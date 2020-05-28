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
    public partial class frmMillProduction : Form
    {
       
        List<clsRawMaterialFromScrap> listRawMaterial = new List<clsRawMaterialFromScrap>();

        public frmMillProduction()
        {
            InitializeComponent();
        }

        private void frmMillProduction_Load(object sender, EventArgs e)
        {
            cargarCombos();
        }
        public void cargarCombos()
        {
            //En teoria me retorna una lista con los campos de otra tabla que puse en el metodo (se pueden agregar mas) segun los id's que estan
            //Guardados en la tabla de la misma clase.

            listRawMaterial = clsRawMaterialFromScrap.lstRawMaterialFromScrap();

            for (int i = 0; i < listRawMaterial.Count; i++)
            {
               cmbTipo.Items.Add(listRawMaterial[i].rawMaterial.name);
            }
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pletra,tletra, contextbox;

            string vta;
            vta = "";

            DateTime hoy = DateTime.Now;
            string anio = Convert.ToString(hoy.Year);
            string mes = Convert.ToString(hoy.Month);
            string dia = Convert.ToString(hoy.Day);
            string hora = Convert.ToString(hoy.Hour);
            string minu = Convert.ToString(hoy.Minute);
            string seg = Convert.ToString(hoy.Second);

            anio = anio.Substring(2, 2);
            string fecha = anio + mes + dia + hora + minu + seg ;

            contextbox = cmbTipo.Text;
            pletra = contextbox.Substring(0, 1);
            if(contextbox.Length>25)
            {
                tletra = contextbox.Substring(22, 2);
            }
            else
            {
                tletra = contextbox.Substring(18, 2);
            }

            if (contextbox.Length > 33)
            {
                vta = "V";
            }

            if (cmbTipo.SelectedIndex == 6)
            {
                tletra = "MZ";
            }

            txtCodigo.Text = pletra + tletra + vta + fecha; 
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int fkScrap = 0;

            if ((txtPeso.Text != string.Empty) && (txtPesoScrap.Text != string.Empty) && (cmbTipo.Text != string.Empty))
            {
                clsRawMaterialPallet rawMaterialPallet = new clsRawMaterialPallet();
                clsRawPalletByCoilCellar rawPalletByCoilCellar = new clsRawPalletByCoilCellar();
                clsRawMaterialMovements movimientoRaw = new clsRawMaterialMovements();

                // Obtengo el codsec que coincide con el fkRawMaterial por medio de el string que tiene el combo

                clsRawMaterial rawMat = new clsRawMaterial();
                int codsecRaw = rawMat.getCodsecByName(cmbTipo.SelectedItem.ToString());

                //Si es cristal venta, o blanco venta conque consuma de blanco. Por ahora lo hardcodeo despues vemos como organizamos esto.
                clsRawMaterialFromScrap rawMatFromScrap = new clsRawMaterialFromScrap();

                // Doy de Alta el pallet.

                rawMaterialPallet.code = txtCodigo.Text;
                rawMaterialPallet.netweigth = Convert.ToDouble(txtPeso.Text);
                rawMaterialPallet.fkRaw = codsecRaw;
                rawMaterialPallet.lote = txtCodigo.Text;
                rawMaterialPallet.fkStatus = 38;
                rawMaterialPallet.date = DateTime.Now;
                rawMaterialPallet.fkUser = clsGlobal.LoggedUser.codsec;
             
                if (codsecRaw == 293)
                {
                    fkScrap = 4;
                }
                else if (codsecRaw == 294)
                {
                    fkScrap = 1;
                }
                else if (codsecRaw == 295)
                {
                    //MessageBox.Show("No se puede consumir mezcla, por que no se que se quiere consumir de cada cosa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    // Obtengo el fkScrap a partir del fkRawMaterial que consegui arriba.
                    fkScrap = rawMatFromScrap.getfkScrapByfkRawMaterialCode(codsecRaw);
                }
              
                double rpeso = -1*(Convert.ToDouble(txtPeso.Text) + Convert.ToDouble(txtPesoScrap.Text));

                // Aca descuento del Stock de scrap que hay almacenado.
                clsScrapByExtruderCellar deposito = new clsScrapByExtruderCellar();
                if (clsGlobal.LoggedUser.fkRole == 2029 || clsGlobal.LoggedUser.fkRole == 2030 || clsGlobal.LoggedUser.fkRole == 2032)
                {
                    // Doy de alta el movimiento y la baja de los pesos de la tabla extruderCellar.
                    //deposito = new clsScrapByExtruderCellar(fkScrap, 4022); //Arreglar esto, falta algo de la planta. que no se instancia.

                    //if (deposito.weigth > Math.Abs(rpeso))
                    //{
                        //deposito.acuWeigth(rpeso);   //Le paso un peso negativo asi se descuenta de lo que hay en el deposito.

                        bool prue = rawMaterialPallet.save();
                        
                        
                        clsScrapMovements movimiento = new clsScrapMovements();
                        clsRawMaterialPallet rawPallet = new clsRawMaterialPallet();
                        int codsecPalletRaw = clsRawMaterialPallet.getCodsecByCode(txtCodigo.Text);
                        clsPrintLabels.printRawLabelPL(codsecPalletRaw);

                        // Lo cambie de lugar por que me estaba instanciando con el fk de tipo de scrap del pallet
                        // Y no con el fk del pallet.
                        rawPalletByCoilCellar.fkCoilCellar = 4019;
                        rawPalletByCoilCellar.fkRawPallet = codsecPalletRaw;

                        // Doy de alta el movimiento.
                        
                        // Recordar que los movimientos que no tengan fk de ScrapPallet y sean producción de molino. 
                        // Son produccion del molino.

                        movimiento.fkScrap = fkScrap;
                        movimiento.type = "Producción de molino";
                        movimiento.fkUser = clsGlobal.LoggedUser.codsec;
                        movimiento.date = DateTime.Now;
                        movimiento.netWeigth = Convert.ToDouble(Math.Abs(rpeso));
                        movimiento.fkOriginalCellar = 4019;
                        movimiento.fkDestinationCellar = 4019;

                        movimientoRaw.fkRaw = codsecRaw;
                        movimientoRaw.fkRawPallet = codsecPalletRaw;
                        movimientoRaw.netWeigth = Convert.ToDouble(txtPeso.Text);
                        movimientoRaw.lote = codsecPalletRaw.ToString();
                        movimientoRaw.type = "Produccion de Materia prima del molino";
                        movimientoRaw.estrusionLote = "";
                        movimientoRaw.fkOrigCellar = 4019;
                        movimientoRaw.fkDestCellar = 4019;
                        movimientoRaw.date = DateTime.Now;
                        movimientoRaw.fkUser = clsGlobal.LoggedUser.codsec;

                        movimientoRaw.save();
                        movimiento.save(); // Guardo el movimiento en la tabla.
                        rawPalletByCoilCellar.save(); // Se afilia un codigo de pallet a un deposito en particular, con sus respectivos fks

                        // Aca iria el alta de la nueva tabla mill production, donde se da de alta el movimiento creado por el molino.

                        clsMillProduction millProduction = new clsMillProduction();

                        millProduction.fkRaw = codsecPalletRaw;
                        millProduction.netWeigth = Convert.ToDouble(txtPeso.Text);
                        millProduction.scrapWeigth = Convert.ToDouble(txtPesoScrap.Text);
                        millProduction.fkUser = clsGlobal.LoggedUser.codsec;
                        millProduction.date = DateTime.Now;

                        millProduction.fkMachine = 3029;

                        millProduction.save();

                        MessageBox.Show("Datos Procesados Correctamente", "¡Exito!", MessageBoxButtons.OK);
                    //}
                    //else
                    //{
                        //MessageBox.Show("No existe Material suficiente para procesar de ese tipo de material", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //}
                } // Se hace lo mismo si el usuario logueado es de campana.
                else
                {
                    // Doy de alta el movimiento y la bajade los pesos de la tabla extruderCellar.
                    //deposito = new clsScrapByExtruderCellar(fkScrap, 4023);

                    //if (deposito.weigth >= Math.Abs(rpeso))
                    //{
                        //deposito.acuWeigth(rpeso);   //Le paso un peso negativo asi se descuenta de lo que hay en el deposito.
                        bool prue = rawMaterialPallet.save();
                       
                        clsScrapMovements movimiento = new clsScrapMovements();
                        clsRawMaterialPallet rawPallet = new clsRawMaterialPallet();
                        int codsecPalletRaw = clsRawMaterialPallet.getCodsecByCode(txtCodigo.Text);
                        clsPrintLabels.printRawLabel(codsecPalletRaw);

                        // Lo cambie de lugar por que me estaba instanciando con el fk de tipo de scrap del pallet
                        // Y no con el fk del pallet.
                        rawPalletByCoilCellar.fkCoilCellar = 4023;
                        rawPalletByCoilCellar.fkRawPallet = codsecPalletRaw; 

                        // Doy de alta el movimiento.

                        movimiento.fkScrap = fkScrap;
                        movimiento.type = "Producción de molino";
                        movimiento.fkUser = clsGlobal.LoggedUser.codsec;
                        movimiento.date = DateTime.Now;
                        movimiento.netWeigth = Convert.ToDouble(Math.Abs(rpeso));
                        movimiento.fkOriginalCellar = 4023;
                        movimiento.fkDestinationCellar = 4023;

                        movimientoRaw.fkRaw = codsecRaw;
                        movimientoRaw.fkRawPallet = codsecPalletRaw;
                        movimientoRaw.lote = codsecPalletRaw.ToString();
                        movimientoRaw.netWeigth = Convert.ToDouble(txtPeso.Text);
                        movimientoRaw.type = "Produccion de Materia prima del molino";
                        movimientoRaw.fkOrigCellar = 4023;
                        movimientoRaw.fkDestCellar = 4023;
                        movimientoRaw.date = DateTime.Now;
                        movimientoRaw.fkUser = clsGlobal.LoggedUser.codsec;

                        movimientoRaw.save();
                        movimiento.save(); // Guardo el movimiento en la tabla.
                        rawPalletByCoilCellar.save(); // Se afilia un codigo de pallet a un deposito en particular, con sus respectivos fks

                        // Aca iria el alta de la nueva tabla mill production, donde se da de alta el movimiento creado por el molino.

                        clsMillProduction millProduction = new clsMillProduction();

                        millProduction.fkRaw = codsecPalletRaw;
                        millProduction.netWeigth = Convert.ToDouble(txtPeso.Text);
                        millProduction.scrapWeigth = Convert.ToDouble(txtPesoScrap.Text);
                        millProduction.fkUser = clsGlobal.LoggedUser.codsec;
                        millProduction.date = DateTime.Now;

                        millProduction.fkMachine = 3030;

                        millProduction.save();
                        

                        MessageBox.Show("Datos Procesados Correctamente", "¡Exito!", MessageBoxButtons.OK);
                    //}
                    //else
                    //{
                        //MessageBox.Show("No existe Material suficiente para procesar de ese tipo de material", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //}
                }
            }
            else
            {
                MessageBox.Show("Por favor complete todos los campos que se le requieren", "¡Validacion!", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

            txtCodigo.Text = "";
            cmbTipo.ResetText();
            txtPeso.Text = "";
            txtPesoScrap.Text = "";

        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPesoScrap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void cmbTipo_KeyUp(object sender, KeyEventArgs e)
        {
            cmbTipo.ResetText();
        }
    }
}
