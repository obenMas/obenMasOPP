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

namespace BPS.Lite
{
    public partial class frmPCPTProductionControl : Form
    {
        private double param = 0;
        public frmPCPTProductionControl()
        {
            InitializeComponent();
        }
        public frmPCPTProductionControl(DateTime desde, DateTime hasta, string identifier)
        {
            InitializeComponent();

            txtDesde.Text = desde.ToString();
            txtHasta.Text = hasta.ToString();

            hideAll();
            populateDatagrid(desde, hasta, identifier,0);
        }
        public frmPCPTProductionControl(DateTime desde, DateTime hasta, string identifier, int hora, double para)
        {
            InitializeComponent();

            txtDesde.Text = desde.ToString();
            txtHasta.Text = hasta.ToString();

            hideAll();
            param = para;
            populateDatagrid(desde, hasta, identifier, 0);
            
        }
        public frmPCPTProductionControl(DateTime desde, DateTime hasta, string identifier, int hora)
        {
            InitializeComponent();

            txtDesde.Text = desde.ToString();
            txtHasta.Text = hasta.ToString();

            hideAll();
            populateDatagrid(desde, hasta, identifier,hora);
        }
        public void populateDatagrid(DateTime desde, DateTime hasta, string id,int hora)
        {
            double total = 0;
            string horario = ""; string horario2 = "";
            #region Cortadora Primaria
            #region Cortadora primaria de primera
            if (id == "CortadoraPrimariaPrimera")
            {
                this.Text = "Detalle de corte primario de primera";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmExtrusora.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spCuttingReportTotalPrimaryByDate '" + desde.ToString("dd/MM/yyyy") + " " + horario + "', '" + hasta.ToString("dd/MM/yyyy") + " " + horario2 + "'");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["codeFilm"];
                        dgvControl.Rows[fila].Cells[clmExtrusora.Index].Value = DS.Tables[0].Rows[i]["Maquina"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #region Cortadora Primaria de proceso
            if (id == "CortadoraPrimariaProceso")
            {
                this.Text = "Detalle de cortadora primaria de producto en proceso";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmExtrusora.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spCuttingReportTotalObservationByDate '" + desde.ToString("dd/MM/yyyy") + " " + horario + "', '" + hasta.ToString("dd/MM/yyyy") + " " + horario2 + "'");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["codeFilm"];
                        dgvControl.Rows[fila].Cells[clmExtrusora.Index].Value = DS.Tables[0].Rows[i]["Maquina"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #region Cortadora Primaria de OP1
            if (id == "CortadoraPrimariaOP1")
            {
                this.Text = "Detalle de corte primario de OP1";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmExtrusora.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spCuttingReportTotalOP1ByDate '" + desde.ToString("dd/MM/yyyy") + " " + horario + "', '" + hasta.ToString("dd/MM/yyyy") + " " + horario2 + "'");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["codeFilm"];
                        dgvControl.Rows[fila].Cells[clmExtrusora.Index].Value = DS.Tables[0].Rows[i]["Maquina"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #region Cortadora Primaria Total
            if (id == "CortadoraPrimariaTotal")
            {
                this.Text = "Detalle de corte primario total";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmExtrusora.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spCuttingReportTotalPrimaryCutter '" + desde.ToString("dd/MM/yyyy") + " " + horario + "', '" + hasta.ToString("dd/MM/yyyy") + " " + horario2 + "'");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["codeFilm"];
                        dgvControl.Rows[fila].Cells[clmExtrusora.Index].Value = DS.Tables[0].Rows[i]["Maquina"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #region Cortadora Primaria Base
            if (id == "CortadoraPrimariaBase")
            {
                this.Text = "Detalle de corte primario base";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmExtrusora.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spCuttingReportTotalBaseByDate '" + desde.ToString("dd/MM/yyyy") + " " + horario + "', '" + hasta.ToString("dd/MM/yyyy") + " " + horario2 + "'");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["codeFilm"];
                        dgvControl.Rows[fila].Cells[clmExtrusora.Index].Value = DS.Tables[0].Rows[i]["Maquina"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #region Merma
            if (id == "CortadoraPrimariaMerma")
            {
                this.Text = "Detalle de corte primario Merma";
                dgvControl.Columns[clmScrap.Index].Visible = true;
                dgvControl.Columns[clmExtrusora.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spScrapPalletPrimaryCutterByDate '" + desde.ToString("dd/MM/yyyy") + " " + horario + "', '" + hasta.ToString("dd/MM/yyyy") + " " + horario2 + "'");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmScrap.Index].Value = DS.Tables[0].Rows[i]["nomScrap"];
                        dgvControl.Rows[fila].Cells[clmExtrusora.Index].Value = DS.Tables[0].Rows[i]["Maquina"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #endregion

            #region Cortadora Atlas
            #region Atlas Total
            if (id == "CortadoraAtlas")
            {
                this.Text = "Detalle de cortadora Atlas";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                //dgvControl.Columns[clmExtrusora.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                dgvControl.Columns[clmTipo.Index].Visible = true;
                dgvControl.Columns[clmCalif.Index].Visible = true;

                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spCuttingReportTotalAtlas '" + desde.ToString("dd/MM/yyyy") + " " + horario + "', '" + hasta.ToString("dd/MM/yyyy") + " " + horario2 + "'");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["codeFilm"];
                        //dgvControl.Rows[fila].Cells[clmExtrusora.Index].Value = DS.Tables[0].Rows[i]["Maquina"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000).ToString("0.00");
                        dgvControl.Rows[fila].Cells[clmTipo.Index].Value = DS.Tables[0].Rows[i]["Tipo"];
                        dgvControl.Rows[fila].Cells[clmCalif.Index].Value = DS.Tables[0].Rows[i]["Calificacion"];
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #region Atlas Metal
            #region Total
            if (id == "CortadoraAtlasMetal")
            {
                this.Text = "Detalle de cortadora Atlas de corte metalizado";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                //dgvControl.Columns[clmExtrusora.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spCuttingReportTotalAtlas '" + desde.ToString("dd/MM/yyyy") + " " + horario + "', '" + hasta.ToString("dd/MM/yyyy") + " " + horario2 + "'");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        if(DS.Tables[0].Rows[i]["Tipo"].ToString() == "Corte Metal")
                        {
                            dgvControl.Rows.Add();
                            int fila = dgvControl.Rows.Count - 1;
                            dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["codeFilm"];
                            //dgvControl.Rows[fila].Cells[clmExtrusora.Index].Value = DS.Tables[0].Rows[i]["Maquina"];
                            dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000).ToString("0.00");
                            total += Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000;
                        }                                              
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #region Primera
            if (id == "AtlasMetPrimera")
            {
                this.Text = "Detalle de Atlas de calificacion primera";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                //dgvControl.Columns[clmExtrusora.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spCuttingReportTotalAtlas '" + desde.ToString("dd/MM/yyyy") + " " + horario + "', '" + hasta.ToString("dd/MM/yyyy") + " " + horario2 + "'");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        if (DS.Tables[0].Rows[i]["Tipo"].ToString() == "Corte Metal" && DS.Tables[0].Rows[i]["Calificacion"].ToString() == "Primera")
                        {
                            dgvControl.Rows.Add();
                            int fila = dgvControl.Rows.Count - 1;
                            dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["codeFilm"];
                            //dgvControl.Rows[fila].Cells[clmExtrusora.Index].Value = DS.Tables[0].Rows[i]["Maquina"];
                            dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000).ToString("0.00");
                            total += Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000;
                        }
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #region Producto en proceso
            if (id == "AtlasMetPP")
            {
                this.Text = "Detalle de Atlas de calificacion Producto en proceso";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                //dgvControl.Columns[clmExtrusora.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spCuttingReportTotalAtlas '" + desde.ToString("dd/MM/yyyy") + " " + horario + "', '" + hasta.ToString("dd/MM/yyyy") + " " + horario2 + "'");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        if (DS.Tables[0].Rows[i]["Tipo"].ToString() == "Corte Metal" && DS.Tables[0].Rows[i]["Calificacion"].ToString() == "Observación")
                        {
                            dgvControl.Rows.Add();
                            int fila = dgvControl.Rows.Count - 1;
                            dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["codeFilm"];
                            //dgvControl.Rows[fila].Cells[clmExtrusora.Index].Value = DS.Tables[0].Rows[i]["Maquina"];
                            dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000).ToString("0.00");
                            total += Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000;
                        }
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #region Segunda
            if (id == "AtlasMetOP1")
            {
                this.Text = "Detalle de Atlas de calificacion Segunda";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                //dgvControl.Columns[clmExtrusora.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spCuttingReportTotalAtlas '" + desde.ToString("dd/MM/yyyy") + " " + horario + "', '" + hasta.ToString("dd/MM/yyyy") + " " + horario2 + "'");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        if (DS.Tables[0].Rows[i]["Tipo"].ToString() == "Corte Metal" && DS.Tables[0].Rows[i]["Calificacion"].ToString() == "Segunda")
                        {
                            dgvControl.Rows.Add();
                            int fila = dgvControl.Rows.Count - 1;
                            dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["codeFilm"];
                            //dgvControl.Rows[fila].Cells[clmExtrusora.Index].Value = DS.Tables[0].Rows[i]["Maquina"];
                            dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000).ToString("0.00");
                            total += Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000;
                        }
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #endregion
            #region Atlas Secundario
            #region Total
            if (id == "CortadoraAtlasSecundario")
            {
                this.Text = "Detalle de cortadora Atlas de corte secundario";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmExtrusora.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spCuttingReportSecondaryAtlas '" + desde.ToString("dd/MM/yyyy") + " " + horario + "', '" + hasta.ToString("dd/MM/yyyy") + " " + horario2 + "'");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["codeFilm"];
                        dgvControl.Rows[fila].Cells[clmExtrusora.Index].Value = DS.Tables[0].Rows[i]["Maquina"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #region Primera
            if (id == "CortadoraAtlasSecundarioPrimera")
            {
                this.Text = "Detalle de cortadora Atlas de corte secundario calificacion Primera";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmExtrusora.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spCuttingReportSecundaryPrimaryAtlas '" + desde.ToString("dd/MM/yyyy") + " " + horario + "', '" + hasta.ToString("dd/MM/yyyy") + " " + horario2 + "'");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["codeFilm"];
                        dgvControl.Rows[fila].Cells[clmExtrusora.Index].Value = DS.Tables[0].Rows[i]["Maquina"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #region Observacion
            if (id == "CortadoraAtlasSecundarioPP")
            {
                this.Text = "Detalle de cortadora Atlas de corte secundario Calificacion Producto en proceso";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmExtrusora.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spCuttingReportSecundaryObsAtlas '" + desde.ToString("dd/MM/yyyy") + " " + horario + "', '" + hasta.ToString("dd/MM/yyyy") + " " + horario2 + "'");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["codeFilm"];
                        dgvControl.Rows[fila].Cells[clmExtrusora.Index].Value = DS.Tables[0].Rows[i]["Maquina"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #region Segunda
            if (id == "CortadoraAtlasSecundarioOP1")
            {
                this.Text = "Detalle de cortadora Atlas de corte secundario Calificacion Producto en proceso";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmExtrusora.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spCuttingReportSecundaryOP1Atlas '" + desde.ToString("dd/MM/yyyy") + " " + horario + "', '" + hasta.ToString("dd/MM/yyyy") + " " + horario2 + "'");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["codeFilm"];
                        dgvControl.Rows[fila].Cells[clmExtrusora.Index].Value = DS.Tables[0].Rows[i]["Maquina"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #endregion
            #region Atlas Merma Metal
            if (id == "AtlasMermaMetal")
            {
                this.Text = "Detalle de cortadora Atlas de merma metalizado";
                dgvControl.Columns[clmScrap.Index].Visible = true;
                dgvControl.Columns[clmExtrusora.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spScrapPalletAtlasMetalByDate '" + desde.ToString("dd/MM/yyyy") + " " + horario + "', '" + hasta.ToString("dd/MM/yyyy") + " " + horario2 + "'");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmScrap.Index].Value = DS.Tables[0].Rows[i]["nomScrap"];
                        dgvControl.Rows[fila].Cells[clmExtrusora.Index].Value = DS.Tables[0].Rows[i]["Maquina"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #region Merma Secundario
            if (id == "AtlasMermaSecundario")
            {
                this.Text = "Detalle de cortadora Atlas de merma secundario";
                dgvControl.Columns[clmScrap.Index].Visible = true;
                dgvControl.Columns[clmExtrusora.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spScrapPalletAtlasSecondaryByDate '" + desde.ToString("dd/MM/yyyy") + " " + horario + "', '" + hasta.ToString("dd/MM/yyyy") + " " + horario2 + "'");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmScrap.Index].Value = DS.Tables[0].Rows[i]["nomScrap"];
                        dgvControl.Rows[fila].Cells[clmExtrusora.Index].Value = DS.Tables[0].Rows[i]["Maquina"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #endregion

            #region Cortadora Titan
            #region Titan Total
            if (id == "CortadoraTitan")
            {
                this.Text = "Detalle de cortadora Titan";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmExtrusora.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spCuttingReportTotalTitan '" + desde.ToString("dd/MM/yyyy") + " " + horario + "', '" + hasta.ToString("dd/MM/yyyy") + " " + horario2 + "'");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["codeFilm"];
                        dgvControl.Rows[fila].Cells[clmExtrusora.Index].Value = DS.Tables[0].Rows[i]["Maquina"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #region Titan Secundario
            if (id == "CortadoraTitanSecundario")
            {
                this.Text = "Detalle de cortadora Titan corte secundario";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmExtrusora.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spCuttingReportSecondaryTitan '" + desde.ToString("dd/MM/yyyy") + " " + horario + "', '" + hasta.ToString("dd/MM/yyyy") + " " + horario2 + "'");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["codeFilm"];
                        dgvControl.Rows[fila].Cells[clmExtrusora.Index].Value = DS.Tables[0].Rows[i]["Maquina"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #region Titan Merma
            if (id == "TitanMerma")
            {
                this.Text = "Detalle de cortadora Titan merma";
                dgvControl.Columns[clmScrap.Index].Visible = true;
                dgvControl.Columns[clmExtrusora.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spScrapPalletTitanMetalByDate '" + desde.ToString("dd/MM/yyyy") + " " + horario + "', '" + hasta.ToString("dd/MM/yyyy") + " " + horario2 + "'");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmScrap.Index].Value = DS.Tables[0].Rows[i]["nomScrap"];
                        dgvControl.Rows[fila].Cells[clmExtrusora.Index].Value = DS.Tables[0].Rows[i]["Maquina"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #region Primera
            if (id == "CortadoraTitanSecundarioPrimera")
            {
                this.Text = "Detalle de cortadora Titan corte secundario Calificacion Primera";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmExtrusora.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spCuttingReportSecondaryPrimaryTitan '" + desde.ToString("dd/MM/yyyy") + " " + horario + "', '" + hasta.ToString("dd/MM/yyyy") + " " + horario2 + "'");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["codeFilm"];
                        dgvControl.Rows[fila].Cells[clmExtrusora.Index].Value = DS.Tables[0].Rows[i]["Maquina"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #region Producto en proceso
            if (id == "CortadoraTitanSecundarioPP")
            {
                this.Text = "Detalle de cortadora Titan corte secundario Calificacion Producto en proceso";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmExtrusora.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spCuttingReportSecondaryObsTitan '" + desde.ToString("dd/MM/yyyy") + " " + horario + "', '" + hasta.ToString("dd/MM/yyyy") + " " + horario2 + "'");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["codeFilm"];
                        dgvControl.Rows[fila].Cells[clmExtrusora.Index].Value = DS.Tables[0].Rows[i]["Maquina"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #region Segunda
            if (id == "CortadoraTitanSecundarioOP1")
            {
                this.Text = "Detalle de cortadora Titan corte secundario Calificacion Segunda";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmExtrusora.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spCuttingReportSecondaryOP1Titan '" + desde.ToString("dd/MM/yyyy") + " " + horario + "', '" + hasta.ToString("dd/MM/yyyy") + " " + horario2 + "'");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["codeFilm"];
                        dgvControl.Rows[fila].Cells[clmExtrusora.Index].Value = DS.Tables[0].Rows[i]["Maquina"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["CorteTotal"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #endregion

            #region Metalizadora
            #region Metal
            if (id == "MetalizadoraMetal")
            {
                this.Text = "Detalle de metalizado";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmExtrusora.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spMainCoilReportMetalByDateTotalizedbyFilm '" + desde.ToString("dd/MM/yyyy") + " " + horario + "', '" + hasta.ToString("dd/MM/yyyy") + " " + horario2 + "'");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["pelicula"];
                        dgvControl.Rows[fila].Cells[clmExtrusora.Index].Value = DS.Tables[0].Rows[i]["Extrusora"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #region Merma
            if (id == "MetalizadoraMerma")
            {
                this.Text = "Detalle de merma de metalizadora";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmExtrusora.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spScrapPalletMetallizerByDate '" + desde.ToString("dd/MM/yyyy") + " " + horario + "', '" + hasta.ToString("dd/MM/yyyy") + " " + horario2 + "'");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["pelicula"];
                        dgvControl.Rows[fila].Cells[clmExtrusora.Index].Value = DS.Tables[0].Rows[i]["Extrusora"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #endregion

            #region Extrusora
            #region Produccion
            if (id == "ExtrusoraProduccion")
            {
                this.Text = "Detalle de Extrusora";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmExtrusora.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spMainCoilReportByDateTotalizedbyFilm '" + desde.ToString("dd/MM/yyyy") + " " + horario + "', '" + hasta.ToString("dd/MM/yyyy") + " " + horario2 + "'");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["pelicula"];
                        dgvControl.Rows[fila].Cells[clmExtrusora.Index].Value = DS.Tables[0].Rows[i]["Extrusora"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = ((Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"]) / 1000) - ((Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"]) / 1000)*param)).ToString("0.00");
                        total += ((Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"]) / 1000) - ((Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"]) / 1000) * param));
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion

            #region Merma
            if (id == "ExtrusoraMerma")
            {
                this.Text = "Detalle de merma de extrusora";
                dgvControl.Columns[clmScrap.Index].Visible = true;
                dgvControl.Columns[clmScrap.Index].Width= 150;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spScrapPalletExtruderByDate '" + desde.ToString("dd/MM/yyyy") + " " + horario + "', '" + hasta.ToString("dd/MM/yyyy") + " " + horario2 + "'");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmScrap.Index].Value = DS.Tables[0].Rows[i]["nomScrap"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion

            #region Recuperado
            if (id == "ExtrusoraRecup")
            {
                this.Text = "Detalle de recuperado de extrusora";
                dgvControl.Columns[clmMaterial.Index].Visible = true;
                dgvControl.Columns[clmMaterial.Index].Width = 230;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spRawMaterialMovementsTotalByDateAndRecup '" + desde.ToString("dd/MM/yyyy") + " " + horario + "', '" + hasta.ToString("dd/MM/yyyy") + " " + horario2 + "'");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmMaterial.Index].Value = DS.Tables[0].Rows[i]["Nombre"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["pesoRaw"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["pesoRaw"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            if (id == "ExtrusoraConsum")
            {
                this.Text = "Detalle de recuperado de extrusora";
                dgvControl.Columns[clmMaterial.Index].Visible = true;
                dgvControl.Columns[clmMaterial.Index].Width = 230;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spRawMaterialMovementsTotalByDateAndConsumption '" + desde.ToString("dd/MM/yyyy") + " " + horario + "', '" + hasta.ToString("dd/MM/yyyy") + " " + horario2 + "'");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmMaterial.Index].Value = DS.Tables[0].Rows[i]["Nombre"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["pesoRaw"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["pesoRaw"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #endregion

            #region Deposito
            #region Despachos
            if (id == "DepDespachos")
            {
                this.Text = "Detalle de deposito de despachos";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                dgvControl.Columns[clmCliente.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spShippingsReportTotalByClient '" + desde.ToString("dd/MM/yyyy") + " " + horario + "', '" + hasta.ToString("dd/MM/yyyy") + " " + horario2 + "'");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmCliente.Index].Value = DS.Tables[0].Rows[i]["Cliente"];
                        dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["CodProd"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["EntTotal"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["EntTotal"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #region Devoluciones
            if (id == "DepDevoluciones")
            {
                this.Text = "Detalle de deposito de devoluciones";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                dgvControl.Columns[clmCliente.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spReturnsReportTotalizedByClient '" + desde.ToString("dd/MM/yyyy") + " " + horario + "', '" + hasta.ToString("dd/MM/yyyy") + " " + horario2 + "'");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmCliente.Index].Value = DS.Tables[0].Rows[i]["Cliente"];
                        dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["producto"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["DevTotal"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["DevTotal"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #region Importaciones
            if (id == "DepImportaciones")
            {
                this.Text = "Detalle de deposito de importaciones";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spReporteImportacionesTotalizado '" + desde.ToString("dd/MM/yyyy") + " " + horario + "', '" + hasta.ToString("dd/MM/yyyy") + " " + horario2 + "'");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["producto"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["DevTotal"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["DevTotal"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #region Primera 
            if (id == "DepPrimera")
            {
                this.Text = "Detalle de Deposito Primera";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                dgvControl.Columns[clmDeposito.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                if (hora == 19)
                    DS = clsConnection.getDataSetResult("CALL spDepotCoilHistoryPrimaryTotal(" + hasta.Day.ToString() + "," + hasta.Month.ToString() + "," + hasta.Year.ToString() + "," + "19,0)");
                else if (hora == 7)
                    DS = clsConnection.getDataSetResult("CALL spDepotCoilHistoryPrimaryTotal(" + hasta.Day.ToString() + "," + hasta.Month.ToString() + "," + hasta.Year.ToString() + "," + "7,0)");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        if ((Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000) != 0.00)
                        {
                            dgvControl.Rows.Add();
                            int fila = dgvControl.Rows.Count - 1;
                            dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["Pelicula"];
                            dgvControl.Rows[fila].Cells[clmDeposito.Index].Value = DS.Tables[0].Rows[i]["Deposito"];
                            dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                        }
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            if (id == "DepPrimera2")
            {
                this.Text = "Detalle de Deposito Primera";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                dgvControl.Columns[clmDeposito.Index].Visible = true;
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("CALL spDepotCoilHistoryPrimaryTotal(" + desde.Day.ToString() + "," + desde.Month.ToString() + "," + desde.Year.ToString() + "," + "0,0)");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        if ((Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000) != 0.00)
                        {
                            dgvControl.Rows.Add();
                            int fila = dgvControl.Rows.Count - 1;
                            dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["Pelicula"];
                            dgvControl.Rows[fila].Cells[clmDeposito.Index].Value = DS.Tables[0].Rows[i]["Deposito"];
                            dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                        }
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            if (id == "DepPrimeraImp")
            {
                this.Text = "Detalle de Deposito Primera";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                dgvControl.Columns[clmDeposito.Index].Visible = true;
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("CALL spDepotCoilHistoryPrimaryTotal(" + desde.Day.ToString() + "," + desde.Month.ToString() + "," + desde.Year.ToString() + "," + "0,1)");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        if ((Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000) != 0.00)
                        {
                            dgvControl.Rows.Add();
                            int fila = dgvControl.Rows.Count - 1;
                            dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["Pelicula"];
                            dgvControl.Rows[fila].Cells[clmDeposito.Index].Value = DS.Tables[0].Rows[i]["Deposito"];
                            dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                        }
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            if (id == "PrimeraDepositoFinal")
            {
                this.Text = "Detalle de Deposito Primera";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                dgvControl.Columns[clmDeposito.Index].Visible = true;
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("CALL spDepotCoilHistoryPrimaryTotal(" + hasta.Day.ToString() + "," + hasta.Month.ToString() + "," + hasta.Year.ToString() + "," + "0,0)");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        if ((Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000) != 0.00)
                        {
                            dgvControl.Rows.Add();
                            int fila = dgvControl.Rows.Count - 1;
                            dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["Pelicula"];
                            dgvControl.Rows[fila].Cells[clmDeposito.Index].Value = DS.Tables[0].Rows[i]["Deposito"];
                            dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                        }
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            if (id == "PrimeraDepositoFinalImp")
            {
                this.Text = "Detalle de Deposito Primera";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                dgvControl.Columns[clmDeposito.Index].Visible = true;
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("CALL spDepotCoilHistoryPrimaryTotal(" + hasta.Day.ToString() + "," + hasta.Month.ToString() + "," + hasta.Year.ToString() + "," + "0,1)");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        if ((Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000) != 0.00)
                        {
                            dgvControl.Rows.Add();
                            int fila = dgvControl.Rows.Count - 1;
                            dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["Pelicula"];
                            dgvControl.Rows[fila].Cells[clmDeposito.Index].Value = DS.Tables[0].Rows[i]["Deposito"];
                            dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                        }
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #region Observacion
            if (id == "DepProceso")
            {
                this.Text = "Detalle de Deposito Producto En Proceso";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                dgvControl.Columns[clmDeposito.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                if (hora == 19)
                    DS = clsConnection.getDataSetResult("CALL spDepotCoilHistoryObsTotal(" + hasta.Day.ToString() + "," + hasta.Month.ToString() + "," + hasta.Year.ToString() + "," + "19)");
                else if (hora == 7)
                    DS = clsConnection.getDataSetResult("CALL spDepotCoilHistoryObsTotal(" + hasta.Day.ToString() + "," + hasta.Month.ToString() + "," + hasta.Year.ToString() + "," + "7)");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        if ((Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000) != 0.00)
                        {
                            dgvControl.Rows.Add();
                            int fila = dgvControl.Rows.Count - 1;
                            dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["Pelicula"];
                            dgvControl.Rows[fila].Cells[clmDeposito.Index].Value = DS.Tables[0].Rows[i]["Deposito"];
                            dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                        }
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            if (id == "DepProceso2")
            {
                this.Text = "Detalle de Deposito de Producto en Proceso";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                dgvControl.Columns[clmDeposito.Index].Visible = true;
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("CALL spDepotCoilHistoryObsTotal(" + desde.Day.ToString() + "," + desde.Month.ToString() + "," + desde.Year.ToString() + "," + "0)");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        if ((Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000) != 0.00)
                        {
                            dgvControl.Rows.Add();
                            int fila = dgvControl.Rows.Count - 1;
                            dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["Pelicula"];
                            dgvControl.Rows[fila].Cells[clmDeposito.Index].Value = DS.Tables[0].Rows[i]["Deposito"];
                            dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                        }
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            if (id == "PPDepositoFinal")
            {
                this.Text = "Detalle de Deposito de Producto en Proceso";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                dgvControl.Columns[clmDeposito.Index].Visible = true;
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("CALL spDepotCoilHistoryObsTotal(" + hasta.Day.ToString() + "," + hasta.Month.ToString() + "," + hasta.Year.ToString() + "," + "0)");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        if ((Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000) != 0.00)
                        {
                            dgvControl.Rows.Add();
                            int fila = dgvControl.Rows.Count - 1;
                            dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["Pelicula"];
                            dgvControl.Rows[fila].Cells[clmDeposito.Index].Value = DS.Tables[0].Rows[i]["Deposito"];
                            dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                        }
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #region Segunda
            if (id == "DepOP1")
            {
                this.Text = "Detalle de Deposito OP1";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                dgvControl.Columns[clmDeposito.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                if (hora == 19)
                    DS = clsConnection.getDataSetResult("CALL spDepotCoilHistoryOP1Total(" + hasta.Day.ToString() + "," + hasta.Month.ToString() + "," + hasta.Year.ToString() + "," + "19)");
                else if (hora == 7)
                    DS = clsConnection.getDataSetResult("CALL spDepotCoilHistoryOP1Total(" + hasta.Day.ToString() + "," + hasta.Month.ToString() + "," + hasta.Year.ToString() + "," + "7)");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        if ((Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000) != 0.00)
                        {
                            dgvControl.Rows.Add();
                            int fila = dgvControl.Rows.Count - 1;
                            dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["Pelicula"];
                            dgvControl.Rows[fila].Cells[clmDeposito.Index].Value = DS.Tables[0].Rows[i]["Deposito"];
                            dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                        }
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            if (id == "DepOP1_2")
            {
                this.Text = "Detalle de Deposito de OP1";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                dgvControl.Columns[clmDeposito.Index].Visible = true;
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("CALL spDepotCoilHistoryOP1Total(" + desde.Day.ToString() + "," + desde.Month.ToString() + "," + desde.Year.ToString() + "," + "0)");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        if ((Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000) != 0.00)
                        {
                            dgvControl.Rows.Add();
                            int fila = dgvControl.Rows.Count - 1;
                            dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["Pelicula"];
                            dgvControl.Rows[fila].Cells[clmDeposito.Index].Value = DS.Tables[0].Rows[i]["Deposito"];
                            dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                        }
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            if (id == "OP1DepositoFinal")
            {
                this.Text = "Detalle de Deposito de OP1";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                dgvControl.Columns[clmDeposito.Index].Visible = true;
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("CALL spDepotCoilHistoryOP1Total(" + hasta.Day.ToString() + "," + hasta.Month.ToString() + "," + hasta.Year.ToString() + "," + "0)");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        if ((Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000) != 0.00)
                        {
                            dgvControl.Rows.Add();
                            int fila = dgvControl.Rows.Count - 1;
                            dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["Pelicula"];
                            dgvControl.Rows[fila].Cells[clmDeposito.Index].Value = DS.Tables[0].Rows[i]["Deposito"];
                            dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                        }
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #region Swap
            if (id == "SwapPlus")
            {
                this.Text = "Detalle de swap";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                dgvControl.Columns[clmPlanta.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spSwapReportTotalByDate '" + desde.ToString("dd/MM/yyyy") + " " + horario + "', '" + hasta.ToString("dd/MM/yyyy") + " " + horario2 + "'");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        if (DS.Tables[0].Rows[i]["PlantaOrigen"].ToString()=="Campana")
                        {
                            dgvControl.Rows.Add();
                            int fila = dgvControl.Rows.Count - 1;
                            dgvControl.Rows[fila].Cells[clmPlanta.Index].Value = DS.Tables[0].Rows[i]["PlantaOrigen"];
                            dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["Pelicula"];
                            dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                            total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                        }
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            if (id == "SwapMinus")
            {
                this.Text = "Detalle de swap";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                dgvControl.Columns[clmPlanta.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spSwapReportTotalByDate '" + desde.ToString("dd/MM/yyyy") + " " + horario + "', '" + hasta.ToString("dd/MM/yyyy") + " " + horario2 + "'");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        if (DS.Tables[0].Rows[i]["PlantaOrigen"].ToString() == "Pilar")
                        {
                            dgvControl.Rows.Add();
                            int fila = dgvControl.Rows.Count - 1;
                            dgvControl.Rows[fila].Cells[clmPlanta.Index].Value = DS.Tables[0].Rows[i]["PlantaOrigen"];
                            dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["Pelicula"];
                            dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                            total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                        }
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #endregion

            #region Racks
            #region Rack Primario
            if (id == "RackPrimarioStock")
            {
                this.Text = "Detalle de Rack Primario";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmExtrusora.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                if(hora==19)
                    DS = clsConnection.getDataSetResult("CALL spRackHistoryReportTotal("+hasta.Day.ToString()+","+hasta.Month.ToString()+","+hasta.Year.ToString()+","+"19)");
                else if(hora==7)
                    DS = clsConnection.getDataSetResult("CALL spRackHistoryReportTotal(" + hasta.Day.ToString() + "," + hasta.Month.ToString() + "," + hasta.Year.ToString() + "," + "7)");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["Pelicula"];
                        dgvControl.Rows[fila].Cells[clmExtrusora.Index].Value = DS.Tables[0].Rows[i]["Maquina"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = ((Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000) - ((Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000)*param)).ToString("0.00");
                        total += (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000) - ((Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000)*param);
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            if (id == "RackPrimarioStock2")
            {
                this.Text = "Detalle de metalizado";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmExtrusora.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("CALL spRackHistoryReportTotal(" + desde.Day.ToString() + "," + desde.Month.ToString() + "," + desde.Year.ToString() + "," + "0)");
                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["Pelicula"];
                        dgvControl.Rows[fila].Cells[clmExtrusora.Index].Value = DS.Tables[0].Rows[i]["Maquina"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = ((Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000) - ((Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000)*param)).ToString("0.00");
                        total += (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000) - ((Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000)*param);
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            if (id == "RackPrimarioFinal")
            {
                this.Text = "Detalle de metalizado";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmExtrusora.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("CALL spRackHistoryReportTotal(" + hasta.Day.ToString() + "," + hasta.Month.ToString() + "," + hasta.Year.ToString() + "," + "0)");
                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["Pelicula"];
                        dgvControl.Rows[fila].Cells[clmExtrusora.Index].Value = DS.Tables[0].Rows[i]["Maquina"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = ((Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000) - ((Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000)*param)).ToString("0.00");
                        total += (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000) - ((Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000)*param);
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #region Rack Secundario
            #region Base
            if (id == "RackSecundarioBase")
            {
                this.Text = "Detalle de Rack Stock Bases";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmPlanta.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                if (hora == 19)
                    DS = clsConnection.getDataSetResult("CALL spSecundaryRackHistoryReportTotalBase(" + hasta.Day.ToString() + "," + hasta.Month.ToString() + "," + hasta.Year.ToString() + "," + "19)");
                else if (hora == 7)
                    DS = clsConnection.getDataSetResult("CALL spSecundaryRackHistoryReportTotalBase(" + hasta.Day.ToString() + "," + hasta.Month.ToString() + "," + hasta.Year.ToString() + "," + "7)");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["Pelicula"];
                        dgvControl.Rows[fila].Cells[clmPlanta.Index].Value = DS.Tables[0].Rows[i]["Planta"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            if (id == "RackSecundarioBase2")
            {
                this.Text = "Detalle de Rack Secundario Metal";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spSecundaryRackHistoryReportTotalBase(" + desde.Day.ToString() + "," + desde.Month.ToString() + "," + desde.Year.ToString() + "," + "0)");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["Pelicula"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            if (id == "RackSecundarioBaseFinal")
            {
                this.Text = "Detalle de Rack Secundario Metal";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spSecundaryRackHistoryReportTotalBase(" + hasta.Day.ToString() + "," + hasta.Month.ToString() + "," + hasta.Year.ToString() + "," + "0)");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["Pelicula"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #region Metal
            if (id == "RackSecundarioMetal")
            {
                this.Text = "Detalle de Rack Stock Metal";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmPlanta.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                if (hora == 19)
                    DS = clsConnection.getDataSetResult("CALL spSecundaryRackHistoryReportTotalMetal(" + hasta.Day.ToString() + "," + hasta.Month.ToString() + "," + hasta.Year.ToString() + "," + "19)");
                else if (hora == 7)
                    DS = clsConnection.getDataSetResult("CALL spSecundaryRackHistoryReportTotalMetal(" + hasta.Day.ToString() + "," + hasta.Month.ToString() + "," + hasta.Year.ToString() + "," + "7)");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["Pelicula"];
                        dgvControl.Rows[fila].Cells[clmPlanta.Index].Value = DS.Tables[0].Rows[i]["Planta"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            if (id == "RackSecundarioMetal2")
            {
                this.Text = "Detalle de Rack Secundario Metal";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spSecundaryRackHistoryReportTotalMetal(" + desde.Day.ToString() + "," + desde.Month.ToString() + "," + desde.Year.ToString() + "," + "0)");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["Pelicula"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            if (id == "RackSecundarioMetalFinal")
            {
                this.Text = "Detalle de Rack Secundario Metal";
                dgvControl.Columns[clmPelicula.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spSecundaryRackHistoryReportTotalMetal(" + hasta.Day.ToString() + "," + hasta.Month.ToString() + "," + hasta.Year.ToString() + "," + "0)");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["Pelicula"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #endregion
            #endregion

            #region DepositoMP
            if (id == "StockMP")
            {
                this.Text = "Detalle de Deposito Materia Prima";
                dgvControl.Columns[clmMaterial.Index].Visible = true;
                dgvControl.Columns[clmCodMaterial.Index].Visible = true;
                dgvControl.Columns[clmTipoMaterial.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                if (hora == 19)
                    DS = clsConnection.getDataSetResult("CALL spRawDepotHistoryTotalMPByDate(" + hasta.Day.ToString() + "," + hasta.Month.ToString() + "," + hasta.Year.ToString() + "," + "19)");
                else if (hora == 7)
                    DS = clsConnection.getDataSetResult("CALL spRawDepotHistoryTotalMPByDate(" + hasta.Day.ToString() + "," + hasta.Month.ToString() + "," + hasta.Year.ToString() + "," + "7)");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        if ((Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000) != 0.00)
                        {
                            dgvControl.Rows.Add();
                            int fila = dgvControl.Rows.Count - 1;
                            dgvControl.Rows[fila].Cells[clmMaterial.Index].Value = DS.Tables[0].Rows[i]["Material"];
                            dgvControl.Rows[fila].Cells[clmCodMaterial.Index].Value = DS.Tables[0].Rows[i]["CodMaterial"];
                            dgvControl.Rows[fila].Cells[clmTipoMaterial.Index].Value = DS.Tables[0].Rows[i]["TipoMaterial"];
                            dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                        }
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            if (id == "StockMP2")
            {
                this.Text = "Detalle de metalizado";
                dgvControl.Columns[clmCodMaterial.Index].Visible = true;
                dgvControl.Columns[clmTipoMaterial.Index].Visible = true;
                dgvControl.Columns[clmMaterial.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("CALL spRawDepotHistoryTotalMPByDate(" + desde.Day.ToString() + "," + desde.Month.ToString() + "," + desde.Year.ToString() + "," + "0)");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        if ((Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000) != 0.00)
                        {
                            dgvControl.Rows.Add();
                            int fila = dgvControl.Rows.Count - 1;
                            dgvControl.Rows[fila].Cells[clmCodMaterial.Index].Value = DS.Tables[0].Rows[i]["CodMaterial"];
                            dgvControl.Rows[fila].Cells[clmTipoMaterial.Index].Value = DS.Tables[0].Rows[i]["TipoMaterial"];
                            dgvControl.Rows[fila].Cells[clmMaterial.Index].Value = DS.Tables[0].Rows[i]["Material"];
                            dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                        }
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            if (id == "StockMPFinal")
            {
                this.Text = "Detalle de metalizado";
                dgvControl.Columns[clmTipoMaterial.Index].Visible = true;
                dgvControl.Columns[clmCodMaterial.Index].Visible = true;
                dgvControl.Columns[clmMaterial.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("CALL spRawDepotHistoryTotalMPByDate(" + hasta.Day.ToString() + "," + hasta.Month.ToString() + "," + hasta.Year.ToString() + "," + "0)");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        if ((Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000) != 0.00)
                        {
                            dgvControl.Rows.Add();
                            int fila = dgvControl.Rows.Count - 1;
                            dgvControl.Rows[fila].Cells[clmMaterial.Index].Value = DS.Tables[0].Rows[i]["Material"];
                            dgvControl.Rows[fila].Cells[clmCodMaterial.Index].Value = DS.Tables[0].Rows[i]["CodMaterial"];
                            dgvControl.Rows[fila].Cells[clmTipoMaterial.Index].Value = DS.Tables[0].Rows[i]["TipoMaterial"];
                            dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                        }
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion

            #region Deposito Extrusion
            #region Deposito MP
            if (id == "ExtrusionStockMP")
            {
                this.Text = "Detalle de Deposito De Extrusora Materia Prima";
                dgvControl.Columns[clmMaterial.Index].Visible = true;
                dgvControl.Columns[clmCodMaterial.Index].Visible = true;
                dgvControl.Columns[clmTipoMaterial.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                if (hora == 19)
                    DS = clsConnection.getDataSetResult("CALL spRawDepotHistoryTotalExtruderMPByDate(" + hasta.Day.ToString() + "," + hasta.Month.ToString() + "," + hasta.Year.ToString() + "," + "19)");
                else if (hora == 7)
                    DS = clsConnection.getDataSetResult("CALL spRawDepotHistoryTotalExtruderMPByDate(" + hasta.Day.ToString() + "," + hasta.Month.ToString() + "," + hasta.Year.ToString() + "," + "7)");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        if ((Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000) != 0.00)
                        {
                            dgvControl.Rows.Add();
                            int fila = dgvControl.Rows.Count - 1;
                            dgvControl.Rows[fila].Cells[clmMaterial.Index].Value = DS.Tables[0].Rows[i]["Material"];
                            dgvControl.Rows[fila].Cells[clmCodMaterial.Index].Value = DS.Tables[0].Rows[i]["CodMaterial"];
                            dgvControl.Rows[fila].Cells[clmTipoMaterial.Index].Value = DS.Tables[0].Rows[i]["TipoMaterial"];
                            dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                        }
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            if (id == "ExtrusionStockMP2")
            {
                this.Text = "Detalle de metalizado";
                dgvControl.Columns[clmMaterial.Index].Visible = true;
                dgvControl.Columns[clmCodMaterial.Index].Visible = true;
                dgvControl.Columns[clmTipoMaterial.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("CALL spRawDepotHistoryTotalExtruderMPByDate(" + desde.Day.ToString() + "," + desde.Month.ToString() + "," + desde.Year.ToString() + "," + "0)");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        if ((Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000) != 0.00)
                        {
                            dgvControl.Rows.Add();
                            int fila = dgvControl.Rows.Count - 1;
                            dgvControl.Rows[fila].Cells[clmMaterial.Index].Value = DS.Tables[0].Rows[i]["Material"];
                            dgvControl.Rows[fila].Cells[clmCodMaterial.Index].Value = DS.Tables[0].Rows[i]["CodMaterial"];
                            dgvControl.Rows[fila].Cells[clmTipoMaterial.Index].Value = DS.Tables[0].Rows[i]["TipoMaterial"];
                            dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                        }
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            if (id == "StockExtrusionFinal")
            {
                this.Text = "Detalle de metalizado";
                dgvControl.Columns[clmMaterial.Index].Visible = true;
                dgvControl.Columns[clmCodMaterial.Index].Visible = true;
                dgvControl.Columns[clmTipoMaterial.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("CALL spRawDepotHistoryTotalExtruderMPByDate(" + hasta.Day.ToString() + "," + hasta.Month.ToString() + "," + hasta.Year.ToString() + "," + "0)");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        if ((Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000) != 0.00)
                        {
                            dgvControl.Rows.Add();
                            int fila = dgvControl.Rows.Count - 1;
                            dgvControl.Rows[fila].Cells[clmMaterial.Index].Value = DS.Tables[0].Rows[i]["Material"];
                            dgvControl.Rows[fila].Cells[clmCodMaterial.Index].Value = DS.Tables[0].Rows[i]["CodMaterial"];
                            dgvControl.Rows[fila].Cells[clmTipoMaterial.Index].Value = DS.Tables[0].Rows[i]["TipoMaterial"];
                            dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                        }
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            
            #endregion
            #region Silo 3
            if (id == "ExtrusionSilo3")
            {
                this.Text = "Detalle de Extrusion Silo 3";
                dgvControl.Columns[clmMaterial.Index].Visible = true;
                dgvControl.Columns[clmCodMaterial.Index].Visible = true;
                dgvControl.Columns[clmTipoMaterial.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                if (hora == 19)
                    DS = clsConnection.getDataSetResult("CALL spRawDepotHistoryTotalSile3ByDate(" + hasta.Day.ToString() + "," + hasta.Month.ToString() + "," + hasta.Year.ToString() + "," + "19)");
                else if (hora == 7)
                    DS = clsConnection.getDataSetResult("CALL spRawDepotHistoryTotalSile3ByDate(" + hasta.Day.ToString() + "," + hasta.Month.ToString() + "," + hasta.Year.ToString() + "," + "7)");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        if ((Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000) != 0.00)
                        {
                            dgvControl.Rows.Add();
                            int fila = dgvControl.Rows.Count - 1;
                            dgvControl.Rows[fila].Cells[clmMaterial.Index].Value = DS.Tables[0].Rows[i]["Material"];
                            dgvControl.Rows[fila].Cells[clmCodMaterial.Index].Value = DS.Tables[0].Rows[i]["CodMaterial"];
                            dgvControl.Rows[fila].Cells[clmTipoMaterial.Index].Value = DS.Tables[0].Rows[i]["TipoMaterial"];
                            dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                        }
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            if (id == "ExtrusionSilo3_2")
            {
                this.Text = "Detalle de Extrusion Silo 3";
                dgvControl.Columns[clmMaterial.Index].Visible = true;
                dgvControl.Columns[clmCodMaterial.Index].Visible = true;
                dgvControl.Columns[clmTipoMaterial.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spRawDepotHistoryTotalSile3ByDate(" + desde.Day.ToString() + "," + desde.Month.ToString() + "," + desde.Year.ToString() + "," + "0)");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        if ((Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000) != 0.00)
                        {
                            dgvControl.Rows.Add();
                            int fila = dgvControl.Rows.Count - 1;
                            dgvControl.Rows[fila].Cells[clmMaterial.Index].Value = DS.Tables[0].Rows[i]["Material"];
                            dgvControl.Rows[fila].Cells[clmCodMaterial.Index].Value = DS.Tables[0].Rows[i]["CodMaterial"];
                            dgvControl.Rows[fila].Cells[clmTipoMaterial.Index].Value = DS.Tables[0].Rows[i]["TipoMaterial"];
                            dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                        }
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            if (id == "Silo3Final")
            {
                this.Text = "Detalle de Extrusion Silo 3";
                dgvControl.Columns[clmMaterial.Index].Visible = true;
                dgvControl.Columns[clmCodMaterial.Index].Visible = true;
                dgvControl.Columns[clmTipoMaterial.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spRawDepotHistoryTotalSile3ByDate(" + hasta.Day.ToString() + "," + hasta.Month.ToString() + "," + hasta.Year.ToString() + "," + "0)");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        if ((Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000) != 0.00)
                        {
                            dgvControl.Rows.Add();
                            int fila = dgvControl.Rows.Count - 1;
                            dgvControl.Rows[fila].Cells[clmMaterial.Index].Value = DS.Tables[0].Rows[i]["Material"];
                            dgvControl.Rows[fila].Cells[clmCodMaterial.Index].Value = DS.Tables[0].Rows[i]["CodMaterial"];
                            dgvControl.Rows[fila].Cells[clmTipoMaterial.Index].Value = DS.Tables[0].Rows[i]["TipoMaterial"];
                            dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                        }
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #region Silo 4
            if (id == "ExtrusionSilo4")
            {
                this.Text = "Detalle de Extrusion Silo 4";
                dgvControl.Columns[clmMaterial.Index].Visible = true;
                dgvControl.Columns[clmCodMaterial.Index].Visible = true;
                dgvControl.Columns[clmTipoMaterial.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                if (hora == 19)
                    DS = clsConnection.getDataSetResult("CALL spRawDepotHistoryTotalSile4ByDate(" + hasta.Day.ToString() + "," + hasta.Month.ToString() + "," + hasta.Year.ToString() + "," + "19)");
                else if (hora == 7)
                    DS = clsConnection.getDataSetResult("CALL spRawDepotHistoryTotalSile4ByDate(" + hasta.Day.ToString() + "," + hasta.Month.ToString() + "," + hasta.Year.ToString() + "," + "7)");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        if ((Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000) != 0.00)
                        {
                            dgvControl.Rows.Add();
                            int fila = dgvControl.Rows.Count - 1;
                            dgvControl.Rows[fila].Cells[clmMaterial.Index].Value = DS.Tables[0].Rows[i]["Material"];
                            dgvControl.Rows[fila].Cells[clmCodMaterial.Index].Value = DS.Tables[0].Rows[i]["CodMaterial"];
                            dgvControl.Rows[fila].Cells[clmTipoMaterial.Index].Value = DS.Tables[0].Rows[i]["TipoMaterial"];
                            dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                        }
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            if (id == "ExtrusionSilo4_2")
            {
                this.Text = "Detalle de Extrusion Silo 4";
                dgvControl.Columns[clmMaterial.Index].Visible = true;
                dgvControl.Columns[clmCodMaterial.Index].Visible = true;
                dgvControl.Columns[clmTipoMaterial.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("CALL spRawDepotHistoryTotalSile4ByDate(" + desde.Day.ToString() + "," + desde.Month.ToString() + "," + desde.Year.ToString() + "," + "0)");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        if ((Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000) != 0.00)
                        {
                            dgvControl.Rows.Add();
                            int fila = dgvControl.Rows.Count - 1;
                            dgvControl.Rows[fila].Cells[clmMaterial.Index].Value = DS.Tables[0].Rows[i]["Material"];
                            dgvControl.Rows[fila].Cells[clmCodMaterial.Index].Value = DS.Tables[0].Rows[i]["CodMaterial"];
                            dgvControl.Rows[fila].Cells[clmTipoMaterial.Index].Value = DS.Tables[0].Rows[i]["TipoMaterial"];
                            dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                        }
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            if (id == "Silo4Final")
            {
                this.Text = "Detalle de Extrusion Silo 4";
                dgvControl.Columns[clmMaterial.Index].Visible = true;
                dgvControl.Columns[clmCodMaterial.Index].Visible = true;
                dgvControl.Columns[clmTipoMaterial.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("CALL spRawDepotHistoryTotalSile4ByDate(" + hasta.Day.ToString() + "," + hasta.Month.ToString() + "," + hasta.Year.ToString() + "," + "0)");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        if ((Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000) != 0.00)
                        {
                            dgvControl.Rows.Add();
                            int fila = dgvControl.Rows.Count - 1;
                            dgvControl.Rows[fila].Cells[clmMaterial.Index].Value = DS.Tables[0].Rows[i]["Material"];
                            dgvControl.Rows[fila].Cells[clmCodMaterial.Index].Value = DS.Tables[0].Rows[i]["CodMaterial"];
                            dgvControl.Rows[fila].Cells[clmTipoMaterial.Index].Value = DS.Tables[0].Rows[i]["TipoMaterial"];
                            dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000).ToString("0.00");
                        }
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
            #endregion

            #region Molino
            if (id == "Molino")
            {
                this.Text = "Detalle de Molino";
                dgvControl.Columns[clmMaterial.Index].Visible = true;
                dgvControl.Columns[clmSubtotal.Index].Visible = true;
                DataSet DS = new DataSet();
                horario = desde.ToShortTimeString();
                horario2 = hasta.ToShortTimeString();
                DS = clsConnection.getDataSetResult("CALL spRawMaterialMovementsTotalByDate '" + desde.ToString("dd/MM/yyyy") + " " + horario + "', '" + hasta.ToString("dd/MM/yyyy") + " " + horario2 + "'");

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dgvControl.Rows.Add();
                        int fila = dgvControl.Rows.Count - 1;
                        dgvControl.Rows[fila].Cells[clmMaterial.Index].Value = DS.Tables[0].Rows[i]["NombreMat"];
                        dgvControl.Rows[fila].Cells[clmSubtotal.Index].Value = (Convert.ToDouble(DS.Tables[0].Rows[i]["pesoRaw"]) / 1000).ToString("0.00");
                        total += Convert.ToDouble(DS.Tables[0].Rows[i]["pesoRaw"]) / 1000;
                    }
                }
                txtTotal.Text = total.ToString("0.00");
            }
            #endregion
        }
        public void hideAll()
        {
            dgvControl.Columns[clmExtrusora.Index].Visible = false;
            dgvControl.Columns[clmMateriaPrima.Index].Visible = false;
            dgvControl.Columns[clmPelicula.Index].Visible = false;
            dgvControl.Columns[clmScrap.Index].Visible = false;
            dgvControl.Columns[clmSubtotal.Index].Visible = false;
            dgvControl.Columns[clmPlanta.Index].Visible = false;
            dgvControl.Columns[clmCliente.Index].Visible = false;
            dgvControl.Columns[clmDeposito.Index].Visible = false;
            dgvControl.Columns[clmMaterial.Index].Visible = false;
            dgvControl.Columns[clmCodMaterial.Index].Visible = false;
            dgvControl.Columns[clmTipoMaterial.Index].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvControl.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
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
                dgvControl.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
        }
        private void copyAlltoClipboard()
        {
            dgvControl.SelectAll();
            DataObject dataObj = dgvControl.GetClipboardContent();
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
    }
}
