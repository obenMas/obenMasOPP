using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms; 
using BPS.Bussiness;
using ZedGraph;

namespace BPS
{
    public partial class frmMainCoilQualityMetal : Form
    {
        List<clsMainCoilMetal> lstMainCoilMetal = new List<clsMainCoilMetal>();
        clsMainCoilMetal objMainCoilMetal = new clsMainCoilMetal();
        clsMainCoilQualityMetal objMainCoilQualityMetal = new clsMainCoilQualityMetal();
        
        List<clsMainCoilQualityMetalCut> lstMainCoilQualityMetalCut = new List<clsMainCoilQualityMetalCut>();
        clsMainCoilQualityMetalCut objMainCoilQualityMetalCut = new clsMainCoilQualityMetalCut();

        List<string> lstAppearance = new List<string>();
        const double newtons = 9.81;
        private int selectCoil = 0, selectMainCoil = 0;

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

        private void setValuesToControl(System.Windows.Forms.Control container, string controlType, string values)
        {
            try
            {
                List<System.Windows.Forms.TextBox> lstTextBox = new List<TextBox>();
                switch (controlType)
                {
                    case "textBox":

                        List<double> lstDoubleValues = clsGlobal.getDoubleListFromString(values);
                        foreach (System.Windows.Forms.Control ctrl in container.Controls)
                        {
                            if (object.ReferenceEquals(ctrl.GetType(), typeof(System.Windows.Forms.TextBox)))
                                lstTextBox.Add(((TextBox)ctrl));
                        }
                        lstTextBox.Sort(delegate(TextBox txt1, TextBox txt2) { return txt1.TabIndex.CompareTo(txt2.TabIndex); });
                        for (int i = 0; i < lstTextBox.Count; i++)
                            lstTextBox[i].Text = lstDoubleValues[i].ToString();
                        break;

                    case "textBoxString":

                        List<string> lstStringValues = clsGlobal.getStringListFromString(values);
                        foreach (System.Windows.Forms.Control ctrl in container.Controls)
                        {
                            if (object.ReferenceEquals(ctrl.GetType(), typeof(System.Windows.Forms.TextBox)))
                                lstTextBox.Add(((TextBox)ctrl));
                        }

                        lstTextBox.Sort(delegate(TextBox txt1, TextBox txt2) { return txt1.TabIndex.CompareTo(txt2.TabIndex); });
                        for (int i = 0; i < lstStringValues.Count; i++)
                            lstTextBox[i + 1].Text = lstStringValues[i].ToString();
                        break;

                    case "checkBox":

                        List<System.Windows.Forms.CheckBox> lstCheckBox = new List<CheckBox>();
                        List<bool> lstBoolValues = clsGlobal.getBooleanListFromString(values);

                        foreach (System.Windows.Forms.Control ctrl in container.Controls)
                        {
                            if (object.ReferenceEquals(ctrl.GetType(), typeof(System.Windows.Forms.CheckBox)))
                                lstCheckBox.Add(((CheckBox)ctrl));
                        }
                        lstCheckBox.Sort(delegate(CheckBox chk1, CheckBox chk2) { return chk1.TabIndex.CompareTo(chk2.TabIndex); });
                        for (int i = 0; i < lstCheckBox.Count; i++)
                            lstCheckBox[i].Checked = lstBoolValues[i];
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Calidad", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void calculateThiknessAverage()
        {
            try
            {
                double average, sum, variance, sumForVariance, desviation;
                int validCell = 0;
                sum = 0;
                sumForVariance = 0;


                if (chkAverage.Checked == false)
                {
                    for (int i = 0; i < dgvThikness.Rows.Count; i++)
                    {
                        if (Convert.ToDouble(dgvThikness.Rows[i].Cells[clmThiknessValue.Index].Value) != 0)
                            validCell++;
                    }

                    for (int i = 0; i < dgvThikness.Rows.Count; i++)
                        sum += Convert.ToDouble(dgvThikness.Rows[i].Cells[clmThiknessValue.Index].Value);

                    average = Math.Round((sum / validCell), 2);
                    txtAverage.Text = average.ToString();

                    for (int i = 0; i < validCell; i++)
                        sumForVariance += Math.Pow((Convert.ToDouble(dgvThikness.Rows[i].Cells[clmThiknessValue.Index].Value) - average), 2);

                    variance = Math.Round((sumForVariance / validCell), 10);
                    desviation = Math.Round(Math.Sqrt(variance), 3, MidpointRounding.ToEven);
                    c.Text = desviation.ToString();
                }
                else
                {
                    for (int i = 0; i < dgvThikness.Rows.Count; i++)
                    {
                        if (Convert.ToDouble(dgvThikness.Rows[i].Cells[clmThiknessValue.Index].Value) != 0)
                            validCell++;
                    }

                    for (int i = 1; i < dgvThikness.Rows.Count - 1; i++)
                        sum += Convert.ToDouble(dgvThikness.Rows[i].Cells[clmThiknessValue.Index].Value);

                    average = Math.Round((sum / (validCell - 2)), 2);
                    txtAverage.Text = average.ToString();

                    for (int i = 1; i < validCell - 1; i++)
                        sumForVariance += Math.Pow((Convert.ToDouble(dgvThikness.Rows[i].Cells[clmThiknessValue.Index].Value) - average), 2);

                    variance = Math.Round((sumForVariance / (validCell - 2)), 10);
                    desviation = Math.Round(Math.Sqrt(variance), 3, MidpointRounding.ToEven);
                    c.Text = desviation.ToString();
                }

                drawOutline();

                List<double> lstThikness = new List<double>();
                for (int i = 0; i < dgvThikness.Rows.Count; i++)
                    lstThikness.Add(Convert.ToDouble(dgvThikness.Rows[i].Cells[clmThiknessValue.Index].Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Calidad", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void drawOutline()
        {
            try
            {
                zgcProfile.GraphPane.CurveList.Clear();
                PointPairList points = new PointPairList();
                PointPairList averagePoints = new PointPairList();
                PointPairList upDesviationPoints = new PointPairList();
                PointPairList downDesviationPoints = new PointPairList();

                for (int i = 0; i < dgvThikness.Rows.Count; i++)
                {
                    points.Add(Convert.ToDouble(dgvThikness.Rows[i].Cells[clmNumber.Index].Value), Convert.ToDouble(dgvThikness.Rows[i].Cells[clmThiknessValue.Index].Value));
                    averagePoints.Add(i + 1, Convert.ToDouble(txtAverage.Text));
                    upDesviationPoints.Add(i + 1, (Convert.ToDouble(txtAverage.Text) + (Convert.ToDouble(c.Text))));
                    downDesviationPoints.Add(i + 1, (Convert.ToDouble(txtAverage.Text) - (Convert.ToDouble(c.Text))));
                }
                LineItem outLineCurve = zgcProfile.GraphPane.AddCurve("", points, Color.Blue, SymbolType.Diamond);
                LineItem averageCurve = zgcProfile.GraphPane.AddCurve("", averagePoints, Color.Green, SymbolType.None);
                LineItem upDesviationCurve = zgcProfile.GraphPane.AddCurve("", upDesviationPoints, Color.Red, SymbolType.None);
                LineItem downDesviationCurve = zgcProfile.GraphPane.AddCurve("", downDesviationPoints, Color.Red, SymbolType.None);

                zgcProfile.GraphPane.XAxis.Scale.FontSpec.Size = 30;
                zgcProfile.GraphPane.YAxis.Scale.FontSpec.Size = 30;

                zgcProfile.AxisChange();
                zgcProfile.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Calidad", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void setThiknessValues(string destination)
        {
            try
            {
                switch (destination)
                {
                    case "toSave":

                        objMainCoilQualityMetal.densityOpticValues = "";
                        objMainCoilQualityMetal.densityOpticList = new List<double>();
                        if (dgvThikness.Rows.Count <= 29)
                        {
                            for (int i = 0; i < dgvThikness.Rows.Count; i++)
                            {
                                objMainCoilQualityMetal.densityOpticValues += dgvThikness.Rows[i].Cells[clmThiknessValue.Index].Value.ToString();
                                objMainCoilQualityMetal.densityOpticValues += (i < dgvThikness.Rows.Count - 1) ? ";" : "";
                                objMainCoilQualityMetal.densityOpticList.Add(Convert.ToDouble(dgvThikness.Rows[i].Cells[clmThiknessValue.Index].Value));
                            }
                            int complete = 29 - dgvThikness.Rows.Count;

                            if (complete == 1)
                            {
                                objMainCoilQualityMetal.densityOpticValues += ";";
                                objMainCoilQualityMetal.densityOpticValues += 0;
                                objMainCoilQualityMetal.densityOpticList.Add(0);
                            }
                            else if (complete == 29)
                            {
                                for (int i = 0; i < complete; i++)
                                {
                                    objMainCoilQualityMetal.densityOpticValues += 0;
                                    objMainCoilQualityMetal.densityOpticValues += (i < complete - 1) ? ";" : "";
                                    objMainCoilQualityMetal.densityOpticList.Add(0);
                                }
                            }   
                            else
                            {
                                for (int i = 0; i < complete; i++)
                                {
                                    if (i == 0)
                                    {
                                        objMainCoilQualityMetal.densityOpticValues += ";";
                                        objMainCoilQualityMetal.densityOpticValues += 0;
                                        objMainCoilQualityMetal.densityOpticValues += ";";
                                        objMainCoilQualityMetal.densityOpticList.Add(0);
                                    }
                                    else
                                    {
                                        objMainCoilQualityMetal.densityOpticValues += 0;
                                        objMainCoilQualityMetal.densityOpticValues += (i < complete - 1) ? ";" : "";
                                        objMainCoilQualityMetal.densityOpticList.Add(0);
                                    }
                                }
                            }
                        }
                        objMainCoilQualityMetal.densityOpticAverage = Convert.ToDouble(txtAverage.Text);
                        objMainCoilQualityMetal.densityOpticDesviation = Convert.ToDouble(c.Text);
                        break;

                    case "toLoad":
                        dgvThikness.Rows.Clear();
                        for (int i = 0; i < objMainCoilQualityMetal.densityOpticList.Count; i++)
                        {
                            dgvThikness.Rows.Add();
                            dgvThikness.Rows[i].Cells[clmNumber.Index].Value = Convert.ToString(i + 1);
                            dgvThikness.Rows[i].Cells[clmThiknessValue.Index].Value = objMainCoilQualityMetal.densityOpticList[i].ToString();
                        }
                        drawOutline();
                        txtAverage.Text = Convert.ToString(Math.Round(objMainCoilQualityMetal.densityOpticAverage, 2));
                        c.Text = Convert.ToString(Math.Round(objMainCoilQualityMetal.densityOpticDesviation, 2));
                        calculateThiknessAverage();
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Calidad", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void setSealTemperatureNTFValues(string destination)
        {
            try
            {
                switch (destination)
                {
                    case "toSave":
                        objMainCoilQualityMetal.surfaceTensionValues = getValuesFromControl(grpbSurfaceTension, "textBox");
                        objMainCoilQualityMetal.surfaceTensionList = clsGlobal.getDoubleListFromString(objMainCoilQualityMetal.surfaceTensionValues);
                        break;
                    case "toLoad":
                        setValuesToControl(grpbSurfaceTension, "textBox", objMainCoilQualityMetal.surfaceTensionValues);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Calidad", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void calculateTotals()
        {
            //if (dgvGramaje.SelectedRows.Count > 0)
            //    dgvGramaje.Rows[dgvGramaje.SelectedRows[0].Index].Cells[clmGramajeWeight.Index].Value = Convert.ToString(Math.Round(((lstMainCoilMetal[dgvGramaje.SelectedRows[0].Index].grosslength * lstMainCoilMetal[dgvGramaje.SelectedRows[0].Index].width * Convert.ToDouble(dgvGramaje.Rows[dgvGramaje.SelectedRows[0].Index].Cells[clmGramajeGramaje.Index].EditedFormattedValue)) / 1000 / 1000), 2));
        }

        private void loadMainCoilData(clsMainCoilMetal objMainCoilToShow)
        {
            try
            {
                List<clsProductionOrderMetal> lstProductionOrder = new List<clsProductionOrderMetal>();
                lstProductionOrder = clsProductionOrderMetal.getFilmProductionPlanByCodsec(objMainCoilToShow.fkFilmProductionPlan);

                lblOrderNumber.Text = lstProductionOrder[0].number.ToString();
                lblFilmType.Text = objMainCoilToShow.BoppToCode;
                lblCode.Text = objMainCoilToShow.mcode;
                lblLot.Text = objMainCoilToShow.lotNumber;
                lblVariation.Text = "0";
                lblMachine.Text = lstProductionOrder[0].MachineName.ToString();
                lblDate.Text = objMainCoilToShow.modifiedDate.ToString("dd/MM/yyyy HH:mm:ss");
                lblOperator.Text = objMainCoilToShow.modificatorUser;
                lblCoilerName.Text = Math.Round(lstProductionOrder[0].densityoptic, 2, MidpointRounding.ToEven).ToString();
                lblInitDate.Text = objMainCoilToShow.createdDate.ToString("dd/MM/yyyy HH:mm:ss");
                lblEndDate.Text = objMainCoilToShow.modifiedDate.ToString("dd/MM/yyyy HH:mm:ss");
                TimeSpan span = objMainCoilToShow.modifiedDate.Subtract(objMainCoilMetal.createdDate);
                lblHours.Text = Convert.ToString(Math.Abs(Math.Round(span.TotalHours, 2)));
                lblFormulation.Text = objMainCoilToShow.BoppFromCode + " / [ " + objMainCoilToShow.ProductFromCode + "]";
                lblKgPerHour.Text = lstProductionOrder[0].kilograms.ToString();
                lblVelocity.Text = lstProductionOrder[0].Coil.ToString();
                lblLength.Text = objMainCoilToShow.origin.ToString();
                lblWidht.Text = objMainCoilToShow.width.ToString();
                lblGramaje.Text = objMainCoilToShow.maincode.ToString();
                lblWeight.Text = objMainCoilToShow.OriginWeigth.ToString();
                lblNotes.Text = objMainCoilToShow.notes;
                lblTotalDecrease.Text = objMainCoilToShow.decrease.ToString();

                //lblNetLength.Text = objMainCoilToShow.netlength.ToString();
                //lblNetWeigth.Text = objMainCoilToShow.netWeigth.ToString();
                //lblSupervisor.Text = objMainCoilToShow.supervisorName;
                //lblOperator.Text = objMainCoilToShow.operatorName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Calidad", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void loadQualityData(clsMainCoilMetal objMainCoilToShow)
        {
            try
            {
                List<double> lstThikness = new List<double>();
                List<clsMainCoilMetal> lstMainCoilMetalByQuality = new List<clsMainCoilMetal>();

                objMainCoilQualityMetal = clsMainCoilQualityMetal.getQualityByMainCoil(objMainCoilToShow.codsec);

                if (objMainCoilQualityMetal.codsec > 0)
                {
                    //lstMainCoilMetalByQuality = clsMainCoil.getBoppMainCoilListByQualityReport(objMainCoilQualityMetal.codsec);

                    lstbCoilsToQualify.Items.Clear();

                    for (int i = 0; i < objMainCoilQualityMetal.lstMainCoilMetal.Count; i++)
                        lstbCoilsToQualify.Items.Add(objMainCoilQualityMetal.lstMainCoilMetal[i]);

                    lstMainCoilMetal.Clear();
                    lstMainCoilMetal = objMainCoilQualityMetal.lstMainCoilMetal;

                    dgvGramaje.Rows.Clear();
                    dgvRating.Rows.Clear();

                    for (int i = 0; i < lstMainCoilMetal.Count; i++)
                    {
                        dgvGramaje.Rows.Add();
                        dgvGramaje.Rows[i].Cells[clmGramajeMainCoilCodsec.Index].Value = lstMainCoilMetal[i].codsec;
                        dgvGramaje.Rows[i].Cells[clmGramajeMainCoilCode.Index].Value = lstMainCoilMetal[i].mcode;
                        dgvGramaje.Rows[i].Cells[clmGramajeGramaje.Index].Value = objMainCoilQualityMetal.gramaje;
                        dgvGramaje.Rows[i].Cells[clmGramajeWeight.Index].Value = Math.Round(lstMainCoilMetal[i].netWeigth, 2).ToString();

                        dgvRating.Rows.Add();
                        dgvRating.Rows[i].Cells[clmQualityMainCoilCodsec.Index].Value = lstMainCoilMetal[i].codsec;
                        dgvRating.Rows[i].Cells[clmQualityMainCoilCode.Index].Value = lstMainCoilMetal[i].mcode;
                        dgvRating.Rows[i].Cells[clmQualityRanking.Index].Value = lstMainCoilMetal[i].labRating;
                    }
                }

                if (objMainCoilQualityMetal.codsec > 0)
                {
                    txtOpacityTransmitanceAverage.Text = objMainCoilQualityMetal.cof.ToString();
                    txtSealTemperatureNonTreatedFace.Text = objMainCoilQualityMetal.seal.ToString();
                    for (int i = 0; i < cmbTape.Items.Count; i++)
                    {
                        if (cmbTape.Items[i].ToString() == objMainCoilQualityMetal.tape)
                        {
                            cmbTape.SelectedIndex = i;
                            break;
                        }
                    }
                    setThiknessValues("toLoad");
                    setSealTemperatureNTFValues("toLoad");
                    txtFisicStatus.Text = objMainCoilQualityMetal.notes;
                    dtpReceptionDate.Value = objMainCoilQualityMetal.receptionDate;
                }
                if (objMainCoilQualityMetal.codsec == 0)
                {
                    dgvGramaje.Rows.Clear();
                    dgvRating.Rows.Clear();
                    for (int i = 0; i < lstMainCoilMetal.Count; i++)
                    {
                        dgvGramaje.Rows.Add();
                        dgvGramaje.Rows[i].Cells[clmGramajeMainCoilCodsec.Index].Value = lstMainCoilMetal[i].codsec;
                        dgvGramaje.Rows[i].Cells[clmGramajeMainCoilCode.Index].Value = lstMainCoilMetal[i].mcode;
                        dgvGramaje.Rows[i].Cells[clmGramajeGramaje.Index].Value = objMainCoilQualityMetal.gramaje;
                        dgvGramaje.Rows[i].Cells[clmGramajeWeight.Index].Value = Math.Round(lstMainCoilMetal[i].netWeigth, 2).ToString();

                        dgvRating.Rows.Add();
                        dgvRating.Rows[i].Cells[clmQualityMainCoilCodsec.Index].Value = lstMainCoilMetal[i].codsec;
                        dgvRating.Rows[i].Cells[clmQualityMainCoilCode.Index].Value = lstMainCoilMetal[i].mcode;
                        dgvRating.Rows[i].Cells[clmQualityRanking.Index].Value = lstMainCoilMetal[i].labRating;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Calidad", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        public frmMainCoilQualityMetal()
        {
            InitializeComponent();
        }

        public frmMainCoilQualityMetal(int mainCoilCodsec)
        {
            InitializeComponent();
            objMainCoilMetal.load(mainCoilCodsec);
            lstMainCoilMetal.Add(objMainCoilMetal);
            lstbCoilsToQualify.Items.Add(objMainCoilMetal);
        }

        private void frmMainCoilQuality_Load(object sender, EventArgs e)
        {
            if (lstMainCoilMetal.Count > 0)
            {
                loadMainCoilData(lstMainCoilMetal[0]);   
                txtOperatorCriterial.Text = lstMainCoilMetal[0].notes;
                loadQualityData(lstMainCoilMetal[0]);
                loadQualityCut(lstMainCoilMetal[0]);
            }
            else
                tbcMainCoilInfo.TabPages.Remove(tbpMainCoilQuality);
        }

        

        private void txtThikness_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (clsGlobal.isNumeric(txtThikness.Text) == false)
                    {
                        MessageBox.Show("El valor debe ser Numerico");
                        txtThikness.Text = "0";
                        txtThikness.SelectAll();
                    }
                    else
                    {
                        dgvThikness.Rows.Add();
                        dgvThikness.Rows[dgvThikness.Rows.Count - 1].Cells[clmNumber.Index].Value = dgvThikness.Rows.Count;
                        dgvThikness.Rows[dgvThikness.Rows.Count - 1].Cells[clmThiknessValue.Index].Value = Math.Round(Convert.ToDouble(txtThikness.Text), 3, MidpointRounding.ToEven);
                        txtThikness.Text = "0";
                        txtThikness.SelectAll();

                        this.dgvThikness.CurrentCell = this.dgvThikness[0, this.dgvThikness.Rows.Count - 1];

                        calculateThiknessAverage();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Calidad", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void btnMainCoilSave_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < lstMainCoilMetal.Count; i++)
                {
                    //lstMainCoilMetal[i].gramaje = Convert.ToDouble(dgvGramaje.Rows[i].Cells[clmGramajeGramaje.Index].Value);
                    lstMainCoilMetal[i].analistRating = dgvRating.Rows[i].Cells[clmQualityRanking.Index].Value.ToString();
                    lstMainCoilMetal[i].labRating = dgvRating.Rows[i].Cells[clmQualityRanking.Index].Value.ToString();
                    lstMainCoilMetal[i].toUpdateLab();
                }

                setThiknessValues("toSave");
                setSealTemperatureNTFValues("toSave");
                objMainCoilQualityMetal.cof = Convert.ToDouble(txtOpacityTransmitanceAverage.Text);
                objMainCoilQualityMetal.gramaje = Convert.ToDouble(dgvGramaje.Rows[0].Cells[clmGramajeGramaje.Index].Value);
                objMainCoilQualityMetal.seal = Convert.ToDouble(txtSealTemperatureNonTreatedFace.Text);
                objMainCoilQualityMetal.tape = cmbTape.SelectedItem.ToString();
                objMainCoilQualityMetal.notes = txtFisicStatus.Text;
                objMainCoilQualityMetal.lstMainCoilMetal = lstMainCoilMetal;

                if (objMainCoilQualityMetal.save())
                    MessageBox.Show("El control de calidad de la rollo madre metalizado se ha guardado con éxito.", "Control de calidad", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                else
                    MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Control de calidad", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Calidad", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void btnMainCoilCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea cancelar el control de calidad de esta rollo madre metalizado?", "Control de calidad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
                    frmMainCoilMetalList winMainCoilList = new frmMainCoilMetalList();
                    winMainCoilList.StartPosition = FormStartPosition.Manual;
                    winMainCoilList.MdiParent = this.MdiParent;
                    winMainCoilList.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Calidad", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void dgvThikness_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            calculateThiknessAverage();
        }

        private void dgvThikness_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            calculateThiknessAverage();
        }

        private void btnAddThikness_Click(object sender, EventArgs e)
        {
            try
            {
                if (clsGlobal.isNumeric(txtThikness.Text) == false)
                {
                    MessageBox.Show("El valor debe ser Numérico");
                    txtThikness.Text = "0";
                    txtThikness.SelectAll();
                }
                else
                {
                    dgvThikness.Rows.Add();
                    dgvThikness.Rows[dgvThikness.Rows.Count - 1].Cells[clmNumber.Index].Value = dgvThikness.Rows.Count;
                    dgvThikness.Rows[dgvThikness.Rows.Count - 1].Cells[clmThiknessValue.Index].Value = Math.Round(Convert.ToDouble(txtThikness.Text), 3, MidpointRounding.ToEven);
                    txtThikness.Text = "0";
                    txtThikness.SelectAll();
                    this.dgvThikness.CurrentCell = this.dgvThikness[0, this.dgvThikness.Rows.Count - 1];
                    calculateThiknessAverage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Calidad", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void btnMainCoilExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMainCoilQuality_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMainCoilMetalList winMainCoilList = new frmMainCoilMetalList();
            winMainCoilList.StartPosition = FormStartPosition.Manual;
            winMainCoilList.MdiParent = this.MdiParent;
            winMainCoilList.Show();
        }

        private void chkAverage_CheckedChanged(object sender, EventArgs e)
        {
            calculateThiknessAverage();
        }

        private void lblGramaje_TextChanged(object sender, EventArgs e)
        {
            //calculateTotals();
        }

        private void txtCoilCodeToQualify_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                clsMainCoilMetal objNewMainMetalCoil = new clsMainCoilMetal();
                bool flgInList = false;

                if (e.KeyCode == Keys.Enter)
                {
                    objNewMainMetalCoil.load(txtCoilCodeToQualify.Text, true, true);
                    if (objNewMainMetalCoil.codsec > 0)
                    {
                        if (objNewMainMetalCoil.fkStatus != 1073)
                        {
                            for (int i = 0; i < lstMainCoilMetal.Count; i++)
                            {
                                if (objNewMainMetalCoil.codsec == lstMainCoilMetal[i].codsec)
                                    flgInList = true;
                            }

                            if (flgInList == false)
                            {
                                lstbCoilsToQualify.Items.Add(objNewMainMetalCoil);
                                lstMainCoilMetal.Add(objNewMainMetalCoil);

                                dgvGramaje.Rows.Clear();
                                dgvRating.Rows.Clear();

                                for (int i = 0; i < lstMainCoilMetal.Count; i++)
                                {
                                    dgvGramaje.Rows.Add();
                                    dgvGramaje.Rows[i].Cells[clmGramajeMainCoilCodsec.Index].Value = lstMainCoilMetal[i].codsec;
                                    dgvGramaje.Rows[i].Cells[clmGramajeMainCoilCode.Index].Value = lstMainCoilMetal[i].mcode;
                                    dgvGramaje.Rows[i].Cells[clmGramajeWeight.Index].Value = Math.Round(lstMainCoilMetal[i].netWeigth, 2).ToString();
                                    dgvGramaje.Rows[i].Cells[clmGramajeGramaje.Index].Value = 0;
                                    dgvGramaje.Rows[i].Cells[clmCalculateWeight.Index].Value = "True";

                                    dgvRating.Rows.Add();
                                    dgvRating.Rows[i].Cells[clmQualityMainCoilCodsec.Index].Value = lstMainCoilMetal[i].codsec;
                                    dgvRating.Rows[i].Cells[clmQualityMainCoilCode.Index].Value = lstMainCoilMetal[i].mcode;
                                    dgvRating.Rows[i].Cells[clmQualityRanking.Index].Value = lstMainCoilMetal[i].labRating;
                                }

                                if (lstMainCoilMetal.Count == 1)
                                {
                                    tbcMainCoilInfo.TabPages.Add(tbpMainCoilQuality);
                                    loadMainCoilData(objNewMainMetalCoil);
                                    txtOperatorCriterial.Text = objNewMainMetalCoil.notes;
                                    loadQualityData(objNewMainMetalCoil);
                                }
                            }
                        }
                        else
                            MessageBox.Show("No puede ingresar una bobina que se encuentra como ANULADA, por favor confirme con departamento de programación su estado y vuelva a intentarlo.");
                    }
                    else
                        MessageBox.Show("El código ingresado no corresponde a ninguna bobina ingresada al sistema.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Calidad", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void lstbCoilsToQualify_SelectedIndexChanged(object sender, EventArgs e)
        {
            objMainCoilMetal = lstMainCoilMetal[lstbCoilsToQualify.SelectedIndex];
            loadMainCoilData(objMainCoilMetal);
        }

        private void btnCopyForwardSTTF_Click(object sender, EventArgs e)
        {
            txtSurfaceTension2.Text = txtSurfaceTension1.Text;
            txtSurfaceTension3.Text = txtSurfaceTension1.Text;
        }

        private void btnCopyForwardSTNTF_Click(object sender, EventArgs e)
        {
            txtSurfaceTensionEF2.Text = txtSurfaceTensionEF1.Text;
            txtSurfaceTensionEF3.Text = txtSurfaceTensionEF1.Text;
        }

        private void dgvGramaje_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == clmGramajeGramaje.Index)
            //{
            //    if (dgvGramaje.Rows[e.RowIndex].Cells[clmCalculateWeight.Index].Value.ToString() == "True")
            //        calculateTotals();
            //}
        }

        private void txtFrictionCoefficientNTFAverage_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCoil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmcoilselect.Index)
            {
                setDensityValues("toLoad", Convert.ToInt32(dgvCoil.Rows[e.RowIndex].Cells[clmcoilcodsec.Index].Value));
                txtNotesCut.Text = dgvCoil.Rows[e.RowIndex].Cells[clmcoilnotes.Index].Value.ToString();
                setSealTemperatureValuesCoil("toLoad");
                setDensityValuesAll("toLoad", Convert.ToInt32(dgvCoil.Rows[e.RowIndex].Cells[clmcoilcodsec.Index].Value));
                selectCoil = Convert.ToInt32(dgvCoil.Rows[e.RowIndex].Cells[clmcoilcodsec.Index].Value);
                selectMainCoil = Convert.ToInt32(dgvCoil.Rows[e.RowIndex].Cells[clmcoilfkmaincoil.Index].Value);
            }
        }

        private void setDensityValuesAll(string destination, int fkcoil)
        {
            try
            {
                objMainCoilQualityMetalCut = clsMainCoilQualityMetalCut.getQualityByCoil(fkcoil);
                for (int i = 0; i < cmbDensityTaper.Items.Count; i++)
                {
                    if (cmbDensityTaper.Items[i].ToString() == objMainCoilQualityMetalCut.tape)
                    {
                        cmbDensityTaper.SelectedIndex = i;
                        break;
                    }
                }
                for (int i = 0; i < cmbDensityCalification.Items.Count; i++)
                {
                    if (cmbDensityCalification.Items[i].ToString() == objMainCoilQualityMetalCut.analistRating)
                    {
                        cmbDensityCalification.SelectedIndex = i;
                        break;
                    }
                }
                txtNotesAnalist.Text = objMainCoilQualityMetalCut.notes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Calidad", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void setDensityValues(string destination, int fkcoil)
        {
            try
            {
                switch (destination)
                {
                    case "toSave":

                        objMainCoilQualityMetalCut.densityOpticValues = "";
                        objMainCoilQualityMetalCut.densityOpticList = new List<double>();
                        if (dgvDensity.Rows.Count <= 14)
                        {
                            for (int i = 0; i < dgvDensity.Rows.Count; i++)
                            {
                                objMainCoilQualityMetalCut.densityOpticValues += dgvDensity.Rows[i].Cells[clmdensitydensity.Index].Value.ToString();
                                objMainCoilQualityMetalCut.densityOpticValues += (i < dgvDensity.Rows.Count - 1) ? ";" : "";
                                objMainCoilQualityMetalCut.densityOpticList.Add(Convert.ToDouble(dgvDensity.Rows[i].Cells[clmdensitydensity.Index].Value));
                            }
                            int complete = 14 - dgvDensity.Rows.Count;

                            if (complete == 1)
                            {
                                objMainCoilQualityMetalCut.densityOpticValues += ";";
                                objMainCoilQualityMetalCut.densityOpticValues += 0;
                                objMainCoilQualityMetalCut.densityOpticList.Add(0);
                            }
                            else
                            {
                                for (int i = 0; i < complete; i++)
                                {
                                    if (i == 0)
                                    {
                                        objMainCoilQualityMetalCut.densityOpticValues += ";";
                                        objMainCoilQualityMetalCut.densityOpticValues += 0;
                                        objMainCoilQualityMetalCut.densityOpticValues += ";";
                                        objMainCoilQualityMetalCut.densityOpticList.Add(0);
                                    }
                                    else
                                    {
                                        objMainCoilQualityMetalCut.densityOpticValues += 0;
                                        objMainCoilQualityMetalCut.densityOpticValues += (i < complete - 1) ? ";" : "";
                                        objMainCoilQualityMetalCut.densityOpticList.Add(0);
                                    }
                                }
                            }
                        }
                        objMainCoilQualityMetalCut.densityOpticAverage = Convert.ToDouble(txtDensityAverage.Text);
                        objMainCoilQualityMetalCut.densityOpticDesviation = Convert.ToDouble(txtDensityDesviation.Text);
                        break;

                    case "toLoad":
                        dgvDensity.Rows.Clear();
                        if (fkcoil != 0)
                        {
                            objMainCoilQualityMetalCut = new clsMainCoilQualityMetalCut();
                            objMainCoilQualityMetalCut = clsMainCoilQualityMetalCut.getQualityByCoil(fkcoil);
                            if (objMainCoilQualityMetalCut.codsec > 0)
                            {
                                for (int i = 0; i < objMainCoilQualityMetalCut.densityOpticList.Count; i++)
                                {
                                    dgvDensity.Rows.Add();
                                    dgvDensity.Rows[i].Cells[clmdensitynumber.Index].Value = Convert.ToString(i + 1);
                                    dgvDensity.Rows[i].Cells[clmdensitydensity.Index].Value = objMainCoilQualityMetalCut.densityOpticList[i].ToString();
                                }
                                txtDensityAverage.Text = Convert.ToString(Math.Round(objMainCoilQualityMetalCut.densityOpticAverage, 2));
                                txtDensityDesviation.Text = Convert.ToString(Math.Round(objMainCoilQualityMetalCut.densityOpticDesviation, 2));
                                calculateDensityAverage();
                            }
                        }
                        else
                        {
                            dgvDensity.Rows.Clear();
                        }
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Calidad", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void loadQualityCut(clsMainCoilMetal objMainCoilMetal)
        {
            try
            {
                List<clsCoil> lstCoil = new List<clsCoil>();
                lstCoil = clsCoil.getListByMainCoilMetal(objMainCoilMetal.mcode);
                dgvCoil.Rows.Clear();
                if (lstCoil.Count > 0)
                {
                    for (int i = 0; i < lstCoil.Count; i++)
                    {
                        if (lstCoil[i].cuttingPosition != 0 && lstCoil[i].cuttingStop != 0)
                        {
                            dgvCoil.Rows.Add();
                            dgvCoil.Rows[dgvCoil.Rows.Count - 1].Cells[clmcoilcodsec.Index].Value = lstCoil[i].codsec;
                            dgvCoil.Rows[dgvCoil.Rows.Count - 1].Cells[clmcoilcode.Index].Value = lstCoil[i].code;
                            dgvCoil.Rows[dgvCoil.Rows.Count - 1].Cells[clmcoilcreateddate.Index].Value = lstCoil[i].createdDate.ToString("dd/MM/yyyy HH:mm:ss");
                            dgvCoil.Rows[dgvCoil.Rows.Count - 1].Cells[clmcoilcuttingposition.Index].Value = lstCoil[i].cuttingPosition;
                            dgvCoil.Rows[dgvCoil.Rows.Count - 1].Cells[clmcoilcuttingstop.Index].Value = lstCoil[i].cuttingStop;
                            dgvCoil.Rows[dgvCoil.Rows.Count - 1].Cells[clmcoilfkmaincoil.Index].Value = objMainCoilMetal.codsec;
                            dgvCoil.Rows[dgvCoil.Rows.Count - 1].Cells[clmcoilproduct.Index].Value = lstCoil[i].ProductCode;
                            dgvCoil.Rows[dgvCoil.Rows.Count - 1].Cells[clmcoilweigth.Index].Value = Math.Round(lstCoil[i].netWeight, 2, MidpointRounding.AwayFromZero).ToString();
                            dgvCoil.Rows[dgvCoil.Rows.Count - 1].Cells[clmcoilwidth.Index].Value = lstCoil[i].width;
                            dgvCoil.Rows[dgvCoil.Rows.Count - 1].Cells[clmcoilselect.Index].Value = global::BPS.Properties.Resources.quality;
                            dgvCoil.Rows[dgvCoil.Rows.Count - 1].Cells[clmcoilnotes.Index].Value = lstCoil[i].notes;
                            if (lstCoil[i].cuttingPosition == 0 && lstCoil[i].cuttingStop == 0)
                            {
                                for (int j = 0; j < dgvCoil.Columns.Count; j++)
                                    dgvCoil.Rows[dgvCoil.Rows.Count - 1].Cells[j].Style.BackColor = Color.FromArgb(207, 234, 254);
                            } 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Calidad", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void setSealTemperatureValuesCoil(string destination)
        {
            try
            {
                switch (destination)
                {
                    case "toSave":
                        objMainCoilQualityMetalCut.surfaceTensionValues = getValuesFromControl(groupBox2, "textBox");
                        objMainCoilQualityMetalCut.surfaceTensionList = clsGlobal.getDoubleListFromString(objMainCoilQualityMetalCut.surfaceTensionValues);
                        break;
                    case "toLoad":
                        setValuesToControl(groupBox2, "textBox", objMainCoilQualityMetalCut.surfaceTensionValues);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Calidad", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void calculateDensityAverage()
        {
            try
            {
                double average, sum, variance, sumForVariance, desviation;
                int validCell = 0;
                sum = 0;
                sumForVariance = 0;

                if (chkAverage.Checked == false)
                {
                    for (int i = 0; i < dgvDensity.Rows.Count; i++)
                    {
                        if (Convert.ToDouble(dgvDensity.Rows[i].Cells[clmdensitydensity.Index].Value) != 0)
                            validCell++;
                    }

                    for (int i = 0; i < dgvDensity.Rows.Count; i++)
                        sum += Convert.ToDouble(dgvDensity.Rows[i].Cells[clmdensitydensity.Index].Value);

                    average = Math.Round((sum / validCell), 2);
                    txtDensityAverage.Text = average.ToString();

                    for (int i = 0; i < validCell; i++)
                        sumForVariance += Math.Pow((Convert.ToDouble(dgvDensity.Rows[i].Cells[clmdensitydensity.Index].Value) - average), 2);

                    variance = Math.Round((sumForVariance / validCell), 10);
                    desviation = Math.Round(Math.Sqrt(variance), 3, MidpointRounding.ToEven);
                    txtDensityDesviation.Text = desviation.ToString();
                }
                else
                {
                    for (int i = 0; i < dgvThikness.Rows.Count; i++)
                    {
                        if (Convert.ToDouble(dgvThikness.Rows[i].Cells[clmThiknessValue.Index].Value) != 0)
                            validCell++;
                    }

                    for (int i = 1; i < dgvDensity.Rows.Count - 1; i++)
                        sum += Convert.ToDouble(dgvDensity.Rows[i].Cells[clmdensitydensity.Index].Value);

                    average = Math.Round((sum / (validCell - 2)), 2);
                    txtDensityAverage.Text = average.ToString();

                    for (int i = 1; i < validCell - 1; i++)
                        sumForVariance += Math.Pow((Convert.ToDouble(dgvDensity.Rows[i].Cells[clmdensitydensity.Index].Value) - average), 2);

                    variance = Math.Round((sumForVariance / (validCell - 2)), 10);
                    desviation = Math.Round(Math.Sqrt(variance), 3, MidpointRounding.ToEven);
                    txtDensityDesviation.Text = desviation.ToString();
                }
                //List<double> lstThikness = new List<double>();
                //for (int i = 0; i < dgvDensity.Rows.Count; i++)
                //    lstThikness.Add(Convert.ToDouble(dgvDensity.Rows[i].Cells[clmThiknessValue.Index].Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Calidad", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void tbcQualityData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcQualityData.SelectedTab == tbpCut)
                btnMainCoilSave.Enabled = false;
            else
                btnMainCoilSave.Enabled = true;
        }

        private void txtDensity_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (clsGlobal.isNumeric(txtDensity.Text) == false)
                    {
                        MessageBox.Show("El valor debe ser Numérico");
                        txtDensity.Text = "0";
                        txtDensity.SelectAll();
                    }
                    else
                    {
                        dgvDensity.Rows.Add();
                        dgvDensity.Rows[dgvDensity.Rows.Count - 1].Cells[clmdensitynumber.Index].Value = dgvDensity.Rows.Count;
                        dgvDensity.Rows[dgvDensity.Rows.Count - 1].Cells[clmdensitydensity.Index].Value = Math.Round(Convert.ToDouble(txtDensity.Text), 3, MidpointRounding.ToEven);
                        txtDensity.Text = "0";
                        txtDensity.SelectAll();

                        this.dgvDensity.CurrentCell = this.dgvDensity[0, this.dgvDensity.Rows.Count - 1];

                        calculateDensityAverage();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Calidad", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void dgvDensity_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            calculateDensityAverage();
        }

        private void dgvDensity_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            calculateDensityAverage();
        }

        private void btnAddCutQuality_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectCoil != 0 || selectMainCoil != 0)
                {
                    //objMainCoilQualityMetalCut = new clsMainCoilQualityMetalCut();
                    //objMainCoilQualityMetalCut = clsMainCoilQualityMetalCut.getQualityByCoil(selectCoil);
                    //if (objMainCoilQualityMetalCut.codsec > 0)
                    //{
                    objMainCoilQualityMetalCut.tape = cmbDensityTaper.SelectedItem.ToString();
                    objMainCoilQualityMetalCut.fkcoil = selectCoil;
                    objMainCoilQualityMetalCut.fkmaincoil = selectMainCoil;
                    objMainCoilQualityMetalCut.notes = txtNotesAnalist.Text;
                    objMainCoilQualityMetalCut.labRating = cmbDensityCalification.SelectedItem.ToString();
                    objMainCoilQualityMetalCut.analistRating = cmbDensityCalification.SelectedItem.ToString();
                    setDensityValues("toSave", objMainCoilQualityMetalCut.fkcoil);
                    setSealTemperatureValuesCoil("toSave");
                    if (objMainCoilQualityMetalCut.save())
                    {
                        selectCoil = 0;
                        selectMainCoil = 0;
                        MessageBox.Show("El control de calidad de la rollo madre metalizado se ha guardado con éxito.", "Control de calidad", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Control de calidad", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    //}
                    //else
                    //{
                    //    objMainCoilQualityMetalCut.tape = cmbDensityTaper.SelectedItem.ToString();
                    //    objMainCoilQualityMetalCut.notes = txtNotesAnalist.Text;
                    //    objMainCoilQualityMetalCut.labRating = cmbDensityCalification.SelectedItem.ToString();
                    //    objMainCoilQualityMetalCut.analistRating = cmbDensityCalification.SelectedItem.ToString();
                    //}
                }
                else
                    MessageBox.Show("Debe seleccionar al menos una bobina", "Calidad", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                //for (int i = 0; i < lstMainCoilMetal.Count; i++)
                //{
                //    lstMainCoilMetal[i].gramaje = Convert.ToDouble(dgvGramaje.Rows[i].Cells[clmGramajeGramaje.Index].Value);
                //    lstMainCoilMetal[i].analistRating = dgvRating.Rows[i].Cells[clmQualityRanking.Index].Value.ToString();
                //    lstMainCoilMetal[i].labRating = dgvRating.Rows[i].Cells[clmQualityRanking.Index].Value.ToString();
                //    lstMainCoilMetal[i].save();
                //}

                //setThiknessValues("toSave");
                //setSealTemperatureNTFValues("toSave");
                //objMainCoilQualityMetal.cof = Convert.ToDouble(txtOpacityTransmitanceAverage.Text);
                //objMainCoilQualityMetal.gramaje = Convert.ToDouble(dgvGramaje.Rows[0].Cells[clmGramajeGramaje.Index].Value);
                //objMainCoilQualityMetal.seal = Convert.ToInt32(txtSealTemperatureNonTreatedFace.Text);
                //objMainCoilQualityMetal.tape = cmbTape.SelectedItem.ToString();
                //objMainCoilQualityMetal.notes = txtFisicStatus.Text;
                //objMainCoilQualityMetal.lstMainCoilMetal = lstMainCoilMetal;

                //if (objMainCoilQualityMetal.save())
                //    MessageBox.Show("El control de calidad de la rollo madre metalizado se ha guardado con éxito.", "Control de calidad", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                //else
                //    MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Control de calidad", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Calidad", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void chkbDensity_CheckedChanged(object sender, EventArgs e)
        {
            calculateDensityAverage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (clsGlobal.isNumeric(txtDensity.Text) == false)
            {
                MessageBox.Show("El valor debe ser Numérico");
                txtDensity.Text = "0";
                txtDensity.SelectAll();
            }
            else
            {
                dgvDensity.Rows.Add();
                dgvDensity.Rows[dgvDensity.Rows.Count - 1].Cells[clmdensitynumber.Index].Value = dgvDensity.Rows.Count;
                dgvDensity.Rows[dgvDensity.Rows.Count - 1].Cells[clmdensitydensity.Index].Value = Math.Round(Convert.ToDouble(txtDensity.Text), 3, MidpointRounding.ToEven);
                txtDensity.Text = "0";
                txtDensity.SelectAll();

                this.dgvDensity.CurrentCell = this.dgvDensity[0, this.dgvDensity.Rows.Count - 1];

                calculateDensityAverage();
            }
        }

        private void btnDensity01_Click(object sender, EventArgs e)
        {
            txtDensitySuperficial02.Text = txtDensitySuperficial01.Text;
            txtDensitySuperficial03.Text = txtDensitySuperficial01.Text;
        }

        private void btnDensity02_Click(object sender, EventArgs e)
        {
            txtDensitySuperficial05.Text = txtDensitySuperficial04.Text;
            txtDensitySuperficial06.Text = txtDensitySuperficial04.Text;
        }
    }
}