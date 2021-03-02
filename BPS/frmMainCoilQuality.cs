using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms; 
using BPS.Bussiness;
using ZedGraph;

namespace BPS
{
    public partial class frmMainCoilQuality : Form
    {
        List<clsMainCoil> lstMainCoil = new List<clsMainCoil>();
        clsMainCoil objMainCoil = new clsMainCoil();
        clsMainCoilQuality objMainCoilQuality = new clsMainCoilQuality();
        List<string> lstAppearance = new List<string>();
        const double newtons = 9.81;

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

        private void calculateOpcacityAverage()
        {
            double sum = 0;
            if (clsGlobal.isNumeric(txtOpacityTransmittance1.Text))
            {
                sum += Convert.ToDouble(txtOpacityTransmittance1.Text);
                sum += Convert.ToDouble(txtOpacityTransmittance2.Text);
                sum += Convert.ToDouble(txtOpacityTransmittance3.Text);
                /*sum += Convert.ToDouble(txtOpacityTransmittance4.Text);
                sum += Convert.ToDouble(txtOpacityTransmittance5.Text);
                sum += Convert.ToDouble(txtOpacityTransmittance6.Text);
                sum += Convert.ToDouble(txtOpacityTransmittance7.Text);
                sum += Convert.ToDouble(txtOpacityTransmittance8.Text);
                sum += Convert.ToDouble(txtOpacityTransmittance9.Text);
                sum += Convert.ToDouble(txtOpacityTransmittance10.Text);*/
            }

            txtOpacityTransmitanceAverage.Text = Math.Round(sum / 3, 2).ToString();
        }

        private void calculateMetalFilmAverageI()
        {
            double sum = 0;
            if (clsGlobal.isNumeric(txtMetalFilmCS1.Text))
            {
                sum += Convert.ToDouble(txtMetalFilmCS1.Text);
                sum += Convert.ToDouble(txtMetalFilmM1.Text);
                sum += Convert.ToDouble(txtMetalFilmDS1.Text);
            }
            txtMetalFilmAverage.Text = Math.Round(sum / 3, 3).ToString();
        }

        private void calculateMetalFilmAverageII()
        {
            double sum = 0;
            if (clsGlobal.isNumeric(txtMetalFilmCS2.Text))
            {
                sum += Convert.ToDouble(txtMetalFilmCS2.Text);
                sum += Convert.ToDouble(txtMetalFilmM2.Text);
                sum += Convert.ToDouble(txtMetalFilmDS2.Text);
            }
            txtMetalFilmAverage2.Text = Math.Round(sum / 3, 3).ToString();
        }

        private void calculateGlossIIAverage()
        {
            double sum = 0;
            if (clsGlobal.isNumeric(txtGloss2CS1.Text))
            {
                sum += Convert.ToDouble(txtGloss2CS1.Text);
                //sum += Convert.ToDouble(txtGloss2CS2.Text);
                //sum += Convert.ToDouble(txtGloss2CS3.Text);
                sum += Convert.ToDouble(txtGloss2M1.Text);
                //sum += Convert.ToDouble(txtGloss2M2.Text);
                //sum += Convert.ToDouble(txtGloss2M3.Text);
                sum += Convert.ToDouble(txtGloss2DS1.Text);
                //sum += Convert.ToDouble(txtGloss2DS2.Text);
                //sum += Convert.ToDouble(txtGloss2DS3.Text);
            }
            txtGloss2Average.Text = Math.Round(sum / 3, 1).ToString();
        }

        private void calculateGlossIIDesviation()
        {
            double desviation = 0, averageII = 0, sumForVariance = 0, variance = 0;
            averageII = Convert.ToDouble(txtGloss2Average.Text);
            sumForVariance += Math.Pow((Convert.ToDouble(txtGloss2CS1.Text) - averageII), 2);
            //sumForVariance += Math.Pow((Convert.ToDouble(txtGloss2CS2.Text) - averageII), 2);
            //sumForVariance += Math.Pow((Convert.ToDouble(txtGloss2CS3.Text) - averageII), 2);
            sumForVariance += Math.Pow((Convert.ToDouble(txtGloss2M1.Text) - averageII), 2);
            //sumForVariance += Math.Pow((Convert.ToDouble(txtGloss2M2.Text) - averageII), 2);
            //sumForVariance += Math.Pow((Convert.ToDouble(txtGloss2M3.Text) - averageII), 2);
            sumForVariance += Math.Pow((Convert.ToDouble(txtGloss2DS1.Text) - averageII), 2);
            //sumForVariance += Math.Pow((Convert.ToDouble(txtGloss2DS2.Text) - averageII), 2);
            //sumForVariance += Math.Pow((Convert.ToDouble(txtGloss2DS3.Text) - averageII), 2);
            variance = Math.Round((sumForVariance / 3), 2);
            desviation = Math.Round(Math.Sqrt(variance), 2);
            txtGloss2Desviation.Text = desviation.ToString();
        }

