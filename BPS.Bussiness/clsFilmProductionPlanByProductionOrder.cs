using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
namespace BPS.Bussiness
{

    /// <summary>
    /// Clase que trae el detalle de ordenes de extrusion y ordenes de planificacion
    /// </summary>
    public class clsFilmProductionPlanByProductionOrder
    {
        //Atrubutes
        private int popp_fkProductionOrder;
        private int popp_fkFilmProductionPlan;
        private int popp_fkBopp;
        private string popp_BoppCode;
        private int popp_fkCast;
        private string popp_CastCode;
        private int popp_OrderNumber;
        private string popp_lotNumber;
        private int popp_fkStatus;
        private string popp_StatusName;
        private double popp_Quantity;
        private double popp_FulfilledQuantity;
        private DateTime popp_initDate;
        private DateTime popp_endDate;
        private int popp_estimatedLength;
        private string popp_widths;
        private int popp_deadtime;
        private string popp_machineName;

        //Properties
        public int fkProductionOrder { get { return popp_fkProductionOrder; } set { popp_fkProductionOrder = value; } }

        public int fkFilmProductionPlan { get { return popp_fkFilmProductionPlan; } set { popp_fkFilmProductionPlan = value; } }

        public int fkBopp { get { return popp_fkBopp; } set { popp_fkBopp = value; } }

        public string BoppCode { get { return popp_BoppCode; } set { popp_BoppCode = value; } }

        public int fkCast { get { return popp_fkCast; } set { popp_fkCast = value; } }

        public string castCode { get { return popp_CastCode; } set { popp_CastCode = value; } }

        public int OrderNumber { get { return popp_OrderNumber; } set { popp_OrderNumber = value; } }

        public string lotNumber { get { return popp_lotNumber; } set { popp_lotNumber = value; } }

        public int fkStatus { get { return popp_fkStatus; } set { popp_fkStatus = value; } }

        public string StatusName { get { return popp_StatusName; } set { popp_StatusName = value; } }

        public double Quantity { get { return popp_Quantity; } set { popp_Quantity = value; } }

        public double FulfilledQuantity { get { return popp_FulfilledQuantity; } set { popp_FulfilledQuantity = value; } }

        public DateTime initDate { get { return popp_initDate; } set { popp_initDate = value; } }

        public DateTime endDate { get { return popp_endDate; } set { popp_endDate = value; } }

        public int estimatedLength { get { return popp_estimatedLength; } set { popp_estimatedLength = value; } }

        public string widths { get { return popp_widths; } set { popp_widths = value; } }

        public int deadtime { get { return popp_deadtime; } set { popp_deadtime = value; } }

        public string machinename { get { return popp_machineName; } set { popp_machineName = value; } }

        //Constructor

        public clsFilmProductionPlanByProductionOrder()
        {
            popp_fkProductionOrder = 0;
            popp_fkFilmProductionPlan = 0;
            popp_fkBopp = 0;
            popp_BoppCode = "";
            popp_fkCast = 0;
            popp_CastCode = "";
            popp_OrderNumber = 0;
            popp_lotNumber = "";
            popp_fkStatus = 0;
            popp_StatusName = "";
            popp_Quantity = 0;
            popp_FulfilledQuantity = 0;
            popp_initDate = DateTime.Now;
            popp_endDate = DateTime.Now;
            popp_estimatedLength = 0;
            popp_widths = "";
            popp_deadtime = 0;
            popp_machineName = string.Empty;
        }

