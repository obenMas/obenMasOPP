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
    public partial class frmCuttingPlan : Form
    {
        public frmCuttingPlan()
        {
            InitializeComponent();
            completarComboCortadoras();
        }

        private void completarComboCortadoras()
        {
            cmbCortadora.Items.Clear();

            List<clsCutter> lista = clsCutter.getList();

            for(int i=0; i<lista.Count; i++)
            {
                cmbCortadora.Items.Add(lista[i].name);
            }
        }

        private void cmbCortadora_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet DS = clsConnection.getDataSetResult("spCombinacionesPendientes '"+cmbCortadora.Items[cmbCortadora.SelectedIndex].ToString()+"'");

            if(DS.Tables.Count>0 && DS.Tables[0].Rows.Count>0)
            {
                dgvPendientes.Rows.Clear();

                for(int i=0;i<DS.Tables[0].Rows.Count;i++)
                {
                    dgvPendientes.Rows.Add();
                    dgvPendientes.Rows[dgvPendientes.Rows.Count-1].Cells[clmOrden.Index].Value=DS.Tables[0].Rows[i]["orden"];
                    dgvPendientes.Rows[dgvPendientes.Rows.Count - 1].Cells[clmRepeticiones.Index].Value = DS.Tables[0].Rows[i]["restoRepe"];
                    dgvPendientes.Rows[dgvPendientes.Rows.Count - 1].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["pelicula"];
                    dgvPendientes.Rows[dgvPendientes.Rows.Count - 1].Cells[clmAnchoUtil.Index].Value = DS.Tables[0].Rows[i]["anchoUtil"];
                    dgvPendientes.Rows[dgvPendientes.Rows.Count - 1].Cells[clmFecha.Index].Value = DS.Tables[0].Rows[i]["fecha"];
                }
            }
        }

        private void dgvPendientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(cmbModo.SelectedIndex!=-1 && cmbPosicion.SelectedIndex!=-1 && e.RowIndex>-1 && e.ColumnIndex==clmAgregar.Index)
            {
                string selectString = cmbModo.Items[cmbModo.SelectedIndex].ToString() + cmbPosicion.Items[cmbPosicion.SelectedIndex].ToString();

                switch(selectString)
                {
                    case "CombinaciónAl final":
                        combinacionAlFinal(e.RowIndex);
                        break;
                    case "CombinaciónEn posicion intercalada":
                        combinacionIntercalada(e.RowIndex);
                        break;
                    case "RepeticiónAl final":
                        repeticionAlFinal(e.RowIndex);
                        break;
                    case "RepeticiónEn posicion intercalada":
                        repeticionIntercalada(e.RowIndex);
                        break;
                    case "PersonalizadoAl final":
                        personalizadoAlFinal(e.RowIndex);
                        break;
                    case "PersonalizadoEn posicion intercalada":
                        personalizadoIntercalado(e.RowIndex);
                        break;
                }
            }
        }

        private void combinacionAlFinal(int ind)
        {
            dgvPlan.Rows.Add();
            dgvPlan.Rows[dgvPlan.Rows.Count - 1].Cells[clmNumero.Index].Value = dgvPlan.Rows.Count;
            dgvPlan.Rows[dgvPlan.Rows.Count - 1].Cells[clmOrdenPlan.Index].Value = dgvPendientes.Rows[ind].Cells[clmOrden.Index].Value;
            dgvPlan.Rows[dgvPlan.Rows.Count - 1].Cells[clmRepeticionPlan.Index].Value = dgvPendientes.Rows[ind].Cells[clmRepeticiones.Index].Value;
            dgvPlan.Rows[dgvPlan.Rows.Count - 1].Cells[clmAnchoUtilPlan.Index].Value = dgvPendientes.Rows[ind].Cells[clmAnchoUtil.Index].Value;
            dgvPlan.Rows[dgvPlan.Rows.Count - 1].Cells[clmPeliculaPlan.Index].Value = dgvPendientes.Rows[ind].Cells[clmPelicula.Index].Value;
            //dgvPlan.Rows[dgvPlan.Rows.Count - 1].Cells[clmFechaInicio.Index].Value = DateTime.Now;

        }

        private void combinacionIntercalada(int ind)
        {

        }

        private void repeticionAlFinal(int ind)
        {

        }

        private void repeticionIntercalada(int ind)
        {

        }

        private void personalizadoAlFinal(int ind)
        {

        }

        private void personalizadoIntercalado(int ind)
        {

        }



    }
}
