namespace BPS.Lite
{
    partial class Romaneo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Romaneo));
            this.txtPDViejo = new System.Windows.Forms.TextBox();
            this.dgvViejo = new System.Windows.Forms.DataGridView();
            this.Datos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExportViejo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarViejo = new System.Windows.Forms.Button();
            this.txtAgregadosViejo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiarViejo = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpiarNuevo = new System.Windows.Forms.Button();
            this.txtPDNuevo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvNuevo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAgregadosNuevo = new System.Windows.Forms.TextBox();
            this.btnExportarNuevo = new System.Windows.Forms.Button();
            this.btnAgregadoNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViejo)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPDViejo
            // 
            this.txtPDViejo.Location = new System.Drawing.Point(151, 10);
            this.txtPDViejo.Name = "txtPDViejo";
            this.txtPDViejo.Size = new System.Drawing.Size(100, 20);
            this.txtPDViejo.TabIndex = 0;
            this.txtPDViejo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // dgvViejo
            // 
            this.dgvViejo.AllowUserToAddRows = false;
            this.dgvViejo.AllowUserToDeleteRows = false;
            this.dgvViejo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViejo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Datos});
            this.dgvViejo.Location = new System.Drawing.Point(15, 93);
            this.dgvViejo.Name = "dgvViejo";
            this.dgvViejo.ReadOnly = true;
            this.dgvViejo.Size = new System.Drawing.Size(804, 372);
            this.dgvViejo.TabIndex = 1;
            // 
            // Datos
            // 
            this.Datos.HeaderText = "Datos";
            this.Datos.Name = "Datos";
            this.Datos.ReadOnly = true;
            this.Datos.Width = 730;
            // 
            // btnExportViejo
            // 
            this.btnExportViejo.Location = new System.Drawing.Point(661, 10);
            this.btnExportViejo.Name = "btnExportViejo";
            this.btnExportViejo.Size = new System.Drawing.Size(158, 23);
            this.btnExportViejo.TabIndex = 24;
            this.btnExportViejo.Text = "Exportar a txt";
            this.btnExportViejo.UseVisualStyleBackColor = true;
            this.btnExportViejo.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Número de pre-despacho:";
            // 
            // btnAgregarViejo
            // 
            this.btnAgregarViejo.Location = new System.Drawing.Point(257, 9);
            this.btnAgregarViejo.Name = "btnAgregarViejo";
            this.btnAgregarViejo.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarViejo.TabIndex = 26;
            this.btnAgregarViejo.Text = "Agregar";
            this.btnAgregarViejo.UseVisualStyleBackColor = true;
            this.btnAgregarViejo.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAgregadosViejo
            // 
            this.txtAgregadosViejo.Enabled = false;
            this.txtAgregadosViejo.Location = new System.Drawing.Point(151, 51);
            this.txtAgregadosViejo.Name = "txtAgregadosViejo";
            this.txtAgregadosViejo.Size = new System.Drawing.Size(668, 20);
            this.txtAgregadosViejo.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Pre-despachos agregados:";
            // 
            // btnLimpiarViejo
            // 
            this.btnLimpiarViejo.Location = new System.Drawing.Point(338, 9);
            this.btnLimpiarViejo.Name = "btnLimpiarViejo";
            this.btnLimpiarViejo.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarViejo.TabIndex = 29;
            this.btnLimpiarViejo.Text = "Limpiar";
            this.btnLimpiarViejo.UseVisualStyleBackColor = true;
            this.btnLimpiarViejo.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(844, 498);
            this.tabControl1.TabIndex = 30;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnLimpiarNuevo);
            this.tabPage1.Controls.Add(this.txtPDNuevo);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dgvNuevo);
            this.tabPage1.Controls.Add(this.txtAgregadosNuevo);
            this.tabPage1.Controls.Add(this.btnExportarNuevo);
            this.tabPage1.Controls.Add(this.btnAgregadoNuevo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(836, 472);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sistema PD nuevo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnLimpiarViejo);
            this.tabPage2.Controls.Add(this.txtPDViejo);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dgvViejo);
            this.tabPage2.Controls.Add(this.txtAgregadosViejo);
            this.tabPage2.Controls.Add(this.btnExportViejo);
            this.tabPage2.Controls.Add(this.btnAgregarViejo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(836, 472);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sistema PD viejo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Número de pre-despacho:";
            // 
            // btnLimpiarNuevo
            // 
            this.btnLimpiarNuevo.Location = new System.Drawing.Point(340, 8);
            this.btnLimpiarNuevo.Name = "btnLimpiarNuevo";
            this.btnLimpiarNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarNuevo.TabIndex = 37;
            this.btnLimpiarNuevo.Text = "Limpiar";
            this.btnLimpiarNuevo.UseVisualStyleBackColor = true;
            this.btnLimpiarNuevo.Click += new System.EventHandler(this.btnLimpiarNuevo_Click);
            // 
            // txtPDNuevo
            // 
            this.txtPDNuevo.Location = new System.Drawing.Point(153, 9);
            this.txtPDNuevo.Name = "txtPDNuevo";
            this.txtPDNuevo.Size = new System.Drawing.Size(100, 20);
            this.txtPDNuevo.TabIndex = 30;
            this.txtPDNuevo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPDNuevo_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Pre-despachos agregados:";
            // 
            // dgvNuevo
            // 
            this.dgvNuevo.AllowUserToAddRows = false;
            this.dgvNuevo.AllowUserToDeleteRows = false;
            this.dgvNuevo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNuevo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvNuevo.Location = new System.Drawing.Point(17, 92);
            this.dgvNuevo.Name = "dgvNuevo";
            this.dgvNuevo.ReadOnly = true;
            this.dgvNuevo.Size = new System.Drawing.Size(804, 372);
            this.dgvNuevo.TabIndex = 31;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Datos";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 730;
            // 
            // txtAgregadosNuevo
            // 
            this.txtAgregadosNuevo.Enabled = false;
            this.txtAgregadosNuevo.Location = new System.Drawing.Point(153, 50);
            this.txtAgregadosNuevo.Name = "txtAgregadosNuevo";
            this.txtAgregadosNuevo.Size = new System.Drawing.Size(668, 20);
            this.txtAgregadosNuevo.TabIndex = 35;
            // 
            // btnExportarNuevo
            // 
            this.btnExportarNuevo.Location = new System.Drawing.Point(663, 9);
            this.btnExportarNuevo.Name = "btnExportarNuevo";
            this.btnExportarNuevo.Size = new System.Drawing.Size(158, 23);
            this.btnExportarNuevo.TabIndex = 32;
            this.btnExportarNuevo.Text = "Exportar a txt";
            this.btnExportarNuevo.UseVisualStyleBackColor = true;
            this.btnExportarNuevo.Click += new System.EventHandler(this.btnExportarNuevo_Click);
            // 
            // btnAgregadoNuevo
            // 
            this.btnAgregadoNuevo.Location = new System.Drawing.Point(259, 8);
            this.btnAgregadoNuevo.Name = "btnAgregadoNuevo";
            this.btnAgregadoNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnAgregadoNuevo.TabIndex = 34;
            this.btnAgregadoNuevo.Text = "Agregar";
            this.btnAgregadoNuevo.UseVisualStyleBackColor = true;
            this.btnAgregadoNuevo.Click += new System.EventHandler(this.button5_Click);
            // 
            // Romaneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 533);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Romaneo";
            this.Text = "Romaneo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvViejo)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPDViejo;
        private System.Windows.Forms.DataGridView dgvViejo;
        private System.Windows.Forms.Button btnExportViejo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarViejo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datos;
        private System.Windows.Forms.TextBox txtAgregadosViejo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiarViejo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpiarNuevo;
        private System.Windows.Forms.TextBox txtPDNuevo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox txtAgregadosNuevo;
        private System.Windows.Forms.Button btnExportarNuevo;
        private System.Windows.Forms.Button btnAgregadoNuevo;
        private System.Windows.Forms.TabPage tabPage2;
    }
}