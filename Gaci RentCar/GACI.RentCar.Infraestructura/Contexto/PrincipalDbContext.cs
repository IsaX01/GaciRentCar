using GACI.RentCar.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace GACI.RentCar.Infraestructura.Contexto
{
    public partial class PrincipalDbContext : DbContext
    {
        public PrincipalDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<EstadoVehiculo> EstadoVehiculos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EstadoVehiculo>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nombre).HasMaxLength(30).IsRequired();
            });

            base.OnModelCreating(modelBuilder);
        }

    }
}
