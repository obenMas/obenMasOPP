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
using BPS.Raw.Product;

namespace BPS.Raw.In
{
    public partial class frmInRaw : Form
    {
        #region Init

        private int isInitialValue = 0;
        private string type = string.Empty;
        private bool isSave = false;
        private clsRawMaterialbyCoilCellar objRawMaterial = new clsRawMaterialbyCoilCellar();
        private clsRawMaterialbySilo objRawSilo = new clsRawMaterialbySilo();

        public frmInRaw(string source, string type)
        {
            InitializeComponent();
            this.Text = source;
            this.type = type;
            cmbRawMaterial.Focus();
            fillRaw();
            isInitialValue = clsSequential.SequentialList("rawMaterial");
            
            if(type=="Granel")
            {
                txtpalletbag.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label8.Visible = false;
                txtnetweigthbag.Visible = false;
                nupdnumber.Visible = false;
                lblgrossweigth.Visible = false;
            }

            if (type == "Pallet")
            {
                label10.Visible = false;
                label12.Visible = false;
                cbsilo.Visible = false;
                txttotalwe.Visible = false;
            }
        }

        #endregion

        #region Helper

        private void fillRaw()
        {
            var rawList = clsRawMaterial.getListShort();
            cmbRawMaterial.Items.Clear();
            for (int i = 0; i < rawList.Count; i++)
                cmbRawMaterial.Items.Add(rawList[i]);
        }

        private bool ValidateForm()
        {
            bool isValid = true;

            if(this.type == "Pallet")
            {
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
            }
            else
            {
                if (this.type == "Granel")
                {
                    if (!clsValidation.validateField(ref cmbRawMaterial, ref label1, "selected")) isValid = false;
                    if (!clsValidation.validateField(ref cbsilo, ref label10, "selected")) isValid = false;
                    if (!clsValidation.validateField(ref txtLotnumber, ref label6, "notEmpty")) isValid = false;
                    if (!clsValidation.validateField(ref txttotalwe, ref label12, "morethan0")) isValid = false;
                    /*if (nupdnumber.Value == 0)
                    {
                        isValid = false;
                        label4.ForeColor = Color.Red;
                        nupdnumber.BackColor = Color.Red;
                    }*/
                }
            }

            return isValid;
        }

        private string GenerateCode()
        {
            string code = "MP" + DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + "C" + clsGlobal.FillWithZeros(((isInitialValue++).ToString()), 5);
            return code;
        }

        /*private string siigomovType(string type)
        {
            string value = string.Empty;

            if (type == "E4")
                value = "E004";
            else if (type == "E5")
                value = "E005";
            else if (type == "E31")
                value = "E031";

            return value;
        }*/

        /*private string siigocellarType(string type)
        {
            string value = string.Empty;

            if (type == "E4" || type == "E5")
                value = "001";
            else if (type == "E31")
                value = "004";

            return value;
        }*/

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

        #endregion

        #region Actions

        private void cmbRawMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRawMaterial.SelectedIndex > -1)
            {
                lbltmp.Text = ((clsRawMaterial)cmbRawMaterial.SelectedItem).RawMaterialtypeName;
                lblPro.Text = ((clsRawMaterial)cmbRawMaterial.SelectedItem).EntityName;
            }
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

