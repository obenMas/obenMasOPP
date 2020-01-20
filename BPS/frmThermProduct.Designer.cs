namespace BPS
{
    partial class frmThermProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThermProduct));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
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
            this.btnExit = new System.Windows.Forms.Button();
            this.grpbThermoforming = new System.Windows.Forms.GroupBox();
            this.txtUnitsPerPackage = new System.Windows.Forms.TextBox();
            this.lblUnitsPerPackage = new System.Windows.Forms.Label();
            this.cmbTherm = new System.Windows.Forms.ComboBox();
            this.lblTherm = new System.Windows.Forms.Label();
            this.grpbEmpty = new System.Windows.Forms.GroupBox();
            this.grpbActions = new System.Windows.Forms.GroupBox();
            this.ttpThermProdcut = new System.Windows.Forms.ToolTip(this.components);
            this.grpGeneralInfo.SuspendLayout();
            this.grpbThermoforming.SuspendLayout();
            this.grpbActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Location = new System.Drawing.Point(4, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(25, 25);
            this.btnSave.TabIndex = 30;
            this.ttpThermProdcut.SetToolTip(this.btnSave, "Guardar Termoformado");
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
            this.ttpThermProdcut.SetToolTip(this.btnCancel, "Cancelar Termoformado");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.grpGeneralInfo.Location = new System.Drawing.Point(-1, 2);
            this.grpGeneralInfo.Name = "grpGeneralInfo";
            this.grpGeneralInfo.Size = new System.Drawing.Size(633, 118);
            this.grpGeneralInfo.TabIndex = 15;
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
            // btnExit
            // 
            this.btnExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnExit.Location = new System.Drawing.Point(54, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 32;
            this.ttpThermProdcut.SetToolTip(this.btnExit, "Salir Termoformado");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpbThermoforming
            // 
            this.grpbThermoforming.Controls.Add(this.txtUnitsPerPackage);
            this.grpbThermoforming.Controls.Add(this.lblUnitsPerPackage);
            this.grpbThermoforming.Controls.Add(this.cmbTherm);
            this.grpbThermoforming.Controls.Add(this.lblTherm);
            this.grpbThermoforming.Location = new System.Drawing.Point(-1, 119);
            this.grpbThermoforming.Name = "grpbThermoforming";
            this.grpbThermoforming.Size = new System.Drawing.Size(633, 47);
            this.grpbThermoforming.TabIndex = 16;
            this.grpbThermoforming.TabStop = false;
            this.grpbThermoforming.Text = "Termoformado";
            // 
            // txtUnitsPerPackage
            // 
            this.txtUnitsPerPackage.Location = new System.Drawing.Point(555, 15);
            this.txtUnitsPerPackage.Name = "txtUnitsPerPackage";
            this.txtUnitsPerPackage.Size = new System.Drawing.Size(71, 21);
            this.txtUnitsPerPackage.TabIndex = 11;
            // 
            // lblUnitsPerPackage
            // 
            this.lblUnitsPerPackage.AutoSize = true;
            this.lblUnitsPerPackage.Location = new System.Drawing.Point(438, 18);
            this.lblUnitsPerPackage.Name = "lblUnitsPerPackage";
            this.lblUnitsPerPackage.Size = new System.Drawing.Size(110, 15);
            this.lblUnitsPerPackage.TabIndex = 10;
            this.lblUnitsPerPackage.Text = "Unidades Por Caja";
            // 
            // cmbTherm
            // 
            this.cmbTherm.FormattingEnabled = true;
            this.cmbTherm.Location = new System.Drawing.Point(103, 15);
            this.cmbTherm.Name = "cmbTherm";
            this.cmbTherm.Size = new System.Drawing.Size(321, 23);
            this.cmbTherm.TabIndex = 5;
            this.cmbTherm.SelectedIndexChanged += new System.EventHandler(this.cmbTherm_SelectedIndexChanged);
            this.cmbTherm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTherm_KeyDown);
            // 
            // lblTherm
            // 
            this.lblTherm.AutoSize = true;
            this.lblTherm.Location = new System.Drawing.Point(9, 20);
            this.lblTherm.Name = "lblTherm";
            this.lblTherm.Size = new System.Drawing.Size(89, 15);
            this.lblTherm.TabIndex = 0;
            this.lblTherm.Text = "Termoformado";
            // 
            // grpbEmpty
            // 
            this.grpbEmpty.Location = new System.Drawing.Point(-1, 163);
            this.grpbEmpty.Name = "grpbEmpty";
            this.grpbEmpty.Size = new System.Drawing.Size(547, 43);
            this.grpbEmpty.TabIndex = 18;
            this.grpbEmpty.TabStop = false;
            // 
            // grpbActions
            // 
            this.grpbActions.Controls.Add(this.btnExit);
            this.grpbActions.Controls.Add(this.btnSave);
            this.grpbActions.Controls.Add(this.btnCancel);
            this.grpbActions.Location = new System.Drawing.Point(549, 163);
            this.grpbActions.Name = "grpbActions";
            this.grpbActions.Size = new System.Drawing.Size(83, 43);
            this.grpbActions.TabIndex = 17;
            this.grpbActions.TabStop = false;
            // 
            // frmThermProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(631, 209);
            this.Controls.Add(this.grpGeneralInfo);
            this.Controls.Add(this.grpbThermoforming);
            this.Controls.Add(this.grpbEmpty);
            this.Controls.Add(this.grpbActions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmThermProduct";
            this.Text = "Producto (Termoformado)";
            this.Load += new System.EventHandler(this.frmThermProduct_Load);
            this.grpGeneralInfo.ResumeLayout(false);
            this.grpGeneralInfo.PerformLayout();
            this.grpbThermoforming.ResumeLayout(false);
            this.grpbThermoforming.PerformLayout();
            this.grpbActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpGeneralInfo;
        private System.Windows.Forms.ComboBox cmbUnits;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtSystemCode;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSystemCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpbThermoforming;
        private System.Windows.Forms.ComboBox cmbTherm;
        private System.Windows.Forms.Label lblTherm;
        private System.Windows.Forms.GroupBox grpbEmpty;
        private System.Windows.Forms.GroupBox grpbActions;
        private System.Windows.Forms.TextBox txtUnitsPerPackage;
        private System.Windows.Forms.Label lblUnitsPerPackage;
        private System.Windows.Forms.ToolTip ttpThermProdcut;
    }
}