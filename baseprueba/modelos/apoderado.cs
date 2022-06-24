using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseprueba.modelos
{
    public class apoderado
    {
        public apoderado(string nombre_completo, string rut, string telefono, string direccion, string fecha_nacimiento, alumnotest[] datosalumno)
        {
            
            this.nombre_completo = nombre_completo;
            this.rut = rut;
            this.telefono = telefono;
            this.direccion = direccion;
            this.fecha_nacimiento = fecha_nacimiento;
            this.datosalumno = datosalumno;
        }

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
        public alumnotest[] datosalumno { get; set; }
    }

    public class alumnotest
    {
        public string rut_alumno { get; set; }
        public string nombre_alumno { set; get; }
        public string fecha_de_nacimiento { get; set; }
        public string curso { get; set; }
        public alumnotest(string rut_alumno, string nombre_alumno, string fecha_de_nacimiento, string curso)
        {
            this.rut_alumno = rut_alumno;
            this.nombre_alumno = nombre_alumno;
            this.fecha_de_nacimiento = fecha_de_nacimiento;
            this.curso = curso;
        }
    }
}
