using Android.Content;
using SEAlimentarTC.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SEAlimentarTC.Model
{
    class LoggedModel : UserModel
    {
        public static User LoggedUser
        {
            get
            {
                return new User();
            }
            set
            {
              
                
            }
        }
    }
}
