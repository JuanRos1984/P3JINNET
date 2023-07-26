using Agencia.Models;
using Agencia.Services;

namespace Agencia.Facade
{
    public class FachadaHotel
    {
        private readonly HotelServices _repository;

        public FachadaHotel()
        {
            _repository = new HotelServices();
        }

        public List<Hotel> GetHotels()
        {
            return _repository.GetAllHotels();
        }


        public void RealizarReservaHotel(
          DateTime fecharreserva,
          string? nombreCliente,
          string? tipoReserva,
          string? descripcion,
          DateTime fechaRecoger,
          DateTime fechaDevolver,
          decimal preciotipo,
          decimal preciototal)
        {
            _repository.RealizarReservaHotel(
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
