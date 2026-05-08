using System;
using System.IO;
using System.Windows.Forms;

namespace Sistema_de_Gestion_Clinica_Veterinaria.views
{
    public partial class Consultas : Form
    {
        string rutaConsultas = Path.Combine(Application.StartupPath, "consultas.csv");
        string rutaMascotas = Path.Combine(Application.StartupPath, "mascotas.csv");

        public Consultas()
        {
            InitializeComponent();
            ConfigurarColumnas(); // columnas correctas
            CargarMascotas();     // llena el ComboBox
            CargarConsultas();    // carga las consultas en la tabla
        }

        // Configurar columnas del DataGridView
        private void ConfigurarColumnas()
        {
            dataGridViewConsultas.Columns.Clear();
            dataGridViewConsultas.Columns.Add("ID", "ID");
            dataGridViewConsultas.Columns.Add("Fecha", "Fecha");
            dataGridViewConsultas.Columns.Add("Mascota", "Mascota");
            dataGridViewConsultas.Columns.Add("Propietario", "Propietario");
            dataGridViewConsultas.Columns.Add("Motivo", "Motivo");
            dataGridViewConsultas.Columns.Add("Diagnostico", "Diagnóstico");
            dataGridViewConsultas.Columns.Add("Costo", "Costo ($)");
        }

        // Cargar mascotas en ComboBox
        private void CargarMascotas()
        {
            cmbMascotaConsulta.Items.Clear();

            if (File.Exists(rutaMascotas))
            {
                var lineas = File.ReadAllLines(rutaMascotas);
                foreach (var linea in lineas)
                {
                    string[] datos = linea.Split(';');
                    if (datos.Length > 1)
                    {
                        string nombreMascota = datos[1].Trim();
                        if (!string.IsNullOrEmpty(nombreMascota))
                        {
                            cmbMascotaConsulta.Items.Add(nombreMascota);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No se encontró el archivo mascotas.csv en la carpeta del programa");
            }
        }

        // Cargar consultas en DataGridView
        private void CargarConsultas()
        {
            dataGridViewConsultas.Rows.Clear();
            if (File.Exists(rutaConsultas))
            {
                var lineas = File.ReadAllLines(rutaConsultas);
                foreach (var linea in lineas)
                {
                    string[] datos = linea.Split(';');
                    if (datos.Length == 7)
                    {
                        dataGridViewConsultas.Rows.Add(datos);
                    }
                }
            }
            CalcularTotalFacturado();
        }

        // Registrar nueva consulta
        private void btnRegistrarConsulta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDConsulta.Text) ||
                string.IsNullOrWhiteSpace(mskFechaConsulta.Text) ||
                cmbMascotaConsulta.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtPropietarioConsulta.Text) ||
                string.IsNullOrWhiteSpace(txtMotivoConsulta.Text) ||
                string.IsNullOrWhiteSpace(txtDiagnosticoConsulta.Text))
            {
                MessageBox.Show("Todos los campos deben estar llenos");
                return;
            }

            DateTime fecha;
            if (!DateTime.TryParse(mskFechaConsulta.Text, out fecha))
            {
                MessageBox.Show("La fecha ingresada no es válida");
                return;
            }

            string nuevaLinea = $"{txtIDConsulta.Text};{fecha.ToShortDateString()};{cmbMascotaConsulta.Text};{txtPropietarioConsulta.Text};{txtMotivoConsulta.Text};{txtDiagnosticoConsulta.Text};{numCostoConsulta.Value}";
            File.AppendAllText(rutaConsultas, nuevaLinea + Environment.NewLine);

            MessageBox.Show("Consulta registrada correctamente");
            CargarConsultas();
        }

        // Eliminar consulta seleccionada
        private void btnEliminarConsulta_Click(object sender, EventArgs e)
        {
            if (dataGridViewConsultas.SelectedRows.Count > 0)
            {
                string idSeleccionado = dataGridViewConsultas.SelectedRows[0].Cells["ID"].Value.ToString();

                var lineas = File.ReadAllLines(rutaConsultas);
                using (StreamWriter sw = new StreamWriter(rutaConsultas))
                {
                    foreach (var linea in lineas)
                    {
                        string[] datos = linea.Split(';');
                        if (datos.Length > 0 && datos[0] != idSeleccionado)
                        {
                            sw.WriteLine(linea);
                        }
                    }
                }

                MessageBox.Show("Consulta eliminada correctamente");
                CargarConsultas();
            }
            else
            {
                MessageBox.Show("Seleccione una consulta para eliminar");
            }
        }

        // Actualizar total facturado
        private void btnActualizarTotal_Click(object sender, EventArgs e)
        {
            CalcularTotalFacturado();
        }

        // Calcular total facturado
        private void CalcularTotalFacturado()
        {
            decimal total = 0;
            foreach (DataGridViewRow fila in dataGridViewConsultas.Rows)
            {
                if (fila.Cells.Count > 6 && fila.Cells[6].Value != null)
                {
                    decimal costo;
                    if (decimal.TryParse(fila.Cells[6].Value.ToString(), out costo))
                    {
                        total += costo;
                    }
                }
            }
            lblTotalFacturado.Text = $"Total Facturado: {total:C}";
        }

        // Eventos generados por el diseñador (pueden quedar vacíos)
        private void label4_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void txtIDConsulta_TextChanged(object sender, EventArgs e) { }

        private void cmbMascotaConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Aquí puedes decidir qué hacer al seleccionar una mascota
            // Ejemplo: mostrar un mensaje
            // MessageBox.Show("Seleccionaste: " + cmbMascotaConsulta.Text);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIDConsulta.Clear();
            mskFechaConsulta.Clear();
            cmbMascotaConsulta.SelectedIndex = -1;
            txtPropietarioConsulta.Clear();
            txtMotivoConsulta.Clear();
            txtDiagnosticoConsulta.Clear();
            numCostoConsulta.Value = numCostoConsulta.Minimum;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Aquí puedes poner la lógica que quieras para ese botón
            // Si no lo necesitas, lo dejas vacío
        }

    }
}
