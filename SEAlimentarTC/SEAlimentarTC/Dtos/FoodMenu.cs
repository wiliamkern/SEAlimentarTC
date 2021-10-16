using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SEAlimentarTC.Dtos
{
    class FoodMenu
    {
        [Key]
        public int FoodMenuID { get; set; }

        public string Name { get; set; }

        public DateTime? Day { get; set; }

        [ForeignKey("User"), Column(Order = 0)]
        public int UserID {get;set;}

        public DateTime? InsertDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public bool? CanUse { get; set; }
        User User { get; set; }
    }
}
