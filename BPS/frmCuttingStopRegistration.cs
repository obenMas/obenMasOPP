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
    public partial class frmCuttingStopRegistration : Form
    {
        clsCuttingOrder objCuttingOrder = new clsCuttingOrder();
        clsSalesOrderDetail objSalesOrderDetail = new clsSalesOrderDetail();
        clsCuttingStop objCuttingStop = new clsCuttingStop();
        clsProduct objProduct = new clsProduct();
        clsBopp objBopp = new clsBopp();
        clsMachine objMachine = new clsMachine();
        int stop = 0; 
        public string defectsValues = "";
        public string defectsNames = "";
        public int qualityCodsec = 0;
        public string qualityName = "";

        public frmCuttingStopRegistration()
        {
            InitializeComponent();
        }
        public frmCuttingStopRegistration(int parentCuttingOrder, int cuttingStop, int cuttingStopCodsec)
        {
            objCuttingOrder = new clsCuttingOrder(parentCuttingOrder);
            objCuttingStop = new clsCuttingStop(cuttingStopCodsec);
            stop = cuttingStop;
            objBopp = new clsBopp(objCuttingOrder.fkBopp);
            objMachine.load(objCuttingOrder.fkMachine,"Cutter");
            //objProduct = new clsProduct(objCuttingOrder.f)
            InitializeComponent();
        }

        private void frmCuttingStopRegistration_Load(object sender, EventArgs e)
        {
            double length = 0;
            lblCuttingOrderNumber.Text = objCuttingOrder.number;
            lblStop.Text = stop.ToString();
            lblFilmName.Text = "[" + objBopp.code.Replace("-", "") + "] " + objBopp.name;
            lblCutterName.Text = objMachine.Cutter.name;
            int coilSeq = (new clsSequential().coil);

            for (int i = 0; i < objCuttingStop.lstMainCoilByCuttingStop.Count; i++)
            {
                length += objCuttingStop.lstMainCoilByCuttingStop[i].length;
            }

            for (int i = 0; i < objCuttingOrder.lstCuttingOrderDetail.Count; i++)
            {
                int pos = -1;
                bool flgHasCoil = false;

                for (int j = 0; j < objCuttingStop.lstCoil.Count; j++)
                {
                    if (objCuttingStop.lstCoil[j].cuttingPosition == i + 1)
                    {
                        flgHasCoil = true;
                        pos = j;
                    }
                }

                if (flgHasCoil == false)
                {
                    dgvCoilsDetail.Rows.Add();
                    dgvCoilsDetail.Rows[i].Cells[clmCoilCodsec.Index].Value = 0;
                    dgvCoilsDetail.Rows[i].Cells[clmCoilPosition.Index].Value = i + 1;

                    if (objCuttingOrder.lstCuttingOrderDetail[i].fkSalesOrderDetail > 0)
                    {
                        clsSalesOrderDetail objSalesOrderDetail = new clsSalesOrderDetail(objCuttingOrder.lstCuttingOrderDetail[i].fkSalesOrderDetail);
                        clsSalesOrder objSalesOrder = new clsSalesOrder(objSalesOrderDetail.fkSalesOrder);
                        dgvCoilsDetail.Rows[i].Cells[clmCoilSalesOrderDetailCodsec.Index].Value = objSalesOrderDetail.codsec;
                        dgvCoilsDetail.Rows[i].Cells[clmCoilCuttingOrderDetailCodsec.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].codsec;
                        dgvCoilsDetail.Rows[i].Cells[clmCoilCustomer.Index].Value = objSalesOrder.EntityName;
                        dgvCoilsDetail.Rows[i].Cells[clmCoilSalesOrder.Index].Value = objSalesOrder.number;
                        dgvCoilsDetail.Rows[i].Cells[clmCoilCore.Index].Value = objSalesOrderDetail.product.CoreValue.ToString() + "\"";
                        dgvCoilsDetail.Rows[i].Cells[clmCoilCoreCodsec.Index].Value = objSalesOrderDetail.product.fkCore;
                        dgvCoilsDetail.Rows[i].Cells[clmCoilProductCodsec.Index].Value = objSalesOrderDetail.product.codsec;
                    }
                    else
                    {
                        clsProduct objProduct = new clsProduct(objCuttingOrder.lstCuttingOrderDetail[i].fkProduct);
                        dgvCoilsDetail.Rows[i].Cells[clmCoilSalesOrderDetailCodsec.Index].Value = 0;
                        dgvCoilsDetail.Rows[i].Cells[clmCoilCuttingOrderDetailCodsec.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].codsec;
                        dgvCoilsDetail.Rows[i].Cells[clmCoilCustomer.Index].Value = "Producto en Stock";
                        dgvCoilsDetail.Rows[i].Cells[clmCoilSalesOrder.Index].Value = "---";
                        dgvCoilsDetail.Rows[i].Cells[clmCoilCore.Index].Value = objProduct.CoreValue.ToString() + "\"";
                        dgvCoilsDetail.Rows[i].Cells[clmCoilCoreCodsec.Index].Value = objProduct.fkCore;
                    }

                    dgvCoilsDetail.Rows[i].Cells[clmCoilWidth.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].width;
                    dgvCoilsDetail.Rows[i].Cells[clmCoilLength.Index].Value = length.ToString();
                    dgvCoilsDetail.Rows[i].Cells[clmCoilGrossWeight.Index].Value = 0;
                    dgvCoilsDetail.Rows[i].Cells[clmCoilNetWeight.Index].Value = 0;
                    dgvCoilsDetail.Rows[i].Cells[clmCoilCode.Index].Value = DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + objCuttingStop.position.ToString() + stop.ToString() + objMachine.Cutter.cutterNumber.ToString() + "1" + clsGlobal.FillWithZeros(((coilSeq).ToString()), 4) + "0";
                    dgvCoilsDetail.Rows[i].Cells[clmCoilDiameter.Index].Value = 0;
                    dgvCoilsDetail.Rows[i].Cells[clmCoilDensity.Index].Value = 0;
                    dgvCoilsDetail.Rows[i].Cells[clmCoilQuality.Index].Value = "";
                    dgvCoilsDetail.Rows[i].Cells[clmCoilQualityCodsec.Index].Value = 0;
                    dgvCoilsDetail.Rows[i].Cells[clmCoilDefects.Index].Value = "";
                    dgvCoilsDetail.Rows[i].Cells[clmCoilDefects.Index].Value = "False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False";
                    coilSeq++;
                }
                else
                {
                    dgvCoilsDetail.Rows.Add();
                    dgvCoilsDetail.Rows[i].Cells[clmCoilCodsec.Index].Value = objCuttingStop.lstCoil[pos].codsec;
                    dgvCoilsDetail.Rows[i].Cells[clmCoilPosition.Index].Value = objCuttingStop.lstCoil[pos].cuttingPosition;

                    if (objCuttingOrder.lstCuttingOrderDetail[i].fkSalesOrderDetail > 0)
                    {
                        clsSalesOrderDetail objSalesOrderDetail = new clsSalesOrderDetail(objCuttingOrder.lstCuttingOrderDetail[i].fkSalesOrderDetail);
                        clsSalesOrder objSalesOrder = new clsSalesOrder(objSalesOrderDetail.fkSalesOrder);
                        dgvCoilsDetail.Rows[i].Cells[clmCoilSalesOrderDetailCodsec.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].codsec;
                        dgvCoilsDetail.Rows[i].Cells[clmCoilCuttingOrderDetailCodsec.Index].Value = objSalesOrderDetail.codsec;
                        dgvCoilsDetail.Rows[i].Cells[clmCoilCustomer.Index].Value = objSalesOrder.EntityName;
                        dgvCoilsDetail.Rows[i].Cells[clmCoilSalesOrder.Index].Value = objSalesOrder.number;
                        dgvCoilsDetail.Rows[i].Cells[clmCoilCore.Index].Value = objSalesOrderDetail.product.CoreValue.ToString() + "\"";
                        dgvCoilsDetail.Rows[i].Cells[clmCoilCoreCodsec.Index].Value = objSalesOrderDetail.product.fkCore;
                        dgvCoilsDetail.Rows[i].Cells[clmCoilProductCodsec.Index].Value = objSalesOrderDetail.product.codsec;
                    }
                    else
                    {
                        clsProduct objProduct = new clsProduct(objCuttingOrder.lstCuttingOrderDetail[i].fkProduct);
                        dgvCoilsDetail.Rows[i].Cells[clmCoilSalesOrderDetailCodsec.Index].Value = 0;
                        dgvCoilsDetail.Rows[i].Cells[clmCoilCuttingOrderDetailCodsec.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].codsec;
                        dgvCoilsDetail.Rows[i].Cells[clmCoilCustomer.Index].Value = "Producto en Stock";
                        dgvCoilsDetail.Rows[i].Cells[clmCoilSalesOrder.Index].Value = "---";
                        dgvCoilsDetail.Rows[i].Cells[clmCoilCore.Index].Value = objProduct.CoreValue.ToString() + "\"";
                        dgvCoilsDetail.Rows[i].Cells[clmCoilCoreCodsec.Index].Value = objProduct.fkCore;
                    }

                    dgvCoilsDetail.Rows[i].Cells[clmCoilWidth.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].width;
                    dgvCoilsDetail.Rows[i].Cells[clmCoilLength.Index].Value = objCuttingStop.lstCoil[pos].length;
                    dgvCoilsDetail.Rows[i].Cells[clmCoilGrossWeight.Index].Value = Math.Round(objCuttingStop.lstCoil[pos].grossWeight, 2);
                    dgvCoilsDetail.Rows[i].Cells[clmCoilNetWeight.Index].Value = Math.Round(objCuttingStop.lstCoil[pos].netWeight, 2);
                    dgvCoilsDetail.Rows[i].Cells[clmCoilCode.Index].Value = objCuttingStop.lstCoil[pos].code;
                    dgvCoilsDetail.Rows[i].Cells[clmCoilDiameter.Index].Value = Math.Round(objCuttingStop.lstCoil[pos].diameter, 2).ToString();
                    dgvCoilsDetail.Rows[i].Cells[clmCoilDensity.Index].Value = Math.Round(objCuttingStop.lstCoil[pos].density, 2).ToString();
                    dgvCoilsDetail.Rows[i].Cells[clmCoilQualityCodsec.Index].Value = objCuttingStop.lstCoil[pos].fkCuttingQuality;
                    dgvCoilsDetail.Rows[i].Cells[clmCoilQuality.Index].Value = objCuttingStop.lstCoil[pos].CuttingQualityName;
                    dgvCoilsDetail.Rows[i].Cells[clmCoilDefects.Index].Value = "";
                    dgvCoilsDetail.Rows[i].Cells[clmCoilDefects.Index].Value = objCuttingStop.lstCoil[pos].defects;
                }
            }
            for (int j = 0; j < objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstMainCoilByCuttingStop.Count; j++)
            {
                dgvMainCoilList.Rows.Add();
                dgvMainCoilList.Rows[j].Cells[clmMainCoilListCodsec.Index].Value = objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstMainCoilByCuttingStop[j].mainCoil.codsec;
                dgvMainCoilList.Rows[j].Cells[clmMainCoilListFilm.Index].Value = (new clsBopp(objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstMainCoilByCuttingStop[j].mainCoil.fkBopp)).name;
                dgvMainCoilList.Rows[j].Cells[clmMainCoilListCode.Index].Value = objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstMainCoilByCuttingStop[j].mainCoil.code;
                dgvMainCoilList.Rows[j].Cells[clmMainCoilListBatch.Index].Value = objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstMainCoilByCuttingStop[j].mainCoil.lotNumber;
                dgvMainCoilList.Rows[j].Cells[clmMainCoilUsedLenth.Index].Value = Convert.ToString(Math.Round(objCuttingOrder.lstCuttingStop[objCuttingStop.position - 1].lstMainCoilByCuttingStop[j].length, 2));
            }
        }

        private void dgvCoilsDetail_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvCoilsDetail.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.ToString() != "" && dgvCoilsDetail.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.ToString() != dgvCoilsDetail.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString())
            {
                if (e.ColumnIndex == clmCoilGrossWeight.Index)
                {
                    double netWeigth = Convert.ToDouble(dgvCoilsDetail.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue) - (Convert.ToDouble(dgvCoilsDetail.Rows[e.RowIndex].Cells[clmCoilWidth.Index].Value) * (new clsCore(Convert.ToInt32(dgvCoilsDetail.Rows[e.RowIndex].Cells[clmCoilCoreCodsec.Index].Value))).weigthPerMilimeter);
                    dgvCoilsDetail.Rows[e.RowIndex].Cells[clmCoilNetWeight.Index].Value = Convert.ToString(Math.Round(netWeigth, 2));
                    dgvCoilsDetail.Rows[e.RowIndex].Cells[clmCoilDensity.Index].Value = Convert.ToString(Math.Round(clsCoil.getCoilDensity(Convert.ToDouble(dgvCoilsDetail.Rows[e.RowIndex].Cells[clmCoilNetWeight.Index].Value), Convert.ToDouble(dgvCoilsDetail.Rows[e.RowIndex].Cells[clmCoilDiameter.Index].Value), new clsCore(Convert.ToInt32(dgvCoilsDetail.Rows[e.RowIndex].Cells[clmCoilCoreCodsec.Index].Value)), Convert.ToDouble(dgvCoilsDetail.Rows[e.RowIndex].Cells[clmCoilWidth.Index].Value)), 2));
                }
            }

        }

        private void btnCoilSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvCoilsDetail.Rows.Count; i++)
            {
                clsCoil objCoil = new clsCoil(Convert.ToInt32(dgvCoilsDetail.Rows[i].Cells[clmCoilCodsec.Index].Value));

                objCoil.fkBalance = 1; //((clsMachine)cmbBalance.SelectedItem).codsec;
                objCoil.fkCuttingQuality = Convert.ToInt32(dgvCoilsDetail.Rows[i].Cells[clmCoilQualityCodsec.Index].Value);
                objCoil.fkProduct = Convert.ToInt32(dgvCoilsDetail.Rows[i].Cells[clmCoilProductCodsec.Index].Value);
                objCoil.code = dgvCoilsDetail.Rows[i].Cells[clmCoilCode.Index].Value.ToString();
                objCoil.length = Convert.ToDouble(dgvCoilsDetail.Rows[i].Cells[clmCoilLength.Index].Value);
                objCoil.width = Convert.ToDouble(dgvCoilsDetail.Rows[i].Cells[clmCoilWidth.Index].Value);
                objCoil.diameter = Convert.ToDouble(dgvCoilsDetail.Rows[i].Cells[clmCoilDiameter.Index].Value);
                objCoil.density = Convert.ToDouble(dgvCoilsDetail.Rows[i].Cells[clmCoilDensity.Index].Value);
                objCoil.cuttingPosition = i + 1;
                objCoil.cuttingStop = stop;
                objCoil.netWeight = Convert.ToDouble(dgvCoilsDetail.Rows[i].Cells[clmCoilNetWeight.Index].Value);
                objCoil.grossWeight = Convert.ToDouble(dgvCoilsDetail.Rows[i].Cells[clmCoilGrossWeight.Index].Value);
                objCoil.defects = dgvCoilsDetail.Rows[i].Cells[clmCoilDefectsValues.Index].Value.ToString();
                objCoil.notes = "";
                objCoil.cuttingDate = DateTime.Now;
                objCoil.createdDate = DateTime.Now;
                objCoil.modifiedDate = DateTime.Now;
                objCoil.createdBy = clsGlobal.LoggedUser.codsec;
                objCoil.modifiedBy = clsGlobal.LoggedUser.codsec;

                objCoil.save(objCuttingStop.codsec, objSalesOrderDetail.codsec, Convert.ToInt32(dgvCoilsDetail.Rows[i].Cells[clmCoilCellarCodsec.Index].Value), objCuttingOrder.lstCuttingOrderDetail[stop - 1].codsec);
                
            }
        }

        private void dgvCoilsDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if ((dgvCoilsDetail.CurrentCell.ColumnIndex == clmCoilQuality.Index) && e.KeyCode == Keys.Enter)
            {
                frmCoilDefects winCoilDefects = new frmCoilDefects(this);
                winCoilDefects.ShowDialog(this);

                dgvCoilsDetail.Rows[dgvCoilsDetail.CurrentRow.Index].Cells[clmCoilQualityCodsec.Index].Value = qualityCodsec;
                dgvCoilsDetail.Rows[dgvCoilsDetail.CurrentRow.Index].Cells[clmCoilQuality.Index].Value = qualityName;
                dgvCoilsDetail.Rows[dgvCoilsDetail.CurrentRow.Index].Cells[clmCoilDefects.Index].Value = defectsNames;
                dgvCoilsDetail.Rows[dgvCoilsDetail.CurrentRow.Index].Cells[clmCoilDefectsValues.Index].Value = defectsValues;
            }
        }

        private void btnMainCoilExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
