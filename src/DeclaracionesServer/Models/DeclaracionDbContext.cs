using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeclaracionesServer.Models
{
    public class DeclaracionDbContext : DbContext
    {
        public DbSet<Declaracion> Declaraciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Declaracion>()
                .Property(b => b.numero_documento)
                .IsRequired();
        }
    }

}
