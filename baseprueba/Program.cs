
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
            /*conection conection=new conection();
            IMongoDatabase database = conection.conexion_Mongo();
            String [][][]g=conection.consulta_promedio_general(database, "jose");
            foreach (var item in g)
            {
                foreach (var x in item)
                {
                    Console.WriteLine("---------------------------");
                    foreach (var y in x)
                    {
                        Console.WriteLine(y);
                    }
                }
            }*/
     
            

            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());  
        }
        
    }
}
