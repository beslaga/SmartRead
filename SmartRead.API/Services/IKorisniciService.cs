using System.Collections.Generic;

namespace SmartRead.API.Services
{
    public interface IKorisniciService
    {
        List<Model.Korisnik> Get();
        Model.Korisnik GetPrijavljeniKorisnik();
        Model.Korisnik Autentifikacija(string username, string password);
        void SetPrijavljeniKorisnik(Model.Korisnik currentUser);
    }
}
