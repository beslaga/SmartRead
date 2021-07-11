using SmartRead.Mobile.Helpers;
using SmartRead.Mobile.Services;
using SmartRead.Model;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SmartRead.Mobile.ViewModels
{
    public class KategorijaItemViewModel : BaseViewModel
    {
        private readonly APIService _kategorijeService = new APIService("kategorije");
        public KategorijaItemViewModel(int id, string naziv)
        {
            this.id = id;
            this.naziv = naziv;

            isSubscribed = SubscriptionHelper.Get(id);

            ToggleSubscribeCommand = new Command(async () => await ToggleSubscribe());
        }

        private int id;
        public int Id
        {
            get => id;
            set => SetProperty(ref id, value);
        }

        private string naziv;
        public string Naziv
        {
            get => naziv;
            set => SetProperty(ref naziv, value);
        }

        public Command ToggleSubscribeCommand { get; set; }

        private bool isSubscribed;
        public bool IsSubscribed
        {
            get { return isSubscribed; }
            set
            {
                isSubscribed = value;
                OnPropertyChanged(nameof(IsSubscribedImage));
            }
        }

        public string IsSubscribedImage
        {
            get => IsSubscribed ? "bell-filled.png" : "bell-empty.png";

        }

        private async Task ToggleSubscribe()
        {
            try
            {
                if (IsSubscribed)
                {
                    await _kategorijeService.Insert<bool>(null, $"{id}/unsubscribe");
                    SubscriptionHelper.Remove(id);
                    IsSubscribed = false;
                }
                else
                {
                    await _kategorijeService.Insert<KorisnikKategorija>(null, $"{id}/subscribe");
                    SubscriptionHelper.Add(id);
                    IsSubscribed = true;
                }

            }
            catch
            {

            }
        }
    }
}
