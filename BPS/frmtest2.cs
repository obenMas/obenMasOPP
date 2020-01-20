using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms; 
using BPS.Bussiness;

namespace BPS
{    
    public partial class frmtest2 : Form
    {

        public frmtest2()
        {
            InitializeComponent();
        }
        private void frmMachineCalendar_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            executeReorganizeInventory();
        }

        public void executeReorganizeInventory()
        {
            List<string> lstPalletCode = new List<string>();
            lstPalletCode.Add("CTOO20056000022042001");
            lstPalletCode.Add("CTOO20056000022042002");
            lstPalletCode.Add("CTOO20066000022042001");
            lstPalletCode.Add("CTOO20066000022042002");
            lstPalletCode.Add("CTOO20066000022047003");
            lstPalletCode.Add("CTOO20084000022047001");
            lstPalletCode.Add("CTOO20098000022047001");
            lstPalletCode.Add("CTOO20098000022047002");
            lstPalletCode.Add("CTOO25094000022042001");
            lstPalletCode.Add("CTOO25094000022042002");
            lstPalletCode.Add("CTOO25094000022042003");
            lstPalletCode.Add("CTOO25094000022042004");
            //lstPalletCode.Add("12A28070116451");
            //lstPalletCode.Add("");
            //lstPalletCode.Add("");
            //lstPalletCode.Add("");
            //lstPalletCode.Add("");
            //lstPalletCode.Add("");
            //lstPalletCode.Add("1211400010590");
            //lstPalletCode.Add("1211800030813");
            //lstPalletCode.Add("1211800030846");
            //lstPalletCode.Add("1212700021158");
            //lstPalletCode.Add("1212900011282");
            //lstPalletCode.Add("1213000041292");
            //lstPalletCode.Add("1213000011301");
            //lstPalletCode.Add("1213000011302");
            //lstPalletCode.Add("1220300011513");
            //lstPalletCode.Add("1220300011514");
            //lstPalletCode.Add("1220300011515");
            //lstPalletCode.Add("1220600081653");
            //lstPalletCode.Add("1220700021687");
            //lstPalletCode.Add("1220701151692");
            //lstPalletCode.Add("1221000011843");
            //lstPalletCode.Add("1221600052234");
            //lstPalletCode.Add("1221600052235");
            //lstPalletCode.Add("1221600082236");
            //lstPalletCode.Add("1221600012239");
            //lstPalletCode.Add("1221600012240");
            //lstPalletCode.Add("1221700032242");
            //lstPalletCode.Add("1222700012763");
            //lstPalletCode.Add("1230200023009");
            //lstPalletCode.Add("1230700033270");
            //lstPalletCode.Add("1230700033271");
            //lstPalletCode.Add("1230800013301");
            //lstPalletCode.Add("1231200013545");
            //lstPalletCode.Add("1231200013549");
            //lstPalletCode.Add("1231300043618");
            //lstPalletCode.Add("1231300013622");
            //lstPalletCode.Add("1231500013717");
            //lstPalletCode.Add("1231500013718");
            //lstPalletCode.Add("1231903023964");
            //lstPalletCode.Add("1231900013968");
            //lstPalletCode.Add("1232000034046");
            //lstPalletCode.Add("1232000124048");
            //lstPalletCode.Add("1232000064055");
            //lstPalletCode.Add("1232000024063");
            //lstPalletCode.Add("1232100014087");
            //lstPalletCode.Add("1232200014122");
            //lstPalletCode.Add("1232200024124");
            //lstPalletCode.Add("1232200014126");
            //lstPalletCode.Add("1232200034140");
            //lstPalletCode.Add("1232600024369");
            //lstPalletCode.Add("1232700014414");
            //lstPalletCode.Add("1232800044456");
            //lstPalletCode.Add("1232800014458");
            //lstPalletCode.Add("1232800044459");
            //lstPalletCode.Add("1232900014470");
            //lstPalletCode.Add("1232900084471");
            //lstPalletCode.Add("1232900084478");
            //lstPalletCode.Add("1232900044482");
            //lstPalletCode.Add("1232900044496");
            //lstPalletCode.Add("1233000044539");
            //lstPalletCode.Add("1233000024558");
            //lstPalletCode.Add("1233000014567");
            //lstPalletCode.Add("1233000024570");
            //lstPalletCode.Add("1233000034571");
            //lstPalletCode.Add("1233000044592");
            //lstPalletCode.Add("1233100084603");
            //lstPalletCode.Add("1233100084607");
            //lstPalletCode.Add("1233100064608");
            //lstPalletCode.Add("1233100034626");
            //lstPalletCode.Add("1233100014630");
            //lstPalletCode.Add("1240100044652");
            //lstPalletCode.Add("1240100024653");
            //lstPalletCode.Add("1240100014655");
            //lstPalletCode.Add("1240100234666");
            //lstPalletCode.Add("1240100164669");
            //lstPalletCode.Add("1240100054670");
            //lstPalletCode.Add("1240100024691");
            //lstPalletCode.Add("1240300014734");
            //lstPalletCode.Add("1240300044748");
            //lstPalletCode.Add("1240500104876");
            //lstPalletCode.Add("1240600024944");
            //lstPalletCode.Add("1240800025049");
            //lstPalletCode.Add("1240800025058");
            //lstPalletCode.Add("1240800025064");
            //lstPalletCode.Add("1240900055067");
            //lstPalletCode.Add("1240900055068");
            //lstPalletCode.Add("1240900025072");
            //lstPalletCode.Add("1240900015076");
            //lstPalletCode.Add("1240900025130");
            //lstPalletCode.Add("1241000025138");
            //lstPalletCode.Add("1241000045139");
            //lstPalletCode.Add("1241001035175");
            //lstPalletCode.Add("1241000015194");
            //lstPalletCode.Add("1241100015211");
            //lstPalletCode.Add("1241100015212");
            //lstPalletCode.Add("1241100045234");
            //lstPalletCode.Add("1241300045315");
            //lstPalletCode.Add("1241300045323");
            //lstPalletCode.Add("1241300065324");
            //lstPalletCode.Add("1241300045327");
            //lstPalletCode.Add("1241300015331");
            //lstPalletCode.Add("1241400065334");
            //lstPalletCode.Add("1241400015388");
            //lstPalletCode.Add("1241400015391");
            //lstPalletCode.Add("1241701015545");
            //lstPalletCode.Add("1241800025601");
            //lstPalletCode.Add("1241900035709");
            //lstPalletCode.Add("1241900035718");
            //lstPalletCode.Add("1241900025733");
            //lstPalletCode.Add("1241900025738");
            //lstPalletCode.Add("1242000025749");
            //lstPalletCode.Add("1242000065767");
            //lstPalletCode.Add("1242000035782");
            //lstPalletCode.Add("1242100025847");
            //lstPalletCode.Add("1242100065860");
            //lstPalletCode.Add("1242100055861");
            //lstPalletCode.Add("1242100065864");
            //lstPalletCode.Add("1242300025981");
            //lstPalletCode.Add("1242300055984");
            //lstPalletCode.Add("1242400025998");
            //lstPalletCode.Add("1242400026006");
            //lstPalletCode.Add("1242400026011");
            //lstPalletCode.Add("1242400026017");
            //lstPalletCode.Add("1242400026023");
            //lstPalletCode.Add("1242501016128");
            //lstPalletCode.Add("1242501016129");
            //lstPalletCode.Add("1242602016213");
            //lstPalletCode.Add("1242701026236");
            //lstPalletCode.Add("1242700016264");
            //lstPalletCode.Add("1242702036282");
            //lstPalletCode.Add("1242800086311");
            //lstPalletCode.Add("1242800056312");
            //lstPalletCode.Add("1242800046313");
            //lstPalletCode.Add("1242800026315");
            //lstPalletCode.Add("1242800016331");
            //lstPalletCode.Add("1242901066346");
            //lstPalletCode.Add("1242901066347");
            //lstPalletCode.Add("1242900026378");
            //lstPalletCode.Add("1242900016379");
            //lstPalletCode.Add("1242900036380");
            //lstPalletCode.Add("1242900026381");
            //lstPalletCode.Add("1242900016382");
            //lstPalletCode.Add("1242900016383");
            //lstPalletCode.Add("1242900016384");
            //lstPalletCode.Add("1242900016385");
            //lstPalletCode.Add("1242900016386");
            //lstPalletCode.Add("1242900036387");
            //lstPalletCode.Add("1242900026388");
            //lstPalletCode.Add("1242900016389");
            //lstPalletCode.Add("1242900046390");
            //lstPalletCode.Add("1243000016395");
            //lstPalletCode.Add("1243000016396");
            //lstPalletCode.Add("1243000036417");
            //lstPalletCode.Add("1243000046418");
            //lstPalletCode.Add("1243000026421");
            //lstPalletCode.Add("1250100016450");
            //lstPalletCode.Add("1250100016489");
            //lstPalletCode.Add("1250202056547");
            //lstPalletCode.Add("1250300066556");
            //lstPalletCode.Add("1250300066606");
            //lstPalletCode.Add("1250300046607");
            //lstPalletCode.Add("1250300016616");
            //lstPalletCode.Add("1250400026622");
            //lstPalletCode.Add("1250500046690");
            //lstPalletCode.Add("1250500036713");
            //lstPalletCode.Add("1250600026748");
            //lstPalletCode.Add("1250600016757");
            //lstPalletCode.Add("1250600016758");
            //lstPalletCode.Add("1250600016759");
            //lstPalletCode.Add("1250600016760");
            //lstPalletCode.Add("1250600016761");
            //lstPalletCode.Add("1250600016762");
            //lstPalletCode.Add("1250700016782");
            //lstPalletCode.Add("1250800016836");
            //lstPalletCode.Add("1250800046845");
            //lstPalletCode.Add("1250800026855");
            //lstPalletCode.Add("1250800056857");
            //lstPalletCode.Add("1250800086858");
            //lstPalletCode.Add("1250900016883");
            //lstPalletCode.Add("1250900016888");
            //lstPalletCode.Add("1250900046890");
            //lstPalletCode.Add("1250900096891");
            //lstPalletCode.Add("1250900016906");
            //lstPalletCode.Add("1250900016912");
            //lstPalletCode.Add("1251000036940");
            //lstPalletCode.Add("1251000026972");
            //lstPalletCode.Add("1251000026973");
            //lstPalletCode.Add("1251000016977");
            //lstPalletCode.Add("1251000016978");
            //lstPalletCode.Add("1251000016979");
            //lstPalletCode.Add("1251100026989");
            //lstPalletCode.Add("1251100046991");
            //lstPalletCode.Add("1251102047052");
            //lstPalletCode.Add("1251202047065");
            //lstPalletCode.Add("1251304047114");
            //lstPalletCode.Add("1251305037121");
            //lstPalletCode.Add("1251400027164");
            //lstPalletCode.Add("1251400027166");
            //lstPalletCode.Add("1251400027169");
            //lstPalletCode.Add("1251400027180");
            //lstPalletCode.Add("1251700047300");
            //lstPalletCode.Add("1251700047302");
            //lstPalletCode.Add("1251700047303");
            //lstPalletCode.Add("1251700037307");
            //lstPalletCode.Add("1251700047311");
            //lstPalletCode.Add("1251700017313");
            //lstPalletCode.Add("1251700027314");
            //lstPalletCode.Add("1251700017319");
            //lstPalletCode.Add("1251700027321");
            //lstPalletCode.Add("1251700017323");
            //lstPalletCode.Add("1252100047489");
            //lstPalletCode.Add("1252100047500");
            //lstPalletCode.Add("1252201017526");
            //lstPalletCode.Add("1252400027647");
            //lstPalletCode.Add("CCOO30180000020651004");
            //lstPalletCode.Add("CCOO50160000020651002");
            //lstPalletCode.Add("12724130110891");
            //lstPalletCode.Add("12813010112069");
            //lstPalletCode.Add("12831013613330");
            //lstPalletCode.Add("12901011813346");
            //lstPalletCode.Add("12901031813358");
            //lstPalletCode.Add("12901040313373");
            //lstPalletCode.Add("12921010314205");
            //lstPalletCode.Add("12924030314365");




            //lstPalletCode.Add("12723020310860");
            //lstPalletCode.Add("12724010310898");

            //lstPalletCode.Add("12724010110893");
            //lstPalletCode.Add("12724020110896");
            //lstPalletCode.Add("12724010110894");
            //lstPalletCode.Add("1270601019913");
            //lstPalletCode.Add("12715010410345");
            //lstPalletCode.Add("12715020410360");
            //lstPalletCode.Add("12714010110315");
            //lstPalletCode.Add("12716010610424");
            //lstPalletCode.Add("12716010610422");
            //lstPalletCode.Add("12713010210263");
            //lstPalletCode.Add("1252403027601");
            //lstPalletCode.Add("12724010210926");
            //lstPalletCode.Add("12724010110924");
            //lstPalletCode.Add("12724030110923");
            //lstPalletCode.Add("12724010110920");
            //lstPalletCode.Add("1261202028470");
            //lstPalletCode.Add("12721010110701");
            //lstPalletCode.Add("12721020110719");
            //lstPalletCode.Add("12720010110626");
            //lstPalletCode.Add("1262000068968");
            //lstPalletCode.Add("");
            //lstPalletCode.Add("");
            //lstPalletCode.Add("12722060210821");
            //lstPalletCode.Add("12723120210846");
            //lstPalletCode.Add("12722050210817");
            //lstPalletCode.Add("12721090210698");
            //lstPalletCode.Add("12721080210693");
            //lstPalletCode.Add("12720020210647");
            //lstPalletCode.Add("12724130110891");


            clsPallet.setUpdateStatusWhenNotDeliveryPallet(lstPalletCode);

            //clsPallet objPallet = new clsPallet();

            //for (int i = 0; i < lstPalletCode.Count; i++)
            //{
            //    try
            //    {
            //        objPallet = clsPallet.getCompleteDetailByCode(lstPalletCode[i]);

            //        if (objPallet.codsec > 0)
            //        {
            //            clsPallet.transferTo(objPallet, clsCoilCellar.getCellarByName("Producto Terminado").codsec);
            //        }
            //        else
            //        {
            //            clsLog.addLog("pallet desconocido - pallet Nro " + lstPalletCode[i] + " - pos : " + (i + 1).ToString(), 3, "Ingreso de pallets en proceso de inventario físico");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        clsLog.addLog(ex + " - pallet Nro " + lstPalletCode[i] + " - pos : " + (i + 1).ToString(), 3, "Ingreso de pallets en proceso de inventario físico");
            //        throw;
            //    }
            //}

        }

