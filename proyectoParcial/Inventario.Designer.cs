namespace proyectoParcial
{
    partial class Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            label1 = new Label();
            buttonRegresarMI = new Button();
            label2 = new Label();
            comboBoxInventario = new ComboBox();
            dataGridViewInvent = new DataGridView();
            buttonExportarInvt = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("ROG Fonts", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 42);
            label1.Name = "label1";
            label1.Size = new Size(254, 19);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Inventario";
            // 
            // buttonRegresarMI
            // 
            buttonRegresarMI.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegresarMI.Location = new Point(647, 389);
            buttonRegresarMI.Name = "buttonRegresarMI";
            buttonRegresarMI.Size = new Size(111, 36);
            buttonRegresarMI.TabIndex = 1;
            buttonRegresarMI.Text = "Menú Principal";
            buttonRegresarMI.UseVisualStyleBackColor = true;
            buttonRegresarMI.Click += buttonRegresarMI_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(68, 155);
            label2.Name = "label2";
            label2.Size = new Size(195, 19);
            label2.TabIndex = 2;
            label2.Text = "Buscar por Tipo o Rareza";
            // 
            // comboBoxInventario
            // 
            comboBoxInventario.Font = new Font("Microsoft YaHei", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxInventario.FormattingEnabled = true;
            comboBoxInventario.Location = new Point(68, 200);
            comboBoxInventario.Name = "comboBoxInventario";
            comboBoxInventario.Size = new Size(202, 25);
            comboBoxInventario.TabIndex = 3;
            // 
            // dataGridViewInvent
            // 
            dataGridViewInvent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInvent.Location = new Point(339, 30);
            dataGridViewInvent.Name = "dataGridViewInvent";
            dataGridViewInvent.Size = new Size(437, 335);
            dataGridViewInvent.TabIndex = 4;
            // 
            // buttonExportarInvt
            // 
            buttonExportarInvt.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExportarInvt.Location = new Point(76, 329);
            buttonExportarInvt.Name = "buttonExportarInvt";
            buttonExportarInvt.Size = new Size(187, 46);
            buttonExportarInvt.TabIndex = 5;
            buttonExportarInvt.Text = "Exportar Datos del Inventario hacia Excel";
            buttonExportarInvt.UseVisualStyleBackColor = true;
            buttonExportarInvt.Click += buttonExportarInvt_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(513, 371);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(114, 388);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(241, 75);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(61, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(buttonExportarInvt);
            Controls.Add(dataGridViewInvent);
            Controls.Add(comboBoxInventario);
            Controls.Add(label2);
            Controls.Add(buttonRegresarMI);
            Controls.Add(label1);
            Name = "Inventario";
            Text = "Inventario";
            Load += Inventario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewInvent).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonRegresarMI;
        private Label label2;
        private ComboBox comboBoxInventario;
        private DataGridView dataGridViewInvent;
        private Button buttonExportarInvt;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}