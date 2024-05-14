using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZADANIE_3.ModelDanych
{
    internal class magazyn_produkty
    {
        [Key]
        public int id_produktu { get; set; }
        public string nazwa { get; set; }
        public string jednostka { get; set; }
        public string ilosc { get; set; }
        public string termin_waznosci { get; set; }
    }
}
