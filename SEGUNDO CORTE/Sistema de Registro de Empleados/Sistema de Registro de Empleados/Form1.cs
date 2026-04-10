using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Sistema_de_Registro_de_Empleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bntRegistrar_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtNombres.Text) ||
                string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtIdentificacion.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }


            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El correo electrónico no es válido.");
                return;
            }

            
            if (!Regex.IsMatch(txtIdentificacion.Text, @"^\d{10}$"))
            {
                MessageBox.Show("La identificación debe tener exactamente 10 dígitos.");
                return;
            }

            
            decimal sueldoBase = numSueldoBase.Value;
            decimal sueldoNeto = sueldoBase - (sueldoBase * 0.10m);

            
            lblResultadoSueldo.Text = $"Sueldo Neto: {sueldoNeto:C}";
        }

        
        

        private void bntLimpiar_Click_1(object sender, EventArgs e)
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtEmail.Clear();
            txtIdentificacion.Clear();
            numSueldoBase.Value = numSueldoBase.Minimum;
            cmbDepartamento.SelectedIndex = -1;
            lblResultadoSueldo.Text = string.Empty;
        }
    }
}

