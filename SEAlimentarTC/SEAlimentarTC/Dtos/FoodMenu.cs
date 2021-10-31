using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SEAlimentarTC.Dtos
{
    public class FoodMenu
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FoodMenuID { get; set; }

        public DateTime? MenuDay { get; set; }

        public bool IsChecked { get; set; }

        public DateTime? InsertDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public decimal TotalKcal { get; set; }

        List<Breakfest> BreakfestItems { get; set; }
        List<MorningSnack> MorningSnackItems { get; set; }
        List<Lunch> LunchItems { get; set; }
        List<AfternoonSnack> AfternoonSnackItems { get; set; }
        List<Dinner> DinnerItems { get; set; }
        List<AfterDinner> AfterDinnerItems { get; set; }

    }
}
