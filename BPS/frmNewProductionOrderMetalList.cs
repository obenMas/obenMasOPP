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
    public partial class frmNewProductionOrderMetalList : Form
    {
        public frmNewProductionOrderMetalList()
        {
            InitializeComponent();
            cargardgv();
        }

        private void cargardgv()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwMetalOrderListClosed");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                dgvMetalOrderLst.Rows.Add();
                dgvMetalOrderLst.Rows[dgvMetalOrderLst.Rows.Count - 1].Cells[clmAncho.Index].Value = DS.Tables[0].Rows[i]["Ancho"].ToString();
                dgvMetalOrderLst.Rows[dgvMetalOrderLst.Rows.Count - 1].Cells[clmCantBob.Index].Value = DS.Tables[0].Rows[i]["cantBobinas"].ToString();
                dgvMetalOrderLst.Rows[dgvMetalOrderLst.Rows.Count - 1].Cells[clmCreacion.Index].Value = DS.Tables[0].Rows[i]["fechaCreacion"].ToString();
                dgvMetalOrderLst.Rows[dgvMetalOrderLst.Rows.Count - 1].Cells[clmFilmFin.Index].Value = DS.Tables[0].Rows[i]["filmFinal"].ToString();
                dgvMetalOrderLst.Rows[dgvMetalOrderLst.Rows.Count - 1].Cells[clmFilmInit.Index].Value = DS.Tables[0].Rows[i]["filmInicial"].ToString();
                dgvMetalOrderLst.Rows[dgvMetalOrderLst.Rows.Count - 1].Cells[clmLote.Index].Value = DS.Tables[0].Rows[i]["lote"].ToString();
                dgvMetalOrderLst.Rows[dgvMetalOrderLst.Rows.Count - 1].Cells[clmMaquina.Index].Value = DS.Tables[0].Rows[i]["maquina"].ToString();
                dgvMetalOrderLst.Rows[dgvMetalOrderLst.Rows.Count - 1].Cells[clmObservation.Index].Value = DS.Tables[0].Rows[i]["Observacion"].ToString();
            }
        }

    }
}
