using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANKIETA.ModelDanych
{
    internal class Osoby
    {
        [Key]
        public int id_osoby { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string numer_ankiety { get; set; }
        public string odp_1 { get; set; }
        public string odp_2 { get; set; }
    }
}
