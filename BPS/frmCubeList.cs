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
    public partial class frmCubeList : Form
    {
        public frmCubeList()
        {
            InitializeComponent();
            PopulateList();
        }

        private void PopulateList()
        {
            List<clsCubeData> lstCube = new List<clsCubeData>();
            List<clsCubeDetail> lstCubeDetail = new List<clsCubeDetail>();
            double weigth = 0;

            lstCube = clsCubeData.getList();
            if (lstCube.Count > 0)
            {
                dgvCube.Rows.Clear();
                for (int i = 0; i < lstCube.Count; i++)
                {
                    dgvCube.Rows.Add();
                    dgvCube.Rows[i].Cells[clmcubecodsec.Index].Value = lstCube[i].codsec;
                    dgvCube.Rows[i].Cells[clmcubenumber.Index].Value = (i == 0) ? 1 : dgvCube.Rows.Count;
                    dgvCube.Rows[i].Cells[clmcubeorder.Index].Value = lstCube[i].order;
                    dgvCube.Rows[i].Cells[clmcubetransport.Index].Value = lstCube[i].lstTransport[0].name;
                    clsEntity objEntity = new clsEntity(lstCube[i].fkCustomer);
                    dgvCube.Rows[i].Cells[clmcubecustomer.Index].Value = objEntity.companyName;
                    dgvCube.Rows[i].Cells[clmcubereuse.Index].Value = global::BPS.Properties.Resources.arrow_refresh;
                    dgvCube.Rows[i].Cells[clmcubedelete.Index].Value = global::BPS.Properties.Resources.cross;
                    lstCubeDetail = new List<clsCubeDetail>();
                    lstCubeDetail = clsCubeDetail.getListByCube(lstCube[i].codsec);

                    if (lstCubeDetail.Count > 0)
                    {

                        for (int j = 0; j < lstCubeDetail.Count; j++)
                            weigth += Convert.ToDouble(lstCubeDetail[j].palletweigth);

                        dgvCube.Rows[i].Cells[clmcubeweigth.Index].Value = Math.Round(weigth, 1, MidpointRounding.AwayFromZero);
                        dgvCube.Rows[i].Cells[clmcuberowone.Index].Value = lstCubeDetail[lstCubeDetail.Count - 1].rowOne;
                        dgvCube.Rows[i].Cells[clmcuberowtwo.Index].Value = lstCubeDetail[lstCubeDetail.Count - 1].rowTwo;
                        dgvCube.Rows[i].Cells[clmcuberowthree.Index].Value = lstCubeDetail[lstCubeDetail.Count - 1].rowThree;
                    }
                    else
                    {
                        dgvCube.Rows[i].Cells[clmcubeweigth.Index].Value = "0";
                        dgvCube.Rows[i].Cells[clmcuberowone.Index].Value = "0";
                        dgvCube.Rows[i].Cells[clmcuberowtwo.Index].Value = "0";
                        dgvCube.Rows[i].Cells[clmcuberowthree.Index].Value = "0";
                    }
                }
            }
            else
                dgvCube.Rows.Clear();
        }

        private void dgvCube_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmcubereuse.Index)
            {
                if (MessageBox.Show("Está realmente seguro que desea re utilizar el cubicaje seleccionado?", "Cubicaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                {
                    frmDisplacement winDis = new frmDisplacement(Convert.ToInt32(dgvCube.Rows[e.RowIndex].Cells[clmcubecodsec.Index].Value));
                    winDis.StartPosition = FormStartPosition.CenterScreen;
                    winDis.Show();
                }
            }
            else if (e.ColumnIndex == clmcubedelete.Index)
            {
                if (MessageBox.Show("Está realmente seguro que desea eliminar el cubicaje seleccionado?\n\r Por favor recuerde que si eliminar el cubicaje no se podrá recuperar", "Cubicaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                {
                    var codsec = Convert.ToInt32(dgvCube.Rows[e.RowIndex].Cells[clmcubecodsec.Index].Value);
                    if (clsCubeDetail.deteleCubeDetail(codsec))
                    {
                        if (clsCubeData.delete(codsec))
                        {
                            MessageBox.Show("Cubicaje eliminado correctamente!", "Cubicaje", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            PopulateList();
                        }
                        else
                        {
                            MessageBox.Show("Error al momento de eliminar Cube-Data", "Cubicaje", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            PopulateList();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al momento de eliminar Cube-Detail", "Cubicaje", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        PopulateList();
                    }
                }
            }
        }
    }
}
