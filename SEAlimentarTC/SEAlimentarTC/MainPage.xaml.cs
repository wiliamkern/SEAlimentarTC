using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SEAlimentarTC.Model;
using SEAlimentarTC.Repository;
using SEAlimentarTC.Dtos;

[assembly: ExportFont("arial-rounded-mt-bold.ttf", Alias = "ArialRoundedMT")]

namespace SEAlimentarTC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

         /*   new UserModel().InsertUseAsync(new User() { 
                Birthday = DateTime.Parse("2021-02-17"),
                Age = 24,
                Name ="João da Silva Sauro",
                Sex = "M",
                Weight = 78.5m,
                Height = 1.78m,
                Imc = 23.5m
            });
         */
            //User user = new UserModel().GetUserAsync(1).Result;

//            if(user.UserId > 0)
  //          {
    //            LoggedModel.LoggedUser = user; // carrega os dados do usuário para dentro da sessão de login
      //      }// caso contrário chama a tela de cadastro para inserir os dados de usuário
        //    {
          //     // await Navigation.PushAsync(new View.About());
           // }

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
