namespace GACI.RentCar.Dominio.Entidades
{
    public class Reserva
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int VehiculoId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int EstadoId { get; set; }
        public decimal PrecioTotal { get; set; }
    }
}
