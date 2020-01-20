using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsAceptationRange
    {
        //Atributes
        private int acp_codsec;
        private int acp_fkBopp;
        private string acp_filmname;
        private string acp_thiknessdata;
        private List<double> acp_thiknessList;
        private string acp_unitweightdata;
        private List<double> acp_unitweightdataList;
        private string acp_opacitydata;
        private List<double> acp_opacitydataList;
        private string acp_superficialtensiondata;
        private List<int> acp_superficialtensiondataList;
        private string acp_sealctdata;
        private List<int> acp_sealctdataList;
        private string acp_forcectdata;
        private List<double> acp_forcectdataList;
        private string acp_sealcntdata;
        private List<int> acp_sealcntdataList;
        private string acp_forcecntdata;
        private List<double> acp_forcecntdataList;
        private string acp_cofdymanicdata;
        private List<double> acp_cofdymanicdataList;
        private string acp_trateddata;
        private List<double> acp_trateddataList;
        private string acp_tensioncidata;
        private List<double> acp_tensioncidataList;
        private string acp_tensioncedata;
        private List<double> acp_tensioncedataList;
        private int acp_brightness;

        
        //Properties
        
        public int codsec { get { return acp_codsec; } set { acp_codsec = value; } }

        public int fkBopp { get { return acp_fkBopp; } set { acp_fkBopp = value; } }

        public string filmName { get { return acp_filmname; } set { acp_filmname = value; } }

        public string thiknessValues { get { return acp_thiknessdata; } set { acp_thiknessdata = value; } }

        public List<double> thiknessList { get { return acp_thiknessList; } set { acp_thiknessList = value; } }

        public string unitweightValues { get { return acp_unitweightdata; } set { acp_unitweightdata = value; } }

        public List<double> unitweightList { get { return acp_unitweightdataList; } set { acp_unitweightdataList = value; } }

        public string opacityValues { get { return acp_opacitydata; } set { acp_opacitydata = value; } }

        public List<double> opacityList { get { return acp_opacitydataList; } set { acp_opacitydataList = value; } }

        public string superficialtensionValues { get { return acp_superficialtensiondata; } set { acp_superficialtensiondata = value; } }

        public List<int> superficialtensionList { get { return acp_superficialtensiondataList; } set { acp_superficialtensiondataList = value; } }

        public string sealctValues { get { return acp_sealctdata; } set { acp_sealctdata = value; } }

        public List<int> sealctList { get { return acp_sealctdataList; } set { acp_sealctdataList = value; } }

        public string forcectValues { get { return acp_forcectdata; } set { acp_forcectdata = value; } }

        public List<double> forcectList { get { return acp_forcectdataList; } set { acp_forcectdataList = value; } }
        
        public string sealcntValues { get { return acp_sealcntdata; } set { acp_sealcntdata = value; } }

        public List<int> sealcntList { get { return acp_sealcntdataList; } set { acp_sealcntdataList = value; } }

        public string forcecntValues { get { return acp_forcecntdata; } set { acp_forcecntdata = value; } }

        public List<double> forcecntList { get { return acp_forcecntdataList; } set { acp_forcecntdataList = value; } }

        public string cofdymanicValues { get { return acp_cofdymanicdata; } set { acp_cofdymanicdata = value; } }

        public List<double> cofdymanicList { get { return acp_cofdymanicdataList; } set { acp_cofdymanicdataList = value; } }

        public string tratedValues { get { return acp_trateddata; } set { acp_trateddata = value; } }

        public List<double> tratedList { get { return acp_trateddataList; } set { acp_trateddataList = value; } }

        public string tensionciValues { get { return acp_tensioncidata; } set { acp_tensioncidata = value; } }

        public List<double> tensionciList { get { return acp_tensioncidataList; } set { acp_tensioncidataList = value; } }

        public string tensionceValues { get { return acp_tensioncedata; } set { acp_tensioncedata = value; } }

        public List<double> tensionceList { get { return acp_tensioncedataList; } set { acp_tensioncedataList = value; } }

        public int brightness { get { return acp_brightness; } set { acp_brightness = value; } }

        //Constructor

        public clsAceptationRange()
        {
            acp_codsec = 0;
            acp_fkBopp = 0;
            acp_filmname = string.Empty;
            acp_thiknessdata = "";
            acp_thiknessList = new List<double>();
            acp_unitweightdata = "";
            acp_unitweightdataList = new List<double>();
            acp_opacitydata = "";
            acp_opacitydataList = new List<double>();
            acp_superficialtensiondata = "";
            acp_superficialtensiondataList = new List<int>();
            acp_sealctdata = "";
            acp_sealctdataList = new List<int>();
            acp_forcectdata = "";
            acp_forcectdataList = new List<double>();
            acp_sealcntdata = "";
            acp_sealcntdataList = new List<int>();
            acp_forcecntdata = "";
            acp_forcecntdataList = new List<double>();
            acp_cofdymanicdata = "";
            acp_cofdymanicdataList = new List<double>();
            acp_trateddata = "";
            acp_trateddataList = new List<double>();
            acp_tensioncidata = "";
            acp_tensioncidataList = new List<double>();
            acp_tensioncedata = "";
            acp_tensioncedataList = new List<double>();
            acp_brightness = 0;
        }

        public clsAceptationRange(int codsec)
        {
            Load(codsec);
        }

        public void Load(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spAceptationRangeByCodsec(" + codsec.ToString() + ");");

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["acp_codsec"]);
                this.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["acp_fkBopp"]);
                this.filmName = DS.Tables[0].Rows[0]["acp_filmname"].ToString();
                this.thiknessValues = DS.Tables[0].Rows[0]["acp_thicknessdata"].ToString();
                this.thiknessList = clsGlobal.getDoubleListFromString(this.thiknessValues);
                this.unitweightValues = DS.Tables[0].Rows[0]["acp_unitweightdata"].ToString();
                this.unitweightList = clsGlobal.getDoubleListFromString(this.unitweightValues);
                this.opacityValues = DS.Tables[0].Rows[0]["acp_opacitydata"].ToString();
                this.opacityList = clsGlobal.getDoubleListFromString(this.opacityValues);
                this.superficialtensionValues = DS.Tables[0].Rows[0]["acp_superficialtensiondata"].ToString();
                this.superficialtensionList = clsGlobal.getIntListFromString(this.superficialtensionValues);
                this.sealctValues = DS.Tables[0].Rows[0]["acp_sealctdata"].ToString();
                this.sealctList = clsGlobal.getIntListFromString(this.sealctValues);
                this.forcectValues = DS.Tables[0].Rows[0]["acp_forcectdata"].ToString();
                this.forcectList = clsGlobal.getDoubleListFromString(this.forcectValues);
                this.sealcntValues = DS.Tables[0].Rows[0]["acp_sealcntdata"].ToString();
                this.sealcntList = clsGlobal.getIntListFromString(this.sealcntValues);
                this.forcecntValues = DS.Tables[0].Rows[0]["acp_forcecntdata"].ToString();
                this.forcecntList = clsGlobal.getDoubleListFromString(this.forcecntValues);
                this.cofdymanicValues = DS.Tables[0].Rows[0]["acp_cofdymanicdata"].ToString();
                this.cofdymanicList = clsGlobal.getDoubleListFromString(this.cofdymanicValues);
                this.tratedValues = DS.Tables[0].Rows[0]["acp_trateddata"].ToString();
                this.tratedList = clsGlobal.getDoubleListFromString(this.tratedValues);
                this.tensionciValues = DS.Tables[0].Rows[0]["acp_tensioncidata"].ToString();
                this.tensionciList = clsGlobal.getDoubleListFromString(this.tensionciValues);
                this.tensionceValues = DS.Tables[0].Rows[0]["acp_tensioncedata"].ToString();
                this.tensionceList = clsGlobal.getDoubleListFromString(this.tensionceValues);
                this.brightness = Convert.ToInt32(DS.Tables[0].Rows[0]["acp_brightness"]);
            }
        }

        public bool save()
        {
            string queryString = "";    
            try
            {
                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_aceptationrange (acp_fkBopp, acp_thicknessdata, acp_unitweightdata, acp_opacitydata, " +
                    "acp_superficialtensiondata, acp_sealctdata, acp_forcectdata, acp_sealcntdata, acp_forcecntdata, acp_cofdymanicdata, acp_trateddata, acp_tensioncidata, acp_tensioncedata, acp_brightness) ";
                    queryString += " VALUES (";
                    queryString += "" + this.fkBopp.ToString() + ",";
                    queryString += "'" + this.thiknessValues.ToString() + "',";
                    queryString += "'" + this.unitweightValues.ToString() + "',";
                    queryString += "'" + this.opacityValues.ToString() + "',";
                    queryString += "'" + this.tensionciValues.ToString() + "',";
                    queryString += "'" + this.sealctValues.ToString() + "',";
                    queryString += "'" + this.forcectValues.ToString() + "',";
                    queryString += "'" + this.sealcntValues.ToString() + "',";
                    queryString += "'" + this.forcecntValues.ToString() + "',";
                    queryString += "'" + this.cofdymanicValues.ToString() + "',";
                    queryString += "'" + this.tratedValues.ToString() + "',";
                    queryString += "'" + this.tensionciValues.ToString() + "',";
                    queryString += "'" + this.tensionceValues.ToString() + "',";
                    queryString += "'" + this.brightness.ToString() + "')";
                }
                else
                {
                    queryString += "UPDATE bps_prod_aceptationrange ";
                    queryString += " SET ";
                    queryString += "acp_fkBopp =" + this.fkBopp.ToString() + ",";
                    queryString += "acp_thicknessdata = '" + this.thiknessValues.ToString() + "',";
                    queryString += "acp_unitweightdata = '" + this.unitweightValues.ToString() + "',";
                    queryString += "acp_opacitydata ='" + this.opacityValues.ToString() + "',";
                    queryString += "acp_superficialtensiondata ='" + this.tensionciValues.ToString() + "',";
                    queryString += "acp_sealctdata ='" + this.sealctValues.ToString() + "',";
                    queryString += "acp_forcectdata ='" + this.forcectValues.ToString() + "',";
                    queryString += "acp_sealcntdata ='" + this.sealcntValues.ToString() + "',";
                    queryString += "acp_forcecntdata = '" + this.forcecntValues.ToString() + "',";
                    queryString += "acp_cofdymanicdata ='" + this.cofdymanicValues.ToString() + "',";
                    queryString += "acp_trateddata ='" + this.tratedValues.ToString() + "',";
                    queryString += "acp_tensioncidata = '" + this.tensionciValues.ToString() + "',";
                    queryString += "acp_tensioncedata ='" + this.tensionceValues.ToString() + "',";
                    queryString += "acp_brightness = '" + this.brightness.ToString() + "'";
                    queryString += " WHERE acp_codsec = " + this.codsec.ToString() + "";
                }
                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsAceptationRange.save");
                return false;
            }
        }

        public static List<clsAceptationRange> getList()
        {
            List<clsAceptationRange> lstAceptactionRange = new List<clsAceptationRange>();

            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spAceptationRangeList();");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstAceptactionRange.Add(new clsAceptationRange());
                    lstAceptactionRange[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["acp_codsec"]);
                    lstAceptactionRange[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["acp_fkBopp"]);
                    lstAceptactionRange[i].filmName = DS.Tables[0].Rows[i]["acp_filmname"].ToString();
                    lstAceptactionRange[i].thiknessValues = DS.Tables[0].Rows[i]["acp_thicknessdata"].ToString();
                    lstAceptactionRange[i].thiknessList = clsGlobal.getDoubleListFromString(lstAceptactionRange[i].thiknessValues);
                    lstAceptactionRange[i].unitweightValues = DS.Tables[0].Rows[i]["acp_unitweightdata"].ToString();
                    lstAceptactionRange[i].unitweightList = clsGlobal.getDoubleListFromString(lstAceptactionRange[i].unitweightValues);
                    lstAceptactionRange[i].opacityValues = DS.Tables[0].Rows[i]["acp_opacitydata"].ToString();
                    lstAceptactionRange[i].opacityList = clsGlobal.getDoubleListFromString(lstAceptactionRange[i].opacityValues);
                    lstAceptactionRange[i].superficialtensionValues = DS.Tables[0].Rows[i]["acp_superficialtensiondata"].ToString();
                    lstAceptactionRange[i].superficialtensionList = clsGlobal.getIntListFromString(lstAceptactionRange[i].superficialtensionValues);
                    lstAceptactionRange[i].sealctValues = DS.Tables[0].Rows[i]["acp_sealctdata"].ToString();
                    lstAceptactionRange[i].sealctList = clsGlobal.getIntListFromString(lstAceptactionRange[i].sealctValues);
                    lstAceptactionRange[i].forcectValues = DS.Tables[0].Rows[i]["acp_forcectdata"].ToString();
                    lstAceptactionRange[i].forcectList = clsGlobal.getDoubleListFromString(lstAceptactionRange[i].forcectValues);
                    lstAceptactionRange[i].sealcntValues = DS.Tables[0].Rows[i]["acp_sealcntdata"].ToString();
                    lstAceptactionRange[i].sealcntList = clsGlobal.getIntListFromString(lstAceptactionRange[i].sealcntValues);
                    lstAceptactionRange[i].forcecntValues = DS.Tables[0].Rows[i]["acp_forcecntdata"].ToString();
                    lstAceptactionRange[i].forcecntList = clsGlobal.getDoubleListFromString(lstAceptactionRange[i].forcecntValues);
                    lstAceptactionRange[i].cofdymanicValues = DS.Tables[0].Rows[i]["acp_cofdymanicdata"].ToString();
                    lstAceptactionRange[i].cofdymanicList = clsGlobal.getDoubleListFromString(lstAceptactionRange[i].cofdymanicValues);
                    lstAceptactionRange[i].tratedValues = DS.Tables[0].Rows[i]["acp_trateddata"].ToString();
                    lstAceptactionRange[i].tratedList = clsGlobal.getDoubleListFromString(lstAceptactionRange[i].tratedValues);
                    lstAceptactionRange[i].tensionciValues = DS.Tables[0].Rows[i]["acp_tensioncidata"].ToString();
                    lstAceptactionRange[i].tensionciList = clsGlobal.getDoubleListFromString(lstAceptactionRange[i].tensionciValues);
                    lstAceptactionRange[i].tensionceValues = DS.Tables[0].Rows[i]["acp_tensioncedata"].ToString();
                    lstAceptactionRange[i].tensionceList = clsGlobal.getDoubleListFromString(lstAceptactionRange[i].tensionceValues);
                    lstAceptactionRange[i].brightness = Convert.ToInt32(DS.Tables[0].Rows[i]["acp_brightness"]);
                }
            }
            return lstAceptactionRange;
        }

        public static List<clsAceptationRange> getListByFilm(int codsec)
        {
            List<clsAceptationRange> lstAceptactionRange = new List<clsAceptationRange>();

            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spAceptationRangeByFilm('" + codsec.ToString() + "');");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstAceptactionRange.Add(new clsAceptationRange());
                    lstAceptactionRange[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["acp_codsec"]);
                    lstAceptactionRange[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["acp_fkBopp"]);
                    lstAceptactionRange[i].filmName = DS.Tables[0].Rows[i]["acp_filmname"].ToString();
                    lstAceptactionRange[i].thiknessValues = DS.Tables[0].Rows[i]["acp_thicknessdata"].ToString();
                    lstAceptactionRange[i].thiknessList = clsGlobal.getDoubleListFromString(lstAceptactionRange[i].thiknessValues);
                    lstAceptactionRange[i].unitweightValues = DS.Tables[0].Rows[i]["acp_unitweightdata"].ToString();
                    lstAceptactionRange[i].unitweightList = clsGlobal.getDoubleListFromString(lstAceptactionRange[i].unitweightValues);
                    lstAceptactionRange[i].opacityValues = DS.Tables[0].Rows[i]["acp_opacitydata"].ToString();
                    lstAceptactionRange[i].opacityList = clsGlobal.getDoubleListFromString(lstAceptactionRange[i].opacityValues);
                    lstAceptactionRange[i].superficialtensionValues = DS.Tables[0].Rows[i]["acp_superficialtensiondata"].ToString();
                    lstAceptactionRange[i].superficialtensionList = clsGlobal.getIntListFromString(lstAceptactionRange[i].superficialtensionValues);
                    lstAceptactionRange[i].sealctValues = DS.Tables[0].Rows[i]["acp_sealctdata"].ToString();
                    lstAceptactionRange[i].sealctList = clsGlobal.getIntListFromString(lstAceptactionRange[i].sealctValues);
                    lstAceptactionRange[i].forcectValues = DS.Tables[0].Rows[i]["acp_forcectdata"].ToString();
                    lstAceptactionRange[i].forcectList = clsGlobal.getDoubleListFromString(lstAceptactionRange[i].forcectValues);
                    lstAceptactionRange[i].sealcntValues = DS.Tables[0].Rows[i]["acp_sealcntdata"].ToString();
                    lstAceptactionRange[i].sealcntList = clsGlobal.getIntListFromString(lstAceptactionRange[i].sealcntValues);
                    lstAceptactionRange[i].forcecntValues = DS.Tables[0].Rows[i]["acp_forcecntdata"].ToString();
                    lstAceptactionRange[i].forcecntList = clsGlobal.getDoubleListFromString(lstAceptactionRange[i].forcecntValues);
                    lstAceptactionRange[i].cofdymanicValues = DS.Tables[0].Rows[i]["acp_cofdymanicdata"].ToString();
                    lstAceptactionRange[i].cofdymanicList = clsGlobal.getDoubleListFromString(lstAceptactionRange[i].cofdymanicValues);
                    lstAceptactionRange[i].tratedValues = DS.Tables[0].Rows[i]["acp_trateddata"].ToString();
                    lstAceptactionRange[i].tratedList = clsGlobal.getDoubleListFromString(lstAceptactionRange[i].tratedValues);
                    lstAceptactionRange[i].tensionciValues = DS.Tables[0].Rows[i]["acp_tensioncidata"].ToString();
                    lstAceptactionRange[i].tensionciList = clsGlobal.getDoubleListFromString(lstAceptactionRange[i].tensionciValues);
                    lstAceptactionRange[i].tensionceValues = DS.Tables[0].Rows[i]["acp_tensioncedata"].ToString();
                    lstAceptactionRange[i].tensionceList = clsGlobal.getDoubleListFromString(lstAceptactionRange[i].tensionceValues);
                    lstAceptactionRange[i].brightness = Convert.ToInt32(DS.Tables[0].Rows[i]["acp_brightness"]);
                }
            }
            return lstAceptactionRange;
        }
        private static int getLastSavedSalesOrderCodsec()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT mcq_codsec FROM bps_prod_maincoilquality Order By mcq_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["mcq_codsec"]);
        }

        public static bool IsUniqueFilm(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT acp_codsec FROM bps_prod_aceptationrange WHERE acp_fkBopp =" + codsec.ToString());
            if (DS.Tables[0].Rows.Count > 0)
                return false;
            else
                return true;
        }

        public static bool IsUniqueFilm(string code)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT acp_codsec FROM bps_prod_aceptationrange WHERE acp_fkBopp =" + code.ToString());
            if (DS.Tables[0].Rows.Count > 0)
                return false;
            else
                return true;
        }
    }
}
