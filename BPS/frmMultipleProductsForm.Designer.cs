namespace BPS
{
    partial class frmMultipleProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMultipleProductsForm));
            this.grpbProductType = new System.Windows.Forms.GroupBox();
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
            this.lstbWidth = new System.Windows.Forms.ListBox();
            this.lstbDiameter = new System.Windows.Forms.ListBox();
            this.lstbCore = new System.Windows.Forms.ListBox();
            this.lblMm = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.cmbFilm = new System.Windows.Forms.ComboBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblDiameter = new System.Windows.Forms.Label();
            this.lblCore = new System.Windows.Forms.Label();
            this.lblBoppFilm = new System.Windows.Forms.Label();
            this.grpbEmpty = new System.Windows.Forms.GroupBox();
            this.grpbActions = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ttpProduct = new System.Windows.Forms.ToolTip(this.components);
            this.grpbProductType.SuspendLayout();
            this.grpGeneralInfo.SuspendLayout();
            this.grpbFilm.SuspendLayout();
            this.grpbActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbProductType
            // 
            this.grpbProductType.Controls.Add(this.rdoCoating);
            this.grpbProductType.Controls.Add(this.rdoCast);
            this.grpbProductType.Controls.Add(this.rdoBopp);
            this.grpbProductType.Location = new System.Drawing.Point(3, 1);
            this.grpbProductType.Name = "grpbProductType";
            this.grpbProductType.Size = new System.Drawing.Size(633, 60);
            this.grpbProductType.TabIndex = 0;
            this.grpbProductType.TabStop = false;
            this.grpbProductType.Text = "Tipo de producto";
            // 
            // rdoCoating
            // 
            this.rdoCoating.AutoSize = true;
            this.rdoCoating.Location = new System.Drawing.Point(373, 21);
            this.rdoCoating.Name = "rdoCoating";
            this.rdoCoating.Size = new System.Drawing.Size(103, 17);
            this.rdoCoating.TabIndex = 2;
            this.rdoCoating.TabStop = true;
            this.rdoCoating.Text = "Película Coating";
            this.rdoCoating.UseVisualStyleBackColor = true;
            this.rdoCoating.CheckedChanged += new System.EventHandler(this.rdoCoating_CheckedChanged);
            // 
            // rdoCast
            // 
            this.rdoCast.AutoSize = true;
            this.rdoCast.Location = new System.Drawing.Point(264, 21);
            this.rdoCast.Name = "rdoCast";
            this.rdoCast.Size = new System.Drawing.Size(88, 17);
            this.rdoCast.TabIndex = 1;
            this.rdoCast.TabStop = true;
            this.rdoCast.Text = "Película Cast";
            this.rdoCast.UseVisualStyleBackColor = true;
            this.rdoCast.CheckedChanged += new System.EventHandler(this.rdoCast_CheckedChanged);
            // 
            // rdoBopp
            // 
            this.rdoBopp.AutoSize = true;
            this.rdoBopp.Location = new System.Drawing.Point(146, 21);
            this.rdoBopp.Name = "rdoBopp";
            this.rdoBopp.Size = new System.Drawing.Size(96, 17);
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
            this.grpGeneralInfo.Location = new System.Drawing.Point(3, 60);
            this.grpGeneralInfo.Name = "grpGeneralInfo";
            this.grpGeneralInfo.Size = new System.Drawing.Size(633, 118);
            this.grpGeneralInfo.TabIndex = 1;
            this.grpGeneralInfo.TabStop = false;
            this.grpGeneralInfo.Text = "Información general";
            // 
            // cmbUnits
            // 
            this.cmbUnits.FormattingEnabled = true;
            this.cmbUnits.Location = new System.Drawing.Point(64, 89);
            this.cmbUnits.Name = "cmbUnits";
            this.cmbUnits.Size = new System.Drawing.Size(234, 23);
            this.cmbUnits.TabIndex = 7;
            this.cmbUnits.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbUnits_KeyDown);
            // 
            // cmbStatus
            // 
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
            this.grpbFilm.Controls.Add(this.lstbWidth);
            this.grpbFilm.Controls.Add(this.lstbDiameter);
            this.grpbFilm.Controls.Add(this.lstbCore);
            this.grpbFilm.Controls.Add(this.lblMm);
            this.grpbFilm.Controls.Add(this.txtWidth);
            this.grpbFilm.Controls.Add(this.cmbFilm);
            this.grpbFilm.Controls.Add(this.lblWidth);
            this.grpbFilm.Controls.Add(this.lblDiameter);
            this.grpbFilm.Controls.Add(this.lblCore);
            this.grpbFilm.Controls.Add(this.lblBoppFilm);
            this.grpbFilm.Location = new System.Drawing.Point(3, 177);
            this.grpbFilm.Name = "grpbFilm";
            this.grpbFilm.Size = new System.Drawing.Size(633, 157);
            this.grpbFilm.TabIndex = 2;
            this.grpbFilm.TabStop = false;
            this.grpbFilm.Text = "Pelicula";
            // 
            // lstbWidth
            // 
            this.lstbWidth.FormattingEnabled = true;
            this.lstbWidth.ItemHeight = 15;
            this.lstbWidth.Location = new System.Drawing.Point(497, 72);
            this.lstbWidth.Name = "lstbWidth";
            this.lstbWidth.Size = new System.Drawing.Size(88, 64);
            this.lstbWidth.TabIndex = 10;
            // 
            // lstbDiameter
            // 
            this.lstbDiameter.FormattingEnabled = true;
            this.lstbDiameter.ItemHeight = 15;
            this.lstbDiameter.Location = new System.Drawing.Point(297, 52);
            this.lstbDiameter.Name = "lstbDiameter";
            this.lstbDiameter.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstbDiameter.Size = new System.Drawing.Size(136, 94);
            this.lstbDiameter.TabIndex = 10;
            // 
            // lstbCore
            // 
            this.lstbCore.FormattingEnabled = true;
            this.lstbCore.ItemHeight = 15;
            this.lstbCore.Location = new System.Drawing.Point(58, 53);
            this.lstbCore.Name = "lstbCore";
            this.lstbCore.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstbCore.Size = new System.Drawing.Size(136, 94);
            this.lstbCore.TabIndex = 10;
            // 
            // lblMm
            // 
            this.lblMm.AutoSize = true;
            this.lblMm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMm.Location = new System.Drawing.Point(585, 48);
            this.lblMm.Name = "lblMm";
            this.lblMm.Size = new System.Drawing.Size(37, 15);
            this.lblMm.TabIndex = 9;
            this.lblMm.Text = "(mm)";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(497, 45);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(88, 21);
            this.txtWidth.TabIndex = 8;
            this.txtWidth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWidth_KeyDown);
            // 
            // cmbFilm
            // 
            this.cmbFilm.FormattingEnabled = true;
            this.cmbFilm.Location = new System.Drawing.Point(64, 17);
            this.cmbFilm.Name = "cmbFilm";
            this.cmbFilm.Size = new System.Drawing.Size(561, 23);
            this.cmbFilm.TabIndex = 5;
            this.cmbFilm.SelectedIndexChanged += new System.EventHandler(this.cmbFilm_SelectedIndexChanged);
            this.cmbFilm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbFilm_KeyDown);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(450, 48);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(41, 15);
            this.lblWidth.TabIndex = 4;
            this.lblWidth.Text = "Ancho";
            // 
            // lblDiameter
            // 
            this.lblDiameter.AutoSize = true;
            this.lblDiameter.Location = new System.Drawing.Point(223, 48);
            this.lblDiameter.Name = "lblDiameter";
            this.lblDiameter.Size = new System.Drawing.Size(58, 15);
            this.lblDiameter.TabIndex = 2;
            this.lblDiameter.Text = "Diametro";
            // 
            // lblCore
            // 
            this.lblCore.AutoSize = true;
            this.lblCore.Location = new System.Drawing.Point(9, 48);
            this.lblCore.Name = "lblCore";
            this.lblCore.Size = new System.Drawing.Size(33, 15);
            this.lblCore.TabIndex = 1;
            this.lblCore.Text = "Core";
            // 
            // lblBoppFilm
            // 
            this.lblBoppFilm.AutoSize = true;
            this.lblBoppFilm.Location = new System.Drawing.Point(9, 20);
            this.lblBoppFilm.Name = "lblBoppFilm";
            this.lblBoppFilm.Size = new System.Drawing.Size(51, 15);
            this.lblBoppFilm.TabIndex = 0;
            this.lblBoppFilm.Text = "Pelicula";
            // 
            // grpbEmpty
            // 
            this.grpbEmpty.Location = new System.Drawing.Point(3, 329);
            this.grpbEmpty.Name = "grpbEmpty";
            this.grpbEmpty.Size = new System.Drawing.Size(547, 43);
            this.grpbEmpty.TabIndex = 14;
            this.grpbEmpty.TabStop = false;
            // 
            // grpbActions
            // 
            this.grpbActions.Controls.Add(this.btnExit);
            this.grpbActions.Controls.Add(this.btnSave);
            this.grpbActions.Controls.Add(this.btnCancel);
            this.grpbActions.Location = new System.Drawing.Point(553, 329);
            this.grpbActions.Name = "grpbActions";
            this.grpbActions.Size = new System.Drawing.Size(83, 43);
            this.grpbActions.TabIndex = 13;
            this.grpbActions.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnExit.Location = new System.Drawing.Point(54, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 32;
            this.ttpProduct.SetToolTip(this.btnExit, "Salir Producto");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Location = new System.Drawing.Point(4, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(25, 25);
            this.btnSave.TabIndex = 30;
            this.ttpProduct.SetToolTip(this.btnSave, "Guardar Producto");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.Location = new System.Drawing.Point(29, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCancel.TabIndex = 31;
            this.ttpProduct.SetToolTip(this.btnCancel, "Cancelar Producto");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmMultipleProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(641, 373);
            this.Controls.Add(this.grpbProductType);
            this.Controls.Add(this.grpGeneralInfo);
            this.Controls.Add(this.grpbFilm);
            this.Controls.Add(this.grpbEmpty);
            this.Controls.Add(this.grpbActions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMultipleProductsForm";
            this.Text = "Producto (Peículas)";
            this.ttpProduct.SetToolTip(this, "Guardar");
            this.Load += new System.EventHandler(this.frmProductForm_Load);
            this.grpbProductType.ResumeLayout(false);
            this.grpbProductType.PerformLayout();
            this.grpGeneralInfo.ResumeLayout(false);
            this.grpGeneralInfo.PerformLayout();
            this.grpbFilm.ResumeLayout(false);
            this.grpbFilm.PerformLayout();
            this.grpbActions.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox grpbActions;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.Label lblDiameter;
        private System.Windows.Forms.Label lblCore;
        private System.Windows.Forms.Label lblBoppFilm;
        private System.Windows.Forms.ComboBox cmbFilm;
        private System.Windows.Forms.ComboBox cmbUnits;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblMm;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lstbCore;
        private System.Windows.Forms.ListBox lstbWidth;
        private System.Windows.Forms.ListBox lstbDiameter;
        private System.Windows.Forms.ToolTip ttpProduct;
    }
}