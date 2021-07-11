using Bogus;
using Microsoft.EntityFrameworkCore;
using SmartRead.API.Helpers;
using SmartRead.API.Security;
using System;
using System.Collections.Generic;

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

            modelBuilder.Entity<Kategorija>()
                .HasData
                (
                    new Kategorija { Id = 1, Naziv = "Tehnologija", },
                    new Kategorija { Id = 2, Naziv = "Sport" }
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
                    },
                    new Korisnik
                    {
                        Id = 2,
                        Ime = "Desktop",
                        Prezime = "Admin",
                        PasswordSalt = salt,
                        PasswordHash = HashHelper.GenerateHash(salt, "test"),
                        DrzavaId = 1,
                        Username = "desktop",
                        Mail = "desktop@edu.fit.ba"
                    },
                    new Korisnik
                    {
                        Id = 3,
                        Ime = "Mobile",
                        Prezime = "User",
                        PasswordSalt = salt,
                        PasswordHash = HashHelper.GenerateHash(salt, "test"),
                        DrzavaId = 1,
                        Username = "mobile",
                        Mail = "mobile@edu.fit.ba"
                    },
                    new Korisnik
                    {
                        Id = 4,
                        Ime = "Mobile",
                        Prezime = "User",
                        PasswordSalt = salt,
                        PasswordHash = HashHelper.GenerateHash(salt, "test"),
                        DrzavaId = 1,
                        Username = "mobile1",
                        Mail = "mobile1@edu.fit.ba"
                    },
                    new Korisnik
                    {
                        Id = 5,
                        Ime = "Mobile",
                        Prezime = "User",
                        PasswordSalt = salt,
                        PasswordHash = HashHelper.GenerateHash(salt, "test"),
                        DrzavaId = 1,
                        Username = "mobile2",
                        Mail = "mobile2@edu.fit.ba"
                    },
                    new Korisnik
                    {
                        Id = 6,
                        Ime = "Mobile",
                        Prezime = "User",
                        PasswordSalt = salt,
                        PasswordHash = HashHelper.GenerateHash(salt, "test"),
                        DrzavaId = 1,
                        Username = "mobile3",
                        Mail = "mobile3@edu.fit.ba"
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
                    new KorisnikUloga { KorisnikId = 1, UlogaId = 2},
                    new KorisnikUloga { KorisnikId = 2, UlogaId = 1},
                    new KorisnikUloga { KorisnikId = 3, UlogaId = 2},
                    new KorisnikUloga { KorisnikId = 4, UlogaId = 2},
                    new KorisnikUloga { KorisnikId = 5, UlogaId = 2},
                    new KorisnikUloga { KorisnikId = 6, UlogaId = 2}
                );

            var clanakFaker = new Faker<Clanak>()
                .RuleFor(i => i.AutorId, 2)
                .RuleFor(i => i.Naslov, i => i.Lorem.Sentence())
                .RuleFor(i => i.OdobravateljId, i => 1)
                .RuleFor(i => i.Text, i => i.Lorem.Text())
                .RuleFor(i => i.Odobren, true)
                .RuleFor(i => i.Cijena, 0);


            var clanci = new List<Clanak>();
            for (int i = 1; i <= 50; i++)
            {
                var clanak = clanakFaker.Generate();
                clanak.Id = i;
                clanak.AutorId = new Random().Next(1, 6);
                clanci.Add(clanak);
            }

            modelBuilder.Entity<Clanak>()
                .HasData(clanci);

            var korisnikClanakList = new List<KorisnikClanak>();
            for(int i = 1; i <= 50; i++)
            {
                for(int j = 1; j <= 6; j++)
                {
                    var korisnikClank = new KorisnikClanak
                    {
                        ClanakId = i,
                        KorisnikId = j,
                        BrojPosjeta = new Random().Next(0, 5),
                        Ocjena = new Random().Next(0, 5)
                    };

                    korisnikClanakList.Add(korisnikClank);
                }
            }

            modelBuilder.Entity<KorisnikClanak>()
                .HasData(korisnikClanakList);
        }
    }
}
