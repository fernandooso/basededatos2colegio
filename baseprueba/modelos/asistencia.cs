using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseprueba.modelos
{
    internal class Asistencia
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string _id { get; set; }
        [BsonElement("nombre_alumno")]
        public string nombre_alumno { get; set; }
        [BsonElement("asistencia")]
        public string asistencia { get; set; }
        [BsonElement("fecha")]
        public string fecha { get; set; }
        
    }
}
