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
    public partial class frmNewFormulationList : Form
    {
        private string maquinafiltrado = string.Empty;
        private string peliculafiltrado = string.Empty;
        private string nombrefiltrado = string.Empty;
        private string espesorfiltrado = string.Empty;
        private string estandarfiltrado = string.Empty;
        private string ultimocambio = string.Empty;
        private List<string> maquinas = new List<string>();
        private List<string> peliculas = new List<string>();
        private List<string> nombres = new List<string>();
        private List<double> espesores = new List<double>();
        private List<bool> estandar = new List<bool>();
        DataSet DS = new DataSet();
        public frmNewFormulationList()
        {
            InitializeComponent();
            ObtenerDS();
            llenardgv();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmNewFormulationList_Load(object sender, EventArgs e)
        {

        }
        public void ObtenerDS()
        {
            DS = clsConnection.getDataSetResult("SELECT * FROM vwNewFormulation");
        }

        public void llenardgv()
        {
            dgv.Rows.Clear();
            maquinas = new List<string>();
            peliculas = new List<string>();
            nombres = new List<string>();
            espesores = new List<double>();
            estandar = new List<bool>();

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    string concat = maquinafiltrado + peliculafiltrado + nombrefiltrado + espesorfiltrado + estandarfiltrado;
                    string concat2 = string.Empty;

                    if (maquinafiltrado != string.Empty)
                        concat2 += DS.Tables[0].Rows[i]["Maquina"].ToString();

                    if (peliculafiltrado != string.Empty)
                        concat2 += DS.Tables[0].Rows[i]["Pelicula"].ToString();

                    if (nombrefiltrado != string.Empty)
                        concat2 += DS.Tables[0].Rows[i]["Nombre"].ToString();

                    if (espesorfiltrado != string.Empty)
                        concat2 += DS.Tables[0].Rows[i]["Espesor"].ToString();

                    if (estandarfiltrado != string.Empty)
                    {
                        if (DS.Tables[0].Rows[i]["Estandar"].ToString() == "False")
                            concat2 += "No estandar";
                        else
                            concat2 += "Estandar";
                    }


                    if (concat == concat2)
                    {
                        dgv.Rows.Add();
                        int fila = dgv.Rows.Count - 1;
                        dgv.Rows[fila].Cells[clmMaquina.Index].Value = DS.Tables[0].Rows[i]["Maquina"];
                        dgv.Rows[fila].Cells[clmCodsec.Index].Value = DS.Tables[0].Rows[i]["codsec"];
                        dgv.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["Pelicula"];
                        dgv.Rows[fila].Cells[clmNombre.Index].Value = DS.Tables[0].Rows[i]["Nombre"];
                        dgv.Rows[fila].Cells[clmDescripcion.Index].Value = DS.Tables[0].Rows[i]["Descripcion"];
                        dgv.Rows[fila].Cells[clmEspesor.Index].Value = DS.Tables[0].Rows[i]["Espesor"];
                        dgv.Rows[fila].Cells[clmEstandar.Index].Value = Convert.ToBoolean(DS.Tables[0].Rows[i]["Estandar"]);

                        if (!maquinas.Contains(DS.Tables[0].Rows[i]["Maquina"].ToString()))
                            maquinas.Add(DS.Tables[0].Rows[i]["Maquina"].ToString());

                        if (!peliculas.Contains(DS.Tables[0].Rows[i]["Pelicula"].ToString()))
                            peliculas.Add(DS.Tables[0].Rows[i]["Pelicula"].ToString());

                        if (!nombres.Contains(DS.Tables[0].Rows[i]["Nombre"].ToString()))
                            nombres.Add(DS.Tables[0].Rows[i]["Nombre"].ToString());

                        if (!espesores.Contains(Convert.ToDouble(DS.Tables[0].Rows[i]["Espesor"])))
                            espesores.Add(Convert.ToDouble(DS.Tables[0].Rows[i]["Espesor"]));

                        if (!estandar.Contains(Convert.ToBoolean(DS.Tables[0].Rows[i]["Estandar"])))
                            estandar.Add(Convert.ToBoolean(DS.Tables[0].Rows[i]["Estandar"]));
                    }
                }
                maquinas.Sort();
                peliculas.Sort();
                nombres.Sort();
                espesores.Sort();
                estandar.Sort();
                if (ultimocambio != "maquina")
                {
                    cmbMaquina.Items.Clear();
                    for (int i = 0; i < maquinas.Count; i++)
                        cmbMaquina.Items.Add(maquinas[i]);
                }

                if (ultimocambio != "pelicula")
                {
                    cmbPelicula.Items.Clear();
                    for (int i = 0; i < peliculas.Count; i++)
                        cmbPelicula.Items.Add(peliculas[i]);
                }

                if (ultimocambio != "nombre")
                {
                    cmbNombre.Items.Clear();
                    for (int i = 0; i < nombres.Count; i++)
                        cmbNombre.Items.Add(nombres[i]);
                }

                if (ultimocambio != "espesores")
                {
                    cmbEspesor.Items.Clear();
                    for (int i = 0; i < espesores.Count; i++)
                        cmbEspesor.Items.Add(espesores[i]);
                }
                if (ultimocambio != "estandar")
                {
                    cmbEstandar.Items.Clear();
                    for (int i = 0; i < estandar.Count; i++)
                    {

                        if (estandar[i] == false)
                            cmbEstandar.Items.Add("No estandar");
                        else
                            cmbEstandar.Items.Add("Estandar");
                    }
                }
            }
        }

        private void cmbPelicula_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPelicula.SelectedIndex != -1)
            {
                if (peliculafiltrado != cmbPelicula.SelectedItem.ToString())
                {
                    peliculafiltrado = cmbPelicula.SelectedItem.ToString();
                    ultimocambio = "pelicula";
                    llenardgv();
                }
            }
            else
                peliculafiltrado = string.Empty;
        }

        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNombre.SelectedIndex != -1)
            {
                if (nombrefiltrado != cmbNombre.SelectedItem.ToString())
                {
                    nombrefiltrado = cmbNombre.SelectedItem.ToString();
                    ultimocambio = "nombre";
                    llenardgv();
                }
            }
            else
                nombrefiltrado = string.Empty;
        }

        private void cmbEspesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEspesor.SelectedIndex != -1)
            {
                if (espesorfiltrado != cmbEspesor.SelectedItem.ToString())
                {
                    espesorfiltrado = cmbEspesor.SelectedItem.ToString();
                    ultimocambio = "espesores";
                    llenardgv();
                }
            }
            else
                espesorfiltrado = string.Empty;
        }

        private void cmbPelicula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbPelicula.ResetText();
                peliculafiltrado = string.Empty;
                ultimocambio = string.Empty;
                llenardgv();
            }
        }

        private void cmbNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbNombre.ResetText();
                nombrefiltrado = string.Empty;
                ultimocambio = string.Empty;
                llenardgv();
            }
        }

        private void cmbEspesor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbEspesor.ResetText();
                espesorfiltrado = string.Empty;
                ultimocambio = string.Empty;
                llenardgv();
            }
        }

        private void cmbEstandar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEstandar.SelectedIndex != -1)
            {
                if (estandarfiltrado != cmbEstandar.SelectedItem.ToString())
                {
                    estandarfiltrado = cmbEstandar.SelectedItem.ToString();
                    ultimocambio = "estandar";
                    llenardgv();
                }
            }
            else
                estandarfiltrado = string.Empty;
        }

        private void cmbEstandar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbEstandar.ResetText();
                estandarfiltrado = string.Empty;
                ultimocambio = string.Empty;
                llenardgv();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            peliculafiltrado = string.Empty;
            nombrefiltrado = string.Empty;
            espesorfiltrado = string.Empty;
            estandarfiltrado = string.Empty;
            maquinafiltrado = string.Empty;

            cmbMaquina.ResetText();
            cmbMaquina.SelectedIndex = -1;
            cmbPelicula.ResetText();
            cmbPelicula.SelectedIndex = -1;
            cmbNombre.ResetText();
            cmbNombre.SelectedIndex = -1;
            cmbEspesor.ResetText();
            cmbEspesor.SelectedIndex = -1;
            cmbEstandar.ResetText();
            cmbEstandar.SelectedIndex = -1;

            ObtenerDS();
            llenardgv();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
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
                dgv.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }

            dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
        }

        private void copyAlltoClipboard()
        {
            dgv.SelectAll();
            DataObject dataObj = dgv.GetClipboardContent();
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
           
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cmbMaquina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaquina.SelectedIndex != -1)
            {
                if (maquinafiltrado != cmbMaquina.SelectedItem.ToString())
                {
                    maquinafiltrado = cmbMaquina.SelectedItem.ToString();
                    ultimocambio = "maquina";
                    llenardgv();
                }
            }
            else
                maquinafiltrado = string.Empty;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmBorrar.Index && e.RowIndex != -1)
            {
                if (MessageBox.Show("Esta seguro que desea eliminar la formulación?", "Formulaciones", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                    if (clsNewFormulation.Delete(Convert.ToInt32(DS.Tables[0].Rows[e.RowIndex][clmCodsec.Index])))
                        MessageBox.Show("La fórmula se eliminó correctamente", "Formulaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (e.ColumnIndex == clmVer.Index && e.RowIndex != -1)
            {
                frmBoppNewFormulationDetail form = new frmBoppNewFormulationDetail(Convert.ToInt32(dgv.CurrentRow.Cells[clmCodsec.Index].Value));
                form.MdiParent = this.MdiParent;
                form.Show();
            }
            if (dgv.CurrentRow != null && e.ColumnIndex == clmEditar.Index && e.RowIndex != -1)
            {
                frmFormulationBopp form = new frmFormulationBopp(Convert.ToInt32(dgv.CurrentRow.Cells[clmCodsec.Index].Value), true);
                form.ShowDialog();
            }
            ObtenerDS();
            llenardgv();
        }
    }
}