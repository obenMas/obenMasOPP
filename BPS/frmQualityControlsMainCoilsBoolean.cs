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
    public partial class frmQualityControlsMainCoilsBoolean : Form
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


        public frmQualityControlsMainCoilsBoolean()
        {
            InitializeComponent();
        }

        public frmQualityControlsMainCoilsBoolean(int MainCoil, int ControlName, int qMed, int qMedNec,int fkCodsec) // popular todas las mediciones que tengan ese maincoil y controlname
        {
            InitializeComponent();
            txtNameControl.Text = clsQualityControls.nameByQualityControlCodsec(ControlName);
            txtActualMedition.Text = (qMed + 1).ToString();
            txtTotalMed.Text = qMedNec.ToString();

            fkmain = MainCoil;
            Cname = ControlName;
            codsec = fkCodsec;
            

            getDataSet();
            PopulateDgv();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtActualMedition.Text) > Convert.ToInt32(txtTotalMed.Text))
            {
                MessageBox.Show("Ya tiene el total de mediciones necesarias.", "Control de Bobina Madre", MessageBoxButtons.OK);
                System.Threading.Thread.Sleep(1500);
                this.Close();
            }
            else
            {
                objQCByMainC.fkMainCoil = fkmain;
                objQCByMainC.fkQualityControlByFilm = codsec;
                objQCByMainC.meditionNumber = Convert.ToInt32(txtActualMedition.Text);
                if (chkValue.Checked == true)
                {
                    objQCByMainC.Value = "1";
                }
                else
                {
                    objQCByMainC.Value = "0";
                }
                objQCByMainC.save();
                txtActualMedition.Text = ((Convert.ToInt32(txtActualMedition.Text)) + 1).ToString();
            }
            getDataSet();
            PopulateDgv();

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
                    if (Convert.ToInt32(DS.Tables[0].Rows[i]["qcbmc_Value"]) == 1)
                    {
                        dgvMainCoilsControl.Rows[dgvMainCoilsControl.Rows.Count - 1].Cells[clmCheck.Index].Value = true;
                    }
                    else
                    {
                        dgvMainCoilsControl.Rows[dgvMainCoilsControl.Rows.Count - 1].Cells[clmCheck.Index].Value = false;
                    }
                    
                }
            }
        }
    }
}
