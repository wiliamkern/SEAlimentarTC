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

        public DateTime? InsertDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public decimal TotalKcal { get; set; }

        public List<Breakfest> BreakfestItems { get; set; }
        public List<MorningSnack> MorningSnackItems { get; set; }
        public List<Lunch> LunchItems { get; set; }
        public List<AfternoonSnack> AfternoonSnackItems { get; set; }
        public List<Dinner> DinnerItems { get; set; }
        public List<AfterDinner> AfterDinnerItems { get; set; }

    }
}
