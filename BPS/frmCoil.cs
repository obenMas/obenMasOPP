using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms; 
using System.IO.Ports;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmCoil : Form
    {
        clsCuttingOrder objCuttingOrder = new clsCuttingOrder();
        clsCuttingStop objCuttingStop = new clsCuttingStop();
        clsCuttingOrderDetail objCuttingOrderDetail = new clsCuttingOrderDetail();
        clsSalesOrderDetail objSalesOrderDetail = new clsSalesOrderDetail();
        clsSalesOrder objSalesOrder = new clsSalesOrder();
        clsProduct objProduct = new clsProduct();

        clsCoil objCoil = new clsCoil();
        int position = 0;
        int stop = 0;

        public frmCoil()
        {
            InitializeComponent();
        }
        private bool validateForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtDiameter, ref lblDiameter, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtDensity, ref lblDensity, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtGrossWeigth, ref lblGrossWeigth, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbBalance, ref lblBalance, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbQuality, ref lblQuality, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbCoilCellar, ref lblCoilCellar, "selected")) isValid = false;

            return isValid;
        }
        public frmCoil(int parentCuttingOrder, int cuttingPosition, int cuttingStop, int cuttingStopCodsec, int salesOrderDetailCodsec, int cuttingOrderDetailCodsec)
        {
            InitializeComponent();
            objCuttingOrder = new clsCuttingOrder(parentCuttingOrder);
            objCuttingOrderDetail = new clsCuttingOrderDetail(cuttingOrderDetailCodsec);
            objCuttingStop = new clsCuttingStop(cuttingStopCodsec);
            objSalesOrderDetail = new clsSalesOrderDetail(salesOrderDetailCodsec);
            objSalesOrder = new clsSalesOrder(objSalesOrderDetail.fkSalesOrder);
            
            position = cuttingPosition;
            stop = cuttingStop;
        }
        private void setReportParameters()
        {
            crvCoilLabel.ParameterFieldInfo.Clear();

            ParameterDiscreteValue prmCoilCodsec = new ParameterDiscreteValue();
            prmCoilCodsec.Value = objCoil.codsec;

            ParameterField pfldCoilCodsec = new ParameterField();
            pfldCoilCodsec.Name = "mainCoilCodsec";
            pfldCoilCodsec.CurrentValues.Add(prmCoilCodsec);
            pfldCoilCodsec.HasCurrentValue = true;

            for (int i = 0; i < rptCoilLabel1.ParameterFields.Count; i++)
            {
                switch (rptCoilLabel1.ParameterFields[i].Name)
                {
                    case "coilCodsec":
                        rptCoilLabel1.ParameterFields[i].CurrentValues.Clear();
                        rptCoilLabel1.ParameterFields[i].CurrentValues.Add(prmCoilCodsec);
                        rptCoilLabel1.ParameterFields[i].HasCurrentValue = true;
                        rptCoilLabel1.ParameterFields[i].DefaultValues.Clear();
                        rptCoilLabel1.ParameterFields[i].DefaultValues.Add(prmCoilCodsec);
                        break;
                    default:
                        break;
                }
                crvCoilLabel.ParameterFieldInfo.Add(rptCoilLabel1.ParameterFields[i]);
            }
        }
        private void frmCoil_Load(object sender, EventArgs e)
        {
            clsMachine objMachine = new clsMachine();
            List<clsCuttingQuality> lstCuttingQuality = clsCuttingQuality.getList();
            List<clsMachine> lstMachine = clsMachine.getBalanceMachineList();
            List<clsCoilCellar> lstCoilCellar = clsCoilCellar.getInitialCellarList();
            objProduct = new clsProduct(objCuttingOrderDetail.product.codsec);
            
            double length = 0;
            grpbCuttingOrderInfo.Text = "Orden de corte # " + objCuttingOrder.number;
            lblPosition.Text = position.ToString();
            lblStop.Text = stop.ToString();
            lblFilmName.Text = objProduct.name;
            lblCutterName.Text = objCuttingOrder.machineName;
            lblWidth.Text = objProduct.width.ToString();

            objMachine.load(objCuttingOrder.fkMachine, "Cutter");

            for (int i = 0; i < objCuttingOrder.lstCuttingStop[stop-1].lstMainCoilByCuttingStop.Count; i++)
            {
                dgvMainCoilList.Rows.Add();
                dgvMainCoilList.Rows[i].Cells[0].Value = objCuttingOrder.lstCuttingStop[stop - 1].lstMainCoilByCuttingStop[i].mainCoil.codsec;
                dgvMainCoilList.Rows[i].Cells[1].Value = (new clsBopp(objCuttingOrder.lstCuttingStop[stop - 1].lstMainCoilByCuttingStop[i].mainCoil.fkBopp)).name;
                dgvMainCoilList.Rows[i].Cells[2].Value = objCuttingOrder.lstCuttingStop[stop - 1].lstMainCoilByCuttingStop[i].mainCoil.code;
                dgvMainCoilList.Rows[i].Cells[3].Value = objCuttingOrder.lstCuttingStop[stop - 1].lstMainCoilByCuttingStop[i].mainCoil.lotNumber;
                dgvMainCoilList.Rows[i].Cells[4].Value = Convert.ToString(Math.Round(objCuttingOrder.lstCuttingStop[stop - 1].lstMainCoilByCuttingStop[i].length, 2));
                length += objCuttingOrder.lstCuttingStop[stop - 1].lstMainCoilByCuttingStop[i].length;
            }
            for (int i = 0; i < lstCuttingQuality.Count; i++)
                cmbQuality.Items.Add(lstCuttingQuality[i]);

            for (int i = 0; i < lstMachine.Count; i++)
                cmbBalance.Items.Add(lstMachine[i]);

            for (int i = 0; i < lstCoilCellar.Count; i++)
                cmbCoilCellar.Items.Add(lstCoilCellar[i]);

            txtDiameter.Focus();
            txtDiameter.SelectAll();
            lblLength.Text = Convert.ToString(Math.Round(length, 2));
            lblCode.Text = DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + objCuttingStop.position.ToString() + objCuttingOrderDetail.position.ToString() + objMachine.Cutter.cutterNumber.ToString() + "1" + clsGlobal.FillWithZeros(((new clsSequential().coil).ToString()), 4) + "0";

            if (objSalesOrder.codsec > 0)
            {
                lblCustomer.Text = objSalesOrder.EntityName;
                lblSalesOrderNumber.Text = objSalesOrder.number;
            }
            else
            {
                lblCustomer.Text = "STOCK";
                lblSalesOrderNumber.Text = "---";
            }

            tbcCoil.TabPages.Remove(tbpLabel);
            if (objCoil.codsec > 0)
            {
                setReportParameters();
                tbcCoil.TabPages.Add(tbpLabel);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SerialPort serialPort = new SerialPort();


            byte[] buffer = new byte[255];
            serialPort = new SerialPort("COM1", 19200);
            serialPort.Open();
            txtGrossWeigth.Text = serialPort.ReadLine() + "\r\n";
            serialPort.Close();
        }

        private void btnCoilSave_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                objCoil.fkBalance = ((clsMachine)cmbBalance.SelectedItem).codsec;
                objCoil.fkCuttingQuality = ((clsCuttingQuality)cmbQuality.SelectedItem).codsec;
                objCoil.fkProduct = objProduct.codsec;
                objCoil.code = lblCode.Text;
                objCoil.length = Convert.ToDouble(lblLength.Text);
                objCoil.width = objProduct.width;
                objCoil.diameter = Convert.ToDouble(txtDiameter.Text);
                objCoil.density = Convert.ToDouble(txtDensity.Text);
                objCoil.cuttingPosition = Convert.ToInt32(lblPosition.Text);
                objCoil.cuttingStop = Convert.ToInt32(lblStop.Text);
                objCoil.netWeight = Convert.ToDouble(lblNetWeigth.Text);
                objCoil.grossWeight = Convert.ToDouble(txtGrossWeigth.Text);
                if (cmbQuality.Text != "Observación")
                {
                    objCoil.defects = "False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False";
                }
                else
                {
                    for (int i = 0; i < grpbDefects.Controls.Count; i++)
                    {
                        objCoil.defects += (((CheckBox)grpbDefects.Controls[i]).Checked) ? "True" : "False";
                        objCoil.defects += (i < grpbDefects.Controls.Count - 1) ? ";" : "";
                    }
                }
                objCoil.notes = txtNotes.Text;
                objCoil.cuttingDate = DateTime.Now;
                objCoil.createdDate = DateTime.Now;
                objCoil.modifiedDate = DateTime.Now;
                objCoil.createdBy = clsGlobal.LoggedUser.codsec;
                objCoil.modifiedBy = clsGlobal.LoggedUser.codsec;
                

                if (objCoil.save(objCuttingStop.codsec, objSalesOrderDetail.codsec, ((clsCoilCellar)cmbCoilCellar.SelectedItem).codsec,objCuttingOrderDetail.codsec))
                {
                    MessageBox.Show("La bobina se ha guardado con éxito.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

                    setReportParameters();
                    tbcCoil.TabPages.Add(tbpLabel);
                    tbcCoil.TabIndex = 1;
                }
                else
                {
                    MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
        }

        private void cmbQuality_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbQuality.Text == "Observación")
                grpbDefects.Enabled = true;
            else
                grpbDefects.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            objSalesOrder = new clsSalesOrder();
            objSalesOrderDetail = new clsSalesOrderDetail();
            lblCustomer.Text = "STOCK";
            lblSalesOrderNumber.Text = "---";

        }

        private void txtGrossWeigth_TextChanged(object sender, EventArgs e)
        {
            if (clsGlobal.isNumeric(txtGrossWeigth.Text))
            {
                double netWeigth = Convert.ToDouble(txtGrossWeigth.Text) - (objProduct.width * (new clsCore(objProduct.fkCore)).weigthPerMilimeter);

                lblNetWeigth.Text = Convert.ToString(Math.Round(netWeigth, 2));

                txtDensity.Text = Convert.ToString(clsCoil.getCoilDensity(Convert.ToDouble(lblNetWeigth.Text), Convert.ToDouble(txtDiameter.Text), new clsCore(objProduct.fkCore), objProduct.width));
            }
            else
            {
                MessageBox.Show("El valor debe ser Numérico", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {

        }

        private void cmbBalance_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsMachine> lstMachine = clsMachine.getBalanceMachineList();
                for (int i = 0; i < lstMachine.Count; i++)
                    cmbBalance.Items.Add(lstMachine[i]); 
            }
        }

        private void cmbQuality_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsCuttingQuality> lstCuttingQuality = clsCuttingQuality.getList();
                for (int i = 0; i < lstCuttingQuality.Count; i++)
                    cmbQuality.Items.Add(lstCuttingQuality[i]);
            }
        }

        private void cmbCoilCellar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsCoilCellar> lstCoilCellar = clsCoilCellar.getInitialCellarList();
                for (int i = 0; i < lstCoilCellar.Count; i++)
                    cmbCoilCellar.Items.Add(lstCoilCellar[i]); 
            }
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {

        }

    }
}