using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que maneja los datos de direccion,telefono,fax de cliente / proveedor
    /// </summary>
    public class clsEntityAddress
    {
        //Atributes

        private int enttadd_codsec;
        private int enttadd_fkEntity;
        private string enttadd_EntityName;
        private int enttadd_fkCity;
        private string enttadd_name;
        private string enttadd_contact;
        private string enttadd_CityName;
        private string enttadd_address;
        private string enttadd_phone;
        private string enttadd_phone2;
        private string enttadd_fax;
        private string enttadd_email;
        private string enttadd_zip;
  
        //Properties

        public int codsec { get { return enttadd_codsec; } set { enttadd_codsec = value; } }

        public int fkEntity { get { return enttadd_fkEntity; } set { enttadd_fkEntity = value; } }

        public string EntityName { get { return enttadd_EntityName; } set { enttadd_EntityName = value; } }

        public int fkCity { get { return enttadd_fkCity; } set { enttadd_fkCity = value; } }

        public string CityName { get { return enttadd_CityName; } set { enttadd_CityName = value; } }

        public string name { get { return enttadd_name; } set { enttadd_name = value; } }

        public string contact { get { return enttadd_contact; } set { enttadd_contact = value; } }

        public string address { get { return enttadd_address; } set { enttadd_address = value; } }

        public string phone { get { return enttadd_phone; } set { enttadd_phone = value; } }

        public string phone2 { get { return enttadd_phone2; } set { enttadd_phone2 = value; } }

        public string fax { get { return enttadd_fax; } set { enttadd_fax = value; } }

        public string email { get { return enttadd_email; } set { enttadd_email = value; } }

        public string zip { get { return enttadd_zip; } set { enttadd_zip = value; } }


        //Constructor

        public clsEntityAddress()
        { 
            enttadd_codsec = 0;
            enttadd_fkEntity = 0;
            enttadd_EntityName = "";
            enttadd_fkCity = 0;
            enttadd_CityName = "";
            enttadd_name = "";
            enttadd_contact = "";
            enttadd_address = "";
            enttadd_phone = "";
            enttadd_phone2 = "";
            enttadd_fax = "";
            enttadd_email = "";
            enttadd_zip = "";
        }

        public clsEntityAddress(int codsec)
        {
            this.load(codsec);
        }

        public clsEntityAddress(int codsec,string data)
        {
            this.load(codsec);
        }

        //Methods
        public void load(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwentityadress where enttadd_codsec = " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["enttadd_codsec"]);
                this.fkEntity = Convert.ToInt32(DS.Tables[0].Rows[0]["enttadd_fkEntity"]);
                this.EntityName = DS.Tables[0].Rows[0]["enttadd_EntityName"].ToString();
                this.fkCity = Convert.ToInt32(DS.Tables[0].Rows[0]["enttadd_fkCity"]);
                this.CityName = DS.Tables[0].Rows[0]["enttadd_CityName"].ToString();
                this.name = DS.Tables[0].Rows[0]["enttadd_name"].ToString();
                this.contact = DS.Tables[0].Rows[0]["enttadd_contact"].ToString();
                this.address = DS.Tables[0].Rows[0]["enttadd_address"].ToString();
                this.phone = DS.Tables[0].Rows[0]["enttadd_phone"].ToString();
                this.phone2 = DS.Tables[0].Rows[0]["enttadd_phone2"].ToString();
                this.fax = DS.Tables[0].Rows[0]["enttadd_fax"].ToString();
                this.email = DS.Tables[0].Rows[0]["enttadd_email"].ToString();
                this.zip = DS.Tables[0].Rows[0]["enttadd_zip"].ToString(); 
            }

        }

        public void load(int codsec,string data)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwentityadress where enttadd_fkEntity = " + codsec.ToString());
            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["enttadd_codsec"]);
                this.fkEntity = Convert.ToInt32(DS.Tables[0].Rows[0]["enttadd_fkEntity"]);
                this.EntityName = DS.Tables[0].Rows[0]["enttadd_EntityName"].ToString();
                this.fkCity = Convert.ToInt32(DS.Tables[0].Rows[0]["enttadd_fkCity"]);
                this.CityName = DS.Tables[0].Rows[0]["enttadd_CityName"].ToString();
                this.name = DS.Tables[0].Rows[0]["enttadd_name"].ToString();
                this.contact = DS.Tables[0].Rows[0]["enttadd_contact"].ToString();
                this.address = DS.Tables[0].Rows[0]["enttadd_address"].ToString();
                this.phone = DS.Tables[0].Rows[0]["enttadd_phone"].ToString();
                this.phone2 = DS.Tables[0].Rows[0]["enttadd_phone2"].ToString();
                this.fax = DS.Tables[0].Rows[0]["enttadd_fax"].ToString();
                this.email = DS.Tables[0].Rows[0]["enttadd_email"].ToString();
                this.zip = DS.Tables[0].Rows[0]["enttadd_zip"].ToString();
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_admin_entityadress (enttadd_fkEntity, enttadd_fkCity, enttadd_name, enttadd_contact, enttadd_address, enttadd_phone, enttadd_phone2, enttadd_fax, enttadd_email, enttadd_zip)";
                    queryString += " VALUES (";
                    queryString += this.fkEntity.ToString() + ", ";
                    queryString += this.fkCity.ToString() + ", ";
                    queryString += "'" + this.name + "', ";
                    queryString += "'" + this.contact + "', ";
                    queryString += "'" + this.address + "', ";
                    queryString += "'" + this.phone + "', ";
                    queryString += "'" + this.phone2 + "', ";
                    queryString += "'" + this.fax + "', ";
                    queryString += "'" + this.email + "', ";
                    queryString += "'" + this.zip + "' ";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_admin_entityadress";
                    queryString += " SET ";
                    queryString += "enttadd_fkEntity = " + this.fkEntity.ToString() + ",";
                    queryString += "enttadd_fkCity = " + this.fkCity.ToString() + ",";
                    queryString += "enttadd_name = '" + this.name + "',";
                    queryString += "enttadd_contact = '" + this.contact + "',";
                    queryString += "enttadd_address = '" + this.address + "',";
                    queryString += "enttadd_phone = '" + this.phone + "',";
                    queryString += "enttadd_phone2 = '" + this.phone2 + "',";
                    queryString += "enttadd_fax = '" + this.fax + "',";
                    queryString += "enttadd_email = '" + this.email + "',";
                    queryString += "enttadd_zip = '" + this.zip + "'";
                    queryString += " WHERE enttadd_codsec = " + this.codsec.ToString();
                }
                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsEntityAddress.save");
                return false;
            }
        }

        public static List<clsEntityAddress> getListByEntity(int entityCodsec)
        {
            List<clsEntityAddress> lstEntityAdress = new List<clsEntityAddress>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwentityadress WHERE enttadd_fkEntity = " + entityCodsec.ToString());

            lstEntityAdress.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstEntityAdress.Add(new clsEntityAddress());
                lstEntityAdress[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["enttadd_codsec"]);
                lstEntityAdress[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["enttadd_fkEntity"]);
                lstEntityAdress[i].EntityName = DS.Tables[0].Rows[i]["enttadd_EntityName"].ToString();
                lstEntityAdress[i].fkCity = Convert.ToInt32(DS.Tables[0].Rows[i]["enttadd_fkCity"]);
                lstEntityAdress[i].CityName = DS.Tables[0].Rows[i]["enttadd_CityName"].ToString();
                lstEntityAdress[i].name = DS.Tables[0].Rows[i]["enttadd_name"].ToString();
                lstEntityAdress[i].contact = DS.Tables[0].Rows[i]["enttadd_contact"].ToString();
                lstEntityAdress[i].address = DS.Tables[0].Rows[i]["enttadd_address"].ToString();
                lstEntityAdress[i].phone = DS.Tables[0].Rows[i]["enttadd_phone"].ToString();
                lstEntityAdress[i].phone2 = DS.Tables[0].Rows[i]["enttadd_phone2"].ToString();
                lstEntityAdress[i].fax = DS.Tables[0].Rows[i]["enttadd_fax"].ToString();
                lstEntityAdress[i].email = DS.Tables[0].Rows[i]["enttadd_email"].ToString();
                lstEntityAdress[i].zip = DS.Tables[0].Rows[i]["enttadd_zip"].ToString();
            }
            return lstEntityAdress;
        }

    }
}
