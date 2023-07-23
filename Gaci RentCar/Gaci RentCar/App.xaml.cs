using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Gaci_RentCar.Vistas;
namespace Gaci_RentCar
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new HomeCustomer();

            MainPage = new NavigationPage(new login());
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
