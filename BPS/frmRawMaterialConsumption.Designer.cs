namespace BPS
{
    partial class frmRawMaterialConsumption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRawMaterialConsumption));
            this.grpbButton = new System.Windows.Forms.GroupBox();
            this.btnMainCoilExit = new System.Windows.Forms.Button();
            this.btnMainCoilCancel = new System.Windows.Forms.Button();
            this.btnMainCoilSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDeliver = new System.Windows.Forms.DataGridView();
            this.clmReceptionDetailCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.txtBatch = new System.Windows.Forms.TextBox();
            this.lblBatch = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.ttpRawMaterialActives = new System.Windows.Forms.ToolTip(this.components);
            this.grpbButton.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliver)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbButton
            // 
            this.grpbButton.Controls.Add(this.btnMainCoilExit);
            this.grpbButton.Controls.Add(this.btnMainCoilCancel);
            this.grpbButton.Controls.Add(this.btnMainCoilSave);
            this.grpbButton.Location = new System.Drawing.Point(966, 304);
            this.grpbButton.Name = "grpbButton";
            this.grpbButton.Size = new System.Drawing.Size(89, 46);
            this.grpbButton.TabIndex = 22;
            this.grpbButton.TabStop = false;
            // 
            // btnMainCoilExit
            // 
            this.btnMainCoilExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnMainCoilExit.Location = new System.Drawing.Point(58, 15);
            this.btnMainCoilExit.Name = "btnMainCoilExit";
            this.btnMainCoilExit.Size = new System.Drawing.Size(25, 25);
            this.btnMainCoilExit.TabIndex = 5;
            this.ttpRawMaterialActives.SetToolTip(this.btnMainCoilExit, "Salir");
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
            this.ttpRawMaterialActives.SetToolTip(this.btnMainCoilCancel, "Cancelar");
            this.btnMainCoilCancel.UseVisualStyleBackColor = true;
            // 
            // btnMainCoilSave
            // 
            this.btnMainCoilSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMainCoilSave.BackgroundImage")));
            this.btnMainCoilSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMainCoilSave.Location = new System.Drawing.Point(8, 15);
            this.btnMainCoilSave.Name = "btnMainCoilSave";
            this.btnMainCoilSave.Size = new System.Drawing.Size(25, 25);
            this.btnMainCoilSave.TabIndex = 3;
            this.ttpRawMaterialActives.SetToolTip(this.btnMainCoilSave, "Guardar");
            this.btnMainCoilSave.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(2, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(958, 47);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDeliver);
            this.groupBox1.Location = new System.Drawing.Point(2, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1056, 220);
            this.groupBox1.TabIndex = 20;
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
            // txtBatch
            // 
            this.txtBatch.Location = new System.Drawing.Point(805, 45);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.Size = new System.Drawing.Size(140, 21);
            this.txtBatch.TabIndex = 19;
            // 
            // lblBatch
            // 
            this.lblBatch.AutoSize = true;
            this.lblBatch.Location = new System.Drawing.Point(746, 48);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.Size = new System.Drawing.Size(31, 15);
            this.lblBatch.TabIndex = 17;
            this.lblBatch.Text = "Lote";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(69, 47);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(140, 21);
            this.txtCode.TabIndex = 13;
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(11, 51);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(46, 15);
            this.lblCode.TabIndex = 15;
            this.lblCode.Text = "Código";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpDate.Location = new System.Drawing.Point(805, 7);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(243, 21);
            this.dtpDate.TabIndex = 18;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(746, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 15);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "Fecha";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(69, 10);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(140, 21);
            this.txtNumber.TabIndex = 16;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(11, 12);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(52, 15);
            this.lblNumber.TabIndex = 12;
            this.lblNumber.Text = "Número";
            // 
            // frmRawMaterialConsumption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1057, 353);
            this.Controls.Add(this.grpbButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBatch);
            this.Controls.Add(this.lblBatch);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblNumber);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmRawMaterialConsumption";
            this.Text = "Consumo Materia Prima";
            this.Load += new System.EventHandler(this.frmRawMaterialConsumption_Load);
            this.grpbButton.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbButton;
        private System.Windows.Forms.Button btnMainCoilExit;
        private System.Windows.Forms.Button btnMainCoilCancel;
        private System.Windows.Forms.Button btnMainCoilSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDeliver;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmReceptionDetailCodsec;
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
        private System.Windows.Forms.TextBox txtBatch;
        private System.Windows.Forms.Label lblBatch;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.ToolTip ttpRawMaterialActives;
    }
}