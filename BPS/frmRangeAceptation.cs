using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms; 
using System.IO;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmRangeAceptation : Form
    {
        string procedenceActivity = "Add";
        int codsec = 0;
        List<clsImportedRange> lstImportedRange = new List<clsImportedRange>();
        List<string[]> parsedData = new List<string[]>();
        List<clsAceptationRange> lstAceptationRange = new List<clsAceptationRange>();
        bool flgCanBeProcessed = false;
        clsAceptationRange ObjAceptationRange = new clsAceptationRange();

        public frmRangeAceptation()
        {
            InitializeComponent();
        }

        private void frmRangeAceptation_Load(object sender, EventArgs e)
        {
            PopulateFilmMain();
            PopulateMainRangeList();
        }

        private void PopulateFilmMain()
        {
            List<clsBopp> lstBopp = new List<clsBopp>();
            lstBopp = clsBopp.getListShort();
            cmbMainListFilm.Items.Clear();
            for (int i = 0; i < lstBopp.Count; i++)
                cmbMainListFilm.Items.Add(lstBopp[i]);
        }

        private void PopulateFilm()
        {
            List<clsBopp> lstBopp = new List<clsBopp>();
            lstBopp = clsBopp.getListShort();
            cmbFilm.Items.Clear();
            for (int i = 0; i < lstBopp.Count; i++)
                cmbFilm.Items.Add(lstBopp[i]);
        }

        private void PopulateMainRangeList()
        {
            List<clsAceptationRange> lstAceptactionRange = new List<clsAceptationRange>();
            lstAceptactionRange = clsAceptationRange.getList();
            dgvRangeMainList.Rows.Clear();
            if (lstAceptactionRange.Count > 0)
            {
                for (int i = 0; i < lstAceptactionRange.Count; i++)
                {
                    dgvRangeMainList.Rows.Add();
                    dgvRangeMainList.Rows[i].Cells[clmcodsec.Index].Value = lstAceptactionRange[i].codsec;
                    dgvRangeMainList.Rows[i].Cells[clmfilm.Index].Value = lstAceptactionRange[i].filmName;
                    dgvRangeMainList.Rows[i].Cells[clmthickness.Index].Value = "Max " + lstAceptactionRange[i].thiknessList[0] + " ; " + "Min " + lstAceptactionRange[i].thiknessList[1];
                    dgvRangeMainList.Rows[i].Cells[clmunitweight.Index].Value = "Max " + lstAceptactionRange[i].unitweightList[0] + " ; " + "Min " + lstAceptactionRange[i].unitweightList[1];
                    dgvRangeMainList.Rows[i].Cells[clmopacity.Index].Value = "Max " + lstAceptactionRange[i].opacityList[0] + " ; " + "Min " + lstAceptactionRange[i].opacityList[1];
                    dgvRangeMainList.Rows[i].Cells[clmsuperficialtension.Index].Value = "Max " + lstAceptactionRange[i].superficialtensionList[0] + " ; " + "Min " + lstAceptactionRange[i].superficialtensionList[1];
                    dgvRangeMainList.Rows[i].Cells[clmforcefacetrated.Index].Value = "Max " + lstAceptactionRange[i].sealctList[0] + " ; " + "Min " + lstAceptactionRange[i].sealctList[1];
                    dgvRangeMainList.Rows[i].Cells[clmforcesealfacetrated.Index].Value = "Max " + lstAceptactionRange[i].forcectList[0] + " ; " + "Min " + lstAceptactionRange[i].forcectList[1];
                    dgvRangeMainList.Rows[i].Cells[clmforcefacenottrated.Index].Value = "Max " + lstAceptactionRange[i].sealcntList[0] + " ; " + "Min " + lstAceptactionRange[i].sealcntList[1];
                    dgvRangeMainList.Rows[i].Cells[clmforcesealfacenottrated.Index].Value = "Max " + lstAceptactionRange[i].forcecntList[0] + " ; " + "Min " + lstAceptactionRange[i].forcecntList[1];
                    dgvRangeMainList.Rows[i].Cells[clmcoffacenottrated.Index].Value = "Max " + lstAceptactionRange[i].cofdymanicList[0] + " ; " + "Min " + lstAceptactionRange[i].cofdymanicList[1];
                    dgvRangeMainList.Rows[i].Cells[clmtransmitan.Index].Value = "Max " + lstAceptactionRange[i].tratedList[0] + " ; " + "Min " + lstAceptactionRange[i].tratedList[1];
                    dgvRangeMainList.Rows[i].Cells[clmtensionce.Index].Value = "Max " + lstAceptactionRange[i].tensionceList[0] + " ; " + "Min " + lstAceptactionRange[i].tensionceList[1];
                    dgvRangeMainList.Rows[i].Cells[clmbrightness.Index].Value = "Min " + lstAceptactionRange[i].brightness;
                    dgvRangeMainList.Rows[i].Cells[clmedit.Index].Value = global::BPS.Properties.Resources.pencil;
                    dgvRangeMainList.Rows[i].Cells[clmadd.Index].Value = global::BPS.Properties.Resources.add1;
                }
            }
        }

        private void cmbMainListFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMainListFilm.SelectedIndex > -1)
            {
                List<clsAceptationRange> lstAceptactionRange = new List<clsAceptationRange>();
                lstAceptactionRange = clsAceptationRange.getListByFilm(((clsBopp)cmbMainListFilm.SelectedItem).codsec);
                dgvRangeMainList.Rows.Clear();
                if (lstAceptactionRange.Count > 0)
                {
                    for (int i = 0; i < lstAceptactionRange.Count; i++)
                    {
                        dgvRangeMainList.Rows.Add();
                        dgvRangeMainList.Rows[i].Cells[clmcodsec.Index].Value = lstAceptactionRange[i].codsec;
                        dgvRangeMainList.Rows[i].Cells[clmfilm.Index].Value = lstAceptactionRange[i].filmName;
                        dgvRangeMainList.Rows[i].Cells[clmthickness.Index].Value = "Max " + lstAceptactionRange[i].thiknessList[0] + " ; " + "Min " + lstAceptactionRange[i].thiknessList[1];
                        dgvRangeMainList.Rows[i].Cells[clmunitweight.Index].Value = "Max " + lstAceptactionRange[i].unitweightList[0] + " ; " + "Min " + lstAceptactionRange[i].unitweightList[1];
                        dgvRangeMainList.Rows[i].Cells[clmopacity.Index].Value = "Max " + lstAceptactionRange[i].opacityList[0] + " ; " + "Min " + lstAceptactionRange[i].opacityList[1];
                        dgvRangeMainList.Rows[i].Cells[clmsuperficialtension.Index].Value = "Max " + lstAceptactionRange[i].superficialtensionList[0] + " ; " + "Min " + lstAceptactionRange[i].superficialtensionList[1];
                        dgvRangeMainList.Rows[i].Cells[clmforcefacetrated.Index].Value = "Max " + lstAceptactionRange[i].sealctList[0] + " ; " + "Min " + lstAceptactionRange[i].sealctList[1];
                        dgvRangeMainList.Rows[i].Cells[clmforcesealfacetrated.Index].Value = "Max " + lstAceptactionRange[i].forcectList[0] + " ; " + "Min " + lstAceptactionRange[i].forcectList[1];
                        dgvRangeMainList.Rows[i].Cells[clmforcefacenottrated.Index].Value = "Max " + lstAceptactionRange[i].sealcntList[0] + " ; " + "Min " + lstAceptactionRange[i].sealcntList[1];
                        dgvRangeMainList.Rows[i].Cells[clmforcesealfacenottrated.Index].Value = "Max " + lstAceptactionRange[i].forcecntList[0] + " ; " + "Min " + lstAceptactionRange[i].forcecntList[1];
                        dgvRangeMainList.Rows[i].Cells[clmcoffacenottrated.Index].Value = "Max " + lstAceptactionRange[i].cofdymanicList[0] + " ; " + "Min " + lstAceptactionRange[i].cofdymanicList[1];
                        dgvRangeMainList.Rows[i].Cells[clmtransmitan.Index].Value = "Max " + lstAceptactionRange[i].tratedList[0] + " ; " + "Min " + lstAceptactionRange[i].tratedList[1];
                        dgvRangeMainList.Rows[i].Cells[clmtensionce.Index].Value = "Max " + lstAceptactionRange[i].tensionceList[0] + " ; " + "Min " + lstAceptactionRange[i].tensionceList[1];
                        dgvRangeMainList.Rows[i].Cells[clmbrightness.Index].Value = "Min" + lstAceptactionRange[i].brightness;
                        dgvRangeMainList.Rows[i].Cells[clmedit.Index].Value = global::BPS.Properties.Resources.pencil;
                        dgvRangeMainList.Rows[i].Cells[clmadd.Index].Value = global::BPS.Properties.Resources.add1;
                    }
                }
                else
                {
                    MessageBox.Show("La película seleccionada no posee un rango de aceptación por favor seleccione otra película", "Rango de Aceptación", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    PopulateMainRangeList();
                    cmbMainListFilm.Focus();
                }
            }
        }

        private void dgvRangeMainList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmadd.Index)
            {
                tbcRange.SelectedIndex = 1;
                PopulateUnDataAceptactionRange("Add", 0);
            }
            if (e.ColumnIndex == clmedit.Index)
            {
                tbcRange.SelectedIndex = 1;
                PopulateUnDataAceptactionRange("Edit", Convert.ToInt32(dgvRangeMainList.Rows[e.RowIndex].Cells[clmcodsec.Index].Value));
                codsec = Convert.ToInt32(dgvRangeMainList.Rows[e.RowIndex].Cells[clmcodsec.Index].Value);
            }
        }

        private void PopulateUnDataAceptactionRange(string procedence, int codsec)
        {
            if (procedence == "Add")
            {
                TrashData();
                PopulateFilm();
                txtthicknessmax.Focus();
                procedenceActivity = "Add";
            }
            else if (procedence == "Edit")
            {
                PopulateRangeAceptationByCodsec(codsec);
                txtthicknessmax.Focus();
                procedenceActivity = "Edit";
            }
        }

        private void PopulateRangeAceptationByCodsec(int codsec)
        {
            ObjAceptationRange = new clsAceptationRange(codsec);
            txtthicknessmax.Text = ObjAceptationRange.thiknessList[0].ToString();
            txtthicknessmin.Text = ObjAceptationRange.thiknessList[1].ToString();
            txtunitweightmax.Text = ObjAceptationRange.unitweightList[0].ToString();
            txtunitweightmin.Text = ObjAceptationRange.unitweightList[1].ToString();
            txtopacitymax.Text = ObjAceptationRange.opacityList[0].ToString();
            txtopacitymin.Text = ObjAceptationRange.opacityList[1].ToString();
            txttensioncimax.Text = ObjAceptationRange.tensionciList[0].ToString();
            txttensioncimin.Text = ObjAceptationRange.tensionciList[1].ToString();
            txtsealctmax.Text = ObjAceptationRange.sealctList[0].ToString();
            txtsealctmin.Text = ObjAceptationRange.sealctList[1].ToString();
            txtsealcntmax.Text = ObjAceptationRange.sealcntList[0].ToString();
            txtsealcntmin.Text = ObjAceptationRange.sealcntList[1].ToString();
            txtsealforcectmax.Text = ObjAceptationRange.forcectList[0].ToString();
            txtsealforcectmin.Text = ObjAceptationRange.forcectList[1].ToString();
            txtsealforcecntmax.Text = ObjAceptationRange.forcecntList[0].ToString();
            txtsealforcecntmin.Text = ObjAceptationRange.forcecntList[1].ToString();
            txtcofmax.Text = ObjAceptationRange.cofdymanicList[0].ToString();
            txtcofmin.Text = ObjAceptationRange.cofdymanicList[1].ToString();
            txttrasmitamax.Text = ObjAceptationRange.tratedList[0].ToString();
            txttrasmitamin.Text = ObjAceptationRange.tratedList[1].ToString();
            txttensioncemax.Text = ObjAceptationRange.tensionceList[0].ToString();
            txttensioncemin.Text = ObjAceptationRange.tensionceList[1].ToString();
            txtbrightnessmin.Text = ObjAceptationRange.brightness.ToString();
            PopulateFilm();
            for (int i = 0; i < cmbFilm.Items.Count; i++)
            {
                if (((clsBopp)cmbFilm.Items[i]).codsec == ObjAceptationRange.fkBopp)
                    cmbFilm.SelectedIndex = i;
            }
        }

        private void TrashData()
        {
            txtthicknessmax.Text = "0";
            txtthicknessmin.Text = "0";
            txtunitweightmax.Text = "0";
            txtunitweightmin.Text = "0";
            txtopacitymax.Text = "0";
            txtopacitymin.Text = "0";
            txttensioncimax.Text = "0";
            txttensioncimin.Text = "0";
            txtsealctmax.Text = "0";
            txtsealctmin.Text = "0";
            txtsealcntmax.Text = "0";
            txtsealcntmin.Text = "0";
            txtsealforcectmax.Text = "0";
            txtsealforcectmin.Text = "0";
            txtsealforcecntmax.Text = "0";
            txtsealforcecntmin.Text = "0";
            txtcofmax.Text = "0";
            txtcofmin.Text = "0";
            txttrasmitamax.Text = "0";
            txttrasmitamin.Text = "0";
            txttensioncemax.Text = "0";
            txttensioncemin.Text = "0";
            txtbrightnessmin.Text = "0";
        }

        private void btnSaveAceptationRange_Click(object sender, EventArgs e)
        {
            if (procedenceActivity == "Add")
            {
                if (ValidateForm())
                {
                    if (clsAceptationRange.IsUniqueFilm((((clsBopp)cmbFilm.SelectedItem).codsec)))
                    {
                        setThiknessValues("toSave");
                        setUnitWeightValues("toSave");
                        setOpacityValues("toSave");
                        setTensionCIValues("toSave");
                        setSealCTValues("toSave");
                        setForceCTValues("toSave");
                        setSealCNTValues("toSave");
                        setForceCNTValues("toSave");
                        setCofValues("toSave");
                        setTransmitanValues("toSave");
                        setTensionCEValues("toSave");
                        setBrightnessValues("toSave");
                        ObjAceptationRange.fkBopp = (((clsBopp)cmbFilm.SelectedItem).codsec);
                        if (ObjAceptationRange.save())
                        {
                            MessageBox.Show("Datos guardados correctamente", "Rangos de Aceptación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            PopulateMainRangeList();
                            tbcRange.SelectedIndex = 0;
                            codsec = 0;
                        }
                        else
                            MessageBox.Show("Ha sucedido un error y la información no ha sido procesada correctamente!", "Rangos de Aceptación", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    }
                    else
                        MessageBox.Show("La película que seleccionó ya se encuentra registrada por favor cambie de película!", "Rangos de Aceptación", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                }
            }
            else if (procedenceActivity == "Edit")
            {
                setThiknessValues("toSave");
                setUnitWeightValues("toSave");
                setOpacityValues("toSave");
                setTensionCIValues("toSave");
                setSealCTValues("toSave");
                setForceCTValues("toSave");
                setSealCNTValues("toSave");
                setForceCNTValues("toSave");
                setCofValues("toSave");
                setTransmitanValues("toSave");
                setTensionCEValues("toSave");
                setBrightnessValues("toSave");
                ObjAceptationRange.fkBopp = (((clsBopp)cmbFilm.SelectedItem).codsec);
                if (ObjAceptationRange.save())
                {
                    MessageBox.Show("Datos guardados correctamente", "Rangos de Aceptación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopulateMainRangeList();
                    tbcRange.SelectedIndex = 0;
                    codsec = 0;
                }
                else
                    MessageBox.Show("Ha sucedido un error y la información no ha sido procesada correctamente!", "Rangos de Aceptación", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private bool ValidateForm()
        {
            bool isValid = true;
            if (!clsValidation.validateField(ref cmbFilm, ref lblFilmNewData, "selected")) isValid = false;
            return isValid;
        }

        private void setBrightnessValues(string destination)
        {
            switch (destination)
            {
                case "toSave":
                    ObjAceptationRange.brightness = Convert.ToInt32(txtbrightnessmin.Text);
                    break;
                
                default:
                    break;
            }
        }

        private void setThiknessValues(string destination)
        {
            switch (destination)
            {
                case "toSave":
                    ObjAceptationRange.thiknessValues = getValuesFromControl(grpbThickness, "textBox");
                    ObjAceptationRange.thiknessList = clsGlobal.getDoubleListFromString(ObjAceptationRange.thiknessValues);
                    break;
                //case "toLoadImported":
                //    txtFrictionCoefficientNTFAverage.Text = objMainCoilQuality.frictionCoefficientNTFAverage.ToString();
                //    txtFrictionCoefficientNTFAverage2.Text = objMainCoilQuality.frictionCoefficientNTFDinamicAverage.ToString();
                //    setValuesToControl(grpbFrictionCoefficientNTF, "textBox", objMainCoilQuality.frictionCoefficientNTFValues);
                //    break;
                default:
                    break;
            }
        }

        private void setUnitWeightValues(string destination)
        {
            switch (destination)
            {
                case "toSave":
                    ObjAceptationRange.unitweightValues = getValuesFromControl(grpbUnitWeight, "textBox");
                    ObjAceptationRange.unitweightList = clsGlobal.getDoubleListFromString(ObjAceptationRange.unitweightValues);
                    break;
                //case "toLoad":
                //    txtFrictionCoefficientNTFAverage.Text = objMainCoilQuality.frictionCoefficientNTFAverage.ToString();
                //    txtFrictionCoefficientNTFAverage2.Text = objMainCoilQuality.frictionCoefficientNTFDinamicAverage.ToString();
                //    setValuesToControl(grpbFrictionCoefficientNTF, "textBox", objMainCoilQuality.frictionCoefficientNTFValues);
                //    break;
                default:
                    break;
            }
        }

        private void setOpacityValues(string destination)
        {
            switch (destination)
            {
                case "toSave":
                    ObjAceptationRange.opacityValues = getValuesFromControl(grpbOpacity, "textBox");
                    ObjAceptationRange.opacityList = clsGlobal.getDoubleListFromString(ObjAceptationRange.opacityValues);
                    break;
                //case "toLoad":
                //    txtFrictionCoefficientNTFAverage.Text = objMainCoilQuality.frictionCoefficientNTFAverage.ToString();
                //    txtFrictionCoefficientNTFAverage2.Text = objMainCoilQuality.frictionCoefficientNTFDinamicAverage.ToString();
                //    setValuesToControl(grpbFrictionCoefficientNTF, "textBox", objMainCoilQuality.frictionCoefficientNTFValues);
                //    break;
                default:
                    break;
            }
        }

        private void setTensionCIValues(string destination)
        {
            switch (destination)
            {
                case "toSave":
                    ObjAceptationRange.tensionciValues = getValuesFromControl(grpbTesionCI, "textBox");
                    ObjAceptationRange.tensionciList = clsGlobal.getDoubleListFromString(ObjAceptationRange.tensionciValues);
                    break;
                //case "toLoad":
                //    txtFrictionCoefficientNTFAverage.Text = objMainCoilQuality.frictionCoefficientNTFAverage.ToString();
                //    txtFrictionCoefficientNTFAverage2.Text = objMainCoilQuality.frictionCoefficientNTFDinamicAverage.ToString();
                //    setValuesToControl(grpbFrictionCoefficientNTF, "textBox", objMainCoilQuality.frictionCoefficientNTFValues);
                //    break;
                default:
                    break;
            }
        }

        private void setSealCTValues(string destination)
        {
            switch (destination)
            {
                case "toSave":
                    ObjAceptationRange.sealctValues = getValuesFromControl(grpbSealCT, "textBox");
                    ObjAceptationRange.sealctList = clsGlobal.getIntListFromString(ObjAceptationRange.sealctValues);
                    break;
                //case "toLoad":
                //    txtFrictionCoefficientNTFAverage.Text = objMainCoilQuality.frictionCoefficientNTFAverage.ToString();
                //    txtFrictionCoefficientNTFAverage2.Text = objMainCoilQuality.frictionCoefficientNTFDinamicAverage.ToString();
                //    setValuesToControl(grpbFrictionCoefficientNTF, "textBox", objMainCoilQuality.frictionCoefficientNTFValues);
                //    break;
                default:
                    break;
            }
        }

        private void setForceCTValues(string destination)
        {
            switch (destination)
            {
                case "toSave":
                    ObjAceptationRange.forcectValues= getValuesFromControl(grpbSealForceCT, "textBox");
                    ObjAceptationRange.forcectList = clsGlobal.getDoubleListFromString(ObjAceptationRange.forcectValues);
                    break;
                //case "toLoad":
                //    txtFrictionCoefficientNTFAverage.Text = objMainCoilQuality.frictionCoefficientNTFAverage.ToString();
                //    txtFrictionCoefficientNTFAverage2.Text = objMainCoilQuality.frictionCoefficientNTFDinamicAverage.ToString();
                //    setValuesToControl(grpbFrictionCoefficientNTF, "textBox", objMainCoilQuality.frictionCoefficientNTFValues);
                //    break;
                default:
                    break;
            }
        }

        private void setSealCNTValues(string destination)
        {
            switch (destination)
            {
                case "toSave":
                    ObjAceptationRange.sealcntValues = getValuesFromControl(grpbSealCNT, "textBox");
                    ObjAceptationRange.sealcntList = clsGlobal.getIntListFromString(ObjAceptationRange.sealcntValues);
                    break;
                //case "toLoad":
                //    txtFrictionCoefficientNTFAverage.Text = objMainCoilQuality.frictionCoefficientNTFAverage.ToString();
                //    txtFrictionCoefficientNTFAverage2.Text = objMainCoilQuality.frictionCoefficientNTFDinamicAverage.ToString();
                //    setValuesToControl(grpbFrictionCoefficientNTF, "textBox", objMainCoilQuality.frictionCoefficientNTFValues);
                //    break;
                default:
                    break;
            }
        }

        private void setForceCNTValues(string destination)
        {
            switch (destination)
            {
                case "toSave":
                    ObjAceptationRange.forcecntValues = getValuesFromControl(grpbSealForceCNT, "textBox");
                    ObjAceptationRange.forcecntList = clsGlobal.getDoubleListFromString(ObjAceptationRange.forcecntValues);
                    break;
                //case "toLoad":
                //    txtFrictionCoefficientNTFAverage.Text = objMainCoilQuality.frictionCoefficientNTFAverage.ToString();
                //    txtFrictionCoefficientNTFAverage2.Text = objMainCoilQuality.frictionCoefficientNTFDinamicAverage.ToString();
                //    setValuesToControl(grpbFrictionCoefficientNTF, "textBox", objMainCoilQuality.frictionCoefficientNTFValues);
                //    break;
                default:
                    break;
            }
        }

        private void setCofValues(string destination)
        {
            switch (destination)
            {
                case "toSave":
                    ObjAceptationRange.cofdymanicValues = getValuesFromControl(grpbCof, "textBox");
                    ObjAceptationRange.cofdymanicList = clsGlobal.getDoubleListFromString(ObjAceptationRange.cofdymanicValues);
                    break;
                //case "toLoad":
                //    txtFrictionCoefficientNTFAverage.Text = objMainCoilQuality.frictionCoefficientNTFAverage.ToString();
                //    txtFrictionCoefficientNTFAverage2.Text = objMainCoilQuality.frictionCoefficientNTFDinamicAverage.ToString();
                //    setValuesToControl(grpbFrictionCoefficientNTF, "textBox", objMainCoilQuality.frictionCoefficientNTFValues);
                //    break;
                default:
                    break;
            }
        }

        private void setTransmitanValues(string destination)
        {
            switch (destination)
            {
                case "toSave":
                    ObjAceptationRange.tratedValues = getValuesFromControl(grpbTransmitan, "textBox");
                    ObjAceptationRange.tratedList = clsGlobal.getDoubleListFromString(ObjAceptationRange.tratedValues);
                    break;
                //case "toLoad":
                //    txtFrictionCoefficientNTFAverage.Text = objMainCoilQuality.frictionCoefficientNTFAverage.ToString();
                //    txtFrictionCoefficientNTFAverage2.Text = objMainCoilQuality.frictionCoefficientNTFDinamicAverage.ToString();
                //    setValuesToControl(grpbFrictionCoefficientNTF, "textBox", objMainCoilQuality.frictionCoefficientNTFValues);
                //    break;
                default:
                    break;
            }
        }

        private void setTensionCEValues(string destination)
        {
            switch (destination)
            {
                case "toSave":
                    ObjAceptationRange.tensionceValues = getValuesFromControl(grpbTesionCE, "textBox");
                    ObjAceptationRange.tensionceList = clsGlobal.getDoubleListFromString(ObjAceptationRange.tensionceValues);
                    break;
                //case "toLoadImported":
                //    txtFrictionCoefficientNTFAverage.Text = objMainCoilQuality.frictionCoefficientNTFAverage.ToString();
                //    txtFrictionCoefficientNTFAverage2.Text = objMainCoilQuality.frictionCoefficientNTFDinamicAverage.ToString();
                //    setValuesToControl(grpbFrictionCoefficientNTF, "textBox", objMainCoilQuality.frictionCoefficientNTFValues);
                //    break;
                default:
                    break;
            }
        }

        private string getValuesFromControl(System.Windows.Forms.Control container, string controlType)
        {
            string result = "";
            switch (controlType)
            {
                case "textBox":

                    List<System.Windows.Forms.TextBox> lstTextBox = new List<TextBox>();
                    foreach (System.Windows.Forms.Control ctrl in container.Controls)
                    {
                        if (object.ReferenceEquals(ctrl.GetType(), typeof(System.Windows.Forms.TextBox)))
                            lstTextBox.Add(((TextBox)ctrl));
                    }
                    lstTextBox.Sort(delegate(TextBox txt1, TextBox txt2) { return txt1.TabIndex.CompareTo(txt2.TabIndex); });
                    for (int i = 0; i < lstTextBox.Count; i++)
                        result += lstTextBox[i].Text + ((i < lstTextBox.Count - 1) ? ";" : "");
                    break;

                case "checkBox":

                    List<System.Windows.Forms.CheckBox> lstCheckBox = new List<CheckBox>();
                    foreach (System.Windows.Forms.Control ctrl in container.Controls)
                    {
                        if (object.ReferenceEquals(ctrl.GetType(), typeof(System.Windows.Forms.CheckBox)))
                            lstCheckBox.Add(((CheckBox)ctrl));
                    }
                    lstCheckBox.Sort(delegate(CheckBox chk1, CheckBox chk2) { return chk1.TabIndex.CompareTo(chk2.TabIndex); });
                    for (int i = 0; i < lstCheckBox.Count; i++)
                        result += lstCheckBox[i].Checked.ToString() + ((i < lstCheckBox.Count - 1) ? ";" : "");
                    break;

                default:
                    break;
            }
            return result;
        }

        private string getValuesFromCVS(string max, string min)
        {
            string result = "";
            result += max + ";" + min;
            return result;
        }

        private void tbcRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcRange.SelectedIndex == 1 && codsec == 0)
                PopulateUnDataAceptactionRange("Add", 0);
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            opfImport.ShowDialog();
            txtFileName.Text = opfImport.FileName;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            importFromFile();
        }

        public void importFromFile()
        {
            parseCSV(txtFileName.Text);

            for (int i = 0; i < parsedData.Count; i++)
            {
                if (parsedData[i][0] != "")
                {
                    if (parsedData[i][0] == "Pelicula" || parsedData[i][0] == "Película")
                    {
                       
                    }
                    else
                    {

                        lstImportedRange.Add(new clsImportedRange());

                        lstImportedRange[lstImportedRange.Count - 1].filmName = parsedData[i][0];
                        lstImportedRange[lstImportedRange.Count - 1].thiknessValues = getValuesFromCVS(parsedData[i][1], parsedData[i][2]);
                        lstImportedRange[lstImportedRange.Count - 1].unitweightValues = getValuesFromCVS(parsedData[i][3], parsedData[i][4]);
                        lstImportedRange[lstImportedRange.Count - 1].opacityValues = getValuesFromCVS(parsedData[i][5], parsedData[i][6]);
                        lstImportedRange[lstImportedRange.Count - 1].tensionciValues = getValuesFromCVS(parsedData[i][7], parsedData[i][8]);
                        lstImportedRange[lstImportedRange.Count - 1].sealctValues = getValuesFromCVS(parsedData[i][9], parsedData[i][10]);
                        lstImportedRange[lstImportedRange.Count - 1].forcectValues = getValuesFromCVS(parsedData[i][11], parsedData[i][12]);
                        lstImportedRange[lstImportedRange.Count - 1].sealcntValues = getValuesFromCVS(parsedData[i][13], parsedData[i][14]);
                        lstImportedRange[lstImportedRange.Count - 1].forcecntValues = getValuesFromCVS(parsedData[i][15], parsedData[i][16]);
                        lstImportedRange[lstImportedRange.Count - 1].cofdymanicValues = getValuesFromCVS(parsedData[i][17], parsedData[i][18]);
                        lstImportedRange[lstImportedRange.Count - 1].tratedValues = getValuesFromCVS(parsedData[i][19], parsedData[i][20]);
                        lstImportedRange[lstImportedRange.Count - 1].tensionceValues = getValuesFromCVS(parsedData[i][21], parsedData[i][22]);
                    }
                }
            }
            dgvImportedRange.Rows.Clear();
            for (int i = 0; i < lstImportedRange.Count; i++)
            {
                dgvImportedRange.Rows.Add();
                dgvImportedRange.Rows[i].Cells[clmimportedfilm.Index].Value = lstImportedRange[i].filmName;
                dgvImportedRange.Rows[i].Cells[clmimportedthickness.Index].Value = lstImportedRange[i].thiknessValues;
                dgvImportedRange.Rows[i].Cells[clmimportedunited.Index].Value = lstImportedRange[i].unitweightValues;
                dgvImportedRange.Rows[i].Cells[clmimportedopacity.Index].Value = lstImportedRange[i].opacityValues;
                dgvImportedRange.Rows[i].Cells[clmimportedtensionci.Index].Value = lstImportedRange[i].tensionciValues;
                dgvImportedRange.Rows[i].Cells[clmimportedsealct.Index].Value = lstImportedRange[i].sealctValues;
                dgvImportedRange.Rows[i].Cells[clmimportedforcect.Index].Value = lstImportedRange[i].forcectValues;
                dgvImportedRange.Rows[i].Cells[clmimportedsealcnt.Index].Value = lstImportedRange[i].sealcntValues;
                dgvImportedRange.Rows[i].Cells[clmimportedforcecnt.Index].Value = lstImportedRange[i].forcecntValues;
                dgvImportedRange.Rows[i].Cells[clmimportedcof.Index].Value = lstImportedRange[i].cofdymanicValues;
                dgvImportedRange.Rows[i].Cells[clmimportedtrased.Index].Value = lstImportedRange[i].tratedValues;
                dgvImportedRange.Rows[i].Cells[clmimportedtensionce.Index].Value = lstImportedRange[i].tensionceValues;
            }

            lblImportedPallets.Text = lstImportedRange.Count.ToString();
        }
        public List<string[]> parseCSV(string path)
        {
            try
            {
                parsedData = new List<string[]>();

                using (StreamReader readFile = new StreamReader(path))
                {
                    string line;
                    string[] row;

                    while ((line = readFile.ReadLine()) != null)
                    {
                        row = line.Split(',');
                        parsedData.Add(row);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return parsedData;
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            flgCanBeProcessed = true;

            for (int i = 0; i < dgvImportedRange.Rows.Count; i++)
            {
                string ProductCode = dgvImportedRange.Rows[i].Cells[clmimportedfilm.Index].Value.ToString();
                if (clsBopp.ExistFilm(ProductCode))
                {
                    dgvImportedRange.Rows[i].Cells[clmimportedfilm.Index].Style.ForeColor = Color.Red;
                    flgCanBeProcessed = false;
                }
                else
                    dgvImportedRange.Rows[i].Cells[clmimportedfilm.Index].Style.ForeColor = Color.Black;
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                lstAceptationRange = new List<clsAceptationRange>();
                if (flgCanBeProcessed)
                {
                    for (int i = 0; i < dgvImportedRange.Rows.Count; i++)
                    {
                        
                        if (clsAceptationRange.IsUniqueFilm(clsBopp.getFilmByCode(dgvImportedRange.Rows[i].Cells[clmimportedfilm.Index].Value.ToString())))
                        {
                            lstAceptationRange.Add(new clsAceptationRange());
                            lstAceptationRange[lstAceptationRange.Count - 1].fkBopp = clsBopp.getFilmByCode(dgvImportedRange.Rows[i].Cells[clmimportedfilm.Index].Value.ToString());
                            lstAceptationRange[lstAceptationRange.Count - 1].thiknessValues = dgvImportedRange.Rows[i].Cells[clmimportedthickness.Index].Value.ToString();
                            lstAceptationRange[lstAceptationRange.Count - 1].unitweightValues = dgvImportedRange.Rows[i].Cells[clmimportedunited.Index].Value.ToString();
                            lstAceptationRange[lstAceptationRange.Count - 1].opacityValues = dgvImportedRange.Rows[i].Cells[clmimportedopacity.Index].Value.ToString();
                            lstAceptationRange[lstAceptationRange.Count - 1].tensionciValues = dgvImportedRange.Rows[i].Cells[clmimportedtensionci.Index].Value.ToString();
                            lstAceptationRange[lstAceptationRange.Count - 1].sealctValues = dgvImportedRange.Rows[i].Cells[clmimportedsealct.Index].Value.ToString();
                            lstAceptationRange[lstAceptationRange.Count - 1].forcectValues = dgvImportedRange.Rows[i].Cells[clmimportedforcect.Index].Value.ToString();
                            lstAceptationRange[lstAceptationRange.Count - 1].sealcntValues = dgvImportedRange.Rows[i].Cells[clmimportedsealcnt.Index].Value.ToString();
                            lstAceptationRange[lstAceptationRange.Count - 1].forcecntValues = dgvImportedRange.Rows[i].Cells[clmimportedforcecnt.Index].Value.ToString();
                            lstAceptationRange[lstAceptationRange.Count - 1].cofdymanicValues = dgvImportedRange.Rows[i].Cells[clmimportedcof.Index].Value.ToString();
                            lstAceptationRange[lstAceptationRange.Count - 1].tratedValues = dgvImportedRange.Rows[i].Cells[clmimportedtrased.Index].Value.ToString();
                            lstAceptationRange[lstAceptationRange.Count - 1].tensionceValues = dgvImportedRange.Rows[i].Cells[clmimportedtensionce.Index].Value.ToString();
                        }
                    }

                    for (int i = 0; i < lstAceptationRange.Count; i++)
                        lstAceptationRange[i].save();

                    MessageBox.Show("Se ha realizado la importación de los rangos de aceptación con éxito", "Rangos de Aceptación importados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    PopulateMainRangeList();
                    tbcRange.SelectedIndex = 0;
                    codsec = 0;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha surgido un error en el proceso de importación de rango de aceptación, verifique que la información esta validada. " + ex.Message, "Rangos de Aceptación importados", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }
    }
}
