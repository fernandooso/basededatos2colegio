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

        private void button8_Click(object sender, EventArgs e)
        {
            conection unaconexon = new conection();
            IMongoDatabase database = unaconexon.conexion_Mongo();
            unaconexon.agrega_notas(database, textBox_Nombre_Alumno_notas.Text, textBox_Materia_panelnotas.Text, textBox_Nota.Text);
            
        }
    }
}