        public void ReDelivery()
        {
            List<string> lstPalletCode = new List<string>();
            List<clsPallet> lstNewList = new List<clsPallet>();
            lstNewList = clsPallet.getPalletListBySalesOrder("1370-3");

            for (int i = 0; i < lstNewList.Count; i++)
                lstPalletCode.Add(lstNewList[i].code);

            clsPallet objPallet = new clsPallet();

            for (int i = 0; i < lstPalletCode.Count; i++)
            {
                try
                {
                    objPallet = clsPallet.getCompleteDetailByCode(lstPalletCode[i]);

                    if (objPallet.codsec > 0)
                        clsPallet.transferTo(objPallet, clsCoilCellar.getCellarByName("Producto Terminado").codsec);
                    else
                        clsLog.addLog("pallet desconocido - pallet Nro " + lstPalletCode[i] + " - pos : " + (i + 1).ToString(), 3, "Ingreso de pallets en proceso de inventario físico");
                }
                catch (Exception ex)
                {
                    clsLog.addLog(ex + " - pallet Nro " + lstPalletCode[i] + " - pos : " + (i + 1).ToString(), 3, "Ingreso de pallets en proceso de inventario físico");
                    throw;
                }
            }
            clsPallet.setPalletReDelivery(lstPalletCode);
        }

