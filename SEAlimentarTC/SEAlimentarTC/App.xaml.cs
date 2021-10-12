using Microsoft.EntityFrameworkCore;
using SEAlimentarTC.Dtos;
using SEAlimentarTC.Repository;
using SEAlimentarTC.ViewModel;
using System;
using System.Threading.Tasks;
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

            Task.Run(async () =>
            {
                User user = new User();
                user = await new UserModel().GetUserAsync(1);

                LoggedModel.LoggedUser = user; // salva os dados na sessão
            });
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
