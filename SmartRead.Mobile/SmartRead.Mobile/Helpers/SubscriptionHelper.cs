using SmartRead.Mobile.Services;
using System.Linq;

namespace SmartRead.Mobile.Helpers
{
    public class SubscriptionHelper
    {
        public static bool Remove(int id)
        {
            var itemToRemove = APIService.PrijavljeniKorisnik.PretplaceneKategorije
                .Where(i => i.KategorijaId == id).FirstOrDefault();

            return APIService.PrijavljeniKorisnik.PretplaceneKategorije.Remove(itemToRemove);
        }

        public static void Add(int id)
        {
            var item = APIService.PrijavljeniKorisnik.PretplaceneKategorije
                .Where(i => i.KategorijaId == id).FirstOrDefault();

            if (item == null)
            {
                APIService.PrijavljeniKorisnik.PretplaceneKategorije.Add(new Model.KorisnikKategorija
                {
                    KategorijaId = id,
                    KorisnikId = APIService.PrijavljeniKorisnik.Id
                });
            }
        }

        public static bool Get(int id)
        {
            return APIService.PrijavljeniKorisnik.PretplaceneKategorije
                .Any(i => i.KategorijaId == id);
        }
    }
}
