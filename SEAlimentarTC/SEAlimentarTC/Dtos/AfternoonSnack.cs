using System;
using System.Collections.Generic;
using System.Text;

namespace SEAlimentarTC.Dtos
{
    public class AfternoonSnack
    {
        public int AfternoonSnackID { get; set; }
        public int FoodMenuID { get; set; }

        public string ItemName { get; set; }

        public bool IsChecked { get; set; }

        public DateTime? InsertDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public FoodMenu FoodMenu { get; set; }
    }
}
