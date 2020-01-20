namespace BPS
{
    partial class frmRawMaterialDecreaseByOrderProduction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRawMaterialDecreaseByOrderProduction));
            this.txtFilmProduction = new System.Windows.Forms.Label();
            this.lblFilmProduction = new System.Windows.Forms.Label();
            this.grpbEmpty = new System.Windows.Forms.GroupBox();
            this.grpbActions = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpbAdd = new System.Windows.Forms.GroupBox();
            this.cmbAddOrderLote = new System.Windows.Forms.ComboBox();
            this.lblAddOrderLote = new System.Windows.Forms.Label();
            this.dgvAdd = new System.Windows.Forms.DataGridView();
            this.clmRawMaterialDecreaseRMCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialDecreaseRMEntityProvider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialDecreaseRMName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialDecreaseRMType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialDecreaseRMCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialDecreaseKg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialDecreaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbDetail = new System.Windows.Forms.GroupBox();
            this.cmbOrderLote = new System.Windows.Forms.ComboBox();
            this.lblOrderLote = new System.Windows.Forms.Label();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.clmDecreaseMPRawMaterialCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDecreaseMPRawMaterialType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDecreaseMPRawMaterialEntityProvider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDecreaseMPRawMaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDecreaseMPRawMaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDecreaseMPRawMaterialKg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtOrderProduction = new System.Windows.Forms.Label();
            this.lblOrderProduction = new System.Windows.Forms.Label();
            this.ttpRawMaterial = new System.Windows.Forms.ToolTip(this.components);
            this.grpbActions.SuspendLayout();
            this.grpbAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdd)).BeginInit();
            this.grpbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilmProduction
            // 
            this.txtFilmProduction.BackColor = System.Drawing.SystemColors.Window;
            this.txtFilmProduction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtFilmProduction.Location = new System.Drawing.Point(73, 12);
            this.txtFilmProduction.Name = "txtFilmProduction";
            this.txtFilmProduction.Size = new System.Drawing.Size(130, 24);
            this.txtFilmProduction.TabIndex = 33;
            this.txtFilmProduction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFilmProduction
            // 
            this.lblFilmProduction.AutoSize = true;
            this.lblFilmProduction.Location = new System.Drawing.Point(10, 17);
            this.lblFilmProduction.Name = "lblFilmProduction";
            this.lblFilmProduction.Size = new System.Drawing.Size(51, 15);
            this.lblFilmProduction.TabIndex = 32;
            this.lblFilmProduction.Text = "Película";
            // 
            // grpbEmpty
            // 
            this.grpbEmpty.Location = new System.Drawing.Point(6, 574);
            this.grpbEmpty.Name = "grpbEmpty";
            this.grpbEmpty.Size = new System.Drawing.Size(774, 50);
            this.grpbEmpty.TabIndex = 31;
            this.grpbEmpty.TabStop = false;
            // 
            // grpbActions
            // 
            this.grpbActions.Controls.Add(this.btnExit);
            this.grpbActions.Controls.Add(this.btnSave);
            this.grpbActions.Controls.Add(this.btnCancel);
            this.grpbActions.Location = new System.Drawing.Point(786, 574);
            this.grpbActions.Name = "grpbActions";
            this.grpbActions.Size = new System.Drawing.Size(97, 50);
            this.grpbActions.TabIndex = 30;
            this.grpbActions.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnExit.Location = new System.Drawing.Point(63, 14);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(29, 29);
            this.btnExit.TabIndex = 32;
            this.ttpRawMaterial.SetToolTip(this.btnExit, "Salir");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Location = new System.Drawing.Point(6, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(29, 29);
            this.btnSave.TabIndex = 30;
            this.ttpRawMaterial.SetToolTip(this.btnSave, "Guardar");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.Location = new System.Drawing.Point(34, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(29, 29);
            this.btnCancel.TabIndex = 31;
            this.ttpRawMaterial.SetToolTip(this.btnCancel, "Cancelar");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpbAdd
            // 
            this.grpbAdd.Controls.Add(this.cmbAddOrderLote);
            this.grpbAdd.Controls.Add(this.lblAddOrderLote);
            this.grpbAdd.Controls.Add(this.dgvAdd);
            this.grpbAdd.Location = new System.Drawing.Point(3, 324);
            this.grpbAdd.Name = "grpbAdd";
            this.grpbAdd.Size = new System.Drawing.Size(883, 244);
            this.grpbAdd.TabIndex = 29;
            this.grpbAdd.TabStop = false;
            this.grpbAdd.Text = "Agregar";
            // 
            // cmbAddOrderLote
            // 
            this.cmbAddOrderLote.FormattingEnabled = true;
            this.cmbAddOrderLote.Location = new System.Drawing.Point(47, 33);
            this.cmbAddOrderLote.Name = "cmbAddOrderLote";
            this.cmbAddOrderLote.Size = new System.Drawing.Size(130, 23);
            this.cmbAddOrderLote.TabIndex = 27;
            // 
            // lblAddOrderLote
            // 
            this.lblAddOrderLote.AutoSize = true;
            this.lblAddOrderLote.Location = new System.Drawing.Point(10, 38);
            this.lblAddOrderLote.Name = "lblAddOrderLote";
            this.lblAddOrderLote.Size = new System.Drawing.Size(31, 15);
            this.lblAddOrderLote.TabIndex = 26;
            this.lblAddOrderLote.Text = "Lote";
            // 
            // dgvAdd
            // 
            this.dgvAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmRawMaterialDecreaseRMCodsec,
            this.clmRawMaterialDecreaseRMEntityProvider,
            this.clmRawMaterialDecreaseRMName,
            this.clmRawMaterialDecreaseRMType,
            this.clmRawMaterialDecreaseRMCode,
            this.clmRawMaterialDecreaseKg,
            this.clmRawMaterialDecreaseDate});
            this.dgvAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAdd.Location = new System.Drawing.Point(3, 83);
            this.dgvAdd.Name = "dgvAdd";
            this.dgvAdd.Size = new System.Drawing.Size(877, 158);
            this.dgvAdd.TabIndex = 0;
            // 
            // clmRawMaterialDecreaseRMCodsec
            // 
            this.clmRawMaterialDecreaseRMCodsec.HeaderText = "RMCodsec";
            this.clmRawMaterialDecreaseRMCodsec.Name = "clmRawMaterialDecreaseRMCodsec";
            this.clmRawMaterialDecreaseRMCodsec.ReadOnly = true;
            this.clmRawMaterialDecreaseRMCodsec.Visible = false;
            this.clmRawMaterialDecreaseRMCodsec.Width = 5;
            // 
            // clmRawMaterialDecreaseRMEntityProvider
            // 
            this.clmRawMaterialDecreaseRMEntityProvider.HeaderText = "Proveedor";
            this.clmRawMaterialDecreaseRMEntityProvider.Name = "clmRawMaterialDecreaseRMEntityProvider";
            this.clmRawMaterialDecreaseRMEntityProvider.Width = 150;
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
            this.clmRawMaterialDecreaseDate.Width = 180;
            // 
            // grpbDetail
            // 
            this.grpbDetail.Controls.Add(this.cmbOrderLote);
            this.grpbDetail.Controls.Add(this.lblOrderLote);
            this.grpbDetail.Controls.Add(this.dgvDetail);
            this.grpbDetail.Location = new System.Drawing.Point(3, 50);
            this.grpbDetail.Name = "grpbDetail";
            this.grpbDetail.Size = new System.Drawing.Size(886, 244);
            this.grpbDetail.TabIndex = 28;
            this.grpbDetail.TabStop = false;
            this.grpbDetail.Text = "Detalle";
            // 
            // cmbOrderLote
            // 
            this.cmbOrderLote.FormattingEnabled = true;
            this.cmbOrderLote.Location = new System.Drawing.Point(47, 30);
            this.cmbOrderLote.Name = "cmbOrderLote";
            this.cmbOrderLote.Size = new System.Drawing.Size(130, 23);
            this.cmbOrderLote.TabIndex = 25;
            // 
            // lblOrderLote
            // 
            this.lblOrderLote.AutoSize = true;
            this.lblOrderLote.Location = new System.Drawing.Point(10, 35);
            this.lblOrderLote.Name = "lblOrderLote";
            this.lblOrderLote.Size = new System.Drawing.Size(31, 15);
            this.lblOrderLote.TabIndex = 24;
            this.lblOrderLote.Text = "Lote";
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
            this.clmDecreaseMPRawMaterialEntityProvider,
            this.clmDecreaseMPRawMaterialName,
            this.clmDecreaseMPRawMaterialCode,
            this.clmDecreaseMPRawMaterialKg});
            this.dgvDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDetail.Location = new System.Drawing.Point(3, 68);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.Size = new System.Drawing.Size(880, 173);
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
            // clmDecreaseMPRawMaterialEntityProvider
            // 
            this.clmDecreaseMPRawMaterialEntityProvider.HeaderText = "Proveedor";
            this.clmDecreaseMPRawMaterialEntityProvider.Name = "clmDecreaseMPRawMaterialEntityProvider";
            this.clmDecreaseMPRawMaterialEntityProvider.ReadOnly = true;
            this.clmDecreaseMPRawMaterialEntityProvider.Width = 150;
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
            // txtOrderProduction
            // 
            this.txtOrderProduction.BackColor = System.Drawing.SystemColors.Window;
            this.txtOrderProduction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtOrderProduction.Location = new System.Drawing.Point(284, 11);
            this.txtOrderProduction.Name = "txtOrderProduction";
            this.txtOrderProduction.Size = new System.Drawing.Size(130, 24);
            this.txtOrderProduction.TabIndex = 27;
            this.txtOrderProduction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOrderProduction
            // 
            this.lblOrderProduction.AutoSize = true;
            this.lblOrderProduction.Location = new System.Drawing.Point(221, 16);
            this.lblOrderProduction.Name = "lblOrderProduction";
            this.lblOrderProduction.Size = new System.Drawing.Size(41, 15);
            this.lblOrderProduction.TabIndex = 26;
            this.lblOrderProduction.Text = "Orden";
            // 
            // frmRawMaterialDecreaseByOrderProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(892, 635);
            this.Controls.Add(this.txtFilmProduction);
            this.Controls.Add(this.lblFilmProduction);
            this.Controls.Add(this.grpbEmpty);
            this.Controls.Add(this.grpbActions);
            this.Controls.Add(this.grpbAdd);
            this.Controls.Add(this.grpbDetail);
            this.Controls.Add(this.txtOrderProduction);
            this.Controls.Add(this.lblOrderProduction);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRawMaterialDecreaseByOrderProduction";
            this.Text = "Desperdicios de Materia Prima";
            this.grpbActions.ResumeLayout(false);
            this.grpbAdd.ResumeLayout(false);
            this.grpbAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdd)).EndInit();
            this.grpbDetail.ResumeLayout(false);
            this.grpbDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtFilmProduction;
        private System.Windows.Forms.Label lblFilmProduction;
        private System.Windows.Forms.GroupBox grpbEmpty;
        private System.Windows.Forms.GroupBox grpbActions;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpbAdd;
        private System.Windows.Forms.ComboBox cmbAddOrderLote;
        private System.Windows.Forms.Label lblAddOrderLote;
        private System.Windows.Forms.DataGridView dgvAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialDecreaseRMCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialDecreaseRMEntityProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialDecreaseRMName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialDecreaseRMType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialDecreaseRMCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialDecreaseKg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialDecreaseDate;
        private System.Windows.Forms.GroupBox grpbDetail;
        private System.Windows.Forms.ComboBox cmbOrderLote;
        private System.Windows.Forms.Label lblOrderLote;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDecreaseMPRawMaterialCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDecreaseMPRawMaterialType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDecreaseMPRawMaterialEntityProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDecreaseMPRawMaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDecreaseMPRawMaterialCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDecreaseMPRawMaterialKg;
        private System.Windows.Forms.Label txtOrderProduction;
        private System.Windows.Forms.Label lblOrderProduction;
        private System.Windows.Forms.ToolTip ttpRawMaterial;
    }
}