using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;
using Excel = Microsoft.Office.Interop.Excel;  //Supongo, que importa algo para exportar a excel.
using System.IO;

namespace BPS
{
    public partial class frmExtruderStock : Form
    {
        List<clsScrapByExtruderCellar> listaExtStock = new List<clsScrapByExtruderCellar>();

        //Los filtros del Dgv
        string tipoMat = string.Empty;
        string deposito = string.Empty;
        string lastChange = string.Empty;

        public frmExtruderStock()
        {
            InitializeComponent();
        }

        private void frmExtruderStock_Load(object sender, EventArgs e)
        {
            getList();
            populateDgv();
        }

        public void getList()
        {
            if (clsGlobal.LoggedUser.fkRole == 2029 || clsGlobal.LoggedUser.fkRole == 2030)
            {
                listaExtStock = clsScrapByExtruderCellar.getWeigthInExtruderCellarByPlant(4);
            }
            else
            {
                listaExtStock = clsScrapByExtruderCellar.getWeigthInExtruderCellarByPlant(3);
            }
        }

        public void populateDgv()
        {
            List<string> tipoMats = new List<string>();

            double pesos = 0;

            if (lastChange != "tipomaterial")
            {
                cmbTipoScrap.Items.Clear();
            }
        

            dgvExtruderStock.Rows.Clear();

            if (listaExtStock.Count > 0)
            {
                for (int i = 0; i < listaExtStock.Count; i++)
                {
                    string concat = tipoMat;
                    string concat2 = string.Empty;

                    if (tipoMat != string.Empty)
                    {
                        concat2 += listaExtStock[i].Scrap.name.ToString();
                    }

                    if (concat == concat2)
                    {
                        dgvExtruderStock.Rows.Add();
                        dgvExtruderStock.Rows[dgvExtruderStock.Rows.Count - 1].Cells[clmCodsec.Index].Value = listaExtStock[i].codsec;
                        dgvExtruderStock.Rows[dgvExtruderStock.Rows.Count - 1].Cells[clmTipoScrap.Index].Value = listaExtStock[i].Scrap.name;
                        dgvExtruderStock.Rows[dgvExtruderStock.Rows.Count - 1].Cells[clmPeso.Index].Value = listaExtStock[i].weigth;
                        dgvExtruderStock.Rows[dgvExtruderStock.Rows.Count - 1].Cells[clmDeposito.Index].Value = listaExtStock[i].deposito.name;

                        if (!tipoMats.Contains(listaExtStock[i].Scrap.name))
                            tipoMats.Add(listaExtStock[i].Scrap.name);

                    }
                }

                tipoMats.Sort();

                if (lastChange != "tipomaterial")
                {
                    for (int i = 0; i < tipoMats.Count; i++)
                    {
                        if (tipoMats[i] != null)
                        {
                            cmbTipoScrap.Items.Add(tipoMats[i]);
                        }
                    }
                }

                foreach (DataGridViewRow rows in dgvExtruderStock.Rows)
                {
                    pesos = pesos + Convert.ToDouble(rows.Cells["clmPeso"].Value);
                    txtPesos.Text = Convert.ToString(pesos);
                }
            }
        }

        private void cmbTipoScrap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoScrap.SelectedIndex != -1)
            {
                if (tipoMat != cmbTipoScrap.SelectedItem.ToString())
                {
                    tipoMat = cmbTipoScrap.SelectedItem.ToString();
                    lastChange = "tipomaterial";
                    populateDgv();
                }
                else
                {
                    tipoMat = string.Empty;
                }
            }
        }       

        private void cmbTipoScrap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbTipoScrap.ResetText();
                tipoMat = string.Empty;
                lastChange = string.Empty;
                populateDgv();
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            // supongo que aca pongo las columnas que voy a exportar al excel.
            string ext = string.Empty;
            dgvExtruderStock.Columns["clmTipoScrap"].Visible = true;
            dgvExtruderStock.Columns["clmPeso"].Visible = true;
            dgvExtruderStock.Columns["clmDeposito"].Visible = true;
            dgvExtruderStock.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;

            //Genero el save y en que formato se va a poder grabar (supongo)
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
                dgvExtruderStock.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }

            // Esto lo que hace es, luego de exportarlo te oculta las columnas que se exportaron.
            // false = no visible ---- true = se ve la columna
            dgvExtruderStock.Columns["clmTipoScrap"].Visible = true;
            dgvExtruderStock.Columns["clmPeso"].Visible = true;
            dgvExtruderStock.Columns["clmDeposito"].Visible = true;
            dgvExtruderStock.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
        }

        private void copyAlltoClipboard()
        {
            dgvExtruderStock.SelectAll();
            DataObject dataObj = dgvExtruderStock.GetClipboardContent();
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
