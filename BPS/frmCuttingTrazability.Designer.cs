namespace BPS
{
    partial class frmCuttingTrazability
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuttingTrazability));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPrimaryCut = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvPrimaryCut = new System.Windows.Forms.DataGridView();
            this.clmCutter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCuttingorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCuttingstops = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCustommer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNetWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCuttingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExportPrimary = new System.Windows.Forms.Button();
            this.txtMainCoil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSecundaryCut = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvSecundaryCut = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExportSecundary = new System.Windows.Forms.Button();
            this.txtCoil = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnClearSecondary = new System.Windows.Forms.Button();
            this.btnClearPrimary = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbPrimaryCut.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimaryCut)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tbSecundaryCut.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecundaryCut)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPrimaryCut);
            this.tabControl1.Controls.Add(this.tbSecundaryCut);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1050, 422);
            this.tabControl1.TabIndex = 0;
            // 
            // tbPrimaryCut
            // 
            this.tbPrimaryCut.Controls.Add(this.groupBox3);
            this.tbPrimaryCut.Controls.Add(this.groupBox1);
            this.tbPrimaryCut.Location = new System.Drawing.Point(4, 22);
            this.tbPrimaryCut.Name = "tbPrimaryCut";
            this.tbPrimaryCut.Padding = new System.Windows.Forms.Padding(3);
            this.tbPrimaryCut.Size = new System.Drawing.Size(1042, 396);
            this.tbPrimaryCut.TabIndex = 0;
            this.tbPrimaryCut.Text = "Corte Primario";
            this.tbPrimaryCut.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvPrimaryCut);
            this.groupBox3.Location = new System.Drawing.Point(3, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1036, 327);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // dgvPrimaryCut
            // 
            this.dgvPrimaryCut.AllowUserToAddRows = false;
            this.dgvPrimaryCut.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvPrimaryCut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrimaryCut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCutter,
            this.clmCuttingorder,
            this.clmCuttingstops,
            this.clmCoilCode,
            this.clmProduct,
            this.clmCustommer,
            this.clmOrder,
            this.clmNetWeight,
            this.clmStatus,
            this.clmMainCoil,
            this.clmCuttingDate});
            this.dgvPrimaryCut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrimaryCut.Location = new System.Drawing.Point(3, 16);
            this.dgvPrimaryCut.Name = "dgvPrimaryCut";
            this.dgvPrimaryCut.Size = new System.Drawing.Size(1030, 308);
            this.dgvPrimaryCut.TabIndex = 0;
            // 
            // clmCutter
            // 
            this.clmCutter.HeaderText = "Maquina";
            this.clmCutter.Name = "clmCutter";
            this.clmCutter.Width = 90;
            // 
            // clmCuttingorder
            // 
            this.clmCuttingorder.HeaderText = "OrdenCorte";
            this.clmCuttingorder.Name = "clmCuttingorder";
            this.clmCuttingorder.Width = 70;
            // 
            // clmCuttingstops
            // 
            this.clmCuttingstops.HeaderText = "Parada";
            this.clmCuttingstops.Name = "clmCuttingstops";
            this.clmCuttingstops.Width = 70;
            // 
            // clmCoilCode
            // 
            this.clmCoilCode.HeaderText = "CodigoBobina";
            this.clmCoilCode.Name = "clmCoilCode";
            this.clmCoilCode.Width = 150;
            // 
            // clmProduct
            // 
            this.clmProduct.HeaderText = "Producto";
            this.clmProduct.Name = "clmProduct";
            // 
            // clmCustommer
            // 
            this.clmCustommer.HeaderText = "Cliente";
            this.clmCustommer.Name = "clmCustommer";
            // 
            // clmOrder
            // 
            this.clmOrder.HeaderText = "Pedido";
            this.clmOrder.Name = "clmOrder";
            // 
            // clmNetWeight
            // 
            this.clmNetWeight.HeaderText = "Peso";
            this.clmNetWeight.Name = "clmNetWeight";
            this.clmNetWeight.Width = 80;
            // 
            // clmStatus
            // 
            this.clmStatus.HeaderText = "Estado";
            this.clmStatus.Name = "clmStatus";
            // 
            // clmMainCoil
            // 
            this.clmMainCoil.HeaderText = "BobinaMadre";
            this.clmMainCoil.Name = "clmMainCoil";
            this.clmMainCoil.Width = 150;
            // 
            // clmCuttingDate
            // 
            this.clmCuttingDate.HeaderText = "FechaCorte";
            this.clmCuttingDate.Name = "clmCuttingDate";
            this.clmCuttingDate.Width = 90;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearPrimary);
            this.groupBox1.Controls.Add(this.btnExportPrimary);
            this.groupBox1.Controls.Add(this.txtMainCoil);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1036, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnExportPrimary
            // 
            this.btnExportPrimary.Image = global::BPS.Properties.Resources.doc_excel_table;
            this.btnExportPrimary.Location = new System.Drawing.Point(964, 24);
            this.btnExportPrimary.Name = "btnExportPrimary";
            this.btnExportPrimary.Size = new System.Drawing.Size(25, 25);
            this.btnExportPrimary.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnExportPrimary, "Exportar a Excel");
            this.btnExportPrimary.UseVisualStyleBackColor = true;
            this.btnExportPrimary.Click += new System.EventHandler(this.btnExportPrimary_Click);
            // 
            // txtMainCoil
            // 
            this.txtMainCoil.Location = new System.Drawing.Point(152, 26);
            this.txtMainCoil.Name = "txtMainCoil";
            this.txtMainCoil.Size = new System.Drawing.Size(197, 20);
            this.txtMainCoil.TabIndex = 1;
            this.txtMainCoil.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMainCoil_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de Bobina Madre:";
            // 
            // tbSecundaryCut
            // 
            this.tbSecundaryCut.Controls.Add(this.groupBox4);
            this.tbSecundaryCut.Controls.Add(this.groupBox2);
            this.tbSecundaryCut.Location = new System.Drawing.Point(4, 22);
            this.tbSecundaryCut.Name = "tbSecundaryCut";
            this.tbSecundaryCut.Padding = new System.Windows.Forms.Padding(3);
            this.tbSecundaryCut.Size = new System.Drawing.Size(1042, 396);
            this.tbSecundaryCut.TabIndex = 1;
            this.tbSecundaryCut.Text = "Corte Secundario";
            this.tbSecundaryCut.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvSecundaryCut);
            this.groupBox4.Location = new System.Drawing.Point(5, 64);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1034, 327);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // dgvSecundaryCut
            // 
            this.dgvSecundaryCut.AllowUserToAddRows = false;
            this.dgvSecundaryCut.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvSecundaryCut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSecundaryCut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dgvSecundaryCut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSecundaryCut.Location = new System.Drawing.Point(3, 16);
            this.dgvSecundaryCut.Name = "dgvSecundaryCut";
            this.dgvSecundaryCut.Size = new System.Drawing.Size(1028, 308);
            this.dgvSecundaryCut.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Maquina";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 90;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "OrdenCorte";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Parada";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "CodigoBobina";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Pedido";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Peso";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 80;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "BobinaMadre";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "FechaCorte";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 90;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClearSecondary);
            this.groupBox2.Controls.Add(this.btnExportSecundary);
            this.groupBox2.Controls.Add(this.txtCoil);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(5, -1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1034, 65);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnExportSecundary
            // 
            this.btnExportSecundary.Image = global::BPS.Properties.Resources.doc_excel_table;
            this.btnExportSecundary.Location = new System.Drawing.Point(962, 24);
            this.btnExportSecundary.Name = "btnExportSecundary";
            this.btnExportSecundary.Size = new System.Drawing.Size(25, 25);
            this.btnExportSecundary.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnExportSecundary, "Exportar a Excel");
            this.btnExportSecundary.UseVisualStyleBackColor = true;
            this.btnExportSecundary.Click += new System.EventHandler(this.btnExportSecundary_Click);
            // 
            // txtCoil
            // 
            this.txtCoil.Location = new System.Drawing.Point(121, 26);
            this.txtCoil.Name = "txtCoil";
            this.txtCoil.Size = new System.Drawing.Size(197, 20);
            this.txtCoil.TabIndex = 1;
            this.txtCoil.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCoil_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código de Bobina :";
            // 
            // btnClearSecondary
            // 
            this.btnClearSecondary.Image = global::BPS.Properties.Resources.funnel_clear;
            this.btnClearSecondary.Location = new System.Drawing.Point(993, 24);
            this.btnClearSecondary.Name = "btnClearSecondary";
            this.btnClearSecondary.Size = new System.Drawing.Size(25, 25);
            this.btnClearSecondary.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnClearSecondary, "Limpiar Formulario");
            this.btnClearSecondary.UseVisualStyleBackColor = true;
            this.btnClearSecondary.Click += new System.EventHandler(this.btnClearSecondary_Click);
            // 
            // btnClearPrimary
            // 
            this.btnClearPrimary.Image = global::BPS.Properties.Resources.funnel_clear;
            this.btnClearPrimary.Location = new System.Drawing.Point(995, 24);
            this.btnClearPrimary.Name = "btnClearPrimary";
            this.btnClearPrimary.Size = new System.Drawing.Size(25, 25);
            this.btnClearPrimary.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnClearPrimary, "Limpiar Formulario");
            this.btnClearPrimary.UseVisualStyleBackColor = true;
            this.btnClearPrimary.Click += new System.EventHandler(this.btnClearPrimary_Click);
            // 
            // frmCuttingTrazability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 425);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCuttingTrazability";
            this.Text = "Trazabilidad de Corte";
            this.tabControl1.ResumeLayout(false);
            this.tbPrimaryCut.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrimaryCut)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbSecundaryCut.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecundaryCut)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPrimaryCut;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvPrimaryCut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMainCoil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbSecundaryCut;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCoil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSecundaryCut;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCutter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCuttingorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCuttingstops;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustommer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNetWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoil;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCuttingDate;
        private System.Windows.Forms.Button btnExportPrimary;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button btnExportSecundary;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnClearPrimary;
        private System.Windows.Forms.Button btnClearSecondary;
    }
}