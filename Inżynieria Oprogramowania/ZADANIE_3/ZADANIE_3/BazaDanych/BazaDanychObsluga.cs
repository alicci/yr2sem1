using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZADANIE_3.ModelDanych;

namespace ZADANIE_3.BazaDanych
{
    internal class BazaDanychObsluga : DbContext
    {
        
            public DbSet<magazyn_produkty> magazyn_produkty { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
            {
                dbContextOptionsBuilder.UseSqlite("Data Source=magazyn.db");
                base.OnConfiguring(dbContextOptionsBuilder);
            }
        
    }
}
