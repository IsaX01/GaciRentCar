using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gaci.RentCar.Identity.Configuracion
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "fd6610a6-b131-4fdc-bb5a-173f2e7f39ae",
                    UserId = "67235962-93a4-4cf4-9505-6e5fc2b8f496"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "70f762f5-9dae-41db-b39b-630aae82a860",
                    UserId = "2e818092-b9e2-4b0a-99e9-044c824d3799"
                }
            );
        }
    }
}
