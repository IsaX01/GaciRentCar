using GACI.RentCar.Aplicacion.Modelos.Identity;

namespace GACI.RentCar.Aplicacion.Contractos.Identity
{
    public interface IServicioDeAutentificacion
    {
        Task<RepuestaDeAutentificacion> Login(SolicitudDeAutenticacion solicitudDeAutenticacion);
        Task<RepuestaDeRegistro> Registrarse(SolicitudDeRegistro solicitudDeRegistro);
    }
}