        public void Delivery()
        {
            List<string> lstPalletCode = new List<string>();
            List<clsPallet> lstNewList = new List<clsPallet>();
            lstNewList = clsPallet.getPalletListBySalesOrder("1370-3");
            for (int i = 0; i < lstNewList.Count; i++)
                lstPalletCode.Add(lstNewList[i].code);
            clsPallet.setPalletAsDeliveredNational(lstPalletCode);
        }

        //public void testEmail()
        //{
        //    obenMasEmailLibrary.clsDailyEmailReport email = new obenMasEmailLibrary.clsDailyEmailReport();

        //    email.subject = "TEST";
        //    email.from = "obenmas@boppdelecuador.com";
        //    email.fromName = "OBEN MAS";
        //    email.to.Add("arizzo@boppdelecuador.com");
        //    //email.to.Add("gpico@boppdelecuador.com");
        //    email.toNames.Add("Atilio Rizzo B.");
        //    //email.toNames.Add("Galo Pico");

        //    email.smtpCredentials = new System.Net.NetworkCredential();

        //    //EMAIL BOBY
        //    DateTime initDate = new DateTime(DateTime.Now.AddDays(-1).Year, DateTime.Now.AddDays(-1).Month, DateTime.Now.AddDays(-1).Day, 7, 30, 00);
        //    DateTime endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 7, 30, 00);
        //    //DateTime initDate = new DateTime(DateTime.Now.AddDays(-1).Year, DateTime.Now.AddDays(-1).Month, 1, 7, 30, 00);
        //    //DateTime endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 2, 7, 30, 00);

