using System.ComponentModel;
using Xamarin.Forms;
using SmartRead.Mobile.ViewModels;

namespace SmartRead.Mobile.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}