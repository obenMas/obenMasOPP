using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms; 
using BPS.Bussiness;

namespace BPS
{
    public partial class frmRawMaterialReceptionDetail : Form
    {

        List<clsReceptionRawMaterialDetail> lstReceptionRawMaterialDetail = new List<clsReceptionRawMaterialDetail>();
        clsReceptionRawMaterialDetail objReceptionRawMaterial = new clsReceptionRawMaterialDetail();
        clsReceptionRawMaterialDetail objReceptionRawMaterialDetail = new clsReceptionRawMaterialDetail();

        public frmRawMaterialReceptionDetail()
        {

            InitializeComponent();
        }

        public void clearFields()
        {
            txtNumberPackages.BackColor = Color.White;
            txtWeigthPerPackage.BackColor = Color.White;
            txtUnitsPerPackage.BackColor = Color.White;
            txtWeigthPerUnit.BackColor = Color.White;
            lblNumberPackages.ForeColor = Color.Black;
            lblWeigthPerPackage.ForeColor = Color.Black;
            lblUnitsPerPackage.ForeColor = Color.Black;
            lblWeigthPerUnit.ForeColor = Color.Black;
            txtNumberPackages.Clear();
            txtWeigthPerPackage.Clear();
            txtUnitsPerPackage.Clear();
            txtWeigthPerUnit.Clear();
            grpbData.Enabled = true;
        }
        public bool validateForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtNumberPackages, ref lblNumberPackages, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtWeigthPerPackage, ref lblWeigthPerPackage, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtUnitsPerPackage, ref lblUnitsPerPackage, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtWeigthPerUnit, ref lblWeigthPerUnit, "notEmpty")) isValid = false;

            return isValid;
        }

        public string getCodeBatch(string batchCode, int sequencial)
        {
            int secuencial;
            string batch = "";
            string secuencialLength = "";
            secuencialLength = sequencial.ToString();
            secuencial = Convert.ToInt32(secuencialLength.Length);

            switch (secuencial)
            {
                case 1:
                    batch = batchCode + "-" + "000" + sequencial;
                    break;

                case 2:
                    batch = batchCode + "-" + "00" + sequencial;
                    break;

                case 3:
                    batch = batchCode + "-" + "0" + sequencial;
                    break;

                default:
                    break;
            }
            return batch;
        }

        private void frmRawMaterialReceptionDetail_Load(object sender, EventArgs e)
        {
            int codsec = 0;
            codsec = objReceptionRawMaterialDetail.getLastReceptionSaved();
            lstReceptionRawMaterialDetail = clsReceptionRawMaterialDetail.getReceptionDetail(codsec);

            for (int i = 0; i < lstReceptionRawMaterialDetail.Count; i++)
            {
                txtPurchaseOrder.Text = lstReceptionRawMaterialDetail[i].PurchaseOrder.ToString();
                txtBatch.Text = lstReceptionRawMaterialDetail[i].ReceptionBatch.ToString();
                txtRawMaterial.Text = lstReceptionRawMaterialDetail[i].RawMaterialName.ToString();
                txtRawMaterialType.Text = lstReceptionRawMaterialDetail[i].RawMaterialTypeName.ToString();
                txtQuantity.Text = lstReceptionRawMaterialDetail[i].DeliveredAmount.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int seqCode = 1;

            if (validateForm())
            {
                double a = (Convert.ToDouble(txtNumberPackages.Text) * Convert.ToDouble(txtUnitsPerPackage.Text) * Convert.ToDouble(txtWeigthPerUnit.Text));
                double b = Convert.ToDouble(txtQuantity.Text);

                for (int i = 0; i < lstReceptionRawMaterialDetail.Count; i++)
                {

                    if (b != a)
                    {
                        MessageBox.Show("Compruebe los datos ingresados", "Detalle de Recepciones", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        clearFields();
                    }
                    else
                    {
                        do
                        {
                            objReceptionRawMaterialDetail.fkReception = lstReceptionRawMaterialDetail[i].fkReception;
                            objReceptionRawMaterialDetail.fkRawMaterial = lstReceptionRawMaterialDetail[i].fkRawMaterial;
                            objReceptionRawMaterialDetail.weigthPerPackage = Convert.ToDouble(txtWeigthPerPackage.Text);
                            objReceptionRawMaterialDetail.unitsPerPackage = Convert.ToInt32(txtUnitsPerPackage.Text);
                            objReceptionRawMaterialDetail.unitWeight = Convert.ToDouble(txtWeigthPerUnit.Text);
                            objReceptionRawMaterialDetail.avaliableUnitsPerpackage = Convert.ToInt32(txtUnitsPerPackage.Text);
                            objReceptionRawMaterialDetail.codePackage = getCodeBatch(lstReceptionRawMaterialDetail[i].ReceptionBatch, seqCode);
                            objReceptionRawMaterialDetail.save();
                            seqCode++;
                        } while (seqCode < Convert.ToInt32(txtNumberPackages.Text) + 1);

                        MessageBox.Show("El detalle de la recepción se ha guardado con éxito", "Detalle de Recepciones", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        this.Close();
                    }

                }
            }
            else
            {
                MessageBox.Show("Debe Completar el detalle de la recepción", "Detalle de Recepciones", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                clearFields();
            }
        }


        private void txtWeigthPerUnit_TabIndexChanged(object sender, EventArgs e)
        {
            double total;
            total = (Convert.ToInt32(txtNumberPackages.Text) * Convert.ToDouble(txtUnitsPerPackage.Text) * Convert.ToDouble(txtWeigthPerUnit.Text));
            txtTotal.Text = total.ToString();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void txtNumberPackages_TextChanged(object sender, EventArgs e)
        {
            if (clsGlobal.isNumeric(txtNumberPackages.Text))
            {
                if (txtNumberPackages.Text != "" && txtNumberPackages.Text != "0")
                    txtWeigthPerPackage.Text = (Convert.ToDouble(txtQuantity.Text) / Convert.ToDouble(txtNumberPackages.Text)).ToString();
                else
                    txtWeigthPerPackage.Text = "0";
            }
            else
            {
                MessageBox.Show("El valor debe ser numérico", "Detalle de Recepciones", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void txtUnitsPerPackage_TextChanged(object sender, EventArgs e)
        {
            if (clsGlobal.isNumeric(txtUnitsPerPackage.Text))
            {
                if (txtUnitsPerPackage.Text != "" && txtUnitsPerPackage.Text != "0")
                    txtWeigthPerUnit.Text = (Convert.ToDouble(txtWeigthPerPackage.Text) / Convert.ToDouble(txtUnitsPerPackage.Text)).ToString();
                else
                    txtWeigthPerUnit.Text = "0";
            }
            else
            {
                MessageBox.Show("El valor debe ser numérico", "Detalle de Recepciones", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }
    }
}