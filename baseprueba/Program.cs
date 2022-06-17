
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
    internal  class Program
    {
        [STAThread]
        private static void Main()
        {
            conection conection=new conection();
            IMongoDatabase database = conection.conexion_Mongo();
            // conection.agregatest(database, "unadireccionrandom", "nombrepapatest", "1", "hacemucho", "unruttest", "nombrealumnotest",
            //    "rutaltest", "hecpoco");

            conection.agrega_alumno(database, "ayer", "juan", "rrutloo", "4");
            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());  */          
        }
        
    }
}
