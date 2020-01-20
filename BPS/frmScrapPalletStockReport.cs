using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;
//Agrego usings, que estan en el otro form
using Excel = Microsoft.Office.Interop.Excel;  //Supongo, que importa algo para exportar a excel.
using System.IO;

namespace BPS
{
    public partial class frmScrapPalletStockReport : Form
    {
       //Usamos la lista que genera la clase por que el otro metodo de los 2 Dataset, era mas complejo.

        List<clsScrapPallet> list = new List<clsScrapPallet>();

        //Estas variables de tipo string es lo que voy a usar para los filtros.
        // Cada variable se tiene que corresponder con un filtro que se aplique sobre el DataGrid.

        string codigo = string.Empty;
        string tipo = string.Empty;
        string maquina = string.Empty;
        string turno = string.Empty;
        // Este es uno especial que se utiliza para guardar cual fue el ultimo que cambio.
        // Asi se guarda este ultimo campo y se "filtran" todos los demas.
        string lastChange = string.Empty; 

        public frmScrapPalletStockReport()
        {
            InitializeComponent();
            
        }

        private void frmScrapPalletStock_Load(object sender, EventArgs e)
        {
            getList();
            populateDgv(); // Este evento me carga el DataGrid, con los datos de la BD. 
        }

        public void getList()
        {
            //En teoria, lo que hace esta funcion es llenar el Datagrid, con el metodo getlist de la clase que esta en 
            // ScrapPallet.

            if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027 || clsGlobal.LoggedUser.fkRole == 2032)
            {
                list = clsScrapPallet.getStockInCoilCellarbyPlant(4);
            }
            else
            {
                list = clsScrapPallet.getStockInCoilCellarbyPlant(3);
            }
        }

