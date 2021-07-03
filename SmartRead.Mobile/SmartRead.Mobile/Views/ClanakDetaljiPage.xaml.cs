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
    public partial class ClanakDetaljiPage : ContentPage
    {
        public ClanakDetaljiPage()
        {
            InitializeComponent();
            BindingContext = new ClanakDetaljiViewModel();
        }
    }
}