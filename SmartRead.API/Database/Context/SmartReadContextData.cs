using Microsoft.EntityFrameworkCore;
using SmartRead.API.Helpers;
using SmartRead.API.Security;

namespace SmartRead.API.Database.Context
{
    public partial class SmartReadContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Drzava>()
                .HasData
                (
                    new Drzava { Id = 1, Naziv = "Bosna i Hercegovina"},
                    new Drzava { Id = 2, Naziv = "Hrvatska"}
                );

            var salt = HashHelper.GenerateSalt();

            modelBuilder.Entity<Korisnik>()
                .HasData
                (
                    new Korisnik
                    {
                        Id = 1,
                        Ime = "Maid",
                        Prezime = "Bešlagić",
                        PasswordSalt = salt,
                        PasswordHash = HashHelper.GenerateHash(salt, "test"),
                        DrzavaId = 1,
                        Username = "maid",
                        Mail = "maid.beslagic@edu.fit.ba"
                    }
                );

            modelBuilder.Entity<Uloga>()
                .HasData
                (
                    new Uloga{Id = 1, Naziv = Roles.Administrator},
                    new Uloga{Id = 2, Naziv = Roles.BasicUser}
                );

            modelBuilder.Entity<KorisnikUloga>()
                .HasData
                (
                    new KorisnikUloga { KorisnikId = 1, UlogaId = 1},
                    new KorisnikUloga { KorisnikId = 1, UlogaId = 2}
                );
        }
    }
}
