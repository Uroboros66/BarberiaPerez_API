using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BarberiaPerez_API.Models
{
    public class ReporteBarberoModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("nombre_cliente")]
        public string NombreCliente { get; set; }

        [BsonElement("fecha_cita")]
        public DateTime FechaCita { get; set; }

        [BsonElement("servicio")]
        public string Servicio { get; set; }

        [BsonElement("precio")]
        public decimal Precio { get; set; }
    }
}
