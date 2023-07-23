using GACI.RentCar.Aplicacion.Contractos;
using GACI.RentCar.Infraestructura.Contexto;
using GACI.RentCar.Infraestructura.Repositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GACI.RentCar.Infraestructura
{
    public static class RegistroDeServiciosDeInfraestructura
    {
        public static IServiceCollection AgregarServiciosDeInfraestructura(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PrincipalDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("cadenaPrincipal")));
            services.AddScoped(typeof(IRepositorioGenerico<>), typeof(RepositorioGenerico<>));
            return services;
        }
    }
}
