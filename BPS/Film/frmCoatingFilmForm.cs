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
    public partial class frmCoatingFilmForm : Form
    {
        clsCoating objCoatingFilm = new clsCoating();

        public frmCoatingFilmForm()
        {
            InitializeComponent();
        }
        public frmCoatingFilmForm(int codsec)
        {
            InitializeComponent();
            objCoatingFilm = new clsCoating(codsec);
        }
        public bool validateForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtName, ref lblName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtCode, ref lblCode, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbProcess, ref lblProcess, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbSubProcess, ref lblSubProcess, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbTerminationStructure, ref lblTerminationStructure, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbCoatingStructure, ref lblCoatingStructure, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbTreatment, ref lblTreatment, "selected")) isValid = false;

            return isValid;
        }
        public void generateCode()
        {
            string code = "";

            code += (cmbProcess.SelectedIndex >= 0) ? ((((clsProcess)cmbProcess.SelectedItem).abbreviation != "") ? ((clsProcess)cmbProcess.SelectedItem).abbreviation : "-") : "-";
            code += (cmbSubProcess.SelectedIndex >= 0) ? ((((clsProcess)cmbSubProcess.SelectedItem).abbreviation != "") ? ((clsProcess)cmbSubProcess.SelectedItem).abbreviation : "-") : "-";
            code += (cmbTerminationStructure.SelectedIndex >= 0) ? ((((clsStructure)cmbTerminationStructure.SelectedItem).abbreviation != "") ? ((clsStructure)cmbTerminationStructure.SelectedItem).abbreviation : "-") : "-";
            code += (cmbCoatingStructure.SelectedIndex >= 0) ? ((((clsStructure)cmbCoatingStructure.SelectedItem).abbreviation != "") ? ((clsStructure)cmbCoatingStructure.SelectedItem).abbreviation : "-") : "-";
            if (rdoOneThickness.Checked == true)
                code += (lstbCoatingThikness.SelectedIndex >= 0) ? clsGlobal.FillWithZeros(((clsThickness)lstbCoatingThikness.SelectedItem).value.ToString(), 3) : "---";
            else
                code += "---";
            if (rdoOneThickness.Checked == true)
                code += (lstbSubstrateThickness.SelectedIndex >= 0) ? clsGlobal.FillWithZeros(((clsThickness)lstbSubstrateThickness.SelectedItem).value.ToString(), 3) : "---";
            else
                code += "---";
            code += (cmbTreatment.SelectedIndex >= 0) ? ((((clsTreatment)cmbTreatment.SelectedItem).abbreviation != "") ? ((clsTreatment)cmbTreatment.SelectedItem).abbreviation : "-") : "-";

            txtCode.Text = code;
        }
        public string generateCode(string substrateThickness, string coatingThickness)
        {
            string code = "";

            code += (cmbProcess.SelectedIndex >= 0) ? ((((clsProcess)cmbProcess.SelectedItem).abbreviation != "") ? ((clsProcess)cmbProcess.SelectedItem).abbreviation : "-") : "-";
            code += (cmbSubProcess.SelectedIndex >= 0) ? ((((clsProcess)cmbSubProcess.SelectedItem).abbreviation != "") ? ((clsProcess)cmbSubProcess.SelectedItem).abbreviation : "-") : "-";
            code += (cmbTerminationStructure.SelectedIndex >= 0) ? ((((clsStructure)cmbTerminationStructure.SelectedItem).abbreviation != "") ? ((clsStructure)cmbTerminationStructure.SelectedItem).abbreviation : "-") : "-";
            code += (cmbCoatingStructure.SelectedIndex >= 0) ? ((((clsStructure)cmbCoatingStructure.SelectedItem).abbreviation != "") ? ((clsStructure)cmbCoatingStructure.SelectedItem).abbreviation : "-") : "-";
            code += clsGlobal.FillWithZeros(substrateThickness, 3);
            code += clsGlobal.FillWithZeros(coatingThickness, 3);
            code += (cmbTreatment.SelectedIndex >= 0) ? ((((clsTreatment)cmbTreatment.SelectedItem).abbreviation != "") ? ((clsTreatment)cmbTreatment.SelectedItem).abbreviation : "-") : "-";

            return code;
        }
        public void clearForm()
        {
            objCoatingFilm = new clsCoating();
            cmbProcess.SelectedIndex = -1;
            cmbSubProcess.SelectedIndex = -1;
            cmbTerminationStructure.SelectedIndex = -1;
            cmbCoatingStructure.SelectedIndex = -1;
            cmbTreatment.SelectedIndex = -1;
            rdoOneThickness.Checked = true;
            lstbSubstrateThickness.SelectedIndex = -1;
            lstbCoatingThikness.SelectedIndex = -1;
            txtName.Text = "";
            txtCode.Text = "";
            txtName.Focus();
        }
        private void frmCoatingFilmForm_Load(object sender, EventArgs e)
        {
            List<clsProcess> lstProcess = new List<clsProcess>();
            List<clsStructure> lstStructure = new List<clsStructure>();
            List<clsThickness> lstThickness = new List<clsThickness>();
            List<clsTreatment> lstTreatment = new List<clsTreatment>();

            lstProcess = clsProcess.getListProcessForCoat();
            lstStructure = clsStructure.getListStructureForCoat();
            lstThickness = clsThickness.getList();
            lstTreatment = clsTreatment.getListForCoating();

            txtName.Text = "";
            txtCode.Text = "";

            cmbProcess.Items.Clear();
            cmbSubProcess.Items.Clear();
            for (int i = 0; i < lstProcess.Count; i++)
            {
                cmbProcess.Items.Add(lstProcess[i]);
                cmbSubProcess.Items.Add(lstProcess[i]);
            }

            cmbTerminationStructure.Items.Clear();
            cmbCoatingStructure.Items.Clear();
            for (int i = 0; i < lstStructure.Count; i++)
            {
                cmbTerminationStructure.Items.Add(lstStructure[i]);
                cmbCoatingStructure.Items.Add(lstStructure[i]);
            }

            lstbCoatingThikness.Items.Clear();
            lstbSubstrateThickness.Items.Clear();
            for (int i = 0; i < lstThickness.Count; i++)
            {
                lstbCoatingThikness.Items.Add(lstThickness[i]);
                lstbSubstrateThickness.Items.Add(lstThickness[i]);
            }

            cmbTreatment.Items.Clear();
            for (int i = 0; i < lstTreatment.Count; i++)
                cmbTreatment.Items.Add(lstTreatment[i]);
        }

        private void cmbProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProcess.SelectedIndex >= 0)
            {
                lblProcessCode.Text = ((clsProcess)cmbProcess.SelectedItem).abbreviation;
                generateCode();
            }
            else
                lblProcessCode.Text = "";
        }

        private void cmbSubProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSubProcess.SelectedIndex >= 0)
            {
                lblSubProcessCode.Text = ((clsProcess)cmbSubProcess.SelectedItem).abbreviation;
                generateCode();
            }
            else
                lblSubProcessCode.Text = "";
        }

        private void cmbTerminationStructure_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTerminationStructure.SelectedIndex >= 0)
            {
                lblTerminationStructureCode.Text = ((clsStructure)cmbTerminationStructure.SelectedItem).abbreviation;
                generateCode();
            }
            else
                lblTerminationStructureCode.Text = "";
        }

        private void cmbCoatingStructure_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCoatingStructure.SelectedIndex >= 0)
            {
                lblCoatingStructureCode.Text = ((clsStructure)cmbCoatingStructure.SelectedItem).abbreviation;
                generateCode();
            }
            else
                lblCoatingStructureCode.Text = "";
        }

        private void cmbTreatment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTreatment.SelectedIndex >= 0)
            {
                lblTreatmentCode.Text = ((clsTreatment)cmbTreatment.SelectedItem).abbreviation;
                generateCode();
            }
            else
                lblTreatmentCode.Text = "";
        }

        private void rdoOneThickness_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoOneThickness.Checked == false)
            {
                lstbCoatingThikness.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
                if (lstbCoatingThikness.SelectedIndex >= 0)
                {
                    lblCoatingThicknessCode.Text = "---";
                    generateCode();
                }
                else
                    lblCoatingThicknessCode.Text = "";

                lstbSubstrateThickness.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
                if (lstbSubstrateThickness.SelectedIndex >= 0)
                {
                    lblSubstrateThicknessCode.Text = "---";
                    generateCode();
                }
                else
                    lblSubstrateThicknessCode.Text = "";
            }
            else
            {
                lstbCoatingThikness.SelectedIndex = -1;
                lstbCoatingThikness.SelectionMode = System.Windows.Forms.SelectionMode.One;
                if (lstbCoatingThikness.SelectedItems.Count > 0)
                {
                    lblCoatingThicknessCode.Text = "";
                    generateCode();
                }
                else
                    lblCoatingThicknessCode.Text = "";

                lstbSubstrateThickness.SelectedIndex = -1;
                lstbSubstrateThickness.SelectionMode = System.Windows.Forms.SelectionMode.One;
                if (lstbSubstrateThickness.SelectedItems.Count > 0)
                {
                    lblSubstrateThicknessCode.Text = "";
                    generateCode();
                }
                else
                    lblSubstrateThicknessCode.Text = "";
            }
        }

        private void lstbSubstrateThickness_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdoOneThickness.Checked == true && lstbSubstrateThickness.SelectedItem != null)
            {
                lblSubstrateThicknessCode.Text = ((clsThickness)lstbSubstrateThickness.SelectedItem).value.ToString();
                generateCode();
            }
        }

        private void lstbCoatingThikness_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdoOneThickness.Checked == true && lstbCoatingThikness.SelectedItem != null)
            {
                lblCoatingThicknessCode.Text = ((clsThickness)lstbCoatingThikness.SelectedItem).value.ToString();
                generateCode();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateForm())
                {
                    if (rdoOneThickness.Checked == true)
                    {
                        objCoatingFilm.name = txtName.Text;
                        objCoatingFilm.code = txtCode.Text;
                        objCoatingFilm.Process = ((clsProcess)cmbProcess.SelectedItem);
                        objCoatingFilm.fkProcess = objCoatingFilm.Process.codsec;
                        objCoatingFilm.SubProcess = ((clsProcess)cmbSubProcess.SelectedItem);
                        objCoatingFilm.fkSubProcess = objCoatingFilm.SubProcess.codsec;
                        objCoatingFilm.TerminationStructure = ((clsStructure)cmbTerminationStructure.SelectedItem);
                        objCoatingFilm.fkTerminationStructure = objCoatingFilm.TerminationStructure.codsec;
                        objCoatingFilm.CoatingStructure = ((clsStructure)cmbCoatingStructure.SelectedItem);
                        objCoatingFilm.fkCoatingStructure = objCoatingFilm.CoatingStructure.codsec;                        
                        objCoatingFilm.SubstrateThickness = ((clsThickness)lstbSubstrateThickness.SelectedItem);
                        objCoatingFilm.fkSubstrateThickness = objCoatingFilm.SubstrateThickness.codsec;
                        objCoatingFilm.CoatThickness = ((clsThickness)lstbCoatingThikness.SelectedItem);
                        objCoatingFilm.fkCoatThickness = objCoatingFilm.CoatThickness.codsec;
                        objCoatingFilm.Treatment = ((clsTreatment)cmbTreatment.SelectedItem);
                        objCoatingFilm.fkTreatment = objCoatingFilm.Treatment.codsec;

                        if (objCoatingFilm.save())
                        {
                            MessageBox.Show("La película Coating se ha guardado con éxito.", "Coating Film", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                            clearForm();
                        }
                        else
                            MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Coating Film", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

                    }
                    else
                    {
                        bool flgSave = true;

                        for (int i = 0; i < lstbSubstrateThickness.SelectedItems.Count; i++)
                        {
                            for (int j = 0; j < lstbCoatingThikness.SelectedItems.Count; j++)
                            {
                                objCoatingFilm.name = txtName.Text + "-" + ((clsThickness)lstbSubstrateThickness.SelectedItems[i]).value.ToString() + "-" +((clsThickness)lstbCoatingThikness.SelectedItems[j]).value.ToString();
                                objCoatingFilm.code = generateCode(((clsThickness)lstbSubstrateThickness.SelectedItems[i]).value.ToString(), ((clsThickness)lstbCoatingThikness.SelectedItems[j]).value.ToString());
                                objCoatingFilm.Process = ((clsProcess)cmbProcess.SelectedItem);
                                objCoatingFilm.fkProcess = objCoatingFilm.Process.codsec;
                                objCoatingFilm.SubProcess = ((clsProcess)cmbSubProcess.SelectedItem);
                                objCoatingFilm.fkSubProcess = objCoatingFilm.SubProcess.codsec;
                                objCoatingFilm.TerminationStructure = ((clsStructure)cmbTerminationStructure.SelectedItem);
                                objCoatingFilm.fkTerminationStructure = objCoatingFilm.TerminationStructure.codsec;
                                objCoatingFilm.CoatingStructure = ((clsStructure)cmbCoatingStructure.SelectedItem);
                                objCoatingFilm.fkCoatingStructure = objCoatingFilm.CoatingStructure.codsec;
                                objCoatingFilm.SubstrateThickness = ((clsThickness)lstbSubstrateThickness.SelectedItems[i]);
                                objCoatingFilm.fkSubstrateThickness = objCoatingFilm.SubstrateThickness.codsec;
                                objCoatingFilm.CoatThickness = ((clsThickness)lstbCoatingThikness.SelectedItems[j]);
                                objCoatingFilm.fkCoatThickness = objCoatingFilm.CoatThickness.codsec;
                                objCoatingFilm.Treatment = ((clsTreatment)cmbTreatment.SelectedItem);
                                objCoatingFilm.fkTreatment = objCoatingFilm.Treatment.codsec;

                                if (!objCoatingFilm.save())
                                    flgSave = false;
                            }
                        }
                        if (flgSave == true)
                        {
                            MessageBox.Show("Las películas Coating se ha guardado con éxito.", "Coating Film", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                            clearForm();
                        }

                        else
                            MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Coating Film", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Bopp Film", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            frmCoatingFilmList winCoatingFilmList = new frmCoatingFilmList();
            winCoatingFilmList.MdiParent = this.MdiParent;
            winCoatingFilmList.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (objCoatingFilm.codsec != 0)
            {
                frmCoatingFilmList winCoatingFilmList = new frmCoatingFilmList();
                winCoatingFilmList.MdiParent = this.MdiParent;
                winCoatingFilmList.Show();
                this.Close();
            }
            else
                this.Close();
        }

        private void cmbProcess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsProcess> lstProcess = clsProcess.getList();
                cmbProcess.Items.Clear();
                for (int i = 0; i < lstProcess.Count; i++)
                    cmbProcess.Items.Add(lstProcess[i]);
            }
        }

        private void cmbSubProcess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsProcess> lstProcess = clsProcess.getList();
                cmbSubProcess.Items.Clear();
                for (int i = 0; i < lstProcess.Count; i++)
                    cmbSubProcess.Items.Add(lstProcess[i]);
            }
        }

        private void cmbTerminationStructure_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsStructure> lstStructure = clsStructure.getList();
                cmbTerminationStructure.Items.Clear();
                for (int i = 0; i < lstStructure.Count; i++)
                    cmbTerminationStructure.Items.Add(lstStructure[i]);
            }
        }

        private void cmbCoatingStructure_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsStructure> lstStructure = clsStructure.getList();
                cmbTerminationStructure.Items.Clear();
                for (int i = 0; i < lstStructure.Count; i++)
                    cmbTerminationStructure.Items.Add(lstStructure[i]);
            }
        }

        private void cmbTreatment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsTreatment> lstTreatment = clsTreatment.getList();
                cmbTreatment.Items.Clear();
                for (int i = 0; i < lstTreatment.Count; i++)
                    cmbTreatment.Items.Add(lstTreatment[i]);
            }
        }
    }
}