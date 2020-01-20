using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms; 
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Drawing.Printing;
using System.Threading;
using BPS.Bussiness;


namespace BPS
{
    public partial class frmCoilRegistrationBCK : Form
    {
        clsCuttingStop objCuttingStop = new clsCuttingStop();
        clsCuttingOrder objCuttingOrder = new clsCuttingOrder();
        List<Label> lstLblCoilsLabels = new List<Label>();
        List<Label> lstLblCoils = new List<Label>();
        clsMachine objMachine = new clsMachine();
        List<clsCoil> lstCoil = new List<clsCoil>();
        clsProduct objProduct = new clsProduct();
        clsSalesOrderDetail objSalesOrderDetail = new clsSalesOrderDetail();
        clsSalesOrder objSalesOrder = new clsSalesOrder();
        List<clsCoilInformationByCuttingStop> lstCoilInformation = new List<clsCoilInformationByCuttingStop>();
        bool isExternalCoil = false;

        int selectedCoilIndex = -1;

        public frmCoilRegistrationBCK()
        {
            InitializeComponent();
        }
        public frmCoilRegistrationBCK(int cuttingStopCodsec)
        {
            InitializeComponent();
            objCuttingStop = new clsCuttingStop(cuttingStopCodsec);
            objCuttingOrder = new clsCuttingOrder(objCuttingStop.fkCuttingOrder);
            objMachine.load(objCuttingOrder.fkMachine,"Cutter");
            lstCoilInformation = clsCoilInformationByCuttingStop.getListByCuttingStop(objCuttingStop.codsec);

            if (objCuttingOrder.isSecundaryCut)
            {
                for (int i = 0; i < objCuttingStop.lstSecundaryCutCoil.Count; i++)
                {
                    if (objCuttingStop.lstSecundaryCutCoil[i].objCoil.isExternalCoil)
                        isExternalCoil = true;
                }
            }

        }
        private bool validateForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtDiameter, ref lblDiameter, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtGrossWeigth, ref lblGrossWeigth, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbBalance, ref lblBalance, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbQuality, ref lblQuality, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbCoilCellar, ref lblCoilCellar, "selected")) isValid = false;

            return isValid;
        }
        public void loadCoilLayout()
        {
            lstLblCoils = new List<Label>();
            lstLblCoilsLabels = new List<Label>();
            int relativePosition = 21;
            double usedWidth = 0;
            int totalUsedWidth = 0;
            double length = 0;

            int coilSeq = (new clsSequential().coil);

            if (objCuttingOrder.isSecundaryCut == false)
            {
                for (int i = 0; i < objCuttingStop.lstMainCoilByCuttingStop.Count; i++)
                {
                    length += objCuttingStop.lstMainCoilByCuttingStop[i].length;
                }
            }
            else
            {
                for (int i = 0; i < objCuttingStop.lstSecundaryCutCoil.Count; i++)
                {
                    length += objCuttingStop.lstSecundaryCutCoil[i].length;
                }
            }

            for (int i = 0; i < objCuttingOrder.lstCuttingOrderDetail.Count; i++)
                totalUsedWidth += Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width);

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

                    lstLblCoils.Add(new Label());
                    lstLblCoils[i].BackColor = clsGlobal.getColorByPosition(i, objCuttingOrder.lstCuttingOrderDetail.Count);
                    lstLblCoils[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    lstLblCoils[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lstLblCoils[i].Location = new System.Drawing.Point(relativePosition, 44);
                    lstLblCoils[i].Name = "lblCoil" + i.ToString();
                    lstLblCoils[i].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width), 1228), 150);
                    lstLblCoils[i].TabIndex = 0;
                    lstLblCoils[i].Tag = 0;

                    clsProduct objProduct = new clsProduct(objCuttingOrder.lstCuttingOrderDetail[i].fkProduct);

                    if (objCuttingOrder.lstCuttingOrderDetail[i].salesOrderNumber != "")
                    {
                        clsSalesOrderDetail objSalesOrderDetail = new clsSalesOrderDetail(objCuttingOrder.lstCuttingOrderDetail[i].fkSalesOrderDetail);
                        clsSalesOrder objSalesOrder = new clsSalesOrder(objSalesOrderDetail.fkSalesOrder);

                        lstLblCoils[i].Text = "Orden   : " + objCuttingOrder.lstCuttingOrderDetail[i].salesOrderNumber + "\n";
                        lstLblCoils[i].Text += "Cliente  : " + objSalesOrder.EntityName + "\n";
                        //lstLblCoils[i].Text += "Código  : " + DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + objCuttingStop.position.ToString() + (i + 1).ToString() + objMachine.Cutter.cutterNumber.ToString() + "1" + clsGlobal.FillWithZeros(((coilSeq).ToString()), 4) + "0" + "\n";
                        lstLblCoils[i].Text += "Código  : --------------\n";
                        lstLblCoils[i].Text += "Ancho   :  " + objCuttingOrder.lstCuttingOrderDetail[i].width.ToString() + "mm\n";
                        lstLblCoils[i].Text += "Metraje : " + length + " m\n";
                        lstLblCoils[i].Text += "Diametro : --- cm\n";
                        lstLblCoils[i].Text += "Core : " + objProduct.CoreValue + "\"\n";
                        lstLblCoils[i].Text += "Peso : --- Kg\n";
                        lstLblCoils[i].Text += "Densidad : --- Kg/cm3\n";
                        lstLblCoils[i].Text += "Calidad : ---\n";

                        coilSeq++;
                    }
                    else
                    {
                        lstLblCoils[i].Text = "Orden   : -----\n";
                        lstLblCoils[i].Text += "Cliente  : STOCK\n";
                        //lstLblCoils[i].Text += "Código  : " + DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + objCuttingStop.position.ToString() + (i + 1).ToString() + objMachine.Cutter.cutterNumber.ToString() + "1" + clsGlobal.FillWithZeros(((coilSeq).ToString()), 4) + "0" + "\n";
                        lstLblCoils[i].Text += "Código  : --------------\n";
                        lstLblCoils[i].Text += "Ancho   :  " + objCuttingOrder.lstCuttingOrderDetail[i].width.ToString() + "mm\n";
                        lstLblCoils[i].Text += "Metraje : " + length + " m\n";
                        lstLblCoils[i].Text += "Diametro : --- cm\n";
                        lstLblCoils[i].Text += "Core : " + objProduct.CoreValue + "\"\n";
                        lstLblCoils[i].Text += "Peso : --- Kg\n";
                        lstLblCoils[i].Text += "Densidad : --- Kg/cm3\n";
                        lstLblCoils[i].Text += "Calidad : ---\n";

                        coilSeq++;
                    }

                    lstLblCoils[i].TextAlign = System.Drawing.ContentAlignment.TopLeft;
                    usedWidth += Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width);
                    grpbCombination.Controls.Add(lstLblCoils[i]);


                    lstLblCoilsLabels.Add(new Label());
                    lstLblCoilsLabels[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    lstLblCoilsLabels[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lstLblCoilsLabels[i].Location = new System.Drawing.Point(relativePosition, 22);
                    lstLblCoilsLabels[i].Name = "lblCoilLabel" + (i + 1).ToString();
                    lstLblCoilsLabels[i].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width), 1228), 22);
                    lstLblCoilsLabels[i].TabIndex = 3;
                    lstLblCoilsLabels[i].Text = "Bobina " + (i + 1).ToString();
                    lstLblCoilsLabels[i].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    lstLblCoilsLabels[i].Tag = i * 2;
                    lstLblCoilsLabels[i].Click += new System.EventHandler(this.selectCoil);
                    lstLblCoilsLabels[i].Cursor = System.Windows.Forms.Cursors.Hand;

                    grpbCombination.Controls.Add(lstLblCoilsLabels[i]);

                    relativePosition += clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width), 1228);

                    //Add new Coil to list
                    lstCoil.Add(new clsCoil());
                    
                    lstCoil[i].fkProduct = objProduct.codsec;
                    lstCoil[i].fkStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Bobinas", "Activa").codsec;
                    //lstCoil[i].code = DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + objCuttingStop.position.ToString() + (i + 1).ToString() + objMachine.Cutter.cutterNumber.ToString() + "1" + clsGlobal.FillWithZeros(((coilSeq).ToString()), 4) + "0";
                    lstCoil[i].length = length;
                    lstCoil[i].width = objProduct.width;
                    lstCoil[i].cuttingPosition = i + 1;
                    lstCoil[i].cuttingStop = objCuttingStop.position;
                    if (objCuttingOrder.lstCuttingOrderDetail[i].salesOrderNumber != "")
                    {
                        clsSalesOrderDetail objSalesOrderDetail = new clsSalesOrderDetail(objCuttingOrder.lstCuttingOrderDetail[i].fkSalesOrderDetail);
                        clsSalesOrder objSalesOrder = new clsSalesOrder(objSalesOrderDetail.fkSalesOrder);

                        lstCoil[i].salesOrderNumber = objCuttingOrder.lstCuttingOrderDetail[i].salesOrderNumber;
                        lstCoil[i].customerName = objSalesOrder.EntityName;
                    }
                    else
                    {
                        lstCoil[i].salesOrderNumber = "-----";
                        lstCoil[i].customerName = "STOCK";
                    }
                    
                }
                else
                {
                    lstLblCoils.Add(new Label());
                    lstLblCoils[i].BackColor = clsGlobal.getColorByPosition(i, objCuttingOrder.lstCuttingOrderDetail.Count);
                    lstLblCoils[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    lstLblCoils[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lstLblCoils[i].Location = new System.Drawing.Point(relativePosition, 44);
                    lstLblCoils[i].Name = "lblCoil" + i.ToString();
                    lstLblCoils[i].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width), 1228), 150);
                    lstLblCoils[i].TabIndex = 0;
                    lstLblCoils[i].Tag = objCuttingStop.lstCoil[pos].codsec;

                    if (objCuttingOrder.lstCuttingOrderDetail[i].salesOrderNumber != "")
                    {
                        clsSalesOrderDetail objSalesOrderDetail = new clsSalesOrderDetail(objCuttingOrder.lstCuttingOrderDetail[i].fkSalesOrderDetail);
                        clsSalesOrder objSalesOrder = new clsSalesOrder(objSalesOrderDetail.fkSalesOrder);
                        objProduct = new clsProduct(objCuttingOrder.lstCuttingOrderDetail[i].fkProduct);
                        lstLblCoils[i].Text = "Orden   : " + objCuttingOrder.lstCuttingOrderDetail[i].salesOrderNumber + "\n";
                        lstLblCoils[i].Text += "Cliente  : " + objSalesOrder.EntityName + "\n";
                        lstLblCoils[i].Text += "Código  : " + objCuttingStop.lstCoil[pos].code +"\n";
                        lstLblCoils[i].Text += "Ancho   :  " + objCuttingOrder.lstCuttingOrderDetail[i].width.ToString() + "mm\n";
                        lstLblCoils[i].Text += "Metraje : " + length + " m\n";
                        lstLblCoils[i].Text += "Diametro : " + Math.Round(objCuttingStop.lstCoil[pos].diameter, 2).ToString() + " cm\n";
                        lstLblCoils[i].Text += "Core : " + objProduct.CoreValue + "\"\n";
                        lstLblCoils[i].Text += "Peso : " + Math.Round(objCuttingStop.lstCoil[pos].netWeight, 2).ToString() + " Kg\n";
                        lstLblCoils[i].Text += "Densidad : " + Math.Round(objCuttingStop.lstCoil[pos].density, 2).ToString() + " Kg/cm3\n";
                        lstLblCoils[i].Text += "Calidad : " + objCuttingStop.lstCoil[pos].CuttingQualityName + "\n";
                        coilSeq++;
                    }
                    else
                    {
                        objProduct = new clsProduct(objCuttingOrder.lstCuttingOrderDetail[i].fkProduct);
                        lstLblCoils[i].Text = "Orden   : -----\n";
                        lstLblCoils[i].Text += "Cliente  : STOCK\n";
                        lstLblCoils[i].Text += "Código  : " + objCuttingStop.lstCoil[pos].code + "\n";
                        lstLblCoils[i].Text += "Ancho   :  " + objCuttingOrder.lstCuttingOrderDetail[i].width.ToString() + "mm\n";
                        lstLblCoils[i].Text += "Metraje : " + length + " m\n";
                        lstLblCoils[i].Text += "Diametro : " + Math.Round(objCuttingStop.lstCoil[pos].diameter, 2).ToString() + " cm\n";
                        lstLblCoils[i].Text += "Core : " + objProduct.CoreValue + "\"\n";
                        lstLblCoils[i].Text += "Peso : " + Math.Round(objCuttingStop.lstCoil[pos].netWeight, 2).ToString() + " Kg\n";
                        lstLblCoils[i].Text += "Densidad : " + Math.Round(objCuttingStop.lstCoil[pos].density, 2).ToString() + " Kg/cm3\n";
                        lstLblCoils[i].Text += "Calidad : " + objCuttingStop.lstCoil[pos].CuttingQualityName + "\n";
                        coilSeq++;
                    }

                    lstLblCoils[i].TextAlign = System.Drawing.ContentAlignment.TopLeft;

                    usedWidth += Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width);

                    grpbCombination.Controls.Add(lstLblCoils[i]);


                    lstLblCoilsLabels.Add(new Label());
                    lstLblCoilsLabels[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    lstLblCoilsLabels[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lstLblCoilsLabels[i].Location = new System.Drawing.Point(relativePosition, 22);
                    lstLblCoilsLabels[i].Name = "lblCoilLabel" + (i + 1).ToString();
                    lstLblCoilsLabels[i].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width), 1228), 22);
                    lstLblCoilsLabels[i].TabIndex = 3;
                    lstLblCoilsLabels[i].Text = "Bobina " + (i + 1).ToString();
                    lstLblCoilsLabels[i].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    lstLblCoilsLabels[i].BackColor = Color.Lime;
                    lstLblCoilsLabels[i].Tag = i * 2;
                    lstLblCoilsLabels[i].Click += new System.EventHandler(this.selectCoil);
                    lstLblCoilsLabels[i].Cursor = System.Windows.Forms.Cursors.Hand;

                    grpbCombination.Controls.Add(lstLblCoilsLabels[i]);

                    relativePosition += clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width), 1228);

                    //Add existing coil to list
                    lstCoil.Add(objCuttingStop.lstCoil[pos]);
                }
            }


        }
        public void selectCoilInLayout(int selectedIndex)
        {
            selectedCoilIndex = selectedIndex;

            for (int i = 0; i < objCuttingOrder.lstCuttingOrderDetail.Count; i++)
            {
                bool flgHasCoil = false;

                for (int j = 0; j < objCuttingStop.lstCoil.Count; j++)
                {
                    if (objCuttingStop.lstCoil[j].cuttingPosition == i + 1)
                        flgHasCoil = true;
                }

                if (flgHasCoil == false)
                    ((Label)grpbCombination.Controls[i * 2 + 1]).BackColor = Color.White;
                else
                    ((Label)grpbCombination.Controls[i * 2 + 1]).BackColor = Color.Lime;
            }

            ((Label)grpbCombination.Controls[selectedCoilIndex + 1]).BackColor = Color.Yellow;
            
            clsCoilCellar objCoilCellar = clsCoil.getContainerCellarByCoil(lstCoil[selectedCoilIndex / 2].codsec);
            objProduct = new clsProduct(objCuttingOrder.lstCuttingOrderDetail[selectedCoilIndex / 2].fkProduct);

            
            lblDensity.Text = Convert.ToString(Math.Round(lstCoil[selectedCoilIndex / 2].density, 5));
            lblNetWeigth.Text = Convert.ToString(Math.Round(lstCoil[selectedCoilIndex / 2].netWeight, 2));
            //txtDiameter.Text = Convert.ToString(Math.Round(lstCoil[selectedCoilIndex / 2].diameter, 2));
            //txtGrossWeigth.Text = Convert.ToString(Math.Round(lstCoil[selectedCoilIndex / 2].grossWeight, 2));
            txtGrossWeigth.Text = "0";
            //if (lstCoil[selectedCoilIndex / 2].codsec == 0)
            //{
            txtDiameter.Text = Convert.ToString(Math.Round(lstCoilInformation[selectedCoilIndex / 2].diameter, 2));
            txtGrossWeigth.Text = Convert.ToString(Math.Round(lstCoilInformation[selectedCoilIndex / 2].weigth, 2));
            //}
            //else
            //{
            //    txtDiameter.Text = Convert.ToString(Math.Round(lstCoil[selectedCoilIndex / 2].diameter, 2));
            //    txtGrossWeigth.Text = Convert.ToString(Math.Round(lstCoil[selectedCoilIndex / 2].grossWeight, 2));
            //}
            
            txtLength.Text = Convert.ToString(Math.Round(lstCoil[selectedCoilIndex / 2].length, 2));

            if (objCuttingOrder.isSecundaryCut == false)
            {
                if (lstCoil[selectedCoilIndex / 2].codsec == 0)
                {
                    int coilSeq = (new clsSequential().coil);
                    lblCode.Text = DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + objCuttingStop.position.ToString() + ((selectedCoilIndex / 2) + 1).ToString() + objMachine.Cutter.cutterNumber.ToString() + "1" + clsGlobal.FillWithZeros(((coilSeq).ToString()), 4) + "0";
                }
                else
                    lblCode.Text = lstCoil[selectedCoilIndex / 2].code;
            }
            else
            {
                if (lstCoil[selectedCoilIndex / 2].codsec == 0)
                {
                    int coilSeq = (new clsSequential().coil);
                    clsCoil objcoil = new clsCoil(objCuttingStop.lstSecundaryCutCoil[0].fkCoil);
                    int coilReprocessNumber = Convert.ToInt32(objcoil.code.Substring(objcoil.code.Length -1)) + 1;
                    lblCode.Text = DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + objCuttingStop.position.ToString() + ((selectedCoilIndex / 2) + 1).ToString() + objMachine.Cutter.cutterNumber.ToString() + "1" + clsGlobal.FillWithZeros(((coilSeq).ToString()), 4) + coilReprocessNumber.ToString();
                }
                else
                    lblCode.Text = lstCoil[selectedCoilIndex / 2].code;
            }
            
            lblFilmName.Text = objProduct.code.Replace("-", "");
            lblPosition.Text = ((selectedCoilIndex / 2) + 1).ToString();

            if (lstCoil[selectedCoilIndex / 2].treatmentSide == "Externo")
                rdoTreatmentExternal.Checked = true;
            else if (lstCoil[selectedCoilIndex / 2].treatmentSide == "Interno")
                rdoTreatmentInner.Checked = true;
            else if (lstCoil[selectedCoilIndex / 2].treatmentSide == "Doble")
                rdoTreatmentDouble.Checked = true;
            else if (lstCoil[selectedCoilIndex / 2].treatmentSide == "Sin tratamiento")
                rdoTreatmentWithout.Checked = true;

            cmbBalance.SelectedIndex = -1;
            for (int i = 0; i < cmbBalance.Items.Count; i++)
            {
                if (((clsMachine)cmbBalance.Items[i]).codsec == lstCoil[selectedCoilIndex / 2].fkBalance)
                    cmbBalance.SelectedIndex = i;
            }
            txtNotes.Text = lstCoil[selectedCoilIndex / 2].notes;
            lblWidth.Text = lstCoil[selectedCoilIndex / 2].width.ToString();

            for (int i = 0; i < grpbDefects.Controls.Count; i++)
                ((CheckBox)grpbDefects.Controls[i]).Checked = lstCoil[selectedCoilIndex / 2].lstDefects[i];

            objSalesOrderDetail = new clsSalesOrderDetail();
            objSalesOrderDetail.load(objCuttingOrder.lstCuttingOrderDetail[selectedCoilIndex / 2].fkSalesOrderDetail);
            objSalesOrder = new clsSalesOrder(objSalesOrderDetail.fkSalesOrder);

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

            cmbCoilCellar.SelectedIndex = -1;
            for (int i = 0; i < cmbCoilCellar.Items.Count; i++)
            {
                if (((clsCoilCellar)cmbCoilCellar.Items[i]).codsec == objCoilCellar.codsec)
                    cmbCoilCellar.SelectedIndex = i;
            }
            cmbQuality.SelectedIndex = -1;
            for (int i = 0; i < cmbQuality.Items.Count; i++)
            {
                if (((clsCuttingQuality)cmbQuality.Items[i]).codsec == lstCoil[selectedCoilIndex / 2].fkCuttingQuality)
                    cmbQuality.SelectedIndex = i;
            }

            txtDiameter.Focus();
            txtDiameter.SelectAll();

        }

        private void updateCoilLayout()
        {
            ((Label)grpbCombination.Controls[selectedCoilIndex]).Text = "Orden   : " + lstCoil[selectedCoilIndex / 2].salesOrderNumber + "\n";
            ((Label)grpbCombination.Controls[selectedCoilIndex]).Text += "Cliente  : " + lstCoil[selectedCoilIndex / 2].customerName + "\n";
            ((Label)grpbCombination.Controls[selectedCoilIndex]).Text += "Código  : " + lstCoil[selectedCoilIndex / 2].code + "\n";
            ((Label)grpbCombination.Controls[selectedCoilIndex]).Text += "Ancho   :  " + lstCoil[selectedCoilIndex / 2].width.ToString() + "mm\n";
            ((Label)grpbCombination.Controls[selectedCoilIndex]).Text += "Metraje : " + lstCoil[selectedCoilIndex / 2].length + " m\n";
            ((Label)grpbCombination.Controls[selectedCoilIndex]).Text += "Diametro : " + Math.Round(lstCoil[selectedCoilIndex / 2].diameter, 2).ToString() + " cm\n";
            ((Label)grpbCombination.Controls[selectedCoilIndex]).Text += "Core : " + objProduct.CoreValue + "\"\n";
            ((Label)grpbCombination.Controls[selectedCoilIndex]).Text += "Peso : " + Math.Round(lstCoil[selectedCoilIndex / 2].netWeight, 2).ToString() + " Kg\n";
            ((Label)grpbCombination.Controls[selectedCoilIndex]).Text += "Densidad : " + Math.Round(lstCoil[selectedCoilIndex / 2].density, 2).ToString() + " Kg/cm3\n";
            ((Label)grpbCombination.Controls[selectedCoilIndex]).Text += "Calidad : " + lstCoil[selectedCoilIndex / 2].CuttingQualityName + "\n";

            ((Label)grpbCombination.Controls[selectedCoilIndex + 1]).BackColor = Color.Lime;
        }
        private void printCoilLabel(int coilCodsec)
        {
            if (isExternalCoil == false)
            {
                Reports.rptCoilLabel rptCoilLabel = new Reports.rptCoilLabel();

                ParameterDiscreteValue prmCoilCodsec = new ParameterDiscreteValue();
                prmCoilCodsec.Value = coilCodsec;

                ParameterField pfldCoilCodsec = new ParameterField();
                pfldCoilCodsec.Name = "coilLabelCodsec";
                pfldCoilCodsec.CurrentValues.Add(prmCoilCodsec);
                pfldCoilCodsec.HasCurrentValue = true;

                for (int i = 0; i < rptCoilLabel.ParameterFields.Count; i++)
                {
                    switch (rptCoilLabel.ParameterFields[i].Name)
                    {
                        case "coilLabelCodsec":
                            rptCoilLabel.ParameterFields[i].CurrentValues.Clear();
                            rptCoilLabel.ParameterFields[i].CurrentValues.Add(prmCoilCodsec);
                            rptCoilLabel.ParameterFields[i].HasCurrentValue = true;
                            rptCoilLabel.ParameterFields[i].DefaultValues.Clear();
                            rptCoilLabel.ParameterFields[i].DefaultValues.Add(prmCoilCodsec);
                            break;
                        default:
                            break;
                    }
                }

                PrinterSettings printerSettings = new PrinterSettings();
                rptCoilLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                rptCoilLabel.PrintToPrinter(2, false, 0, 0);
            }
            else
            { 
                Reports.rptOppCoilLabel rptCoilLabel = new Reports.rptOppCoilLabel();


                ParameterDiscreteValue prmCoilCodsec = new ParameterDiscreteValue();
                prmCoilCodsec.Value = coilCodsec;

                ParameterField pfldCoilCodsec = new ParameterField();
                pfldCoilCodsec.Name = "coilLabelCodsec";
                pfldCoilCodsec.CurrentValues.Add(prmCoilCodsec);
                pfldCoilCodsec.HasCurrentValue = true;

                for (int i = 0; i < rptCoilLabel.ParameterFields.Count; i++)
                {
                    switch (rptCoilLabel.ParameterFields[i].Name)
                    {
                        case "coilLabelCodsec":
                            rptCoilLabel.ParameterFields[i].CurrentValues.Clear();
                            rptCoilLabel.ParameterFields[i].CurrentValues.Add(prmCoilCodsec);
                            rptCoilLabel.ParameterFields[i].HasCurrentValue = true;
                            rptCoilLabel.ParameterFields[i].DefaultValues.Clear();
                            rptCoilLabel.ParameterFields[i].DefaultValues.Add(prmCoilCodsec);
                            break;
                        default:
                            break;
                    }
                }

                PrinterSettings printerSettings = new PrinterSettings();
                rptCoilLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                rptCoilLabel.PrintToPrinter(2, false, 0, 0);
            }
        }
        private void printObservationCoilLabel(int coilCodsec)
        {
            Reports.rptCoilLabelObservation rptCoilLabel = new Reports.rptCoilLabelObservation();

            ParameterDiscreteValue prmCoilCodsec = new ParameterDiscreteValue();
            prmCoilCodsec.Value = coilCodsec;

            ParameterField pfldCoilCodsec = new ParameterField();
            pfldCoilCodsec.Name = "coilLabelCodsec";
            pfldCoilCodsec.CurrentValues.Add(prmCoilCodsec);
            pfldCoilCodsec.HasCurrentValue = true;

            for (int i = 0; i < rptCoilLabel.ParameterFields.Count; i++)
            {
                switch (rptCoilLabel.ParameterFields[i].Name)
                {
                    case "coilLabelCodsec":
                        rptCoilLabel.ParameterFields[i].CurrentValues.Clear();
                        rptCoilLabel.ParameterFields[i].CurrentValues.Add(prmCoilCodsec);
                        rptCoilLabel.ParameterFields[i].HasCurrentValue = true;
                        rptCoilLabel.ParameterFields[i].DefaultValues.Clear();
                        rptCoilLabel.ParameterFields[i].DefaultValues.Add(prmCoilCodsec);
                        break;
                    default:
                        break;
                }
            }

            PrinterSettings printerSettings = new PrinterSettings();
            rptCoilLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
            rptCoilLabel.PrintToPrinter(1, false, 0, 0);
        }
        private void frmCoilRegistration_Load(object sender, EventArgs e)
        {
            List<clsCuttingQuality> lstCuttingQuality = clsCuttingQuality.getList();
            List<clsMachine> lstMachine = clsMachine.getBalanceMachineList();
            List<clsCoilCellar> lstCoilCellar = clsCoilCellar.getInitialCellarList();
            bool loadForm = true;

            if (lstCoilInformation.Count != objCuttingOrder.lstCuttingOrderDetail.Count)
            {
                MessageBox.Show("No se ha registrado la información inicial de las bobinas de esta parada (peso y diametro).", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                this.Close();
                loadForm = false;
            }

            if (objCuttingOrder.isSecundaryCut == false)
            {
                if (objCuttingStop.lstMainCoilByCuttingStop.Count == 0)
                {
                    MessageBox.Show("No se han registrado las rollos madres de la parada.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    this.Close();
                    loadForm = false;
                }
            }
            else
            {
                if (objCuttingStop.lstSecundaryCutCoil.Count == 0)
                {
                    MessageBox.Show("No se han registrado las bobinas a ser reprocesadas de la parada.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    this.Close();
                    loadForm = false;
                }
            }

            if (loadForm == true)
            {
                this.Text += " - [" + objMachine.Cutter.name + "]";
                loadCoilLayout();

                for (int i = 0; i < lstCuttingQuality.Count; i++)
                    cmbQuality.Items.Add(lstCuttingQuality[i]);

                for (int i = 0; i < lstMachine.Count; i++)
                    cmbBalance.Items.Add(lstMachine[i]);

                for (int i = 0; i < lstCoilCellar.Count; i++)
                    cmbCoilCellar.Items.Add(lstCoilCellar[i]);

                lblStop.Text = objCuttingStop.position.ToString();

                selectCoilInLayout(0);
            }

        }

        private void btnCoilSave_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                lstCoil[selectedCoilIndex / 2].fkBalance = ((clsMachine)cmbBalance.SelectedItem).codsec;
                lstCoil[selectedCoilIndex / 2].fkCuttingQuality = ((clsCuttingQuality)cmbQuality.SelectedItem).codsec;
                lstCoil[selectedCoilIndex / 2].fkProduct = objProduct.codsec;
                lstCoil[selectedCoilIndex / 2].code = lblCode.Text;
                lstCoil[selectedCoilIndex / 2].length = Convert.ToDouble(txtLength.Text);
                lstCoil[selectedCoilIndex / 2].width = objProduct.width;
                lstCoil[selectedCoilIndex / 2].diameter = Convert.ToDouble(txtDiameter.Text);
                lstCoil[selectedCoilIndex / 2].density = Convert.ToDouble(lblDensity.Text);
                lstCoil[selectedCoilIndex / 2].cuttingPosition = Convert.ToInt32(lblPosition.Text);
                lstCoil[selectedCoilIndex / 2].cuttingStop = Convert.ToInt32(lblStop.Text);
                lstCoil[selectedCoilIndex / 2].netWeight = Convert.ToDouble(lblNetWeigth.Text);
                lstCoil[selectedCoilIndex / 2].grossWeight = Convert.ToDouble(txtGrossWeigth.Text);
                
                                
                    
                if (rdoTreatmentExternal.Checked == true)
                    lstCoil[selectedCoilIndex / 2].treatmentSide = "Externo";
                else if (rdoTreatmentInner.Checked == true)
                    lstCoil[selectedCoilIndex / 2].treatmentSide = "Interno";
                else if (rdoTreatmentDouble.Checked == true)
                    lstCoil[selectedCoilIndex / 2].treatmentSide = "Doble";
                else
                    lstCoil[selectedCoilIndex / 2].treatmentSide = "Sin tratamiento";

                if (cmbQuality.Text != "Observación")
                {
                    lstCoil[selectedCoilIndex / 2].defects = "False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False";
                }
                else
                {
                    lstCoil[selectedCoilIndex / 2].defects = "";
                    for (int i = 0; i < grpbDefects.Controls.Count; i++)
                    {
                        lstCoil[selectedCoilIndex / 2].defects += (((CheckBox)grpbDefects.Controls[i]).Checked) ? "True" : "False";
                        lstCoil[selectedCoilIndex / 2].defects += (i < grpbDefects.Controls.Count - 1) ? ";" : "";
                    }
                }
                lstCoil[selectedCoilIndex / 2].notes = txtNotes.Text;
                lstCoil[selectedCoilIndex / 2].cuttingDate = DateTime.Now;
                lstCoil[selectedCoilIndex / 2].createdDate = DateTime.Now;
                lstCoil[selectedCoilIndex / 2].modifiedDate = DateTime.Now;
                lstCoil[selectedCoilIndex / 2].createdBy = clsGlobal.LoggedUser.codsec;
                lstCoil[selectedCoilIndex / 2].modifiedBy = clsGlobal.LoggedUser.codsec;
                lstCoil[selectedCoilIndex / 2].isExternalCoil = isExternalCoil;

                if (objCuttingStop.lstMainCoilByCuttingStop.Count > 0)
                {
                    lstCoil[selectedCoilIndex / 2].lotNumber = objCuttingStop.lstMainCoilByCuttingStop[objCuttingStop.lstMainCoilByCuttingStop.Count - 1].mainCoil.lotNumber.Substring(0, objCuttingStop.lstMainCoilByCuttingStop[objCuttingStop.lstMainCoilByCuttingStop.Count - 1].mainCoil.lotNumber.Length - 1);
                    lstCoil[selectedCoilIndex / 2].mainCoilCode = objCuttingStop.lstMainCoilByCuttingStop[objCuttingStop.lstMainCoilByCuttingStop.Count - 1].mainCoil.code;
                }
                else
                {
                    lstCoil[selectedCoilIndex / 2].lotNumber = objCuttingStop.lstSecundaryCutCoil[objCuttingStop.lstSecundaryCutCoil.Count - 1].objCoil.lotNumber;
                    lstCoil[selectedCoilIndex / 2].mainCoilCode = objCuttingStop.lstSecundaryCutCoil[objCuttingStop.lstSecundaryCutCoil.Count - 1].objCoil.mainCoilCode;
                }


                if (lstCoil[selectedCoilIndex / 2].codsec == 0)
                {
                    objCuttingStop.lstCoil.Add(lstCoil[selectedCoilIndex / 2]);
                }
                else
                {
                    objCuttingStop.lstCoil[selectedCoilIndex / 2] = lstCoil[selectedCoilIndex / 2];
                }

                if (lstCoil[selectedCoilIndex / 2].save(objCuttingStop.codsec, objSalesOrderDetail.codsec, ((clsCoilCellar)cmbCoilCellar.SelectedItem).codsec, objCuttingOrder.lstCuttingOrderDetail[selectedCoilIndex / 2].codsec))
                {
                    objCuttingStop.lstCoil[selectedCoilIndex / 2] = lstCoil[selectedCoilIndex / 2];
                    if (MessageBox.Show("Desea imprimir la etiqueta?", "Registro de Bobina", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                    {
                        if (cmbQuality.Text != "Observación")
                        {
                            Thread thrdPrint = new Thread(delegate() { printCoilLabel(lstCoil[selectedCoilIndex / 2].codsec); });
                            thrdPrint.Start();
                            thrdPrint.Join();
                            //printCoilLabel(lstCoil[selectedCoilIndex / 2].codsec);
                        }
                        else
                            printObservationCoilLabel(lstCoil[selectedCoilIndex / 2].codsec);

                    }
                    MessageBox.Show("La bobina se ha guardado con éxito.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    if ((selectedCoilIndex + 1) < grpbCombination.Controls.Count - 1)
                    {
                        updateCoilLayout();
                        selectCoilInLayout(selectedCoilIndex + 2);
                    }
                    else
                    {
                        updateCoilLayout();
                        MessageBox.Show("Se han registrado todas las bobinas de la parada.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        this.Close();
                    }
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
            if (txtGrossWeigth.Text != "")
            {
                if (clsGlobal.isNumeric(txtGrossWeigth.Text))
                {
                    double netWeigth = Convert.ToDouble(txtGrossWeigth.Text) - (objProduct.width * (new clsCore(objProduct.fkCore)).weigthPerMilimeter);

                    lblNetWeigth.Text = Convert.ToString(Math.Round(netWeigth, 1));

                    lblDensity.Text = Convert.ToString(clsCoil.getCoilDensity(Convert.ToDouble(lblNetWeigth.Text), Convert.ToDouble(txtDiameter.Text), new clsCore(objProduct.fkCore), objProduct.width));
                }
                else
                    MessageBox.Show("El valor debe ser Numérico", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            else
            {
                txtGrossWeigth.Text = "0";
            }
        }

        private void btnMainCoilExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectCoil(object sender, EventArgs e)
        {
            selectCoilInLayout(Convert.ToInt32(((Label)sender).Tag));
        }

        private void cmbBalance_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsBalance> lstBalance = clsBalance.getList();
                cmbBalance.Items.Clear();
                for (int i = 0; i < lstBalance.Count; i++)
                    cmbBalance.Items.Add(lstBalance[i]);
            }
        }

        private void cmbQuality_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsCuttingQuality> lstCuttingQuality = clsCuttingQuality.getList();
                cmbQuality.Items.Clear();
                for (int i = 0; i < lstCuttingQuality.Count; i++)
                    cmbQuality.Items.Add(lstCuttingQuality[i]);
            }
        }

        private void cmbCoilCellar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsCoilCellar> lstCoilCellar = clsCoilCellar.getInitialCellarList();
                cmbCoilCellar.Items.Clear();
                for (int i = 0; i < lstCoilCellar.Count; i++)
                    cmbCoilCellar.Items.Add(lstCoilCellar[i]);
            }
        }

        private void txtDiameter_TextChanged(object sender, EventArgs e)
        {
            if (txtDiameter.Text != "")
            {
                if (clsGlobal.isNumeric(txtGrossWeigth.Text))
                {
                    double netWeigth = Convert.ToDouble(txtGrossWeigth.Text) - (objProduct.width * (new clsCore(objProduct.fkCore)).weigthPerMilimeter);

                    lblNetWeigth.Text = Convert.ToString(Math.Round(netWeigth, 1));

                    lblDensity.Text = Convert.ToString(clsCoil.getCoilDensity(Convert.ToDouble(lblNetWeigth.Text), Convert.ToDouble(txtDiameter.Text), new clsCore(objProduct.fkCore), objProduct.width));
                }
                else
                {
                    MessageBox.Show("El valor debe ser Numérico", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    txtDiameter.Text = "0";
                    txtDiameter.SelectAll();
                }
            }
            else
            {
                txtDiameter.Text = "0";
            }
        }
    }
}
