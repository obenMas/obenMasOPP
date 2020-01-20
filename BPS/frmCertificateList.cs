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
using BPS.Certificate.Report;

namespace BPS
{
    public partial class frmCertificateList : Form
    {
        List<clsCertificate> lstCertificate = new List<clsCertificate>();
        bool executeFilter = true;
        delegate void showLoading();
        delegate void HideLoading();

        showLoading showLoadImage;
        HideLoading hideLoadImage;

        private void loadMovements()
        {
            this.Invoke(showLoadImage);
            lstCertificate = clsCertificate.getPopulateList();
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
            List<string> lstLotNumber = new List<string>();

            for (int i = 0; i < lstCertificate.Count; i++)
            {
                //Products
                bool flgIsProductInList = false;
                for (int j = 0; j < lstProducts.Count; j++)
                {
                    if (lstProducts[j] == lstCertificate[i].Bopp)
                    {
                        flgIsProductInList = true;
                        break;
                    }
                }
                if (flgIsProductInList == false)
                    lstProducts.Add(lstCertificate[i].Bopp);


                //Widths
                bool flgIsWidthInList = false;
                for (int j = 0; j < lstLotNumber.Count; j++)
                {
                    if (lstLotNumber[j] == lstCertificate[i].LotNumber)
                    {
                        flgIsWidthInList = true;
                        break;
                    }
                }
                if (flgIsWidthInList == false)
                    lstLotNumber.Add(lstCertificate[i].LotNumber);


                //Customers
                bool flgIsCustomerInList = false;
                for (int j = 0; j < lstCustomers.Count; j++)
                {
                    if (lstCustomers[j] == lstCertificate[i].Company)
                    {
                        flgIsCustomerInList = true;
                        break;
                    }
                }
                if (flgIsCustomerInList == false)
                    lstCustomers.Add(lstCertificate[i].Company);


                //Sales Order Number
                bool flgIsSalesOrderNumberInList = false;
                for (int j = 0; j < lstSalesOrderNumber.Count; j++)
                {
                    if (lstSalesOrderNumber[j] == lstCertificate[i].OrderNumber)
                    {
                        flgIsSalesOrderNumberInList = true;
                        break;
                    }
                }
                if (flgIsSalesOrderNumberInList == false)
                    lstSalesOrderNumber.Add(lstCertificate[i].OrderNumber);
            }

            lstProducts.Sort();
            lstCustomers.Sort();
            lstSalesOrderNumber.Sort();
            lstLotNumber.Sort();

            cmbFilm.Items.Clear();
            cmbCustomer.Items.Clear();
            cmbOrder.Items.Clear();
            cmbLotNumber.Items.Clear();

            for (int i = 0; i < lstProducts.Count; i++)
                cmbFilm.Items.Add(lstProducts[i]);

            for (int i = 0; i < lstCustomers.Count; i++)
                cmbCustomer.Items.Add(lstCustomers[i]);

            for (int i = 0; i < lstSalesOrderNumber.Count; i++)
                cmbOrder.Items.Add(lstSalesOrderNumber[i]);

            for (int i = 0; i < lstLotNumber.Count; i++)
                cmbLotNumber.Items.Add(lstLotNumber[i]);

            grpbFilters.Enabled = true;
            pbxLoading.Visible = false;
            lblLoading.Visible = false;
        }

        public frmCertificateList()
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

