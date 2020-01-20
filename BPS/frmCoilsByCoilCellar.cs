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
    public partial class frmCoilsByCoilCellar : Form
    {
        List<clsCoil> lstCoil = new List<clsCoil>();
        clsCoilCellar objCoilCellar = new clsCoilCellar();

        public frmCoilsByCoilCellar()
        {
            InitializeComponent();
        }
        public frmCoilsByCoilCellar(int coilCellarCodsec)
        {
            InitializeComponent();
            objCoilCellar = new clsCoilCellar(coilCellarCodsec);
        }
        private void fillDataGrid()
        {
            bool flgUseFilter = false;
            lstCoil.Clear();

            if (cmbProduct.SelectedIndex >= 0)
                flgUseFilter = true;
            
            if (cmbCustomer.SelectedIndex >= 0)
                flgUseFilter = true;
            
            if (flgUseFilter == false)
                lstCoil = clsCoil.getCoilListByCoilCellar(objCoilCellar.codsec);

            dgvCoils.Rows.Clear();
            for (int i = 0; i < lstCoil.Count; i++)
            {
                clsSalesOrderDetail objSalesOrderDetail = clsCoil.getSalesOrderDetailByCoil(lstCoil[i].codsec);
                clsSalesOrder objSalesOrder = new clsSalesOrder(objSalesOrderDetail.fkSalesOrder);
                dgvCoils.Rows.Add();
                dgvCoils.Rows[i].Cells[clmCodsec.Index].Value = lstCoil[i].codsec;
                dgvCoils.Rows[i].Cells[clmCode.Index].Value = lstCoil[i].code;
                dgvCoils.Rows[i].Cells[clmProductName.Index].Value = lstCoil[i].ProductName;
                dgvCoils.Rows[i].Cells[clmDestination.Index].Value = (objSalesOrder.codsec != 0)? objSalesOrder.EntityName + " [" + objSalesOrder.number + "]" : "Stock";
                dgvCoils.Rows[i].Cells[clmLength.Index].Value = Convert.ToString(Math.Round(lstCoil[i].length, 2));
                dgvCoils.Rows[i].Cells[clmWidth.Index].Value = Convert.ToString(Math.Round(lstCoil[i].width, 2));
                dgvCoils.Rows[i].Cells[clmWeigth.Index].Value = Convert.ToString(Math.Round(lstCoil[i].netWeight, 2));
                dgvCoils.Rows[i].Cells[clmQuality.Index].Value = lstCoil[i].CuttingQualityName;
            }
            
        }
        private void frmCoilsByCoilCellar_Load(object sender, EventArgs e)
        {
            fillDataGrid();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {

        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {

        }

        private void btnFilters_Click(object sender, EventArgs e)
        {

        }
    }
}