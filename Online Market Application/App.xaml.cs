using Online_Market_Application.Services;
using Online_Market_Application.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Online_Market_Application
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new SplashPage();
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
