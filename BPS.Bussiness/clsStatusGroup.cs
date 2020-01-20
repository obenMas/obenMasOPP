using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que maneja los grupos en que pertenecen los diferentes estados
    /// </summary>
    public class clsStatusGroup
    {
        //Atributes

        private int stgp_codsec;
        private string stgp_name;
        
        //Properties

        public int codsec{get{return stgp_codsec;}set{stgp_codsec = value;}}

        public string name{get{return stgp_name;}set{stgp_name = value;}}


        //Constructor

        public clsStatusGroup()
        {
            stgp_codsec = 0;
            stgp_name = "";
      
        }
        public clsStatusGroup(int codsec)
        {
            this.load(codsec);
        }
        //Methods
        
        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_statusgroup where stgp_codsec =  " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["stgp_codsec"]);
            this.name = DS.Tables[0].Rows[0]["stgp_name"].ToString();
            
        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_admin_statusgroup (stgp_name)";
                    queryString += " VALUES (";
                    queryString += "'" + this.name + "'";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_admin_statusgroup";
                    queryString += " SET ";
                    queryString += "stgp_name = '" + this.name + "'";
                    queryString += " WHERE stgp_codsec = " + this.codsec.ToString() + ";";
                    clsConnection.executeQuery(queryString);
                }
                return true;
            }

            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsStatusGroup.save");
                return false;                
            }
        }
        public static List<clsStatusGroup> getList()
        {
            List<clsStatusGroup> lstStatusGroup = new List<clsStatusGroup>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_statusgroup order by stgp_name asc");

            lstStatusGroup.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstStatusGroup.Add(new clsStatusGroup());
                lstStatusGroup[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["stgp_codsec"]);
                lstStatusGroup[i].name = DS.Tables[0].Rows[i]["stgp_name"].ToString();


            }

            return lstStatusGroup;
        }
        public override string ToString()
        {
            return this.name;
        }
    }
}
