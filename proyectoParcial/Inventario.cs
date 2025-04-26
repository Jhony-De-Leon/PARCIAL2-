using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinecraftManager.Services;
using MinecraftManager.Utils;
using MinecraftManager.Models;
using ClosedXML.Excel;
using Microsoft.Data.SqlClient;

namespace proyectoParcial
{
    public partial class Inventario : Form
    {
        private InventarioService r_inventarioService;
        private BloqueService r_bloqueService;
        private JugadorService r_jugadorService;

        private Form1 formPrincipal;
        public Inventario(Form1 formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;

            var db = new DatabaseManager();
            r_jugadorService = new JugadorService(db);
            r_bloqueService = new BloqueService(db);
            r_inventarioService = new InventarioService(db, r_jugadorService, r_bloqueService);

            comboBoxInventario.Items.AddRange(new string[] { "Todos", "Común", "Raro", "Épico" });
            comboBoxInventario.SelectedIndex = 0;
            comboBoxInventario.SelectedIndexChanged += Filtrar;

            MostrarInventario("Todos");
        }

        private void Filtrar(object sender, EventArgs e)
        {
            string seleccion = comboBoxInventario.SelectedItem.ToString();
            MostrarInventario(seleccion);
        }

        private void MostrarInventario(string rareza)
        {
            var inventario = r_inventarioService.ObtenerTodos();

            if (rareza != "Todos")
            {
                var bloques = r_bloqueService.BuscarPorRareza(rareza).Select(b => b.Id).ToList();
                inventario = inventario.Where(i => bloques.Contains(i.BloqueId)).ToList();
            }

            var vista = inventario.Select(i =>
            {
                var bloque = r_bloqueService.ObtenerPorId(i.BloqueId);
                var jugador = r_jugadorService.ObtenerPorId(i.JugadorId);

                return new
                {
                    Jugador = jugador?.Nombre ?? "Desconocido",
                    Nivel = jugador?.Nivel ?? 0,
                    Bloque = bloque?.Nombre ?? "Desconocido",
                    Tipo = bloque?.Tipo ?? "N/A",
                    Rareza = bloque?.Rareza ?? "N/A",
                    Cantidad = i.Cantidad
                };
            }).ToList();

            dataGridViewInvent.DataSource = vista;
        }


        private void buttonRegresarMI_Click(object sender, EventArgs e)
        {
            formPrincipal.Show();
            this.Close();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {

        }

        private void buttonExportarInvt_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show("¿Confirmar que sí desea exportar la tabla 'Bloques' a Excel 🦁?", "Confirmar exportación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.No)
                return;

            using (var connection = new SqlConnection(@"Data Source=DESKTOP-MNQI1M5\SQLEXPRESS;Initial Catalog=PARCIAL2;Integrated Security=True;TrustServerCertificate=True"))
            {
                connection.Open();
                var command = new SqlCommand("SELECT * FROM Bloques", connection);
                var adapter = new SqlDataAdapter(command);
                var table = new DataTable();
                adapter.Fill(table);

                using (var workbook = new XLWorkbook())
                {
                    workbook.Worksheets.Add(table, "Bloques");

                    var guardar = new SaveFileDialog();
                    guardar.Filter = "Excel (*.xlsx)|*.xlsx";
                    guardar.FileName = "TablaBloques.xlsx";

                    if (guardar.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(guardar.FileName);
                        MessageBox.Show("¡Exito... Tabla Bloques exportada eficazmente🦁!");
                    }
                }
            }
        }
    }
}
