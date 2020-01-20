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
    public partial class frmSecundaryCuttingOrderMultiple : Form
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
        string filmType = "";
        clsPlant plant = new clsPlant();

        public string Notes = "";
        public string TPallet = "";

        public frmSecundaryCuttingOrderMultiple()
        {
            InitializeComponent();
            dgvSalesOrderDetail.Height = lblProduct1.Top - 17;
            List<clsPlant> plist = clsPlant.getList();
            for (int i = 0; i < plist.Count; i++)
            {
                cmbPlants.Items.Add(plist[i].name);
            }
        }

        public void fillFilmList()
        {
            dgvBopp.Rows.Clear();

            List<clsBopp> lstBopp = new List<clsBopp>();
            List<clsCast> lstCast = new List<clsCast>();
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
                dgvBopp.Rows[i].Cells[clmTotalWeightFilms.Index].Value = Convert.ToString(Math.Round(lstBopp[i].salesOrderQuantity, 2));
                dgvBopp.Rows[i].Cells[clmMainCoilQuantity.Index].Value = Convert.ToString(Math.Round(lstBopp[i].mainCoilQuantity, 2));
            }

            dgvCast.Rows.Clear();

            if (txtCastCode.Text == "")
                lstCast = clsCast.getSimplifiedListWithQuantities();
            else
            {
                lstFilter = new List<clsFilter>();
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
            lstCuttingOrders = clsCuttingOrder.getActiveSecundaryCuttingList();
            lstGroupBoxResume.Clear();

            dgvCuttingOrder.Rows.Clear();
            //grpbCuttingOrderDetail.Controls.Clear();
            grpbCombination.Controls.Clear();

            for (int i = 0; i < lstCuttingOrders.Count; i++)
            {
                dgvCuttingOrder.Rows.Add();
                dgvCuttingOrder.Rows[i].Cells[clmCodsec.Index].Value = lstCuttingOrders[i].codsec;
                dgvCuttingOrder.Rows[i].Cells[clmMachineName.Index].Value = lstCuttingOrders[i].machineName;
                dgvCuttingOrder.Rows[i].Cells[clmFilmName.Index].Value = "[" + lstCuttingOrders[i].productCode + "] " + lstCuttingOrders[i].productName;
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
            clsCuttingOrder objCuttingOrder = new clsCuttingOrder(cuttingOrderCodsec);
            clsMachine objMachine = new clsMachine();
            clsProduct objProduct = new clsProduct(objCuttingOrder.fkProduct);
            List<Label> lstLblCoils = new List<Label>();
            List<CheckBox> lstChkSingleFace = new List<CheckBox>();
            List<CheckBox> lstPalletType = new List<CheckBox>();
            objMachine.load(objCuttingOrder.fkMachine, "Cutter");
            int relativePosition = 16;
            int wasteSize = Convert.ToInt32(objProduct.width);
            double usedWidth = 0;

            lblCutterName.Text = objCuttingOrder.machineName;
            lblFilmNameInDetail.Text = "";
            lblStopsNumber.Text = objCuttingOrder.repetitions.ToString();
            nudStopsNumber.Value = objCuttingOrder.repetitions;
            lblCoilNumber.Text = objCuttingOrder.positions.ToString();

            for (int i = 0; i < objCuttingOrder.lstCuttingOrderDetail.Count; i++)
                wasteSize -= Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width);

            lblWasteDraw1.BackColor = System.Drawing.Color.DimGray;
            lblWasteDraw1.Size = new System.Drawing.Size(Convert.ToInt32(clsCuttingOrderResume.getProportinalWidth(Convert.ToInt32(objProduct.width), wasteSize, 1020) / 2), 66);
            lblWasteDraw1.Location = new System.Drawing.Point(relativePosition, 21);

            grpbCombination.Controls.Clear();

            grpbCombination.Text = "Orden de corte #" + objCuttingOrder.number.ToString();
            grpbCombination.Controls.Add(lblWasteDraw1);

            relativePosition += Convert.ToInt32(clsCuttingOrderResume.getProportinalWidth(Convert.ToInt32(objProduct.width), wasteSize, 1020) / 2);

            for (int i = 0; i < objCuttingOrder.lstCuttingOrderDetail.Count; i++)
            {
                lstLblCoils.Add(new Label());
                lstLblCoils[i].BackColor = clsGlobal.getColorByPosition(i, objCuttingOrder.lstCuttingOrderDetail.Count);
                lstLblCoils[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                lstLblCoils[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lstLblCoils[i].Location = new System.Drawing.Point(relativePosition, 21);
                lstLblCoils[i].Name = "lblCoil" + i.ToString();
                lstLblCoils[i].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(Convert.ToInt32(objProduct.width), Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width), 1020), 66);
                lstLblCoils[i].TabIndex = 0;
                if (objCuttingOrder.lstCuttingOrderDetail[i].salesOrderNumber != "")
                {
                    //lstLblCoils[i].Text = "Orden  : " + objCuttingOrder.lstCuttingOrderDetail[i].salesOrderNumber + "\r\nCliente : " + (new clsSalesOrder(new clsSalesOrderDetail(objCuttingOrder.lstCuttingOrderDetail[i].fkSalesOrderDetail).fkSalesOrder).EntityName) + "\r\nAncho : " + Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width).ToString() + "mm\r\nCore     : " + objCuttingOrder.lstCuttingOrderDetail[i].product.CoreValue.ToString() + "\"";
                    lstLblCoils[i].Text = "Orden  : " + objCuttingOrder.lstCuttingOrderDetail[i].salesOrderNumber + "\r\nCliente : " + clsCuttingOrderDetail.getSalesOrderDetailCustomer(objCuttingOrder.lstCuttingOrderDetail[i].codsec) + "\r\nAncho : " + Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width).ToString() + "mm\r\nCore     : " + objCuttingOrder.lstCuttingOrderDetail[i].product.CoreValue.ToString() + "\"";
                }
                else
                    lstLblCoils[i].Text = "Orden  : ----\r\nCliente : STOCK\r\nAncho : " + Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width).ToString() + "mm\r\nCore     : " + objCuttingOrder.lstCuttingOrderDetail[i].product.CoreValue.ToString() + "\"";
                lstLblCoils[i].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                usedWidth += Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width);

                grpbCombination.Controls.Add(lstLblCoils[i]);

                lstChkSingleFace.Add(new CheckBox());
                lstChkSingleFace[i].AutoSize = true;
                lstChkSingleFace[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lstChkSingleFace[i].Location = new System.Drawing.Point(relativePosition, 90);
                lstChkSingleFace[i].Name = "chkSingleFace" + i.ToString();
                lstChkSingleFace[i].Size = new System.Drawing.Size(81, 17);
                lstChkSingleFace[i].TabIndex = 10;
                lstChkSingleFace[i].Text = "Single Face";
                lstChkSingleFace[i].Tag = objCuttingOrder.lstCuttingOrderDetail[i].codsec;
                lstChkSingleFace[i].UseVisualStyleBackColor = true;
                lstChkSingleFace[i].Checked = objCuttingOrder.lstCuttingOrderDetail[i].useSingleFace;

                grpbCombination.Controls.Add(lstChkSingleFace[i]);

                lstPalletType.Add(new CheckBox());
                lstPalletType[i].AutoSize = true;
                lstPalletType[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lstPalletType[i].Location = new System.Drawing.Point(relativePosition, 108);
                lstPalletType[i].Name = "chkPalletType" + i.ToString();
                lstPalletType[i].Size = new System.Drawing.Size(81, 17);
                lstPalletType[i].TabIndex = 10;
                lstPalletType[i].Text = ((objCuttingOrder.lstCuttingOrderDetail[i].pallet) == "") ? "TPallet  -----  " : "TPallet " + objCuttingOrder.lstCuttingOrderDetail[i].pallet;
                lstPalletType[i].Tag = objCuttingOrder.lstCuttingOrderDetail[i].codsec;
                lstPalletType[i].UseVisualStyleBackColor = true;
                lstPalletType[i].Checked = ((objCuttingOrder.lstCuttingOrderDetail[i].pallet) == "") ? false : true;

                grpbCombination.Controls.Add(lstPalletType[i]);

                relativePosition += clsCuttingOrderResume.getProportinalWidth(Convert.ToInt32(objProduct.width), Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width), 1020);
            }

            lblWasteDraw2.BackColor = System.Drawing.Color.DimGray;
            lblWasteDraw2.Size = new System.Drawing.Size(Convert.ToInt32(clsCuttingOrderResume.getProportinalWidth(Convert.ToInt32(objProduct.width), wasteSize, 1020) / 2), 66);
            lblWasteDraw2.Location = new System.Drawing.Point(relativePosition, 21);
            grpbCombination.Controls.Add(lblWasteDraw2);

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
            lblWasteInDetail.Text = Convert.ToString(Math.Round(((Convert.ToInt32(objProduct.width) - usedWidth) * 100 / Convert.ToInt32(objProduct.width)), 2));
            lblFilmNameInDetail.Text = objCuttingOrder.productCode;
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
                {
                    CheckBox test = new CheckBox();
                    test.Text = ((CheckBox)grpbCombination.Controls[j]).Text.ToString();
                    if (test.Text.ToString() == "Single Face")
                    {
                        ((CheckBox)grpbCombination.Controls[j]).CheckedChanged += new System.EventHandler(changeSingleFaceStatus);
                    }
                    else
                    {
                        ((CheckBox)grpbCombination.Controls[j]).CheckedChanged += new System.EventHandler(changePalletStatus);
                    }
                    //if (((CheckBox)grpbCombination.Controls[j].Text.ToString()) == "Single Face")
                    //((CheckBox)grpbCombination.Controls[j]).CheckedChanged += new System.EventHandler(changeSingleFaceStatus);
                }
            }

            grpbCuttingOrderDetail.Visible = true;
        }

        private void fillSalesOrderList(string filmType)
        {
            if (filmType != "")
            {
                if (filmType == "Bopp")
                {
                    //lstSalesOrderDetail = clsSalesOrderDetail.getCompleteListByBoppFilm(Convert.ToInt32(Convert.ToInt32(dgvBopp.SelectedRows[0].Cells[clmCodsec.Index].Value)));
                    if (plant.codsec != 0 && cmbPlants.SelectedIndex != -1)
                    {
                        lstSalesOrderDetail = clsSalesOrderDetail.getCompleteListByBoppFilmAndPlant(Convert.ToInt32(dgvBopp.SelectedRows[0].Cells[clmCodsec.Index].Value), plant.codsec);
                    }
                    else
                    {
                        lstSalesOrderDetail = clsSalesOrderDetail.getCompleteListByBoppFilmAndPlant(Convert.ToInt32(dgvBopp.SelectedRows[0].Cells[clmCodsec.Index].Value), 3);
                    }

                    if (chkLoadEquivalentFilm.Checked == true)
                    {
                        if (plant.codsec != 0 && cmbPlants.SelectedIndex != -1)
                        {
                            lstEquivalentSalesOrderDetail = clsSalesOrderDetail.getCompleteListByBoppEquivalentFilmAndPlant(Convert.ToInt32(dgvBopp.SelectedRows[0].Cells[clmCodsec.Index].Value), plant.codsec);
                        }
                        else
                        {
                            lstEquivalentSalesOrderDetail = clsSalesOrderDetail.getCompleteListByBoppEquivalentFilmAndPlant(Convert.ToInt32(dgvBopp.SelectedRows[0].Cells[clmCodsec.Index].Value), 3);
                        }
                    }
                    else
                        lstEquivalentSalesOrderDetail = new List<clsSalesOrderDetail>();
                }    
                else
                {
                    if (plant.codsec != 0 && cmbPlants.SelectedIndex != -1)
                    {
                        lstSalesOrderDetail = clsSalesOrderDetail.getCompleteListByCastFilmAndPlant(Convert.ToInt32(dgvCast.SelectedRows[0].Cells[clmCodsec.Index].Value), plant.codsec);
                    }
                    else
                    {
                        lstSalesOrderDetail = clsSalesOrderDetail.getCompleteListByCastFilmAndPlant(Convert.ToInt32(dgvCast.SelectedRows[0].Cells[clmCodsec.Index].Value), 3);
                    }
                    if (chkLoadEquivalentFilm.Checked == true)
                        lstEquivalentSalesOrderDetail = clsSalesOrderDetail.getCompleteListByCastEquivalentFilmAndPlant(Convert.ToInt32(dgvCast.SelectedRows[0].Cells[clmCodsec.Index].Value),3);
                    else
                        lstEquivalentSalesOrderDetail = new List<clsSalesOrderDetail>();
                }
                    

                

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
                            if (dgvSalesOrderVisibility.Rows[j].Cells[clmSONumber.Index].Value.ToString() == lstSalesOrderDetail[i].codsec.ToString())
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
                            dgvSalesOrderVisibility.Rows[dgvSalesOrderVisibility.Rows.Count - 1].Cells[clmSONumber.Index].Value = lstSalesOrderDetail[i].codsec;
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
                        objSalesOrderDetailItems.number = lstSalesOrderDetail[i].codsec.ToString();
                        objSalesOrderDetailItems.productCode = lstSalesOrderDetail[i].product.code.Replace("-", "");
                        objSalesOrderDetailItems.weight = Math.Round(lstSalesOrderDetail[i].quantity, 2);
                        objSalesOrderDetailItems.totalCoils = Math.Round(clsParameters.getCoilsNumberByWidthAndWeigth(lstSalesOrderDetail[i].product.fkBopp, lstSalesOrderDetail[i].product.fkCast, lstSalesOrderDetail[i].product.fkDiameter, lstSalesOrderDetail[i].product.fkCore, lstSalesOrderDetail[i].product.width, (lstSalesOrderDetail[i].quantity)),1);
                        //objSalesOrderDetailItems.totalCoils = lstSalesOrderDetail[i].coilsToCut;
                        objSalesOrderDetailItems.pendingCoils = Math.Round(clsSalesOrderDetail.getPendingCoilBySalesOrderDetailObj(lstSalesOrderDetail[i]),1);
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
                                if (dgvSalesOrderVisibility.Rows[j].Cells[clmSONumber.Index].Value.ToString() == lstEquivalentSalesOrderDetail[i].codsec.ToString())
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
                                dgvSalesOrderVisibility.Rows[dgvSalesOrderVisibility.Rows.Count - 1].Cells[clmSONumber.Index].Value = lstEquivalentSalesOrderDetail[i].codsec;
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
                            objSalesOrderDetailItems.number = lstEquivalentSalesOrderDetail[i].codsec.ToString();
                            objSalesOrderDetailItems.productCode = lstEquivalentSalesOrderDetail[i].product.code.Replace("-", "");
                            objSalesOrderDetailItems.weight = Math.Round(lstEquivalentSalesOrderDetail[i].quantity, 2);
                            objSalesOrderDetailItems.totalCoils = Math.Round(clsParameters.getCoilsNumberByWidthAndWeigth(lstEquivalentSalesOrderDetail[i].product.fkBopp, lstEquivalentSalesOrderDetail[i].product.fkCast, lstEquivalentSalesOrderDetail[i].product.fkDiameter, lstEquivalentSalesOrderDetail[i].product.fkCore, lstEquivalentSalesOrderDetail[i].product.width, (lstEquivalentSalesOrderDetail[i].quantity)),1);
                            //objSalesOrderDetailItems.totalCoils = lstEquivalentSalesOrderDetail[i].coilsToCut;
                            objSalesOrderDetailItems.pendingCoils = Math.Round(clsSalesOrderDetail.getPendingCoilBySalesOrderDetailObj(lstEquivalentSalesOrderDetail[i]),1);
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
                lblProduct1.Text = "";
                lblProduct1.Tag = null;
                lblCuter1.Text = "";
                lblCuter1.Tag = null;

                lblUsedWidth2.Text = "0";
                lblUsedArms2.Text = "0";
                lblViableCombination2.Text = "NO";
                lblViableCombination2.ForeColor = Color.Red;
                nudStops2.Value = 1;
                nudWasteAllowed2.Value = 10;
                lblWaste2.Text = "0";
                btnObservations2.Tag = "";
                ttpCuttingOrder.SetToolTip(btnObservations2, "-- Sin observaciones --");
                lblProduct2.Text = "";
                lblProduct2.Tag = null;
                lblCuter2.Text = "";
                lblCuter2.Tag = null;

                lblUsedWidth3.Text = "0";
                lblUsedArms3.Text = "0";
                lblViableCombination3.Text = "NO";
                lblViableCombination3.ForeColor = Color.Red;
                nudStops3.Value = 1;
                nudWasteAllowed3.Value = 10;
                lblWaste3.Text = "0";
                btnObservations3.Tag = "";
                ttpCuttingOrder.SetToolTip(btnObservations3, "-- Sin observaciones --");
                lblProduct3.Text = "";
                lblProduct3.Tag = null;
                lblCuter3.Text = "";
                lblCuter3.Tag = null;

                lblUsedWidth4.Text = "0";
                lblUsedArms4.Text = "0";
                lblViableCombination4.Text = "NO";
                lblViableCombination4.ForeColor = Color.Red;
                nudStops4.Value = 1;
                nudWasteAllowed4.Value = 10;
                lblWaste4.Text = "0";
                btnObservations4.Tag = "";
                ttpCuttingOrder.SetToolTip(btnObservations4, "-- Sin observaciones --");
                lblProduct4.Text = "";
                lblProduct4.Tag = null;
                lblCuter4.Text = "";
                lblCuter4.Tag = null;

                lblUsedWidth5.Text = "0";
                lblUsedArms5.Text = "0";
                lblViableCombination5.Text = "NO";
                lblViableCombination5.ForeColor = Color.Red;
                nudStops5.Value = 1;
                nudWasteAllowed5.Value = 10;
                lblWaste5.Text = "0";
                btnObservations5.Tag = "";
                ttpCuttingOrder.SetToolTip(btnObservations5, "-- Sin observaciones --");
                lblProduct5.Text = "";
                lblProduct5.Tag = null;
                lblCuter5.Text = "";
                lblCuter5.Tag = null;

                lblUsedWidth6.Text = "0";
                lblUsedArms6.Text = "0";
                lblViableCombination6.Text = "NO";
                lblViableCombination6.ForeColor = Color.Red;
                nudStops6.Value = 1;
                nudWasteAllowed6.Value = 10;
                lblWaste6.Text = "0";
                btnObservations6.Tag = "";
                ttpCuttingOrder.SetToolTip(btnObservations6, "-- Sin observaciones --");
                lblProduct6.Text = "";
                lblProduct6.Tag = null;
                lblCuter6.Text = "";
                lblCuter6.Tag = null;

                lblUsedWidth7.Text = "0";
                lblUsedArms7.Text = "0";
                lblViableCombination7.Text = "NO";
                lblViableCombination7.ForeColor = Color.Red;
                nudStops7.Value = 1;
                nudWasteAllowed7.Value = 10;
                lblWaste7.Text = "0";
                btnObservations7.Tag = "";
                ttpCuttingOrder.SetToolTip(btnObservations7, "-- Sin observaciones --");
                lblProduct7.Text = "";
                lblProduct7.Tag = null;
                lblCuter7.Text = "";
                lblCuter7.Tag = null;

                lblUsedWidth8.Text = "0";
                lblUsedArms8.Text = "0";
                lblViableCombination8.Text = "NO";
                lblViableCombination8.ForeColor = Color.Red;
                nudStops8.Value = 1;
                nudWasteAllowed8.Value = 10;
                lblWaste8.Text = "0";
                btnObservations8.Tag = "";
                ttpCuttingOrder.SetToolTip(btnObservations8, "-- Sin observaciones --");
                lblProduct8.Text = "";
                lblProduct8.Tag = null;
                lblCuter8.Text = "";
                lblCuter8.Tag = null;

                lblUsedWidth9.Text = "0";
                lblUsedArms9.Text = "0";
                lblViableCombination9.Text = "NO";
                lblViableCombination9.ForeColor = Color.Red;
                nudStops9.Value = 1;
                nudWasteAllowed9.Value = 10;
                lblWaste9.Text = "0";
                btnObservations9.Tag = "";
                ttpCuttingOrder.SetToolTip(btnObservations9, "-- Sin observaciones --");
                lblProduct9.Text = "";
                lblProduct9.Tag = null;
                lblCuter9.Text = "";
                lblCuter9.Tag = null;

                lblUsedWidth10.Text = "0";
                lblUsedArms10.Text = "0";
                lblViableCombination10.Text = "NO";
                lblViableCombination10.ForeColor = Color.Red;
                nudStops10.Value = 1;
                nudWasteAllowed10.Value = 10;
                lblWaste10.Text = "0";
                btnObservations10.Tag = "";
                ttpCuttingOrder.SetToolTip(btnObservations10, "-- Sin observaciones --");
                lblProduct10.Text = "";
                lblProduct10.Tag = null;
                lblCuter10.Text = "";
                lblCuter10.Tag = null;
            }
        }
        private void fillDatagrid()
        {
            List<string> diameters = new List<string>();
            cmbDiameter.Items.Clear();

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

                //if (flgVisible && (lstSalesOrderDetailItems[i].pendingCoils > 0 || (lstSalesOrderDetailItems[i].pendingCoils <= 0 && flgVisible == true)))
                if (flgVisible && (lstSalesOrderDetailItems[i].pendingCoils > 0))
                {
                    dgvSalesOrderDetail.Rows.Add();

                    int j = dgvSalesOrderDetail.Rows.Count - 2;

                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCodsec.Index].Value = lstSalesOrderDetailItems[i].codsec;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCustomer.Index].Value = lstSalesOrderDetailItems[i].entityName;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderNumber.Index].Value = lstSalesOrderDetailItems[i].number;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderProduct.Index].Value = lstSalesOrderDetailItems[i].productCode;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderChangeProduct.Index].Value = global::BPS.Properties.Resources.arrow_refresh;
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

                    if (!diameters.Contains(lstSalesOrderDetailItems[i].coreDiameter))
                        diameters.Add(lstSalesOrderDetailItems[i].coreDiameter);

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

            diameters.Sort();

            for (int i = 0; i < diameters.Count; i++)
            {
                cmbDiameter.Items.Add(diameters[i]);
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

            dgvSalesOrderDetail.Rows[rowIndex].Cells[totalColumnIndex].Value = Math.Round(value * repetitions, 1);
            dgvSalesOrderDetail.Rows[rowIndex].Cells[clmSalesOrderProgrammedCoils.Index].Value = 0;

            for (int j = 11; j < 30; j = j + 2)
                dgvSalesOrderDetail.Rows[rowIndex].Cells[clmSalesOrderProgrammedCoils.Index].Value = Convert.ToInt32(dgvSalesOrderDetail.Rows[rowIndex].Cells[clmSalesOrderProgrammedCoils.Index].Value) + Convert.ToInt32(dgvSalesOrderDetail.Rows[rowIndex].Cells[j].Value);


            dgvSalesOrderDetail.Rows[rowIndex].Cells[clmSalesOrderSlopeCoils.Index].Value = Math.Round(Convert.ToDouble(dgvSalesOrderDetail.Rows[rowIndex].Cells[clmSalesOrderCoilsQuantity.Index].Value) - Convert.ToDouble(dgvSalesOrderDetail.Rows[rowIndex].Cells[clmSalesOrderProgrammedCoils.Index].Value),1);

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
            int arms = 0;
            double widthToCut = 0;

            switch (ColIndex)
            {
                case 11:
                    repetitions = Convert.ToInt32(nudStops1.Value);
                    arms = ((clsMachine)lblCuter1.Tag).Cutter.arms;
                    widthToCut = ((clsProduct)lblProduct1.Tag).width;
                    break;
                case 13:
                    repetitions = Convert.ToInt32(nudStops2.Value);
                    arms = ((clsMachine)lblCuter2.Tag).Cutter.arms;
                    widthToCut = ((clsProduct)lblProduct2.Tag).width;
                    break;
                case 15:
                    repetitions = Convert.ToInt32(nudStops3.Value);
                    arms = ((clsMachine)lblCuter3.Tag).Cutter.arms;
                    widthToCut = ((clsProduct)lblProduct3.Tag).width;
                    break;
                case 17:
                    repetitions = Convert.ToInt32(nudStops4.Value);
                    arms = ((clsMachine)lblCuter4.Tag).Cutter.arms;
                    widthToCut = ((clsProduct)lblProduct4.Tag).width;
                    break;
                case 19:
                    repetitions = Convert.ToInt32(nudStops5.Value);
                    arms = ((clsMachine)lblCuter5.Tag).Cutter.arms;
                    widthToCut = ((clsProduct)lblProduct5.Tag).width;
                    break;
                case 21:
                    repetitions = Convert.ToInt32(nudStops6.Value);
                    arms = ((clsMachine)lblCuter6.Tag).Cutter.arms;
                    widthToCut = ((clsProduct)lblProduct6.Tag).width;
                    break;
                case 23:
                    repetitions = Convert.ToInt32(nudStops7.Value);
                    arms = ((clsMachine)lblCuter7.Tag).Cutter.arms;
                    widthToCut = ((clsProduct)lblProduct7.Tag).width;
                    break;
                case 25:
                    repetitions = Convert.ToInt32(nudStops8.Value);
                    arms = ((clsMachine)lblCuter8.Tag).Cutter.arms;
                    widthToCut = ((clsProduct)lblProduct8.Tag).width;
                    break;
                case 27:
                    repetitions = Convert.ToInt32(nudStops9.Value);
                    arms = ((clsMachine)lblCuter9.Tag).Cutter.arms;
                    widthToCut = ((clsProduct)lblProduct9.Tag).width;
                    break;
                case 29:
                    repetitions = Convert.ToInt32(nudStops10.Value);
                    arms = ((clsMachine)lblCuter10.Tag).Cutter.arms;
                    widthToCut = ((clsProduct)lblProduct10.Tag).width;
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


            switch (ColIndex)
            {
                case 11:
                    if (lblCuter1.Tag != null)
                        wastePercentage = Math.Round(((widthToCut - usedWidth) * 100) / widthToCut, 2);

                    lblUsedWidth1.Text = Convert.ToString(Math.Round(usedWidth, 2));
                    lblUnusedWidth1.Text = Convert.ToString(Math.Round((widthToCut - Convert.ToDouble(lblUsedWidth1.Text)), 2));
                    lblUsedArms1.Text = Convert.ToString(numArms);
                    lblWaste1.Text = wastePercentage.ToString();


                    if (usedWidth > widthToCut)
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

                    if (numArms > arms)
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
                    if (lblCuter2.Tag != null)
                        wastePercentage = Math.Round(((widthToCut - usedWidth) * 100) / widthToCut, 2);

                    lblUsedWidth2.Text = Convert.ToString(Math.Round(usedWidth, 2));
                    lblUnusedWidth2.Text = Convert.ToString(Math.Round((((clsProduct)lblProduct2.Tag).width - Convert.ToDouble(lblUsedWidth2.Text)), 2));
                    lblUsedArms2.Text = Convert.ToString(numArms);
                    lblWaste2.Text = wastePercentage.ToString();


                    if (usedWidth > widthToCut)
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

                    if (numArms > arms)
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
                    if (lblCuter3.Tag != null)
                        wastePercentage = Math.Round(((widthToCut - usedWidth) * 100) / widthToCut, 2);

                    lblUsedWidth3.Text = Convert.ToString(Math.Round(usedWidth, 2));
                    lblUnusedWidth3.Text = Convert.ToString(Math.Round((widthToCut - Convert.ToDouble(lblUsedWidth3.Text)), 2));
                    lblUsedArms3.Text = Convert.ToString(numArms);
                    lblWaste3.Text = wastePercentage.ToString();


                    if (usedWidth > widthToCut)
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

                    if (numArms > arms)
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

                    if (lblCuter4.Tag != null)
                        wastePercentage = Math.Round(((widthToCut - usedWidth) * 100) / widthToCut, 2);

                    lblUsedWidth4.Text = Convert.ToString(Math.Round(usedWidth, 2));
                    lblUnusedWidth4.Text = Convert.ToString(Math.Round((widthToCut - Convert.ToDouble(lblUsedWidth4.Text)), 2));
                    lblUsedArms4.Text = Convert.ToString(numArms);
                    lblWaste4.Text = wastePercentage.ToString();


                    if (usedWidth > widthToCut)
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

                    if (numArms > arms)
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

                    if (lblCuter5.Tag != null)
                        wastePercentage = Math.Round(((widthToCut - usedWidth) * 100) / widthToCut, 2);

                    lblUsedWidth5.Text = Convert.ToString(Math.Round(usedWidth, 2));
                    lblUnusedWidth5.Text = Convert.ToString(Math.Round((widthToCut - Convert.ToDouble(lblUsedWidth5.Text)), 2));
                    lblUsedArms5.Text = Convert.ToString(numArms);
                    lblWaste5.Text = wastePercentage.ToString();


                    if (usedWidth > widthToCut)
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

                    if (numArms > arms)
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
                    if (lblCuter6.Tag != null)
                        wastePercentage = Math.Round(((widthToCut - usedWidth) * 100) / widthToCut, 2);

                    lblUsedWidth6.Text = Convert.ToString(Math.Round(usedWidth, 2));
                    lblUnusedWidth6.Text = Convert.ToString(Math.Round((widthToCut - Convert.ToDouble(lblUsedWidth6.Text)), 2));
                    lblUsedArms6.Text = Convert.ToString(numArms);
                    lblWaste6.Text = wastePercentage.ToString();


                    if (usedWidth > widthToCut)
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

                    if (numArms > arms)
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
                    if (lblCuter7.Tag != null)
                        wastePercentage = Math.Round(((widthToCut - usedWidth) * 100) / widthToCut, 2);

                    lblUsedWidth7.Text = Convert.ToString(Math.Round(usedWidth, 2));
                    lblUnusedWidth7.Text = Convert.ToString(Math.Round((widthToCut - Convert.ToDouble(lblUsedWidth7.Text)), 2));
                    lblUsedArms7.Text = Convert.ToString(numArms);
                    lblWaste7.Text = wastePercentage.ToString();


                    if (usedWidth > widthToCut)
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

                    if (numArms > arms)
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
                    if (lblCuter8.Tag != null)
                        wastePercentage = Math.Round(((widthToCut - usedWidth) * 100) / widthToCut, 2);

                    lblUsedWidth8.Text = Convert.ToString(Math.Round(usedWidth, 2));
                    lblUnusedWidth8.Text = Convert.ToString(Math.Round((widthToCut - Convert.ToDouble(lblUsedWidth8.Text)), 2));
                    lblUsedArms8.Text = Convert.ToString(numArms);
                    lblWaste8.Text = wastePercentage.ToString();


                    if (usedWidth > widthToCut)
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

                    if (numArms > arms)
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
                    if (lblCuter9.Tag != null)
                        wastePercentage = Math.Round(((widthToCut - usedWidth) * 100) / widthToCut, 2);

                    lblUsedWidth9.Text = Convert.ToString(Math.Round(usedWidth, 2));
                    lblUnusedWidth9.Text = Convert.ToString(Math.Round((widthToCut - Convert.ToDouble(lblUsedWidth9.Text)), 2));
                    lblUsedArms9.Text = Convert.ToString(numArms);
                    lblWaste9.Text = wastePercentage.ToString();


                    if (usedWidth > widthToCut)
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

                    if (numArms > arms)
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
                    if (lblCuter10.Tag != null)
                        wastePercentage = Math.Round(((widthToCut - usedWidth) * 100) / widthToCut, 2);

                    lblUsedWidth10.Text = Convert.ToString(Math.Round(usedWidth, 2));
                    lblUnusedWidth10.Text = Convert.ToString(Math.Round((widthToCut - Convert.ToDouble(lblUsedWidth10.Text)), 2));
                    lblUsedArms10.Text = Convert.ToString(numArms);
                    lblWaste10.Text = wastePercentage.ToString();


                    if (usedWidth > widthToCut)
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

                    if (numArms > arms)
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

                for (int j = 11; j < 30; j = j + 2)
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

        private void changePalletStatus(object sender, EventArgs e)
        {
            CheckBox chkSingleFace = (CheckBox)sender;
            frmCuttingOrderPalletType win = new frmCuttingOrderPalletType(this);
            win.StartPosition = FormStartPosition.CenterScreen;
            win.ShowDialog();
            clsCuttingOrderDetail objCuttingOrderDetail = new clsCuttingOrderDetail();
            objCuttingOrderDetail.load(Convert.ToInt32(chkSingleFace.Tag));
            objCuttingOrderDetail.pallet = (TPallet == "") ? "" : TPallet;
            objCuttingOrderDetail.save();
            chkSingleFace.Text = "TPallet " + ((TPallet == "") ? "-----" : TPallet);
        }

        private void frmCuttingOrder_Load(object sender, EventArgs e)
        {
            fillFilmList();
            generateResume();


        }

        private void dgvCast_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                objCast.load(Convert.ToInt32(dgvCast.Rows[e.RowIndex].Cells[clmCodsec.Index].Value));
                lblFilmName.Text = "[" + objCast.code + "] " + objCast.name;

                filmType = "Cast";
                fillSalesOrderList(filmType);

                generateResume();

                tbcCuttingOrder.SelectedIndex = 1;
                chkAllowEquivalentFilm1.Checked = false;
            }
        }

        private void dgvSalesOrderDetail_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 10:
                    if (lblCuter1.Tag != null && lblCuter1.Tag.ToString() != "" && lblProduct1.Tag != null && lblProduct1.Tag.ToString() != "")
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
                        if (dgvSalesOrderDetail.CurrentCell.EditedFormattedValue.ToString() != dgvSalesOrderDetail.CurrentCell.Value.ToString())
                            MessageBox.Show("Por favor, seleccione primero el producto que se cortar� y la cortadora en la que se realizar� el corte.");
                        dgvSalesOrderDetail.CancelEdit();
                    }
                    break;
                case 12:
                    if (lblCuter2.Tag != null && lblCuter2.Tag.ToString() != "" && lblProduct2.Tag != null && lblProduct2.Tag.ToString() != "")
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
                        if (dgvSalesOrderDetail.CurrentCell.EditedFormattedValue.ToString() != dgvSalesOrderDetail.CurrentCell.Value.ToString())
                            MessageBox.Show("Por favor, seleccione primero el producto que se cortar� y la cortadora en la que se realizar� el corte.");
                        dgvSalesOrderDetail.CancelEdit();
                    }
                    break;
                case 14:
                    if (lblCuter3.Tag != null && lblCuter3.Tag.ToString() != "" && lblProduct3.Tag != null && lblProduct3.Tag.ToString() != "")
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
                        if (dgvSalesOrderDetail.CurrentCell.EditedFormattedValue.ToString() != dgvSalesOrderDetail.CurrentCell.Value.ToString())
                            MessageBox.Show("Por favor, seleccione primero el producto que se cortar� y la cortadora en la que se realizar� el corte.");
                        dgvSalesOrderDetail.CancelEdit();
                    }
                    break;
                case 16:
                    if (lblCuter4.Tag != null && lblCuter4.Tag.ToString() != "" && lblProduct4.Tag != null && lblProduct4.Tag.ToString() != "")
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
                        if (dgvSalesOrderDetail.CurrentCell.EditedFormattedValue.ToString() != dgvSalesOrderDetail.CurrentCell.Value.ToString())
                            MessageBox.Show("Por favor, seleccione primero el producto que se cortar� y la cortadora en la que se realizar� el corte.");
                        dgvSalesOrderDetail.CancelEdit();
                    }
                    break;
                case 18:
                    if (lblCuter5.Tag != null && lblCuter5.Tag.ToString() != "" && lblProduct5.Tag != null && lblProduct5.Tag.ToString() != "")
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
                        if (dgvSalesOrderDetail.CurrentCell.EditedFormattedValue.ToString() != dgvSalesOrderDetail.CurrentCell.Value.ToString())
                            MessageBox.Show("Por favor, seleccione primero el producto que se cortar� y la cortadora en la que se realizar� el corte.");
                        dgvSalesOrderDetail.CancelEdit();
                    }
                    break;
                case 20:
                    if (lblCuter6.Tag != null && lblCuter6.Tag.ToString() != "" && lblProduct6.Tag != null && lblProduct6.Tag.ToString() != "")
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
                        if (dgvSalesOrderDetail.CurrentCell.EditedFormattedValue.ToString() != dgvSalesOrderDetail.CurrentCell.Value.ToString())
                            MessageBox.Show("Por favor, seleccione primero el producto que se cortar� y la cortadora en la que se realizar� el corte.");
                        dgvSalesOrderDetail.CancelEdit();
                    }
                    break;
                case 22:
                    if (lblCuter7.Tag != null && lblCuter7.Tag.ToString() != "" && lblProduct7.Tag != null && lblProduct7.Tag.ToString() != "")
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
                        if (dgvSalesOrderDetail.CurrentCell.EditedFormattedValue.ToString() != dgvSalesOrderDetail.CurrentCell.Value.ToString())
                            MessageBox.Show("Por favor, seleccione primero el producto que se cortar� y la cortadora en la que se realizar� el corte.");
                        dgvSalesOrderDetail.CancelEdit();
                    }
                    break;
                case 24:
                    if (lblCuter8.Tag != null && lblCuter8.Tag.ToString() != "" && lblProduct8.Tag != null && lblProduct8.Tag.ToString() != "")
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
                        if (dgvSalesOrderDetail.CurrentCell.EditedFormattedValue.ToString() != dgvSalesOrderDetail.CurrentCell.Value.ToString())
                            MessageBox.Show("Por favor, seleccione primero el producto que se cortar� y la cortadora en la que se realizar� el corte.");
                        dgvSalesOrderDetail.CancelEdit();
                    }
                    break;
                case 26:
                    if (lblCuter9.Tag != null && lblCuter9.Tag.ToString() != "" && lblProduct9.Tag != null && lblProduct9.Tag.ToString() != "")
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
                        if (dgvSalesOrderDetail.CurrentCell.EditedFormattedValue.ToString() != dgvSalesOrderDetail.CurrentCell.Value.ToString())
                            MessageBox.Show("Por favor, seleccione primero el producto que se cortar� y la cortadora en la que se realizar� el corte.");
                        dgvSalesOrderDetail.CancelEdit();
                    }
                    break;
                case 28:
                    if (lblCuter10.Tag != null && lblCuter10.Tag.ToString() != "" && lblProduct10.Tag != null && lblProduct10.Tag.ToString() != "")
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
                        if (dgvSalesOrderDetail.CurrentCell.EditedFormattedValue.ToString() != dgvSalesOrderDetail.CurrentCell.Value.ToString())
                            MessageBox.Show("Por favor, seleccione primero el producto que se cortar� y la cortadora en la que se realizar� el corte.");
                        dgvSalesOrderDetail.CancelEdit();
                    }
                    break;

            }
        }

        private void dgvSalesOrderDetail_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 10:
                    if (lblCuter1.Tag != null && lblCuter1.Tag.ToString() != "" && lblProduct1.Tag != null && lblProduct1.Tag.ToString() != "")
                    {
                        int combinationNumber = (e.ColumnIndex - 8) / 2;
                        calculateCombination(combinationNumber);
                    }
                    break;
                case 12:

                    if (lblCuter2.Tag != null && lblCuter2.Tag.ToString() != "" && lblProduct2.Tag != null && lblProduct2.Tag.ToString() != "")
                    {
                        int combinationNumber = (e.ColumnIndex - 8) / 2;
                        calculateCombination(combinationNumber);
                    }
                    break;
                case 14:

                    if (lblCuter3.Tag != null && lblCuter3.Tag.ToString() != "" && lblProduct3.Tag != null && lblProduct3.Tag.ToString() != "")
                    {
                        int combinationNumber = (e.ColumnIndex - 8) / 2;
                        calculateCombination(combinationNumber);
                    }
                    break;
                case 16:

                    if (lblCuter4.Tag != null && lblCuter4.Tag.ToString() != "" && lblProduct4.Tag != null && lblProduct4.Tag.ToString() != "")
                    {
                        int combinationNumber = (e.ColumnIndex - 8) / 2;
                        calculateCombination(combinationNumber);
                    }
                    break;
                case 18:

                    if (lblCuter5.Tag != null && lblCuter5.Tag.ToString() != "" && lblProduct5.Tag != null && lblProduct5.Tag.ToString() != "")
                    {
                        int combinationNumber = (e.ColumnIndex - 8) / 2;
                        calculateCombination(combinationNumber);
                    }
                    break;
                case 20:

                    if (lblCuter6.Tag != null && lblCuter6.Tag.ToString() != "" && lblProduct6.Tag != null && lblProduct6.Tag.ToString() != "")
                    {
                        int combinationNumber = (e.ColumnIndex - 8) / 2;
                        calculateCombination(combinationNumber);
                    }
                    break;
                case 22:

                    if (lblCuter7.Tag != null && lblCuter7.Tag.ToString() != "" && lblProduct7.Tag != null && lblProduct7.Tag.ToString() != "")
                    {
                        int combinationNumber = (e.ColumnIndex - 8) / 2;
                        calculateCombination(combinationNumber);
                    }
                    break;
                case 24:

                    if (lblCuter8.Tag != null && lblCuter8.Tag.ToString() != "" && lblProduct8.Tag != null && lblProduct8.Tag.ToString() != "")
                    {
                        int combinationNumber = (e.ColumnIndex - 8) / 2;
                        calculateCombination(combinationNumber);
                    }
                    break;
                case 26:

                    if (lblCuter9.Tag != null && lblCuter9.Tag.ToString() != "" && lblProduct9.Tag != null && lblProduct9.Tag.ToString() != "")
                    {
                        int combinationNumber = (e.ColumnIndex - 8) / 2;
                        calculateCombination(combinationNumber);
                    }
                    break;
                case 28:

                    if (lblCuter10.Tag != null && lblCuter10.Tag.ToString() != "" && lblProduct10.Tag != null && lblProduct10.Tag.ToString() != "")
                    {
                        int combinationNumber = (e.ColumnIndex - 8) / 2;
                        calculateCombination(combinationNumber);
                    }
                    break;
            }
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
                clsMachine objCutter = new clsMachine();
                clsProduct objProduct = new clsProduct();

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
                        objCutter = (clsMachine)lblCuter1.Tag;
                        objProduct = (clsProduct)lblProduct1.Tag;
                        break;
                    case 12:
                        repetitions = Convert.ToInt32(nudStops2.Value);
                        strViability = lblViableCombination2.Text;
                        usedWidth = Convert.ToInt32(lblUsedWidth2.Text);
                        armsUsed = Convert.ToInt32(lblUsedArms2.Text);
                        waste = Convert.ToDouble(lblWaste2.Text);
                        allowEquivalentFilm = chkAllowEquivalentFilm2.Checked;
                        combinationNotes = btnObservations2.Tag.ToString();

                        objCutter = (clsMachine)lblCuter2.Tag;
                        objProduct = (clsProduct)lblProduct2.Tag;
                        break;
                    case 14:
                        repetitions = Convert.ToInt32(nudStops3.Value);
                        strViability = lblViableCombination3.Text;
                        usedWidth = Convert.ToInt32(lblUsedWidth3.Text);
                        armsUsed = Convert.ToInt32(lblUsedArms3.Text);
                        waste = Convert.ToDouble(lblWaste3.Text);
                        allowEquivalentFilm = chkAllowEquivalentFilm3.Checked;
                        combinationNotes = btnObservations3.Tag.ToString();

                        objCutter = (clsMachine)lblCuter3.Tag;
                        objProduct = (clsProduct)lblProduct3.Tag;
                        break;
                    case 16:
                        repetitions = Convert.ToInt32(nudStops4.Value);
                        strViability = lblViableCombination4.Text;
                        usedWidth = Convert.ToInt32(lblUsedWidth4.Text);
                        armsUsed = Convert.ToInt32(lblUsedArms4.Text);
                        waste = Convert.ToDouble(lblWaste4.Text);
                        allowEquivalentFilm = chkAllowEquivalentFilm4.Checked;
                        combinationNotes = btnObservations4.Tag.ToString();

                        objCutter = (clsMachine)lblCuter4.Tag;
                        objProduct = (clsProduct)lblProduct4.Tag;
                        break;
                    case 18:
                        repetitions = Convert.ToInt32(nudStops5.Value);
                        strViability = lblViableCombination5.Text;
                        usedWidth = Convert.ToInt32(lblUsedWidth5.Text);
                        armsUsed = Convert.ToInt32(lblUsedArms5.Text);
                        waste = Convert.ToDouble(lblWaste5.Text);
                        allowEquivalentFilm = chkAllowEquivalentFilm5.Checked;
                        combinationNotes = btnObservations5.Tag.ToString();

                        objCutter = (clsMachine)lblCuter5.Tag;
                        objProduct = (clsProduct)lblProduct5.Tag;
                        break;
                    case 20:
                        repetitions = Convert.ToInt32(nudStops6.Value);
                        strViability = lblViableCombination6.Text;
                        usedWidth = Convert.ToInt32(lblUsedWidth6.Text);
                        armsUsed = Convert.ToInt32(lblUsedArms6.Text);
                        waste = Convert.ToDouble(lblWaste6.Text);
                        allowEquivalentFilm = chkAllowEquivalentFilm6.Checked;
                        combinationNotes = btnObservations6.Tag.ToString();

                        objCutter = (clsMachine)lblCuter6.Tag;
                        objProduct = (clsProduct)lblProduct6.Tag;
                        break;
                    case 22:
                        repetitions = Convert.ToInt32(nudStops7.Value);
                        strViability = lblViableCombination7.Text;
                        usedWidth = Convert.ToInt32(lblUsedWidth7.Text);
                        armsUsed = Convert.ToInt32(lblUsedArms7.Text);
                        waste = Convert.ToDouble(lblWaste7.Text);
                        allowEquivalentFilm = chkAllowEquivalentFilm7.Checked;
                        combinationNotes = btnObservations7.Tag.ToString();

                        objCutter = (clsMachine)lblCuter7.Tag;
                        objProduct = (clsProduct)lblProduct7.Tag;
                        break;
                    case 24:
                        repetitions = Convert.ToInt32(nudStops8.Value);
                        strViability = lblViableCombination8.Text;
                        usedWidth = Convert.ToInt32(lblUsedWidth8.Text);
                        armsUsed = Convert.ToInt32(lblUsedArms8.Text);
                        waste = Convert.ToDouble(lblWaste8.Text);
                        allowEquivalentFilm = chkAllowEquivalentFilm8.Checked;
                        combinationNotes = btnObservations8.Tag.ToString();

                        objCutter = (clsMachine)lblCuter8.Tag;
                        objProduct = (clsProduct)lblProduct8.Tag;
                        break;
                    case 26:
                        repetitions = Convert.ToInt32(nudStops9.Value);
                        strViability = lblViableCombination9.Text;
                        usedWidth = Convert.ToInt32(lblUsedWidth9.Text);
                        armsUsed = Convert.ToInt32(lblUsedArms9.Text);
                        waste = Convert.ToDouble(lblWaste9.Text);
                        allowEquivalentFilm = chkAllowEquivalentFilm9.Checked;
                        combinationNotes = btnObservations9.Tag.ToString();

                        objCutter = (clsMachine)lblCuter9.Tag;
                        objProduct = (clsProduct)lblProduct9.Tag;
                        break;
                    case 28:
                        repetitions = Convert.ToInt32(nudStops10.Value);
                        strViability = lblViableCombination10.Text;
                        usedWidth = Convert.ToInt32(lblUsedWidth10.Text);
                        armsUsed = Convert.ToInt32(lblUsedArms10.Text);
                        waste = Convert.ToDouble(lblWaste10.Text);
                        allowEquivalentFilm = chkAllowEquivalentFilm10.Checked;
                        combinationNotes = btnObservations10.Tag.ToString();

                        objCutter = (clsMachine)lblCuter10.Tag;
                        objProduct = (clsProduct)lblProduct10.Tag;
                        break;
                }

                if (strViability == "SI")
                {
                    lstCuttingOrders.Add(new clsCuttingOrder());

                    int pos = lstCuttingOrders.Count - 1;
                    lstCuttingOrders[pos].fkMachine = objCutter.codsec;
                    lstCuttingOrders[pos].machineName = objCutter.Cutter.name;
                    lstCuttingOrders[pos].fkStatus = (clsStatus.getStatusByStatusGroupNameAndStatusName("Ordenes de corte", "Programada")).codsec;
                    lstCuttingOrders[pos].statusName = (clsStatus.getStatusByStatusGroupNameAndStatusName("Ordenes de corte", "Programada")).name;
                    lstCuttingOrders[pos].fkProduct = objProduct.codsec;
                    lstCuttingOrders[pos].productName = objProduct.name;
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
                    lstCuttingOrders[pos].notes = combinationNotes;
                    lstCuttingOrders[pos].allowEquivalentFilm = allowEquivalentFilm;
                    lstCuttingOrders[pos].isSecundaryCut = true;

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
            fillSalesOrderList(filmType);
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


            fillSalesOrderList(filmType);

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


                fillSalesOrderList(filmType);
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
            fillSalesOrderList(filmType);
        }

        private void btnFilterSalesOrder_Click(object sender, EventArgs e)
        {
            fillSalesOrderList(filmType);
        }

        private void btnClearFilterSalesOrder_Click(object sender, EventArgs e)
        {
            fillSalesOrderList(filmType);
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
                frmProductListShort winProductList = new frmProductListShort(this, Convert.ToInt32(dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderProductCodsec.Index].Value), filmType, true);
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
                    dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderCoilsToCut1.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[e.RowIndex].Cells[clmSalesOrderProgrammedCoils.Index].Value = 0;

                    for (int j = 11; j < 30; j = j + 2)
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

        private void nudStops_ValueChanged(object sender, EventArgs e)
        {
            if (lblCuter1.Tag != null && lblCuter1.Tag.ToString() != "" && lblProduct1.Tag != null && lblProduct1.Tag.ToString() != "")
                calculateRepetitions(1);
        }

        private void nudStops2_ValueChanged(object sender, EventArgs e)
        {
            if (lblCuter2.Tag != null && lblCuter2.Tag.ToString() != "" && lblProduct2.Tag != null && lblProduct2.Tag.ToString() != "")
                calculateRepetitions(2);
        }

        private void nudStops3_ValueChanged(object sender, EventArgs e)
        {
            if (lblCuter3.Tag != null && lblCuter3.Tag.ToString() != "" && lblProduct3.Tag != null && lblProduct3.Tag.ToString() != "")
                calculateRepetitions(3);
        }

        private void nudStops4_ValueChanged(object sender, EventArgs e)
        {
            if (lblCuter4.Tag != null && lblCuter4.Tag.ToString() != "" && lblProduct4.Tag != null && lblProduct4.Tag.ToString() != "")
                calculateRepetitions(4);
        }

        private void nudStops5_ValueChanged(object sender, EventArgs e)
        {
            if (lblCuter5.Tag != null && lblCuter5.Tag.ToString() != "" && lblProduct5.Tag != null && lblProduct5.Tag.ToString() != "")
                calculateRepetitions(5);
        }

        private void nudStops6_ValueChanged(object sender, EventArgs e)
        {
            if (lblCuter6.Tag != null && lblCuter6.Tag.ToString() != "" && lblProduct6.Tag != null && lblProduct6.Tag.ToString() != "")
                calculateRepetitions(6);
        }

        private void nudStops7_ValueChanged(object sender, EventArgs e)
        {
            if (lblCuter7.Tag != null && lblCuter7.Tag.ToString() != "" && lblProduct7.Tag != null && lblProduct7.Tag.ToString() != "")
                calculateRepetitions(7);
        }

        private void nudStops8_ValueChanged(object sender, EventArgs e)
        {
            if (lblCuter8.Tag != null && lblCuter8.Tag.ToString() != "" && lblProduct8.Tag != null && lblProduct8.Tag.ToString() != "")
                calculateRepetitions(8);
        }

        private void nudStops9_ValueChanged(object sender, EventArgs e)
        {
            if (lblCuter9.Tag != null && lblCuter9.Tag.ToString() != "" && lblProduct9.Tag != null && lblProduct9.Tag.ToString() != "")
                calculateRepetitions(9);
        }

        private void nudStops10_ValueChanged(object sender, EventArgs e)
        {
            if (lblCuter10.Tag != null && lblCuter10.Tag.ToString() != "" && lblProduct10.Tag != null && lblProduct10.Tag.ToString() != "")
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
                ((Button)sender).Image = global::BPS.Properties.Resources.textOK;
            }
            else
            {
                ttpCuttingOrder.SetToolTip((Button)sender, "-- Sin observaciones --");
                ((Button)sender).Image = global::BPS.Properties.Resources.textNo;
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

                frmProductListShort winProductList;

                if (filmType == "Bopp")
                {
                    winProductList = new frmProductListShort(this, objBopp.codsec, filmType, true);
                    winProductList.ShowDialog(this);
                }
                else
                {
                    winProductList = new frmProductListShort(this, objCast.codsec, filmType, true);
                    winProductList.ShowDialog(this);
                }

                if (selectedProductCodsec != 0)
                {
                    objSelectedProduct.load(selectedProductCodsec);
                    dgvSalesOrderDetail.Rows.Add();

                    int j = dgvSalesOrderDetail.Rows.Count - 2;

                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCodsec.Index].Value = 0;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCustomer.Index].Value = "STOCK";
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderNumber.Index].Value = "----";
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderProduct.Index].Value = objSelectedProduct.code;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderChangeProduct.Index].Value = global::BPS.Properties.Resources.clear;
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

        private void txtBoppCode_TextChanged(object sender, EventArgs e)
        {
            fillFilmList();
        }

        private void frmSecundaryCuttingOrderMultiple_SizeChanged(object sender, EventArgs e)
        {
            dgvSalesOrderDetail.Height = lblProduct1.Top - 17;
        }

        private void dgvBopp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (clsGlobal.LoggedUser.userName == "narguello" || clsGlobal.LoggedUser.userName == "jotero")
                {
                    cmbPlants.SelectedItem = "Pilar";
                }
                else
                {
                    cmbPlants.SelectedItem = "Campana";
                }

                objBopp.load(Convert.ToInt32(dgvBopp.Rows[e.RowIndex].Cells[clmCodsec.Index].Value));
                lblFilmName.Text = "[" + objBopp.code + "] " + objBopp.name;

                filmType = "Bopp";
                fillSalesOrderList(filmType);

                generateResume();

                tbcCuttingOrder.SelectedIndex = 1;
                chkAllowEquivalentFilm1.Checked = false;
            }
        }

        private void dgvCast_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (clsGlobal.LoggedUser.userName == "narguello" || clsGlobal.LoggedUser.userName == "jotero" || clsGlobal.LoggedUser.userName == "nzarate")
                {
                    cmbPlants.SelectedItem = "Pilar";
                }
                else
                {
                    cmbPlants.SelectedItem = "Campana";
                }

                objCast.load(Convert.ToInt32(dgvCast.Rows[e.RowIndex].Cells[clmCodsec.Index].Value));
                lblFilmName.Text = "[" + objCast.code + "] " + objCast.name;

                filmType = "Cast";
                fillSalesOrderList(filmType);

                generateResume();

                tbcCuttingOrder.SelectedIndex = 1;
                chkAllowEquivalentFilm1.Checked = false;
            }
        }

        private void lblProduct1_DoubleClick(object sender, EventArgs e)
        {
            frmProductListShort winProductList;

            if (filmType == "Bopp")
            {
                winProductList = new frmProductListShort(this, objBopp.codsec, filmType, false);
                winProductList.ShowDialog(this);
            }
            else
            {
                winProductList = new frmProductListShort(this, objCast.codsec, filmType, false);
                winProductList.ShowDialog(this);
            }

            ((Label)sender).Tag = new clsProduct(selectedProductCodsec);
            ((Label)sender).Text = ((clsProduct)((Label)sender).Tag).code;
        }

        private void lblCuter1_DoubleClick(object sender, EventArgs e)
        {
            frmCutterSelector winCutterSelector = new frmCutterSelector((Label)sender);
            winCutterSelector.StartPosition = FormStartPosition.CenterScreen;
            winCutterSelector.ShowDialog(this);
            if (((Label)sender).Tag != null && ((Label)sender).Tag.ToString() != "")
            {
                ((Label)sender).Text = ((clsMachine)((Label)sender).Tag).ToString();

                string strControlName = ((Label)sender).Name;

                switch (strControlName)
                {
                    case "lblCuter1":
                        if (lblProduct1.Tag != null && lblProduct1.Tag.ToString() != "")
                            calculateCombination(1);
                        break;
                    case "lblCuter2":
                        if (lblProduct2.Tag != null && lblProduct2.Tag.ToString() != "")
                            calculateCombination(2);
                        break;
                    case "lblCuter3":
                        if (lblProduct3.Tag != null && lblProduct3.Tag.ToString() != "")
                            calculateCombination(3);
                        break;
                    case "lblCuter4":
                        if (lblProduct4.Tag != null && lblProduct4.Tag.ToString() != "")
                            calculateCombination(4);
                        break;
                    case "lblCuter5":
                        if (lblProduct5.Tag != null && lblProduct5.Tag.ToString() != "")
                            calculateCombination(5);
                        break;
                    case "lblCuter6":
                        if (lblProduct6.Tag != null && lblProduct6.Tag.ToString() != "")
                            calculateCombination(6);
                        break;
                    case "lblCuter7":
                        if (lblProduct7.Tag != null && lblProduct7.Tag.ToString() != "")
                            calculateCombination(7);
                        break;
                    case "lblCuter8":
                        if (lblProduct8.Tag != null && lblProduct8.Tag.ToString() != "")
                            calculateCombination(8);
                        break;
                    case "lblCuter9":
                        if (lblProduct9.Tag != null && lblProduct9.Tag.ToString() != "")
                            calculateCombination(9);
                        break;
                    case "lblCuter10":
                        if (lblProduct10.Tag != null && lblProduct10.Tag.ToString() != "")
                            calculateCombination(10);
                        break;
                    default:
                        break;
                }

            }

        }

        private void txtBoppCode_TextChanged_1(object sender, EventArgs e)
        {
            fillFilmList();
        }

        private void txtCastCode_TextChanged_1(object sender, EventArgs e)
        {
            fillFilmList();
        }

        private void grpbMainCoilButtons_Enter(object sender, EventArgs e)
        {

        }

        private void cmbPlants_SelectedIndexChanged(object sender, EventArgs e)
        {
            plant = new clsPlant(cmbPlants.Items[cmbPlants.SelectedIndex].ToString());
            if (dgvBopp.Rows.Count > 0)
            {
                fillSalesOrderList(filmType);
            }
        }

        private void cmbDiameter_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDatagrid(cmbDiameter.SelectedItem.ToString());
        }

        private void fillDatagrid(string diameter)
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

                //if (flgVisible && (lstSalesOrderDetailItems[i].pendingCoils > 0 || (lstSalesOrderDetailItems[i].pendingCoils <= 0 && flgVisible == true)))
                if (flgVisible && (lstSalesOrderDetailItems[i].pendingCoils > 0) && lstSalesOrderDetailItems[i].coreDiameter == diameter)
                {
                    dgvSalesOrderDetail.Rows.Add();

                    int j = dgvSalesOrderDetail.Rows.Count - 2;

                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCodsec.Index].Value = lstSalesOrderDetailItems[i].codsec;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCustomer.Index].Value = lstSalesOrderDetailItems[i].entityName;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderNumber.Index].Value = lstSalesOrderDetailItems[i].number;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderProduct.Index].Value = lstSalesOrderDetailItems[i].productCode;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderChangeProduct.Index].Value = global::BPS.Properties.Resources.arrow_refresh;
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

        private void cmbDiameter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                fillDatagrid();
            }
        }



    }
}