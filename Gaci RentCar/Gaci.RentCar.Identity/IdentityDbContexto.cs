using Gaci.RentCar.Identity.Configuracion;
using Gaci.RentCar.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Gaci.RentCar.Identity
{
    public class IdentityDbContexto : IdentityDbContext<ApplicationUser>
    {
        public IdentityDbContexto(DbContextOptions<IdentityDbContexto> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());
        }
    }
}
