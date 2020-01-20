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
    public partial class frmExportPalletShipping : Form
    {
        public frmExportPalletShipping()
        {
            InitializeComponent();
        }

        private void frmPalletMovement_Load(object sender, EventArgs e)
        {
            
        }
        

        private void FillDataGrid()
        {
            List<clsPalletbyCoilCellar> lstPallet = new List<clsPalletbyCoilCellar>();
            lstPallet = clsPalletbyCoilCellar.getListMovementByDateShipping(dtpInitDate.Value, dtpEndDate.Value);
            //lstPallet = clsPalletbyCoilCellar.getListMovementByDateNoShipping(dtpInitDate.Value, dtpEndDate.Value);
            if (lstPallet.Count > 0)
            {
                dgvPalletCellar.Rows.Clear();
                for (int i = 0; i < lstPallet.Count; i++)
                {
                    dgvPalletCellar.Rows.Add();

                    dgvPalletCellar.Rows[i].Cells[clmMovementCodsec.Index].Value = lstPallet[i].codsec;
                    dgvPalletCellar.Rows[i].Cells[clmMovementPalletCodsec.Index].Value = lstPallet[i].fkpallet;
                    dgvPalletCellar.Rows[i].Cells[clmmovementcellar.Index].Value = lstPallet[i].movement;
                    dgvPalletCellar.Rows[i].Cells[clmmovementdate.Index].Value = lstPallet[i].date.ToString("dd/MM/yyyy HH:mm:ss");
                    dgvPalletCellar.Rows[i].Cells[clmmovementcodepallet.Index].Value = lstPallet[i].code;
                    dgvPalletCellar.Rows[i].Cells[clmmovementproduct.Index].Value = lstPallet[i].producto;
                    dgvPalletCellar.Rows[i].Cells[clmmovementpalletcomposition.Index].Value = lstPallet[i].palletnumber + " - " + lstPallet[i].coilnumber;
                    dgvPalletCellar.Rows[i].Cells[clmmovementcustomer.Index].Value = lstPallet[i].customer;
                    dgvPalletCellar.Rows[i].Cells[clmmovementorder.Index].Value = lstPallet[i].order;
                    dgvPalletCellar.Rows[i].Cells[clmmovementwith.Index].Value = lstPallet[i].width;
                    dgvPalletCellar.Rows[i].Cells[clmmovementweigth.Index].Value = lstPallet[i].netweigth;
                    if (lstPallet[i].wasExportedToSystem == true)
                        dgvPalletCellar.Rows[i].Cells[clmMovementIsExported.Index].Value = global::BPS.Properties.Resources.bullet_green;
                    else
                        dgvPalletCellar.Rows[i].Cells[clmMovementIsExported.Index].Value = global::BPS.Properties.Resources.bullet_red;
                    dgvPalletCellar.Rows[i].Cells[clmMovementToExport.Index].Value = global::BPS.Properties.Resources.clear;
                    dgvPalletCellar.Rows[i].Cells[clmMovementFlgToExport.Index].Value = "0";
                    dgvPalletCellar.Rows[i].Cells[clmMovementValidated.Index].Value = 0;
                    dgvPalletCellar.Rows[i].Cells[clmMovementLocalWeight.Index].Value = lstPallet[i].localweigth;
                    dgvPalletCellar.Rows[i].Cells[clmMovementExternalWeight.Index].Value = lstPallet[i].oppweigth;
                }
            }
            else
            {
                dgvPalletCellar.Rows.Clear();
                MessageBox.Show("No existen coincidencias con ese pallet por favor ingrese uno pallet válido", "Trazabilidad Pallet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
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

                        if (clsXportCellarMovementsToSIIGO.exportCellarShippingsToSiigo(lstPalletMovement, folderPath, 1))
                        {
                            MessageBox.Show("Se han generado los archivos para la exportación de las ordenes de venta al SIIGO con éxito.", "Exportación de ordenes a SIIGO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                            FillDataGrid();
                        }
                        else
                        {
                            MessageBox.Show("Ha habido un problema al generar los archivos de exportación, por favor comuníquese con el administrador.", "Exportación de ordenes a SIIGO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Hay películas que no han sido validadas por no tener su correspondiente código de siigo, revise estos códigos para continuar.", "Exportación de ordenes a SIIGO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna orden de venta para ser exportada.", "Exportación de ordenes a SIIGO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
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
                    List<int> lstPos = new List<int>();

                    for (int i = dgvPalletCellar.Rows.Count -1; i > 0; i--)
                    {
                        if (dgvPalletCellar.Rows[i].Cells[clmMovementFlgToExport.Index].Value.ToString() == "0")
                            lstPos.Add(i);
                    }

                    for (int i = 0; i < lstPos.Count; i++)
                        dgvPalletCellar.Rows.RemoveAt(lstPos[i]);

                    dgvPalletCellar.Sort(clmmovementorder, ListSortDirection.Ascending);

                    
                }

            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna orden de venta para ser exportada.", "Exportación de ordenes a SIIGO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
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
            if (e.ColumnIndex == clmmovementproduct.Index)
            {
                frmXtraFilmEquivalence winXtraFilmEquivalence = new frmXtraFilmEquivalence(dgvPalletCellar.Rows[e.RowIndex].Cells[clmmovementproduct.Index].Value.ToString());
                winXtraFilmEquivalence.ShowDialog();
            }
        }
    }
}
