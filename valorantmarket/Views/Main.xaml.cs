using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using valorantmarket.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace valorantmarket.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Main : ContentPage
    {
        public Main()
        {
            InitializeComponent();

            IDeviceHelper deviceHelper = DependencyService.Get<IDeviceHelper>();

            string platformName = deviceHelper.GetPlatformName();

            Size screenSize =deviceHelper.GetScreenSize();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var result = await DisplayAlert("Leave?", "Press Yes to close application", "Yes", "No");
            if (result)
            {
                await Navigation.PushAsync(new Login());
            }
        }
    }
}