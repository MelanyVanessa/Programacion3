namespace Sistema_de_Gestion_Clinica_Veterinaria.views
{
    partial class Mascota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mascota));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPropietario = new System.Windows.Forms.ComboBox();
            this.btnRegistrarMascota = new System.Windows.Forms.Button();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.txtNombreMascota = new System.Windows.Forms.TextBox();
            this.txtIDMascota = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mskNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminarMascota = new System.Windows.Forms.Button();
            this.btnActualizarMascota = new System.Windows.Forms.Button();
            this.dataGridViewMascotas = new System.Windows.Forms.DataGridView();
            this.btnLimpiarMascota = new System.Windows.Forms.Button();
            this.IDMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPropietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePropietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1389, 34);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Mascotas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1389, 122);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(242, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Registro Pacientes de la Clinica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(226, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 62);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mascotas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 156);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1389, 430);
            this.splitContainer1.SplitterDistance = 382;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiarMascota);
            this.groupBox1.Controls.Add(this.cmbPropietario);
            this.groupBox1.Controls.Add(this.btnRegistrarMascota);
            this.groupBox1.Controls.Add(this.txtEdad);
            this.groupBox1.Controls.Add(this.txtRaza);
            this.groupBox1.Controls.Add(this.txtEspecie);
            this.groupBox1.Controls.Add(this.txtNombreMascota);
            this.groupBox1.Controls.Add(this.txtIDMascota);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mskNacimiento);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 409);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro Mascota";
            // 
            // cmbPropietario
            // 
            this.cmbPropietario.FormattingEnabled = true;
            this.cmbPropietario.Location = new System.Drawing.Point(128, 192);
            this.cmbPropietario.Name = "cmbPropietario";
            this.cmbPropietario.Size = new System.Drawing.Size(163, 28);
            this.cmbPropietario.TabIndex = 14;
            // 
            // btnRegistrarMascota
            // 
            this.btnRegistrarMascota.BackColor = System.Drawing.Color.MistyRose;
            this.btnRegistrarMascota.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarMascota.Location = new System.Drawing.Point(57, 287);
            this.btnRegistrarMascota.Name = "btnRegistrarMascota";
            this.btnRegistrarMascota.Size = new System.Drawing.Size(185, 42);
            this.btnRegistrarMascota.TabIndex = 13;
            this.btnRegistrarMascota.Text = "Registrar Mascotas";
            this.btnRegistrarMascota.UseVisualStyleBackColor = false;
            this.btnRegistrarMascota.Click += new System.EventHandler(this.btnRegistrarMascota_Click);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(14, 232);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(277, 26);
            this.txtEdad.TabIndex = 12;
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(128, 127);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(163, 26);
            this.txtRaza.TabIndex = 10;
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(128, 95);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(163, 26);
            this.txtEspecie.TabIndex = 9;
            // 
            // txtNombreMascota
            // 
            this.txtNombreMascota.Location = new System.Drawing.Point(128, 63);
            this.txtNombreMascota.Name = "txtNombreMascota";
            this.txtNombreMascota.Size = new System.Drawing.Size(163, 26);
            this.txtNombreMascota.TabIndex = 8;
            // 
            // txtIDMascota
            // 
            this.txtIDMascota.Location = new System.Drawing.Point(128, 31);
            this.txtIDMascota.Name = "txtIDMascota";
            this.txtIDMascota.Size = new System.Drawing.Size(163, 26);
            this.txtIDMascota.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Propietario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "F. Nacimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Raza";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Especie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "ID";
            // 
            // mskNacimiento
            // 
            this.mskNacimiento.Location = new System.Drawing.Point(128, 159);
            this.mskNacimiento.Mask = "00/00/0000";
            this.mskNacimiento.Name = "mskNacimiento";
            this.mskNacimiento.Size = new System.Drawing.Size(163, 26);
            this.mskNacimiento.TabIndex = 0;
            this.mskNacimiento.ValidatingType = typeof(System.DateTime);
            this.mskNacimiento.Click += new System.EventHandler(this.mskNacimiento_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminarMascota);
            this.groupBox2.Controls.Add(this.btnActualizarMascota);
            this.groupBox2.Controls.Add(this.dataGridViewMascotas);
            this.groupBox2.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(972, 291);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mascotas Registradas";
            // 
            // btnEliminarMascota
            // 
            this.btnEliminarMascota.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMascota.ForeColor = System.Drawing.Color.Red;
            this.btnEliminarMascota.Location = new System.Drawing.Point(612, 219);
            this.btnEliminarMascota.Name = "btnEliminarMascota";
            this.btnEliminarMascota.Size = new System.Drawing.Size(149, 44);
            this.btnEliminarMascota.TabIndex = 2;
            this.btnEliminarMascota.Text = "Eliminar";
            this.btnEliminarMascota.UseVisualStyleBackColor = true;
            this.btnEliminarMascota.Click += new System.EventHandler(this.btnEliminarMascota_Click);
            // 
            // btnActualizarMascota
            // 
            this.btnActualizarMascota.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarMascota.Location = new System.Drawing.Point(436, 219);
            this.btnActualizarMascota.Name = "btnActualizarMascota";
            this.btnActualizarMascota.Size = new System.Drawing.Size(149, 44);
            this.btnActualizarMascota.TabIndex = 1;
            this.btnActualizarMascota.Text = "Actualizar";
            this.btnActualizarMascota.UseVisualStyleBackColor = true;
            this.btnActualizarMascota.Click += new System.EventHandler(this.btnActualizarMascota_Click);
            // 
            // dataGridViewMascotas
            // 
            this.dataGridViewMascotas.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridViewMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMascotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDMascota,
            this.NombreMascota,
            this.Especie,
            this.Raza,
            this.Edad,
            this.IDPropietario,
            this.NombrePropietario});
            this.dataGridViewMascotas.Location = new System.Drawing.Point(16, 45);
            this.dataGridViewMascotas.Name = "dataGridViewMascotas";
            this.dataGridViewMascotas.RowHeadersWidth = 51;
            this.dataGridViewMascotas.RowTemplate.Height = 24;
            this.dataGridViewMascotas.Size = new System.Drawing.Size(936, 150);
            this.dataGridViewMascotas.TabIndex = 0;
            // 
            // btnLimpiarMascota
            // 
            this.btnLimpiarMascota.BackColor = System.Drawing.Color.MistyRose;
            this.btnLimpiarMascota.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarMascota.Location = new System.Drawing.Point(57, 344);
            this.btnLimpiarMascota.Name = "btnLimpiarMascota";
            this.btnLimpiarMascota.Size = new System.Drawing.Size(185, 42);
            this.btnLimpiarMascota.TabIndex = 15;
            this.btnLimpiarMascota.Text = "Limpiar";
            this.btnLimpiarMascota.UseVisualStyleBackColor = false;
            this.btnLimpiarMascota.Click += new System.EventHandler(this.btnLimpiarMascota_Click);
            // 
            // IDMascota
            // 
            this.IDMascota.HeaderText = "ID";
            this.IDMascota.MinimumWidth = 6;
            this.IDMascota.Name = "IDMascota";
            this.IDMascota.Width = 125;
            // 
            // NombreMascota
            // 
            this.NombreMascota.HeaderText = "Nombre";
            this.NombreMascota.MinimumWidth = 6;
            this.NombreMascota.Name = "NombreMascota";
            this.NombreMascota.Width = 125;
            // 
            // Especie
            // 
            this.Especie.HeaderText = "Especie";
            this.Especie.MinimumWidth = 6;
            this.Especie.Name = "Especie";
            this.Especie.Width = 125;
            // 
            // Raza
            // 
            this.Raza.HeaderText = "Raza";
            this.Raza.MinimumWidth = 6;
            this.Raza.Name = "Raza";
            this.Raza.Width = 125;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.MinimumWidth = 6;
            this.Edad.Name = "Edad";
            this.Edad.Width = 125;
            // 
            // IDPropietario
            // 
            this.IDPropietario.HeaderText = "IDPropietario";
            this.IDPropietario.MinimumWidth = 6;
            this.IDPropietario.Name = "IDPropietario";
            this.IDPropietario.Width = 125;
            // 
            // NombrePropietario
            // 
            this.NombrePropietario.HeaderText = "Propietario";
            this.NombrePropietario.MinimumWidth = 6;
            this.NombrePropietario.Name = "NombrePropietario";
            this.NombrePropietario.Width = 125;
            // 
            // Mascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 586);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Mascota";
            this.Text = "Mascota";
            this.Load += new System.EventHandler(this.Mascota_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMascotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mskNacimiento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.TextBox txtNombreMascota;
        private System.Windows.Forms.TextBox txtIDMascota;
        private System.Windows.Forms.Button btnRegistrarMascota;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.ComboBox cmbPropietario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewMascotas;
        private System.Windows.Forms.Button btnEliminarMascota;
        private System.Windows.Forms.Button btnActualizarMascota;
        private System.Windows.Forms.Button btnLimpiarMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Raza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPropietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePropietario;
    }
}