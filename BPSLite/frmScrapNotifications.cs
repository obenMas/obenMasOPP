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
    public partial class frmScrapNotifications : Form
    {   
        // Como necesito guardar cosas en estas clases las tengo que declarar de manera global
        // De esta manera puedo acceder a sus atributos para pode.r seguir completando las tablas
        // Mas abajo por ejemplo se usa la clase Scrap para completar el FkScrap

        clsScrapPallet Scrappallet = new clsScrapPallet();
        clsScrapPalletByCoilCellar ScrapcoilCellar = new clsScrapPalletByCoilCellar();
        clsScrap Scrap = new clsScrap();
        clsScrapMovements scrapMovement = new clsScrapMovements();

        public frmScrapNotifications()
        {
            InitializeComponent();
        }

        private void frmScrapNotifications_Load(object sender, EventArgs e)
        {
            cargarCombos();

        }

        public void cargarCombos()
        {
            // inicializo el combobox de Scrap, con us diferentes tipos desde la base de datos
            List<clsScrap> listScrap = new List<clsScrap>();
            listScrap = clsScrap.getList();

            for (int i = 0; i < listScrap.Count; i++)
            {
                cmbScrap.Items.Add(listScrap[i].name);
            }
            cmbTurno.Items.Add("A");
            cmbTurno.Items.Add("B");
            cmbTurno.Items.Add("C");

            if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)
            {
                
                // Aca lo que se hace es segun si es pilar o Campana el rol del usuario, trae la lista de maquinas.

                List<clsCutter> listCutter = new List<clsCutter>();
                listCutter = clsCutter.CutterListByPlant(4); // 4 es pilar


                for (int i = 0; i < listCutter.Count; i++)
                {
                    cmbCortadoras.Items.Add(listCutter[i].name);
                }

                List<clsMetallizer> listMetallizer = new List<clsMetallizer>();
                listMetallizer = clsMetallizer.getListByPlant(4); // 4 es pilar

                for (int i = 0; i < listMetallizer.Count; i++)
                {
                    cmbCortadoras.Items.Add(listMetallizer[i].name);
                }
            }
            else
            {
                List<clsCutter> listCutter = new List<clsCutter>();
                listCutter = clsCutter.CutterListByPlant(3); // 3 es Campana


                for (int i = 0; i < listCutter.Count; i++)
                {
                    cmbCortadoras.Items.Add(listCutter[i].name);
                }

                List<clsMetallizer> listMetallizer = new List<clsMetallizer>();
                listMetallizer = clsMetallizer.getListByPlant(3); // 4 es pilar

                for (int i = 0; i < listMetallizer.Count; i++)
                {
                    cmbCortadoras.Items.Add(listMetallizer[i].name);
                }
            }
        }


        private void cmbScrap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

         private void cmbTurno_SelectedIndexChanged(object sender, EventArgs e)
         {
             if (cmbTurno.SelectedIndex != -1 && cmbScrap.SelectedIndex != -1)
             {  
                 //Genero el codigo segun los parametros abajo nombrados

                 DateTime hoy = DateTime.Now;
                 string anio = Convert.ToString(hoy.Year);
                 string mes = Convert.ToString(hoy.Month);
                 string dia = Convert.ToString(hoy.Day);
                 string hora = Convert.ToString(hoy.Hour);
                 string minu = Convert.ToString(hoy.Minute);
                 string seg = Convert.ToString(hoy.Second);

                 string fecha = anio + mes + dia + hora + minu + seg;

                 //Este evento es el que se ejecuta cuando un cmb cambia de estado o de contenido.

                 //Aca segun lo que seleccionaron necesito que me traiga el valor del campo abr
                 // Al pasarle un string luego del new, llamo al metodo load por que dentro de los metodos esta.

                 clsScrap ScrapABR = new clsScrap(cmbScrap.Items[cmbScrap.SelectedIndex].ToString());
                 string codigo = ScrapABR.abr + cmbTurno.Text + fecha;
                 txtCodigo.Text = codigo;

             }
            }

         private void btnGuardar_Click(object sender, EventArgs e)
            {

                clsCutter cutter = new clsCutter(cmbCortadoras.SelectedItem.ToString()); //instancio cutter y llamo a su metodo load Todo en el mismo declarado

                clsMetallizer met = new clsMetallizer(cmbCortadoras.SelectedItem.ToString());

                Scrap = new clsScrap(cmbScrap.Items[cmbScrap.SelectedIndex].ToString()); //igual manera aqui      
         
             // Antes de Guardar debo de chequear si los todos los inputs no estan vacios.

                if ((txtCodigo.Text != "") && (cmbScrap != null) && (txtPeso.Text != "") && (cmbCortadoras != null))
                {
                    
                    /* Anteriormente instanciado el codigo aca le diste los valores a los campos */
 
                    Scrappallet.code = txtCodigo.Text;
                    Scrappallet.fkScrap = Scrap.codsec;
                    Scrappallet.netWeigth = Convert.ToDouble(txtPeso.Text);
                    Scrappallet.turn = cmbTurno.Text;
                    Scrappallet.date = DateTime.Now;
                    Scrappallet.fkStatus = 38; 

                    if(cutter.codsec != 0)
                    {
                        Scrappallet.fkMachine = clsMachine.getMachineCodSecByCutterCodSec(cutter.codsec);
                    }
                    else
                    {
                        Scrappallet.fkMachine = clsMachine.getMachineCodSecByMetallizerCodSec(met.codsec);
                    }
                    
                    bool result = Scrappallet.save(); // Siempre chequear que el save este bien, recordar que el codsec
                                                    // Se genera automaticamente.

                    Scrappallet = new clsScrapPallet(Scrappallet.code);
                    ScrapcoilCellar.fkScrapPallet= Scrappallet.codsec;

                //Como no tengo el fkcoilcellar de aca, lo saco de su respectiva clase
                //Y segun sea pilar o campana tiene uno u otro. 
           
                   if(clsGlobal.LoggedUser.fkRole==2026 || clsGlobal.LoggedUser.fkRole==2027)
                       {
                            ScrapcoilCellar.fkCoilCellar = 4014; // Pilar
                       }
                   else
                       {
                            ScrapcoilCellar.fkCoilCellar = 11; // Campana
                       }

                   scrapMovement.date = DateTime.Now;
                   scrapMovement.fkCoil = 0;
                   scrapMovement.fkDestinationCellar = ScrapcoilCellar.fkCoilCellar;
                   scrapMovement.fkScrapPallet = Scrappallet.codsec;
                   scrapMovement.fkUser = clsGlobal.LoggedUser.codsec;
                   scrapMovement.type = "Merma Corte";
                   scrapMovement.netWeigth = Scrappallet.netWeigth;
                   scrapMovement.save();                 
                        

                       bool result2 = ScrapcoilCellar.save();
                       if ((result == true) && (result2 == true)) //Chequea que los saves se hayan hecho bien.
                       {
                           if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)
                           {
                               clsPrintLabels.printScrapLabelPL(Scrappallet.codsec);
                           }
                           else
                           {
                               clsPrintLabels.printScrapLabel(Scrappallet.codsec);
                           }
                           
                           MessageBox.Show("¡Datos guardados exitosamente!", "Confirmación", MessageBoxButtons.OK);
                           txtCodigo.Text = "";
                           txtPeso.Text = "";
                           cmbScrap.ResetText();
                           cmbCortadoras.ResetText();
                           cmbTurno.ResetText();
                           cmbScrap.SelectedIndex = -1;
                           cmbCortadoras.SelectedIndex = -1;
                           cmbTurno.SelectedIndex = -1;

//Vuelvo a instanciar el scrapPallet para que se ejecute el constructor y asi volver a vaciar su contenido.
// Si no lo hago, en una segunda consulta a los pocos segundos no se ejcuta y no se escriben los datos en la BD, de este Objeto.

                           Scrappallet = new clsScrapPallet(); // Siempre Siempre instancia un objeto VACIO.
                       }
                       else
                       {
                           MessageBox.Show("Ocurrio algun error, los saves no funcionaron correctamente", "Error", MessageBoxButtons.OK);
                       }
                   
                }
                else 
                {
                    MessageBox.Show("Faltan campos que completar, Por favor completelos.", "Error", MessageBoxButtons.OK);
                }
         }

         private void cmbScrap_KeyUp(object sender, KeyEventArgs e)
         {
             cmbScrap.ResetText();
         }

         private void cmbTurno_KeyUp(object sender, KeyEventArgs e)
         {
             cmbTurno.ResetText();
         }

         private void cmbCortadoras_KeyUp(object sender, KeyEventArgs e)
         {
             cmbCortadoras.ResetText();
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
    }
}


