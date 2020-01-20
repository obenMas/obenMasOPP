using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;

namespace BPS.Bussiness
{
    public class clsProductionOrderDetail
    {
        private int pod_fkProductionOrder;
        private int pod_fkFilmProductionPlan;
        private int pod_fkBopp;
        private string pod_BoppCode;
        private int pod_fkCast;
        private string pod_castCode;
        private int pod_OrderNumber;
        private int pod_fkStatus;
        private string pod_StatusName;
        private double pod_Quantity;
        private double pod_FulfilledQuantity;
        private int pod_fkMachine;
        private string pod_MachineName;

        //Properties
        public int fkProductionOrder { get { return pod_fkProductionOrder; } set { pod_fkProductionOrder = value; } }

        public int fkFilmProductionPlan { get { return pod_fkFilmProductionPlan; } set { pod_fkFilmProductionPlan = value; } }

        public int fkBopp { get { return pod_fkBopp; } set { pod_fkBopp = value; } }

        public string BoppCode { get { return pod_BoppCode; } set { pod_BoppCode = value; } }

        public int fkCast { get { return pod_fkCast; } set { pod_fkCast = value; } }

        public string castCode { get { return pod_castCode; } set { pod_castCode = value; } }

        public int OrderNumber { get { return pod_OrderNumber; } set { pod_OrderNumber = value; } }

        public int fkStatus { get { return pod_fkStatus; } set { pod_fkStatus = value; } }

        public string StatusName { get { return pod_StatusName; } set { pod_StatusName = value; } }

        public double Quantity { get { return pod_Quantity; } set { pod_Quantity = value; } }

        public double FulfilledQuantity { get { return pod_FulfilledQuantity; } set { pod_FulfilledQuantity = value; } }

        public int fkMachine { get { return pod_fkMachine; } set { pod_fkMachine = value; } }

        public string MachineName { get { return pod_MachineName; } set { pod_MachineName = value; } }

        //Constructor

        public clsProductionOrderDetail()
        {
            pod_fkProductionOrder = 0;
            pod_fkFilmProductionPlan = 0;
            pod_fkBopp = 0;
            pod_BoppCode = "";
            pod_fkCast = 0;
            pod_castCode = "";
            pod_OrderNumber = 0;
            pod_fkStatus = 0;
            pod_StatusName = "";
            pod_Quantity = 0;
            pod_FulfilledQuantity = 0;
            pod_fkMachine = 0;
            pod_MachineName = "";
        }

        public clsProductionOrderDetail(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spProductionOrderByFilmProductionPlan " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["popp_fkProductionOrder"]);
                this.fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[0]["popp_fkFilmProductionPlan"]);
                this.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["popp_fkBopp"]);
                this.BoppCode = DS.Tables[0].Rows[0]["popp_BoppCode"].ToString();
                this.fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["popp_fkCast"]);
                this.castCode = DS.Tables[0].Rows[0]["popp_castCode"].ToString();
                this.OrderNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["popp_OrderNumber"]);
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["popp_fkStatus"]);
                this.StatusName = DS.Tables[0].Rows[0]["popp_StatusName"].ToString();
                this.Quantity = Convert.ToDouble(DS.Tables[0].Rows[0]["popp_Quantity"]);
                this.FulfilledQuantity = Convert.ToDouble(DS.Tables[0].Rows[0]["popp_FulfilledQuantity"]);
                this.fkMachine = Convert.ToInt32(DS.Tables[0].Rows[0]["popp_fkMachine"]);
                this.MachineName = DS.Tables[0].Rows[0]["popp_MachineName"].ToString();
            }
        }
    }
}
