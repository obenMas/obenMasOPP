namespace BPS
{
    partial class frmCoilsByCoilCellar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCoilsByCoilCellar));
            this.lblCoilCellarName = new System.Windows.Forms.Label();
            this.dgvCoils = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmToMove = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbActions = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.grpbMainCoilFiltersBar = new System.Windows.Forms.GroupBox();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.btnFilters = new System.Windows.Forms.Button();
            this.chkMoveTo = new System.Windows.Forms.CheckBox();
            this.grpbMoveTo = new System.Windows.Forms.GroupBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbCoilCellar = new System.Windows.Forms.ComboBox();
            this.lblCoilCellar = new System.Windows.Forms.Label();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.ttpCoilByCoilCellar = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoils)).BeginInit();
            this.grpbActions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpbMainCoilFiltersBar.SuspendLayout();
            this.grpbMoveTo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCoilCellarName
            // 
            this.lblCoilCellarName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCoilCellarName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoilCellarName.Location = new System.Drawing.Point(0, 0);
            this.lblCoilCellarName.Name = "lblCoilCellarName";
            this.lblCoilCellarName.Size = new System.Drawing.Size(1024, 35);
            this.lblCoilCellarName.TabIndex = 0;
            this.lblCoilCellarName.Text = "Bodega de Empaque";
            this.lblCoilCellarName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvCoils
            // 
            this.dgvCoils.AllowUserToAddRows = false;
            this.dgvCoils.AllowUserToDeleteRows = false;
            this.dgvCoils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoils.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmToMove,
            this.clmCode,
            this.clmProductName,
            this.clmDestination,
            this.clmLength,
            this.clmWidth,
            this.clmWeigth,
            this.clmQuality});
            this.dgvCoils.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCoils.Location = new System.Drawing.Point(0, 35);
            this.dgvCoils.Name = "dgvCoils";
            this.dgvCoils.ReadOnly = true;
            this.dgvCoils.Size = new System.Drawing.Size(1024, 403);
            this.dgvCoils.TabIndex = 1;
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmToMove
            // 
            this.clmToMove.HeaderText = "";
            this.clmToMove.Name = "clmToMove";
            this.clmToMove.ReadOnly = true;
            this.clmToMove.Visible = false;
            this.clmToMove.Width = 20;
            // 
            // clmCode
            // 
            this.clmCode.HeaderText = "Código";
            this.clmCode.Name = "clmCode";
            this.clmCode.ReadOnly = true;
            this.clmCode.Width = 110;
            // 
            // clmProductName
            // 
            this.clmProductName.HeaderText = "Producto";
            this.clmProductName.Name = "clmProductName";
            this.clmProductName.ReadOnly = true;
            this.clmProductName.Width = 220;
            // 
            // clmDestination
            // 
            this.clmDestination.HeaderText = "Destino";
            this.clmDestination.Name = "clmDestination";
            this.clmDestination.ReadOnly = true;
            this.clmDestination.Width = 220;
            // 
            // clmLength
            // 
            this.clmLength.HeaderText = "Metraje";
            this.clmLength.Name = "clmLength";
            this.clmLength.ReadOnly = true;
            this.clmLength.Width = 90;
            // 
            // clmWidth
            // 
            this.clmWidth.HeaderText = "Ancho";
            this.clmWidth.Name = "clmWidth";
            this.clmWidth.ReadOnly = true;
            this.clmWidth.Width = 90;
            // 
            // clmWeigth
            // 
            this.clmWeigth.HeaderText = "Peso";
            this.clmWeigth.Name = "clmWeigth";
            this.clmWeigth.ReadOnly = true;
            this.clmWeigth.Width = 90;
            // 
            // clmQuality
            // 
            this.clmQuality.HeaderText = "Calidad";
            this.clmQuality.Name = "clmQuality";
            this.clmQuality.ReadOnly = true;
            // 
            // grpbActions
            // 
            this.grpbActions.Controls.Add(this.btnExit);
            this.grpbActions.Controls.Add(this.groupBox1);
            this.grpbActions.Controls.Add(this.chkMoveTo);
            this.grpbActions.Controls.Add(this.grpbMoveTo);
            this.grpbActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbActions.Location = new System.Drawing.Point(0, 365);
            this.grpbActions.Name = "grpbActions";
            this.grpbActions.Size = new System.Drawing.Size(1024, 73);
            this.grpbActions.TabIndex = 2;
            this.grpbActions.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnExit.Location = new System.Drawing.Point(993, 43);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 3;
            this.ttpCoilByCoilCellar.SetToolTip(this.btnExit, "Salir Bodega");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCustomer);
            this.groupBox1.Controls.Add(this.lblCustomer);
            this.groupBox1.Controls.Add(this.cmbProduct);
            this.groupBox1.Controls.Add(this.lblProduct);
            this.groupBox1.Controls.Add(this.grpbMainCoilFiltersBar);
            this.groupBox1.Location = new System.Drawing.Point(0, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(336, 23);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(218, 23);
            this.cmbCustomer.TabIndex = 1;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(285, 26);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(45, 15);
            this.lblCustomer.TabIndex = 2;
            this.lblCustomer.Text = "Cliente";
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(61, 23);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(218, 23);
            this.cmbProduct.TabIndex = 0;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(5, 26);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(56, 15);
            this.lblProduct.TabIndex = 2;
            this.lblProduct.Text = "Producto";
            // 
            // grpbMainCoilFiltersBar
            // 
            this.grpbMainCoilFiltersBar.Controls.Add(this.btnClearFilters);
            this.grpbMainCoilFiltersBar.Controls.Add(this.btnFilters);
            this.grpbMainCoilFiltersBar.Location = new System.Drawing.Point(560, 9);
            this.grpbMainCoilFiltersBar.Name = "grpbMainCoilFiltersBar";
            this.grpbMainCoilFiltersBar.Size = new System.Drawing.Size(59, 44);
            this.grpbMainCoilFiltersBar.TabIndex = 2;
            this.grpbMainCoilFiltersBar.TabStop = false;
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.BackgroundImage = global::BPS.Properties.Resources.funnel_clear;
            this.btnClearFilters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClearFilters.Location = new System.Drawing.Point(4, 13);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(25, 25);
            this.btnClearFilters.TabIndex = 0;
            this.ttpCoilByCoilCellar.SetToolTip(this.btnClearFilters, "Limpiar Filtro");
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // btnFilters
            // 
            this.btnFilters.BackgroundImage = global::BPS.Properties.Resources.funnel;
            this.btnFilters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFilters.Location = new System.Drawing.Point(29, 13);
            this.btnFilters.Name = "btnFilters";
            this.btnFilters.Size = new System.Drawing.Size(25, 25);
            this.btnFilters.TabIndex = 1;
            this.ttpCoilByCoilCellar.SetToolTip(this.btnFilters, "Filtrar");
            this.btnFilters.UseVisualStyleBackColor = true;
            this.btnFilters.Click += new System.EventHandler(this.btnFilters_Click);
            // 
            // chkMoveTo
            // 
            this.chkMoveTo.AutoSize = true;
            this.chkMoveTo.Location = new System.Drawing.Point(653, 8);
            this.chkMoveTo.Name = "chkMoveTo";
            this.chkMoveTo.Size = new System.Drawing.Size(66, 17);
            this.chkMoveTo.TabIndex = 1;
            this.chkMoveTo.Text = "Mover A";
            this.chkMoveTo.UseVisualStyleBackColor = true;
            // 
            // grpbMoveTo
            // 
            this.grpbMoveTo.Controls.Add(this.btnMove);
            this.grpbMoveTo.Controls.Add(this.btnCancel);
            this.grpbMoveTo.Controls.Add(this.cmbCoilCellar);
            this.grpbMoveTo.Controls.Add(this.lblCoilCellar);
            this.grpbMoveTo.Enabled = false;
            this.grpbMoveTo.Location = new System.Drawing.Point(633, 9);
            this.grpbMoveTo.Name = "grpbMoveTo";
            this.grpbMoveTo.Size = new System.Drawing.Size(354, 59);
            this.grpbMoveTo.TabIndex = 2;
            this.grpbMoveTo.TabStop = false;
            // 
            // btnMove
            // 
            this.btnMove.BackgroundImage = global::BPS.Properties.Resources.arrow_curve;
            this.btnMove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMove.Location = new System.Drawing.Point(292, 21);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(25, 25);
            this.btnMove.TabIndex = 35;
            this.ttpCoilByCoilCellar.SetToolTip(this.btnMove, "Movilizar Bodega");
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.Location = new System.Drawing.Point(317, 21);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCancel.TabIndex = 36;
            this.ttpCoilByCoilCellar.SetToolTip(this.btnCancel, "Cancelar Bodega");
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cmbCoilCellar
            // 
            this.cmbCoilCellar.FormattingEnabled = true;
            this.cmbCoilCellar.Location = new System.Drawing.Point(68, 23);
            this.cmbCoilCellar.Name = "cmbCoilCellar";
            this.cmbCoilCellar.Size = new System.Drawing.Size(218, 23);
            this.cmbCoilCellar.TabIndex = 3;
            // 
            // lblCoilCellar
            // 
            this.lblCoilCellar.AutoSize = true;
            this.lblCoilCellar.Location = new System.Drawing.Point(12, 26);
            this.lblCoilCellar.Name = "lblCoilCellar";
            this.lblCoilCellar.Size = new System.Drawing.Size(50, 15);
            this.lblCoilCellar.TabIndex = 2;
            this.lblCoilCellar.Text = "Bodega";
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Location = new System.Drawing.Point(45, 40);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(15, 14);
            this.chkSelectAll.TabIndex = 3;
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.Visible = false;
            // 
            // frmCoilsByCoilCellar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1024, 438);
            this.Controls.Add(this.chkSelectAll);
            this.Controls.Add(this.grpbActions);
            this.Controls.Add(this.dgvCoils);
            this.Controls.Add(this.lblCoilCellarName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCoilsByCoilCellar";
            this.Text = "Bobinas por bodega";
            this.Load += new System.EventHandler(this.frmCoilsByCoilCellar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoils)).EndInit();
            this.grpbActions.ResumeLayout(false);
            this.grpbActions.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpbMainCoilFiltersBar.ResumeLayout(false);
            this.grpbMoveTo.ResumeLayout(false);
            this.grpbMoveTo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCoilCellarName;
        private System.Windows.Forms.DataGridView dgvCoils;
        private System.Windows.Forms.GroupBox grpbActions;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.GroupBox grpbMoveTo;
        private System.Windows.Forms.ComboBox cmbCoilCellar;
        private System.Windows.Forms.Label lblCoilCellar;
        private System.Windows.Forms.CheckBox chkMoveTo;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.GroupBox grpbMainCoilFiltersBar;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.Button btnFilters;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmToMove;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuality;
        private System.Windows.Forms.ToolTip ttpCoilByCoilCellar;
    }
}