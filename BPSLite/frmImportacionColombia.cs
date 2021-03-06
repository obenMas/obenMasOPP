using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS.Lite
{
    public partial class frmImportacionColombia : Form
    {
        bool flgCanBeProcessed=false;
        List<clsPallet> lstPallet = new List<clsPallet>();


        public frmImportacionColombia()
        {
            InitializeComponent();
        }

        private void btnObtenerPL_Click(object sender, EventArgs e)
        {
            
            DataTable table = clsConnectionAccess.getPLCOLOMBIA();
            

            string stringprod = "";
            string stringdiam = "";
            string stringancho = "";
            string stringtratamiento = "";
            clsProduct prod = new clsProduct();

            dgv.Rows.Clear();

            if(table.Rows.Count>0)
            {
                for(int i=0;i<table.Rows.Count;i++)
                {
                    dgv.Rows.Add();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[producto.Index].Value = table.Rows[i][1];                    
                    
                    dgv.Rows[dgv.Rows.Count - 1].Cells[ancho.Index].Value = table.Rows[i][2];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[diametro.Index].Value = table.Rows[i][3];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[pallet.Index].Value = table.Rows[i][4];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[brutoPallet.Index].Value = table.Rows[i][5];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[netoPallet.Index].Value = table.Rows[i][6];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[fecha.Index].Value = table.Rows[i][7];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[netoBobina.Index].Value = table.Rows[i][8];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[bobina.Index].Value = table.Rows[i][9];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[largo.Index].Value = table.Rows[i][10];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[diam.Index].Value = table.Rows[i][11];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[lote.Index].Value = table.Rows[i][13];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[bobinaMadre.Index].Value = table.Rows[i][14];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[fechaFab.Index].Value = table.Rows[i][15];
                    if(Convert.ToInt32(table.Rows[i][8])==0)
                    {
                        dgv.Rows[dgv.Rows.Count - 1].Cells[tipo.Index].Value = "P";
                    }
                    else
                    {
                        dgv.Rows[dgv.Rows.Count - 1].Cells[tipo.Index].Value = "C";
                    }
                }
            }
            
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            flgCanBeProcessed = true;
            int totpal = 0;
            int totbob = 0;
            double totkil = 0;

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                string oppProductCode = dgv.Rows[i].Cells[producto.Index].Value.ToString();
                string diameterCore = dgv.Rows[i].Cells[diametro.Index].Value.ToString();
                string width = dgv.Rows[i].Cells[ancho.Index].Value.ToString();
                string productCode = oppProductCode;
                
                clsProduct objProduct = new clsProduct();
                objProduct.load(productCode);

                string palletCode = "";
                string coilCode = "";

                if (dgv.Rows[i].Cells[tipo.Index].Value.ToString() == "P")
                {
                    totpal++;
                    totkil += Convert.ToDouble(dgv.Rows[i].Cells[netoPallet.Index].Value);
                    palletCode = dgv.Rows[i].Cells[pallet.Index].Value.ToString();
                    if (palletCode != "")
                    {
                        if (clsPallet.getPalletValidate(palletCode))
                        {
                            dgv.Rows[i].Cells[pallet.Index].Style.ForeColor = Color.Orange;
                            flgCanBeProcessed = false;
                        }
                        else
                            dgv.Rows[i].Cells[pallet.Index].Style.ForeColor = Color.Black;
                    }
                    else
                        dgv.Rows[i].Cells[pallet.Index].Style.ForeColor = Color.Black;
                }
                else if (dgv.Rows[i].Cells[tipo.Index].Value.ToString() == "C")
                {
                    totbob++;
                    coilCode = dgv.Rows[i].Cells[bobina.Index].Value.ToString();
                    if (coilCode != "")
                    {
                        if (clsCoil.getCoilValidate(coilCode))
                        {
                            dgv.Rows[i].Cells[bobina.Index].Style.ForeColor = Color.Purple;
                            flgCanBeProcessed = false;
                        }
                        else
                            dgv.Rows[i].Cells[bobina.Index].Style.ForeColor = Color.Black;
                    }
                    else
                        dgv.Rows[i].Cells[bobina.Index].Style.ForeColor = Color.Black;
                }

                if (objProduct.codsec == 0)
                {
                    dgv.Rows[i].Cells[producto.Index].Style.ForeColor = Color.Red;
                    flgCanBeProcessed = false;
                }
                else
                {
                    dgv.Rows[i].Cells[producto.Index].Style.ForeColor = Color.Black;
                }
            }

            if(flgCanBeProcessed)
            {
                txtListo.Text = "Listo";
                txtListo.BackColor = Color.Green;
                //txtListo.ForeColor = Color.Black;
                
            }
            txtPallets.Text = totpal.ToString();
            txtBobinas.Text = totbob.ToString();
            txtKilos.Text = totkil.ToString();
            MessageBox.Show("Datos verificados. En caso de haber datos que no se puedan ingresar, se verán los códigos pintados de color.","Verificación realizada",MessageBoxButtons.OK);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                lstPallet = new List<clsPallet>();
                if (flgCanBeProcessed)
                {
                    //getPalletList();
                    this.ProcessImport();

                }
                else
                    MessageBox.Show("No se puede procesar el archivo debido a que no se realizó la prueba de revisión del mismo. Pueden existir varios conflictos: \r\n-Códigos de Pallets duplicados.\r\n-Código de Bobinas duplicados.\r\n-No existe el producto en el sistema.", "Registro de pallets importados", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha surgido un error en el proceso de importación de pallets, verifique que la información esta validada. " + ex.Message, "Registro de pallets importados", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void ProcessImport()
        {
            string treatmentSide = "";
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (dgv.Rows[i].Cells[tipo.Index].Value.ToString() == "P")
                {
                    string oppProductCode = dgv.Rows[i].Cells[producto.Index].Value.ToString();
                    string diameterCore = dgv.Rows[i].Cells[diametro.Index].Value.ToString();
                    string width = dgv.Rows[i].Cells[ancho.Index].Value.ToString();

                    string productCode = oppProductCode;
                    
                    clsProduct objProduct = new clsProduct();
                    objProduct.load(productCode);

                    lstPallet.Add(new clsPallet());

                    lstPallet[lstPallet.Count - 1].fkProduct = objProduct.codsec;
                    lstPallet[lstPallet.Count - 1].fkStatus = 38;
                    lstPallet[lstPallet.Count - 1].palletNumber = 1;
                    lstPallet[lstPallet.Count - 1].code = dgv.Rows[i].Cells[pallet.Index].Value.ToString();
                    lstPallet[lstPallet.Count - 1].netWeight = Math.Round(Convert.ToDouble(dgv.Rows[i].Cells[netoPallet.Index].Value), 2);
                    lstPallet[lstPallet.Count - 1].grossWeight = Math.Round(Convert.ToDouble(dgv.Rows[i].Cells[brutoPallet.Index].Value), 2);
                    lstPallet[lstPallet.Count - 1].isPrinted = false;
                    lstPallet[lstPallet.Count - 1].createdBy = clsGlobal.LoggedUser.codsec;
                    lstPallet[lstPallet.Count - 1].modifiedBy = clsGlobal.LoggedUser.codsec;

                }
                else
                {
                    if (dgv.Rows[i].Cells[tipo.Index].Value.ToString() == "C")
                    {
                        string oppProductCode = dgv.Rows[i].Cells[producto.Index].Value.ToString();
                        string diameterCore = dgv.Rows[i].Cells[diametro.Index].Value.ToString();
                        string width = dgv.Rows[i].Cells[ancho.Index].Value.ToString();

                        string productCode = oppProductCode;

                        clsProduct objProduct = new clsProduct();
                        objProduct.load(productCode);

                        lstPallet[lstPallet.Count - 1].lstCoil.Add(new clsCoil());
                        int lstPos = lstPallet[lstPallet.Count - 1].lstCoil.Count - 1;

                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].fkCuttingQuality = 3;
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].fkBalance = 1012;
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].fkProduct = objProduct.codsec;
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].fkStatus = 33;
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].code = dgv.Rows[i].Cells[bobina.Index].Value.ToString();
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].length = Convert.ToDouble(dgv.Rows[i].Cells[largo.Index].Value.ToString());
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].width = Convert.ToDouble(dgv.Rows[i].Cells[ancho.Index].Value.ToString());
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].diameter = Convert.ToDouble(dgv.Rows[i].Cells[diam.Index].Value.ToString());
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].cuttingPosition = 1;
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].cuttingStop = 1;
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].netWeight = Math.Round(Convert.ToDouble(dgv.Rows[i].Cells[netoBobina.Index].Value.ToString()), 2);
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].density = clsCoil.getCoilDensity(lstPallet[lstPallet.Count - 1].lstCoil[lstPos].netWeight, lstPallet[lstPallet.Count - 1].lstCoil[lstPos].diameter, new clsCore(objProduct.fkCore), objProduct.width);
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].grossWeight = lstPallet[lstPallet.Count - 1].lstCoil[lstPos].netWeight + (objProduct.width * (new clsCore(objProduct.fkCore).weigthPerMilimeter));
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].treatmentSide = treatmentSide;
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].defects = "0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0";
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].notes = "";
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].createdBy = clsGlobal.LoggedUser.codsec;
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].modifiedBy = clsGlobal.LoggedUser.codsec;
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].isExternalCoil = true;
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].lotNumber = dgv.Rows[i].Cells[lote.Index].Value.ToString();
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].mainCoilCode = dgv.Rows[i].Cells[bobinaMadre.Index].Value.ToString();
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].extrusionDate = DateTime.Parse(dgv.Rows[i].Cells[fecha.Index].Value.ToString());
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].procedence = 253;
                    }
                    

                }
            }

            clsCoilCellar objCoilCellar = clsCoilCellar.getCellarByName("Ingreso Importación");

            clsPalletType objPalletType = clsPalletType.getPalletTypeByCoilNumberFloorsOrientation(lstPallet[0].lstCoil.Count, Convert.ToInt32(Math.Ceiling((decimal)(lstPallet[0].lstCoil.Count / 2))), "Horizontal");


            for (int i = 0; i < lstPallet.Count; i++)
            {
                if (lstPallet[i].salesOrderNumber == "")
                {
                    
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
                    
                    lstPallet[i].fkPalletType = objPalletType.codsec;
                    lstPallet[i].fkPalletDimention = 1091;

                    lstPallet[i].save(lstPallet[i].salesOrderNumber);

                    for (int j = 0; j < lstPallet[i].lstCoil.Count; j++)
                    {
                        lstPallet[i].lstCoil[j].save(lstPallet[i].salesOrderNumber, objCoilCellar.codsec);

                        lstPallet[i].addCoilToPallet(lstPallet[i].lstCoil[j].codsec);
                    }

                    lstPallet[i] = new clsPallet(lstPallet[i].codsec);
                    lstPallet[i].fkCoilCellar = objCoilCellar.codsec;
                    clsPallet.transferTo(DateTime.Now, lstPallet[i].code, lstPallet[i].codsec, lstPallet[i].fkCoilCellar, lstPallet[i].product.code, lstPallet[i].palletNumber, lstPallet[i].customerName, lstPallet[i].salesOrderNumber, Convert.ToInt32(lstPallet[i].product.width), Math.Round(lstPallet[i].netWeight, 1), "Ingreso a bodega de producto terminado", true, 1);
                }
            }

            dgv.Rows.Clear();
            flgCanBeProcessed = false;
            txtListo.Text = "Falso";
            txtListo.BackColor = Color.Red;
            MessageBox.Show("Se ha realizado la importación de los pallets con éxito.", "Registro de pallets importados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        }

    }
}
