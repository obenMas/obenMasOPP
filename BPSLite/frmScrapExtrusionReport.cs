using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS.Lite
{
    public partial class frmScrapExtrusionReport : Form
    {
        public frmScrapExtrusionReport()
        {
            InitializeComponent();
            List<clsPlant> list = clsPlant.getList();
            for (int i = 0; i < list.Count; i++)
            {
                cmbPlanta.Items.Add(list[i].name);
            }
        }

        private void btnGenerateCuttingRp_Click(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();
            double pesosTot = 0;
            string query;

            if (cmbPlanta.SelectedIndex == -1)
            {
                query = "CALL spScrapPalletByDate ('" + dtpDesde.Value.ToString("dd/MM/yyyy") + "', '" + dtpHasta.Value.ToString("dd/MM/yyyy") + "');";
            }
            else
            {
                query = "CALL spScrapPalletByDateByPlant ('" + dtpDesde.Value.ToString("dd/MM/yyyy") + "', '" + dtpHasta.Value.ToString("dd/MM/yyyy") + "', " + new clsPlant(cmbPlanta.Items[cmbPlanta.SelectedIndex].ToString()).codsec.ToString() + ");";
            }

            DS = clsConnection.getDataSetResult(query);

            dgvScrapExtrusion.Rows.Clear();

            if ((DS.Tables[0].Rows.Count > 0) && (DS.Tables.Count > 0))
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvScrapExtrusion.Rows.Add();
                    dgvScrapExtrusion.Rows[dgvScrapExtrusion.Rows.Count - 1].Cells[clmTipo.Index].Value = DS.Tables[0].Rows[i]["tipoMerma"].ToString();
                    dgvScrapExtrusion.Rows[dgvScrapExtrusion.Rows.Count - 1].Cells[clmPeso.Index].Value = DS.Tables[0].Rows[i]["Peso"].ToString();
                    dgvScrapExtrusion.Rows[dgvScrapExtrusion.Rows.Count - 1].Cells[clmBodegaOrigen.Index].Value = DS.Tables[0].Rows[i]["BodegaOrigen"].ToString();
                    dgvScrapExtrusion.Rows[dgvScrapExtrusion.Rows.Count - 1].Cells[clmBodegaDestino.Index].Value = DS.Tables[0].Rows[i]["BodegaDestino"].ToString();
                    dgvScrapExtrusion.Rows[dgvScrapExtrusion.Rows.Count - 1].Cells[clmFecha.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["Fecha"].ToString());
                    dgvScrapExtrusion.Rows[dgvScrapExtrusion.Rows.Count - 1].Cells[clmUsuario.Index].Value = DS.Tables[0].Rows[i]["Usuario"].ToString();
                }
            }
            foreach (DataGridViewRow row in dgvScrapExtrusion.Rows)
            {
                pesosTot = pesosTot + Convert.ToDouble(row.Cells["clmPeso"].Value);
                txtPesos.Text = Convert.ToString(pesosTot);
            }
        }
    }
}
