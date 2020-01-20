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
    public partial class frmBoppFilmForm : Form
    {
        clsBopp objBoppFilm = new clsBopp();

        public frmBoppFilmForm()
        {
            InitializeComponent();
        }

        public frmBoppFilmForm(int codsec)
        {
            objBoppFilm.load(codsec);
            InitializeComponent();
            this.rdoMoreThickness.Enabled = false;
        }
        public void generateCode()
        {
            string code = "";

            code += (cmbFamily.SelectedIndex >= 0) ? ((((clsFamily)cmbFamily.SelectedItem).abbreviation != "") ? ((clsFamily)cmbFamily.SelectedItem).abbreviation : "") : "";
            code += (cmbSubFamily.SelectedIndex >= 0) ? ((((clsFamily)cmbSubFamily.SelectedItem).abbreviation != "") ? ((clsFamily)cmbSubFamily.SelectedItem).abbreviation : "") : "";
            code += (cmbInnerSeal.SelectedIndex >= 0) ? ((((clsSeal)cmbInnerSeal.SelectedItem).abbreviation != "") ? ((clsSeal)cmbInnerSeal.SelectedItem).abbreviation : "") : "";
            code += (cmbOuterSeal.SelectedIndex >= 0) ? ((((clsSeal)cmbOuterSeal.SelectedItem).abbreviation != "") ? ((clsSeal)cmbOuterSeal.SelectedItem).abbreviation : "") : "";
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

            code += (cmbFamily.SelectedIndex >= 0) ? ((((clsFamily)cmbFamily.SelectedItem).abbreviation != "") ? ((clsFamily)cmbFamily.SelectedItem).abbreviation : "") : "";
            code += (cmbSubFamily.SelectedIndex >= 0) ? ((((clsFamily)cmbSubFamily.SelectedItem).abbreviation != "") ? ((clsFamily)cmbSubFamily.SelectedItem).abbreviation : "") : "";
            code += (cmbInnerSeal.SelectedIndex >= 0) ? ((((clsSeal)cmbInnerSeal.SelectedItem).abbreviation != "") ? ((clsSeal)cmbInnerSeal.SelectedItem).abbreviation : "") : "";
            code += (cmbOuterSeal.SelectedIndex >= 0) ? ((((clsSeal)cmbOuterSeal.SelectedItem).abbreviation != "") ? ((clsSeal)cmbOuterSeal.SelectedItem).abbreviation : "") : "";
            code += (cmbCentralAdditivation.SelectedIndex >= 0) ? ((((clsAdditivation)cmbCentralAdditivation.SelectedItem).abbreviation != "") ? ((clsAdditivation)cmbCentralAdditivation.SelectedItem).abbreviation : "") : "";
            code += (cmbSurfaceAdditivation.SelectedIndex >= 0) ? ((((clsAdditivation)cmbSurfaceAdditivation.SelectedItem).abbreviation != "") ? ((clsAdditivation)cmbSurfaceAdditivation.SelectedItem).abbreviation : "") : "";

            code += clsGlobal.FillWithZeros(thickness, 3);
            
            code += (cmbTreatment.SelectedIndex >= 0) ? ((((clsTreatment)cmbTreatment.SelectedItem).abbreviation != "") ? ((clsTreatment)cmbTreatment.SelectedItem).abbreviation : "") : "";

            return code;
        }
        public bool validateForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtName, ref lblName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtweigthpercentimeter, ref lblweigthpercentimeter, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtCode, ref lblCode, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbFamily, ref lblFamily, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbSubFamily, ref lblSubFamily, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbInnerSeal, ref lblInnerSeal, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbOuterSeal, ref lblOuterSeal, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbCentralAdditivation, ref lblCentralAdditivation, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbSurfaceAdditivation, ref lblSurfaceAdditivation, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbTreatment, ref lblTreatment, "selected")) isValid = false;
            
            return isValid;
        }
        public void clearForm()
        {
            objBoppFilm = new clsBopp();
            cmbFamily.SelectedIndex = -1;
            cmbSubFamily.SelectedIndex = -1;
            cmbInnerSeal.SelectedIndex = -1;
            cmbOuterSeal.SelectedIndex = -1;
            cmbCentralAdditivation.SelectedIndex = -1;
            cmbSurfaceAdditivation.SelectedIndex = -1;
            cmbTreatment.SelectedIndex = -1;

            rdoOneThickness.Checked = true;
            lstbThickness.SelectedIndex = -1;
            txtweigthpercentimeter.Clear();
            txtName.Text = "";
            txtCode.Text = "";
            txtName.Focus();

        }
        private void frmBoppFilmForm_Load(object sender, EventArgs e)
        {
            List<clsFamily> lstFamily = new List<clsFamily>();
            List<clsSeal> lstSeal = new List<clsSeal>();
            List<clsAdditivation> lstAdditivation = new List<clsAdditivation>();
            List<clsThickness> lstThickness = new List<clsThickness>();
            List<clsTreatment> lstTreatment = new List<clsTreatment>();
                        
            lstFamily = clsFamily.getList();
            lstSeal = clsSeal.getList();
            lstAdditivation = clsAdditivation.getListAdditivationForBopp();
            lstThickness = clsThickness.getList();
            lstTreatment = clsTreatment.getListForBopp();

            txtName.Text = "";
            txtCode.Text = "";
            chkIsBaseFilm.Checked = false;

            
            cmbFamily.Items.Clear();
            cmbSubFamily.Items.Clear();

            for (int i = 0; i < lstFamily.Count; i++)
            {
                cmbFamily.Items.Add(lstFamily[i]);
                cmbSubFamily.Items.Add(lstFamily[i]);
            }

            cmbInnerSeal.Items.Clear();
            cmbOuterSeal.Items.Clear();
            for (int i = 0; i < lstSeal.Count; i++)
            {
                cmbInnerSeal.Items.Add(lstSeal[i]);
                cmbOuterSeal.Items.Add(lstSeal[i]);
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
                cmbTreatment.Items.Add(lstTreatment[i]);

            lstbThickness.Items.Clear();
            for (int i = 0; i < lstThickness.Count; i++)
                lstbThickness.Items.Add(lstThickness[i]);

            if (objBoppFilm.codsec != 0)
            {
                txtName.Text = objBoppFilm.name;
                txtCode.Text = objBoppFilm.code;
                
                //Family
                lblFamilyCode.Text = objBoppFilm.Family.abbreviation;
                for (int i = 0; i < cmbFamily.Items.Count; i++)
                {
                    if (((clsFamily)cmbFamily.Items[i]).codsec == objBoppFilm.Family.codsec)
                        cmbFamily.SelectedIndex = i;
                }

                //Subfamily
                lblSubFamilyCode.Text = objBoppFilm.SubFamily.abbreviation;
                for (int i = 0; i < cmbSubFamily.Items.Count; i++)
                {
                    if (((clsFamily)cmbSubFamily.Items[i]).codsec == objBoppFilm.SubFamily.codsec)
                        cmbSubFamily.SelectedIndex = i;
                }

                //InnerSeal
                lblInnerSealCode.Text = objBoppFilm.InnerSeal.abbreviation;
                for (int i = 0; i < cmbInnerSeal.Items.Count; i++)
                {
                    if (((clsSeal)cmbInnerSeal.Items[i]).codsec == objBoppFilm.InnerSeal.codsec)
                        cmbInnerSeal.SelectedIndex = i;
                }

                //OuterSeal
                lblOuterSealCode.Text = objBoppFilm.OuterSeal.abbreviation;
                for (int i = 0; i < cmbOuterSeal.Items.Count; i++)
                {
                    if (((clsSeal)cmbOuterSeal.Items[i]).codsec == objBoppFilm.OuterSeal.codsec)
                        cmbOuterSeal.SelectedIndex = i;
                }

                //CentralAdditivation
                lblCentralAdditivationCode.Text = objBoppFilm.CentralAdditivation.abbreviation;
                for (int i = 0; i < cmbCentralAdditivation.Items.Count; i++)
                {
                    if (((clsAdditivation)cmbCentralAdditivation.Items[i]).codsec == objBoppFilm.CentralAdditivation.codsec)
                        cmbCentralAdditivation.SelectedIndex = i;
                }

                //SurfaceAdditivation
                lblSurfaceAdditivationCode.Text = objBoppFilm.SurfaceAdditivation.abbreviation;
                for (int i = 0; i < cmbSurfaceAdditivation.Items.Count; i++)
                {
                    if (((clsAdditivation)cmbSurfaceAdditivation.Items[i]).codsec == objBoppFilm.SurfaceAdditivation.codsec)
                        cmbSurfaceAdditivation.SelectedIndex = i;
                }

                //Thickness
                lblThicknessCode.Text = objBoppFilm.Thickness.value.ToString();
                for (int i = 0; i <lstbThickness.Items.Count; i++)
                {
                    if (((clsThickness)lstbThickness.Items[i]).codsec == objBoppFilm.Thickness.codsec)
                        lstbThickness.SelectedIndex = i;
                }

                //Treatment
                lblTreatmentCode.Text = objBoppFilm.Treatment.abbreviation;
                
                for (int i = 0; i < cmbTreatment.Items.Count; i++)
                {
                    if (((clsTreatment)cmbTreatment.Items[i]).codsec == objBoppFilm.Treatment.codsec)
                        cmbTreatment.SelectedIndex = i;
                }
            }
        }

        private void cmbFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFamily.SelectedIndex >= 0)
            {
                lblFamilyCode.Text = ((clsFamily)cmbFamily.SelectedItem).abbreviation;
                generateCode();
            }
            else
                lblFamilyCode.Text = "";
        }

        private void cmbSubFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSubFamily.SelectedIndex >= 0)
            {
                lblSubFamilyCode.Text = ((clsFamily)cmbSubFamily.SelectedItem).abbreviation;
                generateCode();
            }
            else
                lblSubFamilyCode.Text = "";
        }

        private void cmbInnerSeal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbInnerSeal.SelectedIndex >= 0)
            {
                lblInnerSealCode.Text = ((clsSeal)cmbInnerSeal.SelectedItem).abbreviation;
                generateCode();
            }
            else
                lblInnerSealCode.Text = "";
        }

        private void cmbOuterSeal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOuterSeal.SelectedIndex >= 0)
            {
                lblOuterSealCode.Text = ((clsSeal)cmbOuterSeal.SelectedItem).abbreviation;
                generateCode();
            }
            else
                lblOuterSealCode.Text = "";
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
                lblSurfaceAdditivationCode.Text = ((clsAdditivation)cmbSurfaceAdditivation.SelectedItem).abbreviation;
                generateCode();
            }
            else
                lblSurfaceAdditivationCode.Text = "";
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (objBoppFilm.codsec != 0)
            {
                frmBoppFilmList winBoppFilmList = new frmBoppFilmList();
                winBoppFilmList.MdiParent = this.MdiParent;
                winBoppFilmList.Show();
                this.Close();
            }
            else
                this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateForm())
                {
                    if (rdoOneThickness.Checked == true)
                    {
                        objBoppFilm.name = txtName.Text;
                        objBoppFilm.code = txtCode.Text.Replace("-", "");
                        objBoppFilm.isBaseFilm = chkIsBaseFilm.Checked;
                        objBoppFilm.Family = ((clsFamily)cmbFamily.SelectedItem);
                        objBoppFilm.fkFamily = objBoppFilm.Family.codsec;
                        objBoppFilm.SubFamily = ((clsFamily)cmbSubFamily.SelectedItem);
                        objBoppFilm.fkSubFamily = objBoppFilm.SubFamily.codsec;
                        objBoppFilm.InnerSeal = ((clsSeal)cmbInnerSeal.SelectedItem);
                        objBoppFilm.fkInnerSeal = objBoppFilm.InnerSeal.codsec;
                        objBoppFilm.OuterSeal = ((clsSeal)cmbOuterSeal.SelectedItem);
                        objBoppFilm.fkOuterSeal = objBoppFilm.OuterSeal.codsec;
                        objBoppFilm.CentralAdditivation = ((clsAdditivation)cmbCentralAdditivation.SelectedItem);
                        objBoppFilm.fkCentralAdditivation = objBoppFilm.CentralAdditivation.codsec;
                        objBoppFilm.SurfaceAdditivation = ((clsAdditivation)cmbSurfaceAdditivation.SelectedItem);
                        objBoppFilm.fkSurfaceAdditivation = objBoppFilm.SurfaceAdditivation.codsec;
                        objBoppFilm.Thickness = ((clsThickness)lstbThickness.SelectedItem);
                        objBoppFilm.fkThickness = objBoppFilm.Thickness.codsec;
                        objBoppFilm.Treatment = ((clsTreatment)cmbTreatment.SelectedItem);
                        objBoppFilm.fkTreatment = objBoppFilm.Treatment.codsec;

                        if (objBoppFilm.save())
                        {
                            if (WeigthPerCentimeter(true,clsBopp.getLastSavedCodsec()))
                            {
                                MessageBox.Show("La película BOPP se ha guardado con éxito.", "Bopp Film", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                clearForm();
                            }
                            else
                                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Bopp Film", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        }
                        else
                            MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Bopp Film", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }
                    else
                    {
                        bool flgSave = true;

                        for (int i = 0; i < lstbThickness.SelectedItems.Count; i++)
                        {
                            objBoppFilm.name = txtName.Text + "-" + ((clsThickness)lstbThickness.SelectedItems[i]).value.ToString();
                            objBoppFilm.code = generateCode(((clsThickness)lstbThickness.SelectedItems[i]).value.ToString()).Replace("-", "");
                            objBoppFilm.isBaseFilm = chkIsBaseFilm.Checked;
                            objBoppFilm.Family = ((clsFamily)cmbFamily.SelectedItem);
                            objBoppFilm.fkFamily = objBoppFilm.Family.codsec;
                            objBoppFilm.SubFamily = ((clsFamily)cmbSubFamily.SelectedItem);
                            objBoppFilm.fkSubFamily = objBoppFilm.SubFamily.codsec;
                            objBoppFilm.InnerSeal = ((clsSeal)cmbInnerSeal.SelectedItem);
                            objBoppFilm.fkInnerSeal = objBoppFilm.InnerSeal.codsec;
                            objBoppFilm.OuterSeal = ((clsSeal)cmbOuterSeal.SelectedItem);
                            objBoppFilm.fkOuterSeal = objBoppFilm.OuterSeal.codsec;
                            objBoppFilm.CentralAdditivation = ((clsAdditivation)cmbCentralAdditivation.SelectedItem);
                            objBoppFilm.fkCentralAdditivation = objBoppFilm.CentralAdditivation.codsec;
                            objBoppFilm.SurfaceAdditivation = ((clsAdditivation)cmbSurfaceAdditivation.SelectedItem);
                            objBoppFilm.fkSurfaceAdditivation = objBoppFilm.SurfaceAdditivation.codsec;
                            objBoppFilm.Thickness = ((clsThickness)lstbThickness.SelectedItems[i]);
                            objBoppFilm.fkThickness = objBoppFilm.Thickness.codsec;
                            objBoppFilm.Treatment = ((clsTreatment)cmbTreatment.SelectedItem);
                            objBoppFilm.fkTreatment = objBoppFilm.Treatment.codsec;
                            if (!objBoppFilm.save())
                            {
                                flgSave = false;
                                break;
                            }
                            else
                            {
                                if (!WeigthPerCentimeter(false, clsBopp.getLastSavedCodsec()))
                                {
                                    flgSave = false;
                                    break;
                                }
                            }
                        }
                        if (flgSave == true)
                        {
                            MessageBox.Show("La película BOPP se ha guardado con éxito.", "Bopp Film", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                            clearForm();
                        }
                        else
                            MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Bopp Film", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
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

        private bool WeigthPerCentimeter(bool Thickness, int Bopp)
        {
            bool flgValidate = true;
            if (Thickness)
            {
                clsParameters ObjParameters = new clsParameters();
                List<clsCore> lstCore = new List<clsCore>();
                List<clsDiameter> lstDiameter = new List<clsDiameter>();
                lstCore = clsCore.getList();
                lstDiameter = clsDiameter.getList();
                for (int i = 0; i < lstDiameter.Count; i++)
                {
                    for (int j = 0; j < lstCore.Count; j++)
                    {
                        ObjParameters.fkBopp = Bopp;
                        ObjParameters.fkDiameter = lstDiameter[i].codsec;
                        ObjParameters.fkCore = lstCore[j].codsec;
                        ObjParameters.weightFactor = Convert.ToDouble(txtweigthpercentimeter.Text);
                        ObjParameters.aproxLength = 1024;
                        if (!ObjParameters.save())
                        {
                            flgValidate = false;
                            break;
                        }
                    }
                }
            }
            else
            {
                clsParameters ObjParameters = new clsParameters();
                List<clsCore> lstCore = new List<clsCore>();
                List<clsDiameter> lstDiameter = new List<clsDiameter>();
                lstCore = clsCore.getList();
                lstDiameter = clsDiameter.getList();
                for (int i = 0; i < lstDiameter.Count; i++)
                {
                    for (int j = 0; j < lstCore.Count; j++)
                    {
                        ObjParameters.fkBopp = Bopp;
                        ObjParameters.fkDiameter = lstDiameter[i].codsec;
                        ObjParameters.fkCore = lstCore[j].codsec;
                        ObjParameters.weightFactor = Convert.ToDouble(txtweigthpercentimeter.Text);
                        ObjParameters.aproxLength = 1024;
                        if (!ObjParameters.save())
                        {
                            flgValidate = false;
                            break;
                        }
                    }
                }
            }
            return flgValidate;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            frmBoppFilmList winBoppFilmList = new frmBoppFilmList();
            winBoppFilmList.MdiParent = this.MdiParent;
            winBoppFilmList.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void cmbFamily_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsFamily> lstFamily = clsFamily.getList();
                cmbFamily.Items.Clear();
                for (int i = 0; i < lstFamily.Count; i++)
                    cmbFamily.Items.Add(lstFamily[i]);
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsFamily> lstFamily = clsFamily.getList();
                List<clsSeal> lstSeal = clsSeal.getList();
                List<clsAdditivation> lstAdditivation = clsAdditivation.getList();
                List<clsTreatment> lstTreatment = clsTreatment.getList();

                cmbFamily.Items.Clear();
                cmbSubFamily.Items.Clear();
                cmbInnerSeal.Items.Clear();
                cmbOuterSeal.Items.Clear();
                cmbCentralAdditivation.Items.Clear();
                cmbSurfaceAdditivation.Items.Clear();
                cmbTreatment.Items.Clear();

                for (int i = 0; i < lstFamily.Count; i++)
                {
                    cmbFamily.Items.Add(lstFamily[i]);
                    cmbSubFamily.Items.Add(lstFamily[i]);
                }

                for (int i = 0; i < lstSeal.Count; i++)
                {
                    cmbInnerSeal.Items.Add(lstSeal[i]);
                    cmbOuterSeal.Items.Add(lstSeal[i]);
                }


                for (int i = 0; i < lstAdditivation.Count; i++)
                {
                    cmbCentralAdditivation.Items.Add(lstAdditivation[i]);
                    cmbSurfaceAdditivation.Items.Add(lstAdditivation[i]);
                }

                for (int i = 0; i < lstTreatment.Count; i++)
                    cmbTreatment.Items.Add(lstTreatment[i]);
            }
        }

        private void cmbSubFamily_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsFamily> lstSubFamily = clsFamily.getList();
                cmbSubFamily.Items.Clear();
                for (int i = 0; i < lstSubFamily.Count; i++)
                    cmbSubFamily.Items.Add(lstSubFamily[i]); 
            }
        }

        private void cmbInnerSeal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsSeal> lstSeal = clsSeal.getList();
                cmbInnerSeal.Items.Clear();
                for (int i = 0; i < lstSeal.Count; i++)
                    cmbInnerSeal.Items.Add(lstSeal[i]);
            }
        }

        private void cmbOuterSeal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsSeal> lstSeal = clsSeal.getList();
                cmbOuterSeal.Items.Clear();
                for (int i = 0; i < lstSeal.Count; i++)
                    cmbOuterSeal.Items.Add(lstSeal[i]);
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