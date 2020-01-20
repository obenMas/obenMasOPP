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

namespace BPS.Raw
{
    public partial class frmExportRawMaterialS : Form
    {
        List<clsRawMaterialbyCoilCellar> rawList = new List<clsRawMaterialbyCoilCellar>();
        bool executeFilter = true;
        public DateTime dtpEndMonth = DateTime.Now;
        private bool isActiveCalendar = false;

        #region Init
        delegate void showLoading();
        delegate void HideLoading();
        showLoading showLoadImage;
        HideLoading hideLoadImage;

        public frmExportRawMaterialS()
        {
            InitializeComponent();
            getPalletList();
        }

        private void frmExportRawMaterialS_Load(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            pbxLoading.Visible = false;
            lblLoading.Visible = false;
        }

        private void getPalletList()
        {
            showLoadImage = new showLoading(showLoadingDelegate);
            hideLoadImage = new HideLoading(hideLoadingDelegate);
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
            groupBox2.BringToFront();

            fillPalletInfo();

            List<string> proList = new List<string>();
            List<string> movList = new List<string>();

            proList = rawList.Select(p => p.product).Distinct().ToList();
            movList = rawList.Select(p => p.siigoMovement).Distinct().ToList();

            proList.Sort();
            movList.Sort();

            for (int i = 0; i < proList.Count; i++)
                cmbProduct.Items.Add(proList[i]);

            for (int i = 0; i < movList.Count; i++)
                cmbMovement.Items.Add(movList[i]);

            //colorateByOrigin();
            groupBox4.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            groupBox4.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            pbxLoading.Visible = false;
            lblLoading.Visible = false;
        }

