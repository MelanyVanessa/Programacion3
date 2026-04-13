using System;
using System.Windows.Forms;

namespace GestionInventarioProductos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            dtpFechaVencimiento.Enabled = false;

            
            chkEsPerecedero.CheckedChanged += chkEsPerecedero_CheckedChanged;
        }

        
        private void chkEsPerecedero_CheckedChanged(object sender, EventArgs e)
        {
            dtpFechaVencimiento.Enabled = chkEsPerecedero.Checked;
        }

       
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            if (!txtCodigo.Text.StartsWith("PROD-"))
            {
                MessageBox.Show("El código debe comenzar con 'PROD-'.");
                return;
            }

            
            if (numStockInicial.Value < numStockMinimo.Value)
            {
                MessageBox.Show("El stock inicial no puede ser menor al stock mínimo.");
                return;
            }

           
            if (!rbExento.Checked && !rbGeneral.Checked && !rbReducido.Checked)
            {
                MessageBox.Show("Debe seleccionar un tipo de IVA.");
                return;
            }

           
            if (chkEsPerecedero.Checked && dtpFechaVencimiento.Value <= DateTime.Now)
            {
                MessageBox.Show("La fecha de vencimiento debe ser posterior a hoy.");
                return;
            }

           
            MessageBox.Show("Producto registrado correctamente.");
        }

       
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNombreProducto.Clear();
            cmbCategoria.SelectedIndex = -1;
            numStockInicial.Value = numStockInicial.Minimum;
            numStockMinimo.Value = numStockMinimo.Minimum;
            rbExento.Checked = false;
            rbGeneral.Checked = false;
            rbReducido.Checked = false;
            chkEsPerecedero.Checked = false;
            dtpFechaVencimiento.Enabled = false;
            dtpFechaVencimiento.Value = DateTime.Now;
        }
    }
}

