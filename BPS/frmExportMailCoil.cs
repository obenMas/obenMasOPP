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
    public struct decreaseByFilmAndFormulation
    {
        private int dbfaf_orderNumber;
        private string dbfaf_filmCode;
        private double dbdaf_weight;
        private int dbdaf_fkFormulation;
        private string dbdaf_formulationName;

        public int orderNumber { get { return dbfaf_orderNumber; } set { dbfaf_orderNumber = value; } }

        public string filmCode { get { return dbfaf_filmCode; } set { dbfaf_filmCode = value; } }

        public double weight { get { return dbdaf_weight; } set { dbdaf_weight = value; } }

        public int fkFormulation { get { return dbdaf_fkFormulation; } set { dbdaf_fkFormulation = value; } }

        public string formulationName  { get { return dbdaf_formulationName; } set { dbdaf_formulationName = value; } }

        public decreaseByFilmAndFormulation(int orderNumber, string prmFilmCode, double prmWeight, int prmFkFormulation, string prmFormulationName)
        {
            dbfaf_orderNumber = orderNumber;
            dbfaf_filmCode = prmFilmCode;
            dbdaf_weight = prmWeight;
            dbdaf_fkFormulation = prmFkFormulation;
            dbdaf_formulationName = prmFormulationName;
        }
    }

    public partial class frmExportMailCoil : Form
    {
        public frmExportMailCoil()
        {
            InitializeComponent();
        }

        public DateTime selectedDate;
        public string wasteType;

        private void frmExportMailCoil_Load(object sender, EventArgs e)
        {
            List<clsMachine> lstMachines = clsMachine.getExtruderMachineList();
            cmbMachine.Items.Clear();
            for (int i = 0; i < lstMachines.Count; i++)
                cmbMachine.Items.Add(lstMachines[i]);
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            if (cmbMachine.SelectedIndex >= 0)
            {
                List<clsMainCoil> lstMainCoil = new List<clsMainCoil>();
                List<clsDeadTimeByFilmProductionPlan> lstDeadTimeByFilmProductionPlan = new List<clsDeadTimeByFilmProductionPlan>();
                List<clsDecreaseByFilmProductionPlan> lstDecreaseByFilmProductionPlan = new List<clsDecreaseByFilmProductionPlan>();
                List<clsFilter> lstFilter = new List<clsFilter>();
                List<decreaseByFilmAndFormulation> lstDecreaseByFilmAndFormulation = new List<decreaseByFilmAndFormulation>();

                List<string> lstFilmType = new List<string>();
                Boolean flgInList = false;
                int position = -1;

                lstFilter.Add(new clsFilter());
                lstFilter[0].field = "mcl_initDate";
                lstFilter[0].operation = "between";
                lstFilter[0].value = dtpInitDate.Value.ToString("dd/MM/yyyy HH:mm");
                lstFilter[0].value2 = dtpEndDate.Value.ToString("dd/MM/yyyy HH:mm");
                lstFilter[0].dataType = "dateTime";

                lstFilter.Add(new clsFilter());
                lstFilter[1].field = "mcl_fkMachine";
                lstFilter[1].operation = "equal";
                lstFilter[1].value = ((clsMachine)cmbMachine.SelectedItem).codsec.ToString();
                lstFilter[1].dataType = "int";

                lstMainCoil = clsMainCoil.getBoppMainCoilListByFilter(lstFilter);

                dgvMainCoils.Rows.Clear();
                lstFilmType.Clear();

                for (int i = 0; i < lstMainCoil.Count; i++)
                {
                    List<clsFormulationByFilmProductionPlan> lstFormulations = clsFormulationByFilmProductionPlan.getListByFilmProductionPlan(lstMainCoil[i].fkFilmProductionPlan);

                    dgvMainCoils.Rows.Add();
                    dgvMainCoils.Rows[i].Cells[clmCodsec.Index].Value = lstMainCoil[i].codsec;
                    dgvMainCoils.Rows[i].Cells[clmCode.Index].Value = lstMainCoil[i].code;
                    dgvMainCoils.Rows[i].Cells[clmFilmName.Index].Value = lstMainCoil[i].BoppCode.Replace("-", "");
                    dgvMainCoils.Rows[i].Cells[clmInitDate.Index].Value = lstMainCoil[i].initDate.ToString("dd/MM/yyyy hh:mm");
                    dgvMainCoils.Rows[i].Cells[clmEndDate.Index].Value = lstMainCoil[i].endDate.ToString("dd/MM/yyyy hh:mm");
                    dgvMainCoils.Rows[i].Cells[clmWidth.Index].Value = lstMainCoil[i].width.ToString();
                    dgvMainCoils.Rows[i].Cells[clmLength.Index].Value = Math.Round(lstMainCoil[i].netlength, 2).ToString();
                    dgvMainCoils.Rows[i].Cells[clmWeigth.Index].Value = Math.Round(lstMainCoil[i].netWeigth, 2).ToString();
                    dgvMainCoils.Rows[i].Cells[clmSupervisor.Index].Value = lstMainCoil[i].supervisorName;
                    dgvMainCoils.Rows[i].Cells[clmGramaje.Index].Value = Math.Round(lstMainCoil[i].gramaje, 2).ToString();
                    dgvMainCoils.Rows[i].Cells[clmFormulation.Index].Value = lstFormulations[lstMainCoil[i].variation].formulationName;
                    dgvMainCoils.Rows[i].Cells[clmFormulationCodsec.Index].Value = lstFormulations[lstMainCoil[i].variation].fkFormulation;

                    flgInList = false;

                    for (int j = 0; j < lstFilmType.Count; j++)
                    {
                        if (lstFilmType[j] == lstMainCoil[i].BoppCode.Replace("-", ""))
                            flgInList = true;
                    }

                    if (flgInList == false)
                        lstFilmType.Add(lstMainCoil[i].BoppCode.Replace("-", ""));
                }

                lstFilter = new List<clsFilter>();

                lstFilter.Add(new clsFilter());
                lstFilter[0].field = "dbfpp_createdDate";
                lstFilter[0].operation = "between";
                lstFilter[0].value = dtpInitDate.Value.ToString("dd/MM/yyyy HH:mm");
                lstFilter[0].value2 = dtpEndDate.Value.ToString("dd/MM/yyyy HH:mm");
                lstFilter[0].dataType = "dateTime";

                lstFilter.Add(new clsFilter());
                lstFilter[1].field = "dbfpp_fkMachine";
                lstFilter[1].operation = "equal";
                lstFilter[1].value = ((clsMachine)cmbMachine.SelectedItem).codsec.ToString();
                lstFilter[1].dataType = "int";

                lstDecreaseByFilmProductionPlan = clsDecreaseByFilmProductionPlan.getListByfilter(lstFilter);

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
                        objDecreaseByFilmAndFormulation.weight =  lstDecreaseByFilmProductionPlan[i].weight;
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
                    dgvDecrease.Rows[i].Cells[clmDecreaseFormulation.Index].Value = lstDecreaseByFilmAndFormulation[i].formulationName;
                    dgvDecrease.Rows[i].Cells[clmDecreaseFormulationCodsec.Index].Value = lstDecreaseByFilmAndFormulation[i].fkFormulation;
                }

                lstFilter = new List<clsFilter>();

                lstFilter.Add(new clsFilter());
                lstFilter[0].field = "dtbfpp_initDate";
                lstFilter[0].operation = "between";
                lstFilter[0].value = dtpInitDate.Value.ToString("dd/MM/yyyy HH:mm");
                lstFilter[0].value2 = dtpEndDate.Value.ToString("dd/MM/yyyy HH:mm");
                lstFilter[0].dataType = "dateTime";

                lstFilter.Add(new clsFilter());
                lstFilter[1].field = "dtbfpp_fkMachine";
                lstFilter[1].operation = "equal";
                lstFilter[1].value = ((clsMachine)cmbMachine.SelectedItem).codsec.ToString();
                lstFilter[1].dataType = "int";

                lstDeadTimeByFilmProductionPlan = clsDeadTimeByFilmProductionPlan.getListByFilter(lstFilter);

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
                }
                
            }
            else
            {
                MessageBox.Show("Debe seleccionar la máquina.");
                cmbMachine.Focus();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            List<clsXproMainCoil> lstXproMainCoil = new List<clsXproMainCoil>();

            //Rollos Madre
            for (int i = 0; i < dgvMainCoils.Rows.Count; i++)
            {
                clsMainCoil objmainCoil = new clsMainCoil(Convert.ToInt32(dgvMainCoils.Rows[i].Cells[clmCodsec.Index].Value));
                List<clsFormulationByFilmProductionPlan> lstFormulatiosn = new List<clsFormulationByFilmProductionPlan>();

                lstFormulatiosn = clsFormulationByFilmProductionPlan.getListByFilmProductionPlan(objmainCoil.fkFilmProductionPlan);

                lstXproMainCoil.Add(new clsXproMainCoil());
                lstXproMainCoil[i].orden = objmainCoil.ProductionOrderNumber;
                lstXproMainCoil[i].turno = "";
                lstXproMainCoil[i].fec_in = objmainCoil.initDate;
                lstXproMainCoil[i].fec_fn = objmainCoil.endDate;
                lstXproMainCoil[i].nombre_sup = objmainCoil.supervisorName;
                lstXproMainCoil[i].tipo = objmainCoil.BoppCode.Replace("-", "");
                lstXproMainCoil[i].lote_estru = objmainCoil.lotNumber;
                lstXproMainCoil[i].identific = objmainCoil.code;
                lstXproMainCoil[i].metraje = objmainCoil.netlength;
                lstXproMainCoil[i].kilos = objmainCoil.netWeigth;
                lstXproMainCoil[i].fecha = objmainCoil.createdDate;
                lstXproMainCoil[i].MAQ = (objmainCoil.MachineName == "DMT") ? "DMT No. 01" : "MARSHALL No. 02";
                lstXproMainCoil[i].ancho = objmainCoil.width;
                lstXproMainCoil[i].OBS = (objmainCoil.notes.Length > 50) ? objmainCoil.notes.Substring(0, 50) : objmainCoil.notes;
                lstXproMainCoil[i].ESTADO = "0";
                lstXproMainCoil[i].trata = ((new clsBopp(objmainCoil.fkBopp)).Treatment.abbreviation == "N") ? "N" : ((new clsBopp(objmainCoil.fkBopp)).Treatment.abbreviation == "D") ? "D" : "EXT";
                lstXproMainCoil[i].x1 = (lstFormulatiosn[objmainCoil.variation].formulationName.Length > 10) ? lstFormulatiosn[objmainCoil.variation].formulationName.Substring(0, 10) : lstFormulatiosn[objmainCoil.variation].formulationName;
                lstXproMainCoil[i].x3 = objmainCoil.gramaje;

                List<clsRawMaterialConsumptionByFormulation> lstRawMaterialConsumption = clsRawMaterialConsumptionByFormulation.getRawMaterialConsumptionByFormulation(Convert.ToInt32(dgvMainCoils.Rows[i].Cells[clmFormulationCodsec.Index].Value), objmainCoil.netWeigth);
                List<clsXproRawMaterialConsumption> lstXproRawMaterialConsumption = new List<clsXproRawMaterialConsumption>();

                for (int j = 0; j < lstRawMaterialConsumption.Count; j++)
                {
                    lstXproRawMaterialConsumption.Add(new clsXproRawMaterialConsumption());

                    lstXproRawMaterialConsumption[j].tipmov = "H";
                    lstXproRawMaterialConsumption[j].commov = 1;
                    lstXproRawMaterialConsumption[j].nromov = 999;
                    lstXproRawMaterialConsumption[j].secmov = 1;
                    lstXproRawMaterialConsumption[j].productomo = 40001000001;
                    lstXproRawMaterialConsumption[j].cantidad = lstRawMaterialConsumption[j].consumption;
                    lstXproRawMaterialConsumption[j].bodegamov = 1;
                    lstXproRawMaterialConsumption[j].lote = objmainCoil.lotNumber;
                    lstXproRawMaterialConsumption[j].cargas = "0";
                    lstXproRawMaterialConsumption[j].orden = objmainCoil.ProductionOrderNumber;
                    lstXproRawMaterialConsumption[j].fecha = objmainCoil.createdDate;
                    lstXproRawMaterialConsumption[j].turno = "";
                    lstXproRawMaterialConsumption[j].identifica = objmainCoil.code;
                    lstXproRawMaterialConsumption[j].MAQ = (objmainCoil.MachineName == "DMT") ? "DMT No. 01" : "MARSHALL No. 02"; ;
                    lstXproRawMaterialConsumption[j].REFFCA = lstRawMaterialConsumption[j].rawMaterialEquivalence.externalSystemCode;
                    lstXproRawMaterialConsumption[j].LOTE1 = "";
                    lstXproRawMaterialConsumption[j].LOTE2 = "";
                }

                clsXproRawMaterialConsumption.saveToDatabase(lstXproRawMaterialConsumption);

            }

            //Desperdicios

            int DecreaseSecuential = 31;

            for (int i = 0; i < dgvDecrease.Rows.Count; i++)
			{
                lstXproMainCoil.Add(new clsXproMainCoil());
                lstXproMainCoil[lstXproMainCoil.Count - 1].orden = Convert.ToDouble(dgvDecrease.Rows[i].Cells[clmDecreaseOrderNumber.Index].Value.ToString());
                lstXproMainCoil[lstXproMainCoil.Count - 1].turno = "";
                lstXproMainCoil[lstXproMainCoil.Count - 1].fec_in = dtpInitDate.Value;
                lstXproMainCoil[lstXproMainCoil.Count - 1].fec_fn = dtpEndDate.Value;
                lstXproMainCoil[lstXproMainCoil.Count - 1].nombre_sup = "";
                lstXproMainCoil[lstXproMainCoil.Count - 1].tipo = dgvDecrease.Rows[i].Cells[clmDecreaseFilmType.Index].Value.ToString();
                lstXproMainCoil[lstXproMainCoil.Count - 1].lote_estru = "";
                lstXproMainCoil[lstXproMainCoil.Count - 1].identific = "DSP00" + clsGlobal.FillWithZeros(DecreaseSecuential.ToString(), 3);
                lstXproMainCoil[lstXproMainCoil.Count - 1].metraje = 0;
                lstXproMainCoil[lstXproMainCoil.Count - 1].kilos = 0.01;//Convert.ToDouble(dgvDecrease.Rows[i].Cells[clmDecreaseQuantity.Index].Value);
                lstXproMainCoil[lstXproMainCoil.Count - 1].fecha = dtpInitDate.Value;
                lstXproMainCoil[lstXproMainCoil.Count - 1].MAQ = (cmbMachine.Text == "DMT") ? "DMT No. 01" : "MARSHALL No. 02"; 
                lstXproMainCoil[lstXproMainCoil.Count - 1].ancho = 0;
                lstXproMainCoil[lstXproMainCoil.Count - 1].OBS = "";
                lstXproMainCoil[lstXproMainCoil.Count - 1].ESTADO = "0";
                lstXproMainCoil[lstXproMainCoil.Count - 1].trata = "N";
                lstXproMainCoil[lstXproMainCoil.Count - 1].x1 = (dgvDecrease.Rows[i].Cells[clmDecreaseFormulation.Index].Value.ToString().Length > 10) ? dgvDecrease.Rows[i].Cells[clmDecreaseFormulation.Index].Value.ToString().Substring(0, 10) : dgvDecrease.Rows[i].Cells[clmDecreaseFormulation.Index].Value.ToString();
                lstXproMainCoil[lstXproMainCoil.Count - 1].x3 = 0;

                List<clsRawMaterialConsumptionByFormulation> lstRawMaterialConsumption = clsRawMaterialConsumptionByFormulation.getRawMaterialConsumptionByFormulation(Convert.ToInt32(dgvDecrease.Rows[i].Cells[clmDecreaseFormulationCodsec.Index].Value), Convert.ToDouble(dgvDecrease.Rows[i].Cells[clmDecreaseQuantity.Index].Value));
                List<clsXproRawMaterialConsumption> lstXproRawMaterialConsumption = new List<clsXproRawMaterialConsumption>();

                for (int j = 0; j < lstRawMaterialConsumption.Count; j++)
                {
                    lstXproRawMaterialConsumption.Add(new clsXproRawMaterialConsumption());

                    lstXproRawMaterialConsumption[j].tipmov = "H";
                    lstXproRawMaterialConsumption[j].commov = 1;
                    lstXproRawMaterialConsumption[j].nromov = 999;
                    lstXproRawMaterialConsumption[j].secmov = 1;
                    lstXproRawMaterialConsumption[j].productomo = 40001000001;
                    lstXproRawMaterialConsumption[j].cantidad = lstRawMaterialConsumption[j].consumption;
                    lstXproRawMaterialConsumption[j].bodegamov = 1;
                    lstXproRawMaterialConsumption[j].lote = "";
                    lstXproRawMaterialConsumption[j].cargas = "0";
                    lstXproRawMaterialConsumption[j].orden = Convert.ToDouble(dgvDecrease.Rows[i].Cells[clmDecreaseOrderNumber.Index].Value.ToString());
                    lstXproRawMaterialConsumption[j].fecha = dtpInitDate.Value;
                    lstXproRawMaterialConsumption[j].turno = "";
                    lstXproRawMaterialConsumption[j].identifica = "DSP00" + clsGlobal.FillWithZeros(DecreaseSecuential.ToString(), 3);
                    lstXproRawMaterialConsumption[j].MAQ = (cmbMachine.Text == "DMT") ? "DMT No. 01" : "MARSHALL No. 02"; ;
                    lstXproRawMaterialConsumption[j].REFFCA = lstRawMaterialConsumption[j].rawMaterialEquivalence.externalSystemCode;
                    lstXproRawMaterialConsumption[j].LOTE1 = "";
                    lstXproRawMaterialConsumption[j].LOTE2 = "";
                }

                clsXproRawMaterialConsumption.saveToDatabase(lstXproRawMaterialConsumption);
                DecreaseSecuential++;
			}


            //Tiempo Muerto
            for (int i = 0; i < dgvDeadTime.Rows.Count; i++)
            {
                switch (dgvDeadTime.Rows[i].Cells[clmDeadTimeGroup.Index].Value.ToString())
                {
                    case "TMM":
                        lstXproMainCoil.Add(new clsXproMainCoil());
                        lstXproMainCoil[lstXproMainCoil.Count - 1].orden = 999999;
                        lstXproMainCoil[lstXproMainCoil.Count - 1].turno = "";
                        lstXproMainCoil[lstXproMainCoil.Count - 1].fec_in = Convert.ToDateTime(dgvDeadTime.Rows[i].Cells[clmDeadTimeInitDate.Index].Value.ToString());
                        lstXproMainCoil[lstXproMainCoil.Count - 1].fec_fn = Convert.ToDateTime(dgvDeadTime.Rows[i].Cells[clmDeadTimeEndDate.Index].Value.ToString());
                        lstXproMainCoil[lstXproMainCoil.Count - 1].nombre_sup = "";
                        lstXproMainCoil[lstXproMainCoil.Count - 1].tipo = "TMM";
                        lstXproMainCoil[lstXproMainCoil.Count - 1].lote_estru = "01109991";
                        lstXproMainCoil[lstXproMainCoil.Count - 1].identific = "0.01";
                        lstXproMainCoil[lstXproMainCoil.Count - 1].metraje = 0;
                        lstXproMainCoil[lstXproMainCoil.Count - 1].kilos = 0;
                        lstXproMainCoil[lstXproMainCoil.Count - 1].fecha = dtpInitDate.Value;
                        lstXproMainCoil[lstXproMainCoil.Count - 1].MAQ = (cmbMachine.Text == "DMT") ? "DMT No. 01" : "MARSHALL No. 02"; ;
                        lstXproMainCoil[lstXproMainCoil.Count - 1].ancho = 0;
                        lstXproMainCoil[lstXproMainCoil.Count - 1].OBS = dgvDeadTime.Rows[i].Cells[clmDeadTimeReason.Index].Value.ToString();
                        lstXproMainCoil[lstXproMainCoil.Count - 1].ESTADO = "0";
                        lstXproMainCoil[lstXproMainCoil.Count - 1].trata = "N";
                        lstXproMainCoil[lstXproMainCoil.Count - 1].x1 = "TM-1";
                        lstXproMainCoil[lstXproMainCoil.Count - 1].x3 = 0;
                        break;
                    case "TMP":
                        lstXproMainCoil.Add(new clsXproMainCoil());
                        lstXproMainCoil[lstXproMainCoil.Count - 1].orden = 999998;
                        lstXproMainCoil[lstXproMainCoil.Count - 1].turno = cmbTurn.Text;
                        lstXproMainCoil[lstXproMainCoil.Count - 1].fec_in = Convert.ToDateTime(dgvDeadTime.Rows[i].Cells[clmDeadTimeInitDate.Index].Value.ToString());
                        lstXproMainCoil[lstXproMainCoil.Count - 1].fec_fn = Convert.ToDateTime(dgvDeadTime.Rows[i].Cells[clmDeadTimeEndDate.Index].Value.ToString());
                        lstXproMainCoil[lstXproMainCoil.Count - 1].nombre_sup = "";
                        lstXproMainCoil[lstXproMainCoil.Count - 1].tipo = "TMP";
                        lstXproMainCoil[lstXproMainCoil.Count - 1].lote_estru = "01109981";
                        lstXproMainCoil[lstXproMainCoil.Count - 1].identific = "0.01";
                        lstXproMainCoil[lstXproMainCoil.Count - 1].metraje = 0;
                        lstXproMainCoil[lstXproMainCoil.Count - 1].kilos = 0;
                        lstXproMainCoil[lstXproMainCoil.Count - 1].fecha = dtpInitDate.Value;
                        lstXproMainCoil[lstXproMainCoil.Count - 1].MAQ = (cmbMachine.Text == "DMT") ? "DMT No. 01" : "MARSHALL No. 02"; ;
                        lstXproMainCoil[lstXproMainCoil.Count - 1].ancho = 0;
                        lstXproMainCoil[lstXproMainCoil.Count - 1].OBS = dgvDeadTime.Rows[i].Cells[clmDeadTimeReason.Index].Value.ToString();
                        lstXproMainCoil[lstXproMainCoil.Count - 1].ESTADO = "0";
                        lstXproMainCoil[lstXproMainCoil.Count - 1].trata = "N";
                        lstXproMainCoil[lstXproMainCoil.Count - 1].x1 = "TM-1";
                        lstXproMainCoil[lstXproMainCoil.Count - 1].x3 = 0;
                        break;
                    case "TMOtros":
                        lstXproMainCoil.Add(new clsXproMainCoil());
                        lstXproMainCoil[lstXproMainCoil.Count - 1].orden = 999997;
                        lstXproMainCoil[lstXproMainCoil.Count - 1].turno = "";
                        lstXproMainCoil[lstXproMainCoil.Count - 1].fec_in = Convert.ToDateTime(dgvDeadTime.Rows[i].Cells[clmDeadTimeInitDate.Index].Value.ToString());
                        lstXproMainCoil[lstXproMainCoil.Count - 1].fec_fn = Convert.ToDateTime(dgvDeadTime.Rows[i].Cells[clmDeadTimeEndDate.Index].Value.ToString());
                        lstXproMainCoil[lstXproMainCoil.Count - 1].nombre_sup = "";
                        lstXproMainCoil[lstXproMainCoil.Count - 1].tipo = "TMOtros";
                        lstXproMainCoil[lstXproMainCoil.Count - 1].lote_estru = "01109971";
                        lstXproMainCoil[lstXproMainCoil.Count - 1].identific = "0.01";
                        lstXproMainCoil[lstXproMainCoil.Count - 1].metraje = 0;
                        lstXproMainCoil[lstXproMainCoil.Count - 1].kilos = 0;
                        lstXproMainCoil[lstXproMainCoil.Count - 1].fecha = dtpInitDate.Value;
                        lstXproMainCoil[lstXproMainCoil.Count - 1].MAQ = (cmbMachine.Text == "DMT") ? "DMT No. 01" : "MARSHALL No. 02";
                        lstXproMainCoil[lstXproMainCoil.Count - 1].ancho = 0;
                        lstXproMainCoil[lstXproMainCoil.Count - 1].OBS = dgvDeadTime.Rows[i].Cells[clmDeadTimeReason.Index].Value.ToString();
                        lstXproMainCoil[lstXproMainCoil.Count - 1].ESTADO = "0";
                        lstXproMainCoil[lstXproMainCoil.Count - 1].trata = "N";
                        lstXproMainCoil[lstXproMainCoil.Count - 1].x1 = "TM-1";
                        lstXproMainCoil[lstXproMainCoil.Count - 1].x3 = 0;
                        break;

                }
            }
            
            if (clsXproMainCoil.saveToDatabase(lstXproMainCoil))
            {
                MessageBox.Show("Se ha exportado los datos con éxito.", "Exportación de datos al sistema XPROWare", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            else
            {
                MessageBox.Show("Ha habido un problema al guardar los datos.", "Exportación de datos al sistema XPROWare", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void cmbMachine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsMachine> lstMachines = clsMachine.getExtruderMachineList();
                cmbMachine.Items.Clear();
                for (int i = 0; i < lstMachines.Count; i++)
                    cmbMachine.Items.Add(lstMachines[i]); 
            }
        }
    }
}
