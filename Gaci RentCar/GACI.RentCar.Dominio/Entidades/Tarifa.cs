namespace GACI.RentCar.Dominio.Entidades
{
    public class Tarifa 
    {
        public int Id { get; set; }
        public int VehiculoId { get; set; }
        public int DuracionMinima { get; set; }
        public int DuracionMaxima { get; set; }
        public decimal Precio { get; set; }
    }
}
