using SmartRead.Mobile.ViewModels;
using SmartRead.Mobile.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SmartRead.Mobile
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ClanakDetaljiPage), typeof(ClanakDetaljiPage));
            CurrentItem = new LoginPage();
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
