using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;
using BPS.Bussiness;

namespace BPS.Lite
{
    public partial class frmCuttingOrderSummary : Form
    {
        clsCuttingOrder objCuttingOrder = new clsCuttingOrder();
        clsMachine objMachine = new clsMachine();
        clsMainCoil objMainCoil = new clsMainCoil();
        clsCoil objCoil = new clsCoil();
        Thread thrdWeigth;
        static SerialPort sprtBalance = new SerialPort();
        public volatile bool continueReading = true;
        List<clsCoilInformationByCuttingStop> lstCoilInformation = new List<clsCoilInformationByCuttingStop>();

        private bool validateToClose()
        {
            bool isValid = true;


            return isValid;
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
        public void getStopLayoutByCuttingStop(int cuttingStopCodsec)
        {
            clsCuttingStop objCuttingStop = new clsCuttingStop(cuttingStopCodsec);
            List<clsCoilInformationByCuttingStop> lstExistingCoilInformation = clsCoilInformationByCuttingStop.getListByCuttingStop(objCuttingStop.codsec);
            bool flgExist = false;
            int existingPosition = -1;

            grpbStop.Text = "Parada # " + objCuttingStop.position.ToString();
            grpbStop.Tag = objCuttingStop.codsec;

            dgvCoils.Rows.Clear();
            lstCoilInformation.Clear();

            for (int i = 0; i < objCuttingOrder.lstCuttingOrderDetail.Count; i++)
            {
                existingPosition = -1;
                flgExist = false;
                for (int j = 0; j < lstExistingCoilInformation.Count; j++)
                {
                    if (lstExistingCoilInformation[j].position == i + 1)
                    {
                        flgExist = true;
                        existingPosition = j;
                    }
                }

                if (flgExist)
                    lstCoilInformation.Add(lstExistingCoilInformation[existingPosition]);
                else
                    lstCoilInformation.Add(new clsCoilInformationByCuttingStop());
            }

            for (int i = 0; i < objCuttingOrder.lstCuttingOrderDetail.Count; i++)
            {

                dgvCoils.Rows.Add();
                dgvCoils.Rows[i].Cells[clmCodsec.Index].Value = lstCoilInformation[i].codsec;
                dgvCoils.Rows[i].Cells[clmOrderNumber.Index].Value = (objCuttingOrder.lstCuttingOrderDetail[i].companyName != "") ? objCuttingOrder.lstCuttingOrderDetail[i].companyName : "Stock";
                dgvCoils.Rows[i].Cells[clmPosition.Index].Value = i + 1;
                dgvCoils.Rows[i].Cells[clmWidth.Index].Value = objCuttingOrder.lstCuttingOrderDetail[i].width;
                dgvCoils.Rows[i].Cells[clmWeigth.Index].Value = lstCoilInformation[i].weigth;
                dgvCoils.Rows[i].Cells[clmDiameter.Index].Value = lstCoilInformation[i].diameter;
            }

            lblPositionValue.Text = "1";
            lblWeigthValue.Text = "0";
            lblWidthValue.Text = objCuttingOrder.lstCuttingOrderDetail[0].width.ToString();
            txtDiameter.Text = "0.0";
            txtDiameter.Focus();
            txtDiameter.SelectAll();
        }

        private void setStopLayout()
        {
            trvStopViews.Nodes[0].Text = "Orden de corte # " + objCuttingOrder.number;
            trvStopViews.Nodes[0].Nodes.Clear();


            for (int i = 0; i < objCuttingOrder.lstCuttingStop.Count; i++)
            {
                TreeNode trnNode = new TreeNode();
                trnNode.Text = "Parada #" + (i + 1).ToString();
                trnNode.Tag = objCuttingOrder.lstCuttingStop[i].codsec;

                if (objCuttingOrder.lstCuttingStop[i].closed == true)
                {
                    trnNode.ImageIndex = 1;
                    trnNode.SelectedImageIndex = 1;
                }
                else
                {
                    trnNode.ImageIndex = 0;
                    trnNode.SelectedImageIndex = 0;
                }
                trvStopViews.Nodes[0].Nodes.Add(trnNode);
            }

            trvStopViews.ExpandAll();
        }

        public frmCuttingOrderSummary()
        {
            InitializeComponent();
        }
        public frmCuttingOrderSummary(int cuttingOrderCodsec)
        {
            InitializeComponent();
            objCuttingOrder.load(cuttingOrderCodsec);
            objMachine.load(objCuttingOrder.fkMachine, "Cutter");
        }
        private void frmCuttingOrderSummary_Load(object sender, EventArgs e)
        {
            if (objCuttingOrder.codsec > 0)
            {
                try
                {
                    lblCutterName.Text = objCuttingOrder.machineName;
                    lblFilmName.Text = objCuttingOrder.lstCuttingOrderDetail[0].product.boppCode.Replace("-", "");
                    grpbInfo.Text = "Orden de corte # " + objCuttingOrder.number;
                    setStopLayout();

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
                    MessageBox.Show("No se ha detectado la conexión con la balanza, se realizará la toma manual del peso bruto del pallet.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    chkManualWeight.Checked = true;
                    chkManualWeight.Enabled = false;
                }
            }

        }

        private void trvStopViews_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag != null)
                getStopLayoutByCuttingStop(Convert.ToInt32(e.Node.Tag));

            txtDiameter.Focus();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (objCuttingOrder.codsec != 0)
            {

            }
            else
                MessageBox.Show("A sucedido un error", "registro de peso de bobinas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frmCuttingOrderSummary_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopGettingWeigth();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsCoilInformationByCuttingStop objCoilInformationByStop = new clsCoilInformationByCuttingStop();
            clsCuttingStop objCuttingStop = new clsCuttingStop(Convert.ToInt32(grpbStop.Tag));

            if (lblWeigthValue.ForeColor == Color.Black || chkManualWeight.Checked == true)
            {
                if (Convert.ToDouble(txtDiameter.Text) > 0)
                {
                    objCoilInformationByStop.codsec = lstCoilInformation[Convert.ToInt32(lblPositionValue.Text) - 1].codsec;
                    objCoilInformationByStop.fkCuttingStop = objCuttingStop.codsec;
                    objCoilInformationByStop.position = Convert.ToInt32(lblPositionValue.Text);
                    objCoilInformationByStop.weigth = Convert.ToDouble(lblWeigthValue.Text);
                    objCoilInformationByStop.diameter = Convert.ToDouble(txtDiameter.Text);

                    objCoilInformationByStop.save();

                    lstCoilInformation[Convert.ToInt32(lblPositionValue.Text) - 1].codsec = objCoilInformationByStop.codsec;

                    dgvCoils.Rows[Convert.ToInt32(lblPositionValue.Text) - 1].Cells[clmCodsec.Index].Value = objCoilInformationByStop.codsec;
                    dgvCoils.Rows[Convert.ToInt32(lblPositionValue.Text) - 1].Cells[clmDiameter.Index].Value = objCoilInformationByStop.diameter;
                    dgvCoils.Rows[Convert.ToInt32(lblPositionValue.Text) - 1].Cells[clmWeigth.Index].Value = objCoilInformationByStop.weigth;


                    MessageBox.Show("Se ha registrado la bobina con éxito.", "registro de peso de bobinas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (objCuttingOrder.lstCuttingOrderDetail.Count > Convert.ToInt32(lblPositionValue.Text))
                    {
                        lblPositionValue.Text = (Convert.ToInt32(lblPositionValue.Text) + 1).ToString();
                        txtDiameter.Text = "0.0";
                        lblWidthValue.Text = objCuttingOrder.lstCuttingOrderDetail[Convert.ToInt32(lblPositionValue.Text) - 1].width.ToString();
                        txtManualGrossWeigth.Text = "0.0";
                        txtDiameter.Focus();
                        txtDiameter.SelectAll();
                    }
                }
                else
                    MessageBox.Show("Debe registrar el valor del diametro de la bobina.", "registro de peso de bobinas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Debe esperar a que la balanza este estable para registrar el peso correcto.", "registro de peso de bobinas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgvCoils_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblPositionValue.Text = dgvCoils.Rows[e.RowIndex].Cells[clmPosition.Index].Value.ToString();
            txtDiameter.Text = dgvCoils.Rows[e.RowIndex].Cells[clmDiameter.Index].Value.ToString();
            lblWidthValue.Text = objCuttingOrder.lstCuttingOrderDetail[e.RowIndex].width.ToString();
            txtDiameter.Focus();
            txtDiameter.SelectAll();
        }

        private void lblWeigthValue_TextChanged(object sender, EventArgs e)
        {


            if (clsGlobal.isNumeric(lblWeigthValue.Text))
            {
                if ((Convert.ToInt32(lblPositionValue.Text)) > 0)
                {
                    double netWeigth = Convert.ToDouble(lblWeigthValue.Text) - (objCuttingOrder.lstCuttingOrderDetail[(Convert.ToInt32(lblPositionValue.Text) - 1)].product.width * (new clsCore(objCuttingOrder.lstCuttingOrderDetail[(Convert.ToInt32(lblPositionValue.Text) - 1)].product.fkCore)).weigthPerMilimeter);

                    lblNetWeight.Text = Convert.ToString(Math.Round(netWeigth, 2));

                    lblDensity.Text = Convert.ToString(clsCoil.getCoilDensity(Convert.ToDouble(lblNetWeight.Text), Convert.ToDouble(txtDiameter.Text), new clsCore(objCuttingOrder.lstCuttingOrderDetail[(Convert.ToInt32(lblPositionValue.Text) - 1)].product.fkCore), objCuttingOrder.lstCuttingOrderDetail[(Convert.ToInt32(lblPositionValue.Text) - 1)].product.width));
                }
            }
            else
            {
                MessageBox.Show("El valor debe ser Numérico", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void txtDiameter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                clsCoilInformationByCuttingStop objCoilInformationByStop = new clsCoilInformationByCuttingStop();
                clsCuttingStop objCuttingStop = new clsCuttingStop(Convert.ToInt32(grpbStop.Tag));

                if (lblWeigthValue.ForeColor == Color.Black)
                {
                    if (Convert.ToDouble(txtDiameter.Text) > 0)
                    {
                        objCoilInformationByStop.codsec = lstCoilInformation[Convert.ToInt32(lblPositionValue.Text) - 1].codsec;
                        objCoilInformationByStop.fkCuttingStop = objCuttingStop.codsec;
                        objCoilInformationByStop.position = Convert.ToInt32(lblPositionValue.Text);
                        objCoilInformationByStop.weigth = Convert.ToDouble(lblWeigthValue.Text);
                        objCoilInformationByStop.diameter = Convert.ToDouble(txtDiameter.Text);

                        objCoilInformationByStop.save();

                        lstCoilInformation[Convert.ToInt32(lblPositionValue.Text) - 1].codsec = objCoilInformationByStop.codsec;

                        dgvCoils.Rows[Convert.ToInt32(lblPositionValue.Text) - 1].Cells[clmCodsec.Index].Value = objCoilInformationByStop.codsec;
                        dgvCoils.Rows[Convert.ToInt32(lblPositionValue.Text) - 1].Cells[clmDiameter.Index].Value = objCoilInformationByStop.diameter;
                        dgvCoils.Rows[Convert.ToInt32(lblPositionValue.Text) - 1].Cells[clmWeigth.Index].Value = objCoilInformationByStop.weigth;


                        MessageBox.Show("Se ha registrado la bobina con éxito.", "registro de peso de bobinas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (objCuttingOrder.lstCuttingOrderDetail.Count > Convert.ToInt32(lblPositionValue.Text))
                        {
                            lblPositionValue.Text = (Convert.ToInt32(lblPositionValue.Text) + 1).ToString();
                            txtDiameter.Text = "0.0";
                            lblWidthValue.Text = objCuttingOrder.lstCuttingOrderDetail[Convert.ToInt32(lblPositionValue.Text) - 1].width.ToString();
                            txtDiameter.Focus();
                            txtDiameter.SelectAll();
                        }
                    }
                    else
                        MessageBox.Show("Debe registrar el valor del diametro de la bobina.", "registro de peso de bobinas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Debe esperar a que la balanza este estable para registrar el peso correcto.", "registro de peso de bobinas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void trvStopViews_AfterSelect(object sender, TreeViewEventArgs e)
        {
            txtDiameter.Focus();
        }

        private void txtDiameter_TextChanged(object sender, EventArgs e)
        {
            if (clsGlobal.isNumeric(txtDiameter.Text))
            {
                if ((Convert.ToInt32(lblPositionValue.Text)) > 0)
                {
                    double netWeigth = Convert.ToDouble(lblWeigthValue.Text) - (objCuttingOrder.lstCuttingOrderDetail[(Convert.ToInt32(lblPositionValue.Text) - 1)].product.width * (new clsCore(objCuttingOrder.lstCuttingOrderDetail[(Convert.ToInt32(lblPositionValue.Text) - 1)].product.fkCore)).weigthPerMilimeter);

                    lblNetWeight.Text = Convert.ToString(Math.Round(netWeigth, 2));

                    lblDensity.Text = Convert.ToString(clsCoil.getCoilDensity(Convert.ToDouble(lblNetWeight.Text), Convert.ToDouble(txtDiameter.Text), new clsCore(objCuttingOrder.lstCuttingOrderDetail[(Convert.ToInt32(lblPositionValue.Text) - 1)].product.fkCore), objCuttingOrder.lstCuttingOrderDetail[(Convert.ToInt32(lblPositionValue.Text) - 1)].product.width));
                }
            }
            else
            {
                MessageBox.Show("El valor debe ser Numérico", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                txtDiameter.Text = "0";
                txtDiameter.SelectAll();
            }
        }

        private void chkManualWeight_CheckedChanged(object sender, EventArgs e)
        {
            if (chkManualWeight.Checked == true)
            {
                stopGettingWeigth();
                txtManualGrossWeigth.Visible = true;
                txtManualGrossWeigth.Focus();
            }
            else
            {
                try
                {
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtManualGrossWeigth_TextChanged(object sender, EventArgs e)
        {
            lblWeigthValue.Text = txtManualGrossWeigth.Text;
        }

    }
}