using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsFormulationCentralLayer
    {
         //Atributes
        private int forcen_codsec;
        private int forcen_fkformulationreport;
        private string forcen_rawmaterial;
        private string forcen_rawname;
        private double forcen_percentaje;
        private string forcen_lotnumber;
        private double forcen_weigth;
        private double forcen_gramaje;
        private double forcen_thick;
        
        //Properties

        public int codsec { get { return forcen_codsec; } set { forcen_codsec = value; } }

        public int fkformulationreport { get { return forcen_fkformulationreport; } set { forcen_fkformulationreport = value; } }

        public string rawmaterial { get { return forcen_rawmaterial; } set { forcen_rawmaterial = value; } }

        public string rawname { get { return forcen_rawname; } set { forcen_rawname = value; } }

        public double percentage { get { return forcen_percentaje; } set { forcen_percentaje = value; } }

        public string lotenumber { get { return forcen_lotnumber; } set { forcen_lotnumber = value; } }

        public double weigth { get { return forcen_weigth; } set { forcen_weigth = value; } }

        public double gramage { get { return forcen_gramaje; } set { forcen_gramaje = value; } }

        public double thick { get { return forcen_thick; } set { forcen_thick = value; } }


        //Constructor

        public clsFormulationCentralLayer()
        {
            forcen_codsec = 0;
            forcen_fkformulationreport = 0;
            forcen_rawmaterial = string.Empty;
            forcen_rawname = string.Empty;
            forcen_percentaje = 0;
            forcen_lotnumber = string.Empty;
            forcen_weigth = 0;
            forcen_gramaje = 0;
            forcen_thick = 0;
        }

        public clsFormulationCentralLayer(int codsec)
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
                    queryString += "INSERT INTO bps_prod_formulationcentrallayer (forcen_fkformulationreport,forcen_rawname,forcen_rawmaterial,forcen_percentaje,forcen_lotnumber,forcen_weigth,forcen_gramaje,forcen_thick) VALUES(";
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
                    queryString += "UPDATE bps_prod_formulationcentrallayer";
                    queryString += " SET ";
                    queryString += "forcen_fkformulationreport = " + this.fkformulationreport + ",";
                    queryString += "forcen_rawname = '" + this.rawname.ToString() + "',";
                    queryString += "forcen_rawmaterial = '" + this.rawmaterial.ToString() + "',";
                    queryString += "forcen_percentaje = " + this.percentage.ToString() + ",";
                    queryString += "forcen_lotnumber = '" + this.lotenumber.ToString() + "',";
                    queryString += "forcen_weigth = " + this.weigth.ToString() + "',";
                    queryString += "forcen_gramaje = " + this.gramage + ",";
                    queryString += "forcen_thick = " + this.thick + "";
                    queryString += " WHERE forcen_codsec = " + this.codsec.ToString() + ";";
                }
                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsFormulationCentralLayer.save");
                return false;
            }
        }

        public static int getTotalWeigth(int codsec)
        {
            DataSet DS = new DataSet();
            clsFormulationReport ObjFormulationReport = new clsFormulationReport();
            ObjFormulationReport.load(codsec);
            DS = clsConnection.getDataSetResult("SELECT COALESCE(SUM(forcen_weigth),0) AS weigth FROM bps_prod_formulationcentrallayer WHERE forcen_fkformulationreport = " + ObjFormulationReport.fkproductionorder.ToString());
            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(DS.Tables[0].Rows[0]["weigth"]);
            else
                return 0;
        }
    }
}
