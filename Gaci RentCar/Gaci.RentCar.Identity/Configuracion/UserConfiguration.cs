using Gaci.RentCar.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gaci.RentCar.Identity.Configuracion
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser
                {
                    Id = "67235962-93a4-4cf4-9505-6e5fc2b8f496",
                    Email = "adminlocalhost@gmail.com",
                    NormalizedEmail = "ADMINLOCALHOST@GMAIL.COM",
                    Nombre = "Jefe de Gaci",
                    Apellidos = "Todavia sin dinero",
                    UserName = "Gaci",
                    NormalizedUserName = "GACI",
                    PasswordHash = hasher.HashPassword(null, "Gaci2023@"),
                    EmailConfirmed = true
                },

                new ApplicationUser
                {
                    Id = "2e818092-b9e2-4b0a-99e9-044c824d3799",
                    Email = "clientlocalhost@gmail.com",
                    NormalizedEmail = "CLIENTLOCALHOST@GMAIL.COM",
                    Nombre = "Cliente de Gaci",
                    Apellidos = "Todavia sin compra",
                    UserName = "ClienteGaci",
                    NormalizedUserName = "CLIENTGACI",
                    PasswordHash = hasher.HashPassword(null, "Gaci2023@"),
                    EmailConfirmed = true
                }
                );
        }
    }
}
