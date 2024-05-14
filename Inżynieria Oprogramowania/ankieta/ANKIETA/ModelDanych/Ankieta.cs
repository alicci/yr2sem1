using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANKIETA.ModelDanych
{
    internal class Ankiety
    {
        [Key]
        public int nr_ankiety { get; set; }
        public int id_osoby  { get; set; }
    }
}
