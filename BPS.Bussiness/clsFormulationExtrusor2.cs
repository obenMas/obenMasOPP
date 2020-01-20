using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsFormulationExtrusor2
    {
         //Atributes
        private int forext2_codsec;
        private int forext2_fkformulationreport;
        private string forext2_rawname;
        private string forext2_rawmaterial;
        private double forext2_percentaje;
        private string forext2_lotnumber;
        private double forext2_weigth;
        private double forext2_gramaje;
        private double forext2_thick;
        
        //Properties

        public int codsec { get { return forext2_codsec; } set { forext2_codsec = value; } }

        public int fkformulationreport { get { return forext2_fkformulationreport; } set { forext2_fkformulationreport = value; } }

        public string rawname { get { return forext2_rawname; } set { forext2_rawname = value; } }

        public string rawmaterial { get { return forext2_rawmaterial; } set { forext2_rawmaterial = value; } }

        public double percentage { get { return forext2_percentaje; } set { forext2_percentaje = value; } }

        public string lotenumber { get { return forext2_lotnumber; } set { forext2_lotnumber = value; } }

        public double weigth { get { return forext2_weigth; } set { forext2_weigth = value; } }

        public double gramage { get { return forext2_gramaje; } set { forext2_gramaje = value; } }

        public double thick { get { return forext2_thick; } set { forext2_thick = value; } }


        //Constructor

        public clsFormulationExtrusor2()
        {
            forext2_codsec = 0;
            forext2_fkformulationreport = 0;
            forext2_rawmaterial = string.Empty;
            forext2_percentaje = 0;
            forext2_lotnumber = string.Empty;
            forext2_weigth = 0;
            forext2_gramaje = 0;
            forext2_thick = 0;
            forext2_rawname = string.Empty;
        }

        public clsFormulationExtrusor2(int codsec)
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
                    queryString += "INSERT INTO bps_prod_formulationextrusor2 (forext2_fkformulationreport,forext2_rawname,forext2_rawmaterial,forext2_percentaje,forext2_lotnumber,forext2_weigth,forext2_gramaje,forext2_thick) VALUES(";
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
                    queryString += "UPDATE bps_prod_formulationextrusor2";
                    queryString += " SET ";
                    queryString += "forext2_fkformulationreport = " + this.fkformulationreport + ",";
                    queryString += "forext2_rawmaterial = '" + this.rawmaterial.ToString() + "',";
                    queryString += "forext2_percentaje = " + this.percentage.ToString() + ",";
                    queryString += "forext2_lotnumber = '" + this.lotenumber.ToString() + "',";
                    queryString += "forext2_weigth = " + this.weigth.ToString() + "',";
                    queryString += "forext2_gramaje = " + this.gramage + ",";
                    queryString += " WHERE forext2_codsec = " + this.codsec.ToString() + ";";
                }
                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsFormulationExtrusor2.save");
                return false;
            }
        }
        public static int getTotalWeigth(int codsec)
        {
            DataSet DS = new DataSet();
            clsFormulationReport ObjFormulationReport = new clsFormulationReport();
            ObjFormulationReport.load(codsec);
            DS = clsConnection.getDataSetResult("SELECT COALESCE(SUM(forext2_weigth),0) AS weigth FROM bps_prod_formulationextrusor2 WHERE forext2_fkformulationreport = " + ObjFormulationReport.fkproductionorder.ToString());
            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(DS.Tables[0].Rows[0]["weigth"]);
            else
                return 0;
        }
    }
}
