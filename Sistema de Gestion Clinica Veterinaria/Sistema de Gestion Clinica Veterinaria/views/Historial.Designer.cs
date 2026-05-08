namespace Sistema_de_Gestion_Clinica_Veterinaria.views
{
    partial class Historial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historial));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnVerTodo = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cmbPropietarioFiltro = new System.Windows.Forms.ComboBox();
            this.cmbMascotaFiltro = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewHistorial = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewResumenMascota = new System.Windows.Forms.DataGridView();
            this.btnMascotasAtendidas = new System.Windows.Forms.Button();
            this.btnConsultasTotales = new System.Windows.Forms.Button();
            this.btnIngresosTotales = new System.Windows.Forms.Button();
            this.btnPromedioConsulta = new System.Windows.Forms.Button();
            this.lblPromedioConsulta = new System.Windows.Forms.Label();
            this.lblMascotasAtendidas = new System.Windows.Forms.Label();
            this.lblConsultasTotales = new System.Windows.Forms.Label();
            this.lblIngresosTotales = new System.Windows.Forms.Label();
            this.ID_Historial_Consulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePropietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Propietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroConsultas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalFactuardo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorial)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResumenMascota)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 35);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historial Clinico";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1001, 110);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(434, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Registro medico completo por mascota e ingreso del periodo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(166, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 62);
            this.label2.TabIndex = 1;
            this.label2.Text = "Historial ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MistyRose;
            this.panel3.Controls.Add(this.btnVerTodo);
            this.panel3.Controls.Add(this.btnFiltrar);
            this.panel3.Controls.Add(this.cmbPropietarioFiltro);
            this.panel3.Controls.Add(this.cmbMascotaFiltro);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(13, 240);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(976, 79);
            this.panel3.TabIndex = 2;
            // 
            // btnVerTodo
            // 
            this.btnVerTodo.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodo.Location = new System.Drawing.Point(565, 27);
            this.btnVerTodo.Name = "btnVerTodo";
            this.btnVerTodo.Size = new System.Drawing.Size(99, 34);
            this.btnVerTodo.TabIndex = 5;
            this.btnVerTodo.Text = "Ver todo";
            this.btnVerTodo.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(444, 27);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(99, 34);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // cmbPropietarioFiltro
            // 
            this.cmbPropietarioFiltro.FormattingEnabled = true;
            this.cmbPropietarioFiltro.Location = new System.Drawing.Point(224, 37);
            this.cmbPropietarioFiltro.Name = "cmbPropietarioFiltro";
            this.cmbPropietarioFiltro.Size = new System.Drawing.Size(181, 24);
            this.cmbPropietarioFiltro.TabIndex = 3;
            // 
            // cmbMascotaFiltro
            // 
            this.cmbMascotaFiltro.FormattingEnabled = true;
            this.cmbMascotaFiltro.Location = new System.Drawing.Point(16, 37);
            this.cmbMascotaFiltro.Name = "cmbMascotaFiltro";
            this.cmbMascotaFiltro.Size = new System.Drawing.Size(181, 24);
            this.cmbMascotaFiltro.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(220, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Propietario :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mascota :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewHistorial);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(976, 165);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Historial de Consultas";
            // 
            // dataGridViewHistorial
            // 
            this.dataGridViewHistorial.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridViewHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Historial_Consulta,
            this.FechaConsulta,
            this.NombreMascota,
            this.NombrePropietario,
            this.Diagnostico,
            this.Motivo,
            this.Costo});
            this.dataGridViewHistorial.Location = new System.Drawing.Point(16, 26);
            this.dataGridViewHistorial.Name = "dataGridViewHistorial";
            this.dataGridViewHistorial.RowHeadersWidth = 51;
            this.dataGridViewHistorial.RowTemplate.Height = 24;
            this.dataGridViewHistorial.Size = new System.Drawing.Size(936, 124);
            this.dataGridViewHistorial.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewResumenMascota);
            this.groupBox2.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 507);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(976, 203);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resumen por Mascota";
            // 
            // dataGridViewResumenMascota
            // 
            this.dataGridViewResumenMascota.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridViewResumenMascota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResumenMascota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Propietario,
            this.NumeroConsultas,
            this.TotalFactuardo});
            this.dataGridViewResumenMascota.Location = new System.Drawing.Point(15, 51);
            this.dataGridViewResumenMascota.Name = "dataGridViewResumenMascota";
            this.dataGridViewResumenMascota.RowHeadersWidth = 51;
            this.dataGridViewResumenMascota.RowTemplate.Height = 24;
            this.dataGridViewResumenMascota.Size = new System.Drawing.Size(936, 117);
            this.dataGridViewResumenMascota.TabIndex = 0;
            // 
            // btnMascotasAtendidas
            // 
            this.btnMascotasAtendidas.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMascotasAtendidas.Location = new System.Drawing.Point(29, 153);
            this.btnMascotasAtendidas.Name = "btnMascotasAtendidas";
            this.btnMascotasAtendidas.Size = new System.Drawing.Size(182, 71);
            this.btnMascotasAtendidas.TabIndex = 0;
            this.btnMascotasAtendidas.Text = "Mascotas Atendidas";
            this.btnMascotasAtendidas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMascotasAtendidas.UseVisualStyleBackColor = true;
            this.btnMascotasAtendidas.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnConsultasTotales
            // 
            this.btnConsultasTotales.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultasTotales.Location = new System.Drawing.Point(264, 153);
            this.btnConsultasTotales.Name = "btnConsultasTotales";
            this.btnConsultasTotales.Size = new System.Drawing.Size(182, 71);
            this.btnConsultasTotales.TabIndex = 1;
            this.btnConsultasTotales.Text = "Consultas Totales";
            this.btnConsultasTotales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultasTotales.UseVisualStyleBackColor = true;
            // 
            // btnIngresosTotales
            // 
            this.btnIngresosTotales.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresosTotales.Location = new System.Drawing.Point(511, 153);
            this.btnIngresosTotales.Name = "btnIngresosTotales";
            this.btnIngresosTotales.Size = new System.Drawing.Size(201, 71);
            this.btnIngresosTotales.TabIndex = 2;
            this.btnIngresosTotales.Text = "Ingresos Totales";
            this.btnIngresosTotales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIngresosTotales.UseVisualStyleBackColor = true;
            // 
            // btnPromedioConsulta
            // 
            this.btnPromedioConsulta.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromedioConsulta.Location = new System.Drawing.Point(746, 153);
            this.btnPromedioConsulta.Name = "btnPromedioConsulta";
            this.btnPromedioConsulta.Size = new System.Drawing.Size(219, 71);
            this.btnPromedioConsulta.TabIndex = 8;
            this.btnPromedioConsulta.Text = "Promedio Por Consulta";
            this.btnPromedioConsulta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPromedioConsulta.UseVisualStyleBackColor = true;
            // 
            // lblPromedioConsulta
            // 
            this.lblPromedioConsulta.AutoSize = true;
            this.lblPromedioConsulta.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPromedioConsulta.Location = new System.Drawing.Point(771, 164);
            this.lblPromedioConsulta.Name = "lblPromedioConsulta";
            this.lblPromedioConsulta.Size = new System.Drawing.Size(30, 34);
            this.lblPromedioConsulta.TabIndex = 9;
            this.lblPromedioConsulta.Text = "0";
            // 
            // lblMascotasAtendidas
            // 
            this.lblMascotasAtendidas.AutoSize = true;
            this.lblMascotasAtendidas.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMascotasAtendidas.ForeColor = System.Drawing.Color.Blue;
            this.lblMascotasAtendidas.Location = new System.Drawing.Point(108, 164);
            this.lblMascotasAtendidas.Name = "lblMascotasAtendidas";
            this.lblMascotasAtendidas.Size = new System.Drawing.Size(30, 34);
            this.lblMascotasAtendidas.TabIndex = 3;
            this.lblMascotasAtendidas.Text = "0";
            // 
            // lblConsultasTotales
            // 
            this.lblConsultasTotales.AutoSize = true;
            this.lblConsultasTotales.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultasTotales.ForeColor = System.Drawing.Color.Blue;
            this.lblConsultasTotales.Location = new System.Drawing.Point(342, 164);
            this.lblConsultasTotales.Name = "lblConsultasTotales";
            this.lblConsultasTotales.Size = new System.Drawing.Size(30, 34);
            this.lblConsultasTotales.TabIndex = 8;
            this.lblConsultasTotales.Text = "0";
            // 
            // lblIngresosTotales
            // 
            this.lblIngresosTotales.AutoSize = true;
            this.lblIngresosTotales.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresosTotales.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblIngresosTotales.Location = new System.Drawing.Point(525, 164);
            this.lblIngresosTotales.Name = "lblIngresosTotales";
            this.lblIngresosTotales.Size = new System.Drawing.Size(31, 34);
            this.lblIngresosTotales.TabIndex = 9;
            this.lblIngresosTotales.Text = "0";
            this.lblIngresosTotales.Click += new System.EventHandler(this.lblIngresosTotales_Click);
            // 
            // ID_Historial_Consulta
            // 
            this.ID_Historial_Consulta.HeaderText = "ID";
            this.ID_Historial_Consulta.MinimumWidth = 6;
            this.ID_Historial_Consulta.Name = "ID_Historial_Consulta";
            this.ID_Historial_Consulta.Width = 125;
            // 
            // FechaConsulta
            // 
            this.FechaConsulta.HeaderText = "Fecha de la Consula";
            this.FechaConsulta.MinimumWidth = 6;
            this.FechaConsulta.Name = "FechaConsulta";
            this.FechaConsulta.Width = 125;
            // 
            // NombreMascota
            // 
            this.NombreMascota.HeaderText = "Mascota";
            this.NombreMascota.MinimumWidth = 6;
            this.NombreMascota.Name = "NombreMascota";
            this.NombreMascota.Width = 125;
            // 
            // NombrePropietario
            // 
            this.NombrePropietario.HeaderText = "Propietario";
            this.NombrePropietario.MinimumWidth = 6;
            this.NombrePropietario.Name = "NombrePropietario";
            this.NombrePropietario.Width = 125;
            // 
            // Diagnostico
            // 
            this.Diagnostico.HeaderText = "Diagnostico";
            this.Diagnostico.MinimumWidth = 6;
            this.Diagnostico.Name = "Diagnostico";
            this.Diagnostico.Width = 125;
            // 
            // Motivo
            // 
            this.Motivo.HeaderText = "Motivo";
            this.Motivo.MinimumWidth = 6;
            this.Motivo.Name = "Motivo";
            this.Motivo.Width = 125;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.MinimumWidth = 6;
            this.Costo.Name = "Costo";
            this.Costo.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // Propietario
            // 
            this.Propietario.HeaderText = "Propietario";
            this.Propietario.MinimumWidth = 6;
            this.Propietario.Name = "Propietario";
            this.Propietario.Width = 125;
            // 
            // NumeroConsultas
            // 
            this.NumeroConsultas.HeaderText = "Numero de Consultas";
            this.NumeroConsultas.MinimumWidth = 6;
            this.NumeroConsultas.Name = "NumeroConsultas";
            this.NumeroConsultas.Width = 125;
            // 
            // TotalFactuardo
            // 
            this.TotalFactuardo.HeaderText = "Total Facturado";
            this.TotalFactuardo.MinimumWidth = 6;
            this.TotalFactuardo.Name = "TotalFactuardo";
            this.TotalFactuardo.Width = 125;
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1001, 722);
            this.Controls.Add(this.lblPromedioConsulta);
            this.Controls.Add(this.btnPromedioConsulta);
            this.Controls.Add(this.lblIngresosTotales);
            this.Controls.Add(this.lblConsultasTotales);
            this.Controls.Add(this.btnIngresosTotales);
            this.Controls.Add(this.lblMascotasAtendidas);
            this.Controls.Add(this.btnConsultasTotales);
            this.Controls.Add(this.btnMascotasAtendidas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Historial";
            this.Text = "Historial";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorial)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResumenMascota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVerTodo;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cmbPropietarioFiltro;
        private System.Windows.Forms.ComboBox cmbMascotaFiltro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewHistorial;
        private System.Windows.Forms.DataGridView dataGridViewResumenMascota;
        private System.Windows.Forms.Button btnMascotasAtendidas;
        private System.Windows.Forms.Button btnIngresosTotales;
        private System.Windows.Forms.Button btnConsultasTotales;
        private System.Windows.Forms.Button btnPromedioConsulta;
        private System.Windows.Forms.Label lblPromedioConsulta;
        private System.Windows.Forms.Label lblMascotasAtendidas;
        private System.Windows.Forms.Label lblConsultasTotales;
        private System.Windows.Forms.Label lblIngresosTotales;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Historial_Consulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePropietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Propietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroConsultas;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalFactuardo;
    }
}