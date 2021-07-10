using SmartRead.Mobile.Helpers;
using SmartRead.Mobile.Services;
using SmartRead.Model;
using System;
using System.Diagnostics;
using System.Linq;
using Xamarin.Forms;

namespace SmartRead.Mobile.ViewModels
{
    [QueryProperty(nameof(Id), nameof(Id))]
    public class ClanakDetaljiViewModel : BaseViewModel
    {
        private int id;
        private string naslov;
        private string sadrzaj;
        private byte[] slika;

        private readonly APIService _clanakServis = new APIService("clanak");

        public string Naslov
        {
            get => naslov;
            set => SetProperty(ref naslov, value);
        }

        public string Sadrzaj
        {
            get => sadrzaj;
            set => SetProperty(ref sadrzaj, value);
        }

        private int ocjena;
        public int Ocjena
        {
            get => ocjena;
            set => SetProperty(ref ocjena, value);
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                LoadItemId(value);
            }
        }

        public byte[] Slika
        {
            get => slika;
            set => SetProperty(ref slika, value);
        }

        public async void LoadItemId(int id)
        {
            try
            {
                var item = await _clanakServis.GetById<Clanak>(id);
                Id = item.Id;
                Naslov = item.Naslov;
                Sadrzaj = item.Text;
                Slika = item.Slika;

                var korisnikClanak = await _clanakServis.Get<KorisnikClanak>(null, $"{Id}/ocjena");
                Ocjena = korisnikClanak != null ? korisnikClanak.Ocjena : 0;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
