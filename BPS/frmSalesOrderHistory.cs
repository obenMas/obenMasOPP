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
    public partial class frmSalesOrderHistory : Form
    {
        DataSet DS = new DataSet();
        DataSet DS2 = new DataSet();
        string lastChange = string.Empty;
        string executive = string.Empty;
        string saleorder = string.Empty;
        string plant = string.Empty;
        string client = string.Empty;
        string film = string.Empty;
        string width = string.Empty;
        string diam = string.Empty;
        string core = string.Empty;
        string obs = string.Empty;

        public frmSalesOrderHistory()
        {
            InitializeComponent();
            getDataSet();
            populateDataGrid();
        }

        public void getDataSet()
        {
            string querystring = "";        
            querystring += "EXECUTE spSalesOrderHistory2 @quant=" + txtQuantity.Text;
            if(executive==string.Empty)
            {
                querystring += ", @ejecutiva=NULL";
                
            }
            else
            {
                querystring += ", @ejecutiva='"+executive+"'";
               
            }
            if (saleorder == string.Empty)
            {
                querystring += ", @pedido=NULL";
       
            }
            else
            {
                querystring += ", @pedido=" + saleorder;
          
            }
            if (plant == string.Empty)
            {
                querystring += ", @planta=NULL";
          
            }
            else
            {
                querystring += ", @planta='" + plant+"'";
            
            }
            if (client == string.Empty)
            {
                querystring += ", @cliente=NULL";
              
            }
            else
            {
                querystring += ", @cliente='" + client+"'";
            
            }
            if (film == string.Empty)
            {
                querystring += ", @pelicula=NULL";
               
            }
            else
            {
                querystring += ", @pelicula='" + film+"'";
             
            }
            if (width == string.Empty)
            {
                querystring += ", @ancho=NULL";
               
            }
            else
            {
                querystring += ", @ancho=" + width;
             
            }
            if (diam == string.Empty)
            {
                querystring += ", @diametro=NULL";
         
            }
            else
            {
                querystring += ", @diametro='" + diam+"'";
             
            }
            if (core == string.Empty)
            {
                querystring += ", @core=NULL";
          
            }
            else
            {
                querystring += ", @core=" + core;
         
            }
            if (obs == string.Empty)
            {
                querystring += ", @observaciones=NULL";
              
            }
            else
            {
                querystring += ", @observaciones='" + obs+"'";
               
            }
            DS = clsConnection.getDataSetResult(querystring);
        }


        public void populateDataGrid()
        {
            List<string> executives = new List<string>();
            List<string> order = new List<string>();
            List<string> plants = new List<String>();
            List<string> customers = new List<string>();
            List<string> films = new List<string>();
            List<double> widths = new List<double>();
            List<string> diameters = new List<string>();
            List<string> notes = new List<string>();
            List<int> cod = new List<int>(); // lista nueva de los pedidos
            List<int> cores = new List<int>();
            clsSalesOrderDetail objsod = new clsSalesOrderDetail();


            dgvSalesOrderHistory.Rows.Clear();

            if (DS.Tables.Count>0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvSalesOrderHistory.Rows.Add();
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells[clmCodsec.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["codsec"]);
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmPlant"].Value = DS.Tables[0].Rows[i]["Planta"].ToString();
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmCompromiseDate"].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaEntrega"]).ToShortDateString();
                    // Agregado de Fechas de Entrega Separadas
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmDayEnt"].Value =DS.Tables[0].Rows[i]["dayFechaEntrega"];
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmMonthEnt"].Value = DS.Tables[0].Rows[i]["monthFechaEntrega"];
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmYearEnt"].Value = DS.Tables[0].Rows[i]["yearFechaEntrega"];
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmHourEnt"].Value = DS.Tables[0].Rows[i]["HoraEntrega"];
                    // Agregado de Fecha de Despacho
                    if (Convert.ToDateTime(DS.Tables[0].Rows[i]["fechaDespacho"]).ToString("dd/MM/yyyy") != "01/01/1900")
                    {
                        dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmShippingDate"].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["fechaDespacho"]).ToShortDateString();
                        
                    }
                    else
                    {
                        dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmShippingDate"].Value = "";

                    }
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmdayShipping"].Value = DS.Tables[0].Rows[i]["dayfechaDespacho"];
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmmonthShipping"].Value = DS.Tables[0].Rows[i]["monthfechaDespacho"];
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmyearShipping"].Value = DS.Tables[0].Rows[i]["yearfechaDespacho"];
                    // Termina acá
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmCustomer"].Value = DS.Tables[0].Rows[i]["Cliente"].ToString();
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmPurchaseOrder"].Value = DS.Tables[0].Rows[i]["OCCliente"].ToString();
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmFilm"].Value = DS.Tables[0].Rows[i]["Pelicula"].ToString();
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmWidth"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Ancho"]), 2);
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmDiameter"].Value = DS.Tables[0].Rows[i]["Diametro"].ToString();
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmCore"].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["Core"]);

                    //CANTIDAD SOLICITADA
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells[clmQuantity.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadSolicitada"]), 2);
                    if (Convert.ToDouble(dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmQuantity"].Value) > 999.99)
                    {
                        dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmQuantity"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadSolicitada"]), 2).ToString("0,000.00");
                    }
                    else
                    {
                        dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmQuantity"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadSolicitada"]), 2).ToString("00.00");
                    }

                    //CANTIDAD ENTREGADA
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmDeliveredQuantity"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadEntregada"]), 2);
                    if (Convert.ToDouble(dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmDeliveredQuantity"].Value) > 999.99)
                    {
                        dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmDeliveredQuantity"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadEntregada"]), 2).ToString("0,000.00");
                    }
                    else
                    {
                        dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmDeliveredQuantity"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadEntregada"]), 2).ToString("00.00");
                    }

                    //PRECIO USD
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmPrice"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Precio"]), 2);
                    if (Convert.ToDouble(dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmPrice"].Value) > 999.99)
                    {
                        dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmPrice"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Precio"]), 2).ToString("0,000.00");
                    }
                    else
                    {
                        dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmPrice"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Precio"]), 2).ToString("00.00");
                    }

                    //TDC
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmTdC"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["TipoDeCambio"]), 2);
                    if (Convert.ToDouble(dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmTdC"].Value) > 999.99)
                    {
                        dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmTdC"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["TipoDeCambio"]), 2).ToString("0,000.00");
                    }
                    else
                    {
                        dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmTdC"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["TipoDeCambio"]), 2).ToString("00.00");
                    }

                    //PENDIENTE AR$
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmPendingMoney"].Value = (Math.Round(Convert.ToDouble(dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmTdC"].Value), 2)) * (Math.Round(Convert.ToDouble(dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmPrice"].Value), 2)) * (Math.Round(Convert.ToDouble(dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmDeliveredQuantity"].Value), 2));
                    if (Convert.ToDouble(dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmPendingMoney"].Value) > 999.99)
                    {
                        dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmPendingMoney"].Value = ((Math.Round(Convert.ToDouble(dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmTdC"].Value), 2)) * (Math.Round(Convert.ToDouble(dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmPrice"].Value), 2)) * (Math.Round(Convert.ToDouble(dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmDeliveredQuantity"].Value), 2))).ToString("0,000.00");
                    }
                    else
                    {
                        dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmPendingMoney"].Value = ((Math.Round(Convert.ToDouble(dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmTdC"].Value), 2)) * (Math.Round(Convert.ToDouble(dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmPrice"].Value), 2)) * (Math.Round(Convert.ToDouble(dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmDeliveredQuantity"].Value), 2))).ToString("00.00");
                    }

                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmObservations"].Value = DS.Tables[0].Rows[i]["Observaciones"].ToString();
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmStatus"].Value = DS.Tables[0].Rows[i]["Estado"].ToString();

                    //EL RESTO SE COMPLETAN PERO NO SE MUESTRAN EN EL DGV

                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmExecutive"].Value = DS.Tables[0].Rows[i]["EjecutivoDeCuentas"].ToString();

                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmCreatedDate"].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaIngreso"]).ToShortDateString();
                    //Agregada fecha de ingreso
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmDayIng"].Value = DS.Tables[0].Rows[i]["dayFechaIngreso"];
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmMonthIng"].Value = DS.Tables[0].Rows[i]["monthFechaIngreso"];
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmYearIng"].Value = DS.Tables[0].Rows[i]["yearFechaIngreso"];
                    dgvSalesOrderHistory.Rows[dgvSalesOrderHistory.Rows.Count - 1].Cells["clmHourIng"].Value = DS.Tables[0].Rows[i]["HoraIngreso"];
                    //termina aca

                    //Se complentan las listas que luego se utilizan para completar los combos
                    if (!executives.Contains(DS.Tables[0].Rows[i]["EjecutivoDeCuentas"].ToString()))
                        executives.Add(DS.Tables[0].Rows[i]["EjecutivoDeCuentas"].ToString());

                    /*
                    if (!order.Contains(DS.Tables[0].Rows[i]["Pedido"].ToString()))
                        order.Add(DS.Tables[0].Rows[i]["Pedido"].ToString());*/

                    //permite agregar a la lista cod el codsec para poder filtrar
                    if (!cod.Contains(Convert.ToInt32(DS.Tables[0].Rows[i]["codsec"])))
                        cod.Add(Convert.ToInt32(DS.Tables[0].Rows[i]["codsec"]));

                    if (!plants.Contains(DS.Tables[0].Rows[i]["Planta"].ToString()))
                        plants.Add(DS.Tables[0].Rows[i]["Planta"].ToString());

                    if (!customers.Contains(DS.Tables[0].Rows[i]["Cliente"].ToString()))
                        customers.Add(DS.Tables[0].Rows[i]["Cliente"].ToString());

                    if (!films.Contains(DS.Tables[0].Rows[i]["Pelicula"].ToString()))
                        films.Add(DS.Tables[0].Rows[i]["Pelicula"].ToString());

                    if (!widths.Contains(Convert.ToDouble(DS.Tables[0].Rows[i]["Ancho"])))
                        widths.Add(Convert.ToDouble(DS.Tables[0].Rows[i]["Ancho"].ToString()));

                    if (!diameters.Contains(DS.Tables[0].Rows[i]["Diametro"].ToString()))
                        diameters.Add(DS.Tables[0].Rows[i]["Diametro"].ToString());

                    if (!cores.Contains(Convert.ToInt32(DS.Tables[0].Rows[i]["Core"])))
                        cores.Add(Convert.ToInt32(DS.Tables[0].Rows[i]["Core"].ToString()));

                    if (!notes.Contains(DS.Tables[0].Rows[i]["Observaciones"].ToString()))
                        notes.Add(DS.Tables[0].Rows[i]["Observaciones"].ToString());              
                }
                //Se ordenan las listas 
                executives.Sort();
                cod.Sort();
                plants.Sort();
                customers.Sort();
                films.Sort();
                widths.Sort();
                diameters.Sort();
                cores.Sort();
                notes.Sort();

                //Si no fue el ultimo cambio, se borra el combo y se completa con la lista correspondiente
                if(lastChange!="executive")
                {
                    cmbExecutive.Items.Clear();
                    for (int i = 0; i < executives.Count; i++)
                    {
                        cmbExecutive.Items.Add(executives[i]);
                    }
                }
                
                if (lastChange != "saleorder")
                {
                    cmbOrder.Items.Clear();
                    for (int i = 0; i < cod.Count; i++)
                    {
                        cmbOrder.Items.Add(cod[i]);
                    }
                }
                
                if (lastChange != "plant")
                {
                    cmbPlant.Items.Clear();
                    for (int i = 0; i < plants.Count; i++)
                    {
                        cmbPlant.Items.Add(plants[i]);
                    }
                }
                
                if (lastChange != "client")
                {
                    cmbCustommer.Items.Clear();
                    for (int i = 0; i < customers.Count; i++)
                    {
                        cmbCustommer.Items.Add(customers[i]);
                    }
                }
                
                if (lastChange != "film")
                {
                    cmbFilm.Items.Clear();
                    for (int i = 0; i < films.Count; i++)
                    {
                        cmbFilm.Items.Add(films[i]);
                    }
                }
                
                if (lastChange != "width")
                {
                    cmbWidth.Items.Clear();
                    for (int i = 0; i < widths.Count; i++)
                    {
                        cmbWidth.Items.Add(widths[i]);
                    }
                }
                
                if (lastChange != "diam")
                {
                    cmbDiameter.Items.Clear();
                    for (int i = 0; i < diameters.Count; i++)
                    {
                        cmbDiameter.Items.Add(diameters[i]);
                    }
                }
                
                if (lastChange != "core")
                {
                    cmbCore.Items.Clear();
                    for (int i = 0; i < cores.Count; i++)
                    {
                        cmbCore.Items.Add(cores[i]);
                    }
                }
                
                if (lastChange != "obs")
                {
                    cmbNotes.Items.Clear();
                    for (int i = 0; i < notes.Count; i++)
                    {
                        cmbNotes.Items.Add(notes[i]);
                    }
                }

                //Se completa la cantidad de registros mostrados
                label9.Text = dgvSalesOrderHistory.Rows.Count + " /";
            }

            dgvSalesOrderHistory.Sort(clmCodsec, ListSortDirection.Descending);

        }

        //Cuando se cambia el indice de algun combo se actualiza la variable correspondiente, se lo guarda como ultimo cambio y se vuelve a obtener dataset y popular
        private void cmbExecutive_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbExecutive.SelectedIndex!=-1)
            {
                executive = cmbExecutive.Items[cmbExecutive.SelectedIndex].ToString();
                lastChange = "executive";
                getDataSet();
                populateDataGrid();
            }
            
        }

        private void cmbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrder.SelectedIndex != -1)
            {
                saleorder = cmbOrder.Items[cmbOrder.SelectedIndex].ToString();
                lastChange = "saleorder";
                getDataSet();
                populateDataGrid();
            }
            
        }

        private void cmbPlant_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPlant.SelectedIndex != -1)
            {
                plant = cmbPlant.Items[cmbPlant.SelectedIndex].ToString();
                lastChange = "plant";
                getDataSet();
                populateDataGrid();
            }
            
        }

        private void cmbCustommer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustommer.SelectedIndex != -1)
            {
                client = cmbCustommer.Items[cmbCustommer.SelectedIndex].ToString();
                lastChange = "client";
                getDataSet();
                populateDataGrid();
            }
            
        }

        private void cmbFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilm.SelectedIndex != -1)
            {
                film = cmbFilm.Items[cmbFilm.SelectedIndex].ToString();
                lastChange = "film";
                getDataSet();
                populateDataGrid();
            }
            
        }

        private void cmbWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbWidth.SelectedIndex != -1)
            {
                width = cmbWidth.Items[cmbWidth.SelectedIndex].ToString();
                lastChange = "width";
                getDataSet();
                populateDataGrid();
            }
           
        }

        private void cmbDiameter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDiameter.SelectedIndex != -1)
            {
                diam = cmbDiameter.Items[cmbDiameter.SelectedIndex].ToString();
                lastChange = "diam";
                getDataSet();
                populateDataGrid();
            }
           
        }

        private void cmbCore_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCore.SelectedIndex != -1)
            {
                core = cmbCore.Items[cmbCore.SelectedIndex].ToString();
                lastChange = "core";
                getDataSet();
                populateDataGrid();
            }
            
        }

        private void cmbNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNotes.SelectedIndex != -1)
            {
                obs = cmbNotes.Items[cmbNotes.SelectedIndex].ToString();
                lastChange = "obs";
                getDataSet();
                populateDataGrid();
            }
            
        }

        //Cuando se apreta Backspace en un combo, se borra el texto, la variable, el ultimo cambio y se vuelve a obtener dataset y popular
        private void cmbExecutive_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbExecutive.ResetText();
                executive = string.Empty;
                lastChange = string.Empty;
                getDataSet();
                populateDataGrid();
            }
        }

        private void cmbOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbOrder.ResetText();
                saleorder = string.Empty;
                lastChange = string.Empty;
                getDataSet();
                populateDataGrid();
            }
        }

        private void cmbPlant_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbPlant.ResetText();
                plant = string.Empty;
                lastChange = string.Empty;
                getDataSet();
                populateDataGrid();
            }
        }

        private void cmbCustommer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbCustommer.ResetText();
                client = string.Empty;
                lastChange = string.Empty;
                getDataSet();
                populateDataGrid();
            }
        }

        private void cmbFilm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbFilm.ResetText();
                film = string.Empty;
                lastChange = string.Empty;
                getDataSet();
                populateDataGrid();
            }
        }

        private void cmbWidth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbWidth.ResetText();
                width = string.Empty;
                lastChange = string.Empty;
                getDataSet();
                populateDataGrid();
            }
        }

        private void cmbDiameter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbDiameter.ResetText();
                diam = string.Empty;
                lastChange = string.Empty;
                getDataSet();
                populateDataGrid();
            }
        }

        private void cmbCore_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbCore.ResetText();
                core = string.Empty;
                lastChange = string.Empty;
                getDataSet();
                populateDataGrid();
            }
        }

        private void cmbNotes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbNotes.ResetText();
                obs = string.Empty;
                lastChange = string.Empty;
                getDataSet();
                populateDataGrid();
            }
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                getDataSet();
                populateDataGrid();
            }
        }

        //Boton para deshacer cualquier filtro y volver a mostrar todo
        private void btnDeleteFilter_Click(object sender, EventArgs e)
        {
            executive = string.Empty;
            saleorder = string.Empty;
            plant = string.Empty;
            client = string.Empty;
            film = string.Empty;
            width = string.Empty;
            diam = string.Empty;
            core = string.Empty;
            obs = string.Empty;
            lastChange = string.Empty;

            getDataSet();
            populateDataGrid();
            cmbCustommer.ResetText();
            cmbFilm.ResetText();
            cmbPlant.ResetText();
            cmbCore.ResetText();
            cmbDiameter.ResetText();
            cmbExecutive.ResetText();
            cmbOrder.ResetText();
            cmbWidth.ResetText();
            cmbNotes.ResetText();

            cmbCustommer.SelectedIndex = -1;
            cmbFilm.SelectedIndex = -1;
            cmbPlant.SelectedIndex = -1;
            cmbCore.SelectedIndex = -1;
            cmbDiameter.SelectedIndex = -1;
            cmbExecutive.SelectedIndex = -1;
            cmbOrder.SelectedIndex = -1;
            cmbWidth.SelectedIndex = -1;
            cmbNotes.SelectedIndex = -1;
        }

        //Boton expo a Excel
        private void btnExport_Click(object sender, EventArgs e)
        {

            string ext = string.Empty;
            dgvSalesOrderHistory.Columns["clmDayIng"].Visible = true;
            dgvSalesOrderHistory.Columns["clmMonthIng"].Visible = true;
            dgvSalesOrderHistory.Columns["clmYearIng"].Visible = true;
            dgvSalesOrderHistory.Columns["clmHourIng"].Visible = true;
            dgvSalesOrderHistory.Columns["clmCreatedDate"].Visible = false;

            dgvSalesOrderHistory.Columns["clmDayEnt"].Visible = true;
            dgvSalesOrderHistory.Columns["clmMonthEnt"].Visible = true;
            dgvSalesOrderHistory.Columns["clmYearEnt"].Visible = true;
            dgvSalesOrderHistory.Columns["clmHourEnt"].Visible = true;
            dgvSalesOrderHistory.Columns["clmCompromiseDate"].Visible = false;

            dgvSalesOrderHistory.Columns["clmShippingDate"].Visible = false;
            dgvSalesOrderHistory.Columns["clmdayShipping"].Visible = true;
            dgvSalesOrderHistory.Columns["clmmonthShipping"].Visible = true;
            dgvSalesOrderHistory.Columns["clmyearShipping"].Visible = true;

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
                dgvSalesOrderHistory.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }

            /*try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
                worksheet.Name = "Listado de Historial de Pedidos";

                for (int i = 1; i < dgvSalesOrderHistory.Columns.Count + 1; i++)
                    worksheet.Cells[1, i] = dgvSalesOrderHistory.Columns[i - 1].HeaderText;

                for (int i = 0; i < dgvSalesOrderHistory.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvSalesOrderHistory.Columns.Count - 1; j++)
                    {
                        if (dgvSalesOrderHistory.Rows[i].Cells[j].Value != null)
                            worksheet.Cells[i + 2, j + 1] = dgvSalesOrderHistory.Rows[i].Cells[j].Value.ToString();
                    }
                }
                MessageBox.Show("Exportación Generada correctamente", "Listado de Historial de Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Listado de Historial de Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

            dgvSalesOrderHistory.Columns["clmDayIng"].Visible = false;
            dgvSalesOrderHistory.Columns["clmMonthIng"].Visible = false;
            dgvSalesOrderHistory.Columns["clmYearIng"].Visible = false;
            dgvSalesOrderHistory.Columns["clmHourIng"].Visible = false;
            dgvSalesOrderHistory.Columns["clmCreatedDate"].Visible = true;

            dgvSalesOrderHistory.Columns["clmDayEnt"].Visible = false;
            dgvSalesOrderHistory.Columns["clmMonthEnt"].Visible = false;
            dgvSalesOrderHistory.Columns["clmYearEnt"].Visible = false;
            dgvSalesOrderHistory.Columns["clmHourEnt"].Visible = false;
            dgvSalesOrderHistory.Columns["clmCompromiseDate"].Visible = true;

            dgvSalesOrderHistory.Columns["clmShippingDate"].Visible = true;
            dgvSalesOrderHistory.Columns["clmdayShipping"].Visible = false;
            dgvSalesOrderHistory.Columns["clmmonthShipping"].Visible = false;
            dgvSalesOrderHistory.Columns["clmyearShipping"].Visible = false;
        }

        private void copyAlltoClipboard()
        {
            dgvSalesOrderHistory.SelectAll();
            DataObject dataObj = dgvSalesOrderHistory.GetClipboardContent();
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




        private void dgvSalesOrderHistory_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == clmDeliveredQuantity.Index)
            {
                frmDeliveredQuantity form = new frmDeliveredQuantity(Convert.ToInt32(dgvSalesOrderHistory.Rows[e.RowIndex].Cells[clmCodsec.Index].Value));
                form.MdiParent = this.MdiParent;
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Show();
            }
        }





    }
}