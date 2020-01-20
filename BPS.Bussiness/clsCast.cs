using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que maneja peliculas Cast
    /// </summary>
    public class clsCast
    {
        //Atributes

        private int cpp_codsec;
        private int cpp_fkProcess;
        private clsProcess cpp_Process;
        private string cpp_ProcessName;
        private int cpp_fkSubProcess;
        private clsProcess cpp_SubProcess;
        private string cpp_SubProcessName;
        private int cpp_fkCentralStructure;
        private clsStructure cpp_CentralStructure;
        private string cpp_CentralStructureName;
        private int cpp_fkSurfaceStructure;
        private clsStructure cpp_SurfaceStructure;
        private string cpp_SurfaceStructureName;
        private int cpp_fkCentralAdditivation;
        private clsAdditivation cpp_CentralAdditivation;
        private string cpp_CentralAdditivationName;
        private int cpp_fkSurfaceAdditivation;
        private clsAdditivation cpp_SurfaceAdditivation;
        private string cpp_SurfaceAdditivationName;
        private int cpp_fkThickness;
        private clsThickness cpp_Thickness;
        private string cpp_ThicknessValue;
        private int cpp_fkTreatment;
        private clsTreatment cpp_Treatment;
        private string cpp_TreatmentName;
        private string cpp_name;
        private string cpp_code;

        private double cpp_salesOrderQuantity;
        private double cpp_mainCoilQuantity;
        
        private string cpp_externalID;
        private string cpp_externalDescription;
        private string cpp_externalCode;

        private bool cpp_isNylon;
        private int cpp_leadTime;

        public bool isNylon
        {
            get { return cpp_isNylon; }
            set { cpp_isNylon = value; }
        }



        //Properties

        public int codsec { get { return cpp_codsec; } set { cpp_codsec = value; } }

        public int fkProcess { get { return cpp_fkProcess; } set { cpp_fkProcess = value; } }

        public clsProcess Process { get { return cpp_Process; } set { cpp_Process = value; } }

        public int fkSubProcess { get { return cpp_fkSubProcess; } set { cpp_fkSubProcess = value; } }

        public clsProcess SubProcess { get { return cpp_SubProcess; } set { cpp_SubProcess = value; } }

        public int fkCentralStructure { get { return cpp_fkCentralStructure; } set { cpp_fkCentralStructure = value; } }

        public clsStructure CentralStructure { get { return cpp_CentralStructure; } set { cpp_CentralStructure = value; } }

        public int fkSurfaceStructure { get { return cpp_fkSurfaceStructure; } set { cpp_fkSurfaceStructure = value; } }

        public clsStructure SurfaceStructure { get { return cpp_SurfaceStructure; } set { cpp_SurfaceStructure = value; } }

        public int fkCentralAdditivation { get { return cpp_fkCentralAdditivation; } set { cpp_fkCentralAdditivation = value; } }

        public clsAdditivation CentralAdditivation { get { return cpp_CentralAdditivation; } set { cpp_CentralAdditivation = value; } }

        public int fkSurfaceAdditivation { get { return cpp_fkSurfaceAdditivation; } set { cpp_fkSurfaceAdditivation = value; } }

        public clsAdditivation SurfaceAdditivation { get { return cpp_SurfaceAdditivation; } set { cpp_SurfaceAdditivation = value; } }

        public int fkThickness { get { return cpp_fkThickness; } set { cpp_fkThickness = value; } }

        public clsThickness Thickness { get { return cpp_Thickness; } set { cpp_Thickness = value; } }

        public int fkTreatment { get { return cpp_fkTreatment; } set { cpp_fkTreatment = value; } }

        public clsTreatment Treatment { get { return cpp_Treatment; } set { cpp_Treatment = value; } }

        public string name { get { return cpp_name; } set { cpp_name = value; } }

        public string code { get { return cpp_code; } set { cpp_code = value; } }

        public string ProcessName { get { return cpp_ProcessName; } set { cpp_ProcessName = value; } }

        public string SubProcessName { get { return cpp_SubProcessName; } set { cpp_SubProcessName = value; } }

        public string CentralStructureName { get { return cpp_CentralStructureName; } set { cpp_CentralStructureName = value; } }

        public string SurfaceStructureName { get { return cpp_SurfaceStructureName; } set { cpp_SurfaceStructureName = value; } }

        public string CentralAdditivationName { get { return cpp_CentralAdditivationName; } set { cpp_CentralAdditivationName = value; } }

        public string SurfaceAdditivationName { get { return cpp_SurfaceAdditivationName; } set { cpp_SurfaceAdditivationName = value; } }

        public string ThicknessValue { get { return cpp_ThicknessValue; } set { cpp_ThicknessValue = value; } }

        public string TreatmentName { get { return cpp_TreatmentName; } set { cpp_TreatmentName = value; } }

        public double salesOrderQuantity { get { return cpp_salesOrderQuantity; } set { cpp_salesOrderQuantity = value; } }

        public double mainCoilQuantity { get { return cpp_mainCoilQuantity; } set { cpp_mainCoilQuantity = value; } }

        public string externalID { get { return cpp_externalID; } set { cpp_externalID = value; } }

        public string externalDescription { get { return cpp_externalDescription; } set { cpp_externalDescription = value; } }

        public string externalCode { get { return cpp_externalCode; } set { cpp_externalCode = value; } }

        public int leadTime { get { return cpp_leadTime; } set { cpp_leadTime = value; } }


        //Constructor

        public clsCast()

        {
            
            cpp_codsec = 0;
            cpp_fkProcess = 0;
            cpp_Process = new clsProcess();
            cpp_ProcessName = "";
            cpp_fkSubProcess = 0;
            cpp_SubProcess = new clsProcess();
            cpp_SubProcessName = "";
            cpp_fkCentralStructure = 0;
            cpp_CentralStructure = new clsStructure();
            cpp_CentralStructureName = "";
            cpp_fkSurfaceStructure = 0;
            cpp_SurfaceStructure = new clsStructure();
            cpp_SurfaceAdditivationName = "";
            cpp_fkCentralAdditivation = 0;
            cpp_CentralAdditivation = new clsAdditivation();
            cpp_CentralStructureName = "";
            cpp_fkSurfaceAdditivation = 0;
            cpp_SurfaceAdditivation = new clsAdditivation();
            cpp_SurfaceAdditivationName = "";
            cpp_fkThickness = 0;
            cpp_Thickness = new clsThickness();
            cpp_ThicknessValue = "";
            cpp_fkTreatment = 0;
            cpp_Treatment = new clsTreatment();
            cpp_TreatmentName = "";
            cpp_name = "";
            cpp_code = "";

            cpp_salesOrderQuantity = 0;
            cpp_mainCoilQuantity = 0;

            cpp_externalID = "";
            cpp_externalDescription = "";
            cpp_externalCode = "";

            cpp_isNylon = false;

            cpp_leadTime = 0;
        
        }
        public clsCast(int codsec)
        {
            this.load(codsec);
        }
        //Methods

        public void load(int codsec)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwcastfilm where cpp_codsec = " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cpp_codsec"]);
                this.fkProcess = Convert.ToInt32(DS.Tables[0].Rows[0]["cpp_fkProcess"]);
                this.Process = new clsProcess(Convert.ToInt32(DS.Tables[0].Rows[0]["cpp_fkProcess"]));
                this.ProcessName = DS.Tables[0].Rows[0]["cpp_processName"].ToString();
                this.fkSubProcess = Convert.ToInt32(DS.Tables[0].Rows[0]["cpp_fkSubProcess"]);
                this.SubProcess = new clsProcess(Convert.ToInt32(DS.Tables[0].Rows[0]["cpp_fkSubProcess"]));
                this.SubProcessName = DS.Tables[0].Rows[0]["cpp_SubProcessName"].ToString();
                this.fkCentralStructure = Convert.ToInt32(DS.Tables[0].Rows[0]["cpp_fkCentralStructure"]);
                this.CentralStructure = new clsStructure(Convert.ToInt32(DS.Tables[0].Rows[0]["cpp_fkCentralStructure"]));
                this.CentralAdditivationName = DS.Tables[0].Rows[0]["cpp_CentralAdditivationName"].ToString();
                this.fkSurfaceStructure = Convert.ToInt32(DS.Tables[0].Rows[0]["cpp_fkSurfaceStructure"]);
                this.SurfaceStructure = new clsStructure(Convert.ToInt32(DS.Tables[0].Rows[0]["cpp_fkSurfaceStructure"]));
                this.SurfaceStructureName = DS.Tables[0].Rows[0]["cpp_SurfaceStructureName"].ToString();
                this.fkCentralAdditivation = Convert.ToInt32(DS.Tables[0].Rows[0]["cpp_fkCentralAdditivation"]);
                this.CentralAdditivation = new clsAdditivation(Convert.ToInt32(DS.Tables[0].Rows[0]["cpp_fkCentralAdditivation"]));
                this.CentralAdditivationName = DS.Tables[0].Rows[0]["cpp_CentralAdditivationName"].ToString();
                this.fkSurfaceAdditivation = Convert.ToInt32(DS.Tables[0].Rows[0]["cpp_fkSurfaceAdditivation"]);
                this.SurfaceAdditivation = new clsAdditivation(Convert.ToInt32(DS.Tables[0].Rows[0]["cpp_fkSurfaceAdditivation"]));
                this.SurfaceAdditivationName = DS.Tables[0].Rows[0]["cpp_SurfaceAdditivationName"].ToString();
                this.fkThickness = Convert.ToInt32(DS.Tables[0].Rows[0]["cpp_fkThickness"]);
                this.Thickness = new clsThickness(Convert.ToInt32(DS.Tables[0].Rows[0]["cpp_fkThickness"]));
                this.ThicknessValue = DS.Tables[0].Rows[0]["cpp_ThicknessValue"].ToString();
                this.fkTreatment = Convert.ToInt32(DS.Tables[0].Rows[0]["cpp_fkTreatment"]);
                this.Treatment = new clsTreatment(Convert.ToInt32(DS.Tables[0].Rows[0]["cpp_fkTreatment"]));
                this.TreatmentName = DS.Tables[0].Rows[0]["cpp_TreatmentName"].ToString();
                this.name = DS.Tables[0].Rows[0]["cpp_name"].ToString();
                this.code = DS.Tables[0].Rows[0]["cpp_code"].ToString();
                this.externalID = DS.Tables[0].Rows[0]["cpp_externalID"].ToString();
                this.externalDescription = DS.Tables[0].Rows[0]["cpp_externalDescription"].ToString();
                this.externalCode = DS.Tables[0].Rows[0]["cpp_externalCode"].ToString();
                this.leadTime = Convert.ToInt32(DS.Tables[0].Rows[0]["cpp_leadTime"]);
            }

        }

        public bool save()
        {
            try
            {
            string queryString = "";


            if (this.codsec == 0)
            {
                queryString += "INSERT INTO bps_prod_cast (cpp_fkProcess,cpp_fkSubProcess,cpp_fkCentralStructure,cpp_fkSurfaceStructure,cpp_fkCentralAdditivation,cpp_fkSurfaceAdditivation,cpp_fkThickness,cpp_fkTreatment,cpp_name,cpp_code,cpp_isNylon,cpp_leadTime)";
                queryString += " VALUES (";
                queryString += this.fkProcess.ToString() + ",";
                queryString += this.fkSubProcess.ToString() + ",";
                queryString += this.fkCentralStructure.ToString() + ",";
                queryString += this.fkSurfaceStructure.ToString() + ",";
                queryString += this.fkCentralAdditivation.ToString() + ",";
                queryString += this.fkSurfaceAdditivation.ToString() + ",";
                queryString += this.fkThickness.ToString() + ",";
                queryString += this.fkTreatment.ToString() + ",";
                queryString += "'" + this.name + "',";
                queryString += "'" + this.code + "',";
                queryString += "" + this.isNylon + ",";
                queryString += this.leadTime.ToString() + "";
                queryString += ");";
                clsConnection.executeQuery(queryString);
            }
            else
            {
                queryString += "UPDATE bps_prod_cast";
                queryString += " SET ";
                queryString += "cpp_fkProcess = " + this.fkProcess.ToString() + ",";
                queryString += "cpp_fkSubProcess = " + this.fkSubProcess.ToString() + ",";
                queryString += "cpp_fkCentralStructure = " + this.fkCentralStructure.ToString() + ",";
                queryString += "cpp_fkSurfaceStructure = " + this.fkSurfaceStructure.ToString() + ",";
                queryString += "cpp_fkCentralAdditivation = " + this.fkCentralAdditivation.ToString() + ",";
                queryString += "cpp_fkSurfaceAdditivation = " + this.fkSurfaceAdditivation.ToString() + ",";
                queryString += "cpp_fkThickness = " + this.fkThickness.ToString() + ",";
                queryString += "cpp_fkTreatment = " + this.fkTreatment.ToString() + ",";
                queryString += "cpp_name = '" + this.name + "',";
                queryString += "cpp_code = '" + this.code + "',";
                queryString += "cpp_leadTime = " + this.leadTime.ToString() + "";
                queryString += " WHERE cpp_codsec = " + this.codsec.ToString() + ";";
                clsConnection.executeQuery(queryString);
            }
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCast.save");
                return false;
            }
        }

        public static List<clsCast> getList()
        {
            List<clsCast> lstCast = new List<clsCast>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spCastFilmList()");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstCast.Add(new clsCast());
                lstCast[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_codsec"]);
                lstCast[i].fkProcess = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkProcess"]);
                lstCast[i].Process = new clsProcess(Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkProcess"]));
                lstCast[i].ProcessName = DS.Tables[0].Rows[i]["cpp_processName"].ToString();
                lstCast[i].fkSubProcess = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkSubProcess"]);
                lstCast[i].SubProcess = new clsProcess(Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkSubProcess"]));
                lstCast[i].SubProcessName = DS.Tables[0].Rows[i]["cpp_SubProcessName"].ToString();
                lstCast[i].fkCentralStructure = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkCentralStructure"]);
                lstCast[i].CentralStructure = new clsStructure(Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkCentralStructure"]));
                lstCast[i].CentralAdditivationName = DS.Tables[0].Rows[i]["cpp_CentralAdditivationName"].ToString();
                lstCast[i].fkSurfaceStructure = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkSurfaceStructure"]);
                lstCast[i].SurfaceStructure = new clsStructure(Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkSurfaceStructure"]));
                lstCast[i].SurfaceStructureName = DS.Tables[0].Rows[i]["cpp_SurfaceStructureName"].ToString();
                lstCast[i].fkCentralAdditivation = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkCentralAdditivation"]);
                lstCast[i].CentralAdditivation = new clsAdditivation(Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkCentralAdditivation"]));
                lstCast[i].CentralAdditivationName = DS.Tables[0].Rows[i]["cpp_CentralAdditivationName"].ToString();
                lstCast[i].fkSurfaceAdditivation = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkSurfaceAdditivation"]);
                lstCast[i].SurfaceAdditivation = new clsAdditivation(Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkSurfaceAdditivation"]));
                lstCast[i].SurfaceAdditivationName = DS.Tables[0].Rows[i]["cpp_SurfaceAdditivationName"].ToString();
                lstCast[i].fkThickness = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkThickness"]);
                lstCast[i].Thickness = new clsThickness(Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkThickness"]));
                lstCast[i].ThicknessValue = DS.Tables[0].Rows[i]["cpp_ThicknessValue"].ToString();
                lstCast[i].fkTreatment = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkTreatment"]);
                lstCast[i].Treatment = new clsTreatment(Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkTreatment"]));
                lstCast[i].TreatmentName = DS.Tables[0].Rows[i]["cpp_TreatmentName"].ToString();
                lstCast[i].name = DS.Tables[0].Rows[i]["cpp_name"].ToString();
                lstCast[i].code = DS.Tables[0].Rows[i]["cpp_code"].ToString();
                lstCast[i].externalID = DS.Tables[0].Rows[i]["cpp_externalID"].ToString();
                lstCast[i].externalDescription = DS.Tables[0].Rows[i]["cpp_externalDescription"].ToString();
                lstCast[i].externalCode = DS.Tables[0].Rows[i]["cpp_externalCode"].ToString();
                lstCast[i].leadTime = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_leadTime"]);
            }
            return lstCast;
        }
        
        public static List<clsCast> getSimplifiedList()
        {
            List<clsCast> lstCast = new List<clsCast>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spCastFilmList()");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstCast.Add(new clsCast());
                lstCast[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_codsec"]);
                lstCast[i].fkProcess = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkProcess"]);
                lstCast[i].ProcessName = DS.Tables[0].Rows[i]["cpp_processName"].ToString();
                lstCast[i].fkSubProcess = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkSubProcess"]);
                lstCast[i].SubProcessName = DS.Tables[0].Rows[i]["cpp_SubProcessName"].ToString();
                lstCast[i].fkCentralStructure = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkCentralStructure"]);
                lstCast[i].CentralAdditivationName = DS.Tables[0].Rows[i]["cpp_CentralAdditivationName"].ToString();
                lstCast[i].fkSurfaceStructure = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkSurfaceStructure"]);
                lstCast[i].SurfaceStructureName = DS.Tables[0].Rows[i]["cpp_SurfaceStructureName"].ToString();
                lstCast[i].fkCentralAdditivation = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkCentralAdditivation"]);
                lstCast[i].CentralAdditivationName = DS.Tables[0].Rows[i]["cpp_CentralAdditivationName"].ToString();
                lstCast[i].fkSurfaceAdditivation = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkSurfaceAdditivation"]);
                lstCast[i].SurfaceAdditivationName = DS.Tables[0].Rows[i]["cpp_SurfaceAdditivationName"].ToString();
                lstCast[i].fkThickness = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkThickness"]);
                lstCast[i].ThicknessValue = DS.Tables[0].Rows[i]["cpp_ThicknessValue"].ToString();
                lstCast[i].fkTreatment = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkTreatment"]);
                lstCast[i].TreatmentName = DS.Tables[0].Rows[i]["cpp_TreatmentName"].ToString();
                lstCast[i].name = DS.Tables[0].Rows[i]["cpp_name"].ToString();
                lstCast[i].code = DS.Tables[0].Rows[i]["cpp_code"].ToString();
                lstCast[i].externalID = DS.Tables[0].Rows[i]["cpp_externalID"].ToString();
                lstCast[i].externalDescription = DS.Tables[0].Rows[i]["cpp_externalDescription"].ToString();
                lstCast[i].externalCode = DS.Tables[0].Rows[i]["cpp_externalCode"].ToString();
                lstCast[i].leadTime = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_leadTime"]);
            }
            return lstCast;
        }

        public static List<clsCast> getSimplifiedListNylon()
        {
            List<clsCast> lstCast = new List<clsCast>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spNylonMultipleFilm 'NylonList','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "',0,''");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstCast.Add(new clsCast());
                lstCast[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_codsec"]);
                lstCast[i].fkProcess = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkProcess"]);
                lstCast[i].ProcessName = DS.Tables[0].Rows[i]["cpp_processName"].ToString();
                lstCast[i].fkSubProcess = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkSubProcess"]);
                lstCast[i].SubProcessName = DS.Tables[0].Rows[i]["cpp_SubProcessName"].ToString();
                lstCast[i].fkCentralStructure = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkCentralStructure"]);
                lstCast[i].CentralAdditivationName = DS.Tables[0].Rows[i]["cpp_CentralAdditivationName"].ToString();
                lstCast[i].fkSurfaceStructure = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkSurfaceStructure"]);
                lstCast[i].SurfaceStructureName = DS.Tables[0].Rows[i]["cpp_SurfaceStructureName"].ToString();
                lstCast[i].fkCentralAdditivation = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkCentralAdditivation"]);
                lstCast[i].CentralAdditivationName = DS.Tables[0].Rows[i]["cpp_CentralAdditivationName"].ToString();
                lstCast[i].fkSurfaceAdditivation = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkSurfaceAdditivation"]);
                lstCast[i].SurfaceAdditivationName = DS.Tables[0].Rows[i]["cpp_SurfaceAdditivationName"].ToString();
                lstCast[i].fkThickness = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkThickness"]);
                lstCast[i].ThicknessValue = DS.Tables[0].Rows[i]["cpp_ThicknessValue"].ToString();
                lstCast[i].fkTreatment = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkTreatment"]);
                lstCast[i].TreatmentName = DS.Tables[0].Rows[i]["cpp_TreatmentName"].ToString();
                lstCast[i].name = DS.Tables[0].Rows[i]["cpp_name"].ToString();
                lstCast[i].code = DS.Tables[0].Rows[i]["cpp_code"].ToString();
                lstCast[i].externalID = DS.Tables[0].Rows[i]["cpp_externalID"].ToString();
                lstCast[i].externalDescription = DS.Tables[0].Rows[i]["cpp_externalDescription"].ToString();
                lstCast[i].externalCode = DS.Tables[0].Rows[i]["cpp_externalCode"].ToString();
                lstCast[i].leadTime = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_leadTime"]);
            }
            return lstCast;
        }

        public static List<clsCast> getSimplifiedListWithSalesOrderQuantitiesByFilter(List<clsFilter> lstFilter)
        {
            List<clsCast> lstCast = new List<clsCast>();
            DataSet DS = new DataSet();
            string where = "";

            if (clsFilter.getSql(lstFilter) != "")
                where = " WHERE " + clsFilter.getSql(lstFilter);

            if (lstFilter.Count > 0)
                DS = clsConnection.getDataSetResult("SELECT * FROM vwCastfilmwithsalesorderquantity" + where);
            else
                DS = clsConnection.getDataSetResult("CALL spCastFilmWithSalesOrderQuantity()");

            lstCast.Clear();

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCast.Add(new clsCast());
                    lstCast[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_codsec"]);
                    lstCast[i].fkProcess = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkProcess"]);
                    lstCast[i].ProcessName = DS.Tables[0].Rows[i]["cpp_processName"].ToString();
                    lstCast[i].fkSubProcess = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkSubProcess"]);
                    lstCast[i].SubProcessName = DS.Tables[0].Rows[i]["cpp_SubProcessName"].ToString();
                    lstCast[i].fkCentralStructure = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkCentralStructure"]);
                    lstCast[i].CentralAdditivationName = DS.Tables[0].Rows[i]["cpp_CentralAdditivationName"].ToString();
                    lstCast[i].fkSurfaceStructure = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkSurfaceStructure"]);
                    lstCast[i].SurfaceStructureName = DS.Tables[0].Rows[i]["cpp_SurfaceStructureName"].ToString();
                    lstCast[i].fkCentralAdditivation = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkCentralAdditivation"]);
                    lstCast[i].CentralAdditivationName = DS.Tables[0].Rows[i]["cpp_CentralAdditivationName"].ToString();
                    lstCast[i].fkSurfaceAdditivation = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkSurfaceAdditivation"]);
                    lstCast[i].SurfaceAdditivationName = DS.Tables[0].Rows[i]["cpp_SurfaceAdditivationName"].ToString();
                    lstCast[i].fkThickness = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkThickness"]);
                    lstCast[i].ThicknessValue = DS.Tables[0].Rows[i]["cpp_ThicknessValue"].ToString();
                    lstCast[i].fkTreatment = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkTreatment"]);
                    lstCast[i].TreatmentName = DS.Tables[0].Rows[i]["cpp_TreatmentName"].ToString();
                    lstCast[i].name = DS.Tables[0].Rows[i]["cpp_name"].ToString();
                    lstCast[i].code = DS.Tables[0].Rows[i]["cpp_code"].ToString();
                    lstCast[i].externalID = DS.Tables[0].Rows[i]["cpp_externalID"].ToString();
                    lstCast[i].externalDescription = DS.Tables[0].Rows[i]["cpp_externalDescription"].ToString();
                    lstCast[i].externalCode = DS.Tables[0].Rows[i]["cpp_externalCode"].ToString();
                    lstCast[i].salesOrderQuantity = Convert.ToDouble(DS.Tables[0].Rows[i]["cpp_salesOrderQuantity"]);
                    lstCast[i].leadTime = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_leadTime"]);
                }
            }

            return lstCast;
        }
        public static List<clsCast> getSimplifiedListWithSalesOrderQuantities()
        {
            List<clsCast> lstCast = new List<clsCast>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spCastFilmWithSalesOrderQuantity()");

            lstCast.Clear();

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCast.Add(new clsCast());
                    lstCast[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_codsec"]);
                    lstCast[i].fkProcess = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkProcess"]);
                    lstCast[i].ProcessName = DS.Tables[0].Rows[i]["cpp_processName"].ToString();
                    lstCast[i].fkSubProcess = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkSubProcess"]);
                    lstCast[i].SubProcessName = DS.Tables[0].Rows[i]["cpp_SubProcessName"].ToString();
                    lstCast[i].fkCentralStructure = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkCentralStructure"]);
                    lstCast[i].CentralAdditivationName = DS.Tables[0].Rows[i]["cpp_CentralAdditivationName"].ToString();
                    lstCast[i].fkSurfaceStructure = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkSurfaceStructure"]);
                    lstCast[i].SurfaceStructureName = DS.Tables[0].Rows[i]["cpp_SurfaceStructureName"].ToString();
                    lstCast[i].fkCentralAdditivation = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkCentralAdditivation"]);
                    lstCast[i].CentralAdditivationName = DS.Tables[0].Rows[i]["cpp_CentralAdditivationName"].ToString();
                    lstCast[i].fkSurfaceAdditivation = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkSurfaceAdditivation"]);
                    lstCast[i].SurfaceAdditivationName = DS.Tables[0].Rows[i]["cpp_SurfaceAdditivationName"].ToString();
                    lstCast[i].fkThickness = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkThickness"]);
                    lstCast[i].ThicknessValue = DS.Tables[0].Rows[i]["cpp_ThicknessValue"].ToString();
                    lstCast[i].fkTreatment = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkTreatment"]);
                    lstCast[i].TreatmentName = DS.Tables[0].Rows[i]["cpp_TreatmentName"].ToString();
                    lstCast[i].name = DS.Tables[0].Rows[i]["cpp_name"].ToString();
                    lstCast[i].code = DS.Tables[0].Rows[i]["cpp_code"].ToString();
                    lstCast[i].externalID = DS.Tables[0].Rows[i]["cpp_externalID"].ToString();
                    lstCast[i].externalDescription = DS.Tables[0].Rows[i]["cpp_externalDescription"].ToString();
                    lstCast[i].externalCode = DS.Tables[0].Rows[i]["cpp_externalCode"].ToString();
                    lstCast[i].salesOrderQuantity = Convert.ToDouble(DS.Tables[0].Rows[i]["cpp_salesOrderQuantity"]);
                    lstCast[i].leadTime = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_leadTime"]);
                }
            }

            return lstCast;
        }
        public static List<clsCast> getSimplifiedListWithQuantities()
        {
            List<clsCast> lstCast = new List<clsCast>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spCastFilmWithTotalKilograms();");

            lstCast.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstCast.Add(new clsCast());
                lstCast[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_codsec"]);
                lstCast[i].fkProcess = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkProcess"]);
                lstCast[i].ProcessName = DS.Tables[0].Rows[i]["cpp_processName"].ToString();
                lstCast[i].fkSubProcess = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkSubProcess"]);
                lstCast[i].SubProcessName = DS.Tables[0].Rows[i]["cpp_SubProcessName"].ToString();
                lstCast[i].fkCentralStructure = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkCentralStructure"]);
                lstCast[i].CentralAdditivationName = DS.Tables[0].Rows[i]["cpp_CentralAdditivationName"].ToString();
                lstCast[i].fkSurfaceStructure = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkSurfaceStructure"]);
                lstCast[i].SurfaceStructureName = DS.Tables[0].Rows[i]["cpp_SurfaceStructureName"].ToString();
                lstCast[i].fkCentralAdditivation = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkCentralAdditivation"]);
                lstCast[i].CentralAdditivationName = DS.Tables[0].Rows[i]["cpp_CentralAdditivationName"].ToString();
                lstCast[i].fkSurfaceAdditivation = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkSurfaceAdditivation"]);
                lstCast[i].SurfaceAdditivationName = DS.Tables[0].Rows[i]["cpp_SurfaceAdditivationName"].ToString();
                lstCast[i].fkThickness = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkThickness"]);
                lstCast[i].ThicknessValue = DS.Tables[0].Rows[i]["cpp_ThicknessValue"].ToString();
                lstCast[i].fkTreatment = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkTreatment"]);
                lstCast[i].TreatmentName = DS.Tables[0].Rows[i]["cpp_TreatmentName"].ToString();
                lstCast[i].name = DS.Tables[0].Rows[i]["cpp_name"].ToString();
                lstCast[i].code = DS.Tables[0].Rows[i]["cpp_code"].ToString();
                lstCast[i].externalID = DS.Tables[0].Rows[i]["cpp_externalID"].ToString();
                lstCast[i].externalDescription = DS.Tables[0].Rows[i]["cpp_externalDescription"].ToString();
                lstCast[i].externalCode = DS.Tables[0].Rows[i]["cpp_externalCode"].ToString();
                lstCast[i].salesOrderQuantity = Convert.ToDouble(DS.Tables[0].Rows[i]["cpp_salesOrderQuantity"]);
                lstCast[i].mainCoilQuantity = Convert.ToDouble(DS.Tables[0].Rows[i]["cpp_mainCoilQuantity"]);
                lstCast[i].leadTime = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_leadTime"]);
            }

            return lstCast;
        }
        public static List<clsCast> getSimplifiedListWithQuantitiesByFilter(List<clsFilter> lstFilter)
        {
            List<clsCast> lstCast = new List<clsCast>();
            DataSet DS = new DataSet();
            string where = "";

            if (clsFilter.getSql(lstFilter) != "")
                where = " WHERE " + clsFilter.getSql(lstFilter);

            DS = clsConnection.getDataSetResult("SELECT * FROM vwcastfilmwithtotalkilograms" + where);

            lstCast.Clear();

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCast.Add(new clsCast());
                    lstCast[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_codsec"]);
                    lstCast[i].fkProcess = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkProcess"]);
                    lstCast[i].ProcessName = DS.Tables[0].Rows[i]["cpp_processName"].ToString();
                    lstCast[i].fkSubProcess = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkSubProcess"]);
                    lstCast[i].SubProcessName = DS.Tables[0].Rows[i]["cpp_SubProcessName"].ToString();
                    lstCast[i].fkCentralStructure = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkCentralStructure"]);
                    lstCast[i].CentralAdditivationName = DS.Tables[0].Rows[i]["cpp_CentralAdditivationName"].ToString();
                    lstCast[i].fkSurfaceStructure = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkSurfaceStructure"]);
                    lstCast[i].SurfaceStructureName = DS.Tables[0].Rows[i]["cpp_SurfaceStructureName"].ToString();
                    lstCast[i].fkCentralAdditivation = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkCentralAdditivation"]);
                    lstCast[i].CentralAdditivationName = DS.Tables[0].Rows[i]["cpp_CentralAdditivationName"].ToString();
                    lstCast[i].fkSurfaceAdditivation = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkSurfaceAdditivation"]);
                    lstCast[i].SurfaceAdditivationName = DS.Tables[0].Rows[i]["cpp_SurfaceAdditivationName"].ToString();
                    lstCast[i].fkThickness = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkThickness"]);
                    lstCast[i].ThicknessValue = DS.Tables[0].Rows[i]["cpp_ThicknessValue"].ToString();
                    lstCast[i].fkTreatment = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_fkTreatment"]);
                    lstCast[i].TreatmentName = DS.Tables[0].Rows[i]["cpp_TreatmentName"].ToString();
                    lstCast[i].name = DS.Tables[0].Rows[i]["cpp_name"].ToString();
                    lstCast[i].code = DS.Tables[0].Rows[i]["cpp_code"].ToString();
                    lstCast[i].externalID = DS.Tables[0].Rows[i]["cpp_externalID"].ToString();
                    lstCast[i].externalDescription = DS.Tables[0].Rows[i]["cpp_externalDescription"].ToString();
                    lstCast[i].externalCode = DS.Tables[0].Rows[i]["cpp_externalCode"].ToString();
                    lstCast[i].salesOrderQuantity = Convert.ToDouble(DS.Tables[0].Rows[i]["cpp_salesOrderQuantity"]);
                    lstCast[i].mainCoilQuantity = Convert.ToDouble(DS.Tables[0].Rows[i]["cpp_mainCoilQuantity"]);
                    lstCast[i].leadTime = Convert.ToInt32(DS.Tables[0].Rows[i]["cpp_leadTime"]);
                }
            }

            return lstCast;
        }
        public override string ToString()
        {
            return "[" + this.code + "] " + this.name;
        }

        public static string validateSiigoCode(int castCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_xtr_filmequivalence WHERE feq_fkCast = " + castCodsec.ToString() + " AND feq_externalCode LIKE 'OPP%'");

            if (DS.Tables[0].Rows.Count > 0)
                return DS.Tables[0].Rows[0]["feq_externalId"].ToString();
            else
                return "";
        }

        public static List<clsCast> getCastEquivalensceByCastCodsec(int fkCastEquiv)
        {
            DataSet DS = new DataSet();
            List<clsCast> lstCast = new List<clsCast>();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_castfilmequivalence WHERE cfe_fkCast = " + fkCastEquiv.ToString());

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstCast.Add(new clsCast(Convert.ToInt32(DS.Tables[0].Rows[i]["cfe_fkCast"])));
            }

            return lstCast;
        }

        public static int getFilmByCode(string code)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT bps_prod_cast.cast.codsec FROM bps_prod_cast WHERE cast_code = '" + code + "'");

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {

                return Convert.ToInt32(DS.Tables[0].Rows[0]["cast_codsec"]);

            }
            else
            {
                return 0;
            }
        }

    }
}
