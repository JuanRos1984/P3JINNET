using Agencia.Models;
using Agencia.Services;

namespace Agencia.Facade
{
    public class FachadaRentarCarro
    {
        private readonly RentarCarroServices _repository;

        public FachadaRentarCarro()
        {
            _repository = new RentarCarroServices();
        }

        public List<RentarCarro> GetCarros()
        {
            return _repository.GetAllRenta();
        }
    }
}
