namespace BPS
{
    partial class frmMainCoilSecundaryProperties
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainCoilSecundaryProperties));
            this.ttpMainCoilList = new System.Windows.Forms.ToolTip(this.components);
            this.crvSecundaryProperties = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptMainCoilQualitySecundaryProperties1 = new BPS.Reports.rptMainCoilQualitySecundaryProperties();
            this.SuspendLayout();
            // 
            // crvSecundaryProperties
            // 
            this.crvSecundaryProperties.ActiveViewIndex = 0;
            this.crvSecundaryProperties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvSecundaryProperties.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvSecundaryProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvSecundaryProperties.Location = new System.Drawing.Point(0, 0);
            this.crvSecundaryProperties.Name = "crvSecundaryProperties";
            this.crvSecundaryProperties.ReportSource = this.rptMainCoilQualitySecundaryProperties1;
            this.crvSecundaryProperties.ShowGroupTreeButton = false;
            this.crvSecundaryProperties.ShowParameterPanelButton = false;
            this.crvSecundaryProperties.ShowRefreshButton = false;
            this.crvSecundaryProperties.Size = new System.Drawing.Size(1004, 532);
            this.crvSecundaryProperties.TabIndex = 0;
            this.crvSecundaryProperties.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmMainCoilSecundaryProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1004, 532);
            this.Controls.Add(this.crvSecundaryProperties);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainCoilSecundaryProperties";
            this.Text = "Propiedades Secundarias";
            this.Load += new System.EventHandler(this.frmMainCoilSecundaryProperties_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip ttpMainCoilList;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvSecundaryProperties;
        private Reports.rptMainCoilQualitySecundaryProperties rptMainCoilQualitySecundaryProperties1;
    }
}