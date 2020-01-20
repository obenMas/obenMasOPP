using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms; 
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Drawing.Printing;
using System.Threading;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmGroupCoils : Form
    {
        clsProduct objProduct = new clsProduct();
        List<clsCoil> lstCoil = new List<clsCoil>();

        public frmGroupCoils()
        {
            InitializeComponent();
        }
        private void printCoilLabel()
        {

            Reports.rptGroupCoilLabel rptGroupCoilLabel = new Reports.rptGroupCoilLabel();

            Tables tables;

            tables = rptGroupCoilLabel.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
            {
                TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                table.ApplyLogOnInfo(tableLogonInfo);
            }

            Sections sections = rptGroupCoilLabel.ReportDefinition.Sections;
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

            //filmCode
            ParameterDiscreteValue prmFilmCode = new ParameterDiscreteValue();
            prmFilmCode.Value = (lstCoil[0].fkBopp != 0) ? (new clsBopp(lstCoil[0].fkBopp).code) : (new clsCast(lstCoil[0].fkCast).code);

            ParameterField pfldFilmCode = new ParameterField();
            pfldFilmCode.Name = "filmCode";
            pfldFilmCode.CurrentValues.Add(prmFilmCode);
            pfldFilmCode.HasCurrentValue = true;

            //treatment
            ParameterDiscreteValue prmTreatment = new ParameterDiscreteValue();
            prmTreatment.Value = lstCoil[0].treatmentSide.Substring(0, 3);

            ParameterField pfldTreatment = new ParameterField();
            pfldTreatment.Name = "treatment";
            pfldTreatment.CurrentValues.Add(prmTreatment);
            pfldTreatment.HasCurrentValue = true;

            //customer
            ParameterDiscreteValue prmCustomer = new ParameterDiscreteValue();
            prmCustomer.Value = lstCoil[0].customerName;

            ParameterField pfldCustomer = new ParameterField();
            pfldCustomer.Name = "customer";
            pfldCustomer.CurrentValues.Add(prmCustomer);
            pfldCustomer.HasCurrentValue = true;

            //orderNumber
            ParameterDiscreteValue prmOrderNumber = new ParameterDiscreteValue();
            prmOrderNumber.Value = lstCoil[0].salesOrderNumber;

            ParameterField pfldOrderNumber = new ParameterField();
            pfldOrderNumber.Name = "customer";
            pfldOrderNumber.CurrentValues.Add(prmOrderNumber);
            pfldOrderNumber.HasCurrentValue = true;

            //destination
            ParameterDiscreteValue prmDestination = new ParameterDiscreteValue();
            prmDestination.Value = new clsEntity(lstCoil[0].fkEntity).countryName;

            ParameterField pfldDestination = new ParameterField();
            pfldDestination.Name = "customer";
            pfldDestination.CurrentValues.Add(prmDestination);
            pfldDestination.HasCurrentValue = true;

            //width
            ParameterDiscreteValue prmWidth = new ParameterDiscreteValue();
            prmWidth.Value = lstCoil[0].width;

            ParameterField pfldWidth = new ParameterField();
            pfldWidth.Name = "customer";
            pfldWidth.CurrentValues.Add(prmWidth);
            pfldWidth.HasCurrentValue = true;

            //netWeight
            double netWeight = 0;
            for (int i = 0; i < lstCoil.Count; i++)
                netWeight += lstCoil[0].netWeight;

            ParameterDiscreteValue prmNetWeight = new ParameterDiscreteValue();
            prmNetWeight.Value = netWeight;

            ParameterField pfldNetWeight = new ParameterField();
            pfldNetWeight.Name = "customer";
            pfldNetWeight.CurrentValues.Add(prmNetWeight);
            pfldNetWeight.HasCurrentValue = true;

            //grossWeight
            double grossWeight = 0;
            for (int i = 0; i < lstCoil.Count; i++)
                grossWeight += lstCoil[0].grossWeight;

            ParameterDiscreteValue prmGrossWeight = new ParameterDiscreteValue();
            prmGrossWeight.Value = netWeight;

            ParameterField pfldGrossWeight = new ParameterField();
            pfldGrossWeight.Name = "customer";
            pfldGrossWeight.CurrentValues.Add(prmGrossWeight);
            pfldGrossWeight.HasCurrentValue = true;

            //length
            double length = 0;
            for (int i = 0; i < lstCoil.Count; i++)
                length += lstCoil[0].length;

            length = length / lstCoil.Count;

            ParameterDiscreteValue prmLength = new ParameterDiscreteValue();
            prmLength.Value = length;

            ParameterField pfldLength = new ParameterField();
            pfldLength.Name = "customer";
            pfldLength.CurrentValues.Add(prmLength);
            pfldLength.HasCurrentValue = true;

            //diameter
            double diameter = 0;
            for (int i = 0; i < lstCoil.Count; i++)
                diameter += lstCoil[0].diameter;

            diameter = diameter / lstCoil.Count;

            ParameterDiscreteValue prmDiameter = new ParameterDiscreteValue();
            prmDiameter.Value = diameter;

            ParameterField pfldDiameter = new ParameterField();
            pfldDiameter.Name = "customer";
            pfldDiameter.CurrentValues.Add(prmDiameter);
            pfldDiameter.HasCurrentValue = true;

            //density
            double density = 0;
            for (int i = 0; i < lstCoil.Count; i++)
                density += lstCoil[0].density;

            density = density / lstCoil.Count;

            ParameterDiscreteValue prmDensity = new ParameterDiscreteValue();
            prmDensity.Value = density;

            ParameterField pfldDensity = new ParameterField();
            pfldDensity.Name = "customer";
            pfldDensity.CurrentValues.Add(prmDensity);
            pfldDensity.HasCurrentValue = true;

            //density
            string coilCodesList = "";
            for (int i = 0; i < lstCoil.Count; i++)
                coilCodesList += lstCoil[0].code + "          ";
            
            ParameterDiscreteValue prmCoilCodesList = new ParameterDiscreteValue();
            prmCoilCodesList.Value = coilCodesList;

            ParameterField pfldCoilCodesList = new ParameterField();
            pfldCoilCodesList.Name = "customer";
            pfldCoilCodesList.CurrentValues.Add(prmCoilCodesList);
            pfldCoilCodesList.HasCurrentValue = true;

            for (int i = 0; i < rptGroupCoilLabel.ParameterFields.Count; i++)
            {
                switch (rptGroupCoilLabel.ParameterFields[i].Name)
                {
                    case "filmCode":
                        rptGroupCoilLabel.ParameterFields[i].CurrentValues.Clear();
                        rptGroupCoilLabel.ParameterFields[i].CurrentValues.Add(prmFilmCode);
                        rptGroupCoilLabel.ParameterFields[i].HasCurrentValue = true;
                        rptGroupCoilLabel.ParameterFields[i].DefaultValues.Clear();
                        rptGroupCoilLabel.ParameterFields[i].DefaultValues.Add(prmFilmCode);
                        break;
                    case "treatment":
                        rptGroupCoilLabel.ParameterFields[i].CurrentValues.Clear();
                        rptGroupCoilLabel.ParameterFields[i].CurrentValues.Add(prmTreatment);
                        rptGroupCoilLabel.ParameterFields[i].HasCurrentValue = true;
                        rptGroupCoilLabel.ParameterFields[i].DefaultValues.Clear();
                        rptGroupCoilLabel.ParameterFields[i].DefaultValues.Add(prmTreatment);
                        break;
                    case "customer":
                        rptGroupCoilLabel.ParameterFields[i].CurrentValues.Clear();
                        rptGroupCoilLabel.ParameterFields[i].CurrentValues.Add(prmCustomer);
                        rptGroupCoilLabel.ParameterFields[i].HasCurrentValue = true;
                        rptGroupCoilLabel.ParameterFields[i].DefaultValues.Clear();
                        rptGroupCoilLabel.ParameterFields[i].DefaultValues.Add(prmCustomer);
                        break;
                    case "orderNumber":
                        rptGroupCoilLabel.ParameterFields[i].CurrentValues.Clear();
                        rptGroupCoilLabel.ParameterFields[i].CurrentValues.Add(prmOrderNumber);
                        rptGroupCoilLabel.ParameterFields[i].HasCurrentValue = true;
                        rptGroupCoilLabel.ParameterFields[i].DefaultValues.Clear();
                        rptGroupCoilLabel.ParameterFields[i].DefaultValues.Add(prmOrderNumber);
                        break;
                    case "destination":
                        rptGroupCoilLabel.ParameterFields[i].CurrentValues.Clear();
                        rptGroupCoilLabel.ParameterFields[i].CurrentValues.Add(prmDestination);
                        rptGroupCoilLabel.ParameterFields[i].HasCurrentValue = true;
                        rptGroupCoilLabel.ParameterFields[i].DefaultValues.Clear();
                        rptGroupCoilLabel.ParameterFields[i].DefaultValues.Add(prmDestination);
                        break;
                    case "width":
                        rptGroupCoilLabel.ParameterFields[i].CurrentValues.Clear();
                        rptGroupCoilLabel.ParameterFields[i].CurrentValues.Add(prmWidth);
                        rptGroupCoilLabel.ParameterFields[i].HasCurrentValue = true;
                        rptGroupCoilLabel.ParameterFields[i].DefaultValues.Clear();
                        rptGroupCoilLabel.ParameterFields[i].DefaultValues.Add(prmWidth);
                        break;
                    case "netWeight":
                        rptGroupCoilLabel.ParameterFields[i].CurrentValues.Clear();
                        rptGroupCoilLabel.ParameterFields[i].CurrentValues.Add(prmNetWeight);
                        rptGroupCoilLabel.ParameterFields[i].HasCurrentValue = true;
                        rptGroupCoilLabel.ParameterFields[i].DefaultValues.Clear();
                        rptGroupCoilLabel.ParameterFields[i].DefaultValues.Add(prmNetWeight);
                        break;
                    case "grossWeight":
                        rptGroupCoilLabel.ParameterFields[i].CurrentValues.Clear();
                        rptGroupCoilLabel.ParameterFields[i].CurrentValues.Add(prmGrossWeight);
                        rptGroupCoilLabel.ParameterFields[i].HasCurrentValue = true;
                        rptGroupCoilLabel.ParameterFields[i].DefaultValues.Clear();
                        rptGroupCoilLabel.ParameterFields[i].DefaultValues.Add(prmGrossWeight);
                        break;
                    case "length":
                        rptGroupCoilLabel.ParameterFields[i].CurrentValues.Clear();
                        rptGroupCoilLabel.ParameterFields[i].CurrentValues.Add(prmLength);
                        rptGroupCoilLabel.ParameterFields[i].HasCurrentValue = true;
                        rptGroupCoilLabel.ParameterFields[i].DefaultValues.Clear();
                        rptGroupCoilLabel.ParameterFields[i].DefaultValues.Add(prmLength);
                        break;
                    case "diameter":
                        rptGroupCoilLabel.ParameterFields[i].CurrentValues.Clear();
                        rptGroupCoilLabel.ParameterFields[i].CurrentValues.Add(prmDiameter);
                        rptGroupCoilLabel.ParameterFields[i].HasCurrentValue = true;
                        rptGroupCoilLabel.ParameterFields[i].DefaultValues.Clear();
                        rptGroupCoilLabel.ParameterFields[i].DefaultValues.Add(prmDiameter);
                        break;
                    case "density":
                        rptGroupCoilLabel.ParameterFields[i].CurrentValues.Clear();
                        rptGroupCoilLabel.ParameterFields[i].CurrentValues.Add(prmDensity);
                        rptGroupCoilLabel.ParameterFields[i].HasCurrentValue = true;
                        rptGroupCoilLabel.ParameterFields[i].DefaultValues.Clear();
                        rptGroupCoilLabel.ParameterFields[i].DefaultValues.Add(prmDensity);
                        break;
                    case "coilCodesList":
                        rptGroupCoilLabel.ParameterFields[i].CurrentValues.Clear();
                        rptGroupCoilLabel.ParameterFields[i].CurrentValues.Add(prmCoilCodesList);
                        rptGroupCoilLabel.ParameterFields[i].HasCurrentValue = true;
                        rptGroupCoilLabel.ParameterFields[i].DefaultValues.Clear();
                        rptGroupCoilLabel.ParameterFields[i].DefaultValues.Add(prmCoilCodesList);
                        break;
                    default:
                        break;
                }
            }

            PrinterSettings printerSettings = new PrinterSettings();
            rptGroupCoilLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
            rptGroupCoilLabel.PrintToPrinter(2, false, 0, 0);
            
        }
        private void calculateGroupWeigth()
        {
            double groupNetWeigth = 0;
            double groupGrossWeigth = 0;

            for (int i = 0; i < dgvCoils.Rows.Count; i++)
            {
                groupNetWeigth += Convert.ToDouble(dgvCoils.Rows[i].Cells[clmCoilWeigth.Index].Value);
                groupGrossWeigth += Convert.ToDouble(dgvCoils.Rows[i].Cells[clmCoilGrossWeight.Index].Value);
            }
            lblNetWeigth.Text = groupNetWeigth.ToString();
            lblGrossWeigth.Text = groupGrossWeigth.ToString();
        }
        private void txtCoilCode_KeyDown(object sender, KeyEventArgs e)
        {
            clsCoil objCoil = new clsCoil();

            if (e.KeyCode == Keys.Enter)
            {
                if (dgvCoils.Rows.Count == 0)
                {
                    objCoil = clsCoil.getDetailByCode(txtCoilCode.Text);
                    if (objCoil.codsec != 0)
                    {
                        lstCoil.Add(objCoil);

                        objProduct = new clsProduct(objCoil.fkProduct);
                        lblFilmName.Text = objProduct.code;

                        dgvCoils.Rows.Add();
                        dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCodsec.Index].Value = objCoil.codsec;
                        dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCode.Index].Value = objCoil.code;
                        dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilLength.Index].Value = objCoil.length;
                        dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWeigth.Index].Value = Convert.ToString(Math.Round(objCoil.netWeight, 2));
                        dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilGrossWeight.Index].Value = Convert.ToString(Math.Round(objCoil.grossWeight, 2));
                        dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWidth.Index].Value = objCoil.width;
                        dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilAction.Index].Value = global::BPS.Properties.Resources.cross;

                        lblCoilCount.Text = "Bobinas : " + dgvCoils.Rows.Count.ToString();

                        lblCustomer.Text = objCoil.customerName;
                        lblSalesOrderNumber.Text = objCoil.salesOrderNumber;

                        calculateGroupWeigth();

                        txtCoilCode.Text = "";
                        txtCoilCode.Focus();
                    }
                }
                else
                {
                    objCoil = clsCoil.getDetailByCode(txtCoilCode.Text);
                    if (objCoil.codsec != 0)
                    {
                        lstCoil.Add(objCoil);

                        if (objCoil.fkProduct == objProduct.codsec)
                        {
                            dgvCoils.Rows.Add();
                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCodsec.Index].Value = objCoil.codsec;
                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCode.Index].Value = objCoil.code;
                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilLength.Index].Value = objCoil.length;
                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWeigth.Index].Value = Convert.ToString(Math.Round(objCoil.netWeight, 2));
                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilGrossWeight.Index].Value = Convert.ToString(Math.Round(objCoil.grossWeight, 2));
                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWidth.Index].Value = objCoil.width;
                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilAction.Index].Value = global::BPS.Properties.Resources.cross;

                            lblCoilCount.Text = "Bobinas : " + dgvCoils.Rows.Count.ToString();

                            calculateGroupWeigth();

                            txtCoilCode.Text = "";
                            txtCoilCode.Focus();
                        }
                        else
                            MessageBox.Show("La bobina seleccionada no coincide con el producto a ser ingresado en el pallet.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea imprimir la etiqueta?", "Agrupamiento de bobinas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
            {
                Thread thrdPrint = new Thread(delegate() { printCoilLabel(); });
                thrdPrint.Start();
            }
        }

        private void btnMainCoilExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
