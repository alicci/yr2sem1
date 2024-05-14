using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZADANIE_2.ModelDanych;

namespace ZADANIE_2.BazaDanych
{
    internal class BazaDanychObsluga : DbContext
    {
        public DbSet<ksiazka> ksiazka { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlite("Data Source=ksiazkaNad.db");
            base.OnConfiguring(dbContextOptionsBuilder);
        }
    }
}
