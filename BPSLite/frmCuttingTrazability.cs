using System;
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

namespace BPS.Lite
{
    public partial class frmCuttingTrazability : Form
    {
        DataSet DS = new DataSet();
        DataSet DS2 = new DataSet();

        public frmCuttingTrazability()
        {
            InitializeComponent();
        }

        public void getDataSetMainCoil(int MainCoilCodsec)
        {
            DS = clsConnection.getDataSetResult("CALL spchildcoilsbymaincoil(" + MainCoilCodsec.ToString() + ")");
        }

        public void getDataSetCoil(int CoilCodsec)
        {
            DS2 = clsConnection.getDataSetResult("CALL spchildcoilsbycoil(" + CoilCodsec.ToString() + ")");
        }

        public void populateDgvPrimaryCut()
        {
            clsMainCoil objMainCoil = new clsMainCoil();

            objMainCoil.load(txtMainCoil.Text);

            getDataSetMainCoil(objMainCoil.codsec);

            if (DS.Tables[0].Rows.Count > 0)
            {
                dgvPrimaryCut.Rows.Clear();
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvPrimaryCut.Rows.Add();
                    dgvPrimaryCut.Rows[dgvPrimaryCut.Rows.Count - 1].Cells[clmCutter.Index].Value = DS.Tables[0].Rows[i]["Maquina"].ToString();
                    dgvPrimaryCut.Rows[dgvPrimaryCut.Rows.Count - 1].Cells[clmCuttingorder.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["OrdenCorte"]);
                    dgvPrimaryCut.Rows[dgvPrimaryCut.Rows.Count - 1].Cells[clmCuttingstops.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["Parada"]);
                    dgvPrimaryCut.Rows[dgvPrimaryCut.Rows.Count - 1].Cells[clmCoilCode.Index].Value = DS.Tables[0].Rows[i]["CodigoBobina"].ToString();
                    dgvPrimaryCut.Rows[dgvPrimaryCut.Rows.Count - 1].Cells[clmProduct.Index].Value =DS.Tables[0].Rows[i]["Producto"].ToString();
                    dgvPrimaryCut.Rows[dgvPrimaryCut.Rows.Count - 1].Cells[clmCustommer.Index].Value = DS.Tables[0].Rows[i]["Cliente"].ToString();
                    dgvPrimaryCut.Rows[dgvPrimaryCut.Rows.Count - 1].Cells[clmOrder.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["Pedido"]);
                    dgvPrimaryCut.Rows[dgvPrimaryCut.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]),2);
                    dgvPrimaryCut.Rows[dgvPrimaryCut.Rows.Count - 1].Cells[clmStatus.Index].Value = DS.Tables[0].Rows[i]["Estado"].ToString();
                    dgvPrimaryCut.Rows[dgvPrimaryCut.Rows.Count - 1].Cells[clmMainCoil.Index].Value = DS.Tables[0].Rows[i]["BobinaMadre"].ToString();
                    dgvPrimaryCut.Rows[dgvPrimaryCut.Rows.Count - 1].Cells[clmCuttingDate.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaCorte"]).ToString("dd/MM/yyyy");
                }
            }
        }

        public void populateDgvSecundaryCut()
        {
            clsCoil objCoil = new clsCoil();

            objCoil = clsCoil.getDetailByCode(txtCoil.Text);

            getDataSetCoil(objCoil.codsec);

            if (DS2.Tables[0].Rows.Count > 0)
            {
                dgvSecundaryCut.Rows.Clear();
                for (int i = 0; i < DS2.Tables[0].Rows.Count; i++)
                {
                    dgvSecundaryCut.Rows.Add();
                    dgvSecundaryCut.Rows[dgvSecundaryCut.Rows.Count - 1].Cells[clmCutter.Index].Value = DS2.Tables[0].Rows[i]["Maquina"].ToString();
                    dgvSecundaryCut.Rows[dgvSecundaryCut.Rows.Count - 1].Cells[clmCuttingorder.Index].Value = Convert.ToInt32(DS2.Tables[0].Rows[i]["OrdenCorte"]);
                    dgvSecundaryCut.Rows[dgvSecundaryCut.Rows.Count - 1].Cells[clmCuttingstops.Index].Value = Convert.ToInt32(DS2.Tables[0].Rows[i]["Parada"]);
                    dgvSecundaryCut.Rows[dgvSecundaryCut.Rows.Count - 1].Cells[clmCoilCode.Index].Value = DS2.Tables[0].Rows[i]["CodigoBobina"].ToString();
                    dgvSecundaryCut.Rows[dgvSecundaryCut.Rows.Count - 1].Cells[clmProduct.Index].Value = DS2.Tables[0].Rows[i]["Producto"].ToString();
                    dgvSecundaryCut.Rows[dgvSecundaryCut.Rows.Count - 1].Cells[clmCustommer.Index].Value = DS2.Tables[0].Rows[i]["Cliente"].ToString();
                    dgvSecundaryCut.Rows[dgvSecundaryCut.Rows.Count - 1].Cells[clmOrder.Index].Value = Convert.ToInt32(DS2.Tables[0].Rows[i]["Pedido"]);
                    dgvSecundaryCut.Rows[dgvSecundaryCut.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(Convert.ToDouble(DS2.Tables[0].Rows[i]["Peso"]), 2);
                    dgvSecundaryCut.Rows[dgvSecundaryCut.Rows.Count - 1].Cells[clmStatus.Index].Value = DS2.Tables[0].Rows[i]["Estado"].ToString();
                    dgvSecundaryCut.Rows[dgvSecundaryCut.Rows.Count - 1].Cells[clmMainCoil.Index].Value = DS2.Tables[0].Rows[i]["BobinaMadre"].ToString();
                    dgvSecundaryCut.Rows[dgvSecundaryCut.Rows.Count - 1].Cells[clmCuttingDate.Index].Value = Convert.ToDateTime(DS2.Tables[0].Rows[i]["FechaCorte"]).ToString("dd/MM/yyyy");
                }
            }
        }

        private void txtMainCoil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(txtMainCoil.Text != string.Empty)
                {
                    populateDgvPrimaryCut();
                }
                else
                {
                    MessageBox.Show("El campo Código de Bobina Madre no puede estar vacio.", "Trazabilidad de corte", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
        }

        private void txtCoil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCoil.Text != string.Empty)
                {
                    populateDgvSecundaryCut();
                }
                else
                {
                    MessageBox.Show("El campo Código de Bobina no puede estar vacio.", "Trazabilidad de corte", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
        }

        private void btnExportPrimary_Click(object sender, EventArgs e)
        {
            string ext = string.Empty;

            dgvPrimaryCut.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel 97-2003 WorkBook|*.xls|Excel WorkBook|*.xlsx|All Excel Files|*.xls;*.xlsx";
            string filename = System.IO.Path.GetFileName(sfd.FileName);

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Copy DataGridView results to clipboard
                copyAlltoClipboardPrimary();

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
                dgvPrimaryCut.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
 
            dgvPrimaryCut.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
        }

        private void copyAlltoClipboardPrimary()
        {
            dgvPrimaryCut.SelectAll();
            DataObject dataObj = dgvPrimaryCut.GetClipboardContent();
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

        private void btnExportSecundary_Click(object sender, EventArgs e)
        {
            string ext = string.Empty;

           dgvSecundaryCut.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel 97-2003 WorkBook|*.xls|Excel WorkBook|*.xlsx|All Excel Files|*.xls;*.xlsx";
            string filename = System.IO.Path.GetFileName(sfd.FileName);

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Copy DataGridView results to clipboard
                copyAlltoClipboardSecondary();

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
                dgvSecundaryCut.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }

            dgvSecundaryCut.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
        }

        private void copyAlltoClipboardSecondary()
        {
            dgvSecundaryCut.SelectAll();
            DataObject dataObj = dgvSecundaryCut.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void btnClearPrimary_Click(object sender, EventArgs e)
        {
            dgvPrimaryCut.Rows.Clear();

            txtMainCoil.Text = string.Empty;
        }

        private void btnClearSecondary_Click(object sender, EventArgs e)
        {
            dgvSecundaryCut.Rows.Clear();

            txtCoil.Text = string.Empty;
        }

    }
}
