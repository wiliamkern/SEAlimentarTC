using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SEAlimentarTC.Dtos
{
    public class AfterDinner
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AfterDinnerID { get; set; }
        public int FoodMenuID { get; set; }

        public string ItemName { get; set; }

        public DateTime? InsertDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public FoodMenu FoodMenu { get; set; }
    }
}
