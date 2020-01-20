using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms; 
using System.Globalization;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmSalesOrderByReport : Form
    {
        public frmSalesOrderByReport()
        {
            InitializeComponent();
        }

        private void frmSalesOrderByReport_Load(object sender, EventArgs e)
        {
            PopulateData();
        }

        private void PopulateData()
        {
            List<clsSalesOrderByReport> lstSaleOrderByReport = new List<clsSalesOrderByReport>();
            lstSaleOrderByReport = clsSalesOrderByReport.Load();

            for (int i = 0; i < lstSaleOrderByReport.Count; i++)
            {
                dgvSalesOrder.Rows.Add();
                dgvSalesOrder.Rows[i].Cells[clmYearCreatedDate.Index].Value = lstSaleOrderByReport[i].yearcreateddate;
                dgvSalesOrder.Rows[i].Cells[clmMonthCreateDate.Index].Value = lstSaleOrderByReport[i].createddate.ToString("MMMM");
                dgvSalesOrder.Rows[i].Cells[clmCreateDate.Index].Value = lstSaleOrderByReport[i].createddate;
                dgvSalesOrder.Rows[i].Cells[clmCompanyName.Index].Value = lstSaleOrderByReport[i].companyname;
                dgvSalesOrder.Rows[i].Cells[clmProductName.Index].Value = lstSaleOrderByReport[i].productname;
                dgvSalesOrder.Rows[i].Cells[clmQuantity.Index].Value = lstSaleOrderByReport[i].quantity;
                dgvSalesOrder.Rows[i].Cells[clmPrice.Index].Value = lstSaleOrderByReport[i].price;
                dgvSalesOrder.Rows[i].Cells[clmWeigth.Index].Value = lstSaleOrderByReport[i].width;
                var validateboppcode = (lstSaleOrderByReport[i].boppcode != "" || lstSaleOrderByReport[i].boppcode.Length != 0) ? dgvSalesOrder.Rows[i].Cells[clmType.Index].Value = lstSaleOrderByReport[i].boppcode.Replace("-", "").Substring(0,2) : dgvSalesOrder.Rows[i].Cells[clmType.Index].Value = lstSaleOrderByReport[i].systemcode.Replace("-", "").Substring(0,2);
                var validatethickness = (lstSaleOrderByReport[i].thicknessvalue != "" || lstSaleOrderByReport[i].thicknessvalue.Length != 0) ? dgvSalesOrder.Rows[i].Cells[clmThickness.Index].Value = lstSaleOrderByReport[i].thicknessvalue : dgvSalesOrder.Rows[i].Cells[clmThickness.Index].Value = "0";
                var validatefamily = (lstSaleOrderByReport[i].familyname != "" || lstSaleOrderByReport[i].familyname.Length != 0) ? dgvSalesOrder.Rows[i].Cells[clmFamily.Index].Value = lstSaleOrderByReport[i].familyname : dgvSalesOrder.Rows[i].Cells[clmFamily.Index].Value = "No espedificado";
                var validaterelation = (lstSaleOrderByReport[i].iscustomer == 1) ? dgvSalesOrder.Rows[i].Cells[clmRelation.Index].Value = "Cliente" : dgvSalesOrder.Rows[i].Cells[clmRelation.Index].Value = "Distribuidor";
                dgvSalesOrder.Rows[i].Cells[clmPais.Index].Value = lstSaleOrderByReport[i].countryname;
            }
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    myExcel.Application ExcelApp = new myExcel.Application();
            //    ExcelApp.Application.Workbooks.Add(Type.Missing);
            //    ExcelApp.Columns.ColumnWidth = 20;
            //    for (int i = 0; i < dgvSalesOrder.Rows.Count; i++)
            //    {
            //        DataGridViewRow File = dgvSalesOrder.Rows[i];
            //        for (int j = 0; j < File.Cells.Count; j++)
            //        {
            //            ExcelApp.Cells[i + 1, j + 1] = File.Cells[j].Value;
            //        }
            //    }

            //    SaveFileDialog Dialog = new SaveFileDialog();
            //    Dialog.DefaultExt = "xls";
            //    Dialog.Filter = "xls file(*.xls)|*.xls";
            //    Dialog.AddExtension = true;
            //    Dialog.RestoreDirectory = true;
            //    Dialog.Title = "Guardar";
            //    Dialog.InitialDirectory = @"C:\";
            //    if (Dialog.ShowDialog() == DialogResult.OK)
            //    {
            //        ExcelApp.ActiveWorkbook.SaveCopyAs(Dialog.FileName);
            //        ExcelApp.ActiveWorkbook.Saved = true;
            //        Dialog.Dispose();
            //        Dialog = null;
            //        ExcelApp.Quit();
            //        MessageBox.Show("Datos exportados correctamente", "Ventas Nacionales", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show("No se pudo exportar datos", "Ventas Nacionales", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("No se pudo exportar datos", "Ventas Nacionales", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnExportToExcelI_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    myExcelII.Application excel = new myExcelII.Application();
            //    excel.Application.Workbooks.Add(true);
            //    excel.Columns.ColumnWidth = 16;
            //    int ColumnIndex = 0;
            //    foreach (DataGridViewColumn col in dgvSalesOrder.Columns)
            //    {
            //        ColumnIndex++;
            //        excel.Cells[1, ColumnIndex] = col.HeaderText;
            //    }
            //    int rowIndex = 0;
            //    foreach (DataGridViewRow row in dgvSalesOrder.Rows)
            //    {
            //        rowIndex++;
            //        ColumnIndex = 0;
            //        foreach (DataGridViewColumn col in dgvSalesOrder.Columns)
            //        {
            //            ColumnIndex++;
            //            excel.Cells[rowIndex + 1, ColumnIndex] = row.Cells[col.Name].Value;
            //        }
            //    }
            //    MessageBox.Show("Datos exportados correctamente", "Ventas Nacionales", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    excel.Visible = true;
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("No se pudo exportar datos", "Ventas Nacionales", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
