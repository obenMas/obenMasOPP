namespace BPS
{
    partial class frmMetallizedProductionOrderDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMetallizedProductionOrderDetails));
            this.ttpDetailExtruction = new System.Windows.Forms.ToolTip(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.tbpDetail = new System.Windows.Forms.TabPage();
            this.grpbProductionOrderMainCoil = new System.Windows.Forms.GroupBox();
            this.dgvProductionOrderMainCoil = new System.Windows.Forms.DataGridView();
            this.grpbProductionOrderDetailsFilters = new System.Windows.Forms.GroupBox();
            this.lblVatiation = new System.Windows.Forms.Label();
            this.grpbDetail = new System.Windows.Forms.GroupBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblInitDate = new System.Windows.Forms.Label();
            this.lblInitDateLabel = new System.Windows.Forms.Label();
            this.lblMainCoilEndDate = new System.Windows.Forms.Label();
            this.txtProductionOrderDetailFilm = new System.Windows.Forms.Label();
            this.txtProductionOrderMachine = new System.Windows.Forms.Label();
            this.txtProductionOrderDetailNumber = new System.Windows.Forms.Label();
            this.lblProductionOrderMachine = new System.Windows.Forms.Label();
            this.lblProductionOrderDetailFilm = new System.Windows.Forms.Label();
            this.lblProductionOrderDetailNumber = new System.Windows.Forms.Label();
            this.tbcProductionOrder = new System.Windows.Forms.TabControl();
            this.clmProductionOrderMainCoilCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductionOrderMainCoilCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductionOrderMainCoilBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductionOrderMainCoilWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductionOrderMainCoilLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductionOrderMainCoilStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductionOrderEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmProductionOrderOutLine = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmProductionOrderCoilQuality = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmProductionOrderDeleteMainCoil = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbpDetail.SuspendLayout();
            this.grpbProductionOrderMainCoil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductionOrderMainCoil)).BeginInit();
            this.grpbProductionOrderDetailsFilters.SuspendLayout();
            this.grpbDetail.SuspendLayout();
            this.tbcProductionOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnExit.Location = new System.Drawing.Point(697, 17);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 23);
            this.btnExit.TabIndex = 2;
            this.ttpDetailExtruction.SetToolTip(this.btnExit, "Salir Orden de Extrusión");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(104, 14);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(194, 20);
            this.textBox15.TabIndex = 9;
            // 
            // tbpDetail
            // 
            this.tbpDetail.Controls.Add(this.grpbProductionOrderMainCoil);
            this.tbpDetail.Controls.Add(this.grpbProductionOrderDetailsFilters);
            this.tbpDetail.Controls.Add(this.grpbDetail);
            this.tbpDetail.Location = new System.Drawing.Point(4, 24);
            this.tbpDetail.Name = "tbpDetail";
            this.tbpDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDetail.Size = new System.Drawing.Size(731, 447);
            this.tbpDetail.TabIndex = 0;
            this.tbpDetail.Text = "Detalle de orden metalizado";
            this.tbpDetail.UseVisualStyleBackColor = true;
            // 
            // grpbProductionOrderMainCoil
            // 
            this.grpbProductionOrderMainCoil.Controls.Add(this.dgvProductionOrderMainCoil);
            this.grpbProductionOrderMainCoil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbProductionOrderMainCoil.Location = new System.Drawing.Point(3, 163);
            this.grpbProductionOrderMainCoil.Name = "grpbProductionOrderMainCoil";
            this.grpbProductionOrderMainCoil.Size = new System.Drawing.Size(725, 238);
            this.grpbProductionOrderMainCoil.TabIndex = 26;
            this.grpbProductionOrderMainCoil.TabStop = false;
            this.grpbProductionOrderMainCoil.Text = "Detalle rollos madre";
            // 
            // dgvProductionOrderMainCoil
            // 
            this.dgvProductionOrderMainCoil.AllowUserToAddRows = false;
            this.dgvProductionOrderMainCoil.AllowUserToDeleteRows = false;
            this.dgvProductionOrderMainCoil.AllowUserToOrderColumns = true;
            this.dgvProductionOrderMainCoil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductionOrderMainCoil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmProductionOrderMainCoilCodsec,
            this.clmProductionOrderMainCoilCode,
            this.clmProductionOrderMainCoilBatch,
            this.clmProductionOrderMainCoilWeigth,
            this.clmProductionOrderMainCoilLength,
            this.clmProductionOrderMainCoilStatus,
            this.clmProductionOrderEdit,
            this.clmProductionOrderOutLine,
            this.clmProductionOrderCoilQuality,
            this.clmProductionOrderDeleteMainCoil});
            this.dgvProductionOrderMainCoil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductionOrderMainCoil.Location = new System.Drawing.Point(3, 17);
            this.dgvProductionOrderMainCoil.Name = "dgvProductionOrderMainCoil";
            this.dgvProductionOrderMainCoil.ReadOnly = true;
            this.dgvProductionOrderMainCoil.Size = new System.Drawing.Size(719, 218);
            this.dgvProductionOrderMainCoil.TabIndex = 0;
            this.dgvProductionOrderMainCoil.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductionOrderMainCoil_CellClick);
            // 
            // grpbProductionOrderDetailsFilters
            // 
            this.grpbProductionOrderDetailsFilters.Controls.Add(this.lblVatiation);
            this.grpbProductionOrderDetailsFilters.Controls.Add(this.btnExit);
            this.grpbProductionOrderDetailsFilters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbProductionOrderDetailsFilters.Location = new System.Drawing.Point(3, 401);
            this.grpbProductionOrderDetailsFilters.Name = "grpbProductionOrderDetailsFilters";
            this.grpbProductionOrderDetailsFilters.Size = new System.Drawing.Size(725, 43);
            this.grpbProductionOrderDetailsFilters.TabIndex = 27;
            this.grpbProductionOrderDetailsFilters.TabStop = false;
            // 
            // lblVatiation
            // 
            this.lblVatiation.AutoSize = true;
            this.lblVatiation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblVatiation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVatiation.Location = new System.Drawing.Point(6, 18);
            this.lblVatiation.Name = "lblVatiation";
            this.lblVatiation.Size = new System.Drawing.Size(0, 15);
            this.lblVatiation.TabIndex = 1;
            // 
            // grpbDetail
            // 
            this.grpbDetail.Controls.Add(this.lblNotes);
            this.grpbDetail.Controls.Add(this.label5);
            this.grpbDetail.Controls.Add(this.lblEndDate);
            this.grpbDetail.Controls.Add(this.lblInitDate);
            this.grpbDetail.Controls.Add(this.lblInitDateLabel);
            this.grpbDetail.Controls.Add(this.lblMainCoilEndDate);
            this.grpbDetail.Controls.Add(this.txtProductionOrderDetailFilm);
            this.grpbDetail.Controls.Add(this.txtProductionOrderMachine);
            this.grpbDetail.Controls.Add(this.txtProductionOrderDetailNumber);
            this.grpbDetail.Controls.Add(this.lblProductionOrderMachine);
            this.grpbDetail.Controls.Add(this.lblProductionOrderDetailFilm);
            this.grpbDetail.Controls.Add(this.lblProductionOrderDetailNumber);
            this.grpbDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbDetail.Location = new System.Drawing.Point(3, 3);
            this.grpbDetail.Name = "grpbDetail";
            this.grpbDetail.Size = new System.Drawing.Size(725, 160);
            this.grpbDetail.TabIndex = 31;
            this.grpbDetail.TabStop = false;
            this.grpbDetail.Text = "Detalle de orden";
            // 
            // lblNotes
            // 
            this.lblNotes.BackColor = System.Drawing.SystemColors.Window;
            this.lblNotes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNotes.Location = new System.Drawing.Point(100, 72);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(611, 85);
            this.lblNotes.TabIndex = 60;
            this.lblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 59;
            this.label5.Text = "Observaciones";
            // 
            // lblEndDate
            // 
            this.lblEndDate.BackColor = System.Drawing.SystemColors.Window;
            this.lblEndDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEndDate.Location = new System.Drawing.Point(552, 42);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(159, 21);
            this.lblEndDate.TabIndex = 57;
            this.lblEndDate.Tag = "numericClearOnReload";
            this.lblEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInitDate
            // 
            this.lblInitDate.BackColor = System.Drawing.SystemColors.Window;
            this.lblInitDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInitDate.Location = new System.Drawing.Point(552, 16);
            this.lblInitDate.Name = "lblInitDate";
            this.lblInitDate.Size = new System.Drawing.Size(159, 21);
            this.lblInitDate.TabIndex = 58;
            this.lblInitDate.Tag = "numericClearOnReload";
            this.lblInitDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInitDateLabel
            // 
            this.lblInitDateLabel.AutoSize = true;
            this.lblInitDateLabel.Location = new System.Drawing.Point(508, 19);
            this.lblInitDateLabel.Name = "lblInitDateLabel";
            this.lblInitDateLabel.Size = new System.Drawing.Size(38, 15);
            this.lblInitDateLabel.TabIndex = 55;
            this.lblInitDateLabel.Text = "Metal";
            // 
            // lblMainCoilEndDate
            // 
            this.lblMainCoilEndDate.AutoSize = true;
            this.lblMainCoilEndDate.Location = new System.Drawing.Point(486, 45);
            this.lblMainCoilEndDate.Name = "lblMainCoilEndDate";
            this.lblMainCoilEndDate.Size = new System.Drawing.Size(60, 15);
            this.lblMainCoilEndDate.TabIndex = 56;
            this.lblMainCoilEndDate.Text = "Densidad";
            // 
            // txtProductionOrderDetailFilm
            // 
            this.txtProductionOrderDetailFilm.BackColor = System.Drawing.SystemColors.Window;
            this.txtProductionOrderDetailFilm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtProductionOrderDetailFilm.Location = new System.Drawing.Point(319, 16);
            this.txtProductionOrderDetailFilm.Name = "txtProductionOrderDetailFilm";
            this.txtProductionOrderDetailFilm.Size = new System.Drawing.Size(159, 21);
            this.txtProductionOrderDetailFilm.TabIndex = 32;
            this.txtProductionOrderDetailFilm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtProductionOrderMachine
            // 
            this.txtProductionOrderMachine.BackColor = System.Drawing.SystemColors.Window;
            this.txtProductionOrderMachine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtProductionOrderMachine.Location = new System.Drawing.Point(102, 42);
            this.txtProductionOrderMachine.Name = "txtProductionOrderMachine";
            this.txtProductionOrderMachine.Size = new System.Drawing.Size(150, 21);
            this.txtProductionOrderMachine.TabIndex = 34;
            this.txtProductionOrderMachine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtProductionOrderDetailNumber
            // 
            this.txtProductionOrderDetailNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtProductionOrderDetailNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtProductionOrderDetailNumber.Location = new System.Drawing.Point(102, 16);
            this.txtProductionOrderDetailNumber.Name = "txtProductionOrderDetailNumber";
            this.txtProductionOrderDetailNumber.Size = new System.Drawing.Size(159, 21);
            this.txtProductionOrderDetailNumber.TabIndex = 31;
            this.txtProductionOrderDetailNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProductionOrderMachine
            // 
            this.lblProductionOrderMachine.AutoSize = true;
            this.lblProductionOrderMachine.Location = new System.Drawing.Point(44, 45);
            this.lblProductionOrderMachine.Name = "lblProductionOrderMachine";
            this.lblProductionOrderMachine.Size = new System.Drawing.Size(52, 15);
            this.lblProductionOrderMachine.TabIndex = 30;
            this.lblProductionOrderMachine.Text = "Bobinas";
            // 
            // lblProductionOrderDetailFilm
            // 
            this.lblProductionOrderDetailFilm.AutoSize = true;
            this.lblProductionOrderDetailFilm.Location = new System.Drawing.Point(278, 19);
            this.lblProductionOrderDetailFilm.Name = "lblProductionOrderDetailFilm";
            this.lblProductionOrderDetailFilm.Size = new System.Drawing.Size(35, 15);
            this.lblProductionOrderDetailFilm.TabIndex = 29;
            this.lblProductionOrderDetailFilm.Text = "Base";
            // 
            // lblProductionOrderDetailNumber
            // 
            this.lblProductionOrderDetailNumber.AutoSize = true;
            this.lblProductionOrderDetailNumber.Location = new System.Drawing.Point(65, 19);
            this.lblProductionOrderDetailNumber.Name = "lblProductionOrderDetailNumber";
            this.lblProductionOrderDetailNumber.Size = new System.Drawing.Size(31, 15);
            this.lblProductionOrderDetailNumber.TabIndex = 28;
            this.lblProductionOrderDetailNumber.Text = "Lote";
            // 
            // tbcProductionOrder
            // 
            this.tbcProductionOrder.Controls.Add(this.tbpDetail);
            this.tbcProductionOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcProductionOrder.Location = new System.Drawing.Point(0, 0);
            this.tbcProductionOrder.Name = "tbcProductionOrder";
            this.tbcProductionOrder.SelectedIndex = 0;
            this.tbcProductionOrder.Size = new System.Drawing.Size(739, 475);
            this.tbcProductionOrder.TabIndex = 0;
            // 
            // clmProductionOrderMainCoilCodsec
            // 
            this.clmProductionOrderMainCoilCodsec.HeaderText = "Codsec";
            this.clmProductionOrderMainCoilCodsec.Name = "clmProductionOrderMainCoilCodsec";
            this.clmProductionOrderMainCoilCodsec.ReadOnly = true;
            this.clmProductionOrderMainCoilCodsec.Visible = false;
            // 
            // clmProductionOrderMainCoilCode
            // 
            this.clmProductionOrderMainCoilCode.HeaderText = "Código";
            this.clmProductionOrderMainCoilCode.Name = "clmProductionOrderMainCoilCode";
            this.clmProductionOrderMainCoilCode.ReadOnly = true;
            this.clmProductionOrderMainCoilCode.Width = 150;
            // 
            // clmProductionOrderMainCoilBatch
            // 
            this.clmProductionOrderMainCoilBatch.HeaderText = "Lote";
            this.clmProductionOrderMainCoilBatch.Name = "clmProductionOrderMainCoilBatch";
            this.clmProductionOrderMainCoilBatch.ReadOnly = true;
            this.clmProductionOrderMainCoilBatch.Width = 115;
            // 
            // clmProductionOrderMainCoilWeigth
            // 
            this.clmProductionOrderMainCoilWeigth.HeaderText = "Peso";
            this.clmProductionOrderMainCoilWeigth.Name = "clmProductionOrderMainCoilWeigth";
            this.clmProductionOrderMainCoilWeigth.ReadOnly = true;
            this.clmProductionOrderMainCoilWeigth.Width = 115;
            // 
            // clmProductionOrderMainCoilLength
            // 
            this.clmProductionOrderMainCoilLength.HeaderText = "Metraje";
            this.clmProductionOrderMainCoilLength.Name = "clmProductionOrderMainCoilLength";
            this.clmProductionOrderMainCoilLength.ReadOnly = true;
            this.clmProductionOrderMainCoilLength.Width = 115;
            // 
            // clmProductionOrderMainCoilStatus
            // 
            this.clmProductionOrderMainCoilStatus.HeaderText = "Estado";
            this.clmProductionOrderMainCoilStatus.Name = "clmProductionOrderMainCoilStatus";
            this.clmProductionOrderMainCoilStatus.ReadOnly = true;
            this.clmProductionOrderMainCoilStatus.Width = 115;
            // 
            // clmProductionOrderEdit
            // 
            this.clmProductionOrderEdit.HeaderText = "";
            this.clmProductionOrderEdit.Name = "clmProductionOrderEdit";
            this.clmProductionOrderEdit.ReadOnly = true;
            this.clmProductionOrderEdit.Visible = false;
            this.clmProductionOrderEdit.Width = 25;
            // 
            // clmProductionOrderOutLine
            // 
            this.clmProductionOrderOutLine.HeaderText = "";
            this.clmProductionOrderOutLine.Name = "clmProductionOrderOutLine";
            this.clmProductionOrderOutLine.ReadOnly = true;
            this.clmProductionOrderOutLine.Visible = false;
            this.clmProductionOrderOutLine.Width = 25;
            // 
            // clmProductionOrderCoilQuality
            // 
            this.clmProductionOrderCoilQuality.HeaderText = "";
            this.clmProductionOrderCoilQuality.Name = "clmProductionOrderCoilQuality";
            this.clmProductionOrderCoilQuality.ReadOnly = true;
            this.clmProductionOrderCoilQuality.Visible = false;
            this.clmProductionOrderCoilQuality.Width = 25;
            // 
            // clmProductionOrderDeleteMainCoil
            // 
            this.clmProductionOrderDeleteMainCoil.HeaderText = "";
            this.clmProductionOrderDeleteMainCoil.Name = "clmProductionOrderDeleteMainCoil";
            this.clmProductionOrderDeleteMainCoil.ReadOnly = true;
            this.clmProductionOrderDeleteMainCoil.Visible = false;
            this.clmProductionOrderDeleteMainCoil.Width = 25;
            // 
            // frmMetallizedProductionOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(739, 475);
            this.Controls.Add(this.tbcProductionOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMetallizedProductionOrderDetails";
            this.Text = "Detalle Orden Metalizado";
            this.Load += new System.EventHandler(this.frmProductionOrderDetails_Load);
            this.tbpDetail.ResumeLayout(false);
            this.grpbProductionOrderMainCoil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductionOrderMainCoil)).EndInit();
            this.grpbProductionOrderDetailsFilters.ResumeLayout(false);
            this.grpbProductionOrderDetailsFilters.PerformLayout();
            this.grpbDetail.ResumeLayout(false);
            this.grpbDetail.PerformLayout();
            this.tbcProductionOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip ttpDetailExtruction;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TabPage tbpDetail;
        private System.Windows.Forms.GroupBox grpbProductionOrderMainCoil;
        private System.Windows.Forms.DataGridView dgvProductionOrderMainCoil;
        private System.Windows.Forms.GroupBox grpbProductionOrderDetailsFilters;
        private System.Windows.Forms.Label lblVatiation;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpbDetail;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblInitDate;
        private System.Windows.Forms.Label lblInitDateLabel;
        private System.Windows.Forms.Label lblMainCoilEndDate;
        private System.Windows.Forms.Label txtProductionOrderDetailFilm;
        private System.Windows.Forms.Label txtProductionOrderMachine;
        private System.Windows.Forms.Label txtProductionOrderDetailNumber;
        private System.Windows.Forms.Label lblProductionOrderMachine;
        private System.Windows.Forms.Label lblProductionOrderDetailFilm;
        private System.Windows.Forms.Label lblProductionOrderDetailNumber;
        private System.Windows.Forms.TabControl tbcProductionOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductionOrderMainCoilCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductionOrderMainCoilCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductionOrderMainCoilBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductionOrderMainCoilWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductionOrderMainCoilLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductionOrderMainCoilStatus;
        private System.Windows.Forms.DataGridViewImageColumn clmProductionOrderEdit;
        private System.Windows.Forms.DataGridViewImageColumn clmProductionOrderOutLine;
        private System.Windows.Forms.DataGridViewImageColumn clmProductionOrderCoilQuality;
        private System.Windows.Forms.DataGridViewImageColumn clmProductionOrderDeleteMainCoil;

    }
}