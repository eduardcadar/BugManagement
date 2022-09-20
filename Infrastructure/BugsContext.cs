using BugInfrastructure.DBEntities;
using Microsoft.EntityFrameworkCore;

namespace BugInfrastructure
{
    public class BugsContext : DbContext
    {
        public DbSet<DBAngajat> Employees { get; set; }
        public DbSet<DBBug> Bugs { get; set; }
        public DbSet<DBPasBug> Steps { get; set; }
        public DbSet<DBMesaj> Messages { get; set; }
        public BugsContext(DbContextOptions op) : base(op) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DBPasBug>()
                .HasKey(p => new { p.BugId, p.PasNumber });
            modelBuilder.Entity<DBMesaj>()
                .HasOne(m => m.Sender)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<DBMesaj>()
                .HasOne(m => m.Receiver)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
