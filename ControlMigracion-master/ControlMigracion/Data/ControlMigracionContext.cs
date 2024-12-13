using Microsoft.EntityFrameworkCore;
using ControlMigracion.Models;

namespace ControlMigracion.Data
{
    public class ControlMigracionContext : DbContext
    {
        public ControlMigracionContext(DbContextOptions<ControlMigracionContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Viajero> Viajeros { get; set; }
        public DbSet<Viaje> Viajes { get; set; }
        public DbSet<EntradaSalida> EntradasSalidas { get; set; }
        public DbSet<Pais> Paises { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Viajero>().ToTable("Viajero");
            modelBuilder.Entity<Viaje>().ToTable("Viaje");
            modelBuilder.Entity<EntradaSalida>().ToTable("EntradaSalida");
            modelBuilder.Entity<Pais>().ToTable("Pais");
        }
    }
}

