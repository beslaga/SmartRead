using SmartRead.Mobile.Services;
using SmartRead.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SmartRead.Mobile.ViewModels
{
    class KategorijeViewModel : BaseViewModel
    {
        private readonly APIService _kategorijeService = new APIService("kategorije");
        public ObservableCollection<KategorijaItemViewModel> Kategorije { get; set; }
        
        public Command LoadItemsCommand { get; }
        public KategorijeViewModel()
        {
            Title = "Kategorije";
            Kategorije = new ObservableCollection<KategorijaItemViewModel>();

            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            
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
                    Kategorije.Add(new KategorijaItemViewModel(item.Id, item.Naziv));
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
