using SmartRead.Mobile.Helpers;
using SmartRead.Mobile.Services;
using SmartRead.Model;
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
        public ICommand ToggleFavouriteCommand { get; set; }

        private readonly APIService _clanakService = new APIService("clanak");

        public ClanakItemViewModel(int id, string naslov, string autor)
        {
            this.id = id;
            this.naslov = naslov;
            this.autor = autor;
            this.isFavourite = LikesHelper.Get(id);

            ToggleFavouriteCommand = new Command(async () => await ToggleFavourite());
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
    }
}
