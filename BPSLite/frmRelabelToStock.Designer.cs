namespace BPS.Lite
{
    partial class frmRelabelToStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelabelToStock));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvRelabel = new System.Windows.Forms.DataGridView();
            this.btnProcesPallet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodigoPallet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvRlblCoil = new System.Windows.Forms.DataGridView();
            this.btnProcesCoil = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCoilCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clmCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSaleOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodsecCoil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodBob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSoDCoil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProdCoil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmClientCoil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIsExternal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelabel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRlblCoil)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(602, 357);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvRelabel);
            this.tabPage1.Controls.Add(this.btnProcesPallet);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(594, 331);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pallets";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvRelabel
            // 
            this.dgvRelabel.AllowUserToAddRows = false;
            this.dgvRelabel.AllowUserToDeleteRows = false;
            this.dgvRelabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelabel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCode,
            this.clmCodsec,
            this.clmCoilCount,
            this.clmProducto,
            this.clmPeso,
            this.clmSaleOrder,
            this.clmCliente});
            this.dgvRelabel.Location = new System.Drawing.Point(10, 107);
            this.dgvRelabel.Name = "dgvRelabel";
            this.dgvRelabel.ReadOnly = true;
            this.dgvRelabel.Size = new System.Drawing.Size(581, 172);
            this.dgvRelabel.TabIndex = 2;
            // 
            // btnProcesPallet
            // 
            this.btnProcesPallet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProcesPallet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcesPallet.Location = new System.Drawing.Point(497, 285);
            this.btnProcesPallet.Name = "btnProcesPallet";
            this.btnProcesPallet.Size = new System.Drawing.Size(94, 37);
            this.btnProcesPallet.TabIndex = 1;
            this.btnProcesPallet.Text = "Procesar";
            this.btnProcesPallet.UseVisualStyleBackColor = true;
            this.btnProcesPallet.Click += new System.EventHandler(this.btnProcesPallet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodigoPallet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Código de Pallet";
            // 
            // txtCodigoPallet
            // 
            this.txtCodigoPallet.CausesValidation = false;
            this.txtCodigoPallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPallet.Location = new System.Drawing.Point(102, 37);
            this.txtCodigoPallet.Name = "txtCodigoPallet";
            this.txtCodigoPallet.Size = new System.Drawing.Size(459, 31);
            this.txtCodigoPallet.TabIndex = 1;
            this.txtCodigoPallet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoPallet_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvRlblCoil);
            this.tabPage2.Controls.Add(this.btnProcesCoil);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(594, 331);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bobinas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvRlblCoil
            // 
            this.dgvRlblCoil.AllowUserToAddRows = false;
            this.dgvRlblCoil.AllowUserToDeleteRows = false;
            this.dgvRlblCoil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRlblCoil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsecCoil,
            this.clmCodBob,
            this.clmSoDCoil,
            this.clmProdCoil,
            this.clmLength,
            this.clmClientCoil,
            this.clmIsExternal});
            this.dgvRlblCoil.Location = new System.Drawing.Point(8, 109);
            this.dgvRlblCoil.Name = "dgvRlblCoil";
            this.dgvRlblCoil.ReadOnly = true;
            this.dgvRlblCoil.Size = new System.Drawing.Size(580, 171);
            this.dgvRlblCoil.TabIndex = 3;
            // 
            // btnProcesCoil
            // 
            this.btnProcesCoil.Location = new System.Drawing.Point(499, 286);
            this.btnProcesCoil.Name = "btnProcesCoil";
            this.btnProcesCoil.Size = new System.Drawing.Size(92, 39);
            this.btnProcesCoil.TabIndex = 2;
            this.btnProcesCoil.Text = "Procesar";
            this.btnProcesCoil.UseVisualStyleBackColor = true;
            this.btnProcesCoil.Click += new System.EventHandler(this.btnProcesCoil_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCoilCode);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(580, 97);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Código de Bobina";
            // 
            // txtCoilCode
            // 
            this.txtCoilCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoilCode.Location = new System.Drawing.Point(104, 32);
            this.txtCoilCode.Name = "txtCoilCode";
            this.txtCoilCode.Size = new System.Drawing.Size(416, 31);
            this.txtCoilCode.TabIndex = 1;
            this.txtCoilCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCoilCode_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código";
            // 
            // clmCode
            // 
            this.clmCode.HeaderText = "Código Pallet";
            this.clmCode.Name = "clmCode";
            this.clmCode.ReadOnly = true;
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "Codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmCoilCount
            // 
            this.clmCoilCount.HeaderText = "Código Bobina";
            this.clmCoilCount.Name = "clmCoilCount";
            this.clmCoilCount.ReadOnly = true;
            // 
            // clmProducto
            // 
            this.clmProducto.HeaderText = "Producto";
            this.clmProducto.Name = "clmProducto";
            this.clmProducto.ReadOnly = true;
            // 
            // clmPeso
            // 
            this.clmPeso.HeaderText = "Peso";
            this.clmPeso.Name = "clmPeso";
            this.clmPeso.ReadOnly = true;
            // 
            // clmSaleOrder
            // 
            this.clmSaleOrder.HeaderText = "Orden de compra";
            this.clmSaleOrder.Name = "clmSaleOrder";
            this.clmSaleOrder.ReadOnly = true;
            // 
            // clmCliente
            // 
            this.clmCliente.HeaderText = "Cliente";
            this.clmCliente.Name = "clmCliente";
            this.clmCliente.ReadOnly = true;
            // 
            // clmCodsecCoil
            // 
            this.clmCodsecCoil.HeaderText = "codsecCoil";
            this.clmCodsecCoil.Name = "clmCodsecCoil";
            this.clmCodsecCoil.ReadOnly = true;
            this.clmCodsecCoil.Visible = false;
            // 
            // clmCodBob
            // 
            this.clmCodBob.HeaderText = "Código Bobina";
            this.clmCodBob.Name = "clmCodBob";
            this.clmCodBob.ReadOnly = true;
            // 
            // clmSoDCoil
            // 
            this.clmSoDCoil.HeaderText = "Orden Compra";
            this.clmSoDCoil.Name = "clmSoDCoil";
            this.clmSoDCoil.ReadOnly = true;
            // 
            // clmProdCoil
            // 
            this.clmProdCoil.HeaderText = "Producto";
            this.clmProdCoil.Name = "clmProdCoil";
            this.clmProdCoil.ReadOnly = true;
            // 
            // clmLength
            // 
            this.clmLength.HeaderText = "Metraje";
            this.clmLength.Name = "clmLength";
            this.clmLength.ReadOnly = true;
            // 
            // clmClientCoil
            // 
            this.clmClientCoil.HeaderText = "Cliente";
            this.clmClientCoil.Name = "clmClientCoil";
            this.clmClientCoil.ReadOnly = true;
            // 
            // clmIsExternal
            // 
            this.clmIsExternal.HeaderText = "EsImpo";
            this.clmIsExternal.Name = "clmIsExternal";
            this.clmIsExternal.ReadOnly = true;
            this.clmIsExternal.Visible = false;
            // 
            // frmRelabelToStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 359);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRelabelToStock";
            this.Text = "Re-Etiquetado a Stock";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelabel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRlblCoil)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnProcesPallet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtCodigoPallet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcesCoil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCoilCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRelabel;
        private System.Windows.Forms.DataGridView dgvRlblCoil;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSaleOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsecCoil;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodBob;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSoDCoil;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProdCoil;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClientCoil;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIsExternal;
    }
}