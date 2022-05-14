using MobileControl.Services;
using MobileControl.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileControl
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AuthorizationPage();
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
