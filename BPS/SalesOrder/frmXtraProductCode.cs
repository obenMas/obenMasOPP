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
    public partial class frmXtraProductCode : Form
    {
        clsProduct objProduct = new clsProduct();
        bool flgIsNew = false;
                

        public frmXtraProductCode()
        {
            InitializeComponent();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (objProduct.codsec > 0)
            {
                if (flgIsNew == true)
                    clsConnection.executeQuery("INSERT INTO dbo.bps_xtr_productCustomerCode (pcc_fkProduct, pcc_code, pcc_description) VALUES (" + objProduct.codsec.ToString() + ", '" + txtExternalCode.Text + "','" + txtExternalDescription.Text + "');");
                else
                    clsConnection.executeQuery("UPDATE dbo.bps_xtr_productCustomerCode SET pcc_code = '" + txtExternalCode.Text + "', pcc_description = '" + txtExternalDescription.Text + "' WHERE pcc_fkProduct = " + objProduct.codsec.ToString() + ";");

            }
            MessageBox.Show("Se ha registrado la equivalencia con éxito.", "Equivalencia de películas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtExternalID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                objProduct.load(txtProductCode.Text);

                if (objProduct.codsec > 0)
                {
                    lblFilmName.Text = objProduct.code + "  -  " + objProduct.name;

                    DataSet DS = clsConnection.getDataSetResult("SELECT * FROM bps_xtr_productCustomerCode WHERE pcc_fkProduct = " + objProduct.codsec.ToString());

                    if (DS.Tables[0].Rows.Count > 0)
                    {
                        txtExternalDescription.Text = DS.Tables[0].Rows[0]["pcc_description"].ToString();
                        txtExternalCode.Text = DS.Tables[0].Rows[0]["pcc_code"].ToString();
                        flgIsNew = false;
                    }
                    else
                    {
                        txtExternalDescription.Text = "";
                        txtExternalCode.Text = "";
                        flgIsNew = true;
                    }
                }
            }
        }
    }
}
