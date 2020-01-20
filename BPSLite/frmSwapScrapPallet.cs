using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS.Lite
{
    public partial class frmSwapScrapPallet : Form
    {
        clsScrapMovements movimientos = new clsScrapMovements();
        clsScrapPalletByCoilCellar scrapPBCC = new clsScrapPalletByCoilCellar();
        clsScrapPallet palletScrap = new clsScrapPallet();

        public frmSwapScrapPallet()
        {
            InitializeComponent();
        }

        #region Carga de Swap ScrapPallet
        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            bool bandera = false;

            if (e.KeyCode == Keys.Enter)
            {
                if ((cmbDestino.Text != string.Empty) && (cmbOrigen.Text != string.Empty))
                {
                    if (txtCodigo.Text != string.Empty)
                    {
                        if (cmbOrigen.Text != cmbDestino.Text)
                        {
                            clsCoilCellar bodega = new clsCoilCellar(cmbOrigen.SelectedItem.ToString()); // el fk de la bodega
                            clsScrapPallet scrapPallet = new clsScrapPallet(txtCodigo.Text);
                            scrapPBCC = new clsScrapPalletByCoilCellar(scrapPallet.codsec); // Tiene el fkCoilCellar donde esta el pallet

                            if (bodega.codsec == scrapPBCC.fkCoilCellar) // Si coinciden es por que las se encuentra en esa bodega
                            {
                                if (scrapPallet.codsec != 0)
                                {
                                    if (scrapPallet.fkStatus == 38)
                                    {
                                        if (dgvPalletSwap.Rows.Count > 0)
                                        {
                                            foreach (DataGridViewRow row in dgvPalletSwap.Rows)
                                            {
                                                if (scrapPallet.codsec == Convert.ToInt32(row.Cells[clmCodsec.Index].Value))
                                                {
                                                    MessageBox.Show("Codigo ya ingresado. Por favor verifique la tabla", "¡Error!", MessageBoxButtons.OK);
                                                    bandera = true;
                                                }
                                            }

                                            if (bandera != true)
                                            {
                                                dgvPalletSwap.Rows.Add();
                                                dgvPalletSwap.Rows[dgvPalletSwap.Rows.Count - 1].Cells[clmCodsec.Index].Value = scrapPallet.codsec;
                                                dgvPalletSwap.Rows[dgvPalletSwap.Rows.Count - 1].Cells[clmCodigo.Index].Value = scrapPallet.code;
                                                dgvPalletSwap.Rows[dgvPalletSwap.Rows.Count - 1].Cells[clmTipo.Index].Value = scrapPallet.Scrap.name;
                                                dgvPalletSwap.Rows[dgvPalletSwap.Rows.Count - 1].Cells[clmMachine.Index].Value = scrapPallet.Machine.Cutter;
                                                dgvPalletSwap.Rows[dgvPalletSwap.Rows.Count - 1].Cells[clmPeso.Index].Value = scrapPallet.netWeigth;
                                                dgvPalletSwap.Rows[dgvPalletSwap.Rows.Count - 1].Cells[clmTurno.Index].Value = scrapPallet.turn;
                                                dgvPalletSwap.Rows[dgvPalletSwap.Rows.Count - 1].Cells[clmBodegaOrigen.Index].Value = cmbOrigen.Text;
                                                dgvPalletSwap.Rows[dgvPalletSwap.Rows.Count - 1].Cells[clmBodegaDestino.Index].Value = cmbDestino.Text;
                                                dgvPalletSwap.Rows[dgvPalletSwap.Rows.Count - 1].Cells[clmFecha.Index].Value = DateTime.Now;

                                                cmbDestino.ResetText();
                                                cmbOrigen.ResetText();
                                                txtCodigo.ResetText();
                                            }
                                        }
                                        else
                                        {
                                            dgvPalletSwap.Rows.Add();
                                            dgvPalletSwap.Rows[dgvPalletSwap.Rows.Count - 1].Cells[clmCodsec.Index].Value = scrapPallet.codsec;
                                            dgvPalletSwap.Rows[dgvPalletSwap.Rows.Count - 1].Cells[clmCodigo.Index].Value = scrapPallet.code;
                                            dgvPalletSwap.Rows[dgvPalletSwap.Rows.Count - 1].Cells[clmTipo.Index].Value = scrapPallet.Scrap.name;
                                            dgvPalletSwap.Rows[dgvPalletSwap.Rows.Count - 1].Cells[clmMachine.Index].Value = scrapPallet.Machine.Cutter;
                                            dgvPalletSwap.Rows[dgvPalletSwap.Rows.Count - 1].Cells[clmPeso.Index].Value = scrapPallet.netWeigth;
                                            dgvPalletSwap.Rows[dgvPalletSwap.Rows.Count - 1].Cells[clmTurno.Index].Value = scrapPallet.turn;
                                            dgvPalletSwap.Rows[dgvPalletSwap.Rows.Count - 1].Cells[clmBodegaOrigen.Index].Value = cmbOrigen.Text;
                                            dgvPalletSwap.Rows[dgvPalletSwap.Rows.Count - 1].Cells[clmBodegaDestino.Index].Value = cmbDestino.Text;
                                            dgvPalletSwap.Rows[dgvPalletSwap.Rows.Count - 1].Cells[clmFecha.Index].Value = DateTime.Now;

                                            cmbDestino.ResetText();
                                            cmbOrigen.ResetText();
                                            txtCodigo.ResetText();

                                        }
                                        calculodeSubtotalesOut();
                                    }
                                    else
                                    {
                                        MessageBox.Show("El pallet que intenta cargar debe de estar Activo para ingresarlo","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                        cmbDestino.ResetText();
                                        cmbOrigen.ResetText();
                                        txtCodigo.ResetText();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("El pallet que intenta cargar no existe o el codigo es erroneo", "¡Error!", MessageBoxButtons.OK);
                                    cmbDestino.ResetText();
                                    cmbOrigen.ResetText();
                                    txtCodigo.ResetText();
                                }
                            }
                            else
                            {
                                MessageBox.Show("El pallet que intenta ingresar no se encuentra en la bodega de Origen que selecciono", "¡Error!", MessageBoxButtons.OK);
                                cmbDestino.ResetText();
                                cmbOrigen.ResetText();
                                txtCodigo.ResetText();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Esta intentando hacer un swap a la misma bodega, por favor seleccione otra bodega de destino.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, complete el codigo de pallet", "¡Error!", MessageBoxButtons.OK);

                    }
                }
                else
                {
                    MessageBox.Show("Complete primero Bodega Origen y Bodega Destino", "¡Error!", MessageBoxButtons.OK);

                }
            }
        }

        private void dgvPalletSwap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmEliminar.Index)
            {
                dgvPalletSwap.Rows.RemoveAt(dgvPalletSwap.CurrentRow.Index);
                calculodeSubtotalesOut();
            }
        }
        #endregion  

        #region Proceso de Swap ScrapPallet
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (dgvPalletSwap.Rows.Count > 0)
            {
                for (int i = 0; i < dgvPalletSwap.Rows.Count; i++)
                {
                    palletScrap = new clsScrapPallet(Convert.ToString(dgvPalletSwap.Rows[i].Cells[clmCodigo.Index].Value));
                    scrapPBCC = new clsScrapPalletByCoilCellar(palletScrap.codsec);
                    clsCoilCellar bodegaNueva = new clsCoilCellar(Convert.ToString(dgvPalletSwap.Rows[i].Cells[clmBodegaDestino.Index].Value));

                    //Antes de cambiar la bodega nueva la guardo
                    movimientos.fkOriginalCellar = scrapPBCC.fkCoilCellar;
                    scrapPBCC.fkCoilCellar = bodegaNueva.codsec;
                    palletScrap.fkStatus = 3066;
                    movimientos.fkScrap = palletScrap.fkScrap;
                    movimientos.type = "Swap de Pallet de Scrap";
                    movimientos.fkScrapPallet = palletScrap.codsec;
                    movimientos.fkDestinationCellar = bodegaNueva.codsec;
                    movimientos.fkUser = clsGlobal.LoggedUser.codsec;
                    movimientos.date = DateTime.Now;
                    movimientos.netWeigth = Convert.ToDouble(dgvPalletSwap.Rows[i].Cells[clmPeso.Index].Value);

                    scrapPBCC.save();
                    movimientos.save();
                    palletScrap.save();

                }
            }
            else
            {
                MessageBox.Show("La tabla esta vacia", "Llenar Tabla", MessageBoxButtons.OK);
            }
            exportToExcel();
            dgvPalletSwap.Rows.Clear();
            MessageBox.Show("Datos Procesados Correctamente", "Confirmacion", MessageBoxButtons.OK);
            txtCodigo.Text = string.Empty;
            cmbDestino.ResetText();
            cmbOrigen.ResetText();

        }
        #endregion

        #region Autocarga del DgvIngresoScrapPallet
        private void populateDgvIngresoSwap()
        {
            DataSet DS = new DataSet();

            if (clsGlobal.LoggedUser.fkRole == 1019 || clsGlobal.LoggedUser.fkRole == 1024)
            {
                DS = clsConnection.getDataSetResult("CALL spScrapPalletInTransit (" + 3 + ")");
            }
            else
            {
                DS = clsConnection.getDataSetResult("CALL spScrapPalletInTransit(" + 4 + ")");
            }

            if (DS.Tables[0].Rows.Count > 0)
            {
                for(int i = 0; i<DS.Tables[0].Rows.Count ; i++)
                {
                    dgvIngresoScrapSwap.Rows.Add();
                    dgvIngresoScrapSwap.Rows[dgvIngresoScrapSwap.Rows.Count - 1].Cells[clmIngCodPallet.Index].Value = DS.Tables[0].Rows[i]["CodScrapPallet"].ToString();
                    dgvIngresoScrapSwap.Rows[dgvIngresoScrapSwap.Rows.Count - 1].Cells[clmIngCodScrap.Index].Value = DS.Tables[0].Rows[i]["CodScrap"].ToString();
                    dgvIngresoScrapSwap.Rows[dgvIngresoScrapSwap.Rows.Count - 1].Cells[clmIngNomScrap.Index].Value = DS.Tables[0].Rows[i]["NomScrap"].ToString();
                    dgvIngresoScrapSwap.Rows[dgvIngresoScrapSwap.Rows.Count - 1].Cells[clmIngPesoScrap.Index].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["PesoScrapPallet"]);
                    dgvIngresoScrapSwap.Rows[dgvIngresoScrapSwap.Rows.Count - 1].Cells[clmIngBdOrgScrap.Index].Value = DS.Tables[0].Rows[i]["BodegaOrig"].ToString();
                    dgvIngresoScrapSwap.Rows[dgvIngresoScrapSwap.Rows.Count - 1].Cells[clmBdDestinoScrap.Index].Value = DS.Tables[0].Rows[i]["BodegaDest"].ToString();
                    dgvIngresoScrapSwap.Rows[dgvIngresoScrapSwap.Rows.Count - 1].Cells[clmIngFechaScrap.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaScrapPallet"]);
                }
                calculodeSubtotalesIn();
            }
         }
        #endregion

        #region Aceptacion/Denegacion de ScrapPallets

        private void dgvIngresoScrapSwap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bool anduvobodega = false;

            if (e.ColumnIndex == clmAceptScrap.Index)
            {
                clsCoilCellar bodega = new clsCoilCellar(dgvIngresoScrapSwap.CurrentRow.Cells[clmBdDestinoScrap.Index].Value.ToString());
                palletScrap = new clsScrapPallet(dgvIngresoScrapSwap.CurrentRow.Cells[clmIngCodPallet.Index].Value.ToString());

                anduvobodega = clsScrapPallet.setFkCoilcellarNew(palletScrap.codsec, bodega.codsec);

                palletScrap.fkStatus = 38;

                palletScrap.save();
                dgvIngresoScrapSwap.Rows.RemoveAt(dgvIngresoScrapSwap.CurrentRow.Index);
            }
            else if (e.ColumnIndex == clmDenyScrap.Index)
            {
                clsCoilCellar bodegaOrg = new clsCoilCellar(dgvIngresoScrapSwap.CurrentRow.Cells[clmIngBdOrgScrap.Index].Value.ToString());
                palletScrap = new clsScrapPallet(dgvIngresoScrapSwap.CurrentRow.Cells[clmIngCodPallet.Index].Value.ToString());
                clsCoilCellar bodegaDestino = new clsCoilCellar(dgvIngresoScrapSwap.CurrentRow.Cells[clmBdDestinoScrap.Index].Value.ToString());

                anduvobodega = clsScrapPallet.setFkCoilcellarNew(palletScrap.codsec, bodegaOrg.codsec);

                var dialogResult = MessageBox.Show("a.BOTON SI: Seleccione este boton si, el pallet no llego.\nb.BOTON NO: Seleccione este boton si, el pallet no llego en condiciones.\nc.Si no es ninguna de las opciones anteriores, presione CANCEL.", "¡Advertencia!", MessageBoxButtons.YesNoCancel);

                switch (dialogResult)
                {
                    case DialogResult.Yes:
                        palletScrap.fkStatus = 38;
                        movimientos.fkScrap = palletScrap.fkScrap;
                        movimientos.fkOriginalCellar = bodegaOrg.codsec;
                        movimientos.type = "No llegó Pallet de Scrap";
                        movimientos.fkScrapPallet = palletScrap.codsec;
                        movimientos.fkDestinationCellar = bodegaDestino.codsec;
                        movimientos.fkUser = clsGlobal.LoggedUser.codsec;
                        movimientos.date = DateTime.Now;
                        movimientos.netWeigth = -1 * Convert.ToDouble(dgvIngresoScrapSwap.CurrentRow.Cells[clmIngPesoScrap.Index].Value);
                        
                        if (anduvobodega == true && palletScrap.save() && movimientos.save()) // Chequeo si se guardó todo correctamente.
                        {
                            dgvIngresoScrapSwap.Rows.RemoveAt(dgvIngresoScrapSwap.CurrentRow.Index);
                        }
                        else
                        {
                            MessageBox.Show("No se generó el rechazo, por favor contacte con el Administrador del sistema", "Inconveniente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;

                    case DialogResult.No:

                        palletScrap.fkStatus = 3066;
                        // Doy de alta el movimiento en scrapmovements.
                        movimientos.fkOriginalCellar = bodegaDestino.codsec;
                        movimientos.fkScrap = palletScrap.fkScrap;
                        movimientos.type = "Rechazo Swap de Pallet de Scrap por desperfecto";
                        movimientos.fkScrapPallet = palletScrap.codsec;
                        movimientos.fkDestinationCellar = bodegaOrg.codsec;
                        movimientos.fkUser = clsGlobal.LoggedUser.codsec;
                        movimientos.date = DateTime.Now;
                        movimientos.netWeigth = -1 * Convert.ToDouble(dgvIngresoScrapSwap.CurrentRow.Cells[clmIngPesoScrap.Index].Value);

                        if (anduvobodega == true && palletScrap.save() && movimientos.save()) // Chequeo si se guardó todo correctamente.

                        {
                            dgvIngresoScrapSwap.Rows.RemoveAt(dgvIngresoScrapSwap.CurrentRow.Index);
                        }
                        else
                        {
                            MessageBox.Show("No se generó el rechazo, por favor contacte con el Administrador del sistema", "Inconveniente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        
                        break;

                    case DialogResult.Cancel:
                        palletScrap.save();
                        break;
                }
            }
            calculodeSubtotalesIn();
        }

        #endregion

        #region Eventos de elementos del formulario
        private void frmScrapSwap_Load(object sender, EventArgs e)
        {
            cargarCombos();
            //cmbOrigen.Items.Remove(cmbOrigen.Items[2]);
            //cmbOrigen.Items.Remove(cmbOrigen.Items[2]);
            populateDgvIngresoSwap();
        }

        private void cmbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrigen.Text != string.Empty)
            {
                cmbDestino.Enabled = true;
                cmbDestino.Items.Clear();
                cargarCombos();

            }
            else
            {
                cmbDestino.Enabled = false;
            }
        }

        private void cmbOrigen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbOrigen.ResetText();
                cmbDestino.ResetText();
                cmbDestino.SelectedIndex = -1;
                cmbOrigen.SelectedIndex = -1;

            }
        }

        private void cmbDestino_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbDestino.ResetText();
                cmbDestino.SelectedIndex = -1;

            }
        }

        private void cargarCombos()
        {
            List<clsCoilCellar> bodegas = new List<clsCoilCellar>();
            List<clsCoilCellar> bodegasNew = new List<clsCoilCellar>();

            if (clsGlobal.LoggedUser.fkRole == 1019 || clsGlobal.LoggedUser.fkRole == 1024 || clsGlobal.LoggedUser.fkRole == 11 || clsGlobal.LoggedUser.fkRole == 1)
            {
                bodegas = clsCoilCellar.lstCellarScrap(3);
                bodegasNew = clsCoilCellar.lstCellarScrap(4);
            }
            else
            {
                bodegas = clsCoilCellar.lstCellarScrap(4);
                bodegasNew = clsCoilCellar.lstCellarScrap(3);
            }

            if (cmbOrigen.Text == string.Empty)
            {
                for (int i = 0; i < bodegas.Count; i++)
                {
                    cmbOrigen.Items.Add(bodegas[i]);
                }

                for (int j = 0; j < bodegasNew.Count; j++)
                {
                    cmbDestino.Items.Add(bodegasNew[j]);
                }

                    cmbDestino.Enabled = false;
            }
            else
            {
                for (int i = 0; i < bodegasNew.Count; i++)
                {
                    cmbDestino.Items.Add(bodegasNew[i]);
                }
            }
        }

        #endregion

        #region Exportar a Excel
        private void exportToExcel()
        {
            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
                worksheet.Name = "Swap de Pallet de Scrap";

                for (int i = 2; i < dgvPalletSwap.Columns.Count + 1; i++)
                    worksheet.Cells[1, i - 1] = dgvPalletSwap.Columns[i - 1].HeaderText;

                for (int i = 0; i < dgvPalletSwap.Rows.Count; i++)
                {
                    for (int j = 1; j < dgvPalletSwap.Columns.Count - 1; j++)
                    {
                        if (dgvPalletSwap.Rows[i].Cells[j].Value != null)
                            worksheet.Cells[i + 2, j] = dgvPalletSwap.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Swap de Pallet de Scrap", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Calculo de Subtotales
        private void calculodeSubtotalesOut()
        {
            double pesos = 0;

            foreach (DataGridViewRow row in dgvPalletSwap.Rows)
            {
                pesos = pesos + Convert.ToDouble(row.Cells[clmPeso.Index].Value);
            }
            txtPalletTotOut.Text = dgvPalletSwap.Rows.Count.ToString();
            txtTotKgOut.Text = Math.Round(pesos, 2).ToString();
        }

        private void calculodeSubtotalesIn()
        {
            double pesos = 0;

            foreach (DataGridViewRow row in dgvIngresoScrapSwap.Rows)
            {
                pesos = pesos + Convert.ToDouble(row.Cells[clmIngPesoScrap.Index].Value);
            }
            txtTotPalletIn.Text = dgvIngresoScrapSwap.Rows.Count.ToString();
            txtTotKgIn.Text = Math.Round(pesos, 2).ToString();
        }
        #endregion

    }
}
