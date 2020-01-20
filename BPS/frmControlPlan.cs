using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Business;
using BPS.Bussiness;


namespace BPS
{
    public partial class frmControlPlan : Form
    {
        DataSet DS = new DataSet();
        DataSet DS2 = new DataSet();
        clsQualityControls objqctrl = new clsQualityControls();
        clsQualityControlsTypes objQCTypes = new clsQualityControlsTypes();
        clsQualityControlsByFilm objQCbyFilm = new clsQualityControlsByFilm();

        public frmControlPlan()
        {
            InitializeComponent();
            PopulateCombo();
          //  getDataSet();
           // PopulateDgv();
        }

        public void getDataSet()
        {
            DS = clsConnection.getDataSetResult("CALL spQualityControlsByFilm");
        }

        public void getDataSet2(string code)
        {
            DS2 = clsConnection.getDataSetResult("CALL spQualityControlsByFilmByBoppCode('" + code.ToString() + "')");
        }

        public void PopulateDgv()
        {
            dgvControlPlans.Rows.Clear();
            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvControlPlans.Rows.Add();
                    dgvControlPlans.Rows[dgvControlPlans.Rows.Count - 1].Cells[clmCodsec.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["qcbf_codsec"]);
                    dgvControlPlans.Rows[dgvControlPlans.Rows.Count - 1].Cells[clmFkBopp.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["qcbf_fkBopp"]);
                    dgvControlPlans.Rows[dgvControlPlans.Rows.Count - 1].Cells[clmBoppCode.Index].Value = DS.Tables[0].Rows[i]["bopp_code"].ToString();
                    dgvControlPlans.Rows[dgvControlPlans.Rows.Count - 1].Cells[clmCodsecFkqQalityControl.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["qcbf_fkqualitycontrol"]);
                    dgvControlPlans.Rows[dgvControlPlans.Rows.Count - 1].Cells[clmQualityControlName.Index].Value = DS.Tables[0].Rows[i]["qc_name"].ToString();
                    dgvControlPlans.Rows[dgvControlPlans.Rows.Count - 1].Cells[clmQuantityValues.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["qcbf_valuesquantity"]);
                    dgvControlPlans.Rows[dgvControlPlans.Rows.Count - 1].Cells[clmMin.Index].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["qcbf_minimum"]);
                    dgvControlPlans.Rows[dgvControlPlans.Rows.Count - 1].Cells[clmMax.Index].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["qcbf_maximum"]);
                }
            }
        }

        public void PopulateCombo()
        {
            List<clsBopp> lstBopp = new List<clsBopp>();
            lstBopp = clsBopp.getListShort();

            for (int i = 0; i < lstBopp.Count; i++)
            {
                cmbBopp.Items.Add(lstBopp[i].code);
            }
        }

        private void cmbBopp_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsBopp objBopp = new clsBopp();
            if (cmbBopp.SelectedIndex != -1)
            {
                if (validateIsNew(cmbBopp.SelectedItem.ToString()))
                {
                    getDataSet2(cmbBopp.SelectedItem.ToString());
                    PopulateDgvByFilm();
                }
                else
                {
                    MessageBox.Show("No existe un plan de control para la pelicula seleccionada. Debe apretar el boton Agregar Control para crear uno nuevo.", "Planes de Control", MessageBoxButtons.OK);
                    dgvControlPlans.Rows.Clear();
                }
            }
        }

        public bool validateIsNew(string boppCode)
        {

            int boppCodsec = 0;

            DataSet DS3 = new DataSet();

            DS3 = clsConnection.getDataSetResult("SELECT QCBF.qcbf_codsec AS BoppCodsec FROM bps_prod_qualitycontrolsbyfilm AS QCBF LEFT JOIN bps_prod_bopp ON(bps_prod_bopp.bopp_codsec = QCBF.qcbf_fkBopp)  WHERE bps_prod_bopp.bopp_code = '" + boppCode + "'");

            if (DS3.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS3.Tables[0].Rows.Count; i++)
                {
                    boppCodsec = Convert.ToInt32(DS3.Tables[0].Rows[i]["BoppCodsec"]);
                }
            }
            if (boppCodsec > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PopulateDgvByFilm()
        {
            dgvControlPlans.Rows.Clear();
            if (DS2.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS2.Tables[0].Rows.Count; i++)
                {
                    dgvControlPlans.Rows.Add();
                    dgvControlPlans.Rows[dgvControlPlans.Rows.Count - 1].Cells[clmCodsec.Index].Value = Convert.ToInt32(DS2.Tables[0].Rows[i]["qcbf_codsec"]);
                    dgvControlPlans.Rows[dgvControlPlans.Rows.Count - 1].Cells[clmFkBopp.Index].Value = Convert.ToInt32(DS2.Tables[0].Rows[i]["qcbf_fkBopp"]);
                    dgvControlPlans.Rows[dgvControlPlans.Rows.Count - 1].Cells[clmBoppCode.Index].Value = DS2.Tables[0].Rows[i]["bopp_code"].ToString();
                    dgvControlPlans.Rows[dgvControlPlans.Rows.Count - 1].Cells[clmCodsecFkqQalityControl.Index].Value = Convert.ToInt32(DS2.Tables[0].Rows[i]["qcbf_fkqualitycontrol"]);
                    dgvControlPlans.Rows[dgvControlPlans.Rows.Count - 1].Cells[clmQualityControlName.Index].Value = DS2.Tables[0].Rows[i]["qc_name"].ToString();
                    dgvControlPlans.Rows[dgvControlPlans.Rows.Count - 1].Cells[clmQuantityValues.Index].Value = Convert.ToInt32(DS2.Tables[0].Rows[i]["qcbf_valuesquantity"]);
                    dgvControlPlans.Rows[dgvControlPlans.Rows.Count - 1].Cells[clmMin.Index].Value = Convert.ToDouble(DS2.Tables[0].Rows[i]["qcbf_minimum"]);
                    dgvControlPlans.Rows[dgvControlPlans.Rows.Count - 1].Cells[clmMax.Index].Value = Convert.ToDouble(DS2.Tables[0].Rows[i]["qcbf_maximum"]);
                }
            }
        }

        private void btnClean_Click_1(object sender, EventArgs e)
        {
            PopulateCombo();
            cmbBopp.SelectedIndex = -1;
            dgvControlPlans.Rows.Clear();

        }

        private void dgvControlPlans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmDelete.Index)
            {
                if (MessageBox.Show("Esta seguro que desea eliminar el plan de control seleccionado?", "Eliminar Plan de Control", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (clsQualityControlsByFilm.delete(Convert.ToInt32(dgvControlPlans.Rows[e.RowIndex].Cells[clmCodsec.Index].Value)))
                    {
                        dgvControlPlans.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }

            if (e.ColumnIndex == clmEdit.Index)
            {
                frmControlPlanNew winCuttingOrderList = new frmControlPlanNew(Convert.ToInt32(dgvControlPlans.Rows[e.RowIndex].Cells[clmCodsec.Index].Value), Convert.ToInt32(dgvControlPlans.Rows[e.RowIndex].Cells[clmCodsecFkqQalityControl.Index].Value), dgvControlPlans.Rows[e.RowIndex].Cells[clmBoppCode.Index].Value.ToString(), dgvControlPlans.Rows[e.RowIndex].Cells[clmQualityControlName.Index].Value.ToString(), Convert.ToInt32(dgvControlPlans.Rows[e.RowIndex].Cells[clmQuantityValues.Index].Value), Convert.ToDouble(dgvControlPlans.Rows[e.RowIndex].Cells[clmMin.Index].Value), Convert.ToDouble(dgvControlPlans.Rows[e.RowIndex].Cells[clmMax.Index].Value));
                winCuttingOrderList.StartPosition = FormStartPosition.Manual;
                winCuttingOrderList.Show();
            }
            getDataSet();
            PopulateDgv();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cmbBopp.SelectedIndex != -1)
            {
                frmControlPlanNew winCuttingOrderList = new frmControlPlanNew(cmbBopp.SelectedItem.ToString());
                winCuttingOrderList.StartPosition = FormStartPosition.Manual;
                winCuttingOrderList.ShowDialog();

                getDataSet2(cmbBopp.SelectedItem.ToString());
                PopulateDgvByFilm();

            }
            else
            {
                MessageBox.Show("Debe seleccionar una Pelicula del listado.", "Planes de Control", MessageBoxButtons.OK);
            }

        }

    }
}