                for (int i = 0; i < lstCertificate.Count; i++)
                {
                    bool flgInclude = false;
                    bool flgOKFilm = false;
                    bool flgOKCustomer = false;
                    bool flgOKSalesOrder = false;
                    bool flgOKExtrusionDate = false;
                    bool flgOKLotNumber = false;

                    if (cmbLotNumber.Text != "" || cmbFilm.Text != "" || cmbCustomer.Text != "" || cmbOrder.Text != "" || cmbFilm.SelectedIndex > -1 || cmbCustomer.SelectedIndex > -1 || cmbOrder.SelectedIndex > -1 || cmbLotNumber.SelectedIndex > -1 || chkExtrusionDate.Checked == true)
                    {
                        //Film
                        if (cmbFilm.SelectedIndex > -1 || cmbFilm.Text != "")
                        {
                            if (lstCertificate[i].Bopp.ToUpper().StartsWith(cmbFilm.Text.ToString().ToUpper()))
                                flgOKFilm = true;
                        }
                        if (cmbFilm.Text == "" && cmbFilm.SelectedIndex == -1)
                            flgOKFilm = true;


                        //Origin
                        if (cmbLotNumber.SelectedIndex > -1)
                        {
                            if (lstCertificate[i].LotNumber.StartsWith(cmbLotNumber.Text))
                                flgOKLotNumber = true;
                        }
                        if (cmbLotNumber.SelectedIndex == -1)
                            flgOKLotNumber = true;

                        //Customer
                        if (cmbCustomer.SelectedIndex > -1 || cmbCustomer.Text != "")
                        {
                            if (lstCertificate[i].Company.ToUpper().StartsWith(cmbCustomer.Text.ToString().ToUpper()))
                                flgOKCustomer = true;
                        }
                        if (cmbCustomer.Text == "" && cmbCustomer.SelectedIndex == -1)
                            flgOKCustomer = true;

                        //Sales Order
                        if (cmbOrder.Text != "" || cmbOrder.SelectedIndex > -1)
                        {
                            if (lstCertificate[i].OrderNumber.StartsWith(cmbOrder.Text))
                                flgOKSalesOrder = true;
                        }
                        if (cmbOrder.Text == "" && cmbOrder.SelectedIndex == -1)
                            flgOKSalesOrder = true;

                        //Extrusion Date
                        if (chkExtrusionDate.Checked == true)
                        {
                            if (lstCertificate[i].createdDateDate >= dtpInitDate.Value && lstCertificate[i].createdDateDate <= dtpEndDate.Value)
                            {
                                flgOKExtrusionDate = true;
                            }
                        }
                        else
                            flgOKExtrusionDate = true;

                        if (flgOKFilm == true && flgOKCustomer == true && flgOKSalesOrder == true && flgOKExtrusionDate == true && flgOKLotNumber == true)
                            flgInclude = true;
                    }
                    else
                        flgInclude = true;

                    if (flgInclude == true)
                    {
                        dgvDetails.Rows.Add();
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCodsec.Index].Value = lstCertificate[i].codsec;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = lstCertificate[i].Bopp;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmSalesOrder.Index].Value = lstCertificate[i].OrderNumber;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCustomer.Index].Value = lstCertificate[i].Company;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmLotNumber.Index].Value = lstCertificate[i].LotNumber;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmfkBopp.Index].Value = lstCertificate[i].FilmName;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCreatedDate.Index].Value = lstCertificate[i].createdDateDate.ToShortDateString();
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmReport.Index].Value = global::BPS.Properties.Resources.report;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmdelete.Index].Value = global::BPS.Properties.Resources.cross;
                    }
                }
            }
        }

        private void frmCertificateList_Load(object sender, EventArgs e)
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
            cmbCustomer.Text = "";
            cmbOrder.SelectedIndex = -1;
            cmbOrder.Text = "";
            cmbLotNumber.SelectedIndex = -1;
            cmbLotNumber.Text = "";
            chkExtrusionDate.Checked = false;
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

        private void cmbOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }

        private void dgvDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmReport.Index)
            {
                if (Convert.ToInt32(dgvDetails.Rows[e.RowIndex].Cells[clmCodsec.Index].Value) != 0 && !string.IsNullOrEmpty(dgvDetails.Rows[e.RowIndex].Cells[clmfkBopp.Index].Value.ToString()))
                    setCertificate(Convert.ToInt32(dgvDetails.Rows[e.RowIndex].Cells[clmCodsec.Index].Value), dgvDetails.Rows[e.RowIndex].Cells[clmfkBopp.Index].Value.ToString());
                else
                    MessageBox.Show("Película no asignada", "Certificados", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
            if (e.ColumnIndex == clmdelete.Index)
            {
                if (MessageBox.Show("Esta realmente seguro que desea eliminar el certificado seleccionado?", "Certificados", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                {
                    if (clsCertificate.toDelete(Convert.ToInt32(dgvDetails.Rows[e.RowIndex].Cells[clmCodsec.Index].Value)))
                    {
                        MessageBox.Show("Certificado Eliminado Correctamente", "Certificados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        dgvDetails.Rows.Clear();
                        Thread td = new Thread(new ThreadStart(this.loadMovements));
                        td.Start();
                    }
                    else
                        MessageBox.Show("Certificado NO Eliminado", "Certificados", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
            }
        }

        private void setCertificate(int codsec, string film)
        {
            if (film.StartsWith("SC"))
            {
                frmCertificateSC winSC = new frmCertificateSC(codsec, clsGlobal.password);
                winSC.ShowDialog(this.MdiParent);
            }

            if (film.StartsWith("SD0"))
            {
                frmCertificateSD winSC = new frmCertificateSD(codsec, clsGlobal.password);
                winSC.ShowDialog(this.MdiParent);
            }

            if (film.StartsWith("FH"))
            {
                frmCertificateFH winSC = new frmCertificateFH(codsec, clsGlobal.password);
                winSC.ShowDialog(this.MdiParent);
            }

            if (film.StartsWith("FCH"))
            {
                frmCertificateFCH winSC = new frmCertificateFCH(codsec, clsGlobal.password);
                winSC.ShowDialog(this.MdiParent);
            }

            if (film.StartsWith("FHe"))
            {
                frmCertificateFHE winFhe = new frmCertificateFHE(codsec, clsGlobal.password);
                winFhe.ShowDialog(this.MdiParent);
            }

            if (film.StartsWith("PC") || film.StartsWith("OC"))
            {
                frmCertificatePC winPC = new frmCertificatePC(codsec, clsGlobal.password);
                winPC.ShowDialog(this.MdiParent);
            }

            if (film.StartsWith("PCx") || film.StartsWith("BD"))
            {
                frmCertificatePCX winPCX = new frmCertificatePCX(codsec, clsGlobal.password);
                winPCX.ShowDialog(this.MdiParent);
            }

            if (film.StartsWith("PL"))
            {
                frmCertificatePL winPL = new frmCertificatePL(codsec, clsGlobal.password);
                winPL.ShowDialog(this.MdiParent);
            }

            if (film == "OH020TT" || film == "OH040TT" || film == "OH060TT" || film == "OH080TT" || film == "OH010TT" || film == "OH090TT" || film == "OH100TT" || film == "OH120TT")
            {
                frmCertificateOHTT winLH = new frmCertificateOHTT(codsec, clsGlobal.password);
                winLH.ShowDialog(this.MdiParent);
            }

            if (film.StartsWith("OH"))
            {
                frmCertificateOH winOH = new frmCertificateOH(codsec, clsGlobal.password);
                winOH.ShowDialog(this.MdiParent);
            }

            if (film.StartsWith("OHx"))
            {
                frmCertificateOHX winOHX = new frmCertificateOHX(codsec, clsGlobal.password);
                winOHX.ShowDialog(this.MdiParent);
            }

            if (film.StartsWith("WC"))
            {
                frmCertificateWC winWC = new frmCertificateWC(codsec, clsGlobal.password);
                winWC.ShowDialog(this.MdiParent);
            }
            else if (film == "QC023" || film == "QC030" || film == "QC035" || film == "QC040" || film == "QC025")
            {
                frmCertificateQC winQC = new frmCertificateQC(codsec, clsGlobal.password);
                winQC.ShowDialog(this.MdiParent);
            }
            else if (film == "MA015" || film == "MA017" || film == "MA020" || film == "MA030" || film == "MA025" || film == "MC015" || film == "MC017" || film == "MC020" || film == "MC025" || film == "MC030" || film == "MC035" || film == "MC040" || film == "MC045" || film == "MC050" || film == "MC055" || film == "MC060" || film == "MC065" || film == "MC020" || film == "MC070" || film == "MC018" || film == "MQC023" || film == "MQC025" || film == "MQC027" || film == "MQC037" || film == "MQC040" || film == "MQC045")
            {
                frmCertificateMA winMA = new frmCertificateMA(codsec, clsGlobal.password);
                winMA.ShowDialog(this.MdiParent);
            }
            else if (film == "MOHH036" || film == "MOHH040")
            {
                frmCertificateMOHH winMOHH = new frmCertificateMOHH(codsec, clsGlobal.password);
                winMOHH.ShowDialog(this.MdiParent);
            }
            else if (film == "MOHH035D" || film == "MOHH036D" || film == "MOHH040D")
            {
                frmCertificateMOHHD winMOHHD = new frmCertificateMOHHD(codsec, clsGlobal.password);
                winMOHHD.ShowDialog(this.MdiParent);
            }
            else if (film == "MC023D" || film == "MC020D" || film == "MC017D" || film == "MC025D" || film == "MC030D")
            {
                frmCertificateMCD winMCD = new frmCertificateMCD(codsec, clsGlobal.password);
                winMCD.ShowDialog(this.MdiParent);
            }
            else if (film.StartsWith("TH"))
            {
                frmCertificateTH winTH = new frmCertificateTH(codsec, clsGlobal.password);
                winTH.ShowDialog(this.MdiParent);
            }
            else if (film == "LH015TT" || film == "LH017TT" || film == "LH020TT" || film == "LH025TT" || film == "LH030TT")
            {
                frmCertificateLHTT winLHTT = new frmCertificateLHTT(codsec, clsGlobal.password);
                winLHTT.ShowDialog(this.MdiParent);
            }
            else if (film.StartsWith("LH"))
            {
                frmCertificateLH winLH = new frmCertificateLH(codsec, clsGlobal.password);
                winLH.ShowDialog(this.MdiParent);
            }
            else if (film == "ODH020TT" || film == "ODH050TT" || film == "ODH060TT" || film == "ODH080TT" || film == "PDH060TT" || film == "PDH080TT" || film == "PDH100TT" || film == "PDH120TT")
            {
                frmCertificateODPH winLH = new frmCertificateODPH(codsec, clsGlobal.password);
                winLH.ShowDialog(this.MdiParent);
            }
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

        private void cmbAntique_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillPalletInfo();
        }

        private void cmbAntique_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }

        private void cmbLotNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillPalletInfo();
        }

        private void cmbLotNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }
    }
}
