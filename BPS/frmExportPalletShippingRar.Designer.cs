namespace BPS
{
    partial class frmExportPalletShippingRar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExportPalletShippingRar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPalletCellar = new System.Windows.Forms.DataGridView();
            this.clmobenvalidate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmobennumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmsiigocellar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmsiigomovement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmsiigocode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmsiigoref = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmobenorigin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmobenbopp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmobenopp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmobenmaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmobenpalletcoil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmobenview = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletCellar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPalletCellar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(947, 406);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pallets";
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 406);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(947, 69);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgvPalletCellar
            // 
            this.dgvPalletCellar.AllowUserToAddRows = false;
            this.dgvPalletCellar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPalletCellar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPalletCellar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalletCellar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmobenvalidate,
            this.clmobennumber,
            this.clmsiigocellar,
            this.clmsiigomovement,
            this.clmsiigocode,
            this.clmsiigoref,
            this.clmobenorigin,
            this.clmobenbopp,
            this.clmobenopp,
            this.clmobenmaterial,
            this.clmobenpalletcoil,
            this.clmobenview});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPalletCellar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPalletCellar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPalletCellar.Location = new System.Drawing.Point(3, 16);
            this.dgvPalletCellar.Name = "dgvPalletCellar";
            this.dgvPalletCellar.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPalletCellar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPalletCellar.Size = new System.Drawing.Size(941, 387);
            this.dgvPalletCellar.TabIndex = 0;
            // 
            // clmobenvalidate
            // 
            this.clmobenvalidate.HeaderText = "validate";
            this.clmobenvalidate.Name = "clmobenvalidate";
            this.clmobenvalidate.ReadOnly = true;
            this.clmobenvalidate.Visible = false;
            // 
            // clmobennumber
            // 
            this.clmobennumber.HeaderText = "Nro.";
            this.clmobennumber.Name = "clmobennumber";
            this.clmobennumber.ReadOnly = true;
            // 
            // clmsiigocellar
            // 
            this.clmsiigocellar.HeaderText = "S. Bod";
            this.clmsiigocellar.Name = "clmsiigocellar";
            this.clmsiigocellar.ReadOnly = true;
            // 
            // clmsiigomovement
            // 
            this.clmsiigomovement.HeaderText = "S. Mov";
            this.clmsiigomovement.Name = "clmsiigomovement";
            this.clmsiigomovement.ReadOnly = true;
            // 
            // clmsiigocode
            // 
            this.clmsiigocode.HeaderText = "S. Code";
            this.clmsiigocode.Name = "clmsiigocode";
            this.clmsiigocode.ReadOnly = true;
            // 
            // clmsiigoref
            // 
            this.clmsiigoref.HeaderText = "S. Ref";
            this.clmsiigoref.Name = "clmsiigoref";
            this.clmsiigoref.ReadOnly = true;
            // 
            // clmobenorigin
            // 
            this.clmobenorigin.HeaderText = "Origen";
            this.clmobenorigin.Name = "clmobenorigin";
            this.clmobenorigin.ReadOnly = true;
            // 
            // clmobenbopp
            // 
            this.clmobenbopp.HeaderText = "Bopp";
            this.clmobenbopp.Name = "clmobenbopp";
            this.clmobenbopp.ReadOnly = true;
            // 
            // clmobenopp
            // 
            this.clmobenopp.HeaderText = "Opp";
            this.clmobenopp.Name = "clmobenopp";
            this.clmobenopp.ReadOnly = true;
            // 
            // clmobenmaterial
            // 
            this.clmobenmaterial.HeaderText = "Producto";
            this.clmobenmaterial.Name = "clmobenmaterial";
            this.clmobenmaterial.ReadOnly = true;
            // 
            // clmobenpalletcoil
            // 
            this.clmobenpalletcoil.HeaderText = "P - B";
            this.clmobenpalletcoil.Name = "clmobenpalletcoil";
            this.clmobenpalletcoil.ReadOnly = true;
            // 
            // clmobenview
            // 
            this.clmobenview.HeaderText = "";
            this.clmobenview.Name = "clmobenview";
            this.clmobenview.ReadOnly = true;
            // 
            // frmExportPalletShippingRar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(947, 475);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExportPalletShippingRar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empaquetamiento de Despacho de Material";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletCellar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPalletCellar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmobenvalidate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmobennumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmsiigocellar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmsiigomovement;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmsiigocode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmsiigoref;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmobenorigin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmobenbopp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmobenopp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmobenmaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmobenpalletcoil;
        private System.Windows.Forms.DataGridViewImageColumn clmobenview;
    }
}