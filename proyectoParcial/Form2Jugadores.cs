using Microsoft.Data.SqlClient;
using MinecraftManager.Models;
using MinecraftManager.Services;
using MinecraftManager.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel; 

namespace proyectoParcial
{
    public partial class Form2Jugadores : Form
    {
        private Form1 formPrincipal;
        private readonly JugadorService jugadorService;
        public Form2Jugadores(Form1 formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
            jugadorService = new JugadorService(new DatabaseManager());
            CargarJugadores();
        }

        private void CargarJugadores()
        {
            dataGridView1.DataSource = jugadorService.ObtenerTodos();
        }

        private void buttonRegresarM_Click(object sender, EventArgs e)
        {
            formPrincipal.Show();
            this.Close();

        }

        private void buttonAgregarJ_Click(object sender, EventArgs e)
        {
            try
            {
                var jugador = new Jugador
                {
                    Nombre = textBoxNombreJugadores.Text,
                    Nivel = int.Parse(textBoxNivelJugadores.Text)
                };

                jugadorService.Crear(jugador);
                MessageBox.Show("Jugador agregado con éxito.");
                CargarJugadores();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar jugador: " + ex.Message);
            }
        }

        private void buttonModificarJ_Click(object sender, EventArgs e)
        {
            try
            {
                var jugador = new Jugador
                {
                    Id = int.Parse(textBoxIDjugador.Text),
                    Nombre = textBoxNombreJugadores.Text,
                    Nivel = int.Parse(textBoxNivelJugadores.Text)
                };

                jugadorService.Actualizar(jugador);
                MessageBox.Show("Jugador actualizado.");
                CargarJugadores();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar jugador: " + ex.Message);
            }
        }

        private void buttonEliminarJ_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBoxIDjugador.Text);
                jugadorService.Eliminar(id);
                CargarJugadores();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar jugador: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            textBoxIDjugador.Clear();
            textBoxNombreJugadores.Clear();
            textBoxNivelJugadores.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                textBoxIDjugador.Text = row.Cells["Id"].Value.ToString();
                textBoxNombreJugadores.Text = row.Cells["Nombre"].Value.ToString();
                textBoxNivelJugadores.Text = row.Cells["Nivel"].Value.ToString();
            }
        }

        private void Form2Jugadores_Load(object sender, EventArgs e)
        {

        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show("¿Esta de acuerdo seguro en exportar la tabla con nombre 'Jugadores' hacia Excel?", "Confirmar exportación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.No)
                return;

            using (var connection = new SqlConnection(@"Data Source=DESKTOP-MNQI1M5\SQLEXPRESS;Initial Catalog=PARCIAL2;Integrated Security=True;TrustServerCertificate=True"))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Jugadores", connection);
                var adapter = new SqlDataAdapter(command);
                var table = new DataTable();
                adapter.Fill(table);

                using (var workbook = new XLWorkbook())
                {
                    workbook.Worksheets.Add(table, "Jugadores");

                    var guardar = new SaveFileDialog();
                    guardar.Filter = "Excel (*.xlsx)|*.xlsx";
                    guardar.FileName = "TablaJugadores.xlsx";

                    if (guardar.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(guardar.FileName);
                        MessageBox.Show("¡Excelente... Jugadores exportados eficazmente!");
                    }
                }
            }
        }
    }
}
