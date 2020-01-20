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

namespace BPS.Lite
{
    public partial class frmMillMaterialSend : Form
    {
        clsScrapPallet pallet = new clsScrapPallet();
        // Esto se usara en la segunda solapa. 
        clsScrapByExtruderCellar scrapCellar = new clsScrapByExtruderCellar();
        clsScrapPalletByCoilCellar scrapCoilCellar = new clsScrapPalletByCoilCellar();
        clsCoil coil = new clsCoil();
        clsScrap Scrap = new clsScrap();
        clsMainCoil mainCoil = new clsMainCoil();
       
        public frmMillMaterialSend()
        {
            InitializeComponent();
        }

        private void frmMillMaterialSend_Load(object sender, EventArgs e)
        {

            List<clsScrap> listaScrap = new List<clsScrap>();

            listaScrap = clsScrap.getList();

            for (int i = 0; i < listaScrap.Count; i++)
            {
                cmbTProducto.Items.Add(listaScrap[i].name);
                cmbTMerma.Items.Add(listaScrap[i].name);
            }

        }

        #region Pallets Scrap

        private void txtPalletCode_KeyDown(object sender, KeyEventArgs e)
        {
            bool bandera = false;

            if (e.KeyCode == Keys.Enter)
            {
                if (txtPalletCode.Text != "")
                {
                    clsScrapPallet pallet = new clsScrapPallet(txtPalletCode.Text);
                    if (pallet.codsec != 0) // Verifico que le pallet esté.
                    {
                        if (pallet.fkStatus == 38) // Verifico que el estado sea activo.
                        {
                            if (dgvPalletScrap.Rows.Count > 0)
                            {

                                foreach (DataGridViewRow row in dgvPalletScrap.Rows)
                                {
                                    if (pallet.codsec == Convert.ToInt32(row.Cells["clmCodsec"].Value))
                                    {
                                        MessageBox.Show("El pallet que intenta cargar ya fue cargado", "¡Error!", MessageBoxButtons.OK);
                                        txtPalletCode.ResetText();
                                        bandera = true;
                                    }
                                }

                                if (bandera != true)
                                {
                                    dgvPalletScrap.Rows.Add();
                                    dgvPalletScrap.Rows[dgvPalletScrap.Rows.Count - 1].Cells[clmCodsec.Index].Value = pallet.codsec;
                                    dgvPalletScrap.Rows[dgvPalletScrap.Rows.Count - 1].Cells[clmCodigo.Index].Value = pallet.code;
                                    dgvPalletScrap.Rows[dgvPalletScrap.Rows.Count - 1].Cells[clmTipo.Index].Value = pallet.Scrap.name;
                                    dgvPalletScrap.Rows[dgvPalletScrap.Rows.Count - 1].Cells[clmMaquina.Index].Value = pallet.Machine.Cutter.name;
                                    dgvPalletScrap.Rows[dgvPalletScrap.Rows.Count - 1].Cells[clmTurno.Index].Value = pallet.turn;
                                    dgvPalletScrap.Rows[dgvPalletScrap.Rows.Count - 1].Cells[clmPeso.Index].Value = Math.Round(pallet.netWeigth,2);
                                    dgvPalletScrap.Rows[dgvPalletScrap.Rows.Count - 1].Cells[clmFecha.Index].Value = pallet.date;

                                    txtPalletCode.ResetText();

                                }

                            }
                            else
                            {
                                dgvPalletScrap.Rows.Add();
                                dgvPalletScrap.Rows[dgvPalletScrap.Rows.Count - 1].Cells[clmCodsec.Index].Value = pallet.codsec;
                                dgvPalletScrap.Rows[dgvPalletScrap.Rows.Count - 1].Cells[clmCodigo.Index].Value = pallet.code;
                                dgvPalletScrap.Rows[dgvPalletScrap.Rows.Count - 1].Cells[clmTipo.Index].Value = pallet.Scrap.name;
                                dgvPalletScrap.Rows[dgvPalletScrap.Rows.Count - 1].Cells[clmMaquina.Index].Value = pallet.Machine.Cutter.name;
                                dgvPalletScrap.Rows[dgvPalletScrap.Rows.Count - 1].Cells[clmTurno.Index].Value = pallet.turn;
                                dgvPalletScrap.Rows[dgvPalletScrap.Rows.Count - 1].Cells[clmPeso.Index].Value = Math.Round(pallet.netWeigth);
                                dgvPalletScrap.Rows[dgvPalletScrap.Rows.Count - 1].Cells[clmFecha.Index].Value = pallet.date;

                                txtPalletCode.ResetText();
                            }
                        }
                        else
                        {
                            MessageBox.Show("El pallet que intenta enviar, está dado de baja", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El pallet que intenta cargar no existe o el codigo es erroneo", "¡Error!", MessageBoxButtons.OK);
                        txtPalletCode.ResetText();
                    }

                }
                else
                {
                    MessageBox.Show("Por favor complete el codigo de palllet.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        

        
        private void btnGuardarScrap_Click(object sender, EventArgs e)
        {
            if (dgvPalletScrap.Rows.Count == 0)
            {
                MessageBox.Show("La tabla esta vacia", "Llenar Tabla", MessageBoxButtons.OK);
            }
            else
            {
                for (int i = 0; i < dgvPalletScrap.Rows.Count; i++)
                {
                // Recorro cada uno de los registros, de la tabla para ir cambiandole de estado. ("doy de baja pallet")
                pallet = new clsScrapPallet(Convert.ToInt32(dgvPalletScrap.Rows[i].Cells[clmCodsec.Index].Value));
                pallet.delete(); // Este es el metodo que updatea el status.
                // Hasta aca estamos bien
                if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)
                {
                    scrapCellar = new clsScrapByExtruderCellar(pallet.fkScrap, 4022); //instancio un objeto de esta clase.
                    //scrapCellar.acuWeigth(pallet.netWeigth); // Ejecuto el metodo para que se aumente el peso.
                }
                else
                {
                    scrapCellar = new clsScrapByExtruderCellar(pallet.fkScrap, 4023); //instancio un objeto de esta clase.
                    //scrapCellar.acuWeigth(pallet.netWeigth); // Ejecuto el metodo para que se aumente el peso. Lo dejamos comentado por el momento
                    //Para no tener problemas con la bodega de estrusion.
                }

           
                clsScrapMovements movimientos = new clsScrapMovements();
                clsScrapPalletByCoilCellar scpbCoilCellar = new clsScrapPalletByCoilCellar();
                scpbCoilCellar = new clsScrapPalletByCoilCellar(pallet.codsec);
                

                movimientos.fkScrap = pallet.fkScrap;
                movimientos.type = "Movimiento de pallet";
                movimientos.fkOriginalCellar = scpbCoilCellar.fkCoilCellar;
                movimientos.fkScrapPallet = pallet.codsec;
                movimientos.fkUser = clsGlobal.LoggedUser.codsec;
                movimientos.netWeigth = pallet.netWeigth;

                if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)
                {
                    movimientos.fkDestinationCellar = 4022;
                }
                else
                {
                    movimientos.fkDestinationCellar = 4023;
                }
                movimientos.save();

            }
                dgvPalletScrap.Rows.Clear();
                MessageBox.Show("Datos Procesados Correctamente", "Confirmacion", MessageBoxButtons.OK);
            }
        }

        #endregion

        #region Envío de Bobinas.

        // Carga del coil Hay campos que no se estan cargando.
        private void txtCoilCode_KeyDown(object sender, KeyEventArgs e)
        {
            double netlengthC, netweigthC, usedlengthC, usedweigthC, currentweigthC;
            bool bandera = false;

            if (e.KeyCode == Keys.Enter)
            {
                if (txtCoilCode.Text != string.Empty)
                {
                    if (cmbTProducto.Text != string.Empty)
                    {
                        clsCoil coil = new clsCoil();
                        coil = clsCoil.getDetailByCode(txtCoilCode.Text);
      
                        usedlengthC = coil.getUsedLength(coil.codsec);
                        netlengthC = coil.length;
                        netweigthC = coil.netWeight;
                        usedweigthC = 0;
                        currentweigthC = 0;

                        usedweigthC = ((usedlengthC * netweigthC) / netlengthC);

                        currentweigthC = netweigthC - usedweigthC;
                  
                       if (coil.codsec != 0)
                            {
                                if (coil.fkStatus == 33)// Verifico si la bobina esta activa
                                {
                                    if (currentweigthC >= 0)
                                    {
                                        if (dgvScrapCoil.Rows.Count > 0) // Chequeo que no sea vacio el dgv.
                                        {
                                            foreach (DataGridViewRow row in dgvScrapCoil.Rows)
                                            {
                                                if (coil.code == row.Cells[clmCoilCode.Index].Value)
                                                {
                                                    MessageBox.Show("Código de bobina ya ingresada. Por favor verifique la tabla", "¡Error!", MessageBoxButtons.OK);
                                                    bandera = true;
                                                }    
                                            }

                                            if(bandera != true) // Hago esta verificacion por que se estaban cargando codigo por duplicado.
                                            {
                                                    dgvScrapCoil.Rows.Add();
                                                    dgvScrapCoil.Rows[dgvScrapCoil.Rows.Count - 1].Cells[clmCoilCodsec.Index].Value = coil.codsec;
                                                    dgvScrapCoil.Rows[dgvScrapCoil.Rows.Count - 1].Cells[clmCoilCode.Index].Value = coil.code;
                                                    dgvScrapCoil.Rows[dgvScrapCoil.Rows.Count - 1].Cells[clmProducto.Index].Value = cmbTProducto.Text;
                                                    dgvScrapCoil.Rows[dgvScrapCoil.Rows.Count - 1].Cells[clmNetWeigth.Index].Value = Math.Round(currentweigthC,2);
                                                    dgvScrapCoil.Rows[dgvScrapCoil.Rows.Count - 1].Cells[clmfkCoilCellar.Index].Value = coil.fkCoilCellar; // lo mismo de esto.
                                                    dgvScrapCoil.Rows[dgvScrapCoil.Rows.Count - 1].Cells[clmCoilDate.Index].Value = Convert.ToString(DateTime.Now); //Fecha que se carga.

                                                    txtCoilCode.ResetText();
                                                    cmbTProducto.ResetText();
                                                    
                                            }
                                        }
                                        // En teoria esto seria para que agregue el pale que ingreso a mano.
                                        else
                                        {
                                            dgvScrapCoil.Rows.Add();
                                            dgvScrapCoil.Rows[dgvScrapCoil.Rows.Count - 1].Cells[clmCoilCodsec.Index].Value = coil.codsec;
                                            dgvScrapCoil.Rows[dgvScrapCoil.Rows.Count - 1].Cells[clmCoilCode.Index].Value = coil.code;
                                            dgvScrapCoil.Rows[dgvScrapCoil.Rows.Count - 1].Cells[clmProducto.Index].Value = cmbTProducto.Text;
                                            dgvScrapCoil.Rows[dgvScrapCoil.Rows.Count - 1].Cells[clmNetWeigth.Index].Value = Math.Round(currentweigthC,2);
                                            dgvScrapCoil.Rows[dgvScrapCoil.Rows.Count - 1].Cells[clmfkCoilCellar.Index].Value = coil.fkCoilCellar; // lo mismo de esto.
                                            dgvScrapCoil.Rows[dgvScrapCoil.Rows.Count - 1].Cells[clmCoilDate.Index].Value = Convert.ToString(DateTime.Now); //Fecha que se carga.

                                            txtCoilCode.ResetText();
                                            cmbTProducto.ResetText();
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show("La bobina que intenta agregar ya se consumió por completo.", "¡Error!", MessageBoxButtons.OK);

                                        txtCoilCode.ResetText();
                                        cmbTProducto.ResetText();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("La bobina que intenta agregar ya esta dada de baja", "Error", MessageBoxButtons.OK);
                                    txtCoilCode.ResetText();
                                    cmbTProducto.ResetText();
                                }
                        }
                        else
                        {
                            MessageBox.Show("La bobina que intenta agregar es inexistente o el codigo es erroneo", "Error", MessageBoxButtons.OK);
                            txtCoilCode.ResetText();
                            cmbTProducto.ResetText();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Complete el tipo de merma que desea Cargar", "¡Error!", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Complete el Codigo de Bobina", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < dgvScrapCoil.Rows.Count; i++)
            {
                // Recorro cada uno de los registros, de la tabla para ir cambiandole de estado. ("doy de baja pallet")
                Scrap = new clsScrap(dgvScrapCoil.Rows[i].Cells[clmProducto.Index].Value.ToString());
                coil = new clsCoil(Convert.ToInt32(dgvScrapCoil.Rows[i].Cells[clmCodsec.Index].Value));
                coil.delete(); // Este es el metodo que updatea el status.
                
                if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)
                {
                    scrapCellar = new clsScrapByExtruderCellar(Scrap.codsec, 4022); 
                    //scrapCellar.acuWeigth(coil.netWeight);  De igual manera estos dos, todavia no esta contemplado la bodega de estrusion
                }
                else
                {
                    scrapCellar = new clsScrapByExtruderCellar(Scrap.codsec, 4023); 
                    //scrapCellar.acuWeigth(coil.netWeight); 

                }

                clsScrapMovements movimientos = new clsScrapMovements();
        
               

                movimientos.fkScrap = Convert.ToInt32(Scrap.codsec); //Preguntar si es este, por que is es otra vez el codsec hay datos dupli
                movimientos.type = "Movimiento de Bobina";
                movimientos.fkOriginalCellar = coil.coilCellarContainer.codsec;
                movimientos.fkCoil = coil.codsec;
                movimientos.fkUser = clsGlobal.LoggedUser.codsec;
                movimientos.netWeigth = Convert.ToDouble(dgvScrapCoil.Rows[i].Cells[clmNetWeigth.Index].Value);

                if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)
                {
                    movimientos.fkDestinationCellar = 4022;
                }
                else
                {
                    movimientos.fkDestinationCellar = 4023;
                }
                movimientos.save();

            }

            if (dgvScrapCoil.Rows.Count == 0)
            {
                MessageBox.Show("La tabla esta vacia", "Llenar Tabla", MessageBoxButtons.OK);
            }
            else 
            { 
            dgvScrapCoil.Rows.Clear();
            MessageBox.Show("Datos Procesados Correctamente", "Confirmacion", MessageBoxButtons.OK);
            }
        }

        #endregion

        #region Scrap Bobinas Madres.

        private void cmbTProducto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCoilCode.Focus();
                SendKeys.Send("{ENTER}");
            }
        }

        private void txtBobinaMadre_KeyDown(object sender, KeyEventArgs e)
        {
            double netlength, netweigth, usedlength, usedweigth, currentweigth;
            bool bandera = false;

            if (e.KeyCode == Keys.Enter)
            {
                if (cmbTMerma.Text != string.Empty)
                {
                    if (txtBobinaMadre.Text != string.Empty)
                    {
                        clsMainCoil mainCoil = new clsMainCoil(txtBobinaMadre.Text);

                        netlength = mainCoil.netlength;
                        netweigth = mainCoil.netWeigth;
                        usedlength = mainCoil.usedLength;
                        usedweigth = 0;
                        currentweigth = 0;

                        usedweigth = ((usedlength * netweigth) / netlength);
                        
                        currentweigth = netweigth - usedweigth;

                        if (mainCoil.codsec != 0)
                        {
                            if (mainCoil.fkStatus == 50) // Preguntar estado de bobinas madres.
                            {
                                if (currentweigth > 0)
                                {
                                    if (dgvBobinaMadre.Rows.Count > 0)
                                    {
                                        foreach (DataGridViewRow row in dgvBobinaMadre.Rows)
                                        {
                                            if (mainCoil.code == row.Cells[clmMCCodigo.Index].Value.ToString())
                                            {
                                                MessageBox.Show("El codigo que intenta ingresar ya se encuentra Cargado", "¡Error!", MessageBoxButtons.OK);
                                                bandera = true;
                                            }
                                        }

                                        if (bandera != true)
                                        {
                                            dgvBobinaMadre.Rows.Add();
                                            dgvBobinaMadre.Rows[dgvBobinaMadre.Rows.Count - 1].Cells[clmMCCodsec.Index].Value = mainCoil.codsec;
                                            dgvBobinaMadre.Rows[dgvBobinaMadre.Rows.Count - 1].Cells[clmMCCodigo.Index].Value = mainCoil.code;
                                            dgvBobinaMadre.Rows[dgvBobinaMadre.Rows.Count - 1].Cells[clmMCProducto.Index].Value = cmbTMerma.Text;
                                            dgvBobinaMadre.Rows[dgvBobinaMadre.Rows.Count - 1].Cells[clmMCFecha.Index].Value = Convert.ToString(DateTime.Now);
                                            dgvBobinaMadre.Rows[dgvBobinaMadre.Rows.Count - 1].Cells[clmMCNetWeigth.Index].Value = Math.Round(currentweigth,2);

                                            txtBobinaMadre.ResetText();
                                            cmbTMerma.ResetText();
                                        }

                                    }
                                    else
                                    {
                                        dgvBobinaMadre.Rows.Add();
                                        dgvBobinaMadre.Rows[dgvBobinaMadre.Rows.Count - 1].Cells[clmMCCodsec.Index].Value = mainCoil.codsec;
                                        dgvBobinaMadre.Rows[dgvBobinaMadre.Rows.Count - 1].Cells[clmMCCodigo.Index].Value = mainCoil.code;
                                        dgvBobinaMadre.Rows[dgvBobinaMadre.Rows.Count - 1].Cells[clmMCProducto.Index].Value = cmbTMerma.Text;
                                        dgvBobinaMadre.Rows[dgvBobinaMadre.Rows.Count - 1].Cells[clmMCNetWeigth.Index].Value = Math.Round(currentweigth,2);
                                        dgvBobinaMadre.Rows[dgvBobinaMadre.Rows.Count - 1].Cells[clmMCFecha.Index].Value = Convert.ToString(DateTime.Now);

                                        txtBobinaMadre.ResetText();
                                        cmbTMerma.ResetText();
                                    }
                                }
                                else
                                {
                                        
                                    MessageBox.Show("La bobina madre que intenta agregar ya se consumió por completo.","¡Error!",MessageBoxButtons.OK);
                                    txtBobinaMadre.ResetText();
                                    cmbTMerma.ResetText();
                                }
                            }
                            else
                             {
                                    MessageBox.Show("La bobina que intenta agregar ya esta dada de baja", "¡Error!", MessageBoxButtons.OK);
                                    txtBobinaMadre.ResetText();
                                    cmbTMerma.ResetText();
                             }
                        }
                        else
                        {
                            MessageBox.Show("La bobina madre que intenta cargar es inexistente o el codigo es erroneo", "¡Error!", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese el código de bobina madre", "¡Error!", MessageBoxButtons.OK);
                    }

                }
                else
                {
                    MessageBox.Show("Complete el tipo de merma que desea Cargar", "¡Error!", MessageBoxButtons.OK);
                }
            }
        }


        private void btnBobinaMadre_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvBobinaMadre.Rows.Count; i++)
            {
                Scrap = new clsScrap(dgvBobinaMadre.Rows[i].Cells[clmMCProducto.Index].Value.ToString());
                mainCoil = new clsMainCoil(Convert.ToInt32(dgvBobinaMadre.Rows[i].Cells[clmMCCodsec.Index].Value));
                mainCoil.delete(); // Este es el metodo que updatea el status.
                
                if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)
                {
                    scrapCellar = new clsScrapByExtruderCellar(Scrap.codsec, 4022); 
                    //scrapCellar.acuWeigth(Convert.ToDouble(dgvBobinaMadre.Rows[i].Cells[clmMCNetWeigth.Index].Value)); 
                }
                else
                {
                    scrapCellar = new clsScrapByExtruderCellar(Scrap.codsec, 4023); 
                    //scrapCellar.acuWeigth(mainCoil.netWeigth); 

                }

                clsScrapMovements movimientos = new clsScrapMovements();
        
                movimientos.fkScrap = Convert.ToInt32(Scrap.codsec);
                movimientos.type = "Movimiento de Bobina Madre";
                movimientos.fkMainCoil = mainCoil.codsec;
                movimientos.fkUser = clsGlobal.LoggedUser.codsec;
                movimientos.netWeigth = Convert.ToDouble(dgvBobinaMadre.Rows[i].Cells[clmPeso.Index].Value);

                if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)
                {
                    movimientos.fkDestinationCellar = 4022;
                    movimientos.fkOriginalCellar = 4022;
                }
                else
                {
                    movimientos.fkDestinationCellar = 4023;
                    movimientos.fkOriginalCellar = 4023;
                }
                movimientos.save();

            }

            if (dgvBobinaMadre.Rows.Count == 0)
            {
                MessageBox.Show("La tabla esta vacia", "Llenar Tabla", MessageBoxButtons.OK);
            }
            else 
            { 
            dgvBobinaMadre.Rows.Clear();
            MessageBox.Show("Datos Procesados Correctamente", "Confirmacion", MessageBoxButtons.OK);
            }
        }
        #endregion

        private void cmbTMerma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBobinaMadre.Focus();
                SendKeys.Send("{ENTER}");
            }
        }

        private void dgvPalletScrap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmElimPallet.Index)
            {
                dgvPalletScrap.Rows.RemoveAt(dgvPalletScrap.CurrentRow.Index);
            }
        }

        private void dgvScrapCoil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmElimBobina.Index)
            {
                dgvScrapCoil.Rows.RemoveAt(dgvScrapCoil.CurrentRow.Index);
            }
        }

        private void dgvBobinaMadre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmElimBobMad.Index)
            {
                dgvBobinaMadre.Rows.RemoveAt(dgvBobinaMadre.CurrentRow.Index);
            }
        }
        }
    }




