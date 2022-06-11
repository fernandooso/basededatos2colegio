using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio_BD.Models
{
    public class Conexion
    {
        private static void conexion()
        {
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://mongouser:mongouser@taller2bd2.cpnky.mongodb.net/?retryWrites=true&w=majority");
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            var database = client.GetDatabase("baseprueba");


        }
    }
}
