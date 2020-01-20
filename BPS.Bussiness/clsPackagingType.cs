using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra el tipo de empaque (Por Peso o Por Unidades) para materias primas y suministros
    /// </summary>
    public class clsPackagingType
    {
        //Atributes

        private int pktp_codsec;
        private int pktp_fkUnit;
        private string pktp_UnitName;
        private string pktp_name;
        private string pktp_initial;


        //Properties

        public int codsec { get { return pktp_codsec; } set { pktp_codsec = value; } }

        public int fkUnit { get { return pktp_fkUnit; } set { pktp_fkUnit = value; } }

        public string UnitName { get { return pktp_UnitName; } set { pktp_UnitName = value; } }

        public string name { get { return pktp_name; } set { pktp_name = value; } }

        public string initial { get { return pktp_initial; } set { pktp_initial = value; } }


        //Constructor

        public clsPackagingType()
        { 
        pktp_codsec = 0;
        pktp_fkUnit = 0;
        pktp_UnitName = "";
        pktp_name = "";
        pktp_initial = "";
        }
        public clsPackagingType(int codsec)
        {
            this.load(codsec);
        }
        //Methods

        public void load(int codsec)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT pktp_codsec,pktp_name, unt.unit_codsec as pktp_fkUnit, unt.unit_name as pktp_UnitName,pktp_initial FROM bps_prod_packagingtype as pkt ,bps_admin_unit as unt where pkt.pktp_fkUnit = unt.unit_codsec and pktp_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["pktp_codsec"]);
            this.fkUnit = Convert.ToInt32(DS.Tables[0].Rows[0]["pktp_fkUnit"]);
            this.name = DS.Tables[0].Rows[0]["pktp_name"].ToString();
            this.UnitName = DS.Tables[0].Rows[0]["pktp_UnitName"].ToString();
            this.initial = DS.Tables[0].Rows[0]["pktp_initial"].ToString();
            
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_packagingtype (pktp_fkUnit,pktp_name,pktp_initial)";
                    queryString += " VALUES (";
                    queryString += this.fkUnit.ToString() + ",";
                    queryString += "'" + this.name + "',";
                    queryString += "'" + this.initial + "'";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_packagingtype";
                    queryString += " SET ";
                    queryString += "pktp_fkUnit = " + this.fkUnit.ToString() + ",";
                    queryString += "pktp_name = '" + this.name + "',";
                    queryString += "pktp_initial = '" + this.initial + "'";
                    queryString += " WHERE pktp_codsec = " + this.codsec.ToString() + ";";
                }
                clsConnection.executeQuery(queryString);
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsPackagingType.save");
                return false;
            }

        }

        public static List<clsPackagingType> getList()
        {
            List<clsPackagingType> lstPackagingType = new List<clsPackagingType>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT pktp_codsec,pktp_name, unt.unit_codsec as pktp_fkUnit, unt.unit_name as pktp_UnitName,pktp_initial FROM bps_prod_packagingtype as pkt ,bps_admin_unit as unt where pkt.pktp_fkUnit = unt.unit_codsec order by pktp_name asc");

            lstPackagingType.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstPackagingType.Add(new clsPackagingType());
                lstPackagingType[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pktp_codsec"]);
                lstPackagingType[i].name = DS.Tables[0].Rows[i]["pktp_name"].ToString();
                lstPackagingType[i].UnitName = DS.Tables[0].Rows[i]["pktp_UnitName"].ToString();
                lstPackagingType[i].initial = DS.Tables[0].Rows[i]["pktp_initial"].ToString();
                
            }

            return lstPackagingType;
        }


        public override string ToString()
        {
            return this.name;
        }
    }
}
