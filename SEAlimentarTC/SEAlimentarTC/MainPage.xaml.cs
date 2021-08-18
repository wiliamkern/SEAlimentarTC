using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SEAlimentarTC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
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
    }
}
