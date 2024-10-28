using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BarberiaPerez_API.Models
{
    public class LoginModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("nombre")]
        public string Nombre { get; set; }

        [BsonElement("contraseña")]
        public string Contraseña { get; set; }
    }
}
