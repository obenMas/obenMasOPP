using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel; 

namespace BPS.Lite
{
    public partial class frmScrapMovementsReport : Form
    {
        //Usamos la lista que genera la clase por que el otro metodo de los 2 Dataset, era mas complejo.
        
        List<clsScrapMovements> list = new List<clsScrapMovements>();

        //Estas variables de tipo string es lo que voy a usar para los filtros.
        // Cada variable se tiene que corresponder con un filtro que se aplique sobre el DataGrid.

        string codigo = string.Empty;
        string tipo = string.Empty;
        string borigen = string.Empty;
        string bdestino = string.Empty;
        string turno = string.Empty;
        string tipoScrap = string.Empty;
        string usuario = string.Empty;
        string tipomov = string.Empty;


        // Este es uno especial que se utiliza para guardar cual fue el ultimo que cambio.
        // Asi se guarda este ultimo campo y se "filtran" todos los demas.
        string lastChange = string.Empty; 

        public frmScrapMovementsReport()
        {
            InitializeComponent();
            List<clsPlant> list = clsPlant.getList();
            for (int i = 0; i < list.Count; i++)
            {
                cmbPlanta.Items.Add(list[i].name);
            }
        }

        public void getList()
        {
            // Preguntar ssi deberia de traer una lista si es de pilar y otra si es de Campana.

            if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)
            {
                list = clsScrapMovements.getList();
            }
            else
            {
                list = clsScrapMovements.getList();
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            double netlengthC, netweigthC, usedlengthC, usedweigthC, currentweigthC;
            double netlengthMC, netweigthMC, usedlengthMC, usedweigthMC, currentweigthMC;
            double pesosTot = 0;

            string queryString;
            DataSet DS = new DataSet();

            if (cmbPlanta.SelectedIndex == -1)
            {
                queryString = "CALL spScrapMovementByDate ('" + dtpDesde.Value.ToString("dd/MM/yyyy") + "', '" + dtpHasta.Value.ToString("dd/MM/yyyy") + "');";
            }
            else
            {
                queryString = "CALL spScrapMovementByDateAndPlant ('" + dtpDesde.Value.ToString("dd/MM/yyyy") + "', '" + dtpHasta.Value.ToString("dd/MM/yyyy") + "', " + new clsPlant(cmbPlanta.Items[cmbPlanta.SelectedIndex].ToString()).codsec.ToString() + ");";
            }

            DS = clsConnection.getDataSetResult(queryString);

            dgvScrapMov.Rows.Clear();

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {   
                    dgvScrapMov.Rows.Add();
                    //Arrancan los ifs para la carga de codigos dentro del dgv
                    if(DS.Tables[0].Rows[i]["spCode"].ToString() != string.Empty)
                    {
                        dgvScrapMov.Rows[dgvScrapMov.Rows.Count - 1].Cells[clmCodigo.Index].Value = DS.Tables[0].Rows[i]["spCode"].ToString();
                        dgvScrapMov.Rows[dgvScrapMov.Rows.Count - 1].Cells[clmPeso.Index].Value = DS.Tables[0].Rows[i]["pesoPallet"].ToString();
                    }
                    else
                    {
                        if (DS.Tables[0].Rows[i]["coilCode"].ToString() != string.Empty)
                        {
                            clsCoil coil = new clsCoil();
                            coil = clsCoil.getDetailByCode(Convert.ToString(DS.Tables[0].Rows[i]["coilCode"]));
                            dgvScrapMov.Rows[dgvScrapMov.Rows.Count - 1].Cells[clmCodigo.Index].Value = "B-" + DS.Tables[0].Rows[i]["coilCode"].ToString();

                            usedlengthC = coil.getUsedLength(coil.codsec);
                            netlengthC = coil.length;
                            netweigthC = coil.netWeight;
                            usedweigthC = 0;
                            currentweigthC = 0;

                            usedweigthC = ((usedlengthC * netweigthC) / netlengthC);

                            currentweigthC = netweigthC - usedweigthC;
                            if (currentweigthC > 0)
                            {
                                dgvScrapMov.Rows[dgvScrapMov.Rows.Count - 1].Cells[clmPeso.Index].Value = currentweigthC;
                            }
                            else
                            {
                                dgvScrapMov.Rows[dgvScrapMov.Rows.Count - 1].Cells[clmPeso.Index].Value = 0;
                            }
                            
                        }
                        else
                        {
                            clsMainCoil mainCoil = new clsMainCoil(DS.Tables[0].Rows[i]["mclCode"].ToString());
                            
                            dgvScrapMov.Rows[dgvScrapMov.Rows.Count - 1].Cells[clmCodigo.Index].Value = DS.Tables[0].Rows[i]["mclCode"].ToString();
                            if (DS.Tables[0].Rows[i]["mclCode"].ToString() != string.Empty)
                            {
                                usedlengthMC = mainCoil.usedLength;
                                netlengthMC = mainCoil.netlength;
                                netweigthMC = mainCoil.netWeigth;
                                usedweigthMC = 0;
                                currentweigthC = 0;

                                usedweigthMC = ((usedlengthMC * netweigthMC) / netlengthMC);

                                currentweigthMC = netweigthMC - usedweigthMC;

                                dgvScrapMov.Rows[dgvScrapMov.Rows.Count - 1].Cells[clmPeso.Index].Value = currentweigthMC;
                            }
                            else
                            {
                                dgvScrapMov.Rows[dgvScrapMov.Rows.Count - 1].Cells[clmPeso.Index].Value = DS.Tables[0].Rows[i]["pesoPallet"].ToString();
                            }
                            
                        }
                    } // Aca termino la carga de los codigos de pallets, bobina o bobinas madres y con sus respectivos pesos calculados.
                    dgvScrapMov.Rows[dgvScrapMov.Rows.Count - 1].Cells[clmTipoMov.Index].Value = DS.Tables[0].Rows[i]["TipoMov"].ToString();
                    dgvScrapMov.Rows[dgvScrapMov.Rows.Count - 1].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["pelicula"].ToString();
                    dgvScrapMov.Rows[dgvScrapMov.Rows.Count - 1].Cells[clmtScrap.Index].Value = DS.Tables[0].Rows[i]["TipoScrap"].ToString();
                    dgvScrapMov.Rows[dgvScrapMov.Rows.Count - 1].Cells[clmOrigin.Index].Value = DS.Tables[0].Rows[i]["BodegaOrigen"].ToString();
                    dgvScrapMov.Rows[dgvScrapMov.Rows.Count - 1].Cells[clmDestination.Index].Value = DS.Tables[0].Rows[i]["BodegaDestino"].ToString();
                    dgvScrapMov.Rows[dgvScrapMov.Rows.Count - 1].Cells[clmUser.Index].Value = DS.Tables[0].Rows[i]["Usuario"].ToString();
                    dgvScrapMov.Rows[dgvScrapMov.Rows.Count - 1].Cells[clmFecha.Index].Value = DS.Tables[0].Rows[i]["Fecha"].ToString();
                    dgvScrapMov.Rows[dgvScrapMov.Rows.Count - 1].Cells[clmDay.Index].Value = DS.Tables[0].Rows[i]["dayFecha"];
                    dgvScrapMov.Rows[dgvScrapMov.Rows.Count - 1].Cells[clmMonth.Index].Value = DS.Tables[0].Rows[i]["monthFecha"];
                    dgvScrapMov.Rows[dgvScrapMov.Rows.Count - 1].Cells[clmYear.Index].Value = DS.Tables[0].Rows[i]["yearFecha"];
                    dgvScrapMov.Rows[dgvScrapMov.Rows.Count - 1].Cells[clmHour.Index].Value = DS.Tables[0].Rows[i]["Hora"];


                    foreach (DataGridViewRow row in dgvScrapMov.Rows)
                    {

                        pesosTot = Math.Round(pesosTot + Convert.ToDouble(row.Cells["clmPeso"].Value),2);
                        txtPesos.Text = Convert.ToString(pesosTot);

                    }
                }
            }
            
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            // supongo que aca pongo las columnas que voy a exportar al excel.
            string ext = string.Empty;
            dgvScrapMov.Columns["clmCodigo"].Visible = true;
            dgvScrapMov.Columns["clmTipoMov"].Visible = true;
            dgvScrapMov.Columns["clmPeso"].Visible = true;
            dgvScrapMov.Columns["clmtScrap"].Visible = true;
            dgvScrapMov.Columns["clmOrigin"].Visible = true;
            dgvScrapMov.Columns["clmDestination"].Visible = true;
            dgvScrapMov.Columns["clmUser"].Visible = true;
            dgvScrapMov.Columns["clmFecha"].Visible = false;
            dgvScrapMov.Columns["clmDay"].Visible = true;
            dgvScrapMov.Columns["clmMonth"].Visible = true;
            dgvScrapMov.Columns["clmYear"].Visible = true;

            dgvScrapMov.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;

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
                dgvScrapMov.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }

            // Esto lo que hace es, luego de exportarlo te oculta las columnas que se exportaron.
            // false = no visible ---- true = se ve la columna

            dgvScrapMov.Columns["clmCodigo"].Visible = true;
            dgvScrapMov.Columns["clmTipoMov"].Visible = true;
            dgvScrapMov.Columns["clmPeso"].Visible = true;
            dgvScrapMov.Columns["clmtScrap"].Visible = true;
            dgvScrapMov.Columns["clmOrigin"].Visible = true;
            dgvScrapMov.Columns["clmDestination"].Visible = true;
            dgvScrapMov.Columns["clmUser"].Visible = true;
            dgvScrapMov.Columns["clmFecha"].Visible = true;
            dgvScrapMov.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
        }

        private void copyAlltoClipboard()
        {
            dgvScrapMov.SelectAll();
            DataObject dataObj = dgvScrapMov.GetClipboardContent();
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

