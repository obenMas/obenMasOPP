using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;


namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra las formulaciones de termoformado
    /// </summary>
    public class clsThermFormulation
    {

        //Atributes

        private int thermfrm_codsec;
        private int thermfrm_numberofstops;
        private DateTime thermfrm_createdDate;
        private DateTime thermfrm_modifiedDate;
        private int thermfrm_createdBy;
        private string therm_creatorUser;
        private int thermfrm_modifiedBy;
        private string thermfrm_modificatorUser;

        //Properties

        public int codsec { get { return thermfrm_codsec; } set { thermfrm_codsec = value; } }

        public int numberofstops { get { return thermfrm_numberofstops; } set { thermfrm_numberofstops = value; } }

        public DateTime createdDate { get { return thermfrm_createdDate; } set { thermfrm_createdDate = value; } }

        public DateTime modifiedDate { get { return thermfrm_modifiedDate; } set { thermfrm_modifiedDate = value; } }

        public int createdBy { get { return thermfrm_createdBy; } set { thermfrm_createdBy = value; } }

        public string creatorUser { get { return therm_creatorUser; } set { therm_creatorUser = value; } }

        public int modifiedBy { get { return thermfrm_modifiedBy; } set { thermfrm_modifiedBy = value; } }

        public string modificatorUser { get { return thermfrm_modificatorUser; } set { thermfrm_modificatorUser = value; } }

         //Constructor

        public clsThermFormulation()
        {
            thermfrm_codsec = 0;
            thermfrm_numberofstops = 0;
            thermfrm_createdDate = DateTime.Now;
            thermfrm_modifiedDate = DateTime.Now;
            thermfrm_createdBy = 0;
            therm_creatorUser = "";
            thermfrm_modifiedBy = 0;
            thermfrm_modificatorUser = "";
        }

        public clsThermFormulation(int codsec)
        {
            this.load(codsec);
        }
        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_thermformulation where thermfrm_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["thermfrm_codsec"]);
            this.numberofstops = Convert.ToInt32(DS.Tables[0].Rows[0]["thermfrm_numberofstops"]);
            this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["thermfrm_createdDate"]);
            this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["thermfrm_modifiedDate"]);
            this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["thermfrm_createdBy"]);
            this.creatorUser = DS.Tables[0].Rows[0]["therm_creatorUser"].ToString();
            this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["thermfrm_modifiedBy"]);
            this.modificatorUser = DS.Tables[0].Rows[0]["thermfrm_modificatorUser"].ToString();

        }

         public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO c (thermfrm_numberofstops, thermfrm_createdDate, thermfrm_modifiedDate, thermfrm_createdBy, thermfrm_modifiedBy)";
                    queryString += " VALUES (";
                    queryString += "'" + this.numberofstops + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += clsGlobal.LoggedUser.codsec.ToString();
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_thermformulation";
                    queryString += " SET ";
                    queryString += "thermfrm_numberofstops = " + this.numberofstops + ",";
                    queryString += "thermfrm_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "thermfrm_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString();
                    queryString += " WHERE thermfrm_codsec = " + this.codsec.ToString() + ";";
                }
                clsConnection.executeQuery(queryString);
                return true;                
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsThermFormulation.save");
                return false;
            }

        }

         public static List<clsThermFormulation> getList()
         {
             List<clsThermFormulation> lstThermFormulation = new List<clsThermFormulation>();
             DataSet DS = new DataSet();

             DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_thermformulation order by thermfrm_codsec asc");

             lstThermFormulation.Clear();

             for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
             {
                 lstThermFormulation.Add(new clsThermFormulation());
                 lstThermFormulation[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["thermfrm_codsec"]);
                 lstThermFormulation[i].numberofstops = Convert.ToInt32(DS.Tables[0].Rows[i]["thermfrm_numberofstops"]);
                 lstThermFormulation[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["thermfrm_createdDate"]);
                 lstThermFormulation[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["thermfrm_createdBy"]);
                 lstThermFormulation[i].creatorUser = DS.Tables[0].Rows[i]["therm_creatorUser"].ToString();
                 lstThermFormulation[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["thermfrm_modifiedDate"]);
                 lstThermFormulation[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["thermfrm_modifiedBy"]);
                 lstThermFormulation[i].modificatorUser = DS.Tables[0].Rows[i]["thermfrm_modificatorUser"].ToString();

             }

             return lstThermFormulation;
         }

    }
}
