using Online_Market_Application.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Online_Market_Application.Views
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