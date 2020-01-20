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
    public partial class frmRawMaterial : Form
    {
        private int isInitialValue = 0;
        private bool isSave = false;
        private clsRawMaterialbyCoilCellar objRawMaterial = new clsRawMaterialbyCoilCellar();

        public frmRawMaterial()
        {
            InitializeComponent();
            cmbRawMaterial.Focus();
            Populate();
            isInitialValue = clsSequential.SequentialList("rawMaterial");
        }

        private void Populate()
        {
            List<clsRawMaterial> lstRawMaterial = new List<clsRawMaterial>();
            lstRawMaterial = clsRawMaterial.getList();
            cmbRawMaterial.Items.Clear();
            for (int i = 0; i < lstRawMaterial.Count; i++)
                cmbRawMaterial.Items.Add(lstRawMaterial[i]);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                double totalnetweigth = 0, totalgrossweigth = 0;

                if (!isSave)
                {
                    Random rdn = new Random();
                    dgvRawMaterial.Rows.Clear();
                    for (int i = 0; i < nupdnumber.Value; i++)
                    {
                        dgvRawMaterial.Rows.Add();
                        dgvRawMaterial.Rows[i].Cells[clmrawmaterialnumber.Index].Value = (dgvRawMaterial.Rows.Count == 0) ? 1 : i + 1;
                        dgvRawMaterial.Rows[i].Cells[clmrawmaterialprovider.Index].Value = ((clsRawMaterial)cmbRawMaterial.SelectedItem).EntityName.ToUpper();
                        dgvRawMaterial.Rows[i].Cells[clmrawmaterialmaterialtype.Index].Value = ((clsRawMaterial)cmbRawMaterial.SelectedItem).RawMaterialtypeName.ToUpper();
                        dgvRawMaterial.Rows[i].Cells[clmrawmaterialname.Index].Value = ((clsRawMaterial)cmbRawMaterial.SelectedItem).name.ToUpper();
                        dgvRawMaterial.Rows[i].Cells[clmrawmaterialmycode.Index].Value = ((clsRawMaterial)cmbRawMaterial.SelectedItem).code.ToUpper();
                        dgvRawMaterial.Rows[i].Cells[clmrawmaterialgrossweigth.Index].Value = Math.Round(((((Convert.ToDouble(txtpalletbag.Text)) * (Convert.ToDouble(txtnetweigthbag.Text)))) - (Convert.ToDouble((rdn.Next(0, 19) + rdn.NextDouble()).ToString()))), 2, MidpointRounding.AwayFromZero);
                        dgvRawMaterial.Rows[i].Cells[clmrawmaterialnetweigth.Index].Value = Math.Round(((Convert.ToDouble(txtpalletbag.Text)) * (Convert.ToDouble(txtnetweigthbag.Text))), 2, MidpointRounding.AwayFromZero);
                        dgvRawMaterial.Rows[i].Cells[clmrawmaterialmycode.Index].Value = ((clsRawMaterial)cmbRawMaterial.SelectedItem).code.ToUpper();
                        dgvRawMaterial.Rows[i].Cells[clmrawmaterialbag.Index].Value = txtpalletbag.Text;
                        dgvRawMaterial.Rows[i].Cells[clmrawmateriallotnumber.Index].Value = txtLotnumber.Text.ToUpper();
                        dgvRawMaterial.Rows[i].Cells[clmrawmaterialcodsec.Index].Value = isInitialValue;
                        dgvRawMaterial.Rows[i].Cells[clmrawmaterialcode.Index].Value = GenerateCode();
                        dgvRawMaterial.Rows[i].Cells[clmrawmaterialdelete.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                        totalnetweigth += Math.Round(((Convert.ToDouble(txtpalletbag.Text)) * (Convert.ToDouble(txtnetweigthbag.Text))), 2, MidpointRounding.AwayFromZero);
                        totalgrossweigth += Math.Round(Convert.ToDouble(dgvRawMaterial.Rows[i].Cells[clmrawmaterialgrossweigth.Index].Value), 2, MidpointRounding.AwayFromZero);
                    }
                    isSave = true;
                    lblTotalNetWeigth.Text = Math.Round(totalnetweigth, 2, MidpointRounding.AwayFromZero).ToString();
                    lblgrossweigth.Text = Math.Round(totalgrossweigth, 2, MidpointRounding.AwayFromZero).ToString();
                }
                else
                {
                    isInitialValue = clsSequential.SequentialList("rawMaterial");
                    totalnetweigth = 0;
                    Random rdn = new Random();
                    dgvRawMaterial.Rows.Clear();
                    for (int i = 0; i < nupdnumber.Value; i++)
                    {
                        dgvRawMaterial.Rows.Add();
                        dgvRawMaterial.Rows[i].Cells[clmrawmaterialnumber.Index].Value = (dgvRawMaterial.Rows.Count == 0) ? 1 : i + 1;
                        dgvRawMaterial.Rows[i].Cells[clmrawmaterialprovider.Index].Value = ((clsRawMaterial)cmbRawMaterial.SelectedItem).EntityName.ToUpper();
                        dgvRawMaterial.Rows[i].Cells[clmrawmaterialmaterialtype.Index].Value = ((clsRawMaterial)cmbRawMaterial.SelectedItem).RawMaterialtypeName.ToUpper();
                        dgvRawMaterial.Rows[i].Cells[clmrawmaterialname.Index].Value = ((clsRawMaterial)cmbRawMaterial.SelectedItem).name.ToUpper();
                        dgvRawMaterial.Rows[i].Cells[clmrawmaterialmycode.Index].Value = ((clsRawMaterial)cmbRawMaterial.SelectedItem).code.ToUpper();
                        dgvRawMaterial.Rows[i].Cells[clmrawmaterialgrossweigth.Index].Value = Math.Round(((((Convert.ToDouble(txtpalletbag.Text)) * (Convert.ToDouble(txtnetweigthbag.Text)))) - (Convert.ToDouble((rdn.Next(0, 19) + rdn.NextDouble()).ToString()))), 2, MidpointRounding.AwayFromZero);
                        dgvRawMaterial.Rows[i].Cells[clmrawmaterialnetweigth.Index].Value = Math.Round(((Convert.ToDouble(txtpalletbag.Text)) * (Convert.ToDouble(txtnetweigthbag.Text))), 2, MidpointRounding.AwayFromZero);
                        dgvRawMaterial.Rows[i].Cells[clmrawmaterialmycode.Index].Value = ((clsRawMaterial)cmbRawMaterial.SelectedItem).code.ToUpper();
                        dgvRawMaterial.Rows[i].Cells[clmrawmaterialbag.Index].Value = txtpalletbag.Text;
                        dgvRawMaterial.Rows[i].Cells[clmrawmaterialcodsec.Index].Value = isInitialValue;
                        dgvRawMaterial.Rows[i].Cells[clmrawmateriallotnumber.Index].Value = txtLotnumber.Text.ToUpper();
                        dgvRawMaterial.Rows[i].Cells[clmrawmaterialcode.Index].Value = GenerateCode();
                        dgvRawMaterial.Rows[i].Cells[clmrawmaterialdelete.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                        totalnetweigth += Math.Round(((Convert.ToDouble(txtpalletbag.Text)) * (Convert.ToDouble(txtnetweigthbag.Text))), 2, MidpointRounding.AwayFromZero);
                        totalgrossweigth += Math.Round(Convert.ToDouble(dgvRawMaterial.Rows[i].Cells[clmrawmaterialgrossweigth.Index].Value), 2, MidpointRounding.AwayFromZero);
                    }
                    lblTotalNetWeigth.Text = Math.Round(totalnetweigth, 2, MidpointRounding.AwayFromZero).ToString();
                    lblgrossweigth.Text = Math.Round(totalgrossweigth, 2, MidpointRounding.AwayFromZero).ToString();
                }
            }
            else
            {
                MessageBox.Show("Existen datos que no están llenos completamente o no cumplen con las condiciones establecidas", "Materias Primas", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                cmbRawMaterial.Focus();
            }
        }

        private string GenerateCode()
        {
            string code = "MP" + DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + clsGlobal.FillWithZeros(((isInitialValue++).ToString()), 8);
            //clsSequential.addSequential("rawMaterial");
            return code;
        }

        private bool ValidateForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref cmbRawMaterial, ref label1, "selected")) isValid = false;
            if (!clsValidation.validateField(ref txtpalletbag, ref label2, "morethan0")) isValid = false;
            if (!clsValidation.validateField(ref txtLotnumber, ref label6, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtnetweigthbag, ref label3, "morethan0")) isValid = false;
            if (nupdnumber.Value == 0)
            {
                isValid = false;
                label4.ForeColor = Color.Red;
                nupdnumber.BackColor = Color.Red;
            }

            return isValid;
        }

        private void dgvRawMaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmrawmaterialdelete.Index)
            {
                if (MessageBox.Show("Esta realmente seguro que desea eliminar el pallet seleccionado?", "Materias Primas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                    dgvRawMaterial.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool flgValidate = true;
            try
            {
                if (dgvRawMaterial.Rows.Count > 0)
                {
                    for (int i = 0; i < dgvRawMaterial.Rows.Count; i++)
                    {
                        objRawMaterial = new clsRawMaterialbyCoilCellar();
                        objRawMaterial.fkStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Materia Prima", "Ingreso").codsec;
                        objRawMaterial.fkrawmaterial = ((clsRawMaterial)cmbRawMaterial.SelectedItem).codsec;
                        objRawMaterial.product = dgvRawMaterial.Rows[i].Cells[clmrawmaterialname.Index].Value.ToString().ToUpper();
                        objRawMaterial.lotnumber = dgvRawMaterial.Rows[i].Cells[clmrawmateriallotnumber.Index].Value.ToString().ToUpper();
                        objRawMaterial.siigoCellar = "001";
                        objRawMaterial.siigoMovement = "E004";
                        objRawMaterial.bag = Convert.ToInt32(dgvRawMaterial.Rows[i].Cells[clmrawmaterialbag.Index].Value);
                        objRawMaterial.ingress = true;
                        objRawMaterial.output = false;
                        objRawMaterial.devolution = false;
                        objRawMaterial.code = dgvRawMaterial.Rows[i].Cells[clmrawmaterialcode.Index].Value.ToString().ToUpper();
                        objRawMaterial.netweigth = Convert.ToDouble(dgvRawMaterial.Rows[i].Cells[clmrawmaterialnetweigth.Index].Value);
                        objRawMaterial.grossweigth = Convert.ToDouble(dgvRawMaterial.Rows[i].Cells[clmrawmaterialgrossweigth.Index].Value);
                        objRawMaterial.order = Convert.ToInt32(dgvRawMaterial.Rows[i].Cells[clmrawmaterialcodsec.Index].Value);
                        objRawMaterial.provider = dgvRawMaterial.Rows[i].Cells[clmrawmaterialprovider.Index].Value.ToString().ToUpper();
                        objRawMaterial.movement = "Ingreso a Bodega de Materia Prima";
                        objRawMaterial.notes = txtNotes.Text.ToUpper();
                        objRawMaterial.isImport = true;
                        if (!objRawMaterial.save())
                        {
                            flgValidate = false;
                            break;
                        }
                    }
                    if (flgValidate)
                    {
                        if (clsSequential.updateSequentialRawMaterialPallet((Convert.ToInt32(dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawmaterialcodsec.Index].Value) + 1)))
                        {
                            MessageBox.Show("Materia Prima Ingresada Correctamente!!\n\rSe procederá a imprimir las etiquetas con los códigos de barras\n\rPor favor recuerde etiquetar correctamente los pallets de Materia Prima", "Materias Primas", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            for (int i = 0; i < dgvRawMaterial.Rows.Count; i++)
                            {
                                Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printRawMaterialLabel(dgvRawMaterial.Rows[i].Cells[clmrawmaterialcode.Index].Value.ToString(), true, false, false); });
                                thrdPrint.Start();
                                thrdPrint.Join();
                                Thread.Sleep(3000);
                            }
                        }
                        isSave = false;
                        ClearForm();
                    }
                }
                else
                {
                    MessageBox.Show("No existen datos a guardar por favor verifique que el ingreso de los materiales sea efectivo!!..", "Materias Primas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    cmbRawMaterial.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Materias Primas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void ClearForm()
        {
            dgvRawMaterial.Rows.Clear();
            cmbRawMaterial.SelectedItem = "";
            cmbRawMaterial.SelectedIndex = -1;
            cmbRawMaterial.Text = "";
            txtLotnumber.Text = "";
            txtnetweigthbag.Text = "0";
            txtpalletbag.Text = "0";
            nupdnumber.Value = 0;
            cmbRawMaterial.Focus();
            txtNotes.Text = "";
        }

        private void dgvRawMaterial_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            switch (dgvRawMaterial.CurrentCell.ColumnIndex)
            {
                case 6:
                    if (clsGlobal.isNumeric(dgvRawMaterial.CurrentCell.EditedFormattedValue.ToString()) == false && dgvRawMaterial.CurrentCell.EditedFormattedValue.ToString() != "")
                    {
                        MessageBox.Show("El valor debe ser Numérico");
                        dgvRawMaterial.CancelEdit();
                    }
                    else
                        calculateTotals();
                    break;
                default:
                    break;
            }
        }

        private void calculateTotals()
        {
            double totalnetweigth = 0, totalgrossweigth = 0;
            for (int i = 0; i < dgvRawMaterial.Rows.Count; i++)
            {
                totalnetweigth += Math.Round(((Convert.ToDouble(txtpalletbag.Text)) * (Convert.ToDouble(txtnetweigthbag.Text))), 2, MidpointRounding.AwayFromZero);
                totalgrossweigth += Math.Round(Convert.ToDouble(dgvRawMaterial.Rows[i].Cells[clmrawmaterialgrossweigth.Index].Value), 2, MidpointRounding.AwayFromZero);
            }
            lblTotalNetWeigth.Text = Math.Round(totalnetweigth, 2, MidpointRounding.AwayFromZero).ToString();
            lblgrossweigth.Text = Math.Round(totalgrossweigth, 2, MidpointRounding.AwayFromZero).ToString();
        }

        private void dgvRawMaterial_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[clmrawmaterialgrossweigth.Index].Value = "0";
            e.Row.Cells[clmrawmaterialnetweigth.Index].Value = "0";
        }
    }
}
