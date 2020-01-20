namespace BPS
{
    partial class frmThermoformingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThermoformingForm));
            this.grpGeneralInfo = new System.Windows.Forms.GroupBox();
            this.chkIsSpecial = new System.Windows.Forms.CheckBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.cmbOunce = new System.Windows.Forms.ComboBox();
            this.lblOunce = new System.Windows.Forms.Label();
            this.txtGrams = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblGrams = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpbActions = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpbEmpty = new System.Windows.Forms.GroupBox();
            this.ttpThermoformingForm = new System.Windows.Forms.ToolTip(this.components);
            this.grpGeneralInfo.SuspendLayout();
            this.grpbActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGeneralInfo
            // 
            this.grpGeneralInfo.Controls.Add(this.chkIsSpecial);
            this.grpGeneralInfo.Controls.Add(this.cmbColor);
            this.grpGeneralInfo.Controls.Add(this.cmbOunce);
            this.grpGeneralInfo.Controls.Add(this.lblOunce);
            this.grpGeneralInfo.Controls.Add(this.txtGrams);
            this.grpGeneralInfo.Controls.Add(this.lblColor);
            this.grpGeneralInfo.Controls.Add(this.txtCode);
            this.grpGeneralInfo.Controls.Add(this.txtName);
            this.grpGeneralInfo.Controls.Add(this.lblGrams);
            this.grpGeneralInfo.Controls.Add(this.lblCode);
            this.grpGeneralInfo.Controls.Add(this.lblName);
            this.grpGeneralInfo.Location = new System.Drawing.Point(12, 10);
            this.grpGeneralInfo.Name = "grpGeneralInfo";
            this.grpGeneralInfo.Size = new System.Drawing.Size(470, 114);
            this.grpGeneralInfo.TabIndex = 2;
            this.grpGeneralInfo.TabStop = false;
            this.grpGeneralInfo.Text = "Información general";
            // 
            // chkIsSpecial
            // 
            this.chkIsSpecial.AutoSize = true;
            this.chkIsSpecial.Location = new System.Drawing.Point(377, 86);
            this.chkIsSpecial.Name = "chkIsSpecial";
            this.chkIsSpecial.Size = new System.Drawing.Size(80, 17);
            this.chkIsSpecial.TabIndex = 10;
            this.chkIsSpecial.Text = "Es especial";
            this.chkIsSpecial.UseVisualStyleBackColor = true;
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(59, 20);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(165, 21);
            this.cmbColor.TabIndex = 7;
            this.cmbColor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbColor_KeyDown);
            // 
            // cmbOunce
            // 
            this.cmbOunce.FormattingEnabled = true;
            this.cmbOunce.Location = new System.Drawing.Point(288, 19);
            this.cmbOunce.Name = "cmbOunce";
            this.cmbOunce.Size = new System.Drawing.Size(169, 21);
            this.cmbOunce.TabIndex = 9;
            this.cmbOunce.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbOunce_KeyDown);
            // 
            // lblOunce
            // 
            this.lblOunce.AutoSize = true;
            this.lblOunce.Location = new System.Drawing.Point(246, 23);
            this.lblOunce.Name = "lblOunce";
            this.lblOunce.Size = new System.Drawing.Size(32, 13);
            this.lblOunce.TabIndex = 8;
            this.lblOunce.Text = "Onza";
            // 
            // txtGrams
            // 
            this.txtGrams.Location = new System.Drawing.Point(284, 84);
            this.txtGrams.Name = "txtGrams";
            this.txtGrams.Size = new System.Drawing.Size(69, 20);
            this.txtGrams.TabIndex = 6;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(18, 23);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 3;
            this.lblColor.Text = "Color";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(59, 84);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(104, 20);
            this.txtCode.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(59, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(399, 20);
            this.txtName.TabIndex = 4;
            // 
            // lblGrams
            // 
            this.lblGrams.AutoSize = true;
            this.lblGrams.Location = new System.Drawing.Point(178, 87);
            this.lblGrams.Name = "lblGrams";
            this.lblGrams.Size = new System.Drawing.Size(96, 13);
            this.lblGrams.TabIndex = 3;
            this.lblGrams.Text = "Gramos por unidad";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(9, 87);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(40, 13);
            this.lblCode.TabIndex = 2;
            this.lblCode.Text = "Código";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(5, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            // 
            // grpbActions
            // 
            this.grpbActions.Controls.Add(this.btnExit);
            this.grpbActions.Controls.Add(this.btnSave);
            this.grpbActions.Controls.Add(this.btnCancel);
            this.grpbActions.Location = new System.Drawing.Point(399, 126);
            this.grpbActions.Name = "grpbActions";
            this.grpbActions.Size = new System.Drawing.Size(83, 43);
            this.grpbActions.TabIndex = 18;
            this.grpbActions.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnExit.Location = new System.Drawing.Point(54, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 32;
            this.ttpThermoformingForm.SetToolTip(this.btnExit, "Salir Termoformado");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Location = new System.Drawing.Point(4, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(25, 25);
            this.btnSave.TabIndex = 30;
            this.ttpThermoformingForm.SetToolTip(this.btnSave, "Guardar Termoformado");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.Location = new System.Drawing.Point(29, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCancel.TabIndex = 31;
            this.ttpThermoformingForm.SetToolTip(this.btnCancel, "Cancelar Termoformado");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpbEmpty
            // 
            this.grpbEmpty.Location = new System.Drawing.Point(11, 126);
            this.grpbEmpty.Name = "grpbEmpty";
            this.grpbEmpty.Size = new System.Drawing.Size(386, 43);
            this.grpbEmpty.TabIndex = 19;
            this.grpbEmpty.TabStop = false;
            // 
            // frmThermoformingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(494, 178);
            this.Controls.Add(this.grpbEmpty);
            this.Controls.Add(this.grpbActions);
            this.Controls.Add(this.grpGeneralInfo);
            this.Name = "frmThermoformingForm";
            this.Text = "Termoformado";
            this.Load += new System.EventHandler(this.frmThermoformingForm_Load);
            this.grpGeneralInfo.ResumeLayout(false);
            this.grpGeneralInfo.PerformLayout();
            this.grpbActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGeneralInfo;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.ComboBox cmbOunce;
        private System.Windows.Forms.Label lblOunce;
        private System.Windows.Forms.TextBox txtGrams;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblGrams;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grpbActions;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpbEmpty;
        private System.Windows.Forms.CheckBox chkIsSpecial;
        private System.Windows.Forms.ToolTip ttpThermoformingForm;
    }
}