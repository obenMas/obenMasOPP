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
    public partial class frmObservationCoilReport : Form
    {
        List<clsCoil> lstCoil = new List<clsCoil>();
        DataGridViewPrinter MyDataGridViewPrinter;
        bool executeFilter = true;
        delegate void showLoading();
        delegate void HideLoading();

        showLoading showLoadImage;
        HideLoading hideLoadImage;

        private void loadMovements()
        {
            this.Invoke(showLoadImage);
            lstCoil = clsCoil.getObservationCoilList(true);
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
            List<string> lstProducts = new List<string>();
            List<string> lstCustomers = new List<string>();
            List<string> lstSalesOrderNumber = new List<string>();

            for (int i = 0; i < lstCoil.Count; i++)
            {
                //Products
                bool flgIsProductInList = false;
                for (int j = 0; j < lstProducts.Count; j++)
                {
                    if (lstProducts[j] == lstCoil[i].ProductName)
                    {
                        flgIsProductInList = true;
                        break;
                    }
                }
                if (flgIsProductInList == false)
                    lstProducts.Add(lstCoil[i].ProductName);

                //Customers
                bool flgIsCustomerInList = false;
                for (int j = 0; j < lstCustomers.Count; j++)
                {
                    if (lstCustomers[j] == lstCoil[i].customerName)
                    {
                        flgIsCustomerInList = true;
                        break;
                    }
                }
                if (flgIsCustomerInList == false)
                    lstCustomers.Add(lstCoil[i].customerName);

                //Sales Order Number
                bool flgIsSalesOrderNumberInList = false;
                for (int j = 0; j < lstSalesOrderNumber.Count; j++)
                {
                    if (lstSalesOrderNumber[j] == lstCoil[i].salesOrderNumber)
                    {
                        flgIsSalesOrderNumberInList = true;
                        break;
                    }
                }
                if (flgIsSalesOrderNumberInList == false)
                    lstSalesOrderNumber.Add(lstCoil[i].salesOrderNumber);

            }
            lstProducts.Sort();
            lstCustomers.Sort();
            lstSalesOrderNumber.Sort();

            for (int i = 0; i < lstProducts.Count; i++)
                cmbFilm.Items.Add(lstProducts[i]);

            for (int i = 0; i < lstCustomers.Count; i++)
                cmbCustomer.Items.Add(lstCustomers[i]);

            for (int i = 0; i < lstSalesOrderNumber.Count; i++)
                cmbOrder.Items.Add(lstSalesOrderNumber[i]);

            //for (int i = 0; i < lstCoilCellar.Count; i++)
            //    cmbCoilCellar.Items.Add(lstCoilCellar[i]);

            grpbFilters.Enabled = true;
            pbxLoading.Visible = false;
            lblLoading.Visible = false;
        }
        public frmObservationCoilReport()
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
            double TotalQuantity = 0;
            double TotalProduction = 0;
            double TotalMissing = 0;

            if (executeFilter == true)
            {
                string filmCode = "";
                double totalquantity = 0;
                int totalPalletsByProduct = 0;
                int lastPosition = -1;

                dgvDetails.Rows.Clear();

                for (int i = 0; i < lstCoil.Count; i++)
                {
                    bool flgInclude = false;
                    bool flgOKFilm = false;
                    bool flgOKCustomers = false;
                    bool flgOKSalesOrder = false;
                    bool flgOKWidth = false;
                    bool flgOKExtrusionDate = false;
                    bool flgOKWeigth = false;


                    if (cmbFilm.Text != "" || cmbOrder.Text != "" || cmbFilm.SelectedIndex > -1 || cmbOrder.SelectedIndex > -1 || (txtWidth.Text != "" && txtWidth.Text != "0") || (txtWeigth.Text != "" && txtWeigth.Text != "0") || cmbCustomer.Text != string.Empty || cmbCustomer.SelectedIndex > -1 || chkExtrusionDate.Checked == true)
                    {
                        //Film
                        if (cmbFilm.SelectedIndex > -1 || cmbFilm.Text != "")
                        {
                            if (lstCoil[i].ProductName.ToUpper().StartsWith(cmbFilm.Text.ToString().ToUpper()))
                                flgOKFilm = true;
                        }
                        if (cmbFilm.Text == "" && cmbFilm.SelectedIndex == -1)
                            flgOKFilm = true;

                        //Customer
                        if (cmbCustomer.SelectedIndex > -1 || cmbCustomer.Text != "")
                        {
                            if (lstCoil[i].customerName.ToUpper().StartsWith(cmbCustomer.Text.ToString().ToUpper()))
                                flgOKCustomers = true;
                        }
                        if (cmbCustomer.Text == "" && cmbCustomer.SelectedIndex == -1)
                            flgOKCustomers = true;

                        //Sales Order
                        if (cmbOrder.Text != "" || cmbOrder.SelectedIndex > -1)
                        {
                            if (lstCoil[i].salesOrderNumber.StartsWith(cmbOrder.Text))
                                flgOKSalesOrder = true;
                        }
                        if (cmbOrder.Text == "" && cmbOrder.SelectedIndex == -1)
                            flgOKSalesOrder = true;

                        //Extrusion Date
                        if (chkExtrusionDate.Checked == true)
                        {
                            if (lstCoil[i].cuttingDate >= dtpInitDate.Value && lstCoil[i].cuttingDate <= dtpEndDate.Value)
                                flgOKExtrusionDate = true;
                        }
                        else
                            flgOKExtrusionDate = true;

                        //Width
                        if (txtWidth.Text != "" && txtWidth.Text != "0")
                        {
                                if (lstCoil[i].width == Convert.ToInt32(txtWidth.Text))
                                    flgOKWidth = true;
                        }
                        else
                            flgOKWidth = true;

                        //Weigth
                        if (txtWeigth.Text != "" && txtWeigth.Text != "0")
                        {
                            if (Math.Round(lstCoil[i].netWeight,2) == Math.Round(Convert.ToDouble(txtWeigth.Text),2))
                                flgOKWeigth = true;
                        }
                        else
                            flgOKWeigth = true;

                        if (flgOKFilm == true && flgOKSalesOrder == true && flgOKWidth == true && flgOKCustomers == true && flgOKExtrusionDate == true && flgOKWeigth == true)
                            flgInclude = true;
                    }
                    else
                        flgInclude = true;

                    if (flgInclude == true)
                    {
                        if (filmCode == "")
                            filmCode = (lstCoil.Count > 0) ? lstCoil[i].ProductName : string.Empty;

                        if (lstCoil[i].ProductName == filmCode)
                        {
                            totalquantity += Math.Round(lstCoil[i].netWeight, 1);
                            totalPalletsByProduct++;
                        }
                        else
                        {
                            dgvDetails.Rows.Add();
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = filmCode;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmWeigth.Index].Value = Math.Round(totalquantity, 1);
                            for (int j = 0; j < dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells.Count; j++)
                            {
                                System.Drawing.Font fntBold = new System.Drawing.Font(dgvDetails.Font, FontStyle.Bold);
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.Font = fntBold;
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.BackColor = Color.FromArgb(204, 204, 204);
                            }

                            filmCode = lstCoil[i].ProductName;
                            totalquantity += Math.Round(lstCoil[i].netWeight, 1);
                            totalPalletsByProduct = 1;
                        }
                        dgvDetails.Rows.Add();
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCustomer.Index].Value = lstCoil[i].customerName;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmSalesOrder.Index].Value = lstCoil[i].salesOrderNumber;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = lstCoil[i].ProductName;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmWidth.Index].Value = lstCoil[i].width;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmWeigth.Index].Value = Math.Round(lstCoil[i].netWeight, 2).ToString();
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmcode.Index].Value = lstCoil[i].code;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmObservation.Index].Value = lstCoil[i].notes;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDate.Index].Value = " " + lstCoil[i].cuttingDate + " ";
                        lastPosition = i;
                    }
                }
                if (lastPosition > -1)
                {
                    dgvDetails.Rows.Add();
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = filmCode;
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmWeigth.Index].Value = Math.Round(totalquantity, 1);

                    for (int j = 0; j < dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells.Count; j++)
                    {
                        System.Drawing.Font fntBold = new System.Drawing.Font(dgvDetails.Font, FontStyle.Bold);
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.Font = fntBold;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.BackColor = Color.FromArgb(204, 204, 204);
                        totalquantity = 0;
                    }
                    filmCode = lstCoil[lastPosition].ProductName;
                    totalquantity += Math.Round(lstCoil[lastPosition].netWeight, 1);
                    totalPalletsByProduct = 1;
                }
            }
            lblTotalPallets.Text = TotalQuantity.ToString();
            lblTotalWeight.Text = TotalProduction.ToString();
            label1.Text = TotalMissing.ToString();
        }

        private void frmObservationCoilReport_Load(object sender, EventArgs e)
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

            cmbFilm.SelectedIndex = -1;
            cmbFilm.Text = "";
            cmbCustomer.SelectedIndex = -1;
            cmbOrder.SelectedIndex = -1;
            cmbOrder.Text = "";
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
            bool flgCustomer = false;
            bool flgOrder = false;
            bool flgFilm = false;
            bool flgWidth = false;

            if (cmbCustomer.Text != string.Empty || cmbCustomer.SelectedIndex > -1)
                flgCustomer = true;

            if (cmbOrder.Text != string.Empty || cmbOrder.SelectedIndex > -1)
                flgOrder = true;

            if (cmbFilm.Text != string.Empty || cmbFilm.SelectedIndex > -1)
                flgFilm= true;

            if (txtWidth.Text != string.Empty && txtWidth.Text != "0")
                flgWidth = true;

            if (flgCustomer && !flgOrder && !flgFilm && !flgWidth)
            {
                MessageBox.Show("Customer");
            }
            else if (flgCustomer && flgOrder && !flgFilm && !flgWidth)
            {
                MessageBox.Show("Customer-Order || Order-Customer");
            }
            else if (flgCustomer && flgOrder && flgFilm && !flgWidth)
            {
                MessageBox.Show("Customer-Order-Film");
            }
            else if (flgCustomer && flgOrder && flgFilm && flgWidth)
            {
                MessageBox.Show("Customer-Order-Film-Width");
            }
            else if (flgCustomer && !flgOrder && flgFilm && !flgWidth)
            {
                MessageBox.Show("Customer-Film || Film-Customer");
            }
            else if (flgCustomer && !flgOrder && !flgFilm && flgWidth)
            {
                MessageBox.Show("Customer-Width || Width-Customer");
            }
            else if (!flgCustomer && flgOrder && flgFilm && !flgWidth)
            {
                MessageBox.Show("Order-Film || Film-Order");
            }
            else if (!flgCustomer && flgOrder && !flgFilm && flgWidth)
            {
                MessageBox.Show("Order-Width || Width-Order");
            }
            else if (!flgCustomer && !flgOrder && flgFilm && flgWidth)
            {
                MessageBox.Show("Film-Width || Width-Film");
            }
            else if (!flgCustomer && !flgOrder && !flgFilm && !flgWidth)
            {
                MessageBox.Show("Ninguno");
            }
            else if (!flgCustomer && !flgOrder && flgFilm && !flgWidth)
            {
                MessageBox.Show("Film");
            }
            else if (!flgCustomer && !flgOrder && !flgFilm && flgWidth)
            {
                MessageBox.Show("Width");
            }
            else if (!flgCustomer && flgOrder && !flgFilm && !flgWidth)
            {
                MessageBox.Show("Order");
            }
            else if (flgCustomer && !flgOrder && flgFilm && flgWidth)
            {
                MessageBox.Show("Customer-Film-Width");
            }
            else if (flgCustomer && flgOrder && !flgFilm && flgWidth)
            {
                MessageBox.Show("Customer-Order-Width");
            }
            else if (!flgCustomer && flgOrder && flgFilm && flgWidth)
            {
                MessageBox.Show("Order-Film-Width");
            }
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
                worksheet.Name = "Bobinas en Observación";

                for (int i = 1; i < dgvDetails.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgvDetails.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgvDetails.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvDetails.Columns.Count; j++)
                    {
                        if (dgvDetails.Rows[i].Cells[j].Value != null)
                            worksheet.Cells[i + 2, j + 1] = dgvDetails.Rows[i].Cells[j].Value.ToString();
                    }
                }
                MessageBox.Show("Exportación Generada correctamente... Por favor revisar el EXCEL", "Bobinas en Observación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bobinas en Observación", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            printDocument1.DocumentName = "Bobinas en Observación";
            printDocument1.PrinterSettings = MyPrintDialog.PrinterSettings;
            printDocument1.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings;
            printDocument1.DefaultPageSettings.Margins = new Margins(20, 20, 20, 20);

            if (MessageBox.Show("Desea centrar la impresión en la hoja de resultados", "Bobinas en Observación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                MyDataGridViewPrinter = new DataGridViewPrinter(dgvDetails, printDocument1, true, true, "Bobinas en Observación", new System.Drawing.Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);
            else
                MyDataGridViewPrinter = new DataGridViewPrinter(dgvDetails, printDocument1, false, true, "Bobinas en Observación", new System.Drawing.Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);

            return true;
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            bool more = MyDataGridViewPrinter.DrawDataGridView(e.Graphics);
            if (more == true)
                e.HasMorePages = true;
        }

        private void txtWeigth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }
    }
}
