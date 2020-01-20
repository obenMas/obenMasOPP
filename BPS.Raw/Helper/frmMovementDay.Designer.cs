namespace BPS.Raw.Helper
{
    partial class frmMovementDay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovementDay));
            this.grpbPackingList = new System.Windows.Forms.GroupBox();
            this.tbcReports = new System.Windows.Forms.TabControl();
            this.tbpUnifiedMovemet = new System.Windows.Forms.TabPage();
            this.crvUnifiedPackingList = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tbpDetailedMovement = new System.Windows.Forms.TabPage();
            this.crvDetailedPackingList = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.grpbTransport = new System.Windows.Forms.GroupBox();
            this.lblTransport = new System.Windows.Forms.Label();
            this.cmbIn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dptTime = new System.Windows.Forms.DateTimePicker();
            this.btnProcess = new System.Windows.Forms.Button();
            this.grpbPackingList.SuspendLayout();
            this.tbcReports.SuspendLayout();
            this.tbpUnifiedMovemet.SuspendLayout();
            this.tbpDetailedMovement.SuspendLayout();
            this.grpbTransport.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbPackingList
            // 
            this.grpbPackingList.Controls.Add(this.tbcReports);
            this.grpbPackingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbPackingList.Location = new System.Drawing.Point(0, 47);
            this.grpbPackingList.Name = "grpbPackingList";
            this.grpbPackingList.Size = new System.Drawing.Size(956, 453);
            this.grpbPackingList.TabIndex = 3;
            this.grpbPackingList.TabStop = false;
            this.grpbPackingList.Text = "Packing list";
            // 
            // tbcReports
            // 
            this.tbcReports.Controls.Add(this.tbpUnifiedMovemet);
            this.tbcReports.Controls.Add(this.tbpDetailedMovement);
            this.tbcReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcReports.Location = new System.Drawing.Point(3, 16);
            this.tbcReports.Name = "tbcReports";
            this.tbcReports.SelectedIndex = 0;
            this.tbcReports.Size = new System.Drawing.Size(950, 434);
            this.tbcReports.TabIndex = 0;
            // 
            // tbpUnifiedMovemet
            // 
            this.tbpUnifiedMovemet.Controls.Add(this.crvUnifiedPackingList);
            this.tbpUnifiedMovemet.Location = new System.Drawing.Point(4, 22);
            this.tbpUnifiedMovemet.Name = "tbpUnifiedMovemet";
            this.tbpUnifiedMovemet.Padding = new System.Windows.Forms.Padding(3);
            this.tbpUnifiedMovemet.Size = new System.Drawing.Size(942, 408);
            this.tbpUnifiedMovemet.TabIndex = 0;
            this.tbpUnifiedMovemet.Text = "Movimiento Diario";
            this.tbpUnifiedMovemet.UseVisualStyleBackColor = true;
            // 
            // crvUnifiedPackingList
            // 
            this.crvUnifiedPackingList.ActiveViewIndex = -1;
            this.crvUnifiedPackingList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvUnifiedPackingList.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvUnifiedPackingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvUnifiedPackingList.Location = new System.Drawing.Point(3, 3);
            this.crvUnifiedPackingList.Name = "crvUnifiedPackingList";
            this.crvUnifiedPackingList.ReuseParameterValuesOnRefresh = true;
            this.crvUnifiedPackingList.ShowGroupTreeButton = false;
            this.crvUnifiedPackingList.ShowParameterPanelButton = false;
            this.crvUnifiedPackingList.ShowRefreshButton = false;
            this.crvUnifiedPackingList.Size = new System.Drawing.Size(936, 402);
            this.crvUnifiedPackingList.TabIndex = 0;
            this.crvUnifiedPackingList.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // tbpDetailedMovement
            // 
            this.tbpDetailedMovement.Controls.Add(this.crvDetailedPackingList);
            this.tbpDetailedMovement.Location = new System.Drawing.Point(4, 22);
            this.tbpDetailedMovement.Name = "tbpDetailedMovement";
            this.tbpDetailedMovement.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDetailedMovement.Size = new System.Drawing.Size(923, 414);
            this.tbpDetailedMovement.TabIndex = 1;
            this.tbpDetailedMovement.Text = "Movimiento Detallado";
            this.tbpDetailedMovement.UseVisualStyleBackColor = true;
            // 
            // crvDetailedPackingList
            // 
            this.crvDetailedPackingList.ActiveViewIndex = -1;
            this.crvDetailedPackingList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvDetailedPackingList.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvDetailedPackingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvDetailedPackingList.Location = new System.Drawing.Point(3, 3);
            this.crvDetailedPackingList.Name = "crvDetailedPackingList";
            this.crvDetailedPackingList.ReuseParameterValuesOnRefresh = true;
            this.crvDetailedPackingList.ShowGroupTreeButton = false;
            this.crvDetailedPackingList.ShowParameterPanelButton = false;
            this.crvDetailedPackingList.ShowRefreshButton = false;
            this.crvDetailedPackingList.Size = new System.Drawing.Size(917, 408);
            this.crvDetailedPackingList.TabIndex = 0;
            this.crvDetailedPackingList.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // grpbTransport
            // 
            this.grpbTransport.Controls.Add(this.btnProcess);
            this.grpbTransport.Controls.Add(this.dptTime);
            this.grpbTransport.Controls.Add(this.label1);
            this.grpbTransport.Controls.Add(this.cmbIn);
            this.grpbTransport.Controls.Add(this.lblTransport);
            this.grpbTransport.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbTransport.Location = new System.Drawing.Point(0, 0);
            this.grpbTransport.Name = "grpbTransport";
            this.grpbTransport.Size = new System.Drawing.Size(956, 47);
            this.grpbTransport.TabIndex = 2;
            this.grpbTransport.TabStop = false;
            this.grpbTransport.Text = "Lista de transportes";
            // 
            // lblTransport
            // 
            this.lblTransport.AutoSize = true;
            this.lblTransport.Location = new System.Drawing.Point(242, 20);
            this.lblTransport.Name = "lblTransport";
            this.lblTransport.Size = new System.Drawing.Size(35, 13);
            this.lblTransport.TabIndex = 10;
            this.lblTransport.Text = "Turno";
            // 
            // cmbIn
            // 
            this.cmbIn.FormattingEnabled = true;
            this.cmbIn.Items.AddRange(new object[] {
            "Día",
            "Noche"});
            this.cmbIn.Location = new System.Drawing.Point(283, 17);
            this.cmbIn.Name = "cmbIn";
            this.cmbIn.Size = new System.Drawing.Size(121, 21);
            this.cmbIn.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fecha";
            // 
            // dptTime
            // 
            this.dptTime.Location = new System.Drawing.Point(469, 17);
            this.dptTime.Name = "dptTime";
            this.dptTime.Size = new System.Drawing.Size(200, 20);
            this.dptTime.TabIndex = 13;
            // 
            // btnProcess
            // 
            this.btnProcess.BackgroundImage = global::BPS.Raw.Properties.Resources.funnel;
            this.btnProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProcess.Location = new System.Drawing.Point(690, 14);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(24, 25);
            this.btnProcess.TabIndex = 14;
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // frmMovementDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(956, 500);
            this.Controls.Add(this.grpbPackingList);
            this.Controls.Add(this.grpbTransport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMovementDay";
            this.Text = "Movimiento Diario Abastecedores";
            this.grpbPackingList.ResumeLayout(false);
            this.tbcReports.ResumeLayout(false);
            this.tbpUnifiedMovemet.ResumeLayout(false);
            this.tbpDetailedMovement.ResumeLayout(false);
            this.grpbTransport.ResumeLayout(false);
            this.grpbTransport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbPackingList;
        private System.Windows.Forms.TabControl tbcReports;
        private System.Windows.Forms.TabPage tbpUnifiedMovemet;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvUnifiedPackingList;
        private System.Windows.Forms.TabPage tbpDetailedMovement;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvDetailedPackingList;
        private System.Windows.Forms.GroupBox grpbTransport;
        private System.Windows.Forms.Label lblTransport;
        private System.Windows.Forms.DateTimePicker dptTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbIn;
        private System.Windows.Forms.Button btnProcess;
    }
}