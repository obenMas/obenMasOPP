using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;


namespace BPS.Bussiness
{
    /// <summary>
    /// Clase para el manejo de la información de exportación de las ordenes de venta internacionales 
    /// </summary>
    public class clsExportData
    {
        // Atributes

        private int expd_codsec;
        private int expd_fkSalesOrder;
        private int expd_fkIncoterms;
        private string expd_incotermsName;
        private int expd_fkCityFrom;
        private string expd_cityFromName;
        private int expd_fkCityTo;
        private string expd_cityToName;
        private int expd_fkPackagingType;
        private string expd_packagingTypeName;
        private int expd_fkCurrency;
        private string expd_currencyName;
        private double expd_exchangeRate;
        private string expd_trafficification;
        private double expd_freight;
        private double expd_insurance;
        private double expd_otherCharges;


        // Properties

        public int codsec { get { return expd_codsec; } set { expd_codsec = value; } }

        public int fkSalesOrder { get { return expd_fkSalesOrder; } set { expd_fkSalesOrder = value; } }

        public int fkIncoterms { get { return expd_fkIncoterms; } set { expd_fkIncoterms = value; } }

        public int fkCityFrom { get { return expd_fkCityFrom; } set { expd_fkCityFrom = value; } }

        public int fkCityTo { get { return expd_fkCityTo; } set { expd_fkCityTo = value; } }

        public int fkPackagingType { get { return expd_fkPackagingType; } set { expd_fkPackagingType = value; } }

        public int fkCurrency { get { return expd_fkCurrency; } set { expd_fkCurrency = value; } }

        public double exchangeRate { get { return expd_exchangeRate; } set { expd_exchangeRate = value; } }

        public string trafficification { get { return expd_trafficification; } set { expd_trafficification = value; } }

        public double freight { get { return expd_freight; } set { expd_freight = value; } }

        public double insurance { get { return expd_insurance; } set { expd_insurance = value; } }

        public string incotermsName { get { return expd_incotermsName; } set { expd_incotermsName = value; } }

        public string cityFromName { get { return expd_cityFromName; } set { expd_cityFromName = value; } }

        public string cityToName { get { return expd_cityToName; } set { expd_cityToName = value; } }

        public string packagingTypeName { get { return expd_packagingTypeName; } set { expd_packagingTypeName = value; } }

        public string currencyName { get { return expd_currencyName; } set { expd_currencyName = value; } }

        public double otherCharges { get { return expd_otherCharges; } set { expd_otherCharges = value; } }
        

        // Constructor

        public clsExportData()
        {
            expd_codsec = 0;
            expd_fkSalesOrder = 0;
            expd_fkIncoterms = 0;
            expd_incotermsName = "";
            expd_fkCityFrom = 0;
            expd_cityFromName = "";
            expd_fkCityTo = 0;
            expd_cityToName = "";
            expd_fkPackagingType = 0;
            expd_packagingTypeName = "";
            expd_fkCurrency = 0;
            expd_currencyName = "";
            expd_exchangeRate = 0;
            expd_trafficification = "";
            expd_freight = 0;
            expd_insurance = 0;
            expd_otherCharges = 0;
        }

        // Methods

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_com_exportdata (expd_fkSalesOrder,expd_fkIncoterms, expd_fkCityFrom, expd_fkCityTo, expd_fkPackagingType, expd_fkCurrency, expd_exchangeRate, expd_trafficClassification, expd_freight, expd_insurance, expd_otherCharges) ";
                    queryString += " VALUES (";
                    queryString += this.fkSalesOrder.ToString() + ",";
                    queryString += this.fkIncoterms.ToString() + ",";
                    queryString += this.fkCityFrom.ToString() + ",";
                    queryString += this.fkCityTo.ToString() + ",";
                    queryString += this.fkPackagingType.ToString() + ",";
                    queryString += this.fkCurrency.ToString() + ",";
                    queryString += this.exchangeRate.ToString() + ",";
                    queryString += "'" + this.trafficification.ToString() + "',";
                    queryString += this.freight.ToString() + ",";
                    queryString += this.insurance.ToString() + ",";
                    queryString += this.otherCharges.ToString() + "";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_com_exportdata";
                    queryString += " SET ";
                    queryString += "expd_fkSalesOrder = " + this.fkSalesOrder.ToString() + ",";
                    queryString += "expd_fkIncoterms = " + this.fkIncoterms.ToString() + ",";
                    queryString += "expd_fkCityFrom = " + this.fkCityFrom.ToString() + ",";
                    queryString += "expd_fkCityTo = " + this.fkCityTo.ToString() + ",";
                    queryString += "expd_fkPackagingType = " + this.fkPackagingType.ToString() + ",";
                    queryString += "expd_fkCurrency = " + this.fkCurrency.ToString() + ",";
                    queryString += "expd_exchangeRate = " + this.exchangeRate.ToString() + ",";
                    queryString += "expd_trafficClassification = '" + this.trafficification.ToString() + "',";
                    queryString += "expd_freight = " + this.freight.ToString() + ",";
                    queryString += "expd_insurance = " + this.insurance.ToString() + ",";
                    queryString += "expd_otherCharges = " + this.otherCharges.ToString();
                    queryString += " WHERE expd_codsec = " + this.codsec.ToString() + ";";
                }

                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsExportData.save");
                return false;
            }
        }

        public clsExportData getDetailBySalesOrder(int salesOrderCodsec)
        {
            clsExportData objExportData = new clsExportData();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwExportData where expd_fkSalesOrder = " + salesOrderCodsec.ToString());
            
            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["expd_codsec"]);
                this.fkSalesOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["expd_fkSalesOrder"]);
                this.fkIncoterms = Convert.ToInt32(DS.Tables[0].Rows[0]["expd_fkIncoterms"]);
                this.incotermsName = DS.Tables[0].Rows[0]["expd_incotermsName"].ToString();
                this.fkCityFrom = Convert.ToInt32(DS.Tables[0].Rows[0]["expd_fkCityFrom"]);
                this.cityFromName = DS.Tables[0].Rows[0]["expd_cityFromName"].ToString();
                this.fkCityTo = Convert.ToInt32(DS.Tables[0].Rows[0]["expd_fkCityTo"]);
                this.cityToName = DS.Tables[0].Rows[0]["expd_cityToName"].ToString();
                this.fkPackagingType = Convert.ToInt32(DS.Tables[0].Rows[0]["expd_fkPackagingType"]);
                this.packagingTypeName = DS.Tables[0].Rows[0]["expd_packagingTypeName"].ToString();
                this.fkCurrency = Convert.ToInt32(DS.Tables[0].Rows[0]["expd_fkCurrency"]);
                this.currencyName = DS.Tables[0].Rows[0]["expd_currencyName"].ToString();
                this.exchangeRate = Convert.ToInt32(DS.Tables[0].Rows[0]["expd_exchangeRate"]);
                this.trafficification = DS.Tables[0].Rows[0]["expd_trafficClassification"].ToString();
                this.freight = Convert.ToInt32(DS.Tables[0].Rows[0]["expd_freight"]);
                this.insurance = Convert.ToInt32(DS.Tables[0].Rows[0]["expd_insurance"]);
                this.otherCharges = Convert.ToInt32(DS.Tables[0].Rows[0]["expd_otherCharges"]);
            }
            return objExportData;

        }
    }
}
