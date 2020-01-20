namespace BPS
{
    partial class frmMillPalletDetail
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMillPalletDetail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.ttpMill = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblMill = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBag = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWeigthGross = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblWeigthPallet = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblWeigthNet = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblWeigthNet);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblWeigthGross);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblWeigthPallet);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblBag);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblMill);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.lblCode);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 44);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(13, 15);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(46, 15);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Código";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(64, 10);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(261, 24);
            this.txtCode.TabIndex = 1;
            this.txtCode.Text = "3C11036";
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo";
            // 
            // lblType
            // 
            this.lblType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblType.Location = new System.Drawing.Point(64, 42);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(261, 21);
            this.lblType.TabIndex = 3;
            // 
            // lblMill
            // 
            this.lblMill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMill.Location = new System.Drawing.Point(64, 72);
            this.lblMill.Name = "lblMill";
            this.lblMill.Size = new System.Drawing.Size(88, 21);
            this.lblMill.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Molino";
            // 
            // lblBag
            // 
            this.lblBag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBag.Location = new System.Drawing.Point(215, 72);
            this.lblBag.Name = "lblBag";
            this.lblBag.Size = new System.Drawing.Size(99, 21);
            this.lblBag.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sacos";
            // 
            // lblWeigthGross
            // 
            this.lblWeigthGross.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWeigthGross.Location = new System.Drawing.Point(215, 102);
            this.lblWeigthGross.Name = "lblWeigthGross";
            this.lblWeigthGross.Size = new System.Drawing.Size(99, 21);
            this.lblWeigthGross.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(158, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "P. Bruto";
            // 
            // lblWeigthPallet
            // 
            this.lblWeigthPallet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWeigthPallet.Location = new System.Drawing.Point(64, 102);
            this.lblWeigthPallet.Name = "lblWeigthPallet";
            this.lblWeigthPallet.Size = new System.Drawing.Size(88, 21);
            this.lblWeigthPallet.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "P. Pallet";
            // 
            // lblWeigthNet
            // 
            this.lblWeigthNet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWeigthNet.Location = new System.Drawing.Point(64, 132);
            this.lblWeigthNet.Name = "lblWeigthNet";
            this.lblWeigthNet.Size = new System.Drawing.Size(250, 21);
            this.lblWeigthNet.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 15);
            this.label13.TabIndex = 12;
            this.label13.Text = "P. Neto";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackgroundImage = global::BPS.Properties.Resources.printer;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrint.Location = new System.Drawing.Point(304, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(25, 25);
            this.btnPrint.TabIndex = 20;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmMillPalletDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(334, 202);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMillPalletDetail";
            this.Text = "Re-Procesado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolTip ttpMill;
        private System.Windows.Forms.Label lblWeigthNet;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblWeigthGross;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblWeigthPallet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblBag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrint;
    }
}