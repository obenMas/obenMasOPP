using System;
using System.Windows.Forms;
using BPS.Bussiness;
using System.Threading;
using BPS.Raw.Product;
using System.Collections.Generic;

namespace BPS.Raw.Return
{
    public partial class frmReRaw : Form
    {
        #region Init

        private int isInitialValue = 0;
        private string type = string.Empty;
        private clsRawMaterialbyCoilCellar objRawMaterial = new clsRawMaterialbyCoilCellar();
        private clsRawMaterialExtruder objRME = new clsRawMaterialExtruder();

        public frmReRaw(string source, string type)
        {
            InitializeComponent();
            this.Text = source;
            this.type = type;
            cmbRawMaterial.Focus();
            fillRaw();
            isInitialValue = clsSequential.SequentialList("rawMaterialD");

            tbcRawMaterial.TabPages.RemoveAt(1);
        }

        #endregion

        #region Helper

        private void fillRaw()
        {
            //var rawList = clsRawMaterial.getListShort();
            //cmbRawMaterial.Items.Clear();
            //for (int i = 0; i < rawList.Count; i++)
            //    cmbRawMaterial.Items.Add(rawList[i]); 

            var rawList = clsRawMaterial.getListShort();
            cmbRawMaterialR.Items.Clear();
            for (int i = 0; i < rawList.Count; i++)
                cmbRawMaterialR.Items.Add(rawList[i]);
        }

