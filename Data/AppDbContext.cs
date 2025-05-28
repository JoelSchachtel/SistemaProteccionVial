using GestorMotosRetenidas.Models;
using Microsoft.EntityFrameworkCore;

namespace GestorMotosRetenidas.Data
{

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Moto> Motos { get; set; }
        public DbSet<Titular> Titulares { get; set; }
        public DbSet<Infractor> Infractores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Titular>()
                .HasKey(t => t.DniTitular);

            modelBuilder.Entity<Infractor>()
                .HasKey(i => i.DniInfractor);

            modelBuilder.Entity<Moto>()
                .HasOne(m => m.Titular)
                .WithMany()
                .HasForeignKey(m => m.DniTitular);

            modelBuilder.Entity<Moto>()
                .HasOne(m => m.Infractor)
                .WithMany()
                .HasForeignKey(m => m.DniInfractor);
        }
    }
}

