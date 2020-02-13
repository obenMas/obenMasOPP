using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BPS.Bussiness;
using System.Linq;
using System.IO;
using System.Xml;
using BPS.Reporting.SummaryCutterMothReport;
using BPS.Reporting.Manager.Managers;
using BPS.Raw;
using BPS.Cellar.Inventory.RePro;
using BPS.Cellar.Inventory.Raw;
using System.ComponentModel;
using System.Data;

namespace BPS
{
    public partial class frmMain : Form
    {
        public ToolStripItemCollection objToolStripItemCollectionPublic;

        public frmMain()
        {
            string fileName = "";

            if (File.Exists("engine.xml"))
                fileName = "engine.xml";
            else if (File.Exists("../../engine.xml"))
                fileName = "../../engine.xml";

            XmlTextReader xmlRdr = new XmlTextReader(fileName);

            while (xmlRdr.Read())
            {
                switch (xmlRdr.Name)
                {
                    case "engine":
                        clsGlobal.DataBaseEngine = xmlRdr.GetAttribute("value");
                        break;
                }
            }

            frmLogin winLogin = new frmLogin();
            winLogin.ShowDialog();
            clsGlobal.Company.load(2);
            InitializeComponent();
            #region gerente de planta
            if (clsGlobal.LoggedUser.RoleName == "Gerente de planta")
            {
                tsmAdmin.Visible = false;
                tsmProduction.Visible = false;
                tsmBackload.Visible = false;
                tsmSales.Visible = false;
                tsmCellars.Visible = false;
                tsmCube.Visible = false;
                tsmRawMaterial.Visible = false;
                tsmManagement.Visible = false;
                tsmManagerFull.Visible = false;
                reportesToolStripMenuItem.Visible = false;

                ToolStripMenuItem ext = new ToolStripMenuItem();
                ext.Text = "Extrusión";
                ext.Image = Properties.Resources.rewind;
                mnuMain.Items.Add(ext);

                ToolStripMenuItem listaext = new ToolStripMenuItem();
                listaext.Text = "Plan de extrusión";
                listaext.Image = Properties.Resources.page_white_gear;
                listaext.Click += new EventHandler(pruebaOrdenesDeExtrusionToolStripMenuItem_Click);
                ext.DropDownItems.Add(listaext);

                ToolStripMenuItem lisBM = new ToolStripMenuItem();
                lisBM.Text = "Listado de bobinas madre";
                lisBM.Image = Properties.Resources.page_coils;
                lisBM.Click += new EventHandler(listadoDeBobinasMadreToolStripMenuItemPL_Click);
                ext.DropDownItems.Add(lisBM);

                ToolStripMenuItem Stock = new ToolStripMenuItem();
                Stock.Text = "Estado de Rack Primario";
                Stock.Image = Properties.Resources.storage2;
                Stock.Click += new EventHandler(loadMainCoilStockPL);
                ext.DropDownItems.Add(Stock);

                ToolStripMenuItem historialRackPrimario = new ToolStripMenuItem();
                historialRackPrimario.Text = "Historial de Rack Primario";
                historialRackPrimario.Image = Properties.Resources.calendar;
                historialRackPrimario.Click += new EventHandler(historialDeRackPrimarioToolStripMenuItem_Click);
                ext.DropDownItems.Add(historialRackPrimario);

                ToolStripMenuItem Formu = new ToolStripMenuItem();
                Formu.Text = "Formulaciones";
                Formu.Image = Properties.Resources.chart_line;
                ext.DropDownItems.Add(Formu);

                ToolStripMenuItem NuevaFormu = new ToolStripMenuItem();
                NuevaFormu.Text = "Nueva";
                NuevaFormu.Image = Properties.Resources.add1;
                NuevaFormu.Click += new EventHandler(pruebaFormulacionesToolStripMenuItem_Click);
                Formu.DropDownItems.Add(NuevaFormu);

                ToolStripMenuItem ListaFormu = new ToolStripMenuItem();
                ListaFormu.Text = "Listado";
                ListaFormu.Image = Properties.Resources.page;
                ListaFormu.Click += new EventHandler(pruebaListadoFormulacionesToolStripMenuItem_Click);
                Formu.DropDownItems.Add(ListaFormu);

                ToolStripMenuItem cor = new ToolStripMenuItem();
                cor.Text = "Corte";
                cor.Image = Properties.Resources.coilCut;
                mnuMain.Items.Add(cor);

                ToolStripMenuItem listacort = new ToolStripMenuItem();
                listacort.Text = "Listado de ordenes de corte";
                listacort.Image = Properties.Resources.page_white_gear;
                listacort.Click += new EventHandler(loadCuttingOrderList);
                cor.DropDownItems.Add(listacort);

                ToolStripMenuItem listacortG = new ToolStripMenuItem();
                listacortG.Text = "Goebel";
                listacortG.Image = Properties.Resources.page_white_gear;
                listacortG.Click += new EventHandler(loadCuttingOrderListG);
                listacort.DropDownItems.Add(listacortG);

                ToolStripMenuItem listacortA = new ToolStripMenuItem();
                listacortA.Text = "Atlas";
                listacortA.Image = Properties.Resources.page_white_gear;
                listacortA.Click += new EventHandler(loadCuttingOrderListA);
                listacort.DropDownItems.Add(listacortA);

                ToolStripMenuItem listacortT = new ToolStripMenuItem();
                listacortT.Text = "Titan";
                listacortT.Image = Properties.Resources.page_white_gear;
                listacortT.Click += new EventHandler(loadCuttingOrderListT);
                listacort.DropDownItems.Add(listacortT);

                ToolStripMenuItem lisBMM = new ToolStripMenuItem();
                lisBMM.Text = "Listado de ordenes de metalizado";
                lisBMM.Image = Properties.Resources.page_coils;
                lisBMM.Click += new EventHandler(listadoToolStripMenuItem1_Click_2);
                cor.DropDownItems.Add(lisBMM);

                ToolStripMenuItem StockM = new ToolStripMenuItem();
                StockM.Text = "Estado de Rack metalizado";
                StockM.Image = Properties.Resources.storage2;
                StockM.Click += new EventHandler(loadMainCoilMetalStockPL);
                cor.DropDownItems.Add(StockM);

                ToolStripMenuItem historialRackSecundario = new ToolStripMenuItem();
                historialRackSecundario.Text = "Historial de Rack metalizado";
                historialRackSecundario.Image = Properties.Resources.calendar;
                historialRackSecundario.Click += new EventHandler(historialDeRackSecundarioToolStripMenuItem_Click);
                cor.DropDownItems.Add(historialRackSecundario);

                ToolStripMenuItem log = new ToolStripMenuItem();
                log.Text = "Logistica";
                log.Image = Properties.Resources.delivery_national;
                mnuMain.Items.Add(log);

                ToolStripMenuItem dep = new ToolStripMenuItem();
                dep.Text = "Inventario Completo de Pallets";
                dep.Image = Properties.Resources.pallet;
                dep.Click += new EventHandler(stockDePalletsToolStripMenuItem_Click_1);
                log.DropDownItems.Add(dep);

                ToolStripMenuItem depop1 = new ToolStripMenuItem();
                depop1.Text = "Inventario Completo de Bobinas";
                depop1.Image = Properties.Resources.coils;
                depop1.Click += new EventHandler(stockDeOP1ToolStripMenuItem_Click_1);
                log.DropDownItems.Add(depop1);

                ToolStripMenuItem historialBobinas = new ToolStripMenuItem();
                historialBobinas.Text = "Historial de inventario de bobinas";
                historialBobinas.Image = Properties.Resources.calendar;
                historialBobinas.Click += new EventHandler(historialDeDepositoDeBobinasToolStripMenuItem_Click);
                log.DropDownItems.Add(historialBobinas);

                ToolStripMenuItem historialPallets = new ToolStripMenuItem();
                historialPallets.Text = "Historial de inventario de pallets";
                historialPallets.Image = Properties.Resources.calendar;
                historialPallets.Click += new EventHandler(historialDeDepositoDePalletsToolStripMenuItem_Click);
                log.DropDownItems.Add(historialPallets);

                ToolStripMenuItem stockmp = new ToolStripMenuItem();
                stockmp.Text = "Inventario de materia prima";
                stockmp.Image = Properties.Resources.box;
                stockmp.Click += new EventHandler(palletStockDeMateriasPrimasToolStripMenuItem_Click);
                log.DropDownItems.Add(stockmp);

                ToolStripMenuItem historialMateriaPrima = new ToolStripMenuItem();
                historialMateriaPrima.Text = "Historial de inventario de materia prima";
                historialMateriaPrima.Image = Properties.Resources.calendar;
                historialMateriaPrima.Click += new EventHandler(historialDeDepositoDeMateriaPrimaToolStripMenuItem_Click);
                log.DropDownItems.Add(historialMateriaPrima);

                ToolStripMenuItem stockmerm = new ToolStripMenuItem();
                stockmerm.Text = "Inventario de mermas";
                stockmerm.Image = Properties.Resources.box1;
                stockmerm.Click += new EventHandler(stockDeEstrusiónToolStripMenuItem_Click);
                log.DropDownItems.Add(stockmerm);

                

                

                ToolStripMenuItem rep = new ToolStripMenuItem();
                rep.Text = "Reportes";
                rep.Image = Properties.Resources.report;
                mnuMain.Items.Add(rep);

                ToolStripMenuItem repe = new ToolStripMenuItem();
                repe.Text = "Extrusión";
                repe.Image = Properties.Resources.rewind;
                repe.Click += new EventHandler(extrusionToolStripMenuItem_Click);
                rep.DropDownItems.Add(repe);

                ToolStripMenuItem repmo = new ToolStripMenuItem();
                repmo.Text = "Molino";
                repmo.Image = Properties.Resources.coilMill1;
                repmo.Click += new EventHandler(reportproduccionDeMolinoToolStripMenuItem_Click);
                rep.DropDownItems.Add(repmo);

                ToolStripMenuItem repc = new ToolStripMenuItem();
                repc.Text = "Corte";
                repc.Image = Properties.Resources.coilCut;
                repc.Click += new EventHandler(corteToolStripMenuItem_Click);
                rep.DropDownItems.Add(repc);

                ToolStripMenuItem repm = new ToolStripMenuItem();
                repm.Text = "Metalizado";
                repm.Image = Properties.Resources.mainCoil;
                repm.Click += new EventHandler(metalizadoToolStripMenuItem_Click);
                rep.DropDownItems.Add(repm);

                ToolStripMenuItem repBLPend = new ToolStripMenuItem();
                repBLPend.Text = "BL Pendiente de corte";
                repBLPend.Image = Properties.Resources.delivery;
                repBLPend.Click += new EventHandler(BLPendienteDeCorte_Click);
                rep.DropDownItems.Add(repBLPend);

                ToolStripMenuItem reppred = new ToolStripMenuItem();
                reppred.Text = "Despachos";
                reppred.Image = Properties.Resources.delivery;
                reppred.Click += new EventHandler(shippingReportL_Click);
                rep.DropDownItems.Add(reppred);

                ToolStripMenuItem res = new ToolStripMenuItem();
                res.Text = "Control de resultados";
                res.Image = Properties.Resources.document_edit;
                mnuMain.Items.Add(res);

                ToolStripMenuItem respt = new ToolStripMenuItem();
                respt.Text = "Resultados por turno";
                respt.Image = Properties.Resources.page_white_gear;
                respt.Click += new EventHandler(pruebaControlDeProdPorTurnoToolStripMenuItem_Click);
                res.DropDownItems.Add(respt);

                ToolStripMenuItem resef = new ToolStripMenuItem();
                resef.Text = "Resultados entre fechas";
                resef.Image = Properties.Resources.page_white_gear;
                resef.Click += new EventHandler(pruebaControlDeProdPorFechasToolStripMenuItem_Click);
                res.DropDownItems.Add(resef);

            }
            #endregion
            #region extrusion pilar
            if (clsGlobal.LoggedUser.RoleName == "Extrusion Pilar")
            {

                tsmAdmin.Visible = false;
                tsmProduction.Visible = false;
                tsmBackload.Visible = false;
                tsmSales.Visible = false;
                tsmCellars.Visible = false;
                tsmCube.Visible = false;
                tsmRawMaterial.Visible = false;
                tsmManagement.Visible = false;
                tsmManagerFull.Visible = false;
                reportesToolStripMenuItem.Visible = false;

                ToolStripMenuItem prode = new ToolStripMenuItem();
                prode.Text = "Extrusora";
                prode.Image = Properties.Resources.rewind;
                mnuMain.Items.Add(prode);

                ToolStripMenuItem ejeext = new ToolStripMenuItem();
                ejeext.Text = "Ejecución de ordenes de extrusión";
                ejeext.Image = Properties.Resources.page_lightning;
                ejeext.Click += new EventHandler(ordenesDeExtrusiónBoppToolStripMenuItem_Click);
                prode.DropDownItems.Add(ejeext);

                ToolStripMenuItem listaext = new ToolStripMenuItem();
                listaext.Text = "Listado de ordenes de extrusión";
                listaext.Image = Properties.Resources.page_white_gear;
                listaext.Click += new EventHandler(loadExtrusionListPL);
                prode.DropDownItems.Add(listaext);

                ToolStripMenuItem notiext = new ToolStripMenuItem();
                notiext.Text = "Notificación de bobinas madre";
                notiext.Image = Properties.Resources.mainCoil;
                notiext.Click += new EventHandler(loadMainCoilRegistration);
                prode.DropDownItems.Add(notiext);

                ToolStripMenuItem stockext = new ToolStripMenuItem();
                stockext.Text = "Stock de bobinas madre";
                stockext.Image = Properties.Resources.storage2;
                stockext.Click += new EventHandler(loadMainCoilStockPL);
                prode.DropDownItems.Add(stockext);

                ToolStripMenuItem lisBM = new ToolStripMenuItem();
                lisBM.Text = "Listado de bobinas madre";
                lisBM.Image = Properties.Resources.page_coils;
                lisBM.Click += new EventHandler(listadoDeBobinasMadreToolStripMenuItemPL_Click);
                prode.DropDownItems.Add(lisBM);

                ToolStripMenuItem repext = new ToolStripMenuItem();
                repext.Text = "Reporte de producción de extrusión";
                repext.Image = Properties.Resources.reportOff;
                repext.Click += new EventHandler(extrusionToolStripMenuItem_Click);
                prode.DropDownItems.Add(repext);

                ToolStripMenuItem prodm = new ToolStripMenuItem();
                prodm.Text = "Molino";
                prodm.Image = Properties.Resources.coilMill;
                mnuMain.Items.Add(prodm);

                ToolStripMenuItem notim = new ToolStripMenuItem();
                notim.Text = "Notificación de recuperado/regranulado";
                notim.Image = Properties.Resources.page_out;
                notim.Click += new EventHandler(produccionDeMolinoToolStripMenuItem_Click);
                prodm.DropDownItems.Add(notim);

                ToolStripMenuItem repm = new ToolStripMenuItem();
                repm.Text = "Reporte de producción de molino";
                repm.Image = Properties.Resources.coilMill1;
                repm.Click += new EventHandler(reportproduccionDeMolinoToolStripMenuItem_Click);
                prodm.DropDownItems.Add(repm);

                ToolStripMenuItem matp = new ToolStripMenuItem();
                matp.Text = "Materia prima";
                matp.Image = Properties.Resources.box;
                mnuMain.Items.Add(matp);

                ToolStripMenuItem consmp = new ToolStripMenuItem();
                consmp.Text = "Notificación de consumo de materia prima";
                consmp.Image = Properties.Resources.brick_add;
                consmp.Click += new EventHandler(consumoDeMateriasPrimasToolStripMenuItem_Click);
                matp.DropDownItems.Add(consmp);

                ToolStripMenuItem consmpIny = new ToolStripMenuItem();
                consmpIny.Text = "Notificación de consumo de materia prima para inyectora.";
                consmpIny.Image = Properties.Resources.funnel;
                consmpIny.Click += new EventHandler(consumoDeMateriasPrimasInyectoraToolStripMenuItem_Click);
                matp.DropDownItems.Add(consmpIny);

                ToolStripMenuItem stockmp = new ToolStripMenuItem();
                stockmp.Text = "Stock de materia prima";
                stockmp.Image = Properties.Resources.storage2;
                stockmp.Click += new EventHandler(palletStockDeMateriasPrimasToolStripMenuItem_Click);
                matp.DropDownItems.Add(stockmp);

                ToolStripMenuItem reportmp = new ToolStripMenuItem();
                reportmp.Text = "Reporte de consumos de materia prima";
                reportmp.Image = Properties.Resources.reportOff;
                reportmp.Click += new EventHandler(reporteDeConsumoDeMateriasPrimas_Click);
                matp.DropDownItems.Add(reportmp);

                ToolStripMenuItem rawpalletSon = new ToolStripMenuItem();
                rawpalletSon.Text = "Generar Pallet Hijo";
                rawpalletSon.Image = Properties.Resources.pallet;
                rawpalletSon.Click += new EventHandler(rawPalletSon_Click);
                matp.DropDownItems.Add(rawpalletSon);

                ToolStripMenuItem merm = new ToolStripMenuItem();
                merm.Text = "Mermas";
                merm.Image = Properties.Resources.coilMill;
                mnuMain.Items.Add(merm);

                ToolStripMenuItem notimerm = new ToolStripMenuItem();
                notimerm.Text = "Notificación de mermas";
                notimerm.Image = Properties.Resources.coilMill;
                notimerm.Click += new EventHandler(notificacionDeEstrusiónToolStripMenuItem_Click);
                merm.DropDownItems.Add(notimerm);

                /*ToolStripMenuItem bajabm = new ToolStripMenuItem();
                bajabm.Text = "Baja de bobinas madre";
                bajabm.Image = Properties.Resources.mainCoil;
                bajabm.Click += new EventHandler(envíoDeBobinaMadresAlMolinoToolStripMenuItem_Click);
                merm.DropDownItems.Add(bajabm);*/

                ToolStripMenuItem stockmerm = new ToolStripMenuItem();
                stockmerm.Text = "Stock de mermas";
                stockmerm.Image = Properties.Resources.storage2;
                stockmerm.Click += new EventHandler(stockDeEstrusiónToolStripMenuItem_Click);
                merm.DropDownItems.Add(stockmerm);

                ToolStripMenuItem repmermext = new ToolStripMenuItem();
                repmermext.Text = "Reporte merma de extrusión";
                repmermext.Image = Properties.Resources.report;
                repmermext.Click += new EventHandler(reporteMermaExtrusion_Click);
                merm.DropDownItems.Add(repmermext);

                ToolStripMenuItem Formu = new ToolStripMenuItem();
                Formu.Text = "Formulaciones";
                Formu.Image = Properties.Resources.chart_line;
                mnuMain.Items.Add(Formu);

                ToolStripMenuItem NuevaFormu = new ToolStripMenuItem();
                NuevaFormu.Text = "Nueva";
                NuevaFormu.Image = Properties.Resources.add1;
                NuevaFormu.Click += new EventHandler(nuevaToolStripMenuItem5_Click);
                Formu.DropDownItems.Add(NuevaFormu);

                ToolStripMenuItem ListaFormu = new ToolStripMenuItem();
                ListaFormu.Text = "Listado";
                ListaFormu.Image = Properties.Resources.page;
                ListaFormu.Click += new EventHandler(listadoToolStripMenuItem17_Click);
                Formu.DropDownItems.Add(ListaFormu);
            }
            #endregion
            #region operadores/ supervisores extrusion campana
            if (clsGlobal.LoggedUser.RoleName == "Operadores de extrusión" || clsGlobal.LoggedUser.RoleName == "Supervisor de extrusión")
            {
                tsmAdmin.Visible = false;
                tsmProduction.Visible = false;
                tsmBackload.Visible = false;
                tsmSales.Visible = false;
                tsmCellars.Visible = false;
                tsmCube.Visible = false;
                tsmRawMaterial.Visible = false;
                tsmManagement.Visible = false;
                tsmManagerFull.Visible = false;
                reportesToolStripMenuItem.Visible = false;

                ToolStripMenuItem prode = new ToolStripMenuItem();
                prode.Text = "Extrusora";
                prode.Image = Properties.Resources.rewind;
                mnuMain.Items.Add(prode);

                ToolStripMenuItem ejeext = new ToolStripMenuItem();
                ejeext.Text = "Ejecución de ordenes de extrusión";
                ejeext.Image = Properties.Resources.page_coils;
                ejeext.Click += new EventHandler(ordenesDeExtrusiónBoppToolStripMenuItem_Click);
                prode.DropDownItems.Add(ejeext);

                ToolStripMenuItem listaext = new ToolStripMenuItem();
                listaext.Text = "Listado de ordenes de extrusión";
                listaext.Image = Properties.Resources.page_white_gear;
                listaext.Click += new EventHandler(loadExtrusionListC);
                prode.DropDownItems.Add(listaext);

                ToolStripMenuItem notiext = new ToolStripMenuItem();
                notiext.Text = "Notificación de bobinas madre";
                notiext.Image = Properties.Resources.mainCoil;
                notiext.Click += new EventHandler(loadMainCoilRegistrationC);
                prode.DropDownItems.Add(notiext);

                ToolStripMenuItem stockext = new ToolStripMenuItem();
                stockext.Text = "Stock de bobinas madre";
                stockext.Image = Properties.Resources.bricks;
                stockext.Click += new EventHandler(loadMainCoilStockC);
                prode.DropDownItems.Add(stockext);

                ToolStripMenuItem lisBM = new ToolStripMenuItem();
                lisBM.Text = "Listado de bobinas madre";
                lisBM.Image = Properties.Resources.page_coils;
                lisBM.Click += new EventHandler(listadoDeBobinasMadreToolStripMenuItemC_Click);
                prode.DropDownItems.Add(lisBM);

                ToolStripMenuItem repext = new ToolStripMenuItem();
                repext.Text = "Reporte de producción de extrusión";
                repext.Image = Properties.Resources.report;
                repext.Click += new EventHandler(extrusionToolStripMenuItem_Click);
                prode.DropDownItems.Add(repext);

                ToolStripMenuItem prodm = new ToolStripMenuItem();
                prodm.Text = "Molino";
                prodm.Image = Properties.Resources.coilMill1;
                mnuMain.Items.Add(prodm);

                ToolStripMenuItem notim = new ToolStripMenuItem();
                notim.Text = "Notificación de recuperado/regranulado";
                notim.Image = Properties.Resources.coilMill;
                notim.Click += new EventHandler(produccionDeMolinoToolStripMenuItem_Click);
                prodm.DropDownItems.Add(notim);

                ToolStripMenuItem repm = new ToolStripMenuItem();
                repm.Text = "Reporte de producción de molino";
                repm.Image = Properties.Resources.reportOff;
                repm.Click += new EventHandler(reportproduccionDeMolinoToolStripMenuItem_Click);
                prodm.DropDownItems.Add(repm);

                ToolStripMenuItem matp = new ToolStripMenuItem();
                matp.Text = "Materia prima";
                matp.Image = Properties.Resources.box1;
                mnuMain.Items.Add(matp);

                ToolStripMenuItem consmp = new ToolStripMenuItem();
                consmp.Text = "Notificación de consumo de materia prima";
                consmp.Image = Properties.Resources.reprocess2;
                consmp.Click += new EventHandler(consumoDeMateriasPrimasToolStripMenuItem_Click);
                matp.DropDownItems.Add(consmp);

                ToolStripMenuItem stockmp = new ToolStripMenuItem();
                stockmp.Text = "Stock de materia prima";
                stockmp.Image = Properties.Resources.box;
                stockmp.Click += new EventHandler(palletStockDeMateriasPrimasToolStripMenuItem_Click);
                matp.DropDownItems.Add(stockmp);

                ToolStripMenuItem reEtiquetado = new ToolStripMenuItem();
                reEtiquetado.Text = "Re-Etiquetado de Materias Primas";
                reEtiquetado.Image = Properties.Resources.printer;
                reEtiquetado.Click += new EventHandler(reetiquetadoMateriasPrimas_Click);
                matp.DropDownItems.Add(reEtiquetado);

                /*ToolStripMenuItem consummp = new ToolStripMenuItem();
                consummp.Text = "Consumo de Materias Primas";
                consummp.Click += new EventHandler(consumoDeMateriasPrimasToolStripMenuItem_Click);
                matp.DropDownItems.Add(consummp);*/

                ToolStripMenuItem reportmp = new ToolStripMenuItem();
                reportmp.Text = "Reporte de consumos de materia prima";
                reportmp.Image = Properties.Resources.report;
                reportmp.Click += new EventHandler(reporteDeConsumoDeMateriasPrimas_Click);
                matp.DropDownItems.Add(reportmp);

                ToolStripMenuItem reportmov = new ToolStripMenuItem();
                reportmov.Text = "Reporte de movimientos de materias primas";
                reportmov.Image = Properties.Resources.page_white_get;
                reportmov.Click += new EventHandler(reporteMovmimientoMatPrimas_Click);
                matp.DropDownItems.Add(reportmov);

                ToolStripMenuItem rawpalletSon = new ToolStripMenuItem();
                rawpalletSon.Text = "Generar Pallet Hijo";
                rawpalletSon.Image = Properties.Resources.pallet;
                rawpalletSon.Click += new EventHandler(rawPalletSon_Click);
                matp.DropDownItems.Add(rawpalletSon);

                ToolStripMenuItem merm = new ToolStripMenuItem();
                merm.Text = "Mermas";
                merm.Image = Properties.Resources.coilMill;
                mnuMain.Items.Add(merm);

                ToolStripMenuItem notimerm = new ToolStripMenuItem();
                notimerm.Text = "Notificación de mermas";
                notimerm.Image = Properties.Resources.coilMill;
                notimerm.Click += new EventHandler(notificacionDeEstrusiónToolStripMenuItem_Click);
                merm.DropDownItems.Add(notimerm);

                ToolStripMenuItem bajabm = new ToolStripMenuItem();
                bajabm.Text = "Baja de bobinas madre";
                bajabm.Image = Properties.Resources.observationCoils;
                bajabm.Click += new EventHandler(envíoDeBobinaMadresAlMolinoToolStripMenuItem_Click);
                merm.DropDownItems.Add(bajabm);

                ToolStripMenuItem stockmerm = new ToolStripMenuItem();
                stockmerm.Text = "Stock de mermas";
                stockmerm.Image = Properties.Resources.box1;
                stockmerm.Click += new EventHandler(stockDeEstrusiónToolStripMenuItem_Click);
                merm.DropDownItems.Add(stockmerm);

                ToolStripMenuItem repmermext = new ToolStripMenuItem();
                repmermext.Text = "Reporte merma de extrusión";
                repmermext.Image = Properties.Resources.report;
                repmermext.Click += new EventHandler(reporteMermaExtrusion_Click);
                merm.DropDownItems.Add(repmermext);

                ToolStripMenuItem Formu = new ToolStripMenuItem();
                Formu.Text = "Formulaciones";
                Formu.Image = Properties.Resources.chart_line;
                mnuMain.Items.Add(Formu);

                ToolStripMenuItem NuevaFormu = new ToolStripMenuItem();
                NuevaFormu.Text = "Nueva";
                NuevaFormu.Image = Properties.Resources.add1;
                NuevaFormu.Click += new EventHandler(nuevaToolStripMenuItem5_Click);
                Formu.DropDownItems.Add(NuevaFormu);

                ToolStripMenuItem ListaFormu = new ToolStripMenuItem();
                ListaFormu.Text = "Listado";
                ListaFormu.Image = Properties.Resources.page;
                ListaFormu.Click += new EventHandler(listadoToolStripMenuItem17_Click);
                Formu.DropDownItems.Add(ListaFormu);

            }
            #endregion
            #region bobinadores campana
            if (clsGlobal.LoggedUser.RoleName == "Bobinadores")
            {
                tsmAdmin.Visible = false;
                tsmProduction.Visible = false;
                tsmBackload.Visible = false;
                tsmSales.Visible = false;
                tsmCellars.Visible = false;
                tsmCube.Visible = false;
                tsmRawMaterial.Visible = false;
                tsmManagement.Visible = false;
                tsmManagerFull.Visible = false;
                reportesToolStripMenuItem.Visible = false;

                ToolStripMenuItem prode = new ToolStripMenuItem();
                prode.Text = "Extrusora";
                prode.Image = Properties.Resources.rewind;
                mnuMain.Items.Add(prode);

                ToolStripMenuItem listaext = new ToolStripMenuItem();
                listaext.Text = "Listado de ordenes de extrusión";
                listaext.Image = Properties.Resources.page_out;
                listaext.Click += new EventHandler(loadExtrusionListC);
                prode.DropDownItems.Add(listaext);

                ToolStripMenuItem notiext = new ToolStripMenuItem();
                notiext.Text = "Notificación de bobinas madre";
                notiext.Image = Properties.Resources.mainCoil;
                notiext.Click += new EventHandler(loadMainCoilRegistrationC);
                prode.DropDownItems.Add(notiext);

                ToolStripMenuItem stockext = new ToolStripMenuItem();
                stockext.Text = "Stock de bobinas madre";
                stockext.Image = Properties.Resources.storage2;
                stockext.Click += new EventHandler(loadMainCoilStockC);
                prode.DropDownItems.Add(stockext);

            }
            #endregion
            #region calidad pilar
            if (clsGlobal.LoggedUser.RoleName == "Calidad Pilar")
            {
                tsmAdmin.Visible = false;
                tsmProduction.Visible = false;
                tsmBackload.Visible = false;
                tsmSales.Visible = false;
                tsmCellars.Visible = false;
                tsmCube.Visible = false;
                tsmRawMaterial.Visible = false;
                tsmManagement.Visible = false;
                tsmManagerFull.Visible = false;
                reportesToolStripMenuItem.Visible = false;

                ToolStripMenuItem cal = new ToolStripMenuItem();
                cal.Text = "Calidad";
                cal.Image = Properties.Resources.chart_line;
                mnuMain.Items.Add(cal);

                ToolStripMenuItem calBM = new ToolStripMenuItem();
                calBM.Text = "Control de bobinas madre";
                calBM.Image = Properties.Resources.mainCoil;
                calBM.Click += new EventHandler(registrarPropiedadesPorBobinaMadreToolStripMenuItem_Click);
                cal.DropDownItems.Add(calBM);

                ToolStripMenuItem calBMM = new ToolStripMenuItem();
                calBMM.Text = "Control de bobinas madre metal";
                calBMM.Image = Properties.Resources.metallized;
                calBMM.Click += new EventHandler(registrarPropiedadesRolloMetalizadosToolStripMenuItem_Click);
                cal.DropDownItems.Add(calBMM);

                ToolStripMenuItem lisBM = new ToolStripMenuItem();
                lisBM.Text = "Listado de bobinas madre";
                lisBM.Image = Properties.Resources.page_coils;
                lisBM.Click += new EventHandler(listadoDeBobinasMadreToolStripMenuItemPL_Click);
                cal.DropDownItems.Add(lisBM);
                
                ToolStripMenuItem lisBMM = new ToolStripMenuItem();
                lisBMM.Text = "Listado de bobinas madre metal";
                lisBMM.Image = Properties.Resources.clipboard_text;
                lisBMM.Click += new EventHandler(toolStripTextBox1PL_Click);
                cal.DropDownItems.Add(lisBMM);
                
                /*ToolStripMenuItem calOS = new ToolStripMenuItem();
                calOS.Text = "Control de bobinas en proceso y segunda";
                calOS.Click += new EventHandler(inProcessCoilsTSMItem_Click);
                cal.DropDownItems.Add(calOS);*/

                ToolStripMenuItem traza = new ToolStripMenuItem();
                traza.Text = "Trazabilidad";
                traza.Image = Properties.Resources.magnifier;
                cal.DropDownItems.Add(traza);

                ToolStripMenuItem trazaB = new ToolStripMenuItem();
                trazaB.Text = "Detalle de bobina";
                trazaB.Image = Properties.Resources.page_coils;
                trazaB.Click += new EventHandler(detalleDeBobinaToolStripMenuItem_Click);
                traza.DropDownItems.Add(trazaB);

                ToolStripMenuItem trazaP = new ToolStripMenuItem();
                trazaP.Text = "Detalle de pallet";
                trazaP.Image = Properties.Resources.page;
                trazaP.Click += new EventHandler(detalleDePalletToolStripMenuItem_Click);
                traza.DropDownItems.Add(trazaP);

                ToolStripMenuItem trazaRC = new ToolStripMenuItem();
                trazaRC.Text = "Reporte de corte";
                trazaRC.Image = Properties.Resources.page_white_wrench;
                trazaRC.Click += new EventHandler(corteToolStripMenuItem_Click);
                traza.DropDownItems.Add(trazaRC);

                ToolStripMenuItem trazaC = new ToolStripMenuItem();
                trazaC.Text = "Trazabilidad de Corte";
                trazaC.Image = Properties.Resources.magnifier;
                trazaC.Click += new EventHandler(trazabilidadDeCorteToolStripMenuItem_Click);
                traza.DropDownItems.Add(trazaC);

                ToolStripMenuItem pred = new ToolStripMenuItem();
                pred.Text = "Pre-Despachos";
                pred.Image = Properties.Resources.delivery_national;
                pred.Click += new EventHandler(listadoToolStripMenuItem2_Click_1);
                traza.DropDownItems.Add(pred);

                ToolStripMenuItem predDetail = new ToolStripMenuItem();
                predDetail.Text = "Detalle de Pre-Despachos";
                predDetail.Image = Properties.Resources.reportOff;
                predDetail.Click += new EventHandler(predDespDetail_Click);
                traza.DropDownItems.Add(predDetail);

                ToolStripMenuItem reppred = new ToolStripMenuItem();
                reppred.Text = "Reporte de Despachos";
                reppred.Image = Properties.Resources.report;
                reppred.Click += new EventHandler(shippingReportL_Click);
                traza.DropDownItems.Add(reppred);

                ToolStripMenuItem inventarios = new ToolStripMenuItem();
                inventarios.Text = "Inventarios";
                inventarios.Image = Properties.Resources.storage2;
                cal.DropDownItems.Add(inventarios);

                ToolStripMenuItem Stock = new ToolStripMenuItem();
                Stock.Text = "Rack Primario";
                Stock.Image = Properties.Resources.box1;
                Stock.Click += new EventHandler(loadMainCoilStockPL);
                inventarios.DropDownItems.Add(Stock);

                ToolStripMenuItem StockM = new ToolStripMenuItem();
                StockM.Text = "Rack Secundario";
                StockM.Image = Properties.Resources.box1;
                StockM.Click += new EventHandler(loadMainCoilMetalStockPL);
                inventarios.DropDownItems.Add(StockM);

                ToolStripMenuItem ProdT = new ToolStripMenuItem();
                ProdT.Text = "Inventario Completo de Pallets";
                ProdT.Image = Properties.Resources.pallet;
                ProdT.Click += new EventHandler(stockDePalletsToolStripMenuItem_Click_1);
                inventarios.DropDownItems.Add(ProdT);

                ToolStripMenuItem ProdP = new ToolStripMenuItem();
                ProdP.Text = "Inventario Completo de Bobinas";
                ProdP.Image = Properties.Resources.coilSecundaryCut;
                ProdP.Click += new EventHandler(stockDeOP1ToolStripMenuItem_Click_1);
                inventarios.DropDownItems.Add(ProdP);

                ToolStripMenuItem CC = new ToolStripMenuItem();
                CC.Text = "Certificados";
                CC.Image = Properties.Resources.bookmark_document;
                cal.DropDownItems.Add(CC);

                ToolStripMenuItem CCP = new ToolStripMenuItem();
                CCP.Text = "Parametrización";
                CCP.Image = Properties.Resources.chart_line;
                CCP.Click += new EventHandler(rangoDeAceptaciónToolStripMenuItem_Click);
                CC.DropDownItems.Add(CCP);

                ToolStripMenuItem CCN = new ToolStripMenuItem();
                CCN.Text = "Nuevo";
                CCN.Image = Properties.Resources.add1;
                CCN.Click += new EventHandler(nuevoToolStripMenuItem3_Click);
                CC.DropDownItems.Add(CCN);

                ToolStripMenuItem CCL = new ToolStripMenuItem();
                CCL.Text = "Listado";
                CCL.Image = Properties.Resources.page;
                CCL.Click += new EventHandler(listadoToolStripMenuItem4_Click);
                CC.DropDownItems.Add(CCL);

                ToolStripMenuItem extcal = new ToolStripMenuItem();
                extcal.Text = "Extrusión";
                extcal.Image = Properties.Resources.rewind;
                mnuMain.Items.Add(extcal);

                ToolStripMenuItem OP = new ToolStripMenuItem();
                OP.Text = "Nueva Orden de extrusión";
                OP.Image = Properties.Resources.page_white_database;
                OP.Click += new EventHandler(nuevaToolStripMenuItem4_Click);
                extcal.DropDownItems.Add(OP);

                ToolStripMenuItem POP = new ToolStripMenuItem();
                POP.Text = "Planificación de extrusión";
                POP.Image = Properties.Resources.calendar;
                POP.Click += new EventHandler(listadoToolStripMenuItem16_Click);
                extcal.DropDownItems.Add(POP);

                ToolStripMenuItem Rext = new ToolStripMenuItem();
                Rext.Text = "Reporte de extrusión";
                Rext.Image = Properties.Resources.report;
                Rext.Click += new EventHandler(extrusionToolStripMenuItem_Click);
                extcal.DropDownItems.Add(Rext);
               
                ToolStripMenuItem QualityControls = new ToolStripMenuItem();
                QualityControls.Text = "Control de calidad";
                QualityControls.Image = Properties.Resources.bug_delete;
                QualityControls.Click += new EventHandler(QualityControls_Click);
                cal.DropDownItems.Add(QualityControls);

                ToolStripMenuItem QualityControlsByFilm = new ToolStripMenuItem();
                QualityControlsByFilm.Text = "Planes de Control";
                QualityControlsByFilm.Image = Properties.Resources.bug_edit;
                QualityControlsByFilm.Click += new EventHandler(QualityControlsByFilm_Click);
                cal.DropDownItems.Add(QualityControlsByFilm);

                ToolStripMenuItem MCQualityControls = new ToolStripMenuItem();
                MCQualityControls.Text = "Control de bobina madre";
                MCQualityControls.Image = Properties.Resources.observationCoils;
                MCQualityControls.Click += new EventHandler(MainCoilQualityControls_Click);
                cal.DropDownItems.Add(MCQualityControls);

            }
            #endregion
            #region analistas/jefe calidad campana
            if (clsGlobal.LoggedUser.RoleName == "Analistas de laboratorio" || clsGlobal.LoggedUser.RoleName == "Jefe de control de Calidad")
            {
                tsmAdmin.Visible = false;
                tsmProduction.Visible = false;
                tsmBackload.Visible = false;
                tsmSales.Visible = false;
                tsmCellars.Visible = false;
                tsmCube.Visible = false;
                tsmRawMaterial.Visible = false;
                tsmManagement.Visible = false;
                tsmManagerFull.Visible = false;
                reportesToolStripMenuItem.Visible = false;

                #region Calidad
                
                
                ToolStripMenuItem cal = new ToolStripMenuItem();
                cal.Text = "Calidad";
                cal.Image = Properties.Resources.chart_line;
                cal.Image = Properties.Resources.bug_delete;
                mnuMain.Items.Add(cal);

                ToolStripMenuItem calBM = new ToolStripMenuItem();
                calBM.Text = "Control de bobinas madre";
                calBM.Image = Properties.Resources.coils1;
                calBM.Click += new EventHandler(registrarPropiedadesPorBobinaMadreToolStripMenuItem_Click);
                cal.DropDownItems.Add(calBM);

                ToolStripMenuItem calBMM = new ToolStripMenuItem();
                calBMM.Text = "Control de bobinas madre metal";
                calBMM.Image = Properties.Resources.page_white_gear;
                calBMM.Click += new EventHandler(registrarPropiedadesRolloMetalizadosToolStripMenuItem_Click);
                cal.DropDownItems.Add(calBMM);

                ToolStripMenuItem lisBM = new ToolStripMenuItem();
                lisBM.Text = "Listado de bobinas madre";
                lisBM.Image = Properties.Resources.page_coils;
                lisBM.Click += new EventHandler(listadoDeBobinasMadreToolStripMenuItemC_Click);
                cal.DropDownItems.Add(lisBM);
                
                ToolStripMenuItem lisBMM = new ToolStripMenuItem();
                lisBMM.Text = "Listado de bobinas madre metal";
                lisBMM.Image = Properties.Resources.page_coils;
                lisBMM.Click += new EventHandler(toolStripTextBox1_Click);
                cal.DropDownItems.Add(lisBMM);
                
                /*ToolStripMenuItem calOS = new ToolStripMenuItem();
                calOS.Text = "Control de bobinas en proceso y segunda";
                calOS.Click += new EventHandler(inProcessCoilsTSMItem_Click);
                cal.DropDownItems.Add(calOS);*/

                ToolStripMenuItem traza = new ToolStripMenuItem();
                traza.Text = "Trazabilidad";
                traza.Image = Properties.Resources.magnifier;
                cal.DropDownItems.Add(traza);

                ToolStripMenuItem trazaB = new ToolStripMenuItem();
                trazaB.Text = "Detalle de bobina";
                trazaB.Image = Properties.Resources.page_coils;
                trazaB.Click += new EventHandler(detalleDeBobinaToolStripMenuItem_Click);
                traza.DropDownItems.Add(trazaB);

                ToolStripMenuItem trazaP = new ToolStripMenuItem();
                trazaP.Text = "Detalle de pallet";
                trazaP.Image = Properties.Resources.pallet;
                trazaP.Click += new EventHandler(detalleDePalletToolStripMenuItem_Click);
                traza.DropDownItems.Add(trazaP);

                ToolStripMenuItem trazaRC = new ToolStripMenuItem();
                trazaRC.Text = "Reporte de corte";
                trazaRC.Image = Properties.Resources.reportOff;
                trazaRC.Click += new EventHandler(corteToolStripMenuItem_Click);
                traza.DropDownItems.Add(trazaRC);

                ToolStripMenuItem trazaRM = new ToolStripMenuItem();
                trazaRM.Text = "Reporte de metalizado";
                trazaRM.Image = Properties.Resources.reportOff;
                trazaRM.Click += new EventHandler(metalizadoToolStripMenuItem_Click);
                traza.DropDownItems.Add(trazaRM);

                ToolStripMenuItem trazaC = new ToolStripMenuItem();
                trazaC.Text = "Trazabilidad de Corte";
                trazaC.Image = Properties.Resources.magnifier;
                trazaC.Click += new EventHandler(trazabilidadDeCorteToolStripMenuItem_Click);
                traza.DropDownItems.Add(trazaC);

                ToolStripMenuItem pred = new ToolStripMenuItem();
                pred.Text = "Pre-Despachos";
                pred.Image = Properties.Resources.clipboard_text;
                pred.Click += new EventHandler(listadoToolStripMenuItem2_Click_1);
                traza.DropDownItems.Add(pred);

                ToolStripMenuItem predDetail = new ToolStripMenuItem();
                predDetail.Text = "Detalle de Pre-Despachos";
                predDetail.Image = Properties.Resources.reportOff;
                predDetail.Click += new EventHandler(predDespDetail_Click);
                traza.DropDownItems.Add(predDetail);

                ToolStripMenuItem reppred = new ToolStripMenuItem();
                reppred.Text = "Reporte de Despachos";
                reppred.Image = Properties.Resources.report;
                reppred.Click += new EventHandler(shippingReportL_Click);
                traza.DropDownItems.Add(reppred);

                ToolStripMenuItem inventarios = new ToolStripMenuItem();
                inventarios.Text = "Inventarios";
                inventarios.Image = Properties.Resources.inventory;
                cal.DropDownItems.Add(inventarios);

                ToolStripMenuItem Stock = new ToolStripMenuItem();
                Stock.Text = "Rack Primario";
                Stock.Image = Properties.Resources.mainCoil;
                Stock.Click += new EventHandler(loadMainCoilStockC);
                inventarios.DropDownItems.Add(Stock);

                ToolStripMenuItem StockM = new ToolStripMenuItem();
                StockM.Text = "Bobinas Colgantes";
                StockM.Image = Properties.Resources.mainCoil;
                StockM.Click += new EventHandler(loadMainCoilMetalStock);
                inventarios.DropDownItems.Add(StockM);

                ToolStripMenuItem ProdT = new ToolStripMenuItem();
                ProdT.Text = "Inventario Completo de Pallets";
                ProdT.Image = Properties.Resources.pallet;
                ProdT.Click += new EventHandler(stockDePalletsToolStripMenuItem_Click_1);
                inventarios.DropDownItems.Add(ProdT);

                ToolStripMenuItem ProdP = new ToolStripMenuItem();
                ProdP.Text = "Inventario Completo de Bobinas";
                ProdP.Image = Properties.Resources.coilSecundaryCut;
                ProdP.Click += new EventHandler(stockDeOP1ToolStripMenuItem_Click_1);
                inventarios.DropDownItems.Add(ProdP);

                ToolStripMenuItem CC = new ToolStripMenuItem();
                CC.Text = "Certificados";
                CC.Image = Properties.Resources.bookmark_document;
                cal.DropDownItems.Add(CC);

                ToolStripMenuItem CCP = new ToolStripMenuItem();
                CCP.Text = "Parametrización";
                CCP.Image = Properties.Resources.chart_line;
                CCP.Click += new EventHandler(rangoDeAceptaciónToolStripMenuItem_Click);
                CC.DropDownItems.Add(CCP);

                ToolStripMenuItem CCN = new ToolStripMenuItem();
                CCN.Text = "Nuevo";
                CCN.Image = Properties.Resources.bookmark_document;
                CCN.Click += new EventHandler(nuevoToolStripMenuItem3_Click);
                CC.DropDownItems.Add(CCN);

                ToolStripMenuItem CCL = new ToolStripMenuItem();
                CCL.Text = "Listado";
                CCL.Image = Properties.Resources.bookmark_book_open;
                CCL.Click += new EventHandler(listadoToolStripMenuItem4_Click);
                CC.DropDownItems.Add(CCL);

                #endregion

                #region Extrusion

                ToolStripMenuItem extcal = new ToolStripMenuItem();
                extcal.Text = "Extrusión";
                extcal.Image = Properties.Resources.gear_16;
                mnuMain.Items.Add(extcal);

                ToolStripMenuItem OP = new ToolStripMenuItem();
                OP.Text = "Nueva Orden de extrusión";
                OP.Image = Properties.Resources.clipboard_text;
                OP.Click += new EventHandler(nuevaToolStripMenuItem4_Click);
                extcal.DropDownItems.Add(OP);

                ToolStripMenuItem POP = new ToolStripMenuItem();
                POP.Text = "Planificación de extrusión";
                POP.Image = Properties.Resources.calendar;
                POP.Click += new EventHandler(listadoToolStripMenuItem16_Click);
                extcal.DropDownItems.Add(POP);

                ToolStripMenuItem Rext = new ToolStripMenuItem();
                Rext.Text = "Reporte de extrusión";
                Rext.Image = Properties.Resources.chart_line;
                Rext.Click += new EventHandler(extrusionToolStripMenuItem_Click);
                extcal.DropDownItems.Add(Rext);

                #endregion

            }
            #endregion
            #region jefe de corte-prog-plan (operaciones)
            //MENU DE OPERACIONES Pilar & Campana   
            if (clsGlobal.LoggedUser.RoleName == "Jefe de Corte - Programación - Planificación")
            {
                //tsmAdmin.Visible = false;
                tsmProduction.Visible = false;
                tsmSales.Visible = false;
                tsmRequests.Visible = false;
                tsmBackload.Visible = false;
                tsmCellars.Visible = false;
                tsmCube.Visible = false;
                tsmRawMaterial.Visible = false;
                tsmManagement.Visible = false;
                tsmManagerFull.Visible = false;
                reportesToolStripMenuItem.Visible = false;

                //OPERACIONES
                ToolStripMenuItem op = new ToolStripMenuItem();
                op.Text = "Operaciones";
                op.Image = Properties.Resources.gear_16;
                mnuMain.Items.Add(op);

                //PLANIFICACION
                ToolStripMenuItem PLNF = new ToolStripMenuItem();
                PLNF.Text = "Planificación";
                PLNF.Image = Properties.Resources.calendar;
                op.DropDownItems.Add(PLNF);

                ToolStripMenuItem extr = new ToolStripMenuItem();
                extr.Text = "Extrusion";
                extr.Image = Properties.Resources.rewind;
                PLNF.DropDownItems.Add(extr);

                ToolStripMenuItem nuevaordenextr = new ToolStripMenuItem();
                nuevaordenextr.Text = "Nueva orden de extrusión";
                nuevaordenextr.Image = Properties.Resources.database_add;
                nuevaordenextr.Click += new EventHandler(nuevaToolStripMenuItem4_Click);
                extr.DropDownItems.Add(nuevaordenextr);

                ToolStripMenuItem listaext = new ToolStripMenuItem();
                listaext.Text = "Listado de ordenes de extrusión";
                listaext.Image = Properties.Resources.page_white_database;
                extr.DropDownItems.Add(listaext);

                

                ToolStripMenuItem listaextp = new ToolStripMenuItem();
                listaextp.Text = "Pilar";
                listaextp.Click += new EventHandler(loadExtrusionListPL);
                listaext.DropDownItems.Add(listaextp);

                ToolStripMenuItem listaextc = new ToolStripMenuItem();
                listaextc.Text = "Campana";
                listaextc.Click += new EventHandler(loadExtrusionListC);
                listaext.DropDownItems.Add(listaextc);

                ToolStripMenuItem planextru = new ToolStripMenuItem();
                planextru.Text = "Plan de extrusión (viejo)";
                planextru.Image = Properties.Resources.calendar_2;
                planextru.Click += new EventHandler(listadoToolStripMenuItem16_Click);
                extr.DropDownItems.Add(planextru);

                ToolStripMenuItem listaext2 = new ToolStripMenuItem();
                listaext2.Text = "Plan de extrusión (nuevo)";
                listaext2.Image = Properties.Resources.page_white_gear;
                listaext2.Click += new EventHandler(pruebaOrdenesDeExtrusionToolStripMenuItem_Click);
                extr.DropDownItems.Add(listaext2);

                //CORTE
                ToolStripMenuItem CORTE = new ToolStripMenuItem();
                CORTE.Text = "Corte";
                CORTE.Image = Properties.Resources.coilCut;
                PLNF.DropDownItems.Add(CORTE);

                ToolStripMenuItem nuevaocp = new ToolStripMenuItem();
                nuevaocp.Text = "Nueva orden de corte primario";
                nuevaocp.Click += new EventHandler(ordenesDeCorteToolStripMenuItem1_Click);
                CORTE.DropDownItems.Add(nuevaocp);

                ToolStripMenuItem nuevaocs = new ToolStripMenuItem();
                nuevaocs.Text = "Nueva orden de corte secundario";
                nuevaocs.Click += new EventHandler(toolStripMenuItem4_Click);
                CORTE.DropDownItems.Add(nuevaocs);

                ToolStripMenuItem planc = new ToolStripMenuItem();
                planc.Text = "Plan de corte";
                planc.Image = Properties.Resources.calendar_2;
                CORTE.DropDownItems.Add(planc);

                ToolStripMenuItem ATLAS = new ToolStripMenuItem();
                ATLAS.Text = "ATLAS";
                ATLAS.Image = Properties.Resources.gear_32;
                planc.DropDownItems.Add(ATLAS);

                ATLAS.Click += new EventHandler(loadCuttingOrderList);
                ToolStripMenuItem C230 = new ToolStripMenuItem();
                C230.Text = "C230";
                C230.Image = Properties.Resources.gear_32;
                planc.DropDownItems.Add(C230);
                C230.Click += new EventHandler(loadCuttingOrderList);

                ToolStripMenuItem C231 = new ToolStripMenuItem();
                C231.Text = "C231";
                C231.Image = Properties.Resources.gear_32;
                planc.DropDownItems.Add(C231);

                C231.Click += new EventHandler(loadCuttingOrderList);
                ToolStripMenuItem C232 = new ToolStripMenuItem();
                C232.Text = "C232";
                C232.Image = Properties.Resources.gear_32;
                planc.DropDownItems.Add(C232);
                C232.Click += new EventHandler(loadCuttingOrderList);

                ToolStripMenuItem GOEBEL = new ToolStripMenuItem();
                GOEBEL.Text = "GOEBEL";
                GOEBEL.Image = Properties.Resources.gear_32;
                planc.DropDownItems.Add(GOEBEL);
                GOEBEL.Click += new EventHandler(loadCuttingOrderList);

                ToolStripMenuItem SECATLAS = new ToolStripMenuItem();
                SECATLAS.Text = "SEC.ATLAS";
                SECATLAS.Image = Properties.Resources.gear_32;
                planc.DropDownItems.Add(SECATLAS);
                SECATLAS.Click += new EventHandler(SECATLAS_Click);

                ToolStripMenuItem TITAN = new ToolStripMenuItem();
                TITAN.Text = "TITAN";
                TITAN.Image = Properties.Resources.gear_32;
                planc.DropDownItems.Add(TITAN);
                TITAN.Click += new EventHandler(loadCuttingOrderList);

                ToolStripMenuItem SINASIGNAR = new ToolStripMenuItem();
                SINASIGNAR.Text = "SIN ASIGNAR";
                SINASIGNAR.Image = Properties.Resources.gear_32;
                planc.DropDownItems.Add(SINASIGNAR);
                SINASIGNAR.Click += new EventHandler(loadCuttingOrderList);


                //METALIZADO
                ToolStripMenuItem METALIZADO = new ToolStripMenuItem();
                METALIZADO.Text = "Metalizado";
                METALIZADO.Image = Properties.Resources.metallized;
                PLNF.DropDownItems.Add(METALIZADO);

                ToolStripMenuItem nuevaomet = new ToolStripMenuItem();
                nuevaomet.Text = "Nueva orden de metalizado";
                nuevaomet.Image = Properties.Resources.add1;
                nuevaomet.Click += new EventHandler(nuevaToolStripMenuItem2_Click_2);
                METALIZADO.DropDownItems.Add(nuevaomet);

                ToolStripMenuItem planmet = new ToolStripMenuItem();
                planmet.Text = "Plan de metalizado";
                planmet.Image = Properties.Resources.calendar;
                planmet.Click += new EventHandler(listadoToolStripMenuItem1_Click_2);
                METALIZADO.DropDownItems.Add(planmet);

                /*ToolStripMenuItem newOrdMet = new ToolStripMenuItem();
                newOrdMet.Text = "Nueva orden de metalizado (Sistema Nuevo)";
                newOrdMet.Image = Properties.Resources.add1;
                newOrdMet.Click += new EventHandler(newOrdMet_Click);
                METALIZADO.DropDownItems.Add(newOrdMet);

                ToolStripMenuItem newMetPlan = new ToolStripMenuItem();
                newMetPlan.Text = "Historial de Ordenes de Metalizado (Sistema Nuevo)";
                newMetPlan.Image = Properties.Resources.calendar;
                newMetPlan.Click += new EventHandler(historyOfMetalOrders_Click);
                METALIZADO.DropDownItems.Add(newMetPlan);*/

                //INVENTARIOS
                ToolStripMenuItem INVENTARIOS = new ToolStripMenuItem();
                INVENTARIOS.Text = "Inventarios";
                INVENTARIOS.Image = Properties.Resources.page_white_database;
                op.DropDownItems.Add(INVENTARIOS);

                ToolStripMenuItem rackprimario = new ToolStripMenuItem();
                rackprimario.Text = "Rack primario";
                rackprimario.Image = Properties.Resources.page_white_gear;
                INVENTARIOS.DropDownItems.Add(rackprimario);

                ToolStripMenuItem rppilar = new ToolStripMenuItem();
                rppilar.Text = "Pilar";
                rppilar.Click += new EventHandler(loadMainCoilStockPL);
                rackprimario.DropDownItems.Add(rppilar);

                ToolStripMenuItem rpcampana = new ToolStripMenuItem();
                rpcampana.Text = "Campana";
                rpcampana.Click += new EventHandler(loadMainCoilStockC);
                rackprimario.DropDownItems.Add(rpcampana);

                ToolStripMenuItem HistR = new ToolStripMenuItem();
                HistR.Text = "Historial de rack primario";
                HistR.Image = Properties.Resources.calendar_2;
                HistR.Click += new EventHandler(historialDeRackPrimarioToolStripMenuItem_Click);
                rackprimario.DropDownItems.Add(HistR);

                ToolStripMenuItem racksecundario = new ToolStripMenuItem();
                racksecundario.Text = "Rack secundario";
                racksecundario.Image = Properties.Resources.coils1;
                INVENTARIOS.DropDownItems.Add(racksecundario);

                ToolStripMenuItem rsecpilar = new ToolStripMenuItem();
                rsecpilar.Text = "Pilar";
                rsecpilar.Click += new EventHandler(loadMainCoilMetalStockPL);
                racksecundario.DropDownItems.Add(rsecpilar);

                ToolStripMenuItem rseccampana = new ToolStripMenuItem();
                rseccampana.Text = "Campana";
                rseccampana.Click += new EventHandler(loadMainCoilMetalStock);
                racksecundario.DropDownItems.Add(rseccampana);

                ToolStripMenuItem HistRs = new ToolStripMenuItem();
                HistRs.Text = "Historial de rack secundario";
                HistRs.Image = Properties.Resources.calendar_2;
                HistRs.Click += new EventHandler(historialDeRackSecundarioToolStripMenuItem_Click);
                racksecundario.DropDownItems.Add(HistRs);

                ToolStripMenuItem ProdT = new ToolStripMenuItem();
                ProdT.Text = "Inventario de Pallets";
                ProdT.Image = Properties.Resources.pallet;
                ProdT.Click += new EventHandler(stockDePalletsToolStripMenuItem_Click_1);
                INVENTARIOS.DropDownItems.Add(ProdT);

                ToolStripMenuItem historialPallets = new ToolStripMenuItem();
                historialPallets.Text = "Historial inventario de pallets";
                historialPallets.Image = Properties.Resources.calendar_2;
                historialPallets.Click += new EventHandler(historialDeDepositoDePalletsToolStripMenuItem_Click);
                INVENTARIOS.DropDownItems.Add(historialPallets);

                ToolStripMenuItem ProdP = new ToolStripMenuItem();
                ProdP.Text = "Inventario de Bobinas";
                ProdP.Image = Properties.Resources.storage2;
                ProdP.Click += new EventHandler(stockDeOP1ToolStripMenuItem_Click_1);
                INVENTARIOS.DropDownItems.Add(ProdP);

                ToolStripMenuItem historialBobinas = new ToolStripMenuItem();
                historialBobinas.Text = "Historial inventario de bobinas";
                historialBobinas.Image = Properties.Resources.calendar_2;
                historialBobinas.Click += new EventHandler(historialDeDepositoDeBobinasToolStripMenuItem_Click);
                INVENTARIOS.DropDownItems.Add(historialBobinas);

                ToolStripMenuItem MATERIAPRIMA = new ToolStripMenuItem();
                MATERIAPRIMA.Text = "Materia Prima";
                INVENTARIOS.DropDownItems.Add(MATERIAPRIMA);

                ToolStripMenuItem estadodedepositomatprima = new ToolStripMenuItem();
                estadodedepositomatprima.Text = "Inventario de MP";
                estadodedepositomatprima.Image = Properties.Resources.box1;
                estadodedepositomatprima.Click += new EventHandler(estadoDeDepositoMP_Click);
                MATERIAPRIMA.DropDownItems.Add(estadodedepositomatprima);

                ToolStripMenuItem historialMateriaPrima = new ToolStripMenuItem();
                historialMateriaPrima.Text = "Historial de deposito de materia prima";
                historialMateriaPrima.Image = Properties.Resources.calendar;
                historialMateriaPrima.Click += new EventHandler(rawdepothistory_Click);
                MATERIAPRIMA.DropDownItems.Add(historialMateriaPrima);

                ToolStripMenuItem reportIngresoMP = new ToolStripMenuItem();
                reportIngresoMP.Text = "Reporte de Ingreso de MP";
                reportIngresoMP.Image = Properties.Resources.report;
                reportIngresoMP.Click += new EventHandler(reportIngresoMP_Click);
                MATERIAPRIMA.DropDownItems.Add(reportIngresoMP);

                ToolStripMenuItem reportemovimientosmatprima = new ToolStripMenuItem();
                reportemovimientosmatprima.Text = "Reporte de Movimientos de MP";
                reportemovimientosmatprima.Image = Properties.Resources.report;
                reportemovimientosmatprima.Click += new EventHandler(reportemovimientosmatprima_Click);
                MATERIAPRIMA.DropDownItems.Add(reportemovimientosmatprima);

                ToolStripMenuItem despachoReport = new ToolStripMenuItem();
                despachoReport.Text = "Reporte de Despachos de Materias Primas";
                despachoReport.Image = Properties.Resources.report;
                despachoReport.Click += new EventHandler(despachoReport_Click);
                MATERIAPRIMA.DropDownItems.Add(despachoReport);

                //REPORTES
                ToolStripMenuItem REPORTES = new ToolStripMenuItem();
                REPORTES.Text = "Reportes";
                REPORTES.Image = Properties.Resources.report;
                op.DropDownItems.Add(REPORTES);

                ToolStripMenuItem combentfechas = new ToolStripMenuItem();
                combentfechas.Text = "Combinaciones entre fechas";
                combentfechas.Image = Properties.Resources.reportSalesorder;
                combentfechas.Click += new EventHandler(reporteDeProgramacionToolStripMenuItem_Click);
                REPORTES.DropDownItems.Add(combentfechas);

                ToolStripMenuItem extrentfechas = new ToolStripMenuItem();
                extrentfechas.Text = "Extrusión entre fechas";
                extrentfechas.Image = Properties.Resources.calendar_2;
                extrentfechas.Click += new EventHandler(extrusionToolStripMenuItem_Click);
                REPORTES.DropDownItems.Add(extrentfechas);

                ToolStripMenuItem corteentfechas = new ToolStripMenuItem();
                corteentfechas.Text = "Corte entre fechas";
                corteentfechas.Image = Properties.Resources.report;
                corteentfechas.Click += new EventHandler(corteToolStripMenuItem_Click);
                REPORTES.DropDownItems.Add(corteentfechas);

                ToolStripMenuItem metentfechas = new ToolStripMenuItem();
                metentfechas.Text = "Metalizado entre fechas";
                metentfechas.Image = Properties.Resources.page_white_database;
                metentfechas.Click += new EventHandler(metalizadoToolStripMenuItem_Click);
                REPORTES.DropDownItems.Add(metentfechas);

                ToolStripMenuItem rebobentfechas = new ToolStripMenuItem();
                rebobentfechas.Text = "Rebobinado entre fechas";
                rebobentfechas.Image = Properties.Resources.reportOff;
                rebobentfechas.Click += new EventHandler(rebobinadoToolStripMenuItem_Click_1);
                REPORTES.DropDownItems.Add(rebobentfechas);

                ToolStripMenuItem swapReport = new ToolStripMenuItem();
                swapReport.Text = "Reporte de Swap";
                swapReport.Image = Properties.Resources.reportOff;
                swapReport.Click += new EventHandler(swapReportToolStripMenuItem_click);
                REPORTES.DropDownItems.Add(swapReport);

                ToolStripMenuItem ImportReport = new ToolStripMenuItem();
                ImportReport.Text = "Reporte de importaciones por bobina";
                ImportReport.Image = Properties.Resources.report;
                ImportReport.Click += new EventHandler(importReport_Click);
                REPORTES.DropDownItems.Add(ImportReport);

                ToolStripMenuItem dispatchReport = new ToolStripMenuItem();
                dispatchReport.Text = "Reporte de Despachos";
                dispatchReport.Image = Properties.Resources.report;
                dispatchReport.Click += new EventHandler(shippingsByCoil_Click);
                REPORTES.DropDownItems.Add(dispatchReport);

                ToolStripMenuItem otifReport = new ToolStripMenuItem();
                otifReport.Text = "Reporte de OTIF";
                otifReport.Image = Properties.Resources.report;
                otifReport.Click += new EventHandler(OTIFReport_Click);
                REPORTES.DropDownItems.Add(otifReport);

                ToolStripMenuItem PLReport = new ToolStripMenuItem();
                PLReport.Text = "Lista de empaque para OBENMAS";
                PLReport.Image = Properties.Resources.report;
                PLReport.Click += new EventHandler(listaDeEmpaqueToolStripMenuItem_Click);
                REPORTES.DropDownItems.Add(PLReport);

                //VENTAS
                ToolStripMenuItem VTAS = new ToolStripMenuItem();
                VTAS.Text = "Ventas";
                VTAS.Image = Properties.Resources.reportSalesorder;
                mnuMain.Items.Add(VTAS);

                ToolStripMenuItem pedidos = new ToolStripMenuItem();
                pedidos.Text = "Pedidos";
                pedidos.Image = Properties.Resources.cart;
                VTAS.DropDownItems.Add(pedidos);

                ToolStripMenuItem controldeped = new ToolStripMenuItem();
                controldeped.Text = "Control de pedidos";
                controldeped.Image = Properties.Resources.bookmark_document;
                controldeped.Click += new EventHandler(controlDePedidosToolStripMenuItem_Click);
                pedidos.DropDownItems.Add(controldeped);

                ToolStripMenuItem historial = new ToolStripMenuItem();
                historial.Text = "Historial";
                historial.Image = Properties.Resources.calendar_2;
                historial.Click += new EventHandler(historialDePedidosToolStripMenuItem_Click);
                pedidos.DropDownItems.Add(historial);

                ToolStripMenuItem asignplanta = new ToolStripMenuItem();
                asignplanta.Text = "Asignación de planta";
                asignplanta.Image = Properties.Resources.server;
                asignplanta.Click += new EventHandler(asignaciónDePlantasToolStripMenuItem_Click);
                pedidos.DropDownItems.Add(asignplanta);

                ToolStripMenuItem definiciones = new ToolStripMenuItem();
                definiciones.Text = "Definiciones";
                definiciones.Image = Properties.Resources.delivery_national;
                VTAS.DropDownItems.Add(definiciones);

                ToolStripMenuItem controldef = new ToolStripMenuItem();
                controldef.Text = "Control de Definiciones";
                controldef.Image = Properties.Resources.page;
                controldef.Click += new EventHandler(definicionesDeCorteToolStripMenuItem_Click);
                definiciones.DropDownItems.Add(controldef);

                ToolStripMenuItem histodef = new ToolStripMenuItem();
                histodef.Text = "Historial";
                histodef.Image = Properties.Resources.calendar_2;
                histodef.Click += new EventHandler(historialDeDefinicionesToolStripMenuItem_Click);
                definiciones.DropDownItems.Add(histodef);

                ToolStripMenuItem predesp = new ToolStripMenuItem();
                predesp.Text = "Pre-despachos";
                predesp.Image = Properties.Resources.box1;
                VTAS.DropDownItems.Add(predesp);

                ToolStripMenuItem listadopredesp = new ToolStripMenuItem();
                listadopredesp.Text = "Listado";
                listadopredesp.Image = Properties.Resources.page_white_put;
                listadopredesp.Click += new EventHandler(listadoToolStripMenuItem2_Click_2);
                predesp.DropDownItems.Add(listadopredesp);

                ToolStripMenuItem reportesvtas = new ToolStripMenuItem();
                reportesvtas.Text = "Reportes";
                reportesvtas.Image = Properties.Resources.report;
                VTAS.DropDownItems.Add(reportesvtas);

                ToolStripMenuItem detalleBL = new ToolStripMenuItem();
                detalleBL.Text = "Detalle de BL";
                detalleBL.Image = Properties.Resources.report;
                detalleBL.Click += new EventHandler(detalleDeBLToolStripMenuItem1_Click);
                reportesvtas.DropDownItems.Add(detalleBL);

                ToolStripMenuItem reasignvtas = new ToolStripMenuItem();
                reasignvtas.Text = "Reasignaciones";
                reasignvtas.Image = Properties.Resources.arrow_curve;
                reasignvtas.Click += new EventHandler(reasignacionesToolStripMenuItem2_Click);
                reportesvtas.DropDownItems.Add(reasignvtas);

                ToolStripMenuItem ingped = new ToolStripMenuItem();
                ingped.Text = "Ingreso de pedidos";
                ingped.Image = Properties.Resources.arrow_curve;
                ingped.Click += new EventHandler(toolStripMenuItem5_Click_2);
                reportesvtas.DropDownItems.Add(ingped);

                //CALIDAD
                ToolStripMenuItem CAL = new ToolStripMenuItem();
                CAL.Text = "Calidad";
                CAL.Image = Properties.Resources.chart_line;
                mnuMain.Items.Add(CAL);

                ToolStripMenuItem trazaB = new ToolStripMenuItem();
                trazaB.Text = "Detalle de bobina";
                trazaB.Image = Properties.Resources.page_white_database;
                trazaB.Click += new EventHandler(detalleDeBobinaToolStripMenuItem_Click);
                CAL.DropDownItems.Add(trazaB);

                ToolStripMenuItem trazaP = new ToolStripMenuItem();
                trazaP.Text = "Detalle de pallet";
                trazaP.Image = Properties.Resources.magnifier;
                trazaP.Click += new EventHandler(detalleDePalletToolStripMenuItem_Click);
                CAL.DropDownItems.Add(trazaP);

                ToolStripMenuItem trazaC = new ToolStripMenuItem();
                trazaC.Text = "Trazabilidad de Corte";
                trazaC.Image = Properties.Resources.magnifier;
                trazaC.Click += new EventHandler(trazabilidadDeCorteToolStripMenuItem_Click);
                CAL.DropDownItems.Add(trazaC);

                ToolStripMenuItem res = new ToolStripMenuItem();
                res.Text = "Control de resultados";
                res.Image = Properties.Resources.document_edit;
                mnuMain.Items.Add(res);

                ToolStripMenuItem respt = new ToolStripMenuItem();
                respt.Text = "Resultados por turno";
                respt.Image = Properties.Resources.page_white_gear;
                respt.Click += new EventHandler(pruebaControlDeProdPorTurnoToolStripMenuItem_Click);
                res.DropDownItems.Add(respt);

                ToolStripMenuItem resef = new ToolStripMenuItem();
                resef.Text = "Resultados entre fechas";
                resef.Image = Properties.Resources.page_white_gear;
                resef.Click += new EventHandler(pruebaControlDeProdPorFechasToolStripMenuItem_Click);
                res.DropDownItems.Add(resef);
            }
            #endregion
            #region jefe planta pilar
            //MENU JEFE DE PLANTA PILAR (2035 Role)
            if(clsGlobal.LoggedUser.RoleName == "Jefe de Planta Pilar")
            {
                tsmAdmin.Visible = false;
                tsmProduction.Visible = false;
                tsmSales.Visible = false;
                tsmRequests.Visible = false;
                tsmBackload.Visible = false;
                tsmCellars.Visible = false;
                tsmCube.Visible = false;
                tsmRawMaterial.Visible = false;
                tsmManagement.Visible = false;
                tsmManagerFull.Visible = false;
                reportesToolStripMenuItem.Visible = false;

                //EXTRUSION
                ToolStripMenuItem EXTRUSION = new ToolStripMenuItem();
                EXTRUSION.Text = "Extrusion";
                EXTRUSION.Image = Properties.Resources.reprocess2;
                mnuMain.Items.Add(EXTRUSION);

                //Extrusora
                ToolStripMenuItem EXTRUSORA = new ToolStripMenuItem();
                EXTRUSORA.Text = "Extrusora";
                EXTRUSORA.Image = Properties.Resources.server;
                EXTRUSION.DropDownItems.Add(EXTRUSORA);

                ToolStripMenuItem plandeextrusion = new ToolStripMenuItem();
                plandeextrusion.Text = "Plan de extrusión";
                plandeextrusion.Image = Properties.Resources.calendar_2;
                plandeextrusion.Click += new EventHandler(listadoToolStripMenuItem16_Click);
                EXTRUSORA.DropDownItems.Add(plandeextrusion);

                ToolStripMenuItem rackprimario = new ToolStripMenuItem();
                rackprimario.Text = "Rack Primario";
                rackprimario.Image = Properties.Resources.storage2;
                rackprimario.Click += new EventHandler(loadMainCoilStockPL);
                EXTRUSORA.DropDownItems.Add(rackprimario);

                ToolStripMenuItem HistR = new ToolStripMenuItem();
                HistR.Text = "Historial de rack primario";
                HistR.Image = Properties.Resources.calendar_2;
                HistR.Click += new EventHandler(HistorialDeRack);
                EXTRUSORA.DropDownItems.Add(HistR);

                ToolStripMenuItem reportedeextrusion = new ToolStripMenuItem();
                reportedeextrusion.Text = "Reporte de extrusión";
                reportedeextrusion.Image = Properties.Resources.report;
                reportedeextrusion.Click += new EventHandler(extrusionToolStripMenuItem_Click);
                EXTRUSORA.DropDownItems.Add(reportedeextrusion);

                //Molino
                ToolStripMenuItem MOLINO = new ToolStripMenuItem();
                MOLINO.Text = "Molino";
                MOLINO.Image = Properties.Resources.coilMill;
                EXTRUSION.DropDownItems.Add(MOLINO);

                ToolStripMenuItem reportedeprodmolino = new ToolStripMenuItem();
                reportedeprodmolino.Text = "Reporte de producción de molino";
                reportedeprodmolino.Image = Properties.Resources.report;
                reportedeprodmolino.Click += new EventHandler(reportproduccionDeMolinoToolStripMenuItem_Click);
                MOLINO.DropDownItems.Add(reportedeprodmolino);

                //Materias Primas
                ToolStripMenuItem MATERIASPRIMAS = new ToolStripMenuItem();
                MATERIASPRIMAS.Text = "Marias Primas";
                MATERIASPRIMAS.Image = Properties.Resources.storage2;
                EXTRUSION.DropDownItems.Add(MATERIASPRIMAS);

                ToolStripMenuItem stockenextrusion = new ToolStripMenuItem();
                stockenextrusion.Text = "Stock en extrusión";
                stockenextrusion.Image = Properties.Resources.storage2;
                stockenextrusion.Click += new EventHandler(palletStockDeMateriasPrimasToolStripMenuItem_Click);
                MATERIASPRIMAS.DropDownItems.Add(stockenextrusion);

                ToolStripMenuItem repdeconsumodematprimas = new ToolStripMenuItem();
                repdeconsumodematprimas.Text = "Reporte de consumo de materias primas";
                repdeconsumodematprimas.Image = Properties.Resources.report;
                repdeconsumodematprimas.Click += new EventHandler(reporteDeConsumoDeMateriasPrimas_Click);
                MATERIASPRIMAS.DropDownItems.Add(repdeconsumodematprimas);
                
                //Scrap
                ToolStripMenuItem SCRAP = new ToolStripMenuItem();
                SCRAP.Text = "Scrap";
                SCRAP.Image = Properties.Resources.add_thermo;
                EXTRUSION.DropDownItems.Add(SCRAP);

                ToolStripMenuItem stockenmolino = new ToolStripMenuItem();
                stockenmolino.Text = "Stock en molino";
                stockenextrusion.Image = Properties.Resources.coilMill;
                stockenmolino.Click += new EventHandler(stockDeEstrusiónToolStripMenuItem_Click);
                SCRAP.DropDownItems.Add(stockenmolino);

                ToolStripMenuItem repdenotiscrap = new ToolStripMenuItem();
                repdenotiscrap.Text = "Reporte de notificación de scrap";
                repdenotiscrap.Image = Properties.Resources.report;
                repdenotiscrap.Click += new EventHandler(notificacionDeEstrusiónToolStripMenuItem_Click);
                SCRAP.DropDownItems.Add(repdenotiscrap);

                //CORTE Y METALIZADO
                ToolStripMenuItem CORTEYMETALIZADO = new ToolStripMenuItem();
                CORTEYMETALIZADO.Text = "Corte y Metalizado";
                CORTEYMETALIZADO.Image = Properties.Resources.coilCut;
                mnuMain.Items.Add(CORTEYMETALIZADO);

                //Corte
                ToolStripMenuItem CORTE = new ToolStripMenuItem();
                CORTE.Text = "Corte";
                CORTE.Image = Properties.Resources.coilCut;
                CORTEYMETALIZADO.DropDownItems.Add(CORTE);
                ToolStripMenuItem CORTPRIMARIA = new ToolStripMenuItem();
                
                //Cortadora Primaria
                CORTPRIMARIA.Text = "Cortadora Primaria";
                CORTE.DropDownItems.Add(CORTPRIMARIA);

                ToolStripMenuItem plandecorte = new ToolStripMenuItem();
                plandecorte.Text = "Plan de corte";
                plandecorte.Image = Properties.Resources.calendar_2;
                plandecorte.Click += new EventHandler(GOEBEL_Click);
                CORTPRIMARIA.DropDownItems.Add(plandecorte);

                ToolStripMenuItem rackprimariocym = new ToolStripMenuItem();
                rackprimariocym.Text = "Rack Primario";
                rackprimariocym.Image = Properties.Resources.storage2;
                rackprimariocym.Click += new EventHandler(loadMainCoilStockPL);
                CORTPRIMARIA.DropDownItems.Add(rackprimariocym);
                
                //Cortadora Secundaria
                ToolStripMenuItem CORTSECUNDARIA = new ToolStripMenuItem();
                CORTSECUNDARIA.Text = "Cortadora Secundaria";
                CORTE.DropDownItems.Add(CORTSECUNDARIA);
                CORTSECUNDARIA.Image = Properties.Resources.coilSecundaryCut;
                CORTPRIMARIA.DropDownItems.Add(rackprimariocym);

                //ATLAS
                ToolStripMenuItem ATLAS = new ToolStripMenuItem();
                ATLAS.Text = "Atlas";
                ATLAS.Image = Properties.Resources.server;
                CORTSECUNDARIA.DropDownItems.Add(ATLAS);

                ToolStripMenuItem plandecorteatlas = new ToolStripMenuItem();
                plandecorteatlas.Text = "Plan de corte";
                plandecorteatlas.Image = Properties.Resources.calendar_2;
                plandecorteatlas.Click += new EventHandler(ATLAS_Click);
                ATLAS.DropDownItems.Add(plandecorteatlas);

                ToolStripMenuItem racksecunatlas = new ToolStripMenuItem();
                racksecunatlas.Text = "Rack secundario";
                racksecunatlas.Image = Properties.Resources.storage2;
                racksecunatlas.Click += new EventHandler(rackMetalizadoToolStripMenuItem_Click);
                ATLAS.DropDownItems.Add(racksecunatlas);

                //TITAN
                ToolStripMenuItem TITAN = new ToolStripMenuItem();
                TITAN.Text = "Titan";
                TITAN.Image = Properties.Resources.server;
                CORTSECUNDARIA.DropDownItems.Add(TITAN);

                ToolStripMenuItem plandecortetitan = new ToolStripMenuItem();
                plandecortetitan.Text = "Plan de corte";
                plandecortetitan.Image = Properties.Resources.page_white_gear;
                plandecortetitan.Click += new EventHandler(TITAN_Click);
                TITAN.DropDownItems.Add(plandecortetitan);

                ToolStripMenuItem stockscarpcorte = new ToolStripMenuItem();
                stockscarpcorte.Text = "Stock de scrap de corte";
                stockscarpcorte.Image = Properties.Resources.storage2;
                stockscarpcorte.Click += new EventHandler(stockPalletsScrapToolStripMenuItem_Click);
                CORTE.DropDownItems.Add(stockscarpcorte);

                ToolStripMenuItem reportecorte = new ToolStripMenuItem();
                reportecorte.Text = "Reporte de corte";
                reportecorte.Image = Properties.Resources.report;
                reportecorte.Click += new EventHandler(corteToolStripMenuItem_Click);
                CORTE.DropDownItems.Add(reportecorte);

                ToolStripMenuItem reporterebobinado = new ToolStripMenuItem();
                reporterebobinado.Text = "Reporte de rebobinado";
                reporterebobinado.Image = Properties.Resources.report;
                reporterebobinado.Click += new EventHandler(rebobinadoToolStripMenuItem_Click_1);
                CORTE.DropDownItems.Add(reporterebobinado);

                ToolStripMenuItem reportescrapdecorte = new ToolStripMenuItem();
                reportescrapdecorte.Text = "Reporte de scrap de corte";
                reportescrapdecorte.Image = Properties.Resources.report;
                reportescrapdecorte.Click += new EventHandler(reportesDePalletsDeMermaToolStripMenuItem_Click);
                CORTE.DropDownItems.Add(reportescrapdecorte);

                //METALIZADO
                ToolStripMenuItem METALIZADO = new ToolStripMenuItem();
                METALIZADO.Text = "Metalizado";
                METALIZADO.Image = Properties.Resources.metallized;
                CORTEYMETALIZADO.DropDownItems.Add(METALIZADO);

                ToolStripMenuItem plandemetalizado = new ToolStripMenuItem();
                plandemetalizado.Text = "Plan de metalizado";
                plandemetalizado.Image = Properties.Resources.metallized2;
                plandemetalizado.Click += new EventHandler(listadoToolStripMenuItem1_Click_2);
                METALIZADO.DropDownItems.Add(plandemetalizado);

                ToolStripMenuItem reportedemetalizado = new ToolStripMenuItem();
                reportedemetalizado.Text = "Reporte de metalizado";
                reportedemetalizado.Image = Properties.Resources.metallized2;
                reportedemetalizado.Click += new EventHandler(metalizadoToolStripMenuItem_Click);
                METALIZADO.DropDownItems.Add(reportedemetalizado);

                //CALIDAD
                ToolStripMenuItem CALIDAD = new ToolStripMenuItem();
                CALIDAD.Text = "Calidad";
                CALIDAD.Image = Properties.Resources.chart_line;
                mnuMain.Items.Add(CALIDAD);

                ToolStripMenuItem listadobobmadres = new ToolStripMenuItem();
                listadobobmadres.Text = "Listado de Bobinas madre";
                listadobobmadres.Image = Properties.Resources.page_coils;
                listadobobmadres.Click += new EventHandler(listadoDeBobinasMadreToolStripMenuItem_Click);
                CALIDAD.DropDownItems.Add(listadobobmadres);
                
                //TRAZABILIDAD
                ToolStripMenuItem TRAZABILIDAD = new ToolStripMenuItem();
                TRAZABILIDAD.Text = "Trazabilidad";
                TRAZABILIDAD.Image = Properties.Resources.traceability;
                CALIDAD.DropDownItems.Add(TRAZABILIDAD);

                ToolStripMenuItem trazaB = new ToolStripMenuItem();
                trazaB.Text = "Detalle de bobina";
                trazaB.Image = Properties.Resources.magnifier;
                trazaB.Click += new EventHandler(detalleDeBobinaToolStripMenuItem_Click);
                TRAZABILIDAD.DropDownItems.Add(trazaB);

                ToolStripMenuItem trazaP = new ToolStripMenuItem();
                trazaP.Text = "Detalle de pallet";
                trazaP.Image = Properties.Resources.magnifier;
                trazaP.Click += new EventHandler(detalleDePalletToolStripMenuItem_Click);
                TRAZABILIDAD.DropDownItems.Add(trazaP);

                ToolStripMenuItem trazaRC = new ToolStripMenuItem();
                trazaRC.Text = "Reporte de corte";
                trazaRC.Image = Properties.Resources.report;
                trazaRC.Click += new EventHandler(corteToolStripMenuItem_Click);
                TRAZABILIDAD.DropDownItems.Add(trazaRC);

                ToolStripMenuItem trazaC = new ToolStripMenuItem();
                trazaC.Text = "Trazabilidad de Corte";
                trazaC.Image = Properties.Resources.magnifier;
                trazaC.Click += new EventHandler(trazabilidadDeCorteToolStripMenuItem_Click);
                TRAZABILIDAD.DropDownItems.Add(trazaC);

                ToolStripMenuItem invbs = new ToolStripMenuItem();
                invbs.Text = "Inventario de bobinas sueltas";
                invbs.Image = Properties.Resources.storage2;
                invbs.Click += new EventHandler(toolStripMenuItem6_Click_1);
                TRAZABILIDAD.DropDownItems.Add(invbs);

                //LOGISTICA

                ToolStripMenuItem LOGISTICA = new ToolStripMenuItem();
                LOGISTICA.Text = "Logistica";
                LOGISTICA.Image = Properties.Resources.delivery;
                mnuMain.Items.Add(LOGISTICA);

                //MATERIAS PRIMAS

                ToolStripMenuItem MATSPRIMAS = new ToolStripMenuItem();
                MATSPRIMAS.Text = "Materias Primas";
                MATSPRIMAS.Image = Properties.Resources.box;
                LOGISTICA.DropDownItems.Add(MATSPRIMAS);

                ToolStripMenuItem stockdmatpr = new ToolStripMenuItem();
                stockdmatpr.Text = "Stock de materias primas";
                stockdmatpr.Image = Properties.Resources.box1;
                stockdmatpr.Click += new EventHandler(estadoDeDepositoMP_Click);
                MATSPRIMAS.DropDownItems.Add(stockdmatpr);

                //PRODUCTO TERMINADO
                ToolStripMenuItem PRODTER = new ToolStripMenuItem();
                PRODTER.Text = "Productos";
                PRODTER.Image = Properties.Resources.pallet;
                LOGISTICA.DropDownItems.Add(PRODTER);

                ToolStripMenuItem stockprodt = new ToolStripMenuItem();
                stockprodt.Text = "Inventario Completo de Pallets";
                stockprodt.Image = Properties.Resources.pallet;
                stockprodt.Click += new EventHandler(stockDePalletsToolStripMenuItem_Click_1);
                PRODTER.DropDownItems.Add(stockprodt);

                ToolStripMenuItem stockprodenproceso2 = new ToolStripMenuItem();
                stockprodenproceso2.Text = "Inventario Completo de Bobinas";
                stockprodenproceso2.Image = Properties.Resources.storage2;
                stockprodenproceso2.Click += new EventHandler(stockDeOP1ToolStripMenuItem_Click_1);
                PRODTER.DropDownItems.Add(stockprodenproceso2);

                //DESPACHOS
                ToolStripMenuItem DESPACHOS = new ToolStripMenuItem();
                DESPACHOS.Text = "Despachos";
                DESPACHOS.Image = Properties.Resources.delivery;
                LOGISTICA.DropDownItems.Add(DESPACHOS);

                ToolStripMenuItem reportdedesp = new ToolStripMenuItem();
                reportdedesp.Text = "Reporte de despachos";
                reportdedesp.Image = Properties.Resources.report;
                reportdedesp.Click += new EventHandler(reportedespachos_Click);
                DESPACHOS.DropDownItems.Add(reportdedesp);

            }
            #endregion
            #region molinos campana
            if (clsGlobal.LoggedUser.RoleName == "Molinos")
            {
                tsmRawMaterialStock.Visible = false;
                reportesToolStripMenuItem.Visible = false;
                materiaPrimaToolStripMenuItem.Visible = false;
                reportesToolStripMenuItem.Visible = false;
                tsmRawMaterialProduct.Visible = false;
                tsmRawMaterial.Visible = false;
                tsmRawMaterial.Width = 0;
                tsmRawMaterial.Enabled = false;
        
                ToolStripMenuItem prodm = new ToolStripMenuItem();
                prodm.Text = "Molino";
                prodm.Image = Properties.Resources.coilMill;
                mnuMain.Items.Add(prodm);

                ToolStripMenuItem notim = new ToolStripMenuItem();
                notim.Text = "Notificación de recuperado/regranulado";
                notim.Image = Properties.Resources.coilMill;
                notim.Click += new EventHandler(produccionDeMolinoToolStripMenuItem_Click);
                prodm.DropDownItems.Add(notim);

                ToolStripMenuItem repm = new ToolStripMenuItem();
                repm.Text = "Reporte de producción de molino";
                repm.Image = Properties.Resources.report;
                repm.Click += new EventHandler(reportproduccionDeMolinoToolStripMenuItem_Click);
                prodm.DropDownItems.Add(repm);
            }
            #endregion
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string menuTree = getMenuTreeString(mnuMain.Items, 1);
            List<clsMachine> lstMachines = new List<clsMachine>();
            List<System.Windows.Forms.ToolStripMenuItem> lstToolStripMenues = new List<ToolStripMenuItem>();
            List<System.Windows.Forms.ToolStripMenuItem> lstToolStripMenues2 = new List<ToolStripMenuItem>();
            List<System.Windows.Forms.ToolStripMenuItem> lstToolStripMenues3 = new List<ToolStripMenuItem>();
            List<System.Windows.Forms.ToolStripMenuItem> lstToolStripMenues4 = new List<ToolStripMenuItem>();
            List<System.Windows.Forms.ToolStripMenuItem> lstToolStripMenues5 = new List<ToolStripMenuItem>();
            List<System.Windows.Forms.ToolStripMenuItem> lstToolStripMenues6 = new List<ToolStripMenuItem>();
            List<System.Windows.Forms.ToolStripMenuItem> lstToolStripMenues7 = new List<ToolStripMenuItem>();
            List<System.Windows.Forms.ToolStripMenuItem> lstToolStripMenues8 = new List<ToolStripMenuItem>();
            List<System.Windows.Forms.ToolStripMenuItem> lstToolStripMenues9 = new List<ToolStripMenuItem>();
            List<System.Windows.Forms.ToolStripMenuItem> lstToolStripMenues10 = new List<ToolStripMenuItem>();
            List<System.Windows.Forms.ToolStripMenuItem> lstToolStripMenues11 = new List<ToolStripMenuItem>();
            List<System.Windows.Forms.ToolStripMenuItem> lstToolStripMenues12 = new List<ToolStripMenuItem>();
            List<System.Windows.Forms.ToolStripMenuItem> lstToolStripMenues13 = new List<ToolStripMenuItem>();
            List<System.Windows.Forms.ToolStripMenuItem> lstToolStripMenues14 = new List<ToolStripMenuItem>();
            List<System.Windows.Forms.ToolStripMenuItem> lstToolStripMenues15 = new List<ToolStripMenuItem>();
            List<System.Windows.Forms.ToolStripMenuItem> lstExtruderMachinesForStock = new List<ToolStripMenuItem>();
            List<System.Windows.Forms.ToolStripMenuItem> lstExtruderMachineForComparation = new List<ToolStripMenuItem>();
            List<System.Windows.Forms.ToolStripMenuItem> lstExtruderMachineForConsumption = new List<ToolStripMenuItem>();
            List<System.Windows.Forms.ToolStripMenuItem> lstRawMaterialDelivery = new List<ToolStripMenuItem>();
            List<clsMachine> lstMachinesForProductionOrder = new List<clsMachine>();

            lstMachines = clsMachine.getExtruderMachineList();
            lstMachinesForProductionOrder = clsMachine.getExtruderMachineList();

            for (int i = 0; i < lstMachinesForProductionOrder.Count; i++)
            {
                lstToolStripMenues2.Add(new ToolStripMenuItem());
                lstToolStripMenues2[i].Image = global::BPS.Properties.Resources.server;
                lstToolStripMenues2[i].Name = lstMachines[i].Extruder.name + "ToolStripMenuItem1";
                lstToolStripMenues2[i].Size = new System.Drawing.Size(109, 22);
                lstToolStripMenues2[i].Text = lstMachines[i].Extruder.name;
                lstToolStripMenues2[i].Click += new System.EventHandler(loadExtrusionList);
                this.tsmExtrusionOrderList.DropDownItems.Add(lstToolStripMenues2[i]);

                lstToolStripMenues3.Add(new ToolStripMenuItem());
                lstToolStripMenues3[i].Image = global::BPS.Properties.Resources.server;
                lstToolStripMenues3[i].Name = lstMachines[i].Extruder.name + "ToolStripMenuItem2";
                lstToolStripMenues3[i].Size = new System.Drawing.Size(109, 22);
                lstToolStripMenues3[i].Text = lstMachines[i].Extruder.name;
                lstToolStripMenues3[i].Click += new System.EventHandler(loadProductionReport);
                lstToolStripMenues3[i].Tag = lstMachines[i].codsec;
                this.tsmProductionReports.DropDownItems.Add(lstToolStripMenues3[i]);

                lstToolStripMenues4.Add(new ToolStripMenuItem());
                lstToolStripMenues4[i].Image = global::BPS.Properties.Resources.server;
                lstToolStripMenues4[i].Name = lstMachines[i].Extruder.name + "ToolStripMenuItem3";
                lstToolStripMenues4[i].Size = new System.Drawing.Size(109, 22);
                lstToolStripMenues4[i].Text = lstMachines[i].Extruder.name;
                lstToolStripMenues4[i].Click += new System.EventHandler(loadProductionReportByDecrease);
                lstToolStripMenues4[i].Tag = lstMachines[i].codsec;
                this.tsmDecreaseReports.DropDownItems.Add(lstToolStripMenues4[i]);

                lstToolStripMenues5.Add(new ToolStripMenuItem());
                lstToolStripMenues5[i].Image = global::BPS.Properties.Resources.server;
                lstToolStripMenues5[i].Name = lstMachines[i].Extruder.name + "ToolStripMenuItem4";
                lstToolStripMenues5[i].Size = new System.Drawing.Size(109, 22);
                lstToolStripMenues5[i].Text = lstMachines[i].Extruder.name;
                lstToolStripMenues5[i].Click += new System.EventHandler(loadProductionReportByDeadTime);
                lstToolStripMenues5[i].Tag = lstMachines[i].codsec;
                this.tsmDeadTimeReports.DropDownItems.Add(lstToolStripMenues5[i]);

                lstToolStripMenues6.Add(new ToolStripMenuItem());
                lstToolStripMenues6[i].Image = global::BPS.Properties.Resources.server;
                lstToolStripMenues6[i].Name = lstMachines[i].Extruder.name + "ToolStripMenuItem5";
                lstToolStripMenues6[i].Size = new System.Drawing.Size(109, 22);
                lstToolStripMenues6[i].Text = lstMachines[i].Extruder.name;
                lstToolStripMenues6[i].Click += new System.EventHandler(loadProductionReportByOrder);
                lstToolStripMenues6[i].Tag = lstMachines[i].codsec;
                this.tsmProductionReportByOrder.DropDownItems.Add(lstToolStripMenues6[i]);

                lstToolStripMenues7.Add(new ToolStripMenuItem());
                lstToolStripMenues7[i].Image = global::BPS.Properties.Resources.server;
                lstToolStripMenues7[i].Name = lstMachines[i].Extruder.name + "ToolStripMenuItem2";
                lstToolStripMenues7[i].Size = new System.Drawing.Size(109, 22);
                lstToolStripMenues7[i].Text = lstMachines[i].Extruder.name;
                lstToolStripMenues7[i].Click += new System.EventHandler(loadProductionReport);
                lstToolStripMenues7[i].Tag = lstMachines[i].codsec;
                this.tsmPrioductionReportMainCoil.DropDownItems.Add(lstToolStripMenues7[i]);

                lstToolStripMenues8.Add(new ToolStripMenuItem());
                lstToolStripMenues8[i].Image = global::BPS.Properties.Resources.server;
                lstToolStripMenues8[i].Name = lstMachines[i].Extruder.name + "ToolStripMenuItem2";
                lstToolStripMenues8[i].Size = new System.Drawing.Size(109, 22);
                lstToolStripMenues8[i].Text = lstMachines[i].Extruder.name;
                lstToolStripMenues8[i].Click += new System.EventHandler(loadExtrusionListForDeadTime);
                lstToolStripMenues8[i].Tag = lstMachines[i].codsec;
                this.tsmDeadTime.DropDownItems.Add(lstToolStripMenues8[i]);

                lstToolStripMenues9.Add(new ToolStripMenuItem());
                lstToolStripMenues9[i].Image = global::BPS.Properties.Resources.server;
                lstToolStripMenues9[i].Name = lstMachines[i].Extruder.name + "ToolStripMenuItem8";
                lstToolStripMenues9[i].Size = new System.Drawing.Size(109, 22);
                lstToolStripMenues9[i].Text = lstMachines[i].Extruder.name;
                lstToolStripMenues9[i].Click += new System.EventHandler(loadExtrusionList);
                this.tsmManagementOrder.DropDownItems.Add(lstToolStripMenues9[i]);

                lstToolStripMenues10.Add(new ToolStripMenuItem());
                lstToolStripMenues10[i].Image = global::BPS.Properties.Resources.server;
                lstToolStripMenues10[i].Name = lstMachines[i].Extruder.name + "ToolStripMenuItem9";
                lstToolStripMenues10[i].Size = new System.Drawing.Size(109, 22);
                lstToolStripMenues10[i].Text = lstMachines[i].Extruder.name;
                lstToolStripMenues10[i].Click += new System.EventHandler(loadProductionReportByDeadTime);
                lstToolStripMenues10[i].Tag = lstMachines[i].codsec;
                this.tsmManagementReports.DropDownItems.Add(lstToolStripMenues10[i]);

                lstToolStripMenues11.Add(new ToolStripMenuItem());
                lstToolStripMenues11[i].Image = global::BPS.Properties.Resources.server;
                lstToolStripMenues11[i].Name = lstMachines[i].Extruder.name + "ToolStripMenuItem10";
                lstToolStripMenues11[i].Size = new System.Drawing.Size(109, 22);
                lstToolStripMenues11[i].Text = lstMachines[i].Extruder.name;
                lstToolStripMenues11[i].Click += new System.EventHandler(loadProductionReportAll);
                lstToolStripMenues11[i].Tag = lstMachines[i].codsec;
                this.tsmReportPlanificationAll.DropDownItems.Add(lstToolStripMenues11[i]);

                lstExtruderMachinesForStock.Add(new ToolStripMenuItem());
                lstExtruderMachinesForStock[i].Image = global::BPS.Properties.Resources.server;
                lstExtruderMachinesForStock[i].Name = lstMachines[i].Extruder.name + "ToolStripMenuItem5";
                lstExtruderMachinesForStock[i].Size = new System.Drawing.Size(109, 22);
                lstExtruderMachinesForStock[i].Text = lstMachines[i].Extruder.name;
                lstExtruderMachinesForStock[i].Click += new System.EventHandler(loadMainCoilStock);
                lstExtruderMachinesForStock[i].Tag = lstMachines[i].codsec;
                this.tsmMainCoilStock.DropDownItems.Add(lstExtruderMachinesForStock[i]);

                lstExtruderMachineForComparation.Add(new ToolStripMenuItem());
                lstExtruderMachineForComparation[i].Image = global::BPS.Properties.Resources.chart_line;
                lstExtruderMachineForComparation[i].Name = lstMachines[i].Extruder.name + "ToolStripMenuItem5";
                lstExtruderMachineForComparation[i].Size = new System.Drawing.Size(109, 22);
                lstExtruderMachineForComparation[i].Text = lstMachines[i].Extruder.name;
                lstExtruderMachineForComparation[i].Click += new System.EventHandler(loadMainCoilForComparation);
                lstExtruderMachineForComparation[i].Tag = lstMachines[i].codsec;
                this.tsmOutlineComparer.DropDownItems.Add(lstExtruderMachineForComparation[i]);

                lstExtruderMachineForConsumption.Add(new ToolStripMenuItem());
                lstExtruderMachineForConsumption[i].Image = global::BPS.Properties.Resources.chart_line;
                lstExtruderMachineForConsumption[i].Name = lstMachines[i].Extruder.name + "Consumption";
                lstExtruderMachineForConsumption[i].Size = new System.Drawing.Size(109, 22);
                lstExtruderMachineForConsumption[i].Text = lstMachines[i].Extruder.name;
                lstExtruderMachineForConsumption[i].Click += new System.EventHandler(loadMainCoilForConsumption);
                lstExtruderMachineForConsumption[i].Tag = lstMachines[i].codsec;

                //lstRawMaterialDelivery.Add(new ToolStripMenuItem());
                //lstRawMaterialDelivery[i].Image = global::BPS.Properties.Resources.chart_line;
                //lstRawMaterialDelivery[i].Name = lstMachines[i].Extruder.name + "Delivery";
                //lstRawMaterialDelivery[i].Size = new System.Drawing.Size(109, 22);
                //lstRawMaterialDelivery[i].Text = lstMachines[i].Extruder.name;
                //lstRawMaterialDelivery[i].Click += new System.EventHandler(loadDeliveyRawMaterial);
                //lstRawMaterialDelivery[i].Tag = lstMachines[i].codsec;
                //this.tsmRawMaterialTransferNew.DropDownItems.Add(lstRawMaterialDelivery[i]);
            }

            //List<clsMachine> lstMachinesStockRawMaterial = new List<clsMachine>();

            //lstMachinesStockRawMaterial = clsMachine.getExtruderMachineList();

            //List<System.Windows.Forms.ToolStripMenuItem> bodegaMPToolStripMenuItem = new List<ToolStripMenuItem>();


            //for (int i = 0; i < lstMachinesStockRawMaterial.Count; i++)
            //{
            //    bodegaMPToolStripMenuItem.Add(new ToolStripMenuItem());
            //    bodegaMPToolStripMenuItem[i].Image = global::BPS.Properties.Resources.server;
            //    bodegaMPToolStripMenuItem[i].Name = lstMachines[i].Extruder.name + "ToolStripMenuItem1";
            //    bodegaMPToolStripMenuItem[i].Size = new System.Drawing.Size(109, 22);
            //    bodegaMPToolStripMenuItem[i].Text = lstMachines[i].Extruder.name;
            //    bodegaMPToolStripMenuItem[i].Click += new System.EventHandler(loadStockList);
            //    this.tsmRawMaterialBalanceToProduction.DropDownItems.Add(bodegaMPToolStripMenuItem[i]);
            //}

            List<clsMachine> lstMachinesMPConsumption = new List<clsMachine>();
            List<clsMachine> lstMachinesMPDecrease = new List<clsMachine>();
            List<System.Windows.Forms.ToolStripMenuItem> consumoMPToolStripMenuItem = new List<ToolStripMenuItem>();
            List<System.Windows.Forms.ToolStripMenuItem> despedicioMPToolStripMenuItem = new List<ToolStripMenuItem>();

            lstMachinesMPConsumption = clsMachine.getExtruderMachineList();
            lstMachinesMPDecrease = clsMachine.getExtruderMachineList();


            List<clsMachine> lstCutterMachines = new List<clsMachine>();

            lstCutterMachines = clsMachine.getCutterMachineList();
            List<ToolStripMenuItem> lstToolStripMenuesCutters = new List<ToolStripMenuItem>();
            List<ToolStripMenuItem> lstToolStripMenuesCuttersI = new List<ToolStripMenuItem>();
            List<ToolStripMenuItem> lstToolStripMenuesCuttersII = new List<ToolStripMenuItem>();
            List<ToolStripMenuItem> lstToolStripMenuesCutterssumary = new List<ToolStripMenuItem>();
            List<ToolStripMenuItem> lstToolStripMenuesCutterssumaryI = new List<ToolStripMenuItem>();
            List<ToolStripMenuItem> lstToolStripMenuesCuttersIII = new List<ToolStripMenuItem>();
            List<ToolStripMenuItem> lstToolStripMenuesCuttersIV = new List<ToolStripMenuItem>();


            List<ToolStripMenuItem> lstToolStripMenuesPallets = new List<ToolStripMenuItem>();

            for (int i = 0; i < lstCutterMachines.Count; i++)
            {
                lstToolStripMenuesCutters.Add(new ToolStripMenuItem());
                lstToolStripMenuesCutters[i].Image = global::BPS.Properties.Resources.server;
                lstToolStripMenuesCutters[i].Name = lstCutterMachines[i].Cutter.name + "ToolStripMenuItem1";
                lstToolStripMenuesCutters[i].Size = new System.Drawing.Size(109, 22);
                lstToolStripMenuesCutters[i].Text = lstCutterMachines[i].Cutter.name;
                lstToolStripMenuesCutters[i].Click += new System.EventHandler(loadCuttingOrderListC);
                this.tsmCuttingOrderList.DropDownItems.Add(lstToolStripMenuesCutters[i]);


                lstToolStripMenuesCuttersII.Add(new ToolStripMenuItem());
                lstToolStripMenuesCuttersII[i].Image = global::BPS.Properties.Resources.server;
                lstToolStripMenuesCuttersII[i].Name = lstCutterMachines[i].Cutter.name + "ToolStripMenuItem1";
                lstToolStripMenuesCuttersII[i].Size = new System.Drawing.Size(109, 22);
                lstToolStripMenuesCuttersII[i].Text = lstCutterMachines[i].Cutter.name;
                lstToolStripMenuesCuttersII[i].Click += new System.EventHandler(loadCuttingOrderList);
                this.tsmCuttingOrdersProgram.DropDownItems.Add(lstToolStripMenuesCuttersII[i]);

                lstToolStripMenuesCuttersIV.Add(new ToolStripMenuItem());
                lstToolStripMenuesCuttersIV[i].Image = global::BPS.Properties.Resources.server;
                lstToolStripMenuesCuttersIV[i].Name = lstCutterMachines[i].Cutter.name + "ToolStripMenuItem1";
                lstToolStripMenuesCuttersIV[i].Size = new System.Drawing.Size(109, 22);
                lstToolStripMenuesCuttersIV[i].Text = lstCutterMachines[i].Cutter.name;
                lstToolStripMenuesCuttersIV[i].Click += new System.EventHandler(loadCuttingOrderListTwo);
                this.tsmCuttingOrdersProgramCombinations.DropDownItems.Add(lstToolStripMenuesCuttersIV[i]);

                lstToolStripMenuesCutterssumary.Add(new ToolStripMenuItem());
                lstToolStripMenuesCutterssumary[i].Image = global::BPS.Properties.Resources.server;
                lstToolStripMenuesCutterssumary[i].Name = lstCutterMachines[i].Cutter.name + "ToolStripMenuItem1";
                lstToolStripMenuesCutterssumary[i].Size = new System.Drawing.Size(109, 22);
                lstToolStripMenuesCutterssumary[i].Text = lstCutterMachines[i].Cutter.name;
                lstToolStripMenuesCutterssumary[i].Click += new System.EventHandler(loadCuttingOrderSumary);
                this.tsmCuttingOrderActive.DropDownItems.Add(lstToolStripMenuesCutterssumary[i]);

                lstToolStripMenuesCutterssumaryI.Add(new ToolStripMenuItem());
                lstToolStripMenuesCutterssumaryI[i].Image = global::BPS.Properties.Resources.server;
                lstToolStripMenuesCutterssumaryI[i].Name = lstCutterMachines[i].Cutter.name + "ToolStripMenuItem1";
                lstToolStripMenuesCutterssumaryI[i].Size = new System.Drawing.Size(109, 22);
                lstToolStripMenuesCutterssumaryI[i].Text = lstCutterMachines[i].Cutter.name;
                lstToolStripMenuesCutterssumaryI[i].Click += new System.EventHandler(loadCuttingOrderSumary);
                this.tsmActiveCuttingOrderSummary.DropDownItems.Add(lstToolStripMenuesCutterssumaryI[i]);

                lstToolStripMenuesPallets.Add(new ToolStripMenuItem());
                lstToolStripMenuesPallets[i].Image = global::BPS.Properties.Resources.server;
                lstToolStripMenuesPallets[i].Name = lstCutterMachines[i].Cutter.name + "ToolStripMenuItem1";
                lstToolStripMenuesPallets[i].Size = new System.Drawing.Size(109, 22);
                lstToolStripMenuesPallets[i].Text = lstCutterMachines[i].Cutter.name;
                lstToolStripMenuesPallets[i].Click += new System.EventHandler(loadRegisterPallet);
                this.tsmPalletsByActiveOrder.DropDownItems.Add(lstToolStripMenuesPallets[i]);

            }

            List<clsCoilCellar> lstCoilCellar = clsCoilCellar.getList();
            List<ToolStripMenuItem> lstToolStripMenuesFinishedProductsCellars = new List<ToolStripMenuItem>();

            for (int i = 0; i < lstCoilCellar.Count; i++)
            {
                lstToolStripMenuesFinishedProductsCellars.Add(new ToolStripMenuItem());
                lstToolStripMenuesFinishedProductsCellars[i].Image = global::BPS.Properties.Resources.box1;
                lstToolStripMenuesFinishedProductsCellars[i].Name = lstCoilCellar[i].name + "ToolStripMenuItem1";
                lstToolStripMenuesFinishedProductsCellars[i].Size = new System.Drawing.Size(109, 22);
                lstToolStripMenuesFinishedProductsCellars[i].Text = lstCoilCellar[i].name;
                lstToolStripMenuesFinishedProductsCellars[i].Click += new System.EventHandler(loadPalletCoilCellarList);
                lstToolStripMenuesFinishedProductsCellars[i].Tag = lstCoilCellar[i].codsec;
            }

            validateByUserRole(mnuMain.Items);

            objToolStripItemCollectionPublic = mnuMain.Items;

            tsslUserName.Text = clsGlobal.LoggedUser.firstName + " " + clsGlobal.LoggedUser.lastName;
            if (clsGlobal.DataBaseEngine == "MySql")
                tsslDatabase.Image = global::BPS.Properties.Resources.mysql;
            else
                tsslDatabase.Image = global::BPS.Properties.Resources.sqlserver;

            tsslDatabase.ToolTipText = clsGlobal.server;

            if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
                tsslVersion.Text = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.Major.ToString() + "." +
                    System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.Minor.ToString() + "." +
                    System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.Build.ToString() + "." +
                    System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.Revision.ToString();
            else
                tsslVersion.Text = string.Empty;
            if (clsGlobal.LoggedUser.fkRole == 5 || clsGlobal.LoggedUser.fkRole == 4 || clsGlobal.LoggedUser.fkRole == 7 || clsGlobal.LoggedUser.fkRole == 8)
            {
                tsmAdmin.Visible = false;
                tsmProduction.Visible = false;
                tsmBackload.Visible = false;
                tsmSales.Visible = false;
                tsmCellars.Visible = false;
                tsmCube.Visible = false;
                tsmRawMaterial.Visible = false;
                tsmManagement.Visible = false;
                tsmManagerFull.Visible = false;
                reportesToolStripMenuItem.Visible = false;
            }

            if (clsGlobal.LoggedUser.fkRole == 9)
            {
                //tsmAdmin.Visible = false;
                tsmProduction.Visible = false;
                tsmBackload.Visible = false;
                tsmSales.Visible = false;
                tsmCellars.Visible = false;
                tsmCube.Visible = false;
                tsmRawMaterial.Visible = false;
                tsmManagement.Visible = false;
                tsmManagerFull.Visible = false;
                reportesToolStripMenuItem.Visible = false;
            }

            if (clsGlobal.LoggedUser.fkRole == 6)
            {
                /*Panel pnlShorcuts = clsShortcutsLayout.getMainCoilRegistrationShortCuts(3);
                this.Controls.Add(pnlShorcuts);
                pnlShorcuts.BringToFront();

                for (int i = 0; i < pnlShorcuts.Controls.Count; i++)
                {
                    if (object.ReferenceEquals(pnlShorcuts.Controls[i].GetType(), typeof(System.Windows.Forms.Button)))
                    {
                        switch (pnlShorcuts.Controls[i].Tag.ToString().Split(new char[] { ' ' })[0])
                        {
                            case "mainCoilRegistration":
                                pnlShorcuts.Controls[i].Click += new EventHandler(loadMainCoilFromShortcut);
                                break;
                            default:
                                break;
                        }
                    }
                }*/

                tsmAdmin.Visible = false;
                tsmProduction.Visible = false;
                tsmBackload.Visible = false;
                tsmSales.Visible = false;
                tsmCellars.Visible = false;
                tsmCube.Visible = false;
                tsmRawMaterial.Visible = false;
                tsmManagement.Visible = false;
                tsmManagerFull.Visible = false;
                reportesToolStripMenuItem.Visible = false;
            }
            if (clsGlobal.LoggedUser.fkRole == 2030)
            {
                Panel pnlShorcuts = clsShortcutsLayout.getMainCoilRegistrationShortCuts(4);
                this.Controls.Add(pnlShorcuts);
                pnlShorcuts.BringToFront();

                for (int i = 0; i < pnlShorcuts.Controls.Count; i++)
                {
                    if (object.ReferenceEquals(pnlShorcuts.Controls[i].GetType(), typeof(System.Windows.Forms.Button)))
                    {
                        switch (pnlShorcuts.Controls[i].Tag.ToString().Split(new char[] { ' ' })[0])
                        {
                            case "mainCoilRegistration":
                                pnlShorcuts.Controls[i].Click += new EventHandler(loadMainCoilFromShortcut);
                                break;
                            default:
                                break;
                        }
                    }
                }

                mnuMain.Visible = false;
                tsmRequests.Visible = false;
                tsmAdmin.Visible = false;
                tsmSales.Visible = false;
                tsmPlanification.Visible = false;
                tsmMainCoil.Visible = false;
                tsmMainCoilStockBT.Visible = false;
                tsmFormulation.Visible = false;
                tsmDeadTime.Visible = false;
                tsmReports.Visible = false;
                tsmEfficiencyCut.Visible = false;
                consumoDeMPToolStripMenuItem.Visible = false;
                silosToolStripMenuItem.Visible = false;
                tsmExtrusionOrderNew.Visible = false;
                tsmMainCoilQuality.Visible = false;
                tsmProgramming.Visible = false;
                tsmCutting.Visible = false;
                tsmReprocess.Visible = false;
                tsmShippingObject.Visible = false;
                tsmMetallizedObject.Visible = false;
                tsmSeparatorPlanification.Visible = false;
                tsmSeparatorEstrusion.Visible = false;
                tsmSeparatorMainCoilQuality.Visible = false;
                tsmSeparatorProgramming.Visible = false;
                tsmSeparatorShippingObject.Visible = false;
                toolStripSeparator3.Visible = false;
                tsmSeparatorMainCoil.Visible = false;
                toolStripSeparator4.Visible = false;
                tsmSeparatorFormulation.Visible = false;
                tsmSeparatorDeadTime.Visible = false;
                tsmSeparatorReports.Visible = false;
                tsmBackload.Visible = false;
                tsmCellars.Visible = false;
                tsmCube.Visible = false;
                tsmRawMaterial.Visible = false;
                tsmManagement.Visible = false;
                tsmManagerFull.Visible = false;
                reportesToolStripMenuItem.Visible = false;
            }
            if (clsGlobal.LoggedUser.fkRole == 12)
            {
                Panel pnlShorcuts = clsShortcutsLayout.getCuttingRegistrationShortCuts();
                this.Controls.Add(pnlShorcuts);
                pnlShorcuts.BringToFront();

                for (int i = 0; i < pnlShorcuts.Controls.Count; i++)
                {
                    if (object.ReferenceEquals(pnlShorcuts.Controls[i].GetType(), typeof(System.Windows.Forms.Button)))
                    {
                        switch (pnlShorcuts.Controls[i].Tag.ToString().Split(new char[] { ' ' })[0])
                        {
                            case "coilRegistration":
                                pnlShorcuts.Controls[i].Click += new EventHandler(loadCuttingOrderSumaryFromShortcut);
                                break;
                            case "palletRegistration":
                                pnlShorcuts.Controls[i].Click += new EventHandler(loadRegisterPalletFromShortcut);
                                break;
                            default:
                                break;
                        }
                    }
                }

                //mnuMain.Visible = false;
            }
            if (clsGlobal.LoggedUser.fkRole == 2)
                tsmBackload.Visible = false;
                
        }

