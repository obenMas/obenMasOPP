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
    public partial class frmDeadTimeByFilmProductionPlan : Form    
    {
        List<clsFilmProductionPlanByProductionOrder> lstFilmProductionPlanByProductionOrder = new List<clsFilmProductionPlanByProductionOrder>();
        int machine = 0;
        bool executeFilter = true;
        delegate void showLoading();
        delegate void HideLoading();
        showLoading showLoadImage;
        HideLoading hideLoadImage;

        private void loadMovements()
        {
            this.Invoke(showLoadImage);
            lstFilmProductionPlanByProductionOrder = clsFilmProductionPlanByProductionOrder.getListActiveOrderByMachine(machine);
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
            List<string> lstLotNumber = new List<string>();
            List<string> lstWidths = new List<string>();
            List<string> lstDeadTime = new List<string>();

            for (int i = 0; i < lstFilmProductionPlanByProductionOrder.Count; i++)
            {
                //Film
                bool flgIsFilmInList = false;
                for (int j = 0; j < lstFilm.Count; j++)
                {
                    if (lstFilm[j] == lstFilmProductionPlanByProductionOrder[i].BoppCode.Replace("-",""))
                    {
                        flgIsFilmInList = true;
                        break;
                    }
                }
                if (flgIsFilmInList == false)
                    lstFilm.Add(lstFilmProductionPlanByProductionOrder[i].BoppCode.Replace("-", ""));

                //LotNumber
                bool flgIsLotNumberInList = false;
                for (int j = 0; j < lstLotNumber.Count; j++)
                {
                    if (lstLotNumber[j] == lstFilmProductionPlanByProductionOrder[i].lotNumber)
                    {
                        flgIsLotNumberInList = true;
                        break;
                    }
                }
                if (flgIsLotNumberInList == false)
                    lstLotNumber.Add(lstFilmProductionPlanByProductionOrder[i].lotNumber);
                
                //Widths
                bool flgIsWidthInList = false;
                for (int j = 0; j < lstWidths.Count; j++)
                {
                    if (lstWidths[j] == lstFilmProductionPlanByProductionOrder[i].widths)
                    {
                        flgIsWidthInList = true;
                        break;
                    }
                }
                if (flgIsWidthInList == false)
                    lstWidths.Add(lstFilmProductionPlanByProductionOrder[i].widths);

                //DeadTime
                lstDeadTime.Add("Orden sin Tiempos Muertos");
                lstDeadTime.Add("Orden en Producción sin Tiempos Muertos");
                lstDeadTime.Add("Orden Cerrada con Tiempos Muertos");
            }

            lstFilm.Sort();
            lstLotNumber.Sort();
            lstWidths.Sort();
            lstDeadTime = lstDeadTime.Distinct().ToList();

            for (int i = 0; i < lstFilm.Count; i++)
                cmbFilm.Items.Add(lstFilm[i]);


            for (int i = 0; i < lstLotNumber.Count; i++)
                cmbLotnumber.Items.Add(lstLotNumber[i]);

            for (int i = 0; i < lstWidths.Count; i++)
                cmbOrder.Items.Add(lstWidths[i]);

            for (int i = 0; i < lstDeadTime.Count; i++)
                cmbAntique.Items.Add(lstDeadTime[i]);

            grpbFilters.Enabled = true;
            pbxLoading.Visible = false;
            lblLoading.Visible = false;
        }

        public void colorateByCoilCellar()
        {
            if (chkColorDeadTime.Checked == true)
            {
                for (int i = 0; i < dgvDetails.Rows.Count; i++)
                {
                    if (dgvDetails.Rows[i].Cells[clmDeadTime.Index].Value != null)
                    {
                        switch (dgvDetails.Rows[i].Cells[clmDeadTime.Index].Value.ToString())
                        {
                            
                            default:
                                if (dgvDetails.Rows[i].Cells[clmDeadTime.Index].Value.ToString() == "-----" && dgvDetails.Rows[i].Cells[clmStatusName.Index].Value.ToString() == "En producción")
                                {
                                    for (int j = 0; j < dgvDetails.Columns.Count; j++)
                                        dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(232, 202, 244);
                                    break;
                                }
                                else if (dgvDetails.Rows[i].Cells[clmDeadTime.Index].Value.ToString() != "-----" && dgvDetails.Rows[i].Cells[clmStatusName.Index].Value.ToString() == "En producción")
                                {
                                    for (int j = 0; j < dgvDetails.Columns.Count; j++)
                                        dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(232, 202, 244);
                                    break;
                                }
                                else if (dgvDetails.Rows[i].Cells[clmDeadTime.Index].Value.ToString() == "-----" && dgvDetails.Rows[i].Cells[clmStatusName.Index].Value.ToString() == "Cerrada")
                                {
                                    for (int j = 0; j < dgvDetails.Columns.Count; j++)
                                        dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(207, 234, 254);
                                    break;
                                }

                                else if (dgvDetails.Rows[i].Cells[clmDeadTime.Index].Value.ToString() != "-----" && dgvDetails.Rows[i].Cells[clmStatusName.Index].Value.ToString() == "Cerrada")
                                {
                                    for (int j = 0; j < dgvDetails.Columns.Count; j++)
                                        dgvDetails.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(176, 247, 182);
                                    break;
                                }
                                break;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < dgvDetails.Rows.Count; i++)
                {
                    if (dgvDetails.Rows[i].Cells[clmDeadTime.Index].Value != null)
                    {
                        if (dgvDetails.Rows[i].Cells[clmDeadTime.Index].Value.ToString() != "")
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

        public frmDeadTimeByFilmProductionPlan()
        {
            InitializeComponent();
            getFilmProductionPlanList();
        }

        public frmDeadTimeByFilmProductionPlan(int machine)
        {
            InitializeComponent();
            this.machine = machine;
            getFilmProductionPlanList();
        }

        private void getFilmProductionPlanList()
        {
            showLoadImage = new showLoading(showLoadingDelegate);
            hideLoadImage = new HideLoading(hideLoadingDelegate);
        }

        private void fillPalletInfo()
        {
            int OrderUnDeadTime = 0, OrderInProdcution = 0, OrderCloseOk = 0;
            
            if (executeFilter == true)
            {
                dgvDetails.Rows.Clear();
                for (int i = 0; i < lstFilmProductionPlanByProductionOrder.Count; i++)
                {
                    bool flgInclude = false;
                    bool flgOKFilm = false;
                    bool flgOKLotNumber = false;
                    bool flgOKWidths = false;
                    bool flgOKDeadTime = false;
                    bool flgOKExtrusionDate = false;
                    if (cmbFilm.Text != "" || cmbLotnumber.Text != "" || cmbOrder.Text != "" || cmbFilm.SelectedIndex > -1 || cmbLotnumber.SelectedIndex > -1 || cmbOrder.SelectedIndex > -1 || cmbAntique.SelectedIndex > -1 || chkExtrusionDate.Checked == true || cmbAntique.SelectedIndex > -1 || cmbAntique.Text != string.Empty)
                    {
                        //Film
                        if (cmbFilm.SelectedIndex > -1 || cmbFilm.Text != "")
                        {
                            if (lstFilmProductionPlanByProductionOrder[i].BoppCode.ToUpper().StartsWith(cmbFilm.Text.ToString().ToUpper()))
                                flgOKFilm = true;
                        }
                        if (cmbFilm.Text == string.Empty && cmbFilm.SelectedIndex == -1)
                            flgOKFilm = true;

                        //LotNumber
                        if (cmbLotnumber.SelectedIndex > -1 || cmbLotnumber.Text != "")
                        {
                            if (lstFilmProductionPlanByProductionOrder[i].lotNumber.ToUpper().StartsWith(cmbLotnumber.Text.ToString().ToUpper()))
                                flgOKLotNumber = true;
                        }
                        if (cmbLotnumber.Text == string.Empty && cmbLotnumber.SelectedIndex == -1)
                            flgOKLotNumber = true;

                        //Widths
                        if (cmbOrder.SelectedIndex > -1 || cmbOrder.Text != "")
                        {
                            if (lstFilmProductionPlanByProductionOrder[i].widths.ToUpper().StartsWith(cmbOrder.Text.ToString().ToUpper()))
                                flgOKWidths = true;
                        }
                        if (cmbOrder.Text == "" && cmbOrder.SelectedIndex == -1)
                            flgOKWidths = true;

                        //DeatTime
                        if (cmbAntique.SelectedIndex > -1)
                        {
                            if (lstFilmProductionPlanByProductionOrder[i].deadtime == 0 && cmbAntique.SelectedItem.ToString() == "Orden sin Tiempos Muertos")
                                flgOKDeadTime = true;
                            else if (lstFilmProductionPlanByProductionOrder[i].deadtime == 0 && cmbAntique.SelectedIndex == 1 && lstFilmProductionPlanByProductionOrder[i].StatusName == "En producción")
                                flgOKDeadTime = true;
                            else if (lstFilmProductionPlanByProductionOrder[i].deadtime != 0 && cmbAntique.SelectedIndex == 1 && lstFilmProductionPlanByProductionOrder[i].StatusName == "En producción")
                                flgOKDeadTime = true;
                            else if (lstFilmProductionPlanByProductionOrder[i].deadtime != 0 && cmbAntique.SelectedIndex == 2 && lstFilmProductionPlanByProductionOrder[i].StatusName == "Cerrada")
                                flgOKDeadTime = true;
                        }
                        if (cmbAntique.SelectedIndex == -1)
                            flgOKDeadTime = true;

                        //Extrusion Date
                        if (chkExtrusionDate.Checked == true)
                        {
                            if (lstFilmProductionPlanByProductionOrder[i].initDate >= dtpInitDate.Value && lstFilmProductionPlanByProductionOrder[i].initDate <= dtpEndDate.Value)
                                flgOKExtrusionDate = true;
                        }
                        else
                            flgOKExtrusionDate = true;

                        if (flgOKFilm == true && flgOKLotNumber == true && flgOKWidths == true && flgOKDeadTime == true && flgOKExtrusionDate == true)
                            flgInclude = true;
                    }
                    else
                        flgInclude = true;

                    if (flgInclude == true)
                    {
                        if (lstFilmProductionPlanByProductionOrder[i].deadtime == 0 && lstFilmProductionPlanByProductionOrder[i].StatusName == "Cerrada")
                            OrderUnDeadTime++;
                        else if (lstFilmProductionPlanByProductionOrder[i].deadtime != 0 && lstFilmProductionPlanByProductionOrder[i].StatusName == "En producción")
                            OrderInProdcution++;
                        else if (lstFilmProductionPlanByProductionOrder[i].deadtime != 0 && lstFilmProductionPlanByProductionOrder[i].StatusName == "Cerrada")
                            OrderCloseOk++;

                        dgvDetails.Rows.Add();
                        if (lstFilmProductionPlanByProductionOrder[i].fkBopp > 0)
                        {
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmtypefilm.Index].Value = "BOPP";
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = lstFilmProductionPlanByProductionOrder[i].BoppCode;
                        }
                        else
                        {
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmtypefilm.Index].Value = "CAST";
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmFilm.Index].Value = lstFilmProductionPlanByProductionOrder[i].castCode;
                        }
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmLotNumber.Index].Value = lstFilmProductionPlanByProductionOrder[i].lotNumber;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmWidth.Index].Value = lstFilmProductionPlanByProductionOrder[i].widths;
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmInitDate.Index].Value = lstFilmProductionPlanByProductionOrder[i].initDate.ToString();
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmEndDate.Index].Value = lstFilmProductionPlanByProductionOrder[i].endDate.ToString();
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmStatusName.Index].Value = lstFilmProductionPlanByProductionOrder[i].StatusName;
                        if (lstFilmProductionPlanByProductionOrder[i].deadtime == 0)
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDeadTime.Index].Value = "-----";
                        else
                            dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDeadTime.Index].Value = lstFilmProductionPlanByProductionOrder[i].deadtime;

                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmCodsec.Index].Value = lstFilmProductionPlanByProductionOrder[i].fkProductionOrder.ToString();
                        dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[clmDetail.Index].Value = global::BPS.Properties.Resources.eye;
                    }
                }
            }

            lblOrderUnDeadTime.Text = OrderUnDeadTime.ToString();
            lblOrderInProduction.Text = OrderInProdcution.ToString();
            lblOrderCloseOK.Text = OrderCloseOk.ToString();
            colorateByCoilCellar();
        }

        private void frmDeadTimeByFilmProductionPlan_Load(object sender, EventArgs e)
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

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnMainCoilClearFilters_Click(object sender, EventArgs e)
        {
            executeFilter = false;
            cmbFilm.SelectedIndex = -1;
            cmbFilm.Text = "";
            cmbLotnumber.SelectedIndex = -1;
            cmbLotnumber.Text = "";
            cmbOrder.SelectedIndex = -1;
            cmbOrder.Text = "";
            cmbAntique.SelectedIndex = -1;
            cmbAntique.Text = "";
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
            if (e.ColumnIndex == clmDetail.Index)
            {
                if (Convert.ToInt32(dgvDetails.Rows[e.RowIndex].Cells[clmCodsec.Index].Value) != 0)
                {
                    frmProductionOrderDetails winProductionOrderDetails = new frmProductionOrderDetails(Convert.ToInt32(dgvDetails.Rows[e.RowIndex].Cells[clmCodsec.Index].Value));
                    winProductionOrderDetails.MdiParent = this.MdiParent;
                    winProductionOrderDetails.StartPosition = FormStartPosition.Manual;
                    winProductionOrderDetails.Show();
                }
            }
        }

        private void chkColorCoilCellar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkColorDeadTime.Checked == true)
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

        private void frmDeadTimeByFilmProductionPlan_Load_1(object sender, EventArgs e)
        {
            Thread td = new Thread(new ThreadStart(this.loadMovements));
            td.Start();
        }
    }
}
