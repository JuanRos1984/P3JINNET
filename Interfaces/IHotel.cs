using Agencia.Models;

namespace Agencia.Interfaces
{
    public interface IHotel
    {
        List<Hotel> GetAllHotels();

        public void RealizarReservaHotel(
           DateTime fecharreserva,
           string nombreCliente,
           string tipoReserva,
           string descripcion,
           DateTime fechaRecoger,
           DateTime fechaDevolver,
           decimal preciotipo,
           decimal preciototal);

    }
}

