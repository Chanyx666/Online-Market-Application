using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Online_Market_Application.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GetStartedPage : ContentPage
    {
        public GetStartedPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked_Login(object sender, EventArgs args)
        {
            App.Current.MainPage = new LoginPage();
        }
        private void Button_Clicked_SignUp(object sender, EventArgs args)
        {
            App.Current.MainPage = new SignupPage();
        }
    }
}