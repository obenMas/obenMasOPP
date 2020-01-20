using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsFormulationRawMaterial
    {
         //Atributes
        private int forraw_codsec;
        private int forraw_fkproductionorder;
        private string forraw_rawname;
        private string forraw_rawmaterial;
        private double forraw_teorical;
        private double forraw_real;
        
        
        //Properties

        public int codsec { get { return forraw_codsec; } set { forraw_codsec = value; } }

        public int fkproductionorder { get { return forraw_fkproductionorder; } set { forraw_fkproductionorder = value; } }

        public string name { get { return forraw_rawname; } set { forraw_rawname = value; } }

        public string material { get { return forraw_rawmaterial; } set { forraw_rawmaterial = value; } }

        public double teorical { get { return forraw_teorical; } set { forraw_teorical = value; } }

        public double real { get { return forraw_real; } set { forraw_real = value; } }


        //Constructor

        public clsFormulationRawMaterial()
        {
            forraw_codsec = 0;
            forraw_fkproductionorder = 0;
            forraw_rawname = string.Empty;
            forraw_rawmaterial = string.Empty;
            forraw_teorical = 0;
            forraw_real = 0;
        }

        public clsFormulationRawMaterial(int codsec)
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
                    queryString += "INSERT INTO bps_prod_formulationrawmaterial (forraw_fkproductionorder,forraw_rawname,forraw_rawmaterial,forraw_teorical,forraw_real) VALUES(";
                    queryString += this.fkproductionorder.ToString() + ",";
                    queryString += "'" + this.name + "',";
                    queryString += "'" + this.material + "',";
                    queryString += this.teorical.ToString() + ",";
                    queryString += this.real.ToString();
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_formulationrawmaterial";
                    queryString += " SET ";
                    queryString += "forraw_fkproductionorder = " + this.fkproductionorder + ",";
                    queryString += "forraw_rawname = '" + this.name.ToString() + "',";
                    queryString += "forraw_rawmaterial = '" + this.material.ToString() + "',";
                    queryString += "forraw_teorical = " + this.teorical.ToString() + ",";
                    queryString += "forraw_real = " + this.real + ",";
                    queryString += " WHERE forraw_codsec = " + this.codsec.ToString() + ";";
                }
                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsFormulationExtrusor1.save");
                return false;
            }
        }
        //public static int getTotalWeigth(int codsec)
        //{
        //    DataSet DS = new DataSet();
        //    clsFormulationReport ObjFormulationReport = new clsFormulationReport();
        //    ObjFormulationReport.load(codsec);
        //    DS = clsConnection.getDataSetResult("SELECT SUM(forext1_weigth) AS weigth FROM bps_prod_formulationextrusor1 WHERE forext1_fkformulationreport = " + ObjFormulationReport.fkproductionorder.ToString());
        //    if (DS.Tables[0].Rows.Count > 0)
        //        return Convert.ToInt32(DS.Tables[0].Rows[0]["weigth"]);
        //    else
        //        return 0;
        //}
    }
}
