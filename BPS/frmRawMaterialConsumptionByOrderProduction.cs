using System;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmRawMaterialConsumptionByOrderProduction : Form
    {
        clsMachine objMachine = new clsMachine();
        clsFilmProductionPlanByProductionOrder objFilmProductionPlanByProductionOrder = new clsFilmProductionPlanByProductionOrder();
        clsRawMaterialConsumptionByExtruder objRawMaterialConsumptionByOrderProduction = new clsRawMaterialConsumptionByExtruder();
        clsFilmProductionPlan objFilmProductionPlan = new clsFilmProductionPlan();
        clsTransfer objTransfer = new clsTransfer();
        int machCodsec = 0;

        public int selectedRawMaterial = 0;
        public int selectedCellar = 0;

        public frmRawMaterialConsumptionByOrderProduction()
        {
            InitializeComponent();
        }

        public bool validateForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref dgvDeliver, ref grpbAdd, "isValid")) isValid = false;

            return isValid;
        }

        clsKardex objKardex = new clsKardex();
        clsDeliverRawMaterial objDeliverRawMaterial = new clsDeliverRawMaterial();

        string batch = "";
        string year = "";
        string month = "";
        string day = "";
        string secuencial = "";

        private string loadNumber()
        {
            string initial = "CMP-";
            string separator = "-";
            int newSecuencial = 0;
            int a = 0;

            batch = objRawMaterialConsumptionByOrderProduction.getLastBatch();

            if (batch == "")
            {
                secuencial = "0001";
                year = DateTime.Now.ToString("yy");
                month = DateTime.Now.ToString("MM");
                day = DateTime.Now.ToString("dd");
                switch (month)
                {
                    case "10":
                        month = "A";
                        break;

                    case "11":
                        month = "B";
                        break;

                    case "12":
                        month = "C";
                        break;
                    default:
                        month = month.Substring(1, 1);
                        break;
                }
                batch = initial + year + month + day + separator + secuencial;
            }
            else
            {
                year = DateTime.Now.ToString("yy");
                month = DateTime.Now.ToString("MM");
                day = DateTime.Now.ToString("dd");
                switch (month)
                {
                    case "10":
                        month = "A";
                        break;

                    case "11":
                        month = "B";
                        break;

                    case "12":
                        month = "C";
                        break;
                    default:
                        month = month.Substring(1, 1);
                        break;
                }

                secuencial = batch.Substring(8, 4);
                newSecuencial = int.Parse(secuencial);
                newSecuencial = newSecuencial + 1;
                secuencial = newSecuencial.ToString();
                a = secuencial.Length;

                switch (a)
                {
                    case 1:
                        secuencial = "000" + secuencial;
                        break;

                    case 2:
                        secuencial = "00" + secuencial;

                        break;

                    case 3:
                        secuencial = "0" + secuencial;
                        break;

                    default:
                        break;
                }
                batch = initial + year + month + day + separator + secuencial;
            }

            return batch;
        }

        public frmRawMaterialConsumptionByOrderProduction(int machineCodsec)
        {
            InitializeComponent();
            objMachine.load(machineCodsec, "Extruder");
            objFilmProductionPlanByProductionOrder = clsFilmProductionPlanByProductionOrder.getActiveOrderByMachine(machineCodsec);
            machCodsec = machineCodsec;
        }

        private void frmRawMaterialConsumptionByOrderProduction_Load(object sender, EventArgs e)
        {
            batch = "";
            year = "";
            month = "";
            day = "";
            secuencial = "";
            txtNumber.Text = loadNumber();
            txtFilmProduction.Text = objFilmProductionPlanByProductionOrder.BoppCode.ToString();
            txtOrderProduction.Text = objFilmProductionPlanByProductionOrder.OrderNumber.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {


        }


        private void dgvDeliver_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 5:
                    if (clsGlobal.isNumeric(e.FormattedValue.ToString()) == false && e.FormattedValue.ToString() != "")
                    {
                        MessageBox.Show("El valor debe ser Numerico");
                        dgvDeliver.CancelEdit();
                    }
                    break;
            }
        }
    }
}