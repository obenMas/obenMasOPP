using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que maneja el tipo de entidad
    /// </summary>
    public class clsIdType
    {

        //Atributes

        private int idt_codsec;
        private string idt_name;

        //Properties

        public int codsec { get { return idt_codsec; } set { idt_codsec = value; } }

        public string name { get { return idt_name; } set { idt_name = value; } }

        //Constructor

        public clsIdType()
        {
            idt_codsec = 0;
            idt_name = "";

        }

        public clsIdType(int codsec)
        {
            this.load(codsec);
        }
        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_idtype where idt_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["idt_codsec"]);
            this.name = DS.Tables[0].Rows[0]["idt_name"].ToString();

        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_admin_idType (idt_name)";
                    queryString += " VALUES (";
                    queryString += "'" + this.name + "'";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_admin_idType";
                    queryString += " SET ";
                    queryString += "idt_name = '" + this.name + "'";
                    queryString += " WHERE idt_codsec = " + this.codsec.ToString() + ";";
                    clsConnection.executeQuery(queryString);
                }
                return true;
            }

            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsIdType.save");
                return false;
            }

        }

        public static List<clsIdType> getList()
        {
            List<clsIdType> lstIdType = new List<clsIdType>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_idtype order by idt_name asc");

            lstIdType.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstIdType.Add(new clsIdType());
                lstIdType[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["idt_codsec"]);
                lstIdType[i].name = DS.Tables[0].Rows[i]["idt_name"].ToString();


            }

            return lstIdType;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}