namespace Agencia.Models
{
    public class Vuelo 
    {
        public int FlightId { get; set; }
        public string? Origin { get; set; }
        public string? Destination { get; set; }
        public string? DescritionFlight { get; set; }
        public decimal Precio { get; set; }
    }


}
