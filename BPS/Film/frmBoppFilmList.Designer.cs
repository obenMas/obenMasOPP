namespace BPS
{
    partial class frmBoppFilmList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBoppFilmList));
            this.grpbList = new System.Windows.Forms.GroupBox();
            this.dgvBopp = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubFamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInnerSeal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOuterSeal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCentralAdditivation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSurfaceAdditivation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmThickness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTreatment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbFilters = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEditCompany = new System.Windows.Forms.Button();
            this.btnViewDetail = new System.Windows.Forms.Button();
            this.ttpListFilmsBopp = new System.Windows.Forms.ToolTip(this.components);
            this.grpbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBopp)).BeginInit();
            this.grpbFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbList
            // 
            this.grpbList.Controls.Add(this.dgvBopp);
            this.grpbList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbList.Location = new System.Drawing.Point(0, 0);
            this.grpbList.Name = "grpbList";
            this.grpbList.Size = new System.Drawing.Size(894, 446);
            this.grpbList.TabIndex = 9;
            this.grpbList.TabStop = false;
            // 
            // dgvBopp
            // 
            this.dgvBopp.AllowUserToAddRows = false;
            this.dgvBopp.AllowUserToDeleteRows = false;
            this.dgvBopp.AllowUserToOrderColumns = true;
            this.dgvBopp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBopp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBopp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmCode,
            this.clmName,
            this.clmFamily,
            this.clmSubFamily,
            this.clmInnerSeal,
            this.clmOuterSeal,
            this.clmCentralAdditivation,
            this.clmSurfaceAdditivation,
            this.clmThickness,
            this.clmTreatment});
            this.dgvBopp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBopp.Location = new System.Drawing.Point(3, 17);
            this.dgvBopp.Name = "dgvBopp";
            this.dgvBopp.ReadOnly = true;
            this.dgvBopp.RowHeadersWidth = 21;
            this.dgvBopp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBopp.Size = new System.Drawing.Size(888, 426);
            this.dgvBopp.TabIndex = 0;
            this.dgvBopp.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBopp_RowHeaderMouseDoubleClick);
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
            // clmFamily
            // 
            this.clmFamily.HeaderText = "Familia";
            this.clmFamily.Name = "clmFamily";
            this.clmFamily.ReadOnly = true;
            // 
            // clmSubFamily
            // 
            this.clmSubFamily.HeaderText = "Sub-familia";
            this.clmSubFamily.Name = "clmSubFamily";
            this.clmSubFamily.ReadOnly = true;
            // 
            // clmInnerSeal
            // 
            this.clmInnerSeal.HeaderText = "Sello Int.";
            this.clmInnerSeal.Name = "clmInnerSeal";
            this.clmInnerSeal.ReadOnly = true;
            // 
            // clmOuterSeal
            // 
            this.clmOuterSeal.HeaderText = "Sello Ext.";
            this.clmOuterSeal.Name = "clmOuterSeal";
            this.clmOuterSeal.ReadOnly = true;
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
            // grpbFilters
            // 
            this.grpbFilters.Controls.Add(this.btnRefresh);
            this.grpbFilters.Controls.Add(this.btnExit);
            this.grpbFilters.Controls.Add(this.btnDelete);
            this.grpbFilters.Controls.Add(this.btnAdd);
            this.grpbFilters.Controls.Add(this.btnEditCompany);
            this.grpbFilters.Controls.Add(this.btnViewDetail);
            this.grpbFilters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbFilters.Location = new System.Drawing.Point(0, 446);
            this.grpbFilters.Name = "grpbFilters";
            this.grpbFilters.Size = new System.Drawing.Size(894, 43);
            this.grpbFilters.TabIndex = 10;
            this.grpbFilters.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::BPS.Properties.Resources.arrow_refresh1;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefresh.Location = new System.Drawing.Point(737, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 25);
            this.btnRefresh.TabIndex = 6;
            this.ttpListFilmsBopp.SetToolTip(this.btnRefresh, "Actualizar Listado Películas Bopp");
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnExit.Location = new System.Drawing.Point(862, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 11;
            this.ttpListFilmsBopp.SetToolTip(this.btnExit, "Salir Películas Bopp");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.Location = new System.Drawing.Point(837, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(25, 25);
            this.btnDelete.TabIndex = 10;
            this.ttpListFilmsBopp.SetToolTip(this.btnDelete, "Borrar Películas Bopp");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.Location = new System.Drawing.Point(762, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 25);
            this.btnAdd.TabIndex = 7;
            this.ttpListFilmsBopp.SetToolTip(this.btnAdd, "Agregar Películas Bopp");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEditCompany
            // 
            this.btnEditCompany.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnEditCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditCompany.Location = new System.Drawing.Point(812, 12);
            this.btnEditCompany.Name = "btnEditCompany";
            this.btnEditCompany.Size = new System.Drawing.Size(25, 25);
            this.btnEditCompany.TabIndex = 9;
            this.ttpListFilmsBopp.SetToolTip(this.btnEditCompany, "Editar Películas Bopp");
            this.btnEditCompany.UseVisualStyleBackColor = true;
            this.btnEditCompany.Click += new System.EventHandler(this.btnEditCompany_Click);
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.BackgroundImage = global::BPS.Properties.Resources.eye;
            this.btnViewDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnViewDetail.Location = new System.Drawing.Point(787, 12);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Size = new System.Drawing.Size(25, 25);
            this.btnViewDetail.TabIndex = 8;
            this.ttpListFilmsBopp.SetToolTip(this.btnViewDetail, "Ver Detalles Películas Bopp");
            this.btnViewDetail.UseVisualStyleBackColor = true;
            this.btnViewDetail.Click += new System.EventHandler(this.btnViewDetail_Click);
            // 
            // frmBoppFilmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(894, 489);
            this.Controls.Add(this.grpbList);
            this.Controls.Add(this.grpbFilters);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBoppFilmList";
            this.Text = "Listado de películas BOPP";
            this.Load += new System.EventHandler(this.frmBoppFilmList_Load);
            this.grpbList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBopp)).EndInit();
            this.grpbFilters.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbList;
        private System.Windows.Forms.DataGridView dgvBopp;
        private System.Windows.Forms.GroupBox grpbFilters;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInnerSeal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOuterSeal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCentralAdditivation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSurfaceAdditivation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmThickness;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTreatment;
        private System.Windows.Forms.ToolTip ttpListFilmsBopp;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEditCompany;
        private System.Windows.Forms.Button btnViewDetail;
    }
}