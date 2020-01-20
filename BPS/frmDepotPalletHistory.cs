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

namespace BPS
{
    public partial class frmPalletDepotHistory : Form
    {
        public frmPalletDepotHistory()
        {
            InitializeComponent();
            List<clsPlant> list = clsPlant.getList();

            for (int i = 0; i < list.Count; i++)
            {
                cmbPlanta.Items.Add(list[i].name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            populateDatagrid();
        }
        public void populateDatagrid()
        {
            DataSet DS = new DataSet();

            if (cmbPlanta.SelectedIndex == -1)
            {
                DS = DeterminarTurno("SELECT * from bps_prod_depothistory WHERE dh_day=" + dtpFecha.Value.Day.ToString() + "AND dh_month=" + dtpFecha.Value.Month.ToString() + "AND dh_year=" + dtpFecha.Value.Year.ToString());
            }
            else if (cmbPlanta.Items[cmbPlanta.SelectedIndex].ToString() == "Pilar")
            {
                DS = DeterminarTurno("SELECT * from bps_prod_depothistory WHERE dh_day=" + dtpFecha.Value.Day.ToString() + "AND dh_month=" + dtpFecha.Value.Month.ToString() + "AND dh_year=" + dtpFecha.Value.Year.ToString() + "AND dh_plant=4");
            }
            else if (cmbPlanta.Items[cmbPlanta.SelectedIndex].ToString() == "Campana")
            {
                DS = DeterminarTurno("SELECT * from bps_prod_depothistory WHERE dh_day=" + dtpFecha.Value.Day.ToString() + "AND dh_month=" + dtpFecha.Value.Month.ToString() + "AND dh_year=" + dtpFecha.Value.Year.ToString() + "AND dh_plant=3");
            }

            dataGridView1.Rows.Clear();
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[Day.Index].Value = DS.Tables[0].Rows[i]["dh_day"].ToString();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[Month.Index].Value = DS.Tables[0].Rows[i]["dh_month"].ToString();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[Year.Index].Value = DS.Tables[0].Rows[i]["dh_year"].ToString();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[Film.Index].Value = DS.Tables[0].Rows[i]["dh_film"].ToString();
                    if (Convert.ToDouble(DS.Tables[0].Rows[i]["dh_netweight"]) >= 10000)
                    {
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[ActualWeight.Index].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["dh_netweight"]).ToString("0000.00");
                    }
                    else
                    {
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[ActualWeight.Index].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["dh_netweight"]).ToString("000.00");
                    }
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[Quality.Index].Value = DS.Tables[0].Rows[i]["dh_quality"].ToString();
                    if (Convert.ToInt32(DS.Tables[0].Rows[i]["dh_plant"]) == 4)
                    {
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[plant.Index].Value = "Pilar";
                    }

                    if (Convert.ToInt32(DS.Tables[0].Rows[i]["dh_plant"]) == 3)
                    {
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[plant.Index].Value = "Campana";
                    }
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[CoilCellar.Index].Value = DS.Tables[0].Rows[i]["dh_coilcellar"].ToString();
                }
            }
            else
            {
                MessageBox.Show("No se encontraron datos.", "Historial de racks", MessageBoxButtons.OK);
            }
        }

        public DataSet DeterminarTurno(string query)
        {
            DataSet DS = new DataSet();
            switch (cmbTurno.SelectedIndex)
            {
                case 0:
                    query += " AND dh_hour=7";
                    DS = clsConnection.getDataSetResult(query);
                    break;
                case 1:
                    query += " AND dh_hour=19";
                    DS = clsConnection.getDataSetResult(query);
                    break;
                case 2:
                    query += " AND dh_hour=0";
                    DS = clsConnection.getDataSetResult(query);
                    break;
                default:
                    DS = clsConnection.getDataSetResult(query);
                    break;
            }
            return DS;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            string ext = string.Empty;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
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
                dataGridView1.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
        }
        private void copyAlltoClipboard()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
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
    }
}
