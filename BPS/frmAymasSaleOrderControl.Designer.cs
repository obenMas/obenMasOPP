namespace BPS
{
    partial class frmAymasSaleOrderControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAymasSaleOrderControl));
            this.dgvAymasSaleOrderControl = new System.Windows.Forms.DataGridView();
            this.clmcodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSolicitedQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOvQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSecond = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPositiveReassignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmReassignationNegative = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPendingOV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteFilter = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cmbShow = new System.Windows.Forms.ComboBox();
            this.cmbCore = new System.Windows.Forms.ComboBox();
            this.cmbDiameter = new System.Windows.Forms.ComboBox();
            this.cmbWidth = new System.Windows.Forms.ComboBox();
            this.cmbFilm = new System.Windows.Forms.ComboBox();
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAymasSaleOrderControl)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAymasSaleOrderControl
            // 
            this.dgvAymasSaleOrderControl.AllowUserToAddRows = false;
            this.dgvAymasSaleOrderControl.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvAymasSaleOrderControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAymasSaleOrderControl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmcodsec,
            this.clmOrder,
            this.clmCliente,
            this.clmFilm,
            this.clmWidth,
            this.clmDiameter,
            this.clmCore,
            this.clmSolicitedQuantity,
            this.clmOvQuantity,
            this.clmSecond,
            this.clmPositiveReassignation,
            this.clmReassignationNegative,
            this.clmPendingOV});
            this.dgvAymasSaleOrderControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAymasSaleOrderControl.Location = new System.Drawing.Point(3, 16);
            this.dgvAymasSaleOrderControl.Name = "dgvAymasSaleOrderControl";
            this.dgvAymasSaleOrderControl.Size = new System.Drawing.Size(1135, 364);
            this.dgvAymasSaleOrderControl.TabIndex = 0;
            this.dgvAymasSaleOrderControl.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAymasSaleOrderControl_CellDoubleClick);
            // 
            // clmcodsec
            // 
            this.clmcodsec.HeaderText = "Codsec";
            this.clmcodsec.Name = "clmcodsec";
            this.clmcodsec.Visible = false;
            // 
            // clmOrder
            // 
            this.clmOrder.HeaderText = "Pedido";
            this.clmOrder.Name = "clmOrder";
            // 
            // clmCliente
            // 
            this.clmCliente.HeaderText = "Cliente";
            this.clmCliente.Name = "clmCliente";
            // 
            // clmFilm
            // 
            this.clmFilm.HeaderText = "Película";
            this.clmFilm.Name = "clmFilm";
            // 
            // clmWidth
            // 
            this.clmWidth.HeaderText = "Ancho";
            this.clmWidth.Name = "clmWidth";
            // 
            // clmDiameter
            // 
            this.clmDiameter.HeaderText = "Diametro";
            this.clmDiameter.Name = "clmDiameter";
            // 
            // clmCore
            // 
            this.clmCore.HeaderText = "Core";
            this.clmCore.Name = "clmCore";
            // 
            // clmSolicitedQuantity
            // 
            this.clmSolicitedQuantity.HeaderText = "Cant Solicitada";
            this.clmSolicitedQuantity.Name = "clmSolicitedQuantity";
            // 
            // clmOvQuantity
            // 
            this.clmOvQuantity.HeaderText = "Cantidad OV";
            this.clmOvQuantity.Name = "clmOvQuantity";
            // 
            // clmSecond
            // 
            this.clmSecond.HeaderText = "Segundas";
            this.clmSecond.Name = "clmSecond";
            // 
            // clmPositiveReassignation
            // 
            this.clmPositiveReassignation.HeaderText = "Reasignaciones +";
            this.clmPositiveReassignation.Name = "clmPositiveReassignation";
            // 
            // clmReassignationNegative
            // 
            this.clmReassignationNegative.HeaderText = "Reasignaciones -";
            this.clmReassignationNegative.Name = "clmReassignationNegative";
            // 
            // clmPendingOV
            // 
            this.clmPendingOV.HeaderText = "Pendiente OV";
            this.clmPendingOV.Name = "clmPendingOV";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteFilter);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.cmbShow);
            this.groupBox1.Controls.Add(this.cmbCore);
            this.groupBox1.Controls.Add(this.cmbDiameter);
            this.groupBox1.Controls.Add(this.cmbWidth);
            this.groupBox1.Controls.Add(this.cmbFilm);
            this.groupBox1.Controls.Add(this.cmbOrder);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1141, 64);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnDeleteFilter
            // 
            this.btnDeleteFilter.Image = global::BPS.Properties.Resources.funnel_clear;
            this.btnDeleteFilter.Location = new System.Drawing.Point(1105, 18);
            this.btnDeleteFilter.Name = "btnDeleteFilter";
            this.btnDeleteFilter.Size = new System.Drawing.Size(25, 25);
            this.btnDeleteFilter.TabIndex = 13;
            this.btnDeleteFilter.UseVisualStyleBackColor = true;
            this.btnDeleteFilter.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Image = global::BPS.Properties.Resources.funnel;
            this.btnFilter.Location = new System.Drawing.Point(1074, 18);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(25, 25);
            this.btnFilter.TabIndex = 12;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cmbShow
            // 
            this.cmbShow.FormattingEnabled = true;
            this.cmbShow.Items.AddRange(new object[] {
            "Todo"});
            this.cmbShow.Location = new System.Drawing.Point(855, 22);
            this.cmbShow.Name = "cmbShow";
            this.cmbShow.Size = new System.Drawing.Size(197, 21);
            this.cmbShow.TabIndex = 11;
            // 
            // cmbCore
            // 
            this.cmbCore.FormattingEnabled = true;
            this.cmbCore.Location = new System.Drawing.Point(713, 22);
            this.cmbCore.Name = "cmbCore";
            this.cmbCore.Size = new System.Drawing.Size(47, 21);
            this.cmbCore.TabIndex = 10;
            // 
            // cmbDiameter
            // 
            this.cmbDiameter.FormattingEnabled = true;
            this.cmbDiameter.Location = new System.Drawing.Point(579, 22);
            this.cmbDiameter.Name = "cmbDiameter";
            this.cmbDiameter.Size = new System.Drawing.Size(47, 21);
            this.cmbDiameter.TabIndex = 9;
            // 
            // cmbWidth
            // 
            this.cmbWidth.FormattingEnabled = true;
            this.cmbWidth.Location = new System.Drawing.Point(386, 22);
            this.cmbWidth.Name = "cmbWidth";
            this.cmbWidth.Size = new System.Drawing.Size(90, 21);
            this.cmbWidth.TabIndex = 8;
            // 
            // cmbFilm
            // 
            this.cmbFilm.FormattingEnabled = true;
            this.cmbFilm.Location = new System.Drawing.Point(230, 22);
            this.cmbFilm.Name = "cmbFilm";
            this.cmbFilm.Size = new System.Drawing.Size(66, 21);
            this.cmbFilm.TabIndex = 7;
            // 
            // cmbOrder
            // 
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.Location = new System.Drawing.Point(69, 22);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(60, 21);
            this.cmbOrder.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(804, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mostrar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(675, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Core:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(521, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Diametro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ancho:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Película:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedido:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAymasSaleOrderControl);
            this.groupBox2.Location = new System.Drawing.Point(4, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1141, 383);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnExport
            // 
            this.btnExport.Image = global::BPS.Properties.Resources.doc_excel_table;
            this.btnExport.Location = new System.Drawing.Point(964, 441);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(25, 25);
            this.btnExport.TabIndex = 3;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1006, 439);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "Importación Masiva";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmAymasSaleOrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 474);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAymasSaleOrderControl";
            this.Text = "Ordenes de Venta Aymas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAymasSaleOrderControl)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAymasSaleOrderControl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbShow;
        private System.Windows.Forms.ComboBox cmbCore;
        private System.Windows.Forms.ComboBox cmbDiameter;
        private System.Windows.Forms.ComboBox cmbWidth;
        private System.Windows.Forms.ComboBox cmbFilm;
        private System.Windows.Forms.ComboBox cmbOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDeleteFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCore;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSolicitedQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOvQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSecond;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPositiveReassignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmReassignationNegative;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPendingOV;
    }
}