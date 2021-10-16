using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SEAlimentarTC.Dtos
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        //  [Column("Name", TypeName = "varchar(30)")]
        public string Name { get; set; }
        //
        public int? Age { get; set; }

        public decimal? Height { get; set; }

        public string Sex { get; set; }

        public decimal? Weight { get; set; }

        public decimal? Imc { get; set; }

        public DateTime? InsertDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        [NotMapped]
        public string ImcFormatted { get { return Imc.HasValue ? $"Seu IMC é " + Imc.Value.ToString("N2") : string.Empty; } }
    }
}
