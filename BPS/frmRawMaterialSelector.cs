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
    public partial class frmRawMaterialSelector : Form
    {
        #region Init

        frmFormulationsBoppForm prntRawMaterialBoppForm;
        frmFormulationsCastForm prntRawMaterialCastForm;
        frmRawMaterialConsumptionByExtruder prntRawMaterialConsumtion;
        frmPurchaseOrder prntPurchaseOrder;
        frmFormulationBopp prntRawMaterialBopp;
        frmMain prntMain;

        string CALLerForm = "";

        public frmRawMaterialSelector()
        {
            InitializeComponent();
        }

        public frmRawMaterialSelector(frmFormulationsBoppForm winFormulationBoppForm)
        {
            InitializeComponent();
            prntRawMaterialBoppForm = winFormulationBoppForm;
            CALLerForm = "FormulationsBoppForm";
        }
        public frmRawMaterialSelector(frmFormulationBopp winFormulationBopp)
        {
            InitializeComponent();
            prntRawMaterialBopp = winFormulationBopp;
            CALLerForm = "FormulationBopp";
        }

        public frmRawMaterialSelector(frmFormulationsCastForm winFormulationCastForm)
        {
            InitializeComponent();
            prntRawMaterialCastForm = winFormulationCastForm;
            CALLerForm = "FormulationsCastForm";
        }

        public frmRawMaterialSelector(frmMain winMain)
        {
            InitializeComponent();
            prntMain = winMain;
            CALLerForm = "Main";
        }

        public frmRawMaterialSelector(frmRawMaterialConsumptionByExtruder winRawMaterialSelector)
        {
            InitializeComponent();
            prntRawMaterialConsumtion = winRawMaterialSelector;
            CALLerForm = "RawMaterialConsumption";
            btnAdd.Enabled = true;
            btnAdd.Visible = true;
        }

        public frmRawMaterialSelector(frmPurchaseOrder winPurchaseOrder)
        {
            InitializeComponent();
            prntPurchaseOrder = winPurchaseOrder;
            CALLerForm = "PurchaseOrder";
            btnAdd.Enabled = false;
            btnAdd.Visible = false;
        }

        private void frmRawMaterialSelector_Load(object sender, EventArgs e)
        {
            fillRawMaterialGrid("");
        }

        public void fillRawMaterialGrid(string source)
        {
            List<clsRawMaterial> lstRawMaterial = new List<clsRawMaterial>();
            List<clsFilter> lstFilter = new List<clsFilter>();

            if (source == "code")
            {
                if (!string.IsNullOrEmpty(txtCode.Text))
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "rwm_code";
                    lstFilter[lstFilter.Count - 1].operation = "startsWith";
                    lstFilter[lstFilter.Count - 1].value = txtCode.Text;
                    lstFilter[lstFilter.Count - 1].dataType = "varchar";
                }

                lstRawMaterial = clsRawMaterial.getListByFilterRaw(lstFilter);
            }
            else if (source == "provider")
            {
                if (!string.IsNullOrEmpty(txtProvider.Text))
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "rwm_companyName";
                    lstFilter[lstFilter.Count - 1].operation = "startsWith";
                    lstFilter[lstFilter.Count - 1].value = txtProvider.Text;
                    lstFilter[lstFilter.Count - 1].dataType = "varchar";
                }

                lstRawMaterial = clsRawMaterial.getListByFilterRaw(lstFilter);
            }
            else if (source == "tmp")
            {
                if (!string.IsNullOrEmpty(txtTMP.Text))
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "rwm_rawTypeName";
                    lstFilter[lstFilter.Count - 1].operation = "startsWith";
                    lstFilter[lstFilter.Count - 1].value = txtTMP.Text;
                    lstFilter[lstFilter.Count - 1].dataType = "varchar";
                }

                lstRawMaterial = clsRawMaterial.getListByFilterRaw(lstFilter);
            }
            else
                lstRawMaterial = clsRawMaterial.getListRaw();

            dgvRawMaterial.Rows.Clear();

            for (int i = 0; i < lstRawMaterial.Count; i++)
            {
                dgvRawMaterial.Rows.Add();
                dgvRawMaterial.Rows[i].Cells["clmRawMaterialCodsec"].Value = lstRawMaterial[i].codsec;
                dgvRawMaterial.Rows[i].Cells["clmRawMaterialType"].Value = lstRawMaterial[i].RawMaterialtypeName;
                dgvRawMaterial.Rows[i].Cells["clmRawMaterialEntity"].Value = lstRawMaterial[i].EntityName;
                dgvRawMaterial.Rows[i].Cells["clmRawMaterialCode"].Value = lstRawMaterial[i].code.Trim().ToUpper();
                dgvRawMaterial.Rows[i].Cells["clmRawMaterialUnit"].Value = lstRawMaterial[i].name;
            }
        }

        #endregion

        #region Helper

        public void returnRawMaterial()
        {
            switch (CALLerForm)
            {
                case "FormulationsBoppForm":
                    prntRawMaterialBoppForm.selectedRawMaterial = Convert.ToInt32(dgvRawMaterial.SelectedRows[0].Cells[clmRawMaterialCodsec.Index].Value);
                    this.Close();
                    break;

                case "FormulationsCastForm":
                    prntRawMaterialCastForm.selectedRawMaterial = Convert.ToInt32(dgvRawMaterial.SelectedRows[0].Cells[clmRawMaterialCodsec.Index].Value);
                    this.Close();
                    break;

                case "RawMaterialConsumption":
                    prntRawMaterialConsumtion.selectedRawMaterial = Convert.ToInt32(dgvRawMaterial.SelectedRows[0].Cells[clmRawMaterialCodsec.Index].Value);
                    this.Close();
                    break;

                case "PurchaseOrder":
                    prntPurchaseOrder.selectedRawMaterial = Convert.ToInt32(dgvRawMaterial.SelectedRows[0].Cells[clmRawMaterialCodsec.Index].Value);
                    this.Close();
                    break;

                case "FormulationBopp":
                    prntRawMaterialBopp.selectedRawMaterial = Convert.ToInt32(dgvRawMaterial.SelectedRows[0].Cells[clmRawMaterialCodsec.Index].Value);
                    this.Close();
                    break;
            }
        }

        #endregion

        #region Actions

        private void btnAccept_Click(object sender, EventArgs e)
        {
            returnRawMaterial();
        }

        private void dgvRawMaterial_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            returnRawMaterial();
        }

        private void txtCustomerId_TextChanged(object sender, EventArgs e)
        {
            fillRawMaterialGrid("code");
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            fillRawMaterialGrid("provider");
        }

        private void txtTMP_TextChanged(object sender, EventArgs e)
        {
            fillRawMaterialGrid("tmp");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddRawMaterialSelector winraw = new frmAddRawMaterialSelector();
            winraw.StartPosition = FormStartPosition.CenterScreen;
            winraw.ShowDialog();
        }

        #endregion




    }
}