using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms; 
using BPS.Bussiness;

namespace BPS
{
    public partial class frmRawMaterialStock : Form
    {
        public frmRawMaterialStock()
        {
            InitializeComponent();
        }

        private void frmRawMaterialStock_Load(object sender, EventArgs e)
        {
            List<clsRawMaterialStock> lstRawMaterialStock = clsRawMaterialStock.getList();

            for (int i = 0; i < lstRawMaterialStock.Count; i++)
            {
                dgvStock.Rows.Add();   
                dgvStock.Rows[i].Cells["clmfkRawMaterialType"].Value = lstRawMaterialStock[i].fkRawMaterialType.ToString();
                dgvStock.Rows[i].Cells["clmName"].Value = lstRawMaterialStock[i].RawMaterialTypeName.ToString();
                dgvStock.Rows[i].Cells["clmStock"].Value = (lstRawMaterialStock[i].Stock/1000).ToString() + "  Tm" ;
            }
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvStock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmRawMaterialStockDetail winRawMaterialStockDetail = new frmRawMaterialStockDetail(Convert.ToInt32(dgvStock.Rows[e.RowIndex].Cells[clmfkRawMaterialType.Index].Value));
            winRawMaterialStockDetail.MdiParent = this.MdiParent;
            winRawMaterialStockDetail.Show();

            //ahora vamos a pasar el parametro, tiene que ser en el constructor porque es la función que 
            // sobrecargamos
            
        }
    }
}