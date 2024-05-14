using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.ModelDanych;

namespace WindowsFormsApp1.BazaDanych
{
    class BazaDanychObsluga : DbContext
    {
        public DbSet<pomiar> pomiar { get; set; }
        public DbSet<sensor> sensor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlite("Data Source=pomiaryy.db");
            base.OnConfiguring(dbContextOptionsBuilder);
        }
    }
}
