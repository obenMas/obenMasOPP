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
    public partial class frmRackHistory : Form
    {
        public frmRackHistory()
        {
            InitializeComponent();

            List<clsPlant> list = clsPlant.getList();

            for(int i=0;i<list.Count;i++)
            {
                comboBox1.Items.Add(list[i].name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            populateDatagrid();
        }

        public void populateDatagrid()
        {
            DataSet DS = new DataSet();

            if(comboBox1.SelectedIndex==-1)
            {
                DS = DeterminarTurno("SELECT * from bps_prod_rackHistory WHERE rh_day=" + dateTimePicker1.Value.Day.ToString() + "AND rh_month=" + dateTimePicker1.Value.Month.ToString() + "AND rh_year=" + dateTimePicker1.Value.Year.ToString());
            }
            else if(comboBox1.Items[comboBox1.SelectedIndex].ToString()=="Pilar")
            {
                DS = DeterminarTurno("SELECT * from bps_prod_rackHistory WHERE rh_day=" + dateTimePicker1.Value.Day.ToString() + "AND rh_month=" + dateTimePicker1.Value.Month.ToString() + "AND rh_year=" + dateTimePicker1.Value.Year.ToString() + "AND rh_machine=3024");
            }
            else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "Campana")
            {
                DS = DeterminarTurno("SELECT * from bps_prod_rackHistory WHERE rh_day=" + dateTimePicker1.Value.Day.ToString() + "AND rh_month=" + dateTimePicker1.Value.Month.ToString() + "AND rh_year=" + dateTimePicker1.Value.Year.ToString() + "AND rh_machine=11");
            }

            dataGridView1.Rows.Clear();
            if(DS.Tables.Count>0 && DS.Tables[0].Rows.Count>0)
            {
                for(int i=0;i<DS.Tables[0].Rows.Count;i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[Day.Index].Value = DS.Tables[0].Rows[i]["rh_day"].ToString();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[Month.Index].Value = DS.Tables[0].Rows[i]["rh_month"].ToString();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[Year.Index].Value = DS.Tables[0].Rows[i]["rh_year"].ToString();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[MainCoilCode.Index].Value = DS.Tables[0].Rows[i]["rh_code"].ToString();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[Film.Index].Value = DS.Tables[0].Rows[i]["rh_film"].ToString();
                    if (Convert.ToDouble(DS.Tables[0].Rows[i]["rh_actualweight"])>=10000)
                    {
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[ActualWeight.Index].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["rh_actualweight"]).ToString("0000.00");
                    }
                    else
                    {
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[ActualWeight.Index].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["rh_actualweight"]).ToString("000.00");
                    }
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[ActualLength.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["rh_actuallength"]).ToString();
                    if (Convert.ToInt32(DS.Tables[0].Rows[i]["rh_machine"])==3024)
                    {
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[plant.Index].Value = "Pilar";
                    }

                    if (Convert.ToInt32(DS.Tables[0].Rows[i]["rh_machine"]) == 11)
                    {
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[plant.Index].Value = "Campana";
                    }
                    
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
            switch(cmbTurno.SelectedIndex)
            {
                case 0:
                    query += " AND rh_hour=7";
                    DS = clsConnection.getDataSetResult(query);
                    break;
                case 1:
                    query += " AND rh_hour=19";
                    DS = clsConnection.getDataSetResult(query);
                    break;
                case 2:
                    query += " AND rh_hour=0";
                    DS = clsConnection.getDataSetResult(query);
                    break;
                default:
                    DS = clsConnection.getDataSetResult(query);
                    break;
            }
            return DS;
        }


        private void btnExport_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
