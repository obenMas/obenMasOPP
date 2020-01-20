using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;
using System.Threading;

namespace BPS.Lite
{
    public partial class frmRawMaterialEdit : Form
    {
        private clsRawMaterialbyCoilCellar objRawMaterial = new clsRawMaterialbyCoilCellar();

        public frmRawMaterialEdit()
        {
            InitializeComponent();
        }

        private void txtcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtcode.Text.Length > 0)
                {
                    objRawMaterial = new clsRawMaterialbyCoilCellar(txtcode.Text.ToUpper(), true, false, false);
                    if (objRawMaterial.codsec > 0)
                    {
                        btnprint.Enabled = true;
                        pnlMain.Visible = true;
                        PopulateProduct();
                        FillProduct(objRawMaterial.fkrawmaterial);
                        txtlotnumber.Text = objRawMaterial.lotnumber.ToUpper();
                        txtnetweigth.Text = Math.Round(objRawMaterial.netweigth, 2, MidpointRounding.AwayFromZero).ToString();
                        lblgrossweigth.Text = Math.Round(objRawMaterial.grossweigth, 2, MidpointRounding.AwayFromZero).ToString();
                        nudbag.Value = objRawMaterial.bag;
                        txtNotes.Text = objRawMaterial.notes.ToUpper();
                    }
                    else
                    {
                        MessageBox.Show("El código ingresado no pertenece a ningún pallet registrado\n\rPor favor verifique que el código sea el correcto y vuelva a intentarlo", "Materia Prima", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        txtcode.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar al menos un código para buscar la materia prima", "Materia Prima", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    txtcode.Focus();
                } 
            }
        }

        private void FillProduct(int codsec)
        {
            for (int i = 0; i < cmbproduct.Items.Count; i++)
            {
                if (((clsRawMaterial)cmbproduct.Items[i]).codsec == codsec)
                {
                    cmbproduct.SelectedIndex = i;
                    break;
                }

            }
        }

        private void PopulateProduct()
        {
            List<clsRawMaterial> lstRawMaterial = new List<clsRawMaterial>();
            lstRawMaterial = clsRawMaterial.getList();
            cmbproduct.Items.Clear();
            for (int i = 0; i < lstRawMaterial.Count; i++)
                cmbproduct.Items.Add(lstRawMaterial[i]);
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (objRawMaterial.codsec > 0)
                {
                    if (ValidateForm())
                    {
                        objRawMaterial.fkrawmaterial = ((clsRawMaterial)cmbproduct.SelectedItem).codsec;
                        objRawMaterial.product = ((clsRawMaterial)cmbproduct.SelectedItem).name.ToUpper();
                        objRawMaterial.lotnumber = txtlotnumber.Text;
                        objRawMaterial.bag = Convert.ToInt32(nudbag.Value);
                        objRawMaterial.netweigth = Math.Round(Convert.ToDouble(txtnetweigth.Text), 2, MidpointRounding.AwayFromZero);
                        objRawMaterial.grossweigth = Math.Round(Convert.ToDouble(lblgrossweigth.Text), 2, MidpointRounding.AwayFromZero);
                        objRawMaterial.provider = ((clsRawMaterial)cmbproduct.SelectedItem).EntityName.ToUpper();
                        if (objRawMaterial.toUpdateData())
                        {
                            MessageBox.Show("Datos Guardados Correctamente!", "Materia Prima", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);

                            if (MessageBox.Show("Desea Imprimir la Etiqueta?", "Materia Prima", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                            {
                                Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printRawMaterialLabel(txtcode.Text.ToUpper(), true, false, false); });
                                thrdPrint.Start();
                                thrdPrint.Join();
                                objRawMaterial = new clsRawMaterialbyCoilCellar();
                            }
                            else
                                objRawMaterial = new clsRawMaterialbyCoilCellar();

                            ClearForm();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Existen datos que no fueron validados correctamente por favor verifique que los campos se encuentre llenos", "Materia Prima", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        txtcode.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("la información no ha podido ser guardada ya que no existe datos para poder trabajar", "Materia Prima", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    txtcode.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Materia Prima", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void ClearForm()
        {
            txtcode.Text = "";
            cmbproduct.Items.Clear();
            cmbproduct.Text = "";
            cmbproduct.SelectedIndex = -1;
            txtlotnumber.Text = "";
            txtnetweigth.Text = "0";
            lblgrossweigth.Text = "0";
            nudbag.Value = 0;
            pnlMain.Visible = false;
            txtcode.Focus();
        }

        private bool ValidateForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref cmbproduct, ref label2, "selected")) isValid = false;
            if (!clsValidation.validateField(ref txtcode, ref label1, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtlotnumber, ref label3, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtnetweigth, ref label4, "morethan0")) isValid = false;
            if (nudbag.Value == 0)
            {
                isValid = false;
                label4.ForeColor = Color.Red;
                nudbag.BackColor = Color.Red;
            }

            return isValid;
        }

        private void txtnetweigth_TextChanged(object sender, EventArgs e)
        {
            Random rdn = new Random();
            lblgrossweigth.Text = Math.Round(((((Convert.ToDouble(txtnetweigth.Text)))) - (Convert.ToDouble((rdn.Next(0, 19) + rdn.NextDouble()).ToString()))), 2, MidpointRounding.AwayFromZero).ToString();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printRawMaterialLabel(txtcode.Text.ToUpper(), true, false, false); });
            thrdPrint.Start();
            thrdPrint.Join();
            ClearForm();
            objRawMaterial = new clsRawMaterialbyCoilCellar();
        }
    }
}
