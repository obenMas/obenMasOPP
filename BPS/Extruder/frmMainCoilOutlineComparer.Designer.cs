namespace BPS
{
    partial class frmMainCoilOutlineComparer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainCoilOutlineComparer));
            this.zgcProfile = new ZedGraph.ZedGraphControl();
            this.grpbMainCoilList = new System.Windows.Forms.GroupBox();
            this.dgvMainCoilList = new System.Windows.Forms.DataGridView();
            this.clmMainCoilListCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmMainCoilListFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListProductionOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListLabRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListInitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpbDate = new System.Windows.Forms.GroupBox();
            this.grpbLot = new System.Windows.Forms.GroupBox();
            this.chkDate = new System.Windows.Forms.CheckBox();
            this.chkLot = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpInitdate = new System.Windows.Forms.DateTimePicker();
            this.dtpEnddate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.txtLot = new System.Windows.Forms.TextBox();
            this.grpbMainCoilList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainCoilList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpbDate.SuspendLayout();
            this.grpbLot.SuspendLayout();
            this.SuspendLayout();
            // 
            // zgcProfile
            // 
            this.zgcProfile.AutoScroll = true;
            this.zgcProfile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.zgcProfile.EditButtons = System.Windows.Forms.MouseButtons.Left;
            this.zgcProfile.LinkModifierKeys = System.Windows.Forms.Keys.None;
            this.zgcProfile.Location = new System.Drawing.Point(0, 336);
            this.zgcProfile.Name = "zgcProfile";
            this.zgcProfile.ScrollGrace = 0D;
            this.zgcProfile.ScrollMaxX = 0D;
            this.zgcProfile.ScrollMaxY = 0D;
            this.zgcProfile.ScrollMaxY2 = 0D;
            this.zgcProfile.ScrollMinX = 0D;
            this.zgcProfile.ScrollMinY = 0D;
            this.zgcProfile.ScrollMinY2 = 0D;
            this.zgcProfile.Size = new System.Drawing.Size(1094, 249);
            this.zgcProfile.TabIndex = 44;
            // 
            // grpbMainCoilList
            // 
            this.grpbMainCoilList.Controls.Add(this.dgvMainCoilList);
            this.grpbMainCoilList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbMainCoilList.Location = new System.Drawing.Point(0, 77);
            this.grpbMainCoilList.Name = "grpbMainCoilList";
            this.grpbMainCoilList.Size = new System.Drawing.Size(1094, 259);
            this.grpbMainCoilList.TabIndex = 45;
            this.grpbMainCoilList.TabStop = false;
            this.grpbMainCoilList.Text = "Rollos Madres";
            // 
            // dgvMainCoilList
            // 
            this.dgvMainCoilList.AllowUserToAddRows = false;
            this.dgvMainCoilList.AllowUserToDeleteRows = false;
            this.dgvMainCoilList.AllowUserToOrderColumns = true;
            this.dgvMainCoilList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainCoilList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMainCoilListCodsec,
            this.clmMainCoilListSelected,
            this.clmMainCoilListFilm,
            this.clmMainCoilListCode,
            this.clmMainCoilListBatch,
            this.clmMainCoilListProductionOrder,
            this.clmMainCoilListLabRating,
            this.clmMainCoilListInitDate,
            this.clmMainCoilListEndDate});
            this.dgvMainCoilList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMainCoilList.Location = new System.Drawing.Point(3, 17);
            this.dgvMainCoilList.Name = "dgvMainCoilList";
            this.dgvMainCoilList.ReadOnly = true;
            this.dgvMainCoilList.RowHeadersWidth = 21;
            this.dgvMainCoilList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMainCoilList.Size = new System.Drawing.Size(1088, 239);
            this.dgvMainCoilList.TabIndex = 1;
            this.dgvMainCoilList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMainCoilList_CellClick);
            // 
            // clmMainCoilListCodsec
            // 
            this.clmMainCoilListCodsec.HeaderText = "Codsec";
            this.clmMainCoilListCodsec.Name = "clmMainCoilListCodsec";
            this.clmMainCoilListCodsec.ReadOnly = true;
            this.clmMainCoilListCodsec.Visible = false;
            this.clmMainCoilListCodsec.Width = 200;
            // 
            // clmMainCoilListSelected
            // 
            this.clmMainCoilListSelected.HeaderText = "";
            this.clmMainCoilListSelected.Name = "clmMainCoilListSelected";
            this.clmMainCoilListSelected.ReadOnly = true;
            this.clmMainCoilListSelected.Width = 30;
            // 
            // clmMainCoilListFilm
            // 
            this.clmMainCoilListFilm.HeaderText = "Película";
            this.clmMainCoilListFilm.Name = "clmMainCoilListFilm";
            this.clmMainCoilListFilm.ReadOnly = true;
            this.clmMainCoilListFilm.Width = 130;
            // 
            // clmMainCoilListCode
            // 
            this.clmMainCoilListCode.HeaderText = "Código";
            this.clmMainCoilListCode.Name = "clmMainCoilListCode";
            this.clmMainCoilListCode.ReadOnly = true;
            this.clmMainCoilListCode.Width = 200;
            // 
            // clmMainCoilListBatch
            // 
            this.clmMainCoilListBatch.HeaderText = "Lote";
            this.clmMainCoilListBatch.Name = "clmMainCoilListBatch";
            this.clmMainCoilListBatch.ReadOnly = true;
            this.clmMainCoilListBatch.Width = 120;
            // 
            // clmMainCoilListProductionOrder
            // 
            this.clmMainCoilListProductionOrder.HeaderText = "Orden";
            this.clmMainCoilListProductionOrder.Name = "clmMainCoilListProductionOrder";
            this.clmMainCoilListProductionOrder.ReadOnly = true;
            // 
            // clmMainCoilListLabRating
            // 
            this.clmMainCoilListLabRating.HeaderText = "Calif. Lab.";
            this.clmMainCoilListLabRating.Name = "clmMainCoilListLabRating";
            this.clmMainCoilListLabRating.ReadOnly = true;
            this.clmMainCoilListLabRating.Width = 85;
            // 
            // clmMainCoilListInitDate
            // 
            this.clmMainCoilListInitDate.HeaderText = "Fecha Inicio";
            this.clmMainCoilListInitDate.Name = "clmMainCoilListInitDate";
            this.clmMainCoilListInitDate.ReadOnly = true;
            this.clmMainCoilListInitDate.Width = 180;
            // 
            // clmMainCoilListEndDate
            // 
            this.clmMainCoilListEndDate.HeaderText = "Fecha Fin";
            this.clmMainCoilListEndDate.Name = "clmMainCoilListEndDate";
            this.clmMainCoilListEndDate.ReadOnly = true;
            this.clmMainCoilListEndDate.Width = 180;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.btnClearFilters);
            this.groupBox1.Controls.Add(this.chkLot);
            this.groupBox1.Controls.Add(this.chkDate);
            this.groupBox1.Controls.Add(this.grpbLot);
            this.groupBox1.Controls.Add(this.grpbDate);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1094, 77);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // grpbDate
            // 
            this.grpbDate.Controls.Add(this.dtpEnddate);
            this.grpbDate.Controls.Add(this.label2);
            this.grpbDate.Controls.Add(this.dtpInitdate);
            this.grpbDate.Controls.Add(this.label1);
            this.grpbDate.Location = new System.Drawing.Point(23, 12);
            this.grpbDate.Name = "grpbDate";
            this.grpbDate.Size = new System.Drawing.Size(568, 58);
            this.grpbDate.TabIndex = 0;
            this.grpbDate.TabStop = false;
            // 
            // grpbLot
            // 
            this.grpbLot.Controls.Add(this.txtLot);
            this.grpbLot.Location = new System.Drawing.Point(650, 12);
            this.grpbLot.Name = "grpbLot";
            this.grpbLot.Size = new System.Drawing.Size(315, 58);
            this.grpbLot.TabIndex = 1;
            this.grpbLot.TabStop = false;
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.Location = new System.Drawing.Point(17, 12);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(149, 19);
            this.chkDate.TabIndex = 0;
            this.chkDate.Text = "Por fecha de Extrusión";
            this.chkDate.UseVisualStyleBackColor = true;
            this.chkDate.CheckedChanged += new System.EventHandler(this.chkDate_CheckedChanged);
            // 
            // chkLot
            // 
            this.chkLot.AutoSize = true;
            this.chkLot.Location = new System.Drawing.Point(641, 12);
            this.chkLot.Name = "chkLot";
            this.chkLot.Size = new System.Drawing.Size(50, 19);
            this.chkLot.TabIndex = 2;
            this.chkLot.Text = "Lote";
            this.chkLot.UseVisualStyleBackColor = true;
            this.chkLot.CheckedChanged += new System.EventHandler(this.chkLot_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Inicio";
            // 
            // dtpInitdate
            // 
            this.dtpInitdate.CustomFormat = "";
            this.dtpInitdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInitdate.Location = new System.Drawing.Point(174, 25);
            this.dtpInitdate.Name = "dtpInitdate";
            this.dtpInitdate.Size = new System.Drawing.Size(113, 21);
            this.dtpInitdate.TabIndex = 1;
            // 
            // dtpEnddate
            // 
            this.dtpEnddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnddate.Location = new System.Drawing.Point(374, 25);
            this.dtpEnddate.Name = "dtpEnddate";
            this.dtpEnddate.Size = new System.Drawing.Size(100, 21);
            this.dtpEnddate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Fin";
            // 
            // btnFilter
            // 
            this.btnFilter.BackgroundImage = global::BPS.Properties.Resources.funnel;
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFilter.Location = new System.Drawing.Point(1063, 29);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(25, 25);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.BackgroundImage = global::BPS.Properties.Resources.funnel_clear;
            this.btnClearFilters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClearFilters.Location = new System.Drawing.Point(1038, 29);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(25, 25);
            this.btnClearFilters.TabIndex = 3;
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // txtLot
            // 
            this.txtLot.Location = new System.Drawing.Point(69, 21);
            this.txtLot.Name = "txtLot";
            this.txtLot.Size = new System.Drawing.Size(177, 21);
            this.txtLot.TabIndex = 0;
            // 
            // frmMainCoilOutlineComparer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1094, 585);
            this.Controls.Add(this.grpbMainCoilList);
            this.Controls.Add(this.zgcProfile);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainCoilOutlineComparer";
            this.Text = "Comparación de perfiles";
            this.Load += new System.EventHandler(this.frmMainCoilOutlineComparer_Load);
            this.grpbMainCoilList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainCoilList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpbDate.ResumeLayout(false);
            this.grpbDate.PerformLayout();
            this.grpbLot.ResumeLayout(false);
            this.grpbLot.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl zgcProfile;
        private System.Windows.Forms.GroupBox grpbMainCoilList;
        private System.Windows.Forms.DataGridView dgvMainCoilList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListCodsec;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmMainCoilListSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListProductionOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListLabRating;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListInitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListEndDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpbLot;
        private System.Windows.Forms.GroupBox grpbDate;
        private System.Windows.Forms.CheckBox chkDate;
        private System.Windows.Forms.CheckBox chkLot;
        private System.Windows.Forms.DateTimePicker dtpEnddate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpInitdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.TextBox txtLot;
    }
}