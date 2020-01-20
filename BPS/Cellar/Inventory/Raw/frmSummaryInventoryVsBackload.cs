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
using BPS.Raw;

namespace BPS.Cellar.Inventory.Raw
{
    public partial class frmSummaryInventoryVsBackload : Form
    {
        #region Parametros
        List<clsComparator> lstComparator = new List<clsComparator>();
        int codsec = 0;
        bool executeFilter = true;
        public double palletTotalWeight { get; set; }
        delegate void showLoading();
        delegate void HideLoading();

        showLoading showLoadImage;
        HideLoading hideLoadImage;
        #endregion

        #region Inicio
        private void loadMovements()
        {
            this.Invoke(showLoadImage);
            lstComparator = clsComparator.getComparatorShortRaw(codsec);
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

            List<string> lstTmp = new List<string>();
            List<string> lstProv = new List<string>();
            List<string> lstCoilCellar = new List<string>();
            List<string> lstPosition = new List<string>();

            lstTmp = lstComparator.Select(p => p.salesOrderNumber).Distinct().ToList();
            lstProv = lstComparator.Select(p => p.origin).Distinct().ToList();
            lstCoilCellar = lstComparator.Select(p => p.coilCellarName).Distinct().ToList();
            lstPosition = lstComparator.Select(p => p.destination).Distinct().ToList();

            lstTmp.Sort();
            lstProv.Sort();
            lstCoilCellar.Sort();
            lstPosition.Sort();

            for (int i = 0; i < lstTmp.Count; i++)
                cmbFilm.Items.Add(lstTmp[i]);


            for (int i = 0; i < lstProv.Count; i++)
                cmbProv.Items.Add(lstProv[i]);

            for (int i = 0; i < lstPosition.Count; i++)
                cmbPosition.Items.Add(lstPosition[i]);

            for (int i = 0; i < lstCoilCellar.Count; i++)
                lstbCoilCellar.Items.Add(lstCoilCellar[i]);

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

        private void chkColorCoilCellar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkColorCoilCellar.Checked == true)
                grpbColorCode.Visible = true;
            else
                grpbColorCode.Visible = false;

            colorateByCoilCellar();
        }
        #endregion

        #region Fill Data

        private void fillPalletInfo()
        {
            int palletCount = 0;
            double totalNetWeight = 0;

            if (this.InvokeRequired)
            {
                fillPalletInfoDelegate pop = new fillPalletInfoDelegate(fillPalletInfo);
                this.Invoke(pop);
            }
            else
            {
                if (executeFilter == true)
                {
                    int lastPosition = -1;
                    string productCode = "";
                    int totalPalletsByProduct = 0;

                    dgvDetails.Rows.Clear();

                    for (int i = 0; i < lstComparator.Count; i++)
                    {
                        bool flgInclude = false;
                        bool flgOKFilm = false;
                        bool flgOKProv = false;
                        bool flgOKCoilCellar = false;
                        bool flgOKPosition = false;

                        if (cmbFilm.Text != "" || cmbProv.Text != "" || cmbFilm.SelectedIndex > -1 || cmbProv.SelectedIndex > -1 ||
                            chkCoilCellar.Checked == true || cmbPosition.SelectedIndex > -1 || cmbPosition.Text != "")
                        {
                            //Film
                            if (cmbFilm.SelectedIndex > -1 || cmbFilm.Text != "")
                            {
                                if (lstComparator[i].salesOrderNumber.ToUpper().StartsWith(cmbFilm.Text.ToString().ToUpper()))
                                    flgOKFilm = true;
                            }
                            if (cmbFilm.Text == "" && cmbFilm.SelectedIndex == -1)
                                flgOKFilm = true;

                            //Proveedor
                            if (cmbProv.SelectedIndex > -1)
                            {
                                if (lstComparator[i].origin.ToUpper() == cmbProv.SelectedItem.ToString().ToUpper())
                                    flgOKProv = true;
                            }
                            if (cmbProv.SelectedIndex == -1)
                                flgOKProv = true;

                            //Position
                            if (cmbPosition.SelectedIndex > -1)
                            {
                                if (lstComparator[i].destination.ToUpper().StartsWith(cmbPosition.Text.ToString().ToUpper()))
                                    flgOKPosition = true;
                            }
                            if (cmbPosition.SelectedIndex == -1)
                                flgOKPosition = true;

                            //Coil cellar
                            if (chkCoilCellar.Checked == true)
                            {
                                for (int j = 0; j < lstbCoilCellar.SelectedItems.Count; j++)
                                {
                                    if (lstComparator[i].coilCellarName.ToUpper().StartsWith(lstbCoilCellar.SelectedItems[j].ToString().ToUpper()))
                                        flgOKCoilCellar = true;
                                }
                            }
                            else
                                flgOKCoilCellar = true;

                            if (flgOKFilm == true && flgOKProv == true && flgOKPosition == true && flgOKCoilCellar == true)
                                flgInclude = true;
                        }
                        else
                            flgInclude = true;

                        if (flgInclude == true)
                        {
                            palletCount++;
                            palletTotalWeight += Math.Round(lstComparator[i].netWeight, 1);

                            if (productCode == "")
                                productCode = (lstComparator.Count > 0) ? lstComparator[i].salesOrderNumber : "";

                            if (lstComparator[i].salesOrderNumber == productCode)
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

                                productCode = lstComparator[i].salesOrderNumber;
                                totalNetWeight = Math.Round(lstComparator[i].netWeight, 1);
                                totalPalletsByProduct = 1;
                            }

                            dgvDetails.Rows.Add();
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCodsec.Index].Value = lstComparator[i].codsec;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clminventory.Index].Value = lstComparator[i].destination;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmprov.Index].Value = lstComparator[i].origin;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmtmp.Index].Value = lstComparator[i].salesOrderNumber;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = lstComparator[i].productName;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmNetWeight.Index].Value = lstComparator[i].netWeight;
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

                        productCode = lstComparator[lastPosition].salesOrderNumber;
                        totalNetWeight = Math.Round(lstComparator[lastPosition].netWeight, 1);
                        totalPalletsByProduct = 1;
                    }
                }

                lblTotalPallets.Text = palletCount.ToString();
                lblTotalWeight.Text = palletTotalWeight.ToString();

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

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProv.SelectedIndex > -1)
                fillPalletInfo();
        }

        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPosition.SelectedIndex > -1)
                fillPalletInfo();
        }

        private void chkCoilCellar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCoilCellar.Checked == false)
                lstbCoilCellar.ClearSelected();

            fillPalletInfo();
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

        private void cmbPosition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
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
        #endregion

        #region Acciones

        private void btnMainCoilClearFilters_Click(object sender, EventArgs e)
        {
            executeFilter = false;

            cmbFilm.SelectedIndex = -1;
            cmbFilm.Text = "";
            cmbProv.SelectedIndex = -1;
            cmbProv.Text = "";
            cmbPosition.Text = "";
            cmbPosition.SelectedIndex = -1;
            chkCoilCellar.Checked = false;

            executeFilter = true;

            fillPalletInfo();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvDetails.Rows.Clear();
            Thread td = new Thread(new ThreadStart(this.loadMovements));
            td.Start();
        }

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

        #endregion
    }
}
