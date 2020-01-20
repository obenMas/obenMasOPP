using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmReactiveSiigo : Form
    {
        public frmReactiveSiigo()
        {
            InitializeComponent();
        }

        public bool validateForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtE10, ref lblE10, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtE21, ref lblE21, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtE22, ref lblE22, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtE43, ref lblE43, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtH14, ref lblH14, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtH22, ref lblH22, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtH23, ref lblH23, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtH47, ref lblH47, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtH56, ref lblH56, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtS6, ref lblS6, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtS8, ref lblS8, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtS9, ref lblS9, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtS10, ref lblS10, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtS23, ref lblS23, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtS25, ref lblS25, "notEmpty")) isValid = false;

            return isValid;
        }

        public void clearForm()
        {
            txtE10.Clear();
            txtE21.Clear();
            txtE22.Clear();
            txtE43.Clear();
            txtH14.Clear();
            txtH22.Clear();
            txtH23.Clear();
            txtH47.Clear();
            txtS6.Clear();
            txtS8.Clear();
            txtS9.Clear();
            txtS10.Clear();
            txtS23.Clear();
            txtS25.Clear();
            txtE10.Focus();
            txtH56.Clear();

            txtE4.Clear();
            txtE5.Clear();
            txtE2.Clear();
            txtE35.Clear();
            txtE30.Clear();
            txtE31.Clear();
            txtE33.Clear();
            txtE36.Clear();
            txtH16.Clear();
            txtH4.Clear();
            txtH18.Clear();
            txtH17.Clear();
            txtH5.Clear();
            txtH1.Clear();
            txtH3.Clear();
            txtH7.Clear();
            txtH6.Clear();
            txtS19.Clear();
            txtS21.Clear();

        }

        private void frmReactiveSiigo_Load(object sender, EventArgs e)
        {
            clsSequentialMovementSiigo ObjSiigo = new clsSequentialMovementSiigo();
            ObjSiigo.Load();
            txtE10.Text = ObjSiigo.E10.ToString();
            txtE21.Text = ObjSiigo.E21.ToString();
            txtE22.Text = ObjSiigo.E22.ToString();
            txtE43.Text = ObjSiigo.E43.ToString();
            txtH14.Text = ObjSiigo.H14.ToString();
            txtH22.Text = ObjSiigo.H22.ToString();
            txtH23.Text = ObjSiigo.H23.ToString();
            txtH47.Text = ObjSiigo.H47.ToString();
            txtS6.Text = ObjSiigo.S6.ToString();
            txtS8.Text = ObjSiigo.S8.ToString();
            txtS9.Text = ObjSiigo.S9.ToString();
            txtS10.Text = ObjSiigo.S10.ToString();
            txtS23.Text = ObjSiigo.S23.ToString();
            txtS25.Text = ObjSiigo.S25.ToString();
            txtE01.Text = ObjSiigo.E01.ToString();
            txtE11.Text = ObjSiigo.E11.ToString();
            txtE12.Text = ObjSiigo.E12.ToString();
            txtH13.Text = ObjSiigo.H13.ToString();
            txtS14.Text = ObjSiigo.S14.ToString();
            txtE23.Text = ObjSiigo.E23.ToString();
            txtE7.Text = ObjSiigo.E7.ToString();
            txtE37.Text = ObjSiigo.E37.ToString();
            txtE38.Text = ObjSiigo.E38.ToString();
            txtS1.Text = ObjSiigo.S1.ToString();
            txtS26.Text = ObjSiigo.S26.ToString();
            txtS18.Text = ObjSiigo.S18.ToString();
            txtS20.Text = ObjSiigo.S20.ToString();
            txtH56.Text = ObjSiigo.H56.ToString();

            txtE4.Text = ObjSiigo.E4.ToString();
            txtE5.Text = ObjSiigo.E5.ToString();
            txtE2.Text = ObjSiigo.E2.ToString();
            txtE35.Text = ObjSiigo.E35.ToString();
            txtE30.Text = ObjSiigo.E30.ToString();
            txtE31.Text = ObjSiigo.E31.ToString();
            txtE33.Text = ObjSiigo.E33.ToString();
            txtE36.Text = ObjSiigo.E36.ToString();

            txtH1.Text = ObjSiigo.H1.ToString();
            txtH3.Text = ObjSiigo.H3.ToString();
            txtH7.Text = ObjSiigo.H7.ToString();
            txtH6.Text = ObjSiigo.H6.ToString();
            txtH16.Text = ObjSiigo.H16.ToString();
            txtH4.Text = ObjSiigo.H4.ToString();
            txtH18.Text = ObjSiigo.H18.ToString();
            txtH17.Text = ObjSiigo.H17.ToString();
            txtH5.Text = ObjSiigo.H5.ToString();

            txtS19.Text = ObjSiigo.S19.ToString();
            txtS21.Text = ObjSiigo.S21.ToString();

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateForm())
                {
                    clsSequentialMovementSiigo ObjSiigo = new clsSequentialMovementSiigo();
                    ObjSiigo.E10 = Convert.ToInt32(txtE10.Text);
                    ObjSiigo.E21 = Convert.ToInt32(txtE21.Text);
                    ObjSiigo.E22 = Convert.ToInt32(txtE22.Text);
                    ObjSiigo.E43 = Convert.ToInt32(txtE43.Text);
                    ObjSiigo.H14 = Convert.ToInt32(txtH14.Text);
                    ObjSiigo.H22 = Convert.ToInt32(txtH22.Text);
                    ObjSiigo.H23 = Convert.ToInt32(txtH23.Text);
                    ObjSiigo.H47 = Convert.ToInt32(txtH47.Text);
                    ObjSiigo.S6 = Convert.ToInt32(txtS6.Text);
                    ObjSiigo.S8 = Convert.ToInt32(txtS8.Text);
                    ObjSiigo.S9 = Convert.ToInt32(txtS9.Text);
                    ObjSiigo.S10 = Convert.ToInt32(txtS10.Text);
                    ObjSiigo.S23 = Convert.ToInt32(txtS23.Text);
                    ObjSiigo.S25 = Convert.ToInt32(txtS25.Text);
                    ObjSiigo.E01 = Convert.ToInt32(txtE01.Text);
                    ObjSiigo.E11 = Convert.ToInt32(txtE11.Text);
                    ObjSiigo.E12 = Convert.ToInt32(txtE12.Text);
                    ObjSiigo.H13 = Convert.ToInt32(txtH13.Text);
                    ObjSiigo.S14 = Convert.ToInt32(txtS14.Text);
                    ObjSiigo.E23 = Convert.ToInt32(txtE23.Text);
                    ObjSiigo.E7 = Convert.ToInt32(txtE7.Text);
                    ObjSiigo.E37 = Convert.ToInt32(txtE37.Text);
                    ObjSiigo.E38 = Convert.ToInt32(txtE38.Text);
                    ObjSiigo.S1 = Convert.ToInt32(txtS1.Text);
                    ObjSiigo.S26 = Convert.ToInt32(txtS26.Text);
                    ObjSiigo.S18 = Convert.ToInt32(txtS18.Text);
                    ObjSiigo.S20 = Convert.ToInt32(txtS20.Text);
                    ObjSiigo.H56 = Convert.ToInt32(txtH56.Text);

                    ObjSiigo.E4 = Convert.ToInt32(txtE4.Text);
                    ObjSiigo.E5 = Convert.ToInt32(txtE5.Text);
                    ObjSiigo.E2 = Convert.ToInt32(txtE2.Text);
                    ObjSiigo.E35 = Convert.ToInt32(txtE35.Text);
                    ObjSiigo.E30 = Convert.ToInt32(txtE30.Text);
                    ObjSiigo.E31 = Convert.ToInt32(txtE31.Text);
                    ObjSiigo.E33 = Convert.ToInt32(txtE33.Text);
                    ObjSiigo.E36 = Convert.ToInt32(txtE36.Text);

                    ObjSiigo.H1 = Convert.ToInt32(txtH1.Text);
                    ObjSiigo.H3 = Convert.ToInt32(txtH3.Text);
                    ObjSiigo.H7 = Convert.ToInt32(txtH7.Text);
                    ObjSiigo.H6 = Convert.ToInt32(txtH6.Text);
                    ObjSiigo.H16 = Convert.ToInt32(txtH16.Text);
                    ObjSiigo.H4 = Convert.ToInt32(txtH4.Text);
                    ObjSiigo.H18 = Convert.ToInt32(txtH18.Text);
                    ObjSiigo.H17 = Convert.ToInt32(txtH17.Text);
                    ObjSiigo.H5 = Convert.ToInt32(txtH5.Text);

                    ObjSiigo.S19 = Convert.ToInt32(txtS19.Text);
                    ObjSiigo.S21 = Convert.ToInt32(txtS21.Text);

                    if (ObjSiigo.save())
                    {
                        MessageBox.Show("Secuenciales guardados con éxito", "Siigo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Siigo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.\r\n" + ex.Message, "Siigo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                throw;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}