namespace BPS
{
    partial class frmDecreaseSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDecreaseSelector));
            this.grpbDecreaseList = new System.Windows.Forms.GroupBox();
            this.dgvDecreaseList = new System.Windows.Forms.DataGridView();
            this.clmDecreaseCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDecreaseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDecreaseDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDecreaseClose = new System.Windows.Forms.Button();
            this.btnDecreaseAccept = new System.Windows.Forms.Button();
            this.grpbDecreaseFilters = new System.Windows.Forms.GroupBox();
            this.grpbDecreaseButtons = new System.Windows.Forms.GroupBox();
            this.ttpWaste = new System.Windows.Forms.ToolTip(this.components);
            this.grpbDecreaseList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDecreaseList)).BeginInit();
            this.grpbDecreaseButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbDecreaseList
            // 
            this.grpbDecreaseList.Controls.Add(this.dgvDecreaseList);
            this.grpbDecreaseList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbDecreaseList.Location = new System.Drawing.Point(0, 0);
            this.grpbDecreaseList.Name = "grpbDecreaseList";
            this.grpbDecreaseList.Size = new System.Drawing.Size(562, 192);
            this.grpbDecreaseList.TabIndex = 11;
            this.grpbDecreaseList.TabStop = false;
            this.grpbDecreaseList.Text = "Desperdicios";
            // 
            // dgvDecreaseList
            // 
            this.dgvDecreaseList.AllowUserToAddRows = false;
            this.dgvDecreaseList.AllowUserToDeleteRows = false;
            this.dgvDecreaseList.AllowUserToOrderColumns = true;
            this.dgvDecreaseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDecreaseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmDecreaseCodsec,
            this.clmDecreaseName,
            this.clmDecreaseDescription});
            this.dgvDecreaseList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDecreaseList.Location = new System.Drawing.Point(3, 16);
            this.dgvDecreaseList.Name = "dgvDecreaseList";
            this.dgvDecreaseList.ReadOnly = true;
            this.dgvDecreaseList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDecreaseList.Size = new System.Drawing.Size(556, 173);
            this.dgvDecreaseList.TabIndex = 1;
            this.dgvDecreaseList.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDecreaseList_RowHeaderMouseDoubleClick);
            // 
            // clmDecreaseCodsec
            // 
            this.clmDecreaseCodsec.HeaderText = "Codsec";
            this.clmDecreaseCodsec.Name = "clmDecreaseCodsec";
            this.clmDecreaseCodsec.ReadOnly = true;
            this.clmDecreaseCodsec.Visible = false;
            this.clmDecreaseCodsec.Width = 200;
            // 
            // clmDecreaseName
            // 
            this.clmDecreaseName.HeaderText = "Nombre";
            this.clmDecreaseName.Name = "clmDecreaseName";
            this.clmDecreaseName.ReadOnly = true;
            this.clmDecreaseName.Width = 200;
            // 
            // clmDecreaseDescription
            // 
            this.clmDecreaseDescription.HeaderText = "Descripción";
            this.clmDecreaseDescription.Name = "clmDecreaseDescription";
            this.clmDecreaseDescription.ReadOnly = true;
            this.clmDecreaseDescription.Width = 310;
            // 
            // btnDecreaseClose
            // 
            this.btnDecreaseClose.BackgroundImage = global::BPS.Lite.Properties.Resources.door_in;
            this.btnDecreaseClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDecreaseClose.Location = new System.Drawing.Point(32, 13);
            this.btnDecreaseClose.Name = "btnDecreaseClose";
            this.btnDecreaseClose.Size = new System.Drawing.Size(29, 25);
            this.btnDecreaseClose.TabIndex = 23;
            this.ttpWaste.SetToolTip(this.btnDecreaseClose, "s");
            this.btnDecreaseClose.UseVisualStyleBackColor = true;
            this.btnDecreaseClose.Click += new System.EventHandler(this.btnDecreaseClose_Click);
            // 
            // btnDecreaseAccept
            // 
            this.btnDecreaseAccept.BackgroundImage = global::BPS.Lite.Properties.Resources.accept;
            this.btnDecreaseAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDecreaseAccept.Location = new System.Drawing.Point(3, 13);
            this.btnDecreaseAccept.Name = "btnDecreaseAccept";
            this.btnDecreaseAccept.Size = new System.Drawing.Size(29, 25);
            this.btnDecreaseAccept.TabIndex = 27;
            this.ttpWaste.SetToolTip(this.btnDecreaseAccept, "Selecionar Desperdicios");
            this.btnDecreaseAccept.UseVisualStyleBackColor = true;
            this.btnDecreaseAccept.Click += new System.EventHandler(this.btnDecreaseAccept_Click);
            // 
            // grpbDecreaseFilters
            // 
            this.grpbDecreaseFilters.Location = new System.Drawing.Point(0, 189);
            this.grpbDecreaseFilters.Name = "grpbDecreaseFilters";
            this.grpbDecreaseFilters.Size = new System.Drawing.Size(491, 43);
            this.grpbDecreaseFilters.TabIndex = 12;
            this.grpbDecreaseFilters.TabStop = false;
            // 
            // grpbDecreaseButtons
            // 
            this.grpbDecreaseButtons.Controls.Add(this.btnDecreaseClose);
            this.grpbDecreaseButtons.Controls.Add(this.btnDecreaseAccept);
            this.grpbDecreaseButtons.Location = new System.Drawing.Point(493, 189);
            this.grpbDecreaseButtons.Name = "grpbDecreaseButtons";
            this.grpbDecreaseButtons.Size = new System.Drawing.Size(65, 43);
            this.grpbDecreaseButtons.TabIndex = 13;
            this.grpbDecreaseButtons.TabStop = false;
            // 
            // frmDecreaseSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(562, 232);
            this.Controls.Add(this.grpbDecreaseList);
            this.Controls.Add(this.grpbDecreaseFilters);
            this.Controls.Add(this.grpbDecreaseButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDecreaseSelector";
            this.Text = "Desperdicios";
            this.Load += new System.EventHandler(this.frmDecreaseSelector_Load);
            this.grpbDecreaseList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDecreaseList)).EndInit();
            this.grpbDecreaseButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbDecreaseList;
        private System.Windows.Forms.DataGridView dgvDecreaseList;
        private System.Windows.Forms.Button btnDecreaseClose;
        private System.Windows.Forms.Button btnDecreaseAccept;
        private System.Windows.Forms.GroupBox grpbDecreaseFilters;
        private System.Windows.Forms.GroupBox grpbDecreaseButtons;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDecreaseCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDecreaseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDecreaseDescription;
        private System.Windows.Forms.ToolTip ttpWaste;
    }
}