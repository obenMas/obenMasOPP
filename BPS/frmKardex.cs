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
    public partial class frmKardex : Form
    {
        public frmKardex()
        {
            InitializeComponent();
        }


        //funcion nueva


        public void populateDataGrid()
        {
            List<clsKardex> lstKardex = new List<clsKardex>();
            List<clsFilter> lstFilter = new List<clsFilter>();

            dgvDetail.Rows.Clear();
            if (chkDateFilter.Checked || chkCustomerFilter.Checked || chkRMTFilter.Checked || chkRMNameFilter.Checked || chkRMCodeFilter.Checked || chkRMCellarFilter.Checked)
            {
                if (chkCustomerFilter.Checked && cmbProvider.SelectedIndex > -1)
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "kdx_fkEntity";
                    lstFilter[lstFilter.Count - 1].operation = "equal";
                    lstFilter[lstFilter.Count - 1].value = ((clsEntity)cmbProvider.SelectedItem).codsec.ToString();
                    lstFilter[lstFilter.Count - 1].dataType = "int";
                }
                if (chkDateFilter.Checked)
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "kdx_date";
                    lstFilter[lstFilter.Count - 1].operation = "between";
                    lstFilter[lstFilter.Count - 1].value = dtpFrom.Value.ToString("dd/MM/yyyy");
                    lstFilter[lstFilter.Count - 1].value2 = dtpTo.Value.ToString("dd/MM/yyyy");
                    lstFilter[lstFilter.Count - 1].dataType = "dateTime";
                }
                
                if (chkRMTFilter.Checked && cmbRmt.SelectedIndex > -1)
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "kdx_fkRawMaterialType";
                    lstFilter[lstFilter.Count - 1].operation = "equal"; 
                    lstFilter[lstFilter.Count - 1].value = ((clsRawMaterialtype)cmbRmt.SelectedItem).codsec.ToString();
                    lstFilter[lstFilter.Count - 1].dataType = "int";
                }

                if (chkRMTFilter.Checked && cmbRMName.SelectedIndex > -1)
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "kdx_RawMaterialName";
                    lstFilter[lstFilter.Count - 1].operation = "equal";
                    lstFilter[lstFilter.Count - 1].value = ((clsRawMaterial)cmbRMName.SelectedItem).codsec.ToString();
                    lstFilter[lstFilter.Count - 1].dataType = "int";
                }

                if (chkRMTFilter.Checked && cmbRMCode.SelectedIndex > -1)
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "kdx_RawMaterialCode";
                    lstFilter[lstFilter.Count - 1].operation = "equal";
                    lstFilter[lstFilter.Count - 1].value = ((clsRawMaterial)cmbRMCode.SelectedItem).codsec.ToString();
                    lstFilter[lstFilter.Count - 1].dataType = "int";
                }

                if (chkRMTFilter.Checked && cmbRMCellar.SelectedIndex > -1)
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "kdx_fkCellar";
                    lstFilter[lstFilter.Count - 1].operation = "equal";
                    lstFilter[lstFilter.Count - 1].value = ((clsCellar)cmbRMCellar.SelectedItem).codsec.ToString();
                    lstFilter[lstFilter.Count - 1].dataType = "int";
                }



                lstKardex = clsKardex.getListByFilter(lstFilter);
            }
            else
                lstKardex = clsKardex.getList();

            for (int i = 0; i < lstKardex.Count; i++)
            {

                dgvDetail.Rows.Add();
                dgvDetail.Rows[i].Cells["clmCodsec"].Value = lstKardex[i].codsec.ToString();
                dgvDetail.Rows[i].Cells["clmEntityName"].Value = lstKardex[i].EntityName.ToString();
                dgvDetail.Rows[i].Cells["clmRawMaterialType"].Value = lstKardex[i].RawMaterialTypeName.ToString();
                dgvDetail.Rows[i].Cells["clmRawMaterialName"].Value = lstKardex[i].RawMaterialName.ToString();
                dgvDetail.Rows[i].Cells["clmRawMaterialCode"].Value = lstKardex[i].RawMaterialCode.ToString();
                dgvDetail.Rows[i].Cells["clmCellarName"].Value = lstKardex[i].CellarName.ToString();
                dgvDetail.Rows[i].Cells["clmQuantityIn"].Value = lstKardex[i].quantityIn.ToString();
                dgvDetail.Rows[i].Cells["clmQuantityOut"].Value = lstKardex[i].quantityOut.ToString();
                dgvDetail.Rows[i].Cells["clmBalance"].Value = lstKardex[i].balance.ToString();
                dgvDetail.Rows[i].Cells["clmCost"].Value = lstKardex[i].cost.ToString();
                dgvDetail.Rows[i].Cells["clmQuote"].Value = lstKardex[i].quote.ToString();
                dgvDetail.Rows[i].Cells["clmDescription"].Value = lstKardex[i].description.ToString();
                dgvDetail.Rows[i].Cells["clmDate"].Value = lstKardex[i].date.ToString();


                
            }
            
        }

        //fin funcion nueva

        private void frmKardex_Load(object sender, EventArgs e)
        {
            populateDataGrid();
            List<clsEntity> lstEntity = clsEntity.getProviderList();
            List<clsRawMaterial> lstRawMaterial = clsRawMaterial.getList();
            List<clsRawMaterialtype> lstRawMaterialtype = clsRawMaterialtype.getList();
            List<clsCellar> lstCellar = clsCellar.getList();


            for (int i = 0; i < lstEntity.Count; i++)
                cmbProvider.Items.Add(lstEntity[i]);

            for (int i = 0; i < lstRawMaterial.Count; i++)
                cmbRMCode.Items.Add(lstRawMaterial[i]);

            for (int i = 0; i < lstRawMaterial.Count; i++)
                cmbRMName.Items.Add(lstRawMaterial[i]);

            for (int i = 0; i < lstRawMaterialtype.Count; i++)
                cmbRmt.Items.Add(lstRawMaterialtype[i]);


            for (int i = 0; i < lstCellar.Count; i++)
                cmbRMCellar.Items.Add(lstCellar[i]);
            
            
            List<clsKardex> lstKardex = new List<clsKardex>();
            lstKardex = clsKardex.getList();

            for (int i = 0; i < lstKardex.Count; i++)
            {

                dgvDetail.Rows.Add();
                dgvDetail.Rows[i].Cells["clmCodsec"].Value = lstKardex[i].codsec.ToString();
                dgvDetail.Rows[i].Cells["clmEntityName"].Value = lstKardex[i].EntityName.ToString();
                dgvDetail.Rows[i].Cells["clmRawMaterialType"].Value = lstKardex[i].RawMaterialTypeName.ToString();
                dgvDetail.Rows[i].Cells["clmRawMaterialName"].Value = lstKardex[i].RawMaterialName.ToString();
                dgvDetail.Rows[i].Cells["clmRawMaterialCode"].Value = lstKardex[i].RawMaterialCode.ToString();
                dgvDetail.Rows[i].Cells["clmCellarName"].Value = lstKardex[i].CellarName.ToString();
                dgvDetail.Rows[i].Cells["clmQuantityIn"].Value = lstKardex[i].quantityIn.ToString();
                dgvDetail.Rows[i].Cells["clmQuantityOut"].Value = lstKardex[i].quantityOut.ToString();
                dgvDetail.Rows[i].Cells["clmBalance"].Value = lstKardex[i].balance.ToString();
                dgvDetail.Rows[i].Cells["clmCost"].Value = lstKardex[i].cost.ToString();
                dgvDetail.Rows[i].Cells["clmQuote"].Value = lstKardex[i].quote.ToString();
                dgvDetail.Rows[i].Cells["clmDescription"].Value = lstKardex[i].description.ToString();
                dgvDetail.Rows[i].Cells["clmDate"].Value = lstKardex[i].date.ToString();
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

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

        private void chkRMNameFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRMNameFilter.Checked)
                grpbRmN.Enabled = true;
            else
                grpbRmN.Enabled = false;
        }

        private void chkRMCodeFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRMCodeFilter.Checked)
                grpbRmC.Enabled = true;
            else
                grpbRmC.Enabled = false;
        }

        private void chkRMCellarFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRMCellarFilter.Checked)
                grpbCellar.Enabled = true;
            else
                grpbCellar.Enabled = false;
            
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            populateDataGrid();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            chkDateFilter.Checked = false;
            chkRMCellarFilter.Checked = false;
            chkCustomerFilter.Checked = false;
            chkRMTFilter.Checked = false;
            chkRMCodeFilter.Checked = false;
            chkRMNameFilter.Checked = false;
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
            cmbProvider.SelectedIndex = -1;
           
            
            cmbRmt.SelectedIndex = -1;
            cmbRMCellar.SelectedIndex = -1;
            cmbRMCode.SelectedIndex = -1;
            cmbRMName.SelectedIndex = -1;
            
            populateDataGrid();
        }
    }
}