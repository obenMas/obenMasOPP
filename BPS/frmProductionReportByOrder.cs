using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms; 
using BPS.Bussiness;

namespace BPS
{
    public partial class frmProductionReportByOrder : Form
    {
        private DateTime InitDatePrm, EndDatePrm;
        double TMM = 0, TMP = 0, TMOtros = 0, TotalHours = 0, ProductionHours, Nethours = 0, Efficiency = 0, TotalWeigth = 0, TotalQuantity = 0, DecreaseWeigth = 0, MatEfficiency = 0, Decrease = 0, DecreasePorcent = 0, Consuption = 0, Performance = 0;
        int KilogramPerHour = 0, fkFilmProductionPlan = 0;
        string FilmProductionPlanName = "";
        clsMachine ObjMachine = new clsMachine();
        public frmProductionReportByOrder()
        {
            InitializeComponent();
        }

        public frmProductionReportByOrder(int MachineCodsec)
        {
            InitializeComponent();
            ObjMachine.load(MachineCodsec, "Extruder");
            GetMachineName(MachineCodsec);
            FillLots(MachineCodsec);
        }

        private void FillLots(int MachineCodsec)
        {
            List<clsFilter> lstFilter = new List<clsFilter>();
            List<clsFilmProductionPlan> lstFilmProductionPlan = new List<clsFilmProductionPlan>();

            lstFilter.Add(new clsFilter());
            lstFilter[lstFilter.Count - 1].field = "fpo_fkMachine";
            lstFilter[lstFilter.Count - 1].operation = "equal";
            lstFilter[lstFilter.Count - 1].value = MachineCodsec.ToString();
            lstFilter[lstFilter.Count - 1].dataType = "int";

            lstFilmProductionPlan = clsFilmProductionPlan.getFilmProductionPlanListByFilter(lstFilter);
            cmbOrder.Items.Clear();

            if (lstFilmProductionPlan.Count != 0)
            {
                for (int i = 0; i < lstFilmProductionPlan.Count; i++)
                    cmbOrder.Items.Add(lstFilmProductionPlan[i]);
            }
        }

