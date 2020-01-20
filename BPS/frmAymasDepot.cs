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
    public partial class frmAymasDepot : Form
    {
        List<clsAymasDepot> list = new List<clsAymasDepot>();
        DataSet DS = new DataSet();

        public frmAymasDepot()
        {
            InitializeComponent();
            getList();
            populateDataGrid();
        }

        public void getList()
        {
            list = clsAymasDepot.getList();
        }
        //agregados por ndizner para realizar la parte de filtros
        public void getDataSet(string query)
        {
            DS = clsConnection.getDataSetResult(query);
        }
        //fin comentario

        public void populateDataGrid()
        {
            List<string> pltCodes = new List<string>();
            List<string> films = new List<string>();
            List<string> diameters = new List<string>();
            List<string> cores = new List<string>();
            List<string> orders = new List<string>();
            List<string> customers = new List<string>();
            List<string> satus = new List<string>();

            dgvAymasDepot.Rows.Clear();
            cmbPalletCode.Items.Clear();
            cmbFilm.Items.Clear();
            cmbDiameter.Items.Clear();
            cmbCore.Items.Clear();
            cmbOrder.Items.Clear();
            cmbCustomer.Items.Clear();
            cmbStatus.Items.Clear();

            dgvAymasDepot.Rows.Clear();
            for(int i=0;i<list.Count;i++)
            {
                dgvAymasDepot.Rows.Add();
                dgvAymasDepot.Rows[dgvAymasDepot.Rows.Count - 1].Cells[clmPalletCode.Index].Value = list[i].palletCode;
                dgvAymasDepot.Rows[dgvAymasDepot.Rows.Count - 1].Cells[clmFilm.Index].Value = list[i].film;
                dgvAymasDepot.Rows[dgvAymasDepot.Rows.Count - 1].Cells[clmWidth.Index].Value = list[i].width;
                dgvAymasDepot.Rows[dgvAymasDepot.Rows.Count - 1].Cells[clmWeight.Index].Value = list[i].weigth;
                dgvAymasDepot.Rows[dgvAymasDepot.Rows.Count - 1].Cells[clmDiameter.Index].Value = list[i].diameter;
                dgvAymasDepot.Rows[dgvAymasDepot.Rows.Count - 1].Cells[clmCore.Index].Value = list[i].core;
                dgvAymasDepot.Rows[dgvAymasDepot.Rows.Count - 1].Cells[clmProcedence.Index].Value = list[i].procedence;
                dgvAymasDepot.Rows[dgvAymasDepot.Rows.Count - 1].Cells[clmSaleOrderDetail.Index].Value = list[i].fkSaleOrderDetail;
                dgvAymasDepot.Rows[dgvAymasDepot.Rows.Count - 1].Cells[clmSaleOrder.Index].Value = list[i].saleOrder;
                dgvAymasDepot.Rows[dgvAymasDepot.Rows.Count - 1].Cells[clmCustommer.Index].Value = list[i].customer;
                dgvAymasDepot.Rows[dgvAymasDepot.Rows.Count - 1].Cells[clmQuality.Index].Value = list[i].quality;
                dgvAymasDepot.Rows[dgvAymasDepot.Rows.Count - 1].Cells[clmState.Index].Value = list[i].state;
                dgvAymasDepot.Rows[dgvAymasDepot.Rows.Count - 1].Cells[clmDate.Index].Value = list[i].date.ToString("dd/MM/yyyy");

                pltCodes.Sort();
                films.Sort();
                diameters.Sort();
                cores.Sort();
                orders.Sort();
                customers.Sort();
                satus.Sort();


                if (!pltCodes.Contains(list[i].palletCode.ToString()))
                    pltCodes.Add(list[i].palletCode.ToString());

                if (!films.Contains(list[i].film.ToString()))
                    films.Add(list[i].film.ToString());

                if (!diameters.Contains(list[i].diameter.ToString()))
                    diameters.Add(list[i].diameter.ToString());

                if (!cores.Contains(list[i].core.ToString()))
                    cores.Add(list[i].core.ToString());

                if (!orders.Contains(list[i].saleOrder.ToString()))
                    orders.Add(list[i].saleOrder.ToString());

                if (!customers.Contains(list[i].customer.ToString()))
                customers.Add(list[i].customer.ToString());

                if (!satus.Contains(list[i].state.ToString()))
                    satus.Add(list[i].state.ToString());
            }

            for (int i = 0; i < pltCodes.Count; i++)
            {
                cmbPalletCode.Items.Add(pltCodes[i]);
            }

            for (int i = 0; i < films.Count; i++)
            {
                cmbFilm.Items.Add(films[i]);
            }

            for (int i = 0; i < diameters.Count; i++)
            {
                cmbDiameter.Items.Add(diameters[i]);
            }

            for (int i = 0; i < cores.Count; i++)
            {
                cmbCore.Items.Add(cores[i]);
            }

            for (int i = 0; i < orders.Count; i++)
            {
                cmbOrder.Items.Add(orders[i]);
            }

            for (int i = 0; i < customers.Count; i++)
            {
                cmbCustomer.Items.Add(customers[i]);
            }

            for (int i = 0; i < satus.Count; i++)
            {
                cmbStatus.Items.Add(satus[i]);
            }

            if (cmbPalletCode.Text != string.Empty)
                cmbPalletCode.SelectedIndex = 0;

            if (cmbFilm.Text != string.Empty)
                cmbFilm.SelectedIndex = 0;

            if (cmbDiameter.Text != string.Empty)
                cmbDiameter.SelectedIndex = 0;

            if (cmbCore.Text != string.Empty)
                cmbCore.SelectedIndex = 0;

            if (cmbOrder.Text != string.Empty)
                cmbOrder.SelectedIndex = 0;

            if (cmbCustomer.Text != string.Empty)
                cmbCustomer.SelectedIndex = 0;

            if (cmbStatus.Text != string.Empty)
                cmbStatus.SelectedIndex = 0;

            txtDate.Text= mostrarFecha();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataTable table = clsConnectionAccess.getDepot();

            if(table.Rows.Count>0)
            {
                for(int i=0;i<table.Rows.Count;i++)
                {
                    list.Add(new clsAymasDepot());
                    list[list.Count - 1].Id = table.Rows[i][0].ToString();
                    list[list.Count-1].palletCode = table.Rows[i][1].ToString();
                    list[list.Count - 1].film = getObenFilmCode(table.Rows[i][2].ToString() + table.Rows[i][3].ToString());
                    list[list.Count - 1].width = Convert.ToInt32(table.Rows[i][4]);
                    list[list.Count - 1].weigth = Convert.ToDouble(table.Rows[i][5]);
                    list[list.Count - 1].diameter = table.Rows[i][8].ToString();
                    list[list.Count - 1].core = Convert.ToInt32(table.Rows[i][9]);
                    list[list.Count - 1].procedence = table.Rows[i][6].ToString();
                    list[list.Count - 1].saleOrder = table.Rows[i][10].ToString();
                    list[list.Count - 1].customer = table.Rows[i][11].ToString();
                    list[list.Count - 1].quality = table.Rows[i][7].ToString();
                    list[list.Count - 1].state = table.Rows[i][12].ToString();
                    list[list.Count - 1].date = Convert.ToDateTime(table.Rows[i][13]);
                }
            }
            clsAymasDepot.clear();
            save();

            txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            setActualizationDate(txtDate.Text);
            getList();
            populateDataGrid();
            MessageBox.Show("Deposito actualizado correctamente", "Actualización deposito Aymas", MessageBoxButtons.OK);
        }

        public void save()
        {
            clsAymasDepot obj = new clsAymasDepot(); 
            for(int i=0;i<list.Count;i++)
            {
                obj = list[i];
                obj.save();
            }
        }

        public void setActualizationDate(string date)
        {
            string querystring = "UPDATE bps_admin_presea SET pre_date = '"+date+ "' WHERE pre_codsec = 1;";
            bool preuba= clsConnection.executeQuery(querystring);
        }

        public string getObenFilmCode(string AymasCode)
        {
            string code;
            if (AymasCode.StartsWith("E") || AymasCode.StartsWith("NHTT") || AymasCode.StartsWith("ATTT") || AymasCode.StartsWith("BDTT"))
            {
                if (AymasCode.Substring(4, 1)==" ")
                {
                    code = AymasCode.Substring(0, 2) + "0" + AymasCode.Substring(5, 2) + AymasCode.Substring(2, 2);
                }
                else
                {
                    code = AymasCode.Substring(0, 2) + "0" + AymasCode.Substring(4, 2) + AymasCode.Substring(2, 2);
                }
                
            }
            else if (AymasCode.StartsWith("R"))
            {
                AymasCode = AymasCode.Replace("-", "");
                if (AymasCode.Length == 7)
                {
                    code = AymasCode.Substring(0, 3) + "0" + AymasCode.Substring(3, 4);
                }
                else
                {
                    code = AymasCode.Substring(0, 4) + "0" + AymasCode.Substring(4, 4);
                }
                
            }
            else
            {
                AymasCode=AymasCode.Replace("O", "");
                AymasCode=AymasCode.Replace("-0", "");
                AymasCode = AymasCode.Replace(" ", "");
                if(AymasCode.Length==4)
                {
                    code = AymasCode.Substring(0, 2) + "0" + AymasCode.Substring(2, 2);
                }
                else if (AymasCode.Length == 5)
                {
                    code = AymasCode.Substring(0, 3) + "0" + AymasCode.Substring(3, 2);
                }
                else
                {
                    code = AymasCode.Substring(0, 4) + "0" + AymasCode.Substring(4, 2);
                }
                
            }
            return code.ToUpper();
        }

        private void button1_Click(object sender, EventArgs e) //filtrar
        {

            bool first = false;
            string querystring = "SELECT * FROM vwAymasDepot";

            if(cmbPalletCode.SelectedIndex != -1)
            {
                first = true;
                querystring += " WHERE palletCode = '" + cmbPalletCode.SelectedItem.ToString() + "' ";
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
                querystring += "film ='" + cmbFilm.SelectedItem.ToString() + "' ";
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
                querystring += "diameter ='" + cmbDiameter.SelectedItem.ToString() + "' ";
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
                querystring += "core = " + cmbCore.SelectedItem.ToString() + " ";
            }

            if (cmbOrder.SelectedIndex != -1)
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
                querystring += "saleOrder ='" + cmbOrder.SelectedItem.ToString() + "' ";
            }

            if (cmbCustomer.SelectedIndex != -1)
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
                querystring += "customer ='" + cmbCustomer.SelectedItem.ToString() + "' ";
            }

            if (cmbStatus.SelectedIndex != -1)
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
                querystring += "state ='" + cmbStatus.SelectedItem.ToString() + "' ";
            }



            getDataSet(querystring);
            list.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                list.Add(new clsAymasDepot());
                list[list.Count-1].palletCode = DS.Tables[0].Rows[i]["palletCode"].ToString();
                list[list.Count - 1].film = DS.Tables[0].Rows[i]["film"].ToString();
                list[list.Count - 1].width = Convert.ToInt32(DS.Tables[0].Rows[i]["width"]);
                list[list.Count - 1].weigth = Convert.ToDouble(DS.Tables[0].Rows[i]["weigth"]); 
                list[list.Count - 1].diameter = DS.Tables[0].Rows[i]["diameter"].ToString();
                list[list.Count - 1].core = Convert.ToInt32(DS.Tables[0].Rows[i]["core"]);
                list[list.Count - 1].procedence = DS.Tables[0].Rows[i]["procedence"].ToString();
                list[list.Count - 1].saleOrder = DS.Tables[0].Rows[i]["saleOrder"].ToString();
                list[list.Count - 1].customer = DS.Tables[0].Rows[i]["customer"].ToString();
                list[list.Count - 1].quality =  DS.Tables[0].Rows[i]["quality"].ToString();
                list[list.Count - 1].state = DS.Tables[0].Rows[i]["state"].ToString();
                list[list.Count - 1].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["date"]);
                
            }
            populateDataGrid();
        }

        private void button2_Click(object sender, EventArgs e) //quitar Filtro
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwAymasDepot");

            list.Clear();
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                list.Add(new clsAymasDepot());
                list[list.Count - 1].palletCode = DS.Tables[0].Rows[i]["palletCode"].ToString();
                list[list.Count - 1].film = DS.Tables[0].Rows[i]["film"].ToString();
                list[list.Count - 1].width = Convert.ToInt32(DS.Tables[0].Rows[i]["width"]);
                list[list.Count - 1].weigth = Convert.ToDouble(DS.Tables[0].Rows[i]["weigth"]);
                list[list.Count - 1].diameter = DS.Tables[0].Rows[i]["diameter"].ToString();
                list[list.Count - 1].core = Convert.ToInt32(DS.Tables[0].Rows[i]["core"]);
                list[list.Count - 1].procedence = DS.Tables[0].Rows[i]["procedence"].ToString();
                list[list.Count - 1].saleOrder = DS.Tables[0].Rows[i]["saleOrder"].ToString();
                list[list.Count - 1].customer = DS.Tables[0].Rows[i]["customer"].ToString();
                list[list.Count - 1].quality = DS.Tables[0].Rows[i]["quality"].ToString();
                list[list.Count - 1].state = DS.Tables[0].Rows[i]["state"].ToString();
                list[list.Count - 1].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["date"]);

            }
            populateDataGrid();
            cmbPalletCode.ResetText();
            cmbFilm.ResetText();
            cmbDiameter.ResetText();
            cmbCore.ResetText();
            cmbOrder.ResetText();
            cmbCustomer.ResetText();
            cmbStatus.ResetText();

            cmbPalletCode.SelectedIndex = -1;
            cmbFilm.SelectedIndex = -1;
            cmbDiameter.SelectedIndex = -1;
            cmbCore.SelectedIndex = -1;
            cmbOrder.SelectedIndex = -1;
            cmbCustomer.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
        }

        public string mostrarFecha()
        {
            DataSet DS2 = new DataSet();
            string query = "SELECT pre_date FROM bps_admin_presea WHERE pre_codsec = 1;";
            DS2=clsConnection.getDataSetResult(query);
            string date = "";

            for (int i = 0; i < DS2.Tables[0].Rows.Count; i++)
            {
                date= DS2.Tables[0].Rows[i]["pre_date"].ToString();
            }

            return date;
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
                Excel.Range rng = xlWorkSheet.get_Range("M:M").Cells;
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
                dgvAymasDepot.ClearSelection();

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
                worksheet.Name = "Listado depósito Aymas";

                for (int i = 1; i < dgvAymasDepot.Columns.Count + 1; i++)
                    worksheet.Cells[1, i] = dgvAymasDepot.Columns[i - 1].HeaderText;

                for (int i = 0; i < dgvAymasDepot.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvAymasDepot.Columns.Count - 1; j++)
                    {
                        if (dgvAymasDepot.Rows[i].Cells[j].Value != null)
                            worksheet.Cells[i + 2, j + 1] = dgvAymasDepot.Rows[i].Cells[j].Value.ToString();
                    }
                }
                MessageBox.Show("Exportación Generada correctamente", "Listado depósito Aymas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Listado depósito Aymas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

        }

        private void copyAlltoClipboard()
        {
            dgvAymasDepot.SelectAll();
            DataObject dataObj = dgvAymasDepot.GetClipboardContent();
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
