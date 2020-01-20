namespace BPS.Lite
{
    partial class frmPalletCellarReturn
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnProcessPallet = new System.Windows.Forms.Button();
            this.dgvReturnPallet = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtReturnPallet = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMovimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCheckPallet = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnPallet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(6, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(881, 510);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(873, 484);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Devoluciones por pallet";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnProcessPallet);
            this.groupBox2.Controls.Add(this.dgvReturnPallet);
            this.groupBox2.Location = new System.Drawing.Point(10, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(852, 414);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnProcessPallet
            // 
            this.btnProcessPallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcessPallet.Location = new System.Drawing.Point(348, 370);
            this.btnProcessPallet.Name = "btnProcessPallet";
            this.btnProcessPallet.Size = new System.Drawing.Size(130, 38);
            this.btnProcessPallet.TabIndex = 1;
            this.btnProcessPallet.Text = "Procesar";
            this.btnProcessPallet.UseVisualStyleBackColor = true;
            this.btnProcessPallet.Click += new System.EventHandler(this.btnProcessPallet_Click);
            // 
            // dgvReturnPallet
            // 
            this.dgvReturnPallet.AllowUserToAddRows = false;
            this.dgvReturnPallet.AllowUserToDeleteRows = false;
            this.dgvReturnPallet.AllowUserToOrderColumns = true;
            this.dgvReturnPallet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReturnPallet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReturnPallet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnPallet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmCodigo,
            this.clmCliente,
            this.clmOv,
            this.clmPeso,
            this.clmMovimiento,
            this.clmCheckPallet});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReturnPallet.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReturnPallet.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvReturnPallet.Location = new System.Drawing.Point(3, 16);
            this.dgvReturnPallet.Name = "dgvReturnPallet";
            this.dgvReturnPallet.ReadOnly = true;
            this.dgvReturnPallet.RowHeadersWidth = 21;
            this.dgvReturnPallet.Size = new System.Drawing.Size(846, 343);
            this.dgvReturnPallet.TabIndex = 0;
            this.dgvReturnPallet.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReturnPallet_CellContentDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.txtReturnPallet);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Location = new System.Drawing.Point(10, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(852, 50);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(633, 10);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(62, 34);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar Tabla";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtReturnPallet
            // 
            this.txtReturnPallet.Location = new System.Drawing.Point(151, 16);
            this.txtReturnPallet.Name = "txtReturnPallet";
            this.txtReturnPallet.Size = new System.Drawing.Size(444, 20);
            this.txtReturnPallet.TabIndex = 1;
            this.txtReturnPallet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReturnPallet_KeyDown);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(6, 16);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(139, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código de pallet";
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "Column1";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmCodigo
            // 
            this.clmCodigo.HeaderText = "Codigo";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            // 
            // clmCliente
            // 
            this.clmCliente.HeaderText = "Cliente";
            this.clmCliente.Name = "clmCliente";
            this.clmCliente.ReadOnly = true;
            // 
            // clmOv
            // 
            this.clmOv.HeaderText = "OV";
            this.clmOv.Name = "clmOv";
            this.clmOv.ReadOnly = true;
            // 
            // clmPeso
            // 
            this.clmPeso.HeaderText = "Peso";
            this.clmPeso.Name = "clmPeso";
            this.clmPeso.ReadOnly = true;
            // 
            // clmMovimiento
            // 
            this.clmMovimiento.HeaderText = "Movimiento";
            this.clmMovimiento.Name = "clmMovimiento";
            this.clmMovimiento.ReadOnly = true;
            // 
            // clmCheckPallet
            // 
            this.clmCheckPallet.HeaderText = "";
            this.clmCheckPallet.Name = "clmCheckPallet";
            this.clmCheckPallet.ReadOnly = true;
            this.clmCheckPallet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // frmPalletCellarReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 512);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmPalletCellarReturn";
            this.Text = "Devoluciones";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnPallet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtReturnPallet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvReturnPallet;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnProcessPallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOv;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMovimiento;
        private System.Windows.Forms.DataGridViewImageColumn clmCheckPallet;
    }
}