        public void validateByUserRole(ToolStripItemCollection objToolStripItemCollection)
        {
            for (int i = 0; i < objToolStripItemCollection.Count; i++)
            {
                if (object.ReferenceEquals(objToolStripItemCollection[i].GetType(), typeof(System.Windows.Forms.ToolStripMenuItem)))
                {
                    clsSystemMenuByUserRole objSystemMenuByUserRole = clsSystemMenuByUserRole.getDetailByUserRoleAndControlName(clsGlobal.LoggedUser.fkRole, objToolStripItemCollection[i].Name);
                    if (objSystemMenuByUserRole.codsec > 0)
                    {
                        objToolStripItemCollection[i].Enabled = objSystemMenuByUserRole.enabled;
                        objToolStripItemCollection[i].Visible = objSystemMenuByUserRole.visible;
                    }
                    validateByUserRole(((System.Windows.Forms.ToolStripDropDownItem)(((ToolStripMenuItem)objToolStripItemCollection[i]))).DropDownItems);
                }
            }
        }

        public string getMenuTreeString(ToolStripItemCollection objToolStripItemCollection, int menuLevel)
        {
            string strMenuTree = "";

            for (int i = 0; i < objToolStripItemCollection.Count; i++)
            {
                if (object.ReferenceEquals(objToolStripItemCollection[i].GetType(), typeof(System.Windows.Forms.ToolStripMenuItem)))
                {
                    for (int j = 1; j < menuLevel; j++)
                        strMenuTree += "\t";

                    strMenuTree += objToolStripItemCollection[i].Name + "  -  " + objToolStripItemCollection[i].Text + "\n";
                    strMenuTree += getMenuTreeString(((System.Windows.Forms.ToolStripDropDownItem)(((ToolStripMenuItem)objToolStripItemCollection[i]))).DropDownItems, menuLevel + 1);
                }
            }

            return strMenuTree;
        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSystemConfig winSystemConfig = new frmSystemConfig();
            winSystemConfig.MdiParent = this;
            winSystemConfig.StartPosition = FormStartPosition.Manual;
            winSystemConfig.Show();
        }