        //    List<clsMachine> lstExtruders = clsMachine.getExtruderMachineList();

        //    email.messageBody = "";

        //    email.messageBody += "<h1 style = \"margin: 0px; padding: 50px 0px 0px 0px; letter-spacing: -2px; text-transform: uppercase; font-size: 40px; color: #FF9601;\">OBEN<span style =\"color: #1A1A1A;\">MAS</span></h1>";
        //    email.messageBody += "Reporte de producción del " + initDate.ToString("dd-MMMM-yyy HH:mm") + " al " + initDate.ToString("dd-MMMM-yyy HH:mm");
        //    email.messageBody += "<p>";
        //    email.messageBody += "<h2 style = \"color: #FF9601;\">Extrusión</h2>";

        //    //Extruders
        //    for (int i = 0; i < lstExtruders.Count; i++)
        //    {

        //        List<clsMainCoil> lstMainCoil = clsMainCoil.getListForReportProduction(lstExtruders[i].codsec, initDate.ToString("dd/MM/yyyy 07:30"), endDate.ToString("dd/MM/yyyy 07:30"));
        //        List<stctMainCoilSumary> lstMainCoilSumary = new List<stctMainCoilSumary>();

        //        if (lstMainCoil.Count > 0)
        //        {
        //            lstMainCoilSumary.Add(new stctMainCoilSumary());
        //            lstMainCoilSumary[0].filmCode = lstMainCoil[0].BoppCode;
        //            lstMainCoilSumary[0].mainCoilsCount = 1;
        //            lstMainCoilSumary[0].weight = lstMainCoil[0].netWeigth;
        //            lstMainCoilSumary[0].lotNumber = lstMainCoil[0].lotNumber;
        //        }

