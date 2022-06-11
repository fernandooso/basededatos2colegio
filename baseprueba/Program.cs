using baseprueba.conexion;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Console.WriteLine("hola");
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://mongouser:mongouser@taller2bd2.cpnky.mongodb.net/?retryWrites=true&w=majority");
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            var database = client.GetDatabase("TallerBD2");
            Console.WriteLine("hola");
            var apoderadodb = database.GetCollection<apoderado>("apoderado");
            Console.WriteLine("hola");
            var uwuwp = new apoderado() { 
                direccion = "direccion prueba",
                fecha_nacimiento="0000-00-00",
                nombre_completo="nombre prueba apoderado",
                rut="11111111-1",
                telefono="11111111"};
            Console.WriteLine("direccion:",uwuwp.direccion);
            var alumnop = new alumno()
            {
                fecha_de_nacimiento = "1111-11-11",
                nombre_alumno = "alfonso",
                rut_alumno = "22222222-2"
            };
            apoderadodb.InsertOne(uwuwp);
            Console.WriteLine("ewew");

            agregarsub(database,alumnop);

        }

        private static void agregarsub(IMongoDatabase database, alumno alumnop)
        {
            BsonDocument documentillo = alumnop.ToBsonDocument();
            BsonDocument newSubdocument = documentillo;
           //  newSubdocument.Remove("Id");
            var collection = database.GetCollection<BsonDocument>("apoderado");
            var filter = Builders<BsonDocument>.Filter.Eq("rut","11111111-1");
            var update = Builders<BsonDocument>.Update.Push("a_cargo", newSubdocument);
            var result = collection.UpdateOne(filter, update);
            if (result.IsModifiedCountAvailable)
            {
                if (result.ModifiedCount == 1)
                {
                    Console.WriteLine("funciono");
                }
            }
            Console.WriteLine("fallos");
        }
    }
}
