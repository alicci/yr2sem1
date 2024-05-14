using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ANKIETA.ModelDanych;

namespace ANKIETA.BazaDanych
{
    internal class BazaDanychObsluga : DbContext
    {
        public DbSet<Osoby> Osoby { get; set; }

        public DbSet<Ankiety> Ankiety { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlite("Data Source=Baza_danych.db");
            base.OnConfiguring(dbContextOptionsBuilder);
        }
    }
}
