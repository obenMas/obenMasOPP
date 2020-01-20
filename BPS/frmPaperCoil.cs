using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms; 
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Drawing.Printing;
using BPS.Reports;
using System.Threading;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmPaperCoil : Form
    {
        int codsec = 0;
        public frmPaperCoil()
        {
            InitializeComponent();
            tbcLabel.TabPages.Remove(tbpRePrintlabel);
        }

        public frmPaperCoil(int codsec)
        {
            InitializeComponent();
            this.codsec = codsec;
            tbcLabel.TabPages.Remove(tbpLabel);
            FindData(codsec);
        }

        private void FindData(int codsec)
        {
            clsPaper ObjPaper = new clsPaper(codsec);
            txtCodeLabelEdit.Text = ObjPaper.code;
            txtWidthEdit.Text = ObjPaper.width.ToString();
            txtNetWeigthEdit.Text = ObjPaper.netweigth.ToString();
            txtDiameterEdit.Text = ObjPaper.diameter.ToString();
            txtGrossWeigthEdit.Text = ObjPaper.grossweigth.ToString();
            txtMemoEdit.Text = ObjPaper.memo.ToString();
            lblDensityEdit.Text = ObjPaper.density.ToString();
            label2.Text = ObjPaper.material;
            PopulateFromToEdit();
            PopulateCustomerEdit();
            FindCustomer(ObjPaper.fkCustomer);
            FindFromTo(ObjPaper.fkCountry);
        }

        private void FindFromTo(int fromto)
        {
            for (int i = 0; i < cmbFromToEdit.Items.Count; i++)
            {
                if (((clsCountry)cmbFromToEdit.Items[i]).codsec == fromto)
                    cmbFromToEdit.SelectedIndex = i;
            }
        }

        private void FindCustomer(int entity)
        {
            for (int i = 0; i < cmbCustomerEdit.Items.Count; i++)
            {
                if (((clsEntity)cmbCustomerEdit.Items[i]).codsec == entity)
                    cmbCustomerEdit.SelectedIndex = i;
            }
        }

        private void frmPaperCoil_Load(object sender, EventArgs e)
        {
            PopulateCustomer();
            PopulateFromTo();
            ClearForm();   
        }

        private void ClearForm()
        {
            txtWidth.Clear();
            txtNetWeigth.Clear();
            txtGrossWeigth.Clear();
            txtDiameter.Clear();
            lbDensityLabel.Text = string.Empty;
            txtMemo.Clear();
            lblFullCode.Text = string.Empty;
        }

        private void PopulateFromTo()
        {
            List<clsCountry> lstCountry = new List<clsCountry>();
            lstCountry = clsCountry.getList();
            cmbFromTo.Items.Clear();
            for (int i = 0; i < lstCountry.Count; i++)
                cmbFromTo.Items.Add(lstCountry[i]);
        }

        private void PopulateFromToEdit()
        {
            List<clsCountry> lstCountry = new List<clsCountry>();
            lstCountry = clsCountry.getList();
            cmbFromToEdit.Items.Clear();
            for (int i = 0; i < lstCountry.Count; i++)
                cmbFromToEdit.Items.Add(lstCountry[i]);
        }

        private void PopulateCustomer()
        {
            List<clsEntity> lstEntity = new List<clsEntity>();
            lstEntity = clsEntity.getCustomerList();
            cmbCustomer.Items.Clear();
            for (int i = 0; i < lstEntity.Count; i++)
                cmbCustomer.Items.Add(lstEntity[i]);
        }

        private void PopulateCustomerEdit()
        {
            List<clsEntity> lstEntity = new List<clsEntity>();
            lstEntity = clsEntity.getCustomerList();
            cmbCustomerEdit.Items.Clear();
            for (int i = 0; i < lstEntity.Count; i++)
                cmbCustomerEdit.Items.Add(lstEntity[i]);
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                lblFullCode.Text = DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + clsGlobal.FillWithZeros("1", 2) + clsGlobal.FillWithZeros("1", 2) + clsGlobal.FillWithZeros(((new clsSequential().pallet).ToString()), 4);
                clsPaper ObjPaper = new clsPaper();
                ObjPaper.code = lblFullCode.Text;
                ObjPaper.fkCustomer = ((clsEntity)cmbCustomer.SelectedItem).codsec;
                ObjPaper.fkCountry = ((clsCountry)cmbFromTo.SelectedItem).codsec;
                ObjPaper.width = Convert.ToDouble(txtWidth.Text);
                ObjPaper.netweigth = Convert.ToDouble(txtNetWeigth.Text);
                ObjPaper.grossweigth = Convert.ToDouble(txtGrossWeigth.Text);
                ObjPaper.diameter = Convert.ToDouble(txtDiameter.Text);
                ObjPaper.density = Convert.ToDouble(lbDensityLabel.Text);
                ObjPaper.material = (cmbpaper.SelectedIndex > -1) ? cmbpaper.Text.ToString() : "PRY-4010";
                ObjPaper.memo = Convert.ToInt32(txtMemo.Text);
                ObjPaper.createdDate = DateTime.Now;
                ObjPaper.modificatedDate = DateTime.Now;
                ObjPaper.createdBY = clsGlobal.LoggedUser.codsec;
                ObjPaper.modifyBy = clsGlobal.LoggedUser.codsec;
                if (ObjPaper.save())
                {
                    Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printPaperLabel(ObjPaper.getLastSavedCodsec()); });
                    thrdPrint.Start();
                    thrdPrint.Join();
                    MessageBox.Show("Se ha generado correctamente la etiqueta Código " + lblFullCode.Text, "Etiquetas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("Desea generar una nueva bobina", "Etiquetas", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        PopulateCustomer();
                        PopulateFromTo();
                        ClearForm();
                        cmbCustomer.Focus();
                    }
                    else
                        this.Close();
                }
                else
                    MessageBox.Show("No se ha podido procesar los datos correctamente..", "Etiquetas", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
            else
                MessageBox.Show("Debe ingresar todos los datos requeridos para poder continuar", "Etiquetas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private bool ValidateForm()
        {
            bool isValid = true;
            if (!clsValidation.validateField(ref txtDiameter, ref lblDiameter, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtGrossWeigth, ref lblGrossWeigth, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtMemo, ref lblMemo, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbCustomer, ref lblCustomer, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbFromTo, ref lblFromTo, "selected")) isValid = false;
            if (!clsValidation.validateField(ref txtNetWeigth, ref lblNetWeigth, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtWidth, ref lblWidth, "notEmpty")) isValid = false;
            return isValid;
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

        private void txtNetWeigth_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtGrossWeigth_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDiameter_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void txtNetWeigth_TextChanged(object sender, EventArgs e)
        {
            double grossWeigth = Convert.ToDouble(txtNetWeigth.Text) - (Convert.ToInt32(txtWidth.Text) * 0.00147);
            txtGrossWeigth.Text = Convert.ToString(Math.Round(grossWeigth, 2));            
        }

        private void txtDiameter_TextChanged(object sender, EventArgs e)
        {
            lbDensityLabel.Text = Convert.ToString(clsCoil.getCoilDensity(Convert.ToDouble(txtNetWeigth.Text), Convert.ToDouble(txtDiameter.Text), new clsCore(2), Convert.ToDouble(txtWidth.Text)));
        }

        private void txtMemo_TextChanged(object sender, EventArgs e)
        {
            lblFullCode.Text = DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + clsGlobal.FillWithZeros("1", 2) + clsGlobal.FillWithZeros("1", 2) + clsGlobal.FillWithZeros(((new clsSequential().pallet).ToString()), 4);
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            clsPaper ObjPaper = new clsPaper(codsec);
            ObjPaper.fkCustomer = ((clsEntity)cmbCustomerEdit.SelectedItem).codsec;
            ObjPaper.fkCountry = ((clsCountry)cmbFromToEdit.SelectedItem).codsec;
            ObjPaper.width = Convert.ToDouble(txtWidthEdit.Text);
            ObjPaper.netweigth = Convert.ToDouble(txtNetWeigthEdit.Text);
            ObjPaper.grossweigth = Convert.ToDouble(txtGrossWeigthEdit.Text);
            ObjPaper.diameter = Convert.ToDouble(txtDiameterEdit.Text);
            ObjPaper.density = Convert.ToDouble(lblDensityEdit.Text);
            ObjPaper.memo = Convert.ToInt32(txtMemoEdit.Text);
            ObjPaper.modificatedDate = DateTime.Now;
            ObjPaper.modifyBy = clsGlobal.LoggedUser.codsec;
            ObjPaper.material = label2.Text;
            if (ObjPaper.save())
            {
                Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printPaperLabel(codsec); });
                thrdPrint.Start();
                thrdPrint.Join();
                MessageBox.Show("Se ha generado correctamente la etiqueta Código " + lblFullCode.Text, "Etiquetas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se ha podido procesar los datos correctamente..", "Etiquetas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtNetWeigthEdit_TextChanged(object sender, EventArgs e)
        {
            if (txtNetWeigthEdit.Text.Length > 0)
            {
                double grossWeigth = Convert.ToDouble(txtNetWeigthEdit.Text) - (Convert.ToInt32(txtWidthEdit.Text) * 0.00147);
                txtGrossWeigthEdit.Text = Convert.ToString(Math.Round(grossWeigth, 2));
            }
        }

        private void txtDiameterEdit_TextChanged(object sender, EventArgs e)
        {
            if (txtDiameterEdit.Text.Length > 0)
                lblDensityEdit.Text = Convert.ToString(clsCoil.getCoilDensity(Convert.ToDouble(txtNetWeigthEdit.Text), Convert.ToDouble(txtDiameterEdit.Text), new clsCore(2), Convert.ToDouble(txtWidthEdit.Text)));
        }
    }
}
