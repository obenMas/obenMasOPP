using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms; 
using BPS.Bussiness;

namespace BPS
{
    public partial class frmMovementReportbyDate : Form
    {
        string initdate, enddate = string.Empty;


        public frmMovementReportbyDate()
        {
            InitializeComponent();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            if (cmbMovementType.SelectedIndex > -1)
            {
                List<clsPalletbyCoilCellar> lstPalletbyCoilCellar = new List<clsPalletbyCoilCellar>();
                TimeSpan InitHour = new TimeSpan(00, 00, 00);
                TimeSpan EndHour = new TimeSpan(23, 59, 59);
                initdate = dtpDate.Value.Date.Add(InitHour).ToString("dd/MM/yyyy HH:mm:ss");
                enddate = dtpDate.Value.Date.Add(EndHour).ToString("dd/MM/yyyy HH:mm:ss");
                if (dtpDate.Value.Date > Convert.ToDateTime("2012/02/28 00:00:00"))
                {
                    lstPalletbyCoilCellar = clsPalletbyCoilCellar.getListMovement(Convert.ToDateTime(initdate), Convert.ToDateTime(enddate), (((clsCoilCellarMovement)cmbMovementType.SelectedItem).fkCoilCellar));
                    dgvPallets.Rows.Clear();
                    if (lstPalletbyCoilCellar.Count > 0)
                    {
                        for (int i = 0; i < lstPalletbyCoilCellar.Count; i++)
                        {
                            dgvPallets.Rows.Add();
                            dgvPallets.Rows[i].Cells[clmcodsec.Index].Value = lstPalletbyCoilCellar[i].codsec;
                            dgvPallets.Rows[i].Cells[clmcodepallet.Index].Value = lstPalletbyCoilCellar[i].code;
                            dgvPallets.Rows[i].Cells[clmcustomer.Index].Value = lstPalletbyCoilCellar[i].customer;
                            dgvPallets.Rows[i].Cells[clmdateproduction.Index].Value = lstPalletbyCoilCellar[i].createdate.ToString("dd/MM/yyyy HH:mm:ss");
                            dgvPallets.Rows[i].Cells[clmproduct.Index].Value = lstPalletbyCoilCellar[i].producto;
                            dgvPallets.Rows[i].Cells[clmNetWeight.Index].Value = lstPalletbyCoilCellar[i].netweigth;
                            dgvPallets.Rows[i].Cells[clmordernumber.Index].Value = lstPalletbyCoilCellar[i].order;
                            dgvPallets.Rows[i].Cells[clmnumber.Index].Value = (i + 1);
                        }
                    }
                    else
                        MessageBox.Show("No existen datos con esa fecha. Por favor ingrese una nueva fecha", "Pallet Movimientos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("La fecha de búsqueda debe ser mayor que 28/02/2012 !..", "Pallet Movimientos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Debe seleccionar un tipo de movimiento", "Reporte movimientos bodega", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmMovementReportbyDate_Load(object sender, EventArgs e)
        {
            FillDataMovementType();
        }

        private void FillDataMovementType()
        {
            List<clsCoilCellarMovement> lstCoilCellarMovement = new List<clsCoilCellarMovement>();
            lstCoilCellarMovement = clsCoilCellarMovement.getList();
            for (int i = 0; i < lstCoilCellarMovement.Count; i++)
            {
                if (lstCoilCellarMovement[i].fkCoilCellar == 4)
                    lstCoilCellarMovement.RemoveAt(i);
            }
            for (int i = 0; i < lstCoilCellarMovement.Count; i++)
                cmbMovementType.Items.Add(lstCoilCellarMovement[i]);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (dgvPallets.Rows.Count > 0)
            {
                frmMovementReportByDates winReport = new frmMovementReportByDates(Convert.ToDateTime(initdate), Convert.ToDateTime(enddate), (((clsCoilCellarMovement)cmbMovementType.SelectedItem).fkCoilCellar));
                winReport.StartPosition = FormStartPosition.CenterScreen;
                winReport.MdiParent = this.MdiParent;
                winReport.Show();
            }
            else
                MessageBox.Show("No existen datos para el reporte", "Reporte de movimientos bodega", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