        private void calculateGlossAverage()
        {
            double sum = 0;
            if (clsGlobal.isNumeric(txtGlossCS1.Text))
            {
                sum += Convert.ToDouble(txtGlossCS1.Text);
                //sum += Convert.ToDouble(txtGlossCS2.Text);
                //sum += Convert.ToDouble(txtGlossCS3.Text);
                sum += Convert.ToDouble(txtGlossM1.Text);
                //sum += Convert.ToDouble(txtGlossM2.Text);
                //sum += Convert.ToDouble(txtGlossM3.Text);
                sum += Convert.ToDouble(txtGlossDS1.Text);
                //sum += Convert.ToDouble(txtGlossDS2.Text);
                //sum += Convert.ToDouble(txtGlossDS3.Text);
            }
            txtGlossAverage.Text = Math.Round(sum / 3, 1).ToString();
        }

        private void calculateGlossDesviation()
        {
            double desviation = 0, averageII = 0, sumForVariance = 0, variance = 0;
            averageII = Convert.ToDouble(txtGlossAverage.Text);
            sumForVariance += Math.Pow((Convert.ToDouble(txtGlossCS1.Text) - averageII), 2);
            //sumForVariance += Math.Pow((Convert.ToDouble(txtGlossCS2.Text) - averageII), 2);
            //sumForVariance += Math.Pow((Convert.ToDouble(txtGlossCS3.Text) - averageII), 2);
            sumForVariance += Math.Pow((Convert.ToDouble(txtGlossM1.Text) - averageII), 2);
            //sumForVariance += Math.Pow((Convert.ToDouble(txtGlossM2.Text) - averageII), 2);
            //sumForVariance += Math.Pow((Convert.ToDouble(txtGlossM3.Text) - averageII), 2);
            sumForVariance += Math.Pow((Convert.ToDouble(txtGlossDS1.Text) - averageII), 2);
            //sumForVariance += Math.Pow((Convert.ToDouble(txtGlossDS2.Text) - averageII), 2);
            //sumForVariance += Math.Pow((Convert.ToDouble(txtGlossDS3.Text) - averageII), 2);
            variance = Math.Round((sumForVariance / 3), 2);
            desviation = Math.Round(Math.Sqrt(variance), 2);
            txtGlossDesviation.Text = desviation.ToString();
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
                c.Text = desviation.ToString();
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
                c.Text = desviation.ToString();
            }

            drawOutline();

            List<double> lstThikness = new List<double>();
            for (int i = 0; i < dgvThikness.Rows.Count; i++)
                lstThikness.Add(Convert.ToDouble(dgvThikness.Rows[i].Cells[clmThiknessValue.Index].Value));
        }

        private void calculateFrictionCoefficientTFAverage()
        {
            double sum = 0;
            if (clsGlobal.isNumeric(txtFrictionCoefficientTFCS1.Text))
            {
                sum += Convert.ToDouble(txtFrictionCoefficientTFCS1.Text);
                //sum += Convert.ToDouble(txtFrictionCoefficientTFCS3.Text);
                sum += Convert.ToDouble(txtFrictionCoefficientTFM1.Text);
                //sum += Convert.ToDouble(txtFrictionCoefficientTFM3.Text);
                sum += Convert.ToDouble(txtFrictionCoefficientTFDS1.Text);
                //sum += Convert.ToDouble(txtFrictionCoefficientTFDS3.Text);
            }
            txtFrictionCoefficientTFAverage.Text = Math.Round(sum / 3, 3).ToString();
        }

        private void calculateFrictionCoefficientTFAverageII()
        {
            double sum = 0;
            if (clsGlobal.isNumeric(txtFrictionCoefficientTFCS2.Text))
            {
                sum += Convert.ToDouble(txtFrictionCoefficientTFCS2.Text);
                //sum += Convert.ToDouble(txtFrictionCoefficientTFCS4.Text);
                sum += Convert.ToDouble(txtFrictionCoefficientTFM2.Text);
                //sum += Convert.ToDouble(txtFrictionCoefficientTFM4.Text);
                sum += Convert.ToDouble(txtFrictionCoefficientTFDS2.Text);
                //sum += Convert.ToDouble(txtFrictionCoefficientTFDS4.Text);
            }

            txtFrictionCoefficientTFAverage2.Text = Math.Round(sum / 3, 3).ToString();
        }

        private void calculateFrictionCoefficientNTFAverage()
        {
            double sum = 0;
            if (clsGlobal.isNumeric(txtFrictionCoefficientNTFCS1.Text))
            {
                sum += Convert.ToDouble(txtFrictionCoefficientNTFCS1.Text);
                //sum += Convert.ToDouble(txtFrictionCoefficientNTFCS3.Text);
                sum += Convert.ToDouble(txtFrictionCoefficientNTFM1.Text);
                //sum += Convert.ToDouble(txtFrictionCoefficientNTFM3.Text);
                sum += Convert.ToDouble(txtFrictionCoefficientNTFDS1.Text);
                //sum += Convert.ToDouble(txtFrictionCoefficientNTFDS3.Text);
            }
            txtFrictionCoefficientNTFAverage.Text = Math.Round(sum / 3, 3).ToString();
        }

