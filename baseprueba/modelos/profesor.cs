using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseprueba.modelos
{
    internal class profesor
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string _id { get; set; }
        [BsonElement("nombre_completo")]
        public string nombre_completo { get; set; }
        [BsonElement("rut")]
        public string rut { get; set; }
        [BsonElement("telefono")]
        public string telefono { get; set; }
        [BsonElement("especialidad")]
        public string especialidad { get; set; }
        [BsonElement("curso_jefatura")]
        public string curso_jefatura { get; set; }
        [BsonElement("fecha")]
        public string fecha { get; set; }
        [BsonElement("contraseña")]
        public string contraseña { get; set; }
    }
}
