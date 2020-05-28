namespace BPS.Lite
{
    partial class frmInputRawMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInputRawMaterial));
            this.dgvEntradaMaterPrima = new System.Windows.Forms.DataGridView();
            this.btnImportar = new System.Windows.Forms.Button();
            this.clmCodAlfa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPartida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombreEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRecption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPallets = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmGranel = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradaMaterPrima)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEntradaMaterPrima
            // 
            this.dgvEntradaMaterPrima.AllowUserToAddRows = false;
            this.dgvEntradaMaterPrima.AllowUserToDeleteRows = false;
            this.dgvEntradaMaterPrima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradaMaterPrima.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodAlfa,
            this.clmCantidad,
            this.clmPartida,
            this.clmProveedor,
            this.clmEmpresa,
            this.clmNombreEmpresa,
            this.clmFecha,
            this.clmRecption,
            this.clmPallets,
            this.clmGranel});
            this.dgvEntradaMaterPrima.Location = new System.Drawing.Point(7, 54);
            this.dgvEntradaMaterPrima.Name = "dgvEntradaMaterPrima";
            this.dgvEntradaMaterPrima.ReadOnly = true;
            this.dgvEntradaMaterPrima.Size = new System.Drawing.Size(1063, 262);
            this.dgvEntradaMaterPrima.TabIndex = 0;
            this.dgvEntradaMaterPrima.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntradaMaterPrima_CellContentClick);
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(955, 12);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(115, 36);
            this.btnImportar.TabIndex = 1;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.Importar_Click);
            // 
            // clmCodAlfa
            // 
            this.clmCodAlfa.DataPropertyName = "COD_ALFA";
            this.clmCodAlfa.HeaderText = "Codigo Alpha";
            this.clmCodAlfa.Name = "clmCodAlfa";
            this.clmCodAlfa.ReadOnly = true;
            this.clmCodAlfa.Width = 130;
            // 
            // clmCantidad
            // 
            this.clmCantidad.DataPropertyName = "CANTIDAD";
            this.clmCantidad.HeaderText = "Cantidad";
            this.clmCantidad.Name = "clmCantidad";
            this.clmCantidad.ReadOnly = true;
            // 
            // clmPartida
            // 
            this.clmPartida.DataPropertyName = "PARTIDA";
            this.clmPartida.HeaderText = "Partida";
            this.clmPartida.Name = "clmPartida";
            this.clmPartida.ReadOnly = true;
            // 
            // clmProveedor
            // 
            this.clmProveedor.DataPropertyName = "PROVEEDOR";
            this.clmProveedor.HeaderText = "Proveedor";
            this.clmProveedor.Name = "clmProveedor";
            this.clmProveedor.ReadOnly = true;
            // 
            // clmEmpresa
            // 
            this.clmEmpresa.DataPropertyName = "EMPRESA";
            this.clmEmpresa.HeaderText = "Empresa";
            this.clmEmpresa.Name = "clmEmpresa";
            this.clmEmpresa.ReadOnly = true;
            // 
            // clmNombreEmpresa
            // 
            this.clmNombreEmpresa.DataPropertyName = "NOMBRE";
            this.clmNombreEmpresa.HeaderText = "Nombre Empresa";
            this.clmNombreEmpresa.Name = "clmNombreEmpresa";
            this.clmNombreEmpresa.ReadOnly = true;
            // 
            // clmFecha
            // 
            this.clmFecha.DataPropertyName = "FECHA";
            this.clmFecha.HeaderText = "Fecha";
            this.clmFecha.Name = "clmFecha";
            this.clmFecha.ReadOnly = true;
            // 
            // clmRecption
            // 
            this.clmRecption.DataPropertyName = "NNUMERO";
            this.clmRecption.HeaderText = "Recepción";
            this.clmRecption.Name = "clmRecption";
            this.clmRecption.ReadOnly = true;
            // 
            // clmPallets
            // 
            this.clmPallets.HeaderText = "";
            this.clmPallets.Name = "clmPallets";
            this.clmPallets.ReadOnly = true;
            this.clmPallets.Text = "Pallet";
            this.clmPallets.UseColumnTextForButtonValue = true;
            this.clmPallets.Width = 80;
            // 
            // clmGranel
            // 
            this.clmGranel.HeaderText = "";
            this.clmGranel.Name = "clmGranel";
            this.clmGranel.ReadOnly = true;
            this.clmGranel.Text = "Granel";
            this.clmGranel.UseColumnTextForButtonValue = true;
            this.clmGranel.Visible = false;
            this.clmGranel.Width = 80;
            // 
            // frmInputRawMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 356);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.dgvEntradaMaterPrima);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInputRawMaterial";
            this.Text = "Ingreso de Materia Prima";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradaMaterPrima)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEntradaMaterPrima;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodAlfa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPartida;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombreEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRecption;
        private System.Windows.Forms.DataGridViewButtonColumn clmPallets;
        private System.Windows.Forms.DataGridViewButtonColumn clmGranel;
    }
}