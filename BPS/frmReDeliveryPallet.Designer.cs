namespace BPS
{
    partial class frmReDeliveryPallet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReDeliveryPallet));
            this.grpbInfoInventory = new System.Windows.Forms.GroupBox();
            this.lblpallet = new System.Windows.Forms.Label();
            this.txtcodepallet = new System.Windows.Forms.TextBox();
            this.lbldate = new System.Windows.Forms.Label();
            this.lbldatelabel = new System.Windows.Forms.Label();
            this.grpbPallet = new System.Windows.Forms.GroupBox();
            this.dgvPallet = new System.Windows.Forms.DataGridView();
            this.tbcInventory = new System.Windows.Forms.TabControl();
            this.tbpInventory = new System.Windows.Forms.TabPage();
            this.clmnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmfkpallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmpalletnumberandcoilnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnetweigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcoilcellar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmsalesnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbInfoInventory.SuspendLayout();
            this.grpbPallet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPallet)).BeginInit();
            this.tbcInventory.SuspendLayout();
            this.tbpInventory.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbInfoInventory
            // 
            this.grpbInfoInventory.Controls.Add(this.lblpallet);
            this.grpbInfoInventory.Controls.Add(this.txtcodepallet);
            this.grpbInfoInventory.Controls.Add(this.lbldate);
            this.grpbInfoInventory.Controls.Add(this.lbldatelabel);
            this.grpbInfoInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbInfoInventory.Location = new System.Drawing.Point(3, 3);
            this.grpbInfoInventory.Name = "grpbInfoInventory";
            this.grpbInfoInventory.Size = new System.Drawing.Size(822, 86);
            this.grpbInfoInventory.TabIndex = 0;
            this.grpbInfoInventory.TabStop = false;
            // 
            // lblpallet
            // 
            this.lblpallet.AutoSize = true;
            this.lblpallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpallet.Location = new System.Drawing.Point(82, 45);
            this.lblpallet.Name = "lblpallet";
            this.lblpallet.Size = new System.Drawing.Size(88, 31);
            this.lblpallet.TabIndex = 7;
            this.lblpallet.Text = "Pallet";
            // 
            // txtcodepallet
            // 
            this.txtcodepallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodepallet.Location = new System.Drawing.Point(187, 41);
            this.txtcodepallet.Name = "txtcodepallet";
            this.txtcodepallet.Size = new System.Drawing.Size(554, 40);
            this.txtcodepallet.TabIndex = 6;
            this.txtcodepallet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodepallet_KeyDown);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(363, 17);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(207, 15);
            this.lbldate.TabIndex = 5;
            this.lbldate.Text = "miercoles, 24 de diciembre del 2012";
            // 
            // lbldatelabel
            // 
            this.lbldatelabel.AutoSize = true;
            this.lbldatelabel.Location = new System.Drawing.Point(252, 16);
            this.lbldatelabel.Name = "lbldatelabel";
            this.lbldatelabel.Size = new System.Drawing.Size(105, 15);
            this.lbldatelabel.TabIndex = 2;
            this.lbldatelabel.Text = "Fecha Re-Ingreso";
            // 
            // grpbPallet
            // 
            this.grpbPallet.Controls.Add(this.dgvPallet);
            this.grpbPallet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbPallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbPallet.Location = new System.Drawing.Point(3, 89);
            this.grpbPallet.Name = "grpbPallet";
            this.grpbPallet.Size = new System.Drawing.Size(822, 415);
            this.grpbPallet.TabIndex = 1;
            this.grpbPallet.TabStop = false;
            // 
            // dgvPallet
            // 
            this.dgvPallet.AllowUserToAddRows = false;
            this.dgvPallet.AllowUserToDeleteRows = false;
            this.dgvPallet.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPallet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPallet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPallet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnumber,
            this.clmfkpallet,
            this.clmcode,
            this.clmdelivery,
            this.clmproduct,
            this.clmpalletnumberandcoilnumber,
            this.clmnetweigth,
            this.clmcoilcellar,
            this.clmsalesnumber,
            this.clmcustomer});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPallet.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPallet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPallet.Location = new System.Drawing.Point(3, 16);
            this.dgvPallet.Name = "dgvPallet";
            this.dgvPallet.ReadOnly = true;
            this.dgvPallet.RowHeadersWidth = 21;
            this.dgvPallet.Size = new System.Drawing.Size(816, 396);
            this.dgvPallet.TabIndex = 0;
            // 
            // tbcInventory
            // 
            this.tbcInventory.Controls.Add(this.tbpInventory);
            this.tbcInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcInventory.Location = new System.Drawing.Point(0, 0);
            this.tbcInventory.Name = "tbcInventory";
            this.tbcInventory.SelectedIndex = 0;
            this.tbcInventory.Size = new System.Drawing.Size(836, 535);
            this.tbcInventory.TabIndex = 2;
            // 
            // tbpInventory
            // 
            this.tbpInventory.Controls.Add(this.grpbPallet);
            this.tbpInventory.Controls.Add(this.grpbInfoInventory);
            this.tbpInventory.Location = new System.Drawing.Point(4, 24);
            this.tbpInventory.Name = "tbpInventory";
            this.tbpInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInventory.Size = new System.Drawing.Size(828, 507);
            this.tbpInventory.TabIndex = 0;
            this.tbpInventory.Text = "Inventario";
            this.tbpInventory.UseVisualStyleBackColor = true;
            // 
            // clmnumber
            // 
            this.clmnumber.HeaderText = "Nro.";
            this.clmnumber.Name = "clmnumber";
            this.clmnumber.ReadOnly = true;
            this.clmnumber.Width = 40;
            // 
            // clmfkpallet
            // 
            this.clmfkpallet.HeaderText = "fkpallet";
            this.clmfkpallet.Name = "clmfkpallet";
            this.clmfkpallet.ReadOnly = true;
            this.clmfkpallet.Visible = false;
            // 
            // clmcode
            // 
            this.clmcode.HeaderText = "Pallet";
            this.clmcode.Name = "clmcode";
            this.clmcode.ReadOnly = true;
            this.clmcode.Width = 150;
            // 
            // clmdelivery
            // 
            this.clmdelivery.HeaderText = "F. Despacho";
            this.clmdelivery.Name = "clmdelivery";
            this.clmdelivery.ReadOnly = true;
            // 
            // clmproduct
            // 
            this.clmproduct.HeaderText = "Producto";
            this.clmproduct.Name = "clmproduct";
            this.clmproduct.ReadOnly = true;
            this.clmproduct.Width = 120;
            // 
            // clmpalletnumberandcoilnumber
            // 
            this.clmpalletnumberandcoilnumber.HeaderText = "P - B";
            this.clmpalletnumberandcoilnumber.Name = "clmpalletnumberandcoilnumber";
            this.clmpalletnumberandcoilnumber.ReadOnly = true;
            this.clmpalletnumberandcoilnumber.Width = 55;
            // 
            // clmnetweigth
            // 
            this.clmnetweigth.HeaderText = "P. Neto";
            this.clmnetweigth.Name = "clmnetweigth";
            this.clmnetweigth.ReadOnly = true;
            this.clmnetweigth.Width = 70;
            // 
            // clmcoilcellar
            // 
            this.clmcoilcellar.HeaderText = "Bodega";
            this.clmcoilcellar.Name = "clmcoilcellar";
            this.clmcoilcellar.ReadOnly = true;
            this.clmcoilcellar.Width = 80;
            // 
            // clmsalesnumber
            // 
            this.clmsalesnumber.HeaderText = "Orden";
            this.clmsalesnumber.Name = "clmsalesnumber";
            this.clmsalesnumber.ReadOnly = true;
            this.clmsalesnumber.Width = 60;
            // 
            // clmcustomer
            // 
            this.clmcustomer.HeaderText = "Cliente";
            this.clmcustomer.Name = "clmcustomer";
            this.clmcustomer.ReadOnly = true;
            // 
            // frmReDeliveryPallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(836, 535);
            this.Controls.Add(this.tbcInventory);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReDeliveryPallet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Re Ingreso de Pallets";
            this.grpbInfoInventory.ResumeLayout(false);
            this.grpbInfoInventory.PerformLayout();
            this.grpbPallet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPallet)).EndInit();
            this.tbcInventory.ResumeLayout(false);
            this.tbpInventory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbInfoInventory;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lbldatelabel;
        private System.Windows.Forms.Label lblpallet;
        private System.Windows.Forms.TextBox txtcodepallet;
        private System.Windows.Forms.GroupBox grpbPallet;
        private System.Windows.Forms.DataGridView dgvPallet;
        private System.Windows.Forms.TabControl tbcInventory;
        private System.Windows.Forms.TabPage tbpInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfkpallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmdelivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmpalletnumberandcoilnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnetweigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcoilcellar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmsalesnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcustomer;
    }
}