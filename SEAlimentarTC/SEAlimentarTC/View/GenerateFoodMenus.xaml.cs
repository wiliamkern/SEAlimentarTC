using SEAlimentarTC.Dtos;
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
    public partial class GenerateFoodMenus : ContentPage
    {
        public GenerateFoodMenus()
        {
            InitializeComponent();

            FoodMenuHistory fmh = new FoodMenuHistoryModel().GetList().Where(w => w.MenuDay.Value.Date == DateTime.Now.Date).FirstOrDefault();

            if (fmh != null)
            {
                FoodMenu fd = new FoodMenuModel().GetList().Where(w => w.FoodMenuID == fmh.FoodMenuID).FirstOrDefault();

                string breakfest = string.Empty;
                foreach (Breakfest item in fd.BreakfestItems)
                {
                    breakfest += $"{item.ItemName} \r\n \r\n";
                }
                Breakfest.Text = breakfest;

                string morningSnack = string.Empty;
                foreach (MorningSnack item in fd.MorningSnackItems)
                {
                    morningSnack += $"{item.ItemName} \r\n \r\n";
                }
                MorningSnack.Text = morningSnack;

                string lunch = string.Empty;
                foreach (Lunch item in fd.LunchItems)
                {
                    lunch += $"{item.ItemName} \r\n \r\n";
                }
                Lunch.Text = lunch;

                string afternoonSnack = string.Empty;
                foreach (AfternoonSnack item in fd.AfternoonSnackItems)
                {
                    afternoonSnack += $"{item.ItemName} \r\n \r\n";
                }
                AfternoonSnack.Text = afternoonSnack;

                string dinner = string.Empty;
                foreach (Dinner item in fd.DinnerItems)
                {
                    dinner += $"{item.ItemName} \r\n \r\n";
                }
                Dinner.Text = dinner;

                string afterDinner = string.Empty;
                foreach (AfterDinner item in fd.AfterDinnerItems)
                {
                    afterDinner += $"{item.ItemName} \r\n \r\n";
                }
                AfterDinner.Text = afterDinner;
            }
        }

        private async void GenerateNewFoodMenus(object sender, EventArgs e)
        {
            // chama classe que realiza as operações de inferência em cima dos dados do banco
            new InferenceMachine().Infer();

            await App.Current.MainPage.DisplayAlert("", "Novos cardápios gerados com sucesso!", "OK");
        }

        private async void GetFoodMenusHistoricList(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FoodMenuHistoryList());
        }
    }
}