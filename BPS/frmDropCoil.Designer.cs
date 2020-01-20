namespace BPS
{
    partial class frmDropCoil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDropCoil));
            this.txtCoilCode = new System.Windows.Forms.TextBox();
            this.lblCoilCode = new System.Windows.Forms.Label();
            this.grpbCoilInfo = new System.Windows.Forms.GroupBox();
            this.lblSalesOrder = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblCustomerLabel = new System.Windows.Forms.Label();
            this.lblSalesOrderNumber = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblWidthLabel = new System.Windows.Forms.Label();
            this.lblGrossWeigth = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblNetWeigth = new System.Windows.Forms.Label();
            this.lblLengthLabel = new System.Windows.Forms.Label();
            this.lblNetWeigthLabel = new System.Windows.Forms.Label();
            this.lblGrossWeigthLabel = new System.Windows.Forms.Label();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.grpbCoilList = new System.Windows.Forms.GroupBox();
            this.dgvCoils = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbEmpty = new System.Windows.Forms.GroupBox();
            this.grpbMainCoilButtons = new System.Windows.Forms.GroupBox();
            this.btnCancelDrop = new System.Windows.Forms.Button();
            this.btnDropCoil = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.ttpDropCoil = new System.Windows.Forms.ToolTip(this.components);
            this.grpbCoilInfo.SuspendLayout();
            this.grpbCoilList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoils)).BeginInit();
            this.grpbMainCoilButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCoilCode
            // 
            this.txtCoilCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoilCode.Location = new System.Drawing.Point(151, 24);
            this.txtCoilCode.Name = "txtCoilCode";
            this.txtCoilCode.Size = new System.Drawing.Size(240, 26);
            this.txtCoilCode.TabIndex = 0;
            this.txtCoilCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCoilCode_KeyDown);
            // 
            // lblCoilCode
            // 
            this.lblCoilCode.AutoSize = true;
            this.lblCoilCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoilCode.Location = new System.Drawing.Point(12, 27);
            this.lblCoilCode.Name = "lblCoilCode";
            this.lblCoilCode.Size = new System.Drawing.Size(133, 20);
            this.lblCoilCode.TabIndex = 110;
            this.lblCoilCode.Text = "Código de bobina";
            // 
            // grpbCoilInfo
            // 
            this.grpbCoilInfo.Controls.Add(this.lblSalesOrder);
            this.grpbCoilInfo.Controls.Add(this.lblCustomer);
            this.grpbCoilInfo.Controls.Add(this.lblCustomerLabel);
            this.grpbCoilInfo.Controls.Add(this.lblSalesOrderNumber);
            this.grpbCoilInfo.Controls.Add(this.lblWidth);
            this.grpbCoilInfo.Controls.Add(this.lblWidthLabel);
            this.grpbCoilInfo.Controls.Add(this.lblGrossWeigth);
            this.grpbCoilInfo.Controls.Add(this.lblLength);
            this.grpbCoilInfo.Controls.Add(this.lblNetWeigth);
            this.grpbCoilInfo.Controls.Add(this.lblLengthLabel);
            this.grpbCoilInfo.Controls.Add(this.lblNetWeigthLabel);
            this.grpbCoilInfo.Controls.Add(this.lblGrossWeigthLabel);
            this.grpbCoilInfo.Controls.Add(this.lblCoilCode);
            this.grpbCoilInfo.Controls.Add(this.btnAddToList);
            this.grpbCoilInfo.Controls.Add(this.txtCoilCode);
            this.grpbCoilInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbCoilInfo.Location = new System.Drawing.Point(0, 0);
            this.grpbCoilInfo.Name = "grpbCoilInfo";
            this.grpbCoilInfo.Size = new System.Drawing.Size(997, 106);
            this.grpbCoilInfo.TabIndex = 0;
            this.grpbCoilInfo.TabStop = false;
            this.grpbCoilInfo.Text = "Información de bobina";
            // 
            // lblSalesOrder
            // 
            this.lblSalesOrder.AutoSize = true;
            this.lblSalesOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesOrder.Location = new System.Drawing.Point(785, 27);
            this.lblSalesOrder.Name = "lblSalesOrder";
            this.lblSalesOrder.Size = new System.Drawing.Size(108, 20);
            this.lblSalesOrder.TabIndex = 125;
            this.lblSalesOrder.Text = "Ord. de Venta";
            // 
            // lblCustomer
            // 
            this.lblCustomer.BackColor = System.Drawing.SystemColors.Window;
            this.lblCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(461, 27);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(318, 21);
            this.lblCustomer.TabIndex = 127;
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomerLabel
            // 
            this.lblCustomerLabel.AutoSize = true;
            this.lblCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerLabel.Location = new System.Drawing.Point(397, 27);
            this.lblCustomerLabel.Name = "lblCustomerLabel";
            this.lblCustomerLabel.Size = new System.Drawing.Size(58, 20);
            this.lblCustomerLabel.TabIndex = 126;
            this.lblCustomerLabel.Text = "Cliente";
            // 
            // lblSalesOrderNumber
            // 
            this.lblSalesOrderNumber.BackColor = System.Drawing.SystemColors.Window;
            this.lblSalesOrderNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalesOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesOrderNumber.Location = new System.Drawing.Point(899, 27);
            this.lblSalesOrderNumber.Name = "lblSalesOrderNumber";
            this.lblSalesOrderNumber.Size = new System.Drawing.Size(86, 21);
            this.lblSalesOrderNumber.TabIndex = 128;
            this.lblSalesOrderNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWidth
            // 
            this.lblWidth.BackColor = System.Drawing.SystemColors.Window;
            this.lblWidth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(804, 64);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(133, 26);
            this.lblWidth.TabIndex = 124;
            this.lblWidth.Tag = "clearOnReload";
            this.lblWidth.Text = "0";
            this.lblWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWidthLabel
            // 
            this.lblWidthLabel.AutoSize = true;
            this.lblWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidthLabel.Location = new System.Drawing.Point(734, 67);
            this.lblWidthLabel.Name = "lblWidthLabel";
            this.lblWidthLabel.Size = new System.Drawing.Size(55, 20);
            this.lblWidthLabel.TabIndex = 123;
            this.lblWidthLabel.Text = "Ancho";
            // 
            // lblGrossWeigth
            // 
            this.lblGrossWeigth.BackColor = System.Drawing.SystemColors.Window;
            this.lblGrossWeigth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGrossWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossWeigth.Location = new System.Drawing.Point(361, 64);
            this.lblGrossWeigth.Name = "lblGrossWeigth";
            this.lblGrossWeigth.Size = new System.Drawing.Size(133, 26);
            this.lblGrossWeigth.TabIndex = 118;
            this.lblGrossWeigth.Tag = "clearOnReload";
            this.lblGrossWeigth.Text = "0";
            this.lblGrossWeigth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLength
            // 
            this.lblLength.BackColor = System.Drawing.SystemColors.Window;
            this.lblLength.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(586, 64);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(133, 26);
            this.lblLength.TabIndex = 116;
            this.lblLength.Tag = "clearOnReload";
            this.lblLength.Text = "0";
            this.lblLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNetWeigth
            // 
            this.lblNetWeigth.BackColor = System.Drawing.SystemColors.Window;
            this.lblNetWeigth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetWeigth.Location = new System.Drawing.Point(110, 64);
            this.lblNetWeigth.Name = "lblNetWeigth";
            this.lblNetWeigth.Size = new System.Drawing.Size(133, 26);
            this.lblNetWeigth.TabIndex = 117;
            this.lblNetWeigth.Tag = "clearOnReload";
            this.lblNetWeigth.Text = "0";
            this.lblNetWeigth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLengthLabel
            // 
            this.lblLengthLabel.AutoSize = true;
            this.lblLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLengthLabel.Location = new System.Drawing.Point(509, 67);
            this.lblLengthLabel.Name = "lblLengthLabel";
            this.lblLengthLabel.Size = new System.Drawing.Size(62, 20);
            this.lblLengthLabel.TabIndex = 115;
            this.lblLengthLabel.Text = "Metraje";
            // 
            // lblNetWeigthLabel
            // 
            this.lblNetWeigthLabel.AutoSize = true;
            this.lblNetWeigthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetWeigthLabel.Location = new System.Drawing.Point(12, 67);
            this.lblNetWeigthLabel.Name = "lblNetWeigthLabel";
            this.lblNetWeigthLabel.Size = new System.Drawing.Size(83, 20);
            this.lblNetWeigthLabel.TabIndex = 114;
            this.lblNetWeigthLabel.Text = "Peso Neto";
            // 
            // lblGrossWeigthLabel
            // 
            this.lblGrossWeigthLabel.AutoSize = true;
            this.lblGrossWeigthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossWeigthLabel.Location = new System.Drawing.Point(258, 67);
            this.lblGrossWeigthLabel.Name = "lblGrossWeigthLabel";
            this.lblGrossWeigthLabel.Size = new System.Drawing.Size(88, 20);
            this.lblGrossWeigthLabel.TabIndex = 113;
            this.lblGrossWeigthLabel.Text = "Peso Bruto";
            // 
            // btnAddToList
            // 
            this.btnAddToList.Image = global::BPS.Properties.Resources.add1;
            this.btnAddToList.Location = new System.Drawing.Point(960, 65);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(25, 25);
            this.btnAddToList.TabIndex = 2;
            this.ttpDropCoil.SetToolTip(this.btnAddToList, "Agregar Rollo Madre");
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // grpbCoilList
            // 
            this.grpbCoilList.Controls.Add(this.dgvCoils);
            this.grpbCoilList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbCoilList.Location = new System.Drawing.Point(0, 106);
            this.grpbCoilList.Name = "grpbCoilList";
            this.grpbCoilList.Size = new System.Drawing.Size(997, 300);
            this.grpbCoilList.TabIndex = 1;
            this.grpbCoilList.TabStop = false;
            this.grpbCoilList.Text = "Listado de bobinas";
            // 
            // dgvCoils
            // 
            this.dgvCoils.AllowUserToAddRows = false;
            this.dgvCoils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoils.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmCode,
            this.clmProductName,
            this.clmDestination,
            this.clmLength,
            this.clmWidth,
            this.clmWeigth,
            this.clmQuality});
            this.dgvCoils.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCoils.Location = new System.Drawing.Point(3, 17);
            this.dgvCoils.Name = "dgvCoils";
            this.dgvCoils.ReadOnly = true;
            this.dgvCoils.Size = new System.Drawing.Size(991, 280);
            this.dgvCoils.TabIndex = 0;
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
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
            // grpbEmpty
            // 
            this.grpbEmpty.Location = new System.Drawing.Point(0, 400);
            this.grpbEmpty.Name = "grpbEmpty";
            this.grpbEmpty.Size = new System.Drawing.Size(914, 44);
            this.grpbEmpty.TabIndex = 2;
            this.grpbEmpty.TabStop = false;
            // 
            // grpbMainCoilButtons
            // 
            this.grpbMainCoilButtons.Controls.Add(this.btnCancelDrop);
            this.grpbMainCoilButtons.Controls.Add(this.btnDropCoil);
            this.grpbMainCoilButtons.Controls.Add(this.btnExit);
            this.grpbMainCoilButtons.Location = new System.Drawing.Point(916, 400);
            this.grpbMainCoilButtons.Name = "grpbMainCoilButtons";
            this.grpbMainCoilButtons.Size = new System.Drawing.Size(81, 44);
            this.grpbMainCoilButtons.TabIndex = 3;
            this.grpbMainCoilButtons.TabStop = false;
            // 
            // btnCancelDrop
            // 
            this.btnCancelDrop.Image = global::BPS.Properties.Resources.cancel;
            this.btnCancelDrop.Location = new System.Drawing.Point(3, 13);
            this.btnCancelDrop.Name = "btnCancelDrop";
            this.btnCancelDrop.Size = new System.Drawing.Size(25, 25);
            this.btnCancelDrop.TabIndex = 0;
            this.ttpDropCoil.SetToolTip(this.btnCancelDrop, "Cancelar Rollos Madre");
            this.btnCancelDrop.UseVisualStyleBackColor = true;
            this.btnCancelDrop.Click += new System.EventHandler(this.btnCancelDrop_Click);
            // 
            // btnDropCoil
            // 
            this.btnDropCoil.Image = global::BPS.Properties.Resources.coilMill1;
            this.btnDropCoil.Location = new System.Drawing.Point(28, 13);
            this.btnDropCoil.Name = "btnDropCoil";
            this.btnDropCoil.Size = new System.Drawing.Size(25, 25);
            this.btnDropCoil.TabIndex = 1;
            this.ttpDropCoil.SetToolTip(this.btnDropCoil, "Baja Rollo Madre");
            this.btnDropCoil.UseVisualStyleBackColor = true;
            this.btnDropCoil.Click += new System.EventHandler(this.btnDropCoil_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnExit.Location = new System.Drawing.Point(53, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 2;
            this.ttpDropCoil.SetToolTip(this.btnExit, "Salir Rollo Madre");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmDropCoil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(997, 445);
            this.Controls.Add(this.grpbCoilList);
            this.Controls.Add(this.grpbCoilInfo);
            this.Controls.Add(this.grpbEmpty);
            this.Controls.Add(this.grpbMainCoilButtons);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDropCoil";
            this.Text = "Rollos Madre";
            this.grpbCoilInfo.ResumeLayout(false);
            this.grpbCoilInfo.PerformLayout();
            this.grpbCoilList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoils)).EndInit();
            this.grpbMainCoilButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCoilCode;
        private System.Windows.Forms.Label lblCoilCode;
        private System.Windows.Forms.GroupBox grpbCoilInfo;
        private System.Windows.Forms.GroupBox grpbCoilList;
        private System.Windows.Forms.DataGridView dgvCoils;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblWidthLabel;
        private System.Windows.Forms.Label lblGrossWeigth;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblNetWeigth;
        private System.Windows.Forms.Label lblLengthLabel;
        private System.Windows.Forms.Label lblNetWeigthLabel;
        private System.Windows.Forms.Label lblGrossWeigthLabel;
        private System.Windows.Forms.Label lblSalesOrder;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblCustomerLabel;
        private System.Windows.Forms.Label lblSalesOrderNumber;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.GroupBox grpbEmpty;
        private System.Windows.Forms.GroupBox grpbMainCoilButtons;
        private System.Windows.Forms.Button btnCancelDrop;
        private System.Windows.Forms.Button btnDropCoil;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuality;
        private System.Windows.Forms.ToolTip ttpDropCoil;
    }
}