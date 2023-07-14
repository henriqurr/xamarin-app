using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using valorantmarket.Models;
using System.Threading;

namespace valorantmarket.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ContentPage_SizeChanged(object sender, EventArgs e)
        {
            // responsivo

            //if (Width * Height < 0)
            //{
            //    return;
            //}

            //if (Width > Height)
            //{
            //    container.ColumnDefinitions[1].Width = new GridLength(1, GridUnitType.Star);
            //    container.RowDefinitions[1].Height = 0;

            //    Grid.SetColumn(heading, 1);
            //    Grid.SetRow(heading, 0);
            //}
            //else
            //{
            //    container.ColumnDefinitions[1].Width = 0;
            //    container.RowDefinitions[1].Height = new GridLength(1, GridUnitType.Star);

            //    Grid.SetColumn(heading, 0);
            //    Grid.SetRow(heading, 1);
            //}
        }

        private async void loginButton_Clicked(object sender, EventArgs e)
        {
            if (loginButton.IsEnabled)
            {
                loginButton.IsEnabled = false;
                loginButton.Opacity = 0.6;
                loginIndicator.IsRunning = true;

                await Task.Delay(1000);

                if (string.IsNullOrEmpty(inputUsername.Text) || string.IsNullOrEmpty(inputPassword.Text))
                {
                    await DisplayAlert("Error", "Login or password has wrong", "Try again");

                    loginButton.IsEnabled = true;
                    loginButton.Opacity = 1;
                    loginIndicator.IsRunning = false;
                    return;
                }

                User user = new User
                {
                    Username = inputUsername.Text,
                    Password = inputPassword.Text
                };

                await DisplayAlert($"Welcome, {user.Username}", "You will be redirected shortly...", "OK");

                await Task.Delay(1500);

                await Navigation.PushAsync(new Main());

                loginButton.IsEnabled = true;
                loginButton.Opacity = 1;
                loginIndicator.IsRunning = false;
            }
            else
            {
                Console.WriteLine("teste");
            }
        }
    }
}