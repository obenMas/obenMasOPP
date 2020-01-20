using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS
{
    class clsStopLayout
    {
        //Attributes

        private TabPage sly_tbpStop;
        private TabControl sly_tbcCoilsInfo;
        private TabPage sly_tbpCoils;
        private TabPage sly_tbpMainCoils;
        private GroupBox sly_grpbUsedMainCoil;
        private Label sly_lblGramaje;
        private Label sly_lblWidht;
        private Label sly_lblVelocity;
        private Label sly_lblKgPerHour;
        private Label sly_lblUnit8;
        private Label sly_lblUnit4;
        private Label sly_lblUnit6;
        private Label sly_lblUnit3;
        private Label sly_lblUnit5;
        private Label sly_lblUnit1;
        private Label sly_lblNetWeigth;
        private Label sly_lblNetLength;
        private Label sly_lblMainCoilNetWeigth;
        private Label sly_lblMainCoilNetLength;
        private Label sly_lblMainCoilVelocity;
        private Label sly_lblMainCoilGramaje;
        private Label sly_lblMainCoilWidth;
        private Label sly_lblMainCoilKgPerHour;
        private Label sly_lblMachine;
        private Label sly_lblMainCoilMachine;
        private Label sly_lblLot;
        private Label sly_lblMainCoilBatch;
        private TextBox sly_txtMainCoilCode;
        private Label sly_lblCode;
        private Button sly_btnAdd;
        private Button sly_btnMainCoilCancel;
        private DataGridView sly_dgvCoilsDetail;
        private DataGridViewTextBoxColumn sly_clmCodsec;
        private DataGridViewTextBoxColumn sly_clmSalesOrderDetailCodsec;
        private DataGridViewTextBoxColumn sly_clmCuttingDetailCodsec;
        private DataGridViewTextBoxColumn sly_clmPosition;
        private DataGridViewTextBoxColumn sly_clmCustomer;
        private DataGridViewTextBoxColumn sly_clmSalesOrder;
        private DataGridViewTextBoxColumn sly_clmProductCode;
        private DataGridViewTextBoxColumn sly_clmWidth;
        private DataGridViewTextBoxColumn sly_clmLength;
        private DataGridViewTextBoxColumn sly_clmWeigth;
        private DataGridView sly_dgvMainCoilList;
        private Label sly_lblUnit9;
        private Label sly_lblCoilsWeigth;
        private Label sly_lblCoilsWeigthLabel;
        private Label sly_lblUnit10;
        private TextBox sly_txtUsedLength;
        private Label sly_lblUsedLength;
        private DataGridViewTextBoxColumn sly_clmMainCoilListCodsec;
        private DataGridViewTextBoxColumn sly_clmMainCoilListFilm;
        private DataGridViewTextBoxColumn sly_clmMainCoilListCode;
        private DataGridViewTextBoxColumn sly_clmMainCoilListBatch;
        private DataGridViewTextBoxColumn sly_clmMainCoilListLabRating;
        private DataGridViewTextBoxColumn sly_clmMainCoilListInitDate;
        private DataGridViewTextBoxColumn sly_clmMainCoilUsedLenth;
        private Button sly_btnCloseStop;
        private ComboBox sly_cmbOperator;
        private Label sly_lblOperator;
        private ComboBox sly_cmbDigitizer;
        private Label sly_lblDigitizer;
        private ComboBox sly_cmbSupervisor;
        private Label sly_lblSupervisor;
        private Button sly_btnRegisterCoils;

        //Properties

        public TabPage tbpStop { get { return sly_tbpStop; } set { sly_tbpStop = value; } }

        public TabControl tbcCoilsInfo { get { return sly_tbcCoilsInfo; } set { sly_tbcCoilsInfo = value; } }

        public TabPage tbpCoils { get { return sly_tbpCoils; } set { sly_tbpCoils = value; } }

        public TabPage tbpMainCoils { get { return sly_tbpMainCoils; } set { sly_tbpMainCoils = value; } }

        public GroupBox grpbUsedMainCoil { get { return sly_grpbUsedMainCoil; } set { sly_grpbUsedMainCoil = value; } }

        public Label lblGramaje { get { return sly_lblGramaje; } set { sly_lblGramaje = value; } }

        public Label lblWidht { get { return sly_lblWidht; } set { sly_lblWidht = value; } }

        public Label lblVelocity { get { return sly_lblVelocity; } set { sly_lblVelocity = value; } }

        public Label lblKgPerHour { get { return sly_lblKgPerHour; } set { sly_lblKgPerHour = value; } }

        public Label lblUnit8 { get { return sly_lblUnit8; } set { sly_lblUnit8 = value; } }

        public Label lblUnit4 { get { return sly_lblUnit4; } set { sly_lblUnit4 = value; } }

        public Label lblUnit6 { get { return sly_lblUnit6; } set { sly_lblUnit6 = value; } }

        public Label lblUnit3 { get { return sly_lblUnit3; } set { sly_lblUnit3 = value; } }

        public Label lblUnit5 { get { return sly_lblUnit5; } set { sly_lblUnit5 = value; } }

        public Label lblUnit1 { get { return sly_lblUnit1; } set { sly_lblUnit1 = value; } }

        public Label lblNetWeigth { get { return sly_lblNetWeigth; } set { sly_lblNetWeigth = value; } }

        public Label lblNetLength { get { return sly_lblNetLength; } set { sly_lblNetLength = value; } }

        public Label lblMainCoilNetWeigth { get { return sly_lblMainCoilNetWeigth; } set { sly_lblMainCoilNetWeigth = value; } }

        public Label lblMainCoilNetLength { get { return sly_lblMainCoilNetLength; } set { sly_lblMainCoilNetLength = value; } }

        public Label lblMainCoilVelocity { get { return sly_lblMainCoilVelocity; } set { sly_lblMainCoilVelocity = value; } }

        public Label lblMainCoilGramaje { get { return sly_lblMainCoilGramaje; } set { sly_lblMainCoilGramaje = value; } }

        public Label lblMainCoilWidth { get { return sly_lblMainCoilWidth; } set { sly_lblMainCoilWidth = value; } }

        public Label lblMainCoilKgPerHour { get { return sly_lblMainCoilKgPerHour; } set { sly_lblMainCoilKgPerHour = value; } }

        public Label lblMachine { get { return sly_lblMachine; } set { sly_lblMachine = value; } }

        public Label lblMainCoilMachine { get { return sly_lblMainCoilMachine; } set { sly_lblMainCoilMachine = value; } }

        public Label lblLot { get { return sly_lblLot; } set { sly_lblLot = value; } }

        public Label lblMainCoilBatch { get { return sly_lblMainCoilBatch; } set { sly_lblMainCoilBatch = value; } }

        public TextBox txtMainCoilCode { get { return sly_txtMainCoilCode; } set { sly_txtMainCoilCode = value; } }

        public Label lblCode { get { return sly_lblCode; } set { sly_lblCode = value; } }

        public Button btnAdd { get { return sly_btnAdd; } set { sly_btnAdd = value; } }

        public Button btnMainCoilCancel { get { return sly_btnMainCoilCancel; } set { sly_btnMainCoilCancel = value; } }

        public DataGridView dgvCoilsDetail { get { return sly_dgvCoilsDetail; } set { sly_dgvCoilsDetail = value; } }

        public DataGridViewTextBoxColumn clmCodsec { get { return sly_clmCodsec; } set { sly_clmCodsec = value; } }

        public DataGridViewTextBoxColumn clmSalesOrderDetailCodsec { get { return sly_clmSalesOrderDetailCodsec; } set { sly_clmSalesOrderDetailCodsec = value; } }

        public DataGridViewTextBoxColumn clmCuttingOrderDetailCodsec { get { return sly_clmCuttingDetailCodsec; } set { sly_clmCuttingDetailCodsec = value; } }

        public DataGridViewTextBoxColumn clmPosition { get { return sly_clmPosition; } set { sly_clmPosition = value; } }

        public DataGridViewTextBoxColumn clmCustomer { get { return sly_clmCustomer; } set { sly_clmCustomer = value; } }

        public DataGridViewTextBoxColumn clmSalesOrder { get { return sly_clmSalesOrder; } set { sly_clmSalesOrder = value; } }

        public DataGridViewTextBoxColumn clmProductCode { get { return sly_clmProductCode; } set { sly_clmProductCode = value; } }

        public DataGridViewTextBoxColumn clmWidth { get { return sly_clmWidth; } set { sly_clmWidth = value; } }

        public DataGridViewTextBoxColumn clmLength { get { return sly_clmLength; } set { sly_clmLength = value; } }

        public DataGridViewTextBoxColumn clmWeigth { get { return sly_clmWeigth; } set { sly_clmWeigth = value; } }

        public DataGridView dgvMainCoilList { get { return sly_dgvMainCoilList; } set { sly_dgvMainCoilList = value; } }

        public Label lblUnit9 { get { return sly_lblUnit9; } set { sly_lblUnit9 = value; } }

        public Label lblCoilsWeigth { get { return sly_lblCoilsWeigth; } set { sly_lblCoilsWeigth = value; } }

        public Label lblCoilsWeigthLabel { get { return sly_lblCoilsWeigthLabel; } set { sly_lblCoilsWeigthLabel = value; } }

        public Label lblUnit10 { get { return sly_lblUnit10; } set { sly_lblUnit10 = value; } }

        public TextBox txtUsedLength { get { return sly_txtUsedLength; } set { sly_txtUsedLength = value; } }

        public Label lblUsedLength { get { return sly_lblUsedLength; } set { sly_lblUsedLength = value; } }

        public DataGridViewTextBoxColumn clmMainCoilListCodsec { get { return sly_clmMainCoilListCodsec; } set { sly_clmMainCoilListCodsec = value; } }

        public DataGridViewTextBoxColumn clmMainCoilListFilm { get { return sly_clmMainCoilListFilm; } set { sly_clmMainCoilListFilm = value; } }

        public DataGridViewTextBoxColumn clmMainCoilListCode { get { return sly_clmMainCoilListCode; } set { sly_clmMainCoilListCode = value; } }

        public DataGridViewTextBoxColumn clmMainCoilListBatch { get { return sly_clmMainCoilListBatch; } set { sly_clmMainCoilListBatch = value; } }

        public DataGridViewTextBoxColumn clmMainCoilListLabRating { get { return sly_clmMainCoilListLabRating; } set { sly_clmMainCoilListLabRating = value; } }

        public DataGridViewTextBoxColumn clmMainCoilListInitDate { get { return sly_clmMainCoilListInitDate; } set { sly_clmMainCoilListInitDate = value; } }

        public DataGridViewTextBoxColumn clmMainCoilUsedLenth { get { return sly_clmMainCoilUsedLenth; } set { sly_clmMainCoilUsedLenth = value; } }

        public Button btnCloseStop { get { return sly_btnCloseStop; } set { sly_btnCloseStop = value; } }

        public ComboBox cmbOperator { get { return sly_cmbOperator; } set { sly_cmbOperator = value; } }

        public Label lblOperator { get { return sly_lblOperator; } set { sly_lblOperator = value; } }

        public ComboBox cmbDigitizer { get { return sly_cmbDigitizer; } set { sly_cmbDigitizer = value; } }

        public Label lblDigitizer { get { return sly_lblDigitizer; } set { sly_lblDigitizer = value; } }

        public ComboBox cmbSupervisor { get { return sly_cmbSupervisor; } set { sly_cmbSupervisor = value; } }

        public Label lblSupervisor { get { return sly_lblSupervisor; } set { sly_lblSupervisor = value; } }

        public Button btnRegisterCoils { get { return sly_btnRegisterCoils; } set { sly_btnRegisterCoils = value; } }

        //Constructor

        public clsStopLayout()
        {
            tbpStop = new System.Windows.Forms.TabPage();
            tbcCoilsInfo = new System.Windows.Forms.TabControl();
            tbpCoils = new System.Windows.Forms.TabPage();
            lblUnit9 = new System.Windows.Forms.Label();
            lblCoilsWeigth = new System.Windows.Forms.Label();
            lblCoilsWeigthLabel = new System.Windows.Forms.Label();
            dgvCoilsDetail = new System.Windows.Forms.DataGridView();
            clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            clmSalesOrderDetailCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            clmCuttingOrderDetailCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            clmPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            clmCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            clmSalesOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            clmProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            clmWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            clmLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            clmWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tbpMainCoils = new System.Windows.Forms.TabPage();
            grpbUsedMainCoil = new System.Windows.Forms.GroupBox();
            dgvMainCoilList = new System.Windows.Forms.DataGridView();
            btnAdd = new System.Windows.Forms.Button();
            btnMainCoilCancel = new System.Windows.Forms.Button();
            lblGramaje = new System.Windows.Forms.Label();
            lblWidht = new System.Windows.Forms.Label();
            lblVelocity = new System.Windows.Forms.Label();
            lblKgPerHour = new System.Windows.Forms.Label();
            lblUnit8 = new System.Windows.Forms.Label();
            lblUnit4 = new System.Windows.Forms.Label();
            lblUnit6 = new System.Windows.Forms.Label();
            lblUnit3 = new System.Windows.Forms.Label();
            lblUnit5 = new System.Windows.Forms.Label();
            lblUnit1 = new System.Windows.Forms.Label();
            lblNetWeigth = new System.Windows.Forms.Label();
            lblNetLength = new System.Windows.Forms.Label();
            lblMainCoilNetWeigth = new System.Windows.Forms.Label();
            lblMainCoilNetLength = new System.Windows.Forms.Label();
            lblMainCoilVelocity = new System.Windows.Forms.Label();
            lblMainCoilGramaje = new System.Windows.Forms.Label();
            lblMainCoilWidth = new System.Windows.Forms.Label();
            lblMainCoilKgPerHour = new System.Windows.Forms.Label();
            lblMachine = new System.Windows.Forms.Label();
            lblMainCoilMachine = new System.Windows.Forms.Label();
            lblLot = new System.Windows.Forms.Label();
            lblMainCoilBatch = new System.Windows.Forms.Label();
            txtMainCoilCode = new System.Windows.Forms.TextBox();
            lblCode = new System.Windows.Forms.Label();
            lblUsedLength = new System.Windows.Forms.Label();
            txtUsedLength = new System.Windows.Forms.TextBox();
            lblUnit10 = new System.Windows.Forms.Label();
            clmMainCoilListCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            clmMainCoilListFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            clmMainCoilListCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            clmMainCoilListBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            clmMainCoilListLabRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            clmMainCoilListInitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            clmMainCoilUsedLenth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cmbOperator = new System.Windows.Forms.ComboBox();
            lblOperator = new System.Windows.Forms.Label();
            cmbDigitizer = new System.Windows.Forms.ComboBox();
            lblDigitizer = new System.Windows.Forms.Label();
            cmbSupervisor = new System.Windows.Forms.ComboBox();
            lblSupervisor = new System.Windows.Forms.Label();
            btnCloseStop = new System.Windows.Forms.Button();
            btnRegisterCoils = new System.Windows.Forms.Button();
            
            tbpStop.SuspendLayout();
            tbcCoilsInfo.SuspendLayout();
            tbpCoils.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dgvCoilsDetail)).BeginInit();
            tbpMainCoils.SuspendLayout();
            grpbUsedMainCoil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dgvMainCoilList)).BeginInit();
            
            
            // 
            // tbpStop
            // 
            tbpStop.BackColor = System.Drawing.SystemColors.Control;
            tbpStop.Controls.Add(tbcCoilsInfo);
            tbpStop.Location = new System.Drawing.Point(4, 24);
            tbpStop.Name = "tbpStop";
            tbpStop.Padding = new System.Windows.Forms.Padding(3);
            tbpStop.Size = new System.Drawing.Size(993, 355);
            tbpStop.TabIndex = 0;
            tbpStop.Text = "Parada ";
            // 
            // tbcCoilsInfo
            // 
            tbcCoilsInfo.Controls.Add(tbpCoils);
            tbcCoilsInfo.Controls.Add(tbpMainCoils);
            tbcCoilsInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            tbcCoilsInfo.Location = new System.Drawing.Point(3, 3);
            tbcCoilsInfo.Name = "tbcCoilsInfo";
            tbcCoilsInfo.SelectedIndex = 0;
            tbcCoilsInfo.Size = new System.Drawing.Size(987, 349);
            tbcCoilsInfo.TabIndex = 0;
            // 
            // tbpCoils
            // 
            tbpCoils.BackColor = System.Drawing.SystemColors.Control;
            tbpCoils.Controls.Add(btnRegisterCoils);
            tbpCoils.Controls.Add(btnCloseStop);
            tbpCoils.Controls.Add(cmbOperator);
            tbpCoils.Controls.Add(lblOperator);
            tbpCoils.Controls.Add(cmbDigitizer);
            tbpCoils.Controls.Add(lblDigitizer);
            tbpCoils.Controls.Add(cmbSupervisor);
            tbpCoils.Controls.Add(lblSupervisor);
            tbpCoils.Controls.Add(lblUnit9);
            tbpCoils.Controls.Add(lblCoilsWeigth);
            tbpCoils.Controls.Add(lblCoilsWeigthLabel);
            tbpCoils.Controls.Add(dgvCoilsDetail);
            tbpCoils.Location = new System.Drawing.Point(4, 24);
            tbpCoils.Name = "tbpCoils";
            tbpCoils.Padding = new System.Windows.Forms.Padding(3);
            tbpCoils.Size = new System.Drawing.Size(979, 321);
            tbpCoils.TabIndex = 0;
            tbpCoils.Text = "Bobinas";
            // 
            // lblUnit9
            // 
            lblUnit9.AutoSize = true;
            lblUnit9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUnit9.Location = new System.Drawing.Point(870, 291);
            lblUnit9.Name = "lblUnit9";
            lblUnit9.Size = new System.Drawing.Size(19, 12);
            lblUnit9.TabIndex = 0;
            lblUnit9.Text = "Kg.";
            // 
            // lblCoilsWeigth
            // 
            lblCoilsWeigth.BackColor = System.Drawing.SystemColors.Window;
            lblCoilsWeigth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblCoilsWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCoilsWeigth.Location = new System.Drawing.Point(783, 287);
            lblCoilsWeigth.Name = "lblCoilsWeigth";
            lblCoilsWeigth.Size = new System.Drawing.Size(84, 21);
            lblCoilsWeigth.TabIndex = 1;
            lblCoilsWeigth.Tag = "numericClearOnReload";
            lblCoilsWeigth.Text = "0";
            lblCoilsWeigth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCoilsWeigthLabel
            // 
            lblCoilsWeigthLabel.AutoSize = true;
            lblCoilsWeigthLabel.Location = new System.Drawing.Point(711, 290);
            lblCoilsWeigthLabel.Name = "lblCoilsWeigthLabel";
            lblCoilsWeigthLabel.Size = new System.Drawing.Size(64, 15);
            lblCoilsWeigthLabel.TabIndex = 2;
            lblCoilsWeigthLabel.Text = "Peso Neto";
            // 
            // dgvCoilsDetail
            // 
            dgvCoilsDetail.AllowUserToAddRows = false;
            dgvCoilsDetail.AllowUserToDeleteRows = false;
            dgvCoilsDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCoilsDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            clmCodsec,
            clmSalesOrderDetailCodsec,
            clmCuttingOrderDetailCodsec,
            clmPosition,
            clmCustomer,
            clmSalesOrder,
            clmProductCode,
            clmWidth,
            clmLength,
            clmWeigth});
            dgvCoilsDetail.Dock = System.Windows.Forms.DockStyle.Top;
            dgvCoilsDetail.Location = new System.Drawing.Point(3, 3);
            dgvCoilsDetail.Name = "dgvCoilsDetail";
            dgvCoilsDetail.ReadOnly = true;
            dgvCoilsDetail.Size = new System.Drawing.Size(973, 272);
            dgvCoilsDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCoilsDetail.TabIndex = 0;
            // 
            // clmCodsec
            // 
            clmCodsec.HeaderText = "codsec";
            clmCodsec.Name = "clmCodsec";
            clmCodsec.ReadOnly = true;
            clmCodsec.Visible = false;
            // 
            // clmSalesOrderDetailCodsec
            // 
            clmSalesOrderDetailCodsec.HeaderText = "salesOrderDetailCodsec";
            clmSalesOrderDetailCodsec.Name = "clmSalesOrderDetailCodsec";
            clmSalesOrderDetailCodsec.ReadOnly = true;
            clmSalesOrderDetailCodsec.Visible = false;
            // 
            // clmCuttingOrderDetailCodsec
            // 
            clmCuttingOrderDetailCodsec.HeaderText = "CuttingOrderDetailCodsec";
            clmCuttingOrderDetailCodsec.Name = "clmCuttingOrderDetailCodsec";
            clmCuttingOrderDetailCodsec.ReadOnly = true;
            clmCuttingOrderDetailCodsec.Visible = false;
            // 
            // clmPosition
            // 
            clmPosition.HeaderText = "Posición";
            clmPosition.Name = "clmPosition";
            clmPosition.ReadOnly = true;
            clmPosition.Width = 80;
            // 
            // clmCustomer
            // 
            clmCustomer.HeaderText = "Cliente";
            clmCustomer.Name = "clmCustomer";
            clmCustomer.ReadOnly = true;
            clmCustomer.Width = 250;
            // 
            // clmSalesOrder
            // 
            clmSalesOrder.HeaderText = "Orden";
            clmSalesOrder.Name = "clmSalesOrder";
            clmSalesOrder.ReadOnly = true;
            clmSalesOrder.Width = 80;
            // 
            // clmProductCode
            // 
            clmProductCode.HeaderText = "Cód. Producto";
            clmProductCode.Name = "clmProductCode";
            clmProductCode.ReadOnly = true;
            clmProductCode.Width = 200;
            // 
            // clmWidth
            // 
            clmWidth.HeaderText = "Ancho";
            clmWidth.Name = "clmWidth";
            clmWidth.ReadOnly = true;
            // 
            // clmLength
            // 
            clmLength.HeaderText = "Metraje";
            clmLength.Name = "clmLength";
            clmLength.ReadOnly = true;
            // 
            // clmWeigth
            // 
            clmWeigth.HeaderText = "Peso";
            clmWeigth.Name = "clmWeigth";
            clmWeigth.ReadOnly = true;
            // 
            // tbpMainCoils
            // 
            tbpMainCoils.BackColor = System.Drawing.SystemColors.Control;
            tbpMainCoils.Controls.Add(grpbUsedMainCoil);
            tbpMainCoils.Location = new System.Drawing.Point(4, 24);
            tbpMainCoils.Name = "tbpMainCoils";
            tbpMainCoils.Padding = new System.Windows.Forms.Padding(3);
            tbpMainCoils.Size = new System.Drawing.Size(979, 321);
            tbpMainCoils.TabIndex = 1;
            tbpMainCoils.Text = "Rollos madre";
            // 
            // grpbUsedMainCoil
            // 
            grpbUsedMainCoil.BackColor = System.Drawing.SystemColors.Control;
            grpbUsedMainCoil.Controls.Add(dgvMainCoilList);
            grpbUsedMainCoil.Controls.Add(btnAdd);
            grpbUsedMainCoil.Controls.Add(btnMainCoilCancel);
            grpbUsedMainCoil.Controls.Add(lblGramaje);
            grpbUsedMainCoil.Controls.Add(lblWidht);
            grpbUsedMainCoil.Controls.Add(lblVelocity);
            grpbUsedMainCoil.Controls.Add(lblKgPerHour);
            grpbUsedMainCoil.Controls.Add(lblUnit8);
            grpbUsedMainCoil.Controls.Add(lblUnit10);
            grpbUsedMainCoil.Controls.Add(lblUnit4);
            grpbUsedMainCoil.Controls.Add(lblUnit6);
            grpbUsedMainCoil.Controls.Add(lblUnit3);
            grpbUsedMainCoil.Controls.Add(lblUnit5);
            grpbUsedMainCoil.Controls.Add(lblUnit1);
            grpbUsedMainCoil.Controls.Add(lblNetWeigth);
            grpbUsedMainCoil.Controls.Add(lblNetLength);
            grpbUsedMainCoil.Controls.Add(lblMainCoilNetWeigth);
            grpbUsedMainCoil.Controls.Add(lblMainCoilNetLength);
            grpbUsedMainCoil.Controls.Add(lblMainCoilVelocity);
            grpbUsedMainCoil.Controls.Add(lblMainCoilGramaje);
            grpbUsedMainCoil.Controls.Add(lblMainCoilWidth);
            grpbUsedMainCoil.Controls.Add(lblMainCoilKgPerHour);
            grpbUsedMainCoil.Controls.Add(lblMachine);
            grpbUsedMainCoil.Controls.Add(lblMainCoilMachine);
            grpbUsedMainCoil.Controls.Add(lblLot);
            grpbUsedMainCoil.Controls.Add(lblMainCoilBatch);
            grpbUsedMainCoil.Controls.Add(txtUsedLength);
            grpbUsedMainCoil.Controls.Add(lblUsedLength);
            grpbUsedMainCoil.Controls.Add(txtMainCoilCode);
            grpbUsedMainCoil.Controls.Add(lblCode);
            grpbUsedMainCoil.Dock = System.Windows.Forms.DockStyle.Fill;
            grpbUsedMainCoil.Location = new System.Drawing.Point(3, 3);
            grpbUsedMainCoil.Name = "grpbUsedMainCoil";
            grpbUsedMainCoil.Size = new System.Drawing.Size(973, 315);
            grpbUsedMainCoil.TabIndex = 0;
            grpbUsedMainCoil.TabStop = false;
            grpbUsedMainCoil.Text = "Bobina usada";
            // 
            // dgvMainCoilList
            // 
            dgvMainCoilList.AllowUserToAddRows = false;
            dgvMainCoilList.AllowUserToDeleteRows = false;
            dgvMainCoilList.AllowUserToOrderColumns = true;
            dgvMainCoilList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMainCoilList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            clmMainCoilListCodsec,
            clmMainCoilListFilm,
            clmMainCoilListCode,
            clmMainCoilListBatch,
            clmMainCoilListLabRating,
            clmMainCoilListInitDate,
            clmMainCoilUsedLenth});
            dgvMainCoilList.Dock = System.Windows.Forms.DockStyle.Bottom;
            dgvMainCoilList.Location = new System.Drawing.Point(3, 129);
            dgvMainCoilList.Name = "dgvMainCoilList";
            dgvMainCoilList.ReadOnly = true;
            dgvMainCoilList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvMainCoilList.Size = new System.Drawing.Size(967, 183);
            dgvMainCoilList.TabIndex = 13;
            // 
            // cmbOperator
            // 
            cmbOperator.FormattingEnabled = true;
            cmbOperator.Location = new System.Drawing.Point(550, 286);
            cmbOperator.Name = "cmbOperator";
            cmbOperator.Size = new System.Drawing.Size(153, 23);
            cmbOperator.TabIndex = 72;
            // 
            // lblOperator
            // 
            lblOperator.AutoSize = true;
            lblOperator.Location = new System.Drawing.Point(483, 290);
            lblOperator.Name = "lblOperator";
            lblOperator.Size = new System.Drawing.Size(59, 15);
            lblOperator.TabIndex = 70;
            lblOperator.Text = "Operador";
            // 
            // cmbDigitizer
            // 
            cmbDigitizer.FormattingEnabled = true;
            cmbDigitizer.Location = new System.Drawing.Point(322, 286);
            cmbDigitizer.Name = "cmbDigitizer";
            cmbDigitizer.Size = new System.Drawing.Size(153, 23);
            cmbDigitizer.TabIndex = 74;
            // 
            // lblDigitizer
            // 
            lblDigitizer.AutoSize = true;
            lblDigitizer.Location = new System.Drawing.Point(257, 290);
            lblDigitizer.Name = "lblDigitizer";
            lblDigitizer.Size = new System.Drawing.Size(57, 15);
            lblDigitizer.TabIndex = 69;
            lblDigitizer.Text = "Digitador";
            // 
            // cmbSupervisor
            // 
            cmbSupervisor.FormattingEnabled = true;
            cmbSupervisor.Location = new System.Drawing.Point(96, 286);
            cmbSupervisor.Name = "cmbSupervisor";
            cmbSupervisor.Size = new System.Drawing.Size(153, 23);
            cmbSupervisor.TabIndex = 73;
            // 
            // lblSupervisor
            // 
            lblSupervisor.AutoSize = true;
            lblSupervisor.Location = new System.Drawing.Point(23, 290);
            lblSupervisor.Name = "lblSupervisor";
            lblSupervisor.Size = new System.Drawing.Size(65, 15);
            lblSupervisor.TabIndex = 71;
            lblSupervisor.Text = "Supervisor";
            // 
            // btnCloseStop
            // 
            btnCloseStop.BackgroundImage = global::BPS.Properties.Resources.lock1;
            btnCloseStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnCloseStop.Location = new System.Drawing.Point(931, 285);
            btnCloseStop.Name = "btnCloseStop";
            btnCloseStop.Size = new System.Drawing.Size(25, 25);
            btnCloseStop.TabIndex = 75;
            btnCloseStop.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnAdd.Location = new System.Drawing.Point(778, 74);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(25, 25);
            btnAdd.TabIndex = 11;
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnMainCoilCancel
            // 
            btnMainCoilCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            btnMainCoilCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnMainCoilCancel.Location = new System.Drawing.Point(778, 99);
            btnMainCoilCancel.Name = "btnMainCoilCancel";
            btnMainCoilCancel.Size = new System.Drawing.Size(25, 25);
            btnMainCoilCancel.TabIndex = 12;
            btnMainCoilCancel.UseVisualStyleBackColor = true;
            // 
            // lblGramaje
            // 
            lblGramaje.BackColor = System.Drawing.SystemColors.Window;
            lblGramaje.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblGramaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblGramaje.Location = new System.Drawing.Point(429, 101);
            lblGramaje.Name = "lblGramaje";
            lblGramaje.Size = new System.Drawing.Size(84, 21);
            lblGramaje.TabIndex = 9;
            lblGramaje.Tag = "numericClearOnReload";
            lblGramaje.Text = "0";
            lblGramaje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWidht
            // 
            lblWidht.BackColor = System.Drawing.SystemColors.Window;
            lblWidht.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblWidht.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblWidht.Location = new System.Drawing.Point(232, 101);
            lblWidht.Name = "lblWidht";
            lblWidht.Size = new System.Drawing.Size(84, 21);
            lblWidht.TabIndex = 8;
            lblWidht.Tag = "numericClearOnReload";
            lblWidht.Text = "0";
            lblWidht.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVelocity
            // 
            lblVelocity.BackColor = System.Drawing.SystemColors.Window;
            lblVelocity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblVelocity.Location = new System.Drawing.Point(429, 74);
            lblVelocity.Name = "lblVelocity";
            lblVelocity.Size = new System.Drawing.Size(84, 21);
            lblVelocity.TabIndex = 6;
            lblVelocity.Tag = "numericClearOnReload";
            lblVelocity.Text = "0";
            lblVelocity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKgPerHour
            // 
            lblKgPerHour.BackColor = System.Drawing.SystemColors.Window;
            lblKgPerHour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblKgPerHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblKgPerHour.Location = new System.Drawing.Point(232, 74);
            lblKgPerHour.Name = "lblKgPerHour";
            lblKgPerHour.Size = new System.Drawing.Size(84, 21);
            lblKgPerHour.TabIndex = 5;
            lblKgPerHour.Tag = "numericClearOnReload";
            lblKgPerHour.Text = "0";
            lblKgPerHour.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUnit8
            // 
            lblUnit8.AutoSize = true;
            lblUnit8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUnit8.Location = new System.Drawing.Point(738, 105);
            lblUnit8.Name = "lblUnit8";
            lblUnit8.Size = new System.Drawing.Size(19, 12);
            lblUnit8.TabIndex = 38;
            lblUnit8.Text = "Kg.";
            // 
            // lblUnit4
            // 
            lblUnit4.AutoSize = true;
            lblUnit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUnit4.Location = new System.Drawing.Point(738, 78);
            lblUnit4.Name = "lblUnit4";
            lblUnit4.Size = new System.Drawing.Size(28, 12);
            lblUnit4.TabIndex = 37;
            lblUnit4.Text = "Mtrs.";
            // 
            // lblUnit6
            // 
            lblUnit6.AutoSize = true;
            lblUnit6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUnit6.Location = new System.Drawing.Point(328, 105);
            lblUnit6.Name = "lblUnit6";
            lblUnit6.Size = new System.Drawing.Size(21, 12);
            lblUnit6.TabIndex = 40;
            lblUnit6.Text = "mm";
            // 
            // lblUnit3
            // 
            lblUnit3.AutoSize = true;
            lblUnit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUnit3.Location = new System.Drawing.Point(519, 105);
            lblUnit3.Name = "lblUnit3";
            lblUnit3.Size = new System.Drawing.Size(24, 12);
            lblUnit3.TabIndex = 35;
            lblUnit3.Text = "g/m²";
            // 
            // lblUnit5
            // 
            lblUnit5.AutoSize = true;
            lblUnit5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUnit5.Location = new System.Drawing.Point(520, 78);
            lblUnit5.Name = "lblUnit5";
            lblUnit5.Size = new System.Drawing.Size(43, 12);
            lblUnit5.TabIndex = 36;
            lblUnit5.Text = "Mtrs/min";
            // 
            // lblUnit1
            // 
            lblUnit1.AutoSize = true;
            lblUnit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUnit1.Location = new System.Drawing.Point(328, 78);
            lblUnit1.Name = "lblUnit1";
            lblUnit1.Size = new System.Drawing.Size(29, 12);
            lblUnit1.TabIndex = 34;
            lblUnit1.Text = "Kg/Hr";
            // 
            // lblNetWeigth
            // 
            lblNetWeigth.BackColor = System.Drawing.SystemColors.Window;
            lblNetWeigth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblNetWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNetWeigth.Location = new System.Drawing.Point(648, 101);
            lblNetWeigth.Name = "lblNetWeigth";
            lblNetWeigth.Size = new System.Drawing.Size(84, 21);
            lblNetWeigth.TabIndex = 10;
            lblNetWeigth.Tag = "numericClearOnReload";
            lblNetWeigth.Text = "0";
            lblNetWeigth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNetLength
            // 
            lblNetLength.BackColor = System.Drawing.SystemColors.Window;
            lblNetLength.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblNetLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNetLength.Location = new System.Drawing.Point(648, 74);
            lblNetLength.Name = "lblNetLength";
            lblNetLength.Size = new System.Drawing.Size(84, 21);
            lblNetLength.TabIndex = 7;
            lblNetLength.Tag = "numericClearOnReload";
            lblNetLength.Text = "0";
            lblNetLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMainCoilNetWeigth
            // 
            lblMainCoilNetWeigth.AutoSize = true;
            lblMainCoilNetWeigth.Location = new System.Drawing.Point(569, 104);
            lblMainCoilNetWeigth.Name = "lblMainCoilNetWeigth";
            lblMainCoilNetWeigth.Size = new System.Drawing.Size(64, 15);
            lblMainCoilNetWeigth.TabIndex = 32;
            lblMainCoilNetWeigth.Text = "Peso Neto";
            // 
            // lblMainCoilNetLength
            // 
            lblMainCoilNetLength.AutoSize = true;
            lblMainCoilNetLength.Location = new System.Drawing.Point(569, 77);
            lblMainCoilNetLength.Name = "lblMainCoilNetLength";
            lblMainCoilNetLength.Size = new System.Drawing.Size(78, 15);
            lblMainCoilNetLength.TabIndex = 31;
            lblMainCoilNetLength.Text = "Metraje Neto";
            // 
            // lblMainCoilVelocity
            // 
            lblMainCoilVelocity.AutoSize = true;
            lblMainCoilVelocity.Location = new System.Drawing.Point(362, 77);
            lblMainCoilVelocity.Name = "lblMainCoilVelocity";
            lblMainCoilVelocity.Size = new System.Drawing.Size(61, 15);
            lblMainCoilVelocity.TabIndex = 29;
            lblMainCoilVelocity.Text = "Velocidad";
            // 
            // lblMainCoilGramaje
            // 
            lblMainCoilGramaje.AutoSize = true;
            lblMainCoilGramaje.Location = new System.Drawing.Point(362, 104);
            lblMainCoilGramaje.Name = "lblMainCoilGramaje";
            lblMainCoilGramaje.Size = new System.Drawing.Size(55, 15);
            lblMainCoilGramaje.TabIndex = 25;
            lblMainCoilGramaje.Text = "Gramaje";
            // 
            // lblMainCoilWidth
            // 
            lblMainCoilWidth.AutoSize = true;
            lblMainCoilWidth.Location = new System.Drawing.Point(170, 104);
            lblMainCoilWidth.Name = "lblMainCoilWidth";
            lblMainCoilWidth.Size = new System.Drawing.Size(41, 15);
            lblMainCoilWidth.TabIndex = 24;
            lblMainCoilWidth.Text = "Ancho";
            // 
            // lblMainCoilKgPerHour
            // 
            lblMainCoilKgPerHour.AutoSize = true;
            lblMainCoilKgPerHour.Location = new System.Drawing.Point(170, 77);
            lblMainCoilKgPerHour.Name = "lblMainCoilKgPerHour";
            lblMainCoilKgPerHour.Size = new System.Drawing.Size(38, 15);
            lblMainCoilKgPerHour.TabIndex = 22;
            lblMainCoilKgPerHour.Text = "Kg/Hr";
            // 
            // lblMachine
            // 
            lblMachine.BackColor = System.Drawing.SystemColors.Window;
            lblMachine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblMachine.Location = new System.Drawing.Point(232, 47);
            lblMachine.Name = "lblMachine";
            lblMachine.Size = new System.Drawing.Size(318, 21);
            lblMachine.TabIndex = 3;
            lblMachine.Tag = "clearOnReload";
            lblMachine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMainCoilMachine
            // 
            lblMainCoilMachine.AutoSize = true;
            lblMainCoilMachine.Location = new System.Drawing.Point(170, 50);
            lblMainCoilMachine.Name = "lblMainCoilMachine";
            lblMainCoilMachine.Size = new System.Drawing.Size(56, 15);
            lblMainCoilMachine.TabIndex = 14;
            lblMainCoilMachine.Text = "Máquina";
            // 
            // lblLot
            // 
            lblLot.BackColor = System.Drawing.SystemColors.Window;
            lblLot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblLot.Location = new System.Drawing.Point(606, 47);
            lblLot.Name = "lblLot";
            lblLot.Size = new System.Drawing.Size(126, 21);
            lblLot.TabIndex = 4;
            lblLot.Tag = "clearOnReload";
            lblLot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMainCoilBatch
            // 
            lblMainCoilBatch.AutoSize = true;
            lblMainCoilBatch.Location = new System.Drawing.Point(569, 50);
            lblMainCoilBatch.Name = "lblMainCoilBatch";
            lblMainCoilBatch.Size = new System.Drawing.Size(31, 15);
            lblMainCoilBatch.TabIndex = 10;
            lblMainCoilBatch.Text = "Lote";
            // 
            // txtMainCoilCode
            // 
            txtMainCoilCode.Location = new System.Drawing.Point(232, 20);
            txtMainCoilCode.Name = "txtMainCoilCode";
            txtMainCoilCode.Size = new System.Drawing.Size(231, 21);
            txtMainCoilCode.TabIndex = 1;
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Location = new System.Drawing.Point(170, 23);
            lblCode.Name = "lblCode";
            lblCode.Size = new System.Drawing.Size(46, 15);
            lblCode.TabIndex = 3;
            lblCode.Text = "Código";
            // 
            // btnRegisterCoils
            // 
            this.btnRegisterCoils.BackgroundImage = global::BPS.Properties.Resources.coils;
            this.btnRegisterCoils.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRegisterCoils.Location = new System.Drawing.Point(906, 285);
            this.btnRegisterCoils.Name = "btnRegisterCoils";
            this.btnRegisterCoils.Size = new System.Drawing.Size(25, 25);
            this.btnRegisterCoils.TabIndex = 76;
            this.btnRegisterCoils.UseVisualStyleBackColor = true;
            // 
            // lblUsedLength
            // 
            lblUsedLength.AutoSize = true;
            lblUsedLength.Location = new System.Drawing.Point(473, 23);
            lblUsedLength.Name = "lblUsedLength";
            lblUsedLength.Size = new System.Drawing.Size(98, 15);
            lblUsedLength.TabIndex = 3;
            lblUsedLength.Text = "Metraje utilizado";
            // 
            // txtUsedLength
            // 
            txtUsedLength.Location = new System.Drawing.Point(577, 20);
            txtUsedLength.Name = "txtUsedLength";
            txtUsedLength.Size = new System.Drawing.Size(155, 21);
            txtUsedLength.TabIndex = 2;
            // 
            // lblUnit10
            // 
            lblUnit10.AutoSize = true;
            lblUnit10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblUnit10.Location = new System.Drawing.Point(738, 26);
            lblUnit10.Name = "lblUnit10";
            lblUnit10.Size = new System.Drawing.Size(28, 12);
            lblUnit10.TabIndex = 37;
            lblUnit10.Text = "Mtrs.";
            // 
            // clmMainCoilListCodsec
            // 
            clmMainCoilListCodsec.HeaderText = "Codsec";
            clmMainCoilListCodsec.Name = "clmMainCoilListCodsec";
            clmMainCoilListCodsec.ReadOnly = true;
            clmMainCoilListCodsec.Visible = false;
            clmMainCoilListCodsec.Width = 200;
            // 
            // clmMainCoilListFilm
            // 
            clmMainCoilListFilm.HeaderText = "Película";
            clmMainCoilListFilm.Name = "clmMainCoilListFilm";
            clmMainCoilListFilm.ReadOnly = true;
            clmMainCoilListFilm.Width = 200;
            // 
            // clmMainCoilListCode
            // 
            clmMainCoilListCode.HeaderText = "Código";
            clmMainCoilListCode.Name = "clmMainCoilListCode";
            clmMainCoilListCode.ReadOnly = true;
            clmMainCoilListCode.Width = 150;
            // 
            // clmMainCoilListBatch
            // 
            clmMainCoilListBatch.HeaderText = "Lote";
            clmMainCoilListBatch.Name = "clmMainCoilListBatch";
            clmMainCoilListBatch.ReadOnly = true;
            // 
            // clmMainCoilListLabRating
            // 
            clmMainCoilListLabRating.HeaderText = "Calificación";
            clmMainCoilListLabRating.Name = "clmMainCoilListLabRating";
            clmMainCoilListLabRating.ReadOnly = true;
            clmMainCoilListLabRating.Width = 120;
            // 
            // clmMainCoilListInitDate
            // 
            clmMainCoilListInitDate.HeaderText = "Fecha Inicio";
            clmMainCoilListInitDate.Name = "clmMainCoilListInitDate";
            clmMainCoilListInitDate.ReadOnly = true;
            clmMainCoilListInitDate.Width = 150;
            // 
            // clmMainCoilUsedLenth
            // 
            clmMainCoilUsedLenth.HeaderText = "Metraje Usado";
            clmMainCoilUsedLenth.Name = "clmMainCoilUsedLenth";
            clmMainCoilUsedLenth.ReadOnly = true;
            
            
            tbpStop.ResumeLayout(false);
            tbcCoilsInfo.ResumeLayout(false);
            tbpCoils.ResumeLayout(false);
            tbpCoils.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(dgvCoilsDetail)).EndInit();
            tbpMainCoils.ResumeLayout(false);
            grpbUsedMainCoil.ResumeLayout(false);
            grpbUsedMainCoil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(dgvMainCoilList)).EndInit();
        }

        //Method
        public static TabPage getStopLayout()
        {
            clsStopLayout tbpStopLayout = new clsStopLayout();
            return tbpStopLayout.tbpStop;
        }
        public static TabPage getStopLayoutByCuttingStop(int cuttingStopCodsec)
        {
            clsStopLayout tbpStopLayout = new clsStopLayout();
            clsCuttingStop objCuttingStop = new clsCuttingStop(cuttingStopCodsec);
            clsCuttingOrder objCuttingOrder = new clsCuttingOrder(objCuttingStop.fkCuttingOrder);
            List<clsUser> lstUsers = clsUser.getList();
            
            for (int j = 0; j < lstUsers.Count; j++)
            {
                tbpStopLayout.cmbDigitizer.Items.Add(lstUsers[j]);
                tbpStopLayout.cmbOperator.Items.Add(lstUsers[j]);
                tbpStopLayout.cmbSupervisor.Items.Add(lstUsers[j]);
            }

            for (int i = 0; i < objCuttingOrder.lstCuttingOrderDetail.Count; i++)
            {
                int pos = -1;
                bool flgHasCoil = false;

                for (int j = 0; j < objCuttingStop.lstCoil.Count; j++)
                {
                    if (objCuttingStop.lstCoil[j].cuttingPosition == i+1)
                    {
                        flgHasCoil = true;
                        pos = j;
                    }
                }

                if (flgHasCoil == false)
                {
                    tbpStopLayout.dgvCoilsDetail.Rows.Add();
                    tbpStopLayout.tbpStop.Tag = cuttingStopCodsec;
                    tbpStopLayout.dgvCoilsDetail.Rows[i].Cells[tbpStopLayout.clmCodsec.Index].Value = 0;
                    tbpStopLayout.dgvCoilsDetail.Rows[i].Cells[tbpStopLayout.clmPosition.Index].Value = i + 1;

                    if (objCuttingOrder.lstCuttingOrderDetail[i].fkSalesOrderDetail > 0)
                    {
                        clsSalesOrderDetail objSalesOrderDetail = new clsSalesOrderDetail(objCuttingOrder.lstCuttingOrderDetail[i].fkSalesOrderDetail);
                        clsSalesOrder objSalesOrder = new clsSalesOrder(objSalesOrderDetail.fkSalesOrder);
                        tbpStopLayout.dgvCoilsDetail.Rows[i].Cells[tbpStopLayout.clmSalesOrderDetailCodsec.Index].Value = objSalesOrderDetail.codsec;
                        tbpStopLayout.dgvCoilsDetail.Rows[i].Cells[tbpStopLayout.clmCuttingOrderDetailCodsec.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].codsec;
                        tbpStopLayout.dgvCoilsDetail.Rows[i].Cells[tbpStopLayout.clmCustomer.Index].Value = objSalesOrder.EntityName;
                        tbpStopLayout.dgvCoilsDetail.Rows[i].Cells[tbpStopLayout.clmSalesOrder.Index].Value = objSalesOrder.number;
                    }
                    else
                    {
                        tbpStopLayout.dgvCoilsDetail.Rows[i].Cells[tbpStopLayout.clmSalesOrderDetailCodsec.Index].Value = 0;
                        tbpStopLayout.dgvCoilsDetail.Rows[i].Cells[tbpStopLayout.clmCuttingOrderDetailCodsec.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].codsec;
                        tbpStopLayout.dgvCoilsDetail.Rows[i].Cells[tbpStopLayout.clmCustomer.Index].Value = "Producto en Stock";
                        tbpStopLayout.dgvCoilsDetail.Rows[i].Cells[tbpStopLayout.clmSalesOrder.Index].Value = "---";
                    }
                    tbpStopLayout.dgvCoilsDetail.Rows[i].Cells[tbpStopLayout.clmProductCode.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].product.code;
                    tbpStopLayout.dgvCoilsDetail.Rows[i].Cells[tbpStopLayout.clmWidth.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].width;
                    tbpStopLayout.dgvCoilsDetail.Rows[i].Cells[tbpStopLayout.clmLength.Index].Value = 0;
                    tbpStopLayout.dgvCoilsDetail.Rows[i].Cells[tbpStopLayout.clmWeigth.Index].Value = 0;
                }
                else
                {
                    tbpStopLayout.dgvCoilsDetail.Rows.Add();
                    tbpStopLayout.tbpStop.Tag = cuttingStopCodsec;
                    tbpStopLayout.dgvCoilsDetail.Rows[i].Cells[tbpStopLayout.clmCodsec.Index].Value = objCuttingStop.lstCoil[pos].codsec;
                    tbpStopLayout.dgvCoilsDetail.Rows[i].Cells[tbpStopLayout.clmPosition.Index].Value = objCuttingStop.lstCoil[pos].cuttingPosition;

                    if (objCuttingOrder.lstCuttingOrderDetail[i].fkSalesOrderDetail > 0)
                    {
                        clsSalesOrderDetail objSalesOrderDetail = new clsSalesOrderDetail(objCuttingOrder.lstCuttingOrderDetail[i].fkSalesOrderDetail);
                        clsSalesOrder objSalesOrder = new clsSalesOrder(objSalesOrderDetail.fkSalesOrder);
                        tbpStopLayout.dgvCoilsDetail.Rows[i].Cells[tbpStopLayout.clmCuttingOrderDetailCodsec.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].codsec;
                        tbpStopLayout.dgvCoilsDetail.Rows[i].Cells[tbpStopLayout.clmSalesOrderDetailCodsec.Index].Value = objSalesOrderDetail.codsec;
                        tbpStopLayout.dgvCoilsDetail.Rows[i].Cells[tbpStopLayout.clmCustomer.Index].Value = objSalesOrder.EntityName;
                        tbpStopLayout.dgvCoilsDetail.Rows[i].Cells[tbpStopLayout.clmSalesOrder.Index].Value = objSalesOrder.number;
                    }
                    else
                    {
                        tbpStopLayout.dgvCoilsDetail.Rows[i].Cells[tbpStopLayout.clmSalesOrderDetailCodsec.Index].Value = 0;
                        tbpStopLayout.dgvCoilsDetail.Rows[i].Cells[tbpStopLayout.clmCuttingOrderDetailCodsec.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].codsec;
                        tbpStopLayout.dgvCoilsDetail.Rows[i].Cells[tbpStopLayout.clmCustomer.Index].Value = "Producto en Stock";
                        tbpStopLayout.dgvCoilsDetail.Rows[i].Cells[tbpStopLayout.clmSalesOrder.Index].Value = "---";
                    }

                    tbpStopLayout.dgvCoilsDetail.Rows[i].Cells[tbpStopLayout.clmProductCode.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].product.code;
                    tbpStopLayout.dgvCoilsDetail.Rows[i].Cells[tbpStopLayout.clmWidth.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].width;
                    tbpStopLayout.dgvCoilsDetail.Rows[i].Cells[tbpStopLayout.clmLength.Index].Value = objCuttingStop.lstCoil[pos].length;
                    tbpStopLayout.dgvCoilsDetail.Rows[i].Cells[tbpStopLayout.clmWeigth.Index].Value = objCuttingStop.lstCoil[pos].grossWeight;

                    for (int j = 0; j < tbpStopLayout.dgvCoilsDetail.ColumnCount; j++)
                        tbpStopLayout.dgvCoilsDetail.Rows[i].Cells[j].Style.BackColor = Color.LightGreen;
                }

                if (objCuttingOrder.lstCuttingStop[objCuttingStop.position-1].codsec == cuttingStopCodsec)
                {
                    for (int j = 0; j < objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstMainCoilByCuttingStop.Count; j++)
                    {
                        tbpStopLayout.dgvMainCoilList.Rows.Add();
                        tbpStopLayout.dgvMainCoilList.Rows[j].Cells[tbpStopLayout.clmMainCoilListCodsec.Index].Value = objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstMainCoilByCuttingStop[j].mainCoil.codsec;
                        tbpStopLayout.dgvMainCoilList.Rows[j].Cells[tbpStopLayout.clmMainCoilListFilm.Index].Value = (new clsBopp(objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstMainCoilByCuttingStop[j].mainCoil.fkBopp)).name;
                        tbpStopLayout.dgvMainCoilList.Rows[j].Cells[tbpStopLayout.clmMainCoilListCode.Index].Value = objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstMainCoilByCuttingStop[j].mainCoil.code;
                        tbpStopLayout.dgvMainCoilList.Rows[j].Cells[tbpStopLayout.clmMainCoilListBatch.Index].Value = objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstMainCoilByCuttingStop[j].mainCoil.lotNumber;
                        tbpStopLayout.dgvMainCoilList.Rows[j].Cells[tbpStopLayout.clmMainCoilListLabRating.Index].Value = objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstMainCoilByCuttingStop[j].mainCoil.labRating;
                        tbpStopLayout.dgvMainCoilList.Rows[j].Cells[tbpStopLayout.clmMainCoilListInitDate.Index].Value = objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstMainCoilByCuttingStop[j].mainCoil.initDate.ToString("dd/MM/yyyy HH:mm:ss");
                        tbpStopLayout.dgvMainCoilList.Rows[j].Cells[tbpStopLayout.clmMainCoilUsedLenth.Index].Value = Convert.ToString(Math.Round(objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstMainCoilByCuttingStop[j].length, 2));
                    }

                    if (objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].closed)
                    {
                        tbpStopLayout.btnCloseStop.Enabled = false;
                        tbpStopLayout.cmbSupervisor.Enabled = false;
                        tbpStopLayout.cmbOperator.Enabled = false;
                        tbpStopLayout.cmbDigitizer.Enabled = false;
                        tbpStopLayout.grpbUsedMainCoil.Enabled = false;
                        tbpStopLayout.dgvCoilsDetail.Enabled = false;
                    }
                }
            }

            
            return tbpStopLayout.tbpStop;
        }
    }
}
