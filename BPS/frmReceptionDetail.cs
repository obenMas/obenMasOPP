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
    public partial class frmReceptionDetail : Form
    {
        clsReception objReception = new clsReception();
        clsPurchaseOrder objPurchaseOrder = new clsPurchaseOrder();
        List<clsReceptionRawMaterialDetail> lstReceptionRawMaterialDetail = new List<clsReceptionRawMaterialDetail>();


        private void fillDetail()
        {
            dgvReception.Rows.Clear();

            for (int i = 0; i < lstReceptionRawMaterialDetail.Count; i++)
            {
                dgvReception.Rows.Add();
                dgvReception.Rows[i].Cells[clmCodsec.Index].Value = lstReceptionRawMaterialDetail[i].codsec;
                dgvReception.Rows[i].Cells[clmReceptionPackageCode.Index].Value = lstReceptionRawMaterialDetail[i].codePackage;
                dgvReception.Rows[i].Cells[clmRawMaterialType.Index].Value = lstReceptionRawMaterialDetail[i].RawMaterialTypeName;
                dgvReception.Rows[i].Cells[clmRawMaterialName.Index].Value = lstReceptionRawMaterialDetail[i].RawMaterialName;
                dgvReception.Rows[i].Cells[clmRawMaterialCode.Index].Value = lstReceptionRawMaterialDetail[i].RawMaterialCode;
                dgvReception.Rows[i].Cells[clmQuantity.Index].Value = lstReceptionRawMaterialDetail[i].weigthPerPackage;
                dgvReception.Rows[i].Cells[clmUnits.Index].Value = lstReceptionRawMaterialDetail[i].unitsPerPackage;
                dgvReception.Rows[i].Cells[clmWeigthPerUnit.Index].Value = lstReceptionRawMaterialDetail[i].unitWeight;
                dgvReception.Rows[i].Cells[clmAvailablePackages.Index].Value = lstReceptionRawMaterialDetail[i].avaliableUnits;
                dgvReception.Rows[i].Cells[clmPrint.Index].Value = global::BPS.Properties.Resources.printer;

            }
        }

        public frmReceptionDetail()
        {
            InitializeComponent();
        }

        public frmReceptionDetail(int ReceptionCodsec)
        {
            InitializeComponent();
            objReception.load(ReceptionCodsec);
            objPurchaseOrder.load(objReception.fkPurchaseOrder);
            lstReceptionRawMaterialDetail = clsReceptionRawMaterialDetail.getRawMaterialByReceptionList(ReceptionCodsec);

        }

        private void frmReceptionDetail_Load(object sender, EventArgs e)
        {
            fillDetail();
        }
    }
}
