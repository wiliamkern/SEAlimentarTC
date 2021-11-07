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
    public partial class FoodMenuHistoryList : ContentPage
    {
        public FoodMenuHistoryList()
        {
            InitializeComponent();

            FoodMenuHistoryListData.ItemsSource = new FoodMenuHistoryModel().GetList().OrderByDescending(o => o.MenuDay).ToList();
        }

        private async void ShowFoodMenu(object sender, EventArgs e)
        {
            var data = (ImageCell)sender;
            int FoodMenuID  = (int)data.CommandParameter;
            string FoodMenuDay = data.Text;

            FoodMenu fm = new FoodMenuModel().GetFoodMenuByID(FoodMenuID);

            await Navigation.PushAsync(new FoodMenuData(fm, FoodMenuDay));
        }
    }
}