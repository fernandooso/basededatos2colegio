
using baseprueba.modelos;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baseprueba
{
    internal  class Program:conection
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            conection unaconexion = new conection();

            IMongoDatabase database=unaconexion.conexion_Mongo();
            unaconexion.leer_anotacion(database,"pedrito");

           /* unaconexion.agregar_apoderado(database, "una direccion","un nombre",
                "111","unafecha","4");
            unaconexion.agrega_alumno(database, "unafechanac", "federico", "22", "4");
            unaconexion.agrega_anotacion(database, "pedrito", "se hace una en clase",
                "negativa", "lenguaje", "hoy");
            unaconexion.agrega_profesor(database, "profesr", "unrut", "111", "matematica", "5b",
                "desde siempre", "unacontraseña");
            unaconexion.agrega_notas(database, "pedrito", "lenguaje", "7.0");
            unaconexion.agrega_asistencia(database, "pepe", "si", "hoy");*/

            
        }
        
    }
}