        //        for (int j = 1; j < lstMainCoil.Count; j++)
        //        {
        //            if (lstMainCoilSumary[lstMainCoilSumary.Count - 1].filmCode == lstMainCoil[j].BoppCode && lstMainCoilSumary[lstMainCoilSumary.Count - 1].lotNumber == lstMainCoil[j].lotNumber)
        //            {
        //                lstMainCoilSumary[lstMainCoilSumary.Count - 1].mainCoilsCount++;

        //                lstMainCoilSumary[lstMainCoilSumary.Count - 1].weight += lstMainCoil[j].netWeigth;
        //            }
        //            else
        //            {
        //                lstMainCoilSumary.Add(new stctMainCoilSumary());
        //                lstMainCoilSumary[lstMainCoilSumary.Count - 1].filmCode = lstMainCoil[j].BoppCode;
        //                lstMainCoilSumary[lstMainCoilSumary.Count - 1].mainCoilsCount = 1;
        //                lstMainCoilSumary[lstMainCoilSumary.Count - 1].weight = lstMainCoil[j].netWeigth;
        //                lstMainCoilSumary[lstMainCoilSumary.Count - 1].lotNumber = lstMainCoil[j].lotNumber;
        //            }
        //        }

        //        email.messageBody += "<h3>" + lstExtruders[i].Extruder.name + "</h3>";
        //        email.messageBody += "<h4>Producción</h4>";
        //        email.messageBody += "<table width=100%>";
        //        email.messageBody += "<tr><td><b>Material</b></td><td><b>Rollos</b></td><td><b>Peso</b></td><td><b>Lote</b></td></tr>";

