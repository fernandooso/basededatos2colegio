using baseprueba.modelos;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baseprueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            conection unaconexon = new conection();
            IMongoDatabase database = unaconexon.conexion_Mongo();
           String contraseña= unaconexon.consulta_contraseña(database, textBox_Usuario_login.Text);
            if (unaconexon.exitenciaprofesor(database,textBox_Usuario_login.Text)&& contraseña== textBox_contraseña_login.Text)
            {
                panel_Login.Visible = false;
                panel_opciones_profesor.Visible = true;
                panel_nota.Visible = false;
                panel_anotacion.Visible = false;
                panel_ver_anotaciones.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecto");
                textBox_Usuario_login.Text = "";
                textBox_contraseña_login.Text = "";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_contraseña_login.Text = "";
            textBox_Usuario_login.Text = "";

            panel_Login.Visible = true;
            panel_opciones_profesor.Visible = false;
            panel_nota.Visible = false;
            panel_anotacion.Visible = false;
            panel_ver_anotaciones.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel_Login.Visible = false;
            panel_opciones_profesor.Visible = false;
            panel_nota.Visible = true;
            panel_anotacion.Visible = false;
            panel_ver_anotaciones.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox_Nombre_Alumno_notas.Text = "";
            textBox_Nota.Text = "";
            panel_Login.Visible = false;
            panel_opciones_profesor.Visible = true;
            panel_nota.Visible = false;
            panel_anotacion.Visible = false;
            panel_ver_anotaciones.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            textBox_nom_al_anotacion.Text = "";
            textBox_anotacion.Text = "";
            panel_Login.Visible = false;
            panel_opciones_profesor.Visible = true;
            panel_nota.Visible = false;
            panel_anotacion.Visible = false;
            panel_ver_anotaciones.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel_Login.Visible = false;
            panel_opciones_profesor.Visible = false;
            panel_nota.Visible = false;
            panel_anotacion.Visible = false;
            panel_Asistencia.Visible = true;
            panel_ver_anotaciones.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel_Login.Visible = false;
            panel_opciones_profesor.Visible = false;
            panel_nota.Visible = false;
            panel_anotacion.Visible = true;
            panel_ver_anotaciones.Visible = false;
        }
       

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox_nombrealumasistencia.Text = "";
            
            panel_Asistencia.Visible=false;
            panel_Login.Visible = false;
            panel_opciones_profesor.Visible = false;
            panel_nota.Visible = false;
            panel_anotacion.Visible = false;
            panel_opciones_profesor.Visible = true;
            panel_ver_anotaciones.Visible = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panel_Login.Visible = false;
            panel_opciones_profesor.Visible = false;
            panel_nota.Visible = false;
            panel_anotacion.Visible = false;
            panelverNotas.Visible = true;
            panel_opciones_profesor.Visible = false;
            panel_ver_anotaciones.Visible = false;
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            //aca lo de ver asistencia
            textBox_Nombre_Alumno_Ver_Asistencia.Text = "";
            textBox_Asitencia_Ver_asistencia.Text = "";
            textBox_porcentaje_asistencia.Text = "";
            panel_Login.Visible = false;
            panel_opciones_profesor.Visible = false;
            panel_nota.Visible = false;
            panel_anotacion.Visible = false;
            panel_Ver_asistencia.Visible = false;
            panel_opciones_profesor.Visible = true;
            panel_ver_anotaciones.Visible = false;
        }

        private void button_Ver_asistencia_Click(object sender, EventArgs e)
        {
            //abre panle asistencia
            panel_Login.Visible = false;
            panel_opciones_profesor.Visible = false;
            panel_nota.Visible = false;
            panel_anotacion.Visible = false;
            panel_Ver_asistencia.Visible = true;
            panel_opciones_profesor.Visible = false;
            panel_ver_anotaciones.Visible = false;
        }

        private void button_ver_anotaciones_Click(object sender, EventArgs e)
        {
            panel_Login.Visible = false;
            panel_opciones_profesor.Visible = false;
            panel_nota.Visible = false;
            panel_anotacion.Visible = false;
            panel_Ver_asistencia.Visible = false;
            panel_opciones_profesor.Visible = false;
            panel_ver_anotaciones.Visible = true;
        }
        private void button7_volver_panleveranotaciones_Click(object sender, EventArgs e)
        {
            panel_Login.Visible = false;
            panel_opciones_profesor.Visible = false;
            panel_nota.Visible = false;
            panel_anotacion.Visible = false;
            panel_Ver_asistencia.Visible = false;
            panel_opciones_profesor.Visible = true;
            panel_ver_anotaciones.Visible = false;
            textBox_nombrealumno_ver_anotaciones.Text = "";
            textBox_resultados_anotaciones.Text = "";
        }
        private void button5_volver_vernotas_Click(object sender, EventArgs e)
        {
            textBoxIngresoNombreVN.Text = "";
            textBoxResultadoVN.Text = "";
            textBox_primedio.Text = "";
            panel_Login.Visible = false;
            panel_nota.Visible = false;
            panel_anotacion.Visible = false;
            panel_Ver_asistencia.Visible = false;
            panel_opciones_profesor.Visible = true;
            panel_ver_anotaciones.Visible = false;
            panelverNotas.Visible = false;
        }

        private void button_agregaapoderado_Click(object sender, EventArgs e)
        {
            panel_Login.Visible = false;
            panel_opciones_profesor.Visible = false;
            panel_nota.Visible = false;
            panel_anotacion.Visible = false;
            panel_Ver_asistencia.Visible = false;
            panel_opciones_profesor.Visible = false;
            panel_ver_anotaciones.Visible = false;
            panel_agregarapoderado.Visible = true;
        }
        private void button_volver_panelingresoapoderado_Click(object sender, EventArgs e)
        {
            textBox_ingresodireccionapoderado.Text = "";
            textBox_ingresarnombreapoderado.Text = "";
            textBox_ingresotelefonoapoderdao.Text = "";
            textBox_ingresofechadenacimientoapoderado.Text = "";
            textBox_ingresorutapoderado.Text = "";
            textBox_ingresonombrealumno_panelingreso.Text = "";
            textBox_ingresorutalumno_panleingreso.Text = "";
            textBox_ingresofnacalumno_panelingreso.Text = "";
            panel_Login.Visible = false;
            panel_nota.Visible = false;
            panel_anotacion.Visible = false;
            panel_Ver_asistencia.Visible = false;
            panel_opciones_profesor.Visible = true;
            panel_ver_anotaciones.Visible = false;
            panelverNotas.Visible = false;
            panel_agregarapoderado.Visible = false;
        }

        private void button_agregar_mas_alumnos_Click(object sender, EventArgs e)
        {
            panel_Login.Visible = false;
            panel_opciones_profesor.Visible = false;
            panel_nota.Visible = false;
            panel_anotacion.Visible = false;
            panel_Ver_asistencia.Visible = false;
            panel_opciones_profesor.Visible = false;
            panel_ver_anotaciones.Visible = false;
            panel_agregarapoderado.Visible = false;
            panel_agregaralumnos.Visible = true;
        }

        private void button_volver_panleingresoalunos_Click(object sender, EventArgs e)
        {
            textBox_fnacalumnos_panlealumnos.Text = "";
            textBox_nombrealumno_panelalumnos.Text = "";
            textBox_rutalumno_panelalumnos.Text = "";
            textBox_rutap_alumnos.Text = "";
            panel_Login.Visible = false;
            panel_nota.Visible = false;
            panel_anotacion.Visible = false;
            panel_Ver_asistencia.Visible = false;
            panel_opciones_profesor.Visible = false;
            panel_ver_anotaciones.Visible = false;
            panelverNotas.Visible = false;
            panel_agregarapoderado.Visible = true;
            panel_agregaralumnos.Visible =false;
        }

        private void button_consultadatosalumnos_Click(object sender, EventArgs e)
        {
            panel_Login.Visible = false;
            panel_opciones_profesor.Visible = false;
            panel_nota.Visible = false;
            panel_anotacion.Visible = false;
            panel_Ver_asistencia.Visible = false;
            panel_opciones_profesor.Visible = false;
            panel_ver_anotaciones.Visible = false;
            panel_agregarapoderado.Visible = false;
            panel_agregaralumnos.Visible = false;
            panel_consultadatos.Visible = true;
        }


        private void button_volverpaneldatos_Click(object sender, EventArgs e)
        {
            textBox_nombreconsultadatos.Text = "";
            textBox2.Text = "";
            panel_consultadatos.Visible = false;
            panel_Login.Visible = false;
            panel_nota.Visible = false;
            panel_anotacion.Visible = false;
            panel_Ver_asistencia.Visible = false;
            panel_opciones_profesor.Visible = true;
            panel_ver_anotaciones.Visible = false;
            panelverNotas.Visible = false;
            panel_agregarapoderado.Visible = false;
        }

        private void button_ir_a_promedio_Click(object sender, EventArgs e)
        {
            panel_Login.Visible = false;
            panel_opciones_profesor.Visible = false;
            panel_nota.Visible = false;
            panel_anotacion.Visible = false;
            panel_Ver_asistencia.Visible = false;
            panel_opciones_profesor.Visible = false;
            panel_ver_anotaciones.Visible = false;
            panel_agregarapoderado.Visible = false;
            panel_agregaralumnos.Visible = false;
            panel_consultadatos.Visible = false;
            panel_promediogeneral.Visible = true;
            panelverNotas.Visible = false;
        }


        private void button_volverproediogeneral_Click(object sender, EventArgs e)
        {
            textBox_nombrepromediogeneral.Text = "";
            textBox_promediogeneral.Text = "";
            textBox_mate.Text = "";
            textBox_leng.Text = "";
            textBox_histo.Text = "";
            textBox_artes.Text = "";
            panel_consultadatos.Visible = false;
            panel_Login.Visible = false;
            panel_nota.Visible = false;
            panel_anotacion.Visible = false;
            panel_Ver_asistencia.Visible = false;
            panel_opciones_profesor.Visible = false;
            panel_ver_anotaciones.Visible = false;
            panelverNotas.Visible = true;
            panel_agregarapoderado.Visible = false;
            panel_promediogeneral.Visible = false;
        }






        ////////////////////////////--funciones de ingresar notas ------///////////////////////

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox_Nombre_Alumno_notas.Text.Equals("") || comboBox2.Text=="Materias" || textBox_Nota.Text.Equals(""))
            {
                MessageBox.Show("Por favor rellene todos los campos");
            }
            else
            {
                conection unaconexon = new conection();
                IMongoDatabase database = unaconexon.conexion_Mongo();
                String nombre = unaconexon.existenciaalumno(database, textBox_Nombre_Alumno_notas.Text);
               if (nombre!="")
                {
                    unaconexon.agrega_notas(database, textBox_Nombre_Alumno_notas.Text, comboBox2.Text, textBox_Nota.Text,nombre);
                    textBox_Nombre_Alumno_notas.Text = "";
                    textBox_Nota.Text = "";
                    MessageBox.Show("se ingreso la nota correctamente");
               }else
               {
                    textBox_Nota.Text = "";
                    textBox_Nombre_Alumno_notas.Text = "";
                    MessageBox.Show("No se pudo ingresar la nota porque el alumno no existe");
               }
                    
          
                    
            }

        }
        ////////////////////////////--funciones de ingresar asistencia------///////////////////////

        private void boton_ingresarasistencia_Click(object sender, EventArgs e)
        {
            
            if (textBox_nombrealumasistencia.Text.Equals(""))
            {
                MessageBox.Show("Por favor rellene todos los campos");
            }
            else
            {
                String opcion = "";
                conection unaconexon = new conection();
                IMongoDatabase database = unaconexon.conexion_Mongo();
                String nombre = unaconexon.existenciaalumno(database, textBox_nombrealumasistencia.Text);
                if (nombre!="")
                {
                    if (rdsi.Checked)
                    {
                        opcion = "si";
                    }
                    else
                    {
                        opcion = "no";
                    }

                    unaconexon.agrega_asistencia(database, textBox_nombrealumasistencia.Text, opcion, DateTime.Now.ToString("dd-MM-yyyy"),nombre);
                    textBox_nombrealumasistencia.Text = "";
                    MessageBox.Show("se ingreso la asistencia correctamente");
                }
                else
                {
                    textBox_nombrealumasistencia.Text = "";
                    MessageBox.Show("No se puede ingresar asistencia porque el alumno no existe");
                }
                   
              

            }
        }

        ////////////////////////////-- funciones de ingresar anotacion------///////////////////////
        private void boton_ingresaanotacion_Click(object sender, EventArgs e)
        {
            if (textBox_nom_al_anotacion.Text.Equals("") || textBox_anotacion.Text.Equals("")
               )
            {
                MessageBox.Show("Por favor rellene todos los campos");
            }
            else
            {
                conection unaconexon = new conection();
                IMongoDatabase database = unaconexon.conexion_Mongo();
                String nombre=unaconexon.existenciaalumno(database, textBox_nom_al_anotacion.Text);
                if (nombre!="")
                {
                    String tipo = "";
                    if (rdpositiva.Checked)
                    {
                        tipo = "positiva";
                    }
                    else
                    {
                        tipo = "negativa";
                    }
                    unaconexon.agrega_anotacion(database, textBox_nom_al_anotacion.Text, textBox_anotacion.Text,
                        tipo, "no aplica", DateTime.Now.ToString("dd-MM-yyyy"),nombre);

                    textBox_anotacion.Text = "";
                    textBox_nom_al_anotacion.Text = "";

                    MessageBox.Show("se ingreso la anotacion correctamente");
                }
                else
                {
                    textBox_anotacion.Text = "";
                    textBox_nom_al_anotacion.Text = "";

                    MessageBox.Show("No se puede ingresar la anotacion porque el alumno no existe");
                }
                   
                
              

            }
        }

        //---------------------------------------- ingreso de apoderado
        private void button_ingresarapoderado_Click(object sender, EventArgs e)
        {
            conection unaconexion = new conection();
            IMongoDatabase database = unaconexion.conexion_Mongo();
            if (unaconexion.exitenciaapoderado(database, textBox_ingresorutapoderado.Text))
            {
                MessageBox.Show("El apoderado ya existe");
            }
            else
            {
                if (textBox_ingresodireccionapoderado.Text.Equals("") || textBox_ingresarnombreapoderado.Text.Equals("") || textBox_ingresotelefonoapoderdao.Text.Equals("") ||
               textBox_ingresofechadenacimientoapoderado.Text.Equals("") || textBox_ingresorutapoderado.Text.Equals("") ||
               textBox_ingresonombrealumno_panelingreso.Text.Equals("") || textBox_ingresorutalumno_panleingreso.Text.Equals("") || textBox_ingresofnacalumno_panelingreso.Text.Equals("") || textBox_ingresocurso_panelapoderado.Text.Equals(""))
                {
                    MessageBox.Show("Rellene todos los campos");
                }
                else
                {
                    unaconexion.agregaapoderado(database, textBox_ingresodireccionapoderado.Text, textBox_ingresarnombreapoderado.Text, textBox_ingresotelefonoapoderdao.Text,
                    textBox_ingresofechadenacimientoapoderado.Text, textBox_ingresorutapoderado.Text,
                    textBox_ingresonombrealumno_panelingreso.Text, textBox_ingresorutalumno_panleingreso.Text, textBox_ingresofnacalumno_panelingreso.Text, textBox_ingresocurso_panelapoderado.Text);
                    textBox_ingresodireccionapoderado.Text = "";
                    textBox_ingresarnombreapoderado.Text = "";
                    textBox_ingresotelefonoapoderdao.Text = "";
                    textBox_ingresofechadenacimientoapoderado.Text = "";
                    textBox_ingresorutapoderado.Text = "";
                    textBox_ingresonombrealumno_panelingreso.Text = "";
                    textBox_ingresorutalumno_panleingreso.Text = "";
                    textBox_ingresofnacalumno_panelingreso.Text = "";
                    textBox_ingresocurso_panelapoderado.Text = "";
                    MessageBox.Show("se ingreso correctamente");
                }

            }

        }


        private void button_ingresardatosalumnos_Click(object sender, EventArgs e)
        {
            conection unaconexion = new conection();
            IMongoDatabase database = unaconexion.conexion_Mongo();
            if (unaconexion.exitenciaapoderado(database, textBox_rutap_alumnos.Text))
            {
                if (textBox_fnacalumnos_panlealumnos.Text.Equals("")|| textBox_nombrealumno_panelalumnos.Text.Equals("") ||
                        textBox_rutalumno_panelalumnos.Text.Equals("") || textBox_rutap_alumnos.Text.Equals("")|| textBox_ingresocurso_panleingresoalumnos.Text.Equals(""))
                {
                    MessageBox.Show("Rellene todos los campos");
                }
                else
                {
                    unaconexion.agrega_alumno(database, textBox_fnacalumnos_panlealumnos.Text, textBox_nombrealumno_panelalumnos.Text,
                        textBox_rutalumno_panelalumnos.Text, textBox_rutap_alumnos.Text, textBox_ingresocurso_panleingresoalumnos.Text);
                    textBox_fnacalumnos_panlealumnos.Text = "";
                    textBox_nombrealumno_panelalumnos.Text = "";
                    textBox_rutalumno_panelalumnos.Text = "";
                    textBox_rutap_alumnos.Text = "";
                    textBox_ingresocurso_panleingresoalumnos.Text = "";
                    MessageBox.Show("se ingreso correctamente");
                }

            }
            else
            {
                textBox_fnacalumnos_panlealumnos.Text = "";
                textBox_nombrealumno_panelalumnos.Text = "";
                textBox_rutalumno_panelalumnos.Text = "";
                textBox_rutap_alumnos.Text = "";
                textBox_ingresocurso_panleingresoalumnos.Text = "";
                MessageBox.Show("No existe ese rut en los registros");

            }
        }




        //---------------------------------------------------------------------------------------------------//
        //////////////////////////------- funciones de los botones con la base de datos ---/////////////////
        //----------------------------------------------------------------------------------------------------//



        //////////////---funciones para ver asistencia---/////////////////////
        private void button_verasistencia_Click(object sender, EventArgs e)
        {
            
            textBox_porcentaje_asistencia.Text = "";
            textBox_Asitencia_Ver_asistencia.Text = "";
            conection unaconexion = new conection();
            IMongoDatabase database = unaconexion.conexion_Mongo();
            if (unaconexion.existenciaasistencia(database, textBox_Nombre_Alumno_Ver_Asistencia.Text))
            {
                double diasasistido = unaconexion.consulta_asistencia(database, textBox_Nombre_Alumno_Ver_Asistencia.Text);
                double diastotales = unaconexion.consulta_asistencia_total(database, textBox_Nombre_Alumno_Ver_Asistencia.Text);
               
                Double calculo = (diasasistido / diastotales) * 100;

                String[] asistencia = unaconexion.consulta_asistencia_detalle(database, textBox_Nombre_Alumno_Ver_Asistencia.Text);
                foreach (var item in asistencia)
                {
                    textBox_Asitencia_Ver_asistencia.Text = textBox_Asitencia_Ver_asistencia.Text + item + "\r\n";

                }
                textBox_porcentaje_asistencia.Text = "dias transcurridos: " + diastotales + "\n" + ", dias asistidos: " + diasasistido + "\n" + ", porcentaje de asistencia= " + Math.Round(calculo, 2) + "%"; ;
            }
            else
            {
                MessageBox.Show("No existe el alumno en los registros");
                textBox_Nombre_Alumno_Ver_Asistencia.Text = "";
                textBox_porcentaje_asistencia.Text = "";
                textBox_Asitencia_Ver_asistencia.Text = "";
            }


        }
        //////////////---funciones para ver notas---/////////////////////
        private void btVerNotas_Click(object sender, EventArgs e)
        {
            textBox_primedio.Text = "";
            textBoxResultadoVN.Text = "";
            conection unaConexion = new conection();
            IMongoDatabase database = unaConexion.conexion_Mongo();
           // Console.WriteLine(comboBox1.Text);
            if (unaConexion.existenciaNotas(database, textBoxIngresoNombreVN.Text)==true && comboBox1.Text != "Materias")
            {
                String[] valores = unaConexion.consulta_notas(database, textBoxIngresoNombreVN.Text, comboBox1.Text);
                foreach (var item in valores)
                {
                    textBoxResultadoVN.Text= textBoxResultadoVN.Text+item+ "\r\n";
                }

                Double[] notas = unaConexion.consulta_notas_promedio(database, textBoxIngresoNombreVN.Text, comboBox1.Text);
                int contador = 0;
                foreach (var item in notas)
                {
                    contador++;
                }
                double suma=0;
                foreach (var item in notas)
                {
                    suma = suma + item;
                }
                if (suma==0)
                {
                    MessageBox.Show("El alumno no tiene notas en esta materia: "+ comboBox1.Text);
                }
                else
                {
                    textBox_primedio.Text = "" + Math.Round(suma / contador, 2); ;
                }
                
            }
            else
            {
                if (comboBox1.Text == "Materias")
                {
                    MessageBox.Show("Por favor selccione una materia");
                }
                else
                {
                    MessageBox.Show("No existe el alumno en los registros");
                    textBoxIngresoNombreVN.Text = "";
                    
                }
               
            }
            
        }
        //---------------------- funciones para ver anotaciones -----------
  

        private void boton_veraanotaciones_panelveranotaciones_Click(object sender, EventArgs e)
        {
            
            textBox_resultados_anotaciones.Text = "";
            conection unaconexion = new conection();
            IMongoDatabase database = unaconexion.conexion_Mongo();
            String[] anotaciones = unaconexion.consulta_anotacion(database, textBox_nombrealumno_ver_anotaciones.Text);
            if (anotaciones.Length==0)
            {
                MessageBox.Show("No existe el alumno en los registros");
                textBox_nombrealumno_ver_anotaciones.Text = "";
                textBox_resultados_anotaciones.Text = "";


            }
            else
            {
                foreach (var item in anotaciones)
                {
                    textBox_resultados_anotaciones.Text = textBox_resultados_anotaciones.Text + item + "\r\n" + "------------------------------------------------------------------------------------------------------------------------" + "\r\n";
                }

            }
           // unaconexion.existenciaanotacion(database, textBox_nombrealumno_ver_anotaciones.Text
        }

        //-------------------------- funcion que retorna datos del apoderado de un alumno

        private void button_consultardatos_Click(object sender, EventArgs e)
        {
           
            textBox2.Text = "";
            conection unaconexion = new conection();
            IMongoDatabase database = unaconexion.conexion_Mongo();
            
            if (unaconexion.consuladatos(database, textBox_nombreconsultadatos.Text).Equals("no esta"))
            {
                String respuesta = "No existe el alumno en los registros";
                MessageBox.Show(respuesta);
                textBox_nombreconsultadatos.Text = "";
                textBox2.Text = "";

            }
            else
            {
                String datos2 = unaconexion.consuladatosal(database, textBox_nombreconsultadatos.Text);
                textBox2.Text = textBox2.Text + datos2;
                textBox2.Text = textBox2.Text + "\r\n" + "-----------------------------------------------------------------------------------" + "\r\n"+"\r\n";
                String datos = unaconexion.consuladatos(database, textBox_nombreconsultadatos.Text);
                textBox2.Text = textBox2.Text+datos;
                
                
            }
            
        }

        private void button_verpormediogeneral_Click(object sender, EventArgs e)
        {
            textBox_promediogeneral.Text = "";
            textBox_mate.Text = "";
            textBox_leng.Text = "";
            textBox_histo.Text = "";
            textBox_artes.Text = "";
            conection unaConexion = new conection();
            IMongoDatabase database = unaConexion.conexion_Mongo();
            if (unaConexion.existenciaNotas(database, textBox_nombrepromediogeneral.Text))
            {
                //artes
                String[] valores = unaConexion.consulta_notas(database, textBox_nombrepromediogeneral.Text, "Artes");
                foreach (var item in valores)
                {
                    textBox_artes.Text = textBox_artes.Text + item + "\r\n";
                }

                Double[] notasart = unaConexion.consulta_notas_promedio(database, textBox_nombrepromediogeneral.Text, "Artes");
                int contador = 0;
                double suma = 0;
                foreach (var item in notasart)
                {
                    suma = suma + item;
                    contador++;
                }   double promartes= Math.Round(suma / contador, 2);
                textBox_artes.Text = textBox_artes.Text +"Promedio: "+ promartes + "\r\n";

                //historia
                String[] valores2 = unaConexion.consulta_notas(database, textBox_nombrepromediogeneral.Text, "Historia");
                foreach (var item in valores2)
                {
                    textBox_histo.Text = textBox_histo.Text + item + "\r\n";
                }

                Double[] notash = unaConexion.consulta_notas_promedio(database, textBox_nombrepromediogeneral.Text, "Historia");
                int contador2 = 0;
                double suma2 = 0;
                foreach (var item in notash)
                {
                    suma2 = suma2 + item;
                    contador2++;
                }
                double promah = Math.Round(suma2 / contador2, 2);
                textBox_histo.Text = textBox_histo.Text + "Promedio: " +promah + "\r\n";

                //lenguaje
                String[] valores3 = unaConexion.consulta_notas(database, textBox_nombrepromediogeneral.Text, "Lenguaje");
                foreach (var item in valores3)
                {
                    textBox_leng.Text = textBox_leng.Text + item + "\r\n";
                }

                Double[] notasl = unaConexion.consulta_notas_promedio(database, textBox_nombrepromediogeneral.Text, "Lenguaje");
                int contador3 = 0;
                double suma3 = 0;
                foreach (var item in notasl)
                {
                    suma3 = suma3 + item;
                    contador3++;
                }
                double promal = Math.Round(suma3 / contador3, 2);
                textBox_leng.Text = textBox_leng.Text + "Promedio: " + promal + "\r\n";


                //matematica
                String[] valores4 = unaConexion.consulta_notas(database, textBox_nombrepromediogeneral.Text, "Matematica");
                foreach (var item in valores4)
                {
                    textBox_mate.Text = textBox_mate.Text + item + "\r\n";
                }

                Double[] notasm = unaConexion.consulta_notas_promedio(database, textBox_nombrepromediogeneral.Text, "Matematica");
                int contador4 = 0;
                double suma4 = 0;
                foreach (var item in notasm)
                {
                    suma4 = suma4 + item;
                    contador4++;
                }
                double promam = Math.Round(suma4 / contador4, 2);
                textBox_mate.Text = textBox_mate.Text + "Promedio: " + promam + "\r\n";



                textBox_promediogeneral.Text ="" + Math.Round((promam + promal + promah + promartes) / 4, 2);
            }
            else
            {
                if (textBox_nombrepromediogeneral.Text == "")
                {
                    MessageBox.Show("Existen campos vacios");
                }
                else
                {
                    MessageBox.Show("No existe el alumno en los registros");
                    textBox_nombrepromediogeneral.Text = "";
                    textBox_promediogeneral.Text = "";
                    textBox_mate.Text = "";
                    textBox_leng.Text = "";
                    textBox_histo.Text = "";
                    textBox_artes.Text = "";
                }

            }


        }

       
    }
    

}
