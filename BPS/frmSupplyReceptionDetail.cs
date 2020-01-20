using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmSupplyReceptionDetail : Form
    {

        List<clsSupplyReception> lstSupplyReception = new List<clsSupplyReception>();
        clsSupplyReceptionDetail objSupplyReceptionDetail = new clsSupplyReceptionDetail();

        public frmSupplyReceptionDetail()
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


        private void frmSupplyReceptionDetail_Load(object sender, EventArgs e)
        {
            int codsec = 0;

            codsec = objSupplyReceptionDetail.getLastReceptionSaved();

            lstSupplyReception = clsSupplyReception.getReceptionDetail(codsec);

            for (int i = 0; i < lstSupplyReception.Count; i++)
            {
                txtBatch.Text = lstSupplyReception[i].batch.ToString();
                txtQuantity.Text = lstSupplyReception[i].quantity.ToString();
                txtSupplyName.Text = lstSupplyReception[i].supplyName.ToString();
                txtUnit.Text = lstSupplyReception[i].unitName.ToString();
                if (txtUnit.Text == "Unidad")
                {
                    txtWeigthPerPackage.Enabled = false;
                    txtWeigthPerUnit.Enabled = false;
                }
                else
                {
                    txtWeigthPerPackage.Enabled = true;
                    txtWeigthPerUnit.Enabled = true;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int i = 0;
            int seqCode = 1;

            //  if (validateForm())
            //   {
            int c = (Convert.ToInt32(txtNumberPackages.Text) * Convert.ToInt32(txtUnitsPerPackage.Text));
            int d = Convert.ToInt32(txtQuantity.Text);

            for (i = 0; i < lstSupplyReception.Count; i++)
            {
                if (txtWeigthPerPackage.Enabled == false & txtWeigthPerUnit.Enabled == false)
                {
                    if (c == d)
                    {
                        do
                        {
                            objSupplyReceptionDetail.fkReception = lstSupplyReception[i].codsec;
                            objSupplyReceptionDetail.weigthPerPackage = 0;
                            objSupplyReceptionDetail.unitsPerPackage = Convert.ToInt32(txtUnitsPerPackage.Text);
                            objSupplyReceptionDetail.unitWeigth = 0;
                            objSupplyReceptionDetail.availableUnitsPerpackage = Convert.ToInt32(txtUnitsPerPackage.Text);
                            objSupplyReceptionDetail.codePackage = getCodeBatch(lstSupplyReception[i].batch, seqCode);
                            objSupplyReceptionDetail.save();
                            seqCode++;
                        } while (seqCode < Convert.ToInt32(txtNumberPackages.Text) + 1);

                        MessageBox.Show("El detalle de la recepción se ha guardado con éxito", "Detalle de Recepciones", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Compruebe los datos ingresados", "Detalle de Recepciones", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        clearFields();
                    }
                }

                else
                {

                    double a = (Convert.ToDouble(txtNumberPackages.Text) * Convert.ToDouble(txtUnitsPerPackage.Text) * Convert.ToDouble(txtWeigthPerUnit.Text));
                    double b = Convert.ToDouble(txtQuantity.Text);

                    if (b != a)
                    {
                        MessageBox.Show("Compruebe los datos ingresados", "Detalle de Recepciones", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        clearFields();
                    }
                    else
                    {
                        do
                        {
                            objSupplyReceptionDetail.fkReception = lstSupplyReception[i].codsec;
                            objSupplyReceptionDetail.weigthPerPackage = Convert.ToDouble(txtWeigthPerPackage.Text);
                            objSupplyReceptionDetail.unitsPerPackage = Convert.ToInt32(txtUnitsPerPackage.Text);
                            objSupplyReceptionDetail.unitWeigth = Convert.ToDouble(txtWeigthPerUnit.Text); ;
                            objSupplyReceptionDetail.availableUnitsPerpackage = Convert.ToInt32(txtUnitsPerPackage.Text);
                            objSupplyReceptionDetail.codePackage = getCodeBatch(lstSupplyReception[i].batch, seqCode);
                            objSupplyReceptionDetail.save();
                            seqCode++;
                        } while (seqCode < Convert.ToInt32(txtNumberPackages.Text) + 1);
                        MessageBox.Show("El detalle de la recepción se ha guardado con éxito", "Detalle de Recepciones", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        this.Close();
                    }
                }
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        //      else
        //      {
        //           MessageBox.Show("Debe Completar el detalle de la recepción", "Detalle de Recepciones", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

        //           clearFields();
        //       }



        //}
    }
}