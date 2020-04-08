namespace BPS.Lite
{
    partial class frmPCPTProductionControl
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
            this.dgvControl = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.clmExtrusora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPlanta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDeposito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMateriaPrima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipoMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmScrap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCalif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControl)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvControl
            // 
            this.dgvControl.AllowUserToAddRows = false;
            this.dgvControl.AllowUserToDeleteRows = false;
            this.dgvControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmExtrusora,
            this.clmPlanta,
            this.clmCliente,
            this.clmDeposito,
            this.clmPelicula,
            this.clmMateriaPrima,
            this.clmCodMaterial,
            this.clmTipoMaterial,
            this.clmMaterial,
            this.clmScrap,
            this.clmSubtotal,
            this.clmTipo,
            this.clmCalif});
            this.dgvControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvControl.Location = new System.Drawing.Point(3, 16);
            this.dgvControl.Name = "dgvControl";
            this.dgvControl.ReadOnly = true;
            this.dgvControl.RowHeadersWidth = 10;
            this.dgvControl.Size = new System.Drawing.Size(690, 340);
            this.dgvControl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasta:";
            // 
            // button1
            // 
            this.button1.Image = global::BPS.Lite.Properties.Resources.doc_excel_table;
            this.button1.Location = new System.Drawing.Point(522, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 38);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(475, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total[T]";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(525, 16);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(69, 20);
            this.txtTotal.TabIndex = 7;
            // 
            // txtDesde
            // 
            this.txtDesde.Enabled = false;
            this.txtDesde.Location = new System.Drawing.Point(157, 24);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(122, 20);
            this.txtDesde.TabIndex = 8;
            this.txtDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHasta
            // 
            this.txtHasta.Enabled = false;
            this.txtHasta.Location = new System.Drawing.Point(157, 62);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(122, 20);
            this.txtHasta.TabIndex = 9;
            this.txtHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHasta);
            this.groupBox1.Controls.Add(this.txtDesde);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 94);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fechas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(702, 472);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvControl);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 110);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(696, 359);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtTotal);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 481);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(702, 46);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.36656F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.633437F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(708, 530);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // clmExtrusora
            // 
            this.clmExtrusora.HeaderText = "Extrusora";
            this.clmExtrusora.Name = "clmExtrusora";
            this.clmExtrusora.ReadOnly = true;
            // 
            // clmPlanta
            // 
            this.clmPlanta.HeaderText = "Planta";
            this.clmPlanta.Name = "clmPlanta";
            this.clmPlanta.ReadOnly = true;
            // 
            // clmCliente
            // 
            this.clmCliente.HeaderText = "Cliente";
            this.clmCliente.Name = "clmCliente";
            this.clmCliente.ReadOnly = true;
            // 
            // clmDeposito
            // 
            this.clmDeposito.HeaderText = "Deposito";
            this.clmDeposito.Name = "clmDeposito";
            this.clmDeposito.ReadOnly = true;
            this.clmDeposito.Width = 200;
            // 
            // clmPelicula
            // 
            this.clmPelicula.HeaderText = "Pelicula";
            this.clmPelicula.Name = "clmPelicula";
            this.clmPelicula.ReadOnly = true;
            // 
            // clmMateriaPrima
            // 
            this.clmMateriaPrima.HeaderText = "Materia Prima";
            this.clmMateriaPrima.Name = "clmMateriaPrima";
            this.clmMateriaPrima.ReadOnly = true;
            // 
            // clmCodMaterial
            // 
            this.clmCodMaterial.HeaderText = "Codigo Material";
            this.clmCodMaterial.Name = "clmCodMaterial";
            this.clmCodMaterial.ReadOnly = true;
            this.clmCodMaterial.Width = 150;
            // 
            // clmTipoMaterial
            // 
            this.clmTipoMaterial.HeaderText = "Tipo de material";
            this.clmTipoMaterial.Name = "clmTipoMaterial";
            this.clmTipoMaterial.ReadOnly = true;
            this.clmTipoMaterial.Width = 150;
            // 
            // clmMaterial
            // 
            this.clmMaterial.HeaderText = "Material";
            this.clmMaterial.Name = "clmMaterial";
            this.clmMaterial.ReadOnly = true;
            this.clmMaterial.Width = 300;
            // 
            // clmScrap
            // 
            this.clmScrap.HeaderText = "Scrap";
            this.clmScrap.Name = "clmScrap";
            this.clmScrap.ReadOnly = true;
            this.clmScrap.Visible = false;
            // 
            // clmSubtotal
            // 
            this.clmSubtotal.HeaderText = "Subtotal [T]";
            this.clmSubtotal.Name = "clmSubtotal";
            this.clmSubtotal.ReadOnly = true;
            // 
            // clmTipo
            // 
            this.clmTipo.HeaderText = "Tipo de corte";
            this.clmTipo.Name = "clmTipo";
            this.clmTipo.ReadOnly = true;
            this.clmTipo.Visible = false;
            // 
            // clmCalif
            // 
            this.clmCalif.HeaderText = "Calificación";
            this.clmCalif.Name = "clmCalif";
            this.clmCalif.ReadOnly = true;
            this.clmCalif.Visible = false;
            // 
            // frmPCPTProductionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 530);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmPCPTProductionControl";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvControl)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExtrusora;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPlanta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDeposito;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMateriaPrima;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipoMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmScrap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCalif;
    }
}