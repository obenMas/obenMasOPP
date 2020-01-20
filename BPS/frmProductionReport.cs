using System;
using System.Collections.Generic;
using System.Windows.Forms; 
using BPS.Bussiness;

namespace BPS
{
    public partial class frmProductionReport : Form
    {
        clsFilmProductionPlan ObjFilmProductionPlan = new clsFilmProductionPlan();

        List<clsMainCoil> lstMainCoil = new List<clsMainCoil>();
        List<clsDeadTimeByFilmProductionPlan> lstDeadTimeByFilmProductionPlan = new List<clsDeadTimeByFilmProductionPlan>();
        List<clsDecreaseByFilmProductionPlan> lstDecreaseByFilmProductionPlan = new List<clsDecreaseByFilmProductionPlan>();
        List<clsFilter> lstFilter = new List<clsFilter>();
        List<decreaseByFilmAndFormulation> lstDecreaseByFilmAndFormulation = new List<decreaseByFilmAndFormulation>();

        List<string> lstFilmType = new List<string>();
        Boolean flgInList = false;
        int position = -1;
        clsMachine objMachine = new clsMachine();
        clsFormulation objFormulation = new clsFormulation();
        double TotalProduction = 0;
        double TotalDecrease = 0;
        double DeadTimeTMP, DeadTimeTMM, DeadTimeTMOtros = 0;
        string initDate = "", endDate = "";

        public frmProductionReport()
        {
            InitializeComponent();
        }

        public frmProductionReport(int machineCodsec)
        {
            InitializeComponent();
            objMachine.load(machineCodsec, "Extruder");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadMainProductionList();
        }

