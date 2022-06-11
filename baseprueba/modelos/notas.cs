using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseprueba.modelos
{
    internal class notas
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string _id { get; set; }
        [BsonElement("nombre_alumno")]
        public string nombre_alumno { get; set; }
        [BsonElement("materia")]
        public string materia { get; set; }
        [BsonElement("nota")]
        public string nota { get; set; }
    }
}
