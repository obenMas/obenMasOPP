using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Drawing.Printing;
using System.Threading;
using System.IO.Ports;

namespace BPS.Lite
{
    public partial class frmNewCoilRegistration : Form
    {
        int plant = 0;
        string lote;
        string maincoil;
        string cstop;
        string cuttingod;
        clsProduct objprod = new clsProduct();
        Thread thrdWeigth;
        static SerialPort sprtBalance = new SerialPort();
        public volatile bool continueReading = true;
        clsBalance balance = new clsBalance();

        public frmNewCoilRegistration(string cuttingOrder,string repetition,string position,string customer,string saleorderdetail,string product,string length,string lot, string main,string cuttingstop,string cuttingorderdetail,bool isImported)
        {
            InitializeComponent();
            txtCuttingOrder.Text = cuttingOrder;
            txtRep.Text = repetition;
            txtPosition.Text = position;
            txtCustomer.Text = customer;
            txtSalesOrderDetail.Text = saleorderdetail;
            txtProduct.Text = product;
            objprod = new clsProduct(product);
            txtLength.Text = length;
            lote = lot;
            maincoil = main;
            cstop = cuttingstop;
            cuttingod = cuttingorderdetail;
            chkImportada.Checked = isImported;
            if (clsGlobal.LoggedUser.fkRole == 11 || clsGlobal.LoggedUser.fkRole == 12 || clsGlobal.LoggedUser.fkRole == 14 || clsGlobal.LoggedUser.fkRole == 2022 || clsGlobal.LoggedUser.fkRole == 2023 || clsGlobal.LoggedUser.fkRole == 2024)
            {
                plant = 3;
            }

            if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)
            {
                plant = 4;
            }

            List<clsCuttingQuality> cqlist= clsCuttingQuality.getList();
            cmbQuality.Items.Clear();
            for(int i=0;i<cqlist.Count;i++)
            {
                cmbQuality.Items.Add(cqlist[i].name);
            }

            List<clsMachine> blist=clsMachine.getBalanceMachineList();
            cmbBalance.Items.Clear();
            for(int i=0;i<blist.Count;i++)
            {
                cmbBalance.Items.Add(blist[i].Balance.name);
            }

            List<clsCoilCellar> cclist = clsCoilCellar.getInitialCellarList(plant);
            for(int i=0;i<cclist.Count;i++)
            {
                cmbDepot.Items.Add(cclist[i].name);
            }
            if(plant==3)
            {
                cmbDepot.SelectedIndex = 1;
            }
            else
            {
                cmbDepot.SelectedIndex = 0;
            }
            

            for (int i = 0; i < cmbBalance.Items.Count; i++)
            {
                if (clsGlobal.LoggedUser.fkRole == new clsBalance(cmbBalance.Items[i].ToString()).fkRole && clsGlobal.LoggedUser.codsec == 5115)
                {
                    cmbBalance.SelectedIndex = 2;
                    break;
                }
                else if (clsGlobal.LoggedUser.fkRole == new clsBalance(cmbBalance.Items[i].ToString()).fkRole)
                {
                    cmbBalance.SelectedIndex = i;
                    break;
                }
            }
            int coilSeq = (new clsSequential().coil);
            
            string pos;
            if(Convert.ToInt32(txtPosition.Text)<10)
            {
                pos = "0" + txtPosition.Text;
            }
            else
            {
                pos = txtPosition.Text;
            }

            string rep;
            if (Convert.ToInt32(txtRep.Text) < 10)
            {
                rep = "0" + txtRep.Text;
            }
            else
            {
                rep = txtRep.Text;
            }
            txtCoilCode.Text = DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + new clsPlant(plant).abr + txtCuttingOrder.Text + "R" + rep + "P" + pos + "A00";//+ clsGlobal.FillWithZeros(((coilSeq).ToString()), 5) + "0";
            
        }

