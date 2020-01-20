namespace BPS
{
    partial class frmFormulationsCastList
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
            this.grpbFomulationsButtons = new System.Windows.Forms.GroupBox();
            this.btnFormulationAdd = new System.Windows.Forms.Button();
            this.btnViewDetail = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpbFormulationsFilters = new System.Windows.Forms.GroupBox();
            this.grpbFormulationsList = new System.Windows.Forms.GroupBox();
            this.dgvFormulationsList = new System.Windows.Forms.DataGridView();
            this.clmFormulationsCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFormulationsFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFormulationsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFormulationsDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttpFormulationsCast = new System.Windows.Forms.ToolTip(this.components);
            this.grpbFomulationsButtons.SuspendLayout();
            this.grpbFormulationsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormulationsList)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbFomulationsButtons
            // 
            this.grpbFomulationsButtons.Controls.Add(this.btnFormulationAdd);
            this.grpbFomulationsButtons.Controls.Add(this.btnViewDetail);
            this.grpbFomulationsButtons.Controls.Add(this.btnClose);
            this.grpbFomulationsButtons.Location = new System.Drawing.Point(777, 218);
            this.grpbFomulationsButtons.Name = "grpbFomulationsButtons";
            this.grpbFomulationsButtons.Size = new System.Drawing.Size(83, 43);
            this.grpbFomulationsButtons.TabIndex = 5;
            this.grpbFomulationsButtons.TabStop = false;
            // 
            // btnFormulationAdd
            // 
            this.btnFormulationAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnFormulationAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFormulationAdd.Location = new System.Drawing.Point(5, 13);
            this.btnFormulationAdd.Name = "btnFormulationAdd";
            this.btnFormulationAdd.Size = new System.Drawing.Size(25, 25);
            this.btnFormulationAdd.TabIndex = 28;
            this.ttpFormulationsCast.SetToolTip(this.btnFormulationAdd, "Agregar Formulaciones Cast");
            this.btnFormulationAdd.UseVisualStyleBackColor = true;
            this.btnFormulationAdd.Click += new System.EventHandler(this.btnFormulationAdd_Click);
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.BackgroundImage = global::BPS.Properties.Resources.eye;
            this.btnViewDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnViewDetail.Location = new System.Drawing.Point(30, 13);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Size = new System.Drawing.Size(25, 25);
            this.btnViewDetail.TabIndex = 26;
            this.ttpFormulationsCast.SetToolTip(this.btnViewDetail, "Ver Detalles Formulaciones Cast");
            this.btnViewDetail.UseVisualStyleBackColor = true;
            this.btnViewDetail.Click += new System.EventHandler(this.btnViewDetail_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(55, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 27;
            this.ttpFormulationsCast.SetToolTip(this.btnClose, "Salir Formulaciones Cast");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpbFormulationsFilters
            // 
            this.grpbFormulationsFilters.Location = new System.Drawing.Point(0, 218);
            this.grpbFormulationsFilters.Name = "grpbFormulationsFilters";
            this.grpbFormulationsFilters.Size = new System.Drawing.Size(776, 43);
            this.grpbFormulationsFilters.TabIndex = 4;
            this.grpbFormulationsFilters.TabStop = false;
            // 
            // grpbFormulationsList
            // 
            this.grpbFormulationsList.Controls.Add(this.dgvFormulationsList);
            this.grpbFormulationsList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbFormulationsList.Location = new System.Drawing.Point(0, 0);
            this.grpbFormulationsList.Name = "grpbFormulationsList";
            this.grpbFormulationsList.Size = new System.Drawing.Size(861, 223);
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
            this.clmFormulationsDescription});
            this.dgvFormulationsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFormulationsList.Location = new System.Drawing.Point(3, 17);
            this.dgvFormulationsList.Name = "dgvFormulationsList";
            this.dgvFormulationsList.ReadOnly = true;
            this.dgvFormulationsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFormulationsList.Size = new System.Drawing.Size(855, 203);
            this.dgvFormulationsList.TabIndex = 0;
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
            this.clmFormulationsFilm.Width = 200;
            // 
            // clmFormulationsName
            // 
            this.clmFormulationsName.HeaderText = "Nombre";
            this.clmFormulationsName.Name = "clmFormulationsName";
            this.clmFormulationsName.ReadOnly = true;
            this.clmFormulationsName.Width = 200;
            // 
            // clmFormulationsDescription
            // 
            this.clmFormulationsDescription.HeaderText = "Descripción";
            this.clmFormulationsDescription.Name = "clmFormulationsDescription";
            this.clmFormulationsDescription.ReadOnly = true;
            this.clmFormulationsDescription.Width = 400;
            // 
            // frmFormulationsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(861, 263);
            this.Controls.Add(this.grpbFormulationsList);
            this.Controls.Add(this.grpbFomulationsButtons);
            this.Controls.Add(this.grpbFormulationsFilters);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFormulationsList";
            this.Text = "Lista Formulaciones Cast";
            this.Load += new System.EventHandler(this.frmFormulationsList_Load);
            this.grpbFomulationsButtons.ResumeLayout(false);
            this.grpbFormulationsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormulationsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbFomulationsButtons;
        private System.Windows.Forms.Button btnFormulationAdd;
        private System.Windows.Forms.Button btnViewDetail;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpbFormulationsFilters;
        private System.Windows.Forms.GroupBox grpbFormulationsList;
        private System.Windows.Forms.DataGridView dgvFormulationsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFormulationsCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFormulationsFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFormulationsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFormulationsDescription;
        private System.Windows.Forms.ToolTip ttpFormulationsCast;
    }
}