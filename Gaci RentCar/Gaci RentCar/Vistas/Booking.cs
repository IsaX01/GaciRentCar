using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Gaci_RentCar.Vistas
{
    public class Booking
    {
        public string Car { get; set; }
        public string State { get; set; }
        public string Photo { get; set; }

        public override string ToString()
        {
            return Car;
        }
    }


}
