namespace BPS
{
    partial class frmPalletShipping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPalletShipping));
            this.grpInfoDate = new System.Windows.Forms.GroupBox();
            this.cmbTransport = new System.Windows.Forms.ComboBox();
            this.lblTransport = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerNameLabel = new System.Windows.Forms.Label();
            this.lblNumberLabel = new System.Windows.Forms.Label();
            this.grpPalletList = new System.Windows.Forms.GroupBox();
            this.dgvPalletList = new System.Windows.Forms.DataGridView();
            this.grpbEmpty = new System.Windows.Forms.GroupBox();
            this.grpbActions = new System.Windows.Forms.GroupBox();
            this.txtPalletCode = new System.Windows.Forms.TextBox();
            this.lblPalletCode = new System.Windows.Forms.Label();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalesOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNetWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGrossWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAction = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmActionToDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.grpInfoDate.SuspendLayout();
            this.grpPalletList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletList)).BeginInit();
            this.grpbActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInfoDate
            // 
            this.grpInfoDate.Controls.Add(this.cmbTransport);
            this.grpInfoDate.Controls.Add(this.lblTransport);
            this.grpInfoDate.Controls.Add(this.txtNumber);
            this.grpInfoDate.Controls.Add(this.lblCustomerName);
            this.grpInfoDate.Controls.Add(this.lblCustomerNameLabel);
            this.grpInfoDate.Controls.Add(this.lblNumberLabel);
            this.grpInfoDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInfoDate.Location = new System.Drawing.Point(0, 0);
            this.grpInfoDate.Name = "grpInfoDate";
            this.grpInfoDate.Size = new System.Drawing.Size(863, 79);
            this.grpInfoDate.TabIndex = 1;
            this.grpInfoDate.TabStop = false;
            // 
            // cmbTransport
            // 
            this.cmbTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTransport.FormattingEnabled = true;
            this.cmbTransport.Location = new System.Drawing.Point(206, 45);
            this.cmbTransport.Name = "cmbTransport";
            this.cmbTransport.Size = new System.Drawing.Size(538, 28);
            this.cmbTransport.TabIndex = 17;
            this.cmbTransport.SelectedIndexChanged += new System.EventHandler(this.cmbTransport_SelectedIndexChanged);
            // 
            // lblTransport
            // 
            this.lblTransport.AutoSize = true;
            this.lblTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransport.Location = new System.Drawing.Point(119, 48);
            this.lblTransport.Name = "lblTransport";
            this.lblTransport.Size = new System.Drawing.Size(86, 20);
            this.lblTransport.TabIndex = 18;
            this.lblTransport.Text = "Transporte";
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(169, 12);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(146, 26);
            this.txtNumber.TabIndex = 16;
            this.txtNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumber_KeyDown);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(382, 12);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(382, 21);
            this.lblCustomerName.TabIndex = 14;
            // 
            // lblCustomerNameLabel
            // 
            this.lblCustomerNameLabel.AutoSize = true;
            this.lblCustomerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerNameLabel.Location = new System.Drawing.Point(318, 15);
            this.lblCustomerNameLabel.Name = "lblCustomerNameLabel";
            this.lblCustomerNameLabel.Size = new System.Drawing.Size(58, 20);
            this.lblCustomerNameLabel.TabIndex = 11;
            this.lblCustomerNameLabel.Text = "Cliente";
            // 
            // lblNumberLabel
            // 
            this.lblNumberLabel.AutoSize = true;
            this.lblNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberLabel.Location = new System.Drawing.Point(98, 15);
            this.lblNumberLabel.Name = "lblNumberLabel";
            this.lblNumberLabel.Size = new System.Drawing.Size(65, 20);
            this.lblNumberLabel.TabIndex = 9;
            this.lblNumberLabel.Text = "Número";
            // 
            // grpPalletList
            // 
            this.grpPalletList.Controls.Add(this.btnProcess);
            this.grpPalletList.Controls.Add(this.txtPalletCode);
            this.grpPalletList.Controls.Add(this.lblPalletCode);
            this.grpPalletList.Controls.Add(this.dgvPalletList);
            this.grpPalletList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpPalletList.Location = new System.Drawing.Point(0, 79);
            this.grpPalletList.Name = "grpPalletList";
            this.grpPalletList.Size = new System.Drawing.Size(863, 429);
            this.grpPalletList.TabIndex = 2;
            this.grpPalletList.TabStop = false;
            this.grpPalletList.Text = "Pallets completos";
            // 
            // dgvPalletList
            // 
            this.dgvPalletList.AllowUserToAddRows = false;
            this.dgvPalletList.AllowUserToDeleteRows = false;
            this.dgvPalletList.AllowUserToOrderColumns = true;
            this.dgvPalletList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalletList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmNumber,
            this.clmProductCode,
            this.clmID,
            this.clmCode,
            this.clmSalesOrderNumber,
            this.clmWidth,
            this.clmNetWeight,
            this.clmGrossWeight,
            this.clmAction,
            this.clmActionToDo});
            this.dgvPalletList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPalletList.Location = new System.Drawing.Point(3, 56);
            this.dgvPalletList.Name = "dgvPalletList";
            this.dgvPalletList.ReadOnly = true;
            this.dgvPalletList.Size = new System.Drawing.Size(857, 370);
            this.dgvPalletList.TabIndex = 0;
            // 
            // grpbEmpty
            // 
            this.grpbEmpty.Location = new System.Drawing.Point(0, 503);
            this.grpbEmpty.Name = "grpbEmpty";
            this.grpbEmpty.Size = new System.Drawing.Size(793, 41);
            this.grpbEmpty.TabIndex = 8;
            this.grpbEmpty.TabStop = false;
            // 
            // grpbActions
            // 
            this.grpbActions.Controls.Add(this.btnExit);
            this.grpbActions.Controls.Add(this.btnReport);
            this.grpbActions.Location = new System.Drawing.Point(797, 503);
            this.grpbActions.Name = "grpbActions";
            this.grpbActions.Size = new System.Drawing.Size(63, 41);
            this.grpbActions.TabIndex = 7;
            this.grpbActions.TabStop = false;
            // 
            // txtPalletCode
            // 
            this.txtPalletCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalletCode.Location = new System.Drawing.Point(287, 16);
            this.txtPalletCode.Name = "txtPalletCode";
            this.txtPalletCode.Size = new System.Drawing.Size(450, 30);
            this.txtPalletCode.TabIndex = 20;
            this.txtPalletCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPalletCode_KeyDown);
            // 
            // lblPalletCode
            // 
            this.lblPalletCode.AutoSize = true;
            this.lblPalletCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalletCode.Location = new System.Drawing.Point(126, 19);
            this.lblPalletCode.Name = "lblPalletCode";
            this.lblPalletCode.Size = new System.Drawing.Size(155, 25);
            this.lblPalletCode.TabIndex = 19;
            this.lblPalletCode.Text = "Código de Pallet";
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmNumber
            // 
            this.clmNumber.HeaderText = "Nro.";
            this.clmNumber.Name = "clmNumber";
            this.clmNumber.ReadOnly = true;
            this.clmNumber.Width = 50;
            // 
            // clmProductCode
            // 
            this.clmProductCode.HeaderText = "Producto";
            this.clmProductCode.Name = "clmProductCode";
            this.clmProductCode.ReadOnly = true;
            this.clmProductCode.Width = 120;
            // 
            // clmID
            // 
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            this.clmID.Width = 70;
            // 
            // clmCode
            // 
            this.clmCode.HeaderText = "Código";
            this.clmCode.Name = "clmCode";
            this.clmCode.ReadOnly = true;
            this.clmCode.Width = 120;
            // 
            // clmSalesOrderNumber
            // 
            this.clmSalesOrderNumber.HeaderText = "Orden";
            this.clmSalesOrderNumber.Name = "clmSalesOrderNumber";
            this.clmSalesOrderNumber.ReadOnly = true;
            this.clmSalesOrderNumber.Width = 80;
            // 
            // clmWidth
            // 
            this.clmWidth.HeaderText = "Ancho";
            this.clmWidth.Name = "clmWidth";
            this.clmWidth.ReadOnly = true;
            this.clmWidth.Width = 80;
            // 
            // clmNetWeight
            // 
            this.clmNetWeight.HeaderText = "Peso Neto";
            this.clmNetWeight.Name = "clmNetWeight";
            this.clmNetWeight.ReadOnly = true;
            this.clmNetWeight.Width = 90;
            // 
            // clmGrossWeight
            // 
            this.clmGrossWeight.HeaderText = "Peso Bruto";
            this.clmGrossWeight.Name = "clmGrossWeight";
            this.clmGrossWeight.ReadOnly = true;
            this.clmGrossWeight.Width = 90;
            // 
            // clmAction
            // 
            this.clmAction.HeaderText = "Despacho";
            this.clmAction.Name = "clmAction";
            this.clmAction.ReadOnly = true;
            this.clmAction.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmAction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmAction.Width = 80;
            // 
            // clmActionToDo
            // 
            this.clmActionToDo.HeaderText = "action";
            this.clmActionToDo.Name = "clmActionToDo";
            this.clmActionToDo.ReadOnly = true;
            this.clmActionToDo.Visible = false;
            // 
            // btnProcess
            // 
            this.btnProcess.Image = global::BPS.Properties.Resources.send;
            this.btnProcess.Location = new System.Drawing.Point(818, 13);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(40, 40);
            this.btnProcess.TabIndex = 21;
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnExit.Location = new System.Drawing.Point(31, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackgroundImage = global::BPS.Properties.Resources.report;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReport.Location = new System.Drawing.Point(6, 12);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(25, 25);
            this.btnReport.TabIndex = 0;
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // frmPalletShipping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(863, 545);
            this.Controls.Add(this.grpPalletList);
            this.Controls.Add(this.grpInfoDate);
            this.Controls.Add(this.grpbEmpty);
            this.Controls.Add(this.grpbActions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPalletShipping";
            this.Text = "Listado de pallets completas";
            this.Load += new System.EventHandler(this.frmPalletList_Load);
            this.grpInfoDate.ResumeLayout(false);
            this.grpInfoDate.PerformLayout();
            this.grpPalletList.ResumeLayout(false);
            this.grpPalletList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletList)).EndInit();
            this.grpbActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInfoDate;
        private System.Windows.Forms.GroupBox grpPalletList;
        private System.Windows.Forms.DataGridView dgvPalletList;
        private System.Windows.Forms.GroupBox grpbEmpty;
        private System.Windows.Forms.GroupBox grpbActions;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerNameLabel;
        private System.Windows.Forms.Label lblNumberLabel;
        private System.Windows.Forms.ComboBox cmbTransport;
        private System.Windows.Forms.Label lblTransport;
        private System.Windows.Forms.TextBox txtPalletCode;
        private System.Windows.Forms.Label lblPalletCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNetWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGrossWeight;
        private System.Windows.Forms.DataGridViewImageColumn clmAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmActionToDo;
        private System.Windows.Forms.Button btnProcess;
    }
}