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
            panel_Login.Visible = false;
            panel_opciones_profesor.Visible = true;
            panel_nota.Visible = false;
            panel_anotacion.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_contraseña_login.Text = "";
            textBox_Usuario_login.Text = "";

            panel_Login.Visible = true;
            panel_opciones_profesor.Visible = false;
            panel_nota.Visible = false;
            panel_anotacion.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel_Login.Visible = false;
            panel_opciones_profesor.Visible = false;
            panel_nota.Visible = true;
            panel_anotacion.Visible = false;
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel_Login.Visible = false;
            panel_opciones_profesor.Visible = false;
            panel_nota.Visible = false;
            panel_anotacion.Visible = false;
            panel_Asistencia.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel_Login.Visible = false;
            panel_opciones_profesor.Visible = false;
            panel_nota.Visible = false;
            panel_anotacion.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)//ingresa notas
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

        private void boton_ingresarasistencia_Click(object sender, EventArgs e)
        {
            if (textBox_nombrealumasistencia.Text.Equals("") || textBox_fechaasistencia.Text.Equals("") || textBoxasistencia.Text.Equals(""))
            {
                MessageBox.Show("Por favor rellene todos los campos");
            }
            else
            {
                conection unaconexon = new conection();
                IMongoDatabase database = unaconexon.conexion_Mongo();
                unaconexon.agrega_asistencia(database, textBox_nombrealumasistencia.Text, textBoxasistencia.Text, textBox_fechaasistencia.Text);
                textBox_nombrealumasistencia.Text = "";
                textBox_fechaasistencia.Text = "";
                textBoxasistencia.Text = "";
                MessageBox.Show("se ingreso la asistencia correctamente");
            }
        }

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

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox_nombrealumasistencia.Text = "";
            textBox_fechaasistencia.Text = "";
            textBoxasistencia.Text = "";
            panel_Login.Visible = false;
            panel_opciones_profesor.Visible = false;
            panel_nota.Visible = false;
            panel_anotacion.Visible = false;
            panel_opciones_profesor.Visible = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panel_Login.Visible = false;
            panel_opciones_profesor.Visible = false;
            panel_nota.Visible = false;
            panel_anotacion.Visible = false;
            panelverNotas.Visible = true;
            panel_opciones_profesor.Visible = false;
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            //aca lo de ver asistencia
            panel_Login.Visible = false;
            panel_opciones_profesor.Visible = false;
            panel_nota.Visible = false;
            panel_anotacion.Visible = false;
            panel_Ver_asistencia.Visible = false;
            panel_opciones_profesor.Visible = true;
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
        }

        private void button_verasistencia_Click(object sender, EventArgs e)
        {
            conection unaconexion = new conection();
            IMongoDatabase database = unaconexion.conexion_Mongo();
            if (unaconexion.existencia(database, textBox_Nombre_Alumno_Ver_Asistencia.Text))
            {
                double diasasistido = unaconexion.consulta_asistencia(database, textBox_Nombre_Alumno_Ver_Asistencia.Text);

                //double diastotales = Convert.ToDouble(textBox_porcentaje_Ver_Asistencia.Text);
                double diastotales = unaconexion.consulta_asistencia_total(database, textBox_Nombre_Alumno_Ver_Asistencia.Text);
                textBox_Nombre_Alumno_Ver_Asistencia.Text = "";

                Double calculo = (diasasistido / diastotales) * 100;
                textBox_Asitencia_Ver_asistencia.Text = "dias transcurridos: " + diastotales + "\n" + "dias asistidos: " + diasasistido + "\n" + "porcentaje de asistencia= " + Math.Round(calculo, 2) + "%";

            }
            else
            {
                MessageBox.Show("no existe el alumno en los registros ctm");
                textBox_Nombre_Alumno_Ver_Asistencia.Text = "";
            }


        }

        private void btVerNotas_Click(object sender, EventArgs e)
        {
            conection unaConexion = new conection();
            IMongoDatabase database = unaConexion.conexion_Mongo();
            if (unaConexion.existenciaNotas(database, textBoxIngresoNombreVN.Text)){
                String[] valores = unaConexion.consulta_notas(database, textBoxIngresoNombreVN.Text, ingresoMateriaVN.Text);


                foreach (var item in valores)
                {
                    textBoxResultadoVN.Text= textBoxResultadoVN.Text+item+ "\r\n";


                }

             
                
            }
            else
            {
                MessageBox.Show("no existe el alumno en los registros ctm");
                textBoxIngresoNombreVN.Text = "";
                ingresoMateriaVN.Text = "";
            }
            
        }
    }
}
