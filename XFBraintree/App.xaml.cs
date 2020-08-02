using System;
using XFBraintree.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFBraintree
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PaymentPage();
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
