using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    //clase para manejar Equivalencia de materia prima con sistemas externos
    public class clsRawMaterialEquivalence
    {
        //Attributes

        private int rme_codsec;
        private int rme_fkRawMaterial;
        private string rme_rawMaterialName;
        private string rme_externalSystemCode;
        private string rme_externalSystemReference;

        //Properties

        public int codsec { get { return rme_codsec; } set { rme_codsec = value; } }

        public int fkRawMaterial { get { return rme_fkRawMaterial; } set { rme_fkRawMaterial = value; } }

        public string rawMaterialName { get { return rme_rawMaterialName; } set { rme_rawMaterialName = value; } }

        public string  externalSystemCode { get { return rme_externalSystemCode; } set { rme_externalSystemCode = value; } }

        public string  externalSystemReference { get { return rme_externalSystemReference; } set { rme_externalSystemReference = value; } }

        public clsRawMaterialEquivalence()
        {
            codsec = 0;
            fkRawMaterial = 0;
            rawMaterialName = "";
            externalSystemCode = "";
            externalSystemReference = "";
        }

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * from vmxtrrawmaterialequivalence where rme_codsec = " + codsec.ToString());
            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["rme_codsec"]);
                this.fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[0]["rme_fkRawMaterial"]);
                this.rawMaterialName = DS.Tables[0].Rows[0]["rme_rawMaterialName"].ToString();
                this.externalSystemCode = DS.Tables[0].Rows[0]["rme_externalSystemCode"].ToString();
                this.externalSystemReference = DS.Tables[0].Rows[0]["rme_externalSystemReference"].ToString();
            }
        }
        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_xtr_rawmaterialequivalence (rme_fkRawMaterial, rme_externalSystemCode, rme_externalSystemReference)";
                    queryString += " VALUES (";
                    queryString += this.fkRawMaterial + ",";
                    queryString += "'" + this.externalSystemCode.ToString() + "' ,";
                    queryString += "'" +  this.externalSystemReference.ToString() + "'";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_xtr_rawmaterialequivalence";
                    queryString += " SET ";
                    queryString += "rme_fkRawMateria = " + this.fkRawMaterial + ",";
                    queryString += "rme_externalSystemCode = '" + this.externalSystemCode.ToString() + "',";
                    queryString += "rme_externalSystemReference = '" + this.externalSystemReference.ToString() + "'";
                    queryString += " WHERE rme_codsec = " + this.codsec.ToString() + ";";
                    clsConnection.executeQuery(queryString);
                }
                return true;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsRawMaterialEquivalence.save");
                return false;
            }
        }
        public static List<clsRawMaterialEquivalence> getList()
        {
            List<clsRawMaterialEquivalence> lstMaterialEquivalence = new List<clsRawMaterialEquivalence>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vmxtrrawmaterialequivalence");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstMaterialEquivalence.Add(new clsRawMaterialEquivalence());
                lstMaterialEquivalence[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["rme_codsec"]);
                lstMaterialEquivalence[i].fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[i]["rme_fkRawMaterial"]);
                lstMaterialEquivalence[i].rawMaterialName = DS.Tables[0].Rows[i]["rme_rawMaterialName"].ToString();
                lstMaterialEquivalence[i].externalSystemCode = DS.Tables[0].Rows[i]["rme_externalSystemCode"].ToString();
                lstMaterialEquivalence[i].externalSystemReference = DS.Tables[0].Rows[i]["rme_externalSystemReference"].ToString();

            }
            return lstMaterialEquivalence;
        }

        public static clsRawMaterialEquivalence getDetailByRawMaterial(int RawMaterialCodSec)
        {
            clsRawMaterialEquivalence objMaterialEquivalence = new clsRawMaterialEquivalence();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vmxtrrawmaterialequivalence where rme_fkRawMaterial = " + RawMaterialCodSec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                objMaterialEquivalence.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["rme_codsec"]);
                objMaterialEquivalence.fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[0]["rme_fkRawMaterial"]);
                objMaterialEquivalence.rawMaterialName = DS.Tables[0].Rows[0]["rme_rawMaterialName"].ToString();
                objMaterialEquivalence.externalSystemCode = DS.Tables[0].Rows[0]["rme_externalSystemCode"].ToString();
                objMaterialEquivalence.externalSystemReference = DS.Tables[0].Rows[0]["rme_externalSystemReference"].ToString();

            }
            return objMaterialEquivalence;
        }
    }
}
