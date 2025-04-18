using FerraFilterCase.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FerraFilterCase.DataAccess.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=ANIL\SQLEXPRESS;Database=FerraDb;Trusted_Connection=True;TrustServerCertificate=True");
        }

        public DbSet<Ferra_orjinal_muadil> ferra_orjinal_muadil { get; set; }
        public DbSet<Filters> filtreler { get; set; }
    }
}
