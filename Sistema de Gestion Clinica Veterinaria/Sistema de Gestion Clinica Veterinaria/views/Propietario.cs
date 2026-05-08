using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_de_Gestion_Clinica_Veterinaria.views
{
    public partial class Propietario : Form
    {
        // Ruta segura al archivo CSV
        string ruta = Path.Combine(Application.StartupPath, "propietarios.csv");

        public Propietario()
        {
            InitializeComponent();
            CargarPropietarios();
        }

        // Cargar propietarios desde CSV
        private void CargarPropietarios()
        {
            dataGridView1.Rows.Clear();
            if (File.Exists(ruta))
            {
                string[] lineas = File.ReadAllLines(ruta);
                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(';');
                    dataGridView1.Rows.Add(datos);
                }
            }
            ResetearColores();
        }

        // Registrar propietario
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(mskTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Todos los campos deben estar llenos");
                return;
            }

            if (!txtCorreo.Text.Contains("@"))
            {
                MessageBox.Show("El correo debe contener un @ válido");
                return;
            }

            string nuevaLinea = $"{txtID.Text};{txtNombre.Text};{mskTelefono.Text};{txtCorreo.Text};{txtDireccion.Text};0";
            File.AppendAllText(ruta, nuevaLinea + Environment.NewLine);
            CargarPropietarios();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            // Puedes dejarlo vacío si no necesitas lógica aquí
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Puedes dejarlo vacío si no necesitas lógica aquí
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            // Puedes dejarlo vacío si no necesitas lógica aquí
        }


        // Actualizar propietario
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (File.Exists(ruta))
            {
                var lineas = File.ReadAllLines(ruta).ToList();
                for (int i = 0; i < lineas.Count; i++)
                {
                    string[] datos = lineas[i].Split(';');
                    if (datos[0] == txtID.Text)
                    {
                        lineas[i] = $"{txtID.Text};{txtNombre.Text};{mskTelefono.Text};{txtCorreo.Text};{txtDireccion.Text};{datos[5]}";
                        break;
                    }
                }
                File.WriteAllLines(ruta, lineas);
                CargarPropietarios();
            }
        }

        // Eliminar propietario
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (File.Exists(ruta))
            {
                var lineas = File.ReadAllLines(ruta).ToList();
                lineas = lineas.Where(l =>
                {
                    string[] datos = l.Split(';');
                    return datos[0] != txtID.Text;
                }).ToList();

                File.WriteAllLines(ruta, lineas);
                CargarPropietarios();
            }
        }

        // Buscar propietario y resaltar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombreBuscado = txtBuscarPropietario.Text.Trim().ToLower();
            bool encontrado = false;

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.Cells[1].Value != null &&
                    fila.Cells[1].Value.ToString().ToLower().Contains(nombreBuscado))
                {
                    DataGridViewRow filaEncontrada = (DataGridViewRow)fila.Clone();
                    for (int i = 0; i < fila.Cells.Count; i++)
                    {
                        filaEncontrada.Cells[i].Value = fila.Cells[i].Value;
                    }

                    dataGridView1.Rows.Remove(fila);
                    dataGridView1.Rows.Insert(0, filaEncontrada);
                    dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.Coral;

                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("Propietario no encontrado");
            }
        }

        // Limpiar campos
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtNombre.Clear();
            mskTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtBuscarPropietario.Clear();
            dataGridView1.ClearSelection();
            ResetearColores();
        }

        // Selección en DataGridView
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                txtID.Text = fila.Cells[0].Value.ToString();
                txtNombre.Text = fila.Cells[1].Value.ToString();
                mskTelefono.Text = fila.Cells[2].Value.ToString();
                txtCorreo.Text = fila.Cells[3].Value.ToString();
                txtDireccion.Text = fila.Cells[4].Value.ToString();
            }
        }

        // Método para resetear colores
        private void ResetearColores()
        {
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                fila.DefaultCellStyle.BackColor = Color.White;
            }
        }
    }
}
