using Agencia.Interfaces;
using Agencia.Models;
using System.Text.Json;
using System.Xml;

namespace Agencia.Services
{
    public class VueloServices : IVuelo
    {
        private const string FilePath = @"..\Agencia\Data\Vuelos.json";
       
        public List<Vuelo> GetAllFlights()
        {
            // Leer el archivo JSON y convertirlo en una lista de vuelos
            string jsonData = File.ReadAllText(FilePath);
            List<Vuelo>? flights = JsonSerializer.Deserialize<List<Vuelo>>(jsonData);

          
            return flights?? new List<Vuelo>();
        }

        //Metodo realiza la reserva, la almacena y lo pasa a un json
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


