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
    public partial class frmProductionControlPerDate : Form
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
        double TitanPrimeraSec = 0;
        double TitanPPSec = 0;
        double TitanOP1Sec = 0;
        double TitanSecundario = 0;
        double TitanMerma = 0;
        double ExtrusoraProduccion = 0;
        double ExtrusoraMerma = 0;
        double DepDevoluciones = 0;
        double DepDespachos = 0;
        double DepImportaciones = 0;
        double DepPrimera = 0;
        double DepPrimeraImp = 0;
        double DepProceso = 0;
        double DepOP1 = 0;
        double DepPrimeraFinal = 0;
        double DepPrimeraFinalImp = 0;
        double DepProcesoFinal = 0;
        double DepOP1Final = 0;
        double RackPStock = 0;
        double RackSBases = 0;
        double RackSMetal = 0;
        double RackPStockFinal = 0;
        double RackSBasesFinal = 0;
        double RackSMetalFinal = 0;
        double ExtrusoraStockMP = 0;
        double ExtrusoraStockMPFinal = 0;
        double ExtrusoraRecup = 0;
        double ExtrusoraRecupTotal = 0;
        double ExtrusoraRecupPorcentaje =0;
        double Silo3 = 0;
        double Silo4 = 0;
        double StockMP = 0;
        double Silo3Final = 0;
        double Silo4Final = 0;
        double StockMPFinal = 0;
        double Molino = 0;
        double MermaMolino = 0;
        //double SwapPlus = 0;
        //double SwapMinus = 0;
        public frmProductionControlPerDate()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void getPrimaryCutter()
        {
            DataSet DS = new DataSet();
            string texto;
            texto = "CALL spCuttingReport '" + dtpDesde.Value.ToString("dd/MM/yyyy") + "', '" + dtpHasta.Value.ToString("dd/MM/yyyy")+ "'";
            DS = clsConnection.getDataSetResult(texto);
            CPprimera = 0;
            CPobs = 0;
            CPOP1 = 0;
            CPbase = 0;
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    string producto = DS.Tables[0].Rows[i]["Producto"].ToString();
                    if (DS.Tables[0].Rows[i]["Tipo"].ToString() == "Corte Primario")
                    {
                        if (DS.Tables[0].Rows[i]["Calificación"].ToString() == "Primera")
                            CPprimera += Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"].ToString());

                        else if (DS.Tables[0].Rows[i]["Calificación"].ToString() == "Producto en proceso")
                            CPobs += Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"].ToString());

                        else if (DS.Tables[0].Rows[i]["Calificación"].ToString() == "PNC")
                            CPOP1 += Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"].ToString());

                        if (producto.Substring(producto.Length - 2, 1) == "M")
                            CPbase += Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"].ToString());
                    }
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
            string texto;
            texto = "CALL spCuttingReport '" + dtpDesde.Value.ToString("dd/MM/yyyy") + "', '" + dtpHasta.Value.ToString("dd/MM/yyyy") + "'";
            DS = clsConnection.getDataSetResult(texto);
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
                    if (DS.Tables[0].Rows[i]["Maquina"].ToString() == "SEC. ATLAS")
                    {
                        if (DS.Tables[0].Rows[i]["Tipo"].ToString() == "Corte Metal")
                        {
                            AtlasMetal += Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"].ToString());
                            if (DS.Tables[0].Rows[i]["Calificación"].ToString() == "Primera")
                                AtlasPrimeraMet += Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"].ToString());
                            if (DS.Tables[0].Rows[i]["Calificación"].ToString() == "Producto en proceso")
                                AtlasPPMet += Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"].ToString());
                            if (DS.Tables[0].Rows[i]["Calificación"].ToString() == "PNC")
                                AtlasOP1Met += Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"].ToString());
                        }
                        else if (DS.Tables[0].Rows[i]["Tipo"].ToString() == "Corte Secundario")
                        {
                            AtlasSecundario += Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"].ToString());
                            if (DS.Tables[0].Rows[i]["Calificación"].ToString() == "Primera")
                                AtlasPrimeraSec += Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"].ToString());
                            if (DS.Tables[0].Rows[i]["Calificación"].ToString() == "Producto en proceso")
                                AtlasPPSec += Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"].ToString());
                            if (DS.Tables[0].Rows[i]["Calificación"].ToString() == "PNC")
                                AtlasOP1Sec += Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"].ToString());
                        }
                    }
                    else if (DS.Tables[0].Rows[i]["Maquina"].ToString() == "TITAN")
                    {
                        if (DS.Tables[0].Rows[i]["Tipo"].ToString() == "Corte Secundario")
                        {
                            TitanSecundario += Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"].ToString());
                            if (DS.Tables[0].Rows[i]["Calificación"].ToString() == "Primera")
                                TitanPrimeraSec += Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"].ToString());
                            if (DS.Tables[0].Rows[i]["Calificación"].ToString() == "Producto en proceso")
                                TitanPPSec += Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"].ToString());
                            if (DS.Tables[0].Rows[i]["Calificación"].ToString() == "PNC")
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
            string texto;
            texto = "CALL spMetalizedReportByPlantTotalized '" + dtpDesde.Value.ToString("dd/MM/yyyy") + "', '" + dtpHasta.Value.ToString("dd/MM/yyyy") + "',4";
            DS = clsConnection.getDataSetResult(texto);
            metalized = 0;
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                metalized = (Convert.ToDouble(DS.Tables[0].Rows[0]["MetalTotal"]) / 1000);
            }
        }
        public void getMermas()
        {
            DataSet DS = new DataSet();
            string texto;
            texto = "CALL spScrapPalletByDate '" + dtpDesde.Value.ToString("dd/MM/yyyy") + "', '" + dtpHasta.Value.ToString("dd/MM/yyyy") + "'";
            DS = clsConnection.getDataSetResult(texto);
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
            texto = "CALL spScrapByMachineByDateTotalized '" + dtpDesde.Value.ToString("dd/MM/yyyy") + "', '" + dtpHasta.Value.ToString("dd/MM/yyyy") + "',3028";
            DS = clsConnection.getDataSetResult(texto);
            MetMerma = 0;
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    MetMerma += Convert.ToDouble(DS.Tables[0].Rows[i]["ScrapTotal"].ToString());
                }
            }
            texto = "CALL spScrapPalletExtruderByDate '" + dtpDesde.Value.ToString("dd/MM/yyyy") + "', '" + dtpHasta.Value.ToString("dd/MM/yyyy")+"'";
            DS = clsConnection.getDataSetResult(texto);
            ExtrusoraMerma = 0;
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    ExtrusoraMerma += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"].ToString());
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
            string texto;
            texto = "CALL spMainCoilReportByDate '" + dtpDesde.Value.ToString("dd/MM/yyyy") + "', '" + dtpHasta.Value.ToString("dd/MM/yyyy") + "'";
            DS = clsConnection.getDataSetResult(texto);
            ExtrusoraProduccion = 0;
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    ExtrusoraProduccion += Convert.ToDouble(DS.Tables[0].Rows[i]["PesoNeto"].ToString());
                }
            }

            texto = "CALL spRawMaterialMovementsTotalByDateAndRecup '" + dtpDesde.Value.ToString("dd/MM/yyyy") + "', '" + dtpHasta.Value.ToString("dd/MM/yyyy") + "'";
            DS = clsConnection.getDataSetResult(texto);
            ExtrusoraRecup = 0;
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    ExtrusoraRecup += Convert.ToDouble(DS.Tables[0].Rows[i]["pesoRaw"].ToString());
                }
            }

            texto = "CALL spRawMaterialMovementsTotalByDateAndConsumption '" + dtpDesde.Value.ToString("dd/MM/yyyy") + "', '" + dtpHasta.Value.ToString("dd/MM/yyyy") + "'";
            DS = clsConnection.getDataSetResult(texto);
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
            if(ExtrusoraRecup!=0)
                ExtrusoraRecupPorcentaje = (ExtrusoraRecup) / ExtrusoraProduccion;
            ExtrusoraProduccion = ExtrusoraProduccion / 1000;
            if (ExtrusoraRecup != 0)
                ExtrusoraRecupPorcentaje = (ExtrusoraRecup) / ExtrusoraProduccion;
        }
        public void getReturnsAndShippings()
        {
            DataSet DS = new DataSet();
            string texto;
            texto = "CALL spShippingByDate '" + dtpDesde.Value.ToString("dd/MM/yyyy") + "', '" + dtpHasta.Value.ToString("dd/MM/yyyy") + "'";
            DS = clsConnection.getDataSetResult(texto);
            DepDespachos = 0;
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (DS.Tables[0].Rows[i]["Planta"].ToString()=="Pilar")
                        DepDespachos += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"].ToString());
                }
            }


            texto = "CALL spReturnByDate '" + dtpDesde.Value.ToString("dd/MM/yyyy") + "', '" + dtpHasta.Value.ToString("dd/MM/yyyy") + "'";
            DS = clsConnection.getDataSetResult(texto);
            DepDevoluciones = 0;
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (DS.Tables[0].Rows[i]["Planta"].ToString() == "Pilar")
                    DepDevoluciones += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"].ToString());
                }
            }


            texto = "CALL spReporteImportaciones '" + dtpDesde.Value.ToString("dd/MM/yyyy") + "', '" + dtpHasta.Value.ToString("dd/MM/yyyy") + "'";
            DS = clsConnection.getDataSetResult(texto);
            DepImportaciones = 0;
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    DepImportaciones += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"].ToString());
                }
            }
            /*texto = "CALL spSwapReportByDate '" + dtpDesde.Value.ToString("dd/MM/yyyy") + "', '" + dtpHasta.Value.ToString("dd/MM/yyyy") + "',0,0";
            DS = clsConnection.getDataSetResult(texto);
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
            SwapMinus = SwapMinus / 1000;*/
            DepImportaciones = DepImportaciones / 1000;
            DepDevoluciones = DepDevoluciones / 1000;
            DepDespachos = DepDespachos / 1000;
        }
        public void getRacks()
        {
            DataSet DS = new DataSet();
            string texto;
            texto = "CALL spRackHistoryReport (" + dtpDesde.Value.Date.Day + "," + dtpDesde.Value.Date.Month + "," + dtpDesde.Value.Date.Year + ",0)";
            DS = clsConnection.getDataSetResult(texto);
            RackPStock = 0;
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                        RackPStock += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
            }
            texto = "CALL spRackHistoryReport (" + dtpHasta.Value.Date.Day + "," + dtpHasta.Value.Date.Month + "," + dtpHasta.Value.Date.Year + ",0)";
            DS = clsConnection.getDataSetResult(texto);
            RackPStockFinal = 0;
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    RackPStockFinal += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
            }
            texto = "CALL spSecundaryRackHistoryReport(" + dtpDesde.Value.Date.Day + "," + dtpDesde.Value.Date.Month + "," + dtpDesde.Value.Date.Year + ",0)";
            DS = clsConnection.getDataSetResult(texto);
            RackSBases = 0;
            RackSMetal = 0;
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
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

            texto = "CALL spSecundaryRackHistoryReport(" + dtpHasta.Value.Date.Day + "," + dtpHasta.Value.Date.Month + "," + dtpHasta.Value.Date.Year + ",0)";
            DS = clsConnection.getDataSetResult(texto);
            RackSBasesFinal = 0;
            RackSMetalFinal = 0;
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    string codigo = DS.Tables[0].Rows[i]["Pelicula"].ToString();
                    if (codigo.Substring(0, 1) == "B")
                        RackSBasesFinal += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                    else if (codigo.Substring(0, 1) == "M" || codigo.Substring(0, 1) == "N")
                        RackSMetalFinal += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                }
            }

            texto = "CALL spDepotCoilHistory(" + dtpDesde.Value.Date.Day + "," + dtpDesde.Value.Date.Month + "," + dtpDesde.Value.Date.Year + ",0)";
            DS = clsConnection.getDataSetResult(texto);
            DepPrimera = 0;
            DepPrimeraImp = 0;
            DepProceso = 0;
            DepOP1 = 0;
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (DS.Tables[0].Rows[i]["Calidad"].ToString() == "Primera" && DS.Tables[0].Rows[i]["Bodega"].ToString() == "Producto Terminado Pilar")
                    {
                        if (DS.Tables[0].Rows[i]["Tipo"].ToString() == "LOCAL")
                        {
                            DepPrimera += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                        }
                        else
                        {
                            DepPrimeraImp += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                        }
                    }
                    else if (DS.Tables[0].Rows[i]["Calidad"].ToString() == "Producto en proceso")
                        DepProceso += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                    else if (DS.Tables[0].Rows[i]["Calidad"].ToString() == "PNC")
                        DepOP1 += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                }
            }

            texto = "CALL spDepotCoilHistory(" + dtpHasta.Value.Date.Day + "," + dtpHasta.Value.Date.Month + "," + dtpHasta.Value.Date.Year + ",0)";
            DS = clsConnection.getDataSetResult(texto);
            DepPrimeraFinal = 0;
            DepPrimeraFinalImp = 0;
            DepProcesoFinal = 0;
            DepOP1Final = 0;
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (DS.Tables[0].Rows[i]["Calidad"].ToString() == "Primera" && DS.Tables[0].Rows[i]["Bodega"].ToString() == "Producto Terminado Pilar")
                    {
                        if (DS.Tables[0].Rows[i]["Tipo"].ToString() == "LOCAL")
                        {
                            DepPrimeraFinal += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                        }
                        else
                        {
                            DepPrimeraFinalImp += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                        }
                    }                        
                    else if (DS.Tables[0].Rows[i]["Calidad"].ToString() == "Producto en proceso")
                        DepProcesoFinal += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                    else if (DS.Tables[0].Rows[i]["Calidad"].ToString() == "PNC")
                        DepOP1Final += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                }
            }


            RackPStock = RackPStock / 1000;
            RackSBases = RackSBases / 1000;
            RackSMetal = RackSMetal / 1000;
            DepPrimera = DepPrimera / 1000;
            DepPrimeraImp = DepPrimeraImp / 1000;
            DepProceso = DepProceso / 1000;
            DepOP1 = DepOP1 / 1000;
            RackPStockFinal = RackPStockFinal / 1000;
            RackSBasesFinal = RackSBasesFinal / 1000;
            RackSMetalFinal = RackSMetalFinal / 1000;
            DepPrimeraFinal = DepPrimeraFinal / 1000;
            DepPrimeraFinalImp = DepPrimeraFinalImp / 1000;
            DepProcesoFinal = DepProcesoFinal / 1000;
            DepOP1Final = DepOP1Final / 1000;
        }
        public void getExtruderDepAndDepMP()
        {
            DataSet DS = new DataSet();
            string texto;
            texto = "CALL spRawDepotHistoryByDate(" + dtpDesde.Value.Date.Day + "," + dtpDesde.Value.Date.Month + ","+dtpDesde.Value.Date.Year+",0)";
            DS = clsConnection.getDataSetResult(texto);
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

            texto = "CALL spRawDepotHistoryByDate(" + dtpHasta.Value.Date.Day + "," + dtpHasta.Value.Date.Month + "," + dtpHasta.Value.Date.Year + ",0)";
            DS = clsConnection.getDataSetResult(texto);
            ExtrusoraStockMPFinal = 0;
            Silo3Final = 0;
            Silo4Final = 0;
            StockMPFinal = 0;
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (DS.Tables[0].Rows[i]["Deposito"].ToString() == "Extrusion Pilar")
                        if (DS.Tables[0].Rows[i]["NumTipo"].ToString() != "35")
                            ExtrusoraStockMPFinal += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                    if (DS.Tables[0].Rows[i]["Deposito"].ToString() == "Silo Pilar 3")
                        Silo3Final += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                    if (DS.Tables[0].Rows[i]["Deposito"].ToString() == "Silo Pilar 4")
                        Silo4Final += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                    if (DS.Tables[0].Rows[i]["Deposito"].ToString() == "Materia Prima Pilar")
                        if (DS.Tables[0].Rows[i]["NumTipo"].ToString() != "35")
                            StockMPFinal += Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                }
            }
            ExtrusoraStockMP = ExtrusoraStockMP / 1000;
            Silo3 = Silo3 / 1000;
            Silo4 = Silo4 / 1000;
            StockMP = StockMP / 1000;
            ExtrusoraStockMPFinal = ExtrusoraStockMPFinal / 1000;
            Silo3Final = Silo3Final / 1000;
            Silo4Final = Silo4Final / 1000;
            StockMPFinal = StockMPFinal / 1000;
        }
        public void getMill()
        {
            DataSet DS = new DataSet();
            string texto;
            texto = "CALL spRawMaterialMovementsByDate '" + dtpDesde.Value.ToString("dd/MM/yyyy") + "', '" + dtpHasta.Value.ToString("dd/MM/yyyy") + "'";
            DS = clsConnection.getDataSetResult(texto);
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

            texto = "SELECT COALESCE(SUM(bps_prod_millproduction.mp_scrapWeigth),0) FROM bps_prod_millproduction WHERE bps_prod_millproduction.mp_date BETWEEN'" + dtpDesde.Value.ToString("dd/MM/yyyy") + "' AND '" + dtpHasta.Value.ToString("dd/MM/yyyy") + "'";
            DS = clsConnection.getDataSetResult(texto);
            Molino = 0;
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                MermaMolino += Convert.ToDouble(DS.Tables[0].Rows[0][0].ToString());
            }
            MermaMolino = MermaMolino / 1000;
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
                txtMermaMetalizadora.Text = MetMerma.ToString("0");
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
                txtRecup.Text = ExtrusoraRecup.ToString("0");
                txtRecupExtrusora.Text = ExtrusoraRecupPorcentaje.ToString("0.0 %");
                //Extrusora
                //Deposito PT, PP y OP1
                //txtSwapPlus.Text = SwapPlus.ToString("0");
                //txtSwapMinus.Text = SwapMinus.ToString("0");
                txtDespachosDeposito.Text = DepDespachos.ToString("0");
                txtDevolucionesDeposito.Text = DepDevoluciones.ToString("0");
                txtImportacionesDeposito.Text = DepImportaciones.ToString("0");
                txtPrimeraDeposito.Text = DepPrimera.ToString("0");
                txtDepositoImpInicial.Text = DepPrimeraImp.ToString("0");
                txtProductoEnProcesoDeposito.Text = DepProceso.ToString("0");
                txtOP1Deposito.Text = DepOP1.ToString("0");
                txtPrimeraDepositoFinal.Text = DepPrimeraFinal.ToString("0");
                txtDepositoImpFinal.Text = DepPrimeraFinalImp.ToString("0");
                txtProductoEnProcesoDepositoFinal.Text = DepProcesoFinal.ToString("0");
                txtOP1DepositoFinal.Text = DepOP1Final.ToString("0");
                //Deposito PT, PP y OP1
                //Racks
                txtStockPrimario.Text = RackPStock.ToString("0");
                txtStockBasesSecundario.Text = RackSBases.ToString("0");
                txtStockMetalSecundario.Text = RackSMetal.ToString("0");
                txtStockPrimarioFinal.Text = RackPStockFinal.ToString("0");
                txtStockBasesSecundarioFinal.Text = RackSBasesFinal.ToString("0");
                txtStockMetalSecundarioFinal.Text = RackSMetalFinal.ToString("0");
                //Racks
                //Deposito Extrusion
                txtStockExtrusion.Text = ExtrusoraStockMP.ToString("0");
                txtSilo3.Text = Silo3.ToString("0");
                txtSilo4.Text = Silo4.ToString("0");
                txtStockExtrusionFinal.Text = ExtrusoraStockMPFinal.ToString("0");
                txtSilo3Final.Text = Silo3Final.ToString("0");
                txtSilo4Final.Text = Silo4Final.ToString("0");
                //Deposito Extrusion
                //DepositoMP
                txtStockMP.Text = StockMP.ToString("0");
                txtStockMPFinal.Text = StockMPFinal.ToString("0");
                //DepositoMP
                //Molino
                txtStockMolino.Text = Molino.ToString("0");
                txtMermaMolino.Text = MermaMolino.ToString("0");
                //Molino
                getParameter();
                ajustarExtrusion();
            }
        }

        public void ajustarExtrusion()
        {
            txtProduccionExtrusora.Text = (Convert.ToDouble(txtProduccionExtrusora.Text) - (Convert.ToDouble(txtProduccionExtrusora.Text) * Convert.ToDouble(txtParametro.Text))).ToString("0");
            txtProduccionGlobal.Text = (Convert.ToDouble(txtProduccionExtrusora.Text) + Convert.ToDouble(txtMermaExtrusora.Text)).ToString("0");
            txtMermaGlobal.Text = (Convert.ToDouble(txtMermaExtrusora.Text) + Convert.ToDouble(txtMermaPrimaria.Text) + Convert.ToDouble(txtMermaMetalAtlas.Text) + Convert.ToDouble(txtMermaSecundarioAtlas.Text) + Convert.ToDouble(txtMermaTitan.Text)).ToString("0");
            txtEficienciaGlobal.Text = (1 - (Convert.ToDouble(txtMermaGlobal.Text) / Convert.ToDouble(txtProduccionGlobal.Text))).ToString("0.0 %");
            txtStockMPGlobal.Text = (Convert.ToDouble(txtStockExtrusionFinal.Text) + Convert.ToDouble(txtSilo3Final.Text) + Convert.ToDouble(txtSilo4Final.Text) + Convert.ToDouble(txtStockMPFinal.Text)).ToString("0");
            txtStockPrimario.Text = (Convert.ToDouble(txtStockPrimario.Text) - (Convert.ToDouble(txtStockPrimario.Text) * Convert.ToDouble(txtParametro.Text))).ToString("0");
            txtStockPrimarioFinal.Text = (Convert.ToDouble(txtStockPrimarioFinal.Text) - (Convert.ToDouble(txtStockPrimarioFinal.Text) * Convert.ToDouble(txtParametro.Text))).ToString("0");
        }

        public void getParameter()
        {
            clsAux param = new clsAux(dtpDesde.Value.Month, dtpDesde.Value.Year);
            txtParametro.Text = param.parameter.ToString();
        }
        public bool Validar()
        {
            bool bandera = true;
            if (dtpDesde.Value.Date > dtpHasta.Value.Date)
            {
                lblError.Text = "La fecha 'Desde' no puede ser mayor a la fecha 'Hasta'";
                lblError.Visible = true;
                bandera = false;
            }
            else
                lblError.Visible = false;
            return bandera;
        }
        #region Double Click
        private void txtPrimera_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "CortadoraPrimariaPrimera");
            form.Show();
        }
        private void txtProductoEnProceso_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "CortadoraPrimariaProceso");
            form.Show();
        }
        private void txtCortePrimario_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "CortadoraPrimariaTotal");
            form.Show();
        }
        private void txtCorteTotal_DoubleClick(object sender, EventArgs e)
        {

            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "CortadoraPrimariaTotal");
            form.Show();
        }
        private void txtOP1Primaria_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "CortadoraPrimariaOP1");
            form.Show();
        }
        private void txtCorteBase_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "CortadoraPrimariaBase");
            form.Show();
        }
        private void txtAtlas_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "CortadoraAtlas");
            form.Show();
        }
        private void txtCorteMetalAtlas_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "CortadoraAtlasMetal");
            form.Show();
        }
        private void txtCorteSecundarioAtlas_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "CortadoraAtlasSecundario");
            form.Show();
        }
        private void txtTitan_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "CortadoraTitan");
            form.Show();
        }
        private void txtCorteSecundarioTitan_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "CortadoraTitanSecundario");
            form.Show();
        }
        private void txtMetalizadoMetalizadora_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "MetalizadoraMetal");
            form.Show();
        }
        private void txtProduccionExtrusora_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "ExtrusoraProduccion",0,Convert.ToDouble(txtParametro.Text));
            form.Show();
        }
        private void txtMermaMetalAtlas_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "AtlasMermaMetal");
            form.Show();
        }
        private void txtMermaTitan_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "TitanMerma");
            form.Show();
        }
        private void txtMermaExtrusora_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "ExtrusoraMerma");
            form.Show();
        }
        private void txtMermaPrimaria_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "CortadoraPrimariaMerma");
            form.Show();
        }
        private void txtMermaMetalizadora_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "MetalizadoraMerma");
            form.Show();
        }
        private void txtMermaSecundarioAtlas_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "AtlasMermaSecundario");
            form.Show();
        }
        private void txtDespachosDeposito_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "DepDespachos");
            form.Show();
        }
        private void txtDevolucionesDeposito_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "DepDevoluciones");
            form.Show();
        }
        private void txtStockPrimario_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "RackPrimarioStock2", 0, Convert.ToDouble(txtParametro.Text));
            form.Show();
        }
        private void txtStockBasesSecundario_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "RackSecundarioBase2");
            form.Show();
        }
        private void txtStockMetalSecundario_DoubleClick(object sender, EventArgs e)
        {
            //revisar
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "RackSecundarioMetal2");
            form.Show();
        }
        private void txtImportacionesDeposito_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "DepImportaciones");
            form.Show();
        }
        private void txtStockMP_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "StockMP2");
            form.Show();
        }
        private void txtStockExtrusion_DoubleClick(object sender, EventArgs e)
        {
            //revisar
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "ExtrusionStockMP2");
            form.Show();
        }
        private void txtSilo3_DoubleClick(object sender, EventArgs e)
        {
            //revisar
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "ExtrusionSilo3_2");
            form.Show();
        }
        private void txtSilo4_DoubleClick(object sender, EventArgs e)
        {
            //revisar
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "ExtrusionSilo4_2");
            form.Show();
        }
        private void txtPrimeraDeposito_DoubleClick(object sender, EventArgs e)
        {
            //revisar
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "DepPrimera2");
            form.Show();
        }
        private void txtProductoEnProcesoDeposito_DoubleClick(object sender, EventArgs e)
        {
            //revisar
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "DepProceso2");
            form.Show();
        }
        private void txtOP1Deposito_DoubleClick(object sender, EventArgs e)
        {
            //tambien revisar
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "DepOP1_2");
            form.Show();
        }
        private void txtStockMolino_DoubleClick(object sender, EventArgs e)
        {
            //este no
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "Molino");
            form.Show();
        }
        private void txtMetPrimeraAtlas_DoubleClick(object sender, EventArgs e)
        {
                frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "AtlasMetPrimera");
                form.Show();
        }

        private void txtMetPPAtlas_DoubleClick(object sender, EventArgs e)
        {
                frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "AtlasMetPP");
                form.Show();
        }

        private void txtMetOP1Atlas_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "AtlasMetOP1");
            form.Show();
        }

        private void txtSecPrimeraAtlas_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "CortadoraAtlasSecundarioPrimera");
            form.Show();
        }

        private void txtSecPPAtlas_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "CortadoraAtlasSecundarioPP");
            form.Show();
        }

        private void txtSecOP1Atlas_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "CortadoraAtlasSecundarioOP1");
            form.Show();
        }

        private void txtSecPrimeraTitan_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "CortadoraTitanSecundarioPrimera");
            form.Show();
        }

        private void txtSecPPTitan_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "CortadoraTitanSecundarioPP");
            form.Show();
        }

        private void txtSecOP1Titan_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "CortadoraTitanSecundarioOP1");
            form.Show();
        }
        private void txtSwapPlus_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "SwapPlus");
            form.Show();
        }
        private void txtSwapMinus_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "SwapMinus");
            form.Show();
        }
        #endregion

        private void frmProductionControlPerDate_Load(object sender, EventArgs e)
        {

        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }

        private void txtStockMPFinal_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "StockMPFinal");
            form.Show();
        }

        private void txtStockExtrusionFinal_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "StockExtrusionFinal");
            form.Show();
        }

        private void txtSilo3Final_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "Silo3Final");
            form.Show();
        }

        private void txtSilo4Final_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "Silo4Final");
            form.Show();
        }

        private void txtStockPrimarioFinal_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "RackPrimarioFinal", 0, Convert.ToDouble(txtParametro.Text));
            form.Show();
        }

        private void txtStockBasesSecundarioFinal_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "RackSecundarioBaseFinal");
            form.Show();
        }

        private void txtStockMetalSecundarioFinal_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "RackSecundarioMetalFinal");
            form.Show();
        }

        private void txtPrimeraDepositoFinal_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "PrimeraDepositoFinal");
            form.Show();
        }

        private void txtProductoEnProcesoDepositoFinal_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "PPDepositoFinal");
            form.Show();
        }

        private void txtOP1DepositoFinal_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "OP1DepositoFinal");
            form.Show();
        }

        private void txtRecupExtrusora_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "ExtrusoraRecup");
            form.Show();
        }

        private void txtRecup_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "ExtrusoraRecup");
            form.Show();
        }

        private void txtConsumoExtrusora_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "ExtrusoraConsum");
            form.Show();
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControlMP form = new frmPCPTProductionControlMP(dtpDesde.Value.Date, dtpHasta.Value.Date, "StockMPFinal");
            form.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(clsGlobal.isNumeric(txtParametro.Text))
            {
                clsAux param = new clsAux(dtpDesde.Value.Month, dtpDesde.Value.Year);
                param.parameter = Convert.ToDecimal(txtParametro.Text);
                param.save();
            }
            
        }

        private void txtDepositoImpInicial_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "DepPrimeraImp");
            form.Show();
        }

        private void txtDepositoImpFinal_DoubleClick(object sender, EventArgs e)
        {
            frmPCPTProductionControl form = new frmPCPTProductionControl(dtpDesde.Value.Date, dtpHasta.Value.Date, "PrimeraDepositoFinalImp");
            form.Show();
        }
    }
}
