using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Text;

namespace SEAlimentarTC.Dtos
{
    public class FoodMenuHistory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FoodMenuHistoryID { get; set; }

        public int FoodMenuID { get; set; }

        public DateTime? MenuDay { get; set; }

        public DateTime? InsertDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public decimal TotalKcal { get; set; }

        [NotMapped]
        public string MenuDayString
        {
            get
            {
                if (MenuDay.HasValue)
                {
                    CultureInfo culture = new CultureInfo("pt-BR");
                    string dayName = culture.DateTimeFormat.GetDayName(MenuDay.Value.DayOfWeek);

                    return $"Refeição de {dayName} {MenuDay.Value.Date.ToString("dd/MM/yyyy")}";
                }
                else
                    return string.Empty;
            }
        }

        public FoodMenu FoodMenuData { get; set; }
    }
}
