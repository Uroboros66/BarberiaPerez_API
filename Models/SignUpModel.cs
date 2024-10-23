using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BarberiaPerez_API.Models
{
    public class SignUpModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("nombre")]
        public string Nombre { get; set; }

        [BsonElement("contraseña")]
        public string Contraseña { get; set; }

        [BsonElement("confirmar_contraseña")]
        public string ConfirmarContraseña { get; set; }

        [BsonElement("rol")]
        public string Rol { get; set; } 
    }
}
