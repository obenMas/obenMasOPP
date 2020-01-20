using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms; 
using BPS.Bussiness;

namespace BPS
{
    public partial class frmDropCoil : Form
    {
        clsSalesOrderDetail objSalesOrderDetail = new clsSalesOrderDetail();
        clsSalesOrder objSalesOrder = new clsSalesOrder();
        clsCoil objCoil = new clsCoil();
        clsCuttingStop objCuttingStop = new clsCuttingStop();
        clsCoilCellar objCoilCellar = new clsCoilCellar();

        public frmDropCoil()
        {
            InitializeComponent();
        }

        private void txtCoilCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCoilCode.Text != "")
                {
                    objCoil = clsCoil.getDetailByCode(txtCoilCode.Text);
                    objCoilCellar = clsCoil.getContainerCellarByCoil(objCoil.codsec);
                    objCuttingStop = clsCoil.getCuttingStopByCoil(objCoil.codsec);

                    if (objCoilCellar.codsec == 11 || objCoilCellar.codsec == 2 || objCoilCellar.codsec == 5 || objCoilCellar.codsec == 7 || objCoilCellar.codsec == 3012)
                    {

                        if (objCoil.codsec != 0)
                        {

                            lblNetWeigth.Text = Convert.ToString(Math.Round(objCoil.netWeight, 2));
                            lblGrossWeigth.Text = Convert.ToString(Math.Round(objCoil.grossWeight, 2));
                            lblLength.Text = Convert.ToString(Math.Round(objCoil.length, 2));
                            lblWidth.Text = objCoil.width.ToString();

                            objSalesOrderDetail = clsCoil.getSalesOrderDetailByCoil(objCoil.codsec);
                            objSalesOrder = new clsSalesOrder(objSalesOrderDetail.fkSalesOrder);

                            if (objSalesOrder.codsec != 0)
                            {
                                lblCustomer.Text = objSalesOrder.EntityName;
                                lblSalesOrderNumber.Text = objSalesOrder.number;
                                dgvCoils.Rows.Add();
                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCodsec.Index].Value = objCoil.codsec;
                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCode.Index].Value = objCoil.code;
                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmProductName.Index].Value = objCoil.ProductName;
                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmDestination.Index].Value = objCoil.customerName + ((objCoil.salesOrderNumber != "0") ? "[" + objCoil.salesOrderNumber + "]" : "");
                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmLength.Index].Value = objCoil.length.ToString();
                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmWidth.Index].Value = objCoil.width.ToString();
                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmWeigth.Index].Value = objCoil.netWeight.ToString();
                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmQuality.Index].Value = objCoil.CuttingQualityName.ToString();

                                lblNetWeigth.Text = "0";
                                lblGrossWeigth.Text = "0";
                                lblLength.Text = "0";
                                lblWidth.Text = "0";
                                lblCustomer.Text = "";
                                lblSalesOrderNumber.Text = "";
                                txtCoilCode.Text = "";
                                txtCoilCode.Focus();

                                objCoil = new clsCoil();
                                objCoilCellar = new clsCoilCellar();
                                objCuttingStop = new clsCuttingStop();
                                objSalesOrderDetail = new clsSalesOrderDetail();
                                objSalesOrder = new clsSalesOrder();
                            }
                            else
                            {
                                lblCustomer.Text = "STOCK";
                                lblSalesOrderNumber.Text = "---";
                                dgvCoils.Rows.Add();
                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCodsec.Index].Value = objCoil.codsec;
                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCode.Index].Value = objCoil.code;
                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmProductName.Index].Value = objCoil.ProductName;
                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmDestination.Index].Value = objCoil.customerName + ((objCoil.salesOrderNumber != "0") ? "[" + objCoil.salesOrderNumber + "]" : "");
                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmLength.Index].Value = objCoil.length.ToString();
                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmWidth.Index].Value = objCoil.width.ToString();
                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmWeigth.Index].Value = objCoil.netWeight.ToString();
                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmQuality.Index].Value = objCoil.CuttingQualityName.ToString();

                                lblNetWeigth.Text = "0";
                                lblGrossWeigth.Text = "0";
                                lblLength.Text = "0";
                                lblWidth.Text = "0";
                                lblCustomer.Text = "";
                                lblSalesOrderNumber.Text = "";
                                txtCoilCode.Text = "";
                                txtCoilCode.Focus();

                                objCoil = new clsCoil();
                                objCoilCellar = new clsCoilCellar();
                                objCuttingStop = new clsCuttingStop();
                                objSalesOrderDetail = new clsSalesOrderDetail();
                                objSalesOrder = new clsSalesOrder();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No puede modificar una bobina que se encuentre en bodega de " + objCoilCellar.name + " por favor solicite a bodega que extraigan el pallet a BODEGA DE PROCESO para que pueda enviar a EREMA la bobina seleccionada", "Molina", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        txtCoilCode.Focus();
                        objCoil = new clsCoil();
                        objCoilCellar = new clsCoilCellar();
                        objCuttingStop = new clsCuttingStop();
                        objSalesOrderDetail = new clsSalesOrderDetail();
                        objSalesOrder = new clsSalesOrder();
                    }
                }
            }
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if (objCoil.codsec != 0)
            {
                    dgvCoils.Rows.Add();
                    dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCodsec.Index].Value = objCoil.codsec;
                    dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCode.Index].Value = objCoil.code;
                    dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmProductName.Index].Value = objCoil.ProductName;
                    dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmDestination.Index].Value = objCoil.customerName + ((objCoil.salesOrderNumber != "0") ? "[" + objCoil.salesOrderNumber + "]" : "");
                    dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmLength.Index].Value = objCoil.length.ToString();
                    dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmWidth.Index].Value = objCoil.width.ToString();
                    dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmWeigth.Index].Value = objCoil.netWeight.ToString();
                    dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmQuality.Index].Value = objCoil.CuttingQualityName.ToString();

                    lblNetWeigth.Text = "0";
                    lblGrossWeigth.Text = "0";
                    lblLength.Text = "0";
                    lblWidth.Text = "0";
                    lblCustomer.Text = "";
                    lblSalesOrderNumber.Text = "";
                    txtCoilCode.Text = "";
                    txtCoilCode.Focus();

                    objCoil = new clsCoil();
                    objCoilCellar = new clsCoilCellar();
                    objCuttingStop = new clsCuttingStop();
                    objSalesOrderDetail = new clsSalesOrderDetail();
                    objSalesOrder = new clsSalesOrder();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelDrop_Click(object sender, EventArgs e)
        {
            dgvCoils.Rows.Clear();
            lblNetWeigth.Text = "0";
            lblGrossWeigth.Text = "0";
            lblLength.Text = "0";
            lblWidth.Text = "0";
            lblCustomer.Text = "";
            lblSalesOrderNumber.Text = "";
            txtCoilCode.Text = "";
            txtCoilCode.Focus();

            objCoil = new clsCoil();
            objCoilCellar = new clsCoilCellar();
            objCuttingStop = new clsCuttingStop();
            objSalesOrderDetail = new clsSalesOrderDetail();
            objSalesOrder = new clsSalesOrder();
        }

        private void btnDropCoil_Click(object sender, EventArgs e)
        {

            if (dgvCoils.Rows.Count > 0)
            {
                if (MessageBox.Show("Una vez realizado el proceso las bobinas seleccionadas serán eliminadas del sistema de forma irreversible, desea continuar con el proceso?", "Molino", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
                    for (int i = 0; i < dgvCoils.Rows.Count; i++)
                        clsCoil.dropCoil(Convert.ToInt32(dgvCoils.Rows[i].Cells[clmCodsec.Index].Value));

                    dgvCoils.Rows.Clear();
                    lblNetWeigth.Text = "0";
                    lblGrossWeigth.Text = "0";
                    lblLength.Text = "0";
                    lblWidth.Text = "0";
                    lblCustomer.Text = "";
                    lblSalesOrderNumber.Text = "";
                    txtCoilCode.Text = "";
                    txtCoilCode.Focus();

                    objCoil = new clsCoil();
                    objCoilCellar = new clsCoilCellar();
                    objCuttingStop = new clsCuttingStop();
                    objSalesOrderDetail = new clsSalesOrderDetail();
                    objSalesOrder = new clsSalesOrder();

                    MessageBox.Show("Las bobinas seleccionadas han sido eliminadas del sistema al ser enviadas al molino.", "Molino", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                } 
            }
            else
                MessageBox.Show("No existen bobinas ingresadas para enviar las al molino", "Molino", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
        }
    }
}
