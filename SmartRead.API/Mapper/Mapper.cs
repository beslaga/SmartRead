using AutoMapper;
using SmartRead.API.Database;

namespace SmartRead.API.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Clanak, Model.Clanak>();
            CreateMap<Drzava, Model.Drzava>();
            CreateMap<Kategorija, Model.Kategorija>();
            CreateMap<Korisnik, Model.Korisnik>();
            CreateMap<KorisnikKategorija, Model.KorisnikKategorija>();
            CreateMap<KorisnikPrijava, Model.KorisnikPrijava>();
            CreateMap<Uplata, Model.Uplata>();
            CreateMap<Uloga, Model.Uloga>();
            CreateMap<KorisnikUloga, Model.KorisnikUloga>();

            CreateMap<Kategorija, Model.Requests.KategorijaUpsertRequest>().ReverseMap();
        }
    }
}
