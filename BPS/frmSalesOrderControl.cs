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
    public partial class frmSalesOrderControl : Form
    {
        DataSet DS = new DataSet();
        DataSet DS2 = new DataSet();
        string executive = string.Empty;
        string saleorder = string.Empty;
        string plant = string.Empty;
        string client = string.Empty;
        string film = string.Empty;
        string width = string.Empty;
        string diam = string.Empty;
        string core = string.Empty;
        string obs = string.Empty;
        string occ = string.Empty;
        string lastChange = string.Empty;

        public frmSalesOrderControl()
        {
            InitializeComponent();
            getDataSet();
            populateDataGrid();
        }

        public void getDataSet()
        {
            DS = clsConnection.getDataSetResult("SELECT * FROM vwSalesOrderControl");
        }

        public void getDataSet2(int number)
        {
            DS2 = clsConnection.getDataSetResult("CALL spGetPalletListBySalesOrderDetail(" + number.ToString() + ")");
        }

        #region Populate DGV

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
            List<string> occlientes = new List<string>();
            double Kgs = 0;
            double TotalPending = 0;
            clsSalesOrderDetail objsod = new clsSalesOrderDetail();

            dgvSalesOrderControl.Rows.Clear();
            if (lastChange != "executive")
            {
                cmbExecutiveSalesOrderControl.Items.Clear();
            }
            if (lastChange != "saleorder")
            {
                cmbOrderSalesOrderControl.Items.Clear();
            }
            if (lastChange != "plant")
            {
                cmbPlantSalesOrderControl.Items.Clear();
            }
            if (lastChange != "client")
            {
                cmbCustomerSalesOrderControl.Items.Clear();
            }
            if (lastChange != "film")
            {
                cmbFilmSalesOrderControl.Items.Clear();
            }
            if (lastChange != "width")
            {
                cmbWidthSalesOrderControl.Items.Clear();
            }
            if (lastChange != "diam")
            {
                cmbDiameterSalesOrderControl.Items.Clear();
            }
            if (lastChange != "core")
            {
                cmbCoreSalesOrderControl.Items.Clear();
            }
            if (lastChange != "obs")
            {
                cmbObs.Items.Clear();
            }
            if (lastChange != "occ")
            {
                cmbOCCliente.Items.Clear();
            }

            dgvSalesOrderControl.Rows.Clear();
            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    string concat = executive + saleorder + plant + client + film + width + diam + core + obs + occ;
                    string concat2 = string.Empty;
                    if (executive != string.Empty)
                    {
                        concat2 = DS.Tables[0].Rows[i]["EjecutivoDeCuentas"].ToString();
                    }
                    if (saleorder != string.Empty)
                    {
                        concat2 += DS.Tables[0].Rows[i]["codsec"].ToString();
                    }
                    if (plant != string.Empty)
                    {
                        concat2 += DS.Tables[0].Rows[i]["Planta"].ToString();
                    }
                    if (client != string.Empty)
                    {
                        concat2 += DS.Tables[0].Rows[i]["Cliente"].ToString();
                    }
                    if (film != string.Empty)
                    {
                        concat2 += DS.Tables[0].Rows[i]["Pelicula"].ToString();
                    }
                    if (width != string.Empty)
                    {
                        concat2 += Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Ancho"]), 2).ToString();
                    }
                    if (diam != string.Empty)
                    {
                        concat2 += DS.Tables[0].Rows[i]["Diametro"].ToString();
                    }
                    if (core != string.Empty)
                    {
                        concat2 += DS.Tables[0].Rows[i]["Core"].ToString();
                    }
                    if (obs != string.Empty)
                    {
                        concat2 += DS.Tables[0].Rows[i]["Observaciones"].ToString();
                    }
                    if (occ != string.Empty)
                    {
                        concat2 += DS.Tables[0].Rows[i]["OCCliente"].ToString();
                    }
                    if (concat == concat2)
                    {
                        dgvSalesOrderControl.Rows.Add();
                        int fila = dgvSalesOrderControl.Rows.Count - 1;
                        dgvSalesOrderControl.Rows[fila].Cells["clmCodsec"].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["codsec"]);
                        dgvSalesOrderControl.Rows[fila].Cells["clmExecutive"].Value = DS.Tables[0].Rows[i]["EjecutivoDeCuentas"].ToString();
                        dgvSalesOrderControl.Rows[fila].Cells["clmOrder"].Value = DS.Tables[0].Rows[i]["Pedido"].ToString();
                        dgvSalesOrderControl.Rows[fila].Cells["clmPlant"].Value = DS.Tables[0].Rows[i]["Planta"].ToString();
                        dgvSalesOrderControl.Rows[fila].Cells["clmCreatedDate"].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaIngreso"]).ToString("dd/MM/yyyy");
                        // Agregado para el cambio de Fecha, por la movida de que excel nos lo da vuelta (GOD BLESS MICROSOFT ¬¬) INGRESO
                        dgvSalesOrderControl.Rows[fila].Cells[clmDayIng.Index].Value = DS.Tables[0].Rows[i]["dayFechaIngreso"];
                        dgvSalesOrderControl.Rows[fila].Cells[clmMonthIng.Index].Value = DS.Tables[0].Rows[i]["monthFechaIngreso"];
                        dgvSalesOrderControl.Rows[fila].Cells[clmYearIng.Index].Value = DS.Tables[0].Rows[i]["yearFechaIngreso"];
                        dgvSalesOrderControl.Rows[fila].Cells[clmHourIng.Index].Value = DS.Tables[0].Rows[i]["HoraIngreso"];
                        // Aca termina
                        dgvSalesOrderControl.Rows[fila].Cells["clmCompromiseDate"].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaEntrega2"]).ToString("dd/MM/yyyy");
                        // Agregado para el cambio de Fecha, por la movida de que excel nos lo da vuelta (GOD BLESS MICROSOFT ¬¬) ENTREGA
                        dgvSalesOrderControl.Rows[fila].Cells[clmDayEnt.Index].Value = DS.Tables[0].Rows[i]["dayFechaEntrega"];
                        dgvSalesOrderControl.Rows[fila].Cells[clmMonthEnt.Index].Value = DS.Tables[0].Rows[i]["monthFechaEntrega"];
                        dgvSalesOrderControl.Rows[fila].Cells[clmYearEnt.Index].Value = DS.Tables[0].Rows[i]["yearFechaEntrega"];
                        dgvSalesOrderControl.Rows[fila].Cells[clmHourEnt.Index].Value = DS.Tables[0].Rows[i]["HoraEntrega"];
                        // Aca termina
                        
                        if (Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaComprometida"]).ToString("dd/MM/yyyy") != "01/01/1900")
                        {
                            dgvSalesOrderControl.Rows[fila].Cells[clmCompDate.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaComprometida"]).ToString("dd/MM/yyyy");
                            // Agregado para el cambio de Fecha, por la movida de que excel nos lo da vuelta (GOD BLESS MICROSOFT ¬¬) COMPROMETIDA
                            dgvSalesOrderControl.Rows[fila].Cells[clmDayComp.Index].Value = DS.Tables[0].Rows[i]["dayFechaComprometida"];
                            dgvSalesOrderControl.Rows[fila].Cells[clmMonthComp.Index].Value = DS.Tables[0].Rows[i]["monthFechaComprometida"];
                            dgvSalesOrderControl.Rows[fila].Cells[clmYearComp.Index].Value = DS.Tables[0].Rows[i]["yearFechaComprometida"];
                            dgvSalesOrderControl.Rows[fila].Cells[clmHourComp.Index].Value = DS.Tables[0].Rows[i]["HoraComprometida"];
                            // Aca termina.
                        }

                        if (Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaOtif"]).ToString("dd/MM/yyyy") != "01/01/1900")
                        {
                            dgvSalesOrderControl.Rows[fila].Cells[fechaOtif.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaOtif"]).ToString("dd/MM/yyyy");
                            // Agregado para el cambio de Fecha, por la movida de que excel nos lo da vuelta (GOD BLESS MICROSOFT ¬¬) COMPROMETIDA
                            dgvSalesOrderControl.Rows[fila].Cells[clmDayOtif.Index].Value = DS.Tables[0].Rows[i]["dayFechaOtif"];
                            dgvSalesOrderControl.Rows[fila].Cells[clmMonthOtif.Index].Value = DS.Tables[0].Rows[i]["monthFechaOtif"];
                            dgvSalesOrderControl.Rows[fila].Cells[clmYearOtif.Index].Value = DS.Tables[0].Rows[i]["yearFechaOtif"];
                            // Aca termina.
                        }

                        if (Convert.ToBoolean(DS.Tables[0].Rows[i]["fueCompletado"]))
                        {
                            if (Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaComplecion"]).ToString("dd/MM/yyyy") != "01/01/1900")
                            {
                                dgvSalesOrderControl.Rows[fila].Cells["estaCompleto"].Value = Convert.ToBoolean(DS.Tables[0].Rows[i]["fueCompletado"]);
                                dgvSalesOrderControl.Rows[fila].Cells[fechaComplecion.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaComplecion"]).ToString("dd/MM/yyyy");
                                // Agregado para el cambio de Fecha, por la movida de que excel nos lo da vuelta (GOD BLESS MICROSOFT ¬¬) COMPROMETIDA
                                dgvSalesOrderControl.Rows[fila].Cells[clmDayComplecion.Index].Value = DS.Tables[0].Rows[i]["dayFechaComplecion"];
                                dgvSalesOrderControl.Rows[fila].Cells[clmMonthComplecion.Index].Value = DS.Tables[0].Rows[i]["monthFechaComplecion"];
                                dgvSalesOrderControl.Rows[fila].Cells[clmYearComplecion.Index].Value = DS.Tables[0].Rows[i]["yearFechaComplecion"];
                                // Aca termina.
                            }
                        }


                        dgvSalesOrderControl.Rows[fila].Cells["clmCustomer"].Value = DS.Tables[0].Rows[i]["Cliente"].ToString();
                        dgvSalesOrderControl.Rows[fila].Cells["clmPurchaseOrder"].Value = DS.Tables[0].Rows[i]["OCCliente"].ToString();
                        dgvSalesOrderControl.Rows[fila].Cells["clmFilm"].Value = DS.Tables[0].Rows[i]["Pelicula"].ToString();
                        dgvSalesOrderControl.Rows[fila].Cells["clmWidth"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Ancho"]), 2);
                        dgvSalesOrderControl.Rows[fila].Cells["clmDiameter"].Value = DS.Tables[0].Rows[i]["Diametro"].ToString();
                        dgvSalesOrderControl.Rows[fila].Cells["clmCore"].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["Core"]);
                        dgvSalesOrderControl.Rows[fila].Cells["clmQuantity"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadSolicitada"]), 2);
                        if (Convert.ToDouble(dgvSalesOrderControl.Rows[fila].Cells["clmQuantity"].Value) < 1000)
                        {
                            dgvSalesOrderControl.Rows[fila].Cells["clmQuantity"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadSolicitada"]), 2).ToString("0.00");
                        }
                        else
                        {
                            dgvSalesOrderControl.Rows[fila].Cells["clmQuantity"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadSolicitada"]), 2).ToString("0,000.00");
                        }

                        dgvSalesOrderControl.Rows[fila].Cells["clmUnpaletisedQuantity"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadSinPaletizar"]), 2);

                        if (Convert.ToDouble(dgvSalesOrderControl.Rows[fila].Cells["clmUnpaletisedQuantity"].Value) < 1000)
                        {
                            dgvSalesOrderControl.Rows[fila].Cells["clmUnpaletisedQuantity"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadSinPaletizar"]), 2).ToString("0.00");
                        }
                        else
                        {
                            dgvSalesOrderControl.Rows[fila].Cells["clmUnpaletisedQuantity"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadSinPaletizar"]), 2).ToString("0,000.00");
                        }

                        dgvSalesOrderControl.Rows[fila].Cells["clmPalletisedQuantityUnavialable"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadPaletizadaNoDisponible"]), 2);
                        if (Convert.ToDouble(dgvSalesOrderControl.Rows[fila].Cells["clmPalletisedQuantityUnavialable"].Value) < 1000)
                        {
                            dgvSalesOrderControl.Rows[fila].Cells["clmPalletisedQuantityUnavialable"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadPaletizadaNoDisponible"]), 2).ToString("0.00");
                        }
                        else
                        {
                            dgvSalesOrderControl.Rows[fila].Cells["clmPalletisedQuantityUnavialable"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadPaletizadaNoDisponible"]), 2).ToString("0,000.00");
                        }

                        dgvSalesOrderControl.Rows[fila].Cells["clmPalletisedQuantityAvialable"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadPaletizadaDisponible"]), 2);
                        if (Convert.ToDouble(dgvSalesOrderControl.Rows[fila].Cells["clmPalletisedQuantityAvialable"].Value) < 1000)
                        {
                            dgvSalesOrderControl.Rows[fila].Cells["clmPalletisedQuantityAvialable"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadPaletizadaDisponible"]), 2).ToString("0.00");
                        }
                        else
                        {
                            dgvSalesOrderControl.Rows[fila].Cells["clmPalletisedQuantityAvialable"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadPaletizadaDisponible"]), 2).ToString("0,000.00");
                        }

                        dgvSalesOrderControl.Rows[fila].Cells["clmPendingDeliveredQuantity"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["PendienteEntrega"]), 2);
                        if (Convert.ToDouble(dgvSalesOrderControl.Rows[fila].Cells["clmPendingDeliveredQuantity"].Value) < 1000)
                        {
                            dgvSalesOrderControl.Rows[fila].Cells["clmPendingDeliveredQuantity"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["PendienteEntrega"]), 2).ToString("0.00");
                        }
                        else
                        {
                            dgvSalesOrderControl.Rows[fila].Cells["clmPendingDeliveredQuantity"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["PendienteEntrega"]), 2).ToString("0,000.00");
                        }

                        dgvSalesOrderControl.Rows[fila].Cells["clmPrice"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Precio"]), 2);
                        if (Convert.ToDouble(dgvSalesOrderControl.Rows[fila].Cells["clmPrice"].Value) < 1000)
                        {
                            dgvSalesOrderControl.Rows[fila].Cells["clmPrice"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Precio"]), 2).ToString("0.00");
                        }
                        else
                        {
                            dgvSalesOrderControl.Rows[fila].Cells["clmPrice"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Precio"]), 2).ToString("0,000.00");
                        }

                        dgvSalesOrderControl.Rows[fila].Cells["clmTdC"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["TipoDeCambio"]), 2);
                        if (Convert.ToDouble(dgvSalesOrderControl.Rows[fila].Cells["clmTdC"].Value) < 1000)
                        {
                            dgvSalesOrderControl.Rows[fila].Cells["clmTdC"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["TipoDeCambio"]), 2).ToString("0.00");
                        }
                        else
                        {
                            dgvSalesOrderControl.Rows[fila].Cells["clmTdC"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["TipoDeCambio"]), 2).ToString("0,000.00");
                        }

                        dgvSalesOrderControl.Rows[fila].Cells["clmPendingMoney"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["PendienteAR$"]), 2).ToString("0,000.00");
                        if (Convert.ToDouble(dgvSalesOrderControl.Rows[fila].Cells["clmPendingMoney"].Value) < 1000)
                        {
                            dgvSalesOrderControl.Rows[fila].Cells["clmPendingMoney"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["PendienteAR$"]), 2).ToString("0.00");
                        }
                        else
                        {
                            dgvSalesOrderControl.Rows[fila].Cells["clmPendingMoney"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["PendienteAR$"]), 2).ToString("0,000.00");
                        }

                        dgvSalesOrderControl.Rows[fila].Cells["clmPendingMoneyUSD"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["PendienteUSD"]), 2);
                        if (Convert.ToDouble(dgvSalesOrderControl.Rows[fila].Cells["clmPendingMoneyUSD"].Value) < 1000)
                        {
                            dgvSalesOrderControl.Rows[fila].Cells["clmPendingMoneyUSD"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["PendienteUSD"]), 2).ToString("0.00");
                        }
                        else
                        {
                            dgvSalesOrderControl.Rows[fila].Cells["clmPendingMoneyUSD"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["PendienteUSD"]), 2).ToString("0,000.00");
                        }

                        dgvSalesOrderControl.Rows[fila].Cells["clmObservations"].Value = DS.Tables[0].Rows[i]["Observaciones"].ToString();
                        dgvSalesOrderControl.Rows[fila].Cells["clmStatus"].Value = DS.Tables[0].Rows[i]["Estado"].ToString();

                        dgvSalesOrderControl.Rows[fila].Cells["clmDeliveredQuantity"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadEntregada"]), 2);
                        if (Convert.ToDouble(dgvSalesOrderControl.Rows[fila].Cells["clmDeliveredQuantity"].Value) < 1000)
                        {
                            dgvSalesOrderControl.Rows[fila].Cells["clmDeliveredQuantity"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadEntregada"]), 2).ToString("0.00");
                        }
                        else
                        {
                            dgvSalesOrderControl.Rows[fila].Cells["clmDeliveredQuantity"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadEntregada"]), 2).ToString("0,000.00");
                        }

                        dgvSalesOrderControl.Rows[fila].Cells["clmProgrammedQuantity"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadProgramada"]), 2).ToString("0,000.00");
                        if (Convert.ToDouble(dgvSalesOrderControl.Rows[fila].Cells["clmProgrammedQuantity"].Value) < 1000)
                        {
                            dgvSalesOrderControl.Rows[fila].Cells["clmProgrammedQuantity"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadProgramada"]), 2).ToString("0.00");
                        }
                        else
                        {
                            dgvSalesOrderControl.Rows[fila].Cells["clmProgrammedQuantity"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadProgramada"]), 2).ToString("0,000.00");
                        }
                        if (Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadPredespachada"])<1000)
                        {
                            dgvSalesOrderControl.Rows[fila].Cells[predespachado.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadPredespachada"]), 2).ToString("0.00");
                        }
                        else
                        {
                            dgvSalesOrderControl.Rows[fila].Cells[predespachado.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadPredespachada"]), 2).ToString("0,000.00");
                        }
                        

                        if (!executives.Contains(DS.Tables[0].Rows[i]["EjecutivoDeCuentas"].ToString()))
                            executives.Add(DS.Tables[0].Rows[i]["EjecutivoDeCuentas"].ToString());

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

                        if (!occlientes.Contains(DS.Tables[0].Rows[i]["OCCliente"].ToString()))
                            occlientes.Add(DS.Tables[0].Rows[i]["OCCliente"].ToString());

                        Kgs += Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["PendienteEntrega"]), 2);
                        TotalPending += Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["PendienteAR$"]), 2);
                    }
                }
                if (Kgs >= 1000)
                {
                    txtKgsSalesOrderControl.Text = Kgs.ToString("0,000.00");
                }
                else
                {
                    txtKgsSalesOrderControl.Text = Kgs.ToString("00.00");
                }
                if (TotalPending >= 1000)
                {
                    txtTotalPendingSalesOrderControl.Text = TotalPending.ToString("0,000.00");
                }
                else
                {
                    txtTotalPendingSalesOrderControl.Text = TotalPending.ToString("00.00");
                }



                executives.Sort();
                cod.Sort();
                plants.Sort();
                customers.Sort();
                films.Sort();
                widths.Sort();
                diameters.Sort();
                cores.Sort();
                notes.Sort();
                occlientes.Sort();

                if (lastChange != "executive")
                {
                    for (int i = 0; i < executives.Count; i++)
                    {
                        cmbExecutiveSalesOrderControl.Items.Add(executives[i]);
                    }
                }


                if (lastChange != "saleorder")
                {
                    for (int i = 0; i < cod.Count; i++)
                    {
                        cmbOrderSalesOrderControl.Items.Add(cod[i]);
                    }
                }


                if (lastChange != "plant")
                {
                    for (int i = 0; i < plants.Count; i++)
                    {
                        cmbPlantSalesOrderControl.Items.Add(plants[i]);
                    }
                }


                if (lastChange != "client")
                {
                    for (int i = 0; i < customers.Count; i++)
                    {
                        cmbCustomerSalesOrderControl.Items.Add(customers[i]);
                    }
                }


                if (lastChange != "film")
                {
                    for (int i = 0; i < films.Count; i++)
                    {
                        cmbFilmSalesOrderControl.Items.Add(films[i]);
                    }
                }


                if (lastChange != "width")
                {
                    for (int i = 0; i < widths.Count; i++)
                    {
                        cmbWidthSalesOrderControl.Items.Add(widths[i]);
                    }
                }

                if (lastChange != "diam")
                {
                    for (int i = 0; i < diameters.Count; i++)
                    {
                        cmbDiameterSalesOrderControl.Items.Add(diameters[i]);
                    }
                }

                if (lastChange != "core")
                {
                    for (int i = 0; i < cores.Count; i++)
                    {
                        cmbCoreSalesOrderControl.Items.Add(cores[i]);
                    }
                }

                if (lastChange != "obs")
                {
                    for (int i = 0; i < notes.Count; i++)
                    {
                        cmbObs.Items.Add(notes[i]);
                    }
                }

                if (lastChange != "occ")
                {
                    for (int i = 0; i < occlientes.Count; i++)
                    {
                        cmbOCCliente.Items.Add(occlientes[i]);
                    }
                }


            }
        }

        #endregion

        #region Eventos del Formulario

        private void chkSelectAllSalesOrderControl_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelectAllSalesOrderControl.Checked)
            {
                for (int i = 0; i < dgvSalesOrderControl.Rows.Count; i++)
                {
                    dgvSalesOrderControl.Rows[i].Cells[clmCheck.Index].Value = true;
                }
            }
            else
            {
                for (int i = 0; i < dgvSalesOrderControl.Rows.Count; i++)
                {
                    dgvSalesOrderControl.Rows[i].Cells[clmCheck.Index].Value = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
            occ = string.Empty;

            getDataSet();
            populateDataGrid();
            cmbCustomerSalesOrderControl.ResetText();
            cmbFilmSalesOrderControl.ResetText();
            cmbPlantSalesOrderControl.ResetText();
            cmbCoreSalesOrderControl.ResetText();
            cmbDiameterSalesOrderControl.ResetText();
            cmbExecutiveSalesOrderControl.ResetText();
            cmbOrderSalesOrderControl.ResetText();
            cmbWidthSalesOrderControl.ResetText();
            cmbObs.ResetText();
            cmbOCCliente.ResetText();

            cmbCustomerSalesOrderControl.SelectedIndex = -1;
            cmbFilmSalesOrderControl.SelectedIndex = -1;
            cmbPlantSalesOrderControl.SelectedIndex = -1;
            cmbCoreSalesOrderControl.SelectedIndex = -1;
            cmbDiameterSalesOrderControl.SelectedIndex = -1;
            cmbExecutiveSalesOrderControl.SelectedIndex = -1;
            cmbOrderSalesOrderControl.SelectedIndex = -1;
            cmbWidthSalesOrderControl.SelectedIndex = -1;
            cmbObs.SelectedIndex = -1;
            cmbOCCliente.SelectedIndex = -1;
        }

        private void btnStatusSalesOrderControl_Click(object sender, EventArgs e)
        {

            if (cmbCustomerSalesOrderControl.SelectedIndex != -1)
            {
                string name = cmbCustomerSalesOrderControl.SelectedItem.ToString();

                frmMaterialStatus winSystemConfig = new frmMaterialStatus(name);
                winSystemConfig.StartPosition = FormStartPosition.Manual;
                winSystemConfig.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Cliente", "Estado de Materiales", MessageBoxButtons.OK);
            }

        }

        private void btnNewOrderSalesOrderControl_Click(object sender, EventArgs e)
        {
            frmNewOrdersEntry winSalesOrderForm = new frmNewOrdersEntry();
            winSalesOrderForm.StartPosition = FormStartPosition.Manual;
            winSalesOrderForm.Show();
        }

        private void dgvSalesOrderControl_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            double PendingQuantity = 0;
            PendingQuantity = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[e.RowIndex]["CantidadSolicitada"]), 2) - Math.Round(Convert.ToDouble(DS.Tables[0].Rows[e.RowIndex]["CantidadPaletizadaNoDisponible"]), 2) - Math.Round(Convert.ToDouble(DS.Tables[0].Rows[e.RowIndex]["CantidadPaletizadaDisponible"]), 2) - Math.Round(Convert.ToDouble(DS.Tables[0].Rows[e.RowIndex]["CantidadEntregada"]), 2) - Math.Round(Convert.ToDouble(DS.Tables[0].Rows[e.RowIndex]["CantidadSinPaletizar"]), 2);
            if (e.ColumnIndex == clmPalletisedQuantityAvialable.Index) // se verifica qye haya hecho doble clic sobre la celda "Paletizado Disponible" y abre el formulario de reasignaciones
            {
                //if(clsGlobal.LoggedUser.fkRole==1 || clsGlobal.LoggedUser.fkRole==9)
                //{
                    frmReassign generateNewReport = new frmReassign(Convert.ToInt32(dgvSalesOrderControl.Rows[e.RowIndex].Cells[clmCodsec.Index].Value), PendingQuantity, dgvSalesOrderControl.Rows[e.RowIndex].Cells[clmPlant.Index].Value.ToString());
                    generateNewReport.StartPosition = FormStartPosition.CenterScreen;
                    generateNewReport.MaximizeBox = false;
                    generateNewReport.ShowDialog();
                    getDataSet();
                    populateDataGrid();
                //}
                //else
                //{
                //    MessageBox.Show("Su nivel de permisos no le permite realizar esta acción.", "Control de pedidos", MessageBoxButtons.OK);
                //}
            }
            if (e.ColumnIndex == clmCodsec.Index)
            {
                frmNewOrdersEntry form = new frmNewOrdersEntry(new clsSalesOrderDetail(Convert.ToInt32(dgvSalesOrderControl.Rows[e.RowIndex].Cells[clmCodsec.Index].Value)).fkSalesOrder, this);
                form.MdiParent = this.MdiParent;
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Show();
            }

            if (e.ColumnIndex == clmPalletisedQuantityUnavialable.Index)
            {
                frmUnavailablePalletizedPallets form = new frmUnavailablePalletizedPallets(Convert.ToInt32(dgvSalesOrderControl.Rows[e.RowIndex].Cells[clmCodsec.Index].Value));
                form.MdiParent = this.MdiParent;
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Show();
            }

            if (e.ColumnIndex == clmDeliveredQuantity.Index)
            {
                frmDeliveredQuantity form = new frmDeliveredQuantity(Convert.ToInt32(dgvSalesOrderControl.Rows[e.RowIndex].Cells[clmCodsec.Index].Value));
                form.MdiParent = this.MdiParent;
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Show();
            }


        }

        private void btnPriceSalesOrderControl_Click(object sender, EventArgs e)
        {
            clsSalesOrderDetail prc = new clsSalesOrderDetail();
            double price = 0;
           
            if (txtPriceSalesOrderControl.Text != string.Empty)
            {
                price = Convert.ToDouble(txtPriceSalesOrderControl.Text);
                if (dgvSalesOrderControl.Rows.Count > 0)
                {
                    for (int i = 0; i < dgvSalesOrderControl.Rows.Count; i++)
                    {
                        if (Convert.ToBoolean(dgvSalesOrderControl.Rows[i].Cells[clmCheck.Index].Value))
                        {
                            dgvSalesOrderControl.Rows[i].Cells["clmPrice"].Value = txtPriceSalesOrderControl.Text;
                            prc = new clsSalesOrderDetail(Convert.ToInt32(dgvSalesOrderControl.Rows[i].Cells[clmCodsec.Index].Value));
                            prc.updatePrice(price);
                        }

                    }

                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un precio","Inconveniente",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            txtPriceSalesOrderControl.Clear();
            getDataSet();
            populateDataGrid();
        }

        private void btnTDCSalesOrderControl_Click(object sender, EventArgs e)
        {
            clsSalesOrderDetail TdC = new clsSalesOrderDetail();
            double exchangerate = 0;
            exchangerate = Convert.ToDouble(txtExchangeRateSalesOrderControl.Text);

            if (txtExchangeRateSalesOrderControl.Text != string.Empty)
            {
                if (dgvSalesOrderControl.Rows.Count > 0)
                {
                    for (int i = 0; i < dgvSalesOrderControl.Rows.Count; i++)
                    {
                        if (Convert.ToBoolean(dgvSalesOrderControl.Rows[i].Cells[clmCheck.Index].Value))
                        {
                            dgvSalesOrderControl.Rows[i].Cells["clmTdC"].Value = txtExchangeRateSalesOrderControl.Text;
                            TdC = new clsSalesOrderDetail(Convert.ToInt32(dgvSalesOrderControl.Rows[i].Cells[clmCodsec.Index].Value));
                            TdC.updateExchangerate(exchangerate);
                        }

                    }

                }
            }
            txtExchangeRateSalesOrderControl.Clear();
            getDataSet();
            populateDataGrid();
        }

        private void btnCancelSalesOrderControl_Click(object sender, EventArgs e) //Anular
        {
            List<clsPallet> toStock = new List<clsPallet>();
            clsSalesOrderDetail statusCancel = new clsSalesOrderDetail();

            for (int i = 0; i < dgvSalesOrderControl.Rows.Count; i++)
            {
                getDataSet2(Convert.ToInt32(dgvSalesOrderControl.Rows[i].Cells["clmCodsec"].Value));
                if (Convert.ToBoolean(dgvSalesOrderControl.Rows[i].Cells[clmCheck.Index].Value))
                {
                    if (!tieneMaterial(i))
                    {
                        statusCancel = new clsSalesOrderDetail(Convert.ToInt32(dgvSalesOrderControl.Rows[i].Cells[clmCodsec.Index].Value));
                        statusCancel.changeStatus(3065);
                    }
                    else
                    {
                        MessageBox.Show("No se puede realizar la acción solicitada porque el pedido tiene material asignado.", "Control de pedidos", MessageBoxButtons.OK);
                    }
                    /*if (DS2.Tables[0].Rows.Count > 0)
                    {
                        for (int l = 0; l < DS2.Tables[0].Rows.Count; l++)
                        {
                            clsPallet objpallet = new clsPallet(Convert.ToInt32(DS2.Tables[0].Rows[l]["plt_codsec"]));

                            if (!toStock.Contains(objpallet))
                            {
                                toStock.Add(objpallet);
                            }
                        }
                    }

                    statusCancel = new clsSalesOrderDetail(Convert.ToInt32(dgvSalesOrderControl.Rows[i].Cells[clmCodsec.Index].Value));

                    if (statusCancel.cancelAvailable())
                    {
                        statusCancel.changeStatus(3065);

                        for (int k = 0; k < toStock.Count; k++)
                        {
                            for (int j = 0; j < toStock[k].lstCoil.Count; j++)
                            {
                                clsCoil.assignToSalesOrder(toStock[k].lstCoil[j].codsec, 0);
                            }
                            clsReassign objrea = new clsReassign();
                            objrea.fkOldSalesOrderDetail = toStock[k].fkSalesOrderDetail;
                            objrea.fkNewSalesOrderDetail = 0;
                            objrea.fkPallet = toStock[k].codsec;
                            objrea.weigth = toStock[k].netWeight;
                            objrea.fkUser = clsGlobal.LoggedUser.codsec;
                            objrea.save();
                            clsPallet.assignPalletToSalesOrderDetail(toStock[k].codsec, 0);
                        }
                    }*/
                }

            }
            getDataSet();
            populateDataGrid();
        }

        private bool tieneMaterial(int indice)
        {
            if (Convert.ToDouble(dgvSalesOrderControl.Rows[indice].Cells["clmProgrammedQuantity"].Value)
                +Convert.ToDouble(dgvSalesOrderControl.Rows[indice].Cells["clmUnpaletisedQuantity"].Value)
                +Convert.ToDouble(dgvSalesOrderControl.Rows[indice].Cells["clmPalletisedQuantityUnavialable"].Value)
                +Convert.ToDouble(dgvSalesOrderControl.Rows[indice].Cells["clmPalletisedQuantityAvialable"].Value)
                +Convert.ToDouble(dgvSalesOrderControl.Rows[indice].Cells["predespachado"].Value)>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void btnCloseSalesOrderControl_Click(object sender, EventArgs e)//Cerrar
        {
            List<clsPallet> toStock = new List<clsPallet>();
            clsSalesOrderDetail statusClose = new clsSalesOrderDetail();

            for (int i = 0; i < dgvSalesOrderControl.Rows.Count; i++)
            {
                getDataSet2(Convert.ToInt32(dgvSalesOrderControl.Rows[i].Cells["clmCodsec"].Value));
                if (Convert.ToBoolean(dgvSalesOrderControl.Rows[i].Cells[clmCheck.Index].Value))
                {
                    if (!tieneMaterial(i))
                    {
                        statusClose = new clsSalesOrderDetail(Convert.ToInt32(dgvSalesOrderControl.Rows[i].Cells[clmCodsec.Index].Value));
                        statusClose.changeStatus(3064);
                    }
                    else
                    {
                        MessageBox.Show("No se puede realizar la acción solicitada porque el pedido tiene material asignado.", "Control de pedidos", MessageBoxButtons.OK);
                    }
                    /*if (DS2.Tables[0].Rows.Count > 0)
                    {
                        for (int l = 0; l < DS2.Tables[0].Rows.Count; l++)
                        {
                            clsPallet objpallet = new clsPallet(Convert.ToInt32(DS2.Tables[0].Rows[l]["plt_codsec"]));

                            if (!toStock.Contains(objpallet))
                            {
                                toStock.Add(objpallet);
                            }
                        }
                    }

                    statusClose = new clsSalesOrderDetail(Convert.ToInt32(dgvSalesOrderControl.Rows[i].Cells[clmCodsec.Index].Value));

                    if (statusClose.closeAvailable())
                    {
                        statusClose.changeStatus(3064);

                        for (int k = 0; k < toStock.Count; k++)
                        {
                            for (int j = 0; j < toStock[k].lstCoil.Count; j++)
                            {
                                clsCoil.assignToSalesOrder(toStock[k].lstCoil[j].codsec, 0);
                            }
                            clsReassign objrea = new clsReassign();
                            objrea.fkOldSalesOrderDetail = toStock[k].fkSalesOrderDetail;
                            objrea.fkNewSalesOrderDetail = 0;
                            objrea.fkPallet = toStock[k].codsec;
                            objrea.weigth = toStock[k].netWeight;
                            objrea.fkUser = clsGlobal.LoggedUser.codsec;
                            objrea.save();
                            clsPallet.assignPalletToSalesOrderDetail(toStock[k].codsec, 0);
                        }
                    }*/
                }
            }
            getDataSet();
            populateDataGrid();
        }

        private void btnDepositListSalesOrderControl_Click(object sender, EventArgs e)
        {
            List<int> sodList = new List<int>();
            List<double> priceList = new List<double>();
            List<double> exchangeList = new List<double>();
            List<string> POList = new List<string>();
            List<string> plantList = new List<string>();
            List<string> custommerList = new List<string>();


            for (int i = 0; i < dgvSalesOrderControl.Rows.Count; i++)
            {

                if (Convert.ToBoolean(dgvSalesOrderControl.Rows[i].Cells[clmCheck.Index].Value))
                {
                    sodList.Add(Convert.ToInt32(dgvSalesOrderControl.Rows[i].Cells[clmCodsec.Index].Value));
                    priceList.Add(Convert.ToDouble(dgvSalesOrderControl.Rows[i].Cells[clmPrice.Index].Value));
                    exchangeList.Add(Convert.ToDouble(dgvSalesOrderControl.Rows[i].Cells[clmTdC.Index].Value));
                    POList.Add(dgvSalesOrderControl.Rows[i].Cells[clmPurchaseOrder.Index].Value.ToString());
                    plantList.Add(dgvSalesOrderControl.Rows[i].Cells[clmPlant.Index].Value.ToString());
                    custommerList.Add(dgvSalesOrderControl.Rows[i].Cells[clmCustomer.Index].Value.ToString());
                }
            }

            // if (cmbPlantSalesOrderControl.SelectedItem == null)
            //{
            //    MessageBox.Show("Debe seleccionar una Planta", "Listado de Control de Pedidos", MessageBoxButtons.OK);
            //}
            //else if (cmbPlantSalesOrderControl.SelectedItem.ToString() == "Campana")
            //{
            frmDepositList winSystemConfig = new frmDepositList(sodList, priceList, exchangeList, POList, plantList, custommerList);
            winSystemConfig.StartPosition = FormStartPosition.Manual;
            winSystemConfig.Show();
            //}
            //else if (cmbPlantSalesOrderControl.SelectedItem.ToString() == "Pilar")
            //{
            //   frmDepositListPL winSystemConfig = new frmDepositListPL(sodList, priceList, exchangeList, POList, plantList, custommerList);
            //  winSystemConfig.StartPosition = FormStartPosition.Manual;
            // winSystemConfig.Show();
        }
        #endregion

        #region Exportar a Excel

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            List<String> listaFechaIngreso = new List<string>();
            List<String> listaFechasEntrega = new List<string>();
            

          /*  for (int i = 0; i < dgvSalesOrderControl.Rows.Count; i++ )
            {
                listaFechaIngreso.Add(dgvSalesOrderControl.Rows[i].Cells[clmCreatedDate.Index].Value.ToString());
                dgvSalesOrderControl.Rows[i].Cells[clmCreatedDate.Index].Value = Convert.ToDateTime(dgvSalesOrderControl.Rows[i].Cells[clmCreatedDate.Index].Value).ToString("MM/dd/yyyy HH:mm");
                listaFechasEntrega.Add(dgvSalesOrderControl.Rows[i].Cells[clmCompromiseDate.Index].Value.ToString());
                dgvSalesOrderControl.Rows[i].Cells[clmCompromiseDate.Index].Value = Convert.ToDateTime(dgvSalesOrderControl.Rows[i].Cells[clmCompromiseDate.Index].Value).ToString("MM/dd/yyyy HH:mm");
            }*/

            string ext = string.Empty;
            dgvSalesOrderControl.Columns["clmExecutive"].Visible = true;
            dgvSalesOrderControl.Columns["clmUnpaletisedQuantity"].Visible = true;
            dgvSalesOrderControl.Columns["clmPendingMoneyUSD"].Visible = true;
            dgvSalesOrderControl.Columns["clmCheck"].Visible = false;

            // Ingreso
            dgvSalesOrderControl.Columns["clmDayIng"].Visible = true;
            dgvSalesOrderControl.Columns["clmMonthIng"].Visible = true;
            dgvSalesOrderControl.Columns["clmYearIng"].Visible = true;
            dgvSalesOrderControl.Columns["clmHourIng"].Visible = true;
            dgvSalesOrderControl.Columns["clmCreatedDate"].Visible = false;

            // Entrega
            dgvSalesOrderControl.Columns["clmDayEnt"].Visible = true;
            dgvSalesOrderControl.Columns["clmMonthEnt"].Visible = true;
            dgvSalesOrderControl.Columns["clmYearEnt"].Visible = true;
            dgvSalesOrderControl.Columns["clmHourEnt"].Visible = true;
            dgvSalesOrderControl.Columns["clmCompromiseDate"].Visible = false;

            // Comprometida
            dgvSalesOrderControl.Columns["clmDayComp"].Visible = true;
            dgvSalesOrderControl.Columns["clmMonthComp"].Visible = true;
            dgvSalesOrderControl.Columns["clmYearComp"].Visible = true;
            dgvSalesOrderControl.Columns["clmHourComp"].Visible = true;
            dgvSalesOrderControl.Columns["clmCompDate"].Visible = false;

            // Otif
            dgvSalesOrderControl.Columns["clmDayOtif"].Visible = true;
            dgvSalesOrderControl.Columns["clmMonthOtif"].Visible = true;
            dgvSalesOrderControl.Columns["clmYearOtif"].Visible = true;
            dgvSalesOrderControl.Columns["fechaOtif"].Visible = false;

            // Complecion
            dgvSalesOrderControl.Columns["clmDayComplecion"].Visible = true;
            dgvSalesOrderControl.Columns["clmMonthComplecion"].Visible = true;
            dgvSalesOrderControl.Columns["clmYearComplecion"].Visible = true;
            dgvSalesOrderControl.Columns["fechaComplecion"].Visible = false;
            
            dgvSalesOrderControl.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;

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
                dgvSalesOrderControl.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
            dgvSalesOrderControl.Columns["clmExecutive"].Visible = false;
            dgvSalesOrderControl.Columns["clmCreatedDate"].Visible = false;
            dgvSalesOrderControl.Columns["clmUnpaletisedQuantity"].Visible = false;
            dgvSalesOrderControl.Columns["clmPendingMoneyUSD"].Visible = false;
            dgvSalesOrderControl.Columns["clmCheck"].Visible = true;
            dgvSalesOrderControl.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;

            /*for (int i = 0; i < dgvSalesOrderControl.Rows.Count; i++)
            {
                dgvSalesOrderControl.Rows[i].Cells[clmCreatedDate.Index].Value = Convert.ToDateTime(listaFechaIngreso[i].ToString());
                dgvSalesOrderControl.Rows[i].Cells[clmCompromiseDate.Index].Value = Convert.ToDateTime(listaFechasEntrega[i].ToString());
            } */

            // Ingreso
            dgvSalesOrderControl.Columns["clmDayIng"].Visible = false;
            dgvSalesOrderControl.Columns["clmMonthIng"].Visible = false;
            dgvSalesOrderControl.Columns["clmYearIng"].Visible = false;
            dgvSalesOrderControl.Columns["clmHourIng"].Visible = false;
            dgvSalesOrderControl.Columns["clmCreatedDate"].Visible = true;
            // Entrega
            dgvSalesOrderControl.Columns["clmDayEnt"].Visible = false;
            dgvSalesOrderControl.Columns["clmMonthEnt"].Visible = false;
            dgvSalesOrderControl.Columns["clmYearEnt"].Visible = false;
            dgvSalesOrderControl.Columns["clmHourEnt"].Visible = false;
            dgvSalesOrderControl.Columns["clmCompromiseDate"].Visible = true;

            // Comprometida
            dgvSalesOrderControl.Columns["clmDayComp"].Visible = false;
            dgvSalesOrderControl.Columns["clmMonthComp"].Visible = false;
            dgvSalesOrderControl.Columns["clmYearComp"].Visible = false;
            dgvSalesOrderControl.Columns["clmHourComp"].Visible = false;
            dgvSalesOrderControl.Columns["clmCompDate"].Visible = true;

            // Otif
            dgvSalesOrderControl.Columns["clmDayOtif"].Visible = false;
            dgvSalesOrderControl.Columns["clmMonthOtif"].Visible = false;
            dgvSalesOrderControl.Columns["clmYearOtif"].Visible = false;
            dgvSalesOrderControl.Columns["fechaOtif"].Visible = true;

            // Complecion
            dgvSalesOrderControl.Columns["clmDayComplecion"].Visible = false;
            dgvSalesOrderControl.Columns["clmMonthComplecion"].Visible = false;
            dgvSalesOrderControl.Columns["clmYearComplecion"].Visible = false;
            dgvSalesOrderControl.Columns["fechaComplecion"].Visible = true;
        }

        private void copyAlltoClipboard()
        {
            dgvSalesOrderControl.SelectAll();
            DataObject dataObj = dgvSalesOrderControl.GetClipboardContent();
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

        #endregion

        #region Eventos Formularios 2

        private void cmbExecutiveSalesOrderControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbExecutiveSalesOrderControl.SelectedIndex != -1)
            {
                if (executive != cmbExecutiveSalesOrderControl.SelectedItem.ToString())
                {
                    executive = cmbExecutiveSalesOrderControl.SelectedItem.ToString();
                    lastChange = "executive";
                    populateDataGrid();
                }
            }
            else
            {
                executive = string.Empty;
            }
        }

        private void cmbOrderSalesOrderControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrderSalesOrderControl.SelectedIndex != -1)
            {
                if (saleorder != cmbOrderSalesOrderControl.SelectedItem.ToString())
                {
                    saleorder = cmbOrderSalesOrderControl.SelectedItem.ToString();
                    lastChange = "saleorder";
                    populateDataGrid();
                }
            }
            else
            {
                saleorder = string.Empty;
            }
        }

        private void cmbPlantSalesOrderControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPlantSalesOrderControl.SelectedIndex != -1)
            {
                if (plant != cmbPlantSalesOrderControl.SelectedItem.ToString())
                {
                    plant = cmbPlantSalesOrderControl.SelectedItem.ToString();
                    lastChange = "plant";
                    populateDataGrid();
                }
            }
            else
            {
                plant = string.Empty;
            }
        }

        private void cmbCustomerSalesOrderControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomerSalesOrderControl.SelectedIndex != -1)
            {
                if (client != cmbCustomerSalesOrderControl.SelectedItem.ToString())
                {
                    client = cmbCustomerSalesOrderControl.SelectedItem.ToString();
                    lastChange = "client";
                    populateDataGrid();
                }
            }
            else
            {
                client = string.Empty;
            }
        }

        private void cmbFilmSalesOrderControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilmSalesOrderControl.SelectedIndex != -1)
            {
                if (film != cmbFilmSalesOrderControl.SelectedItem.ToString())
                {
                    film = cmbFilmSalesOrderControl.SelectedItem.ToString();
                    lastChange = "film";
                    populateDataGrid();
                }
            }
            else
            {
                film = string.Empty;
            }
        }

        private void cmbWidthSalesOrderControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbWidthSalesOrderControl.SelectedIndex != -1)
            {
                if (width != cmbWidthSalesOrderControl.SelectedItem.ToString())
                {
                    width = cmbWidthSalesOrderControl.SelectedItem.ToString();
                    lastChange = "width";
                    populateDataGrid();
                }
            }
            else
            {
                width = string.Empty;
            }
        }

        private void cmbDiameterSalesOrderControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDiameterSalesOrderControl.SelectedIndex != -1)
            {
                if (diam != cmbDiameterSalesOrderControl.SelectedItem.ToString())
                {
                    diam = cmbDiameterSalesOrderControl.SelectedItem.ToString();
                    lastChange = "diam";
                    populateDataGrid();
                }
            }
            else
            {
                diam = string.Empty;
            }
        }

        private void cmbCoreSalesOrderControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCoreSalesOrderControl.SelectedIndex != -1)
            {
                if (core != cmbCoreSalesOrderControl.SelectedItem.ToString())
                {
                    core = cmbCoreSalesOrderControl.SelectedItem.ToString();
                    lastChange = "core";
                    populateDataGrid();
                }
            }
            else
            {
                core = string.Empty;
            }
        }

        private void dgvSalesOrderControl_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex== clmPurchaseOrder.Index)
            {
                clsSalesOrder obj = new clsSalesOrder(Convert.ToInt32(dgvSalesOrderControl.Rows[e.RowIndex].Cells[clmOrder.Index].Value));

                if (dgvSalesOrderControl.Rows[e.RowIndex].Cells[clmPurchaseOrder.Index].Value != null)
                    obj.UpdateOc(dgvSalesOrderControl.Rows[e.RowIndex].Cells[clmPurchaseOrder.Index].Value.ToString());
                else
                    obj.UpdateOc("");

                List<string> purchaseOrder= new List<string>();

                for(int i=0; i<dgvSalesOrderControl.Rows.Count;i++)
                {
                    if(dgvSalesOrderControl.Rows[i].Cells[clmPurchaseOrder.Index].Value!=null)
                        purchaseOrder.Add(dgvSalesOrderControl.Rows[i].Cells[clmPurchaseOrder.Index].Value.ToString());
                }

                purchaseOrder.Sort();
                cmbOCCliente.Items.Clear();
                
                for(int i=0;i<purchaseOrder.Count;i++)
                    cmbOCCliente.Items.Add(purchaseOrder[i]);

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (DS.Tables[0].Rows[i]["Pedido"].ToString() == dgvSalesOrderControl.Rows[e.RowIndex].Cells[clmOrder.Index].Value.ToString())
                    {
                        if (dgvSalesOrderControl.Rows[e.RowIndex].Cells[clmPurchaseOrder.Index].Value != null)
                        {
                            DS.Tables[0].Rows[i]["OCCliente"] = dgvSalesOrderControl.Rows[e.RowIndex].Cells[clmPurchaseOrder.Index].Value.ToString();
                        }
                        else
                        {
                            DS.Tables[0].Rows[i]["OCCliente"] = string.Empty;
                        }
                    }
                }
            }
            if (e.ColumnIndex == clmObservations.Index)
            {
                clsSalesOrderDetail obj = new clsSalesOrderDetail(Convert.ToInt32(dgvSalesOrderControl.Rows[e.RowIndex].Cells[clmCodsec.Index].Value));
                if (dgvSalesOrderControl.Rows[e.RowIndex].Cells[clmObservations.Index].Value != null)
                {
                    obj.updateObs(dgvSalesOrderControl.Rows[e.RowIndex].Cells[clmObservations.Index].Value.ToString());
                }
                else
                {
                    obj.updateObs("");
                }

                List<string> notes = new List<string>();

                for (int i = 0; i < dgvSalesOrderControl.Rows.Count; i++)
                {
                    if (dgvSalesOrderControl.Rows[i].Cells[clmObservations.Index].Value != null)
                    {
                        notes.Add(dgvSalesOrderControl.Rows[i].Cells[clmObservations.Index].Value.ToString());
                    }
                }
                notes.Sort();
                cmbObs.Items.Clear();
                for (int j = 0; j < notes.Count; j++)
                {
                    cmbObs.Items.Add(notes[j]);
                }
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (DS.Tables[0].Rows[i]["codsec"].ToString() == dgvSalesOrderControl.Rows[e.RowIndex].Cells[clmCodsec.Index].Value.ToString())
                    {
                        if (dgvSalesOrderControl.Rows[e.RowIndex].Cells[clmObservations.Index].Value != null)
                        {
                            DS.Tables[0].Rows[i]["Observaciones"] = dgvSalesOrderControl.Rows[e.RowIndex].Cells[clmObservations.Index].Value.ToString();
                        }
                        else
                        {
                            DS.Tables[0].Rows[i]["Observaciones"] = string.Empty;
                        }
                    }
                }
                //populateDataGrid();
            }

            if (e.ColumnIndex == clmCompDate.Index)
            {
                
                    
                DateTimeConverter date = new DateTimeConverter();
                clsSalesOrderDetail obj = new clsSalesOrderDetail(Convert.ToInt32(dgvSalesOrderControl.Rows[e.RowIndex].Cells[clmCodsec.Index].Value));

                if (dgvSalesOrderControl.Rows[e.RowIndex].Cells[clmCompDate.Index].Value != null)
                {
                    try
                    {
                        
                        obj.updateCompromisedDate(Convert.ToDateTime(dgvSalesOrderControl.Rows[e.RowIndex].Cells[clmCompDate.Index].Value));

                        for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                        {
                            if (DS.Tables[0].Rows[i]["codsec"].ToString() == dgvSalesOrderControl.Rows[e.RowIndex].Cells[clmCodsec.Index].Value.ToString())
                            {
                                DS.Tables[0].Rows[i]["FechaComprometida"] = dgvSalesOrderControl.Rows[e.RowIndex].Cells[clmCompDate.Index].Value.ToString(); 
                            }
                        }
                    }
                    catch(FormatException ex)
                    {
                        clsLog.addLog(ex, 1, "salesordercontrol.edit");
                        MessageBox.Show("El valor ingresado no puede ser reconocido como una fecha", "Fecha no reconocida", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    obj.updateCompromisedDate(new DateTime(1900,01,01));
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        if (DS.Tables[0].Rows[i]["codsec"].ToString() == dgvSalesOrderControl.Rows[e.RowIndex].Cells[clmCodsec.Index].Value.ToString())
                        {
                            DS.Tables[0].Rows[i]["FechaComprometida"] = string.Empty;
                        }
                        
                    }
                    
                }
            }
        }

        private void cmbObs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbObs.SelectedIndex != -1)
            {
                if (obs != cmbObs.SelectedItem.ToString())
                {
                    obs = cmbObs.SelectedItem.ToString();
                    lastChange = "obs";
                    populateDataGrid();
                }
            }
            else
            {
                obs = string.Empty;
            }
        }

        private void cmbOCCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOCCliente.SelectedIndex != -1)
            {
                if (obs != cmbOCCliente.SelectedItem.ToString())
                {
                    occ = cmbOCCliente.SelectedItem.ToString();
                    lastChange = "occ";
                    populateDataGrid();
                }
            }
            else
            {
                occ = string.Empty;
            }
        }

        private void cmbExecutiveSalesOrderControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbExecutiveSalesOrderControl.ResetText();
                executive = string.Empty;
                lastChange = string.Empty;
                populateDataGrid();
            }
        }

        private void cmbOrderSalesOrderControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbOrderSalesOrderControl.ResetText();
                saleorder = string.Empty;
                lastChange = string.Empty;
                populateDataGrid();
            }
        }

        private void cmbPlantSalesOrderControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbPlantSalesOrderControl.ResetText();
                plant = string.Empty;
                lastChange = string.Empty;
                populateDataGrid();
            }
        }

        private void cmbCustomerSalesOrderControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbCustomerSalesOrderControl.ResetText();
                client = string.Empty;
                lastChange = string.Empty;
                populateDataGrid();
            }
        }

        private void cmbFilmSalesOrderControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbFilmSalesOrderControl.ResetText();
                film = string.Empty;
                lastChange = string.Empty;
                populateDataGrid();
            }
        }

        private void cmbWidthSalesOrderControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbWidthSalesOrderControl.ResetText();
                width = string.Empty;
                lastChange = string.Empty;
                populateDataGrid();
            }
        }

        private void cmbDiameterSalesOrderControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbDiameterSalesOrderControl.ResetText();
                diam = string.Empty;
                lastChange = string.Empty;
                populateDataGrid();
            }
        }

        private void cmbCoreSalesOrderControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbCoreSalesOrderControl.ResetText();
                core = string.Empty;
                lastChange = string.Empty;
                populateDataGrid();
            }
        }

        private void cmbObs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbObs.ResetText();
                obs = string.Empty;
                lastChange = string.Empty;
                populateDataGrid();
            }
        }

        private void cmbOCCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbOCCliente.ResetText();
                occ = string.Empty;
                lastChange = string.Empty;
                populateDataGrid();
            }
        }
        #endregion




    }
}