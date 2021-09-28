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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }

        //  [Column("Name", TypeName = "varchar(30)")]
        public string Name { get; set; }
        //
        //      [Column("Age", TypeName = "integer(3)")]
        public int? Age { get; set; }

        //     [Column("Height", TypeName = "decimal(1,2)")]
        public decimal? Height { get; set; }

        //   [Column("Sex", TypeName = "char(1)")]
        public string Sex { get; set; }

        // [Column("Weight", TypeName = "decimal(3,2)")]
        public decimal? Weight { get; set; }

        // [Column("Imc", TypeName = "decimal(2,2)")]
        public decimal? Imc { get; set; }
        public object Id { get; internal set; }
    }
}
