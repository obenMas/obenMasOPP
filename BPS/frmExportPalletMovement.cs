using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms; 
using BPS.Bussiness;

namespace BPS
{
    public partial class frmExportPalletMovement : Form
    {
        internal class stccellar
        {
            public string cellar { get; set; }
            public double weigth { get; set; }
        }


        public frmExportPalletMovement()
        {
            InitializeComponent();
        }

        private void frmPalletMovement_Load(object sender, EventArgs e)
        {
            
        }
        

        private void FillDataGrid()
        {
            lblnumber.Text = string.Empty;
            string movement  = string.Empty;
            List<clsPalletbyCoilCellar> lstPallet = new List<clsPalletbyCoilCellar>();
            List<clsPalletbyCoilCellar> lstPalletAux = new List<clsPalletbyCoilCellar>();
            List<stccellar> lstStuctCellar = new List<stccellar>();
            lstPallet = clsPalletbyCoilCellar.getListMovementByDateNoShipping(dtpInitDate.Value, dtpEndDate.Value);
            if (lstPallet.Count > 0)
            {
                if (cmbMovements.Text != String.Empty)
                {
                    if (cmbMovements.Text.ToString() == "Ingreso Producto Terminado")
                        movement = "Ingreso a bodega de producto terminado";
                    else if (cmbMovements.Text.ToString() == "Ingreso Stock local")
                        movement = "Ingreso a bodega de stock local";
                    else if (cmbMovements.Text.ToString() == "Salida Proceso")
                        movement = "Salida a bodega de proceso";

                    dgvPalletCellar.Rows.Clear();
                    for (int i = 0; i < lstPallet.Count; i++)
                    {
                        if (lstPallet[i].movement == movement)
                        {
                            dgvPalletCellar.Rows.Add();
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmnumber.Index].Value = (dgvPalletCellar.Rows.Count - 1 == 0 ? 1 : dgvPalletCellar.Rows.Count - 1 + 1);
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmMovementCodsec.Index].Value = lstPallet[i].codsec;
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmMovementPalletCodsec.Index].Value = lstPallet[i].fkpallet;
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmmovementcellar.Index].Value = lstPallet[i].movement;
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmmovementdate.Index].Value = lstPallet[i].date.ToString("dd/MM/yyyy HH:mm:ss");
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmmovementcodepallet.Index].Value = lstPallet[i].code;
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmmovementproduct.Index].Value = lstPallet[i].producto;
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmmovementpalletcomposition.Index].Value = lstPallet[i].palletnumber + " - " + lstPallet[i].coilnumber;
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmmovementcustomer.Index].Value = lstPallet[i].customer;
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmmovementorder.Index].Value = lstPallet[i].order;
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmmovementwith.Index].Value = lstPallet[i].width;
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmmovementweigth.Index].Value = lstPallet[i].netweigth;
                            if (lstPallet[i].wasExportedToSystem == true)
                                dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmMovementIsExported.Index].Value = global::BPS.Properties.Resources.bullet_green;
                            else
                                dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmMovementIsExported.Index].Value = global::BPS.Properties.Resources.bullet_red;
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmMovementToExport.Index].Value = global::BPS.Properties.Resources.clear;
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmMovementFlgToExport.Index].Value = "0";
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmMovementValidated.Index].Value = 0;
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmMovementLocalWeight.Index].Value = lstPallet[i].localweigth;
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmMovementExternalWeight.Index].Value = lstPallet[i].oppweigth;
                            lstPalletAux.Add(lstPallet[i]);
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmsiigocellar.Index].Value = clsXportCellarMovementsToSIIGO.exportCellar(lstPalletAux).Replace("0","");
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmsiigomovement.Index].Value = clsXportCellarMovementsToSIIGO.movementCellar(lstPalletAux);
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmsiigocode.Index].Value = clsXportCellarMovementsToSIIGO.codeCellar(lstPalletAux);
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmref.Index].Value = clsXportCellarMovementsToSIIGO.ReferenceCellar(dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmsiigocode.Index].Value.ToString());
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmorigin.Index].Value = lstPallet[i].origin;
                            lstStuctCellar.Add(new stccellar());
                            lstStuctCellar[lstStuctCellar.Count - 1].cellar = dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmsiigocellar.Index].Value.ToString();
                            lstStuctCellar[lstStuctCellar.Count - 1].weigth = Convert.ToDouble(dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmmovementweigth.Index].Value);
                            lstPalletAux.Clear();
                            //lstWeigth.Add(lstPallet[i].netweigth);
                        }
                    }
                    SummaryWeigth(lstStuctCellar, movement);
                }
            }
            else
            {
                dgvPalletCellar.Rows.Clear();
                MessageBox.Show("No existen movimientos en esa fecha", "Trazabilidad Pallet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SummaryWeigth(List<stccellar> lstStructCellar, string movement)
        {
            double Tcellar3 = 0;
            double Tcellar18 = 0;
            double Tcellar23 = 0;
            string Cellar3 = "3";
            string Cellar18 = "18";
            string Cellar23 = "23";


            if (movement == "Ingreso a bodega de producto terminado")
            {
                for (int i = 0; i < lstStructCellar.Count; i++)
                {
                    if (lstStructCellar[i].cellar == Cellar3)
                        Tcellar3 += lstStructCellar[i].weigth;
                    else
                        Tcellar18 += lstStructCellar[i].weigth;
                }
                lblTCellar3.Text = Math.Round(Tcellar3, 1).ToString();
                lblTCellar18.Text = Math.Round(Tcellar18, 1).ToString();
                lblTCellar23.Text = Math.Round(Tcellar23, 1).ToString();
            }
            else if (movement == "Ingreso a bodega de stock local")
            {
                for (int i = 0; i < lstStructCellar.Count; i++)
                {
                    if (lstStructCellar[i].cellar == Cellar18)
                        Tcellar18 += lstStructCellar[i].weigth;
                    else
                        Tcellar23 += lstStructCellar[i].weigth;
                }
                lblTCellar3.Text = Math.Round(Tcellar3, 1).ToString();
                lblTCellar18.Text = Math.Round(Tcellar18, 1).ToString();
                lblTCellar23.Text = Math.Round(Tcellar23, 1).ToString();
            }
            else if (movement == "Salida a bodega de proceso")
            {
                for (int i = 0; i < lstStructCellar.Count; i++)
                {
                    if (lstStructCellar[i].cellar == Cellar23)
                        Tcellar23 += lstStructCellar[i].weigth;
                    else if (lstStructCellar[i].cellar == Cellar18)
                        Tcellar18 += lstStructCellar[i].weigth;
                    else
                        Tcellar3 += lstStructCellar[i].weigth;
                }
                lblTCellar3.Text = Math.Round(Tcellar3, 1).ToString();
                lblTCellar18.Text = Math.Round(Tcellar18, 1).ToString();
                lblTCellar23.Text = Math.Round(Tcellar23, 1).ToString();
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            bool hasSelectedRows = false;
            List<clsPalletbyCoilCellar> lstPalletMovement = new List<clsPalletbyCoilCellar>();

            for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
            {
                if (dgvPalletCellar.Rows[i].Cells[clmMovementFlgToExport.Index].Value.ToString() == "1")
                    hasSelectedRows = true;
            }
            if (hasSelectedRows == true)
            {
                bool hasInvalidRows = true;
                for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
                {
                    if (dgvPalletCellar.Rows[i].Cells[clmMovementValidated.Index].Value.ToString() == "0")
                        hasInvalidRows = false;
                }
                if (hasInvalidRows == true)
                {

                    if (MessageBox.Show("Se realizará el proceso de creación de los archivos de exportación a SIIGO de los movimientos seleccionados.\n\n Desea continuar?", "Exportación de movimientos a SIIGO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                    {
                        string folderPath = "";
                        fbdFilePath.Description = "Por favor, seleccione la ubicación donde se guardarán los archivos de exportación.";
                        fbdFilePath.ShowDialog();

                        folderPath = fbdFilePath.SelectedPath;
                        lstPalletMovement = new List<clsPalletbyCoilCellar>();

                        for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
                        {
                            if (dgvPalletCellar.Rows[i].Cells[clmMovementFlgToExport.Index].Value.ToString() == "1")
                                lstPalletMovement.Add(new clsPalletbyCoilCellar(Convert.ToInt32(dgvPalletCellar.Rows[i].Cells[clmMovementCodsec.Index].Value)));
                        }

                        if (clsXportCellarMovementsToSIIGO.exportCellarMovementsToSiigo(lstPalletMovement, folderPath, 1,false,DateTime.Now))
                        {
                            MessageBox.Show("Se han generado los archivos para la exportación de las ordenes de venta al SIIGO con éxito.", "Exportación de ordenes a SIIGO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                            FillDataGrid();
                        }
                        else
                            MessageBox.Show("Ha habido un problema al generar los archivos de exportación, por favor comuníquese con el administrador.", "Exportación de ordenes a SIIGO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }
                }
                else
                    MessageBox.Show("Hay películas que no han sido validadas por no tener su correspondiente código de siigo, revise estos códigos para continuar.", "Exportación de ordenes a SIIGO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            else
                MessageBox.Show("No ha seleccionado ninguna orden de venta para ser exportada.", "Exportación de ordenes a SIIGO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPalletCellar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmMovementToExport.Index)
            {
                if (dgvPalletCellar.Rows[e.RowIndex].Cells[clmMovementFlgToExport.Index].Value.ToString() != "0")
                {
                    dgvPalletCellar.Rows[e.RowIndex].Cells[clmMovementToExport.Index].Value = global::BPS.Properties.Resources.clear;
                    dgvPalletCellar.Rows[e.RowIndex].Cells[clmMovementFlgToExport.Index].Value = 0;
                }
                else
                {
                    dgvPalletCellar.Rows[e.RowIndex].Cells[clmMovementToExport.Index].Value = global::BPS.Properties.Resources.accept;
                    dgvPalletCellar.Rows[e.RowIndex].Cells[clmMovementFlgToExport.Index].Value = 1;
                }
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

            bool hasSelectedRows = false;
            List<clsPalletbyCoilCellar> lstPalletMovement = new List<clsPalletbyCoilCellar>();

            for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
            {
                if (dgvPalletCellar.Rows[i].Cells[clmMovementFlgToExport.Index].Value.ToString() == "1")
                    hasSelectedRows = true;
            }
            if (hasSelectedRows == true)
            {
                if (MessageBox.Show("Los registros no seleccionados serán eliminados del listado para no ser tomados en cuenta en la exportación. Desea continuar?", "Exportación de movimientos a SIIGO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
                    var count=0;
                    List<int> lstPos = new List<int>();

                    for (int i = dgvPalletCellar.Rows.Count -1; i >= 0; i--)
                    {
                        if (dgvPalletCellar.Rows[i].Cells[clmMovementFlgToExport.Index].Value.ToString() == "0")
                            lstPos.Add(i);
                        else
                        {
                            count++;
                            lblnumber.Text = count.ToString();
                        }
                    }

                    for (int i = 0; i < lstPos.Count; i++)
                        dgvPalletCellar.Rows.RemoveAt(lstPos[i]);

                    dgvPalletCellar.Sort(clmmovementcellar, ListSortDirection.Ascending);
                }

            }
            else
                MessageBox.Show("No ha seleccionado ninguna orden de venta para ser exportada.", "Exportación de ordenes a SIIGO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
            {
                clsProduct objProduct = new clsProduct(dgvPalletCellar.Rows[i].Cells[clmmovementproduct.Index].Value.ToString());
                objProduct = new clsProduct(objProduct.codsec);
                bool flgIsValidated = true;

                if (objProduct.Bopp.codsec != 0)
                {
                    if (Convert.ToDouble(dgvPalletCellar.Rows[i].Cells[clmMovementLocalWeight.Index].Value) > 0 && Convert.ToDouble(dgvPalletCellar.Rows[i].Cells[clmMovementExternalWeight.Index].Value) == 0)
                    {
                        if (dgvPalletCellar.Rows[i].Cells[clmmovementcustomer.Index].Value.ToString() == "STOCK")
                        { 
                            if (clsProduct.getExternalERPDescriptionStockCode(objProduct) == "")
                                flgIsValidated = false;
                        }
                        else
                        {
                            if (clsProduct.getExternalERPDescriptionNationalCode(objProduct) == "")
                                flgIsValidated = false;
                        }
                    }
                    else if (Convert.ToDouble(dgvPalletCellar.Rows[i].Cells[clmMovementLocalWeight.Index].Value) == 0 && Convert.ToDouble(dgvPalletCellar.Rows[i].Cells[clmMovementExternalWeight.Index].Value) > 0)
                    {
                        if (clsProduct.getExternalERPDescriptionExternalCode(objProduct) == "")
                            flgIsValidated = false;
                    }
                    else if (Convert.ToDouble(dgvPalletCellar.Rows[i].Cells[clmMovementLocalWeight.Index].Value) > 0 && Convert.ToDouble(dgvPalletCellar.Rows[i].Cells[clmMovementExternalWeight.Index].Value) > 0)
                    {
                        if (clsProduct.getExternalERPDescriptionExternalCode(objProduct) == "" || clsProduct.getExternalERPDescriptionNationalCode(objProduct) == "")
                            flgIsValidated = false;
                    }
                }

                if (objProduct.Cast.codsec != 0)
                {
                    if (clsProduct.getExternalERPDescriptionExternalCode(objProduct) == "") 
                        flgIsValidated = false;
                }

                if (flgIsValidated == true)
                {
                    dgvPalletCellar.Rows[i].Cells[clmmovementproduct.Index].Style.ForeColor = Color.Black;
                    dgvPalletCellar.Rows[i].Cells[clmmovementproduct.Index].Style.SelectionForeColor = Color.Black;
                    dgvPalletCellar.Rows[i].Cells[clmMovementValidated.Index].Value = 1;
                }
                else
                {
                    dgvPalletCellar.Rows[i].Cells[clmmovementproduct.Index].Style.ForeColor = Color.Red;
                    dgvPalletCellar.Rows[i].Cells[clmmovementproduct.Index].Style.SelectionForeColor = Color.Red;
                    dgvPalletCellar.Rows[i].Cells[clmMovementValidated.Index].Value = 0;
                }
            }
        }

        private void dgvPalletCellar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmsiigocode.Index)
            {
                frmXtraFilmEquivalence winXtraFilmEquivalence = new frmXtraFilmEquivalence(dgvPalletCellar.Rows[e.RowIndex].Cells[clmmovementproduct.Index].Value.ToString());
                winXtraFilmEquivalence.ShowDialog();
            }
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelectAll.Checked == true)
            {
                for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
                {
                    dgvPalletCellar.Rows[i].Cells[clmMovementToExport.Index].Value = global::BPS.Properties.Resources.accept;
                    dgvPalletCellar.Rows[i].Cells[clmMovementFlgToExport.Index].Value = 1;
                    dgvPalletCellar.FirstDisplayedScrollingRowIndex = i;
                }
            }
            else
            {

            }
        }
    }
}
