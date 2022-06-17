using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseprueba.modelos
{
    public class testeadora
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
        [BsonElement("direccion")]
        public string direccion { get; set; }
        [BsonElement("fecha_de_nacimiento")]
        public string fecha_nacimiento { get; set; }
        [BsonElement("a_cargo")]
        public alumnotest alumnillo { get; set; }
    }

    public class alumnotest
    {
        public string rut_alumno { get; set; }
        public string nombre_alumno { set; get; }
        public string fecha_de_nacimiento { get; set; }
    }
}
