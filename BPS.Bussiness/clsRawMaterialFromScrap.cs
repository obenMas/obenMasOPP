using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsRawMaterialFromScrap
    {
        // Atributes
        private int rmfs_codsec;
        private int rmfs_fkRawMaterial;
        private int rmfs_fkScrap;

        // Properties
        public int codsec { get { return rmfs_codsec; } set { rmfs_codsec = value; } }
        public int fkRawMaterial { get { return rmfs_fkRawMaterial; } set { rmfs_fkRawMaterial = value; } }
        public int fkScrap { get { return rmfs_fkScrap; } set { rmfs_fkScrap = value; } }
        public clsRawMaterial rawMaterial = new clsRawMaterial();

        // Constructor
        /*
        public clsRawMaterialFromScrap()
        {
            codsec = 0;
            fkRawMaterial = 0;
            fkScrap = 0;
        }*/

        public clsRawMaterialFromScrap(int codsec)
        {
            this.load(codsec);
            rawMaterial = new clsRawMaterial(this.fkRawMaterial);
        }

        public clsRawMaterialFromScrap()
        {
            this.loadNCodsec();
        }

        //Method
        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_rawmaterialfromscrap WHERE rmfs_codsec = " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["rmfs_codsec"]);
                this.fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[0]["rmfs_fkRawMaterial"]);
                this.fkScrap = Convert.ToInt32(DS.Tables[0].Rows[0]["rmfs_fkScrap"]);
            }
        }
       
        public void loadNCodsec()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_rawmaterialfromscrap");

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["rmfs_codsec"]);
                this.fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[0]["rmfs_fkRawMaterial"]);
                this.fkScrap = Convert.ToInt32(DS.Tables[0].Rows[0]["rmfs_fkScrap"]);
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_rawmaterialfromscrap (rmfs_codsec,rmfs_fkRawMaterial,rmfs_fkScrap)";
                    queryString += "VALUES ( ";
                    queryString += this.fkRawMaterial.ToString() + ", ";
                    queryString += this.fkScrap.ToString() + ") ";
                }
                else
                {
                    queryString += "UPDATE bps_prod_rawmaterialfromscrap (rmfs_fkRawMaterial,rmfs_fkScrap)";
                    queryString += " SET ";
                    queryString += " rmfs_fkScrap = " + this.fkScrap.ToString() + ",";
                    queryString += " rmfs_fkRawMaterial = " + this.fkRawMaterial.ToString() + ",";
                    queryString += " WHERE rmfs_codsec = " + this.codsec.ToString() + ";";
                }
                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsRawMaterialFromScrap.save");
                return false;
            }
        }

        // Aca hago el getlist.

        public static List<clsRawMaterialFromScrap> lstRawMaterialFromScrap()
        {
            List<clsRawMaterialFromScrap> lstRawMaterials = new List<clsRawMaterialFromScrap>();
            

            DataSet DS = new DataSet();
            
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_rawmaterialfromscrap");

            lstRawMaterials.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstRawMaterials.Add(new clsRawMaterialFromScrap(Convert.ToInt32(DS.Tables[0].Rows[i]["rmfs_codsec"])));
            }
            return lstRawMaterials;
        }

        public int getfkScrapByfkRawMaterialCode(int fkRawMaterialCode)
        {
            try
            {
                DataSet DS = new DataSet();

                DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_rawmaterialfromscrap WHERE rmfs_fkRawMaterial = " + fkRawMaterialCode.ToString());

                if (DS.Tables[0].Rows.Count > 0)
                {
                    return Convert.ToInt32(DS.Tables[0].Rows[0]["rmfs_fkScrap"]);
                }
                else
                {
                    return 0;
                }

            }
            catch(Exception ex)
            {
                clsLog.addLog(ex, 3, "clsRawMaterialFromScrap.save");
                return 0;
            }
        }
        
    }
}
