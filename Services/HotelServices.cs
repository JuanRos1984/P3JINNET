using Agencia.Interfaces;
using Agencia.Models;
using System.Text.Json;

namespace Agencia.Services
{
    public class HotelServices : IHotel
    {
        private const string FilePath = @"..\Agencia\Data\Hotel.json";

        public List<Hotel> GetAllHotels()
        {
            // Leer el archivo JSON y convertirlo en una lista de vuelos
            string jsonData = File.ReadAllText(FilePath);
            List<Hotel>? flights = JsonSerializer.Deserialize<List<Hotel>>(jsonData);


            return flights ?? new List<Hotel>();
        }


        //Metodo realiza la reserva, la almacena y lo pasa a un json
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

            //Instancea la lista de la clase Reserva y se añade nuevo items
            List<Reserva>? list = new List<Reserva>();
            list.Add(new Reserva
            {
                FechaReserva = fecharreserva,
                NombreCliente = nombreCliente,
                TipoRerserva = tipoReserva,
                Descripcion = descripcion,
                FechaRecoger = fechaRecoger,
                FechaDevolver = fechaDevolver,
                PrecioTipo = preciotipo,
                PrecioTotal = preciototal
            });


            // Ruta del archivo JSON
            string filePath = @"..\Agencia\Data\Reserva.json";


            {
                // Leer el archivo JSON existente y deserializarlo en una lista de reservas
                string jsonExisting = File.ReadAllText(filePath);
                List<Reserva>? existingReservas = JsonSerializer.Deserialize<List<Reserva>>(jsonExisting);

                // Agregar la nueva reserva a la lista existente
                existingReservas.Add(new Reserva
                {
                    FechaReserva = fecharreserva,
                    NombreCliente = nombreCliente,
                    TipoRerserva = tipoReserva,
                    Descripcion = descripcion,
                    FechaRecoger = fechaRecoger,
                    FechaDevolver = fechaDevolver,
                    PrecioTipo = preciotipo,
                    PrecioTotal = preciototal
                });

                // Serializar la lista combinada de reservas
                string jsonCombined = JsonSerializer.Serialize(existingReservas);

                // Guardar el JSON en el archivo
                File.WriteAllText(filePath, jsonCombined);
            }


        }

    }
    }
