using SEAlimentarTC.Dtos;
using SEAlimentarTC.Repository;
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
    public partial class Config : ContentPage
    {
        public Config()
        {
            InitializeComponent();
        }

        private void SexM_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (SexM.IsChecked)
            {
                SexF.IsChecked = false;
            }
        }

        private void SexF_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (SexF.IsChecked)
            {
                SexM.IsChecked = false;
            }
        }

        private async void SaveData(object sender, EventArgs e)
        {
            User user = new User();
            user.Age = !string.IsNullOrEmpty(Age.Text) ? Convert.ToInt32(Age.Text.Trim()) : 0;
            user.Name = Name.Text;
            user.Weight = !string.IsNullOrEmpty(Weight.Text) ? decimal.Parse(Weight.Text.Replace(".", ",")) : 0;
            user.Height = !string.IsNullOrEmpty(Height.Text) ? decimal.Parse(Height.Text.Replace(".", ",")) : 0;
            user.Sex = SexM.IsChecked ? "M" : "F";
            user.Imc = System.Math.Round((decimal)(user.Weight / (user.Height * user.Height)), 2);
        //    bool Updated = await new UserModel().UpdateUserAsync(user);

         //   if (!Updated)
             bool atualizado = await new UserModel().InsertUseAsync(user);



        }
    }
}