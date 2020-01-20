using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms; 
using BPS.Bussiness;
using System.Threading;
using Microsoft.Office.Interop.Excel;
using System.Drawing.Printing;

namespace BPS
{
    public partial class frmSalesOrderFilmByCustomer : Form
    {
        List<clsFilmByCustomer> lstSalesOrder = new List<clsFilmByCustomer>();
        DataGridViewPrinter MyDataGridViewPrinter;
        bool executeFilter = true;
        delegate void showLoading();
        delegate void HideLoading();

        showLoading showLoadImage;
        HideLoading hideLoadImage;

        private void loadMovements()
        {
            this.Invoke(showLoadImage);
            lstSalesOrder = clsFilmByCustomer.getList();
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

            for (int i = 0; i < lstSalesOrder.Count; i++)
            {
                //Film
                bool flgIsFilmInList = false;
                for (int j = 0; j < lstFilm.Count; j++)
                {
                    if (lstFilm[j] == lstSalesOrder[i].film)
                    {
                        flgIsFilmInList = true;
                        break;
                    }
                }
                if (flgIsFilmInList == false)
                    lstFilm.Add(lstSalesOrder[i].film);


                //Product
                bool flgIsProductInList = false;
                for (int j = 0; j < lstProducts.Count; j++)
                {
                    if (lstProducts[j] == lstSalesOrder[i].product)
                    {
                        flgIsProductInList = true;
                        break;
                    }
                }
                if (flgIsProductInList == false)
                    lstProducts.Add(lstSalesOrder[i].product);


                //Customers
                bool flgIsCustomerInList = false;
                for (int j = 0; j < lstCustomers.Count; j++)
                {
                    if (lstCustomers[j] == lstSalesOrder[i].customer)
                    {
                        flgIsCustomerInList = true;
                        break;
                    }
                }
                if (flgIsCustomerInList == false)
                    lstCustomers.Add(lstSalesOrder[i].customer);
            }

            lstProducts.Sort();
            lstCustomers.Sort();
            lstFilm.Sort();

            for (int i = 0; i < lstFilm.Count; i++)
                cmbFilm.Items.Add(lstFilm[i]);

            for (int i = 0; i < lstProducts.Count; i++)
                cmbMaterial.Items.Add(lstProducts[i]);

            for (int i = 0; i < lstCustomers.Count; i++)
                cmbCustomer.Items.Add(lstCustomers[i]);

            grpbFilters.Enabled = true;
            pbxLoading.Visible = false;
            lblLoading.Visible = false;
        }
        public frmSalesOrderFilmByCustomer()
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
            if (executeFilter == true)
            {
                dgvDetails.Rows.Clear();
                for (int i = 0; i < lstSalesOrder.Count; i++)
                {
                    bool flgInclude = false;
                    bool flgOKFilm = false;
                    bool flgOKCustomers = false;
                    bool flgOKProduct = false;
                    bool flgOKWidth = false;

                    if (cmbMaterial.Text != "" || cmbFilm.Text != "" || cmbMaterial.SelectedIndex > -1 || cmbFilm.SelectedIndex > -1 || (txtWidth.Text != "" && txtWidth.Text != "0") || cmbCustomer.Text != string.Empty || cmbCustomer.SelectedIndex > -1)
                    {
                        //Film
                        if (cmbFilm.SelectedIndex > -1 || cmbFilm.Text != "")
                        {
                            if (lstSalesOrder[i].film.ToUpper().StartsWith(cmbFilm.Text.ToString().ToUpper()))
                                flgOKFilm = true;
                        }
                        if (cmbFilm.Text == "" && cmbFilm.SelectedIndex == -1)
                            flgOKFilm = true;

                        //Customer
                        if (cmbCustomer.SelectedIndex > -1 || cmbCustomer.Text != "")
                        {
                            if (lstSalesOrder[i].customer.ToUpper().StartsWith(cmbCustomer.Text.ToString().ToUpper()))
                                flgOKCustomers = true;
                        }
                        if (cmbCustomer.Text == "" && cmbCustomer.SelectedIndex == -1)
                            flgOKCustomers = true;

                        //Product
                        if (cmbMaterial.Text != "" || cmbMaterial.SelectedIndex > -1)
                        {
                            if (lstSalesOrder[i].product.StartsWith(cmbMaterial.Text))
                                flgOKProduct = true;
                        }
                        if (cmbMaterial.Text == "" && cmbMaterial.SelectedIndex == -1)
                            flgOKProduct = true;

                        if (txtWidth.Text != "" && txtWidth.Text != "0")
                        {
                            if (lstSalesOrder[i].width == Convert.ToInt32(txtWidth.Text))
                                flgOKWidth = true;
                        }
                        else
                            flgOKWidth = true;

                        if (flgOKFilm == true && flgOKProduct == true && flgOKWidth == true && flgOKCustomers == true)
                            flgInclude = true;
                    }
                    else
                        flgInclude = true;

                    if (flgInclude == true)
                    {
                        dgvDetails.Rows.Add();
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmMaterial.Index].Value = lstSalesOrder[i].product;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = lstSalesOrder[i].film;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmWidth.Index].Value = lstSalesOrder[i].width;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCustomer.Index].Value = lstSalesOrder[i].customer;
                    }
                }
            }
        }

        private void frmBackLoad_Load(object sender, EventArgs e)
        {
            Thread td = new Thread(new ThreadStart(this.loadMovements));
            td.Start();
        }

        private void txtFilm_TextChanged(object sender, EventArgs e)
        {
            fillPalletInfo();
        }

        private void cmbFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillPalletInfo();
        }

        private void cmbOrigin_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillPalletInfo();
        }

        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {
            fillPalletInfo();
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillPalletInfo();
        }

        private void txtSalesOrder_TextChanged(object sender, EventArgs e)
        {
            fillPalletInfo();
        }

        private void cmbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillPalletInfo();
        }

        private void chkExtrusionDate_CheckedChanged(object sender, EventArgs e)
        {
            fillPalletInfo();
        }


        private void grpbFilters_Enter(object sender, EventArgs e)
        {

        }

        private void btnMainCoilClearFilters_Click(object sender, EventArgs e)
        {
            executeFilter = false;

            cmbMaterial.SelectedIndex = -1;
            cmbMaterial.Text = "";
            cmbCustomer.SelectedIndex = -1;
            cmbFilm.SelectedIndex = -1;
            cmbFilm.Text = "";
            txtWidth.Clear();
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

        }

        private void cmbOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }

        private void dgvDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtWidthFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }

        private void txtWidthTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }

        private void cmbCustomer_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            fillPalletInfo();
        }

        private void cmbCustomer_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            //bool flgCustomer = false;
            //bool flgOrder = false;
            //bool flgFilm = false;
            //bool flgWidth = false;

            //if (cmbCustomer.Text != string.Empty || cmbCustomer.SelectedIndex > -1)
            //    flgCustomer = true;

            //if (cmbFilm.Text != string.Empty || cmbFilm.SelectedIndex > -1)
            //    flgOrder = true;

            //if (cmbMaterial.Text != string.Empty || cmbMaterial.SelectedIndex > -1)
            //    flgFilm= true;

            //if (txtWidth.Text != string.Empty && txtWidth.Text != "0")
            //    flgWidth = true;

            //if (flgCustomer && !flgOrder && !flgFilm && !flgWidth)
            //{
            //    MessageBox.Show("Customer");
            //}
            //else if (flgCustomer && flgOrder && !flgFilm && !flgWidth)
            //{
            //    MessageBox.Show("Customer-Order || Order-Customer");
            //}
            //else if (flgCustomer && flgOrder && flgFilm && !flgWidth)
            //{
            //    MessageBox.Show("Customer-Order-Film");
            //}
            //else if (flgCustomer && flgOrder && flgFilm && flgWidth)
            //{
            //    MessageBox.Show("Customer-Order-Film-Width");
            //}
            //else if (flgCustomer && !flgOrder && flgFilm && !flgWidth)
            //{
            //    MessageBox.Show("Customer-Film || Film-Customer");
            //}
            //else if (flgCustomer && !flgOrder && !flgFilm && flgWidth)
            //{
            //    MessageBox.Show("Customer-Width || Width-Customer");
            //}
            //else if (!flgCustomer && flgOrder && flgFilm && !flgWidth)
            //{
            //    MessageBox.Show("Order-Film || Film-Order");
            //}
            //else if (!flgCustomer && flgOrder && !flgFilm && flgWidth)
            //{
            //    MessageBox.Show("Order-Width || Width-Order");
            //}
            //else if (!flgCustomer && !flgOrder && flgFilm && flgWidth)
            //{
            //    MessageBox.Show("Film-Width || Width-Film");
            //}
            //else if (!flgCustomer && !flgOrder && !flgFilm && !flgWidth)
            //{
            //    MessageBox.Show("Ninguno");
            //}
            //else if (!flgCustomer && !flgOrder && flgFilm && !flgWidth)
            //{
            //    MessageBox.Show("Film");
            //}
            //else if (!flgCustomer && !flgOrder && !flgFilm && flgWidth)
            //{
            //    MessageBox.Show("Width");
            //}
            //else if (!flgCustomer && flgOrder && !flgFilm && !flgWidth)
            //{
            //    MessageBox.Show("Order");
            //}
            //else if (flgCustomer && !flgOrder && flgFilm && flgWidth)
            //{
            //    MessageBox.Show("Customer-Film-Width");
            //}
            //else if (flgCustomer && flgOrder && !flgFilm && flgWidth)
            //{
            //    MessageBox.Show("Customer-Order-Width");
            //}
            //else if (!flgCustomer && flgOrder && flgFilm && flgWidth)
            //{
            //    MessageBox.Show("Order-Film-Width");
            //}
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
                worksheet.Name = "Productos x Clientes";

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
                MessageBox.Show("Exportación Generada correctamente... Por favor revisar el EXCEL", "Productos x Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Productos x Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            //app.Quit();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (SetupThePrinting())
                printDocument1.Print();
        }
        private bool SetupThePrinting()
        {
            
            PrintDialog MyPrintDialog = new PrintDialog();
            MyPrintDialog.AllowCurrentPage = false;
            MyPrintDialog.AllowPrintToFile = false;
            MyPrintDialog.AllowSelection = false;
            MyPrintDialog.AllowSomePages = false;
            MyPrintDialog.PrintToFile = false;
            MyPrintDialog.ShowHelp = false;
            MyPrintDialog.ShowNetwork = false;

            if (MyPrintDialog.ShowDialog() != DialogResult.OK)
                return false;

            printDocument1.DocumentName = "Productos x Clientes";
            printDocument1.PrinterSettings = MyPrintDialog.PrinterSettings;
            printDocument1.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings;
            printDocument1.DefaultPageSettings.Margins = new Margins(20, 20, 20, 20);

            if (MessageBox.Show("Desea centrar la impresión en la hoja de resultados", "Productos x Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                MyDataGridViewPrinter = new DataGridViewPrinter(dgvDetails, printDocument1, true, true, "Productos x Clientes", new System.Drawing.Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);
            else
                MyDataGridViewPrinter = new DataGridViewPrinter(dgvDetails, printDocument1, false, true, "Productos x Clientes", new System.Drawing.Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);

            return true;
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            bool more = MyDataGridViewPrinter.DrawDataGridView(e.Graphics);
            if (more == true)
                e.HasMorePages = true;
        }
    }
}
