using SmartRead.Mobile.Services;
using SmartRead.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace SmartRead.Mobile.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }
        public Command RegisterCommand { get; }

        private readonly APIService _serviceLogin = new APIService("login");

        string username;
        public string Username
        {
            get { return username; }
            set { SetProperty(ref username, value); }
        }

        string password;
        public string Password
        {
            get { return password; }
            set { SetProperty(ref password, value); }
        }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
            RegisterCommand = new Command(OnRegisterClicked);
        }

        private async void OnRegisterClicked(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(RegisterPage)}");
        }

        private async void OnLoginClicked(object obj)
        {
            APIService.PrijavljeniKorisnik = await _serviceLogin.Insert<Model.Korisnik>(new Model.Requests.LoginRequest { username = Username, password = Password });
            
            if (APIService.PrijavljeniKorisnik == null)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Pogrešan username i/ili password.", "OK");
            }
            else if (!APIService.PrijavljeniKorisnik.Uloge.Any(i => i.Uloga.Naziv == "BasicUser"))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Nemate permisije za pristup admin aplikaciji.", "OK");
                APIService.PrijavljeniKorisnik = null;
            }
            else
            {
                APIService.Username = Username;
                APIService.Password = Password;

                // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
                await Shell.Current.GoToAsync($"//{nameof(NaslovnaPage)}");
            }

        }
    }
}
