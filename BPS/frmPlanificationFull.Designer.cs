namespace BPS
{
    partial class frmPlanificationFull
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlanificationFull));
            this.grpbPlanification = new System.Windows.Forms.GroupBox();
            this.lblPlanificationDate = new System.Windows.Forms.Label();
            this.dtpPlanification = new System.Windows.Forms.DateTimePicker();
            this.grpbPlanificationFull = new System.Windows.Forms.GroupBox();
            this.crvPlanification = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.grpbPlanification.SuspendLayout();
            this.grpbPlanificationFull.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbPlanification
            // 
            this.grpbPlanification.Controls.Add(this.dtpPlanification);
            this.grpbPlanification.Controls.Add(this.lblPlanificationDate);
            this.grpbPlanification.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbPlanification.Location = new System.Drawing.Point(0, 0);
            this.grpbPlanification.Name = "grpbPlanification";
            this.grpbPlanification.Size = new System.Drawing.Size(1053, 50);
            this.grpbPlanification.TabIndex = 0;
            this.grpbPlanification.TabStop = false;
            this.grpbPlanification.Text = "Planificación";
            // 
            // lblPlanificationDate
            // 
            this.lblPlanificationDate.AutoSize = true;
            this.lblPlanificationDate.Location = new System.Drawing.Point(337, 20);
            this.lblPlanificationDate.Name = "lblPlanificationDate";
            this.lblPlanificationDate.Size = new System.Drawing.Size(120, 15);
            this.lblPlanificationDate.TabIndex = 0;
            this.lblPlanificationDate.Text = "Fecha Planificación :";
            // 
            // dtpPlanification
            // 
            this.dtpPlanification.Location = new System.Drawing.Point(464, 18);
            this.dtpPlanification.Name = "dtpPlanification";
            this.dtpPlanification.Size = new System.Drawing.Size(252, 21);
            this.dtpPlanification.TabIndex = 1;
            this.dtpPlanification.CloseUp += new System.EventHandler(this.dtpPlanification_CloseUp);
            // 
            // grpbPlanificationFull
            // 
            this.grpbPlanificationFull.Controls.Add(this.crvPlanification);
            this.grpbPlanificationFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbPlanificationFull.Location = new System.Drawing.Point(0, 50);
            this.grpbPlanificationFull.Name = "grpbPlanificationFull";
            this.grpbPlanificationFull.Size = new System.Drawing.Size(1053, 511);
            this.grpbPlanificationFull.TabIndex = 1;
            this.grpbPlanificationFull.TabStop = false;
            // 
            // crvPlanification
            // 
            this.crvPlanification.ActiveViewIndex = -1;
            this.crvPlanification.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvPlanification.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvPlanification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvPlanification.Location = new System.Drawing.Point(3, 17);
            this.crvPlanification.Name = "crvPlanification";
            this.crvPlanification.ShowGroupTreeButton = false;
            this.crvPlanification.ShowParameterPanelButton = false;
            this.crvPlanification.ShowRefreshButton = false;
            this.crvPlanification.ShowZoomButton = false;
            this.crvPlanification.Size = new System.Drawing.Size(1047, 491);
            this.crvPlanification.TabIndex = 0;
            this.crvPlanification.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmPlanificationFull
            //  
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1053, 561);
            this.Controls.Add(this.grpbPlanificationFull);
            this.Controls.Add(this.grpbPlanification);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPlanificationFull";
            this.Text = "Planifiacción Grupal";
            this.grpbPlanification.ResumeLayout(false);
            this.grpbPlanification.PerformLayout();
            this.grpbPlanificationFull.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbPlanification;
        private System.Windows.Forms.DateTimePicker dtpPlanification;
        private System.Windows.Forms.Label lblPlanificationDate;
        private System.Windows.Forms.GroupBox grpbPlanificationFull;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvPlanification;
    }
}