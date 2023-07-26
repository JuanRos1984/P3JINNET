using Microsoft.VisualBasic;

namespace Agencia.Models
{
    public class Reserva
    {
        public DateTime FechaReserva { get; set; }
        public string? NombreCliente { get; set; }
        public string? TipoRerserva { get; set; }
        public string? Descripcion { get; set; }
        public DateTime FechaRecoger { get; set; }
        public DateTime FechaDevolver { get; set; }
        public decimal PrecioTipo { get; set; }
        public decimal PrecioTotal { get; set; }
    }
}
