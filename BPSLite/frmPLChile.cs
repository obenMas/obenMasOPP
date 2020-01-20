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
    public partial class frmPLChile : Form
    {
        bool flgCanBeProcessed = false;
        List<clsPallet> lstPallet = new List<clsPallet>();

        public frmPLChile()
        {
            InitializeComponent();
        }

        private void btnObtenerPL_Click(object sender, EventArgs e)
        {
            DataTable table = clsConnectionAccess.getPLChile();
            string diam = "N";
            string core = "6";
            dgv.Rows.Clear();

            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    dgv.Rows.Add();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[PedidoN.Index].Value = table.Rows[i][0].ToString();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[Posicion.Index].Value = table.Rows[i][1].ToString();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[Pallet.Index].Value = table.Rows[i][2].ToString();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[Bobina.Index].Value = table.Rows[i][3].ToString();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[PesoNetoBobina.Index].Value = Convert.ToDouble(table.Rows[i][4]);
                    dgv.Rows[dgv.Rows.Count - 1].Cells[Unidad.Index].Value = table.Rows[i][5].ToString();
                    int prue = Convert.ToInt32(table.Rows[i][6].ToString().Replace("m", "").Replace(" ", ""));
                    if (prue != 570 && prue != 550)
                    {
                        if (prue == 770)
                        {
                            diam = "J";
                        }
                        else
                        {
                            diam = "";
                        }
                    }
                    dgv.Rows[dgv.Rows.Count - 1].Cells[Diametro.Index].Value = prue;
                    prue = Convert.ToInt32(table.Rows[i][7].ToString().Replace(" ", "").Replace("PLG", ""));
                    if (prue != 6)
                    {
                        if (prue == 3)
                        {
                            core = "3";
                        }
                        else
                        {
                            core = "";
                        }
                    }
                    dgv.Rows[dgv.Rows.Count - 1].Cells[DiametroE.Index].Value = prue;
                    dgv.Rows[dgv.Rows.Count - 1].Cells[Grosor.Index].Value = table.Rows[i][8].ToString();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[Ancho.Index].Value = table.Rows[i][9].ToString().Replace(" ", "").Replace("m", "").Replace(".","");
                    dgv.Rows[dgv.Rows.Count - 1].Cells[Largo.Index].Value = table.Rows[i][10].ToString().Replace(".", "").Replace("m", "").Replace(".", "");
                    dgv.Rows[dgv.Rows.Count - 1].Cells[Material.Index].Value = table.Rows[i][11].ToString();
                    switch (table.Rows[i][11].ToString())
                    {
                        case "NH 17 TT":
                            dgv.Rows[dgv.Rows.Count - 1].Cells[codOben.Index].Value = "NH017TTx" + table.Rows[i][9].ToString().Replace(" ", "").Replace("m", "").Replace(".", "") + diam + core;
                            break;
                        case "NH 20 TT":
                            dgv.Rows[dgv.Rows.Count - 1].Cells[codOben.Index].Value = "NH020TTx" + table.Rows[i][9].ToString().Replace(" ", "").Replace("m", "").Replace(".", "") + diam + core;
                            break;
                        case "VC 25":
                            dgv.Rows[dgv.Rows.Count - 1].Cells[codOben.Index].Value = "VC025x" + table.Rows[i][9].ToString().Replace(" ", "").Replace("m", "").Replace(".", "") + diam + core;
                            break;
                        case "VC 30":
                            dgv.Rows[dgv.Rows.Count - 1].Cells[codOben.Index].Value = "VC030x" + table.Rows[i][9].ToString().Replace(" ", "").Replace("m", "").Replace(".", "") + diam + core;
                            break;
                        case "VC 35":
                            dgv.Rows[dgv.Rows.Count - 1].Cells[codOben.Index].Value = "VC035x" + table.Rows[i][9].ToString().Replace(" ", "").Replace("m", "").Replace(".", "") + diam + core;
                            break;
                        case "VC 40":
                            dgv.Rows[dgv.Rows.Count - 1].Cells[codOben.Index].Value = "VC040x" + table.Rows[i][9].ToString().Replace(" ", "").Replace("m", "").Replace(".", "") + diam + core;
                            break;
                        case "AT 15 TT":
                            dgv.Rows[dgv.Rows.Count - 1].Cells[codOben.Index].Value = "AT015TTx" + table.Rows[i][9].ToString().Replace(" ", "").Replace("m", "").Replace(".", "") + diam + core;
                            break;
                        case "AT 15":
                            dgv.Rows[dgv.Rows.Count - 1].Cells[codOben.Index].Value = "AT015x" + table.Rows[i][9].ToString().Replace(" ", "").Replace("m", "").Replace(".", "") + diam + core;
                            break;
                        case "AT 12":
                            dgv.Rows[dgv.Rows.Count - 1].Cells[codOben.Index].Value = "AT012x" + table.Rows[i][9].ToString().Replace(" ", "").Replace("m", "").Replace(".", "") + diam + core;
                            break;
                        case "WC 20":
                            dgv.Rows[dgv.Rows.Count - 1].Cells[codOben.Index].Value = "WC020x" + table.Rows[i][9].ToString().Replace(" ", "").Replace("m", "").Replace(".", "") + diam + core;
                            break;
                        case "WC 25":
                            dgv.Rows[dgv.Rows.Count - 1].Cells[codOben.Index].Value = "WC025x" + table.Rows[i][9].ToString().Replace(" ", "").Replace("m", "").Replace(".", "") + diam + core;
                            break;
                        case "NL 20":
                            dgv.Rows[dgv.Rows.Count - 1].Cells[codOben.Index].Value = "NL020x" + table.Rows[i][9].ToString().Replace(" ", "").Replace("m", "").Replace(".", "") + diam + core;
                            break;
                        case "NL 17":
                            dgv.Rows[dgv.Rows.Count - 1].Cells[codOben.Index].Value = "NL017x" + table.Rows[i][9].ToString().Replace(" ", "").Replace("m", "").Replace(".", "") + diam + core;
                            break;
                        case "BD 17":
                            dgv.Rows[dgv.Rows.Count - 1].Cells[codOben.Index].Value = "BD017x" + table.Rows[i][9].ToString().Replace(" ", "").Replace("m", "").Replace(".", "") + diam + core;
                            break;
                        case "SC 30 TT":
                            dgv.Rows[dgv.Rows.Count - 1].Cells[codOben.Index].Value = "SC030TTx" + table.Rows[i][9].ToString().Replace(" ", "").Replace("m", "").Replace(".", "") + diam + core;
                            break;
                        default:
                            dgv.Rows[dgv.Rows.Count - 1].Cells[codOben.Index].Value = "ERROR";
                            break;
                    }
                    dgv.Rows[dgv.Rows.Count - 1].Cells[Descripcion.Index].Value = table.Rows[i][12].ToString();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[Entrega.Index].Value = table.Rows[i][13].ToString();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[PesoNetoBobinaLB.Index].Value = Convert.ToDouble(table.Rows[i][4]);
                    dgv.Rows[dgv.Rows.Count - 1].Cells[PesoPalletNeto.Index].Value = Convert.ToDouble(table.Rows[i][15]);
                    dgv.Rows[dgv.Rows.Count - 1].Cells[PesoPalletBruto.Index].Value = Convert.ToDouble(table.Rows[i][16]);
                    dgv.Rows[dgv.Rows.Count - 1].Cells[PesoPalletNetoLB.Index].Value = Convert.ToDouble(table.Rows[i][17]);
                    dgv.Rows[dgv.Rows.Count - 1].Cells[PesoBrutoPalletLB.Index].Value = Convert.ToDouble(table.Rows[i][18]);
                    if (new clsProduct(dgv.Rows[dgv.Rows.Count - 1].Cells[codOben.Index].Value.ToString()).codsec != 0)
                    {
                        dgv.Rows[dgv.Rows.Count - 1].Cells[done.Index].Value = "Si";
                        dgv.Rows[dgv.Rows.Count - 1].Cells[done.Index].Style.BackColor = Color.Green;
                    }
                    else
                    {
                        dgv.Rows[dgv.Rows.Count - 1].Cells[done.Index].Value = "No";
                        dgv.Rows[dgv.Rows.Count - 1].Cells[done.Index].Style.BackColor = Color.Red;
                    }
                }
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (flgCanBeProcessed)
            {
                string treatmentSide = "";
                List<string> lista = new List<string>();

                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    string productCode = dgv.Rows[i].Cells[codOben.Index].Value.ToString();

                    clsProduct objProduct = new clsProduct();
                    objProduct.load(productCode);

                    

                    if (!lista.Contains(dgv.Rows[i].Cells[Pallet.Index].Value.ToString()))
                    {
                        lista.Add(dgv.Rows[i].Cells[Pallet.Index].Value.ToString());
                        lstPallet.Add(new clsPallet());

                        lstPallet[lstPallet.Count - 1].fkProduct = objProduct.codsec;
                        lstPallet[lstPallet.Count - 1].fkStatus = 38;
                        lstPallet[lstPallet.Count - 1].palletNumber = 1;
                        lstPallet[lstPallet.Count - 1].code = dgv.Rows[i].Cells[Pallet.Index].Value.ToString();
                        lstPallet[lstPallet.Count - 1].netWeight = Math.Round(Convert.ToDouble(dgv.Rows[i].Cells[PesoPalletNeto.Index].Value), 2);
                        lstPallet[lstPallet.Count - 1].grossWeight = Math.Round(Convert.ToDouble(dgv.Rows[i].Cells[PesoPalletBruto.Index].Value), 2);
                        lstPallet[lstPallet.Count - 1].isPrinted = false;
                        lstPallet[lstPallet.Count - 1].createdBy = clsGlobal.LoggedUser.codsec;
                        lstPallet[lstPallet.Count - 1].modifiedBy = clsGlobal.LoggedUser.codsec;

                        lstPallet[lstPallet.Count - 1].lstCoil.Add(new clsCoil());
                        int lstPos = lstPallet[lstPallet.Count - 1].lstCoil.Count - 1;

                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].fkCuttingQuality = 3;
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].fkBalance = 1012;
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].fkProduct = objProduct.codsec;
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].fkStatus = 33;
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].code = dgv.Rows[i].Cells[Bobina.Index].Value.ToString();
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].length = Convert.ToDouble(dgv.Rows[i].Cells[Largo.Index].Value.ToString());
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].width = Convert.ToDouble(dgv.Rows[i].Cells[Ancho.Index].Value.ToString());
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].diameter = Convert.ToDouble(dgv.Rows[i].Cells[Diametro.Index].Value.ToString());
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].cuttingPosition = 1;
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].cuttingStop = 1;
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].netWeight = Math.Round(Convert.ToDouble(dgv.Rows[i].Cells[PesoNetoBobina.Index].Value.ToString()), 2);
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].density = clsCoil.getCoilDensity(lstPallet[lstPallet.Count - 1].lstCoil[lstPos].netWeight, lstPallet[lstPallet.Count - 1].lstCoil[lstPos].diameter, new clsCore(objProduct.fkCore), objProduct.width);
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].grossWeight = lstPallet[lstPallet.Count - 1].lstCoil[lstPos].netWeight + (objProduct.width * (new clsCore(objProduct.fkCore).weigthPerMilimeter));
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].treatmentSide = treatmentSide;
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].defects = "0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0";
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].notes = "";
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].createdBy = clsGlobal.LoggedUser.codsec;
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].modifiedBy = clsGlobal.LoggedUser.codsec;
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].isExternalCoil = true;
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].lotNumber = dgv.Rows[i].Cells[Entrega.Index].Value.ToString();
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].mainCoilCode = dgv.Rows[i].Cells[Entrega.Index].Value.ToString();
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].extrusionDate = DateTime.Now;
                    }
                    else
                    {
                        lstPallet[lstPallet.Count - 1].lstCoil.Add(new clsCoil());
                        int lstPos = lstPallet[lstPallet.Count - 1].lstCoil.Count - 1;

                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].fkCuttingQuality = 3;
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].fkBalance = 1012;
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].fkProduct = objProduct.codsec;
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].fkStatus = 33;
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].code = dgv.Rows[i].Cells[Bobina.Index].Value.ToString();
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].length = Convert.ToDouble(dgv.Rows[i].Cells[Largo.Index].Value.ToString());
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].width = Convert.ToDouble(dgv.Rows[i].Cells[Ancho.Index].Value.ToString());
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].diameter = Convert.ToDouble(dgv.Rows[i].Cells[Diametro.Index].Value.ToString());
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].cuttingPosition = 1;
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].cuttingStop = 1;
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].netWeight = Math.Round(Convert.ToDouble(dgv.Rows[i].Cells[PesoNetoBobina.Index].Value.ToString()), 2);
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].density = clsCoil.getCoilDensity(lstPallet[lstPallet.Count - 1].lstCoil[lstPos].netWeight, lstPallet[lstPallet.Count - 1].lstCoil[lstPos].diameter, new clsCore(objProduct.fkCore), objProduct.width);
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].grossWeight = lstPallet[lstPallet.Count - 1].lstCoil[lstPos].netWeight + (objProduct.width * (new clsCore(objProduct.fkCore).weigthPerMilimeter));
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].treatmentSide = treatmentSide;
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].defects = "0;0;0;0;0;0;0;0;0;0;0;0;0;0;0;0";
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].notes = "";
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].createdBy = clsGlobal.LoggedUser.codsec;
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].modifiedBy = clsGlobal.LoggedUser.codsec;
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].isExternalCoil = true;
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].lotNumber = dgv.Rows[i].Cells[Entrega.Index].Value.ToString();
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].mainCoilCode = dgv.Rows[i].Cells[Entrega.Index].Value.ToString();
                        lstPallet[lstPallet.Count - 1].lstCoil[lstPos].extrusionDate = DateTime.Now;
                    }

                }

                clsCoilCellar objCoilCellar = clsCoilCellar.getCellarByName("Ingreso Importación");

                clsPalletType objPalletType = clsPalletType.getPalletTypeByCoilNumberFloorsOrientation(lstPallet[0].lstCoil.Count, Convert.ToInt32(Math.Ceiling((decimal)(lstPallet[0].lstCoil.Count / 2))), "Horizontal");

                for (int i = 0; i < lstPallet.Count; i++)
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

                dgv.Rows.Clear();
                flgCanBeProcessed = false;
                txtListo.Text = "Falso";
                txtListo.BackColor = Color.Red;
                MessageBox.Show("Se ha realizado la importación de los pallets con éxito.", "Registro de pallets importados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);



            }
            else
                MessageBox.Show("No se puede procesar el archivo debido a que no se realizó la prueba de revisión del mismo. Pueden existir varios conflictos: \r\n-Códigos de Pallets duplicados.\r\n-Código de Bobinas duplicados.\r\n-No existe el producto en el sistema.", "Registro de pallets importados", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            flgCanBeProcessed = true;
            List<string> totpal = new List<string>();
            List<string> totbob = new List<string>();
            double totkil = 0;

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                string productCode = dgv.Rows[i].Cells[codOben.Index].Value.ToString();
                totkil += Convert.ToDouble(dgv.Rows[i].Cells[PesoNetoBobina.Index].Value);

                clsProduct objProduct = new clsProduct();
                objProduct.load(productCode);

                string palletCode = "";
                string coilCode = "";

                palletCode = dgv.Rows[i].Cells[Pallet.Index].Value.ToString();
                if (palletCode != "")
                {
                    if(!totpal.Contains(palletCode))
                    {
                        totpal.Add(palletCode);
                    }
                    if (clsPallet.getPalletValidate(palletCode))
                    {
                        dgv.Rows[i].Cells[Pallet.Index].Style.ForeColor = Color.Orange;
                        flgCanBeProcessed = false;
                    }
                    else
                        dgv.Rows[i].Cells[Pallet.Index].Style.ForeColor = Color.Black;
                }
                else
                    dgv.Rows[i].Cells[Pallet.Index].Style.ForeColor = Color.Black;

                coilCode = dgv.Rows[i].Cells[Bobina.Index].Value.ToString();
                if (coilCode != "")
                {
                    if (!totbob.Contains(coilCode))
                    {
                        totbob.Add(coilCode);
                    }
                    if (clsCoil.getCoilValidate(coilCode))
                    {
                        dgv.Rows[i].Cells[Bobina.Index].Style.ForeColor = Color.Purple;
                        flgCanBeProcessed = false;
                    }
                    else
                        dgv.Rows[i].Cells[Bobina.Index].Style.ForeColor = Color.Black;
                }
                else
                    dgv.Rows[i].Cells[Bobina.Index].Style.ForeColor = Color.Black;

                if (objProduct.codsec == 0)
                {
                    dgv.Rows[i].Cells[codOben.Index].Style.ForeColor = Color.Red;
                    flgCanBeProcessed = false;
                }
                else
                {
                    dgv.Rows[i].Cells[codOben.Index].Style.ForeColor = Color.Black;
                }
            }

            if (flgCanBeProcessed)
            {
                txtListo.Text = "Listo";
                txtListo.BackColor = Color.Green;
                //txtListo.ForeColor = Color.Black;
            }
            txtPallets.Text = totpal.Count.ToString();
            txtBobinas.Text = totbob.Count.ToString();
            txtKilos.Text = totkil.ToString();
            MessageBox.Show("Datos verificados. En caso de haber datos que no se puedan ingresar, se verán los códigos pintados de color.", "Verificación realizada", MessageBoxButtons.OK);
        }
    }
}
