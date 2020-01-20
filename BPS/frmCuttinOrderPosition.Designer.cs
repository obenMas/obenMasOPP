namespace BPS
{
    partial class frmCuttinOrderPosition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuttinOrderPosition));
            this.grpbInfo = new System.Windows.Forms.GroupBox();
            this.dgvCuttingOrder = new System.Windows.Forms.DataGridView();
            this.grpbEmpty = new System.Windows.Forms.GroupBox();
            this.lblInformationColor1 = new System.Windows.Forms.Label();
            this.lblInformation1 = new System.Windows.Forms.Label();
            this.lblInformation2 = new System.Windows.Forms.Label();
            this.lblInformation3 = new System.Windows.Forms.Label();
            this.lblInformationColor3 = new System.Windows.Forms.Label();
            this.lblInformationColor2 = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.grpbFilter = new System.Windows.Forms.GroupBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpInitDate = new System.Windows.Forms.DateTimePicker();
            this.lblInitDate = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnUnfilter = new System.Windows.Forms.Button();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIsSecundaryCut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmachine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmfilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmpositions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmwidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuttingOrder)).BeginInit();
            this.grpbEmpty.SuspendLayout();
            this.grpbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbInfo
            // 
            this.grpbInfo.Controls.Add(this.dgvCuttingOrder);
            this.grpbInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbInfo.Location = new System.Drawing.Point(0, 44);
            this.grpbInfo.Name = "grpbInfo";
            this.grpbInfo.Size = new System.Drawing.Size(796, 485);
            this.grpbInfo.TabIndex = 0;
            this.grpbInfo.TabStop = false;
            this.grpbInfo.Text = "Listado de Ordenes";
            // 
            // dgvCuttingOrder
            // 
            this.dgvCuttingOrder.AllowUserToAddRows = false;
            this.dgvCuttingOrder.AllowUserToDeleteRows = false;
            this.dgvCuttingOrder.AllowUserToOrderColumns = true;
            this.dgvCuttingOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuttingOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmIsSecundaryCut,
            this.clmmachine,
            this.clmfilm,
            this.clmpositions,
            this.clmdate,
            this.clmwidth});
            this.dgvCuttingOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCuttingOrder.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvCuttingOrder.Location = new System.Drawing.Point(3, 16);
            this.dgvCuttingOrder.Name = "dgvCuttingOrder";
            this.dgvCuttingOrder.ReadOnly = true;
            this.dgvCuttingOrder.RowHeadersWidth = 21;
            this.dgvCuttingOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCuttingOrder.Size = new System.Drawing.Size(790, 466);
            this.dgvCuttingOrder.TabIndex = 0;
            // 
            // grpbEmpty
            // 
            this.grpbEmpty.Controls.Add(this.btnReport);
            this.grpbEmpty.Controls.Add(this.lblInformationColor1);
            this.grpbEmpty.Controls.Add(this.lblInformation1);
            this.grpbEmpty.Controls.Add(this.lblInformation2);
            this.grpbEmpty.Controls.Add(this.lblInformation3);
            this.grpbEmpty.Controls.Add(this.lblInformationColor3);
            this.grpbEmpty.Controls.Add(this.lblInformationColor2);
            this.grpbEmpty.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbEmpty.Location = new System.Drawing.Point(0, 529);
            this.grpbEmpty.Name = "grpbEmpty";
            this.grpbEmpty.Size = new System.Drawing.Size(796, 37);
            this.grpbEmpty.TabIndex = 38;
            this.grpbEmpty.TabStop = false;
            // 
            // lblInformationColor1
            // 
            this.lblInformationColor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInformationColor1.Location = new System.Drawing.Point(131, 14);
            this.lblInformationColor1.Name = "lblInformationColor1";
            this.lblInformationColor1.Size = new System.Drawing.Size(13, 13);
            this.lblInformationColor1.TabIndex = 1;
            // 
            // lblInformation1
            // 
            this.lblInformation1.AutoSize = true;
            this.lblInformation1.Location = new System.Drawing.Point(147, 13);
            this.lblInformation1.Name = "lblInformation1";
            this.lblInformation1.Size = new System.Drawing.Size(85, 15);
            this.lblInformation1.TabIndex = 2;
            this.lblInformation1.Text = "Corte primario";
            // 
            // lblInformation2
            // 
            this.lblInformation2.AutoSize = true;
            this.lblInformation2.Location = new System.Drawing.Point(271, 13);
            this.lblInformation2.Name = "lblInformation2";
            this.lblInformation2.Size = new System.Drawing.Size(100, 15);
            this.lblInformation2.TabIndex = 4;
            this.lblInformation2.Text = "Corte secundario";
            // 
            // lblInformation3
            // 
            this.lblInformation3.AutoSize = true;
            this.lblInformation3.Location = new System.Drawing.Point(410, 13);
            this.lblInformation3.Name = "lblInformation3";
            this.lblInformation3.Size = new System.Drawing.Size(114, 15);
            this.lblInformation3.TabIndex = 6;
            this.lblInformation3.Text = "Orden en ejecución";
            // 
            // lblInformationColor3
            // 
            this.lblInformationColor3.BackColor = System.Drawing.Color.Orange;
            this.lblInformationColor3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInformationColor3.Location = new System.Drawing.Point(394, 14);
            this.lblInformationColor3.Name = "lblInformationColor3";
            this.lblInformationColor3.Size = new System.Drawing.Size(13, 13);
            this.lblInformationColor3.TabIndex = 5;
            // 
            // lblInformationColor2
            // 
            this.lblInformationColor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblInformationColor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInformationColor2.Location = new System.Drawing.Point(255, 14);
            this.lblInformationColor2.Name = "lblInformationColor2";
            this.lblInformationColor2.Size = new System.Drawing.Size(13, 13);
            this.lblInformationColor2.TabIndex = 3;
            // 
            // btnReport
            // 
            this.btnReport.Image = global::BPS.Properties.Resources.report;
            this.btnReport.Location = new System.Drawing.Point(758, 8);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(25, 25);
            this.btnReport.TabIndex = 0;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // grpbFilter
            // 
            this.grpbFilter.Controls.Add(this.btnFilter);
            this.grpbFilter.Controls.Add(this.btnUnfilter);
            this.grpbFilter.Controls.Add(this.dtpEndDate);
            this.grpbFilter.Controls.Add(this.lblEndDate);
            this.grpbFilter.Controls.Add(this.dtpInitDate);
            this.grpbFilter.Controls.Add(this.lblInitDate);
            this.grpbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbFilter.Location = new System.Drawing.Point(0, 0);
            this.grpbFilter.Name = "grpbFilter";
            this.grpbFilter.Size = new System.Drawing.Size(796, 44);
            this.grpbFilter.TabIndex = 40;
            this.grpbFilter.TabStop = false;
            this.grpbFilter.Text = "Fechas de Creación";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(448, 16);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(244, 21);
            this.dtpEndDate.TabIndex = 3;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(375, 18);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(67, 15);
            this.lblEndDate.TabIndex = 2;
            this.lblEndDate.Text = "Fecha Fin :";
            // 
            // dtpInitDate
            // 
            this.dtpInitDate.Location = new System.Drawing.Point(99, 16);
            this.dtpInitDate.Name = "dtpInitDate";
            this.dtpInitDate.Size = new System.Drawing.Size(244, 21);
            this.dtpInitDate.TabIndex = 1;
            // 
            // lblInitDate
            // 
            this.lblInitDate.AutoSize = true;
            this.lblInitDate.Location = new System.Drawing.Point(14, 18);
            this.lblInitDate.Name = "lblInitDate";
            this.lblInitDate.Size = new System.Drawing.Size(79, 15);
            this.lblInitDate.TabIndex = 0;
            this.lblInitDate.Text = "Fecha Inicio :";
            // 
            // btnFilter
            // 
            this.btnFilter.Image = global::BPS.Properties.Resources.funnel;
            this.btnFilter.Location = new System.Drawing.Point(758, 13);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(25, 25);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnUnfilter
            // 
            this.btnUnfilter.Image = global::BPS.Properties.Resources.funnel_clear;
            this.btnUnfilter.Location = new System.Drawing.Point(732, 13);
            this.btnUnfilter.Name = "btnUnfilter";
            this.btnUnfilter.Size = new System.Drawing.Size(25, 25);
            this.btnUnfilter.TabIndex = 4;
            this.btnUnfilter.UseVisualStyleBackColor = true;
            this.btnUnfilter.Click += new System.EventHandler(this.btnUnfilter_Click);
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "Codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmIsSecundaryCut
            // 
            this.clmIsSecundaryCut.HeaderText = "SecundaryCut";
            this.clmIsSecundaryCut.Name = "clmIsSecundaryCut";
            this.clmIsSecundaryCut.ReadOnly = true;
            this.clmIsSecundaryCut.Visible = false;
            // 
            // clmmachine
            // 
            this.clmmachine.HeaderText = "Máquina";
            this.clmmachine.Name = "clmmachine";
            this.clmmachine.ReadOnly = true;
            this.clmmachine.Width = 90;
            // 
            // clmfilm
            // 
            this.clmfilm.HeaderText = "Película";
            this.clmfilm.Name = "clmfilm";
            this.clmfilm.ReadOnly = true;
            // 
            // clmpositions
            // 
            this.clmpositions.HeaderText = "Posiciones";
            this.clmpositions.Name = "clmpositions";
            this.clmpositions.ReadOnly = true;
            this.clmpositions.Width = 250;
            // 
            // clmdate
            // 
            this.clmdate.HeaderText = "Creado";
            this.clmdate.Name = "clmdate";
            this.clmdate.ReadOnly = true;
            // 
            // clmwidth
            // 
            this.clmwidth.HeaderText = "Ancho Utilizado";
            this.clmwidth.Name = "clmwidth";
            this.clmwidth.ReadOnly = true;
            this.clmwidth.Width = 120;
            // 
            // frmCuttinOrderPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(796, 566);
            this.Controls.Add(this.grpbInfo);
            this.Controls.Add(this.grpbEmpty);
            this.Controls.Add(this.grpbFilter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCuttinOrderPosition";
            this.Text = "Reporte por Cortadoras";
            this.Load += new System.EventHandler(this.frmCuttinOrderPosition_Load);
            this.grpbInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuttingOrder)).EndInit();
            this.grpbEmpty.ResumeLayout(false);
            this.grpbEmpty.PerformLayout();
            this.grpbFilter.ResumeLayout(false);
            this.grpbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbInfo;
        private System.Windows.Forms.DataGridView dgvCuttingOrder;
        private System.Windows.Forms.GroupBox grpbEmpty;
        private System.Windows.Forms.Label lblInformationColor1;
        private System.Windows.Forms.Label lblInformation1;
        private System.Windows.Forms.Label lblInformation2;
        private System.Windows.Forms.Label lblInformation3;
        private System.Windows.Forms.Label lblInformationColor3;
        private System.Windows.Forms.Label lblInformationColor2;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.GroupBox grpbFilter;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpInitDate;
        private System.Windows.Forms.Label lblInitDate;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnUnfilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIsSecundaryCut;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmachine;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmpositions;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmwidth;
    }
}