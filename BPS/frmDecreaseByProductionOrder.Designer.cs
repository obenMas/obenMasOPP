namespace BPS
{
    partial class frmDecreaseByProductionOrder
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDecreaseByProductionOrder));
            this.lblOrderProduction = new System.Windows.Forms.Label();
            this.txtOrderProduction = new System.Windows.Forms.Label();
            this.grpbDetail = new System.Windows.Forms.GroupBox();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.clmDecreaseMPRawMaterialCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDecreaseMPRawMaterialType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDecreaseMPRawMaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDecreaseMPRawMaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDecreaseMPRawMaterialKg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDecreaseMPRawMaterialDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbAdd = new System.Windows.Forms.GroupBox();
            this.dgvAdd = new System.Windows.Forms.DataGridView();
            this.clmRawMaterialDecreaseCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialDecreaseRMName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialDecreaseRMType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialDecreaseRMCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialDecreaseRMCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialDecreaseKg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialDecreaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbActions = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpbEmpty = new System.Windows.Forms.GroupBox();
            this.ttpWasterByExtruction = new System.Windows.Forms.ToolTip(this.components);
            this.grpbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.grpbAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdd)).BeginInit();
            this.grpbActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOrderProduction
            // 
            this.lblOrderProduction.AutoSize = true;
            this.lblOrderProduction.Location = new System.Drawing.Point(3, 23);
            this.lblOrderProduction.Name = "lblOrderProduction";
            this.lblOrderProduction.Size = new System.Drawing.Size(41, 15);
            this.lblOrderProduction.TabIndex = 0;
            this.lblOrderProduction.Text = "Orden";
            // 
            // txtOrderProduction
            // 
            this.txtOrderProduction.BackColor = System.Drawing.SystemColors.Window;
            this.txtOrderProduction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtOrderProduction.Location = new System.Drawing.Point(55, 21);
            this.txtOrderProduction.Name = "txtOrderProduction";
            this.txtOrderProduction.Size = new System.Drawing.Size(117, 21);
            this.txtOrderProduction.TabIndex = 1;
            this.txtOrderProduction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpbDetail
            // 
            this.grpbDetail.Controls.Add(this.dgvDetail);
            this.grpbDetail.Location = new System.Drawing.Point(3, 55);
            this.grpbDetail.Name = "grpbDetail";
            this.grpbDetail.Size = new System.Drawing.Size(649, 175);
            this.grpbDetail.TabIndex = 2;
            this.grpbDetail.TabStop = false;
            this.grpbDetail.Text = "Detalle";
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            this.dgvDetail.AllowUserToOrderColumns = true;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmDecreaseMPRawMaterialCodsec,
            this.clmDecreaseMPRawMaterialType,
            this.clmDecreaseMPRawMaterialName,
            this.clmDecreaseMPRawMaterialCode,
            this.clmDecreaseMPRawMaterialKg,
            this.clmDecreaseMPRawMaterialDate});
            this.dgvDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDetail.Location = new System.Drawing.Point(3, 17);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.Size = new System.Drawing.Size(643, 150);
            this.dgvDetail.TabIndex = 0;
            // 
            // clmDecreaseMPRawMaterialCodsec
            // 
            this.clmDecreaseMPRawMaterialCodsec.HeaderText = "Codsec";
            this.clmDecreaseMPRawMaterialCodsec.Name = "clmDecreaseMPRawMaterialCodsec";
            this.clmDecreaseMPRawMaterialCodsec.ReadOnly = true;
            this.clmDecreaseMPRawMaterialCodsec.Visible = false;
            // 
            // clmDecreaseMPRawMaterialType
            // 
            this.clmDecreaseMPRawMaterialType.HeaderText = "Tipo";
            this.clmDecreaseMPRawMaterialType.Name = "clmDecreaseMPRawMaterialType";
            this.clmDecreaseMPRawMaterialType.ReadOnly = true;
            this.clmDecreaseMPRawMaterialType.Width = 125;
            // 
            // clmDecreaseMPRawMaterialName
            // 
            this.clmDecreaseMPRawMaterialName.HeaderText = "Nombre";
            this.clmDecreaseMPRawMaterialName.Name = "clmDecreaseMPRawMaterialName";
            this.clmDecreaseMPRawMaterialName.ReadOnly = true;
            this.clmDecreaseMPRawMaterialName.Width = 125;
            // 
            // clmDecreaseMPRawMaterialCode
            // 
            this.clmDecreaseMPRawMaterialCode.HeaderText = "Código";
            this.clmDecreaseMPRawMaterialCode.Name = "clmDecreaseMPRawMaterialCode";
            this.clmDecreaseMPRawMaterialCode.ReadOnly = true;
            this.clmDecreaseMPRawMaterialCode.Width = 125;
            // 
            // clmDecreaseMPRawMaterialKg
            // 
            this.clmDecreaseMPRawMaterialKg.HeaderText = "Kilos";
            this.clmDecreaseMPRawMaterialKg.Name = "clmDecreaseMPRawMaterialKg";
            this.clmDecreaseMPRawMaterialKg.ReadOnly = true;
            this.clmDecreaseMPRawMaterialKg.Width = 125;
            // 
            // clmDecreaseMPRawMaterialDate
            // 
            this.clmDecreaseMPRawMaterialDate.HeaderText = "Fecha";
            this.clmDecreaseMPRawMaterialDate.Name = "clmDecreaseMPRawMaterialDate";
            this.clmDecreaseMPRawMaterialDate.ReadOnly = true;
            // 
            // grpbAdd
            // 
            this.grpbAdd.Controls.Add(this.dgvAdd);
            this.grpbAdd.Location = new System.Drawing.Point(6, 236);
            this.grpbAdd.Name = "grpbAdd";
            this.grpbAdd.Size = new System.Drawing.Size(649, 163);
            this.grpbAdd.TabIndex = 3;
            this.grpbAdd.TabStop = false;
            this.grpbAdd.Text = "Agregar";
            // 
            // dgvAdd
            // 
            this.dgvAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmRawMaterialDecreaseCodsec,
            this.clmRawMaterialDecreaseRMName,
            this.clmRawMaterialDecreaseRMType,
            this.clmRawMaterialDecreaseRMCode,
            this.clmRawMaterialDecreaseRMCodsec,
            this.clmRawMaterialDecreaseKg,
            this.clmRawMaterialDecreaseDate});
            this.dgvAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvAdd.Location = new System.Drawing.Point(3, 17);
            this.dgvAdd.Name = "dgvAdd";
            this.dgvAdd.Size = new System.Drawing.Size(643, 137);
            this.dgvAdd.TabIndex = 0;
            // 
            // clmRawMaterialDecreaseCodsec
            // 
            this.clmRawMaterialDecreaseCodsec.HeaderText = "Codsec";
            this.clmRawMaterialDecreaseCodsec.Name = "clmRawMaterialDecreaseCodsec";
            this.clmRawMaterialDecreaseCodsec.ReadOnly = true;
            this.clmRawMaterialDecreaseCodsec.Visible = false;
            // 
            // clmRawMaterialDecreaseRMName
            // 
            this.clmRawMaterialDecreaseRMName.HeaderText = "Nombre";
            this.clmRawMaterialDecreaseRMName.Name = "clmRawMaterialDecreaseRMName";
            this.clmRawMaterialDecreaseRMName.Width = 125;
            // 
            // clmRawMaterialDecreaseRMType
            // 
            this.clmRawMaterialDecreaseRMType.HeaderText = "Tipo";
            this.clmRawMaterialDecreaseRMType.Name = "clmRawMaterialDecreaseRMType";
            this.clmRawMaterialDecreaseRMType.Width = 125;
            // 
            // clmRawMaterialDecreaseRMCode
            // 
            this.clmRawMaterialDecreaseRMCode.HeaderText = "Código";
            this.clmRawMaterialDecreaseRMCode.Name = "clmRawMaterialDecreaseRMCode";
            this.clmRawMaterialDecreaseRMCode.Width = 125;
            // 
            // clmRawMaterialDecreaseRMCodsec
            // 
            this.clmRawMaterialDecreaseRMCodsec.HeaderText = "RMCodsec";
            this.clmRawMaterialDecreaseRMCodsec.Name = "clmRawMaterialDecreaseRMCodsec";
            this.clmRawMaterialDecreaseRMCodsec.ReadOnly = true;
            this.clmRawMaterialDecreaseRMCodsec.Visible = false;
            this.clmRawMaterialDecreaseRMCodsec.Width = 5;
            // 
            // clmRawMaterialDecreaseKg
            // 
            this.clmRawMaterialDecreaseKg.HeaderText = "Kilos";
            this.clmRawMaterialDecreaseKg.Name = "clmRawMaterialDecreaseKg";
            this.clmRawMaterialDecreaseKg.Width = 125;
            // 
            // clmRawMaterialDecreaseDate
            // 
            this.clmRawMaterialDecreaseDate.HeaderText = "Fecha";
            this.clmRawMaterialDecreaseDate.Name = "clmRawMaterialDecreaseDate";
            // 
            // grpbActions
            // 
            this.grpbActions.Controls.Add(this.btnExit);
            this.grpbActions.Controls.Add(this.btnSave);
            this.grpbActions.Controls.Add(this.btnCancel);
            this.grpbActions.Location = new System.Drawing.Point(572, 398);
            this.grpbActions.Name = "grpbActions";
            this.grpbActions.Size = new System.Drawing.Size(83, 43);
            this.grpbActions.TabIndex = 16;
            this.grpbActions.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnExit.Location = new System.Drawing.Point(54, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 32;
            this.ttpWasterByExtruction.SetToolTip(this.btnExit, "Salir Materia Prima");
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
            this.ttpWasterByExtruction.SetToolTip(this.btnSave, "Guardar Materia Prima ");
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
            this.ttpWasterByExtruction.SetToolTip(this.btnCancel, "Cancelar Materia Prima");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpbEmpty
            // 
            this.grpbEmpty.Location = new System.Drawing.Point(6, 398);
            this.grpbEmpty.Name = "grpbEmpty";
            this.grpbEmpty.Size = new System.Drawing.Size(564, 43);
            this.grpbEmpty.TabIndex = 17;
            this.grpbEmpty.TabStop = false;
            // 
            // frmDecreaseByProductionOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(658, 449);
            this.Controls.Add(this.grpbEmpty);
            this.Controls.Add(this.grpbActions);
            this.Controls.Add(this.grpbAdd);
            this.Controls.Add(this.grpbDetail);
            this.Controls.Add(this.txtOrderProduction);
            this.Controls.Add(this.lblOrderProduction);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDecreaseByProductionOrder";
            this.Text = "Desperdicios de Materia Prima Por Orden de Extrusión";
            this.grpbDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.grpbAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdd)).EndInit();
            this.grpbActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderProduction;
        private System.Windows.Forms.Label txtOrderProduction;
        private System.Windows.Forms.GroupBox grpbDetail;
        private System.Windows.Forms.GroupBox grpbAdd;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.DataGridView dgvAdd;
        private System.Windows.Forms.GroupBox grpbActions;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpbEmpty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDecreaseMPRawMaterialCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDecreaseMPRawMaterialType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDecreaseMPRawMaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDecreaseMPRawMaterialCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDecreaseMPRawMaterialKg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDecreaseMPRawMaterialDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialDecreaseCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialDecreaseRMName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialDecreaseRMType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialDecreaseRMCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialDecreaseRMCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialDecreaseKg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialDecreaseDate;
        private System.Windows.Forms.ToolTip ttpWasterByExtruction;
    }
}