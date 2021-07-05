using SmartRead.Mobile.Services;
using System.Linq;

namespace SmartRead.Mobile.Helpers
{
    public class LikesHelper
    {
        private readonly APIService _korisnikService = new APIService("korisnik");
        public static bool Remove(int id)
        {
            var itemToRemove = APIService.PrijavljeniKorisnik.Likes
                .Where(i => i.ClanakId == id).FirstOrDefault();

            return APIService.PrijavljeniKorisnik.Likes.Remove(itemToRemove);
        }

        public static void Add(int id)
        {
            var item = APIService.PrijavljeniKorisnik.Likes
                .Where(i => i.ClanakId == id).FirstOrDefault();

            if (item == null)
            {
                APIService.PrijavljeniKorisnik.Likes.Add(new Model.Like
                {
                    ClanakId = id,
                    KorisnikId = APIService.PrijavljeniKorisnik.Id
                });
            }
        }

        public static bool Get(int id)
        {
            return APIService.PrijavljeniKorisnik.Likes
                .Any(i => i.ClanakId == id);
        }
    }
}
