using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsFormulationExtrusor1
    {
         //Atributes
        private int forext1_codsec;
        private int forext1_fkformulationreport;
        private string forext1_rawname;
        private string forext1_rawmaterial;
        private double forext1_percentaje;
        private string forext1_lotnumber;
        private double forext1_weigth;
        private double forext1_gramaje;
        private double forext1_thick; 
        
        //Properties

        public int codsec { get { return forext1_codsec; } set { forext1_codsec = value; } }

        public int fkformulationreport { get { return forext1_fkformulationreport; } set { forext1_fkformulationreport = value; } }

        public string rawmaterial { get { return forext1_rawmaterial; } set { forext1_rawmaterial = value; } }

        public string rawname { get { return forext1_rawname; } set { forext1_rawname = value; } }

        public double percentage { get { return forext1_percentaje; } set { forext1_percentaje = value; } }

        public string lotenumber { get { return forext1_lotnumber; } set { forext1_lotnumber = value; } }

        public double weigth { get { return forext1_weigth; } set { forext1_weigth = value; } }

        public double gramage { get { return forext1_gramaje; } set { forext1_gramaje = value; } }

        public double thick { get { return forext1_thick; } set { forext1_thick = value; } }


        //Constructor

        public clsFormulationExtrusor1()
        {
            forext1_codsec = 0;
            forext1_fkformulationreport = 0;
            forext1_rawmaterial = string.Empty;
            forext1_percentaje = 0;
            forext1_lotnumber = string.Empty;
            forext1_weigth = 0;
            forext1_gramaje = 0;
            forext1_thick = 0;
            forext1_rawname = string.Empty;
        }

        public clsFormulationExtrusor1(int codsec)
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
                    queryString += "INSERT INTO bps_prod_formulationextrusor1 (forext1_fkformulationreport,forext1_rawname,forext1_rawmaterial,forext1_percentaje,forext1_lotnumber,forext1_weigth,forext1_gramaje, forext1_thick) VALUES(";
                    queryString += this.fkformulationreport.ToString() + ",";
                    queryString += "'" + this.rawname + "',";
                    queryString += "'" + this.rawmaterial + "',";
                    queryString += this.percentage.ToString() + ",";
                    queryString += "'" + this.lotenumber.ToString() + "',";
                    queryString += this.weigth.ToString() + ",";
                    queryString += this.gramage.ToString()+",";
                    queryString += this.thick.ToString();
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_formulationextrusor1";
                    queryString += " SET ";
                    queryString += "forext1_fkformulationreport = " + this.fkformulationreport + ",";
                    queryString += "forext1_rawmaterial = '" + this.rawmaterial.ToString() + "',";
                    queryString += "forext1_percentaje = " + this.percentage.ToString() + ",";
                    queryString += "forext1_lotnumber = '" + this.lotenumber.ToString() + "',";
                    queryString += "forext1_weigth = " + this.weigth.ToString() + "',";
                    queryString += "forext1_gramaje = " + this.gramage + ",";
                    queryString += " WHERE forext1_codsec = " + this.codsec.ToString() + ";";
                }
                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsFormulationExtrusor1.save");
                return false;
            }
        }
        public static int getTotalWeigth(int codsec)
        {
            DataSet DS = new DataSet();
            clsFormulationReport ObjFormulationReport = new clsFormulationReport();
            ObjFormulationReport.load(codsec);
            DS = clsConnection.getDataSetResult("SELECT COALESCE(SUM(forext1_weigth),0) AS weigth FROM bps_prod_formulationextrusor1 WHERE forext1_fkformulationreport = " + ObjFormulationReport.fkproductionorder.ToString());
            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(DS.Tables[0].Rows[0]["weigth"]);
            else
                return 0;
        }
    }
}
