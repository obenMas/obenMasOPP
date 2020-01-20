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
    public partial class frmRawMaterialProductionCellarDetail : Form
    {
        clsRawMaterialtype objRawMaterialType = new clsRawMaterialtype();
        clsMachine objMachine = new clsMachine();
        public frmRawMaterialProductionCellarDetail()
        {
            InitializeComponent();
        }

        public frmRawMaterialProductionCellarDetail(int rawMaterialTypeCodsec, int machCodsec)
        {
            InitializeComponent();
            objRawMaterialType = new clsRawMaterialtype(rawMaterialTypeCodsec);
            objMachine.load(machCodsec, "Extruder");
        }   

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRawMaterialProductionCellarDetail_Load(object sender, EventArgs e)
        {
            List<clsRawMaterial> lstRawMaterialStockDetail = new List<clsRawMaterial>();
            lstRawMaterialStockDetail = clsRawMaterial.getStockRawMaterialProductionDetail(Convert.ToInt32(objRawMaterialType.codsec),Convert.ToInt32(objMachine.codsec));
            for (int i = 0; i < lstRawMaterialStockDetail.Count; i++)
            {
                dgvStockProductionDetail.Rows.Add();
                dgvStockProductionDetail.Rows[i].Cells["clmRawMaterialCodsec"].Value = lstRawMaterialStockDetail[i].codsec.ToString();
                dgvStockProductionDetail.Rows[i].Cells["clmName"].Value = lstRawMaterialStockDetail[i].name.ToString();
                dgvStockProductionDetail.Rows[i].Cells["clmStock"].Value = (lstRawMaterialStockDetail[i].stock / 1000).ToString() + "  Tm";
            }
        }
    }
}