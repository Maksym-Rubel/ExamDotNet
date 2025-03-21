using DB_Controller.Entities;
using Microsoft.EntityFrameworkCore;

namespace DB_Controller
{
    public class Data_Conttroler : DbContext
    {
        public Data_Conttroler()
        {
            //this.Database.EnsureDeleted();

            //this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-JELVTGO\SQLEXPRESS;
                                        Initial Catalog = MusicDb16;
                                        Integrated Security=True;
                                        Connect Timeout=2;Encrypt=False;
                                        Trust Server Certificate=True;
                                        Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Selles>()
                .HasOne(c => c.Account)
                .WithMany(w => w.Selles)
                .HasForeignKey(c => c.AccountId);
            modelBuilder.Entity<Record>()
                .HasOne(c => c.Artist)
                .WithMany(w => w.Records)
                .HasForeignKey(c => c.ArtistId);
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Artist> Artists { get; set; }

        public DbSet<Record> Records { get; set; }
        public DbSet<Arhive> Arhives { get; set; }
        public DbSet<Selles> Selles { get; set; }

    }
}
