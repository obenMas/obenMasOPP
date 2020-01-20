namespace BPS
{
    partial class frmReassign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReassign));
            this.tbcReassign = new System.Windows.Forms.TabControl();
            this.tbpReassign = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtPendingAllocationReassign = new System.Windows.Forms.TextBox();
            this.txtSolicitedQuantityReassign = new System.Windows.Forms.TextBox();
            this.txtProductReassign = new System.Windows.Forms.TextBox();
            this.txtStatusReassign = new System.Windows.Forms.TextBox();
            this.txtDateReassign = new System.Windows.Forms.TextBox();
            this.txtCustomerReassign = new System.Windows.Forms.TextBox();
            this.txtOvReassign = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.cmbPlant = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.btnSearchC = new System.Windows.Forms.Button();
            this.txtMoreOrLessPltToAssign = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTotalPalletToAssign = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTotalPalletAsigned = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.dgvPalletsToAssign = new System.Windows.Forms.DataGridView();
            this.clmCodsecToAssignPallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmImgToAssignPallet = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmPalletCodeToAssign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWidthToAssignPallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiameterToAssignPallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoreToAssignPallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWeightToAssignPallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCustomerToAssignPallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOrderToAssignPallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDateToAssignPallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgvAsignedPallets = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmCodsecSalesOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodsecAsigned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletCodeAsigned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWidthAsigned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiameterAsigned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoreAsigned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWeightAsigned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmImgAssignPallet = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbcReassign.SuspendLayout();
            this.tbpReassign.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletsToAssign)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignedPallets)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcReassign
            // 
            this.tbcReassign.Controls.Add(this.tbpReassign);
            this.tbcReassign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcReassign.Location = new System.Drawing.Point(0, 0);
            this.tbcReassign.Multiline = true;
            this.tbcReassign.Name = "tbcReassign";
            this.tbcReassign.SelectedIndex = 0;
            this.tbcReassign.Size = new System.Drawing.Size(982, 624);
            this.tbcReassign.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tbcReassign.TabIndex = 0;
            // 
            // tbpReassign
            // 
            this.tbpReassign.Controls.Add(this.groupBox6);
            this.tbpReassign.Controls.Add(this.groupBox10);
            this.tbpReassign.Controls.Add(this.groupBox9);
            this.tbpReassign.Controls.Add(this.groupBox8);
            this.tbpReassign.Controls.Add(this.groupBox7);
            this.tbpReassign.Location = new System.Drawing.Point(4, 22);
            this.tbpReassign.Name = "tbpReassign";
            this.tbpReassign.Padding = new System.Windows.Forms.Padding(3);
            this.tbpReassign.Size = new System.Drawing.Size(974, 598);
            this.tbpReassign.TabIndex = 2;
            this.tbpReassign.Text = "Reasignaciones";
            this.tbpReassign.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtPendingAllocationReassign);
            this.groupBox6.Controls.Add(this.txtSolicitedQuantityReassign);
            this.groupBox6.Controls.Add(this.txtProductReassign);
            this.groupBox6.Controls.Add(this.txtStatusReassign);
            this.groupBox6.Controls.Add(this.txtDateReassign);
            this.groupBox6.Controls.Add(this.txtCustomerReassign);
            this.groupBox6.Controls.Add(this.txtOvReassign);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Location = new System.Drawing.Point(7, 7);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(952, 85);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Reasignaciones";
            // 
            // txtPendingAllocationReassign
            // 
            this.txtPendingAllocationReassign.Enabled = false;
            this.txtPendingAllocationReassign.Location = new System.Drawing.Point(616, 52);
            this.txtPendingAllocationReassign.Name = "txtPendingAllocationReassign";
            this.txtPendingAllocationReassign.Size = new System.Drawing.Size(209, 20);
            this.txtPendingAllocationReassign.TabIndex = 51;
            // 
            // txtSolicitedQuantityReassign
            // 
            this.txtSolicitedQuantityReassign.Enabled = false;
            this.txtSolicitedQuantityReassign.Location = new System.Drawing.Point(323, 52);
            this.txtSolicitedQuantityReassign.Name = "txtSolicitedQuantityReassign";
            this.txtSolicitedQuantityReassign.Size = new System.Drawing.Size(144, 20);
            this.txtSolicitedQuantityReassign.TabIndex = 50;
            // 
            // txtProductReassign
            // 
            this.txtProductReassign.Enabled = false;
            this.txtProductReassign.Location = new System.Drawing.Point(78, 52);
            this.txtProductReassign.Name = "txtProductReassign";
            this.txtProductReassign.Size = new System.Drawing.Size(125, 20);
            this.txtProductReassign.TabIndex = 49;
            // 
            // txtStatusReassign
            // 
            this.txtStatusReassign.Enabled = false;
            this.txtStatusReassign.Location = new System.Drawing.Point(725, 18);
            this.txtStatusReassign.Name = "txtStatusReassign";
            this.txtStatusReassign.Size = new System.Drawing.Size(100, 20);
            this.txtStatusReassign.TabIndex = 48;
            // 
            // txtDateReassign
            // 
            this.txtDateReassign.Enabled = false;
            this.txtDateReassign.Location = new System.Drawing.Point(528, 18);
            this.txtDateReassign.Name = "txtDateReassign";
            this.txtDateReassign.Size = new System.Drawing.Size(125, 20);
            this.txtDateReassign.TabIndex = 47;
            // 
            // txtCustomerReassign
            // 
            this.txtCustomerReassign.Enabled = false;
            this.txtCustomerReassign.Location = new System.Drawing.Point(264, 19);
            this.txtCustomerReassign.Name = "txtCustomerReassign";
            this.txtCustomerReassign.Size = new System.Drawing.Size(203, 20);
            this.txtCustomerReassign.TabIndex = 46;
            // 
            // txtOvReassign
            // 
            this.txtOvReassign.Enabled = false;
            this.txtOvReassign.Location = new System.Drawing.Point(78, 18);
            this.txtOvReassign.Name = "txtOvReassign";
            this.txtOvReassign.Size = new System.Drawing.Size(63, 20);
            this.txtOvReassign.TabIndex = 45;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(467, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 13);
            this.label15.TabIndex = 44;
            this.label15.Text = "Pendiente de Asignación:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(205, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "Cantidad Solicitada:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "Producto:                ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(658, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "Estado:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(467, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Fecha:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(205, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Cliente:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "OV:";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.cmbPlant);
            this.groupBox10.Controls.Add(this.label29);
            this.groupBox10.Controls.Add(this.btnSearchC);
            this.groupBox10.Controls.Add(this.txtMoreOrLessPltToAssign);
            this.groupBox10.Controls.Add(this.label18);
            this.groupBox10.Controls.Add(this.txtTotalPalletToAssign);
            this.groupBox10.Controls.Add(this.label17);
            this.groupBox10.Location = new System.Drawing.Point(365, 518);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(591, 77);
            this.groupBox10.TabIndex = 23;
            this.groupBox10.TabStop = false;
            // 
            // cmbPlant
            // 
            this.cmbPlant.FormattingEnabled = true;
            this.cmbPlant.Location = new System.Drawing.Point(49, 47);
            this.cmbPlant.Name = "cmbPlant";
            this.cmbPlant.Size = new System.Drawing.Size(125, 21);
            this.cmbPlant.TabIndex = 26;
            this.cmbPlant.SelectedIndexChanged += new System.EventHandler(this.cmbPlant_SelectedIndexChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(9, 53);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(40, 13);
            this.label29.TabIndex = 25;
            this.label29.Text = "Planta:";
            // 
            // btnSearchC
            // 
            this.btnSearchC.Location = new System.Drawing.Point(482, 14);
            this.btnSearchC.Name = "btnSearchC";
            this.btnSearchC.Size = new System.Drawing.Size(72, 32);
            this.btnSearchC.TabIndex = 24;
            this.btnSearchC.Text = "Buscar";
            this.btnSearchC.UseVisualStyleBackColor = true;
            this.btnSearchC.Click += new System.EventHandler(this.btnSearchC_Click);
            // 
            // txtMoreOrLessPltToAssign
            // 
            this.txtMoreOrLessPltToAssign.Location = new System.Drawing.Point(372, 19);
            this.txtMoreOrLessPltToAssign.Name = "txtMoreOrLessPltToAssign";
            this.txtMoreOrLessPltToAssign.Size = new System.Drawing.Size(91, 20);
            this.txtMoreOrLessPltToAssign.TabIndex = 23;
            this.txtMoreOrLessPltToAssign.Text = "50";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(251, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 16);
            this.label18.TabIndex = 22;
            this.label18.Text = "Margen [mm]: +/ -";
            // 
            // txtTotalPalletToAssign
            // 
            this.txtTotalPalletToAssign.Enabled = false;
            this.txtTotalPalletToAssign.Location = new System.Drawing.Point(49, 21);
            this.txtTotalPalletToAssign.Name = "txtTotalPalletToAssign";
            this.txtTotalPalletToAssign.Size = new System.Drawing.Size(125, 20);
            this.txtTotalPalletToAssign.TabIndex = 20;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "Total:";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnSave);
            this.groupBox9.Controls.Add(this.txtTotalPalletAsigned);
            this.groupBox9.Controls.Add(this.label16);
            this.groupBox9.Location = new System.Drawing.Point(10, 518);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(352, 77);
            this.groupBox9.TabIndex = 20;
            this.groupBox9.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(205, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 37);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTotalPalletAsigned
            // 
            this.txtTotalPalletAsigned.Enabled = false;
            this.txtTotalPalletAsigned.Location = new System.Drawing.Point(46, 21);
            this.txtTotalPalletAsigned.Name = "txtTotalPalletAsigned";
            this.txtTotalPalletAsigned.Size = new System.Drawing.Size(125, 20);
            this.txtTotalPalletAsigned.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "Total:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.dgvPalletsToAssign);
            this.groupBox8.Location = new System.Drawing.Point(365, 98);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(594, 420);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Pallets Asignables";
            // 
            // dgvPalletsToAssign
            // 
            this.dgvPalletsToAssign.AllowUserToAddRows = false;
            this.dgvPalletsToAssign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalletsToAssign.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsecToAssignPallet,
            this.clmImgToAssignPallet,
            this.clmPalletCodeToAssign,
            this.clmWidthToAssignPallet,
            this.clmDiameterToAssignPallet,
            this.clmCoreToAssignPallet,
            this.clmWeightToAssignPallet,
            this.clmCustomerToAssignPallet,
            this.clmOrderToAssignPallet,
            this.clmDateToAssignPallet});
            this.dgvPalletsToAssign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPalletsToAssign.Location = new System.Drawing.Point(3, 16);
            this.dgvPalletsToAssign.Name = "dgvPalletsToAssign";
            this.dgvPalletsToAssign.Size = new System.Drawing.Size(588, 401);
            this.dgvPalletsToAssign.TabIndex = 0;
            this.dgvPalletsToAssign.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPalletsToAssign_CellContentClick);
            // 
            // clmCodsecToAssignPallet
            // 
            this.clmCodsecToAssignPallet.HeaderText = "codsec";
            this.clmCodsecToAssignPallet.Name = "clmCodsecToAssignPallet";
            this.clmCodsecToAssignPallet.Visible = false;
            this.clmCodsecToAssignPallet.Width = 50;
            // 
            // clmImgToAssignPallet
            // 
            this.clmImgToAssignPallet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmImgToAssignPallet.HeaderText = "";
            this.clmImgToAssignPallet.Image = global::BPS.Properties.Resources.arrow_left;
            this.clmImgToAssignPallet.Name = "clmImgToAssignPallet";
            this.clmImgToAssignPallet.Width = 5;
            // 
            // clmPalletCodeToAssign
            // 
            this.clmPalletCodeToAssign.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmPalletCodeToAssign.HeaderText = "Código";
            this.clmPalletCodeToAssign.Name = "clmPalletCodeToAssign";
            this.clmPalletCodeToAssign.Width = 65;
            // 
            // clmWidthToAssignPallet
            // 
            this.clmWidthToAssignPallet.HeaderText = "Ancho";
            this.clmWidthToAssignPallet.Name = "clmWidthToAssignPallet";
            this.clmWidthToAssignPallet.Width = 40;
            // 
            // clmDiameterToAssignPallet
            // 
            this.clmDiameterToAssignPallet.HeaderText = "Diam";
            this.clmDiameterToAssignPallet.Name = "clmDiameterToAssignPallet";
            this.clmDiameterToAssignPallet.Width = 40;
            // 
            // clmCoreToAssignPallet
            // 
            this.clmCoreToAssignPallet.HeaderText = "Core";
            this.clmCoreToAssignPallet.Name = "clmCoreToAssignPallet";
            this.clmCoreToAssignPallet.Width = 40;
            // 
            // clmWeightToAssignPallet
            // 
            this.clmWeightToAssignPallet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmWeightToAssignPallet.HeaderText = "Peso";
            this.clmWeightToAssignPallet.Name = "clmWeightToAssignPallet";
            this.clmWeightToAssignPallet.Width = 56;
            // 
            // clmCustomerToAssignPallet
            // 
            this.clmCustomerToAssignPallet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmCustomerToAssignPallet.HeaderText = "Cliente";
            this.clmCustomerToAssignPallet.Name = "clmCustomerToAssignPallet";
            this.clmCustomerToAssignPallet.Width = 64;
            // 
            // clmOrderToAssignPallet
            // 
            this.clmOrderToAssignPallet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmOrderToAssignPallet.HeaderText = "Pedido";
            this.clmOrderToAssignPallet.Name = "clmOrderToAssignPallet";
            this.clmOrderToAssignPallet.Width = 65;
            // 
            // clmDateToAssignPallet
            // 
            this.clmDateToAssignPallet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmDateToAssignPallet.HeaderText = "Fecha";
            this.clmDateToAssignPallet.Name = "clmDateToAssignPallet";
            this.clmDateToAssignPallet.Width = 62;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dgvAsignedPallets);
            this.groupBox7.Location = new System.Drawing.Point(7, 98);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(355, 420);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Pallets Asignados";
            // 
            // dgvAsignedPallets
            // 
            this.dgvAsignedPallets.AllowUserToAddRows = false;
            this.dgvAsignedPallets.AllowUserToDeleteRows = false;
            this.dgvAsignedPallets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignedPallets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsecSalesOrder,
            this.clmCodsecAsigned,
            this.clmPalletCodeAsigned,
            this.clmWidthAsigned,
            this.clmDiameterAsigned,
            this.clmCoreAsigned,
            this.clmWeightAsigned,
            this.clmImgAssignPallet});
            this.dgvAsignedPallets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAsignedPallets.Location = new System.Drawing.Point(3, 16);
            this.dgvAsignedPallets.Name = "dgvAsignedPallets";
            this.dgvAsignedPallets.ReadOnly = true;
            this.dgvAsignedPallets.Size = new System.Drawing.Size(349, 401);
            this.dgvAsignedPallets.TabIndex = 0;
            this.dgvAsignedPallets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsignedPallets_CellContentClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::BPS.Properties.Resources.table_refresh;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 19;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::BPS.Properties.Resources.table_refresh;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 113;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::BPS.Properties.Resources.arrow_left;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewImageColumn4.HeaderText = "";
            this.dataGridViewImageColumn4.Image = global::BPS.Properties.Resources.arrow_right;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            // 
            // dataGridViewImageColumn5
            // 
            this.dataGridViewImageColumn5.HeaderText = "";
            this.dataGridViewImageColumn5.Image = global::BPS.Properties.Resources.arrow_left;
            this.dataGridViewImageColumn5.Name = "dataGridViewImageColumn5";
            this.dataGridViewImageColumn5.Width = 50;
            // 
            // dataGridViewImageColumn6
            // 
            this.dataGridViewImageColumn6.HeaderText = "";
            this.dataGridViewImageColumn6.Image = global::BPS.Properties.Resources.arrow_right;
            this.dataGridViewImageColumn6.Name = "dataGridViewImageColumn6";
            this.dataGridViewImageColumn6.Width = 50;
            // 
            // clmCodsecSalesOrder
            // 
            this.clmCodsecSalesOrder.HeaderText = "CodsecSalesOrder";
            this.clmCodsecSalesOrder.Name = "clmCodsecSalesOrder";
            this.clmCodsecSalesOrder.ReadOnly = true;
            this.clmCodsecSalesOrder.Visible = false;
            // 
            // clmCodsecAsigned
            // 
            this.clmCodsecAsigned.HeaderText = "codSec";
            this.clmCodsecAsigned.Name = "clmCodsecAsigned";
            this.clmCodsecAsigned.ReadOnly = true;
            this.clmCodsecAsigned.Visible = false;
            // 
            // clmPalletCodeAsigned
            // 
            this.clmPalletCodeAsigned.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmPalletCodeAsigned.HeaderText = "Código";
            this.clmPalletCodeAsigned.Name = "clmPalletCodeAsigned";
            this.clmPalletCodeAsigned.ReadOnly = true;
            this.clmPalletCodeAsigned.Width = 65;
            // 
            // clmWidthAsigned
            // 
            this.clmWidthAsigned.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmWidthAsigned.HeaderText = "Ancho";
            this.clmWidthAsigned.Name = "clmWidthAsigned";
            this.clmWidthAsigned.ReadOnly = true;
            this.clmWidthAsigned.Width = 63;
            // 
            // clmDiameterAsigned
            // 
            this.clmDiameterAsigned.HeaderText = "Diam";
            this.clmDiameterAsigned.Name = "clmDiameterAsigned";
            this.clmDiameterAsigned.ReadOnly = true;
            this.clmDiameterAsigned.Width = 40;
            // 
            // clmCoreAsigned
            // 
            this.clmCoreAsigned.HeaderText = "Core";
            this.clmCoreAsigned.Name = "clmCoreAsigned";
            this.clmCoreAsigned.ReadOnly = true;
            this.clmCoreAsigned.Width = 40;
            // 
            // clmWeightAsigned
            // 
            this.clmWeightAsigned.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmWeightAsigned.HeaderText = "Peso";
            this.clmWeightAsigned.Name = "clmWeightAsigned";
            this.clmWeightAsigned.ReadOnly = true;
            this.clmWeightAsigned.Width = 56;
            // 
            // clmImgAssignPallet
            // 
            this.clmImgAssignPallet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmImgAssignPallet.HeaderText = "";
            this.clmImgAssignPallet.Image = global::BPS.Properties.Resources.arrow_right;
            this.clmImgAssignPallet.Name = "clmImgAssignPallet";
            this.clmImgAssignPallet.ReadOnly = true;
            this.clmImgAssignPallet.Width = 5;
            // 
            // frmReassign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(982, 624);
            this.Controls.Add(this.tbcReassign);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReassign";
            this.Text = "Reasignaciones";
            this.tbcReassign.ResumeLayout(false);
            this.tbpReassign.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletsToAssign)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignedPallets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcReassign;
        private System.Windows.Forms.TabPage tbpReassign;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DataGridView dgvPalletsToAssign;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dgvAsignedPallets;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button btnSearchC;
        private System.Windows.Forms.TextBox txtMoreOrLessPltToAssign;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTotalPalletToAssign;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox txtTotalPalletAsigned;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtPendingAllocationReassign;
        private System.Windows.Forms.TextBox txtSolicitedQuantityReassign;
        private System.Windows.Forms.TextBox txtProductReassign;
        private System.Windows.Forms.TextBox txtStatusReassign;
        private System.Windows.Forms.TextBox txtDateReassign;
        private System.Windows.Forms.TextBox txtCustomerReassign;
        private System.Windows.Forms.TextBox txtOvReassign;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsecToAssignPallet;
        private System.Windows.Forms.DataGridViewImageColumn clmImgToAssignPallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletCodeToAssign;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWidthToAssignPallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiameterToAssignPallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoreToAssignPallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWeightToAssignPallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustomerToAssignPallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrderToAssignPallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDateToAssignPallet;
        private System.Windows.Forms.ComboBox cmbPlant;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsecSalesOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsecAsigned;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletCodeAsigned;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWidthAsigned;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiameterAsigned;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoreAsigned;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWeightAsigned;
        private System.Windows.Forms.DataGridViewImageColumn clmImgAssignPallet;
    }
}