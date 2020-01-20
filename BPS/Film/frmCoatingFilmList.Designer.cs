namespace BPS
{
    partial class frmCoatingFilmList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCoatingFilmList));
            this.dgvCoating = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProcess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubProcess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTerminationStructure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoatingStructure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubstrateThickness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoatingThickness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTreatment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbList = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnViewDetail = new System.Windows.Forms.Button();
            this.btnEditCompany = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grpbFilters = new System.Windows.Forms.GroupBox();
            this.ttpListFilmCoating = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoating)).BeginInit();
            this.grpbList.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCoating
            // 
            this.dgvCoating.AllowUserToAddRows = false;
            this.dgvCoating.AllowUserToDeleteRows = false;
            this.dgvCoating.AllowUserToOrderColumns = true;
            this.dgvCoating.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoating.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmCode,
            this.clmName,
            this.clmProcess,
            this.clmSubProcess,
            this.clmTerminationStructure,
            this.clmCoatingStructure,
            this.clmSubstrateThickness,
            this.clmCoatingThickness,
            this.clmTreatment});
            this.dgvCoating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCoating.Location = new System.Drawing.Point(3, 17);
            this.dgvCoating.Name = "dgvCoating";
            this.dgvCoating.ReadOnly = true;
            this.dgvCoating.Size = new System.Drawing.Size(692, 294);
            this.dgvCoating.TabIndex = 0;
            this.dgvCoating.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellContentClick);
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
            this.clmSubProcess.HeaderText = "Sub-Proceso";
            this.clmSubProcess.Name = "clmSubProcess";
            this.clmSubProcess.ReadOnly = true;
            // 
            // clmTerminationStructure
            // 
            this.clmTerminationStructure.HeaderText = "Acabado";
            this.clmTerminationStructure.Name = "clmTerminationStructure";
            this.clmTerminationStructure.ReadOnly = true;
            // 
            // clmCoatingStructure
            // 
            this.clmCoatingStructure.HeaderText = "Recubrimiento";
            this.clmCoatingStructure.Name = "clmCoatingStructure";
            this.clmCoatingStructure.ReadOnly = true;
            // 
            // clmSubstrateThickness
            // 
            this.clmSubstrateThickness.HeaderText = "Espesor Sustrato";
            this.clmSubstrateThickness.Name = "clmSubstrateThickness";
            this.clmSubstrateThickness.ReadOnly = true;
            // 
            // clmCoatingThickness
            // 
            this.clmCoatingThickness.HeaderText = "Espesor recubrimiento";
            this.clmCoatingThickness.Name = "clmCoatingThickness";
            this.clmCoatingThickness.ReadOnly = true;
            // 
            // clmTreatment
            // 
            this.clmTreatment.HeaderText = "Tratamiento";
            this.clmTreatment.Name = "clmTreatment";
            this.clmTreatment.ReadOnly = true;
            // 
            // grpbList
            // 
            this.grpbList.Controls.Add(this.dgvCoating);
            this.grpbList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbList.Location = new System.Drawing.Point(0, 0);
            this.grpbList.Name = "grpbList";
            this.grpbList.Size = new System.Drawing.Size(698, 314);
            this.grpbList.TabIndex = 15;
            this.grpbList.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnViewDetail);
            this.groupBox1.Controls.Add(this.btnEditCompany);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Location = new System.Drawing.Point(534, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 43);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnExit.Location = new System.Drawing.Point(130, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 5;
            this.ttpListFilmCoating.SetToolTip(this.btnExit, "Salir Películas Coating");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.Location = new System.Drawing.Point(30, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 25);
            this.btnAdd.TabIndex = 1;
            this.ttpListFilmCoating.SetToolTip(this.btnAdd, "Agregar Películas Coating");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.BackgroundImage = global::BPS.Properties.Resources.eye;
            this.btnViewDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnViewDetail.Location = new System.Drawing.Point(55, 13);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Size = new System.Drawing.Size(25, 25);
            this.btnViewDetail.TabIndex = 2;
            this.ttpListFilmCoating.SetToolTip(this.btnViewDetail, "Ver Detalles Peliculas Coating");
            this.btnViewDetail.UseVisualStyleBackColor = true;
            this.btnViewDetail.Click += new System.EventHandler(this.btnViewDetail_Click);
            // 
            // btnEditCompany
            // 
            this.btnEditCompany.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnEditCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditCompany.Location = new System.Drawing.Point(80, 13);
            this.btnEditCompany.Name = "btnEditCompany";
            this.btnEditCompany.Size = new System.Drawing.Size(25, 25);
            this.btnEditCompany.TabIndex = 3;
            this.ttpListFilmCoating.SetToolTip(this.btnEditCompany, "Editar Películas Coating");
            this.btnEditCompany.UseVisualStyleBackColor = true;
            this.btnEditCompany.Click += new System.EventHandler(this.btnEditCompany_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::BPS.Properties.Resources.cross;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.Location = new System.Drawing.Point(105, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(25, 25);
            this.btnDelete.TabIndex = 4;
            this.ttpListFilmCoating.SetToolTip(this.btnDelete, "Eliminar Películas Coating");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::BPS.Properties.Resources.arrow_refresh1;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefresh.Location = new System.Drawing.Point(5, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 25);
            this.btnRefresh.TabIndex = 0;
            this.ttpListFilmCoating.SetToolTip(this.btnRefresh, "Actualizar Películas Coating");
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // grpbFilters
            // 
            this.grpbFilters.Location = new System.Drawing.Point(2, 309);
            this.grpbFilters.Name = "grpbFilters";
            this.grpbFilters.Size = new System.Drawing.Size(530, 43);
            this.grpbFilters.TabIndex = 16;
            this.grpbFilters.TabStop = false;
            // 
            // frmCoatingFilmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(698, 354);
            this.Controls.Add(this.grpbList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbFilters);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCoatingFilmList";
            this.Text = "Listado de películas Coating";
            this.Load += new System.EventHandler(this.frmCoatingFilmList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoating)).EndInit();
            this.grpbList.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCoating;
        private System.Windows.Forms.GroupBox grpbList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnViewDetail;
        private System.Windows.Forms.Button btnEditCompany;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grpbFilters;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTerminationStructure;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoatingStructure;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubstrateThickness;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoatingThickness;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTreatment;
        private System.Windows.Forms.ToolTip ttpListFilmCoating;
    }
}