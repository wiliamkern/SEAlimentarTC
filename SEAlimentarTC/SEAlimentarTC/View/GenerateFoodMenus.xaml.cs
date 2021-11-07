using Acr.UserDialogs;
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

            FoodMenuHistory fmh = new FoodMenuHistoryModel().GetDataByDate(DateTime.Now);

            if (fmh != null)
            {
                FoodMenu fd = new FoodMenuModel().GetFoodMenuByID(fmh.FoodMenuID);

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

        private void GenerateNewFoodMenus(object sender, EventArgs e)
        {
            Device.BeginInvokeOnMainThread(() => UserDialogs.Instance.ShowLoading("Gerando cardápios. Por favor aguarde!", MaskType.Black));
            _ = Task.Run(() =>
              {
                  new InferenceMachine().Infer();
              }).ContinueWith(result => Device.BeginInvokeOnMainThread(async () =>
              {
                  UserDialogs.Instance.HideLoading();
                  await DisplayAlert("", "Novos cardápios gerados com sucesso!", "OK");
              }));
        }

        private async void GetFoodMenusHistoricList(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FoodMenuHistoryList());
        }
    }
}