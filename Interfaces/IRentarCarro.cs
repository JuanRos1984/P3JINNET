using Agencia.Models;

namespace Agencia.Interfaces
{
    public interface IRentarCarro
    {
        List<RentarCarro> GetAllRenta();

        public void RealizarReservaRentaCarro(
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


