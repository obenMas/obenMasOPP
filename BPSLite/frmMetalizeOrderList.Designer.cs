namespace BPS.Lite
{
    partial class frmMetalizeOrderList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMetalizeOrderList));
            this.grpbOrder = new System.Windows.Forms.GroupBox();
            this.dgvMetalizeOrder = new System.Windows.Forms.DataGridView();
            this.grpbMetalizeDetail = new System.Windows.Forms.GroupBox();
            this.lblProductTo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblProductFrom = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblLotNumber = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExtruder = new System.Windows.Forms.Button();
            this.clmmetalizedmystated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmetalizedfkfilmproductionplanmetal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmetalizecodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmetalizedtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmetalizefkstatus = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmmetalizeproductbase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmetalizeproductmetalize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmetalizewidthbase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmetalizewidthmetalize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmetalizeorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmetalizecoilnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmetalizelot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmetalizecustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmetalizenotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmetalizedviewer = new System.Windows.Forms.DataGridViewImageColumn();
            this.grpbOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetalizeOrder)).BeginInit();
            this.grpbMetalizeDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbOrder
            // 
            this.grpbOrder.Controls.Add(this.dgvMetalizeOrder);
            this.grpbOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbOrder.Location = new System.Drawing.Point(0, 0);
            this.grpbOrder.Name = "grpbOrder";
            this.grpbOrder.Size = new System.Drawing.Size(1026, 382);
            this.grpbOrder.TabIndex = 0;
            this.grpbOrder.TabStop = false;
            this.grpbOrder.Text = "Ordenes";
            // 
            // dgvMetalizeOrder
            // 
            this.dgvMetalizeOrder.AllowUserToAddRows = false;
            this.dgvMetalizeOrder.AllowUserToDeleteRows = false;
            this.dgvMetalizeOrder.AllowUserToOrderColumns = true;
            this.dgvMetalizeOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMetalizeOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmmetalizedmystated,
            this.clmmetalizedfkfilmproductionplanmetal,
            this.clmmetalizecodsec,
            this.clmmetalizedtype,
            this.clmmetalizefkstatus,
            this.clmmetalizeproductbase,
            this.clmmetalizeproductmetalize,
            this.clmmetalizewidthbase,
            this.clmmetalizewidthmetalize,
            this.clmmetalizeorder,
            this.clmmetalizecoilnumber,
            this.clmmetalizelot,
            this.clmmetalizecustomer,
            this.clmmetalizenotes,
            this.clmmetalizedviewer});
            this.dgvMetalizeOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMetalizeOrder.Location = new System.Drawing.Point(3, 14);
            this.dgvMetalizeOrder.Name = "dgvMetalizeOrder";
            this.dgvMetalizeOrder.ReadOnly = true;
            this.dgvMetalizeOrder.RowHeadersWidth = 21;
            this.dgvMetalizeOrder.Size = new System.Drawing.Size(1020, 365);
            this.dgvMetalizeOrder.TabIndex = 0;
            this.dgvMetalizeOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMetalizeOrder_CellContentClick);
            this.dgvMetalizeOrder.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMetalizeOrder_CellMouseDoubleClick);
            // 
            // grpbMetalizeDetail
            // 
            this.grpbMetalizeDetail.Controls.Add(this.lblProductTo);
            this.grpbMetalizeDetail.Controls.Add(this.label9);
            this.grpbMetalizeDetail.Controls.Add(this.lblProductFrom);
            this.grpbMetalizeDetail.Controls.Add(this.label6);
            this.grpbMetalizeDetail.Controls.Add(this.lblNotes);
            this.grpbMetalizeDetail.Controls.Add(this.lblStatus);
            this.grpbMetalizeDetail.Controls.Add(this.lblLotNumber);
            this.grpbMetalizeDetail.Controls.Add(this.lblOrder);
            this.grpbMetalizeDetail.Controls.Add(this.lblCustomer);
            this.grpbMetalizeDetail.Controls.Add(this.label5);
            this.grpbMetalizeDetail.Controls.Add(this.label4);
            this.grpbMetalizeDetail.Controls.Add(this.label3);
            this.grpbMetalizeDetail.Controls.Add(this.label2);
            this.grpbMetalizeDetail.Controls.Add(this.label1);
            this.grpbMetalizeDetail.Controls.Add(this.btnExtruder);
            this.grpbMetalizeDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbMetalizeDetail.Location = new System.Drawing.Point(0, 382);
            this.grpbMetalizeDetail.Name = "grpbMetalizeDetail";
            this.grpbMetalizeDetail.Size = new System.Drawing.Size(1026, 133);
            this.grpbMetalizeDetail.TabIndex = 1;
            this.grpbMetalizeDetail.TabStop = false;
            this.grpbMetalizeDetail.Text = "Detalles";
            // 
            // lblProductTo
            // 
            this.lblProductTo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProductTo.Location = new System.Drawing.Point(644, 50);
            this.lblProductTo.Name = "lblProductTo";
            this.lblProductTo.Size = new System.Drawing.Size(247, 24);
            this.lblProductTo.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(518, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Producto Metalizado";
            // 
            // lblProductFrom
            // 
            this.lblProductFrom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProductFrom.Location = new System.Drawing.Point(106, 49);
            this.lblProductFrom.Name = "lblProductFrom";
            this.lblProductFrom.Size = new System.Drawing.Size(358, 24);
            this.lblProductFrom.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Producto Base";
            // 
            // lblNotes
            // 
            this.lblNotes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNotes.Location = new System.Drawing.Point(106, 83);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(785, 34);
            this.lblNotes.TabIndex = 10;
            // 
            // lblStatus
            // 
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatus.Location = new System.Drawing.Point(819, 17);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(72, 24);
            this.lblStatus.TabIndex = 9;
            // 
            // lblLotNumber
            // 
            this.lblLotNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLotNumber.Location = new System.Drawing.Point(678, 17);
            this.lblLotNumber.Name = "lblLotNumber";
            this.lblLotNumber.Size = new System.Drawing.Size(85, 24);
            this.lblLotNumber.TabIndex = 8;
            // 
            // lblOrder
            // 
            this.lblOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOrder.Location = new System.Drawing.Point(590, 17);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(46, 24);
            this.lblOrder.TabIndex = 7;
            // 
            // lblCustomer
            // 
            this.lblCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomer.Location = new System.Drawing.Point(106, 17);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(431, 24);
            this.lblCustomer.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Observaciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(768, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(641, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lote";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Orden";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente";
            // 
            // btnExtruder
            // 
            this.btnExtruder.Image = global::BPS.Lite.Properties.Resources.gear_32;
            this.btnExtruder.Location = new System.Drawing.Point(923, 26);
            this.btnExtruder.Name = "btnExtruder";
            this.btnExtruder.Size = new System.Drawing.Size(97, 77);
            this.btnExtruder.TabIndex = 0;
            this.btnExtruder.Text = "Ejecutar";
            this.btnExtruder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExtruder.UseVisualStyleBackColor = true;
            this.btnExtruder.Click += new System.EventHandler(this.btnExtruder_Click);
            // 
            // clmmetalizedmystated
            // 
            this.clmmetalizedmystated.HeaderText = "mystated";
            this.clmmetalizedmystated.Name = "clmmetalizedmystated";
            this.clmmetalizedmystated.ReadOnly = true;
            this.clmmetalizedmystated.Visible = false;
            // 
            // clmmetalizedfkfilmproductionplanmetal
            // 
            this.clmmetalizedfkfilmproductionplanmetal.HeaderText = "fkFilmProductionOrder";
            this.clmmetalizedfkfilmproductionplanmetal.Name = "clmmetalizedfkfilmproductionplanmetal";
            this.clmmetalizedfkfilmproductionplanmetal.ReadOnly = true;
            this.clmmetalizedfkfilmproductionplanmetal.Visible = false;
            // 
            // clmmetalizecodsec
            // 
            this.clmmetalizecodsec.HeaderText = "codsec";
            this.clmmetalizecodsec.Name = "clmmetalizecodsec";
            this.clmmetalizecodsec.ReadOnly = true;
            this.clmmetalizecodsec.Visible = false;
            // 
            // clmmetalizedtype
            // 
            this.clmmetalizedtype.HeaderText = "type";
            this.clmmetalizedtype.Name = "clmmetalizedtype";
            this.clmmetalizedtype.ReadOnly = true;
            this.clmmetalizedtype.Visible = false;
            // 
            // clmmetalizefkstatus
            // 
            this.clmmetalizefkstatus.HeaderText = "";
            this.clmmetalizefkstatus.Name = "clmmetalizefkstatus";
            this.clmmetalizefkstatus.ReadOnly = true;
            this.clmmetalizefkstatus.Width = 30;
            // 
            // clmmetalizeproductbase
            // 
            this.clmmetalizeproductbase.FillWeight = 80F;
            this.clmmetalizeproductbase.HeaderText = "Base";
            this.clmmetalizeproductbase.Name = "clmmetalizeproductbase";
            this.clmmetalizeproductbase.ReadOnly = true;
            this.clmmetalizeproductbase.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmmetalizeproductbase.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmmetalizeproductbase.Width = 80;
            // 
            // clmmetalizeproductmetalize
            // 
            this.clmmetalizeproductmetalize.FillWeight = 80F;
            this.clmmetalizeproductmetalize.HeaderText = "Metalizado";
            this.clmmetalizeproductmetalize.Name = "clmmetalizeproductmetalize";
            this.clmmetalizeproductmetalize.ReadOnly = true;
            this.clmmetalizeproductmetalize.Width = 80;
            // 
            // clmmetalizewidthbase
            // 
            this.clmmetalizewidthbase.HeaderText = "Ancho B";
            this.clmmetalizewidthbase.Name = "clmmetalizewidthbase";
            this.clmmetalizewidthbase.ReadOnly = true;
            this.clmmetalizewidthbase.Width = 88;
            // 
            // clmmetalizewidthmetalize
            // 
            this.clmmetalizewidthmetalize.HeaderText = "Ancho M";
            this.clmmetalizewidthmetalize.Name = "clmmetalizewidthmetalize";
            this.clmmetalizewidthmetalize.ReadOnly = true;
            this.clmmetalizewidthmetalize.Width = 88;
            // 
            // clmmetalizeorder
            // 
            this.clmmetalizeorder.HeaderText = "Orden";
            this.clmmetalizeorder.Name = "clmmetalizeorder";
            this.clmmetalizeorder.ReadOnly = true;
            this.clmmetalizeorder.Width = 50;
            // 
            // clmmetalizecoilnumber
            // 
            this.clmmetalizecoilnumber.FillWeight = 80F;
            this.clmmetalizecoilnumber.HeaderText = "# Bobinas";
            this.clmmetalizecoilnumber.Name = "clmmetalizecoilnumber";
            this.clmmetalizecoilnumber.ReadOnly = true;
            this.clmmetalizecoilnumber.Width = 68;
            // 
            // clmmetalizelot
            // 
            this.clmmetalizelot.HeaderText = "Lote";
            this.clmmetalizelot.Name = "clmmetalizelot";
            this.clmmetalizelot.ReadOnly = true;
            this.clmmetalizelot.Width = 80;
            // 
            // clmmetalizecustomer
            // 
            this.clmmetalizecustomer.HeaderText = "Cliente";
            this.clmmetalizecustomer.Name = "clmmetalizecustomer";
            this.clmmetalizecustomer.ReadOnly = true;
            this.clmmetalizecustomer.Width = 170;
            // 
            // clmmetalizenotes
            // 
            this.clmmetalizenotes.HeaderText = "Observaciones";
            this.clmmetalizenotes.Name = "clmmetalizenotes";
            this.clmmetalizenotes.ReadOnly = true;
            this.clmmetalizenotes.Width = 170;
            // 
            // clmmetalizedviewer
            // 
            this.clmmetalizedviewer.HeaderText = "";
            this.clmmetalizedviewer.Name = "clmmetalizedviewer";
            this.clmmetalizedviewer.ReadOnly = true;
            this.clmmetalizedviewer.Width = 30;
            // 
            // frmMetalizeOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1026, 515);
            this.Controls.Add(this.grpbOrder);
            this.Controls.Add(this.grpbMetalizeDetail);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMetalizeOrderList";
            this.Text = "Listado de Ordenes de Metalizado";
            this.Load += new System.EventHandler(this.frmMetalizeOrderList_Load);
            this.grpbOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetalizeOrder)).EndInit();
            this.grpbMetalizeDetail.ResumeLayout(false);
            this.grpbMetalizeDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbOrder;
        private System.Windows.Forms.DataGridView dgvMetalizeOrder;
        private System.Windows.Forms.GroupBox grpbMetalizeDetail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExtruder;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblLotNumber;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblProductTo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblProductFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmetalizedmystated;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmetalizedfkfilmproductionplanmetal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmetalizecodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmetalizedtype;
        private System.Windows.Forms.DataGridViewImageColumn clmmetalizefkstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmetalizeproductbase;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmetalizeproductmetalize;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmetalizewidthbase;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmetalizewidthmetalize;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmetalizeorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmetalizecoilnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmetalizelot;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmetalizecustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmetalizenotes;
        private System.Windows.Forms.DataGridViewImageColumn clmmetalizedviewer;
    }
}