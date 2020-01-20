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

namespace BPS.Cellar.Inventory.RePro
{
    public partial class frmSummaryInventoryVsBackload : Form
    {
        #region Parametros
        List<clsComparator> lstComparator = new List<clsComparator>();
        int codsec = 0;
        bool executeFilter = true;
        delegate void showLoading();
        delegate void HideLoading();
        showLoading showLoadImage;
        HideLoading hideLoadImage;
        #endregion

        #region Inicio
        private void loadMovements()
        {
            this.Invoke(showLoadImage);
            lstComparator = clsComparator.getComparatorShortRePro(codsec);
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

            List<string> lstProducts = new List<string>();
            List<string> lstPosition = new List<string>();

            lstProducts = lstComparator.Select(p => p.productName).Distinct().ToList();
            lstPosition = lstComparator.Select(p => p.destination).Distinct().ToList();

            lstProducts.Sort();
            lstPosition.Sort();

            for (int i = 0; i < lstProducts.Count; i++)
                cmbFilm.Items.Add(lstProducts[i]);

            for (int i = 0; i < lstPosition.Count; i++)
                cmbPosition.Items.Add(lstPosition[i]);

            grpbFilters.Enabled = true;
            pbxLoading.Visible = false;
            lblLoading.Visible = false;
        }

