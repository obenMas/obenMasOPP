using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que calcula el stock de materias primas enviadas al deposito de produccion por maquina
    /// </summary>
    public class clsRawMaterialStockProduction
    {
         //Atributes

        private int rmstp_fkRawMaterialType;
        private string rmstp_rawMaterialTypeName;
        private int rmstp_fkRawMaterial;
        private string rmstp_rawMaterialCode;
        private string rmstp_rawMaterialName;
        private double rmstp_transferredTotal;
        private double rmstp_consumedTotal;
        private double rmstp_stock;


        //Properties

        public int fkRawMaterialType { get { return rmstp_fkRawMaterialType; } set { rmstp_fkRawMaterialType = value; } }

        public string rawMaterialTypeName { get { return rmstp_rawMaterialTypeName; } set { rmstp_rawMaterialTypeName = value; } }

        public int fkRawMaterial { get { return rmstp_fkRawMaterial; } set { rmstp_fkRawMaterial = value; } }

        public string rawMaterialCode { get { return rmstp_rawMaterialCode; } set { rmstp_rawMaterialCode = value; } }

        public string rawMaterialName { get { return rmstp_rawMaterialName; } set { rmstp_rawMaterialName = value; } }

        public double transferredTotal { get { return rmstp_transferredTotal; } set { rmstp_transferredTotal = value; } }

        public double consumedTotal { get { return rmstp_consumedTotal; } set { rmstp_consumedTotal = value; } }

        public double stock { get { return rmstp_stock; } set { rmstp_stock = value; } }

  
        //Constructor

        public clsRawMaterialStockProduction()
        {

            rmstp_fkRawMaterialType = 0;
            rmstp_rawMaterialTypeName = "";
            rmstp_fkRawMaterial = 0;
            rmstp_rawMaterialCode = "";
            rmstp_rawMaterialName = "";
            rmstp_transferredTotal = 0;
            rmstp_consumedTotal = 0;
            rmstp_stock = 0;
            
        }

        public static List<clsRawMaterialStockProduction> getListByExtruder(int extruderCodsec)
        {
            List<clsRawMaterialStockProduction> lstRawMaterialStockProduction = new List<clsRawMaterialStockProduction>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spStockRawMaterialProductionCellar('" + extruderCodsec + "')");

            lstRawMaterialStockProduction.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstRawMaterialStockProduction.Add(new clsRawMaterialStockProduction());
                lstRawMaterialStockProduction[i].fkRawMaterialType = Convert.ToInt32(DS.Tables[0].Rows[i]["rmstp_fkRawMaterialType"]);
                lstRawMaterialStockProduction[i].rawMaterialTypeName = DS.Tables[0].Rows[i]["rmstp_rawMaterialTypeName"].ToString();
                lstRawMaterialStockProduction[i].fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[i]["rmstp_fkRawMaterial"]);
                lstRawMaterialStockProduction[i].rawMaterialCode = DS.Tables[0].Rows[i]["rmstp_rawMaterialCode"].ToString();
                lstRawMaterialStockProduction[i].rawMaterialName = DS.Tables[0].Rows[i]["rmstp_rawMaterialName"].ToString();
                lstRawMaterialStockProduction[i].transferredTotal = Convert.ToDouble(DS.Tables[0].Rows[i]["rmstp_transferredTotal"]);
                lstRawMaterialStockProduction[i].consumedTotal = Convert.ToDouble(DS.Tables[0].Rows[i]["rmstp_consumedTotal"]);
                lstRawMaterialStockProduction[i].stock = Convert.ToDouble(DS.Tables[0].Rows[i]["rmstp_stock"]);
                
            }

            return lstRawMaterialStockProduction;
        }


        public static List<clsRawMaterialStockProduction> getListByExtruderAndRawMaterial(int extruderCodsec, int rawMaterialCodsec)
        {
            List<clsRawMaterialStockProduction> lstRawMaterialStockProduction = new List<clsRawMaterialStockProduction>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spStockRawMaterialProductionCellarByExtruderByRawMaterial(" + "'" + extruderCodsec.ToString() + "', " + "'" + rawMaterialCodsec.ToString() + "');");

       //     lstRawMaterialStockProduction.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstRawMaterialStockProduction.Add(new clsRawMaterialStockProduction());
                lstRawMaterialStockProduction[i].fkRawMaterialType = Convert.ToInt32(DS.Tables[0].Rows[i]["rmstp_fkRawMaterialType"]);
                lstRawMaterialStockProduction[i].rawMaterialTypeName = DS.Tables[0].Rows[i]["rmstp_rawMaterialTypeName"].ToString();
                lstRawMaterialStockProduction[i].fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[i]["rmstp_fkRawMaterial"]);
                lstRawMaterialStockProduction[i].rawMaterialCode = DS.Tables[0].Rows[i]["rmstp_rawMaterialCode"].ToString();
                lstRawMaterialStockProduction[i].rawMaterialName = DS.Tables[0].Rows[i]["rmstp_rawMaterialName"].ToString();
                lstRawMaterialStockProduction[i].transferredTotal = Convert.ToDouble(DS.Tables[0].Rows[i]["rmstp_transferredTotal"]);
                lstRawMaterialStockProduction[i].consumedTotal = Convert.ToDouble(DS.Tables[0].Rows[i]["rmstp_consumedTotal"]);
                lstRawMaterialStockProduction[i].stock = Convert.ToDouble(DS.Tables[0].Rows[i]["rmstp_stock"]);
                
            }

            return lstRawMaterialStockProduction;
        }

       

    }
}
