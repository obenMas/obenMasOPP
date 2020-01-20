using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmExportMaquileMovement : Form
    {
        #region Parametros
        List<clsMaquile> lstMaquile = new List<clsMaquile>();
        bool executeFilter = true, isActiveCalendar = false;
        delegate void showLoading();
        delegate void HideLoading();
        showLoading showLoadImage;
        HideLoading hideLoadImage;

        string movementload = string.Empty;
        public DateTime dtpEndMonth = DateTime.Now;
        #endregion

        #region Inicio

        private void loadMovements()
        {
            this.Invoke(showLoadImage);
            lstMaquile = clsMaquile.getListMovementByDate(dtpInitDate.Value, dtpEndDate.Value, movementload);
            this.Invoke(hideLoadImage);
        }

        private void showLoadingDelegate()
        {
            groupBox4.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;

            groupBox4.Enabled = false;
            groupBox2.Enabled = true;
            groupBox3.Enabled = false;

            pbxLoading.Visible = true;
            pbxLoading.Enabled = true;
            lblLoading.Visible = true;
        }

        private void hideLoadingDelegate()
        {
            var demoThread = new Thread(new ThreadStart(this.fillPalletInfo));
            demoThread.Start();
            demoThread.Priority = ThreadPriority.Highest;

            List<string> lstProducts = new List<string>();
            List<string> lstCustomers = new List<string>();
            List<string> lstMovemenet = new List<string>();

            lstProducts = lstMaquile.Select(p => p.product.Replace("-", "")).Distinct().ToList();
            lstCustomers = lstMaquile.Select(p => p.customer).Distinct().ToList();
            lstMovemenet = lstMaquile.Select(p => p.movement).Distinct().ToList();

            lstProducts.Sort();
            lstCustomers.Sort();
            lstMovemenet.Sort();

            for (int i = 0; i < lstProducts.Count; i++)
                cmbProduct.Items.Add(lstProducts[i]);

            for (int i = 0; i < lstCustomers.Count; i++)
                cmbCustomer.Items.Add(lstCustomers[i]);

            for (int i = 0; i < lstMovemenet.Count; i++)
                cmbMovement.Items.Add(lstMovemenet[i]);

            colorateByOrigin();
            groupBox4.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;

            groupBox4.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;

            pbxLoading.Visible = false;
            lblLoading.Visible = false;
        }

        public void colorateByOrigin()
        {
            for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
            {
                if (dgvPalletCellar.Rows[i].Cells[clmobenorigin.Index].Value != null)
                {
                    switch (dgvPalletCellar.Rows[i].Cells[clmobenorigin.Index].Value.ToString())
                    {
                        case "BOPP":
                            if (dgvPalletCellar.Rows[i].Cells[clmobencustomer.Index].Value.ToString() == "STOCK")
                            {
                                for (int j = 0; j < dgvPalletCellar.Columns.Count; j++)
                                    dgvPalletCellar.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(207, 234, 254);
                            }
                            else
                            {
                                for (int j = 0; j < dgvPalletCellar.Columns.Count; j++)
                                    dgvPalletCellar.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(232, 202, 244);
                            }
                            break;
                        case "OPP":
                            for (int j = 0; j < dgvPalletCellar.Columns.Count; j++)
                                dgvPalletCellar.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(230, 95, 0);

                            break;
                        default:
                            break;
                    }
                }
            }
        }

        public frmExportMaquileMovement()
        {
            InitializeComponent();
            getPalletList();
        }

        private void getPalletList()
        {
            showLoadImage = new showLoading(showLoadingDelegate);
            hideLoadImage = new HideLoading(hideLoadingDelegate);
        }

        delegate void fillPalletInfoDelegate();

        private void frmExportMaquileMovement_Load(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            pbxLoading.Visible = false;
            lblLoading.Visible = false;
        }
        #endregion

        #region Fill Data

        private void fillPalletInfo()
        {
            if (this.InvokeRequired)
            {
                fillPalletInfoDelegate pop = new fillPalletInfoDelegate(fillPalletInfo);
                this.Invoke(pop);
            }
            else
            {
                double cellar19 = 0;

                if (executeFilter == true)
                {
                    dgvPalletCellar.Rows.Clear();

                    for (int i = 0; i < lstMaquile.Count; i++)
                    {
                        bool flgInclude = false;
                        bool flgOKFilm = false;
                        bool flgOKCustomer = false;
                        bool flgOkMovement = false;

                        if (cmbProduct.Text != "" || cmbCustomer.Text != "" || cmbProduct.SelectedIndex > -1 || cmbCustomer.SelectedIndex > -1 ||
                            cmbMovement.Text != "" || cmbMovement.SelectedIndex > -1)
                        {
                            //Film
                            if (cmbProduct.SelectedIndex > -1 || cmbProduct.Text != "")
                            {
                                if (lstMaquile[i].product.ToUpper().StartsWith(cmbProduct.Text.ToString().ToUpper()))
                                    flgOKFilm = true;
                            }

                            if (cmbProduct.Text == "" && cmbProduct.SelectedIndex == -1)
                                flgOKFilm = true;

                            //Customer
                            if (cmbCustomer.SelectedIndex > -1 || cmbCustomer.Text != "")
                            {
                                if (lstMaquile[i].customer.ToUpper().StartsWith(cmbCustomer.Text.ToString().ToUpper()))
                                    flgOKCustomer = true;
                            }

                            if (cmbCustomer.Text == "" && cmbCustomer.SelectedIndex == -1)
                                flgOKCustomer = true;

                            //Movement
                            if (cmbMovement.Text != "" || cmbMovement.SelectedIndex > -1)
                            {
                                if (lstMaquile[i].movement == cmbMovement.Text)
                                    flgOkMovement = true;
                            }

                            if (cmbMovement.Text == "" && cmbMovement.SelectedIndex == -1)
                                flgOkMovement = true;

                            if (flgOKFilm == true && flgOKCustomer == true && flgOkMovement == true)
                                flgInclude = true;
                        }
                        else
                            flgInclude = true;


                        if (flgInclude == true)
                        {
                            dgvPalletCellar.Rows.Add();
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobencodsec.Index].Value = lstMaquile[i].codsec;
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobennumber.Index].Value = (dgvPalletCellar.Rows.Count - 1) + 1;
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmsiigocellar.Index].Value = lstMaquile[i].cellar;
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmsiigomovement.Index].Value = lstMaquile[i].movement;
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmsiigocode.Index].Value = lstMaquile[i].code;
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmsiigoreference.Index].Value = lstMaquile[i].reference;
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobenorigin.Index].Value = lstMaquile[i].origin;
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobenbopp.Index].Value = lstMaquile[i].boppweigth;
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobenopp.Index].Value = lstMaquile[i].oppweigth;
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobenweigth.Index].Value = lstMaquile[i].weigth;
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobenproduct.Index].Value = lstMaquile[i].product;
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobenmovement.Index].Value = lstMaquile[i].movementcellar;
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobencustomer.Index].Value = lstMaquile[i].customer;
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobenwidth.Index].Value = lstMaquile[i].width;
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobenpb.Index].Value = lstMaquile[i].pallet + "-" + lstMaquile[i].coil;
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobendate.Index].Value = lstMaquile[i].createdDate.ToShortDateString();
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmfilter.Index].Value = global::BPS.Properties.Resources.clear;
                            cellar19 += Math.Round(Convert.ToDouble(dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobenweigth.Index].Value), 1);
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobenvalidate.Index].Value = "0";
                            dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobenvalidatevalue.Index].Value = 0;
                        }
                    }
                }
                colorateByOrigin();
                lblCellar19.Text = cellar19.ToString();
            }
        }
        #endregion

        #region Helper

        private void ClearMyFilter()
        {
            cmbCustomer.Text = string.Empty;
            cmbMovement.Text = string.Empty;
            cmbProduct.Text = string.Empty;
            dgvPalletCellar.Rows.Clear();
            cmbCustomer.Items.Clear();
            cmbMovement.Items.Clear();
            cmbProduct.Items.Clear();
            lblnumber.Text = "0";
        }

        private bool validateRows(DataGridView dgvPalletCellar)
        {
            bool hasSelectedRows = false;

            for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
            {
                if (dgvPalletCellar.Rows[i].Cells[clmobenvalidatevalue.Index].Value.ToString() == "1")
                {
                    hasSelectedRows = true;
                    break;
                }
            }

            return hasSelectedRows;
        }

        private void updatePalletExport(DataGridView dgvPalletCellar)
        {
            double cellar19 = 0;
            var count = 0;

            List<int> lstPos = new List<int>();

            for (int i = dgvPalletCellar.Rows.Count - 1; i >= 0; i--)
            {
                if (dgvPalletCellar.Rows[i].Cells[clmobenvalidatevalue.Index].Value.ToString() == "0")
                    lstPos.Add(i);
                else
                {
                    count++;
                    lblnumber.Text = count.ToString();
                }
            }

            for (int i = 0; i < lstPos.Count; i++)
                dgvPalletCellar.Rows.RemoveAt(lstPos[i]);

            //Actualizar los campos para Exportar

            for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
            {
                cellar19 += Math.Round(Convert.ToDouble(dgvPalletCellar.Rows[i].Cells[clmobenweigth.Index].Value), 1);
            }

            dgvPalletCellar.Sort(clmsiigocellar, ListSortDirection.Ascending);
            lblCellar19.Text = cellar19.ToString();
        }

        private bool validateRowsToProductSIIGO(DataGridView dgvPalletCellar)
        {
            bool hasInvalidRows = true;

            for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
            {
                if (dgvPalletCellar.Rows[i].Cells[clmobenvalidatevalue.Index].Value.ToString() == "0")
                {
                    hasInvalidRows = false;
                    break;
                }
            }

            return hasInvalidRows;
        }

        #endregion

        #region Filtros

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedIndex > -1)
                fillPalletInfo();
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedIndex > -1)
                fillPalletInfo();
        }

        private void cmbMovement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMovement.SelectedIndex > -1)
                fillPalletInfo();
        }

        private void cmbProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }

        private void cmbCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }

        private void cmbMovement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }

        private void cmbCellar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }

        #endregion

        #region Acciones

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbMovements.SelectedIndex > -1)
                {
                    if (dtpInitDate.Value.CompareTo(dtpEndDate.Value) < 0)
                    {
                        movementload = cmbMovements.Text.ToString();
                        ClearMyFilter();

                        Thread td = new Thread(new ThreadStart(this.loadMovements));
                        td.Start();
                    }
                    else if (dtpInitDate.Value.CompareTo(dtpEndDate.Value) == 0)
                        MessageBox.Show("Las fechas no pueden ser iguales por favor cambie las fechas", "Exportación de Maquilas al Siigo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    else if (dtpInitDate.Value.CompareTo(dtpEndDate.Value) > 0)
                        MessageBox.Show("La fecha inicio no pueden ser mayor que la fecha fin", "Exportación de Maquilas al Siigo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un movimiento antes de poder visualizar los datos", "Exportación de Maquilas al Siigo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    cmbMovements.SelectedText = string.Empty;
                    cmbMovements.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exportación de Maquilas al Siigo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void dgvPalletCellar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmfilter.Index)
            {
                if (dgvPalletCellar.Rows[e.RowIndex].Cells[clmobenvalidatevalue.Index].Value.ToString() != "0")
                {
                    dgvPalletCellar.Rows[e.RowIndex].Cells[clmfilter.Index].Value = global::BPS.Properties.Resources.clear;
                    dgvPalletCellar.Rows[e.RowIndex].Cells[clmobenvalidatevalue.Index].Value = 0;
                }
                else
                {
                    dgvPalletCellar.Rows[e.RowIndex].Cells[clmfilter.Index].Value = global::BPS.Properties.Resources.accept;
                    dgvPalletCellar.Rows[e.RowIndex].Cells[clmobenvalidatevalue.Index].Value = 1;
                }
            }
        }

        private void dgvPalletCellar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmsiigocode.Index)
            {
                if (e.RowIndex > -1)
                {
                    frmXtraFilmEquivalence winXtraFilmEquivalence = new frmXtraFilmEquivalence(dgvPalletCellar.Rows[e.RowIndex].Cells[clmobenproduct.Index].Value.ToString());
                    winXtraFilmEquivalence.ShowDialog();
                }
            }
        }

        private void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelectAll.Checked == true)
            {
                for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
                {
                    dgvPalletCellar.Rows[i].Cells[clmfilter.Index].Value = global::BPS.Properties.Resources.accept;
                    dgvPalletCellar.Rows[i].Cells[clmobenvalidatevalue.Index].Value = 1;
                    dgvPalletCellar.FirstDisplayedScrollingRowIndex = i;
                }
            }
            else
            {
                if (MessageBox.Show("Esta realmente seguro que desea eliminar la selección de los movimientos?", "Exportación de Maquilas al Siigo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.OK)
                {
                    for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
                    {
                        dgvPalletCellar.Rows[i].Cells[clmfilter.Index].Value = global::BPS.Properties.Resources.clear;
                        dgvPalletCellar.Rows[i].Cells[clmobenvalidatevalue.Index].Value = 0;
                        dgvPalletCellar.FirstDisplayedScrollingRowIndex = i;
                    }
                    chkSelectAll.Checked = false;
                }
            }
        }

        private void btnFilterPallet_Click(object sender, EventArgs e)
        {
            if (validateRows(dgvPalletCellar))
            {
                if (MessageBox.Show("Los registros no seleccionados serán eliminados del listado para no ser tomados en cuenta en la exportación. Desea continuar?", "Exportación Maquilas a SIIGO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                    updatePalletExport(dgvPalletCellar);
            }
            else
                MessageBox.Show("No ha seleccionado ninguna movimiento para ser exportado.", "Exportación Maquilas a SIIGO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
            {
                bool flgIsValidated = true;

                if (dgvPalletCellar.Rows[i].Cells[clmsiigocode.Index].Value.ToString() == "0000000000000")
                    flgIsValidated = false;

                if (flgIsValidated == true)
                {
                    dgvPalletCellar.Rows[i].Cells[clmobenproduct.Index].Style.ForeColor = Color.Black;
                    dgvPalletCellar.Rows[i].Cells[clmobenproduct.Index].Style.SelectionForeColor = Color.Black;
                    dgvPalletCellar.Rows[i].Cells[clmsiigocode.Index].Style.ForeColor = Color.Black;
                    dgvPalletCellar.Rows[i].Cells[clmsiigocode.Index].Style.SelectionForeColor = Color.Black;
                    dgvPalletCellar.Rows[i].Cells[clmobenvalidatevalue.Index].Value = 1;
                }
                else
                {
                    dgvPalletCellar.Rows[i].Cells[clmobenproduct.Index].Style.ForeColor = Color.Red;
                    dgvPalletCellar.Rows[i].Cells[clmobenproduct.Index].Style.SelectionForeColor = Color.Red;
                    dgvPalletCellar.Rows[i].Cells[clmsiigocode.Index].Style.ForeColor = Color.Red;
                    dgvPalletCellar.Rows[i].Cells[clmsiigocode.Index].Style.SelectionForeColor = Color.Red;
                    dgvPalletCellar.Rows[i].Cells[clmobenvalidatevalue.Index].Value = 0;
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            List<clsMaquile> lstPalletMovement = new List<clsMaquile>();

            if (validateRows(dgvPalletCellar))
            {
                if (validateRowsToProductSIIGO(dgvPalletCellar))
                {
                    if (MessageBox.Show("Se realizará el proceso de creación de los archivos de exportación a SIIGO de los movimientos seleccionados.\n\n Desea continuar?", "Exportación Maquilas a SIIGO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                    {
                        string folderPath = "";
                        fbdFilePath.Description = "Por favor, seleccione la ubicación donde se guardarán los archivos de exportación.";
                        fbdFilePath.ShowDialog();

                        folderPath = fbdFilePath.SelectedPath;
                        lstPalletMovement = new List<clsMaquile>();

                        for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
                        {
                            if (dgvPalletCellar.Rows[i].Cells[clmobenvalidatevalue.Index].Value.ToString() == "1")
                                lstPalletMovement.Add(new clsMaquile(Convert.ToInt32(dgvPalletCellar.Rows[i].Cells[clmobencodsec.Index].Value)));
                        }

                        if (clsXportCellarMovementsToSIIGO.exportMaquileMovementsToSiigo(lstPalletMovement, folderPath, 1, isActiveCalendar, dtpEndMonth))
                        {
                            MessageBox.Show("Se han generado los archivos para la exportación de los movimientos al SIIGO con éxito.", "Exportación Maquilas a SIIGO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                            ClearMyFilter();
                        }
                        else
                            MessageBox.Show("Ha habido un problema al generar los archivos de exportación, por favor comuníquese con el administrador.", "Exportación Maquilas a SIIGO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }
                }
                else
                    MessageBox.Show("Hay películas que no han sido validadas por no tener su correspondiente código de siigo, revise estos códigos para continuar.", "Exportación Maquilas a SIIGO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            else
                MessageBox.Show("No ha seleccionado ningún movimiento para ser exportado.", "Exportación Maquilas a SIIGO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            frmCalendar winCalendar = new frmCalendar(this);
            winCalendar.ShowDialog(this);

            if (dtpEndMonth.Date == DateTime.Now.Date)
                isActiveCalendar = false;
            else
                isActiveCalendar = true;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            string myList = string.Empty;

            if (validateRows(dgvPalletCellar))
            {
                frmCalendar winCalendar = new frmCalendar(this);
                winCalendar.ShowDialog(this);

                if (dtpEndMonth.Date == DateTime.Now.Date)
                    isActiveCalendar = false;
                else
                    isActiveCalendar = true;

                for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
                {
                    if (dgvPalletCellar.Rows[i].Cells[clmobenvalidatevalue.Index].Value.ToString() == "1")
                    {
                        myList += dgvPalletCellar.Rows[i].Cells[clmobencodsec.Index].Value.ToString();
                        myList += ((i < dgvPalletCellar.Rows.Count - 1) ? ";" : "");
                    }
                }

                frmPalletByCoilCellarReport winPallet = new frmPalletByCoilCellarReport(myList, dtpEndMonth.Date, cmbMovement.Text);
                winPallet.ShowDialog(this);
            }
            else
                MessageBox.Show("No ha seleccionado ninguna orden de venta para generar el reporte de movimientos.", "Exportación de ordenes a SIIGO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        }

        #endregion
    }
}
