namespace proyectoParcial
{
    partial class Form2Jugadores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2Jugadores));
            label1 = new Label();
            label2 = new Label();
            textBoxIDjugador = new TextBox();
            label3 = new Label();
            textBoxNombreJugadores = new TextBox();
            label4 = new Label();
            textBoxNivelJugadores = new TextBox();
            buttonAgregarJ = new Button();
            buttonModificarJ = new Button();
            buttonEliminarJ = new Button();
            buttonRegresarM = new Button();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            buttonExportar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 18);
            label1.Name = "label1";
            label1.Size = new Size(210, 22);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Jugadores";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 88);
            label2.Name = "label2";
            label2.Size = new Size(20, 14);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // textBoxIDjugador
            // 
            textBoxIDjugador.Location = new Point(89, 84);
            textBoxIDjugador.Name = "textBoxIDjugador";
            textBoxIDjugador.Size = new Size(233, 23);
            textBoxIDjugador.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 127);
            label3.Name = "label3";
            label3.Size = new Size(54, 14);
            label3.TabIndex = 3;
            label3.Text = "Nombre";
            // 
            // textBoxNombreJugadores
            // 
            textBoxNombreJugadores.Location = new Point(89, 123);
            textBoxNombreJugadores.Name = "textBoxNombreJugadores";
            textBoxNombreJugadores.Size = new Size(233, 23);
            textBoxNombreJugadores.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 170);
            label4.Name = "label4";
            label4.Size = new Size(36, 14);
            label4.TabIndex = 5;
            label4.Text = "Nivel";
            // 
            // textBoxNivelJugadores
            // 
            textBoxNivelJugadores.Location = new Point(89, 170);
            textBoxNivelJugadores.Name = "textBoxNivelJugadores";
            textBoxNivelJugadores.Size = new Size(233, 23);
            textBoxNivelJugadores.TabIndex = 6;
            // 
            // buttonAgregarJ
            // 
            buttonAgregarJ.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAgregarJ.Location = new Point(24, 245);
            buttonAgregarJ.Name = "buttonAgregarJ";
            buttonAgregarJ.Size = new Size(75, 23);
            buttonAgregarJ.TabIndex = 7;
            buttonAgregarJ.Text = "Agregar";
            buttonAgregarJ.UseVisualStyleBackColor = true;
            buttonAgregarJ.Click += buttonAgregarJ_Click;
            // 
            // buttonModificarJ
            // 
            buttonModificarJ.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonModificarJ.Location = new Point(242, 245);
            buttonModificarJ.Name = "buttonModificarJ";
            buttonModificarJ.Size = new Size(91, 23);
            buttonModificarJ.TabIndex = 8;
            buttonModificarJ.Text = "Modificar";
            buttonModificarJ.UseVisualStyleBackColor = true;
            buttonModificarJ.Click += buttonModificarJ_Click;
            // 
            // buttonEliminarJ
            // 
            buttonEliminarJ.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEliminarJ.Location = new Point(134, 245);
            buttonEliminarJ.Name = "buttonEliminarJ";
            buttonEliminarJ.Size = new Size(82, 23);
            buttonEliminarJ.TabIndex = 9;
            buttonEliminarJ.Text = "Eliminar";
            buttonEliminarJ.UseVisualStyleBackColor = true;
            buttonEliminarJ.Click += buttonEliminarJ_Click;
            // 
            // buttonRegresarM
            // 
            buttonRegresarM.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRegresarM.Location = new Point(654, 356);
            buttonRegresarM.Name = "buttonRegresarM";
            buttonRegresarM.Size = new Size(103, 37);
            buttonRegresarM.TabIndex = 11;
            buttonRegresarM.Text = "Menú Principal";
            buttonRegresarM.UseVisualStyleBackColor = true;
            buttonRegresarM.Click += buttonRegresarM_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(357, 18);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(411, 284);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(502, 321);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(252, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // buttonExportar
            // 
            buttonExportar.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonExportar.Location = new Point(89, 321);
            buttonExportar.Name = "buttonExportar";
            buttonExportar.Size = new Size(156, 41);
            buttonExportar.TabIndex = 15;
            buttonExportar.Text = "Transferir Archivos de Jugadores hacia Excel";
            buttonExportar.UseVisualStyleBackColor = true;
            buttonExportar.Click += buttonExportar_Click;
            // 
            // Form2Jugadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(buttonExportar);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(buttonRegresarM);
            Controls.Add(buttonEliminarJ);
            Controls.Add(buttonModificarJ);
            Controls.Add(buttonAgregarJ);
            Controls.Add(textBoxNivelJugadores);
            Controls.Add(label4);
            Controls.Add(textBoxNombreJugadores);
            Controls.Add(label3);
            Controls.Add(textBoxIDjugador);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2Jugadores";
            Text = "Form2Jugadores";
            Load += Form2Jugadores_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxIDjugador;
        private Label label3;
        private TextBox textBoxNombreJugadores;
        private Label label4;
        private TextBox textBoxNivelJugadores;
        private Button buttonAgregarJ;
        private Button buttonModificarJ;
        private Button buttonEliminarJ;
        private Button buttonRegresarM;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button buttonExportar;
    }
}