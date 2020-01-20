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
    public partial class frmStockPallet : Form
    {
        clsPallet objStockPallet = new clsPallet();
        clsProduct objprod = new clsProduct();
        frmSalesOrderForm form = new frmSalesOrderForm();
        List<clsPallet> list = new List<clsPallet>();

        public frmStockPallet(string prod, frmSalesOrderForm form)
        {
            InitializeComponent();
            objprod = new clsProduct(prod);
            this.form = form;
            populateDataGrid();
            calculateTotal();
        }

        public void populateDataGrid()
        {
            dgvStockPallet.Rows.Clear();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spStockPallets '" + objprod.code.ToString() + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvStockPallet.Rows.Add();
                    dgvStockPallet.Rows[i].Cells["clmCodsec"].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_codsec"]);
                    dgvStockPallet.Rows[i].Cells["clmPalletCode"].Value = DS.Tables[0].Rows[i]["plt_code"].ToString();
                    dgvStockPallet.Rows[i].Cells["clmPalletNetWeight"].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["plt_netWeight"]);
                    dgvStockPallet.Rows[i].Cells["clmPalletCreateDate"].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_createdDate"]);
                    
                   
                }
            }

        }

        public void calculateTotal()
        {
            double total = 0;

            for(int i=0;i<dgvStockPallet.Rows.Count;i++)
            {
                if(Convert.ToBoolean(dgvStockPallet.Rows[i].Cells[clmPalletCheck.Index].Value))
                {
                    total += Convert.ToDouble(dgvStockPallet.Rows[i].Cells[clmPalletNetWeight.Index].Value);
                }
            }

            txtTotalCheked.Text = total.ToString();
        }

        private void dgvStockPallet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTotalCheked.Focus();
            calculateTotal();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            list = new List<clsPallet>();

            for(int i=0;i<dgvStockPallet.Rows.Count;i++)
            {
                if(Convert.ToBoolean(dgvStockPallet.Rows[i].Cells[clmPalletCheck.Index].Value))
                {
                    list.Add(new clsPallet(Convert.ToInt32(dgvStockPallet.Rows[i].Cells[clmCodsec.Index].Value)));
                }
            }
            this.Close();
        }

        private void frmStockPallet_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.setPalletList(list);
        }

    }



}

