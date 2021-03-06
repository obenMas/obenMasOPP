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
    public partial class frmBackLoadBW : Form
    {
        List<clsPallet> lstPallets = new List<clsPallet>();
        private int highestPercentageReached = 0;





        bool executeFilter = true;
        delegate void showLoading();
        delegate void HideLoading();

        showLoading showLoadImage;
        HideLoading hideLoadImage;

        private void loadMovements()
        {
            this.Invoke(showLoadImage);
            lstPallets = clsPallet.getListForBackLoad();
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
            List<int> lstWidths = new List<int>();
            List<string> lstWidths2 = new List<string>();
            List<string> lstCustomers = new List<string>();
            List<string> lstSalesOrderNumber = new List<string>();
            List<string> lstCoilCellar = new List<string>();
            List<string> lstAntique = new List<string>();
            List<string> lstOrigin = new List<string>();

            lstProducts = lstPallets.Select(p => p.product.code).Distinct().ToList();
            lstWidths2 = lstPallets.Select(p => p.product.width.ToString()).Distinct().ToList();
            lstWidths = lstPallets.Select(p => Convert.ToInt32(p.product.width)).Distinct().ToList();
            lstCustomers = lstPallets.Select(p => p.customerName).Distinct().ToList();

            lstSalesOrderNumber = lstPallets.Select(p => p.salesOrderNumber).Distinct().ToList();
            lstCoilCellar = lstPallets.Select(p => p.coilCellarName).Distinct().ToList();
            lstOrigin = lstPallets.Select(p => p.origin).Distinct().ToList();

            lstAntique.Add("Baja");
            lstAntique.Add("Media");
            lstAntique.Add("Alta");

            lstProducts.Sort();
            lstCustomers.Sort();
            lstSalesOrderNumber.Sort();
            lstCoilCellar.Sort();
            lstAntique.Sort();

            cmbAntique.Items.Clear();
            cmbCustomer.Items.Clear();
            cmbFilm.Items.Clear();
            cmbOrder.Items.Clear();
            cmbOrigin.Items.Clear();

            for (int i = 0; i < lstProducts.Count; i++)
                cmbFilm.Items.Add(lstProducts[i]);

            for (int i = 0; i < lstOrigin.Count; i++)
                cmbOrigin.Items.Add(lstOrigin[i]);

            for (int i = 0; i < lstCustomers.Count; i++)
                cmbCustomer.Items.Add(lstCustomers[i]);

            for (int i = 0; i < lstSalesOrderNumber.Count; i++)
                cmbOrder.Items.Add(lstSalesOrderNumber[i]);

            for (int i = 0; i < lstAntique.Count; i++)
                cmbAntique.Items.Add(lstAntique[i]);

            for (int i = 0; i < lstCoilCellar.Count; i++)
                lstbCoilCellar.Items.Add(lstCoilCellar[i]);

            grpbFilters.Enabled = true;
            pbxLoading.Visible = false;
            lblLoading.Visible = false;



            //for (int i = 0; i < lstPallets.Count; i++)
            //{
            //    //Products
            //    bool flgIsProductInList = false;
            //    for (int j = 0; j < lstProducts.Count; j++)
            //    {
            //        if (lstProducts[j] == lstPallets[i].product.code)
            //        {
            //            flgIsProductInList = true;
            //            break;
            //        }
            //    }
            //    if (flgIsProductInList == false)
            //        lstProducts.Add(lstPallets[i].product.code);

            //    //Antique
            //    lstAntique.Add("Baja");
            //    lstAntique.Add("Media");
            //    lstAntique.Add("Alta");

            //    //Widths
            //    bool flgIsWidthInList = false;
            //    for (int j = 0; j < lstWidths.Count; j++)
            //    {
            //        if (lstWidths[j] == lstPallets[i].product.width)
            //        {
            //            flgIsWidthInList = true;
            //            break;
            //        }
            //    }
            //    if (flgIsWidthInList == false)
            //        lstWidths.Add(Convert.ToInt32(lstPallets[i].product.width));


            //    //Customers
            //    bool flgIsCustomerInList = false;
            //    for (int j = 0; j < lstCustomers.Count; j++)
            //    {
            //        if (lstCustomers[j] == lstPallets[i].customerName)
            //        {
            //            flgIsCustomerInList = true;
            //            break;
            //        }
            //    }
            //    if (flgIsCustomerInList == false)
            //        lstCustomers.Add(lstPallets[i].customerName);


            //    //Sales Order Number
            //    bool flgIsSalesOrderNumberInList = false;
            //    for (int j = 0; j < lstSalesOrderNumber.Count; j++)
            //    {
            //        if (lstSalesOrderNumber[j] == lstPallets[i].salesOrderNumber)
            //        {
            //            flgIsSalesOrderNumberInList = true;
            //            break;
            //        }
            //    }
            //    if (flgIsSalesOrderNumberInList == false)
            //        lstSalesOrderNumber.Add(lstPallets[i].salesOrderNumber);

            //    //Coil Cellar
            //    bool flgIsCoilCellar = false;
            //    for (int j = 0; j < lstCoilCellar.Count; j++)
            //    {
            //        if (lstCoilCellar[j] == lstPallets[i].coilCellarName)
            //        {
            //            flgIsCoilCellar = true;
            //            break;
            //        }
            //    }
            //    if (flgIsCoilCellar == false)
            //        lstCoilCellar.Add(lstPallets[i].coilCellarName);

            //    //Origin
            //    bool flgOrigin = false;
            //    for (int j = 0; j < lstOrigin.Count; j++)
            //    {
            //        if (lstOrigin[j] == lstPallets[i].origin)
            //        {
            //            flgOrigin = true;
            //            break;
            //        }
            //    }
            //    if (flgOrigin == false)
            //        lstOrigin.Add(lstPallets[i].origin);

            //}
            //lstProducts.Sort();
            //lstCustomers.Sort();
            //lstSalesOrderNumber.Sort();
            //lstCoilCellar.Sort();
            //lstAntique.Sort();
            //lstAntique.Distinct().ToList();
            //lstAntique = lstAntique.Distinct().ToList();

            //cmbAntique.Items.Clear();
            //cmbCustomer.Items.Clear();
            //cmbFilm.Items.Clear();
            //cmbOrder.Items.Clear();
            //cmbOrigin.Items.Clear();

            //for (int i = 0; i < lstProducts.Count; i++)
            //    cmbFilm.Items.Add(lstProducts[i]);

            //for (int i = 0; i < lstOrigin.Count; i++)
            //    cmbOrigin.Items.Add(lstOrigin[i]);

            //for (int i = 0; i < lstCustomers.Count; i++)
            //    cmbCustomer.Items.Add(lstCustomers[i]);

            //for (int i = 0; i < lstSalesOrderNumber.Count; i++)
            //    cmbOrder.Items.Add(lstSalesOrderNumber[i]);

            //for (int i = 0; i < lstAntique.Count; i++)
            //    cmbAntique.Items.Add(lstAntique[i]);

            //for (int i = 0; i < lstCoilCellar.Count; i++)
            //    lstbCoilCellar.Items.Add(lstCoilCellar[i]);

            //grpbFilters.Enabled = true;
            //pbxLoading.Visible = false;
            //lblLoading.Visible = false;
        }

        public void colorateByCoilCellar()
        {
            if (chkColorCoilCellar.Checked == true)
            {
                for (int i = 0; i < dgvDetails.Rows.Count; i++)
                {
                    if (dgvDetails.Rows[i].Cells[clmCellar.Index].Value != null)
                    {
                        switch (dgvDetails.Rows[i].Cells[clmCellar.Index].Value.ToString())
                        {
                            case "Empaque":
                                for (int j = 0; j < dgvDetails.Columns.Count; j++)
                                    dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(207, 234, 254);
                                break;
                            case "Proceso":
                                for (int j = 0; j < dgvDetails.Columns.Count; j++)
                                    dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(232, 202, 244);
                                break;
                            case "Producto Terminado":
                                for (int j = 0; j < dgvDetails.Columns.Count; j++)
                                    dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(176, 247, 182);
                                break;
                            case "Stock Local":
                                for (int j = 0; j < dgvDetails.Columns.Count; j++)
                                    dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(188, 188, 254);
                                break;
                            case "Metalizado":
                                for (int j = 0; j < dgvDetails.Columns.Count; j++)
                                    dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(177, 211, 185);
                                break;
                            case "Bajas":
                                for (int j = 0; j < dgvDetails.Columns.Count; j++)
                                    dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(249, 196, 183);
                                break;
                            case "Stock Perú":
                                for (int j = 0; j < dgvDetails.Columns.Count; j++)
                                    dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(247, 202, 153);
                                break;
                            case "Base para metalizar":
                                for (int j = 0; j < dgvDetails.Columns.Count; j++)
                                    dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(241, 218, 239);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < dgvDetails.Rows.Count; i++)
                {
                    if (dgvDetails.Rows[i].Cells[clmCellar.Index].Value != null)
                    {
                        if (dgvDetails.Rows[i].Cells[clmCellar.Index].Value.ToString() != "")
                        {
                            for (int j = 0; j < dgvDetails.Columns.Count; j++)
                            {
                                dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.White;
                            }
                        }
                    }
                }
            }
        }

        public frmBackLoadBW()
        {
            InitializeComponent();

            InitializeBackgroundWorker();

            //getPalletList();
        }

        private void InitializeBackgroundWorker()
        {
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;

            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            BackgroundWorker worker = sender as BackgroundWorker;


            lstPallets = clsPallet.getListForBackLoadReload();

            for (int i = 0; i <= lstPallets.Count - 1; i++)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    // Perform a time consuming operation and report progress.
                    //System.Threading.Thread.Sleep(500);


                    PopGrid(lstPallets);


                    if ((i + 1) * 10 > 100)
                    {
                        worker.ReportProgress(100);
                    }
                    else
                    {
                        worker.ReportProgress((i + 1) * 10);
                    }


                }
            }

            //// Get the BackgroundWorker that raised this event.
            //BackgroundWorker worker = sender as BackgroundWorker;

            //// Assign the result of the computation 
            //// to the Result property of the DoWorkEventArgs 
            //// object. This is will be available to the  
            //// RunWorkerCompleted eventhandler.
            //e.Result = ComputeFibonacci((int)e.Argument, worker, e);
        }

        delegate void PopGridDelegate(List<clsPallet> list);

        private void PopGrid(List<clsPallet> list)
        {
            if (this.InvokeRequired)
            {
                PopGridDelegate pop = new PopGridDelegate(PopGrid);
                object[] par = new object[] { list };
                this.Invoke(pop, par);
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    dgvDetails.Rows.Add();
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCodsec.Index].Value = list[i].codsec;
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = list[i].code;
                    //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmWidth.Index].Value = lstPallets[i].product.width;
                    //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDiameter.Index].Value = lstPallets[i].product.DiameterAbbreviation;
                    //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCore.Index].Value = lstPallets[i].product.CoreValue;
                    //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(lstPallets[i].netWeight, 1).ToString();
                    //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmOrigin.Index].Value = lstPallets[i].origin; // lstPallets[i].code;
                    //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmSalesOrder.Index].Value = lstPallets[i].salesOrderNumber;
                    //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCustomer.Index].Value = lstPallets[i].customerName;
                    //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDestination.Index].Value = lstPallets[i].destination;
                    //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmLotNumber.Index].Value = lstPallets[i].lotNumber;
                    //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCellar.Index].Value = lstPallets[i].coilCellarName;
                    //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmPalletNumber.Index].Value = lstPallets[i].palletNumber;
                    //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCoilsNumber.Index].Value = lstPallets[i].coilCount.ToString();

                }
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // First, handle the case where an exception was thrown. 
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled)
            {
                // Next, handle the case where the user canceled  
                // the operation. 
                // Note that due to a race condition in  
                // the DoWork event handler, the Cancelled 
                // flag may not have been set, even though 
                // CancelAsync was called.
                txtWidthFrom.Text = "Canceled";
            }
            else
            {
                // Finally, handle the case where the operation  
                // succeeded.
                txtWidthFrom.Text = (e.Result == null) ? "100" : e.Result.ToString();
            }

            // Enable the UpDown control. 
            //this.numericUpDown1.Enabled = true;

            // Enable the Start button.
            //startAsyncButton.Enabled = true;

            // Disable the Cancel button.
            //cancelAsyncButton.Enabled = false;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;

            txtWidthFrom.Text = (e.ProgressPercentage.ToString() + "%");
        }

        long ComputeFibonacci(int n, BackgroundWorker worker, DoWorkEventArgs e)
        {
            // The parameter n must be >= 0 and <= 91. 
            // Fib(n), with n > 91, overflows a long. 
            //if ((n < 0) || (n > 91))
            //{
            //    throw new ArgumentException(
            //        "value must be >= 0 and <= 91", "n");
            //}

            long result = 0;

            // Abort the operation if the user has canceled. 
            // Note that a call to CancelAsync may have set  
            // CancellationPending to true just after the 
            // last invocation of this method exits, so this  
            // code will not have the opportunity to set the  
            // DoWorkEventArgs.Cancel flag to true. This means 
            // that RunWorkerCompletedEventArgs.Cancelled will 
            // not be set to true in your RunWorkerCompleted 
            // event handler. This is a race condition. 

            if (worker.CancellationPending)
            {
                e.Cancel = true;
            }
            else
            {
                if (n < 2)
                {
                    result = 1;
                }
                else
                {
                    result = ComputeFibonacci(n - 1, worker, e) +
                             ComputeFibonacci(n - 2, worker, e);
                }

                // Report progress as a percentage of the total task. 
                int percentComplete =
                    (int)((float)n / (float)10 * 100);
                if (percentComplete > highestPercentageReached)
                {
                    highestPercentageReached = percentComplete;
                    worker.ReportProgress(percentComplete);
                }
            }

            return result;
        }

        private void frmBackLoadBW_Load(object sender, EventArgs e)
        {
            //Thread td = new Thread(new ThreadStart(this.loadMovements));
            //td.Start();

            // Reset the text in the result label.
            txtWidthFrom.Text = String.Empty;
            // Reset the variable for percentage tracking.
            //highestPercentageReached = 0;

            // Start the asynchronous operation.
            //backgroundWorker1.RunWorkerAsync();

            if (backgroundWorker1.IsBusy != true)
            {
                // Start the asynchronous operation.
                backgroundWorker1.RunWorkerAsync();
            }

        }

        private void btnMainCoilClearFilters_Click(object sender, EventArgs e)
        {

            // Cancel the asynchronous operation. 
            this.backgroundWorker1.CancelAsync();

            // Disable the Cancel button.
            btnMainCoilClearFilters.Enabled = false;








            //executeFilter = false;

            //cmbFilm.SelectedIndex = -1;
            //cmbFilm.Text = "";
            //cmbCustomer.SelectedIndex = -1;
            //cmbCustomer.Text = "";
            //cmbOrigin.Text = "";
            //cmbOrigin.SelectedIndex = -1;
            //cmbOrder.SelectedIndex = -1;
            //cmbOrder.Text = "";
            //cmbAntique.SelectedIndex = -1;
            //cmbAntique.Text = "";
            //chkExtrusionDate.Checked = false;
            //chkCoilCellar.Checked = false;
            //txtWidthFrom.Clear();
            //txtWidthTo.Clear();
            //executeFilter = true;
            //lstbCoilCellar.Items.Clear();
            //fillPalletInfo();
        }


        private void getPalletList()
        {
            showLoadImage = new showLoading(showLoadingDelegate);
            hideLoadImage = new HideLoading(hideLoadingDelegate);
        }
        private void fillPalletInfo()
        {
            //int palletCount = 0;
            //double palletTotalWeight = 0;
            //double palletTotalStock = 0;
            //double palletTotalSalesOrder = 0;
            //double palletTotalNew = 0;
            //double palletTotalMiddle = 0;
            //double palletTotalOld = 0;

            //if (executeFilter == true)
            //{
            //    string productCode = "";
            //    double totalNetWeight = 0;
            //    int totalPalletsByProduct = 0;
            //    int lastPosition = -1;

            //    dgvDetails.Rows.Clear();

            //    for (int i = 0; i < lstPallets.Count; i++)
            //    {
            //        bool flgInclude = false;
            //        bool flgOKFilm = false;
            //        bool flgOKOrigin = false;
            //        bool flgOKCustomer = false;
            //        bool flgOKSalesOrder = false;
            //        bool flgOKExtrusionDate = false;
            //        bool flgOKAntique = false;
            //        bool flgOKCoilCellar = false;
            //        bool flgOKWidth = false;


            //        if (cmbFilm.Text != "" || cmbCustomer.Text != "" || cmbOrder.Text != "" || cmbFilm.SelectedIndex > -1 || cmbCustomer.SelectedIndex > -1 || cmbOrder.SelectedIndex > -1 || cmbAntique.SelectedIndex > -1 || chkExtrusionDate.Checked == true || chkCoilCellar.Checked == true || (txtWidthFrom.Text != "" && txtWidthFrom.Text != "0") || cmbAntique.SelectedIndex > -1 || cmbAntique.Text != string.Empty)
            //        {
            //            //Film
            //            if (cmbFilm.SelectedIndex > -1 || cmbFilm.Text != "")
            //            {
            //                if (lstPallets[i].product.code.ToUpper().StartsWith(cmbFilm.Text.ToString().ToUpper()))
            //                    flgOKFilm = true;
            //            }
            //            if (cmbFilm.Text == "" && cmbFilm.SelectedIndex == -1)
            //                flgOKFilm = true;


            //            //Origin
            //            if (cmbOrigin.SelectedIndex > -1)
            //            {
            //                if (lstPallets[i].origin.ToUpper() == cmbOrigin.SelectedItem.ToString().ToUpper())
            //                    flgOKOrigin = true;
            //            }
            //            if (cmbOrigin.SelectedIndex == -1)
            //                flgOKOrigin = true;

            //            //Customer
            //            if (cmbCustomer.SelectedIndex > -1 || cmbCustomer.Text != "")
            //            {
            //                if (lstPallets[i].customerName.ToUpper().StartsWith(cmbCustomer.Text.ToString().ToUpper()))
            //                    flgOKCustomer = true;
            //            }
            //            if (cmbCustomer.Text == "" && cmbCustomer.SelectedIndex == -1)
            //                flgOKCustomer = true;

            //            //Sales Order
            //            if (cmbOrder.Text != "" || cmbOrder.SelectedIndex > -1)
            //            {
            //                if (lstPallets[i].salesOrderNumber.StartsWith(cmbOrder.Text))
            //                    flgOKSalesOrder = true;
            //            }
            //            if (cmbOrder.Text == "" && cmbOrder.SelectedIndex == -1)
            //                flgOKSalesOrder = true;

            //            //Extrusion Date
            //            if (chkExtrusionDate.Checked == true)
            //            {
            //                if (lstPallets[i].createdDate >= dtpInitDate.Value && lstPallets[i].createdDate <= dtpEndDate.Value)
            //                {
            //                    flgOKExtrusionDate = true;
            //                }
            //            }
            //            else
            //                flgOKExtrusionDate = true;

            //            //Coil cellar
            //            if (chkCoilCellar.Checked == true)
            //            {
            //                for (int j = 0; j < lstbCoilCellar.SelectedItems.Count; j++)
            //                {
            //                    if (lstPallets[i].coilCellarName.ToUpper().StartsWith(lstbCoilCellar.SelectedItems[j].ToString().ToUpper()))
            //                        flgOKCoilCellar = true;
            //                }
            //            }
            //            else
            //                flgOKCoilCellar = true;

            //            if (txtWidthFrom.Text != "" && txtWidthFrom.Text != "0")
            //            {
            //                if (txtWidthTo.Text != "" && txtWidthTo.Text != "0")
            //                {
            //                    if (lstPallets[i].product.width >= Convert.ToInt32(txtWidthFrom.Text) && lstPallets[i].product.width <= Convert.ToInt32(txtWidthTo.Text))
            //                        flgOKWidth = true;
            //                }
            //                else
            //                {
            //                    if (lstPallets[i].product.width == Convert.ToInt32(txtWidthFrom.Text))
            //                        flgOKWidth = true;
            //                }
            //            }
            //            else
            //                flgOKWidth = true;

            //            //Antique
            //            if (cmbAntique.Text != "" || cmbAntique.SelectedIndex > -1)
            //            {
            //                TimeSpan ts = DateTime.Now - lstPallets[i].extrusionDate;

            //                if (cmbAntique.Text.ToUpper().ToString() == "BAJA")
            //                {
            //                    if (ts.Days < 120)
            //                        flgOKAntique = true;
            //                }
            //                else if (cmbAntique.Text.ToUpper().ToString() == "MEDIA")
            //                {
            //                    if (ts.Days >= 120 && ts.Days < 180)
            //                        flgOKAntique = true;
            //                }
            //                else if (cmbAntique.Text.ToUpper().ToString() == "ALTA")
            //                {
            //                    if (ts.Days >= 180)
            //                        flgOKAntique = true;
            //                }
            //                else
            //                    flgOKAntique = true;
            //            }
            //            else
            //                flgOKAntique = true;

            //            if (flgOKFilm == true && flgOKOrigin == true && flgOKCustomer == true && flgOKSalesOrder == true && flgOKExtrusionDate == true && flgOKAntique == true && flgOKCoilCellar == true && flgOKWidth == true && flgOKAntique == true)
            //                flgInclude = true;
            //        }
            //        else
            //        {
            //            flgInclude = true;
            //        }

            //        if (flgInclude == true)
            //        {
            //            palletCount++;
            //            palletTotalWeight += Math.Round(lstPallets[i].netWeight, 1);
            //            if (lstPallets[i].customerName == "STOCK")
            //                palletTotalStock += Math.Round(lstPallets[i].netWeight, 1);
            //            else
            //                palletTotalSalesOrder += Math.Round(lstPallets[i].netWeight, 1);

            //            if (productCode == "")
            //                productCode = (lstPallets.Count > 0) ? lstPallets[i].product.code : "";

            //            if (lstPallets[i].product.code == productCode)
            //            {
            //                totalNetWeight += Math.Round(lstPallets[i].netWeight, 1);
            //                totalPalletsByProduct++;
            //            }
            //            else
            //            {
            //                dgvDetails.Rows.Add();
            //                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = productCode;
            //                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(totalNetWeight, 1);
            //                //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmAntiquity.Index].Value = global::BPS.Properties.Resources.clear;
            //                //dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDetail.Index].Value = global::BPS.Properties.Resources.clear;

            //                for (int j = 0; j < dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells.Count; j++)
            //                {
            //                    Font fntBold = new Font(dgvDetails.Font, FontStyle.Bold);
            //                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.Font = fntBold;
            //                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.BackColor = Color.FromArgb(204, 204, 204);
            //                }

            //                productCode = lstPallets[i].product.code;
            //                totalNetWeight = Math.Round(lstPallets[i].netWeight, 1);
            //                totalPalletsByProduct = 1;
            //            }


            //            dgvDetails.Rows.Add();
            //            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCodsec.Index].Value = lstPallets[i].codsec;
            //            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = lstPallets[i].product.code;
            //            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmWidth.Index].Value = lstPallets[i].product.width;
            //            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDiameter.Index].Value = lstPallets[i].product.DiameterAbbreviation;
            //            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCore.Index].Value = lstPallets[i].product.CoreValue;
            //            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(lstPallets[i].netWeight, 1).ToString();
            //            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmOrigin.Index].Value = lstPallets[i].origin; // lstPallets[i].code;
            //            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmSalesOrder.Index].Value = lstPallets[i].salesOrderNumber;
            //            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCustomer.Index].Value = lstPallets[i].customerName;
            //            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDestination.Index].Value = lstPallets[i].destination;
            //            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmLotNumber.Index].Value = lstPallets[i].lotNumber;
            //            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCellar.Index].Value = lstPallets[i].coilCellarName;
            //            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmPalletNumber.Index].Value = lstPallets[i].palletNumber;
            //            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCoilsNumber.Index].Value = lstPallets[i].coilCount.ToString();

            //            //DateTime extrusionDate = DateTime.Now;

            //            //for (int j = 0; j < lstPallets[i].lstCoil.Count; j++)
            //            //{
            //            //    if (lstPallets[i].lstCoil[0].extrusionDate < extrusionDate)
            //            //        extrusionDate = lstPallets[i].lstCoil[j].extrusionDate;
            //            //}
            //            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmExtrusionDate.Index].Value = lstPallets[i].extrusionDate.ToString("dd/MM/yyyy");

            //            TimeSpan ts = DateTime.Now - lstPallets[i].extrusionDate;

            //            if (ts.Days < 120)
            //            {
            //                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmAntiquity.Index].Value = global::BPS.Properties.Resources.bullet_green;
            //                palletTotalNew += Math.Round(lstPallets[i].netWeight, 1);
            //            }
            //            else if (ts.Days >= 120 && ts.Days < 180)
            //            {
            //                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmAntiquity.Index].Value = global::BPS.Properties.Resources.bullet_orange;
            //                palletTotalMiddle += Math.Round(lstPallets[i].netWeight, 1);
            //            }
            //            else
            //            {
            //                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmAntiquity.Index].Value = global::BPS.Properties.Resources.bullet_red;
            //                palletTotalOld += Math.Round(lstPallets[i].netWeight, 1);
            //            }

            //            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDetail.Index].Value = global::BPS.Properties.Resources.eye;
            //            lastPosition = i;

            //            bool isblock = false;

            //            for (int k = 0; k < lstPallets[i].coilList.Count; k++)
            //            {
            //                if (lstPallets[i].coilList[k] == 1)
            //                {
            //                    isblock = true;
            //                    break;
            //                }
            //                else
            //                    isblock = false;
            //            }
            //            if (isblock)
            //            {
            //                for (int j = 0; j < dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells.Count; j++)
            //                {
            //                    Font fntBold = new Font(dgvDetails.Font, FontStyle.Bold);
            //                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.Font = fntBold;
            //                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.ForeColor = Color.Red;
            //                }
            //            }
            //        }
            //    }
            //    if (lastPosition > -1)
            //    {
            //        dgvDetails.Rows.Add();
            //        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = productCode;
            //        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(totalNetWeight, 1);
            //        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmAntiquity.Index].Value = global::BPS.Properties.Resources.clear;
            //        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDetail.Index].Value = global::BPS.Properties.Resources.clear;

            //        for (int j = 0; j < dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells.Count; j++)
            //        {
            //            Font fntBold = new Font(dgvDetails.Font, FontStyle.Bold);
            //            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.Font = fntBold;
            //            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.BackColor = Color.FromArgb(204, 204, 204);
            //        }

            //        productCode = lstPallets[lastPosition].product.code;
            //        totalNetWeight = Math.Round(lstPallets[lastPosition].netWeight, 1);
            //        totalPalletsByProduct = 1;
            //    }
            //}

            //lblTotalPallets.Text = palletCount.ToString();
            //lblTotalWeight.Text = palletTotalWeight.ToString();
            //lblTotalStockWeight.Text = palletTotalStock.ToString();
            //lblTotalSalesOrderWeight.Text = palletTotalSalesOrder.ToString();
            //lblTotalWeightNew.Text = palletTotalNew.ToString();
            //lblTotalWeightMiddle.Text = palletTotalMiddle.ToString();
            //lblTotalWeightOld.Text = palletTotalOld.ToString();

            //colorateByCoilCellar();

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

        private void cmbOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }

        private void dgvDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmDetail.Index)
            {
                if (Convert.ToInt32(dgvDetails.Rows[e.RowIndex].Cells[clmCodsec.Index].Value) != 0)
                {
                    //frmPalletDetailTraceability winPalletDetailTraceability = new frmPalletDetailTraceability(Convert.ToInt32(dgvDetails.Rows[e.RowIndex].Cells[clmCodsec.Index].Value));
                    //winPalletDetailTraceability.ShowDialog(this);
                }
            }
        }

        private void lstbCoilCellar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbCoilCellar.SelectedItems.Count > 0)
            {
                if (chkCoilCellar.Checked == false)
                    chkCoilCellar.Checked = true;
                else
                    fillPalletInfo();

            }
        }

        private void chkCoilCellar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCoilCellar.Checked == false)
                lstbCoilCellar.ClearSelected();

            fillPalletInfo();
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

        private void chkColorCoilCellar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkColorCoilCellar.Checked == true)
                grpbColorCode.Visible = true;
            else
                grpbColorCode.Visible = false;

            colorateByCoilCellar();
        }

        private void cmbAntique_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillPalletInfo();
        }

        private void cmbAntique_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }
    }
}
