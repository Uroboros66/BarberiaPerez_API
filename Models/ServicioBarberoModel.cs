using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BarberiaPerez_API.Models
{
    public class ServicioBarberoModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("nombre_barbero")]
        public string NombreBarbero { get; set; }

        [BsonElement("disponibilidad")]
        public string Disponibilidad { get; set; }

        [BsonElement("reservar_cita")]
        public string ReservarCita { get; set; }
    }
}
