using SmartRead.Mobile.Services;
using SmartRead.Mobile.Views;
using SmartRead.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace SmartRead.Mobile.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        private readonly APIService _korisnikService = new APIService("korisnici");
        public Command LoginCommand { get; }
        public Command RegisterCommand { get; }

        string ime;
        public string Ime
        {
            get { return ime; }
            set { SetProperty(ref ime, value); }
        }

        string prezime;
        public string Prezime
        {
            get { return prezime; }
            set { SetProperty(ref prezime, value); }
        }

        string mail;
        public string Mail
        {
            get { return mail; }
            set { SetProperty(ref mail, value); }
        }

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

        string potvrdiPassword;
        public string PotvrdiPassword
        {
            get { return potvrdiPassword; }
            set { SetProperty(ref potvrdiPassword, value); }
        }

        DateTime datumRodjenja;
        public DateTime DatumRodjenja
        {
            get { return datumRodjenja; }
            set { SetProperty(ref datumRodjenja, value); }
        }

        public RegisterViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
            RegisterCommand = new Command(OnRegisterClicked);
        }

        private async void OnRegisterClicked(object obj)
        {
            var registerRequest = new KorisnikInsertRequest
            {
                Ime = Ime,
                Prezime = Prezime,
                Mail = Mail,
                DrzavaId = 1,
                Password = Password,
                PasswordConfirmation = PotvrdiPassword,
                Username = Username,
                Uloge = new List<int> { 2 },
                DatumRodjenja = DatumRodjenja,
            };

            var korisnik = await _korisnikService.Insert<Model.Korisnik>(registerRequest, "register");

            if (korisnik == null)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Pogrešan username i/ili password.", "OK");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Success", "Uspješna registracija.", "OK");

                // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
                await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
            }
        }

        private async void OnLoginClicked(object obj)
        {
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}
