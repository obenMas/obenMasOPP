using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;
using BPS.Bussiness;

namespace BPS.Lite
{
    public partial class frmCoilDetail : Form
    {
        clsSalesOrderDetail objSalesOrderDetail = new clsSalesOrderDetail();
        clsSalesOrder objSalesOrder = new clsSalesOrder();
        clsCuttingStop objCuttingStop = new clsCuttingStop();
        clsCoilCellar objCoilCellar = new clsCoilCellar();
        clsCoil objCoil = new clsCoil();
        Thread thrdWeigth;
        static SerialPort sprtBalance = new SerialPort();
        public volatile bool continueReading = true;

        public frmCoilDetail()
        {
            InitializeComponent();
        }
        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                getCoilInformation(txtCode.Text);
            }
        }
        private void getWeigth()
        {
            try
            {
                while (continueReading)
                {
                    if (sprtBalance.IsOpen == false)
                    {
                        sprtBalance.PortName = "COM5";
                        sprtBalance.Open();
                    }

                    string strReceivedData = sprtBalance.ReadLine();

                    if (strReceivedData != "\r")
                    {
                        if (strReceivedData.EndsWith("?\r"))
                        {
                            if (clsGlobal.isNumeric(strReceivedData.Substring(0, strReceivedData.Length - 2)))
                            {
                                this.Invoke((MethodInvoker)delegate { lblWeigthValue.Text = Math.Round(Convert.ToDouble(strReceivedData.Substring(0, strReceivedData.Length - 2)), 2).ToString("N2").Trim(); });
                                this.Invoke((MethodInvoker)delegate { lblWeigthValue.ForeColor = Color.Red; });
                            }
                        }
                        else
                        {
                            if (clsGlobal.isNumeric(strReceivedData.Substring(0, strReceivedData.Length - 1)))
                            {
                                this.Invoke((MethodInvoker)delegate { lblWeigthValue.Text = Math.Round(Convert.ToDouble(strReceivedData.Substring(0, strReceivedData.Length - 1)), 2).ToString("N2").Trim(); });
                                this.Invoke((MethodInvoker)delegate { lblWeigthValue.ForeColor = Color.Black; });
                            }
                        }
                    }
                }

                if (continueReading == false)
                {
                    sprtBalance.Close();
                }
            }
            catch (Exception)
            {
                continueReading = false;
                sprtBalance.Close();
            }
        }
        public void stopGettingWeigth()
        {
            continueReading = false;
        }
        private void getCoilInformation(string Code)
        {
            clsProduct objProduct = new clsProduct();

            objCoil = clsCoil.getDetailByCode(Code);
            objCoilCellar = clsCoil.getContainerCellarByCoil(objCoil.codsec);
            objCuttingStop = clsCoil.getCuttingStopByCoil(objCoil.codsec);

            if (objCoil.codsec != 0)
            {
                lblDensity.Text = Convert.ToString(Math.Round(objCoil.density, 5));
                lblNetWeight.Text = Convert.ToString(Math.Round(objCoil.netWeight, 2));
                txtLength.Text = Convert.ToString(Math.Round(objCoil.length, 2));
                lblBalance.Text = objCoil.BalanceName;
                lblWidth.Text = objCoil.width.ToString();
                txtDiameter.Text = objCoil.diameter.ToString();

                lblQuality.Text = objCoil.CuttingQualityName;
                
                objProduct = new clsProduct(objCoil.fkProduct);

                lblFilmName.Text = objProduct.code.Replace("-", "");
                lblPosition.Text = objCoil.cuttingPosition.ToString();
                lblStop.Text = objCoil.cuttingStop.ToString();

                objSalesOrderDetail = clsCoil.getSalesOrderDetailByCoil(objCoil.codsec);
                objSalesOrder = new clsSalesOrder(objSalesOrderDetail.fkSalesOrder);

                if (objCoil.treatmentSide == "Externo")
                    rdoTreatmentExternal.Checked = true;
                else if (objCoil.treatmentSide == "Interno")
                    rdoTreatmentInner.Checked = true;
                else if (objCoil.treatmentSide == "Doble")
                    rdoTreatmentDouble.Checked = true;
                else if (objCoil.treatmentSide == "Sin tratamiento")
                    rdoTreatmentWithout.Checked = true;

                if (objSalesOrder.codsec != 0)
                {
                    lblCustomer.Text = objSalesOrder.EntityName;
                    lblSalesOrderNumber.Text = objSalesOrder.number;
                }
                else
                {
                    lblCustomer.Text = "STOCK";
                    lblSalesOrderNumber.Text = "---";
                }
                lblCoilCellar.Text = objCoilCellar.name;
            }
        }
        private void frmCoilDetail_Load(object sender, EventArgs e)
        {
            try
            {

                ActiveControl = txtCode;

                thrdWeigth = new Thread(delegate() { getWeigth(); });
                if (sprtBalance.IsOpen)
                {
                    stopGettingWeigth();
                    sprtBalance.Close();
                }
                sprtBalance.PortName = "COM5";
                sprtBalance.ReadTimeout = 5000;
                sprtBalance.Open();
                continueReading = true;

                thrdWeigth.Start();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lblWeigthValue.ForeColor == Color.Black)
            {
                if (txtLength.Text != "" && txtDiameter.Text != "")
                {
                    objCoil.diameter = Convert.ToDouble(txtDiameter.Text);
                    objCoil.density = Convert.ToDouble(lblDensity.Text);
                    objCoil.length = Convert.ToDouble(txtLength.Text);
                    objCoil.netWeight = Convert.ToDouble(lblNetWeight.Text);
                    objCoil.grossWeight = Convert.ToDouble(lblWeigthValue.Text);

                    objCoil.save();


                    if (objCoil.codsec != 0)
                    {
                        if (clsCoil.IsInPallet(objCoil.codsec))
                        {

                            clsPallet objPallet = new clsPallet(clsCoil.getContainerPalletCodsecByCoil(objCoil.codsec));

                            if (objPallet.codsec != 0)
                            {
                                double newNetWeight = 0;
                                for (int i = 0; i < objPallet.lstCoil.Count; i++)
                                    newNetWeight += objPallet.lstCoil[i].netWeight;
                                
                                objPallet.netWeight = newNetWeight;
                                objPallet.save();
                            }
                        }
                    }

                    MessageBox.Show("Se ha registrado la bobina con éxito.", "registro de peso de bobinas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
        }

        private void frmCoilDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopGettingWeigth();
        }

        private void lblNetWeight_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblWeigthValue_TextChanged(object sender, EventArgs e)
        {
            if (clsGlobal.isNumeric(lblWeigthValue.Text))
            {
                if (objCoil.codsec != 0)
                {
                    double netWeigth = Convert.ToDouble(lblWeigthValue.Text) - (objCoil.width * (new clsCore(new clsProduct(objCoil.fkProduct).fkCore)).weigthPerMilimeter);

                    lblNetWeight.Text = Convert.ToString(Math.Round(netWeigth, 2));

                    lblDensity.Text = Convert.ToString(clsCoil.getCoilDensity(Convert.ToDouble(lblNetWeight.Text), Convert.ToDouble(txtDiameter.Text), (new clsCore(new clsProduct(objCoil.fkProduct).fkCore)), objCoil.width));
                }
            }
            else
            {
                MessageBox.Show("El valor debe ser Numérico", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }
    }
}