        public void colorateByCoilCellar()
        {
            if (chkColorCoilCellar.Checked == true)
            {
                for (int i = 0; i < dgvDetails.Rows.Count; i++)
                {
                    if (dgvDetails.Rows[i].Cells[clminventory.Index].Value != null)
                    {
                        switch (dgvDetails.Rows[i].Cells[clminventory.Index].Value.ToString())
                        {
                            case "OK":
                                for (int j = 0; j < dgvDetails.Columns.Count; j++)
                                    dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(207, 234, 254);
                                break;
                            case "Inventario":
                                for (int j = 0; j < dgvDetails.Columns.Count; j++)
                                    dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(232, 202, 244);
                                break;
                            case "Backload":
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
                    if (dgvDetails.Rows[i].Cells[clminventory.Index].Value != null)
                    {
                        if (dgvDetails.Rows[i].Cells[clminventory.Index].Value.ToString() != "")
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

        public frmSummaryInventoryVsBackload()
        {
            InitializeComponent();
            getPalletList();
        }

        public frmSummaryInventoryVsBackload(int codsec)
        {
            InitializeComponent();
            this.codsec = codsec;
            getPalletList();
        }

        private void getPalletList()
        {
            showLoadImage = new showLoading(showLoadingDelegate);
            hideLoadImage = new HideLoading(hideLoadingDelegate);
        }

        delegate void fillPalletInfoDelegate();

        private void frmBackLoad_Load(object sender, EventArgs e)
        {
            Thread td = new Thread(new ThreadStart(this.loadMovements));
            td.Start();
        }
        #endregion

        #region Fill Data

        private void fillPalletInfo()
        {
            double totalNetWeight = 0;

            if (this.InvokeRequired)
            {
                fillPalletInfoDelegate pop = new fillPalletInfoDelegate(fillPalletInfo);
                this.Invoke(pop);
            }
            else
            {
                int palletCount = 0;

                if (executeFilter == true)
                {
                    string productCode = "";
                    int totalPalletsByProduct = 0;
                    int lastPosition = -1;

                    dgvDetails.Rows.Clear();

                    for (int i = 0; i < lstComparator.Count; i++)
                    {
                        bool flgInclude = false;
                        bool flgOKFilm = false;
                        bool flgOKPosition = false;

                        if (cmbFilm.Text != "" || cmbPosition.Text != "" || cmbFilm.SelectedIndex > -1 || cmbPosition.SelectedIndex > -1)
                        {
                            //Film
                            if (cmbFilm.SelectedIndex > -1 || cmbFilm.Text != "")
                            {
                                if (lstComparator[i].productName.ToUpper().StartsWith(cmbFilm.Text.ToString().ToUpper()))
                                    flgOKFilm = true;
                            }
                            if (cmbFilm.Text == "" && cmbFilm.SelectedIndex == -1)
                                flgOKFilm = true;

                            //Position
                            if (cmbPosition.SelectedIndex > -1)
                            {
                                if (lstComparator[i].destination.ToUpper().StartsWith(cmbPosition.Text.ToString().ToUpper()))
                                    flgOKPosition = true;
                            }
                            if (cmbPosition.SelectedIndex == -1)
                                flgOKPosition = true;

                            if (flgOKFilm == true && flgOKPosition == true)
                                flgInclude = true;
                        }
                        else
                            flgInclude = true;

                        if (flgInclude == true)
                        {
                            palletCount++;

                            if (productCode == "")
                                productCode = (lstComparator.Count > 0) ? lstComparator[i].productName : "";

                            if (lstComparator[i].productName == productCode)
                            {
                                totalNetWeight += Math.Round(lstComparator[i].netWeight, 1);
                                totalPalletsByProduct++;
                            }
                            else
                            {
                                dgvDetails.Rows.Add();
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = productCode;
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(totalNetWeight, 1);
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDetail.Index].Value = global::BPS.Properties.Resources.clear;

                                for (int j = 0; j < dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells.Count; j++)
                                {
                                    Font fntBold = new Font(dgvDetails.Font, FontStyle.Bold);
                                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.Font = fntBold;
                                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.BackColor = Color.FromArgb(204, 204, 204);
                                }

                                productCode = lstComparator[i].productName;
                                totalNetWeight = Math.Round(lstComparator[i].netWeight, 1);
                                totalPalletsByProduct = 1;
                            }

                            dgvDetails.Rows.Add();
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCodsec.Index].Value = lstComparator[i].codsec;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clminventory.Index].Value = lstComparator[i].destination;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = lstComparator[i].productName;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmNetWeight.Index].Value = lstComparator[i].netWeight;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmgrossWeight.Index].Value = lstComparator[i].grossWeigth;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCellar.Index].Value = lstComparator[i].coilCellarName;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmPalletNumber.Index].Value = lstComparator[i].palletNumber;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCoilsNumber.Index].Value = lstComparator[i].coilCount.ToString();
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmnave.Index].Value = lstComparator[i].nave;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmpallet.Index].Value = lstComparator[i].code;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDetail.Index].Value = global::BPS.Properties.Resources.eye;
                            lastPosition = i;
                        }
                    }

                    if (lastPosition > -1)
                    {
                        dgvDetails.Rows.Add();
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = productCode;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(totalNetWeight, 1);
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDetail.Index].Value = global::BPS.Properties.Resources.clear;

                        for (int j = 0; j < dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells.Count; j++)
                        {
                            Font fntBold = new Font(dgvDetails.Font, FontStyle.Bold);
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.Font = fntBold;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.BackColor = Color.FromArgb(204, 204, 204);
                        }

                        productCode = lstComparator[lastPosition].productName;
                        totalNetWeight = Math.Round(lstComparator[lastPosition].netWeight, 1);
                        totalPalletsByProduct = 1;
                    }
                }

                lblTotalPallets.Text = palletCount.ToString();
                lblTotalWeight.Text = totalNetWeight.ToString();
                colorateByCoilCellar();
            }
        }
        #endregion

        #region Filtros

        private void cmbFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilm.SelectedIndex > -1)
                fillPalletInfo();
        }

        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPosition.SelectedIndex > -1)
                fillPalletInfo();
        }

        private void cmbFilm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }

        private void cmbPosition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }
        #endregion

        #region Acciones

        private void btnMainCoilClearFilters_Click(object sender, EventArgs e)
        {
            executeFilter = false;

            cmbFilm.SelectedIndex = -1;
            cmbFilm.Text = "";
            cmbPosition.SelectedIndex = -1;
            cmbPosition.Text = "";

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

        private void dgvDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmDetail.Index)
            {
                if (Convert.ToInt32(dgvDetails.Rows[e.RowIndex].Cells[clmCodsec.Index].Value) != 0)
                {
                    frmMillPalletDetail winPalletDetailTraceability = new frmMillPalletDetail(Convert.ToInt32(dgvDetails.Rows[e.RowIndex].Cells[clmCodsec.Index].Value), 0);
                    winPalletDetailTraceability.ShowDialog(this);
                }
            }
        }

        #endregion

    }
}