        private void GetMachineName(int MachineCodsec)
        {
            List<clsMachine> lstMachine = clsMachine.getExtruderMachineList();
            for (int i = 0; i < lstMachine.Count; i++)
            {
                if (lstMachine[i].codsec == MachineCodsec)
                    lblMachineName.Text = lstMachine[i].Extruder.name;
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            NewReport();
            List<clsFilter> lstFilter = new List<clsFilter>();
            List<clsMainCoil> lstMainCoil = new List<clsMainCoil>();
            List<clsMachine> lstMachine = new List<clsMachine>();
            List<clsExtruder> lstExtruder = new List<clsExtruder>();
            List<clsDecreaseByFilmProductionPlan> lstDecreaseByFilmProductionPlan = new List<clsDecreaseByFilmProductionPlan>();
            List<clsDeadTimeByFilmProductionPlan> lstDeadTimeByFilmProductionPlan = new List<clsDeadTimeByFilmProductionPlan>();

            lstFilter.Add(new clsFilter());
            lstFilter[lstFilter.Count - 1].field = "mcl_fkMachine";
            lstFilter[lstFilter.Count - 1].operation = "equal";
            lstFilter[lstFilter.Count - 1].value = ObjMachine.codsec.ToString();
            lstFilter[lstFilter.Count - 1].dataType = "int";

            lstFilter.Add(new clsFilter());
            lstFilter[lstFilter.Count - 1].field = "mcl_fkFilmProductionPlan";
            lstFilter[lstFilter.Count - 1].operation = "equal";
            lstFilter[lstFilter.Count - 1].value = (((clsFilmProductionPlan)cmbOrder.SelectedItem).codsec).ToString();
            lstFilter[lstFilter.Count - 1].dataType = "int";
            lstMainCoil = clsMainCoil.getBoppMainCoilListByFilter(lstFilter);
            lstFilter.Clear();

            lstFilter.Add(new clsFilter());
            lstFilter[lstFilter.Count - 1].field = "dbfpp_fkMachine";
            lstFilter[lstFilter.Count - 1].operation = "equal";
            lstFilter[lstFilter.Count - 1].value = ObjMachine.codsec.ToString();
            lstFilter[lstFilter.Count - 1].dataType = "int";

            lstFilter.Add(new clsFilter());
            lstFilter[lstFilter.Count - 1].field = "dbfpp_fkFilmProductionPlan";
            lstFilter[lstFilter.Count - 1].operation = "equal";
            lstFilter[lstFilter.Count - 1].value = (((clsFilmProductionPlan)cmbOrder.SelectedItem).codsec).ToString();
            lstFilter[lstFilter.Count - 1].dataType = "int";
            lstDecreaseByFilmProductionPlan = clsDecreaseByFilmProductionPlan.getListByfilter(lstFilter);
            lstFilter.Clear();

            lstFilter.Add(new clsFilter());
            lstFilter[lstFilter.Count - 1].field = "dtbfpp_fkMachine";
            lstFilter[lstFilter.Count - 1].operation = "equal";
            lstFilter[lstFilter.Count - 1].value = ObjMachine.codsec.ToString();
            lstFilter[lstFilter.Count - 1].dataType = "int";

            lstFilter.Add(new clsFilter());
            lstFilter[lstFilter.Count - 1].field = "dtbfpp_fkFilmProductionPlan";
            lstFilter[lstFilter.Count - 1].operation = "equal";
            lstFilter[lstFilter.Count - 1].value = (((clsFilmProductionPlan)cmbOrder.SelectedItem).codsec).ToString();
            lstFilter[lstFilter.Count - 1].dataType = "int";
            lstDeadTimeByFilmProductionPlan = clsDeadTimeByFilmProductionPlan.getListByFilter(lstFilter);

            lstFilter.Add(new clsFilter());
            lstFilter[lstFilter.Count - 1].field = "dtbfpp_fkFilmProductionPlan";
            lstFilter[lstFilter.Count - 1].operation = "equal";
            lstFilter[lstFilter.Count - 1].value = (((clsFilmProductionPlan)cmbOrder.SelectedItem).codsec).ToString();
            lstFilter[lstFilter.Count - 1].dataType = "int";

            fkFilmProductionPlan = (((clsFilmProductionPlan)cmbOrder.SelectedItem).codsec);
            TotalQuantity = clsMainCoil.getaccumulatedbyfilproductionplan(fkFilmProductionPlan);
            dgvMainCoil.Rows.Clear();
            
            if (lstMainCoil.Count != 0)
            {
                for (int i = 0; i < lstMainCoil.Count; i++)
                {                    
                    dgvMainCoil.Rows.Add();
                    dgvMainCoil.Rows[i].Cells[clmCodsecMainCoil.Index].Value = lstMainCoil[i].codsec;
                    var codsec1 = lstMainCoil[i].codsec;
                    var filproductionplan = lstMainCoil[i].fkFilmProductionPlan;
                    dgvMainCoil.Rows[i].Cells[clmLotNumber.Index].Value = lstMainCoil[i].lotNumber;
                    dgvMainCoil.Rows[i].Cells[clmBoppCode.Index].Value = lstMainCoil[i].BoppCode.ToString().Replace("-", "");
                    FilmProductionPlanName = lstMainCoil[i].BoppCode.ToString().Replace("-", "");
                    dgvMainCoil.Rows[i].Cells[clmTotalWeigth.Index].Value = lstMainCoil[i].FilmProductionPlanTotalWeigth;
                    TotalWeigth = lstMainCoil[i].FilmProductionPlanTotalWeigth;
                    if (dgvMainCoil.Rows[i].Cells[clmInitDate.Index] == dgvMainCoil.Rows[0].Cells[clmInitDate.Index])
                    {
                        EndDatePrm = Convert.ToDateTime(lstMainCoil[i].endDate.ToString());
                    }
                    dgvMainCoil.Rows[i].Cells[clmInitDate.Index].Value = lstMainCoil[i].initDate.ToString();
                    dgvMainCoil.Rows[i].Cells[clmEndDate.Index].Value = lstMainCoil[i].endDate.ToString();
                    dgvMainCoil.Rows[i].Cells[clmEndDate.Index].Value = lstMainCoil[i].endDate.ToString();
                }
                InitDatePrm = Convert.ToDateTime(dgvMainCoil.Rows[lstMainCoil.Count - 1].Cells[clmInitDate.Index].Value);
                TotalHours = Convert.ToDouble(Math.Round(RestHours(InitDatePrm, EndDatePrm).TotalHours, 2));
                dgvDecrease.Rows.Clear();
                for (int i = 0; i < lstDecreaseByFilmProductionPlan.Count; i++)
                {
                    dgvDecrease.Rows.Add();
                    dgvDecrease.Rows[i].Cells[clmDecreaseName.Index].Value = lstDecreaseByFilmProductionPlan[i].decreaseName;
                    dgvDecrease.Rows[i].Cells[clmDecreaseWeigth.Index].Value = lstDecreaseByFilmProductionPlan[i].weight;
                    DecreaseWeigth += lstDecreaseByFilmProductionPlan[i].weight;
                    dgvDecrease.Rows[i].Cells[clmDeacreseDate.Index].Value = lstDecreaseByFilmProductionPlan[i].createdDate.ToString("dd/MM/yyyy HH:mm");
                }

                dgvDeadTime.Rows.Clear();
                for (int i = 0; i < lstDeadTimeByFilmProductionPlan.Count; i++)
                {
                    dgvDeadTime.Rows.Add();
                    dgvDeadTime.Rows[i].Cells[clmDeadTimeName.Index].Value = lstDeadTimeByFilmProductionPlan[i].deadTimeTypeName;
                    dgvDeadTime.Rows[i].Cells[clmDeadTimeInitDate.Index].Value = lstDeadTimeByFilmProductionPlan[i].initDate.ToString("dd/MM/yyyy HH:mm");
                    dgvDeadTime.Rows[i].Cells[clmDeadTimeEndDate.Index].Value = lstDeadTimeByFilmProductionPlan[i].endDate.ToString("dd/MM/yyyy HH:mm");
                    dgvDeadTime.Rows[i].Cells[clmDeadTimeAbreviation.Index].Value = lstDeadTimeByFilmProductionPlan[i].deadTimeGroup;
                    
                    if (lstDeadTimeByFilmProductionPlan[i].deadTimeGroup.ToString() == "TMM")
                        TMM += Convert.ToDouble(Math.Round(RestHours(Convert.ToDateTime(lstDeadTimeByFilmProductionPlan[i].initDate.ToString("dd/MM/yyyy HH:mm")), Convert.ToDateTime(lstDeadTimeByFilmProductionPlan[i].endDate.ToString("dd/MM/yyyy HH:mm"))).TotalHours, 2));
                    else
                    {
                        if (lstDeadTimeByFilmProductionPlan[i].deadTimeGroup.ToString() == "TMP")
                            TMP += Convert.ToDouble(Math.Round(RestHours(Convert.ToDateTime(lstDeadTimeByFilmProductionPlan[i].initDate.ToString("dd/MM/yyyy HH:mm")), Convert.ToDateTime(lstDeadTimeByFilmProductionPlan[i].endDate.ToString("dd/MM/yyyy HH:mm"))).TotalHours, 2));
                        else
                        {
                            if (lstDeadTimeByFilmProductionPlan[i].deadTimeGroup.ToString() == "TMOtros")
                                TMOtros += Convert.ToDouble(Math.Round(RestHours(Convert.ToDateTime(lstDeadTimeByFilmProductionPlan[i].initDate.ToString("dd/MM/yyyy HH:mm")), Convert.ToDateTime(lstDeadTimeByFilmProductionPlan[i].endDate.ToString("dd/MM/yyyy HH:mm"))).TotalHours, 2));
                        }
                    }
                }
            }

            ProductionHours = TotalHours - (TMM + TMOtros);
            Nethours = TotalHours - TMP;
            Efficiency = (Nethours / ProductionHours) * 100;
            Consuption = TotalQuantity + DecreaseWeigth;
            MatEfficiency = TotalQuantity / Consuption;
            Decrease = Consuption - TotalQuantity;
            DecreasePorcent = (Decrease / Consuption) * 100;
            lstExtruder = clsExtruder.getExtruderListByMachine(ObjMachine.codsec);
            
            for (int i = 0; i < lstExtruder.Count; i++)
                KilogramPerHour = Convert.ToInt32(lstExtruder[i].kilogramsPerHour);

            if (txtKilogramsPerHour.Text == "" || txtKilogramsPerHour.Text.Length == 0)
                MessageBox.Show("Debe ingresar un valor en Producción (Kg/h)", "Reporte de Producción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                Performance = Convert.ToDouble(txtKilogramsPerHour.Text) / KilogramPerHour;
        }

        private TimeSpan RestHours(DateTime InitDate, DateTime EndDate)
        {
            DateTime HourInitDate = InitDate;
            DateTime HourEndDate = EndDate;
            return (HourEndDate.Subtract(InitDate));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (txtKilogramsPerHour.Text != "")
            {
                frmProductionReportByOrderView winProductionReportByOrder = new frmProductionReportByOrderView(Convert.ToInt32(txtKilogramsPerHour.Text), fkFilmProductionPlan);
                winProductionReportByOrder.StartPosition = FormStartPosition.Manual;
                winProductionReportByOrder.MdiParent = this.MdiParent;
                winProductionReportByOrder.Show();

                //frmProductionReportByOrderViewBCK winProductionReportByOrder = new frmProductionReportByOrderViewBCK(TMM, TMP, TMOtros, TotalHours, ProductionHours, Nethours, Efficiency, TotalWeigth, TotalQuantity, MatEfficiency, Decrease, DecreasePorcent, Consuption, Performance, KilogramPerHour, Convert.ToInt32(txtKilogramsPerHour.Text), InitDatePrm, EndDatePrm, FilmProductionPlanName, fkFilmProductionPlan);
                //winProductionReportByOrder.StartPosition = FormStartPosition.Manual;
                //winProductionReportByOrder.Show();
            }
            else
                MessageBox.Show("Debe ingresar un valor en Producción (Kg/h)", "Reporte de Producción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void NewReport()
        {
            TMM = 0;
            TMP = 0; 
            TMOtros = 0;
            TotalHours = 0;
            ProductionHours = 0;
            Nethours = 0;
            Efficiency = 0;
            TotalWeigth = 0;
            TotalQuantity = 0;
            DecreaseWeigth = 0;
            MatEfficiency = 0;
            Decrease = 0;
            DecreasePorcent = 0;
            Consuption = 0;
            Performance = 0;
            KilogramPerHour = 0;
            fkFilmProductionPlan = 0;
            FilmProductionPlanName = "";
        }

        private void gpbMainLots_Enter(object sender, EventArgs e)
        {

        }
    }
}
