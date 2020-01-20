namespace BPS
{
    partial class frmDensityByFilm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDensityByFilm));
            this.grpbFilters = new System.Windows.Forms.GroupBox();
            this.txtDensity = new System.Windows.Forms.TextBox();
            this.lblDensity = new System.Windows.Forms.Label();
            this.txtFilm = new System.Windows.Forms.TextBox();
            this.lblFilm = new System.Windows.Forms.Label();
            this.grpbFilm = new System.Windows.Forms.GroupBox();
            this.dgvFilm = new System.Windows.Forms.DataGridView();
            this.clmcodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmfilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdensity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmview = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmviewform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbActions = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpbFilters.SuspendLayout();
            this.grpbFilm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilm)).BeginInit();
            this.grpbActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbFilters
            // 
            this.grpbFilters.Controls.Add(this.txtDensity);
            this.grpbFilters.Controls.Add(this.lblDensity);
            this.grpbFilters.Controls.Add(this.txtFilm);
            this.grpbFilters.Controls.Add(this.lblFilm);
            this.grpbFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbFilters.Location = new System.Drawing.Point(0, 0);
            this.grpbFilters.Name = "grpbFilters";
            this.grpbFilters.Size = new System.Drawing.Size(479, 88);
            this.grpbFilters.TabIndex = 0;
            this.grpbFilters.TabStop = false;
            this.grpbFilters.Text = "Filtros";
            // 
            // txtDensity
            // 
            this.txtDensity.Location = new System.Drawing.Point(222, 47);
            this.txtDensity.Name = "txtDensity";
            this.txtDensity.Size = new System.Drawing.Size(100, 21);
            this.txtDensity.TabIndex = 3;
            this.txtDensity.Visible = false;
            this.txtDensity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDensity_KeyPress);
            // 
            // lblDensity
            // 
            this.lblDensity.AutoSize = true;
            this.lblDensity.Location = new System.Drawing.Point(156, 50);
            this.lblDensity.Name = "lblDensity";
            this.lblDensity.Size = new System.Drawing.Size(60, 15);
            this.lblDensity.TabIndex = 2;
            this.lblDensity.Text = "Densidad";
            this.lblDensity.Visible = false;
            // 
            // txtFilm
            // 
            this.txtFilm.Location = new System.Drawing.Point(222, 20);
            this.txtFilm.Name = "txtFilm";
            this.txtFilm.Size = new System.Drawing.Size(100, 21);
            this.txtFilm.TabIndex = 1;
            this.txtFilm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilm_KeyDown);
            // 
            // lblFilm
            // 
            this.lblFilm.AutoSize = true;
            this.lblFilm.Location = new System.Drawing.Point(165, 23);
            this.lblFilm.Name = "lblFilm";
            this.lblFilm.Size = new System.Drawing.Size(51, 15);
            this.lblFilm.TabIndex = 0;
            this.lblFilm.Text = "Película";
            // 
            // grpbFilm
            // 
            this.grpbFilm.Controls.Add(this.dgvFilm);
            this.grpbFilm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbFilm.Location = new System.Drawing.Point(0, 88);
            this.grpbFilm.Name = "grpbFilm";
            this.grpbFilm.Size = new System.Drawing.Size(479, 380);
            this.grpbFilm.TabIndex = 1;
            this.grpbFilm.TabStop = false;
            this.grpbFilm.Text = "Películas";
            // 
            // dgvFilm
            // 
            this.dgvFilm.AllowUserToAddRows = false;
            this.dgvFilm.AllowUserToDeleteRows = false;
            this.dgvFilm.AllowUserToOrderColumns = true;
            this.dgvFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmcodsec,
            this.clmdescription,
            this.clmfilm,
            this.clmdensity,
            this.clmview,
            this.clmviewform});
            this.dgvFilm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFilm.Location = new System.Drawing.Point(3, 17);
            this.dgvFilm.Name = "dgvFilm";
            this.dgvFilm.ReadOnly = true;
            this.dgvFilm.RowHeadersWidth = 21;
            this.dgvFilm.Size = new System.Drawing.Size(473, 360);
            this.dgvFilm.TabIndex = 0;
            this.dgvFilm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFilm_CellClick);
            // 
            // clmcodsec
            // 
            this.clmcodsec.HeaderText = "codsec";
            this.clmcodsec.Name = "clmcodsec";
            this.clmcodsec.ReadOnly = true;
            this.clmcodsec.Visible = false;
            // 
            // clmdescription
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmdescription.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmdescription.HeaderText = "Descripción";
            this.clmdescription.Name = "clmdescription";
            this.clmdescription.ReadOnly = true;
            this.clmdescription.Width = 250;
            // 
            // clmfilm
            // 
            this.clmfilm.HeaderText = "Película";
            this.clmfilm.Name = "clmfilm";
            this.clmfilm.ReadOnly = true;
            this.clmfilm.Width = 80;
            // 
            // clmdensity
            // 
            this.clmdensity.HeaderText = "Densidad";
            this.clmdensity.Name = "clmdensity";
            this.clmdensity.ReadOnly = true;
            this.clmdensity.Width = 80;
            // 
            // clmview
            // 
            this.clmview.HeaderText = "";
            this.clmview.Name = "clmview";
            this.clmview.ReadOnly = true;
            this.clmview.Width = 30;
            // 
            // clmviewform
            // 
            this.clmviewform.HeaderText = "";
            this.clmviewform.Name = "clmviewform";
            this.clmviewform.ReadOnly = true;
            this.clmviewform.Visible = false;
            // 
            // grpbActions
            // 
            this.grpbActions.Controls.Add(this.btnSave);
            this.grpbActions.Controls.Add(this.btnExit);
            this.grpbActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbActions.Location = new System.Drawing.Point(0, 468);
            this.grpbActions.Name = "grpbActions";
            this.grpbActions.Size = new System.Drawing.Size(479, 39);
            this.grpbActions.TabIndex = 2;
            this.grpbActions.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::BPS.Properties.Resources.disk;
            this.btnSave.Location = new System.Drawing.Point(421, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(25, 25);
            this.btnSave.TabIndex = 6;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnExit.Location = new System.Drawing.Point(448, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmDensityByFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(479, 507);
            this.Controls.Add(this.grpbFilm);
            this.Controls.Add(this.grpbActions);
            this.Controls.Add(this.grpbFilters);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDensityByFilm";
            this.Text = "Densidad por Película";
            this.grpbFilters.ResumeLayout(false);
            this.grpbFilters.PerformLayout();
            this.grpbFilm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilm)).EndInit();
            this.grpbActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbFilters;
        private System.Windows.Forms.TextBox txtFilm;
        private System.Windows.Forms.Label lblFilm;
        private System.Windows.Forms.GroupBox grpbFilm;
        private System.Windows.Forms.DataGridView dgvFilm;
        private System.Windows.Forms.GroupBox grpbActions;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtDensity;
        private System.Windows.Forms.Label lblDensity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmdescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmdensity;
        private System.Windows.Forms.DataGridViewImageColumn clmview;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmviewform;
    }
}