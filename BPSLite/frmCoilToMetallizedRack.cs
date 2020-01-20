using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS.Lite
{
    public partial class frmCoilToMetallizedRack : Form
    {
        clsCoil objcoil = new clsCoil();
        int ToCoilcellar = 2011;
        int FromCoilCellar = 11;
        int ToCoilCellarPL = 4017;
        int FromCoilCellarPL = 4014;
        int inCellar = 1;
        int outCellar = 0;
        DateTime dateMovement = DateTime.Now;

        public frmCoilToMetallizedRack()
        {
            InitializeComponent();
        }

        private void txtCoil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                objcoil = clsCoil.getDetailByCode(txtCoil.Text);
                txtProduct.Text = objcoil.ProductCode;
                txtLong.Text = objcoil.length.ToString();
                txtWidth.Text = objcoil.width.ToString();
                txtDiameter.Text = objcoil.diameter.ToString();
                txtNetWeight.Text = Math.Round(Convert.ToDouble(objcoil.netWeight), 2).ToString();
                txtStatus.Text = objcoil.statusName;
                txtCoilCellar.Text = objcoil.coilCellarContainer.ToString();
                if (isInPallet(objcoil.codsec))
                {
                    chkIsInPallet.Checked = true;
                }
                else
                {
                    chkIsInPallet.Checked = false;
                }
            }
        }

        public Boolean isInPallet(int coilCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilbypallet WHERE cbp_fkCoil = " + coilCodsec);

            if (DS.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //CAMPANA:

            if (clsGlobal.LoggedUser.fkRole == 2022 || clsGlobal.LoggedUser.fkRole == 2023 || clsGlobal.LoggedUser.fkRole == 2024 || clsGlobal.LoggedUser.fkRole == 12 || clsGlobal.LoggedUser.fkRole == 11) //Campana: C230,C231,C232,Embalaje1 y 2,Juan Fernandez, Martin Bianchi
            {

                if (objcoil.Coil_CoilCellarContainer.ToString() == "Conversión" && chkIsInPallet.Checked == false && objcoil.statusName == "Activa")
                {
                    outFromCoilcellarCampana(FromCoilCellar, objcoil.codsec, inCellar, outCellar, dateMovement);

                    if (SendCoilToMetallizedRackCampana(ToCoilcellar, objcoil.codsec, inCellar, outCellar, dateMovement))
                    {
                        MessageBox.Show("Movimiento realizado exitosamente.", "Movimiento de bobina a Rack de Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error al realizar el movimiento", "Movimiento de bobina a Rack de Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }
                }
                else
                {
                    MessageBox.Show("No es posible realizar este movimiento. La bobina debe encontrarse en la bodega de Conversión, no debe estar dentro de un pallet y tiene que estar con estado Activa.", "Movimiento de bobina a Rack de Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }

            //PILAR:

            else if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)// Pilar: SupervisorA,B y C / DigitadorA, B y C.
            {
                if (objcoil.Coil_CoilCellarContainer.ToString() == "Corte, metalizado y empaque" && chkIsInPallet.Checked == false && objcoil.statusName == "Activa")
                {
                   outFromCoilcellarPL(FromCoilCellarPL, objcoil.codsec, inCellar, outCellar, dateMovement);

                   if(SendCoilToMetallizedRackPL(ToCoilCellarPL, objcoil.codsec, inCellar, outCellar, dateMovement))
                   {
                       MessageBox.Show("Movimiento realizado exitosamente.", "Movimiento de bobina a Rack de Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                   }
                }
                else
                {
                    MessageBox.Show("No es posible realizar este movimiento. La bobina debe encontrarse en la bodega Corte, metalizado y empaque, no debe estar dentro de un pallet y tiene que estar con estado Activa.", "Movimiento de bobina a Rack de Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
            else
            {
                MessageBox.Show("No posee permiso en su rol de usuario para realizar este movimiento.", "Movimiento de bobina a Rack de Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        //CAMPANA

        public bool outFromCoilcellarCampana(int cCellar, int coilCodsec, int inCC, int outCC, DateTime dateMv)
        {
            inCC = 0;
            outCC = 1;

            try
            {
                string queryString = "";
                queryString += "INSERT INTO bps_prod_coilbycoilcellar (cbcc_fkCoilCellar, cbcc_fkCoil, cbcc_in, cbcc_out, cbcc_date)";
                queryString += " VALUES (";
                queryString += "" + cCellar.ToString() + ", ";
                queryString += "" + coilCodsec.ToString() + ", ";
                queryString += "" + inCC.ToString() + ", ";
                queryString += "" + outCC.ToString() + ", ";
                queryString += "'" + dateMv.ToString("dd/MM/yyyy HH:mm") + "' ";
                queryString += ");";

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        public bool SendCoilToMetallizedRackCampana(int cCellar, int coilCodsec, int inCC, int outCC, DateTime dateMv)
        {
            try
            {
                string queryString = "";
                queryString += "INSERT INTO bps_prod_coilbycoilcellar (cbcc_fkCoilCellar, cbcc_fkCoil, cbcc_in, cbcc_out, cbcc_date)";
                queryString += " VALUES (";
                queryString += "" + cCellar.ToString() + ", ";
                queryString += "" + coilCodsec.ToString() + ", ";
                queryString += "" + inCC.ToString() + ", ";
                queryString += "" + outCC.ToString() + ", ";
                queryString += "'" + dateMv.ToString("dd/MM/yyyy HH:mm") + "' ";
                queryString += ");";

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        //PILAR

        public bool outFromCoilcellarPL(int cCellar, int coilCodsec, int inCC, int outCC, DateTime dateMv)
        {
            inCC = 0;
            outCC = 1;

            try
            {
                string queryString = "";
                queryString += "INSERT INTO bps_prod_coilbycoilcellar (cbcc_fkCoilCellar, cbcc_fkCoil, cbcc_in, cbcc_out, cbcc_date)";
                queryString += " VALUES (";
                queryString += "" + cCellar.ToString() + ", ";
                queryString += "" + coilCodsec.ToString() + ", ";
                queryString += "" + inCC.ToString() + ", ";
                queryString += "" + outCC.ToString() + ", ";
                queryString += "'" + dateMv.ToString("dd/MM/yyyy HH:mm") + "' ";
                queryString += ");";

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        public bool SendCoilToMetallizedRackPL(int cCellar, int coilCodsec, int inCC, int outCC, DateTime dateMv)
        {
            try
            {
                string queryString = "";
                queryString += "INSERT INTO bps_prod_coilbycoilcellar (cbcc_fkCoilCellar, cbcc_fkCoil, cbcc_in, cbcc_out, cbcc_date)";
                queryString += " VALUES (";
                queryString += "" + cCellar.ToString() + ", ";
                queryString += "" + coilCodsec.ToString() + ", ";
                queryString += "" + inCC.ToString() + ", ";
                queryString += "" + outCC.ToString() + ", ";
                queryString += "'" + dateMv.ToString("dd/MM/yyyy HH:mm") + "' ";
                queryString += ");";

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
