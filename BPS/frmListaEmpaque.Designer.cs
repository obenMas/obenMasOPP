namespace BPS
{
    partial class frmListaEmpaque
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ancho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiamCore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeBarPallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoPalletBto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoPalletNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PNetoBobina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeBarBobina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Metraje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diametro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodInterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoteExtrusion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeRMadre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FecFabricacionRMadre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdenDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnObtener = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbOrden = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.txtPallets = new System.Windows.Forms.TextBox();
            this.txtBobinas = new System.Windows.Forms.TextBox();
            this.txtNeto = new System.Windows.Forms.TextBox();
            this.txtBruto = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgv, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1261, 474);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Orden,
            this.Codigo,
            this.Ancho,
            this.DiamCore,
            this.CodeBarPallet,
            this.PesoPalletBto,
            this.PesoPalletNeto,
            this.Fecha,
            this.PNetoBobina,
            this.CodeBarBobina,
            this.Metraje,
            this.Diametro,
            this.CodInterno,
            this.LoteExtrusion,
            this.CodeRMadre,
            this.FecFabricacionRMadre,
            this.OrdenDestino});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 63);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(1255, 338);
            this.dgv.TabIndex = 2;
            // 
            // Orden
            // 
            this.Orden.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Orden.HeaderText = "Orden";
            this.Orden.Name = "Orden";
            this.Orden.ReadOnly = true;
            this.Orden.Width = 61;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 65;
            // 
            // Ancho
            // 
            this.Ancho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ancho.HeaderText = "Ancho";
            this.Ancho.Name = "Ancho";
            this.Ancho.ReadOnly = true;
            this.Ancho.Width = 63;
            // 
            // DiamCore
            // 
            this.DiamCore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DiamCore.HeaderText = "DiamCore";
            this.DiamCore.Name = "DiamCore";
            this.DiamCore.ReadOnly = true;
            this.DiamCore.Width = 78;
            // 
            // CodeBarPallet
            // 
            this.CodeBarPallet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CodeBarPallet.HeaderText = "CodeBarPallet";
            this.CodeBarPallet.Name = "CodeBarPallet";
            this.CodeBarPallet.ReadOnly = true;
            this.CodeBarPallet.Width = 99;
            // 
            // PesoPalletBto
            // 
            this.PesoPalletBto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PesoPalletBto.HeaderText = "PesoPalletBto";
            this.PesoPalletBto.Name = "PesoPalletBto";
            this.PesoPalletBto.ReadOnly = true;
            this.PesoPalletBto.Width = 98;
            // 
            // PesoPalletNeto
            // 
            this.PesoPalletNeto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PesoPalletNeto.HeaderText = "PesoPalletNeto";
            this.PesoPalletNeto.Name = "PesoPalletNeto";
            this.PesoPalletNeto.ReadOnly = true;
            this.PesoPalletNeto.Width = 105;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 62;
            // 
            // PNetoBobina
            // 
            this.PNetoBobina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PNetoBobina.HeaderText = "PNetoBobina";
            this.PNetoBobina.Name = "PNetoBobina";
            this.PNetoBobina.ReadOnly = true;
            this.PNetoBobina.Width = 95;
            // 
            // CodeBarBobina
            // 
            this.CodeBarBobina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CodeBarBobina.HeaderText = "CodeBarBobina";
            this.CodeBarBobina.Name = "CodeBarBobina";
            this.CodeBarBobina.ReadOnly = true;
            this.CodeBarBobina.Width = 106;
            // 
            // Metraje
            // 
            this.Metraje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Metraje.HeaderText = "Metraje";
            this.Metraje.Name = "Metraje";
            this.Metraje.ReadOnly = true;
            this.Metraje.Width = 67;
            // 
            // Diametro
            // 
            this.Diametro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Diametro.HeaderText = "Diametro";
            this.Diametro.Name = "Diametro";
            this.Diametro.ReadOnly = true;
            this.Diametro.Width = 74;
            // 
            // CodInterno
            // 
            this.CodInterno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CodInterno.HeaderText = "CodInterno";
            this.CodInterno.Name = "CodInterno";
            this.CodInterno.ReadOnly = true;
            this.CodInterno.Width = 84;
            // 
            // LoteExtrusion
            // 
            this.LoteExtrusion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LoteExtrusion.HeaderText = "LoteExtrusion";
            this.LoteExtrusion.Name = "LoteExtrusion";
            this.LoteExtrusion.ReadOnly = true;
            this.LoteExtrusion.Width = 96;
            // 
            // CodeRMadre
            // 
            this.CodeRMadre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CodeRMadre.HeaderText = "CodeRMadre";
            this.CodeRMadre.Name = "CodeRMadre";
            this.CodeRMadre.ReadOnly = true;
            this.CodeRMadre.Width = 95;
            // 
            // FecFabricacionRMadre
            // 
            this.FecFabricacionRMadre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FecFabricacionRMadre.HeaderText = "FecFabricacionRMadre";
            this.FecFabricacionRMadre.Name = "FecFabricacionRMadre";
            this.FecFabricacionRMadre.ReadOnly = true;
            this.FecFabricacionRMadre.Width = 143;
            // 
            // OrdenDestino
            // 
            this.OrdenDestino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OrdenDestino.HeaderText = "OrdenDestino";
            this.OrdenDestino.Name = "OrdenDestino";
            this.OrdenDestino.ReadOnly = true;
            this.OrdenDestino.Width = 97;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnObtener, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox5, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1255, 54);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btnObtener
            // 
            this.btnObtener.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnObtener.Location = new System.Drawing.Point(831, 3);
            this.btnObtener.Name = "btnObtener";
            this.btnObtener.Size = new System.Drawing.Size(421, 48);
            this.btnObtener.TabIndex = 2;
            this.btnObtener.Text = "Obtener datos";
            this.btnObtener.UseVisualStyleBackColor = true;
            this.btnObtener.Click += new System.EventHandler(this.btnObtener_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbCliente);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(408, 48);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cliente";
            // 
            // cmbCliente
            // 
            this.cmbCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(3, 16);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(402, 21);
            this.cmbCliente.TabIndex = 0;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbOrden);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(417, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(408, 48);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Orden";
            // 
            // cmbOrden
            // 
            this.cmbOrden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbOrden.FormattingEnabled = true;
            this.cmbOrden.Location = new System.Drawing.Point(3, 16);
            this.cmbOrden.Name = "cmbOrden";
            this.cmbOrden.Size = new System.Drawing.Size(402, 21);
            this.cmbOrden.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 407);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1255, 64);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Totales";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox6, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox7, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnExcel, 4, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1249, 45);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPallets);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 39);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pallets";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBobinas);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(252, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 39);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bobinas";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtNeto);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(501, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(243, 39);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Peso Neto";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtBruto);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(750, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(243, 39);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Peso Bruto";
            // 
            // btnExcel
            // 
            this.btnExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExcel.Location = new System.Drawing.Point(999, 3);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(247, 39);
            this.btnExcel.TabIndex = 4;
            this.btnExcel.Text = "Exportar a Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // txtPallets
            // 
            this.txtPallets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPallets.Location = new System.Drawing.Point(3, 16);
            this.txtPallets.Name = "txtPallets";
            this.txtPallets.Size = new System.Drawing.Size(237, 20);
            this.txtPallets.TabIndex = 0;
            this.txtPallets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBobinas
            // 
            this.txtBobinas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBobinas.Location = new System.Drawing.Point(3, 16);
            this.txtBobinas.Name = "txtBobinas";
            this.txtBobinas.Size = new System.Drawing.Size(237, 20);
            this.txtBobinas.TabIndex = 0;
            this.txtBobinas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNeto
            // 
            this.txtNeto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNeto.Location = new System.Drawing.Point(3, 16);
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.Size = new System.Drawing.Size(237, 20);
            this.txtNeto.TabIndex = 0;
            this.txtNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBruto
            // 
            this.txtBruto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBruto.Location = new System.Drawing.Point(3, 16);
            this.txtBruto.Name = "txtBruto";
            this.txtBruto.Size = new System.Drawing.Size(237, 20);
            this.txtBruto.TabIndex = 0;
            this.txtBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmListaEmpaque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 474);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmListaEmpaque";
            this.ShowIcon = false;
            this.Text = "Lista de empaque";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cmbOrden;
        private System.Windows.Forms.Button btnObtener;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ancho;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiamCore;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeBarPallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoPalletBto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoPalletNeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn PNetoBobina;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeBarBobina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Metraje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diametro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodInterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoteExtrusion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeRMadre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FecFabricacionRMadre;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdenDestino;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPallets;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBobinas;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtNeto;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtBruto;
        private System.Windows.Forms.Button btnExcel;
    }
}