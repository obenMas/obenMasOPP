using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsNewFormulation
    {
        private int nf_codsec;
        private string nf_name;
        private string nf_description;
        private float nf_thickness;
        private int nf_fkBopp;
        private int nf_fkCast;
        private int nf_fkCoat;
        private bool nf_isStandar;
        private List<clsLayerThickByNewFormulation> nf_lstLayerThickByNewFormulation;
        private List<clsNewFormulationDetail> nf_lstNewFormulationDetail;
        private int nf_fkMachine;

        public int Codsec { get { return nf_codsec; } set { nf_codsec = value; } }
        public string Name { get { return nf_name; } set { nf_name = value; } }
        public string Description { get { return nf_description; } set { nf_description = value; } }
        public float Thickness { get { return nf_thickness; } set { nf_thickness = value; } }
        public int fkBopp { get { return nf_fkBopp; } set { nf_fkBopp = value; } }
        public int fkCast { get { return nf_fkCast; } set { nf_fkCast = value; } }
        public int fkCoat { get { return nf_fkCoat; } set { nf_fkCoat = value; } }
        public bool isStandar { get { return nf_isStandar; } set { nf_isStandar = value; } }
        public List<clsLayerThickByNewFormulation> lstLayerThickByNewFormulation { get { return nf_lstLayerThickByNewFormulation; } set { nf_lstLayerThickByNewFormulation = value; } }
        public List<clsNewFormulationDetail> lstNewFormulationDetail { get { return nf_lstNewFormulationDetail; } set { nf_lstNewFormulationDetail = value; } }
        public int fkMachine { get { return nf_fkMachine; } set { nf_fkMachine = value; } }

        public clsNewFormulation()
        {
            nf_codsec = 0;
            nf_name = "";
            nf_description = "";
            nf_thickness = 0;
            nf_fkBopp = 0;
            nf_fkCast = 0;
            nf_fkCoat = 0;
            nf_isStandar = false;
            lstLayerThickByNewFormulation = new List<clsLayerThickByNewFormulation>();
            lstNewFormulationDetail = new List<clsNewFormulationDetail>();
            fkMachine = 0;
        }
        public clsNewFormulation(int codsec)
        {
            this.load(codsec);
        }

        public void load(int codsec)
        {
            
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_newformulation WHERE nf_codsec=" + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                Codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["nf_codsec"]);
                Name = DS.Tables[0].Rows[0]["nf_name"].ToString();
                Description = DS.Tables[0].Rows[0]["nf_description"].ToString();
                Thickness = float.Parse(DS.Tables[0].Rows[0]["nf_thickness"].ToString());
                fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["nf_fkBopp"]);
                fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["nf_fkCast"]);
                fkCoat = Convert.ToInt32(DS.Tables[0].Rows[0]["nf_fkCoat"]);
                isStandar = Convert.ToBoolean(DS.Tables[0].Rows[0]["nf_isStandar"]);
                lstLayerThickByNewFormulation = clsLayerThickByNewFormulation.getListByFormulation(Codsec);
                lstNewFormulationDetail = clsNewFormulationDetail.getListByFormulation(Codsec);
                fkMachine = Convert.ToInt32(DS.Tables[0].Rows[0]["nf_fkMachine"]);
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        public void loadByBoppStandar(int fkbopp, int fkmachine)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_newformulation WHERE nf_fkBopp=" + fkbopp.ToString() +"AND nf_isStandar=1 AND nf_fkMachine="+fkmachine.ToString());

            if (DS.Tables.Count>0&&DS.Tables[0].Rows.Count > 0)
            {
                Codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["nf_codsec"]);
                Name = DS.Tables[0].Rows[0]["nf_name"].ToString();
                Description = DS.Tables[0].Rows[0]["nf_description"].ToString();
                Thickness = float.Parse(DS.Tables[0].Rows[0]["nf_thickness"].ToString());
                fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["nf_fkBopp"]);
                fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["nf_fkCast"]);
                fkCoat = Convert.ToInt32(DS.Tables[0].Rows[0]["nf_fkCoat"]);
                isStandar = Convert.ToBoolean(DS.Tables[0].Rows[0]["nf_isStandar"]);
                lstLayerThickByNewFormulation = clsLayerThickByNewFormulation.getListByFormulation(Codsec);
                lstNewFormulationDetail = clsNewFormulationDetail.getListByFormulation(Codsec);
                fkMachine = Convert.ToInt32(DS.Tables[0].Rows[0]["nf_fkMachine"]);
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        public bool save()
        {
            try
            {
                bool bandera=false;
                string queryString = "";
                if(this.Codsec==0)
                {
                    queryString += "INSERT INTO bps_prod_newformulation(nf_name, nf_description, nf_thickness, nf_fkBopp, nf_fkCast, nf_fkCoat, nf_isStandar, nf_fkMachine)";
                    queryString += " VALUES(";
                    queryString += "'" + Name.ToString() + "',";
                    queryString += "'" + Description.ToString() + "',";
                    queryString += Thickness.ToString() + ",";
                    queryString += fkBopp.ToString() + ",";
                    queryString += fkCast.ToString() + ",";
                    queryString += fkCoat.ToString() + ",";
                    queryString += isStandar.ToString()+",";
                    queryString += fkMachine.ToString() + ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_newformulation";
                    queryString += " SET";
                    queryString += " nf_name='" + Name.ToString() + "',";
                    queryString += " nf_description='" + Description.ToString() + "',";
                    queryString += " nf_thickness=" + Thickness.ToString() + ",";
                    queryString += " nf_fkBopp=" + fkBopp.ToString() + ",";
                    queryString += " nf_fkCast=" + fkCast.ToString() + ",";
                    queryString += " nf_fkCoat=" + fkCoat.ToString() + ",";
                    queryString += " nf_isStandar=" + isStandar.ToString()+",";
                    queryString += " nf_fkMachine=" + fkMachine.ToString();
                    queryString += " WHERE nf_codsec=" + Codsec.ToString();
                }
                bandera = clsConnection.executeQuery(queryString);

                if (Codsec == 0)
                {
                    Codsec = getLastSavedCodsec();
                    for (int i = 0; i < lstLayerThickByNewFormulation.Count; i++)
                    {
                        lstLayerThickByNewFormulation[i].fkNewFormulation = Codsec;
                        lstLayerThickByNewFormulation[i].save();
                    }
                    for (int i = 0; i < lstNewFormulationDetail.Count; i++)
                    {
                        lstNewFormulationDetail[i].fkNewFormulation = Codsec;
                        lstNewFormulationDetail[i].save();
                    }
                }
                else
                {
                    for (int i = 0; i < lstLayerThickByNewFormulation.Count; i++)
                    {
                        lstLayerThickByNewFormulation[i].fkNewFormulation = Codsec;
                        lstLayerThickByNewFormulation[i].save();
                    }
                    for (int i = 0; i < lstNewFormulationDetail.Count; i++)
                    {
                        lstNewFormulationDetail[i].fkNewFormulation = Codsec;
                        lstNewFormulationDetail[i].save();
                    }
                }
                return bandera;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsNewFormulation.save");
                return false;
            }
        }

        public int getLastSavedCodsec()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_newformulation ORDER BY nf_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["nf_codsec"]);
        }
        public bool CheckStandar(int fkBopp, int fkmachine)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT nf_codsec FROM bps_prod_newformulation WHERE nf_isStandar=1 AND nf_fkBopp="+fkBopp.ToString()+"AND nf_fkMachine="+fkmachine.ToString());

            if (DS.Tables.Count>0 && DS.Tables[0].Rows.Count > 0)
                return true;
            return false;
        }
        public static void EstablecerNoEstandar(int fkBopp, int fkmachine)
        {
            clsNewFormulation obj = new clsNewFormulation();
            obj.load(obj.GetCodsecStandar(fkBopp,fkmachine));
            obj.isStandar = false;
            obj.save();
        }
        public int GetCodsecStandar(int fkBopp, int fkmachine)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT nf_codsec FROM bps_prod_newformulation WHERE nf_isStandar=1 AND nf_fkBopp=" + fkBopp.ToString() + "AND nf_fkMachine=" + fkmachine.ToString());

            return Convert.ToInt32(DS.Tables[0].Rows[0]["nf_codsec"]);
        }
        public int ContarCapas()
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT COUNT(ltbnf_codsec) AS Capas FROM bps_prod_layerThickByNewFormulation WHERE ltbnf_fkNewFormulation="+Codsec.ToString());
            return Convert.ToInt32(DS.Tables[0].Rows[0]["Capas"]);
        }
        public static bool Delete(int codsec)
        {
            bool bandera = false;
            bandera = clsConnection.executeQuery("DELETE FROM bps_prod_newformulation WHERE nf_codsec=" + codsec.ToString());
            bandera = clsLayerThickByNewFormulation.DeleteByNewFormulation(codsec);
            bandera = clsNewFormulationDetail.DeleteByNewFormulation(codsec);
            return bandera;
        }
    }
}
