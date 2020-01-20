using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using BPS.Bussiness;

namespace BPS.Raw
{
    public partial class frmBackLoadRaw : Form
    {
        #region Init

        List<clsRawMaterialbyCoilCellar> rawList = new List<clsRawMaterialbyCoilCellar>();
        bool executeFilter = true;
        delegate void showLoading();
        delegate void HideLoading();

        showLoading showLoadImage;
        HideLoading hideLoadImage;

        delegate void fillPalletInfoDelegate();

        private void loadMovements()
        {
            this.Invoke(showLoadImage);
            rawList = clsRawMaterialbyCoilCellar.getListBackLoad();
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
            var demoThread = new Thread(new ThreadStart(this.fillPalletInfo));
            demoThread.Start();
            demoThread.Priority = ThreadPriority.Highest;

            List<string> proList = new List<string>();
            List<string> tmpList = new List<string>();
            List<string> antList = new List<string>();
            List<string> cellList = new List<string>();
            List<string> lotList = new List<string>();

            proList = rawList.Select(p => p.product).Distinct().ToList();
            tmpList = rawList.Select(p => p.productName).Distinct().ToList();
            cellList = rawList.Select(p => p.siigoCellar).Distinct().ToList();
            lotList = rawList.Select(p => p.lotnumber).Distinct().ToList();

            antList.Add("Baja");
            antList.Add("Media");
            antList.Add("Alta");

            proList.Sort();
            tmpList.Sort();
            cellList.Sort();
            lotList.Sort();

            cmbAntique.Items.Clear();
            cmbCustomer.Items.Clear();
            cmbFilm.Items.Clear();
            cmbOrder.Items.Clear();
            cmbLot.Items.Clear();

            for (int i = 0; i < proList.Count; i++)
                cmbFilm.Items.Add(proList[i]);

            for (int i = 0; i < tmpList.Count; i++)
                cmbCustomer.Items.Add(tmpList[i]);

            for (int i = 0; i < cellList.Count; i++)
                cmbOrder.Items.Add(cellList[i]);

            for (int i = 0; i < antList.Count; i++)
                cmbAntique.Items.Add(antList[i]);

            for (int i = 0; i < lotList.Count; i++)
                cmbLot.Items.Add(lotList[i]);

            grpbFilters.Enabled = true;
            pbxLoading.Visible = false;
            lblLoading.Visible = false;
        }

