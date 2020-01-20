using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsLayerThickByNewFormulation
    {
        private int ltbnf_codsec;
        private int ltbnf_fkNewFormulation;
        private int ltbnf_fkLayer;
        private float ltbnf_thickness;

        public int Codsec { get { return ltbnf_codsec; } set { ltbnf_codsec = value; } }
        public int fkNewFormulation { get { return ltbnf_fkNewFormulation; } set { ltbnf_fkNewFormulation = value; } }
        public int fkLayer { get { return ltbnf_fkLayer; } set { ltbnf_fkLayer = value; } }
        public float Thickness { get { return ltbnf_thickness; } set { ltbnf_thickness = value; } }

        public clsLayerThickByNewFormulation()
        {
            ltbnf_codsec = 0;
            ltbnf_fkNewFormulation = 0;
            ltbnf_fkLayer = 0;
            ltbnf_thickness = 0;
        }
        public clsLayerThickByNewFormulation(int codsec)
        {
            this.load(codsec);
        }
        public void load(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("Select * from bps_prod_layerThickByNewFormulation where ltbnf_codsec=" + codsec.ToString());

            if(DS.Tables[0].Rows.Count>0)
            {
                Codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["ltbnf_codsec"]);
                fkNewFormulation = Convert.ToInt32(DS.Tables[0].Rows[0]["ltbnf_fkNewFormulation"]);
                fkLayer = Convert.ToInt32(DS.Tables[0].Rows[0]["ltbnf_fkLayer"]);
                Thickness = float.Parse(DS.Tables[0].Rows[0]["ltbnf_thickness"].ToString());
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";
                bool bandera = false;
                if (this.Codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_layerThickByNewFormulation (ltbnf_fkNewFormulation, ltbnf_fkLayer, ltbnf_thickness) ";
                    queryString += "VALUES (";
                    queryString += fkNewFormulation.ToString() + ",";
                    queryString += fkLayer.ToString() + ",";
                    queryString += Thickness.ToString() + ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_layerThickByNewFormulation";
                    queryString += " SET ";
                    queryString += "ltbnf_fkNewFormulation = " + fkNewFormulation.ToString() + ",";
                    queryString += "ltbnf_fkLayer = " + fkLayer.ToString() + ",";
                    queryString += "ltbnf_thickness = " + Thickness.ToString();
                    queryString += " WHERE ltbnf_codsec = " + Codsec.ToString() + ";";
                }
                bandera=clsConnection.executeQuery(queryString);
                return bandera;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsLayerThickByNewFormulation.save");
                return false;
            }
        }
        public static List<clsLayerThickByNewFormulation> getListByFormulation(int codsec)
        {
            List<clsLayerThickByNewFormulation> lstLTBNF = new List<clsLayerThickByNewFormulation>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_layerThickByNewFormulation where ltbnf_fkNewFormulation="+codsec.ToString());
            for(int i=0; i<DS.Tables[0].Rows.Count;i++)
            {
                lstLTBNF.Add(new clsLayerThickByNewFormulation());
                lstLTBNF[i].Codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["ltbnf_codsec"]);
                lstLTBNF[i].fkNewFormulation = Convert.ToInt32(DS.Tables[0].Rows[i]["ltbnf_fkNewFormulation"]);
                lstLTBNF[i].fkLayer = Convert.ToInt32(DS.Tables[0].Rows[i]["ltbnf_fkLayer"]);
                lstLTBNF[i].Thickness = float.Parse(DS.Tables[0].Rows[i]["ltbnf_thickness"].ToString());
            }
            return lstLTBNF;
        }
        public void loadCodsecAndNF(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("Select * from bps_prod_layerThickByNewFormulation where ltbnf_fkLayer="+fkLayer.ToString()+"AND ltbnf_fkNewFormulation="+codsec.ToString());

            Codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["ltbnf_codsec"]);
            fkNewFormulation = Convert.ToInt32(DS.Tables[0].Rows[0]["ltbnf_fkNewFormulation"]);
        }
        public void getFkNewFormulation()
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT ltbnf_fkNewFormulation FROM bps_prod_layerThickByNewFormulation WHERE ltbnf_codsec=" + Codsec.ToString());
            fkNewFormulation = Convert.ToInt32(DS.Tables[0].Rows[0]["ltbnf_fkNewFormulation"]);
        }
        public static bool DeleteByNewFormulation(int codsec)
        {
            return clsConnection.executeQuery("DELETE FROM bps_prod_layerThickByNewFormulation WHERE ltbnf_fkNewFormulation=" + codsec.ToString());
        }
        public static void Delete(int codsec)
        {
            clsConnection.executeQuery("DELETE FROM bps_prod_layerThickByNewFormulation WHERE ltbnf_codsec=" + codsec.ToString());
        }
    }
}
