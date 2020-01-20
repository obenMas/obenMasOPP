using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms; 
using BPS.Bussiness;

namespace BPS.Lite
{
    public partial class frmCuttingOrderMultipleCast : Form
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

        clsCast objCast = new clsCast();
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

        public string Notes = "";

        public frmCuttingOrderMultipleCast()
        {
            InitializeComponent();
        }

        public void fillFilmList()
        {
            dgvCast.Rows.Clear();

            List<clsCast> lstCast = new List<clsCast>();
            List<clsFilter> lstFilter = new List<clsFilter>();

            if (txtCastCode.Text == "")
                lstCast = clsCast.getSimplifiedListWithQuantities();
            else
            {
                if (txtCastCode.Text != "")
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "cpp_code";
                    lstFilter[lstFilter.Count - 1].operation = "startsWith";
                    lstFilter[lstFilter.Count - 1].value = txtCastCode.Text;
                    lstFilter[lstFilter.Count - 1].dataType = "varchar";
                }
                lstCast = clsCast.getSimplifiedListWithQuantitiesByFilter(lstFilter);
            }

            for (int i = 0; i < lstCast.Count; i++)
            {
                dgvCast.Rows.Add();
                dgvCast.Rows[i].Cells[clmCodsec.Index].Value = lstCast[i].codsec.ToString();
                dgvCast.Rows[i].Cells[clmCode.Index].Value = lstCast[i].code.Replace("-", "");
                dgvCast.Rows[i].Cells[clmName.Index].Value = lstCast[i].name;
                dgvCast.Rows[i].Cells[clmTotalWeightFilms.Index].Value = Convert.ToString(Math.Round(lstCast[i].salesOrderQuantity, 2));
                dgvCast.Rows[i].Cells[clmMainCoilQuantity.Index].Value = Convert.ToString(Math.Round(lstCast[i].mainCoilQuantity, 2));
            }
        }
        private void generateResume()
        {
            lstCuttingOrders = clsCuttingOrder.getActiveListByCastCodsec(objCast.codsec);
            lstGroupBoxResume.Clear();

            dgvCuttingOrder.Rows.Clear();
            //grpbCuttingOrderDetail.Controls.Clear();
            grpbCombination.Controls.Clear();

            for (int i = 0; i < lstCuttingOrders.Count; i++)
            {
                dgvCuttingOrder.Rows.Add();
                dgvCuttingOrder.Rows[i].Cells[clmCodsec.Index].Value = lstCuttingOrders[i].codsec;
                dgvCuttingOrder.Rows[i].Cells[clmMachineName.Index].Value = lstCuttingOrders[i].machineName;
                dgvCuttingOrder.Rows[i].Cells[clmFilmName.Index].Value = new clsCast(lstCuttingOrders[i].fkCast).code.Replace("-", "");
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

                    dgvCuttingOrder.Rows[i].Cells[clmStatus.Index].Value = global::BPS.Lite.Properties.Resources.play_sharp;
                }
                else if (lstCuttingOrders[i].fkStatus == 24)
                {
                    dgvCuttingOrder.Rows[i].Cells[clmStatus.Index].Value = global::BPS.Lite.Properties.Resources.calendar_2;
                }
                else if (lstCuttingOrders[i].fkStatus == 31)
                {
                    dgvCuttingOrder.Rows[i].Cells[clmStatus.Index].Value = global::BPS.Lite.Properties.Resources.pause_sharp;
                }
                else if (lstCuttingOrders[i].fkStatus == 23)
                {
                    dgvCuttingOrder.Rows[i].Cells[clmStatus.Index].Value = global::BPS.Lite.Properties.Resources.clipboard_text;
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

            lblWasteDraw1.BackColor = System.Drawing.Color.DimGray;
            lblWasteDraw1.Size = new System.Drawing.Size(Convert.ToInt32(clsCuttingOrderResume.getProportinalWidth(objMachine.Cutter.utilWidth, wasteSize, 1020) / 2), 66);
            lblWasteDraw1.Location = new System.Drawing.Point(relativePosition, 21);

            grpbCombination.Controls.Clear();

            grpbCombination.Text = "Orden de corte #" + objCuttingOrder.number.ToString();
            grpbCombination.Controls.Add(lblWasteDraw1);

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

            lblWasteDraw2.BackColor = System.Drawing.Color.DimGray;
            lblWasteDraw2.Size = new System.Drawing.Size(Convert.ToInt32(clsCuttingOrderResume.getProportinalWidth(objMachine.Cutter.utilWidth, wasteSize, 1020) / 2), 66);
            lblWasteDraw2.Location = new System.Drawing.Point(relativePosition, 21);
            grpbCombination.Controls.Add(lblWasteDraw2);
            lblNotes.Text = objCuttingOrder.notes;
            switch (objCuttingOrder.fkStatus)
            {
                case 23:
                    lblStatusImage.Image = global::BPS.Lite.Properties.Resources.paste;
                    lblStatus.Text = objCuttingOrder.statusName;
                    break;
                case 24:
                    lblStatusImage.Image = global::BPS.Lite.Properties.Resources.calendar;
                    lblStatus.Text = objCuttingOrder.statusName;
                    break;
                case 25:
                    lblStatusImage.Image = global::BPS.Lite.Properties.Resources.applications;
                    lblStatus.Text = objCuttingOrder.statusName;
                    break;
                case 26:
                    lblStatusImage.Image = global::BPS.Lite.Properties.Resources.check;
                    lblStatus.Text = objCuttingOrder.statusName;
                    break;
                case 27:
                    lblStatusImage.Image = global::BPS.Lite.Properties.Resources.cancel1;
                    lblStatus.Text = objCuttingOrder.statusName;
                    break;
                case 31:
                    lblStatusImage.Image = global::BPS.Lite.Properties.Resources.Pause_Hot;
                    lblStatus.Text = objCuttingOrder.statusName;
                    break;
                default:
                    break;
            }

            switch (objCuttingOrder.fkStatus)
            {
                case 23:
                    btnSave.BackgroundImage = global::BPS.Lite.Properties.Resources.calendar_2;
                    btnSave.Visible = true;
                    btnCancel.Visible = true;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    break;
                case 24:
                    btnSave.BackgroundImage = global::BPS.Lite.Properties.Resources.calendar_2;
                    btnSave.Visible = true;
                    btnCancel.Visible = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = true;
                    break;
                case 25:
                    if (objCuttingOrder.beingProcessed())
                    {
                        btnSave.BackgroundImage = global::BPS.Lite.Properties.Resources.accept;
                        btnSave.Visible = true;
                        btnCancel.Visible = true;
                        btnSave.Enabled = false;
                        btnCancel.Enabled = false;
                    }
                    break;
                case 31:
                    if (objCuttingOrder.beingProcessed())
                    {
                        btnSave.BackgroundImage = global::BPS.Lite.Properties.Resources.gear_16;
                        btnSave.Visible = true;
                        btnCancel.Visible = true;
                        btnSave.Enabled = false;
                        btnCancel.Enabled = true;
                    }
                    break;
            }

            lblUsedWidthInDetail.Text = usedWidth.ToString();
            lblWasteInDetail.Text = Convert.ToString(Math.Round(((objMachine.Cutter.utilWidth - usedWidth) * 100 / objMachine.Cutter.utilWidth), 2));
            lblFilmNameInDetail.Text = objCuttingOrder.castCode.Replace("-", "");
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
            lstSalesOrderDetail = clsSalesOrderDetail.getCompleteListByCastFilm(Convert.ToInt32(Convert.ToInt32(dgvCast.SelectedRows[0].Cells[clmCodsec.Index].Value)));

            if (chkLoadEquivalentFilm.Checked == true)
                lstEquivalentSalesOrderDetail = clsSalesOrderDetail.getCompleteListByCastEquivalentFilm(Convert.ToInt32(Convert.ToInt32(dgvCast.SelectedRows[0].Cells[clmCodsec.Index].Value)));
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
                        dgvSalesOrderVisibility.Rows[dgvSalesOrderVisibility.Rows.Count - 1].Cells[clmSOVisible.Index].Value = global::BPS.Lite.Properties.Resources.clear;
                        dgvSalesOrderVisibility.Rows[dgvSalesOrderVisibility.Rows.Count - 1].Cells[clmSOFlagVisible.Index].Value = 0;

                        pos = dgvSalesOrderVisibility.Rows.Count - 1;
                    }

                    if (clsSalesOrderDetail.getPendingCoilBySalesOrderDetailObj(lstSalesOrderDetail[i]) > 0)
                    {
                        dgvSalesOrderVisibility.Rows[pos].Cells[clmSOVisible.Index].Value = global::BPS.Lite.Properties.Resources.eye;
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
                    //objSalesOrderDetailItems.totalCoils = Convert.ToInt32(clsParameters.getCoilsNumberByWidthAndWeigth(lstSalesOrderDetail[i].product.fkCast, lstSalesOrderDetail[i].product.fkDiameter, lstSalesOrderDetail[i].product.fkCore, lstSalesOrderDetail[i].product.width, (lstSalesOrderDetail[i].quantity)));
                    objSalesOrderDetailItems.totalCoils = lstSalesOrderDetail[i].coilsToCut;
                    objSalesOrderDetailItems.pendingCoils = Convert.ToInt32(clsSalesOrderDetail.getPendingCoilBySalesOrderDetailObj(lstSalesOrderDetail[i]));
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
                            dgvSalesOrderVisibility.Rows[dgvSalesOrderVisibility.Rows.Count - 1].Cells[clmSOVisible.Index].Value = global::BPS.Lite.Properties.Resources.clear;
                            dgvSalesOrderVisibility.Rows[dgvSalesOrderVisibility.Rows.Count - 1].Cells[clmSOFlagVisible.Index].Value = 0;

                            pos = dgvSalesOrderVisibility.Rows.Count - 1;
                        }

                        if (clsSalesOrderDetail.getPendingCoilBySalesOrderDetailObj(lstEquivalentSalesOrderDetail[i]) > 0)
                        {
                            dgvSalesOrderVisibility.Rows[pos].Cells[clmSOVisible.Index].Value = global::BPS.Lite.Properties.Resources.eye;
                            dgvSalesOrderVisibility.Rows[pos].Cells[clmSOFlagVisible.Index].Value = 1;
                        }

                        //SALES ORDER DETAIL LIST


                        salesOrderDetailItems objSalesOrderDetailItems = new salesOrderDetailItems();

                        objSalesOrderDetailItems.codsec = lstEquivalentSalesOrderDetail[i].codsec;
                        objSalesOrderDetailItems.entityName = objSalesOrder.EntityName;
                        objSalesOrderDetailItems.number = objSalesOrder.number;
                        objSalesOrderDetailItems.productCode = lstEquivalentSalesOrderDetail[i].product.code.Replace("-", "");
                        objSalesOrderDetailItems.weight = Math.Round(lstEquivalentSalesOrderDetail[i].quantity, 2);
                        //objSalesOrderDetailItems.totalCoils = Convert.ToInt32(clsParameters.getCoilsNumberByWidthAndWeigth(lstEquivalentSalesOrderDetail[i].product.fkCast, lstEquivalentSalesOrderDetail[i].product.fkDiameter, lstEquivalentSalesOrderDetail[i].product.fkCore, lstEquivalentSalesOrderDetail[i].product.width, (lstEquivalentSalesOrderDetail[i].quantity)));
                        objSalesOrderDetailItems.totalCoils = lstEquivalentSalesOrderDetail[i].coilsToCut;
                        objSalesOrderDetailItems.pendingCoils = Convert.ToInt32(clsSalesOrderDetail.getPendingCoilBySalesOrderDetailObj(lstEquivalentSalesOrderDetail[i]));
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

            lblUsedWidth1.Text = "0";
            lblUsedArms1.Text = "0";
            lblViableCombination1.Text = "NO";
            lblViableCombination1.ForeColor = Color.Red;
            nudStops1.Value = 1;
            nudWasteAllowed1.Value = 10;
            lblWaste1.Text = "0";
            btnObservations1.Tag = "";
            ttpCuttingOrder.SetToolTip(btnObservations1, "-- Sin observaciones --");

            lblUsedWidth2.Text = "0";
            lblUsedArms2.Text = "0";
            lblViableCombination2.Text = "NO";
            lblViableCombination2.ForeColor = Color.Red;
            nudStops2.Value = 1;
            nudWasteAllowed2.Value = 10;
            lblWaste2.Text = "0";
            btnObservations2.Tag = "";
            ttpCuttingOrder.SetToolTip(btnObservations2, "-- Sin observaciones --");

            lblUsedWidth3.Text = "0";
            lblUsedArms3.Text = "0";
            lblViableCombination3.Text = "NO";
            lblViableCombination3.ForeColor = Color.Red;
            nudStops3.Value = 1;
            nudWasteAllowed3.Value = 10;
            lblWaste3.Text = "0";
            btnObservations3.Tag = "";
            ttpCuttingOrder.SetToolTip(btnObservations3, "-- Sin observaciones --");

            lblUsedWidth4.Text = "0";
            lblUsedArms4.Text = "0";
            lblViableCombination4.Text = "NO";
            lblViableCombination4.ForeColor = Color.Red;
            nudStops4.Value = 1;
            nudWasteAllowed4.Value = 10;
            lblWaste4.Text = "0";
            btnObservations4.Tag = "";
            ttpCuttingOrder.SetToolTip(btnObservations4, "-- Sin observaciones --");

            lblUsedWidth5.Text = "0";
            lblUsedArms5.Text = "0";
            lblViableCombination5.Text = "NO";
            lblViableCombination5.ForeColor = Color.Red;
            nudStops5.Value = 1;
            nudWasteAllowed5.Value = 10;
            lblWaste5.Text = "0";
            btnObservations5.Tag = "";
            ttpCuttingOrder.SetToolTip(btnObservations5, "-- Sin observaciones --");

            lblUsedWidth6.Text = "0";
            lblUsedArms6.Text = "0";
            lblViableCombination6.Text = "NO";
            lblViableCombination6.ForeColor = Color.Red;
            nudStops6.Value = 1;
            nudWasteAllowed6.Value = 10;
            lblWaste6.Text = "0";
            btnObservations6.Tag = "";
            ttpCuttingOrder.SetToolTip(btnObservations6, "-- Sin observaciones --");

            lblUsedWidth7.Text = "0";
            lblUsedArms7.Text = "0";
            lblViableCombination7.Text = "NO";
            lblViableCombination7.ForeColor = Color.Red;
            nudStops7.Value = 1;
            nudWasteAllowed7.Value = 10;
            lblWaste7.Text = "0";
            btnObservations7.Tag = "";
            ttpCuttingOrder.SetToolTip(btnObservations7, "-- Sin observaciones --");

            lblUsedWidth8.Text = "0";
            lblUsedArms8.Text = "0";
            lblViableCombination8.Text = "NO";
            lblViableCombination8.ForeColor = Color.Red;
            nudStops8.Value = 1;
            nudWasteAllowed8.Value = 10;
            lblWaste8.Text = "0";
            btnObservations8.Tag = "";
            ttpCuttingOrder.SetToolTip(btnObservations8, "-- Sin observaciones --");

            lblUsedWidth9.Text = "0";
            lblUsedArms9.Text = "0";
            lblViableCombination9.Text = "NO";
            lblViableCombination9.ForeColor = Color.Red;
            nudStops9.Value = 1;
            nudWasteAllowed9.Value = 10;
            lblWaste9.Text = "0";
            btnObservations9.Tag = "";
            ttpCuttingOrder.SetToolTip(btnObservations9, "-- Sin observaciones --");

            lblUsedWidth10.Text = "0";
            lblUsedArms10.Text = "0";
            lblViableCombination10.Text = "NO";
            lblViableCombination10.ForeColor = Color.Red;
            nudStops10.Value = 1;
            nudWasteAllowed10.Value = 10;
            lblWaste10.Text = "0";
            btnObservations10.Tag = "";
            ttpCuttingOrder.SetToolTip(btnObservations10, "-- Sin observaciones --");
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

                    int j = dgvSalesOrderDetail.Rows.Count - 2;

                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCodsec.Index].Value = lstSalesOrderDetailItems[i].codsec;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCustomer.Index].Value = lstSalesOrderDetailItems[i].entityName;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderNumber.Index].Value = lstSalesOrderDetailItems[i].number.Replace("005-00", "");
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderProduct.Index].Value = lstSalesOrderDetailItems[i].productCode;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderChangeProduct.Index].Value = global::BPS.Lite.Properties.Resources.arrow_refresh;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderWeigth.Index].Value = lstSalesOrderDetailItems[i].weight;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderTotalOrderCoils.Index].Value = lstSalesOrderDetailItems[i].totalCoils;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCoilsQuantity.Index].Value = lstSalesOrderDetailItems[i].pendingCoils;

                    //if (lstSalesOrderDetailItems[i].pendingCoils < 0)
                    //    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCoilsQuantity.Index].Value = 0;

                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderWidth.Index].Value = lstSalesOrderDetailItems[i].width;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCoreDiameter.Index].Value = lstSalesOrderDetailItems[i].coreDiameter;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCoilsToCut1.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCoilsToCut2.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCoilsToCut3.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCoilsToCut4.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCoilsToCut5.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCoilsToCut6.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCoilsToCut7.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCoilsToCut8.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCoilsToCut9.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCoilsToCut10.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderTotalCoils1.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderTotalCoils2.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderTotalCoils3.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderTotalCoils4.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderTotalCoils5.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderTotalCoils6.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderTotalCoils7.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderTotalCoils8.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderTotalCoils9.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderTotalCoils10.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderProgrammedCoils.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderSlopeCoils.Index].Value = lstSalesOrderDetailItems[i].pendingCoils;

                    if (Convert.ToInt32(dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderSlopeCoils.Index].Value) == 0)
                        dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderSlopeCoils.Index].Style.ForeColor = Color.LightGreen;
                    else if (Convert.ToInt32(dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderSlopeCoils.Index].Value) < 0)
                        dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderSlopeCoils.Index].Style.ForeColor = Color.Red;
                    else
                        dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderSlopeCoils.Index].Style.ForeColor = SystemColors.ControlText;

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
        private void calculateTotalValue(int rowIndex, int colIndex, double value)
        {
            int totalColumnIndex = colIndex + 1;
            int repetitions = 0;

            switch (colIndex)
            {
                case 10:
                    repetitions = Convert.ToInt32(nudStops1.Value);
                    break;
                case 12:
                    repetitions = Convert.ToInt32(nudStops2.Value);
                    break;
                case 14:
                    repetitions = Convert.ToInt32(nudStops3.Value);
                    break;
                case 16:
                    repetitions = Convert.ToInt32(nudStops4.Value);
                    break;
                case 18:
                    repetitions = Convert.ToInt32(nudStops5.Value);
                    break;
                case 20:
                    repetitions = Convert.ToInt32(nudStops6.Value);
                    break;
                case 22:
                    repetitions = Convert.ToInt32(nudStops7.Value);
                    break;
                case 24:
                    repetitions = Convert.ToInt32(nudStops8.Value);
                    break;
                case 26:
                    repetitions = Convert.ToInt32(nudStops9.Value);
                    break;
                case 28:
                    repetitions = Convert.ToInt32(nudStops10.Value);
                    break;
            }

            dgvSalesOrderDetail.Rows[rowIndex].Cells[totalColumnIndex].Value = Math.Round(value * repetitions, 0);
            dgvSalesOrderDetail.Rows[rowIndex].Cells[clmSalesOrderProgrammedCoils.Index].Value = 0;

            for (int j = 11; j < 30; j = j +2)
                dgvSalesOrderDetail.Rows[rowIndex].Cells[clmSalesOrderProgrammedCoils.Index].Value = Convert.ToInt32(dgvSalesOrderDetail.Rows[rowIndex].Cells[clmSalesOrderProgrammedCoils.Index].Value) + Convert.ToInt32(dgvSalesOrderDetail.Rows[rowIndex].Cells[j].Value);


            dgvSalesOrderDetail.Rows[rowIndex].Cells[clmSalesOrderSlopeCoils.Index].Value = Convert.ToInt32(dgvSalesOrderDetail.Rows[rowIndex].Cells[clmSalesOrderCoilsQuantity.Index].Value) - Convert.ToInt32(dgvSalesOrderDetail.Rows[rowIndex].Cells[clmSalesOrderProgrammedCoils.Index].Value);

            if (Convert.ToInt32(dgvSalesOrderDetail.Rows[rowIndex].Cells[clmSalesOrderSlopeCoils.Index].Value) == 0)
                dgvSalesOrderDetail.Rows[rowIndex].Cells[clmSalesOrderSlopeCoils.Index].Style.ForeColor = Color.LightGreen;
            else if (Convert.ToInt32(dgvSalesOrderDetail.Rows[rowIndex].Cells[clmSalesOrderSlopeCoils.Index].Value) < 0)
                dgvSalesOrderDetail.Rows[rowIndex].Cells[clmSalesOrderSlopeCoils.Index].Style.ForeColor = Color.Red;
            else
                dgvSalesOrderDetail.Rows[rowIndex].Cells[clmSalesOrderSlopeCoils.Index].Style.ForeColor = SystemColors.ControlText;

            if (Convert.ToInt32(value) > 0)
            {
                for (int i = 0; i < 10; i++)
                    dgvSalesOrderDetail.Rows[rowIndex].Cells[i].Style.BackColor = Color.LightBlue;

                dgvSalesOrderDetail.Rows[rowIndex].Cells[colIndex].Style.BackColor = Color.LightBlue;
                dgvSalesOrderDetail.Rows[rowIndex].Cells[totalColumnIndex].Style.BackColor = Color.LightBlue;
            }
            else
            {
                bool flgClearRowColor = true;

                for (int i = 10; i < clmSalesOrderTotalCoils10.Index; i = i + 2)
                {
                    if (Convert.ToInt32(dgvSalesOrderDetail.Rows[rowIndex].Cells[i].Value) > 0 && (i != colIndex)) 
                        flgClearRowColor = false;
                }

                if (flgClearRowColor == true)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (Convert.ToBoolean(dgvSalesOrderDetail.Rows[rowIndex].Cells[clmSalesOrderIsEquivalentFilm.Index].Value) == true)
                            dgvSalesOrderDetail.Rows[rowIndex].Cells[i].Style.BackColor = Color.LightGreen;
                        else
                            dgvSalesOrderDetail.Rows[rowIndex].Cells[i].Style.BackColor = Color.White;
                    }                    
                }
                switch (colIndex)
                {
                    case 10:
                    case 14:
                    case 18:
                    case 22:
                    case 26:
                        dgvSalesOrderDetail.Rows[rowIndex].Cells[colIndex].Style.BackColor = Color.FromArgb(224, 224, 224);
                        dgvSalesOrderDetail.Rows[rowIndex].Cells[totalColumnIndex].Style.BackColor = Color.FromArgb(224, 224, 224);
                        break;
                    case 12:
                    case 16:
                    case 20:
                    case 24:
                    case 28:
                        dgvSalesOrderDetail.Rows[rowIndex].Cells[colIndex].Style.BackColor = Color.White;
                        dgvSalesOrderDetail.Rows[rowIndex].Cells[totalColumnIndex].Style.BackColor = Color.White;
                        break;
                    default:
                        break;
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
            for (int i = 0; i < dgvSalesOrderDetail.Rows.Count - 1; i++)
            {
                usedWidth += (Convert.ToDouble(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderWidth.Index].Value) * (Convert.ToDouble(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderTotalCoils1.Index].Value) / Convert.ToInt32(nudStops1.Value)));
                numCoils += Convert.ToInt32(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderTotalCoils1.Index].Value);

                //if (dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderProgrammedWeigth.Index].Value.ToString() != "NaN" && dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderProgrammedWeigth.Index].Value.ToString() != "NeuN")
                //    programmedWeigth += Convert.ToDouble(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderProgrammedWeigth.Index].Value);

                if (Convert.ToDouble(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderTotalCoils1.Index].Value) != 0 && Convert.ToDouble(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderTotalCoils1.Index].Value) % Convert.ToDouble(nudStops1.Value) != 0)
                {
                    dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderTotalCoils1.Index].Style.ForeColor = Color.Red;
                    flgMultiple = true;
                }
                else
                    dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderTotalCoils1.Index].Style.ForeColor = SystemColors.ControlText;
            }
            numArms = Convert.ToInt32(Math.Round(numCoils / nudStops1.Value, 0));
            if (lblUtilWidth.Text != "")
                wastePercentage = Math.Round(((Convert.ToDouble(txtUtilWidth.Text) - usedWidth) * 100) / Convert.ToDouble(txtUtilWidth.Text), 2);


            lblUsedWidth1.Text = Convert.ToString(Math.Round(usedWidth, 2));
            lblUnusedWidth1.Text = Convert.ToString(Math.Round((Convert.ToDouble(txtUtilWidth.Text) - Convert.ToDouble(lblUsedWidth1.Text)), 2));
            lblUsedArms1.Text = Convert.ToString(numArms);
            lblWaste1.Text = wastePercentage.ToString();


            if (usedWidth > Convert.ToDouble(txtUtilWidth.Text))
            {
                flgWidthOverload = true;
                lblUsedWidth1.ForeColor = Color.Red;
                lblWaste1.ForeColor = SystemColors.ControlText;
            }
            else if (wastePercentage > Convert.ToDouble(nudWasteAllowed1.Value))
            {
                flgWaste = true;
                lblWaste1.ForeColor = Color.Red;
                lblUsedWidth1.ForeColor = SystemColors.ControlText;
            }
            else
            {
                lblUsedWidth1.ForeColor = SystemColors.ControlText;
                lblWaste1.ForeColor = SystemColors.ControlText;
            }

            if (numArms > Convert.ToInt32(lblArms.Text))
            {
                flgArmsOverload = true;
                lblUsedArms1.ForeColor = Color.Red;
            }
            else
                lblUsedArms1.ForeColor = SystemColors.ControlText;

            if (!flgArmsOverload && !flgMultiple && !flgWaste && !flgWidthOverload)
            {
                lblViableCombination1.Text = "SI";
                lblViableCombination1.ForeColor = Color.Green;
            }
            else
            {
                lblViableCombination1.Text = "NO";
                lblViableCombination1.ForeColor = Color.Red;
            }

        }
        private void calculateCombination(int combinationNumber)
        {
            clmProgrammedWeigth.Visible = true;
            int numCoils = 0;
            double usedWidth = 0;
            int numArms = 0;
            double wastePercentage = 0;
            programmedWeigth = 0;
            int repetitions = 0;
            int ColIndex = 9 + (2 * combinationNumber);

            switch (ColIndex)
            {
                case 11:
                    repetitions = Convert.ToInt32(nudStops1.Value);
                    break;
                case 13:
                    repetitions = Convert.ToInt32(nudStops2.Value);
                    break;
                case 15:
                    repetitions = Convert.ToInt32(nudStops3.Value);
                    break;
                case 17:
                    repetitions = Convert.ToInt32(nudStops4.Value);
                    break;
                case 19:
                    repetitions = Convert.ToInt32(nudStops5.Value);
                    break;
                case 21:
                    repetitions = Convert.ToInt32(nudStops6.Value);
                    break;
                case 23:
                    repetitions = Convert.ToInt32(nudStops7.Value);
                    break;
                case 25:
                    repetitions = Convert.ToInt32(nudStops8.Value);
                    break;
                case 27:
                    repetitions = Convert.ToInt32(nudStops9.Value);
                    break;
                case 29:
                    repetitions = Convert.ToInt32(nudStops10.Value);
                    break;
            }



            bool flgMultiple = false, flgWidthOverload = false, flgArmsOverload = false, flgWaste = false;
            for (int i = 0; i < dgvSalesOrderDetail.Rows.Count - 1; i++)
            {
                usedWidth += (Convert.ToDouble(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderWidth.Index].Value) * (Convert.ToDouble(dgvSalesOrderDetail.Rows[i].Cells[ColIndex].Value) / Convert.ToInt32(repetitions)));
                numCoils += Convert.ToInt32(dgvSalesOrderDetail.Rows[i].Cells[ColIndex].Value);

                //if (dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderProgrammedWeigth.Index].Value.ToString() != "NaN" && dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderProgrammedWeigth.Index].Value.ToString() != "NeuN")
                //    programmedWeigth += Convert.ToDouble(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderProgrammedWeigth.Index].Value);

                if (Convert.ToDouble(dgvSalesOrderDetail.Rows[i].Cells[ColIndex].Value) != 0 && Convert.ToDouble(dgvSalesOrderDetail.Rows[i].Cells[ColIndex].Value) % Convert.ToDouble(repetitions) != 0)
                {
                    dgvSalesOrderDetail.Rows[i].Cells[ColIndex].Style.ForeColor = Color.Red;
                    flgMultiple = true;
                }
                else
                    dgvSalesOrderDetail.Rows[i].Cells[ColIndex].Style.ForeColor = SystemColors.ControlText;
            }
            numArms = Convert.ToInt32(Math.Round(Convert.ToDecimal(numCoils / repetitions), 0));
            if (lblUtilWidth.Text != "")
                wastePercentage = Math.Round(((Convert.ToDouble(txtUtilWidth.Text) - usedWidth) * 100) / Convert.ToDouble(txtUtilWidth.Text), 2);

            switch (ColIndex)
            {
                case 11:
                    lblUsedWidth1.Text = Convert.ToString(Math.Round(usedWidth, 2));
                    lblUnusedWidth1.Text = Convert.ToString(Math.Round((Convert.ToDouble(txtUtilWidth.Text) - Convert.ToDouble(lblUsedWidth1.Text)), 2));
                    lblUsedArms1.Text = Convert.ToString(numArms);
                    lblWaste1.Text = wastePercentage.ToString();


                    if (usedWidth > Convert.ToDouble(txtUtilWidth.Text))
                    {
                        flgWidthOverload = true;
                        lblUsedWidth1.ForeColor = Color.Red;
                        lblWaste1.ForeColor = SystemColors.ControlText;
                    }
                    else if (wastePercentage > Convert.ToDouble(nudWasteAllowed1.Value))
                    {
                        flgWaste = true;
                        lblWaste1.ForeColor = Color.Red;
                        lblUsedWidth1.ForeColor = SystemColors.ControlText;
                    }
                    else
                    {
                        lblUsedWidth1.ForeColor = SystemColors.ControlText;
                        lblWaste1.ForeColor = SystemColors.ControlText;
                    }

                    if (numArms > Convert.ToInt32(lblArms.Text))
                    {
                        flgArmsOverload = true;
                        lblUsedArms1.ForeColor = Color.Red;
                    }
                    else
                        lblUsedArms1.ForeColor = SystemColors.ControlText;

                    if (!flgArmsOverload && !flgMultiple && !flgWaste && !flgWidthOverload)
                    {
                        lblViableCombination1.Text = "SI";
                        lblViableCombination1.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblViableCombination1.Text = "NO";
                        lblViableCombination1.ForeColor = Color.Red;
                    }
                    break;
                case 13:
                    lblUsedWidth2.Text = Convert.ToString(Math.Round(usedWidth, 2));
                    lblUnusedWidth2.Text = Convert.ToString(Math.Round((Convert.ToDouble(txtUtilWidth.Text) - Convert.ToDouble(lblUsedWidth2.Text)), 2));
                    lblUsedArms2.Text = Convert.ToString(numArms);
                    lblWaste2.Text = wastePercentage.ToString();


                    if (usedWidth > Convert.ToDouble(txtUtilWidth.Text))
                    {
                        flgWidthOverload = true;
                        lblUsedWidth2.ForeColor = Color.Red;
                        lblWaste2.ForeColor = SystemColors.ControlText;
                    }
                    else if (wastePercentage > Convert.ToDouble(nudWasteAllowed2.Value))
                    {
                        flgWaste = true;
                        lblWaste1.ForeColor = Color.Red;
                        lblUsedWidth2.ForeColor = SystemColors.ControlText;
                    }
                    else
                    {
                        lblUsedWidth2.ForeColor = SystemColors.ControlText;
                        lblWaste1.ForeColor = SystemColors.ControlText;
                    }

                    if (numArms > Convert.ToInt32(lblArms.Text))
                    {
                        flgArmsOverload = true;
                        lblUsedArms2.ForeColor = Color.Red;
                    }
                    else
                        lblUsedArms2.ForeColor = SystemColors.ControlText;

                    if (!flgArmsOverload && !flgMultiple && !flgWaste && !flgWidthOverload)
                    {
                        lblViableCombination2.Text = "SI";
                        lblViableCombination2.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblViableCombination2.Text = "NO";
                        lblViableCombination2.ForeColor = Color.Red;
                    }
                    break;
                case 15:
                    lblUsedWidth3.Text = Convert.ToString(Math.Round(usedWidth, 2));
                    lblUnusedWidth3.Text = Convert.ToString(Math.Round((Convert.ToDouble(txtUtilWidth.Text) - Convert.ToDouble(lblUsedWidth3.Text)), 2));
                    lblUsedArms3.Text = Convert.ToString(numArms);
                    lblWaste3.Text = wastePercentage.ToString();


                    if (usedWidth > Convert.ToDouble(txtUtilWidth.Text))
                    {
                        flgWidthOverload = true;
                        lblUsedWidth3.ForeColor = Color.Red;
                        lblWaste3.ForeColor = SystemColors.ControlText;
                    }
                    else if (wastePercentage > Convert.ToDouble(nudWasteAllowed3.Value))
                    {
                        flgWaste = true;
                        lblWaste3.ForeColor = Color.Red;
                        lblUsedWidth3.ForeColor = SystemColors.ControlText;
                    }
                    else
                    {
                        lblUsedWidth3.ForeColor = SystemColors.ControlText;
                        lblWaste3.ForeColor = SystemColors.ControlText;
                    }

                    if (numArms > Convert.ToInt32(lblArms.Text))
                    {
                        flgArmsOverload = true;
                        lblUsedArms3.ForeColor = Color.Red;
                    }
                    else
                        lblUsedArms3.ForeColor = SystemColors.ControlText;

                    if (!flgArmsOverload && !flgMultiple && !flgWaste && !flgWidthOverload)
                    {
                        lblViableCombination3.Text = "SI";
                        lblViableCombination3.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblViableCombination3.Text = "NO";
                        lblViableCombination3.ForeColor = Color.Red;
                    }
                    break;
                case 17:
                    lblUsedWidth4.Text = Convert.ToString(Math.Round(usedWidth, 2));
                    lblUnusedWidth4.Text = Convert.ToString(Math.Round((Convert.ToDouble(txtUtilWidth.Text) - Convert.ToDouble(lblUsedWidth4.Text)), 2));
                    lblUsedArms4.Text = Convert.ToString(numArms);
                    lblWaste4.Text = wastePercentage.ToString();


                    if (usedWidth > Convert.ToDouble(txtUtilWidth.Text))
                    {
                        flgWidthOverload = true;
                        lblUsedWidth4.ForeColor = Color.Red;
                        lblWaste4.ForeColor = SystemColors.ControlText;
                    }
                    else if (wastePercentage > Convert.ToDouble(nudWasteAllowed4.Value))
                    {
                        flgWaste = true;
                        lblWaste4.ForeColor = Color.Red;
                        lblUsedWidth4.ForeColor = SystemColors.ControlText;
                    }
                    else
                    {
                        lblUsedWidth4.ForeColor = SystemColors.ControlText;
                        lblWaste4.ForeColor = SystemColors.ControlText;
                    }

                    if (numArms > Convert.ToInt32(lblArms.Text))
                    {
                        flgArmsOverload = true;
                        lblUsedArms4.ForeColor = Color.Red;
                    }
                    else
                        lblUsedArms4.ForeColor = SystemColors.ControlText;

                    if (!flgArmsOverload && !flgMultiple && !flgWaste && !flgWidthOverload)
                    {
                        lblViableCombination4.Text = "SI";
                        lblViableCombination4.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblViableCombination4.Text = "NO";
                        lblViableCombination4.ForeColor = Color.Red;
                    }
                    break;
                case 19:
                    lblUsedWidth5.Text = Convert.ToString(Math.Round(usedWidth, 2));
                    lblUnusedWidth5.Text = Convert.ToString(Math.Round((Convert.ToDouble(txtUtilWidth.Text) - Convert.ToDouble(lblUsedWidth5.Text)), 2));
                    lblUsedArms5.Text = Convert.ToString(numArms);
                    lblWaste5.Text = wastePercentage.ToString();


                    if (usedWidth > Convert.ToDouble(txtUtilWidth.Text))
                    {
                        flgWidthOverload = true;
                        lblUsedWidth5.ForeColor = Color.Red;
                        lblWaste5.ForeColor = SystemColors.ControlText;
                    }
                    else if (wastePercentage > Convert.ToDouble(nudWasteAllowed5.Value))
                    {
                        flgWaste = true;
                        lblWaste5.ForeColor = Color.Red;
                        lblUsedWidth5.ForeColor = SystemColors.ControlText;
                    }
                    else
                    {
                        lblUsedWidth5.ForeColor = SystemColors.ControlText;
                        lblWaste5.ForeColor = SystemColors.ControlText;
                    }

                    if (numArms > Convert.ToInt32(lblArms.Text))
                    {
                        flgArmsOverload = true;
                        lblUsedArms5.ForeColor = Color.Red;
                    }
                    else
                        lblUsedArms5.ForeColor = SystemColors.ControlText;

                    if (!flgArmsOverload && !flgMultiple && !flgWaste && !flgWidthOverload)
                    {
                        lblViableCombination5.Text = "SI";
                        lblViableCombination5.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblViableCombination5.Text = "NO";
                        lblViableCombination5.ForeColor = Color.Red;
                    }
                    break;
                case 21:
                    lblUsedWidth6.Text = Convert.ToString(Math.Round(usedWidth, 2));
                    lblUnusedWidth6.Text = Convert.ToString(Math.Round((Convert.ToDouble(txtUtilWidth.Text) - Convert.ToDouble(lblUsedWidth6.Text)), 2));
                    lblUsedArms6.Text = Convert.ToString(numArms);
                    lblWaste6.Text = wastePercentage.ToString();


                    if (usedWidth > Convert.ToDouble(txtUtilWidth.Text))
                    {
                        flgWidthOverload = true;
                        lblUsedWidth6.ForeColor = Color.Red;
                        lblWaste6.ForeColor = SystemColors.ControlText;
                    }
                    else if (wastePercentage > Convert.ToDouble(nudWasteAllowed6.Value))
                    {
                        flgWaste = true;
                        lblWaste6.ForeColor = Color.Red;
                        lblUsedWidth6.ForeColor = SystemColors.ControlText;
                    }
                    else
                    {
                        lblUsedWidth6.ForeColor = SystemColors.ControlText;
                        lblWaste6.ForeColor = SystemColors.ControlText;
                    }

                    if (numArms > Convert.ToInt32(lblArms.Text))
                    {
                        flgArmsOverload = true;
                        lblUsedArms6.ForeColor = Color.Red;
                    }
                    else
                        lblUsedArms6.ForeColor = SystemColors.ControlText;

                    if (!flgArmsOverload && !flgMultiple && !flgWaste && !flgWidthOverload)
                    {
                        lblViableCombination6.Text = "SI";
                        lblViableCombination6.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblViableCombination6.Text = "NO";
                        lblViableCombination6.ForeColor = Color.Red;
                    }
                    break;
                case 23:
                    lblUsedWidth7.Text = Convert.ToString(Math.Round(usedWidth, 2));
                    lblUnusedWidth7.Text = Convert.ToString(Math.Round((Convert.ToDouble(txtUtilWidth.Text) - Convert.ToDouble(lblUsedWidth7.Text)), 2));
                    lblUsedArms7.Text = Convert.ToString(numArms);
                    lblWaste7.Text = wastePercentage.ToString();


                    if (usedWidth > Convert.ToDouble(txtUtilWidth.Text))
                    {
                        flgWidthOverload = true;
                        lblUsedWidth7.ForeColor = Color.Red;
                        lblWaste7.ForeColor = SystemColors.ControlText;
                    }
                    else if (wastePercentage > Convert.ToDouble(nudWasteAllowed7.Value))
                    {
                        flgWaste = true;
                        lblWaste7.ForeColor = Color.Red;
                        lblUsedWidth7.ForeColor = SystemColors.ControlText;
                    }
                    else
                    {
                        lblUsedWidth7.ForeColor = SystemColors.ControlText;
                        lblWaste7.ForeColor = SystemColors.ControlText;
                    }

                    if (numArms > Convert.ToInt32(lblArms.Text))
                    {
                        flgArmsOverload = true;
                        lblUsedArms7.ForeColor = Color.Red;
                    }
                    else
                        lblUsedArms7.ForeColor = SystemColors.ControlText;

                    if (!flgArmsOverload && !flgMultiple && !flgWaste && !flgWidthOverload)
                    {
                        lblViableCombination7.Text = "SI";
                        lblViableCombination7.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblViableCombination7.Text = "NO";
                        lblViableCombination7.ForeColor = Color.Red;
                    }
                    break;
                case 25:
                    lblUsedWidth8.Text = Convert.ToString(Math.Round(usedWidth, 2));
                    lblUnusedWidth8.Text = Convert.ToString(Math.Round((Convert.ToDouble(txtUtilWidth.Text) - Convert.ToDouble(lblUsedWidth8.Text)), 2));
                    lblUsedArms8.Text = Convert.ToString(numArms);
                    lblWaste8.Text = wastePercentage.ToString();


                    if (usedWidth > Convert.ToDouble(txtUtilWidth.Text))
                    {
                        flgWidthOverload = true;
                        lblUsedWidth8.ForeColor = Color.Red;
                        lblWaste8.ForeColor = SystemColors.ControlText;
                    }
                    else if (wastePercentage > Convert.ToDouble(nudWasteAllowed8.Value))
                    {
                        flgWaste = true;
                        lblWaste8.ForeColor = Color.Red;
                        lblUsedWidth8.ForeColor = SystemColors.ControlText;
                    }
                    else
                    {
                        lblUsedWidth8.ForeColor = SystemColors.ControlText;
                        lblWaste8.ForeColor = SystemColors.ControlText;
                    }

                    if (numArms > Convert.ToInt32(lblArms.Text))
                    {
                        flgArmsOverload = true;
                        lblUsedArms8.ForeColor = Color.Red;
                    }
                    else
                        lblUsedArms8.ForeColor = SystemColors.ControlText;

                    if (!flgArmsOverload && !flgMultiple && !flgWaste && !flgWidthOverload)
                    {
                        lblViableCombination8.Text = "SI";
                        lblViableCombination8.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblViableCombination8.Text = "NO";
                        lblViableCombination8.ForeColor = Color.Red;
                    }
                    break;
                case 27:
                    lblUsedWidth9.Text = Convert.ToString(Math.Round(usedWidth, 2));
                    lblUnusedWidth9.Text = Convert.ToString(Math.Round((Convert.ToDouble(txtUtilWidth.Text) - Convert.ToDouble(lblUsedWidth9.Text)), 2));
                    lblUsedArms9.Text = Convert.ToString(numArms);
                    lblWaste9.Text = wastePercentage.ToString();


                    if (usedWidth > Convert.ToDouble(txtUtilWidth.Text))
                    {
                        flgWidthOverload = true;
                        lblUsedWidth9.ForeColor = Color.Red;
                        lblWaste9.ForeColor = SystemColors.ControlText;
                    }
                    else if (wastePercentage > Convert.ToDouble(nudWasteAllowed9.Value))
                    {
                        flgWaste = true;
                        lblWaste9.ForeColor = Color.Red;
                        lblUsedWidth9.ForeColor = SystemColors.ControlText;
                    }
                    else
                    {
                        lblUsedWidth9.ForeColor = SystemColors.ControlText;
                        lblWaste9.ForeColor = SystemColors.ControlText;
                    }

                    if (numArms > Convert.ToInt32(lblArms.Text))
                    {
                        flgArmsOverload = true;
                        lblUsedArms9.ForeColor = Color.Red;
                    }
                    else
                        lblUsedArms9.ForeColor = SystemColors.ControlText;

                    if (!flgArmsOverload && !flgMultiple && !flgWaste && !flgWidthOverload)
                    {
                        lblViableCombination9.Text = "SI";
                        lblViableCombination9.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblViableCombination9.Text = "NO";
                        lblViableCombination9.ForeColor = Color.Red;
                    }
                    break;
                case 29:
                    lblUsedWidth10.Text = Convert.ToString(Math.Round(usedWidth, 2));
                    lblUnusedWidth10.Text = Convert.ToString(Math.Round((Convert.ToDouble(txtUtilWidth.Text) - Convert.ToDouble(lblUsedWidth10.Text)), 2));
                    lblUsedArms10.Text = Convert.ToString(numArms);
                    lblWaste10.Text = wastePercentage.ToString();


                    if (usedWidth > Convert.ToDouble(txtUtilWidth.Text))
                    {
                        flgWidthOverload = true;
                        lblUsedWidth10.ForeColor = Color.Red;
                        lblWaste10.ForeColor = SystemColors.ControlText;
                    }
                    else if (wastePercentage > Convert.ToDouble(nudWasteAllowed10.Value))
                    {
                        flgWaste = true;
                        lblWaste10.ForeColor = Color.Red;
                        lblUsedWidth10.ForeColor = SystemColors.ControlText;
                    }
                    else
                    {
                        lblUsedWidth10.ForeColor = SystemColors.ControlText;
                        lblWaste10.ForeColor = SystemColors.ControlText;
                    }

                    if (numArms > Convert.ToInt32(lblArms.Text))
                    {
                        flgArmsOverload = true;
                        lblUsedArms10.ForeColor = Color.Red;
                    }
                    else
                        lblUsedArms10.ForeColor = SystemColors.ControlText;

                    if (!flgArmsOverload && !flgMultiple && !flgWaste && !flgWidthOverload)
                    {
                        lblViableCombination10.Text = "SI";
                        lblViableCombination10.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblViableCombination10.Text = "NO";
                        lblViableCombination10.ForeColor = Color.Red;
                    }
                    break;
            }
        }
        private void calculateRepetitions(int combinationNumber)
        {
            int repetitions = 0;
            int ColIndex = 9 + (2 * combinationNumber);

            switch (ColIndex)
            {
                case 11:
                    repetitions = Convert.ToInt32(nudStops1.Value);
                    break;
                case 13:
                    repetitions = Convert.ToInt32(nudStops2.Value);
                    break;
                case 15:
                    repetitions = Convert.ToInt32(nudStops3.Value);
                    break;
                case 17:
                    repetitions = Convert.ToInt32(nudStops4.Value);
                    break;
                case 19:
                    repetitions = Convert.ToInt32(nudStops5.Value);
                    break;
                case 21:
                    repetitions = Convert.ToInt32(nudStops6.Value);
                    break;
                case 23:
                    repetitions = Convert.ToInt32(nudStops7.Value);
                    break;
                case 25:
                    repetitions = Convert.ToInt32(nudStops8.Value);
                    break;
                case 27:
                    repetitions = Convert.ToInt32(nudStops9.Value);
                    break;
                case 29:
                    repetitions = Convert.ToInt32(nudStops10.Value);
                    break;
            }

            for (int i = 0; i < dgvSalesOrderDetail.Rows.Count - 1; i++)
            {
                dgvSalesOrderDetail.Rows[i].Cells[ColIndex].Value = Math.Round(Convert.ToDouble(dgvSalesOrderDetail.Rows[i].Cells[ColIndex - 1].Value) * Convert.ToDouble(repetitions), 0);

                dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderProgrammedCoils.Index].Value = 0;

                for (int j = 11; j < 30; j = j +2)
                    dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderProgrammedCoils.Index].Value = Convert.ToInt32(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderProgrammedCoils.Index].Value) + Convert.ToInt32(dgvSalesOrderDetail.Rows[i].Cells[j].Value);


                dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderSlopeCoils.Index].Value = Convert.ToInt32(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderCoilsQuantity.Index].Value) - Convert.ToInt32(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderProgrammedCoils.Index].Value);

                if (Convert.ToInt32(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderSlopeCoils.Index].Value) == 0)
                    dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderSlopeCoils.Index].Style.ForeColor = Color.LightGreen;
                else if (Convert.ToInt32(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderSlopeCoils.Index].Value) < 0)
                    dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderSlopeCoils.Index].Style.ForeColor = Color.Red;
                else
                    dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderSlopeCoils.Index].Style.ForeColor = SystemColors.ControlText;
            }

            calculateCombination(combinationNumber);
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

        }

        private void dgvCast_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                objCast.load(Convert.ToInt32(dgvCast.Rows[e.RowIndex].Cells[clmCodsec.Index].Value));
                lblFilmName.Text = "[" + objCast.code + "] " + objCast.name;

                fillSalesOrderList();

                generateResume();

                tbcCuttingOrder.SelectedIndex = 1;
                cmbCutter.Focus();
                chkLoadEquivalentFilm.Checked = false;
                chkAllowEquivalentFilm1.Checked = false;
            }
        }

        private void dgvSalesOrderDetail_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 10:
                case 12:
                case 14:
                case 16:
                case 18:
                case 20:
                case 22:
                case 24:
                case 26:
                case 28:
                    if (cmbCutter.SelectedIndex >= 0)
                    {
                        if (clsGlobal.isNumeric(dgvSalesOrderDetail.CurrentCell.EditedFormattedValue.ToString()) == false && dgvSalesOrderDetail.CurrentCell.EditedFormattedValue.ToString() != "")
                        {
                            MessageBox.Show("El valor debe ser Numerico");
                        }
                        else if (dgvSalesOrderDetail.CurrentCell.EditedFormattedValue.ToString() == "")
                        { 
                            dgvSalesOrderDetail.CancelEdit();                        
                        }
                        else
                        {
                            calculateTotalValue(e.RowIndex, e.ColumnIndex, Convert.ToDouble(dgvSalesOrderDetail.CurrentCell.EditedFormattedValue));
                        }
                    }
                    else
                    {
                        if (dgvSalesOrderDetail.CurrentCell.Value != null)
                        {
                            if (dgvSalesOrderDetail.CurrentCell.EditedFormattedValue.ToString() != dgvSalesOrderDetail.CurrentCell.Value.ToString())
                                MessageBox.Show("Por favor, seleccione primero en que cortadora se realizará el corte.");
                            dgvSalesOrderDetail.CancelEdit();
                        }
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

                lblUsedWidth1.Text = "0";
                lblUsedArms1.Text = "0";
                lblUnusedWidth1.Text = lblUtilWidth.Text;
                lblViableCombination1.Text = "NO";
                lblViableCombination1.ForeColor = Color.Red;

                lblUsedWidth2.Text = "0";
                lblUsedArms2.Text = "0";
                lblUnusedWidth2.Text = lblUtilWidth.Text;
                lblViableCombination2.Text = "NO";
                lblViableCombination2.ForeColor = Color.Red;

                lblUsedWidth3.Text = "0";
                lblUsedArms3.Text = "0";
                lblUnusedWidth3.Text = lblUtilWidth.Text;
                lblViableCombination3.Text = "NO";
                lblViableCombination3.ForeColor = Color.Red;

                lblUsedWidth4.Text = "0";
                lblUsedArms4.Text = "0";
                lblUnusedWidth4.Text = lblUtilWidth.Text;
                lblViableCombination4.Text = "NO";
                lblViableCombination4.ForeColor = Color.Red;

                lblUsedWidth5.Text = "0";
                lblUsedArms5.Text = "0";
                lblUnusedWidth5.Text = lblUtilWidth.Text;
                lblViableCombination5.Text = "NO";
                lblViableCombination5.ForeColor = Color.Red;

                lblUsedWidth6.Text = "0";
                lblUsedArms6.Text = "0";
                lblUnusedWidth6.Text = lblUtilWidth.Text;
                lblViableCombination6.Text = "NO";
                lblViableCombination6.ForeColor = Color.Red;

                lblUsedWidth7.Text = "0";
                lblUsedArms7.Text = "0";
                lblUnusedWidth7.Text = lblUtilWidth.Text;
                lblViableCombination7.Text = "NO";
                lblViableCombination7.ForeColor = Color.Red;

                lblUsedWidth8.Text = "0";
                lblUsedArms8.Text = "0";
                lblUnusedWidth8.Text = lblUtilWidth.Text;
                lblViableCombination8.Text = "NO";
                lblViableCombination8.ForeColor = Color.Red;

                lblUsedWidth9.Text = "0";
                lblUsedArms9.Text = "0";
                lblUnusedWidth9.Text = lblUtilWidth.Text;
                lblViableCombination9.Text = "NO";
                lblViableCombination9.ForeColor = Color.Red;

                lblUsedWidth10.Text = "0";
                lblUsedArms10.Text = "0";
                lblUnusedWidth10.Text = lblUtilWidth.Text;
                lblViableCombination10.Text = "NO";
                lblViableCombination10.ForeColor = Color.Red;
            }
        }

        private void dgvSalesOrderDetail_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 10:
                case 12:
                case 14:
                case 16:
                case 18:
                case 20:
                case 22:
                case 24:
                case 26:
                case 28:
                    if (cmbCutter.SelectedIndex >= 0)
                    {
                        int combinationNumber = (e.ColumnIndex - 8) / 2;
                        calculateCombination(combinationNumber);
                    }
                    break;
            }
        }

        private void nudWasteAllowed_ValueChanged(object sender, EventArgs e)
        {
            calculateCombination();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            for (int comb = 10; comb < 29; comb = comb + 2)
            {
                int repetitions = 0;
                string strViability = "";
                int usedWidth = 0;
                int armsUsed = 0;
                double waste = 0;
                bool allowEquivalentFilm = false;
                string combinationNotes = "";

                switch (comb)
                {
                    case 10:
                        repetitions = Convert.ToInt32(nudStops1.Value);
                        strViability = lblViableCombination1.Text;
                        usedWidth = Convert.ToInt32(lblUsedWidth1.Text);
                        armsUsed = Convert.ToInt32(lblUsedArms1.Text);
                        waste = Convert.ToDouble(lblWaste1.Text);
                        allowEquivalentFilm = chkAllowEquivalentFilm1.Checked;
                        combinationNotes = btnObservations1.Tag.ToString();
                        
                        break;
                    case 12:
                        repetitions = Convert.ToInt32(nudStops2.Value);
                        strViability = lblViableCombination2.Text;
                        usedWidth = Convert.ToInt32(lblUsedWidth2.Text);
                        armsUsed = Convert.ToInt32(lblUsedArms2.Text);
                        waste = Convert.ToDouble(lblWaste2.Text);
                        allowEquivalentFilm = chkAllowEquivalentFilm2.Checked;
                        combinationNotes = btnObservations2.Tag.ToString();
                        
                        break;
                    case 14:
                        repetitions = Convert.ToInt32(nudStops3.Value);
                        strViability = lblViableCombination3.Text;
                        usedWidth = Convert.ToInt32(lblUsedWidth3.Text);
                        armsUsed = Convert.ToInt32(lblUsedArms3.Text);
                        waste = Convert.ToDouble(lblWaste3.Text);
                        allowEquivalentFilm = chkAllowEquivalentFilm3.Checked;
                        combinationNotes = btnObservations3.Tag.ToString();
                        
                        break;
                    case 16:
                        repetitions = Convert.ToInt32(nudStops4.Value);
                        strViability = lblViableCombination4.Text;
                        usedWidth = Convert.ToInt32(lblUsedWidth4.Text);
                        armsUsed = Convert.ToInt32(lblUsedArms4.Text);
                        waste = Convert.ToDouble(lblWaste4.Text);
                        allowEquivalentFilm = chkAllowEquivalentFilm4.Checked;
                        combinationNotes = btnObservations4.Tag.ToString();
                        
                        break;
                    case 18:
                        repetitions = Convert.ToInt32(nudStops5.Value);
                        strViability = lblViableCombination5.Text;
                        usedWidth = Convert.ToInt32(lblUsedWidth5.Text);
                        armsUsed = Convert.ToInt32(lblUsedArms5.Text);
                        waste = Convert.ToDouble(lblWaste5.Text);
                        allowEquivalentFilm = chkAllowEquivalentFilm5.Checked;
                        combinationNotes = btnObservations5.Tag.ToString();
                        
                        break;
                    case 20:
                        repetitions = Convert.ToInt32(nudStops6.Value);
                        strViability = lblViableCombination6.Text;
                        usedWidth = Convert.ToInt32(lblUsedWidth6.Text);
                        armsUsed = Convert.ToInt32(lblUsedArms6.Text);
                        waste = Convert.ToDouble(lblWaste6.Text);
                        allowEquivalentFilm = chkAllowEquivalentFilm6.Checked;
                        combinationNotes = btnObservations6.Tag.ToString();
                        
                        break;
                    case 22:
                        repetitions = Convert.ToInt32(nudStops7.Value);
                        strViability = lblViableCombination7.Text;
                        usedWidth = Convert.ToInt32(lblUsedWidth7.Text);
                        armsUsed = Convert.ToInt32(lblUsedArms7.Text);
                        waste = Convert.ToDouble(lblWaste7.Text);
                        allowEquivalentFilm = chkAllowEquivalentFilm7.Checked;
                        combinationNotes = btnObservations7.Tag.ToString();
                        
                        break;
                    case 24:
                        repetitions = Convert.ToInt32(nudStops8.Value);
                        strViability = lblViableCombination8.Text;
                        usedWidth = Convert.ToInt32(lblUsedWidth8.Text);
                        armsUsed = Convert.ToInt32(lblUsedArms8.Text);
                        waste = Convert.ToDouble(lblWaste8.Text);
                        allowEquivalentFilm = chkAllowEquivalentFilm8.Checked;
                        combinationNotes = btnObservations8.Tag.ToString();
                        
                        break;
                    case 26:
                        repetitions = Convert.ToInt32(nudStops9.Value);
                        strViability = lblViableCombination9.Text;
                        usedWidth = Convert.ToInt32(lblUsedWidth9.Text);
                        armsUsed = Convert.ToInt32(lblUsedArms9.Text);
                        waste = Convert.ToDouble(lblWaste9.Text);
                        allowEquivalentFilm = chkAllowEquivalentFilm9.Checked;
                        combinationNotes = btnObservations9.Tag.ToString();
                        
                        break;
                    case 28:
                        repetitions = Convert.ToInt32(nudStops10.Value);
                        strViability = lblViableCombination10.Text;
                        usedWidth = Convert.ToInt32(lblUsedWidth10.Text);
                        armsUsed = Convert.ToInt32(lblUsedArms10.Text);
                        waste = Convert.ToDouble(lblWaste10.Text);
                        allowEquivalentFilm = chkAllowEquivalentFilm10.Checked;
                        combinationNotes = btnObservations10.Tag.ToString();
                        
                        break;
                }

                if (strViability == "SI")
                {
                    lstCuttingOrders.Add(new clsCuttingOrder());

                    int pos = lstCuttingOrders.Count - 1;
                    lstCuttingOrders[pos].fkMachine = ((clsMachine)cmbCutter.SelectedItem).codsec;
                    lstCuttingOrders[pos].machineName = ((clsMachine)cmbCutter.SelectedItem).Cutter.name;
                    lstCuttingOrders[pos].fkStatus = (clsStatus.getStatusByStatusGroupNameAndStatusName("Ordenes de corte", "Borrador")).codsec;
                    lstCuttingOrders[pos].statusName = (clsStatus.getStatusByStatusGroupNameAndStatusName("Ordenes de corte", "Borrador")).name;
                    lstCuttingOrders[pos].fkCast = objCast.codsec;
                    lstCuttingOrders[pos].castName = objCast.name;
                    lstCuttingOrders[pos].positions = armsUsed;
                    lstCuttingOrders[pos].repetitions = repetitions;

                    if (programmedWeigth.ToString() != "NaN" && programmedWeigth.ToString() != "NeuN")
                        lstCuttingOrders[pos].programmedWeight = programmedWeigth;
                    else
                        lstCuttingOrders[pos].programmedWeight = 0;

                    lstCuttingOrders[pos].programmedLength = 0;
                    lstCuttingOrders[pos].createdDate = DateTime.Now;
                    lstCuttingOrders[pos].modifiedDate = DateTime.Now;
                    lstCuttingOrders[pos].createdBy = clsGlobal.LoggedUser.codsec;
                    lstCuttingOrders[pos].modifiedBy = clsGlobal.LoggedUser.codsec;
                    lstCuttingOrders[pos].notes = "";
                    lstCuttingOrders[pos].allowEquivalentFilm = allowEquivalentFilm;

                    int coilPosition = 0;
                    int combinationColumn = comb + 1;

                    for (int i = 0; i < dgvSalesOrderDetail.Rows.Count - 1; i++)
                    {
                        if (Convert.ToInt32(dgvSalesOrderDetail.Rows[i].Cells[comb].Value) != 0)
                        {

                            for (int j = 0; j < Convert.ToInt32(dgvSalesOrderDetail.Rows[i].Cells[comb].Value); j++)
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
                                lstCuttingOrders[pos].lstCuttingOrderDetail[lstCuttingOrders[pos].lstCuttingOrderDetail.Count - 1].programmedLength = clsParameters.getAproxLengthByWidthAndWeigth(objSelectedProduct.fkCast, objSelectedProduct.fkDiameter, objSelectedProduct.fkCore);
                                lstCuttingOrders[pos].lstCuttingOrderDetail[lstCuttingOrders[pos].lstCuttingOrderDetail.Count - 1].programmedWeight = Convert.ToDouble(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderWeigth.Index].Value) / Convert.ToInt32(dgvSalesOrderDetail.Rows[i].Cells[clmSalesOrderTotalOrderCoils.Index].Value);
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
                }
            }

            generateResume();
            cmbCutter.SelectedIndex = -1;
            txtUtilWidth.Text = "0";
            fillSalesOrderList();
            tbcCuttingOrder.SelectedIndex = 2;
            chkAllowEquivalentFilm1.Checked = false;
        }


        private void save(object sender, EventArgs e)
        {
            lstCuttingOrders[Convert.ToInt32(((Button)sender).Tag)].fkStatus = (clsStatus.getStatusByStatusGroupNameAndStatusName("Ordenes de corte", "Programada")).codsec;
            lstCuttingOrders[Convert.ToInt32(((Button)sender).Tag)].statusName = "Programada";
            lstCuttingOrders[Convert.ToInt32(((Button)sender).Tag)].save();
            generateResume();

            loadResumeLayout(Convert.ToInt32(dgvCuttingOrder.Rows[Convert.ToInt32(((Button)sender).Tag)].Cells[clmCodsec.Index].Value), Convert.ToInt32(((Button)sender).Tag));


            fillSalesOrderList();
            cmbCutter.Focus();

        }
        private void changeStops(object sender, EventArgs e)
        {
            if (nudStopsNumber.Visible == false)
            {
                nudStopsNumber.Visible = true;
                lblStopsNumber.Visible = false;
                btnRefresh.Image = global::BPS.Lite.Properties.Resources.disk;
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
                cmbCutter.Focus();
                nudStopsNumber.Visible = false;
                lblStopsNumber.Visible = true;
                btnRefresh.Image = global::BPS.Lite.Properties.Resources.arrow_refresh;
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
            cmbCutter.Focus();
        }

        private void btnFilterSalesOrder_Click(object sender, EventArgs e)
        {
            fillSalesOrderList();
        }

        private void btnClearFilterSalesOrder_Click(object sender, EventArgs e)
        {
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
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        calculateCombination(i);
                    }
                }
            }
            else
            {
                MessageBox.Show("El valor debe ser Numerico");
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
                //frmProductList winProductList = new frmProductList(this, Convert.ToInt32(dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderProductCodsec.Index].Value), true);    
                //winProductList.ShowDialog(this);

                objSelectedProduct.load(selectedProductCodsec);

                if (objSelectedProduct.codsec > 0)
                {
                    dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderProduct.Index].Value = objSelectedProduct.code.Replace("-", "");
                    dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderChangeProduct.Index].Value = global::BPS.Lite.Properties.Resources.arrow_refresh;

                    dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderTotalOrderCoils.Index].Value = clsParameters.getCoilsNumberByWidthAndWeigth(objSelectedProduct.fkBopp, objSelectedProduct.fkCast, objSelectedProduct.fkDiameter, objSelectedProduct.fkCore, objSelectedProduct.width, (Convert.ToDouble(dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderWeigth.Index].Value)));
                    dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderCoilsQuantity.Index].Value = clsParameters.getCoilsNumberByWidthAndWeigth(objSelectedProduct.fkBopp, objSelectedProduct.fkCast, objSelectedProduct.fkDiameter, objSelectedProduct.fkCore, objSelectedProduct.width, ((Convert.ToDouble(dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderWeigth.Index].Value) - lstSalesOrderDetail[Convert.ToInt32(dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderDetailIndex.Index].Value)].programmedWeigth)));

                    if (Convert.ToDouble(dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderCoilsQuantity.Index].Value) < 0)
                        dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderCoilsQuantity.Index].Value = 0;

                    dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderWidth.Index].Value = Convert.ToString(Math.Round(objSelectedProduct.width));
                    dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderCoreDiameter.Index].Value = objSelectedProduct.DiameterAbbreviation + objSelectedProduct.CoreValue.ToString();
                    dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderCoilsToCut1.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderProgrammedCoils.Index].Value = 0;

                    for (int j = 11; j < 30; j = j +2)
                        dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderProgrammedCoils.Index].Value = Convert.ToInt32(dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderProgrammedCoils.Index].Value) + Convert.ToInt32(dgvSalesOrderDetail.Rows[e.RowIndex].Cells[j].Value);


                    dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderSlopeCoils.Index].Value = Convert.ToInt32(dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderCoilsQuantity.Index].Value) - Convert.ToInt32(dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderProgrammedCoils.Index].Value);

                    if (Convert.ToInt32(dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderSlopeCoils.Index].Value) == 0)
                        dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderSlopeCoils.Index].Style.ForeColor = Color.LightGreen;
                    else if (Convert.ToInt32(dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderSlopeCoils.Index].Value) < 0)
                        dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderSlopeCoils.Index].Style.ForeColor = Color.Red;
                    else
                        dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderSlopeCoils.Index].Style.ForeColor = SystemColors.ControlText;

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

        private void txtCastCode_TextChanged(object sender, EventArgs e)
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
                    dgvSalesOrderVisibility.Rows[e.RowIndex].Cells[clmSOVisible.Index].Value = global::BPS.Lite.Properties.Resources.clear;
                    chkSelectAll.Checked = false;
                }
                else
                {
                    dgvSalesOrderVisibility.Rows[e.RowIndex].Cells[clmSOFlagVisible.Index].Value = 1;
                    dgvSalesOrderVisibility.Rows[e.RowIndex].Cells[clmSOVisible.Index].Value = global::BPS.Lite.Properties.Resources.eye;
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
                    dgvSalesOrderVisibility.Rows[i].Cells[clmSOVisible.Index].Value = global::BPS.Lite.Properties.Resources.eye;
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
                    dgvSalesOrderVisibility.Rows[i].Cells[clmSOVisible.Index].Value = global::BPS.Lite.Properties.Resources.clear;
                }

                fillDatagrid();
                chkSelectAll.Checked = false;
            }
        }

        private void nudStops_ValueChanged(object sender, EventArgs e)
        {
            calculateRepetitions(1);
        }

        private void nudStops2_ValueChanged(object sender, EventArgs e)
        {
            calculateRepetitions(2);
        }

        private void nudStops3_ValueChanged(object sender, EventArgs e)
        {
            calculateRepetitions(3);
        }

        private void nudStops4_ValueChanged(object sender, EventArgs e)
        {
            calculateRepetitions(4);
        }

        private void nudStops5_ValueChanged(object sender, EventArgs e)
        {
            calculateRepetitions(5);
        }

        private void nudStops6_ValueChanged(object sender, EventArgs e)
        {
            calculateRepetitions(6);
        }

        private void nudStops7_ValueChanged(object sender, EventArgs e)
        {
            calculateRepetitions(7);
        }

        private void nudStops8_ValueChanged(object sender, EventArgs e)
        {
            calculateRepetitions(8);
        }

        private void nudStops9_ValueChanged(object sender, EventArgs e)
        {
            calculateRepetitions(9);
        }

        private void nudStops10_ValueChanged(object sender, EventArgs e)
        {
            calculateRepetitions(10);
        }

        private void btnObservations1_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Tag != null)
                Notes = ((Button)sender).Tag.ToString();
            else
                Notes = "";
            frmCuttingOrderNotes winCuttingOrderNotes = new frmCuttingOrderNotes(this);
            winCuttingOrderNotes.StartPosition = FormStartPosition.CenterScreen;
            winCuttingOrderNotes.ShowDialog(this);
            ((Button)sender).Tag = Notes;

            if (Notes != "")
            {
                ttpCuttingOrder.SetToolTip((Button)sender, Notes);
                ((Button)sender).Image = global::BPS.Lite.Properties.Resources.textOK;
            }
            else
            {
                ttpCuttingOrder.SetToolTip((Button)sender, "-- Sin observaciones --");
                ((Button)sender).Image = global::BPS.Lite.Properties.Resources.textNo;
            }
        }

        private void btnExecuteCombinatios_Click(object sender, EventArgs e)
        {

        }

        private void dgvSalesOrderDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmSalesOrderCustomer.Index || e.ColumnIndex == clmSalesOrderNumber.Index)
            {
                objSelectedProduct = new clsProduct();
                selectedProductCodsec = 0;
                frmProductList winProductList = new frmProductList(this, objCast.codsec);
                winProductList.ShowDialog(this);
                //frmProductListShort winProductList = new frmProductListShort(this, objCast.codsec);
                //winProductList.ShowDialog(this);

                if (selectedProductCodsec != 0)
                {
                    objSelectedProduct.load(selectedProductCodsec);
                    dgvSalesOrderDetail.Rows.Add();

                    int j = dgvSalesOrderDetail.Rows.Count - 2;

                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCodsec.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCustomer.Index].Value = "STOCK";
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderNumber.Index].Value = "----";
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderProduct.Index].Value = objSelectedProduct.code;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderChangeProduct.Index].Value = global::BPS.Lite.Properties.Resources.clear;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderWeigth.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderTotalOrderCoils.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCoilsQuantity.Index].Value = 0;

                    //if (lstSalesOrderDetailItems[i].pendingCoils < 0)
                    //    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCoilsQuantity.Index].Value = 0;

                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderWidth.Index].Value = objSelectedProduct.width;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCoreDiameter.Index].Value = objSelectedProduct.DiameterAbbreviation + objSelectedProduct.CoreValue.ToString();
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCoilsToCut1.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCoilsToCut2.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCoilsToCut3.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCoilsToCut4.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCoilsToCut5.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCoilsToCut6.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCoilsToCut7.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCoilsToCut8.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCoilsToCut9.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCoilsToCut10.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderTotalCoils1.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderTotalCoils2.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderTotalCoils3.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderTotalCoils4.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderTotalCoils5.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderTotalCoils6.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderTotalCoils7.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderTotalCoils8.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderTotalCoils9.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderTotalCoils10.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderProgrammedCoils.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderSlopeCoils.Index].Value = 0;

                    if (Convert.ToInt32(dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderSlopeCoils.Index].Value) == 0)
                        dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderSlopeCoils.Index].Style.ForeColor = Color.LightGreen;
                    else if (Convert.ToInt32(dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderSlopeCoils.Index].Value) < 0)
                        dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderSlopeCoils.Index].Style.ForeColor = Color.Red;
                    else
                        dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderSlopeCoils.Index].Style.ForeColor = SystemColors.ControlText;

                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderProductCodsec.Index].Value = objSelectedProduct.codsec;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderOriginalProductCodsec.Index].Value = objSelectedProduct.codsec;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderIsEquivalentFilm.Index].Value = false;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderDetailIndex.Index].Value = j;

                    
                    //for (int k = 0; k < dgvSalesOrderDetail.ColumnCount; k++)
                    //    dgvSalesOrderDetail.Rows[j].Cells[k].Style.BackColor = Color.LightGreen;
                }
            }
        }

        private void frmCuttingOrderMultipleCast_SizeChanged(object sender, EventArgs e)
        {
            dgvSalesOrderDetail.Height = lblUsedWidth1.Top - 17;
        }

        private void chkLoadEquivalentFilm_CheckedChanged(object sender, EventArgs e)
        {
            fillSalesOrderList();
        }
    }
}