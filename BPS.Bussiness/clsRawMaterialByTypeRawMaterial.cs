using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;

namespace BPS.Bussiness
{
    public class clsRawMaterialTypeByTypeRawMaterial
    {

        //Atributes

        private int rwm_codsec;
        private int rwm_fkRawMaterialtype;
        private string rwm_RawMaterialtypeName;
        private string rwm_code;

        //Properties

        public int codsec { get { return rwm_codsec; } set { rwm_codsec = value; } }

        public int fkRawMaterialtype { get { return rwm_fkRawMaterialtype; } set { rwm_fkRawMaterialtype = value; } }

        public string RawMaterialtypeName { get { return rwm_RawMaterialtypeName; } set { rwm_RawMaterialtypeName = value; } }

        public string code { get { return rwm_code; } set { rwm_code = value; } }

        //Constructor

        public clsRawMaterialTypeByTypeRawMaterial()
        {
            rwm_codsec = 0;
            rwm_fkRawMaterialtype = 0;
            rwm_RawMaterialtypeName = "";
            rwm_code = "";
        }

        public static List<clsRawMaterialTypeByTypeRawMaterial> getListByRawMaterial(int rwCodsec)
        {
            List<clsRawMaterialTypeByTypeRawMaterial> lstRawMaterialByRawMaterialType = new List<clsRawMaterialTypeByTypeRawMaterial>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT rwm_codsec,rwn_fkRawMaterialtype,rwm_name,rwm_code FROM bps_prod_rawmaterial  where rwn_fkRawMaterialtype = " + rwCodsec + " order by rwm_code asc");

            lstRawMaterialByRawMaterialType.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstRawMaterialByRawMaterialType.Add(new clsRawMaterialTypeByTypeRawMaterial());
                lstRawMaterialByRawMaterialType[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["rwm_codsec"]);
                lstRawMaterialByRawMaterialType[i].fkRawMaterialtype = Convert.ToInt32(DS.Tables[0].Rows[i]["rwm_fkRawMaterialType"]);
                lstRawMaterialByRawMaterialType[i].RawMaterialtypeName = DS.Tables[0].Rows[i]["rwm_name"].ToString();
                lstRawMaterialByRawMaterialType[i].code = DS.Tables[0].Rows[i]["rwm_code"].ToString();


            }

            return lstRawMaterialByRawMaterialType;
        }

              public override string ToString()
        {
            return this.RawMaterialtypeName;
        }
    }
}
