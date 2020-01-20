using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra la clase de contenedores
    /// </summary>
    public class clsTransport
    {
        //Atributes

        private int trans_codsec;
        private string trans_name;
        private double trans_usefulWidth;
        private double trans_usefulHigh;
        private double trans_usefulLong;
        private double trans_GrossCapacity;


        //Properties


        public int codsec { get { return trans_codsec; } set { trans_codsec = value; } }

        public string name { get { return trans_name; } set { trans_name = value; } }

        public double usefulWidth { get { return trans_usefulWidth; } set { trans_usefulWidth = value; } }

        public double usefulHigh { get { return trans_usefulHigh; } set { trans_usefulHigh = value; } }

        public double usefulLong { get { return trans_usefulLong; } set { trans_usefulLong = value; } }

        public double GrossCapacity { get { return trans_GrossCapacity; } set { trans_GrossCapacity = value; } }

         //Constructor

        public clsTransport()
        { 
        trans_codsec = 0;
        trans_name = "";
        trans_usefulWidth = 0;
        trans_usefulHigh = 0;
        trans_usefulLong = 0;
        trans_GrossCapacity = 0;
        }

        public clsTransport(int codsec)
        {
            this.load(codsec);
        }

        //Methods
        public void load(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_transport where trans_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["trans_codsec"]);
            this.name = DS.Tables[0].Rows[0]["trans_name"].ToString();
            this.usefulWidth = Convert.ToDouble(DS.Tables[0].Rows[0]["trans_usefulWidth"]);
            this.usefulHigh = Convert.ToDouble(DS.Tables[0].Rows[0]["trans_usefulHigh"]);
            this.usefulLong = Convert.ToDouble(DS.Tables[0].Rows[0]["trans_usefulLong"]);
            this.GrossCapacity = Convert.ToDouble(DS.Tables[0].Rows[0]["trans_GrossCapacity"]);
        }

        public bool save()
        {
            try
            {

                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_admin_transport (trans_name, trans_usefulWidth, trans_usefulHigh,trans_usefulLong,trans_GrossCapacity) ";
                    queryString += "VALUES (";
                    queryString += "'" + this.name + "',";
                    queryString += "" + this.usefulWidth.ToString()+ ",";
                    queryString += "" + this.usefulHigh.ToString() + ",";
                    queryString += "" + this.usefulLong.ToString() + ",";
                    queryString += "" + this.GrossCapacity.ToString() + "";
                    queryString += ");";

                }
                else
                {
                    queryString += "UPDATE bps_admin_transport";
                    queryString += " SET ";
                    queryString += "trans_name = '" + this.name + "',";
                    queryString += "trans_usefulWidth = " + this.usefulWidth.ToString() + ",";
                    queryString += "trans_usefulHigh = " + this.usefulHigh.ToString() + ",";
                    queryString += "trans_usefulLong = " + this.usefulLong.ToString() + ",";
                    queryString += "trans_GrossCapacity = " + this.GrossCapacity.ToString() + "";
                    queryString += " WHERE trans_codsec = " + this.codsec.ToString() + ";";

                }
                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsTransport.save");
                return false;
            }
        }
        
        public static List<clsTransport> getList()
        {
            List<clsTransport> lstTransport = new List<clsTransport>();

            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_transport ORDER BY trans_name");

            lstTransport.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstTransport.Add(new clsTransport());
                lstTransport[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["trans_codsec"]);
                lstTransport[i].name = DS.Tables[0].Rows[i]["trans_name"].ToString();
                lstTransport[i].usefulWidth = Convert.ToDouble(DS.Tables[0].Rows[i]["trans_usefulWidth"]);
                lstTransport[i].usefulHigh = Convert.ToDouble(DS.Tables[0].Rows[i]["trans_usefulHigh"]);
                lstTransport[i].usefulLong = Convert.ToDouble(DS.Tables[0].Rows[i]["trans_usefulLong"]);
                lstTransport[i].GrossCapacity = Convert.ToDouble(DS.Tables[0].Rows[i]["trans_GrossCapacity"]);
            }

            return lstTransport;
        }

        public static List<clsTransport> getListIsVisible()
        {
            List<clsTransport> lstTransport = new List<clsTransport>();

            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_transport WHERE trans_isVisible = 1 ORDER BY trans_name");

            lstTransport.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstTransport.Add(new clsTransport());
                lstTransport[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["trans_codsec"]);
                lstTransport[i].name = DS.Tables[0].Rows[i]["trans_name"].ToString();
                lstTransport[i].usefulWidth = Convert.ToDouble(DS.Tables[0].Rows[i]["trans_usefulWidth"]);
                lstTransport[i].usefulHigh = Convert.ToDouble(DS.Tables[0].Rows[i]["trans_usefulHigh"]);
                lstTransport[i].usefulLong = Convert.ToDouble(DS.Tables[0].Rows[i]["trans_usefulLong"]);
                lstTransport[i].GrossCapacity = Convert.ToDouble(DS.Tables[0].Rows[i]["trans_GrossCapacity"]);
            }

            return lstTransport;
        }

        public override string ToString()
        {
            return this.name;
        }

        public static bool toCrossTransport(int codsecTransport)
        {
            try
            {

                string queryString = "";

                queryString += "UPDATE bps_admin_transport";
                queryString += " SET ";
                queryString += "trans_isVisible = 0";
                queryString += " WHERE trans_codsec = " + codsecTransport.ToString() + ";";

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsTransport.save");
                return false;
            }
        }

        internal static List<clsTransport> getListByCodsec(int codsec)
        {
            DataSet DS = new DataSet();
            List<clsTransport> lstTransport = new List<clsTransport>();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_transport WHERE trans_codsec = " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstTransport.Add(new clsTransport());
                    lstTransport[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["trans_codsec"]);
                    lstTransport[i].name = DS.Tables[0].Rows[i]["trans_name"].ToString();
                    lstTransport[i].usefulWidth = Convert.ToDouble(DS.Tables[0].Rows[i]["trans_usefulWidth"]);
                    lstTransport[i].usefulHigh = Convert.ToDouble(DS.Tables[0].Rows[i]["trans_usefulHigh"]);
                    lstTransport[i].usefulLong = Convert.ToDouble(DS.Tables[0].Rows[i]["trans_usefulLong"]);
                    lstTransport[i].GrossCapacity = Convert.ToDouble(DS.Tables[0].Rows[i]["trans_GrossCapacity"]);  
                }
            }
            return lstTransport;
        }
    }
}
