using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BarberiaPerez_API.Models
{
    public class UsuarioModel
    {
        [BsonId] // Esta propiedad es la clave primaria
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; } // ID del usuario en MongoDB

        [BsonElement("Nombre")] // Indica que este campo es requerido
        public string? Nombre { get; set; } = string.Empty; // Nombre de usuario

        [BsonElement("Contraseña")] // Indica que este campo es requerido
        public string? Contraseña { get; set; } // Contraseña del usuario (hasheada)

        [BsonElement("rol")] // Añadir esto para tener consistencia en la base de datos
        public string? Rol { get; set; } // Rol del usuario (Cliente, Barbero)
    }
}
