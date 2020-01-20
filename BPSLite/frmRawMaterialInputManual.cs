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
    public partial class frmRawMaterialInputManual : Form
    {
        // Aca dejo todas las Listas que necesito
        List<clsRawMaterial> listaRawMats = new List<clsRawMaterial>();
        List<clsCoilCellar> listaBodegasRaw = new List<clsCoilCellar>();
        List<clsCoilCellar> listaSilos = new List<clsCoilCellar>();

        //Aca todos los objetos que se van a usar a nivel global en el formulario
        clsRawMaterial rawMaterial = new clsRawMaterial();
        clsRawMaterial rawMaterialSilo = new clsRawMaterial();

        public frmRawMaterialInputManual()
        {
            InitializeComponent();

            listaRawMats = clsRawMaterial.getListRaw();
            listaBodegasRaw = clsCoilCellar.lstRawCellar();
            listaSilos = clsCoilCellar.lstSiloCellar();

            for (int i = 0; i < listaRawMats.Count; i++)
            {
                cmbCodPallet.Items.Add(listaRawMats[i].code);
                cmbCodSilo.Items.Add(listaRawMats[i].code);
            }

            for (int i = 0; i < listaBodegasRaw.Count; i++)
            {
                cmbBodegaPallets.Items.Add(listaBodegasRaw[i].name);
            }
            for (int i = 0; i < listaSilos.Count; i++)
            {
                cmbDestinoSilo.Items.Add(listaSilos[i].name);
            }
        }

        #region Solapa Pallets

        private void cmbCodPallet_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.rawMaterial = clsRawMaterial.getObjByCode(cmbCodPallet.SelectedItem.ToString());
            txtNomMatPallet.Text = rawMaterial.name;
            txtEmpresaPallet.Text = new clsEntity(rawMaterial.fkEntity).companyName;
            txtTipoMatPallet.Text = new clsRawMaterialtype(rawMaterial.fkRawMaterialtype).name;
            txtLotePallet.Focus();
        }

        private void btnCargarPallet_Click(object sender, EventArgs e)
        {

            clsPlant planta = new clsPlant();
            double pesoPallet = 0;
 
            if (clsGlobal.LoggedUser.fkRole == 1019 || clsGlobal.LoggedUser.fkRole == 1024 || clsGlobal.LoggedUser.codsec == 5164)
            {
                planta = new clsPlant(3);
            }
            else
            {
                planta = new clsPlant(4);
            }

            if ((txtCantidadPallet.Text != string.Empty) && (cmbBodegaPallets.SelectedIndex != -1) && (txtLotePallet.Text != string.Empty))
            {
                pesoPallet = Convert.ToDouble(txtCantidadPallet.Text) / Convert.ToInt32(txtPallets.Text);

                if (dgvRawMatPallet.Rows.Count == 0)
                {
                    for (int i = 0; i < Convert.ToInt32(txtPallets.Text); i++)
                    {

                        dgvRawMatPallet.Rows.Add();
                        dgvRawMatPallet.Rows[dgvRawMatPallet.Rows.Count - 1].Cells[clmCodigo.Index].Value = cmbCodPallet.SelectedItem.ToString();
                        dgvRawMatPallet.Rows[dgvRawMatPallet.Rows.Count - 1].Cells[clmCantidad.Index].Value = Math.Round(pesoPallet,2);
                        dgvRawMatPallet.Rows[dgvRawMatPallet.Rows.Count - 1].Cells[clmLote.Index].Value = txtLotePallet.Text.ToUpper();
                        dgvRawMatPallet.Rows[dgvRawMatPallet.Rows.Count - 1].Cells[clmEmpresa.Index].Value = txtEmpresaPallet.Text;
                        dgvRawMatPallet.Rows[dgvRawMatPallet.Rows.Count - 1].Cells[clmNotas.Index].Value = txtNotasPallet.Text;
                        dgvRawMatPallet.Rows[dgvRawMatPallet.Rows.Count - 1].Cells[clmBodDestino.Index].Value = cmbBodegaPallets.SelectedItem.ToString();
                        dgvRawMatPallet.Rows[dgvRawMatPallet.Rows.Count - 1].Cells[clmCodPallet.Index].Value = DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + planta.abr + "MP" + clsGlobal.FillWithZeros(((new clsSequential().rawPallet).ToString()), 5);
                        dgvRawMatPallet.Rows[dgvRawMatPallet.Rows.Count - 1].Cells[clmFechaPallet.Index].Value = DateTime.Now;

                        clsSequential.addSequential("rawPallet");

                    }
                    
                    cmbCodPallet.ResetText();
                    txtCantidadPallet.Text = string.Empty;
                    txtEmpresaPallet.Text = string.Empty;
                    txtPallets.Text = string.Empty;
                    txtNotasPallet.Text = string.Empty;
                    txtLotePallet.Text = string.Empty;
                    txtTipoMatPallet.Text = string.Empty;
                    txtNomMatPallet.Text = string.Empty;
                    cmbBodegaPallets.ResetText();
                    CalcularSubtotales();
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

        private void btnGuardarPallet_Click(object sender, EventArgs e)
        {
            int rawMaterialcodsec;
            clsCoilCellar bodegas = new clsCoilCellar();
            bool psave = false;
            bool psavePallet = false;

            for (int i = 0; i < dgvRawMatPallet.Rows.Count; i++)
            {
                clsRawMaterialPallet palletMateriaprima = new clsRawMaterialPallet();
                clsRawMaterialMovements movimientosRaw = new clsRawMaterialMovements();
                bodegas = clsCoilCellar.getCellarByName(Convert.ToString(dgvRawMatPallet.Rows[i].Cells[clmBodDestino.Index].Value));
                clsRawPalletByCoilCellar bodegaDestino = new clsRawPalletByCoilCellar();

                //Instancio cada pallet.

                palletMateriaprima.code = Convert.ToString(dgvRawMatPallet.Rows[i].Cells[clmCodPallet.Index].Value);
                rawMaterialcodsec = clsRawMaterial.getCodsecByCode(Convert.ToString(dgvRawMatPallet.Rows[i].Cells[clmCodigo.Index].Value));
                palletMateriaprima.fkRaw = rawMaterialcodsec;
                palletMateriaprima.netweigth = Convert.ToDouble(dgvRawMatPallet.Rows[i].Cells[clmCantidad.Index].Value);
                palletMateriaprima.lote = Convert.ToString(dgvRawMatPallet.Rows[i].Cells[clmLote.Index].Value);
                palletMateriaprima.fkStatus = 38;
                palletMateriaprima.fkUser = clsGlobal.LoggedUser.codsec;
                palletMateriaprima.date = DateTime.Now;
                palletMateriaprima.notes = Convert.ToString(dgvRawMatPallet.Rows[i].Cells[clmNotas.Index].Value);

                // Hasta aca termina la asignacion de los datos de cada pallet que se genera.

                // Aca se genera el movimiento del ingreso de pallet.
                psavePallet = palletMateriaprima.save();

                clsRawMaterialPallet palletRawMaterial = new clsRawMaterialPallet(Convert.ToString(dgvRawMatPallet.Rows[i].Cells[clmCodPallet.Index].Value));
                movimientosRaw.fkRaw = rawMaterialcodsec;
                movimientosRaw.type = "Ingreso de Materias Primas Manual";
                movimientosRaw.netWeigth = palletRawMaterial.netweigth;
                movimientosRaw.lote = Convert.ToString(dgvRawMatPallet.Rows[i].Cells[clmLote.Index].Value);
                movimientosRaw.fkRawPallet = palletRawMaterial.codsec;
                movimientosRaw.fkOrigCellar = bodegas.codsec;
                movimientosRaw.estrusionLote = "";
                movimientosRaw.fkDestCellar = bodegas.codsec;
                movimientosRaw.date = DateTime.Now;
                movimientosRaw.fkUser = clsGlobal.LoggedUser.codsec;

                psave = movimientosRaw.save();

                // Genero el destino del pallet

                bodegaDestino.fkCoilCellar = bodegas.codsec;
                bodegaDestino.fkRawPallet = palletRawMaterial.codsec;

                bodegaDestino.save();

                if ((psave == true) && psavePallet == true)
                {
                    if (clsGlobal.LoggedUser.fkRole == 2029 || clsGlobal.LoggedUser.fkRole == 2030 || clsGlobal.LoggedUser.fkRole == 2032)
                    {
                        clsPrintLabels.printRawLabelPL(palletRawMaterial.codsec);
                    }
                    else
                    {
                        clsPrintLabels.printRawLabel(palletRawMaterial.codsec);
                    }
                }

            }
            if ((psave == true) && (psavePallet == true))
            {
                MessageBox.Show("Los Datos se cargaron con exito", "¡Exito!", MessageBoxButtons.OK);
                dgvRawMatPallet.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Se produjo un error al cargar los datos, contacte con sistemas ante este inconveniente", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Solapa Silo
        private void cmbCodSilo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.rawMaterialSilo = clsRawMaterial.getObjByCode(cmbCodSilo.SelectedItem.ToString());
            txtNomSilo.Text = rawMaterialSilo.name;
            txtEmpresaSilo.Text = new clsEntity(rawMaterialSilo.fkEntity).companyName;
            cmbDestinoSilo.Focus();
        }

        private void btnCargarSilo_Click(object sender, EventArgs e)
        {
            if (txtCantidadSilo.Text != "" && cmbDestinoSilo.SelectedIndex != -1 && txtLoteSilo.Text != "")
            {
                if (dgvSilo.Rows.Count <= 0)
                {
                    dgvSilo.Rows.Add();
                    dgvSilo.Rows[dgvSilo.Rows.Count - 1].Cells[clmCodSilo.Index].Value = Convert.ToString(cmbCodSilo.SelectedItem.ToString());
                    dgvSilo.Rows[dgvSilo.Rows.Count - 1].Cells[clmCantidadSilo.Index].Value = txtCantidadSilo.Text;
                    dgvSilo.Rows[dgvSilo.Rows.Count - 1].Cells[clmLoteSilo.Index].Value = txtLoteSilo.Text.ToUpper();
                    dgvSilo.Rows[dgvSilo.Rows.Count - 1].Cells[clmEmpresaSilo.Index].Value = txtEmpresaSilo.Text;
                    dgvSilo.Rows[dgvSilo.Rows.Count - 1].Cells[clmNotaSilo.Index].Value = txtNotasSilo.Text;
                    dgvSilo.Rows[dgvSilo.Rows.Count - 1].Cells[clmSiloDestino.Index].Value = cmbDestinoSilo.SelectedItem.ToString();
                    dgvSilo.Rows[dgvSilo.Rows.Count - 1].Cells[clmFechaSilo.Index].Value = DateTime.Now;

                    cmbDestinoSilo.ResetText();
                    cmbCodSilo.ResetText();
                    txtCantidadSilo.Text = string.Empty;
                    txtEmpresaSilo.Text = string.Empty;
                    txtLoteSilo.Text = string.Empty;
                    txtNomSilo.Text = string.Empty;
                    txtNotasSilo.Text = string.Empty; 
                }
            }
        }

        private void btnGuardarSilo_Click(object sender, EventArgs e)
        {
            bool anduvo;

            clsRawMaterialMovements movimientoSilo = new clsRawMaterialMovements();
            clsCoilCellar siloCellar = new clsCoilCellar(dgvSilo.Rows[dgvSilo.Rows.Count - 1].Cells[clmSiloDestino.Index].Value.ToString());
            clsRawMaterialBySiloCellar SiloPapu = new clsRawMaterialBySiloCellar();
            rawMaterial = clsRawMaterial.getObjByCode(dgvSilo.Rows[dgvSilo.Rows.Count - 1].Cells[clmCodSilo.Index].Value.ToString());

            anduvo = SiloPapu.checkSiloItsGood(Convert.ToInt32(siloCellar.codsec), rawMaterial.codsec, rawMaterial.fkRawMaterialtype, dgvSilo.Rows[dgvSilo.Rows.Count - 1].Cells[clmLoteSilo.Index].Value.ToString(), Convert.ToDouble(dgvSilo.Rows[dgvSilo.Rows.Count - 1].Cells[clmCantidadSilo.Index].Value.ToString()));

            // Doy de alta el movimiento.

            movimientoSilo.fkRaw = rawMaterial.codsec;
            movimientoSilo.type = "Ingreso de Material al " + siloCellar.name.ToString();
            movimientoSilo.fkRawPallet = 0;
            movimientoSilo.lote = rawMaterial.lotNumber;
            movimientoSilo.netWeigth = Convert.ToDouble(dgvSilo.Rows[dgvSilo.Rows.Count - 1].Cells[clmCantidadSilo.Index].Value);
            movimientoSilo.estrusionLote = "";
            movimientoSilo.lote = Convert.ToString(dgvSilo.Rows[dgvSilo.Rows.Count - 1].Cells[clmLoteSilo.Index].Value);
            movimientoSilo.fkOrigCellar = siloCellar.codsec;
            movimientoSilo.fkDestCellar = siloCellar.codsec;
            movimientoSilo.fkUser = clsGlobal.LoggedUser.codsec;
            movimientoSilo.date = DateTime.Now;

            if (anduvo == true)
            {
                movimientoSilo.save();
                MessageBox.Show("Datos procesados correctamente", "¡Exito!", MessageBoxButtons.OK);
                dgvSilo.Rows.Clear();
            }
            else
            {
                MessageBox.Show("El Material que intenta ingresar, no se puede mezclar con el contenido del Silo.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                dgvSilo.Rows.Clear();
            }
        }
        #endregion

        #region Eventos Partes del Formulario
        private void txtCantidadSilo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar!=(char)Keys.Enter))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtLoteSilo.Focus();
            }
        }

        private void txtCantidadPallet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
            if(e.KeyChar == (char)Keys.Enter)
            {
                txtPallets.Focus();
            }
        }

        private void txtPallets_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                txtNotasPallet.Focus();
            }
        }
  

        private void txtLotePallet_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                cmbBodegaPallets.Focus();
            }
        }

        private void cmbBodegaPallets_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCantidadPallet.Focus();
        }

        private void cmbDestinoSilo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCantidadSilo.Focus();
        }

        private void txtLoteSilo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtNotasSilo.Focus();
            }
        }
        #endregion

        #region Subtotales
        private void CalcularSubtotales()
        {
            double pesos = 0;

            foreach (DataGridViewRow row in dgvRawMatPallet.Rows)
            {
                pesos = pesos + Convert.ToDouble(row.Cells[clmCantidad.Index].Value);
               
            }
            txtCantPallet.Text = dgvRawMatPallet.Rows.Count.ToString();
            txtPesoTot.Text = Math.Round(pesos, 2).ToString();
        }
        #endregion
    }
}
