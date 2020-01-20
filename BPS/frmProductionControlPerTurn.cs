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
    public partial class frmProductionControlPerTurn : Form
    {
        double metalized = 0;
        double MetMerma = 0;
        double CPprimera = 0;
        double CPobs = 0;
        double CPOP1 = 0;
        double CPbase = 0;
        double CPMerma = 0;
        double AtlasMetal = 0;
        double AtlasSecundario = 0;
        double AtlasMermaMetal = 0;
        double AtlasMermaSecundario = 0;
        double AtlasPrimeraMet = 0;
        double AtlasPPMet = 0;
        double AtlasOP1Met = 0;
        double AtlasPrimeraSec = 0;
        double AtlasPPSec = 0;
        double AtlasOP1Sec = 0;
        double TitanSecundario = 0;
        double TitanPrimeraSec = 0;
        double TitanPPSec = 0;
        double TitanOP1Sec = 0;
        double TitanMerma = 0;
        double ExtrusoraProduccion = 0;
        double ExtrusoraMerma = 0;
        double ExtrusoraRecup = 0;
        double ExtrusoraRecupTotal = 0;
        double ExtrusoraRecupPorcentaje = 0;
        double DepDevoluciones = 0;
        double DepDespachos = 0;
        double DepImportaciones = 0;
        double DepPrimera = 0;
        double DepProceso = 0;
        double DepOP1 = 0;
        double RackPStock = 0;
        double RackSBases = 0;
        double RackSMetal = 0;
        double ExtrusoraStockMP = 0;
        double Silo3 = 0;
        double Silo4 = 0;
        double StockMP = 0;
        double Molino = 0;
        double SwapPlus = 0;
        double SwapMinus = 0;
        public frmProductionControlPerTurn()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void getPrimaryCutter()
        {
            DataSet DS = new DataSet();
            string time = ""; string time2 = "";
            string texto;
            if (cmbTurno.SelectedIndex == 0)
            {
                time = "07:00";
                time2 = "19:00";
                texto = "CALL spCuttingReport '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time + "', '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time2 + "'";
                DS = clsConnection.getDataSetResult(texto);
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                time = "19:00";
                time2 = "07:00";
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = "CALL spCuttingReport '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time + "', '" + diasiguiente.ToShortDateString() + " " + time2 + "'";
                DS = clsConnection.getDataSetResult(texto);
            }

            CPprimera = 0;
            CPobs = 0;
            CPOP1 = 0;
            CPbase = 0;
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    string producto = DS.Tables[0].Rows[i]["Producto"].ToString();
                    if (DS.Tables[0].Rows[i]["Calificación"].ToString() == "Primera" && DS.Tables[0].Rows[i]["Tipo"].ToString() == "Corte Primario")
                        CPprimera += Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"].ToString());
                    else if (DS.Tables[0].Rows[i]["Calificación"].ToString() == "Observación" && DS.Tables[0].Rows[i]["Tipo"].ToString() == "Corte Primario")
                        CPobs += Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"].ToString());
                    else if (DS.Tables[0].Rows[i]["Calificación"].ToString() == "Segunda" && DS.Tables[0].Rows[i]["Tipo"].ToString() == "Corte Primario")
                        CPOP1 += Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"].ToString());
                    if (producto.Substring(producto.Length - 2, 1) == "M" && DS.Tables[0].Rows[i]["Tipo"].ToString() == "Corte Primario")
                        CPbase += Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"].ToString());
                }
                CPprimera = CPprimera / 1000;
                CPobs = CPobs / 1000;
                CPOP1 = CPOP1 / 1000;
                CPbase = CPbase / 1000;
            }
        }
        public void getSecondaryCutter()
        {
            DataSet DS = new DataSet();
            string time = ""; string time2 = "";
            string texto;
            if (cmbTurno.SelectedIndex == 0)
            {
                time = "07:00";
                time2 = "19:00";
                texto = "CALL spCuttingReport '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time + "', '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time2 + "'";
                DS = clsConnection.getDataSetResult(texto);
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                time = "19:00";
                time2 = "07:00";
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = "CALL spCuttingReport '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time + "', '" + diasiguiente.ToShortDateString() + " " + time2 + "'";
                DS = clsConnection.getDataSetResult(texto);
            }
            AtlasMetal = 0;
            AtlasSecundario = 0;
            TitanSecundario = 0;
            AtlasPrimeraMet = 0;
            AtlasPPMet = 0;
            AtlasOP1Met = 0;
            AtlasPrimeraSec = 0;
            AtlasPPSec = 0;
            AtlasOP1Sec = 0;
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {      
                    if(DS.Tables[0].Rows[i]["Maquina"].ToString() == "SEC. ATLAS")
                    {
                        if(DS.Tables[0].Rows[i]["Tipo"].ToString() == "Corte Metal")
                        {
                            AtlasMetal += Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"].ToString());
                            if(DS.Tables[0].Rows[i]["Calificación"].ToString() == "Primera")
                                AtlasPrimeraMet += Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"].ToString());
                            if (DS.Tables[0].Rows[i]["Calificación"].ToString() == "Observación")
                                AtlasPPMet += Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"].ToString());
                            if (DS.Tables[0].Rows[i]["Calificación"].ToString() == "Segunda")
                                AtlasOP1Met += Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"].ToString());
                        }
                        else if (DS.Tables[0].Rows[i]["Tipo"].ToString() == "Corte Secundario")
                        {
                            AtlasSecundario += Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"].ToString());
                            if(DS.Tables[0].Rows[i]["Calificación"].ToString() == "Primera")
                                AtlasPrimeraSec += Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"].ToString());
                            if (DS.Tables[0].Rows[i]["Calificación"].ToString() == "Observación")
                                AtlasPPSec += Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"].ToString());
                            if (DS.Tables[0].Rows[i]["Calificación"].ToString() == "Segunda")
                                AtlasOP1Sec += Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"].ToString());
                        }
                    }
                    else if(DS.Tables[0].Rows[i]["Maquina"].ToString() == "TITAN")
                    {
                        if(DS.Tables[0].Rows[i]["Tipo"].ToString() == "Corte Secundario")
                        {
                            TitanSecundario += Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"].ToString());
                            if(DS.Tables[0].Rows[i]["Calificación"].ToString() == "Primera")
                               TitanPrimeraSec += Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"].ToString());
                            if (DS.Tables[0].Rows[i]["Calificación"].ToString() == "Observación")
                                TitanPPSec += Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"].ToString());
                            if (DS.Tables[0].Rows[i]["Calificación"].ToString() == "Segunda")
                                TitanOP1Sec += Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"].ToString());
                        }
                    }
                }
            }
            AtlasMetal = AtlasMetal / 1000;
            AtlasSecundario = AtlasSecundario / 1000;
            AtlasPrimeraMet = AtlasPrimeraMet / 1000;
            AtlasPPMet = AtlasPPMet / 1000;
            AtlasOP1Met = AtlasOP1Met / 1000;
            AtlasPrimeraSec = AtlasPrimeraSec / 1000;
            AtlasPPSec = AtlasPPSec / 1000;
            AtlasOP1Sec = AtlasOP1Sec / 1000;
            TitanSecundario = TitanSecundario / 1000;
            TitanPrimeraSec = TitanPrimeraSec / 1000;
            TitanPPSec = TitanPPSec / 1000;
            TitanOP1Sec = TitanOP1Sec / 1000;
        }
        public void getMetalizerProduction()
        {
            DataSet DS = new DataSet();
            string time = ""; string time2 = "";
            string texto;
            if (cmbTurno.SelectedIndex == 0)
            {
                time = "07:00:00";
                time2 = "19:00:00";
                texto = "CALL spMetalizedReportByPlantTotalized '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time + "', '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time2 + "', 4";
                DS = clsConnection.getDataSetResult(texto);
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                time = "19:00:00";
                time2 = "07:00:00";
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = "CALL spMetalizedReportByPlantTotalized '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time + "', '" + diasiguiente.ToShortDateString() + " " + time2 + "', 4";
                DS = clsConnection.getDataSetResult(texto);
            }
            metalized = 0;
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                metalized = (Convert.ToDouble(DS.Tables[0].Rows[0]["MetalTotal"]) / 1000);
            }
        }
        public void getMermas()
        {
            DataSet DS = new DataSet();
            string time = ""; string time2 = "";
            string texto;
            if (cmbTurno.SelectedIndex == 0)
            {
                time = "07:00";
                time2 = "19:00";
                texto = "CALL spScrapPalletByDate '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time + "', '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time2 + "'";
                DS = clsConnection.getDataSetResult(texto);
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                time = "19:00";
                time2 = "07:00";
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = "CALL spScrapPalletByDate '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time + "', '" + diasiguiente.ToShortDateString() + " " + time2 + "'";
                DS = clsConnection.getDataSetResult(texto);
            }

            CPMerma = 0;
            AtlasMermaMetal = 0;
            AtlasMermaSecundario = 0;
            TitanMerma = 0;
            ExtrusoraMerma = 0;
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (DS.Tables[0].Rows[i]["Maquina"].ToString() == "TITAN")
                        TitanMerma += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"].ToString());
                    else if (DS.Tables[0].Rows[i]["Maquina"].ToString() == "SEC. ATLAS" && DS.Tables[0].Rows[i]["nomScrap"].ToString() == "SCRAP METAL")
                        AtlasMermaMetal += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"].ToString());
                    else if (DS.Tables[0].Rows[i]["Maquina"].ToString() == "SEC. ATLAS" && DS.Tables[0].Rows[i]["nomScrap"].ToString() == "SCRAP CRISTAL")
                        AtlasMermaSecundario += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"].ToString());
                    else if (DS.Tables[0].Rows[i]["Maquina"].ToString() == "GOEBEL")
                        CPMerma += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"].ToString());
                }
            }
            if (cmbTurno.SelectedIndex == 0)
            {
                time = "07:00";
                time2 = "19:00";
                texto = "CALL spScrapByMachineByDateTotalized '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time + "', '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time2 + "', 3028";
                DS = clsConnection.getDataSetResult(texto);
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                time = "19:00";
                time2 = "07:00";
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = "CALL spScrapByMachineByDateTotalized '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time + "', '" + diasiguiente.ToShortDateString() + " " + time2 + "', 3028";
                DS = clsConnection.getDataSetResult(texto);
            }
            MetMerma = 0;
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    MetMerma += Convert.ToDouble(DS.Tables[0].Rows[i]["ScrapTotal"].ToString());
                }
            }
            if (cmbTurno.SelectedIndex == 0)
            {
                time = "07:00";
                time2 = "19:00";
                texto = "CALL spScrapByMachineByDateTotalized '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time + "', '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time2 + "', 3024";
                DS = clsConnection.getDataSetResult(texto);
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                time = "19:00";
                time2 = "07:00";
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = "CALL spScrapByMachineByDateTotalized '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time + "', '" + diasiguiente.ToShortDateString() + " " + time2 + "', 3024";
                DS = clsConnection.getDataSetResult(texto);
            }
            ExtrusoraMerma = 0;
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    MetMerma += Convert.ToDouble(DS.Tables[0].Rows[i]["ScrapTotal"].ToString());
                }
            }

            CPMerma = CPMerma / 1000;
            AtlasMermaMetal = AtlasMermaMetal / 1000;
            AtlasMermaSecundario = AtlasMermaSecundario / 1000;
            TitanMerma = TitanMerma / 1000;
            MetMerma = MetMerma / 1000;
            ExtrusoraMerma = ExtrusoraMerma / 1000;
        }
        public void getExtruder()
        {
            DataSet DS = new DataSet();
            string time = ""; string time2 = "";
            string texto;
            if (cmbTurno.SelectedIndex == 0)
            {
                time = "07:00";
                time2 = "19:00";
                texto = "CALL spMainCoilReportByDate '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time + "', '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time2 + "'";
                DS = clsConnection.getDataSetResult(texto);
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                time = "19:00";
                time2 = "07:00";
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = "CALL spMainCoilReportByDate '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time + "', '" + diasiguiente.ToShortDateString() + " " + time2 + "'";
                DS = clsConnection.getDataSetResult(texto);
            }
            ExtrusoraProduccion = 0;
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    ExtrusoraProduccion += Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"].ToString());
                }
            }


            if (cmbTurno.SelectedIndex == 0)
            {
                time = "07:00";
                time2 = "19:00";
                texto = "CALL spRawMaterialMovementsTotalByDateAndRecup '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time + "', '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time2 + "'";
                DS = clsConnection.getDataSetResult(texto);
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                time = "19:00";
                time2 = "07:00";
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = "CALL spRawMaterialMovementsTotalByDateAndRecup '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time + "', '" + diasiguiente.ToShortDateString() + " " + time2 + "'";
                DS = clsConnection.getDataSetResult(texto);
            }
            ExtrusoraRecup = 0;
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    ExtrusoraRecup += Convert.ToDouble(DS.Tables[0].Rows[i]["pesoRaw"].ToString());
                }
            }


            if (cmbTurno.SelectedIndex == 0)
            {
                time = "07:00";
                time2 = "19:00";
                texto = "CALL spRawMaterialMovementsTotalByDateAndConsumption '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time + "', '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time2 + "'";
                DS = clsConnection.getDataSetResult(texto);
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                time = "19:00";
                time2 = "07:00";
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = "CALL spRawMaterialMovementsTotalByDateAndConsumption '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time + "', '" + diasiguiente.ToShortDateString() + " " + time2 + "'";
                DS = clsConnection.getDataSetResult(texto);
            }
            ExtrusoraRecupTotal = 0;
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    ExtrusoraRecupTotal += Convert.ToDouble(DS.Tables[0].Rows[i]["pesoRaw"].ToString());
                }
            }
            ExtrusoraRecup = ExtrusoraRecup / 1000;
            ExtrusoraRecupTotal = ExtrusoraRecupTotal / 1000;
            if(ExtrusoraRecupTotal!=0)
                ExtrusoraRecupPorcentaje = (ExtrusoraRecup * 100) / ExtrusoraRecupTotal;
            ExtrusoraProduccion = ExtrusoraProduccion / 1000;
            if (ExtrusoraRecupTotal != 0)
                ExtrusoraRecupPorcentaje = (ExtrusoraRecup * 100) / ExtrusoraProduccion;
        }
        public void getReturnsAndShippings()
        {
            DataSet DS = new DataSet();
            string time = ""; string time2 = "";
            string texto;
            if (cmbTurno.SelectedIndex == 0)
            {
                time = "07:00";
                time2 = "19:00";
                texto = "CALL spShippingByDate '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time + "', '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time2 + "'";
                DS = clsConnection.getDataSetResult(texto);
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                time = "19:00";
                time2 = "07:00";
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = "CALL spShippingByDate '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time + "', '" + diasiguiente.ToShortDateString() + " " + time2 + "'";
                DS = clsConnection.getDataSetResult(texto);
            }
            DepDespachos = 0;
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (DS.Tables[0].Rows[i]["Planta"].ToString()=="Pilar")
                        DepDespachos += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"].ToString());
                }
            }



            if (cmbTurno.SelectedIndex == 0)
            {
                time = "07:00";
                time2 = "19:00";
                texto = "CALL spReturnByDate '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time + "', '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time2 + "'";
                DS = clsConnection.getDataSetResult(texto);
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                time = "19:00";
                time2 = "07:00";
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = "CALL spReturnByDate '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time + "', '" + diasiguiente.ToShortDateString() + " " + time2 + "'";
                DS = clsConnection.getDataSetResult(texto);
            }
            DepDevoluciones = 0;
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (DS.Tables[0].Rows[i]["Planta"].ToString() == "Pilar")
                    DepDevoluciones += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"].ToString());
                }
            }


            if (cmbTurno.SelectedIndex == 0)
            {
                time = "07:00";
                time2 = "19:00";
                texto = "CALL spReporteImportaciones '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time + "', '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time2 + "'";
                DS = clsConnection.getDataSetResult(texto);
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                time = "19:00";
                time2 = "07:00";
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = "CALL spReporteImportaciones '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time + "', '" + diasiguiente.ToShortDateString() + " " + time2 + "'";
                DS = clsConnection.getDataSetResult(texto);
            }
            DepImportaciones = 0;
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    DepImportaciones += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"].ToString());
                }
            }

            if (cmbTurno.SelectedIndex == 0)
            {
                time = "07:00";
                time2 = "19:00";
                texto = "CALL spSwapReportByDate '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time + "', '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time2 + "',0,0";
                DS = clsConnection.getDataSetResult(texto);
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                time = "19:00";
                time2 = "07:00";
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = "CALL spSwapReportByDate '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time + "', '" + diasiguiente.ToShortDateString() + " " + time2 + "',0,0";
                DS = clsConnection.getDataSetResult(texto);
            }
            SwapPlus = 0;
            SwapMinus = 0;
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (DS.Tables[0].Rows[i]["PlantaOrigen"].ToString() == "Pilar")
                        SwapMinus += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                    if (DS.Tables[0].Rows[i]["PlantaOrigen"].ToString() == "Campana")
                        SwapPlus += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                }
            }
            SwapPlus = SwapPlus / 1000;
            SwapMinus = SwapMinus / 1000;
            DepImportaciones = DepImportaciones / 1000;
            DepDevoluciones = DepDevoluciones / 1000;
            DepDespachos = DepDespachos / 1000;
        }
        public void getRacks()
        {
            DataSet DS = new DataSet();
            string texto;
            if (cmbTurno.SelectedIndex == 0)
            {
                texto = "CALL spRackHistoryReport("+dtpFecha.Value.Day.ToString()+","+dtpFecha.Value.Month+","+dtpFecha.Value.Year+","+"19)";
                DS = clsConnection.getDataSetResult(texto);
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                texto = "CALL spRackHistoryReport(" + dtpFecha.Value.AddDays(1).Day.ToString()+"," + dtpFecha.Value.Month + "," + dtpFecha.Value.Year + "," + "7)";
                DS = clsConnection.getDataSetResult(texto);
            }
            RackPStock = 0;
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                        RackPStock += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
            }
            if (cmbTurno.SelectedIndex == 0)
            {
                texto = "CALL spSecundaryRackHistoryReport(" + dtpFecha.Value.Day.ToString() + "," + dtpFecha.Value.Month + "," + dtpFecha.Value.Year + "," + "19)";
                DS = clsConnection.getDataSetResult(texto);
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                texto = "CALL spSecundaryRackHistoryReport(" +  dtpFecha.Value.AddDays(1).Day.ToString() + "," + dtpFecha.Value.Month + "," + dtpFecha.Value.Year + "," + "7)";
                DS = clsConnection.getDataSetResult(texto);
            }
            RackSBases = 0;
            RackSMetal = 0;
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    string codigo = DS.Tables[0].Rows[i]["Pelicula"].ToString();
                        if (codigo.Substring(0, 1) == "B")
                            RackSBases += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                        else if (codigo.Substring(0, 1) == "M" || codigo.Substring(0, 1) == "N")
                            RackSMetal += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                }
            }




            if (cmbTurno.SelectedIndex == 0)
            {
                texto = "CALL spDepotCoilHistory(" + dtpFecha.Value.Day.ToString() + "," + dtpFecha.Value.Month + "," + dtpFecha.Value.Year + "," + "19)";
                DS = clsConnection.getDataSetResult(texto);
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                texto = "CALL spDepotCoilHistory(" + dtpFecha.Value.AddDays(1).Day.ToString() + "," + dtpFecha.Value.Month + "," + dtpFecha.Value.Year + "," + "7)";
                DS = clsConnection.getDataSetResult(texto);
            }
            DepPrimera = 0;
            DepProceso = 0;
            DepOP1 = 0;
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (DS.Tables[0].Rows[i]["Calidad"].ToString() == "Primera")
                        DepPrimera += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                    else if (DS.Tables[0].Rows[i]["Calidad"].ToString() == "Observación")
                        DepProceso += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                    else if (DS.Tables[0].Rows[i]["Calidad"].ToString() == "Segunda")
                        DepOP1 += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                }
            }


            RackPStock = RackPStock / 1000;
            RackSBases = RackSBases / 1000;
            RackSMetal = RackSMetal / 1000;
            DepPrimera = DepPrimera / 1000;
            DepProceso = DepProceso / 1000;
            DepOP1 = DepOP1 / 1000;
        }
        public void getExtruderDepAndDepMP()
        {
            DataSet DS = new DataSet();
            string texto;
            if (cmbTurno.SelectedIndex == 0)
            {
                texto = "CALL spRawDepotHistoryByDate(" + dtpFecha.Value.Day.ToString() + "," + dtpFecha.Value.Month + "," + dtpFecha.Value.Year + "," + "19)";
                DS = clsConnection.getDataSetResult(texto);
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                texto = "CALL spRawDepotHistoryByDate(" + dtpFecha.Value.AddDays(1).Day.ToString() + "," + dtpFecha.Value.Month + "," + dtpFecha.Value.Year + "," + "7)";
                DS = clsConnection.getDataSetResult(texto);
            }
            ExtrusoraStockMP = 0;
            Silo3 = 0;
            Silo4 = 0;
            StockMP = 0;
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (DS.Tables[0].Rows[i]["Deposito"].ToString() == "Extrusion Pilar")
                        if (DS.Tables[0].Rows[i]["NumTipo"].ToString() != "35")
                            ExtrusoraStockMP += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                    if (DS.Tables[0].Rows[i]["Deposito"].ToString() == "Silo Pilar 3")
                        Silo3 += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                    if (DS.Tables[0].Rows[i]["Deposito"].ToString() == "Silo Pilar 4")
                        Silo4 += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                    if (DS.Tables[0].Rows[i]["Deposito"].ToString() == "Materia Prima Pilar")
                        if (DS.Tables[0].Rows[i]["NumTipo"].ToString() != "35")
                            StockMP += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                }
            }
            ExtrusoraStockMP = ExtrusoraStockMP / 1000;
            Silo3 = Silo3 / 1000;
            Silo4 = Silo4 / 1000;
            StockMP = StockMP / 1000;
        }
        public void getMill()
        {
            DataSet DS = new DataSet();
            string texto;
            if (cmbTurno.SelectedIndex == 0)
            {
                texto = "CALL spRawMaterialMovementsByDate '" + dtpFecha.Value.ToString("dd/MM/yyyy") + "  07:00', '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00'";
                DS = clsConnection.getDataSetResult(texto);
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = "CALL spRawMaterialMovementsByDate '" + dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00', '" + diasiguiente.ToShortDateString() + " 07:00'";
                DS = clsConnection.getDataSetResult(texto);
            }
            Molino = 0;
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (DS.Tables[0].Rows[i]["tipoMov"].ToString() == "Produccion de Materia prima del molino")
                    Molino += Convert.ToDouble(DS.Tables[0].Rows[i]["pesoRaw"].ToString());
                }
            }
            Molino = Molino / 1000;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                getRacks();
                getMetalizerProduction();
                getPrimaryCutter();
                getSecondaryCutter();
                getMermas();
                getExtruder();
                getReturnsAndShippings();
                getExtruderDepAndDepMP();
                getMill();
                //Metalizadora
                txtMetalizadoMetalizadora.Text = metalized.ToString("0");
                //Metalizadora
                //Cortadora primaria
                txtPrimera.Text = CPprimera.ToString("0");
                txtProductoEnProceso.Text = CPobs.ToString("0");
                txtOP1Primaria.Text = CPOP1.ToString("0");
                txtCortePrimario.Text = (CPprimera + CPOP1 + CPobs).ToString("0");
                txtCorteBase.Text = CPbase.ToString("0");
                txtMermaPrimaria.Text = CPMerma.ToString("0");
                txtCorteTotal.Text = (CPprimera + CPOP1 + CPobs).ToString("0");
                //Cortadora primaria
                //Cortadora Atlas
                txtCorteMetalAtlas.Text = AtlasMetal.ToString("0");
                txtCorteSecundarioAtlas.Text = AtlasSecundario.ToString("0");
                txtMermaMetalAtlas.Text = AtlasMermaMetal.ToString("0");
                txtMermaSecundarioAtlas.Text = AtlasMermaSecundario.ToString("0");
                txtAtlas.Text = (AtlasSecundario + AtlasMetal).ToString("0");
                txtMetPrimeraAtlas.Text = AtlasPrimeraMet.ToString("0");
                txtMetPPAtlas.Text = AtlasPPMet.ToString("0");
                txtMetOP1Atlas.Text = AtlasOP1Met.ToString("0");
                txtSecPrimeraAtlas.Text = AtlasPrimeraSec.ToString("0");
                txtSecPPAtlas.Text = AtlasPPSec.ToString("0");
                txtSecOP1Atlas.Text = AtlasOP1Sec.ToString("0");
                //Cortadora Atlas
                //Cortadora Titan
                txtMermaTitan.Text = TitanMerma.ToString("0");
                txtTitan.Text = TitanSecundario.ToString("0");
                txtSecPrimeraTitan.Text = TitanPrimeraSec.ToString("0");
                txtSecPPTitan.Text = TitanPPSec.ToString("0");
                txtSecOP1Titan.Text = TitanOP1Sec.ToString("0");
                //Cortadora Titan
                //Extrusora
                txtProduccionExtrusora.Text = ExtrusoraProduccion.ToString("0");
                txtMermaExtrusora.Text = ExtrusoraMerma.ToString("0");
                //Extrusora
                //Deposito PT, PP y OP1
                txtSwapPlus.Text = SwapPlus.ToString("0");
                txtSwapMinus.Text = SwapMinus.ToString("0");
                txtDespachosDeposito.Text = DepDespachos.ToString("0");
                txtDevolucionesDeposito.Text = DepDevoluciones.ToString("0");
                txtImportacionesDeposito.Text = DepImportaciones.ToString("0");
                txtPrimeraDeposito.Text = DepPrimera.ToString("0");
                txtProductoEnProcesoDeposito.Text = DepProceso.ToString("0");
                txtOP1Deposito.Text = DepOP1.ToString("0");
                //Deposito PT, PP y OP1
                //Racks
                txtStockPrimario.Text = RackPStock.ToString("0");
                txtStockBasesSecundario.Text = RackSBases.ToString("0");
                txtStockMetalSecundario.Text = RackSMetal.ToString("0");
                //Racks
                //Deposito Extrusion
                txtStockExtrusion.Text = ExtrusoraStockMP.ToString("0");
                txtSilo3.Text = Silo3.ToString("0");
                txtSilo4.Text = Silo4.ToString("0");
                //Deposito Extrusion
                //DepositoMP
                txtStockMP.Text = StockMP.ToString("0");
                //DepositoMP
                //Molino
                txtStockMolino.Text = Molino.ToString("0");
                //Molino
            }
        }
        public bool Validar()
        {
            bool bandera = true;
            if (cmbTurno.SelectedIndex == -1)
            {
                lblError.Visible = true;
                bandera = false;
            }
            else
                lblError.Visible = false;
            return bandera;
        }
        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
        #region Double Click
        private void txtPrimera_DoubleClick(object sender, EventArgs e)
        {
            string time = ""; string time2 = "";
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                time = "07:00";
                time2 = "19:00";
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "CortadoraPrimariaPrimera"); 
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                time = "19:00";
                time2 = "07:00";
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = diasiguiente.ToShortDateString() + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "CortadoraPrimariaPrimera");
                form.Show();
            }
        }
        private void txtProductoEnProceso_DoubleClick(object sender, EventArgs e)
        {
            string time = ""; string time2 = "";
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                time = "07:00";
                time2 = "19:00";
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "CortadoraPrimariaProceso");
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                time = "19:00";
                time2 = "07:00";
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = diasiguiente.ToShortDateString() + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "CortadoraPrimariaProceso");
                form.Show();
            }
        }
        private void txtCortePrimario_DoubleClick(object sender, EventArgs e)
        {
            string time = ""; string time2 = "";
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                time = "07:00";
                time2 = "19:00";
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "CortadoraPrimariaTotal");
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                time = "19:00";
                time2 = "07:00";
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = diasiguiente.ToShortDateString() + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "CortadoraPrimariaTotal");
                form.Show();
            }
        }
        private void txtCorteTotal_DoubleClick(object sender, EventArgs e)
        {
            string time = ""; string time2 = "";
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                time = "07:00";
                time2 = "19:00";
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "CortadoraPrimariaTotal");
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                time = "19:00";
                time2 = "07:00";
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = diasiguiente.ToShortDateString() + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "CortadoraPrimariaTotal");
                form.Show();
            }
        }
        private void txtOP1Primaria_DoubleClick(object sender, EventArgs e)
        {
            string time = ""; string time2 = "";
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                time = "07:00";
                time2 = "19:00";
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "CortadoraPrimariaOP1");
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                time = "19:00";
                time2 = "07:00";
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = diasiguiente.ToShortDateString() + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "CortadoraPrimariaOP1");
                form.Show();
            }
        }
        private void txtCorteBase_DoubleClick(object sender, EventArgs e)
        {
            string time = ""; string time2 = "";
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                time = "07:00";
                time2 = "19:00";
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "CortadoraPrimariaBase");
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                time = "19:00";
                time2 = "07:00";
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = diasiguiente.ToShortDateString() + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "CortadoraPrimariaBase");
                form.Show();
            }
        }
        private void txtAtlas_DoubleClick(object sender, EventArgs e)
        {
            string time = ""; string time2 = "";
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                time = "07:00";
                time2 = "19:00";
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "CortadoraAtlas");
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                time = "19:00";
                time2 = "07:00";
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = diasiguiente.ToShortDateString() + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "CortadoraAtlas");
                form.Show();
            }
        }
        private void txtCorteMetalAtlas_DoubleClick(object sender, EventArgs e)
        {
            string time = ""; string time2 = "";
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                time = "07:00";
                time2 = "19:00";
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "CortadoraAtlasMetal");
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                time = "19:00";
                time2 = "07:00";
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = diasiguiente.ToShortDateString() + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "CortadoraAtlasMetal");
                form.Show();
            }
        }
        private void txtCorteSecundarioAtlas_DoubleClick(object sender, EventArgs e)
        {
            string time = ""; string time2 = "";
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                time = "07:00";
                time2 = "19:00";
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "CortadoraAtlasSecundario");
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                time = "19:00";
                time2 = "07:00";
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = diasiguiente.ToShortDateString() + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "CortadoraAtlasSecundario");
                form.Show();
            }
        }
        private void txtTitan_DoubleClick(object sender, EventArgs e)
        {
            string time = ""; string time2 = "";
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                time = "07:00";
                time2 = "19:00";
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "CortadoraTitan");
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                time = "19:00";
                time2 = "07:00";
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = diasiguiente.ToShortDateString() + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "CortadoraTitan");
                form.Show();
            }
        }
        private void txtCorteSecundarioTitan_DoubleClick(object sender, EventArgs e)
        {
            string time = ""; string time2 = "";
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                time = "07:00";
                time2 = "19:00";
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "CortadoraTitanSecundario");
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                time = "19:00";
                time2 = "07:00";
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = diasiguiente.ToShortDateString() + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "CortadoraTitanSecundario");
                form.Show();
            }
        }
        private void txtMetalizadoMetalizadora_DoubleClick(object sender, EventArgs e)
        {
            string time = ""; string time2 = "";
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                time = "07:00";
                time2 = "19:00";
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "MetalizadoraMetal");
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                time = "19:00";
                time2 = "07:00";
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = diasiguiente.ToShortDateString() + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "MetalizadoraMetal");
                form.Show();
            }
        }
        private void txtProduccionExtrusora_DoubleClick(object sender, EventArgs e)
        {
            string time = ""; string time2 = "";
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                time = "07:00";
                time2 = "19:00";
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "ExtrusoraProduccion");
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                time = "19:00";
                time2 = "07:00";
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = diasiguiente.ToShortDateString() + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "ExtrusoraProduccion");
                form.Show();
            }
        }
        private void txtMermaMetalAtlas_DoubleClick(object sender, EventArgs e)
        {
            string time = ""; string time2 = "";
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                time = "07:00";
                time2 = "19:00";
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "AtlasMermaMetal");
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                time = "19:00";
                time2 = "07:00";
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = diasiguiente.ToShortDateString() + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "AtlasMermaMetal");
                form.Show();
            }
        }
        private void txtMermaTitan_DoubleClick(object sender, EventArgs e)
        {
            string time = ""; string time2 = "";
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                time = "07:00";
                time2 = "19:00";
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "TitanMerma");
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                time = "19:00";
                time2 = "07:00";
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = diasiguiente.ToShortDateString() + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "TitanMerma");
                form.Show();
            }
        }
        private void txtMermaExtrusora_DoubleClick(object sender, EventArgs e)
        {
            string time = ""; string time2 = "";
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                time = "07:00";
                time2 = "19:00";
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "ExtrusoraMerma");
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                time = "19:00";
                time2 = "07:00";
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = diasiguiente.ToShortDateString() + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "ExtrusoraMerma");
                form.Show();
            }
        }
        private void txtMermaPrimaria_DoubleClick(object sender, EventArgs e)
        {
            string time = ""; string time2 = "";
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                time = "07:00";
                time2 = "19:00";
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "CortadoraPrimariaMerma");
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                time = "19:00";
                time2 = "07:00";
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = diasiguiente.ToShortDateString() + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "CortadoraPrimariaMerma");
                form.Show();
            }
        }
        private void txtMermaMetalizadora_DoubleClick(object sender, EventArgs e)
        {
            string time = ""; string time2 = "";
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                time = "07:00";
                time2 = "19:00";
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "MetalizadoraMerma");
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                time = "19:00";
                time2 = "07:00";
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = diasiguiente.ToShortDateString() + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "MetalizadoraMerma");
                form.Show();
            }
        }
        private void txtMermaSecundarioAtlas_DoubleClick(object sender, EventArgs e)
        {
            string time = ""; string time2 = "";
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                time = "07:00";
                time2 = "19:00";
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "AtlasMermaSecundario");
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                time = "19:00";
                time2 = "07:00";
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = diasiguiente.ToShortDateString() + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "AtlasMermaSecundario");
                form.Show();
            }
        }
        private void txtDespachosDeposito_DoubleClick(object sender, EventArgs e)
        {
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 07:00";
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "DepDespachos");
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                texto2 = diasiguiente.ToShortDateString() + " 07:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "DepDespachos");
                form.Show();
            }
        }
        private void txtDevolucionesDeposito_DoubleClick(object sender, EventArgs e)
        {
            string time = ""; string time2 = "";
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                time = "07:00";
                time2 = "19:00";
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "DepDevoluciones");
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                time = "19:00";
                time2 = "07:00";
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " " + time;
                texto2 = diasiguiente.ToShortDateString() + " " + time2;
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "DepDevoluciones");
                form.Show();
            }
        }
        private void txtStockPrimario_DoubleClick(object sender, EventArgs e)
        {
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 07:00";
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "RackPrimarioStock",19);
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                texto2 = dtpFecha.Value.AddDays(1).ToShortDateString() +" 07:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "RackPrimarioStock",7);
                form.Show();
            }
        }
        private void txtStockBasesSecundario_DoubleClick(object sender, EventArgs e)
        {
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 07:00";
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "RackSecundarioBase", 19);
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                texto2 = dtpFecha.Value.AddDays(1).ToShortDateString() + " 07:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "RackSecundarioBase", 7);
                form.Show();
            }
        }
        private void txtStockMetalSecundario_DoubleClick(object sender, EventArgs e)
        {
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 07:00";
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "RackSecundarioMetal", 19);
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                texto2 = dtpFecha.Value.AddDays(1).ToShortDateString() + " 07:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "RackSecundarioMetal", 7);
                form.Show();
            }
        }
        private void txtImportacionesDeposito_DoubleClick(object sender, EventArgs e)
        {
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 07:00";
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "DepImportaciones");
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                texto2 = diasiguiente.ToShortDateString() + " 07:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "DepImportaciones");
                form.Show();
            }
        }
        private void txtStockMP_DoubleClick(object sender, EventArgs e)
        {
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 07:00";
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "StockMP", 19);
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                texto2 = dtpFecha.Value.AddDays(1).ToShortDateString() + " 07:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "StockMP", 7);
                form.Show();
            }
        }
        private void txtStockExtrusion_DoubleClick(object sender, EventArgs e)
        {
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 07:00";
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "ExtrusionStockMP", 19);
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                texto2 = dtpFecha.Value.AddDays(1).ToShortDateString() + " 07:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "ExtrusionStockMP", 7);
                form.Show();
            }
        }
        private void txtSilo3_DoubleClick(object sender, EventArgs e)
        {
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 07:00";
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "ExtrusionSilo3", 19);
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                texto2 = dtpFecha.Value.AddDays(1).ToShortDateString() + " 07:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "ExtrusionSilo3", 7);
                form.Show();
            }
        }
        private void txtSilo4_DoubleClick(object sender, EventArgs e)
        {
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 07:00";
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "ExtrusionSilo4", 19);
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                texto2 = dtpFecha.Value.AddDays(1).ToShortDateString() + " 07:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "ExtrusionSilo4", 7);
                form.Show();
            }
        }
        private void txtPrimeraDeposito_DoubleClick(object sender, EventArgs e)
        {
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 07:00";
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "DepPrimera", 19);
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                texto2 = dtpFecha.Value.AddDays(1).ToShortDateString() + " 07:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "DepPrimera", 7);
                form.Show();
            }
        }
        private void txtProductoEnProcesoDeposito_DoubleClick(object sender, EventArgs e)
        {
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 07:00";
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "DepProceso", 19);
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                texto2 = dtpFecha.Value.AddDays(1).ToShortDateString() + " 07:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "DepProceso", 7);
                form.Show();
            }
        }
        private void txtOP1Deposito_DoubleClick(object sender, EventArgs e)
        {
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 07:00";
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "DepOP1", 19);
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                texto2 = dtpFecha.Value.AddDays(1).ToShortDateString() + " 07:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "DepOP1", 7);
                form.Show();
            }
        }
        private void txtStockMolino_DoubleClick(object sender, EventArgs e)
        {
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 07:00";
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "Molino");
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                texto2 = dtpFecha.Value.AddDays(1).ToShortDateString() + " 07:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "Molino");
                form.Show();
            }
        }
        private void txtSwapPlus_DoubleClick(object sender, EventArgs e)
        {
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 07:00";
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "SwapPlus");
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                texto2 = diasiguiente.ToShortDateString() + " 07:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "SwapPlus");
                form.Show();
            }
        }
        private void txtSwapMinus_DoubleClick(object sender, EventArgs e)
        {
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 07:00";
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "SwapMinus");
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                texto2 = diasiguiente.ToShortDateString() + " 07:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "SwapMinus");
                form.Show();
            }
        }
        #endregion

        

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtMetPrimeraAtlas_DoubleClick(object sender, EventArgs e)
        {
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 07:00";
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "AtlasMetPrimera");
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                texto2 = diasiguiente.ToShortDateString() + " 07:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "AtlasMetPrimera");
                form.Show();
            }
        }

        private void txtMetPPAtlas_DoubleClick(object sender, EventArgs e)
        {
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 07:00";
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "AtlasMetPP");
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                texto2 = diasiguiente.ToShortDateString() + " 07:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "AtlasMetPP");
                form.Show();
            }
        }

        private void txtMetOP1Atlas_DoubleClick(object sender, EventArgs e)
        {
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 07:00";
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "AtlasMetOP1");
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                texto2 = diasiguiente.ToShortDateString() + " 07:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "AtlasMetOP1");
                form.Show();
            }
        }

        private void txtSecPrimeraAtlas_DoubleClick(object sender, EventArgs e)
        {
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 07:00";
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "CortadoraAtlasSecundarioPrimera");
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                texto2 = diasiguiente.ToShortDateString() + " 07:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "CortadoraAtlasSecundarioPrimera");
                form.Show();
            }
        }

        private void txtSecPPAtlas_DoubleClick(object sender, EventArgs e)
        {
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 07:00";
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "CortadoraAtlasSecundarioPP");
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                texto2 = diasiguiente.ToShortDateString() + " 07:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "CortadoraAtlasSecundarioPP");
                form.Show();
            }
        }

        private void txtSecOP1Atlas_DoubleClick(object sender, EventArgs e)
        {
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 07:00";
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "CortadoraAtlasSecundarioOP1");
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                texto2 = diasiguiente.ToShortDateString() + " 07:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "CortadoraAtlasSecundarioOP1");
                form.Show();
            }
        }

        private void txtSecPrimeraTitan_DoubleClick(object sender, EventArgs e)
        {
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 07:00";
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "CortadoraTitanSecundarioPrimera");
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                texto2 = diasiguiente.ToShortDateString() + " 07:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "CortadoraTitanSecundarioPrimera");
                form.Show();
            }
        }

        private void txtSecPPTitan_DoubleClick(object sender, EventArgs e)
        {
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 07:00";
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "CortadoraTitanSecundarioPP");
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                texto2 = diasiguiente.ToShortDateString() + " 07:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "CortadoraTitanSecundarioPP");
                form.Show();
            }
        }

        private void txtSecOP1Titan_DoubleClick(object sender, EventArgs e)
        {
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 07:00";
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "CortadoraTitanSecundarioOP1");
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                texto2 = diasiguiente.ToShortDateString() + " 07:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "CortadoraTitanSecundarioOP1");
                form.Show();
            }
        }

        private void txtRecupExtrusora_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 07:00";
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "ExtrusoraRecup");
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                texto2 = diasiguiente.ToShortDateString() + " 07:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "ExtrusoraRecup");
                form.Show();
            }
        }

        private void txtConsumoExtrusora_DoubleClick(object sender, EventArgs e)
        {
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 07:00";
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "ExtrusoraConsum");
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                texto2 = diasiguiente.ToShortDateString() + " 07:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "ExtrusoraConsum");
                form.Show();
            }
        }

        private void txtRecup_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string texto; string texto2;
            if (cmbTurno.SelectedIndex == 0)
            {
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 07:00";
                texto2 = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "ExtrusoraRecup");
                form.Show();
            }
            else if (cmbTurno.SelectedIndex == 1)
            {
                DateTime diasiguiente = dtpFecha.Value;
                diasiguiente = dtpFecha.Value.AddDays(1);
                texto = dtpFecha.Value.ToString("dd/MM/yyyy") + " 19:00";
                texto2 = diasiguiente.ToShortDateString() + " 07:00";
                frmPCPTProductionControl form = new frmPCPTProductionControl(Convert.ToDateTime(texto), Convert.ToDateTime(texto2), "ExtrusoraRecup");
                form.Show();
            }
        }


    }
}
