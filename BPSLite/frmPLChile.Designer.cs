namespace BPS.Lite
{
    partial class frmPLChile
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtListo = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnObtenerPL = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.txtKilos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBobinas = new System.Windows.Forms.TextBox();
            this.txtPallets = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PedidoN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bobina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoNetoBobina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diametro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiametroE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grosor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ancho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Largo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoNetoBobinaLB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoPalletNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoPalletBruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoPalletNetoLB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoBrutoPalletLB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codOben = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.done = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PedidoN,
            this.Posicion,
            this.Pallet,
            this.Bobina,
            this.PesoNetoBobina,
            this.Unidad,
            this.Diametro,
            this.DiametroE,
            this.Grosor,
            this.Ancho,
            this.Largo,
            this.Material,
            this.Descripcion,
            this.Entrega,
            this.PesoNetoBobinaLB,
            this.PesoPalletNeto,
            this.PesoPalletBruto,
            this.PesoPalletNetoLB,
            this.PesoBrutoPalletLB,
            this.codOben,
            this.done});
            this.dgv.Location = new System.Drawing.Point(12, 63);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(1228, 557);
            this.dgv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Listo para ingresar:";
            // 
            // txtListo
            // 
            this.txtListo.BackColor = System.Drawing.Color.Red;
            this.txtListo.ForeColor = System.Drawing.Color.White;
            this.txtListo.Location = new System.Drawing.Point(386, 21);
            this.txtListo.Name = "txtListo";
            this.txtListo.Size = new System.Drawing.Size(105, 20);
            this.txtListo.TabIndex = 9;
            this.txtListo.Text = "Falso";
            this.txtListo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(497, 19);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(114, 23);
            this.btnIngresar.TabIndex = 8;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnObtenerPL
            // 
            this.btnObtenerPL.Location = new System.Drawing.Point(6, 19);
            this.btnObtenerPL.Name = "btnObtenerPL";
            this.btnObtenerPL.Size = new System.Drawing.Size(115, 23);
            this.btnObtenerPL.TabIndex = 6;
            this.btnObtenerPL.Text = "Obtener PL";
            this.btnObtenerPL.UseVisualStyleBackColor = true;
            this.btnObtenerPL.Click += new System.EventHandler(this.btnObtenerPL_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(127, 19);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(110, 23);
            this.btnVerificar.TabIndex = 7;
            this.btnVerificar.Text = "Verificar datos";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // txtKilos
            // 
            this.txtKilos.Enabled = false;
            this.txtKilos.Location = new System.Drawing.Point(1047, 22);
            this.txtKilos.Name = "txtKilos";
            this.txtKilos.Size = new System.Drawing.Size(85, 20);
            this.txtKilos.TabIndex = 19;
            this.txtKilos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1007, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Kilos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(886, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Bobinas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(770, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Pallets:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(719, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Totales:";
            // 
            // txtBobinas
            // 
            this.txtBobinas.Enabled = false;
            this.txtBobinas.Location = new System.Drawing.Point(942, 22);
            this.txtBobinas.Name = "txtBobinas";
            this.txtBobinas.Size = new System.Drawing.Size(51, 20);
            this.txtBobinas.TabIndex = 14;
            this.txtBobinas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPallets
            // 
            this.txtPallets.Enabled = false;
            this.txtPallets.Location = new System.Drawing.Point(819, 22);
            this.txtPallets.Name = "txtPallets";
            this.txtPallets.Size = new System.Drawing.Size(52, 20);
            this.txtPallets.TabIndex = 13;
            this.txtPallets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnObtenerPL);
            this.groupBox1.Controls.Add(this.txtKilos);
            this.groupBox1.Controls.Add(this.btnVerificar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnIngresar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtListo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPallets);
            this.groupBox1.Controls.Add(this.txtBobinas);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1228, 57);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // PedidoN
            // 
            this.PedidoN.HeaderText = "Pedido N°";
            this.PedidoN.Name = "PedidoN";
            this.PedidoN.ReadOnly = true;
            this.PedidoN.Visible = false;
            this.PedidoN.Width = 80;
            // 
            // Posicion
            // 
            this.Posicion.HeaderText = "Posición";
            this.Posicion.Name = "Posicion";
            this.Posicion.ReadOnly = true;
            this.Posicion.Visible = false;
            this.Posicion.Width = 60;
            // 
            // Pallet
            // 
            this.Pallet.HeaderText = "Pallet";
            this.Pallet.Name = "Pallet";
            this.Pallet.ReadOnly = true;
            this.Pallet.Width = 80;
            // 
            // Bobina
            // 
            this.Bobina.HeaderText = "Bobina";
            this.Bobina.Name = "Bobina";
            this.Bobina.ReadOnly = true;
            this.Bobina.Width = 60;
            // 
            // PesoNetoBobina
            // 
            this.PesoNetoBobina.HeaderText = "Peso Neto Bobina";
            this.PesoNetoBobina.Name = "PesoNetoBobina";
            this.PesoNetoBobina.ReadOnly = true;
            this.PesoNetoBobina.Width = 60;
            // 
            // Unidad
            // 
            this.Unidad.HeaderText = "Unidad";
            this.Unidad.Name = "Unidad";
            this.Unidad.ReadOnly = true;
            this.Unidad.Visible = false;
            this.Unidad.Width = 60;
            // 
            // Diametro
            // 
            this.Diametro.HeaderText = "Diametro";
            this.Diametro.Name = "Diametro";
            this.Diametro.ReadOnly = true;
            this.Diametro.Width = 60;
            // 
            // DiametroE
            // 
            this.DiametroE.HeaderText = "Diametro Externo";
            this.DiametroE.Name = "DiametroE";
            this.DiametroE.ReadOnly = true;
            this.DiametroE.Width = 60;
            // 
            // Grosor
            // 
            this.Grosor.HeaderText = "Grosor";
            this.Grosor.Name = "Grosor";
            this.Grosor.ReadOnly = true;
            this.Grosor.Visible = false;
            this.Grosor.Width = 60;
            // 
            // Ancho
            // 
            this.Ancho.HeaderText = "Ancho";
            this.Ancho.Name = "Ancho";
            this.Ancho.ReadOnly = true;
            this.Ancho.Width = 60;
            // 
            // Largo
            // 
            this.Largo.HeaderText = "Largo";
            this.Largo.Name = "Largo";
            this.Largo.ReadOnly = true;
            this.Largo.Width = 60;
            // 
            // Material
            // 
            this.Material.HeaderText = "Material";
            this.Material.Name = "Material";
            this.Material.ReadOnly = true;
            this.Material.Width = 80;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Entrega
            // 
            this.Entrega.HeaderText = "Entrega";
            this.Entrega.Name = "Entrega";
            this.Entrega.ReadOnly = true;
            this.Entrega.Width = 80;
            // 
            // PesoNetoBobinaLB
            // 
            this.PesoNetoBobinaLB.HeaderText = "Peso Neto Bobina LB";
            this.PesoNetoBobinaLB.Name = "PesoNetoBobinaLB";
            this.PesoNetoBobinaLB.ReadOnly = true;
            this.PesoNetoBobinaLB.Visible = false;
            this.PesoNetoBobinaLB.Width = 60;
            // 
            // PesoPalletNeto
            // 
            this.PesoPalletNeto.HeaderText = "Peso Pallet Neto";
            this.PesoPalletNeto.Name = "PesoPalletNeto";
            this.PesoPalletNeto.ReadOnly = true;
            this.PesoPalletNeto.Width = 60;
            // 
            // PesoPalletBruto
            // 
            this.PesoPalletBruto.HeaderText = "Peso Pallet Bruto";
            this.PesoPalletBruto.Name = "PesoPalletBruto";
            this.PesoPalletBruto.ReadOnly = true;
            this.PesoPalletBruto.Width = 60;
            // 
            // PesoPalletNetoLB
            // 
            this.PesoPalletNetoLB.HeaderText = "Peso Pallet Neto LB";
            this.PesoPalletNetoLB.Name = "PesoPalletNetoLB";
            this.PesoPalletNetoLB.ReadOnly = true;
            this.PesoPalletNetoLB.Visible = false;
            this.PesoPalletNetoLB.Width = 60;
            // 
            // PesoBrutoPalletLB
            // 
            this.PesoBrutoPalletLB.HeaderText = "Peso Pallet Bruto LB";
            this.PesoBrutoPalletLB.Name = "PesoBrutoPalletLB";
            this.PesoBrutoPalletLB.ReadOnly = true;
            this.PesoBrutoPalletLB.Visible = false;
            this.PesoBrutoPalletLB.Width = 60;
            // 
            // codOben
            // 
            this.codOben.HeaderText = "Código Oben";
            this.codOben.Name = "codOben";
            this.codOben.ReadOnly = true;
            this.codOben.Width = 120;
            // 
            // done
            // 
            this.done.HeaderText = "Listo para ingresar";
            this.done.Name = "done";
            this.done.ReadOnly = true;
            this.done.Visible = false;
            this.done.Width = 60;
            // 
            // frmPLChile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1252, 624);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv);
            this.Name = "frmPLChile";
            this.ShowIcon = false;
            this.Text = "Importación desde Bopp Chile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtListo;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnObtenerPL;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.TextBox txtKilos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBobinas;
        private System.Windows.Forms.TextBox txtPallets;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PedidoN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bobina;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoNetoBobina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diametro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiametroE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grosor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ancho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Largo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoNetoBobinaLB;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoPalletNeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoPalletBruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoPalletNetoLB;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoBrutoPalletLB;
        private System.Windows.Forms.DataGridViewTextBoxColumn codOben;
        private System.Windows.Forms.DataGridViewTextBoxColumn done;
    }
}