using SmartRead.Mobile.Services;
using SmartRead.Mobile.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartRead.Mobile
{
    public partial class App : Application
    {

        public App()
        {
            string licenseKey = "NDcxOTMzQDMxMzkyZTMyMmUzMFhKMy9XZm93bTI2M0ZCclNwdnpYQTVSa09FdGlqMWFOQnZyV011eGNVbm89";
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(licenseKey);

            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
