using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gaci.RentCar.Identity.Configuracion
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(

                new IdentityRole
                {
                    Id = "fd6610a6-b131-4fdc-bb5a-173f2e7f39ae",
                    Name = "Administrador",
                    NormalizedName = "ADMINISTRADOR",
                },
                new IdentityRole
                {
                    Id = "70f762f5-9dae-41db-b39b-630aae82a860",
                    Name = "Cliente",
                    NormalizedName = "CLIENTE",
                }
            );
        }
    }
}
