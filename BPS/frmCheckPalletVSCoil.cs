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
    public partial class frmCheckPalletVSCoil : Form
    {
        private void fillDetail()
        {
            dgvCoil.Rows.Clear();

            //for (int i = 0; i < lstReceptionRawMaterialDetail.Count; i++)
            //{
            //    dgvCoil.Rows.Add();
            //    dgvCoil.Rows[i].Cells[clmCodsec.Index].Value = lstReceptionRawMaterialDetail[i].codsec;
                

            //}
        }

        public frmCheckPalletVSCoil()
        {
            InitializeComponent();
        }

        public frmCheckPalletVSCoil(int ReceptionCodsec, double palletnet, double coil)
        {
            InitializeComponent();
            //objReception.load(ReceptionCodsec);
            //objPurchaseOrder.load(objReception.fkPurchaseOrder);
            //lstReceptionRawMaterialDetail = clsReceptionRawMaterialDetail.getRawMaterialByReceptionList(ReceptionCodsec);

        }

        private void frmCheckPalletVSCoil_Load_1(object sender, EventArgs e)
        {

        }
    }
}
