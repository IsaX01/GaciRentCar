namespace GACI.RentCar.Dominio.Entidades
{
    public class Cliente : Comun
    {
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }   
        public bool Estado { get; set; }
    }
}
