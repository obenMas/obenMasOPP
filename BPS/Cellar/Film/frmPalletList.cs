using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS.Cellar.Film
{
    public partial class frmPalletList : Form
    {

        public int pltok = 0;
        public int pltnotok = 0;
        public string notes = string.Empty;

        public frmPalletList()
        {
            InitializeComponent();
        }

        private void frmPalletList_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            lblpercentaje.Visible = false;
            lblok.Visible = false;
            lblnotok.Visible = false;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            lblpercentaje.Visible = false;
            lblok.Visible = false;
            lblnotok.Visible = false;

            if (cmbInnig.Text == "Día")
            {
                TimeSpan tsInit = new TimeSpan(7, 30, 00);
                TimeSpan tsEnd = new TimeSpan(19, 30, 00);

                DateTime initDate = dtpDate.Value.Date + tsInit;
                DateTime endDate = dtpDate.Value.Date + tsEnd;

                populateList(initDate, endDate, 1);
            }
            else
            {
                TimeSpan tsInit = new TimeSpan(19, 30, 00);
                TimeSpan tsEnd = new TimeSpan(7, 30, 00);

                DateTime initDate = dtpDate.Value.Date + tsInit;
                DateTime endDate = dtpDate.Value.AddDays(1).Date + tsEnd;

                populateList(initDate, endDate, 2);
            }
        }

        private void populateList(DateTime initDate, DateTime endDate, int source)
        {
            pltok = 0;
            pltnotok = 0;
            List<clsPallet> lstPallets = new List<clsPallet>();
            dgvPalletList.Rows.Clear();

            lstPallets = clsPallet.getListCross(initDate, endDate, source);

            for (int i = 0; i < lstPallets.Count; i++)
            {
                dgvPalletList.Rows.Add();

                dgvPalletList.Rows[i].Cells[clmCodsec.Index].Value = lstPallets[i].codsec;
                dgvPalletList.Rows[i].Cells[clmNumber.Index].Value = (i + 1).ToString();
                dgvPalletList.Rows[i].Cells[clmProductCode.Index].Value = lstPallets[i].productAbbreviation;
                dgvPalletList.Rows[i].Cells[clmcode.Index].Value = lstPallets[i].code;
                dgvPalletList.Rows[i].Cells[clmprodate.Index].Value = lstPallets[i].closedDate.ToString("dd/MM/yyyy HH:mm:ss");
                dgvPalletList.Rows[i].Cells[clmCustomer.Index].Value = lstPallets[i].customerName;
                dgvPalletList.Rows[i].Cells[clmNetWeight.Index].Value = Math.Round(lstPallets[i].netWeight, 1);
                dgvPalletList.Rows[i].Cells[clmbopp.Index].Value = (lstPallets[i].localW > 0) ? lstPallets[i].localW.ToString() : "";
                dgvPalletList.Rows[i].Cells[clmopp.Index].Value = (lstPallets[i].extW > 0) ? lstPallets[i].extW.ToString() : "";
                dgvPalletList.Rows[i].Cells[clmSalesOrderNumber.Index].Value = lstPallets[i].salesOrderNumber;
                dgvPalletList.Rows[i].Cells[clmWidth.Index].Value = lstPallets[i].productWidth;
                dgvPalletList.Rows[i].Cells[clmLot.Index].Value = lstPallets[i].lotNumber;
                dgvPalletList.Rows[i].Cells[clmID.Index].Value = lstPallets[i].notes;

                if (lstPallets[i].diference == "OK")
                {
                    dgvPalletList.Rows[i].Cells[clmindate.Index].Value = lstPallets[i].processDate.ToString("dd/MM/yyyy HH:mm:ss");

                    pltok++;
                    for (int j = 0; j < dgvPalletList.Rows[dgvPalletList.Rows.Count - 1].Cells.Count; j++)
                        dgvPalletList.Rows[dgvPalletList.Rows.Count - 1].Cells[j].Style.BackColor = Color.FromArgb(232, 202, 244);
                }
                else
                {
                    pltnotok++;
                    dgvPalletList.Rows[i].Cells[clmindate.Index].Value = "";
                }
            }

            lblpercentaje.Text = dgvPalletList.Rows.Count.ToString();
            lblok.Text = pltok.ToString();
            lblnotok.Text = pltnotok.ToString();

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            lblpercentaje.Visible = true;
            lblok.Visible = true;
            lblnotok.Visible = true;
        }
    }
}
