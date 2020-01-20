using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;


namespace BPS.Bussiness
{
    public class clsRawMaterialByFormulation
    {
        //Atributes

        private int rwf_codsec;
        private int rwf_fkRawMaterial;
        private int rwt_fkFormulation;
        private double rwt_percentage;
        private double rwt_globalPercentage;
        private double rwt_consumptionPercentage;
        private Boolean rwt_layerC1;
        private Boolean rwt_layerC2;
        private Boolean rwt_layerC3;
        private Boolean rwt_layerC4;
        private Boolean rwt_CentralLayer;
        private string rwt_name;
        private string rwt_material;

        private string entt_companyName;
        private string rwm_code;
        private string trwm_name;
        private string frml_name;
        private double rwf_weigth;

        private string rwt_lotnumber;

        public string lotnumber
        {
            get { return rwt_lotnumber; }
            set { rwt_lotnumber = value; }
        }


        /*
        bps_prod_formulation.frml_name,
        bps_prod_formulation.frml_thick,
        bps_prod_formulation.frml_thickLayerC1,
        bps_prod_formulation.frml_thickLayerC2,
        bps_prod_formulation.frml_thickCentralLayer
         */

        //Properties

        public int codsec { get { return rwf_codsec; } set { rwf_codsec = value; } }

        public int fkRawMaterial { get { return rwf_fkRawMaterial; } set { rwf_fkRawMaterial = value; } }

        public int fkFormulation { get { return rwt_fkFormulation; } set { rwt_fkFormulation = value; } }

        public double percentage { get { return rwt_percentage; } set { rwt_percentage = value; } }

        public double globalPercentage { get { return rwt_globalPercentage; } set { rwt_globalPercentage = value; } }

        public double consumptionPercentage { get { return rwt_consumptionPercentage; } set { rwt_consumptionPercentage = value; } }

        public Boolean layerC1 { get { return rwt_layerC1; } set { rwt_layerC1 = value; } }

        public Boolean layerC2 { get { return rwt_layerC2; } set { rwt_layerC2 = value; } }

        public Boolean layerC3 { get { return rwt_layerC3; } set { rwt_layerC3 = value; } }

        public Boolean layerC4 { get { return rwt_layerC4; } set { rwt_layerC4 = value; } }

        public Boolean CentralLayer { get { return rwt_CentralLayer; } set { rwt_CentralLayer = value; } }

        public string name { get { return rwt_name; } set { rwt_name = value; } }

        public string material { get { return rwt_material; } set { rwt_material = value; } }

        public string companyName { get { return entt_companyName; } set { entt_companyName = value; } }

        public string code { get { return rwm_code; } set { rwm_code = value; } }

        public string nameTypeFormulation { get { return trwm_name; } set { trwm_name = value; } }

        public string nameFormulation { get { return frml_name; } set { frml_name = value; } }

        public double weigth { get { return rwf_weigth; } set { rwf_weigth = value; } }

        public bool isSummary { get; set; }

        public int fkRaw { get; set; }

        //Constructor

        public clsRawMaterialByFormulation()
        {
            rwf_codsec = 0;
            rwf_fkRawMaterial = 0;
            rwt_fkFormulation = 0;
            rwt_percentage = 0;
            rwt_globalPercentage = 0;
            rwt_consumptionPercentage = 0;
            rwt_layerC1 = false;
            rwt_layerC2 = false;
            rwt_layerC3 = false;
            rwt_layerC4 = false;
            rwt_CentralLayer = false;
            rwt_material = string.Empty;
            entt_companyName = string.Empty;
            rwm_code = "";
            trwm_name = "";
            frml_name = "";
            rwf_weigth = 0;

        }

