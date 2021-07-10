using AutoMapper;
using SmartRead.API.Database;
using SmartRead.Model.Requests;

namespace SmartRead.API.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Clanak, Model.Clanak>();
            CreateMap<Drzava, Model.Drzava>();
            CreateMap<Like, Model.Like>();
            CreateMap<Kategorija, Model.Kategorija>();
            CreateMap<Korisnik, Model.Korisnik>();
            CreateMap<KorisnikKategorija, Model.KorisnikKategorija>();
            CreateMap<KorisnikPrijava, Model.KorisnikPrijava>();
            CreateMap<Uplata, Model.Uplata>();
            CreateMap<Uloga, Model.Uloga>();
            CreateMap<KorisnikUloga, Model.KorisnikUloga>();
            CreateMap<KorisnikClanak, Model.KorisnikClanak>();
            CreateMap<ClanakKategorija, Model.ClanakKategorija>();

            CreateMap<Kategorija, KategorijaUpsertRequest>().ReverseMap();
            CreateMap<ClanakInsertRequest, Clanak>().ReverseMap();
            CreateMap<ClanakUpdateRequest, Clanak>()
                .ForMember(dest => dest.Kategorije, opt => opt.Ignore());
            CreateMap<KorisnikInsertRequest, Korisnik>()
                .ForMember(dest => dest.Uloge, opt => opt.Ignore());

            CreateMap<KorisnikUpdateRequest, Korisnik>()
                .ForMember(dest => dest.Uloge, opt => opt.Ignore());
        }
    }
}
