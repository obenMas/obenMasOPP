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
    public partial class frmCuttingOrderSummaryD : Form
    {
        clsCuttingOrder objCuttingOrder = new clsCuttingOrder();
        clsMachine objMachine = new clsMachine();
        clsMainCoil objMainCoil = new clsMainCoil();
        clsEfficiencyCutExtruder objEfficiencyCutExtruder = new clsEfficiencyCutExtruder();

        bool flgCloseCuttingOrder = false;
        private int inPosition = 0;
        List<int> lstCoilsCodsec = new List<int>();
        List<int> lstCoilsCodsecClose = new List<int>();
        List<int> lstCoilsSeqCodsecClose = new List<int>();
        List<int> lstCoilsMainCodsecClose = new List<int>();

        clsCoil objCoil = new clsCoil();

        private bool validateToClose()
        {
            bool isValid = true;

            if (cmbOperator.SelectedIndex == -1)
            {
                isValid = false;
                lblOperator.ForeColor = Color.Red;
                cmbOperator.BackColor = Color.FromArgb(253, 230, 231);
            }
            else
            {
                lblOperator.ForeColor = SystemColors.WindowText;
                cmbOperator.BackColor = SystemColors.Window;
            }

            if (cmbDigitizer.SelectedIndex == -1)
            {
                isValid = false;
                lblDigitizer.ForeColor = Color.Red;
                cmbDigitizer.BackColor = Color.FromArgb(253, 230, 231);
            }
            else
            {
                lblDigitizer.ForeColor = SystemColors.WindowText;
                cmbDigitizer.BackColor = SystemColors.Window;
            }

            if (cmbSupervisor.SelectedIndex == -1)
            {
                isValid = false;
                lblSupervisor.ForeColor = Color.Red;
                cmbSupervisor.BackColor = Color.FromArgb(253, 230, 231);
            }
            else
            {
                lblSupervisor.ForeColor = SystemColors.WindowText;
                cmbSupervisor.BackColor = SystemColors.Window;
            }
            return isValid;
        }
        private void setStopLayout()
        {
            trvStopViews.Nodes[0].Text = "Orden de corte # " + objCuttingOrder.codsec;
            trvStopViews.Nodes[0].Nodes.Clear();
            int closedStops = 0;


            for (int i = 0; i < objCuttingOrder.lstCuttingStop.Count; i++)
            {
                TreeNode trnNode = new TreeNode();
                trnNode.Text = "Parada #" + (i + 1).ToString();
                trnNode.Tag = objCuttingOrder.lstCuttingStop[i].codsec;

                if (objCuttingOrder.lstCuttingStop[i].closed == true)
                {
                    trnNode.ImageIndex = 1;
                    trnNode.SelectedImageIndex = 1;
                    closedStops++;
                }
                else
                {
                    trnNode.ImageIndex = 0;
                    trnNode.SelectedImageIndex = 0;
                }
                trvStopViews.Nodes[0].Nodes.Add(trnNode);
            }

            if (closedStops == objCuttingOrder.lstCuttingStop.Count)
            {
                btnProcess.Image = global::BPS.Lite.Properties.Resources._lock;
                btnProcess.Text = "Cerrar";
                flgCloseCuttingOrder = true;
                chkForceClose.Visible = false;
            }

        }
        public void getStopLayoutByCuttingStop(int cuttingStopCodsec)
        {
            clsCuttingStop objCuttingStop = new clsCuttingStop(cuttingStopCodsec);
            double stopWeigth = 0;

            grpbStop.Text = "Parada # " + objCuttingStop.position.ToString();
            inPosition = objCuttingStop.position;

            dgvCoilsDetail.Rows.Clear();
            dgvMainCoilList.Rows.Clear();
            dgvCoilsSecundaryCut.Rows.Clear();
            List<clsUser> lstUsers;
            if(new clsPlant().codsec==3)
            {
                lstUsers = clsUser.getListByRole("Supervisor de corte");
                cmbSupervisor.Items.Clear();
                cmbSupervisor.SelectedIndex = -1;
                cmbSupervisor.Text = "";
                for (int j = 0; j < lstUsers.Count; j++)
                {
                    cmbSupervisor.Items.Add(lstUsers[j]);

                    if (lstUsers[j].codsec == objCuttingStop.supervisedBy)
                        cmbSupervisor.SelectedIndex = j;
                }

                lstUsers = clsUser.getListByRole("Digitador de corte");
                cmbDigitizer.Items.Clear();
                cmbDigitizer.SelectedIndex = -1;
                cmbDigitizer.Text = "";
                for (int j = 0; j < lstUsers.Count; j++)
                {
                    cmbDigitizer.Items.Add(lstUsers[j]);

                    if (lstUsers[j].codsec == objCuttingStop.digitizedBy)
                        cmbDigitizer.SelectedIndex = j;
                }

                lstUsers = clsUser.getListByRole("Operadores de corte");
                cmbOperator.Items.Clear();
                cmbOperator.SelectedIndex = -1;
                cmbOperator.Text = "";
                for (int j = 0; j < lstUsers.Count; j++)
                {
                    cmbOperator.Items.Add(lstUsers[j]);

                    if (lstUsers[j].codsec == objCuttingStop.operatedBy)
                        cmbOperator.SelectedIndex = j;
                }
            }
            else
            {
                lstUsers = clsUser.getListByRole("Supervisor Pilar");
                cmbSupervisor.Items.Clear();
                cmbSupervisor.SelectedIndex = -1;
                cmbSupervisor.Text = "";
                for (int j = 0; j < lstUsers.Count; j++)
                {
                    cmbSupervisor.Items.Add(lstUsers[j]);

                    if (lstUsers[j].codsec == objCuttingStop.supervisedBy)
                        cmbSupervisor.SelectedIndex = j;
                }

                lstUsers = clsUser.getListByRole("Digitador Pilar");
                cmbDigitizer.Items.Clear();
                cmbDigitizer.SelectedIndex = -1;
                cmbDigitizer.Text = "";
                for (int j = 0; j < lstUsers.Count; j++)
                {
                    cmbDigitizer.Items.Add(lstUsers[j]);

                    if (lstUsers[j].codsec == objCuttingStop.digitizedBy)
                        cmbDigitizer.SelectedIndex = j;
                }

                lstUsers = clsUser.getListByRole("Digitador Pilar");
                cmbOperator.Items.Clear();
                cmbOperator.SelectedIndex = -1;
                cmbOperator.Text = "";
                for (int j = 0; j < lstUsers.Count; j++)
                {
                    cmbOperator.Items.Add(lstUsers[j]);

                    if (lstUsers[j].codsec == objCuttingStop.operatedBy)
                        cmbOperator.SelectedIndex = j;
                }
            }


            lstCoilsCodsec = new List<int>();

            for (int i = 0; i < objCuttingOrder.lstCuttingOrderDetail.Count; i++)
            {
                int pos = -1;
                bool flgHasCoil = false;

                for (int j = 0; j < objCuttingStop.lstCoil.Count; j++)
                {
                    if (objCuttingStop.lstCoil[j].width == objCuttingOrder.lstCuttingOrderDetail[i].width && objCuttingStop.lstCoil[j].fkProduct == objCuttingOrder.lstCuttingOrderDetail[i].product.codsec)
                    {
                        if (!lstCoilsCodsec.Exists(codsec => codsec == objCuttingStop.lstCoil[j].codsec))
                        {
                            flgHasCoil = true;
                            pos = j;
                            lstCoilsCodsec.Add(objCuttingStop.lstCoil[j].codsec);
                            j = objCuttingStop.lstCoil.Count;
                        }
                    }
                }

                if (flgHasCoil == false)
                {
                    dgvCoilsDetail.Rows.Add();
                    grpbStop.Tag = cuttingStopCodsec;
                    dgvCoilsDetail.Rows[i].Cells[clmCodsec.Index].Value = 0;
                    dgvCoilsDetail.Rows[i].Cells[clmPosition.Index].Value = i + 1;

                    if (objCuttingOrder.lstCuttingOrderDetail[i].fkSalesOrderDetail > 0)
                    {
                        clsSalesOrderDetail objSalesOrderDetail = new clsSalesOrderDetail(objCuttingOrder.lstCuttingOrderDetail[i].fkSalesOrderDetail);
                        clsSalesOrder objSalesOrder = new clsSalesOrder();
                        objSalesOrder.loadWithoutDetail(objSalesOrderDetail.fkSalesOrder);
                        dgvCoilsDetail.Rows[i].Cells[clmSalesOrderDetailCodsec.Index].Value = objSalesOrderDetail.codsec;
                        dgvCoilsDetail.Rows[i].Cells[clmCuttingOrderDetailCodsec.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].codsec;
                        dgvCoilsDetail.Rows[i].Cells[clmCustomer.Index].Value = objSalesOrder.EntityName;
                        dgvCoilsDetail.Rows[i].Cells[clmSalesOrder.Index].Value = objSalesOrderDetail.codsec;  //objSalesOrder.number;
                    }
                    else
                    {
                        dgvCoilsDetail.Rows[i].Cells[clmSalesOrderDetailCodsec.Index].Value = 0;
                        dgvCoilsDetail.Rows[i].Cells[clmCuttingOrderDetailCodsec.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].codsec;
                        dgvCoilsDetail.Rows[i].Cells[clmCustomer.Index].Value = "Producto en Stock";
                        dgvCoilsDetail.Rows[i].Cells[clmSalesOrder.Index].Value = "---";
                    }
                    dgvCoilsDetail.Rows[i].Cells[clmProductCode.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].product.code;
                    dgvCoilsDetail.Rows[i].Cells[clmWidth.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].width;
                    dgvCoilsDetail.Rows[i].Cells[clmLength.Index].Value = 0;
                    dgvCoilsDetail.Rows[i].Cells[clmWeigth.Index].Value = 0;
                }
                else
                {
                    dgvCoilsDetail.Rows.Add();
                    grpbStop.Tag = cuttingStopCodsec;
                    dgvCoilsDetail.Rows[i].Cells[clmCodsec.Index].Value = objCuttingStop.lstCoil[pos].codsec;
                    dgvCoilsDetail.Rows[i].Cells[clmPosition.Index].Value = objCuttingStop.lstCoil[pos].cuttingPosition;

                    if (objCuttingOrder.lstCuttingOrderDetail[i].fkSalesOrderDetail > 0)
                    {
                        clsSalesOrderDetail objSalesOrderDetail = new clsSalesOrderDetail(objCuttingOrder.lstCuttingOrderDetail[i].fkSalesOrderDetail);
                        clsSalesOrder objSalesOrder = new clsSalesOrder(); 
                        objSalesOrder.loadWithoutDetail(objSalesOrderDetail.fkSalesOrder);
                        dgvCoilsDetail.Rows[i].Cells[clmCuttingOrderDetailCodsec.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].codsec;
                        dgvCoilsDetail.Rows[i].Cells[clmSalesOrderDetailCodsec.Index].Value = objSalesOrderDetail.codsec;
                        dgvCoilsDetail.Rows[i].Cells[clmCustomer.Index].Value = objSalesOrder.EntityName;
                        dgvCoilsDetail.Rows[i].Cells[clmSalesOrder.Index].Value = objSalesOrderDetail.codsec; //objSalesOrder.number;
                    }
                    else
                    {
                        dgvCoilsDetail.Rows[i].Cells[clmSalesOrderDetailCodsec.Index].Value = 0;
                        dgvCoilsDetail.Rows[i].Cells[clmCuttingOrderDetailCodsec.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].codsec;
                        dgvCoilsDetail.Rows[i].Cells[clmCustomer.Index].Value = "Producto en Stock";
                        dgvCoilsDetail.Rows[i].Cells[clmSalesOrder.Index].Value = "---";
                    }

                    dgvCoilsDetail.Rows[i].Cells[clmProductCode.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].product.code;
                    dgvCoilsDetail.Rows[i].Cells[clmWidth.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].width;
                    dgvCoilsDetail.Rows[i].Cells[clmLength.Index].Value = objCuttingStop.lstCoil[pos].length;
                    dgvCoilsDetail.Rows[i].Cells[clmWeigth.Index].Value = Math.Round(objCuttingStop.lstCoil[pos].grossWeight, 2);

                    stopWeigth += objCuttingStop.lstCoil[pos].grossWeight;

                    for (int j = 0; j < dgvCoilsDetail.ColumnCount; j++)
                        dgvCoilsDetail.Rows[i].Cells[j].Style.BackColor = Color.LightGreen;
                }
            }

            lblCoilsWeigth.Text = Math.Round(stopWeigth, 2).ToString();

            dgvCoilsDetail.Sort(clmPosition, ListSortDirection.Ascending);

            if (objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].codsec == cuttingStopCodsec)
            {
                if (objCuttingOrder.isSecundaryCut == false)
                {
                    for (int j = 0; j < objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstMainCoilByCuttingStop.Count; j++)
                    {
                        dgvMainCoilList.Rows.Add();
                        dgvMainCoilList.Rows[j].Cells[clmMainCoilListCodsec.Index].Value = objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstMainCoilByCuttingStop[j].mainCoil.codsec;
                        dgvMainCoilList.Rows[j].Cells[clmMainCoilListFilm.Index].Value = (new clsBopp(objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstMainCoilByCuttingStop[j].mainCoil.fkBopp)).name;
                        dgvMainCoilList.Rows[j].Cells[clmMainCoilListCode.Index].Value = objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstMainCoilByCuttingStop[j].mainCoil.code;
                        dgvMainCoilList.Rows[j].Cells[clmMainCoilListBatch.Index].Value = objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstMainCoilByCuttingStop[j].mainCoil.lotNumber;
                        dgvMainCoilList.Rows[j].Cells[clmMainCoilListLabRating.Index].Value = objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstMainCoilByCuttingStop[j].mainCoil.labRating;
                        dgvMainCoilList.Rows[j].Cells[clmMainCoilListInitDate.Index].Value = objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstMainCoilByCuttingStop[j].mainCoil.initDate.ToString("dd/MM/yyyy HH:mm:ss");
                        dgvMainCoilList.Rows[j].Cells[clmMainCoilUsedLenth.Index].Value = Convert.ToString(Math.Round(objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstMainCoilByCuttingStop[j].length, 2));
                        dgvMainCoilList.Rows[j].Cells[clmMainCoilEditLength.Index].Value = global::BPS.Lite.Properties.Resources.pencil;
                        dgvMainCoilList.Rows[j].Cells[clmMainCoilEditLength.Index].Tag = "edit";
                        dgvMainCoilList.Rows[j].Cells[clmMainCoilDelete.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                    }
                }
                else
                {
                    for (int i = 0; i < objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstSecundaryCutCoil.Count; i++)
                    {
                        dgvCoilsSecundaryCut.Rows.Add();
                        dgvCoilsSecundaryCut.Rows[i].Cells[clmCodsec.Index].Value = objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstSecundaryCutCoil[i].objCoil.codsec;
                        dgvCoilsSecundaryCut.Rows[i].Cells[clmCode.Index].Value = objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstSecundaryCutCoil[i].objCoil.code;
                        dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilProduct.Index].Value = (new clsProduct(objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstSecundaryCutCoil[i].objCoil.fkProduct)).code;
                        dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilDiameter.Index].Value = objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstSecundaryCutCoil[i].objCoil.diameter;
                        dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilCore.Index].Value = (new clsProduct(objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstSecundaryCutCoil[i].objCoil.fkProduct)).CoreValue.ToString() + "\"";
                        dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilWidth.Index].Value = objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstSecundaryCutCoil[i].objCoil.width;
                        dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilLength.Index].Value = objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstSecundaryCutCoil[i].objCoil.length;
                        dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilUsedLength.Index].Value = Convert.ToString(Math.Round(objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstSecundaryCutCoil[i].length, 2));
                        dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilEdit.Index].Value = global::BPS.Lite.Properties.Resources.pencil;
                        dgvCoilsSecundaryCut.Rows[i].Cells[clmCoildelete.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                    }
                }
                if (objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].closed)
                {
                    btnCloseStop.Enabled = false;
                    cmbSupervisor.Enabled = false;
                    cmbOperator.Enabled = false;
                    cmbDigitizer.Enabled = false;
                    grpbUsedMainCoil.Enabled = false;
                    dgvCoilsDetail.Enabled = false;
                    btnDecrease.Enabled = false;
                }
                else
                {
                    btnCloseStop.Enabled = true;
                    cmbSupervisor.Enabled = true;
                    cmbOperator.Enabled = true;
                    cmbDigitizer.Enabled = true;
                    grpbUsedMainCoil.Enabled = true;
                    dgvCoilsDetail.Enabled = true;
                    btnDecrease.Enabled = true;
                }
            }
            txtMainCoilCode.Text = "";
            txtUsedLength.Text = "0";
            lblMachine.Text = "";
            lblLot.Text = "";
            lblKgPerHour.Text = "0";
            lblVelocity.Text = "0";
            lblNetLength.Text = "0";
            lblWidht.Text = "0";
            lblGramaje.Text = "0";
            lblNetWeigth.Text = "0";
            txtMainCoilCode.Focus();
        }

        private void getCoilInformation(string Code)
        {
            clsProduct objProduct = new clsProduct();

            objCoil = clsCoil.getDetailByCode(Code);

            if (objCoil.codsec != 0)
            {
                lblDiameter.Text = Convert.ToString(Math.Round(objCoil.diameter, 2));
                lblDensity.Text = Convert.ToString(Math.Round(objCoil.density, 5));
                label4.Text = Convert.ToString(Math.Round(objCoil.netWeight, 2));
                lblGrossWeigth.Text = Convert.ToString(Math.Round(objCoil.grossWeight, 2));
                lblLength.Text = Convert.ToString(Math.Round(objCoil.length, 2));
                lblBalance.Text = objCoil.BalanceName;
                lblWidth.Text = objCoil.width.ToString();
                objProduct = new clsProduct(objCoil.fkProduct);
                lblCoilProduct.Text = objProduct.code.Replace("-", "");

            }
        }
        public frmCuttingOrderSummaryD()
        {
            InitializeComponent();
        }
        public frmCuttingOrderSummaryD(int cuttingOrderCodsec)
        {
            InitializeComponent();
            objCuttingOrder.load(cuttingOrderCodsec);
            objMachine.load(objCuttingOrder.fkMachine, "Cutter");
        }
        private void frmCuttingOrderSummary_Load(object sender, EventArgs e)
        {
            if (objCuttingOrder.codsec > 0)
            {
                double usedWidth = 0;
                try
                {
                    lblCutterName.Text = objCuttingOrder.machineName;
                    lblFilmName.Text = "";
                    lblStopsNumber.Text = objCuttingOrder.repetitions.ToString();
                    lblUsedArms.Text = objCuttingOrder.positions.ToString();
                    lblUtilWidth.Text = objMachine.Cutter.utilWidth.ToString();
                    lblTotalCoils.Text = Convert.ToString(objCuttingOrder.repetitions * objCuttingOrder.lstCuttingOrderDetail.Count);

                    lblUsedWidth.Text = usedWidth.ToString();
                    lblWaste.Text = Convert.ToString(Math.Round(((objMachine.Cutter.utilWidth - usedWidth) * 100 / objMachine.Cutter.utilWidth), 2));
                    if (objCuttingOrder.lstCuttingOrderDetail[0].product.fkBopp > 0)
                        lblFilmName.Text = objCuttingOrder.lstCuttingOrderDetail[0].product.boppCode.Replace("-", "");
                    else
                        lblFilmName.Text = objCuttingOrder.lstCuttingOrderDetail[0].product.castCode.Replace("-", "");

                    grpbInfo.Text = "Orden de corte # " + objCuttingOrder.codsec;
                    lblNotes.Text = objCuttingOrder.notes;
                    setStopLayout();

                    if (objCuttingOrder.isSecundaryCut == true)
                    {
                        tbcCoilsInfo.TabPages.Remove(tbpMainCoils);
                    }
                    else
                    {
                        tbcCoilsInfo.TabPages.Remove(tbpReprocessedCoils);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void getMainCoilByCode(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                objMainCoil = new clsMainCoil();
                
                objMainCoil.load(txtMainCoilCode.Text);


                if (objMainCoil.StatusName != "Cerrada")
                {
                    if (objMainCoil.fkBopp == objCuttingOrder.fkBopp)
                    {
                        txtUsedLength.Text = "0";
                        lblMachine.Text = objMainCoil.MachineName;
                        lblLot.Text = objMainCoil.lotNumber;
                        lblKgPerHour.Text = Convert.ToString(Math.Round(objMainCoil.productionKgHr, 2));
                        lblVelocity.Text = objMainCoil.velocity.ToString();
                        lblNetLength.Text = Convert.ToString(Math.Round(objMainCoil.netlength - objMainCoil.usedLength, 2));
                        lblWidht.Text = objMainCoil.width.ToString();
                        lblGramaje.Text = Convert.ToString(Math.Round(objMainCoil.gramaje, 2));
                        lblNetWeigth.Text = Convert.ToString(Math.Round(objMainCoil.netWeigth, 2));

                        txtUsedLength.Focus();
                    }
                    else if (objCuttingOrder.allowEquivalentFilm)
                    {
                        List<clsBopp> lstEquivalentFilms = clsBopp.getEquivalentFilmsByBoppFilm(objCuttingOrder.fkBopp);
                        bool isAllowed = false;

                        for (int i = 0; i < lstEquivalentFilms.Count; i++)
                        {
                            if (objMainCoil.fkBopp == lstEquivalentFilms[i].codsec)
                                isAllowed = true;
                        }

                        if (isAllowed)
                        {
                            txtUsedLength.Text = "0";
                            lblMachine.Text = objMainCoil.MachineName;
                            lblLot.Text = objMainCoil.lotNumber;
                            lblKgPerHour.Text = Convert.ToString(Math.Round(objMainCoil.productionKgHr, 2));
                            lblVelocity.Text = objMainCoil.velocity.ToString();
                            lblNetLength.Text = Convert.ToString(Math.Round(objMainCoil.netlength - objMainCoil.usedLength, 2));
                            lblWidht.Text = objMainCoil.width.ToString();
                            lblGramaje.Text = Convert.ToString(Math.Round(objMainCoil.gramaje, 2));
                            lblNetWeigth.Text = Convert.ToString(Math.Round(objMainCoil.netWeigth, 2));
                        }
                    }
                    else
                    {
                        MessageBox.Show("La película seleccionada no coincide con la requerida en la orden de corte.", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

                        objMainCoil = new clsMainCoil();
                        txtMainCoilCode.Clear();
                        lblMachine.Text = string.Empty;
                        lblKgPerHour.Text = string.Empty;
                        lblWidht.Text = string.Empty;
                        lblVelocity.Text = string.Empty;
                        lblGramaje.Text = string.Empty;
                        txtUsedLength.Clear();
                        lblLot.Text = string.Empty;
                        lblNetLength.Text = string.Empty;
                        lblNetWeigth.Text = string.Empty;
                        txtMainCoilCode.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("El código ingresado no corresponde a ninguna rollo madre registrada en el sistema o la rollo madre seleccionada ya ha sido cerrada.", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    lblDiameter.Text = "0";
                    lblDensity.Text = "0";
                    lblNetWeigth.Text = "0";
                    lblGrossWeigth.Text = "0";
                    lblLength.Text = "0";
                    lblBalance.Text = "";
                    lblWidth.Text = "0";
                    lblCoilProduct.Text = "";
                    txtCoilCode.Focus();
                }
            }
        }
        private void addMainCoil(object sender, EventArgs e)
        {
            if (objMainCoil.codsec > 0)
            {
                if (clsGlobal.isNumeric(txtUsedLength.Text))
                {
                    if (objMainCoil.fkBopp == objCuttingOrder.fkBopp)
                    {
                        clsMainCoilByCuttingStop objMainCoilByCuttingStop = new clsMainCoilByCuttingStop();
                        objMainCoilByCuttingStop.fkCuttingStop = Convert.ToInt32(grpbStop.Tag);
                        objMainCoilByCuttingStop.fkMainCoil = objMainCoil.codsec;
                        objMainCoilByCuttingStop.length = Convert.ToDouble(txtUsedLength.Text);
                        objMainCoilByCuttingStop.save();

                        if (objMainCoil.netlength - objMainCoil.usedLength - Convert.ToDouble(txtUsedLength.Text) < objMainCoil.netlength * 0.05)
                        {
                            if (MessageBox.Show("La rollo madre esta próxima a terminarse o ya se terminó, desea cerrar la rollo madre?", "Resumen de orden de corte", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                                objMainCoil.changeStatus("Cerrada");
                        }
                        else
                            objMainCoil.changeStatus("En proceso");

                        txtMainCoilCode.Text = "";
                        txtUsedLength.Text = "0";
                        lblMachine.Text = "";
                        lblLot.Text = "";
                        lblKgPerHour.Text = "0";
                        lblVelocity.Text = "0";
                        lblNetLength.Text = "0";
                        lblWidht.Text = "0";
                        lblGramaje.Text = "0";
                        lblNetWeigth.Text = "0";
                        txtMainCoilCode.Focus();
                        objCoil = new clsCoil();

                        objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index] = new clsCuttingStop(Convert.ToInt32(grpbStop.Tag));
                        dgvMainCoilList.Rows.Clear();

                        for (int i = 0; i < objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstMainCoilByCuttingStop.Count; i++)
                        {
                            dgvMainCoilList.Rows.Add();
                            dgvMainCoilList.Rows[i].Cells[0].Value = objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstMainCoilByCuttingStop[i].mainCoil.codsec;
                            dgvMainCoilList.Rows[i].Cells[1].Value = (new clsBopp(objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstMainCoilByCuttingStop[i].mainCoil.fkBopp)).name;
                            dgvMainCoilList.Rows[i].Cells[2].Value = objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstMainCoilByCuttingStop[i].mainCoil.code;
                            dgvMainCoilList.Rows[i].Cells[3].Value = objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstMainCoilByCuttingStop[i].mainCoil.lotNumber;
                            dgvMainCoilList.Rows[i].Cells[4].Value = objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstMainCoilByCuttingStop[i].mainCoil.labRating;
                            dgvMainCoilList.Rows[i].Cells[5].Value = objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstMainCoilByCuttingStop[i].mainCoil.initDate.ToString("dd/MM/yyyy HH:mm:ss");
                            dgvMainCoilList.Rows[i].Cells[6].Value = Convert.ToString(Math.Round(objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstMainCoilByCuttingStop[i].length, 2));
                            dgvMainCoilList.Rows[i].Cells[clmMainCoilEditLength.Index].Tag = "edit";
                            dgvMainCoilList.Rows[i].Cells[7].Value = global::BPS.Lite.Properties.Resources.pencil;
                            dgvMainCoilList.Rows[i].Cells[8].Value = global::BPS.Lite.Properties.Resources.cross;
                        }
                    }
                    else
                    {
                        MessageBox.Show("La película seleccionada no coincide con la requerida en la orden de corte.", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

                        objMainCoil = new clsMainCoil();
                        txtMainCoilCode.Text = "";
                        txtUsedLength.Text = "0";
                        lblMachine.Text = "";
                        lblLot.Text = "";
                        lblKgPerHour.Text = "0";
                        lblVelocity.Text = "0";
                        lblNetLength.Text = "0";
                        lblWidht.Text = "0";
                        lblGramaje.Text = "0";
                        lblNetWeigth.Text = "0";
                        txtMainCoilCode.Focus();
                    }
                }
                else
                    MessageBox.Show("El valor debe ser numérico.", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            else
                MessageBox.Show("Debe seleccionar un rollo madre.", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

        }
        private void cancelMainCoil(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta realmente seguro de cancelar Rollo Madre", "Rollo Madre", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtMainCoilCode.Text = "";
                txtUsedLength.Text = "";
                lblMachine.Text = "";
                lblLot.Text = "";
                lblKgPerHour.Text = "0";
                lblVelocity.Text = "0";
                lblNetLength.Text = "0";
                lblWidht.Text = "0";
                lblGramaje.Text = "0";
                lblNetWeigth.Text = "0";
                objCoil = new clsCoil();
            }
        }
        private void closeStop(object sender, EventArgs e)
        {
            if (validateToClose())
            {
                clsCuttingStop objCuttingStop = new clsCuttingStop(Convert.ToInt32(grpbStop.Tag));
                lstCoilsMainCodsecClose.Clear();
                if (objCuttingOrder.fkMachine == 7)
                {
                    if (clsEfficiencyCutExtruder.getEfficiencyCutExtruderByCuttingStopCodsec(objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].codsec))
                    {
                        if (objCuttingOrder.isSecundaryCut == false)
                        {
                            for (int j = 0; j < objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstMainCoilByCuttingStop.Count; j++)
                                lstCoilsMainCodsecClose.Add(objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstMainCoilByCuttingStop[j].mainCoil.codsec);
                        }
                        else
                        {
                            for (int i = 0; i < objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstSecundaryCutCoil.Count; i++)
                                lstCoilsSeqCodsecClose.Add(objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstSecundaryCutCoil[i].objCoil.codsec);
                        }

                        setMainCoilValues("toSave", objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].codsec);
                        setSeqCoilValues("toSave", objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].codsec);
                        setCoilValues("toSave", objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].codsec, objCuttingStop.lstCoil);

                        objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].digitizedBy = ((clsUser)cmbDigitizer.SelectedItem).codsec;
                        objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].operatedBy = ((clsUser)cmbOperator.SelectedItem).codsec;
                        objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].supervisedBy = ((clsUser)cmbSupervisor.SelectedItem).codsec;
                        objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].closed = true;
                        objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].save();

                        objCuttingOrder.load(objCuttingOrder.codsec);
                        TreeNode selNode = trvStopViews.SelectedNode;
                        getStopLayoutByCuttingStop(Convert.ToInt32(grpbStop.Tag));
                        setStopLayout();
                        trvStopViews.SelectedNode = selNode;
                    }
                    else
                        MessageBox.Show("La parada no puede ser cerrada ya que no están ingresados los datos de DESPERCIO en la parada " + objCuttingStop.position.ToString());
                }
                else 
                {
                    if (objCuttingOrder.isSecundaryCut == false)
                    {
                        for (int j = 0; j < objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstMainCoilByCuttingStop.Count; j++)
                            lstCoilsMainCodsecClose.Add(objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstMainCoilByCuttingStop[j].mainCoil.codsec);
                    }
                    else
                    {
                        for (int i = 0; i < objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstSecundaryCutCoil.Count; i++)
                            lstCoilsSeqCodsecClose.Add(objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstSecundaryCutCoil[i].objCoil.codsec);
                    }

                    setMainCoilValues("toSave", objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].codsec);
                    setSeqCoilValues("toSave", objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].codsec);
                    setCoilValues("toSave", objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].codsec, objCuttingStop.lstCoil);

                    objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].digitizedBy = ((clsUser)cmbDigitizer.SelectedItem).codsec;
                    objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].operatedBy = ((clsUser)cmbOperator.SelectedItem).codsec;
                    objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].supervisedBy = ((clsUser)cmbSupervisor.SelectedItem).codsec;
                    objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].closed = true;
                    objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].save();

                    objCuttingOrder.load(objCuttingOrder.codsec);
                    TreeNode selNode = trvStopViews.SelectedNode;
                    getStopLayoutByCuttingStop(Convert.ToInt32(grpbStop.Tag));
                    setStopLayout();
                    trvStopViews.SelectedNode = selNode;
                }
            }
        }

        private void setCoilValues(string destination, int CuttingStopCodsec, List<clsCoil> lstCoil)
        {
            try
            {
                switch (destination)
                {
                    case "toSave":
                        objEfficiencyCutExtruder = clsEfficiencyCutExtruder.getEfficiencyCutExtruderByCuttingOrder(CuttingStopCodsec);

                        objEfficiencyCutExtruder.coilsValues = "";
                        objEfficiencyCutExtruder.coilList = new List<int>();
                        for (int i = 0; i < lstCoil.Count; i++)
                        {
                            objEfficiencyCutExtruder.coilsValues += lstCoil[i].codsec.ToString();
                            objEfficiencyCutExtruder.coilsValues += (i < lstCoil.Count - 1) ? ";" : "";
                            objEfficiencyCutExtruder.coilList.Add(lstCoil[i].codsec);
                        }
                        objEfficiencyCutExtruder.saveCoil();
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Corte", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void setSeqCoilValues(string destination, int CuttingStopCodsec)
        {
            try
            {
                switch (destination)
                {
                    case "toSave":
                        objEfficiencyCutExtruder = clsEfficiencyCutExtruder.getEfficiencyCutExtruderByCuttingOrder(CuttingStopCodsec);

                        objEfficiencyCutExtruder.SeqCoilValues = "";
                        objEfficiencyCutExtruder.SeqCoilList = new List<int>();
                        for (int i = 0; i < lstCoilsSeqCodsecClose.Count; i++)
                        {
                            objEfficiencyCutExtruder.SeqCoilValues += lstCoilsSeqCodsecClose[i].ToString();
                            objEfficiencyCutExtruder.SeqCoilValues += (i < lstCoilsSeqCodsecClose.Count - 1) ? ";" : "";
                            objEfficiencyCutExtruder.SeqCoilList.Add(lstCoilsSeqCodsecClose[i]);
                        }
                        objEfficiencyCutExtruder.saveSeqCoil();
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Corte", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void setMainCoilValues(string destination, int CuttingStopCodsec)
        {
            try
            {
                switch (destination)
                {
                    case "toSave":
                        objEfficiencyCutExtruder = clsEfficiencyCutExtruder.getEfficiencyCutExtruderByCuttingOrder(CuttingStopCodsec);

                        objEfficiencyCutExtruder.MainCoilValues = "";
                        objEfficiencyCutExtruder.MainCoilList = new List<int>();
                        for (int i = 0; i < lstCoilsMainCodsecClose.Count; i++)
                        {
                            objEfficiencyCutExtruder.MainCoilValues += lstCoilsMainCodsecClose[i].ToString();
                            objEfficiencyCutExtruder.MainCoilValues += (i < lstCoilsMainCodsecClose.Count - 1) ? ";" : "";
                            objEfficiencyCutExtruder.MainCoilList.Add(lstCoilsMainCodsecClose[i]);
                        }
                        objEfficiencyCutExtruder.saveMainCoil();
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Corte", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void coilRegistration(object sender, EventArgs e)
        {
            if (validateToClose())
            {
                clsCuttingStop objCuttingStop = new clsCuttingStop(Convert.ToInt32(grpbStop.Tag));
                objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].digitizedBy = ((clsUser)cmbDigitizer.SelectedItem).codsec;
                objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].operatedBy = ((clsUser)cmbOperator.SelectedItem).codsec;
                objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].supervisedBy = ((clsUser)cmbSupervisor.SelectedItem).codsec;
                objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].save();

                /*frmCuttingOrderSummary winCOSum = new frmCuttingOrderSummary(objCuttingOrder.codsec);
                winCOSum.StartPosition = FormStartPosition.CenterParent;
                winCOSum.ShowDialog(this);*/

                /*frmNewCoilRegistration winCoilRegistration = new frmNewCoilRegistration(Convert.ToInt32(grpbStop.Tag));
                winCoilRegistration.StartPosition = FormStartPosition.CenterParent;
                winCoilRegistration.ShowDialog(this);*/
                
                frmCoilRegistration winCoilRegistration = new frmCoilRegistration(Convert.ToInt32(grpbStop.Tag));
                winCoilRegistration.StartPosition = FormStartPosition.CenterParent;
                winCoilRegistration.ShowDialog(this);

                objCuttingOrder.load(objCuttingOrder.codsec);
                TreeNode selNode = trvStopViews.SelectedNode;
                getStopLayoutByCuttingStop(Convert.ToInt32(grpbStop.Tag));
                setStopLayout();
                trvStopViews.SelectedNode = selNode;
            }
            else
            {
                MessageBox.Show("Por favor, primero registre al supervisor, digitador y operador antes de registrar a las bobinas.", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (flgCloseCuttingOrder == false)
            {
                if (MessageBox.Show("Desea suspender temporalmente la orden de corte?", "Resumen de orden de corte", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
                    objCuttingOrder.changeStatus("En pausa");
                    MessageBox.Show("La orden de corte ha sido pausada.", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    frmCuttingOrderList winCuttingOrderList = new frmCuttingOrderList(objCuttingOrder.fkMachine,true);
                    winCuttingOrderList.StartPosition = FormStartPosition.Manual;
                    winCuttingOrderList.MdiParent = this.MdiParent;
                    winCuttingOrderList.Show();
                    this.Close();
                }
            }
            else
            {
                if (MessageBox.Show("Desea cerrar permanentemente la orden de corte?", "Resumen de orden de corte", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
                    objCuttingOrder.changeStatus("Cerrada");
                    MessageBox.Show("La orden de corte ha sido cerrada.", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    frmCuttingOrderList winCuttingOrderList = new frmCuttingOrderList(objCuttingOrder.fkMachine,true);
                    winCuttingOrderList.StartPosition = FormStartPosition.Manual;
                    winCuttingOrderList.MdiParent = this.MdiParent;
                    winCuttingOrderList.Show();
                    this.Close();
                }
            }
        }

        private void chkForceClose_CheckedChanged(object sender, EventArgs e)
        {
            if (chkForceClose.Checked)
            {
                if (MessageBox.Show("Una vez cerrada la orden de corte no podrá ser activada nuevamente, desea continuar?", "Resumen de orden de corte", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
                    btnProcess.Image = global::BPS.Lite.Properties.Resources._lock;
                    btnProcess.Text = "Cerrar";
                    flgCloseCuttingOrder = true;
                }
            }
            else
            {
                btnProcess.Image = global::BPS.Lite.Properties.Resources.Pause_Hot;
                btnProcess.Text = "Pausar";
                flgCloseCuttingOrder = false;
            }
        }

        private void trvStopViews_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                getStopLayoutByCuttingStop(Convert.ToInt32(e.Node.Tag));
                grpbStop.Enabled = true;
            }
            else
            {
                grpbStop.Enabled = false;
                grpbStop.Text = "";
                dgvCoilsDetail.Rows.Clear();
                tbcCoilsInfo.TabIndex = 0;
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (objCuttingOrder.codsec != 0)
            {
                frmCuttingOrdersReport winCuttingOrderReport = new frmCuttingOrdersReport(objCuttingOrder.codsec);
                winCuttingOrderReport.StartPosition = FormStartPosition.Manual;
                winCuttingOrderReport.Show();
            }
            else
                MessageBox.Show("A sucedido un error", "Ordenes de Corte", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cmbSupervisor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsUser> lstUsers = clsUser.getListByRole("Supervisor de corte");
                cmbSupervisor.Items.Clear();
                for (int j = 0; j < lstUsers.Count; j++)
                    cmbSupervisor.Items.Add(lstUsers[j]);
            }
        }

        private void cmbDigitizer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsUser> lstUsers = clsUser.getListByRole("Digitador de corte");
                cmbDigitizer.Items.Clear();
                for (int j = 0; j < lstUsers.Count; j++)
                    cmbDigitizer.Items.Add(lstUsers[j]);
            }
        }

        private void cmbOperator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsUser> lstUsers = clsUser.getListByRole("Operadores de corte");
                cmbOperator.Items.Clear();
                for (int j = 0; j < lstUsers.Count; j++)
                    cmbOperator.Items.Add(lstUsers[j]);
            }
        }

        private void dgvMainCoilList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmMainCoilEditLength.Index)
            {
                if (dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilEditLength.Index].Tag.ToString() == "edit")
                {
                    dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilUsedLenth.Index].ReadOnly = false;
                    dgvMainCoilList.CurrentCell = dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilUsedLenth.Index];
                    dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilEditLength.Index].Tag = "save";
                    dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilEditLength.Index].Value = global::BPS.Lite.Properties.Resources.disk;
                }
                else
                {
                    List<clsMainCoilByCuttingStop> lstMainCoilByCuttingStop = clsMainCoilByCuttingStop.getListByCuttingStop(Convert.ToInt32(grpbStop.Tag));

                    for (int i = 0; i < lstMainCoilByCuttingStop.Count; i++)
                    {
                        if (lstMainCoilByCuttingStop[i].fkMainCoil == Convert.ToInt32(dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilListCodsec.Index].Value))
                        {
                            lstMainCoilByCuttingStop[i].length = Convert.ToDouble(dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilUsedLenth.Index].Value);
                            lstMainCoilByCuttingStop[i].save();
                            i = lstMainCoilByCuttingStop.Count;
                        }
                    }

                    objCuttingOrder = new clsCuttingOrder(objCuttingOrder.codsec);

                    dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilUsedLenth.Index].ReadOnly = true;
                    dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilEditLength.Index].Tag = "edit";
                    dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilEditLength.Index].Value = global::BPS.Lite.Properties.Resources.pencil;
                }

            }
            if (e.ColumnIndex == clmMainCoilDelete.Index)
            {
                if (MessageBox.Show("Desea eliminar la rollo madre registrada?", "Resumen de orden de corte", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
                    List<clsMainCoilByCuttingStop> lstMainCoilByCuttingStop = clsMainCoilByCuttingStop.getListByCuttingStop(Convert.ToInt32(grpbStop.Tag));

                    for (int i = 0; i < lstMainCoilByCuttingStop.Count; i++)
                    {
                        if (lstMainCoilByCuttingStop[i].fkMainCoil == Convert.ToInt32(dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilListCodsec.Index].Value))
                        {
                            clsMainCoilByCuttingStop.delete(lstMainCoilByCuttingStop[i].codsec);
                            i = lstMainCoilByCuttingStop.Count;
                        }
                    }

                    objCuttingOrder = new clsCuttingOrder(objCuttingOrder.codsec);
                    dgvMainCoilList.Rows.Clear();

                    for (int i = 0; i < objCuttingOrder.lstCuttingStop.Count; i++)
                    {

                        if (objCuttingOrder.lstCuttingStop[i].codsec == Convert.ToInt32(grpbStop.Tag))
                        {
                            for (int j = 0; j < objCuttingOrder.lstCuttingStop[i].lstMainCoilByCuttingStop.Count; j++)
                            {
                                dgvMainCoilList.Rows.Add();
                                dgvMainCoilList.Rows[j].Cells[clmMainCoilListCodsec.Index].Value = objCuttingOrder.lstCuttingStop[i].lstMainCoilByCuttingStop[j].mainCoil.codsec;
                                dgvMainCoilList.Rows[j].Cells[clmMainCoilListFilm.Index].Value = (new clsBopp(objCuttingOrder.lstCuttingStop[i].lstMainCoilByCuttingStop[j].mainCoil.fkBopp)).name;
                                dgvMainCoilList.Rows[j].Cells[clmMainCoilListCode.Index].Value = objCuttingOrder.lstCuttingStop[i].lstMainCoilByCuttingStop[j].mainCoil.code;
                                dgvMainCoilList.Rows[j].Cells[clmMainCoilListBatch.Index].Value = objCuttingOrder.lstCuttingStop[i].lstMainCoilByCuttingStop[j].mainCoil.lotNumber;
                                dgvMainCoilList.Rows[j].Cells[clmMainCoilListLabRating.Index].Value = objCuttingOrder.lstCuttingStop[i].lstMainCoilByCuttingStop[j].mainCoil.labRating;
                                dgvMainCoilList.Rows[j].Cells[clmMainCoilListInitDate.Index].Value = objCuttingOrder.lstCuttingStop[i].lstMainCoilByCuttingStop[j].mainCoil.initDate.ToString("dd/MM/yyyy HH:mm:ss");
                                dgvMainCoilList.Rows[j].Cells[clmMainCoilUsedLenth.Index].Value = Convert.ToString(Math.Round(objCuttingOrder.lstCuttingStop[i].lstMainCoilByCuttingStop[j].length, 2));
                                dgvMainCoilList.Rows[j].Cells[clmMainCoilEditLength.Index].Value = global::BPS.Lite.Properties.Resources.pencil;
                                dgvMainCoilList.Rows[j].Cells[clmMainCoilDelete.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                            }
                            i = objCuttingOrder.lstCuttingStop.Count;
                        }
                    }
                }
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCoilCode.Text != string.Empty)
                {
                    getCoilInformation(txtCoilCode.Text);

                    objCoil = new clsCoil();
                    objCoil = clsCoil.getDetailByCode(txtCoilCode.Text);

                    if (objCoil.codsec > 0)
                    {
                        if (objCoil.Coil_CoilCellarContainer.name == "Conversión" || objCoil.Coil_CoilCellarContainer.name == "Producto en Proceso" || objCoil.Coil_CoilCellarContainer.name == "Bobinas Base y metalizado" || objCoil.Coil_CoilCellarContainer.name == "Corte, metalizado y empaque" || objCoil.Coil_CoilCellarContainer.name == "Producto en Proceso Pilar" || objCoil.Coil_CoilCellarContainer.name == "Rack Metalizado")
                        {
                            if (objCoil.statusName == "Activa" || objCoil.statusName == "Reprocesada")
                            {
                                clsProduct ObjProduct = new clsProduct(objCuttingOrder.fkProduct);
                                if (ObjProduct.boppCode != string.Empty)
                                {
                                    clsProduct ObjProductCoil = new clsProduct(objCoil.fkProduct);
                                    if (ObjProduct.boppCode == ObjProductCoil.boppCode)
                                    {
                                        getCoilInformation(txtCoilCode.Text);
                                        txtUsedCoilLength.Focus();
                                    }
                                    else
                                    {
                                        MessageBox.Show("La película seleccionada es " + ObjProduct.boppCode + " y la bobina seleccionada es un " + ObjProductCoil.boppCode + " para que usted pueda reprocesar debe ingresar una bobina con la misma película de la orden de corte", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                        txtCoilCode.Text = string.Empty;
                                        lblCoilProduct.Text = string.Empty;
                                        txtUsedCoilLength.Text = string.Empty;
                                        lblDensity.Text = string.Empty;
                                        lblLength.Text = string.Empty;
                                        lblDiameter.Text = string.Empty;
                                        label4.Text = string.Empty;
                                        lblBalance.Text = string.Empty;
                                        lblWidth.Text = string.Empty;
                                        lblGrossWeigth.Text = string.Empty;
                                    }

                                }
                                else if (ObjProduct.castCode != string.Empty)
                                {
                                    clsProduct ObjProductCoil = new clsProduct(objCoil.fkProduct);
                                    if (ObjProduct.castCode == ObjProductCoil.castCode)
                                    {
                                        getCoilInformation(txtCoilCode.Text);
                                        txtUsedCoilLength.Focus();
                                    }
                                    else
                                    {
                                        MessageBox.Show("La película seleccionada es " + ObjProduct.castCode + " y la bobina seleccionada es un " + ObjProductCoil.castCode + " para que usted pueda reprocesar debe ingresar una bobina con la misma película de la orden de corte", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                        txtCoilCode.Text = string.Empty;
                                        lblCoilProduct.Text = string.Empty;
                                        txtUsedCoilLength.Text = string.Empty;
                                        lblDensity.Text = string.Empty;
                                        lblLength.Text = string.Empty;
                                        lblDiameter.Text = string.Empty;
                                        label4.Text = string.Empty;
                                        lblBalance.Text = string.Empty;
                                        lblWidth.Text = string.Empty;
                                        lblGrossWeigth.Text = string.Empty;
                                    }
                                }
                                else
                                {

                                    MessageBox.Show("El código ingresado no corresponde a ninguna bobina registrada en el sistema o la bobina seleccionada ya ha sido cerrada.", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

                                    txtCoilCode.Text = string.Empty;
                                    lblCoilProduct.Text = string.Empty;
                                    txtUsedCoilLength.Text = string.Empty;
                                    lblDensity.Text = string.Empty;
                                    lblLength.Text = string.Empty;
                                    lblDiameter.Text = string.Empty;
                                    label4.Text = string.Empty;
                                    lblBalance.Text = string.Empty;
                                    lblWidth.Text = string.Empty;
                                    lblGrossWeigth.Text = string.Empty;
                                }

                            }
                            else
                            {
                                MessageBox.Show("El código ingresado no corresponde a ninguna bobina registrada en el sistema o la bobina seleccionada ya ha sido cerrada.", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

                                txtCoilCode.Text = string.Empty;
                                lblCoilProduct.Text = string.Empty;
                                txtUsedCoilLength.Text = string.Empty;
                                lblDensity.Text = string.Empty;
                                lblLength.Text = string.Empty;
                                lblDiameter.Text = string.Empty;
                                label4.Text = string.Empty;
                                lblBalance.Text = string.Empty;
                                lblWidth.Text = string.Empty;
                                lblGrossWeigth.Text = string.Empty;
                            }
                        }
                        else
                        {
                            MessageBox.Show("La bobina seleccionada se encuentra en la bodega de " + objCoil.Coil_CoilCellarContainer.name + " es necesario que las bobinas o el pallets\r\n Se encuentre en PLANTA - CORTE - PROCESO para que pueda ingresar al reproceso\r\n Solicite a bodega que libere el pallet para poder continuar con la ejecución de la orden de corte secundario", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);

                            txtCoilCode.Text = string.Empty;
                            lblCoilProduct.Text = string.Empty;
                            txtUsedCoilLength.Text = string.Empty;
                            lblDensity.Text = string.Empty;
                            lblLength.Text = string.Empty;
                            lblDiameter.Text = string.Empty;
                            label4.Text = string.Empty;
                            lblBalance.Text = string.Empty;
                            lblWidth.Text = string.Empty;
                            lblGrossWeigth.Text = string.Empty;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El código ingresado no corresponde a ninguna bobina registrada en el sistema o la bobina seleccionada ya ha sido cerrada.", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);

                        txtCoilCode.Text = string.Empty;
                        lblCoilProduct.Text = string.Empty;
                        txtUsedCoilLength.Text = string.Empty;
                        lblDensity.Text = string.Empty;
                        lblLength.Text = string.Empty;
                        lblDiameter.Text = string.Empty;
                        label4.Text = string.Empty;
                        lblBalance.Text = string.Empty;
                        lblWidth.Text = string.Empty;
                        lblGrossWeigth.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("El código de la bobina no puede estar vacio por favor ingrese el código nuevamente", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    txtCoilCode.Text = string.Empty;
                    lblCoilProduct.Text = string.Empty;
                    txtUsedCoilLength.Text = string.Empty;
                    lblDensity.Text = string.Empty;
                    lblLength.Text = string.Empty;
                    lblDiameter.Text = string.Empty;
                    label4.Text = string.Empty;
                    lblBalance.Text = string.Empty;
                    lblWidth.Text = string.Empty;
                    lblGrossWeigth.Text = string.Empty;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (clsGlobal.isNumeric(txtUsedCoilLength.Text))
            {
                if (txtCoilCode.Text != string.Empty)
                {
                    objCoil = new clsCoil();
                    objCoil = clsCoil.getDetailByCode(txtCoilCode.Text);
                    if (objCoil.codsec > 0)
                    {
                        if (objCoil.Coil_CoilCellarContainer.name == "Conversión" || objCoil.Coil_CoilCellarContainer.name == "Producto en Proceso" || objCoil.Coil_CoilCellarContainer.name == "Bobinas Base y metalizado" || objCoil.Coil_CoilCellarContainer.name == "Corte, metalizado y empaque" || objCoil.Coil_CoilCellarContainer.name == "Producto en Proceso Pilar" || objCoil.Coil_CoilCellarContainer.name == "Rack Metalizado")
                        {
                            if (objCoil.statusName == "Activa" || objCoil.statusName == "Reprocesada")
                            {
                                clsProduct ObjProduct = new clsProduct(objCuttingOrder.fkProduct);
                                if (ObjProduct.boppCode != string.Empty)
                                {
                                    clsProduct ObjProductCoil = new clsProduct(objCoil.fkProduct);
                                    if (ObjProduct.boppCode == ObjProductCoil.boppCode)
                                    {
                                        clsPallet objOriginPallet = new clsPallet(clsCoil.getContainerPalletCodsecByCoil(objCoil.codsec));
                                        
                                            if(objOriginPallet.codsec==0)
                                            {
                                                objOriginPallet.removeCoilToPallet(objCoil.codsec);
                                                clsCoilBySecundaryCuttingStop objCoilBySecundaryCuttingStop = new clsCoilBySecundaryCuttingStop();
                                                objCoilBySecundaryCuttingStop.fkCuttingStop = Convert.ToInt32(grpbStop.Tag);
                                                objCoilBySecundaryCuttingStop.fkCoil = objCoil.codsec;
                                                objCoilBySecundaryCuttingStop.length = Convert.ToDouble(txtUsedCoilLength.Text);
                                                objCoilBySecundaryCuttingStop.save();

                                                DataSet DS = new DataSet();

                                                DS = clsConnection.getDataSetResult("CALL spUsedLengthByCoil(" + objCoil.codsec.ToString() + ")");

                                                if (DS.Tables[0].Rows.Count > 0)
                                                {
                                                    if (MessageBox.Show("Ya se usaron " + DS.Tables[0].Rows[0]["usedLen"].ToString()+" metros de un total de "+objCoil.length.ToString()+". ¿Desea cerrar la bobina?", "Resumen de orden de corte", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                                                        clsCoil.setCoilAsReprocesed(objCoil.codsec);
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Se produjo un error, consulte a sistemas");
                                                }
                                                

                                                //else
                                                //objMainCoil.changeStatus("En proceso");
                                                lblDiameter.Text = "0";
                                                lblDensity.Text = "0";
                                                lblNetWeigth.Text = "0";
                                                lblGrossWeigth.Text = "0";
                                                lblLength.Text = "0";
                                                lblBalance.Text = "";
                                                lblWidth.Text = "0";
                                                lblCoilProduct.Text = "";
                                                txtCoilCode.Text = "";
                                                txtUsedCoilLength.Text = "";
                                                txtCoilCode.Focus();

                                                objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index] = new clsCuttingStop(Convert.ToInt32(grpbStop.Tag));
                                                dgvCoilsSecundaryCut.Rows.Clear();

                                                for (int i = 0; i < objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstSecundaryCutCoil.Count; i++)
                                                {
                                                    dgvCoilsSecundaryCut.Rows.Add();
                                                    dgvCoilsSecundaryCut.Rows[i].Cells[clmCodsec.Index].Value = objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstSecundaryCutCoil[i].objCoil.codsec;
                                                    dgvCoilsSecundaryCut.Rows[i].Cells[clmCode.Index].Value = objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstSecundaryCutCoil[i].objCoil.code;
                                                    dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilProduct.Index].Value = (new clsProduct(objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstSecundaryCutCoil[i].objCoil.fkProduct)).code;
                                                    dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilDiameter.Index].Value = objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstSecundaryCutCoil[i].objCoil.diameter;
                                                    dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilCore.Index].Value = (new clsProduct(objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstSecundaryCutCoil[i].objCoil.codsec)).CoreValue.ToString() + "\"";
                                                    dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilWidth.Index].Value = objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstSecundaryCutCoil[i].objCoil.width;
                                                    dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilLength.Index].Value = objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstSecundaryCutCoil[i].objCoil.length;
                                                    dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilUsedLength.Index].Value = Convert.ToString(Math.Round(objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstSecundaryCutCoil[i].length, 2));
                                                    dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilEdit.Index].Tag = "edit";
                                                    dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilEdit.Index].Value = global::BPS.Lite.Properties.Resources.pencil;
                                                    dgvCoilsSecundaryCut.Rows[i].Cells[clmCoildelete.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("No se puede reprocesar una bobina que este dentro de un pallet. Quite la bobina del pallet para poder reprocesar.");
                                            }
                                        
                                    }
                                    else
                                    {
                                        MessageBox.Show("La película seleccionada es " + ObjProduct.boppCode + " y la bobina seleccionada es un " + ObjProductCoil.boppCode + " para que usted pueda reprocesar debe ingresar una bobina con la misma película de la orden de corte", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                        txtCoilCode.Text = string.Empty;
                                        lblCoilProduct.Text = string.Empty;
                                        txtUsedCoilLength.Text = string.Empty;
                                        lblDensity.Text = string.Empty;
                                        lblLength.Text = string.Empty;
                                        lblDiameter.Text = string.Empty;
                                        label4.Text = string.Empty;
                                        lblBalance.Text = string.Empty;
                                        lblWidth.Text = string.Empty;
                                        lblGrossWeigth.Text = string.Empty;
                                    }
                                }
                                else if (ObjProduct.castCode != string.Empty)
                                {
                                    clsProduct ObjProductCoil = new clsProduct(objCoil.fkProduct);
                                    if (ObjProduct.castCode == ObjProductCoil.castCode)
                                    {
                                        clsPallet objOriginPallet = new clsPallet(clsCoil.getContainerPalletCodsecByCoil(objCoil.codsec));
                                        if (objOriginPallet.fkStatus == 40)
                                            MessageBox.Show("No puede reabrir un pallet despachado", "Resumen de Orden de Corte", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                        else
                                        {
                                            if (objOriginPallet.open())
                                            {
                                                objOriginPallet.removeCoilToPallet(objCoil.codsec);
                                                clsCoilBySecundaryCuttingStop objCoilBySecundaryCuttingStop = new clsCoilBySecundaryCuttingStop();
                                                objCoilBySecundaryCuttingStop.fkCuttingStop = Convert.ToInt32(grpbStop.Tag);
                                                objCoilBySecundaryCuttingStop.fkCoil = objCoil.codsec;
                                                objCoilBySecundaryCuttingStop.length = Convert.ToDouble(txtUsedCoilLength.Text);
                                                objCoilBySecundaryCuttingStop.save();

                                                clsCoil.setCoilAsReprocesed(objCoil.codsec);

                                                //else
                                                //objMainCoil.changeStatus("En proceso");
                                                lblDiameter.Text = "0";
                                                lblDensity.Text = "0";
                                                lblNetWeigth.Text = "0";
                                                lblGrossWeigth.Text = "0";
                                                lblLength.Text = "0";
                                                lblBalance.Text = "";
                                                lblWidth.Text = "0";
                                                lblCoilProduct.Text = "";
                                                txtCoilCode.Text = "";
                                                txtUsedCoilLength.Text = "";
                                                txtCoilCode.Focus();

                                                objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index] = new clsCuttingStop(Convert.ToInt32(grpbStop.Tag));
                                                dgvCoilsSecundaryCut.Rows.Clear();

                                                for (int i = 0; i < objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstSecundaryCutCoil.Count; i++)
                                                {
                                                    dgvCoilsSecundaryCut.Rows.Add();
                                                    dgvCoilsSecundaryCut.Rows[i].Cells[clmCodsec.Index].Value = objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstSecundaryCutCoil[i].objCoil.codsec;
                                                    dgvCoilsSecundaryCut.Rows[i].Cells[clmCode.Index].Value = objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstSecundaryCutCoil[i].objCoil.code;
                                                    dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilProduct.Index].Value = (new clsProduct(objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstSecundaryCutCoil[i].objCoil.fkProduct)).code;
                                                    dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilDiameter.Index].Value = objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstSecundaryCutCoil[i].objCoil.diameter;
                                                    dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilCore.Index].Value = (new clsProduct(objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstSecundaryCutCoil[i].objCoil.codsec)).CoreValue.ToString() + "\"";
                                                    dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilWidth.Index].Value = objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstSecundaryCutCoil[i].objCoil.width;
                                                    dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilLength.Index].Value = objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstSecundaryCutCoil[i].objCoil.length;
                                                    dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilUsedLength.Index].Value = Convert.ToString(Math.Round(objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstSecundaryCutCoil[i].length, 2));
                                                    dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilEdit.Index].Tag = "edit";
                                                    dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilEdit.Index].Value = global::BPS.Lite.Properties.Resources.pencil;
                                                    dgvCoilsSecundaryCut.Rows[i].Cells[clmCoildelete.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("La película seleccionada es " + ObjProduct.castCode + " y la bobina seleccionada es un " + ObjProductCoil.castCode + " para que usted pueda reprocesar debe ingresar una bobina con la misma película de la orden de corte", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                        txtCoilCode.Text = string.Empty;
                                        lblCoilProduct.Text = string.Empty;
                                        txtUsedCoilLength.Text = string.Empty;
                                        lblDensity.Text = string.Empty;
                                        lblLength.Text = string.Empty;
                                        lblDiameter.Text = string.Empty;
                                        label4.Text = string.Empty;
                                        lblBalance.Text = string.Empty;
                                        lblWidth.Text = string.Empty;
                                        lblGrossWeigth.Text = string.Empty;
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("El código ingresado no corresponde a ninguna bobina registrada en el sistema o la bobina seleccionada ya ha sido cerrada.", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                txtCoilCode.Text = string.Empty;
                                lblCoilProduct.Text = string.Empty;
                                txtUsedCoilLength.Text = string.Empty;
                                lblDensity.Text = string.Empty;
                                lblLength.Text = string.Empty;
                                lblDiameter.Text = string.Empty;
                                label4.Text = string.Empty;
                                lblBalance.Text = string.Empty;
                                lblWidth.Text = string.Empty;
                                lblGrossWeigth.Text = string.Empty;
                            }
                        }
                        else
                        {
                            MessageBox.Show("La bobina seleccionada se encuentra en la bodega de " + objCoil.Coil_CoilCellarContainer.name + " es necesario que las bobinas o el pallets\r\n Se encuentre en PLANTA - CORTE - PROCESO para que pueda ingresar al reproceso\r\n Solicite a bodega que libere el pallet para poder continuar con la ejecución de la orden de corte secundario", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            txtCoilCode.Text = string.Empty;
                            lblCoilProduct.Text = string.Empty;
                            txtUsedCoilLength.Text = string.Empty;
                            lblDensity.Text = string.Empty;
                            lblLength.Text = string.Empty;
                            lblDiameter.Text = string.Empty;
                            label4.Text = string.Empty;
                            lblBalance.Text = string.Empty;
                            lblWidth.Text = string.Empty;
                            lblGrossWeigth.Text = string.Empty;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El código ingresado no corresponde a ninguna bobina registrada en el sistema o la bobina seleccionada ya ha sido cerrada.", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        txtCoilCode.Text = string.Empty;
                        lblCoilProduct.Text = string.Empty;
                        txtUsedCoilLength.Text = string.Empty;
                        lblDensity.Text = string.Empty;
                        lblLength.Text = string.Empty;
                        lblDiameter.Text = string.Empty;
                        label4.Text = string.Empty;
                        lblBalance.Text = string.Empty;
                        lblWidth.Text = string.Empty;
                        lblGrossWeigth.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("El código ingresado no corresponde a ninguna bobina registrada en el sistema o la bobina seleccionada ya ha sido cerrada.", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    txtCoilCode.Text = string.Empty;
                    lblCoilProduct.Text = string.Empty;
                    txtUsedCoilLength.Text = string.Empty;
                    lblDensity.Text = string.Empty;
                    lblLength.Text = string.Empty;
                    lblDiameter.Text = string.Empty;
                    label4.Text = string.Empty;
                    lblBalance.Text = string.Empty;
                    lblWidth.Text = string.Empty;
                    lblGrossWeigth.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Para poder adicionar una bobina de reproceso debe llenar los campos de Código y Metraje. Por favor vuelva a ingresar nuevamente y asegúrese de que los campos mencionados estén llenos.", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                txtCoilCode.Text = string.Empty;
                lblCoilProduct.Text = string.Empty;
                txtUsedCoilLength.Text = string.Empty;
                lblDensity.Text = string.Empty;
                lblLength.Text = string.Empty;
                lblDiameter.Text = string.Empty;
                label4.Text = string.Empty;
                lblBalance.Text = string.Empty;
                lblWidth.Text = string.Empty;
                lblGrossWeigth.Text = string.Empty;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblDiameter.Text = "0";
            lblDensity.Text = "0";
            lblNetWeigth.Text = "0";
            lblGrossWeigth.Text = "0";
            lblLength.Text = "0";
            lblBalance.Text = "";
            lblWidth.Text = "0";
            lblCoilProduct.Text = "";
            txtCoilCode.Focus();
        }

        private void dgvCoilsSecundaryCut_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmCoilEdit.Index)
            {
                if (dgvCoilsSecundaryCut.Rows[e.RowIndex].Cells[clmCoilEdit.Index].Tag.ToString() == "edit")
                {
                    dgvCoilsSecundaryCut.Rows[e.RowIndex].Cells[clmCoilUsedLength.Index].ReadOnly = false;
                    dgvCoilsSecundaryCut.CurrentCell = dgvCoilsSecundaryCut.Rows[e.RowIndex].Cells[clmCoilUsedLength.Index];
                    dgvCoilsSecundaryCut.Rows[e.RowIndex].Cells[clmCoilEdit.Index].Tag = "save";
                    dgvCoilsSecundaryCut.Rows[e.RowIndex].Cells[clmCoilEdit.Index].Value = global::BPS.Lite.Properties.Resources.disk;
                }
                else
                {
                    List<clsCoilBySecundaryCuttingStop> lstCoilBySecundaryCuttingStop = clsCoilBySecundaryCuttingStop.getListByCuttingStop(Convert.ToInt32(grpbStop.Tag));

                    for (int i = 0; i < lstCoilBySecundaryCuttingStop.Count; i++)
                    {
                        if (lstCoilBySecundaryCuttingStop[i].fkCoil == Convert.ToInt32(dgvCoilsSecundaryCut.Rows[e.RowIndex].Cells[clmCoilCode.Index].Value))
                        {
                            lstCoilBySecundaryCuttingStop[i].length = Convert.ToDouble(dgvCoilsSecundaryCut.Rows[e.RowIndex].Cells[clmCoilUsedLength.Index].Value);
                            lstCoilBySecundaryCuttingStop[i].save();
                            i = lstCoilBySecundaryCuttingStop.Count;
                        }
                    }

                    objCuttingOrder = new clsCuttingOrder(objCuttingOrder.codsec);

                    dgvCoilsSecundaryCut.Rows[e.RowIndex].Cells[clmCoilUsedLength.Index].ReadOnly = true;
                    dgvCoilsSecundaryCut.Rows[e.RowIndex].Cells[clmCoilEdit.Index].Tag = "edit";
                    dgvCoilsSecundaryCut.Rows[e.RowIndex].Cells[clmCoilEdit.Index].Value = global::BPS.Lite.Properties.Resources.pencil;
                }

            }
            if (e.ColumnIndex == clmCoildelete.Index)
            {
                if (MessageBox.Show("Desea eliminar la bobina seleccionada?", "Resumen de orden de corte", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
                    List<clsCoilBySecundaryCuttingStop> lstCoilBySecundaryCuttingStop = clsCoilBySecundaryCuttingStop.getListByCuttingStop(Convert.ToInt32(grpbStop.Tag));

                    for (int i = 0; i < lstCoilBySecundaryCuttingStop.Count; i++)
                    {
                        if (lstCoilBySecundaryCuttingStop[i].fkCoil == Convert.ToInt32(dgvCoilsSecundaryCut.Rows[e.RowIndex].Cells[clmCoilCode.Index].Value))
                        {
                            clsCoilBySecundaryCuttingStop.delete(lstCoilBySecundaryCuttingStop[i].codsec);
                            i = lstCoilBySecundaryCuttingStop.Count;
                        }
                    }

                    objCuttingOrder = new clsCuttingOrder(objCuttingOrder.codsec);
                    dgvCoilsSecundaryCut.Rows.Clear();

                    for (int i = 0; i < objCuttingOrder.lstCuttingStop.Count; i++)
                    {

                        if (objCuttingOrder.lstCuttingStop[i].codsec == Convert.ToInt32(grpbStop.Tag))
                        {
                            for (int j = 0; j < objCuttingOrder.lstCuttingStop[i].lstSecundaryCutCoil.Count; j++)
                            {
                                dgvCoilsSecundaryCut.Rows.Add();
                                dgvCoilsSecundaryCut.Rows[j].Cells[clmCodsec.Index].Value = objCuttingOrder.lstCuttingStop[i].lstSecundaryCutCoil[j].objCoil.codsec;
                                dgvCoilsSecundaryCut.Rows[j].Cells[clmCode.Index].Value = objCuttingOrder.lstCuttingStop[i].lstSecundaryCutCoil[j].objCoil.code;
                                dgvCoilsSecundaryCut.Rows[j].Cells[clmCoilProduct.Index].Value = (new clsProduct(objCuttingOrder.lstCuttingStop[i].lstSecundaryCutCoil[j].objCoil.fkProduct)).code;
                                dgvCoilsSecundaryCut.Rows[j].Cells[clmCoilDiameter.Index].Value = objCuttingOrder.lstCuttingStop[i].lstSecundaryCutCoil[j].objCoil.diameter;
                                dgvCoilsSecundaryCut.Rows[j].Cells[clmCoilCore.Index].Value = (new clsProduct(objCuttingOrder.lstCuttingStop[i].lstSecundaryCutCoil[j].objCoil.codsec)).CoreValue.ToString() + "\"";
                                dgvCoilsSecundaryCut.Rows[j].Cells[clmCoilWidth.Index].Value = objCuttingOrder.lstCuttingStop[i].lstSecundaryCutCoil[j].objCoil.width;
                                dgvCoilsSecundaryCut.Rows[j].Cells[clmCoilLength.Index].Value = objCuttingOrder.lstCuttingStop[i].lstSecundaryCutCoil[j].objCoil.length;
                                dgvCoilsSecundaryCut.Rows[j].Cells[clmCoilUsedLength.Index].Value = Convert.ToString(Math.Round(objCuttingOrder.lstCuttingStop[i].lstSecundaryCutCoil[j].length, 2));
                                dgvCoilsSecundaryCut.Rows[j].Cells[clmCoilEdit.Index].Value = global::BPS.Lite.Properties.Resources.pencil;
                                dgvCoilsSecundaryCut.Rows[j].Cells[clmCoildelete.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                            }
                            i = objCuttingOrder.lstCuttingStop.Count;
                        }
                    }
                }
            }
        }

        private void txtUsedCoilLength_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (clsGlobal.isNumeric(txtUsedCoilLength.Text))
                {
                    if (txtCoilCode.Text != string.Empty)
                    {
                        objCoil = new clsCoil();
                        objCoil = clsCoil.getDetailByCode(txtCoilCode.Text);
                        if (objCoil.codsec > 0)
                        {
                            if (objCoil.Coil_CoilCellarContainer.name == "Conversión" || objCoil.Coil_CoilCellarContainer.name == "Producto en Proceso" || objCoil.Coil_CoilCellarContainer.name == "Bobinas Base y metalizado" || objCoil.Coil_CoilCellarContainer.name == "Corte, metalizado y empaque" || objCoil.Coil_CoilCellarContainer.name == "Producto en Proceso Pilar" || objCoil.Coil_CoilCellarContainer.name == "Rack Metalizado")
                            {
                                if (objCoil.statusName == "Activa" || objCoil.statusName == "Reprocesada")
                                {
                                    clsProduct ObjProduct = new clsProduct(objCuttingOrder.fkProduct);
                                    if (ObjProduct.boppCode != string.Empty)
                                    {
                                        clsProduct ObjProductCoil = new clsProduct(objCoil.fkProduct);
                                        if (ObjProduct.boppCode == ObjProductCoil.boppCode)
                                        {
                                            clsPallet objOriginPallet = new clsPallet(clsCoil.getContainerPalletCodsecByCoil(objCoil.codsec));

                                            if (objOriginPallet.codsec == 0)
                                                {
                                                    objOriginPallet.removeCoilToPallet(objCoil.codsec);
                                                    clsCoilBySecundaryCuttingStop objCoilBySecundaryCuttingStop = new clsCoilBySecundaryCuttingStop();
                                                    objCoilBySecundaryCuttingStop.fkCuttingStop = Convert.ToInt32(grpbStop.Tag);
                                                    objCoilBySecundaryCuttingStop.fkCoil = objCoil.codsec;
                                                    objCoilBySecundaryCuttingStop.length = Convert.ToDouble(txtUsedCoilLength.Text);
                                                    objCoilBySecundaryCuttingStop.save();

                                                    DataSet DS = new DataSet();

                                                    DS = clsConnection.getDataSetResult("CALL spUsedLengthByCoil(" + objCoil.codsec.ToString() + ")");

                                                    if (DS.Tables[0].Rows.Count > 0)
                                                    {
                                                        if (MessageBox.Show("Ya se usaron " + DS.Tables[0].Rows[0]["usedLen"].ToString() + " metros de un total de " + objCoil.length.ToString() + ". ¿Desea cerrar la bobina?", "Resumen de orden de corte", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                                                            clsCoil.setCoilAsReprocesed(objCoil.codsec);
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Se produjo un error, consulte a sistemas");
                                                    }


                                                    //else
                                                    //objMainCoil.changeStatus("En proceso");
                                                    lblDiameter.Text = "0";
                                                    lblDensity.Text = "0";
                                                    lblNetWeigth.Text = "0";
                                                    lblGrossWeigth.Text = "0";
                                                    lblLength.Text = "0";
                                                    lblBalance.Text = "";
                                                    lblWidth.Text = "0";
                                                    lblCoilProduct.Text = "";
                                                    txtCoilCode.Text = "";
                                                    txtUsedCoilLength.Text = "";
                                                    txtCoilCode.Focus();

                                                    objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index] = new clsCuttingStop(Convert.ToInt32(grpbStop.Tag));
                                                    dgvCoilsSecundaryCut.Rows.Clear();

                                                    for (int i = 0; i < objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstSecundaryCutCoil.Count; i++)
                                                    {
                                                        dgvCoilsSecundaryCut.Rows.Add();
                                                        dgvCoilsSecundaryCut.Rows[i].Cells[clmCodsec.Index].Value = objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstSecundaryCutCoil[i].objCoil.codsec;
                                                        dgvCoilsSecundaryCut.Rows[i].Cells[clmCode.Index].Value = objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstSecundaryCutCoil[i].objCoil.code;
                                                        dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilProduct.Index].Value = (new clsProduct(objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstSecundaryCutCoil[i].objCoil.fkProduct)).code;
                                                        dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilDiameter.Index].Value = objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstSecundaryCutCoil[i].objCoil.diameter;
                                                        dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilCore.Index].Value = (new clsProduct(objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstSecundaryCutCoil[i].objCoil.codsec)).CoreValue.ToString() + "\"";
                                                        dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilWidth.Index].Value = objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstSecundaryCutCoil[i].objCoil.width;
                                                        dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilLength.Index].Value = objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstSecundaryCutCoil[i].objCoil.length;
                                                        dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilUsedLength.Index].Value = Convert.ToString(Math.Round(objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstSecundaryCutCoil[i].length, 2));
                                                        dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilEdit.Index].Tag = "edit";
                                                        dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilEdit.Index].Value = global::BPS.Lite.Properties.Resources.pencil;
                                                        dgvCoilsSecundaryCut.Rows[i].Cells[clmCoildelete.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                                                    }
                                                }
                                            else
                                            {
                                                MessageBox.Show("No se puede reprocesar una bobina que este dentro de un pallet. Quite la bobina del pallet para poder reprocesar.");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("La película seleccionada es " + ObjProduct.boppCode + " y la bobina seleccionada es un " + ObjProductCoil.boppCode + " para que usted pueda reprocesar debe ingresar una bobina con la misma película de la orden de corte", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                            txtCoilCode.Text = string.Empty;
                                            lblCoilProduct.Text = string.Empty;
                                            txtUsedCoilLength.Text = string.Empty;
                                            lblDensity.Text = string.Empty;
                                            lblLength.Text = string.Empty;
                                            lblDiameter.Text = string.Empty;
                                            label4.Text = string.Empty;
                                            lblBalance.Text = string.Empty;
                                            lblWidth.Text = string.Empty;
                                            lblGrossWeigth.Text = string.Empty;
                                        }
                                    }
                                    else if (ObjProduct.castCode != string.Empty)
                                    {
                                        clsProduct ObjProductCoil = new clsProduct(objCoil.fkProduct);
                                        if (ObjProduct.castCode == ObjProductCoil.castCode)
                                        {
                                            clsPallet objOriginPallet = new clsPallet(clsCoil.getContainerPalletCodsecByCoil(objCoil.codsec));
                                            if (objOriginPallet.fkStatus == 40)
                                                MessageBox.Show("No puede reabrir un pallet despachado", "Resumen de Orden de Corte", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                            else
                                            {
                                                if (objOriginPallet.open())
                                                {
                                                    objOriginPallet.removeCoilToPallet(objCoil.codsec);
                                                    clsCoilBySecundaryCuttingStop objCoilBySecundaryCuttingStop = new clsCoilBySecundaryCuttingStop();
                                                    objCoilBySecundaryCuttingStop.fkCuttingStop = Convert.ToInt32(grpbStop.Tag);
                                                    objCoilBySecundaryCuttingStop.fkCoil = objCoil.codsec;
                                                    objCoilBySecundaryCuttingStop.length = Convert.ToDouble(txtUsedCoilLength.Text);
                                                    objCoilBySecundaryCuttingStop.save();

                                                    DataSet DS = new DataSet();

                                                    DS = clsConnection.getDataSetResult("CALL spUsedLengthByCoil(" + objCoil.codsec.ToString() + ")");

                                                    if (DS.Tables[0].Rows.Count > 0)
                                                    {
                                                        if (MessageBox.Show("Ya se usaron " + DS.Tables[0].Rows[0]["usedLen"].ToString() + " metros de un total de " + objCoil.length.ToString() + ". ¿Desea cerrar la bobina?", "Resumen de orden de corte", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                                                            clsCoil.setCoilAsReprocesed(objCoil.codsec);
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Se produjo un error, consulte a sistemas");
                                                    }
                                                    //else
                                                    //objMainCoil.changeStatus("En proceso");
                                                    lblDiameter.Text = "0";
                                                    lblDensity.Text = "0";
                                                    lblNetWeigth.Text = "0";
                                                    lblGrossWeigth.Text = "0";
                                                    lblLength.Text = "0";
                                                    lblBalance.Text = "";
                                                    lblWidth.Text = "0";
                                                    lblCoilProduct.Text = "";
                                                    txtCoilCode.Text = "";
                                                    txtUsedCoilLength.Text = "";
                                                    txtCoilCode.Focus();

                                                    objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index] = new clsCuttingStop(Convert.ToInt32(grpbStop.Tag));
                                                    dgvCoilsSecundaryCut.Rows.Clear();

                                                    for (int i = 0; i < objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstSecundaryCutCoil.Count; i++)
                                                    {
                                                        dgvCoilsSecundaryCut.Rows.Add();
                                                        dgvCoilsSecundaryCut.Rows[i].Cells[clmCodsec.Index].Value = objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstSecundaryCutCoil[i].objCoil.codsec;
                                                        dgvCoilsSecundaryCut.Rows[i].Cells[clmCode.Index].Value = objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstSecundaryCutCoil[i].objCoil.code;
                                                        dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilProduct.Index].Value = (new clsProduct(objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstSecundaryCutCoil[i].objCoil.fkProduct)).code;
                                                        dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilDiameter.Index].Value = objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstSecundaryCutCoil[i].objCoil.diameter;
                                                        dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilCore.Index].Value = (new clsProduct(objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstSecundaryCutCoil[i].objCoil.codsec)).CoreValue.ToString() + "\"";
                                                        dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilWidth.Index].Value = objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstSecundaryCutCoil[i].objCoil.width;
                                                        dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilLength.Index].Value = objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstSecundaryCutCoil[i].objCoil.length;
                                                        dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilUsedLength.Index].Value = Convert.ToString(Math.Round(objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstSecundaryCutCoil[i].length, 2));
                                                        dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilEdit.Index].Tag = "edit";
                                                        dgvCoilsSecundaryCut.Rows[i].Cells[clmCoilEdit.Index].Value = global::BPS.Lite.Properties.Resources.pencil;
                                                        dgvCoilsSecundaryCut.Rows[i].Cells[clmCoildelete.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("La película seleccionada es " + ObjProduct.castCode + " y la bobina seleccionada es un " + ObjProductCoil.castCode + " para que usted pueda reprocesar debe ingresar una bobina con la misma película de la orden de corte", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                            txtCoilCode.Text = string.Empty;
                                            lblCoilProduct.Text = string.Empty;
                                            txtUsedCoilLength.Text = string.Empty;
                                            lblDensity.Text = string.Empty;
                                            lblLength.Text = string.Empty;
                                            lblDiameter.Text = string.Empty;
                                            label4.Text = string.Empty;
                                            lblBalance.Text = string.Empty;
                                            lblWidth.Text = string.Empty;
                                            lblGrossWeigth.Text = string.Empty;
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("El código ingresado no corresponde a ninguna bobina registrada en el sistema o la bobina seleccionada ya ha sido cerrada.", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                    txtCoilCode.Text = string.Empty;
                                    lblCoilProduct.Text = string.Empty;
                                    txtUsedCoilLength.Text = string.Empty;
                                    lblDensity.Text = string.Empty;
                                    lblLength.Text = string.Empty;
                                    lblDiameter.Text = string.Empty;
                                    label4.Text = string.Empty;
                                    lblBalance.Text = string.Empty;
                                    lblWidth.Text = string.Empty;
                                    lblGrossWeigth.Text = string.Empty;
                                }
                            }
                            else
                            {
                                MessageBox.Show("La bobina seleccionada se encuentra en la bodega de " + objCoil.Coil_CoilCellarContainer.name + " es necesario que las bobinas o el pallets\r\n Se encuentre en PLANTA - CORTE - PROCESO para que pueda ingresar al reproceso\r\n Solicite a bodega que libere el pallet para poder continuar con la ejecución de la orden de corte secundario", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                txtCoilCode.Text = string.Empty;
                                lblCoilProduct.Text = string.Empty;
                                txtUsedCoilLength.Text = string.Empty;
                                lblDensity.Text = string.Empty;
                                lblLength.Text = string.Empty;
                                lblDiameter.Text = string.Empty;
                                label4.Text = string.Empty;
                                lblBalance.Text = string.Empty;
                                lblWidth.Text = string.Empty;
                                lblGrossWeigth.Text = string.Empty;
                            }
                        }
                        else
                        {
                            MessageBox.Show("El código ingresado no corresponde a ninguna bobina registrada en el sistema o la bobina seleccionada ya ha sido cerrada.", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                            txtCoilCode.Text = string.Empty;
                            lblCoilProduct.Text = string.Empty;
                            txtUsedCoilLength.Text = string.Empty;
                            lblDensity.Text = string.Empty;
                            lblLength.Text = string.Empty;
                            lblDiameter.Text = string.Empty;
                            label4.Text = string.Empty;
                            lblBalance.Text = string.Empty;
                            lblWidth.Text = string.Empty;
                            lblGrossWeigth.Text = string.Empty;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El código ingresado no corresponde a ninguna bobina registrada en el sistema o la bobina seleccionada ya ha sido cerrada.", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        txtCoilCode.Text = string.Empty;
                        lblCoilProduct.Text = string.Empty;
                        txtUsedCoilLength.Text = string.Empty;
                        lblDensity.Text = string.Empty;
                        lblLength.Text = string.Empty;
                        lblDiameter.Text = string.Empty;
                        label4.Text = string.Empty;
                        lblBalance.Text = string.Empty;
                        lblWidth.Text = string.Empty;
                        lblGrossWeigth.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("Para poder adicionar una bobina de reproceso debe llenar los campos de Código y Metraje. Por favor vuelva a ingresar nuevamente y asegúrese de que los campos mencionados estén llenos.", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    txtCoilCode.Text = string.Empty;
                    lblCoilProduct.Text = string.Empty;
                    txtUsedCoilLength.Text = string.Empty;
                    lblDensity.Text = string.Empty;
                    lblLength.Text = string.Empty;
                    lblDiameter.Text = string.Empty;
                    label4.Text = string.Empty;
                    lblBalance.Text = string.Empty;
                    lblWidth.Text = string.Empty;
                    lblGrossWeigth.Text = string.Empty;
                }
            }
        }

        private void txtUsedLength_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (objMainCoil.codsec > 0)
                {
                    if (clsGlobal.isNumeric(txtUsedLength.Text))
                    {
                        if (objMainCoil.fkBopp == objCuttingOrder.fkBopp)
                        {
                            clsMainCoilByCuttingStop objMainCoilByCuttingStop = new clsMainCoilByCuttingStop();
                            objMainCoilByCuttingStop.fkCuttingStop = Convert.ToInt32(grpbStop.Tag);
                            objMainCoilByCuttingStop.fkMainCoil = objMainCoil.codsec;
                            objMainCoilByCuttingStop.length = Convert.ToDouble(txtUsedLength.Text);
                            objMainCoilByCuttingStop.save();

                            if (objMainCoil.netlength - objMainCoil.usedLength - Convert.ToDouble(txtUsedLength.Text) < objMainCoil.netlength * 0.05)
                            {
                                if (MessageBox.Show("La rollo madre esta próxima a terminarse o ya se terminó, desea cerrar la rollo madre?", "Resumen de orden de corte", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                                    objMainCoil.changeStatus("Cerrada");
                            }
                            else
                                objMainCoil.changeStatus("En proceso");

                            txtMainCoilCode.Text = "";
                            txtUsedLength.Text = "0";
                            lblMachine.Text = "";
                            lblLot.Text = "";
                            lblKgPerHour.Text = "0";
                            lblVelocity.Text = "0";
                            lblNetLength.Text = "0";
                            lblWidht.Text = "0";
                            lblGramaje.Text = "0";
                            lblNetWeigth.Text = "0";
                            txtMainCoilCode.Focus();
                            objCoil = new clsCoil();

                            objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index] = new clsCuttingStop(Convert.ToInt32(grpbStop.Tag));
                            dgvMainCoilList.Rows.Clear();

                            for (int i = 0; i < objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstMainCoilByCuttingStop.Count; i++)
                            {
                                dgvMainCoilList.Rows.Add();
                                dgvMainCoilList.Rows[i].Cells[0].Value = objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstMainCoilByCuttingStop[i].mainCoil.codsec;
                                dgvMainCoilList.Rows[i].Cells[1].Value = (new clsBopp(objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstMainCoilByCuttingStop[i].mainCoil.fkBopp)).name;
                                dgvMainCoilList.Rows[i].Cells[2].Value = objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstMainCoilByCuttingStop[i].mainCoil.code;
                                dgvMainCoilList.Rows[i].Cells[3].Value = objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstMainCoilByCuttingStop[i].mainCoil.lotNumber;
                                dgvMainCoilList.Rows[i].Cells[4].Value = objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstMainCoilByCuttingStop[i].mainCoil.labRating;
                                dgvMainCoilList.Rows[i].Cells[5].Value = objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstMainCoilByCuttingStop[i].mainCoil.initDate.ToString("dd/MM/yyyy HH:mm:ss");
                                dgvMainCoilList.Rows[i].Cells[6].Value = Convert.ToString(Math.Round(objCuttingOrder.lstCuttingStop[trvStopViews.SelectedNode.Index].lstMainCoilByCuttingStop[i].length, 2));
                                dgvMainCoilList.Rows[i].Cells[clmMainCoilEditLength.Index].Tag = "edit";
                                dgvMainCoilList.Rows[i].Cells[7].Value = global::BPS.Lite.Properties.Resources.pencil;
                                dgvMainCoilList.Rows[i].Cells[8].Value = global::BPS.Lite.Properties.Resources.cross;
                            }
                        }
                        else
                        {
                            MessageBox.Show("La película seleccionada no coincide con la requerida en la orden de corte.", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

                            objMainCoil = new clsMainCoil();
                            txtMainCoilCode.Text = "";
                            txtUsedLength.Text = "0";
                            lblMachine.Text = "";
                            lblLot.Text = "";
                            lblKgPerHour.Text = "0";
                            lblVelocity.Text = "0";
                            lblNetLength.Text = "0";
                            lblWidht.Text = "0";
                            lblGramaje.Text = "0";
                            lblNetWeigth.Text = "0";
                            txtMainCoilCode.Focus();
                        }
                    }
                    else
                        MessageBox.Show("El valor debe ser numérico.", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
                else
                    MessageBox.Show("Debe seleccionar un rollo madre.", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            if(inPosition != 0)
            {
                clsCuttingStop objCuttingStop = new clsCuttingStop(Convert.ToInt32(grpbStop.Tag));
                frmEfficiencyPerCuttingNumberAndPosition winEfficiency = new frmEfficiencyPerCuttingNumberAndPosition(Convert.ToInt32(objCuttingOrder.number), inPosition, objCuttingOrder, objCuttingStop);
                winEfficiency.StartPosition = FormStartPosition.CenterScreen;
                winEfficiency.ShowDialog();
            }
        }
    }
}