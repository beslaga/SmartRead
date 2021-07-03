using SmartRead.Mobile.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartRead.Mobile.Views
{
    public partial class NaslovnaPage : ContentPage
    {
        NaslovnaViewModel _viewModel;

        public NaslovnaPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new NaslovnaViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}