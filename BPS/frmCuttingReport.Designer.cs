namespace BPS
{
    partial class frmCuttingReport
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuttingReport));
            this.gpbCuttingOrder = new System.Windows.Forms.GroupBox();
            this.lblCutterNameLabel = new System.Windows.Forms.Label();
            this.lblCutterName = new System.Windows.Forms.Label();
            this.dgvCuttingOrder = new System.Windows.Forms.DataGridView();
            this.clmCodSec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMachineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFilmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStops = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbCuttingOrders = new System.Windows.Forms.GroupBox();
            this.gpbCuttingOrderDetails = new System.Windows.Forms.GroupBox();
            this.dgvDetailsCutting = new System.Windows.Forms.DataGridView();
            this.clmCodSecDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPositionDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEntity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOrdeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmwidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmlength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalCoil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbReport = new System.Windows.Forms.GroupBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.ttpCuttingReport = new System.Windows.Forms.ToolTip(this.components);
            this.gpbCuttingOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuttingOrder)).BeginInit();
            this.gpbCuttingOrders.SuspendLayout();
            this.gpbCuttingOrderDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailsCutting)).BeginInit();
            this.gpbReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbCuttingOrder
            // 
            this.gpbCuttingOrder.Controls.Add(this.lblCutterNameLabel);
            this.gpbCuttingOrder.Controls.Add(this.lblCutterName);
            this.gpbCuttingOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbCuttingOrder.Location = new System.Drawing.Point(0, 0);
            this.gpbCuttingOrder.Name = "gpbCuttingOrder";
            this.gpbCuttingOrder.Size = new System.Drawing.Size(988, 46);
            this.gpbCuttingOrder.TabIndex = 1;
            this.gpbCuttingOrder.TabStop = false;
            this.gpbCuttingOrder.Text = "Orden De Corte";
            // 
            // lblCutterNameLabel
            // 
            this.lblCutterNameLabel.AutoSize = true;
            this.lblCutterNameLabel.Location = new System.Drawing.Point(411, 20);
            this.lblCutterNameLabel.Name = "lblCutterNameLabel";
            this.lblCutterNameLabel.Size = new System.Drawing.Size(61, 15);
            this.lblCutterNameLabel.TabIndex = 69;
            this.lblCutterNameLabel.Text = "Cortadora";
            // 
            // lblCutterName
            // 
            this.lblCutterName.BackColor = System.Drawing.SystemColors.Window;
            this.lblCutterName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCutterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCutterName.Location = new System.Drawing.Point(478, 17);
            this.lblCutterName.Name = "lblCutterName";
            this.lblCutterName.Size = new System.Drawing.Size(99, 21);
            this.lblCutterName.TabIndex = 67;
            this.lblCutterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvCuttingOrder
            // 
            this.dgvCuttingOrder.AllowUserToAddRows = false;
            this.dgvCuttingOrder.AllowUserToDeleteRows = false;
            this.dgvCuttingOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuttingOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodSec,
            this.clmMachineName,
            this.clmFilmName,
            this.clmPosition,
            this.clmStops});
            this.dgvCuttingOrder.Location = new System.Drawing.Point(3, 10);
            this.dgvCuttingOrder.Name = "dgvCuttingOrder";
            this.dgvCuttingOrder.ReadOnly = true;
            this.dgvCuttingOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCuttingOrder.Size = new System.Drawing.Size(982, 159);
            this.dgvCuttingOrder.TabIndex = 70;
            this.dgvCuttingOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuttingOrder_CellClick);
            // 
            // clmCodSec
            // 
            this.clmCodSec.HeaderText = "CodSec";
            this.clmCodSec.Name = "clmCodSec";
            this.clmCodSec.ReadOnly = true;
            this.clmCodSec.Visible = false;
            // 
            // clmMachineName
            // 
            this.clmMachineName.HeaderText = "Máquina";
            this.clmMachineName.Name = "clmMachineName";
            this.clmMachineName.ReadOnly = true;
            this.clmMachineName.Width = 200;
            // 
            // clmFilmName
            // 
            this.clmFilmName.HeaderText = "Película";
            this.clmFilmName.Name = "clmFilmName";
            this.clmFilmName.ReadOnly = true;
            this.clmFilmName.Width = 350;
            // 
            // clmPosition
            // 
            this.clmPosition.HeaderText = "Posiciones";
            this.clmPosition.Name = "clmPosition";
            this.clmPosition.ReadOnly = true;
            // 
            // clmStops
            // 
            this.clmStops.HeaderText = "Parádas";
            this.clmStops.Name = "clmStops";
            this.clmStops.ReadOnly = true;
            // 
            // gpbCuttingOrders
            // 
            this.gpbCuttingOrders.Controls.Add(this.dgvCuttingOrder);
            this.gpbCuttingOrders.Location = new System.Drawing.Point(0, 41);
            this.gpbCuttingOrders.Name = "gpbCuttingOrders";
            this.gpbCuttingOrders.Size = new System.Drawing.Size(988, 174);
            this.gpbCuttingOrders.TabIndex = 71;
            this.gpbCuttingOrders.TabStop = false;
            // 
            // gpbCuttingOrderDetails
            // 
            this.gpbCuttingOrderDetails.Controls.Add(this.dgvDetailsCutting);
            this.gpbCuttingOrderDetails.Location = new System.Drawing.Point(0, 213);
            this.gpbCuttingOrderDetails.Name = "gpbCuttingOrderDetails";
            this.gpbCuttingOrderDetails.Size = new System.Drawing.Size(988, 275);
            this.gpbCuttingOrderDetails.TabIndex = 72;
            this.gpbCuttingOrderDetails.TabStop = false;
            this.gpbCuttingOrderDetails.Text = "Detalles";
            // 
            // dgvDetailsCutting
            // 
            this.dgvDetailsCutting.AllowUserToAddRows = false;
            this.dgvDetailsCutting.AllowUserToDeleteRows = false;
            this.dgvDetailsCutting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailsCutting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodSecDetails,
            this.clmPositionDetails,
            this.clmEntity,
            this.clmOrdeNumber,
            this.clmProduct,
            this.clmwidth,
            this.clmlength,
            this.clmTotalCoil});
            this.dgvDetailsCutting.Location = new System.Drawing.Point(3, 20);
            this.dgvDetailsCutting.Name = "dgvDetailsCutting";
            this.dgvDetailsCutting.ReadOnly = true;
            this.dgvDetailsCutting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetailsCutting.Size = new System.Drawing.Size(982, 249);
            this.dgvDetailsCutting.TabIndex = 70;
            // 
            // clmCodSecDetails
            // 
            this.clmCodSecDetails.HeaderText = "codsec";
            this.clmCodSecDetails.Name = "clmCodSecDetails";
            this.clmCodSecDetails.ReadOnly = true;
            this.clmCodSecDetails.Visible = false;
            // 
            // clmPositionDetails
            // 
            this.clmPositionDetails.HeaderText = "Posición";
            this.clmPositionDetails.Name = "clmPositionDetails";
            this.clmPositionDetails.ReadOnly = true;
            // 
            // clmEntity
            // 
            this.clmEntity.HeaderText = "Cliente";
            this.clmEntity.Name = "clmEntity";
            this.clmEntity.ReadOnly = true;
            this.clmEntity.Width = 230;
            // 
            // clmOrdeNumber
            // 
            this.clmOrdeNumber.HeaderText = "Orden";
            this.clmOrdeNumber.Name = "clmOrdeNumber";
            this.clmOrdeNumber.ReadOnly = true;
            // 
            // clmProduct
            // 
            this.clmProduct.HeaderText = "Cod. Producto";
            this.clmProduct.Name = "clmProduct";
            this.clmProduct.ReadOnly = true;
            this.clmProduct.Width = 150;
            // 
            // clmwidth
            // 
            this.clmwidth.HeaderText = "Ancho";
            this.clmwidth.Name = "clmwidth";
            this.clmwidth.ReadOnly = true;
            // 
            // clmlength
            // 
            this.clmlength.HeaderText = "Longitud";
            this.clmlength.Name = "clmlength";
            this.clmlength.ReadOnly = true;
            // 
            // clmTotalCoil
            // 
            this.clmTotalCoil.HeaderText = "Total Boinas";
            this.clmTotalCoil.Name = "clmTotalCoil";
            this.clmTotalCoil.ReadOnly = true;
            this.clmTotalCoil.Width = 150;
            // 
            // gpbReport
            // 
            this.gpbReport.Controls.Add(this.btnReport);
            this.gpbReport.Location = new System.Drawing.Point(0, 484);
            this.gpbReport.Name = "gpbReport";
            this.gpbReport.Size = new System.Drawing.Size(988, 38);
            this.gpbReport.TabIndex = 73;
            this.gpbReport.TabStop = false;
            // 
            // btnReport
            // 
            this.btnReport.BackgroundImage = global::BPS.Properties.Resources.report;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReport.Location = new System.Drawing.Point(960, 10);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(25, 25);
            this.btnReport.TabIndex = 4;
            this.ttpCuttingReport.SetToolTip(this.btnReport, "Reporte");
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // frmCuttingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(988, 523);
            this.Controls.Add(this.gpbCuttingOrder);
            this.Controls.Add(this.gpbCuttingOrders);
            this.Controls.Add(this.gpbCuttingOrderDetails);
            this.Controls.Add(this.gpbReport);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCuttingReport";
            this.Text = "Corte";
            this.Load += new System.EventHandler(this.frmCuttingReport_Load);
            this.gpbCuttingOrder.ResumeLayout(false);
            this.gpbCuttingOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuttingOrder)).EndInit();
            this.gpbCuttingOrders.ResumeLayout(false);
            this.gpbCuttingOrderDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailsCutting)).EndInit();
            this.gpbReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCuttingOrder;
        private System.Windows.Forms.Label lblCutterNameLabel;
        private System.Windows.Forms.Label lblCutterName;
        private System.Windows.Forms.DataGridView dgvCuttingOrder;
        private System.Windows.Forms.GroupBox gpbCuttingOrders;
        private System.Windows.Forms.GroupBox gpbCuttingOrderDetails;
        private System.Windows.Forms.DataGridView dgvDetailsCutting;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodSec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMachineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFilmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStops;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodSecDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPositionDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEntity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrdeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmwidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmlength;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalCoil;
        private System.Windows.Forms.GroupBox gpbReport;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.ToolTip ttpCuttingReport;
    }
}