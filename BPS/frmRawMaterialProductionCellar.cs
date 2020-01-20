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
    public partial class frmRawMaterialProductionCellar : Form
    {
        clsMachine objMachine = new clsMachine();
        int machCodsec = 0;
        clsRawMaterialStockProduction objRawMaterialStockProduction = new clsRawMaterialStockProduction();

        public frmRawMaterialProductionCellar(int machineCodsec)
        {
            InitializeComponent();
            objMachine.load(machineCodsec, "Extruder");
            
            List<clsRawMaterialStockProduction> lstRawMaterialStockProduction = clsRawMaterialStockProduction.getListByExtruder(objMachine.fkExtruder);
            
            for (int i = 0; i < lstRawMaterialStockProduction.Count; i++)
            {
                
                    dgvProduccionStock.Rows.Add();
                    dgvProduccionStock.Rows[i].Cells["clmfkRawMaterialType"].Value = lstRawMaterialStockProduction[i].fkRawMaterialType.ToString();
                    dgvProduccionStock.Rows[i].Cells["clmRawMaterialTypeName"].Value = lstRawMaterialStockProduction[i].rawMaterialTypeName.ToString();
                    dgvProduccionStock.Rows[i].Cells["clmfkRawMaterial"].Value = lstRawMaterialStockProduction[i].fkRawMaterial.ToString();
                    dgvProduccionStock.Rows[i].Cells["clmRawMaterialCode"].Value = lstRawMaterialStockProduction[i].rawMaterialCode.ToString();
                    dgvProduccionStock.Rows[i].Cells["clmRawMaterialName"].Value = lstRawMaterialStockProduction[i].rawMaterialName.ToString();
                    dgvProduccionStock.Rows[i].Cells["clmStock"].Value = (lstRawMaterialStockProduction[i].stock / 1000).ToString() + "  Tm";
               
                
            }
        }

        public frmRawMaterialProductionCellar()
        {
            InitializeComponent();
        }

        private void frmRawMaterialProductionCellar_Load(object sender, EventArgs e)
        {
          //  List<clsRawMaterialStockProduction> lstRawMaterialStock = new List<clsRawMaterialStockProduction>();
         //   lstRawMaterialStock = clsRawMaterialStockProduction.getListByMachine();
        }

        private void btnProductionCellarClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProduccionStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmRawMaterialProductionCellarDetail winRawMaterialProductionCellarDetai = new frmRawMaterialProductionCellarDetail(Convert.ToInt32(dgvProduccionStock.Rows[e.RowIndex].Cells[clmfkRawMaterialType.Index].Value), Convert.ToInt32(machCodsec));
            winRawMaterialProductionCellarDetai.MdiParent = this.MdiParent;
            winRawMaterialProductionCellarDetai.Show();
        }
    }
}