using SmartRead.Mobile.Helpers;
using SmartRead.Mobile.Services;
using SmartRead.Model;
using SmartRead.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SmartRead.Mobile.ViewModels
{
    public class NoviClanakViewModel : BaseViewModel
    {
        private readonly APIService _kategorijeService = new APIService("kategorije");
        private readonly APIService _clanakService = new APIService("clanak");
        public Command PromijeniSliku { get; set; }
        public Command Spasi { get; set; }
        
        public ObservableCollection<SelectableKategorijaViewModel> Kategorije { get; set; }

        public Command LoadItemsCommand { get; }
        public NoviClanakViewModel()
        {
            Title = "Novi Članak";

            Kategorije = new ObservableCollection<SelectableKategorijaViewModel>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            PromijeniSliku = new Command(async () => await OnTapped());
            Spasi = new Command(async () => await SpasiClanak());
        }

        private async Task SpasiClanak()
        {
            var kategorije = new List<int>();

            foreach (var item in Kategorije)
            {
                if (item.Selected)
                {
                    kategorije.Add(item.Kategorija.Id);
                }
            }

            var request = new ClanakInsertRequest
            {
                Naslov = Naslov,
                Text = Text,
                Slika = Slika,
                AutorId = APIService.PrijavljeniKorisnik.Id,
                Cijena = Cijena,
                Kategorije = kategorije
            };

            try
            {
                await _clanakService.Insert<Clanak>(request);
                await Application.Current.MainPage.DisplayAlert("Success", "Uspješno kreiran članak.", "OK");
            }
            catch
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Pogrešni podatci.", "OK");
            }
        }

        private async Task OnTapped()
        {
            Slika = await ImageHelper.UploadImage(Slika);
        }

        private string naslov;
        public string Naslov
        {
            get => naslov;
            set => SetProperty(ref naslov, value);
        }

        private string text;
        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        private double cijena;
        public double Cijena
        {
            get => cijena;
            set => SetProperty(ref cijena, value);
        }

        private byte[] slika;
        public byte[] Slika
        {
            get { return slika; }
            set { SetProperty(ref slika, value); }
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }

        private async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                Kategorije.Clear();
                var items = await _kategorijeService.Get<List<Kategorija>>(null);
                foreach (var item in items)
                {
                    Kategorije.Add(new SelectableKategorijaViewModel
                    { 
                        Kategorija = item,
                        Selected = false
                    });
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