                    if(this.type=="Pallet")
                    {
                        for (int i = 0; i < nupdnumber.Value; i++)
                        {
                            dgvRawMaterial.Rows.Add();
                            dgvRawMaterial.Rows[i].Cells[clmrawmaterialnumber.Index].Value = (dgvRawMaterial.Rows.Count == 0) ? 1 : i + 1;
                            dgvRawMaterial.Rows[i].Cells[clmrawmaterialprovider.Index].Value = ((clsRawMaterial)cmbRawMaterial.SelectedItem).EntityName.ToUpper();
                            dgvRawMaterial.Rows[i].Cells[clmrawmaterialmaterialtype.Index].Value = ((clsRawMaterial)cmbRawMaterial.SelectedItem).RawMaterialtypeName.ToUpper();
                            dgvRawMaterial.Rows[i].Cells[clmrawmaterialname.Index].Value = ((clsRawMaterial)cmbRawMaterial.SelectedItem).name.ToUpper();
                            dgvRawMaterial.Rows[i].Cells[clmrawmaterialmycode.Index].Value = ((clsRawMaterial)cmbRawMaterial.SelectedItem).code.ToUpper();
                            dgvRawMaterial.Rows[i].Cells[clmrawmaterialgrossweigth.Index].Value = Math.Round(((((Convert.ToDouble(txtpalletbag.Text)) * (Convert.ToDouble(txtnetweigthbag.Text)))) + (Convert.ToDouble((rdn.Next(17, 20) + rdn.NextDouble()).ToString()))), 2, MidpointRounding.AwayFromZero);
                            dgvRawMaterial.Rows[i].Cells[clmrawmaterialnetweigth.Index].Value = Math.Round(((Convert.ToDouble(txtpalletbag.Text)) * (Convert.ToDouble(txtnetweigthbag.Text))), 2, MidpointRounding.AwayFromZero);
                            dgvRawMaterial.Rows[i].Cells[clmrawmaterialmycode.Index].Value = ((clsRawMaterial)cmbRawMaterial.SelectedItem).code.ToUpper();
                            dgvRawMaterial.Rows[i].Cells[clmrawmaterialbag.Index].Value = txtpalletbag.Text;
                            dgvRawMaterial.Rows[i].Cells[clmrawmateriallotnumber.Index].Value = txtLotnumber.Text.Trim().ToUpper();
                            dgvRawMaterial.Rows[i].Cells[clmrawmaterialcodsec.Index].Value = isInitialValue;
                            dgvRawMaterial.Rows[i].Cells[clmrawmaterialcode.Index].Value = GenerateCode();
                            dgvRawMaterial.Rows[i].Cells[clmrawmaterialdelete.Index].Value = global::BPS.Raw.Properties.Resources.cross;
                            totalnetweigth += Math.Round(((Convert.ToDouble(txtpalletbag.Text)) * (Convert.ToDouble(txtnetweigthbag.Text))), 2, MidpointRounding.AwayFromZero);
                            totalgrossweigth += Math.Round(Convert.ToDouble(dgvRawMaterial.Rows[i].Cells[clmrawmaterialgrossweigth.Index].Value), 2, MidpointRounding.AwayFromZero);
                        }
                        isSave = true;
                        lblTotalNetWeigth.Text = Math.Round(totalnetweigth, 2, MidpointRounding.AwayFromZero).ToString();
                        lblgrossweigth.Text = Math.Round(totalgrossweigth, 2, MidpointRounding.AwayFromZero).ToString();
                    }