        //        double totalMainCoilWeight = 0;

        //        if (lstMainCoilSumary.Count > 0)
        //        {
        //            for (int j = 0; j < lstMainCoilSumary.Count; j++)
        //            {
        //                email.messageBody += "<tr><td><b>" + lstMainCoilSumary[j].filmCode + "</b></td><td>" + lstMainCoilSumary[j].mainCoilsCount.ToString() + "</td><td>" + Math.Round(lstMainCoilSumary[j].weight, 1).ToString() + "</td><td>" + lstMainCoilSumary[j].lotNumber + "</td></tr>";
        //                totalMainCoilWeight += Math.Round(lstMainCoilSumary[j].weight, 1);
        //            }
        //            email.messageBody += "<tr><td></td><td>Total</td><td>" + Math.Round(totalMainCoilWeight, 1).ToString() + "</td><td></td></tr>";
        //        }
        //        else
        //        {
        //            email.messageBody += "<tr><td rowspan=4 align=center>No hay producción registrada este día</td></tr>";
        //        }

        //        email.messageBody += "</table>";

        //        List<clsDeadTimeByFilmProductionPlan> lstDeadTime = clsDeadTimeByFilmProductionPlan.getDeadTimeByMachineAndDate(initDate, endDate, lstExtruders[i].codsec);

        //        email.messageBody += "<h4>Tiempos Muertos</h4>";
        //        email.messageBody += "<table width=100%>";
        //        email.messageBody += "<tr><td><b>Tipo de tiempo muerto</b></td><td><b>Tiempo</b></td></tr>";
        //        if (lstDeadTime.Count > 0)
        //        {
        //            TimeSpan totalTS = new TimeSpan(0);

        //            for (int j = 0; j < lstDeadTime.Count; j++)
        //            {
        //                TimeSpan ts = lstDeadTime[j].endDate - lstDeadTime[j].initDate;

        //                email.messageBody += "<tr><td>" + lstDeadTime[j].deadTimeTypeName + "</td><td><b>" + ts.ToString("t") + "</b></td></tr>";
        //                totalTS += ts;
        //            }
        //            email.messageBody += "<tr><td>Total</td><td><b>" + totalTS.ToString("t") + "</b></td></tr>";
        //        }
        //        else
        //        {
        //            email.messageBody += "<tr><td rowspan=2 align=center>No existen tiempos muertos registrados este día</td></tr>";
        //        }
        //        email.messageBody += "</table>";
        //        email.messageBody += "<h4>Producción actual</h4>";

