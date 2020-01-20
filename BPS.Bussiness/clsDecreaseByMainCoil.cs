using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;


namespace BPS.Bussiness
{
    /// <summary>
    /// Clase para control de desperdicios por Rollo Madre
    /// </summary>
    public class clsDecreaseByMainCoil
    {
        //Attibutes
        private int dcrmcl_codsec;
        private int dcrmcl_fkDecrease;
        private string dcrmcl_decreaseName;
        private int dcrmcl_fkMainCoil;
        private string dcrmcl_mainCoilCode;
        private double dcrmcl_weigth;

        //Properties
        public int codsec { get { return dcrmcl_codsec; } set { dcrmcl_codsec = value; } }

        public int fkDecrease { get { return dcrmcl_fkDecrease; } set { dcrmcl_fkDecrease = value; } }

        public string decreaseName{get{return dcrmcl_decreaseName;}set{dcrmcl_decreaseName = value;}}

        public int fkMainCoil { get { return dcrmcl_fkMainCoil; } set { dcrmcl_fkMainCoil = value; } }

        public string mainCoilCode{get{return dcrmcl_mainCoilCode;}set{dcrmcl_mainCoilCode = value;}}

        public double weigth { get { return dcrmcl_weigth; } set { dcrmcl_weigth = value; } }


        //Constructor
        public clsDecreaseByMainCoil()
        {
            dcrmcl_codsec = 0;
            dcrmcl_fkDecrease = 0;
            dcrmcl_fkMainCoil = 0;
            dcrmcl_weigth = 0;
        }

        //Methods

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_decreasebymaincoil (dcrmcl_fkDecrease, dcrmcl_fkMainCoil, dcrmcl_weigth)";
                    queryString += " VALUES (";
                    queryString += "" + this.fkDecrease + ",";
                    queryString += "" + this.fkMainCoil + ",";
                    queryString += "" + this.weigth + "";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_decreasebymaincoil";
                    queryString += " SET ";
                    queryString += "dcrmcl_fkDecrease = " + this.fkDecrease + ",";
                    queryString += "dcrmcl_fkMainCoil = " + this.fkMainCoil + ",";
                    queryString += "dcrmcl_weigth = " + this.weigth + "";
                    queryString += " WHERE dcrmcl_codsec = " + this.codsec + ";";
                }
                clsConnection.executeQuery(queryString);
                return true;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsDecreaseByMainCoil.save");
                return false;
            }
        }

        public static List<clsDecreaseByMainCoil> getListByMainCoil(int mainCoilCodsec)
        {
            List<clsDecreaseByMainCoil> lstDecreaseByMainCoil = new List<clsDecreaseByMainCoil>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwdecreasebymaincoil WHERE dcrmcl_fkMainCoil = " + mainCoilCodsec.ToString());

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstDecreaseByMainCoil.Add(new clsDecreaseByMainCoil());
                    lstDecreaseByMainCoil[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["dcrmcl_codsec"]);
                    lstDecreaseByMainCoil[i].fkDecrease = Convert.ToInt32(DS.Tables[0].Rows[i]["dcrmcl_fkDecrease"]);
                    lstDecreaseByMainCoil[i].decreaseName = DS.Tables[0].Rows[i]["dcrmcl_decreaseName"].ToString();
                    lstDecreaseByMainCoil[i].fkMainCoil = Convert.ToInt32(DS.Tables[0].Rows[i]["dcrmcl_fkMainCoil"]);
                    lstDecreaseByMainCoil[i].mainCoilCode = DS.Tables[0].Rows[i]["dcrmcl_codsec"].ToString();
                    lstDecreaseByMainCoil[i].weigth = Convert.ToDouble(DS.Tables[0].Rows[i]["dcrmcl_weigth"]);
                }
            }

            return lstDecreaseByMainCoil;
        }

    }
}
