using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmDeliverRawMaterial : Form
    {
        clsMachine objMachine = new clsMachine();
        clsCellarByExtruder objCellarByExtruder = new clsCellarByExtruder();
        List<clsExtruder> lstExtruder = new List<clsExtruder>();

        public int MachineCodsec = 0;

        public frmDeliverRawMaterial()
        {
            InitializeComponent();
        }

        public frmDeliverRawMaterial(int machineCodsec)
        {
            InitializeComponent();
            objMachine.load(machineCodsec, "Extruder");
            MachineCodsec = machineCodsec;

            lstExtruder = clsExtruder.getExtruderListByMachine(machineCodsec);
        }

        public bool validateForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref dgvDeliver, ref groupBox1, "isValid")) isValid = false;

            return isValid;
        }

        clsReceptionRawMaterialDetail objReceptionRawMaterialDetail = new clsReceptionRawMaterialDetail();
        clsDeliverRawMaterial objDeliverRawMaterial = new clsDeliverRawMaterial();
        clsTransfer objTransfer = new clsTransfer();
        clsKardex objKardex = new clsKardex();

        double balance = 0;
        double delivered = 0;
        string batch = "";
        string year = "";
        string month = "";
        string day = "";
        string secuencial = "";

        public int selectedCellar = 0;

        private string loadNumber()
        {
            string initial = "TMP-";
            string separator = "-";
            int newSecuencial = 0;
            int a = 0;

            batch = objTransfer.getLastBatch();

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

        private void frmDeliverRawMaterial_Load(object sender, EventArgs e)
        {


        }


        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                List<clsReceptionRawMaterialDetail> lstReceptionRawMaterialDetail = new List<clsReceptionRawMaterialDetail>();
                List<clsCellar> lstCellar = new List<clsCellar>();
                lstCellar = clsCellar.getList();

                //   lstReceptionRawMaterialDetail.Clear();

                lstReceptionRawMaterialDetail = clsReceptionRawMaterialDetail.getReceptionDetailByPackageCode(txtCode.Text);


                if (dgvDeliver.Rows.Count == 0)
                {
                    for (int i = 0; i < lstReceptionRawMaterialDetail.Count; i++)
                    {
                        if (lstReceptionRawMaterialDetail[i].avaliableUnits == 0)
                        {
                            MessageBox.Show("El Producto ya ha sido despachado", "Despacho Materia Prima", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        }
                        else
                        {
                            dgvDeliver.Rows.Add();
                            dgvDeliver.Rows[i].Cells["clmReceptionDetailCodsec"].Value = lstReceptionRawMaterialDetail[i].codsec.ToString();
                            dgvDeliver.Rows[i].Cells["fkExtruder"].Value = lstExtruder[0].codsec.ToString();
                            dgvDeliver.Rows[i].Cells["clmfkRawMaterial"].Value = lstReceptionRawMaterialDetail[i].fkRawMaterial.ToString();
                            dgvDeliver.Rows[i].Cells["clmProvider"].Value = lstReceptionRawMaterialDetail[i].entityName.ToString();
                            dgvDeliver.Rows[i].Cells["clmRawMaterialType"].Value = lstReceptionRawMaterialDetail[i].RawMaterialTypeName.ToString();
                            dgvDeliver.Rows[i].Cells["clmRawMaterial"].Value = lstReceptionRawMaterialDetail[i].RawMaterialName.ToString();
                            dgvDeliver.Rows[i].Cells["clmAvailableUnits"].Value = lstReceptionRawMaterialDetail[i].avaliableUnits.ToString();
                            dgvDeliver.Rows[i].Cells["clmWeigthUnit"].Value = lstReceptionRawMaterialDetail[i].unitWeight.ToString();
                            dgvDeliver.Rows[i].Cells["clmAvailableWeigth"].Value = lstReceptionRawMaterialDetail[i].avaliableWeigth.ToString();
                            dgvDeliver.Rows[i].Cells["clmCost"].Value = lstReceptionRawMaterialDetail[i].cost.ToString();
                            dgvDeliver.Rows[i].Cells["clmQuote"].Value = lstReceptionRawMaterialDetail[i].quote.ToString();
                        }

                    }
                    txtCode.Clear();
                }
                else
                {

                    for (int i = 0; i < lstReceptionRawMaterialDetail.Count; i++)
                    {
                        if (lstReceptionRawMaterialDetail[i].avaliableUnits == 0)
                        {
                            MessageBox.Show("El Producto ya ha sido despachado", "Despacho Materia Prima", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        }
                        else
                        {
                            dgvDeliver.Rows.Add();
                            dgvDeliver.Rows[dgvDeliver.Rows.Count - 1].Cells["clmReceptionDetailCodsec"].Value = lstReceptionRawMaterialDetail[i].codsec.ToString();
                            dgvDeliver.Rows[i].Cells["fkExtruder"].Value = lstExtruder[0].codsec.ToString();
                            dgvDeliver.Rows[dgvDeliver.Rows.Count - 1].Cells["clmfkRawMaterial"].Value = lstReceptionRawMaterialDetail[i].fkRawMaterial.ToString();
                            dgvDeliver.Rows[dgvDeliver.Rows.Count - 1].Cells["clmProvider"].Value = lstReceptionRawMaterialDetail[i].entityName.ToString();
                            dgvDeliver.Rows[dgvDeliver.Rows.Count - 1].Cells["clmRawMaterialType"].Value = lstReceptionRawMaterialDetail[i].RawMaterialTypeName.ToString();
                            dgvDeliver.Rows[dgvDeliver.Rows.Count - 1].Cells["clmRawMaterial"].Value = lstReceptionRawMaterialDetail[i].RawMaterialName.ToString();
                            dgvDeliver.Rows[dgvDeliver.Rows.Count - 1].Cells["clmAvailableUnits"].Value = lstReceptionRawMaterialDetail[i].avaliableUnits.ToString();
                            dgvDeliver.Rows[dgvDeliver.Rows.Count - 1].Cells["clmWeigthUnit"].Value = lstReceptionRawMaterialDetail[i].unitWeight.ToString();
                            dgvDeliver.Rows[dgvDeliver.Rows.Count - 1].Cells["clmAvailableWeigth"].Value = lstReceptionRawMaterialDetail[i].avaliableWeigth.ToString();
                            dgvDeliver.Rows[dgvDeliver.Rows.Count - 1].Cells["clmCost"].Value = lstReceptionRawMaterialDetail[i].cost.ToString();
                            dgvDeliver.Rows[dgvDeliver.Rows.Count - 1].Cells["clmQuote"].Value = lstReceptionRawMaterialDetail[i].quote.ToString();
                        }

                    }
                    txtCode.Clear();
                }

            }
        }

        private void dgvDeliver_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            clsCellar objCellar = new clsCellar();
            if (e.ColumnIndex != 1)
            {
                frmCellarSelector winCellarSelector = new frmCellarSelector(this);
                winCellarSelector.ShowDialog(this);
                objCellarByExtruder.load(selectedCellar);
            }


            if (objCellarByExtruder.codsec > 0)
            {
                dgvDeliver.CurrentRow.Cells[clmDestiny.Index].Value = objCellarByExtruder.cellarName;
                dgvDeliver.CurrentRow.Cells[clmfkCellar.Index].Value = objCellarByExtruder.fkCellar;
            }
        }


        private void btnMainCoilSave_Click(object sender, EventArgs e)
        {
            //   if (validateForm())
            //   {
            for (int i = 0; i < dgvDeliver.Rows.Count; i++)
            {
                if (Convert.ToInt32(dgvDeliver.Rows[i].Cells[clmReceptionDetailCodsec.Index].Value) != 0)
                {
                    batch = "";
                    year = "";
                    month = "";
                    day = "";
                    secuencial = "";
                    txtNumber.Text = loadNumber();
                    objTransfer.fkRawMaterial = Convert.ToInt32(dgvDeliver.Rows[i].Cells[clmfkRawMaterial.Index].Value);
                    objTransfer.fkExtruder = Convert.ToInt32(dgvDeliver.Rows[i].Cells[fkExtruder.Index].Value);
                    objTransfer.fkRawMaterialByReception = Convert.ToInt32(dgvDeliver.Rows[i].Cells[clmReceptionDetailCodsec.Index].Value);
                    objTransfer.amountTransferred = (Convert.ToInt32(dgvDeliver.Rows[i].Cells[clmWeigthUnit.Index].Value) * Convert.ToInt32(dgvDeliver.Rows[i].Cells[clmDeliveredQuantity.Index].Value));
                    objTransfer.number = txtNumber.Text;
                    objTransfer.fkCellar = Convert.ToInt32(dgvDeliver.Rows[i].Cells[clmfkCellar.Index].Value);
                    objTransfer.unitsTransferred = Convert.ToInt32(dgvDeliver.Rows[i].Cells[clmDeliveredQuantity.Index].Value);

                    objTransfer.save();

                    // Hace la descarga de M.P.


                    objKardex.fkRawMaterial = Convert.ToInt32(dgvDeliver.Rows[i].Cells[clmfkRawMaterial.Index].Value);
                    objKardex.fkCellar = objDeliverRawMaterial.getOutlerCellar();
                    objKardex.description = dgvDeliver.Rows[i].Cells[clmComment.Index].Value.ToString();
                    objKardex.quantityIn = 0;
                    objKardex.quantityOut = (Convert.ToInt32(dgvDeliver.Rows[i].Cells[clmWeigthUnit.Index].Value) * Convert.ToInt32(dgvDeliver.Rows[i].Cells[clmDeliveredQuantity.Index].Value));
                    balance = objTransfer.CalculateOutputBalance(Convert.ToInt32(dgvDeliver.Rows[i].Cells[clmfkRawMaterial.Index].Value));
                    //delivered = Convert.ToDouble((Convert.ToInt32(dgvDeliver.Rows[i].Cells[clmWeigthUnit.Index].Value) * Convert.ToDouble(dgvDeliver.Rows[i].Cells[clmDeliveredQuantity.Index].Value)));
                    objKardex.balance = Convert.ToDouble(balance);
                    objKardex.cost = Convert.ToDouble(dgvDeliver.Rows[i].Cells[clmCost.Index].Value);
                    objKardex.quote = Convert.ToDouble(dgvDeliver.Rows[i].Cells[clmQuote.Index].Value);
                    objKardex.save();

                    // Hace la carga al nuevo deposito de m.p. en produccion 

                    objKardex.fkRawMaterial = Convert.ToInt32(dgvDeliver.Rows[i].Cells[clmfkRawMaterial.Index].Value);
                    objKardex.fkCellar = Convert.ToInt32(dgvDeliver.Rows[i].Cells[clmfkCellar.Index].Value);
                    objKardex.description = dgvDeliver.Rows[i].Cells[clmComment.Index].Value.ToString();
                    objKardex.quantityIn = (Convert.ToInt32(dgvDeliver.Rows[i].Cells[clmWeigthUnit.Index].Value) * Convert.ToInt32(dgvDeliver.Rows[i].Cells[clmDeliveredQuantity.Index].Value));
                    objKardex.quantityOut = 0;
                    balance = objTransfer.CalculateInputBalance(Convert.ToInt32(dgvDeliver.Rows[i].Cells[clmfkRawMaterial.Index].Value), Convert.ToInt32(dgvDeliver.Rows[i].Cells[clmfkCellar.Index].Value));
                    delivered = Convert.ToDouble((Convert.ToInt32(dgvDeliver.Rows[i].Cells[clmWeigthUnit.Index].Value) * Convert.ToDouble(dgvDeliver.Rows[i].Cells[clmDeliveredQuantity.Index].Value)));
                    objKardex.balance = Convert.ToDouble(balance);
                    objKardex.cost = Convert.ToDouble(dgvDeliver.Rows[i].Cells[clmCost.Index].Value);
                    objKardex.quote = Convert.ToDouble(dgvDeliver.Rows[i].Cells[clmQuote.Index].Value);
                    objKardex.save();
                    objReceptionRawMaterialDetail.load(Convert.ToInt32(dgvDeliver.Rows[i].Cells[clmReceptionDetailCodsec.Index].Value));
                    objReceptionRawMaterialDetail.avaliableUnitsPerpackage = (objReceptionRawMaterialDetail.avaliableUnits - Convert.ToInt32(dgvDeliver.Rows[i].Cells[clmDeliveredQuantity.Index].Value));
                    objReceptionRawMaterialDetail.save();
                }
            }
            MessageBox.Show("Se agrego el despacho de Materia Prima con éxito", "Despacho Materia Prima", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            this.Close();

        }

        private void btnMainCoilCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta realmente seguro que desea cancelar Materia Prima", "Materia Prima", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                txtNumber.Text = "";
                txtCode.Text = "";
                txtUser.Text = "";
                dtpDate.Value = DateTime.Now;
            }
        }

        private void btnMainCoilExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}