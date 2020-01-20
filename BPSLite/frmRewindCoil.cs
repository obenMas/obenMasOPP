using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms; 
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Drawing.Printing;
using System.Threading;
using BPS.Bussiness;


namespace BPS.Lite
{
    public partial class frmRewindCoil : Form
    {
        clsSalesOrderDetail objSalesOrderDetail = new clsSalesOrderDetail();
        clsSalesOrder objSalesOrder = new clsSalesOrder();
        clsCoil objCoil = new clsCoil();
        clsCoil objCoilBySaleOrder = new clsCoil();
        clsCuttingStop objCuttingStop = new clsCuttingStop();
        clsCoilCellar objCoilCellar = new clsCoilCellar();
        clsProduct objProduct = new clsProduct();

        private bool isValid = false;

        public frmRewindCoil()
        {
            InitializeComponent();
        }
        private bool validateForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtDiameter, ref lblDiameter, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref lblDensity, ref lblDensityLabel, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtGrossWeigth, ref lblGrossWeigth, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbQuality, ref lblQuality, "selected")) isValid = false;

            return isValid;
        }
        private void printCoilLabel(int coilCodsec)
        {
            if (objCoil.isExternalCoil == false)
            {
                Reports.rptCoilLabel rptCoilLabel = new Reports.rptCoilLabel();

                Tables tables;

                tables = rptCoilLabel.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptCoilLabel.ReportDefinition.Sections;
                foreach (Section section in sections)
                {
                    ReportObjects reportObjects = section.ReportObjects;
                    foreach (ReportObject reportObject in reportObjects)
                    {
                        if (reportObject.Kind == ReportObjectKind.SubreportObject)
                        {
                            SubreportObject subreportObject = (SubreportObject)reportObject;
                            ReportDocument subReportDocument = subreportObject.OpenSubreport(subreportObject.SubreportName);
                            tables = subReportDocument.Database.Tables;
                            foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                            {
                                TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                                tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                                table.ApplyLogOnInfo(tableLogonInfo);
                            }
                        }
                    }
                }

                ParameterDiscreteValue prmCoilCodsec = new ParameterDiscreteValue();
                prmCoilCodsec.Value = coilCodsec;

                ParameterField pfldCoilCodsec = new ParameterField();
                pfldCoilCodsec.Name = "coilLabelCodsec";
                pfldCoilCodsec.CurrentValues.Add(prmCoilCodsec);
                pfldCoilCodsec.HasCurrentValue = true;

                for (int i = 0; i < rptCoilLabel.ParameterFields.Count; i++)
                {
                    switch (rptCoilLabel.ParameterFields[i].Name)
                    {
                        case "coilLabelCodsec":
                            rptCoilLabel.ParameterFields[i].CurrentValues.Clear();
                            rptCoilLabel.ParameterFields[i].CurrentValues.Add(prmCoilCodsec);
                            rptCoilLabel.ParameterFields[i].HasCurrentValue = true;
                            rptCoilLabel.ParameterFields[i].DefaultValues.Clear();
                            rptCoilLabel.ParameterFields[i].DefaultValues.Add(prmCoilCodsec);
                            break;
                        default:
                            break;
                    }
                }

                PrinterSettings printerSettings = new PrinterSettings();
                rptCoilLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                rptCoilLabel.PrintToPrinter(2, false, 0, 0);
                rptCoilLabel.Close();
                rptCoilLabel.Dispose();
            }
            else
            {
                Reports.rptOppCoilLabel rptCoilLabel = new Reports.rptOppCoilLabel();

                Tables tables;

                tables = rptCoilLabel.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptCoilLabel.ReportDefinition.Sections;
                foreach (Section section in sections)
                {
                    ReportObjects reportObjects = section.ReportObjects;
                    foreach (ReportObject reportObject in reportObjects)
                    {
                        if (reportObject.Kind == ReportObjectKind.SubreportObject)
                        {
                            SubreportObject subreportObject = (SubreportObject)reportObject;
                            ReportDocument subReportDocument = subreportObject.OpenSubreport(subreportObject.SubreportName);
                            tables = subReportDocument.Database.Tables;
                            foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                            {
                                TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                                tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                                table.ApplyLogOnInfo(tableLogonInfo);
                            }
                        }
                    }
                }

                ParameterDiscreteValue prmCoilCodsec = new ParameterDiscreteValue();
                prmCoilCodsec.Value = coilCodsec;

                ParameterField pfldCoilCodsec = new ParameterField();
                pfldCoilCodsec.Name = "coilLabelCodsec";
                pfldCoilCodsec.CurrentValues.Add(prmCoilCodsec);
                pfldCoilCodsec.HasCurrentValue = true;

                for (int i = 0; i < rptCoilLabel.ParameterFields.Count; i++)
                {
                    switch (rptCoilLabel.ParameterFields[i].Name)
                    {
                        case "coilLabelCodsec":
                            rptCoilLabel.ParameterFields[i].CurrentValues.Clear();
                            rptCoilLabel.ParameterFields[i].CurrentValues.Add(prmCoilCodsec);
                            rptCoilLabel.ParameterFields[i].HasCurrentValue = true;
                            rptCoilLabel.ParameterFields[i].DefaultValues.Clear();
                            rptCoilLabel.ParameterFields[i].DefaultValues.Add(prmCoilCodsec);
                            break;
                        default:
                            break;
                    }
                }

                PrinterSettings printerSettings = new PrinterSettings();
                rptCoilLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                rptCoilLabel.PrintToPrinter(2, false, 0, 0);
                rptCoilLabel.Close();
                rptCoilLabel.Dispose();
            }
        }
        
        private void printObservationCoilLabel(int coilCodsec)
        {
            Reports.rptCoilLabelObservation rptCoilLabel = new Reports.rptCoilLabelObservation();

            ParameterDiscreteValue prmCoilCodsec = new ParameterDiscreteValue();
            prmCoilCodsec.Value = coilCodsec;

            ParameterField pfldCoilCodsec = new ParameterField();
            pfldCoilCodsec.Name = "coilLabelCodsec";
            pfldCoilCodsec.CurrentValues.Add(prmCoilCodsec);
            pfldCoilCodsec.HasCurrentValue = true;

            for (int i = 0; i < rptCoilLabel.ParameterFields.Count; i++)
            {
                switch (rptCoilLabel.ParameterFields[i].Name)
                {
                    case "coilLabelCodsec":
                        rptCoilLabel.ParameterFields[i].CurrentValues.Clear();
                        rptCoilLabel.ParameterFields[i].CurrentValues.Add(prmCoilCodsec);
                        rptCoilLabel.ParameterFields[i].HasCurrentValue = true;
                        rptCoilLabel.ParameterFields[i].DefaultValues.Clear();
                        rptCoilLabel.ParameterFields[i].DefaultValues.Add(prmCoilCodsec);
                        break;
                    default:
                        break;
                }
            }

            PrinterSettings printerSettings = new PrinterSettings();
            rptCoilLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
            rptCoilLabel.PrintToPrinter(1, false, 0, 0);
            rptCoilLabel.Close();
            rptCoilLabel.Dispose();
        }
        
        private void frmRewindCoil_Load(object sender, EventArgs e)
        {
            tbpRewinedCoil.Enabled = false;
            List<clsCuttingQuality> lstCuttingQuality = clsCuttingQuality.getList();
            List<clsMachine> lstMachine = clsMachine.getBalanceMachineList();

            for (int i = 0; i < lstCuttingQuality.Count; i++)
                cmbQuality.Items.Add(lstCuttingQuality[i]);
        }
        
        private void txtOriginalCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                objCoil = clsCoil.getDetailByCode(txtOriginalCode.Text);
                objCoilCellar = clsCoil.getContainerCellarByCoil(objCoil.codsec);
                objCuttingStop = clsCoil.getCuttingStopByCoil(objCoil.codsec);
                objProduct.load(objCoil.fkProduct);

                if ("Conversión" == objCoilCellar.name || "Producto en Proceso"== objCoilCellar.name || "Bobinas Base y metalizado"== objCoilCellar.name || "Corte, metalizado y empaque"== objCoilCellar.name || "Producto en Proceso Pilar"== objCoilCellar.name || "Rack Metalizado"== objCoilCellar.name)
                {
                    if (objCoil.codsec != 0)
                    {
                        isValid = true;
                        if (objCoilCellar.isRewindCellar)
                        {
                            lblOriginalQuality.Text = objCoil.CuttingQualityName;
                            lblOriginalDiameter.Text = Convert.ToString(Math.Round(objCoil.diameter, 2));
                            lblOriginalDensity.Text = Convert.ToString(Math.Round(objCoil.density, 5));
                            lblOriginalNetWeigth.Text = Convert.ToString(Math.Round(objCoil.netWeight, 2));
                            lblOriginalGrossWeigth.Text = Convert.ToString(Math.Round(objCoil.grossWeight, 2));
                            lblOriginalLength.Text = Convert.ToString(Math.Round(objCoil.length, 2));
                            lblOriginalCellar.Text = objCoil.Coil_CoilCellarContainer.name;
                            lblOriginalWidth.Text = objCoil.width.ToString();
                            lblOriginalFilmName.Text = objProduct.name;

                            if (objCoil.treatmentSide == "Externo")
                                rdoTreatmentExternal.Checked = true;
                            else if (objCoil.treatmentSide == "Interno")
                                rdoTreatmentInner.Checked = true;
                            else if (objCoil.treatmentSide == "Doble")
                                rdoTreatmentDouble.Checked = true;
                            else if (objCoil.treatmentSide == "Sin tratamiento")
                                rdoTreatmentWithout.Checked = true;

                            txtNotes.Text = objCoil.notes;
                        }
                        else
                        {
                            MessageBox.Show("La bobina seleccionada no se encuentra en la bodega correspondiente para realizar el rebobinado.", "Rebobinado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                            lblOriginalQualityLabel.Text = "";
                            lblOriginalDiameterLabel.Text = "0";
                            lblOriginalDensity.Text = "0";
                            lblOriginalNetWeigth.Text = "0";
                            lblOriginalGrossWeigthLabel.Text = "0";
                            lblOriginalLength.Text = "0";
                            lblOriginalCellar.Text = "";
                            lblOriginalWidth.Text = "0";
                            lblOriginalQuality.Text = "";
                            txtOriginalCode.Text = "";
                            txtOriginalCode.Focus();
                            objCoil = new clsCoil();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No puede modificar una bobina que se encuentre en bodega de " + objCoilCellar.name + " por favor solicite a bodega que extraigan el pallet a BODEGA DE PRODUCTO EN PROCESO o CONVERSION", "Rebobinado", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    txtOriginalCode.Focus();
                    objCoil = new clsCoil();
                    objCoilCellar = new clsCoilCellar();
                    objCuttingStop = new clsCuttingStop();
                    objSalesOrderDetail = new clsSalesOrderDetail();
                    objSalesOrder = new clsSalesOrder();
                }
            }
        }

        private void btnRewind_Click(object sender, EventArgs e)
        {
            if (isValid)
            {
                if(objCoil.fkPallet==0)
                {
                    if (objCoil.fkStatus == 33)
                    {
                        int lastDigit = 0;
                        int newDigit = 0;

                        tbpRewinedCoil.Enabled = true;
                        tbcRewind.SelectedIndex = 1;
                        lastDigit = Convert.ToInt32(txtOriginalCode.Text.Substring(txtOriginalCode.Text.Length - 1));
                        clsMainCoilMetal met = new clsMainCoilMetal(txtOriginalCode.Text, true, true);
                        if (!objCoil.isExternalCoil && met.codsec == 0)
                        {
                            lastDigit++;
                            lblCode.Text = txtOriginalCode.Text.Substring(0, txtOriginalCode.Text.Length - 1) + lastDigit.ToString();
                            string end = lblCode.Text.Substring(lblCode.Text.Length - 3, 3).Replace("C", "A");
                            lblCode.Text = lblCode.Text.Substring(0, lblCode.Text.Length - 3) + end;
                        }
                        else
                        {
                            if (!objCoil.wasRewined) // No fue rebobinada y es externa.
                            {
                                newDigit++; // Primer valor en 1.
                                lblCode.Text = txtOriginalCode.Text + "A01"; // Se agrega un digito sobre el final, que en primer
                                // instancia, estaria en 1.
                            }
                            else
                            {
                                // Fue rebobinada y es externa.
                                lastDigit++; // El lastdigit en la segunda vuelta me sirve, por que en teoriaya pasó por lo de arriba.
                                lblCode.Text = txtOriginalCode.Text.Substring(0, txtOriginalCode.Text.Length - 1) + lastDigit.ToString();
                                string end = lblCode.Text.Substring(lblCode.Text.Length - 3, 3).Replace("C", "A");
                                lblCode.Text = lblCode.Text.Substring(0, lblCode.Text.Length - 3) + end;
                                // los agrego al final. 
                            }
                        }
                        lblFilmName.Text = lblOriginalFilmName.Text;
                        lblWidth.Text = lblOriginalWidth.Text;
                    }
                    else
                    {
                        MessageBox.Show("La bobina ingresada no se encuentra activa. No se puede realizar el rebobinado.", "Rebobinado", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }
                }
                else
                {
                    MessageBox.Show("La bobina ingresada se encuentra dentro de un pallet. No se puede realizar el rebobinado.", "Rebobinado", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
                 
            }
        }

        private void txtGrossWeigth_TextChanged(object sender, EventArgs e)     
        {
            if (clsGlobal.isNumeric(txtGrossWeigth.Text))
            {
                if (txtGrossWeigth.Text != "0")
                {
                    double netWeigth = Convert.ToDouble(txtGrossWeigth.Text) - (objProduct.width * (new clsCore(objProduct.fkCore)).weigthPerMilimeter);
                    lblNetWeigth.Text = Convert.ToString(Math.Round(netWeigth, 2));
                    lblDensity.Text = Convert.ToString(clsCoil.getCoilDensity(Convert.ToDouble(lblNetWeigth.Text), Convert.ToDouble(txtDiameter.Text), new clsCore(objProduct.fkCore), objProduct.width));
                }
            }
            else
                MessageBox.Show("El valor debe ser Numérico", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                if(objCoil.fkStatus==33)
                {
                    if(Convert.ToDouble(lblNetWeigth.Text)<=objCoil.netWeight)
                    {
                        clsCoil coilRewined = new clsCoil();

                        int saleOrderDetail = 0;
                        bool deleteCoilPerSaleOrder = false;

                        saleOrderDetail = clsCoil.getFkSaleOrderByCoilCodsec(Convert.ToInt32(objCoil.codsec));

                        deleteCoilPerSaleOrder = coilRewined.deleteCoilPerSalesOrderDetail(objCoil.codsec); // si da true se borro correctamente la bobina vieja de la sale order.

                        coilRewined.fkBalance = objCoil.fkBalance;
                        coilRewined.fkProduct = objCoil.fkProduct;
                        coilRewined.fkCuttingQuality = ((clsCuttingQuality)cmbQuality.SelectedItem).codsec;
                        coilRewined.code = lblCode.Text;
                        coilRewined.length = Convert.ToDouble(txtLength.Text);
                        coilRewined.width = objProduct.width;
                        coilRewined.diameter = Convert.ToDouble(txtDiameter.Text);
                        coilRewined.density = Convert.ToDouble(lblDensity.Text);
                        coilRewined.cuttingPosition = objCoil.cuttingPosition;
                        coilRewined.cuttingStop = objCoil.cuttingStop;
                        coilRewined.netWeight = Convert.ToDouble(lblNetWeigth.Text);
                        coilRewined.grossWeight = Convert.ToDouble(txtGrossWeigth.Text);
                        coilRewined.modifiedDate = DateTime.Now;
                        coilRewined.createdBy = objCoil.createdBy;
                        coilRewined.modifiedBy = clsGlobal.LoggedUser.codsec;
                        coilRewined.treatmentSide = "Externo";
                        coilRewined.externalLabelPrint = objCoil.externalLabelPrint;
                        coilRewined.defects = objCoil.defects;
                        coilRewined.notes = txtNotes.Text;
                        coilRewined.wasRewined = true;

                        if (objCoil.isExternalCoil) // Se fija si la madre es importada. 
                        {
                            coilRewined.isExternalCoil = true;
                        }
                        else
                        {
                            coilRewined.isExternalCoil = false;
                        }

                        coilRewined.mainCoilCode = objCoil.mainCoilCode;
                        coilRewined.lotNumber = objCoil.lotNumber;
                        coilRewined.cellar = objCoil.cellar;

                        coilRewined.fkStatus = 33;

                        if (coilRewined.save())
                        {
                            clsCoilByCoilCellar Cellar = new clsCoilByCoilCellar();
                            clsCoil coil = new clsCoil();
                            clsCoilMovements movimientoBobina = new clsCoilMovements();

                            movimientoBobina.type = "Se rebobino " + objCoil.code + " y se genero" + coilRewined.code.ToString();
                            movimientoBobina.fkCoil = coilRewined.codsec;
                            movimientoBobina.fkDestCellar = coilRewined.fkCoilCellar;
                            movimientoBobina.fkOrgCellar = coilRewined.fkCoilCellar;
                            movimientoBobina.fkUser = clsGlobal.LoggedUser.codsec;
                            movimientoBobina.date = DateTime.Now;
                            movimientoBobina.save();

                            coil = clsCoil.getAllByCode(coilRewined.code);
                            clsCoil.setCoilAsRewined(objCoil.codsec);

                            if (deleteCoilPerSaleOrder)
                            {
                                clsCoil.assignToSalesOrder(coil.codsec, saleOrderDetail); // Aca ya andaria y lo doi de alta nuevamente en la orden de compra que estaba.
                            }

                            if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)
                            {
                                Cellar.fkCoil = coil.codsec;
                                Cellar.fkCoilCellar = 4014;
                                Cellar.In = true;
                                Cellar.date = DateTime.Now;
                            }
                            else
                            {
                                Cellar.fkCoil = coil.codsec;
                                Cellar.fkCoilCellar = 11;
                                Cellar.In = true;
                                Cellar.date = DateTime.Now;
                            }

                            Cellar.save();
                            MessageBox.Show("El proceso de rebobinado se ha registrado con éxito, por favor imprima las nuevas etiquetas de la bobina.", "Rebobinado de bobinas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                            tbcRewind.SelectedIndex = 0;
                            lblCode.Text = string.Empty;
                            lblDensity.Text = "0";
                            txtDiameter.Text = "0";
                            lblNetWeigth.Text = "0";
                            txtGrossWeigth.Text = "0";
                            txtLength.Text = "0";
                            cmbQuality.SelectedItem = -1;
                            cmbQuality.SelectedIndex = -1;
                            cmbQuality.Text = string.Empty;
                            lblWidth.Text = string.Empty;
                            txtNotes.Clear();
                            if (MessageBox.Show("Desea imprimir la etiqueta?", "Registro de Bobina", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                            {

                                if (cmbQuality.Text != "Observación")
                                {
                                    Thread thrdPrint = new Thread(delegate() { printCoilLabel(coilRewined.codsec); });
                                    thrdPrint.Start();
                                }
                                else
                                {
                                    Thread thrdPrint = new Thread(delegate() { printObservationCoilLabel(coilRewined.codsec); });
                                    thrdPrint.Start();

                                }

                            }
                            MessageBox.Show("La bobina se ha guardado con éxito.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        }
                        else
                            MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Rebobinado de bobinas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }
                    else
                    {
                        MessageBox.Show("No se puede ingresar un peso neto mayor al de la bobina original. Corrija los datos e intente nuevamente.", "Rebobinado de bobinas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        txtGrossWeigth.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("La bobina ingresada no se encuentra activa. No se puede realizar el rebobinado.", "Rebobinado", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
            }
        }

        private void btnMainCoilExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     
    }
}
