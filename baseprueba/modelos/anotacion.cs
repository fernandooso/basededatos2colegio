using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio_BD.Models
{
    internal class anotacion
    {
        public string _id { get; set; }
        public string nombre_alumno { get; set; }
        public string comentario { get; set; }
        public string tipo { get; set; }
        public string materia { get; set; }
        public int fecha { get; set; }
    }
}