        public clsRawMaterialByFormulation(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * bps_prod_rawmateriabyformulation FROM  where rwf_fkRawMaterial = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["rwf_codsec"]);
            this.fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[0]["rwf_fkRawMaterial"]);
            this.fkFormulation = Convert.ToInt32(DS.Tables[0].Rows[0]["rwf_fkRawMaterial"]);
            this.percentage = Convert.ToDouble(DS.Tables[0].Rows[0]["rwt_percentage"]);
            this.layerC1 = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["rwt_layerC1"], DS.Tables[0].Rows[0]["rwt_layerC1"].GetType().FullName);
            this.layerC2 = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["rwt_layerC2"], DS.Tables[0].Rows[0]["rwt_layerC2"].GetType().FullName);
            this.layerC3 = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["rwt_layerC3"], DS.Tables[0].Rows[0]["rwt_layerC3"].GetType().FullName);
            this.layerC4 = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["rwt_layerC4"], DS.Tables[0].Rows[0]["rwt_layerC4"].GetType().FullName);
            this.CentralLayer = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["rwt_CentralLayer"], DS.Tables[0].Rows[0]["rwt_CentralLayer"].GetType().FullName);

        }

        //Methods

        public bool save()
        {
            try
            {
                string queryString = "";
                queryString += "INSERT INTO bps_prod_rawmateriabyformulation (rwf_fkRawMaterial,rwt_fkFormulation,rwt_percentage,rwt_layerC1,rwt_layerC2,rwt_layerC3,rwt_layerC4,rwt_CentralLayer, rwf_Weigth, rwt_lotnumber) VALUES(";
                queryString += this.fkRawMaterial.ToString() + ",";
                queryString += this.fkFormulation.ToString() + ",";
                queryString += this.percentage.ToString() + ",";
                queryString += this.layerC1.ToString() + ",";
                queryString += this.layerC2.ToString() + ",";
                queryString += this.layerC3.ToString() + ",";
                queryString += this.layerC4.ToString() + ",";
                queryString += this.CentralLayer.ToString() + ",";
                queryString += this.weigth.ToString() + ",'";
                queryString += this.lotnumber.ToString() + "'";
                queryString += ");";
                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsRawMaterialByFormulation.save");
                return false;
            }


        }

        public static List<clsRawMaterialByFormulation> getListByFormulation(int FormulationCodsec, bool data)
        {
            List<clsRawMaterialByFormulation> lstRawMaterialByFormulation = new List<clsRawMaterialByFormulation>();

            DataSet DS = new DataSet();
            //spFormulationByFilm

            DS = clsConnection.getDataSetResult("spFormulationByFilm " + FormulationCodsec.ToString());


            lstRawMaterialByFormulation.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstRawMaterialByFormulation.Add(new clsRawMaterialByFormulation());
                lstRawMaterialByFormulation[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["rwf_fkRawMaterial"]);
                lstRawMaterialByFormulation[i].companyName = DS.Tables[0].Rows[i]["entt_companyName"].ToString();
                lstRawMaterialByFormulation[i].nameTypeFormulation = DS.Tables[0].Rows[i]["trwm_name"].ToString();
                lstRawMaterialByFormulation[i].material = DS.Tables[0].Rows[i]["rwm_code"].ToString();
                lstRawMaterialByFormulation[i].percentage = Convert.ToDouble(DS.Tables[0].Rows[i]["rwt_percentage"]);
                lstRawMaterialByFormulation[i].rwt_layerC1 = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rwt_layerC1"], DS.Tables[0].Rows[i]["rwt_layerC1"].GetType().FullName);
                lstRawMaterialByFormulation[i].rwt_layerC2 = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rwt_layerC2"], DS.Tables[0].Rows[i]["rwt_layerC2"].GetType().FullName);
                lstRawMaterialByFormulation[i].rwt_layerC3 = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rwt_layerC3"], DS.Tables[0].Rows[i]["rwt_layerC3"].GetType().FullName);
                lstRawMaterialByFormulation[i].rwt_layerC4 = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rwt_layerC4"], DS.Tables[0].Rows[i]["rwt_layerC4"].GetType().FullName);
                lstRawMaterialByFormulation[i].rwt_CentralLayer = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rwt_CentralLayer"], DS.Tables[0].Rows[i]["rwt_CentralLayer"].GetType().FullName);
                lstRawMaterialByFormulation[i].weigth = Convert.ToDouble(DS.Tables[0].Rows[i]["rwf_Weigth"]);
                lstRawMaterialByFormulation[i].lotnumber = DS.Tables[0].Rows[i]["rwt_lotnumber"].ToString();

            }
            return lstRawMaterialByFormulation;

        }

        public static List<clsRawMaterialByFormulation> getListByFormulation(int FormulationCodsec)
        {
            List<clsRawMaterialByFormulation> lstRawMaterialByFormulation = new List<clsRawMaterialByFormulation>();

            DataSet DS = new DataSet();
            //spFormulationByFilm

            DS = clsConnection.getDataSetResult("SELECT rw.rwm_name,rw.rwm_codsec as frml_codsec,rw.rwm_code as frml_name, rwt_percentage as frml_percentage, rwt_layerC1 as frml_C1,rwt_layerC2 as frml_C2,rwt_layerC3 as frml_C3,rwt_layerC4 as frml_C4,rwt_CentralLayer as frml_CentralLayer,frml.frml_thick,frml.frml_thickLayerC1,frml.frml_thickLayerC2,frml.frml_thickCentralLayer, bps_prod_rawmateriabyformulation.rwf_Weigth AS rwf_Weigth, bps_prod_rawmateriabyformulation.rwt_lotnumber AS rwt_lotnumber  FROM bps_prod_rawmateriabyformulation,bps_prod_rawmaterial as rw,bps_prod_formulation as frml where rwf_fkRawMaterial = rw.rwm_codsec and rwt_fkFormulation = frml.frml_codsec and rwt_fkFormulation = " + FormulationCodsec.ToString());

            //DS = clsConnection.getDataSetResult("spFormulationMultiple 'FormulationByCodsec','',0,'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");

            lstRawMaterialByFormulation.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstRawMaterialByFormulation.Add(new clsRawMaterialByFormulation());
                lstRawMaterialByFormulation[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["frml_codsec"]);
                lstRawMaterialByFormulation[i].name = DS.Tables[0].Rows[i]["frml_name"].ToString();
                lstRawMaterialByFormulation[i].material = DS.Tables[0].Rows[i]["rwm_name"].ToString();
                lstRawMaterialByFormulation[i].percentage = Convert.ToDouble(DS.Tables[0].Rows[i]["frml_percentage"]);
                lstRawMaterialByFormulation[i].rwt_layerC1 = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["frml_C1"], DS.Tables[0].Rows[i]["frml_C1"].GetType().FullName);
                lstRawMaterialByFormulation[i].rwt_layerC2 = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["frml_C2"], DS.Tables[0].Rows[i]["frml_C2"].GetType().FullName);
                lstRawMaterialByFormulation[i].rwt_layerC3 = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["frml_C3"], DS.Tables[0].Rows[i]["frml_C3"].GetType().FullName);
                lstRawMaterialByFormulation[i].rwt_layerC4 = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["frml_C4"], DS.Tables[0].Rows[i]["frml_C4"].GetType().FullName);
                lstRawMaterialByFormulation[i].rwt_CentralLayer = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["frml_CentralLayer"], DS.Tables[0].Rows[i]["frml_CentralLayer"].GetType().FullName);
                lstRawMaterialByFormulation[i].weigth = Convert.ToDouble(DS.Tables[0].Rows[i]["rwf_Weigth"]);
                lstRawMaterialByFormulation[i].lotnumber = DS.Tables[0].Rows[i]["rwt_lotnumber"].ToString();
            }
            return lstRawMaterialByFormulation;

        }

        public static List<clsRawMaterialByFormulation> getListByFormulationEdit(int FormulationCodsec)
        {
            List<clsRawMaterialByFormulation> lstRawMaterialByFormulation = new List<clsRawMaterialByFormulation>();

            DataSet DS = new DataSet();
            //spFormulationByFilm

            //DS = clsConnection.getDataSetResult("SELECT rw.rwm_name,rw.rwm_codsec as frml_codsec,rw.rwm_code as frml_name, rwt_percentage as frml_percentage, rwt_layerC1 as frml_C1,rwt_layerC2 as frml_C2,rwt_CentralLayer as frml_CentralLayer,frml.frml_thick,frml.frml_thickLayerC1,frml.frml_thickLayerC2,frml.frml_thickCentralLayer, bps_prod_rawmateriabyformulation.rwf_Weigth AS rwf_Weigth, bps_prod_rawmateriabyformulation.rwt_lotnumber AS rwt_lotnumber  FROM bps_prod_rawmateriabyformulation,bps_prod_rawmaterial as rw,bps_prod_formulation as frml where rwf_fkRawMaterial = rw.rwm_codsec and rwt_fkFormulation = frml.frml_codsec and rwt_fkFormulation = " + FormulationCodsec.ToString());

            DS = clsConnection.getDataSetResult("spFormulationMultiple 'FormulationByCodsec',''," + FormulationCodsec.ToString() + ",'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");

            lstRawMaterialByFormulation.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstRawMaterialByFormulation.Add(new clsRawMaterialByFormulation());
                lstRawMaterialByFormulation[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["rwf_codsec"]);
                lstRawMaterialByFormulation[i].fkRawMaterial = Convert.ToInt32(DS.Tables[0].Rows[i]["rwf_fkRawMaterial"]);
                lstRawMaterialByFormulation[i].nameFormulation = DS.Tables[0].Rows[i]["trwm_name"].ToString();
                lstRawMaterialByFormulation[i].name = DS.Tables[0].Rows[i]["rwm_name"].ToString();
                lstRawMaterialByFormulation[i].material = DS.Tables[0].Rows[i]["rwm_code"].ToString();
                lstRawMaterialByFormulation[i].percentage = Convert.ToDouble(DS.Tables[0].Rows[i]["rwt_percentage"]);
                lstRawMaterialByFormulation[i].rwt_layerC1 = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rwt_layerC1"], DS.Tables[0].Rows[i]["rwt_layerC1"].GetType().FullName);
                lstRawMaterialByFormulation[i].rwt_layerC2 = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rwt_layerC2"], DS.Tables[0].Rows[i]["rwt_layerC2"].GetType().FullName);
                lstRawMaterialByFormulation[i].rwt_layerC3 = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rwt_layerC3"], DS.Tables[0].Rows[i]["rwt_layerC3"].GetType().FullName);
                lstRawMaterialByFormulation[i].rwt_layerC4 = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rwt_layerC4"], DS.Tables[0].Rows[i]["rwt_layerC4"].GetType().FullName);
                lstRawMaterialByFormulation[i].rwt_CentralLayer = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rwt_CentralLayer"], DS.Tables[0].Rows[i]["rwt_CentralLayer"].GetType().FullName);
                lstRawMaterialByFormulation[i].weigth = Convert.ToDouble(DS.Tables[0].Rows[i]["rwf_Weigth"]);
                lstRawMaterialByFormulation[i].lotnumber = DS.Tables[0].Rows[i]["rwt_lotnumber"].ToString();
            }
            return lstRawMaterialByFormulation;

        }

        public bool saveReaload()
        {
            try
            {
                string queryString = "";
                queryString += "INSERT INTO bps_prod_rawmaterialbyformulationreload (rwf_fkRawMaterial,rwt_fkFormulation,rwt_percentage,rwt_layerC1,rwt_layerC2,rwt_layerC3,rwt_layerC4,rwt_CentralLayer, rwf_Weigth, rwt_lotnumber,rwt_isSummary,rwt_fkRaw, rwt_date) VALUES(";
                queryString += this.fkRawMaterial.ToString() + ",";
                queryString += this.fkFormulation.ToString() + ",";
                queryString += this.percentage.ToString() + ",";
                queryString += this.layerC1.ToString() + ",";
                queryString += this.layerC2.ToString() + ",";
                queryString += this.layerC3.ToString() + ",";
                queryString += this.layerC4.ToString() + ",";
                queryString += this.CentralLayer.ToString() + ",";
                queryString += this.weigth.ToString() + ",'";
                queryString += this.lotnumber.ToString() + "',";
                queryString += this.isSummary.ToString() + ",";
                queryString += this.fkRaw.ToString() + ",";
                queryString += "GETDATE()";
                queryString += ");";
                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsRawMaterialByFormulation.save");
                return false;
            }
        }

        public static List<clsRawMaterialByFormulation> getListByFormulationExtruder(int fkFilmProduction)
        {
            DataSet DS = new DataSet();
            List<clsRawMaterialByFormulation> rmList = new List<clsRawMaterialByFormulation>();

            DS = clsConnection.getDataSetResult("SELECT TOP(1) COALESCE(fpfpp_fkFormulation,0) AS fpfpp_fkFormulation FROM  bps_prod_formulationperfilmproductionplanreload WHERE fpfpp_fkFilmProductionPlan = " + fkFilmProduction.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                var formulation = DS.Tables[0].Rows[0][0].ToString();
                DS.Clear();
                DS = clsConnection.getDataSetResult("spRequestUserMultiple 'rawLayerList'," + formulation + ",'','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    rmList.Add(new clsRawMaterialByFormulation());
                    rmList[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["rwf_codsec"]);
                    rmList[i].layerC1 = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rwt_layerC1"], DS.Tables[0].Rows[i]["rwt_layerC1"].GetType().FullName);
                    rmList[i].layerC2 = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rwt_layerC2"], DS.Tables[0].Rows[i]["rwt_layerC2"].GetType().FullName);
                    rmList[i].layerC3 = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rwt_layerC3"], DS.Tables[0].Rows[i]["rwt_layerC3"].GetType().FullName);
                    rmList[i].layerC4 = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rwt_layerC4"], DS.Tables[0].Rows[i]["rwt_layerC4"].GetType().FullName);
                    rmList[i].CentralLayer = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rwt_CentralLayer"], DS.Tables[0].Rows[i]["rwt_CentralLayer"].GetType().FullName);
                    rmList[i].weigth = Convert.ToDouble(DS.Tables[0].Rows[i]["rwf_Weigth"]);
                    rmList[i].lotnumber = DS.Tables[0].Rows[i]["rwt_lotnumber"].ToString();
                    rmList[i].fkRaw = Convert.ToInt32(DS.Tables[0].Rows[i]["rwt_fkRaw"]);
                    rmList[i].material = DS.Tables[0].Rows[i]["rwmc_rawmaterialproduct"].ToString();
                    rmList[i].code = DS.Tables[0].Rows[i]["rwmc_code"].ToString();
                    rmList[i].provider = DS.Tables[0].Rows[i]["rwmc_provider"].ToString();
                    rmList[i].isReProcess = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rwmc_isReProcess"], DS.Tables[0].Rows[i]["rwmc_isReProcess"].GetType().FullName);
                    rmList[i].fkOrigin = Convert.ToInt32(DS.Tables[0].Rows[i]["rwmc_fkOrigin"]);
                    rmList[i].fkFormulation = Convert.ToInt32(formulation);

                }
            }

            return rmList;
        }

        public string provider { get; set; }

        public bool isReProcess { get; set; }

        public int fkOrigin { get; set; }

        public static bool toDeleteMPCL(string codsec, string fkformulation, string lot, string Layer)
        {
            bool isValid = true;
            string queryString = "";

            queryString += "DELETE FROM bps_prod_rawmaterialbyformulationreload ";
            queryString += " WHERE rwf_codsec = " + codsec + ";";

            isValid = clsConnection.executeQuery(queryString);

            queryString = "";

            switch (Layer)
            {
                case "CL":

                    queryString += "DELETE FROM bps_prod_rawmaterialbyformulationreload WHERE rwt_CentralLayer = 1 AND rwt_fkFormulation = " + fkformulation +
                        " AND rwt_lotnumber = '" + lot + "' AND rwt_isSummary = 1;";

                    clsConnection.executeQuery(queryString);

                    clsSummaryRM.getSummarytoDelete(fkformulation, 1, 0, 0, 0, 0);
                    break;

                case "L1":

                    queryString += "DELETE FROM bps_prod_rawmaterialbyformulationreload WHERE rwt_layerC1 = 1 AND rwt_fkFormulation = " + fkformulation +
                        " AND rwt_lotnumber = '" + lot + "' AND rwt_isSummary = 1;";

                    clsConnection.executeQuery(queryString);

                    clsSummaryRM.getSummarytoDelete(fkformulation, 0, 1, 0, 0, 0);
                    break;

                case "L2":

                    queryString += "DELETE FROM bps_prod_rawmaterialbyformulationreload WHERE rwt_layerC2 = 1 AND rwt_fkFormulation = " + fkformulation +
                       " AND rwt_lotnumber = '" + lot + "' AND rwt_isSummary = 1;";

                    clsConnection.executeQuery(queryString);

                    clsSummaryRM.getSummarytoDelete(fkformulation, 0, 0, 1, 0, 0);
                    break;

                case "L3":

                    queryString += "DELETE FROM bps_prod_rawmaterialbyformulationreload WHERE rwt_layerC3 = 1 AND rwt_fkFormulation = " + fkformulation +
                       " AND rwt_lotnumber = '" + lot + "' AND rwt_isSummary = 1;";

                    clsConnection.executeQuery(queryString);

                    clsSummaryRM.getSummarytoDelete(fkformulation, 0, 0, 0, 1, 0);
                    break;

                case "L4":

                    queryString += "DELETE FROM bps_prod_rawmaterialbyformulationreload WHERE rwt_layerC4 = 1 AND rwt_fkFormulation = " + fkformulation +
                       " AND rwt_lotnumber = '" + lot + "' AND rwt_isSummary = 1;";

                    clsConnection.executeQuery(queryString);

                    clsSummaryRM.getSummarytoDelete(fkformulation, 0, 0, 0, 0, 1);
                    break;

                default:
                    break;
            }

            return isValid;
        }

        public static List<clsRawMaterialByFormulation> getListByFormulationExtruderPlus(int fkFilmProduction)
        {
            DataSet DS = new DataSet();
            List<clsRawMaterialByFormulation> rmList = new List<clsRawMaterialByFormulation>();

            DS = clsConnection.getDataSetResult("SELECT TOP(1) COALESCE(fpfpp_fkFormulation,0) AS fpfpp_fkFormulation FROM  bps_prod_formulationperfilmproductionplanreload WHERE fpfpp_fkFilmProductionPlan = " + fkFilmProduction.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                var formulation = DS.Tables[0].Rows[0][0].ToString();
                DS.Clear();
                DS = clsConnection.getDataSetResult("spRequestUserMultiple 'rawLayerListEXT'," + formulation + ",'','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    rmList.Add(new clsRawMaterialByFormulation());
                    rmList[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["rwf_codsec"]);
                    rmList[i].layerC1 = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rwt_layerC1"], DS.Tables[0].Rows[i]["rwt_layerC1"].GetType().FullName);
                    rmList[i].layerC2 = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rwt_layerC2"], DS.Tables[0].Rows[i]["rwt_layerC2"].GetType().FullName);
                    rmList[i].layerC3 = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rwt_layerC3"], DS.Tables[0].Rows[i]["rwt_layerC3"].GetType().FullName);
                    rmList[i].layerC4 = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rwt_layerC4"], DS.Tables[0].Rows[i]["rwt_layerC4"].GetType().FullName);
                    rmList[i].CentralLayer = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rwt_CentralLayer"], DS.Tables[0].Rows[i]["rwt_CentralLayer"].GetType().FullName);
                    rmList[i].weigth = Convert.ToDouble(DS.Tables[0].Rows[i]["rwf_Weigth"]);
                    rmList[i].lotnumber = DS.Tables[0].Rows[i]["rwt_lotnumber"].ToString();
                    rmList[i].fkRaw = Convert.ToInt32(DS.Tables[0].Rows[i]["rwt_fkRaw"]);
                    rmList[i].material = DS.Tables[0].Rows[i]["rwmc_rawmaterialproduct"].ToString();
                    rmList[i].code = DS.Tables[0].Rows[i]["rw_code"].ToString();
                    rmList[i].provider = DS.Tables[0].Rows[i]["rwmc_provider"].ToString();
                    rmList[i].isReProcess = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["rw_isSon"], DS.Tables[0].Rows[i]["rw_isSon"].GetType().FullName);
                    rmList[i].fkOrigin = Convert.ToInt32(DS.Tables[0].Rows[i]["rwmc_fkOrigin"]);
                    rmList[i].fkFormulation = Convert.ToInt32(formulation);

                }
            }

            return rmList;
        }
    }
}
