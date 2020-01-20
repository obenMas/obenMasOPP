using System;
using System.Windows.Forms;
using BPS.Raw;

namespace BPS
{
    public partial class frmCalendar : Form
    {
        public frmExportMailCoil parentExportMainCoil;
        public frmShipping parentShipping;
        public frmExportPalletMovementPlus prntExportPalletMovementPlus;
        public frmExportReProcessPalletMovementPlus prntExportMillPalletMovementPlus;
        public frmExportPalletShippingPlus prntExportPalletShippingPlus;
        public frmExportRawMaterial prntExportRawMaterial;
        public frmExportRawMaterialS prntExportRawMaterialS;
        public frmExportReturnMovement prntExportReturnMovement;
        public frmExportMaquileMovement prntExportMaquileMovement;

        public string parentName = "";

        public frmCalendar()
        {
            InitializeComponent();
        }

        public frmCalendar(frmExportMailCoil winExportMainCoil)
        {
            InitializeComponent();
            parentExportMainCoil = winExportMainCoil;
            parentName = "exportMainCoil";
        }

        public frmCalendar(frmExportPalletMovementPlus winExportPallet)
        {
            InitializeComponent();
            prntExportPalletMovementPlus = winExportPallet;
            parentName = "exportPallet";
        }

        public frmCalendar(frmExportReProcessPalletMovementPlus winExportPallet)
        {
            InitializeComponent();
            prntExportMillPalletMovementPlus = winExportPallet;
            parentName = "exportMillPallet";
        }

        public frmCalendar(frmExportPalletShippingPlus winExportPalletShippingPlus)
        {
            InitializeComponent();
            prntExportPalletShippingPlus = winExportPalletShippingPlus;
            parentName = "exportPalletShippingPlus";
        }

        public frmCalendar(frmExportRawMaterial winExportRawMaterial)
        {
            InitializeComponent();
            prntExportRawMaterial = winExportRawMaterial;
            parentName = "exportRM";
        }

        public frmCalendar(frmExportRawMaterialS winExportRawMaterialS)
        {
            InitializeComponent();
            prntExportRawMaterialS = winExportRawMaterialS;
            parentName = "exportRMS";
        }

        public frmCalendar(frmExportReturnMovement winExportReturnMovement)
        {
            InitializeComponent();
            prntExportReturnMovement = winExportReturnMovement;
            parentName = "exportRMRETURN";
        }

        public frmCalendar(frmExportMaquileMovement winExportMaquileMovement)
        {
            InitializeComponent();
            prntExportMaquileMovement = winExportMaquileMovement;
            parentName = "exportRMMAQUILE";
        }

        public frmCalendar(frmShipping windate, string data)
        {
            InitializeComponent();
            parentShipping = windate;
            if (data == "estimateddate")
                parentName = "estimateddate";
            else if (data == "releasedate")
                parentName = "releasedate";
            else if (data == "pledgedate")
                parentName = "pledgedate";
            else if (data == "vapordate")
                parentName = "vapordate";
            else if (data == "thermaldate")
                parentName = "thermaldate";
        }

        private void frmCalendar_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            switch (parentName)
            {
                case "exportMainCoil":
                    parentExportMainCoil.selectedDate = dtpCalendar.Value;
                    break;

                case "estimateddate":
                    parentShipping.selectedestimateddate = dtpCalendar.Value;
                    break;

                case "releasedate":
                    parentShipping.selectedreleasedate = dtpCalendar.Value;
                    break;

                case "pledgedate":
                    parentShipping.selectedpledge = dtpCalendar.Value;
                    break;

                case "vapordate":
                    parentShipping.selectedvapor = dtpCalendar.Value;
                    break;

                case "thermaldate":
                    parentShipping.selectedthermal = dtpCalendar.Value;
                    break;

                case "exportPallet":
                    prntExportPalletMovementPlus.dtpEndMonth = dtpCalendar.Value;
                    break;

                case "exportMillPallet":
                    prntExportMillPalletMovementPlus.dtpEndMonth = dtpCalendar.Value;
                    break;

                case "exportPalletShippingPlus":
                    prntExportPalletShippingPlus.dtpEndMonth = dtpCalendar.Value;
                    break;

                case "exportRM":
                    prntExportRawMaterial.dtpEndMonth = dtpCalendar.Value;
                    break;

                case "exportRMS":
                    prntExportRawMaterialS.dtpEndMonth = dtpCalendar.Value;
                    break;

                case "exportRMRETURN":
                    prntExportReturnMovement.dtpEndMonth = dtpCalendar.Value;
                    break;

                case "exportRMMAQUILE":
                    prntExportMaquileMovement.dtpEndMonth = dtpCalendar.Value;
                    break;

                default:
                    break;
            }

            this.Close();
        }
    }
}
