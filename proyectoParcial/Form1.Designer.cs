namespace proyectoParcial
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonJugadores = new Button();
            buttonInventario = new Button();
            buttonSalir = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // buttonJugadores
            // 
            buttonJugadores.BackColor = Color.FromArgb(128, 64, 0);
            buttonJugadores.Font = new Font("Virtual DJ", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonJugadores.Location = new Point(94, 106);
            buttonJugadores.Name = "buttonJugadores";
            buttonJugadores.Size = new Size(213, 55);
            buttonJugadores.TabIndex = 0;
            buttonJugadores.Text = "GESTIÓN DE JUGADORES";
            buttonJugadores.UseVisualStyleBackColor = false;
            buttonJugadores.Click += buttonJugadores_Click;
            // 
            // buttonInventario
            // 
            buttonInventario.BackColor = Color.FromArgb(255, 128, 0);
            buttonInventario.Font = new Font("Virtual DJ", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonInventario.Location = new Point(94, 176);
            buttonInventario.Name = "buttonInventario";
            buttonInventario.Size = new Size(213, 46);
            buttonInventario.TabIndex = 2;
            buttonInventario.Text = "GESTIÓN DE INVENTARIO";
            buttonInventario.UseVisualStyleBackColor = false;
            buttonInventario.Click += buttonInventario_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = SystemColors.ControlDark;
            buttonSalir.Font = new Font("Virtual DJ", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSalir.Location = new Point(668, 381);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(96, 36);
            buttonSalir.TabIndex = 3;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(732, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(25, 106);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(25, 176);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(62, 52);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(26, 246);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(62, 53);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(32, 317);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(56, 60);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(884, 517);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(buttonSalir);
            Controls.Add(buttonInventario);
            Controls.Add(buttonJugadores);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonJugadores;
        private Button buttonInventario;
        private Button buttonSalir;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}
