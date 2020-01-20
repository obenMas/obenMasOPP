using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using BPS.Bussiness;
using BPS.Reporting.ProductionReports.SalesOrderEffience;

namespace BPS
{
    public partial class frmEficiencySalesOrder : Form
    {
        int isInternation = 0;
        string initdate = string.Empty, enddate = string.Empty;

        public frmEficiencySalesOrder()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpInitDate.Value.CompareTo(dtpEndDate.Value) < 0)
                {
                    if (cmborder.SelectedIndex > -1)
                    {
                        if (cmborder.SelectedItem.ToString() == "Nacional")
                            isInternation = 0;
                        else
                            isInternation = 1;

                        loadReports();
                    }
                    else
                        MessageBox.Show("Debe seleccionar el tipo de Orden", "Eficiencias Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dtpInitDate.Value.CompareTo(dtpEndDate.Value) == 0)
                    MessageBox.Show("Las fechas no pueden ser iguales por favor cambie las fechas", "Eficiencias Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (dtpInitDate.Value.CompareTo(dtpEndDate.Value) > 0)
                    MessageBox.Show("La fecha inicio no pueden ser mayor que la fecha fin", "Eficiencias Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eficiencia de Pedido", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                throw;
            }
        }



        private void loadReports()
        {

            rptEffienceSalesOrder rptEffienceSalesOrder = new rptEffienceSalesOrder();

            Tables tables;

            tables = rptEffienceSalesOrder.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
            {
                TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                table.ApplyLogOnInfo(tableLogonInfo);
            }

            Sections sections = rptEffienceSalesOrder.ReportDefinition.Sections;
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

            ParameterDiscreteValue prminitdate = new ParameterDiscreteValue();
            var init = dtpInitDate.Value.Date.ToString("dd/MM/yyyy HH:mm:ss");
            prminitdate.Value = init;

            ParameterDiscreteValue prmenddate = new ParameterDiscreteValue();
            var end = dtpEndDate.Value.Date.ToString("dd/MM/yyyy HH:mm:ss");

            prmenddate.Value = end.Replace("00:00:00", "23:59:59");

            ParameterDiscreteValue prmisinternational = new ParameterDiscreteValue();
            prmisinternational.Value = isInternation;

            for (int i = 0; i < rptEffienceSalesOrder.ParameterFields.Count; i++)
            {
                switch (rptEffienceSalesOrder.ParameterFields[i].Name)
                {
                    case "initdate":
                        rptEffienceSalesOrder.ParameterFields[i].CurrentValues.Clear();
                        rptEffienceSalesOrder.ParameterFields[i].CurrentValues.Add(prminitdate);
                        rptEffienceSalesOrder.ParameterFields[i].HasCurrentValue = true;
                        rptEffienceSalesOrder.ParameterFields[i].DefaultValues.Clear();
                        rptEffienceSalesOrder.ParameterFields[i].DefaultValues.Add(prminitdate);
                        break;

                    case "enddate":
                        rptEffienceSalesOrder.ParameterFields[i].CurrentValues.Clear();
                        rptEffienceSalesOrder.ParameterFields[i].CurrentValues.Add(prmenddate);
                        rptEffienceSalesOrder.ParameterFields[i].HasCurrentValue = true;
                        rptEffienceSalesOrder.ParameterFields[i].DefaultValues.Clear();
                        rptEffienceSalesOrder.ParameterFields[i].DefaultValues.Add(prmenddate);
                        break;

                    case "isInternational":
                        rptEffienceSalesOrder.ParameterFields[i].CurrentValues.Clear();
                        rptEffienceSalesOrder.ParameterFields[i].CurrentValues.Add(prmisinternational);
                        rptEffienceSalesOrder.ParameterFields[i].HasCurrentValue = true;
                        rptEffienceSalesOrder.ParameterFields[i].DefaultValues.Clear();
                        rptEffienceSalesOrder.ParameterFields[i].DefaultValues.Add(prmisinternational);
                        break;

                    default:
                        break;
                }
            }


            crvEffience.ReportSource = rptEffienceSalesOrder;
        }
    }
}
