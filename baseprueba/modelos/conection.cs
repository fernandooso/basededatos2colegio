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

        ////////////////////////7 consultas///////////////////////////////////

        // ---------------- devuelve las anotaciones de un alumno
        public String[] consulta_anotacion(IMongoDatabase database, String nombrealumno)
        {
            var consultadb = database.GetCollection<anotacion>("anotacion");
            var query = consultadb.AsQueryable<anotacion>();
            int cont = 0;
            String espacio = " ";

            foreach (var anotado in query)
                {
                    if (nombrealumno == anotado.nombre_alumno)
                    {
                    cont++;
                    }
                }
            String[] anotaciones = new String[cont];
            int i = 0;
            foreach (var anotado in query)
            {
                if (nombrealumno == anotado.nombre_alumno)
                {
                    anotaciones[i] ="Tipo: "+anotado.tipo+": "+anotado.comentario+espacio+"Fecha: "+anotado.fecha;
                    i++;
                }
            }
            return anotaciones;

        }

        //------- consulta que devuelve las notas de un alumno por materia
        public String[] consulta_notas(IMongoDatabase database, String nombrealumno,
            String materia)
        {
            int contador = 0;
            String espacio = " ";
            var consultadb = database.GetCollection<notas>("notas");

            var query = consultadb.AsQueryable<notas>();
            foreach (var alumno in query)
            {
                if (nombrealumno == alumno.nombre_alumno && materia == alumno.materia)
                {
                    contador++;
                }
            }

            String[] valores = new String[contador];
            int i = 0;
            foreach (var alumno in query)
                {
                    if (nombrealumno == alumno.nombre_alumno && materia== alumno.materia)
                    {
                    valores[i] = alumno.nota + espacio + alumno.materia;    
                    i++;
                    }
                }
            return valores;
        }
        //----------------Devuelve las notas en int para sacar promedio---------------------------------------
        public Double[] consulta_notas_promedio(IMongoDatabase database, String nombrealumno,
           String materia)
        {
            int contador = 0;
            String espacio = " ";
            var consultadb = database.GetCollection<notas>("notas");

            var query = consultadb.AsQueryable<notas>();
            foreach (var alumno in query)
            {
                if (nombrealumno == alumno.nombre_alumno && materia == alumno.materia)
                {
                    contador++;
                }
            }

            Double[] notas = new Double[contador];
            int i = 0;
            foreach (var alumno in query)
            {
                if (nombrealumno == alumno.nombre_alumno && materia == alumno.materia)
                {
                    notas[i] = Convert.ToDouble(alumno.nota);
                    i++;
                }
            }
            return notas;
        }



        //------------- devuelve asistencia de un alumno
        public double consulta_asistencia(IMongoDatabase database, String nombrealumno)
        {
            double i = 0;
            var consultadb = database.GetCollection<Asistencia>("asistencia");
                var query = consultadb.AsQueryable<Asistencia>();
                foreach (var alumno in query)
                {
                    if (nombrealumno == alumno.nombre_alumno && alumno.asistencia=="si")
                    {
                       
                      
                        i++;
                       
                    }
                }
            return i;
        }
        // consulta que devuelve el total de asistencia d eun laumno tanto asistidos como no asistidos
        public double consulta_asistencia_total(IMongoDatabase database, String nombrealumno)
        {
            double i = 0;
            var consultadb = database.GetCollection<Asistencia>("asistencia");
            
                var query = consultadb.AsQueryable<Asistencia>();
                foreach (var alumno in query)
                {
                    if (nombrealumno == alumno.nombre_alumno)
                    {

                        
                        i++;

                    }
                }
            return i;
        }
        //-------------------retorna el detalle de la asistencia
        public String[] consulta_asistencia_detalle(IMongoDatabase database, String nombrealumno)
        {
            int i = 0;
            var consultadb = database.GetCollection<Asistencia>("asistencia");

            var query = consultadb.AsQueryable<Asistencia>();
            foreach (var alumno in query)
            {
                if (nombrealumno == alumno.nombre_alumno)
                {
                    i++;

                }
            }
            String[] asistencia= new String[i];
            int cont = 0;
            foreach (var alumno in query)
            {
                if (nombrealumno == alumno.nombre_alumno)
                {
                    asistencia[cont] = alumno.fecha + ": " + alumno.asistencia;
                    cont++;
                }
            }
            return  asistencia;
        }



        //ve si el profeexiste, si es asi devuelve su info
        public void consulta_datosprofe(IMongoDatabase database, String nombreprofe)
        {
            var consultadb = database.GetCollection<profesor>("profesor");
            if (consultadb.AsQueryable<profesor>().Any(c => c.nombre_completo == nombreprofe))
            {
                var query = consultadb.AsQueryable<profesor>();
                foreach (var profe in query)
                {
                    if (nombreprofe == profe.nombre_completo)
                    {
                        Console.WriteLine(profe.especialidad);
                    }
                }
            }
            else
            {
                Console.WriteLine("no se encontro");
            }
        }

        /////////////////////------ funciones que verifican existencia
        public bool existenciaasistencia(IMongoDatabase database, String nombreabuscar)
        {
            var consultadb = database.GetCollection<Asistencia>("asistencia");
            if (consultadb.AsQueryable<Asistencia>().Any(c => c.nombre_alumno == nombreabuscar))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public bool existenciaNotas(IMongoDatabase database, String nombreabuscar)
        {
            var consultadb = database.GetCollection<notas>("notas");
            if (consultadb.AsQueryable<notas>().Any(c => c.nombre_alumno == nombreabuscar))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool existenciaanotacion(IMongoDatabase database, String nombreabuscar)
        {
            var consultadb = database.GetCollection<anotacion>("anotacion");
            if (consultadb.AsQueryable<anotacion>().Any(c => c.nombre_alumno == nombreabuscar))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
