namespace BPS
{
    partial class frmShippingMultiple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShippingMultiple));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.dgvInternationalFrom = new System.Windows.Forms.DataGridView();
            this.clminternationalcustomerfrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clminternationalcodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clminternationalcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clminternationalproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clminternationalorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clminternationalnumberpallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clminternationalnumbercoil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clminternationalnetweitgh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalWeigth = new System.Windows.Forms.Label();
            this.lblTotalWeigthLabel = new System.Windows.Forms.Label();
            this.lblTotalCoil = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.lblTotalCoilLabel = new System.Windows.Forms.Label();
            this.lblTotalPallet = new System.Windows.Forms.Label();
            this.lblTotalPalletLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOrder);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(869, 42);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvInternationalFrom);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(869, 453);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pallets";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTotalWeigth);
            this.groupBox3.Controls.Add(this.lblTotalWeigthLabel);
            this.groupBox3.Controls.Add(this.lblTotalCoil);
            this.groupBox3.Controls.Add(this.btnTransfer);
            this.groupBox3.Controls.Add(this.lblTotalCoilLabel);
            this.groupBox3.Controls.Add(this.lblTotalPallet);
            this.groupBox3.Controls.Add(this.lblTotalPalletLabel);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 495);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(869, 44);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Orden";
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(381, 13);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(154, 21);
            this.txtOrder.TabIndex = 1;
            this.txtOrder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOrder_KeyDown);
            // 
            // dgvInternationalFrom
            // 
            this.dgvInternationalFrom.AllowUserToAddRows = false;
            this.dgvInternationalFrom.AllowUserToDeleteRows = false;
            this.dgvInternationalFrom.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInternationalFrom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInternationalFrom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternationalFrom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clminternationalcustomerfrom,
            this.clminternationalcodsec,
            this.clminternationalcode,
            this.clminternationalproduct,
            this.clminternationalorder,
            this.clminternationalnumberpallet,
            this.clminternationalnumbercoil,
            this.clminternationalnetweitgh});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInternationalFrom.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInternationalFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInternationalFrom.Location = new System.Drawing.Point(3, 16);
            this.dgvInternationalFrom.MultiSelect = false;
            this.dgvInternationalFrom.Name = "dgvInternationalFrom";
            this.dgvInternationalFrom.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInternationalFrom.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInternationalFrom.RowHeadersWidth = 21;
            this.dgvInternationalFrom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInternationalFrom.Size = new System.Drawing.Size(863, 434);
            this.dgvInternationalFrom.TabIndex = 1;
            // 
            // clminternationalcustomerfrom
            // 
            this.clminternationalcustomerfrom.HeaderText = "Customer";
            this.clminternationalcustomerfrom.Name = "clminternationalcustomerfrom";
            this.clminternationalcustomerfrom.ReadOnly = true;
            this.clminternationalcustomerfrom.Visible = false;
            // 
            // clminternationalcodsec
            // 
            this.clminternationalcodsec.HeaderText = "codsec";
            this.clminternationalcodsec.Name = "clminternationalcodsec";
            this.clminternationalcodsec.ReadOnly = true;
            this.clminternationalcodsec.Visible = false;
            this.clminternationalcodsec.Width = 10;
            // 
            // clminternationalcode
            // 
            this.clminternationalcode.FillWeight = 80F;
            this.clminternationalcode.HeaderText = "Pallet";
            this.clminternationalcode.Name = "clminternationalcode";
            this.clminternationalcode.ReadOnly = true;
            this.clminternationalcode.Width = 130;
            // 
            // clminternationalproduct
            // 
            this.clminternationalproduct.FillWeight = 80F;
            this.clminternationalproduct.HeaderText = "Producto";
            this.clminternationalproduct.Name = "clminternationalproduct";
            this.clminternationalproduct.ReadOnly = true;
            this.clminternationalproduct.Width = 130;
            // 
            // clminternationalorder
            // 
            this.clminternationalorder.HeaderText = "Orden";
            this.clminternationalorder.Name = "clminternationalorder";
            this.clminternationalorder.ReadOnly = true;
            this.clminternationalorder.Width = 60;
            // 
            // clminternationalnumberpallet
            // 
            this.clminternationalnumberpallet.HeaderText = "Nro. Pallet";
            this.clminternationalnumberpallet.Name = "clminternationalnumberpallet";
            this.clminternationalnumberpallet.ReadOnly = true;
            this.clminternationalnumberpallet.Width = 90;
            // 
            // clminternationalnumbercoil
            // 
            this.clminternationalnumbercoil.HeaderText = "Nro. Bobinas";
            this.clminternationalnumbercoil.Name = "clminternationalnumbercoil";
            this.clminternationalnumbercoil.ReadOnly = true;
            this.clminternationalnumbercoil.Width = 110;
            // 
            // clminternationalnetweitgh
            // 
            this.clminternationalnetweitgh.HeaderText = "P. Neto";
            this.clminternationalnetweitgh.Name = "clminternationalnetweitgh";
            this.clminternationalnetweitgh.ReadOnly = true;
            this.clminternationalnetweitgh.Width = 80;
            // 
            // lblTotalWeigth
            // 
            this.lblTotalWeigth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalWeigth.Location = new System.Drawing.Point(589, 13);
            this.lblTotalWeigth.Name = "lblTotalWeigth";
            this.lblTotalWeigth.Size = new System.Drawing.Size(111, 21);
            this.lblTotalWeigth.TabIndex = 125;
            this.lblTotalWeigth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalWeigthLabel
            // 
            this.lblTotalWeigthLabel.AutoSize = true;
            this.lblTotalWeigthLabel.Location = new System.Drawing.Point(512, 16);
            this.lblTotalWeigthLabel.Name = "lblTotalWeigthLabel";
            this.lblTotalWeigthLabel.Size = new System.Drawing.Size(71, 15);
            this.lblTotalWeigthLabel.TabIndex = 124;
            this.lblTotalWeigthLabel.Text = "Total Peso :";
            // 
            // lblTotalCoil
            // 
            this.lblTotalCoil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCoil.Location = new System.Drawing.Point(453, 13);
            this.lblTotalCoil.Name = "lblTotalCoil";
            this.lblTotalCoil.Size = new System.Drawing.Size(46, 21);
            this.lblTotalCoil.TabIndex = 123;
            this.lblTotalCoil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackgroundImage = global::BPS.Properties.Resources.arrow_curve;
            this.btnTransfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTransfer.Location = new System.Drawing.Point(170, 11);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(25, 25);
            this.btnTransfer.TabIndex = 126;
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // lblTotalCoilLabel
            // 
            this.lblTotalCoilLabel.AutoSize = true;
            this.lblTotalCoilLabel.Location = new System.Drawing.Point(359, 16);
            this.lblTotalCoilLabel.Name = "lblTotalCoilLabel";
            this.lblTotalCoilLabel.Size = new System.Drawing.Size(88, 15);
            this.lblTotalCoilLabel.TabIndex = 122;
            this.lblTotalCoilLabel.Text = "Total Bobinas :";
            // 
            // lblTotalPallet
            // 
            this.lblTotalPallet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalPallet.Location = new System.Drawing.Point(307, 13);
            this.lblTotalPallet.Name = "lblTotalPallet";
            this.lblTotalPallet.Size = new System.Drawing.Size(46, 21);
            this.lblTotalPallet.TabIndex = 121;
            this.lblTotalPallet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPalletLabel
            // 
            this.lblTotalPalletLabel.AutoSize = true;
            this.lblTotalPalletLabel.Location = new System.Drawing.Point(227, 16);
            this.lblTotalPalletLabel.Name = "lblTotalPalletLabel";
            this.lblTotalPalletLabel.Size = new System.Drawing.Size(74, 15);
            this.lblTotalPalletLabel.TabIndex = 120;
            this.lblTotalPalletLabel.Text = "Total Pallet :";
            // 
            // frmShippingMultiple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(869, 539);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmShippingMultiple";
            this.Text = "Despacho Masivo de Pallet por Orden";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternationalFrom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvInternationalFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clminternationalcustomerfrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clminternationalcodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clminternationalcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clminternationalproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clminternationalorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clminternationalnumberpallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clminternationalnumbercoil;
        private System.Windows.Forms.DataGridViewTextBoxColumn clminternationalnetweitgh;
        private System.Windows.Forms.Label lblTotalWeigth;
        private System.Windows.Forms.Label lblTotalWeigthLabel;
        private System.Windows.Forms.Label lblTotalCoil;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label lblTotalCoilLabel;
        private System.Windows.Forms.Label lblTotalPallet;
        private System.Windows.Forms.Label lblTotalPalletLabel;
    }
}