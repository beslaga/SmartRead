using SmartRead.Mobile.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartRead.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KreditPage : ContentPage
    {
        public KreditPage()
        {
            InitializeComponent();
            this.BindingContext = new KreditViewModel();
        }
    }
}