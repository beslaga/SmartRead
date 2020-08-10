using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace SmartRead.API.Database.Context
{
    public partial class SmartReadContext : DbContext
    {
        public SmartReadContext(DbContextOptions<SmartReadContext> options) : base(options) { }

        public virtual DbSet<Administrator> Administratori { get; set; }
        public virtual DbSet<Clanak> Clanci { get; set; }
        public virtual DbSet<Drzava> Drzave { get; set; }
        public virtual DbSet<Kategorija> Kategorije { get; set; }
        public virtual DbSet<Korisnik> Korisnici { get; set; }
        public virtual DbSet<KorisnikKategorija> KorisnikKategorije { get; set; }
        public virtual DbSet<KorisnikPrijava> KorisnikPrijave { get; set; }
        public virtual DbSet<Uplata> Uplate { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KorisnikKategorija>().HasKey(o => new { o.KorisnikId, o.KategorijaId });
            modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()).ToList().ForEach(r => r.DeleteBehavior = DeleteBehavior.Restrict);
            base.OnModelCreating(modelBuilder);
        }
    }
}
