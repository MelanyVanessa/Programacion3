using Sistema_de_Gestion_Clinica_Veterinaria.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gestion_Clinica_Veterinaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var PropietarioForm = new Propietario();
            PropietarioForm.ShowDialog();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var MascotaForm = new Mascota();
            MascotaForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ConsultasForm = new Consultas();
            ConsultasForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var HistorialForm = new Historial();
            HistorialForm.ShowDialog();
        }
    }
}
