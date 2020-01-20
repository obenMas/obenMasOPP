using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmRawMaterialReception : Form
    {
        public frmRawMaterialReception()
        {
            InitializeComponent();
        }

        clsReception objReception = new clsReception();
        clsKardex objKardex = new clsKardex();
        clsCellar objCellar = new clsCellar();
        clsPurchaseOrderDetail objPurchaseOrderDetail = new clsPurchaseOrderDetail();
        clsPurchaseOrder objPurchaseOrder = new clsPurchaseOrder();
        double TotalDelivered = 0;


        private string GetBatch()
        {
            string batch = "";
            string year = "";
            string month = "";
            string secuencial = null;
            int newSecuencial = 0;
            int a = 0;


            batch = objReception.getLastBatch();

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

        private void frmRawMaterialReception_Load(object sender, EventArgs e)
        {
            List<clsPurchaseOrder> lstPurchaseOrder = clsPurchaseOrder.getListPuchaseOrderActive();
            cmbPurchaseOrder.Items.Clear();
            for (int i = 0; i < lstPurchaseOrder.Count; i++)
                cmbPurchaseOrder.Items.Add(lstPurchaseOrder[i]);
        }

        private void cmbPurchaseOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<clsPurchaseOrderDetail> lstPurchaseOrderDetail = new List<clsPurchaseOrderDetail>();
            lstPurchaseOrderDetail = clsPurchaseOrderDetail.getListByPurchaseOrder(((clsPurchaseOrder)cmbPurchaseOrder.SelectedItem).codsec);
            int pos = 0;
            dgvReception.Rows.Clear();
            for (int i = 0; i < lstPurchaseOrderDetail.Count; i++)
            {
                if ((lstPurchaseOrderDetail[i].quantity - lstPurchaseOrderDetail[i].totalRecepted) != 0)
                {
                    dgvReception.Rows.Add();
                    dgvReception.Rows[pos].Cells["clmfkPurchaseOrderDetail"].Value = lstPurchaseOrderDetail[i].codsec.ToString();
                    dgvReception.Rows[pos].Cells["clmRawMaterialType"].Value = lstPurchaseOrderDetail[i].TypeRawMaterialName;
                    dgvReception.Rows[pos].Cells["clmRawMaterialName"].Value = lstPurchaseOrderDetail[i].RawMaterialName;
                    dgvReception.Rows[pos].Cells["clmRawMaterialCode"].Value = lstPurchaseOrderDetail[i].RawMaterialCode;
                    dgvReception.Rows[pos].Cells["clmQuantityOrdered"].Value = lstPurchaseOrderDetail[i].quantity.ToString();
                    dgvReception.Rows[pos].Cells["clmAmountToBeDelivered"].Value = (lstPurchaseOrderDetail[i].quantity - lstPurchaseOrderDetail[i].totalRecepted);
                    dgvReception.Rows[pos].Cells["clmQuantityDelivered"].Value = lstPurchaseOrderDetail[i].totalRecepted.ToString();
                    dgvReception.Rows[pos].Cells["clmPrice"].Value = lstPurchaseOrderDetail[i].price.ToString();
                    dgvReception.Rows[pos].Cells["clmfkRawMaterial"].Value = lstPurchaseOrderDetail[i].fkRawMaterial.ToString();
                    dgvReception.Rows[pos].Cells["clmPurchaseOrderCodsec"].Value = lstPurchaseOrderDetail[i].fkPurchaseOrder.ToString();
                    pos++;
                }
            }
        }

        private void btnMainCoilExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMainCoilCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnMainCoilSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvReception.Rows.Count; i++)
            {
                if (Convert.ToInt32(dgvReception.Rows[i].Cells[clmQuantity.Index].Value) != 0)
                {
                    if (Convert.ToInt32(dgvReception.Rows[i].Cells[clmAmountToBeDelivered.Index].Value) != 0)
                    {
                        if (Convert.ToDouble(dgvReception.Rows[i].Cells[clmQuantity.Index].Value) > Convert.ToDouble(dgvReception.Rows[i].Cells[clmAmountToBeDelivered.Index].Value))
                            MessageBox.Show("No se puede recibir mas del faltante", "Recepciones", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        else
                        {
                            if ((Convert.ToDouble(dgvReception.Rows[i].Cells[clmQuantity.Index].Value) + TotalDelivered) == Convert.ToInt32(dgvReception.Rows[i].Cells[clmQuantityOrdered.Index].Value))
                            {
                                objReception.fkPurchaseOrderDetail = Convert.ToInt32(dgvReception.Rows[i].Cells[clmfkPurchaseOrderDetail.Index].Value);
                                objReception.batch = GetBatch();
                                objReception.quantity = Convert.ToInt32(dgvReception.Rows[i].Cells[clmQuantity.Index].Value);
                                objReception.notes = dgvReception.Rows[i].Cells[clmDetail.Index].Value.ToString();
                                objReception.createdDate = dtpReceptionDate.Value;
                                objReception.documentNumber = dgvReception.Rows[i].Cells[clmDocument.Index].Value.ToString();
                                objReception.cost = Convert.ToDouble(dgvReception.Rows[i].Cells[clmPrice.Index].Value);
                                objReception.fkRawMaterial = Convert.ToInt32(dgvReception.Rows[i].Cells[clmfkRawMaterial.Index].Value);
                                objReception.fkPurchaseOrder = Convert.ToInt32(dgvReception.Rows[i].Cells[clmPurchaseOrderCodsec.Index].Value);
                                if (objReception.save())
                                {
                                    objKardex.fkRawMaterial = objReception.fkRawMaterial;
                                    objKardex.fkCellar = objCellar.getCellarCodsec();
                                    objKardex.description = objReception.notes;
                                    objKardex.quantityIn = objReception.quantity;
                                    objKardex.quantityOut = 0;
                                    // codigo cuando grababa solo ingreso y salida      
                                    objKardex.balance = objReception.CalculateBalance(objReception.fkRawMaterial);
                                    //objKardex.balance = objReception.quantity;
                                    objKardex.cost = objReception.cost;
                                    objKardex.date = dtpReceptionDate.Value;
                                    if (objKardex.save())
                                    {
                                        MessageBox.Show("La recepción se ha guardado con éxito", "Recepciones", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                        frmRawMaterialReceptionDetail winRawMaterialReceptionDetail = new frmRawMaterialReceptionDetail();
                                        winRawMaterialReceptionDetail.ShowDialog(this);
                                    }
                                    else
                                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Recepciones", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                }
                                else
                                    MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Recepciones", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                            }
                            else
                            {
                                objReception.fkPurchaseOrderDetail = Convert.ToInt32(dgvReception.Rows[i].Cells[clmfkPurchaseOrderDetail.Index].Value);
                                objReception.batch = GetBatch();
                                objReception.quantity = Convert.ToInt32(dgvReception.Rows[i].Cells[clmQuantity.Index].Value);
                                objReception.notes = dgvReception.Rows[i].Cells[clmDetail.Index].Value.ToString();
                                objReception.createdDate = dtpReceptionDate.Value;
                                objReception.documentNumber = dgvReception.Rows[i].Cells[clmDocument.Index].Value.ToString();
                                objReception.cost = Convert.ToDouble(dgvReception.Rows[i].Cells[clmPrice.Index].Value);
                                objReception.fkRawMaterial = Convert.ToInt32(dgvReception.Rows[i].Cells[clmfkRawMaterial.Index].Value);
                                objReception.fkPurchaseOrder = Convert.ToInt32(dgvReception.Rows[i].Cells[clmPurchaseOrderCodsec.Index].Value);
                                if (objReception.save())
                                {
                                    objKardex.fkRawMaterial = objReception.fkRawMaterial;
                                    objKardex.fkCellar = objCellar.getCellarCodsec();
                                    objKardex.description = objReception.notes;
                                    objKardex.quantityIn = objReception.quantity;
                                    objKardex.quantityOut = 0;
                                    // codigo cuando grababa solo ingreso y salida      objKardex.balance = objReception.CalculateBalance(objReception.fkRawMaterial);
                                    objKardex.balance = objReception.quantity;
                                    objKardex.cost = objReception.cost;
                                    objKardex.date = dtpReceptionDate.Value;

                                    if (objKardex.save())
                                    {
                                        MessageBox.Show("La recepción se ha guardado con éxito", "Recepciones", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                        frmRawMaterialReceptionDetail winRawMaterialReceptionDetail = new frmRawMaterialReceptionDetail();
                                        winRawMaterialReceptionDetail.ShowDialog(this);
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

                TotalDelivered = objPurchaseOrder.getTotalDeliverder(Convert.ToInt32(dgvReception.Rows[i].Cells[clmPurchaseOrderCodsec.Index].Value));
                if (TotalDelivered != 0)
                {
                    objPurchaseOrder.load(objReception.fkPurchaseOrder);
                    objPurchaseOrder.fkStatus = objPurchaseOrder.getPurchaseOrderStatusCodsec("Parcialmente Recepcionada");
                    objPurchaseOrder.save();
                }
                else
                {
                    objPurchaseOrder.load(Convert.ToInt32(dgvReception.Rows[i].Cells[clmPurchaseOrderCodsec.Index].Value));
                    objPurchaseOrder.fkStatus = objPurchaseOrder.getPurchaseOrderStatusCodsec("Orden Recepcionada");
                    objPurchaseOrder.save();
                }
            }
            this.Close();
        }

        private void cmbPurchaseOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsPurchaseOrder> lstPurcharseOrder = clsPurchaseOrder.getListPuchaseOrderActive();
                cmbPurchaseOrder.Items.Clear();
                for (int i = 0; i < lstPurcharseOrder.Count; i++)
                    cmbPurchaseOrder.Items.Add(lstPurcharseOrder[i]);
            }
        }
    }
}
