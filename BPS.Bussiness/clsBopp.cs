using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que maneja peliculas BOPP
    /// </summary>
    public class clsBopp
    {
        //Atributes

        private int bopp_codsec;
        private int bopp_fkFamily;
        private clsFamily bopp_Family;
        private string bopp_FamilyName;
        private int bopp_fkSubFamily;
        private clsFamily bopp_SubFamily;
        private string bopp_SubFamilyName;
        private int bopp_fkInnerSeal;
        private clsSeal bopp_InnerSeal;
        private string bopp_InnerSealName;
        private int bopp_fkOuterSeal;
        private clsSeal bopp_OuterSeal;
        private string bopp_OuterSealName;
        private int bopp_fkCentralAdditivation;
        private clsAdditivation bopp_CentralAdditivation;
        private string bopp_CentralAdditivationName;
        private int bopp_fkSurfaceAdditivation;
        private clsAdditivation bopp_SurfaceAdditivation;
        private string bopp_SurfaceAdditivationName;
        private int bopp_fkThickness;
        private clsThickness bopp_Thickness;
        private string bopp_ThicknessValue;
        private int bopp_fkTreatment;
        private clsTreatment bopp_Treatment;
        private string bopp_TreatmentName;
        private string bopp_name;
        private string bopp_code;
        private Boolean bopp_isBaseFilm;
        private double bopp_salesOrderQuantity;
        private double bopp_mainCoilQuantity;
        private int bopp_fkBaseFilm;
        private string bopp_baseFilmCode;
        private string bopp_baseFilmName;
        private string bopp_externalID;
        private string bopp_externalDescription;
        private string bopp_externalCode;
        private double bopp_density;
        private bool bopp_ismaquile;
        private double bopp_weigth;
        private string bopp_width;
        private double bopp_maqweigth;
        private string bopp_maqwidth;
        private int bopp_metalcodsec;
        private string bopp_metalName;
        private int bopp_leadTime;

        //Properties

        public int codsec { get { return bopp_codsec; } set { bopp_codsec = value; } }

        public int fkFamily { get { return bopp_fkFamily; } set { bopp_fkFamily = value; } }

        public clsFamily Family { get { return bopp_Family; } set { bopp_Family = value; } }

        public int fkSubFamily { get { return bopp_fkSubFamily; } set { bopp_fkSubFamily = value; } }

        public clsFamily SubFamily { get { return bopp_SubFamily; } set { bopp_SubFamily = value; } }

        public int fkInnerSeal { get { return bopp_fkInnerSeal; } set { bopp_fkInnerSeal = value; } }

        public clsSeal InnerSeal { get { return bopp_InnerSeal; } set { bopp_InnerSeal = value; } }

        public int fkOuterSeal { get { return bopp_fkOuterSeal; } set { bopp_fkOuterSeal = value; } }

        public clsSeal OuterSeal { get { return bopp_OuterSeal; } set { bopp_OuterSeal = value; } }

        public int fkCentralAdditivation { get { return bopp_fkCentralAdditivation; } set { bopp_fkCentralAdditivation = value; } }

        public clsAdditivation CentralAdditivation { get { return bopp_CentralAdditivation; } set { bopp_CentralAdditivation = value; } }

        public int fkSurfaceAdditivation { get { return bopp_fkSurfaceAdditivation; } set { bopp_fkSurfaceAdditivation = value; } }

        public clsAdditivation SurfaceAdditivation { get { return bopp_SurfaceAdditivation; } set { bopp_SurfaceAdditivation = value; } }

        public int fkThickness { get { return bopp_fkThickness; } set { bopp_fkThickness = value; } }

        public clsThickness Thickness { get { return bopp_Thickness; } set { bopp_Thickness = value; } }

        public int fkTreatment { get { return bopp_fkTreatment; } set { bopp_fkTreatment = value; } }

        public clsTreatment Treatment { get { return bopp_Treatment; } set { bopp_Treatment = value; } }

        public string name { get { return bopp_name; } set { bopp_name = value; } }

        public string code { get { return bopp_code; } set { bopp_code = value; } }

        public Boolean isBaseFilm { get { return bopp_isBaseFilm; } set { bopp_isBaseFilm = value; } }

        public string familyName { get { return bopp_FamilyName; } set { bopp_FamilyName = value; } }

        public string subFamilyName { get { return bopp_SubFamilyName; } set { bopp_SubFamilyName = value; } }

        public string innerSealName { get { return bopp_InnerSealName; } set { bopp_InnerSealName = value; } }

        public string outerSealName { get { return bopp_OuterSealName; } set { bopp_OuterSealName = value; } }

        public string centralAdditivationName { get { return bopp_CentralAdditivationName; } set { bopp_CentralAdditivationName = value; } }

        public string surfaceAdditivationName { get { return bopp_SurfaceAdditivationName; } set { bopp_SurfaceAdditivationName = value; } }

        public string thicknessValue { get { return bopp_ThicknessValue; } set { bopp_ThicknessValue = value; } }

        public string treatmentName { get { return bopp_TreatmentName; } set { bopp_TreatmentName = value; } }

        public double salesOrderQuantity { get { return bopp_salesOrderQuantity; } set { bopp_salesOrderQuantity = value; } }

        public double mainCoilQuantity { get { return bopp_mainCoilQuantity; } set { bopp_mainCoilQuantity = value; } }

        public int fkBaseFilm { get { return bopp_fkBaseFilm; } set { bopp_fkBaseFilm = value; } }

        public string baseFilmCode { get { return bopp_baseFilmCode; } set { bopp_baseFilmCode = value; } }

        public string baseFilmName { get { return bopp_baseFilmName; } set { bopp_baseFilmName = value; } }

        public string externalID { get { return bopp_externalID; } set { bopp_externalID = value; } }

        public string externalDescription { get { return bopp_externalDescription; } set { bopp_externalDescription = value; } }

        public string externalCode { get { return bopp_externalCode; } set { bopp_externalCode = value; } }

        public double density { get { return bopp_density; } set { bopp_density = value; } }

        public bool ismaquile { get { return bopp_ismaquile; } set { bopp_ismaquile = value; } }

        public double weigth { get { return bopp_weigth; } set { bopp_weigth = value; } }

        public string width { get { return bopp_width; } set { bopp_width = value; } }

        public double maqweigth { get { return bopp_maqweigth; } set { bopp_maqweigth = value; } }

        public string maqwidth { get { return bopp_maqwidth; } set { bopp_maqwidth = value; } }

        public int metalcodsec { get { return bopp_metalcodsec; } set { bopp_metalcodsec = value; } }

        public string metalName { get { return bopp_metalName; } set { bopp_metalName = value; } }

        public int leadTime { get { return bopp_leadTime; } set { bopp_leadTime = value; } }

        //Constructor

        public clsBopp()
        {
            bopp_codsec = 0;
            bopp_fkFamily = 0;
            bopp_Family = new clsFamily();
            bopp_FamilyName = "";
            bopp_fkSubFamily = 0;
            bopp_SubFamily = new clsFamily();
            bopp_SubFamilyName = "";
            bopp_fkInnerSeal = 0;
            bopp_InnerSeal = new clsSeal();
            bopp_InnerSealName = "";
            bopp_fkOuterSeal = 0;
            bopp_OuterSeal = new clsSeal();
            bopp_OuterSealName = "";
            bopp_fkCentralAdditivation = 0;
            bopp_CentralAdditivation = new clsAdditivation();
            bopp_CentralAdditivationName = "";
            bopp_fkSurfaceAdditivation = 0;
            bopp_SurfaceAdditivation = new clsAdditivation();
            bopp_SurfaceAdditivationName = "";
            bopp_fkThickness = 0;
            bopp_Thickness = new clsThickness();
            bopp_ThicknessValue = "";
            bopp_fkTreatment = 0;
            bopp_Treatment = new clsTreatment();
            bopp_TreatmentName = "";
            bopp_name = "";
            bopp_code = "";
            bopp_isBaseFilm = false;
            bopp_salesOrderQuantity = 0; ;
            bopp_mainCoilQuantity = 0;
            bopp_fkBaseFilm = 0;
            bopp_baseFilmCode = "";
            bopp_baseFilmName = "";
            bopp_externalID = "";
            bopp_externalDescription = "";
            bopp_externalCode = "";
            bopp_density = 0;
            bopp_ismaquile = false;
            bopp_weigth = 0;
            bopp_width = "";
            bopp_maqweigth = 0;
            bopp_maqwidth = "";
            bopp_metalcodsec = 0;
            bopp_metalName = "";
            bopp_leadTime = 0;
        }

        public clsBopp(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spBoopMultiple " + codsec.ToString() + ",0,'','','','', 'BoppFilmByCodsec'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["bopp_codsec"]);
                this.fkFamily = Convert.ToInt32(DS.Tables[0].Rows[0]["bopp_fkFamily"]);
                this.Family = new clsFamily(Convert.ToInt32(DS.Tables[0].Rows[0]["bopp_fkFamily"]));
                this.familyName = DS.Tables[0].Rows[0]["bopp_FamilyName"].ToString();
                this.fkSubFamily = Convert.ToInt32(DS.Tables[0].Rows[0]["bopp_fkSubFamily"]);
                this.SubFamily = new clsFamily(Convert.ToInt32(DS.Tables[0].Rows[0]["bopp_fkSubFamily"]));
                this.subFamilyName = DS.Tables[0].Rows[0]["bopp_SubFamilyName"].ToString();
                this.fkInnerSeal = Convert.ToInt32(DS.Tables[0].Rows[0]["bopp_fkInnerSeal"]);
                this.InnerSeal = new clsSeal(Convert.ToInt32(DS.Tables[0].Rows[0]["bopp_fkInnerSeal"]));
                this.innerSealName = DS.Tables[0].Rows[0]["bopp_innerSealName"].ToString();
                this.fkOuterSeal = Convert.ToInt32(DS.Tables[0].Rows[0]["bopp_fkOuterSeal"]);
                this.OuterSeal = new clsSeal(Convert.ToInt32(DS.Tables[0].Rows[0]["bopp_fkOuterSeal"]));
                this.outerSealName = DS.Tables[0].Rows[0]["bopp_outerSealName"].ToString();
                this.fkCentralAdditivation = Convert.ToInt32(DS.Tables[0].Rows[0]["bopp_fkCentralAdditivation"]);
                this.CentralAdditivation = new clsAdditivation(Convert.ToInt32(DS.Tables[0].Rows[0]["bopp_fkCentralAdditivation"]));
                this.centralAdditivationName = DS.Tables[0].Rows[0]["bopp_centralAdditivationName"].ToString();
                this.fkSurfaceAdditivation = Convert.ToInt32(DS.Tables[0].Rows[0]["bopp_fkSurfaceAdditivation"]);
                this.SurfaceAdditivation = new clsAdditivation(Convert.ToInt32(DS.Tables[0].Rows[0]["bopp_fkSurfaceAdditivation"]));
                this.surfaceAdditivationName = DS.Tables[0].Rows[0]["bopp_surfaceAdditivationName"].ToString();
                this.fkThickness = Convert.ToInt32(DS.Tables[0].Rows[0]["bopp_fkThickness"]);
                this.Thickness = new clsThickness(Convert.ToInt32(DS.Tables[0].Rows[0]["bopp_fkThickness"]));
                this.thicknessValue = DS.Tables[0].Rows[0]["bopp_thicknessValue"].ToString();
                this.fkTreatment = Convert.ToInt32(DS.Tables[0].Rows[0]["bopp_fkTreatment"]);
                this.Treatment = new clsTreatment(Convert.ToInt32(DS.Tables[0].Rows[0]["bopp_fkTreatment"]));
                this.treatmentName = DS.Tables[0].Rows[0]["bopp_treatmentName"].ToString();
                this.name = DS.Tables[0].Rows[0]["bopp_name"].ToString();
                this.code = DS.Tables[0].Rows[0]["bopp_code"].ToString();
                this.isBaseFilm = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["bopp_isBaseFilm"], DS.Tables[0].Rows[0]["bopp_isBaseFilm"].GetType().FullName);
                this.externalID = DS.Tables[0].Rows[0]["bopp_externalID"].ToString();
                this.externalDescription = DS.Tables[0].Rows[0]["bopp_externalDescription"].ToString();
                this.externalCode = DS.Tables[0].Rows[0]["bopp_externalCode"].ToString();
                this.density = Convert.ToDouble(DS.Tables[0].Rows[0]["bopp_density"]);
                this.leadTime = Convert.ToInt32(DS.Tables[0].Rows[0]["bopp_leadTime"]);
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_bopp(bopp_fkFamily,bopp_fkSubFamily,bopp_fkInnerSeal,bopp_fkOuterSeal,bopp_fkCentralAdditivation,bopp_fkSurfaceAdditivation,bopp_fkThickness,bopp_fkTreatment,bopp_name,bopp_code,bopp_isBaseFilm, bopp_density, bopp_leadTime)";
                    queryString += " VALUES (";
                    queryString += this.fkFamily.ToString() + ",";
                    queryString += this.fkSubFamily.ToString() + ",";
                    queryString += this.fkInnerSeal.ToString() + ",";
                    queryString += this.fkOuterSeal.ToString() + ",";
                    queryString += this.fkCentralAdditivation.ToString() + ",";
                    queryString += this.fkSurfaceAdditivation.ToString() + ",";
                    queryString += this.fkThickness.ToString() + ",";
                    queryString += this.fkTreatment.ToString() + ",";
                    queryString += "'" + this.name + "',";
                    queryString += "'" + this.code + "',";
                    queryString += "" + this.isBaseFilm + ", ";
                    queryString += "" + this.density.ToString() + ", ";
                    queryString += this.leadTime.ToString() + " ";
                    queryString += ");";
                    return clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_prod_bopp";
                    queryString += " SET ";
                    queryString += "bopp_fkFamily = " + this.fkFamily.ToString() + ",";
                    queryString += "bopp_fkSubFamily = " + this.fkSubFamily.ToString() + ",";
                    queryString += "bopp_fkInnerSeal = " + this.fkInnerSeal.ToString() + ",";
                    queryString += "bopp_fkOuterSeal = " + this.fkOuterSeal.ToString() + ",";
                    queryString += "bopp_fkCentralAdditivation = " + this.fkCentralAdditivation.ToString() + ",";
                    queryString += "bopp_fkSurfaceAdditivation = " + this.fkSurfaceAdditivation.ToString() + ",";
                    queryString += "bopp_fkThickness = " + this.fkThickness.ToString() + ",";
                    queryString += "bopp_fkTreatment = " + this.fkTreatment.ToString() + ",";
                    queryString += "bopp_name = '" + this.name + "',";
                    queryString += "bopp_code = '" + this.code + "',";
                    queryString += "bopp_isBaseFilm = " + this.isBaseFilm.ToString() + ", ";
                    queryString += "bopp_density = " + this.density.ToString() + ", ";
                    queryString += "bopp_leadTime = " + this.leadTime.ToString() + "";
                    queryString += " WHERE bopp_codsec = " + this.codsec.ToString() + ";";
                    return clsConnection.executeQuery(queryString);

                }
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsBopp.save");
                return false;
            }
        }

        public static List<clsBopp> getList()
        {
            List<clsBopp> lstBopp = new List<clsBopp>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spBoopMultiple 0,0,'','','','','BoppFilmList'");

            lstBopp.Clear();

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstBopp.Add(new clsBopp());
                    lstBopp[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_codsec"]);
                    lstBopp[i].fkFamily = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkFamily"]);
                    lstBopp[i].Family = new clsFamily(Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkFamily"]));
                    lstBopp[i].familyName = DS.Tables[0].Rows[i]["bopp_FamilyName"].ToString();
                    lstBopp[i].fkSubFamily = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkSubFamily"]);
                    lstBopp[i].SubFamily = new clsFamily(Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkSubFamily"]));
                    lstBopp[i].subFamilyName = DS.Tables[0].Rows[i]["bopp_SubFamilyName"].ToString();
                    lstBopp[i].fkInnerSeal = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkInnerSeal"]);
                    lstBopp[i].InnerSeal = new clsSeal(Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkInnerSeal"]));
                    lstBopp[i].innerSealName = DS.Tables[0].Rows[i]["bopp_innerSealName"].ToString();
                    lstBopp[i].fkOuterSeal = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkOuterSeal"]);
                    lstBopp[i].OuterSeal = new clsSeal(Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkOuterSeal"]));
                    lstBopp[i].outerSealName = DS.Tables[0].Rows[i]["bopp_outerSealName"].ToString();
                    lstBopp[i].fkCentralAdditivation = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkCentralAdditivation"]);
                    lstBopp[i].CentralAdditivation = new clsAdditivation(Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkCentralAdditivation"]));
                    lstBopp[i].centralAdditivationName = DS.Tables[0].Rows[i]["bopp_centralAdditivationName"].ToString();
                    lstBopp[i].fkSurfaceAdditivation = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkSurfaceAdditivation"]);
                    lstBopp[i].SurfaceAdditivation = new clsAdditivation(Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkSurfaceAdditivation"]));
                    lstBopp[i].surfaceAdditivationName = DS.Tables[0].Rows[i]["bopp_surfaceAdditivationName"].ToString();
                    lstBopp[i].fkThickness = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkThickness"]);
                    lstBopp[i].Thickness = new clsThickness(Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkThickness"]));
                    lstBopp[i].thicknessValue = DS.Tables[0].Rows[i]["bopp_thicknessValue"].ToString();
                    lstBopp[i].fkTreatment = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkTreatment"]);
                    lstBopp[i].Treatment = new clsTreatment(Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkTreatment"]));
                    lstBopp[i].treatmentName = DS.Tables[0].Rows[i]["bopp_treatmentName"].ToString();
                    lstBopp[i].name = DS.Tables[0].Rows[i]["bopp_name"].ToString();
                    lstBopp[i].code = DS.Tables[0].Rows[i]["bopp_code"].ToString();
                    lstBopp[i].isBaseFilm = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["bopp_isBaseFilm"], DS.Tables[0].Rows[i]["bopp_isBaseFilm"].GetType().FullName);
                    lstBopp[i].fkBaseFilm = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkBaseFilm"]);
                    lstBopp[i].baseFilmCode = DS.Tables[0].Rows[i]["bopp_baseFilmCode"].ToString();
                    lstBopp[i].baseFilmName = DS.Tables[0].Rows[i]["bopp_baseFilmName"].ToString();
                    lstBopp[i].externalID = DS.Tables[0].Rows[i]["bopp_externalID"].ToString();
                    lstBopp[i].externalDescription = DS.Tables[0].Rows[i]["bopp_externalDescription"].ToString();
                    lstBopp[i].externalCode = DS.Tables[0].Rows[i]["bopp_externalCode"].ToString();
                    lstBopp[i].leadTime = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_leadTime"]);
                }
            }
            return lstBopp;
        }

        public static List<clsBopp> getListShort()
        {
            List<clsBopp> lstBopp = new List<clsBopp>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spBoopMultiple 0,0,'','','','','BoppFilmList'");

            lstBopp.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstBopp.Add(new clsBopp());
                lstBopp[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_codsec"]);
                lstBopp[i].name = DS.Tables[0].Rows[i]["bopp_name"].ToString();
                lstBopp[i].code = DS.Tables[0].Rows[i]["bopp_code"].ToString();
            }


            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return lstBopp;
        }

        public static List<clsBopp> getSimplifiedList()
        {
            List<clsBopp> lstBopp = new List<clsBopp>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spBoopMultiple 0,0,'','','','','BoppFilmListOrderByCode'");

            lstBopp.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstBopp.Add(new clsBopp());
                lstBopp[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_codsec"]);
                lstBopp[i].fkFamily = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkFamily"]);
                lstBopp[i].familyName = DS.Tables[0].Rows[i]["bopp_FamilyName"].ToString();
                lstBopp[i].fkSubFamily = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkSubFamily"]);
                lstBopp[i].subFamilyName = DS.Tables[0].Rows[i]["bopp_SubFamilyName"].ToString();
                lstBopp[i].fkInnerSeal = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkInnerSeal"]);
                lstBopp[i].innerSealName = DS.Tables[0].Rows[i]["bopp_innerSealName"].ToString();
                lstBopp[i].fkOuterSeal = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkOuterSeal"]);
                lstBopp[i].outerSealName = DS.Tables[0].Rows[i]["bopp_outerSealName"].ToString();
                lstBopp[i].fkCentralAdditivation = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkCentralAdditivation"]);
                lstBopp[i].centralAdditivationName = DS.Tables[0].Rows[i]["bopp_centralAdditivationName"].ToString();
                lstBopp[i].fkSurfaceAdditivation = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkSurfaceAdditivation"]);
                lstBopp[i].surfaceAdditivationName = DS.Tables[0].Rows[i]["bopp_surfaceAdditivationName"].ToString();
                lstBopp[i].fkThickness = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkThickness"]);
                lstBopp[i].thicknessValue = DS.Tables[0].Rows[i]["bopp_thicknessValue"].ToString();
                lstBopp[i].fkTreatment = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkTreatment"]);
                lstBopp[i].treatmentName = DS.Tables[0].Rows[i]["bopp_treatmentName"].ToString();
                lstBopp[i].name = DS.Tables[0].Rows[i]["bopp_name"].ToString();
                lstBopp[i].code = DS.Tables[0].Rows[i]["bopp_code"].ToString();
                lstBopp[i].isBaseFilm = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["bopp_isBaseFilm"], DS.Tables[0].Rows[i]["bopp_isBaseFilm"].GetType().FullName);
                lstBopp[i].fkBaseFilm = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkBaseFilm"]);
                lstBopp[i].baseFilmCode = DS.Tables[0].Rows[i]["bopp_baseFilmCode"].ToString();
                lstBopp[i].baseFilmName = DS.Tables[0].Rows[i]["bopp_baseFilmName"].ToString();
                lstBopp[i].externalID = DS.Tables[0].Rows[i]["bopp_externalID"].ToString();
                lstBopp[i].externalDescription = DS.Tables[0].Rows[i]["bopp_externalDescription"].ToString();
                lstBopp[i].externalCode = DS.Tables[0].Rows[i]["bopp_externalCode"].ToString();
                lstBopp[i].leadTime = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_leadTime"]);
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return lstBopp;
        }

        public static List<clsBopp> getSimplifiedListWithSalesOrderQuantitiesByFilter(List<clsFilter> lstFilter)
        {
            List<clsBopp> lstBopp = new List<clsBopp>();
            DataSet DS = new DataSet();
            string where = "";

            if (clsFilter.getSql(lstFilter) != "")
                where = " WHERE " + clsFilter.getSql(lstFilter);

            DS = clsConnection.getDataSetResult("SELECT * FROM vwboppfilmwithtotalkilograms" + where);

            lstBopp.Clear();

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstBopp.Add(new clsBopp());
                    lstBopp[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_codsec"]);
                    lstBopp[i].fkFamily = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkFamily"]);
                    lstBopp[i].familyName = DS.Tables[0].Rows[i]["bopp_FamilyName"].ToString();
                    lstBopp[i].fkSubFamily = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkSubFamily"]);
                    lstBopp[i].subFamilyName = DS.Tables[0].Rows[i]["bopp_SubFamilyName"].ToString();
                    lstBopp[i].fkInnerSeal = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkInnerSeal"]);
                    lstBopp[i].innerSealName = DS.Tables[0].Rows[i]["bopp_innerSealName"].ToString();
                    lstBopp[i].fkOuterSeal = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkOuterSeal"]);
                    lstBopp[i].outerSealName = DS.Tables[0].Rows[i]["bopp_outerSealName"].ToString();
                    lstBopp[i].fkCentralAdditivation = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkCentralAdditivation"]);
                    lstBopp[i].centralAdditivationName = DS.Tables[0].Rows[i]["bopp_centralAdditivationName"].ToString();
                    lstBopp[i].fkSurfaceAdditivation = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkSurfaceAdditivation"]);
                    lstBopp[i].surfaceAdditivationName = DS.Tables[0].Rows[i]["bopp_surfaceAdditivationName"].ToString();
                    lstBopp[i].fkThickness = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkThickness"]);
                    lstBopp[i].thicknessValue = DS.Tables[0].Rows[i]["bopp_thicknessValue"].ToString();
                    lstBopp[i].fkTreatment = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkTreatment"]);
                    lstBopp[i].treatmentName = DS.Tables[0].Rows[i]["bopp_treatmentName"].ToString();
                    lstBopp[i].name = DS.Tables[0].Rows[i]["bopp_name"].ToString();
                    lstBopp[i].code = DS.Tables[0].Rows[i]["bopp_code"].ToString();
                    lstBopp[i].isBaseFilm = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["bopp_isBaseFilm"], DS.Tables[0].Rows[i]["bopp_isBaseFilm"].GetType().FullName);
                    lstBopp[i].salesOrderQuantity = Convert.ToDouble(DS.Tables[0].Rows[i]["bopp_salesOrderQuantity"]);
                    lstBopp[i].fkBaseFilm = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkBaseFilm"]);
                    lstBopp[i].baseFilmCode = DS.Tables[0].Rows[i]["bopp_baseFilmCode"].ToString();
                    lstBopp[i].baseFilmName = DS.Tables[0].Rows[i]["bopp_baseFilmName"].ToString();
                    lstBopp[i].externalID = DS.Tables[0].Rows[i]["bopp_externalID"].ToString();
                    lstBopp[i].externalDescription = DS.Tables[0].Rows[i]["bopp_externalDescription"].ToString();
                    lstBopp[i].externalCode = DS.Tables[0].Rows[i]["bopp_externalCode"].ToString();
                    lstBopp[i].leadTime = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_leadTime"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return lstBopp;
        }

        public static List<clsBopp> getSimplifiedListWithSalesOrderQuantities()
        {
            List<clsBopp> lstBopp = new List<clsBopp>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwboppfilmwithtotalkilograms");

            lstBopp.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstBopp.Add(new clsBopp());
                lstBopp[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_codsec"]);
                lstBopp[i].fkFamily = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkFamily"]);
                lstBopp[i].familyName = DS.Tables[0].Rows[i]["bopp_FamilyName"].ToString();
                lstBopp[i].fkSubFamily = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkSubFamily"]);
                lstBopp[i].subFamilyName = DS.Tables[0].Rows[i]["bopp_SubFamilyName"].ToString();
                lstBopp[i].fkInnerSeal = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkInnerSeal"]);
                lstBopp[i].innerSealName = DS.Tables[0].Rows[i]["bopp_innerSealName"].ToString();
                lstBopp[i].fkOuterSeal = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkOuterSeal"]);
                lstBopp[i].outerSealName = DS.Tables[0].Rows[i]["bopp_outerSealName"].ToString();
                lstBopp[i].fkCentralAdditivation = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkCentralAdditivation"]);
                lstBopp[i].centralAdditivationName = DS.Tables[0].Rows[i]["bopp_centralAdditivationName"].ToString();
                lstBopp[i].fkSurfaceAdditivation = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkSurfaceAdditivation"]);
                lstBopp[i].surfaceAdditivationName = DS.Tables[0].Rows[i]["bopp_surfaceAdditivationName"].ToString();
                lstBopp[i].fkThickness = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkThickness"]);
                lstBopp[i].thicknessValue = DS.Tables[0].Rows[i]["bopp_thicknessValue"].ToString();
                lstBopp[i].fkTreatment = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkTreatment"]);
                lstBopp[i].treatmentName = DS.Tables[0].Rows[i]["bopp_treatmentName"].ToString();
                lstBopp[i].name = DS.Tables[0].Rows[i]["bopp_name"].ToString();
                lstBopp[i].code = DS.Tables[0].Rows[i]["bopp_code"].ToString();
                lstBopp[i].isBaseFilm = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["bopp_isBaseFilm"], DS.Tables[0].Rows[i]["bopp_isBaseFilm"].GetType().FullName);
                lstBopp[i].salesOrderQuantity = Convert.ToDouble(DS.Tables[0].Rows[i]["bopp_salesOrderQuantity"]);
                lstBopp[i].fkBaseFilm = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkBaseFilm"]);
                lstBopp[i].baseFilmCode = DS.Tables[0].Rows[i]["bopp_baseFilmCode"].ToString();
                lstBopp[i].baseFilmName = DS.Tables[0].Rows[i]["bopp_baseFilmName"].ToString();
                lstBopp[i].externalID = DS.Tables[0].Rows[i]["bopp_externalID"].ToString();
                lstBopp[i].externalDescription = DS.Tables[0].Rows[i]["bopp_externalDescription"].ToString();
                lstBopp[i].externalCode = DS.Tables[0].Rows[i]["bopp_externalCode"].ToString();
                lstBopp[i].leadTime = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_leadTime"]);
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return lstBopp;
        }

        public static List<clsBopp> getSimplifiedListWithQuantities()
        {
            List<clsBopp> lstBopp = new List<clsBopp>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spBoppFilmWithTotalKilograms();");

            lstBopp.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstBopp.Add(new clsBopp());
                lstBopp[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_codsec"]);
                lstBopp[i].fkFamily = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkFamily"]);
                lstBopp[i].familyName = DS.Tables[0].Rows[i]["bopp_FamilyName"].ToString();
                lstBopp[i].fkSubFamily = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkSubFamily"]);
                lstBopp[i].subFamilyName = DS.Tables[0].Rows[i]["bopp_SubFamilyName"].ToString();
                lstBopp[i].fkInnerSeal = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkInnerSeal"]);
                lstBopp[i].innerSealName = DS.Tables[0].Rows[i]["bopp_innerSealName"].ToString();
                lstBopp[i].fkOuterSeal = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkOuterSeal"]);
                lstBopp[i].outerSealName = DS.Tables[0].Rows[i]["bopp_outerSealName"].ToString();
                lstBopp[i].fkCentralAdditivation = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkCentralAdditivation"]);
                lstBopp[i].centralAdditivationName = DS.Tables[0].Rows[i]["bopp_centralAdditivationName"].ToString();
                lstBopp[i].fkSurfaceAdditivation = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkSurfaceAdditivation"]);
                lstBopp[i].surfaceAdditivationName = DS.Tables[0].Rows[i]["bopp_surfaceAdditivationName"].ToString();
                lstBopp[i].fkThickness = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkThickness"]);
                lstBopp[i].thicknessValue = DS.Tables[0].Rows[i]["bopp_thicknessValue"].ToString();
                lstBopp[i].fkTreatment = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkTreatment"]);
                lstBopp[i].treatmentName = DS.Tables[0].Rows[i]["bopp_treatmentName"].ToString();
                lstBopp[i].name = DS.Tables[0].Rows[i]["bopp_name"].ToString();
                lstBopp[i].code = DS.Tables[0].Rows[i]["bopp_code"].ToString();
                lstBopp[i].isBaseFilm = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["bopp_isBaseFilm"], DS.Tables[0].Rows[i]["bopp_isBaseFilm"].GetType().FullName);
                lstBopp[i].salesOrderQuantity = Convert.ToDouble(DS.Tables[0].Rows[i]["bopp_salesOrderQuantity"]);
                lstBopp[i].mainCoilQuantity = Convert.ToDouble(DS.Tables[0].Rows[i]["bopp_mainCoilQuantity"]);
                lstBopp[i].fkBaseFilm = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkBaseFilm"]);
                lstBopp[i].baseFilmCode = DS.Tables[0].Rows[i]["bopp_baseFilmCode"].ToString();
                lstBopp[i].baseFilmName = DS.Tables[0].Rows[i]["bopp_baseFilmName"].ToString();
                lstBopp[i].externalID = DS.Tables[0].Rows[i]["bopp_externalID"].ToString();
                lstBopp[i].externalDescription = DS.Tables[0].Rows[i]["bopp_externalDescription"].ToString();
                lstBopp[i].externalCode = DS.Tables[0].Rows[i]["bopp_externalCode"].ToString();
                lstBopp[i].leadTime = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_leadTime"]);
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return lstBopp;
        }

        public static List<clsBopp> getSimplifiedListWithQuantitiesByFilter(List<clsFilter> lstFilter)
        {
            List<clsBopp> lstBopp = new List<clsBopp>();
            DataSet DS = new DataSet();
            string where = "";

            if (clsFilter.getSql(lstFilter) != "")
                where = " WHERE " + clsFilter.getSql(lstFilter);

            DS = clsConnection.getDataSetResult("SELECT * FROM vwboppfilmwithtotalkilograms" + where);

            lstBopp.Clear();

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstBopp.Add(new clsBopp());
                    lstBopp[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_codsec"]);
                    lstBopp[i].fkFamily = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkFamily"]);
                    lstBopp[i].familyName = DS.Tables[0].Rows[i]["bopp_FamilyName"].ToString();
                    lstBopp[i].fkSubFamily = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkSubFamily"]);
                    lstBopp[i].subFamilyName = DS.Tables[0].Rows[i]["bopp_SubFamilyName"].ToString();
                    lstBopp[i].fkInnerSeal = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkInnerSeal"]);
                    lstBopp[i].innerSealName = DS.Tables[0].Rows[i]["bopp_innerSealName"].ToString();
                    lstBopp[i].fkOuterSeal = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkOuterSeal"]);
                    lstBopp[i].outerSealName = DS.Tables[0].Rows[i]["bopp_outerSealName"].ToString();
                    lstBopp[i].fkCentralAdditivation = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkCentralAdditivation"]);
                    lstBopp[i].centralAdditivationName = DS.Tables[0].Rows[i]["bopp_centralAdditivationName"].ToString();
                    lstBopp[i].fkSurfaceAdditivation = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkSurfaceAdditivation"]);
                    lstBopp[i].surfaceAdditivationName = DS.Tables[0].Rows[i]["bopp_surfaceAdditivationName"].ToString();
                    lstBopp[i].fkThickness = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkThickness"]);
                    lstBopp[i].thicknessValue = DS.Tables[0].Rows[i]["bopp_thicknessValue"].ToString();
                    lstBopp[i].fkTreatment = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkTreatment"]);
                    lstBopp[i].treatmentName = DS.Tables[0].Rows[i]["bopp_treatmentName"].ToString();
                    lstBopp[i].name = DS.Tables[0].Rows[i]["bopp_name"].ToString();
                    lstBopp[i].code = DS.Tables[0].Rows[i]["bopp_code"].ToString();
                    lstBopp[i].isBaseFilm = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["bopp_isBaseFilm"], DS.Tables[0].Rows[i]["bopp_isBaseFilm"].GetType().FullName);
                    lstBopp[i].salesOrderQuantity = Convert.ToDouble(DS.Tables[0].Rows[i]["bopp_salesOrderQuantity"]);
                    lstBopp[i].mainCoilQuantity = Convert.ToDouble(DS.Tables[0].Rows[i]["bopp_mainCoilQuantity"]);
                    lstBopp[i].fkBaseFilm = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkBaseFilm"]);
                    lstBopp[i].baseFilmCode = DS.Tables[0].Rows[i]["bopp_baseFilmCode"].ToString();
                    lstBopp[i].baseFilmName = DS.Tables[0].Rows[i]["bopp_baseFilmName"].ToString();
                    lstBopp[i].externalID = DS.Tables[0].Rows[i]["bopp_externalID"].ToString();
                    lstBopp[i].externalDescription = DS.Tables[0].Rows[i]["bopp_externalDescription"].ToString();
                    lstBopp[i].externalCode = DS.Tables[0].Rows[i]["bopp_externalCode"].ToString();
                    lstBopp[i].leadTime = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_leadTime"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return lstBopp;
        }

        public static int getLastSavedCodsec()
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT TOP (1) bps_prod_bopp.bopp_codsec FROM bps_prod_bopp ORDER BY bps_prod_bopp.bopp_codsec DESC");
            return Convert.ToInt32(DS.Tables[0].Rows[0]["bopp_codsec"]);

        }

        public static List<clsBopp> getEquivalentFilmsByBoppFilm(int boppCodsec)
        {
            DataSet DS = new DataSet();
            List<clsBopp> lstEquivalentList = new List<clsBopp>();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_boppfilmequivalence WHERE bfe_fkBopp = " + boppCodsec.ToString());

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstEquivalentList.Add(new clsBopp(Convert.ToInt32(DS.Tables[0].Rows[i]["bfe_fkBoppEquivalence"])));
            }

            return lstEquivalentList;
        }

        public static bool isEquivalent(int boppcodsec, string boppCode)
        {
            List<clsBopp> list = clsBopp.getEquivalentFilmsByBoppFilm(boppcodsec);
            
            bool equivalent = false;

            for(int i=0;i<list.Count;i++)
            {
                if(list[i].code==boppCode)
                {
                    equivalent = true;
                }
            }

            return equivalent;
        }

        public static List<clsBopp> getListByFilter(List<clsFilter> lstFilter)
        {
            List<clsBopp> lstBopp = new List<clsBopp>();
            DataSet DS = new DataSet();
            string where = "";

            if (clsFilter.getSql(lstFilter) != "")
                where = " WHERE " + clsFilter.getSql(lstFilter);

            DS = clsConnection.getDataSetResult("SELECT * FROM vwboppfilm" + where);

            lstBopp.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstBopp.Add(new clsBopp());
                lstBopp[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_codsec"]);
                lstBopp[i].fkFamily = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkFamily"]);
                lstBopp[i].Family = new clsFamily(Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkFamily"]));
                lstBopp[i].familyName = DS.Tables[0].Rows[i]["bopp_FamilyName"].ToString();
                lstBopp[i].fkSubFamily = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkSubFamily"]);
                lstBopp[i].SubFamily = new clsFamily(Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkSubFamily"]));
                lstBopp[i].subFamilyName = DS.Tables[0].Rows[i]["bopp_SubFamilyName"].ToString();
                lstBopp[i].fkInnerSeal = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkInnerSeal"]);
                lstBopp[i].InnerSeal = new clsSeal(Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkInnerSeal"]));
                lstBopp[i].innerSealName = DS.Tables[0].Rows[i]["bopp_innerSealName"].ToString();
                lstBopp[i].fkOuterSeal = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkOuterSeal"]);
                lstBopp[i].OuterSeal = new clsSeal(Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkOuterSeal"]));
                lstBopp[i].outerSealName = DS.Tables[0].Rows[i]["bopp_outerSealName"].ToString();
                lstBopp[i].fkCentralAdditivation = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkCentralAdditivation"]);
                lstBopp[i].CentralAdditivation = new clsAdditivation(Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkCentralAdditivation"]));
                lstBopp[i].centralAdditivationName = DS.Tables[0].Rows[i]["bopp_centralAdditivationName"].ToString();
                lstBopp[i].fkSurfaceAdditivation = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkSurfaceAdditivation"]);
                lstBopp[i].SurfaceAdditivation = new clsAdditivation(Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkSurfaceAdditivation"]));
                lstBopp[i].surfaceAdditivationName = DS.Tables[0].Rows[i]["bopp_surfaceAdditivationName"].ToString();
                lstBopp[i].fkThickness = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkThickness"]);
                lstBopp[i].Thickness = new clsThickness(Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkThickness"]));
                lstBopp[i].thicknessValue = DS.Tables[0].Rows[i]["bopp_thicknessValue"].ToString();
                lstBopp[i].fkTreatment = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkTreatment"]);
                lstBopp[i].Treatment = new clsTreatment(Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkTreatment"]));
                lstBopp[i].treatmentName = DS.Tables[0].Rows[i]["bopp_treatmentName"].ToString();
                lstBopp[i].name = DS.Tables[0].Rows[i]["bopp_name"].ToString();
                lstBopp[i].code = DS.Tables[0].Rows[i]["bopp_code"].ToString();
                lstBopp[i].isBaseFilm = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["bopp_isBaseFilm"], DS.Tables[0].Rows[i]["bopp_isBaseFilm"].GetType().FullName);
                lstBopp[i].fkBaseFilm = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkBaseFilm"]);
                lstBopp[i].baseFilmCode = DS.Tables[0].Rows[i]["bopp_baseFilmCode"].ToString();
                lstBopp[i].baseFilmName = DS.Tables[0].Rows[i]["bopp_baseFilmName"].ToString();
                lstBopp[i].externalID = DS.Tables[0].Rows[i]["bopp_externalID"].ToString();
                lstBopp[i].externalDescription = DS.Tables[0].Rows[i]["bopp_externalDescription"].ToString();
                lstBopp[i].externalCode = DS.Tables[0].Rows[i]["bopp_externalCode"].ToString();
                lstBopp[i].density = Convert.ToDouble(DS.Tables[0].Rows[i]["bopp_density"].ToString());
                lstBopp[i].leadTime = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_leadTime"]);
            }

            return lstBopp;
        }

        public static bool ExistFilm(string code)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT bopp_codsec FROM bps_prod_bopp WHERE bopp_code ='" + code + "'");
            if (DS.Tables[0].Rows.Count > 0)
                return false;
            else
                return true;
        }

        public static int getFilmByCode(string code)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT bopp_codsec FROM bps_prod_bopp WHERE bopp_code ='" + code + "'");
            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(DS.Tables[0].Rows[0]["bopp_codsec"]);
            else
                return 0;
        }

        public static List<clsBopp> getListBaseFilm(int e)
        {
            List<clsBopp> lstBopp = new List<clsBopp>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spNewMetalizedOrder");

            lstBopp.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                if (Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_metalcodsec"]) > 0)
                {
                    lstBopp.Add(new clsBopp());
                    int pos = lstBopp.Count - 1;
                    lstBopp[pos].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_codsec"]);
                    lstBopp[pos].fkFamily = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkFamily"]);
                    lstBopp[pos].familyName = DS.Tables[0].Rows[i]["fml_name"].ToString();
                    lstBopp[pos].fkThickness = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkThickness"]);
                    lstBopp[pos].thicknessValue = DS.Tables[0].Rows[i]["thick_value"].ToString();
                    lstBopp[pos].name = DS.Tables[0].Rows[i]["bopp_name"].ToString();
                    lstBopp[pos].code = DS.Tables[0].Rows[i]["bopp_code"].ToString();
                    //lstBopp[pos].ismaquile = (Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_ismaquile"]) == 1) ? true : false;
                    /*lstBopp[pos].weigth = Convert.ToDouble(DS.Tables[0].Rows[i]["bopp_totalweigth"]);
                    lstBopp[pos].width = DS.Tables[0].Rows[i]["bopp_totalwidth"].ToString();
                    lstBopp[pos].maqweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["bopp_maqtotalweigth"]);
                    lstBopp[pos].maqwidth = DS.Tables[0].Rows[i]["bopp_maqtotalwidth"].ToString();*/
                    lstBopp[pos].metalcodsec = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_metalcodsec"]);
                    lstBopp[pos].metalName = DS.Tables[0].Rows[i]["bopp_metalProduct"].ToString();
                }
            }

            return lstBopp;
        }

        public static List<clsBopp> getListBaseFilm()
        {
            List<clsBopp> lstBopp = new List<clsBopp>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spMetalizedOrderMultiple 'PreviusList','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "', 0");

            lstBopp.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                if (Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_metalcodsec"]) > 0)
                {
                    lstBopp.Add(new clsBopp());
                    int pos = lstBopp.Count - 1;
                    lstBopp[pos].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_codsec"]);
                    lstBopp[pos].fkFamily = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkFamily"]);
                    lstBopp[pos].familyName = DS.Tables[0].Rows[i]["fml_name"].ToString();
                    lstBopp[pos].fkThickness = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_fkThickness"]);
                    lstBopp[pos].thicknessValue = DS.Tables[0].Rows[i]["thick_value"].ToString();
                    lstBopp[pos].name = DS.Tables[0].Rows[i]["bopp_name"].ToString();
                    lstBopp[pos].code = DS.Tables[0].Rows[i]["bopp_code"].ToString();
                    lstBopp[pos].ismaquile = (Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_ismaquile"]) == 1) ? true : false;
                    lstBopp[pos].weigth = Convert.ToDouble(DS.Tables[0].Rows[i]["bopp_totalweigth"]);
                    lstBopp[pos].width = DS.Tables[0].Rows[i]["bopp_totalwidth"].ToString();
                    lstBopp[pos].maqweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["bopp_maqtotalweigth"]);
                    lstBopp[pos].maqwidth = DS.Tables[0].Rows[i]["bopp_maqtotalwidth"].ToString();
                    lstBopp[pos].metalcodsec = Convert.ToInt32(DS.Tables[0].Rows[i]["bopp_metalcodsec"]);
                    lstBopp[pos].metalName = DS.Tables[0].Rows[i]["bopp_metalProduct"].ToString();
                }
            }

            return lstBopp;
        }

        public override string ToString()
        {
            return "[" + this.code.Replace("-", "") + "] " + this.name;
        }

        public static double getThickByCodsec(int fkBopp)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT bps_prod_thickness.thick_value FROM bps_prod_bopp LEFT OUTER JOIN bps_prod_thickness ON (bps_prod_bopp.bopp_fkThickness = bps_prod_thickness.thick_codsec) WHERE bps_prod_bopp.bopp_codsec = " + fkBopp.ToString());
            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToDouble(DS.Tables[0].Rows[0]["thick_value"]);
            else
                return 0;
        }
    }
}

