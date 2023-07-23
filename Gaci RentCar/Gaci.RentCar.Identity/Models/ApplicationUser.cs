using Microsoft.AspNetCore.Identity;

namespace Gaci.RentCar.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

    }
}
