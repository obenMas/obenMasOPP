using System;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmSupplyForm : Form
    {

        public int selectedSupply = 0;
        clsSupplyReception objSupplyReception = new clsSupplyReception();
        clsSupplyKardex objSupplyKardex = new clsSupplyKardex();
        clsCellar objCellar = new clsCellar();

        public frmSupplyForm()
        {
            InitializeComponent();
        }

        private string GetBatch()
        {
            string batch = "";
            string year = "";
            string month = "";
            string secuencial = null;
            int newSecuencial = 0;
            int a = 0;
            batch = objSupplyReception.getLastBatch();

            if (batch == "")
            {
                secuencial = "0001";
                year = DateTime.Now.ToString("yy");
                month = DateTime.Now.ToString("MM");
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
                batch = year + month + secuencial;
            }
            else
            {
                year = DateTime.Now.ToString("yy");
                month = DateTime.Now.ToString("MM");
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

                secuencial = batch.Substring(3, 4);
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
                batch = year + month + secuencial;
            }
            return batch;
        }

        private void dgvReception_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clsSupply objSupply = new clsSupply();

            frmSupplySelector winSupplySelector = new frmSupplySelector(this);
            winSupplySelector.ShowDialog(this);
            objSupply.load(selectedSupply);

            if (objSupply.codsec > 0)
            {
                dgvReception.CurrentRow.Cells[clmName.Index].Value = objSupply.name;
                dgvReception.CurrentRow.Cells[clmCodsec.Index].Value = objSupply.codsec;
                dgvReception.CurrentRow.Cells[clmCode.Index].Value = objSupply.code;
                dgvReception.CurrentRow.Cells[clmcodsecProvider.Index].Value = objSupply.fkEntity;
                dgvReception.CurrentRow.Cells[clmProvider.Index].Value = objSupply.EntityName;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvReception.Rows.Count; i++)
            {
                if (Convert.ToInt32(dgvReception.Rows[i].Cells[clmQuantity.Index].Value) != 0)
                {
                    objSupplyReception.fkSupply = Convert.ToInt32(dgvReception.Rows[i].Cells[clmCodsec.Index].Value);
                    objSupplyReception.fkEntity = Convert.ToInt32(dgvReception.Rows[i].Cells[clmcodsecProvider.Index].Value);
                    objSupplyReception.batch = GetBatch();
                    objSupplyReception.quantity = Convert.ToInt32(dgvReception.Rows[i].Cells[clmQuantity.Index].Value);
                    objSupplyReception.notes = dgvReception.Rows[i].Cells[clmNotes.Index].Value.ToString();
                    objSupplyReception.createdDate = dtpReceptionDate.Value;
                    objSupplyReception.documentNumber = dgvReception.Rows[i].Cells[clmDocument.Index].Value.ToString();
                    if (objSupplyReception.save())
                    {
                        objSupplyKardex.fkSupply = objSupplyReception.fkSupply;
                        objSupplyKardex.fkCellar = objCellar.getSupplyCellarCodsec();
                        objSupplyKardex.description = objSupplyReception.notes;
                        objSupplyKardex.quantityIn = objSupplyReception.quantity;
                        objSupplyKardex.quantityOut = 0;
                        objSupplyKardex.balance = (objSupplyReception.CalculateBalance(objSupplyKardex.fkSupply) + objSupplyReception.quantity);
                        //objSupplyKardex.cost = objSupplyReception.cost;
                        objSupplyKardex.date = dtpReceptionDate.Value;

                        if (objSupplyKardex.save())
                        {

                            MessageBox.Show("La recepción se ha guardado con éxito", "Recepciones", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

                            frmSupplyReceptionDetail winSupplyReceptionDetail = new frmSupplyReceptionDetail();

                            winSupplyReceptionDetail.ShowDialog(this);
                        }
                        else
                            MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Recepciones", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Recepciones", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
        }
    }
}