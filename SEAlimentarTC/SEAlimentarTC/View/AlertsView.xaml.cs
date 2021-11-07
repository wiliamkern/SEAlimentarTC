using SEAlimentarTC.Dtos;
using SEAlimentarTC.Repository;
using SEAlimentarTC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SEAlimentarTC.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlertsView : ContentPage
    {
        public AlertsView()
        {
            InitializeComponent();

            ReceiveAlerts.IsChecked = LoggedModel.LoggedUser.ReceiveAlerts.HasValue ? LoggedModel.LoggedUser.ReceiveAlerts.Value : false;
        }

        private async void SaveData(object sender, EventArgs e)
        {
            User user = LoggedModel.LoggedUser;
            user.ReceiveAlerts = ReceiveAlerts.IsChecked;

            await new UserModel().UpdateUserAsync(user);

            await App.Current.MainPage.DisplayAlert("", "Notificações atualizados com sucesso!", "Fechar");

            await Navigation.PushAsync(new MainPage());
        }
    }
}