        public void populateDgv()
        {
            List<string> codigos = new List<string>();
            List<string> tipos = new List<string>();
            List<string> maquinas = new List<string>();
            List<string> turnos = new List<string>();
            double pesos = 0; // Se setea una unica vez, despues el foreach hace la magia.

            // Limpia Por las dudas, los cmb que no fueron seleccionados.
 
            if (lastChange != "codigo")
            {
                cmbCodigo.Items.Clear();
            }
            if (lastChange != "tipo")
            {
                cmbTipo.Items.Clear();
            }
            if (lastChange != "maquina")
            {
                cmbMaquina.Items.Clear();
            }
            if (lastChange != "turno")
            {
                cmbTurno.Items.Clear();
            }

            // una vez que las variables fueron cargadas con los strings segun los combo de filtros que hayan hecho se realiza lo siguiente:
            // genera una variable concat donde va a tener los valores de string de los filtros que eligio.

            dataGridView1.Rows.Clear();

            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    //cada varibale del concat, se llena con lo q seleccionaron del cmbox
                    string concat = codigo + turno + tipo + maquina;
                    string concat2 = string.Empty;

                    if (codigo != string.Empty)
                    {
                        // Al final no se usa la consulta se usa la lista, asi que chau a todos los DS.
                        concat2 = list[i].code.ToString();
                    }
                    if (turno != string.Empty)
                    {
                        concat2 += list[i].turn.ToString();
                    }
                    if (tipo != string.Empty)
                    {
                        concat2 += list[i].Scrap.name.ToString();
                    }
                    if (maquina != string.Empty)
                    {
                        concat2 += list[i].Machine.Cutter.ToString();
                    }
                    if (concat == concat2)
                    {
                        //Si coiniciden que lo concatenado dentro del campo es igual a lo seleccionado con loss combos, entonces:
                        // empiezo a recrear la tabla a partir de los campos que se seleccionaron.

                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmCodsec.Index].Value = list[i].codsec;
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmCodigo.Index].Value = list[i].code;
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmTipo.Index].Value = list[i].Scrap.name;
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmMaquina.Index].Value = list[i].Machine.Cutter.name;
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmTurno.Index].Value = list[i].turn;
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmPeso.Index].Value = list[i].netWeigth;
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmFecha.Index].Value = list[i].date;
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmStatus.Index].Value = list[i].fkStatus;

                        //si dio el concat bien, aca es donde agrego a la lista los diferentes codigos y las diferentes campos.
                        //que luego se van a mostrar filtradas en el datagrid.


                        if (!codigos.Contains(list[i].code))
                            codigos.Add(list[i].code);

                        if (!tipos.Contains(list[i].Scrap.name))
                            tipos.Add(list[i].Scrap.name);

                        if (!maquinas.Contains(list[i].Machine.Cutter.name))
                            maquinas.Add(list[i].Machine.Cutter.name);

                        if (!turnos.Contains(list[i].turn.ToString()))
                            turnos.Add(list[i].turn.ToString());

                    }                    
                }

                codigos.Sort();
                tipos.Sort();
                turnos.Sort();
                maquinas.Sort();

                // Estos if's lo que hacen es que se van llenando los combos con los datos de las sublistas que se van generando
                // a partir de los filtros que se van haciendo.
                
                if (lastChange != "codigo")
                {
                    for (int i = 0; i < codigos.Count; i++)
                    {
                        cmbCodigo.Items.Add(codigos[i]);
                    }
                }


                if (lastChange != "tipo")
                {
                    for (int i = 0; i < tipos.Count; i++)
                    {
                        cmbTipo.Items.Add(tipos[i]);
                    }
                }


                if (lastChange != "maquina")
                {
                    for (int i = 0; i < maquinas.Count; i++)
                    {
                        cmbMaquina.Items.Add(maquinas[i]);
                    }
                }


                if (lastChange != "turno")
                {
                    for (int i = 0; i < turnos.Count; i++)
                    {
                        cmbTurno.Items.Add(turnos[i]);
                    }
                }
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                pesos = pesos + Convert.ToDouble(row.Cells["clmPeso"].Value);
                txtPesos.Text = Convert.ToString(pesos);

            }
        }

 //Lo que se hace acá es segun el combo que se seleccione se guarda un string con el nombre de la variable
 //(que luego se usa en una serie de if y se invoca nuevamente al populate datagrid para que se recargue el datagrid)


        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCodigo.SelectedIndex != -1)
            {
                if (codigo != cmbCodigo.SelectedItem.ToString())
                {
                    codigo = cmbCodigo.SelectedItem.ToString();
                    lastChange = "codigo";
                    populateDgv();
                }
            }
            else
            {
                codigo = string.Empty;
            }
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex != -1)
            {
                if (tipo != cmbTipo.SelectedItem.ToString())
                {
                    tipo = cmbTipo.SelectedItem.ToString();
                    lastChange = "tipo";
                    populateDgv();
                }
            }
            else
            {
                tipo = string.Empty;
            }
        }

        private void cmbMaquina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaquina.SelectedIndex != -1)
            {
                if (maquina != cmbMaquina.SelectedItem.ToString())
                {
                    maquina = cmbMaquina.SelectedItem.ToString();
                    lastChange = "maquina";
                    populateDgv();
                }
            }
            else
            {
                maquina = string.Empty;
            }
        }

        private void cmbTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTurno.SelectedIndex != -1)
            {
                if (turno != cmbTurno.SelectedItem.ToString())
                {
                    turno = cmbTurno.SelectedItem.ToString();
                    lastChange = "turno";
                    populateDgv();
                }
            }
            else
            {
                turno = string.Empty;
            }
        }

        // Como el nombre lo indica es para limpiar todos los filtros.
        // los hace apuntar a blanco y le limpia el texto que contienen.

        private void btnlimpiarFiltros_Click(object sender, EventArgs e)
        {
            codigo = string.Empty;
            tipo = string.Empty;
            maquina = string.Empty;
            turno = string.Empty;

            getList();
            populateDgv();
            cmbCodigo.ResetText();
            cmbTipo.ResetText();
            cmbMaquina.ResetText();
            cmbTurno.ResetText();

            cmbCodigo.SelectedIndex = -1;
            cmbTipo.SelectedIndex = -1;
            cmbMaquina.SelectedIndex = -1;
            cmbTurno.SelectedIndex = -1;
         
        }

        private void cmbCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbCodigo.ResetText();
                codigo = string.Empty;
                lastChange = string.Empty;
                populateDgv();
            }
        }

        private void cmbTipo_KeyDown(object sender, KeyEventArgs e) // La variable e es la tecla que se aprieta.
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbTipo.ResetText();
                tipo = string.Empty;
                lastChange = string.Empty;
                populateDgv();
            }
        }

        private void cmbMaquina_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbMaquina.ResetText();
                maquina = string.Empty;
                lastChange = string.Empty;
                populateDgv();
            }
        }

        private void cmbTurno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbTurno.ResetText();
                turno = string.Empty;
                lastChange = string.Empty;
                populateDgv();
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            // supongo que aca pongo las columnas que voy a exportar al excel.
            string ext = string.Empty;
            dataGridView1.Columns["clmCodigo"].Visible = true;
            dataGridView1.Columns["clmTipo"].Visible = true;
            dataGridView1.Columns["clmMaquina"].Visible = true;
            dataGridView1.Columns["clmTurno"].Visible = true;
            dataGridView1.Columns["clmPeso"].Visible = true;
            dataGridView1.Columns["clmFecha"].Visible = true;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;

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
                dataGridView1.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }

            // Esto lo que hace es, luego de exportarlo te oculta las columnas que se exportaron.
            // false = no visible ---- true = se ve la columna
            dataGridView1.Columns["clmCodigo"].Visible = true;
            dataGridView1.Columns["clmTipo"].Visible = true;
            dataGridView1.Columns["clmMaquina"].Visible = true;
            dataGridView1.Columns["clmTurno"].Visible = true;
            dataGridView1.Columns["clmPeso"].Visible = true;
            dataGridView1.Columns["clmFecha"].Visible = true;
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

        private void txtPesos_Click(object sender, EventArgs e)
        {
            cmbCodigo.Focus();
        }
        
    }


}
