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
    public partial class frmNylonFilmForm : Form
    {
        clsCast objCastFilm = new clsCast();
        public frmNylonFilmForm()
        {
            InitializeComponent();
        }
        public frmNylonFilmForm(int codsec)
        {
            objCastFilm.load(codsec);
            InitializeComponent();
        }
        public bool validateForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtName, ref lblName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtCode, ref lblCode, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbProcess, ref lblProcess, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbSubProcess, ref lblSubProcess, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbCentralStructure, ref lblCentralStructure, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbSurfaceStructure, ref lblSurfaceStructure, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbCentralAdditivation, ref lblCentralAdditivation, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbSurfaceAdditivation, ref lblSurfaceAdditivation, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbTreatment, ref lblTreatment, "selected")) isValid = false;

            return isValid;
        }
        public void generateCode()
        {
            string code = "";

            code += (cmbProcess.SelectedIndex >= 0) ? ((((clsProcess)cmbProcess.SelectedItem).abbreviation != "") ? ((clsProcess)cmbProcess.SelectedItem).abbreviation : "") : "";
            code += (cmbSubProcess.SelectedIndex >= 0) ? ((((clsProcess)cmbSubProcess.SelectedItem).abbreviation != "") ? ((clsProcess)cmbSubProcess.SelectedItem).abbreviation : "") : "";
            code += (cmbCentralStructure.SelectedIndex >= 0) ? ((((clsStructure)cmbCentralStructure.SelectedItem).abbreviation != "") ? ((clsStructure)cmbCentralStructure.SelectedItem).abbreviation : "") : "";
            code += (cmbSurfaceStructure.SelectedIndex >= 0) ? ((((clsStructure)cmbSurfaceStructure.SelectedItem).abbreviation != "") ? ((clsStructure)cmbSurfaceStructure.SelectedItem).abbreviation : "") : "";
            code += (cmbCentralAdditivation.SelectedIndex >= 0) ? ((((clsAdditivation)cmbCentralAdditivation.SelectedItem).abbreviation != "") ? ((clsAdditivation)cmbCentralAdditivation.SelectedItem).abbreviation : "") : "";
            code += (cmbSurfaceAdditivation.SelectedIndex >= 0) ? ((((clsAdditivation)cmbSurfaceAdditivation.SelectedItem).abbreviation != "") ? ((clsAdditivation)cmbSurfaceAdditivation.SelectedItem).abbreviation : "") : "";
            if (rdoOneThickness.Checked == true)
                code += (lstbThickness.SelectedIndex >= 0) ? clsGlobal.FillWithZeros(((clsThickness)lstbThickness.SelectedItem).value.ToString(),3) : "---" ;
            else
                code += "---";
            code += (cmbTreatment.SelectedIndex >= 0) ? ((((clsTreatment)cmbTreatment.SelectedItem).abbreviation != "") ? ((clsTreatment)cmbTreatment.SelectedItem).abbreviation : "") : "";

            txtCode.Text = code;
        }
        public string generateCode(string thickness)
        {
            string code = "";

            code += (cmbProcess.SelectedIndex >= 0) ? ((((clsProcess)cmbProcess.SelectedItem).abbreviation != "") ? ((clsProcess)cmbProcess.SelectedItem).abbreviation : "") : "";
            code += (cmbSubProcess.SelectedIndex >= 0) ? ((((clsProcess)cmbSubProcess.SelectedItem).abbreviation != "") ? ((clsProcess)cmbSubProcess.SelectedItem).abbreviation : "") : "";
            code += (cmbCentralStructure.SelectedIndex >= 0) ? ((((clsStructure)cmbCentralStructure.SelectedItem).abbreviation != "") ? ((clsStructure)cmbCentralStructure.SelectedItem).abbreviation : "") : "";
            code += (cmbSurfaceStructure.SelectedIndex >= 0) ? ((((clsStructure)cmbSurfaceStructure.SelectedItem).abbreviation != "") ? ((clsStructure)cmbSurfaceStructure.SelectedItem).abbreviation : "") : "";
            code += (cmbCentralAdditivation.SelectedIndex >= 0) ? ((((clsAdditivation)cmbCentralAdditivation.SelectedItem).abbreviation != "") ? ((clsAdditivation)cmbCentralAdditivation.SelectedItem).abbreviation : "") : "";
            code += (cmbSurfaceAdditivation.SelectedIndex >= 0) ? ((((clsAdditivation)cmbSurfaceAdditivation.SelectedItem).abbreviation != "") ? ((clsAdditivation)cmbSurfaceAdditivation.SelectedItem).abbreviation : "") : "";

            code += clsGlobal.FillWithZeros(thickness, 3);
            
            code += (cmbTreatment.SelectedIndex >= 0) ? ((((clsTreatment)cmbTreatment.SelectedItem).abbreviation != "") ? ((clsTreatment)cmbTreatment.SelectedItem).abbreviation : "") : "";

            return code;
        }
        public void clearForm()
        {
            objCastFilm = new clsCast();
            cmbProcess.SelectedIndex = -1;
            cmbSubProcess.SelectedIndex = -1;
            cmbCentralStructure.SelectedIndex = -1;
            cmbSurfaceStructure.SelectedIndex = -1;
            cmbCentralAdditivation.SelectedIndex = -1;
            cmbSurfaceAdditivation.SelectedIndex = -1;
            cmbTreatment.SelectedIndex = -1;

            rdoOneThickness.Checked = true;
            lstbThickness.SelectedIndex = -1;

            txtName.Text = "";
            txtCode.Text = "";
            txtName.Focus();
        }
        private void frmNylonFilmForm_Load(object sender, EventArgs e)
        {
            List<clsProcess> lstProcess = new List<clsProcess>();
            List<clsStructure> lstStructure = new List<clsStructure>();
            List<clsAdditivation> lstAdditivation = new List<clsAdditivation>();
            List<clsThickness> lstThickness = new List<clsThickness>();
            List<clsTreatment> lstTreatment = new List<clsTreatment>();

            lstProcess = clsProcess.getListProcessForCast();
            lstStructure = clsStructure.getListStructureForCast();
            lstAdditivation = clsAdditivation.getListAdditivationForCast();
            lstThickness = clsThickness.getList();
            lstTreatment = clsTreatment.getListForBopp();

            txtName.Text = "";
            txtCode.Text = "";

            cmbProcess.Items.Clear();
            cmbSubProcess.Items.Clear();
            for (int i = 0; i < lstProcess.Count; i++)
            {
                cmbProcess.Items.Add(lstProcess[i]);
                cmbSubProcess.Items.Add(lstProcess[i]);
            }

            cmbCentralStructure.Items.Clear();
            cmbSurfaceStructure.Items.Clear();
            for (int i = 0; i < lstStructure.Count; i++)
			{
                cmbSurfaceStructure.Items.Add(lstStructure[i]);
                cmbCentralStructure.Items.Add(lstStructure[i]);
			}

            cmbCentralAdditivation.Items.Clear();
            cmbSurfaceAdditivation.Items.Clear();
            for (int i = 0; i < lstAdditivation.Count; i++)
            {
                cmbCentralAdditivation.Items.Add(lstAdditivation[i]);
                cmbSurfaceAdditivation.Items.Add(lstAdditivation[i]);
            }

            cmbTreatment.Items.Clear();
            for (int i = 0; i < lstTreatment.Count; i++)
            {
                cmbTreatment.Items.Add(lstTreatment[i]);
            }

            lstbThickness.Items.Clear();
            for (int i = 0; i < lstThickness.Count; i++)
            {
                lstbThickness.Items.Add(lstThickness[i]);
            }

            if (objCastFilm.codsec != 0)
            {
                txtName.Text = objCastFilm.name;
                txtCode.Text = objCastFilm.code;

                //Process
                lblProcessCode.Text = objCastFilm.Process.abbreviation;
                for (int i = 0; i < cmbProcess.Items.Count; i++)
                {
                    if (((clsProcess)cmbProcess.Items[i]).codsec == objCastFilm.Process.codsec)
                    {
                        cmbProcess.SelectedIndex = i;
                    }
                }

                //SubProcess
                lblSubProcessCode.Text = objCastFilm.SubProcess.abbreviation;
                for (int i = 0; i < cmbSubProcess.Items.Count; i++)
                {
                    if (((clsProcess)cmbSubProcess.Items[i]).codsec == objCastFilm.SubProcess.codsec)
                    {
                        cmbSubProcess.SelectedIndex = i;
                    }
                }

                //CentralStructure
                lblCentralStructureCode.Text = objCastFilm.CentralStructure.abbreviation;
                for (int i = 0; i < cmbCentralStructure.Items.Count; i++)
                {
                    if (((clsStructure)cmbCentralStructure.Items[i]).codsec == objCastFilm.CentralStructure.codsec)
                    {
                        cmbCentralStructure.SelectedIndex = i;
                    }
                }

                //SurfaceStructure
                lblSurfaceStructureCode.Text = objCastFilm.SurfaceStructure.abbreviation;
                for (int i = 0; i < cmbSurfaceStructure.Items.Count; i++)
                {
                    if (((clsStructure)cmbSurfaceStructure.Items[i]).codsec == objCastFilm.SurfaceStructure.codsec)
                    {
                        cmbSurfaceStructure.SelectedIndex = i;
                    }
                }

                //CentralAdditivation
                lblCentralAdditivationCode.Text = objCastFilm.CentralAdditivation.abbreviation;
                for (int i = 0; i < cmbCentralAdditivation.Items.Count; i++)
                {
                    if (((clsAdditivation)cmbCentralAdditivation.Items[i]).codsec == objCastFilm.CentralAdditivation.codsec)
                    {
                        cmbCentralAdditivation.SelectedIndex = i;
                    }
                }

                //SurfaceAdditivation
                lblSurfaceAdditivavionCode.Text = objCastFilm.SurfaceAdditivation.abbreviation;
                for (int i = 0; i < cmbSurfaceAdditivation.Items.Count; i++)
                {
                    if (((clsAdditivation)cmbSurfaceAdditivation.Items[i]).codsec == objCastFilm.SurfaceAdditivation.codsec)
                    {
                        cmbSurfaceAdditivation.SelectedIndex = i;
                    }
                }

                //Thickness
                lblThicknessCode.Text = objCastFilm.Thickness.value.ToString();
                for (int i = 0; i < lstbThickness.Items.Count; i++)
                {
                    if (((clsThickness)lstbThickness.Items[i]).codsec == objCastFilm.Thickness.codsec)
                    {
                        lstbThickness.SelectedIndex = i;
                    }
                }

                //Treatment
                lblTreatmentCode.Text = objCastFilm.Treatment.abbreviation;

                for (int i = 0; i < cmbTreatment.Items.Count; i++)
                {
                    if (((clsTreatment)cmbTreatment.Items[i]).codsec == objCastFilm.Treatment.codsec)
                    {
                        cmbTreatment.SelectedIndex = i;
                    }
                }
            }
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

        private void cmbCentralStructure_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCentralStructure.SelectedIndex >= 0)
            {
                lblCentralStructureCode.Text = ((clsStructure)cmbCentralStructure.SelectedItem).abbreviation;
                generateCode();
            }
            else
                lblCentralStructureCode.Text = "";
        }

        private void cmbSurfaceStructure_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSurfaceStructure.SelectedIndex >= 0)
            {
                lblSurfaceStructureCode.Text = ((clsStructure)cmbSurfaceStructure.SelectedItem).abbreviation;
                generateCode();
            }
            else
                lblSurfaceStructureCode.Text = "";
        }

        private void cmbCentralAdditivation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCentralAdditivation.SelectedIndex >= 0)
            {
                lblCentralAdditivationCode.Text = ((clsAdditivation)cmbCentralAdditivation.SelectedItem).abbreviation;
                generateCode();
            }
            else
                lblCentralAdditivationCode.Text = "";
        }

        private void cmbSurfaceAdditivation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSurfaceAdditivation.SelectedIndex >= 0)
            {
                lblSurfaceAdditivavionCode.Text = ((clsAdditivation)cmbSurfaceAdditivation.SelectedItem).abbreviation;
                generateCode();
            }
            else
                lblSurfaceAdditivavionCode.Text = "";
        }

        private void rdoOneThickness_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoOneThickness.Checked == false)
            {
                lstbThickness.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
                if (lstbThickness.SelectedIndex >= 0)
                {
                    lblThicknessCode.Text = "---";
                    generateCode();
                }
                else
                    lblThicknessCode.Text = "";
            }
            else
            {
                lstbThickness.SelectedIndex = -1;
                lstbThickness.SelectionMode = System.Windows.Forms.SelectionMode.One;
                if (lstbThickness.SelectedItems.Count > 0)
                {
                    lblThicknessCode.Text = "";
                    generateCode();
                }
                else
                    lblThicknessCode.Text = "";
            }
        }

        private void lstbThickness_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdoOneThickness.Checked == true && lstbThickness.SelectedItem != null)
            {
                lblThicknessCode.Text = ((clsThickness)lstbThickness.SelectedItem).value.ToString();
                generateCode();
            }
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateForm())
                {
                    if (rdoOneThickness.Checked == true)
                    {
                        objCastFilm.name = txtName.Text;
                        objCastFilm.code = txtCode.Text.Replace("-", "");
                        objCastFilm.Process = ((clsProcess)cmbProcess.SelectedItem);
                        objCastFilm.fkProcess = objCastFilm.Process.codsec;
                        objCastFilm.SubProcess = ((clsProcess)cmbSubProcess.SelectedItem);
                        objCastFilm.fkSubProcess = objCastFilm.SubProcess.codsec;
                        objCastFilm.CentralStructure = ((clsStructure)cmbCentralStructure.SelectedItem);
                        objCastFilm.fkCentralStructure = objCastFilm.CentralStructure.codsec;
                        objCastFilm.SurfaceStructure = ((clsStructure)cmbSurfaceStructure.SelectedItem);
                        objCastFilm.fkSurfaceStructure = objCastFilm.SurfaceStructure.codsec;
                        objCastFilm.CentralAdditivation = ((clsAdditivation)cmbCentralAdditivation.SelectedItem);
                        objCastFilm.fkCentralAdditivation = objCastFilm.CentralAdditivation.codsec;
                        objCastFilm.SurfaceAdditivation = ((clsAdditivation)cmbSurfaceAdditivation.SelectedItem);
                        objCastFilm.fkSurfaceAdditivation = objCastFilm.SurfaceAdditivation.codsec;
                        objCastFilm.Thickness = ((clsThickness)lstbThickness.SelectedItem);
                        objCastFilm.fkThickness = objCastFilm.Thickness.codsec;
                        objCastFilm.Treatment = ((clsTreatment)cmbTreatment.SelectedItem);
                        objCastFilm.fkTreatment = objCastFilm.Treatment.codsec;
                        objCastFilm.isNylon = true;

                        if (objCastFilm.save())
                        {
                            MessageBox.Show("La película Cast se ha guardado con éxito.", "Cast Film", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                            clearForm();
                        }
                        else
                            MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Cast Film", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

                    }
                    else
                    {
                        bool flgSave = true;

                        for (int i = 0; i < lstbThickness.SelectedItems.Count; i++)
                        {
                            objCastFilm.name = txtName.Text + "-" + ((clsThickness)lstbThickness.SelectedItems[i]).value.ToString();
                            objCastFilm.code = generateCode(((clsThickness)lstbThickness.SelectedItems[i]).value.ToString());
                            objCastFilm.Process = ((clsProcess)cmbProcess.SelectedItem);
                            objCastFilm.fkProcess = objCastFilm.Process.codsec;
                            objCastFilm.SubProcess = ((clsProcess)cmbSubProcess.SelectedItem);
                            objCastFilm.fkSubProcess = objCastFilm.SubProcess.codsec;
                            objCastFilm.CentralStructure = ((clsStructure)cmbCentralStructure.SelectedItem);
                            objCastFilm.fkCentralStructure = objCastFilm.CentralStructure.codsec;
                            objCastFilm.SurfaceStructure = ((clsStructure)cmbSurfaceStructure.SelectedItem);
                            objCastFilm.fkSurfaceStructure = objCastFilm.SurfaceStructure.codsec;
                            objCastFilm.CentralAdditivation = ((clsAdditivation)cmbCentralAdditivation.SelectedItem);
                            objCastFilm.fkCentralAdditivation = objCastFilm.CentralAdditivation.codsec;
                            objCastFilm.SurfaceAdditivation = ((clsAdditivation)cmbSurfaceAdditivation.SelectedItem);
                            objCastFilm.fkSurfaceAdditivation = objCastFilm.SurfaceAdditivation.codsec;
                            objCastFilm.Thickness = ((clsThickness)lstbThickness.SelectedItems[i]);
                            objCastFilm.fkThickness = objCastFilm.Thickness.codsec;
                            objCastFilm.Treatment = ((clsTreatment)cmbTreatment.SelectedItem);
                            objCastFilm.fkTreatment = objCastFilm.Treatment.codsec;
                            objCastFilm.isNylon = true;

                            if (!objCastFilm.save())
                                flgSave = false;
                        }
                        if (flgSave == true)
                        {
                            MessageBox.Show("Las películas Cast se ha guardado con éxito.", "Cast Film", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                            clearForm();
                        }
                        else
                            MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Cast Film", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }
                }
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Cast Film", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            frmCastFilmList winCastFilmList = new frmCastFilmList();
            winCastFilmList.MdiParent = this.MdiParent;
            winCastFilmList.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

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

        private void cmbCentralStructure_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsStructure> lstStructure = clsStructure.getList();
                cmbCentralStructure.Items.Clear();
                for (int i = 0; i < lstStructure.Count; i++)
                    cmbCentralStructure.Items.Add(lstStructure[i]);
            }
        }

        private void cmbSurfaceStructure_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsStructure> lstStructure = clsStructure.getList();
                cmbSurfaceStructure.Items.Clear();
                for (int i = 0; i < lstStructure.Count; i++)
                    cmbSurfaceStructure.Items.Add(lstStructure[i]);
            }
        }

        private void cmbCentralAdditivation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsAdditivation> lstAdditivation = clsAdditivation.getList();
                cmbCentralAdditivation.Items.Clear();
                for (int i = 0; i < lstAdditivation.Count; i++)
                    cmbCentralAdditivation.Items.Add(lstAdditivation[i]);
            }
        }

        private void cmbSurfaceAdditivation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsAdditivation> lstAdditivation = clsAdditivation.getList();
                cmbSurfaceAdditivation.Items.Clear();
                for (int i = 0; i < lstAdditivation.Count; i++)
                    cmbSurfaceAdditivation.Items.Add(lstAdditivation[i]);
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