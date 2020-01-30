namespace BPS
{
    partial class frmNewOrdersEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewOrdersEntry));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOC = new System.Windows.Forms.TextBox();
            this.cmbCustommers = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbExecutives = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpOtif = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnAddDuplicate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTDC = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvOrdersEntry = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExchangeRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubtotalPesos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOC);
            this.groupBox1.Controls.Add(this.cmbCustommers);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbExecutives);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1161, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orden de Venta";
            // 
            // txtOC
            // 
            this.txtOC.Location = new System.Drawing.Point(349, 24);
            this.txtOC.Name = "txtOC";
            this.txtOC.Size = new System.Drawing.Size(169, 20);
            this.txtOC.TabIndex = 3;
            // 
            // cmbCustommers
            // 
            this.cmbCustommers.FormattingEnabled = true;
            this.cmbCustommers.Location = new System.Drawing.Point(833, 22);
            this.cmbCustommers.Name = "cmbCustommers";
            this.cmbCustommers.Size = new System.Drawing.Size(298, 21);
            this.cmbCustommers.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(785, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cliente:";
            // 
            // cmbExecutives
            // 
            this.cmbExecutives.FormattingEnabled = true;
            this.cmbExecutives.Location = new System.Drawing.Point(620, 24);
            this.cmbExecutives.Name = "cmbExecutives";
            this.cmbExecutives.Size = new System.Drawing.Size(117, 21);
            this.cmbExecutives.TabIndex = 7;
            this.cmbExecutives.SelectedIndexChanged += new System.EventHandler(this.cmbExecutives_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(560, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ejecutiva:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Orden de Compra:";
            // 
            // dtpDate
            // 
            this.dtpDate.Enabled = false;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(116, 23);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(91, 20);
            this.dtpDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Ingreso:";
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDeliveryDate.Location = new System.Drawing.Point(655, 65);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(103, 20);
            this.dtpDeliveryDate.TabIndex = 5;
            this.dtpDeliveryDate.ValueChanged += new System.EventHandler(this.dtpDeliveryDate_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(560, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Solicitada:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpOtif);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtNotes);
            this.groupBox2.Controls.Add(this.btnAddDuplicate);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtTDC);
            this.groupBox2.Controls.Add(this.dtpDeliveryDate);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtQuantity);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtProductDescription);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtProductCode);
            this.groupBox2.Location = new System.Drawing.Point(6, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1161, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingreso";
            // 
            // dtpOtif
            // 
            this.dtpOtif.Enabled = false;
            this.dtpOtif.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOtif.Location = new System.Drawing.Point(876, 64);
            this.dtpOtif.Name = "dtpOtif";
            this.dtpOtif.Size = new System.Drawing.Size(103, 20);
            this.dtpOtif.TabIndex = 15;
            this.dtpOtif.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(803, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Fecha OTIF:";
            this.label15.Visible = false;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(116, 65);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(402, 20);
            this.txtNotes.TabIndex = 12;
            // 
            // btnAddDuplicate
            // 
            this.btnAddDuplicate.Location = new System.Drawing.Point(1016, 64);
            this.btnAddDuplicate.Name = "btnAddDuplicate";
            this.btnAddDuplicate.Size = new System.Drawing.Size(115, 23);
            this.btnAddDuplicate.TabIndex = 13;
            this.btnAddDuplicate.Text = "Agregar y Duplicar";
            this.btnAddDuplicate.UseVisualStyleBackColor = true;
            this.btnAddDuplicate.Click += new System.EventHandler(this.btnAddDuplicate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1016, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Observaciones:";
            // 
            // txtTDC
            // 
            this.txtTDC.Location = new System.Drawing.Point(931, 24);
            this.txtTDC.Name = "txtTDC";
            this.txtTDC.Size = new System.Drawing.Size(48, 20);
            this.txtTDC.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(894, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "TDC:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(773, 24);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(77, 20);
            this.txtPrice.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(731, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Precio:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(598, 24);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(93, 20);
            this.txtQuantity.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(560, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Cant:";
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Enabled = false;
            this.txtProductDescription.Location = new System.Drawing.Point(311, 24);
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(207, 20);
            this.txtProductDescription.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Descripción:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cod. Producto:";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(116, 24);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(91, 20);
            this.txtProductCode.TabIndex = 2;
            this.txtProductCode.Leave += new System.EventHandler(this.txtProductCode_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvOrdersEntry);
            this.groupBox3.Location = new System.Drawing.Point(6, 168);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1161, 271);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle";
            // 
            // dgvOrdersEntry
            // 
            this.dgvOrdersEntry.AllowUserToAddRows = false;
            this.dgvOrdersEntry.AllowUserToDeleteRows = false;
            this.dgvOrdersEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdersEntry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmProductCodsec,
            this.clmProductCode,
            this.clmProductName,
            this.clmQuantity,
            this.clmPrice,
            this.clmExchangeRate,
            this.clmSubTotal,
            this.clmSubtotalPesos,
            this.clmNotes,
            this.clmStatusName,
            this.clmStock,
            this.clmEdit,
            this.clmDelete});
            this.dgvOrdersEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrdersEntry.Location = new System.Drawing.Point(3, 16);
            this.dgvOrdersEntry.Name = "dgvOrdersEntry";
            this.dgvOrdersEntry.ReadOnly = true;
            this.dgvOrdersEntry.Size = new System.Drawing.Size(1155, 252);
            this.dgvOrdersEntry.TabIndex = 0;
            this.dgvOrdersEntry.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdersEntry_CellClick);
            this.dgvOrdersEntry.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdersEntry_CellDoubleClick);
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "Pedido";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Width = 60;
            // 
            // clmProductCodsec
            // 
            this.clmProductCodsec.HeaderText = "productCodsec";
            this.clmProductCodsec.Name = "clmProductCodsec";
            this.clmProductCodsec.ReadOnly = true;
            this.clmProductCodsec.Visible = false;
            // 
            // clmProductCode
            // 
            this.clmProductCode.HeaderText = "Código";
            this.clmProductCode.Name = "clmProductCode";
            this.clmProductCode.ReadOnly = true;
            // 
            // clmProductName
            // 
            this.clmProductName.HeaderText = "Producto";
            this.clmProductName.Name = "clmProductName";
            this.clmProductName.ReadOnly = true;
            this.clmProductName.Width = 150;
            // 
            // clmQuantity
            // 
            this.clmQuantity.HeaderText = "Cantidad";
            this.clmQuantity.Name = "clmQuantity";
            this.clmQuantity.ReadOnly = true;
            this.clmQuantity.Width = 60;
            // 
            // clmPrice
            // 
            this.clmPrice.HeaderText = "Precio";
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.ReadOnly = true;
            this.clmPrice.Width = 50;
            // 
            // clmExchangeRate
            // 
            this.clmExchangeRate.HeaderText = "Tipo de cambio";
            this.clmExchangeRate.Name = "clmExchangeRate";
            this.clmExchangeRate.ReadOnly = true;
            this.clmExchangeRate.Width = 50;
            // 
            // clmSubTotal
            // 
            this.clmSubTotal.HeaderText = "Subtotal USD";
            this.clmSubTotal.Name = "clmSubTotal";
            this.clmSubTotal.ReadOnly = true;
            // 
            // clmSubtotalPesos
            // 
            this.clmSubtotalPesos.HeaderText = "Subtotal $AR";
            this.clmSubtotalPesos.Name = "clmSubtotalPesos";
            this.clmSubtotalPesos.ReadOnly = true;
            // 
            // clmNotes
            // 
            this.clmNotes.HeaderText = "Observaciones";
            this.clmNotes.Name = "clmNotes";
            this.clmNotes.ReadOnly = true;
            this.clmNotes.Width = 150;
            // 
            // clmStatusName
            // 
            this.clmStatusName.HeaderText = "Estado";
            this.clmStatusName.Name = "clmStatusName";
            this.clmStatusName.ReadOnly = true;
            // 
            // clmStock
            // 
            this.clmStock.HeaderText = "Stock disponible";
            this.clmStock.Name = "clmStock";
            this.clmStock.ReadOnly = true;
            this.clmStock.Width = 80;
            // 
            // clmEdit
            // 
            this.clmEdit.HeaderText = "Editar";
            this.clmEdit.Name = "clmEdit";
            this.clmEdit.ReadOnly = true;
            this.clmEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmEdit.Width = 50;
            // 
            // clmDelete
            // 
            this.clmDelete.HeaderText = "Eliminar";
            this.clmDelete.Image = global::BPS.Properties.Resources.cross;
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.ReadOnly = true;
            this.clmDelete.Width = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(798, 457);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Total $AR:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(862, 454);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(115, 20);
            this.textBox8.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(983, 457);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Total USD:";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(1047, 454);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(115, 20);
            this.textBox9.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(619, 457);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Total KG:";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(677, 454);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(115, 20);
            this.textBox10.TabIndex = 4;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(9, 450);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(132, 23);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "Nuevo Pedido";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // frmNewOrdersEntry
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1174, 485);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNewOrdersEntry";
            this.Text = "Ingreso de Pedidos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmNewOrdersEntry_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersEntry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCustommers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbExecutives;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvOrdersEntry;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOC;
        private System.Windows.Forms.Button btnAddDuplicate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTDC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExchangeRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubtotalPesos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStock;
        private System.Windows.Forms.DataGridViewImageColumn clmEdit;
        private System.Windows.Forms.DataGridViewImageColumn clmDelete;
        private System.Windows.Forms.DateTimePicker dtpOtif;
        private System.Windows.Forms.Label label15;
    }
}