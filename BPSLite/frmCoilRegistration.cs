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
    public partial class frmCoilRegistration : Form
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
        clsBalance bal1 = new clsBalance();
        

        int selectedCoilIndex = -1;

        public frmCoilRegistration()
        {
            InitializeComponent();
            int prueba=cmbBalance.Items.Count;
            
            
            
        }

        public frmCoilRegistration(int cuttingStopCodsec)
        {
            InitializeComponent();
            objCuttingStop = new clsCuttingStop(cuttingStopCodsec);
            objCuttingOrder = new clsCuttingOrder(objCuttingStop.fkCuttingOrder);
            objMachine.load(objCuttingOrder.fkMachine, "Cutter");
            //lstCoilInformation = clsCoilInformationByCuttingStop.getListByCuttingStop(objCuttingStop.codsec);

            if (objCuttingOrder.isSecundaryCut)
            {
                for (int i = 0; i < objCuttingStop.lstSecundaryCutCoil.Count; i++)
                {
                    if (objCuttingStop.lstSecundaryCutCoil[i].objCoil.isExternalCoil)
                        isExternalCoil = true;
                }
            }

            PrinterSettings printerSettings = new PrinterSettings();
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                cmbPrinter.Items.Add(PrinterSettings.InstalledPrinters[i]);
            }
        }

        private bool validateForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtDiameter, ref lblDiameter, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtGrossWeigthNew, ref lblGrossWeigth, "notEmpty")) isValid = false;
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
                    lstLblCoils[i].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width), 800), 150);
                    lstLblCoils[i].TabIndex = 0;
                    lstLblCoils[i].Tag = 0;

                    clsProduct objProduct = new clsProduct(objCuttingOrder.lstCuttingOrderDetail[i].fkProduct);

                    if (objCuttingOrder.lstCuttingOrderDetail[i].salesOrderNumber != "")
                    {
                        clsSalesOrderDetail objSalesOrderDetail = new clsSalesOrderDetail(objCuttingOrder.lstCuttingOrderDetail[i].fkSalesOrderDetail);
                        clsSalesOrder objSalesOrder = new clsSalesOrder();
                        objSalesOrder.loadWithoutDetail(objSalesOrderDetail.fkSalesOrder);
                        lstLblCoils[i].Text = "Orden   : " + objCuttingOrder.lstCuttingOrderDetail[i].fkSalesOrderDetail + "\n";
                        lstLblCoils[i].Text += "Cliente  : " + objSalesOrder.EntityName + "\n";
                        //lstLblCoils[i].Text += "Código  : " + DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + objCuttingStop.position.ToString() + (i + 1).ToString() + objMachine.Cutter.cutterNumber.ToString() + "1" + clsGlobal.FillWithZeros(((coilSeq).ToString()), 4) + "0" + "\n";
                        lstLblCoils[i].Text += "Código  : --------------\n";
                        lstLblCoils[i].Text += "Producto  : " + objCuttingOrder.lstCuttingOrderDetail[i].product.code + "\n";
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
                        lstLblCoils[i].Text += "Producto  : " + objCuttingOrder.lstCuttingOrderDetail[i].product.code + "\n";
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
                    grpbCombination.Enabled = true;


                    lstLblCoilsLabels.Add(new Label());
                    lstLblCoilsLabels[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    lstLblCoilsLabels[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lstLblCoilsLabels[i].Location = new System.Drawing.Point(relativePosition, 22);
                    lstLblCoilsLabels[i].Name = "lblCoilLabel" + (i + 1).ToString();
                    lstLblCoilsLabels[i].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width), 800), 22);
                    lstLblCoilsLabels[i].TabIndex = 3;
                    lstLblCoilsLabels[i].Text = "Bobina " + (i + 1).ToString();
                    lstLblCoilsLabels[i].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    lstLblCoilsLabels[i].Tag = i * 2;
                    lstLblCoilsLabels[i].Click += new System.EventHandler(this.selectCoil);
                    lstLblCoilsLabels[i].Cursor = System.Windows.Forms.Cursors.Hand;

                    grpbCombination.Controls.Add(lstLblCoilsLabels[i]);

                    relativePosition += clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width), 800);

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
                        clsSalesOrder objSalesOrder = new clsSalesOrder();
                        objSalesOrder.loadWithoutDetail(objSalesOrderDetail.fkSalesOrder);

                        lstCoil[i].salesOrderNumber = objCuttingOrder.lstCuttingOrderDetail[i].fkSalesOrderDetail.ToString();  //.salesOrderNumber;
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
                    //lstLblCoils[i].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width), 1228), 150);
                    lstLblCoils[i].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(objCuttingStop.lstCoil[pos].width), 800), 150);
                    lstLblCoils[i].TabIndex = 0;
                    lstLblCoils[i].Tag = objCuttingStop.lstCoil[pos].codsec;

                    if (objCuttingOrder.lstCuttingOrderDetail[i].salesOrderNumber != "")
                    {
                        clsSalesOrderDetail objSalesOrderDetail = new clsSalesOrderDetail(objCuttingOrder.lstCuttingOrderDetail[i].fkSalesOrderDetail);
                        clsSalesOrder objSalesOrder = new clsSalesOrder();
                        objSalesOrder.loadWithoutDetail(objSalesOrderDetail.fkSalesOrder);
                        objProduct = objSalesOrderDetail.product;
                        lstLblCoils[i].Text = "Orden   : " + objCuttingOrder.lstCuttingOrderDetail[i].fkSalesOrderDetail; //salesOrderNumber + "\n";
                        lstLblCoils[i].Text += "Cliente  : " + objSalesOrder.EntityName + "\n";
                        lstLblCoils[i].Text += "Código  : " + objCuttingStop.lstCoil[pos].code + "\n";
                        lstLblCoils[i].Text += "Producto  : " + objCuttingStop.lstCoil[pos].ProductCode + "\n";
                        lstLblCoils[i].Text += "Ancho   :  " + objCuttingStop.lstCoil[pos].width.ToString() + "mm\n";
                        lstLblCoils[i].Text += "Metraje : " + length + " m\n";
                        lstLblCoils[i].Text += "Diametro : " + Math.Round(objCuttingStop.lstCoil[pos].diameter, 2).ToString() + " cm\n";
                        lstLblCoils[i].Text += "Core : " + objProduct.CoreValue + "\"\n";
                        lstLblCoils[i].Text += "Peso : " + Math.Round(objCuttingStop.lstCoil[pos].netWeight, 1).ToString() + " Kg\n";
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
                        lstLblCoils[i].Text += "Producto  : " + objCuttingStop.lstCoil[pos].ProductCode + "\n";
                        lstLblCoils[i].Text += "Ancho   :  " + objCuttingStop.lstCoil[pos].width.ToString() + "mm\n";
                        lstLblCoils[i].Text += "Metraje : " + length + " m\n";
                        lstLblCoils[i].Text += "Diametro : " + Math.Round(objCuttingStop.lstCoil[pos].diameter, 2).ToString() + " cm\n";
                        lstLblCoils[i].Text += "Core : " + objProduct.CoreValue + "\"\n";
                        lstLblCoils[i].Text += "Peso : " + Math.Round(objCuttingStop.lstCoil[pos].netWeight, 2).ToString() + " Kg\n";
                        lstLblCoils[i].Text += "Densidad : " + Math.Round(objCuttingStop.lstCoil[pos].density, 2).ToString() + " Kg/cm3\n";
                        lstLblCoils[i].Text += "Calidad : " + objCuttingStop.lstCoil[pos].CuttingQualityName + "\n";
                        coilSeq++;
                    }

                    lstLblCoils[i].TextAlign = System.Drawing.ContentAlignment.TopLeft;

                    //usedWidth += Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width);
                    usedWidth += Convert.ToInt32(objCuttingStop.lstCoil[pos].width);

                    grpbCombination.Controls.Add(lstLblCoils[i]);


                    lstLblCoilsLabels.Add(new Label());
                    lstLblCoilsLabels[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    lstLblCoilsLabels[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lstLblCoilsLabels[i].Location = new System.Drawing.Point(relativePosition, 22);
                    lstLblCoilsLabels[i].Name = "lblCoilLabel" + (i + 1).ToString();
                    //lstLblCoilsLabels[i].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(objCuttingOrder.lstCuttingOrderDetail[i].width), 1228), 22);
                    lstLblCoilsLabels[i].Size = new System.Drawing.Size(clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(objCuttingStop.lstCoil[pos].width), 800), 22);
                    lstLblCoilsLabels[i].TabIndex = 3;
                    lstLblCoilsLabels[i].Text = "Bobina " + (i + 1).ToString();
                    lstLblCoilsLabels[i].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    lstLblCoilsLabels[i].BackColor = Color.Lime;
                    lstLblCoilsLabels[i].Tag = i * 2;
                    lstLblCoilsLabels[i].Click += new System.EventHandler(this.selectCoil);
                    lstLblCoilsLabels[i].Cursor = System.Windows.Forms.Cursors.Hand;

                    grpbCombination.Controls.Add(lstLblCoilsLabels[i]);

                    relativePosition += clsCuttingOrderResume.getProportinalWidth(totalUsedWidth, Convert.ToInt32(objCuttingStop.lstCoil[pos].width), 800);

                    //Add existing coil to list
                    lstCoil.Add(objCuttingStop.lstCoil[pos]);
                }
            }


        }

        private void loadPalletList(int salesOrderDetailCodsec)
        {
            List<clsPalletTypeBySalesOrderDetail> lstPalletList = clsPalletTypeBySalesOrderDetail.getListBySalesOrderDetail(salesOrderDetailCodsec);

            dgvPalletType.Rows.Clear();
            for (int i = 0; i < lstPalletList.Count; i++)
            {
                dgvPalletType.Rows.Add();
                dgvPalletType.Rows[i].Cells[clmPalletTypeCodsec.Index].Value = lstPalletList[i].codsec;
                dgvPalletType.Rows[i].Cells[clmPalletTypePTCodsec.Index].Value = lstPalletList[i].fkPalletType;
                dgvPalletType.Rows[i].Cells[clmPalletTypeDimentionCodsec.Index].Value = lstPalletList[i].fkPalletDimention;
                dgvPalletType.Rows[i].Cells[clmPalletTypeTransportCodsec.Index].Value = lstPalletList[i].fkTransport;
                dgvPalletType.Rows[i].Cells[clmPalletTypeName.Index].Value = lstPalletList[i].palletType.name;
                dgvPalletType.Rows[i].Cells[clmPalletTypeCoilsByPallet.Index].Value = lstPalletList[i].palletType.coilNumber;
                dgvPalletType.Rows[i].Cells[clmPalletTypeDimention.Index].Value = lstPalletList[i].palletDimention.ToString();
                dgvPalletType.Rows[i].Cells[clmPalletTypeQuantity.Index].Value = lstPalletList[i].quantity;
            }
        }
       
        public void selectCoilInLayout(int selectedIndex)
        {
            selectedCoilIndex = selectedIndex;
            bool hasRegisteredCoil = false;


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

            if (lstCoil[selectedCoilIndex / 2].codsec != 0)
                hasRegisteredCoil = true;

            if (hasRegisteredCoil == false)
            {
                ((Label)grpbCombination.Controls[selectedCoilIndex + 1]).BackColor = Color.Yellow;

                clsCoilCellar objCoilCellar = clsCoil.getContainerCellarByCoil(lstCoil[selectedCoilIndex / 2].codsec);
                objProduct = new clsProduct(objCuttingOrder.lstCuttingOrderDetail[selectedCoilIndex / 2].fkProduct);


                lblDensity.Text = Convert.ToString(Math.Round(lstCoil[selectedCoilIndex / 2].density, 5));
                lblNetWeigth.Text = Convert.ToString(Math.Round(lstCoil[selectedCoilIndex / 2].netWeight, 2));
                //txtDiameter.Text = Convert.ToString(Math.Round(lstCoil[selectedCoilIndex / 2].diameter, 2));
                //txtGrossWeigthNew.Text = Convert.ToString(Math.Round(lstCoil[selectedCoilIndex / 2].grossWeight, 2));
                //txtGrossWeigthNew.Text = "0";
                //if (lstCoil[selectedCoilIndex / 2].codsec == 0)
                //{
                txtDiameter.Text = "0";
                txtGrossWeigthNew.Text = "0";
                //cmbBalance.SelectedIndex = 0;
                //txtDiameter.Text = Convert.ToString(Math.Round(lstCoilInformation[selectedCoilIndex / 2].diameter, 2));
                //txtGrossWeigthNew.Text = Convert.ToString(Math.Round(lstCoilInformation[selectedCoilIndex / 2].weigth, 2));
                //}
                //else
                //{
                //    txtDiameter.Text = Convert.ToString(Math.Round(lstCoil[selectedCoilIndex / 2].diameter, 2));
                //    txtGrossWeigthNew.Text = Convert.ToString(Math.Round(lstCoil[selectedCoilIndex / 2].grossWeight, 2));
                //}

                txtLength.Text = Convert.ToString(Math.Round(lstCoil[selectedCoilIndex / 2].length, 2));

                if (objCuttingOrder.isSecundaryCut == false)
                {
                    if (lstCoil[selectedCoilIndex / 2].codsec == 0)
                    {
                        int coilSeq = (new clsSequential().coil);
                        //lblCode.Text = DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + objMachine.Cutter.cutterNumber.ToString() + 
                        lblCode.Text = DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + objCuttingOrder.codsec.ToString() + objCuttingStop.position.ToString() + ((selectedCoilIndex / 2) + 1).ToString() + new clsPlant(new clsSector(objMachine.fkSector).fkPlant).abr + objMachine.Cutter.cutterNumber.ToString() + clsGlobal.FillWithZeros(((coilSeq).ToString()), 5) + "0";
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
                        string prue = objcoil.code.Substring(objcoil.code.Length - 1);
                        int coilReprocessNumber = Convert.ToInt32(objcoil.code.Substring(objcoil.code.Length - 1)) + 1;
                        lblCode.Text = DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + objCuttingOrder.codsec.ToString() + objCuttingStop.position.ToString() + ((selectedCoilIndex / 2) + 1).ToString() + new clsPlant(new clsSector(objMachine.fkSector).fkPlant).abr + objMachine.Cutter.cutterNumber.ToString() + clsGlobal.FillWithZeros(((coilSeq).ToString()), 5)  +coilReprocessNumber.ToString();
                    }
                    else
                        lblCode.Text = lstCoil[selectedCoilIndex / 2].code;
                }

                lblFilmName.Text = objProduct.code.Replace("-", "");
                lblPosition.Text = ((selectedCoilIndex / 2) + 1).ToString();
               

                if (lstCoil[selectedCoilIndex / 2].codsec == 0)
                {
                    if (lstCoil[selectedCoilIndex / 2].treatmentSide == "Externo")
                        rdoTreatmentExternal.Checked = true;
                    else if (lstCoil[selectedCoilIndex / 2].treatmentSide == "Interno")
                        rdoTreatmentInner.Checked = true;
                    else if (lstCoil[selectedCoilIndex / 2].treatmentSide == "Doble")
                        rdoTreatmentDouble.Checked = true;
                    else if (lstCoil[selectedCoilIndex / 2].treatmentSide == "Sin tratamiento")
                        rdoQ.Checked = true;
                    else if (lstCoil[selectedCoilIndex / 2].treatmentSide == "TT")
                        rdbTT.Checked = true;
                }
                else
                {
                    if (lstCoil[selectedCoilIndex / 2].treatmentSide == "Externo")
                        rdoTreatmentExternal.Checked = true;
                    else if (lstCoil[selectedCoilIndex / 2].treatmentSide == "Interno")
                        rdoTreatmentInner.Checked = true;
                    else if (lstCoil[selectedCoilIndex / 2].treatmentSide == "Doble")
                        rdoTreatmentDouble.Checked = true;
                    else if (lstCoil[selectedCoilIndex / 2].treatmentSide == "Sin tratamiento")
                        rdoTreatmentWithout.Checked = true;
                    else if (lstCoil[selectedCoilIndex / 2].treatmentSide == "")
                        rdoQ.Checked = true;
                    else if (lstCoil[selectedCoilIndex / 2].treatmentSide == "TT")
                        rdbTT.Checked = true;
                }

                //cmbBalance.SelectedIndex = -1;
                //for (int i = 0; i < cmbBalance.Items.Count; i++)
                //{
                //    if (((clsMachine)cmbBalance.Items[i]).codsec == lstCoil[selectedCoilIndex / 2].fkBalance)
                //        cmbBalance.SelectedIndex = i;
                //}
                txtNotes.Text = lstCoil[selectedCoilIndex / 2].notes;
                lblWidth.Text = lstCoil[selectedCoilIndex / 2].width.ToString();

                //for (int i = 0; i < grpbSalesOrderSumary.Controls.Count; i++)
                //    ((CheckBox)grpbSalesOrderSumary.Controls[i]).Checked = lstCoil[selectedCoilIndex / 2].lstDefects[i];

                objSalesOrderDetail = new clsSalesOrderDetail();
                objSalesOrderDetail.load(objCuttingOrder.lstCuttingOrderDetail[selectedCoilIndex / 2].fkSalesOrderDetail);
                objSalesOrder = new clsSalesOrder();
                objSalesOrder.loadWithoutDetail(objSalesOrderDetail.fkSalesOrder);
                if (objSalesOrder.codsec != 0)
                {
                    lblCustomer.Text = objSalesOrder.EntityName;
                    lblSalesOrderNumber.Text = objSalesOrderDetail.codsec.ToString();//objSalesOrder.number;

                    grpbSalesOrderSumary.Enabled = true;
                    lblTotalWeight.Text = Math.Round(objSalesOrderDetail.quantity, 0).ToString();
                    lblCuttedWeight.Text = clsSalesOrderDetail.getCuttedWeightBySalesOrderDetail(objSalesOrderDetail.codsec).ToString();
                    lblUncuttedWeight.Text = Math.Round((Convert.ToDouble(lblTotalWeight.Text) - Convert.ToDouble(lblCuttedWeight.Text)), 1).ToString();

                    //lblTotalCoils.Text = Math.Round(Convert.ToDecimal(clsParameters.getCoilsNumberByWidthAndWeigth(objSalesOrderDetail.product.codsec, objSalesOrderDetail.quantity)), 0).ToString();
                    lblTotalCoils.Text = objSalesOrderDetail.coilsToCut.ToString();
                    lblCuttedCoils.Text = clsSalesOrderDetail.getCuttedCoilCountBySalesOrderDetail(objSalesOrderDetail.codsec).ToString();
                    lblMissingCoils.Text = (Convert.ToInt32(lblTotalCoils.Text) - Convert.ToInt32(lblCuttedCoils.Text)).ToString();
                    lblNextCoil.Text = (Convert.ToInt32(lblMissingCoils.Text) > 0) ? Math.Round((Convert.ToDouble(lblUncuttedWeight.Text) / Convert.ToInt32(lblMissingCoils.Text)), 1).ToString() : "0";

                    loadPalletList(objSalesOrderDetail.codsec);

                }
                else
                {
                    lblCustomer.Text = "STOCK";
                    lblSalesOrderNumber.Text = "---";

                    grpbSalesOrderSumary.Enabled = false;
                    lblTotalWeight.Text = "0";
                    lblCuttedWeight.Text = "0";
                    lblUncuttedWeight.Text = "0";

                    lblTotalCoils.Text = "0";
                    lblCuttedCoils.Text = "0";
                    lblMissingCoils.Text = "0";
                    lblNextCoil.Text = "0";
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
            else
            {
                ((Label)grpbCombination.Controls[selectedCoilIndex + 1]).BackColor = Color.Yellow;

                clsCoilCellar objCoilCellar = clsCoil.getContainerCellarByCoil(lstCoil[selectedCoilIndex / 2].codsec);
                objProduct = new clsProduct(lstCoil[selectedCoilIndex / 2].fkProduct);


                lblDensity.Text = Convert.ToString(Math.Round(lstCoil[selectedCoilIndex / 2].density, 5));
                lblNetWeigth.Text = Convert.ToString(Math.Round(lstCoil[selectedCoilIndex / 2].netWeight, 2));
                //txtDiameter.Text = Convert.ToString(Math.Round(lstCoil[selectedCoilIndex / 2].diameter, 2));
                //txtGrossWeigthNew.Text = Convert.ToString(Math.Round(lstCoil[selectedCoilIndex / 2].grossWeight, 2));
                txtGrossWeigthNew.Text = "0";
                //cmbBalance.SelectedIndex = 0;
                //if (lstCoil[selectedCoilIndex / 2].codsec == 0)
                //{
                txtDiameter.Text = Convert.ToString(Math.Round(lstCoil[selectedCoilIndex / 2].diameter, 2));
                txtGrossWeigthNew.Text = Convert.ToString(Math.Round(lstCoil[selectedCoilIndex / 2].grossWeight, 2));
                //}
                //else
                //{
                //    txtDiameter.Text = Convert.ToString(Math.Round(lstCoil[selectedCoilIndex / 2].diameter, 2));
                //    txtGrossWeigthNew.Text = Convert.ToString(Math.Round(lstCoil[selectedCoilIndex / 2].grossWeight, 2));
                //}

                txtLength.Text = Convert.ToString(Math.Round(lstCoil[selectedCoilIndex / 2].length, 2));

                if (objCuttingOrder.isSecundaryCut == false)
                {
                    if (lstCoil[selectedCoilIndex / 2].codsec == 0)
                    {
                        int coilSeq = (new clsSequential().coil);
                        lblCode.Text = DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + objCuttingOrder.codsec.ToString() + objCuttingStop.position.ToString() + ((selectedCoilIndex / 2) + 1).ToString() + new clsPlant(new clsSector(objMachine.fkSector).fkPlant).abr + objMachine.Cutter.cutterNumber.ToString() + clsGlobal.FillWithZeros(((coilSeq).ToString()), 5) + "0";
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
                        int coilReprocessNumber = Convert.ToInt32(objcoil.code.Substring(objcoil.code.Length - 1)) + 1;
                        lblCode.Text = DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + objCuttingOrder.codsec.ToString() + objCuttingStop.position.ToString() + ((selectedCoilIndex / 2) + 1).ToString() + new clsPlant(new clsSector(objMachine.fkSector).fkPlant).abr + objMachine.Cutter.cutterNumber.ToString() + clsGlobal.FillWithZeros(((coilSeq).ToString()), 5) + coilReprocessNumber.ToString();
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
                else if (lstCoil[selectedCoilIndex / 2].treatmentSide == "")
                    rdoQ.Checked = true;
                else if (lstCoil[selectedCoilIndex / 2].treatmentSide == "TT")
                    rdbTT.Checked = true;

                //cmbBalance.SelectedIndex = -1;
                //for (int i = 0; i < cmbBalance.Items.Count; i++)
                //{
                //    if (((clsMachine)cmbBalance.Items[i]).codsec == lstCoil[selectedCoilIndex / 2].fkBalance)
                //        cmbBalance.SelectedIndex = i;
                //}
                txtNotes.Text = lstCoil[selectedCoilIndex / 2].notes;
                lblWidth.Text = lstCoil[selectedCoilIndex / 2].width.ToString();

                //for (int i = 0; i < grpbSalesOrderSumary.Controls.Count; i++)
                //    ((CheckBox)grpbSalesOrderSumary.Controls[i]).Checked = lstCoil[selectedCoilIndex / 2].lstDefects[i];

                objSalesOrderDetail = new clsSalesOrderDetail();
                objSalesOrderDetail.load(objCuttingOrder.lstCuttingOrderDetail[selectedCoilIndex / 2].fkSalesOrderDetail);
                objSalesOrder = new clsSalesOrder();
                objSalesOrder.loadWithoutDetail(objSalesOrderDetail.fkSalesOrder);

                if (objSalesOrder.codsec != 0)
                {
                    lblCustomer.Text = objSalesOrder.EntityName;
                    lblSalesOrderNumber.Text = objSalesOrderDetail.codsec.ToString(); //objSalesOrder.number;

                    grpbSalesOrderSumary.Enabled = true;
                    lblTotalWeight.Text = Math.Round(objSalesOrderDetail.quantity, 0).ToString();
                    lblCuttedWeight.Text = clsSalesOrderDetail.getCuttedWeightBySalesOrderDetail(objSalesOrderDetail.codsec).ToString();
                    lblUncuttedWeight.Text = Math.Round((Convert.ToDouble(lblTotalWeight.Text) - Convert.ToDouble(lblCuttedWeight.Text)), 1).ToString();

                    //lblTotalCoils.Text = Math.Round(Convert.ToDecimal(clsParameters.getCoilsNumberByWidthAndWeigth(objSalesOrderDetail.product.codsec, objSalesOrderDetail.quantity)), 0).ToString();
                    lblTotalCoils.Text = objSalesOrderDetail.coilsToCut.ToString();
                    lblCuttedCoils.Text = clsSalesOrderDetail.getCuttedCoilCountBySalesOrderDetail(objSalesOrderDetail.codsec).ToString();
                    lblMissingCoils.Text = (Convert.ToInt32(lblTotalCoils.Text) - Convert.ToInt32(lblCuttedCoils.Text)).ToString();
                    lblNextCoil.Text = (Convert.ToInt32(lblMissingCoils.Text) > 0) ? Math.Round((Convert.ToDouble(lblUncuttedWeight.Text) / Convert.ToInt32(lblMissingCoils.Text)), 1).ToString() : "0";

                    loadPalletList(objSalesOrderDetail.codsec);

                }
                else
                {
                    lblCustomer.Text = "STOCK";
                    lblSalesOrderNumber.Text = "---";

                    grpbSalesOrderSumary.Enabled = false;
                    lblTotalWeight.Text = "0";
                    lblCuttedWeight.Text = "0";
                    lblUncuttedWeight.Text = "0";

                    lblTotalCoils.Text = "0";
                    lblCuttedCoils.Text = "0";
                    lblMissingCoils.Text = "0";
                    lblNextCoil.Text = "0";
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

        }

        private void updateCoilLayout()
        {
            (grpbCombination.Controls[selectedCoilIndex]).Text = "Orden   : " + lstCoil[selectedCoilIndex / 2].salesOrderNumber + "\n";
            (grpbCombination.Controls[selectedCoilIndex]).Text += "Cliente  : " + lstCoil[selectedCoilIndex / 2].customerName + "\n";
            (grpbCombination.Controls[selectedCoilIndex]).Text += "Código  : " + lstCoil[selectedCoilIndex / 2].code + "\n";
            (grpbCombination.Controls[selectedCoilIndex]).Text += "Ancho   :  " + lstCoil[selectedCoilIndex / 2].width.ToString() + "mm\n";
            (grpbCombination.Controls[selectedCoilIndex]).Text += "Metraje : " + lstCoil[selectedCoilIndex / 2].length + " m\n";
            (grpbCombination.Controls[selectedCoilIndex]).Text += "Diametro : " + Math.Round(lstCoil[selectedCoilIndex / 2].diameter, 2).ToString() + " cm\n";
            (grpbCombination.Controls[selectedCoilIndex]).Text += "Core : " + objProduct.CoreValue + "\"\n";
            (grpbCombination.Controls[selectedCoilIndex]).Text += "Peso : " + Math.Round(lstCoil[selectedCoilIndex / 2].netWeight, 2).ToString() + " Kg\n";
            (grpbCombination.Controls[selectedCoilIndex]).Text += "Densidad : " + Math.Round(lstCoil[selectedCoilIndex / 2].density, 2).ToString() + " Kg/cm3\n";
            (grpbCombination.Controls[selectedCoilIndex]).Text += "Calidad : " + lstCoil[selectedCoilIndex / 2].CuttingQualityName + "\n";

            (grpbCombination.Controls[selectedCoilIndex + 1]).BackColor = Color.Lime;
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
                if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)
                {
                    for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
                    {
                        if (PrinterSettings.InstalledPrinters[i] == "\\\\Store2\\TSC BOBINAS")
                        {
                            rptCoilLabel.PrintOptions.PrinterName = "\\\\Store2\\TSC BOBINAS";
                        }
                        else
                        {
                            rptCoilLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                        }
                    }

                }
                else
                {
                    rptCoilLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                }
                rptCoilLabel.PrintToPrinter(2, false, 0, 0);
            }
            else
            {
                Reports.rptOppCoilLabel rptCoilLabel = new Reports.rptOppCoilLabel();

                Tables tables;

                tables = rptCoilLabel.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptCoilLabel.ReportDefinition.Sections;
                foreach (Section section in sections)
                {
                    ReportObjects reportObjects = section.ReportObjects;
                    foreach (ReportObject reportObject in reportObjects)
                    {
                        if (reportObject.Kind == ReportObjectKind.SubreportObject)
                        {
                            SubreportObject subreportObject = (SubreportObject)reportObject;
                            ReportDocument subReportDocument = subreportObject.OpenSubreport(subreportObject.SubreportName);
                            tables = subReportDocument.Database.Tables;
                            foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                            {
                                TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                                tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                                table.ApplyLogOnInfo(tableLogonInfo);
                            }
                        }
                    }
                }

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
                if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)
                {
                    for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
                    {
                        if (PrinterSettings.InstalledPrinters[i] == "\\\\Store2\\TSC BOBINAS")
                        {
                            rptCoilLabel.PrintOptions.PrinterName = "\\\\Store2\\TSC BOBINAS";
                        }
                        else
                        {
                            rptCoilLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                        }
                    }

                }
                else
                {
                    rptCoilLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                }
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
            if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)
            {
                for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
                {
                    if (PrinterSettings.InstalledPrinters[i] == "\\\\Store2\\TSC BOBINAS")
                    {
                        rptCoilLabel.PrintOptions.PrinterName = "\\\\Store2\\TSC BOBINAS";
                    }
                    else
                    {
                        rptCoilLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                    }
                }

            }
            else
            {
                rptCoilLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
            }
            rptCoilLabel.PrintToPrinter(1, false, 0, 0);
        }
       
        private void frmCoilRegistration_Load(object sender, EventArgs e)
        {
            List<clsCuttingQuality> lstCuttingQuality = clsCuttingQuality.getList();
            List<clsMachine> lstMachine = clsMachine.getBalanceMachineList();
            List<clsCoilCellar> lstCoilCellar = clsCoilCellar.getInitialCellarList(new clsSector(objMachine.fkSector).fkPlant);
            bool loadForm = true;

            /*if (lstCoilInformation.Count != objCuttingOrder.lstCuttingOrderDetail.Count)
            {
                MessageBox.Show("No se ha registrado la información inicial de las bobinas de esta parada (peso y diámetro).", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                this.Close();
                loadForm = false;
            }*/

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
                    MessageBox.Show("No se han registrado las bobinas a ser re procesadas de la parada.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
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

                for(int i=0;i<cmbBalance.Items.Count;i++)
                {
                    if(clsGlobal.LoggedUser.fkRole == new clsBalance(cmbBalance.Items[i].ToString()).fkRole && clsGlobal.LoggedUser.codsec == 5115)
                    {
                        cmbBalance.SelectedIndex=2;
                    }   
                    else if (clsGlobal.LoggedUser.fkRole == new clsBalance(cmbBalance.Items[i].ToString()).fkRole)
                    {
                        cmbBalance.SelectedIndex = i;
                    }
                }

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
                lstCoil[selectedCoilIndex / 2].grossWeight = Convert.ToDouble(txtGrossWeigthNew.Text);

                if (rdoTreatmentExternal.Checked == true)
                    lstCoil[selectedCoilIndex / 2].treatmentSide = "Externo";
                else if (rdoTreatmentInner.Checked == true)
                    lstCoil[selectedCoilIndex / 2].treatmentSide = "Interno";
                else if (rdoTreatmentDouble.Checked == true)
                    lstCoil[selectedCoilIndex / 2].treatmentSide = "Doble";
                else if (rdbTT.Checked == true)
                    lstCoil[selectedCoilIndex / 2].treatmentSide = "TT";
                else if (rdoQ.Checked == true)
                    lstCoil[selectedCoilIndex / 2].treatmentSide = "";
                else
                    lstCoil[selectedCoilIndex / 2].treatmentSide = "Sin tratamiento";

                //if (cmbQuality.Text != "Observación")
                //{
                lstCoil[selectedCoilIndex / 2].defects = "False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False";
                //}
                //else
                //{
                //    lstCoil[selectedCoilIndex / 2].defects = "";
                //    for (int i = 0; i < grpbSalesOrderSumary.Controls.Count; i++)
                //    {
                //        lstCoil[selectedCoilIndex / 2].defects += (((CheckBox)grpbSalesOrderSumary.Controls[i]).Checked) ? "True" : "False";
                //        lstCoil[selectedCoilIndex / 2].defects += (i < grpbSalesOrderSumary.Controls.Count - 1) ? ";" : "";
                //    }
                //}
                lstCoil[selectedCoilIndex / 2].notes = txtNotes.Text;
                lstCoil[selectedCoilIndex / 2].cuttingDate = DateTime.Now;
                lstCoil[selectedCoilIndex / 2].createdDate = DateTime.Now;
                lstCoil[selectedCoilIndex / 2].modifiedDate = DateTime.Now;
                lstCoil[selectedCoilIndex / 2].createdBy = clsGlobal.LoggedUser.codsec;
                lstCoil[selectedCoilIndex / 2].modifiedBy = clsGlobal.LoggedUser.codsec;
                lstCoil[selectedCoilIndex / 2].isExternalCoil = isExternalCoil;
                lstCoil[selectedCoilIndex / 2].externalLabelPrint = false;

                if (objCuttingStop.lstMainCoilByCuttingStop.Count > 0)
                {
                    lstCoil[selectedCoilIndex / 2].lotNumber = objCuttingStop.lstMainCoilByCuttingStop[objCuttingStop.lstMainCoilByCuttingStop.Count - 1].mainCoil.lotNumber.Substring(0, objCuttingStop.lstMainCoilByCuttingStop[objCuttingStop.lstMainCoilByCuttingStop.Count - 1].mainCoil.lotNumber.Length - 1);
                    lstCoil[selectedCoilIndex / 2].mainCoilCode = objCuttingStop.lstMainCoilByCuttingStop[objCuttingStop.lstMainCoilByCuttingStop.Count - 1].mainCoil.code;
                    lstCoil[selectedCoilIndex / 2].extrusionDate = objCuttingStop.lstMainCoilByCuttingStop[objCuttingStop.lstMainCoilByCuttingStop.Count - 1].mainCoil.createdDate;
                }
                else
                {
                    lstCoil[selectedCoilIndex / 2].lotNumber = objCuttingStop.lstSecundaryCutCoil[objCuttingStop.lstSecundaryCutCoil.Count - 1].objCoil.lotNumber;
                    lstCoil[selectedCoilIndex / 2].mainCoilCode = objCuttingStop.lstSecundaryCutCoil[objCuttingStop.lstSecundaryCutCoil.Count - 1].objCoil.mainCoilCode;
                    lstCoil[selectedCoilIndex / 2].extrusionDate = objCuttingStop.lstSecundaryCutCoil[objCuttingStop.lstSecundaryCutCoil.Count - 1].objCoil.extrusionDate;
                }


                if (lstCoil[selectedCoilIndex / 2].codsec == 0)
                {
                    if (objCuttingStop.lstCoil.Count <= (selectedCoilIndex / 2))
                    {
                        while (objCuttingStop.lstCoil.Count < (selectedCoilIndex / 2))
                        {
                            objCuttingStop.lstCoil.Add(new clsCoil());
                        }
                        objCuttingStop.lstCoil.Add(lstCoil[selectedCoilIndex / 2]);
                    }
                    
                   
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

                            if (objSalesOrderDetail.sordEntityName == "ENVASANDO S.R.L.")
                            {
                                Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabelSpecial(lstCoil[selectedCoilIndex / 2].codsec, lstCoil[selectedCoilIndex / 2].externalLabelPrint); });
                                thrdPrint.Start();
                                thrdPrint.Join();
                            }
                            else
                            {
                                
                                //Nahuel: Harcodeo para imprimir la etiqueta segun la planta
                                Thread thrdPrint;
                                clsSector sec = new clsSector(objMachine.fkSector);
                                switch(sec.fkPlant)
                                {
                                    case 3:
                                        thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabel(lstCoil[selectedCoilIndex / 2].codsec, lstCoil[selectedCoilIndex / 2].externalLabelPrint); });
                                        thrdPrint.Start();
                                        thrdPrint.Join();
                                        break;
                                    case 4:
                                        thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabelPL(lstCoil[selectedCoilIndex / 2].codsec, lstCoil[selectedCoilIndex / 2].externalLabelPrint); });
                                        thrdPrint.Start();
                                        thrdPrint.Join();
                                        break;
                                    default:
                                        thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabel(lstCoil[selectedCoilIndex / 2].codsec, lstCoil[selectedCoilIndex / 2].externalLabelPrint); });
                                        thrdPrint.Start();
                                        thrdPrint.Join();
                                        break;
                                }
                                
                            }

                        }
                        else
                        {
                            Thread thrdPrint;
                            clsSector sec = new clsSector(objMachine.fkSector);
                            switch (sec.fkPlant)
                            {
                                case 3:
                                    thrdPrint = new Thread(delegate() { clsPrintLabels.printObservationCoilLabel(lstCoil[selectedCoilIndex / 2].codsec); });
                                    thrdPrint.Start();
                                    thrdPrint.Join();
                                    break;
                                case 4:
                                    thrdPrint = new Thread(delegate() { clsPrintLabels.printObservationCoilLabelPL(lstCoil[selectedCoilIndex / 2].codsec); });
                                    thrdPrint.Start();
                                    thrdPrint.Join();
                                    break;
                                default:
                                    thrdPrint = new Thread(delegate() { clsPrintLabels.printObservationCoilLabel(lstCoil[selectedCoilIndex / 2].codsec); });
                                    thrdPrint.Start();
                                    thrdPrint.Join();
                                    break;
                            }
                            
                        }
                        

                    }
                    MessageBox.Show("La bobina se ha guardado con éxito.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    if ((selectedCoilIndex + 1) < grpbCombination.Controls.Count - 1)
                    {
                        updateCoilLayout();
                        //selectCoilInLayout(selectedCoilIndex + 2);
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
                //Nahuel: Hardcodeo para que se cierre despues de digitar una bobina en cortadora primaria campana
                if(objMachine.Cutter.name=="ATLAS")
                {
                    this.Close();
                }
                
            }
        }

        private void cmbQuality_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbQuality.Text == "Observación")
            //    grpbSalesOrderSumary.Enabled = true;
            //else
            //    grpbSalesOrderSumary.Enabled = false;
        }

        private void txtGrossWeigthNew_TextChanged(object sender, EventArgs e)
        {
            double netWeigth = 0;

            try
            {
                if (txtGrossWeigthNew.Text != "")
                {
                    if (clsGlobal.isNumeric(txtGrossWeigthNew.Text))
                    {
                        if (lblWidth.Text != string.Empty && Convert.ToInt32(lblWidth.Text) < 1600)
                        {
                            //resto el peso del core de carton de 8mm de 3 o de 6 pulgadas
                            netWeigth = Convert.ToDouble(txtGrossWeigthNew.Text) - (objProduct.width * (new clsCore(objProduct.fkCore)).weigthPerMilimeter);
                        }
                        else
                        {
                            //resta el peso del core de carton de 15mm de 6 pulgadas
                            netWeigth = Convert.ToDouble(txtGrossWeigthNew.Text) - (objProduct.width * (new clsCore(objProduct.fkCore)).weigthPerMilimeter2);
                        }


                        lblNetWeigth.Text = Convert.ToString(Math.Round(netWeigth, 1));

                        lblDensity.Text = Convert.ToString(clsCoil.getCoilDensity(Convert.ToDouble(lblNetWeigth.Text), Convert.ToDouble(txtDiameter.Text), new clsCore(objProduct.fkCore), objProduct.width));
                    }
                    else
                        MessageBox.Show("El valor debe ser Numérico", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
                else
                {
                    txtGrossWeigthNew.Text = "0";
                }
            }
            catch
            {

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
                List<clsCoilCellar> lstCoilCellar = clsCoilCellar.getInitialCellarList(new clsSector(objMachine.fkSector).fkPlant);
                cmbCoilCellar.Items.Clear();
                for (int i = 0; i < lstCoilCellar.Count; i++)
                    cmbCoilCellar.Items.Add(lstCoilCellar[i]);
            }
        }

        private void txtDiameter_TextChanged(object sender, EventArgs e)
        {
            double netWeigth = 0;
             if (txtGrossWeigthNew.Text != "")
             {
                 if (clsGlobal.isNumeric(txtGrossWeigthNew.Text))
                 {

                     if (lblWidth.Text!=string.Empty && Convert.ToInt32(lblWidth.Text) < 1600)
                     {
                         //resto el peso del core de carton de 8mm de 3 o de 6 pulgadas
                         netWeigth = Convert.ToDouble(txtGrossWeigthNew.Text) - (objProduct.width * (new clsCore(objProduct.fkCore)).weigthPerMilimeter);
                     }
                     else
                     {
                         //resta el peso del core de carton de 15mm de 6 pulgadas
                         netWeigth = Convert.ToDouble(txtGrossWeigthNew.Text) - (objProduct.width * (new clsCore(objProduct.fkCore)).weigthPerMilimeter2);
                     }
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

        private void lblDensity_TextChanged(object sender, EventArgs e)
        {
            /*if (objCuttingStop.lstMainCoilByCuttingStop.Count > 0)
            {
                double mainCoilDensity = objCuttingStop.lstMainCoilByCuttingStop[objCuttingStop.lstMainCoilByCuttingStop.Count - 1].mainCoil.gramaje / clsMainCoilQuality.getQualityByMainCoil(objCuttingStop.lstMainCoilByCuttingStop[objCuttingStop.lstMainCoilByCuttingStop.Count - 1].mainCoil.codsec).thiknessAverage;

                if (Convert.ToDouble(lblDensity.Text) >= mainCoilDensity)
                    lblDensity.ForeColor = Color.Red;
                else if (Convert.ToDouble(lblDensity.Text) <= (mainCoilDensity - 0.03))
                    lblDensity.ForeColor = Color.Green;
                else
                    lblDensity.ForeColor = Color.Black;
            }
            else if (objCuttingStop.lstSecundaryCutCoil.Count > 0)
            {
                if (Convert.ToDouble(lblDensity.Text) >= objCuttingStop.lstSecundaryCutCoil[objCuttingStop.lstSecundaryCutCoil.Count - 1].objCoil.density)
                    lblDensity.ForeColor = Color.Red;
                else if (Convert.ToDouble(lblDensity.Text) <= (objCuttingStop.lstSecundaryCutCoil[objCuttingStop.lstSecundaryCutCoil.Count - 1].objCoil.density - 0.03))
                    lblDensity.ForeColor = Color.Green;
                else
                    lblDensity.ForeColor = Color.Black;
            }*/
        }

        private void chkManual_CheckedChanged(object sender, EventArgs e)
        {
            if (chkManual.Checked)
            {
                txtGrossWeigthNew.Enabled = true;
                timer1.Enabled = false;
            }
            else
            {
                txtGrossWeigthNew.Enabled = false;
                timer1.Enabled = true;
            }
        }

        private void cmbBalance_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbBalance.SelectedIndex != -1)
                {
                    bal1 = new clsBalance(cmbBalance.SelectedItem.ToString());
                }
            }
            catch
            {
                
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (bal1.codsec != 0)
                {
                    string data = bal1.getWeigth(txtGrossWeigthNew.Text);
                    if (data != string.Empty)
                    {
                        data = data.Replace(",", ".");
                    }
                    if (clsGlobal.isNumeric(data))
                    {
                        txtGrossWeigthNew.Text = Convert.ToDouble(data).ToString();
                    }
                    else
                    {
                        txtGrossWeigthNew.Text = "0";
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Se detectó un error en la comunicación con la balanza, se deshabilitó el pesaje automático. Pesaje manual habilitado.");
                chkManual.Checked = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }


    }
}
