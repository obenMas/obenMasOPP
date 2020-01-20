namespace BPS.Lite
{
    partial class frmInternationalSalesOrderDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInternationalSalesOrderDetail));
            this.grpbSalesOrder = new System.Windows.Forms.GroupBox();
            this.tbcHeader = new System.Windows.Forms.TabControl();
            this.tbpGeneralInfo = new System.Windows.Forms.TabPage();
            this.lblCommercialCondition = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblDateLabel = new System.Windows.Forms.Label();
            this.lblStatusLabel = new System.Windows.Forms.Label();
            this.lblCommercialConditionLabel = new System.Windows.Forms.Label();
            this.lblNumberLabel = new System.Windows.Forms.Label();
            this.tbpDeliveryData = new System.Windows.Forms.TabPage();
            this.grpbDelivery = new System.Windows.Forms.GroupBox();
            this.lblContainerLabel = new System.Windows.Forms.Label();
            this.lblPackagingLabel = new System.Windows.Forms.Label();
            this.lblPackaging = new System.Windows.Forms.Label();
            this.lblContainer = new System.Windows.Forms.Label();
            this.grpbTo = new System.Windows.Forms.GroupBox();
            this.lblCityToLabel = new System.Windows.Forms.Label();
            this.lblCountryToLabel = new System.Windows.Forms.Label();
            this.lblCountryTo = new System.Windows.Forms.Label();
            this.lblCityTo = new System.Windows.Forms.Label();
            this.grpbFrom = new System.Windows.Forms.GroupBox();
            this.lblCityFromLabel = new System.Windows.Forms.Label();
            this.lblCountryFromLabel = new System.Windows.Forms.Label();
            this.lblCountryFrom = new System.Windows.Forms.Label();
            this.lblCityFrom = new System.Windows.Forms.Label();
            this.grpbCustomer = new System.Windows.Forms.GroupBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.lblAddressLabel = new System.Windows.Forms.Label();
            this.lblCountryLabel = new System.Windows.Forms.Label();
            this.lblCustomerNameLabel = new System.Windows.Forms.Label();
            this.lblCustomerIdLabel = new System.Windows.Forms.Label();
            this.grpbDetail = new System.Windows.Forms.GroupBox();
            this.lblTotalWeith = new System.Windows.Forms.Label();
            this.lblTotalWeithLabel = new System.Windows.Forms.Label();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbNotes = new System.Windows.Forms.GroupBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.grpbActions = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpbFilters = new System.Windows.Forms.GroupBox();
            this.ttpInternationalSalesOrder = new System.Windows.Forms.ToolTip(this.components);
            this.grpbSalesOrder.SuspendLayout();
            this.tbcHeader.SuspendLayout();
            this.tbpGeneralInfo.SuspendLayout();
            this.tbpDeliveryData.SuspendLayout();
            this.grpbDelivery.SuspendLayout();
            this.grpbTo.SuspendLayout();
            this.grpbFrom.SuspendLayout();
            this.grpbCustomer.SuspendLayout();
            this.grpbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.grpbNotes.SuspendLayout();
            this.grpbActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbSalesOrder
            // 
            this.grpbSalesOrder.Controls.Add(this.tbcHeader);
            this.grpbSalesOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbSalesOrder.Location = new System.Drawing.Point(0, 0);
            this.grpbSalesOrder.Name = "grpbSalesOrder";
            this.grpbSalesOrder.Size = new System.Drawing.Size(799, 124);
            this.grpbSalesOrder.TabIndex = 0;
            this.grpbSalesOrder.TabStop = false;
            // 
            // tbcHeader
            // 
            this.tbcHeader.Controls.Add(this.tbpGeneralInfo);
            this.tbcHeader.Controls.Add(this.tbpDeliveryData);
            this.tbcHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcHeader.Location = new System.Drawing.Point(3, 17);
            this.tbcHeader.Name = "tbcHeader";
            this.tbcHeader.SelectedIndex = 0;
            this.tbcHeader.Size = new System.Drawing.Size(793, 104);
            this.tbcHeader.TabIndex = 0;
            // 
            // tbpGeneralInfo
            // 
            this.tbpGeneralInfo.BackColor = System.Drawing.SystemColors.Window;
            this.tbpGeneralInfo.Controls.Add(this.lblCommercialCondition);
            this.tbpGeneralInfo.Controls.Add(this.lblStatus);
            this.tbpGeneralInfo.Controls.Add(this.lblDate);
            this.tbpGeneralInfo.Controls.Add(this.lblNumber);
            this.tbpGeneralInfo.Controls.Add(this.lblDateLabel);
            this.tbpGeneralInfo.Controls.Add(this.lblStatusLabel);
            this.tbpGeneralInfo.Controls.Add(this.lblCommercialConditionLabel);
            this.tbpGeneralInfo.Controls.Add(this.lblNumberLabel);
            this.tbpGeneralInfo.Location = new System.Drawing.Point(4, 24);
            this.tbpGeneralInfo.Name = "tbpGeneralInfo";
            this.tbpGeneralInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpGeneralInfo.Size = new System.Drawing.Size(785, 76);
            this.tbpGeneralInfo.TabIndex = 0;
            this.tbpGeneralInfo.Text = "Información general";
            // 
            // lblCommercialCondition
            // 
            this.lblCommercialCondition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCommercialCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommercialCondition.Location = new System.Drawing.Point(659, 28);
            this.lblCommercialCondition.Name = "lblCommercialCondition";
            this.lblCommercialCondition.Size = new System.Drawing.Size(121, 21);
            this.lblCommercialCondition.TabIndex = 12;
            // 
            // lblStatus
            // 
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(428, 28);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(121, 21);
            this.lblStatus.TabIndex = 13;
            // 
            // lblDate
            // 
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(216, 28);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(155, 21);
            this.lblDate.TabIndex = 14;
            // 
            // lblNumber
            // 
            this.lblNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(63, 26);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(100, 24);
            this.lblNumber.TabIndex = 15;
            // 
            // lblDateLabel
            // 
            this.lblDateLabel.AutoSize = true;
            this.lblDateLabel.Location = new System.Drawing.Point(169, 31);
            this.lblDateLabel.Name = "lblDateLabel";
            this.lblDateLabel.Size = new System.Drawing.Size(41, 15);
            this.lblDateLabel.TabIndex = 11;
            this.lblDateLabel.Text = "Fecha";
            // 
            // lblStatusLabel
            // 
            this.lblStatusLabel.AutoSize = true;
            this.lblStatusLabel.Location = new System.Drawing.Point(377, 31);
            this.lblStatusLabel.Name = "lblStatusLabel";
            this.lblStatusLabel.Size = new System.Drawing.Size(45, 15);
            this.lblStatusLabel.TabIndex = 9;
            this.lblStatusLabel.Text = "Estado";
            // 
            // lblCommercialConditionLabel
            // 
            this.lblCommercialConditionLabel.AutoSize = true;
            this.lblCommercialConditionLabel.Location = new System.Drawing.Point(555, 31);
            this.lblCommercialConditionLabel.Name = "lblCommercialConditionLabel";
            this.lblCommercialConditionLabel.Size = new System.Drawing.Size(98, 15);
            this.lblCommercialConditionLabel.TabIndex = 10;
            this.lblCommercialConditionLabel.Text = "Cond. Comercial";
            // 
            // lblNumberLabel
            // 
            this.lblNumberLabel.AutoSize = true;
            this.lblNumberLabel.Location = new System.Drawing.Point(5, 31);
            this.lblNumberLabel.Name = "lblNumberLabel";
            this.lblNumberLabel.Size = new System.Drawing.Size(52, 15);
            this.lblNumberLabel.TabIndex = 8;
            this.lblNumberLabel.Text = "Número";
            // 
            // tbpDeliveryData
            // 
            this.tbpDeliveryData.BackColor = System.Drawing.SystemColors.Window;
            this.tbpDeliveryData.Controls.Add(this.grpbDelivery);
            this.tbpDeliveryData.Controls.Add(this.grpbTo);
            this.tbpDeliveryData.Controls.Add(this.grpbFrom);
            this.tbpDeliveryData.Location = new System.Drawing.Point(4, 24);
            this.tbpDeliveryData.Name = "tbpDeliveryData";
            this.tbpDeliveryData.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDeliveryData.Size = new System.Drawing.Size(785, 76);
            this.tbpDeliveryData.TabIndex = 2;
            this.tbpDeliveryData.Text = "Datos de destino y envio";
            // 
            // grpbDelivery
            // 
            this.grpbDelivery.Controls.Add(this.lblContainerLabel);
            this.grpbDelivery.Controls.Add(this.lblPackagingLabel);
            this.grpbDelivery.Controls.Add(this.lblPackaging);
            this.grpbDelivery.Controls.Add(this.lblContainer);
            this.grpbDelivery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbDelivery.Location = new System.Drawing.Point(523, 3);
            this.grpbDelivery.Name = "grpbDelivery";
            this.grpbDelivery.Size = new System.Drawing.Size(259, 70);
            this.grpbDelivery.TabIndex = 2;
            this.grpbDelivery.TabStop = false;
            this.grpbDelivery.Text = "Empaque";
            // 
            // lblContainerLabel
            // 
            this.lblContainerLabel.AutoSize = true;
            this.lblContainerLabel.Location = new System.Drawing.Point(25, 46);
            this.lblContainerLabel.Name = "lblContainerLabel";
            this.lblContainerLabel.Size = new System.Drawing.Size(71, 15);
            this.lblContainerLabel.TabIndex = 15;
            this.lblContainerLabel.Text = "Contenedor";
            // 
            // lblPackagingLabel
            // 
            this.lblPackagingLabel.AutoSize = true;
            this.lblPackagingLabel.Location = new System.Drawing.Point(25, 19);
            this.lblPackagingLabel.Name = "lblPackagingLabel";
            this.lblPackagingLabel.Size = new System.Drawing.Size(61, 15);
            this.lblPackagingLabel.TabIndex = 13;
            this.lblPackagingLabel.Text = "Empaque";
            // 
            // lblPackaging
            // 
            this.lblPackaging.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPackaging.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackaging.Location = new System.Drawing.Point(102, 18);
            this.lblPackaging.Name = "lblPackaging";
            this.lblPackaging.Size = new System.Drawing.Size(131, 21);
            this.lblPackaging.TabIndex = 31;
            // 
            // lblContainer
            // 
            this.lblContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContainer.Location = new System.Drawing.Point(102, 45);
            this.lblContainer.Name = "lblContainer";
            this.lblContainer.Size = new System.Drawing.Size(131, 21);
            this.lblContainer.TabIndex = 31;
            // 
            // grpbTo
            // 
            this.grpbTo.Controls.Add(this.lblCityToLabel);
            this.grpbTo.Controls.Add(this.lblCountryToLabel);
            this.grpbTo.Controls.Add(this.lblCountryTo);
            this.grpbTo.Controls.Add(this.lblCityTo);
            this.grpbTo.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpbTo.Location = new System.Drawing.Point(263, 3);
            this.grpbTo.Name = "grpbTo";
            this.grpbTo.Size = new System.Drawing.Size(260, 70);
            this.grpbTo.TabIndex = 1;
            this.grpbTo.TabStop = false;
            this.grpbTo.Text = "Destino";
            // 
            // lblCityToLabel
            // 
            this.lblCityToLabel.AutoSize = true;
            this.lblCityToLabel.Location = new System.Drawing.Point(39, 46);
            this.lblCityToLabel.Name = "lblCityToLabel";
            this.lblCityToLabel.Size = new System.Drawing.Size(46, 15);
            this.lblCityToLabel.TabIndex = 15;
            this.lblCityToLabel.Text = "Ciudad";
            // 
            // lblCountryToLabel
            // 
            this.lblCountryToLabel.AutoSize = true;
            this.lblCountryToLabel.Location = new System.Drawing.Point(39, 19);
            this.lblCountryToLabel.Name = "lblCountryToLabel";
            this.lblCountryToLabel.Size = new System.Drawing.Size(31, 15);
            this.lblCountryToLabel.TabIndex = 13;
            this.lblCountryToLabel.Text = "País";
            // 
            // lblCountryTo
            // 
            this.lblCountryTo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCountryTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountryTo.Location = new System.Drawing.Point(91, 18);
            this.lblCountryTo.Name = "lblCountryTo";
            this.lblCountryTo.Size = new System.Drawing.Size(131, 21);
            this.lblCountryTo.TabIndex = 31;
            // 
            // lblCityTo
            // 
            this.lblCityTo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCityTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityTo.Location = new System.Drawing.Point(91, 45);
            this.lblCityTo.Name = "lblCityTo";
            this.lblCityTo.Size = new System.Drawing.Size(131, 21);
            this.lblCityTo.TabIndex = 31;
            // 
            // grpbFrom
            // 
            this.grpbFrom.Controls.Add(this.lblCityFromLabel);
            this.grpbFrom.Controls.Add(this.lblCountryFromLabel);
            this.grpbFrom.Controls.Add(this.lblCountryFrom);
            this.grpbFrom.Controls.Add(this.lblCityFrom);
            this.grpbFrom.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpbFrom.Location = new System.Drawing.Point(3, 3);
            this.grpbFrom.Name = "grpbFrom";
            this.grpbFrom.Size = new System.Drawing.Size(260, 70);
            this.grpbFrom.TabIndex = 0;
            this.grpbFrom.TabStop = false;
            this.grpbFrom.Text = "Origen";
            // 
            // lblCityFromLabel
            // 
            this.lblCityFromLabel.AutoSize = true;
            this.lblCityFromLabel.Location = new System.Drawing.Point(39, 46);
            this.lblCityFromLabel.Name = "lblCityFromLabel";
            this.lblCityFromLabel.Size = new System.Drawing.Size(46, 15);
            this.lblCityFromLabel.TabIndex = 15;
            this.lblCityFromLabel.Text = "Ciudad";
            // 
            // lblCountryFromLabel
            // 
            this.lblCountryFromLabel.AutoSize = true;
            this.lblCountryFromLabel.Location = new System.Drawing.Point(39, 19);
            this.lblCountryFromLabel.Name = "lblCountryFromLabel";
            this.lblCountryFromLabel.Size = new System.Drawing.Size(31, 15);
            this.lblCountryFromLabel.TabIndex = 13;
            this.lblCountryFromLabel.Text = "País";
            // 
            // lblCountryFrom
            // 
            this.lblCountryFrom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCountryFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountryFrom.Location = new System.Drawing.Point(91, 18);
            this.lblCountryFrom.Name = "lblCountryFrom";
            this.lblCountryFrom.Size = new System.Drawing.Size(131, 21);
            this.lblCountryFrom.TabIndex = 31;
            // 
            // lblCityFrom
            // 
            this.lblCityFrom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCityFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityFrom.Location = new System.Drawing.Point(91, 45);
            this.lblCityFrom.Name = "lblCityFrom";
            this.lblCityFrom.Size = new System.Drawing.Size(131, 21);
            this.lblCityFrom.TabIndex = 31;
            // 
            // grpbCustomer
            // 
            this.grpbCustomer.Controls.Add(this.lblAddress);
            this.grpbCustomer.Controls.Add(this.lblCustomerName);
            this.grpbCustomer.Controls.Add(this.lblCountry);
            this.grpbCustomer.Controls.Add(this.lblCustomerId);
            this.grpbCustomer.Controls.Add(this.lblAddressLabel);
            this.grpbCustomer.Controls.Add(this.lblCountryLabel);
            this.grpbCustomer.Controls.Add(this.lblCustomerNameLabel);
            this.grpbCustomer.Controls.Add(this.lblCustomerIdLabel);
            this.grpbCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbCustomer.Location = new System.Drawing.Point(0, 124);
            this.grpbCustomer.Name = "grpbCustomer";
            this.grpbCustomer.Size = new System.Drawing.Size(799, 65);
            this.grpbCustomer.TabIndex = 1;
            this.grpbCustomer.TabStop = false;
            this.grpbCustomer.Text = "Cliente";
            // 
            // lblAddress
            // 
            this.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(321, 40);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(443, 21);
            this.lblAddress.TabIndex = 30;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(321, 12);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(443, 21);
            this.lblCustomerName.TabIndex = 33;
            // 
            // lblCountry
            // 
            this.lblCountry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(126, 40);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(131, 21);
            this.lblCountry.TabIndex = 32;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerId.Location = new System.Drawing.Point(126, 12);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(131, 21);
            this.lblCustomerId.TabIndex = 31;
            // 
            // lblAddressLabel
            // 
            this.lblAddressLabel.AutoSize = true;
            this.lblAddressLabel.Location = new System.Drawing.Point(263, 41);
            this.lblAddressLabel.Name = "lblAddressLabel";
            this.lblAddressLabel.Size = new System.Drawing.Size(59, 15);
            this.lblAddressLabel.TabIndex = 35;
            this.lblAddressLabel.Text = "Dirección";
            // 
            // lblCountryLabel
            // 
            this.lblCountryLabel.AutoSize = true;
            this.lblCountryLabel.Location = new System.Drawing.Point(34, 41);
            this.lblCountryLabel.Name = "lblCountryLabel";
            this.lblCountryLabel.Size = new System.Drawing.Size(86, 15);
            this.lblCountryLabel.TabIndex = 34;
            this.lblCountryLabel.Text = "País de origen";
            // 
            // lblCustomerNameLabel
            // 
            this.lblCustomerNameLabel.AutoSize = true;
            this.lblCustomerNameLabel.Location = new System.Drawing.Point(263, 13);
            this.lblCustomerNameLabel.Name = "lblCustomerNameLabel";
            this.lblCustomerNameLabel.Size = new System.Drawing.Size(52, 15);
            this.lblCustomerNameLabel.TabIndex = 29;
            this.lblCustomerNameLabel.Text = "Nombre";
            // 
            // lblCustomerIdLabel
            // 
            this.lblCustomerIdLabel.AutoSize = true;
            this.lblCustomerIdLabel.Location = new System.Drawing.Point(34, 13);
            this.lblCustomerIdLabel.Name = "lblCustomerIdLabel";
            this.lblCustomerIdLabel.Size = new System.Drawing.Size(79, 15);
            this.lblCustomerIdLabel.TabIndex = 28;
            this.lblCustomerIdLabel.Text = "Identificación";
            // 
            // grpbDetail
            // 
            this.grpbDetail.Controls.Add(this.lblTotalWeith);
            this.grpbDetail.Controls.Add(this.lblTotalWeithLabel);
            this.grpbDetail.Controls.Add(this.dgvDetail);
            this.grpbDetail.Controls.Add(this.grpbNotes);
            this.grpbDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbDetail.Location = new System.Drawing.Point(0, 189);
            this.grpbDetail.Name = "grpbDetail";
            this.grpbDetail.Size = new System.Drawing.Size(799, 247);
            this.grpbDetail.TabIndex = 2;
            this.grpbDetail.TabStop = false;
            this.grpbDetail.Text = "Detalle";
            // 
            // lblTotalWeith
            // 
            this.lblTotalWeith.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalWeith.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWeith.Location = new System.Drawing.Point(696, 173);
            this.lblTotalWeith.Name = "lblTotalWeith";
            this.lblTotalWeith.Size = new System.Drawing.Size(100, 21);
            this.lblTotalWeith.TabIndex = 9;
            // 
            // lblTotalWeithLabel
            // 
            this.lblTotalWeithLabel.AutoSize = true;
            this.lblTotalWeithLabel.Location = new System.Drawing.Point(634, 174);
            this.lblTotalWeithLabel.Name = "lblTotalWeithLabel";
            this.lblTotalWeithLabel.Size = new System.Drawing.Size(60, 15);
            this.lblTotalWeithLabel.TabIndex = 8;
            this.lblTotalWeithLabel.Text = "Total (Kg)";
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmProductCodsec,
            this.clmQuantity,
            this.clmProductCode,
            this.clmProductName,
            this.clmStock,
            this.clmStatus});
            this.dgvDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDetail.Location = new System.Drawing.Point(3, 16);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.Size = new System.Drawing.Size(793, 150);
            this.dgvDetail.TabIndex = 7;
            // 
            // clmCodsec
            // 
            dataGridViewCellStyle1.NullValue = "0";
            this.clmCodsec.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmProductCodsec
            // 
            this.clmProductCodsec.HeaderText = "productCodsec";
            this.clmProductCodsec.Name = "clmProductCodsec";
            this.clmProductCodsec.ReadOnly = true;
            this.clmProductCodsec.Visible = false;
            // 
            // clmQuantity
            // 
            this.clmQuantity.HeaderText = "Cantidad";
            this.clmQuantity.Name = "clmQuantity";
            this.clmQuantity.ReadOnly = true;
            this.clmQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmQuantity.Width = 105;
            // 
            // clmProductCode
            // 
            this.clmProductCode.HeaderText = "Código";
            this.clmProductCode.Name = "clmProductCode";
            this.clmProductCode.ReadOnly = true;
            this.clmProductCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmProductCode.Width = 130;
            // 
            // clmProductName
            // 
            this.clmProductName.HeaderText = "Producto";
            this.clmProductName.Name = "clmProductName";
            this.clmProductName.ReadOnly = true;
            this.clmProductName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmProductName.Width = 400;
            // 
            // clmStock
            // 
            this.clmStock.HeaderText = "Stock";
            this.clmStock.Name = "clmStock";
            this.clmStock.ReadOnly = true;
            this.clmStock.Width = 105;
            // 
            // clmStatus
            // 
            this.clmStatus.HeaderText = "Status";
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.ReadOnly = true;
            this.clmStatus.Visible = false;
            // 
            // grpbNotes
            // 
            this.grpbNotes.Controls.Add(this.lblNotes);
            this.grpbNotes.Location = new System.Drawing.Point(3, 173);
            this.grpbNotes.Name = "grpbNotes";
            this.grpbNotes.Size = new System.Drawing.Size(406, 69);
            this.grpbNotes.TabIndex = 6;
            this.grpbNotes.TabStop = false;
            this.grpbNotes.Text = "Notas";
            // 
            // lblNotes
            // 
            this.lblNotes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(8, 16);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(391, 48);
            this.lblNotes.TabIndex = 8;
            // 
            // grpbActions
            // 
            this.grpbActions.Controls.Add(this.btnClose);
            this.grpbActions.Location = new System.Drawing.Point(769, 431);
            this.grpbActions.Name = "grpbActions";
            this.grpbActions.Size = new System.Drawing.Size(30, 43);
            this.grpbActions.TabIndex = 10;
            this.grpbActions.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::BPS.Lite.Properties.Resources.door_in;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(3, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 3;
            this.ttpInternationalSalesOrder.SetToolTip(this.btnClose, "Salir Ordenes de Venta Internacionales");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpbFilters
            // 
            this.grpbFilters.Location = new System.Drawing.Point(0, 431);
            this.grpbFilters.Name = "grpbFilters";
            this.grpbFilters.Size = new System.Drawing.Size(766, 43);
            this.grpbFilters.TabIndex = 11;
            this.grpbFilters.TabStop = false;
            // 
            // frmInternationalSalesOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(799, 476);
            this.Controls.Add(this.grpbDetail);
            this.Controls.Add(this.grpbCustomer);
            this.Controls.Add(this.grpbSalesOrder);
            this.Controls.Add(this.grpbActions);
            this.Controls.Add(this.grpbFilters);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInternationalSalesOrderDetail";
            this.Text = "Orden de Venta Internacionales";
            this.Load += new System.EventHandler(this.frmInternationalSalesOrderDetail_Load);
            this.grpbSalesOrder.ResumeLayout(false);
            this.tbcHeader.ResumeLayout(false);
            this.tbpGeneralInfo.ResumeLayout(false);
            this.tbpGeneralInfo.PerformLayout();
            this.tbpDeliveryData.ResumeLayout(false);
            this.grpbDelivery.ResumeLayout(false);
            this.grpbDelivery.PerformLayout();
            this.grpbTo.ResumeLayout(false);
            this.grpbTo.PerformLayout();
            this.grpbFrom.ResumeLayout(false);
            this.grpbFrom.PerformLayout();
            this.grpbCustomer.ResumeLayout(false);
            this.grpbCustomer.PerformLayout();
            this.grpbDetail.ResumeLayout(false);
            this.grpbDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.grpbNotes.ResumeLayout(false);
            this.grpbActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbSalesOrder;
        private System.Windows.Forms.GroupBox grpbCustomer;
        private System.Windows.Forms.GroupBox grpbDetail;
        private System.Windows.Forms.GroupBox grpbNotes;
        private System.Windows.Forms.TabControl tbcHeader;
        private System.Windows.Forms.TabPage tbpGeneralInfo;
        private System.Windows.Forms.TabPage tbpDeliveryData;
        private System.Windows.Forms.GroupBox grpbFrom;
        private System.Windows.Forms.Label lblCityFromLabel;
        private System.Windows.Forms.Label lblCountryFromLabel;
        private System.Windows.Forms.GroupBox grpbDelivery;
        private System.Windows.Forms.Label lblPackagingLabel;
        private System.Windows.Forms.GroupBox grpbTo;
        private System.Windows.Forms.Label lblCityToLabel;
        private System.Windows.Forms.Label lblCountryToLabel;
        private System.Windows.Forms.Label lblContainerLabel;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblAddressLabel;
        private System.Windows.Forms.Label lblCountryLabel;
        private System.Windows.Forms.Label lblCustomerNameLabel;
        private System.Windows.Forms.Label lblCustomerIdLabel;
        public System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatus;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblCommercialCondition;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblDateLabel;
        private System.Windows.Forms.Label lblStatusLabel;
        private System.Windows.Forms.Label lblCommercialConditionLabel;
        private System.Windows.Forms.Label lblNumberLabel;
        private System.Windows.Forms.Label lblTotalWeith;
        private System.Windows.Forms.Label lblTotalWeithLabel;
        private System.Windows.Forms.GroupBox grpbActions;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpbFilters;
        private System.Windows.Forms.Label lblCountryFrom;
        private System.Windows.Forms.Label lblCityFrom;
        private System.Windows.Forms.Label lblPackaging;
        private System.Windows.Forms.Label lblContainer;
        private System.Windows.Forms.Label lblCountryTo;
        private System.Windows.Forms.Label lblCityTo;
        private System.Windows.Forms.ToolTip ttpInternationalSalesOrder;
    }
}