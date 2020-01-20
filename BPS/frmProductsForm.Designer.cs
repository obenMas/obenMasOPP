namespace BPS
{
    partial class frmProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductsForm));
            this.grpbProductType = new System.Windows.Forms.GroupBox();
            this.rdbNylon = new System.Windows.Forms.RadioButton();
            this.rdoCoating = new System.Windows.Forms.RadioButton();
            this.rdoCast = new System.Windows.Forms.RadioButton();
            this.rdoBopp = new System.Windows.Forms.RadioButton();
            this.grpGeneralInfo = new System.Windows.Forms.GroupBox();
            this.cmbUnits = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtSystemCode = new System.Windows.Forms.TextBox();
            this.lblUnits = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSystemCode = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpbFilm = new System.Windows.Forms.GroupBox();
            this.lblMm = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.cmbDiameter = new System.Windows.Forms.ComboBox();
            this.cmbCore = new System.Windows.Forms.ComboBox();
            this.cmbFilm = new System.Windows.Forms.ComboBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblDiameter = new System.Windows.Forms.Label();
            this.lblCore = new System.Windows.Forms.Label();
            this.lblBoppFilm = new System.Windows.Forms.Label();
            this.grpbEmpty = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ttpProductFilm = new System.Windows.Forms.ToolTip(this.components);
            this.grpbProductType.SuspendLayout();
            this.grpGeneralInfo.SuspendLayout();
            this.grpbFilm.SuspendLayout();
            this.grpbEmpty.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbProductType
            // 
            this.grpbProductType.Controls.Add(this.rdbNylon);
            this.grpbProductType.Controls.Add(this.rdoCoating);
            this.grpbProductType.Controls.Add(this.rdoCast);
            this.grpbProductType.Controls.Add(this.rdoBopp);
            this.grpbProductType.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbProductType.Location = new System.Drawing.Point(0, 0);
            this.grpbProductType.Name = "grpbProductType";
            this.grpbProductType.Size = new System.Drawing.Size(631, 60);
            this.grpbProductType.TabIndex = 0;
            this.grpbProductType.TabStop = false;
            this.grpbProductType.Text = "Tipo de producto";
            // 
            // rdbNylon
            // 
            this.rdbNylon.AutoSize = true;
            this.rdbNylon.Location = new System.Drawing.Point(438, 21);
            this.rdbNylon.Name = "rdbNylon";
            this.rdbNylon.Size = new System.Drawing.Size(103, 19);
            this.rdbNylon.TabIndex = 3;
            this.rdbNylon.TabStop = true;
            this.rdbNylon.Text = "Película Nylon";
            this.rdbNylon.UseVisualStyleBackColor = true;
            this.rdbNylon.CheckedChanged += new System.EventHandler(this.rdbNylon_CheckedChanged);
            // 
            // rdoCoating
            // 
            this.rdoCoating.AutoSize = true;
            this.rdoCoating.Location = new System.Drawing.Point(318, 21);
            this.rdoCoating.Name = "rdoCoating";
            this.rdoCoating.Size = new System.Drawing.Size(114, 19);
            this.rdoCoating.TabIndex = 2;
            this.rdoCoating.TabStop = true;
            this.rdoCoating.Text = "Película Coating";
            this.rdoCoating.UseVisualStyleBackColor = true;
            this.rdoCoating.CheckedChanged += new System.EventHandler(this.rdoCoating_CheckedChanged);
            // 
            // rdoCast
            // 
            this.rdoCast.AutoSize = true;
            this.rdoCast.Location = new System.Drawing.Point(209, 21);
            this.rdoCast.Name = "rdoCast";
            this.rdoCast.Size = new System.Drawing.Size(96, 19);
            this.rdoCast.TabIndex = 1;
            this.rdoCast.TabStop = true;
            this.rdoCast.Text = "Película Cast";
            this.rdoCast.UseVisualStyleBackColor = true;
            this.rdoCast.CheckedChanged += new System.EventHandler(this.rdoCast_CheckedChanged);
            // 
            // rdoBopp
            // 
            this.rdoBopp.AutoSize = true;
            this.rdoBopp.Location = new System.Drawing.Point(91, 21);
            this.rdoBopp.Name = "rdoBopp";
            this.rdoBopp.Size = new System.Drawing.Size(105, 19);
            this.rdoBopp.TabIndex = 0;
            this.rdoBopp.TabStop = true;
            this.rdoBopp.Text = "Película BOPP";
            this.rdoBopp.UseVisualStyleBackColor = true;
            this.rdoBopp.CheckedChanged += new System.EventHandler(this.rdoBopp_CheckedChanged);
            // 
            // grpGeneralInfo
            // 
            this.grpGeneralInfo.Controls.Add(this.cmbUnits);
            this.grpGeneralInfo.Controls.Add(this.cmbStatus);
            this.grpGeneralInfo.Controls.Add(this.lblStatus);
            this.grpGeneralInfo.Controls.Add(this.txtDescription);
            this.grpGeneralInfo.Controls.Add(this.txtSystemCode);
            this.grpGeneralInfo.Controls.Add(this.lblUnits);
            this.grpGeneralInfo.Controls.Add(this.txtCode);
            this.grpGeneralInfo.Controls.Add(this.txtName);
            this.grpGeneralInfo.Controls.Add(this.lblSystemCode);
            this.grpGeneralInfo.Controls.Add(this.lblCode);
            this.grpGeneralInfo.Controls.Add(this.lblDescription);
            this.grpGeneralInfo.Controls.Add(this.lblName);
            this.grpGeneralInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpGeneralInfo.Location = new System.Drawing.Point(0, 60);
            this.grpGeneralInfo.Name = "grpGeneralInfo";
            this.grpGeneralInfo.Size = new System.Drawing.Size(631, 123);
            this.grpGeneralInfo.TabIndex = 1;
            this.grpGeneralInfo.TabStop = false;
            this.grpGeneralInfo.Text = "Información general";
            // 
            // cmbUnits
            // 
            this.cmbUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cmbUnits.FormattingEnabled = true;
            this.cmbUnits.Location = new System.Drawing.Point(64, 89);
            this.cmbUnits.Name = "cmbUnits";
            this.cmbUnits.Size = new System.Drawing.Size(234, 23);
            this.cmbUnits.TabIndex = 7;
            this.cmbUnits.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbUnits_KeyDown);
            // 
            // cmbStatus
            // 
            this.cmbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(385, 88);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(242, 23);
            this.cmbStatus.TabIndex = 9;
            this.cmbStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbStatus_KeyDown);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(307, 92);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(45, 15);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Estado";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(385, 19);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(242, 64);
            this.txtDescription.TabIndex = 8;
            // 
            // txtSystemCode
            // 
            this.txtSystemCode.Enabled = false;
            this.txtSystemCode.Location = new System.Drawing.Point(64, 65);
            this.txtSystemCode.Name = "txtSystemCode";
            this.txtSystemCode.Size = new System.Drawing.Size(234, 21);
            this.txtSystemCode.TabIndex = 6;
            // 
            // lblUnits
            // 
            this.lblUnits.AutoSize = true;
            this.lblUnits.Location = new System.Drawing.Point(6, 92);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(47, 15);
            this.lblUnits.TabIndex = 3;
            this.lblUnits.Text = "Unidad";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(64, 42);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(234, 21);
            this.txtCode.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(64, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(234, 21);
            this.txtName.TabIndex = 4;
            // 
            // lblSystemCode
            // 
            this.lblSystemCode.AutoSize = true;
            this.lblSystemCode.Location = new System.Drawing.Point(6, 68);
            this.lblSystemCode.Name = "lblSystemCode";
            this.lblSystemCode.Size = new System.Drawing.Size(52, 15);
            this.lblSystemCode.TabIndex = 3;
            this.lblSystemCode.Text = "Sistema";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(6, 45);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(46, 15);
            this.lblCode.TabIndex = 2;
            this.lblCode.Text = "Código";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(307, 22);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(72, 15);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Descripción";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            // 
            // grpbFilm
            // 
            this.grpbFilm.Controls.Add(this.lblMm);
            this.grpbFilm.Controls.Add(this.txtWidth);
            this.grpbFilm.Controls.Add(this.cmbDiameter);
            this.grpbFilm.Controls.Add(this.cmbCore);
            this.grpbFilm.Controls.Add(this.cmbFilm);
            this.grpbFilm.Controls.Add(this.lblWidth);
            this.grpbFilm.Controls.Add(this.lblDiameter);
            this.grpbFilm.Controls.Add(this.lblCore);
            this.grpbFilm.Controls.Add(this.lblBoppFilm);
            this.grpbFilm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbFilm.Location = new System.Drawing.Point(0, 183);
            this.grpbFilm.Name = "grpbFilm";
            this.grpbFilm.Size = new System.Drawing.Size(631, 86);
            this.grpbFilm.TabIndex = 2;
            this.grpbFilm.TabStop = false;
            this.grpbFilm.Text = "Pelicula";
            // 
            // lblMm
            // 
            this.lblMm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMm.AutoSize = true;
            this.lblMm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMm.Location = new System.Drawing.Point(583, 58);
            this.lblMm.Name = "lblMm";
            this.lblMm.Size = new System.Drawing.Size(37, 15);
            this.lblMm.TabIndex = 9;
            this.lblMm.Text = "(mm)";
            // 
            // txtWidth
            // 
            this.txtWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWidth.Location = new System.Drawing.Point(493, 55);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(86, 21);
            this.txtWidth.TabIndex = 8;
            this.txtWidth.TextChanged += new System.EventHandler(this.txtWidth_TextChanged);
            // 
            // cmbDiameter
            // 
            this.cmbDiameter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDiameter.FormattingEnabled = true;
            this.cmbDiameter.Location = new System.Drawing.Point(282, 55);
            this.cmbDiameter.Name = "cmbDiameter";
            this.cmbDiameter.Size = new System.Drawing.Size(147, 23);
            this.cmbDiameter.TabIndex = 7;
            this.cmbDiameter.SelectedIndexChanged += new System.EventHandler(this.cmbDiameter_SelectedIndexChanged);
            this.cmbDiameter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDiameter_KeyDown);
            // 
            // cmbCore
            // 
            this.cmbCore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCore.FormattingEnabled = true;
            this.cmbCore.Location = new System.Drawing.Point(59, 55);
            this.cmbCore.Name = "cmbCore";
            this.cmbCore.Size = new System.Drawing.Size(155, 23);
            this.cmbCore.TabIndex = 6;
            this.cmbCore.SelectedIndexChanged += new System.EventHandler(this.cmbCore_SelectedIndexChanged);
            this.cmbCore.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCore_KeyDown);
            // 
            // cmbFilm
            // 
            this.cmbFilm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFilm.FormattingEnabled = true;
            this.cmbFilm.Location = new System.Drawing.Point(64, 21);
            this.cmbFilm.Name = "cmbFilm";
            this.cmbFilm.Size = new System.Drawing.Size(556, 23);
            this.cmbFilm.TabIndex = 5;
            this.cmbFilm.SelectedIndexChanged += new System.EventHandler(this.cmbFilm_SelectedIndexChanged);
            this.cmbFilm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbFilm_KeyDown);
            // 
            // lblWidth
            // 
            this.lblWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(443, 58);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(41, 15);
            this.lblWidth.TabIndex = 4;
            this.lblWidth.Text = "Ancho";
            // 
            // lblDiameter
            // 
            this.lblDiameter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiameter.AutoSize = true;
            this.lblDiameter.Location = new System.Drawing.Point(220, 58);
            this.lblDiameter.Name = "lblDiameter";
            this.lblDiameter.Size = new System.Drawing.Size(58, 15);
            this.lblDiameter.TabIndex = 2;
            this.lblDiameter.Text = "Diametro";
            // 
            // lblCore
            // 
            this.lblCore.AutoSize = true;
            this.lblCore.Location = new System.Drawing.Point(9, 58);
            this.lblCore.Name = "lblCore";
            this.lblCore.Size = new System.Drawing.Size(33, 15);
            this.lblCore.TabIndex = 1;
            this.lblCore.Text = "Core";
            // 
            // lblBoppFilm
            // 
            this.lblBoppFilm.AutoSize = true;
            this.lblBoppFilm.Location = new System.Drawing.Point(9, 24);
            this.lblBoppFilm.Name = "lblBoppFilm";
            this.lblBoppFilm.Size = new System.Drawing.Size(51, 15);
            this.lblBoppFilm.TabIndex = 0;
            this.lblBoppFilm.Text = "Pelicula";
            // 
            // grpbEmpty
            // 
            this.grpbEmpty.Controls.Add(this.btnExit);
            this.grpbEmpty.Controls.Add(this.btnCancel);
            this.grpbEmpty.Controls.Add(this.btnSave);
            this.grpbEmpty.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbEmpty.Location = new System.Drawing.Point(0, 269);
            this.grpbEmpty.Name = "grpbEmpty";
            this.grpbEmpty.Size = new System.Drawing.Size(631, 43);
            this.grpbEmpty.TabIndex = 14;
            this.grpbEmpty.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnExit.Location = new System.Drawing.Point(602, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 35;
            this.ttpProductFilm.SetToolTip(this.btnExit, "Salir");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.Location = new System.Drawing.Point(577, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCancel.TabIndex = 34;
            this.ttpProductFilm.SetToolTip(this.btnCancel, "Cancelar");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Location = new System.Drawing.Point(551, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(25, 25);
            this.btnSave.TabIndex = 33;
            this.ttpProductFilm.SetToolTip(this.btnSave, "Guardar");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(631, 312);
            this.Controls.Add(this.grpGeneralInfo);
            this.Controls.Add(this.grpbProductType);
            this.Controls.Add(this.grpbFilm);
            this.Controls.Add(this.grpbEmpty);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductsForm";
            this.Text = "Producto (Películas)";
            this.Load += new System.EventHandler(this.frmProductForm_Load);
            this.grpbProductType.ResumeLayout(false);
            this.grpbProductType.PerformLayout();
            this.grpGeneralInfo.ResumeLayout(false);
            this.grpGeneralInfo.PerformLayout();
            this.grpbFilm.ResumeLayout(false);
            this.grpbFilm.PerformLayout();
            this.grpbEmpty.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbProductType;
        private System.Windows.Forms.GroupBox grpGeneralInfo;
        private System.Windows.Forms.RadioButton rdoCoating;
        private System.Windows.Forms.RadioButton rdoCast;
        private System.Windows.Forms.RadioButton rdoBopp;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSystemCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtSystemCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grpbFilm;
        private System.Windows.Forms.GroupBox grpbEmpty;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.Label lblDiameter;
        private System.Windows.Forms.Label lblCore;
        private System.Windows.Forms.Label lblBoppFilm;
        private System.Windows.Forms.ComboBox cmbFilm;
        private System.Windows.Forms.ComboBox cmbCore;
        private System.Windows.Forms.ComboBox cmbUnits;
        private System.Windows.Forms.ComboBox cmbDiameter;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblMm;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.ToolTip ttpProductFilm;
        private System.Windows.Forms.RadioButton rdbNylon;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}