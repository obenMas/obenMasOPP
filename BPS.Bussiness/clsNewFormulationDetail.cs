using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsNewFormulationDetail
    {
        private int nfd_codsec;
        private int nfd_fkNewFormulation;
        private int nfd_fkLayer;
        private int nfd_fkRawMaterial;
        private float nfd_percentage;

        public int Codsec { get { return nfd_codsec; } set { nfd_codsec = value; } }
        public int fkNewFormulation { get { return nfd_fkNewFormulation; } set { nfd_fkNewFormulation = value; } }
        public int fkLayer { get { return nfd_fkLayer; } set { nfd_fkLayer = value; } }
        public int fkRawMaterial { get { return nfd_fkRawMaterial; } set { nfd_fkRawMaterial = value; } }
        public float Percentage { get { return nfd_percentage; } set { nfd_percentage = value; } }

        public clsNewFormulationDetail()
        {
            Codsec = 0;
            fkNewFormulation = 0;
            fkLayer = 0;
            fkRawMaterial = 0;
            Percentage = 0;
        }

        public clsNewFormulationDetail(int codsec)
        {
            this.load(codsec);
        }

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_newformulationdetail WHERE nfd_codsec=" + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                Codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["nfd_codsec"]);
                fkNewFormulation = Convert.ToInt32(DS.Tables[0].Rows[0]["nfd_fkNewFormulation"]);
                fkLayer = Convert.ToInt32(DS.Tables[0].Rows[0]["nfd_fkLayer"]);
                fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[0]["nfd_fkRawMaterial"]);
                Percentage = float.Parse(DS.Tables[0].Rows[0]["nfd_percentage"].ToString());
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        public void loadCodsecAndNF(int codsec, int pos)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_newformulationdetail WHERE nfd_fkLayer=" + fkLayer.ToString()+ " AND nfd_fkNewFormulation="+codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                Codsec = Convert.ToInt32(DS.Tables[0].Rows[pos]["nfd_codsec"]);
                fkNewFormulation = Convert.ToInt32(DS.Tables[0].Rows[pos]["nfd_fkNewFormulation"]);
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        public static List<clsNewFormulationDetail> getListByFormulation(int codsec)
        {
            List<clsNewFormulationDetail> lstNFD = new List<clsNewFormulationDetail>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_newformulationdetail where nfd_fkNewFormulation=" + codsec.ToString());
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstNFD.Add(new clsNewFormulationDetail());
                lstNFD[i].Codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["nfd_codsec"]);
                lstNFD[i].fkNewFormulation = Convert.ToInt32(DS.Tables[0].Rows[i]["nfd_fkNewFormulation"]);
                lstNFD[i].fkLayer = Convert.ToInt32(DS.Tables[0].Rows[i]["nfd_fkLayer"]);
                lstNFD[i].fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[i]["nfd_fkRawMaterial"]);
                lstNFD[i].Percentage = float.Parse(DS.Tables[0].Rows[i]["nfd_percentage"].ToString());
            }
            return lstNFD;
        }

        public bool save()
        {
            try
            {
                string queryString = "";
                bool bandera = false;
                if (this.Codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_newformulationdetail (nfd_fkNewFormulation, nfd_fkLayer, nfd_fkRawMaterial, nfd_percentage) ";
                    queryString += "VALUES (";
                    queryString += fkNewFormulation.ToString() + ",";
                    queryString += fkLayer.ToString() + ",";
                    queryString += fkRawMaterial.ToString() + ",";
                    queryString += Percentage.ToString() + ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_newformulationdetail";
                    queryString += " SET ";
                    queryString += "nfd_fkNewFormulation = " + fkNewFormulation.ToString() + ",";
                    queryString += "nfd_fkLayer = " + fkLayer.ToString() + ",";
                    queryString += "nfd_fkRawMaterial = " + fkRawMaterial.ToString() + ",";
                    queryString += "nfd_percentage = " + Percentage.ToString();
                    queryString += " WHERE nfd_codsec = " + Codsec.ToString() + ";";
                }
                bandera = clsConnection.executeQuery(queryString);
                return bandera;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsNewFormulationDetail.save");
                return false;
            }
        }
        public void getFkNewFormulation()
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT nfd_fkNewFormulation FROM bps_prod_newformulationdetail WHERE nfd_codsec=" + Codsec.ToString());
            fkNewFormulation = Convert.ToInt32(DS.Tables[0].Rows[0]["nfd_fkNewFormulation"]);
        }
        public static bool DeleteByNewFormulation(int codsec)
        {
            return clsConnection.executeQuery("DELETE FROM bps_prod_newformulationdetail WHERE nfd_fkNewFormulation=" + codsec.ToString());
        }
        public static void Delete(int codsec)
        {
            clsConnection.executeQuery("DELETE FROM bps_prod_newformulationdetail WHERE nfd_codsec=" + codsec.ToString());
        }
    }
}
