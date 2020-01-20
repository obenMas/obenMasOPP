using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase donde se administra los tipos de productos
    /// </summary>
    public class clsProductType
    {

        //Atributes

        private int ptype_codsec;
        private string ptype_name;
        private string ptype_description;
        private DateTime ptype_createdDate;
        private DateTime ptype_modifiedDate;
        private int ptype_createdBy;
        private string ptype_creatorUser;
        private int ptype_modifiedBy;
        private string ptype_modificatorUser;

        //Properties

        public int codsec { get { return ptype_codsec; } set { ptype_codsec = value; } }

        public string name { get { return ptype_name; } set { ptype_name = value; } }

        public string description { get { return ptype_description; } set { ptype_description = value; } }

        public DateTime createdDate { get { return ptype_createdDate; } set { ptype_createdDate = value; } }

        public DateTime modifiedDate { get { return ptype_modifiedDate; } set { ptype_modifiedDate = value; } }

        public int createdBy { get { return ptype_createdBy; } set { ptype_createdBy = value; } }
        
        public string creatorUser { get { return ptype_creatorUser; } set { ptype_creatorUser = value; } }

        public int modifiedBy { get { return ptype_modifiedBy; } set { ptype_modifiedBy = value; } }
        
        public string modificatorUser { get { return ptype_modificatorUser; } set { ptype_modificatorUser = value; } }


        //Constructor

        public clsProductType()
        { 
        ptype_codsec = 0;
        ptype_name = "";
        ptype_description = "";
        ptype_createdDate = DateTime.Now;
        ptype_modifiedDate = DateTime.Now;
        ptype_createdBy = 0;
        ptype_creatorUser = "";
        ptype_modifiedBy = 0;
        ptype_modificatorUser = "";
        }

        public clsProductType(int codsec)
        {
            this.load(codsec);
        }
        //Methods

        public void load(int codsec)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwProductType where ptype_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["ptype_codsec"]);
            this.name = DS.Tables[0].Rows[0]["ptype_name"].ToString();
            this.description = DS.Tables[0].Rows[0]["ptype_description"].ToString();
            this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["ptype_createdDate"]);
            this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["ptype_modifiedDate"]);
            this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["ptype_createdBy"]);
            this.creatorUser = DS.Tables[0].Rows[0]["ptype_creatorUser"].ToString();
            this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["ptype_modifiedBy"]);
            this.modificatorUser = DS.Tables[0].Rows[0]["ptype_modificatorUser"].ToString();


        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_productType (ptype_name,ptype_description,ptype_createdDate, ptype_modifiedDate,ptype_createdBy,ptype_modifiedBy)";
                    queryString += " VALUES (";
                    queryString += "'" + this.name + "',";
                    queryString += "'" + this.description + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += clsGlobal.LoggedUser.codsec.ToString();
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_prod_productType";
                    queryString += " SET ";
                    queryString += "ptype_name = '" + this.name + "',";
                    queryString += "ptype_description = '" + this.description + "',";
                    queryString += "ptype_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "ptype_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString();
                    queryString += " WHERE ptype_codsec = " + this.codsec.ToString() + ";";
                    clsConnection.executeQuery(queryString);
                }
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsProductType.save");
                return false;
            }
        }

        public static List<clsProductType> getList()
        {
            List<clsProductType> lstProductType = new List<clsProductType>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwProductType order by ptype_name asc");

            lstProductType.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstProductType.Add(new clsProductType());
                lstProductType[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["ptype_codsec"]);
                lstProductType[i].name = DS.Tables[0].Rows[i]["ptype_name"].ToString();
                lstProductType[i].description = DS.Tables[0].Rows[i]["ptype_description"].ToString();
                lstProductType[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["ptype_createdDate"]);
                lstProductType[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["ptype_modifiedDate"]);
                lstProductType[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["ptype_createdDate"]);
                lstProductType[i].creatorUser = DS.Tables[0].Rows[i]["ptype_creatorUser"].ToString();
                lstProductType[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["ptype_modifiedBy"]);
                lstProductType[i].modificatorUser = DS.Tables[0].Rows[i]["ptype_modificatorUser"].ToString();

            }

            return lstProductType;
        }

    }
}
