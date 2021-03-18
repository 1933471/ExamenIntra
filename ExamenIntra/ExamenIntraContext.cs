using System;
using System.Collections.Generic;
using System.Text;
using ExamenIntra.partieLinq;
using Microsoft.EntityFrameworkCore;

namespace ExamenIntra
{

    public class ExamenIntraContext : DbContext
    {
        public DbSet<Fruit> Fruits { get; set; }
        public DbSet<Personne> Personnes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ExamenIntra;Trusted_Connection = True;");
    }
}