        private void cmbQuality_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbQuality.SelectedIndex!=-1)
            {
                if(cmbQuality.Items[cmbQuality.SelectedIndex].ToString()!="Primera")
                {
                    grpbDefects.Enabled = true;
                }
                else
                {
                    grpbDefects.Enabled = false;
                    cmbDepot.Focus();
                }
            }
            
        }

        private void chkManual_CheckedChanged(object sender, EventArgs e)
        {
            if(chkManual.Checked)
            {
                txtGrossWeigth.Enabled = true;
                txtGrossWeigth.Focus();
            }
            else
            {
                txtGrossWeigth.Enabled = false;
                setupBalance();
            }
        }

        private void cmbDepot_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbDepot.SelectedIndex!=-1)
            {
                cmbBalance.Focus();
            }
        }

        private void cmbBalance_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbBalance.SelectedIndex!=-1)
            {
                balance = new clsBalance(cmbBalance.Items[cmbBalance.SelectedIndex].ToString());
                setupBalance();
                if(chkManual.Checked)
                {
                    txtGrossWeigth.Focus();
                }
                else
                {
                    txtDiameter.Focus();
                }
                
            }
        }

        private void txtDiameter_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btnCoilSave.Focus();
            }
        }

        private bool validateForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtDiameter, ref lblDiameter, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtGrossWeigth, ref lblGrossWeigth, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbBalance, ref lblBalance, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbQuality, ref lblQuality, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbDepot, ref lblDepot, "selected")) isValid = false;

            return isValid;
        }

        private void btnCoilSave_Click(object sender, EventArgs e)
        {
            clsCoil objcoil = clsCoil.getDetailByCode(txtCoilCode.Text);

            if (validateForm())
            {
                objcoil.fkBalance = clsMachine.getBalanceCodsec(new clsBalance(cmbBalance.Items[cmbBalance.SelectedIndex].ToString()).codsec);
                clsCuttingQuality objq = clsCuttingQuality.getQualityByName(cmbQuality.Items[cmbQuality.SelectedIndex].ToString());
                objcoil.fkCuttingQuality = objq.codsec;
                clsProduct objProduct = new clsProduct(txtProduct.Text);
                objcoil.fkProduct = objProduct.codsec;
                objcoil.code = txtCoilCode.Text;
                objcoil.length = Convert.ToDouble(txtLength.Text);
                objcoil.width = objProduct.width;
                objcoil.diameter = Convert.ToDouble(txtDiameter.Text);
                objcoil.cuttingPosition = Convert.ToInt32(txtPosition.Text);
                objcoil.cuttingStop = Convert.ToInt32(txtRep.Text);
                objcoil.netWeight = Convert.ToDouble(txtNetWeigth.Text);
                objcoil.grossWeight = Convert.ToDouble(txtGrossWeigth.Text);
                objcoil.treatmentSide = "Externo";

                if (cmbQuality.Text == "Primera")
                {
                    objcoil.defects = "False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False";
                }
                else
                {
                    objcoil.defects = "";
                    for (int i = 0; i < grpbDefects.Controls.Count; i++)
                    {
                        objcoil.defects += (((CheckBox)grpbDefects.Controls[i]).Checked) ? "True" : "False";
                        objcoil.defects += (i < grpbDefects.Controls.Count - 1) ? ";" : "";
                    }
                }
                objcoil.notes = txtNotes.Text;
                objcoil.cuttingDate = DateTime.Now;
                objcoil.createdDate = DateTime.Now;
                objcoil.modifiedDate = DateTime.Now;
                objcoil.createdBy = clsGlobal.LoggedUser.codsec;
                objcoil.modifiedBy = clsGlobal.LoggedUser.codsec;
                objcoil.isExternalCoil = chkImportada.Checked;
                objcoil.externalLabelPrint = false;
                objcoil.lotNumber = lote;              
                
                objcoil.mainCoilCode = maincoil;
                clsMainCoil objmain = new clsMainCoil(maincoil);
                objcoil.extrusionDate = objmain.createdDate;
                clsCoilCellar objcellar = new clsCoilCellar(cmbDepot.Items[cmbDepot.SelectedIndex].ToString());
                objcoil.cellar = objcellar.codsec;
                if (objcoil.save(Convert.ToInt32(cstop), Convert.ToInt32(txtSalesOrderDetail.Text), objcellar.codsec, Convert.ToInt32(cuttingod)))
                {

                    if (MessageBox.Show("Desea imprimir la etiqueta?", "Registro de Bobina", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                    {

                        Thread thrdPrint;
                        switch (plant)
                        {
                            case 3:
                                thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabel(objcoil.codsec, objcoil.externalLabelPrint); });
                                thrdPrint.Start();
                                thrdPrint.Join();
                                break;
                            case 4:
                                thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabelPL(objcoil.codsec, objcoil.externalLabelPrint); });
                                thrdPrint.Start();
                                thrdPrint.Join();
                                break;
                            default:
                                thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabel(objcoil.codsec, objcoil.externalLabelPrint); });
                                thrdPrint.Start();
                                thrdPrint.Join();
                                break;
                        }


                    }
                    MessageBox.Show("La bobina se ha guardado con éxito.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
                

            }
        }

        private void txtGrossWeigth_TextChanged(object sender, EventArgs e)
        {
            double netWeigth = 0;

            try
            {
                if (txtGrossWeigth.Text != "")
                {
                    if (clsGlobal.isNumeric(txtGrossWeigth.Text))
                    {
                        if (objprod.width < 1600)
                        {
                            //resto el peso del core de carton de 8mm de 3 o de 6 pulgadas
                            netWeigth = Convert.ToDouble(txtGrossWeigth.Text) - (objprod.width * (new clsCore(objprod.fkCore)).weigthPerMilimeter);
                        }
                        else
                        {
                            //resta el peso del core de carton de 15mm de 6 pulgadas
                            netWeigth = Convert.ToDouble(txtGrossWeigth.Text) - (objprod.width * (new clsCore(objprod.fkCore)).weigthPerMilimeter2);
                        }


                        txtNetWeigth.Text = Convert.ToString(Math.Round(netWeigth, 1));
                    }
                    else
                        MessageBox.Show("El valor debe ser Numérico", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
                else
                {
                    txtGrossWeigth.Text = "0";
                }
            }
            catch(Exception ex)
            {
                clsLog.addLog(ex, 2, "Registro de bobinas");
            }
        }

        public bool isnumber(string st)
        {
            switch (st)
            {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    return true;
                default:
                    return false;
            }
        }

        private void getWeigth()
        {
            try
            {
                
                string texto = "";
                string texto2 = "";

                while (continueReading)
                {
                    if(balance.codsec!=0)
                    {
                        string strReceivedData = "";

                        if (sprtBalance.IsOpen)
                        {
                            sprtBalance.Close();
                        }
                        sprtBalance.PortName = "COM" + balance.comm;
                        sprtBalance.ReadTimeout = 5000;
                        sprtBalance.Open();

                        if (balance.command != string.Empty)
                        {
                            //sprtBalance.Write(this.blc_command + "\r");
                            sprtBalance.WriteLine(balance.command + "\r");

                            texto = sprtBalance.ReadLine();
                            
                            if (texto != string.Empty)
                            {
                                if (texto.Length >= balance.dataLen + balance.dataInit)
                                {
                                    strReceivedData = texto.Substring(balance.dataInit, balance.dataLen);
                                }
                                else
                                {
                                    strReceivedData = texto.Substring(balance.dataInit, texto.Length - balance.dataInit);
                                }
                            }
                        }
                        else
                        {
                            strReceivedData = sprtBalance.ReadTo("\r");
                            texto2 = strReceivedData;
                            strReceivedData = "0";

                            if(texto2.StartsWith("E"))
                            {
                                for (int i = 1; i < balance.dataLen; i++)
                                {
                                    if (isnumber(texto2.Substring(i, 1)))
                                    {
                                        strReceivedData += texto2.Substring(i, 1);
                                    }
                                }
                                if (Convert.ToDouble(strReceivedData) % 1 != 0)
                                {
                                    strReceivedData = (Convert.ToDouble(strReceivedData) / 10).ToString();
                                }

                            }
                            

                        }

                        this.Invoke((MethodInvoker)delegate { txtGrossWeigth.Text = Math.Round(Convert.ToDouble(strReceivedData.Substring(0, strReceivedData.Length - 2)), 2).ToString("N2").Trim(); });
                        
                    }
                    sprtBalance.Close();
                 }
                    
            }
            catch (Exception)
            {
                sprtBalance.Close();
            }
        }
        public void stopGettingWeigth()
        {
            continueReading = false;
        }

        public void setupBalance()
        {
            if (Convert.ToInt32(txtCuttingOrder.Text)>0)
            {
                try
                {
                    thrdWeigth = new Thread(delegate() { getWeigth(); });
                    if (sprtBalance.IsOpen)
                    {
                        stopGettingWeigth();
                        sprtBalance.Close();
                    }
                    sprtBalance.PortName = "COM" + balance.comm;
                    sprtBalance.ReadTimeout = 5000;
                    sprtBalance.Open();
                    continueReading = true;

                    thrdWeigth.Start();

                }
                catch (Exception)
                {
                    MessageBox.Show("No se ha detectado la conexión con la balanza, se realizará la toma manual del peso bruto de la bobina.", "Notificación de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    chkManual.Checked = true;
                }
            }
        }

    }
}