        //        clsFilmProductionPlanByProductionOrder objFilmProductionPlanByProductionOrder = clsFilmProductionPlanByProductionOrder.getActiveOrderByMachine(lstExtruders[i].codsec);
        //        double percentage = (objFilmProductionPlanByProductionOrder.FulfilledQuantity * 100) / objFilmProductionPlanByProductionOrder.Quantity;
        //        if (objFilmProductionPlanByProductionOrder.fkFilmProductionPlan > 0)
        //        {
        //            email.messageBody += "<b>Actualmente se esta produciento en la linea " + lstExtruders[i].Extruder.name + ": " + objFilmProductionPlanByProductionOrder.BoppCode + " Acumuladas " + Math.Round(objFilmProductionPlanByProductionOrder.FulfilledQuantity, 1).ToString() + " Kilos lo que representa un " + Math.Round(percentage, 2).ToString() + "% de cumplimiento de la orden de extrusion. Fecha Estimada de Finalizacion del lote : " + objFilmProductionPlanByProductionOrder.endDate.ToString("dd-MMMM-yyyy HH:mm") + "</b>";
        //        }
        //        else
        //        {
        //            email.messageBody += "<b>Actualmente no se esta produciendo ninguna orden en la línea " + lstExtruders[i].Extruder.name + " </b>";
        //        }
        //    }

        //    email.messageBody += "</p>";
        //    email.messageBody += "<p>";
        //    email.messageBody += "<h2 style = \"color: #FF9601;\">Corte</h2>";

        //    List<clsMachine> lstCutters = clsMachine.getCutterMachineList();
        //    for (int i = 0; i < lstCutters.Count; i++)
        //    {
        //        email.messageBody += "<h3>" + lstCutters[i].Cutter.name + "</h3>";
        //        email.messageBody += "<table width=100%>";
        //        email.messageBody += "<tr><td><b>Material</b></td><td><b>Bobinas</b></td><td><b>Peso ordenes</b></td><td><b>Peso stock</b></td><td><b>Total</b></td></tr>";

        //        DataSet DS = clsConnection.getDataSetResult("spTotalizedCoilByDate " + lstCutters[i].codsec + ", " + "'" + initDate.ToString("dd/MM/yyyy HH:mm") + "', " + "'" + endDate.ToString("dd/MM/yyyy HH:mm") + "'");
        //        double totalWeight = 0;

        //        for (int j = 0; j < DS.Tables[0].Rows.Count; j++)
        //        {
        //            email.messageBody += "<tr><td><b>" + DS.Tables[0].Rows[j]["productCode"].ToString() + "</b></td><td>" + DS.Tables[0].Rows[j]["coilNumber"].ToString() + "</td><td>" + Math.Round(Convert.ToDouble(DS.Tables[0].Rows[j]["totalWeightSalesOrder"]), 1).ToString() + "</td><td>" + Math.Round(Convert.ToDouble(DS.Tables[0].Rows[j]["totalWeightStock"]), 1).ToString() + "</td><td>" + Math.Round(Convert.ToDouble(DS.Tables[0].Rows[j]["totalWeight"]), 1).ToString() + "</td></tr>";
        //            totalWeight += Math.Round(Convert.ToDouble(DS.Tables[0].Rows[j]["totalWeight"]), 1);
        //        }

        //        email.messageBody += "<tr><td></td><td></td><td></td><td><b>Total</b></td><td><b>" + Math.Round(totalWeight, 1).ToString() + "</b></td></tr>";

        //        email.messageBody += "</table>";
        //    }

        //    email.messageBody += "</p>";


        //    for (int i = 0; i < email.to.Count; i++)
        //    {
        //        try
        //        {
        //            string result = email.SendEmailAsync(email.to[i], email.toNames[i]);

        //            MessageBox.Show(result);
        //        }
        //        catch (Exception ex)
        //        {

        //            MessageBox.Show("No se envió por : " + ex.Message.ToString());
        //            throw;
        //        }
        //    }
        //}
    }
    public class stctMainCoilSumary
    {
        public string filmCode { get; set; }
        public int mainCoilsCount { get; set; }
        public double weight { get; set; }
        public string lotNumber { get; set; }
    }

    public class stctCoilSumary
    {
        public string filmCode { get; set; }
        public int coilsCount { get; set; }
        public double weightStock { get; set; }
        public double weightSalesOrder { get; set; }
        public double weightTotal { get; set; }
        
    }

}