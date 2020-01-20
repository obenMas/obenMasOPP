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
    public partial class frmQualityControlsMainCoilsNumber : Form
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


        public frmQualityControlsMainCoilsNumber()
        {
            InitializeComponent();
        }

        public frmQualityControlsMainCoilsNumber(int MainCoil, int ControlName, int qMed, int qMedNec, int fkCodsec) // popular todas las mediciones que tengan ese maincoil y controlname
        {
            InitializeComponent();
            txtNumber.Focus();
            txtNameControl.Text = clsQualityControls.nameByQualityControlCodsec(ControlName);
            txtActualMedition.Text = (qMed + 1).ToString();
            txtTotalMed.Text = qMedNec.ToString();

            fkmain = MainCoil;
            Cname = ControlName;
            codsec = fkCodsec;


            getDataSet();
            PopulateDgv();
            txtNumber.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*if (Convert.ToInt32(txtActualMedition.Text) > Convert.ToInt32(txtTotalMed.Text))
            {
                MessageBox.Show("Ya tiene el total de mediciones necesarias.", "Control de Bobina Madre", MessageBoxButtons.OK);
            }
            else
            {
                objQCByMainC.fkMainCoil = fkmain;
                objQCByMainC.fkQualityControlByFilm = codsec;
                objQCByMainC.meditionNumber = Convert.ToInt32(txtActualMedition.Text);
                objQCByMainC.Value = txtNumber.Text.ToString();
                objQCByMainC.save();
                txtActualMedition.Text = ((Convert.ToInt32(txtActualMedition.Text)) + 1).ToString();
            }
            getDataSet();
            PopulateDgv();
            txtNumber.Text = string.Empty;
            txtNumber.Focus();*/
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
                    dgvMainCoilsControl.Rows[dgvMainCoilsControl.Rows.Count - 1].Cells[clmValue.Index].Value = DS.Tables[0].Rows[i]["qcbmc_Value"].ToString();
                }
            }
            txtNumber.Focus();
        }

        private void txtNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

                // preguntar como comparar los string
            {
                if (Convert.ToInt32(txtActualMedition.Text) > Convert.ToInt32(txtTotalMed.Text))
                {
                    MessageBox.Show("Mediciones completas.", "Control de Bobina Madre", MessageBoxButtons.OK);
                    System.Threading.Thread.Sleep(3000);
                    this.Close();
                }

                else if (Convert.ToInt32(txtActualMedition.Text) > Convert.ToInt32(txtTotalMed.Text))
                {
                    MessageBox.Show("Ya tiene el total de mediciones necesarias.", "Control de Bobina Madre", MessageBoxButtons.OK);
                }
                else
                {
                    objQCByMainC.fkMainCoil = fkmain;
                    objQCByMainC.fkQualityControlByFilm = codsec;
                    objQCByMainC.meditionNumber = Convert.ToInt32(txtActualMedition.Text);
                    objQCByMainC.Value = txtNumber.Text.ToString();
                    objQCByMainC.save();
                    txtActualMedition.Text = ((Convert.ToInt32(txtActualMedition.Text)) + 1).ToString();
                }
                getDataSet();
                PopulateDgv();
                txtNumber.Text = string.Empty;
                txtNumber.Focus();
            }
        }
    }
}
