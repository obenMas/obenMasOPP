namespace BPS
{
    partial class frmPalletType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPalletType));
            this.grpbInfo = new System.Windows.Forms.GroupBox();
            this.btnAddPallet = new System.Windows.Forms.Button();
            this.lblresultpallet = new System.Windows.Forms.Label();
            this.cboFloor = new System.Windows.Forms.ComboBox();
            this.lblNumberFloorLabel = new System.Windows.Forms.Label();
            this.cbotraining = new System.Windows.Forms.ComboBox();
            this.lbltraining = new System.Windows.Forms.Label();
            this.txtnumbercoilbystop = new System.Windows.Forms.TextBox();
            this.lblnumbercoilbystopLabel = new System.Windows.Forms.Label();
            this.ttpAddPallet = new System.Windows.Forms.ToolTip(this.components);
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.grpbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbInfo
            // 
            this.grpbInfo.Controls.Add(this.txtCode);
            this.grpbInfo.Controls.Add(this.btnAddPallet);
            this.grpbInfo.Controls.Add(this.lblresultpallet);
            this.grpbInfo.Controls.Add(this.cboFloor);
            this.grpbInfo.Controls.Add(this.lblCode);
            this.grpbInfo.Controls.Add(this.lblNumberFloorLabel);
            this.grpbInfo.Controls.Add(this.cbotraining);
            this.grpbInfo.Controls.Add(this.lbltraining);
            this.grpbInfo.Controls.Add(this.txtnumbercoilbystop);
            this.grpbInfo.Controls.Add(this.lblnumbercoilbystopLabel);
            this.grpbInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbInfo.Location = new System.Drawing.Point(0, 0);
            this.grpbInfo.Name = "grpbInfo";
            this.grpbInfo.Size = new System.Drawing.Size(642, 82);
            this.grpbInfo.TabIndex = 0;
            this.grpbInfo.TabStop = false;
            // 
            // btnAddPallet
            // 
            this.btnAddPallet.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnAddPallet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddPallet.Location = new System.Drawing.Point(608, 47);
            this.btnAddPallet.Name = "btnAddPallet";
            this.btnAddPallet.Size = new System.Drawing.Size(25, 25);
            this.btnAddPallet.TabIndex = 9;
            this.ttpAddPallet.SetToolTip(this.btnAddPallet, "Agregar");
            this.btnAddPallet.UseVisualStyleBackColor = true;
            this.btnAddPallet.Click += new System.EventHandler(this.btnAddPallet_Click);
            // 
            // lblresultpallet
            // 
            this.lblresultpallet.AutoSize = true;
            this.lblresultpallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultpallet.Location = new System.Drawing.Point(143, 49);
            this.lblresultpallet.Name = "lblresultpallet";
            this.lblresultpallet.Size = new System.Drawing.Size(0, 20);
            this.lblresultpallet.TabIndex = 8;
            // 
            // cboFloor
            // 
            this.cboFloor.FormattingEnabled = true;
            this.cboFloor.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboFloor.Location = new System.Drawing.Point(460, 14);
            this.cboFloor.Name = "cboFloor";
            this.cboFloor.Size = new System.Drawing.Size(47, 23);
            this.cboFloor.TabIndex = 5;
            this.cboFloor.SelectedIndexChanged += new System.EventHandler(this.cboFloor_SelectedIndexChanged);
            // 
            // lblNumberFloorLabel
            // 
            this.lblNumberFloorLabel.AutoSize = true;
            this.lblNumberFloorLabel.Location = new System.Drawing.Point(404, 17);
            this.lblNumberFloorLabel.Name = "lblNumberFloorLabel";
            this.lblNumberFloorLabel.Size = new System.Drawing.Size(50, 15);
            this.lblNumberFloorLabel.TabIndex = 4;
            this.lblNumberFloorLabel.Text = "# Pisos:";
            // 
            // cbotraining
            // 
            this.cbotraining.FormattingEnabled = true;
            this.cbotraining.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical"});
            this.cbotraining.Location = new System.Drawing.Point(261, 14);
            this.cbotraining.Name = "cbotraining";
            this.cbotraining.Size = new System.Drawing.Size(130, 23);
            this.cbotraining.TabIndex = 3;
            this.cbotraining.SelectedIndexChanged += new System.EventHandler(this.cbotraining_SelectedIndexChanged);
            // 
            // lbltraining
            // 
            this.lbltraining.AutoSize = true;
            this.lbltraining.Location = new System.Drawing.Point(182, 17);
            this.lbltraining.Name = "lbltraining";
            this.lbltraining.Size = new System.Drawing.Size(73, 15);
            this.lbltraining.TabIndex = 2;
            this.lbltraining.Text = "Orientación:";
            // 
            // txtnumbercoilbystop
            // 
            this.txtnumbercoilbystop.Location = new System.Drawing.Point(141, 14);
            this.txtnumbercoilbystop.Name = "txtnumbercoilbystop";
            this.txtnumbercoilbystop.Size = new System.Drawing.Size(28, 21);
            this.txtnumbercoilbystop.TabIndex = 1;
            this.txtnumbercoilbystop.TextChanged += new System.EventHandler(this.txtnumbercoilbystop_TextChanged);
            // 
            // lblnumbercoilbystopLabel
            // 
            this.lblnumbercoilbystopLabel.AutoSize = true;
            this.lblnumbercoilbystopLabel.Location = new System.Drawing.Point(6, 17);
            this.lblnumbercoilbystopLabel.Name = "lblnumbercoilbystopLabel";
            this.lblnumbercoilbystopLabel.Size = new System.Drawing.Size(129, 15);
            this.lblnumbercoilbystopLabel.TabIndex = 0;
            this.lblnumbercoilbystopLabel.Text = "# Bobinas por Parada:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(572, 14);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(61, 21);
            this.txtCode.TabIndex = 7;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(513, 17);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(46, 15);
            this.lblCode.TabIndex = 6;
            this.lblCode.Text = "Código";
            // 
            // frmPalletType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(642, 82);
            this.Controls.Add(this.grpbInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPalletType";
            this.Text = "Registro Palets";
            this.grpbInfo.ResumeLayout(false);
            this.grpbInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbInfo;
        private System.Windows.Forms.TextBox txtnumbercoilbystop;
        private System.Windows.Forms.Label lblnumbercoilbystopLabel;
        private System.Windows.Forms.ComboBox cbotraining;
        private System.Windows.Forms.Label lbltraining;
        private System.Windows.Forms.ComboBox cboFloor;
        private System.Windows.Forms.Label lblNumberFloorLabel;
        private System.Windows.Forms.Label lblresultpallet;
        private System.Windows.Forms.Button btnAddPallet;
        private System.Windows.Forms.ToolTip ttpAddPallet;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
    }
}