using Microsoft.EntityFrameworkCore;
using Progetto_BE_S5.Models;

namespace Progetto_BE_S5.Data
{
    public class ProgettoContext : DbContext
    {
        public ProgettoContext(DbContextOptions<ProgettoContext> options) : base(options) { }

        public DbSet<Anagrafica> Anagrafiche { get; set; }
        public DbSet<TipoViolazione> TipiViolazione { get; set; }
        public DbSet<Verbale> Verbali { get; set; }

        // Configura le relazioni di navigazione
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Verbale>()
                .HasOne(v => v.Anagrafica)
                .WithMany()
                .HasForeignKey(v => v.IdAnagrafica)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Verbale>()
                .HasOne(v => v.TipoViolazione)
                .WithMany()
                .HasForeignKey(v => v.IdViolazione)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
