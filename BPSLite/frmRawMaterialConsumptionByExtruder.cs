using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS.Lite
{
    public partial class frmRawMaterialConsumptionByExtruder : Form
    {
        clsMachine objMachine = new clsMachine();
        clsFilmProductionPlanByProductionOrder objFilmProductionPlanByProductionOrder = new clsFilmProductionPlanByProductionOrder();
        clsRawMaterialConsumptionByExtruder objRawMaterialConsumptionByExtruder = new clsRawMaterialConsumptionByExtruder();
        clsFilmProductionPlan objFilmProductionPlan = new clsFilmProductionPlan();
        clsTransfer objTransfer = new clsTransfer();
        int machCodsec = 0;
        int bandera = 0;
        List<clsExtruder> lstExtruder = new List<clsExtruder>();
        List<clsRawMaterialStockProduction> lstRawMaterialStockProduction = new List<clsRawMaterialStockProduction>();



        public int selectedRawMaterial = 0;
        public int selectedCellar = 0;
        private double balance = 0;
        private string batch = "";
        private string year = "";
        private string month = "";
        private string day = "";
        private string secuencial = "";




        public frmRawMaterialConsumptionByExtruder()
        {
            InitializeComponent();
        }

        public bool validateForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref dgvDeliver, ref grpbRawMaterialConsumptionForm, "isValid")) isValid = false;

            return isValid;
        }

        clsKardex objKardex = new clsKardex();
        clsDeliverRawMaterial objDeliverRawMaterial = new clsDeliverRawMaterial();


        private string loadNumber()
        {
            string initial = "CMP-";
            string separator = "-";
            int newSecuencial = 0;
            int a = 0;

            batch = objRawMaterialConsumptionByExtruder.getLastBatch();

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

                secuencial = batch.Substring(10, 4);
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

        public frmRawMaterialConsumptionByExtruder(int machineCodsec)
        {
            InitializeComponent();
            objMachine.load(machineCodsec, "Extruder");
            objFilmProductionPlanByProductionOrder = clsFilmProductionPlanByProductionOrder.getActiveOrderByMachine(machineCodsec);
            lstExtruder = clsExtruder.getExtruderListByMachine(machineCodsec);
            machCodsec = machineCodsec;

        }




        private void loadConsumptionByExtruder()
        {


        }

        private void frmRawMaterialConsumptionByExtruder_Load(object sender, EventArgs e)
        {
            batch = "";
            year = "";
            month = "";
            day = "";
            secuencial = "";
            //  txtRawMaterialConsumptionCode.Text = loadNumber();
            txtRawMaterialConsumptionProduct.Text = objFilmProductionPlanByProductionOrder.BoppCode.ToString();
            txtRawMaterialConsumptionProdOrder.Text = objFilmProductionPlanByProductionOrder.OrderNumber.ToString();
            txtRawMaterialConsumptionMachine.Text = lstExtruder[0].name.ToString();
        }

        private void dgvDeliver_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            clsRawMaterial objRawMaterial = new clsRawMaterial();

            frmRawMaterialSelector winRawMaterialSelector = new frmRawMaterialSelector(this);
            winRawMaterialSelector.ShowDialog(this);
            objRawMaterial.load(selectedRawMaterial);


            if (objRawMaterial.codsec > 0)
            {
                List<clsRawMaterialConsumptionByExtruder> lstRawMaterialConsumptionByExtruder = new List<clsRawMaterialConsumptionByExtruder>();
                lstRawMaterialConsumptionByExtruder = clsRawMaterialConsumptionByExtruder.getStockByExtruderAndRawMaterial(lstExtruder[0].codsec, objRawMaterial.codsec);
                dgvDeliver.CurrentRow.Cells[clmRawMaterialConsumptionCodsec.Index].Value = objRawMaterial.codsec;
                dgvDeliver.CurrentRow.Cells[clmRawMaterialConsumptionRMType.Index].Value = objRawMaterial.RawMaterialtypeName;
                dgvDeliver.CurrentRow.Cells[clmRawMaterialConsumptionRM.Index].Value = objRawMaterial.code;
                if (lstRawMaterialConsumptionByExtruder.Count == 0)
                    dgvDeliver.CurrentRow.Cells[clmRawMaterialConsumptionEnableQ.Index].Value = 0;
                else
                    dgvDeliver.CurrentRow.Cells[clmRawMaterialConsumptionEnableQ.Index].Value = lstRawMaterialConsumptionByExtruder[0].available;
                balance = Convert.ToDouble(lstRawMaterialConsumptionByExtruder[0].consumed);

            }


        }

        private void btnMainCoilSave_Click(object sender, EventArgs e)
        {

            for (int j = 0; j < dgvDeliver.Rows.Count; j++)
            {


                if ((Convert.ToInt32(dgvDeliver.Rows[j].Cells[clmRawMaterialConsumptionEnableQ.Index].Value) < Convert.ToInt32(dgvDeliver.Rows[j].Cells[clmRawMaterialConsumptionQuantity.Index].Value)))
                {
                    bandera++;
                }
            }
            if (bandera != 0)
                MessageBox.Show("No puede despachar mas de la cantidad disponible. Verifique la informacion", "Consumo Materia Prima", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

            else
            {
                for (int i = 0; i < dgvDeliver.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dgvDeliver.Rows[i].Cells[clmRawMaterialConsumptionCodsec.Index].Value) != 0 & bandera == 0)
                    {
                        batch = "";
                        year = "";
                        month = "";
                        day = "";
                        secuencial = "";
                        balance = balance + Convert.ToDouble(dgvDeliver.Rows[i].Cells[clmRawMaterialConsumptionQuantity.Index].Value);

                        List<clsCellarByExtruder> lstCellarByExtruder = new List<clsCellarByExtruder>();
                        lstCellarByExtruder = clsCellarByExtruder.getListConsumptionByExtruder(lstExtruder[0].codsec);
                        List<clsCellarByExtruder> lstCellarByExtruderConsumption = new List<clsCellarByExtruder>();
                        lstCellarByExtruderConsumption = clsCellarByExtruder.getListConsumptionByExtruder(lstExtruder[0].codsec);

                        txtRawMaterialConsumptionCode.Text = loadNumber();
                        objRawMaterialConsumptionByExtruder.number = txtRawMaterialConsumptionCode.Text;
                        objRawMaterialConsumptionByExtruder.fkCellar = Convert.ToInt32(lstCellarByExtruder[0].fkCellar);
                        objRawMaterialConsumptionByExtruder.fkProductionOrder = Convert.ToInt32(objFilmProductionPlanByProductionOrder.fkProductionOrder);
                        objRawMaterialConsumptionByExtruder.fkRawMaterial = Convert.ToInt32(dgvDeliver.Rows[i].Cells[clmRawMaterialConsumptionCodsec.Index].Value);
                        objRawMaterialConsumptionByExtruder.fkExtruder = Convert.ToInt32(lstExtruder[0].codsec);
                        objRawMaterialConsumptionByExtruder.consumed = Convert.ToDouble(dgvDeliver.Rows[i].Cells[clmRawMaterialConsumptionQuantity.Index].Value);
                        objRawMaterialConsumptionByExtruder.save();

                        //  objRawMaterialConsumptionByExtruder = new clsRawMaterialConsumptionByExtruder();

                        //GRABAR EN EL KARDEX


                        //DESCARGA DE BODEGA DE PRODUCCION

                        lstCellarByExtruder = clsCellarByExtruder.getListProductionCellarByExtruder(Convert.ToInt32(lstExtruder[0].codsec));
                        lstRawMaterialStockProduction = clsRawMaterialStockProduction.getListByExtruderAndRawMaterial(Convert.ToInt32(lstExtruder[0].codsec), Convert.ToInt32(dgvDeliver.Rows[i].Cells[clmRawMaterialConsumptionCodsec.Index].Value));

                        clsKardex objKardex = new clsKardex();

                        objKardex.fkRawMaterial = Convert.ToInt32(dgvDeliver.Rows[i].Cells[clmRawMaterialConsumptionCodsec.Index].Value);
                        objKardex.fkCellar = lstCellarByExtruder[0].fkCellar;
                        objKardex.description = "Despacho a Produccion ";
                        objKardex.quantityIn = 0;
                        objKardex.quantityOut = Convert.ToDouble(dgvDeliver.Rows[i].Cells[clmRawMaterialConsumptionQuantity.Index].Value);
                        objKardex.balance = Convert.ToDouble(lstRawMaterialStockProduction[0].stock);
                        objKardex.cost = 0;
                        objKardex.quote = 0;
                        objKardex.save();

                        //CARGA EN CONSUMO DE MATERIA PRIMA

                        objKardex.fkRawMaterial = Convert.ToInt32(dgvDeliver.Rows[i].Cells[clmRawMaterialConsumptionCodsec.Index].Value);
                        objKardex.fkCellar = lstCellarByExtruderConsumption[0].fkCellar;
                        objKardex.description = "Consumo Materia Prima";
                        objKardex.quantityIn = Convert.ToDouble(dgvDeliver.Rows[i].Cells[clmRawMaterialConsumptionQuantity.Index].Value);
                        objKardex.quantityOut = 0;
                        objKardex.balance = balance;
                        objKardex.cost = 0;
                        objKardex.quote = 0;
                        objKardex.save();












                    }
                }
                MessageBox.Show("El consumo se registro con éxito", "Consumo Materia Prima", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                this.Close();
            }




        }



    }
}

