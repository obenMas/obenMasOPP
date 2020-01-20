namespace BPS
{
    partial class frmVapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVapor));
            this.grpbDataVapor = new System.Windows.Forms.GroupBox();
            this.lblCutOffDate = new System.Windows.Forms.Label();
            this.lblCutOff = new System.Windows.Forms.Label();
            this.lblestimateddate = new System.Windows.Forms.Label();
            this.cmbShippingName = new System.Windows.Forms.ComboBox();
            this.dtpEstimateDate = new System.Windows.Forms.DateTimePicker();
            this.lblShippingName = new System.Windows.Forms.Label();
            this.ttpVapor = new System.Windows.Forms.ToolTip(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpbEmpty = new System.Windows.Forms.GroupBox();
            this.grpbPanelvapor = new System.Windows.Forms.GroupBox();
            this.grpbDetalisVapor = new System.Windows.Forms.GroupBox();
            this.dgvVapor = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmShippingBuilding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmestimateddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCutoff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dtpCuttoff = new System.Windows.Forms.DateTimePicker();
            this.grpbDataVapor.SuspendLayout();
            this.grpbPanelvapor.SuspendLayout();
            this.grpbDetalisVapor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVapor)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbDataVapor
            // 
            this.grpbDataVapor.Controls.Add(this.dtpCuttoff);
            this.grpbDataVapor.Controls.Add(this.lblCutOffDate);
            this.grpbDataVapor.Controls.Add(this.lblCutOff);
            this.grpbDataVapor.Controls.Add(this.lblestimateddate);
            this.grpbDataVapor.Controls.Add(this.cmbShippingName);
            this.grpbDataVapor.Controls.Add(this.dtpEstimateDate);
            this.grpbDataVapor.Controls.Add(this.lblShippingName);
            this.grpbDataVapor.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbDataVapor.Location = new System.Drawing.Point(0, 0);
            this.grpbDataVapor.Name = "grpbDataVapor";
            this.grpbDataVapor.Size = new System.Drawing.Size(590, 109);
            this.grpbDataVapor.TabIndex = 0;
            this.grpbDataVapor.TabStop = false;
            this.grpbDataVapor.Text = "Datos";
            // 
            // lblCutOffDate
            // 
            this.lblCutOffDate.AutoSize = true;
            this.lblCutOffDate.Location = new System.Drawing.Point(256, 75);
            this.lblCutOffDate.Name = "lblCutOffDate";
            this.lblCutOffDate.Size = new System.Drawing.Size(0, 15);
            this.lblCutOffDate.TabIndex = 5;
            // 
            // lblCutOff
            // 
            this.lblCutOff.AutoSize = true;
            this.lblCutOff.Location = new System.Drawing.Point(203, 75);
            this.lblCutOff.Name = "lblCutOff";
            this.lblCutOff.Size = new System.Drawing.Size(47, 15);
            this.lblCutOff.TabIndex = 4;
            this.lblCutOff.Text = "Cut off :";
            // 
            // lblestimateddate
            // 
            this.lblestimateddate.AutoSize = true;
            this.lblestimateddate.Location = new System.Drawing.Point(83, 50);
            this.lblestimateddate.Name = "lblestimateddate";
            this.lblestimateddate.Size = new System.Drawing.Size(167, 15);
            this.lblestimateddate.TabIndex = 3;
            this.lblestimateddate.Text = "Fecha Estimada de Llegada :";
            // 
            // cmbShippingName
            // 
            this.cmbShippingName.FormattingEnabled = true;
            this.cmbShippingName.Location = new System.Drawing.Point(256, 18);
            this.cmbShippingName.Name = "cmbShippingName";
            this.cmbShippingName.Size = new System.Drawing.Size(252, 23);
            this.cmbShippingName.TabIndex = 1;
            this.cmbShippingName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbShippingName_KeyDown);
            // 
            // dtpEstimateDate
            // 
            this.dtpEstimateDate.Location = new System.Drawing.Point(256, 47);
            this.dtpEstimateDate.Name = "dtpEstimateDate";
            this.dtpEstimateDate.Size = new System.Drawing.Size(252, 21);
            this.dtpEstimateDate.TabIndex = 2;
            this.dtpEstimateDate.ValueChanged += new System.EventHandler(this.dtpEstimateDate_ValueChanged);
            // 
            // lblShippingName
            // 
            this.lblShippingName.AutoSize = true;
            this.lblShippingName.Location = new System.Drawing.Point(195, 21);
            this.lblShippingName.Name = "lblShippingName";
            this.lblShippingName.Size = new System.Drawing.Size(55, 15);
            this.lblShippingName.TabIndex = 0;
            this.lblShippingName.Text = "Naviera :";
            // 
            // btnExit
            // 
            this.btnExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnExit.Location = new System.Drawing.Point(64, 14);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 2;
            this.ttpVapor.SetToolTip(this.btnExit, "Salir");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::BPS.Properties.Resources.cancel;
            this.btnCancel.Location = new System.Drawing.Point(34, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCancel.TabIndex = 1;
            this.ttpVapor.SetToolTip(this.btnCancel, "Cancelar");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::BPS.Properties.Resources.add1;
            this.btnAdd.Location = new System.Drawing.Point(5, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 25);
            this.btnAdd.TabIndex = 0;
            this.ttpVapor.SetToolTip(this.btnAdd, "Agregar");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpbEmpty
            // 
            this.grpbEmpty.Location = new System.Drawing.Point(0, 104);
            this.grpbEmpty.Name = "grpbEmpty";
            this.grpbEmpty.Size = new System.Drawing.Size(494, 44);
            this.grpbEmpty.TabIndex = 6;
            this.grpbEmpty.TabStop = false;
            // 
            // grpbPanelvapor
            // 
            this.grpbPanelvapor.Controls.Add(this.btnExit);
            this.grpbPanelvapor.Controls.Add(this.btnCancel);
            this.grpbPanelvapor.Controls.Add(this.btnAdd);
            this.grpbPanelvapor.Location = new System.Drawing.Point(497, 104);
            this.grpbPanelvapor.Name = "grpbPanelvapor";
            this.grpbPanelvapor.Size = new System.Drawing.Size(92, 44);
            this.grpbPanelvapor.TabIndex = 7;
            this.grpbPanelvapor.TabStop = false;
            // 
            // grpbDetalisVapor
            // 
            this.grpbDetalisVapor.Controls.Add(this.dgvVapor);
            this.grpbDetalisVapor.Location = new System.Drawing.Point(0, 146);
            this.grpbDetalisVapor.Name = "grpbDetalisVapor";
            this.grpbDetalisVapor.Size = new System.Drawing.Size(589, 270);
            this.grpbDetalisVapor.TabIndex = 8;
            this.grpbDetalisVapor.TabStop = false;
            this.grpbDetalisVapor.Text = "Listado";
            // 
            // dgvVapor
            // 
            this.dgvVapor.AllowUserToAddRows = false;
            this.dgvVapor.AllowUserToDeleteRows = false;
            this.dgvVapor.AllowUserToOrderColumns = true;
            this.dgvVapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVapor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmShippingBuilding,
            this.clmestimateddate,
            this.clmCutoff,
            this.clmEdit,
            this.clmDelete});
            this.dgvVapor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVapor.Location = new System.Drawing.Point(3, 17);
            this.dgvVapor.Name = "dgvVapor";
            this.dgvVapor.ReadOnly = true;
            this.dgvVapor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVapor.Size = new System.Drawing.Size(583, 250);
            this.dgvVapor.TabIndex = 0;
            this.dgvVapor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVapor_CellClick);
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmShippingBuilding
            // 
            this.clmShippingBuilding.HeaderText = "Naviera";
            this.clmShippingBuilding.Name = "clmShippingBuilding";
            this.clmShippingBuilding.ReadOnly = true;
            this.clmShippingBuilding.Width = 200;
            // 
            // clmestimateddate
            // 
            this.clmestimateddate.HeaderText = "Fecha E. Llegada";
            this.clmestimateddate.Name = "clmestimateddate";
            this.clmestimateddate.ReadOnly = true;
            this.clmestimateddate.Width = 150;
            // 
            // clmCutoff
            // 
            this.clmCutoff.HeaderText = "Cut Off";
            this.clmCutoff.Name = "clmCutoff";
            this.clmCutoff.ReadOnly = true;
            this.clmCutoff.Width = 120;
            // 
            // clmEdit
            // 
            this.clmEdit.HeaderText = "";
            this.clmEdit.Name = "clmEdit";
            this.clmEdit.ReadOnly = true;
            this.clmEdit.Width = 30;
            // 
            // clmDelete
            // 
            this.clmDelete.HeaderText = "";
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.ReadOnly = true;
            this.clmDelete.Width = 30;
            // 
            // dtpCuttoff
            // 
            this.dtpCuttoff.Location = new System.Drawing.Point(256, 72);
            this.dtpCuttoff.Name = "dtpCuttoff";
            this.dtpCuttoff.Size = new System.Drawing.Size(252, 21);
            this.dtpCuttoff.TabIndex = 6;
            // 
            // frmVapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(590, 420);
            this.Controls.Add(this.grpbDataVapor);
            this.Controls.Add(this.grpbEmpty);
            this.Controls.Add(this.grpbPanelvapor);
            this.Controls.Add(this.grpbDetalisVapor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVapor";
            this.Text = "Fechas de Vapores";
            this.Load += new System.EventHandler(this.frmVapor_Load);
            this.grpbDataVapor.ResumeLayout(false);
            this.grpbDataVapor.PerformLayout();
            this.grpbPanelvapor.ResumeLayout(false);
            this.grpbDetalisVapor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVapor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbDataVapor;
        private System.Windows.Forms.Label lblCutOffDate;
        private System.Windows.Forms.Label lblCutOff;
        private System.Windows.Forms.Label lblestimateddate;
        private System.Windows.Forms.ComboBox cmbShippingName;
        private System.Windows.Forms.DateTimePicker dtpEstimateDate;
        private System.Windows.Forms.Label lblShippingName;
        private System.Windows.Forms.ToolTip ttpVapor;
        private System.Windows.Forms.GroupBox grpbEmpty;
        private System.Windows.Forms.GroupBox grpbPanelvapor;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpbDetalisVapor;
        private System.Windows.Forms.DataGridView dgvVapor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmShippingBuilding;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmestimateddate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCutoff;
        private System.Windows.Forms.DataGridViewImageColumn clmEdit;
        private System.Windows.Forms.DataGridViewImageColumn clmDelete;
        private System.Windows.Forms.DateTimePicker dtpCuttoff;
    }
}