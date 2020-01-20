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
    public partial class frmDecreaseSelector : Form
    {
        frmMainCoil prntMainCoilForm;
        frmMainCoilRegister prntMainCoilRegisterForm;
        string CALLerForm = "";

        public frmDecreaseSelector()
        {
            InitializeComponent();
        }

        public frmDecreaseSelector(frmMainCoil winMainCoilForm)
        {
            InitializeComponent();
            prntMainCoilForm = winMainCoilForm;
            CALLerForm = "MainCoilForm";
        }
        public frmDecreaseSelector(frmMainCoilRegister winMainCoilForm)
        {
            InitializeComponent();
            prntMainCoilRegisterForm = winMainCoilForm;
            CALLerForm = "MainCoilFormRegister";
        }
        public void returnMainCoil()
        {
            switch (CALLerForm)
            {
                case "MainCoilForm":
                    prntMainCoilForm.selectedDecrease = Convert.ToInt32(dgvDecreaseList.SelectedRows[0].Cells[clmDecreaseCodsec.Index].Value);
                    this.Close();
                    break;
                case "MainCoilFormRegister":
                    prntMainCoilRegisterForm.selectedDecrease = Convert.ToInt32(dgvDecreaseList.SelectedRows[0].Cells[clmDecreaseCodsec.Index].Value);
                    this.Close();
                    break;
            }
        }

        private void frmDecreaseSelector_Load(object sender, EventArgs e)
        {
            List<clsDecrease> lstDecrease = new List<clsDecrease>();
            lstDecrease.Clear();
            lstDecrease = clsDecrease.getListForMainCoil();
            dgvDecreaseList.Rows.Clear();
            for (int i = 0; i < lstDecrease.Count; i++)
            {
                dgvDecreaseList.Rows.Add();  
                dgvDecreaseList.Rows[i].Cells["clmDecreaseCodsec"].Value = lstDecrease[i].codsec.ToString();
                dgvDecreaseList.Rows[i].Cells["clmDecreaseName"].Value = lstDecrease[i].name;
                dgvDecreaseList.Rows[i].Cells["clmDecreaseDescription"].Value = lstDecrease[i].description;
            }
        }

        private void btnDecreaseAccept_Click(object sender, EventArgs e)
        {
            returnMainCoil();
        }

        private void dgvDecreaseList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            returnMainCoil();
        }

        private void btnDecreaseClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}