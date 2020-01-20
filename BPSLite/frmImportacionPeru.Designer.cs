namespace BPS.Lite
{
    partial class frmImportacionPeru
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
            this.btnObtenerPL = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ancho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diametro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brutoPallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netoPallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netoBobina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bobina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.largo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bobinaMadre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtListo = new System.Windows.Forms.TextBox();
            this.txtPallets = new System.Windows.Forms.TextBox();
            this.txtBobinas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKilos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnObtenerPL
            // 
            this.btnObtenerPL.Location = new System.Drawing.Point(16, 18);
            this.btnObtenerPL.Name = "btnObtenerPL";
            this.btnObtenerPL.Size = new System.Drawing.Size(115, 23);
            this.btnObtenerPL.TabIndex = 0;
            this.btnObtenerPL.Text = "Obtener PL";
            this.btnObtenerPL.UseVisualStyleBackColor = true;
            this.btnObtenerPL.Click += new System.EventHandler(this.btnObtenerPL_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producto,
            this.ancho,
            this.diametro,
            this.pallet,
            this.brutoPallet,
            this.netoPallet,
            this.fecha,
            this.netoBobina,
            this.bobina,
            this.largo,
            this.diam,
            this.lote,
            this.bobinaMadre,
            this.fechaFab,
            this.tipo});
            this.dgv.Location = new System.Drawing.Point(12, 59);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(1207, 535);
            this.dgv.TabIndex = 1;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            this.producto.Width = 125;
            // 
            // ancho
            // 
            this.ancho.HeaderText = "Ancho";
            this.ancho.Name = "ancho";
            this.ancho.ReadOnly = true;
            this.ancho.Width = 50;
            // 
            // diametro
            // 
            this.diametro.HeaderText = "Diametro";
            this.diametro.Name = "diametro";
            this.diametro.ReadOnly = true;
            this.diametro.Width = 60;
            // 
            // pallet
            // 
            this.pallet.HeaderText = "Pallet";
            this.pallet.Name = "pallet";
            this.pallet.ReadOnly = true;
            // 
            // brutoPallet
            // 
            this.brutoPallet.HeaderText = "Peso Bruto Pallet";
            this.brutoPallet.Name = "brutoPallet";
            this.brutoPallet.ReadOnly = true;
            this.brutoPallet.Width = 80;
            // 
            // netoPallet
            // 
            this.netoPallet.HeaderText = "Peso Neto Pallet";
            this.netoPallet.Name = "netoPallet";
            this.netoPallet.ReadOnly = true;
            this.netoPallet.Width = 80;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // netoBobina
            // 
            this.netoBobina.HeaderText = "Peso Neto Bobina";
            this.netoBobina.Name = "netoBobina";
            this.netoBobina.ReadOnly = true;
            this.netoBobina.Width = 60;
            // 
            // bobina
            // 
            this.bobina.HeaderText = "Bobina";
            this.bobina.Name = "bobina";
            this.bobina.ReadOnly = true;
            // 
            // largo
            // 
            this.largo.HeaderText = "Largo";
            this.largo.Name = "largo";
            this.largo.ReadOnly = true;
            this.largo.Width = 50;
            // 
            // diam
            // 
            this.diam.HeaderText = "Diam";
            this.diam.Name = "diam";
            this.diam.ReadOnly = true;
            this.diam.Width = 50;
            // 
            // lote
            // 
            this.lote.HeaderText = "Lote";
            this.lote.Name = "lote";
            this.lote.ReadOnly = true;
            this.lote.Width = 80;
            // 
            // bobinaMadre
            // 
            this.bobinaMadre.HeaderText = "Bobina Madre";
            this.bobinaMadre.Name = "bobinaMadre";
            this.bobinaMadre.ReadOnly = true;
            // 
            // fechaFab
            // 
            this.fechaFab.HeaderText = "Fecha Fabricacion";
            this.fechaFab.Name = "fechaFab";
            this.fechaFab.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Visible = false;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(137, 18);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(110, 23);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Verificar datos";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(507, 18);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(114, 23);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKilos);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBobinas);
            this.groupBox1.Controls.Add(this.txtPallets);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtListo);
            this.groupBox1.Controls.Add(this.btnIngresar);
            this.groupBox1.Controls.Add(this.btnObtenerPL);
            this.groupBox1.Controls.Add(this.btnVerificar);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1207, 51);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Listo para ingresar:";
            // 
            // txtListo
            // 
            this.txtListo.BackColor = System.Drawing.Color.Red;
            this.txtListo.ForeColor = System.Drawing.Color.White;
            this.txtListo.Location = new System.Drawing.Point(396, 20);
            this.txtListo.Name = "txtListo";
            this.txtListo.Size = new System.Drawing.Size(105, 20);
            this.txtListo.TabIndex = 4;
            this.txtListo.Text = "Falso";
            this.txtListo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPallets
            // 
            this.txtPallets.Enabled = false;
            this.txtPallets.Location = new System.Drawing.Point(878, 21);
            this.txtPallets.Name = "txtPallets";
            this.txtPallets.Size = new System.Drawing.Size(52, 20);
            this.txtPallets.TabIndex = 6;
            this.txtPallets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBobinas
            // 
            this.txtBobinas.Enabled = false;
            this.txtBobinas.Location = new System.Drawing.Point(1001, 21);
            this.txtBobinas.Name = "txtBobinas";
            this.txtBobinas.Size = new System.Drawing.Size(51, 20);
            this.txtBobinas.TabIndex = 7;
            this.txtBobinas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(778, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Totales:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(829, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pallets:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(945, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bobinas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1066, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kilos:";
            // 
            // txtKilos
            // 
            this.txtKilos.Enabled = false;
            this.txtKilos.Location = new System.Drawing.Point(1106, 21);
            this.txtKilos.Name = "txtKilos";
            this.txtKilos.Size = new System.Drawing.Size(85, 20);
            this.txtKilos.TabIndex = 12;
            this.txtKilos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmImportacionPeru
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1231, 606);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv);
            this.Name = "frmImportacionPeru";
            this.ShowIcon = false;
            this.Text = "Importación desde OPP Perú";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnObtenerPL;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ancho;
        private System.Windows.Forms.DataGridViewTextBoxColumn diametro;
        private System.Windows.Forms.DataGridViewTextBoxColumn pallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn brutoPallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn netoPallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn netoBobina;
        private System.Windows.Forms.DataGridViewTextBoxColumn bobina;
        private System.Windows.Forms.DataGridViewTextBoxColumn largo;
        private System.Windows.Forms.DataGridViewTextBoxColumn diam;
        private System.Windows.Forms.DataGridViewTextBoxColumn lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn bobinaMadre;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFab;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtListo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKilos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBobinas;
        private System.Windows.Forms.TextBox txtPallets;
    }
}