using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsFormulationExtrusor3
    {
         //Atributes
        private int forext3_codsec;
        private int forext3_fkformulationreport;
        private string forext3_rawname;
        private string forext3_rawmaterial;
        private double forext3_percentaje;
        private string forext3_lotnumber;
        private double forext3_weigth;
        private double forext3_gramaje;
        private double forext3_thick;
        
        //Properties

        public int codsec { get { return forext3_codsec; } set { forext3_codsec = value; } }

        public int fkformulationreport { get { return forext3_fkformulationreport; } set { forext3_fkformulationreport = value; } }

        public string rawname { get { return forext3_rawname; } set { forext3_rawname = value; } }

        public string rawmaterial { get { return forext3_rawmaterial; } set { forext3_rawmaterial = value; } }

        public double percentage { get { return forext3_percentaje; } set { forext3_percentaje = value; } }

        public string lotenumber { get { return forext3_lotnumber; } set { forext3_lotnumber = value; } }

        public double weigth { get { return forext3_weigth; } set { forext3_weigth = value; } }

        public double gramage { get { return forext3_gramaje; } set { forext3_gramaje = value; } }

        public double thick { get { return forext3_thick; } set { forext3_thick = value; } }


        //Constructor

        public clsFormulationExtrusor3()
        {
            forext3_codsec = 0;
            forext3_fkformulationreport = 0;
            forext3_rawmaterial = string.Empty;
            forext3_percentaje = 0;
            forext3_lotnumber = string.Empty;
            forext3_weigth = 0;
            forext3_gramaje = 0;
            forext3_thick = 0;
            forext3_rawname = string.Empty;
        }

        public clsFormulationExtrusor3(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        { 

            //DataSet DS = new DataSet();
            
            //DS = clsConnection.getDataSetResult("SELECT * bps_prod_rawmateriabyformulation FROM  where rwf_fkRawMaterial = " + codsec.ToString());

            //this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["rwf_codsec"]);
            //this.fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[0]["rwf_fkRawMaterial"]);
            //this.fkFormulation = Convert.ToInt32(DS.Tables[0].Rows[0]["rwf_fkRawMaterial"]);
            //this.percentage = Convert.ToDouble(DS.Tables[0].Rows[0]["rwt_percentage"]);
            //this.gramage = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["rwt_layerC1"], DS.Tables[0].Rows[0]["rwt_layerC1"].GetType().FullName);
            //this.layerC2 = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["rwt_layerC2"], DS.Tables[0].Rows[0]["rwt_layerC2"].GetType().FullName);
            //this.CentralLayer = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["rwt_CentralLayer"], DS.Tables[0].Rows[0]["rwt_CentralLayer"].GetType().FullName);
            
        }

        //Methods

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_formulationextrusor3 (forext3_fkformulationreport,forext3_rawname,forext3_rawmaterial,forext3_percentaje,forext3_lotnumber,forext3_weigth,forext3_gramaje,forext3_thick) VALUES(";
                    queryString += this.fkformulationreport.ToString() + ",";
                    queryString += "'" + this.rawname + "',";
                    queryString += "'" + this.rawmaterial + "',";
                    queryString += this.percentage.ToString() + ",";
                    queryString += "'" + this.lotenumber.ToString() + "',";
                    queryString += this.weigth.ToString() + ",";
                    queryString += this.gramage.ToString() + ",";
                    queryString += this.thick.ToString();
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_formulationextrusor3";
                    queryString += " SET ";
                    queryString += "forext3_fkformulationreport = " + this.fkformulationreport + ",";
                    queryString += "forext3_rawmaterial = '" + this.rawmaterial.ToString() + "',";
                    queryString += "forext3_percentaje = " + this.percentage.ToString() + ",";
                    queryString += "forext3_lotnumber = '" + this.lotenumber.ToString() + "',";
                    queryString += "forext3_weigth = " + this.weigth.ToString() + "',";
                    queryString += "forext3_gramaje = " + this.gramage + ",";
                    queryString += " WHERE forext3_codsec = " + this.codsec.ToString() + ";";
                }
                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsFormulationExtrusor3.save");
                return false;
            }
        }
        public static int getTotalWeigth(int codsec)
        {
            DataSet DS = new DataSet();
            clsFormulationReport ObjFormulationReport = new clsFormulationReport();
            ObjFormulationReport.load(codsec);
            DS = clsConnection.getDataSetResult("SELECT COALESCE(SUM(forext3_weigth),0) AS weigth FROM bps_prod_formulationextrusor3 WHERE forext3_fkformulationreport = " + ObjFormulationReport.fkproductionorder.ToString());
            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(DS.Tables[0].Rows[0]["weigth"]);
            else
                return 0;
        }
    }
}
