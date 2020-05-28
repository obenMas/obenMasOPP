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
    public partial class frmImportRawMaterial : Form
    {
        List<clsCoilCellar> bodegas = new List<clsCoilCellar>();
        string referencia;

        public frmImportRawMaterial(string Codigo, string Cantidad, string partida, string proveedor, string nombreEmp, string refe)
        {
            InitializeComponent();
            txtCodigo.Text = Codigo;
            txtCantidad.Text = Convert.ToString(Cantidad);
            txtPartidas.Text = partida;
            txtProveedor.Text = Convert.ToString(proveedor);
            txtEmpresa.Text = nombreEmp;

            bodegas = clsCoilCellar.lstRawCellar();

            for (int i = 0; i < bodegas.Count; i++)
            {
                if(bodegas[i].isReception==1)
                cmbBodegas.Items.Add(bodegas[i]);
            }

            referencia = refe;
        }

        #region Importar Todas las materias primas
        private void btnCargar_Click(object sender, EventArgs e)
        {
            double pesoPallet = 0;
            clsPlant planta = new clsPlant();
          
            if (clsGlobal.LoggedUser.fkRole == 1019 || clsGlobal.LoggedUser.fkRole == 1024 || clsGlobal.LoggedUser.codsec == 5164)
            {
                planta = new clsPlant(3);
            }
            else
            {
                planta = new clsPlant(4);
            }

            pesoPallet = Convert.ToDouble(txtCantidad.Text) / Convert.ToInt32(txtPallets.Text);

            if ((txtCantidad.Text != string.Empty) && (cmbBodegas.SelectedIndex != -1) && (txtLote.Text != string.Empty))
            {
                if (dgvImportRawMat.Rows.Count == 0)
                {
                    for (int i = 0; i < Convert.ToInt32(txtPallets.Text); i++)
                    {

                        dgvImportRawMat.Rows.Add();
                        dgvImportRawMat.Rows[dgvImportRawMat.Rows.Count - 1].Cells[clmCodigo.Index].Value = txtCodigo.Text;
                        dgvImportRawMat.Rows[dgvImportRawMat.Rows.Count - 1].Cells[clmCantidad.Index].Value = Math.Round(pesoPallet,2);
                        dgvImportRawMat.Rows[dgvImportRawMat.Rows.Count - 1].Cells[clmLote.Index].Value = txtLote.Text.ToUpper();
                        dgvImportRawMat.Rows[dgvImportRawMat.Rows.Count - 1].Cells[clmEmpresa.Index].Value = txtEmpresa.Text;
                        dgvImportRawMat.Rows[dgvImportRawMat.Rows.Count - 1].Cells[clmNotas.Index].Value = txtNotas.Text;
                        dgvImportRawMat.Rows[dgvImportRawMat.Rows.Count - 1].Cells[clmBodega.Index].Value = cmbBodegas.Text;
                        dgvImportRawMat.Rows[dgvImportRawMat.Rows.Count - 1].Cells[clmProveedor.Index].Value = txtProveedor.Text;
                        dgvImportRawMat.Rows[dgvImportRawMat.Rows.Count - 1].Cells[clmPartidas.Index].Value = txtPartidas.Text;
                        dgvImportRawMat.Rows[dgvImportRawMat.Rows.Count - 1].Cells[clmCodigoPallet.Index].Value = DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + "R" + DateTime.Now.ToString("hh") + DateTime.Now.ToString("mm") + DateTime.Now.ToString("ss") + clsGlobal.FillWithZeros(i.ToString(),2);

                    }

                    txtCodigo.Text = string.Empty;
                    txtCantidad.Text = string.Empty;
                    txtEmpresa.Text = string.Empty;
                    txtPallets.Text = string.Empty;
                    txtNotas.Text = string.Empty;
                    txtProveedor.Text = string.Empty;
                    txtPartidas.Text = string.Empty;
                    txtLote.Text = string.Empty;
                    cmbBodegas.ResetText();

                    calculoSubtotales();
                }
                else
                {
                    MessageBox.Show("El pallet que intenta cargar ya se encuentra cargado","¡Materia Prima!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Por favor complete los campos en blanco", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion

        #region Procesar importación

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int rawMaterialcodsec;
            clsCoilCellar bodegas = new clsCoilCellar();
            bool psave = false;
            bool psavePallet = false;

            bodegas = clsCoilCellar.getCellarByName(Convert.ToString(dgvImportRawMat.Rows[0].Cells[clmBodega.Index].Value));
            rawMaterialcodsec = clsRawMaterial.getCodsecByCode(Convert.ToString(dgvImportRawMat.Rows[0].Cells[clmCodigo.Index].Value));

            for (int i = 0; i < dgvImportRawMat.Rows.Count; i++)
            {
                clsRawMaterialPallet palletMateriaprima = new clsRawMaterialPallet();
                clsRawMaterialMovements movimientosRaw = new clsRawMaterialMovements();
                
                clsRawPalletByCoilCellar bodegaDestino = new clsRawPalletByCoilCellar();

                //Instancio cada pallet.

                palletMateriaprima.code = Convert.ToString(dgvImportRawMat.Rows[i].Cells[clmCodigoPallet.Index].Value);
                
                palletMateriaprima.fkRaw = rawMaterialcodsec;
                palletMateriaprima.netweigth = Convert.ToDouble(dgvImportRawMat.Rows[i].Cells[clmCantidad.Index].Value);
                palletMateriaprima.lote = Convert.ToString(dgvImportRawMat.Rows[i].Cells[clmLote.Index].Value);
                palletMateriaprima.fkStatus = 38;
                palletMateriaprima.fkUser = clsGlobal.LoggedUser.codsec;
                palletMateriaprima.date = DateTime.Now;
                palletMateriaprima.notes = Convert.ToString(dgvImportRawMat.Rows[i].Cells[clmNotas.Index].Value);

                // Hasta aca termina la asignacion de los datos de cada pallet que se genera.

                // Aca se genera el movimiento del ingreso de pallet.
                psavePallet = palletMateriaprima.save();

                //clsRawMaterialPallet palletRawMaterial = new clsRawMaterialPallet(Convert.ToString(dgvImportRawMat.Rows[i].Cells[clmCodigoPallet.Index].Value));
                movimientosRaw.fkRaw = rawMaterialcodsec;
                movimientosRaw.type = "Ingreso de Materias Primas por interfaz Presea";
                movimientosRaw.netWeigth = Convert.ToDouble(dgvImportRawMat.Rows[i].Cells[clmCantidad.Index].Value);
                movimientosRaw.lote = Convert.ToString(dgvImportRawMat.Rows[i].Cells[clmLote.Index].Value);
                movimientosRaw.fkRawPallet = clsRawMaterialPallet.getCodsecByCode(Convert.ToString(dgvImportRawMat.Rows[i].Cells[clmCodigoPallet.Index].Value));
                movimientosRaw.fkOrigCellar = bodegas.codsec;
                movimientosRaw.estrusionLote = "";
                movimientosRaw.fkDestCellar = bodegas.codsec;
                movimientosRaw.date = DateTime.Now;
                movimientosRaw.fkUser = clsGlobal.LoggedUser.codsec;

                psave = movimientosRaw.save();

                // Genero el destino del pallet

                bodegaDestino.fkCoilCellar = bodegas.codsec;
                bodegaDestino.fkRawPallet = movimientosRaw.fkRawPallet;

                bodegaDestino.save();

                // transaccion
                clsTransactions.addPreseaReception(Convert.ToString(dgvImportRawMat.Rows[0].Cells[clmCodigo.Index].Value), palletMateriaprima.code, palletMateriaprima.lote, bodegas.codsec, palletMateriaprima.netweigth,referencia);

                if ((psave == true) && psavePallet == true)
                {
                    if (clsGlobal.LoggedUser.fkRole == 2029 || clsGlobal.LoggedUser.fkRole == 2030 || clsGlobal.LoggedUser.fkRole == 2032)
                    {
                        clsPrintLabels.printRawLabelPL(movimientosRaw.fkRawPallet);
                    }
                    else
                    {
                        clsPrintLabels.printRawLabel(movimientosRaw.fkRawPallet);
                    }
                }

            }
            if ((psave == true) && (psavePallet == true))
            {
                MessageBox.Show("Los Datos se cargaron con exito", "¡Exito!", MessageBoxButtons.OK);
                dgvImportRawMat.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Se produjo un error al cargar los datos, contacte con sistemas ante este inconveniente", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Subtotales

        private void calculoSubtotales()
        {
            double pesos = 0;

            foreach (DataGridViewRow row in dgvImportRawMat.Rows)
            {
                pesos = pesos + Convert.ToDouble(row.Cells[clmCantidad.Index].Value);
               
            }

            txtCantidadPallet.Text = dgvImportRawMat.Rows.Count.ToString();
            txtPeso.Text = Math.Round(pesos, 2).ToString();

        }

        #endregion
    }
}
