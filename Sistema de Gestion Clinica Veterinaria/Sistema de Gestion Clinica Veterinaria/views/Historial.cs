using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_de_Gestion_Clinica_Veterinaria.views
{
    public partial class Historial : Form
    {
        string rutaConsultas = Path.Combine(Application.StartupPath, "consultas.csv");

        public Historial()
        {
            InitializeComponent();
            CargarDatosIniciales(); // Se ejecuta al abrir el formulario
        }

        private void CargarDatosIniciales()
        {
            if (!File.Exists(rutaConsultas)) return;

            var lineas = File.ReadAllLines(rutaConsultas);
            HashSet<string> mascotas = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            HashSet<string> propietarios = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            int consultasTotales = 0;
            decimal ingresosTotales = 0;

            foreach (var linea in lineas)
            {
                string[] datos = linea.Split(';');
                if (datos.Length == 7)
                {
                    consultasTotales++;
                    mascotas.Add(datos[2].Trim());       // Mascota
                    propietarios.Add(datos[3].Trim());   // Propietario

                    decimal costo;
                    if (decimal.TryParse(datos[6].Trim(), out costo))
                        ingresosTotales += costo;
                }
            }

            // Actualizar labels de los botones
            lblMascotasAtendidas.Text = mascotas.Count.ToString();
            lblConsultasTotales.Text = consultasTotales.ToString();
            lblIngresosTotales.Text = ingresosTotales.ToString("C");
            lblPromedioConsulta.Text = consultasTotales > 0
                ? (ingresosTotales / consultasTotales).ToString("C")
                : "0";

            // Llenar ComboBox
            cmbMascotaFiltro.Items.Clear();
            cmbMascotaFiltro.Items.AddRange(mascotas.ToArray());

            cmbPropietarioFiltro.Items.Clear();
            cmbPropietarioFiltro.Items.AddRange(propietarios.ToArray());

            // Cargar tablas completas
            CargarHistorial(lineas);
            CargarResumenMascota(lineas);
        }

        // Botón Filtrar
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (!File.Exists(rutaConsultas)) return;

            var lineas = File.ReadAllLines(rutaConsultas);
            string mascotaSel = cmbMascotaFiltro.Text.Trim();
            string propietarioSel = cmbPropietarioFiltro.Text.Trim();

            var filtrado = lineas.Where(l =>
            {
                string[] datos = l.Split(';');
                if (datos.Length != 7) return false;

                bool coincideMascota = string.IsNullOrEmpty(mascotaSel) || datos[2].Trim().Equals(mascotaSel, StringComparison.OrdinalIgnoreCase);
                bool coincidePropietario = string.IsNullOrEmpty(propietarioSel) || datos[3].Trim().Equals(propietarioSel, StringComparison.OrdinalIgnoreCase);

                return coincideMascota && coincidePropietario;
            }).ToList();

            // Cargar filtrado en las tablas
            CargarHistorial(filtrado);
            CargarResumenMascota(filtrado);

            // Actualizar resumen con los datos filtrados
            ActualizarResumenDesdeFiltrado(filtrado);
        }

        // Botón Ver Todo
        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            CargarDatosIniciales();
        }

        private void CargarHistorial(IEnumerable<string> lineas)
        {
            dataGridViewHistorial.Rows.Clear();
            foreach (var linea in lineas)
            {
                string[] datos = linea.Split(';');
                if (datos.Length == 7)
                    dataGridViewHistorial.Rows.Add(datos);
            }
        }

        private void CargarResumenMascota(IEnumerable<string> lineas)
        {
            dataGridViewResumenMascota.Rows.Clear();

            var resumen = lineas
                .Select(l => l.Split(';'))
                .Where(d => d.Length == 7)
                .GroupBy(d => d[2].Trim()) // Agrupar por mascota
                .Select(g => new
                {
                    Nombre = g.Key,
                    Especie = g.First()[1].Trim(),
                    Propietario = g.First()[3].Trim(),
                    Consultas = g.Count(),
                    Total = g.Sum(x => decimal.TryParse(x[6].Trim(), out var c) ? c : 0)
                });

            foreach (var r in resumen)
            {
                dataGridViewResumenMascota.Rows.Add(r.Nombre, r.Especie, r.Propietario, r.Consultas, r.Total.ToString("C"));
            }
        }

        private void ActualizarResumenDesdeFiltrado(List<string> lineas)
        {
            HashSet<string> mascotas = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            int consultasTotales = 0;
            decimal ingresosTotales = 0;

            foreach (var linea in lineas)
            {
                string[] datos = linea.Split(';');
                if (datos.Length == 7)
                {
                    consultasTotales++;
                    mascotas.Add(datos[2].Trim());

                    decimal costo;
                    if (decimal.TryParse(datos[6].Trim(), out costo))
                        ingresosTotales += costo;
                }
            }

            lblMascotasAtendidas.Text = mascotas.Count.ToString();
            lblConsultasTotales.Text = consultasTotales.ToString();
            lblIngresosTotales.Text = ingresosTotales.ToString("C");
            lblPromedioConsulta.Text = consultasTotales > 0
                ? (ingresosTotales / consultasTotales).ToString("C")
                : "0";
        }

        // Método vacío para evitar error del diseñador
        private void lblIngresosTotales_Click(object sender, EventArgs e)
        {
            // No hace nada, solo evita el error en el Designer
        }

        // Ejemplo de otro botón que ya tenías
        private void button3_Click(object sender, EventArgs e)
        {
            // Aquí puedes poner la lógica que quieras para ese botón
        }
    }
}