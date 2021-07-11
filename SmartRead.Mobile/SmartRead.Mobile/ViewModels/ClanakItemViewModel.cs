using SmartRead.Mobile.Helpers;
using SmartRead.Mobile.Services;
using SmartRead.Model;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SmartRead.Mobile.ViewModels
{
    public class ClanakItemViewModel : BaseViewModel
    {
        private int id;
        private string naslov;
        private string autor;
        private bool isFavourite;
        private double cijena;
        private bool isKupljen;
        public ICommand ToggleFavouriteCommand { get; set; }
        public ICommand KupiCommand { get; set; }

        private readonly APIService _clanakService = new APIService("clanak");

        public ClanakItemViewModel(int id, string naslov, string autor, double cijena)
        {
            this.id = id;
            this.naslov = naslov;
            this.autor = autor;
            this.cijena = cijena;

            this.isFavourite = LikesHelper.Get(id);
            this.isKupljen = KupovinaHelper.Get(id);

            ToggleFavouriteCommand = new Command(async () => await ToggleFavourite());
            KupiCommand = new Command(async () => await KupiClanak());
        }

        public bool IsFavourite
        {
            get { return isFavourite; }
            set
            {
                isFavourite = value;
                OnPropertyChanged(nameof(IsFavouriteImage));
            }
        }

        public string IsFavouriteImage
        {
            get => IsFavourite ? "heart-filled.png" : "heart-empty.png";

        }

        public string Naslov
        {
            get => naslov;
            set => SetProperty(ref naslov, value);
        }

        public string Autor
        {
            get => autor;
            set => SetProperty(ref autor, value);
        }

        public int Id
        {
            get => id;
            set => SetProperty(ref id, value);
        }

        public double Cijena
        {
            get => Math.Round(cijena, 2);
            set => SetProperty(ref cijena, value);
        }

        public bool IsKupljen
        {
            get => isKupljen;
            set => SetProperty(ref isKupljen, value);
        }

        private async Task ToggleFavourite()
        {
            try
            {
                if (IsFavourite)
                {
                    await _clanakService.Insert<bool>(null, $"{id}/dislike");
                    LikesHelper.Remove(id);
                    IsFavourite = false;
                }
                else
                {
                    await _clanakService.Insert<Like>(null, $"{id}/like");
                    LikesHelper.Add(id);
                    IsFavourite = true;
                }

            }
            catch
            {

            }
        }

        private async Task KupiClanak()
        {
            try
            {
                if (!IsKupljen)
                {
                    await _clanakService.Insert<bool>(null, $"{id}/kupi");
                    KupovinaHelper.Add(id);
                    IsKupljen = true;
                }
            }
            catch
            {

            }
        }
    }
}
