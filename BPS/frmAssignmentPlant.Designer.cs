namespace BPS
{
    partial class frmAssignmentPlant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAssignmentPlant));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSaleOrder = new System.Windows.Forms.ComboBox();
            this.btnDeleteFilter = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cmbPlant = new System.Windows.Forms.ComboBox();
            this.cmbAntiquityDays = new System.Windows.Forms.ComboBox();
            this.cmbCore = new System.Windows.Forms.ComboBox();
            this.cmbDiameter = new System.Windows.Forms.ComboBox();
            this.cmbWidth = new System.Windows.Forms.ComboBox();
            this.cmbFilm = new System.Windows.Forms.ComboBox();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAssignmentPlant = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.chkSelected = new System.Windows.Forms.CheckBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.cmbToAssignPlant = new System.Windows.Forms.ComboBox();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCreatedDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmClientOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCuttingPending = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCompromiseDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAntiquityDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSelcted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmPlant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignmentPlant)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbSaleOrder);
            this.groupBox1.Controls.Add(this.btnDeleteFilter);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.cmbPlant);
            this.groupBox1.Controls.Add(this.cmbAntiquityDays);
            this.groupBox1.Controls.Add(this.cmbCore);
            this.groupBox1.Controls.Add(this.cmbDiameter);
            this.groupBox1.Controls.Add(this.cmbWidth);
            this.groupBox1.Controls.Add(this.cmbFilm);
            this.groupBox1.Controls.Add(this.cmbCustomer);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1134, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Pedido";
            // 
            // cmbSaleOrder
            // 
            this.cmbSaleOrder.FormattingEnabled = true;
            this.cmbSaleOrder.Location = new System.Drawing.Point(260, 16);
            this.cmbSaleOrder.Name = "cmbSaleOrder";
            this.cmbSaleOrder.Size = new System.Drawing.Size(78, 21);
            this.cmbSaleOrder.TabIndex = 18;
            // 
            // btnDeleteFilter
            // 
            this.btnDeleteFilter.Image = global::BPS.Properties.Resources.funnel_clear;
            this.btnDeleteFilter.Location = new System.Drawing.Point(1082, 14);
            this.btnDeleteFilter.Name = "btnDeleteFilter";
            this.btnDeleteFilter.Size = new System.Drawing.Size(46, 23);
            this.btnDeleteFilter.TabIndex = 17;
            this.btnDeleteFilter.UseVisualStyleBackColor = true;
            this.btnDeleteFilter.Click += new System.EventHandler(this.btnDeleteFilter_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Image = global::BPS.Properties.Resources.funnel;
            this.btnFilter.Location = new System.Drawing.Point(1022, 14);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(46, 23);
            this.btnFilter.TabIndex = 16;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cmbPlant
            // 
            this.cmbPlant.FormattingEnabled = true;
            this.cmbPlant.Location = new System.Drawing.Point(936, 15);
            this.cmbPlant.Name = "cmbPlant";
            this.cmbPlant.Size = new System.Drawing.Size(71, 21);
            this.cmbPlant.TabIndex = 15;
            // 
            // cmbAntiquityDays
            // 
            this.cmbAntiquityDays.FormattingEnabled = true;
            this.cmbAntiquityDays.Items.AddRange(new object[] {
            "0-14",
            "15-21",
            "22-30",
            "+30"});
            this.cmbAntiquityDays.Location = new System.Drawing.Point(828, 16);
            this.cmbAntiquityDays.Name = "cmbAntiquityDays";
            this.cmbAntiquityDays.Size = new System.Drawing.Size(59, 21);
            this.cmbAntiquityDays.TabIndex = 14;
            // 
            // cmbCore
            // 
            this.cmbCore.FormattingEnabled = true;
            this.cmbCore.Location = new System.Drawing.Point(747, 15);
            this.cmbCore.Name = "cmbCore";
            this.cmbCore.Size = new System.Drawing.Size(40, 21);
            this.cmbCore.TabIndex = 13;
            // 
            // cmbDiameter
            // 
            this.cmbDiameter.FormattingEnabled = true;
            this.cmbDiameter.Location = new System.Drawing.Point(654, 15);
            this.cmbDiameter.Name = "cmbDiameter";
            this.cmbDiameter.Size = new System.Drawing.Size(53, 21);
            this.cmbDiameter.TabIndex = 12;
            // 
            // cmbWidth
            // 
            this.cmbWidth.FormattingEnabled = true;
            this.cmbWidth.Location = new System.Drawing.Point(529, 15);
            this.cmbWidth.Name = "cmbWidth";
            this.cmbWidth.Size = new System.Drawing.Size(71, 21);
            this.cmbWidth.TabIndex = 11;
            // 
            // cmbFilm
            // 
            this.cmbFilm.FormattingEnabled = true;
            this.cmbFilm.Location = new System.Drawing.Point(390, 17);
            this.cmbFilm.Name = "cmbFilm";
            this.cmbFilm.Size = new System.Drawing.Size(92, 21);
            this.cmbFilm.TabIndex = 9;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(49, 16);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(159, 21);
            this.cmbCustomer.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(893, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Planta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(793, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Antig:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(713, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Core:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(602, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Diametro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ancho:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Película:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAssignmentPlant);
            this.groupBox2.Location = new System.Drawing.Point(1, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1134, 387);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgvAssignmentPlant
            // 
            this.dgvAssignmentPlant.AllowUserToAddRows = false;
            this.dgvAssignmentPlant.AllowUserToDeleteRows = false;
            this.dgvAssignmentPlant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignmentPlant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmOrder,
            this.clmCreatedDay,
            this.clmCustomer,
            this.clmClientOC,
            this.clmFilm,
            this.clmWidth,
            this.clmDiameter,
            this.clmCore,
            this.clmPrice,
            this.clmCuttingPending,
            this.clmNotes,
            this.clmCompromiseDay,
            this.clmAntiquityDays,
            this.clmStatus,
            this.clmSelcted,
            this.clmPlant});
            this.dgvAssignmentPlant.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvAssignmentPlant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAssignmentPlant.Location = new System.Drawing.Point(3, 16);
            this.dgvAssignmentPlant.Name = "dgvAssignmentPlant";
            this.dgvAssignmentPlant.Size = new System.Drawing.Size(1128, 368);
            this.dgvAssignmentPlant.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(790, 461);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Selección:";
            // 
            // chkSelected
            // 
            this.chkSelected.AutoSize = true;
            this.chkSelected.Location = new System.Drawing.Point(863, 461);
            this.chkSelected.Name = "chkSelected";
            this.chkSelected.Size = new System.Drawing.Size(15, 14);
            this.chkSelected.TabIndex = 3;
            this.chkSelected.UseVisualStyleBackColor = true;
            this.chkSelected.CheckedChanged += new System.EventHandler(this.chkSelected_CheckedChanged);
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(1046, 456);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(75, 23);
            this.btnAssign.TabIndex = 4;
            this.btnAssign.Text = "Asignar";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // cmbToAssignPlant
            // 
            this.cmbToAssignPlant.AutoCompleteCustomSource.AddRange(new string[] {
            "Campana",
            "Pilar"});
            this.cmbToAssignPlant.FormattingEnabled = true;
            this.cmbToAssignPlant.Location = new System.Drawing.Point(891, 458);
            this.cmbToAssignPlant.Name = "cmbToAssignPlant";
            this.cmbToAssignPlant.Size = new System.Drawing.Size(121, 21);
            this.cmbToAssignPlant.TabIndex = 5;
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "Codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            this.clmCodsec.Width = 10;
            // 
            // clmOrder
            // 
            this.clmOrder.HeaderText = "Pedido";
            this.clmOrder.Name = "clmOrder";
            this.clmOrder.ReadOnly = true;
            this.clmOrder.Width = 60;
            // 
            // clmCreatedDay
            // 
            this.clmCreatedDay.HeaderText = "Fecha Ing.";
            this.clmCreatedDay.Name = "clmCreatedDay";
            this.clmCreatedDay.ReadOnly = true;
            this.clmCreatedDay.Width = 80;
            // 
            // clmCustomer
            // 
            this.clmCustomer.HeaderText = "Cliente";
            this.clmCustomer.Name = "clmCustomer";
            this.clmCustomer.ReadOnly = true;
            this.clmCustomer.Width = 170;
            // 
            // clmClientOC
            // 
            this.clmClientOC.HeaderText = "OC Cliente";
            this.clmClientOC.Name = "clmClientOC";
            this.clmClientOC.ReadOnly = true;
            // 
            // clmFilm
            // 
            this.clmFilm.HeaderText = "Pel.";
            this.clmFilm.Name = "clmFilm";
            this.clmFilm.ReadOnly = true;
            this.clmFilm.Width = 75;
            // 
            // clmWidth
            // 
            this.clmWidth.HeaderText = "Ancho";
            this.clmWidth.Name = "clmWidth";
            this.clmWidth.ReadOnly = true;
            this.clmWidth.Width = 50;
            // 
            // clmDiameter
            // 
            this.clmDiameter.HeaderText = "Diam.";
            this.clmDiameter.Name = "clmDiameter";
            this.clmDiameter.ReadOnly = true;
            this.clmDiameter.Width = 50;
            // 
            // clmCore
            // 
            this.clmCore.HeaderText = "Core";
            this.clmCore.Name = "clmCore";
            this.clmCore.ReadOnly = true;
            this.clmCore.Width = 50;
            // 
            // clmPrice
            // 
            this.clmPrice.HeaderText = "Precio";
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.Width = 50;
            // 
            // clmCuttingPending
            // 
            this.clmCuttingPending.HeaderText = "Pend.Corte [Kg]";
            this.clmCuttingPending.Name = "clmCuttingPending";
            this.clmCuttingPending.ReadOnly = true;
            this.clmCuttingPending.Width = 70;
            // 
            // clmNotes
            // 
            this.clmNotes.HeaderText = "Observaciones";
            this.clmNotes.Name = "clmNotes";
            this.clmNotes.ReadOnly = true;
            this.clmNotes.Width = 150;
            // 
            // clmCompromiseDay
            // 
            this.clmCompromiseDay.HeaderText = "Fecha Ent.";
            this.clmCompromiseDay.Name = "clmCompromiseDay";
            this.clmCompromiseDay.ReadOnly = true;
            this.clmCompromiseDay.Width = 80;
            // 
            // clmAntiquityDays
            // 
            this.clmAntiquityDays.HeaderText = "Antig.";
            this.clmAntiquityDays.Name = "clmAntiquityDays";
            this.clmAntiquityDays.ReadOnly = true;
            this.clmAntiquityDays.Width = 50;
            // 
            // clmStatus
            // 
            this.clmStatus.FillWeight = 85F;
            this.clmStatus.HeaderText = "Estado";
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.ReadOnly = true;
            this.clmStatus.Width = 80;
            // 
            // clmSelcted
            // 
            this.clmSelcted.HeaderText = "Sel.";
            this.clmSelcted.Name = "clmSelcted";
            this.clmSelcted.Width = 50;
            // 
            // clmPlant
            // 
            this.clmPlant.HeaderText = "Planta";
            this.clmPlant.Name = "clmPlant";
            this.clmPlant.ReadOnly = true;
            this.clmPlant.Width = 75;
            // 
            // frmAssignmentPlant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 493);
            this.Controls.Add(this.cmbToAssignPlant);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.chkSelected);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAssignmentPlant";
            this.Text = "Asignación de Plantas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignmentPlant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cmbPlant;
        private System.Windows.Forms.ComboBox cmbAntiquityDays;
        private System.Windows.Forms.ComboBox cmbCore;
        private System.Windows.Forms.ComboBox cmbDiameter;
        private System.Windows.Forms.ComboBox cmbWidth;
        private System.Windows.Forms.ComboBox cmbFilm;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvAssignmentPlant;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkSelected;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.ComboBox cmbToAssignPlant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSaleOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCreatedDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClientOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCore;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCuttingPending;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCompromiseDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAntiquityDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatus;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmSelcted;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPlant;
    }
}