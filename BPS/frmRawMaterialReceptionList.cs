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
    public partial class frmRawMaterialReceptionList : Form
    {
        public frmRawMaterialReceptionList()
        {
            InitializeComponent();
        }
        double TotalRecepted = 0;

        public void populateDataGrid()
        {
            List<clsReception> lstReception = new List<clsReception>();
            List<clsFilter> lstFilter = new List<clsFilter>();

            dgvDetail.Rows.Clear();
            if (chkDateFilter.Checked || chkNumberFilter.Checked || chkCustomerFilter.Checked || chkRMTFilter.Checked || checkBox1.Checked || chbxStatus.Checked || chkUser.Checked)
            {
                if (chkCustomerFilter.Checked && cmbProvider.SelectedIndex > -1)
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "rcp_fkEntity";
                    lstFilter[lstFilter.Count - 1].operation = "equal";
                    lstFilter[lstFilter.Count - 1].value = ((clsEntity)cmbProvider.SelectedItem).codsec.ToString();
                    lstFilter[lstFilter.Count - 1].dataType = "int";
                }
                if (chkDateFilter.Checked)
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "rcp_createdDate";
                    lstFilter[lstFilter.Count - 1].operation = "between";
                    lstFilter[lstFilter.Count - 1].value = dtpFrom.Value.ToString("dd/MM/yyyy");
                    lstFilter[lstFilter.Count - 1].value2 = dtpTo.Value.ToString("dd/MM/yyyy");
                    lstFilter[lstFilter.Count - 1].dataType = "dateTime";
                }
                if (chkNumberFilter.Checked)
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "rcp_PurchaseOrderNumer";
                    lstFilter[lstFilter.Count - 1].operation = "between";
                    lstFilter[lstFilter.Count - 1].value = txtNumberFrom.Text;
                    lstFilter[lstFilter.Count - 1].value2 = txtNumberTo.Text;
                    lstFilter[lstFilter.Count - 1].dataType = "int";
                }
                if (chbxStatus.Checked && cmbStatus.SelectedIndex > -1)
                {
                    lstFilter.Add(new clsFilter()); 
                    lstFilter[lstFilter.Count - 1].field = "rcp_fkStatus";
                    lstFilter[lstFilter.Count - 1].operation = "equal";
                    lstFilter[lstFilter.Count - 1].value = ((clsStatus)cmbStatus.SelectedItem).codsec.ToString();
                    lstFilter[lstFilter.Count - 1].dataType = "int";
                }

                if (chkRMTFilter.Checked && cmbRmt.SelectedIndex > -1)
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "rcp_fkRawMaterialType";
                    lstFilter[lstFilter.Count - 1].operation = "equal";
                    lstFilter[lstFilter.Count - 1].value = ((clsRawMaterialtype)cmbRmt.SelectedItem).codsec.ToString();
                    lstFilter[lstFilter.Count - 1].dataType = "int";
                }

                if (checkBox1.Checked && cmbRm.SelectedIndex > -1)
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "rcp_fkRawMaterial";
                    lstFilter[lstFilter.Count - 1].operation = "equal";
                    lstFilter[lstFilter.Count - 1].value = ((clsRawMaterial)cmbRm.SelectedItem).codsec.ToString();
                    lstFilter[lstFilter.Count - 1].dataType = "int";
                }

                if (chkUser.Checked && cmbUser.SelectedIndex > -1)
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "rcp_createdBy";
                    lstFilter[lstFilter.Count - 1].operation = "equal";
                    lstFilter[lstFilter.Count - 1].value = ((clsUser)cmbUser.SelectedItem).codsec.ToString();
                    lstFilter[lstFilter.Count - 1].dataType = "int";
                }
               
                if (chkNumberFilter.Checked && txtNumberFrom.Text != "")
                {
                    if (txtNumberTo.Text != "")
                    {
                        lstFilter.Add(new clsFilter());
                        lstFilter[lstFilter.Count - 1].field = "rcp_PurchaseOrderNumer";
                        lstFilter[lstFilter.Count - 1].operation = "between";
                        lstFilter[lstFilter.Count - 1].value = txtNumberFrom.Text;
                        lstFilter[lstFilter.Count - 1].value2 = txtNumberTo.Text;
                        lstFilter[lstFilter.Count - 1].dataType = "int";
                    }
                    else
                    {
                        lstFilter.Add(new clsFilter());
                        lstFilter[lstFilter.Count - 1].field = "rcp_PurchaseOrderNumer";
                        lstFilter[lstFilter.Count - 1].operation = "equal";
                        lstFilter[lstFilter.Count - 1].value = txtNumberFrom.Text;
                        lstFilter[lstFilter.Count - 1].dataType = "int";
                    }
                }

                lstReception = clsReception.getListByFilter(lstFilter);
            }
            else
                lstReception = clsReception.getList();

            TotalRecepted = 0;
            for (int i = 0; i < lstReception.Count; i++)
            {
                dgvDetail.Rows.Add();
                dgvDetail.Rows[i].Cells["clmRawMaterialReceptionCodsec"].Value = lstReception[i].codsec.ToString();
                dgvDetail.Rows[i].Cells["clmPurchaseOrder"].Value = lstReception[i].PurchaseOrderNumer.ToString();
                dgvDetail.Rows[i].Cells["clmRawMaterialProvider"].Value = lstReception[i].EntityName.ToString();
                dgvDetail.Rows[i].Cells["clmRawMaterialType"].Value = lstReception[i].RawMaterialTypeName.ToString();
                dgvDetail.Rows[i].Cells["clmRawMaterialCode"].Value = lstReception[i].RawMaterialCode.ToString();
                dgvDetail.Rows[i].Cells["clmRawMaterialName"].Value = lstReception[i].RawMaterialName.ToString();
                dgvDetail.Rows[i].Cells["clmBatch"].Value = lstReception[i].batch.ToString();
                dgvDetail.Rows[i].Cells["clmQuantity"].Value = lstReception[i].quantity.ToString();
                dgvDetail.Rows[i].Cells["clmStatus"].Value = lstReception[i].statusName.ToString();
                dgvDetail.Rows[i].Cells["clmRawMaterialDate"].Value = lstReception[i].createdDate.ToString();
                dgvDetail.Rows[i].Cells["clmUser"].Value = lstReception[i].creatorUser.ToString();
                dgvDetail.Rows[i].Cells[clmViewDetail.Index].Value = global::BPS.Properties.Resources.eye;
                TotalRecepted += Convert.ToDouble(lstReception[i].quantity);
            }
        }

        private void frmRawMaterialReceptionList_Load(object sender, EventArgs e)
        {
            populateDataGrid();
            List<clsEntity> lstEntity = clsEntity.getProviderList();
            List<clsStatus> lstStatus = clsStatus.getListByStatusGroupName("Ordenes de Compra");
            List<clsRawMaterial> lstRawMaterial = clsRawMaterial.getList();
            List<clsRawMaterialtype> lstRawMaterialtype = clsRawMaterialtype.getList();
            List<clsUser> lstUser = clsUser.getList();
            

            for (int i = 0; i < lstEntity.Count; i++)
                cmbProvider.Items.Add(lstEntity[i]);

            for (int i = 0; i < lstRawMaterial.Count; i++)
                cmbRm.Items.Add(lstRawMaterial[i]);

            for (int i = 0; i < lstRawMaterialtype.Count; i++)
                cmbRmt.Items.Add(lstRawMaterialtype[i]);
            
            for (int i = 0; i < lstUser.Count; i++)
                cmbUser.Items.Add(lstUser[i]);
            
            for (int i = 0; i < lstStatus.Count; i++)
                cmbStatus.Items.Add(lstStatus[i]);
            
            
            List<clsReception> lstReception = clsReception.getList();
            dgvDetail.Rows.Clear();
            TotalRecepted = 0;
            for (int i = 0; i < lstReception.Count; i++)
            {
                dgvDetail.Rows.Add();
                dgvDetail.Rows[i].Cells["clmRawMaterialReceptionCodsec"].Value = lstReception[i].codsec.ToString();
                dgvDetail.Rows[i].Cells["clmPurchaseOrder"].Value = lstReception[i].PurchaseOrderNumer.ToString();
                dgvDetail.Rows[i].Cells["clmRawMaterialProvider"].Value = lstReception[i].EntityName.ToString();
                dgvDetail.Rows[i].Cells["clmRawMaterialType"].Value = lstReception[i].RawMaterialTypeName.ToString();
                dgvDetail.Rows[i].Cells["clmRawMaterialCode"].Value = lstReception[i].RawMaterialCode.ToString();
                dgvDetail.Rows[i].Cells["clmRawMaterialName"].Value = lstReception[i].RawMaterialName.ToString();
                dgvDetail.Rows[i].Cells["clmBatch"].Value = lstReception[i].batch.ToString();
                dgvDetail.Rows[i].Cells["clmQuantity"].Value = lstReception[i].quantity.ToString();
                dgvDetail.Rows[i].Cells["clmStatus"].Value = lstReception[i].statusName.ToString();
                dgvDetail.Rows[i].Cells["clmRawMaterialDate"].Value = lstReception[i].createdDate.ToString();
                dgvDetail.Rows[i].Cells["clmUser"].Value = lstReception[i].creatorUser.ToString();
                dgvDetail.Rows[i].Cells[clmViewDetail.Index].Value = global::BPS.Properties.Resources.eye;
                TotalRecepted += Convert.ToDouble(lstReception[i].quantity);
            }
        }

        private void chkDateFilter_CheckedChanged(object sender, EventArgs e)
        { 
            if (chkDateFilter.Checked)
                grpbDates.Enabled = true;
            else
                grpbDates.Enabled = false;
        }

        private void chkNumberFilter_CheckedChanged(object sender, EventArgs e)
        { 
            if (chkNumberFilter.Checked)
                grpbNumber.Enabled = true;
            else
                grpbNumber.Enabled = false;
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

        private void chbxStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxStatus.Checked)
                grpbStatus.Enabled = true;
            else
                grpbStatus.Enabled = false;
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
            chkNumberFilter.Checked = false;
            chkCustomerFilter.Checked = false;
            chkRMTFilter.Checked = false;
            checkBox1.Checked = false;
            chbxStatus.Checked = false;
            chkUser.Checked = false;
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
            txtNumberFrom.Text = "";
            txtNumberTo.Text = "";
            cmbProvider.SelectedIndex = -1;
            txtProviderId.Text = "";
            cmbStatus.SelectedIndex = -1;
            cmbRm.SelectedIndex = -1;
            cmbRmt.SelectedIndex = -1;
            cmbUser.SelectedIndex = -1;
            populateDataGrid();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmRawMaterialReception winRawMaterialReception = new frmRawMaterialReception();
            winRawMaterialReception.MdiParent = this.MdiParent;
            winRawMaterialReception.Show();
            this.Close();
        }

        private void dgvDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmViewDetail.Index)
            {
                frmReceptionDetail winReceptionDetail = new frmReceptionDetail(Convert.ToInt32(dgvDetail.Rows[e.RowIndex].Cells[clmRawMaterialReceptionCodsec.Index].Value));
                winReceptionDetail.MdiParent = this.MdiParent;
                winReceptionDetail.StartPosition = FormStartPosition.Manual;
                winReceptionDetail.Show();
            }
        }
    }
}