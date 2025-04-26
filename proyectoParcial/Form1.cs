namespace proyectoParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonJugadores_Click(object sender, EventArgs e)
        {
            Form2Jugadores form2 = new Form2Jugadores(this);
            form2.Show();
            this.Hide();
        }

        private void buttonInventario_Click(object sender, EventArgs e)
        {
            Inventario form4 = new Inventario(this);
            form4.Show();
            this.Hide();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
