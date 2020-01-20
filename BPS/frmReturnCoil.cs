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
    public partial class frmReturnCoil : Form
    {
        public bool isAutoricet = false;

        public frmReturnCoil()
        {
            //frmCellarLogin winLogin = new frmCellarLogin(this);
            //winLogin.ShowDialog(this);

            //if (isAutoricet)
            //{
                InitializeComponent();
            //}
            //else
            //    this.Close();
        }

        public frmReturnCoil(string code)
        {
            InitializeComponent();
        }

        private void frmCoilDetail_Load(object sender, EventArgs e)
        {
            cmbFilm.Enabled = false;
            cmbProduct.Enabled = false;
            cmbFilmOpp.Enabled = false;
            cmbProductOpp.Enabled = false;
            PopulateFilm();
            PopulateProduct();
            PopulateFilmOpp();
            PopulateProductOpp();
            lblCode.Text = "DEV00" + DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + clsGlobal.FillWithZeros(((new clsSequential().pallet).ToString()), 4);
        }

        private void PopulateProductOpp()
        {
            List<clsProduct> lstProduct = new List<clsProduct>();
            lstProduct = clsProduct.getCastProductList();
            cmbProductOpp.Items.Clear();
            for (int i = 0; i < lstProduct.Count; i++)
                cmbProductOpp.Items.Add(lstProduct[i]);
        }

        private void PopulateFilmOpp()
        {
            List<clsCast> lstCast = new List<clsCast>();
            lstCast = clsCast.getList();
            cmbFilmOpp.Items.Clear();
            for (int i = 0; i < lstCast.Count; i++)
                cmbFilmOpp.Items.Add(lstCast[i]);
        }

        private void PopulateFilm()
        {
            List<clsBopp> lstBopp = new List<clsBopp>();
            lstBopp = clsBopp.getList();
            cmbFilm.Items.Clear();
            for (int i = 0; i < lstBopp.Count; i++)
                cmbFilm.Items.Add(lstBopp[i]);
        }

        private void PopulateProduct()
        {
            List<clsProduct> lstProduct = new List<clsProduct>();
            lstProduct = clsProduct.getBoppProductList();
            cmbProduct.Items.Clear();
            for (int i = 0; i < lstProduct.Count; i++)
                cmbProduct.Items.Add(lstProduct[i]);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string mycode = String.Empty;

            try
            {
                if (ValidateForm())
                {
                    if (clsReturn.isUnique(lblCode.Text))
                        mycode = lblCode.Text;
                    else
                        mycode = "DEV00" + DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + clsGlobal.FillWithZeros(((new clsSequential().pallet).ToString()), 4) + clsGlobal.FillWithZeros(DateTime.Now.Millisecond.ToString(), 2);

                    clsReturn ObjReturn = new clsReturn();
                    if (cmbFilm.SelectedIndex > -1 && cmbFilm.Enabled == true)
                    {
                        ObjReturn.code = mycode;
                        ObjReturn.fkFilm = ((clsBopp)cmbFilm.SelectedItem).codsec;
                        ObjReturn.fkProduct = 0;
                        ObjReturn.customer = txtCustomer.Text;
                        ObjReturn.cellar = lblCoilCellar.Text;
                        ObjReturn.notes = txtRizon.Text;
                        ObjReturn.weigth = Convert.ToDouble(txtWeight.Text);
                        ObjReturn.movement = "E001";
                        ObjReturn.cellar = "0023";
                        ObjReturn.ingress = true;
                        ObjReturn.outt = false;
                        ObjReturn.boppweigth = ObjReturn.weigth;
                        ObjReturn.oppweigth = 0;
                        ObjReturn.pallet = Convert.ToInt32(txtpallet.Text);
                        ObjReturn.coil = Convert.ToInt32(txtcoil.Text);
                        if (ObjReturn.save())
                        {
                            Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printReturnLabel(clsReturn.getlastcodsec()); });
                            thrdPrint.Start();
                            thrdPrint.Join();

                            if (MessageBox.Show("Devolución generada correctamente\r\nDesea Generar una nueva devolución", "Devolución", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                            {
                                Reload();
                                txtWeight.Focus();
                                lblCode.Text = "DEV00" + DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + clsGlobal.FillWithZeros(((new clsSequential().pallet).ToString()), 4) + clsGlobal.FillWithZeros(DateTime.Now.Millisecond.ToString(), 2);
                            }
                            else
                                this.Close();
                        }
                    }
                    else if (cmbProduct.SelectedIndex > -1 && cmbProduct.Enabled == true)
                    {
                        ObjReturn.code = mycode;
                        ObjReturn.fkFilm = (((clsProduct)cmbProduct.SelectedItem).fkBopp);
                        ObjReturn.fkProduct = (((clsProduct)cmbProduct.SelectedItem).codsec);
                        ObjReturn.customer = txtCustomer.Text;
                        ObjReturn.cellar = lblCoilCellar.Text;
                        ObjReturn.notes = txtRizon.Text;
                        ObjReturn.weigth = Convert.ToDouble(txtWeight.Text);
                        ObjReturn.movement = "E001";
                        ObjReturn.cellar = "0023";
                        ObjReturn.ingress = true;
                        ObjReturn.outt = false;
                        ObjReturn.boppweigth = ObjReturn.weigth;
                        ObjReturn.oppweigth = 0;
                        ObjReturn.pallet = Convert.ToInt32(txtpallet.Text);
                        ObjReturn.coil = Convert.ToInt32(txtcoil.Text);
                        if (ObjReturn.save())
                        {
                            Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printReturnLabel(clsReturn.getlastcodsec()); });
                            thrdPrint.Start();
                            thrdPrint.Join();

                            if (MessageBox.Show("Devolución generada correctamente\r\nDesea Generar una nueva devolución", "Devolución", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                            {
                                Reload();
                                txtWeight.Focus();
                                lblCode.Text = "DEV00" + DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + clsGlobal.FillWithZeros(((new clsSequential().pallet).ToString()), 4) + clsGlobal.FillWithZeros(DateTime.Now.Millisecond.ToString(), 2);
                            }
                            else
                                this.Close();
                        }
                    }
                    else if (cmbFilmOpp.SelectedIndex > -1 && cmbFilmOpp.Enabled == true)
                    {
                        ObjReturn.code = mycode;
                        ObjReturn.fkFilm = ((clsCast)cmbFilmOpp.SelectedItem).codsec;
                        ObjReturn.fkProduct = 0;
                        ObjReturn.customer = txtCustomer.Text;
                        ObjReturn.cellar = lblCoilCellar.Text;
                        ObjReturn.notes = txtRizon.Text;
                        ObjReturn.weigth = Convert.ToDouble(txtWeight.Text);
                        ObjReturn.movement = "E001";
                        ObjReturn.cellar = "0023";
                        ObjReturn.ingress = true;
                        ObjReturn.outt = false;
                        ObjReturn.boppweigth = 0;
                        ObjReturn.oppweigth = ObjReturn.weigth;
                        ObjReturn.pallet = Convert.ToInt32(txtpallet.Text);
                        ObjReturn.coil = Convert.ToInt32(txtcoil.Text);
                        if (ObjReturn.save())
                        {
                            Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printReturnLabel(clsReturn.getlastcodsec()); });
                            thrdPrint.Start();
                            thrdPrint.Join();

                            if (MessageBox.Show("Devolución generada correctamente\r\nDesea Generar una nueva devolución", "Devolución", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                            {
                                Reload();
                                txtWeight.Focus();
                                lblCode.Text = "DEV00" + DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + clsGlobal.FillWithZeros(((new clsSequential().pallet).ToString()), 4) + clsGlobal.FillWithZeros(DateTime.Now.Millisecond.ToString(), 2);
                            }
                            else
                                this.Close();
                        }
                    }
                    else
                    {
                        ObjReturn.code = mycode;
                        ObjReturn.fkFilm = (((clsProduct)cmbProductOpp.SelectedItem).fkCast);
                        ObjReturn.fkProduct = (((clsProduct)cmbProductOpp.SelectedItem).codsec);
                        ObjReturn.customer = txtCustomer.Text;
                        ObjReturn.cellar = lblCoilCellar.Text;
                        ObjReturn.notes = txtRizon.Text;
                        ObjReturn.weigth = Convert.ToDouble(txtWeight.Text);
                        ObjReturn.movement = "E001";
                        ObjReturn.cellar = "0023";
                        ObjReturn.ingress = true;
                        ObjReturn.outt = false;
                        ObjReturn.boppweigth = 0;
                        ObjReturn.oppweigth = ObjReturn.weigth;
                        ObjReturn.pallet = Convert.ToInt32(txtpallet.Text);
                        ObjReturn.coil = Convert.ToInt32(txtcoil.Text);
                        if (ObjReturn.save())
                        {
                            Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printReturnLabel(clsReturn.getlastcodsec()); });
                            thrdPrint.Start();
                            thrdPrint.Join();

                            if (MessageBox.Show("Devolución generada correctamente\r\nDesea Generar una nueva devolución", "Devolución", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                            {
                                Reload();
                                txtWeight.Focus();
                                lblCode.Text = "DEV00" + DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + clsGlobal.FillWithZeros(((new clsSequential().pallet).ToString()), 4) + clsGlobal.FillWithZeros(DateTime.Now.Millisecond.ToString(), 2);
                            }
                            else
                                this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Devolución", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private bool ValidateForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtCustomer, ref lblCustomerLabel, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtRizon, ref lblDiameterLabel, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtWeight, ref lblNetWeigthLabel, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtpallet, ref label3, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtcoil, ref label2, "notEmpty")) isValid = false;
            if (rdbFilm.Checked)
            {
                if (!clsValidation.validateField(ref cmbFilm, ref lblDiameterLabel, "selected")) isValid = false;
            }
            else
            {
                if (rdbFilmOpp.Checked)
                {
                    if (!clsValidation.validateField(ref cmbFilmOpp, ref lblDiameterLabel, "selected")) isValid = false;
                }
                else
                {
                    if (rdbProduct.Checked)
                    {
                        if (!clsValidation.validateField(ref cmbProduct, ref lblDiameterLabel, "selected")) isValid = false;
                    }
                    else
                    {
                        if (!clsValidation.validateField(ref cmbProductOpp, ref lblDiameterLabel, "selected")) isValid = false;
                    }
                }
            }
            return isValid;
        }

        private void Reload()
        {
            cmbFilm.SelectedItem = -1;
            cmbFilm.SelectedIndex = -1;
            cmbFilm.Text = string.Empty;
            cmbFilmOpp.SelectedItem = -1;
            cmbFilmOpp.SelectedIndex = -1;
            cmbFilmOpp.Text = string.Empty;
            cmbProduct.SelectedItem = -1;
            cmbProduct.SelectedIndex = -1;
            cmbProduct.Text = string.Empty;
            cmbProductOpp.SelectedItem = -1;
            cmbProductOpp.SelectedIndex = -1;
            cmbProductOpp.Text = string.Empty;
            txtCustomer.Clear();
            txtRizon.Clear();
            txtWeight.Clear();
            rdbFilm.Checked = false;
            rdbFilmOpp.Checked = false;
            rdbProduct.Checked = false;
            rdbProductOpp.Checked = false;
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

        private void rdbFilm_CheckedChanged(object sender, EventArgs e)
        {
            cmbFilm.Enabled = true;
            cmbProduct.Enabled = false;
            cmbFilmOpp.Enabled = false;
            cmbProductOpp.Enabled = false;
            cmbProduct.SelectedItem = -1;
            cmbFilmOpp.SelectedItem = -1;
            cmbProductOpp.SelectedItem = -1;
        }

        private void rdbProduct_CheckedChanged(object sender, EventArgs e)
        {
            cmbProduct.Enabled = true;
            cmbFilm.Enabled = false;
            cmbFilmOpp.Enabled = false;
            cmbProductOpp.Enabled = false;
        }

        private void rdbFilmOpp_CheckedChanged(object sender, EventArgs e)
        {
            cmbFilmOpp.Enabled = true;
            cmbProductOpp.Enabled = false;
            cmbFilm.Enabled = false;
            cmbProduct.Enabled = false;
        }

        private void rdbProductOpp_CheckedChanged(object sender, EventArgs e)
        {
            cmbProductOpp.Enabled = true;
            cmbFilmOpp.Enabled = false;
            cmbFilm.Enabled = false;
            cmbProduct.Enabled = false;
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
    }
}