﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace BPS
{
    public partial class frmBLDetail : Form
    {
        List<clsSalesOrder> lstSalesOrder = new List<clsSalesOrder>();
        DataSet DS = new DataSet();

        public frmBLDetail()
        {
            InitializeComponent();

            PopulateDGV();
        }
        public void getDataSet()
        {
            DS = clsConnection.getDataSetResult("SELECT * FROM vwDetalleDeBl");
        }

        #region Llenar el DGV

        public void PopulateDGV()
        {
            getDataSet();
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                dgvBLDetail.Rows.Add();
                dgvBLDetail.Rows[dgvBLDetail.Rows.Count - 1].Cells[clmOrder.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["Pedido"]);
                dgvBLDetail.Rows[dgvBLDetail.Rows.Count - 1].Cells[clmCustommer.Index].Value = DS.Tables[0].Rows[i]["Cliente"].ToString();
                dgvBLDetail.Rows[dgvBLDetail.Rows.Count - 1].Cells[clmPlant.Index].Value = DS.Tables[0].Rows[i]["Planta"].ToString();
                dgvBLDetail.Rows[dgvBLDetail.Rows.Count - 1].Cells[clmDateIn.Index].Value = DS.Tables[0].Rows[i]["FechaIngreso"];
                // Fecha de Entrega agregadas.
                dgvBLDetail.Rows[dgvBLDetail.Rows.Count - 1].Cells[clmDayIng.Index].Value = DS.Tables[0].Rows[i]["dayFechaIngreso"];
                dgvBLDetail.Rows[dgvBLDetail.Rows.Count - 1].Cells[clmMonthIng.Index].Value = DS.Tables[0].Rows[i]["monthFechaIngreso"];
                dgvBLDetail.Rows[dgvBLDetail.Rows.Count - 1].Cells[clmYearIng.Index].Value = DS.Tables[0].Rows[i]["yearFechaIngreso"];
                dgvBLDetail.Rows[dgvBLDetail.Rows.Count - 1].Cells[clmHourIng.Index].Value = DS.Tables[0].Rows[i]["HoraIngreso"];
                // Termina Aca
                dgvBLDetail.Rows[dgvBLDetail.Rows.Count - 1].Cells[clmFilm.Index].Value = DS.Tables[0].Rows[i]["Pelicula"].ToString();
                dgvBLDetail.Rows[dgvBLDetail.Rows.Count - 1].Cells[clmWidth.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["Ancho"]);
                dgvBLDetail.Rows[dgvBLDetail.Rows.Count - 1].Cells[clmDiameter.Index].Value = DS.Tables[0].Rows[i]["Diametro"].ToString();
                dgvBLDetail.Rows[dgvBLDetail.Rows.Count - 1].Cells[clmCore.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["Core"]);
                dgvBLDetail.Rows[dgvBLDetail.Rows.Count - 1].Cells[clmSolicitedQuantity.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadSolicitada"]),2);
                dgvBLDetail.Rows[dgvBLDetail.Rows.Count - 1].Cells[clmDepotQuantity.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadDeposito"]),2);
                dgvBLDetail.Rows[dgvBLDetail.Rows.Count - 1].Cells[clmQuantitySecond.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadSegundas"]),2);
                dgvBLDetail.Rows[dgvBLDetail.Rows.Count - 1].Cells[clmQuantityDelivered.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadEntregada"]),2);
                dgvBLDetail.Rows[dgvBLDetail.Rows.Count - 1].Cells[clmProgramationPending.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["PendienteProgramacion"]),2);
                dgvBLDetail.Rows[dgvBLDetail.Rows.Count - 1].Cells[clmCuttingPending.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["PendienteCorte"]),2);
                dgvBLDetail.Rows[dgvBLDetail.Rows.Count - 1].Cells[clmDeliveryPending.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["PendienteEntrega"]),2);
                dgvBLDetail.Rows[dgvBLDetail.Rows.Count - 1].Cells[clmDeliveredDate.Index].Value = DS.Tables[0].Rows[i]["FechaEntrega"];
                // Fechas de Entrega agregadas.
                dgvBLDetail.Rows[dgvBLDetail.Rows.Count - 1].Cells[clmDayEnt.Index].Value = DS.Tables[0].Rows[i]["dayFechaEntrega"];
                dgvBLDetail.Rows[dgvBLDetail.Rows.Count - 1].Cells[clmMonthEnt.Index].Value = DS.Tables[0].Rows[i]["monthFechaEntrega"];
                dgvBLDetail.Rows[dgvBLDetail.Rows.Count - 1].Cells[clmYearEnt.Index].Value = DS.Tables[0].Rows[i]["yearFechaEntrega"];
                dgvBLDetail.Rows[dgvBLDetail.Rows.Count - 1].Cells[clmHourEnt.Index].Value = DS.Tables[0].Rows[i]["HoraEntrega"];
                //Termina a aca
            }
        }

        #endregion

        #region Exportar a Excel

        private void btnExport_Click(object sender, EventArgs e)
        {
            string ext = string.Empty;

            dgvBLDetail.Columns["clmDayIng"].Visible = true;
            dgvBLDetail.Columns["clmMonthIng"].Visible = true;
            dgvBLDetail.Columns["clmYearIng"].Visible = true;
            dgvBLDetail.Columns["clmHourIng"].Visible = true;
            dgvBLDetail.Columns["clmDateIn"].Visible = false;

            dgvBLDetail.Columns["clmDayEnt"].Visible = true;
            dgvBLDetail.Columns["clmMonthEnt"].Visible = true;
            dgvBLDetail.Columns["clmYearEnt"].Visible = true;
            dgvBLDetail.Columns["clmHourEnt"].Visible = true;
            dgvBLDetail.Columns["clmDeliveredDate"].Visible = false;

            dgvBLDetail.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel 97-2003 WorkBook|*.xls|Excel WorkBook|*.xlsx|All Excel Files|*.xls;*.xlsx";
            string filename = System.IO.Path.GetFileName(sfd.FileName);

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Copy DataGridView results to clipboard
                copyAlltoClipboard();

                object misValue = System.Reflection.Missing.Value;
                Excel.Application xlexcel = new Excel.Application();

                xlexcel.DisplayAlerts = false; // Without this you will get two confirm overwrite prompts
                Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add(misValue);
                Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                // Paste clipboard results to worksheet range
                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                // For some reason column A is always blank in the worksheet.
                // Delete blank column A and select cell A1
                Excel.Range delRng = xlWorkSheet.get_Range("A:A").Cells;
                delRng.Delete(Type.Missing);
                xlWorkSheet.get_Range("A1").Select();

                // Save the excel file under the captured location from the SaveFileDialog
                xlWorkBook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookDefault, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlNoChange, misValue, misValue, misValue, misValue, misValue);
                xlexcel.DisplayAlerts = true;
                xlWorkBook.Close(true, misValue, misValue);
                xlexcel.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlexcel);

                // Clear Clipboard and DataGridView selection
                Clipboard.Clear();
                dgvBLDetail.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
            dgvBLDetail.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;

            dgvBLDetail.Columns["clmDayIng"].Visible = false;
            dgvBLDetail.Columns["clmMonthIng"].Visible = false;
            dgvBLDetail.Columns["clmYearIng"].Visible = false;
            dgvBLDetail.Columns["clmHourIng"].Visible = false;
            dgvBLDetail.Columns["clmDateIn"].Visible = true;

            dgvBLDetail.Columns["clmDayEnt"].Visible = false;
            dgvBLDetail.Columns["clmMonthEnt"].Visible = false;
            dgvBLDetail.Columns["clmYearEnt"].Visible = false;
            dgvBLDetail.Columns["clmHourEnt"].Visible = false;
            dgvBLDetail.Columns["clmDeliveredDate"].Visible = true;

        }

        private void copyAlltoClipboard()
        {
            dgvBLDetail.SelectAll();
            DataObject dataObj = dgvBLDetail.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
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
                MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        #endregion

    }
}
