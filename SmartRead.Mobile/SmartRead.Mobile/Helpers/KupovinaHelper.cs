using SmartRead.Mobile.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartRead.Mobile.Helpers
{
    public class KupovinaHelper
    {
        public static void Add(int id)
        {
            var item = APIService.PrijavljeniKorisnik.KorisnikClanci
                .Where(i => i.ClanakId == id).FirstOrDefault();

            if (item == null)
            {
                APIService.PrijavljeniKorisnik.KorisnikClanci.Add(new Model.KorisnikClanak
                {
                    ClanakId = id,
                    KorisnikId = APIService.PrijavljeniKorisnik.Id,
                    Kupljen = true,
                });
            }
            
        }

        public static bool Get(int id)
        {
            var clanak = APIService.PrijavljeniKorisnik?.KorisnikClanci
                .Where(i => i.ClanakId == id).FirstOrDefault();

            if (clanak.Clanak.AutorId == APIService.PrijavljeniKorisnik.Id || clanak.Clanak.Cijena == 0)
            {
                return true;
            }

            return clanak?.Kupljen ?? false;
        }
    }
}
