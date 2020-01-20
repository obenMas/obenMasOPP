namespace BPS
{
    partial class frmCuttingOrderList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuttingOrderList));
            this.grpbList = new System.Windows.Forms.GroupBox();
            this.dgvCuttingOrder = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatus = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMachineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFilmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPositions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRepetitions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProgrammedWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIsSecundaryCut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbEmpty = new System.Windows.Forms.GroupBox();
            this.lblInformationColor1 = new System.Windows.Forms.Label();
            this.lblInformation1 = new System.Windows.Forms.Label();
            this.lblInformation2 = new System.Windows.Forms.Label();
            this.lblInformation3 = new System.Windows.Forms.Label();
            this.lblInformationColor3 = new System.Windows.Forms.Label();
            this.lblInformationColor2 = new System.Windows.Forms.Label();
            this.grpbMainCoilButtons = new System.Windows.Forms.GroupBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.grpbCuttingOrderDetail = new System.Windows.Forms.GroupBox();
            this.grpbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuttingOrder)).BeginInit();
            this.grpbEmpty.SuspendLayout();
            this.grpbMainCoilButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbList
            // 
            this.grpbList.Controls.Add(this.dgvCuttingOrder);
            this.grpbList.Controls.Add(this.grpbEmpty);
            this.grpbList.Controls.Add(this.grpbMainCoilButtons);
            this.grpbList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbList.Location = new System.Drawing.Point(0, 0);
            this.grpbList.Name = "grpbList";
            this.grpbList.Size = new System.Drawing.Size(1084, 334);
            this.grpbList.TabIndex = 0;
            this.grpbList.TabStop = false;
            this.grpbList.Text = "Listado de ordenes";
            // 
            // dgvCuttingOrder
            // 
            this.dgvCuttingOrder.AllowUserToAddRows = false;
            this.dgvCuttingOrder.AllowUserToDeleteRows = false;
            this.dgvCuttingOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuttingOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmPrio,
            this.clmStatus,
            this.clmOrderNumber,
            this.clmMachineName,
            this.clmFilmName,
            this.clmPositions,
            this.clmRepetitions,
            this.clmProgrammedWeigth,
            this.clmCreatedDate,
            this.clmIsSecundaryCut});
            this.dgvCuttingOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCuttingOrder.Location = new System.Drawing.Point(3, 17);
            this.dgvCuttingOrder.Name = "dgvCuttingOrder";
            this.dgvCuttingOrder.Size = new System.Drawing.Size(1078, 269);
            this.dgvCuttingOrder.TabIndex = 0;
            this.dgvCuttingOrder.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuttingOrder_CellEndEdit);
            this.dgvCuttingOrder.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCuttingOrder_CellMouseClick);
            this.dgvCuttingOrder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvCuttingOrder_KeyDown);
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "Num.";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Width = 50;
            // 
            // clmPrio
            // 
            this.clmPrio.HeaderText = "Prioridad";
            this.clmPrio.Name = "clmPrio";
            this.clmPrio.Width = 60;
            // 
            // clmStatus
            // 
            this.clmStatus.HeaderText = "Estado";
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.ReadOnly = true;
            this.clmStatus.Width = 50;
            // 
            // clmOrderNumber
            // 
            this.clmOrderNumber.HeaderText = "Orden";
            this.clmOrderNumber.Name = "clmOrderNumber";
            this.clmOrderNumber.ReadOnly = true;
            this.clmOrderNumber.Visible = false;
            this.clmOrderNumber.Width = 60;
            // 
            // clmMachineName
            // 
            this.clmMachineName.HeaderText = "Máquina";
            this.clmMachineName.Name = "clmMachineName";
            this.clmMachineName.ReadOnly = true;
            this.clmMachineName.Width = 150;
            // 
            // clmFilmName
            // 
            this.clmFilmName.HeaderText = "Película";
            this.clmFilmName.Name = "clmFilmName";
            this.clmFilmName.ReadOnly = true;
            this.clmFilmName.Width = 150;
            // 
            // clmPositions
            // 
            this.clmPositions.HeaderText = "Posiciones";
            this.clmPositions.Name = "clmPositions";
            this.clmPositions.ReadOnly = true;
            this.clmPositions.Width = 270;
            // 
            // clmRepetitions
            // 
            this.clmRepetitions.HeaderText = "Repeticiones";
            this.clmRepetitions.Name = "clmRepetitions";
            this.clmRepetitions.ReadOnly = true;
            // 
            // clmProgrammedWeigth
            // 
            this.clmProgrammedWeigth.HeaderText = "Peso";
            this.clmProgrammedWeigth.Name = "clmProgrammedWeigth";
            this.clmProgrammedWeigth.ReadOnly = true;
            // 
            // clmCreatedDate
            // 
            this.clmCreatedDate.HeaderText = "Creado";
            this.clmCreatedDate.Name = "clmCreatedDate";
            this.clmCreatedDate.ReadOnly = true;
            this.clmCreatedDate.Width = 140;
            // 
            // clmIsSecundaryCut
            // 
            this.clmIsSecundaryCut.HeaderText = "isSecundary";
            this.clmIsSecundaryCut.Name = "clmIsSecundaryCut";
            this.clmIsSecundaryCut.ReadOnly = true;
            this.clmIsSecundaryCut.Visible = false;
            // 
            // grpbEmpty
            // 
            this.grpbEmpty.Controls.Add(this.lblInformationColor1);
            this.grpbEmpty.Controls.Add(this.lblInformation1);
            this.grpbEmpty.Controls.Add(this.lblInformation2);
            this.grpbEmpty.Controls.Add(this.lblInformation3);
            this.grpbEmpty.Controls.Add(this.lblInformationColor3);
            this.grpbEmpty.Controls.Add(this.lblInformationColor2);
            this.grpbEmpty.Location = new System.Drawing.Point(3, 284);
            this.grpbEmpty.Name = "grpbEmpty";
            this.grpbEmpty.Size = new System.Drawing.Size(1044, 44);
            this.grpbEmpty.TabIndex = 36;
            this.grpbEmpty.TabStop = false;
            // 
            // lblInformationColor1
            // 
            this.lblInformationColor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInformationColor1.Location = new System.Drawing.Point(326, 20);
            this.lblInformationColor1.Name = "lblInformationColor1";
            this.lblInformationColor1.Size = new System.Drawing.Size(13, 13);
            this.lblInformationColor1.TabIndex = 1;
            // 
            // lblInformation1
            // 
            this.lblInformation1.AutoSize = true;
            this.lblInformation1.Location = new System.Drawing.Point(342, 19);
            this.lblInformation1.Name = "lblInformation1";
            this.lblInformation1.Size = new System.Drawing.Size(85, 15);
            this.lblInformation1.TabIndex = 2;
            this.lblInformation1.Text = "Corte primario";
            // 
            // lblInformation2
            // 
            this.lblInformation2.AutoSize = true;
            this.lblInformation2.Location = new System.Drawing.Point(466, 19);
            this.lblInformation2.Name = "lblInformation2";
            this.lblInformation2.Size = new System.Drawing.Size(100, 15);
            this.lblInformation2.TabIndex = 4;
            this.lblInformation2.Text = "Corte secundario";
            // 
            // lblInformation3
            // 
            this.lblInformation3.AutoSize = true;
            this.lblInformation3.Location = new System.Drawing.Point(605, 19);
            this.lblInformation3.Name = "lblInformation3";
            this.lblInformation3.Size = new System.Drawing.Size(114, 15);
            this.lblInformation3.TabIndex = 6;
            this.lblInformation3.Text = "Orden en ejecución";
            // 
            // lblInformationColor3
            // 
            this.lblInformationColor3.BackColor = System.Drawing.Color.Orange;
            this.lblInformationColor3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInformationColor3.Location = new System.Drawing.Point(589, 20);
            this.lblInformationColor3.Name = "lblInformationColor3";
            this.lblInformationColor3.Size = new System.Drawing.Size(13, 13);
            this.lblInformationColor3.TabIndex = 5;
            // 
            // lblInformationColor2
            // 
            this.lblInformationColor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblInformationColor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInformationColor2.Location = new System.Drawing.Point(450, 20);
            this.lblInformationColor2.Name = "lblInformationColor2";
            this.lblInformationColor2.Size = new System.Drawing.Size(13, 13);
            this.lblInformationColor2.TabIndex = 3;
            // 
            // grpbMainCoilButtons
            // 
            this.grpbMainCoilButtons.Controls.Add(this.btnReport);
            this.grpbMainCoilButtons.Location = new System.Drawing.Point(1051, 284);
            this.grpbMainCoilButtons.Name = "grpbMainCoilButtons";
            this.grpbMainCoilButtons.Size = new System.Drawing.Size(30, 44);
            this.grpbMainCoilButtons.TabIndex = 37;
            this.grpbMainCoilButtons.TabStop = false;
            // 
            // btnReport
            // 
            this.btnReport.Image = global::BPS.Properties.Resources.doc_excel_table;
            this.btnReport.Location = new System.Drawing.Point(2, 14);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(25, 25);
            this.btnReport.TabIndex = 0;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // grpbCuttingOrderDetail
            // 
            this.grpbCuttingOrderDetail.Location = new System.Drawing.Point(0, 334);
            this.grpbCuttingOrderDetail.Name = "grpbCuttingOrderDetail";
            this.grpbCuttingOrderDetail.Size = new System.Drawing.Size(1081, 248);
            this.grpbCuttingOrderDetail.TabIndex = 1;
            this.grpbCuttingOrderDetail.TabStop = false;
            this.grpbCuttingOrderDetail.Text = "Detalle";
            // 
            // frmCuttingOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1084, 583);
            this.Controls.Add(this.grpbCuttingOrderDetail);
            this.Controls.Add(this.grpbList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCuttingOrderList";
            this.Text = "Listado de ordenes de corte";
            this.Load += new System.EventHandler(this.frmCuttingOrderList_Load);
            this.grpbList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuttingOrder)).EndInit();
            this.grpbEmpty.ResumeLayout(false);
            this.grpbEmpty.PerformLayout();
            this.grpbMainCoilButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbList;
        private System.Windows.Forms.DataGridView dgvCuttingOrder;
        private System.Windows.Forms.GroupBox grpbCuttingOrderDetail;
        private System.Windows.Forms.Label lblInformation2;
        private System.Windows.Forms.Label lblInformationColor2;
        private System.Windows.Forms.Label lblInformation1;
        private System.Windows.Forms.Label lblInformationColor1;
        private System.Windows.Forms.Label lblInformation3;
        private System.Windows.Forms.Label lblInformationColor3;
        private System.Windows.Forms.GroupBox grpbEmpty;
        private System.Windows.Forms.GroupBox grpbMainCoilButtons;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrio;
        private System.Windows.Forms.DataGridViewImageColumn clmStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMachineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFilmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPositions;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRepetitions;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProgrammedWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIsSecundaryCut;
    }
}