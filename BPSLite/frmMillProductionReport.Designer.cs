﻿namespace BPS.Lite
{
    partial class frmMillProductionReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMillProductionReport));
            this.btnGenerar = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmbPlanta = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.dgvMillProduction = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPesos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTorta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPlanta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMillProduction)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(699, 43);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(121, 51);
            this.btnGenerar.TabIndex = 22;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmbPlanta);
            this.groupBox6.Location = new System.Drawing.Point(542, 43);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(133, 52);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            // 
            // cmbPlanta
            // 
            this.cmbPlanta.FormattingEnabled = true;
            this.cmbPlanta.Location = new System.Drawing.Point(12, 19);
            this.cmbPlanta.Name = "cmbPlanta";
            this.cmbPlanta.Size = new System.Drawing.Size(108, 21);
            this.cmbPlanta.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(542, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(103, 31);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(8, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Planta:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpHasta);
            this.groupBox4.Location = new System.Drawing.Point(273, 42);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(263, 52);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(6, 21);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(251, 20);
            this.dtpHasta.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(273, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 31);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hasta:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpDesde);
            this.groupBox2.Location = new System.Drawing.Point(4, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 52);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(6, 21);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(251, 20);
            this.dtpDesde.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 31);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde:";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Image = global::BPS.Lite.Properties.Resources.doc_excel_table;
            this.btnExportExcel.Location = new System.Drawing.Point(850, 60);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(43, 35);
            this.btnExportExcel.TabIndex = 23;
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // dgvMillProduction
            // 
            this.dgvMillProduction.AllowUserToAddRows = false;
            this.dgvMillProduction.AllowUserToDeleteRows = false;
            this.dgvMillProduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMillProduction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmTipo,
            this.clmPeso,
            this.clmTorta,
            this.clmPlanta,
            this.clmUsuario,
            this.clmFecha});
            this.dgvMillProduction.Location = new System.Drawing.Point(5, 100);
            this.dgvMillProduction.Name = "dgvMillProduction";
            this.dgvMillProduction.ReadOnly = true;
            this.dgvMillProduction.Size = new System.Drawing.Size(888, 333);
            this.dgvMillProduction.TabIndex = 29;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.txtPesos);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Location = new System.Drawing.Point(5, 440);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(214, 59);
            this.groupBox7.TabIndex = 30;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Pesos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Kg";
            // 
            // txtPesos
            // 
            this.txtPesos.Enabled = false;
            this.txtPesos.Location = new System.Drawing.Point(50, 23);
            this.txtPesos.Name = "txtPesos";
            this.txtPesos.Size = new System.Drawing.Size(133, 20);
            this.txtPesos.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pesos";
            // 
            // clmCodigo
            // 
            this.clmCodigo.HeaderText = "Código";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            this.clmCodigo.Width = 120;
            // 
            // clmTipo
            // 
            this.clmTipo.HeaderText = "Tipo Scrap";
            this.clmTipo.Name = "clmTipo";
            this.clmTipo.ReadOnly = true;
            this.clmTipo.Width = 200;
            // 
            // clmPeso
            // 
            this.clmPeso.HeaderText = "Peso Producido";
            this.clmPeso.Name = "clmPeso";
            this.clmPeso.ReadOnly = true;
            // 
            // clmTorta
            // 
            this.clmTorta.HeaderText = "Peso Torta";
            this.clmTorta.Name = "clmTorta";
            this.clmTorta.ReadOnly = true;
            // 
            // clmPlanta
            // 
            this.clmPlanta.HeaderText = "Planta";
            this.clmPlanta.Name = "clmPlanta";
            this.clmPlanta.ReadOnly = true;
            // 
            // clmUsuario
            // 
            this.clmUsuario.HeaderText = "Usuario";
            this.clmUsuario.Name = "clmUsuario";
            this.clmUsuario.ReadOnly = true;
            // 
            // clmFecha
            // 
            this.clmFecha.HeaderText = "Fecha";
            this.clmFecha.Name = "clmFecha";
            this.clmFecha.ReadOnly = true;
            // 
            // frmMillProductionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 511);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.dgvMillProduction);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExportExcel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMillProductionReport";
            this.Text = "Reporte produccion de molino";
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMillProduction)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cmbPlanta;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.DataGridView dgvMillProduction;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPesos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTorta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPlanta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFecha;
    }
}