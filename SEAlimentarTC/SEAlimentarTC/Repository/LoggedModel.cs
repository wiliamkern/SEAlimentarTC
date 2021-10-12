using Android.Content;
using SEAlimentarTC.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SEAlimentarTC.Repository
{
    public class LoggedModel : User
    {
        /**
         * Guarda os dados do usuário numa sessão para reutilizar onde for necessário
         * **/
        public static User LoggedUser
        {
            get
            {
                return (User)Application.Current.Properties["UserSession"];
            }
            set
            {
                Application.Current.Properties["UserSession"] = value;
            }
        }
    }
}
