using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms; 
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Drawing.Printing;
using System.Threading;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmMaquileCoil : Form
    {
        public bool isAutoricet = false;

        public frmMaquileCoil()
        {
            frmCellarLogin winLogin = new frmCellarLogin(this);
            winLogin.ShowDialog(this);

            if (isAutoricet)
            {
                InitializeComponent();
            }
            else
                this.Close();
        }

        public frmMaquileCoil(string code)
        {
            InitializeComponent();
        }

        private void frmMaquileCoil_Load(object sender, EventArgs e)
        {
            PopulateMaquile();
            PopulateDiameter();
            PopulateCore();
            lblCode.Text = "MAQ00" + DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + clsGlobal.FillWithZeros(((new clsSequential().pallet).ToString()), 4);
        }

        private void PopulateCore()
        {
            List<clsCore> lstCore = new List<clsCore>();
            lstCore = clsCore.getList();
            cmbCore.Items.Clear();
            for (int i = 0; i < lstCore.Count; i++)
                cmbCore.Items.Add(lstCore[i]);
        }

        private void PopulateDiameter()
        {
            List<clsDiameter> lstDiameter = new List<clsDiameter>();
            lstDiameter = clsDiameter.getList();
            cmbDiameter.Items.Clear();
            for (int i = 0; i < lstDiameter.Count; i++)
                cmbDiameter.Items.Add(lstDiameter[i]);
        }

        private void PopulateMaquile()
        {
            List<clsMaquileProduct> lstProduct = new List<clsMaquileProduct>();
            lstProduct = clsMaquileProduct.getList();
            cmbMaquile.Items.Clear();
            for (int i = 0; i < lstProduct.Count; i++)
                cmbMaquile.Items.Add(lstProduct[i]);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string mycode = String.Empty;

            try
            {
                if (ValidateForm())
                {
                    if (clsMaquile.isUnique(lblCode.Text))
                        mycode = lblCode.Text;
                    else
                        mycode = "MAQ00" + DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + clsGlobal.FillWithZeros(((new clsSequential().pallet).ToString()), 4) + clsGlobal.FillWithZeros(DateTime.Now.Millisecond.ToString(), 2);

                    clsMaquile ObjReturn = new clsMaquile();

                    ObjReturn.code = mycode;
                    ObjReturn.fkProduct = ((clsMaquileProduct)cmbMaquile.SelectedItem).codsec;
                    ObjReturn.customer = txtCustomer.Text;
                    ObjReturn.cellar = lblCoilCellar.Text;
                    ObjReturn.notes = txtRizon.Text;
                    ObjReturn.weigth = Convert.ToDouble(txtWeight.Text);
                    ObjReturn.movement = "E011";
                    ObjReturn.cellar = "0019";
                    ObjReturn.ingress = true;
                    ObjReturn.outt = false;
                    ObjReturn.boppweigth = ObjReturn.weigth;
                    ObjReturn.oppweigth = 0;
                    ObjReturn.pallet = Convert.ToInt32(txtpallet.Text);
                    ObjReturn.coil = Convert.ToInt32(txtcoil.Text);
                    ObjReturn.diameter = ((clsDiameter)cmbDiameter.SelectedItem).codsec;
                    ObjReturn.core = ((clsCore)cmbCore.SelectedItem).codsec;
                    ObjReturn.width = Convert.ToInt32(txtWidth.Text);
                    ValidateProduct(ObjReturn.core, ObjReturn.diameter, ObjReturn.width, clsBopp.getFilmByCode(((clsMaquileProduct)cmbMaquile.SelectedItem).abbreviation));
                    ObjReturn.fkproductTo = GenerateMetalizedProduct(ObjReturn.core, ObjReturn.diameter, ObjReturn.width, clsBopp.getFilmByCode(((clsMaquileProduct)cmbMaquile.SelectedItem).abbreviation));
                    ObjReturn.fkproductFrom = clsProduct.toCheckProductMaquileCodsec(clsProduct.maquileCode(ObjReturn.core, ObjReturn.diameter, ObjReturn.width, clsBopp.getFilmByCode(((clsMaquileProduct)cmbMaquile.SelectedItem).abbreviation)));
                    if (ObjReturn.save())
                    {
                        Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printMaquileLabel(clsMaquile.getlastcodsec()); });
                        thrdPrint.Start();
                        thrdPrint.Join();
                        
                        if (MessageBox.Show("Maquila generada correctamente\r\nDesea Generar una nueva maquila", "Maquila", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                        {
                            Reload();
                            txtWeight.Focus();
                            lblCode.Text = "MAQ00" + DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + clsGlobal.FillWithZeros(((new clsSequential().pallet).ToString()), 4) + clsGlobal.FillWithZeros(DateTime.Now.Millisecond.ToString(), 2);
                        }
                        else
                            this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Maquila", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private int GenerateMetalizedProduct(int fkCore, int fkDiameter, int Width, int fkBopp)
        {
            try
            {
                clsBopp objBopp = new clsBopp(fkBopp);
                if (clsProduct.maquileCode(fkCore, fkDiameter, Width, fkBopp) != "No")
                {
                    if (!clsProduct.toCheckProductMaquileMetalized("M" + clsProduct.maquileCode(fkCore, fkDiameter, Width, fkBopp)))
                    {
                        //objBopp.load(fkBopp);
                        if (clsBopp.getFilmByCode("M" + objBopp.code) > 0)
                        {
                            objBopp.load(clsBopp.getFilmByCode("M" + objBopp.code));
                            clsProduct objProduct = new clsProduct();
                            objProduct.fkProductType = 1;
                            objProduct.fkBopp = objBopp.codsec;
                            objProduct.fkCast = 0;
                            objProduct.fkCoating = 0;
                            objProduct.fkThermoformed = 0;
                            objProduct.fkReprocessed = 0;
                            objProduct.fkCore = fkCore;
                            objProduct.fkDiameter = fkDiameter;
                            objProduct.fkUnit = 1;
                            objProduct.fkStatus = 7;
                            objProduct.name = GenerateName(objBopp);
                            objProduct.description = "";
                            objProduct.code = GenerateCode(objBopp);
                            objProduct.systemCode = GenerateSystemCode(objBopp);
                            objProduct.value = 0;
                            objProduct.width = Convert.ToDouble(txtWidth.Text);
                            objProduct.color = "";
                            objProduct.isLocalProduct = true;
                            objProduct.save("Bopp");
                            return clsProduct.toCheckProductMaquileMetalizedCodsec("M" + clsProduct.maquileCode(fkCore, fkDiameter, Width, fkBopp));
                        }
                        else
                            return 0;
                    }
                    else
                        return clsProduct.toCheckProductMaquileMetalizedCodsec("M" + clsProduct.maquileCode(fkCore, fkDiameter, Width, fkBopp));
                }
                else
                    return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Maquila", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                return 0;
            }
        }

        private void ValidateProduct(int fkCore, int fkDiameter, int Width, int fkBopp)
        {
            try
            {
                if (!clsProduct.toCheckProductMaquile(fkCore, fkDiameter, Width, fkBopp))
                {
                    clsBopp objBopp = new clsBopp();
                    objBopp.load(fkBopp);
                    clsProduct objProduct = new clsProduct();
                    objProduct.fkProductType = 1;
                    objProduct.fkBopp = fkBopp;
                    objProduct.fkCast = 0;
                    objProduct.fkCoating = 0;
                    objProduct.fkThermoformed = 0;
                    objProduct.fkReprocessed = 0;
                    objProduct.fkCore = fkCore;
                    objProduct.fkDiameter = fkDiameter;
                    objProduct.fkUnit = 1;
                    objProduct.fkStatus = 7;
                    objProduct.name = GenerateName(objBopp);
                    objProduct.description = "";
                    objProduct.code = GenerateCode(objBopp);
                    objProduct.systemCode = GenerateSystemCode(objBopp);
                    objProduct.value = 0;
                    objProduct.width = Convert.ToDouble(txtWidth.Text);
                    objProduct.color = "";
                    objProduct.isLocalProduct = true;
                    objProduct.save("Bopp");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Maquila", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private string GenerateSystemCode(clsBopp objBopp)
        {
            string code = "";
            code += objBopp.code;
            code += clsGlobal.FillWithZeros(txtWidth.Text, 4);
            code += (cmbDiameter.SelectedIndex >= 0) ? ((((clsDiameter)cmbDiameter.SelectedItem).abbreviation != "") ? ((clsDiameter)cmbDiameter.SelectedItem).abbreviation : "-") : "-";
            code += (cmbCore.SelectedIndex >= 0) ? ((((clsCore)cmbCore.SelectedItem).value.ToString() != "") ? ((clsCore)cmbCore.SelectedItem).value.ToString() : "-") : "-";
            return code;
        }

        private string GenerateCode(clsBopp objBopp)
        {
            string code = "";
            code += objBopp.code.Replace("-", "");
            code += "x" + txtWidth.Text;
            code += (cmbDiameter.SelectedIndex >= 0) ? ((((clsDiameter)cmbDiameter.SelectedItem).abbreviation != "") ? ((clsDiameter)cmbDiameter.SelectedItem).abbreviation : "-") : "-";
            code += (cmbCore.SelectedIndex >= 0) ? ((((clsCore)cmbCore.SelectedItem).value.ToString() != "") ? ((clsCore)cmbCore.SelectedItem).value.ToString() : "-") : "-";
            return code;
        }

        private string GenerateName(clsBopp objBopp)
        {
            string name = "";
            name += objBopp.name;
            name += " x" + txtWidth.Text + "mm ";
            name += (cmbDiameter.SelectedIndex >= 0) ? ((((clsDiameter)cmbDiameter.SelectedItem).abbreviation != "") ? ((clsDiameter)cmbDiameter.SelectedItem).abbreviation : "-") : "-";
            name += (cmbCore.SelectedIndex >= 0) ? ((((clsCore)cmbCore.SelectedItem).value.ToString() != "") ? ((clsCore)cmbCore.SelectedItem).value.ToString() : "-") : "-";
            return name;
        }

        private bool ValidateForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtCustomer, ref lblCustomerLabel, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtRizon, ref lblDiameterLabel, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtWeight, ref lblNetWeigthLabel, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtpallet, ref label3, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtcoil, ref label2, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbMaquile, ref lblMaquile, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbCore, ref lblCore, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbDiameter, ref lblDiameter, "selected")) isValid = false;
            if (!clsValidation.validateField(ref txtWidth, ref lblWidth, "notEmpty")) isValid = false;

            return isValid;
        }

        private void Reload()
        {
            cmbMaquile.SelectedItem = -1;
            cmbMaquile.SelectedIndex = -1;
            cmbMaquile.Text = string.Empty;
            txtCustomer.Clear();
            txtRizon.Clear();
            txtWeight.Clear();
            txtWidth.Clear();
            txtWeight.Focus();
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnMainCoilExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtpallet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtcoil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

    }
}