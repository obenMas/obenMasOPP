using System;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmMetallizedProductionOrderDetails : Form
    {
        public frmMetallizedProductionOrderDetails(int productionOrderCodsec)
        {
            InitializeComponent();
            PopulateProductionOrderDetail(productionOrderCodsec);
        }

        private void PopulateProductionOrderDetail(int productionOrderCodsec)
        {
            clsFilmProductionPlanMetal objFilm = new clsFilmProductionPlanMetal(productionOrderCodsec);
            txtProductionOrderDetailNumber.Text = objFilm.lotNumber;
            txtProductionOrderDetailFilm.Text = objFilm.productionOrderMetal.BoppFrom;
            lblInitDate.Text = objFilm.productionOrderMetal.BoppTo;
            txtProductionOrderMachine.Text = objFilm.productionOrderMetal.Coil.ToString();
            lblEndDate.Text = objFilm.density.ToString();
            lblNotes.Text = objFilm.notes;

            PopulateMainCoilMetal(objFilm.codsec);
        }

        private void PopulateMainCoilMetal(int filmCodsec)
        {
            var mainCoilMetal = clsMainCoilMetal.getListByFilmProductionPlan(filmCodsec);

            int pos = 0;

            foreach (var item in mainCoilMetal)
            {
                dgvProductionOrderMainCoil.Rows.Add();
                dgvProductionOrderMainCoil.Rows[pos].Cells[clmProductionOrderMainCoilCodsec.Index].Value = item.codsec;
                dgvProductionOrderMainCoil.Rows[pos].Cells[clmProductionOrderMainCoilCode.Index].Value = item.mcode.ToString();
                dgvProductionOrderMainCoil.Rows[pos].Cells[clmProductionOrderMainCoilBatch.Index].Value = item.lotNumber.ToString();
                dgvProductionOrderMainCoil.Rows[pos].Cells[clmProductionOrderMainCoilWeigth.Index].Value = Convert.ToString(Math.Round(item.netWeigth, 2));
                dgvProductionOrderMainCoil.Rows[pos].Cells[clmProductionOrderMainCoilLength.Index].Value = Convert.ToString(Math.Round(item.netlength, 2));
                dgvProductionOrderMainCoil.Rows[pos].Cells[clmProductionOrderMainCoilStatus.Index].Value = item.StatusName.ToString();
                //dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderEdit.Index].Value = BPS.Properties.Resources.pencil;
                //dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderOutLine.Index].Value = BPS.Properties.Resources.chart_line;
                //dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderCoilQuality.Index].Value = BPS.Properties.Resources.report;
                //dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderDeleteMainCoil.Index].Value = BPS.Properties.Resources.cross;
                pos++;
            }
        }

        private void frmProductionOrderDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProductionOrderMainCoil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == clmProductionOrderOutLine.Index)
            //{
            //    frmMainCoilOutline winMainCoilOutline = new frmMainCoilOutline(Convert.ToInt32(dgvProductionOrderMainCoil.Rows[e.RowIndex].Cells[clmProductionOrderMainCoilCodsec.Index].Value));
            //    winMainCoilOutline.MdiParent = this.MdiParent;
            //    winMainCoilOutline.StartPosition = FormStartPosition.Manual;
            //    winMainCoilOutline.Show();
            //}
            //if (e.ColumnIndex == clmProductionOrderCoilQuality.Index)
            //{
            //    frmMainCoilQualityReport winMainCoilQualityReport = new frmMainCoilQualityReport(Convert.ToInt32(dgvProductionOrderMainCoil.Rows[e.RowIndex].Cells[clmProductionOrderMainCoilCodsec.Index].Value));
            //    winMainCoilQualityReport.MdiParent = this.MdiParent;
            //    winMainCoilQualityReport.StartPosition = FormStartPosition.Manual;
            //    winMainCoilQualityReport.Show();
            //}
            //if (e.ColumnIndex == clmProductionOrderEdit.Index)
            //{
            //    frmMainCoilRegister winMainCoilRegister = new frmMainCoilRegister(Convert.ToInt32(dgvProductionOrderMainCoil.Rows[e.RowIndex].Cells[clmProductionOrderMainCoilCodsec.Index].Value), true);
            //    winMainCoilRegister.ShowDialog();

            //    List<clsMainCoil> lstMainCoil = clsMainCoil.getBoppMainCoilByProductionPlan(objProductionOrderDetail.fkFilmProductionPlan);
            //    dgvProductionOrderMainCoil.Rows.Clear();

            //    for (int i = 0; i < lstMainCoil.Count; i++)
            //    {
            //        dgvProductionOrderMainCoil.Rows.Add();
            //        dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderMainCoilCodsec.Index].Value = lstMainCoil[i].codsec.ToString();
            //        dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderMainCoilCode.Index].Value = lstMainCoil[i].code.ToString();
            //        dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderMainCoilBatch.Index].Value = lstMainCoil[i].lotNumber.ToString();
            //        dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderMainCoilWeigth.Index].Value = Convert.ToString(Math.Round(lstMainCoil[i].netWeigth, 2));
            //        dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderMainCoilLength.Index].Value = Convert.ToString(Math.Round(lstMainCoil[i].netlength, 2));
            //        dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderMainCoilStatus.Index].Value = lstMainCoil[i].StatusName.ToString();
            //        dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderEdit.Index].Value = BPS.Properties.Resources.pencil;
            //        dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderOutLine.Index].Value = BPS.Properties.Resources.chart_line;
            //        dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderCoilQuality.Index].Value = BPS.Properties.Resources.report;
            //        dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderDeleteMainCoil.Index].Value = BPS.Properties.Resources.cross;
            //    }
            //}
        }


        //#region Detalle de Orden

        //private void LoadDetailOrder()
        //{
        //    txtProductionOrderDetailNumber.Text = objFilmProductionPlan.lotNumber.ToString();
        //    txtProductionOrderDetailFilm.Text = objProductionOrderDetail.BoppCode;
        //    txtProductionOrderMachine.Text = objProductionOrderDetail.MachineName;
        //    txtProductionOrderStatus.Text = objProductionOrderDetail.StatusName;
        //    txtProductionOrderRequestedKg.Text = Convert.ToString(Math.Round(objProductionOrderDetail.Quantity, 2));
        //    txtProductionOrderExtrudedKg.Text = Convert.ToString(Math.Round(objProductionOrderDetail.FulfilledQuantity, 2));
        //    txtKg.Text = Convert.ToString(Math.Round((objProductionOrderDetail.Quantity - objProductionOrderDetail.FulfilledQuantity), 2));
        //    lblWidts.Text = objFilmProductionPlan.widths;
        //    lblLength.Text = objFilmProductionPlan.estimatedLength.ToString();
        //    lblNotes.Text = objFilmProductionPlan.notes;
        //    lblInitDate.Text = objFilmProductionPlan.estimatedInitDate.ToString("dd/MM/yyyy HH:mm");
        //    lblEndDate.Text = (objProductionOrder.StatusName == "Cerrada") ? objFilmProductionPlan.estimatedEndDate.ToString("dd/MM/yyyy HH:mm") : "----";
        //    txtConsumption.Text = objFilmProductionPlan.consumptionWeight.ToString();
        //    lblEfficiencyValue.Text = Math.Round((objProductionOrderDetail.FulfilledQuantity / objFilmProductionPlan.consumptionWeight) * 100, 2).ToString() + " %";

        //    if (Math.Round((objProductionOrderDetail.FulfilledQuantity / objFilmProductionPlan.consumptionWeight) * 100, 2) <= 100)
        //        pgrbEfficiency.Value = (int)Math.Round(Math.Round((objProductionOrderDetail.FulfilledQuantity / objFilmProductionPlan.consumptionWeight) * 100, 2), 0);
        //    else
        //        pgrbEfficiency.Value = 100;

        //    if (objFilmProductionPlan.variation == true)
        //    {
        //        lblVatiation.Text = "La orden de producción ha sigo modificada el día : " + objFilmProductionPlan.variationDate.ToString("dd/MM/yyyy") + " por el usuario " + objProductionOrder.modificatorUser;
        //        lblVatiation.Visible = true;
        //    }

        //    loadMainCoilList();
        //}

        //private void loadMainCoilList()
        //{
        //    List<clsMainCoil> lstMainCoil = clsMainCoil.getBoppMainCoilByProductionPlan(objFilmProductionPlan.codsec);

        //    dgvProductionOrderMainCoil.Rows.Clear();

        //    for (int i = 0; i < lstMainCoil.Count; i++)
        //    {
        //        dgvProductionOrderMainCoil.Rows.Add();
        //        dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderMainCoilCodsec.Index].Value = lstMainCoil[i].codsec.ToString();
        //        dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderMainCoilCode.Index].Value = lstMainCoil[i].code.ToString();
        //        dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderMainCoilBatch.Index].Value = lstMainCoil[i].lotNumber.ToString();
        //        dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderMainCoilWeigth.Index].Value = Convert.ToString(Math.Round(lstMainCoil[i].netWeigth, 2));
        //        dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderMainCoilLength.Index].Value = Convert.ToString(Math.Round(lstMainCoil[i].netlength, 2));
        //        dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderMainCoilStatus.Index].Value = lstMainCoil[i].StatusName.ToString();
        //        dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderEdit.Index].Value = BPS.Properties.Resources.pencil;
        //        dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderOutLine.Index].Value = BPS.Properties.Resources.chart_line;
        //        dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderCoilQuality.Index].Value = BPS.Properties.Resources.report;
        //        dgvProductionOrderMainCoil.Rows[i].Cells[clmProductionOrderDeleteMainCoil.Index].Value = BPS.Properties.Resources.cross;
        //    }
        //}









        //private void btnSaveConsumption_Click(object sender, EventArgs e)
        //{
        //    if (clsGlobal.isNumeric(txtConsumption.Text))
        //    {
        //        objFilmProductionPlan.consumptionWeight = Convert.ToDouble(txtConsumption.Text);
        //        objFilmProductionPlan.setConsumptionValue();
        //    }
        //    else
        //        MessageBox.Show("El valor debe ser numérico", "Orden de producción", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //    double efficiency = 0;
        //    efficiency = Math.Round((objProductionOrderDetail.FulfilledQuantity / objFilmProductionPlan.consumptionWeight) * 100, 2);
        //    lblEfficiencyValue.Text = efficiency.ToString() + " %";

        //    if (efficiency <= 100)
        //        pgrbEfficiency.Value = (int)Math.Round(efficiency, 0);
        //    else
        //        pgrbEfficiency.Value = 100;
        //}

        //#endregion

        //#region Hoja de Formulaciones

        //private void LoadPaperFormulation()
        //{
        //    PopulateFormulationByBopp(objProductionOrder.fkBopp);
        //    ChekFormulation(objProductionOrderDetail.fkFilmProductionPlan);
        //    PopulateFormulationPaper(objProductionOrderDetail.fkFilmProductionPlan);
        //}

        //private void PopulateFormulationPaper(int fkFormulation)
        //{
        //    List<clsFormulationByFilmProductionPlan> lstFormulationByFilmProductionPlan = clsFormulationByFilmProductionPlan.getListByFilmProductionPlan(fkFormulation);
        //    List<clsRawMaterialByFormulation> lstRawMaterialByFormulation = clsRawMaterialByFormulation.getListByFormulationEdit(lstFormulationByFilmProductionPlan[0].fkFormulation);

        //    dgvC11.Rows.Clear();
        //    dgvC22.Rows.Clear();
        //    dgvPri.Rows.Clear();

        //    for (int i = 0; i < lstRawMaterialByFormulation.Count; i++)
        //    {
        //        if (lstRawMaterialByFormulation[i].layerC1 == true)
        //        {
        //            dgvC11.Rows.Add();
        //            dgvC11.Rows[dgvC11.Rows.Count - 1].Cells[c1tmp.Index].Value = lstRawMaterialByFormulation[i].nameFormulation;
        //            dgvC11.Rows[dgvC11.Rows.Count - 1].Cells[c1pro.Index].Value = lstRawMaterialByFormulation[i].name;
        //            dgvC11.Rows[dgvC11.Rows.Count - 1].Cells[c1mp.Index].Value = lstRawMaterialByFormulation[i].material;
        //            dgvC11.Rows[dgvC11.Rows.Count - 1].Cells[c1per.Index].Value = lstRawMaterialByFormulation[i].percentage;
        //            dgvC11.Rows[dgvC11.Rows.Count - 1].Cells[c1lot.Index].Value = lstRawMaterialByFormulation[i].lotnumber;
        //            dgvC11.Rows[dgvC11.Rows.Count - 1].Cells[c1wei.Index].Value = lstRawMaterialByFormulation[i].weigth;
        //        }
        //    }

        //    for (int i = 0; i < lstRawMaterialByFormulation.Count; i++)
        //    {
        //        if (lstRawMaterialByFormulation[i].layerC2 == true)
        //        {
        //            dgvC22.Rows.Add();
        //            dgvC22.Rows[dgvC22.Rows.Count - 1].Cells[c2tmp.Index].Value = lstRawMaterialByFormulation[i].nameFormulation;
        //            dgvC22.Rows[dgvC22.Rows.Count - 1].Cells[c2pro.Index].Value = lstRawMaterialByFormulation[i].name;
        //            dgvC22.Rows[dgvC22.Rows.Count - 1].Cells[c2mp.Index].Value = lstRawMaterialByFormulation[i].material;
        //            dgvC22.Rows[dgvC22.Rows.Count - 1].Cells[c2per.Index].Value = lstRawMaterialByFormulation[i].percentage;
        //            dgvC22.Rows[dgvC22.Rows.Count - 1].Cells[c2lot.Index].Value = lstRawMaterialByFormulation[i].lotnumber;
        //            dgvC22.Rows[dgvC22.Rows.Count - 1].Cells[c2wei.Index].Value = lstRawMaterialByFormulation[i].weigth;
        //        }
        //    }


        //    for (int i = 0; i < lstRawMaterialByFormulation.Count; i++)
        //    {
        //        if (lstRawMaterialByFormulation[i].CentralLayer == true)
        //        {
        //            dgvPri.Rows.Add();
        //            dgvPri.Rows[dgvPri.Rows.Count - 1].Cells[centertmp.Index].Value = lstRawMaterialByFormulation[i].nameFormulation;
        //            dgvPri.Rows[dgvPri.Rows.Count - 1].Cells[centerpro.Index].Value = lstRawMaterialByFormulation[i].name;
        //            dgvPri.Rows[dgvPri.Rows.Count - 1].Cells[centermp.Index].Value = lstRawMaterialByFormulation[i].material;
        //            dgvPri.Rows[dgvPri.Rows.Count - 1].Cells[centerper.Index].Value = lstRawMaterialByFormulation[i].percentage;
        //            dgvPri.Rows[dgvPri.Rows.Count - 1].Cells[centerlot.Index].Value = lstRawMaterialByFormulation[i].lotnumber;
        //            dgvPri.Rows[dgvPri.Rows.Count - 1].Cells[centerwei.Index].Value = lstRawMaterialByFormulation[i].weigth;
        //        }
        //    }

        //    if (objProductionOrderDetail.fkMachine == 1)
        //    {
        //        grpbPrin.Text = "CAPA CENTRAL";
        //        grpbC1.Text = "CO - EXT 1";
        //        grpbC2.Text = "CO  - EXT2";
        //        grpbFormulationCentralLayer.Text = "CAPA CENTRAL";
        //        grpbFormulationC1.Text = "CO - EXT 1";
        //        grpbFormulationC2.Text = "CO  - EXT2";
        //    }
        //    else
        //    {
        //        grpbPrin.Text = "EXT PRINCIPAL";
        //        grpbC1.Text = "SAT # 1";
        //        grpbC2.Text = "SAT # 2";
        //        grpbFormulationCentralLayer.Text = "EXT PRINCIPAL";
        //        grpbFormulationC1.Text = "SAT # 1";
        //        grpbFormulationC2.Text = "SAT # 2";
        //    }

        //    clsFormulationData objFormulationD = new clsFormulationData(objProductionOrder.codsec, "Check");

        //    if (objFormulationD.codsec > 0)
        //    {
        //        label31.Text = "La Orden seleccionada posee reporte de Formulación";
        //        codsecFormulationPaper = objFormulationD.codsec;
        //        txtliable.Text = objFormulationD.liable.ToUpper();
        //        txttra.Text = objFormulationD.tratiment.ToUpper();
        //        txttrans.Text = objFormulationD.transform.ToUpper();
        //        txtpo.Text = objFormulationD.power;
        //        txthnotes.Text = objFormulationD.notes;
        //    }
        //    else
        //    {
        //        label31.Text = "La Orden seleccionada no posee reporte de Formulación";
        //        codsecFormulationPaper = 0;
        //        txtliable.Clear();
        //        txtliable.Text = "PRADO-MORAN-CROW";
        //        txttra.Clear();
        //        txttrans.Clear();
        //        txtpo.Clear();
        //        txthnotes.Clear();
        //    }
        //}

        //private void PopulateFormulationByBopp(int fkBopp)
        //{
        //    List<clsFormulation> lstFormulation = clsFormulation.getListByBoppFilm(fkBopp, false);
        //    cmbHFormulation.Items.Clear();
        //    for (int i = 0; i < lstFormulation.Count; i++)
        //        cmbHFormulation.Items.Add(lstFormulation[i]);
        //}

        //private void ChekFormulation(int fkFormulation)
        //{
        //    List<clsFormulationByFilmProductionPlan> lstFormulationByFilmProductionPlan = clsFormulationByFilmProductionPlan.getListByFilmProductionPlan(fkFormulation);
        //    for (int i = 0; i < cmbHFormulation.Items.Count; i++)
        //    {
        //        if (((clsFormulation)cmbHFormulation.Items[i]).codsec == lstFormulationByFilmProductionPlan[0].fkFormulation)
        //        {
        //            cmbHFormulation.SelectedIndex = i;
        //            myformulation = lstFormulationByFilmProductionPlan[0].fkFormulation;
        //            break;
        //        }
        //    }

        //    List<clsFormulation> lstFormulation = clsFormulation.getListByBoppFilmOnlyResult(lstFormulationByFilmProductionPlan[0].fkFormulation);
        //    cmbHFormulation.Items.Clear();
        //    for (int i = 0; i < lstFormulation.Count; i++)
        //        cmbHFormulation.Items.Add(lstFormulation[i]);

        //}

        //private void btnEditHFormulation_Click(object sender, EventArgs e)
        //{
        //    if (MessageBox.Show("Está realmente seguro que desea editar la fórmula seleccionada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
        //    {
        //        frmFormulationsBoppForm winBopp = new frmFormulationsBoppForm(myformulation);
        //        winBopp.StartPosition = FormStartPosition.CenterScreen;
        //        winBopp.ShowDialog(this);
        //        PopulateFormulationPaper(objProductionOrderDetail.fkFilmProductionPlan);
        //        FillFormularionDetails();
        //    }
        //}

        //private void btnAddHFormulation_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (ValidateFormFormulationPaper())
        //        {
        //            clsFormulationData objfor = new clsFormulationData(objProductionOrder.codsec, "Check");
        //            if (objfor.codsec == 0)
        //            {
        //                objfor = new clsFormulationData();
        //                objfor.fkFormulation = myformulation;
        //                objfor.fkProductionOrder = objProductionOrder.codsec;
        //                objfor.liable = txtliable.Text.ToUpper();
        //                objfor.tratiment = txttra.Text.ToUpper();
        //                objfor.transform = txttrans.Text.ToUpper();
        //                objfor.power = txtpo.Text.ToUpper();
        //                objfor.notes = txthnotes.Text.ToUpper();
        //                objfor.createdDate = objFilmProductionPlan.estimatedInitDate;
        //                if (objfor.save())
        //                {
        //                    MessageBox.Show("Formulación Guardada Correctamente");
        //                    GenerateFormulationPaperReport(objProductionOrder.codsec);
        //                }
        //                else
        //                {
        //                    MessageBox.Show("No se ha podido guardar el fórmula!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        //                    txtliable.Focus();
        //                }
        //            }
        //            else
        //            {
        //                objfor.fkFormulation = myformulation;
        //                objfor.fkProductionOrder = objProductionOrder.codsec;
        //                objfor.liable = txtliable.Text.ToUpper();
        //                objfor.tratiment = txttra.Text.ToUpper();
        //                objfor.transform = txttrans.Text.ToUpper();
        //                objfor.power = txtpo.Text.ToUpper();
        //                objfor.notes = txthnotes.Text.ToUpper();
        //                objfor.createdDate = objFilmProductionPlan.estimatedInitDate;
        //                if (objfor.save())
        //                {
        //                    MessageBox.Show("Formulación Guardada Correctamente");
        //                    GenerateFormulationPaperReport(objProductionOrder.codsec);
        //                }
        //                else
        //                {
        //                    MessageBox.Show("No se ha podido guardar el fórmula!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        //                    txtliable.Focus();
        //                }
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Es necesario que llene los campos requeridos!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        //            txtliable.Focus();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void GenerateFormulationPaperReport(int fkProductionOrder)
        //{
        //    clsFormulationData objFormulationD = new clsFormulationData(objProductionOrder.codsec, "Check");
        //    if (objFormulationD.codsec > 0)
        //    {
        //        var data = objFormulationD.objFilmProductionPlan.MachineName + ";" + objFormulationD.objFilmProductionPlan.productionOrder.Bopp.code + ";" + objFormulationD.objFilmProductionPlan.lotNumber + ";" + objFormulationD.objFilmProductionPlan.productionOrder.quantity;
        //        BPS.Reporting.ProductionReports.Formulation.frmFormulation winFor = new Reporting.ProductionReports.Formulation.frmFormulation(data, clsGlobal.password, objProductionOrder.codsec);
        //        winFor.StartPosition = FormStartPosition.CenterScreen;
        //        winFor.ShowDialog();
        //    }
        //    else
        //    {
        //        MessageBox.Show("No existe datos para generar el reporte");
        //    }
        //}

        //private void btnReportHFormulation_Click(object sender, EventArgs e)
        //{
        //    GenerateFormulationPaperReport(1);
        //}

        //private bool ValidateFormFormulationPaper()
        //{
        //    bool isValid = true;
        //    if (!clsValidation.validateField(ref txtliable, ref lblhId, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txttra, ref lblhtra, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txttrans, ref label40, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtpo, ref lblhPo, "notEmpty")) isValid = false;
        //    return isValid;
        //}

        //#endregion

        //#region Formulaciones

        //private void LoadFormulation()
        //{
        //    lblFormulationFilm.Text = objProductionOrderDetail.BoppCode.Replace("-", "");
        //    lblFormulationLotNumber.Text = objFilmProductionPlan.lotNumber.ToString();
        //    lblFormulationMachine.Text = objProductionOrderDetail.MachineName;
        //    lblFormulationExtruder.Text = Math.Round(objProductionOrderDetail.FulfilledQuantity, 2).ToString();
        //    lblFormulationDecrease.Text = Math.Round((objProductionOrderDetail.FulfilledQuantity + clsDecreaseByFilmProductionPlan.getTotalDecreaseByFilmProductionPlan(objProductionOrderDetail.fkFilmProductionPlan)), 2).ToString();
        //    lblFormulationInitDate.Text = objFilmProductionPlan.estimatedInitDate.ToString("dd/MM/yyyy HH:mm");
        //    lblFormulationEndDate.Text = (objProductionOrder.StatusName == "Cerrada") ? objFilmProductionPlan.estimatedEndDate.ToString("dd/MM/yyyy HH:mm") : "----";
        //    lblFormulationWidth.Text = objFilmProductionPlan.widths.ToString();
        //    CheckFormulationReport();
        //}

        //private void CheckFormulationReport()
        //{
        //    if (clsFormulationReport.getFormulationStatus(objProductionOrder.codsec) > 0)
        //    {
        //        btnReportFormulation.Enabled = true;
        //        btnAddFormulationReport.Enabled = false;
        //        lblFormulationStatus.Text = "El reporte de formulación se encuentra listo";
        //    }
        //    else
        //    {
        //        btnReportFormulation.Enabled = false;
        //        btnAddFormulationReport.Enabled = true;
        //        lblFormulationStatus.Text = "La Orden no posee aún el reporte de formulación";
        //    }

        //    FillFormularionDetails();
        //}

        //private void FillFormularionDetails()
        //{
        //    List<clsFormulationByFilmProductionPlan> lstFormulationByFilmProductionPlan = clsFormulationByFilmProductionPlan.getListByFilmProductionPlan(objFilmProductionPlan.codsec);
        //    if (lstFormulationByFilmProductionPlan.Count > 0)
        //    {
        //        dgvProductionOrderFormulation.Rows.Clear();

        //        for (int i = 0; i < lstFormulationByFilmProductionPlan.Count; i++)
        //        {
        //            dgvProductionOrderFormulation.Rows.Add();
        //            dgvProductionOrderFormulation.Rows[i].Cells[clmProductionOrderFormulationCodsec.Index].Value = lstFormulationByFilmProductionPlan[i].fkFormulation.ToString();
        //            dgvProductionOrderFormulation.Rows[i].Cells[clmProductionOrderFormulationCode.Index].Value = lstFormulationByFilmProductionPlan[i].formulationName.ToString();
        //        }

        //        dgvCentralLayer.Rows.Clear();
        //        dgvC1.Rows.Clear();
        //        dgvC2.Rows.Clear();

        //        clsFormulation objFormulation = clsFormulation.getFormulationBoppDetail(Convert.ToInt32(dgvProductionOrderFormulation.Rows[0].Cells[clmProductionOrderFormulationCodsec.Index].Value));
        //        List<clsRawMaterialByFormulation> lstRawMaterialByFormulation = new List<clsRawMaterialByFormulation>();
        //        lblFormulationC1Thickness.Text = objFormulation.thickLayerC1.ToString();
        //        lblFormulationC2Thickness.Text = objFormulation.thickLayerC2.ToString();
        //        lblFormulationCentralLayerThickness.Text = objFormulation.thickCentralLayer.ToString();
        //        lstRawMaterialByFormulation = clsRawMaterialByFormulation.getListByFormulation(objFormulation.codsec, true);
        //        for (int i = 0; i < lstRawMaterialByFormulation.Count; i++)
        //        {
        //            if (lstRawMaterialByFormulation[i].CentralLayer == true)
        //            {
        //                dgvCentralLayer.Rows.Add();
        //                dgvCentralLayer.Rows[dgvCentralLayer.Rows.Count - 1].Cells[clmCentralLayerType.Index].Value = lstRawMaterialByFormulation[i].nameTypeFormulation;
        //                dgvCentralLayer.Rows[dgvCentralLayer.Rows.Count - 1].Cells[clmCentralLayerProveetor.Index].Value = lstRawMaterialByFormulation[i].companyName;
        //                dgvCentralLayer.Rows[dgvCentralLayer.Rows.Count - 1].Cells[clmCentralLayerRawMaterial.Index].Value = lstRawMaterialByFormulation[i].material;
        //                dgvCentralLayer.Rows[dgvCentralLayer.Rows.Count - 1].Cells[clmCentralLayerPercentage.Index].Value = lstRawMaterialByFormulation[i].percentage;
        //                dgvCentralLayer.Rows[dgvCentralLayer.Rows.Count - 1].Cells[clmCentralLayerLotNumber.Index].Value = lstRawMaterialByFormulation[i].lotnumber;
        //                dgvCentralLayer.Rows[dgvCentralLayer.Rows.Count - 1].Cells[clmCentralLayerWeigth.Index].Value = lstRawMaterialByFormulation[i].weigth;
        //            }
        //        }
        //        for (int i = 0; i < lstRawMaterialByFormulation.Count; i++)
        //        {
        //            if (lstRawMaterialByFormulation[i].layerC1 == true)
        //            {
        //                dgvC1.Rows.Add();
        //                dgvC1.Rows[dgvC1.Rows.Count - 1].Cells[clmC1Type.Index].Value = lstRawMaterialByFormulation[i].nameTypeFormulation;
        //                dgvC1.Rows[dgvC1.Rows.Count - 1].Cells[clmC1Provider.Index].Value = lstRawMaterialByFormulation[i].companyName;
        //                dgvC1.Rows[dgvC1.Rows.Count - 1].Cells[clmC1RawMaterial.Index].Value = lstRawMaterialByFormulation[i].material;
        //                dgvC1.Rows[dgvC1.Rows.Count - 1].Cells[clmC1Percentage.Index].Value = lstRawMaterialByFormulation[i].percentage;
        //                dgvC1.Rows[dgvC1.Rows.Count - 1].Cells[clmC1LotNumber.Index].Value = lstRawMaterialByFormulation[i].lotnumber;
        //                dgvC1.Rows[dgvC1.Rows.Count - 1].Cells[clmC1Weigth.Index].Value = lstRawMaterialByFormulation[i].weigth;
        //            }
        //        }
        //        for (int i = 0; i < lstRawMaterialByFormulation.Count; i++)
        //        {
        //            if (lstRawMaterialByFormulation[i].layerC2 == true)
        //            {
        //                dgvC2.Rows.Add();
        //                dgvC2.Rows[dgvC2.Rows.Count - 1].Cells[clmC2Type.Index].Value = lstRawMaterialByFormulation[i].nameTypeFormulation;
        //                dgvC2.Rows[dgvC2.Rows.Count - 1].Cells[clmC2Provider.Index].Value = lstRawMaterialByFormulation[i].companyName;
        //                dgvC2.Rows[dgvC2.Rows.Count - 1].Cells[clmC2RawMaterial.Index].Value = lstRawMaterialByFormulation[i].material;
        //                dgvC2.Rows[dgvC2.Rows.Count - 1].Cells[clmC2Percentage.Index].Value = lstRawMaterialByFormulation[i].percentage;
        //                dgvC2.Rows[dgvC2.Rows.Count - 1].Cells[clmC2LotNumber.Index].Value = lstRawMaterialByFormulation[i].lotnumber;
        //                dgvC2.Rows[dgvC2.Rows.Count - 1].Cells[clmC2Weigth.Index].Value = lstRawMaterialByFormulation[i].weigth;
        //            }
        //        }
        //        txtGramageCO2.Text = Math.Round((Convert.ToDouble(lblFormulationC2Thickness.Text) * 0.9), 2).ToString();
        //        txtGramageCO1.Text = Math.Round((Convert.ToDouble(lblFormulationC1Thickness.Text) * 0.9), 2).ToString();
        //        FillRawMaterial();
        //    }
        //}

        //private void btnReportFormulation_Click(object sender, EventArgs e)
        //{
        //    GenerateFormulationReport();
        //}

        //private void btnAddFormulationReport_Click(object sender, EventArgs e)
        //{
        //    bool GridFormulationCenter = true, GridFormulationExtusor1 = true, GridFormulationExtrusor2 = true, FormulationRawMaterial = true;
        //    if (ValidateFormFormulation())
        //    {
        //        for (int i = 0; i < dgvCentralLayer.Rows.Count; i++)
        //        {
        //            if (Convert.ToDouble(dgvCentralLayer.Rows[i].Cells[clmCentralLayerWeigth.Index].Value) == 0)
        //            {
        //                MessageBox.Show("El peso no puede ser igual 0  en la CAPA CENTRAL por favor cambie el peso para poder continuar", "Formulación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                GridFormulationCenter = false;
        //                break;
        //            }
        //        }
        //        if (GridFormulationCenter)
        //        {
        //            for (int i = 0; i < dgvC1.Rows.Count; i++)
        //            {
        //                if (Convert.ToDouble(dgvC1.Rows[i].Cells[clmC1Weigth.Index].Value) == 0)
        //                {
        //                    MessageBox.Show("El peso no puede ser igual 0 en el SATELITE 1 por favor cambie el peso para poder continuar", "Formulación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                    GridFormulationExtusor1 = false;
        //                    break;
        //                }
        //            }
        //            if (GridFormulationExtusor1)
        //            {
        //                for (int i = 0; i < dgvC2.Rows.Count; i++)
        //                {
        //                    if (Convert.ToDouble(dgvC2.Rows[i].Cells[clmC2Weigth.Index].Value) == 0)
        //                    {
        //                        MessageBox.Show("El peso no puede ser igual 0  en el SATELITE 2 por favor cambie el peso para poder continuar", "Formulación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                        GridFormulationExtrusor2 = false;
        //                        break;
        //                    }
        //                }
        //                if (GridFormulationExtrusor2)
        //                {
        //                    bool FormulationCenter = true, FormulationExtrusor1 = true, FormulationExtrusor2 = true;
        //                    clsFormulationReport ObjFormulationReport = new clsFormulationReport();
        //                    ObjFormulationReport.fkproductionorder = objProductionOrder.codsec;
        //                    ObjFormulationReport.treatment = txtFormulationTreatment.Text;
        //                    ObjFormulationReport.speedmachine = Convert.ToDouble(txtFormulationSpeedMachine.Text);
        //                    ObjFormulationReport.gramage = Convert.ToDouble(txtFormulationGramage.Text);
        //                    ObjFormulationReport.kilogramperhour = Convert.ToDouble(txtFormulationKilogramsPerHour.Text);
        //                    ObjFormulationReport.lotnumber = lblFormulationLotNumber.Text;
        //                    ObjFormulationReport.machine = lblFormulationMachine.Text;
        //                    ObjFormulationReport.film = lblFormulationFilm.Text;
        //                    ObjFormulationReport.notes = txtDetailFormulationNotes.Text;
        //                    if (ObjFormulationReport.save())
        //                    {
        //                        clsFormulationCentralLayer ObjFormulationCentralLayer = new clsFormulationCentralLayer();
        //                        for (int i = 0; i < dgvCentralLayer.Rows.Count; i++)
        //                        {
        //                            ObjFormulationCentralLayer.fkformulationreport = clsFormulationReport.getLastsaved();
        //                            ObjFormulationCentralLayer.rawname = dgvCentralLayer.Rows[i].Cells[clmCentralLayerType.Index].Value.ToString();
        //                            ObjFormulationCentralLayer.rawmaterial = dgvCentralLayer.Rows[i].Cells[clmCentralLayerRawMaterial.Index].Value.ToString();
        //                            ObjFormulationCentralLayer.percentage = Convert.ToDouble(dgvCentralLayer.Rows[i].Cells[clmCentralLayerPercentage.Index].Value);
        //                            ObjFormulationCentralLayer.lotenumber = dgvCentralLayer.Rows[i].Cells[clmCentralLayerLotNumber.Index].Value.ToString();
        //                            ObjFormulationCentralLayer.weigth = Convert.ToDouble(dgvCentralLayer.Rows[i].Cells[clmCentralLayerWeigth.Index].Value);
        //                            ObjFormulationCentralLayer.gramage = Convert.ToDouble(txtGramageCentralLayer.Text);
        //                            ObjFormulationCentralLayer.thick = Convert.ToDouble(lblFormulationCentralLayerThickness.Text);
        //                            if (ObjFormulationCentralLayer.save())
        //                                ObjFormulationCentralLayer = new clsFormulationCentralLayer();
        //                            else
        //                            {
        //                                FormulationCenter = false;
        //                                break;
        //                            }
        //                        }
        //                        if (FormulationCenter)
        //                        {
        //                            clsFormulationExtrusor1 ObjFormulationExtrusor1 = new clsFormulationExtrusor1();
        //                            for (int i = 0; i < dgvC1.Rows.Count; i++)
        //                            {
        //                                ObjFormulationExtrusor1.fkformulationreport = clsFormulationReport.getLastsaved();
        //                                ObjFormulationExtrusor1.rawname = dgvC1.Rows[i].Cells[clmC1Type.Index].Value.ToString();
        //                                ObjFormulationExtrusor1.rawmaterial = dgvC1.Rows[i].Cells[clmC1RawMaterial.Index].Value.ToString();
        //                                ObjFormulationExtrusor1.percentage = Convert.ToDouble(dgvC1.Rows[i].Cells[clmC1Percentage.Index].Value);
        //                                ObjFormulationExtrusor1.lotenumber = dgvC1.Rows[i].Cells[clmC1LotNumber.Index].Value.ToString();
        //                                ObjFormulationExtrusor1.weigth = Convert.ToDouble(dgvC1.Rows[i].Cells[clmC1Weigth.Index].Value);
        //                                ObjFormulationExtrusor1.gramage = Convert.ToDouble(txtGramageCO1.Text);
        //                                ObjFormulationExtrusor1.thick = Convert.ToDouble(lblFormulationC1Thickness.Text);
        //                                if (ObjFormulationExtrusor1.save())
        //                                    ObjFormulationExtrusor1 = new clsFormulationExtrusor1();
        //                                else
        //                                {
        //                                    FormulationExtrusor1 = false;
        //                                    break;
        //                                }
        //                            }
        //                            if (FormulationExtrusor1)
        //                            {
        //                                clsFormulationExtrusor2 ObjFormulationExtrusor2 = new clsFormulationExtrusor2();
        //                                for (int i = 0; i < dgvC2.Rows.Count; i++)
        //                                {
        //                                    ObjFormulationExtrusor2.fkformulationreport = clsFormulationReport.getLastsaved();
        //                                    ObjFormulationExtrusor2.rawname = dgvC2.Rows[i].Cells[clmC2Type.Index].Value.ToString();
        //                                    ObjFormulationExtrusor2.rawmaterial = dgvC2.Rows[i].Cells[clmC2RawMaterial.Index].Value.ToString();
        //                                    ObjFormulationExtrusor2.percentage = Convert.ToDouble(dgvC2.Rows[i].Cells[clmC2Percentage.Index].Value);
        //                                    ObjFormulationExtrusor2.lotenumber = dgvC2.Rows[i].Cells[clmC2LotNumber.Index].Value.ToString();
        //                                    ObjFormulationExtrusor2.weigth = Convert.ToDouble(dgvC2.Rows[i].Cells[clmC2Weigth.Index].Value);
        //                                    ObjFormulationExtrusor2.gramage = Convert.ToDouble(txtGramageCO2.Text);
        //                                    ObjFormulationExtrusor2.thick = Convert.ToDouble(lblFormulationC2Thickness.Text);
        //                                    if (ObjFormulationExtrusor2.save())
        //                                        ObjFormulationExtrusor2 = new clsFormulationExtrusor2();
        //                                    else
        //                                    {
        //                                        FormulationExtrusor2 = false;
        //                                        break;
        //                                    }
        //                                }
        //                                if (FormulationExtrusor2)
        //                                {
        //                                    //Salir al reporte
        //                                    GenerateDecreaseRawMaterial();
        //                                    for (int i = 0; i < dgvRawMaterial.Rows.Count; i++)
        //                                    {
        //                                        clsFormulationRawMaterial ObjFormulationRawMaterial = new clsFormulationRawMaterial();
        //                                        ObjFormulationRawMaterial.fkproductionorder = objProductionOrder.codsec;
        //                                        ObjFormulationRawMaterial.name = dgvRawMaterial.Rows[i].Cells[clmrawtype.Index].Value.ToString();
        //                                        ObjFormulationRawMaterial.material = dgvRawMaterial.Rows[i].Cells[clmrawmaterial.Index].Value.ToString();
        //                                        ObjFormulationRawMaterial.teorical = Convert.ToDouble(dgvRawMaterial.Rows[i].Cells[clmrawteorical.Index].Value);
        //                                        ObjFormulationRawMaterial.real = Convert.ToDouble(dgvRawMaterial.Rows[i].Cells[clmrawreal.Index].Value);
        //                                        if (!ObjFormulationRawMaterial.save())
        //                                        {
        //                                            FormulationRawMaterial = false;
        //                                            break;
        //                                        }
        //                                    }
        //                                    if (FormulationRawMaterial)
        //                                    {
        //                                        MessageBox.Show("Reporte de Formulación generado correctamente", "Formulación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                                        GenerateFormulationReport();
        //                                    }
        //                                    else
        //                                        MessageBox.Show("No se pudo guardar formulaciones ya que existe en problema en el calculo del consumo de materia prima", "Formulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                                }
        //                                else
        //                                    MessageBox.Show("No se pudo guardar formulaciones ya que existe en problema en la Formulación Extrusor 2", "Formulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                            }
        //                            else
        //                                MessageBox.Show("No se pudo guardar formulaciones ya que existe en problema en la Formulación Extrusor 1", "Formulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                        }
        //                        else
        //                            MessageBox.Show("No se pudo guardar formulaciones ya que existe en problema en la Formulación Capa Central", "Formulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                    }
        //                    else
        //                        MessageBox.Show("No se pudo guardar formulaciones ya que existe en problema en la Formulación", "Formulación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                }
        //                else
        //                    MessageBox.Show("Debe llenar todos los campos necesarios para poder continuar, recuerde que los los pesos deben ser mayor que 0 en las capas", "Formulación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //            else
        //                MessageBox.Show("Debe llenar todos los campos necesarios para poder continuar, recuerde que los los pesos deben ser mayor que 0 en las capas", "Formulación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else
        //            MessageBox.Show("Debe llenar todos los campos necesarios para poder continuar, recuerde que los los pesos deben ser mayor que 0 en las capas", "Formulación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    else
        //        MessageBox.Show("Debe llenar todos los campos coloreados de color ROJO", "Formulación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        //private bool ValidateFormFormulation()
        //{
        //    bool isValid = true;
        //    if (!clsValidation.validateField(ref txtFormulationTreatment, ref lblFormulationTreatmentLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtFormulationSpeedMachine, ref lblFormulationSpeedMachine, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtFormulationGramage, ref lblFormulationGramage, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtFormulationKilogramsPerHour, ref lblFormulationKilogramsPerHour, "notEmpty")) isValid = false;
        //    return isValid;
        //}

        //private void GenerateFormulationReport()
        //{
        //    int codsec = 0, width = 0, codsecCL = 0, codsecC1 = 0, codsecC2 = 0;
        //    double weigthCL = 0, weigthC1 = 0, weigthC2 = 0, produced = 0, decrease = 0, gramaje = 0;
        //    string initdate = string.Empty, endddate = string.Empty;
        //    clsFormulationReport ObjFormulationReport = new clsFormulationReport();

        //    codsec = objProductionOrder.codsec;
        //    weigthCL = clsFormulationCentralLayer.getTotalWeigth(codsec);
        //    weigthC1 = clsFormulationExtrusor1.getTotalWeigth(codsec);
        //    weigthC2 = clsFormulationExtrusor2.getTotalWeigth(codsec);
        //    produced = (lblFormulationExtruder.Text.Length > 0) ? Convert.ToDouble(lblFormulationExtruder.Text) : 0;
        //    decrease = (lblFormulationDecrease.Text.Length > 0) ? Convert.ToDouble(lblFormulationDecrease.Text) : 0;
        //    initdate = (lblFormulationInitDate.Text.Length > 0) ? lblFormulationInitDate.Text : "-----";
        //    endddate = (lblFormulationEndDate.Text.Length > 0) ? lblFormulationEndDate.Text : "-----";
        //    width = (lblFormulationWidth.Text.Length > 0) ? Convert.ToInt32(lblFormulationWidth.Text) : 0;
        //    ObjFormulationReport.load(codsec);
        //    gramaje = ObjFormulationReport.gramage;
        //    codsecCL = ObjFormulationReport.fkproductionorder;
        //    codsecC1 = ObjFormulationReport.fkproductionorder;
        //    codsecC2 = ObjFormulationReport.fkproductionorder;

        //    frmFormulationReport winFormulationReport = new frmFormulationReport(codsec, weigthCL, weigthC1, weigthC2, produced, decrease, initdate, endddate, width, codsecCL, codsecC1, codsecC2, gramaje);
        //    winFormulationReport.StartPosition = FormStartPosition.CenterScreen;
        //    winFormulationReport.MdiParent = this.MdiParent;
        //    winFormulationReport.Show();
        //}

        //private void tbcFormulation_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (tbcFormulation.SelectedIndex == 1)
        //    {
        //        if (txtFormulationGramage.Text.Length > 0)
        //        {
        //            double summarycentarlLayer = 0, summaryLayerC1 = 0, summaryLayerC2 = 0;

        //            dgvRawMaterial.Rows.Clear();

        //            for (int i = 0; i < dgvCentralLayer.Rows.Count; i++)
        //            {
        //                summarycentarlLayer += Convert.ToDouble(dgvCentralLayer.Rows[i].Cells[clmCentralLayerWeigth.Index].Value);
        //            }

        //            for (int i = 0; i < dgvC1.Rows.Count; i++)
        //            {
        //                summaryLayerC1 += Convert.ToDouble(dgvC1.Rows[i].Cells[clmC1Weigth.Index].Value);
        //            }

        //            for (int i = 0; i < dgvC2.Rows.Count; i++)
        //            {
        //                summaryLayerC2 += Convert.ToDouble(dgvC2.Rows[i].Cells[clmC2Weigth.Index].Value);
        //            }

        //            for (int i = 0; i < dgvCentralLayer.Rows.Count; i++)
        //            {
        //                dgvRawMaterial.Rows.Add();
        //                dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawmaterial.Index].Value = dgvCentralLayer.Rows[i].Cells[clmCentralLayerType.Index].Value.ToString();
        //                dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawtype.Index].Value = dgvCentralLayer.Rows[i].Cells[clmCentralLayerRawMaterial.Index].Value.ToString();
        //                dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawteorical.Index].Value = (Convert.ToDouble(dgvCentralLayer.Rows[i].Cells[clmCentralLayerWeigth.Index].Value) != 0) ? CalculeTeorical(Convert.ToDouble(dgvCentralLayer.Rows[i].Cells[clmCentralLayerWeigth.Index].Value), summarycentarlLayer, Convert.ToDouble(txtGramageCentralLayer.Text), Convert.ToDouble(txtFormulationGramage.Text)) : 0;
        //                dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawreal.Index].Value = (Convert.ToDouble(dgvCentralLayer.Rows[i].Cells[clmCentralLayerWeigth.Index].Value) != 0) ? CalculeReal(Convert.ToDouble(dgvCentralLayer.Rows[i].Cells[clmCentralLayerWeigth.Index].Value), summarycentarlLayer, Convert.ToDouble(txtGramageCentralLayer.Text), Convert.ToDouble(txtFormulationGramage.Text)) : 0;
        //            }

        //            for (int i = 0; i < dgvC1.Rows.Count; i++)
        //            {
        //                dgvRawMaterial.Rows.Add();
        //                dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawmaterial.Index].Value = dgvC1.Rows[i].Cells[clmC1Type.Index].Value.ToString();
        //                dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawtype.Index].Value = dgvC1.Rows[i].Cells[clmC1RawMaterial.Index].Value.ToString();
        //                dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawteorical.Index].Value = (Convert.ToDouble(dgvC1.Rows[i].Cells[clmC1Weigth.Index].Value) != 0) ? CalculeTeorical(Convert.ToDouble(dgvC1.Rows[i].Cells[clmC1Weigth.Index].Value), summaryLayerC1, Convert.ToDouble(txtGramageCO1.Text), Convert.ToDouble(txtFormulationGramage.Text)) : 0;
        //                dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawreal.Index].Value = (Convert.ToDouble(dgvC1.Rows[i].Cells[clmC1Weigth.Index].Value) != 0) ? CalculeReal(Convert.ToDouble(dgvC1.Rows[i].Cells[clmC1Weigth.Index].Value), summaryLayerC1, Convert.ToDouble(txtGramageCO1.Text), Convert.ToDouble(txtFormulationGramage.Text)) : 0;
        //            }

        //            for (int i = 0; i < dgvC2.Rows.Count; i++)
        //            {
        //                dgvRawMaterial.Rows.Add();
        //                dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawmaterial.Index].Value = dgvC2.Rows[i].Cells[clmC2Type.Index].Value.ToString();
        //                dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawtype.Index].Value = dgvC2.Rows[i].Cells[clmC2RawMaterial.Index].Value.ToString();
        //                dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawteorical.Index].Value = (Convert.ToDouble(dgvC2.Rows[i].Cells[clmC2Weigth.Index].Value) != 0) ? CalculeTeorical(Convert.ToDouble(dgvC2.Rows[i].Cells[clmC2Weigth.Index].Value), summaryLayerC2, Convert.ToDouble(txtGramageCO2.Text), Convert.ToDouble(txtFormulationGramage.Text)) : 0;
        //                dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawreal.Index].Value = (Convert.ToDouble(dgvC2.Rows[i].Cells[clmC2Weigth.Index].Value) != 0) ? CalculeReal(Convert.ToDouble(dgvC2.Rows[i].Cells[clmC2Weigth.Index].Value), summaryLayerC2, Convert.ToDouble(txtGramageCO2.Text), Convert.ToDouble(txtFormulationGramage.Text)) : 0;
        //            }
        //        }
        //        else
        //            MessageBox.Show("Debe llenar el campo de gramaje para poder realizar el calculo del consumo de materia prima", "Formulación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        //private void dgvCentralLayer_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        //{
        //    switch (dgvCentralLayer.CurrentCell.ColumnIndex)
        //    {
        //        case 6:
        //            if (clsGlobal.isNumeric(dgvCentralLayer.CurrentCell.EditedFormattedValue.ToString()) == false && dgvCentralLayer.CurrentCell.EditedFormattedValue.ToString() != "")
        //            {
        //                MessageBox.Show("El valor debe ser Numérico");
        //                dgvCentralLayer.CancelEdit();
        //            }
        //            break;
        //        default:
        //            break;
        //    }
        //}

        //private void dgvCentralLayer_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        //{
        //    e.Row.Cells[clmCentralLayerWeigth.Index].Value = "0";
        //}

        //private void dgvC2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        //{
        //    switch (dgvC2.CurrentCell.ColumnIndex)
        //    {
        //        case 6:
        //            if (clsGlobal.isNumeric(dgvC2.CurrentCell.EditedFormattedValue.ToString()) == false && dgvC2.CurrentCell.EditedFormattedValue.ToString() != "")
        //            {
        //                MessageBox.Show("El valor debe ser Numérico");
        //                dgvC2.CancelEdit();
        //            }
        //            break;
        //        default:
        //            break;
        //    }
        //}

        //private void dgvC1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        //{
        //    switch (dgvC1.CurrentCell.ColumnIndex)
        //    {
        //        case 6:
        //            if (clsGlobal.isNumeric(dgvC1.CurrentCell.EditedFormattedValue.ToString()) == false && dgvC1.CurrentCell.EditedFormattedValue.ToString() != "")
        //            {
        //                MessageBox.Show("El valor debe ser Numérico");
        //                dgvC1.CancelEdit();
        //            }
        //            break;
        //        default:
        //            break;
        //    }
        //}

        //private void dgvC2_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        //{
        //    e.Row.Cells[clmC1Weigth.Index].Value = "0";
        //}

        //private void dgvC1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        //{
        //    e.Row.Cells[clmC2Weigth.Index].Value = "0";
        //}

        //private void FillRawMaterial()
        //{
        //    clsFormulation objFormulation = clsFormulation.getFormulationBoppDetail(Convert.ToInt32(dgvProductionOrderFormulation.Rows[0].Cells[clmProductionOrderFormulationCodsec.Index].Value));
        //    List<clsRawMaterialByFormulation> lstRawMaterialByFormulation = new List<clsRawMaterialByFormulation>();
        //    lstRawMaterialByFormulation = clsRawMaterialByFormulation.getListByFormulation(objFormulation.codsec, true);
        //    for (int i = 0; i < lstRawMaterialByFormulation.Count; i++)
        //    {
        //        if (lstRawMaterialByFormulation[i].CentralLayer == true)
        //        {
        //            dgvRawMaterial.Rows.Add();
        //            dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawmaterial.Index].Value = lstRawMaterialByFormulation[i].nameTypeFormulation;
        //            dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawtype.Index].Value = lstRawMaterialByFormulation[i].material;
        //            dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawteorical.Index].Value = 0;
        //            dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawreal.Index].Value = 0;
        //        }
        //    }
        //    for (int i = 0; i < lstRawMaterialByFormulation.Count; i++)
        //    {
        //        if (lstRawMaterialByFormulation[i].layerC1 == true)
        //        {
        //            dgvRawMaterial.Rows.Add();
        //            dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawmaterial.Index].Value = lstRawMaterialByFormulation[i].nameTypeFormulation;
        //            dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawtype.Index].Value = lstRawMaterialByFormulation[i].material;
        //            dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawteorical.Index].Value = 0;
        //            dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawreal.Index].Value = 0;
        //        }
        //    }
        //    for (int i = 0; i < lstRawMaterialByFormulation.Count; i++)
        //    {
        //        if (lstRawMaterialByFormulation[i].layerC2 == true)
        //        {
        //            dgvRawMaterial.Rows.Add();
        //            dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawmaterial.Index].Value = lstRawMaterialByFormulation[i].nameTypeFormulation;
        //            dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawtype.Index].Value = lstRawMaterialByFormulation[i].material;
        //            dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawteorical.Index].Value = 0;
        //            dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawreal.Index].Value = 0;
        //        }
        //    }
        //}

        //private void GenerateValuesForRawMaterial()
        //{
        //    bool GridFormulationCenter = true, GridFormulationExtusor1 = true, GridFormulationExtrusor2 = true;
        //    for (int i = 0; i < dgvCentralLayer.Rows.Count; i++)
        //    {
        //        if (Convert.ToDouble(dgvCentralLayer.Rows[i].Cells[clmCentralLayerWeigth.Index].Value) == 0)
        //        {
        //            GridFormulationCenter = false;
        //            break;
        //        }
        //    }
        //    if (GridFormulationCenter)
        //    {
        //        for (int i = 0; i < dgvC1.Rows.Count; i++)
        //        {
        //            if (Convert.ToDouble(dgvC1.Rows[i].Cells[clmC1Weigth.Index].Value) == 0)
        //            {
        //                GridFormulationExtusor1 = false;
        //                break;
        //            }
        //        }
        //        if (GridFormulationExtusor1)
        //        {
        //            for (int i = 0; i < dgvC2.Rows.Count; i++)
        //            {
        //                if (Convert.ToDouble(dgvC2.Rows[i].Cells[clmC2Weigth.Index].Value) == 0)
        //                {
        //                    GridFormulationExtrusor2 = false;
        //                    break;
        //                }
        //            }
        //            if (GridFormulationExtrusor2)
        //            {

        //            }
        //        }
        //    }
        //}

        //#endregion

        //#region Desperdicios

        //private void LoadDecrease()
        //{
        //    List<clsDecrease> lstDecrease = clsDecrease.getListForFilmProductionPlan();
        //    cmbDecreaseName.Items.Clear();
        //    for (int i = 0; i < lstDecrease.Count; i++)
        //        cmbDecreaseName.Items.Add(lstDecrease[i]);

        //    PopulateDecrease();
        //}

        //private void btnAddDecrease_Click(object sender, EventArgs e)
        //{
        //    if (cmbDecreaseName.SelectedIndex > -1 && !string.IsNullOrEmpty(txtDecreaseQuantity.Text) && Convert.ToDouble(txtDecreaseQuantity.Text) > 0)
        //    {
        //        clsDecreaseByFilmProductionPlan objDecreaseByFilmProductionPlan = new clsDecreaseByFilmProductionPlan();
        //        objDecreaseByFilmProductionPlan.fkFilmProductionPlan = objFilmProductionPlan.codsec;
        //        objDecreaseByFilmProductionPlan.fkDecrease = ((clsDecrease)cmbDecreaseName.SelectedItem).codsec;
        //        objDecreaseByFilmProductionPlan.weight = Convert.ToDouble(txtDecreaseQuantity.Text);
        //        objDecreaseByFilmProductionPlan.createdDate = dtpDecreaseDate.Value;
        //        objDecreaseByFilmProductionPlan.fkFormulation = clsFormulationByFilmProductionPlan.getActiveFormulationByFilmProductionPlan(objFilmProductionPlan.codsec).fkFormulation;
        //        if (objDecreaseByFilmProductionPlan.save())
        //        {
        //            MessageBox.Show("Desperdicio Generado Correctamente..!!!");
        //            cmbDecreaseName.SelectedIndex = -1;
        //            txtDecreaseQuantity.Text = "0";
        //            cmbDecreaseName.Focus();
        //            cmbDecreaseName.Text = string.Empty;
        //            PopulateDecrease();
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Debe seleccionar un tipo de desperdicio o el valor del desperdicio debe ser mayor que 0", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        //        cmbDecreaseName.Focus();
        //    }
        //}

        //private void PopulateDecrease()
        //{
        //    List<clsDecreaseByFilmProductionPlan> lstDecreaseByFilmProductionPlan = clsDecreaseByFilmProductionPlan.getListByFilmProductionPlan(objFilmProductionPlan.codsec);
        //    double totalDecrease = 0;

        //    dgvDecrease.Rows.Clear();

        //    for (int i = 0; i < lstDecreaseByFilmProductionPlan.Count; i++)
        //    {
        //        dgvDecrease.Rows.Add();
        //        dgvDecrease.Rows[i].Cells[clmDecreaseCodsec.Index].Value = lstDecreaseByFilmProductionPlan[i].codsec;
        //        dgvDecrease.Rows[i].Cells[clmDecreaseName.Index].Value = lstDecreaseByFilmProductionPlan[i].decreaseName;
        //        dgvDecrease.Rows[i].Cells[clmDecreaseWeight.Index].Value = lstDecreaseByFilmProductionPlan[i].weight;
        //        dgvDecrease.Rows[i].Cells[clmDecreaseDate.Index].Value = lstDecreaseByFilmProductionPlan[i].createdDate.ToString("dd/MM/yyyy HH:mm");
        //        dgvDecrease.Rows[i].Cells[clmDecreaseDelete.Index].Value = global::BPS.Properties.Resources.cross;

        //        totalDecrease = totalDecrease + lstDecreaseByFilmProductionPlan[i].weight;
        //    }

        //    lblTotalDecrease.Text = Math.Round(totalDecrease, 2).ToString();
        //}

        //private void dgvDecrease_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.ColumnIndex == clmDecreaseDelete.Index)
        //    {
        //        if (MessageBox.Show("Está realmente seguro que desea eliminar el registro seleccionado?", "Aviso", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
        //        {
        //            clsConnection.executeQuery("DELETE FROM bps_prod_decreasebyfilmproductionplan WHERE dbfpp_codsec = " + dgvDecrease.Rows[e.RowIndex].Cells[clmDecreaseCodsec.Index].Value.ToString());
        //            PopulateDecrease();
        //        }
        //    }
        //}

        //private void cmbDecreaseName_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.F5)
        //    {
        //        List<clsDecrease> lstDecrease = clsDecrease.getListForFilmProductionPlan();
        //        cmbDecreaseName.Items.Clear();
        //        for (int i = 0; i < lstDecrease.Count; i++)
        //            cmbDecreaseName.Items.Add(lstDecrease[i]);
        //    }
        //}

        //private void btnExit4_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //#endregion

        //#region Tiempos Muertos

        //private void LoadDeadTime()
        //{
        //    List<clsDeadTimeGroup> lstDeadTime = new List<clsDeadTimeGroup>();
        //    lstDeadTime = clsDeadTimeGroup.getList();
        //    cmbdeadtimetype.Items.Clear();
        //    for (int i = 0; i < lstDeadTime.Count; i++)
        //        cmbdeadtimetype.Items.Add(lstDeadTime[i]);

        //    PopulateDeadTime();
        //}

        //private void PopulateDeadTime()
        //{
        //    List<clsDeadTimeByFilmProductionPlan> lstDeadTimeByFilmProductionPlan = clsDeadTimeByFilmProductionPlan.getListByFilmProductionPlanSecond(objFilmProductionPlan.codsec);
        //    TimeSpan dttime = new TimeSpan(0, 0, 0);
        //    TimeSpan dtttotal = new TimeSpan(0, 0, 0);
        //    dgvDeadTimeDetail.Rows.Clear();

        //    for (int i = 0; i < lstDeadTimeByFilmProductionPlan.Count; i++)
        //    {
        //        dgvDeadTimeDetail.Rows.Add();
        //        dgvDeadTimeDetail.Rows[i].Cells[clmdtcodsec.Index].Value = lstDeadTimeByFilmProductionPlan[i].codsec;
        //        dgvDeadTimeDetail.Rows[i].Cells[clmdtgroup.Index].Value = lstDeadTimeByFilmProductionPlan[i].deadTimeGroup;
        //        dgvDeadTimeDetail.Rows[i].Cells[clmdtdescription.Index].Value = lstDeadTimeByFilmProductionPlan[i].deadTimeTypeName;
        //        dgvDeadTimeDetail.Rows[i].Cells[clmdtnotes.Index].Value = lstDeadTimeByFilmProductionPlan[i].notes;
        //        dgvDeadTimeDetail.Rows[i].Cells[clmdtInit.Index].Value = lstDeadTimeByFilmProductionPlan[i].initDate.ToString("dd/MM/yyyy HH:mm");
        //        dgvDeadTimeDetail.Rows[i].Cells[clmdtend.Index].Value = lstDeadTimeByFilmProductionPlan[i].endDate.ToString("dd/MM/yyyy HH:mm");
        //        dttime = lstDeadTimeByFilmProductionPlan[i].endDate.Subtract(lstDeadTimeByFilmProductionPlan[i].initDate);
        //        dgvDeadTimeDetail.Rows[i].Cells[clmdttime.Index].Value = dttime.ToString();
        //        dgvDeadTimeDetail.Rows[i].Cells[clmdtdelete.Index].Value = global::BPS.Properties.Resources.cross;
        //        if (string.IsNullOrEmpty(lstDeadTimeByFilmProductionPlan[i].notes))
        //            dgvDeadTimeDetail.Rows[i].Cells[clmdtview.Index].Value = global::BPS.Properties.Resources.text;
        //        else
        //            dgvDeadTimeDetail.Rows[i].Cells[clmdtview.Index].Value = global::BPS.Properties.Resources.textOK;

        //        dgvDeadTimeDetail.Rows[i].Cells[clmdtsource.Index].Value = lstDeadTimeByFilmProductionPlan[i].source;

        //        dtttotal += new TimeSpan(dttime.Days, dttime.Hours, dttime.Minutes, 0);
        //    }

        //    ColorByDeadTime();
        //    label36.Text = dtttotal.ToString();
        //}

        //private void cmbdeadtimetype_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cmbdeadtimetype.SelectedIndex > -1)
        //    {
        //        List<clsDeadTimeTypePlus> lstDeadTime = new List<clsDeadTimeTypePlus>();
        //        lstDeadTime = clsDeadTimeTypePlus.getListByGroup(((clsDeadTimeGroup)cmbdeadtimetype.SelectedItem).codsec);
        //        cmbdeadtimedescription.Items.Clear();
        //        for (int i = 0; i < lstDeadTime.Count; i++)
        //            cmbdeadtimedescription.Items.Add(lstDeadTime[i]);
        //    }
        //}

        //private void cmbdeadtimedescription_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cmbdeadtimedescription.SelectedIndex > -1)
        //        lblst.Text = "St : [" + ((clsDeadTimeTypePlus)cmbdeadtimedescription.SelectedItem).days + "." + ((clsDeadTimeTypePlus)cmbdeadtimedescription.SelectedItem).standartTime.Hours + ":" + ((clsDeadTimeTypePlus)cmbdeadtimedescription.SelectedItem).standartTime.Minutes + ":00]";
        //    else
        //        lblst.Text = string.Empty;
        //}

        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    TimeSpan tdeadtime = new TimeSpan(0, 0, 0);
        //    TimeSpan ttdeadtime = new TimeSpan(0, 0, 0);
        //    TimeSpan thdeadtime = new TimeSpan(0, 0, 0);

        //    if (dtpInitDate.Value.CompareTo(dtpEndDate.Value) < 0)
        //    {
        //        if (ValidateFormDeadTime())
        //        {
        //            tdeadtime = dtpEndDate.Value.Subtract(dtpInitDate.Value);
        //            clsDeadTimeTypePlus objDeadTime = new clsDeadTimeTypePlus();
        //            objDeadTime = clsDeadTimeTypePlus.Load(((clsDeadTimeTypePlus)cmbdeadtimedescription.SelectedItem).codsec);
        //            if (objDeadTime.isEnable)
        //            {
        //                if (objDeadTime.days > 0)
        //                {
        //                    thdeadtime = new TimeSpan(objDeadTime.days, objDeadTime.standartTime.Hours, objDeadTime.standartTime.Minutes, 0);
        //                    if (tdeadtime > thdeadtime)
        //                    {
        //                        ttdeadtime = tdeadtime - thdeadtime;
        //                        if (ttdeadtime.Days > 0)
        //                            MessageBox.Show("Usted a superado el estandar asignado para este tipo de tiempo muerto por lo tanto se distribuirá de la siguiente manera :\n\r" + ((clsDeadTimeGroup)cmbdeadtimetype.SelectedItem).name + " : " + ttdeadtime.Days.ToString() + "." + objDeadTime.standartTime + "\n\rTiempo Muerto Mantenimiento : " + ttdeadtime.Days.ToString() + "." + ttdeadtime.Hours.ToString() + ":" + ttdeadtime.Minutes.ToString() + ":00", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        //                        else
        //                            MessageBox.Show("Usted a superado el estandar asignado para este tipo de tiempo muerto por lo tanto se distribuirá de la siguiente manera :\n\r" + ((clsDeadTimeGroup)cmbdeadtimetype.SelectedItem).name + " : " + objDeadTime.standartTime + "\n\rTiempo Muerto Mantenimiento : " + ttdeadtime.Hours.ToString() + ":" + ttdeadtime.Minutes.ToString() + ":00", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);


        //                        var dateinit = dtpInitDate.Value;
        //                        dateinit += new TimeSpan(objDeadTime.days, objDeadTime.standartTime.Hours, objDeadTime.standartTime.Minutes, 0);
        //                        clsDeadTimeByFilmProductionPlan objDeadTimeByFilmProductionPlan = new clsDeadTimeByFilmProductionPlan();
        //                        objDeadTimeByFilmProductionPlan.fkDeadTimeType = objDeadTime.codsec;
        //                        objDeadTimeByFilmProductionPlan.fkFilmProductionPlan = objFilmProductionPlan.codsec;
        //                        objDeadTimeByFilmProductionPlan.initDate = dtpInitDate.Value;
        //                        objDeadTimeByFilmProductionPlan.endDate = dateinit;
        //                        objDeadTimeByFilmProductionPlan.source = 0;
        //                        if (objDeadTimeByFilmProductionPlan.save())
        //                        {
        //                            var dateend = dateinit;
        //                            dateend += new TimeSpan(ttdeadtime.Days, ttdeadtime.Hours, ttdeadtime.Minutes, 0);
        //                            objDeadTimeByFilmProductionPlan = new clsDeadTimeByFilmProductionPlan();
        //                            objDeadTimeByFilmProductionPlan.fkDeadTimeType = 163;
        //                            objDeadTimeByFilmProductionPlan.fkFilmProductionPlan = objFilmProductionPlan.codsec;
        //                            objDeadTimeByFilmProductionPlan.initDate = dateinit;
        //                            objDeadTimeByFilmProductionPlan.endDate = dateend;
        //                            objDeadTimeByFilmProductionPlan.source = clsDeadTimeByFilmProductionPlan.getLastCodsec();
        //                            var lastCodsec = objDeadTimeByFilmProductionPlan.source;
        //                            if (objDeadTimeByFilmProductionPlan.save())
        //                            {
        //                                if (clsDeadTimeByFilmProductionPlan.updateSource(lastCodsec))
        //                                {
        //                                    MessageBox.Show("Tiempo Muerto Generado Correctamente");
        //                                    ClearFormDeadTime();
        //                                    PopulateDeadTime();
        //                                }
        //                                else
        //                                {
        //                                    MessageBox.Show("Ha sucedido un error al guardar source tiempo muerto", "Tiempos Muertos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        //                                    PopulateDeadTime();
        //                                }
        //                            }
        //                            else
        //                            {
        //                                MessageBox.Show("Ha sucedido un error al guardar el restante tiempo muerto", "Tiempos Muertos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        //                                PopulateDeadTime();
        //                            }
        //                        }
        //                        else
        //                        {
        //                            MessageBox.Show("Ha sucedido un error al guardar el estandar del tiempo muerto", "Tiempos Muertos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        //                            PopulateDeadTime();
        //                        }
        //                    }
        //                    else
        //                    {
        //                        clsDeadTimeByFilmProductionPlan objDeadTimeByFilmProductionPlan = new clsDeadTimeByFilmProductionPlan();
        //                        objDeadTimeByFilmProductionPlan.fkDeadTimeType = objDeadTime.codsec;
        //                        objDeadTimeByFilmProductionPlan.fkFilmProductionPlan = objFilmProductionPlan.codsec;
        //                        objDeadTimeByFilmProductionPlan.initDate = dtpInitDate.Value;
        //                        objDeadTimeByFilmProductionPlan.endDate = dtpEndDate.Value;
        //                        objDeadTimeByFilmProductionPlan.source = 0;
        //                        if (objDeadTimeByFilmProductionPlan.save())
        //                        {
        //                            MessageBox.Show("Tiempo Muerto Generado Correctamente");
        //                            ClearFormDeadTime();
        //                            PopulateDeadTime();
        //                        }
        //                        else
        //                        {
        //                            MessageBox.Show("Ha sucedido un error al guardar tiempo muerto", "Tiempos Muertos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        //                            PopulateDeadTime();
        //                        }
        //                    }
        //                }
        //                else
        //                {
        //                    tdeadtime = dtpEndDate.Value.Subtract(dtpInitDate.Value);
        //                    objDeadTime = new clsDeadTimeTypePlus();
        //                    objDeadTime = clsDeadTimeTypePlus.Load(((clsDeadTimeTypePlus)cmbdeadtimedescription.SelectedItem).codsec);

        //                    if (tdeadtime > objDeadTime.standartTime)
        //                    {
        //                        ttdeadtime = tdeadtime - objDeadTime.standartTime;
        //                        if (ttdeadtime.Days > 0)
        //                            MessageBox.Show("Usted a superado el estandar asignado para este tipo de tiempo muerto por lo tanto se distribuirá de la siguiente manera :\n\r" + ((clsDeadTimeGroup)cmbdeadtimetype.SelectedItem).name + " : " + objDeadTime.standartTime + "\n\rTiempo Muerto Mantenimiento : " + ttdeadtime.Days.ToString() + "." + ttdeadtime.Hours.ToString() + ":" + ttdeadtime.Minutes.ToString() + ":00", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        //                        else
        //                            MessageBox.Show("Usted a superado el estandar asignado para este tipo de tiempo muerto por lo tanto se distribuirá de la siguiente manera :\n\r" + ((clsDeadTimeGroup)cmbdeadtimetype.SelectedItem).name + " : " + objDeadTime.standartTime + "\n\rTiempo Muerto Mantenimiento : " + ttdeadtime.Hours.ToString() + ":" + ttdeadtime.Minutes.ToString() + ":00", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        //                        var dateinit = dtpInitDate.Value;
        //                        dateinit += new TimeSpan(objDeadTime.standartTime.Hours, objDeadTime.standartTime.Minutes, 0);
        //                        clsDeadTimeByFilmProductionPlan objDeadTimeByFilmProductionPlan = new clsDeadTimeByFilmProductionPlan();
        //                        objDeadTimeByFilmProductionPlan.fkDeadTimeType = objDeadTime.codsec;
        //                        objDeadTimeByFilmProductionPlan.fkFilmProductionPlan = objFilmProductionPlan.codsec;
        //                        objDeadTimeByFilmProductionPlan.initDate = dtpInitDate.Value;
        //                        objDeadTimeByFilmProductionPlan.endDate = dateinit;
        //                        objDeadTimeByFilmProductionPlan.source = 0;
        //                        if (objDeadTimeByFilmProductionPlan.save())
        //                        {
        //                            var dateend = dateinit;
        //                            if (ttdeadtime.Days > 0)
        //                                dateend += new TimeSpan(ttdeadtime.Days, ttdeadtime.Hours, ttdeadtime.Minutes, 0);
        //                            else
        //                                dateend += new TimeSpan(ttdeadtime.Hours, ttdeadtime.Minutes, 0);

        //                            objDeadTimeByFilmProductionPlan = new clsDeadTimeByFilmProductionPlan();
        //                            objDeadTimeByFilmProductionPlan.fkDeadTimeType = 163;
        //                            objDeadTimeByFilmProductionPlan.fkFilmProductionPlan = objFilmProductionPlan.codsec;
        //                            objDeadTimeByFilmProductionPlan.initDate = dateinit;
        //                            objDeadTimeByFilmProductionPlan.endDate = dateend;
        //                            objDeadTimeByFilmProductionPlan.source = clsDeadTimeByFilmProductionPlan.getLastCodsec();
        //                            var lastCodsec = objDeadTimeByFilmProductionPlan.source;
        //                            if (objDeadTimeByFilmProductionPlan.save())
        //                            {
        //                                if (clsDeadTimeByFilmProductionPlan.updateSource(lastCodsec))
        //                                {
        //                                    MessageBox.Show("Tiempo Muerto Generado Correctamente");
        //                                    ClearFormDeadTime();
        //                                    PopulateDeadTime();
        //                                }
        //                                else
        //                                {
        //                                    MessageBox.Show("Ha sucedido un error al guardar source tiempo muerto", "Tiempos Muertos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        //                                    PopulateDeadTime();
        //                                }
        //                            }
        //                            else
        //                            {
        //                                MessageBox.Show("Ha sucedido un error al guardar el restante tiempo muerto", "Tiempos Muertos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        //                                PopulateDeadTime();
        //                            }
        //                        }
        //                        else
        //                        {
        //                            MessageBox.Show("Ha sucedido un error al guardar el estandar del tiempo muerto", "Tiempos Muertos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        //                            PopulateDeadTime();
        //                        }
        //                    }
        //                    else
        //                    {
        //                        clsDeadTimeByFilmProductionPlan objDeadTimeByFilmProductionPlan = new clsDeadTimeByFilmProductionPlan();
        //                        objDeadTimeByFilmProductionPlan.fkDeadTimeType = objDeadTime.codsec;
        //                        objDeadTimeByFilmProductionPlan.fkFilmProductionPlan = objFilmProductionPlan.codsec;
        //                        objDeadTimeByFilmProductionPlan.initDate = dtpInitDate.Value;
        //                        objDeadTimeByFilmProductionPlan.endDate = dtpEndDate.Value;
        //                        objDeadTimeByFilmProductionPlan.source = 0;
        //                        if (objDeadTimeByFilmProductionPlan.save())
        //                        {
        //                            MessageBox.Show("Tiempo Muerto Generado Correctamente");
        //                            ClearFormDeadTime();
        //                            PopulateDeadTime();
        //                        }
        //                        else
        //                        {
        //                            MessageBox.Show("Ha sucedido un error al guardar tiempo muerto", "Tiempos Muertos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        //                            PopulateDeadTime();
        //                        }
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                clsDeadTimeByFilmProductionPlan objDeadTimeByFilmProductionPlan = new clsDeadTimeByFilmProductionPlan();
        //                objDeadTimeByFilmProductionPlan.fkDeadTimeType = objDeadTime.codsec;
        //                objDeadTimeByFilmProductionPlan.fkFilmProductionPlan = objFilmProductionPlan.codsec;
        //                objDeadTimeByFilmProductionPlan.initDate = dtpInitDate.Value;
        //                objDeadTimeByFilmProductionPlan.endDate = dtpEndDate.Value;
        //                objDeadTimeByFilmProductionPlan.source = 0;
        //                if (objDeadTimeByFilmProductionPlan.save())
        //                {
        //                    MessageBox.Show("Tiempo Muerto Generado Correctamente");
        //                    ClearFormDeadTime();
        //                    PopulateDeadTime();
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Ha sucedido un error al guardar tiempo muerto", "Tiempos Muertos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        //                    PopulateDeadTime();
        //                }
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Debe llenar todos los campos requeridos pintados de color ROJO", "Tiempos Muertos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        //            PopulateDeadTime();
        //        }
        //    }
        //    else if (dtpInitDate.Value.CompareTo(dtpEndDate.Value) == 0)
        //        MessageBox.Show("Las fechas de los tiempos muertos no pueden ser iguales por favor cambie las fechas", "Tiempos muertos", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        //    else if (dtpInitDate.Value.CompareTo(dtpEndDate.Value) > 0)
        //        MessageBox.Show("La fecha inicio del tiempo muerto no pueden ser mayor que la fecha fin del tiempo muerto", "Tiempos muertos", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        //}

        //private bool ValidateFormDeadTime()
        //{
        //    bool isValid = true;
        //    if (!clsValidation.validateField(ref cmbdeadtimedescription, ref label34, "selected")) isValid = false;
        //    if (!clsValidation.validateField(ref cmbdeadtimetype, ref label36, "selected")) isValid = false;
        //    return isValid;
        //}

        //private void btnNewAdd_Click(object sender, EventArgs e)
        //{
        //    frmDeadTimeGroup winGroup = new frmDeadTimeGroup();
        //    winGroup.ShowDialog();
        //    ClearFormDeadTime();
        //    PopulateDeadTime();
        //}

        //private void ClearFormDeadTime()
        //{
        //    cmbdeadtimetype.SelectedIndex = -1;
        //    cmbdeadtimetype.SelectedItem = 0;
        //    cmbdeadtimetype.Text = string.Empty;
        //    cmbdeadtimetype.Focus();
        //    cmbdeadtimedescription.SelectedIndex = -1;
        //    cmbdeadtimedescription.SelectedItem = 0;
        //    cmbdeadtimedescription.Text = string.Empty;
        //    dtpInitDate.Value = DateTime.Now;
        //    dtpEndDate.Value = DateTime.Now;
        //}

        //private void ColorByDeadTime()
        //{
        //    for (int i = 0; i < dgvDeadTimeDetail.Rows.Count; i++)
        //    {
        //        if (dgvDeadTimeDetail.Rows[i].Cells[clmdtgroup.Index].Value != null)
        //        {
        //            switch (dgvDeadTimeDetail.Rows[i].Cells[clmdtgroup.Index].Value.ToString())
        //            {
        //                case "TMP":
        //                    for (int j = 0; j < dgvDeadTimeDetail.Columns.Count - 2; j++)
        //                        dgvDeadTimeDetail.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(207, 234, 254);
        //                    break;
        //                case "TMOtros":
        //                    for (int j = 0; j < dgvDeadTimeDetail.Columns.Count - 2; j++)
        //                        dgvDeadTimeDetail.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(232, 202, 244);
        //                    break;
        //                case "TMM":
        //                    for (int j = 0; j < dgvDeadTimeDetail.Columns.Count - 2; j++)
        //                        dgvDeadTimeDetail.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(249, 196, 183);
        //                    break;
        //                default:
        //                    break;
        //            }
        //        }
        //    }
        //}

        //private void dgvDeadTimeDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.ColumnIndex == clmdtdelete.Index)
        //    {
        //        if (Convert.ToInt32(dgvDeadTimeDetail.Rows[e.RowIndex].Cells[clmdtsource.Index].Value) != 0)
        //        {
        //            if (MessageBox.Show("Está realmente seguro que desea eliminar el tiempo muerto seleccionado?\n\rRecuerde que el tiempo muerto que desea eliminar está ligado a un tiempo muerto por mantenimiento!", "Tiempo Muerto", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
        //            {
        //                if (clsDeadTimeByFilmProductionPlan.deteleSource(Convert.ToInt32(dgvDeadTimeDetail.Rows[e.RowIndex].Cells[clmdtsource.Index].Value)))
        //                {
        //                    MessageBox.Show("Tiempo Muerto Eliminado Correctamente");
        //                    ClearFormDeadTime();
        //                    PopulateDeadTime();
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Ha sucedido un error al intentar eliminar tiempo muerto", "Tiempos Muertos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        //                    PopulateDeadTime();
        //                }
        //            }
        //        }
        //        else
        //        {
        //            if (MessageBox.Show("Está realmente seguro que desea eliminar el tiempo muerto seleccionado?", "Tiempo Muerto", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
        //            {
        //                if (clsDeadTimeByFilmProductionPlan.detele(Convert.ToInt32(dgvDeadTimeDetail.Rows[e.RowIndex].Cells[clmdtcodsec.Index].Value)))
        //                {
        //                    MessageBox.Show("Tiempo Muerto Eliminado Correctamente");
        //                    ClearFormDeadTime();
        //                    PopulateDeadTime();
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Ha sucedido un error al intentar eliminar tiempo muerto", "Tiempos Muertos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        //                    PopulateDeadTime();
        //                }
        //            }
        //        }
        //    }
        //}

        //private void dgvDeadTimeDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.ColumnIndex == clmdtnotes.Index)
        //    {
        //        frmCuttingOrderNotes winCuttingOrderNotes = new frmCuttingOrderNotes(this);
        //        winCuttingOrderNotes.StartPosition = FormStartPosition.CenterScreen;
        //        winCuttingOrderNotes.ShowDialog(this);
        //        var codsec = Int32.Parse(dgvDeadTimeDetail.Rows[e.RowIndex].Cells[clmdtcodsec.Index].Value.ToString());
        //        if (!string.IsNullOrEmpty(notesfull))
        //        {
        //            if (clsDeadTimeByFilmProductionPlan.updateNotes(codsec, notesfull))
        //            {
        //                MessageBox.Show("Notas Generadas Correctamente");
        //                ClearFormDeadTime();
        //                PopulateDeadTime();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Ha sucedido un error al guardar las notas anexas al tiempo muerto", "Tiempos Muertos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        //                PopulateDeadTime();
        //            }
        //        }
        //        else
        //        {
        //            if (clsDeadTimeByFilmProductionPlan.updateNotes(codsec, notesfull))
        //            {
        //                ClearFormDeadTime();
        //                PopulateDeadTime();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Ha sucedido un error al guardar las notas anexas al tiempo muerto", "Tiempos Muertos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        //                PopulateDeadTime();
        //            }
        //        }
        //    }
        //}

        //#endregion

        //#region Record de Producción

        //private void LoadRecordProduction(int machineCodsec)
        //{
        //    if (machineCodsec == 1)
        //    {
        //        tbcProductionOrder.TabPages.Remove(tbpRecordProductionDMT);
        //        lblOrderProductionMW.Text = objProductionOrderDetail.OrderNumber.ToString();
        //        lblTypeMW.Text = objProductionOrderDetail.BoppCode.ToString().Replace("-", "");
        //        lblThicknessMW.Text = ObjBopp.Thickness.ToString();
        //        label9.Text = objFilmProductionPlan.lotNumber.ToString();
        //        label6.Text = DateTime.Now.ToShortDateString();

        //        if (clsRecordDMT.getSituation(objProductionOrder.codsec))
        //        {
        //            btnMW.Enabled = false;
        //            lblMWSatus.Text = "RECORD DE PRODUCCIÓN INGRESADO";
        //            lblMWSatus.ForeColor = Color.Black;
        //        }
        //        else
        //        {
        //            btnMW.Enabled = true;
        //            lblMWSatus.Text = "RECORD DE PRODUCCIÓN  NO INGRESADO";
        //            lblMWSatus.ForeColor = Color.Red;
        //        }
        //    }
        //    else
        //    {
        //        tbcProductionOrder.TabPages.Remove(tbpRecordProductionMW);
        //        lblOrder.Text = objProductionOrderDetail.OrderNumber.ToString();
        //        lblType.Text = objProductionOrderDetail.BoppCode.ToString().Replace("-", "");
        //        lblThickness.Text = ObjBopp.Thickness.ToString();
        //        lblLotNumber.Text = objFilmProductionPlan.lotNumber.ToString();
        //        lblDate.Text = DateTime.Now.ToShortDateString();

        //        if (clsRecordDMT.getSituation(objProductionOrder.codsec))
        //        {
        //            btnDmt.Enabled = false;
        //            lblDMTSatus.Text = "RECORD DE PRODUCCIÓN INGRESADO";
        //            lblDMTSatus.ForeColor = Color.Black;
        //        }
        //        else
        //        {
        //            btnDmt.Enabled = true;
        //            lblDMTSatus.Text = "RECORD DE PRODUCCIÓN  NO INGRESADO";
        //            lblDMTSatus.ForeColor = Color.Red;
        //        }
        //    }
        //}

        //private void btnReportRecorpProduction_Click(object sender, EventArgs e)
        //{
        //    clsRecordProduction ObjRecordProduction = new clsRecordProduction(objProductionOrder.codsec);
        //    if (ObjRecordProduction.recprocodsec > 0)
        //    {
        //        frmRecordProductionReportView winRecordProductionReport = new frmRecordProductionReportView(ObjRecordProduction.recprocodsec);
        //        winRecordProductionReport.StartPosition = FormStartPosition.CenterScreen;
        //        winRecordProductionReport.WindowState = FormWindowState.Maximized;
        //        winRecordProductionReport.MdiParent = this.MdiParent;
        //        winRecordProductionReport.Show();
        //    }
        //    else
        //        MessageBox.Show("No existen datos para generar el Reporte.", "Record de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}

        //private void btnSaveRecordProduction_Click(object sender, EventArgs e)
        //{
        //    clsRecordProduction ObjRecordProduction = new clsRecordProduction();
        //    clsRecordProductionHead ObjRecordProductionHead = new clsRecordProductionHead();
        //    clsRecordProductionLaboratory ObjRecordProductionlaboratory = new clsRecordProductionLaboratory();
        //    clsRecordProductionMdo ObjRecordProductionMdo = new clsRecordProductionMdo();
        //    clsRecordProductionPressure ObjRecordProductionPressure = new clsRecordProductionPressure();
        //    clsRecordProductionPrs ObjRecordProductionPrs = new clsRecordProductionPrs();
        //    clsRecordProductionSatellite ObjRecordProductionSatellite = new clsRecordProductionSatellite();
        //    clsRecordProductionTdo ObjRecordProductionTdo = new clsRecordProductionTdo();
        //    clsRecordProductionThickness ObjRecordProductionThickness = new clsRecordProductionThickness();

        //    if (ValidateFormDMT())
        //    {
        //        //Record Production
        //        ObjRecordProduction.fkproductionorder = objProductionOrder.codsec;
        //        ObjRecordProduction.lotnumber = (lblLotNumber.Text == string.Empty) ? "0" : lblLotNumber.Text;
        //        ObjRecordProduction.type = objProductionOrderDetail.BoppCode.ToString().Replace("-", "");
        //        ObjRecordProduction.thickness = ObjBopp.Thickness.value;
        //        ObjRecordProduction.temperaturemainz1 = Convert.ToDouble(txtZ1.Text);
        //        ObjRecordProduction.temperaturemainz2 = Convert.ToDouble(txtZ2.Text);
        //        ObjRecordProduction.temperaturemainz3 = Convert.ToDouble(txtZ3.Text);
        //        ObjRecordProduction.temperaturemainz4 = Convert.ToDouble(txtZ4.Text);
        //        ObjRecordProduction.temperaturemainz5 = Convert.ToDouble(txtZ5.Text);
        //        ObjRecordProduction.temperaturemainz6 = Convert.ToDouble(txtZ6.Text);
        //        ObjRecordProduction.temperaturemainz7 = Convert.ToDouble(txtZ7.Text);
        //        ObjRecordProduction.temperaturemainbrida = Convert.ToDouble(txtBrida.Text);
        //        ObjRecordProduction.temperaturemainmelt = Convert.ToDouble(txtMelt.Text);
        //        ObjRecordProduction.temperaturemainfilter1 = Convert.ToDouble(txtFilter1.Text);
        //        ObjRecordProduction.temperaturemainfilter2 = Convert.ToDouble(txtFilter2.Text);
        //        ObjRecordProduction.temperaturemainmelt1 = Convert.ToDouble(txtMelt1.Text);
        //        ObjRecordProduction.temperaturemaindiverter = Convert.ToDouble(txtDiverter.Text);
        //        ObjRecordProduction.pressurebeforefiltermain = Convert.ToDouble(txtFilterBeforePressure.Text);
        //        ObjRecordProduction.pressureafterfiltermain = Convert.ToDouble(txtFilterAfterPressure.Text);
        //        ObjRecordProduction.pressuremain = Convert.ToDouble(txtDeferencialPressure.Text);
        //        ObjRecordProduction.revolutionperminutemain = Convert.ToDouble(txtRpmMain.Text);
        //        ObjRecordProduction.amperagemain = Convert.ToDouble(txtAmperage.Text);

        //        if (ObjRecordProduction.saves())
        //        {
        //            //Record Production Head
        //            ObjRecordProductionHead.recproheafkrecordproduction = clsRecordProduction.getLastSavedRecordProduction();
        //            ObjRecordProductionHead.recproheafkproductionorder = objProductionOrder.codsec;
        //            ObjRecordProductionHead.headz1 = Convert.ToDouble(txtZ1Head.Text);
        //            ObjRecordProductionHead.headz2 = Convert.ToDouble(txtZ2Head.Text);
        //            ObjRecordProductionHead.headz3 = Convert.ToDouble(txtZ3Head.Text);
        //            ObjRecordProductionHead.headz4 = Convert.ToDouble(txtZ4Head.Text);
        //            ObjRecordProductionHead.headz5 = Convert.ToDouble(txtZ5Head.Text);
        //            ObjRecordProductionHead.headtemperaturecylinder = Convert.ToDouble(txtCylinder.Text);
        //            ObjRecordProductionHead.headtemperaturetub = Convert.ToDouble(txtCylinderVal.Text);
        //            ObjRecordProductionHead.headtemperaturermp = Convert.ToDouble(txtCylinderRpm.Text);
        //            ObjRecordProductionHead.headtemperatureamperage = Convert.ToDouble(txtCylinderAmperage.Text);
        //            ObjRecordProductionHead.headangle = Convert.ToDouble(txtAmperageWidth.Text);
        //            ObjRecordProductionHead.headpression = Convert.ToDouble(txtPression.Text);
        //            ObjRecordProductionHead.headheight = Convert.ToDouble(txtAmperageHeigth.Text);
        //            ObjRecordProductionHead.headcr = Convert.ToDouble(txtAmperageCR.Text);
        //            ObjRecordProductionHead.headmdo = Convert.ToDouble(txtAmperageMDO.Text);
        //            ObjRecordProductionHead.headtemp = txtAmperageTemp.Text;

        //            if (ObjRecordProductionHead.saves("save"))
        //            {
        //                //Record Production Laboratory
        //                ObjRecordProductionlaboratory.recprolabfkrecordproduction = clsRecordProduction.getLastSavedRecordProduction();
        //                ObjRecordProductionlaboratory.recprolabfkproductionorder = objProductionOrder.codsec;
        //                ObjRecordProductionlaboratory.seal = txtPowerSealCt.Text;
        //                ObjRecordProductionlaboratory.glow = txtBrightnessCt.Text;
        //                ObjRecordProductionlaboratory.coefficientcnt = txtCoefficientCt.Text;
        //                ObjRecordProductionlaboratory.superficial = txtShallowTension.Text;
        //                ObjRecordProductionlaboratory.sealcnt = txtPowerSealCnt.Text;
        //                ObjRecordProductionlaboratory.glowcnt = txtBrightnessCnt.Text;
        //                ObjRecordProductionlaboratory.coefficientcnt = txtCoefficientCnt.Text;
        //                ObjRecordProductionlaboratory.transmitance = txtTransmitance.Text;
        //                ObjRecordProductionlaboratory.haze = txtHaze.Text;

        //                if (ObjRecordProductionlaboratory.saves("save"))
        //                {
        //                    //Record Production MDO
        //                    ObjRecordProductionMdo.recpromdofkrecordproduction = clsRecordProduction.getLastSavedRecordProduction();
        //                    ObjRecordProductionMdo.recpromdofkproductionorder = objProductionOrder.codsec;
        //                    ObjRecordProductionMdo.mdocirprin = Convert.ToDouble(txtCirPrin.Text);
        //                    ObjRecordProductionMdo.mdoz1 = Convert.ToDouble(txtZ1Mdo.Text);
        //                    ObjRecordProductionMdo.mdoz2 = Convert.ToDouble(txtZ2Mdo.Text);
        //                    ObjRecordProductionMdo.mdoz3 = Convert.ToDouble(txtZ3Mdo.Text);
        //                    ObjRecordProductionMdo.mdoz4 = Convert.ToDouble(txtZ4Mdo.Text);
        //                    ObjRecordProductionMdo.mdoest1 = Convert.ToDouble(txtEst1Mdo.Text);
        //                    ObjRecordProductionMdo.mdoest2 = Convert.ToDouble(txtEst2Mdo.Text);
        //                    ObjRecordProductionMdo.mdoestab = Convert.ToDouble(txtEstabMdo.Text);
        //                    ObjRecordProductionMdo.mdo1velocity = Convert.ToDouble(txtSpeedMdo1.Text);
        //                    ObjRecordProductionMdo.mdo1amperage = Convert.ToDouble(txtAmperageMdo1.Text);
        //                    ObjRecordProductionMdo.mdo2velocity = Convert.ToDouble(txtSpeedMdo2.Text);
        //                    ObjRecordProductionMdo.mdo2amperage = Convert.ToDouble(txtAmperageMdo2.Text);
        //                    ObjRecordProductionMdo.mdofixation1 = Convert.ToDouble(txtFixation1Mdo.Text);
        //                    ObjRecordProductionMdo.mdofixation2 = Convert.ToDouble(txtFixation2Mdo.Text);

        //                    if (ObjRecordProductionMdo.saves("save"))
        //                    {
        //                        //Record Production Pressure
        //                        ObjRecordProductionPressure.recproprefkrecordproduction = clsRecordProduction.getLastSavedRecordProduction();
        //                        ObjRecordProductionPressure.recproprefkproductionorder = objProductionOrder.codsec;
        //                        ObjRecordProductionPressure.coil1 = Convert.ToDouble(txtTension1.Text);
        //                        ObjRecordProductionPressure.coil2 = Convert.ToDouble(txtTension2.Text);
        //                        ObjRecordProductionPressure.coil3 = Convert.ToDouble(txtTension3.Text);
        //                        ObjRecordProductionPressure.coil4 = Convert.ToDouble(txtTension4.Text);
        //                        ObjRecordProductionPressure.coil5 = Convert.ToDouble(txtTension5.Text);
        //                        ObjRecordProductionPressure.coil6 = Convert.ToDouble(txtTension6.Text);
        //                        ObjRecordProductionPressure.coil7 = Convert.ToDouble(txtTension7.Text);
        //                        ObjRecordProductionPressure.coil8 = Convert.ToDouble(txtTension8.Text);
        //                        ObjRecordProductionPressure.coil9 = Convert.ToDouble(txtTension9.Text);
        //                        ObjRecordProductionPressure.pressure1 = Convert.ToDouble(txtPressure1.Text);
        //                        ObjRecordProductionPressure.pressure2 = Convert.ToDouble(txtPressure2.Text);
        //                        ObjRecordProductionPressure.pressure3 = Convert.ToDouble(txtPressure3.Text);
        //                        ObjRecordProductionPressure.pressure4 = Convert.ToDouble(txtPressure4.Text);
        //                        ObjRecordProductionPressure.pressure5 = Convert.ToDouble(txtPressure5.Text);
        //                        ObjRecordProductionPressure.pressure6 = Convert.ToDouble(txtPressure6.Text);
        //                        ObjRecordProductionPressure.pressure7 = Convert.ToDouble(txtPressure7.Text);
        //                        ObjRecordProductionPressure.pressure8 = Convert.ToDouble(txtPressure8.Text);
        //                        ObjRecordProductionPressure.pressure9 = Convert.ToDouble(txtPressure9.Text);
        //                        ObjRecordProductionPressure.tensioncut = Convert.ToDouble(txtCutTension.Text);
        //                        ObjRecordProductionPressure.tensionchange = Convert.ToDouble(txtChangeTension.Text);
        //                        ObjRecordProductionPressure.coilthickness = Convert.ToDouble(txtThicknessCoil.Text);
        //                        ObjRecordProductionPressure.pressure10 = Convert.ToDouble(txtPressure10.Text);
        //                        ObjRecordProductionPressure.pressure11 = Convert.ToDouble(txtPressure11.Text);
        //                        ObjRecordProductionPressure.coil10 = Convert.ToDouble(txtTension10.Text);
        //                        ObjRecordProductionPressure.coil11 = Convert.ToDouble(txtTension11.Text);

        //                        if (ObjRecordProductionPressure.saves("save"))
        //                        {
        //                            //Record Production PRS
        //                            ObjRecordProductionPrs.recproprsfkrecordproduction = clsRecordProduction.getLastSavedRecordProduction();
        //                            ObjRecordProductionPrs.recproprsfkproductionorder = objProductionOrder.codsec;
        //                            ObjRecordProductionPrs.prsroller1 = Convert.ToDouble(txtRoller1Speed.Text);
        //                            ObjRecordProductionPrs.prsroller2 = Convert.ToDouble(txtRoller2Speed.Text);
        //                            ObjRecordProductionPrs.prsroller3 = Convert.ToDouble(txtTreaterRoller1Speed.Text);
        //                            ObjRecordProductionPrs.prsroller4 = Convert.ToDouble(txtTreaterRoller2Speed.Text);
        //                            ObjRecordProductionPrs.prsroller5 = Convert.ToDouble(txtTreaterRoller5Speed.Text);
        //                            ObjRecordProductionPrs.prsamperage1 = Convert.ToDouble(txtAmperage1Prs.Text);
        //                            ObjRecordProductionPrs.prsamperage2 = Convert.ToDouble(txtAmperage2Prs.Text);
        //                            ObjRecordProductionPrs.prsamperage = Convert.ToDouble(txtAmperagePrs.Text);
        //                            ObjRecordProductionPrs.prsvelocity = Convert.ToDouble(txtSpeedPrs.Text);
        //                            ObjRecordProductionPrs.prstratador = Convert.ToDouble(txtTreaterPotency.Text);

        //                            if (ObjRecordProductionPrs.saves("save"))
        //                            {
        //                                //Record Production Satellite 1
        //                                ObjRecordProductionSatellite.recprosatfkrecordproduction = clsRecordProduction.getLastSavedRecordProduction();
        //                                ObjRecordProductionSatellite.recprosatfkproductionorder = objProductionOrder.codsec;
        //                                ObjRecordProductionSatellite.sat1z1 = Convert.ToDouble(txtZ1Satellite1.Text);
        //                                ObjRecordProductionSatellite.sat1z2 = Convert.ToDouble(txtZ2Satellite1.Text);
        //                                ObjRecordProductionSatellite.sat1z3 = Convert.ToDouble(txtZ3Satellite1.Text);
        //                                ObjRecordProductionSatellite.sat1z4 = Convert.ToDouble(txtZ4Satellite1.Text);
        //                                ObjRecordProductionSatellite.sat1z5 = Convert.ToDouble(txtZ5Satellite1.Text);
        //                                ObjRecordProductionSatellite.sat1filter = Convert.ToDouble(txtFilterSatellite1.Text);
        //                                ObjRecordProductionSatellite.sat1melt = Convert.ToDouble(txtMeltSatellite1.Text);
        //                                ObjRecordProductionSatellite.sat1beforefiter = Convert.ToDouble(txtPressureBeforeFilterSatellite1.Text);
        //                                ObjRecordProductionSatellite.sat1afterfilter = Convert.ToDouble(txtPressureAfterFilterSatellite1.Text);
        //                                ObjRecordProductionSatellite.sat1pressure = Convert.ToDouble(txtDiferencialPressureSatellite1.Text);
        //                                ObjRecordProductionSatellite.sat1rpm = Convert.ToDouble(txtRpmSatellite1.Text);
        //                                ObjRecordProductionSatellite.sat1amperage = Convert.ToDouble(txtAmperageSatellite1.Text);
        //                                ObjRecordProductionSatellite.sat1thickness = Convert.ToDouble(txtThicknessSatellite1.Text);

        //                                //Record Production Satellite 2
        //                                ObjRecordProductionSatellite.sat2z1 = Convert.ToDouble(txtZ1Satellite2.Text);
        //                                ObjRecordProductionSatellite.sat2z2 = Convert.ToDouble(txtZ2Satellite2.Text);
        //                                ObjRecordProductionSatellite.sat2z3 = Convert.ToDouble(txtZ3Satellite2.Text);
        //                                ObjRecordProductionSatellite.sat2z4 = Convert.ToDouble(txtZ4Satellite2.Text);
        //                                ObjRecordProductionSatellite.sat2z5 = Convert.ToDouble(txtZ5Satellite2.Text);
        //                                ObjRecordProductionSatellite.sat2filter = Convert.ToDouble(txtFilterSatellite2.Text);
        //                                ObjRecordProductionSatellite.sat2melt = Convert.ToDouble(txtMeltSatellite2.Text);
        //                                ObjRecordProductionSatellite.sat2beforefilter = Convert.ToDouble(txtPressureBeforeFilterSatellite2.Text);
        //                                ObjRecordProductionSatellite.sat2afterfilter = Convert.ToDouble(txtPressureAfterFilterSatellite2.Text);
        //                                ObjRecordProductionSatellite.sat2pressure = Convert.ToDouble(txtDiferencialPressureSatellite2.Text);
        //                                ObjRecordProductionSatellite.sat2rpm = Convert.ToDouble(txtRpmSatellite2.Text);
        //                                ObjRecordProductionSatellite.sat2amperage = Convert.ToDouble(txtAmperageSatellite2.Text);
        //                                ObjRecordProductionSatellite.sat2thickness = Convert.ToDouble(txtThicknessSatellite2.Text);

        //                                if (ObjRecordProductionSatellite.saves("save"))
        //                                {
        //                                    //Record Production TDO
        //                                    ObjRecordProductionTdo.recprotdofkrecordproduction = clsRecordProduction.getLastSavedRecordProduction();
        //                                    ObjRecordProductionTdo.recprotdofkproductionorder = objProductionOrder.codsec;
        //                                    ObjRecordProductionTdo.tdoz1 = Convert.ToDouble(txtZ1Tdo.Text);
        //                                    ObjRecordProductionTdo.tdoz2 = Convert.ToDouble(txtZ2Tdo.Text);
        //                                    ObjRecordProductionTdo.tdoz3 = Convert.ToDouble(txtZ3Tdo.Text);
        //                                    ObjRecordProductionTdo.tdoz4 = Convert.ToDouble(txtZ4Tdo.Text);
        //                                    ObjRecordProductionTdo.tdoz5 = Convert.ToDouble(txtZ5Tdo.Text);
        //                                    ObjRecordProductionTdo.tdoz6 = Convert.ToDouble(txtZ6Tdo.Text);
        //                                    ObjRecordProductionTdo.tdoz7 = Convert.ToDouble(txtZ7Tdo.Text);
        //                                    ObjRecordProductionTdo.tdoz8 = Convert.ToDouble(txtZ8Tdo.Text);
        //                                    ObjRecordProductionTdo.tdoz9 = Convert.ToDouble(txtZ9Tdo.Text);
        //                                    ObjRecordProductionTdo.tdovelocitystring = Convert.ToDouble(txtStringSpeed.Text);
        //                                    ObjRecordProductionTdo.tdoamperagestring = Convert.ToDouble(txtStringAmperage.Text);
        //                                    ObjRecordProductionTdo.tdolubrication1 = txtLubricationWithCycles.Text;
        //                                    ObjRecordProductionTdo.tdolubrication2 = txtLubricationNotCycles.Text;

        //                                    if (ObjRecordProductionTdo.saves("save"))
        //                                    {
        //                                        //Record Production Thickness
        //                                        ObjRecordProductionThickness.recprothifkrecordproduction = clsRecordProduction.getLastSavedRecordProduction();
        //                                        ObjRecordProductionThickness.recprothifkproductionorder = objProductionOrder.codsec;
        //                                        ObjRecordProductionThickness.crmdo = Convert.ToDouble(txtcrmdo1.Text);
        //                                        ObjRecordProductionThickness.mdo2tdo = Convert.ToDouble(txtmdo2tdo.Text);
        //                                        ObjRecordProductionThickness.tdoprs = Convert.ToDouble(txttdoprs.Text);
        //                                        ObjRecordProductionThickness.stretch = Convert.ToDouble(txtStretch.Text);
        //                                        ObjRecordProductionThickness.coefficientthickness = Convert.ToDouble(txtcoefficient.Text);
        //                                        ObjRecordProductionThickness.tolerancypositive = Convert.ToDouble(txttoleranceplus.Text);
        //                                        ObjRecordProductionThickness.tolerancynegative = Convert.ToDouble(txttolerancerest.Text);
        //                                        ObjRecordProductionThickness.notes = txtNotes.Text;

        //                                        if (ObjRecordProductionThickness.save("save"))
        //                                            MessageBox.Show("Record de Producción guardado correctamente", "Record de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                                        else
        //                                            MessageBox.Show("Error al guardar la sección Espesores", "Record de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                                    }
        //                                    else
        //                                        MessageBox.Show("Error al guardar la sección TDO", "Record de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                                }
        //                                else
        //                                    MessageBox.Show("Error al guardar la sección Satélites", "Record de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                            }
        //                            else
        //                                MessageBox.Show("Error al guardar la sección PRS", "Record de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                        }
        //                        else
        //                            MessageBox.Show("Error al guardar la sección Bobinadora", "Record de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                    }
        //                    else
        //                        MessageBox.Show("Error al guardar la sección MDO", "Record de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                }
        //                else
        //                    MessageBox.Show("Error al guardar la sección Laboratorio", "Record de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //            else
        //                MessageBox.Show("Error al guardar la sección Temperatura Dado o Cabezal", "Record de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        else
        //            MessageBox.Show("Error al guardar la sección Extrusor Principal", "Record de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else
        //        MessageBox.Show("Por favor revise todos los campos que están pintados de color ROJO, debe llenar todos los datos para poder guardar...", "Record de Producción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //}

        //private bool ValidateFormDMT()
        //{
        //    bool isValid = true;
        //    if (!clsValidation.validateField(ref txtZ1, ref lblZ1Label, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ2, ref lblZ2Label, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ3, ref lblZ3Label, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ4, ref lblZ4Label, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ5, ref lblZ5Label, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ6, ref lblZ6Label, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ7, ref lblZ7Label, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtBrida, ref lblBrida, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtMelt, ref lblMelt, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtFilter1, ref lblFilter1, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtFilter2, ref lblFilter2, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtMelt1, ref lblMelt1, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtDiverter, ref lblDiverter, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtFilterBeforePressure, ref lblFilterBeforePressure, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtFilterAfterPressure, ref lblFilterAfterPressure, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtDeferencialPressure, ref lblDeferencialPressure, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtRpmMain, ref lblRpmMain, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtAmperage, ref lblAmperage, "notEmpty")) isValid = false;
        //    //Satellite 1
        //    if (!clsValidation.validateField(ref txtZ1Satellite1, ref lblZ1Satellite1Label, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ2Satellite1, ref lblZ2Satellite1Label, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ3Satellite1, ref lblZ3Satellite1Label, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ4Satellite1, ref lblZ4Satellite1Label, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ5Satellite1, ref lblZ5Satellite1Label, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtFilterSatellite1, ref lblFilterSatellite1Label, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtMeltSatellite1, ref lblMeltSatellite1Label, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtPressureBeforeFilterSatellite1, ref lblPressureBeforeFilterSatellite1, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtPressureAfterFilterSatellite1, ref lblPressureAfterFilterSatellite1, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtDiferencialPressureSatellite1, ref lblDiferencialPressureSatellite1, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtRpmSatellite1, ref lblRpmSatellite1, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtAmperageSatellite1, ref lblAmperageSatellite1, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtThicknessSatellite1, ref lblThicknessSatellite1, "notEmpty")) isValid = false;
        //    //Satellite 2
        //    if (!clsValidation.validateField(ref txtZ1Satellite2, ref lblZ1Satellite2Label, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ2Satellite2, ref lblZ2Satellite2Label, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ3Satellite2, ref lblZ3Satellite2Label, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ4Satellite2, ref lblZ4Satellite2Label, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ5Satellite2, ref lblZ5Satellite2Label, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtFilterSatellite2, ref lblFilterSatellite2Label, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtMeltSatellite2, ref lblMeltSatellite2Label, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtPressureBeforeFilterSatellite2, ref lblPressureBeforeFilterSatellite2, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtPressureAfterFilterSatellite2, ref lblPressureAfterFilterSatellite2, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtDiferencialPressureSatellite2, ref lblDiferencialPressureSatellite2, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtRpmSatellite2, ref lblRpmSatellite2, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtAmperageSatellite2, ref lblAmperageSatellite2, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtThicknessSatellite2, ref lblThicknessSatellite2, "notEmpty")) isValid = false;
        //    //Head
        //    if (!clsValidation.validateField(ref txtZ1Head, ref lblZ1Head, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ2Head, ref lblZ2Head, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ3Head, ref lblZ3Head, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ4Head, ref lblZ4Head, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ5Head, ref lblZ5Head, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtCylinder, ref lblCylinder, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtCylinderVal, ref lblCylinderVal, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtCylinderRpm, ref lblCylinderRpm, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtCylinderAmperage, ref lblCylinderAmperage, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtAmperageWidth, ref lblAmperageWidth, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtPression, ref label1, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtAmperageHeigth, ref lblAmperageHeigth, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtAmperageCR, ref lblAmperageCR, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtAmperageMDO, ref lblAmperageMDO, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtAmperageTemp, ref lblAmperageTemp, "notEmpty")) isValid = false;
        //    //MDO
        //    if (!clsValidation.validateField(ref txtCirPrin, ref lblCirPrinLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ1Mdo, ref lblZ1MdoLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ2Mdo, ref lblZ2MdoLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ3Mdo, ref lblZ3MdoLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ4Mdo, ref lblZ4MdoLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtEst1Mdo, ref lblEst1MdoLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtEst2Mdo, ref lblEst2MdoLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtEstabMdo, ref lblEstabMdoLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtFixation1Mdo, ref lblFixation1Mdo, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtFixation2Mdo, ref lblFixation2Mdo, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtSpeedMdo1, ref lblSpeedMdo1, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtSpeedMdo2, ref lblSpeedMdo2, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtAmperageMdo1, ref lblAmperageMdo1, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtAmperageMdo2, ref lblAmperageMdo2, "notEmpty")) isValid = false;

        //    //TDO
        //    if (!clsValidation.validateField(ref txtZ1Tdo, ref lblZ1Tdo, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ2Tdo, ref lblZ2Tdo, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ3Tdo, ref lblZ3Tdo, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ4Tdo, ref lblZ4Tdo, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ5Tdo, ref lblZ5Tdo, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ6Tdo, ref lblZ6Tdo, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ7Tdo, ref lblZ7Tdo, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ8Tdo, ref lblZ8Tdo, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ9Tdo, ref lblZ9Tdo, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtStringSpeed, ref lblStringSpeed, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtStringAmperage, ref lblStringAmperage, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtLubricationNotCycles, ref lblLubricationNotCycles, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtLubricationWithCycles, ref lblLubricationWithCycles, "notEmpty")) isValid = false;
        //    //PRS
        //    if (!clsValidation.validateField(ref txtRoller1Speed, ref lblRoller1Speed, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtRoller2Speed, ref lblRoller2Speed, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtTreaterRoller1Speed, ref lblTreaterRoller1Speed, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtTreaterRoller2Speed, ref lblTreaterRoller1Speed, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtTreaterRoller5Speed, ref label4, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtAmperage1Prs, ref lblAmperage1Prs, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtAmperage2Prs, ref lblAmperage2Prs, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtSpeedPrs, ref lblSpeedPrs, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtAmperagePrs, ref lblAmperagePrs, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtTreaterPotency, ref lblTreaterPotency, "notEmpty")) isValid = false;
        //    //RE-COIL
        //    if (!clsValidation.validateField(ref txtTension1, ref lblTension1, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtTension2, ref lblTension2, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtTension3, ref lblTension3, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtTension4, ref lblTension4, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtTension5, ref lblTension5, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtTension6, ref lblTension6, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtTension7, ref lblTension7, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtTension8, ref lblTension8, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtTension9, ref lblTension9, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtTension10, ref label25, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtTension11, ref label26, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtPressure1, ref lblPressure1, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtPressure2, ref lblPressure2, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtPressure3, ref lblPressure3, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtPressure4, ref lblPressure4, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtPressure5, ref lblPressure5, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtPressure6, ref lblPressure6, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtPressure7, ref lblPressure7, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtPressure8, ref lblPressure8, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtPressure9, ref lblPressure9, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtPressure10, ref label27, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtPressure11, ref label28, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtCutTension, ref lblCutTension, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtChangeTension, ref lblChangeTension, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtThicknessCoil, ref lblThicknessCoil, "notEmpty")) isValid = false;
        //    //THICKNESS
        //    if (!clsValidation.validateField(ref txtcrmdo1, ref lblcrmdo1, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtmdo2tdo, ref lblmdo2tdo, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txttdoprs, ref lbltdoprs, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtcoefficient, ref lblCoefficient, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtStretch, ref lblStretch, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txttoleranceplus, ref lbltoleranceplus, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txttolerancerest, ref lbltolerancerest, "notEmpty")) isValid = false;
        //    return isValid;
        //}

        //private void btnSaveRecordProductionMW_Click(object sender, EventArgs e)
        //{
        //    clsRecordProductionMw ObjRecordProductionMw = new clsRecordProductionMw();
        //    clsRecordProductionHeadMw ObjRecordProductionHeadMw = new clsRecordProductionHeadMw();
        //    clsRecordProductionLaboratoryMw ObjRecordProductionLaboratoryMw = new clsRecordProductionLaboratoryMw();
        //    clsRecordProductionMdoMw ObjRecordProductionMdoMw = new clsRecordProductionMdoMw();
        //    clsRecordProductionCoil ObjRecordProductionCoil = new clsRecordProductionCoil();
        //    clsRecordProductionPrsMw ObjRecordProductionPrsMw = new clsRecordProductionPrsMw();
        //    clsRecordProductionSatelliteMw ObjRecordProductionSatelliteMw = new clsRecordProductionSatelliteMw();
        //    clsRecordProductionTdoMw ObjRecordProductionTdoMw = new clsRecordProductionTdoMw();
        //    clsRecordProductionThicknessMw ObjRecordProductionThicknessMw = new clsRecordProductionThicknessMw();

        //    if (ValidateFormMW())
        //    {
        //        //Record Production
        //        ObjRecordProductionMw.fkproductionorder = objProductionOrder.codsec;
        //        ObjRecordProductionMw.type = objProductionOrderDetail.BoppCode.ToString().Replace("-", "");
        //        ObjRecordProductionMw.thickness = ObjBopp.Thickness.value.ToString();
        //        ObjRecordProductionMw.temperaturemainz1mw = Convert.ToDouble(txtZ1MW.Text);
        //        ObjRecordProductionMw.temperaturemainz2mw = Convert.ToDouble(txtZ2MW.Text);
        //        ObjRecordProductionMw.temperaturemainz3mw = Convert.ToDouble(txtZ3MW.Text);
        //        ObjRecordProductionMw.temperaturemainz4mw = Convert.ToDouble(txtZ4MW.Text);
        //        ObjRecordProductionMw.temperaturemainz5mw = Convert.ToDouble(txtZ5MW.Text);
        //        ObjRecordProductionMw.temperaturemainz6mw = Convert.ToDouble(txtZ6MW.Text);
        //        ObjRecordProductionMw.temperaturemainfiltermw = Convert.ToDouble(txtFilterMW.Text);
        //        ObjRecordProductionMw.pressurefiltermw = Convert.ToDouble(txtPressureFilterMW.Text);
        //        ObjRecordProductionMw.pressurecapacity = Convert.ToDouble(txtCapacityMW.Text);
        //        ObjRecordProductionMw.amperagemainmw = Convert.ToDouble(txtAmperageMW.Text);
        //        ObjRecordProductionMw.diverte = Convert.ToDouble(textBox2.Text);
        //        ObjRecordProductionMw.note = txtNote.Text;
        //        ObjRecordProductionMw.lotnumber = label9.Text;

        //        if (ObjRecordProductionMw.saves())
        //        {
        //            //Record Production Head
        //            ObjRecordProductionHeadMw.recproheamwfkrecordproduction = clsRecordProductionMw.getLastSavedRecordProduction();
        //            ObjRecordProductionHeadMw.recproheamwfkproductionorder = objProductionOrder.codsec;
        //            ObjRecordProductionHeadMw.headmwz1 = Convert.ToDouble(txtHeadZ1MW.Text);
        //            ObjRecordProductionHeadMw.headmwz2 = Convert.ToDouble(txtHeadZ2MW.Text);
        //            ObjRecordProductionHeadMw.headmwz3 = Convert.ToDouble(txtHeadZ3MW.Text);
        //            ObjRecordProductionHeadMw.headmwz4 = Convert.ToDouble(txtHeadZ4MW.Text);
        //            ObjRecordProductionHeadMw.headmwz5 = Convert.ToDouble(txtHeadZ5MW.Text);
        //            ObjRecordProductionHeadMw.headmwangle = Convert.ToDouble(txtWidthMw.Text);
        //            ObjRecordProductionHeadMw.headmwcr = Convert.ToDouble(txtEndWidthCrMW.Text);
        //            ObjRecordProductionHeadMw.headmwheight = Convert.ToDouble(txtHeigthMw.Text);
        //            ObjRecordProductionHeadMw.headmwmdo = Convert.ToDouble(txtEndWidthMdoMW.Text);
        //            ObjRecordProductionHeadMw.headmwtemp = txtTempMw.Text;
        //            ObjRecordProductionHeadMw.headmwtemperatureamperage = Convert.ToDouble(txtAmperageHeadMw.Text);
        //            ObjRecordProductionHeadMw.headmwtemperaturecylinder = Convert.ToDouble(txtCilynderHeadMw.Text);
        //            ObjRecordProductionHeadMw.headmwtemperaturemp = Convert.ToDouble(txtRpmHeadMw.Text);
        //            ObjRecordProductionHeadMw.headmwtemperaturetub = Convert.ToDouble(txtTubHeadMw.Text);
        //            ObjRecordProductionHeadMw.tractor = Convert.ToDouble(textBox1.Text);
        //            ObjRecordProductionHeadMw.pression = Convert.ToDouble(textBox3.Text);

        //            if (ObjRecordProductionHeadMw.saves("save"))
        //            {
        //                //Record Production Laboratory
        //                ObjRecordProductionLaboratoryMw.recprolabmwfkrecordproduction = clsRecordProductionMw.getLastSavedRecordProduction();
        //                ObjRecordProductionLaboratoryMw.recprolabmwfkproductionorder = objProductionOrder.codsec;
        //                ObjRecordProductionLaboratoryMw.sealcntmw = txtSealPowerMwCnt.Text;
        //                ObjRecordProductionLaboratoryMw.glowcntmw = txtBrigthnessMwCnt.Text;
        //                ObjRecordProductionLaboratoryMw.coefficientcntmw = txtCoefficientMwCnt.Text;
        //                ObjRecordProductionLaboratoryMw.sealmw = txtSealPowerMwCt.Text;
        //                ObjRecordProductionLaboratoryMw.glowmw = txtBrigthnessMwCt.Text;
        //                ObjRecordProductionLaboratoryMw.coefficientcntmw = txtCoefficientMwCt.Text;
        //                ObjRecordProductionLaboratoryMw.superficialmw = txtSuperficyalTensionMw.Text;
        //                ObjRecordProductionLaboratoryMw.superficialmw = txtSuperficyalTensionMw.Text;

        //                if (ObjRecordProductionLaboratoryMw.saves("save"))
        //                {
        //                    //Record Production MDO
        //                    ObjRecordProductionMdoMw.recpromdomwfkrecordproduction = clsRecordProductionMw.getLastSavedRecordProduction();
        //                    ObjRecordProductionMdoMw.recpromdomwfkproductionorder = objProductionOrder.codsec;
        //                    ObjRecordProductionMdoMw.mdoz1 = Convert.ToInt32(txtMdoZ1MW.Text);
        //                    ObjRecordProductionMdoMw.mdoz2 = Convert.ToInt32(txtMdoZ2MW.Text);
        //                    ObjRecordProductionMdoMw.mdoz3 = Convert.ToInt32(txtMdoZ3MW.Text);
        //                    ObjRecordProductionMdoMw.mdoz4 = Convert.ToInt32(txtMdoZ4MW.Text);
        //                    ObjRecordProductionMdoMw.mdoz5 = Convert.ToInt32(txtMdoZ5MW.Text);
        //                    ObjRecordProductionMdoMw.mdoz6 = Convert.ToInt32(txtMdoZ6MW.Text);
        //                    ObjRecordProductionMdoMw.mdoz7 = Convert.ToInt32(txtMdoZ7MW.Text);
        //                    ObjRecordProductionMdoMw.mdoSpeedphsl = Convert.ToDouble(txtSpeedPhsl.Text);
        //                    ObjRecordProductionMdoMw.mdoamperagephsl = Convert.ToDouble(txtAmperagePhsl.Text);
        //                    ObjRecordProductionMdoMw.mdospeedfd1 = Convert.ToDouble(txtSpeedFd1.Text);
        //                    ObjRecordProductionMdoMw.mdoamperagefd1 = Convert.ToDouble(txtAmperageFd1.Text);
        //                    ObjRecordProductionMdoMw.mdospeedfd2 = Convert.ToDouble(txtSpeedFd2.Text);
        //                    ObjRecordProductionMdoMw.mdoamperagefd2 = Convert.ToDouble(txtAmperageFd2.Text);

        //                    if (ObjRecordProductionMdoMw.saves("save"))
        //                    {
        //                        //Record Production Coil
        //                        ObjRecordProductionCoil.recprocoifkrecordproduction = clsRecordProductionMw.getLastSavedRecordProduction();
        //                        ObjRecordProductionCoil.recprocoifkproductionorder = objProductionOrder.codsec;
        //                        ObjRecordProductionCoil.Tension1 = Convert.ToDouble(txtTensionMwCoil1.Text);
        //                        ObjRecordProductionCoil.Taper1 = Convert.ToDouble(txtTaperMwCoil1.Text);
        //                        ObjRecordProductionCoil.Tension2 = Convert.ToDouble(txtTensionMwCoil2.Text);
        //                        ObjRecordProductionCoil.Taper2 = Convert.ToDouble(txtTaperMwCoil2.Text);
        //                        ObjRecordProductionCoil.coil = Convert.ToDouble(textBox11.Text);

        //                        if (ObjRecordProductionCoil.saves("save"))
        //                        {
        //                            //Record Production PRS
        //                            ObjRecordProductionPrsMw.recproprsmwfkrecordproduction = clsRecordProductionMw.getLastSavedRecordProduction();
        //                            ObjRecordProductionPrsMw.recproprsmwfkproductionorder = objProductionOrder.codsec;
        //                            ObjRecordProductionPrsMw.prsrmwollerguide = Convert.ToDouble(txtRollerGideMw.Text);
        //                            ObjRecordProductionPrsMw.prsmwrollerblade = Convert.ToDouble(txtRollerBladeMw.Text);
        //                            ObjRecordProductionPrsMw.prsmwrollertreater = Convert.ToDouble(txtRollerTreaterMw.Text);
        //                            ObjRecordProductionPrsMw.prsmwrollertreater2 = Convert.ToDouble(txtRollerTreater2Mw.Text);
        //                            ObjRecordProductionPrsMw.prsmwbridge = Convert.ToDouble(txtRollerBridgeMw.Text);
        //                            ObjRecordProductionPrsMw.prsmwspeed = Convert.ToDouble(txtSpeedPrsMw.Text);
        //                            ObjRecordProductionPrsMw.prsmwamperage = Convert.ToDouble(txtAmperagePrsMw.Text);
        //                            ObjRecordProductionPrsMw.prsmwpowertreater = Convert.ToDouble(txtTreaterPowerMw.Text);
        //                            ObjRecordProductionPrsMw.amp1 = Convert.ToDouble(textBox8.Text);
        //                            ObjRecordProductionPrsMw.amp2 = Convert.ToDouble(textBox13.Text);
        //                            ObjRecordProductionPrsMw.amp3 = Convert.ToDouble(textBox12.Text);
        //                            ObjRecordProductionPrsMw.amp4 = Convert.ToDouble(textBox10.Text);
        //                            ObjRecordProductionPrsMw.amp5 = Convert.ToDouble(textBox9.Text);
        //                            ObjRecordProductionPrsMw.amp6 = Convert.ToDouble(textBox14.Text);

        //                            if (ObjRecordProductionPrsMw.saves("save"))
        //                            {
        //                                //Record Production Satellite 1
        //                                ObjRecordProductionSatelliteMw.recprosatmwfkrecordproduction = clsRecordProductionMw.getLastSavedRecordProduction();
        //                                ObjRecordProductionSatelliteMw.recprosatmwfkproductionorder = objProductionOrder.codsec;
        //                                ObjRecordProductionSatelliteMw.sat25z1 = Convert.ToDouble(txtZ1MWSat25.Text);
        //                                ObjRecordProductionSatelliteMw.sat25z2 = Convert.ToDouble(txtZ2MWSat25.Text);
        //                                ObjRecordProductionSatelliteMw.sat25z3 = Convert.ToDouble(txtZ3MWSat25.Text);
        //                                ObjRecordProductionSatelliteMw.sat25z4 = Convert.ToDouble(txtZ4MWSat25.Text);
        //                                ObjRecordProductionSatelliteMw.sat25filter = Convert.ToDouble(txtFilterMWSat25.Text);
        //                                ObjRecordProductionSatelliteMw.sat25mp = Convert.ToDouble(txtMpMWSat25.Text);
        //                                ObjRecordProductionSatelliteMw.sat25amperage = Convert.ToDouble(txtAmperageMWSat25.Text);
        //                                ObjRecordProductionSatelliteMw.sat25pressurefilter = Convert.ToDouble(txtFilterPressureMWSat25.Text);
        //                                ObjRecordProductionSatelliteMw.sat25capacity = Convert.ToDouble(txtCapacityMWSat25.Text);
        //                                ObjRecordProductionSatelliteMw.sat25thickness = Convert.ToDouble(txtThickessMWSat25.Text);

        //                                //Record Production Satellite 2
        //                                ObjRecordProductionSatelliteMw.sat2z1 = Convert.ToDouble(txtSatellite2Z1MW.Text);
        //                                ObjRecordProductionSatelliteMw.sat2z2 = Convert.ToDouble(txtSatellite2Z2MW.Text);
        //                                ObjRecordProductionSatelliteMw.sat2z3 = Convert.ToDouble(txtSatellite2Z3MW.Text);
        //                                ObjRecordProductionSatelliteMw.sat2z4 = Convert.ToDouble(txtSatellite2Z4MW.Text);
        //                                ObjRecordProductionSatelliteMw.sat2filter = Convert.ToDouble(txtSatellite2FilterMW.Text);
        //                                ObjRecordProductionSatelliteMw.sat2mp = Convert.ToDouble(txtSatellite2mpMW.Text);
        //                                ObjRecordProductionSatelliteMw.sat2amperage = Convert.ToDouble(txtAmperageMWSat2.Text);
        //                                ObjRecordProductionSatelliteMw.sat2pressurefilter = Convert.ToDouble(txtFilterPressureMWSat2.Text);
        //                                ObjRecordProductionSatelliteMw.sat2capacity = Convert.ToDouble(txtCapacityMWSat2.Text);
        //                                ObjRecordProductionSatelliteMw.sat2thickness = Convert.ToDouble(txtThickessMWSat2.Text);

        //                                if (ObjRecordProductionSatelliteMw.saves("save"))
        //                                {
        //                                    //Record Production TDO
        //                                    ObjRecordProductionTdoMw.recprotdomwfkrecordproduction = clsRecordProductionMw.getLastSavedRecordProduction();
        //                                    ObjRecordProductionTdoMw.recprotdomwfkproductionorder = objProductionOrder.codsec;
        //                                    ObjRecordProductionTdoMw.tdomwz1 = Convert.ToDouble(txtTdoZ1MW.Text);
        //                                    ObjRecordProductionTdoMw.tdomwz2 = Convert.ToDouble(txtTdoZ2MW.Text);
        //                                    ObjRecordProductionTdoMw.tdomwz3 = Convert.ToDouble(txtTdoZ3MW.Text);
        //                                    ObjRecordProductionTdoMw.tdomwz4 = Convert.ToDouble(txtTdoZ4MW.Text);
        //                                    ObjRecordProductionTdoMw.tdomwz5 = Convert.ToDouble(txtTdoZ5MW.Text);
        //                                    ObjRecordProductionTdoMw.tdomwz6 = Convert.ToDouble(txtTdoZ6MW.Text);
        //                                    ObjRecordProductionTdoMw.tdomwvelocitystring = Convert.ToDouble(txtStringSpeedMw.Text);
        //                                    ObjRecordProductionTdoMw.tdomwamperagestring = Convert.ToDouble(txtStringAmperageMW.Text);
        //                                    ObjRecordProductionTdoMw.tdotimwlubrication = Convert.ToDouble(txtLubricationTimeMw.Text);
        //                                    ObjRecordProductionTdoMw.tdountimelubrication = Convert.ToDouble(txtLubricationUnTimeMw.Text);
        //                                    ObjRecordProductionTdoMw.var1 = Convert.ToDouble(textBox4.Text);
        //                                    ObjRecordProductionTdoMw.var2 = Convert.ToDouble(textBox5.Text);
        //                                    ObjRecordProductionTdoMw.var3 = Convert.ToDouble(textBox7.Text);
        //                                    ObjRecordProductionTdoMw.var4 = Convert.ToDouble(textBox6.Text);

        //                                    if (ObjRecordProductionTdoMw.saves("save"))
        //                                    {
        //                                        //Record Production Thickness
        //                                        ObjRecordProductionThicknessMw.recprothimwfkrecordproduction = clsRecordProductionMw.getLastSavedRecordProduction();
        //                                        ObjRecordProductionThicknessMw.recprothimwfkproductionorder = objProductionOrder.codsec;
        //                                        ObjRecordProductionThicknessMw.preheatcasting = Convert.ToDouble(txtPreHeadMw.Text);
        //                                        ObjRecordProductionThicknessMw.fd1fd2 = Convert.ToDouble(txtFd1Fd2Mw.Text);
        //                                        ObjRecordProductionThicknessMw.fd2tdo = Convert.ToDouble(txtFd2TdoMw.Text);
        //                                        ObjRecordProductionThicknessMw.stretchmw = Convert.ToDouble(txtStretchMw.Text);
        //                                        ObjRecordProductionThicknessMw.coefficientthicknessmw = Convert.ToDouble(txtCoefficientMw.Text);
        //                                        ObjRecordProductionThicknessMw.tolerancypositivemw = Convert.ToDouble(txtTolerancyPositiveMw.Text);
        //                                        ObjRecordProductionThicknessMw.tolerancynegativemw = Convert.ToDouble(txtTolerancyNegativeMw.Text);

        //                                        if (ObjRecordProductionThicknessMw.save("save"))
        //                                            MessageBox.Show("Record de Producción guardado correctamente", "Record de Producción", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                                        else
        //                                            MessageBox.Show("Error al guardar la sección Espesores.. Por favor revise que los datos ingresados sean correctos", "Record de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                                    }
        //                                    else
        //                                        MessageBox.Show("Error al guardar la sección TDO.. Por favor revise que los datos ingresados sean correctos", "Record de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                                }
        //                                else
        //                                    MessageBox.Show("Error al guardar la sección Satelites.. Por favor revise que los datos ingresados sean correctos", "Record de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                            }
        //                            else
        //                                MessageBox.Show("Error al guardar la sección PRS.. Por favor revise que los datos ingresados sean correctos", "Record de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                        }
        //                        else
        //                            MessageBox.Show("Error al guardar la sección Bobinadora.. Por favor revise que los datos ingresados sean correctos", "Record de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                    }
        //                    else
        //                        MessageBox.Show("Error al guardar la sección MDO.. Por favor revise que los datos ingresados sean correctos", "Record de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                }
        //                else
        //                    MessageBox.Show("Error al guardar la sección laboratorio.. Por favor revise que los datos ingresados sean correctos", "Record de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //            else
        //                MessageBox.Show("Error al guardar la sección Extrusor Principal.. Por favor revise que los datos ingresados sean correctos", "Record de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //        else
        //            MessageBox.Show("Error al guardar la sección Extrusor Principal.. Por favor revise que los datos ingresados sean correctos", "Record de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else
        //        MessageBox.Show("Por favor revise todos los campos que están pintados de color ROJO, debe llenar todos los datos para poder guardar...", "Record de Producción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //}

        //private bool ValidateFormMW()
        //{
        //    bool isValid = true;
        //    if (!clsValidation.validateField(ref txtZ1MW, ref lblExtrusorZ1, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ2MW, ref lblExtrusorZ2, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ3MW, ref lblExtrusorZ3, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ4MW, ref lblExtrusorZ4, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ5MW, ref lblExtrusorZ5, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ6MW, ref lblExtrusorZ6, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref textBox2, ref label12, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtFilterMW, ref lblExtrusorFilter, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtPressureFilterMW, ref lblPressionFilterMWLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtCapacityMW, ref lblCapacityMWLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtAmperageMW, ref lblAmperageMWLabel, "notEmpty")) isValid = false;
        //    //Satellite 1
        //    if (!clsValidation.validateField(ref txtZ1MWSat25, ref lblSatellite25Z1MWLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ2MWSat25, ref lblSatellite25Z2MWLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ3MWSat25, ref lblSatellite25Z3MWLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtZ4MWSat25, ref lblSatellite25Z4MWLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtFilterMWSat25, ref lblSatellite25FilterMWLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtMpMWSat25, ref lblSatellite25mpMWLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtAmperageMWSat25, ref lblAmperageMWSat25, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtFilterPressureMWSat25, ref lblFilterPressureMWSat25, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtCapacityMWSat25, ref lblCapacityMWSat25, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtThickessMWSat25, ref lblThickessMWSat25, "notEmpty")) isValid = false;
        //    //Satellite 2
        //    if (!clsValidation.validateField(ref txtSatellite2Z1MW, ref lblSatellite2Z1MWLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtSatellite2Z2MW, ref lblSatellite2Z2MWLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtSatellite2Z3MW, ref lblSatellite2Z3MWLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtSatellite2Z4MW, ref lblSatellite2Z4MWLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtSatellite2FilterMW, ref lblSatellite2FilterMWLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtSatellite2mpMW, ref lblSatellite2mpMWLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtAmperageMWSat2, ref lblAmperageMWSat2, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtFilterPressureMWSat2, ref lblFilterPressureMWSat2, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtCapacityMWSat2, ref lblCapacityMWSat2, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtThickessMWSat2, ref lblThickessMWSat2, "notEmpty")) isValid = false;
        //    //Head
        //    if (!clsValidation.validateField(ref txtHeadZ1MW, ref lblHeadZ1MWLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtHeadZ2MW, ref lblHeadZ2MWLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtHeadZ3MW, ref lblHeadZ3MWLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtHeadZ4MW, ref lblHeadZ4MWLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtHeadZ5MW, ref lblHeadZ5MWLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtWidthMw, ref lblWidthMwLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtEndWidthCrMW, ref lblEndWidthCrMWLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtHeigthMw, ref lblHeigthMwLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtEndWidthMdoMW, ref lblEndWidthMdoMWLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtAmperageHeadMw, ref lblAmperageHeadMwLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtCilynderHeadMw, ref lblCilynderHeadMwLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtRpmHeadMw, ref lblRpmHeadMwLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtTubHeadMw, ref lblTubHeadMwLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtTempMw, ref lblTempMwLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref textBox1, ref label1, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref textBox3, ref label13, "notEmpty")) isValid = false;
        //    //MDO
        //    if (!clsValidation.validateField(ref txtMdoZ1MW, ref lblMdoZ1MWLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtMdoZ2MW, ref lblMdoZ2MWLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtMdoZ3MW, ref lblMdoZ3MWLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtMdoZ4MW, ref lblMdoZ4MWLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtMdoZ5MW, ref lblMdoZ5MWLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtMdoZ6MW, ref lblMdoZ6MWLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtMdoZ7MW, ref lblMdoZ7MWLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtSpeedPhsl, ref lblSpeedPhslLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtAmperagePhsl, ref lblAmperagePhslLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtSpeedFd1, ref lblSpeedFd1Label, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtAmperageFd1, ref lblAmperageFd1Label, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtSpeedFd2, ref lblSpeedFd2Label, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtAmperageFd2, ref lblAmperageFd2Label, "notEmpty")) isValid = false;
        //    //TDO
        //    if (!clsValidation.validateField(ref txtTdoZ1MW, ref lblTdoZ1MWLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtTdoZ2MW, ref lblTdoZ2MWLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtTdoZ3MW, ref lblTdoZ3MWLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtTdoZ4MW, ref lblTdoZ4MWLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtTdoZ5MW, ref lblTdoZ5MWLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtTdoZ6MW, ref lblTdoZ6MWLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtStringSpeedMw, ref lblStringSpeedMwLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtStringAmperageMW, ref lblStringAmperageMwLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtLubricationTimeMw, ref lblLubricationTimeMwLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtLubricationUnTimeMw, ref lblLubricationUnTimeMwLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref textBox4, ref label14, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref textBox5, ref label15, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref textBox7, ref label17, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref textBox6, ref label16, "notEmpty")) isValid = false;
        //    //PRS
        //    if (!clsValidation.validateField(ref txtRollerGideMw, ref lblRollerGideMwLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtRollerBladeMw, ref lblRollerBladeMwLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtRollerTreaterMw, ref lblRollerTreaterMwLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtRollerTreater2Mw, ref lblRollerTreater2MwLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtRollerBridgeMw, ref lblRollerBridgeMwLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtSpeedPrsMw, ref lblSpeedPrsMwLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtAmperagePrsMw, ref lblAmperagePrsMwLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtTreaterPowerMw, ref lblTreaterPowerMwLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref textBox8, ref label18, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref textBox13, ref label23, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref textBox12, ref label21, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref textBox10, ref label22, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref textBox9, ref label19, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref textBox14, ref label24, "notEmpty")) isValid = false;
        //    //COIL
        //    if (!clsValidation.validateField(ref txtTensionMwCoil1, ref lblTensionMwCoil1Label, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtTaperMwCoil1, ref lblTaperMwCoil1Label, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtTensionMwCoil2, ref lblTensionMwCoil2Label, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtTaperMwCoil2, ref lblTaperMwCoil2Label, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref textBox11, ref label20, "notEmpty")) isValid = false;
        //    //THICKNESS
        //    if (!clsValidation.validateField(ref txtPreHeadMw, ref lblPreHeadMwLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtFd1Fd2Mw, ref lblFd1Fd2Mwlabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtFd2TdoMw, ref lblFd2TdoMwlabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtStretchMw, ref lblStretchMwLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtCoefficientMw, ref lblCoefficientMwLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtTolerancyPositiveMw, ref lblTolerancyPositiveMwLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtTolerancyNegativeMw, ref lblTolerancyNegativeMwLabel, "notEmpty")) isValid = false;
        //    //LABORATORY
        //    if (!clsValidation.validateField(ref txtSealPowerMwCnt, ref lblSealForeceMw, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtBrigthnessMwCnt, ref lblBrigthnessCTMwLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtCoefficientMwCnt, ref lblCoefficientMwLabels, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtSealPowerMwCt, ref lblSealForeceMw, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtBrigthnessMwCt, ref lblBrigthnessCTMwLabel, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtCoefficientMwCt, ref lblCoefficientMwLabels, "notEmpty")) isValid = false;
        //    if (!clsValidation.validateField(ref txtSuperficyalTensionMw, ref lblSuperficyalTensionMwLabel, "notEmpty")) isValid = false;
        //    return isValid;
        //}

        //private void btnReportRecordProductionMW_Click(object sender, EventArgs e)
        //{
        //    clsRecordProductionMw ObjRecordProductionMw = new clsRecordProductionMw(objProductionOrder.codsec);
        //    if (ObjRecordProductionMw.recpromwcodsec > 0)
        //    {
        //        frmRecordProductionMwView winRecordProductionReport = new frmRecordProductionMwView(ObjRecordProductionMw.recpromwcodsec);
        //        winRecordProductionReport.StartPosition = FormStartPosition.CenterScreen;
        //        winRecordProductionReport.WindowState = FormWindowState.Maximized;
        //        winRecordProductionReport.MdiParent = this.MdiParent;
        //        winRecordProductionReport.Show();
        //    }
        //    else
        //        MessageBox.Show("No existen datos para generar el Reporte.", "Record de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}

        //private void txtZ1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ3_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;

        //}

        //private void txtZ4_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ5_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ6_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ7_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtBrida_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtMelt_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtFilter1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtFilter2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtMelt1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtDiverter_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtFilterBeforePressure_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtFilterAfterPressure_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtDeferencialPressure_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtRpmMain_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtAmperage_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ1Satellite1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ2Satellite1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ3Satellite1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ4Satellite1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ5Satellite1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtFilterSatellite1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtMeltSatellite1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ1Satellite2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ2Satellite2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ3Satellite2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ4Satellite2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ5Satellite2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtFilterSatellite2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtMeltSatellite2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtPressureBeforeFilterSatellite2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtPressureAfterFilterSatellite2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtDiferencialPressureSatellite2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtRpmSatellite2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtAmperageSatellite2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtThicknessSatellite2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ1Head_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ2Head_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;

        //}

        //private void txtZ3Head_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ4Head_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ5Head_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtCylinder_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtCylinderVal_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtCylinderRpm_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtCylinderAmperage_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtAmperageWidth_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtAmperageHeigth_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtAmperageCR_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtAmperageMDO_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtCirPrin_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ1Mdo_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ2Mdo_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ3Mdo_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ4Mdo_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtEst1Mdo_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtEst2Mdo_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtEstabMdo_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtFixation1Mdo_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtFixation2Mdo_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtSpeedMdo1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtAmperageMdo1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtSpeedMdo2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;

        //}

        //private void txtAmperageMdo2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ1Tdo_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ2Tdo_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ3Tdo_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ4Tdo_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ5Tdo_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ6Tdo_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ7Tdo_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ8Tdo_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ9Tdo_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtStringSpeed_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtStringAmperage_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtRoller1Speed_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtRoller2Speed_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtTreaterRoller1Speed_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtTreaterRoller2Speed_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtAmperage1Prs_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtAmperage2Prs_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtSpeedPrs_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtAmperagePrs_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtTreaterPotency_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtTension1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtTension2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtTension3_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtTension4_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtTension5_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtTension6_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtTension7_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtTension8_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtTension9_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtPressure1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtPressure2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtPressure3_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtPressure4_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtPressure5_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtPressure6_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtPressure7_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtPressure8_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtPressure9_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtCutTension_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtChangeTension_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtThicknessCoil_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtcrmdo1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txttdoprs_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtcoefficient_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtStretch_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txttoleranceplus_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txttolerancerest_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ1MW_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ2MW_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ3MW_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ4MW_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ5MW_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ6MW_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtFilterMW_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtPressureFilterMW_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtCapacityMW_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;

        //}

        //private void txtAmperageMW_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ1MWSat25_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ2MWSat25_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ3MWSat25_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtZ4MWSat25_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtFilterMWSat25_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtMpMWSat25_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;

        //}

        //private void txtAmperageMWSat25_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;

        //}

        //private void txtFilterPressureMWSat25_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtCapacityMWSat25_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtThickessMWSat25_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtSatellite2Z1MW_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtSatellite2Z2MW_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtSatellite2Z3MW_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtSatellite2Z4MW_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtSatellite2FilterMW_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtSatellite2mpMW_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtAmperageMWSat2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtFilterPressureMWSat2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtCapacityMWSat2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtThickessMWSat2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtWidthMw_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtHeigthMw_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtEndWidthCrMW_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtEndWidthMdoMW_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtHeadZ1MW_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtHeadZ2MW_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtHeadZ3MW_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtHeadZ4MW_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtHeadZ5MW_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtCilynderHeadMw_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtTubHeadMw_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtRpmHeadMw_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtAmperageHeadMw_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtMdoZ1MW_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;

        //}

        //private void txtMdoZ2MW_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtMdoZ3MW_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtMdoZ4MW_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtMdoZ5MW_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtMdoZ6MW_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtMdoZ7MW_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtSpeedPhsl_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtAmperagePhsl_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtSpeedFd1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtAmperageFd1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtSpeedFd2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtAmperageFd2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtTdoZ1MW_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtTdoZ2MW_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtTdoZ3MW_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtTdoZ4MW_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtTdoZ5MW_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtTdoZ6MW_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtStringSpeedMw_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtStringAmperageMW_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtLubricationTimeMw_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;

        //}

        //private void txtLubricationUnTimeMw_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtRollerGideMw_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtRollerBladeMw_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtRollerTreaterMw_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtRollerTreater2Mw_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtRollerBridgeMw_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtSpeedPrsMw_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtAmperagePrsMw_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtTreaterPowerMw_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtTensionMwCoil1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtTaperMwCoil1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtTensionMwCoil2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtTaperMwCoil2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtPreHeadMw_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtFd1Fd2Mw_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtFd2TdoMw_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtStretchMw_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtCoefficientMw_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtTolerancyPositiveMw_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtTolerancyNegativeMw_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtFormulationSpeedMachine_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtFormulationGramage_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}

        //private void txtFormulationKilogramsPerHour_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsControl(e.KeyChar))
        //        e.Handled = false;
        //    else if (Char.IsPunctuation(e.KeyChar))
        //        e.Handled = false;
        //    else
        //        e.Handled = true;
        //}




        //#endregion

        //#region Cierre

        //private void LoadClose()
        //{
        //    if (objProductionOrder.StatusName == "Cerrada")
        //    {
        //        tbcProductionOrder.TabPages.Remove(tbpClose);
        //    }
        //}

        //private void btnClose_Click(object sender, EventArgs e)
        //{
        //    if (clsRecordDMT.getSituation(objProductionOrder.codsec))
        //    {
        //        frmProductionOrderClose winProductionOrderClose = new frmProductionOrderClose(objProductionOrder.codsec, objFilmProductionPlan.fkMachine);
        //        winProductionOrderClose.StartPosition = FormStartPosition.CenterParent;
        //        winProductionOrderClose.ShowDialog(this);
        //        objProductionOrder.load(objProductionOrder.codsec);
        //        if (objProductionOrder.StatusName == "Cerrada")
        //            tbcProductionOrder.TabPages.Remove(tbpClose);
        //    }
        //    else
        //        MessageBox.Show("La orden no puede ser cerrada si no llena el RECORD DE PRODUCCION", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        //}

        //#endregion

        //#region No Identify Data

        //private void FillFormultationComplete(bool data)
        //{
        //    lblFormulationFilm.Text = objProductionOrderDetail.BoppCode.Replace("-", "");
        //    lblFormulationLotNumber.Text = objFilmProductionPlan.lotNumber.ToString();
        //    lblFormulationMachine.Text = objProductionOrderDetail.MachineName;
        //    lblFormulationExtruder.Text = Math.Round(objProductionOrderDetail.FulfilledQuantity, 2).ToString();
        //    lblFormulationDecrease.Text = Math.Round((objProductionOrderDetail.FulfilledQuantity + clsDecreaseByFilmProductionPlan.getTotalDecreaseByFilmProductionPlan(objProductionOrderDetail.fkFilmProductionPlan)), 2).ToString();
        //    lblFormulationInitDate.Text = objFilmProductionPlan.estimatedInitDate.ToString("dd/MM/yyyy HH:mm");
        //    lblFormulationEndDate.Text = (objProductionOrder.StatusName == "Cerrada") ? objFilmProductionPlan.estimatedEndDate.ToString("dd/MM/yyyy HH:mm") : "----";
        //    lblFormulationWidth.Text = objFilmProductionPlan.widths.ToString();
        //    List<clsFormulationByFilmProductionPlan> lstFormulationByFilmProductionPlan = clsFormulationByFilmProductionPlan.getListByFilmProductionPlan(objProductionOrderDetail.fkFilmProductionPlan);

        //    if (clsFormulationReport.getFormulationStatus(objProductionOrder.codsec) > 0)
        //    {
        //        btnReportFormulation.Enabled = true;
        //        btnAddFormulationReport.Enabled = false;
        //        lblFormulationStatus.Text = "El reporte de formulación se encuentra listo";
        //    }
        //    else
        //    {
        //        btnReportFormulation.Enabled = false;
        //        btnAddFormulationReport.Enabled = true;
        //        lblFormulationStatus.Text = "La Orden seleccionada no posee aún el reporte de formulación";
        //    }

        //    if (lstFormulationByFilmProductionPlan.Count > 0)
        //    {
        //        dgvProductionOrderFormulation.Rows.Clear();
        //        for (int i = 0; i < lstFormulationByFilmProductionPlan.Count; i++)
        //        {
        //            dgvProductionOrderFormulation.Rows.Add();
        //            dgvProductionOrderFormulation.Rows[i].Cells[clmProductionOrderFormulationCodsec.Index].Value = lstFormulationByFilmProductionPlan[i].fkFormulation.ToString();
        //            dgvProductionOrderFormulation.Rows[i].Cells[clmProductionOrderFormulationCode.Index].Value = lstFormulationByFilmProductionPlan[i].formulationName.ToString();
        //        }

        //        clsFormulation objFormulation = clsFormulation.getFormulationBoppDetail(Convert.ToInt32(dgvProductionOrderFormulation.Rows[0].Cells[clmProductionOrderFormulationCodsec.Index].Value));
        //        List<clsRawMaterialByFormulation> lstRawMaterialByFormulation = new List<clsRawMaterialByFormulation>();
        //        lblFormulationC1Thickness.Text = objFormulation.thickLayerC1.ToString();
        //        lblFormulationC2Thickness.Text = objFormulation.thickLayerC2.ToString();
        //        lblFormulationCentralLayerThickness.Text = objFormulation.thickCentralLayer.ToString();
        //        lstRawMaterialByFormulation = clsRawMaterialByFormulation.getListByFormulation(objFormulation.codsec, true);
        //        for (int i = 0; i < lstRawMaterialByFormulation.Count; i++)
        //        {
        //            if (lstRawMaterialByFormulation[i].CentralLayer == true)
        //            {
        //                dgvCentralLayer.Rows.Add();
        //                dgvCentralLayer.Rows[dgvCentralLayer.Rows.Count - 1].Cells[clmCentralLayerType.Index].Value = lstRawMaterialByFormulation[i].nameTypeFormulation;
        //                dgvCentralLayer.Rows[dgvCentralLayer.Rows.Count - 1].Cells[clmCentralLayerProveetor.Index].Value = lstRawMaterialByFormulation[i].companyName;
        //                dgvCentralLayer.Rows[dgvCentralLayer.Rows.Count - 1].Cells[clmCentralLayerRawMaterial.Index].Value = lstRawMaterialByFormulation[i].material;
        //                dgvCentralLayer.Rows[dgvCentralLayer.Rows.Count - 1].Cells[clmCentralLayerPercentage.Index].Value = lstRawMaterialByFormulation[i].percentage;
        //                dgvCentralLayer.Rows[dgvCentralLayer.Rows.Count - 1].Cells[clmCentralLayerLotNumber.Index].Value = string.Empty;
        //                dgvCentralLayer.Rows[dgvCentralLayer.Rows.Count - 1].Cells[clmCentralLayerWeigth.Index].Value = lstRawMaterialByFormulation[i].weigth;
        //            }
        //        }
        //        for (int i = 0; i < lstRawMaterialByFormulation.Count; i++)
        //        {
        //            if (lstRawMaterialByFormulation[i].layerC1 == true)
        //            {
        //                dgvC1.Rows.Add();
        //                dgvC1.Rows[dgvC1.Rows.Count - 1].Cells[clmC1Type.Index].Value = lstRawMaterialByFormulation[i].nameTypeFormulation;
        //                dgvC1.Rows[dgvC1.Rows.Count - 1].Cells[clmC1Provider.Index].Value = lstRawMaterialByFormulation[i].companyName;
        //                dgvC1.Rows[dgvC1.Rows.Count - 1].Cells[clmC1RawMaterial.Index].Value = lstRawMaterialByFormulation[i].material;
        //                dgvC1.Rows[dgvC1.Rows.Count - 1].Cells[clmC1Percentage.Index].Value = lstRawMaterialByFormulation[i].percentage;
        //                dgvC1.Rows[dgvC1.Rows.Count - 1].Cells[clmC1LotNumber.Index].Value = string.Empty;
        //                dgvC1.Rows[dgvC1.Rows.Count - 1].Cells[clmC1Weigth.Index].Value = lstRawMaterialByFormulation[i].weigth;
        //            }
        //        }
        //        for (int i = 0; i < lstRawMaterialByFormulation.Count; i++)
        //        {
        //            if (lstRawMaterialByFormulation[i].layerC2 == true)
        //            {
        //                dgvC2.Rows.Add();
        //                dgvC2.Rows[dgvC2.Rows.Count - 1].Cells[clmC2Type.Index].Value = lstRawMaterialByFormulation[i].nameTypeFormulation;
        //                dgvC2.Rows[dgvC2.Rows.Count - 1].Cells[clmC2Provider.Index].Value = lstRawMaterialByFormulation[i].companyName;
        //                dgvC2.Rows[dgvC2.Rows.Count - 1].Cells[clmC2RawMaterial.Index].Value = lstRawMaterialByFormulation[i].material;
        //                dgvC2.Rows[dgvC2.Rows.Count - 1].Cells[clmC2Percentage.Index].Value = lstRawMaterialByFormulation[i].percentage;
        //                dgvC2.Rows[dgvC2.Rows.Count - 1].Cells[clmC2LotNumber.Index].Value = string.Empty;
        //                dgvC2.Rows[dgvC2.Rows.Count - 1].Cells[clmC2Weigth.Index].Value = lstRawMaterialByFormulation[i].weigth;
        //            }
        //        }
        //        txtGramageCO2.Text = Math.Round((Convert.ToDouble(lblFormulationC2Thickness.Text) * 0.9), 2).ToString();
        //        txtGramageCO1.Text = Math.Round((Convert.ToDouble(lblFormulationC1Thickness.Text) * 0.9), 2).ToString();
        //    }
        //    else
        //    {
        //        //List<clsFormulation> lstFormulation = clsFormulation.getListByBoppFilm(objProductionOrderDetail.fkBopp);
        //        //for (int i = 0; i < lstFormulation.Count; i++)
        //        //    cmbProductionOrderFormulation.Items.Add(lstFormulation[i]);
        //    }
        //}

        //private void btnExit2_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void brnExit5_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void btnExit3_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void txtFormulationGramage_TextChanged(object sender, EventArgs e)
        //{
        //    txtGramageCentralLayer.Text = (Convert.ToDouble(txtFormulationGramage.Text) - (Convert.ToDouble(txtGramageCO1.Text) + Convert.ToDouble(txtGramageCO2.Text))).ToString();
        //}

        //private void GenerateDecreaseRawMaterial()
        //{
        //    double summarycentarlLayer = 0, summaryLayerC1 = 0, summaryLayerC2 = 0;
        //    dgvRawMaterial.Rows.Clear();
        //    for (int i = 0; i < dgvCentralLayer.Rows.Count; i++)
        //    {
        //        summarycentarlLayer += Convert.ToDouble(dgvCentralLayer.Rows[i].Cells[clmCentralLayerWeigth.Index].Value);
        //    }
        //    for (int i = 0; i < dgvC1.Rows.Count; i++)
        //    {
        //        summaryLayerC1 += Convert.ToDouble(dgvC1.Rows[i].Cells[clmC1Weigth.Index].Value);
        //    }
        //    for (int i = 0; i < dgvC2.Rows.Count; i++)
        //    {
        //        summaryLayerC2 += Convert.ToDouble(dgvC2.Rows[i].Cells[clmC2Weigth.Index].Value);
        //    }
        //    for (int i = 0; i < dgvCentralLayer.Rows.Count; i++)
        //    {
        //        dgvRawMaterial.Rows.Add();
        //        dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawmaterial.Index].Value = dgvCentralLayer.Rows[i].Cells[clmCentralLayerType.Index].Value.ToString();
        //        dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawtype.Index].Value = dgvCentralLayer.Rows[i].Cells[clmCentralLayerRawMaterial.Index].Value.ToString();
        //        dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawteorical.Index].Value = (Convert.ToDouble(dgvCentralLayer.Rows[i].Cells[clmCentralLayerWeigth.Index].Value) != 0) ? CalculeTeorical(Convert.ToDouble(dgvCentralLayer.Rows[i].Cells[clmCentralLayerWeigth.Index].Value), summarycentarlLayer, Convert.ToDouble(txtGramageCentralLayer.Text), Convert.ToDouble(txtFormulationGramage.Text)) : 0;
        //        dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawreal.Index].Value = (Convert.ToDouble(dgvCentralLayer.Rows[i].Cells[clmCentralLayerWeigth.Index].Value) != 0) ? CalculeReal(Convert.ToDouble(dgvCentralLayer.Rows[i].Cells[clmCentralLayerWeigth.Index].Value), summarycentarlLayer, Convert.ToDouble(txtGramageCentralLayer.Text), Convert.ToDouble(txtFormulationGramage.Text)) : 0;
        //    }
        //    for (int i = 0; i < dgvC1.Rows.Count; i++)
        //    {
        //        dgvRawMaterial.Rows.Add();
        //        dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawmaterial.Index].Value = dgvC1.Rows[i].Cells[clmC1Type.Index].Value.ToString();
        //        dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawtype.Index].Value = dgvC1.Rows[i].Cells[clmC1RawMaterial.Index].Value.ToString();
        //        dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawteorical.Index].Value = (Convert.ToDouble(dgvC1.Rows[i].Cells[clmC1Weigth.Index].Value) != 0) ? CalculeTeorical(Convert.ToDouble(dgvC1.Rows[i].Cells[clmC1Weigth.Index].Value), summaryLayerC1, Convert.ToDouble(txtGramageCO1.Text), Convert.ToDouble(txtFormulationGramage.Text)) : 0;
        //        dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawreal.Index].Value = (Convert.ToDouble(dgvC1.Rows[i].Cells[clmC1Weigth.Index].Value) != 0) ? CalculeReal(Convert.ToDouble(dgvC1.Rows[i].Cells[clmC1Weigth.Index].Value), summaryLayerC1, Convert.ToDouble(txtGramageCO1.Text), Convert.ToDouble(txtFormulationGramage.Text)) : 0;
        //    }
        //    for (int i = 0; i < dgvC2.Rows.Count; i++)
        //    {
        //        dgvRawMaterial.Rows.Add();
        //        dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawmaterial.Index].Value = dgvC2.Rows[i].Cells[clmC2Type.Index].Value.ToString();
        //        dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawtype.Index].Value = dgvC2.Rows[i].Cells[clmC2RawMaterial.Index].Value.ToString();
        //        dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawteorical.Index].Value = (Convert.ToDouble(dgvC2.Rows[i].Cells[clmC2Weigth.Index].Value) != 0) ? CalculeTeorical(Convert.ToDouble(dgvC2.Rows[i].Cells[clmC2Weigth.Index].Value), summaryLayerC2, Convert.ToDouble(txtGramageCO2.Text), Convert.ToDouble(txtFormulationGramage.Text)) : 0;
        //        dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawreal.Index].Value = (Convert.ToDouble(dgvC2.Rows[i].Cells[clmC2Weigth.Index].Value) != 0) ? CalculeReal(Convert.ToDouble(dgvC2.Rows[i].Cells[clmC2Weigth.Index].Value), summaryLayerC2, Convert.ToDouble(txtGramageCO2.Text), Convert.ToDouble(txtFormulationGramage.Text)) : 0;
        //    }
        //}

        //private double CalculeReal(double weigth, double summaryweigth, double gramagepercap, double gramage)
        //{
        //    return Math.Round(((weigth / summaryweigth) * (gramagepercap / gramage)) * (Convert.ToDouble(lblFormulationDecrease.Text)), 2);
        //}

        //private double CalculeTeorical(double weigth, double summaryweigth, double gramagepercap, double gramage)
        //{
        //    return Math.Round(((weigth / summaryweigth) * (gramagepercap / gramage)) * (Convert.ToDouble(lblFormulationExtruder.Text)), 2);
        //}

        //#endregion

        //private void btnDmt_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        setDMTValues("toSave");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void setDMTValues(string destination)
        //{
        //    switch (destination)
        //    {
        //        case "toSave":
        //            if (ValidateFormDMT())
        //            {
        //                objRecordDMT.head = string.Empty;
        //                objRecordDMT.head = getValuesFromControl(grpbExtrusedMain, "label").Replace("Orden;", "").Replace("Tipo;", "").Replace("Espesor;", "").Replace("Lote;", "").Replace("Fecha;", "");
        //                objRecordDMT.head += ";" + getValuesFromControl(grpbExtruderFoot, "textBox");
        //                objRecordDMT.head += ";" + getValuesFromControl(gpbPressureandAmperage, "textBox");
        //                objRecordDMT.head += ";" + getValuesFromControl(grpbSatellite1head, "textBox");
        //                objRecordDMT.head += ";" + getValuesFromControl(gpbPressureandAmperageSatellite1, "textBox");
        //                objRecordDMT.head += ";" + getValuesFromControl(grpbSatellite2Head, "textBox");
        //                objRecordDMT.head += ";" + getValuesFromControl(gpbPressureandAmperageSatellite2, "textBox");

        //                objRecordDMT.body = string.Empty;
        //                objRecordDMT.body = "" + getValuesFromControl(gpbTemperatureHead, "textBox");
        //                objRecordDMT.body += ";" + getValuesFromControl(gpbSpeed, "textBox");
        //                objRecordDMT.body += ";" + getValuesFromControl(gpbPressure, "textBox");
        //                objRecordDMT.body += ";" + getValuesFromControl(grpbmdohead, "textBox");
        //                objRecordDMT.body += ";" + getValuesFromControl(grpbmdofoot, "textBox");
        //                objRecordDMT.body += ";" + getValuesFromControl(grpbmdo1, "textBox");
        //                objRecordDMT.body += ";" + getValuesFromControl(grpbmdo2, "textBox");
        //                objRecordDMT.body += ";" + getValuesFromControl(grpbtdohead, "textBox");
        //                objRecordDMT.body += ";" + getValuesFromControl(gpbSpeedAmperageAndLubrication, "textBox");

        //                objRecordDMT.footer = string.Empty;
        //                objRecordDMT.footer = "" + getValuesFromControl(grpbrpmain, "textBox");
        //                objRecordDMT.footer += ";" + getValuesFromControl(gpbTension, "textBox");
        //                objRecordDMT.footer += ";" + getValuesFromControl(gpbPressureCoil, "textBox");
        //                objRecordDMT.footer += ";" + getValuesFromControl(gpbCoil, "textBox");
        //                objRecordDMT.footer += ";" + getValuesFromControl(grpbThickness, "textBox");
        //                objRecordDMT.footer += ";" + getValuesFromControl(grpbLaboratory, "textBox");
        //                objRecordDMT.footer += ";" + getValuesFromControl(groupBox7, "textBox");

        //                objRecordDMT.fkProductionOrder = objProductionOrder.codsec;

        //                if (!clsRecordDMT.getSituation(objProductionOrder.codsec))
        //                {
        //                    var recordCodsec = clsRecordDMT.getSituactionCodsec(objProductionOrder.codsec);
        //                    if (recordCodsec == 0)
        //                    {
        //                        if (objRecordDMT.save())
        //                        {
        //                            lblDMTSatus.Text = "RECORD DE PRODUCCIÓN INGRESADO";
        //                            lblDMTSatus.ForeColor = Color.Black;
        //                            MessageBox.Show("Record Guardado Correctamente");
        //                            //Sacar el reporte
        //                            frmRecordDMT winRecordDMT = new frmRecordDMT(objProductionOrder.codsec, clsGlobal.password);
        //                            winRecordDMT.StartPosition = FormStartPosition.CenterScreen;
        //                            winRecordDMT.WindowState = FormWindowState.Maximized;
        //                            winRecordDMT.MdiParent = this.MdiParent;
        //                            winRecordDMT.Show();
        //                        }
        //                        else
        //                            MessageBox.Show("No se pudo procesar los datos, recuerde no puede usar el ;");
        //                    }
        //                    else
        //                    {
        //                        objRecordDMT.codsec = recordCodsec;
        //                        if (objRecordDMT.save())
        //                        {
        //                            MessageBox.Show("Record Actualizado Correctamente");
        //                            //Sacar Reporte
        //                            lblDMTSatus.Text = "RECORD DE PRODUCCIÓN INGRESADO";
        //                            lblDMTSatus.ForeColor = Color.Black;
        //                            frmRecordDMT winRecordDMT = new frmRecordDMT(objProductionOrder.codsec, clsGlobal.password);
        //                            winRecordDMT.StartPosition = FormStartPosition.CenterScreen;
        //                            winRecordDMT.WindowState = FormWindowState.Maximized;
        //                            winRecordDMT.MdiParent = this.MdiParent;
        //                            winRecordDMT.Show();
        //                        }
        //                        else
        //                            MessageBox.Show("No se pudo procesar los datos, recuerde no puede usar el ;");
        //                    }
        //                }
        //            }
        //            else
        //                MessageBox.Show("Por favor revise todos los campos que están pintados de color ROJO, debe llenar todos los datos para poder guardar...", "Record de Producción", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        //            break;

        //        case "toSaveMW":
        //            if (ValidateFormMW())
        //            {
        //                objRecordDMT.head = string.Empty;
        //                objRecordDMT.head = getValuesFromControl(grpbExtruderMain, "label").Replace("Orden;", "").Replace("Tipo;", "").Replace("Espesor;", "").Replace("Lote;", "").Replace("Fecha;", "");
        //                objRecordDMT.head += ";" + getValuesFromControl(grpbExtruderZ, "textBox");
        //                objRecordDMT.head += ";" + getValuesFromControl(gpbPressionAmperageMW, "textBox");
        //                objRecordDMT.head += ";" + getValuesFromControl(grpSatellitemain25, "textBox");
        //                objRecordDMT.head += ";" + getValuesFromControl(gpbPressureAmperaSat25MW, "textBox");
        //                objRecordDMT.head += ";" + getValuesFromControl(grpbSatellite2, "textBox");
        //                objRecordDMT.head += ";" + getValuesFromControl(gpbPressureAmperaSat2MW, "textBox");

        //                objRecordDMT.body = string.Empty;
        //                objRecordDMT.body = "" + getValuesFromControl(gpbPressureMW, "textBox");
        //                objRecordDMT.body += ";" + getValuesFromControl(gpbHeadAndTemperaturaMW, "textBox");
        //                objRecordDMT.body += ";" + getValuesFromControl(gpbChillRollMW, "textBox");
        //                objRecordDMT.body += ";" + getValuesFromControl(grpbmdomainmw, "textBox");
        //                objRecordDMT.body += ";" + getValuesFromControl(grpbphsl, "textBox");
        //                objRecordDMT.body += ";" + getValuesFromControl(grpbfd, "textBox");
        //                objRecordDMT.body += ";" + getValuesFromControl(grpbfd2, "textBox");
        //                objRecordDMT.body += ";" + getValuesFromControl(grpb, "textBox");
        //                objRecordDMT.body += ";" + getValuesFromControl(gpbAmperageTdoMw, "textBox");

        //                objRecordDMT.footer = string.Empty;
        //                objRecordDMT.footer = "" + getValuesFromControl(grpbprs, "textBox");
        //                objRecordDMT.footer += ";" + getValuesFromControl(grpbCoilmw, "textBox");
        //                objRecordDMT.footer += ";" + getValuesFromControl(gbpThicknessMw, "textBox");
        //                objRecordDMT.footer += ";" + getValuesFromControl(groupBox24, "textBox");
        //                objRecordDMT.footer += ";" + getValuesFromControl(groupBox8, "textBox");

        //                objRecordDMT.fkProductionOrder = objProductionOrder.codsec;

        //                if (!clsRecordDMT.getSituation(objProductionOrder.codsec))
        //                {
        //                    var recordCodsec = clsRecordDMT.getSituactionCodsec(objProductionOrder.codsec);
        //                    if (recordCodsec == 0)
        //                    {
        //                        if (objRecordDMT.save())
        //                        {
        //                            lblMWSatus.Text = "RECORD DE PRODUCCIÓN INGRESADO";
        //                            lblMWSatus.ForeColor = Color.Black;
        //                            MessageBox.Show("Record Guardado Correctamente");
        //                            //Sacar el reporte
        //                            frmRecordMW winRecordMW = new frmRecordMW(objProductionOrder.codsec, clsGlobal.password);
        //                            winRecordMW.StartPosition = FormStartPosition.CenterScreen;
        //                            winRecordMW.WindowState = FormWindowState.Maximized;
        //                            winRecordMW.MdiParent = this.MdiParent;
        //                            winRecordMW.Show();
        //                        }
        //                        else
        //                            MessageBox.Show("No se pudo procesar los datos, recuerde no puede usar el ;");
        //                    }
        //                    else
        //                    {
        //                        objRecordDMT.codsec = recordCodsec;
        //                        if (objRecordDMT.save())
        //                        {
        //                            MessageBox.Show("Record Actualizado Correctamente");
        //                            //Sacar Reporte
        //                            lblMWSatus.Text = "RECORD DE PRODUCCIÓN INGRESADO";
        //                            lblMWSatus.ForeColor = Color.Black;
        //                            frmRecordMW winRecordMW = new frmRecordMW(objProductionOrder.codsec, clsGlobal.password);
        //                            winRecordMW.StartPosition = FormStartPosition.CenterScreen;
        //                            winRecordMW.WindowState = FormWindowState.Maximized;
        //                            winRecordMW.MdiParent = this.MdiParent;
        //                            winRecordMW.Show();
        //                        }
        //                        else
        //                            MessageBox.Show("No se pudo procesar los datos, recuerde no puede usar el ;");
        //                    }
        //                }
        //            }
        //            else
        //                MessageBox.Show("Por favor revise todos los campos que están pintados de color ROJO, debe llenar todos los datos para poder guardar...", "Record de Producción", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        //            break;
        //        //case "toLoad":

        //        //    setValuesToControl(grpbOpacityTransmittance, "textBox", objMainCoilQuality.opacityTransmittanceValues);
        //        //    break;
        //        default:
        //            break;
        //    }
        //}

        //private string getValuesFromControl(System.Windows.Forms.Control container, string controlType)
        //{
        //    string result = "";
        //    switch (controlType)
        //    {
        //        case "textBox":

        //            List<System.Windows.Forms.TextBox> lstTextBox = new List<TextBox>();
        //            foreach (System.Windows.Forms.Control ctrl in container.Controls)
        //            {
        //                if (object.ReferenceEquals(ctrl.GetType(), typeof(System.Windows.Forms.TextBox)))
        //                    lstTextBox.Add(((TextBox)ctrl));
        //            }
        //            lstTextBox.Sort(delegate(TextBox txt1, TextBox txt2) { return txt1.TabIndex.CompareTo(txt2.TabIndex); });
        //            for (int i = 0; i < lstTextBox.Count; i++)
        //                result += lstTextBox[i].Text + ((i < lstTextBox.Count - 1) ? ";" : "");
        //            break;

        //        case "label":

        //            List<System.Windows.Forms.Label> lstLabel = new List<Label>();
        //            foreach (System.Windows.Forms.Control ctrl in container.Controls)
        //            {
        //                if (object.ReferenceEquals(ctrl.GetType(), typeof(System.Windows.Forms.Label)))
        //                    lstLabel.Add(((Label)ctrl));
        //            }
        //            lstLabel.Sort(delegate(Label txt1, Label txt2) { return txt1.TabIndex.CompareTo(txt2.TabIndex); });
        //            for (int i = 0; i < lstLabel.Count; i++)
        //                result += lstLabel[i].Text + ((i < lstLabel.Count - 1) ? ";" : "");
        //            break;

        //        default:
        //            break;
        //    }
        //    return result;
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (clsRecordDMT.getSituation(objProductionOrder.codsec))
        //    {
        //        frmRecordDMT winRecordDMT = new frmRecordDMT(objProductionOrder.codsec, clsGlobal.password);
        //        winRecordDMT.StartPosition = FormStartPosition.CenterScreen;
        //        winRecordDMT.WindowState = FormWindowState.Maximized;
        //        winRecordDMT.MdiParent = this.MdiParent;
        //        winRecordDMT.Show();
        //    }
        //    else
        //        MessageBox.Show("No existen datos para generar el Reporte.");
        //}

        //private void btnCrossDmt_Click(object sender, EventArgs e)
        //{
        //    if (MessageBox.Show("Esta realmente seguro que desea eliminar el record seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
        //    {
        //        try
        //        {
        //            if (clsRecordDMT.delete(objProductionOrder.codsec))
        //            {
        //                MessageBox.Show("Record Eliminado Correctamente");
        //                btnDmt.Enabled = true;
        //                lblMWSatus.Text = "RECORD DE PRODUCCIÓN  BORRADO, Por favor ingreso el nuevo record";
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //    }
        //}

        //private void btnMW_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        setDMTValues("toSaveMW");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void btnReportNew_Click(object sender, EventArgs e)
        //{
        //    if (clsRecordDMT.getSituation(objProductionOrder.codsec))
        //    {
        //        frmRecordMW winRecordMW = new frmRecordMW(objProductionOrder.codsec, clsGlobal.password);
        //        winRecordMW.StartPosition = FormStartPosition.CenterScreen;
        //        winRecordMW.WindowState = FormWindowState.Maximized;
        //        winRecordMW.MdiParent = this.MdiParent;
        //        winRecordMW.Show();
        //    }
        //    else
        //        MessageBox.Show("No existen datos para generar el Reporte.");
        //}

        //private void btnDeleteR_Click(object sender, EventArgs e)
        //{
        //    if (MessageBox.Show("Esta realmente seguro que desea eliminar el record seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
        //    {
        //        try
        //        {
        //            if (clsRecordDMT.delete(objProductionOrder.codsec))
        //            {
        //                MessageBox.Show("Record Eliminado Correctamente");
        //                btnDmt.Enabled = true;
        //                lblMWSatus.Text = "RECORD DE PRODUCCIÓN  BORRADO, Por favor ingreso el nuevo record";
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //    }
        //}
    }
}