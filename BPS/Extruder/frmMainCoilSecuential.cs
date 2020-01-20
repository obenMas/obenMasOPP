using System;
using System.Data;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmMainCoilSecuential : Form
    {
        public frmMainCoilSecuential()
        {
            InitializeComponent();
        }

        private void frmMainCoilSecuential_Load(object sender, EventArgs e)
        {
            DataSet DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_extruder WHERE ext_codsec = 3");

            nudMW.Value = Convert.ToInt32(DS.Tables[0].Rows[0]["ext_secuensial"].ToString());
            
            //DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_extruder WHERE ext_codsec = 2");

            //nudDMT.Value = Convert.ToInt32(DS.Tables[0].Rows[0]["ext_secuensial"]);
        }

        private void btnDMT_Click(object sender, EventArgs e)
        {
            clsConnection.executeQuery("UPDATE bps_prod_extruder SET ext_secuensial = " + nudDMT.Value.ToString() + ", ext_coilerRegistration = 3 WHERE ext_codsec = 3");

            MessageBox.Show("Cambio Registrado");
        }

        private void btnMW_Click(object sender, EventArgs e)
        {
            clsConnection.executeQuery("UPDATE bps_prod_extruder SET ext_secuensial = " + nudMW.Value.ToString() + ", ext_coilerRegistration = 1 WHERE ext_codsec = 1");

            MessageBox.Show("Cambio Registrado");
        }
    }
}
