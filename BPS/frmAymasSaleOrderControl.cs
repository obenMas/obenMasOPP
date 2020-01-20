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
    public partial class frmAymasSaleOrderControl : Form
    {
        DataSet DS = new DataSet();

        public frmAymasSaleOrderControl()
        {
            InitializeComponent();
            cmbShow.SelectedIndex = 0;
            getDataSet();
            populateDataGrid();
            
        }

        public void getDataSet()
        {
            DS = clsConnection.getDataSetResult("SELECT * FROM vwAymasSaleOrderControl");
        }

        public void getDataSet(string query)
        {
            DS = clsConnection.getDataSetResult(query);
        }

        public void populateDataGrid()
        {
            //List<string> order = new List<string>();
            List<string> films = new List<string>();
            List<double> widths = new List<double>();
            List<string> diameters = new List<string>();
            List<int> cores = new List<int>();
            List<int> codsec = new List<int>();

            dgvAymasSaleOrderControl.Rows.Clear();

            cmbOrder.Items.Clear();
            cmbFilm.Items.Clear();
            cmbWidth.Items.Clear();
            cmbDiameter.Items.Clear();
            cmbCore.Items.Clear();

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                dgvAymasSaleOrderControl.Rows.Add();
                dgvAymasSaleOrderControl.Rows[dgvAymasSaleOrderControl.Rows.Count - 1].Cells["clmcodsec"].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["codsec"]);
                //dgvAymasSaleOrderControl.Rows[dgvAymasSaleOrderControl.Rows.Count - 1].Cells["clmOrder"].Value = DS.Tables[0].Rows[i]["Pedido"].ToString();
                dgvAymasSaleOrderControl.Rows[dgvAymasSaleOrderControl.Rows.Count - 1].Cells["clmOrder"].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["codsec"]);
                dgvAymasSaleOrderControl.Rows[dgvAymasSaleOrderControl.Rows.Count - 1].Cells[clmCliente.Index].Value = DS.Tables[0].Rows[i]["Cliente"].ToString();
                dgvAymasSaleOrderControl.Rows[dgvAymasSaleOrderControl.Rows.Count - 1].Cells["clmFilm"].Value = DS.Tables[0].Rows[i]["Película"].ToString();
                dgvAymasSaleOrderControl.Rows[dgvAymasSaleOrderControl.Rows.Count - 1].Cells["clmWidth"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Ancho"]),2);
                dgvAymasSaleOrderControl.Rows[dgvAymasSaleOrderControl.Rows.Count - 1].Cells["clmDiameter"].Value = DS.Tables[0].Rows[i]["Diametro"].ToString();
                dgvAymasSaleOrderControl.Rows[dgvAymasSaleOrderControl.Rows.Count - 1].Cells["clmCore"].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["Core"]);
                dgvAymasSaleOrderControl.Rows[dgvAymasSaleOrderControl.Rows.Count - 1].Cells["clmSolicitedQuantity"].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadSolicitada"]);
                dgvAymasSaleOrderControl.Rows[dgvAymasSaleOrderControl.Rows.Count - 1].Cells["clmOvQuantity"].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadOV"]);
                dgvAymasSaleOrderControl.Rows[dgvAymasSaleOrderControl.Rows.Count - 1].Cells["clmSecond"].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["Segundas"]);
                dgvAymasSaleOrderControl.Rows[dgvAymasSaleOrderControl.Rows.Count - 1].Cells["clmPositiveReassignation"].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["ReasignacionesPositivas"]);
                dgvAymasSaleOrderControl.Rows[dgvAymasSaleOrderControl.Rows.Count - 1].Cells["clmReassignationNegative"].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["ReasignacionesNegativas"]);
                dgvAymasSaleOrderControl.Rows[dgvAymasSaleOrderControl.Rows.Count - 1].Cells["clmPendingOV"].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["PendienteOV"]);

               // if (!order.Contains(DS.Tables[0].Rows[i]["Pedido"].ToString()))
                 //   order.Add(DS.Tables[0].Rows[i]["Pedido"].ToString());

                if(!codsec.Contains(Convert.ToInt32(DS.Tables[0].Rows[i]["codsec"].ToString())))
                    codsec.Add(Convert.ToInt32(DS.Tables[0].Rows[i]["codsec"].ToString()));


                if (!films.Contains(DS.Tables[0].Rows[i]["Película"].ToString()))
                    films.Add(DS.Tables[0].Rows[i]["Película"].ToString());

                if (!widths.Contains(Convert.ToDouble(DS.Tables[0].Rows[i]["Ancho"])))
                    widths.Add(Convert.ToDouble(DS.Tables[0].Rows[i]["Ancho"].ToString()));

                if (!diameters.Contains(DS.Tables[0].Rows[i]["Diametro"].ToString()))
                    diameters.Add(DS.Tables[0].Rows[i]["Diametro"].ToString());

                if (!cores.Contains(Convert.ToInt32(DS.Tables[0].Rows[i]["Core"])))
                    cores.Add(Convert.ToInt32(DS.Tables[0].Rows[i]["Core"].ToString()));
                }

                //order.Sort();
                codsec.Sort();
                films.Sort(); 
                widths.Sort();
                diameters.Sort();
                cores.Sort();

                /*for (int i = 0; i < order.Count; i++)
                {
                    cmbOrder.Items.Add(order[i]);
                }*/

                for (int i = 0; i < codsec.Count; i++)
                {
                    cmbOrder.Items.Add(codsec[i]);
                }


                    for (int i = 0; i < films.Count; i++)
                    {
                        cmbFilm.Items.Add(films[i]);
                    }

                for(int i = 0; i< widths.Count; i++)
                {
                    cmbWidth.Items.Add(widths[i]);
                }

                for (int i = 0; i < diameters.Count; i++)
                {
                    cmbDiameter.Items.Add(diameters[i]);
                }

                for (int i = 0; i < cores.Count; i++)
                {
                    cmbCore.Items.Add(cores[i]);
                }

                if (cmbOrder.Text != string.Empty)
                    cmbOrder.SelectedIndex = 0;

                if (cmbFilm.Text != string.Empty)
                    cmbFilm.SelectedIndex = 0;

                if (cmbWidth.Text != string.Empty)
                    cmbWidth.SelectedIndex = 0;

                if (cmbDiameter.Text != string.Empty)
                    cmbDiameter.SelectedIndex = 0;

                if (cmbCore.Text != string.Empty)
                    cmbCore.SelectedIndex = 0;
            }

          }

        private void button3_Click(object sender, EventArgs e)
        {
            getDataSet();
            populateDataGrid();
            cmbOrder.ResetText();
            cmbFilm.ResetText();
            cmbWidth.ResetText();
            cmbDiameter.ResetText();
            cmbCore.ResetText();
            cmbShow.ResetText();

            cmbOrder.SelectedIndex = -1;
            cmbFilm.SelectedIndex = -1;
            cmbWidth.SelectedIndex = -1;
            cmbDiameter.SelectedIndex = -1;
            cmbCore.SelectedIndex = -1;
            cmbShow.SelectedIndex = -1;
            
        }


        private void btnFilter_Click(object sender, EventArgs e)
        {
            bool first = false;
            string querystring = "SELECT * FROM vwAymasSaleOrderControl";

           /* if (cmbOrder.SelectedIndex != -1)
            {
                first = true;
                querystring += " WHERE Pedido ='" + cmbOrder.SelectedItem.ToString() + "' ";
            }*/

            if(cmbOrder.SelectedIndex != -1)
            {
                first = true;
                querystring += " WHERE codsec = " + cmbOrder.SelectedItem.ToString();
            }

            if (cmbFilm.SelectedIndex != -1)
            {
                if (!first)
                {
                    first = true;
                    querystring += " WHERE ";
                }
                else
                {
                    querystring += "AND ";
                }
                querystring += "Película ='" + cmbFilm.SelectedItem.ToString() + "' ";
            }

            if (cmbWidth.SelectedIndex != -1)
            {
                if (!first)
                {
                    first = true;
                    querystring += " WHERE ";
                }
                else
                {
                    querystring += "AND ";
                }
                querystring += "Ancho ='" + cmbWidth.SelectedItem.ToString() + "' ";
            }

            if (cmbDiameter.SelectedIndex != -1)
            {
                if (!first)
                {
                    first = true;
                    querystring += " WHERE ";
                }
                else
                {
                    querystring += "AND ";
                }
                querystring += "Diametro ='" + cmbDiameter.SelectedItem.ToString() + "' ";
            }

            if (cmbCore.SelectedIndex != -1)
            {
                if (!first)
                {
                    first = true;
                    querystring += " WHERE ";
                }
                else
                {
                    querystring += "AND ";
                }
                querystring += "Core ='" + cmbCore.SelectedItem.ToString() + "' ";
            }

            if(cmbShow.SelectedIndex != -1)
            {
               
                if(cmbShow.SelectedIndex ==1)
                {
                    if (!first)
                    {
                        first = true;
                        querystring += " WHERE ";
                    }
                    else
                    {
                        querystring += "AND ";
                    }
                    querystring += "PendienteOV > 0 ";
                }
                

            }

            getDataSet(querystring);
            populateDataGrid();
        }


        private void btnExport_Click(object sender, EventArgs e)
        {

            string ext = string.Empty;
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
                dgvAymasSaleOrderControl.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
            
            
            
            /*try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
                worksheet.Name = "Ordenes de Venta Aymas";

                for (int i = 1; i < dgvAymasSaleOrderControl.Columns.Count + 1; i++)
                    worksheet.Cells[1, i] = dgvAymasSaleOrderControl.Columns[i - 1].HeaderText;

                for (int i = 0; i < dgvAymasSaleOrderControl.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvAymasSaleOrderControl.Columns.Count; j++)
                    {
                        if (dgvAymasSaleOrderControl.Rows[i].Cells[j].Value != null)
                            worksheet.Cells[i + 2, j + 1] = dgvAymasSaleOrderControl.Rows[i].Cells[j].Value.ToString();
                    }
                }
                worksheet.Cells[1, 14] = "OV";
                worksheet.Cells[1, 15] = "Cantidad";
                MessageBox.Show("Exportación Generada correctamente", "Ordenes de Venta Aymas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ordenes de Venta Aymas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }


        private void copyAlltoClipboard()
        {
            dgvAymasSaleOrderControl.SelectAll();
            DataObject dataObj = dgvAymasSaleOrderControl.GetClipboardContent();
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
            DataTable table = clsConnectionAccess.getAymasOV();
            clsAymasSalesOrder aysord = new clsAymasSalesOrder();
            for(int i=0;i<table.Rows.Count;i++)
            {
                aysord.fkSalesOrderDetail = Convert.ToInt32(table.Rows[i][0]);
                aysord.number = Convert.ToInt32(table.Rows[i][13]);
                aysord.quantity = Convert.ToDouble(table.Rows[i][14]);
                aysord.fkUser = clsGlobal.LoggedUser.codsec;
                aysord.date = DateTime.Now;
                aysord.status = "Abierta";
                if (!aysord.save())
                {
                    MessageBox.Show("Ocurrio un error y no se pudo guardar la OV N°" + aysord.number + " del cliente " + table.Rows[i][2].ToString(),"Importación masiva de OVs",MessageBoxButtons.OK);
                }
            }

            MessageBox.Show("Se procesaron todas las OV", "Importación masiva de OVs", MessageBoxButtons.OK);
        }

        private void dgvAymasSaleOrderControl_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmOrder.Index)
            {
                frmAySordMaintenance generateNewReport = new frmAySordMaintenance(Convert.ToInt32(dgvAymasSaleOrderControl.Rows[e.RowIndex].Cells[clmcodsec.Index].Value));
                generateNewReport.StartPosition = FormStartPosition.CenterScreen;
                generateNewReport.MaximizeBox = false;
                generateNewReport.Show();
            }
        }


        }
    }