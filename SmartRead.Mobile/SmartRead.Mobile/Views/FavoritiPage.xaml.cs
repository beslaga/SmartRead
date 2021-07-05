using SmartRead.Mobile.ViewModels;
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
    public partial class FavoritiPage : ContentPage
    {
        private FavoritiViewModel _viewModel;

        public FavoritiPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new FavoritiViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}