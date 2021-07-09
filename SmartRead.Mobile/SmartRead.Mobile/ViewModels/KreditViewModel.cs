using SmartRead.Mobile.Services;
using SmartRead.Model.Requests;
using Xamarin.Forms;

namespace SmartRead.Mobile.ViewModels
{
    public class KreditViewModel : BaseViewModel
    {
        private readonly APIService _serviceKorisnici = new APIService("korisnici");

        string brojKartice;
        public string BrojKartice
        {
            get { return brojKartice; }
            set { SetProperty(ref brojKartice, value); }
        }

        string cvc;
        public string Cvc
        {
            get { return cvc; }
            set { SetProperty(ref cvc, value); }
        }

        int mjesecIsteka;
        public int MjesecIsteka
        {
            get { return mjesecIsteka; }
            set { SetProperty(ref mjesecIsteka, value); }
        }

        int godinaIsteka;
        public int GodinaIsteka
        {
            get { return godinaIsteka; }
            set { SetProperty(ref godinaIsteka, value); }
        }

        double iznosUplate;
        public double IznosUplate
        {
            get { return iznosUplate; }
            set { SetProperty(ref iznosUplate, value); }
        }

        public Command KupiKreditCommand { get; }

        public KreditViewModel()
        {
            KupiKreditCommand = new Command(OnKupiKreditClicked);
        }

        private async void OnKupiKreditClicked(object obj)
        {
            var request = new UplataRequest
            {
                BrojKartice = BrojKartice,
                Cvc = Cvc,
                MjesecIsteka = MjesecIsteka,
                GodinaIsteka = GodinaIsteka,
                IznosUplate = (long?)(IznosUplate * 100)
            };

            var uplata = await _serviceKorisnici.Insert<Model.Uplata>(request, "kredit");

            if (uplata == null)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Pogrešni podatci.", "OK");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Success", "Uspješno kupljen kredit.", "OK");
            }
        }
    }
}
