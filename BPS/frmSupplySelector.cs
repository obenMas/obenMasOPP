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
    public partial class frmSupplySelector : Form
    {
        frmSupplyForm prntSupplyForm;
        string CALLerForm = "";

        public frmSupplySelector(frmSupplyForm winSupplyForm)
        {
            InitializeComponent();
            prntSupplyForm = winSupplyForm;
            CALLerForm = "SupplyForm";
        }


        public void returnSupplySelector()
        {
            switch (CALLerForm)
            {
                case "SupplyForm":
                    prntSupplyForm.selectedSupply = Convert.ToInt32(dgvSupply.SelectedRows[0].Cells[clmSupplyCodsec.Index].Value);
                    this.Close();
                    break;
            }
        }
        public frmSupplySelector()
        {
            InitializeComponent();
        }

        private void frmSupplySelector_Load(object sender, EventArgs e)
        {
            List<clsSupply> lstSupply = clsSupply.getList();
            dgvSupply.Rows.Clear();
            for (int i = 0; i < lstSupply.Count; i++)
            {
                dgvSupply.Rows.Add();
                dgvSupply.Rows[i].Cells["clmSupplyCodsec"].Value = lstSupply[i].codsec.ToString();
                dgvSupply.Rows[i].Cells["clmSupplyfkEntity"].Value = lstSupply[i].fkEntity;
                dgvSupply.Rows[i].Cells["clmSupplyEntity"].Value = lstSupply[i].EntityName;
                dgvSupply.Rows[i].Cells["clmSupplyName"].Value = lstSupply[i].name;
                dgvSupply.Rows[i].Cells["clmSupplyCode"].Value = lstSupply[i].code;
                dgvSupply.Rows[i].Cells["clmSupplyUnit"].Value = lstSupply[i].UnitName;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            returnSupplySelector();
        }

        private void dgvSupply_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            returnSupplySelector();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}