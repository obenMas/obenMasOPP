namespace BPS
{
    partial class frmNylonFilmList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNylonFilmList));
            this.grpbList = new System.Windows.Forms.GroupBox();
            this.dgvCast = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProcess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubProcess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCentralStructure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSurfaceStructure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCentralAdditivation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSurfaceAdditivation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmThickness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTreatment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnViewDetail = new System.Windows.Forms.Button();
            this.btnEditCompany = new System.Windows.Forms.Button();
            this.grpbFilters = new System.Windows.Forms.GroupBox();
            this.ttpFilmCast = new System.Windows.Forms.ToolTip(this.components);
            this.grpbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCast)).BeginInit();
            this.grpbFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbList
            // 
            this.grpbList.Controls.Add(this.dgvCast);
            this.grpbList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbList.Location = new System.Drawing.Point(0, 0);
            this.grpbList.Name = "grpbList";
            this.grpbList.Size = new System.Drawing.Size(1098, 448);
            this.grpbList.TabIndex = 12;
            this.grpbList.TabStop = false;
            // 
            // dgvCast
            // 
            this.dgvCast.AllowUserToAddRows = false;
            this.dgvCast.AllowUserToDeleteRows = false;
            this.dgvCast.AllowUserToOrderColumns = true;
            this.dgvCast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCast.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmCode,
            this.clmName,
            this.clmProcess,
            this.clmSubProcess,
            this.clmCentralStructure,
            this.clmSurfaceStructure,
            this.clmCentralAdditivation,
            this.clmSurfaceAdditivation,
            this.clmThickness,
            this.clmTreatment});
            this.dgvCast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCast.Location = new System.Drawing.Point(3, 16);
            this.dgvCast.Name = "dgvCast";
            this.dgvCast.ReadOnly = true;
            this.dgvCast.RowHeadersWidth = 21;
            this.dgvCast.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCast.Size = new System.Drawing.Size(1092, 429);
            this.dgvCast.TabIndex = 0;
            this.dgvCast.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCast_RowHeaderMouseDoubleClick);
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmCode
            // 
            this.clmCode.HeaderText = "Codigo";
            this.clmCode.Name = "clmCode";
            this.clmCode.ReadOnly = true;
            this.clmCode.Width = 60;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Nombre";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Width = 200;
            // 
            // clmProcess
            // 
            this.clmProcess.HeaderText = "Proceso";
            this.clmProcess.Name = "clmProcess";
            this.clmProcess.ReadOnly = true;
            // 
            // clmSubProcess
            // 
            this.clmSubProcess.HeaderText = "Sub-proceso";
            this.clmSubProcess.Name = "clmSubProcess";
            this.clmSubProcess.ReadOnly = true;
            // 
            // clmCentralStructure
            // 
            this.clmCentralStructure.HeaderText = "Estructura Cent.";
            this.clmCentralStructure.Name = "clmCentralStructure";
            this.clmCentralStructure.ReadOnly = true;
            // 
            // clmSurfaceStructure
            // 
            this.clmSurfaceStructure.HeaderText = "Estructura Sup.";
            this.clmSurfaceStructure.Name = "clmSurfaceStructure";
            this.clmSurfaceStructure.ReadOnly = true;
            // 
            // clmCentralAdditivation
            // 
            this.clmCentralAdditivation.HeaderText = "Aditivación Cent.";
            this.clmCentralAdditivation.Name = "clmCentralAdditivation";
            this.clmCentralAdditivation.ReadOnly = true;
            // 
            // clmSurfaceAdditivation
            // 
            this.clmSurfaceAdditivation.HeaderText = "Aditivación Sup.";
            this.clmSurfaceAdditivation.Name = "clmSurfaceAdditivation";
            this.clmSurfaceAdditivation.ReadOnly = true;
            // 
            // clmThickness
            // 
            this.clmThickness.HeaderText = "Espesor";
            this.clmThickness.Name = "clmThickness";
            this.clmThickness.ReadOnly = true;
            // 
            // clmTreatment
            // 
            this.clmTreatment.HeaderText = "Tratamiento";
            this.clmTreatment.Name = "clmTreatment";
            this.clmTreatment.ReadOnly = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackgroundImage = global::BPS.Properties.Resources.arrow_refresh1;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefresh.Location = new System.Drawing.Point(966, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 25);
            this.btnRefresh.TabIndex = 29;
            this.ttpFilmCast.SetToolTip(this.btnRefresh, "Actualizar");
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnExit.Location = new System.Drawing.Point(1067, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 28;
            this.ttpFilmCast.SetToolTip(this.btnExit, "Salir");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(991, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 25);
            this.btnAdd.TabIndex = 24;
            this.ttpFilmCast.SetToolTip(this.btnAdd, "Agregar");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewDetail.BackgroundImage = global::BPS.Properties.Resources.eye;
            this.btnViewDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnViewDetail.Location = new System.Drawing.Point(1016, 12);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Size = new System.Drawing.Size(25, 25);
            this.btnViewDetail.TabIndex = 22;
            this.ttpFilmCast.SetToolTip(this.btnViewDetail, "Ver Detalles");
            this.btnViewDetail.UseVisualStyleBackColor = true;
            this.btnViewDetail.Click += new System.EventHandler(this.btnViewDetail_Click);
            // 
            // btnEditCompany
            // 
            this.btnEditCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditCompany.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnEditCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditCompany.Location = new System.Drawing.Point(1041, 12);
            this.btnEditCompany.Name = "btnEditCompany";
            this.btnEditCompany.Size = new System.Drawing.Size(25, 25);
            this.btnEditCompany.TabIndex = 21;
            this.ttpFilmCast.SetToolTip(this.btnEditCompany, "Editar");
            this.btnEditCompany.UseVisualStyleBackColor = true;
            this.btnEditCompany.Click += new System.EventHandler(this.btnEditCompany_Click);
            // 
            // grpbFilters
            // 
            this.grpbFilters.Controls.Add(this.btnRefresh);
            this.grpbFilters.Controls.Add(this.btnAdd);
            this.grpbFilters.Controls.Add(this.btnExit);
            this.grpbFilters.Controls.Add(this.btnEditCompany);
            this.grpbFilters.Controls.Add(this.btnViewDetail);
            this.grpbFilters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbFilters.Location = new System.Drawing.Point(0, 448);
            this.grpbFilters.Name = "grpbFilters";
            this.grpbFilters.Size = new System.Drawing.Size(1098, 43);
            this.grpbFilters.TabIndex = 13;
            this.grpbFilters.TabStop = false;
            // 
            // frmNylonFilmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1098, 491);
            this.Controls.Add(this.grpbList);
            this.Controls.Add(this.grpbFilters);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNylonFilmList";
            this.Text = "Listado de películas Cast";
            this.Load += new System.EventHandler(this.frmNylonFilmList_Load);
            this.grpbList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCast)).EndInit();
            this.grpbFilters.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbList;
        private System.Windows.Forms.DataGridView dgvCast;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnViewDetail;
        private System.Windows.Forms.Button btnEditCompany;
        private System.Windows.Forms.GroupBox grpbFilters;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCentralStructure;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSurfaceStructure;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCentralAdditivation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSurfaceAdditivation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmThickness;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTreatment;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ToolTip ttpFilmCast;

    }
}