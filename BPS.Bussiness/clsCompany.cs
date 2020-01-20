using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;


namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que maneja los datos de la empresa.
    /// </summary>
    public class clsCompany
    {
        //Atribiutes

        private int cmp_codsec;
        private int cmp_fkCountry;
        private string cmp_countryName;
        private int cmp_fkCurrency;
        private string cmp_currencyName;
        private string cmp_name;
        private string cmp_description;
        private string cmp_type;
        private DateTime cmp_createdDate;
        private DateTime cmp_modifiedDate;
        private int cmp_createdBy;
        private string cmp_creatorUser;
        private int cmp_modifiedBy;
        private string cmp_modificatorUser;

        
        //Properties

        public int codsec { get { return cmp_codsec; } set { cmp_codsec = value; } }

        public int fkCountry { get { return cmp_fkCountry; } set { cmp_fkCountry = value; } }

        public string countryName { get { return cmp_countryName; } set { cmp_countryName = value; } }

        public int fkCurrency { get { return cmp_fkCurrency; } set { cmp_fkCurrency = value; } }

        public string currencyName { get { return cmp_currencyName; } set { cmp_currencyName = value; } }

        public string name { get { return cmp_name; } set { cmp_name = value; } }

        public string description { get { return cmp_description; } set { cmp_description = value; } }

        public string type { get { return cmp_type; } set { cmp_type = value; } }

        public DateTime createdDate { get { return cmp_createdDate; } set { cmp_createdDate = value; } }

        public DateTime modifiedDate { get { return cmp_modifiedDate; } set { cmp_modifiedDate = value; } }

        public int createdBy { get { return cmp_createdBy; } set { cmp_createdBy = value; } }

        public string creatorUser { get { return cmp_creatorUser; } set { cmp_creatorUser = value; } }

        public int modifiedBy { get { return cmp_modifiedBy; } set { cmp_modifiedBy = value; } }

        public string modificatorUser { get { return cmp_modificatorUser; } set { cmp_modificatorUser = value; } }

        
        //Constructor

        public clsCompany()
        { 
        cmp_codsec = 0;
        cmp_fkCountry = 0;
        cmp_countryName = "";
        cmp_fkCurrency = 0;
        cmp_currencyName = "";
        cmp_name = "";
        cmp_description = "";
        cmp_type = "";
        cmp_createdDate = DateTime.Now;
        cmp_modifiedDate = DateTime.Now;
        cmp_createdBy = 0;
        cmp_creatorUser = "";
        cmp_modifiedBy = 0;
        cmp_modificatorUser = "";     
        }

        public clsCompany(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("select * from vwCompany where cmp_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cmp_codsec"]);
            this.fkCountry = Convert.ToInt32(DS.Tables[0].Rows[0]["cmp_fkCountry"]);
            this.countryName = DS.Tables[0].Rows[0]["cmp_countryName"].ToString();
            this.fkCurrency = Convert.ToInt32(DS.Tables[0].Rows[0]["cmp_fkCurrency"]);
            this.currencyName = DS.Tables[0].Rows[0]["cmp_currencyName"].ToString();
            this.name = DS.Tables[0].Rows[0]["cmp_name"].ToString();
            this.description = DS.Tables[0].Rows[0]["cmp_description"].ToString();
            this.type = DS.Tables[0].Rows[0]["cmp_type"].ToString();
            this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["cmp_createdDate"]);
            this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["cmp_createdBy"]);
            this.creatorUser = DS.Tables[0].Rows[0]["cmp_creatorUser"].ToString();
            this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["cmp_modifiedDate"]);
            this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["cmp_modifiedBy"]);
            this.modificatorUser = DS.Tables[0].Rows[0]["cmp_modificatorUser"].ToString();
        }

        public bool save()
        {
            try
            {
            string queryString = "";

            if (this.codsec == 0)
            {
                queryString += "INSERT INTO bps_admin_company (cmp_fkCountry, cmp_fkCurrency,cmp_name, cmp_descriprion, cmp_type, cmp_createdDate, cmp_modifiedDate, cmp_createdBy, cmp_modifiedBy )";
                queryString += " VALUES (";
                queryString += this.fkCountry.ToString() + ",";
                queryString += this.fkCurrency.ToString() +  ",";
                queryString += "'" + this.name + "',";
                queryString += "'" + this.description + "',";
                queryString += "'" + this.type + "',";
                queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                queryString += clsGlobal.LoggedUser.codsec.ToString() + ",";
                queryString += clsGlobal.LoggedUser.codsec.ToString();
                queryString += ");";
            }
            else
            {
                queryString += "UPDATE bps_admin_company";
                queryString += " SET ";
                queryString += "cmp_fkCountry = " + this.fkCountry.ToString() + ",";
                queryString += "cmp_fkCurrency = " + this.fkCurrency.ToString() + ",";
                queryString += "cmp_name = '" + this.name + "',";
                queryString += "cmp_description = '" + this.description + "',";
                queryString += "cmp_type = '" + this.type + "',";
                queryString += "cmp_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                queryString += "cmp_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString();
                queryString += " WHERE cmp_codsec = " + this.codsec.ToString() + ";";
            }
            clsConnection.executeQuery(queryString);
            return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCompany.save");
                return false;
            }

            
        }

        public static List<clsCompany> getList()
        {
            List<clsCompany> lstCompany = new List<clsCompany>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_company order by cmp_name asc");

            lstCompany.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstCompany.Add(new clsCompany());
                lstCompany[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cmp_codsec"]);
                lstCompany[i].fkCountry = Convert.ToInt32(DS.Tables[0].Rows[i]["cmp_fkCountry"]);
                lstCompany[i].countryName = DS.Tables[0].Rows[i]["cmp_countryName"].ToString();
                lstCompany[i].cmp_fkCurrency = Convert.ToInt32(DS.Tables[0].Rows[i]["cmp_fkCurrency"]);
                lstCompany[i].currencyName = DS.Tables[0].Rows[i]["cmp_currencyName"].ToString();
                lstCompany[i].name = DS.Tables[0].Rows[i]["cmp_name"].ToString();
                lstCompany[i].description = DS.Tables[0].Rows[i]["cmp_description"].ToString();
                lstCompany[i].type = DS.Tables[0].Rows[i]["cmp_type"].ToString();
                lstCompany[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["cmp_createdDate"]);
                lstCompany[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cmp_createdBy"]);
                lstCompany[i].creatorUser = DS.Tables[0].Rows[i]["cmp_creatorUser"].ToString();
                lstCompany[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["cmp_modifiedDate"]);
                lstCompany[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cmp_modifiedBy"]);
                lstCompany[i].modificatorUser = DS.Tables[0].Rows[i]["cmp_modificatorUser"].ToString();


            }
           
            return lstCompany;
        }
    }
}
