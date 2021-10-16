using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEAlimentarTC.Repository;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SEAlimentarTC.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TermosDeUso : ContentPage
    {
        public TermosDeUso()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            if(LoggedModel.LoggedUser != null)
            {
                btnContinue.IsVisible = false;
                checkTerms.IsVisible = false;
                btnReturn.IsVisible = true;
            }
            else
            {
                btnContinue.IsVisible = true;
                checkTerms.IsVisible = true;
                btnReturn.IsVisible = false;
            }
        }

        private void AcceptTerms(object sender, EventArgs e)
        {
            if (!AcceptUseTerms.IsChecked)
            {
                errorUseTerms.IsVisible = true;
            }
            else
            {
                Navigation.PushAsync(new Config());
            }
        }

        private async void Voltar(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}