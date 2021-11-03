﻿using SEAlimentarTC.Dtos;
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

            FoodMenuHistoryListData.ItemsSource = new FoodMenuHistoryModel().GetList();
        }

        private async void ShowFoodMenu(object sender, EventArgs e)
        {
            var data = (ImageCell)sender;
            int FoodMenuID  = (int)data.CommandParameter;
            string FoodMenuDay = data.Text;

            FoodMenu fm = new FoodMenuModel().GetList().Where(w => w.FoodMenuID == FoodMenuID).FirstOrDefault();

            await Navigation.PushAsync(new FoodMenuData(fm, FoodMenuDay));
        }
    }
}