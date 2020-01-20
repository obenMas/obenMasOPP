namespace BPS
{
    partial class frmDeliverRawMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeliverRawMaterial));
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDeliver = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpbButton = new System.Windows.Forms.GroupBox();
            this.btnMainCoilExit = new System.Windows.Forms.Button();
            this.btnMainCoilCancel = new System.Windows.Forms.Button();
            this.btnMainCoilSave = new System.Windows.Forms.Button();
            this.ttpDenRawMaterial = new System.Windows.Forms.ToolTip(this.components);
            this.clmReceptionDetailCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkExtruder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmfkRawMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProvider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAvailableUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWeigthUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAvailableWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDeliveredQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmfkCellar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDestiny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNumber = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliver)).BeginInit();
            this.grpbButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(321, 15);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(140, 21);
            this.txtNumber.TabIndex = 6;
            this.txtNumber.Visible = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(752, 18);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 15);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Fecha";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpDate.Location = new System.Drawing.Point(811, 16);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(243, 21);
            this.dtpDate.TabIndex = 9;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(5, 18);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(46, 15);
            this.lblCode.TabIndex = 5;
            this.lblCode.Text = "Código";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(63, 14);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(140, 21);
            this.txtCode.TabIndex = 1;
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(482, 18);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(50, 15);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "Usuario";
            this.lblUser.Visible = false;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(541, 15);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(140, 21);
            this.txtUser.TabIndex = 9;
            this.txtUser.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDeliver);
            this.groupBox1.Location = new System.Drawing.Point(8, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1056, 207);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Despacho";
            // 
            // dgvDeliver
            // 
            this.dgvDeliver.AllowUserToAddRows = false;
            this.dgvDeliver.AllowUserToOrderColumns = true;
            this.dgvDeliver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeliver.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmReceptionDetailCodsec,
            this.fkExtruder,
            this.clmfkRawMaterial,
            this.clmProvider,
            this.clmRawMaterialType,
            this.clmRawMaterial,
            this.clmAvailableUnits,
            this.clmWeigthUnit,
            this.clmAvailableWeigth,
            this.clmDeliveredQuantity,
            this.clmfkCellar,
            this.clmDestiny,
            this.clmComment,
            this.clmCost,
            this.clmQuote});
            this.dgvDeliver.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDeliver.Location = new System.Drawing.Point(3, 17);
            this.dgvDeliver.Name = "dgvDeliver";
            this.dgvDeliver.Size = new System.Drawing.Size(1050, 187);
            this.dgvDeliver.TabIndex = 2;
            this.dgvDeliver.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeliver_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(8, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(958, 47);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // grpbButton
            // 
            this.grpbButton.Controls.Add(this.btnMainCoilExit);
            this.grpbButton.Controls.Add(this.btnMainCoilCancel);
            this.grpbButton.Controls.Add(this.btnMainCoilSave);
            this.grpbButton.Location = new System.Drawing.Point(972, 250);
            this.grpbButton.Name = "grpbButton";
            this.grpbButton.Size = new System.Drawing.Size(89, 46);
            this.grpbButton.TabIndex = 11;
            this.grpbButton.TabStop = false;
            // 
            // btnMainCoilExit
            // 
            this.btnMainCoilExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnMainCoilExit.Location = new System.Drawing.Point(58, 15);
            this.btnMainCoilExit.Name = "btnMainCoilExit";
            this.btnMainCoilExit.Size = new System.Drawing.Size(25, 25);
            this.btnMainCoilExit.TabIndex = 5;
            this.ttpDenRawMaterial.SetToolTip(this.btnMainCoilExit, "Salir Materia Prima");
            this.btnMainCoilExit.UseVisualStyleBackColor = true;
            this.btnMainCoilExit.Click += new System.EventHandler(this.btnMainCoilExit_Click);
            // 
            // btnMainCoilCancel
            // 
            this.btnMainCoilCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnMainCoilCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMainCoilCancel.Location = new System.Drawing.Point(33, 15);
            this.btnMainCoilCancel.Name = "btnMainCoilCancel";
            this.btnMainCoilCancel.Size = new System.Drawing.Size(25, 25);
            this.btnMainCoilCancel.TabIndex = 4;
            this.ttpDenRawMaterial.SetToolTip(this.btnMainCoilCancel, "Cancelar Materia Prima");
            this.btnMainCoilCancel.UseVisualStyleBackColor = true;
            this.btnMainCoilCancel.Click += new System.EventHandler(this.btnMainCoilCancel_Click);
            // 
            // btnMainCoilSave
            // 
            this.btnMainCoilSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMainCoilSave.BackgroundImage")));
            this.btnMainCoilSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMainCoilSave.Location = new System.Drawing.Point(8, 15);
            this.btnMainCoilSave.Name = "btnMainCoilSave";
            this.btnMainCoilSave.Size = new System.Drawing.Size(25, 25);
            this.btnMainCoilSave.TabIndex = 3;
            this.ttpDenRawMaterial.SetToolTip(this.btnMainCoilSave, "Guardar Materia Prima");
            this.btnMainCoilSave.UseVisualStyleBackColor = true;
            this.btnMainCoilSave.Click += new System.EventHandler(this.btnMainCoilSave_Click);
            // 
            // clmReceptionDetailCodsec
            // 
            this.clmReceptionDetailCodsec.HeaderText = "codsec";
            this.clmReceptionDetailCodsec.Name = "clmReceptionDetailCodsec";
            this.clmReceptionDetailCodsec.ReadOnly = true;
            this.clmReceptionDetailCodsec.Visible = false;
            // 
            // fkExtruder
            // 
            this.fkExtruder.HeaderText = "fkExtruder";
            this.fkExtruder.Name = "fkExtruder";
            this.fkExtruder.Visible = false;
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
            // 
            // clmRawMaterialType
            // 
            this.clmRawMaterialType.HeaderText = "Tipo M.P.";
            this.clmRawMaterialType.Name = "clmRawMaterialType";
            this.clmRawMaterialType.ReadOnly = true;
            // 
            // clmRawMaterial
            // 
            this.clmRawMaterial.HeaderText = "Materia Prima";
            this.clmRawMaterial.Name = "clmRawMaterial";
            this.clmRawMaterial.ReadOnly = true;
            // 
            // clmAvailableUnits
            // 
            this.clmAvailableUnits.HeaderText = "Unidades Disponibles";
            this.clmAvailableUnits.Name = "clmAvailableUnits";
            this.clmAvailableUnits.ReadOnly = true;
            // 
            // clmWeigthUnit
            // 
            this.clmWeigthUnit.HeaderText = "Peso Unitario";
            this.clmWeigthUnit.Name = "clmWeigthUnit";
            // 
            // clmAvailableWeigth
            // 
            this.clmAvailableWeigth.HeaderText = "Kilos Disponibles";
            this.clmAvailableWeigth.Name = "clmAvailableWeigth";
            this.clmAvailableWeigth.ReadOnly = true;
            // 
            // clmDeliveredQuantity
            // 
            this.clmDeliveredQuantity.HeaderText = "Unidades a Despachar";
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
            // 
            // clmComment
            // 
            this.clmComment.HeaderText = "Comentario";
            this.clmComment.Name = "clmComment";
            this.clmComment.Width = 200;
            // 
            // clmCost
            // 
            this.clmCost.HeaderText = "costo";
            this.clmCost.Name = "clmCost";
            this.clmCost.Visible = false;
            // 
            // clmQuote
            // 
            this.clmQuote.HeaderText = "cotizacion";
            this.clmQuote.Name = "clmQuote";
            this.clmQuote.Visible = false;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(263, 17);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(52, 15);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Número";
            this.lblNumber.Visible = false;
            // 
            // frmDeliverRawMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1067, 300);
            this.Controls.Add(this.grpbButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblNumber);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDeliverRawMaterial";
            this.Text = "Traspaso Materia Prima";
            this.Load += new System.EventHandler(this.frmDeliverRawMaterial_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliver)).EndInit();
            this.grpbButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grpbButton;
        private System.Windows.Forms.DataGridView dgvDeliver;
        private System.Windows.Forms.Button btnMainCoilExit;
        private System.Windows.Forms.Button btnMainCoilCancel;
        private System.Windows.Forms.Button btnMainCoilSave;
        private System.Windows.Forms.ToolTip ttpDenRawMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmReceptionDetailCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkExtruder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfkRawMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAvailableUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWeigthUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAvailableWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDeliveredQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfkCellar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDestiny;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuote;
        private System.Windows.Forms.Label lblNumber;
    }
}