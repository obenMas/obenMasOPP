namespace BPS
{
    partial class frmNationalPalletShipping
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNationalPalletShipping));
            this.tbcShippingPalletFull = new System.Windows.Forms.TabControl();
            this.tbpPalletShippingDelivery = new System.Windows.Forms.TabPage();
            this.grpbPalletsList = new System.Windows.Forms.GroupBox();
            this.dgvPalletList = new System.Windows.Forms.DataGridView();
            this.clmvalidate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmblock = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmimage = new System.Windows.Forms.DataGridViewImageColumn();
            this.grpPalletList = new System.Windows.Forms.GroupBox();
            this.lblShipping = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblPalletCode = new System.Windows.Forms.Label();
            this.txtPalletCode = new System.Windows.Forms.TextBox();
            this.tbpFullShipping = new System.Windows.Forms.TabPage();
            this.dgvPalletShipping = new System.Windows.Forms.DataGridView();
            this.clmstatuspallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnumberpallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmproductpallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcodepallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcustomerpallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmorderpallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnetweigthpallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmgrossweigthpallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmstatusdrawingpallet = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblShippingPallet = new System.Windows.Forms.Label();
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tbpMainPallet = new System.Windows.Forms.TabPage();
            this.txtMaquileCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewMaquile = new System.Windows.Forms.Button();
            this.btnShippingMaquile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMaquile = new System.Windows.Forms.DataGridView();
            this.clmmaquiledelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmmaquilestatus = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmmaquileweigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmaquilebase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmaquileproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmaquilecustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmaquilecode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmaquilenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmaquilecodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmaquileinfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbcShippingPalletFull.SuspendLayout();
            this.tbpPalletShippingDelivery.SuspendLayout();
            this.grpbPalletsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletList)).BeginInit();
            this.grpPalletList.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbpFullShipping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletShipping)).BeginInit();
            this.tbcMain.SuspendLayout();
            this.tbpMainPallet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquile)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcShippingPalletFull
            // 
            this.tbcShippingPalletFull.Controls.Add(this.tbpPalletShippingDelivery);
            this.tbcShippingPalletFull.Controls.Add(this.tbpFullShipping);
            this.tbcShippingPalletFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcShippingPalletFull.Location = new System.Drawing.Point(3, 3);
            this.tbcShippingPalletFull.Name = "tbcShippingPalletFull";
            this.tbcShippingPalletFull.SelectedIndex = 0;
            this.tbcShippingPalletFull.Size = new System.Drawing.Size(984, 498);
            this.tbcShippingPalletFull.TabIndex = 0;
            // 
            // tbpPalletShippingDelivery
            // 
            this.tbpPalletShippingDelivery.Controls.Add(this.grpbPalletsList);
            this.tbpPalletShippingDelivery.Controls.Add(this.grpPalletList);
            this.tbpPalletShippingDelivery.Controls.Add(this.groupBox1);
            this.tbpPalletShippingDelivery.Location = new System.Drawing.Point(4, 24);
            this.tbpPalletShippingDelivery.Name = "tbpPalletShippingDelivery";
            this.tbpPalletShippingDelivery.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPalletShippingDelivery.Size = new System.Drawing.Size(976, 470);
            this.tbpPalletShippingDelivery.TabIndex = 0;
            this.tbpPalletShippingDelivery.Text = "Pallets para despachos";
            this.tbpPalletShippingDelivery.UseVisualStyleBackColor = true;
            // 
            // grpbPalletsList
            // 
            this.grpbPalletsList.Controls.Add(this.dgvPalletList);
            this.grpbPalletsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbPalletsList.Location = new System.Drawing.Point(3, 56);
            this.grpbPalletsList.Name = "grpbPalletsList";
            this.grpbPalletsList.Size = new System.Drawing.Size(970, 348);
            this.grpbPalletsList.TabIndex = 23;
            this.grpbPalletsList.TabStop = false;
            this.grpbPalletsList.Text = "Listado Pallets";
            // 
            // dgvPalletList
            // 
            this.dgvPalletList.AllowUserToAddRows = false;
            this.dgvPalletList.AllowUserToDeleteRows = false;
            this.dgvPalletList.AllowUserToOrderColumns = true;
            this.dgvPalletList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalletList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmvalidate,
            this.clmnumber,
            this.clmCode,
            this.clmStatus,
            this.clmblock,
            this.clmimage});
            this.dgvPalletList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPalletList.Location = new System.Drawing.Point(3, 17);
            this.dgvPalletList.Name = "dgvPalletList";
            this.dgvPalletList.ReadOnly = true;
            this.dgvPalletList.Size = new System.Drawing.Size(964, 328);
            this.dgvPalletList.TabIndex = 0;
            this.dgvPalletList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPalletList_CellClick);
            // 
            // clmvalidate
            // 
            this.clmvalidate.HeaderText = "";
            this.clmvalidate.Name = "clmvalidate";
            this.clmvalidate.ReadOnly = true;
            this.clmvalidate.Visible = false;
            // 
            // clmnumber
            // 
            this.clmnumber.HeaderText = "Nro.";
            this.clmnumber.Name = "clmnumber";
            this.clmnumber.ReadOnly = true;
            // 
            // clmCode
            // 
            this.clmCode.HeaderText = "Pallet";
            this.clmCode.Name = "clmCode";
            this.clmCode.ReadOnly = true;
            this.clmCode.Width = 250;
            // 
            // clmStatus
            // 
            this.clmStatus.HeaderText = "Estado";
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.ReadOnly = true;
            this.clmStatus.Width = 120;
            // 
            // clmblock
            // 
            this.clmblock.HeaderText = "";
            this.clmblock.Name = "clmblock";
            this.clmblock.ReadOnly = true;
            this.clmblock.Width = 30;
            // 
            // clmimage
            // 
            this.clmimage.HeaderText = "";
            this.clmimage.Name = "clmimage";
            this.clmimage.ReadOnly = true;
            this.clmimage.Width = 30;
            // 
            // grpPalletList
            // 
            this.grpPalletList.Controls.Add(this.lblShipping);
            this.grpPalletList.Controls.Add(this.btnProcess);
            this.grpPalletList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpPalletList.Location = new System.Drawing.Point(3, 404);
            this.grpPalletList.Name = "grpPalletList";
            this.grpPalletList.Size = new System.Drawing.Size(970, 63);
            this.grpPalletList.TabIndex = 3;
            this.grpPalletList.TabStop = false;
            // 
            // lblShipping
            // 
            this.lblShipping.AutoSize = true;
            this.lblShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipping.Location = new System.Drawing.Point(793, 23);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Size = new System.Drawing.Size(125, 25);
            this.lblShipping.TabIndex = 22;
            this.lblShipping.Text = "Despachar";
            // 
            // btnProcess
            // 
            this.btnProcess.Image = global::BPS.Lite.Properties.Resources.send;
            this.btnProcess.Location = new System.Drawing.Point(924, 17);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(40, 40);
            this.btnProcess.TabIndex = 21;
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.lblPalletCode);
            this.groupBox1.Controls.Add(this.txtPalletCode);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(970, 53);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pallets";
            // 
            // btnNew
            // 
            this.btnNew.BackgroundImage = global::BPS.Lite.Properties.Resources.page;
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNew.Location = new System.Drawing.Point(821, 20);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(25, 25);
            this.btnNew.TabIndex = 31;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblPalletCode
            // 
            this.lblPalletCode.AutoSize = true;
            this.lblPalletCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalletCode.Location = new System.Drawing.Point(116, 20);
            this.lblPalletCode.Name = "lblPalletCode";
            this.lblPalletCode.Size = new System.Drawing.Size(155, 25);
            this.lblPalletCode.TabIndex = 21;
            this.lblPalletCode.Text = "Código de Pallet";
            // 
            // txtPalletCode
            // 
            this.txtPalletCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalletCode.Location = new System.Drawing.Point(277, 17);
            this.txtPalletCode.Name = "txtPalletCode";
            this.txtPalletCode.Size = new System.Drawing.Size(450, 30);
            this.txtPalletCode.TabIndex = 22;
            this.txtPalletCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPalletCode_KeyDown);
            // 
            // tbpFullShipping
            // 
            this.tbpFullShipping.Controls.Add(this.dgvPalletShipping);
            this.tbpFullShipping.Controls.Add(this.lblDate);
            this.tbpFullShipping.Controls.Add(this.lblShippingPallet);
            this.tbpFullShipping.Location = new System.Drawing.Point(4, 24);
            this.tbpFullShipping.Name = "tbpFullShipping";
            this.tbpFullShipping.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFullShipping.Size = new System.Drawing.Size(976, 470);
            this.tbpFullShipping.TabIndex = 1;
            this.tbpFullShipping.Text = "Pallet despachados";
            this.tbpFullShipping.UseVisualStyleBackColor = true;
            // 
            // dgvPalletShipping
            // 
            this.dgvPalletShipping.AllowUserToAddRows = false;
            this.dgvPalletShipping.AllowUserToDeleteRows = false;
            this.dgvPalletShipping.AllowUserToOrderColumns = true;
            this.dgvPalletShipping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalletShipping.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmstatuspallet,
            this.clmnumberpallet,
            this.clmproductpallet,
            this.clmcodepallet,
            this.clmcustomerpallet,
            this.clmorderpallet,
            this.clmnetweigthpallet,
            this.clmgrossweigthpallet,
            this.clmstatusdrawingpallet});
            this.dgvPalletShipping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPalletShipping.Location = new System.Drawing.Point(3, 3);
            this.dgvPalletShipping.Name = "dgvPalletShipping";
            this.dgvPalletShipping.ReadOnly = true;
            this.dgvPalletShipping.Size = new System.Drawing.Size(970, 464);
            this.dgvPalletShipping.TabIndex = 2;
            // 
            // clmstatuspallet
            // 
            this.clmstatuspallet.HeaderText = "";
            this.clmstatuspallet.Name = "clmstatuspallet";
            this.clmstatuspallet.ReadOnly = true;
            this.clmstatuspallet.Visible = false;
            // 
            // clmnumberpallet
            // 
            this.clmnumberpallet.HeaderText = "Nro.";
            this.clmnumberpallet.Name = "clmnumberpallet";
            this.clmnumberpallet.ReadOnly = true;
            this.clmnumberpallet.Width = 50;
            // 
            // clmproductpallet
            // 
            this.clmproductpallet.HeaderText = "Producto";
            this.clmproductpallet.Name = "clmproductpallet";
            this.clmproductpallet.ReadOnly = true;
            this.clmproductpallet.Width = 160;
            // 
            // clmcodepallet
            // 
            this.clmcodepallet.HeaderText = "Pallet";
            this.clmcodepallet.Name = "clmcodepallet";
            this.clmcodepallet.ReadOnly = true;
            this.clmcodepallet.Width = 160;
            // 
            // clmcustomerpallet
            // 
            this.clmcustomerpallet.HeaderText = "Cliente";
            this.clmcustomerpallet.Name = "clmcustomerpallet";
            this.clmcustomerpallet.ReadOnly = true;
            this.clmcustomerpallet.Width = 160;
            // 
            // clmorderpallet
            // 
            this.clmorderpallet.HeaderText = "Orden";
            this.clmorderpallet.Name = "clmorderpallet";
            this.clmorderpallet.ReadOnly = true;
            // 
            // clmnetweigthpallet
            // 
            this.clmnetweigthpallet.HeaderText = "P. Neto";
            this.clmnetweigthpallet.Name = "clmnetweigthpallet";
            this.clmnetweigthpallet.ReadOnly = true;
            this.clmnetweigthpallet.Width = 80;
            // 
            // clmgrossweigthpallet
            // 
            this.clmgrossweigthpallet.HeaderText = "P. Bruto";
            this.clmgrossweigthpallet.Name = "clmgrossweigthpallet";
            this.clmgrossweigthpallet.ReadOnly = true;
            this.clmgrossweigthpallet.Width = 80;
            // 
            // clmstatusdrawingpallet
            // 
            this.clmstatusdrawingpallet.HeaderText = "";
            this.clmstatusdrawingpallet.Name = "clmstatusdrawingpallet";
            this.clmstatusdrawingpallet.ReadOnly = true;
            this.clmstatusdrawingpallet.Width = 30;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(488, 13);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 29);
            this.lblDate.TabIndex = 1;
            // 
            // lblShippingPallet
            // 
            this.lblShippingPallet.AutoSize = true;
            this.lblShippingPallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippingPallet.Location = new System.Drawing.Point(265, 13);
            this.lblShippingPallet.Name = "lblShippingPallet";
            this.lblShippingPallet.Size = new System.Drawing.Size(217, 29);
            this.lblShippingPallet.TabIndex = 0;
            this.lblShippingPallet.Text = "Despacho Pallets";
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tbpMainPallet);
            this.tbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMain.Location = new System.Drawing.Point(0, 0);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(998, 532);
            this.tbcMain.TabIndex = 1;
            // 
            // tbpMainPallet
            // 
            this.tbpMainPallet.Controls.Add(this.tbcShippingPalletFull);
            this.tbpMainPallet.Location = new System.Drawing.Point(4, 24);
            this.tbpMainPallet.Name = "tbpMainPallet";
            this.tbpMainPallet.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMainPallet.Size = new System.Drawing.Size(990, 504);
            this.tbpMainPallet.TabIndex = 0;
            this.tbpMainPallet.Text = "Pallet Producto Terminado";
            this.tbpMainPallet.UseVisualStyleBackColor = true;
            // 
            // txtMaquileCode
            // 
            this.txtMaquileCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaquileCode.Location = new System.Drawing.Point(295, 12);
            this.txtMaquileCode.Name = "txtMaquileCode";
            this.txtMaquileCode.Size = new System.Drawing.Size(435, 62);
            this.txtMaquileCode.TabIndex = 33;
            this.txtMaquileCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaquileCode_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 32;
            // 
            // btnNewMaquile
            // 
            this.btnNewMaquile.BackgroundImage = global::BPS.Lite.Properties.Resources.page;
            this.btnNewMaquile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNewMaquile.Location = new System.Drawing.Point(751, 32);
            this.btnNewMaquile.Name = "btnNewMaquile";
            this.btnNewMaquile.Size = new System.Drawing.Size(25, 25);
            this.btnNewMaquile.TabIndex = 34;
            this.btnNewMaquile.UseVisualStyleBackColor = true;
            this.btnNewMaquile.Click += new System.EventHandler(this.btnNewMaquile_Click);
            // 
            // btnShippingMaquile
            // 
            this.btnShippingMaquile.Image = global::BPS.Lite.Properties.Resources.send;
            this.btnShippingMaquile.Location = new System.Drawing.Point(938, 11);
            this.btnShippingMaquile.Name = "btnShippingMaquile";
            this.btnShippingMaquile.Size = new System.Drawing.Size(40, 40);
            this.btnShippingMaquile.TabIndex = 23;
            this.btnShippingMaquile.UseVisualStyleBackColor = true;
            this.btnShippingMaquile.Click += new System.EventHandler(this.btnShippingMaquile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(571, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 25);
            this.label2.TabIndex = 24;
            // 
            // dgvMaquile
            // 
            this.dgvMaquile.AllowUserToAddRows = false;
            this.dgvMaquile.AllowUserToDeleteRows = false;
            this.dgvMaquile.AllowUserToOrderColumns = true;
            this.dgvMaquile.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaquile.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMaquile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMaquile.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMaquile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaquile.Location = new System.Drawing.Point(3, 17);
            this.dgvMaquile.Name = "dgvMaquile";
            this.dgvMaquile.ReadOnly = true;
            this.dgvMaquile.RowHeadersWidth = 21;
            this.dgvMaquile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaquile.Size = new System.Drawing.Size(978, 341);
            this.dgvMaquile.TabIndex = 0;
            this.dgvMaquile.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaquile_CellContentClick);
            // 
            // clmmaquiledelete
            // 
            this.clmmaquiledelete.HeaderText = "";
            this.clmmaquiledelete.Name = "clmmaquiledelete";
            this.clmmaquiledelete.ReadOnly = true;
            this.clmmaquiledelete.Width = 30;
            // 
            // clmmaquilestatus
            // 
            this.clmmaquilestatus.HeaderText = "";
            this.clmmaquilestatus.Name = "clmmaquilestatus";
            this.clmmaquilestatus.ReadOnly = true;
            this.clmmaquilestatus.Width = 30;
            // 
            // clmmaquileweigth
            // 
            this.clmmaquileweigth.HeaderText = "Peso N.";
            this.clmmaquileweigth.Name = "clmmaquileweigth";
            this.clmmaquileweigth.ReadOnly = true;
            // 
            // clmmaquilebase
            // 
            this.clmmaquilebase.HeaderText = "Producto";
            this.clmmaquilebase.Name = "clmmaquilebase";
            this.clmmaquilebase.ReadOnly = true;
            this.clmmaquilebase.Width = 200;
            // 
            // clmmaquileproduct
            // 
            this.clmmaquileproduct.HeaderText = "Base";
            this.clmmaquileproduct.Name = "clmmaquileproduct";
            this.clmmaquileproduct.ReadOnly = true;
            this.clmmaquileproduct.Width = 80;
            // 
            // clmmaquilecustomer
            // 
            this.clmmaquilecustomer.HeaderText = "Cliente";
            this.clmmaquilecustomer.Name = "clmmaquilecustomer";
            this.clmmaquilecustomer.ReadOnly = true;
            this.clmmaquilecustomer.Width = 200;
            // 
            // clmmaquilecode
            // 
            this.clmmaquilecode.HeaderText = "Código";
            this.clmmaquilecode.Name = "clmmaquilecode";
            this.clmmaquilecode.ReadOnly = true;
            // 
            // clmmaquilenumber
            // 
            this.clmmaquilenumber.HeaderText = "Nro.";
            this.clmmaquilenumber.Name = "clmmaquilenumber";
            this.clmmaquilenumber.ReadOnly = true;
            this.clmmaquilenumber.Width = 50;
            // 
            // clmmaquilecodsec
            // 
            this.clmmaquilecodsec.HeaderText = "codsec";
            this.clmmaquilecodsec.Name = "clmmaquilecodsec";
            this.clmmaquilecodsec.ReadOnly = true;
            this.clmmaquilecodsec.Visible = false;
            // 
            // clmmaquileinfo
            // 
            this.clmmaquileinfo.HeaderText = "info";
            this.clmmaquileinfo.Name = "clmmaquileinfo";
            this.clmmaquileinfo.ReadOnly = true;
            this.clmmaquileinfo.Visible = false;
            // 
            // frmNationalPalletShipping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(998, 532);
            this.Controls.Add(this.tbcMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNationalPalletShipping";
            this.Text = "Despachos Mercadería";
            this.Load += new System.EventHandler(this.frmNationalPalletShipping_Load);
            this.tbcShippingPalletFull.ResumeLayout(false);
            this.tbpPalletShippingDelivery.ResumeLayout(false);
            this.grpbPalletsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletList)).EndInit();
            this.grpPalletList.ResumeLayout(false);
            this.grpPalletList.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbpFullShipping.ResumeLayout(false);
            this.tbpFullShipping.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletShipping)).EndInit();
            this.tbcMain.ResumeLayout(false);
            this.tbpMainPallet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcShippingPalletFull;
        private System.Windows.Forms.TabPage tbpPalletShippingDelivery;
        private System.Windows.Forms.TabPage tbpFullShipping;
        private System.Windows.Forms.GroupBox grpPalletList;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label lblShipping;
        private System.Windows.Forms.TextBox txtPalletCode;
        private System.Windows.Forms.Label lblPalletCode;
        private System.Windows.Forms.GroupBox grpbPalletsList;
        private System.Windows.Forms.DataGridView dgvPalletList;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblShippingPallet;
        private System.Windows.Forms.DataGridView dgvPalletShipping;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmstatuspallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnumberpallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmproductpallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcodepallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcustomerpallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmorderpallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnetweigthpallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmgrossweigthpallet;
        private System.Windows.Forms.DataGridViewImageColumn clmstatusdrawingpallet;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tbpMainPallet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmvalidate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatus;
        private System.Windows.Forms.DataGridViewImageColumn clmblock;
        private System.Windows.Forms.DataGridViewImageColumn clmimage;
        private System.Windows.Forms.TextBox txtMaquileCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewMaquile;
        private System.Windows.Forms.Button btnShippingMaquile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvMaquile;
        private System.Windows.Forms.DataGridViewImageColumn clmmaquiledelete;
        private System.Windows.Forms.DataGridViewImageColumn clmmaquilestatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmaquileweigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmaquilebase;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmaquileproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmaquilecustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmaquilecode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmaquilenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmaquilecodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmaquileinfo;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}