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
    public partial class frmPCPTProductionControlMP : Form
    {
        public frmPCPTProductionControlMP()
        {
            InitializeComponent();
        }
        public frmPCPTProductionControlMP(DateTime desde, DateTime hasta, string identifier)
        {
            InitializeComponent();

            txtDesde.Text = desde.ToString();
            txtHasta.Text = hasta.ToString();

            populateDatagrid(desde, hasta, identifier,0);
        }
        
        public void populateDatagrid(DateTime desde, DateTime hasta, string id,int hora)
        {
            double total = 0;
            double homoDepo = 0;
            double homoSilo = 0;
            double recuDepo = 0;
            double recuSilo = 0;
            double recumDepo = 0;
            double recumSilo = 0;
            double copoDepo = 0;
            double copoSilo = 0;
            double terpoDepo = 0;
            double terpoSilo = 0;
            double matifDepo = 0;
            double matifSilo = 0;
            double tafmerDepo = 0;
            double tafmerSilo = 0;

            this.Text = "Detalle de materia prima";
            dgvControl.Columns[clmTipoMaterial.Index].Visible = true;
            dgvControl.Columns[clmCodMaterial.Index].Visible = true;
            dgvControl.Columns[clmMaterial.Index].Visible = true;
            dgvControl.Columns[clmSubtotal.Index].Visible = true;
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spRawDepotHistoryTotalMPByDateTotal(" + hasta.Day.ToString() + "," + hasta.Month.ToString() + "," + hasta.Year.ToString() + "," + "0)");

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if ((Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000) != 0.00)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmMaterial.Index].Value = DS.Tables[0].Rows[i]["Material"];
                        dgvControl.Rows[fila].Cells[clmCodMaterial.Index].Value = DS.Tables[0].Rows[i]["CodMaterial"];
                        dgvControl.Rows[fila].Cells[clmTipoMaterial.Index].Value = DS.Tables[0].Rows[i]["TipoMaterial"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");

                        if(DS.Tables[0].Rows[i]["Bodega"].ToString()=="Materia Prima Pilar" || DS.Tables[0].Rows[i]["Bodega"].ToString()=="Extrusion Pilar")
                        {
                            if(DS.Tables[0].Rows[i]["TipoMaterial"].ToString()=="HOMOPOLIMERO PP")
                            {
                                homoDepo += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                            }
                            if (DS.Tables[0].Rows[i]["CodMaterial"].ToString() == "RH-AR-RHC")
                            {
                                recuDepo += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                            }
                            if (DS.Tables[0].Rows[i]["CodMaterial"].ToString() == "RHD-AR-RHD")
                            {
                                recumDepo += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                            }
                            if (DS.Tables[0].Rows[i]["TipoMaterial"].ToString() == "COPOLIMERO")
                            {
                                copoDepo += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                            }
                            if (DS.Tables[0].Rows[i]["TipoMaterial"].ToString() == "TERPOLIMERO")
                            {
                                terpoDepo += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                            }
                            if (DS.Tables[0].Rows[i]["TipoMaterial"].ToString() == "MATIF")
                            {
                                matifDepo += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                            }
                            if (DS.Tables[0].Rows[i]["TipoMaterial"].ToString() == "TAFMER")
                            {
                                tafmerDepo += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                            }
                        }
                        else if (DS.Tables[0].Rows[i]["Bodega"].ToString() == "Silo Pilar 3" || DS.Tables[0].Rows[i]["Bodega"].ToString() == "Silo Pilar 4")
                        {
                            if (DS.Tables[0].Rows[i]["TipoMaterial"].ToString() == "HOMOPOLIMERO PP")
                            {
                                homoSilo += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                            }
                            if (DS.Tables[0].Rows[i]["CodMaterial"].ToString() == "RH-AR-RHC")
                            {
                                recuSilo += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                            }
                            if (DS.Tables[0].Rows[i]["CodMaterial"].ToString() == "RHD-AR-RHD")
                            {
                                recumSilo += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                            }
                            if (DS.Tables[0].Rows[i]["TipoMaterial"].ToString() == "COPOLIMERO")
                            {
                                copoSilo += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                            }
                            if (DS.Tables[0].Rows[i]["TipoMaterial"].ToString() == "TERPOLIMERO")
                            {
                                terpoSilo += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                            }
                            if (DS.Tables[0].Rows[i]["TipoMaterial"].ToString() == "MATIF")
                            {
                                matifSilo += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                            }
                            if (DS.Tables[0].Rows[i]["TipoMaterial"].ToString() == "TAFMER")
                            {
                                tafmerSilo += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                            }
                        }
                    }
                    total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                }
            }
            txtTotal.Text = total.ToString("0.00");

            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].Cells[tipo.Index].Value = "Homopolimero";
            dataGridView1.Rows[0].Cells[depositos.Index].Value = (homoDepo/1000).ToString("0");
            dataGridView1.Rows[0].Cells[silos.Index].Value = (homoSilo/1000).ToString("0");
            dataGridView1.Rows[0].Cells[totalmp.Index].Value = ((homoSilo / 1000)+(homoDepo / 1000)).ToString("0");
            dataGridView1.Rows.Add();
            dataGridView1.Rows[1].Cells[tipo.Index].Value = "Copolimero";
            dataGridView1.Rows[1].Cells[depositos.Index].Value = (copoDepo / 1000).ToString("0");
            dataGridView1.Rows[1].Cells[silos.Index].Value = (copoSilo / 1000).ToString("0");
            dataGridView1.Rows[1].Cells[totalmp.Index].Value = ((copoSilo / 1000) + (copoDepo / 1000)).ToString("0");
            dataGridView1.Rows.Add();
            dataGridView1.Rows[2].Cells[tipo.Index].Value = "Terpolimero";
            dataGridView1.Rows[2].Cells[depositos.Index].Value = (terpoDepo / 1000).ToString("0");
            dataGridView1.Rows[2].Cells[silos.Index].Value = (terpoSilo / 1000).ToString("0");
            dataGridView1.Rows[2].Cells[totalmp.Index].Value = ((terpoSilo / 1000) + (terpoDepo / 1000)).ToString("0");
            dataGridView1.Rows.Add();
            dataGridView1.Rows[3].Cells[tipo.Index].Value = "Recuperado cristal";
            dataGridView1.Rows[3].Cells[depositos.Index].Value = (recuDepo / 1000).ToString("0");
            dataGridView1.Rows[3].Cells[silos.Index].Value = (recuSilo / 1000).ToString("0");
            dataGridView1.Rows[3].Cells[totalmp.Index].Value = ((recuSilo / 1000) + (recuDepo / 1000)).ToString("0");
            dataGridView1.Rows.Add();
            dataGridView1.Rows[4].Cells[tipo.Index].Value = "Recuperado mate";
            dataGridView1.Rows[4].Cells[depositos.Index].Value = (recumDepo / 1000).ToString("0");
            dataGridView1.Rows[4].Cells[silos.Index].Value = (recumSilo / 1000).ToString("0");
            dataGridView1.Rows[4].Cells[totalmp.Index].Value = ((recumSilo / 1000) + (recumDepo / 1000)).ToString("0");
            dataGridView1.Rows.Add();
            dataGridView1.Rows[5].Cells[tipo.Index].Value = "Matif";
            dataGridView1.Rows[5].Cells[depositos.Index].Value = (matifDepo / 1000).ToString("0");
            dataGridView1.Rows[5].Cells[silos.Index].Value = (matifSilo / 1000).ToString("0");
            dataGridView1.Rows[5].Cells[totalmp.Index].Value = ((matifSilo / 1000) + (matifDepo / 1000)).ToString("0");
            dataGridView1.Rows.Add();
            dataGridView1.Rows[6].Cells[tipo.Index].Value = "Tafmer";
            dataGridView1.Rows[6].Cells[depositos.Index].Value = (tafmerDepo / 1000).ToString("0");
            dataGridView1.Rows[6].Cells[silos.Index].Value = (tafmerSilo / 1000).ToString("0");
            dataGridView1.Rows[6].Cells[totalmp.Index].Value = ((tafmerSilo / 1000) + (tafmerDepo / 1000)).ToString("0");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvControl.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
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
                dgvControl.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
        }
        private void copyAlltoClipboard()
        {
            dgvControl.SelectAll();
            DataObject dataObj = dgvControl.GetClipboardContent();
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

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel 97-2003 WorkBook|*.xls|Excel WorkBook|*.xlsx|All Excel Files|*.xls;*.xlsx";
            string filename = System.IO.Path.GetFileName(sfd.FileName);

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Copy DataGridView results to clipboard
                copyAlltoClipboard2();

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
                dataGridView1.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
        }
        private void copyAlltoClipboard2()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
    }
}
