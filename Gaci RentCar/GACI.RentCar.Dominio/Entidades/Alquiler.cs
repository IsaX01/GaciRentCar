namespace GACI.RentCar.Dominio.Entidades
{
    public class Alquiler
    {
        public int Id { get; set; }
        public int ReservaId { get; set; }
        public int EmpleadoId { get; set; }
        public DateTime FechaAlquiler { get; set; }
        public DateTime FechaDevolucion { get; set; }
    }
}
