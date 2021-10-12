using SEAlimentarTC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SEAlimentarTC.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImcNotValid : ContentPage
    {
        public ImcNotValid()
        {
            InitializeComponent();

            Task.Run(async () =>
            {
                await new UserModel().DeleteUserAsync(1);
            });
        }

        private void CloseApp(object sender, EventArgs e)
        {
            Thread.CurrentThread.Abort(); // encerra a thred do app
        }

        protected override bool OnBackButtonPressed()
        {
            return true; // retornando true não deixa retonar 
        }
    }
}