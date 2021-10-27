using System;
using System.Collections.Generic;
using System.Text;

namespace SEAlimentarTC.Dtos
{
    public class Lunch
    {
        public int LunchID { get; set; }

        public string ItemName { get; set; }

        public bool IsChecked { get; set; }

        public DateTime? InsertDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public FoodMenu FoodMenu { get; set; }
    }
}
