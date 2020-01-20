namespace BPS
{
    partial class frmVaporesComplete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVaporesComplete));
            this.grpbVaporList = new System.Windows.Forms.GroupBox();
            this.dgvVapor = new System.Windows.Forms.DataGridView();
            this.clmcodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmestimatedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcutoff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbEstimateDate = new System.Windows.Forms.GroupBox();
            this.chkEstimateDate = new System.Windows.Forms.CheckBox();
            this.dtpEstimdateDate = new System.Windows.Forms.DateTimePicker();
            this.lblEstimateDate = new System.Windows.Forms.Label();
            this.grpbShippingBuilding = new System.Windows.Forms.GroupBox();
            this.chkShippingBuilding = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.cmbShippingBuilding = new System.Windows.Forms.ComboBox();
            this.lblShippingBuilding = new System.Windows.Forms.Label();
            this.grpbMainCoilFiltersBar = new System.Windows.Forms.GroupBox();
            this.btnVaporClearFilters = new System.Windows.Forms.Button();
            this.btnVaporFilters = new System.Windows.Forms.Button();
            this.grpbVaporList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVapor)).BeginInit();
            this.grpbEstimateDate.SuspendLayout();
            this.grpbShippingBuilding.SuspendLayout();
            this.grpbMainCoilFiltersBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbVaporList
            // 
            this.grpbVaporList.Controls.Add(this.dgvVapor);
            this.grpbVaporList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbVaporList.Location = new System.Drawing.Point(0, 0);
            this.grpbVaporList.Name = "grpbVaporList";
            this.grpbVaporList.Size = new System.Drawing.Size(584, 404);
            this.grpbVaporList.TabIndex = 0;
            this.grpbVaporList.TabStop = false;
            this.grpbVaporList.Text = "Listado";
            // 
            // dgvVapor
            // 
            this.dgvVapor.AllowUserToAddRows = false;
            this.dgvVapor.AllowUserToDeleteRows = false;
            this.dgvVapor.AllowUserToOrderColumns = true;
            this.dgvVapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVapor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmcodsec,
            this.clmname,
            this.clmestimatedate,
            this.clmcutoff});
            this.dgvVapor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVapor.Location = new System.Drawing.Point(3, 17);
            this.dgvVapor.Name = "dgvVapor";
            this.dgvVapor.ReadOnly = true;
            this.dgvVapor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVapor.Size = new System.Drawing.Size(578, 384);
            this.dgvVapor.TabIndex = 0;
            this.dgvVapor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVapor_CellDoubleClick);
            // 
            // clmcodsec
            // 
            this.clmcodsec.HeaderText = "codsec";
            this.clmcodsec.Name = "clmcodsec";
            this.clmcodsec.ReadOnly = true;
            this.clmcodsec.Visible = false;
            // 
            // clmname
            // 
            this.clmname.HeaderText = "Naviera";
            this.clmname.Name = "clmname";
            this.clmname.ReadOnly = true;
            this.clmname.Width = 200;
            // 
            // clmestimatedate
            // 
            this.clmestimatedate.HeaderText = "F. Llegada";
            this.clmestimatedate.Name = "clmestimatedate";
            this.clmestimatedate.ReadOnly = true;
            this.clmestimatedate.Width = 150;
            // 
            // clmcutoff
            // 
            this.clmcutoff.HeaderText = "Cut Off";
            this.clmcutoff.Name = "clmcutoff";
            this.clmcutoff.ReadOnly = true;
            this.clmcutoff.Width = 150;
            // 
            // grpbEstimateDate
            // 
            this.grpbEstimateDate.Controls.Add(this.chkEstimateDate);
            this.grpbEstimateDate.Controls.Add(this.dtpEstimdateDate);
            this.grpbEstimateDate.Controls.Add(this.lblEstimateDate);
            this.grpbEstimateDate.Enabled = false;
            this.grpbEstimateDate.Location = new System.Drawing.Point(297, 410);
            this.grpbEstimateDate.Name = "grpbEstimateDate";
            this.grpbEstimateDate.Size = new System.Drawing.Size(244, 72);
            this.grpbEstimateDate.TabIndex = 22;
            this.grpbEstimateDate.TabStop = false;
            // 
            // chkEstimateDate
            // 
            this.chkEstimateDate.Location = new System.Drawing.Point(6, -1);
            this.chkEstimateDate.Name = "chkEstimateDate";
            this.chkEstimateDate.Size = new System.Drawing.Size(84, 19);
            this.chkEstimateDate.TabIndex = 24;
            this.chkEstimateDate.Text = "F. Llegada";
            this.chkEstimateDate.UseVisualStyleBackColor = true;
            this.chkEstimateDate.CheckedChanged += new System.EventHandler(this.chkEstimateDate_CheckedChanged);
            // 
            // dtpEstimdateDate
            // 
            this.dtpEstimdateDate.CustomFormat = "dd MMMM yyyy";
            this.dtpEstimdateDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEstimdateDate.Location = new System.Drawing.Point(87, 26);
            this.dtpEstimdateDate.Name = "dtpEstimdateDate";
            this.dtpEstimdateDate.Size = new System.Drawing.Size(148, 21);
            this.dtpEstimdateDate.TabIndex = 7;
            // 
            // lblEstimateDate
            // 
            this.lblEstimateDate.AutoSize = true;
            this.lblEstimateDate.Location = new System.Drawing.Point(10, 31);
            this.lblEstimateDate.Name = "lblEstimateDate";
            this.lblEstimateDate.Size = new System.Drawing.Size(71, 15);
            this.lblEstimateDate.TabIndex = 6;
            this.lblEstimateDate.Text = "F. Llegada :";
            // 
            // grpbShippingBuilding
            // 
            this.grpbShippingBuilding.Controls.Add(this.chkShippingBuilding);
            this.grpbShippingBuilding.Controls.Add(this.checkBox3);
            this.grpbShippingBuilding.Controls.Add(this.cmbShippingBuilding);
            this.grpbShippingBuilding.Controls.Add(this.lblShippingBuilding);
            this.grpbShippingBuilding.Enabled = false;
            this.grpbShippingBuilding.Location = new System.Drawing.Point(0, 410);
            this.grpbShippingBuilding.Name = "grpbShippingBuilding";
            this.grpbShippingBuilding.Size = new System.Drawing.Size(293, 72);
            this.grpbShippingBuilding.TabIndex = 21;
            this.grpbShippingBuilding.TabStop = false;
            // 
            // chkShippingBuilding
            // 
            this.chkShippingBuilding.Location = new System.Drawing.Point(6, -2);
            this.chkShippingBuilding.Name = "chkShippingBuilding";
            this.chkShippingBuilding.Size = new System.Drawing.Size(71, 19);
            this.chkShippingBuilding.TabIndex = 23;
            this.chkShippingBuilding.Text = "Naviera";
            this.chkShippingBuilding.UseVisualStyleBackColor = true;
            this.chkShippingBuilding.CheckedChanged += new System.EventHandler(this.chkShippingBuilding_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(496, 0);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "checkBox1";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // cmbShippingBuilding
            // 
            this.cmbShippingBuilding.FormattingEnabled = true;
            this.cmbShippingBuilding.Location = new System.Drawing.Point(67, 25);
            this.cmbShippingBuilding.Name = "cmbShippingBuilding";
            this.cmbShippingBuilding.Size = new System.Drawing.Size(219, 23);
            this.cmbShippingBuilding.TabIndex = 5;
            // 
            // lblShippingBuilding
            // 
            this.lblShippingBuilding.AutoSize = true;
            this.lblShippingBuilding.Location = new System.Drawing.Point(6, 28);
            this.lblShippingBuilding.Name = "lblShippingBuilding";
            this.lblShippingBuilding.Size = new System.Drawing.Size(55, 15);
            this.lblShippingBuilding.TabIndex = 4;
            this.lblShippingBuilding.Text = "Naviera :";
            // 
            // grpbMainCoilFiltersBar
            // 
            this.grpbMainCoilFiltersBar.Controls.Add(this.btnVaporClearFilters);
            this.grpbMainCoilFiltersBar.Controls.Add(this.btnVaporFilters);
            this.grpbMainCoilFiltersBar.Location = new System.Drawing.Point(543, 410);
            this.grpbMainCoilFiltersBar.Name = "grpbMainCoilFiltersBar";
            this.grpbMainCoilFiltersBar.Size = new System.Drawing.Size(39, 72);
            this.grpbMainCoilFiltersBar.TabIndex = 20;
            this.grpbMainCoilFiltersBar.TabStop = false;
            // 
            // btnVaporClearFilters
            // 
            this.btnVaporClearFilters.BackgroundImage = global::BPS.Properties.Resources.funnel_clear;
            this.btnVaporClearFilters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVaporClearFilters.Location = new System.Drawing.Point(6, 40);
            this.btnVaporClearFilters.Name = "btnVaporClearFilters";
            this.btnVaporClearFilters.Size = new System.Drawing.Size(25, 25);
            this.btnVaporClearFilters.TabIndex = 2;
            this.btnVaporClearFilters.UseVisualStyleBackColor = true;
            this.btnVaporClearFilters.Click += new System.EventHandler(this.btnVaporClearFilters_Click);
            // 
            // btnVaporFilters
            // 
            this.btnVaporFilters.BackgroundImage = global::BPS.Properties.Resources.funnel;
            this.btnVaporFilters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVaporFilters.Location = new System.Drawing.Point(6, 15);
            this.btnVaporFilters.Name = "btnVaporFilters";
            this.btnVaporFilters.Size = new System.Drawing.Size(25, 25);
            this.btnVaporFilters.TabIndex = 3;
            this.btnVaporFilters.UseVisualStyleBackColor = true;
            this.btnVaporFilters.Click += new System.EventHandler(this.btnVaporFilters_Click);
            // 
            // frmVaporesComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(584, 482);
            this.Controls.Add(this.grpbEstimateDate);
            this.Controls.Add(this.grpbShippingBuilding);
            this.Controls.Add(this.grpbMainCoilFiltersBar);
            this.Controls.Add(this.grpbVaporList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVaporesComplete";
            this.Text = "Vapores Disponibles";
            this.Load += new System.EventHandler(this.frmVaporesComplete_Load);
            this.grpbVaporList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVapor)).EndInit();
            this.grpbEstimateDate.ResumeLayout(false);
            this.grpbEstimateDate.PerformLayout();
            this.grpbShippingBuilding.ResumeLayout(false);
            this.grpbShippingBuilding.PerformLayout();
            this.grpbMainCoilFiltersBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbVaporList;
        private System.Windows.Forms.DataGridView dgvVapor;
        private System.Windows.Forms.GroupBox grpbEstimateDate;
        private System.Windows.Forms.DateTimePicker dtpEstimdateDate;
        private System.Windows.Forms.Label lblEstimateDate;
        private System.Windows.Forms.GroupBox grpbShippingBuilding;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ComboBox cmbShippingBuilding;
        private System.Windows.Forms.Label lblShippingBuilding;
        private System.Windows.Forms.GroupBox grpbMainCoilFiltersBar;
        private System.Windows.Forms.Button btnVaporClearFilters;
        private System.Windows.Forms.Button btnVaporFilters;
        private System.Windows.Forms.CheckBox chkEstimateDate;
        private System.Windows.Forms.CheckBox chkShippingBuilding;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmestimatedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcutoff;
    }
}