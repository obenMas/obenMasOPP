using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra los turnos de empleados
    /// </summary>
    public class clsInning
    {
        //Atributes

        private int inn_codsec;
        private string inn_name;
        private string inn_description;
        private DateTime inn_createdDate;
        private DateTime inn_modifiedDate;
        private int inn_createdBy;
        private string inn_creatorUser;
        private int inn_modifiedBy;
        private string inn_modificatorUser;


        //Properties

        public int codsec { get { return inn_codsec; } set { inn_codsec = value; } }

        public string name { get { return inn_name; } set { inn_name = value; } }

        public string description { get { return inn_description; } set { inn_description = value; } }

        public DateTime createdDate { get { return inn_createdDate; } set { inn_createdDate = value; } }

        public DateTime modifiedDate { get { return inn_modifiedDate; } set { inn_modifiedDate = value; } }

        public int createdBy { get { return inn_createdBy; } set { inn_createdBy = value; } }

        public string creatorUser { get { return inn_creatorUser; } set { inn_creatorUser = value; } }

        public int modifiedBy { get { return inn_modifiedBy; } set { inn_modifiedBy = value; } }

        public string modificatorUser { get { return inn_modificatorUser; } set { inn_modificatorUser = value; } }


        //Constructor

        public clsInning()
        { 
        inn_codsec = 0;
        inn_name = "";
        inn_description = "";
        inn_createdDate = DateTime.Now;
        inn_modifiedDate = DateTime.Now;
        inn_createdBy = 0;
        inn_creatorUser = "";
        inn_modifiedBy = 0;
        inn_modificatorUser = "";
        }

        public clsInning(int codsec)
        {
            this.load(codsec);
        }
        //Methods

        public void load(int codsec)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwInning where inn_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["inn_codsec"]);
            this.name = DS.Tables[0].Rows[0]["inn_name"].ToString();
            this.description = DS.Tables[0].Rows[0]["inn_description"].ToString();
            this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["inn_createdDate"]);
            this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["inn_modifiedDate"]);
            this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["inn_createdBy"]);
            this.creatorUser = DS.Tables[0].Rows[0]["inn_creatorUser"].ToString();
            this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["inn_modifiedBy"]);
            this.modificatorUser = DS.Tables[0].Rows[0]["inn_modificatorUser"].ToString();
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_admin_inning (inn_name, inn_description, inn_createdDate, inn_modifiedDate, inn_createdBy, inn_modifiedBy )";
                    queryString += " VALUES (";
                    queryString += "'" + this.name + "',";
                    queryString += "'" + this.description + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += clsGlobal.LoggedUser.codsec.ToString();
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_admin_inning";
                    queryString += " SET ";
                    queryString += "inn_name = '" + this.name + "',";
                    queryString += "inn_description = '" + this.description + "',";
                    queryString += "inn_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "inn_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString();
                    queryString += " WHERE inn_codsec = " + this.codsec.ToString() + ";";
                }
                clsConnection.executeQuery(queryString);
                return true;                
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsInning.save");
                return false;
            }

        }

        public static List<clsInning> getList()
        {
            List<clsInning> lstInning = new List<clsInning>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_inning order by inn_name asc");

            lstInning.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstInning.Add(new clsInning());
                lstInning[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["inn_codsec"]);
                lstInning[i].name = DS.Tables[0].Rows[i]["inn_name"].ToString();
                lstInning[i].description = DS.Tables[0].Rows[i]["inn_description"].ToString();
           //     lstInning[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["inn_createdDate"]);
          //      lstInning[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["inn_createdBy"]);
          //      lstInning[i].creatorUser = DS.Tables[0].Rows[i]["inn_creatorUser"].ToString();
           //     lstInning[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["inn_modifiedDate"]);
           //     lstInning[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["inn_modificatorUser"]);
           //     lstInning[i].modificatorUser = DS.Tables[0].Rows[i]["inn_modificatorUser"].ToString();

            }

            return lstInning;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
