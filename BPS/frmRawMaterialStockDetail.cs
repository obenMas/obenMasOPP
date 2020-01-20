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
    public partial class frmRawMaterialStockDetail : Form
    {
        clsRawMaterialtype objRawMaterialType = new clsRawMaterialtype();
        public frmRawMaterialStockDetail()
        {
            InitializeComponent();
        }
        public frmRawMaterialStockDetail(int rawMaterialTypeCodsec)
        {
            InitializeComponent();
            objRawMaterialType = new clsRawMaterialtype(rawMaterialTypeCodsec);

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRawMaterialStockDetail_Load(object sender, EventArgs e)
        {
            List<clsRawMaterial> lstRawMaterialStockDetail = clsRawMaterial.getStockRawMaterialDetail(objRawMaterialType.codsec);

            for (int i = 0; i < lstRawMaterialStockDetail.Count; i++)
            {
                if (lstRawMaterialStockDetail[i].stock != 0)
                {
                    dgvStockDetail.Rows.Add();
                    dgvStockDetail.Rows[i].Cells["clmRawMaterialCodsec"].Value = lstRawMaterialStockDetail[i].codsec.ToString();
                    dgvStockDetail.Rows[i].Cells["clmName"].Value = lstRawMaterialStockDetail[i].name.ToString();
                    dgvStockDetail.Rows[i].Cells["clmCode"].Value = lstRawMaterialStockDetail[i].code.ToString();
                    dgvStockDetail.Rows[i].Cells["clmStock"].Value = (lstRawMaterialStockDetail[i].stock / 1000).ToString() + "  Tm";
                }
            }
        }
    }
}