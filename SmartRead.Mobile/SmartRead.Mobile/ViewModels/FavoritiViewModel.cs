using SmartRead.Mobile.Services;
using SmartRead.Mobile.Views;
using SmartRead.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SmartRead.Mobile.ViewModels
{
    public class FavoritiViewModel : BaseViewModel
    {
        private ClanakItemViewModel _selectedItem;

        public ObservableCollection<ClanakItemViewModel> Items { get; }
        public Command LoadItemsCommand { get; }
        public Command<ClanakItemViewModel> ItemTapped { get; }

        private readonly APIService _korisniciServis = new APIService("korisnici");

        public FavoritiViewModel()
        {
            Title = "Favoriti";
            Items = new ObservableCollection<ClanakItemViewModel>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            ItemTapped = new Command<ClanakItemViewModel>(OnItemSelected);
        }

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await _korisniciServis.Get<List<Clanak>>(null, $"{APIService.PrijavljeniKorisnik.Id}/likes");
                foreach (var item in items)
                {
                    Items.Add(new ClanakItemViewModel(item.Id, item.Naslov, item.Autor.Ime + " " + item.Autor.Prezime, item.Cijena));
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
            if (item == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(ClanakDetaljiPage)}?{nameof(ClanakDetaljiViewModel.Id)}={item.Id}");
        }
    }
}
