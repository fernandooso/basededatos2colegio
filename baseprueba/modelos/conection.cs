using baseprueba.conexion;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseprueba.modelos
{
    internal class conection
    {
        
        
        public IMongoDatabase conexion_Mongo()
        {
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://mongouser:mongouser@taller2bd2.cpnky.mongodb.net/?retryWrites=true&w=majority");
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            var client = new MongoClient(settings);
            var database = client.GetDatabase("TallerBD2");

            return database;
        }
        
        public void agregar_apoderado(IMongoDatabase database,String direccion,
            String nombre,String telefono, String fechanac, String rut)
        {
            var apoderadodb = database.GetCollection<apoderado>("apoderado");
            var apoderadoingreso = new apoderado()
            {
                direccion = direccion,
                fecha_nacimiento = fechanac,
                nombre_completo = nombre,
                rut = rut,
                telefono = telefono
            };

            apoderadodb.InsertOne(apoderadoingreso);
        }

        public void agrega_alumno(IMongoDatabase database,String fnac,
            String nomal, String rutal, String rutapoderado)
        {
            var alumnop = new alumno()
            {
                fecha_de_nacimiento = fnac,
                nombre_alumno = nomal,
                rut_alumno = rutal
            };

            BsonDocument documentillo = alumnop.ToBsonDocument();
            BsonDocument newSubdocument = documentillo;
            var collection = database.GetCollection<BsonDocument>("apoderado");
            var filter = Builders<BsonDocument>.Filter.Eq("rut", rutapoderado);
            var update = Builders<BsonDocument>.Update.Push("a_cargo", newSubdocument);
            var result = collection.UpdateOne(filter, update);
        }

        public void agrega_anotacion(IMongoDatabase database,String nomal,
            String comentario, String tipo,String materia, String fechano)
        {
            var anotaciondb = database.GetCollection<anotacion>("anotacion");
            var anotacioningreso = new anotacion()
            {
                comentario = comentario,
                tipo = tipo,
                materia = materia,
                fecha = fechano,
                nombre_alumno = nomal
            };
            anotaciondb.InsertOne(anotacioningreso);
        }

        public void agrega_asistencia(IMongoDatabase database,String nombre_alumno,
            String asistenciaa, String fecha)
        {
            var asistenciandb = database.GetCollection<Asistencia>("asistencia");
            var asistenciaingreso = new Asistencia()
            {
                asistencia = asistenciaa,
                fecha=fecha,
                nombre_alumno=nombre_alumno
            };
            asistenciandb.InsertOne(asistenciaingreso);
        }

        public void agrega_notas(IMongoDatabase database, String nombre_alumno, String materia,
            String nota)
        {
            var notasdb = database.GetCollection<notas>("notas");
            var notaingreso = new notas()
            {
                materia = materia,
                nombre_alumno = nombre_alumno,
                nota = nota
            };
            notasdb.InsertOne(notaingreso);
        }

        public void agrega_profesor(IMongoDatabase database, String nombre_completo, String rut,
            String telefono, String especialidad, String curso_jefatura, String fecha, String contraseña)
        {
            var profesordb = database.GetCollection<profesor>("profesor");
            var profeingreso = new profesor()
            {
                fecha = fecha,
                contraseña=contraseña,
                curso_jefatura = curso_jefatura,
                especialidad = especialidad,
                nombre_completo = nombre_completo,
                rut = rut,
                telefono = telefono
            };
            profesordb.InsertOne(profeingreso);
        }

        public void leer_anotacion(IMongoDatabase database, String nombrealumno
           )
        {
      
            var consultadb = database.GetCollection<anotacion>("anotacion");
            var filter = Builders<anotacion>.Filter.Eq(x => x.nombre_alumno,nombrealumno);
           // var respuesta = consultadb.Find<anotacion>(filter).ToJson;
  
            
            
            //Console.WriteLine(respuesta);
        }

    }

    

}
