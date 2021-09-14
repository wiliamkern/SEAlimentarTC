using System;
using System.Collections.Generic;
using System.Text;

namespace SEAlimentarTC.Dtos
{
    class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime Birthday { get; set; }
        public decimal Height { get; set; }
        public bool Sex { get; set; }
        public decimal Weight { get; set; }
        public decimal Imc { get; set; }
    }
}
