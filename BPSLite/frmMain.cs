using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS.Lite
{
    public partial class frmMain : Form
    {
        List<Button> lstButton = new List<Button>();

        public frmMain()
        {
            frmLogin winLogin = new frmLogin();
            winLogin.ShowDialog();
            clsGlobal.Company.load(2);
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            List<clsMachine> lstMachine = clsMachine.getCutterMachineList();
            lstButton = new List<Button>();
            if (clsGlobal.LoggedUser.RoleName == "Empacador")
            {
                for (int i = 0; i < lstMachine.Count; i++)
                {
                    lstButton.Add(new Button());
                    lstButton[i].Image = global::BPS.Lite.Properties.Resources.add_coil24;
                    lstButton[i].Location = new System.Drawing.Point(12, 12 + (i * 77));
                    lstButton[i].Name = "btnCutter" + lstMachine[i].codsec.ToString();
                    lstButton[i].Size = new System.Drawing.Size(70, 65);
                    lstButton[i].TabIndex = i;
                    lstButton[i].Text = lstMachine[i].Cutter.name;
                    lstButton[i].TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                    lstButton[i].UseVisualStyleBackColor = true;
                    lstButton[i].Tag = lstMachine[i].codsec;
                    lstButton[i].Click += new System.EventHandler(this.btnCutter_Click);
                    movimientosTSMLog.Visible = false;
                    reporteDeMetalizadoTSMItem.Visible = false;
                    tsmInProcessCoils.Visible = false;
                    tsmOrderList_PL.Visible = false;
                    tsmCoils_PL.Visible = false;
                    pnlShortCut.Controls.Add(lstButton[i]);
                }
            }
            else if (clsGlobal.LoggedUser.RoleName == "Apilador")
            {
                pnlShortCut.Visible = true;
                detalleDePalletToolStripMenuItem.Visible = false;
                digitaciónToolStripMenuItem.Visible = false;
                detalleToolStripMenuItem.Visible = false;
                movimientosTSMLog.Visible = false;
                tsmOrderList_PL.Visible = false;
                tsmCoils_PL.Visible = false;
                pnlShortCut.Size = new System.Drawing.Size(70, 422);
                /*frmCoilCellarMovementsA winCoilCellarMovements = new frmCoilCellarMovementsA();
                winCoilCellarMovements.MdiParent = this;
                winCoilCellarMovements.StartPosition = FormStartPosition.WindowsDefaultLocation;
                winCoilCellarMovements.MaximizeBox = false;
                reporteDeMetalizadoTSMItem.Visible = false;
                tsmInProcessCoils.Visible = false;
                winCoilCellarMovements.Show();*/

                Button btnCellarMovements = new Button();

                btnCellarMovements.Image = global::BPS.Lite.Properties.Resources.Raw;
                btnCellarMovements.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
                btnCellarMovements.Location = new System.Drawing.Point(2, 12 + (0 * 70));
                btnCellarMovements.Name = "btnCellarMovements";
                btnCellarMovements.Size = new System.Drawing.Size(65, 60);
                btnCellarMovements.TabIndex = 0;
                btnCellarMovements.Text = "Movimientos";
                //btnCellarMovements.Text = "Ingresos";
                btnCellarMovements.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnCellarMovements.UseVisualStyleBackColor = true;
                //btnCellarMovements.Click += new System.EventHandler(this.btnCellarMovements_Click);
                btnCellarMovements.Click += new System.EventHandler(movimientoDePalletInterplantaToolStripMenuItem_Click);
                
                pnlShortCut.Controls.Add(btnCellarMovements);

                Button btnDepotOut = new Button();
                btnDepotOut.Image = global::BPS.Lite.Properties.Resources.RawOut;
                btnDepotOut.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                btnDepotOut.Location = new System.Drawing.Point(2, 24 + (1 * 70));
                btnDepotOut.Name = "btnBL";
                btnDepotOut.Size = new System.Drawing.Size(65, 60);
                btnDepotOut.TabIndex = 1;
                btnDepotOut.Text = "Reasignar";
                //btnDepotOut.Text = "Egresos";
                btnDepotOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnDepotOut.UseVisualStyleBackColor = true;
                //btnDepotOut.Click += new System.EventHandler(this.btnDepotOut_Click);
                btnDepotOut.Click += new System.EventHandler(asignacionDePosicionTooStripMenuItem_Click);
                pnlShortCut.Controls.Add(btnDepotOut);

            }
            else if (clsGlobal.LoggedUser.RoleName == "Supervisor de corte")
            {

                pnlShortCut.Visible = false;
                detalleDePalletToolStripMenuItem.Visible = false;
                digitaciónToolStripMenuItem.Visible = false;
                detalleToolStripMenuItem.Visible = false;
                movimientosTSMLog.Visible = false;

                #region Digitacion

                ToolStripMenuItem Digitacion = new ToolStripMenuItem();
                Digitacion.Text = "Digitación";
                Digitacion.Image = Properties.Resources.server;
                mnu.Items.Add(Digitacion);

                ToolStripMenuItem lstOrdenes = new ToolStripMenuItem();
                lstOrdenes.Text = "Listado de Ordenes";
                lstOrdenes.Image = Properties.Resources.page_coils;
                Digitacion.DropDownItems.Add(lstOrdenes);

                ToolStripMenuItem atlasCamp = new ToolStripMenuItem();
                atlasCamp.Text = "Atlas";
                atlasCamp.Image = Properties.Resources.gear_16;
                atlasCamp.Click += new EventHandler(atlasToolStripMenuItem2_Click);
                lstOrdenes.DropDownItems.Add(atlasCamp);

                ToolStripMenuItem c230 = new ToolStripMenuItem();
                c230.Text = "C230";
                c230.Image = Properties.Resources.gear_16;
                c230.Click += new EventHandler(c230ToolStripMenuItem2_Click);
                lstOrdenes.DropDownItems.Add(c230);

                ToolStripMenuItem c231 = new ToolStripMenuItem();
                c231.Text = "C231";
                c231.Image = Properties.Resources.gear_16;
                c231.Click += new EventHandler(c231ToolStripMenuItem2_Click);
                lstOrdenes.DropDownItems.Add(c231);

                ToolStripMenuItem c232 = new ToolStripMenuItem();
                c232.Text = "C232";
                c232.Image = Properties.Resources.gear_16;
                c232.Click += new EventHandler(c232ToolStripMenuItem2_Click);
                lstOrdenes.DropDownItems.Add(c232);

                ToolStripMenuItem bobinas = new ToolStripMenuItem();
                bobinas.Image = Properties.Resources.coils;
                bobinas.Text = "Bobinas";
                Digitacion.DropDownItems.Add(bobinas);

                ToolStripMenuItem goebelB = new ToolStripMenuItem();
                goebelB.Text = "Atlas";
                goebelB.Image = Properties.Resources.gear_16;
                goebelB.Click += new EventHandler(goebelToolStripMenuItem2_Click);
                bobinas.DropDownItems.Add(goebelB);

                ToolStripMenuItem c230Cmp = new ToolStripMenuItem();
                c230Cmp.Text = "C230";
                c230Cmp.Image = Properties.Resources.gear_16;
                c230Cmp.Click += new EventHandler(atlasCampanaToolStripMenuItem_Click);
                bobinas.DropDownItems.Add(c230Cmp);

                ToolStripMenuItem c231cmp = new ToolStripMenuItem();
                c231cmp.Text = "C231";
                c231cmp.Image = Properties.Resources.gear_16;
                c231cmp.Click += new EventHandler(c231ToolStripMenuItem1_Click_1);
                bobinas.DropDownItems.Add(c231cmp);

                ToolStripMenuItem c232cmp = new ToolStripMenuItem();
                c232cmp.Text = "C232";
                c232cmp.Image = Properties.Resources.gear_16;
                c232cmp.Click += new EventHandler(c232ToolStripMenuItem1_Click_1);
                bobinas.DropDownItems.Add(c232cmp);

                ToolStripMenuItem CombCS = new ToolStripMenuItem();
                CombCS.Text = "Combinacion de Corte Secundario";
                CombCS.Image = Properties.Resources.coilSecundaryCut;
                CombCS.Click += new EventHandler(combinacionesCorteSecundarioToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(CombCS);

                ToolStripMenuItem rebobinado = new ToolStripMenuItem();
                rebobinado.Text = "Rebobinado";
                rebobinado.Image = Properties.Resources.rewind;
                rebobinado.Click += new EventHandler(rebobinadoToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(rebobinado);

                ToolStripMenuItem regBobReproc = new ToolStripMenuItem();
                regBobReproc.Text = "Registro de Bobinas para Reproceso";
                regBobReproc.Image = Properties.Resources.reprocess2;
                regBobReproc.Click += new EventHandler(registroDeBobinasParaReprocesoToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(regBobReproc);

                ToolStripMenuItem reetiquetadopeliculasEquiv = new ToolStripMenuItem();
                reetiquetadopeliculasEquiv.Text = "Re-etiquetado peliculas equivalente";
                reetiquetadopeliculasEquiv.Image = Properties.Resources.printer;
                reetiquetadopeliculasEquiv.Click += new EventHandler(reetiquetadoDePeliculaEquivalenteToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(reetiquetadopeliculasEquiv);

                ToolStripMenuItem reetiquetadoStock = new ToolStripMenuItem();
                reetiquetadoStock.Text = "Re-etiquetado a Stock";
                reetiquetadoStock.Image = Properties.Resources.printer;
                reetiquetadoStock.Click += new EventHandler(reetiquetadoAStockToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(reetiquetadoStock);

                ToolStripMenuItem metalizado = new ToolStripMenuItem();
                metalizado.Text = "Metalizado (Sistema Viejo)";
                metalizado.Image = Properties.Resources.coils;
                metalizado.Click += new EventHandler(btnMetlizedOrder_Click);
                Digitacion.DropDownItems.Add(metalizado);

                //ToolStripMenuItem nuevoMetalizado = new ToolStripMenuItem();
                //nuevoMetalizado.Text = "Metalizado (Sistema Nuevo)";
                //nuevoMetalizado.Image = Properties.Resources.coils;
                //nuevoMetalizado.Click += new EventHandler(btnNewMetlizedOrder_Click);
                //Digitacion.DropDownItems.Add(nuevoMetalizado);

                ToolStripMenuItem pallets = new ToolStripMenuItem();
                pallets.Text = "Pallets";
                pallets.Image = Properties.Resources.pallet;
                pallets.Click += new EventHandler(palletsToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(pallets);

                ToolStripMenuItem mermas = new ToolStripMenuItem();
                mermas.Text = "Notificacion de Mermas";
                mermas.Image = Properties.Resources.coilMill;
                mermas.Click += new EventHandler(scrapToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(mermas);

                ToolStripMenuItem scrap = new ToolStripMenuItem();
                scrap.Text = "Envío de Materiales al Molino";
                scrap.Image = Properties.Resources.Mill;
                scrap.Click += new EventHandler(envioMAteriaToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(scrap);
                
                #endregion

                #region Detalle

                ToolStripMenuItem detalle = new ToolStripMenuItem();
                detalle.Text = "Detalle";
                detalle.Image = Properties.Resources.clipboard_text;
                mnu.Items.Add(detalle);

                ToolStripMenuItem estadoDeDepot = new ToolStripMenuItem();
                estadoDeDepot.Text = "Inventario Completo de Pallets";
                estadoDeDepot.Image = Properties.Resources.storage2;
                estadoDeDepot.Click += new EventHandler(EstadoDeDeposito_Click);
                detalle.DropDownItems.Add(estadoDeDepot);

                ToolStripMenuItem estadoDeDepotOP1 = new ToolStripMenuItem();
                estadoDeDepotOP1.Text = "Inventario Completo de Bobinas";
                estadoDeDepotOP1.Image = Properties.Resources.storage2;
                estadoDeDepotOP1.Click += new EventHandler(stockOP1ToolStripMenuItem_Click);
                detalle.DropDownItems.Add(estadoDeDepotOP1);

                ToolStripMenuItem estadobobsue = new ToolStripMenuItem();
                estadobobsue.Text = "Inventario Bobinas Sueltas";
                estadobobsue.Image = Properties.Resources.page_coils;
                estadobobsue.Click += new EventHandler(inventarioDeBobinasSueltasToolStripMenuItem_Click);
                detalle.DropDownItems.Add(estadobobsue);

                ToolStripMenuItem estadoRackCP = new ToolStripMenuItem();
                estadoRackCP.Text = "Estado de Rack Cortadora Primaria";
                estadoRackCP.Image = Properties.Resources.page_coils;
                estadoRackCP.Click += new EventHandler(estadoDeRackCortadoraPrimariaToolStripMenuItem_Click);
                detalle.DropDownItems.Add(estadoRackCP);

                ToolStripMenuItem rackMet = new ToolStripMenuItem();
                rackMet.Text = "Rack de Metalizado";
                rackMet.Image = Properties.Resources.coils;
                rackMet.Click += new EventHandler(bobinasColgantesToolStripMenuItem_Click);
                detalle.DropDownItems.Add(rackMet);

                ToolStripMenuItem stockPalletScrap = new ToolStripMenuItem();
                stockPalletScrap.Text = "Stock de Pallets de Merma";
                stockPalletScrap.Image = Properties.Resources.box;
                stockPalletScrap.Click += new EventHandler(stockPalletsScrapToolStripMenuItem_Click);
                detalle.DropDownItems.Add(stockPalletScrap);

                ToolStripMenuItem palletDtl = new ToolStripMenuItem();
                palletDtl.Text = "Detalle de Pallet";
                palletDtl.Image = Properties.Resources.pallet;
                palletDtl.Click += new EventHandler(btnPallet_Click);
                detalle.DropDownItems.Add(palletDtl);

                ToolStripMenuItem coilDtl = new ToolStripMenuItem();
                coilDtl.Text = "Detalle de Bobina";
                coilDtl.Image = Properties.Resources.mainCoil;
                coilDtl.Click += new EventHandler(btnCoil_Click);
                detalle.DropDownItems.Add(coilDtl);



                #endregion

                #region Supervision

                ToolStripMenuItem supervision = new ToolStripMenuItem();
                supervision.Text = "Supervisión";
                supervision.Image = Properties.Resources.eye;
                mnu.Items.Add(supervision);

                ToolStripMenuItem reports = new ToolStripMenuItem();
                reports.Text = "Reportes";
                reports.Image = Properties.Resources.report;
                supervision.DropDownItems.Add(reports);

                ToolStripMenuItem cutReport = new ToolStripMenuItem();
                cutReport.Text = "Reporte de Corte";
                cutReport.Click += new EventHandler(reporteDeCorteToolStripMenuItem_Click);
                cutReport.Image = Properties.Resources.reportOff;
                reports.DropDownItems.Add(cutReport);

                ToolStripMenuItem metallizedReport = new ToolStripMenuItem();
                metallizedReport.Text = "Reporte de Metalizado";
                metallizedReport.Click += new EventHandler(reporteDeMetalizadoTSMItem_Click);
                metallizedReport.Image = Properties.Resources.reportOff;
                reports.DropDownItems.Add(metallizedReport);

                ToolStripMenuItem rewindReport = new ToolStripMenuItem();
                rewindReport.Text = "Reporte de Rebobinado";
                rewindReport.Click += new EventHandler(reporteDeRebobinadoToolStripMenuItem_Click);
                rewindReport.Image = Properties.Resources.reportOff;
                reports.DropDownItems.Add(rewindReport);

                ToolStripMenuItem scrapReport = new ToolStripMenuItem();
                scrapReport.Text = "Reporte de Pallets de Merma";
                scrapReport.Click += new EventHandler(reportesDePalletsDeMermaToolStripMenuItem_Click);
                scrapReport.Image = Properties.Resources.reportOff;
                reports.DropDownItems.Add(scrapReport);

                ToolStripMenuItem scrapMovHistory = new ToolStripMenuItem();
                scrapMovHistory.Text = "Reporte Movimiento de Mermas";
                scrapMovHistory.Click += new EventHandler(movimientosDeScrapToolStripMenuItem_Click);
                scrapMovHistory.Image = Properties.Resources.reportOff;
                reports.DropDownItems.Add(scrapMovHistory);

                ToolStripMenuItem healerForm = new ToolStripMenuItem();
                healerForm.Text = "Revivir/Eliminar Bobinas Hijas";
                healerForm.Click += new EventHandler(reviveOrKillCoilToolStripMenuItem_Click);
                healerForm.Image = Properties.Resources.coils;
                supervision.DropDownItems.Add(healerForm);

                ToolStripMenuItem ocmReport = new ToolStripMenuItem();
                ocmReport.Text = "Reporte Condiciones Operativas Metalizado";
                ocmReport.Click += new EventHandler(pruebaCondicionesOperativasMetReportesToolStripMenuItem_Click);
                ocmReport.Image = Properties.Resources.reportOff;
                supervision.DropDownItems.Add(ocmReport);
                #endregion

            }
            //Rol de Supervisores PILAR
            else if (clsGlobal.LoggedUser.RoleName == "Supervisor Pilar")
            {
                pnlShortCut.Visible = false;
                detalleDePalletToolStripMenuItem.Visible = false;
                digitaciónToolStripMenuItem.Visible = false;
                detalleToolStripMenuItem.Visible = false;
                movimientosTSMLog.Visible = false;

                #region Digitacion

                ToolStripMenuItem Digitacion = new ToolStripMenuItem();
                Digitacion.Text = "Digitación";
                Digitacion.Image = Properties.Resources.server;
                mnu.Items.Add(Digitacion);

                ToolStripMenuItem lstOrdenes = new ToolStripMenuItem();
                lstOrdenes.Text = "Listado de Ordenes";
                lstOrdenes.Image = Properties.Resources.page_coils;
                Digitacion.DropDownItems.Add(lstOrdenes);

                ToolStripMenuItem goebel = new ToolStripMenuItem();
                goebel.Text = "Goebel";
                goebel.Image = Properties.Resources.gear_16;
                goebel.Click += new EventHandler(goebelToolStripMenuItem_Click);
                lstOrdenes.DropDownItems.Add(goebel);

                ToolStripMenuItem atlas = new ToolStripMenuItem();
                atlas.Text = "Atlas";
                atlas.Image = Properties.Resources.gear_16;
                atlas.Click += new EventHandler(atlasToolStripMenuItem1_Click_1);
                lstOrdenes.DropDownItems.Add(atlas);

                ToolStripMenuItem titan = new ToolStripMenuItem();
                titan.Text = "Titan";
                titan.Image = Properties.Resources.gear_16;
                titan.Click += new EventHandler(titanToolStripMenuItem_Click);
                lstOrdenes.DropDownItems.Add(titan);

                ToolStripMenuItem bobinas = new ToolStripMenuItem();
                bobinas.Image = Properties.Resources.coils;
                bobinas.Text = "Bobinas";
                Digitacion.DropDownItems.Add(bobinas);

                ToolStripMenuItem goebelB = new ToolStripMenuItem();
                goebelB.Text = "Goebel";
                goebelB.Image = Properties.Resources.gear_16;
                goebelB.Click += new EventHandler(goebelToolStripMenuItem3_Click);
                bobinas.DropDownItems.Add(goebelB);

                ToolStripMenuItem AtlasB = new ToolStripMenuItem();
                AtlasB.Text = "Atlas";
                AtlasB.Image = Properties.Resources.gear_16;
                AtlasB.Click += new EventHandler(atlasPilarToolStripMenuItem_Click);
                bobinas.DropDownItems.Add(AtlasB);

                ToolStripMenuItem TitanB = new ToolStripMenuItem();
                TitanB.Text = "Titan";
                TitanB.Image = Properties.Resources.gear_16;
                TitanB.Click += new EventHandler(titanToolStripMenuItem2_Click);
                bobinas.DropDownItems.Add(TitanB);

                ToolStripMenuItem CombCS = new ToolStripMenuItem();
                CombCS.Text = "Combinacion de Corte Secundario";
                CombCS.Image = Properties.Resources.coilSecundaryCut;
                CombCS.Click += new EventHandler(combinacionesCorteSecundarioToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(CombCS);

                ToolStripMenuItem rebobinado = new ToolStripMenuItem();
                rebobinado.Text = "Rebobinado";
                rebobinado.Image = Properties.Resources.rewind;
                rebobinado.Click += new EventHandler(rebobinadoToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(rebobinado);

                ToolStripMenuItem regBobReproc = new ToolStripMenuItem();
                regBobReproc.Text = "Registro de Bobinas para Reproceso";
                regBobReproc.Image = Properties.Resources.reprocess2;
                regBobReproc.Click += new EventHandler(registroDeBobinasParaReprocesoToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(regBobReproc);

                ToolStripMenuItem reetiquetadopeliculasEquiv = new ToolStripMenuItem();
                reetiquetadopeliculasEquiv.Text = "Re-etiquetado peliculas equivalente";
                reetiquetadopeliculasEquiv.Image = Properties.Resources.printer;
                reetiquetadopeliculasEquiv.Click += new EventHandler(reetiquetadoDePeliculaEquivalenteToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(reetiquetadopeliculasEquiv);

                ToolStripMenuItem reetiquetadoStock = new ToolStripMenuItem();
                reetiquetadoStock.Text = "Re-etiquetado a Stock";
                reetiquetadoStock.Image = Properties.Resources.printer;
                reetiquetadoStock.Click += new EventHandler(reetiquetadoAStockToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(reetiquetadoStock);

                ToolStripMenuItem metalizado = new ToolStripMenuItem();
                metalizado.Text = "Metalizado";
                metalizado.Image = Properties.Resources.coils;
                metalizado.Click += new EventHandler(btnMetlizedOrder_Click);
                Digitacion.DropDownItems.Add(metalizado);
                
                //ToolStripMenuItem newmetalizado = new ToolStripMenuItem();
                //newmetalizado.Text = "Metalizado (Sistema Nuevo)";
                //newmetalizado.Image = Properties.Resources.coils;
                //newmetalizado.Click += new EventHandler(btnNewMetlizedOrder_Click);
                //Digitacion.DropDownItems.Add(newmetalizado);

                ToolStripMenuItem pallets = new ToolStripMenuItem();
                pallets.Text = "Pallets";
                pallets.Image = Properties.Resources.pallet;
                pallets.Click += new EventHandler(palletsToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(pallets);

                ToolStripMenuItem mermas = new ToolStripMenuItem();
                mermas.Text = "Notificacion de Mermas";
                mermas.Image = Properties.Resources.coilMill;
                mermas.Click += new EventHandler(scrapToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(mermas);

                ToolStripMenuItem envioMermas = new ToolStripMenuItem();
                envioMermas.Text = "Envío de Materiales al Molino";
                envioMermas.Image = Properties.Resources.coilMill;
                envioMermas.Click += new EventHandler(envioMAteriaToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(envioMermas);

                #endregion

                #region Detalle

                ToolStripMenuItem detalle = new ToolStripMenuItem();
                detalle.Text = "Detalle";
                detalle.Image = Properties.Resources.clipboard_text;
                mnu.Items.Add(detalle);

                ToolStripMenuItem estadoDeDepot = new ToolStripMenuItem();
                estadoDeDepot.Text = "Inventario Completo de Pallets";
                estadoDeDepot.Image = Properties.Resources.storage2;
                estadoDeDepot.Click += new EventHandler(EstadoDeDeposito_Click);
                detalle.DropDownItems.Add(estadoDeDepot);

                ToolStripMenuItem estadoDeDepotOP1 = new ToolStripMenuItem();
                estadoDeDepotOP1.Text = "Inventario Completo de Bobinas";
                estadoDeDepotOP1.Image = Properties.Resources.storage2;
                estadoDeDepotOP1.Click += new EventHandler(stockOP1ToolStripMenuItem_Click);
                detalle.DropDownItems.Add(estadoDeDepotOP1);

                ToolStripMenuItem estadobobsue = new ToolStripMenuItem();
                estadobobsue.Text = "Inventario Bobinas Sueltas";
                estadobobsue.Image = Properties.Resources.page_coils;
                estadobobsue.Click += new EventHandler(inventarioDeBobinasSueltasToolStripMenuItem_Click);
                detalle.DropDownItems.Add(estadobobsue);

                ToolStripMenuItem estadoRackCP = new ToolStripMenuItem();
                estadoRackCP.Text = "Estado de Rack Cortadora Primaria";
                estadoRackCP.Image = Properties.Resources.page_coils;
                estadoRackCP.Click += new EventHandler(estadoDeRackCortadoraPrimariaToolStripMenuItem_Click);
                detalle.DropDownItems.Add(estadoRackCP);

                ToolStripMenuItem rackMet = new ToolStripMenuItem();
                rackMet.Text = "Rack de Metalizado";
                rackMet.Image = Properties.Resources.coils;
                rackMet.Click += new EventHandler(estadoDeToolStripMenuItem_Click);
                detalle.DropDownItems.Add(rackMet);

                ToolStripMenuItem stockPalletScrap = new ToolStripMenuItem();
                stockPalletScrap.Text = "Stock de Pallets de Merma";
                stockPalletScrap.Image = Properties.Resources.box;
                stockPalletScrap.Click += new EventHandler(stockPalletsScrapToolStripMenuItem_Click);
                detalle.DropDownItems.Add(stockPalletScrap);

                ToolStripMenuItem palletDtl = new ToolStripMenuItem();
                palletDtl.Text = "Detalle de Pallet";
                palletDtl.Image = Properties.Resources.pallet;
                palletDtl.Click += new EventHandler(btnPallet_Click);
                detalle.DropDownItems.Add(palletDtl);

                ToolStripMenuItem coilDtl = new ToolStripMenuItem();
                coilDtl.Text = "Detalle de Bobina";
                coilDtl.Image = Properties.Resources.mainCoil;
                coilDtl.Click += new EventHandler(btnCoil_Click);
                detalle.DropDownItems.Add(coilDtl);



                #endregion

                #region Supervision

                ToolStripMenuItem supervision = new ToolStripMenuItem();
                supervision.Text = "Supervisión";
                supervision.Image = Properties.Resources.eye;
                mnu.Items.Add(supervision);

                ToolStripMenuItem reports = new ToolStripMenuItem();
                reports.Text = "Reportes";
                reports.Image = Properties.Resources.report;
                supervision.DropDownItems.Add(reports);

                ToolStripMenuItem cutReport = new ToolStripMenuItem();
                cutReport.Text = "Reporte de Corte";
                cutReport.Click += new EventHandler(reporteDeCorteToolStripMenuItem_Click);
                cutReport.Image = Properties.Resources.reportOff;
                reports.DropDownItems.Add(cutReport);

                ToolStripMenuItem metallizedReport = new ToolStripMenuItem();
                metallizedReport.Text = "Reporte de Metalizado";
                metallizedReport.Click += new EventHandler(reporteDeMetalizadoTSMItem_Click);
                metallizedReport.Image = Properties.Resources.reportOff;
                reports.DropDownItems.Add(metallizedReport);

                ToolStripMenuItem metallizedReport2 = new ToolStripMenuItem();
                metallizedReport2.Text = "Reporte de Metalizado con condiciones operativas";
                metallizedReport2.Click += new EventHandler(pruebaCondicionesOperativasMetReportesToolStripMenuItem_Click);
                metallizedReport2.Image = Properties.Resources.reportOff;
                reports.DropDownItems.Add(metallizedReport2);

                

                ToolStripMenuItem rewindReport = new ToolStripMenuItem();
                rewindReport.Text = "Reporte de Rebobinado";
                rewindReport.Click += new EventHandler(reporteDeRebobinadoToolStripMenuItem_Click);
                rewindReport.Image = Properties.Resources.reportOff;
                reports.DropDownItems.Add(rewindReport);

                ToolStripMenuItem scrapReport = new ToolStripMenuItem();
                scrapReport.Text = "Reporte de Pallets de Merma";
                scrapReport.Click += new EventHandler(reportesDePalletsDeMermaToolStripMenuItem_Click);
                scrapReport.Image = Properties.Resources.reportOff;
                reports.DropDownItems.Add(scrapReport);

                ToolStripMenuItem scrapMovHistory = new ToolStripMenuItem();
                scrapMovHistory.Text = "Reporte Movimiento de Mermas";
                scrapMovHistory.Click += new EventHandler(movimientosDeScrapToolStripMenuItem_Click);
                scrapMovHistory.Image = Properties.Resources.reportOff;
                reports.DropDownItems.Add(scrapMovHistory);

                ToolStripMenuItem healerForm = new ToolStripMenuItem();
                healerForm.Text = "Revivir/Eliminar Bobinas Hijas";
                healerForm.Click += new EventHandler(reviveOrKillCoilToolStripMenuItem_Click);
                healerForm.Image = Properties.Resources.coils;
                supervision.DropDownItems.Add(healerForm);

                ToolStripMenuItem prodcont = new ToolStripMenuItem();
                prodcont.Text = "Control de resultados entre fechas";
                prodcont.Click += new EventHandler(prodcontToolStripMenuItem_Click);
                prodcont.Image = Properties.Resources.coils;
                supervision.DropDownItems.Add(prodcont);

                ToolStripMenuItem prodcont2 = new ToolStripMenuItem();
                prodcont2.Text = "Control de resultados por turno";
                prodcont2.Click += new EventHandler(prodcont2ToolStripMenuItem_Click);
                prodcont2.Image = Properties.Resources.coils;
                supervision.DropDownItems.Add(prodcont2);

                #endregion

            }
            else if (clsGlobal.LoggedUser.RoleName == "Recursos Humanos")
            {
                pnlShortCut.Visible = false;
                detalleDePalletToolStripMenuItem.Visible = false;
                digitaciónToolStripMenuItem.Visible = false;
                detalleToolStripMenuItem.Visible = false;
                movimientosTSMLog.Visible = false;

                #region Supervision

                ToolStripMenuItem supervision = new ToolStripMenuItem();
                supervision.Text = "Reportes";
                supervision.Image = Properties.Resources.eye;
                mnu.Items.Add(supervision);

                ToolStripMenuItem prodcont = new ToolStripMenuItem();
                prodcont.Text = "Control de resultados entre fechas";
                prodcont.Click += new EventHandler(prodcontToolStripMenuItem_Click);
                prodcont.Image = Properties.Resources.coils;
                supervision.DropDownItems.Add(prodcont);

                ToolStripMenuItem prodcont2 = new ToolStripMenuItem();
                prodcont2.Text = "Control de resultados por turno";
                prodcont2.Click += new EventHandler(prodcont2ToolStripMenuItem_Click);
                prodcont2.Image = Properties.Resources.coils;
                supervision.DropDownItems.Add(prodcont2);

                #endregion

            }

            else if (clsGlobal.LoggedUser.RoleName == "Cortacores")
            {

                pnlShortCut.Visible = false;
                detalleDePalletToolStripMenuItem.Visible = false;
                digitaciónToolStripMenuItem.Visible = true;
                bobinasToolStripMenuItem.Visible = false;
                atlasToolStripMenuItem.Visible = false;
                c230ToolStripMenuItem.Visible = false;
                c231ToolStripMenuItem.Visible = false;
                c232ToolStripMenuItem.Visible = false;
                palletsToolStripMenuItem.Visible = false;
                rebobinadoToolStripMenuItem.Visible = false;
                metalizadoToolStripMenuItem.Visible = false;
                toolStripMenuItem1.Visible = false;
                registroDeBobinasParaReprocesoToolStripMenuItem.Visible = false;
                movimientosTSMLog.Visible = false;
                tsmInProcessCoils.Visible = false;
                tsmOrderList_PL.Visible = false;
                tsmCoils_PL.Visible = false;
    
            }
            else if (clsGlobal.LoggedUser.RoleName == "Digitador de corte")
            {
               /* pnlShortCut.Visible = false;
                detalleDePalletToolStripMenuItem.Visible = false;
                listadoDeOrdenesToolStripMenuItem.Visible = false;
                c230ToolStripMenuItem.Visible = false;
                c231ToolStripMenuItem.Visible = false;
                c232ToolStripMenuItem.Visible = false;
                rebobinadoToolStripMenuItem.Visible = false;
                metalizadoToolStripMenuItem.Visible = false;
                toolStripMenuItem1.Visible = false;
                registroDeBobinasParaReprocesoToolStripMenuItem.Visible = false;
                estadoDeDepositoToolStripMenuItem.Visible = false;
                stockBobinasMadreToolStripMenuItem.Visible = false;
                stockBobinasMadreMetalizadoToolStripMenuItem.Visible = false;
                reporteDeCorteToolStripMenuItem.Visible = false;
                movimientosTSMLog.Visible = false;
                estadoDeDepositoToolStripMenuItem.Visible = false;
                stockBobinasMadreToolStripMenuItem.Visible = false;
                stockBobinasMadreMetalizadoToolStripMenuItem.Visible = false;
                reporteDeCorteToolStripMenuItem.Visible = false;
                reporteDeMetalizadoTSMItem.Visible = false;
                tsmInProcessCoils.Visible = false;
                tsmOrderList_PL.Visible = false;
                tsmCoils_PL.Visible = false;*/

                pnlShortCut.Visible = false;
                detalleDePalletToolStripMenuItem.Visible = false;
                digitaciónToolStripMenuItem.Visible = false;
                detalleToolStripMenuItem.Visible = false;
                movimientosTSMLog.Visible = false;

                #region Digitacion

                ToolStripMenuItem Digitacion = new ToolStripMenuItem();
                Digitacion.Text = "Digitación";
                Digitacion.Image = Properties.Resources.server;
                mnu.Items.Add(Digitacion);

                ToolStripMenuItem lstOrdenes = new ToolStripMenuItem();
                lstOrdenes.Text = "Listado de Ordenes";
                lstOrdenes.Image = Properties.Resources.page_coils;
                Digitacion.DropDownItems.Add(lstOrdenes);

                ToolStripMenuItem atlas = new ToolStripMenuItem();
                atlas.Text = "Atlas - Campana";
                atlas.Image = Properties.Resources.gear_16;
                atlas.Click += new EventHandler(atlasToolStripMenuItem2_Click);
                lstOrdenes.DropDownItems.Add(atlas);

                ToolStripMenuItem bobinas = new ToolStripMenuItem();
                bobinas.Image = Properties.Resources.coils;
                bobinas.Text = "Bobinas";
                Digitacion.DropDownItems.Add(bobinas);

                ToolStripMenuItem AtlasB = new ToolStripMenuItem();
                AtlasB.Text = "Atlas - Campana";
                AtlasB.Image = Properties.Resources.gear_16;
                AtlasB.Click += new EventHandler(goebelToolStripMenuItem2_Click);
                bobinas.DropDownItems.Add(AtlasB);

                ToolStripMenuItem CombCS = new ToolStripMenuItem();
                CombCS.Text = "Combinacion de Corte Secundario";
                CombCS.Image = Properties.Resources.coilSecundaryCut;
                CombCS.Click += new EventHandler(combinacionesCorteSecundarioToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(CombCS);

                ToolStripMenuItem rebobinado = new ToolStripMenuItem();
                rebobinado.Text = "Rebobinado";
                rebobinado.Image = Properties.Resources.rewind;
                rebobinado.Click += new EventHandler(rebobinadoToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(rebobinado);

                ToolStripMenuItem regBobReproc = new ToolStripMenuItem();
                regBobReproc.Text = "Registro de Bobinas para Reproceso";
                regBobReproc.Image = Properties.Resources.reprocess2;
                regBobReproc.Click += new EventHandler(registroDeBobinasParaReprocesoToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(regBobReproc);

                ToolStripMenuItem reetiquetadopeliculasEquiv = new ToolStripMenuItem();
                reetiquetadopeliculasEquiv.Text = "Re-etiquetado peliculas equivalente";
                reetiquetadopeliculasEquiv.Image = Properties.Resources.printer;
                reetiquetadopeliculasEquiv.Click += new EventHandler(reetiquetadoDePeliculaEquivalenteToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(reetiquetadopeliculasEquiv);

                ToolStripMenuItem reetiquetadoStock = new ToolStripMenuItem();
                reetiquetadoStock.Text = "Re-etiquetado a Stock";
                reetiquetadoStock.Image = Properties.Resources.printer;
                reetiquetadoStock.Click += new EventHandler(reetiquetadoAStockToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(reetiquetadoStock);

                ToolStripMenuItem metalizado = new ToolStripMenuItem();
                metalizado.Text = "Metalizado (Sistema Viejo)";
                metalizado.Image = Properties.Resources.coils;
                metalizado.Click += new EventHandler(btnMetlizedOrder_Click);
                Digitacion.DropDownItems.Add(metalizado);

                //ToolStripMenuItem nuevoMetalizado = new ToolStripMenuItem();
                //nuevoMetalizado.Text = "Metalizado (Sistema Nuevo)";
                //nuevoMetalizado.Image = Properties.Resources.coils;
                //nuevoMetalizado.Click += new EventHandler(btnNewMetlizedOrder_Click);
                //Digitacion.DropDownItems.Add(nuevoMetalizado);

                ToolStripMenuItem pallets = new ToolStripMenuItem();
                pallets.Text = "Pallets";
                pallets.Image = Properties.Resources.pallet;
                pallets.Click += new EventHandler(palletsToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(pallets);

                ToolStripMenuItem mermas = new ToolStripMenuItem();
                mermas.Text = "Notificacion de Mermas";
                mermas.Image = Properties.Resources.coilMill;
                mermas.Click += new EventHandler(scrapToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(mermas);

                #endregion

                #region Detalle

                ToolStripMenuItem detalle = new ToolStripMenuItem();
                detalle.Text = "Detalle";
                detalle.Image = Properties.Resources.clipboard_text;
                mnu.Items.Add(detalle);

                ToolStripMenuItem estadoDeDepot = new ToolStripMenuItem();
                estadoDeDepot.Text = "Inventario Completo de pallets";
                estadoDeDepot.Image = Properties.Resources.storage2;
                estadoDeDepot.Click += new EventHandler(EstadoDeDeposito_Click);
                detalle.DropDownItems.Add(estadoDeDepot);

                ToolStripMenuItem estadoDeDepotOP1 = new ToolStripMenuItem();
                estadoDeDepotOP1.Text = "Inventario Completo de Bobinas";
                estadoDeDepotOP1.Image = Properties.Resources.storage2;
                estadoDeDepotOP1.Click += new EventHandler(stockOP1ToolStripMenuItem_Click);
                detalle.DropDownItems.Add(estadoDeDepotOP1);

                ToolStripMenuItem bobSueltas = new ToolStripMenuItem();
                bobSueltas.Text = "Inventario de Bobinas Sueltas";
                bobSueltas.Image = Properties.Resources.page_coils;
                bobSueltas.Click += new EventHandler(invetarioBobinasSueltasToolStripMenuItem_Click);
                detalle.DropDownItems.Add(bobSueltas);

                ToolStripMenuItem estadoRackCP = new ToolStripMenuItem();
                estadoRackCP.Text = "Estado de Rack Cortadora Primaria";
                estadoRackCP.Image = Properties.Resources.page_coils;
                estadoRackCP.Click += new EventHandler(estadoDeRackCortadoraPrimariaToolStripMenuItem_Click);
                detalle.DropDownItems.Add(estadoRackCP);

                ToolStripMenuItem rackMet = new ToolStripMenuItem();
                rackMet.Text = "Rack de Metalizado";
                rackMet.Image = Properties.Resources.coils;
                rackMet.Click += new EventHandler(estadoDeToolStripMenuItem_Click);
                detalle.DropDownItems.Add(rackMet);

                ToolStripMenuItem stockPalletScrap = new ToolStripMenuItem();
                stockPalletScrap.Text = "Stock de Pallets de Merma";
                stockPalletScrap.Image = Properties.Resources.box;
                stockPalletScrap.Click += new EventHandler(stockPalletsScrapToolStripMenuItem_Click);
                detalle.DropDownItems.Add(stockPalletScrap);

                ToolStripMenuItem palletDtl = new ToolStripMenuItem();
                palletDtl.Text = "Detalle de Pallet";
                palletDtl.Image = Properties.Resources.pallet;
                palletDtl.Click += new EventHandler(btnPallet_Click);
                detalle.DropDownItems.Add(palletDtl);

                ToolStripMenuItem coilDtl = new ToolStripMenuItem();
                coilDtl.Text = "Detalle de Bobina";
                coilDtl.Image = Properties.Resources.mainCoil;
                coilDtl.Click += new EventHandler(btnCoil_Click);
                detalle.DropDownItems.Add(coilDtl);



                #endregion

            }
            else if (clsGlobal.LoggedUser.RoleName == "Digitador Pilar")
            {
                
                pnlShortCut.Visible = false;
                detalleDePalletToolStripMenuItem.Visible = false;
                digitaciónToolStripMenuItem.Visible = false;
                detalleToolStripMenuItem.Visible = false;
                movimientosTSMLog.Visible = false;

                #region Digitacion

                ToolStripMenuItem Digitacion = new ToolStripMenuItem();
                Digitacion.Text = "Digitación";
                Digitacion.Image = Properties.Resources.server;
                mnu.Items.Add(Digitacion);

                ToolStripMenuItem lstOrdenes = new ToolStripMenuItem();
                lstOrdenes.Text = "Listado de Ordenes";
                lstOrdenes.Image = Properties.Resources.page_coils;
                Digitacion.DropDownItems.Add(lstOrdenes);

                ToolStripMenuItem goebel = new ToolStripMenuItem();
                goebel.Text = "Goebel";
                goebel.Image = Properties.Resources.gear_16;
                goebel.Click += new EventHandler(goebelToolStripMenuItem_Click);
                lstOrdenes.DropDownItems.Add(goebel);

                ToolStripMenuItem atlas = new ToolStripMenuItem();
                atlas.Text = "Atlas";
                atlas.Image = Properties.Resources.gear_16;
                atlas.Click += new EventHandler(atlasToolStripMenuItem1_Click_1);
                lstOrdenes.DropDownItems.Add(atlas);

                ToolStripMenuItem titan = new ToolStripMenuItem();
                titan.Text = "Titan";
                titan.Image = Properties.Resources.gear_16;
                titan.Click += new EventHandler(titanToolStripMenuItem_Click);
                lstOrdenes.DropDownItems.Add(titan);
                
                ToolStripMenuItem bobinas = new ToolStripMenuItem();
                bobinas.Image = Properties.Resources.coils;
                bobinas.Text = "Bobinas";
                Digitacion.DropDownItems.Add(bobinas);

                ToolStripMenuItem goebelB = new ToolStripMenuItem();
                goebelB.Text = "Goebel";
                goebelB.Image = Properties.Resources.gear_16;
                goebelB.Click += new EventHandler(goebelToolStripMenuItem3_Click);
                bobinas.DropDownItems.Add(goebelB);

                ToolStripMenuItem AtlasB = new ToolStripMenuItem();
                AtlasB.Text = "Atlas";
                AtlasB.Image = Properties.Resources.gear_16;
                AtlasB.Click += new EventHandler(atlasPilarToolStripMenuItem_Click);
                bobinas.DropDownItems.Add(AtlasB);

                ToolStripMenuItem TitanB = new ToolStripMenuItem();
                TitanB.Text = "Titan";
                TitanB.Image = Properties.Resources.gear_16;
                TitanB.Click += new EventHandler(titanToolStripMenuItem2_Click);
                bobinas.DropDownItems.Add(TitanB);

                ToolStripMenuItem CombCS = new ToolStripMenuItem();
                CombCS.Text = "Combinacion de Corte Secundario";
                CombCS.Image = Properties.Resources.coilSecundaryCut;
                CombCS.Click += new EventHandler(combinacionesCorteSecundarioToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(CombCS);

                ToolStripMenuItem rebobinado = new ToolStripMenuItem();
                rebobinado.Text = "Rebobinado";
                rebobinado.Image = Properties.Resources.rewind;
                rebobinado.Click += new EventHandler(rebobinadoToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(rebobinado);

                ToolStripMenuItem regBobReproc = new ToolStripMenuItem();
                regBobReproc.Text = "Registro de Bobinas para Reproceso";
                regBobReproc.Image = Properties.Resources.reprocess2;
                regBobReproc.Click += new EventHandler(registroDeBobinasParaReprocesoToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(regBobReproc);

                ToolStripMenuItem reetiquetadopeliculasEquiv = new ToolStripMenuItem();
                reetiquetadopeliculasEquiv.Text = "Re-etiquetado peliculas equivalente";
                reetiquetadopeliculasEquiv.Image = Properties.Resources.printer;
                reetiquetadopeliculasEquiv.Click += new EventHandler(reetiquetadoDePeliculaEquivalenteToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(reetiquetadopeliculasEquiv);

                ToolStripMenuItem reetiquetadoStock = new ToolStripMenuItem();
                reetiquetadoStock.Text = "Re-etiquetado a Stock";
                reetiquetadoStock.Image = Properties.Resources.printer;
                reetiquetadoStock.Click += new EventHandler(reetiquetadoAStockToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(reetiquetadoStock);

                ToolStripMenuItem metalizado = new ToolStripMenuItem();
                metalizado.Text = "Metalizado (Sistema viejo)";
                metalizado.Image = Properties.Resources.coils;
                metalizado.Click += new EventHandler(btnMetlizedOrder_Click);
                Digitacion.DropDownItems.Add(metalizado);

                /*ToolStripMenuItem nuevoMetalizado = new ToolStripMenuItem();
                nuevoMetalizado.Text = "Metalizado (Sistema Nuevo)";
                nuevoMetalizado.Image = Properties.Resources.coils;
                nuevoMetalizado.Click += new EventHandler(btnNewMetlizedOrder_Click);
                Digitacion.DropDownItems.Add(nuevoMetalizado);*/
                
                ToolStripMenuItem pallets = new ToolStripMenuItem();
                pallets.Text = "Pallets";
                pallets.Image = Properties.Resources.pallet;
                pallets.Click += new EventHandler(palletsToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(pallets);

                ToolStripMenuItem mermas = new ToolStripMenuItem();
                mermas.Text = "Notificacion de Mermas";
                mermas.Image = Properties.Resources.coilMill;
                mermas.Click += new EventHandler(scrapToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(mermas);

                #endregion

                #region Detalle

                ToolStripMenuItem detalle = new ToolStripMenuItem();
                detalle.Text = "Detalle";
                detalle.Image = Properties.Resources.clipboard_text;
                mnu.Items.Add(detalle);

                ToolStripMenuItem estadoDeDepot = new ToolStripMenuItem();
                estadoDeDepot.Text = "Inventario Completo de Pallets";
                estadoDeDepot.Image = Properties.Resources.storage2;
                estadoDeDepot.Click += new EventHandler(EstadoDeDeposito_Click);
                detalle.DropDownItems.Add(estadoDeDepot);

                ToolStripMenuItem estadoDeDepotOP1 = new ToolStripMenuItem();
                estadoDeDepotOP1.Text = "Inventario Completo de Bobinas";
                estadoDeDepotOP1.Image = Properties.Resources.storage2;
                estadoDeDepotOP1.Click += new EventHandler(stockOP1ToolStripMenuItem_Click);
                detalle.DropDownItems.Add(estadoDeDepotOP1);

                ToolStripMenuItem estadobobsue = new ToolStripMenuItem();
                estadobobsue.Text = "Inventario Bobinas Sueltas";
                estadobobsue.Image = Properties.Resources.page_coils;
                estadobobsue.Click += new EventHandler(inventarioDeBobinasSueltasToolStripMenuItem_Click);
                detalle.DropDownItems.Add(estadobobsue);

                ToolStripMenuItem estadoRackCP = new ToolStripMenuItem();
                estadoRackCP.Text = "Estado de Rack Cortadora Primaria";
                estadoRackCP.Image = Properties.Resources.page_coils;
                estadoRackCP.Click += new EventHandler(estadoDeRackCortadoraPrimariaToolStripMenuItem_Click);
                detalle.DropDownItems.Add(estadoRackCP);

                ToolStripMenuItem rackMet = new ToolStripMenuItem();
                rackMet.Text = "Rack de Metalizado";
                rackMet.Image = Properties.Resources.coils;
                rackMet.Click += new EventHandler(estadoDeToolStripMenuItem_Click);
                detalle.DropDownItems.Add(rackMet);

                ToolStripMenuItem stockPalletScrap = new ToolStripMenuItem();
                stockPalletScrap.Text = "Stock de Pallets de Merma";
                stockPalletScrap.Image = Properties.Resources.box;
                stockPalletScrap.Click += new EventHandler(stockPalletsScrapToolStripMenuItem_Click);
                detalle.DropDownItems.Add(stockPalletScrap);

                ToolStripMenuItem palletDtl = new ToolStripMenuItem();
                palletDtl.Text = "Detalle de Pallet";
                palletDtl.Image = Properties.Resources.pallet;
                palletDtl.Click += new EventHandler(btnPallet_Click);
                detalle.DropDownItems.Add(palletDtl);

                ToolStripMenuItem coilDtl = new ToolStripMenuItem();
                coilDtl.Text = "Detalle de Bobina";
                coilDtl.Image = Properties.Resources.mainCoil;
                coilDtl.Click += new EventHandler(btnCoil_Click);
                detalle.DropDownItems.Add(coilDtl);



                #endregion

            }


            else if (clsGlobal.LoggedUser.RoleName == "Operadores de corte")
            {
               /* pnlShortCut.Visible = false;
                detalleDePalletToolStripMenuItem.Visible = false;
                c230ToolStripMenuItem2.Visible = false;
                c231ToolStripMenuItem2.Visible = false;
                c232ToolStripMenuItem2.Visible = false;
                c230ToolStripMenuItem.Visible = false;
                c231ToolStripMenuItem.Visible = false;
                c232ToolStripMenuItem.Visible = false;
                palletsToolStripMenuItem.Visible = false;
                rebobinadoToolStripMenuItem.Visible = false;
                metalizadoToolStripMenuItem.Visible = false;
                toolStripMenuItem1.Visible = false;
                registroDeBobinasParaReprocesoToolStripMenuItem.Visible = false;
                movimientosTSMLog.Visible = false;
                reporteDeMetalizadoTSMItem.Visible = false;
                tsmInProcessCoils.Visible = false;
                tsmOrderList_PL.Visible = false;
                tsmCoils_PL.Visible = false;*/

                pnlShortCut.Visible = false;
                detalleDePalletToolStripMenuItem.Visible = false;
                digitaciónToolStripMenuItem.Visible = false;
                detalleToolStripMenuItem.Visible = false;
                movimientosTSMLog.Visible = false;

                #region Digitacion

                ToolStripMenuItem Digitacion = new ToolStripMenuItem();
                Digitacion.Text = "Digitación";
                Digitacion.Image = Properties.Resources.server;
                mnu.Items.Add(Digitacion);

                ToolStripMenuItem lstOrdenes = new ToolStripMenuItem();
                lstOrdenes.Text = "Listado de Ordenes";
                lstOrdenes.Image = Properties.Resources.page_coils;
                Digitacion.DropDownItems.Add(lstOrdenes);

                ToolStripMenuItem atlas = new ToolStripMenuItem();
                atlas.Text = "Atlas - Campana";
                atlas.Image = Properties.Resources.gear_16;
                atlas.Click += new EventHandler(atlasToolStripMenuItem2_Click);
                lstOrdenes.DropDownItems.Add(atlas);

                ToolStripMenuItem bobinas = new ToolStripMenuItem();
                bobinas.Image = Properties.Resources.coils;
                bobinas.Text = "Bobinas";
                Digitacion.DropDownItems.Add(bobinas);

                ToolStripMenuItem AtlasB = new ToolStripMenuItem();
                AtlasB.Text = "Atlas - Campana";
                AtlasB.Image = Properties.Resources.gear_16;
                AtlasB.Click += new EventHandler(goebelToolStripMenuItem2_Click);
                bobinas.DropDownItems.Add(AtlasB);

                ToolStripMenuItem CombCS = new ToolStripMenuItem();
                CombCS.Text = "Combinacion de Corte Secundario";
                CombCS.Image = Properties.Resources.coilSecundaryCut;
                CombCS.Click += new EventHandler(combinacionesCorteSecundarioToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(CombCS);

                ToolStripMenuItem rebobinado = new ToolStripMenuItem();
                rebobinado.Text = "Rebobinado";
                rebobinado.Image = Properties.Resources.rewind;
                rebobinado.Click += new EventHandler(rebobinadoToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(rebobinado);

                ToolStripMenuItem regBobReproc = new ToolStripMenuItem();
                regBobReproc.Text = "Registro de Bobinas para Reproceso";
                regBobReproc.Image = Properties.Resources.reprocess2;
                regBobReproc.Click += new EventHandler(registroDeBobinasParaReprocesoToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(regBobReproc);

                ToolStripMenuItem reetiquetadopeliculasEquiv = new ToolStripMenuItem();
                reetiquetadopeliculasEquiv.Text = "Re-etiquetado peliculas equivalente";
                reetiquetadopeliculasEquiv.Image = Properties.Resources.printer;
                reetiquetadopeliculasEquiv.Click += new EventHandler(reetiquetadoDePeliculaEquivalenteToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(reetiquetadopeliculasEquiv);

                ToolStripMenuItem reetiquetadoStock = new ToolStripMenuItem();
                reetiquetadoStock.Text = "Re-etiquetado a Stock";
                reetiquetadoStock.Image = Properties.Resources.printer;
                reetiquetadoStock.Click += new EventHandler(reetiquetadoAStockToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(reetiquetadoStock);

                ToolStripMenuItem metalizado = new ToolStripMenuItem();
                metalizado.Text = "Metalizado (Sistema Viejo)";
                metalizado.Image = Properties.Resources.coils;
                metalizado.Click += new EventHandler(btnMetlizedOrder_Click);
                Digitacion.DropDownItems.Add(metalizado);

               /* ToolStripMenuItem newmetalizado = new ToolStripMenuItem();
                newmetalizado.Text = "Metalizado (Sistema nuevo)";
                newmetalizado.Image = Properties.Resources.coils;
                newmetalizado.Click += new EventHandler(btnNewMetlizedOrder_Click);
                Digitacion.DropDownItems.Add(newmetalizado);
                */
                ToolStripMenuItem pallets = new ToolStripMenuItem();
                pallets.Text = "Pallets";
                pallets.Image = Properties.Resources.pallet;
                pallets.Click += new EventHandler(palletsToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(pallets);

                ToolStripMenuItem mermas = new ToolStripMenuItem();
                mermas.Text = "Notificacion de Mermas";
                mermas.Image = Properties.Resources.coilMill;
                mermas.Click += new EventHandler(scrapToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(mermas);

                #endregion

                #region Detalle

                ToolStripMenuItem detalle = new ToolStripMenuItem();
                detalle.Text = "Detalle";
                detalle.Image = Properties.Resources.clipboard_text;
                mnu.Items.Add(detalle);

                ToolStripMenuItem estadoDeDepot = new ToolStripMenuItem();
                estadoDeDepot.Text = "Inventario Completo de Pallets";
                estadoDeDepot.Image = Properties.Resources.storage2;
                estadoDeDepot.Click += new EventHandler(EstadoDeDeposito_Click);
                detalle.DropDownItems.Add(estadoDeDepot);

                ToolStripMenuItem estadoDeDepotOP1 = new ToolStripMenuItem();
                estadoDeDepotOP1.Text = "Inventario Completo de Bobinas";
                estadoDeDepotOP1.Image = Properties.Resources.storage2;
                estadoDeDepotOP1.Click += new EventHandler(stockOP1ToolStripMenuItem_Click);
                detalle.DropDownItems.Add(estadoDeDepotOP1);

                ToolStripMenuItem estadoRackCP = new ToolStripMenuItem();
                estadoRackCP.Text = "Estado de Rack Cortadora Primaria";
                estadoRackCP.Image = Properties.Resources.page_coils;
                estadoRackCP.Click += new EventHandler(estadoDeRackCortadoraPrimariaToolStripMenuItem_Click);
                detalle.DropDownItems.Add(estadoRackCP);

                ToolStripMenuItem rackMet = new ToolStripMenuItem();
                rackMet.Text = "Rack de Metalizado";
                rackMet.Image = Properties.Resources.coils;
                rackMet.Click += new EventHandler(estadoDeToolStripMenuItem_Click);
                detalle.DropDownItems.Add(rackMet);

                ToolStripMenuItem bobSueltas = new ToolStripMenuItem();
                bobSueltas.Text = "Inventario de Bobinas Sueltas";
                bobSueltas.Image = Properties.Resources.page_coils;
                bobSueltas.Click += new EventHandler(invetarioBobinasSueltasToolStripMenuItem_Click);
                detalle.DropDownItems.Add(bobSueltas);

                ToolStripMenuItem stockPalletScrap = new ToolStripMenuItem();
                stockPalletScrap.Text = "Stock de Pallets de Merma";
                stockPalletScrap.Image = Properties.Resources.box;
                stockPalletScrap.Click += new EventHandler(stockPalletsScrapToolStripMenuItem_Click);
                detalle.DropDownItems.Add(stockPalletScrap);

                ToolStripMenuItem palletDtl = new ToolStripMenuItem();
                palletDtl.Text = "Detalle de Pallet";
                palletDtl.Image = Properties.Resources.pallet;
                palletDtl.Click += new EventHandler(btnPallet_Click);
                detalle.DropDownItems.Add(palletDtl);

                ToolStripMenuItem coilDtl = new ToolStripMenuItem();
                coilDtl.Text = "Detalle de Bobina";
                coilDtl.Image = Properties.Resources.mainCoil;
                coilDtl.Click += new EventHandler(btnCoil_Click);
                detalle.DropDownItems.Add(coilDtl);



                #endregion

            }
            else if (clsGlobal.LoggedUser.RoleName == "Operadores de corte C230")
            {
                pnlShortCut.Visible = false;
                detalleDePalletToolStripMenuItem.Visible = false;
                digitaciónToolStripMenuItem.Visible = false;
                detalleToolStripMenuItem.Visible = false;
                movimientosTSMLog.Visible = false;

                #region Digitacion

                ToolStripMenuItem Digitacion = new ToolStripMenuItem();
                Digitacion.Text = "Digitación";
                Digitacion.Image = Properties.Resources.server;
                mnu.Items.Add(Digitacion);

                ToolStripMenuItem lstOrdenes = new ToolStripMenuItem();
                lstOrdenes.Text = "Listado de Ordenes";
                lstOrdenes.Image = Properties.Resources.page_coils;
                Digitacion.DropDownItems.Add(lstOrdenes);

                ToolStripMenuItem c230 = new ToolStripMenuItem();
                c230.Text = "C230";
                c230.Image = Properties.Resources.gear_16;
                c230.Click += new EventHandler(c230ToolStripMenuItem2_Click);
                lstOrdenes.DropDownItems.Add(c230);

                ToolStripMenuItem bobinas = new ToolStripMenuItem();
                bobinas.Image = Properties.Resources.coils;
                bobinas.Text = "Bobinas";
                Digitacion.DropDownItems.Add(bobinas);

                ToolStripMenuItem bobinasc230 = new ToolStripMenuItem();
                bobinasc230.Text = "C230";
                bobinasc230.Image = Properties.Resources.gear_16;
                bobinasc230.Click += new EventHandler(atlasCampanaToolStripMenuItem_Click);
                bobinas.DropDownItems.Add(bobinasc230);

                ToolStripMenuItem CombCS = new ToolStripMenuItem();
                CombCS.Text = "Combinacion de Corte Secundario";
                CombCS.Image = Properties.Resources.coilSecundaryCut;
                CombCS.Click += new EventHandler(combinacionesCorteSecundarioToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(CombCS);

                ToolStripMenuItem rebobinado = new ToolStripMenuItem();
                rebobinado.Text = "Rebobinado";
                rebobinado.Image = Properties.Resources.rewind;
                rebobinado.Click += new EventHandler(rebobinadoToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(rebobinado);

                ToolStripMenuItem regBobReproc = new ToolStripMenuItem();
                regBobReproc.Text = "Registro de Bobinas para Reproceso";
                regBobReproc.Image = Properties.Resources.reprocess2;
                regBobReproc.Click += new EventHandler(registroDeBobinasParaReprocesoToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(regBobReproc);

                ToolStripMenuItem reetiquetadopeliculasEquiv = new ToolStripMenuItem();
                reetiquetadopeliculasEquiv.Text = "Re-etiquetado peliculas equivalente";
                reetiquetadopeliculasEquiv.Image = Properties.Resources.printer;
                reetiquetadopeliculasEquiv.Click += new EventHandler(reetiquetadoDePeliculaEquivalenteToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(reetiquetadopeliculasEquiv);

                ToolStripMenuItem reetiquetadoStock = new ToolStripMenuItem();
                reetiquetadoStock.Text = "Re-etiquetado a Stock";
                reetiquetadoStock.Image = Properties.Resources.printer;
                reetiquetadoStock.Click += new EventHandler(reetiquetadoAStockToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(reetiquetadoStock);

                ToolStripMenuItem metalizado = new ToolStripMenuItem();
                metalizado.Text = "Metalizado (Sistema Viejo)";
                metalizado.Image = Properties.Resources.coils;
                metalizado.Click += new EventHandler(btnMetlizedOrder_Click);
                Digitacion.DropDownItems.Add(metalizado);

               /* ToolStripMenuItem newmetalizado = new ToolStripMenuItem();
                newmetalizado.Text = "Metalizado (Sistema Nuevo)";
                newmetalizado.Image = Properties.Resources.coils;
                newmetalizado.Click += new EventHandler(btnNewMetlizedOrder_Click);
                Digitacion.DropDownItems.Add(newmetalizado);
                */
                ToolStripMenuItem pallets = new ToolStripMenuItem();
                pallets.Text = "Pallets";
                pallets.Image = Properties.Resources.pallet;
                pallets.Click += new EventHandler(palletsToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(pallets);      

                ToolStripMenuItem mermas = new ToolStripMenuItem();
                mermas.Text = "Notificacion de Mermas";
                mermas.Image = Properties.Resources.coilMill;
                mermas.Click += new EventHandler(scrapToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(mermas);

                #endregion

                #region Detalle

                ToolStripMenuItem detalle = new ToolStripMenuItem();
                detalle.Text = "Detalle";
                detalle.Image = Properties.Resources.clipboard_text;
                mnu.Items.Add(detalle);

                ToolStripMenuItem estadoDeDepot = new ToolStripMenuItem();
                estadoDeDepot.Text = "Inventario Completo de Pallets";
                estadoDeDepot.Image = Properties.Resources.storage2;
                estadoDeDepot.Click += new EventHandler(EstadoDeDeposito_Click);
                detalle.DropDownItems.Add(estadoDeDepot);

                ToolStripMenuItem estadoDeDepotOP1 = new ToolStripMenuItem();
                estadoDeDepotOP1.Text = "Inventario Completo de Bobinas";
                estadoDeDepotOP1.Image = Properties.Resources.storage2;
                estadoDeDepotOP1.Click += new EventHandler(stockOP1ToolStripMenuItem_Click);
                detalle.DropDownItems.Add(estadoDeDepotOP1);

                ToolStripMenuItem estadobobsue = new ToolStripMenuItem();
                estadobobsue.Text = "Inventario Bobinas Sueltas";
                estadobobsue.Image = Properties.Resources.page_coils;
                estadobobsue.Click += new EventHandler(inventarioDeBobinasSueltasToolStripMenuItem_Click);
                detalle.DropDownItems.Add(estadobobsue);

                ToolStripMenuItem estadoRackCP = new ToolStripMenuItem();
                estadoRackCP.Text = "Estado de Rack Cortadora Primaria";
                estadoRackCP.Image = Properties.Resources.page_coils;
                estadoRackCP.Click += new EventHandler(estadoDeRackCortadoraPrimariaToolStripMenuItem_Click);
                detalle.DropDownItems.Add(estadoRackCP);

                ToolStripMenuItem bobColgantes = new ToolStripMenuItem();
                bobColgantes.Text = "Rack de Bobinas Colgantes";
                bobColgantes.Image = Properties.Resources.coils;
                bobColgantes.Click += new EventHandler(bobinasColgantesToolStripMenuItem_Click);
                detalle.DropDownItems.Add(bobColgantes);

                ToolStripMenuItem stockPalletScrap = new ToolStripMenuItem();
                stockPalletScrap.Text = "Stock de Pallets de Merma";
                stockPalletScrap.Image = Properties.Resources.box;
                stockPalletScrap.Click += new EventHandler(stockPalletsScrapToolStripMenuItem_Click);
                detalle.DropDownItems.Add(stockPalletScrap);

                ToolStripMenuItem palletDtl = new ToolStripMenuItem();
                palletDtl.Text = "Detalle de Pallet";
                palletDtl.Image = Properties.Resources.pallet;
                palletDtl.Click += new EventHandler(btnPallet_Click);
                detalle.DropDownItems.Add(palletDtl);

                ToolStripMenuItem coilDtl = new ToolStripMenuItem();
                coilDtl.Text = "Detalle de Bobina";
                coilDtl.Image = Properties.Resources.mainCoil;
                coilDtl.Click += new EventHandler(btnCoil_Click);
                detalle.DropDownItems.Add(coilDtl);



                #endregion

            }
            else if (clsGlobal.LoggedUser.RoleName == "Operadores de corte C231")
            {

                pnlShortCut.Visible = false;
                detalleDePalletToolStripMenuItem.Visible = false;
                digitaciónToolStripMenuItem.Visible = false;
                detalleToolStripMenuItem.Visible = false;
                movimientosTSMLog.Visible = false;

                #region Digitacion

                ToolStripMenuItem Digitacion = new ToolStripMenuItem();
                Digitacion.Text = "Digitación";
                Digitacion.Image = Properties.Resources.server;
                mnu.Items.Add(Digitacion);

                ToolStripMenuItem lstOrdenes = new ToolStripMenuItem();
                lstOrdenes.Text = "Listado de Ordenes";
                lstOrdenes.Image = Properties.Resources.page_coils;
                Digitacion.DropDownItems.Add(lstOrdenes);

                ToolStripMenuItem c231 = new ToolStripMenuItem();
                c231.Text = "C231";
                c231.Image = Properties.Resources.gear_16;
                c231.Click += new EventHandler(c231ToolStripMenuItem2_Click);
                lstOrdenes.DropDownItems.Add(c231);

                ToolStripMenuItem bobinas = new ToolStripMenuItem();
                bobinas.Image = Properties.Resources.coils;
                bobinas.Text = "Bobinas";
                Digitacion.DropDownItems.Add(bobinas);

                ToolStripMenuItem bobinasc231 = new ToolStripMenuItem();
                bobinasc231.Text = "C231";
                bobinasc231.Image = Properties.Resources.gear_16;
                bobinasc231.Click += new EventHandler(c231ToolStripMenuItem1_Click_1);
                bobinas.DropDownItems.Add(bobinasc231);

                ToolStripMenuItem CombCS = new ToolStripMenuItem();
                CombCS.Text = "Combinacion de Corte Secundario";
                CombCS.Image = Properties.Resources.coilSecundaryCut;
                CombCS.Click += new EventHandler(combinacionesCorteSecundarioToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(CombCS);

                ToolStripMenuItem rebobinado = new ToolStripMenuItem();
                rebobinado.Text = "Rebobinado";
                rebobinado.Image = Properties.Resources.rewind;
                rebobinado.Click += new EventHandler(rebobinadoToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(rebobinado);

                ToolStripMenuItem regBobReproc = new ToolStripMenuItem();
                regBobReproc.Text = "Registro de Bobinas para Reproceso";
                regBobReproc.Image = Properties.Resources.reprocess2;
                regBobReproc.Click += new EventHandler(registroDeBobinasParaReprocesoToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(regBobReproc);

                ToolStripMenuItem reetiquetadopeliculasEquiv = new ToolStripMenuItem();
                reetiquetadopeliculasEquiv.Text = "Re-etiquetado peliculas equivalente";
                reetiquetadopeliculasEquiv.Image = Properties.Resources.printer;
                reetiquetadopeliculasEquiv.Click += new EventHandler(reetiquetadoDePeliculaEquivalenteToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(reetiquetadopeliculasEquiv);

                ToolStripMenuItem reetiquetadoStock = new ToolStripMenuItem();
                reetiquetadoStock.Text = "Re-etiquetado a Stock";
                reetiquetadoStock.Image = Properties.Resources.printer;
                reetiquetadoStock.Click += new EventHandler(reetiquetadoAStockToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(reetiquetadoStock);

                ToolStripMenuItem metalizado = new ToolStripMenuItem();
                metalizado.Text = "Metalizado (Sistema Viejo)";
                metalizado.Image = Properties.Resources.coils;
                metalizado.Click += new EventHandler(btnMetlizedOrder_Click);
                Digitacion.DropDownItems.Add(metalizado);

              /* ToolStripMenuItem newmetalizado = new ToolStripMenuItem();
                newmetalizado.Text = "Metalizado (Sistema Nuevo)";
                newmetalizado.Image = Properties.Resources.coils;
                newmetalizado.Click += new EventHandler(btnNewMetlizedOrder_Click);
                Digitacion.DropDownItems.Add(newmetalizado);
                  */
                ToolStripMenuItem pallets = new ToolStripMenuItem();
                pallets.Text = "Pallets";
                pallets.Image = Properties.Resources.pallet;
                pallets.Click += new EventHandler(palletsToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(pallets);

                ToolStripMenuItem mermas = new ToolStripMenuItem();
                mermas.Text = "Notificacion de Mermas";
                mermas.Image = Properties.Resources.coilMill;
                mermas.Click += new EventHandler(scrapToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(mermas);

                #endregion

                #region Detalle

                ToolStripMenuItem detalle = new ToolStripMenuItem();
                detalle.Text = "Detalle";
                detalle.Image = Properties.Resources.clipboard_text;
                mnu.Items.Add(detalle);

                ToolStripMenuItem estadoDeDepot = new ToolStripMenuItem();
                estadoDeDepot.Text = "Inventario Completo de Pallets";
                estadoDeDepot.Image = Properties.Resources.storage2;
                estadoDeDepot.Click += new EventHandler(EstadoDeDeposito_Click);
                detalle.DropDownItems.Add(estadoDeDepot);

                ToolStripMenuItem estadoDeDepotOP1 = new ToolStripMenuItem();
                estadoDeDepotOP1.Text = "Inventario Completo de Bobinas";
                estadoDeDepotOP1.Image = Properties.Resources.storage2;
                estadoDeDepotOP1.Click += new EventHandler(stockOP1ToolStripMenuItem_Click);
                detalle.DropDownItems.Add(estadoDeDepotOP1);

                ToolStripMenuItem estadobobsue = new ToolStripMenuItem();
                estadobobsue.Text = "Inventario Bobinas Sueltas";
                estadobobsue.Image = Properties.Resources.page_coils;
                estadobobsue.Click += new EventHandler(inventarioDeBobinasSueltasToolStripMenuItem_Click);
                detalle.DropDownItems.Add(estadobobsue);

                ToolStripMenuItem estadoRackCP = new ToolStripMenuItem();
                estadoRackCP.Text = "Rack Cortadora Primaria";
                estadoRackCP.Image = Properties.Resources.page_coils;
                estadoRackCP.Click += new EventHandler(estadoDeRackCortadoraPrimariaToolStripMenuItem_Click);
                detalle.DropDownItems.Add(estadoRackCP);

                ToolStripMenuItem bobColgantes = new ToolStripMenuItem();
                bobColgantes.Text = "Rack de Bobinas Colgantes";
                bobColgantes.Image = Properties.Resources.coils;
                bobColgantes.Click += new EventHandler(bobinasColgantesToolStripMenuItem_Click);
                detalle.DropDownItems.Add(bobColgantes);

                ToolStripMenuItem stockPalletScrap = new ToolStripMenuItem();
                stockPalletScrap.Text = "Stock de Pallets de Merma";
                stockPalletScrap.Image = Properties.Resources.box;
                stockPalletScrap.Click += new EventHandler(stockPalletsScrapToolStripMenuItem_Click);
                detalle.DropDownItems.Add(stockPalletScrap);

                ToolStripMenuItem coilDtl = new ToolStripMenuItem();
                coilDtl.Text = "Detalle de Bobina";
                coilDtl.Image = Properties.Resources.mainCoil;
                coilDtl.Click += new EventHandler(btnCoil_Click);
                detalle.DropDownItems.Add(coilDtl);

                ToolStripMenuItem palletDtl = new ToolStripMenuItem();
                palletDtl.Text = "Detalle de Pallet";
                palletDtl.Image = Properties.Resources.pallet;
                palletDtl.Click += new EventHandler(btnPallet_Click);
                detalle.DropDownItems.Add(palletDtl);


                #endregion

            }
            else if (clsGlobal.LoggedUser.RoleName == "Operadores de corte C232")
            {

                pnlShortCut.Visible = false;
                detalleDePalletToolStripMenuItem.Visible = false;
                digitaciónToolStripMenuItem.Visible = false;
                detalleToolStripMenuItem.Visible = false;
                movimientosTSMLog.Visible = false;

                #region Digitacion

                ToolStripMenuItem Digitacion = new ToolStripMenuItem();
                Digitacion.Text = "Digitación";
                Digitacion.Image = Properties.Resources.server;
                mnu.Items.Add(Digitacion);

                ToolStripMenuItem lstOrdenes = new ToolStripMenuItem();
                lstOrdenes.Text = "Listado de Ordenes";
                lstOrdenes.Image = Properties.Resources.page_coils;
                Digitacion.DropDownItems.Add(lstOrdenes);

                ToolStripMenuItem c232 = new ToolStripMenuItem();
                c232.Text = "C232";
                c232.Image = Properties.Resources.gear_16;
                c232.Click += new EventHandler(c232ToolStripMenuItem2_Click);
                lstOrdenes.DropDownItems.Add(c232);

                ToolStripMenuItem bobinas = new ToolStripMenuItem();
                bobinas.Image = Properties.Resources.coils;
                bobinas.Text = "Bobinas";
                Digitacion.DropDownItems.Add(bobinas);

                ToolStripMenuItem bobinasc232 = new ToolStripMenuItem();
                bobinasc232.Text = "C232";
                bobinasc232.Image = Properties.Resources.gear_16;
                bobinasc232.Click += new EventHandler(c232ToolStripMenuItem1_Click_1);
                bobinas.DropDownItems.Add(bobinasc232);

                ToolStripMenuItem CombCS = new ToolStripMenuItem();
                CombCS.Text = "Combinacion de Corte Secundario";
                CombCS.Image = Properties.Resources.coilSecundaryCut;
                CombCS.Click += new EventHandler(combinacionesCorteSecundarioToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(CombCS);

                ToolStripMenuItem rebobinado = new ToolStripMenuItem();
                rebobinado.Text = "Rebobinado";
                rebobinado.Image = Properties.Resources.rewind;
                rebobinado.Click += new EventHandler(rebobinadoToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(rebobinado);

                ToolStripMenuItem regBobReproc = new ToolStripMenuItem();
                regBobReproc.Text = "Registro de Bobinas para Reproceso";
                regBobReproc.Image = Properties.Resources.reprocess2;
                regBobReproc.Click += new EventHandler(registroDeBobinasParaReprocesoToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(regBobReproc);

                ToolStripMenuItem reetiquetadopeliculasEquiv = new ToolStripMenuItem();
                reetiquetadopeliculasEquiv.Text = "Re-etiquetado peliculas equivalente";
                reetiquetadopeliculasEquiv.Image = Properties.Resources.printer;
                reetiquetadopeliculasEquiv.Click += new EventHandler(reetiquetadoDePeliculaEquivalenteToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(reetiquetadopeliculasEquiv);

                ToolStripMenuItem reetiquetadoStock = new ToolStripMenuItem();
                reetiquetadoStock.Text = "Re-etiquetado a Stock";
                reetiquetadoStock.Image = Properties.Resources.printer;
                reetiquetadoStock.Click += new EventHandler(reetiquetadoAStockToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(reetiquetadoStock);

                ToolStripMenuItem metalizado = new ToolStripMenuItem();
                metalizado.Text = "Metalizado (Sistema Viejo)";
                metalizado.Image = Properties.Resources.coils;
                metalizado.Click += new EventHandler(btnMetlizedOrder_Click);
                Digitacion.DropDownItems.Add(metalizado);

                /*
                ToolStripMenuItem newmetalizado = new ToolStripMenuItem();
                newmetalizado.Text = "Metalizado (Sistema Nuevo)";
                newmetalizado.Image = Properties.Resources.coils;
                newmetalizado.Click += new EventHandler(btnNewMetlizedOrder_Click);
                Digitacion.DropDownItems.Add(newmetalizado);
                */
                ToolStripMenuItem pallets = new ToolStripMenuItem();
                pallets.Text = "Pallets";
                pallets.Image = Properties.Resources.pallet;
                pallets.Click += new EventHandler(palletsToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(pallets);

                ToolStripMenuItem mermas = new ToolStripMenuItem();
                mermas.Text = "Notificacion de Mermas";
                mermas.Image = Properties.Resources.coilMill;
                mermas.Click += new EventHandler(scrapToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(mermas);

                #endregion

                #region Detalle

                ToolStripMenuItem detalle = new ToolStripMenuItem();
                detalle.Text = "Detalle";
                detalle.Image = Properties.Resources.clipboard_text;
                mnu.Items.Add(detalle);

                ToolStripMenuItem estadoDeDepot = new ToolStripMenuItem();
                estadoDeDepot.Text = "Inventario Completo de Pallets";
                estadoDeDepot.Image = Properties.Resources.storage2;
                estadoDeDepot.Click += new EventHandler(EstadoDeDeposito_Click);
                detalle.DropDownItems.Add(estadoDeDepot);

                ToolStripMenuItem estadoDeDepotOP1 = new ToolStripMenuItem();
                estadoDeDepotOP1.Text = "Inventario Completo de Bobinas";
                estadoDeDepotOP1.Image = Properties.Resources.storage2;
                estadoDeDepotOP1.Click += new EventHandler(stockOP1ToolStripMenuItem_Click);
                detalle.DropDownItems.Add(estadoDeDepotOP1);

                ToolStripMenuItem estadobobsue = new ToolStripMenuItem();
                estadobobsue.Text = "Inventario Bobinas Sueltas";
                estadobobsue.Image = Properties.Resources.page_coils;
                estadobobsue.Click += new EventHandler(inventarioDeBobinasSueltasToolStripMenuItem_Click);
                detalle.DropDownItems.Add(estadobobsue);

                ToolStripMenuItem estadoRackCP = new ToolStripMenuItem();
                estadoRackCP.Text = "Estado de Rack Cortadora Primaria";
                estadoRackCP.Image = Properties.Resources.page_coils;
                estadoRackCP.Click += new EventHandler(estadoDeRackCortadoraPrimariaToolStripMenuItem_Click);
                detalle.DropDownItems.Add(estadoRackCP);

                ToolStripMenuItem stockPalletScrap = new ToolStripMenuItem();
                stockPalletScrap.Text = "Stock de Pallets de Merma";
                stockPalletScrap.Image = Properties.Resources.box;
                stockPalletScrap.Click += new EventHandler(stockPalletsScrapToolStripMenuItem_Click);
                detalle.DropDownItems.Add(stockPalletScrap);

                ToolStripMenuItem bobColgantes = new ToolStripMenuItem();
                bobColgantes.Text = "Bobinas Colgantes";
                bobColgantes.Image = Properties.Resources.coils;
                bobColgantes.Click += new EventHandler(bobinasColgantesToolStripMenuItem_Click);
                detalle.DropDownItems.Add(bobColgantes);

                ToolStripMenuItem bobSueltas = new ToolStripMenuItem();
                bobSueltas.Text = "Inventario de Bobinas Sueltas";
                bobSueltas.Image = Properties.Resources.page_coils;
                bobSueltas.Click += new EventHandler(invetarioBobinasSueltasToolStripMenuItem_Click);
                detalle.DropDownItems.Add(bobSueltas);

                ToolStripMenuItem palletDtl = new ToolStripMenuItem();
                palletDtl.Text = "Detalle de Pallet";
                palletDtl.Image = Properties.Resources.pallet;
                palletDtl.Click += new EventHandler(btnPallet_Click);
                detalle.DropDownItems.Add(palletDtl);

                ToolStripMenuItem coilDtl = new ToolStripMenuItem();
                coilDtl.Text = "Detalle de Bobina";
                coilDtl.Image = Properties.Resources.mainCoil;
                coilDtl.Click += new EventHandler(btnCoil_Click);
                detalle.DropDownItems.Add(coilDtl);



                #endregion

            }
            else if (clsGlobal.LoggedUser.RoleName == "Operadores de Metalizado")
            {
                pnlShortCut.Visible = false;
                detalleDePalletToolStripMenuItem.Visible = false;
                listadoDeOrdenesToolStripMenuItem.Visible = false;
                atlasToolStripMenuItem2.Visible = false;
                c230ToolStripMenuItem2.Visible = false;
                c231ToolStripMenuItem2.Visible = false;
                c232ToolStripMenuItem2.Visible = false;
                atlasToolStripMenuItem.Visible = false;
                c230ToolStripMenuItem.Visible = false;
                c231ToolStripMenuItem.Visible = false;
                c232ToolStripMenuItem.Visible = false;
                rebobinadoToolStripMenuItem.Visible = false;
                bobinasToolStripMenuItem.Visible = false;
                toolStripMenuItem1.Visible = false;
                movimientosTSMLog.Visible = false;
                reporteDeMetalizadoTSMItem.Visible = false;
                tsmInProcessCoils.Visible = false;
                tsmOrderList_PL.Visible = false;
                tsmCoils_PL.Visible = false;
            }

            else if (clsGlobal.LoggedUser.RoleName == "Paletizador")
            {
                pnlShortCut.Visible = false;
                digitaciónToolStripMenuItem.Visible = false;
                listadoDeOrdenesToolStripMenuItem.Visible = false;
                atlasToolStripMenuItem2.Visible = false;
                c230ToolStripMenuItem2.Visible = false;
                c231ToolStripMenuItem2.Visible = false;
                c232ToolStripMenuItem2.Visible = false;
                c230ToolStripMenuItem2.Visible = false;
                atlasToolStripMenuItem.Visible = false;
                c230ToolStripMenuItem.Visible = false;
                c231ToolStripMenuItem.Visible = false;
                c232ToolStripMenuItem.Visible = false;
                palletsToolStripMenuItem.Visible = false;
                rebobinadoToolStripMenuItem.Visible = false;
                metalizadoToolStripMenuItem.Visible = false;
                toolStripMenuItem1.Visible = false;
                registroDeBobinasParaReprocesoToolStripMenuItem.Visible = false;
                estadoDeDepositoToolStripMenuItem.Visible = false;
                stockBobinasMadreToolStripMenuItem.Visible = false;
                stockBobinasMadreMetalizadoToolStripMenuItem.Visible = false;
                detalleDeBobinaToolStripMenuItem.Visible = false;
                reporteDeCorteToolStripMenuItem.Visible = false;
                detalleToolStripMenuItem.Visible = false;
                movimientosTSMLog.Visible = false;
                reporteDeMetalizadoTSMItem.Visible = false;
                tsmInProcessCoils.Visible = false;
                tsmOrderList_PL.Visible = false;
                tsmCoils_PL.Visible = false;
            }
            else if (clsGlobal.LoggedUser.RoleName == "Montacarguista")
            {
                mnu.Visible = false;
                pnlShortCut.Visible = true;

                #region Alpha Testin Nuevo sistema de Movimientos
                /*
                frmNewPalletMovement generateNewReport = new frmNewPalletMovement();
                generateNewReport.MdiParent = this;
                generateNewReport.StartPosition = FormStartPosition.CenterScreen;
                generateNewReport.MaximizeBox = false;
                generateNewReport.Show();*/

                #endregion

                #region Viejo sistema Menu Montacarguista Campana

                Button btnCellarMovements = new Button();
                btnCellarMovements.Image = global::BPS.Lite.Properties.Resources.Raw;
                btnCellarMovements.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
                btnCellarMovements.Location = new System.Drawing.Point(10, 12 + (0 * 70));
                btnCellarMovements.Name = "btnCellarMovements";
                btnCellarMovements.Size = new System.Drawing.Size(85, 70);
                btnCellarMovements.TabIndex = 0;
                //btnCellarMovements.Text = "Ingresos";
                btnCellarMovements.Text = "Movimientos";
                btnCellarMovements.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnCellarMovements.UseVisualStyleBackColor = true;
                //btnCellarMovements.Click += new System.EventHandler(this.btnCellarMovements_Click);
                btnCellarMovements.Click += new System.EventHandler(movimientoDePalletInterplantaToolStripMenuItem_Click);
                pnlShortCut.Controls.Add(btnCellarMovements);

                Button btnDepotOut = new Button();
                btnDepotOut.Image = global::BPS.Lite.Properties.Resources.RawOut;
                btnDepotOut.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                btnDepotOut.Location = new System.Drawing.Point(10, 24 + (1 * 70));
                btnDepotOut.Name = "btnBL";
                btnDepotOut.Size = new System.Drawing.Size(85, 70);
                btnDepotOut.TabIndex = 1;
                //btnDepotOut.Text = "Egresos";
                btnDepotOut.Text = "Reasignar";
                btnDepotOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnDepotOut.UseVisualStyleBackColor = true;
                //btnDepotOut.Click += new System.EventHandler(this.btnDepotOut_Click);  
                btnDepotOut.Click += new System.EventHandler(asignacionDePosicionTooStripMenuItem_Click);  

                pnlShortCut.Controls.Add(btnDepotOut);

                Button btnBL = new Button();

                btnBL.Image = global::BPS.Lite.Properties.Resources.ret_1;
                btnBL.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
                btnBL.Location = new System.Drawing.Point(10, 36 + (2 * 70));
                btnBL.Name = "btnBL";
                btnBL.Size = new System.Drawing.Size(85, 70);
                btnBL.TabIndex = 1;
                btnBL.Text = "Deposito";
                btnBL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnBL.UseVisualStyleBackColor = true;
                btnBL.Click += new System.EventHandler(this.estadodedeposito_Click);

                pnlShortCut.Controls.Add(btnBL);

                Button btnPreShipping = new Button();

                btnPreShipping.Image = global::BPS.Lite.Properties.Resources.pallet_24;
                btnPreShipping.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
                btnPreShipping.Location = new System.Drawing.Point(10, 48 + (3 * 70));
                btnPreShipping.Name = "btnPreShipping";
                btnPreShipping.Size = new System.Drawing.Size(85, 70);
                btnPreShipping.TabIndex = 2;
                btnPreShipping.Text = "Pre-Desp. (viejo)";
                btnPreShipping.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnPreShipping.UseVisualStyleBackColor = true;
                btnPreShipping.Click += new System.EventHandler(this.btnPreShipping_Click);

                pnlShortCut.Controls.Add(btnPreShipping);

                Button btnPreShipping2 = new Button();

                btnPreShipping2.Image = global::BPS.Lite.Properties.Resources.pallet_24;
                btnPreShipping2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
                btnPreShipping2.Location = new System.Drawing.Point(10, 48 + (4 * 70));
                btnPreShipping2.Name = "btnPreShipping2";
                btnPreShipping2.Size = new System.Drawing.Size(85, 70);
                btnPreShipping2.TabIndex = 2;
                btnPreShipping2.Text = "Pre-Desp. (nuevo)";
                btnPreShipping2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnPreShipping2.UseVisualStyleBackColor = true;
                btnPreShipping2.Click += new System.EventHandler(this.btnPreShipping2_Click);

                pnlShortCut.Controls.Add(btnPreShipping2);
                /*
                Button btnCuttingOrder = new Button();

                btnCuttingOrder.Image = global::BPS.Lite.Properties.Resources.pallet_24;
                btnCuttingOrder.Location = new System.Drawing.Point(12, 12 + (0 * 77));
                btnCuttingOrder.Name = "btnCutterSalesOrder";
                btnCuttingOrder.Size = new System.Drawing.Size(70, 65);
                btnCuttingOrder.TabIndex = 0;
                btnCuttingOrder.Text = "O. de Venta";
                btnCuttingOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnCuttingOrder.UseVisualStyleBackColor = true;
                btnCuttingOrder.Click += new System.EventHandler(this.btnPalletCutterSalesOrder_Click);

                pnlShortCut.Controls.Add(btnCuttingOrder);

                Button btnStockCuttingOrder = new Button();

                btnStockCuttingOrder.Image = global::BPS.Lite.Properties.Resources.pallet_24;
                btnStockCuttingOrder.Location = new System.Drawing.Point(12, 12 + (1 * 77));
                btnStockCuttingOrder.Name = "btnCutterSalesOrderStock";
                btnStockCuttingOrder.Size = new System.Drawing.Size(70, 65);
                btnStockCuttingOrder.TabIndex = 0;
                btnStockCuttingOrder.Text = "Stock";
                btnStockCuttingOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnStockCuttingOrder.UseVisualStyleBackColor = true;
                btnStockCuttingOrder.Click += new System.EventHandler(this.btnPalletCutterStock_Click);
                
                pnlShortCut.Controls.Add(btnStockCuttingOrder);
                mnu.Items.Remove(detalleDePalletToolStripMenuItem);
                mnu.Items.Remove(digitaciónToolStripMenuItem);
                reporteDeMetalizadoTSMItem.Visible = false;*/

                #endregion


            }
            else if (clsGlobal.LoggedUser.RoleName == "Montacarguista Pilar")
            {

                mnu.Visible = true;
                pnlShortCut.Visible = false;

                frmNewPalletMovement generateNewReport = new frmNewPalletMovement();
                generateNewReport.MaximizeBox = true;
                generateNewReport.Show();

                this.Visible = false;

            }
            else if (clsGlobal.LoggedUser.RoleName == "Operadores de Metalizado")
            {
                Button btnMetlizedOrder = new Button();
                movimientosTSMLog.Visible = false;
                tsmInProcessCoils.Visible = false;
                tsmOrderList_PL.Visible = false;
                tsmCoils_PL.Visible = false;
                btnMetlizedOrder.Image = global::BPS.Lite.Properties.Resources.MDatabase;
                btnMetlizedOrder.Location = new System.Drawing.Point(12, 12 + (0 * 77));
                btnMetlizedOrder.Name = "btnMetlizedOrder";
                btnMetlizedOrder.Size = new System.Drawing.Size(70, 65);
                btnMetlizedOrder.TabIndex = 0;
                btnMetlizedOrder.Text = "Metalizado";
                btnMetlizedOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnMetlizedOrder.UseVisualStyleBackColor = true;
                btnMetlizedOrder.Click += new System.EventHandler(this.btnMetlizedOrder_Click);

                pnlShortCut.Controls.Add(btnMetlizedOrder);

                Button btnDeadTime = new Button();

                btnDeadTime.Image = global::BPS.Lite.Properties.Resources.MDeadTime;
                btnDeadTime.Location = new System.Drawing.Point(12, 12 + (1 * 77));
                btnDeadTime.Name = "btnDeadTime";
                btnDeadTime.Size = new System.Drawing.Size(70, 65);
                btnDeadTime.TabIndex = 0;
                btnDeadTime.Text = "T Muerto";
                btnDeadTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnDeadTime.UseVisualStyleBackColor = true;
                btnDeadTime.Click += new System.EventHandler(this.btnDeadTime_Click);

                pnlShortCut.Controls.Add(btnDeadTime);

                Button btnProductionMetal = new Button();

                btnProductionMetal.Image = global::BPS.Lite.Properties.Resources.report;
                btnProductionMetal.Location = new System.Drawing.Point(12, 12 + (2 * 77));
                btnProductionMetal.Name = "btnProductionMetal";
                btnProductionMetal.Size = new System.Drawing.Size(70, 65);
                btnProductionMetal.TabIndex = 0;
                btnProductionMetal.Text = "Prod-Diaria";
                btnProductionMetal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnProductionMetal.UseVisualStyleBackColor = true;
                btnProductionMetal.Click += new System.EventHandler(this.btnProductionMetal_Click);

                pnlShortCut.Controls.Add(btnProductionMetal);

                Button btnDeadTimeMetalized = new Button();

                btnDeadTimeMetalized.Image = global::BPS.Lite.Properties.Resources.reportOff;
                btnDeadTimeMetalized.Location = new System.Drawing.Point(12, 12 + (3 * 77));
                btnDeadTimeMetalized.Name = "btnDeadTimeMetalized";
                btnDeadTimeMetalized.Size = new System.Drawing.Size(70, 65);
                btnDeadTimeMetalized.TabIndex = 0;
                btnDeadTimeMetalized.Text = "TMuertoRpt";
                btnDeadTimeMetalized.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnDeadTimeMetalized.UseVisualStyleBackColor = true;
                btnDeadTimeMetalized.Click += new System.EventHandler(this.btnDeadTimeMetalized_Click);

                pnlShortCut.Controls.Add(btnDeadTimeMetalized);

                Button btnListMainCoilMetal = new Button();

                btnListMainCoilMetal.Image = global::BPS.Lite.Properties.Resources.script;
                btnListMainCoilMetal.Location = new System.Drawing.Point(12, 12 + (4 * 77));
                btnListMainCoilMetal.Name = "btnListMainCoilMetal";
                btnListMainCoilMetal.Size = new System.Drawing.Size(70, 65);
                btnListMainCoilMetal.TabIndex = 0;
                btnListMainCoilMetal.Text = "Rollos M";
                btnListMainCoilMetal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnListMainCoilMetal.UseVisualStyleBackColor = true;
                btnListMainCoilMetal.Click += new System.EventHandler(this.btnListMainCoilMetal_Click);

                pnlShortCut.Controls.Add(btnListMainCoilMetal);
                mnu.Items.Remove(digitaciónToolStripMenuItem);

                mnu.Items.Remove(detalleDePalletToolStripMenuItem);
                reporteDeMetalizadoTSMItem.Visible = false;
            }
            else if (clsGlobal.LoggedUser.RoleName == "Molinos")
            {
                Button btnMetlizedOrder = new Button();
                movimientosTSMLog.Visible = false;
                tsmInProcessCoils.Visible = false;
                tsmOrderList_PL.Visible = false;
                tsmCoils_PL.Visible = false;
                btnMetlizedOrder.Image = global::BPS.Lite.Properties.Resources.Mill;
                btnMetlizedOrder.Location = new System.Drawing.Point(12, 12 + (0 * 77));
                btnMetlizedOrder.Name = "btnMillOrder";
                btnMetlizedOrder.Size = new System.Drawing.Size(70, 65);
                btnMetlizedOrder.TabIndex = 0;
                btnMetlizedOrder.Text = "Molinos";
                btnMetlizedOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnMetlizedOrder.UseVisualStyleBackColor = true;
                btnMetlizedOrder.Click += new System.EventHandler(this.btnMillOrder_Click);

                pnlShortCut.Controls.Add(btnMetlizedOrder);

                Button btnMillList = new Button();

                btnMillList.Image = global::BPS.Lite.Properties.Resources.script;
                btnMillList.Location = new System.Drawing.Point(12, 12 + (1 * 77));
                btnMillList.Name = "btnMillList";
                btnMillList.Size = new System.Drawing.Size(70, 65);
                btnMillList.TabIndex = 0;
                btnMillList.Text = "Listado";
                btnMillList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnMillList.UseVisualStyleBackColor = true;
                btnMillList.Click += new System.EventHandler(this.btnMillList_Click);

                pnlShortCut.Controls.Add(btnMillList);

                Button btnDeadTime = new Button();

                btnDeadTime.Image = global::BPS.Lite.Properties.Resources.MDeadTime;
                btnDeadTime.Location = new System.Drawing.Point(12, 12 + (2 * 77));
                btnDeadTime.Name = "btnDeadTimeMill";
                btnDeadTime.Size = new System.Drawing.Size(70, 65);
                btnDeadTime.TabIndex = 0;
                btnDeadTime.Text = "T Muerto";
                btnDeadTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnDeadTime.UseVisualStyleBackColor = true;
                btnDeadTime.Click += new System.EventHandler(this.btnDeadTimeMill_Click);

                pnlShortCut.Controls.Add(btnDeadTime);

                Button btnMillPallet = new Button();

                btnMillPallet.Image = global::BPS.Lite.Properties.Resources.report;
                btnMillPallet.Location = new System.Drawing.Point(12, 12 + (3 * 77));
                btnMillPallet.Name = "btnMillPallet";
                btnMillPallet.Size = new System.Drawing.Size(70, 65);
                btnMillPallet.TabIndex = 0;
                btnMillPallet.Text = "ReProceso";
                btnMillPallet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnMillPallet.UseVisualStyleBackColor = true;
                btnMillPallet.Click += new System.EventHandler(this.btnMillPallet_Click);

                pnlShortCut.Controls.Add(btnMillPallet);

                mnu.Items.Remove(detalleDePalletToolStripMenuItem);
                mnu.Items.Remove(digitaciónToolStripMenuItem);
                reporteDeMetalizadoTSMItem.Visible = false;
            }
            else if (clsGlobal.LoggedUser.RoleName == "Operadores Bodega Materia Prima")
            {
                Button btnRawMaterial = new Button();
                movimientosTSMLog.Visible = false;
                tsmInProcessCoils.Visible = false;
                tsmOrderList_PL.Visible = false;
                tsmCoils_PL.Visible = false;
                btnRawMaterial.Image = global::BPS.Lite.Properties.Resources.Raw1;
                btnRawMaterial.Location = new System.Drawing.Point(12, 12 + (0 * 77));
                btnRawMaterial.Name = "btnRawMaterial";
                btnRawMaterial.Size = new System.Drawing.Size(70, 85);
                btnRawMaterial.TabIndex = 0;
                btnRawMaterial.Text = "Materia Prima";
                btnRawMaterial.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnRawMaterial.UseVisualStyleBackColor = true;
                btnRawMaterial.Click += new System.EventHandler(this.btnRawMaterial_Click);

                pnlShortCut.Controls.Add(btnRawMaterial);

                Button btnRawMaterialEdit = new Button();

                btnRawMaterialEdit.Image = global::BPS.Lite.Properties.Resources.pencil_32;
                btnRawMaterialEdit.Location = new System.Drawing.Point(12, 12 + (2 * 77));
                btnRawMaterialEdit.Name = "btnRawMaterialEdit";
                btnRawMaterialEdit.Size = new System.Drawing.Size(70, 85);
                btnRawMaterialEdit.TabIndex = 0;
                btnRawMaterialEdit.Text = "Editar M.P.";
                btnRawMaterialEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnRawMaterialEdit.UseVisualStyleBackColor = true;
                btnRawMaterialEdit.Click += new System.EventHandler(this.btnRawMaterialEdit_Click);

                pnlShortCut.Controls.Add(btnRawMaterialEdit);

                mnu.Items.Remove(detalleDePalletToolStripMenuItem);
                mnu.Items.Remove(digitaciónToolStripMenuItem);
                reporteDeMetalizadoTSMItem.Visible = false;
            }
            else if (clsGlobal.LoggedUser.RoleName == "Operadores Bodega de Producto Terminado")
            {

                movimientosTSMLog.Visible = false;
                tsmInProcessCoils.Visible = false;
                tsmOrderList_PL.Visible = false;
                tsmCoils_PL.Visible = false;
                pnlShortCut.Visible = false;
                mnu.Items.Remove(detalleDePalletToolStripMenuItem);
                mnu.Items.Remove(digitaciónToolStripMenuItem);
                detalleToolStripMenuItem.Visible = false;

                #region Despachos

                ToolStripMenuItem DESPACHOS = new ToolStripMenuItem();
                DESPACHOS.Text = "Despachos";
                mnu.Items.Add(DESPACHOS);

                ToolStripMenuItem predespachos = new ToolStripMenuItem();
                predespachos.Text = "Pre-Despachos (sistema viejo)";
                predespachos.Image = Properties.Resources.clipboard_text;
                predespachos.Click += new EventHandler(predespachos_Click);
                DESPACHOS.DropDownItems.Add(predespachos);

                ToolStripMenuItem predespachos2 = new ToolStripMenuItem();
                predespachos2.Text = "Pre-Despachos (sistema nuevo)";
                predespachos2.Image = Properties.Resources.clipboard_text;
                predespachos2.Click += new EventHandler(btnPreShipping2_Click);
                DESPACHOS.DropDownItems.Add(predespachos2);
                
                ToolStripMenuItem romaneo = new ToolStripMenuItem();
                romaneo.Text = "Romaneo";
                romaneo.Image = Properties.Resources.balance;
                romaneo.Click += new EventHandler(romaneo_Click);
                DESPACHOS.DropDownItems.Add(romaneo);

               /* ToolStripMenuItem despachos = new ToolStripMenuItem();
                despachos.Text = "Despachos (Sistema Viejo)";
                despachos.Image = Properties.Resources.delivery;
                despachos.Click += new EventHandler(despachosviejo_Click);
                DESPACHOS.DropDownItems.Add(despachos);*/

                ToolStripMenuItem despachosV = new ToolStripMenuItem();
                despachosV.Text = "Despachos (Sistema Nuevo)";
                despachosV.Image = Properties.Resources.delivery;
                despachosV.Click += new EventHandler(despachos_Click);
                DESPACHOS.DropDownItems.Add(despachosV);

                ToolStripMenuItem reportedespachos = new ToolStripMenuItem();
                reportedespachos.Text = "Reporte";
                reportedespachos.Image = Properties.Resources.report;
                reportedespachos.Click += new EventHandler(reportedespachos_Click);
                DESPACHOS.DropDownItems.Add(reportedespachos);

                #endregion

                #region Devoluciones

                ToolStripMenuItem DEVOLUCIONES = new ToolStripMenuItem();
                DEVOLUCIONES.Text = "Devoluciones";
                mnu.Items.Add(DEVOLUCIONES);

                ToolStripMenuItem devoluciones = new ToolStripMenuItem();
                devoluciones.Text = "Devoluciones";
                devoluciones.Image = Properties.Resources.arrow_circle_double;
                devoluciones.Click += new EventHandler(devoluciones_Click);
                DEVOLUCIONES.DropDownItems.Add(devoluciones);

                ToolStripMenuItem reportedevoluciones = new ToolStripMenuItem();
                reportedevoluciones.Text = "Reporte";
                reportedevoluciones.Image = Properties.Resources.report;
                reportedevoluciones.Click += new EventHandler(reportedevoluciones_Click);
                DEVOLUCIONES.DropDownItems.Add(reportedevoluciones);

                #endregion

                #region Producto Terminado

                ToolStripMenuItem PRODUCTOTERMINADO = new ToolStripMenuItem();
                PRODUCTOTERMINADO.Text = "Productos";
                mnu.Items.Add(PRODUCTOTERMINADO);

                ToolStripMenuItem estadodedeposito = new ToolStripMenuItem();
                estadodedeposito.Text = "Inventario Completo de Pallets";
                estadodedeposito.Image = Properties.Resources.box1;
                estadodedeposito.Click += new EventHandler(estadodedeposito_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(estadodedeposito);

                ToolStripMenuItem estadopp = new ToolStripMenuItem();
                estadopp.Text = "Inventario Completo de Bobinas";
                estadopp.Image = Properties.Resources.box1;
                estadopp.Click += new EventHandler(stockOP1ToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(estadopp);

                ToolStripMenuItem estadoRackCP = new ToolStripMenuItem();
                estadoRackCP.Text = "Rack Cortadora Primaria Campana";
                estadoRackCP.Image = Properties.Resources.page_coils;
                estadoRackCP.Click += new EventHandler(estadoDeRackCortadoraPrimariaToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(estadoRackCP);

                ToolStripMenuItem estadoRackCP2 = new ToolStripMenuItem();
                estadoRackCP2.Text = "Rack Cortadora Primaria pilar";
                estadoRackCP2.Image = Properties.Resources.page_coils;
                estadoRackCP2.Click += new EventHandler(estadoDeRackCortadoraPrimariaToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(estadoRackCP2);

                ToolStripMenuItem rackMet = new ToolStripMenuItem();
                rackMet.Text = "Rack de Metalizado Pilar";
                rackMet.Image = Properties.Resources.coils;
                rackMet.Click += new EventHandler(estadoDeToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(rackMet);

                ToolStripMenuItem bobColgantes = new ToolStripMenuItem();
                bobColgantes.Text = "Rack de Bobinas Colgantes Campana";
                bobColgantes.Image = Properties.Resources.coils;
                bobColgantes.Click += new EventHandler(bobinasColgantesToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(bobColgantes);

                ToolStripMenuItem estadopaletizado = new ToolStripMenuItem();
                estadopaletizado.Text = "Pallets para mover a producto terminado";
                estadopaletizado.Image = Properties.Resources.box1;
                estadopaletizado.Click += new EventHandler(estadopaletizado_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(estadopaletizado);

                ToolStripMenuItem movimientosprodterminado = new ToolStripMenuItem();
                movimientosprodterminado.Text = "Movimientos";
                movimientosprodterminado.Image = Properties.Resources.arrow_curve;
                movimientosprodterminado.Click += new EventHandler(movimientoDePalletInterplantaToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(movimientosprodterminado);

                ToolStripMenuItem asignacionDePosicion = new ToolStripMenuItem();
                asignacionDePosicion.Text = "Reasignación de posición";
                asignacionDePosicion.Image = Properties.Resources.reprocess;
                asignacionDePosicion.Click += new EventHandler(asignacionDePosicionTooStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(asignacionDePosicion);

               /* ToolStripMenuItem reportemovimientosprodtermianado = new ToolStripMenuItem();
                reportemovimientosprodtermianado.Text = "Reporte Movimientos";
                reportemovimientosprodtermianado.Image = Properties.Resources.reportOff;
                reportemovimientosprodtermianado.Click += new EventHandler(reportemovimientoDePalletInterplantaToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(reportemovimientosprodtermianado);*/

                ToolStripMenuItem swapentreplantasprodterminado = new ToolStripMenuItem();
                swapentreplantasprodterminado.Text = "Swap Entre Plantas";
                swapentreplantasprodterminado.Image = Properties.Resources.delivery;
                swapentreplantasprodterminado.Click += new EventHandler(swapentreplantasprodterminado_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(swapentreplantasprodterminado);

            /*    ToolStripMenuItem reporteswapprodterminado = new ToolStripMenuItem();
                reporteswapprodterminado.Text = "Reporte Swap";
                reporteswapprodterminado.Image = Properties.Resources.reportOff;
                reporteswapprodterminado.Click += new EventHandler(reporteswapprodterminado_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(reporteswapprodterminado);

                ToolStripMenuItem reportImport = new ToolStripMenuItem();
                reportImport.Text = "Reporte Importaciones por bobina";
                reportImport.Image = Properties.Resources.reportOff;
                reportImport.Click += new EventHandler(reporteImportado_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(reportImport);*/

                ToolStripMenuItem exportarapresea = new ToolStripMenuItem();
                exportarapresea.Text = "Exportar a Presea";
                exportarapresea.Image = Properties.Resources.doc_excel_table;
                exportarapresea.Click += new EventHandler(exportarapresea_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(exportarapresea);

                ToolStripMenuItem impoperu = new ToolStripMenuItem();
                impoperu.Text = "Ingreso de importación de Perú";
                impoperu.Image = Properties.Resources.doc_excel_table;
                impoperu.Click += new EventHandler(impoPeruToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(impoperu);

                ToolStripMenuItem impochile = new ToolStripMenuItem();
                impochile.Text = "Ingreso de importación de Perú";
                impochile.Image = Properties.Resources.doc_excel_table;
                impochile.Click += new EventHandler(impoChileToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(impochile);

              /*  ToolStripMenuItem reportePorBobina = new ToolStripMenuItem();
                reportePorBobina.Text = "Reportes por Bobina";
                reportePorBobina.Image = Properties.Resources.coils;
                PRODUCTOTERMINADO.DropDownItems.Add(reportePorBobina);

                ToolStripMenuItem reporteImposxBobina = new ToolStripMenuItem();
                reporteImposxBobina.Text = "Reporte Importaciones por bobina";
                reporteImposxBobina.Image = Properties.Resources.reportOff;
                reporteImposxBobina.Click += new EventHandler(reporteImportado_Click);
                reportePorBobina.DropDownItems.Add(reporteImposxBobina);

                ToolStripMenuItem cuttingReport = new ToolStripMenuItem();
                cuttingReport.Text = "Reporte corte por bobina";
                cuttingReport.Image = Properties.Resources.reportOff;
                cuttingReport.Click += new EventHandler(reporteDeCorteToolStripMenuItem_Click);
                reportePorBobina.DropDownItems.Add(cuttingReport);

                ToolStripMenuItem shippingByCoil = new ToolStripMenuItem();
                shippingByCoil.Text = "Reporte despachos por bobina";
                shippingByCoil.Image = Properties.Resources.observationCoils;
                shippingByCoil.Click += new EventHandler(reporteDespachosPorBobina_Click);
                reportePorBobina.DropDownItems.Add(shippingByCoil);*/

                ToolStripMenuItem reportesGeneral = new ToolStripMenuItem();
                reportesGeneral.Text = "Reportes";
                reportesGeneral.Image = Properties.Resources.reportOff;
                PRODUCTOTERMINADO.DropDownItems.Add(reportesGeneral);

                ToolStripMenuItem reportemovimientosprodtermianado = new ToolStripMenuItem();
                reportemovimientosprodtermianado.Text = "Reporte Movimientos";
                reportemovimientosprodtermianado.Image = Properties.Resources.report;
                reportemovimientosprodtermianado.Click += new EventHandler(reportemovimientoDePalletInterplantaToolStripMenuItem_Click);
                reportesGeneral.DropDownItems.Add(reportemovimientosprodtermianado);

                ToolStripMenuItem reporteswapprodterminado = new ToolStripMenuItem();
                reporteswapprodterminado.Text = "Reporte Swap";
                reporteswapprodterminado.Image = Properties.Resources.report;
                reporteswapprodterminado.Click += new EventHandler(reporteswapprodterminado_Click);
                reportesGeneral.DropDownItems.Add(reporteswapprodterminado);

                ToolStripMenuItem reportImport = new ToolStripMenuItem();
                reportImport.Text = "Reporte Importaciones por bobina";
                reportImport.Image = Properties.Resources.reportOff;
                reportImport.Click += new EventHandler(reporteImportado_Click);
                reportesGeneral.DropDownItems.Add(reportImport);

                ToolStripMenuItem reporteImposxBobina = new ToolStripMenuItem();
                reporteImposxBobina.Text = "Reporte Importaciones por bobina";
                reporteImposxBobina.Image = Properties.Resources.reportOff;
                reporteImposxBobina.Click += new EventHandler(reporteImportado_Click);
                reportesGeneral.DropDownItems.Add(reporteImposxBobina);

                ToolStripMenuItem cuttingReport = new ToolStripMenuItem();
                cuttingReport.Text = "Reporte corte por bobina";
                cuttingReport.Image = Properties.Resources.reportOff;
                cuttingReport.Click += new EventHandler(reporteDeCorteToolStripMenuItem_Click);
                reportesGeneral.DropDownItems.Add(cuttingReport);

                ToolStripMenuItem shippingByCoil = new ToolStripMenuItem();
                shippingByCoil.Text = "Reporte despachos por bobina";
                shippingByCoil.Image = Properties.Resources.report;
                shippingByCoil.Click += new EventHandler(reporteDespachosPorBobina_Click);
                reportesGeneral.DropDownItems.Add(shippingByCoil);

                ToolStripMenuItem reporteReproceso = new ToolStripMenuItem();
                reporteReproceso.Text = "Reporte de Reprocesos";
                reporteReproceso.Click += new EventHandler(reporteRepreocessToolStripMenuItem_Click);
                reportesGeneral.DropDownItems.Add(reporteReproceso);




                #endregion

                #region Materia Prima

                ToolStripMenuItem MATERIAPRIMA = new ToolStripMenuItem();
                MATERIAPRIMA.Text = "Materia Prima";
                mnu.Items.Add(MATERIAPRIMA);

                ToolStripMenuItem estadodedepositomatprima = new ToolStripMenuItem();
                estadodedepositomatprima.Text = "Estado de Deposito";
                estadodedepositomatprima.Image = Properties.Resources.box1;
                estadodedepositomatprima.Click += new EventHandler(estadoDeDepositoMP_Click);
                MATERIAPRIMA.DropDownItems.Add(estadodedepositomatprima);

                ToolStripMenuItem depotStateByDate = new ToolStripMenuItem();
                depotStateByDate.Text = "Estado de deposito por fecha";
                depotStateByDate.Image = Properties.Resources.wooden_box;
                depotStateByDate.Click += new EventHandler(depotMPByDate_Click);
                MATERIAPRIMA.DropDownItems.Add(depotStateByDate);

                ToolStripMenuItem ingresoMP = new ToolStripMenuItem();
                ingresoMP.Text = "Ingresos";
                ingresoMP.Image = Properties.Resources.arrow_incoming;
                MATERIAPRIMA.DropDownItems.Add(ingresoMP);

                ToolStripMenuItem ingresosmatprimapresea = new ToolStripMenuItem();
                ingresosmatprimapresea.Text = "Presea";
                ingresosmatprimapresea.Image = Properties.Resources.quality;
                ingresosmatprimapresea.Click += new EventHandler(ingresosmatprimapresea_Click);
                ingresoMP.DropDownItems.Add(ingresosmatprimapresea);

                ToolStripMenuItem ingresomateriaprimaManual = new ToolStripMenuItem();
                ingresomateriaprimaManual.Text = "Manual";
                ingresomateriaprimaManual.Image = Properties.Resources.arrow_left;
                ingresomateriaprimaManual.Click += new EventHandler(ingresomateriaprimaManual_Click);
                ingresoMP.DropDownItems.Add(ingresomateriaprimaManual);

                ToolStripMenuItem reportIngresoMP = new ToolStripMenuItem();
                reportIngresoMP.Text = "Reporte Ingreso";
                reportIngresoMP.Image = Properties.Resources.reportOff;
                reportIngresoMP.Click += new EventHandler(reportIngresoMP_Click);
                MATERIAPRIMA.DropDownItems.Add(reportIngresoMP);

                ToolStripMenuItem notificacionderecuperadomatprima = new ToolStripMenuItem();
                notificacionderecuperadomatprima.Text = "Notificacion de Recuperado";
                notificacionderecuperadomatprima.Image = Properties.Resources.rewind;
                notificacionderecuperadomatprima.Click += new EventHandler(notificacionderecuperadomatprima_Click);
                MATERIAPRIMA.DropDownItems.Add(notificacionderecuperadomatprima);

                ToolStripMenuItem reImpresionDeEtiqueta = new ToolStripMenuItem();
                reImpresionDeEtiqueta.Text = "Re-impresion de etiquetas de pallets";
                reImpresionDeEtiqueta.Image = Properties.Resources.printer;
                reImpresionDeEtiqueta.Click += new EventHandler(reImpresionDeEtiquetasMP_Click);
                MATERIAPRIMA.DropDownItems.Add(reImpresionDeEtiqueta);

                ToolStripMenuItem movimientosmatprima = new ToolStripMenuItem();
                movimientosmatprima.Text = "Movimientos";
                movimientosmatprima.Image = Properties.Resources.arrow_outgoing;
                movimientosmatprima.Click += new EventHandler(movementInterCellar_Click);
                MATERIAPRIMA.DropDownItems.Add(movimientosmatprima);

                ToolStripMenuItem reportemovimientosmatprima = new ToolStripMenuItem();
                reportemovimientosmatprima.Text = "Reporte Movimientos";
                reportemovimientosmatprima.Image = Properties.Resources.report;
                reportemovimientosmatprima.Click += new EventHandler(reportemovimientosmatprima_Click);
                MATERIAPRIMA.DropDownItems.Add(reportemovimientosmatprima);

                ToolStripMenuItem swapentreplantasmatprima = new ToolStripMenuItem();
                swapentreplantasmatprima.Text = "Swap Entre Plantas";
                swapentreplantasmatprima.Image = Properties.Resources.delivery;
                swapentreplantasmatprima.Click += new EventHandler(swapMateriasPrimas_Click);
                MATERIAPRIMA.DropDownItems.Add(swapentreplantasmatprima);

                ToolStripMenuItem reporteswapmatprima = new ToolStripMenuItem();
                reporteswapmatprima.Text = "Reporte Swap";
                reporteswapmatprima.Image = Properties.Resources.reportOff;
                reporteswapmatprima.Click += new EventHandler(swapRawMaterialReport_Click);
                MATERIAPRIMA.DropDownItems.Add(reporteswapmatprima);

                ToolStripMenuItem despachoMp = new ToolStripMenuItem();
                despachoMp.Text = "Despacho de Materias primas";
                despachoMp.Image = Properties.Resources.page_white_get;
                despachoMp.Click += new EventHandler(despachoMP_Click);
                MATERIAPRIMA.DropDownItems.Add(despachoMp);

                ToolStripMenuItem despachoReport = new ToolStripMenuItem();
                despachoReport.Text = "Reporte de Despachos de Materia Primas";
                despachoReport.Image = Properties.Resources.reportOff;
                despachoReport.Click += new EventHandler(despachoReport_Click);
                MATERIAPRIMA.DropDownItems.Add(despachoReport);

                ToolStripMenuItem generarPalletsHijos = new ToolStripMenuItem();
                generarPalletsHijos.Text = "Generar Pallets MP Hijos";
                generarPalletsHijos.Image = Properties.Resources.reprocess;
                generarPalletsHijos.Click += new EventHandler(generarPalletHijo_Click);
                MATERIAPRIMA.DropDownItems.Add(generarPalletsHijos);

                #endregion

                #region Scrap

                ToolStripMenuItem SCRAP = new ToolStripMenuItem();
                SCRAP.Text = "Scrap";
                mnu.Items.Add(SCRAP);

                ToolStripMenuItem estadodedepositoscrap = new ToolStripMenuItem();
                estadodedepositoscrap.Text = "Estado de Deposito";
                estadodedepositoscrap.Image = Properties.Resources.storage2;
                estadodedepositoscrap.Click += new EventHandler(estadodedepositoscrap_Click);
                SCRAP.DropDownItems.Add(estadodedepositoscrap);

                ToolStripMenuItem movimientosscrap = new ToolStripMenuItem();
                movimientosscrap.Text = "Movimientos";
                movimientosscrap.Image = Properties.Resources.arrow_curve;
                movimientosscrap.Click += new EventHandler(movimientosscrap_Click);
                SCRAP.DropDownItems.Add(movimientosscrap);

                ToolStripMenuItem reportemovimientosscrap = new ToolStripMenuItem();
                reportemovimientosscrap.Text = "Reporte Movimientos";
                reportemovimientosscrap.Image = Properties.Resources.report;
                reportemovimientosscrap.Click += new EventHandler(reportemovimientosscrap_Click);
                SCRAP.DropDownItems.Add(reportemovimientosscrap);

                ToolStripMenuItem swappalletscrap = new ToolStripMenuItem();
                swappalletscrap.Text = "Swap de Pallet Scrap";
                swappalletscrap.Image = Properties.Resources.delivery;
                swappalletscrap.Click += new EventHandler(swapScrapPallet_Click);
                SCRAP.DropDownItems.Add(swappalletscrap);


                ToolStripMenuItem swappalletscrapreport = new ToolStripMenuItem();
                swappalletscrapreport.Text = "Reporte Swap de Pallets de Scrap";
                swappalletscrapreport.Image = Properties.Resources.report;
                swappalletscrapreport.Click += new EventHandler(scrapPalletSwapReportMenuItem_Click);
                SCRAP.DropDownItems.Add(swappalletscrapreport);
                
                #endregion

            }
            else if (clsGlobal.LoggedUser.RoleName == "Logistica Pilar")
            {
                //Botones para resto de los usuarios
                //pnlShortCut.Visible = false;
                movimientosTSMLog.Visible = false;
                tsmInProcessCoils.Visible = false;
                tsmOrderList_PL.Visible = false;
                tsmCoils_PL.Visible = false;
                pnlShortCut.Visible = false;
                mnu.Items.Remove(detalleDePalletToolStripMenuItem);
                mnu.Items.Remove(digitaciónToolStripMenuItem);
                detalleToolStripMenuItem.Visible = false;

                #region Despachos

                ToolStripMenuItem DESPACHOS = new ToolStripMenuItem();
                DESPACHOS.Text = "Despachos";
                mnu.Items.Add(DESPACHOS);

                ToolStripMenuItem predespachos = new ToolStripMenuItem();
                predespachos.Text = "Pre-Despachos (sistema viejo)";
                predespachos.Image = Properties.Resources.clipboard_text;
                predespachos.Click += new EventHandler(predespachosPL_Click);
                DESPACHOS.DropDownItems.Add(predespachos);

                ToolStripMenuItem predespachos2 = new ToolStripMenuItem();
                predespachos2.Text = "Pre-Despachos (sistema nuevo)";
                predespachos2.Image = Properties.Resources.clipboard_text;
                predespachos2.Click += new EventHandler(btnPreShipping2_Click);
                DESPACHOS.DropDownItems.Add(predespachos2);

                ToolStripMenuItem romaneo = new ToolStripMenuItem();
                romaneo.Text = "Romaneo";
                romaneo.Image = Properties.Resources.box1;
                romaneo.Click += new EventHandler(romaneo_Click);
                DESPACHOS.DropDownItems.Add(romaneo);

                /*ToolStripMenuItem despachos = new ToolStripMenuItem();
                despachos.Text = "Despachos (Sistema Viejo)";
                despachos.Image = Properties.Resources.delivery;
                despachos.Click += new EventHandler(despachosviejo_Click);
                DESPACHOS.DropDownItems.Add(despachos);*/

                ToolStripMenuItem despachosV = new ToolStripMenuItem();
                despachosV.Text = "Despachos (Sistema Nuevo)";
                despachosV.Image = Properties.Resources.delivery;
                despachosV.Click += new EventHandler(despachos_Click);
                DESPACHOS.DropDownItems.Add(despachosV);

                ToolStripMenuItem reportedespachos = new ToolStripMenuItem();
                reportedespachos.Text = "Reporte";
                reportedespachos.Image = Properties.Resources.report;
                reportedespachos.Click += new EventHandler(reportedespachos_Click);
                DESPACHOS.DropDownItems.Add(reportedespachos);

                #endregion

                #region Devoluciones

                ToolStripMenuItem DEVOLUCIONES = new ToolStripMenuItem();
                DEVOLUCIONES.Text = "Devoluciones";
                mnu.Items.Add(DEVOLUCIONES);

                ToolStripMenuItem devoluciones = new ToolStripMenuItem();
                devoluciones.Text = "Devoluciones";
                devoluciones.Image = Properties.Resources.arrow_left_red;
                devoluciones.Click += new EventHandler(devoluciones_Click);
                DEVOLUCIONES.DropDownItems.Add(devoluciones);

                ToolStripMenuItem reportedevoluciones = new ToolStripMenuItem();
                reportedevoluciones.Text = "Reporte";
                reportedevoluciones.Image = Properties.Resources.report;
                reportedevoluciones.Click += new EventHandler(reportedevoluciones_Click);
                DEVOLUCIONES.DropDownItems.Add(reportedevoluciones);

                #endregion

                #region Producto Terminado

                ToolStripMenuItem PRODUCTOTERMINADO = new ToolStripMenuItem();
                PRODUCTOTERMINADO.Text = "Productos";
                mnu.Items.Add(PRODUCTOTERMINADO);

                ToolStripMenuItem estadodedeposito = new ToolStripMenuItem();
                estadodedeposito.Text = "Inventario de Pallets";
                estadodedeposito.Image = Properties.Resources.box1;
                estadodedeposito.Click += new EventHandler(estadodedeposito_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(estadodedeposito);

                ToolStripMenuItem historialPallets = new ToolStripMenuItem();
                historialPallets.Text = "Historial inventario de pallets";
                historialPallets.Image = Properties.Resources.calendar_2;
                historialPallets.Click += new EventHandler(historialCompletoDePalletsToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(historialPallets);

                ToolStripMenuItem estadopp = new ToolStripMenuItem();
                estadopp.Text = "Inventario de Bobinas";
                estadopp.Image = Properties.Resources.box1;
                estadopp.Click += new EventHandler(stockOP1ToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(estadopp);

                ToolStripMenuItem historialBobinas = new ToolStripMenuItem();
                historialBobinas.Text = "Historial inventario de bobinas";
                historialBobinas.Image = Properties.Resources.calendar_2;
                historialBobinas.Click += new EventHandler(historialCompletoDeBobinasToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(historialBobinas);

                /*ToolStripMenuItem estadoRackCP = new ToolStripMenuItem();
                estadoRackCP.Text = "Rack Cortadora Primaria Campana";
                estadoRackCP.Image = Properties.Resources.page_coils;
                estadoRackCP.Click += new EventHandler(estadoDeRackCortadoraPrimariaToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(estadoRackCP);*/

                ToolStripMenuItem estadoRackCP2 = new ToolStripMenuItem();
                estadoRackCP2.Text = "Rack Primario Pilar";
                estadoRackCP2.Image = Properties.Resources.page_coils;
                estadoRackCP2.Click += new EventHandler(estadoDeRackCortadoraPrimariaToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(estadoRackCP2);

                ToolStripMenuItem historialRackPrimario = new ToolStripMenuItem();
                historialRackPrimario.Text = "Historial de Rack Primario";
                historialRackPrimario.Image = Properties.Resources.calendar_2;
                historialRackPrimario.Click += new EventHandler(historialRackPrimarioToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(historialRackPrimario);

                ToolStripMenuItem rackMet = new ToolStripMenuItem();
                rackMet.Text = "Rack Secundario Pilar";
                rackMet.Image = Properties.Resources.coils;
                rackMet.Click += new EventHandler(estadoDeToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(rackMet);

                ToolStripMenuItem historialRackSecundario = new ToolStripMenuItem();
                historialRackSecundario.Text = "Historial de Rack Secundario";
                historialRackSecundario.Image = Properties.Resources.calendar_2;
                historialRackSecundario.Click += new EventHandler(historialRackSecundarioToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(historialRackSecundario);

                /*ToolStripMenuItem bobColgantes = new ToolStripMenuItem();
                bobColgantes.Text = "Rack de Bobinas Colgantes Campana";
                bobColgantes.Image = Properties.Resources.coils;
                bobColgantes.Click += new EventHandler(bobinasColgantesToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(bobColgantes);*/

                ToolStripMenuItem estadopaletizado = new ToolStripMenuItem();
                estadopaletizado.Text = "Pallets para mover a producto terminado";
                estadopaletizado.Image = Properties.Resources.box1;
                estadopaletizado.Click += new EventHandler(estadopaletizado_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(estadopaletizado);

                ToolStripMenuItem movimientosprodterminado = new ToolStripMenuItem();
                movimientosprodterminado.Text = "Movimientos";
                movimientosprodterminado.Image = Properties.Resources.arrow_curve;
                movimientosprodterminado.Click += new EventHandler(movimientoDePalletInterplantaToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(movimientosprodterminado);

                ToolStripMenuItem movimientoNuevo = new ToolStripMenuItem();
                movimientoNuevo.Text = "Movimiento Nuevo";
                movimientoNuevo.Image = Properties.Resources.delivery;
                movimientoNuevo.Click += new EventHandler(newPalletMovement_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(movimientoNuevo);

                ToolStripMenuItem asignacionDePosicion = new ToolStripMenuItem();
                asignacionDePosicion.Text = "Reasignación de posición";
                asignacionDePosicion.Image = Properties.Resources.reprocess;
                asignacionDePosicion.Click += new EventHandler(asignacionDePosicionTooStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(asignacionDePosicion);

                /*ToolStripMenuItem ingresosprodterminado = new ToolStripMenuItem();
                ingresosprodterminado.Text = "Ingresos";
                ingresosprodterminado.Click += new EventHandler(ingresosprodterminado_Click);
                movimientosprodterminado.DropDownItems.Add(ingresosprodterminado);

                ToolStripMenuItem egresosprodterminado = new ToolStripMenuItem();
                egresosprodterminado.Text = "Egresos";
                egresosprodterminado.Click += new EventHandler(egresosprodterminado_Click);
                movimientosprodterminado.DropDownItems.Add(egresosprodterminado);*/

                ToolStripMenuItem swapentreplantasprodterminado = new ToolStripMenuItem();
                swapentreplantasprodterminado.Text = "Swap Entre Plantas";
                swapentreplantasprodterminado.Image = Properties.Resources.arrow_right_orange;
                swapentreplantasprodterminado.Click += new EventHandler(swapentreplantasprodterminado_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(swapentreplantasprodterminado);

               

                ToolStripMenuItem exportarapresea = new ToolStripMenuItem();
                exportarapresea.Text = "Exportar a Presea";
                exportarapresea.Image = Properties.Resources.doc_excel_table;
                exportarapresea.Click += new EventHandler(exportarapreseaPL_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(exportarapresea);

                ToolStripMenuItem impoperu = new ToolStripMenuItem();
                impoperu.Text = "Ingreso de importación de Perú";
                impoperu.Image = Properties.Resources.Raw1;
                impoperu.Click += new EventHandler(impoPeruToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(impoperu);

                ToolStripMenuItem impochile = new ToolStripMenuItem();
                impochile.Text = "Ingreso de importación de Chile";
                impochile.Image = Properties.Resources.Raw1;
                impochile.Click += new EventHandler(impoChileToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(impochile);

                

                

               

                

                
/*
                ToolStripMenuItem PRODUCTOTERMINADO = new ToolStripMenuItem();
                PRODUCTOTERMINADO.Text = "Producto Terminado";
                mnu.Items.Add(PRODUCTOTERMINADO);

                ToolStripMenuItem estadodedeposito = new ToolStripMenuItem();
                estadodedeposito.Text = "Estado de Deposito";
                estadodedeposito.Click += new EventHandler(estadodedeposito_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(estadodedeposito);

                ToolStripMenuItem movimientosprodterminado = new ToolStripMenuItem();
                movimientosprodterminado.Text = "Movimientos";
                //reportedevoluciones.Click += new EventHandler(ordenesDeExtrusiónBoppToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(movimientosprodterminado);

                ToolStripMenuItem reportemovimientosprodtermianado = new ToolStripMenuItem();
                reportemovimientosprodtermianado.Text = "Reporte Movimientos";
                //reportemovimientosprodtermianado.Click += new EventHandler(ordenesDeExtrusiónBoppToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(reportemovimientosprodtermianado);

                ToolStripMenuItem swapentreplantasprodterminado = new ToolStripMenuItem();
                swapentreplantasprodterminado.Text = "Swap Entre Plantas";
                swapentreplantasprodterminado.Click += new EventHandler(swapentreplantasprodterminado_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(swapentreplantasprodterminado);

                ToolStripMenuItem reporteswapprodterminado = new ToolStripMenuItem();
                reporteswapprodterminado.Text = "Reporte Swap";
                reporteswapprodterminado.Click += new EventHandler(reporteswapprodterminado_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(reporteswapprodterminado);

                ToolStripMenuItem exportarapreseaPL = new ToolStripMenuItem();
                exportarapreseaPL.Text = "Exportar a Presea";
                exportarapreseaPL.Click += new EventHandler(exportarapreseaPL_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(exportarapreseaPL);
*/

                ToolStripMenuItem reportesGeneral = new ToolStripMenuItem();
                reportesGeneral.Text = "Reportes";
                reportesGeneral.Image = Properties.Resources.reportOff;
                PRODUCTOTERMINADO.DropDownItems.Add(reportesGeneral);

                ToolStripMenuItem reportemovimientosprodtermianado = new ToolStripMenuItem();
                reportemovimientosprodtermianado.Text = "Reporte Movimientos";
                reportemovimientosprodtermianado.Image = Properties.Resources.report;
                reportemovimientosprodtermianado.Click += new EventHandler(reportemovimientoDePalletInterplantaToolStripMenuItem_Click);
                reportesGeneral.DropDownItems.Add(reportemovimientosprodtermianado);
                
                ToolStripMenuItem reporteswapprodterminado = new ToolStripMenuItem();
                reporteswapprodterminado.Text = "Reporte Swap";
                reporteswapprodterminado.Image = Properties.Resources.report;
                reporteswapprodterminado.Click += new EventHandler(reporteswapprodterminado_Click);
                reportesGeneral.DropDownItems.Add(reporteswapprodterminado);

                ToolStripMenuItem reportImport = new ToolStripMenuItem();
                reportImport.Text = "Reporte Importaciones por bobina";
                reportImport.Image = Properties.Resources.reportOff;
                reportImport.Click += new EventHandler(reporteImportado_Click);
                reportesGeneral.DropDownItems.Add(reportImport);

                ToolStripMenuItem reporteImposxBobina = new ToolStripMenuItem();
                reporteImposxBobina.Text = "Reporte Importaciones por bobina";
                reporteImposxBobina.Image = Properties.Resources.reportOff;
                reporteImposxBobina.Click += new EventHandler(reporteImportado_Click);
                reportesGeneral.DropDownItems.Add(reporteImposxBobina);

                ToolStripMenuItem cuttingReport = new ToolStripMenuItem();
                cuttingReport.Text = "Reporte corte por bobina";
                cuttingReport.Image = Properties.Resources.reportOff;
                cuttingReport.Click += new EventHandler(reporteDeCorteToolStripMenuItem_Click);
                reportesGeneral.DropDownItems.Add(cuttingReport);

                ToolStripMenuItem shippingByCoil = new ToolStripMenuItem();
                shippingByCoil.Text = "Reporte despachos por bobina";
                shippingByCoil.Image = Properties.Resources.report;
                shippingByCoil.Click += new EventHandler(reporteDespachosPorBobina_Click);
                reportesGeneral.DropDownItems.Add(shippingByCoil);

                ToolStripMenuItem reporteReproceso = new ToolStripMenuItem();
                reporteReproceso.Text = "Reporte de Reprocesos";
                reporteReproceso.Click += new EventHandler(reporteRepreocessToolStripMenuItem_Click);
                reportesGeneral.DropDownItems.Add(reporteReproceso);


                #endregion

                #region Materia Prima

                ToolStripMenuItem MATERIAPRIMA = new ToolStripMenuItem();
                MATERIAPRIMA.Text = "Materia Prima";
                mnu.Items.Add(MATERIAPRIMA);

                ToolStripMenuItem estadodedepositomatprima = new ToolStripMenuItem();
                estadodedepositomatprima.Text = "Estado de Deposito";
                estadodedepositomatprima.Image = Properties.Resources.box1;
                estadodedepositomatprima.Click += new EventHandler(estadoDeDepositoMP_Click);
                MATERIAPRIMA.DropDownItems.Add(estadodedepositomatprima);

                ToolStripMenuItem historialMateriaPrima = new ToolStripMenuItem();
                historialMateriaPrima.Text = "Historial de deposito de materia prima";
                historialMateriaPrima.Image = Properties.Resources.calendar;
                historialMateriaPrima.Click += new EventHandler(toolStripMenuItem2_Click);
                MATERIAPRIMA.DropDownItems.Add(historialMateriaPrima);

                /*ToolStripMenuItem depotStateByDate = new ToolStripMenuItem();
                depotStateByDate.Text = "Estado de deposito por fecha";
                depotStateByDate.Image = Properties.Resources.calendar;
                depotStateByDate.Click += new EventHandler(depotMPByDate_Click);
                MATERIAPRIMA.DropDownItems.Add(depotStateByDate);*/

                ToolStripMenuItem ingresoMP = new ToolStripMenuItem();
                ingresoMP.Text = "Ingresos";
                ingresoMP.Image = Properties.Resources.arrow_incoming;
                MATERIAPRIMA.DropDownItems.Add(ingresoMP);

                ToolStripMenuItem ingresosmatprimapresea = new ToolStripMenuItem();
                ingresosmatprimapresea.Text = "Presea";
                ingresosmatprimapresea.Image = Properties.Resources.server;
                ingresosmatprimapresea.Click += new EventHandler(ingresosmatprimapresea_Click);
                ingresoMP.DropDownItems.Add(ingresosmatprimapresea);

                ToolStripMenuItem ingresomateriaprimaManual = new ToolStripMenuItem();
                ingresomateriaprimaManual.Text = "Manual";
                ingresomateriaprimaManual.Image = Properties.Resources.add1;
                ingresomateriaprimaManual.Click += new EventHandler(ingresomateriaprimaManual_Click);
                ingresoMP.DropDownItems.Add(ingresomateriaprimaManual);

                ToolStripMenuItem reportIngresoMP = new ToolStripMenuItem();
                reportIngresoMP.Text = "Reporte Ingreso";
                reportIngresoMP.Image = Properties.Resources.report;
                reportIngresoMP.Click += new EventHandler(reportIngresoMP_Click);
                MATERIAPRIMA.DropDownItems.Add(reportIngresoMP);

                ToolStripMenuItem notificacionderecuperadomatprima = new ToolStripMenuItem();
                notificacionderecuperadomatprima.Text = "Notificacion de Recuperado";
                notificacionderecuperadomatprima.Image = Properties.Resources.Mill;
                notificacionderecuperadomatprima.Click += new EventHandler(notificacionderecuperadomatprima_Click);
                MATERIAPRIMA.DropDownItems.Add(notificacionderecuperadomatprima);

                ToolStripMenuItem reImpresionDeEtiqueta = new ToolStripMenuItem();
                reImpresionDeEtiqueta.Text = "Re-impresion de etiquetas de pallets";
                reImpresionDeEtiqueta.Image = Properties.Resources.printer;
                reImpresionDeEtiqueta.Click += new EventHandler(reImpresionDeEtiquetasMP_Click);
                MATERIAPRIMA.DropDownItems.Add(reImpresionDeEtiqueta);

                ToolStripMenuItem movimientosmatprima = new ToolStripMenuItem();
                movimientosmatprima.Text = "Movimientos";
                movimientosmatprima.Image = Properties.Resources.arrow_outgoing;
                movimientosmatprima.Click += new EventHandler(movementInterCellar_Click);
                MATERIAPRIMA.DropDownItems.Add(movimientosmatprima);

                ToolStripMenuItem reportemovimientosmatprima = new ToolStripMenuItem();
                reportemovimientosmatprima.Text = "Reporte Movimientos";
                reportemovimientosmatprima.Image = Properties.Resources.report;
                reportemovimientosmatprima.Click += new EventHandler(reportemovimientosmatprima_Click);
                MATERIAPRIMA.DropDownItems.Add(reportemovimientosmatprima);

                ToolStripMenuItem swapentreplantasmatprima = new ToolStripMenuItem();
                swapentreplantasmatprima.Text = "Swap Entre Plantas";
                swapentreplantasmatprima.Image = Properties.Resources.delivery;
                swapentreplantasmatprima.Click += new EventHandler(swapMateriasPrimas_Click);
                MATERIAPRIMA.DropDownItems.Add(swapentreplantasmatprima);

                ToolStripMenuItem reporteswapmatprima = new ToolStripMenuItem();
                reporteswapmatprima.Text = "Reporte Swap";
                reporteswapmatprima.Image = Properties.Resources.report;
                reporteswapmatprima.Click += new EventHandler(swapRawMaterialReport_Click);
                MATERIAPRIMA.DropDownItems.Add(reporteswapmatprima);

                ToolStripMenuItem despachoMp = new ToolStripMenuItem();
                despachoMp.Text = "Despacho de Materias primas";
                despachoMp.Image = Properties.Resources.delivery;
                despachoMp.Click += new EventHandler(despachoMP_Click);
                MATERIAPRIMA.DropDownItems.Add(despachoMp);

                ToolStripMenuItem despachoReport = new ToolStripMenuItem();
                despachoReport.Text = "Reporte de Despachos de Materia Primas";
                despachoReport.Image = Properties.Resources.report;
                despachoReport.Click += new EventHandler(despachoReport_Click);
                MATERIAPRIMA.DropDownItems.Add(despachoReport);


                ToolStripMenuItem generarPalletsHijos = new ToolStripMenuItem();
                generarPalletsHijos.Text = "Generar Pallets MP Hijos";
                generarPalletsHijos.Image = Properties.Resources.reprocess;
                generarPalletsHijos.Click += new EventHandler(generarPalletHijo_Click);
                MATERIAPRIMA.DropDownItems.Add(generarPalletsHijos);


                /*ToolStripMenuItem reporteConsumoMP = new ToolStripMenuItem();
                reporteswapmatprimaconsumo.Text = "Reporte Consumo Materias Primas";
                reporteswapmatprimaconsumo.Click += new EventHandler(ordenesDeExtrusiónBoppToolStripMenuItem_Click);
                MATERIAPRIMA.DropDownItems.Add(reporteswapmatprimaconsumo);*/

                #endregion

                #region Scrap

                ToolStripMenuItem SCRAP = new ToolStripMenuItem();
                SCRAP.Text = "Scrap";
                mnu.Items.Add(SCRAP);

                ToolStripMenuItem estadodedepositoscrap = new ToolStripMenuItem();
                estadodedepositoscrap.Text = "Estado de Deposito";
                estadodedepositoscrap.Image = Properties.Resources.wooden_box;
                estadodedepositoscrap.Click += new EventHandler(estadodedepositoscrap_Click);
                SCRAP.DropDownItems.Add(estadodedepositoscrap);

                ToolStripMenuItem movimientosscrap = new ToolStripMenuItem();
                movimientosscrap.Text = "Movimientos";
                movimientosscrap.Image = Properties.Resources.arrow_outgoing;
                movimientosscrap.Click += new EventHandler(movimientosscrap_Click);
                SCRAP.DropDownItems.Add(movimientosscrap);

                ToolStripMenuItem reportemovimientosscrap = new ToolStripMenuItem();
                reportemovimientosscrap.Text = "Reporte Movimientos";
                reportemovimientosscrap.Image = Properties.Resources.report;
                reportemovimientosscrap.Click += new EventHandler(reportemovimientosscrap_Click);
                SCRAP.DropDownItems.Add(reportemovimientosscrap);

                ToolStripMenuItem swappalletscrap = new ToolStripMenuItem();
                swappalletscrap.Text = "Swap de Pallet Scrap";
                swappalletscrap.Image = Properties.Resources.delivery;
                swappalletscrap.Click += new EventHandler(swapScrapPallet_Click);
                SCRAP.DropDownItems.Add(swappalletscrap);

                ToolStripMenuItem swappalletscrapreport = new ToolStripMenuItem();
                swappalletscrapreport.Text = "Reporte Swap de Pallets de Scrap";
                swappalletscrapreport.Image = Properties.Resources.report;
                swappalletscrapreport.Click += new EventHandler(scrapPalletSwapReportMenuItem_Click);
                SCRAP.DropDownItems.Add(swappalletscrapreport);

                #endregion

                #region corte
                ToolStripMenuItem lstOrdenes = new ToolStripMenuItem();
                lstOrdenes.Text = "Corte";
                mnu.Items.Add(lstOrdenes);

                ToolStripMenuItem goebel = new ToolStripMenuItem();
                goebel.Text = "Goebel";
                goebel.Image = Properties.Resources.gear_16;
                goebel.Click += new EventHandler(goebelToolStripMenuItem_Click);
                lstOrdenes.DropDownItems.Add(goebel);

                ToolStripMenuItem atlas = new ToolStripMenuItem();
                atlas.Text = "Atlas";
                atlas.Image = Properties.Resources.gear_16;
                atlas.Click += new EventHandler(atlasToolStripMenuItem1_Click_1);
                lstOrdenes.DropDownItems.Add(atlas);

                ToolStripMenuItem titan = new ToolStripMenuItem();
                titan.Text = "Titan";
                titan.Image = Properties.Resources.gear_16;
                titan.Click += new EventHandler(titanToolStripMenuItem_Click);
                lstOrdenes.DropDownItems.Add(titan);
                #endregion

                ToolStripMenuItem reports = new ToolStripMenuItem();
                reports.Text = "Reportes";
                //reports.Image = Properties.Resources.report;
                mnu.Items.Add(reports);

                ToolStripMenuItem cutReport = new ToolStripMenuItem();
                cutReport.Text = "Reporte de Corte";
                cutReport.Click += new EventHandler(reporteDeCorteToolStripMenuItem_Click);
                cutReport.Image = Properties.Resources.reportOff;
                reports.DropDownItems.Add(cutReport);

                ToolStripMenuItem metallizedReport = new ToolStripMenuItem();
                metallizedReport.Text = "Reporte de Metalizado";
                metallizedReport.Click += new EventHandler(reporteDeMetalizadoTSMItem_Click);
                metallizedReport.Image = Properties.Resources.reportOff;
                reports.DropDownItems.Add(metallizedReport);

                ToolStripMenuItem rewindReport = new ToolStripMenuItem();
                rewindReport.Text = "Reporte de Rebobinado";
                rewindReport.Click += new EventHandler(reporteDeRebobinadoToolStripMenuItem_Click);
                rewindReport.Image = Properties.Resources.reportOff;
                reports.DropDownItems.Add(rewindReport);

                ToolStripMenuItem scrapReport = new ToolStripMenuItem();
                scrapReport.Text = "Reporte de Pallets de Merma";
                scrapReport.Click += new EventHandler(reportesDePalletsDeMermaToolStripMenuItem_Click);
                scrapReport.Image = Properties.Resources.reportOff;
                reports.DropDownItems.Add(scrapReport);

                ToolStripMenuItem scrapMovHistory = new ToolStripMenuItem();
                scrapMovHistory.Text = "Reporte Movimiento de Mermas";
                scrapMovHistory.Click += new EventHandler(movimientosDeScrapToolStripMenuItem_Click);
                scrapMovHistory.Image = Properties.Resources.reportOff;
                reports.DropDownItems.Add(scrapMovHistory);

                ToolStripMenuItem extrep = new ToolStripMenuItem();
                extrep.Text = "Reporte de extrusión";
                extrep.Click += new EventHandler(reporteDeExtrusiónToolStripMenuItem_Click);
                extrep.Image = Properties.Resources.reportOff;
                reports.DropDownItems.Add(extrep);

                ToolStripMenuItem prodcont = new ToolStripMenuItem();
                prodcont.Text = "Control de resultados entre fechas";
                prodcont.Click += new EventHandler(prodcontToolStripMenuItem_Click);
                prodcont.Image = Properties.Resources.coils;
                reports.DropDownItems.Add(prodcont);

                ToolStripMenuItem prodcont2 = new ToolStripMenuItem();
                prodcont2.Text = "Control de resultados por turno";
                prodcont2.Click += new EventHandler(prodcont2ToolStripMenuItem_Click);
                prodcont2.Image = Properties.Resources.coils;
                reports.DropDownItems.Add(prodcont2);

                #region Cod Comentado

                /*
                Button btnBL = new Button();

                btnBL.Image = global::BPS.Lite.Properties.Resources.ret_1;
                btnBL.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
                btnBL.Location = new System.Drawing.Point(2, 12 + (0 * 70));
                btnBL.Name = "btnBL";
                btnBL.Size = new System.Drawing.Size(95, 70);
                btnBL.TabIndex = 1;
                btnBL.Text = "Deposito";
                btnBL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnBL.UseVisualStyleBackColor = true;
                btnBL.Click += new System.EventHandler(this.btnBL2_Click);
                pnlShortCut.Controls.Add(btnBL);

                Button btnPreShipping = new Button();

                btnPreShipping.Image = global::BPS.Lite.Properties.Resources.pallet_24;
                btnPreShipping.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
                btnPreShipping.Location = new System.Drawing.Point(2, 24 + (1 * 70));
                btnPreShipping.Name = "btnPreShipping";
                btnPreShipping.Size = new System.Drawing.Size(95, 70);
                btnPreShipping.TabIndex = 2;
                btnPreShipping.Text = "Pre - Despachos";
                btnPreShipping.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnPreShipping.UseVisualStyleBackColor = true;
                btnPreShipping.Click += new System.EventHandler(this.btnPreShippingPL_Click);

                pnlShortCut.Controls.Add(btnPreShipping);

                Button btnShipping = new Button();

                btnShipping.Image = global::BPS.Lite.Properties.Resources.delivery;
                //btnShipping.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
                btnShipping.Location = new System.Drawing.Point(2, 36 + (2 * 70));
                btnShipping.Name = "btnShipping";
                btnShipping.Size = new System.Drawing.Size(95, 70);
                btnShipping.TabIndex = 2;
                btnShipping.Text = "Despachos";
                btnShipping.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnShipping.UseVisualStyleBackColor = true;
                btnShipping.Click += new System.EventHandler(this.btnShipping_Click);

                pnlShortCut.Controls.Add(btnShipping);

                Button btnReturn = new Button();

                btnReturn.Image = global::BPS.Lite.Properties.Resources.Return;
                //btnReturn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
                btnReturn.Location = new System.Drawing.Point(2, 48 + (3 * 70));
                btnReturn.Name = "btnReturn";
                btnReturn.Size = new System.Drawing.Size(95, 70);
                btnReturn.TabIndex = 2;
                btnReturn.Text = "Devoluciones";
                btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnReturn.UseVisualStyleBackColor = true;
                btnReturn.Click += new System.EventHandler(this.btnReturn_Click);

                pnlShortCut.Controls.Add(btnReturn);

                Button btnExpPresea = new Button();

                btnExpPresea.Image = global::BPS.Lite.Properties.Resources.arrow_right;
                btnExpPresea.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
                btnExpPresea.Location = new System.Drawing.Point(2, 60 + (4 * 70));
                btnExpPresea.Name = "btnExpPresea";
                btnExpPresea.Size = new System.Drawing.Size(95, 70);
                btnExpPresea.TabIndex = 2;
                btnExpPresea.Text = "Exportar Ingresos";
                btnExpPresea.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnExpPresea.UseVisualStyleBackColor = true;
                btnExpPresea.Click += new System.EventHandler(this.btnExpPreseaPL_Click);

                pnlShortCut.Controls.Add(btnExpPresea);

                Button btnSwap = new Button();

                btnSwap.Image = global::BPS.Lite.Properties.Resources.arrow_circle_double;
                btnSwap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
                btnSwap.Location = new System.Drawing.Point(2, 72 + (5 * 70));
                btnSwap.Name = "btnSwap";
                btnSwap.Size = new System.Drawing.Size(95, 70);
                btnSwap.TabIndex = 2;
                btnSwap.Text = "Swap e/ Plantas";
                btnSwap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnSwap.UseVisualStyleBackColor = true;
                btnSwap.Click += new System.EventHandler(this.btnSwap_Click);

                pnlShortCut.Controls.Add(btnSwap);

                mnu.Items.Remove(detalleDePalletToolStripMenuItem);
                mnu.Items.Remove(digitaciónToolStripMenuItem);
                detalleToolStripMenuItem.Visible = false; */

                #endregion  

            }
            else if (clsGlobal.LoggedUser.RoleName == "Jefe de Corte - Programación - Planificación")
            {
                //Botones para resto de los usuarios
                //pnlShortCut.Visible = false;
                movimientosTSMLog.Visible = false;
                tsmInProcessCoils.Visible = false;
                tsmOrderList_PL.Visible = false;
                tsmCoils_PL.Visible = false;
                pnlShortCut.Visible = false;
                mnu.Items.Remove(detalleDePalletToolStripMenuItem);
                mnu.Items.Remove(digitaciónToolStripMenuItem);
                detalleToolStripMenuItem.Visible = false;

                #region Despachos

                ToolStripMenuItem DESPACHOS = new ToolStripMenuItem();
                DESPACHOS.Text = "Despachos";
                mnu.Items.Add(DESPACHOS);

                ToolStripMenuItem reportedespachos = new ToolStripMenuItem();
                reportedespachos.Text = "Reporte de despachos";
                reportedespachos.Image = Properties.Resources.report;
                reportedespachos.Click += new EventHandler(reportedespachos_Click);
                DESPACHOS.DropDownItems.Add(reportedespachos);

                #endregion

                #region Devoluciones

                ToolStripMenuItem DEVOLUCIONES = new ToolStripMenuItem();
                DEVOLUCIONES.Text = "Devoluciones";
                mnu.Items.Add(DEVOLUCIONES);

                ToolStripMenuItem reportedevoluciones = new ToolStripMenuItem();
                reportedevoluciones.Text = "Reporte de devoluciones";
                reportedevoluciones.Image = Properties.Resources.report;
                reportedevoluciones.Click += new EventHandler(reportedevoluciones_Click);
                DEVOLUCIONES.DropDownItems.Add(reportedevoluciones);

                #endregion

                #region Producto Terminado

                ToolStripMenuItem PRODUCTOTERMINADO = new ToolStripMenuItem();
                PRODUCTOTERMINADO.Text = "Productos";
                mnu.Items.Add(PRODUCTOTERMINADO);

                ToolStripMenuItem estadodedeposito = new ToolStripMenuItem();
                estadodedeposito.Text = "Inventario de Pallets";
                estadodedeposito.Image = Properties.Resources.box1;
                estadodedeposito.Click += new EventHandler(estadodedeposito_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(estadodedeposito);

                ToolStripMenuItem historialPallets = new ToolStripMenuItem();
                historialPallets.Text = "Historial inventario de pallets";
                historialPallets.Image = Properties.Resources.calendar_2;
                historialPallets.Click += new EventHandler(historialCompletoDePalletsToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(historialPallets);

                ToolStripMenuItem estadopp = new ToolStripMenuItem();
                estadopp.Text = "Inventario de Bobinas";
                estadopp.Image = Properties.Resources.box1;
                estadopp.Click += new EventHandler(stockOP1ToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(estadopp);

                ToolStripMenuItem historialBobinas = new ToolStripMenuItem();
                historialBobinas.Text = "Historial inventario de bobinas";
                historialBobinas.Image = Properties.Resources.calendar_2;
                historialBobinas.Click += new EventHandler(historialCompletoDeBobinasToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(historialBobinas);

                ToolStripMenuItem estadoRackCP2 = new ToolStripMenuItem();
                estadoRackCP2.Text = "Rack Primario Pilar";
                estadoRackCP2.Image = Properties.Resources.page_coils;
                estadoRackCP2.Click += new EventHandler(estadoDeRackCortadoraPrimariaToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(estadoRackCP2);

                ToolStripMenuItem historialRackPrimario = new ToolStripMenuItem();
                historialRackPrimario.Text = "Historial de Rack Primario";
                historialRackPrimario.Image = Properties.Resources.calendar_2;
                historialRackPrimario.Click += new EventHandler(historialRackPrimarioToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(historialRackPrimario);

                ToolStripMenuItem rackMet = new ToolStripMenuItem();
                rackMet.Text = "Rack Secundario Pilar";
                rackMet.Image = Properties.Resources.coils;
                rackMet.Click += new EventHandler(estadoDeToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(rackMet);

                ToolStripMenuItem historialRackSecundario = new ToolStripMenuItem();
                historialRackSecundario.Text = "Historial de Rack Secundario";
                historialRackSecundario.Image = Properties.Resources.calendar_2;
                historialRackSecundario.Click += new EventHandler(historialRackSecundarioToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(historialRackSecundario);

                ToolStripMenuItem reportesGeneral = new ToolStripMenuItem();
                reportesGeneral.Text = "Reportes";
                reportesGeneral.Image = Properties.Resources.reportOff;
                PRODUCTOTERMINADO.DropDownItems.Add(reportesGeneral);

                ToolStripMenuItem reportemovimientosprodtermianado = new ToolStripMenuItem();
                reportemovimientosprodtermianado.Text = "Reporte Movimientos";
                reportemovimientosprodtermianado.Image = Properties.Resources.report;
                reportemovimientosprodtermianado.Click += new EventHandler(reportemovimientoDePalletInterplantaToolStripMenuItem_Click);
                reportesGeneral.DropDownItems.Add(reportemovimientosprodtermianado);

                ToolStripMenuItem reporteswapprodterminado = new ToolStripMenuItem();
                reporteswapprodterminado.Text = "Reporte Swap";
                reporteswapprodterminado.Image = Properties.Resources.report;
                reporteswapprodterminado.Click += new EventHandler(reporteswapprodterminado_Click);
                reportesGeneral.DropDownItems.Add(reporteswapprodterminado);

                ToolStripMenuItem reportImport = new ToolStripMenuItem();
                reportImport.Text = "Reporte Importaciones";
                reportImport.Image = Properties.Resources.reportOff;
                reportImport.Click += new EventHandler(reporteImportado_Click);
                reportesGeneral.DropDownItems.Add(reportImport);

                ToolStripMenuItem reporteImposxBobina = new ToolStripMenuItem();
                reporteImposxBobina.Text = "Reporte Importaciones por bobina";
                reporteImposxBobina.Image = Properties.Resources.reportOff;
                reporteImposxBobina.Click += new EventHandler(reporteImportado_Click);
                reportesGeneral.DropDownItems.Add(reporteImposxBobina);

                ToolStripMenuItem cuttingReport = new ToolStripMenuItem();
                cuttingReport.Text = "Reporte corte por bobina";
                cuttingReport.Image = Properties.Resources.reportOff;
                cuttingReport.Click += new EventHandler(reporteDeCorteToolStripMenuItem_Click);
                reportesGeneral.DropDownItems.Add(cuttingReport);

                ToolStripMenuItem shippingByCoil = new ToolStripMenuItem();
                shippingByCoil.Text = "Reporte despachos por bobina";
                shippingByCoil.Image = Properties.Resources.report;
                shippingByCoil.Click += new EventHandler(reporteDespachosPorBobina_Click);
                reportesGeneral.DropDownItems.Add(shippingByCoil);

                ToolStripMenuItem reporteReproceso = new ToolStripMenuItem();
                reporteReproceso.Text = "Reporte de Reprocesos";
                reporteReproceso.Click += new EventHandler(reporteRepreocessToolStripMenuItem_Click);
                reportesGeneral.DropDownItems.Add(reporteReproceso);


                #endregion

                #region Materia Prima

                ToolStripMenuItem MATERIAPRIMA = new ToolStripMenuItem();
                MATERIAPRIMA.Text = "Materia Prima";
                mnu.Items.Add(MATERIAPRIMA);

                ToolStripMenuItem estadodedepositomatprima = new ToolStripMenuItem();
                estadodedepositomatprima.Text = "Estado de Deposito";
                estadodedepositomatprima.Image = Properties.Resources.box1;
                estadodedepositomatprima.Click += new EventHandler(estadoDeDepositoMP_Click);
                MATERIAPRIMA.DropDownItems.Add(estadodedepositomatprima);

                ToolStripMenuItem historialMateriaPrima = new ToolStripMenuItem();
                historialMateriaPrima.Text = "Historial de deposito de materia prima";
                historialMateriaPrima.Image = Properties.Resources.calendar;
                historialMateriaPrima.Click += new EventHandler(toolStripMenuItem2_Click);
                MATERIAPRIMA.DropDownItems.Add(historialMateriaPrima);

                ToolStripMenuItem reportIngresoMP = new ToolStripMenuItem();
                reportIngresoMP.Text = "Reporte Ingreso";
                reportIngresoMP.Image = Properties.Resources.report;
                reportIngresoMP.Click += new EventHandler(reportIngresoMP_Click);
                MATERIAPRIMA.DropDownItems.Add(reportIngresoMP);

                ToolStripMenuItem reportemovimientosmatprima = new ToolStripMenuItem();
                reportemovimientosmatprima.Text = "Reporte Movimientos";
                reportemovimientosmatprima.Image = Properties.Resources.report;
                reportemovimientosmatprima.Click += new EventHandler(reportemovimientosmatprima_Click);
                MATERIAPRIMA.DropDownItems.Add(reportemovimientosmatprima);

                ToolStripMenuItem reporteswapmatprima = new ToolStripMenuItem();
                reporteswapmatprima.Text = "Reporte Swap";
                reporteswapmatprima.Image = Properties.Resources.report;
                reporteswapmatprima.Click += new EventHandler(swapRawMaterialReport_Click);
                MATERIAPRIMA.DropDownItems.Add(reporteswapmatprima);

                ToolStripMenuItem despachoReport = new ToolStripMenuItem();
                despachoReport.Text = "Reporte de Despachos de Materia Primas";
                despachoReport.Image = Properties.Resources.report;
                despachoReport.Click += new EventHandler(despachoReport_Click);
                MATERIAPRIMA.DropDownItems.Add(despachoReport);

                #endregion

                #region Scrap

                ToolStripMenuItem SCRAP = new ToolStripMenuItem();
                SCRAP.Text = "Scrap";
                mnu.Items.Add(SCRAP);

                ToolStripMenuItem estadodedepositoscrap = new ToolStripMenuItem();
                estadodedepositoscrap.Text = "Estado de Deposito";
                estadodedepositoscrap.Image = Properties.Resources.wooden_box;
                estadodedepositoscrap.Click += new EventHandler(estadodedepositoscrap_Click);
                SCRAP.DropDownItems.Add(estadodedepositoscrap);

                ToolStripMenuItem reportemovimientosscrap = new ToolStripMenuItem();
                reportemovimientosscrap.Text = "Reporte Movimientos";
                reportemovimientosscrap.Image = Properties.Resources.report;
                reportemovimientosscrap.Click += new EventHandler(reportemovimientosscrap_Click);
                SCRAP.DropDownItems.Add(reportemovimientosscrap);

                ToolStripMenuItem swappalletscrapreport = new ToolStripMenuItem();
                swappalletscrapreport.Text = "Reporte Swap de Pallets de Scrap";
                swappalletscrapreport.Image = Properties.Resources.report;
                swappalletscrapreport.Click += new EventHandler(scrapPalletSwapReportMenuItem_Click);
                SCRAP.DropDownItems.Add(swappalletscrapreport);

                #endregion

                #region corte
                ToolStripMenuItem lstOrdenes = new ToolStripMenuItem();
                lstOrdenes.Text = "Corte";
                mnu.Items.Add(lstOrdenes);

                ToolStripMenuItem goebel = new ToolStripMenuItem();
                goebel.Text = "Goebel";
                goebel.Image = Properties.Resources.gear_16;
                goebel.Click += new EventHandler(goebelToolStripMenuItem_Click);
                lstOrdenes.DropDownItems.Add(goebel);

                ToolStripMenuItem atlas = new ToolStripMenuItem();
                atlas.Text = "Atlas";
                atlas.Image = Properties.Resources.gear_16;
                atlas.Click += new EventHandler(atlasToolStripMenuItem1_Click_1);
                lstOrdenes.DropDownItems.Add(atlas);

                ToolStripMenuItem titan = new ToolStripMenuItem();
                titan.Text = "Titan";
                titan.Image = Properties.Resources.gear_16;
                titan.Click += new EventHandler(titanToolStripMenuItem_Click);
                lstOrdenes.DropDownItems.Add(titan);
                #endregion

                ToolStripMenuItem reports = new ToolStripMenuItem();
                reports.Text = "Reportes";
                //reports.Image = Properties.Resources.report;
                mnu.Items.Add(reports);

                ToolStripMenuItem cutReport = new ToolStripMenuItem();
                cutReport.Text = "Reporte de Corte";
                cutReport.Click += new EventHandler(reporteDeCorteToolStripMenuItem_Click);
                cutReport.Image = Properties.Resources.reportOff;
                reports.DropDownItems.Add(cutReport);

                ToolStripMenuItem metallizedReport = new ToolStripMenuItem();
                metallizedReport.Text = "Reporte de Metalizado";
                metallizedReport.Click += new EventHandler(reporteDeMetalizadoTSMItem_Click);
                metallizedReport.Image = Properties.Resources.reportOff;
                reports.DropDownItems.Add(metallizedReport);

                ToolStripMenuItem rewindReport = new ToolStripMenuItem();
                rewindReport.Text = "Reporte de Rebobinado";
                rewindReport.Click += new EventHandler(reporteDeRebobinadoToolStripMenuItem_Click);
                rewindReport.Image = Properties.Resources.reportOff;
                reports.DropDownItems.Add(rewindReport);

                ToolStripMenuItem scrapReport = new ToolStripMenuItem();
                scrapReport.Text = "Reporte de Pallets de Merma";
                scrapReport.Click += new EventHandler(reportesDePalletsDeMermaToolStripMenuItem_Click);
                scrapReport.Image = Properties.Resources.reportOff;
                reports.DropDownItems.Add(scrapReport);

                ToolStripMenuItem scrapMovHistory = new ToolStripMenuItem();
                scrapMovHistory.Text = "Reporte Movimiento de Mermas";
                scrapMovHistory.Click += new EventHandler(movimientosDeScrapToolStripMenuItem_Click);
                scrapMovHistory.Image = Properties.Resources.reportOff;
                reports.DropDownItems.Add(scrapMovHistory);

            }
            else if (clsGlobal.LoggedUser.RoleName == "Contabilidad")
            {    
                detalleDePalletToolStripMenuItem.Visible = false;
                digitaciónToolStripMenuItem.Visible = false;
                detalleToolStripMenuItem.Visible = false;
                movimientosTSMLog.Visible = false;
                pnlShortCut.Visible = false;

                #region Producto terminado

                ToolStripMenuItem PRODUCTOTERMINADO = new ToolStripMenuItem();
                PRODUCTOTERMINADO.Text = "Productos";
                mnu.Items.Add(PRODUCTOTERMINADO);

                ToolStripMenuItem predespachos2 = new ToolStripMenuItem();
                predespachos2.Text = "Pre-Despachos";
                predespachos2.Image = Properties.Resources.clipboard_text;
                predespachos2.Click += new EventHandler(btnPreShipping2_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(predespachos2);

                ToolStripMenuItem estadodedeposito = new ToolStripMenuItem();
                estadodedeposito.Text = "Inventario Completo de Pallets";
                estadodedeposito.Image = Properties.Resources.box1;
                estadodedeposito.Click += new EventHandler(estadodedeposito_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(estadodedeposito);

                ToolStripMenuItem estadopp = new ToolStripMenuItem();
                estadopp.Text = "Inventario Completo de Bobinas";
                estadopp.Image = Properties.Resources.box1;
                estadopp.Click += new EventHandler(stockOP1ToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(estadopp);

                ToolStripMenuItem estadoRackCP1 = new ToolStripMenuItem();
                estadoRackCP1.Text = "Rack Cortadora Primaria Campana";
                estadoRackCP1.Image = Properties.Resources.page_coils;
                estadoRackCP1.Click += new EventHandler(estadoDeRackCortadoraPrimariaToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(estadoRackCP1);

                ToolStripMenuItem estadoRackCP2 = new ToolStripMenuItem();
                estadoRackCP2.Text = "Rack Cortadora Primaria pilar";
                estadoRackCP2.Image = Properties.Resources.page_coils;
                estadoRackCP2.Click += new EventHandler(estadoDeRackCortadoraPrimariaToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(estadoRackCP2);

                ToolStripMenuItem rackMet1 = new ToolStripMenuItem();
                rackMet1.Text = "Rack de Metalizado Pilar";
                rackMet1.Image = Properties.Resources.coils;
                rackMet1.Click += new EventHandler(estadoDeToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(rackMet1);

                ToolStripMenuItem bobColgantes = new ToolStripMenuItem();
                bobColgantes.Text = "Rack de Bobinas Colgantes Campana";
                bobColgantes.Image = Properties.Resources.coils;
                bobColgantes.Click += new EventHandler(bobinasColgantesToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(bobColgantes);

                ToolStripMenuItem reportemovimientosprodtermianado = new ToolStripMenuItem();
                reportemovimientosprodtermianado.Text = "Reporte Movimientos";
                reportemovimientosprodtermianado.Image = Properties.Resources.reportOff;
                reportemovimientosprodtermianado.Click += new EventHandler(reportemovimientoDePalletInterplantaToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(reportemovimientosprodtermianado);

                ToolStripMenuItem reporteswapprodterminado = new ToolStripMenuItem();
                reporteswapprodterminado.Text = "Reporte Swap";
                reporteswapprodterminado.Image = Properties.Resources.reportOff;
                reporteswapprodterminado.Click += new EventHandler(reporteswapprodterminado_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(reporteswapprodterminado);

                ToolStripMenuItem reportePorBobina = new ToolStripMenuItem();
                reportePorBobina.Text = "Reportes por Bobina";
                reportePorBobina.Image = Properties.Resources.coils;
                PRODUCTOTERMINADO.DropDownItems.Add(reportePorBobina);

                ToolStripMenuItem reporteImposxBobina = new ToolStripMenuItem();
                reporteImposxBobina.Text = "Reporte Importaciones por bobina";
                reporteImposxBobina.Image = Properties.Resources.reportOff;
                reporteImposxBobina.Click += new EventHandler(reporteImportado_Click);
                reportePorBobina.DropDownItems.Add(reporteImposxBobina);

                ToolStripMenuItem cuttingReport = new ToolStripMenuItem();
                cuttingReport.Text = "Reporte corte por bobina";
                cuttingReport.Image = Properties.Resources.reportOff;
                cuttingReport.Click += new EventHandler(reporteDeCorteToolStripMenuItem_Click);
                reportePorBobina.DropDownItems.Add(cuttingReport);

                ToolStripMenuItem shippingByCoil = new ToolStripMenuItem();
                shippingByCoil.Text = "Reporte despachos por bobina";
                shippingByCoil.Image = Properties.Resources.observationCoils;
                shippingByCoil.Click += new EventHandler(reporteDespachosPorBobina_Click);
                reportePorBobina.DropDownItems.Add(shippingByCoil);

                ToolStripMenuItem reporteReproceso = new ToolStripMenuItem();
                reporteReproceso.Text = "Reporte de Reprocesos";
                reporteReproceso.Click += new EventHandler(reporteRepreocessToolStripMenuItem_Click);
                reportePorBobina.DropDownItems.Add(reporteReproceso);

                ToolStripMenuItem peliculaReport = new ToolStripMenuItem();
                peliculaReport.Text = "Reporte de Stock por Pelicula";
                peliculaReport.Image = Properties.Resources.report;
                peliculaReport.Click += new EventHandler(peliculaReport_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(peliculaReport);

                ToolStripMenuItem DespReport = new ToolStripMenuItem();
                DespReport.Text = "Reporte de despachos";
                DespReport.Image = Properties.Resources.report;
                DespReport.Click += new EventHandler(reporteDespachosToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(DespReport);

                #endregion

                #region Materia Prima

                ToolStripMenuItem MATERIAPRIMA = new ToolStripMenuItem();
                MATERIAPRIMA.Text = "Materia Prima";
                mnu.Items.Add(MATERIAPRIMA);

                ToolStripMenuItem estadodedepositomatprima = new ToolStripMenuItem();
                estadodedepositomatprima.Text = "Estado de Deposito";
                estadodedepositomatprima.Image = Properties.Resources.box1;
                estadodedepositomatprima.Click += new EventHandler(estadoDeDepositoMP_Click);
                MATERIAPRIMA.DropDownItems.Add(estadodedepositomatprima);

                ToolStripMenuItem depotStateByDate = new ToolStripMenuItem();
                depotStateByDate.Text = "Estado de deposito por fecha";
                depotStateByDate.Image = Properties.Resources.box1;
                depotStateByDate.Click += new EventHandler(depotMPByDate_Click);
                MATERIAPRIMA.DropDownItems.Add(depotStateByDate);

                ToolStripMenuItem reportIngresoMP = new ToolStripMenuItem();
                reportIngresoMP.Text = "Reporte Ingreso";
                reportIngresoMP.Image = Properties.Resources.report;
                reportIngresoMP.Click += new EventHandler(reportIngresoMP_Click);
                MATERIAPRIMA.DropDownItems.Add(reportIngresoMP);

                ToolStripMenuItem reportemovimientosmatprima = new ToolStripMenuItem();
                reportemovimientosmatprima.Text = "Reporte Movimientos";
                reportemovimientosmatprima.Image = Properties.Resources.report;
                reportemovimientosmatprima.Click += new EventHandler(reportemovimientosmatprima_Click);
                MATERIAPRIMA.DropDownItems.Add(reportemovimientosmatprima);

                ToolStripMenuItem despachoReport = new ToolStripMenuItem();
                despachoReport.Text = "Reporte de Despachos de Materia Primas";
                despachoReport.Image = Properties.Resources.report;
                despachoReport.Click += new EventHandler(despachoReport_Click);
                MATERIAPRIMA.DropDownItems.Add(despachoReport);
                #endregion

                #region Scrap
                ToolStripMenuItem SCRAP = new ToolStripMenuItem();
                SCRAP.Text = "Scrap";
                mnu.Items.Add(SCRAP);

                ToolStripMenuItem estadodedepositoscrap = new ToolStripMenuItem();
                estadodedepositoscrap.Text = "Estado de Deposito";
                estadodedepositoscrap.Image = Properties.Resources.box;
                estadodedepositoscrap.Click += new EventHandler(estadodedepositoscrap_Click);
                SCRAP.DropDownItems.Add(estadodedepositoscrap);
                #endregion

                #region Supervision

                ToolStripMenuItem supervision = new ToolStripMenuItem();
                supervision.Text = "Reportes";
                supervision.Image = Properties.Resources.eye;
                mnu.Items.Add(supervision);

                ToolStripMenuItem prodcont = new ToolStripMenuItem();
                prodcont.Text = "Control de resultados entre fechas";
                prodcont.Click += new EventHandler(prodcontToolStripMenuItem_Click);
                prodcont.Image = Properties.Resources.coils;
                supervision.DropDownItems.Add(prodcont);

                #endregion

            }
            else if (clsGlobal.LoggedUser.RoleName == "Compras")
            {
                detalleDePalletToolStripMenuItem.Visible = false;
                digitaciónToolStripMenuItem.Visible = false;
                detalleToolStripMenuItem.Visible = false;
                movimientosTSMLog.Visible = false;
                pnlShortCut.Visible = false;

                //ToolStripMenuItem proveedores = new ToolStripMenuItem();
                //proveedores.Text = "Proveedores";
                //mnu.Items.Add(proveedores);

                //ToolStripMenuItem ABMProveedores = new ToolStripMenuItem();
                //ABMProveedores.Text = "ABM Proveedores";
                //ABMProveedores.Image = Properties.Resources.report;
                //ABMProveedores.Click += new EventHandler(abmProveedores_Click); // TODO: Falta que dé el alta.
                //proveedores.DropDownItems.Add(ABMProveedores);

                //ToolStripMenuItem productos = new ToolStripMenuItem();
                //productos.Text = "Productos";
                //mnu.Items.Add(productos);

                //ToolStripMenuItem ABMProductos = new ToolStripMenuItem();
                //ABMProductos.Text = "ABM Productos";
                //ABMProductos.Image = Properties.Resources.page_white_gear;
                //ABMProductos.Click += new EventHandler(abmProductos_Click);
                //productos.DropDownItems.Add(ABMProductos);

                //ToolStripMenuItem ABMMateriales = new ToolStripMenuItem();
                //ABMMateriales.Text = "ABM Materiales";
                //ABMMateriales.Image = Properties.Resources.page_white_gear;
                //ABMMateriales.Click += new EventHandler(ABMMateriales_Click);
                //productos.DropDownItems.Add(ABMMateriales);

                //ToolStripMenuItem requerimientos = new ToolStripMenuItem();
                //requerimientos.Text = "Requerimientos";
                //mnu.Items.Add(requerimientos);

                //ToolStripMenuItem nuevoreq = new ToolStripMenuItem();
                //nuevoreq.Text = "Nuevo Requerimiento";
                //nuevoreq.Image = Properties.Resources.hammer_screwdriver;
                //nuevoreq.Click += new EventHandler(ABMReq_Click);
                //requerimientos.DropDownItems.Add(nuevoreq);

                //ToolStripMenuItem seguimientoReq = new ToolStripMenuItem();
                //seguimientoReq.Text = "Seguimiento de Requerimientos";
                //seguimientoReq.Image = Properties.Resources.reportOff;
                //seguimientoReq.Click += new EventHandler(segReq_Click);
                //requerimientos.DropDownItems.Add(seguimientoReq);

            }
            else if (clsGlobal.LoggedUser.RoleName == "Administrador")
            {

                detalleDePalletToolStripMenuItem.Visible = false;
                digitaciónToolStripMenuItem.Visible = false;
                detalleToolStripMenuItem.Visible = false;
                movimientosTSMLog.Visible = false;

                #region Digitacion

                ToolStripMenuItem Digitacion = new ToolStripMenuItem();
                Digitacion.Text = "Digitación";
                Digitacion.Image = Properties.Resources.server;
                mnu.Items.Add(Digitacion);

                ToolStripMenuItem lstOrdenes = new ToolStripMenuItem();
                lstOrdenes.Text = "Listado de Ordenes";
                lstOrdenes.Image = Properties.Resources.page_coils;
                Digitacion.DropDownItems.Add(lstOrdenes);

                ToolStripMenuItem atlasCamp = new ToolStripMenuItem();
                atlasCamp.Text = "Atlas";
                atlasCamp.Image = Properties.Resources.gear_16;
                atlasCamp.Click += new EventHandler(atlasToolStripMenuItem2_Click);
                lstOrdenes.DropDownItems.Add(atlasCamp);

                ToolStripMenuItem c230 = new ToolStripMenuItem();
                c230.Text = "C230";
                c230.Image = Properties.Resources.gear_16;
                c230.Click += new EventHandler(c230ToolStripMenuItem2_Click);
                lstOrdenes.DropDownItems.Add(c230);

                ToolStripMenuItem c231 = new ToolStripMenuItem();
                c231.Text = "C231";
                c231.Image = Properties.Resources.gear_16;
                c231.Click += new EventHandler(c231ToolStripMenuItem2_Click);
                lstOrdenes.DropDownItems.Add(c231);

                ToolStripMenuItem c232 = new ToolStripMenuItem();
                c232.Text = "C232";
                c232.Image = Properties.Resources.gear_16;
                c232.Click += new EventHandler(c232ToolStripMenuItem2_Click);
                lstOrdenes.DropDownItems.Add(c232);

                ToolStripMenuItem bobinas = new ToolStripMenuItem();
                bobinas.Image = Properties.Resources.coils;
                bobinas.Text = "Bobinas";
                Digitacion.DropDownItems.Add(bobinas);

                ToolStripMenuItem goebelB = new ToolStripMenuItem();
                goebelB.Text = "Atlas";
                goebelB.Image = Properties.Resources.gear_16;
                goebelB.Click += new EventHandler(goebelToolStripMenuItem2_Click);
                bobinas.DropDownItems.Add(goebelB);

                ToolStripMenuItem c230Cmp = new ToolStripMenuItem();
                c230Cmp.Text = "C230";
                c230Cmp.Image = Properties.Resources.gear_16;
                c230Cmp.Click += new EventHandler(atlasCampanaToolStripMenuItem_Click);
                bobinas.DropDownItems.Add(c230Cmp);

                ToolStripMenuItem c231cmp = new ToolStripMenuItem();
                c231cmp.Text = "C231";
                c231cmp.Image = Properties.Resources.gear_16;
                c231cmp.Click += new EventHandler(c231ToolStripMenuItem1_Click_1);
                bobinas.DropDownItems.Add(c231cmp);

                ToolStripMenuItem c232cmp = new ToolStripMenuItem();
                c232cmp.Text = "C232";
                c232cmp.Image = Properties.Resources.gear_16;
                c232cmp.Click += new EventHandler(c232ToolStripMenuItem1_Click_1);
                bobinas.DropDownItems.Add(c232cmp);

                ToolStripMenuItem CombCS = new ToolStripMenuItem();
                CombCS.Text = "Combinacion de Corte Secundario";
                CombCS.Image = Properties.Resources.coilSecundaryCut;
                CombCS.Click += new EventHandler(combinacionesCorteSecundarioToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(CombCS);

                ToolStripMenuItem rebobinado = new ToolStripMenuItem();
                rebobinado.Text = "Rebobinado";
                rebobinado.Image = Properties.Resources.rewind;
                rebobinado.Click += new EventHandler(rebobinadoToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(rebobinado);

                ToolStripMenuItem regBobReproc = new ToolStripMenuItem();
                regBobReproc.Text = "Registro de Bobinas para Reproceso";
                regBobReproc.Image = Properties.Resources.reprocess2;
                regBobReproc.Click += new EventHandler(registroDeBobinasParaReprocesoToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(regBobReproc);

                ToolStripMenuItem reetiquetadopeliculasEquiv = new ToolStripMenuItem();
                reetiquetadopeliculasEquiv.Text = "Re-etiquetado peliculas equivalente";
                reetiquetadopeliculasEquiv.Image = Properties.Resources.printer;
                reetiquetadopeliculasEquiv.Click += new EventHandler(reetiquetadoDePeliculaEquivalenteToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(reetiquetadopeliculasEquiv);

                ToolStripMenuItem reetiquetadoStock = new ToolStripMenuItem();
                reetiquetadoStock.Text = "Re-etiquetado a Stock";
                reetiquetadoStock.Image = Properties.Resources.printer;
                reetiquetadoStock.Click += new EventHandler(reetiquetadoAStockToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(reetiquetadoStock);

                ToolStripMenuItem metalizado = new ToolStripMenuItem();
                metalizado.Text = "Metalizado (Sistema Viejo)";
                metalizado.Image = Properties.Resources.coils;
                metalizado.Click += new EventHandler(btnMetlizedOrder_Click);
                Digitacion.DropDownItems.Add(metalizado);

                /*ToolStripMenuItem newmetalizado = new ToolStripMenuItem();
                newmetalizado.Text = "Metalizado (Sistema Nuevo)";
                newmetalizado.Image = Properties.Resources.coils;
                newmetalizado.Click += new EventHandler(btnNewMetlizedOrder_Click);
                Digitacion.DropDownItems.Add(newmetalizado);
                */

                ToolStripMenuItem pallets = new ToolStripMenuItem();
                pallets.Text = "Pallets";
                pallets.Image = Properties.Resources.pallet;
                pallets.Click += new EventHandler(palletsToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(pallets);

                ToolStripMenuItem mermas = new ToolStripMenuItem();
                mermas.Text = "Notificacion de Mermas";
                mermas.Image = Properties.Resources.coilMill;
                mermas.Click += new EventHandler(scrapToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(mermas);

                ToolStripMenuItem scrap = new ToolStripMenuItem();
                scrap.Text = "Envío de Materiales al Molino";
                scrap.Image = Properties.Resources.Mill;
                scrap.Click += new EventHandler(envioMAteriaToolStripMenuItem_Click);
                Digitacion.DropDownItems.Add(scrap);
                #endregion

                #region Detalle

                ToolStripMenuItem detalle = new ToolStripMenuItem();
                detalle.Text = "Detalle";
                detalle.Image = Properties.Resources.clipboard_text;
                mnu.Items.Add(detalle);

                ToolStripMenuItem estadoDeDepot = new ToolStripMenuItem();
                estadoDeDepot.Text = "Inventario Producto Terminado";
                estadoDeDepot.Image = Properties.Resources.storage2;
                estadoDeDepot.Click += new EventHandler(EstadoDeDeposito_Click);
                detalle.DropDownItems.Add(estadoDeDepot);

                ToolStripMenuItem estadoDeDepotOP1 = new ToolStripMenuItem();
                estadoDeDepotOP1.Text = "Inventario Corte, Producto en Proceso y OP1";
                estadoDeDepotOP1.Image = Properties.Resources.storage2;
                estadoDeDepotOP1.Click += new EventHandler(stockOP1ToolStripMenuItem_Click);
                detalle.DropDownItems.Add(estadoDeDepotOP1);

                ToolStripMenuItem estadobobsue = new ToolStripMenuItem();
                estadobobsue.Text = "Inventario Bobinas Sueltas";
                estadobobsue.Image = Properties.Resources.page_coils;
                estadobobsue.Click += new EventHandler(inventarioDeBobinasSueltasToolStripMenuItem_Click);
                detalle.DropDownItems.Add(estadobobsue);

                ToolStripMenuItem estadoRackCP = new ToolStripMenuItem();
                estadoRackCP.Text = "Estado de Rack Cortadora Primaria";
                estadoRackCP.Image = Properties.Resources.page_coils;
                estadoRackCP.Click += new EventHandler(estadoDeRackCortadoraPrimariaToolStripMenuItem_Click);
                detalle.DropDownItems.Add(estadoRackCP);

                ToolStripMenuItem rackMet = new ToolStripMenuItem();
                rackMet.Text = "Rack de Metalizado";
                rackMet.Image = Properties.Resources.coils;
                rackMet.Click += new EventHandler(bobinasColgantesToolStripMenuItem_Click);
                detalle.DropDownItems.Add(rackMet);

                ToolStripMenuItem stockPalletScrap = new ToolStripMenuItem();
                stockPalletScrap.Text = "Stock de Pallets de Merma";
                stockPalletScrap.Image = Properties.Resources.box;
                stockPalletScrap.Click += new EventHandler(stockPalletsScrapToolStripMenuItem_Click);
                detalle.DropDownItems.Add(stockPalletScrap);

                ToolStripMenuItem palletDtl = new ToolStripMenuItem();
                palletDtl.Text = "Detalle de Pallet";
                palletDtl.Image = Properties.Resources.pallet;
                palletDtl.Click += new EventHandler(btnPallet_Click);
                detalle.DropDownItems.Add(palletDtl);

                ToolStripMenuItem coilDtl = new ToolStripMenuItem();
                coilDtl.Text = "Detalle de Bobina";
                coilDtl.Image = Properties.Resources.mainCoil;
                coilDtl.Click += new EventHandler(btnCoil_Click);
                detalle.DropDownItems.Add(coilDtl);

                ToolStripMenuItem coilDt2 = new ToolStripMenuItem();
                coilDt2.Text = "lista PD";
                coilDt2.Image = Properties.Resources.mainCoil;
                coilDt2.Click += new EventHandler(pruebaToolStripMenuItem_Click);
                detalle.DropDownItems.Add(coilDt2);

                ToolStripMenuItem coilDt3 = new ToolStripMenuItem();
                coilDt3.Text = "binding";
                coilDt3.Image = Properties.Resources.mainCoil;
                coilDt3.Click += new EventHandler(bindingToolStripMenuItem_Click);
                detalle.DropDownItems.Add(coilDt3);

                ToolStripMenuItem coilDt4 = new ToolStripMenuItem();
                coilDt4.Text = "impo peru";
                coilDt4.Image = Properties.Resources.mainCoil;
                coilDt4.Click += new EventHandler(impoPeruToolStripMenuItem_Click);
                detalle.DropDownItems.Add(coilDt4);

                ToolStripMenuItem coilDt5 = new ToolStripMenuItem();
                coilDt5.Text = "impo chile";
                coilDt5.Image = Properties.Resources.mainCoil;
                coilDt5.Click += new EventHandler(impoChileToolStripMenuItem_Click);
                detalle.DropDownItems.Add(coilDt5);

                ToolStripMenuItem coilDt6 = new ToolStripMenuItem();
                coilDt6.Text = "prueba pallet";
                coilDt6.Image = Properties.Resources.mainCoil;
                coilDt6.Click += new EventHandler(pruebaPalletToolStripMenuItem_Click);
                detalle.DropDownItems.Add(coilDt6);

                ToolStripMenuItem coilDt7 = new ToolStripMenuItem();
                coilDt7.Text = "prueba condiciones operativas metalizado";
                coilDt7.Image = Properties.Resources.mainCoil;
                coilDt7.Click += new EventHandler(pruebaCondicionesMetalizadoToolStripMenuItem_Click);
                detalle.DropDownItems.Add(coilDt7);

                ToolStripMenuItem coilDt8 = new ToolStripMenuItem();
                coilDt8.Text = "prueba condiciones operativas met reportes";
                coilDt8.Image = Properties.Resources.mainCoil;
                coilDt8.Click += new EventHandler(pruebaCondicionesOperativasMetReportesToolStripMenuItem_Click);
                detalle.DropDownItems.Add(coilDt8);

                

                #endregion

                #region Supervision

                ToolStripMenuItem supervision = new ToolStripMenuItem();
                supervision.Text = "Supervisión";
                supervision.Image = Properties.Resources.eye;
                mnu.Items.Add(supervision);

                ToolStripMenuItem reports = new ToolStripMenuItem();
                reports.Text = "Reportes";
                reports.Image = Properties.Resources.report;
                supervision.DropDownItems.Add(reports);

                ToolStripMenuItem cutReport = new ToolStripMenuItem();
                cutReport.Text = "Reporte de Corte";
                cutReport.Click += new EventHandler(reporteDeCorteToolStripMenuItem_Click);
                cutReport.Image = Properties.Resources.reportOff;
                reports.DropDownItems.Add(cutReport);

                ToolStripMenuItem metallizedReport = new ToolStripMenuItem();
                metallizedReport.Text = "Reporte de Metalizado";
                metallizedReport.Click += new EventHandler(reporteDeMetalizadoTSMItem_Click);
                metallizedReport.Image = Properties.Resources.reportOff;
                reports.DropDownItems.Add(metallizedReport);

                ToolStripMenuItem rewindReport = new ToolStripMenuItem();
                rewindReport.Text = "Reporte de Rebobinado";
                rewindReport.Click += new EventHandler(reporteDeRebobinadoToolStripMenuItem_Click);
                rewindReport.Image = Properties.Resources.reportOff;
                reports.DropDownItems.Add(rewindReport);

                ToolStripMenuItem scrapReport = new ToolStripMenuItem();
                scrapReport.Text = "Reporte de Pallets de Merma";
                scrapReport.Click += new EventHandler(reportesDePalletsDeMermaToolStripMenuItem_Click);
                scrapReport.Image = Properties.Resources.reportOff;
                reports.DropDownItems.Add(scrapReport);

                ToolStripMenuItem scrapMovHistory = new ToolStripMenuItem();
                scrapMovHistory.Text = "Reporte Movimiento de Mermas";
                scrapMovHistory.Click += new EventHandler(movimientosDeScrapToolStripMenuItem_Click);
                scrapMovHistory.Image = Properties.Resources.reportOff;
                reports.DropDownItems.Add(scrapMovHistory);

                ToolStripMenuItem healerForm = new ToolStripMenuItem();
                healerForm.Text = "Revivir/Eliminar Bobinas Hijas";
                healerForm.Click += new EventHandler(reviveOrKillCoilToolStripMenuItem_Click);
                healerForm.Image = Properties.Resources.coils;
                supervision.DropDownItems.Add(healerForm);

                #endregion

                #region Despachos

                ToolStripMenuItem DESPACHOS = new ToolStripMenuItem();
                DESPACHOS.Text = "Despachos";
                mnu.Items.Add(DESPACHOS);

                ToolStripMenuItem predespachos = new ToolStripMenuItem();
                predespachos.Text = "Pre-Despachos";
                predespachos.Click += new EventHandler(predespachosPL_Click);
                DESPACHOS.DropDownItems.Add(predespachos);

                ToolStripMenuItem romaneo = new ToolStripMenuItem();
                romaneo.Text = "Romaneo";
                romaneo.Click += new EventHandler(romaneo_Click);
                DESPACHOS.DropDownItems.Add(romaneo);

                ToolStripMenuItem despachos = new ToolStripMenuItem();
                despachos.Text = "Despachos";
                despachos.Click += new EventHandler(despachos_Click);
                DESPACHOS.DropDownItems.Add(despachos);

                ToolStripMenuItem reportedespachos = new ToolStripMenuItem();
                reportedespachos.Text = "Reporte";
                reportedespachos.Click += new EventHandler(reportedespachos_Click);
                DESPACHOS.DropDownItems.Add(reportedespachos);

                #endregion

                #region Devoluciones

                ToolStripMenuItem DEVOLUCIONES = new ToolStripMenuItem();
                DEVOLUCIONES.Text = "Devoluciones";
                mnu.Items.Add(DEVOLUCIONES);

                ToolStripMenuItem devoluciones = new ToolStripMenuItem();
                devoluciones.Text = "Devoluciones";
                devoluciones.Click += new EventHandler(devoluciones_Click);
                DEVOLUCIONES.DropDownItems.Add(devoluciones);

                ToolStripMenuItem reportedevoluciones = new ToolStripMenuItem();
                reportedevoluciones.Text = "Reporte";
                reportedevoluciones.Click += new EventHandler(reportedevoluciones_Click);
                DEVOLUCIONES.DropDownItems.Add(reportedevoluciones);

                #endregion

                #region Producto Terminado

                ToolStripMenuItem PRODUCTOTERMINADO = new ToolStripMenuItem();
                PRODUCTOTERMINADO.Text = "Productos";
                mnu.Items.Add(PRODUCTOTERMINADO);

                ToolStripMenuItem estadodedeposito = new ToolStripMenuItem();
                estadodedeposito.Text = "Inventario Completo de Pallets";
                estadodedeposito.Image = Properties.Resources.box1;
                estadodedeposito.Click += new EventHandler(estadodedeposito_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(estadodedeposito);

                ToolStripMenuItem estadopp = new ToolStripMenuItem();
                estadopp.Text = "Inventario Completo de Bobinas";
                estadopp.Image = Properties.Resources.box1;
                estadopp.Click += new EventHandler(stockOP1ToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(estadopp);

                ToolStripMenuItem estadoRackCP1 = new ToolStripMenuItem();
                estadoRackCP1.Text = "Rack Cortadora Primaria Campana";
                estadoRackCP1.Image = Properties.Resources.page_coils;
                estadoRackCP1.Click += new EventHandler(estadoDeRackCortadoraPrimariaToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(estadoRackCP1);

                ToolStripMenuItem estadoRackCP2 = new ToolStripMenuItem();
                estadoRackCP2.Text = "Rack Cortadora Primaria pilar";
                estadoRackCP2.Image = Properties.Resources.page_coils;
                estadoRackCP2.Click += new EventHandler(estadoDeRackCortadoraPrimariaToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(estadoRackCP2);

                ToolStripMenuItem rackMet1 = new ToolStripMenuItem();
                rackMet1.Text = "Rack de Metalizado Pilar";
                rackMet1.Image = Properties.Resources.coils;
                rackMet1.Click += new EventHandler(estadoDeToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(rackMet1);

                ToolStripMenuItem bobColgantes = new ToolStripMenuItem();
                bobColgantes.Text = "Rack de Bobinas Colgantes Campana";
                bobColgantes.Image = Properties.Resources.coils;
                bobColgantes.Click += new EventHandler(bobinasColgantesToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(bobColgantes);

                ToolStripMenuItem estadopaletizado = new ToolStripMenuItem();
                estadopaletizado.Text = "Pallets para mover a producto terminado";
                estadopaletizado.Image = Properties.Resources.box1;
                estadopaletizado.Click += new EventHandler(estadopaletizado_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(estadopaletizado);

                ToolStripMenuItem movimientoNuevo = new ToolStripMenuItem();
                movimientoNuevo.Text = "Movimiento Nuevo";
                movimientoNuevo.Image = Properties.Resources.delivery;
                movimientoNuevo.Click += new EventHandler(newPalletMovement_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(movimientoNuevo);

                ToolStripMenuItem movimientosprodterminado = new ToolStripMenuItem();
                movimientosprodterminado.Text = "Movimientos";
                movimientosprodterminado.Click += new EventHandler(movimientoDePalletInterplantaToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(movimientosprodterminado);

                /*ToolStripMenuItem ingresosprodterminado = new ToolStripMenuItem();
                ingresosprodterminado.Text = "Ingresos";
                ingresosprodterminado.Click += new EventHandler(ingresosprodterminado_Click);
                movimientosprodterminado.DropDownItems.Add(ingresosprodterminado);

                ToolStripMenuItem egresosprodterminado = new ToolStripMenuItem();
                egresosprodterminado.Text = "Egresos";
                egresosprodterminado.Click += new EventHandler(egresosprodterminado_Click);
                movimientosprodterminado.DropDownItems.Add(egresosprodterminado);*/

                ToolStripMenuItem reportemovimientosprodtermianado = new ToolStripMenuItem();
                reportemovimientosprodtermianado.Text = "Reporte Movimientos";
                reportemovimientosprodtermianado.Click += new EventHandler(reportemovimientoDePalletInterplantaToolStripMenuItem_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(reportemovimientosprodtermianado);

                ToolStripMenuItem swapentreplantasprodterminado = new ToolStripMenuItem();
                swapentreplantasprodterminado.Text = "Swap Entre Plantas";
                swapentreplantasprodterminado.Click += new EventHandler(swapentreplantasprodterminado_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(swapentreplantasprodterminado);

                ToolStripMenuItem reporteswapprodterminado = new ToolStripMenuItem();
                reporteswapprodterminado.Text = "Reporte Swap";
                reporteswapprodterminado.Click += new EventHandler(reporteswapprodterminado_Click);
                PRODUCTOTERMINADO.DropDownItems.Add(reporteswapprodterminado);

                ToolStripMenuItem reportePorBobina = new ToolStripMenuItem();
                reportePorBobina.Text = "Reportes por Bobina";
                reportePorBobina.Image = Properties.Resources.coils;
                PRODUCTOTERMINADO.DropDownItems.Add(reportePorBobina);

                ToolStripMenuItem reporteImposxBobina = new ToolStripMenuItem();
                reporteImposxBobina.Text = "Reporte Importaciones por bobina";
                reporteImposxBobina.Image = Properties.Resources.reportOff;
                reporteImposxBobina.Click += new EventHandler(reporteImportado_Click);
                reportePorBobina.DropDownItems.Add(reporteImposxBobina);

                ToolStripMenuItem cuttingReport = new ToolStripMenuItem();
                cuttingReport.Text = "Reporte corte por bobina";
                cuttingReport.Image = Properties.Resources.reportOff;
                cuttingReport.Click += new EventHandler(reporteDeCorteToolStripMenuItem_Click);
                reportePorBobina.DropDownItems.Add(cuttingReport);

                ToolStripMenuItem shippingByCoil = new ToolStripMenuItem();
                shippingByCoil.Text = "Reporte despachos por bobina";
                shippingByCoil.Image = Properties.Resources.observationCoils;
                shippingByCoil.Click += new EventHandler(reporteDespachosPorBobina_Click);
                reportePorBobina.DropDownItems.Add(shippingByCoil);

    
                #endregion

                #region Materia Prima

                ToolStripMenuItem MATERIAPRIMA = new ToolStripMenuItem();
                MATERIAPRIMA.Text = "Materia Prima";
                mnu.Items.Add(MATERIAPRIMA);

                ToolStripMenuItem estadodedepositomatprima = new ToolStripMenuItem();
                estadodedepositomatprima.Text = "Estado de Deposito";
                estadodedepositomatprima.Click += new EventHandler(estadoDeDepositoMP_Click);
                MATERIAPRIMA.DropDownItems.Add(estadodedepositomatprima);

                ToolStripMenuItem depotStateByDate = new ToolStripMenuItem();
                depotStateByDate.Text = "Estado de deposito por fecha";
                depotStateByDate.Click += new EventHandler(depotMPByDate_Click);
                MATERIAPRIMA.DropDownItems.Add(depotStateByDate);

                ToolStripMenuItem ingresoMP = new ToolStripMenuItem();
                ingresoMP.Text = "Ingresos";
                MATERIAPRIMA.DropDownItems.Add(ingresoMP);

                ToolStripMenuItem ingresosmatprimapresea = new ToolStripMenuItem();
                ingresosmatprimapresea.Text = "Presea";
                ingresosmatprimapresea.Click += new EventHandler(ingresosmatprimapresea_Click);
                ingresoMP.DropDownItems.Add(ingresosmatprimapresea);

                ToolStripMenuItem ingresomateriaprimaManual = new ToolStripMenuItem();
                ingresomateriaprimaManual.Text = "Manual";
                ingresomateriaprimaManual.Click += new EventHandler(ingresomateriaprimaManual_Click);
                ingresoMP.DropDownItems.Add(ingresomateriaprimaManual);

                ToolStripMenuItem reportIngresoMP = new ToolStripMenuItem();
                reportIngresoMP.Text = "Reporte Ingreso";
                reportIngresoMP.Click += new EventHandler(reportIngresoMP_Click);
                MATERIAPRIMA.DropDownItems.Add(reportIngresoMP);

                ToolStripMenuItem notificacionderecuperadomatprima = new ToolStripMenuItem();
                notificacionderecuperadomatprima.Text = "Notificacion de Recuperado";
                notificacionderecuperadomatprima.Click += new EventHandler(notificacionderecuperadomatprima_Click);
                MATERIAPRIMA.DropDownItems.Add(notificacionderecuperadomatprima);

                ToolStripMenuItem reImpresionDeEtiqueta = new ToolStripMenuItem();
                reImpresionDeEtiqueta.Text = "Re-impresion de etiquetas de pallets";
                reImpresionDeEtiqueta.Click += new EventHandler(reImpresionDeEtiquetasMP_Click);
                MATERIAPRIMA.DropDownItems.Add(reImpresionDeEtiqueta);

                ToolStripMenuItem movimientosmatprima = new ToolStripMenuItem();
                movimientosmatprima.Text = "Movimientos";
                movimientosmatprima.Click += new EventHandler(movementInterCellar_Click);
                MATERIAPRIMA.DropDownItems.Add(movimientosmatprima);

                ToolStripMenuItem reportemovimientosmatprima = new ToolStripMenuItem();
                reportemovimientosmatprima.Text = "Reporte Movimientos";
                reportemovimientosmatprima.Click += new EventHandler(reportemovimientosmatprima_Click);
                MATERIAPRIMA.DropDownItems.Add(reportemovimientosmatprima);

                ToolStripMenuItem swapentreplantasmatprima = new ToolStripMenuItem();
                swapentreplantasmatprima.Text = "Swap Entre Plantas";
                swapentreplantasmatprima.Click += new EventHandler(swapMateriasPrimas_Click);
                MATERIAPRIMA.DropDownItems.Add(swapentreplantasmatprima);

                ToolStripMenuItem reporteswapmatprima = new ToolStripMenuItem();
                reporteswapmatprima.Text = "Reporte Swap";
                reporteswapmatprima.Click += new EventHandler(swapRawMaterialReport_Click);
                MATERIAPRIMA.DropDownItems.Add(reporteswapmatprima);

                ToolStripMenuItem despachoMp = new ToolStripMenuItem();
                despachoMp.Text = "Despacho de Materias primas";
                despachoMp.Click += new EventHandler(despachoMP_Click);
                MATERIAPRIMA.DropDownItems.Add(despachoMp);

                ToolStripMenuItem despachoReport = new ToolStripMenuItem();
                despachoReport.Text = "Reporte de Despachos de Materia Primas";
                despachoReport.Click += new EventHandler(despachoReport_Click);
                MATERIAPRIMA.DropDownItems.Add(despachoReport);

                ToolStripMenuItem generarPalletsHijos = new ToolStripMenuItem();
                generarPalletsHijos.Text = "Generar Pallets MP Hijos";
                generarPalletsHijos.Image = Properties.Resources.reprocess;
                generarPalletsHijos.Click += new EventHandler(generarPalletHijo_Click);
                MATERIAPRIMA.DropDownItems.Add(generarPalletsHijos);

                /*ToolStripMenuItem reporteConsumoMP = new ToolStripMenuItem();
                reporteswapmatprimaconsumo.Text = "Reporte Consumo Materias Primas";
                reporteswapmatprimaconsumo.Click += new EventHandler(ordenesDeExtrusiónBoppToolStripMenuItem_Click);
                MATERIAPRIMA.DropDownItems.Add(reporteswapmatprimaconsumo);*/

                #endregion

                #region Scrap

                ToolStripMenuItem SCRAP = new ToolStripMenuItem();
                SCRAP.Text = "Scrap";
                mnu.Items.Add(SCRAP);

                ToolStripMenuItem estadodedepositoscrap = new ToolStripMenuItem();
                estadodedepositoscrap.Text = "Estado de Deposito";
                estadodedepositoscrap.Click += new EventHandler(estadodedepositoscrap_Click);
                SCRAP.DropDownItems.Add(estadodedepositoscrap);

                ToolStripMenuItem movimientosscrap = new ToolStripMenuItem();
                movimientosscrap.Text = "Movimientos";
                movimientosscrap.Click += new EventHandler(movimientosscrap_Click);
                SCRAP.DropDownItems.Add(movimientosscrap);

                ToolStripMenuItem reportemovimientosscrap = new ToolStripMenuItem();
                reportemovimientosscrap.Text = "Reporte Movimientos";
                reportemovimientosscrap.Click += new EventHandler(reportemovimientosscrap_Click);
                SCRAP.DropDownItems.Add(reportemovimientosscrap);

                ToolStripMenuItem swappalletscrap = new ToolStripMenuItem();
                swappalletscrap.Text = "Swap de Pallet Scrap";
                swappalletscrap.Click += new EventHandler(swapScrapPallet_Click);
                SCRAP.DropDownItems.Add(swappalletscrap);

                ToolStripMenuItem swappalletscrapreport = new ToolStripMenuItem();
                swappalletscrapreport.Text = "Reporte Swap de Pallets de Scrap";
                swappalletscrapreport.Click += new EventHandler(scrapPalletSwapReportMenuItem_Click);
                SCRAP.DropDownItems.Add(swappalletscrapreport);

                #endregion

                #region Reportes

                ToolStripMenuItem reporte = new ToolStripMenuItem();
                reporte.Text = "Reporte";
                mnu.Items.Add(reporte);

                ToolStripMenuItem reporteReproceso = new ToolStripMenuItem();
                reporteReproceso.Text = "Reporte de Reprocesos";
                reporteReproceso.Click += new EventHandler(reporteRepreocessToolStripMenuItem_Click);
                reporte.DropDownItems.Add(reporteReproceso);

                ToolStripMenuItem control = new ToolStripMenuItem();
                control.Text = "Control de producción";
                control.Click += new EventHandler(ControlDeProduccionToolStripMenuItem_Click);
                reporte.DropDownItems.Add(control);

                #endregion

                Button btnImported = new Button();

                btnImported.Image = global::BPS.Lite.Properties.Resources.Raw1;
                btnImported.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
                btnImported.Location = new System.Drawing.Point(2, 84 + (6 * 70));
                btnImported.Name = "btnImported";
                btnImported.Size = new System.Drawing.Size(95, 70);
                btnImported.TabIndex = 2;
                btnImported.Text = "Ingreso Importación";
                btnImported.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnImported.UseVisualStyleBackColor = true;
                btnImported.Click += new System.EventHandler(this.btnImported_Click);

                pnlShortCut.Controls.Add(btnImported);
            }
            else
            {
                //Botones para resto de los usuarios
                //pnlShortCut.Visible = false;
                movimientosTSMLog.Visible = false;
                tsmInProcessCoils.Visible = false;
                tsmOrderList_PL.Visible = false;
                tsmCoils_PL.Visible = false;

                Button btnCellarMovements = new Button();

                btnCellarMovements.Image = global::BPS.Lite.Properties.Resources.Raw;
                //btnCellarMovements.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
                btnCellarMovements.Location = new System.Drawing.Point(2, 12 + (0 * 70));
                btnCellarMovements.Name = "btnCellarMovements";
                btnCellarMovements.Size = new System.Drawing.Size(95, 70);
                btnCellarMovements.TabIndex = 0;
                btnCellarMovements.Text = "Ingresos";
                btnCellarMovements.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnCellarMovements.UseVisualStyleBackColor = true;
                btnCellarMovements.Click += new System.EventHandler(this.btnCellarMovements_Click);

                pnlShortCut.Controls.Add(btnCellarMovements);

                Button btnDepotOut = new Button();
                btnDepotOut.Image = global::BPS.Lite.Properties.Resources.RawOut;
                btnDepotOut.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                btnDepotOut.Location = new System.Drawing.Point(2, 24 + (1 * 70));
                btnDepotOut.Name = "btnBL";
                btnDepotOut.Size = new System.Drawing.Size(95, 70);
                btnDepotOut.TabIndex = 1;
                btnDepotOut.Text = "Egresos";
                btnDepotOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnDepotOut.UseVisualStyleBackColor = true;
                btnDepotOut.Click += new System.EventHandler(this.btnDepotOut_Click);

                pnlShortCut.Controls.Add(btnDepotOut);

                Button btnBL = new Button();

                btnBL.Image = global::BPS.Lite.Properties.Resources.ret_1;
                btnBL.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
                btnBL.Location = new System.Drawing.Point(2, 36 + (2 * 70));
                btnBL.Name = "btnBL";
                btnBL.Size = new System.Drawing.Size(95, 70);
                btnBL.TabIndex = 1;
                btnBL.Text = "Deposito";
                btnBL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnBL.UseVisualStyleBackColor = true;
                btnBL.Click += new System.EventHandler(this.btnBL_Click);

                pnlShortCut.Controls.Add(btnBL);

                Button btnPreShipping = new Button();

                btnPreShipping.Image = global::BPS.Lite.Properties.Resources.pallet_24;
                btnPreShipping.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
                btnPreShipping.Location = new System.Drawing.Point(2, 48 + (3 * 70));
                btnPreShipping.Name = "btnPreShipping";
                btnPreShipping.Size = new System.Drawing.Size(95, 70);
                btnPreShipping.TabIndex = 2;
                btnPreShipping.Text = "Pre - Despachos";
                btnPreShipping.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnPreShipping.UseVisualStyleBackColor = true;
                btnPreShipping.Click += new System.EventHandler(this.btnPreShipping_Click);

                pnlShortCut.Controls.Add(btnPreShipping);

                Button btnShipping = new Button();

                btnShipping.Image = global::BPS.Lite.Properties.Resources.delivery;
                //btnShipping.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
                btnShipping.Location = new System.Drawing.Point(2, 60 + (4 * 70));
                btnShipping.Name = "btnShipping";
                btnShipping.Size = new System.Drawing.Size(95, 70);
                btnShipping.TabIndex = 2;
                btnShipping.Text = "Despachos";
                btnShipping.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnShipping.UseVisualStyleBackColor = true;
                btnShipping.Click += new System.EventHandler(this.btnShipping_Click);

                pnlShortCut.Controls.Add(btnShipping);

                Button btnReturn = new Button();

                btnReturn.Image = global::BPS.Lite.Properties.Resources.Return;
                //btnReturn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
                btnReturn.Location = new System.Drawing.Point(2, 72 + (5 * 70));
                btnReturn.Name = "btnReturn";
                btnReturn.Size = new System.Drawing.Size(95, 70);
                btnReturn.TabIndex = 2;
                btnReturn.Text = "Devoluciones";
                btnReturn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnReturn.UseVisualStyleBackColor = true;
                btnReturn.Click += new System.EventHandler(this.btnReturn_Click);

                pnlShortCut.Controls.Add(btnReturn);


                Button btnImported = new Button();

                btnImported.Image = global::BPS.Lite.Properties.Resources.Raw1;
                btnImported.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
                btnImported.Location = new System.Drawing.Point(2, 84 + (6 * 70));
                btnImported.Name = "btnImported";
                btnImported.Size = new System.Drawing.Size(95, 70);
                btnImported.TabIndex = 2;
                btnImported.Text = "Ingreso Importación";
                btnImported.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnImported.UseVisualStyleBackColor = true;
                btnImported.Click += new System.EventHandler(this.btnImported_Click);

                pnlShortCut.Controls.Add(btnImported);



                /*Button btnPackingList = new Button();

                btnPackingList.Image = global::BPS.Lite.Properties.Resources.clipboard_text;
                btnPackingList.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
                btnPackingList.Location = new System.Drawing.Point(10, 72 + (5 * 70));
                btnPackingList.Name = "btnPackingList";
                btnPackingList.Size = new System.Drawing.Size(85, 70);
                btnPackingList.TabIndex = 2;
                btnPackingList.Text = "Listas de Empaque";
                btnPackingList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnPackingList.UseVisualStyleBackColor = true;
                btnPackingList.Click += new System.EventHandler(this.btnPackingList_Click);

                pnlShortCut.Controls.Add(btnPackingList);*/

                Button btnExpPresea = new Button();

                btnExpPresea.Image = global::BPS.Lite.Properties.Resources.arrow_right;
                btnExpPresea.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
                btnExpPresea.Location = new System.Drawing.Point(2, 96 + (7 * 70));
                btnExpPresea.Name = "btnExpPresea";
                btnExpPresea.Size = new System.Drawing.Size(95, 70);
                btnExpPresea.TabIndex = 2;
                btnExpPresea.Text = "Exportar Ingresos";
                btnExpPresea.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnExpPresea.UseVisualStyleBackColor = true;
                btnExpPresea.Click += new System.EventHandler(this.btnExpPresea_Click);

                pnlShortCut.Controls.Add(btnExpPresea);

                /*Button btnExpOPresea = new Button();

                btnExpOPresea.Image = global::BPS.Lite.Properties.Resources.arrow_left;
                btnExpOPresea.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
                btnExpOPresea.Location = new System.Drawing.Point(10, 84 + (6 * 70));
                btnExpOPresea.Name = "btnExpOPresea";
                btnExpOPresea.Size = new System.Drawing.Size(85, 70);
                btnExpOPresea.TabIndex = 2;
                btnExpOPresea.Text = "Exportar Egresos";
                btnExpOPresea.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btnExpOPresea.UseVisualStyleBackColor = true;
                //btnExpOPresea.Click += new System.EventHandler(this.btnExpPresea_Click);

                pnlShortCut.Controls.Add(btnExpOPresea);
                */
                mnu.Items.Remove(detalleDePalletToolStripMenuItem);
                mnu.Items.Remove(digitaciónToolStripMenuItem);

            }

            tsslUserName.Text = clsGlobal.LoggedUser.firstName + " " + clsGlobal.LoggedUser.lastName;

            if (clsGlobal.DataBaseEngine == "MySql")
                tsslDatabase.Image = global::BPS.Lite.Properties.Resources.sqlserver;
            else
                tsslDatabase.Image = global::BPS.Lite.Properties.Resources.sqlserver;

            tsslDatabase.ToolTipText = clsGlobal.server;

            if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
                tsslVersion.Text = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.Major.ToString() + "." +
                    System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.Minor.ToString() + "." +
                    System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.Build.ToString() + "." +
                    System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.Revision.ToString();
            else
                tsslVersion.Text = string.Empty;
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            frmSwapPallet generateNewReport = new frmSwapPallet();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }



        private void btnExpPresea_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("EXEC spLastDepotIn");
                string lastin = DS.Tables[0].Rows[0][0].ToString();
                DS = clsConnection.getDataSetResult("SELECT * FROM vwlastinexp");
                string lastinexp = DS.Tables[0].Rows[0][0].ToString();
                DS = clsConnection.getDataSetResult("EXEC spDepotIn @lastinexp=" + @lastinexp + ", @lastin=" + lastin);
                clsConnection.executeQuery("UPDATE bps_admin_presea SET pre_lastinexp=" + lastin + " WHERE pre_codsec=1;");

                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
                worksheet.Name = "Exportación de ingresos a BPT";

                for (int i = 1; i < DS.Tables[0].Columns.Count + 1; i++)
                    worksheet.Cells[1, i] = DS.Tables[0].Columns[i - 1].ToString();

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    for (int j = 0; j < DS.Tables[0].Columns.Count; j++)
                    {
                        if (DS.Tables[0].Rows[i][j].ToString() != null)
                            if (j != 1)
                            {
                                if (DS.Tables[0].Rows[i][j].ToString().Length >= 8)
                                {
                                    switch (DS.Tables[0].Rows[i][j].ToString().Substring(0, 8))
                                    {
                                        case "PGBTF017":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF17";
                                            break;
                                        case "PGBTF020":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF20";
                                            break;
                                        case "PGBTF025":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF25";
                                            break;
                                        case "PGBTF030":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF30";
                                            break;
                                        case "PGBTF035":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF35";
                                            break;
                                        default:
                                            worksheet.Cells[i + 2, j + 1] = "'" + DS.Tables[0].Rows[i][j].ToString();
                                            break;
                                    }
                                }
                                else
                                {
                                    worksheet.Cells[i + 2, j + 1] = "'" + DS.Tables[0].Rows[i][j].ToString();
                                }

                            }
                            else
                            {
                                if (DS.Tables[0].Rows[i][j].ToString().Length >= 8)
                                {
                                    switch (DS.Tables[0].Rows[i][j].ToString().Substring(0, 8))
                                    {
                                        case "PGBTF017":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF17";
                                            break;
                                        case "PGBTF020":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF20";
                                            break;
                                        case "PGBTF025":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF25";
                                            break;
                                        case "PGBTF030":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF30";
                                            break;
                                        case "PGBTF035":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF35";
                                            break;
                                        default:
                                            worksheet.Cells[i + 2, j + 1] = DS.Tables[0].Rows[i][j].ToString();
                                            break;
                                    }
                                }
                                else
                                {
                                    worksheet.Cells[i + 2, j + 1] = DS.Tables[0].Rows[i][j].ToString();
                                }
                            }
                    }
                }
                MessageBox.Show("Exportación Generada correctamente", "Exportación de ingresos a BPT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exportación de ingresos a BPT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExpPreseaPL_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("EXEC spLastDepotInPL");
                string lastin = DS.Tables[0].Rows[0][0].ToString();
                DS = clsConnection.getDataSetResult("SELECT * FROM vwlastinexpPL");
                string lastinexp = DS.Tables[0].Rows[0][0].ToString();
                DS = clsConnection.getDataSetResult("EXEC spDepotInPL @lastinexp=" + @lastinexp + ", @lastin=" + lastin);
                clsConnection.executeQuery("UPDATE bps_admin_presea SET pre_lastinexpPL=" + lastin + " WHERE pre_codsec=1;");

                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
                worksheet.Name = "Exportación de ingresos a BPT";

                for (int i = 1; i < DS.Tables[0].Columns.Count + 1; i++)
                    worksheet.Cells[1, i] = DS.Tables[0].Columns[i - 1].ToString();

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    for (int j = 0; j < DS.Tables[0].Columns.Count; j++)
                    {
                        if (DS.Tables[0].Rows[i][j].ToString() != null)
                            if (j != 1)
                            {
                                if (DS.Tables[0].Rows[i][j].ToString().Length >= 8)
                                {
                                    switch (DS.Tables[0].Rows[i][j].ToString().Substring(0, 8))
                                    {
                                        case "PGBTF017":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF17";
                                            break;
                                        case "PGBTF020":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF20";
                                            break;
                                        case "PGBTF025":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF25";
                                            break;
                                        case "PGBTF030":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF30";
                                            break;
                                        case "PGBTF035":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF35";
                                            break;
                                        default:
                                            worksheet.Cells[i + 2, j + 1] = "'" + DS.Tables[0].Rows[i][j].ToString();
                                            break;
                                    }
                                }
                                else
                                {
                                    worksheet.Cells[i + 2, j + 1] = "'" + DS.Tables[0].Rows[i][j].ToString();
                                }

                            }
                            else
                            {
                                if (DS.Tables[0].Rows[i][j].ToString().Length >= 8)
                                {
                                    switch (DS.Tables[0].Rows[i][j].ToString().Substring(0, 8))
                                    {
                                        case "PGBTF017":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF17";
                                            break;
                                        case "PGBTF020":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF20";
                                            break;
                                        case "PGBTF025":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF25";
                                            break;
                                        case "PGBTF030":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF30";
                                            break;
                                        case "PGBTF035":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF35";
                                            break;
                                        default:
                                            worksheet.Cells[i + 2, j + 1] = DS.Tables[0].Rows[i][j].ToString();
                                            break;
                                    }
                                }
                                else
                                {
                                    worksheet.Cells[i + 2, j + 1] = DS.Tables[0].Rows[i][j].ToString();
                                }
                            }
                    }
                }
                MessageBox.Show("Exportación Generada correctamente", "Exportación de ingresos a BPT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exportación de ingresos a BPT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCoil_Click(object sender, EventArgs e)
        {
            frmCoilTraceability winCoil = new frmCoilTraceability();
            winCoil.MdiParent = this;
            winCoil.StartPosition = FormStartPosition.CenterScreen;
            winCoil.Show();
        }

        private void btnPallet_Click(object sender, EventArgs e)
        {
            frmPalletDetail winPallet = new frmPalletDetail();
            winPallet.MdiParent = this;
            winPallet.StartPosition = FormStartPosition.CenterScreen;
            winPallet.Show();
        }

        private void btnRack_Click(object sender, EventArgs e)
        {
            frmMainCoilStock winRack;
            if (clsGlobal.LoggedUser.RoleName == "Supervisor Pilar" || clsGlobal.LoggedUser.RoleName == "Digitador Pilar")
            {
                winRack = new frmMainCoilStock(3024);
            }
            else
            {
                winRack = new frmMainCoilStock(11);
            }

            winRack.MdiParent = this;
            winRack.StartPosition = FormStartPosition.CenterScreen;
            winRack.Show();
        }

        private void btnCellarMovements_Click(object sender, EventArgs e)
        {
            //frmCoilCellarMovements winCoilCellarMovements = new frmCoilCellarMovements();
            frmDepotIn winCoilCellarMovements = new frmDepotIn();
            winCoilCellarMovements.MdiParent = this;
            winCoilCellarMovements.StartPosition = FormStartPosition.CenterScreen;
            winCoilCellarMovements.Show();
        }

        private void btnDepotOut_Click(object sender, EventArgs e)
        {
            frmDepotOut winDepotOut = new frmDepotOut();
            winDepotOut.MdiParent = this;
            winDepotOut.StartPosition = FormStartPosition.CenterScreen;
            winDepotOut.Show();
        }

        private void EstadoDeDeposito_Click(object sender, EventArgs e)
        {
            /*if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)
            {
                frmDepotState winDepotOut = new frmDepotState(new clsPlant(4).name);
                winDepotOut.MdiParent = this;
                winDepotOut.StartPosition = FormStartPosition.CenterScreen;
                winDepotOut.Show();
            }
            else
            {
                frmDepotState winDepotOut = new frmDepotState(new clsPlant(3).name);
                winDepotOut.MdiParent = this;
                winDepotOut.StartPosition = FormStartPosition.CenterScreen;
                winDepotOut.Show();
            }*/
            frmCompletePalletInventory winDepotOut = new frmCompletePalletInventory();
            winDepotOut.MdiParent = this;
            winDepotOut.StartPosition = FormStartPosition.CenterScreen;
            winDepotOut.Show();
        }

        private void btnBL_Click(object sender, EventArgs e)
        {
            frmDepotState winDepotOut = new frmDepotState(new clsPlant(3).name);
            winDepotOut.MdiParent = this;
            winDepotOut.StartPosition = FormStartPosition.CenterScreen;
            winDepotOut.Show();
        }

        private void btnBL2_Click(object sender, EventArgs e)
        {
            frmDepotState winDepotOut = new frmDepotState(new clsPlant(4).name);
            winDepotOut.MdiParent = this;
            winDepotOut.StartPosition = FormStartPosition.CenterScreen;
            winDepotOut.Show();
        }


        private void btnPreShipping_Click(object sender, EventArgs e)
        {
            frmPalletListPreShipping winPreShipping = new frmPalletListPreShipping();
            winPreShipping.MdiParent = this;
            winPreShipping.StartPosition = FormStartPosition.CenterScreen;
            winPreShipping.Show();
        }

        private void btnPreShipping2_Click(object sender, EventArgs e)
        {
            frmNewPreShippingList winPreShipping = new frmNewPreShippingList();
            winPreShipping.MdiParent = this;
            winPreShipping.StartPosition = FormStartPosition.CenterScreen;
            winPreShipping.Show();
        }

        private void btnPreShippingPL_Click(object sender, EventArgs e)
        {
            frmPalletListPreShipping winPreShipping = new frmPalletListPreShipping(4);
            winPreShipping.MdiParent = this;
            winPreShipping.StartPosition = FormStartPosition.CenterScreen;
            winPreShipping.Show();
        }

        private void btnShipping_Click(object sender, EventArgs e)
        {
            frmNationalPalletShipping winShipping = new frmNationalPalletShipping();
            winShipping.MdiParent = this;
            winShipping.StartPosition = FormStartPosition.CenterScreen;
            winShipping.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmCoilCellarReturnsD winCoilCellarMovements = new frmCoilCellarReturnsD();
            winCoilCellarMovements.MdiParent = this;
            winCoilCellarMovements.StartPosition = FormStartPosition.WindowsDefaultLocation;
            winCoilCellarMovements.MaximizeBox = false;
            winCoilCellarMovements.Show();
        }

        private void btnImported_Click(object sender, EventArgs e)
        {
            frmRegisterCoilPalletsImported winImported = new frmRegisterCoilPalletsImported();
            winImported.MdiParent = this;
            winImported.StartPosition = FormStartPosition.CenterScreen;
            winImported.Show();
        }

        private void btnPackingList_Click(object sender, EventArgs e)
        {
            frmSalesOrderListForPackingList winPacking = new frmSalesOrderListForPackingList();
            winPacking.MdiParent = this;
            winPacking.StartPosition = FormStartPosition.CenterScreen;
            winPacking.Show();
        }

        private void btnCutter_Click(object sender, EventArgs e)
        {
            int cuttingOrderCodsec = clsCuttingOrder.getSimplifiedActiveOrderByMachine(Convert.ToInt32(((Button)sender).Tag)).codsec;

            if (cuttingOrderCodsec > 0)
            {
                if (this.ActiveMdiChild != null)
                    this.ActiveMdiChild.Close();

                frmCuttingOrderSummary winCuttingOrderSummary = new frmCuttingOrderSummary(cuttingOrderCodsec);
                winCuttingOrderSummary.StartPosition = FormStartPosition.Manual;
                winCuttingOrderSummary.MdiParent = this;
                winCuttingOrderSummary.Show();
            }
            else
            {
                MessageBox.Show("No existe ninguna orden de corte asignada a esta cortadora", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }
        private void btnPalletCutter_Click(object sender, EventArgs e)
        {

            int cuttingOrderCodsec = clsCuttingOrder.getSimplifiedActiveOrderByMachine(Convert.ToInt32(((Button)sender).Tag)).codsec;

            if (cuttingOrderCodsec > 0)
            {
                frmStockPalletsRegistration winPalletsRegistration = new frmStockPalletsRegistration(cuttingOrderCodsec, "cuttingOrder");
                winPalletsRegistration.StartPosition = FormStartPosition.Manual;
                winPalletsRegistration.MdiParent = this;
                winPalletsRegistration.Show();
            }
            else
            {
                MessageBox.Show("No existe ninguna orden de corte asignada a esta cortadora", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void btnMetlizedOrder_Click(object sender, EventArgs e)
        {
            frmMetalizeOrderList winPalletsRegistration;
            if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)
            {
                winPalletsRegistration = new frmMetalizeOrderList(4);
            }
            else
            {
                winPalletsRegistration = new frmMetalizeOrderList(3);
            }

            if (winPalletsRegistration.isAutoricet)
            {
                winPalletsRegistration.StartPosition = FormStartPosition.Manual;
                winPalletsRegistration.MdiParent = this;
                winPalletsRegistration.Show();
            }
        }

       /* private void btnNewMetlizedOrder_Click(object sender, EventArgs e)
        {
            frmNewMetallizedCoils winPalletsRegistration;
            if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)
            {
                winPalletsRegistration = new frmNewMetallizedCoils(4);
            }
            else
            {
                winPalletsRegistration = new frmNewMetallizedCoils(3);
            }

                winPalletsRegistration.StartPosition = FormStartPosition.Manual;
                winPalletsRegistration.MdiParent = this;
                winPalletsRegistration.Show();
            
        }*/

        private void btnRawMaterial_Click(object sender, EventArgs e)
        {
            frmRawMaterial winPalletsRegistration = new frmRawMaterial();
            winPalletsRegistration.StartPosition = FormStartPosition.CenterScreen;
            winPalletsRegistration.MdiParent = this;
            winPalletsRegistration.Show();
        }

        private void btnRawMaterialEdit_Click(object sender, EventArgs e)
        {
            frmRawMaterialEdit winPalletsRegistration = new frmRawMaterialEdit();
            winPalletsRegistration.StartPosition = FormStartPosition.CenterScreen;
            winPalletsRegistration.MdiParent = this;
            winPalletsRegistration.Show();
        }

        private void btnDeadTimeMill_Click(object sender, EventArgs e)
        {
            frmDeadTimeMill winPalletsRegistration = new frmDeadTimeMill();
            winPalletsRegistration.StartPosition = FormStartPosition.CenterParent;
            winPalletsRegistration.MdiParent = this;
            winPalletsRegistration.Show();
        }

        private void btnMillPallet_Click(object sender, EventArgs e)
        {
            frmMillPalletReport winPalletsRegistration = new frmMillPalletReport();
            winPalletsRegistration.StartPosition = FormStartPosition.CenterParent;
            winPalletsRegistration.MdiParent = this;
            winPalletsRegistration.Show();
        }

        private void btnMillOrder_Click(object sender, EventArgs e)
        {
            frmMillOrder winPalletsRegistration = new frmMillOrder();
            winPalletsRegistration.StartPosition = FormStartPosition.CenterScreen;
            winPalletsRegistration.MdiParent = this;
            winPalletsRegistration.Show();
        }

        private void btnMillList_Click(object sender, EventArgs e)
        {
            frmMillList winPalletsRegistration = new frmMillList();
            if (winPalletsRegistration.isAutoricet)
            {
                winPalletsRegistration.StartPosition = FormStartPosition.CenterScreen;
                winPalletsRegistration.MdiParent = this;
                winPalletsRegistration.Show();
            }
        }

        private void btnDeadTime_Click(object sender, EventArgs e)
        {
            frmDeadTime winPalletsRegistration = new frmDeadTime();
            winPalletsRegistration.StartPosition = FormStartPosition.Manual;
            winPalletsRegistration.MdiParent = this;
            winPalletsRegistration.Show();
        }

        private void btnProductionMetal_Click(object sender, EventArgs e)
        {
            frmMetalizedProdutionReport winMetallizedOrderList = new frmMetalizedProdutionReport();
            winMetallizedOrderList.MdiParent = this;
            winMetallizedOrderList.StartPosition = FormStartPosition.Manual;
            winMetallizedOrderList.Show();
        }

        private void btnDeadTimeMetalized_Click(object sender, EventArgs e)
        {
            frmMetalizedPressionDeadTimeReport winMetallizedOrderList = new frmMetalizedPressionDeadTimeReport();
            winMetallizedOrderList.MdiParent = this;
            winMetallizedOrderList.StartPosition = FormStartPosition.Manual;
            winMetallizedOrderList.Show();
        }

        private void btnListMainCoilMetal_Click(object sender, EventArgs e)
        {
            frmMainCoilMetalList winList = new frmMainCoilMetalList();
            winList.MdiParent = this;
            winList.StartPosition = FormStartPosition.Manual;
            winList.Show();
        }

        private void btnPalletCutterSalesOrder_Click(object sender, EventArgs e)
        {
            frmPalletRegistration winPalletsRegistration = new frmPalletRegistration();
            winPalletsRegistration.StartPosition = FormStartPosition.Manual;
            winPalletsRegistration.MdiParent = this;
            winPalletsRegistration.Show();
        }

        private void btnPalletCutterStock_Click(object sender, EventArgs e)
        {
            frmSingleStockPalletsRegistration winSingleStockPalletRegistration = new frmSingleStockPalletsRegistration();
            winSingleStockPalletRegistration.StartPosition = FormStartPosition.Manual;
            winSingleStockPalletRegistration.MdiParent = this;
            winSingleStockPalletRegistration.Show();

        }

        private void newPalletMovement_Click(object sender, EventArgs e)
        {
            frmNewPalletMovement generateNewReport = new frmNewPalletMovement();
            //generateNewReport.MdiParent = this;
            //generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = true;
            generateNewReport.Show();
        }

        private void cambioDePesoDeBobinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCoilDetail winCoilDetail = new frmCoilDetail();
            winCoilDetail.StartPosition = FormStartPosition.CenterScreen;
            winCoilDetail.MdiParent = this;
            winCoilDetail.Show();
        }

        private void detalleDePalletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPalletDetail winPalletDetail = new frmPalletDetail();
            winPalletDetail.StartPosition = FormStartPosition.Manual;
            winPalletDetail.MdiParent = this;
            winPalletDetail.Show();
        }

        private void reporteDeIngresosBodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovementReportbyDate winmovement = new frmMovementReportbyDate();
            winmovement.StartPosition = FormStartPosition.Manual;
            winmovement.MdiParent = this;
            winmovement.Show();
        }

        private void detalleDePalletToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmPalletDetail winPalletDetail = new frmPalletDetail();
            winPalletDetail.StartPosition = FormStartPosition.Manual;
            winPalletDetail.MdiParent = this;
            winPalletDetail.Show();
        }

        private void loadCuttingOrderSumaryFromShortcut(object sender, EventArgs e)
        {

            //int cuttingOrderCodsec = clsCuttingOrder.getActiveOrderByMachine(Convert.ToInt32(((Button)sender).Tag.ToString().Split(new char[] { ' ' })[1])).codsec;

            int cuttingOrderCodsec = clsCuttingOrder.getActiveOrderByMachine(10).codsec;

            if (cuttingOrderCodsec > 0)
            {
                frmCuttingOrderSummaryD winCuttingOrderSumary = new frmCuttingOrderSummaryD(cuttingOrderCodsec);
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
                frmPalletsRegistrationD winPalletsByCuttingOrder = new frmPalletsRegistrationD(cuttingOrderCodsec, "cuttingOrder");
                winPalletsByCuttingOrder.MdiParent = this;
                winPalletsByCuttingOrder.StartPosition = FormStartPosition.Manual;
                winPalletsByCuttingOrder.Show();
            }
            else
            {
                MessageBox.Show("No existe ninguna orden de corte asignada a esta cortadora", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void atlasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int cuttingOrderCodsec = clsCuttingOrder.getActiveOrderByMachine(10).codsec;

            if (cuttingOrderCodsec > 0)
            {
                frmCuttingOrderSummaryD winCuttingOrderSumary = new frmCuttingOrderSummaryD(cuttingOrderCodsec);
                winCuttingOrderSumary.MdiParent = this;
                winCuttingOrderSumary.StartPosition = FormStartPosition.Manual;
                winCuttingOrderSumary.Show();
            }
            else
            {
                MessageBox.Show("No existe ninguna orden de corte asignada a esta cortadora", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void atlasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int cuttingOrderCodsec = clsCuttingOrder.getActiveOrderByMachine(10).codsec;

            if (cuttingOrderCodsec > 0)
            {
                frmPalletsRegistrationD winPalletsByCuttingOrder = new frmPalletsRegistrationD(cuttingOrderCodsec, "cuttingOrder");
                winPalletsByCuttingOrder.MdiParent = this;
                winPalletsByCuttingOrder.StartPosition = FormStartPosition.Manual;
                winPalletsByCuttingOrder.Show();
            }
            else
            {
                MessageBox.Show("No existe ninguna orden de corte asignada a esta cortadora", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void atlasToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            int cuttingOrderCodsec = clsCuttingOrder.getActiveOrderByMachine(10).codsec;

            if (cuttingOrderCodsec > 0)
            {
                frmPalletsRegistrationD winPalletsByCuttingOrder = new frmPalletsRegistrationD(cuttingOrderCodsec, "cuttingOrder");
                winPalletsByCuttingOrder.MdiParent = this;
                winPalletsByCuttingOrder.StartPosition = FormStartPosition.Manual;
                winPalletsByCuttingOrder.Show();
            }
            else
            {
                MessageBox.Show("No existe ninguna orden de corte asignada a esta cortadora", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void porOrdenDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int cuttingOrderCodsec = clsCuttingOrder.getActiveOrderByMachine(10).codsec;

            //if (cuttingOrderCodsec > 0)
            //{
            frmPalletRegistrationD winPalletsByCuttingOrder = new frmPalletRegistrationD(0, "salesOrder");
            winPalletsByCuttingOrder.MdiParent = this;
            winPalletsByCuttingOrder.StartPosition = FormStartPosition.Manual;
            winPalletsByCuttingOrder.Show();
            //}
            //else
            //{
            //    MessageBox.Show("No existe ninguna orden de corte asignada a esta cortadora", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            //}
        }

        private void atlasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmCuttingOrderList winCOList = new frmCuttingOrderList(10, true);
            winCOList.MdiParent = this;
            winCOList.StartPosition = FormStartPosition.Manual;
            winCOList.Show();
        }

        private void rebobinadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRewindCoil winRewind = new frmRewindCoil();
            winRewind.MdiParent = this;
            winRewind.StartPosition = FormStartPosition.Manual;
            winRewind.Show();
        }

        private void c230ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cuttingOrderCodsec = clsCuttingOrder.getActiveOrderByMachine(3011).codsec;

            if (cuttingOrderCodsec > 0)
            {
                frmCuttingOrderSummaryD winCuttingOrderSumary = new frmCuttingOrderSummaryD(cuttingOrderCodsec);
                winCuttingOrderSumary.MdiParent = this;
                winCuttingOrderSumary.StartPosition = FormStartPosition.Manual;
                winCuttingOrderSumary.Show();
            }
            else
            {
                MessageBox.Show("No existe ninguna orden de corte asignada a esta cortadora", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void c231ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cuttingOrderCodsec = clsCuttingOrder.getActiveOrderByMachine(3013).codsec;

            if (cuttingOrderCodsec > 0)
            {
                frmCuttingOrderSummaryD winCuttingOrderSumary = new frmCuttingOrderSummaryD(cuttingOrderCodsec);
                winCuttingOrderSumary.MdiParent = this;
                winCuttingOrderSumary.StartPosition = FormStartPosition.Manual;
                winCuttingOrderSumary.Show();
            }
            else
            {
                MessageBox.Show("No existe ninguna orden de corte asignada a esta cortadora", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void c232ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cuttingOrderCodsec = clsCuttingOrder.getActiveOrderByMachine(3012).codsec;

            if (cuttingOrderCodsec > 0)
            {
                frmCuttingOrderSummaryD winCuttingOrderSumary = new frmCuttingOrderSummaryD(cuttingOrderCodsec);
                winCuttingOrderSumary.MdiParent = this;
                winCuttingOrderSumary.StartPosition = FormStartPosition.Manual;
                winCuttingOrderSumary.Show();
            }
            else
            {
                MessageBox.Show("No existe ninguna orden de corte asignada a esta cortadora", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void c230ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int cuttingOrderCodsec = clsCuttingOrder.getActiveOrderByMachine(3011).codsec;

            if (cuttingOrderCodsec > 0)
            {
                frmPalletsRegistrationD winPalletsByCuttingOrder = new frmPalletsRegistrationD(cuttingOrderCodsec, "cuttingOrder");
                winPalletsByCuttingOrder.MdiParent = this;
                winPalletsByCuttingOrder.StartPosition = FormStartPosition.Manual;
                winPalletsByCuttingOrder.Show();
            }
            else
            {
                MessageBox.Show("No existe ninguna orden de corte asignada a esta cortadora", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void c231ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int cuttingOrderCodsec = clsCuttingOrder.getActiveOrderByMachine(3013).codsec;

            if (cuttingOrderCodsec > 0)
            {
                frmPalletsRegistrationD winPalletsByCuttingOrder = new frmPalletsRegistrationD(cuttingOrderCodsec, "cuttingOrder");
                winPalletsByCuttingOrder.MdiParent = this;
                winPalletsByCuttingOrder.StartPosition = FormStartPosition.Manual;
                winPalletsByCuttingOrder.Show();
            }
            else
            {
                MessageBox.Show("No existe ninguna orden de corte asignada a esta cortadora", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void c232ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int cuttingOrderCodsec = clsCuttingOrder.getActiveOrderByMachine(3012).codsec;

            if (cuttingOrderCodsec > 0)
            {
                frmPalletsRegistrationD winPalletsByCuttingOrder = new frmPalletsRegistrationD(cuttingOrderCodsec, "cuttingOrder");
                winPalletsByCuttingOrder.MdiParent = this;
                winPalletsByCuttingOrder.StartPosition = FormStartPosition.Manual;
                winPalletsByCuttingOrder.Show();
            }
            else
            {
                MessageBox.Show("No existe ninguna orden de corte asignada a esta cortadora", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void c230ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmCuttingOrderList winCOList = new frmCuttingOrderList(3011, true);
            winCOList.MdiParent = this;
            winCOList.StartPosition = FormStartPosition.Manual;
            winCOList.Show();
        }

        private void c231ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmCuttingOrderList winCOList = new frmCuttingOrderList(3013, true);
            winCOList.MdiParent = this;
            winCOList.StartPosition = FormStartPosition.Manual;
            winCOList.Show();
        }

        private void c232ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmCuttingOrderList winCOList = new frmCuttingOrderList(3012, true);
            winCOList.MdiParent = this;
            winCOList.StartPosition = FormStartPosition.Manual;
            winCOList.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmExecuteChangeSalesOrder winExecuteChangeSalesOrder = new frmExecuteChangeSalesOrder();
            winExecuteChangeSalesOrder.MdiParent = this;
            winExecuteChangeSalesOrder.StartPosition = FormStartPosition.Manual;
            winExecuteChangeSalesOrder.Show();
        }

        private void palletsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewPalletRegistration winNewPallet = new frmNewPalletRegistration();
            winNewPallet.MdiParent = this;
            winNewPallet.StartPosition = FormStartPosition.Manual;
            winNewPallet.Show();
        }

        private void registroDeBobinasParaReprocesoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewCoil winNewPallet = new frmNewCoil();
            winNewPallet.MdiParent = this;
            winNewPallet.StartPosition = FormStartPosition.Manual;
            winNewPallet.Show();
        }

        private void reporteDeCorteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuttingReport generateNewReport = new frmCuttingReport();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        
        /*try
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spCuttingReport;");

            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
            worksheet.Name = "Reporte de bobinas cortadas";

            for (int i = 1; i < DS.Tables[0].Columns.Count + 1; i++)
                worksheet.Cells[1, i] = DS.Tables[0].Columns[i - 1].ToString();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                for (int j = 0; j < DS.Tables[0].Columns.Count; j++)
                {
                    if (DS.Tables[0].Rows[i][j].ToString() != null)
                        worksheet.Cells[i + 2, j + 1] = DS.Tables[0].Rows[i][j].ToString();
                }
            }
            MessageBox.Show("Exportación Generada correctamente", "Reporte de bobinas cortadas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Reporte de bobinas cortadas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }*/

        private void movimientosTSMLog_Click(object sender, EventArgs e)
        {
            frmCoilCellarMovementsA winCoilCellarMovements = new frmCoilCellarMovementsA();
            winCoilCellarMovements.MdiParent = this;
            winCoilCellarMovements.StartPosition = FormStartPosition.WindowsDefaultLocation;
            winCoilCellarMovements.MaximizeBox = false;
            winCoilCellarMovements.Show();
        }

        private void reporteDeMetalizadoTSMItem_Click(object sender, EventArgs e)
        {
            frmMetallizedReport generateNewReport = new frmMetallizedReport();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();

        }

        private void reporteDeRebobinadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRewinedReport generateNewReport = new frmRewinedReport();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();

        }

        private void tsmInProcessCoils_Click(object sender, EventArgs e)
        {
            frmInProcessCoils generateNewReport = new frmInProcessCoils();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void reporteListadoDePalletsCompletosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPalletList generateNewReport = new frmPalletList();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void pLChileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPLChile generateNewReport = new frmPLChile();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void atlasToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frmCuttingOrderList winCOList = new frmCuttingOrderList(3026, true);
            winCOList.MdiParent = this;
            winCOList.StartPosition = FormStartPosition.Manual;
            winCOList.Show();
        }

        private void goebelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuttingOrderList winCOList = new frmCuttingOrderList(3025, true);
            winCOList.MdiParent = this;
            winCOList.StartPosition = FormStartPosition.Manual;
            winCOList.Show();
        }

        private void titanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuttingOrderList winCOList = new frmCuttingOrderList(3027, true);
            winCOList.MdiParent = this;
            winCOList.StartPosition = FormStartPosition.Manual;
            winCOList.Show();
        }
        
        private void atlasToolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            int cuttingOrderCodsec = clsCuttingOrder.getActiveOrderByMachine(3026).codsec;

            if (cuttingOrderCodsec > 0)
            {
                frmCuttingOrderSummaryD winCuttingOrderSumary = new frmCuttingOrderSummaryD(cuttingOrderCodsec);
                winCuttingOrderSumary.MdiParent = this;
                winCuttingOrderSumary.StartPosition = FormStartPosition.Manual;
                winCuttingOrderSumary.Show();
            }
            else
            {
                MessageBox.Show("No existe ninguna orden de corte asignada a esta cortadora", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void goebelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int cuttingOrderCodsec = clsCuttingOrder.getActiveOrderByMachine(3025).codsec;

            if (cuttingOrderCodsec > 0)
            {
                frmCuttingOrderSummaryD winCuttingOrderSumary = new frmCuttingOrderSummaryD(cuttingOrderCodsec);
                winCuttingOrderSumary.MdiParent = this;
                winCuttingOrderSumary.StartPosition = FormStartPosition.Manual;
                winCuttingOrderSumary.Show();
            }
            else
            {
                MessageBox.Show("No existe ninguna orden de corte asignada a esta cortadora", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void titanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int cuttingOrderCodsec = clsCuttingOrder.getActiveOrderByMachine(3027).codsec;

            if (cuttingOrderCodsec > 0)
            {
                frmCuttingOrderSummaryD winCuttingOrderSumary = new frmCuttingOrderSummaryD(cuttingOrderCodsec);
                winCuttingOrderSumary.MdiParent = this;
                winCuttingOrderSumary.StartPosition = FormStartPosition.Manual;
                winCuttingOrderSumary.Show();
            }
            else
            {
                MessageBox.Show("No existe ninguna orden de corte asignada a esta cortadora", "Resumen de orden de corte", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void reporteDeExtrusiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExtrusionReport generateNewReport = new frmExtrusionReport();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void estadoDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainCoilMetalStock generateNewReport = new frmMainCoilMetalStock(4);
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void estadoDeRackCortadoraPrimariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainCoilStock winRack;
            if (clsGlobal.LoggedUser.RoleName == "Supervisor Pilar" || clsGlobal.LoggedUser.RoleName == "Digitador Pilar")
            {
                winRack = new frmMainCoilStock(3024);
            }
            else
            {
                winRack = new frmMainCoilStock(11);
            }

            winRack.MdiParent = this;
            winRack.StartPosition = FormStartPosition.CenterScreen;
            winRack.Show();
        }

        private void pruebaMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PruebaMail generateNewReport = new PruebaMail();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void combinacionesCorteSecundarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSecundaryCuttingOrderMultiple generateNewReport = new frmSecundaryCuttingOrderMultiple();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void inventarioDeBobinasSueltasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCoilsWhitoutPallets generateNewReport = new frmCoilsWhitoutPallets();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void invetarioBobinasSueltasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCoilsWhitoutPallets generateNewReport = new frmCoilsWhitoutPallets();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void scrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Agrego el boton para que se muestre el frm de Scrap
            frmScrapNotifications generateNewReport = new frmScrapNotifications();
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

        private void envioMAteriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmExtrudderNotifications generateNewReport = new frmExtrudderNotifications();
            frmMillMaterialSend generateNewReport = new frmMillMaterialSend();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void scrapToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void movimientosDeScrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScrapMovementsReport generateNewReport = new frmScrapMovementsReport();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void reviveOrKillCoilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReviveOrKillCoil generateNewReport = new frmReviveOrKillCoil();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void prodcontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductionControlPerDate generateNewReport = new frmProductionControlPerDate();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void prodcont2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductionControlPerTurn generateNewReport = new frmProductionControlPerTurn();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void envioDeBobinasAlRackDeMetalizadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCoilToMetallizedRack generateNewReport = new frmCoilToMetallizedRack();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void swapInterplantaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSwapPallet generateNewReport = new frmSwapPallet();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void swapDeScrapEntrePlantasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSwapScrapPallet generateNewReport = new frmSwapScrapPallet();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void importarMateriasPrimasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInputRawMaterial generateNewReport = new frmInputRawMaterial();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void movimientosDeMateriasPrimasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRawMaterialMovementsReport generateNewReport = new frmRawMaterialMovementsReport();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void enviarBobinaAProductoEnProcesoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCoilToInProcessCellar generateNewReport = new frmCoilToInProcessCellar();
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

        private void swapMateriaPrimaEntreBodegasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInterCellarMovement generateNewReport = new frmInterCellarMovement();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void reporteSwapInterplantaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSwapReport generateNewReport = new frmSwapReport();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void movementInterCellar_Click(object sender, EventArgs e)
        {
            frmInterCellarMovement generateNewReport = new frmInterCellarMovement();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void swapMateriasPrimas_Click(object sender, EventArgs e)
        {
            frmSwapRawPallet generateNewReport = new frmSwapRawPallet();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void despachoMP_Click(object sender, EventArgs e)
        {
            frmRawMaterialDispatch generateNewReport = new frmRawMaterialDispatch();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void generarPalletHijo_Click(object sender, EventArgs e)
        {
            frmRawMaterialPalletSon generateNewReport = new frmRawMaterialPalletSon();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }


        private void despachoReport_Click(object sender, EventArgs e)
        {
            frmRawMaterialDispatchReport generateNewReport = new frmRawMaterialDispatchReport();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void swapRawMaterialReport_Click(object sender, EventArgs e)
        {
            frmRawMaterialSwapReport generateNewReport = new frmRawMaterialSwapReport();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        #region Eventos Menu Logistica Pilar

        #region Menu Despachos

        private void predespachosPL_Click(object sender, EventArgs e)
        {
            frmPalletListPreShipping winPreShipping = new frmPalletListPreShipping(4);
            winPreShipping.MdiParent = this;
            winPreShipping.StartPosition = FormStartPosition.CenterScreen;
            winPreShipping.Show();
        }

        private void romaneo_Click(object sender, EventArgs e)
        {
            Romaneo winPreShipping = new Romaneo();
            winPreShipping.MdiParent = this;
            winPreShipping.StartPosition = FormStartPosition.CenterScreen;
            winPreShipping.Show();
        }
        
        private void despachos_Click(object sender, EventArgs e)
        {
            frmNewShippings winShipping = new frmNewShippings();
            //frmNationalPalletShipping winShipping = new frmNationalPalletShipping();
            winShipping.MdiParent = this;
            winShipping.StartPosition = FormStartPosition.CenterScreen;
            winShipping.Show();
        }

        private void despachosviejo_Click(object sender, EventArgs e)
        {
            //frmNewShippings winShipping = new frmNewShippings();
            frmNationalPalletShipping winShipping = new frmNationalPalletShipping();
            winShipping.MdiParent = this;
            winShipping.StartPosition = FormStartPosition.CenterScreen;
            winShipping.Show();
        }

        private void reportedespachos_Click(object sender, EventArgs e)
        {
            frmShippingReport winShipping = new frmShippingReport();
            winShipping.MdiParent = this;
            winShipping.StartPosition = FormStartPosition.CenterScreen;
            winShipping.Show();
        }

        #endregion

        #region Menu Devoluciones

        private void devoluciones_Click(object sender, EventArgs e)
        {
            frmCoilCellarReturnsD winCoilCellarMovements = new frmCoilCellarReturnsD();
            winCoilCellarMovements.MdiParent = this;
            winCoilCellarMovements.StartPosition = FormStartPosition.WindowsDefaultLocation;
            winCoilCellarMovements.MaximizeBox = false;
            winCoilCellarMovements.Show();
        }

        private void reportedevoluciones_Click(object sender, EventArgs e)
        {
            frmCoilCellarReturnsReport winCoilCellarMovements = new frmCoilCellarReturnsReport();
            winCoilCellarMovements.MdiParent = this;
            winCoilCellarMovements.StartPosition = FormStartPosition.WindowsDefaultLocation;
            winCoilCellarMovements.MaximizeBox = false;
            winCoilCellarMovements.Show();
        }

        #endregion  

        #region Menu Producto Terminado

        private void estadodedeposito_Click(object sender, EventArgs e)
        {
            frmCompletePalletInventory winDepotOut = new frmCompletePalletInventory();
            winDepotOut.MdiParent = this;
            winDepotOut.StartPosition = FormStartPosition.CenterScreen;
            winDepotOut.Show();
        }

        private void estadopaletizado_Click(object sender, EventArgs e)
        {
            frmPaletized winDepotOut = new frmPaletized();
            winDepotOut.MdiParent = this;
            winDepotOut.StartPosition = FormStartPosition.CenterScreen;
            winDepotOut.Show();
        }

        private void swapentreplantasprodterminado_Click(object sender, EventArgs e)
        {
            frmSwapPallet generateNewReport = new frmSwapPallet();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void reporteswapprodterminado_Click(object sender, EventArgs e)
        {
            frmSwapReport generateNewReport = new frmSwapReport();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void reporteImportado_Click(object sender, EventArgs e)
        {
            frmImportReport generateNewReport = new frmImportReport();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void reporteDespachosPorBobina_Click(object sender, EventArgs e)
        {
            frmShippingReportByCoil generateNewReport = new frmShippingReportByCoil();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void reporteDespachosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShippingReport reporteDespachos = new frmShippingReport();
            reporteDespachos.MdiParent = this;
            reporteDespachos.StartPosition = FormStartPosition.Manual;
            reporteDespachos.Show();
        }

        private void peliculaReport_Click(object sender, EventArgs e)
        {
            frmDepotHistoryReport generateNewReport = new frmDepotHistoryReport();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }


        private void exportarapreseaPL_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("EXEC spLastDepotInPL");
                string lastin = DS.Tables[0].Rows[0][0].ToString();
                DS = clsConnection.getDataSetResult("SELECT * FROM vwlastinexpPL");
                string lastinexp = DS.Tables[0].Rows[0][0].ToString();
                DS = clsConnection.getDataSetResult("EXEC spDepotInPL @lastinexp=" + @lastinexp + ", @lastin=" + lastin);
                clsConnection.executeQuery("UPDATE bps_admin_presea SET pre_lastinexpPL=" + lastin + " WHERE pre_codsec=1;");

                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
                worksheet.Name = "Exportación de ingresos a BPT";

                for (int i = 1; i < DS.Tables[0].Columns.Count + 1; i++)
                    worksheet.Cells[1, i] = DS.Tables[0].Columns[i - 1].ToString();

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    for (int j = 0; j < DS.Tables[0].Columns.Count; j++)
                    {
                        if (DS.Tables[0].Rows[i][j].ToString() != null)
                            if (j != 1)
                            {
                                if (DS.Tables[0].Rows[i][j].ToString().Length >= 8)
                                {
                                    switch (DS.Tables[0].Rows[i][j].ToString().Substring(0, 8))
                                    {
                                        case "PGBTF017":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF17";
                                            break;
                                        case "PGBTF020":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF20";
                                            break;
                                        case "PGBTF025":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF25";
                                            break;
                                        case "PGBTF030":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF30";
                                            break;
                                        case "PGBTF035":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF35";
                                            break;
                                        default:
                                            worksheet.Cells[i + 2, j + 1] = "'" + DS.Tables[0].Rows[i][j].ToString();
                                            break;
                                    }
                                }
                                else
                                {
                                    worksheet.Cells[i + 2, j + 1] = "'" + DS.Tables[0].Rows[i][j].ToString();
                                }

                            }
                            else
                            {
                                if (DS.Tables[0].Rows[i][j].ToString().Length >= 8)
                                {
                                    switch (DS.Tables[0].Rows[i][j].ToString().Substring(0, 8))
                                    {
                                        case "PGBTF017":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF17";
                                            break;
                                        case "PGBTF020":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF20";
                                            break;
                                        case "PGBTF025":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF25";
                                            break;
                                        case "PGBTF030":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF30";
                                            break;
                                        case "PGBTF035":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF35";
                                            break;
                                        default:
                                            worksheet.Cells[i + 2, j + 1] = DS.Tables[0].Rows[i][j].ToString();
                                            break;
                                    }
                                }
                                else
                                {
                                    worksheet.Cells[i + 2, j + 1] = DS.Tables[0].Rows[i][j].ToString();
                                }
                            }
                    }
                }
                MessageBox.Show("Exportación Generada correctamente", "Exportación de ingresos a BPT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exportación de ingresos a BPT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        #region Materia Prima

        private void estadoDeDepositoMP_Click(object sender, EventArgs e)
        {
            frmRawMaterialDepositState generateNewReport = new frmRawMaterialDepositState();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void depotMPByDate_Click(object sender, EventArgs e)
        {
            frmRawMaterialStockByDate generateNewReport = new frmRawMaterialStockByDate();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void ingresosmatprimapresea_Click(object sender, EventArgs e)
        {
            frmInputRawMaterial generateNewReport = new frmInputRawMaterial();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void ingresomateriaprimaManual_Click(object sender, EventArgs e)
        {
            frmRawMaterialInputManual generateNewReport = new frmRawMaterialInputManual();
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

        private void notificacionderecuperadomatprima_Click(object sender, EventArgs e)
        {
            frmMillProduction generateNewReport = new frmMillProduction();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void reImpresionDeEtiquetasMP_Click(object sender, EventArgs e)
        {
            frmRawMaterialRePrintLabel generateNewReport = new frmRawMaterialRePrintLabel();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void reportemovimientosmatprima_Click(object sender, EventArgs e)
        {
            frmRawMaterialMovementsReport generateNewReport = new frmRawMaterialMovementsReport();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        #endregion

        #region Scrap

        private void estadodedepositoscrap_Click(object sender, EventArgs e)
        {
            frmScrapPalletStockReport winDepotOut = new frmScrapPalletStockReport();
            winDepotOut.MdiParent = this;
            winDepotOut.StartPosition = FormStartPosition.CenterScreen;
            winDepotOut.Show();
        }

        private void movimientosscrap_Click(object sender, EventArgs e)
        {
            frmScrapIntercellarMovement winDepotOut = new frmScrapIntercellarMovement();
            winDepotOut.MdiParent = this;
            winDepotOut.StartPosition = FormStartPosition.CenterScreen;
            winDepotOut.Show();
        }
        
        private void reportemovimientosscrap_Click(object sender, EventArgs e)
        {
            frmScrapMovementsReport winDepotOut = new frmScrapMovementsReport();
            winDepotOut.MdiParent = this;
            winDepotOut.StartPosition = FormStartPosition.CenterScreen;
            winDepotOut.Show();
        }

        private void swapScrapPallet_Click(object sender, EventArgs e)
        {
            frmSwapScrapPallet winDepotOut = new frmSwapScrapPallet();
            winDepotOut.MdiParent = this;
            winDepotOut.StartPosition = FormStartPosition.CenterScreen;
            winDepotOut.Show();
        }
  
        #endregion


        #endregion

        #region Eventos Logistica Campana

        private void estadodedepositoC_Click(object sender, EventArgs e)
        {
            frmDepotState winDepotOut = new frmDepotState(new clsPlant(3).name);
            winDepotOut.MdiParent = this;
            winDepotOut.StartPosition = FormStartPosition.CenterScreen;
            winDepotOut.Show();
        }

        private void ingresosprodterminado_Click(object sender, EventArgs e)
        {
            frmDepotIn winCoilCellarMovements = new frmDepotIn();
            winCoilCellarMovements.MdiParent = this;
            winCoilCellarMovements.StartPosition = FormStartPosition.CenterScreen;
            winCoilCellarMovements.Show();
        }

        private void egresosprodterminado_Click(object sender, EventArgs e)
        {
            frmDepotOut winDepotOut = new frmDepotOut();
            winDepotOut.MdiParent = this;
            winDepotOut.StartPosition = FormStartPosition.CenterScreen;
            winDepotOut.Show();
        }

        private void exportarapresea_Click(object sender, EventArgs e)
        {
            try
            {   
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("EXEC spLastDepotIn");
                string lastin = DS.Tables[0].Rows[0][0].ToString();
                DS = clsConnection.getDataSetResult("SELECT * FROM vwlastinexp");
                string lastinexp = DS.Tables[0].Rows[0][0].ToString();
                DS = clsConnection.getDataSetResult("EXEC spDepotIn @lastinexp=" + @lastinexp + ", @lastin=" + lastin);
                clsConnection.executeQuery("UPDATE bps_admin_presea SET pre_lastinexp=" + lastin + " WHERE pre_codsec=1;");

                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
                worksheet.Name = "Exportación de ingresos a BPT";

                for (int i = 1; i < DS.Tables[0].Columns.Count + 1; i++)
                    worksheet.Cells[1, i] = DS.Tables[0].Columns[i - 1].ToString();

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    for (int j = 0; j < DS.Tables[0].Columns.Count; j++)
                    {
                        if (DS.Tables[0].Rows[i][j].ToString() != null)
                            if (j != 1)
                            {
                                if (DS.Tables[0].Rows[i][j].ToString().Length >= 8)
                                {
                                    switch (DS.Tables[0].Rows[i][j].ToString().Substring(0, 8))
                                    {
                                        case "PGBTF017":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF17";
                                            break;
                                        case "PGBTF020":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF20";
                                            break;
                                        case "PGBTF025":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF25";
                                            break;
                                        case "PGBTF030":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF30";
                                            break;
                                        case "PGBTF035":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF35";
                                            break;
                                        default:
                                            worksheet.Cells[i + 2, j + 1] = "'" + DS.Tables[0].Rows[i][j].ToString();
                                            break;
                                    }
                                }
                                else
                                {
                                    worksheet.Cells[i + 2, j + 1] = "'" + DS.Tables[0].Rows[i][j].ToString();
                                }

                            }
                            else
                            {
                                if (DS.Tables[0].Rows[i][j].ToString().Length >= 8)
                                {
                                    switch (DS.Tables[0].Rows[i][j].ToString().Substring(0, 8))
                                    {
                                        case "PGBTF017":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF17";
                                            break;
                                        case "PGBTF020":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF20";
                                            break;
                                        case "PGBTF025":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF25";
                                            break;
                                        case "PGBTF030":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF30";
                                            break;
                                        case "PGBTF035":
                                            worksheet.Cells[i + 2, j + 1] = "PGBTF35";
                                            break;
                                        default:
                                            worksheet.Cells[i + 2, j + 1] = DS.Tables[0].Rows[i][j].ToString();
                                            break;
                                    }
                                }
                                else
                                {
                                    worksheet.Cells[i + 2, j + 1] = DS.Tables[0].Rows[i][j].ToString();
                                }
                            }
                    }
                }
                MessageBox.Show("Exportación Generada correctamente", "Exportación de ingresos a BPT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exportación de ingresos a BPT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void predespachos_Click(object sender, EventArgs e)
        {
            frmPalletListPreShipping winPreShipping = new frmPalletListPreShipping(3);
            winPreShipping.MdiParent = this;
            winPreShipping.StartPosition = FormStartPosition.CenterScreen;
            winPreShipping.Show();
        }

        #endregion  

        private void nuevaDigitaciónToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void reetiquetadoDePeliculaEquivalenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelabelFilmEquivalences generateNewReport = new frmRelabelFilmEquivalences();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void goebelToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int cuttingOrderCodsec = clsCuttingOrder.getActiveOrderByMachine(10).codsec;

            frmCuttingOrderNotification generateNewReport = new frmCuttingOrderNotification(cuttingOrderCodsec);
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void atlasCampanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cuttingOrderCodsec = clsCuttingOrder.getActiveOrderByMachine(3011).codsec;

            frmCuttingOrderNotification generateNewReport = new frmCuttingOrderNotification(cuttingOrderCodsec);
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void c231ToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            int cuttingOrderCodsec = clsCuttingOrder.getActiveOrderByMachine(3013).codsec;

            frmCuttingOrderNotification generateNewReport = new frmCuttingOrderNotification(cuttingOrderCodsec);
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void c232ToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            int cuttingOrderCodsec = clsCuttingOrder.getActiveOrderByMachine(3012).codsec;

            frmCuttingOrderNotification generateNewReport = new frmCuttingOrderNotification(cuttingOrderCodsec);
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void goebelToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            int cuttingOrderCodsec = clsCuttingOrder.getActiveOrderByMachine(3025).codsec;

            frmCuttingOrderNotification generateNewReport = new frmCuttingOrderNotification(cuttingOrderCodsec);
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void atlasPilarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cuttingOrderCodsec = clsCuttingOrder.getActiveOrderByMachine(3026).codsec;

            frmCuttingOrderNotification generateNewReport = new frmCuttingOrderNotification(cuttingOrderCodsec);
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void titanToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int cuttingOrderCodsec = clsCuttingOrder.getActiveOrderByMachine(3027).codsec;

            frmCuttingOrderNotification generateNewReport = new frmCuttingOrderNotification(cuttingOrderCodsec);
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void movimientoDePalletInterplantaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPalletMovement generateNewReport = new frmPalletMovement();
            //generateNewReport.MdiParent = this;
            generateNewReport.MaximizeBox = true;
            generateNewReport.StartPosition = FormStartPosition.CenterParent;
            generateNewReport.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            generateNewReport.PerformAutoScale();
            generateNewReport.Show();
            
        }

        private void asignacionDePosicionTooStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSwapPalletPositionCamp generateNewReport = new frmSwapPalletPositionCamp();
            //generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterParent;
            generateNewReport.MaximizeBox = true;
            generateNewReport.PerformAutoScale();
            generateNewReport.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            generateNewReport.Show();
        }
        

        private void reportemovimientoDePalletInterplantaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPalletMovementReport generateNewReport = new frmPalletMovementReport();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void scrapPalletSwapReportMenuItem_Click(object sender, EventArgs e)
        {
            frmScrapPalletSwapReport generateNewReport = new frmScrapPalletSwapReport();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }
        private void historialDeRackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRackHistory generateNewReport = new frmRackHistory();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void bobinasColgantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainCoilMetalStock generateNewReport = new frmMainCoilMetalStock(3);
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void reetiquetadoAStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelabelToStock generateNewReport = new frmRelabelToStock();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewPreShippingList generateNewReport = new frmNewPreShippingList();
            generateNewReport.MdiParent = this;
            generateNewReport.StartPosition = FormStartPosition.CenterScreen;
            generateNewReport.MaximizeBox = false;
            generateNewReport.Show();
        }

        private void stockOP1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompleteCoilInventory winDepotOut = new frmCompleteCoilInventory();
            winDepotOut.MdiParent = this;
            winDepotOut.StartPosition = FormStartPosition.CenterScreen;
            winDepotOut.Show();
        }

        private void reporteRepreocessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReprocessCoilReport winDepotOut = new frmReprocessCoilReport();
            winDepotOut.MdiParent = this;
            winDepotOut.StartPosition = FormStartPosition.CenterScreen;
            winDepotOut.Show();
        }

        private void ControlDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductionControl winDepotOut = new frmProductionControl();
            winDepotOut.MdiParent = this;
            winDepotOut.StartPosition = FormStartPosition.CenterScreen;
            winDepotOut.Show();
        }

        private void bindingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewPallet winDepotOut = new frmNewPallet();
            winDepotOut.MdiParent = this;
            winDepotOut.StartPosition = FormStartPosition.CenterScreen;
            winDepotOut.Show();
        }

        private void impoPeruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImportacionPeru winDepotOut = new frmImportacionPeru();
            winDepotOut.MdiParent = this;
            winDepotOut.StartPosition = FormStartPosition.CenterScreen;
            winDepotOut.Show();
        }

        private void impoChileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPLChile winDepotOut = new frmPLChile();
            winDepotOut.MdiParent = this;
            winDepotOut.StartPosition = FormStartPosition.CenterScreen;
            winDepotOut.Show();
        }

        private void pruebaPalletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPalletCellarReturn palletCellarReturn = new frmPalletCellarReturn();
            palletCellarReturn.MdiParent = this;
            palletCellarReturn.StartPosition = FormStartPosition.CenterScreen;
            palletCellarReturn.Show();
        }

        private void condicionesOperativasMetalizadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOperativeConditionsMetalized opConMet = new frmOperativeConditionsMetalized();
            opConMet.MdiParent = this;
            opConMet.StartPosition = FormStartPosition.CenterScreen;
            opConMet.Show();
        }

        private void pruebaCondicionesMetalizadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOperativeConditionsMetalized opConMet = new frmOperativeConditionsMetalized();
            opConMet.MdiParent = this;
            opConMet.StartPosition = FormStartPosition.CenterScreen;
            opConMet.Show();
        }

        private void pruebaCondicionesOperativasMetReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOperativeConditionMetalizedReport opConMetRep = new frmOperativeConditionMetalizedReport();
            opConMetRep.MdiParent = this;
            opConMetRep.StartPosition = FormStartPosition.CenterScreen;
            opConMetRep.Show();
        }

        private void pruebaControlDeProduPorTurnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void historialCompletoDeBobinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCoilHistory form = new frmCoilHistory();
            form.StartPosition = FormStartPosition.Manual;
            form.MdiParent = this;
            form.Show();
        }

        private void historialCompletoDePalletsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPalletDepotHistory form = new frmPalletDepotHistory();
            form.StartPosition = FormStartPosition.Manual;
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmRawDepotHistory form = new frmRawDepotHistory();
            form.StartPosition = FormStartPosition.Manual;
            form.MdiParent = this;
            form.Show();
        }

        private void historialRackPrimarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRackHistory form = new frmRackHistory();
            form.StartPosition = FormStartPosition.Manual;
            form.MdiParent = this;
            form.Show();
        }

        private void historialRackSecundarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSecundaryRackHistory form = new frmSecundaryRackHistory();
            form.StartPosition = FormStartPosition.Manual;
            form.MdiParent = this;
            form.Show();
        }

        private void btnNewMetlizedOrder_Click(object sender, EventArgs e)
        {
            frmNewMetallizedCoils form = new frmNewMetallizedCoils(4);
            form.StartPosition = FormStartPosition.Manual;
            form.MdiParent = this;
            form.Show();
        }
        
    }
}
