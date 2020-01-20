namespace BPS
{
    partial class frmRawMaterialConsumptionByOrderProduction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRawMaterialConsumptionByOrderProduction));
            this.grpbEmpty = new System.Windows.Forms.GroupBox();
            this.grpbActions = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpbAdd = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDeliver = new System.Windows.Forms.DataGridView();
            this.txtOrderProduction = new System.Windows.Forms.Label();
            this.lblOrderProduction = new System.Windows.Forms.Label();
            this.txtFilmProduction = new System.Windows.Forms.Label();
            this.lblFilmProduction = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.ttpRawMaterialActive = new System.Windows.Forms.ToolTip(this.components);
            this.clmReceptionDetailCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmfkRawMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProvider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAvailableUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDeliveredQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmfkCellar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDestiny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbActions.SuspendLayout();
            this.grpbAdd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliver)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbEmpty
            // 
            this.grpbEmpty.Location = new System.Drawing.Point(-30, 272);
            this.grpbEmpty.Name = "grpbEmpty";
            this.grpbEmpty.Size = new System.Drawing.Size(942, 43);
            this.grpbEmpty.TabIndex = 23;
            this.grpbEmpty.TabStop = false;
            // 
            // grpbActions
            // 
            this.grpbActions.Controls.Add(this.btnExit);
            this.grpbActions.Controls.Add(this.btnSave);
            this.grpbActions.Controls.Add(this.btnCancel);
            this.grpbActions.Location = new System.Drawing.Point(915, 271);
            this.grpbActions.Name = "grpbActions";
            this.grpbActions.Size = new System.Drawing.Size(82, 43);
            this.grpbActions.TabIndex = 22;
            this.grpbActions.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnExit.Location = new System.Drawing.Point(53, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 32;
            this.ttpRawMaterialActive.SetToolTip(this.btnExit, "Salir Consumo Materia Prima");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Location = new System.Drawing.Point(3, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(25, 25);
            this.btnSave.TabIndex = 30;
            this.ttpRawMaterialActive.SetToolTip(this.btnSave, "Guardar Consumo Materia Prima");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.Location = new System.Drawing.Point(28, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCancel.TabIndex = 31;
            this.ttpRawMaterialActive.SetToolTip(this.btnCancel, "Cancelar Consumo Materia Prima");
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // grpbAdd
            // 
            this.grpbAdd.Controls.Add(this.groupBox1);
            this.grpbAdd.Location = new System.Drawing.Point(3, 39);
            this.grpbAdd.Name = "grpbAdd";
            this.grpbAdd.Size = new System.Drawing.Size(994, 237);
            this.grpbAdd.TabIndex = 21;
            this.grpbAdd.TabStop = false;
            this.grpbAdd.Text = "Agregar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDeliver);
            this.groupBox1.Location = new System.Drawing.Point(3, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(985, 211);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // dgvDeliver
            // 
            this.dgvDeliver.AllowUserToAddRows = false;
            this.dgvDeliver.AllowUserToDeleteRows = false;
            this.dgvDeliver.AllowUserToOrderColumns = true;
            this.dgvDeliver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeliver.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmReceptionDetailCodsec,
            this.clmfkRawMaterial,
            this.clmProvider,
            this.clmRawMaterialType,
            this.clmRawMaterial,
            this.clmAvailableUnits,
            this.clmDeliveredQuantity,
            this.clmfkCellar,
            this.clmDestiny,
            this.clmComment});
            this.dgvDeliver.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDeliver.Location = new System.Drawing.Point(3, 17);
            this.dgvDeliver.Name = "dgvDeliver";
            this.dgvDeliver.Size = new System.Drawing.Size(979, 198);
            this.dgvDeliver.TabIndex = 3;
            this.dgvDeliver.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvDeliver_CellValidating);
            // 
            // txtOrderProduction
            // 
            this.txtOrderProduction.BackColor = System.Drawing.SystemColors.Window;
            this.txtOrderProduction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtOrderProduction.Location = new System.Drawing.Point(284, 8);
            this.txtOrderProduction.Name = "txtOrderProduction";
            this.txtOrderProduction.Size = new System.Drawing.Size(130, 21);
            this.txtOrderProduction.TabIndex = 19;
            this.txtOrderProduction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOrderProduction
            // 
            this.lblOrderProduction.AutoSize = true;
            this.lblOrderProduction.Location = new System.Drawing.Point(221, 11);
            this.lblOrderProduction.Name = "lblOrderProduction";
            this.lblOrderProduction.Size = new System.Drawing.Size(41, 15);
            this.lblOrderProduction.TabIndex = 18;
            this.lblOrderProduction.Text = "Orden";
            // 
            // txtFilmProduction
            // 
            this.txtFilmProduction.BackColor = System.Drawing.SystemColors.Window;
            this.txtFilmProduction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtFilmProduction.Location = new System.Drawing.Point(73, 8);
            this.txtFilmProduction.Name = "txtFilmProduction";
            this.txtFilmProduction.Size = new System.Drawing.Size(130, 21);
            this.txtFilmProduction.TabIndex = 25;
            this.txtFilmProduction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFilmProduction
            // 
            this.lblFilmProduction.AutoSize = true;
            this.lblFilmProduction.Location = new System.Drawing.Point(10, 11);
            this.lblFilmProduction.Name = "lblFilmProduction";
            this.lblFilmProduction.Size = new System.Drawing.Size(51, 15);
            this.lblFilmProduction.TabIndex = 24;
            this.lblFilmProduction.Text = "Película";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(859, 8);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(130, 21);
            this.txtNumber.TabIndex = 28;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(801, 11);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(52, 15);
            this.lblNumber.TabIndex = 27;
            this.lblNumber.Text = "Número";
            // 
            // clmReceptionDetailCodsec
            // 
            this.clmReceptionDetailCodsec.HeaderText = "codsec";
            this.clmReceptionDetailCodsec.Name = "clmReceptionDetailCodsec";
            this.clmReceptionDetailCodsec.ReadOnly = true;
            this.clmReceptionDetailCodsec.Visible = false;
            // 
            // clmfkRawMaterial
            // 
            this.clmfkRawMaterial.HeaderText = "fkRawMaterial";
            this.clmfkRawMaterial.Name = "clmfkRawMaterial";
            this.clmfkRawMaterial.ReadOnly = true;
            this.clmfkRawMaterial.Visible = false;
            // 
            // clmProvider
            // 
            this.clmProvider.HeaderText = "Proveedor";
            this.clmProvider.Name = "clmProvider";
            this.clmProvider.ReadOnly = true;
            this.clmProvider.Width = 150;
            // 
            // clmRawMaterialType
            // 
            this.clmRawMaterialType.HeaderText = "Tipo M.P.";
            this.clmRawMaterialType.Name = "clmRawMaterialType";
            this.clmRawMaterialType.ReadOnly = true;
            this.clmRawMaterialType.Width = 130;
            // 
            // clmRawMaterial
            // 
            this.clmRawMaterial.HeaderText = "Materia Prima";
            this.clmRawMaterial.Name = "clmRawMaterial";
            this.clmRawMaterial.ReadOnly = true;
            this.clmRawMaterial.Width = 130;
            // 
            // clmAvailableUnits
            // 
            this.clmAvailableUnits.HeaderText = "Kilos Disponibles";
            this.clmAvailableUnits.Name = "clmAvailableUnits";
            this.clmAvailableUnits.ReadOnly = true;
            // 
            // clmDeliveredQuantity
            // 
            this.clmDeliveredQuantity.HeaderText = "Consumo";
            this.clmDeliveredQuantity.Name = "clmDeliveredQuantity";
            // 
            // clmfkCellar
            // 
            this.clmfkCellar.HeaderText = "fkCellar";
            this.clmfkCellar.Name = "clmfkCellar";
            this.clmfkCellar.Visible = false;
            // 
            // clmDestiny
            // 
            this.clmDestiny.HeaderText = "Destino";
            this.clmDestiny.Name = "clmDestiny";
            this.clmDestiny.Width = 110;
            // 
            // clmComment
            // 
            this.clmComment.HeaderText = "Comentario";
            this.clmComment.Name = "clmComment";
            this.clmComment.Width = 210;
            // 
            // frmRawMaterialConsumptionByOrderProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(999, 317);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.txtFilmProduction);
            this.Controls.Add(this.lblFilmProduction);
            this.Controls.Add(this.grpbAdd);
            this.Controls.Add(this.txtOrderProduction);
            this.Controls.Add(this.lblOrderProduction);
            this.Controls.Add(this.grpbActions);
            this.Controls.Add(this.grpbEmpty);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRawMaterialConsumptionByOrderProduction";
            this.Text = "Consumo Materia Prima Por Orden de Extrusión";
            this.Load += new System.EventHandler(this.frmRawMaterialConsumptionByOrderProduction_Load);
            this.grpbActions.ResumeLayout(false);
            this.grpbAdd.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbEmpty;
        private System.Windows.Forms.GroupBox grpbActions;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpbAdd;
        private System.Windows.Forms.Label txtOrderProduction;
        private System.Windows.Forms.Label lblOrderProduction;
        private System.Windows.Forms.Label txtFilmProduction;
        private System.Windows.Forms.Label lblFilmProduction;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDeliver;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.ToolTip ttpRawMaterialActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmReceptionDetailCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfkRawMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAvailableUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDeliveredQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfkCellar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDestiny;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmComment;

    }
}