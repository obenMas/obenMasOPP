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
    public partial class frmCoilToInProcessCellar : Form
    {
        clsCoil objcoil = new clsCoil();
        int ToCoilcellar = 3012; // Producto en proceso Campana
        int ToCoilCellarPL = 4015; // Producto en proceso Pilar
        int inCellar = 1;
        int outCellar = 0;
        DateTime dateMovement = DateTime.Now;
        string lastCellar = string.Empty;

        public frmCoilToInProcessCellar()
        {
            InitializeComponent();
        }

        private void txtCoil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                objcoil = clsCoil.getDetailByCode(txtCoil.Text);
                txtProduct.Text = objcoil.ProductCode;
                lastCellar = clsCoil.getContainerCellarByCoil(objcoil.codsec).ToString();
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
            int FromCoilCellar = 0;
            int FromCoilCellarPL = 0;

            clsCoilCellar objCoilCellarC = new clsCoilCellar();
            clsCoilCellar objCoilCellarPL = new clsCoilCellar();

            //Obtengo el fk de Coilcellar mediante el Nombre de la bodega para en que bodega se encuentra para Campana y Pilar
            objCoilCellarC = clsCoilCellar.getCellarByName(objcoil.Coil_CoilCellarContainer.ToString()); 
            objCoilCellarPL = clsCoilCellar.getCellarByName(objcoil.Coil_CoilCellarContainer.ToString());
            
            //Guardo el codsec de la bodega para Campana y pilar, este dato sera utilizado en la consulta del movimiento
            FromCoilCellar = objCoilCellarC.codsec;
            FromCoilCellarPL = objCoilCellarPL.codsec;

            if (clsGlobal.LoggedUser.fkRole == 2022 || clsGlobal.LoggedUser.fkRole == 2023 || clsGlobal.LoggedUser.fkRole == 2024 || clsGlobal.LoggedUser.fkRole == 12 || clsGlobal.LoggedUser.fkRole == 11) //Campana: C230,C231,C232,Embalaje1 y 2,Juan Fernandez, Martin Bianchi
            {

                if (chkIsInPallet.Checked == false && objcoil.statusName == "Activa")
                {
                    outFromCoilcellarCampana(FromCoilCellar, objcoil.codsec, inCellar, outCellar, dateMovement);

                    if (SendCoilToInProcessCoilCellarCampana(ToCoilcellar, objcoil.codsec, inCellar, outCellar, dateMovement))
                    {
                        MessageBox.Show("Movimiento realizado exitosamente.", "Movimiento de bobina a Producto en Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error al realizar el movimiento", "Movimiento de bobina a Producto en Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }
                }
                else
                {
                    MessageBox.Show("No es posible realizar este movimiento. La bobina no debe estar dentro de un pallet y tiene que estar con estado Activa.", "Movimiento de bobina a Producto en Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }

            //PILAR:

            else if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)// Pilar: SupervisorA,B y C / DigitadorA, B y C.
            {
                if (chkIsInPallet.Checked == false && objcoil.statusName == "Activa")
                {
                   outFromCoilcellarPL(FromCoilCellarPL, objcoil.codsec, inCellar, outCellar, dateMovement);

                   if(SendCoilToInProcessCoilCellarPL(ToCoilCellarPL, objcoil.codsec, inCellar, outCellar, dateMovement))
                   {
                       MessageBox.Show("Movimiento realizado exitosamente.", "Movimiento de bobina a Producto en Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                   }
                }
                else
                {
                    MessageBox.Show("No es posible realizar este movimiento. La bobina no debe estar dentro de un pallet y tiene que estar con estado Activa.", "Movimiento de bobina a Producto en Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
            else
            {
                MessageBox.Show("No posee permiso en su rol de usuario para realizar este movimiento.", "Movimiento de bobina a Producto en Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
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

        public bool SendCoilToInProcessCoilCellarCampana(int cCellar, int coilCodsec, int inCC, int outCC, DateTime dateMv)
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

        public bool SendCoilToInProcessCoilCellarPL(int cCellar, int coilCodsec, int inCC, int outCC, DateTime dateMv)
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
