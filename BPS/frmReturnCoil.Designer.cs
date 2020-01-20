namespace BPS
{
    partial class frmReturnCoil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReturnCoil));
            this.tbcCoil = new System.Windows.Forms.TabControl();
            this.tbpCoilInfo = new System.Windows.Forms.TabPage();
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
            this.grpbOpp = new System.Windows.Forms.GroupBox();
            this.cmbFilmOpp = new System.Windows.Forms.ComboBox();
            this.rdbProductOpp = new System.Windows.Forms.RadioButton();
            this.cmbProductOpp = new System.Windows.Forms.ComboBox();
            this.rdbFilmOpp = new System.Windows.Forms.RadioButton();
            this.grpbBopp = new System.Windows.Forms.GroupBox();
            this.cmbFilm = new System.Windows.Forms.ComboBox();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.rdbFilm = new System.Windows.Forms.RadioButton();
            this.rdbProduct = new System.Windows.Forms.RadioButton();
            this.lblNetWeigthLabel = new System.Windows.Forms.Label();
            this.lblDiameterLabel = new System.Windows.Forms.Label();
            this.grpbEmpty = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnMainCoilExit = new System.Windows.Forms.Button();
            this.ttpCoilDetail = new System.Windows.Forms.ToolTip(this.components);
            this.txtcoil = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpallet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbcCoil.SuspendLayout();
            this.tbpCoilInfo.SuspendLayout();
            this.grpbDefects.SuspendLayout();
            this.grpbOpp.SuspendLayout();
            this.grpbBopp.SuspendLayout();
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
            this.tbcCoil.Size = new System.Drawing.Size(464, 451);
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
            this.tbpCoilInfo.Size = new System.Drawing.Size(456, 423);
            this.tbpCoilInfo.TabIndex = 1;
            this.tbpCoilInfo.Text = "Información devolución";
            // 
            // lblCode
            // 
            this.lblCode.BackColor = System.Drawing.SystemColors.Window;
            this.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(87, 142);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(358, 21);
            this.lblCode.TabIndex = 50;
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 49;
            this.label1.Text = "Código";
            // 
            // txtRizon
            // 
            this.txtRizon.Location = new System.Drawing.Point(87, 89);
            this.txtRizon.Multiline = true;
            this.txtRizon.Name = "txtRizon";
            this.txtRizon.Size = new System.Drawing.Size(358, 49);
            this.txtRizon.TabIndex = 48;
            // 
            // lblCoilCellarLabel
            // 
            this.lblCoilCellarLabel.AutoSize = true;
            this.lblCoilCellarLabel.Location = new System.Drawing.Point(30, 66);
            this.lblCoilCellarLabel.Name = "lblCoilCellarLabel";
            this.lblCoilCellarLabel.Size = new System.Drawing.Size(50, 15);
            this.lblCoilCellarLabel.TabIndex = 4;
            this.lblCoilCellarLabel.Text = "Bodega";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(87, 36);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(358, 21);
            this.txtCustomer.TabIndex = 6;
            // 
            // lblCoilCellar
            // 
            this.lblCoilCellar.BackColor = System.Drawing.SystemColors.Window;
            this.lblCoilCellar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCoilCellar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoilCellar.Location = new System.Drawing.Point(87, 63);
            this.lblCoilCellar.Name = "lblCoilCellar";
            this.lblCoilCellar.Size = new System.Drawing.Size(217, 21);
            this.lblCoilCellar.TabIndex = 5;
            this.lblCoilCellar.Text = " Devoluciones";
            this.lblCoilCellar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.SystemColors.Window;
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStatus.Location = new System.Drawing.Point(3, 3);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(4, 215);
            this.pnlStatus.TabIndex = 47;
            // 
            // lblCustomerLabel
            // 
            this.lblCustomerLabel.AutoSize = true;
            this.lblCustomerLabel.Location = new System.Drawing.Point(35, 39);
            this.lblCustomerLabel.Name = "lblCustomerLabel";
            this.lblCustomerLabel.Size = new System.Drawing.Size(45, 15);
            this.lblCustomerLabel.TabIndex = 0;
            this.lblCustomerLabel.Text = "Cliente";
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(87, 9);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(217, 21);
            this.txtWeight.TabIndex = 1;
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWeight_KeyPress);
            // 
            // grpbDefects
            // 
            this.grpbDefects.Controls.Add(this.grpbOpp);
            this.grpbDefects.Controls.Add(this.grpbBopp);
            this.grpbDefects.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbDefects.Location = new System.Drawing.Point(3, 218);
            this.grpbDefects.Name = "grpbDefects";
            this.grpbDefects.Size = new System.Drawing.Size(450, 164);
            this.grpbDefects.TabIndex = 30;
            this.grpbDefects.TabStop = false;
            this.grpbDefects.Text = "Material";
            // 
            // grpbOpp
            // 
            this.grpbOpp.Controls.Add(this.cmbFilmOpp);
            this.grpbOpp.Controls.Add(this.rdbProductOpp);
            this.grpbOpp.Controls.Add(this.cmbProductOpp);
            this.grpbOpp.Controls.Add(this.rdbFilmOpp);
            this.grpbOpp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbOpp.Location = new System.Drawing.Point(3, 89);
            this.grpbOpp.Name = "grpbOpp";
            this.grpbOpp.Size = new System.Drawing.Size(444, 72);
            this.grpbOpp.TabIndex = 5;
            this.grpbOpp.TabStop = false;
            this.grpbOpp.Text = "Opp";
            // 
            // cmbFilmOpp
            // 
            this.cmbFilmOpp.FormattingEnabled = true;
            this.cmbFilmOpp.Location = new System.Drawing.Point(2, 45);
            this.cmbFilmOpp.Name = "cmbFilmOpp";
            this.cmbFilmOpp.Size = new System.Drawing.Size(216, 23);
            this.cmbFilmOpp.TabIndex = 6;
            // 
            // rdbProductOpp
            // 
            this.rdbProductOpp.AutoSize = true;
            this.rdbProductOpp.Location = new System.Drawing.Point(223, 20);
            this.rdbProductOpp.Name = "rdbProductOpp";
            this.rdbProductOpp.Size = new System.Drawing.Size(74, 19);
            this.rdbProductOpp.TabIndex = 5;
            this.rdbProductOpp.TabStop = true;
            this.rdbProductOpp.Text = "Producto";
            this.rdbProductOpp.UseVisualStyleBackColor = true;
            this.rdbProductOpp.CheckedChanged += new System.EventHandler(this.rdbProductOpp_CheckedChanged);
            // 
            // cmbProductOpp
            // 
            this.cmbProductOpp.FormattingEnabled = true;
            this.cmbProductOpp.Location = new System.Drawing.Point(222, 45);
            this.cmbProductOpp.Name = "cmbProductOpp";
            this.cmbProductOpp.Size = new System.Drawing.Size(216, 23);
            this.cmbProductOpp.TabIndex = 7;
            // 
            // rdbFilmOpp
            // 
            this.rdbFilmOpp.AutoSize = true;
            this.rdbFilmOpp.Location = new System.Drawing.Point(3, 20);
            this.rdbFilmOpp.Name = "rdbFilmOpp";
            this.rdbFilmOpp.Size = new System.Drawing.Size(69, 19);
            this.rdbFilmOpp.TabIndex = 4;
            this.rdbFilmOpp.TabStop = true;
            this.rdbFilmOpp.Text = "Película";
            this.rdbFilmOpp.UseVisualStyleBackColor = true;
            this.rdbFilmOpp.CheckedChanged += new System.EventHandler(this.rdbFilmOpp_CheckedChanged);
            // 
            // grpbBopp
            // 
            this.grpbBopp.Controls.Add(this.cmbFilm);
            this.grpbBopp.Controls.Add(this.cmbProduct);
            this.grpbBopp.Controls.Add(this.rdbFilm);
            this.grpbBopp.Controls.Add(this.rdbProduct);
            this.grpbBopp.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbBopp.Location = new System.Drawing.Point(3, 17);
            this.grpbBopp.Name = "grpbBopp";
            this.grpbBopp.Size = new System.Drawing.Size(444, 72);
            this.grpbBopp.TabIndex = 4;
            this.grpbBopp.TabStop = false;
            this.grpbBopp.Text = "Bopp";
            // 
            // cmbFilm
            // 
            this.cmbFilm.FormattingEnabled = true;
            this.cmbFilm.Location = new System.Drawing.Point(3, 41);
            this.cmbFilm.Name = "cmbFilm";
            this.cmbFilm.Size = new System.Drawing.Size(216, 23);
            this.cmbFilm.TabIndex = 2;
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(223, 41);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(216, 23);
            this.cmbProduct.TabIndex = 3;
            // 
            // rdbFilm
            // 
            this.rdbFilm.AutoSize = true;
            this.rdbFilm.Location = new System.Drawing.Point(4, 16);
            this.rdbFilm.Name = "rdbFilm";
            this.rdbFilm.Size = new System.Drawing.Size(69, 19);
            this.rdbFilm.TabIndex = 0;
            this.rdbFilm.TabStop = true;
            this.rdbFilm.Text = "Película";
            this.rdbFilm.UseVisualStyleBackColor = true;
            this.rdbFilm.CheckedChanged += new System.EventHandler(this.rdbFilm_CheckedChanged);
            // 
            // rdbProduct
            // 
            this.rdbProduct.AutoSize = true;
            this.rdbProduct.Location = new System.Drawing.Point(224, 16);
            this.rdbProduct.Name = "rdbProduct";
            this.rdbProduct.Size = new System.Drawing.Size(74, 19);
            this.rdbProduct.TabIndex = 1;
            this.rdbProduct.TabStop = true;
            this.rdbProduct.Text = "Producto";
            this.rdbProduct.UseVisualStyleBackColor = true;
            this.rdbProduct.CheckedChanged += new System.EventHandler(this.rdbProduct_CheckedChanged);
            // 
            // lblNetWeigthLabel
            // 
            this.lblNetWeigthLabel.AutoSize = true;
            this.lblNetWeigthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetWeigthLabel.Location = new System.Drawing.Point(17, 12);
            this.lblNetWeigthLabel.Name = "lblNetWeigthLabel";
            this.lblNetWeigthLabel.Size = new System.Drawing.Size(64, 15);
            this.lblNetWeigthLabel.TabIndex = 12;
            this.lblNetWeigthLabel.Text = "Peso Neto";
            // 
            // lblDiameterLabel
            // 
            this.lblDiameterLabel.AutoSize = true;
            this.lblDiameterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiameterLabel.Location = new System.Drawing.Point(38, 92);
            this.lblDiameterLabel.Name = "lblDiameterLabel";
            this.lblDiameterLabel.Size = new System.Drawing.Size(43, 15);
            this.lblDiameterLabel.TabIndex = 8;
            this.lblDiameterLabel.Text = "Razón";
            // 
            // grpbEmpty
            // 
            this.grpbEmpty.Controls.Add(this.btnSave);
            this.grpbEmpty.Controls.Add(this.btnMainCoilExit);
            this.grpbEmpty.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbEmpty.Location = new System.Drawing.Point(3, 382);
            this.grpbEmpty.Name = "grpbEmpty";
            this.grpbEmpty.Size = new System.Drawing.Size(450, 38);
            this.grpbEmpty.TabIndex = 34;
            this.grpbEmpty.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::BPS.Properties.Resources.disk;
            this.btnSave.Location = new System.Drawing.Point(392, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(25, 25);
            this.btnSave.TabIndex = 1;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnMainCoilExit
            // 
            this.btnMainCoilExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnMainCoilExit.Location = new System.Drawing.Point(417, 10);
            this.btnMainCoilExit.Name = "btnMainCoilExit";
            this.btnMainCoilExit.Size = new System.Drawing.Size(25, 25);
            this.btnMainCoilExit.TabIndex = 2;
            this.ttpCoilDetail.SetToolTip(this.btnMainCoilExit, "Salir Bobinas");
            this.btnMainCoilExit.UseVisualStyleBackColor = true;
            this.btnMainCoilExit.Click += new System.EventHandler(this.btnMainCoilExit_Click);
            // 
            // txtcoil
            // 
            this.txtcoil.Location = new System.Drawing.Point(86, 193);
            this.txtcoil.Name = "txtcoil";
            this.txtcoil.Size = new System.Drawing.Size(70, 21);
            this.txtcoil.TabIndex = 53;
            this.txtcoil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcoil_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 51;
            this.label2.Text = "# Bobinas";
            // 
            // txtpallet
            // 
            this.txtpallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpallet.Location = new System.Drawing.Point(86, 166);
            this.txtpallet.Name = "txtpallet";
            this.txtpallet.Size = new System.Drawing.Size(69, 21);
            this.txtpallet.TabIndex = 52;
            this.txtpallet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpallet_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 54;
            this.label3.Text = "# Pallet";
            // 
            // frmReturnCoil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(464, 451);
            this.Controls.Add(this.tbcCoil);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReturnCoil";
            this.Text = "Detalle de Devolución";
            this.Load += new System.EventHandler(this.frmCoilDetail_Load);
            this.tbcCoil.ResumeLayout(false);
            this.tbpCoilInfo.ResumeLayout(false);
            this.tbpCoilInfo.PerformLayout();
            this.grpbDefects.ResumeLayout(false);
            this.grpbOpp.ResumeLayout(false);
            this.grpbOpp.PerformLayout();
            this.grpbBopp.ResumeLayout(false);
            this.grpbBopp.PerformLayout();
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
        private System.Windows.Forms.RadioButton rdbProduct;
        private System.Windows.Forms.RadioButton rdbFilm;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.ComboBox cmbFilm;
        private System.Windows.Forms.TextBox txtRizon;
        private System.Windows.Forms.GroupBox grpbOpp;
        private System.Windows.Forms.ComboBox cmbFilmOpp;
        private System.Windows.Forms.RadioButton rdbProductOpp;
        private System.Windows.Forms.ComboBox cmbProductOpp;
        private System.Windows.Forms.RadioButton rdbFilmOpp;
        private System.Windows.Forms.GroupBox grpbBopp;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcoil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpallet;
        private System.Windows.Forms.Label label3;

    }
}