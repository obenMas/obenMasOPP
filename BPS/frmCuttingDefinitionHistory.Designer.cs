namespace BPS
{
    partial class frmCuttingDefinitionHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuttingDefinitionHistory));
            this.dgvCuttingDefinitionHistory = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMargin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEstimatedStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPlant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmReopen = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuttingDefinitionHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCuttingDefinitionHistory
            // 
            this.dgvCuttingDefinitionHistory.AllowUserToAddRows = false;
            this.dgvCuttingDefinitionHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuttingDefinitionHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmFilm,
            this.clmQuantity,
            this.clmMargin,
            this.clmEstimatedStart,
            this.clmStatus,
            this.clmPlant,
            this.clmView,
            this.clmReopen});
            this.dgvCuttingDefinitionHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCuttingDefinitionHistory.Location = new System.Drawing.Point(0, 0);
            this.dgvCuttingDefinitionHistory.Name = "dgvCuttingDefinitionHistory";
            this.dgvCuttingDefinitionHistory.Size = new System.Drawing.Size(797, 353);
            this.dgvCuttingDefinitionHistory.TabIndex = 0;
            this.dgvCuttingDefinitionHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuttingDefinitionHistory_CellContentClick);
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "N";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.Width = 80;
            // 
            // clmFilm
            // 
            this.clmFilm.HeaderText = "Pelicula";
            this.clmFilm.Name = "clmFilm";
            this.clmFilm.Width = 90;
            // 
            // clmQuantity
            // 
            this.clmQuantity.HeaderText = "Cantidad";
            this.clmQuantity.Name = "clmQuantity";
            // 
            // clmMargin
            // 
            this.clmMargin.HeaderText = "Margen";
            this.clmMargin.Name = "clmMargin";
            // 
            // clmEstimatedStart
            // 
            this.clmEstimatedStart.HeaderText = "Inicio Estimado";
            this.clmEstimatedStart.Name = "clmEstimatedStart";
            // 
            // clmStatus
            // 
            this.clmStatus.HeaderText = "Estado";
            this.clmStatus.Name = "clmStatus";
            // 
            // clmPlant
            // 
            this.clmPlant.HeaderText = "Planta";
            this.clmPlant.Name = "clmPlant";
            // 
            // clmView
            // 
            this.clmView.HeaderText = "";
            this.clmView.Name = "clmView";
            this.clmView.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmView.Text = "VER";
            this.clmView.UseColumnTextForButtonValue = true;
            // 
            // clmReopen
            // 
            this.clmReopen.HeaderText = "";
            this.clmReopen.Name = "clmReopen";
            this.clmReopen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmReopen.Text = "REABRIR";
            this.clmReopen.UseColumnTextForButtonValue = true;
            // 
            // frmCuttingDefinitionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 353);
            this.Controls.Add(this.dgvCuttingDefinitionHistory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCuttingDefinitionHistory";
            this.Text = "Historial Definiciones de Corte";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuttingDefinitionHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCuttingDefinitionHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMargin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEstimatedStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPlant;
        private System.Windows.Forms.DataGridViewButtonColumn clmView;
        private System.Windows.Forms.DataGridViewButtonColumn clmReopen;
    }
}