        private void LoadMainProductionList()
        {
            dgvMainCoilList.Rows.Clear();
            ClearTextBoxAndCounts();
            if (cmbInnig.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar un turno", "Reporte de Producción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (cmbInnig.SelectedIndex == 0)
                {
                    initDate = dtpDate.Value.ToString("dd/MM/yyyy 07:30");
                    endDate = dtpDate.Value.ToString("dd/MM/yyyy 19:30");
                    lstMainCoil = clsMainCoil.getListForReportProduction(objMachine.codsec, initDate, endDate);
                    if (lstMainCoil.Count <= 0)
                        MessageBox.Show("No hay datos con esa Fecha en ese Turno", "Reporte de Producción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        for (int i = 0; i < lstMainCoil.Count; i++)
                        {
                            dgvMainCoilList.Rows.Add();
                            dgvMainCoilList.Rows[i].Cells[clmcodsec.Index].Value = lstMainCoil[i].codsec.ToString();
                            dgvMainCoilList.Rows[i].Cells[clmInitDate.Index].Value = lstMainCoil[i].initDate.ToString("dd/MM/yyyy HH:mm");
                            dgvMainCoilList.Rows[i].Cells[clmEndDate.Index].Value = lstMainCoil[i].endDate.ToString("dd/MM/yyyy HH:mm");
                            dgvMainCoilList.Rows[i].Cells[clmHours.Index].Value = lstMainCoil[i].hours.ToString();
                            dgvMainCoilList.Rows[i].Cells[clmCode.Index].Value = lstMainCoil[i].code.ToString();
                            dgvMainCoilList.Rows[i].Cells[clmTypeFilm.Index].Value = lstMainCoil[i].BoppCode.ToString().Replace("-", "");
                            dgvMainCoilList.Rows[i].Cells[clmOrder.Index].Value = lstMainCoil[i].ProductionOrderNumber.ToString();
                            dgvMainCoilList.Rows[i].Cells[clmLength.Index].Value = Math.Round(lstMainCoil[i].grosslength, 2).ToString();
                            dgvMainCoilList.Rows[i].Cells[clmKilos.Index].Value = Math.Round(lstMainCoil[i].netWeigth, 2).ToString();
                            TotalProduction += Convert.ToDouble(dgvMainCoilList.Rows[i].Cells[clmKilos.Index].Value);
                            dgvMainCoilList.Rows[i].Cells[clmWidth.Index].Value = lstMainCoil[i].width.ToString();
                            dgvMainCoilList.Rows[i].Cells[clmAccumulator.Index].Value = Math.Round(lstMainCoil[i].accumulated, 2).ToString();
                        }
                        lblProductionTotal.Text = TotalProduction.ToString();

                        lstDecreaseByFilmProductionPlan = clsDecreaseByFilmProductionPlan.getListByProductionReport(objMachine.codsec, initDate, endDate);

                        for (int i = 0; i < lstDecreaseByFilmProductionPlan.Count; i++)
                        {
                            flgInList = false;
                            position = -1;
                            for (int j = 0; j < lstDecreaseByFilmAndFormulation.Count; j++)
                            {
                                if (lstDecreaseByFilmProductionPlan[i].filmCode.Replace("-", "") == lstDecreaseByFilmAndFormulation[j].filmCode.Replace("-", "") && lstDecreaseByFilmProductionPlan[i].fkFormulation == lstDecreaseByFilmAndFormulation[j].fkFormulation && lstDecreaseByFilmProductionPlan[i].orderNumber == lstDecreaseByFilmAndFormulation[j].orderNumber)
                                {
                                    flgInList = true;
                                    position = j;
                                }
                            }

                            if (flgInList == true)
                            {
                                decreaseByFilmAndFormulation objDecreaseByFilmAndFormulation = new decreaseByFilmAndFormulation();

                                objDecreaseByFilmAndFormulation.orderNumber = lstDecreaseByFilmAndFormulation[position].orderNumber;
                                objDecreaseByFilmAndFormulation.weight = lstDecreaseByFilmAndFormulation[position].weight + lstDecreaseByFilmProductionPlan[i].weight;
                                objDecreaseByFilmAndFormulation.filmCode = lstDecreaseByFilmAndFormulation[position].filmCode;
                                objDecreaseByFilmAndFormulation.fkFormulation = lstDecreaseByFilmAndFormulation[position].fkFormulation;
                                objDecreaseByFilmAndFormulation.formulationName = lstDecreaseByFilmAndFormulation[position].formulationName;

                                lstDecreaseByFilmAndFormulation[position] = objDecreaseByFilmAndFormulation;
                            }
                            else
                            {
                                decreaseByFilmAndFormulation objDecreaseByFilmAndFormulation = new decreaseByFilmAndFormulation();

                                objDecreaseByFilmAndFormulation.orderNumber = lstDecreaseByFilmProductionPlan[i].orderNumber;
                                objDecreaseByFilmAndFormulation.weight = lstDecreaseByFilmProductionPlan[i].weight;
                                objDecreaseByFilmAndFormulation.filmCode = lstDecreaseByFilmProductionPlan[i].filmCode.Replace("-", "");
                                objDecreaseByFilmAndFormulation.fkFormulation = lstDecreaseByFilmProductionPlan[i].fkFormulation;
                                objDecreaseByFilmAndFormulation.formulationName = lstDecreaseByFilmProductionPlan[i].formulationName;

                                lstDecreaseByFilmAndFormulation.Add(objDecreaseByFilmAndFormulation);
                            }
                        }

                        dgvDecrease.Rows.Clear();

                        for (int i = 0; i < lstDecreaseByFilmAndFormulation.Count; i++)
                        {
                            dgvDecrease.Rows.Add();
                            dgvDecrease.Rows[i].Cells[clmDecreaseOrderNumber.Index].Value = lstDecreaseByFilmAndFormulation[i].orderNumber;
                            dgvDecrease.Rows[i].Cells[clmDecreaseFilmType.Index].Value = lstDecreaseByFilmAndFormulation[i].filmCode;
                            dgvDecrease.Rows[i].Cells[clmDecreaseQuantity.Index].Value = lstDecreaseByFilmAndFormulation[i].weight;
                            TotalDecrease += Convert.ToDouble(lstDecreaseByFilmAndFormulation[i].weight);
                            dgvDecrease.Rows[i].Cells[clmDecreaseFormulation.Index].Value = lstDecreaseByFilmAndFormulation[i].formulationName;
                            dgvDecrease.Rows[i].Cells[clmDecreaseFormulationCodsec.Index].Value = lstDecreaseByFilmAndFormulation[i].fkFormulation;
                        }

                        lblTotalWaste.Text = TotalDecrease.ToString();
                        lstDeadTimeByFilmProductionPlan = clsDeadTimeByFilmProductionPlan.getListProductionReport(objMachine.codsec, endDate, initDate);

                        dgvDeadTime.Rows.Clear();

                        for (int i = 0; i < lstDeadTimeByFilmProductionPlan.Count; i++)
                        {
                            dgvDeadTime.Rows.Add();

                            dgvDeadTime.Rows[i].Cells[clmDeadTimeLotNumber.Index].Value = lstDeadTimeByFilmProductionPlan[i].lotNumber;
                            dgvDeadTime.Rows[i].Cells[clmDeadTimeInitDate.Index].Value = lstDeadTimeByFilmProductionPlan[i].initDate.ToString("dd/MM/yyyy HH:mm");
                            dgvDeadTime.Rows[i].Cells[clmDeadTimeEndDate.Index].Value = lstDeadTimeByFilmProductionPlan[i].endDate.ToString("dd/MM/yyyy HH:mm");
                            dgvDeadTime.Rows[i].Cells[clmDeadTimeTime.Index].Value = Math.Round(lstDeadTimeByFilmProductionPlan[i].endDate.Subtract(lstDeadTimeByFilmProductionPlan[i].initDate).TotalHours, 2);
                            dgvDeadTime.Rows[i].Cells[clmDeadTimeReason.Index].Value = lstDeadTimeByFilmProductionPlan[i].deadTimeTypeName;
                            dgvDeadTime.Rows[i].Cells[clmDeadTimeGroup.Index].Value = lstDeadTimeByFilmProductionPlan[i].deadTimeGroup;
                            if (lstDeadTimeByFilmProductionPlan[i].deadTimeGroup == "TMP")
                                DeadTimeTMP += Math.Round(lstDeadTimeByFilmProductionPlan[i].endDate.Subtract(lstDeadTimeByFilmProductionPlan[i].initDate).TotalHours, 2);
                            else if (lstDeadTimeByFilmProductionPlan[i].deadTimeGroup == "TMM")
                                DeadTimeTMM += Math.Round(lstDeadTimeByFilmProductionPlan[i].endDate.Subtract(lstDeadTimeByFilmProductionPlan[i].initDate).TotalHours, 2);
                            else
                                DeadTimeTMOtros += Math.Round(lstDeadTimeByFilmProductionPlan[i].endDate.Subtract(lstDeadTimeByFilmProductionPlan[i].initDate).TotalHours, 2);
                        }
                        
                    }
                    //Efficiency
                    lblTmp.Text = DeadTimeTMP.ToString();
                    lblTmm.Text = DeadTimeTMM.ToString();
                    lblTOther.Text = DeadTimeTMOtros.ToString();
                    lblEfficiency.Text = Convert.ToString(Math.Round(((TotalProduction / (TotalProduction + TotalDecrease)) * 100), 2));
                    lblConsumption.Text = Convert.ToString((TotalProduction + TotalDecrease));
                }
                else
                {
                    initDate = dtpDate.Value.ToString("dd/MM/yyyy 19:30:01");
                    endDate = dtpDate.Value.AddDays(1).ToString("dd/MM/yyyy 07:29:59" );
                    lstMainCoil = clsMainCoil.getListForReportProduction(objMachine.codsec, initDate, endDate);
                    if (lstMainCoil.Count <= 0)
                        MessageBox.Show("No hay datos con esa Fecha en ese Turno", "Reporte de Producción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        for (int i = 0; i < lstMainCoil.Count; i++)
                        {
                            dgvMainCoilList.Rows.Add();
                            dgvMainCoilList.Rows[i].Cells[clmcodsec.Index].Value = lstMainCoil[i].codsec.ToString();
                            dgvMainCoilList.Rows[i].Cells[clmInitDate.Index].Value = lstMainCoil[i].initDate.ToString("dd/MM/yyyy HH:mm");
                            dgvMainCoilList.Rows[i].Cells[clmEndDate.Index].Value = lstMainCoil[i].endDate.ToString("dd/MM/yyyy HH:mm");
                            dgvMainCoilList.Rows[i].Cells[clmHours.Index].Value = lstMainCoil[i].hours.ToString();
                            dgvMainCoilList.Rows[i].Cells[clmCode.Index].Value = lstMainCoil[i].code.ToString();
                            dgvMainCoilList.Rows[i].Cells[clmTypeFilm.Index].Value = lstMainCoil[i].BoppCode.ToString().Replace("-", "");
                            dgvMainCoilList.Rows[i].Cells[clmOrder.Index].Value = lstMainCoil[i].ProductionOrderNumber.ToString();
                            dgvMainCoilList.Rows[i].Cells[clmLength.Index].Value = Math.Round(lstMainCoil[i].grosslength, 2).ToString();
                            dgvMainCoilList.Rows[i].Cells[clmKilos.Index].Value = Math.Round(lstMainCoil[i].netWeigth, 2).ToString();
                            TotalProduction += Convert.ToDouble(dgvMainCoilList.Rows[i].Cells[clmKilos.Index].Value);
                            dgvMainCoilList.Rows[i].Cells[clmWidth.Index].Value = lstMainCoil[i].width.ToString();
                            dgvMainCoilList.Rows[i].Cells[clmAccumulator.Index].Value = Math.Round(lstMainCoil[i].accumulated, 2).ToString();
                        }
                        lblProductionTotal.Text = TotalProduction.ToString();

                        lstDecreaseByFilmProductionPlan = clsDecreaseByFilmProductionPlan.getListByProductionReport(objMachine.codsec, initDate, endDate);

                        for (int i = 0; i < lstDecreaseByFilmProductionPlan.Count; i++)
                        {
                            flgInList = false;
                            position = -1;
                            for (int j = 0; j < lstDecreaseByFilmAndFormulation.Count; j++)
                            {
                                if (lstDecreaseByFilmProductionPlan[i].filmCode.Replace("-", "") == lstDecreaseByFilmAndFormulation[j].filmCode.Replace("-", "") && lstDecreaseByFilmProductionPlan[i].fkFormulation == lstDecreaseByFilmAndFormulation[j].fkFormulation && lstDecreaseByFilmProductionPlan[i].orderNumber == lstDecreaseByFilmAndFormulation[j].orderNumber)
                                {
                                    flgInList = true;
                                    position = j;
                                }
                            }

                            if (flgInList == true)
                            {
                                decreaseByFilmAndFormulation objDecreaseByFilmAndFormulation = new decreaseByFilmAndFormulation();

                                objDecreaseByFilmAndFormulation.orderNumber = lstDecreaseByFilmAndFormulation[position].orderNumber;
                                objDecreaseByFilmAndFormulation.weight = lstDecreaseByFilmAndFormulation[position].weight + lstDecreaseByFilmProductionPlan[i].weight;
                                objDecreaseByFilmAndFormulation.filmCode = lstDecreaseByFilmAndFormulation[position].filmCode;
                                objDecreaseByFilmAndFormulation.fkFormulation = lstDecreaseByFilmAndFormulation[position].fkFormulation;
                                objDecreaseByFilmAndFormulation.formulationName = lstDecreaseByFilmAndFormulation[position].formulationName;

                                lstDecreaseByFilmAndFormulation[position] = objDecreaseByFilmAndFormulation;
                            }
                            else
                            {
                                decreaseByFilmAndFormulation objDecreaseByFilmAndFormulation = new decreaseByFilmAndFormulation();

                                objDecreaseByFilmAndFormulation.orderNumber = lstDecreaseByFilmProductionPlan[i].orderNumber;
                                objDecreaseByFilmAndFormulation.weight = lstDecreaseByFilmProductionPlan[i].weight;
                                objDecreaseByFilmAndFormulation.filmCode = lstDecreaseByFilmProductionPlan[i].filmCode.Replace("-", "");
                                objDecreaseByFilmAndFormulation.fkFormulation = lstDecreaseByFilmProductionPlan[i].fkFormulation;
                                objDecreaseByFilmAndFormulation.formulationName = lstDecreaseByFilmProductionPlan[i].formulationName;

                                lstDecreaseByFilmAndFormulation.Add(objDecreaseByFilmAndFormulation);
                            }
                        }

                        dgvDecrease.Rows.Clear();

                        for (int i = 0; i < lstDecreaseByFilmAndFormulation.Count; i++)
                        {
                            dgvDecrease.Rows.Add();
                            dgvDecrease.Rows[i].Cells[clmDecreaseOrderNumber.Index].Value = lstDecreaseByFilmAndFormulation[i].orderNumber;
                            dgvDecrease.Rows[i].Cells[clmDecreaseFilmType.Index].Value = lstDecreaseByFilmAndFormulation[i].filmCode;
                            dgvDecrease.Rows[i].Cells[clmDecreaseQuantity.Index].Value = lstDecreaseByFilmAndFormulation[i].weight;
                            TotalDecrease += Convert.ToDouble(lstDecreaseByFilmAndFormulation[i].weight);
                            dgvDecrease.Rows[i].Cells[clmDecreaseFormulation.Index].Value = lstDecreaseByFilmAndFormulation[i].formulationName;
                            dgvDecrease.Rows[i].Cells[clmDecreaseFormulationCodsec.Index].Value = lstDecreaseByFilmAndFormulation[i].fkFormulation;
                        }

                        lblTotalWaste.Text = TotalDecrease.ToString();
                        lstDeadTimeByFilmProductionPlan = clsDeadTimeByFilmProductionPlan.getListProductionReport(objMachine.codsec, endDate, initDate);

                        dgvDeadTime.Rows.Clear();

                        for (int i = 0; i < lstDeadTimeByFilmProductionPlan.Count; i++)
                        {
                            dgvDeadTime.Rows.Add();

                            dgvDeadTime.Rows[i].Cells[clmDeadTimeLotNumber.Index].Value = lstDeadTimeByFilmProductionPlan[i].lotNumber;
                            dgvDeadTime.Rows[i].Cells[clmDeadTimeInitDate.Index].Value = lstDeadTimeByFilmProductionPlan[i].initDate.ToString("dd/MM/yyyy HH:mm");
                            dgvDeadTime.Rows[i].Cells[clmDeadTimeEndDate.Index].Value = lstDeadTimeByFilmProductionPlan[i].endDate.ToString("dd/MM/yyyy HH:mm");
                            dgvDeadTime.Rows[i].Cells[clmDeadTimeTime.Index].Value = Math.Round(lstDeadTimeByFilmProductionPlan[i].endDate.Subtract(lstDeadTimeByFilmProductionPlan[i].initDate).TotalHours, 2);
                            dgvDeadTime.Rows[i].Cells[clmDeadTimeReason.Index].Value = lstDeadTimeByFilmProductionPlan[i].deadTimeTypeName;
                            dgvDeadTime.Rows[i].Cells[clmDeadTimeGroup.Index].Value = lstDeadTimeByFilmProductionPlan[i].deadTimeGroup;
                            if(lstDeadTimeByFilmProductionPlan[i].deadTimeGroup == "TMP")
                                DeadTimeTMP += Math.Round(lstDeadTimeByFilmProductionPlan[i].endDate.Subtract(lstDeadTimeByFilmProductionPlan[i].initDate).TotalHours, 2);
                            else if(lstDeadTimeByFilmProductionPlan[i].deadTimeGroup == "TMM")
                                DeadTimeTMM += Math.Round(lstDeadTimeByFilmProductionPlan[i].endDate.Subtract(lstDeadTimeByFilmProductionPlan[i].initDate).TotalHours, 2);
                            else
                                DeadTimeTMOtros += Math.Round(lstDeadTimeByFilmProductionPlan[i].endDate.Subtract(lstDeadTimeByFilmProductionPlan[i].initDate).TotalHours, 2);
                        }
                    }
                    lblTmp.Text = DeadTimeTMP.ToString();
                    lblTmm.Text = DeadTimeTMM.ToString();
                    lblTOther.Text = DeadTimeTMOtros.ToString();
                }
                //Efficiency
                lblEfficiency.Text = Convert.ToString(Math.Round(((TotalProduction / (TotalProduction + TotalDecrease)) * 100), 2));
                lblConsumption.Text = Convert.ToString((TotalProduction + TotalDecrease));
            }
        }

