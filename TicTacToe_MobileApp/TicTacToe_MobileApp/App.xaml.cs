using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TicTacToe_MobileApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new StartGameDouble_Page());
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
