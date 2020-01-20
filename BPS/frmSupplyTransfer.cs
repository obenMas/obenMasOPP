using System;
using System.Collections.Generic;
using System.Windows.Forms; 
using BPS.Bussiness;

namespace BPS
{
    public partial class frmSupplyTransfer : Form
    {
        public frmSupplyTransfer()
        {
            InitializeComponent();
        }
        string batch = "";
        string year = "";
        string month = "";
        string day = "";
        string secuencial = "";
        public int selectedCellar = 0;

        clsSupplytransfer objSupplyTransfer = new clsSupplytransfer();

        private string loadNumber()
        {
            string initial = "TS-";
            string separator = "-";
            int newSecuencial = 0;
            int a = 0;


            batch = objSupplyTransfer.getLastBatch();

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

        private void btnSupplyExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSupplyTransfer_Load(object sender, EventArgs e)
        {
            List<clsSupply> lstSupply = clsSupply.getList();
            cmbSupply.Items.Clear();
            for (int i = 0; i < lstSupply.Count; i++)
                cmbSupply.Items.Add(lstSupply[i]);
            batch = "";
            year = "";
            month = "";
            day = "";
            secuencial = "";
            txtNumber.Text = loadNumber();
        }

        private void cmbSupply_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvDeliverSupply.Rows.Clear();
            List<clsSupplyReceptionDetail> lstSupplyReceptionDetail = clsSupplyReceptionDetail.getListBySupply(((clsSupply)cmbSupply.SelectedItem).codsec);

            for (int i = 0; i < lstSupplyReceptionDetail.Count; i++)
            {
                    dgvDeliverSupply.Rows.Add();
                    dgvDeliverSupply.Rows[i].Cells["clmCodsec"].Value = lstSupplyReceptionDetail[i].codsec.ToString();
                    dgvDeliverSupply.Rows[i].Cells["clmProvider"].Value = lstSupplyReceptionDetail[i].entityName.ToString();
                    dgvDeliverSupply.Rows[i].Cells["clmLote"].Value = lstSupplyReceptionDetail[i].codePackage.ToString();
                    dgvDeliverSupply.Rows[i].Cells["clmAvailableUnits"].Value = lstSupplyReceptionDetail[i].availableUnitsPerpackage.ToString();
                    dgvDeliverSupply.Rows[i].Cells["clmUnitWeigth"].Value = lstSupplyReceptionDetail[i].unitWeigth.ToString();       
            }
        }

        private void dgvDeliverSupply_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clsCellar objCellar = new clsCellar();
            if (e.ColumnIndex != 1)
            {
                frmCellarSelector winCellarSelector = new frmCellarSelector(this);
                winCellarSelector.ShowDialog(this);
                objCellar.load(selectedCellar);

                if (objCellar.codsec > 0)
                {
                    dgvDeliverSupply.CurrentRow.Cells[clmDestinity.Index].Value = objCellar.name;
                    dgvDeliverSupply.CurrentRow.Cells[clmfkCellar.Index].Value = objCellar.codsec;
                }
            }
        }

        private void btnSupplySave_Click(object sender, EventArgs e)
        {

        }

        private void cmbSupply_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsSupply> lstSupply = clsSupply.getList();
                cmbSupply.Items.Clear();
                for (int i = 0; i < lstSupply.Count; i++)
                    cmbSupply.Items.Add(lstSupply[i]);
            }
        }

    }
}
