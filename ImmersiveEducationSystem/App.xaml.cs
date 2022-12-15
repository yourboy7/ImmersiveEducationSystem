using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ImmersiveEducationSystem.Views;

namespace ImmersiveEducationSystem
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new InitializationPage());
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
