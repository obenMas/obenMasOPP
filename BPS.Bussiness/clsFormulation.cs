using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra las formulaciones
    /// </summary>
    public class clsFormulation
    {
        //Atributes

        private int frml_codsec;
        private string frml_name;
        private string frml_description;
        private int frml_fkBopp;
        private string frml_BoppCode;
        private string frml_BoppName;
        private int frml_fkCast;
        private string frml_CastCode;
        private string frml_CastName;
        private int frml_fkCoating;
        private string frml_CoatingCode;
        private string frml_CoatingName;
        private double frml_thick;
        private double frml_thickLayerC1;
        private double frml_thickLayerC2;
        private double frml_thickLayerC3;
        private double frml_thickLayerC4;
        private double frml_thickCentralLayer;
        private int frml_RawMaterialCodsec;
        private string frml_RawMaterialCode;
        private string frml_RawMaterialName;
        private string frml_RawMaterialNote;
        private double frml_RawMaterialPercentage;
        private Boolean frml_RawMaterialC1;
        private Boolean frml_RawMaterialC2;
        private Boolean frml_RawMaterialC3;
        private Boolean frml_RawMaterialC4;
        private Boolean frml_RawMaterialCentralLayer;
        private List<clsRawMaterialByFormulation> frml_lstRawMaterialByFormulation;


        //Properties



        public int codsec { get { return frml_codsec; } set { frml_codsec = value; } }

        public string name { get { return frml_name; } set { frml_name = value; } }

        public string description { get { return frml_description; } set { frml_description = value; } }

        public int fkBopp { get { return frml_fkBopp; } set { frml_fkBopp = value; } }

        public string BoppCode { get { return frml_BoppCode; } set { frml_BoppCode = value; } }

        public string BoppName { get { return frml_BoppName; } set { frml_BoppName = value; } }

        public int fkCast { get { return frml_fkCast; } set { frml_fkCast = value; } }

        public string CastCode { get { return frml_CastCode; } set { frml_CastCode = value; } }

        public string CastName { get { return frml_CastName; } set { frml_CastName = value; } }

        public int fkCoating { get { return frml_fkCoating; } set { frml_fkCoating = value; } }

        public string CoatingCode { get { return frml_CoatingCode; } set { frml_CoatingCode = value; } }

        public string CoatingName { get { return frml_CoatingName; } set { frml_CoatingName = value; } }

        public double thick { get { return frml_thick; } set { frml_thick = value; } }

        public double thickLayerC1 { get { return frml_thickLayerC1; } set { frml_thickLayerC1 = value; } }

        public double thickLayerC2 { get { return frml_thickLayerC2; } set { frml_thickLayerC2 = value; } }

        public double thickLayerC3 { get { return frml_thickLayerC3; } set { frml_thickLayerC3 = value; } }

        public double thickLayerC4 { get { return frml_thickLayerC4; } set { frml_thickLayerC4 = value; } }

        public double thickCentralLayer { get { return frml_thickCentralLayer; } set { frml_thickCentralLayer = value; } }

        public int RawMaterialCodsec { get { return frml_RawMaterialCodsec; } set { frml_RawMaterialCodsec = value; } }

        public string RawMaterialCode { get { return frml_RawMaterialCode; } set { frml_RawMaterialCode = value; } }

        public string RawMaterialName { get { return frml_RawMaterialName; } set { frml_RawMaterialName = value; } }

        public string RawMaterialNote { get { return frml_RawMaterialNote; } set { frml_RawMaterialNote = value; } }

        public double RawMaterialPercentage { get { return frml_RawMaterialPercentage; } set { frml_RawMaterialPercentage = value; } }

        public Boolean RawMaterialC1 { get { return frml_RawMaterialC1; } set { frml_RawMaterialC1 = value; } }

        public Boolean RawMaterialC2 { get { return frml_RawMaterialC2; } set { frml_RawMaterialC2 = value; } }

        public Boolean RawMaterialC3 { get { return frml_RawMaterialC3; } set { frml_RawMaterialC3 = value; } }

        public Boolean RawMaterialC4 { get { return frml_RawMaterialC4; } set { frml_RawMaterialC4 = value; } }

        public Boolean RawMaterialCentralLayer { get { return frml_RawMaterialCentralLayer; } set { frml_RawMaterialCentralLayer = value; } }

        public List<clsRawMaterialByFormulation> lstRawMaterialByFormulation { get { return frml_lstRawMaterialByFormulation; } set { frml_lstRawMaterialByFormulation = value; } }

        //Constructor

        public clsFormulation()
        {

            frml_codsec = 0;
            frml_name = "";
            frml_description = "";
            frml_fkBopp = 0;
            frml_BoppCode = "";
            frml_BoppName = "";
            frml_fkCast = 0;
            frml_CastCode = "";
            frml_CastName = "";
            frml_fkCoating = 0;
            frml_CoatingCode = "";
            frml_CoatingName = "";
            frml_thick = 0;
            frml_thickLayerC1 = 0;
            frml_thickLayerC2 = 0;
            frml_thickLayerC3 = 0;
            frml_thickLayerC4 = 0;
            frml_thickCentralLayer = 0;
            frml_RawMaterialCodsec = 0;
            frml_RawMaterialCode = "";
            frml_RawMaterialName = "";
            frml_RawMaterialNote = "";
            frml_RawMaterialPercentage = 0;
            frml_RawMaterialC1 = false;
            frml_RawMaterialC2 = false;
            frml_RawMaterialC3 = false;
            frml_RawMaterialC4 = false;
            frml_RawMaterialCentralLayer = false;
            frml_lstRawMaterialByFormulation = new List<clsRawMaterialByFormulation>();


        }

        public clsFormulation(int codsec)
        {
            this.load(codsec);
        }

        public clsFormulation(int codsec, string source)
        {
            this.load(codsec, source);
        }

        //Methods

        public void load(int codsec)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spFormulationByCodsec " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["frml_codsec"]);
            this.name = DS.Tables[0].Rows[0]["frml_name"].ToString();
            this.description = DS.Tables[0].Rows[0]["frml_description"].ToString();
            this.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["frml_fkBopp"]);
            this.BoppCode = DS.Tables[0].Rows[0]["frml_BoppCode"].ToString();
            this.BoppName = DS.Tables[0].Rows[0]["frml_BoppName"].ToString();
            this.fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["frml_fkCast"]);
            this.CastCode = DS.Tables[0].Rows[0]["frml_CastCode"].ToString();
            this.CastName = DS.Tables[0].Rows[0]["frml_CastName"].ToString();
            this.thick = Convert.ToDouble(DS.Tables[0].Rows[0]["frml_thick"]);
            this.thickLayerC1 = Convert.ToDouble(DS.Tables[0].Rows[0]["frml_thickLayerC1"]);
            this.thickLayerC2 = Convert.ToDouble(DS.Tables[0].Rows[0]["frml_thickLayerC2"]);
            this.thickLayerC3 = Convert.ToDouble(DS.Tables[0].Rows[0]["frml_thickLayerC3"]);
            this.thickLayerC4 = Convert.ToDouble(DS.Tables[0].Rows[0]["frml_thickLayerC4"]);
            this.thickCentralLayer = Convert.ToDouble(DS.Tables[0].Rows[0]["frml_thickCentralLayer"]);
            this.lstRawMaterialByFormulation = clsRawMaterialByFormulation.getListByFormulation(this.codsec);

        }

        public void load(int codsec, string source)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spFormulationByCodsec " + codsec.ToString() + "");

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["frml_codsec"]);
            this.name = DS.Tables[0].Rows[0]["frml_name"].ToString();
            this.description = DS.Tables[0].Rows[0]["frml_description"].ToString();
            this.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["frml_fkBopp"]);
            this.BoppCode = DS.Tables[0].Rows[0]["frml_BoppCode"].ToString();
            this.BoppName = DS.Tables[0].Rows[0]["frml_BoppName"].ToString();
            this.fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["frml_fkCast"]);
            this.CastCode = DS.Tables[0].Rows[0]["frml_CastCode"].ToString();
            this.CastName = DS.Tables[0].Rows[0]["frml_CastName"].ToString();
            this.thick = Convert.ToDouble(DS.Tables[0].Rows[0]["frml_thick"]);
            this.thickLayerC1 = Convert.ToDouble(DS.Tables[0].Rows[0]["frml_thickLayerC1"]);
            this.thickLayerC2 = Convert.ToDouble(DS.Tables[0].Rows[0]["frml_thickLayerC2"]);
            this.thickLayerC3 = Convert.ToDouble(DS.Tables[0].Rows[0]["frml_thickLayerC3"]);
            this.thickLayerC4 = Convert.ToDouble(DS.Tables[0].Rows[0]["frml_thickLayerC4"]);
            this.thickCentralLayer = Convert.ToDouble(DS.Tables[0].Rows[0]["frml_thickCentralLayer"]);
            this.lstRawMaterialByFormulation = clsRawMaterialByFormulation.getListByFormulationEdit(this.codsec);
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.fkBopp > 0)
                {
                    if (this.codsec == 0)
                    {
                        queryString += "INSERT INTO bps_prod_formulation (frml_fkBopp,frml_name, frml_description,frml_thick,frml_thickLayerC1,frml_thickLayerC2,frml_thickLayerC3,frml_thickLayerC4,frml_thickCentralLayer)";
                        queryString += " VALUES (";
                        queryString += this.fkBopp.ToString() + ",";
                        queryString += "'" + this.name + "',";
                        queryString += "'" + this.description + "',";
                        queryString += this.thick.ToString() + ",";
                        queryString += this.thickLayerC1.ToString() + ",";
                        queryString += this.thickLayerC2.ToString() + ",";
                        queryString += this.thickLayerC3.ToString() + ",";
                        queryString += this.thickLayerC4.ToString() + ",";
                        queryString += this.thickCentralLayer.ToString() + "";
                        queryString += ");";
                        clsConnection.executeQuery(queryString);
                    }
                    else
                    {
                        queryString += "UPDATE bps_prod_formulation";
                        queryString += " SET ";
                        queryString += "frml_name = '" + this.name + "',";
                        queryString += "frml_description = '" + this.description + "',";
                        queryString += "frml_thick = " + this.thick.ToString() + ",";
                        queryString += "frml_thickLayerC1 = " + this.thickLayerC1.ToString() + ",";
                        queryString += "frml_thickLayerC2 = " + this.thickLayerC2.ToString() + ",";
                        queryString += "frml_thickLayerC3 = " + this.thickLayerC3.ToString() + ",";
                        queryString += "frml_thickLayerC4 = " + this.thickLayerC4.ToString() + ",";
                        queryString += "frml_thickCentralLayer = " + this.thickCentralLayer.ToString() + ",";
                        queryString += "frml_fkBopp = " + this.fkBopp.ToString() + "";
                        queryString += " WHERE frml_codsec = " + this.codsec.ToString() + ";";
                        clsConnection.executeQuery(queryString);
                    }
                }
                if (this.fkCast > 0)
                {
                    if (this.codsec == 0)
                    {
                        queryString += "INSERT INTO bps_prod_formulation (frml_fkCast,frml_name, frml_description,frml_thick,frml_thickLayerC1,frml_thickLayerC2,frml_thickLayerC3,frml_thickLayerC4,frml_thickCentralLayer)";
                        queryString += " VALUES (";
                        queryString += this.fkCast.ToString() + ",";
                        queryString += "'" + this.name + "',";
                        queryString += "'" + this.description + "',";
                        queryString += this.thick.ToString() + ",";
                        queryString += this.thickLayerC1.ToString() + ",";
                        queryString += this.thickLayerC2.ToString() + ",";
                        queryString += this.thickLayerC3.ToString() + ",";
                        queryString += this.thickLayerC4.ToString() + ",";
                        queryString += this.thickCentralLayer.ToString() + "";
                        queryString += ");";
                        clsConnection.executeQuery(queryString);
                    }
                    else
                    {
                        queryString += "UPDATE bps_prod_formulation";
                        queryString += " SET ";
                        queryString += "frml_name = '" + this.name + "',";
                        queryString += "frml_description = '" + this.description + "',";
                        queryString += "frml_thick = " + this.thick.ToString() + ",";
                        queryString += "frml_thickLayerC1 = " + this.thickLayerC1.ToString() + ",";
                        queryString += "frml_thickLayerC2 = " + this.thickLayerC2.ToString() + ",";
                        queryString += "frml_thickLayerC3 = " + this.thickLayerC3.ToString() + ",";
                        queryString += "frml_thickLayerC4 = " + this.thickLayerC4.ToString() + ",";
                        queryString += "frml_thickCentralLayer = " + this.thickCentralLayer.ToString() + ",";
                        queryString += "frml_fkCast = " + this.fkCast.ToString() + "";
                        queryString += " WHERE frml_codsec = " + this.codsec.ToString() + ";";
                        clsConnection.executeQuery(queryString);
                    }
                }

                if (this.codsec == 0)
                    this.codsec = getLastSavedCodsec();

                for (int i = 0; i < this.lstRawMaterialByFormulation.Count; i++)
                {
                    lstRawMaterialByFormulation[i].fkFormulation = this.codsec;
                    lstRawMaterialByFormulation[i].save();
                }
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsFormulation.save");
                return false;
            }
        }

        public static List<clsFormulation> getListBopp()
        {
            List<clsFormulation> lstBoppFormulationList = new List<clsFormulation>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spFormulationListBopp");

            lstBoppFormulationList.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstBoppFormulationList.Add(new clsFormulation());
                lstBoppFormulationList[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["frml_codsec"]);
                lstBoppFormulationList[i].name = DS.Tables[0].Rows[i]["frml_name"].ToString();
                lstBoppFormulationList[i].description = DS.Tables[0].Rows[i]["frml_description"].ToString();
                lstBoppFormulationList[i].BoppCode = DS.Tables[0].Rows[i]["frml_BoppCode"].ToString();

            }
            return lstBoppFormulationList;
        }

        public static List<clsFormulation> getListByBoppFilm(int boppFilmCodsec, bool data)
        {
            List<clsFormulation> lstBoppFormulationList = new List<clsFormulation>();

            DataSet DS = new DataSet();

            if (data)
                DS = clsConnection.getDataSetResult("spFormulationByBoppFilm " + boppFilmCodsec.ToString() + ",'Only'");
            else
                DS = clsConnection.getDataSetResult("spFormulationByBoppFilm " + boppFilmCodsec.ToString() + ",'All'");

            lstBoppFormulationList.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstBoppFormulationList.Add(new clsFormulation());
                lstBoppFormulationList[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["frml_codsec"]);
                lstBoppFormulationList[i].name = DS.Tables[0].Rows[i]["frml_name"].ToString();
                lstBoppFormulationList[i].description = DS.Tables[0].Rows[i]["frml_description"].ToString();
                lstBoppFormulationList[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["frml_fkBopp"]);
                lstBoppFormulationList[i].BoppCode = DS.Tables[0].Rows[i]["frml_BoppCode"].ToString();
                lstBoppFormulationList[i].BoppName = DS.Tables[0].Rows[i]["frml_BoppName"].ToString();
                lstBoppFormulationList[i].thick = Convert.ToDouble(DS.Tables[0].Rows[i]["frml_thick"]);
                lstBoppFormulationList[i].thickLayerC1 = Convert.ToDouble(DS.Tables[0].Rows[i]["frml_thickLayerC1"]);
                lstBoppFormulationList[i].thickLayerC2 = Convert.ToDouble(DS.Tables[0].Rows[i]["frml_thickLayerC2"]);
                lstBoppFormulationList[i].thickLayerC3 = Convert.ToDouble(DS.Tables[0].Rows[i]["frml_thickLayerC3"]);
                lstBoppFormulationList[i].thickLayerC4 = Convert.ToDouble(DS.Tables[0].Rows[i]["frml_thickLayerC4"]);
                lstBoppFormulationList[i].thickCentralLayer = Convert.ToDouble(DS.Tables[0].Rows[i]["frml_thickCentralLayer"]);
            }
            return lstBoppFormulationList;
        }

        public static List<clsFormulation> getListByBoppFilmOnlyResult(int codsecFormulation)
        {
            List<clsFormulation> lstBoppFormulationList = new List<clsFormulation>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spFormulationByBoppFilm " + codsecFormulation.ToString() + ",'One'");

            lstBoppFormulationList.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstBoppFormulationList.Add(new clsFormulation());
                lstBoppFormulationList[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["frml_codsec"]);
                lstBoppFormulationList[i].name = DS.Tables[0].Rows[i]["frml_name"].ToString();
                lstBoppFormulationList[i].description = DS.Tables[0].Rows[i]["frml_description"].ToString();
                lstBoppFormulationList[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["frml_fkBopp"]);
                lstBoppFormulationList[i].BoppCode = DS.Tables[0].Rows[i]["frml_BoppCode"].ToString();
                lstBoppFormulationList[i].BoppName = DS.Tables[0].Rows[i]["frml_BoppName"].ToString();
                lstBoppFormulationList[i].thick = Convert.ToDouble(DS.Tables[0].Rows[i]["frml_thick"]);
                lstBoppFormulationList[i].thickLayerC1 = Convert.ToDouble(DS.Tables[0].Rows[i]["frml_thickLayerC1"]);
                lstBoppFormulationList[i].thickLayerC2 = Convert.ToDouble(DS.Tables[0].Rows[i]["frml_thickLayerC2"]);
                lstBoppFormulationList[i].thickLayerC3 = Convert.ToDouble(DS.Tables[0].Rows[i]["frml_thickLayerC3"]);
                lstBoppFormulationList[i].thickLayerC4 = Convert.ToDouble(DS.Tables[0].Rows[i]["frml_thickLayerC4"]);
                lstBoppFormulationList[i].thickCentralLayer = Convert.ToDouble(DS.Tables[0].Rows[i]["frml_thickCentralLayer"]);
            }
            return lstBoppFormulationList;
        }

        public static clsFormulation getFormulationBoppDetail(int codsec)
        {
            clsFormulation objBoppFormulationListDetail = new clsFormulation();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spFormulationByCodsec(" + codsec.ToString() + ")");

            objBoppFormulationListDetail.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["frml_codsec"]);
            objBoppFormulationListDetail.name = DS.Tables[0].Rows[0]["frml_name"].ToString();
            objBoppFormulationListDetail.description = DS.Tables[0].Rows[0]["frml_description"].ToString();
            objBoppFormulationListDetail.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["frml_fkBopp"]);
            objBoppFormulationListDetail.BoppCode = DS.Tables[0].Rows[0]["frml_BoppCode"].ToString();
            objBoppFormulationListDetail.BoppName = DS.Tables[0].Rows[0]["frml_BoppName"].ToString();
            objBoppFormulationListDetail.fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["frml_fkCast"]);
            objBoppFormulationListDetail.CastCode = DS.Tables[0].Rows[0]["frml_CastCode"].ToString();
            objBoppFormulationListDetail.CastName = DS.Tables[0].Rows[0]["frml_CastName"].ToString();
            objBoppFormulationListDetail.thick = Convert.ToDouble(DS.Tables[0].Rows[0]["frml_thick"]);
            objBoppFormulationListDetail.thickLayerC1 = Convert.ToDouble(DS.Tables[0].Rows[0]["frml_thickLayerC1"]);
            objBoppFormulationListDetail.thickLayerC2 = Convert.ToDouble(DS.Tables[0].Rows[0]["frml_thickLayerC2"]);
            objBoppFormulationListDetail.thickLayerC3 = Convert.ToDouble(DS.Tables[0].Rows[0]["frml_thickLayerC3"]);
            objBoppFormulationListDetail.thickLayerC4 = Convert.ToDouble(DS.Tables[0].Rows[0]["frml_thickLayerC4"]);
            objBoppFormulationListDetail.thickCentralLayer = Convert.ToDouble(DS.Tables[0].Rows[0]["frml_thickCentralLayer"]);
            objBoppFormulationListDetail.lstRawMaterialByFormulation = clsRawMaterialByFormulation.getListByFormulation(objBoppFormulationListDetail.codsec);

            return objBoppFormulationListDetail;
        }

        public static List<clsFormulation> getListCast()
        {
            List<clsFormulation> lstCastFormulationList = new List<clsFormulation>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spFormulationListCast()");

            lstCastFormulationList.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstCastFormulationList.Add(new clsFormulation());
                lstCastFormulationList[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["frml_codsec"]);
                lstCastFormulationList[i].name = DS.Tables[0].Rows[i]["frml_name"].ToString();
                lstCastFormulationList[i].description = DS.Tables[0].Rows[i]["frml_description"].ToString();
                lstCastFormulationList[i].CastCode = DS.Tables[0].Rows[i]["frml_CastCode"].ToString();


            }
            return lstCastFormulationList;
        }

        public static List<clsFormulation> getListByCastFilm(int castFilmCodsec)
        {
            List<clsFormulation> lstCastFormulationList = new List<clsFormulation>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spFormulationByCastFilm(" + castFilmCodsec.ToString() + ")");

            lstCastFormulationList.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstCastFormulationList.Add(new clsFormulation());
                lstCastFormulationList[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["frml_codsec"]);
                lstCastFormulationList[i].name = DS.Tables[0].Rows[i]["frml_name"].ToString();
                lstCastFormulationList[i].description = DS.Tables[0].Rows[i]["frml_description"].ToString();
                lstCastFormulationList[i].CastCode = DS.Tables[0].Rows[i]["frml_CastCode"].ToString();
                lstCastFormulationList[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["frml_fkCast"]);

            }
            return lstCastFormulationList;
        }

        public static clsFormulation getFormulationCastDetail(int codsec)
        {
            clsFormulation objCastFormulationListDetail = new clsFormulation();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spFormulationByCodsec(" + codsec.ToString() + ")");

            objCastFormulationListDetail.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["frml_codsec"]);
            objCastFormulationListDetail.name = DS.Tables[0].Rows[0]["frml_name"].ToString();
            objCastFormulationListDetail.description = DS.Tables[0].Rows[0]["frml_description"].ToString();
            objCastFormulationListDetail.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["frml_fkBopp"]);
            objCastFormulationListDetail.BoppCode = DS.Tables[0].Rows[0]["frml_BoppCode"].ToString();
            objCastFormulationListDetail.BoppName = DS.Tables[0].Rows[0]["frml_BoppName"].ToString();
            objCastFormulationListDetail.fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["frml_fkCast"]);
            objCastFormulationListDetail.CastCode = DS.Tables[0].Rows[0]["frml_CastCode"].ToString();
            objCastFormulationListDetail.CastName = DS.Tables[0].Rows[0]["frml_CastName"].ToString();
            objCastFormulationListDetail.thick = Convert.ToDouble(DS.Tables[0].Rows[0]["frml_thick"]);
            objCastFormulationListDetail.thickLayerC1 = Convert.ToDouble(DS.Tables[0].Rows[0]["frml_thickLayerC1"]);
            objCastFormulationListDetail.thickLayerC2 = Convert.ToDouble(DS.Tables[0].Rows[0]["frml_thickLayerC2"]);
            objCastFormulationListDetail.thickLayerC3 = Convert.ToDouble(DS.Tables[0].Rows[0]["frml_thickLayerC3"]);
            objCastFormulationListDetail.thickLayerC4 = Convert.ToDouble(DS.Tables[0].Rows[0]["frml_thickLayerC4"]);
            objCastFormulationListDetail.thickCentralLayer = Convert.ToDouble(DS.Tables[0].Rows[0]["frml_thickCentralLayer"]);
            objCastFormulationListDetail.lstRawMaterialByFormulation = clsRawMaterialByFormulation.getListByFormulation(objCastFormulationListDetail.codsec);

            return objCastFormulationListDetail;
        }

        public int getLastSavedCodsec()
        {
            DataSet DS = new DataSet();
            DataSet DSUser = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_formulation ORDER BY frml_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["frml_codsec"]);

        }



        public override string ToString()
        {
            return this.name;
        }

        public static bool delete(int codsec)
        {
            try
            {
                string queryString = "";
                queryString += "UPDATE bps_prod_formulation SET fml_isVisible = 0 WHERE frml_codsec = " + codsec.ToString();
                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCity.save");
                return false;
            }
        }

        public static bool deleteRawMaterial(int codsec)
        {
            try
            {
                string queryString = "";
                queryString += "DELETE FROM bps_prod_rawmateriabyformulation WHERE rwt_fkFormulation = " + codsec.ToString();
                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCity.save");
                return false;
            }
        }


        #region Formulation Reload

        public int saveReload()
        {
            try
            {
                string queryString = "";

                queryString += "INSERT INTO bps_prod_formulationrealod (frml_fkBopp,frml_name, frml_description,frml_thick,frml_thickLayerC1,frml_thickLayerC2,frml_thickLayerC3,frml_thickLayerC4,frml_thickCentralLayer)";
                queryString += " VALUES (";
                queryString += this.fkBopp.ToString() + ",";
                queryString += "'" + this.name + "',";
                queryString += "'" + this.description + "',";
                queryString += this.thick.ToString() + ",";
                queryString += this.thickLayerC1.ToString() + ",";
                queryString += this.thickLayerC2.ToString() + ",";
                queryString += this.thickLayerC3.ToString() + ",";
                queryString += this.thickLayerC4.ToString() + ",";
                queryString += this.thickCentralLayer.ToString() + "";
                queryString += ");";

                clsConnection.executeQuery(queryString);

                if (this.codsec == 0)
                    this.codsec = getLastSavedCodsecReload();

                queryString = "";
                queryString += "INSERT INTO bps_prod_formulationperfilmproductionplanreload (fpfpp_fkFilmProductionPlan,fpfpp_fkFormulation, fpfpp_createdDate,fpfpp_createdBy)";
                queryString += " VALUES (";
                queryString += this.fkCoating.ToString() + ",";
                queryString += this.codsec.ToString() + ",";
                queryString += "GETDATE(),";
                queryString += clsGlobal.LoggedUser.codsec.ToString() + "";
                queryString += ");";

                clsConnection.executeQuery(queryString);

                return this.codsec;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int getLastSavedCodsecReload()
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_formulationrealod ORDER BY frml_codsec DESC LIMIT 1");
            return Convert.ToInt32(DS.Tables[0].Rows[0]["frml_codsec"]);
        }

        #endregion
    }
}

