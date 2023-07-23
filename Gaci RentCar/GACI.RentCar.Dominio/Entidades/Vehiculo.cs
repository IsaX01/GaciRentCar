namespace GACI.RentCar.Dominio.Entidades
{
    public class Vehiculo 
    {
        public int Id { get; set; }
        public int MarcaId { get; set; }
        public int TipoVehiculoId { get; set; }
        public int TransmisionId { get; set; }
        public int CantidadPuertas { get; set; }
        public int Capacidad { get; set; }
        public int CombustibleId { get; set; }
        public int EstadoId { get; set; }
        public decimal PrecioPorDia { get; set; }
        public int Existencia { get; set; }
        public DateTime Año { get; set; }
    }

}
