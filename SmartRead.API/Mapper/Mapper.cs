using AutoMapper;
using SmartRead.API.Database;

namespace SmartRead.API.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Administrator, Model.Administrator>();
            CreateMap<Clanak, Model.Clanak>();
            CreateMap<Drzava, Model.Drzava>();
            CreateMap<Kategorija, Model.Kategorija>();
            CreateMap<Korisnik, Model.Korisnik>();
            CreateMap<KorisnikKategorija, Model.KorisnikKategorija>();
            CreateMap<KorisnikPrijava, Model.KorisnikPrijava>();
            CreateMap<Uplata, Model.Uplata>();

            CreateMap<Kategorija, Model.Requests.KategorijaInsertRequest>().ReverseMap();
        }
    }
}
