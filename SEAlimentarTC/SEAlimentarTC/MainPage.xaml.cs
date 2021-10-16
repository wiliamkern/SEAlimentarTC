using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SEAlimentarTC.Repository;
using SEAlimentarTC.Dtos;
using SEAlimentarTC.ViewModel;

[assembly: ExportFont("arial-rounded-mt-bold.ttf", Alias = "ArialRoundedMT")]

namespace SEAlimentarTC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing() // quando abre a view verifica se existe usuario, senão apresenta os termos de uso
        { 
            Task.Run(() =>
            { 
                Device.BeginInvokeOnMainThread(async () =>
                { 
                    User user = await new UserModel().GetUserAsync(1);

                    if (user == null)
                        await Navigation.PushAsync(new View.TermosDeUso());
                });
            });
        }

        private async void GetAboutView(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.About());
        }

        private async void GetConfigurationView(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.Config());
        }

        private async void GetGenerateFoodMenuView(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.GenerateFoodMenus());
        }

        private async void ReadUserTerms(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new View.TermosDeUso());
        }
    }
}
