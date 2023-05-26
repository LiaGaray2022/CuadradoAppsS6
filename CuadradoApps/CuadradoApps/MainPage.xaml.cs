using CuadradoApps.ViewModels;

using Xamarin.Forms;

namespace CuadradoApps.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainViewModel();
        }
    }
}