        private void fillPalletInfo()
        {
            double cell1 = 0;
            double cell4 = 0;

            if (executeFilter == true)
            {
                dgvPalletCellar.Rows.Clear();

                for (int i = 0; i < rawList.Count; i++)
                {
                    bool flgInclude = false;
                    bool flgOKFilm = false;
                    bool flgOkMovement = false;

                    if (cmbProduct.Text != "" || cmbProduct.SelectedIndex > -1 || cmbMovement.Text != "" || cmbMovement.SelectedIndex > -1)
                    {
                        //Product
                        if (cmbProduct.SelectedIndex > -1 || cmbProduct.Text != "")
                        {
                            if (rawList[i].product.ToUpper().StartsWith(cmbProduct.Text.ToString().ToUpper()))
                                flgOKFilm = true;
                        }

                        if (cmbProduct.Text == "" && cmbProduct.SelectedIndex == -1)
                            flgOKFilm = true;

                        //Movement
                        if (cmbMovement.Text != "" || cmbMovement.SelectedIndex > -1)
                        {
                            if (rawList[i].siigoMovement == cmbMovement.Text)
                                flgOkMovement = true;
                        }

                        if (cmbMovement.Text == "" && cmbMovement.SelectedIndex == -1)
                            flgOkMovement = true;

                        if (flgOKFilm == true && flgOkMovement == true)
                            flgInclude = true;
                    }
                    else
                        flgInclude = true;


                    if (flgInclude == true)
                    {
                        dgvPalletCellar.Rows.Add();
                        dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobencodsec.Index].Value = rawList[i].codsec;
                        dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmfkraw.Index].Value = rawList[i].fkrawmaterial;
                        dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobennumber.Index].Value = (dgvPalletCellar.Rows.Count - 1) + 1;
                        dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmsiigocellar.Index].Value = rawList[i].siigoCellar;
                        dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmsiigomovement.Index].Value = rawList[i].siigoMovement;
                        dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmsiigocode.Index].Value = rawList[i].siigoCode;
                        dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmsiigoreference.Index].Value = rawList[i].siigoReference;
                        dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobenweigth.Index].Value = rawList[i].netweigth;
                        dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobenproduct.Index].Value = rawList[i].product;
                        dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobenmovement.Index].Value = rawList[i].movement;
                        dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobencustomer.Index].Value = rawList[i].productName;
                        dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobenpb.Index].Value = rawList[i].plbg;
                        dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobendate.Index].Value = rawList[i].date.ToShortDateString();
                        dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmfilter.Index].Value = global::BPS.Properties.Resources.clear;

                        if (dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmsiigocellar.Index].Value.ToString() == "1")
                            cell1 += Math.Round(Convert.ToDouble(dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobenweigth.Index].Value), 1);
                        else if (dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmsiigocellar.Index].Value.ToString() == "4")
                            cell4 += Math.Round(Convert.ToDouble(dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobenweigth.Index].Value), 1);

                        dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobenvalidate.Index].Value = "0";
                        dgvPalletCellar.Rows[dgvPalletCellar.Rows.Count - 1].Cells[clmobenvalidatevalue.Index].Value = 0;
                    }
                }
            }
            //colorateByOrigin();
            lblTCellar1.Text = cell1.ToString();
            lblTCellar18.Text = cell4.ToString();
        }

        #endregion

        #region Filter

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpInitDate.Value.CompareTo(dtpEndDate.Value) < 0)
                {
                    ClearMyFilter();
                    Thread td = new Thread(new ThreadStart(this.loadMovements));
                    td.Start();
                }
                else if (dtpInitDate.Value.CompareTo(dtpEndDate.Value) == 0)
                    MessageBox.Show("Las fechas no pueden ser iguales por favor cambie las fechas", "Exportación Materia Prima", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                else if (dtpInitDate.Value.CompareTo(dtpEndDate.Value) > 0)
                    MessageBox.Show("La fecha inicio no pueden ser mayor que la fecha fin", "Exportación Materia Prima", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exportación Materia Prima", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void loadMovements()
        {
            this.Invoke(showLoadImage);
            rawList = clsRawMaterialbyCoilCellar.getMovementListByDateShip(dtpInitDate.Value, dtpEndDate.Value);
            this.Invoke(hideLoadImage);
        }

        #endregion

        #region Helper

        private void ClearMyFilter()
        {
            cmbMovement.Text = string.Empty;
            cmbProduct.Text = string.Empty;
            dgvPalletCellar.Rows.Clear();
            cmbMovement.Items.Clear();
            cmbProduct.Items.Clear();
            lblnumber.Text = "0";
        }

        private void dgvPalletCellar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmsiigocode.Index)
            {
                if (e.RowIndex > -1)
                {
                    frmXtraFilmEquivalence winXtraFilmEquivalence = new frmXtraFilmEquivalence(dgvPalletCellar.Rows[e.RowIndex].Cells[clmfkraw.Index].Value.ToString(), true);
                    winXtraFilmEquivalence.ShowDialog();
                }
            }
        }

        //public void colorateByOrigin()
        //{
        //    for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
        //    {
        //        if (dgvPalletCellar.Rows[i].Cells[clmobenmovement.Index].Value != null)
        //        {
        //            switch (dgvPalletCellar.Rows[i].Cells[clmobenmovement.Index].Value.ToString())
        //            {
        //                case "BOPP":
        //                    if (dgvPalletCellar.Rows[i].Cells[clmobencustomer.Index].Value.ToString() == "STOCK")
        //                    {
        //                        for (int j = 0; j < dgvPalletCellar.Columns.Count; j++)
        //                            dgvPalletCellar.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(249, 203, 202);
        //                    }
        //                    else
        //                    {
        //                        for (int j = 0; j < dgvPalletCellar.Columns.Count; j++)
        //                            dgvPalletCellar.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(218, 232, 137);
        //                    }
        //                    break;
        //                //for (int j = 0; j < dgvPalletCellar.Columns.Count; j++)
        //                //    dgvPalletCellar.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(207, 234, 254);
        //                //break;
        //                case "OPP":
        //                    //for (int j = 0; j < dgvPalletCellar.Columns.Count; j++)
        //                    //    dgvPalletCellar.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(232, 202, 244);

        //                    for (int j = 0; j < dgvPalletCellar.Columns.Count; j++)
        //                        dgvPalletCellar.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(230, 95, 0);

        //                    break;
        //                case "MIXTO":
        //                    for (int j = 0; j < dgvPalletCellar.Columns.Count; j++)
        //                        dgvPalletCellar.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(176, 247, 182);
        //                    break;
        //                case "-----":
        //                    for (int j = 0; j < dgvPalletCellar.Columns.Count; j++)
        //                        dgvPalletCellar.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(188, 188, 254);
        //                    break;
        //                default:
        //                    break;
        //            }
        //        }
        //    }
        //}

        #endregion

        #region Actions

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedIndex > -1)
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

        private void cmbMovement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
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
                if (MessageBox.Show("Esta realmente seguro que desea eliminar la selección de los pallets?", "Exportación de Materia Prima al Siigo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.OK)
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

        #endregion

        private void btnFilterPallet_Click(object sender, EventArgs e)
        {
            double cell1 = 0;
            double cell4 = 0;

            bool hasSelectedRows = false;
            List<clsRawMaterialbyCoilCellar> rawList = new List<clsRawMaterialbyCoilCellar>();

            for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
            {
                if (dgvPalletCellar.Rows[i].Cells[clmobenvalidatevalue.Index].Value.ToString() == "1")
                    hasSelectedRows = true;
            }

            if (hasSelectedRows == true)
            {
                if (MessageBox.Show("Los registros no seleccionados serán eliminados del listado para no ser tomados en cuenta en la exportación. Desea continuar?", "Exportación de movimientos a SIIGO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
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

                    for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
                    {
                        if (dgvPalletCellar.Rows[i].Cells[clmsiigocellar.Index].Value.ToString() == "1")
                            cell1 += Math.Round(Convert.ToDouble(dgvPalletCellar.Rows[i].Cells[clmobenweigth.Index].Value), 1);
                        else if (dgvPalletCellar.Rows[i].Cells[clmsiigocellar.Index].Value.ToString() == "4")
                            cell4 += Math.Round(Convert.ToDouble(dgvPalletCellar.Rows[i].Cells[clmobenweigth.Index].Value), 1);
                    }

                    dgvPalletCellar.Sort(clmsiigocellar, ListSortDirection.Ascending);
                    lblTCellar1.Text = cell1.ToString();
                    lblTCellar18.Text = cell4.ToString();
                }
            }
            else
                MessageBox.Show("No ha seleccionado ninguna orden de venta para ser exportada.", "Exportación de ordenes a SIIGO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
            {
                if (string.IsNullOrEmpty(dgvPalletCellar.Rows[i].Cells[clmsiigocode.Index].Value.ToString()) || string.IsNullOrEmpty(dgvPalletCellar.Rows[i].Cells[clmsiigoreference.Index].Value.ToString()))
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
            bool hasSelectedRows = false;
            List<string> rawList = new List<string>();

            for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
            {
                if (dgvPalletCellar.Rows[i].Cells[clmobenvalidatevalue.Index].Value.ToString() == "1")
                    hasSelectedRows = true;
            }

            if (hasSelectedRows == true)
            {
                bool hasInvalidRows = true;

                for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
                {
                    if (dgvPalletCellar.Rows[i].Cells[clmobenvalidatevalue.Index].Value.ToString() == "0")
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

                        for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
                        {
                            if (dgvPalletCellar.Rows[i].Cells[clmobenvalidatevalue.Index].Value.ToString() == "1")
                                rawList.Add(dgvPalletCellar.Rows[i].Cells[clmobencodsec.Index].Value.ToString());
                        }

                        if (clsXportCellarMovementsToSIIGO.exportRaw(rawList, folderPath, isActiveCalendar, dtpEndMonth))
                        {
                            MessageBox.Show("Se han generado los archivos para la exportación de las ordenes de venta al SIIGO con éxito.", "Exportación de ordenes a SIIGO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                            ClearMyFilter();
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

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            //isActiveCalendar = true;
            frmCalendar winCalendar = new frmCalendar(this);
            winCalendar.ShowDialog(this);
            if (dtpEndMonth.Date == DateTime.Now.Date)
                isActiveCalendar = false;
            else
                isActiveCalendar = true;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            bool hasSelectedRows = false;

            List<string> lstString = new List<string>();

            string myList = string.Empty;

            for (int i = 0; i < dgvPalletCellar.Rows.Count; i++)
            {
                if (dgvPalletCellar.Rows[i].Cells[clmobenvalidatevalue.Index].Value.ToString() == "1")
                    hasSelectedRows = true;
            }

            if (hasSelectedRows == true)
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
    }
}
