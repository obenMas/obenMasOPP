using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsFormulationExtrusor4
    {
         //Atributes
        private int forext4_codsec;
        private int forext4_fkformulationreport;
        private string forext4_rawname;
        private string forext4_rawmaterial;
        private double forext4_percentaje;
        private string forext4_lotnumber;
        private double forext4_weigth;
        private double forext4_gramaje;
        private double forext4_thick;
        
        //Properties

        public int codsec { get { return forext4_codsec; } set { forext4_codsec = value; } }

        public int fkformulationreport { get { return forext4_fkformulationreport; } set { forext4_fkformulationreport = value; } }

        public string rawname { get { return forext4_rawname; } set { forext4_rawname = value; } }

        public string rawmaterial { get { return forext4_rawmaterial; } set { forext4_rawmaterial = value; } }

        public double percentage { get { return forext4_percentaje; } set { forext4_percentaje = value; } }

        public string lotenumber { get { return forext4_lotnumber; } set { forext4_lotnumber = value; } }

        public double weigth { get { return forext4_weigth; } set { forext4_weigth = value; } }

        public double gramage { get { return forext4_gramaje; } set { forext4_gramaje = value; } }

        public double thick { get { return forext4_thick; } set { forext4_thick = value; } }


        //Constructor

        public clsFormulationExtrusor4()
        {
            forext4_codsec = 0;
            forext4_fkformulationreport = 0;
            forext4_rawmaterial = string.Empty;
            forext4_percentaje = 0;
            forext4_lotnumber = string.Empty;
            forext4_weigth = 0;
            forext4_gramaje = 0;
            forext4_thick = 0;
            forext4_rawname = string.Empty;
        }

        public clsFormulationExtrusor4(int codsec)
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
                    queryString += "INSERT INTO bps_prod_formulationextrusor4 (forext4_fkformulationreport,forext4_rawname,forext4_rawmaterial,forext4_percentaje,forext4_lotnumber,forext4_weigth,forext4_gramaje,forext4_thick) VALUES(";
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
                    queryString += "UPDATE bps_prod_formulationextrusor4";
                    queryString += " SET ";
                    queryString += "forext4_fkformulationreport = " + this.fkformulationreport + ",";
                    queryString += "forext4_rawmaterial = '" + this.rawmaterial.ToString() + "',";
                    queryString += "forext4_percentaje = " + this.percentage.ToString() + ",";
                    queryString += "forext4_lotnumber = '" + this.lotenumber.ToString() + "',";
                    queryString += "forext4_weigth = " + this.weigth.ToString() + "',";
                    queryString += "forext4_gramaje = " + this.gramage + ",";
                    queryString += " WHERE forext4_codsec = " + this.codsec.ToString() + ";";
                }
                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsFormulationExtrusor4.save");
                return false;
            }
        }
        public static int getTotalWeigth(int codsec)
        {
            DataSet DS = new DataSet();
            clsFormulationReport ObjFormulationReport = new clsFormulationReport();
            ObjFormulationReport.load(codsec);
            DS = clsConnection.getDataSetResult("SELECT COALESCE(SUM(forext4_weigth),0) AS weigth FROM bps_prod_formulationextrusor4 WHERE forext4_fkformulationreport = " + ObjFormulationReport.fkproductionorder.ToString());
            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(DS.Tables[0].Rows[0]["weigth"]);
            else
                return 0;
        }
    }
}
