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
    public partial class frmPreseaRemit : Form
    {   
        List<clsPreseaShippings> list = new List<clsPreseaShippings>();
        DataSet DS = new DataSet();

        public frmPreseaRemit()
        {
            InitializeComponent();
            getList();
            populateDataGrid();

        }

        public void getList()
        {
            list = clsPreseaShippings.getList(Convert.ToInt32(txtQuantity.Text));
        }

        public void getDataSet(string query)
        {
            DS = clsConnection.getDataSetResult(query);
        }

        public void populateDataGrid()
        {
            List<string> ps_customers = new List<string>();
            List<string> ps_codes = new List<string>();
            List<string> ps_users = new List<string>();
            List<string> ps_sord= new List<string>();
            List<string> ps_notes = new List<string>();
            
            dgvPreseaRemit.Rows.Clear();
            cmbCustomers.Items.Clear();
            cmbCodes.Items.Clear();
            cmbUsers.Items.Clear();
            cmbSalesOrder.Items.Clear();
            cmbNotes.Items.Clear();
            
            for (int i = 0; i < list.Count; i++)
            {
                dgvPreseaRemit.Rows.Add();
                dgvPreseaRemit.Rows[dgvPreseaRemit.Rows.Count - 1].Cells[clmCodsec.Index].Value = list[i].codsec;
                dgvPreseaRemit.Rows[dgvPreseaRemit.Rows.Count - 1].Cells[clmNumber.Index].Value = list[i].number;
                dgvPreseaRemit.Rows[dgvPreseaRemit.Rows.Count - 1].Cells[clmCustomerName.Index].Value = list[i].customerName; 
                dgvPreseaRemit.Rows[dgvPreseaRemit.Rows.Count - 1].Cells[clmDate.Index].Value = list[i].date.ToString("dd/MM/yyyy");
                dgvPreseaRemit.Rows[dgvPreseaRemit.Rows.Count - 1].Cells[clmCode.Index].Value = list[i].code;
                dgvPreseaRemit.Rows[dgvPreseaRemit.Rows.Count - 1].Cells[clmPrice.Index].Value = list[i].price;
                dgvPreseaRemit.Rows[dgvPreseaRemit.Rows.Count - 1].Cells[clmQuantity.Index].Value = list[i].quantity;
                dgvPreseaRemit.Rows[dgvPreseaRemit.Rows.Count - 1].Cells[clmIva.Index].Value = list[i].iva;
                dgvPreseaRemit.Rows[dgvPreseaRemit.Rows.Count - 1].Cells[clmDetail.Index].Value = list[i].detail;
                dgvPreseaRemit.Rows[dgvPreseaRemit.Rows.Count - 1].Cells[clmUser.Index].Value = list[i].user;
                dgvPreseaRemit.Rows[dgvPreseaRemit.Rows.Count - 1].Cells[clmOrigin.Index].Value = list[i].origin;
                dgvPreseaRemit.Rows[dgvPreseaRemit.Rows.Count - 1].Cells[clmOrigin2.Index].Value = list[i].origin2;
                dgvPreseaRemit.Rows[dgvPreseaRemit.Rows.Count - 1].Cells[clmSaleOrder.Index].Value = list[i].saleOrder;
                dgvPreseaRemit.Rows[dgvPreseaRemit.Rows.Count - 1].Cells[clmObservation.Index].Value = list[i].observation;

                ps_customers.Sort();
                ps_codes.Sort();
                ps_users.Sort();
                ps_sord.Sort();
                ps_notes.Sort();

                if (!ps_customers.Contains(list[i].customerName.ToString()))
                    ps_customers.Add(list[i].customerName.ToString());

                if (!ps_codes.Contains(list[i].code.ToString()))
                    ps_codes.Add(list[i].code.ToString());

                if (!ps_users.Contains(list[i].user.ToString()))
                    ps_users.Add(list[i].user.ToString());

                if (!ps_sord.Contains(list[i].saleOrder.ToString()))
                    ps_sord.Add(list[i].saleOrder.ToString());

                if (!ps_notes.Contains(list[i].observation.ToString()))
                    ps_notes.Add(list[i].observation.ToString());

            }

            for (int i = 0; i < ps_customers.Count; i++)
            {
                cmbCustomers.Items.Add(ps_customers[i]);
            }

            for (int i = 0; i < ps_codes.Count; i++)
            {
                cmbCodes.Items.Add(ps_codes[i]);
            }

            for (int i = 0; i < ps_users.Count; i++)
            {
                cmbUsers.Items.Add(ps_users[i]);
            }

            for (int i = 0; i < ps_sord.Count; i++)
            {
                cmbSalesOrder.Items.Add(ps_sord[i]);
            }

            for (int i = 0; i < ps_notes.Count; i++)
            {
                cmbNotes.Items.Add(ps_notes[i]);
            }

            if (cmbCustomers.Text != string.Empty)
                cmbCustomers.SelectedIndex = 0;

            if (cmbCodes.Text != string.Empty)
                cmbCodes.SelectedIndex = 0;

            if (cmbUsers.Text != string.Empty)
                cmbUsers.SelectedIndex = 0;

            if (cmbSalesOrder.Text != string.Empty)
                cmbSalesOrder.SelectedIndex = 0;

            if (cmbNotes.Text != string.Empty)
                cmbNotes.SelectedIndex = 0;

            txtUpdatedDate.Text = mostrarFecha();
            label9.Text = dgvPreseaRemit.Rows.Count + " /";
        }

    

     public void save()
     {
         clsPreseaShippings obj = new clsPreseaShippings();
         for (int i = 0; i < list.Count; i++)
         {
             obj = list[i];
             obj.save();  
         }
     }

     public void setActualizationDate(string date)
     {
         string querystring = "UPDATE bps_admin_presea SET pre_date2 = '" + date + "' WHERE pre_codsec = 1;";
         bool prueba = clsConnection.executeQuery(querystring);
     }

     private void btnAddFilter_Click(object sender, EventArgs e)
     {
         bool first = false;
         string querystring = "SELECT TOP ("+Convert.ToInt32(txtQuantity.Text)+") * FROM bps_prod_preseaShippings";

         if (cmbCustomers.SelectedIndex != -1)
         {
             first = true;
             querystring += " WHERE ps_customerName = '" + cmbCustomers.SelectedItem.ToString() + "' ";
         }

         if (cmbCodes.SelectedIndex != -1)
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
             querystring += "ps_code ='" + cmbCodes.SelectedItem.ToString() + "' ";
         }

         if (cmbUsers.SelectedIndex != -1)
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
             querystring += "ps_user ='" + cmbUsers.SelectedItem.ToString() + "' ";
         }

         if (cmbSalesOrder.SelectedIndex != -1)
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
             querystring += "ps_saleOrder = " + cmbSalesOrder.SelectedItem.ToString() + " ";
         }

         if (cmbNotes.SelectedIndex != -1)
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
             querystring += "ps_observation = '" + cmbNotes.SelectedItem.ToString() + "' ";
         }

         querystring += " ORDER BY ps_number DESC";

         getDataSet(querystring);
         list.Clear();

         for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
         {
             list.Add(new clsPreseaShippings());
             list[list.Count - 1].number = Convert.ToInt32(DS.Tables[0].Rows[i]["ps_number"]);
             list[list.Count - 1].customerName = DS.Tables[0].Rows[i]["ps_customerName"].ToString();
             list[list.Count - 1].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["ps_date"]);
             list[list.Count - 1].code = DS.Tables[0].Rows[i]["ps_code"].ToString();
             list[list.Count - 1].price = Convert.ToDouble(DS.Tables[0].Rows[i]["ps_price"]);
             list[list.Count - 1].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["ps_quantity"]);
             list[list.Count - 1].iva = Convert.ToDouble(DS.Tables[0].Rows[i]["ps_iva"]);
             list[list.Count - 1].detail = DS.Tables[0].Rows[i]["ps_detail"].ToString();
             list[list.Count - 1].user = DS.Tables[0].Rows[i]["ps_user"].ToString();
             list[list.Count - 1].origin = DS.Tables[0].Rows[i]["ps_origin"].ToString();
             list[list.Count - 1].origin2 = DS.Tables[0].Rows[i]["ps_origin2"].ToString();
             list[list.Count - 1].saleOrder = DS.Tables[0].Rows[i]["ps_saleOrder"].ToString();
             list[list.Count - 1].observation = DS.Tables[0].Rows[i]["ps_observation"].ToString();
         }
         populateDataGrid();
     }

     private void btnDelFilter_Click(object sender, EventArgs e)
     {
         list.Clear();
         DataSet DS = new DataSet();
         DS = clsConnection.getDataSetResult("SELECT TOP (" + Convert.ToInt32(txtQuantity.Text) + ")* FROM bps_prod_preseaShippings ORDER BY ps_number DESC");

         for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
         {
             list.Add(new clsPreseaShippings());
             list[list.Count - 1].number = Convert.ToInt32(DS.Tables[0].Rows[i]["ps_number"]);
             list[list.Count - 1].customerName = DS.Tables[0].Rows[i]["ps_customerName"].ToString();
             list[list.Count - 1].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["ps_date"]);
             list[list.Count - 1].code = DS.Tables[0].Rows[i]["ps_code"].ToString();
             list[list.Count - 1].price = Convert.ToDouble(DS.Tables[0].Rows[i]["ps_price"]);
             list[list.Count - 1].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["ps_quantity"]);
             list[list.Count - 1].iva = Convert.ToDouble(DS.Tables[0].Rows[i]["ps_iva"]);
             list[list.Count - 1].detail = DS.Tables[0].Rows[i]["ps_detail"].ToString();
             list[list.Count - 1].user = DS.Tables[0].Rows[i]["ps_user"].ToString();
             list[list.Count - 1].origin = DS.Tables[0].Rows[i]["ps_origin"].ToString();
             list[list.Count - 1].origin2 = DS.Tables[0].Rows[i]["ps_origin2"].ToString();
             list[list.Count - 1].saleOrder = DS.Tables[0].Rows[i]["ps_saleOrder"].ToString();
             list[list.Count - 1].observation = DS.Tables[0].Rows[i]["ps_observation"].ToString();

         }
         populateDataGrid();
         cmbCustomers.ResetText();
         cmbCodes.ResetText();
         cmbUsers.ResetText();
         cmbSalesOrder.ResetText();
         cmbNotes.ResetText();

         cmbCustomers.SelectedIndex = -1;
         cmbCodes.SelectedIndex = -1;
         cmbUsers.SelectedIndex = -1;
         cmbSalesOrder.SelectedIndex = -1;
         cmbNotes.SelectedIndex = -1;
         
     }

     public string mostrarFecha()
     {
         DataSet DS2 = new DataSet();
         string query = "SELECT pre_date2 FROM bps_admin_presea WHERE pre_codsec = 1;";
         DS2 = clsConnection.getDataSetResult(query);
         string date = "";

         for (int i = 0; i < DS2.Tables[0].Rows.Count; i++)
         {
             date = DS2.Tables[0].Rows[i]["pre_date2"].ToString();
         }

         return date;
     }

     private void btnUpdatePS_Click(object sender, EventArgs e)
     {
         DataTable table = clsConnectionAccess.getShippings();

         if (table.Rows.Count > 0)
         {
             for (int i = 0; i < table.Rows.Count; i++)
             {
                 list.Add(new clsPreseaShippings());
                 list[list.Count - 1].number = Convert.ToInt32(table.Rows[i][0]);
                 list[list.Count - 1].customerName = table.Rows[i][3].ToString();
                 list[list.Count - 1].date = Convert.ToDateTime(table.Rows[i][4].ToString());
                 list[list.Count - 1].code = table.Rows[i][6].ToString();
                 list[list.Count - 1].price = Convert.ToDouble(table.Rows[i][7]);
                 list[list.Count - 1].quantity = Convert.ToDouble(table.Rows[i][8]);
                 list[list.Count - 1].iva = Convert.ToDouble(table.Rows[i][9]);
                 list[list.Count - 1].detail = table.Rows[i][10].ToString();
                 list[list.Count - 1].user = table.Rows[i][11].ToString();
                 list[list.Count - 1].origin = table.Rows[i][12].ToString();
                 list[list.Count - 1].origin2 = table.Rows[i][13].ToString();
                 list[list.Count - 1].saleOrder = table.Rows[i][14].ToString();
                 list[list.Count - 1].observation = table.Rows[i][15].ToString();
             }
         }
         //clsPreseaShippings.clear();
         save();

         txtUpdatedDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
         setActualizationDate(txtUpdatedDate.Text);
         getList();
         populateDataGrid();
         MessageBox.Show("Remitos actualizados correctamente", "Actualización remitos presea", MessageBoxButtons.OK);
     }

     private void btnExportExcel_Click(object sender, EventArgs e)
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

             // Format column D as text before pasting results, this was required for my data
             Excel.Range rng = xlWorkSheet.get_Range("C:C").Cells;
             rng.NumberFormat = "dd/MM/yyyy";

             // Paste clipboard results to worksheet range
             Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
             CR.Select();
             xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

             // For some reason column A is always blank in the worksheet.
             // Delete blank column A and select cell A1
             Excel.Range delRng = xlWorkSheet.get_Range("A:A").Cells;
             delRng.Delete(Type.Missing);
             xlWorkSheet.get_Range("A1").Select();

             //Delete column T (chkBox Value no needed)
             Excel.Range delRng2 = xlWorkSheet.get_Range("T:T").Cells;
             delRng2.Delete(Type.Missing);

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
             dgvPreseaRemit.ClearSelection();

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
                worksheet.Name = "Listado Remitos Presea";

                for (int i = 1; i < dgvPreseaRemit.Columns.Count + 1; i++)
                    worksheet.Cells[1, i] = dgvPreseaRemit.Columns[i - 1].HeaderText;

                for (int i = 0; i < dgvPreseaRemit.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvPreseaRemit.Columns.Count - 1; j++)
                    {
                        if (dgvPreseaRemit.Rows[i].Cells[j].Value != null)
                            worksheet.Cells[i + 2, j + 1] = dgvPreseaRemit.Rows[i].Cells[j].Value.ToString();
                    }
                }
                MessageBox.Show("Exportación Generada correctamente", "Listado Remitos Presea", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Listado Remitos Presea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

     private void copyAlltoClipboard()
     {
         dgvPreseaRemit.SelectAll();
         DataObject dataObj = dgvPreseaRemit.GetClipboardContent();
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
