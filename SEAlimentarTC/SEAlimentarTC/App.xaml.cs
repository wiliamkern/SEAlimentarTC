using Microsoft.EntityFrameworkCore;
using SEAlimentarTC.Dtos;
using SEAlimentarTC.Model;
using SEAlimentarTC.Repository;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SEAlimentarTC
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var pagina = new NavigationPage(
                 new MainPage()
                 );

            MainPage = pagina;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
