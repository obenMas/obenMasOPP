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
    public partial class frmBoppWeigthParameter : Form
    {
        clsParameters objParameters = new clsParameters();
        List<clsParameters> lstParameters = clsParameters.getBoppListWithParameters();

        public frmBoppWeigthParameter()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(tbpWeigthBackup);
        }

        private void PopulateFilm()
        {
            List<clsParameters> lstParameters = new List<clsParameters>();
            lstParameters = clsParameters.getListByFilm();
            cmbFilm.Items.Clear();
            for (int i = 0; i < lstParameters.Count; i++)
                cmbFilm.Items.Add(lstParameters[i]);
        }
        private void loadFilmData()
        {   
            dgvParameters.Rows.Clear();

            if (txtCode.Text != "")
            {
                for (int i = 0; i < lstParameters.Count; i++)
                {
                    if (lstParameters[i].BoppName.ToUpper().StartsWith(txtCode.Text.ToUpper()))
                    {
                        dgvParameters.Rows.Add();
                        dgvParameters.Rows[dgvParameters.Rows.Count - 1].Cells[clmCodsec.Index].Value = lstParameters[i].codsec;
                        dgvParameters.Rows[dgvParameters.Rows.Count - 1].Cells[clmBoppCodsec.Index].Value = lstParameters[i].fkBopp;
                        dgvParameters.Rows[dgvParameters.Rows.Count - 1].Cells[clmCoreCodsec.Index].Value = lstParameters[i].fkCore;
                        dgvParameters.Rows[dgvParameters.Rows.Count - 1].Cells[clmDiameterCodsec.Index].Value = lstParameters[i].fkDiameter;
                        dgvParameters.Rows[dgvParameters.Rows.Count - 1].Cells[clmFilmName.Index].Value = lstParameters[i].BoppName;
                        dgvParameters.Rows[dgvParameters.Rows.Count - 1].Cells[clmDiameter.Index].Value = lstParameters[i].DiameterValue.ToString();
                        dgvParameters.Rows[dgvParameters.Rows.Count - 1].Cells[clmCore.Index].Value = lstParameters[i].CoreValue.ToString();
                        dgvParameters.Rows[dgvParameters.Rows.Count - 1].Cells[clmWeigthFactor.Index].Value = Math.Round(lstParameters[i].weightFactor, 2);
                        dgvParameters.Rows[dgvParameters.Rows.Count - 1].Cells[clmLength.Index].Value = Math.Round(lstParameters[i].aproxLength, 2);
                    }
                }
            }
            else
            {
                for (int i = 0; i < lstParameters.Count; i++)
                {
                    dgvParameters.Rows.Add();
                    dgvParameters.Rows[i].Cells[clmCodsec.Index].Value = lstParameters[i].codsec;
                    dgvParameters.Rows[i].Cells[clmBoppCodsec.Index].Value = lstParameters[i].fkBopp;
                    dgvParameters.Rows[i].Cells[clmCoreCodsec.Index].Value = lstParameters[i].fkCore;
                    dgvParameters.Rows[i].Cells[clmDiameterCodsec.Index].Value = lstParameters[i].fkDiameter;
                    dgvParameters.Rows[i].Cells[clmFilmName.Index].Value = lstParameters[i].BoppName;
                    dgvParameters.Rows[i].Cells[clmDiameter.Index].Value = lstParameters[i].DiameterValue.ToString();
                    dgvParameters.Rows[i].Cells[clmCore.Index].Value = lstParameters[i].CoreValue.ToString();
                    dgvParameters.Rows[i].Cells[clmWeigthFactor.Index].Value = Math.Round(lstParameters[i].weightFactor, 2);
                    dgvParameters.Rows[i].Cells[clmLength.Index].Value = Math.Round(lstParameters[i].aproxLength, 2);
                }
            }
        }
        private void frmBoppWeigthParameter_Load(object sender, EventArgs e)
        {
            PopulateFilm();
            //loadFilmData();
        }

        private void dgvParameters_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                objParameters = new clsParameters();
                objParameters.codsec = Convert.ToInt32(dgvParameters.Rows[e.RowIndex].Cells[clmCodsec.Index].Value);
                objParameters.fkBopp = Convert.ToInt32(dgvParameters.Rows[e.RowIndex].Cells[clmBoppCodsec.Index].Value);
                objParameters.fkDiameter = Convert.ToInt32(dgvParameters.Rows[e.RowIndex].Cells[clmDiameterCodsec.Index].Value);
                objParameters.fkCore = Convert.ToInt32(dgvParameters.Rows[e.RowIndex].Cells[clmCoreCodsec.Index].Value);
                objParameters.BoppName = dgvParameters.Rows[e.RowIndex].Cells[clmFilmName.Index].Value.ToString();
                objParameters.DiameterValue = Convert.ToDouble(dgvParameters.Rows[e.RowIndex].Cells[clmDiameter.Index].Value);
                objParameters.CoreValue = Convert.ToInt32(dgvParameters.Rows[e.RowIndex].Cells[clmCore.Index].Value);
                objParameters.weightFactor = Convert.ToDouble(dgvParameters.Rows[e.RowIndex].Cells[clmWeigthFactor.Index].Value);
                objParameters.aproxLength = Convert.ToDouble(dgvParameters.Rows[e.RowIndex].Cells[clmLength.Index].Value);
                lblFilmName.Text = objParameters.BoppName;
                lblDiameter.Text = objParameters.DiameterValue.ToString();
                lblCore.Text = objParameters.CoreValue.ToString();
                txtWeigthFactor.Text = Convert.ToString(Math.Round(objParameters.weightFactor, 2));
                txtLength.Text = Convert.ToString(Math.Round(objParameters.aproxLength, 2));
            }
        }

        private void btnMainCoilSave_Click(object sender, EventArgs e)
        {
            objParameters.weightFactor = Convert.ToDouble(txtWeigthFactor.Text);
            objParameters.aproxLength = Convert.ToDouble(txtLength.Text);
            objParameters.save();
            lstParameters = clsParameters.getBoppListWithParameters();
            loadFilmData();
        }
         
        private void btnMainCoilCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta realmenet seguro que desea cancelar Película Bopp?..", "Películas Bopp", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lblFilmName.Text = "";
                lblDiameter.Text = "";
                lblCore.Text = "";
                txtWeigthFactor.Text = "";
                txtLength.Text = "";
            }
        }

        private void btnMainCoilExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            //loadFilmData();
        }

        private void cmbFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilm.SelectedIndex > -1)
                PopulateData(((clsParameters)cmbFilm.SelectedItem).fkBopp);
        }

        private void PopulateData(int codsec)
        {
            dgvParametersByFilm.Rows.Clear();
            List<clsParameters> lstParameters = new List<clsParameters>();
            lstParameters = clsParameters.getListByFilmCodsec(codsec);
            for (int i = 0; i < lstParameters.Count; i++)
            {
                dgvParametersByFilm.Rows.Add();
                dgvParametersByFilm.Rows[i].Cells[clmcodsecparameter.Index].Value = lstParameters[i].codsec;
                dgvParametersByFilm.Rows[i].Cells[clmFilmparameter.Index].Value = lstParameters[i].BoppName;
                dgvParametersByFilm.Rows[i].Cells[clmdiameterparameter.Index].Value = lstParameters[i].DiameterValue;
                dgvParametersByFilm.Rows[i].Cells[clmdiameternameparameter.Index].Value = lstParameters[i].DiameterName;
                dgvParametersByFilm.Rows[i].Cells[clmcoreparameter.Index].Value = lstParameters[i].CoreValue;
                dgvParametersByFilm.Rows[i].Cells[clmweigthparameter.Index].Value = lstParameters[i].weightFactor;
                dgvParametersByFilm.Rows[i].Cells[clmfkcore.Index].Value = lstParameters[i].fkCore;
                dgvParametersByFilm.Rows[i].Cells[clmfkdiameter.Index].Value = lstParameters[i].fkDiameter;

            }
        }

        private void btnExitParameters_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveParameters_Click(object sender, EventArgs e)
        {
            if (txtPCM.Text != string.Empty)
            {
                bool flgValidate = true;
                clsParameters ObjParameter = new clsParameters();
                for (int i = 0; i < dgvParametersByFilm.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dgvParametersByFilm.Rows[i].Cells[clmcodsecparameter.Index].Value) == 0)
                    {
                        clsParameters ObjParameterS = new clsParameters();
                        ObjParameterS.fkBopp = ((clsParameters)cmbFilm.SelectedItem).fkBopp;
                        ObjParameterS.fkDiameter = Convert.ToInt32(dgvParametersByFilm.Rows[i].Cells[clmfkdiameter.Index].Value);
                        ObjParameterS.fkCore = Convert.ToInt32(dgvParametersByFilm.Rows[i].Cells[clmfkcore.Index].Value);
                        ObjParameterS.weightFactor = Convert.ToDouble(txtPCM.Text);
                        ObjParameterS.aproxLength = 1024;
                        if (!ObjParameterS.save())
                        {
                            flgValidate = false;
                            break;
                        }
                    }
                    else
                    {
                        ObjParameter.load(Convert.ToInt32(dgvParametersByFilm.Rows[i].Cells[clmcodsecparameter.Index].Value));
                        ObjParameter.weightFactor = Convert.ToDouble(txtPCM.Text);
                        if (!ObjParameter.save())
                        {
                            flgValidate = false;
                            break;
                        }
                    }
                }
                if (flgValidate)
                {
                    MessageBox.Show("Pesos por centimetro guardados correctamente", "Peso x Centímetro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopulateData(((clsParameters)cmbFilm.SelectedItem).fkBopp);
                }
                else
                    MessageBox.Show("La información no ha podido ser procesada", "Peso x Centímetro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPCM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}