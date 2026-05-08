using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace Sistema_de_Gestion_Clinica_Veterinaria.views
{
    public partial class Mascota : Form
    {
        string rutaMascotas = Application.StartupPath + "\\mascotas.csv";
        string rutaPropietarios = Application.StartupPath + "\\propietarios.csv";

        public Mascota()
        {
            InitializeComponent();
        }

        private void Mascota_Load(object sender, EventArgs e)
        {
            CargarPropietarios();
            CargarMascotas();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            // Mantengo este método vacío como lo tenías
        }

        private void CargarPropietarios()
        {
            cmbPropietario.Items.Clear();
            if (File.Exists(rutaPropietarios))
            {
                string[] lineas = File.ReadAllLines(rutaPropietarios);
                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(';');
                    cmbPropietario.Items.Add($"{datos[0]}-{datos[1]}");
                }
            }
        }

        private void CargarMascotas()
        {
            dataGridViewMascotas.Rows.Clear();
            if (File.Exists(rutaMascotas))
            {
                string[] lineas = File.ReadAllLines(rutaMascotas);
                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(';');
                    dataGridViewMascotas.Rows.Add(datos);
                }
            }
        }

        private string CalcularEdadDetallada(DateTime fechaNacimiento)
        {
            DateTime hoy = DateTime.Now;
            int años = hoy.Year - fechaNacimiento.Year;
            int meses = hoy.Month - fechaNacimiento.Month;
            int dias = hoy.Day - fechaNacimiento.Day;

            if (dias < 0)
            {
                meses--;
                dias += DateTime.DaysInMonth(hoy.Year, (hoy.Month == 1 ? 12 : hoy.Month - 1));
            }

            if (meses < 0)
            {
                años--;
                meses += 12;
            }

            return $"La edad de la mascota es: {años} años, {meses} meses y {dias} días";
        }

        private void btnRegistrarMascota_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDMascota.Text) ||
                string.IsNullOrWhiteSpace(txtNombreMascota.Text) ||
                string.IsNullOrWhiteSpace(txtEspecie.Text) ||
                string.IsNullOrWhiteSpace(txtRaza.Text) ||
                string.IsNullOrWhiteSpace(mskNacimiento.Text) ||
                string.IsNullOrWhiteSpace(cmbPropietario.Text))
            {
                MessageBox.Show("Todos los campos deben estar llenos");
                return;
            }

            DateTime fechaNacimiento;
            if (!DateTime.TryParse(mskNacimiento.Text, out fechaNacimiento))
            {
                MessageBox.Show("La fecha de nacimiento no es válida");
                return;
            }

            string edadDetallada = CalcularEdadDetallada(fechaNacimiento);
            txtEdad.ForeColor = Color.Green;
            txtEdad.Text = edadDetallada;

            string[] propietarioDatos = cmbPropietario.Text.Split('-');
            string idPropietario = propietarioDatos[0];
            string nombrePropietario = propietarioDatos[1];

            string nuevaLinea = $"{txtIDMascota.Text};{txtNombreMascota.Text};{txtEspecie.Text};{txtRaza.Text};{edadDetallada};{idPropietario};{nombrePropietario}";
            File.AppendAllText(rutaMascotas, nuevaLinea + Environment.NewLine);
            CargarMascotas();
        }

        private void btnActualizarMascota_Click(object sender, EventArgs e)
        {
            if (File.Exists(rutaMascotas))
            {
                DateTime fechaNacimiento;
                if (!DateTime.TryParse(mskNacimiento.Text, out fechaNacimiento))
                {
                    MessageBox.Show("La fecha de nacimiento no es válida");
                    return;
                }

                string edadDetallada = CalcularEdadDetallada(fechaNacimiento);
                txtEdad.ForeColor = Color.Green;
                txtEdad.Text = edadDetallada;

                string[] propietarioDatos = cmbPropietario.Text.Split('-');
                string idPropietario = propietarioDatos[0];
                string nombrePropietario = propietarioDatos[1];

                var lineas = File.ReadAllLines(rutaMascotas).ToList();
                for (int i = 0; i < lineas.Count; i++)
                {
                    string[] datos = lineas[i].Split(';');
                    if (datos[0] == txtIDMascota.Text)
                    {
                        lineas[i] = $"{txtIDMascota.Text};{txtNombreMascota.Text};{txtEspecie.Text};{txtRaza.Text};{edadDetallada};{idPropietario};{nombrePropietario}";
                        break;
                    }
                }
                File.WriteAllLines(rutaMascotas, lineas);
                CargarMascotas();
            }
        }

        private void btnEliminarMascota_Click(object sender, EventArgs e)
        {
            if (File.Exists(rutaMascotas))
            {
                var lineas = File.ReadAllLines(rutaMascotas).ToList();
                lineas = lineas.Where(l =>
                {
                    string[] datos = l.Split(';');
                    return datos[0] != txtIDMascota.Text; // compara solo el ID
                }).ToList();

                File.WriteAllLines(rutaMascotas, lineas);
                CargarMascotas();
            }
        }

        private void btnLimpiarMascota_Click(object sender, EventArgs e)
        {
            txtIDMascota.Clear();
            txtNombreMascota.Clear();
            txtEspecie.Clear();
            txtRaza.Clear();
            mskNacimiento.Clear();
            txtEdad.Clear();
            txtEdad.ForeColor = Color.Black;
            cmbPropietario.SelectedIndex = -1;
            dataGridViewMascotas.ClearSelection();
        }

        private void mskNacimiento_Leave(object sender, EventArgs e)
        {
            DateTime fechaNacimiento;
            if (DateTime.TryParse(mskNacimiento.Text, out fechaNacimiento))
            {
                txtEdad.ForeColor = Color.Green;
                txtEdad.Text = CalcularEdadDetallada(fechaNacimiento);
            }
            else
            {
                txtEdad.Clear();
                txtEdad.ForeColor = Color.Black;
            }
        }

        private void dataGridViewMascotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridViewMascotas.Rows[e.RowIndex];
                txtIDMascota.Text = fila.Cells[0].Value.ToString();
                txtNombreMascota.Text = fila.Cells[1].Value.ToString();
                txtEspecie.Text = fila.Cells[2].Value.ToString();
                txtRaza.Text = fila.Cells[3].Value.ToString();
                txtEdad.Text = fila.Cells[4].Value.ToString();
                cmbPropietario.Text = fila.Cells[5].Value.ToString() + "-" + fila.Cells[6].Value.ToString();
            }
        }
    }
}
