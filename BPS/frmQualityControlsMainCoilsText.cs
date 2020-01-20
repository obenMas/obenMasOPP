using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Business;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmQualityControlsMainCoilsText : Form
    {
        clsQualityControlsByMainCoil objQCByMainC = new clsQualityControlsByMainCoil();
        int fkmain = 0;
        int Cname = 0;
        int codsec = 0;

        DataSet DS = new DataSet();

        public void getDataSet()
        {
            DS = clsConnection.getDataSetResult("SELECT qcbmc_meditionNumber,qcbmc_Value FROM vwMeditionsByMainCoilAndControlName WHERE qcbmc_fkMainCoil = " + fkmain + "AND qcbmc_fkQualityControlByFilm = " + codsec);
        }

        public frmQualityControlsMainCoilsText()
        {
            InitializeComponent();
        }

        public frmQualityControlsMainCoilsText(int MainCoil, int ControlName, int qMed, int qMedNec, int fkCodsec) // popular todas las mediciones que tengan ese maincoil y controlname
        {
            InitializeComponent();
            txtValue.Focus();
            txtNameControl.Text = clsQualityControls.nameByQualityControlCodsec(ControlName);

            fkmain = MainCoil;
            Cname = ControlName;
            codsec = fkCodsec;
            
            getDataSet();
            PopulateDgv();
            txtValue.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
             if (DS.Tables[0].Rows.Count > 0)
             { 
                MessageBox.Show("Ya tiene el total de mediciones necesarias.", "Control de Bobina Madre", MessageBoxButtons.OK);
                System.Threading.Thread.Sleep(1000);
                this.Close();             
             }
            else
            {
                objQCByMainC.fkMainCoil = fkmain;
                objQCByMainC.fkQualityControlByFilm = codsec;
                objQCByMainC.meditionNumber = 1;
                objQCByMainC.Value = txtValue.Text.ToString();
                objQCByMainC.save();
            }
            getDataSet();
            PopulateDgv();
            txtValue.Text = string.Empty;
            txtValue.Focus();
        }

        public void PopulateDgv()
        {
            dgvMainCoilsControl.Rows.Clear();
            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvMainCoilsControl.Rows.Add();
                    dgvMainCoilsControl.Rows[dgvMainCoilsControl.Rows.Count - 1].Cells[clmMed.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["qcbmc_meditionNumber"]);
                    dgvMainCoilsControl.Rows[dgvMainCoilsControl.Rows.Count - 1].Cells[clmValue.Index].Value = DS.Tables[0].Rows[i][ "qcbmc_Value"].ToString();
                }
            }
            txtValue.Focus();
        }
    }
}