        public frmBackLoadRaw()
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
            if (this.InvokeRequired)
            {
                fillPalletInfoDelegate pop = new fillPalletInfoDelegate(fillPalletInfo);
                this.Invoke(pop);
            }
            else
            {
                int palletCount = 0;
                double palletTotalWeight = 0;
                double palletTotalNew = 0;
                double palletTotalMiddle = 0;
                double palletTotalOld = 0;

                if (executeFilter == true)
                {
                    string productCode = "";
                    double totalNetWeight = 0;
                    int totalPalletsByProduct = 0;
                    int lastPosition = -1;

                    dgvDetails.Rows.Clear();

                    for (int i = 0; i < rawList.Count; i++)
                    {
                        bool flgInclude = false;
                        bool flgOKFilm = false;
                        bool flgOKCustomer = false;
                        bool flgOKAntique = false;
                        bool flgOKCoilCellar = false;
                        bool flgOKLot = false;

                        if (cmbFilm.Text != "" || cmbCustomer.Text != "" || cmbOrder.Text != "" || cmbFilm.SelectedIndex > -1 || cmbCustomer.SelectedIndex > -1 ||
                            cmbOrder.SelectedIndex > -1 || cmbAntique.SelectedIndex > -1 || cmbAntique.SelectedIndex > -1 || cmbAntique.Text != string.Empty ||
                            cmbLot.SelectedIndex > -1 || cmbLot.Text != string.Empty)
                        {
                            //MP
                            if (cmbFilm.SelectedIndex > -1 || cmbFilm.Text != "")
                            {
                                if (rawList[i].product.ToUpper().StartsWith(cmbFilm.Text.ToString().ToUpper()))
                                    flgOKFilm = true;
                            }
                            if (cmbFilm.Text == "" && cmbFilm.SelectedIndex == -1)
                                flgOKFilm = true;

                            //TMP
                            if (cmbCustomer.SelectedIndex > -1 || cmbCustomer.Text != "")
                            {
                                if (rawList[i].productName.ToUpper().StartsWith(cmbCustomer.Text.ToString().ToUpper()))
                                    flgOKCustomer = true;
                            }
                            if (cmbCustomer.Text == "" && cmbCustomer.SelectedIndex == -1)
                                flgOKCustomer = true;

                            //Cellar
                            if (cmbOrder.Text != "" || cmbOrder.SelectedIndex > -1)
                            {
                                if (rawList[i].siigoCellar.StartsWith(cmbOrder.Text))
                                    flgOKCoilCellar = true;
                            }
                            if (cmbOrder.Text == "" && cmbOrder.SelectedIndex == -1)
                                flgOKCoilCellar = true;

                            //Antique
                            if (cmbAntique.Text != "" || cmbAntique.SelectedIndex > -1)
                            {
                                TimeSpan ts = DateTime.Now - rawList[i].date;

                                if (cmbAntique.Text.ToUpper().ToString() == "BAJA")
                                {
                                    if (ts.Days < 120)
                                        flgOKAntique = true;
                                }
                                else if (cmbAntique.Text.ToUpper().ToString() == "MEDIA")
                                {
                                    if (ts.Days >= 120 && ts.Days < 180)
                                        flgOKAntique = true;
                                }
                                else if (cmbAntique.Text.ToUpper().ToString() == "ALTA")
                                {
                                    if (ts.Days >= 180)
                                        flgOKAntique = true;
                                }
                                else
                                    flgOKAntique = true;
                            }
                            else
                                flgOKAntique = true;

                            //TMP
                            if (cmbLot.SelectedIndex > -1 || cmbLot.Text != "")
                            {
                                if (rawList[i].lotnumber.ToUpper().StartsWith(cmbLot.Text.ToString().ToUpper()))
                                    flgOKLot = true;
                            }
                            if (cmbLot.Text == "" && cmbLot.SelectedIndex == -1)
                                flgOKLot = true;

                            if (flgOKFilm == true && flgOKCustomer == true && flgOKAntique == true && flgOKCoilCellar == true && flgOKAntique == true && flgOKLot == true)
                                flgInclude = true;
                        }
                        else
                            flgInclude = true;

                        if (flgInclude == true)
                        {
                            palletCount++;
                            palletTotalWeight += Math.Round(rawList[i].netweigth, 1);

                            if (productCode == "")
                                productCode = (rawList.Count > 0) ? rawList[i].product : "";

                            if (rawList[i].product == productCode)
                            {
                                totalNetWeight += Math.Round(rawList[i].netweigth, 1);
                                totalPalletsByProduct++;
                            }
                            else
                            {
                                dgvDetails.Rows.Add();
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = productCode;
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(totalNetWeight, 1);
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmAntiquity.Index].Value = global::BPS.Properties.Resources.clear;
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDetail.Index].Value = global::BPS.Properties.Resources.clear;

                                for (int j = 0; j < dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells.Count; j++)
                                {
                                    Font fntBold = new Font(dgvDetails.Font, FontStyle.Bold);
                                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.Font = fntBold;
                                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.BackColor = Color.FromArgb(204, 204, 204);
                                }

                                productCode = rawList[i].product;
                                totalNetWeight = Math.Round(rawList[i].netweigth, 1);
                                totalPalletsByProduct = 1;
                            }

                            dgvDetails.Rows.Add();
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCodsec.Index].Value = rawList[i].codsec;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = rawList[i].product;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmTMP.Index].Value = rawList[i].productName;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(rawList[i].netweigth, 1).ToString();
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmLotNumber.Index].Value = rawList[i].lotnumber;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCellar.Index].Value = rawList[i].siigoCellar;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmPS.Index].Value = rawList[i].plbg;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmPro.Index].Value = rawList[i].provider;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmExtrusionDate.Index].Value = rawList[i].date.ToString("dd/MM/yyyy");

                            TimeSpan ts = DateTime.Now - rawList[i].date;

                            if (ts.Days < 120)
                            {
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmAntiquity.Index].Value = global::BPS.Properties.Resources.bullet_green;
                                palletTotalNew += Math.Round(rawList[i].netweigth, 1);
                            }
                            else if (ts.Days >= 120 && ts.Days < 180)
                            {
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmAntiquity.Index].Value = global::BPS.Properties.Resources.bullet_orange;
                                palletTotalMiddle += Math.Round(rawList[i].netweigth, 1);
                            }
                            else
                            {
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmAntiquity.Index].Value = global::BPS.Properties.Resources.bullet_red;
                                palletTotalOld += Math.Round(rawList[i].netweigth, 1);
                            }

                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDetail.Index].Value = global::BPS.Properties.Resources.eye;
                            lastPosition = i;
                        }
                    }
                    if (lastPosition > -1)
                    {
                        dgvDetails.Rows.Add();
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = productCode;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(totalNetWeight, 1);
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmAntiquity.Index].Value = global::BPS.Properties.Resources.clear;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDetail.Index].Value = global::BPS.Properties.Resources.clear;

                        for (int j = 0; j < dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells.Count; j++)
                        {
                            Font fntBold = new Font(dgvDetails.Font, FontStyle.Bold);
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.Font = fntBold;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.BackColor = Color.FromArgb(204, 204, 204);
                        }

                        productCode = rawList[lastPosition].product;
                        totalNetWeight = Math.Round(rawList[lastPosition].netweigth, 1);
                        totalPalletsByProduct = 1;
                    }
                }

                lblTotalPallets.Text = palletCount.ToString();
                lblTotalWeight.Text = palletTotalWeight.ToString();
                lblTotalWeightNew.Text = palletTotalNew.ToString();
                lblTotalWeightMiddle.Text = palletTotalMiddle.ToString();
                lblTotalWeightOld.Text = palletTotalOld.ToString();

                colorateByCoilCellar();
            }
        }

        private void frmBackLoad_Load(object sender, EventArgs e)
        {
            Thread td = new Thread(new ThreadStart(this.loadMovements));
            td.Start();
        }

        #endregion

        #region Helper

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
                            case "Bodega de Consumo":
                                for (int j = 0; j < dgvDetails.Columns.Count; j++)
                                    dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(232, 202, 244);
                                break;
                            case "Bodega Depósito Industrial":
                                for (int j = 0; j < dgvDetails.Columns.Count; j++)
                                    dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(176, 247, 182);
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

        private void btnMainCoilClearFilters_Click(object sender, EventArgs e)
        {
            executeFilter = false;

            cmbFilm.SelectedIndex = -1;
            cmbFilm.Text = "";
            cmbCustomer.SelectedIndex = -1;
            cmbCustomer.Text = "";
            cmbOrder.SelectedIndex = -1;
            cmbOrder.Text = "";
            cmbAntique.SelectedIndex = -1;
            cmbAntique.Text = "";
            executeFilter = true;
            fillPalletInfo();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvDetails.Rows.Clear();
            Thread td = new Thread(new ThreadStart(this.loadMovements));
            td.Start();
        }

        private void chkColorCoilCellar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkColorCoilCellar.Checked == true)
                grpbColorCode.Visible = true;
            else
                grpbColorCode.Visible = false;

            colorateByCoilCellar();
        }

        #endregion

        #region Actions

        private void cmbFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            var demoThread = new Thread(new ThreadStart(this.fillPalletInfo));
            demoThread.Start();
            demoThread.Priority = ThreadPriority.Highest;
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            var demoThread = new Thread(new ThreadStart(this.fillPalletInfo));
            demoThread.Start();
            demoThread.Priority = ThreadPriority.Highest;
        }

        private void cmbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            var demoThread = new Thread(new ThreadStart(this.fillPalletInfo));
            demoThread.Start();
            demoThread.Priority = ThreadPriority.Highest;
        }

        private void cmbAntique_SelectedIndexChanged(object sender, EventArgs e)
        {
            var demoThread = new Thread(new ThreadStart(this.fillPalletInfo));
            demoThread.Start();
            demoThread.Priority = ThreadPriority.Highest;
        }

        private void cmbLot_SelectedIndexChanged(object sender, EventArgs e)
        {
            var demoThread = new Thread(new ThreadStart(this.fillPalletInfo));
            demoThread.Start();
            demoThread.Priority = ThreadPriority.Highest;
        }

        private void cmbFilm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var demoThread = new Thread(new ThreadStart(this.fillPalletInfo));
                demoThread.Start();
                demoThread.Priority = ThreadPriority.Highest;
            }
        }

        private void cmbLot_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var demoThread = new Thread(new ThreadStart(this.fillPalletInfo));
                demoThread.Start();
                demoThread.Priority = ThreadPriority.Highest;
            }
        }

        private void cmbAntique_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var demoThread = new Thread(new ThreadStart(this.fillPalletInfo));
                demoThread.Start();
                demoThread.Priority = ThreadPriority.Highest;
            }
        }

        private void cmbCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var demoThread = new Thread(new ThreadStart(this.fillPalletInfo));
                demoThread.Start();
                demoThread.Priority = ThreadPriority.Highest;
            }
        }

        private void cmbOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var demoThread = new Thread(new ThreadStart(this.fillPalletInfo));
                demoThread.Start();
                demoThread.Priority = ThreadPriority.Highest;
            }
        }

        #endregion

        private void dgvDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmDetail.Index)
            {
                if (Convert.ToInt32(dgvDetails.Rows[e.RowIndex].Cells[clmCodsec.Index].Value) != 0)
                {
                    frmPalletDetailRaw winPalletDetailTraceability = new frmPalletDetailRaw(Convert.ToInt32(dgvDetails.Rows[e.RowIndex].Cells[clmCodsec.Index].Value));
                    winPalletDetailTraceability.StartPosition = FormStartPosition.CenterScreen;
                    winPalletDetailTraceability.ShowDialog(this);
                }
            }
        }
    }
}
