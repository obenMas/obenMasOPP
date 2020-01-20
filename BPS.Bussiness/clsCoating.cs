using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que maneja peliculas BOPP
    /// </summary>
    public class clsCoating
    {
        //Atributes

        private int coat_codsec;
        private int coat_fkProcess;
        private clsProcess coat_Process;
        private string coat_ProcessName;
        private int coat_fkSubProcess;
        private clsProcess coat_SubProcess;
        private string coat_SubProcessName;
        private int coat_fkTerminationStructure;
        private clsStructure coat_TerminationStructure;
        private string coat_TerminationStructureName;
        private int coat_fkCoatingStructure;
        private clsStructure coat_CoatingStructure;
        private string coat_CoatingStructureName;
        private int coat_fkSubstrateThickness;
        private clsThickness coat_SubstrateThickness;
        private string coat_SubstrateThicknessValue;
        private int coat_fkCoatThickness;
        private clsThickness coat_CoatThickness;
        private string coat_CoatThicknessValue;
        private int coat_fkTreatment;
        private clsTreatment coat_Treatment;
        private string coat_TreatmentName;
        private string coat_name;
        private string coat_code;
        private int coat_leadTime;

         //Properties

        public int codsec { get { return coat_codsec; } set { coat_codsec = value; } }

        public int fkProcess { get { return coat_fkProcess; } set { coat_fkProcess = value; } }

        public clsProcess Process { get { return coat_Process; } set { coat_Process = value; } }

        public int fkSubProcess { get { return coat_fkSubProcess; } set { coat_fkSubProcess = value; } }

        public clsProcess SubProcess { get { return coat_SubProcess; } set { coat_SubProcess = value; } }

        public int fkTerminationStructure { get { return coat_fkTerminationStructure; } set { coat_fkTerminationStructure = value; } }

        public clsStructure TerminationStructure { get { return coat_TerminationStructure; } set { coat_TerminationStructure = value; } }

        public int fkCoatingStructure { get { return coat_fkCoatingStructure; } set { coat_fkCoatingStructure = value; } }

        public clsStructure CoatingStructure { get { return coat_CoatingStructure; } set { coat_CoatingStructure = value; } }

        public int fkSubstrateThickness { get { return coat_fkSubstrateThickness; } set { coat_fkSubstrateThickness = value; } }

        public clsThickness SubstrateThickness { get { return coat_SubstrateThickness; } set { coat_SubstrateThickness = value; } }

        public int fkCoatThickness { get { return coat_fkCoatThickness; } set { coat_fkCoatThickness = value; } }

        public clsThickness CoatThickness { get { return coat_CoatThickness; } set { coat_CoatThickness = value; } }

        public int fkTreatment { get { return coat_fkTreatment; } set { coat_fkTreatment = value; } }

        public clsTreatment Treatment { get { return coat_Treatment; } set { coat_Treatment = value; } }

        public string name { get { return coat_name; } set { coat_name = value; } }

        public string code { get { return coat_code; } set { coat_code = value; } }

        public string ProcessName { get { return coat_ProcessName; } set { coat_ProcessName = value; } }

        public string SubProcessName { get { return coat_SubProcessName; } set { coat_SubProcessName = value; } }

        public string TerminationStructureName { get { return coat_TerminationStructureName; } set { coat_TerminationStructureName = value; } }

        public string CoatingStructureName { get { return coat_CoatingStructureName; } set { coat_CoatingStructureName = value; } }

        public string SubstrateThicknessValue { get { return coat_SubstrateThicknessValue; } set { coat_SubstrateThicknessValue = value; } }

        public string CoatThicknessValue { get { return coat_CoatThicknessValue; } set { coat_CoatThicknessValue = value; } }

        public string TreatmentName { get { return coat_TreatmentName; } set { coat_TreatmentName = value; } }

        public int leadTime { get { return coat_leadTime; } set { coat_leadTime = value; } }


        //Constructor

        public clsCoating()
        { 
            coat_codsec = 0;
            coat_fkProcess = 0;
            coat_Process = new clsProcess();
            coat_ProcessName = "";
            coat_fkSubProcess = 0;
            coat_SubProcess = new clsProcess();
            coat_SubProcessName = "";
            coat_fkTerminationStructure = 0;
            coat_TerminationStructure = new clsStructure();
            coat_TerminationStructureName = "";
            coat_fkCoatingStructure = 0;
            coat_CoatingStructure = new clsStructure();
            coat_CoatingStructureName = "";
            coat_fkSubstrateThickness = 0;
            coat_SubstrateThickness = new clsThickness();
            coat_SubstrateThicknessValue = "";
            coat_fkCoatThickness = 0;
            coat_CoatThickness = new clsThickness();
            coat_CoatThicknessValue = "";
            coat_fkTreatment = 0;
            coat_Treatment = new clsTreatment();
            coat_TreatmentName = "";
            coat_name = "";
            coat_code = "";
            coat_leadTime = 0;
        }
        public clsCoating(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwcoatingfilm where coat_codsec = " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["coat_codsec"]);
                this.fkProcess = Convert.ToInt32(DS.Tables[0].Rows[0]["coat_fkProcess"]);
                this.Process = new clsProcess(Convert.ToInt32(DS.Tables[0].Rows[0]["coat_fkProcess"]));
                this.ProcessName = DS.Tables[0].Rows[0]["coat_ProcessName"].ToString();
                this.fkSubProcess = Convert.ToInt32(DS.Tables[0].Rows[0]["coat_fkSubProcess"]);
                this.SubProcess = new clsProcess(Convert.ToInt32(DS.Tables[0].Rows[0]["coat_fkSubProcess"]));
                this.SubProcessName = DS.Tables[0].Rows[0]["coat_SubProcessName"].ToString();
                this.fkTerminationStructure = Convert.ToInt32(DS.Tables[0].Rows[0]["coat_fkTerminationStructure"]);
                this.TerminationStructure = new clsStructure(Convert.ToInt32(DS.Tables[0].Rows[0]["coat_fkTerminationStructure"]));
                this.TerminationStructureName = DS.Tables[0].Rows[0]["coat_TerminationStructureName"].ToString();
                this.fkCoatingStructure = Convert.ToInt32(DS.Tables[0].Rows[0]["coat_fkCoatingStructure"]);
                this.CoatingStructure = new clsStructure(Convert.ToInt32(DS.Tables[0].Rows[0]["coat_fkCoatingStructure"]));
                this.CoatingStructureName = DS.Tables[0].Rows[0]["coat_CoatingStructureName"].ToString();
                this.fkSubstrateThickness = Convert.ToInt32(DS.Tables[0].Rows[0]["coat_fkSubstrateThickness"]);
                this.SubstrateThickness = new clsThickness(Convert.ToInt32(DS.Tables[0].Rows[0]["coat_fkSubstrateThickness"]));
                this.SubstrateThicknessValue = DS.Tables[0].Rows[0]["coat_SubstrateThicknessValue"].ToString();
                this.fkCoatThickness = Convert.ToInt32(DS.Tables[0].Rows[0]["coat_fkCoatThickness"]);
                this.CoatThickness = new clsThickness(Convert.ToInt32(DS.Tables[0].Rows[0]["coat_fkCoatThickness"]));
                this.CoatThicknessValue = DS.Tables[0].Rows[0]["coat_CoatThicknessValue"].ToString();
                this.fkTreatment = Convert.ToInt32(DS.Tables[0].Rows[0]["coat_fkTreatment"]);
                this.Treatment = new clsTreatment(Convert.ToInt32(DS.Tables[0].Rows[0]["coat_fkTreatment"]));
                this.TreatmentName = DS.Tables[0].Rows[0]["coat_TreatmentName"].ToString();
                this.name = DS.Tables[0].Rows[0]["coat_name"].ToString();
                this.code = DS.Tables[0].Rows[0]["coat_code"].ToString();
                this.leadTime = Convert.ToInt32(DS.Tables[0].Rows[0]["coat_leadTime"]);
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_coating (coat_fkProcess,coat_fkSubProcess,coat_fkTerminationStructure,coat_fkCoatingStructure, coat_fkSubstrateThickness,coat_fkCoatThickness, coat_fkTreatment,coat_name,coat_code,coat_leadTime)";
                    queryString += " VALUES (";
                    queryString += this.fkProcess.ToString() + ",";
                    queryString += this.fkSubProcess.ToString() + ",";
                    queryString += this.fkTerminationStructure.ToString() + ",";
                    queryString += this.fkCoatingStructure.ToString() + ",";
                    queryString += this.fkSubstrateThickness.ToString() + ",";
                    queryString += this.fkCoatThickness.ToString() + ",";
                    queryString += this.fkTreatment.ToString() + ",";
                    queryString += "'" + this.name + "',";
                    queryString += "'" + this.code + "',";
                    queryString += this.leadTime.ToString() + "";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_prod_coating";
                    queryString += " SET ";
                    queryString += "coat_fkProcess = " + this.fkProcess.ToString() + ",";
                    queryString += "coat_fkSubProcess = " + this.fkSubProcess.ToString() + ",";
                    queryString += "coat_fkTerminationStructure = " + this.fkTerminationStructure.ToString() + ",";
                    queryString += "coat_fkCoatingStructure = " + this.fkCoatingStructure.ToString() + ",";
                    queryString += "coat_fkSubstrateThickness = " + this.fkSubstrateThickness.ToString() + ",";
                    queryString += "coat_fkCoatThickness = " + this.fkCoatThickness.ToString() + ",";
                    queryString += "coat_fkTreatment = " + this.fkTreatment.ToString() + ",";
                    queryString += "coat_name = '" + this.name + "',";
                    queryString += "coat_code = '" + this.code + "',";
                    queryString += "coat_leadTime = " + this.leadTime.ToString() + "";
                    queryString += " WHERE coat_codsec = ;" + this.codsec.ToString();
                    clsConnection.executeQuery(queryString);
                }
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCoating.save");
                return false;
            }
        }

        public static List<clsCoating> getList()
        {
            List<clsCoating> lstCoating = new List<clsCoating>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwcoatingList ORDER BY coat_name");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstCoating.Add(new clsCoating());
                lstCoating[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["coat_codsec"]);
                lstCoating[i].fkProcess = Convert.ToInt32(DS.Tables[0].Rows[i]["coat_fkProcess"]);
                lstCoating[i].Process = new clsProcess(Convert.ToInt32(DS.Tables[0].Rows[i]["coat_fkProcess"]));
                lstCoating[i].ProcessName = DS.Tables[0].Rows[i]["coat_ProcessName"].ToString();
                lstCoating[i].fkSubProcess = Convert.ToInt32(DS.Tables[0].Rows[i]["coat_fkSubProcess"]);
                lstCoating[i].SubProcess = new clsProcess(Convert.ToInt32(DS.Tables[0].Rows[i]["coat_fkSubProcess"]));
                lstCoating[i].SubProcessName = DS.Tables[0].Rows[i]["coat_SubProcessName"].ToString();
                lstCoating[i].fkTerminationStructure = Convert.ToInt32(DS.Tables[0].Rows[i]["coat_fkTerminationStructure"]);
                lstCoating[i].TerminationStructure = new clsStructure(Convert.ToInt32(DS.Tables[0].Rows[i]["coat_fkTerminationStructure"]));
                lstCoating[i].TerminationStructureName = DS.Tables[0].Rows[i]["coat_TerminationStructureName"].ToString();
                lstCoating[i].fkCoatingStructure = Convert.ToInt32(DS.Tables[0].Rows[i]["coat_fkCoatingStructure"]);
                lstCoating[i].CoatingStructure = new clsStructure(Convert.ToInt32(DS.Tables[0].Rows[i]["coat_fkCoatingStructure"]));
                lstCoating[i].CoatingStructureName = DS.Tables[0].Rows[i]["coat_CoatingStructureName"].ToString();
                lstCoating[i].fkSubstrateThickness = Convert.ToInt32(DS.Tables[0].Rows[i]["coat_fkSubstrateThickness"]);
                lstCoating[i].SubstrateThickness = new clsThickness(Convert.ToInt32(DS.Tables[0].Rows[i]["coat_fkSubstrateThickness"]));
                lstCoating[i].SubstrateThicknessValue = DS.Tables[0].Rows[i]["coat_SubstrateThicknessValue"].ToString();
                lstCoating[i].fkCoatThickness = Convert.ToInt32(DS.Tables[0].Rows[i]["coat_fkCoatThickness"]);
                lstCoating[i].CoatThickness = new clsThickness(Convert.ToInt32(DS.Tables[0].Rows[i]["coat_fkCoatThickness"]));
                lstCoating[i].CoatThicknessValue = DS.Tables[0].Rows[i]["coat_CoatThicknessValue"].ToString();
                lstCoating[i].fkTreatment = Convert.ToInt32(DS.Tables[0].Rows[i]["coat_fkTreatment"]);
                lstCoating[i].Treatment = new clsTreatment(Convert.ToInt32(DS.Tables[0].Rows[i]["coat_fkTreatment"]));
                lstCoating[i].TreatmentName = DS.Tables[0].Rows[i]["coat_TreatmentName"].ToString();
                lstCoating[i].name = DS.Tables[0].Rows[i]["coat_name"].ToString();
                lstCoating[i].code = DS.Tables[0].Rows[i]["coat_code"].ToString();
                lstCoating[i].leadTime = Convert.ToInt32(DS.Tables[0].Rows[i]["coat_leadTime"]);
            }
            return lstCoating;
        }
        public static List<clsCoating> getSimplifiedList()
        {
            List<clsCoating> lstCoating = new List<clsCoating>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwcoatingList ORDER BY coat_name");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstCoating.Add(new clsCoating());
                lstCoating[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["coat_codsec"]);
                lstCoating[i].fkProcess = Convert.ToInt32(DS.Tables[0].Rows[i]["coat_fkProcess"]);
                lstCoating[i].ProcessName = DS.Tables[0].Rows[i]["coat_ProcessName"].ToString();
                lstCoating[i].fkSubProcess = Convert.ToInt32(DS.Tables[0].Rows[i]["coat_fkSubProcess"]);
                lstCoating[i].SubProcessName = DS.Tables[0].Rows[i]["coat_SubProcessName"].ToString();
                lstCoating[i].fkTerminationStructure = Convert.ToInt32(DS.Tables[0].Rows[i]["coat_fkTerminationStructure"]);
                lstCoating[i].TerminationStructureName = DS.Tables[0].Rows[i]["coat_TerminationStructureName"].ToString();
                lstCoating[i].fkCoatingStructure = Convert.ToInt32(DS.Tables[0].Rows[i]["coat_fkCoatingStructure"]);
                lstCoating[i].CoatingStructureName = DS.Tables[0].Rows[i]["coat_CoatingStructureName"].ToString();
                lstCoating[i].fkSubstrateThickness = Convert.ToInt32(DS.Tables[0].Rows[i]["coat_fkSubstrateThickness"]);
                lstCoating[i].SubstrateThicknessValue = DS.Tables[0].Rows[i]["coat_SubstrateThicknessValue"].ToString();
                lstCoating[i].fkCoatThickness = Convert.ToInt32(DS.Tables[0].Rows[i]["coat_fkCoatThickness"]);
                lstCoating[i].CoatThicknessValue = DS.Tables[0].Rows[i]["coat_CoatThicknessValue"].ToString();
                lstCoating[i].fkTreatment = Convert.ToInt32(DS.Tables[0].Rows[i]["coat_fkTreatment"]);
                lstCoating[i].TreatmentName = DS.Tables[0].Rows[i]["coat_TreatmentName"].ToString();
                lstCoating[i].name = DS.Tables[0].Rows[i]["coat_name"].ToString();
                lstCoating[i].code = DS.Tables[0].Rows[i]["coat_code"].ToString();
                lstCoating[i].leadTime = Convert.ToInt32(DS.Tables[0].Rows[i]["coat_leadTime"]);
            }
            return lstCoating;
        }
        public override string ToString()
        {
            return "[" + this.code + "] " + this.name;
        }

        public static int getFlmByCode(string code)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT bps_prod_coating.coat_codsec FROM bps_prod_coating WHERE bps_prod_coating.coat_code = '" + code + "'");

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {

                return Convert.ToInt32(DS.Tables[0].Rows[0]["coat_codsec"]);
            }
            else
            {
                return 0;
            }
        }

    }
}
