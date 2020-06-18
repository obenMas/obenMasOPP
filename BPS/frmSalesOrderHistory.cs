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
    public partial class frmSalesOrderHistory : Form
    {
        public frmSalesOrderHistory()
        {
            InitializeComponent();
            fillExecutives();
            fillCustomers();
            fillFilms();
            fillDiameters();
            fillCores();
        }

        private void fillExecutives()
        {
            List<clsUser> lista = clsUser.getListByRole("Ejecutivo de ventas");
            List<string> listast = new List<string>();

            for(int i=0;i<lista.Count;i++)
            {
                listast.Add(lista[i].userName);
            }

            listast.Sort();

            cmbExecutive.Items.Clear();

            for(int i=0; i<listast.Count;i++)
            {
                cmbExecutive.Items.Add(listast[i]);
            }
        }

        private void fillCustomers()
        {
            List<clsEntity> lista = clsEntity.getCustomerList();
            List<string> listast = new List<string>();

            for (int i = 0; i < lista.Count; i++)
            {
                listast.Add(lista[i].companyName);
            }

            listast.Sort();
            
            cmbCustommer.Items.Clear();

            for (int i = 0; i < listast.Count; i++)
            {
                cmbCustommer.Items.Add(listast[i]);
            }
        }

        private void fillFilms()
        {
            List<clsBopp> listabopp = clsBopp.getListShort();
            List<clsCast> listacast = clsCast.getSimplifiedList();
            List<clsCoating> listacoat = clsCoating.getSimplifiedList();

            List<string> lista = new List<string>();

            cmbFilm.Items.Clear();

            for (int i = 0; i < listabopp.Count; i++)
            {
                lista.Add(listabopp[i].code);
            }

            for (int i = 0; i < listacast.Count; i++)
            {
                lista.Add(listacast[i].code);
            }

            for (int i = 0; i < listacoat.Count; i++)
            {
                lista.Add(listacoat[i].code);
            }

            lista.Sort();

            for(int i=0;i<lista.Count;i++)
            {
                cmbFilm.Items.Add(lista[i]);
            }
        }

        private void fillDiameters()
        {
            List<clsDiameter> lista = clsDiameter.getList();
            List<string> listast = new List<string>();

            for (int i = 0; i < lista.Count; i++)
            {
                listast.Add(lista[i].abbreviation);
            }

            listast.Sort();

            cmbDiameter.Items.Clear();

            for (int i = 0; i < listast.Count; i++)
            {
                cmbDiameter.Items.Add(listast[i]);
            }
        }

        private void fillCores()
        {
            List<clsCore> lista = clsCore.getList();
            List<string> listast = new List<string>();

            for (int i = 0; i < lista.Count; i++)
            {
                listast.Add(lista[i].value.ToString());
            }

            listast.Sort();

            cmbCore.Items.Clear();

            for (int i = 0; i < lista.Count; i++)
            {
                cmbCore.Items.Add(listast[i]);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string querystring = "spSalesOrderHistory3 @cant=" + numReg.Value;
            if(cmbCustommer.SelectedIndex!=-1)
            {
                querystring += ", @cliente='" + cmbCustommer.Items[cmbCustommer.SelectedIndex].ToString()+"'";
            }
            else
            {
                querystring += ", @cliente=null";
            }
            if (cmbStatus.SelectedIndex != -1)
            {
                querystring += ", @est='" + cmbStatus.Items[cmbStatus.SelectedIndex].ToString() + "'";
            }
            else
            {
                querystring += ", @est=null";
            }
            if (cmbFilm.SelectedIndex != -1)
            {
                querystring += ", @film='" + cmbFilm.Items[cmbFilm.SelectedIndex].ToString()+"'";
            }
            else
            {
                querystring += ", @film=null";
            }
            if (numWidth.Value>0)
            {
                querystring += ", @wid='" + numWidth.Value.ToString()+"'";
            }
            else
            {
                querystring += ", @wid=null";
            }
            if (cmbDiameter.SelectedIndex != -1)
            {
                querystring += ", @diam='" + cmbDiameter.Items[cmbDiameter.SelectedIndex].ToString()+"'";
            }
            else
            {
                querystring += ", @diam=null";
            }
            if (cmbCore.SelectedIndex != -1)
            {
                querystring += ", @cor='" + cmbCore.Items[cmbCore.SelectedIndex].ToString()+"'";
            }
            else
            {
                querystring += ", @cor=null";
            }
            if (cmbExecutive.SelectedIndex != -1)
            {
                querystring += ", @ejec='" + cmbExecutive.Items[cmbExecutive.SelectedIndex].ToString()+"'";
            }
            else
            {
                querystring += ", @ejec=null";
            }

            DataSet DS = clsConnection.getDataSetResult(querystring);

            dgvSalesOrderHistory.Rows.Clear();

            if(DS.Tables.Count>0 && DS.Tables[0].Rows.Count>0)
            {
                for(int i=0;i<DS.Tables[0].Rows.Count;i++)
                {
                    dgvSalesOrderHistory.Rows.Add();
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells[clmCodsec.Index].Value = DS.Tables[0].Rows[i]["Codsec"];
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells[clmPlant.Index].Value = DS.Tables[0].Rows[i]["Planta"];
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells[clmCustomer.Index].Value = DS.Tables[0].Rows[i]["Cliente"];
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells[clmPurchaseOrder.Index].Value = DS.Tables[0].Rows[i]["OCCliente"];
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells[clmFilm.Index].Value = DS.Tables[0].Rows[i]["Pelicula"];
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells[clmWidth.Index].Value = DS.Tables[0].Rows[i]["Ancho"];
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells[clmDiameter.Index].Value = DS.Tables[0].Rows[i]["Diametro"];
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells[clmCore.Index].Value = DS.Tables[0].Rows[i]["Core"];
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells[clmQuantity.Index].Value = DS.Tables[0].Rows[i]["CantidadSolicitada"];
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells[clmDeliveredQuantity.Index].Value = DS.Tables[0].Rows[i]["CantidadEntregada"];
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells[clmPrice.Index].Value = DS.Tables[0].Rows[i]["Precio"];
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells[clmObservations.Index].Value = DS.Tables[0].Rows[i]["Observaciones"];
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells[clmStatus.Index].Value = DS.Tables[0].Rows[i]["Estado"];
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells[clmCreatedDate.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaIngreso"]).ToString("dd/MM/yyyy");
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells[clmSolicit.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaSolicitada"]).ToString("dd/MM/yyyy");
                    if(Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaPlanning"]).ToString("dd/MM/yyyy")!="01/01/1900")
                    {
                        dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells[clmPlanning.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaPlanning"]).ToString("dd/MM/yyyy");
                    }
                    if (Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaEntrega"]).ToString("dd/MM/yyyy") != "01/01/1900")
                    {
                        dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells[clmEntrega.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaEntrega"]).ToString("dd/MM/yyyy");
                    }
                    if (Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaInFull"]).ToString("dd/MM/yyyy") != "01/01/1900")
                    {
                        dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells[clmInFull.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaInFull"]).ToString("dd/MM/yyyy");
                    }
                    if (Convert.ToDateTime(DS.Tables[0].Rows[i]["fechaDespacho"]).ToString("dd/MM/yyyy") != "01/01/1900")
                    {
                        dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells[clmShippingDate.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["fechaDespacho"]).ToString("dd/MM/yyyy");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
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

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
        }

        private void copyAlltoClipboard()
        {
            dgvSalesOrderHistory.SelectAll();
            DataObject dataObj = dgvSalesOrderHistory.GetClipboardContent();
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