using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;


namespace BPS
{
    public partial class frmRawMaterialConsumeByPalletOrSilo : Form
    {
        List<clsCoilCellar> bodegas = new List<clsCoilCellar>();
        clsRawMaterialBySiloCellar silo = new clsRawMaterialBySiloCellar();
        clsRawPalletByCoilCellar bodegaOrg = new clsRawPalletByCoilCellar();

        public frmRawMaterialConsumeByPalletOrSilo()
        {
            InitializeComponent();
            DataSet DS = new DataSet();
            string sqlString = "";


            if (clsGlobal.LoggedUser.fkRole == 2029 || clsGlobal.LoggedUser.fkRole == 2030)
            {
                bodegas = clsCoilCellar.lstSiloCellarByPlant(4);

                for (int i = 0; i < bodegas.Count; i++)
                {
                    cmbSilo.Items.Add(bodegas[i]);
                }

                sqlString = "CALL spLoteNumberByFkPlant (" + 4 + ");";
            }
            else
            {
                bodegas = clsCoilCellar.lstSiloCellarByPlant(3);

                for (int i = 0; i < bodegas.Count; i++)
                {
                    cmbSilo.Items.Add(bodegas[i]);
                }
                sqlString = "CALL spLoteNumberByFkPlant (" + 3 + ");";
            }

            DS = clsConnection.getDataSetResult(sqlString);

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                cmbLotePallets.Items.Add(DS.Tables[0].Rows[i]["Lote"]);
                cmbLoteSilo.Items.Add(DS.Tables[0].Rows[i]["Lote"]);
            }

            lblPeliculaPallet.Text = string.Empty;
            lblSiloFilm.Text = string.Empty;
        }

