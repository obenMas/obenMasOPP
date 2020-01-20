namespace BPS.Raw.ProcessR.RePro
{
    partial class frmRePro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRePro));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPallet = new System.Windows.Forms.TextBox();
            this.lblPalletCode = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTmP = new System.Windows.Forms.Label();
            this.lblLot = new System.Windows.Forms.Label();
            this.lblPalletTypeLabel = new System.Windows.Forms.Label();
            this.lblProductLabel = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvAdt = new System.Windows.Forms.DataGridView();
            this.clmm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmtmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmlotnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmbag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmweight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdt)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPallet);
            this.groupBox1.Controls.Add(this.lblPalletCode);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtPallet
            // 
            this.txtPallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPallet.Location = new System.Drawing.Point(211, 13);
            this.txtPallet.Name = "txtPallet";
            this.txtPallet.Size = new System.Drawing.Size(590, 38);
            this.txtPallet.TabIndex = 5;
            this.txtPallet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPallet_KeyDown);
            // 
            // lblPalletCode
            // 
            this.lblPalletCode.AutoSize = true;
            this.lblPalletCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalletCode.Location = new System.Drawing.Point(30, 14);
            this.lblPalletCode.Name = "lblPalletCode";
            this.lblPalletCode.Size = new System.Drawing.Size(175, 31);
            this.lblPalletCode.TabIndex = 4;
            this.lblPalletCode.Text = "Código Pallet";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblTmP);
            this.groupBox2.Controls.Add(this.lblLot);
            this.groupBox2.Controls.Add(this.lblPalletTypeLabel);
            this.groupBox2.Controls.Add(this.lblProductLabel);
            this.groupBox2.Controls.Add(this.lblProduct);
            this.groupBox2.Controls.Add(this.btnProcess);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(831, 75);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles";
            this.groupBox2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Sacos";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(375, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 21);
            this.label3.TabIndex = 41;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Lote";
            // 
            // lblTmP
            // 
            this.lblTmP.BackColor = System.Drawing.SystemColors.Window;
            this.lblTmP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTmP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTmP.Location = new System.Drawing.Point(82, 16);
            this.lblTmP.Name = "lblTmP";
            this.lblTmP.Size = new System.Drawing.Size(228, 21);
            this.lblTmP.TabIndex = 35;
            this.lblTmP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLot
            // 
            this.lblLot.BackColor = System.Drawing.SystemColors.Window;
            this.lblLot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLot.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblLot.Location = new System.Drawing.Point(375, 15);
            this.lblLot.Name = "lblLot";
            this.lblLot.Size = new System.Drawing.Size(228, 21);
            this.lblLot.TabIndex = 39;
            this.lblLot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPalletTypeLabel
            // 
            this.lblPalletTypeLabel.AutoSize = true;
            this.lblPalletTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalletTypeLabel.Location = new System.Drawing.Point(4, 16);
            this.lblPalletTypeLabel.Name = "lblPalletTypeLabel";
            this.lblPalletTypeLabel.Size = new System.Drawing.Size(66, 20);
            this.lblPalletTypeLabel.TabIndex = 34;
            this.lblPalletTypeLabel.Text = "Tipo MP";
            // 
            // lblProductLabel
            // 
            this.lblProductLabel.AutoSize = true;
            this.lblProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductLabel.Location = new System.Drawing.Point(4, 40);
            this.lblProductLabel.Name = "lblProductLabel";
            this.lblProductLabel.Size = new System.Drawing.Size(73, 20);
            this.lblProductLabel.TabIndex = 36;
            this.lblProductLabel.Text = "Producto";
            // 
            // lblProduct
            // 
            this.lblProduct.BackColor = System.Drawing.SystemColors.Window;
            this.lblProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblProduct.Location = new System.Drawing.Point(82, 40);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(228, 21);
            this.lblProduct.TabIndex = 37;
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProcess
            // 
            this.btnProcess.Image = global::BPS.Raw.Properties.Resources.gear_32;
            this.btnProcess.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProcess.Location = new System.Drawing.Point(737, 10);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(88, 59);
            this.btnProcess.TabIndex = 42;
            this.btnProcess.Text = "Procesar";
            this.btnProcess.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::BPS.Raw.Properties.Resources.disk32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(737, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 59);
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Guardar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvAdt);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(831, 344);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista";
            this.groupBox3.Visible = false;
            // 
            // dgvAdt
            // 
            this.dgvAdt.AllowUserToAddRows = false;
            this.dgvAdt.AllowUserToDeleteRows = false;
            this.dgvAdt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmm,
            this.clmtmp,
            this.clmproduct,
            this.clmlotnumber,
            this.clmbag,
            this.clmweight,
            this.clmcode});
            this.dgvAdt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdt.Location = new System.Drawing.Point(3, 16);
            this.dgvAdt.Name = "dgvAdt";
            this.dgvAdt.ReadOnly = true;
            this.dgvAdt.RowHeadersWidth = 21;
            this.dgvAdt.Size = new System.Drawing.Size(825, 325);
            this.dgvAdt.TabIndex = 0;
            // 
            // clmm
            // 
            this.clmm.HeaderText = "Nro";
            this.clmm.Name = "clmm";
            this.clmm.ReadOnly = true;
            this.clmm.Width = 40;
            // 
            // clmtmp
            // 
            this.clmtmp.HeaderText = "Tipo MP";
            this.clmtmp.Name = "clmtmp";
            this.clmtmp.ReadOnly = true;
            this.clmtmp.Width = 150;
            // 
            // clmproduct
            // 
            this.clmproduct.HeaderText = "Materia Prima";
            this.clmproduct.Name = "clmproduct";
            this.clmproduct.ReadOnly = true;
            this.clmproduct.Width = 150;
            // 
            // clmlotnumber
            // 
            this.clmlotnumber.HeaderText = "Lote";
            this.clmlotnumber.Name = "clmlotnumber";
            this.clmlotnumber.ReadOnly = true;
            // 
            // clmbag
            // 
            this.clmbag.HeaderText = "Saco";
            this.clmbag.Name = "clmbag";
            this.clmbag.ReadOnly = true;
            this.clmbag.Width = 70;
            // 
            // clmweight
            // 
            this.clmweight.HeaderText = "Peso";
            this.clmweight.Name = "clmweight";
            this.clmweight.ReadOnly = true;
            // 
            // clmcode
            // 
            this.clmcode.HeaderText = "Código";
            this.clmcode.Name = "clmcode";
            this.clmcode.ReadOnly = true;
            this.clmcode.Width = 150;
            // 
            // frmRePro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(831, 478);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRePro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReProcesado - Molinos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPallet;
        private System.Windows.Forms.Label lblPalletCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTmP;
        private System.Windows.Forms.Label lblLot;
        private System.Windows.Forms.Label lblPalletTypeLabel;
        private System.Windows.Forms.Label lblProductLabel;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.DataGridView dgvAdt;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmtmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmlotnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmbag;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmweight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcode;
    }
}