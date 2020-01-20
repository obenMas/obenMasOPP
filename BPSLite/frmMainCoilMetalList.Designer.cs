namespace BPS.Lite
{
    partial class frmMainCoilMetalList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainCoilMetalList));
            this.dgvMainCoilList = new System.Windows.Forms.DataGridView();
            this.grpbMainCoilList = new System.Windows.Forms.GroupBox();
            this.btnMainCoilClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMainCoilCode = new System.Windows.Forms.TextBox();
            this.lblMainCoilCode = new System.Windows.Forms.Label();
            this.clmMainCoilListCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListFilmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListProductionOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListLabRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListAnalistRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListInitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListQuality = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmMainCoilListQualityReport = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmMainCoilListDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmMainCoilSecundaryProperties = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainCoilList)).BeginInit();
            this.grpbMainCoilList.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMainCoilList
            // 
            this.dgvMainCoilList.AllowUserToAddRows = false;
            this.dgvMainCoilList.AllowUserToDeleteRows = false;
            this.dgvMainCoilList.AllowUserToOrderColumns = true;
            this.dgvMainCoilList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainCoilList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMainCoilListCodsec,
            this.clmMainCoilListFilmType,
            this.clmMainCoilListFilm,
            this.clmMainCoilListCode,
            this.clmcode,
            this.clmMainCoilListBatch,
            this.clmMainCoilListProductionOrder,
            this.clmMainCoilListLabRating,
            this.clmMainCoilListAnalistRating,
            this.clmMainCoilListInitDate,
            this.clmMainCoilListEndDate,
            this.clmMainCoilListQuality,
            this.clmMainCoilListQualityReport,
            this.clmMainCoilListDelete,
            this.clmMainCoilSecundaryProperties});
            this.dgvMainCoilList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMainCoilList.Location = new System.Drawing.Point(3, 17);
            this.dgvMainCoilList.Name = "dgvMainCoilList";
            this.dgvMainCoilList.ReadOnly = true;
            this.dgvMainCoilList.RowHeadersWidth = 31;
            this.dgvMainCoilList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMainCoilList.Size = new System.Drawing.Size(1125, 439);
            this.dgvMainCoilList.TabIndex = 1;
            this.dgvMainCoilList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMainCoilList_CellClick);
            // 
            // grpbMainCoilList
            // 
            this.grpbMainCoilList.Controls.Add(this.dgvMainCoilList);
            this.grpbMainCoilList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbMainCoilList.Location = new System.Drawing.Point(0, 0);
            this.grpbMainCoilList.Name = "grpbMainCoilList";
            this.grpbMainCoilList.Size = new System.Drawing.Size(1131, 459);
            this.grpbMainCoilList.TabIndex = 14;
            this.grpbMainCoilList.TabStop = false;
            this.grpbMainCoilList.Text = "Rollos Madres Metalizados";
            // 
            // btnMainCoilClose
            // 
            this.btnMainCoilClose.BackgroundImage = global::BPS.Lite.Properties.Resources.door_in;
            this.btnMainCoilClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMainCoilClose.Location = new System.Drawing.Point(1101, 16);
            this.btnMainCoilClose.Name = "btnMainCoilClose";
            this.btnMainCoilClose.Size = new System.Drawing.Size(25, 25);
            this.btnMainCoilClose.TabIndex = 23;
            this.btnMainCoilClose.UseVisualStyleBackColor = true;
            this.btnMainCoilClose.Click += new System.EventHandler(this.btnMainCoilClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMainCoilClose);
            this.groupBox1.Controls.Add(this.txtMainCoilCode);
            this.groupBox1.Controls.Add(this.lblMainCoilCode);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 459);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1131, 49);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // txtMainCoilCode
            // 
            this.txtMainCoilCode.Location = new System.Drawing.Point(471, 18);
            this.txtMainCoilCode.Name = "txtMainCoilCode";
            this.txtMainCoilCode.Size = new System.Drawing.Size(287, 21);
            this.txtMainCoilCode.TabIndex = 1;
            this.txtMainCoilCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMainCoilCode_KeyDown);
            // 
            // lblMainCoilCode
            // 
            this.lblMainCoilCode.AutoSize = true;
            this.lblMainCoilCode.Location = new System.Drawing.Point(336, 21);
            this.lblMainCoilCode.Name = "lblMainCoilCode";
            this.lblMainCoilCode.Size = new System.Drawing.Size(129, 15);
            this.lblMainCoilCode.TabIndex = 0;
            this.lblMainCoilCode.Text = "Código de rollo madre";
            // 
            // clmMainCoilListCodsec
            // 
            this.clmMainCoilListCodsec.HeaderText = "Codsec";
            this.clmMainCoilListCodsec.Name = "clmMainCoilListCodsec";
            this.clmMainCoilListCodsec.ReadOnly = true;
            this.clmMainCoilListCodsec.Visible = false;
            this.clmMainCoilListCodsec.Width = 200;
            // 
            // clmMainCoilListFilmType
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmMainCoilListFilmType.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmMainCoilListFilmType.HeaderText = "Tipo";
            this.clmMainCoilListFilmType.Name = "clmMainCoilListFilmType";
            this.clmMainCoilListFilmType.ReadOnly = true;
            this.clmMainCoilListFilmType.Width = 60;
            // 
            // clmMainCoilListFilm
            // 
            this.clmMainCoilListFilm.HeaderText = "Película";
            this.clmMainCoilListFilm.Name = "clmMainCoilListFilm";
            this.clmMainCoilListFilm.ReadOnly = true;
            // 
            // clmMainCoilListCode
            // 
            this.clmMainCoilListCode.HeaderText = "Código";
            this.clmMainCoilListCode.Name = "clmMainCoilListCode";
            this.clmMainCoilListCode.ReadOnly = true;
            this.clmMainCoilListCode.Width = 130;
            // 
            // clmcode
            // 
            this.clmcode.HeaderText = "Code";
            this.clmcode.Name = "clmcode";
            this.clmcode.ReadOnly = true;
            // 
            // clmMainCoilListBatch
            // 
            this.clmMainCoilListBatch.HeaderText = "Lote";
            this.clmMainCoilListBatch.Name = "clmMainCoilListBatch";
            this.clmMainCoilListBatch.ReadOnly = true;
            this.clmMainCoilListBatch.Width = 90;
            // 
            // clmMainCoilListProductionOrder
            // 
            this.clmMainCoilListProductionOrder.HeaderText = "Origen";
            this.clmMainCoilListProductionOrder.Name = "clmMainCoilListProductionOrder";
            this.clmMainCoilListProductionOrder.ReadOnly = true;
            this.clmMainCoilListProductionOrder.Width = 80;
            // 
            // clmMainCoilListLabRating
            // 
            this.clmMainCoilListLabRating.HeaderText = "Calif. Lab.";
            this.clmMainCoilListLabRating.Name = "clmMainCoilListLabRating";
            this.clmMainCoilListLabRating.ReadOnly = true;
            this.clmMainCoilListLabRating.Width = 85;
            // 
            // clmMainCoilListAnalistRating
            // 
            this.clmMainCoilListAnalistRating.HeaderText = "Calif. An.";
            this.clmMainCoilListAnalistRating.Name = "clmMainCoilListAnalistRating";
            this.clmMainCoilListAnalistRating.ReadOnly = true;
            this.clmMainCoilListAnalistRating.Width = 85;
            // 
            // clmMainCoilListInitDate
            // 
            this.clmMainCoilListInitDate.HeaderText = "Fecha Inicio";
            this.clmMainCoilListInitDate.Name = "clmMainCoilListInitDate";
            this.clmMainCoilListInitDate.ReadOnly = true;
            this.clmMainCoilListInitDate.Width = 130;
            // 
            // clmMainCoilListEndDate
            // 
            this.clmMainCoilListEndDate.HeaderText = "Fecha Fin";
            this.clmMainCoilListEndDate.Name = "clmMainCoilListEndDate";
            this.clmMainCoilListEndDate.ReadOnly = true;
            this.clmMainCoilListEndDate.Width = 130;
            // 
            // clmMainCoilListQuality
            // 
            this.clmMainCoilListQuality.HeaderText = "";
            this.clmMainCoilListQuality.Name = "clmMainCoilListQuality";
            this.clmMainCoilListQuality.ReadOnly = true;
            this.clmMainCoilListQuality.Visible = false;
            this.clmMainCoilListQuality.Width = 25;
            // 
            // clmMainCoilListQualityReport
            // 
            this.clmMainCoilListQualityReport.HeaderText = "";
            this.clmMainCoilListQualityReport.Name = "clmMainCoilListQualityReport";
            this.clmMainCoilListQualityReport.ReadOnly = true;
            this.clmMainCoilListQualityReport.Width = 25;
            // 
            // clmMainCoilListDelete
            // 
            this.clmMainCoilListDelete.HeaderText = "";
            this.clmMainCoilListDelete.Name = "clmMainCoilListDelete";
            this.clmMainCoilListDelete.ReadOnly = true;
            this.clmMainCoilListDelete.Visible = false;
            this.clmMainCoilListDelete.Width = 25;
            // 
            // clmMainCoilSecundaryProperties
            // 
            this.clmMainCoilSecundaryProperties.HeaderText = "";
            this.clmMainCoilSecundaryProperties.Name = "clmMainCoilSecundaryProperties";
            this.clmMainCoilSecundaryProperties.ReadOnly = true;
            this.clmMainCoilSecundaryProperties.Width = 30;
            // 
            // frmMainCoilMetalList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1131, 508);
            this.Controls.Add(this.grpbMainCoilList);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainCoilMetalList";
            this.Text = "Lista Rollos Madres Metalizados";
            this.Load += new System.EventHandler(this.frmMainCoilMetalList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainCoilList)).EndInit();
            this.grpbMainCoilList.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMainCoilList;
        private System.Windows.Forms.GroupBox grpbMainCoilList;
        private System.Windows.Forms.Button btnMainCoilClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMainCoilCode;
        private System.Windows.Forms.Label lblMainCoilCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListFilmType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListProductionOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListLabRating;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListAnalistRating;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListInitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListEndDate;
        private System.Windows.Forms.DataGridViewImageColumn clmMainCoilListQuality;
        private System.Windows.Forms.DataGridViewImageColumn clmMainCoilListQualityReport;
        private System.Windows.Forms.DataGridViewImageColumn clmMainCoilListDelete;
        private System.Windows.Forms.DataGridViewImageColumn clmMainCoilSecundaryProperties;
    }
}