        #region Carga de Pallet de Materia Prima
        private void txtCantConsum_KeyDown(object sender, KeyEventArgs e)
        {
            bool bandera = false;

            if (e.KeyCode == Keys.Enter)
            {
                if ((txtCantConsum.Text != string.Empty) && (txtPaletCode.Text != string.Empty) && (cmbLotePallets.Text != string.Empty))
                {
                    clsRawMaterialPallet palletRaw = new clsRawMaterialPallet(txtPaletCode.Text); // Si esto no se hiciese, en la segunda vuelta el pallet tendria el peso cambiado
                    
                    if (palletRaw.codsec != 0)
                    {
                        if(palletRaw.fkStatus == 38)
                        {
                            palletRaw.netweigth = palletRaw.netweigth - Convert.ToDouble(txtCantConsum.Text);

                            if (palletRaw.netweigth >= 0)
                            {
                                bodegaOrg = new clsRawPalletByCoilCellar(palletRaw.codsec);

                                if (bodegaOrg.fkCoilCellar == 4022 || bodegaOrg.fkCoilCellar == 4023)
                                {
                                    if (dgvRawPallet.Rows.Count > 0)
                                    {
                                        foreach (DataGridViewRow row in dgvRawPallet.Rows)
                                        {
                                            if (palletRaw.code == Convert.ToString(row.Cells[clmCodigo.Index].Value))
                                            {
                                                MessageBox.Show("El codigo ya se encuentra ingresado, por favor verifique la tabla", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                                bandera = true;
                                            }
                                        }

                                        if (bandera != true)
                                        {
                                            dgvRawPallet.Rows.Add();
                                            dgvRawPallet.Rows[dgvRawPallet.Rows.Count - 1].Cells[clmCodigo.Index].Value = txtPaletCode.Text;
                                            dgvRawPallet.Rows[dgvRawPallet.Rows.Count - 1].Cells[clmTipoRM.Index].Value = palletRaw.rawMaterial.name;
                                            dgvRawPallet.Rows[dgvRawPallet.Rows.Count - 1].Cells[clmLotePallet.Index].Value = palletRaw.lote;
                                            dgvRawPallet.Rows[dgvRawPallet.Rows.Count - 1].Cells[clmLoteEstrusion.Index].Value = cmbLotePallets.Text;
                                            dgvRawPallet.Rows[dgvRawPallet.Rows.Count - 1].Cells[clmPelicula.Index].Value = lblPeliculaPallet.Text;
                                            dgvRawPallet.Rows[dgvRawPallet.Rows.Count - 1].Cells[clmPeso.Index].Value = Math.Round(palletRaw.netweigth, 2);
                                            dgvRawPallet.Rows[dgvRawPallet.Rows.Count - 1].Cells[clmCantConsumP.Index].Value = txtCantConsum.Text;
                                            dgvRawPallet.Rows[dgvRawPallet.Rows.Count - 1].Cells[clmUsuario.Index].Value = clsGlobal.LoggedUser.userName;
                                            dgvRawPallet.Rows[dgvRawPallet.Rows.Count - 1].Cells[clmNotas.Index].Value = palletRaw.notes;
                                            dgvRawPallet.Rows[dgvRawPallet.Rows.Count - 1].Cells[clmFecha.Index].Value = palletRaw.date;

                                            txtCantConsum.Text = string.Empty;
                                            txtPaletCode.Text = string.Empty;
                                        }
                                    }
                                    else
                                    {
                                        dgvRawPallet.Rows.Add();
                                        dgvRawPallet.Rows[dgvRawPallet.Rows.Count - 1].Cells[clmCodigo.Index].Value = txtPaletCode.Text;
                                        dgvRawPallet.Rows[dgvRawPallet.Rows.Count - 1].Cells[clmTipoRM.Index].Value = palletRaw.rawMaterial.name;
                                        dgvRawPallet.Rows[dgvRawPallet.Rows.Count - 1].Cells[clmLotePallet.Index].Value = palletRaw.lote;
                                        dgvRawPallet.Rows[dgvRawPallet.Rows.Count - 1].Cells[clmLoteEstrusion.Index].Value = cmbLotePallets.Text;
                                        dgvRawPallet.Rows[dgvRawPallet.Rows.Count - 1].Cells[clmPelicula.Index].Value = lblPeliculaPallet.Text;
                                        dgvRawPallet.Rows[dgvRawPallet.Rows.Count - 1].Cells[clmPeso.Index].Value = Math.Round(palletRaw.netweigth, 2);
                                        dgvRawPallet.Rows[dgvRawPallet.Rows.Count - 1].Cells[clmCantConsumP.Index].Value = txtCantConsum.Text;
                                        dgvRawPallet.Rows[dgvRawPallet.Rows.Count - 1].Cells[clmUsuario.Index].Value = clsGlobal.LoggedUser.userName;
                                        dgvRawPallet.Rows[dgvRawPallet.Rows.Count - 1].Cells[clmNotas.Index].Value = palletRaw.notes;
                                        dgvRawPallet.Rows[dgvRawPallet.Rows.Count - 1].Cells[clmFecha.Index].Value = palletRaw.date;

                                        txtCantConsum.Text = string.Empty;
                                        txtPaletCode.Text = string.Empty;
                                    }
                                }
                                else// la bodega de la que quiere consumir no se puede. 
                                {
                                    MessageBox.Show("No es posible consumir un pallet que no se encuentra en la bodega de Extrusión.(" +  (new clsCoilCellar(bodegaOrg.fkCoilCellar)).name + ")\n Por favor solicite el movimiento de bodega a Logística", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No es posible consumir mas de la cantidad que posee el pallet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El pallet que esta intentando consumir se encuentra cerrado o totalmente consumido","¡Error!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                            txtPaletCode.Text = string.Empty;
                            txtCantConsum.Text = string.Empty;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El pallet que intenta cargar no existe, o el codigo es incorrecto.");
                        txtCantConsum.Text = string.Empty;
                        txtPaletCode.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("Por favor complete el código de pallet, la cantidad a consumir o el numero de lote", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void dgvRawPallet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmEliminar.Index)
            {
                dgvRawPallet.Rows.RemoveAt(dgvRawPallet.CurrentRow.Index);
            }
        }
        #endregion

        #region Procesamiento de Pallet de Materia Prima
        private void btnProcesarPallet_Click(object sender, EventArgs e)
        {
            bool praw = false;
            bool pmov = false;
            bool impetique = false;

                if (dgvRawPallet.Rows.Count > 0)
                {

                    for (int i = 0; i < dgvRawPallet.Rows.Count; i++)
                    {
                        clsRawMaterialPallet palletRaw = new clsRawMaterialPallet(Convert.ToString(dgvRawPallet.Rows[i].Cells[clmCodigo.Index].Value));
                        clsRawMaterialMovements movimientoRaw = new clsRawMaterialMovements();
                        clsRawPalletByCoilCellar rmbcc = new clsRawPalletByCoilCellar(palletRaw.codsec);

                        palletRaw.netweigth = Math.Round(palletRaw.netweigth) - Convert.ToDouble(dgvRawPallet.Rows[i].Cells[clmCantConsumP.Index].Value);

                        if (palletRaw.netweigth > 1) // Como el pallet tiene muchos decimales, pregunto por mayor a uno, por si consume casi todo. 
                        {
                            movimientoRaw.fkRaw = palletRaw.fkRaw;
                            movimientoRaw.type = "Consumición de Pallet de Materia Prima";
                            movimientoRaw.fkRawPallet = palletRaw.codsec;
                            movimientoRaw.lote = palletRaw.lote;
                            movimientoRaw.estrusionLote = Convert.ToString(dgvRawPallet.Rows[i].Cells[clmLoteEstrusion.Index].Value);
                            movimientoRaw.netWeigth = Convert.ToDouble(dgvRawPallet.Rows[i].Cells[clmCantConsumP.Index].Value);
                            movimientoRaw.fkUser = clsGlobal.LoggedUser.codsec;
                            movimientoRaw.date = DateTime.Now;
                            movimientoRaw.fkOrigCellar = rmbcc.fkCoilCellar;
                            movimientoRaw.fkDestCellar = rmbcc.fkCoilCellar;

                            pmov = movimientoRaw.save();
                            praw = palletRaw.save();
                            impetique = true;
                        }
                        else
                        {
                            palletRaw.fkStatus = 41;
                            palletRaw.notes = "Pallet Consumido totalmente";
                            praw = palletRaw.save();

                            movimientoRaw.fkRaw = palletRaw.fkRaw;
                            movimientoRaw.type = "Consumición de Pallet de Materia Prima";
                            movimientoRaw.fkRawPallet = palletRaw.codsec;
                            movimientoRaw.lote = palletRaw.lote;
                            movimientoRaw.estrusionLote = Convert.ToString(dgvRawPallet.Rows[i].Cells[clmLoteEstrusion.Index].Value);
                            movimientoRaw.netWeigth = Convert.ToDouble(dgvRawPallet.Rows[i].Cells[clmCantConsumP.Index].Value);
                            movimientoRaw.fkUser = clsGlobal.LoggedUser.codsec;
                            movimientoRaw.date = DateTime.Now;
                            movimientoRaw.fkOrigCellar = rmbcc.fkCoilCellar;
                            movimientoRaw.fkDestCellar = rmbcc.fkCoilCellar;

                            pmov = movimientoRaw.save();

                        }

                        if (impetique == true)
                        {
                            if (clsGlobal.LoggedUser.fkRole == 2029 || clsGlobal.LoggedUser.fkRole == 2030 || clsGlobal.LoggedUser.fkRole == 2032)
                            {
                                clsPrintLabels.printRawLabelPL(palletRaw.codsec);
                                impetique = false;
                            }
                            else
                            {
                                clsPrintLabels.printRawLabel(palletRaw.codsec);
                                impetique = false;
                            }
                        }
                    }
                        
                        if ((praw == true) && (pmov == true))
                        {
                            MessageBox.Show("¡Datos procesados con exito!", "Exito", MessageBoxButtons.OK);
                            dgvRawPallet.Rows.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Se produjo un error en el proceso de los datos", "¡Error!", MessageBoxButtons.OK);
                        }
                }
        }
        #endregion
       
        #region Carga de Granel

        private void txtCantConsumSilo_KeyDown(object sender, KeyEventArgs e)
        {
            bool bandera = false;
            DataSet DS = new DataSet();
            string query = ""; 

            if(e.KeyCode == Keys.Enter)
            {
                if (txtCantConsumSilo.Text != string.Empty && cmbSilo.SelectedIndex != -1 && cmbLoteSilo.SelectedIndex != -1)
                {
                    clsCoilCellar cellar = new clsCoilCellar(cmbSilo.SelectedItem.ToString());

                    silo = clsRawMaterialBySiloCellar.getAllDataFromSilo(cellar.codsec);
                    clsRawMaterial rawMat = new clsRawMaterial(silo.fkRawMaterial);

                    silo.weigth = silo.weigth - Convert.ToDouble(txtCantConsumSilo.Text);
                    silo.totalWeigth = silo.totalWeigth - Convert.ToDouble(txtCantConsumSilo.Text);

                    if (silo.fkSiloCellar != 0)
                    {
                        if (silo.fkSiloCellar != 4028 || silo.fkSiloCellar != 4029)
                        {
                            if (silo.totalWeigth > 0)
                            {
                                if (dgvSilo.Rows.Count > 0)
                                {
                                    for (int i = 0; i < dgvSilo.Rows.Count; i++)
                                    {
                                        if (Convert.ToInt32(dgvSilo.Rows[i].Cells[clmfkSilo.Index].Value) == silo.fkSiloCellar)
                                        {
                                            bandera = true;
                                            MessageBox.Show("Solo podra realizar una consumición por Silo. Por favor procese los datos primero, si quiere hacer nuevamente una consumision sobre el mismo silo", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }

                                    if (bandera != true) // si es true, significa que se encontro el fkSilo, por ende no puede cargar. 
                                    {

                                        dgvSilo.Rows.Add();
                                        dgvSilo.Rows[dgvSilo.Rows.Count - 1].Cells[clmfkSilo.Index].Value = cellar.codsec;
                                        dgvSilo.Rows[dgvSilo.Rows.Count - 1].Cells[clmLoteSilo.Index].Value = cmbLoteSilo.Text;
                                        dgvSilo.Rows[dgvSilo.Rows.Count - 1].Cells[clmLoteGranel.Index].Value = silo.lote.ToUpper();
                                        dgvSilo.Rows[dgvSilo.Rows.Count - 1].Cells[clmPeliculaSilo.Index].Value = lblSiloFilm.Text;
                                        dgvSilo.Rows[dgvSilo.Rows.Count - 1].Cells[clmNombreSilo.Index].Value = cmbSilo.SelectedItem.ToString();
                                        dgvSilo.Rows[dgvSilo.Rows.Count - 1].Cells[clmTipoRawG.Index].Value = rawMat.name;
                                        if (silo.weigth < 0)
                                        {
                                            dgvSilo.Rows[dgvSilo.Rows.Count - 1].Cells[clmCantSilo.Index].Value = silo.totalWeigth;
                                        }
                                        else
                                        {
                                            dgvSilo.Rows[dgvSilo.Rows.Count - 1].Cells[clmCantSilo.Index].Value = silo.weigth;
                                        }

                                        dgvSilo.Rows[dgvSilo.Rows.Count - 1].Cells[clmCantConsumSilo.Index].Value = txtCantConsumSilo.Text;

                                        txtCantConsumSilo.Text = string.Empty;
                                        cmbSilo.ResetText();
                                        cmbSilo.SelectedIndex = -1;
                                        cmbLoteSilo.ResetText();
                                        lblSiloFilm.Text = "";

                                    }
                                }
                                else
                                {
                                    dgvSilo.Rows.Add();
                                    dgvSilo.Rows[dgvSilo.Rows.Count - 1].Cells[clmfkSilo.Index].Value = cellar.codsec;
                                    dgvSilo.Rows[dgvSilo.Rows.Count - 1].Cells[clmLoteSilo.Index].Value = cmbLoteSilo.Text;
                                    dgvSilo.Rows[dgvSilo.Rows.Count - 1].Cells[clmLoteGranel.Index].Value = silo.lote.ToUpper();
                                    dgvSilo.Rows[dgvSilo.Rows.Count - 1].Cells[clmPeliculaSilo.Index].Value = lblSiloFilm.Text;
                                    dgvSilo.Rows[dgvSilo.Rows.Count - 1].Cells[clmNombreSilo.Index].Value = cmbSilo.SelectedItem.ToString();
                                    dgvSilo.Rows[dgvSilo.Rows.Count - 1].Cells[clmTipoRawG.Index].Value = rawMat.name;
                                    if (silo.weigth < 0)
                                    {
                                        dgvSilo.Rows[dgvSilo.Rows.Count - 1].Cells[clmCantSilo.Index].Value = silo.totalWeigth;
                                    }
                                    else
                                    {
                                        dgvSilo.Rows[dgvSilo.Rows.Count - 1].Cells[clmCantSilo.Index].Value = silo.weigth;
                                    }
                                    dgvSilo.Rows[dgvSilo.Rows.Count - 1].Cells[clmCantConsumSilo.Index].Value = txtCantConsumSilo.Text;

                                    txtCantConsumSilo.Text = string.Empty;
                                    cmbSilo.ResetText();
                                    cmbSilo.SelectedIndex = -1;
                                    cmbLoteSilo.ResetText();
                                    lblSiloFilm.Text = "";
                                }
                            }
                            else
                            {
                                MessageBox.Show("El silo del que intenta consumir no posee material suficiente", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            double AcuPeso = 0;
                            // Aca va la movida donde le diria cuanto le falta para cambiar de material. 

                            // NO CONTEMPLA EL CASO DE QUE SI CARGO LOTE 1 LOTE 2 LOTE 1, POR QUE NO HAY MANERA DE CONTROLARLO. ES SIMPLEMENTE ERROR DE DATA ENTRY

                            query = "SELECT MAX(bps_prod_rawmaterialbysilocellar.rwmbsc_codsec) AS codsec,bps_prod_rawmaterialbysilocellar.rwmbsc_lote AS lote,"; 
                            query += "bps_prod_rawmaterialbysilocellar.rwmbsc_fkRawType AS typeNoMezclo,bps_prod_rawmaterialbysilocellar.rwmbsc_fkSiloCellar AS fkSilo,";
                            query += "SUM(bps_prod_rawmaterialbysilocellar.rwmbsc_weigth) AS TotPeso";
                            query += " FROM bps_prod_rawmaterialbysilocellar WHERE bps_prod_rawmaterialbysilocellar.rwmbsc_fkSiloCellar = " + silo.fkSiloCellar.ToString() + "";
                            query += " GROUP BY rwmbsc_fkRawType,rwmbsc_lote, rwmbsc_fkSiloCellar";
                            query += "ORDER BY codsec ASC";

                            DS = clsConnection.getDataSetResult(query);

                            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                            {
                                if (DS.Tables[0].Rows[i]["typeNoMezclo"] == DS.Tables[0].Rows[i+1]["typeNoMezclo"])
                                {
                                    AcuPeso = AcuPeso + Convert.ToDouble(DS.Tables[0].Rows[i]["TotPeso"]);
                                }
                                else
                                {
                                    AcuPeso = AcuPeso + Convert.ToDouble(DS.Tables[0].Rows[i]["TotPeso"]);
                                    MessageBox.Show("No puede realizar el consumo, ya que, consumiria mezcla de materiales.Tiene disponible para consumir:" + AcuPeso.ToString(), "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El silo que selecciono no existe o es erroneo el nombre.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor Seleccione un silo y la cantidad que desea consumir.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion

        #region Procesamiento de Granel
        private void btnProcesarGranel_Click(object sender, EventArgs e)
        {
            bool psilo = false;

            if (dgvSilo.Rows.Count > 0)
            {
                for (int i = 0; i < dgvSilo.Rows.Count; i++)
                {
                    clsRawMaterialBySiloCellar silo = new clsRawMaterialBySiloCellar();
                    clsRawMaterialBySiloCellar siloaux = new clsRawMaterialBySiloCellar(Convert.ToInt32(dgvSilo.Rows[i].Cells[clmfkSilo.Index].Value));
                    clsCoilCellar siloCellar = new clsCoilCellar(Convert.ToString(dgvSilo.Rows[i].Cells[clmNombreSilo.Index].Value));
                    clsRawMaterialMovements movimientoRaw = new clsRawMaterialMovements();

                    psilo = silo.consumeWhatYouWant(siloCellar.codsec,Convert.ToDouble(dgvSilo.Rows[i].Cells[clmCantConsumSilo.Index].Value));

                    movimientoRaw.fkRaw = siloaux.fkRawMaterial;
                    movimientoRaw.fkRawPallet = 0;
                    movimientoRaw.lote = siloaux.lote;
                    movimientoRaw.netWeigth = Convert.ToDouble(dgvSilo.Rows[i].Cells[clmCantConsumSilo.Index].Value);
                    movimientoRaw.estrusionLote = Convert.ToString(dgvSilo.Rows[i].Cells[clmLoteEstrusion.Index].Value);
                    movimientoRaw.fkOrigCellar = siloaux.fkSiloCellar;
                    movimientoRaw.fkDestCellar = siloaux.fkSiloCellar;
                    movimientoRaw.type = "Consumo a Granel del Silo";
                    movimientoRaw.fkUser = clsGlobal.LoggedUser.codsec;
                    movimientoRaw.date = DateTime.Now;

                    movimientoRaw.save();

                }
            }

            if (psilo)
            {
                MessageBox.Show("Los Datos fueron procesados correctamente.", "Exito", MessageBoxButtons.OK);
                 dgvSilo.Rows.Clear();
                cmbLoteSilo.ResetText();
                txtCantConsumSilo.Text = string.Empty;
                cmbSilo.ResetText();
                lblSiloFilm.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Se produjo algun error en el consumo de Silo", "Error", MessageBoxButtons.OK);
            }
        }
        #endregion

        #region Eventos del Formulario

        private void dgvSilo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmEliminarSilo.Index)
            {
                dgvSilo.Rows.RemoveAt(dgvSilo.CurrentRow.Index);
            }
        }

        private void txtPaletCode_KeyDown(object sender, KeyEventArgs e)
        {
            clsRawMaterialPallet palletRaw = new clsRawMaterialPallet(txtPaletCode.Text);

            txtCantConsum.Text = Convert.ToString(palletRaw.netweigth);
        }

        private void cmbLoteSilo_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsFilmProductionPlan planproduccion = new clsFilmProductionPlan(cmbLoteSilo.Text);
            clsProductionOrder orden = new clsProductionOrder(planproduccion.fkProductionOrder);
            clsBopp pelicula = new clsBopp(orden.fkBopp);

            lblSiloFilm.Text = Convert.ToString(pelicula.code).ToUpper();
        }

        private void cmbLotePallets_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsFilmProductionPlan planproduccion = new clsFilmProductionPlan(cmbLotePallets.Text);
            clsProductionOrder orden = new clsProductionOrder(planproduccion.fkProductionOrder);
            clsBopp pelicula = new clsBopp(orden.fkBopp);

            lblPeliculaPallet.Text = Convert.ToString(pelicula.code).ToUpper();
        }

        #endregion

    }
}
