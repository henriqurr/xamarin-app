using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using valorantmarket.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace valorantmarket.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (loginButton.IsEnabled)
            {
                loginButton.IsEnabled = false;
                loginIndicator.IsRunning = true;

                User user = new User
                {
                    Username = inputUsername.Text,
                    Password = inputPassword.Text
                };
            }
        }
    }
}