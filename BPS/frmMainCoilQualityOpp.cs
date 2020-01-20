using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms; 
using ZedGraph;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmMainCoilQualityOpp : Form
    {
        List<clsMainCoil> lstMainCoil = new List<clsMainCoil>();
        clsMainCoil objMainCoil = new clsMainCoil();
        clsMainCoilQuality objMainCoilQuality = new clsMainCoilQuality();
        List<string> lstAppearance = new List<string>();
        private string getValuesFromControl(System.Windows.Forms.Control container, string controlType)
        {
            string result = "";
            switch (controlType.ToUpper())
            {
                case "TEXTBOX":

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

                case "CHECKBOX":

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
                    if (lstDoubleValues.Count == lstTextBox.Count)
                    {
                        for (int i = 0; i < lstTextBox.Count; i++)
                            lstTextBox[i].Text = lstDoubleValues[i].ToString();
                    }
                    break;
                
                case "textBoxString":

                    List<string> lstStringValues = clsGlobal.getStringListFromString(values);
                    foreach (System.Windows.Forms.Control ctrl in container.Controls)
                    {
                        if (object.ReferenceEquals(ctrl.GetType(), typeof(System.Windows.Forms.TextBox)))
                            lstTextBox.Add(((TextBox)ctrl));
                    }

                    lstTextBox.Sort(delegate(TextBox txt1, TextBox txt2) { return txt1.TabIndex.CompareTo(txt2.TabIndex); });
                    if (lstStringValues.Count == lstTextBox.Count)
                    {
                        for (int i = 0; i < lstStringValues.Count; i++)
                            lstTextBox[i + 1].Text = lstStringValues[i].ToString();
                    }
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
                    if (lstBoolValues.Count == lstTextBox.Count)
                    {
                        for (int i = 0; i < lstCheckBox.Count; i++)
                            lstCheckBox[i].Checked = lstBoolValues[i];
                    }
                    break;

                default:
                    break;
            }
        }

        private void calculateSealStrengthTFAverage()
        {
            double sum = 0;
            if (clsGlobal.isNumeric(txtOpacityTransmittance1.Text))
            {
                sum += Convert.ToDouble(txtSealStrengthTF1.Text);
                sum += Convert.ToDouble(txtSealStrengthTF2.Text);
                sum += Convert.ToDouble(txtSealStrengthTF3.Text);

            }

            txtSealStrengthTFAverage.Text = Math.Round(sum / 3, 2).ToString();
        }


        private void calculateSealTemperatureTFAverage()
        {
            double sum = 0;
            if (clsGlobal.isNumeric(txtHSealTF1.Text))
            {
                sum += Convert.ToDouble(txtHSealTF1.Text);
                sum += Convert.ToDouble(txtHSealTF2.Text);
                sum += Convert.ToDouble(txtHSealTF3.Text);

            }

            txtHSealTFAverage.Text = Math.Round(sum / 3, 2).ToString();
        }

        private void calculateSealTemperatureNTFAverage()
        {
            double sum = 0;
            if (clsGlobal.isNumeric(txtHSealNTF1.Text))
            {
                sum += Convert.ToDouble(txtHSealNTF1.Text);
                sum += Convert.ToDouble(txtHSealNTF2.Text);
                sum += Convert.ToDouble(txtHSealNTF3.Text);

            }

            txtHSealNTFAverage.Text = Math.Round(sum / 3, 2).ToString();
        }

        private void calculateSealStrengthNTFAverage()
        {
            double sum = 0;
            if (clsGlobal.isNumeric(txtOpacityTransmittance1.Text))
            {
                sum += Convert.ToDouble(txtSealStrengthNTF1.Text);
                sum += Convert.ToDouble(txtSealStrengthNTF2.Text);
                sum += Convert.ToDouble(txtSealStrengthNTF3.Text);

            }

            txtSealStrengthTFAverage.Text = Math.Round(sum / 3, 2).ToString();
        }
        private void calculateOpcacityAverage()
        {
            double sum = 0;
            if (clsGlobal.isNumeric(txtOpacityTransmittance1.Text))
            {
                sum += Convert.ToDouble(txtOpacityTransmittance1.Text);
                sum += Convert.ToDouble(txtOpacityTransmittance2.Text);
                sum += Convert.ToDouble(txtOpacityTransmittance3.Text);
               
            }

            txtOpacityTransmitanceAverage.Text = Math.Round(sum / 3, 2).ToString();
        }

        private void calculateTearMDAAverage()
        {
            double sum = 0;
            if (clsGlobal.isNumeric(txtTearMDA1.Text))
            {
                sum += Convert.ToDouble(txtTearMDA1.Text);
                sum += Convert.ToDouble(txtTearMDA2.Text);
                sum += Convert.ToDouble(txtTearMDA3.Text);

            }

            txtTearMDAAverage.Text = Math.Round(sum / 3, 2).ToString();
        }

        private void calculateTearTDAAverage()
        {
            double sum = 0;
            if (clsGlobal.isNumeric(txtTearTDA1.Text))
            {
                sum += Convert.ToDouble(txtTearTDA1.Text);
                sum += Convert.ToDouble(txtTearTDA2.Text);
                sum += Convert.ToDouble(txtTearTDA3.Text);

            }

            txtTearTDAAverage.Text = Math.Round(sum / 3, 2).ToString();
        }

        private void calculateDartImpactTFAverage()
        {
            double sum = 0;
            if (clsGlobal.isNumeric(txtDartImpactTF1.Text))
            {
                sum += Convert.ToDouble(txtDartImpactTF1.Text);
                sum += Convert.ToDouble(txtDartImpactTF2.Text);
                sum += Convert.ToDouble(txtDartImpactTF3.Text);

            }

            txtDartImpactTFAverage.Text = Math.Round(sum / 3, 2).ToString();
        }

        private void calculateDartImpactNTFAverage()
        {
            double sum = 0;
            if (clsGlobal.isNumeric(txtDartImpactNTF1.Text))
            {
                sum += Convert.ToDouble(txtDartImpactNTF1.Text);
                sum += Convert.ToDouble(txtDartImpactNTF2.Text);
                sum += Convert.ToDouble(txtDartImpactNTF3.Text);

            }

            txtDartImpactNTFAverage.Text = Math.Round(sum / 3, 2).ToString();
        }

        private void calculateThiknessAverage()
        {
            double average, sum, variance, sumForVariance, desviation;

            sum = 0;
            sumForVariance = 0;

            if (chkAverage.Checked == false)
            {
                for (int i = 0; i < dgvThikness.Rows.Count; i++)
                    sum += Convert.ToDouble(dgvThikness.Rows[i].Cells[clmThiknessValue.Index].Value);

                average = Math.Round((sum / dgvThikness.Rows.Count), 2);
                txtAverage.Text = average.ToString();

                for (int i = 0; i < dgvThikness.Rows.Count; i++)
                    sumForVariance += Math.Pow((Convert.ToDouble(dgvThikness.Rows[i].Cells[clmThiknessValue.Index].Value) - average), 2);

                variance = Math.Round((sumForVariance / dgvThikness.Rows.Count), 2);
                desviation = Math.Round(Math.Sqrt(variance), 2);
                txtStandardDeviation.Text = desviation.ToString();
            }
            else
            {
                for (int i = 1; i < dgvThikness.Rows.Count - 1; i++)
                    sum += Convert.ToDouble(dgvThikness.Rows[i].Cells[clmThiknessValue.Index].Value);

                average = Math.Round((sum / (dgvThikness.Rows.Count - 2)), 2);
                txtAverage.Text = average.ToString();

                for (int i = 1; i < dgvThikness.Rows.Count - 1; i++)
                    sumForVariance += Math.Pow((Convert.ToDouble(dgvThikness.Rows[i].Cells[clmThiknessValue.Index].Value) - average), 2);
                
                variance = Math.Round((sumForVariance / (dgvThikness.Rows.Count - 2)), 2);
                desviation = Math.Round(Math.Sqrt(variance), 2);
                txtStandardDeviation.Text = desviation.ToString();
            }

            drawOutline();

            List<double> lstThikness = new List<double>();
            for (int i = 0; i < dgvThikness.Rows.Count; i++)
                lstThikness.Add(Convert.ToDouble(dgvThikness.Rows[i].Cells[clmThiknessValue.Index].Value));
        }

        private void drawOutline()
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
                upDesviationPoints.Add(i + 1, (Convert.ToDouble(txtAverage.Text) + (Convert.ToDouble(txtStandardDeviation.Text))));
                downDesviationPoints.Add(i + 1, (Convert.ToDouble(txtAverage.Text) - (Convert.ToDouble(txtStandardDeviation.Text))));
            }
            LineItem outLineCurve = zgcProfile.GraphPane.AddCurve("", points, Color.Blue, SymbolType.None);
            LineItem averageCurve = zgcProfile.GraphPane.AddCurve("", averagePoints, Color.Green, SymbolType.None);
            LineItem upDesviationCurve = zgcProfile.GraphPane.AddCurve("", upDesviationPoints, Color.Red, SymbolType.None);
            LineItem downDesviationCurve = zgcProfile.GraphPane.AddCurve("", downDesviationPoints, Color.Red, SymbolType.None);

            zgcProfile.GraphPane.XAxis.Scale.FontSpec.Size = 12;
            zgcProfile.GraphPane.YAxis.Scale.FontSpec.Size = 12;
            
            zgcProfile.AxisChange();
            zgcProfile.Refresh();

        }

        private void setThiknessValues(string destination)
        {
            switch (destination)
            {
                case "toSave":

                    objMainCoilQuality.thikness = "";
                    objMainCoilQuality.thiknessList = new List<double>();
                    for (int i = 0; i < dgvThikness.Rows.Count; i++)
                    {
                        objMainCoilQuality.thikness += dgvThikness.Rows[i].Cells[clmThiknessValue.Index].Value.ToString();
                        objMainCoilQuality.thikness += (i < dgvThikness.Rows.Count - 1) ? ";" : "";
                        objMainCoilQuality.thiknessList.Add(Convert.ToDouble(dgvThikness.Rows[i].Cells[clmThiknessValue.Index].Value));
                    }
                    objMainCoilQuality.thiknessAverage = Convert.ToDouble(txtAverage.Text);
                    objMainCoilQuality.thiknessDesviation = Convert.ToDouble(txtStandardDeviation.Text);
                    break;

                case "toLoad":
                    dgvThikness.Rows.Clear();
                    for (int i = 0; i < objMainCoilQuality.thiknessList.Count; i++)
                    {
                        dgvThikness.Rows.Add();
                        dgvThikness.Rows[i].Cells[clmNumber.Index].Value = Convert.ToString(i + 1);
                        dgvThikness.Rows[i].Cells[clmThiknessValue.Index].Value = objMainCoilQuality.thiknessList[i].ToString();
                    }
                    drawOutline();
                    txtAverage.Text = Convert.ToString(Math.Round(objMainCoilQuality.thiknessAverage, 2));
                    txtStandardDeviation.Text = Convert.ToString(Math.Round(objMainCoilQuality.thiknessDesviation, 2));
                    calculateThiknessAverage();
                    break;

                default:
                    break;
            }
        }

        private void setOpacityTransmitanceValues(string destination)
        {
            switch (destination)
            {
                case "toSave":
                    
                    objMainCoilQuality.opacityTransmittanceValues = getValuesFromControl(grpbOpacityTransmittance, "textBox");
                    objMainCoilQuality.opacityTransmittanceList = clsGlobal.getDoubleListFromString(objMainCoilQuality.opacityTransmittanceValues);
                    break;
                case "toLoad":
                    
                    setValuesToControl(grpbOpacityTransmittance, "textBox", objMainCoilQuality.opacityTransmittanceValues);
                    break;
                default:
                    break;
            }
        }

        private void setSurfaceTensionValues(string destination)
        {
            switch (destination)
            {
                case "toSave":
                    objMainCoilQuality.surfaceTensionValues = getValuesFromControl(grpbSurfaceTension,"textBox");
                    objMainCoilQuality.surfaceTensionList = clsGlobal.getDoubleListFromString(objMainCoilQuality.surfaceTensionValues);                    
                    break;

                case "toLoad":
                    setValuesToControl(grpbSurfaceTension, "textBox", objMainCoilQuality.surfaceTensionValues);
                    break;
                default:
                    break;
            }
            
        }

        private void setBackSideValues(string destination)
        {
            switch (destination)
            {
                case "toSave":
                    objMainCoilQuality.backSideValues = getValuesFromControl(grpbBackSide, "checkBox");
                    objMainCoilQuality.bakSideList = clsGlobal.getBooleanListFromString(objMainCoilQuality.backSideValues);

                    break;
                case "toLoad":
                    setValuesToControl(grpbBackSide, "checkBox", objMainCoilQuality.backSideValues);
                    break;
                default:
                    break;
            }
        }

        private void setSealTemperatureTFValues(string destination)
        {
            switch (destination)
            {
                case "toSave":
                    //objMainCoilQuality.SealTemperatureTF = Convert.ToDouble(txtSealTemperatureTreatedFace.Text);
                    objMainCoilQuality.sealTemperatureTFValues = getValuesFromControl(grpHSealTF, "textbox");
                    objMainCoilQuality.sealTemperatureTFList = clsGlobal.getBooleanListFromString(objMainCoilQuality.sealTemperatureTFValues);

                    break;
                case "toLoad":
                    //txtSealTemperatureTreatedFace.Text = objMainCoilQuality.SealTemperatureTF.ToString();
                    setValuesToControl(grpHSealTF, "textbox", objMainCoilQuality.sealTemperatureTFValues);
                    break;
                default:
                    break;
            }
        }

        private void setSealTemperatureNTFValues(string destination)
        {
            switch (destination)
            {
                case "toSave":                    
                    objMainCoilQuality.sealTemperatureNTFValues = getValuesFromControl(grpHSealNTF, "textbox");
                    objMainCoilQuality.sealTemperatureNTFList = clsGlobal.getBooleanListFromString(objMainCoilQuality.sealTemperatureNTFValues);
                    break;
                case "toLoad":                    
                    setValuesToControl(grpHSealNTF, "textbox", objMainCoilQuality.sealTemperatureNTFValues);
                    break;
                default:
                    break;
            }
        }

                
        private void setFrictionCoefficentTFValues(string destination)
        {
            switch (destination)
            {
                case "toSave":
                    objMainCoilQuality.frictionCoefficientTFValues = getValuesFromControl(grpbFrictionCoefficientTF, "textBox");
                    objMainCoilQuality.frictionCoefficientTFList = clsGlobal.getDoubleListFromString(objMainCoilQuality.frictionCoefficientTFValues);
                    objMainCoilQuality.frictionCoefficientTFAverage = Convert.ToDouble(txtFrictionCoefficientTFAverage.Text);

                    break;
                case "toLoad":
                    txtFrictionCoefficientTFAverage.Text = objMainCoilQuality.frictionCoefficientTFAverage.ToString();
                    setValuesToControl(grpbFrictionCoefficientTF, "textBox", objMainCoilQuality.frictionCoefficientTFValues);
                    break;
                default:
                    break;
            }
        }

        private void setFrictionCoefficentNTFValues(string destination)
        {
            switch (destination)
            {
                case "toSave":
                    objMainCoilQuality.frictionCoefficientNTFValues = getValuesFromControl(grpbFrictionCoefficientNTF,"textBox");
                    objMainCoilQuality.frictionCoefficientNTFList = clsGlobal.getDoubleListFromString(objMainCoilQuality.frictionCoefficientNTFValues);
                    objMainCoilQuality.frictionCoefficientNTFAverage = Convert.ToDouble(txtFrictionCoefficientNTFAverage.Text);
                    break;

                case "toLoad":
                    txtFrictionCoefficientNTFAverage.Text = objMainCoilQuality.frictionCoefficientNTFAverage.ToString();
                    setValuesToControl(grpbFrictionCoefficientNTF, "textBox", objMainCoilQuality.frictionCoefficientNTFValues);
                    break;
                default:
                    break;
            }
        }

        private void setGlossValue(string destination)
        {
            switch (destination)
            {
                case "toSave":
                    objMainCoilQuality.GlossValues = getValuesFromControl(grpbGloss, "textBox");
                    objMainCoilQuality.GlossList = clsGlobal.getDoubleListFromString(objMainCoilQuality.GlossValues);
                    objMainCoilQuality.GlossAverage = Convert.ToDouble(txtGlossAverage.Text);
                    objMainCoilQuality.GlossDesviation = Convert.ToDouble(txtGlossDesviation.Text);
                    break;
                case "toLoad":
                    txtGlossAverage.Text = objMainCoilQuality.GlossAverage.ToString();
                    txtGlossDesviation.Text = objMainCoilQuality.GlossDesviation.ToString();
                    setValuesToControl(grpbGloss, "textBox", objMainCoilQuality.GlossValues);
                    break;
                default:
                    break;
            }
        }

        private void setTearMDValues(string destination)
        {
            switch (destination)
            {
                case "toSave":
                    objMainCoilQuality.tearMDValues  = getValuesFromControl(grpTearMDA, "textBox");
                    objMainCoilQuality.tearMDAList  = clsGlobal.getDoubleListFromString(objMainCoilQuality.tearMDValues);
                    break;
                case "toLoad":
                    setValuesToControl(grpTearMDA, "textBox", objMainCoilQuality.tearMDValues);
                    break;
                default:
                    break;
            }
        }

        private void setTearTDValues(string destination)
        {
            switch (destination)
            {
                case "toSave":
                    objMainCoilQuality.tearTDValues = getValuesFromControl(grpTearTDA, "textBox");
                    objMainCoilQuality.tearTDAList = clsGlobal.getDoubleListFromString(objMainCoilQuality.tearTDValues);
                    break;
                case "toLoad":
                    setValuesToControl(grpTearTDA, "textBox", objMainCoilQuality.tearTDValues);
                    break;
                default:
                    break;
            }
        }
        private void setSealStrengthValuesTF(string destination)
        {
            switch (destination)
            {
                case "toSave":
                    objMainCoilQuality.sealStrengthValuesTF = getValuesFromControl(grpbSealStrengthTF, "textBox");
                    objMainCoilQuality.sealStrengthListTF = clsGlobal.getDoubleListFromString(objMainCoilQuality.sealStrengthValuesTF);
                    break;
                case "toLoad":
                    setValuesToControl(grpbSealStrengthTF, "textBox", objMainCoilQuality.sealStrengthValuesTF);
                    break;
                default:
                    break;
            }
        }

        private void setSealStrengthValuesNTF(string destination)
        {
            switch (destination)
            {
                case "toSave":
                    objMainCoilQuality.sealStrengthValuesNTF = getValuesFromControl(grpbSealStrengthNTF, "textBox");
                    objMainCoilQuality.sealStrengthListNTF = clsGlobal.getDoubleListFromString(objMainCoilQuality.sealStrengthValuesNTF);
                    break;
                case "toLoad":
                    setValuesToControl(grpbSealStrengthNTF, "textBox", objMainCoilQuality.sealStrengthValuesNTF);
                    break;
                default:
                    break;
            }
        }
        
        private void calculateTotals()
        {
            if (dgvGramaje.SelectedRows.Count > 0)
                dgvGramaje.Rows[dgvGramaje.SelectedRows[0].Index].Cells[clmGramajeWeight.Index].Value = Convert.ToString(Math.Round(((lstMainCoil[dgvGramaje.SelectedRows[0].Index].grosslength  * lstMainCoil[dgvGramaje.SelectedRows[0].Index].width * Convert.ToDouble(dgvGramaje.Rows[dgvGramaje.SelectedRows[0].Index].Cells[clmGramajeGramaje.Index].EditedFormattedValue)) / 1000 / 1000), 2));
        }
        private void loadMainCoilData(clsMainCoil objMainCoilToShow)
        {
            List<clsFormulationByFilmProductionPlan> lstFormulations = clsFormulationByFilmProductionPlan.getListByFilmProductionPlan(objMainCoilToShow.fkFilmProductionPlan);

            lblOrderNumber.Text = objMainCoilToShow.ProductionOrderNumber.ToString();
            if (objMainCoilToShow.fkBopp > 0)
                lblFilmType.Text = objMainCoilToShow.BoppCode;
            else
                lblFilmType.Text = objMainCoilToShow.CastCode;
            lblCode.Text = objMainCoilToShow.code;
            lblLot.Text = objMainCoilToShow.lotNumber;
            lblVariation.Text = objMainCoilToShow.variation.ToString();
            lblMachine.Text = objMainCoilToShow.MachineName;
            lblCoilerNumber.Text = objMainCoilToShow.code.Substring(4, 1);
            lblInitDate.Text = objMainCoilToShow.initDate.ToString("dd/MM/yyyy HH:mm:ss");
            lblEndDate.Text = objMainCoilToShow.endDate.ToString("dd/MM/yyyy HH:mm:ss");
            TimeSpan span = objMainCoilToShow.endDate.Subtract(objMainCoil.initDate);
            lblHours.Text = Convert.ToString((Math.Round(span.TotalHours, 2)));
            lblFormulation.Text = lstFormulations[objMainCoilToShow.variation].formulationName;
            lblKgPerHour.Text = objMainCoilToShow.productionKgHr.ToString();
            lblVelocity.Text = objMainCoilToShow.velocity.ToString();
            lblGramaje.Text = objMainCoilToShow.gramaje.ToString();
            lblLength.Text = objMainCoilToShow.grosslength.ToString();
            lblWidht.Text = objMainCoilToShow.width.ToString();
            lblWeight.Text = objMainCoilToShow.grossWeigth.ToString();
            lblNetLength.Text = objMainCoilToShow.netlength.ToString();
            lblNetWeigth.Text = objMainCoilToShow.netWeigth.ToString();
            lblDate.Text = objMainCoilToShow.createdDate.ToString("dd/MM/yyyy HH:mm:ss");
            lblOperator.Text = objMainCoilToShow.creatorUser;
            lblNotes.Text = objMainCoilToShow.notes;
            lblSupervisor.Text = objMainCoilToShow.supervisorName;
            lblOperator.Text = objMainCoilToShow.operatorName;
            lblCoiler.Text = objMainCoilToShow.coilerName;
        }
        private void loadQualityData(clsMainCoil objMainCoilToShow)
        {
            List<double> lstThikness = new List<double>();
            List<clsMainCoil> lstMainCoilByQuality = new List<clsMainCoil>();

            objMainCoilQuality = clsMainCoilQuality.getQualityByMainCoil(objMainCoilToShow.codsec);

            if (objMainCoilQuality.codsec > 0)
            {
                lstMainCoilByQuality = clsMainCoil.getBoppMainCoilListByQualityReport(objMainCoilQuality.codsec);
                
                lstbCoilsToQualify.Items.Clear();

                for (int i = 0; i < lstMainCoilByQuality.Count; i++)
                    lstbCoilsToQualify.Items.Add(lstMainCoilByQuality[i]);

                lstMainCoil.Clear();
                lstMainCoil = lstMainCoilByQuality;

                dgvGramaje.Rows.Clear();

                for (int i = 0; i < lstMainCoil.Count; i++)
                {
                    dgvGramaje.Rows.Add();
                    dgvGramaje.Rows[i].Cells[clmGramajeMainCoilCodsec.Index].Value = lstMainCoil[i].codsec;
                    dgvGramaje.Rows[i].Cells[clmGramajeMainCoilCode.Index].Value = lstMainCoil[i].code;
                    dgvGramaje.Rows[i].Cells[clmGramajeGramaje.Index].Value = Math.Round(lstMainCoil[i].gramaje, 2).ToString();
                    dgvGramaje.Rows[i].Cells[clmGramajeWeight.Index].Value = Math.Round(lstMainCoil[i].netWeigth, 2).ToString();

                    dgvRating.Rows.Add();
                    dgvRating.Rows[i].Cells[clmQualityMainCoilCodsec.Index].Value = lstMainCoil[i].codsec;
                    dgvRating.Rows[i].Cells[clmQualityMainCoilCode.Index].Value = lstMainCoil[i].code;
                    dgvRating.Rows[i].Cells[clmQualityRanking.Index].Value = lstMainCoil[i].labRating;
                }
            }            

            if (objMainCoilQuality.codsec > 0)
            {
                rdoyTransmittance.Checked = objMainCoilQuality.transmittanceEvaluated;
                rdoOpacity.Checked = objMainCoilQuality.opacityEvaluated;
                txttreatmentvalues.Text = objMainCoilQuality.treatmentValues;
                cbostatictTF.Text = objMainCoilQuality.statictTF;
                cbostatictNTF.Text = objMainCoilQuality.staticNTF;
                //txtOperatorCriterial.Text = objMainCoilQuality.operatorCriterial;
                //txtFisicStatus.Text = objMainCoilQuality.fisicStatus;
                setThiknessValues("toLoad");
                setOpacityTransmitanceValues("toLoad");
                setSurfaceTensionValues("toLoad");
                setBackSideValues("toLoad");
                setSealTemperatureTFValues("toLoad");
                setSealTemperatureNTFValues("toLoad");
                //setAppearanceValues("toLoad");
                setFrictionCoefficentTFValues("toLoad");
                setFrictionCoefficentNTFValues("toLoad");
                setGlossValue("toLoad");
                setSealStrengthValuesTF("toLoad");
                setSealStrengthValuesNTF("toLoad");
                dtpReceptionDate.Value = objMainCoilQuality.receptionDate;
                setTearMDValues("toLoad");
                setTearTDValues("toLoad");
            }
            if (objMainCoilQuality.codsec == 0)
            {
                for (int i = 0; i < lstMainCoil.Count; i++)
                {
                    dgvGramaje.Rows.Add();
                    dgvGramaje.Rows[i].Cells[clmGramajeMainCoilCodsec.Index].Value = lstMainCoil[i].codsec;
                    dgvGramaje.Rows[i].Cells[clmGramajeMainCoilCode.Index].Value = lstMainCoil[i].code;
                    dgvGramaje.Rows[i].Cells[clmGramajeGramaje.Index].Value = Math.Round(lstMainCoil[i].gramaje, 2).ToString();
                    dgvGramaje.Rows[i].Cells[clmGramajeWeight.Index].Value = Math.Round(lstMainCoil[i].netWeigth, 2).ToString();

                    dgvRating.Rows.Add();
                    dgvRating.Rows[i].Cells[clmQualityMainCoilCodsec.Index].Value = lstMainCoil[i].codsec;
                    dgvRating.Rows[i].Cells[clmQualityMainCoilCode.Index].Value = lstMainCoil[i].code;
                    dgvRating.Rows[i].Cells[clmQualityRanking.Index].Value = lstMainCoil[i].labRating;
                }
            }

        }
        public frmMainCoilQualityOpp()
        {
            InitializeComponent();
        }
        public frmMainCoilQualityOpp(int mainCoilCodsec)
        {
            InitializeComponent();
            objMainCoil.load(mainCoilCodsec);
            lstMainCoil.Add(objMainCoil);
            lstbCoilsToQualify.Items.Add(objMainCoil);
        }
        private void frmMainCoilQuality_Load(object sender, EventArgs e)
        {
            
            if (lstMainCoil.Count > 0)
            {
                loadMainCoilData(lstMainCoil[0]);
                //txtOperatorCriterial.Text = lstMainCoil[0].notes;
                loadQualityData(lstMainCoil[0]);
            }
            else
                tbcMainCoilInfo.TabPages.Remove(tbpMainCoilQuality);
        }
        private void txtThikness_KeyDown(object sender, KeyEventArgs e)
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
                    dgvThikness.Rows[dgvThikness.Rows.Count - 1].Cells[clmThiknessValue.Index].Value = Math.Round(Convert.ToDouble(txtThikness.Text), 1).ToString("0.0");
                    txtThikness.Text = "0";
                    txtThikness.SelectAll();

                    this.dgvThikness.CurrentCell = this.dgvThikness[0, this.dgvThikness.Rows.Count - 1];

                    calculateThiknessAverage();
                }
            }
        }
        private void btnMainCoilSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstMainCoil.Count; i++)
            {
                lstMainCoil[i].grossWeigth = Convert.ToDouble(dgvGramaje.Rows[i].Cells[clmGramajeWeight.Index].Value);
                lstMainCoil[i].netWeigth = Convert.ToDouble(dgvGramaje.Rows[i].Cells[clmGramajeWeight.Index].Value); //TODO: calcular quitando los desperdicios
                lstMainCoil[i].gramaje = Convert.ToDouble(dgvGramaje.Rows[i].Cells[clmGramajeGramaje.Index].Value);
                lstMainCoil[i].analistRating = dgvRating.Rows[i].Cells[clmQualityRanking.Index].Value.ToString();
                lstMainCoil[i].labRating = dgvRating.Rows[i].Cells[clmQualityRanking.Index].Value.ToString();
                lstMainCoil[i].save();
            }

            setThiknessValues("toSave");

            objMainCoilQuality.opacityEvaluated = rdoOpacity.Checked;
            objMainCoilQuality.transmittanceEvaluated = rdoyTransmittance.Checked;

            if (rdoyTransmittance.Checked == true)
                objMainCoilQuality.transmittanceEvaluatedInt = 1;
            else
                objMainCoilQuality.transmittanceEvaluatedInt = 0;

            if (rdoOpacity.Checked == true)
                objMainCoilQuality.opacityEvaluatedInt = 1;
            else
                objMainCoilQuality.opacityEvaluatedInt = 0;

            setOpacityTransmitanceValues("toSave");

            setSurfaceTensionValues("toSave");

            setBackSideValues("toSave");

            setSealTemperatureTFValues("toSave");
            setSealTemperatureNTFValues("toSave");

            //setAppearanceValues("toSave");

            objMainCoilQuality.treatmentValues = txttreatmentvalues.Text;
            objMainCoilQuality.statictTF = cbostatictTF.Text;
            objMainCoilQuality.staticNTF = cbostatictNTF.Text;

            //objMainCoilQuality.operatorCriterial = txtOperatorCriterial.Text;
            //objMainCoilQuality.fisicStatus = txtFisicStatus.Text;

            setFrictionCoefficentTFValues("toSave");
            setFrictionCoefficentNTFValues("toSave");
            setGlossValue("toSave");

            setSealStrengthValuesTF("toSave");
            setSealStrengthValuesNTF("toSave");
            setTearMDValues("toSave");
            setTearTDValues("toSave");
            objMainCoilQuality.receptionDate = dtpReceptionDate.Value;
            objMainCoilQuality.createdDate = DateTime.Now;
            objMainCoilQuality.createdBy = clsGlobal.LoggedUser.codsec;
            objMainCoilQuality.ModifiedDate = DateTime.Now;
            objMainCoilQuality.modifiedBy = clsGlobal.LoggedUser.codsec;
            objMainCoilQuality.lstMainCoil = lstMainCoil;

            if (objMainCoilQuality.save())
            {
                MessageBox.Show("El control de calidad de la rollo madre se ha guardado con éxito.", "Control de calidad", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                
            }
            else
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Control de calidad", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            
        }

        private void btnMainCoilCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cancelar el control de calidad de esta rollo madre?", "Control de calidad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
            {
                frmMainCoilList winMainCoilList = new frmMainCoilList();
                winMainCoilList.StartPosition = FormStartPosition.Manual;
                winMainCoilList.MdiParent = this.MdiParent;
                winMainCoilList.Show();
                this.Close();
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
                dgvThikness.Rows[dgvThikness.Rows.Count - 1].Cells[clmThiknessValue.Index].Value = Math.Round(Convert.ToDouble(txtThikness.Text), 1).ToString("0.0");
                txtThikness.Text = "0";
                txtThikness.SelectAll();
                this.dgvThikness.CurrentCell = this.dgvThikness[0, this.dgvThikness.Rows.Count- 1];
                calculateThiknessAverage();
            }
        }

        private void btnMainCoilExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void frmMainCoilQuality_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMainCoilList winMainCoilList = new frmMainCoilList();
            winMainCoilList.MdiParent = this.MdiParent;
            winMainCoilList.Show();
        }

        private void chkAverage_CheckedChanged(object sender, EventArgs e)
        {
            calculateThiknessAverage();
        }

        private void txtOpacityTransmittance1_TextChanged(object sender, EventArgs e)
        {
            calculateOpcacityAverage();
        }

        private void txtOpacityTransmittance2_TextChanged(object sender, EventArgs e)
        {
            calculateOpcacityAverage();
        }

        private void txtOpacityTransmittance3_TextChanged(object sender, EventArgs e)
        {
            calculateOpcacityAverage();
        }

        private void txtOpacityTransmittance4_TextChanged(object sender, EventArgs e)
        {
            calculateOpcacityAverage();
        }

        private void txtOpacityTransmittance5_TextChanged(object sender, EventArgs e)
        {
            calculateOpcacityAverage();
        }

        private void txtOpacityTransmittance6_TextChanged(object sender, EventArgs e)
        {
            calculateOpcacityAverage();
        }

        private void txtOpacityTransmittance7_TextChanged(object sender, EventArgs e)
        {
            calculateOpcacityAverage();
        }

        private void txtOpacityTransmittance8_TextChanged(object sender, EventArgs e)
        {
            calculateOpcacityAverage();
        }

        private void txtOpacityTransmittance9_TextChanged(object sender, EventArgs e)
        {
            calculateOpcacityAverage();
        }

        private void txtOpacityTransmittance10_TextChanged(object sender, EventArgs e)
        {
            calculateOpcacityAverage();             
        }

        //private void btnAddAppearance_Click(object sender, EventArgs e)
        //{
        //    lstAppearance.Add(txtAppearance.Text);
        //    lstbAppearance.Items.Clear();
        //    for (int i = 0; i < lstAppearance.Count; i++)
        //        lstbAppearance.Items.Add((i + 1).ToString() + ". " + lstAppearance[i]);
        //}

        //private void lstbAppearance_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        if (this.lstbAppearance.SelectedItem != null)
        //            this.lstbAppearance.DoDragDrop(this.lstbAppearance.SelectedItem, DragDropEffects.All);                
        //    }
        //}

        private void textBox10_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListBox)))
                e.Effect = DragDropEffects.Move;
        }

        //private void textBox10_DragDrop(object sender, DragEventArgs e)
        //{
        //    txtAppearanceValue1.Text = lstbAppearance.SelectedItem.ToString().Substring(0, 1);
        //}

        private void txtAppearanceValue1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void txtAppearanceValue2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListBox)))
                e.Effect = DragDropEffects.Move;
        }

        //private void txtAppearanceValue2_DragDrop(object sender, DragEventArgs e)
        //{
        //    txtAppearanceValue2.Text = lstbAppearance.SelectedItem.ToString().Substring(0, 1);

        //}

        private void txtAppearanceValue2_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void txtAppearanceValue3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListBox)))
                e.Effect = DragDropEffects.Move;
        }

        //private void txtAppearanceValue3_DragDrop(object sender, DragEventArgs e)
        //{
        //    txtAppearanceValue3.Text = lstbAppearance.SelectedItem.ToString().Substring(0, 1);
        //}

        private void txtAppearanceValue3_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void txtAppearanceValue4_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListBox)))
                e.Effect = DragDropEffects.Move;
        }

        //private void txtAppearanceValue4_DragDrop(object sender, DragEventArgs e)
        //{
        //    txtAppearanceValue4.Text = lstbAppearance.SelectedItem.ToString().Substring(0, 1);
        //}

        private void txtAppearanceValue4_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void txtAppearanceValue5_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListBox)))
                e.Effect = DragDropEffects.Move;
        }

        //private void txtAppearanceValue5_DragDrop(object sender, DragEventArgs e)
        //{
        //    txtAppearanceValue5.Text = lstbAppearance.SelectedItem.ToString().Substring(0, 1);
        //}

        private void txtAppearanceValue5_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void txtAppearanceValue6_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListBox)))
                e.Effect = DragDropEffects.Move;
        }

        //private void txtAppearanceValue6_DragDrop(object sender, DragEventArgs e)
        //{
        //    txtAppearanceValue6.Text = lstbAppearance.SelectedItem.ToString().Substring(0, 1);
        //}

        private void txtAppearanceValue6_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void txtAppearanceValue7_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListBox)))
                e.Effect = DragDropEffects.Move;
        }

        //private void txtAppearanceValue7_DragDrop(object sender, DragEventArgs e)
        //{
        //    txtAppearanceValue7.Text = lstbAppearance.SelectedItem.ToString().Substring(0, 1);
        //}

        private void txtAppearanceValue7_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void txtAppearanceValue8_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListBox)))
                e.Effect = DragDropEffects.Move;
        }

        //private void txtAppearanceValue8_DragDrop(object sender, DragEventArgs e)
        //{
        //    txtAppearanceValue8.Text = lstbAppearance.SelectedItem.ToString().Substring(0, 1);
        //}

        private void txtAppearanceValue8_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void txtAppearanceValue9_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListBox)))
                e.Effect = DragDropEffects.Move;
        }

        //private void txtAppearanceValue9_DragDrop(object sender, DragEventArgs e)
        //{
        //    txtAppearanceValue9.Text = lstbAppearance.SelectedItem.ToString().Substring(0, 1);
        //}

        private void txtAppearanceValue9_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void txtAppearanceValue10_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListBox)))
                e.Effect = DragDropEffects.Move;
        }

        //private void txtAppearanceValue10_DragDrop(object sender, DragEventArgs e)
        //{
        //    txtAppearanceValue10.Text = lstbAppearance.SelectedItem.ToString().Substring(0, 1);
        //}

        private void txtAppearanceValue10_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void lblGramaje_TextChanged(object sender, EventArgs e)
        {
            calculateTotals();
        }

        private void txtCoilCodeToQualify_KeyDown(object sender, KeyEventArgs e)
        {
            clsMainCoil objNewMainCoil = new clsMainCoil();
            bool flgInList = false;

            if (e.KeyCode == Keys.Enter)
            {
                objNewMainCoil.load(txtCoilCodeToQualify.Text);
                if (objNewMainCoil.codsec > 0)
                {
                    for (int i = 0; i < lstMainCoil.Count; i++)
                    {
                        if (objNewMainCoil.codsec == lstMainCoil[i].codsec)
                            flgInList = true;
                    }

                    if (flgInList == false)
                    {
                        lstbCoilsToQualify.Items.Add(objNewMainCoil);
                        lstMainCoil.Add(objNewMainCoil);

                        dgvGramaje.Rows.Clear();
                        dgvRating.Rows.Clear();

                        for (int i = 0; i < lstMainCoil.Count; i++)
                        {
                            dgvGramaje.Rows.Add();
                            dgvGramaje.Rows[i].Cells[clmGramajeMainCoilCodsec.Index].Value = lstMainCoil[i].codsec;
                            dgvGramaje.Rows[i].Cells[clmGramajeMainCoilCode.Index].Value = lstMainCoil[i].code;
                            dgvGramaje.Rows[i].Cells[clmGramajeGramaje.Index].Value = Math.Round(lstMainCoil[i].gramaje, 2).ToString();
                            dgvGramaje.Rows[i].Cells[clmGramajeWeight.Index].Value = Math.Round(lstMainCoil[i].netWeigth, 2).ToString();

                            dgvRating.Rows.Add();
                            dgvRating.Rows[i].Cells[clmQualityMainCoilCodsec.Index].Value = lstMainCoil[i].codsec;
                            dgvRating.Rows[i].Cells[clmQualityMainCoilCode.Index].Value = lstMainCoil[i].code;
                            dgvRating.Rows[i].Cells[clmQualityRanking.Index].Value = lstMainCoil[i].labRating;
                        }

                        if (lstMainCoil.Count == 1)
                        {
                            tbcMainCoilInfo.TabPages.Add(tbpMainCoilQuality);
                            loadMainCoilData(objNewMainCoil);
                            //txtOperatorCriterial.Text = objNewMainCoil.notes;
                            loadQualityData(objNewMainCoil);
                        }
                    }
                    txtCoilCodeToQualify.Text = "";
                }
                else
                    MessageBox.Show("El código ingresado no corresponde a ninguna bobina ingresada al sistema.");
            }
        }

        private void lstbCoilsToQualify_SelectedIndexChanged(object sender, EventArgs e)
        {
            objMainCoil = lstMainCoil[lstbCoilsToQualify.SelectedIndex];
            loadMainCoilData(objMainCoil);
        }

        private void btnCopyForwardOpacity_Click(object sender, EventArgs e)
        {
            txtOpacityTransmittance2.Text = txtOpacityTransmittance1.Text;
            txtOpacityTransmittance3.Text = txtOpacityTransmittance1.Text;
            //txtOpacityTransmittance4.Text = txtOpacityTransmittance1.Text;
            //txtOpacityTransmittance5.Text = txtOpacityTransmittance1.Text;
            //txtOpacityTransmittance6.Text = txtOpacityTransmittance1.Text;
            //txtOpacityTransmittance7.Text = txtOpacityTransmittance1.Text;
            //txtOpacityTransmittance8.Text = txtOpacityTransmittance1.Text;
            //txtOpacityTransmittance9.Text = txtOpacityTransmittance1.Text;
            //txtOpacityTransmittance10.Text = txtOpacityTransmittance1.Text;
        }

        private void btnCopyForwardSTTF_Click(object sender, EventArgs e)
        {
            txtSurfaceTension2.Text = txtSurfaceTension1.Text;
            txtSurfaceTension3.Text = txtSurfaceTension1.Text;
            //txtSurfaceTension4.Text = txtSurfaceTension1.Text;
            //txtSurfaceTension5.Text = txtSurfaceTension1.Text;
            //txtSurfaceTension6.Text = txtSurfaceTension1.Text;
            //txtSurfaceTension7.Text = txtSurfaceTension1.Text;
            //txtSurfaceTension8.Text = txtSurfaceTension1.Text;
            //txtSurfaceTension9.Text = txtSurfaceTension1.Text;
            //txtSurfaceTension10.Text = txtSurfaceTension1.Text;
        }

        private void btnCopyForwardSTNTF_Click(object sender, EventArgs e)
        {
            txtSurfaceTensionEF2.Text = txtSurfaceTensionEF1.Text;
            txtSurfaceTensionEF3.Text = txtSurfaceTensionEF1.Text;
            //txtSurfaceTensionEF4.Text = txtSurfaceTensionEF1.Text;
            //txtSurfaceTensionEF5.Text = txtSurfaceTensionEF1.Text;
            //txtSurfaceTensionEF6.Text = txtSurfaceTensionEF1.Text;
            //txtSurfaceTensionEF7.Text = txtSurfaceTensionEF1.Text;
            //txtSurfaceTensionEF8.Text = txtSurfaceTensionEF1.Text;
            //txtSurfaceTensionEF9.Text = txtSurfaceTensionEF1.Text;
            //txtSurfaceTensionEF10.Text = txtSurfaceTensionEF1.Text;
        }

        //private void btnCopyForwardBackSide_Click(object sender, EventArgs e)
        //{
        //    chkBackSide2.Checked = chkBackSide1.Checked;
        //    chkBackSide3.Checked = chkBackSide1.Checked;
        //    chkBackSide4.Checked = chkBackSide1.Checked;
        //    chkBackSide5.Checked = chkBackSide1.Checked;
        //    chkBackSide6.Checked = chkBackSide1.Checked;
        //    chkBackSide7.Checked = chkBackSide1.Checked;
        //    chkBackSide8.Checked = chkBackSide1.Checked;
        //    chkBackSide9.Checked = chkBackSide1.Checked;
        //    chkBackSide10.Checked = chkBackSide1.Checked;
        //}

        private void btnCopyForwardSealTempIF_Click(object sender, EventArgs e)
        {
            chkSealTempTF2.Checked = chkSealTempTF1.Checked;
            chkSealTempTF3.Checked = chkSealTempTF1.Checked;
      
        }

        private void btnCopyForwardSealTempOF_Click(object sender, EventArgs e)
        {
            chkSealTempNTF2.Checked = chkSealTempNTF1.Checked;
            chkSealTempNTF3.Checked = chkSealTempNTF1.Checked;
        }

        private void dgvGramaje_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmGramajeGramaje.Index)
                calculateTotals();
        }

        private void txtTearMDA1_TextChanged(object sender, EventArgs e)
        {
            calculateTearMDAAverage(); 
        }

        private void txtTearMDA2_TextChanged(object sender, EventArgs e)
        {
            calculateTearMDAAverage(); 
        }

        private void txtTearMDA3_TextChanged(object sender, EventArgs e)
        {
            calculateTearMDAAverage(); 
        }

        private void txtTearTDA1_TextChanged(object sender, EventArgs e)
        {
            calculateTearTDAAverage();
        }

        private void txtTearTDA2_TextChanged(object sender, EventArgs e)
        {
            calculateTearTDAAverage();
        }

        private void txtTearTDA3_TextChanged(object sender, EventArgs e)
        {
            calculateTearTDAAverage();
        }

        private void txtDartImpactTF1_TextChanged(object sender, EventArgs e)
        {
            calculateDartImpactTFAverage();
        }

        private void txtDartImpactTF2_TextChanged(object sender, EventArgs e)
        {
            calculateDartImpactTFAverage();
        }

        private void txtDartImpactTF3_TextChanged(object sender, EventArgs e)
        {
            calculateDartImpactTFAverage();
        }

        private void txtDartImpactNTF1_TextChanged(object sender, EventArgs e)
        {
            calculateDartImpactNTFAverage();
        }

        private void txtDartImpactNTF2_TextChanged(object sender, EventArgs e)
        {
            calculateDartImpactNTFAverage();
        }

        private void txtDartImpactNTF3_TextChanged(object sender, EventArgs e)
        {
            calculateDartImpactNTFAverage();
        }

        private void txtSealStrengthTF1_TextChanged(object sender, EventArgs e)
        {
            calculateSealStrengthTFAverage();
        }

        private void txtSealStrengthTF2_TextChanged(object sender, EventArgs e)
        {
            calculateSealStrengthTFAverage();
        }

        private void txtSealStrengthTF3_TextChanged(object sender, EventArgs e)
        {
            calculateSealStrengthTFAverage();
        }

        private void txtSealStrengthNTF1_TextChanged(object sender, EventArgs e)
        {
            calculateSealStrengthNTFAverage();
        }

        private void txtSealStrengthNTF2_TextChanged(object sender, EventArgs e)
        {
            calculateSealStrengthNTFAverage();
        }

        private void txtSealStrengthNTF3_TextChanged(object sender, EventArgs e)
        {
            calculateSealStrengthNTFAverage();
        }

        private void txtHSealTF1_TextChanged(object sender, EventArgs e)
        {
            calculateSealTemperatureTFAverage();
        }

        private void txtHSealTF2_TextChanged(object sender, EventArgs e)
        {
            calculateSealTemperatureTFAverage();
        }

        private void txtHSealTF3_TextChanged(object sender, EventArgs e)
        {
            calculateSealTemperatureTFAverage();
        }

        private void txtHSealNTF1_TextChanged(object sender, EventArgs e)
        {
            calculateSealTemperatureNTFAverage();
        }

        private void txtHSealNTF2_TextChanged(object sender, EventArgs e)
        {
            calculateSealTemperatureNTFAverage();
        }

        private void txtHSealNTF3_TextChanged(object sender, EventArgs e)
        {
            calculateSealTemperatureNTFAverage();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            try
            {
                string s = Clipboard.GetText();
                string[] lines = s.Split('\n');
                foreach (string line in lines)
                {
                    if (line != "")
                    {
                        if (clsGlobal.isNumeric(line) == false)
                        {
                            MessageBox.Show("El valor debe ser Numerico");
                            dgvThikness.Rows.Add();
                            dgvThikness.Rows[dgvThikness.Rows.Count - 1].Cells[clmNumber.Index].Value = dgvThikness.Rows.Count;
                            dgvThikness.Rows[dgvThikness.Rows.Count - 1].Cells[clmThiknessValue.Index].Value = 0;
                        }
                        else
                        {
                            dgvThikness.Rows.Add();
                            dgvThikness.Rows[dgvThikness.Rows.Count - 1].Cells[clmNumber.Index].Value = dgvThikness.Rows.Count;
                            dgvThikness.Rows[dgvThikness.Rows.Count - 1].Cells[clmThiknessValue.Index].Value = Math.Round(Convert.ToDouble(line), 1).ToString("0.0");

                            this.dgvThikness.CurrentCell = this.dgvThikness[0, this.dgvThikness.Rows.Count - 1];
                        }
                    }
                }
                calculateThiknessAverage();
            }
            catch (FormatException)
            {
                MessageBox.Show("The data you pasted is in the wrong format for the cell");
                return;
            }

        }

        private void txtHSealTF1_Click(object sender, EventArgs e)
        {
            txtHSealTF1.SelectAll(); 
        }
    }
}