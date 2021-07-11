using SmartRead.Mobile.Helpers;
using SmartRead.Mobile.Services;
using SmartRead.Model;
using SmartRead.Model.Requests;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
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

        public Command PrijaviClanakCommand { get; set; }

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

        public ClanakDetaljiViewModel()
        {
            PrijaviClanakCommand = new Command(async () => await PrijaviClanak());
        }

        private async Task PrijaviClanak()
        {
            string result = await Application.Current.MainPage.DisplayPromptAsync(
                "Prijava", "Navedite razlog prijave članka.");

            if (!string.IsNullOrEmpty(result))
            {
                var request = new ClanakPrijavaRequest
                {
                    Opis = result
                };

                await _clanakServis.Insert<KorisnikPrijava>(request, $"{id}/prijavi");
            }
        }

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
