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
    public partial class frmEquivalenceMontana : Form
    {
        public frmEquivalenceMontana()
        {
            InitializeComponent();
            PopulateBopp();
            PopulateOpp();
        }

        private void PopulateBopp()
        {
            List<clsParameters> lstParameters = new List<clsParameters>();
            lstParameters = clsParameters.getListByFilm();
            cmbBopp.Items.Clear();
            for (int i = 0; i < lstParameters.Count; i++)
                cmbBopp.Items.Add(lstParameters[i]);
        }

        private void PopulateOpp()
        {
            List<clsCast> lstParameters = new List<clsCast>();
            lstParameters = clsCast.getSimplifiedList();
            cmbOpp.Items.Clear();
            for (int i = 0; i < lstParameters.Count; i++)
                cmbOpp.Items.Add(lstParameters[i]);
        }

        private void cmbBopp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBopp.SelectedIndex > -1)
            {
                clsParameterMontana objParameter = new clsParameterMontana();
                objParameter = clsParameterMontana.getDescriptionByBopp(((clsParameters)cmbBopp.SelectedItem).fkBopp);
                if (objParameter.codsec > 0)
                    txtNotes.Text = objParameter.notes;
                else
                    txtNotes.Clear();
            }
        }

        private void cmbOpp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOpp.SelectedIndex > -1)
            {
                clsParameterMontana objParameter = new clsParameterMontana();
                objParameter = clsParameterMontana.getDescriptionByCast(((clsCast)cmbOpp.SelectedItem).codsec);
                if (objParameter.codsec > 0)
                    txtNotes.Text = objParameter.notes;
                else
                    txtNotes.Clear();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsParameterMontana objParameter = new clsParameterMontana();

            if (ValidateForm())
            {
                if (((clsParameters)cmbBopp.SelectedItem) != null)
                    objParameter = clsParameterMontana.getDescriptionByBopp(((clsParameters)cmbBopp.SelectedItem).fkBopp);
                else
                    objParameter = new clsParameterMontana();
                
                if (objParameter.codsec == 0)
                {
                    if (((clsCast)cmbOpp.SelectedItem) != null)
                    {
                        objParameter = new clsParameterMontana();
                        objParameter = clsParameterMontana.getDescriptionByCast(((clsCast)cmbOpp.SelectedItem).codsec);
                    }
                    else
                        objParameter = new clsParameterMontana();

                    if (objParameter.codsec == 0)
                    {
                        objParameter = new clsParameterMontana();
                        objParameter.fkBopp = (((clsParameters)cmbBopp.SelectedItem) == null) ? 0 : ((clsParameters)cmbBopp.SelectedItem).fkBopp;
                        objParameter.fkCast = (((clsCast)cmbOpp.SelectedItem) == null) ? 0 : ((clsCast)cmbOpp.SelectedItem).codsec;
                        objParameter.notes = txtNotes.Text;
                        if (objParameter.save())
                        {
                            if (MessageBox.Show("Equivalencias ingresadas correctamente.....\n\r Desea Generar una nueva equivalencia??", "Montana", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                                ClearForm();
                            else
                                this.Close();
                        }
                    }
                    else
                    {
                        objParameter.fkBopp = (((clsParameters)cmbBopp.SelectedItem) == null) ? 0 : ((clsParameters)cmbBopp.SelectedItem).fkBopp;
                        objParameter.fkCast = (((clsCast)cmbOpp.SelectedItem) == null) ? 0 : ((clsCast)cmbOpp.SelectedItem).codsec;
                        objParameter.notes = txtNotes.Text;
                        if (objParameter.save())
                        {
                            if (MessageBox.Show("Equivalencias ingresadas correctamente.....\n\r Desea Generar una nueva equivalencia??", "Montana", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                                ClearForm();
                            else
                                this.Close();
                        }
                    }
                }
                else
                {
                    objParameter.fkBopp = (((clsParameters)cmbBopp.SelectedItem) == null) ? 0 : ((clsParameters)cmbBopp.SelectedItem).fkBopp;
                    objParameter.fkCast = (((clsCast)cmbOpp.SelectedItem) == null) ? 0 : ((clsCast)cmbOpp.SelectedItem).codsec;
                    objParameter.notes = txtNotes.Text;
                    if (objParameter.save())
                    {
                        if (MessageBox.Show("Equivalencias ingresadas correctamente.....\n\r Desea Generar una nueva equivalencia??", "Montana", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                            ClearForm();
                        else
                            this.Close();
                    }
                }
            }
        }

        private void ClearForm()
        {
            cmbBopp.Text = "";
            cmbBopp.SelectedItem = -1;
            cmbBopp.SelectedIndex = -1;
            cmbOpp.Text = "";
            cmbOpp.SelectedItem = -1;
            cmbOpp.SelectedIndex = -1;
            txtNotes.Clear();
            cmbBopp.Focus();
        }

        private bool ValidateForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtNotes, ref lblNotes, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbBopp, ref lblFilmBopp, "selected")) isValid = false;
            if (!isValid)
                if (!clsValidation.validateField(ref cmbOpp, ref lblFilmOpp, "selected")) isValid = false;
            return isValid;
        }


    }
}
