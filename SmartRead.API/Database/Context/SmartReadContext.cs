using Microsoft.EntityFrameworkCore;

namespace SmartRead.API.Database.Context
{
    public partial class SmartReadContext : DbContext
    {
        public SmartReadContext(DbContextOptions<SmartReadContext> options) : base(options) { }

        public virtual DbSet<Clanak> Clanci { get; set; }
        public virtual DbSet<Drzava> Drzave { get; set; }
        public virtual DbSet<Kategorija> Kategorije { get; set; }
        public virtual DbSet<Korisnik> Korisnici { get; set; }
        public virtual DbSet<KorisnikKategorija> KorisnikKategorije { get; set; }
        public virtual DbSet<KorisnikClanak> KorisnikClanci { get; set; }
        public virtual DbSet<KorisnikPrijava> KorisnikPrijave { get; set; }
        public virtual DbSet<Uplata> Uplate { get; set; }
        public virtual DbSet<Uloga> Uloge { get; set; }
        public virtual DbSet<KorisnikUloga> KorisnikUloge { get; set; }
        public virtual DbSet<ClanakKategorija> ClanakKategorije { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KorisnikKategorija>()
                .HasKey(o => new { o.KorisnikId, o.KategorijaId });

            modelBuilder.Entity<KorisnikClanak>()
                .HasKey(o => new { o.KorisnikId, o.ClanakId });

            modelBuilder.Entity<KorisnikUloga>()
                .HasKey(o => new { o.KorisnikId, o.UlogaId });

            modelBuilder.Entity<ClanakKategorija>()
                .HasKey(o => new { o.ClanakId, o.KategorijaId });

            modelBuilder.Entity<Clanak>()
                .HasOne(o => o.Autor)
                .WithMany(o => o.Clanci);

            //modelBuilder.Model.GetEntityTypes()
            //    .SelectMany(e => e.GetForeignKeys())
            //    .ToList()
            //    .ForEach(r => r.DeleteBehavior = DeleteBehavior.Restrict);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
