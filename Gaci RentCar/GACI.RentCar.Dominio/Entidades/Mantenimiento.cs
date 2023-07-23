namespace GACI.RentCar.Dominio.Entidades
{
    public class Mantenimiento
    {
        public int Id { get; set; }
        public int VehiculoId { get; set; }
        public string Descripcion { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public decimal Costo { get; set; }
    }
}
