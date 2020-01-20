using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms; 
using System.Threading;
using Microsoft.Office.Interop.Excel;
using System.Drawing.Printing;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmMaquileCoilBackLoadList : Form
    {
        List<clsMaquile> lstMaquile = new List<clsMaquile>();

        bool executeFilter = true;
        delegate void showLoading();
        delegate void HideLoading();

        showLoading showLoadImage;
        HideLoading hideLoadImage;

        private void loadMovements()
        {
            this.Invoke(showLoadImage);
            lstMaquile = clsMaquile.getList();
            this.Invoke(hideLoadImage);
        }

        private void showLoadingDelegate()
        {
            pbxLoading.Visible = true;
            grpbFilters.Enabled = false;
            lblLoading.Visible = true;
        }
        private void hideLoadingDelegate()
        {
            fillPalletInfo();
            List<string> lstFilm = new List<string>();
            List<string> lstProducts = new List<string>();
            List<string> lstCustomers = new List<string>();
            List<string> lstCellar = new List<string>();

            for (int i = 0; i < lstMaquile.Count; i++)
            {
                //Film
                bool flgIsFilmInList = false;
                for (int j = 0; j < lstFilm.Count; j++)
                {
                    if (lstFilm[j] == lstMaquile[i].name)
                    {
                        flgIsFilmInList = true;
                        break;
                    }
                }
                if (flgIsFilmInList == false)
                    lstFilm.Add(lstMaquile[i].name);

                //Products
                bool flgIsProductInList = false;
                for (int j = 0; j < lstProducts.Count; j++)
                {
                    if (lstProducts[j] == lstMaquile[i].abbreviation)
                    {
                        flgIsProductInList = true;
                        break;
                    }
                }
                if (flgIsProductInList == false)
                    lstProducts.Add(lstMaquile[i].abbreviation);

                //Customers
                bool flgIsCustomerInList = false;
                for (int j = 0; j < lstCustomers.Count; j++)
                {
                    if (lstCustomers[j] == lstMaquile[i].customer)
                    {
                        flgIsCustomerInList = true;
                        break;
                    }
                }
                if (flgIsCustomerInList == false)
                    lstCustomers.Add(lstMaquile[i].customer);

                //Sales Order Number
                bool flgIsCellarInList = false;
                for (int j = 0; j < lstCellar.Count; j++)
                {
                    if (lstCellar[j] == lstMaquile[i].cellarName)
                    {
                        flgIsCellarInList = true;
                        break;
                    }
                }
                if (flgIsCellarInList == false)
                    lstCellar.Add(lstMaquile[i].cellarName);
            }

            cmbCustomer.Items.Clear();
            cmbType.Items.Clear();
            cmbProduct.Items.Clear();

            lstFilm.Sort();
            lstProducts.Sort();
            lstCustomers.Sort();
            lstCellar.Sort();

            for (int i = 0; i < lstFilm.Count; i++)
                cmbType.Items.Add(lstFilm[i]);

            for (int i = 0; i < lstCustomers.Count; i++)
                cmbCustomer.Items.Add(lstCustomers[i]);

            for (int i = 0; i < lstProducts.Count; i++)
                cmbProduct.Items.Add(lstProducts[i]);

            grpbFilters.Enabled = true;
            pbxLoading.Visible = false;
            lblLoading.Visible = false;
        }
        public frmMaquileCoilBackLoadList()
        {
            InitializeComponent();
            getPalletList();
        }
        private void getPalletList()
        {
            showLoadImage = new showLoading(showLoadingDelegate);
            hideLoadImage = new HideLoading(hideLoadingDelegate);
        }
        private void fillPalletInfo()
        {
            double TotalWeigth = 0;
            
            if (executeFilter == true)
            {
                string filmCode = "";
                double totalweigth = 0;
                int lastPosition = -1;

                dgvDetails.Rows.Clear();

                for (int i = 0; i < lstMaquile.Count; i++)
                {
                    bool flgInclude = false;
                    bool flgOKFilm = false;
                    bool flgOKProduct = false;
                    bool flgOKCustomers = false;
                    bool flgOKWidth = false;
                    bool flgOKWeigth = false;


                    if (cmbType.Text != "" || cmbProduct.Text != "" || cmbType.SelectedIndex > -1 || cmbProduct.SelectedIndex > -1 || (txtWidth.Text != "" && txtWidth.Text != "0") || (txtweigth.Text != "" && txtweigth.Text != "0") || cmbCustomer.Text != string.Empty || cmbCustomer.SelectedIndex > -1)
                    {
                        //Film
                        if (cmbType.SelectedIndex > -1 || cmbType.Text != "")
                        {
                            if (lstMaquile[i].name.ToUpper().StartsWith(cmbType.Text.ToString().ToUpper()))
                                flgOKFilm = true;
                        }
                        if (cmbType.Text == "" && cmbType.SelectedIndex == -1)
                            flgOKFilm = true;

                        //Customer
                        if (cmbCustomer.SelectedIndex > -1 || cmbCustomer.Text != "")
                        {
                            if (lstMaquile[i].customer.ToUpper().StartsWith(cmbCustomer.Text.ToString().ToUpper()))
                                flgOKCustomers = true;
                        }
                        if (cmbCustomer.Text == "" && cmbCustomer.SelectedIndex == -1)
                            flgOKCustomers = true;

                        //Product
                        if (cmbProduct.Text != "" || cmbProduct.SelectedIndex > -1)
                        {
                            if (lstMaquile[i].abbreviation.Trim().StartsWith(cmbProduct.Text.ToString().ToUpper()))
                                flgOKProduct = true;
                        }
                        if (cmbProduct.Text == "" && cmbProduct.SelectedIndex == -1)
                            flgOKProduct = true;

                        if (txtWidth.Text != "" && txtWidth.Text != "0")
                        {
                            if (lstMaquile[i].width.ToString().StartsWith(Convert.ToInt32(txtWidth.Text).ToString()))
                                flgOKWidth = true;
                        }
                        else
                            flgOKWidth = true;

                        if (txtweigth.Text != "" && txtweigth.Text != "0")
                        {
                            if (lstMaquile[i].weigth.ToString().StartsWith(Convert.ToDouble(txtweigth.Text).ToString()))
                                flgOKWeigth = true;
                        }
                        else
                            flgOKWeigth = true;

                        if (flgOKFilm == true && flgOKProduct == true && flgOKWidth == true && flgOKCustomers == true  && flgOKWeigth == true)
                            flgInclude = true;
                    }
                    else
                        flgInclude = true;

                    if (flgInclude == true)
                    {
                        TotalWeigth += Math.Round(lstMaquile[i].weigth, 1);

                        if (filmCode == "")
                            filmCode = (lstMaquile.Count > 0) ? lstMaquile[i].abbreviation : string.Empty;

                        if (lstMaquile[i].abbreviation == filmCode)
                            totalweigth += Math.Round(lstMaquile[i].weigth, 1);
                        else
                        {
                            dgvDetails.Rows.Add();
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmType.Index].Value = filmCode;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmweigth.Index].Value = Math.Round(totalweigth, 1);
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmreport.Index].Value = global::BPS.Properties.Resources.clear;

                            for (int j = 0; j < dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells.Count; j++)
                            {
                                System.Drawing.Font fntBold = new System.Drawing.Font(dgvDetails.Font, FontStyle.Bold);
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.Font = fntBold;
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.BackColor = Color.FromArgb(204, 204, 204);
                                totalweigth = 0;
                            }

                            filmCode = lstMaquile[i].name;
                            totalweigth += Math.Round(lstMaquile[i].weigth, 1);
                        }
                        dgvDetails.Rows.Add();
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmcodsec.Index].Value = lstMaquile[i].codsec;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmType.Index].Value = lstMaquile[i].abbreviation;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmproduct.Index].Value = lstMaquile[i].name;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmWidth.Index].Value = lstMaquile[i].width;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmdiameter.Index].Value = lstMaquile[i].Diameter;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmcore.Index].Value = lstMaquile[i].core;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmweigth.Index].Value = Math.Round(lstMaquile[i].weigth, 1).ToString();
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCustomer.Index].Value = lstMaquile[i].customer;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmnotes.Index].Value = lstMaquile[i].notes;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmpallet.Index].Value = lstMaquile[i].pallet;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmcoil.Index].Value = lstMaquile[i].coil;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmcellarname.Index].Value = lstMaquile[i].cellarName;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmreport.Index].Value = global::BPS.Properties.Resources.report;
                        lastPosition = i;
                    }
                }
                if (lastPosition > -1)
                {
                    dgvDetails.Rows.Add();
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmType.Index].Value = filmCode;
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmweigth.Index].Value = Math.Round(totalweigth, 1);
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmreport.Index].Value = global::BPS.Properties.Resources.clear;

                    for (int j = 0; j < dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells.Count; j++)
                    {
                        System.Drawing.Font fntBold = new System.Drawing.Font(dgvDetails.Font, FontStyle.Bold);
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.Font = fntBold;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.BackColor = Color.FromArgb(204, 204, 204);
                        totalweigth = 0;
                    }

                    filmCode = lstMaquile[lastPosition].abbreviation;
                    totalweigth += Math.Round(lstMaquile[lastPosition].weigth, 1);
                }
            }

            lblTotalPallets.Text = TotalWeigth.ToString();
        }

        private void frmMaquileCoilBackLoadList_Load(object sender, EventArgs e)
        {
            Thread td = new Thread(new ThreadStart(this.loadMovements));
            td.Start();
        }

        private void cmbFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillPalletInfo();
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillPalletInfo();
        }

        private void btnMainCoilClearFilters_Click(object sender, EventArgs e)
        {
            executeFilter = false;
            cmbType.SelectedIndex = -1;
            cmbType.Text = "";
            cmbCustomer.SelectedIndex = -1;
            cmbProduct.SelectedIndex = -1;
            cmbProduct.Text = "";
            cmbCustomer.Text = "";
            txtWidth.Clear();
            txtweigth.Clear();
            executeFilter = true;
            fillPalletInfo();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvDetails.Rows.Clear();
            Thread td = new Thread(new ThreadStart(this.loadMovements));
            td.Start();
        }

        private void cmbFilm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }

        private void cmbCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }

        private void dgvDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmreport.Index)
            {
                if (MessageBox.Show("Esta seguro que desea imprimir el reporte?\r\nRecuerde que debe tener como mínimo una impresora determinada..", "Devoluciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                {
                    if (Convert.ToInt32(dgvDetails.Rows[e.RowIndex].Cells[clmcodsec.Index].Value) != 0)
                        clsPrintLabels.printMaquileLabel(Convert.ToInt32(dgvDetails.Rows[e.RowIndex].Cells[clmcodsec.Index].Value));
                }
            }
        }

        private void txtWidthFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
                worksheet.Name = "Pedidos Nacionales";

                for (int i = 1; i < dgvDetails.Columns.Count + 1; i++)
                    worksheet.Cells[1, i] = dgvDetails.Columns[i - 1].HeaderText;

                for (int i = 0; i < dgvDetails.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvDetails.Columns.Count; j++)
                    {
                        if (dgvDetails.Rows[i].Cells[j].Value != null)
                            worksheet.Cells[i + 2, j + 1] = dgvDetails.Rows[i].Cells[j].Value.ToString();
                    }
                }
                MessageBox.Show("Exportación Generada correctamente... Por favor revisar el EXCEL", "Pedidos Nacionales", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pedidos Nacionales", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtweigth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillPalletInfo();
        }

        private void cmbProduct_KeyDown(object sender, KeyEventArgs e)
        {
            fillPalletInfo();
        }
    }
}
