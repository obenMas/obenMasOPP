namespace BPS
{
    partial class frmChangeCellar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeOrigin));
            this.grpbEmployee = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPalletOrigin = new System.Windows.Forms.DataGridView();
            this.clmcodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcellarname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnetweigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmpalbob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbPallet = new System.Windows.Forms.GroupBox();
            this.lblid = new System.Windows.Forms.Label();
            this.grpbTransfer = new System.Windows.Forms.GroupBox();
            this.grpbTrans = new System.Windows.Forms.GroupBox();
            this.dgvTransfer = new System.Windows.Forms.DataGridView();
            this.clmcodsecpallettransfer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcodeccellartransfer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcodetransfer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcellartransfer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnetweigthtransfer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmpalbobtransfer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmordertransfer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmcustomertransfer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbCellar = new System.Windows.Forms.ComboBox();
            this.lblPlantLabel = new System.Windows.Forms.Label();
            this.chkEnableTransfer = new System.Windows.Forms.CheckBox();
            this.grpbTransferFinally = new System.Windows.Forms.GroupBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ttpTransfer = new System.Windows.Forms.ToolTip(this.components);
            this.txtid = new System.Windows.Forms.TextBox();
            this.grpbEmployee.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletOrigin)).BeginInit();
            this.grpbPallet.SuspendLayout();
            this.grpbTransfer.SuspendLayout();
            this.grpbTrans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransfer)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grpbTransferFinally.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbEmployee
            // 
            this.grpbEmployee.Controls.Add(this.groupBox1);
            this.grpbEmployee.Controls.Add(this.grpbPallet);
            this.grpbEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbEmployee.Location = new System.Drawing.Point(0, 0);
            this.grpbEmployee.Name = "grpbEmployee";
            this.grpbEmployee.Size = new System.Drawing.Size(578, 572);
            this.grpbEmployee.TabIndex = 0;
            this.grpbEmployee.TabStop = false;
            this.grpbEmployee.Text = "Bodega Orgien";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPalletOrigin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 500);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // dgvPalletOrigin
            // 
            this.dgvPalletOrigin.AllowUserToAddRows = false;
            this.dgvPalletOrigin.AllowUserToDeleteRows = false;
            this.dgvPalletOrigin.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPalletOrigin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPalletOrigin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalletOrigin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmcodsec,
            this.clmcode,
            this.clmcellarname,
            this.clmnetweigth,
            this.clmpalbob,
            this.clmnumber,
            this.clmcustomer});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPalletOrigin.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPalletOrigin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPalletOrigin.Location = new System.Drawing.Point(3, 16);
            this.dgvPalletOrigin.MultiSelect = false;
            this.dgvPalletOrigin.Name = "dgvPalletOrigin";
            this.dgvPalletOrigin.ReadOnly = true;
            this.dgvPalletOrigin.RowHeadersWidth = 21;
            this.dgvPalletOrigin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPalletOrigin.Size = new System.Drawing.Size(566, 481);
            this.dgvPalletOrigin.TabIndex = 0;
            this.dgvPalletOrigin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvPalletOrigin_MouseMove);
            // 
            // clmcodsec
            // 
            this.clmcodsec.HeaderText = "codsec";
            this.clmcodsec.Name = "clmcodsec";
            this.clmcodsec.ReadOnly = true;
            this.clmcodsec.Visible = false;
            // 
            // clmcode
            // 
            this.clmcode.HeaderText = "Pallet";
            this.clmcode.Name = "clmcode";
            this.clmcode.ReadOnly = true;
            this.clmcode.Width = 130;
            // 
            // clmcellarname
            // 
            this.clmcellarname.HeaderText = "Bodega";
            this.clmcellarname.Name = "clmcellarname";
            this.clmcellarname.ReadOnly = true;
            // 
            // clmnetweigth
            // 
            this.clmnetweigth.HeaderText = "P.Neto";
            this.clmnetweigth.Name = "clmnetweigth";
            this.clmnetweigth.ReadOnly = true;
            this.clmnetweigth.Width = 50;
            // 
            // clmpalbob
            // 
            this.clmpalbob.HeaderText = "P - B";
            this.clmpalbob.Name = "clmpalbob";
            this.clmpalbob.ReadOnly = true;
            this.clmpalbob.Width = 60;
            // 
            // clmnumber
            // 
            this.clmnumber.HeaderText = "Orden";
            this.clmnumber.Name = "clmnumber";
            this.clmnumber.ReadOnly = true;
            this.clmnumber.Width = 60;
            // 
            // clmcustomer
            // 
            this.clmcustomer.HeaderText = "Cliente";
            this.clmcustomer.Name = "clmcustomer";
            this.clmcustomer.ReadOnly = true;
            this.clmcustomer.Width = 130;
            // 
            // grpbPallet
            // 
            this.grpbPallet.Controls.Add(this.lblid);
            this.grpbPallet.Controls.Add(this.txtid);
            this.grpbPallet.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbPallet.Location = new System.Drawing.Point(3, 17);
            this.grpbPallet.Name = "grpbPallet";
            this.grpbPallet.Size = new System.Drawing.Size(572, 52);
            this.grpbPallet.TabIndex = 1;
            this.grpbPallet.TabStop = false;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(20, 18);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(54, 20);
            this.lblid.TabIndex = 7;
            this.lblid.Text = "Pallet";
            // 
            // grpbTransfer
            // 
            this.grpbTransfer.Controls.Add(this.grpbTrans);
            this.grpbTransfer.Controls.Add(this.groupBox2);
            this.grpbTransfer.Controls.Add(this.grpbTransferFinally);
            this.grpbTransfer.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpbTransfer.Location = new System.Drawing.Point(578, 0);
            this.grpbTransfer.Name = "grpbTransfer";
            this.grpbTransfer.Size = new System.Drawing.Size(467, 572);
            this.grpbTransfer.TabIndex = 1;
            this.grpbTransfer.TabStop = false;
            this.grpbTransfer.Text = "Bodega Destino";
            // 
            // grpbTrans
            // 
            this.grpbTrans.Controls.Add(this.dgvTransfer);
            this.grpbTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbTrans.Location = new System.Drawing.Point(3, 63);
            this.grpbTrans.Name = "grpbTrans";
            this.grpbTrans.Size = new System.Drawing.Size(461, 467);
            this.grpbTrans.TabIndex = 10;
            this.grpbTrans.TabStop = false;
            // 
            // dgvTransfer
            // 
            this.dgvTransfer.AllowDrop = true;
            this.dgvTransfer.AllowUserToAddRows = false;
            this.dgvTransfer.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransfer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTransfer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransfer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmcodsecpallettransfer,
            this.clmcodeccellartransfer,
            this.clmcodetransfer,
            this.clmcellartransfer,
            this.clmnetweigthtransfer,
            this.clmpalbobtransfer,
            this.clmordertransfer,
            this.clmdelete,
            this.clmcustomertransfer});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransfer.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTransfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransfer.Location = new System.Drawing.Point(3, 16);
            this.dgvTransfer.Name = "dgvTransfer";
            this.dgvTransfer.ReadOnly = true;
            this.dgvTransfer.RowHeadersWidth = 21;
            this.dgvTransfer.Size = new System.Drawing.Size(455, 448);
            this.dgvTransfer.TabIndex = 1;
            this.dgvTransfer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransfer_CellClick);
            this.dgvTransfer.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvTransfer_DragDrop);
            this.dgvTransfer.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvTransfer_DragEnter);
            // 
            // clmcodsecpallettransfer
            // 
            this.clmcodsecpallettransfer.HeaderText = "codsecpallet";
            this.clmcodsecpallettransfer.Name = "clmcodsecpallettransfer";
            this.clmcodsecpallettransfer.ReadOnly = true;
            this.clmcodsecpallettransfer.Visible = false;
            // 
            // clmcodeccellartransfer
            // 
            this.clmcodeccellartransfer.HeaderText = "codseccellar";
            this.clmcodeccellartransfer.Name = "clmcodeccellartransfer";
            this.clmcodeccellartransfer.ReadOnly = true;
            this.clmcodeccellartransfer.Visible = false;
            // 
            // clmcodetransfer
            // 
            this.clmcodetransfer.HeaderText = "Pallet";
            this.clmcodetransfer.Name = "clmcodetransfer";
            this.clmcodetransfer.ReadOnly = true;
            this.clmcodetransfer.Width = 130;
            // 
            // clmcellartransfer
            // 
            this.clmcellartransfer.HeaderText = "Bodega";
            this.clmcellartransfer.Name = "clmcellartransfer";
            this.clmcellartransfer.ReadOnly = true;
            // 
            // clmnetweigthtransfer
            // 
            this.clmnetweigthtransfer.HeaderText = "P.Neto";
            this.clmnetweigthtransfer.Name = "clmnetweigthtransfer";
            this.clmnetweigthtransfer.ReadOnly = true;
            this.clmnetweigthtransfer.Width = 60;
            // 
            // clmpalbobtransfer
            // 
            this.clmpalbobtransfer.HeaderText = "P - B";
            this.clmpalbobtransfer.Name = "clmpalbobtransfer";
            this.clmpalbobtransfer.ReadOnly = true;
            this.clmpalbobtransfer.Width = 55;
            // 
            // clmordertransfer
            // 
            this.clmordertransfer.HeaderText = "Orden";
            this.clmordertransfer.Name = "clmordertransfer";
            this.clmordertransfer.ReadOnly = true;
            this.clmordertransfer.Width = 50;
            // 
            // clmdelete
            // 
            this.clmdelete.HeaderText = "";
            this.clmdelete.Name = "clmdelete";
            this.clmdelete.ReadOnly = true;
            this.clmdelete.Width = 30;
            // 
            // clmcustomertransfer
            // 
            this.clmcustomertransfer.HeaderText = "Cliente";
            this.clmcustomertransfer.Name = "clmcustomertransfer";
            this.clmcustomertransfer.ReadOnly = true;
            this.clmcustomertransfer.Width = 80;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbCellar);
            this.groupBox2.Controls.Add(this.lblPlantLabel);
            this.groupBox2.Controls.Add(this.chkEnableTransfer);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 46);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // cmbCellar
            // 
            this.cmbCellar.FormattingEnabled = true;
            this.cmbCellar.Location = new System.Drawing.Point(111, 14);
            this.cmbCellar.Name = "cmbCellar";
            this.cmbCellar.Size = new System.Drawing.Size(260, 23);
            this.cmbCellar.TabIndex = 2;
            this.cmbCellar.SelectedIndexChanged += new System.EventHandler(this.cmbCompanyTransfer_SelectedIndexChanged);
            // 
            // lblPlantLabel
            // 
            this.lblPlantLabel.AutoSize = true;
            this.lblPlantLabel.Location = new System.Drawing.Point(57, 17);
            this.lblPlantLabel.Name = "lblPlantLabel";
            this.lblPlantLabel.Size = new System.Drawing.Size(50, 15);
            this.lblPlantLabel.TabIndex = 3;
            this.lblPlantLabel.Text = "Bodega";
            // 
            // chkEnableTransfer
            // 
            this.chkEnableTransfer.AutoSize = true;
            this.chkEnableTransfer.Location = new System.Drawing.Point(416, 20);
            this.chkEnableTransfer.Name = "chkEnableTransfer";
            this.chkEnableTransfer.Size = new System.Drawing.Size(15, 14);
            this.chkEnableTransfer.TabIndex = 0;
            this.chkEnableTransfer.UseVisualStyleBackColor = true;
            this.chkEnableTransfer.CheckedChanged += new System.EventHandler(this.chkEnableTransfer_CheckedChanged);
            // 
            // grpbTransferFinally
            // 
            this.grpbTransferFinally.Controls.Add(this.btnTransfer);
            this.grpbTransferFinally.Controls.Add(this.btnCancel);
            this.grpbTransferFinally.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbTransferFinally.Location = new System.Drawing.Point(3, 530);
            this.grpbTransferFinally.Name = "grpbTransferFinally";
            this.grpbTransferFinally.Size = new System.Drawing.Size(461, 39);
            this.grpbTransferFinally.TabIndex = 8;
            this.grpbTransferFinally.TabStop = false;
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTransfer.Image = global::BPS.Properties.Resources.arrow_refresh_small;
            this.btnTransfer.Location = new System.Drawing.Point(433, 10);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(25, 25);
            this.btnTransfer.TabIndex = 7;
            this.ttpTransfer.SetToolTip(this.btnTransfer, "Transferir Pallets");
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.Image = global::BPS.Properties.Resources.cancel;
            this.btnCancel.Location = new System.Drawing.Point(406, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCancel.TabIndex = 6;
            this.ttpTransfer.SetToolTip(this.btnCancel, "Cancelar Transferencia");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(80, 11);
            this.txtid.MaxLength = 100;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(473, 35);
            this.txtid.TabIndex = 6;
            this.txtid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
            // 
            // frmChangeCellar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1045, 572);
            this.Controls.Add(this.grpbEmployee);
            this.Controls.Add(this.grpbTransfer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChangeCellar";
            this.Text = "Cambio de Bodega";
            this.Load += new System.EventHandler(this.frmChangeCellar_Load);
            this.grpbEmployee.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletOrigin)).EndInit();
            this.grpbPallet.ResumeLayout(false);
            this.grpbPallet.PerformLayout();
            this.grpbTransfer.ResumeLayout(false);
            this.grpbTrans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransfer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpbTransferFinally.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbEmployee;
        private System.Windows.Forms.GroupBox grpbTransfer;
        private System.Windows.Forms.CheckBox chkEnableTransfer;
        private System.Windows.Forms.DataGridView dgvPalletOrigin;
        private System.Windows.Forms.Label lblPlantLabel;
        private System.Windows.Forms.ComboBox cmbCellar;
        private System.Windows.Forms.DataGridView dgvTransfer;
        private System.Windows.Forms.GroupBox grpbPallet;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.GroupBox grpbTransferFinally;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolTip ttpTransfer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcellarname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnetweigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmpalbob;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcustomer;
        private System.Windows.Forms.GroupBox grpbTrans;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcodsecpallettransfer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcodeccellartransfer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcodetransfer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcellartransfer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnetweigthtransfer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmpalbobtransfer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmordertransfer;
        private System.Windows.Forms.DataGridViewImageColumn clmdelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcustomertransfer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtid;
    }
}