using Acr.UserDialogs;
using SEAlimentarTC.Dtos;
using SEAlimentarTC.Repository;
using SEAlimentarTC.ViewModel;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SEAlimentarTC.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Config : ContentPage
    {
        public Config()
        {
            Task.Run(() =>
            { // para executar métodos assíncronos (executa numa segunda thred por ser assincrono (o que carrega a UI tá na primeira thred))
                Device.BeginInvokeOnMainThread(async () =>
                { // como está executando assincrona precisa recarregar o elemento que faz referência após a execução
                    User user = await new UserModel().GetUserAsync(1);

                    if (user != null)
                    {
                        BindingContext = user; // manda os dados pra tela

                        if (user.Sex.Equals("M"))
                            SexM.IsChecked = true;
                        else
                            SexF.IsChecked = true;
                    }
                    else
                        DeleteButton.IsVisible = false;
                });
            });

            InitializeComponent();
        }

        private void SexM_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (SexM.IsChecked)
            {
                SexF.IsChecked = false;
            }
        }

        private void SexF_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (SexF.IsChecked)
            {
                SexM.IsChecked = false;
            }
        }

        private void SaveData(object sender, EventArgs e)
        {
            User user = new User();

            Device.BeginInvokeOnMainThread(() => UserDialogs.Instance.ShowLoading("Criando conta. Por favor aguarde!", MaskType.Black));
            _ = Task.Run(async () =>
            {
                if (string.IsNullOrEmpty(Age.Text) || string.IsNullOrEmpty(Name.Text) || string.IsNullOrEmpty(Weight.Text) || string.IsNullOrEmpty(Height.Text)
              || (!SexM.IsChecked && !SexF.IsChecked))
                    await App.Current.MainPage.DisplayAlert("Atenção", "Você precisa preencher todos os campos para prosseguir", "OK");
                else
                {
                    user.Age = !string.IsNullOrEmpty(Age.Text) ? Convert.ToInt32(Age.Text.Trim()) : 0;
                    user.Name = Name.Text;
                    user.Weight = !string.IsNullOrEmpty(Weight.Text) ? decimal.Parse(Weight.Text) : 0;
                    user.Height = !string.IsNullOrEmpty(Height.Text) ? decimal.Parse(Height.Text) : 0;
                    user.Sex = SexM.IsChecked ? "M" : "F";
                    user.Imc = System.Math.Round((decimal)(user.Weight / (user.Height * user.Height)), 2);

                    bool Updated = false;

                    if (LoggedModel.LoggedUser != null)
                    {
                        user.UserID = LoggedModel.LoggedUser.UserID;
                        user.UpdateDate = DateTime.Now;
                        Updated = await new UserModel().UpdateUserAsync(user);
                    }

                    if (Updated)
                        await App.Current.MainPage.DisplayAlert("", "Dados atualizados com sucesso!", "Fechar");
                    else
                    {
                        user.InsertDate = DateTime.Now;
                        user.UserID = 1;
                        user.ReceiveAlerts = true;

                        if (new UserModel().InsertUseAsync(user))
                        {
                            // faz o insert dos cardápios pré definidos
                            if (new FoodMenuModel().GetList().Count == 0)
                            {
                                await new GenerateEnvironmentDefault().InsertAllFoodMenus1600KcalAsync();
                                await new GenerateEnvironmentDefault().InsertAllFoodMenus1800KcalAsync();
                                await new GenerateEnvironmentDefault().InsertAllFoodMenus2000KcalAsync();
                                await new GenerateEnvironmentDefault().InsertAllFoodMenus2200KcalAsync();
                                await new GenerateEnvironmentDefault().InsertAllFoodMenus2500KcalAsync();
                            }

                            await App.Current.MainPage.DisplayAlert("", "Dados salvos com sucesso!", "Fechar");
                        }
                        else
                            await App.Current.MainPage.DisplayAlert("", "Não foi possível salvar os dados", "Fechar");
                    }
                }
            }).ContinueWith(result => Device.BeginInvokeOnMainThread(async () =>
            {
                UserDialogs.Instance.HideLoading();

                // carrega os dados atualizados pra sessão usuário
                LoggedModel.LoggedUser = user;

                if (!CheckImcIsValid(user))
                    await Navigation.PushAsync(new ImcNotValid());
                else
                    await Navigation.PushAsync(new MainPage());
            }));           
            
        }

        public bool CheckImcIsValid(User user)
        {
            bool result = true;

            if (user.Imc.HasValue && user.Imc.Value > (decimal)29.9)
            {
                result = false; //é obesidade
            }
            else if (user.Imc.HasValue && user.Imc.Value < (decimal)18.5)
            {
                result = false; //é magreza
            }

            return result;
        }

        [Obsolete]
        private async void DeleteUser(object sender, EventArgs e)
        {
            var answer = await DisplayAlert("Cuidado", "Ao deletar seu cadastro, todos os seus dados pessoais serão deletados! Deseja continuar?", "Sim", "Não");

            if (answer) // deleta o usuário quaso 
            {
                await new UserModel().DeleteUserAsyncBySqlCommand(LoggedModel.LoggedUser.UserID);

                Thread.CurrentThread.Abort(); // encerra a thred do app
            }
        }
    }
}