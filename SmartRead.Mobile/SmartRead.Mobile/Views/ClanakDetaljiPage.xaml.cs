using SmartRead.Mobile.Helpers;
using SmartRead.Mobile.Services;
using SmartRead.Mobile.ViewModels;
using SmartRead.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartRead.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClanakDetaljiPage : ContentPage
    {
        private readonly APIService _clanakService = new APIService("clanak");
        private readonly ClanakDetaljiViewModel model;
        public ClanakDetaljiPage()
        {
            InitializeComponent();
            BindingContext = model = new ClanakDetaljiViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private async void Rating_ValueChanged(object sender, Syncfusion.SfRating.XForms.ValueEventArgs e)
        {
            int ocjena = Convert.ToInt32(e.Value);

            await _clanakService.Insert<KorisnikClanak>(null, $"{model.Id}/ocijeni/{ocjena}");

            OcjenaHelper.Upsert(model.Id, ocjena);
        }
    }
}