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
    public partial class NoviClanakPage : ContentPage
    {
        private NoviClanakViewModel _viewModel;

        public NoviClanakPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new NoviClanakViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}