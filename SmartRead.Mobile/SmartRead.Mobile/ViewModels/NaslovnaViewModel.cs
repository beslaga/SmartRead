using SmartRead.Mobile.Services;
using SmartRead.Mobile.Views;
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
    public class NaslovnaViewModel : BaseViewModel
    {
        private ClanakItemViewModel _selectedItem;

        public ObservableCollection<ClanakItemViewModel> Items { get; set; }
        public ObservableCollection<Kategorija> Kategorije { get; set; }
        public Command LoadItemsCommand { get; }
        public Command SearchCommand { get; set; }
        public Command<ClanakItemViewModel> ItemTapped { get; }

        private readonly APIService _clanakServis = new APIService("clanak");
        private readonly APIService _kategorijaServis = new APIService("kategorije");

        public Kategorija kategorija;
        public Kategorija Kategorija
        {
            get { return kategorija; }
            set { SetProperty(ref kategorija, value); }
        }


        public string search;
        public string Search
        {
            get { return search; }
            set { SetProperty(ref search, value); }
        }


        public NaslovnaViewModel()
        {
            Title = "Naslovna";
            Items = new ObservableCollection<ClanakItemViewModel>();
            Kategorije = new ObservableCollection<Kategorija>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            SearchCommand = new Command(async () => await ExecuteSearchCommand());

            ItemTapped = new Command<ClanakItemViewModel>(OnItemSelected);
        }

        private async Task ExecuteSearchCommand()
        {
            IsBusy = true;

            try
            {
                var request = new ClanakSearchRequest
                {
                    Search = search,
                    KategorijaId = Kategorija != null ? Kategorija.Id : 0
                };

                Items.Clear();
                var items = await _clanakServis.Get<List<Clanak>>(request);
                foreach (var item in items)
                {
                    Items.Add(
                        new ClanakItemViewModel(item.Id, item.Naslov, item.Autor.Ime + " " + item.Autor.Prezime, item.Cijena));
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

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                if (!string.IsNullOrEmpty(search) || kategorija?.Id == 0) return;

                Items.Clear();
                var items = await _clanakServis.Get<List<Clanak>>(null, "recommend");
                foreach (var item in items)
                {
                    Items.Add(new ClanakItemViewModel(item.Id, item.Naslov, item.Autor.Ime + " " + item.Autor.Prezime, item.Cijena));
                }

                Kategorije.Clear();
                var kategorije = await _kategorijaServis.Get<List<Kategorija>>(null);
                foreach (var kategorija in kategorije)
                {
                    Kategorije.Add(kategorija);
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

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedItem = null;
        }

        public ClanakItemViewModel SelectedItem
        {
            get => _selectedItem;
            set
            {
                SetProperty(ref _selectedItem, value);
                OnItemSelected(value);
            }
        }

        async void OnItemSelected(ClanakItemViewModel item)
        {
            if (item == null || (item.Cijena > 0 && item.IsKupljen == false))
                return;

            // This will push the ItemDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(ClanakDetaljiPage)}?{nameof(ClanakDetaljiViewModel.Id)}={item.Id}");
        }
    }
}
