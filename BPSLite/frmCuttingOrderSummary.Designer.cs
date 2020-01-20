namespace BPS.Lite
{
    partial class frmCuttingOrderSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuttingOrderSummary));
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Orden de corte #", 2, 2);
            this.ilstStopStatus = new System.Windows.Forms.ImageList(this.components);
            this.grpbInfo = new System.Windows.Forms.GroupBox();
            this.grpbCuttingOrderInfo = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFilmName = new System.Windows.Forms.Label();
            this.lblCutterName = new System.Windows.Forms.Label();
            this.trvStopViews = new System.Windows.Forms.TreeView();
            this.grpbStop = new System.Windows.Forms.GroupBox();
            this.chkManualWeight = new System.Windows.Forms.CheckBox();
            this.lblDensity = new System.Windows.Forms.Label();
            this.lblNetWeight = new System.Windows.Forms.Label();
            this.dgvCoils = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDiameter = new System.Windows.Forms.TextBox();
            this.lblDensityLabel = new System.Windows.Forms.Label();
            this.lblNetWeightLabel = new System.Windows.Forms.Label();
            this.lblWeigth = new System.Windows.Forms.Label();
            this.lblWidthValue = new System.Windows.Forms.Label();
            this.lblPositionValue = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblDiameter = new System.Windows.Forms.Label();
            this.txtManualGrossWeigth = new System.Windows.Forms.TextBox();
            this.lblWeigthValue = new System.Windows.Forms.Label();
            this.ttpCuttingOrderSummary = new System.Windows.Forms.ToolTip(this.components);
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbInfo.SuspendLayout();
            this.grpbCuttingOrderInfo.SuspendLayout();
            this.grpbStop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoils)).BeginInit();
            this.SuspendLayout();
            // 
            // ilstStopStatus
            // 
            this.ilstStopStatus.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilstStopStatus.ImageStream")));
            this.ilstStopStatus.TransparentColor = System.Drawing.Color.Transparent;
            this.ilstStopStatus.Images.SetKeyName(0, "lock_unlock.png");
            this.ilstStopStatus.Images.SetKeyName(1, "lock.png");
            this.ilstStopStatus.Images.SetKeyName(2, "cut.png");
            // 
            // grpbInfo
            // 
            this.grpbInfo.Controls.Add(this.grpbCuttingOrderInfo);
            this.grpbInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbInfo.Location = new System.Drawing.Point(0, 0);
            this.grpbInfo.Name = "grpbInfo";
            this.grpbInfo.Size = new System.Drawing.Size(982, 96);
            this.grpbInfo.TabIndex = 0;
            this.grpbInfo.TabStop = false;
            this.grpbInfo.Text = "Orden de corte # 1234";
            // 
            // grpbCuttingOrderInfo
            // 
            this.grpbCuttingOrderInfo.Controls.Add(this.groupBox1);
            this.grpbCuttingOrderInfo.Controls.Add(this.lblFilmName);
            this.grpbCuttingOrderInfo.Controls.Add(this.lblCutterName);
            this.grpbCuttingOrderInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbCuttingOrderInfo.Location = new System.Drawing.Point(3, 17);
            this.grpbCuttingOrderInfo.Name = "grpbCuttingOrderInfo";
            this.grpbCuttingOrderInfo.Size = new System.Drawing.Size(976, 73);
            this.grpbCuttingOrderInfo.TabIndex = 0;
            this.grpbCuttingOrderInfo.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(559, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(2, 60);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lblFilmName
            // 
            this.lblFilmName.BackColor = System.Drawing.SystemColors.Window;
            this.lblFilmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmName.Location = new System.Drawing.Point(58, 12);
            this.lblFilmName.Name = "lblFilmName";
            this.lblFilmName.Size = new System.Drawing.Size(450, 57);
            this.lblFilmName.TabIndex = 1;
            this.lblFilmName.Text = "FH050";
            this.lblFilmName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCutterName
            // 
            this.lblCutterName.BackColor = System.Drawing.SystemColors.Window;
            this.lblCutterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCutterName.Location = new System.Drawing.Point(612, 12);
            this.lblCutterName.Name = "lblCutterName";
            this.lblCutterName.Size = new System.Drawing.Size(361, 57);
            this.lblCutterName.TabIndex = 3;
            this.lblCutterName.Text = "Cortadora 4";
            this.lblCutterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trvStopViews
            // 
            this.trvStopViews.Dock = System.Windows.Forms.DockStyle.Left;
            this.trvStopViews.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvStopViews.ImageIndex = 0;
            this.trvStopViews.ImageList = this.ilstStopStatus;
            this.trvStopViews.Location = new System.Drawing.Point(0, 96);
            this.trvStopViews.Name = "trvStopViews";
            treeNode2.ImageIndex = 2;
            treeNode2.Name = "trnCuttingOrder";
            treeNode2.SelectedImageIndex = 2;
            treeNode2.Text = "Orden de corte #";
            this.trvStopViews.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.trvStopViews.SelectedImageIndex = 0;
            this.trvStopViews.Size = new System.Drawing.Size(268, 453);
            this.trvStopViews.TabIndex = 1;
            this.trvStopViews.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvStopViews_AfterSelect);
            this.trvStopViews.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvStopViews_NodeMouseClick);
            // 
            // grpbStop
            // 
            this.grpbStop.Controls.Add(this.chkManualWeight);
            this.grpbStop.Controls.Add(this.lblDensity);
            this.grpbStop.Controls.Add(this.lblNetWeight);
            this.grpbStop.Controls.Add(this.dgvCoils);
            this.grpbStop.Controls.Add(this.btnAdd);
            this.grpbStop.Controls.Add(this.txtDiameter);
            this.grpbStop.Controls.Add(this.lblDensityLabel);
            this.grpbStop.Controls.Add(this.lblNetWeightLabel);
            this.grpbStop.Controls.Add(this.lblWeigth);
            this.grpbStop.Controls.Add(this.lblWidthValue);
            this.grpbStop.Controls.Add(this.lblPositionValue);
            this.grpbStop.Controls.Add(this.lblWidth);
            this.grpbStop.Controls.Add(this.lblPosition);
            this.grpbStop.Controls.Add(this.lblDiameter);
            this.grpbStop.Controls.Add(this.txtManualGrossWeigth);
            this.grpbStop.Controls.Add(this.lblWeigthValue);
            this.grpbStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbStop.Location = new System.Drawing.Point(268, 96);
            this.grpbStop.Name = "grpbStop";
            this.grpbStop.Size = new System.Drawing.Size(714, 453);
            this.grpbStop.TabIndex = 2;
            this.grpbStop.TabStop = false;
            this.grpbStop.Text = "Parada ";
            // 
            // chkManualWeight
            // 
            this.chkManualWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkManualWeight.Location = new System.Drawing.Point(165, 128);
            this.chkManualWeight.Name = "chkManualWeight";
            this.chkManualWeight.Size = new System.Drawing.Size(80, 48);
            this.chkManualWeight.TabIndex = 7;
            this.chkManualWeight.Text = "Toma Manual";
            this.chkManualWeight.UseVisualStyleBackColor = true;
            this.chkManualWeight.CheckedChanged += new System.EventHandler(this.chkManualWeight_CheckedChanged);
            // 
            // lblDensity
            // 
            this.lblDensity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDensity.Location = new System.Drawing.Point(417, 129);
            this.lblDensity.Name = "lblDensity";
            this.lblDensity.Size = new System.Drawing.Size(121, 47);
            this.lblDensity.TabIndex = 9;
            this.lblDensity.Text = "0";
            this.lblDensity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNetWeight
            // 
            this.lblNetWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNetWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetWeight.Location = new System.Drawing.Point(245, 129);
            this.lblNetWeight.Name = "lblNetWeight";
            this.lblNetWeight.Size = new System.Drawing.Size(121, 47);
            this.lblNetWeight.TabIndex = 8;
            this.lblNetWeight.Text = "0";
            this.lblNetWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvCoils
            // 
            this.dgvCoils.AllowUserToAddRows = false;
            this.dgvCoils.AllowUserToDeleteRows = false;
            this.dgvCoils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoils.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmOrderNumber,
            this.clmPosition,
            this.clmWidth,
            this.clmWeigth,
            this.clmDiameter});
            this.dgvCoils.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCoils.Location = new System.Drawing.Point(3, 179);
            this.dgvCoils.Name = "dgvCoils";
            this.dgvCoils.ReadOnly = true;
            this.dgvCoils.RowHeadersWidth = 15;
            this.dgvCoils.Size = new System.Drawing.Size(708, 271);
            this.dgvCoils.TabIndex = 9;
            this.dgvCoils.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCoils_CellMouseClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::BPS.Lite.Properties.Resources.tick_48;
            this.btnAdd.Location = new System.Drawing.Point(644, 106);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 64);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDiameter
            // 
            this.txtDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiameter.Location = new System.Drawing.Point(618, 28);
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.Size = new System.Drawing.Size(90, 47);
            this.txtDiameter.TabIndex = 5;
            this.txtDiameter.Text = "0";
            this.txtDiameter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiameter.TextChanged += new System.EventHandler(this.txtDiameter_TextChanged);
            this.txtDiameter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDiameter_KeyDown);
            // 
            // lblDensityLabel
            // 
            this.lblDensityLabel.AutoSize = true;
            this.lblDensityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDensityLabel.Location = new System.Drawing.Point(396, 86);
            this.lblDensityLabel.Name = "lblDensityLabel";
            this.lblDensityLabel.Size = new System.Drawing.Size(163, 39);
            this.lblDensityLabel.TabIndex = 4;
            this.lblDensityLabel.Text = "Densidad";
            // 
            // lblNetWeightLabel
            // 
            this.lblNetWeightLabel.AutoSize = true;
            this.lblNetWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetWeightLabel.Location = new System.Drawing.Point(219, 86);
            this.lblNetWeightLabel.Name = "lblNetWeightLabel";
            this.lblNetWeightLabel.Size = new System.Drawing.Size(172, 39);
            this.lblNetWeightLabel.TabIndex = 4;
            this.lblNetWeightLabel.Text = "Peso neto";
            // 
            // lblWeigth
            // 
            this.lblWeigth.AutoSize = true;
            this.lblWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeigth.Location = new System.Drawing.Point(4, 86);
            this.lblWeigth.Name = "lblWeigth";
            this.lblWeigth.Size = new System.Drawing.Size(184, 39);
            this.lblWeigth.TabIndex = 4;
            this.lblWeigth.Text = "Peso bruto";
            // 
            // lblWidthValue
            // 
            this.lblWidthValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWidthValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidthValue.Location = new System.Drawing.Point(406, 27);
            this.lblWidthValue.Name = "lblWidthValue";
            this.lblWidthValue.Size = new System.Drawing.Size(90, 47);
            this.lblWidthValue.TabIndex = 3;
            this.lblWidthValue.Text = "0";
            this.lblWidthValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPositionValue
            // 
            this.lblPositionValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPositionValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositionValue.Location = new System.Drawing.Point(169, 27);
            this.lblPositionValue.Name = "lblPositionValue";
            this.lblPositionValue.Size = new System.Drawing.Size(90, 47);
            this.lblPositionValue.TabIndex = 1;
            this.lblPositionValue.Text = "0";
            this.lblPositionValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(275, 31);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(115, 39);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "Ancho";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(4, 31);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(149, 39);
            this.lblPosition.TabIndex = 0;
            this.lblPosition.Text = "Posición";
            // 
            // lblDiameter
            // 
            this.lblDiameter.AutoSize = true;
            this.lblDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiameter.Location = new System.Drawing.Point(512, 31);
            this.lblDiameter.Name = "lblDiameter";
            this.lblDiameter.Size = new System.Drawing.Size(109, 39);
            this.lblDiameter.TabIndex = 4;
            this.lblDiameter.Text = "Diam.";
            // 
            // txtManualGrossWeigth
            // 
            this.txtManualGrossWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManualGrossWeigth.Location = new System.Drawing.Point(30, 129);
            this.txtManualGrossWeigth.Name = "txtManualGrossWeigth";
            this.txtManualGrossWeigth.Size = new System.Drawing.Size(121, 53);
            this.txtManualGrossWeigth.TabIndex = 6;
            this.txtManualGrossWeigth.Text = "0.0";
            this.txtManualGrossWeigth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtManualGrossWeigth.Visible = false;
            this.txtManualGrossWeigth.TextChanged += new System.EventHandler(this.txtManualGrossWeigth_TextChanged);
            // 
            // lblWeigthValue
            // 
            this.lblWeigthValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWeigthValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeigthValue.Location = new System.Drawing.Point(30, 129);
            this.lblWeigthValue.Name = "lblWeigthValue";
            this.lblWeigthValue.Size = new System.Drawing.Size(121, 47);
            this.lblWeigthValue.TabIndex = 5;
            this.lblWeigthValue.Text = "0";
            this.lblWeigthValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblWeigthValue.TextChanged += new System.EventHandler(this.lblWeigthValue_TextChanged);
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            this.clmCodsec.Width = 110;
            // 
            // clmOrderNumber
            // 
            this.clmOrderNumber.HeaderText = "Cliente";
            this.clmOrderNumber.Name = "clmOrderNumber";
            this.clmOrderNumber.ReadOnly = true;
            this.clmOrderNumber.Width = 160;
            // 
            // clmPosition
            // 
            this.clmPosition.HeaderText = "Posición";
            this.clmPosition.Name = "clmPosition";
            this.clmPosition.ReadOnly = true;
            this.clmPosition.Width = 110;
            // 
            // clmWidth
            // 
            this.clmWidth.HeaderText = "Ancho";
            this.clmWidth.Name = "clmWidth";
            this.clmWidth.ReadOnly = true;
            // 
            // clmWeigth
            // 
            this.clmWeigth.HeaderText = "Peso";
            this.clmWeigth.Name = "clmWeigth";
            this.clmWeigth.ReadOnly = true;
            this.clmWeigth.Width = 160;
            // 
            // clmDiameter
            // 
            this.clmDiameter.HeaderText = "Diametro";
            this.clmDiameter.Name = "clmDiameter";
            this.clmDiameter.ReadOnly = true;
            this.clmDiameter.Width = 160;
            // 
            // frmCuttingOrderSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(982, 549);
            this.Controls.Add(this.grpbStop);
            this.Controls.Add(this.trvStopViews);
            this.Controls.Add(this.grpbInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCuttingOrderSummary";
            this.Text = "Resumen de orden de corte";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCuttingOrderSummary_FormClosing);
            this.Load += new System.EventHandler(this.frmCuttingOrderSummary_Load);
            this.grpbInfo.ResumeLayout(false);
            this.grpbCuttingOrderInfo.ResumeLayout(false);
            this.grpbStop.ResumeLayout(false);
            this.grpbStop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoils)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ilstStopStatus;
        private System.Windows.Forms.GroupBox grpbInfo;
        private System.Windows.Forms.Label lblCutterName;
        private System.Windows.Forms.Label lblFilmName;
        private System.Windows.Forms.TreeView trvStopViews;
        private System.Windows.Forms.GroupBox grpbCuttingOrderInfo;
        private System.Windows.Forms.GroupBox grpbStop;
        private System.Windows.Forms.ToolTip ttpCuttingOrderSummary;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDiameter;
        private System.Windows.Forms.Label lblWeigth;
        private System.Windows.Forms.Label lblWidthValue;
        private System.Windows.Forms.Label lblPositionValue;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblDiameter;
        private System.Windows.Forms.DataGridView dgvCoils;
        private System.Windows.Forms.Label lblWeigthValue;
        private System.Windows.Forms.Label lblDensity;
        private System.Windows.Forms.Label lblNetWeight;
        private System.Windows.Forms.Label lblDensityLabel;
        private System.Windows.Forms.Label lblNetWeightLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkManualWeight;
        private System.Windows.Forms.TextBox txtManualGrossWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiameter;
    }
}