        private void calculateFrictionCoefficientNTFAverageII()
        {
            double sum = 0;
            if (clsGlobal.isNumeric(txtFrictionCoefficientNTFCS2.Text))
            {
                sum += Convert.ToDouble(txtFrictionCoefficientNTFCS2.Text);
                //sum += Convert.ToDouble(txtFrictionCoefficientNTFCS4.Text);
                sum += Convert.ToDouble(txtFrictionCoefficientNTFM2.Text);
                //sum += Convert.ToDouble(txtFrictionCoefficientNTFM4.Text);
                sum += Convert.ToDouble(txtFrictionCoefficientNTFDS2.Text);
                //sum += Convert.ToDouble(txtFrictionCoefficientNTFDS4.Text);
            }

            txtFrictionCoefficientNTFAverage2.Text = Math.Round(sum / 3, 3).ToString();
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
                    objMainCoilQuality.thiknessDesviation = Convert.ToDouble(c.Text);
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
                    c.Text = Convert.ToString(Math.Round(objMainCoilQuality.thiknessDesviation, 2));
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
                    objMainCoilQuality.surfaceTensionValues = getValuesFromControl(grpbSurfaceTension, "textBox");
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
                    objMainCoilQuality.SealTemperatureTF = Convert.ToDouble(txtSealTemperatureTreatedFace.Text);
                    objMainCoilQuality.sealTemperatureTFValues = getValuesFromControl(grpbSealTempTF, "checkBox");
                    objMainCoilQuality.sealTemperatureTFList = clsGlobal.getBooleanListFromString(objMainCoilQuality.sealTemperatureTFValues);

                    break;
                case "toLoad":
                    txtSealTemperatureTreatedFace.Text = objMainCoilQuality.SealTemperatureTF.ToString();
                    setValuesToControl(grpbSealTempTF, "checkBox", objMainCoilQuality.sealTemperatureTFValues);
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

                    objMainCoilQuality.sealTemperatureNTF = Convert.ToDouble(txtSealTemperatureNonTreatedFace.Text);
                    objMainCoilQuality.sealTemperatureNTFValues = getValuesFromControl(grpbSealTempNTF, "checkBox");
                    objMainCoilQuality.sealTemperatureNTFList = clsGlobal.getBooleanListFromString(objMainCoilQuality.sealTemperatureNTFValues);

                    break;
                case "toLoad":
                    txtSealTemperatureNonTreatedFace.Text = objMainCoilQuality.sealTemperatureNTF.ToString();
                    setValuesToControl(grpbSealTempNTF, "checkBox", objMainCoilQuality.sealTemperatureNTFValues);
                    break;
                default:
                    break;
            }
        }

        private void setAppearanceValues(string destination)
        {
            switch (destination)
            {
                case "toSave":
                    objMainCoilQuality.appearance = "";

                    for (int i = 0; i < lstAppearance.Count; i++)
                    {
                        objMainCoilQuality.appearance += lstAppearance[i];
                        objMainCoilQuality.appearance += (i < lstAppearance.Count - 1) ? ";" : "";
                    }

                    objMainCoilQuality.appearanceValues = getValuesFromControl(grpbAppearance, "textBox");
                    objMainCoilQuality.appearanceValues = objMainCoilQuality.appearanceValues.Substring(objMainCoilQuality.appearanceValues.IndexOf(";") + 1);
                    objMainCoilQuality.appearanceList = clsGlobal.getStringListFromString(objMainCoilQuality.appearanceValues);

                    break;
                case "toLoad":
                    lstAppearance = clsGlobal.getStringListFromString(objMainCoilQuality.appearance);
                    lstbAppearance.Items.Clear();

                    for (int i = 0; i < lstAppearance.Count; i++)
                        lstbAppearance.Items.Add((i + 1).ToString() + ". " + lstAppearance[i]);

                    setValuesToControl(grpbAppearance, "textBoxString", objMainCoilQuality.appearanceValues);
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
                    objMainCoilQuality.frictionCoefficientTFDinamicAverage = Convert.ToDouble(txtFrictionCoefficientTFAverage2.Text);

                    break;
                case "toLoad":
                    txtFrictionCoefficientTFAverage.Text = objMainCoilQuality.frictionCoefficientTFAverage.ToString();
                    txtFrictionCoefficientTFAverage2.Text = objMainCoilQuality.frictionCoefficientTFDinamicAverage.ToString();
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
                    objMainCoilQuality.frictionCoefficientNTFValues = getValuesFromControl(grpbFrictionCoefficientNTF, "textBox");
                    objMainCoilQuality.frictionCoefficientNTFList = clsGlobal.getDoubleListFromString(objMainCoilQuality.frictionCoefficientNTFValues);
                    objMainCoilQuality.frictionCoefficientNTFAverage = Convert.ToDouble(txtFrictionCoefficientNTFAverage.Text);
                    objMainCoilQuality.frictionCoefficientNTFDinamicAverage = Convert.ToDouble(txtFrictionCoefficientNTFAverage2.Text);

                    break;
                case "toLoad":
                    txtFrictionCoefficientNTFAverage.Text = objMainCoilQuality.frictionCoefficientNTFAverage.ToString();
                    txtFrictionCoefficientNTFAverage2.Text = objMainCoilQuality.frictionCoefficientNTFDinamicAverage.ToString();
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

        private void setSealStrengthValues(string destination)
        {
            switch (destination)
            {
                case "toSave":
                    objMainCoilQuality.sealStrengthValues = getValuesFromControl(grpbSealStrength, "textBox");
                    objMainCoilQuality.sealStrengthList = clsGlobal.getDoubleListFromString(objMainCoilQuality.sealStrengthValues);
                    objMainCoilQuality.sealStrengthValuesDMTFNewton = Convert.ToDouble(txtSealStrengthMDTFNewtons.Text);
                    objMainCoilQuality.sealStrengthValuesDTNTFNewton = Convert.ToDouble(txtSealStrengthTDTFNewtons.Text);
                    objMainCoilQuality.sealStrengthValuesDMTFNewtonII = Convert.ToDouble(txtSealStrengthMDNTFNewtons.Text);
                    objMainCoilQuality.sealStrengthValuesDTNTFNewtonII = Convert.ToDouble(txtSealStrengthTDNTFNewtons.Text);
                    break;
                case "toLoad":
                    setValuesToControl(grpbSealStrength, "textBox", objMainCoilQuality.sealStrengthValues);
                    break;
                default:
                    break;
            }
        }

        private void setAdictionalValues(string destination)
        {
            switch (destination)
            {
                case "toSave":
                    objMainCoilQuality.addValues = getValuesFromControl(grpbAditional, "textBox");
                    objMainCoilQuality.addList = clsGlobal.getDoubleListFromString(objMainCoilQuality.addValues);
                    break;
                case "toLoad":
                    setValuesToControl(grpbAditional, "textBox", objMainCoilQuality.addValues);
                    break;
                default:
                    break;
            }
        }

        private void calculateTotals()
        {
            if (dgvGramaje.SelectedRows.Count > 0)
                dgvGramaje.Rows[dgvGramaje.SelectedRows[0].Index].Cells[clmGramajeWeight.Index].Value = Convert.ToString(Math.Round(((lstMainCoil[dgvGramaje.SelectedRows[0].Index].grosslength * lstMainCoil[dgvGramaje.SelectedRows[0].Index].width * Convert.ToDouble(dgvGramaje.Rows[dgvGramaje.SelectedRows[0].Index].Cells[clmGramajeGramaje.Index].EditedFormattedValue)) / 1000 / 1000), 2));
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
            lblCore.Text = objMainCoilToShow.core.ToString();
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
                    dgvGramaje.Rows[i].Cells[clmCalculateWeight.Index].Value = lstMainCoil[i].calculateWeight.ToString();

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
                txtOperatorCriterial.Text = objMainCoilQuality.operatorCriterial;
                txtFisicStatus.Text = objMainCoilQuality.fisicStatus;
                setThiknessValues("toLoad");
                setOpacityTransmitanceValues("toLoad");
                setSurfaceTensionValues("toLoad");
                setBackSideValues("toLoad");
                setSealTemperatureTFValues("toLoad");
                setSealTemperatureNTFValues("toLoad");
                setAppearanceValues("toLoad");
                setFrictionCoefficentTFValues("toLoad");
                setFrictionCoefficentNTFValues("toLoad");
                setGlossValue("toLoad");
                setSealStrengthValues("toLoad");
                //Metal Film
                setMetalFilmValues("toLoad");
                setGlossIIValues("toLoad");
                setAdictionalValues("toLoad");
                dtpReceptionDate.Value = objMainCoilQuality.receptionDate;
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
                    dgvGramaje.Rows[i].Cells[clmCalculateWeight.Index].Value = lstMainCoil[i].calculateWeight.ToString();

                    dgvRating.Rows.Add();
                    dgvRating.Rows[i].Cells[clmQualityMainCoilCodsec.Index].Value = lstMainCoil[i].codsec;
                    dgvRating.Rows[i].Cells[clmQualityMainCoilCode.Index].Value = lstMainCoil[i].code;
                    dgvRating.Rows[i].Cells[clmQualityRanking.Index].Value = lstMainCoil[i].labRating;
                }
            }

        }
        public frmMainCoilQuality()
        {
            InitializeComponent();
        }

        public frmMainCoilQuality(int mainCoilCodsec)
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
                txtOperatorCriterial.Text = lstMainCoil[0].notes;
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
            setAppearanceValues("toSave");
            objMainCoilQuality.operatorCriterial = txtOperatorCriterial.Text;
            objMainCoilQuality.fisicStatus = txtFisicStatus.Text;
            setFrictionCoefficentTFValues("toSave");
            setFrictionCoefficentNTFValues("toSave");
            setGlossValue("toSave");
            setSealStrengthValues("toSave");

            //Metal Film
            setMetalFilmValues("toSave");
            setGlossIIValues("toSave");
            setAdictionalValues("toSave");

            objMainCoilQuality.receptionDate = dtpReceptionDate.Value;
            objMainCoilQuality.createdDate = DateTime.Now;
            objMainCoilQuality.createdBy = clsGlobal.LoggedUser.codsec;
            objMainCoilQuality.ModifiedDate = DateTime.Now;
            objMainCoilQuality.modifiedBy = clsGlobal.LoggedUser.codsec;
            objMainCoilQuality.lstMainCoil = lstMainCoil;
            objMainCoilQuality.treatmentValues = "";
            //objMainCoilQuality.

            if (objMainCoilQuality.save())
                MessageBox.Show("El control de calidad de la rollo madre se ha guardado con éxito.", "Control de calidad", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            else
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Control de calidad", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

        }

        private void setMetalFilmValues(string destination)
        {
            switch (destination)
            {
                case "toSave":
                    objMainCoilQuality.metalFilmValues = getValuesFromControl(grpbMetalFilm, "textBox");
                    objMainCoilQuality.metalfilmValuesList = clsGlobal.getDoubleListFromString(objMainCoilQuality.metalFilmValues);
                    objMainCoilQuality.metalfilmAverage = Convert.ToDouble(txtMetalFilmAverage.Text);
                    objMainCoilQuality.metalfilmAverageII = Convert.ToDouble(txtMetalFilmAverage2.Text);
                    break;
                case "toLoad":
                    txtMetalFilmAverage.Text = objMainCoilQuality.metalfilmAverage.ToString();
                    txtMetalFilmAverage2.Text = objMainCoilQuality.metalfilmAverageII.ToString();
                    setValuesToControl(grpbMetalFilm, "textBox", objMainCoilQuality.metalFilmValues);
                    break;
                default:
                    break;
            }
        }

        private void setGlossIIValues(string destination)
        {
            switch (destination)
            {
                case "toSave":
                    objMainCoilQuality.GlossIIValues = getValuesFromControl(grpbGlossII, "textBox");
                    objMainCoilQuality.GlossIIList = clsGlobal.getDoubleListFromString(objMainCoilQuality.GlossIIValues);
                    objMainCoilQuality.GlossIIAverage = Convert.ToDouble(txtGloss2Average.Text);
                    objMainCoilQuality.GlossIIDesviation = Convert.ToDouble(txtGloss2Desviation.Text);
                    break;
                case "toLoad":
                    txtGloss2Average.Text = objMainCoilQuality.GlossIIAverage.ToString();
                    txtGloss2Desviation.Text = objMainCoilQuality.GlossDesviation.ToString();
                    setValuesToControl(grpbGlossII, "textBox", objMainCoilQuality.GlossIIValues);
                    break;
                default:
                    break;
            }
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
                this.dgvThikness.CurrentCell = this.dgvThikness[0, this.dgvThikness.Rows.Count - 1];
                calculateThiknessAverage();
            }
        }

        private void btnMainCoilExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMainCoilQuality_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(clsGlobal.LoggedUser.fkRole==2031)
            {
                frmMainCoilList winMainCoilList = new frmMainCoilList(4);
                winMainCoilList.StartPosition = FormStartPosition.Manual;
                winMainCoilList.MdiParent = this.MdiParent;
                winMainCoilList.Show();
            }
            else
            {
                frmMainCoilList winMainCoilList = new frmMainCoilList(3);
                winMainCoilList.StartPosition = FormStartPosition.Manual;
                winMainCoilList.MdiParent = this.MdiParent;
                winMainCoilList.Show();
            }
            
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

        private void btnAddAppearance_Click(object sender, EventArgs e)
        {
            lstAppearance.Add(txtAppearance.Text);
            lstbAppearance.Items.Clear();
            for (int i = 0; i < lstAppearance.Count; i++)
                lstbAppearance.Items.Add((i + 1).ToString() + ". " + lstAppearance[i]);
        }

        private void lstbAppearance_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.lstbAppearance.SelectedItem != null)
                    this.lstbAppearance.DoDragDrop(this.lstbAppearance.SelectedItem, DragDropEffects.All);
            }
        }

        private void textBox10_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListBox)))
                e.Effect = DragDropEffects.Move;
        }

        private void textBox10_DragDrop(object sender, DragEventArgs e)
        {
            txtAppearanceValue1.Text = lstbAppearance.SelectedItem.ToString().Substring(0, 1);
        }

        private void txtAppearanceValue1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void txtAppearanceValue2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListBox)))
                e.Effect = DragDropEffects.Move;
        }

        private void txtAppearanceValue2_DragDrop(object sender, DragEventArgs e)
        {
            txtAppearanceValue2.Text = lstbAppearance.SelectedItem.ToString().Substring(0, 1);
        }

        private void txtAppearanceValue2_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void txtAppearanceValue3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListBox)))
                e.Effect = DragDropEffects.Move;
        }

        private void txtAppearanceValue3_DragDrop(object sender, DragEventArgs e)
        {
            txtAppearanceValue3.Text = lstbAppearance.SelectedItem.ToString().Substring(0, 1);
        }

        private void txtAppearanceValue3_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void txtAppearanceValue4_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListBox)))
                e.Effect = DragDropEffects.Move;
        }

        private void txtAppearanceValue4_DragDrop(object sender, DragEventArgs e)
        {
            txtAppearanceValue4.Text = lstbAppearance.SelectedItem.ToString().Substring(0, 1);
        }

        private void txtAppearanceValue4_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void txtAppearanceValue5_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListBox)))
                e.Effect = DragDropEffects.Move;
        }

        private void txtAppearanceValue5_DragDrop(object sender, DragEventArgs e)
        {
            txtAppearanceValue5.Text = lstbAppearance.SelectedItem.ToString().Substring(0, 1);
        }

        private void txtAppearanceValue5_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void txtAppearanceValue6_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListBox)))
                e.Effect = DragDropEffects.Move;
        }

        private void txtAppearanceValue6_DragDrop(object sender, DragEventArgs e)
        {
            txtAppearanceValue6.Text = lstbAppearance.SelectedItem.ToString().Substring(0, 1);
        }

        private void txtAppearanceValue6_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void txtAppearanceValue7_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListBox)))
                e.Effect = DragDropEffects.Move;
        }

        private void txtAppearanceValue7_DragDrop(object sender, DragEventArgs e)
        {
            txtAppearanceValue7.Text = lstbAppearance.SelectedItem.ToString().Substring(0, 1);
        }

        private void txtAppearanceValue7_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void txtAppearanceValue8_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListBox)))
                e.Effect = DragDropEffects.Move;
        }

        private void txtAppearanceValue8_DragDrop(object sender, DragEventArgs e)
        {
            txtAppearanceValue8.Text = lstbAppearance.SelectedItem.ToString().Substring(0, 1);
        }

        private void txtAppearanceValue8_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void txtAppearanceValue9_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListBox)))
                e.Effect = DragDropEffects.Move;
        }

        private void txtAppearanceValue9_DragDrop(object sender, DragEventArgs e)
        {
            txtAppearanceValue9.Text = lstbAppearance.SelectedItem.ToString().Substring(0, 1);
        }

        private void txtAppearanceValue9_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void txtAppearanceValue10_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListBox)))
                e.Effect = DragDropEffects.Move;
        }

        private void txtAppearanceValue10_DragDrop(object sender, DragEventArgs e)
        {
            txtAppearanceValue10.Text = lstbAppearance.SelectedItem.ToString().Substring(0, 1);
        }

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
                            dgvGramaje.Rows[i].Cells[clmCalculateWeight.Index].Value = lstMainCoil[i].calculateWeight.ToString();

                            dgvRating.Rows.Add();
                            dgvRating.Rows[i].Cells[clmQualityMainCoilCodsec.Index].Value = lstMainCoil[i].codsec;
                            dgvRating.Rows[i].Cells[clmQualityMainCoilCode.Index].Value = lstMainCoil[i].code;
                            dgvRating.Rows[i].Cells[clmQualityRanking.Index].Value = lstMainCoil[i].labRating;
                        }

                        if (lstMainCoil.Count == 1)
                        {
                            tbcMainCoilInfo.TabPages.Add(tbpMainCoilQuality);
                            loadMainCoilData(objNewMainCoil);
                            txtOperatorCriterial.Text = objNewMainCoil.notes;
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
            /*txtOpacityTransmittance4.Text = txtOpacityTransmittance1.Text;
            txtOpacityTransmittance5.Text = txtOpacityTransmittance1.Text;
            txtOpacityTransmittance6.Text = txtOpacityTransmittance1.Text;
            txtOpacityTransmittance7.Text = txtOpacityTransmittance1.Text;
            txtOpacityTransmittance8.Text = txtOpacityTransmittance1.Text;
            txtOpacityTransmittance9.Text = txtOpacityTransmittance1.Text;
            txtOpacityTransmittance10.Text = txtOpacityTransmittance1.Text;*/
        }

        private void btnCopyForwardSTTF_Click(object sender, EventArgs e)
        {
            /*txtSurfaceTension2.Text = txtSurfaceTension1.Text;
            txtSurfaceTension3.Text = txtSurfaceTension1.Text;
            txtSurfaceTension4.Text = txtSurfaceTension1.Text;
            txtSurfaceTension5.Text = txtSurfaceTension1.Text;
            txtSurfaceTension6.Text = txtSurfaceTension1.Text;
            txtSurfaceTension7.Text = txtSurfaceTension1.Text;
            txtSurfaceTension8.Text = txtSurfaceTension1.Text;
            txtSurfaceTension9.Text = txtSurfaceTension1.Text;
            txtSurfaceTension10.Text = txtSurfaceTension1.Text;*/
        }

        private void btnCopyForwardSTNTF_Click(object sender, EventArgs e)
        {
            /*txtSurfaceTensionEF2.Text = txtSurfaceTensionEF1.Text;
            txtSurfaceTensionEF3.Text = txtSurfaceTensionEF1.Text;
            txtSurfaceTensionEF4.Text = txtSurfaceTensionEF1.Text;
            txtSurfaceTensionEF5.Text = txtSurfaceTensionEF1.Text;
            txtSurfaceTensionEF6.Text = txtSurfaceTensionEF1.Text;
            txtSurfaceTensionEF7.Text = txtSurfaceTensionEF1.Text;
            txtSurfaceTensionEF8.Text = txtSurfaceTensionEF1.Text;
            txtSurfaceTensionEF9.Text = txtSurfaceTensionEF1.Text;
            txtSurfaceTensionEF10.Text = txtSurfaceTensionEF1.Text;*/
        }

        private void btnCopyForwardBackSide_Click(object sender, EventArgs e)
        {
            chkBackSide2.Checked = chkBackSide1.Checked;
            chkBackSide3.Checked = chkBackSide1.Checked;
            chkBackSide4.Checked = chkBackSide1.Checked;
            chkBackSide5.Checked = chkBackSide1.Checked;
            chkBackSide6.Checked = chkBackSide1.Checked;
            chkBackSide7.Checked = chkBackSide1.Checked;
            chkBackSide8.Checked = chkBackSide1.Checked;
            chkBackSide9.Checked = chkBackSide1.Checked;
            chkBackSide10.Checked = chkBackSide1.Checked;
        }

        private void btnCopyForwardSealTempIF_Click(object sender, EventArgs e)
        {
            chkSealTempTF2.Checked = chkSealTempTF1.Checked;
            chkSealTempTF3.Checked = chkSealTempTF1.Checked;
            chkSealTempTF4.Checked = chkSealTempTF1.Checked;
            chkSealTempTF5.Checked = chkSealTempTF1.Checked;
            chkSealTempTF6.Checked = chkSealTempTF1.Checked;
            chkSealTempTF7.Checked = chkSealTempTF1.Checked;
            chkSealTempTF8.Checked = chkSealTempTF1.Checked;
            chkSealTempTF9.Checked = chkSealTempTF1.Checked;
            chkSealTempTF10.Checked = chkSealTempTF1.Checked;
        }

        private void btnCopyForwardSealTempOF_Click(object sender, EventArgs e)
        {
            chkSealTempNTF2.Checked = chkSealTempNTF1.Checked;
            chkSealTempNTF3.Checked = chkSealTempNTF1.Checked;
            chkSealTempNTF4.Checked = chkSealTempNTF1.Checked;
            chkSealTempNTF5.Checked = chkSealTempNTF1.Checked;
            chkSealTempNTF6.Checked = chkSealTempNTF1.Checked;
            chkSealTempNTF7.Checked = chkSealTempNTF1.Checked;
            chkSealTempNTF8.Checked = chkSealTempNTF1.Checked;
            chkSealTempNTF9.Checked = chkSealTempNTF1.Checked;
            chkSealTempNTF10.Checked = chkSealTempNTF1.Checked;
        }

        private void dgvGramaje_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmGramajeGramaje.Index)
            {
                if (dgvGramaje.Rows[e.RowIndex].Cells[clmCalculateWeight.Index].Value.ToString() == "True")
                    calculateTotals();
            }
        }

        private void txtFrictionCoefficientNTFAverage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMetalFilmCS1_TextChanged(object sender, EventArgs e)
        {
            calculateMetalFilmAverageI();
        }

        private void txtMetalFilmM1_TextChanged(object sender, EventArgs e)
        {
            calculateMetalFilmAverageI();
        }

        private void txtMetalFilmDS1_TextChanged(object sender, EventArgs e)
        {
            calculateMetalFilmAverageI();
        }

        private void txtMetalFilmCS2_TextChanged(object sender, EventArgs e)
        {
            calculateMetalFilmAverageII();
        }

        private void txtMetalFilmM2_TextChanged(object sender, EventArgs e)
        {
            calculateMetalFilmAverageII();
        }

        private void txtMetalFilmDS2_TextChanged(object sender, EventArgs e)
        {
            calculateMetalFilmAverageII();
        }

        private void txtGloss2CS1_TextChanged(object sender, EventArgs e)
        {
            calculateGlossIIAverage();
            calculateGlossIIDesviation();
        }

        private void txtGloss2CS2_TextChanged(object sender, EventArgs e)
        {
            calculateGlossIIAverage();
            calculateGlossIIDesviation();
        }

        private void txtGloss2CS3_TextChanged(object sender, EventArgs e)
        {
            calculateGlossIIAverage();
            calculateGlossIIDesviation();
        }

        private void txtGloss2M1_TextChanged(object sender, EventArgs e)
        {
            calculateGlossIIAverage();
            calculateGlossIIDesviation();
        }

        private void txtGloss2M2_TextChanged(object sender, EventArgs e)
        {
            calculateGlossIIAverage();
            calculateGlossIIDesviation();
        }

        private void txtGloss2M3_TextChanged(object sender, EventArgs e)
        {
            calculateGlossIIAverage();
            calculateGlossIIDesviation();
        }

        private void txtGloss2DS1_TextChanged(object sender, EventArgs e)
        {
            calculateGlossIIAverage();
            calculateGlossIIDesviation();
        }

        private void txtGloss2DS2_TextChanged(object sender, EventArgs e)
        {
            calculateGlossIIAverage();
            calculateGlossIIDesviation();
        }

        private void txtGloss2DS3_TextChanged(object sender, EventArgs e)
        {
            calculateGlossIIAverage();
            calculateGlossIIDesviation();
        }

        private void txtFrictionCoefficientTFCS1_TextChanged(object sender, EventArgs e)
        {
            calculateFrictionCoefficientTFAverage();
        }

        private void txtFrictionCoefficientTFCS3_TextChanged(object sender, EventArgs e)
        {
            calculateFrictionCoefficientTFAverage();
        }

        private void txtFrictionCoefficientTFM1_TextChanged(object sender, EventArgs e)
        {
            calculateFrictionCoefficientTFAverage();
        }

        private void txtFrictionCoefficientTFM3_TextChanged(object sender, EventArgs e)
        {
            calculateFrictionCoefficientTFAverage();
        }

        private void txtFrictionCoefficientTFDS1_TextChanged(object sender, EventArgs e)
        {
            calculateFrictionCoefficientTFAverage();
        }

        private void txtFrictionCoefficientTFDS3_TextChanged(object sender, EventArgs e)
        {
            calculateFrictionCoefficientTFAverage();
        }

        private void txtFrictionCoefficientTFCS2_TextChanged(object sender, EventArgs e)
        {
            calculateFrictionCoefficientTFAverageII();
        }

        private void txtFrictionCoefficientTFCS4_TextChanged(object sender, EventArgs e)
        {
            calculateFrictionCoefficientTFAverageII();
        }

        private void txtFrictionCoefficientTFM2_TextChanged(object sender, EventArgs e)
        {
            calculateFrictionCoefficientTFAverageII();
        }

        private void txtFrictionCoefficientTFM4_TextChanged(object sender, EventArgs e)
        {
            calculateFrictionCoefficientTFAverageII();
        }

        private void txtFrictionCoefficientTFDS2_TextChanged(object sender, EventArgs e)
        {
            calculateFrictionCoefficientTFAverageII();
        }

        private void txtFrictionCoefficientTFDS4_TextChanged(object sender, EventArgs e)
        {
            calculateFrictionCoefficientTFAverageII();
        }

        private void txtFrictionCoefficientNTFCS1_TextChanged(object sender, EventArgs e)
        {
            calculateFrictionCoefficientNTFAverage();
        }

        private void txtFrictionCoefficientNTFCS3_TextChanged(object sender, EventArgs e)
        {
            calculateFrictionCoefficientNTFAverage();
        }

        private void txtFrictionCoefficientNTFM1_TextChanged(object sender, EventArgs e)
        {
            calculateFrictionCoefficientNTFAverage();
        }

        private void txtFrictionCoefficientNTFM3_TextChanged(object sender, EventArgs e)
        {
            calculateFrictionCoefficientNTFAverage();
        }

        private void txtFrictionCoefficientNTFDS1_TextChanged(object sender, EventArgs e)
        {
            calculateFrictionCoefficientNTFAverage();
        }

        private void txtFrictionCoefficientNTFDS3_TextChanged(object sender, EventArgs e)
        {
            calculateFrictionCoefficientNTFAverage();
        }

        private void txtFrictionCoefficientNTFCS2_TextChanged(object sender, EventArgs e)
        {
            calculateFrictionCoefficientNTFAverageII();
        }

        private void txtFrictionCoefficientNTFCS4_TextChanged(object sender, EventArgs e)
        {
            calculateFrictionCoefficientNTFAverageII();
        }

        private void txtFrictionCoefficientNTFM2_TextChanged(object sender, EventArgs e)
        {
            calculateFrictionCoefficientNTFAverageII();
        }

        private void txtFrictionCoefficientNTFM4_TextChanged(object sender, EventArgs e)
        {
            calculateFrictionCoefficientNTFAverageII();
        }

        private void txtFrictionCoefficientNTFDS2_TextChanged(object sender, EventArgs e)
        {
            calculateFrictionCoefficientNTFAverageII();
        }

        private void txtFrictionCoefficientNTFDS4_TextChanged(object sender, EventArgs e)
        {
            calculateFrictionCoefficientNTFAverageII();
        }

        private void txtGlossCS1_TextChanged(object sender, EventArgs e)
        {
            calculateGlossAverage();
            calculateGlossDesviation();
        }

        private void txtGlossCS2_TextChanged(object sender, EventArgs e)
        {
            calculateGlossAverage();
            calculateGlossDesviation();
        }

        private void txtGlossCS3_TextChanged(object sender, EventArgs e)
        {
            calculateGlossAverage();
            calculateGlossDesviation();
        }

        private void txtGlossM1_TextChanged(object sender, EventArgs e)
        {
            calculateGlossAverage();
            calculateGlossDesviation();
        }

        private void txtGlossM2_TextChanged(object sender, EventArgs e)
        {
            calculateGlossAverage();
            calculateGlossDesviation();
        }

        private void txtGlossM3_TextChanged(object sender, EventArgs e)
        {
            calculateGlossAverage();
            calculateGlossDesviation();
        }

        private void txtGlossDS1_TextChanged(object sender, EventArgs e)
        {
            calculateGlossAverage();
            calculateGlossDesviation();
        }

        private void txtGlossDS2_TextChanged(object sender, EventArgs e)
        {
            calculateGlossAverage();
            calculateGlossDesviation();
        }

        private void txtGlossDS3_TextChanged(object sender, EventArgs e)
        {
            calculateGlossAverage();
            calculateGlossDesviation();
        }

        private void txtSealStrengthMDTF_TextChanged(object sender, EventArgs e)
        {
            //if (clsGlobal.isNumeric(txtSealStrengthMDTF.Text))
              //  txtSealStrengthMDTFNewtons.Text = Math.Round((Convert.ToDouble(txtSealStrengthMDTF.Text) * newtons), 3).ToString();
        }

        private void txtSealStrengthTDTF_TextChanged(object sender, EventArgs e)
        {
            if (clsGlobal.isNumeric(txtSealStrengthTDTF.Text))
                txtSealStrengthTDTFNewtons.Text = Math.Round((Convert.ToDouble(txtSealStrengthTDTF.Text) * newtons), 3).ToString();
        }

        private void txtSealStrengthMDNTF_TextChanged(object sender, EventArgs e)
        {
            //if (clsGlobal.isNumeric(txtSealStrengthMDNTF.Text))
              //  txtSealStrengthMDNTFNewtons.Text = Math.Round((Convert.ToDouble(txtSealStrengthMDNTF.Text) * newtons), 3).ToString();
        }

        private void txtSealStrengthTDNTF_TextChanged(object sender, EventArgs e)
        {
            if (clsGlobal.isNumeric(txtSealStrengthTDNTF.Text))
                txtSealStrengthTDNTFNewtons.Text = Math.Round((Convert.ToDouble(txtSealStrengthTDNTF.Text) * newtons), 3).ToString();
        }
    }
}