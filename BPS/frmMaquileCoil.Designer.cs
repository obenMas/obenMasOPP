namespace BPS
{
    partial class frmMaquileCoil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaquileCoil));
            this.tbcCoil = new System.Windows.Forms.TabControl();
            this.tbpCoilInfo = new System.Windows.Forms.TabPage();
            this.txtcoil = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpallet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRizon = new System.Windows.Forms.TextBox();
            this.lblCoilCellarLabel = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.lblCoilCellar = new System.Windows.Forms.Label();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblCustomerLabel = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.grpbDefects = new System.Windows.Forms.GroupBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.cmbCore = new System.Windows.Forms.ComboBox();
            this.lblCore = new System.Windows.Forms.Label();
            this.cmbDiameter = new System.Windows.Forms.ComboBox();
            this.lblDiameter = new System.Windows.Forms.Label();
            this.cmbMaquile = new System.Windows.Forms.ComboBox();
            this.lblMaquile = new System.Windows.Forms.Label();
            this.lblNetWeigthLabel = new System.Windows.Forms.Label();
            this.lblDiameterLabel = new System.Windows.Forms.Label();
            this.grpbEmpty = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnMainCoilExit = new System.Windows.Forms.Button();
            this.ttpCoilDetail = new System.Windows.Forms.ToolTip(this.components);
            this.tbcCoil.SuspendLayout();
            this.tbpCoilInfo.SuspendLayout();
            this.grpbDefects.SuspendLayout();
            this.grpbEmpty.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcCoil
            // 
            this.tbcCoil.Controls.Add(this.tbpCoilInfo);
            this.tbcCoil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcCoil.Location = new System.Drawing.Point(0, 0);
            this.tbcCoil.Name = "tbcCoil";
            this.tbcCoil.SelectedIndex = 0;
            this.tbcCoil.Size = new System.Drawing.Size(484, 413);
            this.tbcCoil.TabIndex = 0;
            // 
            // tbpCoilInfo
            // 
            this.tbpCoilInfo.BackColor = System.Drawing.SystemColors.Window;
            this.tbpCoilInfo.Controls.Add(this.txtcoil);
            this.tbpCoilInfo.Controls.Add(this.label2);
            this.tbpCoilInfo.Controls.Add(this.txtpallet);
            this.tbpCoilInfo.Controls.Add(this.label3);
            this.tbpCoilInfo.Controls.Add(this.lblCode);
            this.tbpCoilInfo.Controls.Add(this.label1);
            this.tbpCoilInfo.Controls.Add(this.txtRizon);
            this.tbpCoilInfo.Controls.Add(this.lblCoilCellarLabel);
            this.tbpCoilInfo.Controls.Add(this.txtCustomer);
            this.tbpCoilInfo.Controls.Add(this.lblCoilCellar);
            this.tbpCoilInfo.Controls.Add(this.pnlStatus);
            this.tbpCoilInfo.Controls.Add(this.lblCustomerLabel);
            this.tbpCoilInfo.Controls.Add(this.txtWeight);
            this.tbpCoilInfo.Controls.Add(this.grpbDefects);
            this.tbpCoilInfo.Controls.Add(this.lblNetWeigthLabel);
            this.tbpCoilInfo.Controls.Add(this.lblDiameterLabel);
            this.tbpCoilInfo.Controls.Add(this.grpbEmpty);
            this.tbpCoilInfo.Location = new System.Drawing.Point(4, 24);
            this.tbpCoilInfo.Name = "tbpCoilInfo";
            this.tbpCoilInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCoilInfo.Size = new System.Drawing.Size(476, 385);
            this.tbpCoilInfo.TabIndex = 1;
            this.tbpCoilInfo.Text = "Información maquila";
            // 
            // txtcoil
            // 
            this.txtcoil.Location = new System.Drawing.Point(99, 193);
            this.txtcoil.Name = "txtcoil";
            this.txtcoil.Size = new System.Drawing.Size(70, 21);
            this.txtcoil.TabIndex = 5;
            this.txtcoil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcoil_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 51;
            this.label2.Text = "# Bobinas";
            // 
            // txtpallet
            // 
            this.txtpallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpallet.Location = new System.Drawing.Point(99, 166);
            this.txtpallet.Name = "txtpallet";
            this.txtpallet.Size = new System.Drawing.Size(69, 21);
            this.txtpallet.TabIndex = 4;
            this.txtpallet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpallet_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 54;
            this.label3.Text = "# Pallet";
            // 
            // lblCode
            // 
            this.lblCode.BackColor = System.Drawing.SystemColors.Window;
            this.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(100, 142);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(358, 21);
            this.lblCode.TabIndex = 3;
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 49;
            this.label1.Text = "Código";
            // 
            // txtRizon
            // 
            this.txtRizon.Location = new System.Drawing.Point(100, 89);
            this.txtRizon.Multiline = true;
            this.txtRizon.Name = "txtRizon";
            this.txtRizon.Size = new System.Drawing.Size(358, 49);
            this.txtRizon.TabIndex = 2;
            // 
            // lblCoilCellarLabel
            // 
            this.lblCoilCellarLabel.AutoSize = true;
            this.lblCoilCellarLabel.Location = new System.Drawing.Point(43, 66);
            this.lblCoilCellarLabel.Name = "lblCoilCellarLabel";
            this.lblCoilCellarLabel.Size = new System.Drawing.Size(50, 15);
            this.lblCoilCellarLabel.TabIndex = 4;
            this.lblCoilCellarLabel.Text = "Bodega";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(100, 36);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(358, 21);
            this.txtCustomer.TabIndex = 1;
            // 
            // lblCoilCellar
            // 
            this.lblCoilCellar.BackColor = System.Drawing.SystemColors.Window;
            this.lblCoilCellar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCoilCellar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoilCellar.Location = new System.Drawing.Point(100, 63);
            this.lblCoilCellar.Name = "lblCoilCellar";
            this.lblCoilCellar.Size = new System.Drawing.Size(217, 21);
            this.lblCoilCellar.TabIndex = 5;
            this.lblCoilCellar.Text = "Maquilas";
            this.lblCoilCellar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.SystemColors.Window;
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStatus.Location = new System.Drawing.Point(3, 3);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(4, 211);
            this.pnlStatus.TabIndex = 47;
            // 
            // lblCustomerLabel
            // 
            this.lblCustomerLabel.AutoSize = true;
            this.lblCustomerLabel.Location = new System.Drawing.Point(48, 39);
            this.lblCustomerLabel.Name = "lblCustomerLabel";
            this.lblCustomerLabel.Size = new System.Drawing.Size(45, 15);
            this.lblCustomerLabel.TabIndex = 0;
            this.lblCustomerLabel.Text = "Cliente";
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(100, 9);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(217, 21);
            this.txtWeight.TabIndex = 0;
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeight_KeyPress);
            // 
            // grpbDefects
            // 
            this.grpbDefects.Controls.Add(this.txtWidth);
            this.grpbDefects.Controls.Add(this.lblWidth);
            this.grpbDefects.Controls.Add(this.cmbCore);
            this.grpbDefects.Controls.Add(this.lblCore);
            this.grpbDefects.Controls.Add(this.cmbDiameter);
            this.grpbDefects.Controls.Add(this.lblDiameter);
            this.grpbDefects.Controls.Add(this.cmbMaquile);
            this.grpbDefects.Controls.Add(this.lblMaquile);
            this.grpbDefects.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbDefects.Location = new System.Drawing.Point(3, 214);
            this.grpbDefects.Name = "grpbDefects";
            this.grpbDefects.Size = new System.Drawing.Size(470, 130);
            this.grpbDefects.TabIndex = 30;
            this.grpbDefects.TabStop = false;
            this.grpbDefects.Text = "Material";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(184, 100);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(70, 21);
            this.txtWidth.TabIndex = 55;
            this.txtWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWidth_KeyPress);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(137, 103);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(41, 15);
            this.lblWidth.TabIndex = 56;
            this.lblWidth.Text = "Ancho";
            // 
            // cmbCore
            // 
            this.cmbCore.FormattingEnabled = true;
            this.cmbCore.Location = new System.Drawing.Point(184, 71);
            this.cmbCore.Name = "cmbCore";
            this.cmbCore.Size = new System.Drawing.Size(194, 23);
            this.cmbCore.TabIndex = 60;
            // 
            // lblCore
            // 
            this.lblCore.AutoSize = true;
            this.lblCore.Location = new System.Drawing.Point(145, 74);
            this.lblCore.Name = "lblCore";
            this.lblCore.Size = new System.Drawing.Size(33, 15);
            this.lblCore.TabIndex = 59;
            this.lblCore.Text = "Core";
            // 
            // cmbDiameter
            // 
            this.cmbDiameter.FormattingEnabled = true;
            this.cmbDiameter.Location = new System.Drawing.Point(184, 42);
            this.cmbDiameter.Name = "cmbDiameter";
            this.cmbDiameter.Size = new System.Drawing.Size(194, 23);
            this.cmbDiameter.TabIndex = 58;
            // 
            // lblDiameter
            // 
            this.lblDiameter.AutoSize = true;
            this.lblDiameter.Location = new System.Drawing.Point(120, 45);
            this.lblDiameter.Name = "lblDiameter";
            this.lblDiameter.Size = new System.Drawing.Size(58, 15);
            this.lblDiameter.TabIndex = 57;
            this.lblDiameter.Text = "Diámetro";
            // 
            // cmbMaquile
            // 
            this.cmbMaquile.FormattingEnabled = true;
            this.cmbMaquile.Location = new System.Drawing.Point(184, 13);
            this.cmbMaquile.Name = "cmbMaquile";
            this.cmbMaquile.Size = new System.Drawing.Size(194, 23);
            this.cmbMaquile.TabIndex = 56;
            // 
            // lblMaquile
            // 
            this.lblMaquile.AutoSize = true;
            this.lblMaquile.Location = new System.Drawing.Point(93, 16);
            this.lblMaquile.Name = "lblMaquile";
            this.lblMaquile.Size = new System.Drawing.Size(85, 15);
            this.lblMaquile.TabIndex = 55;
            this.lblMaquile.Text = "Tipo Maquilas";
            // 
            // lblNetWeigthLabel
            // 
            this.lblNetWeigthLabel.AutoSize = true;
            this.lblNetWeigthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetWeigthLabel.Location = new System.Drawing.Point(30, 12);
            this.lblNetWeigthLabel.Name = "lblNetWeigthLabel";
            this.lblNetWeigthLabel.Size = new System.Drawing.Size(64, 15);
            this.lblNetWeigthLabel.TabIndex = 12;
            this.lblNetWeigthLabel.Text = "Peso Neto";
            // 
            // lblDiameterLabel
            // 
            this.lblDiameterLabel.AutoSize = true;
            this.lblDiameterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiameterLabel.Location = new System.Drawing.Point(18, 92);
            this.lblDiameterLabel.Name = "lblDiameterLabel";
            this.lblDiameterLabel.Size = new System.Drawing.Size(75, 15);
            this.lblDiameterLabel.TabIndex = 8;
            this.lblDiameterLabel.Text = "Observación";
            // 
            // grpbEmpty
            // 
            this.grpbEmpty.Controls.Add(this.btnSave);
            this.grpbEmpty.Controls.Add(this.btnMainCoilExit);
            this.grpbEmpty.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbEmpty.Location = new System.Drawing.Point(3, 344);
            this.grpbEmpty.Name = "grpbEmpty";
            this.grpbEmpty.Size = new System.Drawing.Size(470, 38);
            this.grpbEmpty.TabIndex = 34;
            this.grpbEmpty.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::BPS.Properties.Resources.disk;
            this.btnSave.Location = new System.Drawing.Point(415, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(25, 25);
            this.btnSave.TabIndex = 1;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnMainCoilExit
            // 
            this.btnMainCoilExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnMainCoilExit.Location = new System.Drawing.Point(440, 10);
            this.btnMainCoilExit.Name = "btnMainCoilExit";
            this.btnMainCoilExit.Size = new System.Drawing.Size(25, 25);
            this.btnMainCoilExit.TabIndex = 2;
            this.ttpCoilDetail.SetToolTip(this.btnMainCoilExit, "Salir Bobinas");
            this.btnMainCoilExit.UseVisualStyleBackColor = true;
            this.btnMainCoilExit.Click += new System.EventHandler(this.btnMainCoilExit_Click);
            // 
            // frmMaquileCoil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(484, 413);
            this.Controls.Add(this.tbcCoil);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMaquileCoil";
            this.Text = "Detalle de Maquilas";
            this.Load += new System.EventHandler(this.frmMaquileCoil_Load);
            this.tbcCoil.ResumeLayout(false);
            this.tbpCoilInfo.ResumeLayout(false);
            this.tbpCoilInfo.PerformLayout();
            this.grpbDefects.ResumeLayout(false);
            this.grpbDefects.PerformLayout();
            this.grpbEmpty.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCoil;
        private System.Windows.Forms.TabPage tbpCoilInfo;
        private System.Windows.Forms.Label lblNetWeigthLabel;
        private System.Windows.Forms.Label lblDiameterLabel;
        private System.Windows.Forms.GroupBox grpbEmpty;
        private System.Windows.Forms.Button btnMainCoilExit;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.ToolTip ttpCoilDetail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label lblCustomerLabel;
        private System.Windows.Forms.GroupBox grpbDefects;
        private System.Windows.Forms.Label lblCoilCellarLabel;
        private System.Windows.Forms.Label lblCoilCellar;
        private System.Windows.Forms.TextBox txtRizon;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcoil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpallet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMaquile;
        private System.Windows.Forms.Label lblMaquile;
        private System.Windows.Forms.ComboBox cmbCore;
        private System.Windows.Forms.Label lblCore;
        private System.Windows.Forms.ComboBox cmbDiameter;
        private System.Windows.Forms.Label lblDiameter;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblWidth;

    }
}