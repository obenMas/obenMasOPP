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
    public partial class frmValidatePackingList : Form
    {
        clsProduct objProduct = new clsProduct();
        clsThermoforming objThermoforming = new clsThermoforming();

        public frmValidatePackingList()
        {
            InitializeComponent();
        }

        public frmValidatePackingList(int codsec)
        {
            InitializeComponent();
            lblPallet.Text = clsValidatePackingList.getTotalPalletNetWeigth(codsec, 2).ToString();
            lblCoil.Text = clsValidatePackingList.getTotalCoilNetWeigth(codsec, 1).ToString();
            Populate(codsec);
        }

        private void Populate(int codsec)
        {
            List<clsValidatePackingList> lstValidate = new List<clsValidatePackingList>();
            lstValidate = clsValidatePackingList.getList(codsec, 0);
            if (lstValidate.Count > 0)
            {
                for (int i = 0; i < lstValidate.Count; i++)
                {
                    dgvPackingList.Rows.Add();
                    dgvPackingList.Rows[i].Cells[clmcode.Index].Value = lstValidate[i].Code;
                    dgvPackingList.Rows[i].Cells[clmpalletnet.Index].Value = lstValidate[i].PalletNetWeigth;
                    dgvPackingList.Rows[i].Cells[clmcoilnet.Index].Value = lstValidate[i].CoilNetWeigth;
                    dgvPackingList.Rows[i].Cells[clminfo.Index].Value = lstValidate[i].Info;
                }
            }
        }
    }
}

