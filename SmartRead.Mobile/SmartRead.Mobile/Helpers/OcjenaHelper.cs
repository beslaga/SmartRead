using SmartRead.Mobile.Services;
using System.Linq;

namespace SmartRead.Mobile.Helpers
{
    public class OcjenaHelper
    {
        public static void Upsert(int id, int ocjena)
        {
            var item = APIService.PrijavljeniKorisnik.KorisnikClanci
                .Where(i => i.ClanakId == id).FirstOrDefault();

            if (item == null)
            {
                APIService.PrijavljeniKorisnik.KorisnikClanci.Add(new Model.KorisnikClanak
                {
                    ClanakId = id,
                    KorisnikId = APIService.PrijavljeniKorisnik.Id,
                    Ocjena = ocjena,
                });
            }
            else
            {
                item.Ocjena = ocjena;
            }
        }

        public static int Get(int id)
        {
            var clanak = APIService.PrijavljeniKorisnik?.KorisnikClanci
                .Where(i => i.ClanakId == id).FirstOrDefault();

            return clanak != null ? clanak.Ocjena : 0;
        }
    }
}
