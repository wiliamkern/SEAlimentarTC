using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SEAlimentarTC.Dtos
{
    public class FoodMenuHistory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FoodMenuHistoryID { get; set; }

        public int FoodMenuID { get; set; }

        public DateTime? MenuDay { get; set; }

        public bool IsChecked { get; set; }

        public DateTime? InsertDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public decimal TotalKcal { get; set; }

        public FoodMenu FoodMenuData { get; set; }
    }
}
