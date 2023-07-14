using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using valorantmarket.Views;

namespace valorantmarket
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navigationPage = new NavigationPage(new Login());

            MainPage = navigationPage;

            NavigationPage.SetHasNavigationBar(navigationPage.CurrentPage, false);

            //MainPage = new Main();
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
