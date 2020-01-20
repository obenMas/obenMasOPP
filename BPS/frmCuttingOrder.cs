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
    public partial class frmCuttingOrder : Form
    {
        public struct salesOrderDetailItems
        {
            private int sodi_codsec;
            private int sodi_fkSalesOrder;
            private string sodi_EntityName;
            private string sodi_number;
            private string sodi_productCode;
            private double sodi_weight;
            private double sodi_totalCoils;
            private double sodi_pendingCoils;
            private int sodi_width;
            private string sodi_coreDiameter;
            private int sodi_productCodsec;
            private int sodi_originalProductCodsec;
            private int sodi_index;
            private bool sodi_isEquivalentFilm;

            public int codsec { get { return sodi_codsec; } set { sodi_codsec = value; } }

            public int fkSalesOrder { get { return sodi_fkSalesOrder; } set { sodi_fkSalesOrder = value; } }

            public string entityName { get { return sodi_EntityName; } set { sodi_EntityName = value; } }

            public string number { get { return sodi_number; } set { sodi_number = value; } }

            public string productCode { get { return sodi_productCode; } set { sodi_productCode = value; } }

            public double weight { get { return sodi_weight; } set { sodi_weight = value; } }

            public double totalCoils { get { return sodi_totalCoils; } set { sodi_totalCoils = value; } }

            public double pendingCoils { get { return sodi_pendingCoils; } set { sodi_pendingCoils = value; } }

            public int width { get { return sodi_width; } set { sodi_width = value; } }

            public string coreDiameter { get { return sodi_coreDiameter; } set { sodi_coreDiameter = value; } }

            public int productCodsec { get { return sodi_productCodsec; } set { sodi_productCodsec = value; } }

            public int originalProductCodsec { get { return sodi_originalProductCodsec; } set { sodi_originalProductCodsec = value; } }

            public int index { get { return sodi_index; } set { sodi_index = value; } }

            public bool isEquivalentFilm { get { return sodi_isEquivalentFilm; } set { sodi_isEquivalentFilm = value; } }

        }

        clsBopp objBopp = new clsBopp();
        List<clsMachine> lstMachine = clsMachine.getCutterMachineList();
        List<clsCore> lstCore = clsCore.getList();
        List<clsDiameter> lstDiameter = clsDiameter.getList();
        List<clsSalesOrderDetail> lstSalesOrderDetail = new List<clsSalesOrderDetail>();
        List<clsSalesOrderDetail> lstEquivalentSalesOrderDetail = new List<clsSalesOrderDetail>();
        public int selectedProductCodsec = 0;
        clsProduct objSelectedProduct = new clsProduct();
        List<clsCuttingOrder> lstCuttingOrders = new List<clsCuttingOrder>(); 
        List<GroupBox> lstGroupBoxResume = new List<GroupBox>();
        double programmedWeigth = 0;
        int selectedCuttingOrderRow = -1;
        clsProduct objProduct = new clsProduct();
        List<salesOrderDetailItems> lstSalesOrderDetailItems = new List<salesOrderDetailItems>();


        public frmCuttingOrder()
        {
            InitializeComponent();
        }
        public void fillFilmList()
        {
            dgvBopp.Rows.Clear();

            List<clsBopp> lstBopp = new List<clsBopp>();
            List<clsFilter> lstFilter = new List<clsFilter>();

            if (txtBoppCode.Text == "")
                lstBopp = clsBopp.getSimplifiedListWithQuantities();
            else
            {
                if (txtBoppCode.Text != "")
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "bopp_code";
                    lstFilter[lstFilter.Count - 1].operation = "startsWith";
                    lstFilter[lstFilter.Count - 1].value = txtBoppCode.Text;
                    lstFilter[lstFilter.Count - 1].dataType = "varchar";
                }
                lstBopp = clsBopp.getSimplifiedListWithQuantitiesByFilter(lstFilter);
            }

            for (int i = 0; i < lstBopp.Count; i++)
            {
                dgvBopp.Rows.Add();
                dgvBopp.Rows[i].Cells[clmCodsec.Index].Value = lstBopp[i].codsec.ToString();
                dgvBopp.Rows[i].Cells[clmCode.Index].Value = lstBopp[i].code.Replace("-", "");
                dgvBopp.Rows[i].Cells[clmName.Index].Value = lstBopp[i].name;
                dgvBopp.Rows[i].Cells[clmTotalWeightFilms.Index].Value = Convert.ToString(Math.Round( lstBopp[i].salesOrderQuantity,2));
                dgvBopp.Rows[i].Cells[clmMainCoilQuantity.Index].Value = Convert.ToString(Math.Round(lstBopp[i].mainCoilQuantity, 2));
            }
        }
        private void generateResume()
        {
            lstCuttingOrders = clsCuttingOrder.getActiveListByBoppCodsec(objBopp.codsec);
            lstGroupBoxResume.Clear();

            dgvCuttingOrder.Rows.Clear();
            //grpbCuttingOrderDetail.Controls.Clear();
            grpbCombination.Controls.Clear();

            for (int i = 0; i < lstCuttingOrders.Count; i++)
            {
                dgvCuttingOrder.Rows.Add();
                dgvCuttingOrder.Rows[i].Cells[clmCodsec.Index].Value = lstCuttingOrders[i].codsec;
                dgvCuttingOrder.Rows[i].Cells[clmMachineName.Index].Value = lstCuttingOrders[i].machineName;
                dgvCuttingOrder.Rows[i].Cells[clmFilmName.Index].Value = new clsBopp(lstCuttingOrders[i].fkBopp).code.Replace("-", "");
                dgvCuttingOrder.Rows[i].Cells[clmOrderNumber.Index].Value = lstCuttingOrders[i].number;
                dgvCuttingOrder.Rows[i].Cells[clmPositions.Index].Value = " " + lstCuttingOrders[i].positions.ToString() + " [ ";
                for (int j = 0; j < lstCuttingOrders[i].lstCuttingOrderDetail.Count; j++)
                {
                    dgvCuttingOrder.Rows[i].Cells[clmPositions.Index].Value += lstCuttingOrders[i].lstCuttingOrderDetail[j].width.ToString();
                    if (j < lstCuttingOrders[i].lstCuttingOrderDetail.Count - 1)
                        dgvCuttingOrder.Rows[i].Cells[clmPositions.Index].Value += " + ";
                }
                dgvCuttingOrder.Rows[i].Cells[clmPositions.Index].Value += " ]";
                dgvCuttingOrder.Rows[i].Cells[clmRepetitions.Index].Value = lstCuttingOrders[i].repetitions.ToString();
                dgvCuttingOrder.Rows[i].Cells[clmProgrammedWeigth.Index].Value = lstCuttingOrders[i].programmedWeight.ToString();
                dgvCuttingOrder.Rows[i].Cells[clmCreatedDate.Index].Value = lstCuttingOrders[i].createdDate.ToShortDateString();
                if (lstCuttingOrders[i].fkStatus == 25)
                {
                    for (int j = 0; j < dgvCuttingOrder.ColumnCount; j++)
                        dgvCuttingOrder.Rows[i].Cells[j].Style.BackColor = Color.Orange;

                    dgvCuttingOrder.Rows[i].Cells[clmStatus.Index].Value = global::BPS.Properties.Resources.play_sharp;
                }
                else if (lstCuttingOrders[i].fkStatus == 24)
                {
                    dgvCuttingOrder.Rows[i].Cells[clmStatus.Index].Value = global::BPS.Properties.Resources.calendar_2;
                }
                else if (lstCuttingOrders[i].fkStatus == 31)
                {
                    dgvCuttingOrder.Rows[i].Cells[clmStatus.Index].Value = global::BPS.Properties.Resources.pause_sharp;
                }
                else if (lstCuttingOrders[i].fkStatus == 23)
                {
                    dgvCuttingOrder.Rows[i].Cells[clmStatus.Index].Value = global::BPS.Properties.Resources.clipboard_text;
                }
            }
        }
        public void loadResumeLayout(int cuttingOrderCodsec, int rowIndex)
        {
            clsMachine objMachine = new clsMachine();
            clsCuttingOrder objCuttingOrder = new clsCuttingOrder(cuttingOrderCodsec);
            List<Label> lstLblCoils = new List<Label>();
            List<CheckBox> lstChkSingleFace = new List<CheckBox>();
            objMachine.load(objCuttingOrder.fkMachine, "Cutter");
            int relativePosition = 16;
            int wasteSize = objMachine.Cutter.utilWidth;
            double usedWidth = 0;

            lblCutterName.Text = objCuttingOrder.machineName;
            lblFilmNameInDetail.Text = "";
            lblStopsNumber.Text = objCuttingOrder.repetitions.ToString();
            nudStopsNumber.Value = objCuttingOrder.repetitions;
            lblCoilNumber.Text = objCuttingOrder.positions.ToString();

            for (int i = 0; i < objCuttingOrder.lstCuttingOrderDetail.Count; i++)
                wasteSize -= Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width);

            lblWaste1.BackColor = System.Drawing.Color.DimGray;
            lblWaste1.Size = new System.Drawing.Size(Convert.ToInt32(clsCuttingOrderResume.getProportinalWidth(objMachine.Cutter.utilWidth, wasteSize, 1020) / 2), 66);
            lblWaste1.Location = new System.Drawing.Point(relativePosition, 21);

            grpbCombination.Controls.Clear();

            grpbCombination.Text = "Orden de corte #" + objCuttingOrder.number.ToString();
            grpbCombination.Controls.Add(lblWaste1);

            relativePosition += Convert.ToInt32(clsCuttingOrderResume.getProportinalWidth(objMachine.Cutter.utilWidth, wasteSize, 1020) / 2);

            for (int i = 0; i < objCuttingOrder.lstCuttingOrderDetail.Count; i++)
            {
                lstLblCoils.Add(new Label());
                lstLblCoils[i].BackColor = clsGlobal.getColorByPosition(i, objCuttingOrder.lstCuttingOrderDetail.Count);
                lstLblCoils[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                lstLblCoils[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lstLblCoils[i].Location = new System.Drawing.Point(relativePosition, 21);
                lstLblCoils[i].Name = "lblCoil" + i.ToString();
                lstLblCoils[i].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(objMachine.Cutter.utilWidth, Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width), 1020), 66);
                lstLblCoils[i].TabIndex = 0;
                if (objCuttingOrder.lstCuttingOrderDetail[i].salesOrderNumber != "")
                    lstLblCoils[i].Text = "Orden  : " + objCuttingOrder.lstCuttingOrderDetail[i].salesOrderNumber + "\r\nCliente : " + clsCuttingOrderDetail.getSalesOrderDetailCustomer(objCuttingOrder.lstCuttingOrderDetail[i].codsec) + "\r\nAncho : " + Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width).ToString() + "mm\r\nCore     : " + objCuttingOrder.lstCuttingOrderDetail[i].product.CoreValue.ToString() + "\"";
                else
                    lstLblCoils[i].Text = "Orden  : ----\r\nCliente : STOCK\r\nAncho : " + Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width).ToString() + "mm\r\nCore     : " + objCuttingOrder.lstCuttingOrderDetail[i].product.CoreValue.ToString() + "\"";
                lstLblCoils[i].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                usedWidth += Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width);

                grpbCombination.Controls.Add(lstLblCoils[i]);

                lstChkSingleFace.Add(new CheckBox());
                lstChkSingleFace[i].AutoSize = true;
                lstChkSingleFace[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lstChkSingleFace[i].Location = new System.Drawing.Point(relativePosition, 92);
                lstChkSingleFace[i].Name = "chkSingleFace" + i.ToString();
                lstChkSingleFace[i].Size = new System.Drawing.Size(81, 17);
                lstChkSingleFace[i].TabIndex = 10;
                lstChkSingleFace[i].Text = "Single Face";
                lstChkSingleFace[i].Tag = objCuttingOrder.lstCuttingOrderDetail[i].codsec;
                lstChkSingleFace[i].UseVisualStyleBackColor = true;
                lstChkSingleFace[i].Checked = objCuttingOrder.lstCuttingOrderDetail[i].useSingleFace;

                grpbCombination.Controls.Add(lstChkSingleFace[i]);

                relativePosition += clsCuttingOrderResume.getProportinalWidth(objMachine.Cutter.utilWidth, Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width), 1020);
            }

            lblWaste2.BackColor = System.Drawing.Color.DimGray;
            lblWaste2.Size = new System.Drawing.Size(Convert.ToInt32(clsCuttingOrderResume.getProportinalWidth(objMachine.Cutter.utilWidth, wasteSize, 1020) / 2), 66);
            lblWaste2.Location = new System.Drawing.Point(relativePosition, 21);
            grpbCombination.Controls.Add(lblWaste2);
            lblNotes.Text = objCuttingOrder.notes;
            switch (objCuttingOrder.fkStatus)
            {
                case 23:
                    lblStatusImage.Image = global::BPS.Properties.Resources.paste;
                    lblStatus.Text = objCuttingOrder.statusName;
                    break;
                case 24:
                    lblStatusImage.Image = global::BPS.Properties.Resources.calendar;
                    lblStatus.Text = objCuttingOrder.statusName;
                    break;
                case 25:
                    lblStatusImage.Image = global::BPS.Properties.Resources.applications;
                    lblStatus.Text = objCuttingOrder.statusName;
                    break;
                case 26:
                    lblStatusImage.Image = global::BPS.Properties.Resources.check;
                    lblStatus.Text = objCuttingOrder.statusName;
                    break;
                case 27:
                    lblStatusImage.Image = global::BPS.Properties.Resources.cancel1;
                    lblStatus.Text = objCuttingOrder.statusName;
                    break;
                case 31:
                    lblStatusImage.Image = global::BPS.Properties.Resources.Pause_Hot;
                    lblStatus.Text = objCuttingOrder.statusName;
                    break;
                default:
                    break;
            }

            switch (objCuttingOrder.fkStatus)
            {
                case 23:
                    btnSave.BackgroundImage = global::BPS.Properties.Resources.calendar_2;
                    btnSave.Visible = true;
                    btnCancel.Visible = true;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    break;
                case 24:
                    btnSave.BackgroundImage = global::BPS.Properties.Resources.calendar_2;
                    btnSave.Visible = true;
                    btnCancel.Visible = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = true;
                    break;
                case 25:
                    if (objCuttingOrder.beingProcessed())
                    {
                        btnSave.BackgroundImage = global::BPS.Properties.Resources.accept;
                        btnSave.Visible = true;
                        btnCancel.Visible = true;
                        btnSave.Enabled = false;
                        btnCancel.Enabled = false;
                    }
                    break;
                case 31:
                    if (objCuttingOrder.beingProcessed())
                    {
                        btnSave.BackgroundImage = global::BPS.Properties.Resources.gear_16;
                        btnSave.Visible = true;
                        btnCancel.Visible = true;
                        btnSave.Enabled = false;
                        btnCancel.Enabled = true;
                    }
                    break;
            }

            lblUsedWidthInDetail.Text = usedWidth.ToString();
            lblWasteInDetail.Text = Convert.ToString(Math.Round(((objMachine.Cutter.utilWidth - usedWidth) * 100 / objMachine.Cutter.utilWidth), 2));
            lblFilmNameInDetail.Text = objCuttingOrder.boppCode.Replace("-", "");
            lblNotes.Text = objCuttingOrder.notes;

            //btnSave.Click += new System.EventHandler(save);
            btnSave.Tag = rowIndex;
            //btnCancel.Click += new System.EventHandler(delete);
            btnCancel.Tag = rowIndex;
            nudStopsNumber.Visible = false;
            //btnRefresh.Click += new System.EventHandler(changeStops);

            selectedCuttingOrderRow = rowIndex;

            for (int j = 0; j < grpbCombination.Controls.Count; j++)
            {
                if (object.ReferenceEquals(grpbCombination.Controls[j].GetType(), typeof(System.Windows.Forms.CheckBox)))
                    ((CheckBox)grpbCombination.Controls[j]).CheckedChanged += new System.EventHandler(changeSingleFaceStatus);
            }

            grpbCuttingOrderDetail.Visible = true;
        }

        private void fillSalesOrderList()
        {
            if (cmbDiameter.SelectedIndex >= 0 && cmbCore.SelectedIndex < 0)
                lstSalesOrderDetail = clsSalesOrderDetail.getCompleteListByBoppFilmAndDiameter(Convert.ToInt32(Convert.ToInt32(dgvBopp.SelectedRows[0].Cells[clmCodsec.Index].Value)), ((clsDiameter)cmbDiameter.SelectedItem).codsec);
            else if (cmbDiameter.SelectedIndex < 0 && cmbCore.SelectedIndex >= 0)
                lstSalesOrderDetail = clsSalesOrderDetail.getCompleteListByBoppFilmAndCore(Convert.ToInt32(Convert.ToInt32(dgvBopp.SelectedRows[0].Cells[clmCodsec.Index].Value)), ((clsCore)cmbCore.SelectedItem).codsec);
            else if (cmbDiameter.SelectedIndex >= 0 && cmbCore.SelectedIndex >= 0)
                lstSalesOrderDetail = clsSalesOrderDetail.getCompleteListByBoppFilmAndDiameterCore(Convert.ToInt32(Convert.ToInt32(dgvBopp.SelectedRows[0].Cells[clmCodsec.Index].Value)), ((clsDiameter)cmbDiameter.SelectedItem).codsec, ((clsCore)cmbCore.SelectedItem).codsec);
            else
                lstSalesOrderDetail = clsSalesOrderDetail.getCompleteListByBoppFilm(Convert.ToInt32(Convert.ToInt32(dgvBopp.SelectedRows[0].Cells[clmCodsec.Index].Value)));

            if (chkLoadEquivalentFilm.Checked == true)
                lstEquivalentSalesOrderDetail = clsSalesOrderDetail.getCompleteListByBoppEquivalentFilm(Convert.ToInt32(Convert.ToInt32(dgvBopp.SelectedRows[0].Cells[clmCodsec.Index].Value)));
            else
                lstEquivalentSalesOrderDetail = new List<clsSalesOrderDetail>();

            bool inList = false;

            dgvSalesOrderVisibility.Rows.Clear();
            lstSalesOrderDetailItems.Clear();

            for (int i = 0; i < lstSalesOrderDetail.Count; i++)
            {
                if (lstSalesOrderDetail[i].quantity > 0)
                {
                    //SALES ORDER LIST 
                    clsSalesOrder objSalesOrder = new clsSalesOrder();
                    objSalesOrder.loadSimplifiedWithoutDetail(lstSalesOrderDetail[i].fkSalesOrder);

                    inList = false;
                    int pos = -1;

                    for (int j = 0; j < dgvSalesOrderVisibility.Rows.Count; j++)
                    {
                        if (dgvSalesOrderVisibility.Rows[j].Cells[clmSONumber.Index].Value.ToString() == objSalesOrder.number)
                        {
                            inList = true;
                            pos = j;
                        }
                    }

                    if (inList == false)
                    {
                        dgvSalesOrderVisibility.Rows.Add();

                        dgvSalesOrderVisibility.Rows[dgvSalesOrderVisibility.Rows.Count - 1].Cells[clmSOCodsec.Index].Value = objSalesOrder.codsec;
                        dgvSalesOrderVisibility.Rows[dgvSalesOrderVisibility.Rows.Count - 1].Cells[clmSOCustomer.Index].Value = objSalesOrder.EntityName;
                        dgvSalesOrderVisibility.Rows[dgvSalesOrderVisibility.Rows.Count - 1].Cells[clmSONumber.Index].Value = objSalesOrder.number;
                        dgvSalesOrderVisibility.Rows[dgvSalesOrderVisibility.Rows.Count - 1].Cells[clmSOVisible.Index].Value = global::BPS.Properties.Resources.clear;
                        dgvSalesOrderVisibility.Rows[dgvSalesOrderVisibility.Rows.Count - 1].Cells[clmSOFlagVisible.Index].Value = 0;

                        pos = dgvSalesOrderVisibility.Rows.Count - 1;
                    }

                    if (clsSalesOrderDetail.getPendingCoilBySalesOrderDetailObj(lstSalesOrderDetail[i]) > 0)
                    {
                        dgvSalesOrderVisibility.Rows[pos].Cells[clmSOVisible.Index].Value = global::BPS.Properties.Resources.eye;
                        dgvSalesOrderVisibility.Rows[pos].Cells[clmSOFlagVisible.Index].Value = 1;
                    }

                    //SALES ORDER DETAIL LIST


                    salesOrderDetailItems objSalesOrderDetailItems = new salesOrderDetailItems();

                    objSalesOrderDetailItems.codsec = lstSalesOrderDetail[i].codsec;
                    objSalesOrderDetailItems.fkSalesOrder = objSalesOrder.codsec;
                    objSalesOrderDetailItems.entityName = objSalesOrder.EntityName;
                    objSalesOrderDetailItems.number = objSalesOrder.number;
                    objSalesOrderDetailItems.productCode = lstSalesOrderDetail[i].product.code.Replace("-", "");
                    objSalesOrderDetailItems.weight = Math.Round(lstSalesOrderDetail[i].quantity, 2);
                    //objSalesOrderDetailItems.totalCoils = Convert.ToInt32(clsParameters.getCoilsNumberByWidthAndWeigth(lstSalesOrderDetail[i].product.fkBopp, lstSalesOrderDetail[i].product.fkDiameter, lstSalesOrderDetail[i].product.fkCore, lstSalesOrderDetail[i].product.width, (lstSalesOrderDetail[i].quantity)));
                    objSalesOrderDetailItems.totalCoils = lstSalesOrderDetail[i].coilsToCut;
                    objSalesOrderDetailItems.pendingCoils = clsSalesOrderDetail.getPendingCoilBySalesOrderDetailObj(lstSalesOrderDetail[i]);
                    objSalesOrderDetailItems.width = Convert.ToInt32(lstSalesOrderDetail[i].product.width);
                    objSalesOrderDetailItems.coreDiameter = lstSalesOrderDetail[i].product.DiameterAbbreviation + lstSalesOrderDetail[i].product.CoreValue.ToString();
                    objSalesOrderDetailItems.productCodsec = lstSalesOrderDetail[i].product.codsec;
                    objSalesOrderDetailItems.originalProductCodsec = lstSalesOrderDetail[i].product.codsec;
                    objSalesOrderDetailItems.isEquivalentFilm = false;
                    objSalesOrderDetailItems.index = lstSalesOrderDetailItems.Count;

                    lstSalesOrderDetailItems.Add(objSalesOrderDetailItems);
                }

            }
            if (chkLoadEquivalentFilm.Checked == true)
            {
                for (int i = 0; i < lstEquivalentSalesOrderDetail.Count; i++)
                {
                    if (lstEquivalentSalesOrderDetail[i].quantity > 0)
                    {
                        //SALES ORDER LIST 
                        clsSalesOrder objSalesOrder = new clsSalesOrder();
                        objSalesOrder.loadSimplifiedWithoutDetail(lstEquivalentSalesOrderDetail[i].fkSalesOrder);

                        inList = false;
                        int pos = -1;

                        for (int j = 0; j < dgvSalesOrderVisibility.Rows.Count; j++)
                        {
                            if (dgvSalesOrderVisibility.Rows[j].Cells[clmSONumber.Index].Value.ToString() == objSalesOrder.number)
                            {
                                inList = true;
                                pos = j;
                            }
                        }

                        if (inList == false)
                        {
                            dgvSalesOrderVisibility.Rows.Add();

                            dgvSalesOrderVisibility.Rows[dgvSalesOrderVisibility.Rows.Count - 1].Cells[clmSOCodsec.Index].Value = objSalesOrder.codsec;
                            dgvSalesOrderVisibility.Rows[dgvSalesOrderVisibility.Rows.Count - 1].Cells[clmSOCustomer.Index].Value = objSalesOrder.EntityName;
                            dgvSalesOrderVisibility.Rows[dgvSalesOrderVisibility.Rows.Count - 1].Cells[clmSONumber.Index].Value = objSalesOrder.number;
                            dgvSalesOrderVisibility.Rows[dgvSalesOrderVisibility.Rows.Count - 1].Cells[clmSOVisible.Index].Value = global::BPS.Properties.Resources.clear;
                            dgvSalesOrderVisibility.Rows[dgvSalesOrderVisibility.Rows.Count - 1].Cells[clmSOFlagVisible.Index].Value = 0;

                            pos = dgvSalesOrderVisibility.Rows.Count - 1;
                        }

                        if (clsSalesOrderDetail.getPendingCoilBySalesOrderDetailObj(lstEquivalentSalesOrderDetail[i]) > 0)
                        {
                            dgvSalesOrderVisibility.Rows[pos].Cells[clmSOVisible.Index].Value = global::BPS.Properties.Resources.eye;
                            dgvSalesOrderVisibility.Rows[pos].Cells[clmSOFlagVisible.Index].Value = 1;
                        }

                        //SALES ORDER DETAIL LIST


                        salesOrderDetailItems objSalesOrderDetailItems = new salesOrderDetailItems();

                        objSalesOrderDetailItems.codsec = lstEquivalentSalesOrderDetail[i].codsec;
                        objSalesOrderDetailItems.entityName = objSalesOrder.EntityName;
                        objSalesOrderDetailItems.number = objSalesOrder.number;
                        objSalesOrderDetailItems.productCode = lstEquivalentSalesOrderDetail[i].product.code.Replace("-", "");
                        objSalesOrderDetailItems.weight = Math.Round(lstEquivalentSalesOrderDetail[i].quantity, 2);
                        //objSalesOrderDetailItems.totalCoils = Convert.ToInt32(clsParameters.getCoilsNumberByWidthAndWeigth(lstEquivalentSalesOrderDetail[i].product.fkBopp, lstEquivalentSalesOrderDetail[i].product.fkDiameter, lstEquivalentSalesOrderDetail[i].product.fkCore, lstEquivalentSalesOrderDetail[i].product.width, (lstEquivalentSalesOrderDetail[i].quantity)));
                        objSalesOrderDetailItems.totalCoils = lstEquivalentSalesOrderDetail[i].coilsToCut;
                        objSalesOrderDetailItems.pendingCoils = clsSalesOrderDetail.getPendingCoilBySalesOrderDetailObj(lstEquivalentSalesOrderDetail[i]);
                        objSalesOrderDetailItems.width = Convert.ToInt32(lstEquivalentSalesOrderDetail[i].product.width);
                        objSalesOrderDetailItems.coreDiameter = lstEquivalentSalesOrderDetail[i].product.DiameterAbbreviation + lstEquivalentSalesOrderDetail[i].product.CoreValue.ToString();
                        objSalesOrderDetailItems.productCodsec = lstEquivalentSalesOrderDetail[i].product.codsec;
                        objSalesOrderDetailItems.originalProductCodsec = lstEquivalentSalesOrderDetail[i].product.codsec;
                        objSalesOrderDetailItems.isEquivalentFilm = true;
                        objSalesOrderDetailItems.index = lstSalesOrderDetailItems.Count;

                        lstSalesOrderDetailItems.Add(objSalesOrderDetailItems);
                    }
                }
            }

            dgvSalesOrderVisibility.Sort(clmSONumber, ListSortDirection.Ascending);

            fillDatagrid();

            lblUsedWidth.Text = "0";
            lblUsedArms.Text = "0";
            lblUnusedWidth.Text = lblUtilWidth.Text;
            lblViableCombination.Text = "NO";
            lblViableCombination.ForeColor = Color.Red;
            nudStops.Value = 1;
            nudWasteAllowed.Value = 10;
            lblWaste.Text = "0";
        }
        private void fillDatagrid()
        {
            dgvSalesOrderDetail.Rows.Clear();
            
            for (int i = 0; i < lstSalesOrderDetailItems.Count; i++)
            {
                bool flgVisible = false;
                
                for (int j = 0; j < dgvSalesOrderVisibility.Rows.Count; j++)
                {
                    if (dgvSalesOrderVisibility.Rows[j].Cells[clmSONumber.Index].Value.ToString() == lstSalesOrderDetailItems[i].number)
                    {
                        flgVisible = Convert.ToBoolean(dgvSalesOrderVisibility.Rows[j].Cells[clmSOFlagVisible.Index].Value);
                        break;
                    }
                }

                if (flgVisible && (lstSalesOrderDetailItems[i].pendingCoils > 0 || (lstSalesOrderDetailItems[i].pendingCoils <= 0 && flgVisible == true)))
                {
                    dgvSalesOrderDetail.Rows.Add();

                    int j = dgvSalesOrderDetail.Rows.Count - 1;

                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCodsec.Index].Value = lstSalesOrderDetailItems[i].codsec;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCustomer.Index].Value = lstSalesOrderDetailItems[i].entityName;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderNumber.Index].Value = lstSalesOrderDetailItems[i].number;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderProduct.Index].Value = lstSalesOrderDetailItems[i].productCode;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderChangeProduct.Index].Value = global::BPS.Properties.Resources.arrow_refresh;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderWeigth.Index].Value = lstSalesOrderDetailItems[i].weight;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderTotalOrderCoils.Index].Value = lstSalesOrderDetailItems[i].totalCoils;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCoilsQuantity.Index].Value = lstSalesOrderDetailItems[i].pendingCoils;

                    if (lstSalesOrderDetailItems[i].pendingCoils < 0)
                        dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCoilsQuantity.Index].Value = 0;

                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderWidth.Index].Value = lstSalesOrderDetailItems[i].width;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCoreDiameter.Index].Value = lstSalesOrderDetailItems[i].coreDiameter;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCoilsToCut.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderProgrammedWeigth.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderSlopeWeigth.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderTotalSlope.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderProductCodsec.Index].Value = lstSalesOrderDetailItems[i].productCodsec;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderOriginalProductCodsec.Index].Value = lstSalesOrderDetailItems[i].originalProductCodsec;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderIsEquivalentFilm.Index].Value = false;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderDetailIndex.Index].Value = i;

                    if (lstSalesOrderDetailItems[i].isEquivalentFilm)
                    {
                        for (int k = 0; k < dgvSalesOrderDetail.ColumnCount; k++)
                            dgvSalesOrderDetail.Rows[j].Cells[k].Style.BackColor = Color.LightGreen;
                    }
                }
            } 
        }
        private void calculateCombination()
        {
            clmProgrammedWeigth.Visible = true;
            int numCoils = 0;
            double usedWidth = 0;
            int numArms = 0;
            double wastePercentage = 0;
            programmedWeigth = 0;
            
            bool flgMultiple = false, flgWidthOverload = false, flgArmsOverload = false, flgWaste = false;
            for (int i = 0; i < dgvSalesOrderDetail.Rows.Count; i++)
            {                
                usedWidth += (Convert.ToDouble(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderWidth.Index].Value) * (Convert.ToDouble(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderTotalCoils.Index].Value) / Convert.ToInt32(nudStops.Value)));
                numCoils += Convert.ToInt32(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderTotalCoils.Index].Value);

                if (dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderProgrammedWeigth.Index].Value.ToString() != "NaN" && dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderProgrammedWeigth.Index].Value.ToString() != "NeuN")
                    programmedWeigth += Convert.ToDouble(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderProgrammedWeigth.Index].Value);

                if (Convert.ToDouble(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderTotalCoils.Index].Value) != 0 && Convert.ToDouble(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderTotalCoils.Index].Value) % Convert.ToDouble(nudStops.Value) != 0)
                {
                    dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderTotalCoils.Index].Style.ForeColor = Color.Red;
                    flgMultiple = true;
                }
                else
                    dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderTotalCoils.Index].Style.ForeColor = SystemColors.ControlText;
            }
            for (int i = 0; i < dgvStock.Rows.Count; i++)
            {
                if (dgvStock.Rows[i].Cells[clmStockCoilsToCut.Index].Value != null && dgvStock.Rows[i].Cells[clmStockCoilsToCut.Index].Value.ToString() != "")
                {
                    usedWidth += (Convert.ToDouble(dgvStock.Rows[i].Cells[clmStockWidth.Index].Value) * (Convert.ToDouble(dgvStock.Rows[i].Cells[clmStockTotalCoils.Index].Value) / Convert.ToInt32(nudStops.Value)));
                    numCoils += Convert.ToInt32(dgvStock.Rows[i].Cells[clmStockCoilsToCut.Index].Value);
                    if (dgvStock.Rows[i].Cells[clmStockProgrammedWeigth.Index].Value.ToString() != "NaN" && dgvStock.Rows[i].Cells[clmStockProgrammedWeigth.Index].Value.ToString() != "NeuN")
                        programmedWeigth += Convert.ToDouble(dgvStock.Rows[i].Cells[clmStockProgrammedWeigth.Index].Value);
                    if (Convert.ToDouble(dgvStock.Rows[i].Cells[clmStockTotalCoils.Index].Value) != 0 && Convert.ToDouble(dgvStock.Rows[i].Cells[clmStockTotalCoils.Index].Value) % Convert.ToDouble(nudStops.Value) != 0)
                    {
                        dgvStock.Rows[i].Cells[clmStockCoilsToCut.Index].Style.ForeColor = Color.Red;
                        flgMultiple = true;
                    }
                    else
                        dgvStock.Rows[i].Cells[clmStockCoilsToCut.Index].Style.ForeColor = SystemColors.ControlText;
                }
            }
            numArms = Convert.ToInt32(Math.Round(numCoils / nudStops.Value, 0));
            if (txtUtilWidth.Text != "")
                wastePercentage = Math.Round(((Convert.ToDouble(txtUtilWidth.Text) - usedWidth) * 100) / Convert.ToDouble(txtUtilWidth.Text), 2);

            
            lblUsedWidth.Text = Convert.ToString(Math.Round(usedWidth, 2));
            lblUnusedWidth.Text = Convert.ToString(Math.Round((Convert.ToDouble(txtUtilWidth.Text) - Convert.ToDouble(lblUsedWidth.Text)), 2));
            lblUsedArms.Text = Convert.ToString(numArms);
            lblWaste.Text = wastePercentage.ToString();


            if (usedWidth > Convert.ToDouble(txtUtilWidth.Text))
            {
                flgWidthOverload = true;
                lblUsedWidth.ForeColor = Color.Red;
                lblWaste.ForeColor = SystemColors.ControlText;   
            }
            else if (wastePercentage > Convert.ToDouble(nudWasteAllowed.Value))
            {
                flgWaste = true;
                lblWaste.ForeColor = Color.Red;
                lblUsedWidth.ForeColor = SystemColors.ControlText;
            }
            else
            {
                lblUsedWidth.ForeColor = SystemColors.ControlText;
                lblWaste.ForeColor = SystemColors.ControlText;                
            }

            if (numArms > Convert.ToInt32(lblArms.Text))
            {
                flgArmsOverload = true;
                lblUsedArms.ForeColor = Color.Red;
            }
            else
                lblUsedArms.ForeColor = SystemColors.ControlText;

            lblMessage.Text = "";
            if (flgWidthOverload)
                lblMessage.Text += "* Se ha superado el ancho máximo definido por la cortadora.\n";
            if (flgWaste)
                lblMessage.Text += "* El porcentaje de desperdicios es mayor al permitido.\n";
            if (flgArmsOverload)
                lblMessage.Text += "* Se ha superado el número máximo de brazos de la cortadora.\n";
            if (flgMultiple)
                lblMessage.Text += "* El número de bobinas debe ser un número múltiplo con respecto al numero de paradas programadas.\n";

            if (!flgArmsOverload && !flgMultiple && !flgWaste && !flgWidthOverload)
            {
                lblViableCombination.Text = "SI";
                lblViableCombination.ForeColor = Color.Green;
            }
            else
            {
                lblViableCombination.Text = "NO";
                lblViableCombination.ForeColor = Color.Red;
            }

        }
        private void changeSingleFaceStatus(object sender, EventArgs e)
        {
            CheckBox chkSingleFace = (CheckBox)sender;
            clsCuttingOrderDetail objCuttingOrderDetail = new clsCuttingOrderDetail();
            objCuttingOrderDetail.load(Convert.ToInt32(chkSingleFace.Tag));
            objCuttingOrderDetail.useSingleFace = !objCuttingOrderDetail.useSingleFace;
            objCuttingOrderDetail.save();            
        }
        private void frmCuttingOrder_Load(object sender, EventArgs e)
        {
            fillFilmList();

            for (int i = 0; i < lstMachine.Count; i++)
                cmbCutter.Items.Add(lstMachine[i]);

            for (int i = 0; i < lstCore.Count; i++)
                cmbCore.Items.Add(lstCore[i]);

            for (int i = 0; i < lstDiameter.Count; i++)
                cmbDiameter.Items.Add(lstDiameter[i]);
        }

        private void dgvBopp_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                objBopp.load(Convert.ToInt32(dgvBopp.Rows[e.RowIndex].Cells[clmCodsec.Index].Value));
                lblFilmName.Text = "[" + objBopp.code + "] " + objBopp.name;

                fillSalesOrderList();

                generateResume();

                tbcCuttingOrder.SelectedIndex = 1;
                cmbCutter.Focus();
                txtNotes.Text = "";
                chkLoadEquivalentFilm.Checked = false;
                chkAllowEquivalentFilm.Checked = false;
            }
        }

        private void dgvSalesOrderDetail_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 10:
                    if (cmbCutter.SelectedIndex >= 0)
                    {                        
                        if (clsGlobal.isNumeric(dgvSalesOrderDetail.CurrentCell.EditedFormattedValue.ToString()) == false && dgvSalesOrderDetail.CurrentCell.EditedFormattedValue.ToString() != "")
                        {
                            MessageBox.Show("El valor debe ser Numérico");
                            dgvSalesOrderDetail.CancelEdit();
                        }
                        else
                        {
                            dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderTotalCoils.Index].Value = Math.Round(Convert.ToDouble(dgvSalesOrderDetail.CurrentCell.EditedFormattedValue) * Convert.ToDouble(nudStops.Value), 0);
                            dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderProgrammedWeigth.Index].Value = Math.Round(((Convert.ToDouble(dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderWeigth.Index].Value) / Convert.ToDouble(dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderTotalOrderCoils.Index].Value)) * Convert.ToDouble(dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderTotalCoils.Index].Value)), 2);
                            dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderSlopeWeigth.Index].Value = Math.Round(Convert.ToDouble(dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderTotalSlope.Index].Value) - Convert.ToDouble(dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderProgrammedWeigth.Index].Value), 2);

                            double extra = Convert.ToDouble(dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderSlopeWeigth.Index].Value) * 100 / Convert.ToDouble(dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderWeigth.Index].Value);


                            if (-10 < extra && extra < 10)
                                dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderSlopeWeigth.Index].Style.ForeColor = Color.Green;
                            else if (Convert.ToDouble(dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderSlopeWeigth.Index].Value) < 0)
                                dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderSlopeWeigth.Index].Style.ForeColor = Color.Red;
                            else
                                dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderSlopeWeigth.Index].Style.ForeColor = SystemColors.ControlText;

                            if (Convert.ToInt32(dgvSalesOrderDetail.CurrentCell.EditedFormattedValue) > 0)
                            {
                                for (int i = 0; i < dgvSalesOrderDetail.ColumnCount; i++)
                                    dgvSalesOrderDetail.Rows[e.RowIndex].Cells[i].Style.BackColor = Color.LightBlue;
                            }
                            else
                            {
                                for (int i = 0; i < dgvSalesOrderDetail.ColumnCount; i++)
                                {
                                    if (Convert.ToBoolean(dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderIsEquivalentFilm.Index].Value) == true)
                                        dgvSalesOrderDetail.Rows[e.RowIndex].Cells[i].Style.BackColor = Color.LightGreen;
                                    else
                                        dgvSalesOrderDetail.Rows[e.RowIndex].Cells[i].Style.BackColor = Color.White;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (dgvSalesOrderDetail.CurrentCell.EditedFormattedValue.ToString() != dgvSalesOrderDetail.CurrentCell.Value.ToString())
                            MessageBox.Show("Por favor, seleccione primero en que cortadora se realizará el corte.");
                        dgvSalesOrderDetail.CancelEdit();                        
                    }
                    break;
                    
            }
        }

        private void cmbCutter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCutter.SelectedIndex > -1)
            {
                lblArms.Text = ((clsMachine)cmbCutter.SelectedItem).Cutter.arms.ToString();
                lblUtilWidth.Text = ((clsMachine)cmbCutter.SelectedItem).Cutter.utilWidth.ToString();
                txtUtilWidth.Text = ((clsMachine)cmbCutter.SelectedItem).Cutter.utilWidth.ToString();
                lblUsedWidth.Text = "0";
                lblUsedArms.Text = "0";
                lblUnusedWidth.Text = lblUtilWidth.Text;
                lblViableCombination.Text = "NO";
                lblViableCombination.ForeColor = Color.Red;
            }
        }

        private void nudStops_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvSalesOrderDetail.Rows.Count; i++)
            {
                dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderTotalCoils.Index].Value = Math.Round(Convert.ToDouble(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderCoilsToCut.Index].Value) * Convert.ToDouble(nudStops.Value), 0);
                dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderProgrammedWeigth.Index].Value = Math.Round(((Convert.ToDouble(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderWeigth.Index].Value) / Convert.ToDouble(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderTotalOrderCoils.Index].Value)) * Convert.ToDouble(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderTotalCoils.Index].Value)), 2);
                dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderSlopeWeigth.Index].Value = Math.Round(Convert.ToDouble(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderTotalSlope.Index].Value) - Convert.ToDouble(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderProgrammedWeigth.Index].Value), 2);
                
                double extra = Convert.ToDouble(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderSlopeWeigth.Index].Value) * 100 / Convert.ToDouble(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderWeigth.Index].Value);
                
                if (-10 < extra && extra < 10)
                    dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderSlopeWeigth.Index].Style.ForeColor = Color.Green;
                else if (Convert.ToDouble(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderSlopeWeigth.Index].Value) < 0)
                    dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderSlopeWeigth.Index].Style.ForeColor = Color.Red;
                else
                    dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderSlopeWeigth.Index].Style.ForeColor = SystemColors.ControlText;
            }
            for (int i = 0; i < dgvStock.Rows.Count; i++)
            {
                if (dgvStock.Rows[i].Cells[clmStockCoilsToCut.Index].Value != null && dgvStock.Rows[i].Cells[clmStockCoilsToCut.Index].Value.ToString() != "")
                {
                    dgvStock.Rows[i].Cells[clmStockTotalCoils.Index].Value = Math.Round(Convert.ToDouble(dgvStock.Rows[i].Cells[clmStockCoilsToCut.Index].Value) * Convert.ToDouble(nudStops.Value), 0);
                    dgvStock.Rows[i].Cells[clmStockProgrammedWeigth.Index].Value = Math.Round(((Convert.ToDouble(dgvStock.Rows[i].Cells[clmStockWeigth.Index].Value) / Convert.ToDouble(dgvStock.Rows[i].Cells[clmStockCoilQuantity.Index].Value)) * Convert.ToDouble(dgvStock.Rows[i].Cells[clmStockTotalCoils.Index].Value)), 2);
                    dgvStock.Rows[i].Cells[clmStockSlopeWeigth.Index].Value = 0;
                }
            }
            calculateCombination();
        }

        private void dgvSalesOrderDetail_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 10:
                    if (cmbCutter.SelectedIndex >= 0)
                    {
                        calculateCombination();
                    }
                    break;
            }
        }

        private void nudWasteAllowed_ValueChanged(object sender, EventArgs e)
        {
            calculateCombination();
        }

        private void dgvStock_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == clmStockProductName.Index)
            {
                objSelectedProduct = new clsProduct();
                selectedProductCodsec = 0;
                //frmProductList winProductList = new frmProductList(this, objBopp.codsec);
                //winProductList.ShowDialog(this);
                frmProductListShort winProductList = new frmProductListShort(this, objBopp.codsec);
                winProductList.ShowDialog(this);

                if (selectedProductCodsec != 0)
                {
                    objSelectedProduct.load(selectedProductCodsec);
                    dgvStock.CurrentRow.Cells[clmStockProductCodsec.Index].Value = objSelectedProduct.codsec.ToString();
                    dgvStock.CurrentRow.Cells[clmStockProductName.Index].Value = objSelectedProduct.name;
                    dgvStock.CurrentRow.Cells[clmStockWidth.Index].Value = objSelectedProduct.width;
                    dgvStock.CurrentRow.Cells[clmStockDiameterCore.Index].Value = objSelectedProduct.DiameterAbbreviation + objSelectedProduct.CoreValue.ToString();
                    dgvStock.CurrentRow.Cells[clmStockWeigth.Index].Value = 0;
                    dgvStock.CurrentRow.Cells[clmStockCoilQuantity.Index].Value = 0;
                    dgvStock.CurrentRow.Cells[clmStockCoilsToCut.Index].Value = 0;
                    dgvStock.CurrentRow.Cells[clmStockTotalCoils.Index].Value = 0;
                    dgvStock.CurrentRow.Cells[clmStockProgrammedWeigth.Index].Value = 0;
                    dgvStock.CurrentRow.Cells[clmStockSlopeWeigth.Index].Value = 0;
                    dgvStock.CurrentRow.Cells[clmStockBoppCodsec.Index].Value = objSelectedProduct.Bopp.codsec;
                    dgvStock.CurrentRow.Cells[clmStockDiameterCodsec.Index].Value = objSelectedProduct.fkDiameter;
                    dgvStock.CurrentRow.Cells[clmStockCoreCodsec.Index].Value = objSelectedProduct.fkCore;
                }
            }
        }

        private void dgvStock_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 6:
                    if (cmbCutter.SelectedIndex >= 0)
                    {
                        if (clsGlobal.isNumeric(dgvStock.CurrentCell.EditedFormattedValue.ToString()) == false && dgvStock.CurrentCell.EditedFormattedValue.ToString() != "")
                        {
                            MessageBox.Show("El valor debe ser Numérico");
                            dgvStock.CancelEdit();
                        }
                        else
                        {
                            if (dgvStock.CurrentCell.EditedFormattedValue.ToString() != "")
                            {
                                dgvStock.Rows[e.RowIndex].Cells[clmStockCoilQuantity.Index].Value = Math.Round(Convert.ToDouble(dgvStock.CurrentCell.EditedFormattedValue) * Convert.ToDouble(nudStops.Value), 0);
                                dgvStock.Rows[e.RowIndex].Cells[clmStockTotalCoils.Index].Value = Math.Round(Convert.ToDouble(dgvStock.CurrentCell.EditedFormattedValue) * Convert.ToDouble(nudStops.Value), 0);
                                dgvStock.Rows[e.RowIndex].Cells[clmStockWeigth.Index].Value = clsParameters.getWeigthByCoilsNumberAndWidth(Convert.ToInt32(dgvStock.Rows[e.RowIndex].Cells[clmStockBoppCodsec.Index].Value), 0, Convert.ToInt32(dgvStock.Rows[e.RowIndex].Cells[clmStockDiameterCodsec.Index].Value), Convert.ToInt32(dgvStock.Rows[e.RowIndex].Cells[clmStockCoreCodsec.Index].Value), Convert.ToDouble(dgvStock.Rows[e.RowIndex].Cells[clmStockWidth.Index].Value), Convert.ToInt32(dgvStock.Rows[e.RowIndex].Cells[clmStockTotalCoils.Index].Value));
                                dgvStock.Rows[e.RowIndex].Cells[clmStockProgrammedWeigth.Index].Value = Math.Round(((Convert.ToDouble(dgvStock.Rows[e.RowIndex].Cells[clmStockWeigth.Index].Value) / Convert.ToDouble(dgvStock.Rows[e.RowIndex].Cells[clmStockCoilQuantity.Index].Value)) * Convert.ToDouble(dgvStock.Rows[e.RowIndex].Cells[clmStockTotalCoils.Index].Value)), 2);
                                dgvStock.Rows[e.RowIndex].Cells[clmStockSlopeWeigth.Index].Value = Math.Round(Convert.ToDouble(dgvStock.Rows[e.RowIndex].Cells[clmStockWeigth.Index].Value) - Convert.ToDouble(dgvStock.Rows[e.RowIndex].Cells[clmStockWeigth.Index].Value), 2);
                            }
                        }
                    }
                    else
                    {
                        if (dgvStock.CurrentCell.EditedFormattedValue.ToString() != dgvStock.CurrentCell.Value.ToString())
                            MessageBox.Show("Por favor, seleccione primero en que cortadora se realizará el corte.");
                        dgvStock.CancelEdit();
                    }
                    break;

            }
        }

        private void dgvStock_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 6:
                    if (cmbCutter.SelectedIndex >= 0)
                    {
                        calculateCombination();
                    }
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lblViableCombination.Text == "SI")
            {
                lstCuttingOrders.Add(new clsCuttingOrder());

                int pos = lstCuttingOrders.Count - 1;
                lstCuttingOrders[pos].fkMachine = ((clsMachine)cmbCutter.SelectedItem).codsec;
                lstCuttingOrders[pos].machineName = ((clsMachine)cmbCutter.SelectedItem).Cutter.name;
                lstCuttingOrders[pos].fkStatus = (clsStatus.getStatusByStatusGroupNameAndStatusName("Ordenes de corte", "Programada")).codsec;
                lstCuttingOrders[pos].statusName = (clsStatus.getStatusByStatusGroupNameAndStatusName("Ordenes de corte", "Programada")).name;
                lstCuttingOrders[pos].fkBopp = objBopp.codsec;
                lstCuttingOrders[pos].boppName = objBopp.name;
                lstCuttingOrders[pos].positions = Convert.ToInt32(lblUsedArms.Text);
                lstCuttingOrders[pos].repetitions = Convert.ToInt32( nudStops.Value);

                if (programmedWeigth.ToString() != "NaN" && programmedWeigth.ToString() != "NeuN")
                    lstCuttingOrders[pos].programmedWeight = programmedWeigth;
                else
                    lstCuttingOrders[pos].programmedWeight = 0;

                lstCuttingOrders[pos].programmedLength = 0;
                lstCuttingOrders[pos].createdDate = DateTime.Now;
                lstCuttingOrders[pos].modifiedDate = DateTime.Now;
                lstCuttingOrders[pos].createdBy = clsGlobal.LoggedUser.codsec;
                lstCuttingOrders[pos].modifiedBy = clsGlobal.LoggedUser.codsec;
                lstCuttingOrders[pos].notes = txtNotes.Text;
                lstCuttingOrders[pos].allowEquivalentFilm = chkAllowEquivalentFilm.Checked;

                int coilPosition = 0;
                for (int i = 0; i < dgvSalesOrderDetail.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderCoilsToCut.Index].Value) != 0)
                    {

                        for (int j = 0; j < Convert.ToInt32(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderCoilsToCut.Index].Value); j++)
                        {
                            coilPosition++;

                            clsSalesOrderDetail objSalesOrderDetail = new clsSalesOrderDetail(Convert.ToInt32(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderCodsec.Index].Value));

                            lstCuttingOrders[pos].lstCuttingOrderDetail.Add(new clsCuttingOrderDetail());
                            lstCuttingOrders[pos].lstCuttingOrderDetail[lstCuttingOrders[pos].lstCuttingOrderDetail.Count - 1].fkProduct = Convert.ToInt32(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderProductCodsec.Index].Value);
                            lstCuttingOrders[pos].lstCuttingOrderDetail[lstCuttingOrders[pos].lstCuttingOrderDetail.Count - 1].width = Convert.ToDouble(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderWidth.Index].Value);
                            lstCuttingOrders[pos].lstCuttingOrderDetail[lstCuttingOrders[pos].lstCuttingOrderDetail.Count - 1].ProductName = dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderProduct.Index].Value.ToString();
                            lstCuttingOrders[pos].lstCuttingOrderDetail[lstCuttingOrders[pos].lstCuttingOrderDetail.Count - 1].fkSalesOrderDetail = Convert.ToInt32(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderCodsec.Index].Value);
                            lstCuttingOrders[pos].lstCuttingOrderDetail[lstCuttingOrders[pos].lstCuttingOrderDetail.Count - 1].salesOrderNumber = dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderNumber.Index].Value.ToString();
                            lstCuttingOrders[pos].lstCuttingOrderDetail[lstCuttingOrders[pos].lstCuttingOrderDetail.Count - 1].position = coilPosition;
                            clsProduct objSelectedProduct = new clsProduct(Convert.ToInt32(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderProductCodsec.Index].Value));
                            lstCuttingOrders[pos].lstCuttingOrderDetail[lstCuttingOrders[pos].lstCuttingOrderDetail.Count - 1].programmedLength = clsParameters.getAproxLengthByWidthAndWeigth(objSelectedProduct.fkBopp, objSelectedProduct.fkDiameter, objSelectedProduct.fkCore);
                            lstCuttingOrders[pos].lstCuttingOrderDetail[lstCuttingOrders[pos].lstCuttingOrderDetail.Count - 1].programmedWeight = Convert.ToDouble(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderProgrammedWeigth.Index].Value) / Convert.ToInt32(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderTotalCoils.Index].Value);
                            if (lstCuttingOrders[pos].lstCuttingOrderDetail[lstCuttingOrders[pos].lstCuttingOrderDetail.Count - 1].programmedWeight.ToString() != "NaN" && lstCuttingOrders[pos].lstCuttingOrderDetail[lstCuttingOrders[pos].lstCuttingOrderDetail.Count - 1].programmedWeight.ToString() != "NeuN")
                            {
                                if (double.IsInfinity(Convert.ToDouble(lstCuttingOrders[pos].lstCuttingOrderDetail[lstCuttingOrders[pos].lstCuttingOrderDetail.Count - 1].programmedWeight)))
                                    lstCuttingOrders[pos].lstCuttingOrderDetail[lstCuttingOrders[pos].lstCuttingOrderDetail.Count - 1].programmedWeight = 0;
                            }
                            else
                            {
                                lstCuttingOrders[pos].lstCuttingOrderDetail[lstCuttingOrders[pos].lstCuttingOrderDetail.Count - 1].programmedWeight = 0;
                            }
                        } 
                    }
                }
                for (int i = 0; i < dgvStock.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dgvStock.Rows[i].Cells[clmStockCoilsToCut.Index].Value) != 0)
                    {
                        for (int j = 0; j < Convert.ToInt32(dgvStock.Rows[i].Cells[clmStockCoilsToCut.Index].Value); j++)
                        {
                            coilPosition++;
                            lstCuttingOrders[pos].lstCuttingOrderDetail.Add(new clsCuttingOrderDetail());
                            lstCuttingOrders[pos].lstCuttingOrderDetail[lstCuttingOrders[pos].lstCuttingOrderDetail.Count - 1].fkProduct = Convert.ToInt32(dgvStock.Rows[i].Cells[clmStockProductCodsec.Index].Value);
                            lstCuttingOrders[pos].lstCuttingOrderDetail[lstCuttingOrders[pos].lstCuttingOrderDetail.Count - 1].width = Convert.ToDouble(dgvStock.Rows[i].Cells[clmStockWidth.Index].Value);
                            lstCuttingOrders[pos].lstCuttingOrderDetail[lstCuttingOrders[pos].lstCuttingOrderDetail.Count - 1].ProductName = dgvStock.Rows[i].Cells[clmStockProductName.Index].Value.ToString();
                            lstCuttingOrders[pos].lstCuttingOrderDetail[lstCuttingOrders[pos].lstCuttingOrderDetail.Count - 1].position = coilPosition;
                            clsProduct objSelectedProduct = new clsProduct(Convert.ToInt32(dgvStock.Rows[i].Cells[clmStockProductCodsec.Index].Value));
                            lstCuttingOrders[pos].lstCuttingOrderDetail[lstCuttingOrders[pos].lstCuttingOrderDetail.Count - 1].programmedLength = clsParameters.getAproxLengthByWidthAndWeigth(objSelectedProduct.fkBopp, objSelectedProduct.fkDiameter, objSelectedProduct.fkCore);
                            lstCuttingOrders[pos].lstCuttingOrderDetail[lstCuttingOrders[pos].lstCuttingOrderDetail.Count - 1].programmedWeight = Convert.ToDouble(dgvStock.Rows[i].Cells[clmStockProgrammedWeigth.Index].Value) / Convert.ToInt32(dgvStock.Rows[i].Cells[clmStockTotalCoils.Index].Value);

                            if (lstCuttingOrders[pos].lstCuttingOrderDetail[lstCuttingOrders[pos].lstCuttingOrderDetail.Count - 1].programmedWeight.ToString() != "NaN" && lstCuttingOrders[pos].lstCuttingOrderDetail[lstCuttingOrders[pos].lstCuttingOrderDetail.Count - 1].programmedWeight.ToString() != "NeuN")
                            {
                                if (double.IsInfinity(Convert.ToDouble(lstCuttingOrders[pos].lstCuttingOrderDetail[lstCuttingOrders[pos].lstCuttingOrderDetail.Count - 1].programmedWeight)))
                                    lstCuttingOrders[pos].lstCuttingOrderDetail[lstCuttingOrders[pos].lstCuttingOrderDetail.Count - 1].programmedWeight = 0;
                            }
                            else
                            {
                                lstCuttingOrders[pos].lstCuttingOrderDetail[lstCuttingOrders[pos].lstCuttingOrderDetail.Count - 1].programmedWeight = 0;
                            }
                        }
                    }
                }

                lstCuttingOrders[pos].save();
                generateResume();
                dgvStock.Rows.Clear();
                cmbCutter.SelectedIndex = -1;
                txtUtilWidth.Text = "0";
                cmbDiameter.SelectedIndex = -1;
                cmbCore.SelectedIndex = -1;
                fillSalesOrderList();
                tbcCuttingOrder.SelectedIndex = 2;
                chkAllowEquivalentFilm.Checked = false;
                txtNotes.Text = "";
            }
        }

        
        private void save(object sender, EventArgs e)
        {
            lstCuttingOrders[Convert.ToInt32(((Button)sender).Tag)].fkStatus = (clsStatus.getStatusByStatusGroupNameAndStatusName("Ordenes de corte", "Programada")).codsec;
            lstCuttingOrders[Convert.ToInt32(((Button)sender).Tag)].statusName = "Programada";
            lstCuttingOrders[Convert.ToInt32(((Button)sender).Tag)].save();
            generateResume();

            loadResumeLayout(Convert.ToInt32(dgvCuttingOrder.Rows[Convert.ToInt32(((Button)sender).Tag)].Cells[clmCodsec.Index].Value), Convert.ToInt32(((Button)sender).Tag));


            fillSalesOrderList();
            dgvStock.Rows.Clear();
            cmbCutter.Focus();

        }
        private void changeStops(object sender, EventArgs e)
        {
            if (nudStopsNumber.Visible == false)
            {
                nudStopsNumber.Visible = true;
                lblStopsNumber.Visible = false;
                btnRefresh.Image = global::BPS.Properties.Resources.disk;
            }
            else
            {
                //lstCuttingOrders[Convert.ToInt32(((Button)sender).Tag)].repetitions = Convert.ToInt32(((NumericUpDown)grpbCuttingOrderDetail.Controls["grpbOrder"].Controls["nudStopsNumber"]).Value);
                //lstCuttingOrders[Convert.ToInt32(((Button)sender).Tag)].save();
                lstCuttingOrders[selectedCuttingOrderRow].repetitions = Convert.ToInt32(nudStopsNumber.Value);
                lstCuttingOrders[selectedCuttingOrderRow].save();
                generateResume();


                loadResumeLayout(Convert.ToInt32(dgvCuttingOrder.Rows[Convert.ToInt32(((Button)sender).Tag)].Cells[clmCodsec.Index].Value), Convert.ToInt32(((Button)sender).Tag));


                fillSalesOrderList();
                dgvStock.Rows.Clear();
                cmbCutter.Focus();
                nudStopsNumber.Visible = false;
                lblStopsNumber.Visible = true;
                btnRefresh.Image = global::BPS.Properties.Resources.arrow_refresh;
            }
        }
        private void delete(object sender, EventArgs e)
        {
            lstCuttingOrders[Convert.ToInt32(((Button)sender).Tag)].fkStatus = (clsStatus.getStatusByStatusGroupNameAndStatusName("Ordenes de corte", "Cerrada")).codsec;
            lstCuttingOrders[Convert.ToInt32(((Button)sender).Tag)].statusName = "Cerrada";
            lstCuttingOrders[Convert.ToInt32(((Button)sender).Tag)].save();
            lstCuttingOrders.RemoveAt(Convert.ToInt32(((Button)sender).Tag));
            generateResume();
            fillSalesOrderList();
            dgvStock.Rows.Clear();
            cmbCutter.Focus();
        }

        private void btnFilterSalesOrder_Click(object sender, EventArgs e)
        {
            fillSalesOrderList();
        }

        private void btnClearFilterSalesOrder_Click(object sender, EventArgs e)
        {
            cmbCore.SelectedIndex = -1;
            cmbDiameter.SelectedIndex = -1;
            fillSalesOrderList();
        }

        private void txtUtilWidth_TextChanged(object sender, EventArgs e)
        {
            if (clsGlobal.isNumeric(txtUtilWidth.Text))
            {
                if (Convert.ToInt32(txtUtilWidth.Text) > Convert.ToInt32(lblUtilWidth.Text))
                {
                    MessageBox.Show("No se puede ingresar un ancho mayor al ancho máximo permitido por la cortadora");
                    txtUtilWidth.Text = lblUtilWidth.Text;
                    txtUtilWidth.SelectAll();
                }
                else
                    calculateCombination();
            }
            else
            {
                MessageBox.Show("El valor debe ser Numérico");
                txtUtilWidth.Text = lblUtilWidth.Text;
                txtUtilWidth.SelectAll();
            }
        }

        private void cmbCutter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                cmbCutter.Items.Clear();
                for (int i = 0; i < lstMachine.Count; i++)
                    cmbCutter.Items.Add(lstMachine[i]);
            }
        }

        private void cmbCore_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                cmbCore.Items.Clear();
                for (int i = 0; i < lstCore.Count; i++)
                    cmbCore.Items.Add(lstCore[i]);
            }
        }

        private void cmbDiameter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                cmbDiameter.Items.Clear();
                for (int i = 0; i < lstDiameter.Count; i++)
                    cmbDiameter.Items.Add(lstDiameter[i]);
            }
        }

        private void dgvCuttingOrder_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                loadResumeLayout(Convert.ToInt32(dgvCuttingOrder.Rows[e.RowIndex].Cells[clmCodsec.Index].Value), e.RowIndex);
            }
        }

        private void btnMainCoilCancel_Click(object sender, EventArgs e)
        {

        }

        private void grpbSalesOrders_Enter(object sender, EventArgs e)
        {

        }

        private void dgvSalesOrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmSalesOrderChangeProduct.Index)
            {
                objSelectedProduct = new clsProduct();
                frmProductList winProductList = new frmProductList(this, Convert.ToInt32(dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderProductCodsec.Index].Value), true);    
                winProductList.ShowDialog(this);

                objSelectedProduct.load(selectedProductCodsec);

                if (objSelectedProduct.codsec > 0)
                {
                    dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderProduct.Index].Value = objSelectedProduct.code.Replace("-", "");
                    dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderChangeProduct.Index].Value = global::BPS.Properties.Resources.arrow_refresh;

                    dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderTotalOrderCoils.Index].Value = clsParameters.getCoilsNumberByWidthAndWeigth(objSelectedProduct.fkBopp, objSelectedProduct.fkCast, objSelectedProduct.fkDiameter, objSelectedProduct.fkCore, objSelectedProduct.width, (Convert.ToDouble(dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderWeigth.Index].Value)));
                    dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderCoilsQuantity.Index].Value = clsParameters.getCoilsNumberByWidthAndWeigth(objSelectedProduct.fkBopp, objSelectedProduct.fkCast, objSelectedProduct.fkDiameter, objSelectedProduct.fkCore, objSelectedProduct.width, ((Convert.ToDouble(dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderWeigth.Index].Value) - lstSalesOrderDetail[Convert.ToInt32(dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderDetailIndex.Index].Value)].programmedWeigth)));

                    if (Convert.ToDouble(dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderCoilsQuantity.Index].Value) < 0)
                        dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderCoilsQuantity.Index].Value = 0;

                    dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderWidth.Index].Value = Convert.ToString(Math.Round(objSelectedProduct.width));
                    dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderCoreDiameter.Index].Value = objSelectedProduct.DiameterAbbreviation + objSelectedProduct.CoreValue.ToString();
                    dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderCoilsToCut.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderProgrammedWeigth.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderSlopeWeigth.Index].Value = Convert.ToString(Math.Round(lstSalesOrderDetail[Convert.ToInt32(dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderDetailIndex.Index].Value)].quantity - lstSalesOrderDetail[Convert.ToInt32(dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderDetailIndex.Index].Value)].programmedWeigth, 2));
                    dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderTotalSlope.Index].Value = Convert.ToString(Math.Round(lstSalesOrderDetail[Convert.ToInt32(dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderDetailIndex.Index].Value)].quantity - lstSalesOrderDetail[Convert.ToInt32(dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderDetailIndex.Index].Value)].programmedWeigth, 2));


                    double extra = Convert.ToDouble(dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderSlopeWeigth.Index].Value) * 100 / Convert.ToDouble(dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderWeigth.Index].Value);

                    if (-10 < extra && extra < 10)
                        dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderSlopeWeigth.Index].Style.ForeColor = Color.Green;
                    else if (Math.Round(lstSalesOrderDetail[Convert.ToInt32(dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderDetailIndex.Index].Value)].quantity - lstSalesOrderDetail[Convert.ToInt32(dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderDetailIndex.Index].Value)].programmedWeigth, 2) < 0)
                        dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderSlopeWeigth.Index].Style.ForeColor = Color.Red;
                    else
                        dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderSlopeWeigth.Index].Style.ForeColor = SystemColors.ControlText;

                    dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderProductCodsec.Index].Value = objSelectedProduct.codsec;

                    if (Convert.ToInt32(dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderProductCodsec.Index].Value) != Convert.ToInt32(dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderOriginalProductCodsec.Index].Value))
                    {
                        dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderProduct.Index].Style.ForeColor = Color.Orange;
                        dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderCoreDiameter.Index].Style.ForeColor = Color.Orange;
                    }
                    else
                    {
                        dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderProduct.Index].Style.ForeColor = Color.Black;
                        dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderCoreDiameter.Index].Style.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void txtBoppCode_TextChanged(object sender, EventArgs e)
        {
            fillFilmList();
        }

        private void btnChangeCutter_Click(object sender, EventArgs e)
        {

        }

        private void grpbCutterMachine_Enter(object sender, EventArgs e)
        {

        }

        private void grpbFilmNameSalesOrderTab_Enter(object sender, EventArgs e)
        {

        }

        private void dgvSalesOrderVisibility_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmSOVisible.Index)
            {
                if (Convert.ToBoolean(dgvSalesOrderVisibility.Rows[e.RowIndex].Cells[clmSOFlagVisible.Index].Value) == true)
                {
                    dgvSalesOrderVisibility.Rows[e.RowIndex].Cells[clmSOFlagVisible.Index].Value = 0;
                    dgvSalesOrderVisibility.Rows[e.RowIndex].Cells[clmSOVisible.Index].Value = global::BPS.Properties.Resources.clear;
                    chkSelectAll.Checked = false;
                }
                else
                {
                    dgvSalesOrderVisibility.Rows[e.RowIndex].Cells[clmSOFlagVisible.Index].Value = 1;
                    dgvSalesOrderVisibility.Rows[e.RowIndex].Cells[clmSOVisible.Index].Value = global::BPS.Properties.Resources.eye;
                    chkUnselectAll.Checked = false;
                }

                fillDatagrid();
            }
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelectAll.Checked == true)
            {
                for (int i = 0; i < dgvSalesOrderVisibility.Rows.Count; i++)
                {
                    dgvSalesOrderVisibility.Rows[i].Cells[clmSOFlagVisible.Index].Value = 1;
                    dgvSalesOrderVisibility.Rows[i].Cells[clmSOVisible.Index].Value = global::BPS.Properties.Resources.eye;
                }

                fillDatagrid();
                chkUnselectAll.Checked = false;
            }
        }

        private void chkUncheckAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUnselectAll.Checked == true)
            {
                for (int i = 0; i < dgvSalesOrderVisibility.Rows.Count; i++)
                {
                    dgvSalesOrderVisibility.Rows[i].Cells[clmSOFlagVisible.Index].Value = 0;
                    dgvSalesOrderVisibility.Rows[i].Cells[clmSOVisible.Index].Value = global::BPS.Properties.Resources.clear;
                }

                fillDatagrid();
                chkSelectAll.Checked = false;
            }
        }

        private void btnRefreshBopp_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewBopp_Click(object sender, EventArgs e)
        {

        }
    }
}