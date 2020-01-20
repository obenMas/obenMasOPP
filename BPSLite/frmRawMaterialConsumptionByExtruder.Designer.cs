namespace BPS.Lite
{
    partial class frmRawMaterialConsumptionByExtruder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRawMaterialConsumptionByExtruder));
            this.lblRawMaterialConsumptionMachine = new System.Windows.Forms.Label();
            this.txtRawMaterialConsumptionMachine = new System.Windows.Forms.TextBox();
            this.txtRawMaterialConsumptionProdOrder = new System.Windows.Forms.TextBox();
            this.lblRawMaterialConsumptionProdOrder = new System.Windows.Forms.Label();
            this.txtRawMaterialConsumptionProduct = new System.Windows.Forms.TextBox();
            this.lblRawMaterialConsumptionProduct = new System.Windows.Forms.Label();
            this.grpbRawMaterialConsumptionGeneral = new System.Windows.Forms.GroupBox();
            this.grpbRawMaterialConsumptionForm = new System.Windows.Forms.GroupBox();
            this.dgvDeliver = new System.Windows.Forms.DataGridView();
            this.clmRawMaterialConsumptionCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialConsumptionRMType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialConsumptionRM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialConsumptionEnableQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialConsumptionQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbActions = new System.Windows.Forms.GroupBox();
            this.btnMainCoilSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpbSearch = new System.Windows.Forms.GroupBox();
            this.lblRawMaterialConsumptionCode = new System.Windows.Forms.Label();
            this.txtRawMaterialConsumptionCode = new System.Windows.Forms.TextBox();
            this.grpbRawMaterialConsumptionGeneral.SuspendLayout();
            this.grpbRawMaterialConsumptionForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliver)).BeginInit();
            this.grpbActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRawMaterialConsumptionMachine
            // 
            this.lblRawMaterialConsumptionMachine.AutoSize = true;
            this.lblRawMaterialConsumptionMachine.Location = new System.Drawing.Point(10, 33);
            this.lblRawMaterialConsumptionMachine.Name = "lblRawMaterialConsumptionMachine";
            this.lblRawMaterialConsumptionMachine.Size = new System.Drawing.Size(56, 15);
            this.lblRawMaterialConsumptionMachine.TabIndex = 0;
            this.lblRawMaterialConsumptionMachine.Text = "Máquina";
            // 
            // txtRawMaterialConsumptionMachine
            // 
            this.txtRawMaterialConsumptionMachine.Location = new System.Drawing.Point(74, 30);
            this.txtRawMaterialConsumptionMachine.Name = "txtRawMaterialConsumptionMachine";
            this.txtRawMaterialConsumptionMachine.Size = new System.Drawing.Size(121, 21);
            this.txtRawMaterialConsumptionMachine.TabIndex = 1;
            // 
            // txtRawMaterialConsumptionProdOrder
            // 
            this.txtRawMaterialConsumptionProdOrder.Location = new System.Drawing.Point(308, 30);
            this.txtRawMaterialConsumptionProdOrder.Name = "txtRawMaterialConsumptionProdOrder";
            this.txtRawMaterialConsumptionProdOrder.Size = new System.Drawing.Size(100, 21);
            this.txtRawMaterialConsumptionProdOrder.TabIndex = 3;
            // 
            // lblRawMaterialConsumptionProdOrder
            // 
            this.lblRawMaterialConsumptionProdOrder.AutoSize = true;
            this.lblRawMaterialConsumptionProdOrder.Location = new System.Drawing.Point(207, 33);
            this.lblRawMaterialConsumptionProdOrder.Name = "lblRawMaterialConsumptionProdOrder";
            this.lblRawMaterialConsumptionProdOrder.Size = new System.Drawing.Size(95, 15);
            this.lblRawMaterialConsumptionProdOrder.TabIndex = 2;
            this.lblRawMaterialConsumptionProdOrder.Text = "Orden Extrusión";
            // 
            // txtRawMaterialConsumptionProduct
            // 
            this.txtRawMaterialConsumptionProduct.Location = new System.Drawing.Point(487, 30);
            this.txtRawMaterialConsumptionProduct.Name = "txtRawMaterialConsumptionProduct";
            this.txtRawMaterialConsumptionProduct.Size = new System.Drawing.Size(339, 21);
            this.txtRawMaterialConsumptionProduct.TabIndex = 5;
            // 
            // lblRawMaterialConsumptionProduct
            // 
            this.lblRawMaterialConsumptionProduct.AutoSize = true;
            this.lblRawMaterialConsumptionProduct.Location = new System.Drawing.Point(423, 33);
            this.lblRawMaterialConsumptionProduct.Name = "lblRawMaterialConsumptionProduct";
            this.lblRawMaterialConsumptionProduct.Size = new System.Drawing.Size(56, 15);
            this.lblRawMaterialConsumptionProduct.TabIndex = 4;
            this.lblRawMaterialConsumptionProduct.Text = "Producto";
            // 
            // grpbRawMaterialConsumptionGeneral
            // 
            this.grpbRawMaterialConsumptionGeneral.Controls.Add(this.lblRawMaterialConsumptionMachine);
            this.grpbRawMaterialConsumptionGeneral.Controls.Add(this.txtRawMaterialConsumptionProduct);
            this.grpbRawMaterialConsumptionGeneral.Controls.Add(this.txtRawMaterialConsumptionMachine);
            this.grpbRawMaterialConsumptionGeneral.Controls.Add(this.lblRawMaterialConsumptionProduct);
            this.grpbRawMaterialConsumptionGeneral.Controls.Add(this.lblRawMaterialConsumptionProdOrder);
            this.grpbRawMaterialConsumptionGeneral.Controls.Add(this.txtRawMaterialConsumptionProdOrder);
            this.grpbRawMaterialConsumptionGeneral.Location = new System.Drawing.Point(0, 28);
            this.grpbRawMaterialConsumptionGeneral.Name = "grpbRawMaterialConsumptionGeneral";
            this.grpbRawMaterialConsumptionGeneral.Size = new System.Drawing.Size(838, 64);
            this.grpbRawMaterialConsumptionGeneral.TabIndex = 6;
            this.grpbRawMaterialConsumptionGeneral.TabStop = false;
            this.grpbRawMaterialConsumptionGeneral.Text = "Datos Generales";
            // 
            // grpbRawMaterialConsumptionForm
            // 
            this.grpbRawMaterialConsumptionForm.Controls.Add(this.dgvDeliver);
            this.grpbRawMaterialConsumptionForm.Location = new System.Drawing.Point(0, 92);
            this.grpbRawMaterialConsumptionForm.Name = "grpbRawMaterialConsumptionForm";
            this.grpbRawMaterialConsumptionForm.Size = new System.Drawing.Size(838, 266);
            this.grpbRawMaterialConsumptionForm.TabIndex = 7;
            this.grpbRawMaterialConsumptionForm.TabStop = false;
            this.grpbRawMaterialConsumptionForm.Text = "Registrar Consumo";
            // 
            // dgvDeliver
            // 
            this.dgvDeliver.AllowUserToDeleteRows = false;
            this.dgvDeliver.AllowUserToOrderColumns = true;
            this.dgvDeliver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeliver.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmRawMaterialConsumptionCodsec,
            this.clmRawMaterialConsumptionRMType,
            this.clmRawMaterialConsumptionRM,
            this.clmRawMaterialConsumptionEnableQ,
            this.clmRawMaterialConsumptionQuantity});
            this.dgvDeliver.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDeliver.Location = new System.Drawing.Point(3, 17);
            this.dgvDeliver.Name = "dgvDeliver";
            this.dgvDeliver.Size = new System.Drawing.Size(832, 227);
            this.dgvDeliver.TabIndex = 0;
            this.dgvDeliver.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeliver_CellDoubleClick);
            // 
            // clmRawMaterialConsumptionCodsec
            // 
            this.clmRawMaterialConsumptionCodsec.HeaderText = "codsec";
            this.clmRawMaterialConsumptionCodsec.Name = "clmRawMaterialConsumptionCodsec";
            this.clmRawMaterialConsumptionCodsec.ReadOnly = true;
            this.clmRawMaterialConsumptionCodsec.Visible = false;
            // 
            // clmRawMaterialConsumptionRMType
            // 
            this.clmRawMaterialConsumptionRMType.HeaderText = "Tipo M.P.";
            this.clmRawMaterialConsumptionRMType.Name = "clmRawMaterialConsumptionRMType";
            this.clmRawMaterialConsumptionRMType.ReadOnly = true;
            this.clmRawMaterialConsumptionRMType.Width = 200;
            // 
            // clmRawMaterialConsumptionRM
            // 
            this.clmRawMaterialConsumptionRM.HeaderText = "Materia Prima";
            this.clmRawMaterialConsumptionRM.Name = "clmRawMaterialConsumptionRM";
            this.clmRawMaterialConsumptionRM.ReadOnly = true;
            this.clmRawMaterialConsumptionRM.Width = 235;
            // 
            // clmRawMaterialConsumptionEnableQ
            // 
            this.clmRawMaterialConsumptionEnableQ.HeaderText = "Cantidad Disponible";
            this.clmRawMaterialConsumptionEnableQ.Name = "clmRawMaterialConsumptionEnableQ";
            this.clmRawMaterialConsumptionEnableQ.ReadOnly = true;
            this.clmRawMaterialConsumptionEnableQ.Width = 175;
            // 
            // clmRawMaterialConsumptionQuantity
            // 
            this.clmRawMaterialConsumptionQuantity.HeaderText = "Cantidad a Consumir";
            this.clmRawMaterialConsumptionQuantity.Name = "clmRawMaterialConsumptionQuantity";
            this.clmRawMaterialConsumptionQuantity.Width = 175;
            // 
            // grpbActions
            // 
            this.grpbActions.Controls.Add(this.btnMainCoilSave);
            this.grpbActions.Controls.Add(this.btnClose);
            this.grpbActions.Location = new System.Drawing.Point(771, 357);
            this.grpbActions.Name = "grpbActions";
            this.grpbActions.Size = new System.Drawing.Size(64, 43);
            this.grpbActions.TabIndex = 5;
            this.grpbActions.TabStop = false;
            // 
            // btnMainCoilSave
            // 
            this.btnMainCoilSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMainCoilSave.BackgroundImage")));
            this.btnMainCoilSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMainCoilSave.Location = new System.Drawing.Point(7, 13);
            this.btnMainCoilSave.Name = "btnMainCoilSave";
            this.btnMainCoilSave.Size = new System.Drawing.Size(25, 25);
            this.btnMainCoilSave.TabIndex = 4;
            this.btnMainCoilSave.UseVisualStyleBackColor = true;
            this.btnMainCoilSave.Click += new System.EventHandler(this.btnMainCoilSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::BPS.Lite.Properties.Resources.door_in;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(34, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // grpbSearch
            // 
            this.grpbSearch.BackColor = System.Drawing.SystemColors.Control;
            this.grpbSearch.Location = new System.Drawing.Point(0, 357);
            this.grpbSearch.Name = "grpbSearch";
            this.grpbSearch.Size = new System.Drawing.Size(765, 43);
            this.grpbSearch.TabIndex = 8;
            this.grpbSearch.TabStop = false;
            // 
            // lblRawMaterialConsumptionCode
            // 
            this.lblRawMaterialConsumptionCode.AutoSize = true;
            this.lblRawMaterialConsumptionCode.Location = new System.Drawing.Point(553, 10);
            this.lblRawMaterialConsumptionCode.Name = "lblRawMaterialConsumptionCode";
            this.lblRawMaterialConsumptionCode.Size = new System.Drawing.Size(102, 15);
            this.lblRawMaterialConsumptionCode.TabIndex = 9;
            this.lblRawMaterialConsumptionCode.Text = "Código Consumo";
            // 
            // txtRawMaterialConsumptionCode
            // 
            this.txtRawMaterialConsumptionCode.Location = new System.Drawing.Point(661, 7);
            this.txtRawMaterialConsumptionCode.Name = "txtRawMaterialConsumptionCode";
            this.txtRawMaterialConsumptionCode.Size = new System.Drawing.Size(167, 21);
            this.txtRawMaterialConsumptionCode.TabIndex = 10;
            // 
            // frmRawMaterialConsumptionByExtruder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 406);
            this.Controls.Add(this.lblRawMaterialConsumptionCode);
            this.Controls.Add(this.txtRawMaterialConsumptionCode);
            this.Controls.Add(this.grpbSearch);
            this.Controls.Add(this.grpbActions);
            this.Controls.Add(this.grpbRawMaterialConsumptionForm);
            this.Controls.Add(this.grpbRawMaterialConsumptionGeneral);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmRawMaterialConsumptionByExtruder";
            this.Text = "Consumo Materia Prima";
            this.Load += new System.EventHandler(this.frmRawMaterialConsumptionByExtruder_Load);
            this.grpbRawMaterialConsumptionGeneral.ResumeLayout(false);
            this.grpbRawMaterialConsumptionGeneral.PerformLayout();
            this.grpbRawMaterialConsumptionForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliver)).EndInit();
            this.grpbActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRawMaterialConsumptionMachine;
        private System.Windows.Forms.TextBox txtRawMaterialConsumptionMachine;
        private System.Windows.Forms.TextBox txtRawMaterialConsumptionProdOrder;
        private System.Windows.Forms.Label lblRawMaterialConsumptionProdOrder;
        private System.Windows.Forms.TextBox txtRawMaterialConsumptionProduct;
        private System.Windows.Forms.Label lblRawMaterialConsumptionProduct;
        private System.Windows.Forms.GroupBox grpbRawMaterialConsumptionGeneral;
        private System.Windows.Forms.GroupBox grpbRawMaterialConsumptionForm;
        private System.Windows.Forms.DataGridView dgvDeliver;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialConsumptionCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialConsumptionRMType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialConsumptionRM;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialConsumptionEnableQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialConsumptionQuantity;
        private System.Windows.Forms.GroupBox grpbActions;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpbSearch;
        private System.Windows.Forms.Button btnMainCoilSave;
        private System.Windows.Forms.Label lblRawMaterialConsumptionCode;
        private System.Windows.Forms.TextBox txtRawMaterialConsumptionCode;
    }
}