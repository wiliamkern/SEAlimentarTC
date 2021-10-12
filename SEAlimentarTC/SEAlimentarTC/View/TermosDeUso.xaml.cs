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
    public partial class TermosDeUso : ContentPage
    {
        public TermosDeUso()
        {
            InitializeComponent();
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
    }
}