                    if (this.type == "Granel")
                    {
                        dgvRawMaterial.Rows.Add();
                        dgvRawMaterial.Rows[0].Cells[clmrawmaterialnumber.Index].Value = (dgvRawMaterial.Rows.Count == 0) ? 1 : 0 + 1;
                        dgvRawMaterial.Rows[0].Cells[clmrawmaterialprovider.Index].Value = ((clsRawMaterial)cmbRawMaterial.SelectedItem).EntityName.ToUpper();
                        dgvRawMaterial.Rows[0].Cells[clmrawmaterialmaterialtype.Index].Value = ((clsRawMaterial)cmbRawMaterial.SelectedItem).RawMaterialtypeName.ToUpper();
                        dgvRawMaterial.Rows[0].Cells[clmrawmaterialname.Index].Value = ((clsRawMaterial)cmbRawMaterial.SelectedItem).name.ToUpper();
                        dgvRawMaterial.Rows[0].Cells[clmrawmaterialmycode.Index].Value = ((clsRawMaterial)cmbRawMaterial.SelectedItem).code.ToUpper();
                        dgvRawMaterial.Rows[0].Cells[clmrawmaterialgrossweigth.Index].Value = Math.Round(((((Convert.ToDouble(txttotalwe.Text)))) + (Convert.ToDouble((rdn.Next(17, 20) + rdn.NextDouble()).ToString()))), 2, MidpointRounding.AwayFromZero);
                        dgvRawMaterial.Rows[0].Cells[clmrawmaterialnetweigth.Index].Value = Math.Round(((Convert.ToDouble(txttotalwe.Text))), 2, MidpointRounding.AwayFromZero);
                        dgvRawMaterial.Rows[0].Cells[clmrawmaterialmycode.Index].Value = ((clsRawMaterial)cmbRawMaterial.SelectedItem).code.ToUpper();
                        dgvRawMaterial.Rows[0].Cells[clmrawmaterialbag.Index].Value = 1;
                        dgvRawMaterial.Rows[0].Cells[clmrawmateriallotnumber.Index].Value = txtLotnumber.Text.Trim().ToUpper();
                        dgvRawMaterial.Rows[0].Cells[clmrawmaterialcodsec.Index].Value = isInitialValue;
                        dgvRawMaterial.Rows[0].Cells[clmrawmaterialcode.Index].Value = GenerateCode();
                        dgvRawMaterial.Rows[0].Cells[clmrawmaterialdelete.Index].Value = global::BPS.Raw.Properties.Resources.cross;
                        totalnetweigth += Math.Round(((Convert.ToDouble(txttotalwe.Text))), 2, MidpointRounding.AwayFromZero);
                        //totalgrossweigth += Math.Round(Convert.ToDouble(dgvRawMaterial.Rows[i].Cells[clmrawmaterialgrossweigth.Index].Value), 2, MidpointRounding.AwayFromZero);
                      
                        isSave = true;
                        lblTotalNetWeigth.Text = Math.Round(totalnetweigth, 2, MidpointRounding.AwayFromZero).ToString();
                        //lblgrossweigth.Text = Math.Round(totalgrossweigth, 2, MidpointRounding.AwayFromZero).ToString();
                    }
                    
                }
                else
                {
                    isInitialValue = clsSequential.SequentialList("rawMaterial");
                    totalnetweigth = 0;
                    Random rdn = new Random();
                    dgvRawMaterial.Rows.Clear();

                    if(this.type=="Pallet")
                    {
                        for (int i = 0; i < nupdnumber.Value; i++)
                        {
                            dgvRawMaterial.Rows.Add();
                            dgvRawMaterial.Rows[i].Cells[clmrawmaterialnumber.Index].Value = (dgvRawMaterial.Rows.Count == 0) ? 1 : i + 1;
                            dgvRawMaterial.Rows[i].Cells[clmrawmaterialprovider.Index].Value = ((clsRawMaterial)cmbRawMaterial.SelectedItem).EntityName.ToUpper();
                            dgvRawMaterial.Rows[i].Cells[clmrawmaterialmaterialtype.Index].Value = ((clsRawMaterial)cmbRawMaterial.SelectedItem).RawMaterialtypeName.ToUpper();
                            dgvRawMaterial.Rows[i].Cells[clmrawmaterialname.Index].Value = ((clsRawMaterial)cmbRawMaterial.SelectedItem).name.ToUpper();
                            dgvRawMaterial.Rows[i].Cells[clmrawmaterialmycode.Index].Value = ((clsRawMaterial)cmbRawMaterial.SelectedItem).code.ToUpper();
                            dgvRawMaterial.Rows[i].Cells[clmrawmaterialgrossweigth.Index].Value = Math.Round(((((Convert.ToDouble(txtpalletbag.Text)) * (Convert.ToDouble(txtnetweigthbag.Text)))) + (Convert.ToDouble((rdn.Next(17, 20) + rdn.NextDouble()).ToString()))), 2, MidpointRounding.AwayFromZero);
                            dgvRawMaterial.Rows[i].Cells[clmrawmaterialnetweigth.Index].Value = Math.Round(((Convert.ToDouble(txtpalletbag.Text)) * (Convert.ToDouble(txtnetweigthbag.Text))), 2, MidpointRounding.AwayFromZero);
                            dgvRawMaterial.Rows[i].Cells[clmrawmaterialmycode.Index].Value = ((clsRawMaterial)cmbRawMaterial.SelectedItem).code.ToUpper();
                            dgvRawMaterial.Rows[i].Cells[clmrawmaterialbag.Index].Value = txtpalletbag.Text;
                            dgvRawMaterial.Rows[i].Cells[clmrawmaterialcodsec.Index].Value = isInitialValue;
                            dgvRawMaterial.Rows[i].Cells[clmrawmateriallotnumber.Index].Value = txtLotnumber.Text.Trim().ToUpper();
                            dgvRawMaterial.Rows[i].Cells[clmrawmaterialcode.Index].Value = GenerateCode();
                            dgvRawMaterial.Rows[i].Cells[clmrawmaterialdelete.Index].Value = global::BPS.Raw.Properties.Resources.cross;
                            totalnetweigth += Math.Round(((Convert.ToDouble(txtpalletbag.Text)) * (Convert.ToDouble(txtnetweigthbag.Text))), 2, MidpointRounding.AwayFromZero);
                            totalgrossweigth += Math.Round(Convert.ToDouble(dgvRawMaterial.Rows[i].Cells[clmrawmaterialgrossweigth.Index].Value), 2, MidpointRounding.AwayFromZero);
                        }
                        lblTotalNetWeigth.Text = Math.Round(totalnetweigth, 2, MidpointRounding.AwayFromZero).ToString();
                        lblgrossweigth.Text = Math.Round(totalgrossweigth, 2, MidpointRounding.AwayFromZero).ToString();
                    }

                    if (this.type == "Granel")
                    {
                        dgvRawMaterial.Rows.Add();
                        dgvRawMaterial.Rows[0].Cells[clmrawmaterialnumber.Index].Value = (dgvRawMaterial.Rows.Count == 0) ? 1 : 0 + 1;
                        dgvRawMaterial.Rows[0].Cells[clmrawmaterialprovider.Index].Value = ((clsRawMaterial)cmbRawMaterial.SelectedItem).EntityName.ToUpper();
                        dgvRawMaterial.Rows[0].Cells[clmrawmaterialmaterialtype.Index].Value = ((clsRawMaterial)cmbRawMaterial.SelectedItem).RawMaterialtypeName.ToUpper();
                        dgvRawMaterial.Rows[0].Cells[clmrawmaterialname.Index].Value = ((clsRawMaterial)cmbRawMaterial.SelectedItem).name.ToUpper();
                        dgvRawMaterial.Rows[0].Cells[clmrawmaterialmycode.Index].Value = ((clsRawMaterial)cmbRawMaterial.SelectedItem).code.ToUpper();
                        dgvRawMaterial.Rows[0].Cells[clmrawmaterialgrossweigth.Index].Value = Math.Round(((((Convert.ToDouble(txttotalwe.Text)))) + (Convert.ToDouble((rdn.Next(17, 20) + rdn.NextDouble()).ToString()))), 2, MidpointRounding.AwayFromZero);
                        dgvRawMaterial.Rows[0].Cells[clmrawmaterialnetweigth.Index].Value = Math.Round(((Convert.ToDouble(txttotalwe.Text))), 2, MidpointRounding.AwayFromZero);
                        dgvRawMaterial.Rows[0].Cells[clmrawmaterialmycode.Index].Value = ((clsRawMaterial)cmbRawMaterial.SelectedItem).code.ToUpper();
                        dgvRawMaterial.Rows[0].Cells[clmrawmaterialbag.Index].Value = 1;
                        dgvRawMaterial.Rows[0].Cells[clmrawmaterialcodsec.Index].Value = isInitialValue;
                        dgvRawMaterial.Rows[0].Cells[clmrawmateriallotnumber.Index].Value = txtLotnumber.Text.Trim().ToUpper();
                        dgvRawMaterial.Rows[0].Cells[clmrawmaterialcode.Index].Value = GenerateCode();
                        dgvRawMaterial.Rows[0].Cells[clmrawmaterialdelete.Index].Value = global::BPS.Raw.Properties.Resources.cross;
                        totalnetweigth += Math.Round(((Convert.ToDouble(txttotalwe.Text))), 2, MidpointRounding.AwayFromZero);
                        //totalgrossweigth += Math.Round(Convert.ToDouble(dgvRawMaterial.Rows[i].Cells[clmrawmaterialgrossweigth.Index].Value), 2, MidpointRounding.AwayFromZero);
                        
                        lblTotalNetWeigth.Text = Math.Round(totalnetweigth, 2, MidpointRounding.AwayFromZero).ToString();
                        //lblgrossweigth.Text = Math.Round(totalgrossweigth, 2, MidpointRounding.AwayFromZero).ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("Existen datos que no están llenos completamente o no cumplen con las condiciones establecidas", "Materias Primas", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                cmbRawMaterial.Focus();
            }
        }

        private void dgvRawMaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmrawmaterialdelete.Index)
            {
                if (MessageBox.Show("Esta realmente seguro que desea eliminar el pallet seleccionado?", "Materias Primas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                    dgvRawMaterial.Rows.RemoveAt(e.RowIndex);
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
                        if (this.type == "Pallet")
                        {
                            objRawMaterial = new clsRawMaterialbyCoilCellar();
                            objRawMaterial.fkStatus = 1096;
                            objRawMaterial.fkrawmaterial = ((clsRawMaterial)cmbRawMaterial.SelectedItem).codsec;
                            objRawMaterial.product = dgvRawMaterial.Rows[i].Cells[clmrawmaterialname.Index].Value.ToString().ToUpper();
                            objRawMaterial.lotnumber = dgvRawMaterial.Rows[i].Cells[clmrawmateriallotnumber.Index].Value.ToString().ToUpper();
                            //objRawMaterial.siigoCellar = siigocellarType(type);
                            //objRawMaterial.siigoMovement = siigomovType(type);
                            objRawMaterial.bag = Convert.ToInt32(dgvRawMaterial.Rows[i].Cells[clmrawmaterialbag.Index].Value);
                            objRawMaterial.ingress = true;
                            objRawMaterial.output = false;
                            objRawMaterial.devolution = false;
                            objRawMaterial.code = dgvRawMaterial.Rows[i].Cells[clmrawmaterialcode.Index].Value.ToString().ToUpper();
                            objRawMaterial.netweigth = Convert.ToDouble(dgvRawMaterial.Rows[i].Cells[clmrawmaterialnetweigth.Index].Value);
                            objRawMaterial.grossweigth = Convert.ToDouble(dgvRawMaterial.Rows[i].Cells[clmrawmaterialgrossweigth.Index].Value);
                            objRawMaterial.order = Convert.ToInt32(dgvRawMaterial.Rows[i].Cells[clmrawmaterialcodsec.Index].Value);
                            objRawMaterial.provider = dgvRawMaterial.Rows[i].Cells[clmrawmaterialprovider.Index].Value.ToString().ToUpper();                          
                            objRawMaterial.movement = "Ingreso a Bodega MP por pallets";
                            objRawMaterial.notes = txtNotes.Text.ToUpper();
                            objRawMaterial.isImport = true;
                            if (!objRawMaterial.save())
                            {
                                flgValidate = false;
                                break;
                            }
                        }

                        if (this.type == "Granel")
                        {
                            if (clsRawMaterialbySilo.validateMaterial(((clsRawMaterial)cmbRawMaterial.SelectedItem).codsec, Convert.ToInt32(cbsilo.Text)))
                            {
                                objRawSilo.code = dgvRawMaterial.Rows[i].Cells[clmrawmaterialcode.Index].Value.ToString().ToUpper();
                                objRawSilo.fkrawcodsec = ((clsRawMaterial)cmbRawMaterial.SelectedItem).codsec;
                                objRawSilo.fksilo = Convert.ToInt32(cbsilo.Text);
                                objRawSilo.lotnumber = dgvRawMaterial.Rows[i].Cells[clmrawmateriallotnumber.Index].Value.ToString().ToUpper();
                                objRawSilo.rawmaterialname = dgvRawMaterial.Rows[i].Cells[clmrawmaterialmaterialtype.Index].Value.ToString().ToUpper();
                                objRawSilo.weigth = Convert.ToDouble(dgvRawMaterial.Rows[i].Cells[clmrawmaterialnetweigth.Index].Value);
                                if (!objRawSilo.save())
                                {
                                    flgValidate = false;
                                    break;
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se puede ingresar el material porque no coincide el tipo de materia prima almacenada en el silo.", "Materias Primas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            }
                            
                        }
                        
                    }

                    if (flgValidate)
                    {
                        if (clsSequential.updateSequentialRawMaterialPallet((Convert.ToInt32(dgvRawMaterial.Rows[dgvRawMaterial.Rows.Count - 1].Cells[clmrawmaterialcodsec.Index].Value) + 1)))
                        {
                            if (this.type == "Pallet")
                            {
                                MessageBox.Show("Materia prima ingresada correctamente.\n\rSe procederá a imprimir las etiquetas con los códigos de barras\n\rPor favor recuerde etiquetar correctamente los pallets ingresados", "Materias Primas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                for (int i = 0; i < dgvRawMaterial.Rows.Count; i++)
                                {
                                    Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printRawLabel(dgvRawMaterial.Rows[i].Cells[clmrawmaterialcode.Index].Value.ToString(), true, false, false, clsGlobal.password); });
                                    thrdPrint.Start();
                                    thrdPrint.Join();
                                }
                            }
                            if (this.type == "Granel")
                            {
                                /*for (int i = 0; i < dgvRawMaterial.Rows.Count; i++)
                                {
                                    objRawMaterial = new clsRawMaterialbyCoilCellar(dgvRawMaterial.Rows[i].Cells[clmrawmaterialcode.Index].Value.ToString(), true, false, false);
                                    //if (
                                    clsRawMaterialbyCoilCellar.setTransferM(objRawMaterial.codsec.ToString());//)
                                    //{

                                    //if (
                                    clsRawMaterialbyCoilCellar.setTransfer(objRawMaterial.codsec.ToString(), "Salida de Materia Prima Silo " + cbsilo.SelectedItem.ToString(), cbsilo.SelectedItem.ToString());//)
                                    string lastcodsec = clsRawMaterialbyCoilCellar.getLastCodsec().ToString();
                                        //{
                                            MessageBox.Show("Materia prima ingresada correctamente.", "Materias Primas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                        //}
                                        //else
                                        //{
                                        //    MessageBox.Show("Error al ingresar la materia prima", "Materias Primas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                        //}   
                                    //}
                                    //else
                                    //{
                                    //    MessageBox.Show("Error al ingresar la materia prima", "Materias Primas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                    //}
                                            string queryString = "";

                                            queryString += "INSERT INTO bps_prod_rawmaterialextruder (rw_fkRaw, rw_fkMaterial, rw_lotnumber, rw_bag, rw_code, rw_netweigth, rw_date)";
                                            queryString += " VALUES (";
                                            queryString += lastcodsec +", ";
                                            queryString += ((clsRawMaterial)cmbRawMaterial.SelectedItem).codsec.ToString() + ", ";
                                            queryString += "'" + dgvRawMaterial.Rows[i].Cells[clmrawmateriallotnumber.Index].Value.ToString().ToUpper() +"', ";
                                            queryString += Convert.ToInt32(dgvRawMaterial.Rows[i].Cells[clmrawmaterialbag.Index].Value) + ", ";
                                            queryString += "'" + dgvRawMaterial.Rows[i].Cells[clmrawmaterialcode.Index].Value.ToString().ToUpper() + "', ";
                                            queryString += Convert.ToDouble(dgvRawMaterial.Rows[i].Cells[clmrawmaterialnetweigth.Index].Value) + ", ";
                                            queryString += "NOW());";

                                            clsConnection.executeQuery(queryString);
                                }*/
                            }
                            isSave = false;
                            ClearForm();
                        }
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
    }
}
