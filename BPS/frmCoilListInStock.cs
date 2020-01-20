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
    public partial class frmCoilListInStock : Form
    {
        List<clsCoil> lstCoil = new List<clsCoil>();
        bool executeFilter = true;
        delegate void showLoading();
        delegate void HideLoading();

        showLoading showLoadImage;
        HideLoading hideLoadImage;

        private void loadMovements()
        {
            this.Invoke(showLoadImage);
            lstCoil = clsCoil.getCoilListInStock();
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
            List<string> lstProduct = new List<string>();
            List<string> lstCoilCellar = new List<string>();
            List<string> lstQuality = new List<string>();

            for (int i = 0; i < lstCoil.Count; i++)
            {
                //Film
                bool flgIsFilmInList = false;
                for (int j = 0; j < lstFilm.Count; j++)
                {
                    if (lstFilm[j] == lstCoil[i].ProductName)
                    {
                        flgIsFilmInList = true;
                        break;
                    }
                }
                if (flgIsFilmInList == false)
                    lstFilm.Add(lstCoil[i].ProductName);

                //Products
                bool flgIsProductInList = false;
                for (int j = 0; j < lstProduct.Count; j++)
                {
                    if (lstProduct[j] == lstCoil[i].ProductCode)
                    {
                        flgIsProductInList = true;
                        break;
                    }
                }
                if (flgIsProductInList == false)
                    lstProduct.Add(lstCoil[i].ProductCode);

                //Quality
                bool flgIsQualityInList = false;
                for (int j = 0; j < lstQuality.Count; j++)
                {
                    if (lstQuality[j] == lstCoil[i].CuttingQualityName)
                    {
                        flgIsQualityInList = true;
                        break;
                    }
                }
                if (flgIsQualityInList == false)
                    lstQuality.Add(lstCoil[i].CuttingQualityName);

                //Coil Cellar
                bool flgIsCoilCellar = false;
                for (int j = 0; j < lstCoilCellar.Count; j++)
                {
                    if (lstCoilCellar[j] == lstCoil[i].CellarCoil)
                    {
                        flgIsCoilCellar = true;
                        break;
                    }
                }
                if (flgIsCoilCellar == false)
                    lstCoilCellar.Add(lstCoil[i].CellarCoil);

            }
            lstFilm.Sort();
            lstProduct.Sort();
            lstQuality.Sort();
            lstCoilCellar.Sort();

            cmbFilm.Items.Clear();
            cmbProduct.Items.Clear();
            cmbQuality.Items.Clear();
           
            for (int i = 0; i < lstFilm.Count; i++)
                cmbFilm.Items.Add(lstFilm[i]);

            for (int i = 0; i < lstProduct.Count; i++)
                cmbProduct.Items.Add(lstProduct[i]);

            for (int i = 0; i < lstQuality.Count; i++)
                cmbQuality.Items.Add(lstQuality[i]);

            for (int i = 0; i < lstCoilCellar.Count; i++)
                lstbCoilCellar.Items.Add(lstCoilCellar[i]);

            grpbFilters.Enabled = true;
            pbxLoading.Visible = false;
            lblLoading.Visible = false;
        }

        public frmCoilListInStock()
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
                string productCode = "";
                int lastPosition = -1;

                dgvDetails.Rows.Clear();

                for (int i = 0; i < lstCoil.Count; i++)
                {
                    bool flgInclude = false;
                    bool flgOKFilm = false;
                    bool flgOKProduct = false;
                    bool flgOKCoilCellar = false;
                    bool flgOKWidth = false;
                    bool flgOKNetWeigth = false;
                    bool flgOKGrossWeigth = false;
                    bool flgOKCode = false;
                    bool flgOkQuality = false;

                    if (cmbFilm.Text != "" || cmbFilm.SelectedIndex > -1 || cmbProduct.Text != "" || cmbProduct.SelectedIndex > -1 || cmbQuality.Text != "" || cmbQuality.SelectedIndex > -1 || chkCoilCellar.Checked == true || (txtWidthFrom.Text != "" && txtWidthFrom.Text != "0") || (txtnetfrom.Text != "" && txtnetfrom.Text != "0") || (txtgrossfrom.Text != "" && txtgrossfrom.Text != "0" || txtcode.Text != ""))
                    {
                        //Film
                        if (cmbFilm.SelectedIndex > -1 || cmbFilm.Text != "")
                        {
                            if (lstCoil[i].ProductName.ToUpper().StartsWith(cmbFilm.Text.ToString().ToUpper()))
                                flgOKFilm = true;
                        }
                        if (cmbFilm.Text == "" && cmbFilm.SelectedIndex == -1)
                            flgOKFilm = true;

                        //Product
                        if (cmbProduct.SelectedIndex > -1 || cmbProduct.Text != "")
                        {
                            if (lstCoil[i].ProductCode.ToUpper().StartsWith(cmbProduct.Text.ToString().ToUpper()))
                                flgOKProduct = true;
                        }
                        if (cmbProduct.Text == "" && cmbProduct.SelectedIndex == -1)
                            flgOKProduct = true;

                        //Quality
                        if (cmbQuality.SelectedIndex > -1 || cmbQuality.Text != "")
                        {
                            if (lstCoil[i].CuttingQualityName.ToUpper().StartsWith(cmbQuality.Text.ToString().ToUpper()))
                                flgOkQuality = true;
                        }
                        if (cmbQuality.Text == "" && cmbQuality.SelectedIndex == -1)
                            flgOkQuality = true;

                        //Coil cellar
                        if (chkCoilCellar.Checked == true)
                        {
                            for (int j = 0; j < lstbCoilCellar.SelectedItems.Count; j++)
                            {
                                if (lstCoil[i].CellarCoil.ToUpper().StartsWith(lstbCoilCellar.SelectedItems[j].ToString().ToUpper()))
                                    flgOKCoilCellar = true;
                            }
                        }
                        else
                            flgOKCoilCellar = true;

                        //With
                        if (txtWidthFrom.Text != "" && txtWidthFrom.Text != "0")
                        {
                            if (txtWidthTo.Text != "" && txtWidthTo.Text != "0")
                            { 
                                if (lstCoil[i].width >= Convert.ToInt32(txtWidthFrom.Text) && lstCoil[i].width <= Convert.ToInt32(txtWidthTo.Text))
                                    flgOKWidth = true;
                            }
                            else
                            {
                                if (lstCoil[i].width == Convert.ToInt32(txtWidthFrom.Text))
                                    flgOKWidth = true;
                            }
                        }
                        else
                            flgOKWidth = true;

                        //Net Weigth
                        if (txtnetfrom.Text != "" && txtnetfrom.Text != "0")
                        {
                            if (txtnetto.Text != "" && txtnetto.Text != "0")
                            {
                                if (lstCoil[i].netWeight >= Convert.ToDouble(txtnetfrom.Text) && lstCoil[i].netWeight <= Convert.ToDouble(txtnetto.Text))
                                    flgOKNetWeigth = true;
                            }
                            else
                            {
                                if (lstCoil[i].netWeight.ToString().StartsWith(txtnetfrom.Text))
                                    flgOKNetWeigth = true;
                            }
                        }
                        else
                            flgOKNetWeigth = true;

                        //GrossWeigth
                        if (txtgrossfrom.Text != "" && txtgrossfrom.Text != "0")
                        {
                            if (txtgrossfrom.Text != "" && txtgrossto.Text != "0")
                            {
                                if (lstCoil[i].grossWeight >= Convert.ToDouble(txtgrossfrom.Text) && lstCoil[i].grossWeight <= Convert.ToDouble(txtgrossto.Text))
                                    flgOKGrossWeigth = true;
                            }
                            else
                            {
                                if (lstCoil[i].grossWeight.ToString().StartsWith(txtgrossfrom.Text))
                                    flgOKGrossWeigth = true;
                            }
                        }
                        else
                            flgOKGrossWeigth = true;

                        //Code
                        if (txtcode.Text != "")
                        {
                            if (lstCoil[i].code.ToUpper().StartsWith(txtcode.Text.ToString().ToUpper()))
                                flgOKCode = true;
                        }
                        if (txtcode.Text == "")
                            flgOKCode = true;

                        if (flgOKFilm == true && flgOKCode == true && flgOKCoilCellar == true && flgOKGrossWeigth == true && flgOKNetWeigth == true && flgOKWidth == true && flgOKProduct == true && flgOkQuality == true)
                            flgInclude = true;
                    }
                    else
                        flgInclude = true;


                    if (flgInclude == true)
                    {
                        if (i == 0)
                        {
                            productCode = (lstCoil.Count > 0) ? lstCoil[i].palletCode : "";
                            dgvDetails.Rows.Add();
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCodsec.Index].Value = lstCoil[i].codsec;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmproduct.Index].Value = lstCoil[i].ProductName;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCode.Index].Value = lstCoil[i].code;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = lstCoil[i].ProductCode;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmWidth.Index].Value = lstCoil[i].width;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(lstCoil[i].netWeight, 1).ToString();
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmGrossWeigth.Index].Value = Math.Round(lstCoil[i].grossWeight, 1).ToString();
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDiameter.Index].Value = lstCoil[i].diameter;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmLegth.Index].Value = lstCoil[i].length;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCellar.Index].Value = lstCoil[i].CellarCoil;
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDetail.Index].Value = global::BPS.Properties.Resources.eye;
                            lastPosition = i;
                        }
                        else
                        {
                            productCode = lstCoil[i].palletCode;
                            if (lstCoil[i - 1].palletCode == productCode)
                            {
                                dgvDetails.Rows.Add();
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCodsec.Index].Value = lstCoil[i].codsec;
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmproduct.Index].Value = lstCoil[i].ProductName;
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCode.Index].Value = lstCoil[i].code;
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = lstCoil[i].ProductCode;
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmWidth.Index].Value = lstCoil[i].width;
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(lstCoil[i].netWeight, 1).ToString();
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmGrossWeigth.Index].Value = Math.Round(lstCoil[i].grossWeight, 1).ToString();
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDiameter.Index].Value = lstCoil[i].diameter;
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmLegth.Index].Value = lstCoil[i].length;
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCellar.Index].Value = lstCoil[i].CellarCoil;
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDetail.Index].Value = global::BPS.Properties.Resources.eye;
                                lastPosition = i;
                            }
                            else
                            {
                                dgvDetails.Rows.Add();
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = lstCoil[i -1].ProductCode;
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCode.Index].Value = lstCoil[i - 1].palletCode;
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(lstCoil[i - 1].palletNetweight, 1);
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmGrossWeigth.Index].Value = Math.Round(lstCoil[i - 1].palletNetweight, 1);
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDetail.Index].Value = global::BPS.Properties.Resources.clear;

                                for (int j = 0; j < dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells.Count; j++)
                                {
                                    Font fntBold = new Font(dgvDetails.Font, FontStyle.Bold);
                                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.Font = fntBold;
                                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.BackColor = Color.FromArgb(204, 204, 204);
                                }
                                dgvDetails.Rows.Add();
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCodsec.Index].Value = lstCoil[i].codsec;
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmproduct.Index].Value = lstCoil[i].ProductName;
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCode.Index].Value = lstCoil[i].code;
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = lstCoil[i].ProductCode;
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmWidth.Index].Value = lstCoil[i].width;
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(lstCoil[i].netWeight, 1).ToString();
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmGrossWeigth.Index].Value = Math.Round(lstCoil[i].grossWeight, 1).ToString();
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDiameter.Index].Value = lstCoil[i].diameter;
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmLegth.Index].Value = lstCoil[i].length;
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCellar.Index].Value = lstCoil[i].CellarCoil;
                                dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDetail.Index].Value = global::BPS.Properties.Resources.eye;
                                lastPosition = i;
                            }

                        }
                    }
                }

                if (lastPosition > -1)
                {
                    dgvDetails.Rows.Add();
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = lstCoil[lastPosition].ProductCode;
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCode.Index].Value = lstCoil[lastPosition].palletCode;
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(lstCoil[lastPosition].palletNetweight, 1);
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmGrossWeigth.Index].Value = Math.Round(lstCoil[lastPosition].palletNetweight, 1);
                    dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDetail.Index].Value = global::BPS.Properties.Resources.clear;

                    for (int j = 0; j < dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells.Count; j++)
                    {
                        Font fntBold = new Font(dgvDetails.Font, FontStyle.Bold);
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.Font = fntBold;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[j].Style.BackColor = Color.FromArgb(204, 204, 204);
                    }
                }
            }
        }

        private void frmCoilListInStock_Load(object sender, EventArgs e)
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

        private void btnMainCoilClearFilters_Click(object sender, EventArgs e)
        {
            executeFilter = false;
            cmbFilm.SelectedIndex = -1;
            cmbFilm.Text = "";
            cmbProduct.SelectedIndex = -1;
            cmbProduct.Text = "";
            cmbQuality.Text = "";
            cmbQuality.SelectedIndex = -1;
            chkCoilCellar.Checked = false;
            txtWidthFrom.Clear();
            txtWidthTo.Clear();
            txtnetfrom.Clear();
            txtnetto.Clear();
            txtgrossfrom.Clear();
            txtgrossto.Clear();
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
                    frmCoilDetail winPalletDetailTraceability = new frmCoilDetail(dgvDetails.Rows[e.RowIndex].Cells[clmCode.Index].Value.ToString());
                    winPalletDetailTraceability.ShowDialog(this);
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

        private void txtcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }

        private void cmbFilm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }

        private void cmbQuality_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillPalletInfo();
        }

        private void cmbQuality_KeyDown(object sender, KeyEventArgs e)
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
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }

        private void txtnetfrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }

        private void txtnetto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }

        private void txtgrossfrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }

        private void txtgrossto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }
    }
}
