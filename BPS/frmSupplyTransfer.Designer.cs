namespace BPS
{
    partial class frmSupplyTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplyTransfer));
            this.grpbButton = new System.Windows.Forms.GroupBox();
            this.btnSupplyExit = new System.Windows.Forms.Button();
            this.btnSupplySave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpbSupplyForm = new System.Windows.Forms.GroupBox();
            this.dgvDeliverSupply = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProvider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAvailableUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnitWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDispensingUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDestinity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmfkCellar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblSupply = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.cmbSupply = new System.Windows.Forms.ComboBox();
            this.ttpSupplyTransfer = new System.Windows.Forms.ToolTip(this.components);
            this.grpbButton.SuspendLayout();
            this.grpbSupplyForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliverSupply)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbButton
            // 
            this.grpbButton.Controls.Add(this.btnSupplyExit);
            this.grpbButton.Controls.Add(this.btnSupplySave);
            this.grpbButton.Location = new System.Drawing.Point(897, 351);
            this.grpbButton.Name = "grpbButton";
            this.grpbButton.Size = new System.Drawing.Size(76, 53);
            this.grpbButton.TabIndex = 22;
            this.grpbButton.TabStop = false;
            // 
            // btnSupplyExit
            // 
            this.btnSupplyExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnSupplyExit.Location = new System.Drawing.Point(38, 17);
            this.btnSupplyExit.Name = "btnSupplyExit";
            this.btnSupplyExit.Size = new System.Drawing.Size(29, 29);
            this.btnSupplyExit.TabIndex = 5;
            this.ttpSupplyTransfer.SetToolTip(this.btnSupplyExit, "Salir");
            this.btnSupplyExit.UseVisualStyleBackColor = true;
            this.btnSupplyExit.Click += new System.EventHandler(this.btnSupplyExit_Click);
            // 
            // btnSupplySave
            // 
            this.btnSupplySave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSupplySave.BackgroundImage")));
            this.btnSupplySave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSupplySave.Location = new System.Drawing.Point(7, 17);
            this.btnSupplySave.Name = "btnSupplySave";
            this.btnSupplySave.Size = new System.Drawing.Size(29, 29);
            this.btnSupplySave.TabIndex = 3;
            this.ttpSupplyTransfer.SetToolTip(this.btnSupplySave, "Guardar");
            this.btnSupplySave.UseVisualStyleBackColor = true;
            this.btnSupplySave.Click += new System.EventHandler(this.btnSupplySave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(3, 350);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(888, 54);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // grpbSupplyForm
            // 
            this.grpbSupplyForm.Controls.Add(this.dgvDeliverSupply);
            this.grpbSupplyForm.Location = new System.Drawing.Point(3, 97);
            this.grpbSupplyForm.Name = "grpbSupplyForm";
            this.grpbSupplyForm.Size = new System.Drawing.Size(970, 254);
            this.grpbSupplyForm.TabIndex = 20;
            this.grpbSupplyForm.TabStop = false;
            this.grpbSupplyForm.Text = "Detalle Despacho";
            // 
            // dgvDeliverSupply
            // 
            this.dgvDeliverSupply.AllowUserToAddRows = false;
            this.dgvDeliverSupply.AllowUserToOrderColumns = true;
            this.dgvDeliverSupply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeliverSupply.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmProvider,
            this.clmLote,
            this.clmAvailableUnits,
            this.clmUnitWeigth,
            this.clmDispensingUnits,
            this.clmDestinity,
            this.clmfkCellar,
            this.clmComment});
            this.dgvDeliverSupply.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDeliverSupply.Location = new System.Drawing.Point(3, 17);
            this.dgvDeliverSupply.Name = "dgvDeliverSupply";
            this.dgvDeliverSupply.Size = new System.Drawing.Size(964, 216);
            this.dgvDeliverSupply.TabIndex = 2;
            this.dgvDeliverSupply.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeliverSupply_CellDoubleClick);
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmProvider
            // 
            this.clmProvider.HeaderText = "Proveedor";
            this.clmProvider.Name = "clmProvider";
            this.clmProvider.Width = 150;
            // 
            // clmLote
            // 
            this.clmLote.HeaderText = "Lote";
            this.clmLote.Name = "clmLote";
            // 
            // clmAvailableUnits
            // 
            this.clmAvailableUnits.HeaderText = "Unidades Disponibles";
            this.clmAvailableUnits.Name = "clmAvailableUnits";
            // 
            // clmUnitWeigth
            // 
            this.clmUnitWeigth.HeaderText = "Peso Unitario";
            this.clmUnitWeigth.Name = "clmUnitWeigth";
            // 
            // clmDispensingUnits
            // 
            this.clmDispensingUnits.HeaderText = "Unidades a Despachar";
            this.clmDispensingUnits.Name = "clmDispensingUnits";
            // 
            // clmDestinity
            // 
            this.clmDestinity.HeaderText = "Destino";
            this.clmDestinity.Name = "clmDestinity";
            this.clmDestinity.Width = 120;
            // 
            // clmfkCellar
            // 
            this.clmfkCellar.HeaderText = "fkCellar";
            this.clmfkCellar.Name = "clmfkCellar";
            this.clmfkCellar.ReadOnly = true;
            this.clmfkCellar.Visible = false;
            // 
            // clmComment
            // 
            this.clmComment.HeaderText = "Comentario";
            this.clmComment.Name = "clmComment";
            this.clmComment.Width = 250;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(683, 52);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(163, 21);
            this.txtUser.TabIndex = 19;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(615, 55);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(50, 15);
            this.lblUser.TabIndex = 17;
            this.lblUser.Text = "Usuario";
            // 
            // lblSupply
            // 
            this.lblSupply.AutoSize = true;
            this.lblSupply.Location = new System.Drawing.Point(0, 55);
            this.lblSupply.Name = "lblSupply";
            this.lblSupply.Size = new System.Drawing.Size(66, 15);
            this.lblSupply.TabIndex = 15;
            this.lblSupply.Text = "Suministro";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpDate.Location = new System.Drawing.Point(683, 8);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(283, 21);
            this.dtpDate.TabIndex = 18;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(615, 10);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 15);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "Fecha";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(76, 8);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(163, 21);
            this.txtNumber.TabIndex = 16;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(0, 10);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(52, 15);
            this.lblNumber.TabIndex = 12;
            this.lblNumber.Text = "Número";
            // 
            // cmbSupply
            // 
            this.cmbSupply.FormattingEnabled = true;
            this.cmbSupply.Location = new System.Drawing.Point(76, 46);
            this.cmbSupply.Name = "cmbSupply";
            this.cmbSupply.Size = new System.Drawing.Size(163, 23);
            this.cmbSupply.TabIndex = 23;
            this.cmbSupply.SelectedIndexChanged += new System.EventHandler(this.cmbSupply_SelectedIndexChanged);
            this.cmbSupply.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSupply_KeyDown);
            // 
            // frmSupplyTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 407);
            this.Controls.Add(this.cmbSupply);
            this.Controls.Add(this.grpbButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpbSupplyForm);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblSupply);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblNumber);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSupplyTransfer";
            this.Text = "Despacho Suministros";
            this.Load += new System.EventHandler(this.frmSupplyTransfer_Load);
            this.grpbButton.ResumeLayout(false);
            this.grpbSupplyForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliverSupply)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbButton;
        private System.Windows.Forms.Button btnSupplyExit;
        private System.Windows.Forms.Button btnSupplySave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grpbSupplyForm;
        private System.Windows.Forms.DataGridView dgvDeliverSupply;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblSupply;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.ComboBox cmbSupply;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAvailableUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnitWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDispensingUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDestinity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfkCellar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmComment;
        private System.Windows.Forms.ToolTip ttpSupplyTransfer;
    }
}