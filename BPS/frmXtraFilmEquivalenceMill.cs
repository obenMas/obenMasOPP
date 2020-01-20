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
    public partial class frmXtraFilmEquivalenceMill : Form
    {
        clsMillProduct objProduct = new clsMillProduct();

        public frmXtraFilmEquivalenceMill()
        {
            InitializeComponent();
        }
        public frmXtraFilmEquivalenceMill(string productCode)
        {
            InitializeComponent();
            objProduct = new clsMillProduct(productCode);
        }

        private void frmXtraFilmEquivalenceMill_Load(object sender, EventArgs e)
        {
            if (objProduct.codsec > 0)
                lblFilmName.Text = objProduct.name + " [" + objProduct.code + "]";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (objProduct.codsec > 0)
                clsConnection.executeQuery("INSERT INTO dbo.bps_xtr_filmequivalencemill (feq_fkMillProduct, feq_externalId, feq_externalCode, feq_externalDescription) VALUES (" + objProduct.codsec.ToString() + ", '" + txtExternalID.Text + "','" + txtExternalCode.Text + "','" + txtExternalDescription.Text + "');");

            MessageBox.Show("Se ha registrado la equivalencia con éxito.", "Equivalencia de películas Siigo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
