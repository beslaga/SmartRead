using SmartRead.Mobile.Services;
using SmartRead.Model;
using System;
using System.Diagnostics;
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
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
