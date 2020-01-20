using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmXtraFilmEquivalence : Form
    {
        bool isRW = false;
        string code = "";

        clsProduct objProduct = new clsProduct();

        public frmXtraFilmEquivalence()
        {
            InitializeComponent();
        }
        public frmXtraFilmEquivalence(string productCode)
        {
            InitializeComponent();
            objProduct = new clsProduct(productCode);
            objProduct = new clsProduct(objProduct.codsec);
        }

        public frmXtraFilmEquivalence(string productCode, bool isRw)
        {
            InitializeComponent();
            this.isRW = isRw;
            this.code = productCode;
            objProduct.Bopp.codsec = 0;
        }

        private void frmXtraFilmEquivalence_Load(object sender, EventArgs e)
        {
            if (objProduct.Bopp.codsec > 0)
                lblFilmName.Text = objProduct.boppCode;
            else
                lblFilmName.Text = objProduct.castCode;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (objProduct.Bopp.codsec > 0)
                clsConnection.executeQuery("INSERT INTO dbo.bps_xtr_filmequivalence (feq_fkBopp, feq_externalId, feq_externalDescription, feq_externalCode) VALUES (" + objProduct.Bopp.codsec.ToString() + ", '" + txtExternalID.Text + "','" + txtExternalDescription.Text + "','" + txtExternalCode.Text + "');");
            else
            {
                if (isRW)
                    clsConnection.executeQuery("INSERT INTO dbo.bps_xtr_filmequivalence (feq_fkRaw, feq_externalId, feq_externalDescription, feq_externalCode) VALUES (" + code + ", '" + txtExternalID.Text + "','" + txtExternalDescription.Text + "','" + txtExternalCode.Text + "');");
                else
                    clsConnection.executeQuery("INSERT INTO dbo.bps_xtr_filmequivalence (feq_fkCast, feq_externalId, feq_externalDescription, feq_externalCode) VALUES (" + objProduct.Cast.codsec.ToString() + ", '" + txtExternalID.Text + "','" + txtExternalDescription.Text + "','" + txtExternalCode.Text + "');");
            }

            MessageBox.Show("Se ha registrado la equivalencia con éxito.", "Equivalencia de películas Siigo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