        private void testToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTest winTest = new frmTest();
            winTest.Show();
        }

        private void listadoToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            frmCustomerList winCustomerList = new frmCustomerList();
            winCustomerList.MdiParent = this;
            winCustomerList.StartPosition = FormStartPosition.Manual;
            winCustomerList.Show();
        }

        private void listadoToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            frmProviderList winProviderList = new frmProviderList();
            winProviderList.MdiParent = this;
            winProviderList.StartPosition = FormStartPosition.Manual;
            winProviderList.Show();
        }

        private void nuevoToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmCustomerForm winCustomerForm = new frmCustomerForm();
            winCustomerForm.MdiParent = this;
            winCustomerForm.StartPosition = FormStartPosition.Manual;
            winCustomerForm.Show();
        }

        private void nuevoToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmProviderForm winProviderForm = new frmProviderForm();
            winProviderForm.MdiParent = this;
            winProviderForm.StartPosition = FormStartPosition.Manual;
            winProviderForm.Show();
        }

        private void listadoToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            frmBoppFilmList winBoppFilmList = new frmBoppFilmList();
            winBoppFilmList.MdiParent = this;
            winBoppFilmList.StartPosition = FormStartPosition.Manual;
            winBoppFilmList.Show();
        }

        private void nuevoToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            frmBoppFilmForm winBoppFilmForm = new frmBoppFilmForm();
            winBoppFilmForm.MdiParent = this;
            winBoppFilmForm.StartPosition = FormStartPosition.Manual;
            winBoppFilmForm.Show();
        }

        private void nuevoToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            frmCoatingFilmForm winCoatingFilmForm = new frmCoatingFilmForm();
            winCoatingFilmForm.MdiParent = this;
            winCoatingFilmForm.StartPosition = FormStartPosition.Manual;
            winCoatingFilmForm.Show();
        }

        private void listadoToolStripMenuItem14_Click(object sender, EventArgs e)
        {
            frmCoatingFilmList winCoatingFilmList = new frmCoatingFilmList();
            winCoatingFilmList.MdiParent = this;
            winCoatingFilmList.StartPosition = FormStartPosition.Manual;
            winCoatingFilmList.Show();
        }

        private void listadoToolStripMenuItem13_Click(object sender, EventArgs e)
        {
            frmCastFilmList winCastFilmList = new frmCastFilmList();
            winCastFilmList.MdiParent = this;
            winCastFilmList.StartPosition = FormStartPosition.Manual;
            winCastFilmList.Show();
        }

        private void nuevoToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            frmCastFilmForm winCastFilmForm = new frmCastFilmForm();
            winCastFilmForm.MdiParent = this;
            winCastFilmForm.StartPosition = FormStartPosition.Manual;
            winCastFilmForm.Show();
        }

        private void listadoToolStripMenuItem15_Click(object sender, EventArgs e)
        {
            frmSalesOrderList winSalesOrderList = new frmSalesOrderList();
            winSalesOrderList.MdiParent = this;
            winSalesOrderList.StartPosition = FormStartPosition.Manual;
            winSalesOrderList.Show();
        }

        private void películaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductsForm winProductForm = new frmProductsForm();
            winProductForm.MdiParent = this;
            winProductForm.StartPosition = FormStartPosition.Manual;
            winProductForm.Show();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductList winProductList = new frmProductList();
            winProductList.MdiParent = this;
            winProductList.StartPosition = FormStartPosition.Manual;
            winProductList.Show();
        }

        private void nuevaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmSalesOrderForm winSalesOrderForm = new frmSalesOrderForm();
            winSalesOrderForm.MdiParent = this;
            winSalesOrderForm.StartPosition = FormStartPosition.Manual;
            winSalesOrderForm.Show();
        }

        private void nuevaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmPurchaseOrder winPurchaseOrder = new frmPurchaseOrder();
            winPurchaseOrder.MdiParent = this;
            winPurchaseOrder.StartPosition = FormStartPosition.Manual;
            winPurchaseOrder.Show();
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInternationalSalesOrderForm winInternationalSalesOrderForm = new frmInternationalSalesOrderForm();
            winInternationalSalesOrderForm.MdiParent = this;
            winInternationalSalesOrderForm.StartPosition = FormStartPosition.Manual;
            winInternationalSalesOrderForm.Show();
        }

        private void listadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmInternationalSalesOrderList winInternationalSalesOrderList = new frmInternationalSalesOrderList();
            winInternationalSalesOrderList.MdiParent = this;
            winInternationalSalesOrderList.StartPosition = FormStartPosition.Manual;
            winInternationalSalesOrderList.Show();
        }

        private void nuevaToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmFormulationsBoppForm winFormulationBoppForm = new frmFormulationsBoppForm();
            winFormulationBoppForm.MdiParent = this;
            winFormulationBoppForm.StartPosition = FormStartPosition.Manual;
            winFormulationBoppForm.Show();
        }

        private void nuevaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmProductionOrderForm winProductionOrderForm = new frmProductionOrderForm();
            winProductionOrderForm.MdiParent = this;
            winProductionOrderForm.StartPosition = FormStartPosition.Manual;
            winProductionOrderForm.Show();
        }

        private void listadoToolStripMenuItem16_Click(object sender, EventArgs e)
        {
            frmFilmProductionPlan winMachineCalendar = new frmFilmProductionPlan();
            winMachineCalendar.MdiParent = this;
            winMachineCalendar.StartPosition = FormStartPosition.Manual;
            winMachineCalendar.Show();
        }

        private void listadoToolStripMenuItem17_Click(object sender, EventArgs e)
        {
            frmFormulationsList winFormulationsList = new frmFormulationsList();
            winFormulationsList.MdiParent = this;
            winFormulationsList.StartPosition = FormStartPosition.CenterScreen;
            winFormulationsList.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmProductionPlanReport winProductionPlanReport = new frmProductionPlanReport();
            winProductionPlanReport.MdiParent = this;
            winProductionPlanReport.StartPosition = FormStartPosition.Manual;
            winProductionPlanReport.Show();
        }

        private void nuevoToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            frmRawMaterialReception winRawMaterialReception = new frmRawMaterialReception();
            winRawMaterialReception.MdiParent = this;
            winRawMaterialReception.StartPosition = FormStartPosition.Manual;
            winRawMaterialReception.Show();
        }

        private void loadCuttingOrderSumary(object sender, EventArgs e)
        {
            List<clsMachine> lstMachines = new List<clsMachine>();
            int machineSelected = 0;

            lstMachines = clsMachine.getCutterMachineList();

            List<System.Windows.Forms.ToolStripMenuItem> lstToolStripMenues = new List<ToolStripMenuItem>();

            for (int i = 0; i < lstMachines.Count; i++)
            {
                if (((ToolStripMenuItem)sender).Text == lstMachines[i].Cutter.name)
                {
                    machineSelected = lstMachines[i].codsec;
                }
            }

            int cuttingOrderCodsec = clsCuttingOrder.getSimplifiedActiveOrderByMachine(machineSelected).codsec;

            if (cuttingOrderCodsec > 0)
            {
                frmCuttingOrderSummary winCuttingOrderSumary = new frmCuttingOrderSummary(cuttingOrderCodsec);
                winCuttingOrderSumary.MdiParent = this;
                winCuttingOrderSumary.StartPosition = FormStartPosition.Manual;
                winCuttingOrderSumary.Show();
            }
            else
            {
                MessageBox.Show("No existe ninguna orden de corte asignada a esta cortadora", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void loadRegisterPallet(object sender, EventArgs e)
        {
            List<clsMachine> lstMachines = new List<clsMachine>();
            int machineSelected = 0;

            lstMachines = clsMachine.getCutterMachineList();

            List<System.Windows.Forms.ToolStripMenuItem> lstToolStripMenues = new List<ToolStripMenuItem>();

            for (int i = 0; i < lstMachines.Count; i++)
            {
                if (((ToolStripMenuItem)sender).Text == lstMachines[i].Cutter.name)
                {
                    machineSelected = lstMachines[i].codsec;
                }
            }

            int cuttingOrderCodsec = clsCuttingOrder.getActiveOrderByMachine(machineSelected).codsec;

            if (cuttingOrderCodsec > 0)
            {
                frmPalletsRegistration winPalletsByCuttingOrder = new frmPalletsRegistration(cuttingOrderCodsec, "cuttingOrder");
                winPalletsByCuttingOrder.MdiParent = this;
                winPalletsByCuttingOrder.StartPosition = FormStartPosition.Manual;
                winPalletsByCuttingOrder.Show();
            }
            else
            {
                MessageBox.Show("No existe ninguna orden de corte asignada a esta cortadora", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void loadCuttingOrderSumaryFromShortcut(object sender, EventArgs e)
        {

            int cuttingOrderCodsec = clsCuttingOrder.getActiveOrderByMachine(Convert.ToInt32(((Button)sender).Tag.ToString().Split(new char[] { ' ' })[1])).codsec;

            if (cuttingOrderCodsec > 0)
            {
                frmCuttingOrderSummary winCuttingOrderSumary = new frmCuttingOrderSummary(cuttingOrderCodsec);
                winCuttingOrderSumary.MdiParent = this;
                winCuttingOrderSumary.StartPosition = FormStartPosition.Manual;
                winCuttingOrderSumary.Show();
            }
            else
            {
                MessageBox.Show("No existe ninguna orden de corte asignada a esta cortadora", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void loadRegisterPalletFromShortcut(object sender, EventArgs e)
        {

            int cuttingOrderCodsec = clsCuttingOrder.getActiveOrderByMachine(Convert.ToInt32(((Button)sender).Tag.ToString().Split(new char[] { ' ' })[1])).codsec;

            if (cuttingOrderCodsec > 0)
            {
                frmPalletsRegistration winPalletsByCuttingOrder = new frmPalletsRegistration(cuttingOrderCodsec, "cuttingOrder");
                winPalletsByCuttingOrder.MdiParent = this;
                winPalletsByCuttingOrder.StartPosition = FormStartPosition.Manual;
                winPalletsByCuttingOrder.Show();
            }
            else
            {
                MessageBox.Show("No existe ninguna orden de corte asignada a esta cortadora", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void loadCuttingOrderListG(object sender, EventArgs e)
        {
            
            frmCuttingOrderList winCuttingOrderList = new frmCuttingOrderList(3025, false);
            winCuttingOrderList.MdiParent = this;
            winCuttingOrderList.StartPosition = FormStartPosition.Manual;
            winCuttingOrderList.Show();
        }

        private void loadCuttingOrderListA(object sender, EventArgs e)
        {

            frmCuttingOrderList winCuttingOrderList = new frmCuttingOrderList(3026, false);
            winCuttingOrderList.MdiParent = this;
            winCuttingOrderList.StartPosition = FormStartPosition.Manual;
            winCuttingOrderList.Show();
        }

        private void loadCuttingOrderListT(object sender, EventArgs e)
        {

            frmCuttingOrderList winCuttingOrderList = new frmCuttingOrderList(3027, false);
            winCuttingOrderList.MdiParent = this;
            winCuttingOrderList.StartPosition = FormStartPosition.Manual;
            winCuttingOrderList.Show();
        }

        private void loadCuttingOrderList(object sender, EventArgs e)
        {
            List<clsMachine> lstMachines = new List<clsMachine>();
            int machineSelected = 0;

            lstMachines = clsMachine.getCutterMachineList();

            List<System.Windows.Forms.ToolStripMenuItem> lstToolStripMenues = new List<ToolStripMenuItem>();

            for (int i = 0; i < lstMachines.Count; i++)
            {
                if (((ToolStripMenuItem)sender).Text == lstMachines[i].Cutter.name)
                {
                    machineSelected = lstMachines[i].codsec;
                }
            }
            frmCuttingOrderList winCuttingOrderList = new frmCuttingOrderList(machineSelected, false);
            winCuttingOrderList.MdiParent = this;
            winCuttingOrderList.StartPosition = FormStartPosition.Manual;
            winCuttingOrderList.Show();
        }

        private void loadCuttingOrderListC(object sender, EventArgs e)
        {
            List<clsMachine> lstMachines = new List<clsMachine>();
            int machineSelected = 0;

            lstMachines = clsMachine.getCutterMachineList();

            List<System.Windows.Forms.ToolStripMenuItem> lstToolStripMenues = new List<ToolStripMenuItem>();

            for (int i = 0; i < lstMachines.Count; i++)
            {
                if (((ToolStripMenuItem)sender).Text == lstMachines[i].Cutter.name)
                {
                    machineSelected = lstMachines[i].codsec;
                }
            }
            frmCuttingOrderList winCuttingOrderList = new frmCuttingOrderList(machineSelected, true);
            winCuttingOrderList.MdiParent = this;
            winCuttingOrderList.StartPosition = FormStartPosition.Manual;
            winCuttingOrderList.Show();
        }

        private void loadCuttingOrderListTwo(object sender, EventArgs e)
        {
            List<clsMachine> lstMachines = new List<clsMachine>();
            int machineSelected = 0;

            lstMachines = clsMachine.getCutterMachineList();

            List<System.Windows.Forms.ToolStripMenuItem> lstToolStripMenues = new List<ToolStripMenuItem>();

            for (int i = 0; i < lstMachines.Count; i++)
            {
                if (((ToolStripMenuItem)sender).Text == lstMachines[i].Cutter.name)
                    machineSelected = lstMachines[i].codsec;
            }

            frmCuttinOrderPosition winCuttingOrderList = new frmCuttinOrderPosition(machineSelected);
            winCuttingOrderList.MdiParent = this;
            winCuttingOrderList.StartPosition = FormStartPosition.Manual;
            winCuttingOrderList.Show();
        }



        private void loadCuttingOrderListReport(object sender, EventArgs e)
        {
            List<clsMachine> lstMachines = new List<clsMachine>();
            int machineSelected = 0;

            lstMachines = clsMachine.getCutterMachineList();

            List<System.Windows.Forms.ToolStripMenuItem> lstToolStripMenues = new List<ToolStripMenuItem>();

            for (int i = 0; i < lstMachines.Count; i++)
            {
                if (((ToolStripMenuItem)sender).Text == lstMachines[i].Cutter.name)
                {
                    machineSelected = lstMachines[i].codsec;
                }
            }
            frmCuttingReport winCuttingReport = new frmCuttingReport(machineSelected);
            winCuttingReport.MdiParent = this;
            winCuttingReport.StartPosition = FormStartPosition.Manual;
            winCuttingReport.Show();
        }

        private void loadStockList(object sender, EventArgs e)
        {
            List<clsMachine> lstMachines = new List<clsMachine>();
            int machineSelected = 0;

            lstMachines = clsMachine.getExtruderMachineList();

            List<System.Windows.Forms.ToolStripMenuItem> lstToolStripMenues = new List<ToolStripMenuItem>();

            for (int i = 0; i < lstMachines.Count; i++)
            {
                if (((ToolStripMenuItem)sender).Text == lstMachines[i].Extruder.name)
                {
                    machineSelected = lstMachines[i].codsec;
                }
            }
            frmRawMaterialProductionCellar winRawMaterialProductionCellar = new frmRawMaterialProductionCellar(machineSelected);
            winRawMaterialProductionCellar.MdiParent = this;
            winRawMaterialProductionCellar.StartPosition = FormStartPosition.Manual;
            winRawMaterialProductionCellar.Show();
        }

        private void loadMainCoilForm(object sender, EventArgs e)
        {
            List<clsMachine> lstMachines = new List<clsMachine>();
            int machineSelected = 0;

            lstMachines = clsMachine.getExtruderMachineList();

            List<System.Windows.Forms.ToolStripMenuItem> lstToolStripMenues = new List<ToolStripMenuItem>();

            for (int i = 0; i < lstMachines.Count; i++)
            {
                if (((ToolStripMenuItem)sender).Text == lstMachines[i].Extruder.name)
                {
                    machineSelected = lstMachines[i].codsec;
                }
            }
            frmMainCoil winMainCoil = new frmMainCoil(machineSelected);
            winMainCoil.MdiParent = this;
            winMainCoil.StartPosition = FormStartPosition.Manual;
            winMainCoil.Show();
        }

        private void loadMainCoilFromShortcut(object sender, EventArgs e)
        {
            frmMainCoilRegister winMainCoilRegister = new frmMainCoilRegister(Convert.ToInt32(((Button)sender).Tag.ToString().Split(new char[] { ' ' })[1]));
            winMainCoilRegister.StartPosition = FormStartPosition.Manual;
            winMainCoilRegister.MdiParent = this;
            winMainCoilRegister.Show();
        }

        private void loadMainCoilRegistrationC(object sender, EventArgs e)
        {
            frmMainCoilRegister winMainCoilRegister = new frmMainCoilRegister(11);
            winMainCoilRegister.StartPosition = FormStartPosition.Manual;
            winMainCoilRegister.MdiParent = this;
            winMainCoilRegister.Show();
        }

        private void loadMainCoilRegistration(object sender, EventArgs e)
        {
            frmMainCoilRegister winMainCoilRegister = new frmMainCoilRegister(3024);
            winMainCoilRegister.StartPosition = FormStartPosition.Manual;
            winMainCoilRegister.MdiParent = this;
            winMainCoilRegister.Show();
        }

        private void loadExtrusionList(object sender, EventArgs e)
        {
            List<clsMachine> lstMachines = new List<clsMachine>();
            int machineSelected = 0;

            lstMachines = clsMachine.getExtruderMachineList();

            List<System.Windows.Forms.ToolStripMenuItem> lstToolStripMenues = new List<ToolStripMenuItem>();

            for (int i = 0; i < lstMachines.Count; i++)
            {
                if (((ToolStripMenuItem)sender).Text == lstMachines[i].Extruder.name)
                {
                    machineSelected = lstMachines[i].codsec;
                    break;
                }
            }
            frmProductionOrdenList winProductionOrderList = new frmProductionOrdenList(machineSelected);
            winProductionOrderList.MdiParent = this;
            winProductionOrderList.StartPosition = FormStartPosition.Manual;
            winProductionOrderList.Show();
        }

        private void loadExtrusionListC(object sender, EventArgs e)
        {

            frmProductionOrdenList winProductionOrderList = new frmProductionOrdenList(11);
            winProductionOrderList.MdiParent = this;
            winProductionOrderList.StartPosition = FormStartPosition.Manual;
            winProductionOrderList.Show();
        }

        private void loadExtrusionListPL(object sender, EventArgs e)
        {

            frmProductionOrdenList winProductionOrderList = new frmProductionOrdenList(3024);
            winProductionOrderList.MdiParent = this;
            winProductionOrderList.StartPosition = FormStartPosition.Manual;
            winProductionOrderList.Show();
        }

        private void loadExtrusionListForDeadTime(object sender, EventArgs e)
        {
            List<clsMachine> lstMachines = new List<clsMachine>();
            int machineSelected = 0;
            lstMachines = clsMachine.getExtruderMachineList();
            List<System.Windows.Forms.ToolStripMenuItem> lstToolStripMenues = new List<ToolStripMenuItem>();
            for (int i = 0; i < lstMachines.Count; i++)
            {
                if (((ToolStripMenuItem)sender).Text == lstMachines[i].Extruder.name)
                {
                    machineSelected = lstMachines[i].codsec;
                    break;
                }
            }
            frmDeadTimeByFilmProductionPlan winProductionOrderList = new frmDeadTimeByFilmProductionPlan(machineSelected);
            winProductionOrderList.MdiParent = this;
            winProductionOrderList.StartPosition = FormStartPosition.CenterScreen;
            winProductionOrderList.Show();
        }
        private void loadStockByMachine(object sender, EventArgs e)
        {
            frmCoilsByCoilCellar objCoilsByCoilCellar = new frmCoilsByCoilCellar(Convert.ToInt32(((ToolStripMenuItem)sender).Tag));
            objCoilsByCoilCellar.StartPosition = FormStartPosition.Manual;
            objCoilsByCoilCellar.MdiParent = this;
            objCoilsByCoilCellar.Show();
        }

        private void loadConsumptionList(object sender, EventArgs e)
        {
            List<clsMachine> lstMachines = new List<clsMachine>();
            int machineSelected = 0;

            lstMachines = clsMachine.getExtruderMachineList();

            List<System.Windows.Forms.ToolStripMenuItem> lstToolStripMenues = new List<ToolStripMenuItem>();

            for (int i = 0; i < lstMachines.Count; i++)
            {
                if (((ToolStripMenuItem)sender).Text == lstMachines[i].Extruder.name)
                {
                    machineSelected = lstMachines[i].codsec;
                }
            }
            frmRawMaterialConsumptionByExtruder winRawMaterialConsumptionByExtruder = new frmRawMaterialConsumptionByExtruder(machineSelected);
            winRawMaterialConsumptionByExtruder.MdiParent = this;
            winRawMaterialConsumptionByExtruder.StartPosition = FormStartPosition.Manual;
            winRawMaterialConsumptionByExtruder.Show();
        }

        private void loadDecreaseList(object sender, EventArgs e)
        {
            List<clsMachine> lstMachines = new List<clsMachine>();
            int machineSelected = 0;

            lstMachines = clsMachine.getExtruderMachineList();

            List<System.Windows.Forms.ToolStripMenuItem> lstToolStripMenues = new List<ToolStripMenuItem>();

            for (int i = 0; i < lstMachines.Count; i++)
            {
                if (((ToolStripMenuItem)sender).Text == lstMachines[i].Extruder.name)
                {
                    machineSelected = lstMachines[i].codsec;
                }
            }
            frmRawMaterialDecreaseByOrderProduction winRawMaterialDecreaseByOrderProduction = new frmRawMaterialDecreaseByOrderProduction(machineSelected);
            winRawMaterialDecreaseByOrderProduction.MdiParent = this;
            winRawMaterialDecreaseByOrderProduction.StartPosition = FormStartPosition.Manual;
            winRawMaterialDecreaseByOrderProduction.Show();
        }

        private void loadCoilByCoilCellarList(object sender, EventArgs e)
        {
            frmCoilsByCoilCellar objCoilsByCoilCellar = new frmCoilsByCoilCellar(Convert.ToInt32(((ToolStripMenuItem)sender).Tag));
            objCoilsByCoilCellar.StartPosition = FormStartPosition.Manual;
            objCoilsByCoilCellar.MdiParent = this;
            objCoilsByCoilCellar.Show();
        }

        private void loadPalletCoilCellarList(object sender, EventArgs e)
        {
            frmCoilPalletsCellar winCoilPalletsCellar = new frmCoilPalletsCellar(Convert.ToInt32(((ToolStripMenuItem)sender).Tag));
            winCoilPalletsCellar.StartPosition = FormStartPosition.Manual;
            winCoilPalletsCellar.MdiParent = this;
            winCoilPalletsCellar.Show();
        }

        private void loadProductionReport(object sender, EventArgs e)
        {
            frmProductionReport winProductionReport = new frmProductionReport(Convert.ToInt32(((ToolStripMenuItem)sender).Tag));
            winProductionReport.StartPosition = FormStartPosition.Manual;
            winProductionReport.MdiParent = this;
            winProductionReport.Show();
        }

        private void loadProductionReportByDecrease(object sender, EventArgs e)
        {
            frmProductionReportByDecrease winProductionReportByDecrease = new frmProductionReportByDecrease(Convert.ToInt32(((ToolStripMenuItem)sender).Tag));
            winProductionReportByDecrease.StartPosition = FormStartPosition.Manual;
            winProductionReportByDecrease.MdiParent = this;
            winProductionReportByDecrease.Show();
        }

        private void loadProductionReportByDeadTime(object sender, EventArgs e)
        {
            frmProductionReportByDeadTime winProductionReportByDeadTime = new frmProductionReportByDeadTime(Convert.ToInt32(((ToolStripMenuItem)sender).Tag));
            winProductionReportByDeadTime.StartPosition = FormStartPosition.Manual;
            winProductionReportByDeadTime.MdiParent = this;
            winProductionReportByDeadTime.Show();
        }

        private void loadProductionReportAll(object sender, EventArgs e)
        {
            List<clsMachine> lstMachine = new List<clsMachine>();
            string machine = string.Empty;

            lstMachine = clsMachine.getExtruderMachineList();

            for (int i = 0; i < lstMachine.Count; i++)
            {
                if (lstMachine[i].fkExtruder == Convert.ToInt32(((ToolStripMenuItem)sender).Tag))
                {
                    machine = lstMachine[i].Extruder.name;
                    break;
                }
            }

            BPS.Reporting.ProductionReports.SummaryExtruder.frmSummaryExtruder winProduction = new BPS.Reporting.ProductionReports.SummaryExtruder.frmSummaryExtruder(machine, clsGlobal.password, Convert.ToInt32(((ToolStripMenuItem)sender).Tag));
            winProduction.StartPosition = FormStartPosition.Manual;
            winProduction.MdiParent = this;
            winProduction.Show();
        }

        private void loadProductionReportByOrder(object sender, EventArgs e)
        {
            frmProductionReportByOrder winProductionReportByOrder = new frmProductionReportByOrder(Convert.ToInt32(((ToolStripMenuItem)sender).Tag));
            winProductionReportByOrder.StartPosition = FormStartPosition.Manual;
            winProductionReportByOrder.MdiParent = this;
            winProductionReportByOrder.Show();
        }

        private void loadMainCoilStock(object sender, EventArgs e)
        {
            frmMainCoilStock winMainCoilStock = new frmMainCoilStock(Convert.ToInt32(((ToolStripMenuItem)sender).Tag));
            winMainCoilStock.StartPosition = FormStartPosition.Manual;
            winMainCoilStock.MdiParent = this;
            winMainCoilStock.Show();
        }

        private void loadMainCoilStockPL(object sender, EventArgs e)
        {
            frmMainCoilStock winMainCoilStock = new frmMainCoilStock(3024);
            winMainCoilStock.StartPosition = FormStartPosition.Manual;
            winMainCoilStock.MdiParent = this;
            winMainCoilStock.Show();
        }

        private void HistorialDeRack(object sender, EventArgs e)
        {
            frmRackHistory winMainCoilStock = new frmRackHistory();
            winMainCoilStock.StartPosition = FormStartPosition.Manual;
            winMainCoilStock.MdiParent = this;
            winMainCoilStock.Show();
        }

        private void loadMainCoilStockC(object sender, EventArgs e)
        {
            frmMainCoilStock winMainCoilStock = new frmMainCoilStock(11);
            winMainCoilStock.StartPosition = FormStartPosition.Manual;
            winMainCoilStock.MdiParent = this;
            winMainCoilStock.Show();
        }

        private void loadMainCoilMetalStockC(object sender, EventArgs e)
        {
            frmMainCoilMetalStock winMainCoilStock = new frmMainCoilMetalStock(3);
            winMainCoilStock.StartPosition = FormStartPosition.Manual;
            winMainCoilStock.MdiParent = this;
            winMainCoilStock.Show();
        }

        private void loadMainCoilMetalStock(object sender, EventArgs e)
        {
            frmMainCoilMetalStock winMainCoilStock = new frmMainCoilMetalStock(3);
            winMainCoilStock.StartPosition = FormStartPosition.Manual;
            winMainCoilStock.MdiParent = this;
            winMainCoilStock.Show();
        }

        private void loadMainCoilMetalStockPL(object sender, EventArgs e)
        {
            frmMainCoilMetalStock winMainCoilStock = new frmMainCoilMetalStock(4);
            winMainCoilStock.StartPosition = FormStartPosition.Manual;
            winMainCoilStock.MdiParent = this;
            winMainCoilStock.Show();
        }

        private void loadMainCoilForComparation(object sender, EventArgs e)
        {
            frmMainCoilOutlineComparer winMainCoilOutlineComparer = new frmMainCoilOutlineComparer(Convert.ToInt32(((ToolStripMenuItem)sender).Tag));
            winMainCoilOutlineComparer.MdiParent = this;
            winMainCoilOutlineComparer.StartPosition = FormStartPosition.Manual;
            winMainCoilOutlineComparer.Show();
        }

        private void loadMainCoilForConsumption(object sender, EventArgs e)
        {
            frmRawMaterialConsumptionByExtruder winRawMaterialConsumptionByExtruder = new frmRawMaterialConsumptionByExtruder(Convert.ToInt32(((ToolStripMenuItem)sender).Tag));
            winRawMaterialConsumptionByExtruder.MdiParent = this;
            winRawMaterialConsumptionByExtruder.StartPosition = FormStartPosition.Manual;
            winRawMaterialConsumptionByExtruder.Show();
        }

        private void ordenesDeCorteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //frmCuttingOrder winCuttingOrder = new frmCuttingOrder();
            //winCuttingOrder.MdiParent = this;
            //winCuttingOrder.StartPosition = FormStartPosition.Manual;
            //winCuttingOrder.WindowState = FormWindowState.Maximized;
            //winCuttingOrder.Show();

            frmCuttingOrderMultiple winCuttingOrderMultiple = new frmCuttingOrderMultiple();
            winCuttingOrderMultiple.MdiParent = this;
            winCuttingOrderMultiple.StartPosition = FormStartPosition.Manual;
            winCuttingOrderMultiple.WindowState = FormWindowState.Maximized;
            winCuttingOrderMultiple.Show();
        }

        private void pesosPorCentímeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBoppWeigthParameter winBoppWeigthParameter = new frmBoppWeigthParameter();
            winBoppWeigthParameter.MdiParent = this;
            winBoppWeigthParameter.StartPosition = FormStartPosition.Manual;
            winBoppWeigthParameter.Show();
        }

        private void listadoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmPurchaseOrderList winPurchaseOrderList = new frmPurchaseOrderList();
            winPurchaseOrderList.MdiParent = this;
            winPurchaseOrderList.StartPosition = FormStartPosition.Manual;
            winPurchaseOrderList.Show();
        }

        private void loadDeliveyRawMaterial(object sender, EventArgs e)
        {
            frmDeliverRawMaterial winDeliverRawMaterial = new frmDeliverRawMaterial(Convert.ToInt32(((ToolStripMenuItem)sender).Tag));
            winDeliverRawMaterial.MdiParent = this;
            winDeliverRawMaterial.StartPosition = FormStartPosition.Manual;
            winDeliverRawMaterial.Show();
        }

        private void listadoToolStripMenuItem21_Click(object sender, EventArgs e)
        {
            frmRawMaterialReceptionList winRawMaterialReceptionList = new frmRawMaterialReceptionList();
            winRawMaterialReceptionList.MdiParent = this;
            winRawMaterialReceptionList.StartPosition = FormStartPosition.Manual;
            winRawMaterialReceptionList.Show();
        }

        private void listadoToolStripMenuItem22_Click(object sender, EventArgs e)
        {

            frmTransferRawMaterial winTransferRawMaterial = new frmTransferRawMaterial();
            winTransferRawMaterial.MdiParent = this;
            winTransferRawMaterial.StartPosition = FormStartPosition.Manual;
            winTransferRawMaterial.Show();
        }

        private void bodegaMateriaPrimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRawMaterialStock winRawMaterialStock = new frmRawMaterialStock();
            winRawMaterialStock.MdiParent = this;
            winRawMaterialStock.StartPosition = FormStartPosition.Manual;
            winRawMaterialStock.Show();
        }

        private void listadoToolStripMenuItem18_Click(object sender, EventArgs e)
        {
            frmMainCoilListWithDetail winMainCoilListWithDetail = new frmMainCoilListWithDetail();
            winMainCoilListWithDetail.StartPosition = FormStartPosition.Manual;
            winMainCoilListWithDetail.MdiParent = this;
            winMainCoilListWithDetail.Show();
        }

        private void kardexToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmKardex winKardex = new frmKardex();
            winKardex.MdiParent = this;
            winKardex.StartPosition = FormStartPosition.Manual;
            winKardex.Show();
        }

        private void sinOrdenCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSupplyForm winSupplyForm = new frmSupplyForm();
            winSupplyForm.MdiParent = this;
            winSupplyForm.StartPosition = FormStartPosition.Manual;
            winSupplyForm.Show();
        }

        private void porOrdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPalletsRegistration winPalletsByCuttingOrder = new frmPalletsRegistration(0, "salesOrder");
            winPalletsByCuttingOrder.MdiParent = this;
            winPalletsByCuttingOrder.StartPosition = FormStartPosition.Manual;
            winPalletsByCuttingOrder.Show();
        }

        private void palletsStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPalletsRegistration winPalletsByCuttingOrder = new frmPalletsRegistration(0, "stock");
            winPalletsByCuttingOrder.MdiParent = this;
            winPalletsByCuttingOrder.StartPosition = FormStartPosition.Manual;
            winPalletsByCuttingOrder.Show();
        }

        private void traspasoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSupplyTransfer winSupplyTransfer = new frmSupplyTransfer();
            winSupplyTransfer.MdiParent = this;
            winSupplyTransfer.StartPosition = FormStartPosition.Manual;
            winSupplyTransfer.Show();
        }

        private void rebobinadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRewindCoil winRewindCoil = new frmRewindCoil();
            winRewindCoil.MdiParent = this;
            winRewindCoil.StartPosition = FormStartPosition.Manual;
            winRewindCoil.Show();
        }

        private void molinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDropCoil winDropCoil = new frmDropCoil();
            winDropCoil.MdiParent = this;
            winDropCoil.StartPosition = FormStartPosition.Manual;
            winDropCoil.Show();
        }

        private void solicitudDeBaseParaMetalizarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmMetallizedOrder winMetallizedOrder = new frmMetallizedOrder();
            winMetallizedOrder.MdiParent = this;
            winMetallizedOrder.StartPosition = FormStartPosition.Manual;
            winMetallizedOrder.Show();

        }

        private void ingresoDeImportaciónDePelículaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegisterCoilPalletsImported winRegisterCoilPalletsImported = new frmRegisterCoilPalletsImported();
            winRegisterCoilPalletsImported.MdiParent = this;
            winRegisterCoilPalletsImported.StartPosition = FormStartPosition.Manual;
            winRegisterCoilPalletsImported.Show();
        }

        private void ordenesDeMetalizadoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmMetallizedOrderList winMetallizedOrderList = new frmMetallizedOrderList();
            winMetallizedOrderList.MdiParent = this;
            winMetallizedOrderList.StartPosition = FormStartPosition.Manual;
            winMetallizedOrderList.Show();
        }

        private void tsmExtrusionOrderRawMaterial_Click(object sender, EventArgs e)
        {

        }

        private void listadoDeBobinasMadreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainCoilList winMainCoilList = new frmMainCoilList();
            winMainCoilList.MdiParent = this;
            winMainCoilList.StartPosition = FormStartPosition.Manual;
            winMainCoilList.Show();
        }

        private void listadoDeBobinasMadreToolStripMenuItemC_Click(object sender, EventArgs e)
        {
            frmMainCoilList winMainCoilList = new frmMainCoilList(3);
            winMainCoilList.MdiParent = this;
            winMainCoilList.StartPosition = FormStartPosition.Manual;
            winMainCoilList.Show();
        }

        private void listadoDeBobinasMadreToolStripMenuItemPL_Click(object sender, EventArgs e)
        {
            frmMainCoilList winMainCoilList = new frmMainCoilList(4);
            winMainCoilList.MdiParent = this;
            winMainCoilList.StartPosition = FormStartPosition.Manual;
            winMainCoilList.Show();
        }

        private void registrarPropiedadesPorBobinaMadreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainCoilQuality winMainCoilQuality = new frmMainCoilQuality();
            winMainCoilQuality.StartPosition = FormStartPosition.Manual;
            winMainCoilQuality.MdiParent = this;
            winMainCoilQuality.Show();

            //frmMainCoilQualityOpp winMainCoilQuality = new frmMainCoilQualityOpp();
            //winMainCoilQuality.StartPosition = FormStartPosition.Manual;
            //winMainCoilQuality.MdiParent = this;
            //winMainCoilQuality.Show();
        }

        private void nuevoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmValidatePackingList winThermProduct = new frmValidatePackingList();
            winThermProduct.StartPosition = FormStartPosition.Manual;
            winThermProduct.MdiParent = this;
            winThermProduct.Show();
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmThermoformingForm winThermoformingForm = new frmThermoformingForm();
            winThermoformingForm.StartPosition = FormStartPosition.Manual;
            winThermoformingForm.MdiParent = this;
            winThermoformingForm.Show();
        }

        private void listadoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmProductList winProductList = new frmProductList();
            winProductList.MdiParent = this;
            winProductList.StartPosition = FormStartPosition.Manual;
            winProductList.Show();
        }

        private void exportarBobinasXproToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExportMailCoil winExportMainCoil = new frmExportMailCoil();
            winExportMainCoil.MdiParent = this;
            winExportMainCoil.StartPosition = FormStartPosition.Manual;
            winExportMainCoil.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerListReport winCustomerReport = new frmCustomerListReport();
            winCustomerReport.MdiParent = this;
            winCustomerReport.StartPosition = FormStartPosition.Manual;
            winCustomerReport.Show();
        }

        private void tsmNationalSalesNew_Click(object sender, EventArgs e)
        {
            frmNewOrdersEntry winSalesOrderForm = new frmNewOrdersEntry();
            winSalesOrderForm.MdiParent = this;
            winSalesOrderForm.StartPosition = FormStartPosition.Manual;
            winSalesOrderForm.Show();
        }

        private void añosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesOrderByReport winSalesOrderReport = new frmSalesOrderByReport();
            winSalesOrderReport.MdiParent = this;
            winSalesOrderReport.StartPosition = FormStartPosition.Manual;
            winSalesOrderReport.Show();
        }

        private void palletsPorOrdenDeVentaNacionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPalletsBySalesOrder winPalletBySalesOrder = new frmPalletsBySalesOrder();
            winPalletBySalesOrder.MdiParent = this;
            winPalletBySalesOrder.StartPosition = FormStartPosition.Manual;
            winPalletBySalesOrder.Show();
        }

        private void palletsPorOrdenDeVentaInternacionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPalletsByInternationalSalesOrder winPalletsByInternationalSalesOrde = new frmPalletsByInternationalSalesOrder();
            winPalletsByInternationalSalesOrde.MdiParent = this;
            winPalletsByInternationalSalesOrde.StartPosition = FormStartPosition.Manual;
            winPalletsByInternationalSalesOrde.Show();
        }

        private void tsmPalletsBySalesOrder_Click(object sender, EventArgs e)
        {
            frmPalletRegistration winPalletByCuttingOrder = new frmPalletRegistration(0, "salesOrder");
            winPalletByCuttingOrder.MdiParent = this;
            winPalletByCuttingOrder.StartPosition = FormStartPosition.Manual;
            winPalletByCuttingOrder.Show();
        }

        private void listaDeEmpaqueOrdenesNacionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesOrderListForPackingList winSalesOrderListForPackingList = new frmSalesOrderListForPackingList();
            winSalesOrderListForPackingList.MdiParent = this;
            winSalesOrderListForPackingList.StartPosition = FormStartPosition.Manual;
            winSalesOrderListForPackingList.Show();
        }

        private void listaDeEmpaqueOrdenesInternacionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInternationalSalesOrderListForPackingList winInternationalSalesOrderListForPackingList = new frmInternationalSalesOrderListForPackingList();
            winInternationalSalesOrderListForPackingList.MdiParent = this;
            winInternationalSalesOrderListForPackingList.StartPosition = FormStartPosition.Manual;
            winInternationalSalesOrderListForPackingList.Show();
        }

        private void solicitudDeBobinasParaCorteSecundarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPalletCoilRequest winPalletCoilRequest = new frmPalletCoilRequest("secundaryCut");
            winPalletCoilRequest.MdiParent = this;
            winPalletCoilRequest.StartPosition = FormStartPosition.Manual;
            winPalletCoilRequest.Show();
        }

        private void programaciónDeCorteSecundarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSecundaryCuttingOrder winSecundaryCuttingOrder = new frmSecundaryCuttingOrder();
            winSecundaryCuttingOrder.MdiParent = this;
            winSecundaryCuttingOrder.StartPosition = FormStartPosition.Manual;
            winSecundaryCuttingOrder.Show();
        }

        private void listadoDeBobinasEnObservaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCoilsInObservationList winCoilInObservationList = new frmCoilsInObservationList();
            winCoilInObservationList.StartPosition = FormStartPosition.Manual;
            winCoilInObservationList.MdiParent = this;
            winCoilInObservationList.Show();
        }

        private void tsmMainCoilRegistration_Click(object sender, EventArgs e)
        {
            frmMainCoilRegister winMainCoilRegister = new frmMainCoilRegister(true);
            winMainCoilRegister.StartPosition = FormStartPosition.Manual;
            winMainCoilRegister.MdiParent = this;
            winMainCoilRegister.Show();

        }

        private void registroDeBobinasParaReprocesoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewCoil winNewCoil = new frmNewCoil();
            winNewCoil.StartPosition = FormStartPosition.Manual;
            winNewCoil.MdiParent = this;
            winNewCoil.Show();
        }

        private void detalleDeBobinasPorOrdenesDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCoilReportBySalesOrder winCoilReportBySalesOrder = new frmCoilReportBySalesOrder();
            winCoilReportBySalesOrder.StartPosition = FormStartPosition.Manual;
            winCoilReportBySalesOrder.MdiParent = this;
            winCoilReportBySalesOrder.Show();
        }

        private void detalleDeBobinasPorOrdenDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCoilReportBySalesOrder winCoilReportBySalesOrder = new frmCoilReportBySalesOrder();
            winCoilReportBySalesOrder.StartPosition = FormStartPosition.Manual;
            winCoilReportBySalesOrder.MdiParent = this;
            winCoilReportBySalesOrder.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmInProcessCoils generateNewReport = new frmInProcessCoils();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmPalletCoilRequest winPalletCoilRequest = new frmPalletCoilRequest("secundaryCut");
            winPalletCoilRequest.MdiParent = this;
            winPalletCoilRequest.StartPosition = FormStartPosition.Manual;
            winPalletCoilRequest.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            //frmSecundaryCuttingOrder winSecundaryCuttingOrder = new frmSecundaryCuttingOrder();
            //winSecundaryCuttingOrder.MdiParent = this;
            //winSecundaryCuttingOrder.StartPosition = FormStartPosition.Manual;
            //winSecundaryCuttingOrder.WindowState = FormWindowState.Maximized;
            //winSecundaryCuttingOrder.Show();

            frmSecundaryCuttingOrderMultiple winSecundaryCuttingOrderMultiple = new frmSecundaryCuttingOrderMultiple();
            winSecundaryCuttingOrderMultiple.MdiParent = this;
            winSecundaryCuttingOrderMultiple.StartPosition = FormStartPosition.Manual;
            winSecundaryCuttingOrderMultiple.WindowState = FormWindowState.Maximized;
            winSecundaryCuttingOrderMultiple.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            frmSalesOrderListForPackingList winSalesOrderListForPackingList = new frmSalesOrderListForPackingList();
            winSalesOrderListForPackingList.MdiParent = this;
            winSalesOrderListForPackingList.StartPosition = FormStartPosition.Manual;
            winSalesOrderListForPackingList.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            frmInternationalSalesOrderListForPackingList winInternationalSalesOrderListForPackingList = new frmInternationalSalesOrderListForPackingList();
            winInternationalSalesOrderListForPackingList.MdiParent = this;
            winInternationalSalesOrderListForPackingList.StartPosition = FormStartPosition.Manual;
            winInternationalSalesOrderListForPackingList.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            frmChangeSalesOrder winChangeSalesOrder = new frmChangeSalesOrder();
            winChangeSalesOrder.MdiParent = this;
            winChangeSalesOrder.StartPosition = FormStartPosition.Manual;
            winChangeSalesOrder.Show();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            frmExecuteChangeSalesOrder winExecuteChangeSalesOrder = new frmExecuteChangeSalesOrder();
            winExecuteChangeSalesOrder.MdiParent = this;
            winExecuteChangeSalesOrder.StartPosition = FormStartPosition.Manual;
            winExecuteChangeSalesOrder.Show();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            frmCoilDetail winCoilDetail = new frmCoilDetail();
            winCoilDetail.StartPosition = FormStartPosition.Manual;
            winCoilDetail.MdiParent = this;
            winCoilDetail.Show();
        }

        private void nuevaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmMetallizedOrderReaload winMetallizedOrderList = new frmMetallizedOrderReaload();
            winMetallizedOrderList.MdiParent = this;
            winMetallizedOrderList.StartPosition = FormStartPosition.Manual;
            winMetallizedOrderList.Show();
        }

        private void exportaciónSIIGOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesOrderListForExport winSalesOrderListForExport = new frmSalesOrderListForExport();
            winSalesOrderListForExport.MdiParent = this;
            winSalesOrderListForExport.StartPosition = FormStartPosition.Manual;
            winSalesOrderListForExport.Show();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            frmInternationalSalesOrderListForExport winInternationalSalesOrderListForExport = new frmInternationalSalesOrderListForExport();
            winInternationalSalesOrderListForExport.MdiParent = this;
            winInternationalSalesOrderListForExport.StartPosition = FormStartPosition.Manual;
            winInternationalSalesOrderListForExport.Show();
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            frmPalletDetail winPalletDetail = new frmPalletDetail();
            winPalletDetail.MdiParent = this;
            winPalletDetail.StartPosition = FormStartPosition.Manual;
            winPalletDetail.Show();
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            frmPalletList winPalletList = new frmPalletList();
            winPalletList.StartPosition = FormStartPosition.Manual;
            winPalletList.MdiParent = this;
            winPalletList.Show();
        }

        private void tsmShippingBuilding_Click(object sender, EventArgs e)
        {
            frmShippingBuilding winShippingBuilding = new frmShippingBuilding();
            winShippingBuilding.StartPosition = FormStartPosition.Manual;
            winShippingBuilding.MdiParent = this;
            winShippingBuilding.Show();
        }

        private void tsmVapor_Click(object sender, EventArgs e)
        {
            frmVapor winVapor = new frmVapor();
            winVapor.StartPosition = FormStartPosition.Manual;
            winVapor.MdiParent = this;
            winVapor.Show();
        }

        private void tsmShipping_Click(object sender, EventArgs e)
        {
            frmShipping winShipping = new frmShipping();
            winShipping.StartPosition = FormStartPosition.Manual;
            winShipping.MdiParent = this;
            winShipping.Show();
        }

        private void tsmSummaryReportCutter_Click(object sender, EventArgs e)
        {
            frmSummaryCutter winSummaryCutter = new frmSummaryCutter();
            winSummaryCutter.StartPosition = FormStartPosition.Manual;
            winSummaryCutter.MdiParent = this;
            winSummaryCutter.Show();
        }

        private void detalleDeLotesPorPalletsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmLotDetailByPalletList winLotDetailByPalletList = new frmLotDetailByPalletList();
            winLotDetailByPalletList.StartPosition = FormStartPosition.Manual;
            winLotDetailByPalletList.MdiParent = this;
            winLotDetailByPalletList.Show();
        }

        private void detalleDeBobinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCoilTraceability winCoilTraceability = new frmCoilTraceability();
            winCoilTraceability.StartPosition = FormStartPosition.Manual;
            winCoilTraceability.MdiParent = this;
            winCoilTraceability.Show();
        }

        private void detalleDePalletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPalletDetail winPalletDetail = new frmPalletDetail();
            winPalletDetail.MdiParent = this;
            winPalletDetail.StartPosition = FormStartPosition.Manual;
            winPalletDetail.Show();
        }

        private void agrupamientoDeBobinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGroupCoils winGroupCoils = new frmGroupCoils();
            winGroupCoils.MdiParent = this;
            winGroupCoils.StartPosition = FormStartPosition.Manual;
            winGroupCoils.Show();
        }

        private void tsmCoilPerSalesOrder_Click(object sender, EventArgs e)
        {
            frmCoilReportBySalesOrderShortCut winCoilReportBySalesOrder = new frmCoilReportBySalesOrderShortCut();
            winCoilReportBySalesOrder.StartPosition = FormStartPosition.Manual;
            winCoilReportBySalesOrder.MdiParent = this;
            winCoilReportBySalesOrder.Show();
        }

        private void despachosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPalletShipping winPalletShipping = new frmPalletShipping();
            winPalletShipping.StartPosition = FormStartPosition.Manual;
            winPalletShipping.MdiParent = this;
            winPalletShipping.Show();
        }

        private void tsmMovementReport_Click(object sender, EventArgs e)
        {

        }

        private void stockDePalletsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            /*frmDepotState generateNewReport = new frmDepotState();*/
            frmCompletePalletInventory generateNewReport = new frmCompletePalletInventory();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void stockDeOP1ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            /*frmDepotState generateNewReport = new frmDepotState();*/
            frmCompleteCoilInventory generateNewReport = new frmCompleteCoilInventory();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            frmCoilToCutBySalesOrder winCoilsToCutBySalesOrder = new frmCoilToCutBySalesOrder();
            winCoilsToCutBySalesOrder.StartPosition = FormStartPosition.Manual;
            winCoilsToCutBySalesOrder.MdiParent = this;
            winCoilsToCutBySalesOrder.Show();
        }

        private void deliveyNational_Click(object sender, EventArgs e)
        {
            frmNationalPalletShipping winShipping = new frmNationalPalletShipping();
            winShipping.StartPosition = FormStartPosition.CenterScreen;
            winShipping.MdiParent = this;
            winShipping.Show();
        }

        private void reporteDeDespachosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void secuencialDeRolloMadreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainCoilSecuential winMainCoilSecuential = new frmMainCoilSecuential();
            winMainCoilSecuential.StartPosition = FormStartPosition.Manual;
            winMainCoilSecuential.MdiParent = this;
            winMainCoilSecuential.Show();
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            frmCastProductionOrderForm winCastProductionOrderForm = new frmCastProductionOrderForm();
            winCastProductionOrderForm.MdiParent = this;
            winCastProductionOrderForm.StartPosition = FormStartPosition.Manual;
            winCastProductionOrderForm.Show();
        }

        private void nuevaToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            frmFormulationsCastForm winFormulationCastForm = new frmFormulationsCastForm();
            winFormulationCastForm.MdiParent = this;
            winFormulationCastForm.StartPosition = FormStartPosition.Manual;
            winFormulationCastForm.Show();
        }

        private void listadoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmFormulationsCastList winFormulationsCastList = new frmFormulationsCastList();
            winFormulationsCastList.MdiParent = this;
            winFormulationsCastList.StartPosition = FormStartPosition.Manual;
            winFormulationsCastList.Show();
        }

        private void ordenesDeExtrusiónBoppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExtrusionOrder winExtrusionOrder = new frmExtrusionOrder();
            winExtrusionOrder.MdiParent = this;
            winExtrusionOrder.StartPosition = FormStartPosition.Manual;
            winExtrusionOrder.Show();
        }

        private void ordenesDeExtrusiónCastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExtrusionOrderCast winExtrusionOrderCast = new frmExtrusionOrderCast();
            winExtrusionOrderCast.MdiParent = this;
            winExtrusionOrderCast.StartPosition = FormStartPosition.Manual;
            winExtrusionOrderCast.Show();
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            frmCuttingOrderMultipleCast winCuttingOrderMultipleCast = new frmCuttingOrderMultipleCast();
            winCuttingOrderMultipleCast.MdiParent = this;
            winCuttingOrderMultipleCast.StartPosition = FormStartPosition.Manual;
            winCuttingOrderMultipleCast.WindowState = FormWindowState.Maximized;
            winCuttingOrderMultipleCast.Show();
        }

        private void programaciónDeCorteSecundariocombinaciónSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSecundaryCuttingOrder winSecundaryCuttingOrder = new frmSecundaryCuttingOrder();
            winSecundaryCuttingOrder.MdiParent = this;
            winSecundaryCuttingOrder.StartPosition = FormStartPosition.Manual;
            winSecundaryCuttingOrder.WindowState = FormWindowState.Maximized;
            winSecundaryCuttingOrder.Show();
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            frmCoilReportBySalesOrderShort winCoilReportBySalesOrder = new frmCoilReportBySalesOrderShort();
            winCoilReportBySalesOrder.StartPosition = FormStartPosition.Manual;
            winCoilReportBySalesOrder.MdiParent = this;
            winCoilReportBySalesOrder.Show();
        }

        private void tsmCuttingOrderActive_Click(object sender, EventArgs e)
        {

        }

        private void consumoDeMateriaPrimaPorOrdenDeExtrusiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRawMaterialByProductionLot winRawMaterialByProductionLot = new frmRawMaterialByProductionLot();
            winRawMaterialByProductionLot.StartPosition = FormStartPosition.Manual;
            winRawMaterialByProductionLot.MdiParent = this;
            winRawMaterialByProductionLot.Show();
        }

        private void rollosMadrePorRangoDeFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainCoilProductionByDate winMainCoilProductionByDate = new frmMainCoilProductionByDate();
            winMainCoilProductionByDate.StartPosition = FormStartPosition.Manual;
            winMainCoilProductionByDate.MdiParent = this;
            winMainCoilProductionByDate.Show();
        }

        private void preDespachoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPalletListPreShipping winPalletPreShipping = new frmPalletListPreShipping();
            winPalletPreShipping.StartPosition = FormStartPosition.CenterScreen;
            winPalletPreShipping.MdiParent = this;
            winPalletPreShipping.Show();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPalletPreShipping winPalletPreShipping = new frmPalletPreShipping(0);
            winPalletPreShipping.StartPosition = FormStartPosition.CenterScreen;
            winPalletPreShipping.MdiParent = this;
            winPalletPreShipping.Show();
        }

        private void listadoToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            frmPalletListPreShipping winPalletPreShipping = new frmPalletListPreShipping();
            winPalletPreShipping.StartPosition = FormStartPosition.CenterScreen;
            winPalletPreShipping.MdiParent = this;
            winPalletPreShipping.Show();
        }

        private void reporteDeOrdenesDeCorteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuttingOrderPositionSummaryDateReport winCuttinOrder = new frmCuttingOrderPositionSummaryDateReport();
            winCuttinOrder.StartPosition = FormStartPosition.CenterScreen;
            winCuttinOrder.MdiParent = this;
            winCuttinOrder.Show();
        }

        private void reporteDePlanificaciónGrupalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlanificationFull winPlanificationFull = new frmPlanificationFull();
            winPlanificationFull.StartPosition = FormStartPosition.CenterScreen;
            winPlanificationFull.MdiParent = this;
            winPlanificationFull.Show();
        }

        private void trazabilidadPalletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPalletMovement winPalletMovement = new frmPalletMovement();
            winPalletMovement.StartPosition = FormStartPosition.CenterScreen;
            winPalletMovement.MdiParent = this;
            winPalletMovement.Show();
        }

        private void nuevoToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void listadoToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void movimientosMensualesBodegaBoppToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSummaryCellar winInventoryPassword = new frmSummaryCellar();
            winInventoryPassword.StartPosition = FormStartPosition.CenterScreen;
            winInventoryPassword.MdiParent = this;
            winInventoryPassword.Show();
        }

        private void movimientosMensualesBodegaOppToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSummaryCellarOpp winInventoryPassword = new frmSummaryCellarOpp();
            winInventoryPassword.StartPosition = FormStartPosition.CenterScreen;
            winInventoryPassword.MdiParent = this;
            winInventoryPassword.Show();
        }

        private void producciónMensualDMTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSummaryMill winInventoryPassword = new frmSummaryMill();
            winInventoryPassword.StartPosition = FormStartPosition.CenterScreen;
            winInventoryPassword.MdiParent = this;
            winInventoryPassword.Show();
        }

        private void exportacinDeDespachosASIIGOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            frmPalletPreShipping winPalletPreShipping = new frmPalletPreShipping(0);
            winPalletPreShipping.StartPosition = FormStartPosition.CenterScreen;
            winPalletPreShipping.MdiParent = this;
            winPalletPreShipping.Show();
        }

        private void listadoToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            frmPalletListPreShipping winPalletPreShipping = new frmPalletListPreShipping();
            winPalletPreShipping.StartPosition = FormStartPosition.CenterScreen;
            winPalletPreShipping.MdiParent = this;
            winPalletPreShipping.Show();
        }

        private void predDespDetail_Click(object sender, EventArgs e)
        {
            frmPreShippingDetail winPalletPreShipping = new frmPreShippingDetail();
            winPalletPreShipping.StartPosition = FormStartPosition.CenterScreen;
            winPalletPreShipping.MdiParent = this;
            winPalletPreShipping.Show();
        }

        private void códigoDeProductosConfitecaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXtraProductCode winXtraProductCode = new frmXtraProductCode();
            winXtraProductCode.StartPosition = FormStartPosition.CenterScreen;
            winXtraProductCode.MdiParent = this;
            winXtraProductCode.Show();
        }

        private void cóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXtraProductCode winXtraProductCode = new frmXtraProductCode();
            winXtraProductCode.StartPosition = FormStartPosition.CenterScreen;
            winXtraProductCode.MdiParent = this;
            winXtraProductCode.Show();
        }

        private void reporteDeDespachosParaSiigoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backloadVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFinishedProductDepot generateNewReport = new frmFinishedProductDepot();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void registrarBobinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaperCoil winbackload = new frmPaperCoil();
            winbackload.StartPosition = FormStartPosition.CenterScreen;
            winbackload.MdiParent = this;
            winbackload.Show();
        }

        private void listadoToolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            frmPaperList winbackload = new frmPaperList();
            winbackload.StartPosition = FormStartPosition.CenterScreen;
            winbackload.MdiParent = this;
            winbackload.Show();
        }

        private void busquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //frmMenuSalesOrderReports winbackload = new frmMenuSalesOrderReports();
            //winbackload.StartPosition = FormStartPosition.CenterScreen;
            //winbackload.MdiParent = this;
            //winbackload.Show();
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesOrderFulfillmetNational winbackload = new frmSalesOrderFulfillmetNational();
            winbackload.StartPosition = FormStartPosition.CenterScreen;
            winbackload.MdiParent = this;
            winbackload.Show();
        }

        private void filtrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesOrderSummary winbackload = new frmSalesOrderSummary();
            winbackload.StartPosition = FormStartPosition.CenterScreen;
            winbackload.MdiParent = this;
            winbackload.Show();
        }

        private void filtrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSalesOrderSummaryInternational winbackload = new frmSalesOrderSummaryInternational();
            winbackload.StartPosition = FormStartPosition.CenterScreen;
            winbackload.MdiParent = this;
            winbackload.Show();
        }

        private void generalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSalesOrderFulfillmetInternacional winbackload = new frmSalesOrderFulfillmetInternacional();
            winbackload.StartPosition = FormStartPosition.CenterScreen;
            winbackload.MdiParent = this;
            winbackload.Show();
        }

        private void reporteMaterialFaltanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesOrderByProduction winbackload = new frmSalesOrderByProduction();
            winbackload.StartPosition = FormStartPosition.CenterScreen;
            winbackload.MdiParent = this;
            winbackload.Show();
        }

        private void materialStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStockPallets winbackload = new frmStockPallets();
            winbackload.StartPosition = FormStartPosition.CenterScreen;
            winbackload.MdiParent = this;
            winbackload.Show();
        }

        private void exportaciónDeMovimientosASIIGOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmExportPalletMovementPlus winExportPalletMovement = new frmExportPalletMovementPlus();
            winExportPalletMovement.StartPosition = FormStartPosition.Manual;
            winExportPalletMovement.MdiParent = this;
            winExportPalletMovement.Show();
        }

        private void exportaciónDeDespachosASIIGOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExportPalletShippingPlus winExportPalletShipping = new frmExportPalletShippingPlus();
            winExportPalletShipping.StartPosition = FormStartPosition.Manual;
            winExportPalletShipping.MdiParent = this;
            winExportPalletShipping.Show();
        }

        private void materialesXClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesOrderFilmByCustomer winExportPalletShipping = new frmSalesOrderFilmByCustomer();
            winExportPalletShipping.StartPosition = FormStartPosition.CenterScreen;
            winExportPalletShipping.MdiParent = this;
            winExportPalletShipping.Show();
        }

        private void peliculaXMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesOrderQuantityByMonth winExportPalletShipping = new frmSalesOrderQuantityByMonth();
            winExportPalletShipping.StartPosition = FormStartPosition.CenterScreen;
            winExportPalletShipping.MdiParent = this;
            winExportPalletShipping.Show();
        }

        private void películaXClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesOrderQuantityByCustomer winExportPalletShipping = new frmSalesOrderQuantityByCustomer();
            winExportPalletShipping.StartPosition = FormStartPosition.CenterScreen;
            winExportPalletShipping.MdiParent = this;
            winExportPalletShipping.Show();
        }

        private void paísXKilosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesOrderCountry winExportPalletShipping = new frmSalesOrderCountry();
            winExportPalletShipping.StartPosition = FormStartPosition.CenterScreen;
            winExportPalletShipping.MdiParent = this;
            winExportPalletShipping.Show();
        }

        private void bobinasEnObservaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmObservationCoilReport winExportPalletShipping = new frmObservationCoilReport();
            winExportPalletShipping.StartPosition = FormStartPosition.CenterScreen;
            winExportPalletShipping.MdiParent = this;
            winExportPalletShipping.Show();
        }

        private void pedidosFCompromisoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesOrderManagement winExportPalletShipping = new frmSalesOrderManagement();
            winExportPalletShipping.StartPosition = FormStartPosition.CenterScreen;
            winExportPalletShipping.MdiParent = this;
            winExportPalletShipping.Show();
        }

        private void pedidosAnualesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesOrderSummaryByYearOld winExportPalletShipping = new frmSalesOrderSummaryByYearOld();
            winExportPalletShipping.StartPosition = FormStartPosition.CenterScreen;
            winExportPalletShipping.MdiParent = this;
            winExportPalletShipping.Show();
        }

        private void densidadDePelículasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDensityByFilm winExportPalletShipping = new frmDensityByFilm();
            winExportPalletShipping.StartPosition = FormStartPosition.CenterScreen;
            winExportPalletShipping.MdiParent = this;
            winExportPalletShipping.Show();
        }

        private void rangoDeAceptaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRangeAceptation winExportPalletShipping = new frmRangeAceptation();
            winExportPalletShipping.StartPosition = FormStartPosition.CenterScreen;
            winExportPalletShipping.MdiParent = this;
            winExportPalletShipping.Show();
        }

        private void nuevoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmCertificate winExportPalletShipping = new frmCertificate();
            winExportPalletShipping.StartPosition = FormStartPosition.CenterScreen;
            winExportPalletShipping.MdiParent = this;
            winExportPalletShipping.Show();
        }

        private void cambioWc020WTSI020ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCoilDetailTemporaly winExportPalletShipping = new frmCoilDetailTemporaly();
            winExportPalletShipping.StartPosition = FormStartPosition.CenterScreen;
            winExportPalletShipping.MdiParent = this;
            winExportPalletShipping.Show();
        }

        private void reporteDeMaterialFaltanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesOrderByProduction winbackload = new frmSalesOrderByProduction();
            winbackload.StartPosition = FormStartPosition.CenterScreen;
            winbackload.MdiParent = this;
            winbackload.Show();
        }

        private void reporteDeEficienciaPorPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEficiencySalesOrder winbackload = new frmEficiencySalesOrder();
            winbackload.StartPosition = FormStartPosition.CenterScreen;
            winbackload.MdiParent = this;
            winbackload.Show();
        }

        private void listadoToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmCertificateList winCertificateList = new frmCertificateList();
            winCertificateList.StartPosition = FormStartPosition.CenterScreen;
            winCertificateList.MdiParent = this;
            winCertificateList.Show();
        }

        private void listadoDeBobinasEnStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCoilListInStock winCertificateList = new frmCoilListInStock();
            winCertificateList.StartPosition = FormStartPosition.CenterScreen;
            winCertificateList.MdiParent = this;
            winCertificateList.Show();
        }

        private void listadoToolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void nuevaToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            frmAddRawMaterialSelector win = new frmAddRawMaterialSelector();
            win.StartPosition = FormStartPosition.CenterScreen;
            win.MdiParent = this;
            win.Show();
        }

        private void listadoToolStripMenuItem5_Click_1(object sender, EventArgs e)
        {
            frmRawMaterialSelector win = new frmRawMaterialSelector();
            win.StartPosition = FormStartPosition.CenterScreen;
            win.MdiParent = this;
            win.Show();
        }

        private void actualizaciónSiigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReactiveSiigo winSiigo = new frmReactiveSiigo();
            winSiigo.StartPosition = FormStartPosition.CenterScreen;
            winSiigo.MdiParent = this;
            winSiigo.Show();
        }

        private void reIngresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReDeliveryPallet winRedelivery = new frmReDeliveryPallet();
            if (winRedelivery.isAutoricet)
            {
                winRedelivery.StartPosition = FormStartPosition.CenterScreen;
                winRedelivery.MdiParent = this;
                winRedelivery.Show();
            }
        }

        private void bobinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCoilDetailTemporaly winExportPalletShipping = new frmCoilDetailTemporaly();
            winExportPalletShipping.StartPosition = FormStartPosition.CenterScreen;
            winExportPalletShipping.MdiParent = this;
            winExportPalletShipping.Show();
        }

        private void cambioBodegasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangeCellar winExportPalletShipping = new frmChangeCellar();
            if (winExportPalletShipping.isAutoricet)
            {
                winExportPalletShipping.StartPosition = FormStartPosition.CenterScreen;
                winExportPalletShipping.MdiParent = this;
                winExportPalletShipping.Show();
            }
        }

        private void cambioProcedenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangeOrigin winExportPalletShipping = new frmChangeOrigin();
            if (winExportPalletShipping.isAutoricet)
            {
                winExportPalletShipping.StartPosition = FormStartPosition.CenterScreen;
                winExportPalletShipping.MdiParent = this;
                winExportPalletShipping.Show();
            }
        }

        private void sC030SCM030ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exportaciónDeMovimientosSIIGoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExportPalletMovement winExportPalletMovement = new frmExportPalletMovement();
            winExportPalletMovement.StartPosition = FormStartPosition.Manual;
            winExportPalletMovement.MdiParent = this;
            winExportPalletMovement.Show();
        }

        private void wC020WPSI023ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCoilDetailTemporaly winExportPalletShipping = new frmCoilDetailTemporaly();
            winExportPalletShipping.StartPosition = FormStartPosition.CenterScreen;
            winExportPalletShipping.MdiParent = this;
            winExportPalletShipping.Show();
        }

        private void devolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReturnCoil winExportPalletShipping = new frmReturnCoil();
            if (winExportPalletShipping.isAutoricet)
            {
                winExportPalletShipping.StartPosition = FormStartPosition.CenterScreen;
                winExportPalletShipping.MdiParent = this;
                winExportPalletShipping.Show();
            }
        }

        private void devolucionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void devolucionesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmReturnCoilBackLoadList winReturn = new frmReturnCoilBackLoadList();
            winReturn.StartPosition = FormStartPosition.CenterScreen;
            winReturn.MdiParent = this;
            winReturn.Show();
        }

        private void maquilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaquileCoil winReturn = new frmMaquileCoil();
            if (winReturn.isAutoricet)
            {
                winReturn.StartPosition = FormStartPosition.CenterScreen;
                winReturn.MdiParent = this;
                winReturn.Show();
            }
        }

        private void maquilasToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void maquilasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMaquileCoilBackLoadList winReturn = new frmMaquileCoilBackLoadList();
            winReturn.StartPosition = FormStartPosition.CenterScreen;
            winReturn.MdiParent = this;
            winReturn.Show();
        }

        private void esportaciónDeDevolucionesASIIGOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExportReturnMovement winReturn = new frmExportReturnMovement();
            winReturn.StartPosition = FormStartPosition.CenterScreen;
            winReturn.MdiParent = this;
            winReturn.Show();
        }

        private void exportaciónDeMaquilasASIIGOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExportMaquileMovement winReturn = new frmExportMaquileMovement();
            winReturn.StartPosition = FormStartPosition.CenterScreen;
            winReturn.MdiParent = this;
            winReturn.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmMetallizedOrder winMetallizedOrder = new frmMetallizedOrder();
            winMetallizedOrder.MdiParent = this;
            winMetallizedOrder.StartPosition = FormStartPosition.Manual;
            winMetallizedOrder.Show();
        }

        private void rawdepothistory_Click(object sender, EventArgs e)
        {
            frmRawDepotHistory form = new frmRawDepotHistory();
            form.StartPosition = FormStartPosition.Manual;
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            frmMetallizedOrderList winMetallizedOrderList = new frmMetallizedOrderList();
            winMetallizedOrderList.MdiParent = this;
            winMetallizedOrderList.StartPosition = FormStartPosition.Manual;
            winMetallizedOrderList.Show();
        }

        private void reporteOrdenMetalizadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMetalizedOrderReport winMetallizedOrderList = new frmMetalizedOrderReport();
            winMetallizedOrderList.MdiParent = this;
            winMetallizedOrderList.StartPosition = FormStartPosition.Manual;
            winMetallizedOrderList.Show();
        }

        private void reporteProducciónDiariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMetalizedProdutionReport winMetallizedOrderList = new frmMetalizedProdutionReport();
            winMetallizedOrderList.MdiParent = this;
            winMetallizedOrderList.StartPosition = FormStartPosition.Manual;
            winMetallizedOrderList.Show();
        }

        private void reportemovimientosmatprima_Click(object sender, EventArgs e)
        {
            frmRawMaterialMovementsReport generateNewReport = new frmRawMaterialMovementsReport();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void reportIngresoMP_Click(object sender, EventArgs e)
        {
            frmRawMaterialEntryReport generateNewReport = new frmRawMaterialEntryReport();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }
        private void reportePresionesTMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMetalizedPressionDeadTimeReport winMetallizedOrderList = new frmMetalizedPressionDeadTimeReport();
            winMetallizedOrderList.MdiParent = this;
            winMetallizedOrderList.StartPosition = FormStartPosition.Manual;
            winMetallizedOrderList.Show();
        }

        private void nuevasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMetallizedOrderReaload winMetallizedOrderList = new frmMetallizedOrderReaload();
            winMetallizedOrderList.MdiParent = this;
            winMetallizedOrderList.StartPosition = FormStartPosition.Manual;
            winMetallizedOrderList.Show();
        }

        private void devolucionesToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmReturnCoilBackLoadList winReturn = new frmReturnCoilBackLoadList();
            winReturn.StartPosition = FormStartPosition.CenterScreen;
            winReturn.MdiParent = this;
            winReturn.Show();
        }

        private void despachoReport_Click(object sender, EventArgs e)
        {
            frmRawMaterialDispatchReport generateNewReport = new frmRawMaterialDispatchReport();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void maquilasToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmMaquileCoilBackLoadList winReturn = new frmMaquileCoilBackLoadList();
            winReturn.StartPosition = FormStartPosition.CenterScreen;
            winReturn.MdiParent = this;
            winReturn.Show();
        }

        private void despachoOrdenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShippingMultiple winReturn = new frmShippingMultiple();
            if (winReturn.isAutoricet)
            {
                winReturn.StartPosition = FormStartPosition.CenterScreen;
                winReturn.MdiParent = this;
                winReturn.Show();
            }
        }

        private void sC030BC030ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCoilDetailTemporaly winExportPalletShipping = new frmCoilDetailTemporaly();
            winExportPalletShipping.StartPosition = FormStartPosition.CenterScreen;
            winExportPalletShipping.MdiParent = this;
            winExportPalletShipping.Show();
        }

        private void toolStripSeparator2_Click(object sender, EventArgs e)
        {
            frmMetalizedOrderReport winMetallizedOrderList = new frmMetalizedOrderReport();
            winMetallizedOrderList.MdiParent = this;
            winMetallizedOrderList.StartPosition = FormStartPosition.Manual;
            winMetallizedOrderList.Show();
        }

        private void registrarPropiedadesRolloMetalizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainCoilQualityMetal winCoilQualityMetal = new frmMainCoilQualityMetal();
            winCoilQualityMetal.MdiParent = this;
            winCoilQualityMetal.StartPosition = FormStartPosition.Manual;
            winCoilQualityMetal.Show();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            frmMainCoilMetalList wincoil = new frmMainCoilMetalList();
            wincoil.MdiParent = this;
            wincoil.StartPosition = FormStartPosition.Manual;
            wincoil.Show();
        }

        private void toolStripTextBox1PL_Click(object sender, EventArgs e)
        {
            frmMainCoilMetalList wincoil = new frmMainCoilMetalList(4);
            wincoil.MdiParent = this;
            wincoil.StartPosition = FormStartPosition.Manual;
            wincoil.Show();
        }

        private void reportePropiedadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSummaryCertificates winRegister = new frmSummaryCertificates();
            winRegister.MdiParent = this;
            winRegister.StartPosition = FormStartPosition.Manual;
            winRegister.Show();
        }

        private void listadoMolinosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMillList winRegister = new frmMillList();
            winRegister.MdiParent = this;
            winRegister.StartPosition = FormStartPosition.CenterScreen;
            winRegister.Show();
        }

        private void nuevaToolStripMenuItem2_Click_2(object sender, EventArgs e)
        {
            frmMetallizedOrderReaload winMetallizedOrderList = new frmMetallizedOrderReaload();
            winMetallizedOrderList.MdiParent = this;
            winMetallizedOrderList.StartPosition = FormStartPosition.Manual;
            winMetallizedOrderList.Show();
        }

       private void newOrdMet_Click(object sender,EventArgs e)
        {
            frmNewProductionOrderMetal metOrder = new frmNewProductionOrderMetal();
            metOrder.MdiParent = this;
            metOrder.StartPosition = FormStartPosition.Manual;
            metOrder.Show();
        }

       private void historyOfMetalOrders_Click(object sender, EventArgs e)
        {
            frmNewProductionOrderMetalList winProductionList = new frmNewProductionOrderMetalList();
            winProductionList.MdiParent = this;
            winProductionList.StartPosition = FormStartPosition.CenterScreen;
            winProductionList.Show();
        }


        private void producciónDiariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMetalizedProdutionReport winMetallizedOrderList = new frmMetalizedProdutionReport();
            winMetallizedOrderList.MdiParent = this;
            winMetallizedOrderList.StartPosition = FormStartPosition.Manual;
            winMetallizedOrderList.Show();
        }

        private void tiempoMuertosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMetalizedPressionDeadTimeReport winMetallizedOrderList = new frmMetalizedPressionDeadTimeReport();
            winMetallizedOrderList.MdiParent = this;
            winMetallizedOrderList.StartPosition = FormStartPosition.Manual;
            winMetallizedOrderList.Show();
        }

        private void ordenMetalizadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMetalizedOrderReport winMetallizedOrderList = new frmMetalizedOrderReport();
            winMetallizedOrderList.MdiParent = this;
            winMetallizedOrderList.StartPosition = FormStartPosition.Manual;
            winMetallizedOrderList.Show();
        }

        private void importReport_Click(object sender,EventArgs e)
        {
            frmImportReport importaciones = new frmImportReport();
            importaciones.MdiParent = this;
            importaciones.StartPosition = FormStartPosition.Manual;
            importaciones.Show();
        }

        private void shippingsByCoil_Click(object sender, EventArgs e)
        {
            frmShippingReport reporteDespachos = new frmShippingReport();
            reporteDespachos.MdiParent = this;
            reporteDespachos.StartPosition = FormStartPosition.Manual;
            reporteDespachos.Show();
        }

        private void OTIFReport_Click(object sender, EventArgs e)
        {
            frmOTIFReport reporteDespachos = new frmOTIFReport();
            reporteDespachos.MdiParent = this;
            reporteDespachos.StartPosition = FormStartPosition.Manual;
            reporteDespachos.Show();
        }

        private void nuevoToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmDisplacement winExportPalletShipping = new frmDisplacement();
            winExportPalletShipping.StartPosition = FormStartPosition.CenterScreen;
            winExportPalletShipping.MdiParent = this;
            winExportPalletShipping.Show();

            //frmCubeOptions winExportPalletShipping = new frmCubeOptions();
            //winExportPalletShipping.StartPosition = FormStartPosition.CenterScreen;
            //winExportPalletShipping.MdiParent = this;
            //winExportPalletShipping.Show();
        }

        private void molinosProducciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMillPalletReport winExportPalletShipping = new frmMillPalletReport();
            winExportPalletShipping.StartPosition = FormStartPosition.CenterScreen;
            winExportPalletShipping.MdiParent = this;
            winExportPalletShipping.Show();
        }

        private void bodega3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPalletByCellar3 winExportPalletShipping = new frmPalletByCellar3();
            winExportPalletShipping.StartPosition = FormStartPosition.Manual;
            winExportPalletShipping.MdiParent = this;
            winExportPalletShipping.Show();
        }

        private void bodega18ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPalletByCellar18 winExportPalletShipping = new frmPalletByCellar18();
            winExportPalletShipping.StartPosition = FormStartPosition.Manual;
            winExportPalletShipping.MdiParent = this;
            winExportPalletShipping.Show();
        }

        private void bodega23ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPalletByCellar23 winExportPalletShipping = new frmPalletByCellar23();
            winExportPalletShipping.StartPosition = FormStartPosition.Manual;
            winExportPalletShipping.MdiParent = this;
            winExportPalletShipping.Show();
        }

        private void bodega19ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPalletByCellar19 winExportPalletShipping = new frmPalletByCellar19();
            winExportPalletShipping.StartPosition = FormStartPosition.Manual;
            winExportPalletShipping.MdiParent = this;
            winExportPalletShipping.Show();
        }

        private void bodega20ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPalletByCellar20 winExportPalletShipping = new frmPalletByCellar20();
            winExportPalletShipping.StartPosition = FormStartPosition.Manual;
            winExportPalletShipping.MdiParent = this;
            winExportPalletShipping.Show();
        }

        private void despachosObenMasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCellarShipping winCellarShippig = new frmCellarShipping();
            winCellarShippig.StartPosition = FormStartPosition.Manual;
            winCellarShippig.MdiParent = this;
            winCellarShippig.Show();
        }

        private void despachosSIigoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmShippingExportToSiigo winExportSiigo = new frmShippingExportToSiigo();
            winExportSiigo.StartPosition = FormStartPosition.CenterScreen;
            winExportSiigo.MdiParent = this;
            winExportSiigo.Show();
        }

        private void movimientosPelículaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovementReportbyDate winMovementReport = new frmMovementReportbyDate();
            winMovementReport.StartPosition = FormStartPosition.Manual;
            winMovementReport.MdiParent = this;
            winMovementReport.Show();
        }

        private void devolucionesToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmPalletByCellarReturn winExportPalletShipping = new frmPalletByCellarReturn();
            winExportPalletShipping.StartPosition = FormStartPosition.Manual;
            winExportPalletShipping.MdiParent = this;
            winExportPalletShipping.Show();
        }

        private void maquilasToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmPalletByCellarMaquile winReturn = new frmPalletByCellarMaquile();
            winReturn.StartPosition = FormStartPosition.CenterScreen;
            winReturn.MdiParent = this;
            winReturn.Show();
        }

        private void movimientosReProcesoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovementReprocess winReturn = new frmMovementReprocess();
            winReturn.StartPosition = FormStartPosition.CenterScreen;
            winReturn.MdiParent = this;
            winReturn.Show();
        }

        private void expotaciónDeReprocesoSIIGOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExportReProcessPalletMovementPlus winReturn = new frmExportReProcessPalletMovementPlus();
            winReturn.StartPosition = FormStartPosition.CenterScreen;
            winReturn.MdiParent = this;
            winReturn.Show();
        }

        private void stockPalletsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReprocessBackLoad winBackLoad = new frmReprocessBackLoad();
            winBackLoad.StartPosition = FormStartPosition.Manual;
            winBackLoad.MdiParent = this;
            winBackLoad.Show();
        }

        private void eficienciaEnCorteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEfficiencyCut winBackLoad = new frmEfficiencyCut();
            winBackLoad.StartPosition = FormStartPosition.Manual;
            winBackLoad.MdiParent = this;
            winBackLoad.Show();
        }

        private void efficienciaEnCorteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEfficiencyCutExtruder winBackLoad = new frmEfficiencyCutExtruder();
            winBackLoad.StartPosition = FormStartPosition.Manual;
            winBackLoad.MdiParent = this;
            winBackLoad.Show();
        }

        private void eficienciaDeCorteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEfficiencyCut winBackLoad = new frmEfficiencyCut();
            winBackLoad.StartPosition = FormStartPosition.Manual;
            winBackLoad.MdiParent = this;
            winBackLoad.Show();
        }

        private void tsmProductionReportByOrder_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem7_Click_1(object sender, EventArgs e)
        {
            frmAddRawMaterialSelector win = new frmAddRawMaterialSelector();
            win.StartPosition = FormStartPosition.CenterScreen;
            win.MdiParent = this;
            win.Show();
        }

        private void nuevoToolStripMenuItem6_Click_1(object sender, EventArgs e)
        {
            frmCastFilmForm winCastFilmForm = new frmCastFilmForm();
            winCastFilmForm.MdiParent = this;
            winCastFilmForm.StartPosition = FormStartPosition.Manual;
            winCastFilmForm.Show();
        }

        private void listadoToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            frmCastFilmList winCastFilmList = new frmCastFilmList();
            winCastFilmList.MdiParent = this;
            winCastFilmList.StartPosition = FormStartPosition.Manual;
            winCastFilmList.Show();
        }

        private void bloqueoMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBlockMaterial winCastFilmList = new frmBlockMaterial();
            if (winCastFilmList.isAutoricet)
            {
                winCastFilmList.MdiParent = this;
                winCastFilmList.StartPosition = FormStartPosition.Manual;
                winCastFilmList.Show();
            }
        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            frmSummaryMetallized winCastFilmList = new frmSummaryMetallized();
            winCastFilmList.MdiParent = this;
            winCastFilmList.StartPosition = FormStartPosition.Manual;
            winCastFilmList.Show();
        }

        private void sC020SD020ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCoilDetailTemporaly winExportPalletShipping = new frmCoilDetailTemporaly();
            winExportPalletShipping.StartPosition = FormStartPosition.CenterScreen;
            winExportPalletShipping.MdiParent = this;
            winExportPalletShipping.Show();
        }

        private void toolStripMenuItem4_Click_1(object sender, EventArgs e)
        {
            frmCoilDetailTemporaly winExportPalletShipping = new frmCoilDetailTemporaly();
            winExportPalletShipping.StartPosition = FormStartPosition.CenterScreen;
            winExportPalletShipping.MdiParent = this;
            winExportPalletShipping.Show();
        }

        private void toolStripMenuItem5_Click_1(object sender, EventArgs e)
        {
            frmCoilDetailTemporaly winExportPalletShipping = new frmCoilDetailTemporaly();
            winExportPalletShipping.StartPosition = FormStartPosition.CenterScreen;
            winExportPalletShipping.MdiParent = this;
            winExportPalletShipping.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmCoilMontana winExportPalletShipping = new frmCoilMontana();
            winExportPalletShipping.StartPosition = FormStartPosition.CenterScreen;
            winExportPalletShipping.MdiParent = this;
            winExportPalletShipping.Show();
        }

        private void equivalenciaMontanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEquivalenceMontana winExportPalletShipping = new frmEquivalenceMontana();
            winExportPalletShipping.StartPosition = FormStartPosition.CenterScreen;
            winExportPalletShipping.MdiParent = this;
            winExportPalletShipping.Show();
        }

        private void listadoToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmCubeList winExportPalletShipping = new frmCubeList();
            winExportPalletShipping.StartPosition = FormStartPosition.CenterScreen;
            winExportPalletShipping.MdiParent = this;
            winExportPalletShipping.Show();
        }

        private void reporteMensualDeCortadorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSummaryCutterReport winReporting = new frmSummaryCutterReport(clsGlobal.password);
            winReporting.StartPosition = FormStartPosition.CenterScreen;
            winReporting.MdiParent = this;
            winReporting.Show();
        }

        private void reporteMensualDeMolinosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSummaryReProcessByMill winExportPalletShipping = new frmSummaryReProcessByMill();
            winExportPalletShipping.StartPosition = FormStartPosition.CenterScreen;
            winExportPalletShipping.MdiParent = this;
            winExportPalletShipping.Show();
        }

        private void nuevoToolStripMenuItem8_Click_1(object sender, EventArgs e)
        {
            frmNylonFilmForm winCastFilmForm = new frmNylonFilmForm();
            winCastFilmForm.MdiParent = this;
            winCastFilmForm.StartPosition = FormStartPosition.Manual;
            winCastFilmForm.Show();
        }

        private void listadoToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            frmNylonFilmList winCastFilmList = new frmNylonFilmList();
            winCastFilmList.MdiParent = this;
            winCastFilmList.StartPosition = FormStartPosition.Manual;
            winCastFilmList.Show();
        }

        private void configuraciónToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmSystemConfig winSystemConfig = new frmSystemConfig();
            if (winSystemConfig.isAutoricet)
            {
                winSystemConfig.MdiParent = this;
                winSystemConfig.StartPosition = FormStartPosition.Manual;
                winSystemConfig.Show();
            }
        }

        private void tsmAdministratorFull_Click(object sender, EventArgs e)
        {
            frmSystemConfigAdmin winSystemConfig = new frmSystemConfigAdmin();
            if (winSystemConfig.isAutoricet)
            {
                winSystemConfig.MdiParent = this;
                winSystemConfig.StartPosition = FormStartPosition.Manual;
                winSystemConfig.Show();
            }
        }

        private void tsmUserAdd_Click(object sender, EventArgs e)
        {
            Manager.User.frmManagerUser winUser = new Manager.User.frmManagerUser();
            winUser.MdiParent = this;
            winUser.StartPosition = FormStartPosition.CenterScreen;
            winUser.Show();
        }

        private void tsmUserList_Click(object sender, EventArgs e)
        {
            Manager.User.frmManagerList winUserList = new Manager.User.frmManagerList();
            winUserList.MdiParent = this;
            winUserList.StartPosition = FormStartPosition.CenterScreen;
            winUserList.Show();
        }

        private void tsmShippingInternational_Click(object sender, EventArgs e)
        {
            ReportsSales.International.frmInternationalSummarySalesOrder winSummaryReport = new ReportsSales.International.frmInternationalSummarySalesOrder();
            winSummaryReport.MdiParent = this;
            winSummaryReport.StartPosition = FormStartPosition.CenterScreen;
            winSummaryReport.Show();
        }

        private void tsmManagerSummary_Click(object sender, EventArgs e)
        {
            frmManagerReport winManager = new frmManagerReport(clsGlobal.password);
            winManager.MdiParent = this;
            winManager.StartPosition = FormStartPosition.CenterScreen;
            winManager.Show();
        }

        private void ord1976ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCoilDetailTemporaly winManager = new frmCoilDetailTemporaly();
            winManager.MdiParent = this;
            winManager.StartPosition = FormStartPosition.CenterScreen;
            winManager.Show();
        }

        private void listadoToolStripMenuItem_Click_3(object sender, EventArgs e)
        {
            frmMetallizedProductionOrdenList winProductionList = new frmMetallizedProductionOrdenList();
            winProductionList.MdiParent = this;
            winProductionList.StartPosition = FormStartPosition.CenterScreen;
            winProductionList.Show();
        }

        private void listadoToolStripMenuItem1_Click_2(object sender, EventArgs e)
        {
            frmMetallizedProductionOrdenList winProductionList = new frmMetallizedProductionOrdenList();
            winProductionList.MdiParent = this;
            winProductionList.StartPosition = FormStartPosition.CenterScreen;
            winProductionList.Show();
        }

        private void materialClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BPS.SalesOrder.frmSummarySalesOrder winSummarySalesOrder = new BPS.SalesOrder.frmSummarySalesOrder();
            winSummarySalesOrder.MdiParent = this;
            winSummarySalesOrder.StartPosition = FormStartPosition.CenterScreen;
            winSummarySalesOrder.Show();
        }

        private void exportaciónDeMateriaPrimaSIIGOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExportRawMaterial winReturn = new frmExportRawMaterial();
            winReturn.StartPosition = FormStartPosition.CenterScreen;
            winReturn.MdiParent = this;
            winReturn.Show();
        }

        private void exportaciónDeDespachosMateriaPrimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExportRawMaterialS winReturn = new frmExportRawMaterialS();
            winReturn.StartPosition = FormStartPosition.CenterScreen;
            winReturn.MdiParent = this;
            winReturn.Show();
        }

        private void tsmRawMaterialStock_Click(object sender, EventArgs e)
        {
            frmBackLoadRaw winReturn = new frmBackLoadRaw();
            winReturn.StartPosition = FormStartPosition.CenterScreen;
            winReturn.MdiParent = this;
            winReturn.Show();
        }

        private void tsmRawMaterialProductList_Click(object sender, EventArgs e)
        {
            frmRawMaterialSelector win = new frmRawMaterialSelector();
            win.StartPosition = FormStartPosition.CenterScreen;
            win.MdiParent = this;
            win.Show();
        }

        private void ordernesDeExtrusiónBoppEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //BPS.Raw.Extruder.frmExtrusionOrder winEx = new BPS.Raw.Extruder.frmExtrusionOrder();
            //winEx.StartPosition = FormStartPosition.CenterScreen;
            //winEx.MdiParent = this;
            //winEx.Show();
        }

        private void tsmMainCoilStockBT_Click(object sender, EventArgs e)
        {
            BPS.Extruder.frmBackLoadRaw winMenu = new BPS.Extruder.frmBackLoadRaw();
            winMenu.StartPosition = FormStartPosition.CenterScreen;
            winMenu.MdiParent = this;
            winMenu.Show();
        }

        private void tsmAddFilmCellar_Click(object sender, EventArgs e)
        {
            BPS.Cellar.Film.frmPalletList winPalletList = new BPS.Cellar.Film.frmPalletList();
            winPalletList.StartPosition = FormStartPosition.Manual;
            winPalletList.MdiParent = this;
            winPalletList.Show();
        }

        private void tsmReProMonthCellar_Click(object sender, EventArgs e)
        {
            frmSummaryMill winInventoryPassword = new frmSummaryMill();
            winInventoryPassword.StartPosition = FormStartPosition.CenterScreen;
            winInventoryPassword.MdiParent = this;
            winInventoryPassword.Show();
        }

        private void consumoDeMPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BPS.Extruder.frmFormulation winMenu = new BPS.Extruder.frmFormulation("DMT");
            winMenu.StartPosition = FormStartPosition.CenterScreen;
            winMenu.MdiParent = this;
            winMenu.Show();
        }

        private void consumoDeMPToolStripMenuItemPL_Click(object sender, EventArgs e)
        {
            BPS.Extruder.frmFormulation winMenu = new BPS.Extruder.frmFormulation("BRUCKNER");
            winMenu.StartPosition = FormStartPosition.CenterScreen;
            winMenu.MdiParent = this;
            winMenu.Show();
        }

        private void corteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuttingReportGen generateNewReport = new frmCuttingReportGen();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }



        private void extrusionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExtrusionReport generateNewReport = new frmExtrusionReport();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void tsmMainCoilStock_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmPalletPreShipping winPalletPreShipping = new frmPalletPreShipping(0);
            winPalletPreShipping.StartPosition = FormStartPosition.CenterScreen;
            winPalletPreShipping.MdiParent = this;
            winPalletPreShipping.Show();
        }

        private void listadoToolStripMenuItem2_Click_2(object sender, EventArgs e)
        {
            frmPalletListPreShipping winPalletPreShipping = new frmPalletListPreShipping();
            winPalletPreShipping.StartPosition = FormStartPosition.CenterScreen;
            winPalletPreShipping.MdiParent = this;
            winPalletPreShipping.Show();
        }

        private void silosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSilos winSilos = new frmSilos();
            winSilos.StartPosition = FormStartPosition.CenterScreen;
            winSilos.MdiParent = this;
            winSilos.Show();
        }

        private void metalizadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMetallizedReport generateNewReport = new frmMetallizedReport();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void newTSMnuReassign_Click(object sender, EventArgs e)
        {
            frmReassign generateNewReport = new frmReassign();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void reportTSMnuReassign_Click(object sender, EventArgs e)
        {
            frmAssignReport generateNewReport = new frmAssignReport();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void nuevaToolStripMenuItem_Click_3(object sender, EventArgs e)
        {
            frmReassign generateNewReport = new frmReassign();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAssignReport generateNewReport = new frmAssignReport();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void planDeCorteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuttingPlan generateNewReport = new frmCuttingPlan();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void rebobinadoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmRewinedReport generateNewReport = new frmRewinedReport();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();


        }

        private void inProcessCoilsTSMItem_Click(object sender, EventArgs e)
        {
            frmInProcessCoils generateNewReport = new frmInProcessCoils();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void controlDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesOrderControl generateNewReport = new frmSalesOrderControl();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void asignaciónDePlantasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAssignmentPlant generateNewReport = new frmAssignmentPlant();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void asignaciónDeEjecutivasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExecutiveAssign generateNewReport = new frmExecutiveAssign();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void actualizarDepositoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAymasDepot generateNewReport = new frmAymasDepot();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void remitosPreseaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPreseaRemit generateNewReport = new frmPreseaRemit();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void ordenesDeVentaAymasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAymasSaleOrderControl generateNewReport = new frmAymasSaleOrderControl();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void definicionesDeCorteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuttingDefinition generateNewReport = new frmCuttingDefinition();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void ingreseoDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrdersEntryDate generateNewReport = new frmOrdersEntryDate();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void toolStripMenuItem2_Click_2(object sender, EventArgs e)
        {
            frmAymasDepot generateNewReport = new frmAymasDepot();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void toolStripMenuItem3_Click_2(object sender, EventArgs e)
        {
            frmPreseaRemit generateNewReport = new frmPreseaRemit();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void toolStripMenuItem4_Click_2(object sender, EventArgs e)
        {
            frmAymasSaleOrderControl generateNewReport = new frmAymasSaleOrderControl();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void detalleDeBLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBLDetail generateNewReport = new frmBLDetail();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();

            /*try
            {
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("SELECT * FROM vwDetalleDeBl");


                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
                worksheet.Name = "Detalle de BL";

                for (int i = 1; i < DS.Tables[0].Columns.Count + 1; i++)
                    worksheet.Cells[1, i] = DS.Tables[0].Columns[i - 1].ToString();

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    for (int j = 0; j < DS.Tables[0].Columns.Count; j++)
                    {
                        if (DS.Tables[0].Rows[i][j].ToString() != null)
                            if (Convert.ToBoolean(DS.Tables[0].Rows[i][j].ToString() == DS.Tables[0].Rows[0][3].ToString()))
                            {
                                worksheet.Cells[i + 2, j ] = Convert.ToDateTime(DS.Tables[0].Rows[i][j]).Date.ToString("dd/MM/yyyy");
                            }
                            else
                            {
                                worksheet.Cells[i + 2, j] = DS.Tables[0].Rows[i][j].ToString();
                            }
                    }
                }
                MessageBox.Show("Exportación Generada correctamente", "Detalle de BL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Detalle de BL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/


        }

        private void detalleDeBLToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            frmBLDetail generateNewReport = new frmBLDetail();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void despachosProgramadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProgrammedDeliveryDate generateNewReport = new frmProgrammedDeliveryDate();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void despachosAcumuladosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeliveriesByMonthDate generateNewReport = new frmDeliveriesByMonthDate();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void reasignacionesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAssignReport generateNewReport = new frmAssignReport();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void reasignacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAssignReport generateNewReport = new frmAssignReport();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void predespachosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPalletListPreShippingPL winPalletPreShipping = new frmPalletListPreShippingPL();
            winPalletPreShipping.StartPosition = FormStartPosition.CenterScreen;
            winPalletPreShipping.MdiParent = this;
            winPalletPreShipping.Show();
        }

        private void historialDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesOrderHistory generateNewReport = new frmSalesOrderHistory();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void historialDeDefinicionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuttingDefinitionHistory generateNewReport = new frmCuttingDefinitionHistory();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void rackMetalizadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainCoilMetalStock winMainCoilStock = new frmMainCoilMetalStock(4);
            winMainCoilStock.StartPosition = FormStartPosition.Manual;
            winMainCoilStock.MdiParent = this;
            winMainCoilStock.Show();

        }

        private void toolStripMenuItem5_Click_2(object sender, EventArgs e)
        {
            frmReportGenerator generateNewReport = new frmReportGenerator();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void reporteDeProgramacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProgrammingReport generateNewReport = new frmProgrammingReport();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void notificacionDeEstrusiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExtrudderNotifications generateNewReport = new frmExtrudderNotifications();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void reetiquetadoMateriasPrimas_Click(object sender, EventArgs e)
        {
            frmRawMaterialRePrintLabel reEtiquetadoDeBolson = new frmRawMaterialRePrintLabel();
            reEtiquetadoDeBolson.MdiParent = this;
            reEtiquetadoDeBolson.StartPosition = FormStartPosition.CenterScreen;
            reEtiquetadoDeBolson.MaximizeBox = false;
            reEtiquetadoDeBolson.Show();

        }

        private void produccionDeMolinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMillProduction generateNewReport = new frmMillProduction();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void reportproduccionDeMolinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMillProductionReport generateNewReport = new frmMillProductionReport();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void envíoDeBobinaMadresAlMolinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScrapMainCoilSend generateNewReport = new frmScrapMainCoilSend();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void reporteMermaExtrusion_Click(object sender, EventArgs e)
        {
            frmScrapExtrusionReport generateNewReport = new frmScrapExtrusionReport();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void palletStockDeMateriasPrimasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRawMaterialDepositState generateNewReport = new frmRawMaterialDepositState();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void reporteDeConsumoDeMateriasPrimas_Click(object sender, EventArgs e)
        {
            frmRawMaterialConsuptionReport generateNewReport = new frmRawMaterialConsuptionReport();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void rawPalletSon_Click(object sender, EventArgs e)
        {
            frmRawMaterialPalletSon generateNewReport = new frmRawMaterialPalletSon();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void reporteMovmimientoMatPrimas_Click(object sender, EventArgs e)
        {
            frmRawMaterialMovementsReport generateNewReport = new frmRawMaterialMovementsReport();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void consumoDeMateriasPrimasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRawMaterialConsumeByPalletOrSilo generateNewReport = new frmRawMaterialConsumeByPalletOrSilo();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }
          
        private void consumoDeMateriasPrimasInyectoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRawMaterialnyectorConsume generateNewReport = new frmRawMaterialnyectorConsume();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void stockDeEstrusiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExtruderStock generateNewReport = new frmExtruderStock();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void trazabilidadDeCorteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuttingTrazability winCuttingTrazability = new frmCuttingTrazability();
            winCuttingTrazability.MdiParent = this;
            winCuttingTrazability.StartPosition = FormStartPosition.Manual;
            winCuttingTrazability.Show();
        }

        private void swapDePalletsDeMateriasPrimasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSwapRawPallet generateNewReport = new frmSwapRawPallet();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void toolStripMenuItem6_Click_1(object sender, EventArgs e)
        {
            frmCoilsWhitoutPallets generateNewReport = new frmCoilsWhitoutPallets();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void romaneoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Romaneo generateNewReport = new Romaneo();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void shippingReportL_Click(object sender, EventArgs e)
        {
            frmShippingReportL generateNewReport = new frmShippingReportL();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void BLPendienteDeCorte_Click(object sender, EventArgs e)
        {
            frmBLPendienteCorte generateNewReport = new frmBLPendienteCorte();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void tsmSecundaryCuttingorder_Click(object sender, EventArgs e)
        {

        }

        private void productoEnProcesoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCoilsInProcess generateNewReport = new frmCoilsInProcess();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void SECATLAS_Click(object sender, EventArgs e)
        {
            frmCuttingOrderList winCuttingOrderList = new frmCuttingOrderList(3026, false);
            winCuttingOrderList.MdiParent = this;
            winCuttingOrderList.StartPosition = FormStartPosition.Manual;
            winCuttingOrderList.Show();
        }

        private void GOEBEL_Click(object sender, EventArgs e)
        {
            frmCuttingOrderList winCuttingOrderList = new frmCuttingOrderList(3025, false);
            winCuttingOrderList.MdiParent = this;
            winCuttingOrderList.StartPosition = FormStartPosition.Manual;
            winCuttingOrderList.Show();
        }

        private void TITAN_Click(object sender, EventArgs e)
        {
            frmCuttingOrderList winCuttingOrderList = new frmCuttingOrderList(3027, false);
            winCuttingOrderList.MdiParent = this;
            winCuttingOrderList.StartPosition = FormStartPosition.Manual;
            winCuttingOrderList.Show();
        }

        private void ATLAS_Click(object sender, EventArgs e)
        {
            frmCuttingOrderList winCuttingOrderList = new frmCuttingOrderList(10, false);
            winCuttingOrderList.MdiParent = this;
            winCuttingOrderList.StartPosition = FormStartPosition.Manual;
            winCuttingOrderList.Show();
        }

        private void objetivoDeOrdenesDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesOrderObjetive generateNewReport = new frmSalesOrderObjetive();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void stockPalletsScrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScrapPalletStockReport generateNewReport = new frmScrapPalletStockReport();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }


        private void swapMateriaPrimaEntreBodegasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInterCellarMovement generateNewReport = new frmInterCellarMovement();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void swapReportToolStripMenuItem_click(object sender, EventArgs e)
        {
            frmSwapReport generateNewReport = new frmSwapReport();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }
        

        private void reportesDePalletsDeMermaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScrapPalletReport generateNewReport = new frmScrapPalletReport();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void estadoDeDepositoMP_Click(object sender, EventArgs e)
        {
            frmRawMaterialDepositState generateNewReport = new frmRawMaterialDepositState();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void reportedespachos_Click(object sender, EventArgs e)
        {
            frmShippingReport winShipping = new frmShippingReport();
            winShipping.MdiParent = this;
            winShipping.StartPosition = FormStartPosition.CenterScreen;
            winShipping.Show();
        }

        private void QualityControls_Click(object sender, EventArgs e)
        {
            frmQualityControls winShipping = new frmQualityControls();
            winShipping.MdiParent = this;
            winShipping.StartPosition = FormStartPosition.CenterScreen;
            winShipping.Show();
        }

        private void MainCoilQualityControls_Click(object sender, EventArgs e)
        {
            frmMainCoilsControl winShipping = new frmMainCoilsControl();
            winShipping.MdiParent = this;
            winShipping.StartPosition = FormStartPosition.CenterScreen;
            winShipping.Show();
        }

        private void ingresoDeEmpaqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPalletReport winShipping = new frmPalletReport();
            winShipping.MdiParent = this;
            winShipping.StartPosition = FormStartPosition.CenterScreen;
            winShipping.Show();
        }


        private void QualityControlsByFilm_Click(object sender, EventArgs e)
        {
            frmControlPlan winShipping = new frmControlPlan();
            winShipping.MdiParent = this;
            winShipping.StartPosition = FormStartPosition.CenterScreen;
            winShipping.Show();
        }

        private void balanceDeMasasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMassBalance winShipping = new frmMassBalance();
            winShipping.MdiParent = this;
            winShipping.StartPosition = FormStartPosition.CenterScreen;
            winShipping.Show();
        }

        private void controlDeRolloMadreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainCoilsControl winShipping = new frmMainCoilsControl();
            winShipping.MdiParent = this;
            winShipping.StartPosition = FormStartPosition.CenterScreen;
            winShipping.Show();
        }

        private void nuevoCertificadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewCertificate winExportPalletShipping = new frmNewCertificate();
            winExportPalletShipping.StartPosition = FormStartPosition.CenterScreen;
            winExportPalletShipping.MdiParent = this;
            winExportPalletShipping.Show();
        }

        private void tsmActiveCuttingOrderSummary_Click(object sender, EventArgs e)
        {

        }

        private void kPIsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKpis winExportPalletShipping = new frmKpis();
            winExportPalletShipping.StartPosition = FormStartPosition.CenterScreen;
            winExportPalletShipping.MdiParent = this;
            winExportPalletShipping.Show();
        }

        private void tsmPaperNew_Click(object sender, EventArgs e)
        {

        }

        private void controlDePDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewPreShippingControl winExportPalletShipping = new frmNewPreShippingControl();
            winExportPalletShipping.StartPosition = FormStartPosition.CenterScreen;
            winExportPalletShipping.MdiParent = this;
            winExportPalletShipping.Show();
        }

        private void controlDePDNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewPreShippingControl winExportPalletShipping = new frmNewPreShippingControl();
            winExportPalletShipping.StartPosition = FormStartPosition.CenterScreen;
            winExportPalletShipping.MdiParent = this;
            winExportPalletShipping.Show();
        }

        private void listadoDePDSistemaNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewPreShippingList predespacholist = new frmNewPreShippingList();
            predespacholist.StartPosition = FormStartPosition.CenterScreen;
            predespacholist.MdiParent = this;
            predespacholist.Show();
        }

        private void reporteOTIFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOTIFReport reporteDespachos = new frmOTIFReport();
            reporteDespachos.MdiParent = this;
            reporteDespachos.StartPosition = FormStartPosition.Manual;
            reporteDespachos.Show();
        }
        
        private void panelDeControlToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmControlPanel predespacholist = new frmControlPanel();
            predespacholist.StartPosition = FormStartPosition.CenterScreen;
            predespacholist.MdiParent = this;
            predespacholist.Show();
        }

        private void oTIFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOTIFReport reporteDespachos = new frmOTIFReport();
            reporteDespachos.MdiParent = this;
            reporteDespachos.StartPosition = FormStartPosition.Manual;
            reporteDespachos.Show();
        }

        private void pruebaControlDeProdPorTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductionControlPerTurn reporteProd = new frmProductionControlPerTurn();
            reporteProd.MdiParent = this;
            reporteProd.StartPosition = FormStartPosition.Manual;
            reporteProd.Show();
        }

        private void pruebaControlDeProdPorFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductionControlPerDate reporteProd = new frmProductionControlPerDate();
            reporteProd.MdiParent = this;
            reporteProd.StartPosition = FormStartPosition.Manual;
            reporteProd.Show();
        }

        private void tsmCuttingOrderList_Click(object sender, EventArgs e)
        {

        }

        private void pruebaFormulacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFormulationBopp form = new frmFormulationBopp();
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.Manual;
            form.Show();
        }

        private void tsmMainCoilQuality_Click(object sender, EventArgs e)
        {

        }

        private void pruebaListadoFormulacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewFormulationList form = new frmNewFormulationList();
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.Manual;
            form.Show();
        }

        private void pruebaOrdenesDeExtrusionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewExtrusionOrder form = new frmNewExtrusionOrder();
            form.MdiParent = this;
            form.StartPosition = FormStartPosition.Manual;
            form.Show();
        }

        private void historialDeRackPrimarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRackHistory winMainCoilStock = new frmRackHistory();
            winMainCoilStock.StartPosition = FormStartPosition.Manual;
            winMainCoilStock.MdiParent = this;
            winMainCoilStock.Show();
        }

        private void historialDeDepositoDeBobinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCoilHistory form = new frmCoilHistory();
            form.StartPosition = FormStartPosition.Manual;
            form.MdiParent = this;
            form.Show();
        }

        private void historialDeRackSecundarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSecundaryRackHistory form = new frmSecundaryRackHistory();
            form.StartPosition = FormStartPosition.Manual;
            form.MdiParent = this;
            form.Show();
        }

        private void historialDeDepositoDeMateriaPrimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRawDepotHistory form = new frmRawDepotHistory();
            form.StartPosition = FormStartPosition.Manual;
            form.MdiParent = this;
            form.Show();
        }

        private void historialDeDepositoDePalletsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPalletDepotHistory form = new frmPalletDepotHistory();
            form.StartPosition = FormStartPosition.Manual;
            form.MdiParent = this;
            form.Show();
        }

        private void pruebaListaOrdenDeCorteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuttingOrderListSelector form = new frmCuttingOrderListSelector();
            form.StartPosition = FormStartPosition.Manual;
            form.MdiParent = this;
            form.Show();
        }

        private void planDeCorteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCuttingPlan form = new frmCuttingPlan();
            form.StartPosition = FormStartPosition.Manual;
            form.MdiParent = this;
            form.Show();
        }

        private void balanceDeMasasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMassBalance form = new frmMassBalance();
            form.StartPosition = FormStartPosition.Manual;
            form.MdiParent = this;
            form.Show();
        }

        private void listaDeEmpaqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaEmpaque form = new frmListaEmpaque();
            form.StartPosition = FormStartPosition.Manual;
            form.MdiParent = this;
            form.Show();
        }

        private void nuevoPedidoExpoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPedidoExpo form = new frmPedidoExpo();
            form.StartPosition = FormStartPosition.Manual;
            form.MdiParent = this;
            form.Show();
        }

        private void reporteDespachosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShippingReport reporteDespachos = new frmShippingReport();
            reporteDespachos.MdiParent = this;
            reporteDespachos.StartPosition = FormStartPosition.Manual;
            reporteDespachos.Show();
        }

        private void reporteOTIFToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmOTIFReport reporteDespachos = new frmOTIFReport();
            reporteDespachos.MdiParent = this;
            reporteDespachos.StartPosition = FormStartPosition.Manual;
            reporteDespachos.Show();
        }
    }
}