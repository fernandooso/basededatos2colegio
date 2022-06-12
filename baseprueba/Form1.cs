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
            panel_anotacion.Visible = true;
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
            if (textBox_nomal_anotacion.Text.Equals("") || textBox_anotacion.Text.Equals("")
                || textBox_fechaanotacion.Text.Equals("") || textBox_materianotacion.Text.Equals("") || textBox_tipoanotacion.Text.Equals(""))
            {
                MessageBox.Show("Por favor rellene todos los campos");
            }
            else
            {
                conection unaconexon = new conection();
                IMongoDatabase database = unaconexon.conexion_Mongo();
                unaconexon.agrega_anotacion(database, textBox_nomal_anotacion.Text, textBox_anotacion.Text,
                    textBox_tipoanotacion.Text,textBox_materianotacion.Text, textBox_fechaanotacion.Text);

                textBox_anotacion.Text = "";
                textBox_nomal_anotacion.Text = "";
                textBox_fechaanotacion.Text = "";
                textBox_tipoanotacion.Text = "";
                textBox_materianotacion.Text = "";
                MessageBox.Show("se ingreso la anotacion correctamente");
            }
        }

 
    }
}
