using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    public class clsCompanyAddress
    {
        //Atributes

          private int cmpadd_codsec;
          private int cmpadd_fkCompany;
          private int cmpadd_fkCity;
          private string cmpadd_cityName;
          private string cmpadd_contactName;
          private string cmpadd_address;
          private string cmpadd_phone;
          private string cmpadd_phone2;
          private string cmpadd_fax;
          private string cmpadd_email;
          private string cmpadd_zip;


        //Properties

          public int codsec { get { return cmpadd_codsec; } set { cmpadd_codsec = value; } }

          public int fkCompany { get { return cmpadd_fkCompany; } set { cmpadd_fkCompany = value; } }

          public int fkCity { get { return cmpadd_fkCity; } set { cmpadd_fkCity = value; } }

          public string cityName { get { return cmpadd_cityName; } set { cmpadd_cityName = value; } }

          public string contactName { get { return cmpadd_contactName; } set { cmpadd_contactName = value; } }

          public string address { get { return cmpadd_address; } set { cmpadd_address = value; } }

          public string phone { get { return cmpadd_phone; } set { cmpadd_phone = value; } }

          public string phone2 { get { return cmpadd_phone2; } set { cmpadd_phone2 = value; } }

          public string fax { get { return cmpadd_fax; } set { cmpadd_fax = value; } }

          public string email { get { return cmpadd_email; } set { cmpadd_email = value; } }

          public string zip { get { return cmpadd_zip; } set { cmpadd_zip = value; } }



        //Constructor

        public clsCompanyAddress()
        { 
          cmpadd_codsec = 0;
          cmpadd_fkCompany = 0;
          cmpadd_fkCity = 0;
          cmpadd_cityName = "";
          cmpadd_contactName = "";
          cmpadd_address = "";
          cmpadd_phone = "";
          cmpadd_phone2 = "";
          cmpadd_fax = "";
          cmpadd_email = "";
          cmpadd_zip = "";
        }
        public clsCompanyAddress(int codsec)
        {
            this.load(codsec);
        }

        //Methods
        public void load(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwcompanyaddress where cmpadd_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cmpadd_codsec"]);
            this.fkCompany = Convert.ToInt32(DS.Tables[0].Rows[0]["cmpadd_fkCompany"]);
            this.fkCity = Convert.ToInt32(DS.Tables[0].Rows[0]["cmpadd_fkCity"]);
            this.cityName = DS.Tables[0].Rows[0]["cmpadd_cityName"].ToString();
            this.contactName = DS.Tables[0].Rows[0]["cmpadd_contactName"].ToString();
            this.address = DS.Tables[0].Rows[0]["cmpadd_address"].ToString();
            this.phone = DS.Tables[0].Rows[0]["cmpadd_phone"].ToString();
            this.phone2 = DS.Tables[0].Rows[0]["cmpadd_phone2"].ToString();
            this.fax = DS.Tables[0].Rows[0]["cmpadd_fax"].ToString();
            this.email = DS.Tables[0].Rows[0]["cmpadd_email"].ToString();
            this.zip = DS.Tables[0].Rows[0]["cmpadd_zip"].ToString();
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_admin_companyaddress (cmpadd_fkCompany, cmpadd_fkCity, cmpadd_contactName, cmpadd_address,  cmpadd_phone, cmpadd_phone2, cmpadd_fax, cmpadd_email, cmpadd_zip)";
                    queryString += " VALUES (";
                    queryString += this.fkCompany.ToString() + ",";
                    queryString += this.fkCity.ToString() + ",";
                    queryString += "'" + this.contactName + "',";
                    queryString += "'" + this.address + "',";
                    queryString += "'" + this.phone + "',";
                    queryString += "'" + this.phone2 + "',";
                    queryString += "'" + this.fax + "',";
                    queryString += "'" + this.email + "',";
                    queryString += "'" + this.zip + "'";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_admin_companyaddress";
                    queryString += " SET ";
                    queryString += "cmpadd_fkCompany = " + this.fkCompany.ToString() + ",";
                    queryString += "cmpadd_fkCity = " + this.fkCity.ToString() + ",";
                    queryString += "cmpadd_contactName = '" + this.contactName + "',";
                    queryString += "cmpadd_address = '" + this.address + "',";
                    queryString += "cmpadd_phone = '" + this.phone + "',";
                    queryString += "cmpadd_phone2 = '" + this.phone2 + "',";
                    queryString += "cmpadd_fax = '" + this.fax + "',";
                    queryString += "cmpadd_email = '" + this.email + "',";
                    queryString += "cmpadd_zip = '" + this.zip + "'";
                    queryString += " WHERE cmpadd_codsec = ;" + this.codsec.ToString();
                }
                clsConnection.executeQuery(queryString);
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCompanyAddress.save");
                return false;
            }

          }

        public static List<clsCompanyAddress> getListByCompany(int companyCodsec)
        {
            List<clsCompanyAddress> lstCompanyAddress = new List<clsCompanyAddress>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwcompanyaddress WHERE cmpadd_fkCompany = " + companyCodsec.ToString());

            lstCompanyAddress.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstCompanyAddress.Add(new clsCompanyAddress());
                lstCompanyAddress[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cmpadd_codsec"]);
                lstCompanyAddress[i].fkCompany = Convert.ToInt32(DS.Tables[0].Rows[i]["cmpadd_fkCompany"]);
                lstCompanyAddress[i].fkCity = Convert.ToInt32(DS.Tables[0].Rows[i]["cmpadd_fkCity"]);
                lstCompanyAddress[i].cityName = DS.Tables[0].Rows[i]["cmpadd_cityName"].ToString();
                lstCompanyAddress[i].contactName = DS.Tables[0].Rows[i]["cmpadd_contactName"].ToString();
                lstCompanyAddress[i].address = DS.Tables[0].Rows[i]["cmpadd_address"].ToString();
                lstCompanyAddress[i].phone = DS.Tables[0].Rows[i]["cmpadd_phone"].ToString();
                lstCompanyAddress[i].phone2 = DS.Tables[0].Rows[i]["cmpadd_phone2"].ToString();
                lstCompanyAddress[i].fax = DS.Tables[0].Rows[i]["cmpadd_fax"].ToString();
                lstCompanyAddress[i].email = DS.Tables[0].Rows[i]["cmpadd_email"].ToString();
                lstCompanyAddress[i].zip = DS.Tables[0].Rows[i]["cmpadd_zip"].ToString();
            }
            return lstCompanyAddress;
        }


    }
}
