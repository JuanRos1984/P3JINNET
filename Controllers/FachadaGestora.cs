using Agencia.Facade;
using Agencia.Models;
using Agencia.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Net;

namespace Agencia.Controllers
{
    [Route("api/GestorVuelos")]
    [ApiController]
    public class FachadaGestora : ControllerBase
    {
        private readonly FachadaVuelo _fachadavuelo;
        private readonly FachadaHotel _fachadahotel;
        private readonly FachadaRentarCarro _fachadarentarcarro;
  



        public FachadaGestora()
        {
            _fachadavuelo = new FachadaVuelo();
            _fachadahotel = new FachadaHotel();
            _fachadarentarcarro = new FachadaRentarCarro();
           
        }

        [HttpGet("Obtener-Vuelos")]
        public ActionResult<List<Vuelo>> GetVuelos()
        {
            List<Vuelo> flights = _fachadavuelo.GetFlights();
            return Ok(flights);
        }


        [HttpGet("Obtener-Hoteles")]
        
        public ActionResult<List<Hotel>> GetHoteles()
        {
            List<Hotel> hotels = _fachadahotel.GetHotels();
            return Ok(hotels);
        }

        [HttpGet("Obtener-Carros")]

        public ActionResult<List<RentarCarro>> GetRantaAutos()
        {
            List<RentarCarro> carros = _fachadarentarcarro.GetCarros();
            return Ok(carros);
        }

        [HttpPost("Realizar-Reserva-Vuelo")]
        public IActionResult RealizarReservaVuelo([FromBody] Reserva reservaData)
        {
            _fachadavuelo.RealizarReservaVuelo(
                reservaData.FechaReserva,
                 reservaData.NombreCliente,
                reservaData.TipoRerserva,
                reservaData.Descripcion,
               reservaData.FechaRecoger,
                 reservaData.FechaDevolver,
                reservaData.PrecioTipo,
             reservaData.PrecioTotal
                

            );

            return Ok("Reserva realizada con éxito.");
        }
        
         [HttpPost("Realizar-Reserva-Hotel")]
        public IActionResult RealizarReservaHotel([FromBody] Reserva reservaData)
        {
            _fachadavuelo.RealizarReservaVuelo(
                reservaData.FechaReserva,
                 reservaData.NombreCliente,
                reservaData.TipoRerserva,
                reservaData.Descripcion,
               reservaData.FechaRecoger,
                 reservaData.FechaDevolver,
                reservaData.PrecioTipo,
             reservaData.PrecioTotal
                

            );

            return Ok("Reserva realizada con éxito.");
        }
         
        
              [HttpPost("Realizar-Reserva-Carro")]
             public IActionResult RealizarReserva([FromBody] Reserva reservaData)
             {
                 _fachadavuelo.RealizarReservaVuelo(
                     reservaData.FechaReserva,
                      reservaData.NombreCliente,
                     reservaData.TipoRerserva,
                     reservaData.Descripcion,
                    reservaData.FechaRecoger,
                      reservaData.FechaDevolver,
                     reservaData.PrecioTipo,
                  reservaData.PrecioTotal


                 );

                 return Ok("Reserva realizada con éxito.");
             }
            



    }
}
