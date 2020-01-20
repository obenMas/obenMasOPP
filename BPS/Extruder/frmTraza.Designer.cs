namespace BPS.Extruder
{
    partial class frmTraza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraza));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCodeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLot = new System.Windows.Forms.Label();
            this.lblTmP = new System.Windows.Forms.Label();
            this.lblNetWeigthLabel = new System.Windows.Forms.Label();
            this.lblPalletTypeLabel = new System.Windows.Forms.Label();
            this.lblProductLabel = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.txtNWeight = new System.Windows.Forms.TextBox();
            this.grpbDetail = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPro = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFor = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpbDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.lblCodeLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 51);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(100, 9);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(610, 38);
            this.txtCode.TabIndex = 37;
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // lblCodeLabel
            // 
            this.lblCodeLabel.AutoSize = true;
            this.lblCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeLabel.Location = new System.Drawing.Point(16, 16);
            this.lblCodeLabel.Name = "lblCodeLabel";
            this.lblCodeLabel.Size = new System.Drawing.Size(59, 20);
            this.lblCodeLabel.TabIndex = 24;
            this.lblCodeLabel.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Lote";
            // 
            // lblLot
            // 
            this.lblLot.BackColor = System.Drawing.SystemColors.Window;
            this.lblLot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLot.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblLot.Location = new System.Drawing.Point(120, 68);
            this.lblLot.Name = "lblLot";
            this.lblLot.Size = new System.Drawing.Size(203, 21);
            this.lblLot.TabIndex = 33;
            this.lblLot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTmP
            // 
            this.lblTmP.BackColor = System.Drawing.SystemColors.Window;
            this.lblTmP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTmP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTmP.Location = new System.Drawing.Point(120, 42);
            this.lblTmP.Name = "lblTmP";
            this.lblTmP.Size = new System.Drawing.Size(203, 21);
            this.lblTmP.TabIndex = 26;
            this.lblTmP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNetWeigthLabel
            // 
            this.lblNetWeigthLabel.AutoSize = true;
            this.lblNetWeigthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetWeigthLabel.Location = new System.Drawing.Point(361, 96);
            this.lblNetWeigthLabel.Name = "lblNetWeigthLabel";
            this.lblNetWeigthLabel.Size = new System.Drawing.Size(83, 20);
            this.lblNetWeigthLabel.TabIndex = 29;
            this.lblNetWeigthLabel.Text = "Peso Neto";
            // 
            // lblPalletTypeLabel
            // 
            this.lblPalletTypeLabel.AutoSize = true;
            this.lblPalletTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalletTypeLabel.Location = new System.Drawing.Point(47, 42);
            this.lblPalletTypeLabel.Name = "lblPalletTypeLabel";
            this.lblPalletTypeLabel.Size = new System.Drawing.Size(66, 20);
            this.lblPalletTypeLabel.TabIndex = 25;
            this.lblPalletTypeLabel.Text = "Tipo MP";
            // 
            // lblProductLabel
            // 
            this.lblProductLabel.AutoSize = true;
            this.lblProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductLabel.Location = new System.Drawing.Point(324, 42);
            this.lblProductLabel.Name = "lblProductLabel";
            this.lblProductLabel.Size = new System.Drawing.Size(73, 20);
            this.lblProductLabel.TabIndex = 27;
            this.lblProductLabel.Text = "Producto";
            // 
            // lblProduct
            // 
            this.lblProduct.BackColor = System.Drawing.SystemColors.Window;
            this.lblProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblProduct.Location = new System.Drawing.Point(401, 42);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(309, 21);
            this.lblProduct.TabIndex = 28;
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNWeight
            // 
            this.txtNWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.txtNWeight.Location = new System.Drawing.Point(444, 73);
            this.txtNWeight.Multiline = true;
            this.txtNWeight.Name = "txtNWeight";
            this.txtNWeight.Size = new System.Drawing.Size(266, 73);
            this.txtNWeight.TabIndex = 36;
            // 
            // grpbDetail
            // 
            this.grpbDetail.Controls.Add(this.label6);
            this.grpbDetail.Controls.Add(this.lblPro);
            this.grpbDetail.Controls.Add(this.label4);
            this.grpbDetail.Controls.Add(this.lblIn);
            this.grpbDetail.Controls.Add(this.label1);
            this.grpbDetail.Controls.Add(this.lblFor);
            this.grpbDetail.Controls.Add(this.lblPalletTypeLabel);
            this.grpbDetail.Controls.Add(this.label2);
            this.grpbDetail.Controls.Add(this.txtNWeight);
            this.grpbDetail.Controls.Add(this.lblLot);
            this.grpbDetail.Controls.Add(this.lblTmP);
            this.grpbDetail.Controls.Add(this.lblProduct);
            this.grpbDetail.Controls.Add(this.lblNetWeigthLabel);
            this.grpbDetail.Controls.Add(this.lblProductLabel);
            this.grpbDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbDetail.Location = new System.Drawing.Point(0, 51);
            this.grpbDetail.Name = "grpbDetail";
            this.grpbDetail.Size = new System.Drawing.Size(722, 155);
            this.grpbDetail.TabIndex = 3;
            this.grpbDetail.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "F. Proceso";
            // 
            // lblPro
            // 
            this.lblPro.BackColor = System.Drawing.SystemColors.Window;
            this.lblPro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPro.ForeColor = System.Drawing.Color.Red;
            this.lblPro.Location = new System.Drawing.Point(120, 125);
            this.lblPro.Name = "lblPro";
            this.lblPro.Size = new System.Drawing.Size(235, 21);
            this.lblPro.TabIndex = 42;
            this.lblPro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "F. Ingreso BT";
            // 
            // lblIn
            // 
            this.lblIn.BackColor = System.Drawing.SystemColors.Window;
            this.lblIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIn.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblIn.Location = new System.Drawing.Point(120, 96);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(235, 21);
            this.lblIn.TabIndex = 40;
            this.lblIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Fórmula";
            // 
            // lblFor
            // 
            this.lblFor.BackColor = System.Drawing.SystemColors.Window;
            this.lblFor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFor.Location = new System.Drawing.Point(120, 16);
            this.lblFor.Name = "lblFor";
            this.lblFor.Size = new System.Drawing.Size(590, 21);
            this.lblFor.TabIndex = 38;
            this.lblFor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmTraza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(722, 206);
            this.Controls.Add(this.grpbDetail);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTraza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trazabilidad Pallet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpbDetail.ResumeLayout(false);
            this.grpbDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLot;
        private System.Windows.Forms.Label lblTmP;
        private System.Windows.Forms.Label lblNetWeigthLabel;
        private System.Windows.Forms.Label lblPalletTypeLabel;
        private System.Windows.Forms.Label lblCodeLabel;
        private System.Windows.Forms.Label lblProductLabel;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox txtNWeight;
        private System.Windows.Forms.GroupBox grpbDetail;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPro;
    }
}