        private void cmbRawMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRawMaterial.SelectedIndex > -1)
            {
                lbltmp.Text = ((clsRawMaterial)cmbRawMaterial.SelectedItem).RawMaterialtypeName;
                lblPro.Text = ((clsRawMaterial)cmbRawMaterial.SelectedItem).EntityName;
            }
        }

        private void cmbRawMaterialR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRawMaterialR.SelectedIndex > -1)
            {
                lbltmpR.Text = ((clsRawMaterial)cmbRawMaterialR.SelectedItem).RawMaterialtypeName;
                lblProR.Text = ((clsRawMaterial)cmbRawMaterialR.SelectedItem).EntityName;
            }
        }

        private bool ValidateForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref cmbRawMaterial, ref label1, "selected")) isValid = false;
            if (!clsValidation.validateField(ref txtpalletbag, ref label2, "morethan0")) isValid = false;
            if (!clsValidation.validateField(ref txtLotnumber, ref label6, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtnetweigthbag, ref label3, "morethan0")) isValid = false;

            return isValid;
        }

        private bool ValidateFormR()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref cmbRawMaterialR, ref label4, "selected")) isValid = false;
            if (!clsValidation.validateField(ref txtWeigth, ref label16, "morethan0")) isValid = false;
            if (!clsValidation.validateField(ref txtLotR, ref label17, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtBagR, ref label18, "morethan0")) isValid = false;

            return isValid;
        }

        private bool ValidateFormC()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtCW, ref label16, "morethan0")) isValid = false;
            if (!clsValidation.validateField(ref txtCB, ref label17, "morethan0")) isValid = false;

            return isValid;
        }

        private string GenerateCode()
        {
            string code = "DMP" + DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + clsGlobal.FillWithZeros(((isInitialValue++).ToString()), 9);
            return code;
        }

        private string GenerateCode(int number)
        {
            string code = "DMP" + DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + clsGlobal.FillWithZeros(((number).ToString()), 9);
            clsSequential.addSequential("rawMaterialD");
            return code;
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
            cmbRawMaterial.Focus();
            txtNotes.Text = "";
        }

        private void ClearFormR()
        {
            dgvRawMaterialR.Rows.Clear();
            cmbRawMaterialR.SelectedItem = "";
            cmbRawMaterialR.SelectedIndex = -1;
            cmbRawMaterialR.Text = "";
            txtLotR.Text = "";
            txtWeigth.Text = "0";
            txtBagR.Text = "0";
            cmbRawMaterialR.Focus();
            txtNotR.Text = "";
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

        private void calculateTotalsR()
        {
            double totalnetweigth = 0;

            for (int i = 0; i < dgvRawMaterialR.Rows.Count; i++)
                totalnetweigth += Math.Round(double.Parse(dgvRawMaterialR.Rows[i].Cells[clmrawmaterialrwe.Index].Value.ToString()), 2, MidpointRounding.AwayFromZero);

            label21.Text = Math.Round(totalnetweigth, 2, MidpointRounding.AwayFromZero).ToString();
        }

        private void calculeCode(int rows)
        {
            if (rows > 0)
            {
                isInitialValue = clsSequential.SequentialList("rawMaterialD");
                for (int i = 0; i < dgvRawMaterial.Rows.Count; i++)
                {
                    dgvRawMaterial.Rows[i].Cells[clmrawmaterialnumber.Index].Value = (i == 0) ? 1 : i + 1;
                    dgvRawMaterial.Rows[i].Cells[clmrawmaterialcodsec.Index].Value = isInitialValue;
                    dgvRawMaterial.Rows[i].Cells[clmrawmaterialcode.Index].Value = GenerateCode();
                }
                calculateTotals();
            }
        }

        private void calculeCodeR(int rows)
        {
            if (rows > 0)
            {
                isInitialValue = clsSequential.SequentialList("rawMaterialD");
                for (int i = 0; i < dgvRawMaterialR.Rows.Count; i++)
                {
                    dgvRawMaterialR.Rows[i].Cells[clmrawmaterialrnumber.Index].Value = (i == 0) ? 1 : i + 1;
                    dgvRawMaterialR.Rows[i].Cells[clmrawmaterialrcodsec.Index].Value = isInitialValue;
                    dgvRawMaterialR.Rows[i].Cells[clmrawmaterialrcode.Index].Value = GenerateCode();
                }

                calculateTotalsR();
            }
        }

        private string siigocellarType(string type)
        {
            string value = string.Empty;

            if (type == "E2" || type == "E35" || type == "E30")
                value = "001";
            else if (type == "E33" || type == "E36")
                value = "004";

            return value;
        }

        private string siigomovType(string type)
        {
            string value = string.Empty;

            if (type == "E33")
                value = "E033";
            else if (type == "E36")
                value = "E036";
            else if (type == "E2")
                value = "E002";
            else if (type == "E35")
                value = "E035";
            else if (type == "E30")
                value = "E030";

            return value;
        }

        #endregion

        #region Actions

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                double totalnetweigth = 0, totalgrossweigth = 0;

                Random rdn = new Random();

                dgvRawMaterial.Rows.Add();
                dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawmaterialnumber.Index].Value = (dgvRawMaterial.Rows.Count == 0) ? 1 : dgvRawMaterial.Rows.Count;
                dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawmaterialprovider.Index].Value = ((clsRawMaterial)cmbRawMaterial.SelectedItem).EntityName.ToUpper();
                dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawmaterialmaterialtype.Index].Value = ((clsRawMaterial)cmbRawMaterial.SelectedItem).RawMaterialtypeName.ToUpper();
                dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawmaterialname.Index].Value = ((clsRawMaterial)cmbRawMaterial.SelectedItem).name.ToUpper();
                dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawmaterialmycode.Index].Value = ((clsRawMaterial)cmbRawMaterial.SelectedItem).code.ToUpper();
                dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmfkraw.Index].Value = ((clsRawMaterial)cmbRawMaterial.SelectedItem).codsec;
                dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawmaterialgrossweigth.Index].Value = Math.Round(((((Convert.ToDouble(txtpalletbag.Text)) * (Convert.ToDouble(txtnetweigthbag.Text)))) + (Convert.ToDouble((rdn.Next(17, 20) + rdn.NextDouble()).ToString()))), 2, MidpointRounding.AwayFromZero);
                dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawmaterialnetweigth.Index].Value = Math.Round(((Convert.ToDouble(txtpalletbag.Text)) * (Convert.ToDouble(txtnetweigthbag.Text))), 2, MidpointRounding.AwayFromZero);
                dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawmaterialmycode.Index].Value = ((clsRawMaterial)cmbRawMaterial.SelectedItem).code.ToUpper();
                dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawmaterialbag.Index].Value = txtpalletbag.Text;
                dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawmateriallotnumber.Index].Value = txtLotnumber.Text.Trim().ToUpper();
                dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawmaterialcodsec.Index].Value = isInitialValue;
                dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawmaterialcode.Index].Value = GenerateCode();
                dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawmaterialdelete.Index].Value = global::BPS.Raw.Properties.Resources.cross;
                totalnetweigth += Math.Round(((Convert.ToDouble(txtpalletbag.Text)) * (Convert.ToDouble(txtnetweigthbag.Text))), 2, MidpointRounding.AwayFromZero);
                totalgrossweigth += Math.Round(Convert.ToDouble(dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawmaterialgrossweigth.Index].Value), 2, MidpointRounding.AwayFromZero);
                calculateTotals();
            }
            else
            {
                MessageBox.Show("Existen datos que no están llenos completamente o no cumplen con las condiciones establecidas", "Materias Primas", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                cmbRawMaterial.Focus();
            }
        }

        private void btnAddR_Click(object sender, EventArgs e)
        {
            if (ValidateFormR())
            {
                dgvRawMaterialR.Rows.Add();
                dgvRawMaterialR.Rows[dgvRawMaterialR.Rows.Count - 1].Cells[clmrawmaterialrnumber.Index].Value = (dgvRawMaterialR.Rows.Count == 0) ? 1 : dgvRawMaterialR.Rows.Count;
                dgvRawMaterialR.Rows[dgvRawMaterialR.Rows.Count - 1].Cells[clmrawmaterialrpro.Index].Value = ((clsRawMaterial)cmbRawMaterialR.SelectedItem).EntityName.ToUpper();
                dgvRawMaterialR.Rows[dgvRawMaterialR.Rows.Count - 1].Cells[clmrawmaterialrtmp.Index].Value = ((clsRawMaterial)cmbRawMaterialR.SelectedItem).RawMaterialtypeName.ToUpper();
                dgvRawMaterialR.Rows[dgvRawMaterialR.Rows.Count - 1].Cells[clmrawmaterialrname.Index].Value = ((clsRawMaterial)cmbRawMaterialR.SelectedItem).name.ToUpper();
                dgvRawMaterialR.Rows[dgvRawMaterialR.Rows.Count - 1].Cells[clmrawmaterialrid.Index].Value = ((clsRawMaterial)cmbRawMaterialR.SelectedItem).code.ToUpper();
                dgvRawMaterialR.Rows[dgvRawMaterialR.Rows.Count - 1].Cells[clmrawmaterialrfkraw.Index].Value = ((clsRawMaterial)cmbRawMaterialR.SelectedItem).codsec;
                dgvRawMaterialR.Rows[dgvRawMaterialR.Rows.Count - 1].Cells[clmrawmaterialrwe.Index].Value = Math.Round(double.Parse(txtWeigth.Text), 2, MidpointRounding.AwayFromZero);
                dgvRawMaterialR.Rows[dgvRawMaterialR.Rows.Count - 1].Cells[clmrawmaterialrbag.Index].Value = txtBagR.Text;
                dgvRawMaterialR.Rows[dgvRawMaterialR.Rows.Count - 1].Cells[clmrawmaterialrlot.Index].Value = txtLotR.Text.Trim().ToUpper();
                dgvRawMaterialR.Rows[dgvRawMaterialR.Rows.Count - 1].Cells[clmrawmaterialrcodsec.Index].Value = isInitialValue;
                dgvRawMaterialR.Rows[dgvRawMaterialR.Rows.Count - 1].Cells[clmrawmaterialrcode.Index].Value = GenerateCode();
                dgvRawMaterialR.Rows[dgvRawMaterialR.Rows.Count - 1].Cells[clmisCode.Index].Value = false;
                dgvRawMaterialR.Rows[dgvRawMaterialR.Rows.Count - 1].Cells[clmfkCodsec.Index].Value = string.Empty;
                dgvRawMaterialR.Rows[dgvRawMaterialR.Rows.Count - 1].Cells[clmrawmaterialrdel.Index].Value = global::BPS.Raw.Properties.Resources.cross;

                calculateTotalsR();
            }
            else
            {
                MessageBox.Show("Existen datos que no están llenos completamente o no cumplen con las condiciones establecidas", "Materias Primas", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                cmbRawMaterialR.Focus();
            }
        }

        private void dgvRawMaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmrawmaterialdelete.Index)
            {
                if (MessageBox.Show("Esta realmente seguro que desea eliminar el pallet seleccionado?", "Materias Primas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                {
                    dgvRawMaterial.Rows.RemoveAt(e.RowIndex);
                    calculeCode(dgvRawMaterial.Rows.Count);
                }
            }
        }

        private void dgvRawMaterialR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmrawmaterialrdel.Index)
            {
                if (MessageBox.Show("Esta realmente seguro que desea eliminar el pallet seleccionado?", "Materias Primas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                {
                    dgvRawMaterialR.Rows.RemoveAt(e.RowIndex);
                    calculeCodeR(dgvRawMaterialR.Rows.Count);
                }
            }
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

        private void dgvRawMaterial_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[clmrawmaterialgrossweigth.Index].Value = "0";
            e.Row.Cells[clmrawmaterialnetweigth.Index].Value = "0";
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
                        objRawMaterial.fkStatus = 1098;
                        objRawMaterial.fkrawmaterial = Convert.ToInt32(dgvRawMaterial.Rows[i].Cells[clmfkraw.Index].Value.ToString());
                        objRawMaterial.product = dgvRawMaterial.Rows[i].Cells[clmrawmaterialname.Index].Value.ToString().ToUpper();
                        objRawMaterial.lotnumber = dgvRawMaterial.Rows[i].Cells[clmrawmateriallotnumber.Index].Value.ToString().ToUpper();
                        objRawMaterial.siigoCellar = siigocellarType(type);
                        objRawMaterial.siigoMovement = siigomovType(type);
                        objRawMaterial.bag = Convert.ToInt32(dgvRawMaterial.Rows[i].Cells[clmrawmaterialbag.Index].Value);
                        objRawMaterial.ingress = false;
                        objRawMaterial.output = false;
                        objRawMaterial.devolution = true;
                        objRawMaterial.code = dgvRawMaterial.Rows[i].Cells[clmrawmaterialcode.Index].Value.ToString().ToUpper();
                        objRawMaterial.netweigth = Convert.ToDouble(dgvRawMaterial.Rows[i].Cells[clmrawmaterialnetweigth.Index].Value);
                        objRawMaterial.grossweigth = Convert.ToDouble(dgvRawMaterial.Rows[i].Cells[clmrawmaterialgrossweigth.Index].Value);
                        objRawMaterial.order = Convert.ToInt32(dgvRawMaterial.Rows[i].Cells[clmrawmaterialcodsec.Index].Value);
                        objRawMaterial.provider = dgvRawMaterial.Rows[i].Cells[clmrawmaterialprovider.Index].Value.ToString().ToUpper();
                        objRawMaterial.movement = "Devolución a Bodega de Materia Prima";
                        objRawMaterial.notes = txtNotes.Text.ToUpper();
                        objRawMaterial.isImport = false;
                        objRawMaterial.isPending = true;
                        if (!objRawMaterial.saveR())
                        {
                            flgValidate = false;
                            break;
                        }
                    }

                    if (flgValidate)
                    {
                        if (clsSequential.updRawR((Convert.ToInt32(dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawmaterialcodsec.Index].Value) + 1)))
                        {
                            MessageBox.Show("Devolución de Materia Prima Ingresada Correctamente!!\n\rSe procederá a imprimir las etiquetas con los códigos de barras\n\rPor favor recuerde etiquetar correctamente los pallets de Materia Prima", "Materias Primas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            for (int i = 0; i < dgvRawMaterial.Rows.Count; i++)
                            {
                                Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printRawLabel(dgvRawMaterial.Rows[i].Cells[clmrawmaterialcode.Index].Value.ToString(), false, false, true, clsGlobal.password); });
                                thrdPrint.Start();
                                thrdPrint.Join();
                            }
                        }

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

        #endregion

        private void btnPro_Click(object sender, EventArgs e)
        {
            frmAddRaw winRaw = new frmAddRaw();
            winRaw.StartPosition = FormStartPosition.CenterScreen;
            winRaw.ShowDialog();
        }

        private void btnProR_Click(object sender, EventArgs e)
        {
            frmAddRaw winRaw = new frmAddRaw();
            winRaw.StartPosition = FormStartPosition.CenterScreen;
            winRaw.ShowDialog();
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                getRM(txtCode.Text.ToUpper().Trim());
        }

        private void getRM(string code)
        {
            objRME = new clsRawMaterialExtruder();
            objRME = clsRawMaterialExtruder.getRawByCodeExtruder(code);

            if (objRME.codsec > 0)
            {
                txtCW.Text = objRME.netWeigth.ToString();
                txtCB.Text = objRME.bag.ToString();
            }
            else
            {
                MessageBox.Show("No existen datos con el código " + code + " por favor verifique dicho código!!..", "Materias Primas", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                txtCode.Clear();
                txtCode.Focus();
            }
        }

        private void btnAddC_Click(object sender, EventArgs e)
        {
            if (objRME.codsec > 0)
            {
                if (ValidateFormC())
                {
                    dgvRawMaterialR.Rows.Add();
                    dgvRawMaterialR.Rows[dgvRawMaterialR.Rows.Count - 1].Cells[clmrawmaterialrnumber.Index].Value = (dgvRawMaterialR.Rows.Count == 0) ? 1 : dgvRawMaterialR.Rows.Count;
                    dgvRawMaterialR.Rows[dgvRawMaterialR.Rows.Count - 1].Cells[clmrawmaterialrpro.Index].Value = objRME.provider;
                    dgvRawMaterialR.Rows[dgvRawMaterialR.Rows.Count - 1].Cells[clmrawmaterialrtmp.Index].Value = objRME.MaterialName;
                    dgvRawMaterialR.Rows[dgvRawMaterialR.Rows.Count - 1].Cells[clmrawmaterialrname.Index].Value = objRME.MaterialCode + " - " + objRME.MaterialName;
                    dgvRawMaterialR.Rows[dgvRawMaterialR.Rows.Count - 1].Cells[clmrawmaterialrid.Index].Value = objRME.MaterialCode;
                    dgvRawMaterialR.Rows[dgvRawMaterialR.Rows.Count - 1].Cells[clmrawmaterialrfkraw.Index].Value = objRME.fkMaterial;
                    dgvRawMaterialR.Rows[dgvRawMaterialR.Rows.Count - 1].Cells[clmrawmaterialrwe.Index].Value = objRME.netWeigth;
                    dgvRawMaterialR.Rows[dgvRawMaterialR.Rows.Count - 1].Cells[clmrawmaterialrbag.Index].Value = txtCB.Text;
                    dgvRawMaterialR.Rows[dgvRawMaterialR.Rows.Count - 1].Cells[clmrawmaterialrlot.Index].Value = objRME.lotNumber;
                    dgvRawMaterialR.Rows[dgvRawMaterialR.Rows.Count - 1].Cells[clmrawmaterialrcodsec.Index].Value = isInitialValue;
                    dgvRawMaterialR.Rows[dgvRawMaterialR.Rows.Count - 1].Cells[clmrawmaterialrcode.Index].Value = GenerateCode();
                    dgvRawMaterialR.Rows[dgvRawMaterialR.Rows.Count - 1].Cells[clmisCode.Index].Value = true;
                    dgvRawMaterialR.Rows[dgvRawMaterialR.Rows.Count - 1].Cells[clmfkCodsec.Index].Value = objRME.codsec;
                    dgvRawMaterialR.Rows[dgvRawMaterialR.Rows.Count - 1].Cells[clmrawmaterialrdel.Index].Value = global::BPS.Raw.Properties.Resources.cross;

                    calculateTotalsR();

                    objRME = new clsRawMaterialExtruder();
                }
                else
                {
                    MessageBox.Show("Existen datos que no están llenos completamente o no cumplen con las condiciones establecidas", "Materias Primas", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    cmbRawMaterialR.Focus();
                }
            }
            else
            {
                MessageBox.Show("No existe información para ser procesada", "Materias Primas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                txtCode.Focus();
            }
        }

        private void btnSaveR_Click(object sender, EventArgs e)
        {
            Random rdn = new Random();
            List<codeList> codList = new List<codeList>();

            bool flgValidate = true;
            try
            {
                if (dgvRawMaterialR.Rows.Count > 0)
                {
                    for (int i = 0; i < dgvRawMaterialR.Rows.Count; i++)
                    {
                        objRawMaterial = new clsRawMaterialbyCoilCellar();
                        objRawMaterial.fkStatus = 1098;
                        objRawMaterial.fkrawmaterial = Convert.ToInt32(dgvRawMaterialR.Rows[i].Cells[clmrawmaterialrfkraw.Index].Value.ToString());
                        objRawMaterial.product = dgvRawMaterialR.Rows[i].Cells[clmrawmaterialrname.Index].Value.ToString().ToUpper();
                        objRawMaterial.lotnumber = dgvRawMaterialR.Rows[i].Cells[clmrawmaterialrlot.Index].Value.ToString().ToUpper();
                        objRawMaterial.siigoCellar = siigocellarType(type);
                        objRawMaterial.siigoMovement = siigomovType(type);
                        objRawMaterial.bag = Convert.ToInt32(dgvRawMaterialR.Rows[i].Cells[clmrawmaterialrbag.Index].Value);
                        objRawMaterial.ingress = false;
                        objRawMaterial.output = false;
                        objRawMaterial.devolution = true;
                        objRawMaterial.netweigth = Convert.ToDouble(dgvRawMaterialR.Rows[i].Cells[clmrawmaterialrwe.Index].Value);
                        objRawMaterial.grossweigth = Math.Round(((Convert.ToDouble(dgvRawMaterialR.Rows[i].Cells[clmrawmaterialrwe.Index].Value)) + (Convert.ToDouble((rdn.Next(17, 20) + rdn.NextDouble()).ToString()))), 2, MidpointRounding.AwayFromZero);
                        objRawMaterial.provider = dgvRawMaterialR.Rows[i].Cells[clmrawmaterialprovider.Index].Value.ToString().ToUpper();
                        objRawMaterial.movement = "Devolución a Bodega de Materia Prima";
                        objRawMaterial.notes = txtNotes.Text.ToUpper();
                        objRawMaterial.isImport = false;
                        objRawMaterial.isPending = true;

                        var ord = clsSequential.SequentialList("rawMaterialD");

                        objRawMaterial.code = GenerateCode(ord);
                        objRawMaterial.order = ord;

                        if (!objRawMaterial.saveR())
                        {
                            flgValidate = false;
                            break;
                        }
                        else
                        {
                            if (Convert.ToBoolean(dgvRawMaterialR.Rows[i].Cells[clmisCode.Index].Value.ToString()))
                                clsRawMaterialExtruder.setTransferD(dgvRawMaterialR.Rows[i].Cells[clmfkCodsec.Index].Value.ToString());
                        }

                        codList.Add(new codeList());
                        codList[codList.Count - 1].pos = i;
                        codList[codList.Count - 1].code = objRawMaterial.code;
                    }

                    if (flgValidate)
                    {
                        MessageBox.Show("Devolución de Materia Prima Ingresada Correctamente!!\n\rSe procederá a imprimir las etiquetas con los códigos de barras\n\rPor favor recuerde etiquetar correctamente los pallets de Materia Prima", "Materias Primas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        for (int i = 0; i < codList.Count; i++)
                        {
                            Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printRawLabel(codList[i].code.ToString(), false, false, true, clsGlobal.password); });
                            thrdPrint.Start();
                            thrdPrint.Join();
                        }

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

        class codeList
        {
            public int pos { get; set; }
            public string code { get; set; }
        }
    }
}
