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
            textBox_Materia_panelnotas.Text = "";
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
            textBox_tipoanotacion.Text = "";
            textBox_fechaanotacion.Text = "";
            textBox_materianotacion.Text = "";

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
            textBox_ingreso_fechaasistencia.Text = "";
            textBox_ingresoasistencia.Text = "";
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
            ingresoMateriaVN.Text = "";
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











        ////////////////////////////--funciones de ingresar notas ------///////////////////////

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox_Nombre_Alumno_notas.Text.Equals("") || textBox_Materia_panelnotas.Text.Equals("") || textBox_Nota.Text.Equals(""))
            {
                MessageBox.Show("Por favor rellene todos los campos");
            }
            else
            {
                conection unaconexon = new conection();
                IMongoDatabase database = unaconexon.conexion_Mongo();
                unaconexon.agrega_notas(database, textBox_Nombre_Alumno_notas.Text, textBox_Materia_panelnotas.Text, textBox_Nota.Text);
                textBox_Nombre_Alumno_notas.Text = "";
                textBox_Materia_panelnotas.Text = "";
                textBox_Nota.Text = "";
                MessageBox.Show("se ingreso la nota correctamente");
            }

        }
        ////////////////////////////--funciones de ingresar asistencia------///////////////////////

        private void boton_ingresarasistencia_Click(object sender, EventArgs e)
        {
            if (textBox_nombrealumasistencia.Text.Equals("") || textBox_ingreso_fechaasistencia.Text.Equals("") || textBox_ingresoasistencia.Text.Equals(""))
            {
                MessageBox.Show("Por favor rellene todos los campos");
            }
            else
            {
                conection unaconexon = new conection();
                IMongoDatabase database = unaconexon.conexion_Mongo();
                unaconexon.agrega_asistencia(database, textBox_nombrealumasistencia.Text, textBox_ingresoasistencia.Text, textBox_ingreso_fechaasistencia.Text);
                textBox_nombrealumasistencia.Text = "";
                textBox_ingreso_fechaasistencia.Text = "";
                textBox_ingresoasistencia.Text = "";
                MessageBox.Show("se ingreso la asistencia correctamente");
            }
        }

        ////////////////////////////-- funciones de ingresar anotacion------///////////////////////
        private void boton_ingresaanotacion_Click(object sender, EventArgs e)
        {
            if (textBox_nom_al_anotacion.Text.Equals("") || textBox_anotacion.Text.Equals("")
                || textBox_fechaanotacion.Text.Equals("") || textBox_materianotacion.Text.Equals("") || textBox_tipoanotacion.Text.Equals(""))
            {
                MessageBox.Show("Por favor rellene todos los campos");
            }
            else
            {
                conection unaconexon = new conection();
                IMongoDatabase database = unaconexon.conexion_Mongo();
                unaconexon.agrega_anotacion(database, textBox_nom_al_anotacion.Text, textBox_anotacion.Text,
                    textBox_tipoanotacion.Text, textBox_materianotacion.Text, textBox_fechaanotacion.Text);

                textBox_anotacion.Text = "";
                textBox_nom_al_anotacion.Text = "";
                textBox_fechaanotacion.Text = "";
                textBox_tipoanotacion.Text = "";
                textBox_materianotacion.Text = "";
                MessageBox.Show("se ingreso la anotacion correctamente");
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
               textBox_ingresonombrealumno_panelingreso.Text.Equals("") || textBox_ingresorutalumno_panleingreso.Text.Equals("") || textBox_ingresofnacalumno_panelingreso.Text.Equals(""))
                {
                    MessageBox.Show("Rellene todos los campos");
                }
                else
                {
                    unaconexion.agregaapoderado(database, textBox_ingresodireccionapoderado.Text, textBox_ingresarnombreapoderado.Text, textBox_ingresotelefonoapoderdao.Text,
                    textBox_ingresofechadenacimientoapoderado.Text, textBox_ingresorutapoderado.Text,
                    textBox_ingresonombrealumno_panelingreso.Text, textBox_ingresorutalumno_panleingreso.Text, textBox_ingresofnacalumno_panelingreso.Text);
                    textBox_ingresodireccionapoderado.Text = "";
                    textBox_ingresarnombreapoderado.Text = "";
                    textBox_ingresotelefonoapoderdao.Text = "";
                    textBox_ingresofechadenacimientoapoderado.Text = "";
                    textBox_ingresorutapoderado.Text = "";
                    textBox_ingresonombrealumno_panelingreso.Text = "";
                    textBox_ingresorutalumno_panleingreso.Text = "";
                    textBox_ingresofnacalumno_panelingreso.Text = "";
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
                        textBox_rutalumno_panelalumnos.Text.Equals("") || textBox_rutap_alumnos.Text.Equals(""))
                {
                    MessageBox.Show("Rellene todos los campos");
                }
                else
                {
                    unaconexion.agrega_alumno(database, textBox_fnacalumnos_panlealumnos.Text, textBox_nombrealumno_panelalumnos.Text,
                        textBox_rutalumno_panelalumnos.Text, textBox_rutap_alumnos.Text);
                    textBox_fnacalumnos_panlealumnos.Text = "";
                    textBox_nombrealumno_panelalumnos.Text = "";
                    textBox_rutalumno_panelalumnos.Text = "";
                    textBox_rutap_alumnos.Text = "";
                }

            }
            else
            {
                MessageBox.Show("No existe ese rut en los registros");

            }
        }




        //---------------------------------------------------------------------------------------------------//
        //////////////////////////------- funciones de los botones con la base de datos ---/////////////////
        //----------------------------------------------------------------------------------------------------//



        //////////////---funciones para ver asistencia---/////////////////////
        private void button_verasistencia_Click(object sender, EventArgs e)
        {
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
            }


        }
        //////////////---funciones para ver notas---/////////////////////
        private void btVerNotas_Click(object sender, EventArgs e)
        {
            textBox_primedio.Text = "";
            textBoxResultadoVN.Text = "";
            conection unaConexion = new conection();
            IMongoDatabase database = unaConexion.conexion_Mongo();
            if (unaConexion.existenciaNotas(database, textBoxIngresoNombreVN.Text)==true && ingresoMateriaVN.Text!="")
            {
                String[] valores = unaConexion.consulta_notas(database, textBoxIngresoNombreVN.Text, ingresoMateriaVN.Text);
                foreach (var item in valores)
                {
                    textBoxResultadoVN.Text= textBoxResultadoVN.Text+item+ "\r\n";
                }

                Double[] notas = unaConexion.consulta_notas_promedio(database, textBoxIngresoNombreVN.Text, ingresoMateriaVN.Text);
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
                    MessageBox.Show("El alumno no tiene notas en esta materia: "+ ingresoMateriaVN.Text);
                }
                else
                {
                    textBox_primedio.Text = "" + suma / contador;
                }
                
            }
            else
            {
                if (ingresoMateriaVN.Text == "")
                {
                    MessageBox.Show("Existen campos vacios");
                }
                else
                {
                    MessageBox.Show("No existe el alumno en los registros");
                    textBoxIngresoNombreVN.Text = "";
                    ingresoMateriaVN.Text = "";
                }
               
            }
            
        }
        //---------------------- funciones para ver anotaciones -----------
  

        private void boton_veraanotaciones_panelveranotaciones_Click(object sender, EventArgs e)
        {
            conection unaconexion = new conection();
            IMongoDatabase database = unaconexion.conexion_Mongo();
            if (unaconexion.existenciaanotacion(database, textBox_nombrealumno_ver_anotaciones.Text))
            {
                String[] anotaciones = unaconexion.consulta_anotacion(database, textBox_nombrealumno_ver_anotaciones.Text);
                foreach (var item in anotaciones)
                {
                    textBox_resultados_anotaciones.Text = textBox_resultados_anotaciones.Text + item+ "\r\n"+ "------------------------------------------------------------------------------------------------------------------------------" + "\r\n";
                }
            }
            else
            {
                MessageBox.Show("No existe el alumno en los registros");
                textBox_nombre_alumno_ver_anotaciones.Text = "";

            }
        }

        private void button_consultardatos_Click(object sender, EventArgs e)
        {
            conection unaconexion = new conection();
            IMongoDatabase database = unaconexion.conexion_Mongo();
            if (unaconexion.existenciaalumno(database, textBox_nombreconsultadatos.Text))
            {
                String datos = unaconexion.consuladatos(database, textBox_nombreconsultadatos.Text);
                textBox2.Text = datos;
            }
            else
            {
                MessageBox.Show("No existe el alumno en los registros");
                textBox_nombreconsultadatos.Text = "";
            }
            
        }

   
    }
}
