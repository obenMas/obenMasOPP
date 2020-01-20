namespace BPS
{
    partial class frmSupplyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplyForm));
            this.grpbForm = new System.Windows.Forms.GroupBox();
            this.dtpReceptionDate = new System.Windows.Forms.DateTimePicker();
            this.lblReceptionDate = new System.Windows.Forms.Label();
            this.grpbReception = new System.Windows.Forms.GroupBox();
            this.dgvReception = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcodsecProvider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProvider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDocument = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpbActions = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ttpSupplyForm = new System.Windows.Forms.ToolTip(this.components);
            this.grpbForm.SuspendLayout();
            this.grpbReception.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReception)).BeginInit();
            this.grpbActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbForm
            // 
            this.grpbForm.Controls.Add(this.dtpReceptionDate);
            this.grpbForm.Controls.Add(this.lblReceptionDate);
            this.grpbForm.Controls.Add(this.grpbReception);
            this.grpbForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbForm.Location = new System.Drawing.Point(0, 0);
            this.grpbForm.Name = "grpbForm";
            this.grpbForm.Size = new System.Drawing.Size(914, 264);
            this.grpbForm.TabIndex = 8;
            this.grpbForm.TabStop = false;
            // 
            // dtpReceptionDate
            // 
            this.dtpReceptionDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpReceptionDate.Location = new System.Drawing.Point(619, 17);
            this.dtpReceptionDate.Name = "dtpReceptionDate";
            this.dtpReceptionDate.Size = new System.Drawing.Size(283, 21);
            this.dtpReceptionDate.TabIndex = 5;
            // 
            // lblReceptionDate
            // 
            this.lblReceptionDate.AutoSize = true;
            this.lblReceptionDate.Location = new System.Drawing.Point(569, 20);
            this.lblReceptionDate.Name = "lblReceptionDate";
            this.lblReceptionDate.Size = new System.Drawing.Size(41, 15);
            this.lblReceptionDate.TabIndex = 4;
            this.lblReceptionDate.Text = "Fecha";
            // 
            // grpbReception
            // 
            this.grpbReception.Controls.Add(this.dgvReception);
            this.grpbReception.Location = new System.Drawing.Point(0, 47);
            this.grpbReception.Name = "grpbReception";
            this.grpbReception.Size = new System.Drawing.Size(910, 210);
            this.grpbReception.TabIndex = 5;
            this.grpbReception.TabStop = false;
            this.grpbReception.Text = "Detalle";
            // 
            // dgvReception
            // 
            this.dgvReception.AllowUserToDeleteRows = false;
            this.dgvReception.AllowUserToOrderColumns = true;
            this.dgvReception.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReception.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmcodsecProvider,
            this.clmProvider,
            this.clmDocument,
            this.clmName,
            this.clmCode,
            this.clmQuantity,
            this.clmNotes});
            this.dgvReception.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvReception.Location = new System.Drawing.Point(3, 17);
            this.dgvReception.Name = "dgvReception";
            this.dgvReception.Size = new System.Drawing.Size(904, 173);
            this.dgvReception.TabIndex = 0;
            this.dgvReception.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReception_CellDoubleClick);
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmcodsecProvider
            // 
            this.clmcodsecProvider.HeaderText = "codsecProvider";
            this.clmcodsecProvider.Name = "clmcodsecProvider";
            this.clmcodsecProvider.Visible = false;
            // 
            // clmProvider
            // 
            this.clmProvider.HeaderText = "Proveedor";
            this.clmProvider.Name = "clmProvider";
            this.clmProvider.Width = 150;
            // 
            // clmDocument
            // 
            this.clmDocument.HeaderText = "Documento";
            this.clmDocument.Name = "clmDocument";
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Nombre";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Width = 150;
            // 
            // clmCode
            // 
            this.clmCode.HeaderText = "Código";
            this.clmCode.Name = "clmCode";
            this.clmCode.ReadOnly = true;
            // 
            // clmQuantity
            // 
            this.clmQuantity.HeaderText = "Cant. Recibida";
            this.clmQuantity.Name = "clmQuantity";
            // 
            // clmNotes
            // 
            this.clmNotes.HeaderText = "Descripción";
            this.clmNotes.Name = "clmNotes";
            this.clmNotes.Width = 260;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(2, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(803, 50);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // grpbActions
            // 
            this.grpbActions.Controls.Add(this.btnSave);
            this.grpbActions.Controls.Add(this.btnCancel);
            this.grpbActions.Controls.Add(this.btnClose);
            this.grpbActions.Location = new System.Drawing.Point(811, 263);
            this.grpbActions.Name = "grpbActions";
            this.grpbActions.Size = new System.Drawing.Size(100, 50);
            this.grpbActions.TabIndex = 19;
            this.grpbActions.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Location = new System.Drawing.Point(7, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(28, 29);
            this.btnSave.TabIndex = 1;
            this.ttpSupplyForm.SetToolTip(this.btnSave, "Guardar");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.Location = new System.Drawing.Point(36, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(28, 29);
            this.btnCancel.TabIndex = 2;
            this.ttpSupplyForm.SetToolTip(this.btnCancel, "Cancelar");
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(65, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 29);
            this.btnClose.TabIndex = 3;
            this.ttpSupplyForm.SetToolTip(this.btnClose, "Salir");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmSupplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 318);
            this.Controls.Add(this.grpbActions);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpbForm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSupplyForm";
            this.Text = "Suministros";
            this.grpbForm.ResumeLayout(false);
            this.grpbForm.PerformLayout();
            this.grpbReception.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReception)).EndInit();
            this.grpbActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbForm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grpbActions;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpbReception;
        private System.Windows.Forms.DataGridView dgvReception;
        private System.Windows.Forms.DateTimePicker dtpReceptionDate;
        private System.Windows.Forms.Label lblReceptionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcodsecProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDocument;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNotes;
        private System.Windows.Forms.ToolTip ttpSupplyForm;
    }
}