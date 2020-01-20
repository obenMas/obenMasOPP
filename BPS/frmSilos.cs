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
    public partial class frmSilos : Form
    {
        private clsSilo objSilo = new clsSilo();
        
        public frmSilos()
        {
            InitializeComponent();
        }

        private void frmSilos_Load(object sender, EventArgs e)
        {
            List<BPS.Bussiness.clsRawMaterialbySilo> lstRaw = new List<BPS.Bussiness.clsRawMaterialbySilo>();

            lstRaw = BPS.Bussiness.clsRawMaterialbySilo.getListTotalized();

            for (int i = 0; i < lstRaw.Count; i++)
            {
                dgvstocksilos.Rows.Add();
                dgvstocksilos.Rows[i].Cells["clmSilo"].Value = lstRaw[i].fksilo.ToString();
                dgvstocksilos.Rows[i].Cells["clmRawMaterial"].Value = lstRaw[i].rawmaterialname.ToString();
                dgvstocksilos.Rows[i].Cells["clmQuantity"].Value = Convert.ToInt32(lstRaw[i].weigth);
                dgvstocksilos.Rows[i].Cells["clmChange"].Value = BPS.Properties.Resources.arrow_refresh1;
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
                worksheet.Name = "MP en silos";

                for (int i = 1; i < dgvstocksilos.Columns.Count + 1; i++)
                    worksheet.Cells[1, i] = dgvstocksilos.Columns[i - 1].HeaderText;

                for (int i = 0; i < dgvstocksilos.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvstocksilos.Columns.Count-1; j++)
                    {
                        if (dgvstocksilos.Rows[i].Cells[j].Value != null)
                            worksheet.Cells[i + 2, j + 1] = dgvstocksilos.Rows[i].Cells[j].Value.ToString();
                    }
                }
                MessageBox.Show("Exportación Generada correctamente", "MP en silos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MP en silos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvstocksilos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                objSilo = new clsSilo(Convert.ToInt32(dgvstocksilos.Rows[e.RowIndex].Cells["clmSilo"].Value));
                dgvstocksilos.Visible = false;
                txtSelectedSilo.Visible = true;
                lblMaterialSelector.Visible = true;
                cmbMaterialSelector.Visible = true;
                btnSaveChange.Visible = true;
                txtSelectedSilo.Text = objSilo.name;
                List<clsRawMaterial> lstRaw = clsRawMaterial.getListRaw();
                for(int i=0;i<lstRaw.Count;i++)
                {
                    if(!cmbMaterialSelector.Items.Contains(lstRaw[i].RawMaterialtypeName))
                    {
                        cmbMaterialSelector.Items.Add(lstRaw[i].RawMaterialtypeName);
                    }
                }
            }
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            int newcodsec=0;
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * from bps_prod_rawmaterialtype WHERE trwm_name='"+cmbMaterialSelector.SelectedItem.ToString()+"'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                newcodsec = Convert.ToInt32(DS.Tables[0].Rows[0]["trwm_codsec"]);
            }

            if(objSilo.changeMaterial(newcodsec, cmbMaterialSelector.SelectedItem.ToString()))
            {
                MessageBox.Show("Cambio realizado correctamente.", "MP en silos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocurrio un error y no se pudo realizar el cambio. Verifique que el silo no tenga material, solo es posible realizar el cambio si no hay stock en el silo seleccionado.", "MP en silos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvstocksilos.Rows.Clear();
            List<BPS.Bussiness.clsRawMaterialbySilo> lstRaw = new List<BPS.Bussiness.clsRawMaterialbySilo>();

            lstRaw = BPS.Bussiness.clsRawMaterialbySilo.getListTotalized();

            for (int i = 0; i < lstRaw.Count; i++)
            {
                dgvstocksilos.Rows.Add();
                dgvstocksilos.Rows[i].Cells["clmSilo"].Value = lstRaw[i].fksilo.ToString();
                dgvstocksilos.Rows[i].Cells["clmRawMaterial"].Value = lstRaw[i].rawmaterialname.ToString();
                dgvstocksilos.Rows[i].Cells["clmQuantity"].Value = Convert.ToInt32(lstRaw[i].weigth);
                dgvstocksilos.Rows[i].Cells["clmChange"].Value = BPS.Properties.Resources.arrow_refresh1;
            }
            dgvstocksilos.Visible = true;
            txtSelectedSilo.Visible = false;
            lblMaterialSelector.Visible = false;
            cmbMaterialSelector.Visible = false;
            btnSaveChange.Visible = false;
        }
    }
}
