using Agencia.Models;
using Agencia.Services;

namespace Agencia.Facade
{
    public class FachadaVuelo
    {
        private readonly VueloServices _repository;

        public FachadaVuelo()
        {
            _repository = new VueloServices();
        }

        public List<Vuelo> GetFlights()
        {
            return _repository.GetAllFlights();
        }

        public void RealizarReservaVuelo(
            DateTime fecharreserva,
            string? nombreCliente,
            string? tipoReserva,
            string? descripcion,
            DateTime fechaRecoger,
            DateTime fechaDevolver,
            decimal preciotipo,
            decimal preciototal)
        {
            _repository.RealizarReservaVuelo(
                fecharreserva,
                nombreCliente,
                tipoReserva,
                descripcion,
                fechaRecoger,
                fechaDevolver,
                preciotipo,
                preciototal
            );
        }

    }
}
