namespace BPS.Lite
{
    partial class frmNewPalletRegistration
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpbPalletsRegister = new System.Windows.Forms.GroupBox();
            this.grpbCoils = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvCoils = new System.Windows.Forms.DataGridView();
            this.clmCoilCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilAction = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCoilCode = new System.Windows.Forms.Label();
            this.lblCoilCount = new System.Windows.Forms.Label();
            this.txtCoilCode = new System.Windows.Forms.TextBox();
            this.btnAddCoil = new System.Windows.Forms.Button();
            this.grpbPaletInfo = new System.Windows.Forms.GroupBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.btnChangeWeight = new System.Windows.Forms.Button();
            this.lblNetWeigth = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblNetWeigthLabel = new System.Windows.Forms.Label();
            this.lblDestinationLabel = new System.Windows.Forms.Label();
            this.lblCodeLabel = new System.Windows.Forms.Label();
            this.lblProductLabel = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblGrossWeigth = new System.Windows.Forms.Label();
            this.txtNewGrossWeight = new System.Windows.Forms.TextBox();
            this.txtGrossWeigth = new System.Windows.Forms.Label();
            this.lblStatusColor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpbPalletsRegister.SuspendLayout();
            this.grpbCoils.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoils)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grpbPaletInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbPalletsRegister
            // 
            this.grpbPalletsRegister.Controls.Add(this.grpbCoils);
            this.grpbPalletsRegister.Controls.Add(this.grpbPaletInfo);
            this.grpbPalletsRegister.Controls.Add(this.lblStatusColor);
            this.grpbPalletsRegister.Controls.Add(this.groupBox1);
            this.grpbPalletsRegister.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpbPalletsRegister.Location = new System.Drawing.Point(0, 0);
            this.grpbPalletsRegister.Name = "grpbPalletsRegister";
            this.grpbPalletsRegister.Size = new System.Drawing.Size(568, 505);
            this.grpbPalletsRegister.TabIndex = 2;
            this.grpbPalletsRegister.TabStop = false;
            this.grpbPalletsRegister.Text = "Pallets";
            // 
            // grpbCoils
            // 
            this.grpbCoils.Controls.Add(this.groupBox3);
            this.grpbCoils.Controls.Add(this.groupBox2);
            this.grpbCoils.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbCoils.Location = new System.Drawing.Point(8, 242);
            this.grpbCoils.Name = "grpbCoils";
            this.grpbCoils.Size = new System.Drawing.Size(557, 200);
            this.grpbCoils.TabIndex = 111;
            this.grpbCoils.TabStop = false;
            this.grpbCoils.Text = "Ingreso de bobinas";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvCoils);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(551, 115);
            this.groupBox3.TabIndex = 110;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bobinas en el pallet";
            // 
            // dgvCoils
            // 
            this.dgvCoils.AllowUserToAddRows = false;
            this.dgvCoils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoils.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCoilCodsec,
            this.clmCoilCode,
            this.clmCoilLength,
            this.clmCoilWidth,
            this.clmCoilWeigth,
            this.clmCoilAction});
            this.dgvCoils.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCoils.Location = new System.Drawing.Point(3, 16);
            this.dgvCoils.Name = "dgvCoils";
            this.dgvCoils.ReadOnly = true;
            this.dgvCoils.RowHeadersWidth = 21;
            this.dgvCoils.Size = new System.Drawing.Size(545, 96);
            this.dgvCoils.TabIndex = 0;
            this.dgvCoils.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCoils_CellClick);
            // 
            // clmCoilCodsec
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmCoilCodsec.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmCoilCodsec.HeaderText = "codsec";
            this.clmCoilCodsec.Name = "clmCoilCodsec";
            this.clmCoilCodsec.ReadOnly = true;
            this.clmCoilCodsec.Visible = false;
            // 
            // clmCoilCode
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmCoilCode.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmCoilCode.HeaderText = "Código";
            this.clmCoilCode.Name = "clmCoilCode";
            this.clmCoilCode.ReadOnly = true;
            this.clmCoilCode.Width = 150;
            // 
            // clmCoilLength
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmCoilLength.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmCoilLength.HeaderText = "Metraje";
            this.clmCoilLength.Name = "clmCoilLength";
            this.clmCoilLength.ReadOnly = true;
            this.clmCoilLength.Width = 90;
            // 
            // clmCoilWidth
            // 
            this.clmCoilWidth.HeaderText = "Ancho";
            this.clmCoilWidth.Name = "clmCoilWidth";
            this.clmCoilWidth.ReadOnly = true;
            this.clmCoilWidth.Width = 90;
            // 
            // clmCoilWeigth
            // 
            this.clmCoilWeigth.HeaderText = "Peso";
            this.clmCoilWeigth.Name = "clmCoilWeigth";
            this.clmCoilWeigth.ReadOnly = true;
            this.clmCoilWeigth.Width = 90;
            // 
            // clmCoilAction
            // 
            this.clmCoilAction.HeaderText = "";
            this.clmCoilAction.Name = "clmCoilAction";
            this.clmCoilAction.ReadOnly = true;
            this.clmCoilAction.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmCoilAction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmCoilAction.Width = 30;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCoilCode);
            this.groupBox2.Controls.Add(this.lblCoilCount);
            this.groupBox2.Controls.Add(this.txtCoilCode);
            this.groupBox2.Controls.Add(this.btnAddCoil);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(551, 66);
            this.groupBox2.TabIndex = 109;
            this.groupBox2.TabStop = false;
            // 
            // lblCoilCode
            // 
            this.lblCoilCode.AutoSize = true;
            this.lblCoilCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoilCode.Location = new System.Drawing.Point(59, 15);
            this.lblCoilCode.Name = "lblCoilCode";
            this.lblCoilCode.Size = new System.Drawing.Size(133, 20);
            this.lblCoilCode.TabIndex = 47;
            this.lblCoilCode.Text = "Código de bobina";
            // 
            // lblCoilCount
            // 
            this.lblCoilCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoilCount.Location = new System.Drawing.Point(3, 41);
            this.lblCoilCount.Name = "lblCoilCount";
            this.lblCoilCount.Size = new System.Drawing.Size(544, 18);
            this.lblCoilCount.TabIndex = 108;
            this.lblCoilCount.Text = "Bobinas : --";
            this.lblCoilCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCoilCode
            // 
            this.txtCoilCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoilCode.Location = new System.Drawing.Point(198, 12);
            this.txtCoilCode.Name = "txtCoilCode";
            this.txtCoilCode.Size = new System.Drawing.Size(262, 26);
            this.txtCoilCode.TabIndex = 48;
            this.txtCoilCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCoilCode_KeyDown);
            // 
            // btnAddCoil
            // 
            this.btnAddCoil.Image = global::BPS.Lite.Properties.Resources.add_coil;
            this.btnAddCoil.Location = new System.Drawing.Point(466, 13);
            this.btnAddCoil.Name = "btnAddCoil";
            this.btnAddCoil.Size = new System.Drawing.Size(25, 25);
            this.btnAddCoil.TabIndex = 107;
            this.btnAddCoil.UseVisualStyleBackColor = true;
            this.btnAddCoil.Click += new System.EventHandler(this.btnAddCoil_Click);
            // 
            // grpbPaletInfo
            // 
            this.grpbPaletInfo.Controls.Add(this.lblDestination);
            this.grpbPaletInfo.Controls.Add(this.btnChangeWeight);
            this.grpbPaletInfo.Controls.Add(this.lblNetWeigth);
            this.grpbPaletInfo.Controls.Add(this.lblCode);
            this.grpbPaletInfo.Controls.Add(this.lblNetWeigthLabel);
            this.grpbPaletInfo.Controls.Add(this.lblDestinationLabel);
            this.grpbPaletInfo.Controls.Add(this.lblCodeLabel);
            this.grpbPaletInfo.Controls.Add(this.lblProductLabel);
            this.grpbPaletInfo.Controls.Add(this.lblProduct);
            this.grpbPaletInfo.Controls.Add(this.lblGrossWeigth);
            this.grpbPaletInfo.Controls.Add(this.txtNewGrossWeight);
            this.grpbPaletInfo.Controls.Add(this.txtGrossWeigth);
            this.grpbPaletInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbPaletInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbPaletInfo.Location = new System.Drawing.Point(8, 16);
            this.grpbPaletInfo.Name = "grpbPaletInfo";
            this.grpbPaletInfo.Size = new System.Drawing.Size(557, 226);
            this.grpbPaletInfo.TabIndex = 110;
            this.grpbPaletInfo.TabStop = false;
            this.grpbPaletInfo.Text = "Información de pallet";
            // 
            // lblDestination
            // 
            this.lblDestination.BackColor = System.Drawing.SystemColors.Window;
            this.lblDestination.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(120, 22);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(425, 21);
            this.lblDestination.TabIndex = 45;
            this.lblDestination.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnChangeWeight
            // 
            this.btnChangeWeight.Image = global::BPS.Lite.Properties.Resources.arrow_refresh;
            this.btnChangeWeight.Location = new System.Drawing.Point(489, 181);
            this.btnChangeWeight.Name = "btnChangeWeight";
            this.btnChangeWeight.Size = new System.Drawing.Size(25, 25);
            this.btnChangeWeight.TabIndex = 107;
            this.btnChangeWeight.UseVisualStyleBackColor = true;
            this.btnChangeWeight.Click += new System.EventHandler(this.btnChangeWeight_Click);
            // 
            // lblNetWeigth
            // 
            this.lblNetWeigth.BackColor = System.Drawing.SystemColors.Window;
            this.lblNetWeigth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetWeigth.Location = new System.Drawing.Point(42, 146);
            this.lblNetWeigth.Name = "lblNetWeigth";
            this.lblNetWeigth.Size = new System.Drawing.Size(191, 63);
            this.lblNetWeigth.TabIndex = 107;
            this.lblNetWeigth.Tag = "clearOnReload";
            this.lblNetWeigth.Text = "0.0";
            this.lblNetWeigth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCode
            // 
            this.lblCode.BackColor = System.Drawing.SystemColors.Window;
            this.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(120, 54);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(425, 21);
            this.lblCode.TabIndex = 45;
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNetWeigthLabel
            // 
            this.lblNetWeigthLabel.AutoSize = true;
            this.lblNetWeigthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetWeigthLabel.Location = new System.Drawing.Point(96, 123);
            this.lblNetWeigthLabel.Name = "lblNetWeigthLabel";
            this.lblNetWeigthLabel.Size = new System.Drawing.Size(83, 20);
            this.lblNetWeigthLabel.TabIndex = 105;
            this.lblNetWeigthLabel.Text = "Peso Neto";
            // 
            // lblDestinationLabel
            // 
            this.lblDestinationLabel.AutoSize = true;
            this.lblDestinationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationLabel.Location = new System.Drawing.Point(11, 25);
            this.lblDestinationLabel.Name = "lblDestinationLabel";
            this.lblDestinationLabel.Size = new System.Drawing.Size(64, 20);
            this.lblDestinationLabel.TabIndex = 46;
            this.lblDestinationLabel.Text = "Destino";
            // 
            // lblCodeLabel
            // 
            this.lblCodeLabel.AutoSize = true;
            this.lblCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeLabel.Location = new System.Drawing.Point(16, 55);
            this.lblCodeLabel.Name = "lblCodeLabel";
            this.lblCodeLabel.Size = new System.Drawing.Size(59, 20);
            this.lblCodeLabel.TabIndex = 46;
            this.lblCodeLabel.Text = "Código";
            // 
            // lblProductLabel
            // 
            this.lblProductLabel.AutoSize = true;
            this.lblProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductLabel.Location = new System.Drawing.Point(11, 86);
            this.lblProductLabel.Name = "lblProductLabel";
            this.lblProductLabel.Size = new System.Drawing.Size(73, 20);
            this.lblProductLabel.TabIndex = 48;
            this.lblProductLabel.Text = "Producto";
            // 
            // lblProduct
            // 
            this.lblProduct.BackColor = System.Drawing.SystemColors.Window;
            this.lblProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(120, 85);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(425, 21);
            this.lblProduct.TabIndex = 47;
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrossWeigth
            // 
            this.lblGrossWeigth.AutoSize = true;
            this.lblGrossWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossWeigth.Location = new System.Drawing.Point(343, 123);
            this.lblGrossWeigth.Name = "lblGrossWeigth";
            this.lblGrossWeigth.Size = new System.Drawing.Size(88, 20);
            this.lblGrossWeigth.TabIndex = 103;
            this.lblGrossWeigth.Text = "Peso Bruto";
            // 
            // txtNewGrossWeight
            // 
            this.txtNewGrossWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewGrossWeight.Location = new System.Drawing.Point(292, 146);
            this.txtNewGrossWeight.Name = "txtNewGrossWeight";
            this.txtNewGrossWeight.Size = new System.Drawing.Size(191, 67);
            this.txtNewGrossWeight.TabIndex = 108;
            this.txtNewGrossWeight.Text = "0.0";
            this.txtNewGrossWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNewGrossWeight.Visible = false;
            // 
            // txtGrossWeigth
            // 
            this.txtGrossWeigth.BackColor = System.Drawing.SystemColors.Window;
            this.txtGrossWeigth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtGrossWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrossWeigth.Location = new System.Drawing.Point(292, 148);
            this.txtGrossWeigth.Name = "txtGrossWeigth";
            this.txtGrossWeigth.Size = new System.Drawing.Size(191, 63);
            this.txtGrossWeigth.TabIndex = 107;
            this.txtGrossWeigth.Tag = "clearOnReload";
            this.txtGrossWeigth.Text = "0.0";
            this.txtGrossWeigth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatusColor
            // 
            this.lblStatusColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblStatusColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblStatusColor.Location = new System.Drawing.Point(3, 16);
            this.lblStatusColor.Name = "lblStatusColor";
            this.lblStatusColor.Size = new System.Drawing.Size(5, 426);
            this.lblStatusColor.TabIndex = 109;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 442);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 60);
            this.groupBox1.TabIndex = 112;
            this.groupBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::BPS.Lite.Properties.Resources._lock;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(245, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(67, 45);
            this.btnClose.TabIndex = 108;
            this.btnClose.Text = "Cerrar";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // frmNewPalletRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(568, 505);
            this.Controls.Add(this.grpbPalletsRegister);
            this.Name = "frmNewPalletRegistration";
            this.ShowIcon = false;
            this.Text = "Nuevo Pallet";
            this.grpbPalletsRegister.ResumeLayout(false);
            this.grpbCoils.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoils)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpbPaletInfo.ResumeLayout(false);
            this.grpbPaletInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbPalletsRegister;
        private System.Windows.Forms.GroupBox grpbCoils;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvCoils;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilWeigth;
        private System.Windows.Forms.DataGridViewImageColumn clmCoilAction;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCoilCode;
        private System.Windows.Forms.Label lblCoilCount;
        private System.Windows.Forms.TextBox txtCoilCode;
        private System.Windows.Forms.Button btnAddCoil;
        private System.Windows.Forms.GroupBox grpbPaletInfo;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Button btnChangeWeight;
        private System.Windows.Forms.Label lblNetWeigth;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblNetWeigthLabel;
        private System.Windows.Forms.Label lblDestinationLabel;
        private System.Windows.Forms.Label lblCodeLabel;
        private System.Windows.Forms.Label lblProductLabel;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblGrossWeigth;
        private System.Windows.Forms.TextBox txtNewGrossWeight;
        private System.Windows.Forms.Label txtGrossWeigth;
        private System.Windows.Forms.Label lblStatusColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
    }
}