        private void GetDataDecrease(List<clsDecreaseByFilmProductionPlan> lstDecreaseByFilmProductionPlan)
        {
            double Waste = 0;
            for (int i = 0; i < lstDecreaseByFilmProductionPlan.Count; i++)
                Waste += lstDecreaseByFilmProductionPlan[i].weight;
            lblTotalWaste.Text = Waste.ToString();
        }

        private TimeSpan RestHours(DateTime InitDate, DateTime EndDate)
        {
            DateTime HourInitDate = InitDate;
            DateTime HourEndDate = EndDate;
            return (HourEndDate.Subtract(InitDate));
        }

        private void ClearTextBoxAndCounts()
        {
            lblProductionTotal.Text = "0";
            lblEfficiency.Text = "0";
            lblConsumption.Text = "0";
            lblTotalWaste.Text = "0";
            lblTmm.Text = "0";
            lblTmp.Text = "0";
            lblTOther.Text = "0";
            TotalProduction = 0;
            TotalDecrease = 0;
            DeadTimeTMP = 0;
            DeadTimeTMM = 0;
            DeadTimeTMOtros = 0;
            lstMainCoil = new List<clsMainCoil>();
            lstDeadTimeByFilmProductionPlan = new List<clsDeadTimeByFilmProductionPlan>();
            lstDecreaseByFilmAndFormulation = new List<decreaseByFilmAndFormulation>();
            lstDecreaseByFilmProductionPlan = new List<clsDecreaseByFilmProductionPlan>();
        }

        private double CalculeEfficiency(double TotProd, double TotCon)
        {
            return ((TotProd / TotCon) * 100);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (dgvMainCoilList.Rows.Count == 0)
                MessageBox.Show("No hay datos en el reporte", "Reporte de Producción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                frmProductionReportView winProductionReport = new frmProductionReportView(objMachine.codsec, Convert.ToDateTime(initDate), Convert.ToDateTime(endDate), Convert.ToDouble(lblConsumption.Text), DeadTimeTMP, DeadTimeTMM, DeadTimeTMOtros, cmbInnig.SelectedIndex.ToString(), Convert.ToDouble(lblEfficiency.Text), TotalDecrease);
                winProductionReport.StartPosition = FormStartPosition.Manual;
                winProductionReport.MdiParent = this.MdiParent;
                winProductionReport.Show();
            }
        }
    }
}
