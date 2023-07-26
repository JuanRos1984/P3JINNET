using Agencia.Models;

namespace Agencia.Interfaces
{
    public interface IVuelo
    {
        List<Vuelo> GetAllFlights();
        public void RealizarReservaVuelo(
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
