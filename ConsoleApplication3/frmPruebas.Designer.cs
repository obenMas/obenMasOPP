namespace ConsoleApplication3
{
    partial class frmPruebas
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
            this.txtLote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.dgvPrueba = new System.Windows.Forms.DataGridView();
            this.txtPeli = new System.Windows.Forms.TextBox();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAncho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiametro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrueba)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLote
            // 
            this.txtLote.Location = new System.Drawing.Point(110, 15);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(110, 20);
            this.txtLote.TabIndex = 0;
            this.txtLote.TextChanged += new System.EventHandler(this.txtLote_TextChanged);
            this.txtLote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLote_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ancho";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(297, 18);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(44, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Pelicula";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(107, 333);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(35, 13);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "label3";
            // 
            // dgvPrueba
            // 
            this.dgvPrueba.AllowUserToAddRows = false;
            this.dgvPrueba.AllowUserToDeleteRows = false;
            this.dgvPrueba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrueba.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmAncho,
            this.clmNombre,
            this.clmPelicula,
            this.clmDiametro,
            this.clmAd});
            this.dgvPrueba.Location = new System.Drawing.Point(12, 66);
            this.dgvPrueba.Name = "dgvPrueba";
            this.dgvPrueba.ReadOnly = true;
            this.dgvPrueba.Size = new System.Drawing.Size(618, 250);
            this.dgvPrueba.TabIndex = 4;
            this.dgvPrueba.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrueba_CellClick);
            // 
            // txtPeli
            // 
            this.txtPeli.Location = new System.Drawing.Point(347, 15);
            this.txtPeli.Name = "txtPeli";
            this.txtPeli.Size = new System.Drawing.Size(135, 20);
            this.txtPeli.TabIndex = 5;
            this.txtPeli.Text = "SC020";
            // 
            // clmCodigo
            // 
            this.clmCodigo.HeaderText = "Código";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            // 
            // clmAncho
            // 
            this.clmAncho.HeaderText = "Ancho (mm)";
            this.clmAncho.Name = "clmAncho";
            this.clmAncho.ReadOnly = true;
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            // 
            // clmPelicula
            // 
            this.clmPelicula.HeaderText = "Pelicula";
            this.clmPelicula.Name = "clmPelicula";
            this.clmPelicula.ReadOnly = true;
            // 
            // clmDiametro
            // 
            this.clmDiametro.HeaderText = "Diametro";
            this.clmDiametro.Name = "clmDiametro";
            this.clmDiametro.ReadOnly = true;
            // 
            // clmAd
            // 
            this.clmAd.HeaderText = "add";
            this.clmAd.Name = "clmAd";
            this.clmAd.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(534, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPruebas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 376);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPeli);
            this.Controls.Add(this.dgvPrueba);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLote);
            this.Name = "frmPruebas";
            this.Text = "frmPruebas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrueba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.DataGridView dgvPrueba;
        private System.Windows.Forms.TextBox txtPeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAncho;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiametro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAd;
        private System.Windows.Forms.Button button1;
    }
}