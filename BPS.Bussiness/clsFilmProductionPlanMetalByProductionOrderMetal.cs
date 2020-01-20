using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{

    /// <summary>
    /// Clase que trae el detalle de ordenes de extrusion y ordenes de planificacion
    /// </summary>
    public class clsFilmProductionPlanMetalByProductionOrderMetal
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

        //Constructor

        public clsFilmProductionPlanMetalByProductionOrderMetal()
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
        }

        public clsFilmProductionPlanMetalByProductionOrderMetal(int codsec)
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

        public static clsFilmProductionPlanMetalByProductionOrderMetal getActiveOrder(DateTime initdate, DateTime enddate)
        {

            clsFilmProductionPlanMetalByProductionOrderMetal objFilmProductionPlanMetalByProductionOrderMetal = new clsFilmProductionPlanMetalByProductionOrderMetal();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spMailMetalFilm 'ProductionNowMainCoilMetal', '" + initdate.ToString("dd/MM/yyyy HH:mm:ss") + "', '" + enddate.ToString("dd/MM/yyyy HH:mm:ss") + "', 0, '' ");

            if (DS.Tables[0].Rows.Count > 0)
            {
                objFilmProductionPlanMetalByProductionOrderMetal.fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[0]["pordm_fkFilmProductionPlan"]);
                objFilmProductionPlanMetalByProductionOrderMetal.BoppCode = DS.Tables[0].Rows[0]["pordm_BoppTo"].ToString();
                objFilmProductionPlanMetalByProductionOrderMetal.Quantity = Convert.ToDouble(DS.Tables[0].Rows[0]["pordm_quantity"]);
                objFilmProductionPlanMetalByProductionOrderMetal.FulfilledQuantity = Convert.ToDouble(DS.Tables[0].Rows[0]["pordm_fullquantity"]);
                objFilmProductionPlanMetalByProductionOrderMetal.endDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["pordm_modifiedDate"]);

                //Percentaje
                objFilmProductionPlanMetalByProductionOrderMetal.percentaje = Convert.ToDouble(DS.Tables[0].Rows[0]["popp_percentaje"]);
                //Faltante
                objFilmProductionPlanMetalByProductionOrderMetal.faltante = Convert.ToDouble(DS.Tables[0].Rows[0]["popp_un"]);
                //Tiempo Faltante
                objFilmProductionPlanMetalByProductionOrderMetal.tfp = Convert.ToDouble(DS.Tables[0].Rows[0]["popp_tun"]);
            }
            return objFilmProductionPlanMetalByProductionOrderMetal;
        }

        public override string ToString()
        {
            return this.BoppCode;
        }

        public double percentaje { get; set; }

        public double faltante { get; set; }

        public int kgph { get; set; }

        public double tfp { get; set; }
    }
}

