namespace GACI.RentCar.Dominio.Entidades
{
    public class Pago
    {
        public int Id { get; set; }
        public int AlquilerId { get; set; }
        public int TipoPagoId { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Monto { get; set; }
    }
}
