using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZADANIE_2.ModelDanych
{
    internal class ksiazka
    {
        [Key]
        public int id_adresata { get; set; }
        public string nazwa1 { get; set; }
        public string email { get; set; }
        public string miasto { get; set; }
    }
}
