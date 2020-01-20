namespace BPS
{
    partial class frmFormulationsList
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormulationsList));
            this.btnFormulationAdd = new System.Windows.Forms.Button();
            this.btnViewDetail = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpbFormulationsFilters = new System.Windows.Forms.GroupBox();
            this.grpbFormulationsList = new System.Windows.Forms.GroupBox();
            this.dgvFormulationsList = new System.Windows.Forms.DataGridView();
            this.ttpFormulationsBopp = new System.Windows.Forms.ToolTip(this.components);
            this.clmFormulationsCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFormulationsFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFormulationsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFormulationsDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmedit = new System.Windows.Forms.DataGridViewImageColumn();
            this.grpbFormulationsFilters.SuspendLayout();
            this.grpbFormulationsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormulationsList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFormulationAdd
            // 
            this.btnFormulationAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFormulationAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnFormulationAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFormulationAdd.Location = new System.Drawing.Point(696, 12);
            this.btnFormulationAdd.Name = "btnFormulationAdd";
            this.btnFormulationAdd.Size = new System.Drawing.Size(25, 25);
            this.btnFormulationAdd.TabIndex = 28;
            this.ttpFormulationsBopp.SetToolTip(this.btnFormulationAdd, "Agregar Formulaciones Bopp");
            this.btnFormulationAdd.UseVisualStyleBackColor = true;
            this.btnFormulationAdd.Click += new System.EventHandler(this.btnFormulationAdd_Click);
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewDetail.BackgroundImage = global::BPS.Properties.Resources.eye;
            this.btnViewDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnViewDetail.Location = new System.Drawing.Point(721, 12);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Size = new System.Drawing.Size(25, 25);
            this.btnViewDetail.TabIndex = 26;
            this.ttpFormulationsBopp.SetToolTip(this.btnViewDetail, "Ver Detalles Formulaciones Bopp");
            this.btnViewDetail.UseVisualStyleBackColor = true;
            this.btnViewDetail.Click += new System.EventHandler(this.btnViewDetail_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(746, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 27;
            this.ttpFormulationsBopp.SetToolTip(this.btnClose, "Salir Formulaciones Bopp");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpbFormulationsFilters
            // 
            this.grpbFormulationsFilters.Controls.Add(this.btnFormulationAdd);
            this.grpbFormulationsFilters.Controls.Add(this.btnViewDetail);
            this.grpbFormulationsFilters.Controls.Add(this.btnClose);
            this.grpbFormulationsFilters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbFormulationsFilters.Location = new System.Drawing.Point(0, 463);
            this.grpbFormulationsFilters.Name = "grpbFormulationsFilters";
            this.grpbFormulationsFilters.Size = new System.Drawing.Size(775, 43);
            this.grpbFormulationsFilters.TabIndex = 4;
            this.grpbFormulationsFilters.TabStop = false;
            // 
            // grpbFormulationsList
            // 
            this.grpbFormulationsList.Controls.Add(this.dgvFormulationsList);
            this.grpbFormulationsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbFormulationsList.Location = new System.Drawing.Point(0, 0);
            this.grpbFormulationsList.Name = "grpbFormulationsList";
            this.grpbFormulationsList.Size = new System.Drawing.Size(775, 463);
            this.grpbFormulationsList.TabIndex = 3;
            this.grpbFormulationsList.TabStop = false;
            // 
            // dgvFormulationsList
            // 
            this.dgvFormulationsList.AllowUserToAddRows = false;
            this.dgvFormulationsList.AllowUserToDeleteRows = false;
            this.dgvFormulationsList.AllowUserToOrderColumns = true;
            this.dgvFormulationsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormulationsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmFormulationsCodsec,
            this.clmFormulationsFilm,
            this.clmFormulationsName,
            this.clmFormulationsDescription,
            this.clmedit});
            this.dgvFormulationsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFormulationsList.Location = new System.Drawing.Point(3, 17);
            this.dgvFormulationsList.Name = "dgvFormulationsList";
            this.dgvFormulationsList.ReadOnly = true;
            this.dgvFormulationsList.RowHeadersWidth = 21;
            this.dgvFormulationsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFormulationsList.Size = new System.Drawing.Size(769, 443);
            this.dgvFormulationsList.TabIndex = 0;
            this.dgvFormulationsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFormulationsList_CellClick);
            this.dgvFormulationsList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFormulationsList_CellDoubleClick);
            // 
            // clmFormulationsCodsec
            // 
            this.clmFormulationsCodsec.HeaderText = "Codsec";
            this.clmFormulationsCodsec.Name = "clmFormulationsCodsec";
            this.clmFormulationsCodsec.ReadOnly = true;
            this.clmFormulationsCodsec.Visible = false;
            // 
            // clmFormulationsFilm
            // 
            this.clmFormulationsFilm.HeaderText = "Película";
            this.clmFormulationsFilm.Name = "clmFormulationsFilm";
            this.clmFormulationsFilm.ReadOnly = true;
            this.clmFormulationsFilm.Width = 150;
            // 
            // clmFormulationsName
            // 
            this.clmFormulationsName.HeaderText = "Nombre";
            this.clmFormulationsName.Name = "clmFormulationsName";
            this.clmFormulationsName.ReadOnly = true;
            this.clmFormulationsName.Width = 300;
            // 
            // clmFormulationsDescription
            // 
            this.clmFormulationsDescription.HeaderText = "Descripción";
            this.clmFormulationsDescription.Name = "clmFormulationsDescription";
            this.clmFormulationsDescription.ReadOnly = true;
            this.clmFormulationsDescription.Width = 200;
            // 
            // clmedit
            // 
            this.clmedit.HeaderText = "";
            this.clmedit.Name = "clmedit";
            this.clmedit.ReadOnly = true;
            this.clmedit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmedit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmedit.Width = 30;
            // 
            // frmFormulationsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(775, 506);
            this.Controls.Add(this.grpbFormulationsList);
            this.Controls.Add(this.grpbFormulationsFilters);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFormulationsList";
            this.Text = "Lista Formulaciones BOPP";
            this.Load += new System.EventHandler(this.frmFormulationsList_Load);
            this.grpbFormulationsFilters.ResumeLayout(false);
            this.grpbFormulationsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormulationsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormulationAdd;
        private System.Windows.Forms.Button btnViewDetail;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpbFormulationsFilters;
        private System.Windows.Forms.GroupBox grpbFormulationsList;
        private System.Windows.Forms.DataGridView dgvFormulationsList;
        private System.Windows.Forms.ToolTip ttpFormulationsBopp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFormulationsCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFormulationsFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFormulationsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFormulationsDescription;
        private System.Windows.Forms.DataGridViewImageColumn clmedit;
    }
}