        public clsFilmProductionPlanByProductionOrder(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spProductionOrderByFilmProductionPlan(" + codsec.ToString() + ")");

            this.fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["popp_fkProductionOrder"]);
            this.fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[0]["popp_fkFilmProductionPlan"]);
            this.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["popp_Bopp"]);
            this.BoppCode = DS.Tables[0].Rows[0]["popp_BoppCode"].ToString();
            this.fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["popp_fkCast"]);
            this.castCode = DS.Tables[0].Rows[0]["popp_castCode"].ToString();
            this.OrderNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["popp_OrderNumber"]);
            this.lotNumber = DS.Tables[0].Rows[0]["popp_lotNumber"].ToString();
            this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["popp_fkStatus"]);
            this.StatusName = DS.Tables[0].Rows[0]["popp_StatusName"].ToString();
            this.Quantity = Convert.ToDouble(DS.Tables[0].Rows[0]["popp_Quantity"]);
            this.FulfilledQuantity = Convert.ToDouble(DS.Tables[0].Rows[0]["popp_FulfilledQuantity"]);
            this.initDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["popp_initDate"]);
            this.endDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["popp_endDate"]);
            this.estimatedLength = Convert.ToInt32(DS.Tables[0].Rows[0]["popp_estimatedLength"]);
            this.widths = DS.Tables[0].Rows[0]["popp_widths"].ToString();
        }


        public static List<clsFilmProductionPlanByProductionOrder> getListActiveOrderByMachine(int machineCodsec)
        {

            List<clsFilmProductionPlanByProductionOrder> lstFilmProductionPlanByProductionOrder = new List<clsFilmProductionPlanByProductionOrder>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spProductionOrderByFilmProductionPlanAndMachine(" + machineCodsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstFilmProductionPlanByProductionOrder.Add(new clsFilmProductionPlanByProductionOrder());
                    lstFilmProductionPlanByProductionOrder[i].fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["popp_fkProductionOrder"]);
                    lstFilmProductionPlanByProductionOrder[i].fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[i]["popp_fkFilmProductionPlan"]);
                    lstFilmProductionPlanByProductionOrder[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["popp_fkBopp"]);
                    lstFilmProductionPlanByProductionOrder[i].BoppCode = DS.Tables[0].Rows[i]["popp_BoppCode"].ToString();
                    lstFilmProductionPlanByProductionOrder[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["popp_fkCast"]);
                    lstFilmProductionPlanByProductionOrder[i].castCode = DS.Tables[0].Rows[i]["popp_castCode"].ToString();
                    lstFilmProductionPlanByProductionOrder[i].OrderNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["popp_OrderNumber"]);
                    lstFilmProductionPlanByProductionOrder[i].lotNumber = DS.Tables[0].Rows[i]["popp_lotNumber"].ToString();
                    lstFilmProductionPlanByProductionOrder[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["popp_fkStatus"]);
                    lstFilmProductionPlanByProductionOrder[i].StatusName = DS.Tables[0].Rows[i]["popp_StatusName"].ToString();
                    lstFilmProductionPlanByProductionOrder[i].Quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["popp_Quantity"]);
                    lstFilmProductionPlanByProductionOrder[i].FulfilledQuantity = Convert.ToDouble(DS.Tables[0].Rows[i]["popp_FulfilledQuantity"]);
                    lstFilmProductionPlanByProductionOrder[i].initDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["popp_initDate"]);
                    lstFilmProductionPlanByProductionOrder[i].endDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["popp_endDate"]);
                    lstFilmProductionPlanByProductionOrder[i].estimatedLength = Convert.ToInt32(DS.Tables[0].Rows[i]["popp_estimatedLength"]);
                    lstFilmProductionPlanByProductionOrder[i].widths = DS.Tables[0].Rows[i]["popp_widths"].ToString();
                    lstFilmProductionPlanByProductionOrder[i].deadtime = Convert.ToInt32(DS.Tables[0].Rows[i]["popp_deattime"]);
                    lstFilmProductionPlanByProductionOrder[i].machinename = DS.Tables[0].Rows[i]["popp_machineName"].ToString();
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return lstFilmProductionPlanByProductionOrder;
        }
        public static clsFilmProductionPlanByProductionOrder getActiveOrderByMachine(int machineCodsec)
        {

            clsFilmProductionPlanByProductionOrder objFilmProductionPlanByProductionOrder = new clsFilmProductionPlanByProductionOrder();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spProductionOrderByMachineActive(" + machineCodsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                objFilmProductionPlanByProductionOrder.fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["popp_fkProductionOrder"]);
                objFilmProductionPlanByProductionOrder.fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[0]["popp_fkFilmProductionPlan"]);
                objFilmProductionPlanByProductionOrder.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["popp_fkBopp"]);
                objFilmProductionPlanByProductionOrder.BoppCode = DS.Tables[0].Rows[0]["popp_BoppCode"].ToString();
                objFilmProductionPlanByProductionOrder.fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["popp_fkCast"]);
                objFilmProductionPlanByProductionOrder.castCode = DS.Tables[0].Rows[0]["popp_castCode"].ToString();
                objFilmProductionPlanByProductionOrder.OrderNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["popp_OrderNumber"]);
                objFilmProductionPlanByProductionOrder.lotNumber = DS.Tables[0].Rows[0]["popp_lotNumber"].ToString();
                objFilmProductionPlanByProductionOrder.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["popp_fkStatus"]);
                objFilmProductionPlanByProductionOrder.StatusName = DS.Tables[0].Rows[0]["popp_StatusName"].ToString();
                objFilmProductionPlanByProductionOrder.Quantity = Convert.ToDouble(DS.Tables[0].Rows[0]["popp_Quantity"]);
                objFilmProductionPlanByProductionOrder.FulfilledQuantity = Convert.ToDouble(DS.Tables[0].Rows[0]["popp_FulfilledQuantity"]);
                //   objFilmProductionPlanByProductionOrder.initDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["popp_initDate"]);
                objFilmProductionPlanByProductionOrder.endDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["popp_endDate"]);
                objFilmProductionPlanByProductionOrder.estimatedLength = Convert.ToInt32(DS.Tables[0].Rows[0]["popp_estimatedLength"]);
                objFilmProductionPlanByProductionOrder.widths = DS.Tables[0].Rows[0]["popp_widths"].ToString();

                //Percentaje
                objFilmProductionPlanByProductionOrder.percentaje = Convert.ToDouble(DS.Tables[0].Rows[0]["popp_percentaje"]);
                //Faltante
                objFilmProductionPlanByProductionOrder.faltante = Convert.ToDouble(DS.Tables[0].Rows[0]["popp_un"]);
                //kgph
                objFilmProductionPlanByProductionOrder.kgph = Convert.ToInt32(DS.Tables[0].Rows[0]["popp_kgH"]);
                //Tiempo Faltante
                objFilmProductionPlanByProductionOrder.tfp = Convert.ToDouble(DS.Tables[0].Rows[0]["popp_tun"]);
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return objFilmProductionPlanByProductionOrder;
        }

        public static clsFilmProductionPlanByProductionOrder getActiveOrderByFilmProductionPlan(int filmProductionPlanCodsec)
        {

            clsFilmProductionPlanByProductionOrder objFilmProductionPlanByProductionOrder = new clsFilmProductionPlanByProductionOrder();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spProductionOrderByFilmProductionPlanCodsec(" + filmProductionPlanCodsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                objFilmProductionPlanByProductionOrder.fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["popp_fkProductionOrder"]);
                objFilmProductionPlanByProductionOrder.fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[0]["popp_fkFilmProductionPlan"]);
                objFilmProductionPlanByProductionOrder.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["popp_fkBopp"]);
                objFilmProductionPlanByProductionOrder.BoppCode = DS.Tables[0].Rows[0]["popp_BoppCode"].ToString();
                objFilmProductionPlanByProductionOrder.fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["popp_fkCast"]);
                objFilmProductionPlanByProductionOrder.castCode = DS.Tables[0].Rows[0]["popp_castCode"].ToString();
                objFilmProductionPlanByProductionOrder.OrderNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["popp_OrderNumber"]);
                objFilmProductionPlanByProductionOrder.lotNumber = DS.Tables[0].Rows[0]["popp_lotNumber"].ToString();
                objFilmProductionPlanByProductionOrder.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["popp_fkStatus"]);
                objFilmProductionPlanByProductionOrder.StatusName = DS.Tables[0].Rows[0]["popp_StatusName"].ToString();
                objFilmProductionPlanByProductionOrder.Quantity = Convert.ToDouble(DS.Tables[0].Rows[0]["popp_Quantity"]);
                objFilmProductionPlanByProductionOrder.FulfilledQuantity = Convert.ToDouble(DS.Tables[0].Rows[0]["popp_FulfilledQuantity"]);
                //   objFilmProductionPlanByProductionOrder.initDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["popp_initDate"]);
                //   objFilmProductionPlanByProductionOrder.endDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["popp_endDate"]);
                objFilmProductionPlanByProductionOrder.estimatedLength = Convert.ToInt32(DS.Tables[0].Rows[0]["popp_estimatedLength"]);
                objFilmProductionPlanByProductionOrder.widths = DS.Tables[0].Rows[0]["popp_widths"].ToString();
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return objFilmProductionPlanByProductionOrder;
        }
        public override string ToString()
        {
            return this.BoppCode;
        }



        public static List<clsFilmProductionPlanByProductionOrder> getListActiveOrderByMachineByFilter(int machine, int bopp)
        {
            List<clsFilmProductionPlanByProductionOrder> productionList = new List<clsFilmProductionPlanByProductionOrder>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spBoopMultiple " + machine.ToString() + "," + bopp.ToString() + ",'','','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "', 'filterProductionOrder'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    productionList.Add(new clsFilmProductionPlanByProductionOrder());
                    productionList[i].fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["popp_fkProductionOrder"]);
                    productionList[i].fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[i]["popp_fkFilmProductionPlan"]);
                    productionList[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["popp_fkBopp"]);
                    productionList[i].BoppCode = DS.Tables[0].Rows[i]["popp_BoppCode"].ToString();
                    productionList[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["popp_fkCast"]);
                    productionList[i].castCode = DS.Tables[0].Rows[i]["popp_castCode"].ToString();
                    productionList[i].OrderNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["popp_OrderNumber"]);
                    productionList[i].lotNumber = DS.Tables[0].Rows[i]["popp_lotNumber"].ToString();
                    productionList[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["popp_fkStatus"]);
                    productionList[i].StatusName = DS.Tables[0].Rows[i]["popp_StatusName"].ToString();
                    productionList[i].Quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["popp_Quantity"]);
                    productionList[i].FulfilledQuantity = Convert.ToDouble(DS.Tables[0].Rows[i]["popp_FulfilledQuantity"]);
                    productionList[i].initDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["popp_initDate"]);
                    productionList[i].endDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["popp_endDate"]);
                    productionList[i].estimatedLength = Convert.ToInt32(DS.Tables[0].Rows[i]["popp_estimatedLength"]);
                    productionList[i].widths = DS.Tables[0].Rows[i]["popp_widths"].ToString();
                    productionList[i].deadtime = Convert.ToInt32(DS.Tables[0].Rows[i]["popp_deattime"]);
                    productionList[i].machinename = DS.Tables[0].Rows[i]["popp_machineName"].ToString();
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return productionList;
        }

        public static List<clsFilmProductionPlanByProductionOrder> getListActiveOrderByMachineByFilter(int machine, string lote)
        {
            List<clsFilmProductionPlanByProductionOrder> productionList = new List<clsFilmProductionPlanByProductionOrder>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spBoopMultiple " + machine.ToString() + ",0,'" + lote + "','','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "', 'filterProductionOrderLot'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    productionList.Add(new clsFilmProductionPlanByProductionOrder());
                    productionList[i].fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["popp_fkProductionOrder"]);
                    productionList[i].fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[i]["popp_fkFilmProductionPlan"]);
                    productionList[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["popp_fkBopp"]);
                    productionList[i].BoppCode = DS.Tables[0].Rows[i]["popp_BoppCode"].ToString();
                    productionList[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["popp_fkCast"]);
                    productionList[i].castCode = DS.Tables[0].Rows[i]["popp_castCode"].ToString();
                    productionList[i].OrderNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["popp_OrderNumber"]);
                    productionList[i].lotNumber = DS.Tables[0].Rows[i]["popp_lotNumber"].ToString();
                    productionList[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["popp_fkStatus"]);
                    productionList[i].StatusName = DS.Tables[0].Rows[i]["popp_StatusName"].ToString();
                    productionList[i].Quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["popp_Quantity"]);
                    productionList[i].FulfilledQuantity = Convert.ToDouble(DS.Tables[0].Rows[i]["popp_FulfilledQuantity"]);
                    productionList[i].initDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["popp_initDate"]);
                    productionList[i].endDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["popp_endDate"]);
                    productionList[i].estimatedLength = Convert.ToInt32(DS.Tables[0].Rows[i]["popp_estimatedLength"]);
                    productionList[i].widths = DS.Tables[0].Rows[i]["popp_widths"].ToString();
                    productionList[i].deadtime = Convert.ToInt32(DS.Tables[0].Rows[i]["popp_deattime"]);
                    productionList[i].machinename = DS.Tables[0].Rows[i]["popp_machineName"].ToString();
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return productionList;
        }

        public double percentaje { get; set; }

        public double faltante { get; set; }

        public int kgph { get; set; }

        public double tfp { get; set; }
    }
}

