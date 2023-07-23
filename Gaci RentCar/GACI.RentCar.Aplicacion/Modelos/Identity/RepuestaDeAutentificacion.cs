namespace GACI.RentCar.Aplicacion.Modelos.Identity
{
    public class RepuestaDeAutentificacion
    {
        public string Id { get; set; } = string.Empty;
        public string NombreUsuario { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public string Token { get; set; } = string.Empty;
    }
}
