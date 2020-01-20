namespace BPS.Lite
{
    partial class frmDeadTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeadTime));
            this.grpbDeadTime = new System.Windows.Forms.GroupBox();
            this.dgvDeadTime = new System.Windows.Forms.DataGridView();
            this.clmdeadtimecodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdeadtimegroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdeadtimename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdeadtimeadd = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmdeadtimeedit = new System.Windows.Forms.DataGridViewImageColumn();
            this.grpbActions = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbTypeDeadTime = new System.Windows.Forms.ComboBox();
            this.lblTypeDeadTime = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpbDeadTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeadTime)).BeginInit();
            this.grpbActions.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbDeadTime
            // 
            this.grpbDeadTime.Controls.Add(this.dgvDeadTime);
            this.grpbDeadTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbDeadTime.Location = new System.Drawing.Point(0, 0);
            this.grpbDeadTime.Name = "grpbDeadTime";
            this.grpbDeadTime.Size = new System.Drawing.Size(667, 357);
            this.grpbDeadTime.TabIndex = 0;
            this.grpbDeadTime.TabStop = false;
            // 
            // dgvDeadTime
            // 
            this.dgvDeadTime.AllowUserToAddRows = false;
            this.dgvDeadTime.AllowUserToDeleteRows = false;
            this.dgvDeadTime.AllowUserToOrderColumns = true;
            this.dgvDeadTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeadTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmdeadtimecodsec,
            this.clmdeadtimegroup,
            this.clmdeadtimename,
            this.clmdeadtimeadd,
            this.clmdeadtimeedit});
            this.dgvDeadTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeadTime.Location = new System.Drawing.Point(3, 17);
            this.dgvDeadTime.Name = "dgvDeadTime";
            this.dgvDeadTime.ReadOnly = true;
            this.dgvDeadTime.RowHeadersWidth = 21;
            this.dgvDeadTime.Size = new System.Drawing.Size(661, 337);
            this.dgvDeadTime.TabIndex = 0;
            this.dgvDeadTime.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeadTime_CellContentClick);
            // 
            // clmdeadtimecodsec
            // 
            this.clmdeadtimecodsec.HeaderText = "codsec";
            this.clmdeadtimecodsec.Name = "clmdeadtimecodsec";
            this.clmdeadtimecodsec.ReadOnly = true;
            this.clmdeadtimecodsec.Visible = false;
            // 
            // clmdeadtimegroup
            // 
            this.clmdeadtimegroup.HeaderText = "Tipo Tiempo Muerto";
            this.clmdeadtimegroup.Name = "clmdeadtimegroup";
            this.clmdeadtimegroup.ReadOnly = true;
            this.clmdeadtimegroup.Width = 250;
            // 
            // clmdeadtimename
            // 
            this.clmdeadtimename.HeaderText = "Tiempo Muerto";
            this.clmdeadtimename.Name = "clmdeadtimename";
            this.clmdeadtimename.ReadOnly = true;
            this.clmdeadtimename.Width = 250;
            // 
            // clmdeadtimeadd
            // 
            this.clmdeadtimeadd.HeaderText = "";
            this.clmdeadtimeadd.Name = "clmdeadtimeadd";
            this.clmdeadtimeadd.ReadOnly = true;
            this.clmdeadtimeadd.Width = 30;
            // 
            // clmdeadtimeedit
            // 
            this.clmdeadtimeedit.HeaderText = "";
            this.clmdeadtimeedit.Name = "clmdeadtimeedit";
            this.clmdeadtimeedit.ReadOnly = true;
            this.clmdeadtimeedit.Width = 30;
            // 
            // grpbActions
            // 
            this.grpbActions.Controls.Add(this.txtName);
            this.grpbActions.Controls.Add(this.lblName);
            this.grpbActions.Controls.Add(this.cmbTypeDeadTime);
            this.grpbActions.Controls.Add(this.lblTypeDeadTime);
            this.grpbActions.Controls.Add(this.groupBox3);
            this.grpbActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbActions.Location = new System.Drawing.Point(0, 357);
            this.grpbActions.Name = "grpbActions";
            this.grpbActions.Size = new System.Drawing.Size(667, 123);
            this.grpbActions.TabIndex = 1;
            this.grpbActions.TabStop = false;
            this.grpbActions.Text = "Tiempos Muertos";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(235, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(320, 21);
            this.txtName.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(138, 52);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(91, 15);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Tiempo Muerto";
            // 
            // cmbTypeDeadTime
            // 
            this.cmbTypeDeadTime.FormattingEnabled = true;
            this.cmbTypeDeadTime.Location = new System.Drawing.Point(235, 18);
            this.cmbTypeDeadTime.Name = "cmbTypeDeadTime";
            this.cmbTypeDeadTime.Size = new System.Drawing.Size(320, 23);
            this.cmbTypeDeadTime.TabIndex = 4;
            // 
            // lblTypeDeadTime
            // 
            this.lblTypeDeadTime.AutoSize = true;
            this.lblTypeDeadTime.Location = new System.Drawing.Point(111, 21);
            this.lblTypeDeadTime.Name = "lblTypeDeadTime";
            this.lblTypeDeadTime.Size = new System.Drawing.Size(118, 15);
            this.lblTypeDeadTime.TabIndex = 3;
            this.lblTypeDeadTime.Text = "Tipo Tiempo Muerto";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(661, 44);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackgroundImage = global::BPS.Lite.Properties.Resources.disk;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Location = new System.Drawing.Point(603, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(25, 25);
            this.btnSave.TabIndex = 2;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackgroundImage = global::BPS.Lite.Properties.Resources.cancel;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.Location = new System.Drawing.Point(630, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmDeadTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(667, 480);
            this.Controls.Add(this.grpbDeadTime);
            this.Controls.Add(this.grpbActions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDeadTime";
            this.Text = "Administración de Tiempos Muertos Metalizadora";
            this.Load += new System.EventHandler(this.frmDeadTime_Load);
            this.grpbDeadTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeadTime)).EndInit();
            this.grpbActions.ResumeLayout(false);
            this.grpbActions.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbDeadTime;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox grpbActions;
        private System.Windows.Forms.DataGridView dgvDeadTime;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbTypeDeadTime;
        private System.Windows.Forms.Label lblTypeDeadTime;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmdeadtimecodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmdeadtimegroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmdeadtimename;
        private System.Windows.Forms.DataGridViewImageColumn clmdeadtimeadd;
        private System.Windows.Forms.DataGridViewImageColumn clmdeadtimeedit;
    }
}