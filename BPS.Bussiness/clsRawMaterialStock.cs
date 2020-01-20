using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;


namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que calcula el stock de materias primas
    /// </summary>
    public class clsRawMaterialStock
    {

         //Atributes
 
        private int rmst_fkRawMaterialType;
        private string rmst_RawMaterialTypeName;
        private double rmst_Stock;


        //Properties

        public int fkRawMaterialType { get { return rmst_fkRawMaterialType; } set { rmst_fkRawMaterialType = value; } }

        public string RawMaterialTypeName { get { return rmst_RawMaterialTypeName; } set { rmst_RawMaterialTypeName = value; } }

        public double Stock { get { return rmst_Stock; } set { rmst_Stock = value; } }

  
        //Constructor

        public clsRawMaterialStock()
        {
            fkRawMaterialType = 0;
            Stock = 0;
            RawMaterialTypeName = "";
        
   
        }

        public static List<clsRawMaterialStock> getList()
        {
            List<clsRawMaterialStock> lstRawMaterialStock = new List<clsRawMaterialStock>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwRawMaterialStock");

            lstRawMaterialStock.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstRawMaterialStock.Add(new clsRawMaterialStock());
                lstRawMaterialStock[i].fkRawMaterialType = Convert.ToInt32(DS.Tables[0].Rows[i]["rmst_fkRawMaterialType"]);
                lstRawMaterialStock[i].RawMaterialTypeName = DS.Tables[0].Rows[i]["rmst_RawMaterialTypeName"].ToString();
                lstRawMaterialStock[i].Stock = Convert.ToDouble(DS.Tables[0].Rows[i]["rmst_Stock"]);
                
            }

            return lstRawMaterialStock;
        }
    }
}
