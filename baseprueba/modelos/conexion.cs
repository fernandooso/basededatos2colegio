using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseprueba.modelos
{
    internal class conexion
    {


        public static void conexion_Mongo()
        {
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://mongouser:mongouser@taller2bd2.cpnky.mongodb.net/?retryWrites=true&w=majority");
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            var database = client.GetDatabase("TallerBD2");
        }
    }
<<<<<<< HEAD
    
=======
    ///mala tu wea 2.0
>>>>>>> 0e82b1a60b9858e2d79e912801b86f1615c70a54
}
