using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using BPS.Bussiness;


namespace BPS
{
    public partial class frmRegisterCoilPalletsImported : Form
    {
        List<clsImportedPallet> lstImportedPallets = new List<clsImportedPallet>();
        clsSalesOrder objSalesOrder = new clsSalesOrder();

        List<string[]> parsedData = new List<string[]>();
        List<clsPallet> lstPallet = new List<clsPallet>();
        bool flgCanBeProcessed = false;

        delegate void showLoading();
        delegate void HideLoading();
        showLoading showLoadImage;
        HideLoading hideLoadImage;

        private void showLoadingDelegate()
        {
            pbxLoading.Visible = true;
            pnlProcess.Visible = true;
            lblLoading.Visible = true;
        }

        private void hideLoadingDelegate()
        {
            pnlProcess.Visible = false;
            pbxLoading.Visible = false;
            lblLoading.Visible = false;
            MessageBox.Show("Se ha realizado la importación de los pallets con éxito.", "Registro de pallets importados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        }


        private void ProcessImport()
        {
            this.Invoke(showLoadImage);
            string treatmentSide = "";
            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                if (dgvImportedPallets.Rows[i].Cells[clmType.Index].Value.ToString() == "P")
                {
                    string oppProductCode = dgvImportedPallets.Rows[i].Cells[clmProductCode.Index].Value.ToString();
                    string diameterCore = dgvImportedPallets.Rows[i].Cells[clmDiameterCore.Index].Value.ToString();
                    string width = dgvImportedPallets.Rows[i].Cells[clmWidth.Index].Value.ToString();

                    string productCode = oppProductCode;
                    /*
                    if (oppProductCode.StartsWith("RPYO"))
                        productCode = oppProductCode.Substring(0, 4).Replace("O", "") + oppProductCode.Substring(4, 4) + oppProductCode.Substring(8, 1).Replace("0", "") + "x" + width + diameterCore;
                    else if (oppProductCode.StartsWith("PGBTF") || oppProductCode.StartsWith("MEBTF"))
                        productCode = oppProductCode;
                    else if (oppProductCode.StartsWith("RKYO"))
                        productCode = oppProductCode.Substring(0, 4).Replace("O", "") + oppProductCode.Substring(4, 4) + oppProductCode.Substring(8, 1).Replace("0", "").Replace("1", "") + "x" + width + diameterCore;
                    else if (oppProductCode.StartsWith("RMYO"))
                        productCode = oppProductCode.Substring(0, 4).Replace("O", "") + oppProductCode.Substring(4, 4) + oppProductCode.Substring(8, 1).Replace("0", "").Replace("1", "") + "x" + width + diameterCore;
                    //else if (oppProductCode.StartsWith("EMC012MQ"))
                    //  productCode = oppProductCode;
                    else if (oppProductCode.StartsWith("EMCMQ") || oppProductCode.StartsWith("ETKTS") || oppProductCode.StartsWith("EMKMN"))
                        productCode = oppProductCode.Substring(0, 3) + "0" + oppProductCode.Substring(5, 2) + oppProductCode.Substring(3, 2) + "x" + width + diameterCore;
                    else if (oppProductCode.StartsWith("EMA"))
                        productCode = oppProductCode;
                    else if (oppProductCode.StartsWith("ET") || oppProductCode.StartsWith("EM") || oppProductCode.StartsWith("ATTT") || oppProductCode.StartsWith("NH"))
                        productCode = oppProductCode;
                    else if (oppProductCode.StartsWith("AM"))
                        productCode = oppProductCode.Substring(0, 2) + "0" + oppProductCode.Substring(4, 2) + "x" + width + diameterCore;
                    else if (oppProductCode.StartsWith("EMOO"))
                        productCode = oppProductCode.Substring(0, 4).Replace("O", "") + oppProductCode.Substring(4, 2) + "0" + oppProductCode.Substring(6, 2) + "x" + width + diameterCore;
                    else if (oppProductCode.StartsWith("RPON"))
                        productCode = oppProductCode.Substring(0, 4).Replace("O", "") + oppProductCode.Substring(4, 5) + "x" + width + diameterCore;
                    else if (oppProductCode.StartsWith("EC"))
                        productCode = oppProductCode;
                    else if (oppProductCode.StartsWith("PGBTP"))
                        productCode = oppProductCode;
                    else if (oppProductCode.StartsWith("REM"))
                        productCode = oppProductCode;
                    else if (oppProductCode.StartsWith("RM"))
                        productCode = oppProductCode;
                    else if (oppProductCode.StartsWith("CC020"))
                        productCode = oppProductCode;
                    else if (oppProductCode.StartsWith("CC030"))
                        productCode = oppProductCode;
                    else if (oppProductCode.StartsWith("RP"))
                        productCode = oppProductCode;
                    else if (oppProductCode.StartsWith("CG"))
                        productCode = oppProductCode;
                    else if (oppProductCode.StartsWith("RPL"))
                        productCode = oppProductCode;
                    else if (oppProductCode.StartsWith("BD"))
                        productCode = oppProductCode;
                    else if (oppProductCode.StartsWith("AV"))
                        productCode = oppProductCode;
                    else if (oppProductCode.StartsWith("AT"))
                        productCode = oppProductCode;
                    else if (oppProductCode.StartsWith("SC"))
                        productCode = oppProductCode;
                    else if (oppProductCode.StartsWith("SD"))
                        productCode = oppProductCode;
                    else if (oppProductCode.StartsWith("CROO100"))
                        productCode = oppProductCode.Substring(0, 4).Replace("O", "") + oppProductCode.Substring(4, 3) + "x" + width + diameterCore;
                    else if (oppProductCode.StartsWith("CROO"))
                        productCode = oppProductCode.Substring(0, 4).Replace("O", "") + "0" + oppProductCode.Substring(4, 2) + "x" + width + diameterCore;
                    else if (oppProductCode.StartsWith("CMC"))
                        productCode = oppProductCode;
                    else
                        productCode = oppProductCode.Substring(0, 4).Replace("O", "") + "0" + oppProductCode.Substring(4, 2) + "x" + width + diameterCore;
                    */
                    clsProduct objProduct = new clsProduct();
                    objProduct.load(productCode);

                    lstPallet.Add(new clsPallet());

                    lstPallet[lstPallet.Count - 1].fkProduct = objProduct.codsec;
                    lstPallet[lstPallet.Count - 1].fkStatus = 38;
                    lstPallet[lstPallet.Count - 1].palletNumber = 1;
                    lstPallet[lstPallet.Count - 1].code = dgvImportedPallets.Rows[i].Cells[clmPalletCode.Index].Value.ToString();
                    lstPallet[lstPallet.Count - 1].netWeight = Math.Round(Convert.ToDouble(dgvImportedPallets.Rows[i].Cells[clmPalletNetWeight.Index].Value),2);
                    lstPallet[lstPallet.Count - 1].grossWeight = Math.Round(Convert.ToDouble(dgvImportedPallets.Rows[i].Cells[clmPalletGrossWeight.Index].Value),2);
                    lstPallet[lstPallet.Count - 1].isPrinted = false;
                    lstPallet[lstPallet.Count - 1].createdBy = clsGlobal.LoggedUser.codsec;
                    lstPallet[lstPallet.Count - 1].modifiedBy = clsGlobal.LoggedUser.codsec;
                    lstPallet[lstPallet.Count - 1].salesOrderNumber = dgvImportedPallets.Rows[i].Cells[clmDestinationOrder.Index].Value.ToString();

                }
                else
                {
                    string oppProductCode = dgvImportedPallets.Rows[i].Cells[clmProductCode.Index].Value.ToString();
                    string diameterCore = dgvImportedPallets.Rows[i].Cells[clmDiameterCore.Index].Value.ToString();
                    string width = dgvImportedPallets.Rows[i].Cells[clmWidth.Index].Value.ToString();

                    string productCode = oppProductCode;
                    /*
                    if (oppProductCode.StartsWith("RPYO"))
                    {
                        productCode = oppProductCode.Substring(0, 4).Replace("O", "") + oppProductCode.Substring(4, 4) + oppProductCode.Substring(8, 1).Replace("0", "") + "x" + width + diameterCore;
                        treatmentSide = "";
                    }
                    else if (oppProductCode.StartsWith("PGBTF") || oppProductCode.StartsWith("MEBTF"))
                        productCode = oppProductCode;
                    else if (oppProductCode.StartsWith("PGBTP"))
                        productCode = oppProductCode;
                    else if (oppProductCode.StartsWith("BD"))
                        productCode = oppProductCode;
                    else if (oppProductCode.StartsWith("AV"))
                        productCode = oppProductCode;
                    else if (oppProductCode.StartsWith("AT"))
                        productCode = oppProductCode;
                    else if (oppProductCode.StartsWith("EC0"))
                        productCode = oppProductCode;
                    else if (oppProductCode.StartsWith("SC"))
                        productCode = oppProductCode;
                    else if (oppProductCode.StartsWith("SD"))
                        productCode = oppProductCode;
                    else if (oppProductCode.StartsWith("RPON"))
                    {
                        productCode = oppProductCode.Substring(0, 4).Replace("O", "") + oppProductCode.Substring(4, 5) + "x" + width + diameterCore;
                        treatmentSide = "";
                    }
                    else if (oppProductCode.StartsWith("RKYO"))
                    {
                        productCode = oppProductCode.Substring(0, 4).Replace("O", "") + oppProductCode.Substring(4, 4) + oppProductCode.Substring(8, 1).Replace("0", "").Replace("1", "") + "x" + width + diameterCore;
                        treatmentSide = "";
                    }
                    else if (oppProductCode.StartsWith("RMYO"))
                    {
                        productCode = oppProductCode.Substring(0, 4).Replace("O", "") + oppProductCode.Substring(4, 4) + oppProductCode.Substring(8, 1).Replace("0", "").Replace("1", "") + "x" + width + diameterCore;
                        treatmentSide = "";
                    }
                    //else if (oppProductCode.StartsWith("EMC012MQ"))
                    //  productCode = oppProductCode;
                    else if (oppProductCode.StartsWith("EMCMQ") || oppProductCode.StartsWith("ETKTS") || oppProductCode.StartsWith("EMKMN"))
                        productCode = oppProductCode.Substring(0, 3) + "0" + oppProductCode.Substring(5, 2) + oppProductCode.Substring(3, 2) + "x" + width + diameterCore;
                    else if (oppProductCode.StartsWith("EMA"))
                        productCode = oppProductCode;
                    else if (oppProductCode.StartsWith("ET") || oppProductCode.StartsWith("EM") || oppProductCode.StartsWith("ATTT") || oppProductCode.StartsWith("NH"))
                    {
                        productCode = oppProductCode;
                        treatmentSide = "";
                    }
                    else if (oppProductCode.StartsWith("AM"))
                    {
                        productCode = oppProductCode.Substring(0, 2) + "0" + oppProductCode.Substring(4, 2) + "x" + width + diameterCore;
                        treatmentSide = "";
                    }
                    else if (oppProductCode.StartsWith("EMOO"))
                    {
                        productCode = oppProductCode.Substring(0, 4).Replace("O", "") + oppProductCode.Substring(4, 2) + "0" + oppProductCode.Substring(6, 2) + "x" + width + diameterCore;
                        treatmentSide = "";
                    }
                    else if (oppProductCode.StartsWith("RHVO"))
                    {
                        productCode = oppProductCode.Substring(0, 4).Replace("O", "") + "0" + oppProductCode.Substring(4, 2) + "x" + width + diameterCore;
                        treatmentSide = "";
                    }
                    else if (oppProductCode.StartsWith("CROO100"))
                    {
                        productCode = oppProductCode.Substring(0, 4).Replace("O", "") + oppProductCode.Substring(4, 3) + "x" + width + diameterCore;
                        treatmentSide = "";
                    }
                    else if (oppProductCode.StartsWith("EC"))
                        productCode = oppProductCode;
                    else if (oppProductCode.StartsWith("CG"))
                        productCode = oppProductCode;
                    else if (oppProductCode.StartsWith("CR"))
                        productCode = oppProductCode.Substring(0, 4).Replace("O", "") + oppProductCode.Substring(4, 3) + "x" + width + diameterCore;
                    else if (oppProductCode.StartsWith("REM"))
                        productCode = oppProductCode;
                    else if (oppProductCode.StartsWith("RM"))
                        productCode = oppProductCode;
                    else if (oppProductCode.StartsWith("RP"))
                        productCode = oppProductCode;
                    else if (oppProductCode.StartsWith("RPL"))
                        productCode = oppProductCode;
                    else if (oppProductCode.StartsWith("CMC"))
                        productCode = oppProductCode;
                    else if (oppProductCode.StartsWith("CC020"))
                        productCode = oppProductCode;
                    else if (oppProductCode.StartsWith("CC030"))
                        productCode = oppProductCode;
                    else if (oppProductCode.StartsWith("CROO"))
                    {
                        productCode = oppProductCode.Substring(0, 4).Replace("O", "") + "0" + oppProductCode.Substring(4, 2) + "x" + width + diameterCore;
                        treatmentSide = "";
                    }
                    else
                    {
                        productCode = oppProductCode.Substring(0, 4).Replace("O", "") + "0" + oppProductCode.Substring(4, 2) + "x" + width + diameterCore;
                        treatmentSide = "Externo";
                    }
                    */


                    clsProduct objProduct = new clsProduct();
                    objProduct.load(productCode);

                    lstPallet[lstPallet.Count - 1].lstCoil.Add(new clsCoil());
                    int lstPos = lstPallet[lstPallet.Count - 1].lstCoil.Count - 1;

                    lstPallet[lstPallet.Count - 1].lstCoil[lstPos].fkCuttingQuality = 3;
                    lstPallet[lstPallet.Count - 1].lstCoil[lstPos].fkBalance = 1012;
                    lstPallet[lstPallet.Count - 1].lstCoil[lstPos].fkProduct = objProduct.codsec;
                    lstPallet[lstPallet.Count - 1].lstCoil[lstPos].fkStatus = 33;
                    lstPallet[lstPallet.Count - 1].lstCoil[lstPos].code = dgvImportedPallets.Rows[i].Cells[clmCoilCode.Index].Value.ToString();
                    lstPallet[lstPallet.Count - 1].lstCoil[lstPos].length = Convert.ToDouble(dgvImportedPallets.Rows[i].Cells[clmLenght.Index].Value.ToString());
                    lstPallet[lstPallet.Count - 1].lstCoil[lstPos].width = Convert.ToDouble(dgvImportedPallets.Rows[i].Cells[clmWidth.Index].Value.ToString());
                    lstPallet[lstPallet.Count - 1].lstCoil[lstPos].diameter = Convert.ToDouble(dgvImportedPallets.Rows[i].Cells[clmDiameter.Index].Value.ToString());
                    lstPallet[lstPallet.Count - 1].lstCoil[lstPos].cuttingPosition = 1;
                    lstPallet[lstPallet.Count - 1].lstCoil[lstPos].cuttingStop = 1;
                    lstPallet[lstPallet.Count - 1].lstCoil[lstPos].netWeight = Math.Round(Convert.ToDouble(dgvImportedPallets.Rows[i].Cells[clmNetWeightCoil.Index].Value.ToString()),2);
                    lstPallet[lstPallet.Count - 1].lstCoil[lstPos].density = clsCoil.getCoilDensity(lstPallet[lstPallet.Count - 1].lstCoil[lstPos].netWeight, lstPallet[lstPallet.Count - 1].lstCoil[lstPos].diameter, new clsCore(objProduct.fkCore), objProduct.width);
                    lstPallet[lstPallet.Count - 1].lstCoil[lstPos].grossWeight = lstPallet[lstPallet.Count - 1].lstCoil[lstPos].netWeight + (objProduct.width * (new clsCore(objProduct.fkCore).weigthPerMilimeter));
                    lstPallet[lstPallet.Count - 1].lstCoil[lstPos].treatmentSide = treatmentSide;
                    lstPallet[lstPallet.Count - 1].lstCoil[lstPos].defects = "0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0";
                    lstPallet[lstPallet.Count - 1].lstCoil[lstPos].notes = "";
                    lstPallet[lstPallet.Count - 1].lstCoil[lstPos].createdBy = clsGlobal.LoggedUser.codsec;
                    lstPallet[lstPallet.Count - 1].lstCoil[lstPos].modifiedBy = clsGlobal.LoggedUser.codsec;
                    lstPallet[lstPallet.Count - 1].lstCoil[lstPos].isExternalCoil = true;
                    lstPallet[lstPallet.Count - 1].lstCoil[lstPos].lotNumber = dgvImportedPallets.Rows[i].Cells[clmLotNumber.Index].Value.ToString();
                    lstPallet[lstPallet.Count - 1].lstCoil[lstPos].mainCoilCode = dgvImportedPallets.Rows[i].Cells[clmMainCoilCode.Index].Value.ToString();
                    lstPallet[lstPallet.Count - 1].lstCoil[lstPos].extrusionDate = DateTime.Parse(dgvImportedPallets.Rows[i].Cells[clmExtrusionDate.Index].Value.ToString());
                    lstPallet[lstPallet.Count - 1].lstCoil[lstPos].salesOrderNumber = dgvImportedPallets.Rows[i].Cells[clmDestinationOrder.Index].Value.ToString();

                }
            }

            for (int i = 0; i < lstPallet.Count; i++)
            {
                if (lstPallet[i].salesOrderNumber == "")
                {
                    clsCoilCellar objCoilCellar = clsCoilCellar.getCellarByName("Ingreso Importación");

                    clsPalletType objPalletType = clsPalletType.getPalletTypeByCoilNumberFloorsOrientation(lstPallet[i].lstCoil.Count, Convert.ToInt32(Math.Ceiling((decimal)(lstPallet[i].lstCoil.Count / 2))), "Horizontal");

                    lstPallet[i].fkPalletType = objPalletType.codsec;
                    lstPallet[i].fkPalletDimention = 1091;

                    lstPallet[i].save();

                    for (int j = 0; j < lstPallet[i].lstCoil.Count; j++)
                    {
                        lstPallet[i].lstCoil[j].save(objCoilCellar.codsec);

                        lstPallet[i].addCoilToPallet(lstPallet[i].lstCoil[j].codsec);
                    }

                    clsPallet.transferTo(lstPallet[i], objCoilCellar.codsec);
                    lstPallet[i] = new clsPallet(lstPallet[i].codsec);
                    lstPallet[i].fkCoilCellar = objCoilCellar.codsec;
                    clsPallet.transferTo(DateTime.Now, lstPallet[i].code, lstPallet[i].codsec, lstPallet[i].fkCoilCellar, lstPallet[i].product.code, lstPallet[i].palletNumber, lstPallet[i].customerName, lstPallet[i].salesOrderNumber, Convert.ToInt32(lstPallet[i].product.width), Math.Round(lstPallet[i].netWeight, 1), "Ingreso a bodega de stock Perú", true, 1);
                }
                else
                {
                    clsCoilCellar objCoilCellar = clsCoilCellar.getCellarByName("Ingreso Importación");

                    clsPalletType objPalletType = clsPalletType.getPalletTypeByCoilNumberFloorsOrientation(lstPallet[i].lstCoil.Count, Convert.ToInt32(Math.Ceiling((decimal)(lstPallet[i].lstCoil.Count / 2))), "Horizontal");

                    lstPallet[i].fkPalletType = objPalletType.codsec;
                    lstPallet[i].fkPalletDimention = 1091;

                    lstPallet[i].save(lstPallet[i].salesOrderNumber);

                    for (int j = 0; j < lstPallet[i].lstCoil.Count; j++)
                    {
                        lstPallet[i].lstCoil[j].save(lstPallet[i].salesOrderNumber, objCoilCellar.codsec);

                        lstPallet[i].addCoilToPallet(lstPallet[i].lstCoil[j].codsec);
                    }

                    //clsPallet.transferTo(lstPallet[i], objCoilCellar.codsec);
                    lstPallet[i] = new clsPallet(lstPallet[i].codsec);
                    lstPallet[i].fkCoilCellar = objCoilCellar.codsec;
                    clsPallet.transferTo(DateTime.Now, lstPallet[i].code, lstPallet[i].codsec, lstPallet[i].fkCoilCellar, lstPallet[i].product.code, lstPallet[i].palletNumber, lstPallet[i].customerName, lstPallet[i].salesOrderNumber, Convert.ToInt32(lstPallet[i].product.width), Math.Round(lstPallet[i].netWeight, 1), "Ingreso a bodega de producto terminado", true, 1);
                }
            }

            this.Invoke(hideLoadImage);
        }

        public frmRegisterCoilPalletsImported()
        {
            InitializeComponent();
        }
        public void importFromFile()
        {
            parseCSV(txtFileName.Text);

            try
            {
                for (int i = 0; i < parsedData.Count; i++)
                {
                    if (parsedData[i][0] != "Orden")
                    {
                        if (parsedData[i][8] == "0")
                        {
                            lstImportedPallets.Add(new clsImportedPallet());

                            lstImportedPallets[lstImportedPallets.Count - 1].importedProductCode = parsedData[i][1];
                            lstImportedPallets[lstImportedPallets.Count - 1].importedWidth = Convert.ToInt32(parsedData[i][2]);
                            lstImportedPallets[lstImportedPallets.Count - 1].diameterCore = parsedData[i][3];
                            lstImportedPallets[lstImportedPallets.Count - 1].code = parsedData[i][4];
                            lstImportedPallets[lstImportedPallets.Count - 1].netWeight = Math.Round(Convert.ToDouble(parsedData[i][6]),2);
                            lstImportedPallets[lstImportedPallets.Count - 1].grossWeight = Math.Round(Convert.ToDouble(parsedData[i][5]),2);
                            lstImportedPallets[lstImportedPallets.Count - 1].date = parsedData[i][7];
                            lstImportedPallets[lstImportedPallets.Count - 1].lstImportedCoil = new List<clsImportedCoil>();
                            lstImportedPallets[lstImportedPallets.Count - 1].destinationOrder = parsedData[i][16];
                        }
                        else
                        {
                            lstImportedPallets[lstImportedPallets.Count - 1].lstImportedCoil.Add(new clsImportedCoil());

                            int pos = lstImportedPallets[lstImportedPallets.Count - 1].lstImportedCoil.Count - 1;

                            lstImportedPallets[lstImportedPallets.Count - 1].lstImportedCoil[pos].importedProductCode = parsedData[i][1];
                            lstImportedPallets[lstImportedPallets.Count - 1].lstImportedCoil[pos].importedWidth = Convert.ToInt32(parsedData[i][2]);
                            lstImportedPallets[lstImportedPallets.Count - 1].lstImportedCoil[pos].diameterCore = parsedData[i][3];
                            lstImportedPallets[lstImportedPallets.Count - 1].lstImportedCoil[pos].code = parsedData[i][9];
                            lstImportedPallets[lstImportedPallets.Count - 1].lstImportedCoil[pos].netWeight = Math.Round(Convert.ToDouble(parsedData[i][8]),2);
                            lstImportedPallets[lstImportedPallets.Count - 1].lstImportedCoil[pos].length = Convert.ToDouble(parsedData[i][10]);
                            lstImportedPallets[lstImportedPallets.Count - 1].lstImportedCoil[pos].diameter = Convert.ToDouble(parsedData[i][11]);
                            lstImportedPallets[lstImportedPallets.Count - 1].lstImportedCoil[pos].mainCoilCode = parsedData[i][12];
                            lstImportedPallets[lstImportedPallets.Count - 1].lstImportedCoil[pos].lotNumber = parsedData[i][13];
                            lstImportedPallets[lstImportedPallets.Count - 1].lstImportedCoil[pos].extrusionDate = parsedData[i][15];
                            lstImportedPallets[lstImportedPallets.Count - 1].lstImportedCoil[pos].destinationOrder = parsedData[i][16];
                        }
                    }
                }

                for (int i = 0; i < lstImportedPallets.Count; i++)
                {
                    if (lstImportedPallets[i].lstImportedCoil.Count == 0)
                        lstImportedPallets.RemoveAt(i);
                }

                dgvImportedPallets.Rows.Clear();
                int coilCount = 0;

                for (int i = 0; i < lstImportedPallets.Count; i++)
                {
                    dgvImportedPallets.Rows.Add();

                    int dgvPos = dgvImportedPallets.Rows.Count - 1;

                    dgvImportedPallets.Rows[dgvPos].Cells[clmType.Index].Value = "P";
                    dgvImportedPallets.Rows[dgvPos].Cells[clmPalletCode.Index].Value = lstImportedPallets[i].code;
                    dgvImportedPallets.Rows[dgvPos].Cells[clmProductCode.Index].Value = lstImportedPallets[i].importedProductCode.ToUpper();
                    dgvImportedPallets.Rows[dgvPos].Cells[clmWidth.Index].Value = lstImportedPallets[i].importedWidth;
                    dgvImportedPallets.Rows[dgvPos].Cells[clmDiameterCore.Index].Value = lstImportedPallets[i].diameterCore;
                    dgvImportedPallets.Rows[dgvPos].Cells[clmPalletNetWeight.Index].Value = Math.Round(lstImportedPallets[i].netWeight,2);
                    dgvImportedPallets.Rows[dgvPos].Cells[clmPalletGrossWeight.Index].Value = Math.Round(lstImportedPallets[i].grossWeight,2);
                    dgvImportedPallets.Rows[dgvPos].Cells[clmDestinationOrder.Index].Value = lstImportedPallets[i].destinationOrder;

                    for (int j = 0; j < lstImportedPallets[i].lstImportedCoil.Count; j++)
                    {
                        dgvImportedPallets.Rows.Add();

                        dgvPos = dgvImportedPallets.Rows.Count - 1;

                        dgvImportedPallets.Rows[dgvPos].Cells[clmType.Index].Value = "C";
                        dgvImportedPallets.Rows[dgvPos].Cells[clmProductCode.Index].Value = lstImportedPallets[i].importedProductCode.ToUpper();
                        dgvImportedPallets.Rows[dgvPos].Cells[clmWidth.Index].Value = lstImportedPallets[i].importedWidth;
                        dgvImportedPallets.Rows[dgvPos].Cells[clmDiameterCore.Index].Value = lstImportedPallets[i].diameterCore;
                        dgvImportedPallets.Rows[dgvPos].Cells[clmCoilCode.Index].Value = lstImportedPallets[i].lstImportedCoil[j].code;
                        dgvImportedPallets.Rows[dgvPos].Cells[clmNetWeightCoil.Index].Value = Math.Round(lstImportedPallets[i].lstImportedCoil[j].netWeight,2);
                        dgvImportedPallets.Rows[dgvPos].Cells[clmLenght.Index].Value = lstImportedPallets[i].lstImportedCoil[j].length;
                        dgvImportedPallets.Rows[dgvPos].Cells[clmDiameter.Index].Value = lstImportedPallets[i].lstImportedCoil[j].diameter;
                        dgvImportedPallets.Rows[dgvPos].Cells[clmMainCoilCode.Index].Value = lstImportedPallets[i].lstImportedCoil[j].mainCoilCode;
                        dgvImportedPallets.Rows[dgvPos].Cells[clmLotNumber.Index].Value = lstImportedPallets[i].lstImportedCoil[j].lotNumber;
                        dgvImportedPallets.Rows[dgvPos].Cells[clmExtrusionDate.Index].Value = lstImportedPallets[i].lstImportedCoil[j].extrusionDate;
                        dgvImportedPallets.Rows[dgvPos].Cells[clmDestinationOrder.Index].Value = lstImportedPallets[i].lstImportedCoil[j].destinationOrder;

                        coilCount++;
                    }
                }

                lblImportedPallets.Text = lstImportedPallets.Count.ToString();
                lblImportedCoils.Text = coilCount.ToString();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Registro de pallets importados", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Registro de pallets importados", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                //throw;
            }

        }

        public List<string[]> parseCSV(string path)
        {
            try
            {
                parsedData = new List<string[]>();

                using (StreamReader readFile = new StreamReader(path))
                {
                    string line;
                    string[] row;

                    while ((line = readFile.ReadLine()) != null)
                    {
                        row = line.Split(',');
                        parsedData.Add(row);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return parsedData;
        }

        private void frmRegisterCoilPalletsImported_Load(object sender, EventArgs e)
        {
            getPalletList();
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            opfImport.ShowDialog();
            txtFileName.Text = opfImport.FileName;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            importFromFile();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            flgCanBeProcessed = true;

            for (int i = 0; i < dgvImportedPallets.Rows.Count; i++)
            {
                string oppProductCode = dgvImportedPallets.Rows[i].Cells[clmProductCode.Index].Value.ToString();
                string diameterCore = dgvImportedPallets.Rows[i].Cells[clmDiameterCore.Index].Value.ToString();
                string width = dgvImportedPallets.Rows[i].Cells[clmWidth.Index].Value.ToString();
                string productCode = oppProductCode;
                /*
                if (oppProductCode.StartsWith("RPYO"))
                    productCode = oppProductCode.Substring(0, 4).Replace("O", "") + oppProductCode.Substring(4, 4) + oppProductCode.Substring(8, 1).Replace("0", "") + "x" + width + diameterCore;
                else if (oppProductCode.StartsWith("PGBTF") || oppProductCode.StartsWith("MEBTF"))
                    productCode = oppProductCode;
                else if (oppProductCode.StartsWith("RKYO"))
                    productCode = oppProductCode.Substring(0, 4).Replace("O", "") + oppProductCode.Substring(4, 4) + oppProductCode.Substring(8, 1).Replace("0", "").Replace("1", "") + "x" + width + diameterCore;
                else if (oppProductCode.StartsWith("RMYO"))
                    productCode = oppProductCode.Substring(0, 4).Replace("O", "") + oppProductCode.Substring(4, 4) + oppProductCode.Substring(8, 1).Replace("0", "").Replace("1", "") + "x" + width + diameterCore;
                //else if (oppProductCode.StartsWith("EMOO"))
                //    productCode = oppProductCode.Substring(0, 4).Replace("O", "") + oppProductCode.Substring(4, 2) + "0" + oppProductCode.Substring(6, 2) + "x" + width + diameterCore;
                else if (oppProductCode.StartsWith("EMCMQ") || oppProductCode.StartsWith("ETKTS") || oppProductCode.StartsWith("EMKMN"))
                    productCode = oppProductCode.Substring(0, 3) + "0" + oppProductCode.Substring(5, 2) + oppProductCode.Substring(3, 2) + "x" + width + diameterCore;
                //else if (oppProductCode.StartsWith("EMC012MQ"))
                //  productCode = oppProductCode;
                else if (oppProductCode.StartsWith("EMA"))
                    productCode = oppProductCode;
                else if (oppProductCode.StartsWith("EM0"))
                    productCode = oppProductCode;
                else if (oppProductCode.StartsWith("ET") || oppProductCode.StartsWith("EM") || oppProductCode.StartsWith("ATTT") || oppProductCode.StartsWith("NH"))
                    productCode = oppProductCode;
                else if (oppProductCode.StartsWith("AM"))
                    productCode = oppProductCode.Substring(0, 2) + "0" + oppProductCode.Substring(4, 2) + "x" + width + diameterCore;
                else if (oppProductCode.StartsWith("RPON"))
                    productCode = oppProductCode.Substring(0, 4).Replace("O", "") + oppProductCode.Substring(4, 5) + "x" + width + diameterCore;
                else if (oppProductCode.StartsWith("EC"))
                    productCode = oppProductCode;
                else if (oppProductCode.StartsWith("PGBTP"))
                    productCode = oppProductCode;
                else if (oppProductCode.StartsWith("REM"))
                    productCode = oppProductCode;
                else if (oppProductCode.StartsWith("RM"))
                    productCode = oppProductCode;
                else if (oppProductCode.StartsWith("RP"))
                    productCode = oppProductCode;
                else if (oppProductCode.StartsWith("RPL"))
                    productCode = oppProductCode;
                else if (oppProductCode.StartsWith("BD"))
                    productCode = oppProductCode;
                else if (oppProductCode.StartsWith("AV"))
                    productCode = oppProductCode;
                else if (oppProductCode.StartsWith("AT"))
                    productCode = oppProductCode;
                else if (oppProductCode.StartsWith("SCCK"))
                    productCode = oppProductCode.Substring(0, 4).Replace("O", "") + "0" + oppProductCode.Substring(4, 2) + "x" + width + diameterCore;
                else if (oppProductCode.StartsWith("SC"))
                    productCode = oppProductCode;
                else if (oppProductCode.StartsWith("SD"))
                    productCode = oppProductCode;
                else if (oppProductCode.StartsWith("CC030"))
                    productCode = oppProductCode;
                else if (oppProductCode.StartsWith("CG"))
                    productCode = oppProductCode;
                else if (oppProductCode.StartsWith("CC0"))
                    productCode = oppProductCode;
                else if (oppProductCode.StartsWith("CR"))
                    productCode = oppProductCode.Substring(0, 4).Replace("O", "") + oppProductCode.Substring(4, 3) + "x" + width + diameterCore;
                else if (oppProductCode.StartsWith("CROO100"))
                    productCode = oppProductCode.Substring(0, 4).Replace("O", "") + oppProductCode.Substring(4, 3) + "x" + width + diameterCore;
                else if (oppProductCode.StartsWith("CROO"))
                    productCode = oppProductCode.Substring(0, 4).Replace("O", "") + "0" + oppProductCode.Substring(4, 2) + "x" + width + diameterCore;
                else if (oppProductCode.StartsWith("CMC"))
                    productCode = oppProductCode;
                else
                    productCode = oppProductCode.Substring(0, 4).Replace("O", "") + "0" + oppProductCode.Substring(4, 2) + "x" + width + diameterCore;
                */


                clsProduct objProduct = new clsProduct();
                objProduct.load(productCode);

                string palletCode = "";
                string coilCode = "";

                if (dgvImportedPallets.Rows[i].Cells[clmType.Index].Value.ToString() == "P")
                {
                    palletCode = dgvImportedPallets.Rows[i].Cells[clmPalletCode.Index].Value.ToString();
                    if (palletCode != "")
                    {
                        if (clsPallet.getPalletValidate(palletCode))
                        {
                            dgvImportedPallets.Rows[i].Cells[clmPalletCode.Index].Style.ForeColor = Color.Orange;
                            flgCanBeProcessed = false;
                        }
                        else
                            dgvImportedPallets.Rows[i].Cells[clmPalletCode.Index].Style.ForeColor = Color.Black;
                    }
                    else
                        dgvImportedPallets.Rows[i].Cells[clmPalletCode.Index].Style.ForeColor = Color.Black;
                }
                else if (dgvImportedPallets.Rows[i].Cells[clmType.Index].Value.ToString() == "C")
                {
                    coilCode = dgvImportedPallets.Rows[i].Cells[clmCoilCode.Index].Value.ToString();
                    if (coilCode != "")
                    {
                        if (clsCoil.getCoilValidate(coilCode))
                        {
                            dgvImportedPallets.Rows[i].Cells[clmCoilCode.Index].Style.ForeColor = Color.Purple;
                            flgCanBeProcessed = false;
                        }
                        else
                            dgvImportedPallets.Rows[i].Cells[clmCoilCode.Index].Style.ForeColor = Color.Black;
                    }
                    else
                        dgvImportedPallets.Rows[i].Cells[clmCoilCode.Index].Style.ForeColor = Color.Black;
                }

                if (dgvImportedPallets.Rows[i].Cells[clmDestinationOrder.Index].Value.ToString() != "")
                {
                    objSalesOrder = new clsSalesOrder();
                    objSalesOrder = clsSalesOrder.getDetailByNumber(dgvImportedPallets.Rows[i].Cells[clmDestinationOrder.Index].Value.ToString());
                    bool isProduct = true;
                    for (int j = 0; j < objSalesOrder.lstSalesOrderDetail.Count; j++)
                    {
                        if (objSalesOrder.lstSalesOrderDetail[j].product.code.ToUpper() == productCode.ToUpper())
                        {
                            isProduct = true;
                            break;
                        }
                        else
                            isProduct = false;
                    }
                    if (!isProduct)
                    {
                        dgvImportedPallets.Rows[i].Cells[clmDiameterCore.Index].Style.ForeColor = Color.Green;
                        dgvImportedPallets.Rows[i].Cells[clmWidth.Index].Style.ForeColor = Color.Green;
                        flgCanBeProcessed = false;
                    }
                    else
                    {
                        dgvImportedPallets.Rows[i].Cells[clmDiameterCore.Index].Style.ForeColor = Color.Black;
                        dgvImportedPallets.Rows[i].Cells[clmWidth.Index].Style.ForeColor = Color.Black;
                    }
                }

                if (objProduct.codsec == 0)
                {
                    dgvImportedPallets.Rows[i].Cells[clmProductCode.Index].Style.ForeColor = Color.Red;
                    flgCanBeProcessed = false;
                }
                else
                {
                    dgvImportedPallets.Rows[i].Cells[clmProductCode.Index].Style.ForeColor = Color.Black;
                }
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                lstPallet = new List<clsPallet>();
                if (flgCanBeProcessed)
                {
                    //getPalletList();
                    Thread td = new Thread(new ThreadStart(this.ProcessImport));
                    td.Start();

                }
                else
                    MessageBox.Show("Usted no puede procesar el archivo debido a que no paso la prueba de revisión del mismo, puede existir varios conflictos\r\nComo son Códigos de Pallets duplicados, \r\nCódigo de Bobinas duplicados, \r\nNo existe el producto en el sistema\r\nEl Producto que desea incorporar a la orden correspondiente no es igual ya sea por ANCHO o CORE", "Registro de pallets importados", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha surgido un error en el proceso de importación de pallets, verifique que la información esta validada. " + ex.Message, "Registro de pallets importados", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void getPalletList()
        {
            showLoadImage = new showLoading(showLoadingDelegate);
            hideLoadImage = new HideLoading(hideLoadingDelegate);
        }

        private void btnNewImport_Click(object sender, EventArgs e)
        {
            DataTable table = clsConnectionAccess.getPL();

            for(int i=0;i<table.Rows.Count;i++)
            {
                dgvImportedPallets.Rows.Add();
                dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmPalletCode.Index].Value = table.Rows[i][4];
                dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmProductCode.Index].Value = table.Rows[i][1];
                dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmWidth.Index].Value = table.Rows[i][2];
                dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmDiameterCore.Index].Value = table.Rows[i][3];
                dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmPalletNetWeight.Index].Value = table.Rows[i][6];
                dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmPalletGrossWeight.Index].Value = table.Rows[i][5];
                dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmCoilCode.Index].Value = table.Rows[i][9];
                dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmNetWeightCoil.Index].Value = table.Rows[i][8];
                dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmLenght.Index].Value = table.Rows[i][10];
                dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmDiameter.Index].Value = table.Rows[i][11];
                dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmMainCoilCode.Index].Value = table.Rows[i][14];
                dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmLotNumber.Index].Value = table.Rows[i][13];
                dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmExtrusionDate.Index].Value = table.Rows[i][15];
                if(dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmNetWeightCoil.Index].Value.ToString()=="0")
                {
                    dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmType.Index].Value = "P";
                }
                else
                {
                    dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmType.Index].Value = "C";
                }
                dgvImportedPallets.Rows[dgvImportedPallets.Rows.Count - 1].Cells[clmDestinationOrder.Index].Value = "";
            }
        }
    }
}
