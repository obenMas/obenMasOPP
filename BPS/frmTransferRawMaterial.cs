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
    public partial class frmTransferRawMaterial : Form
    {
        public frmTransferRawMaterial()
        {
            InitializeComponent();
        }
        double TotalRecepted = 0;
      
        

        public void populateDataGrid()
        {
            List<clsTransfer> lstTransfer = new List<clsTransfer>();    
            List<clsFilter> lstFilter = new List<clsFilter>();

            dgvDetail.Rows.Clear();
            if (chkDateFilter.Checked || chkCellar.Checked || chkCustomerFilter.Checked || chkRMTFilter.Checked || checkBox1.Checked || chkUser.Checked)
            {
                if (chkCustomerFilter.Checked && cmbProvider.SelectedIndex > -1)
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "transf_fkEntity";
                    lstFilter[lstFilter.Count - 1].operation = "equal";
                    lstFilter[lstFilter.Count - 1].value = ((clsEntity)cmbProvider.SelectedItem).codsec.ToString();
                    lstFilter[lstFilter.Count - 1].dataType = "int";
                }
                if (chkDateFilter.Checked)
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "transf_createdDate";
                    lstFilter[lstFilter.Count - 1].operation = "between";
                    lstFilter[lstFilter.Count - 1].value = dtpFrom.Value.ToString("dd/MM/yyyy");
                    lstFilter[lstFilter.Count - 1].value2 = dtpTo.Value.ToString("dd/MM/yyyy");
                    lstFilter[lstFilter.Count - 1].dataType = "dateTime";
                }
                if (chkCellar.Checked)
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "transf_fkCellarByExtruder";
                    lstFilter[lstFilter.Count - 1].operation = "equal";
                    lstFilter[lstFilter.Count - 1].value = ((clsCellarByExtruder)cmbCellar.SelectedItem).codsec.ToString();
                    lstFilter[lstFilter.Count - 1].dataType = "int";
                }

                if (chkRMTFilter.Checked && cmbRmt.SelectedIndex > -1)
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "transf_fkRawMaterialType";
                    lstFilter[lstFilter.Count - 1].operation = "equal";
                    lstFilter[lstFilter.Count - 1].value = ((clsRawMaterialtype)cmbRmt.SelectedItem).codsec.ToString();
                    lstFilter[lstFilter.Count - 1].dataType = "int";
                }

                if (checkBox1.Checked && cmbRm.SelectedIndex > -1)
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "transf_fkRawMaterial";
                    lstFilter[lstFilter.Count - 1].operation = "equal";
                    lstFilter[lstFilter.Count - 1].value = ((clsRawMaterial)cmbRm.SelectedItem).codsec.ToString();
                    lstFilter[lstFilter.Count - 1].dataType = "int";
                }

                if (chkUser.Checked && cmbUser.SelectedIndex > -1)
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "transf_createdBy";
                    lstFilter[lstFilter.Count - 1].operation = "equal";
                    lstFilter[lstFilter.Count - 1].value = ((clsUser)cmbUser.SelectedItem).codsec.ToString();
                    lstFilter[lstFilter.Count - 1].dataType = "int";
                }



                lstTransfer = clsTransfer.getListByFilter(lstFilter);
            }
            else
                lstTransfer = clsTransfer.getList();

            TotalRecepted = 0;
            for (int i = 0; i < lstTransfer.Count; i++)
            {
                dgvDetail.Rows.Add();
                dgvDetail.Rows[i].Cells["clmfkTransfer"].Value = lstTransfer[i].codsec.ToString();
                dgvDetail.Rows[i].Cells["clmTransferNumber"].Value = lstTransfer[i].number.ToString();
                dgvDetail.Rows[i].Cells["clmRawMaterialProvider"].Value = lstTransfer[i].EntityName.ToString();
                dgvDetail.Rows[i].Cells["clmRawMaterialType"].Value = lstTransfer[i].rawMaterialTypeName.ToString();
                dgvDetail.Rows[i].Cells["clmRawMaterialCode"].Value = lstTransfer[i].rawMaterialCode.ToString();
                dgvDetail.Rows[i].Cells["clmRawMaterialName"].Value = lstTransfer[i].rawMaterialName.ToString();
                dgvDetail.Rows[i].Cells["clmQuantity"].Value = lstTransfer[i].amountTransferred.ToString();
                dgvDetail.Rows[i].Cells["clmCellar"].Value = lstTransfer[i].cellarName.ToString();
                dgvDetail.Rows[i].Cells["clmRawMaterialDate"].Value = lstTransfer[i].createdDate.ToString();
                dgvDetail.Rows[i].Cells["clmUser"].Value = lstTransfer[i].creatorUser.ToString();
                TotalRecepted += Convert.ToDouble(lstTransfer[i].amountTransferred);
            }
            txtTotal.Text = TotalRecepted.ToString();
        }

        private void frmTransferRawMaterial_Load(object sender, EventArgs e)
        {

            populateDataGrid();
            List<clsEntity> lstEntity = clsEntity.getProviderList();
            List<clsRawMaterial> lstRawMaterial = clsRawMaterial.getList();
            List<clsRawMaterialtype> lstRawMaterialtype = clsRawMaterialtype.getList();
            List<clsCellarByExtruder> lstCellarByExtruder = clsCellarByExtruder.getList();
            List<clsUser> lstUser = clsUser.getList();

            for (int i = 0; i < lstEntity.Count; i++)
                cmbProvider.Items.Add(lstEntity[i]);

            for (int i = 0; i < lstRawMaterial.Count; i++)
                cmbRm.Items.Add(lstRawMaterial[i]);

            for (int i = 0; i < lstRawMaterialtype.Count; i++)
                cmbRmt.Items.Add(lstRawMaterialtype[i]);

            for (int i = 0; i < lstUser.Count; i++)
                cmbUser.Items.Add(lstUser[i]);

            for (int i = 0; i < lstCellarByExtruder.Count; i++)
                cmbCellar.Items.Add(lstCellarByExtruder[i]);


            List<clsTransfer> lstTransfer = clsTransfer.getList();
            dgvDetail.Rows.Clear();
            TotalRecepted = 0;
            for (int i = 0; i < lstTransfer.Count; i++)
            {
                dgvDetail.Rows.Add(); 
                dgvDetail.Rows[i].Cells["clmfkTransfer"].Value = lstTransfer[i].codsec.ToString();
                dgvDetail.Rows[i].Cells["clmTransferNumber"].Value = lstTransfer[i].number.ToString();
                dgvDetail.Rows[i].Cells["clmRawMaterialProvider"].Value = lstTransfer[i].EntityName.ToString();
                dgvDetail.Rows[i].Cells["clmRawMaterialType"].Value = lstTransfer[i].rawMaterialTypeName.ToString();
                dgvDetail.Rows[i].Cells["clmRawMaterialCode"].Value = lstTransfer[i].rawMaterialCode.ToString();
                dgvDetail.Rows[i].Cells["clmRawMaterialName"].Value = lstTransfer[i].rawMaterialName.ToString();
                dgvDetail.Rows[i].Cells["clmQuantity"].Value = lstTransfer[i].amountTransferred.ToString();
                dgvDetail.Rows[i].Cells["clmCellar"].Value = lstTransfer[i].cellarName.ToString();
                dgvDetail.Rows[i].Cells["clmRawMaterialDate"].Value = lstTransfer[i].createdDate.ToString();
                dgvDetail.Rows[i].Cells["clmUser"].Value = lstTransfer[i].creatorUser.ToString();
                TotalRecepted += Convert.ToDouble(lstTransfer[i].amountTransferred);
            }
            txtTotal.Text = TotalRecepted.ToString();
        }

        private void chkDateFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDateFilter.Checked)
                grpbDates.Enabled = true;
            else
                grpbDates.Enabled = false;
        }

        private void chkCustomerFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCustomerFilter.Checked)
                grpbProviders.Enabled = true;
            else
                grpbProviders.Enabled = false;
        }

        private void chkRMTFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRMTFilter.Checked)
                grpbRmt.Enabled = true;
            else
                grpbRmt.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                grpbRm.Enabled = true;
            else
                grpbRm.Enabled = false;
        }

        private void chkCellar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCellar.Checked)
                grpbCellar.Enabled = true;
            else
                grpbCellar.Enabled = false;
        }

        private void chkUser_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUser.Checked)
                grpbUser.Enabled = true;
            else
                grpbUser.Enabled = false;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            populateDataGrid();
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            chkDateFilter.Checked = false;
            chkCellar.Checked = false;
            chkCustomerFilter.Checked = false;
            chkRMTFilter.Checked = false;
            checkBox1.Checked = false;
            chkUser.Checked = false;
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
            cmbProvider.SelectedIndex = -1;
            txtProviderId.Text = "";
            cmbRm.SelectedIndex = -1;
            cmbRmt.SelectedIndex = -1;
            cmbUser.SelectedIndex = -1;
            cmbCellar.SelectedIndex = -1;
            populateDataGrid();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            frmDeliverRawMaterial winDeliverRawMaterial = new frmDeliverRawMaterial();
           
            winDeliverRawMaterial.StartPosition = FormStartPosition.Manual;
            winDeliverRawMaterial.Show();
        }
    }
}
