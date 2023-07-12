using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gaci_RentCar.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]


    public partial class BookingsPage : ContentPage
    {
        public IList<Booking> Bookings { get; private set; }
        public BookingsPage()
        {
            InitializeComponent();
            Bookings = new List<Booking>();

            Bookings.Add(new Booking
            {
                Car = "Hyundai y20",
                State = "Reservado",
                Photo = "https://www.cnet.com/a/img/JV_Ni9SmuCjBn0m4s2IROe-vAt8=/1200x630/2014/10/28/368cda77-87e5-42c8-b70a-3949c768ae0f/2015-hyundai-sonata-limited-04.jpg",

            });
            Bookings.Add(new Booking
            {
                Car = "Hyundai y20",
                State = "Listo para reservar",
                Photo = "https://www.cnet.com/a/img/JV_Ni9SmuCjBn0m4s2IROe-vAt8=/1200x630/2014/10/28/368cda77-87e5-42c8-b70a-3949c768ae0f/2015-hyundai-sonata-limited-04.jpg",

            });
            Bookings.Add(new Booking
            {
                Car = "Hyundai y20",
                State = "Reservado",
                Photo = "https://www.cnet.com/a/img/JV_Ni9SmuCjBn0m4s2IROe-vAt8=/1200x630/2014/10/28/368cda77-87e5-42c8-b70a-3949c768ae0f/2015-hyundai-sonata-limited-04.jpg",

            });
            Bookings.Add(new Booking
            {
                Car = "Hyundai y20",
                State = "Listo para reservar",
                Photo = "https://www.cnet.com/a/img/JV_Ni9SmuCjBn0m4s2IROe-vAt8=/1200x630/2014/10/28/368cda77-87e5-42c8-b70a-3949c768ae0f/2015-hyundai-sonata-limited-04.jpg",

            });

            BindingContext = this;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Booking selectItem = e.SelectedItem as Booking;
        }
        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Booking tappedItem = e.Item as Booking;
        }


    }
}