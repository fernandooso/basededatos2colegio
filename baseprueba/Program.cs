
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
            unaconexion.consulta_anotacion(database,"jandi");
            Console.WriteLine("");
            unaconexion.consulta_notas(database, "pedrito");
            Console.WriteLine("");
            unaconexion.consulta_asistencia(database, "pepe");
            Console.WriteLine("");
            unaconexion.consulta_datosprofe(database, "profesr");
            
        }
        
    }
}
