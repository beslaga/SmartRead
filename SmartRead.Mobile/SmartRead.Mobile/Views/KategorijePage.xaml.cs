
using SmartRead.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartRead.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KategorijePage : ContentPage
    {
        private KategorijeViewModel _viewModel;
        public KategorijePage()
        {
            InitializeComponent();
            this.BindingContext = _viewModel = new KategorijeViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}