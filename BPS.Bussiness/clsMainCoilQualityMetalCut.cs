using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra la Calidad de las Rollos Madres Metalizados
    /// </summary>
    public class clsMainCoilQualityMetalCut       
    {
        //Atributes
        private int mcqmc_codsec;
        private int mcqmc_fkCoil;
        private int mcqmc_fkMainCoil;
        private string mcqmc_densityOpticValues;
        private List<double> mcqmc_densityOpticList;
        private double mcqmc_densityOpticAverage;
        private double mcqmc_densityOpticDesviation;
        private string mcqmc_tape;
        private string mcqmc_surfaceTensionValues;
        private List<double> mcqmc_surfaceTensionList;
        private DateTime mcqmc_createdDate;
        private int mcqmc_createdBy;
        private DateTime mcqmc_ModifiedDate;
        private int mcqmc_modifiedBy;
        private string mcqmc_creatorUser;
        private string mcqmc_modificatorUser;
        private List<clsMainCoilQualityMetal> mcqmc_lstMainCoilQualityMetal;
        private string mcqmc_notes;
        private string mcqmc_labRating;
        private string mcqmc_analistRating;

        //private bool mcqmc_opacityEvaluated;
        //private bool mcqmc_transmittanceEvaluated;
        //private string mcqmc_opacityTransmittanceValues;
        //private List<double> mcqmc_opacityTransmittanceList;
        ////private List<double> mcqmc_surfaceTensionList;
        //private string mcqmc_backSideValues;
        //private List<bool> mcqmc_bakSideList;
        //private double mcqmc_SealTemperatureTF;
        //private string mcqmc_sealTemperatureTFValues;
        //private List<bool> mcqmc_sealTemperatureTFList;
        //private double mcqmc_sealTemperatureNTF;
        //private string mcqmc_sealTemperatureNTFValues;
        //private List<bool> mcqmc_sealTemperatureNTFList;
        //private string mcqmc_appearance;
        //private string mcqmc_appearanceValues;
        //private List<string> mcqmc_appearanceList;
        //private string mcqmc_operatorCriterial;
        //private string mcqmc_fisicStatus;
        //private string mcqmc_frictionCoefficientTFValues;
        //private List<double> mcqmc_frictionCoefficientTFList;
        //private double mcqmc_frictionCoefficientTFAverage;
        //private double mcqmc_frictionCoefficientTFDinamicAverage;
        //private string mcqmc_frictionCoefficientNTFValues;
        //private List<double> mcqmc_frictionCoefficientNTFList;
        //private double mcqmc_frictionCoefficientNTFAverage;
        //private double mcqmc_frictionCoefficientNTFDinamicAverage;
        //private string mcqmc_GlossValues;
        //private List<double> mcqmc_GlossList;
        //private double mcqmc_GlossAverage;
        //private double mcqmc_GlossDesviation;
        //private string mcqmc_sealStrengthValues;
        //private List<double> mcqmc_sealStrengthList;
        //private string mcqmc_sealStrengthValuesTF;
        //private List<double> mcqmc_sealStrengthListTF;
        //private List<double> mcqmc_sealStrengthListNTF;
        //private string mcqmc_AnalistRating;
        //private string mcqmc_labRating;
        //private DateTime mcqmc_receptionDate;
        //private int mcqmc_opacityEvaluatedInt;
        //private int mcqmc_transmittanceEvaluatedInt;
        //private string mcqmc_treatmentValues;
        //private string mcqmc_sealStrengthValuesNTF;
        //private string mcqmc_statictTF;
        //private string mcqmc_staticNTF;
        //private double mcqmc_tearMDAverage;
        //private List<double> mcqmc_tearMDAList;
        //private List<double> mcqmc_tearTDAList;
        //private List<double> mcqmc_dartImpactTFList;
        //private List<double> mcqmc_dartImpactNTFList;
        //private string mcqmc_tearMDValues;
        //private double mcqmc_tearTDAverage;
        //private string mcqmc_tearTDValues;
        //private double mcqmc_dartImpactTFAverage;
        //private string mcqmc_dartImpactTFValues;
        //private double mcqmc_dartImpactNTFAverage;
        //private string mcqmc_dartImpactNTFValues;
        //private string mcqmc_metalFilmValues;
        //private List<double> mcqmc_metalFilmValuesList;
        //private double mcqmc_metalFilmAverage;
        //private double mcqmc_metalFilmAverageII;
        //private string mcqmc_GlossIIValues;
        //private List<double> mcqmc_GlossIIList;
        //private double mcqmc_GlossIIAverage;
        //private double mcqmc_GlossIIDesviation;
        //private double mcqmc_sealStrengthValuesDMTFNewton;
        //private double mcqmc_sealStrengthValuesDTNTFNewton;
        //private double mcqmc_sealStrengthValuesDMTFNewton2;
        //private double mcqmc_sealStrengthValuesDTNTFNewton2;

        //Properties
        public int codsec { get { return mcqmc_codsec; } set { mcqmc_codsec = value; } }

        public int fkcoil { get { return mcqmc_fkCoil; } set { mcqmc_fkCoil = value; } }

        public int fkmaincoil { get { return mcqmc_fkMainCoil; } set { mcqmc_fkMainCoil = value; } }

        public string densityOpticValues { get { return mcqmc_densityOpticValues; } set { mcqmc_densityOpticValues = value; } }

        public List<double> densityOpticList { get { return mcqmc_densityOpticList; } set { mcqmc_densityOpticList = value; } }

        public double densityOpticAverage { get { return mcqmc_densityOpticAverage; } set { mcqmc_densityOpticAverage = value; } }

        public double densityOpticDesviation { get { return mcqmc_densityOpticDesviation; } set { mcqmc_densityOpticDesviation = value; } }

        public string tape { get { return mcqmc_tape; } set { mcqmc_tape = value; } }

        public string surfaceTensionValues { get { return mcqmc_surfaceTensionValues; } set { mcqmc_surfaceTensionValues = value; } }

        public List<double> surfaceTensionList { get { return mcqmc_surfaceTensionList; } set { mcqmc_surfaceTensionList = value; } }

        public DateTime createdDate { get { return mcqmc_createdDate; } set { mcqmc_createdDate = value; } }

        public int createdBy { get { return mcqmc_createdBy; } set { mcqmc_createdBy = value; } }

        public DateTime ModifiedDate { get { return mcqmc_ModifiedDate; } set { mcqmc_ModifiedDate = value; } }

        public int modifiedBy { get { return mcqmc_modifiedBy; } set { mcqmc_modifiedBy = value; } }

        public string creatorUser { get { return mcqmc_creatorUser; } set { mcqmc_creatorUser = value; } }

        public string modificatorUser { get { return mcqmc_modificatorUser; } set { mcqmc_modificatorUser = value; } }

        public string notes { get { return mcqmc_notes; } set { mcqmc_notes = value; } }

        public List<clsMainCoilQualityMetal> lstMainCoilQualityMetal { get { return mcqmc_lstMainCoilQualityMetal; } set { mcqmc_lstMainCoilQualityMetal = value; } }

        public string labRating { get { return mcqmc_labRating; } set { mcqmc_labRating = value; } }

        public string analistRating { get { return mcqmc_analistRating; } set { mcqmc_analistRating = value; } }


        //public bool opacityEvaluated { get { return mcqmc_opacityEvaluated; } set { mcqmc_opacityEvaluated = value; } }

        //public bool transmittanceEvaluated { get { return mcqmc_transmittanceEvaluated; } set { mcqmc_transmittanceEvaluated = value; } }

        //public string opacityTransmittanceValues { get { return mcqmc_opacityTransmittanceValues; } set { mcqmc_opacityTransmittanceValues = value; } }

        //public List<double> opacityTransmittanceList { get { return mcqmc_opacityTransmittanceList; } set { mcqmc_opacityTransmittanceList = value; } }

        ////public List<double> surfaceTensionList { get { return mcqmc_surfaceTensionList; } set { mcqmc_surfaceTensionList = value; } }

        //public string backSideValues { get { return mcqmc_backSideValues; } set { mcqmc_backSideValues = value; } }

        //public List<bool> bakSideList { get { return mcqmc_bakSideList; } set { mcqmc_bakSideList = value; } }

        //public double SealTemperatureTF { get { return mcqmc_SealTemperatureTF; } set { mcqmc_SealTemperatureTF = value; } }

        //public string sealTemperatureTFValues { get { return mcqmc_sealTemperatureTFValues; } set { mcqmc_sealTemperatureTFValues = value; } }

        //public List<bool> sealTemperatureTFList { get { return mcqmc_sealTemperatureTFList; } set { mcqmc_sealTemperatureTFList = value; } }

        //public double sealTemperatureNTF { get { return mcqmc_sealTemperatureNTF; } set { mcqmc_sealTemperatureNTF = value; } }

        //public string sealTemperatureNTFValues { get { return mcqmc_sealTemperatureNTFValues; } set { mcqmc_sealTemperatureNTFValues = value; } }

        //public List<bool> sealTemperatureNTFList { get { return mcqmc_sealTemperatureNTFList; } set { mcqmc_sealTemperatureNTFList = value; } }

        //public string appearance { get { return mcqmc_appearance; } set { mcqmc_appearance = value; } }

        //public string appearanceValues { get { return mcqmc_appearanceValues; } set { mcqmc_appearanceValues = value; } }

        //public List<string> appearanceList { get { return mcqmc_appearanceList; } set { mcqmc_appearanceList = value; } }

        //public string operatorCriterial { get { return mcqmc_operatorCriterial; } set { mcqmc_operatorCriterial = value; } }

        //public string fisicStatus { get { return mcqmc_fisicStatus; } set { mcqmc_fisicStatus = value; } }

        //public string frictionCoefficientTFValues { get { return mcqmc_frictionCoefficientTFValues; } set { mcqmc_frictionCoefficientTFValues = value; } }

        //public List<double> frictionCoefficientTFList { get { return mcqmc_frictionCoefficientTFList; } set { mcqmc_frictionCoefficientTFList = value; } }

        //public double frictionCoefficientTFAverage { get { return mcqmc_frictionCoefficientTFAverage; } set { mcqmc_frictionCoefficientTFAverage = value; } }

        //public double frictionCoefficientTFDinamicAverage { get { return mcqmc_frictionCoefficientTFDinamicAverage; } set { mcqmc_frictionCoefficientTFDinamicAverage = value; } }

        //public string frictionCoefficientNTFValues { get { return mcqmc_frictionCoefficientNTFValues; } set { mcqmc_frictionCoefficientNTFValues = value; } }

        //public List<double> frictionCoefficientNTFList { get { return mcqmc_frictionCoefficientNTFList; } set { mcqmc_frictionCoefficientNTFList = value; } }

        //public double frictionCoefficientNTFAverage { get { return mcqmc_frictionCoefficientNTFAverage; } set { mcqmc_frictionCoefficientNTFAverage = value; } }

        //public double frictionCoefficientNTFDinamicAverage { get { return mcqmc_frictionCoefficientNTFDinamicAverage; } set { mcqmc_frictionCoefficientNTFDinamicAverage = value; } }

        //public string GlossValues { get { return mcqmc_GlossValues; } set { mcqmc_GlossValues = value; } }

        //public List<double> GlossList { get { return mcqmc_GlossList; } set { mcqmc_GlossList = value; } }

        //public double GlossAverage { get { return mcqmc_GlossAverage; } set { mcqmc_GlossAverage = value; } }

        //public double GlossDesviation { get { return mcqmc_GlossDesviation; } set { mcqmc_GlossDesviation = value; } }

        //public string sealStrengthValuesTF { get { return mcqmc_sealStrengthValuesTF; } set { mcqmc_sealStrengthValuesTF = value; } }

        //public string sealStrengthValues { get { return mcqmc_sealStrengthValues; } set { mcqmc_sealStrengthValues = value; } }
        //public List<double> sealStrengthList { get { return mcqmc_sealStrengthList; } set { mcqmc_sealStrengthList = value; } }

        //public List<double> sealStrengthListTF { get { return mcqmc_sealStrengthListTF; } set { mcqmc_sealStrengthListTF = value; } }
        //public List<double> sealStrengthListNTF { get { return mcqmc_sealStrengthListNTF; } set { mcqmc_sealStrengthListNTF = value; } }

        //public string AnalistRating { get { return mcqmc_AnalistRating; } set { mcqmc_AnalistRating = value; } }

        //public string labRating { get { return mcqmc_labRating; } set { mcqmc_labRating = value; } }

        //public DateTime receptionDate { get { return mcqmc_receptionDate; } set { mcqmc_receptionDate = value; } }

        //public int opacityEvaluatedInt { get { return mcqmc_opacityEvaluatedInt; } set { mcqmc_opacityEvaluatedInt = value; } }

        //public int transmittanceEvaluatedInt { get { return mcqmc_transmittanceEvaluatedInt; } set { mcqmc_transmittanceEvaluatedInt = value; } }

        //public string sealStrengthValuesNTF { get { return mcqmc_sealStrengthValuesNTF; } set { mcqmc_sealStrengthValuesNTF = value; } }

        //public string treatmentValues { get { return mcqmc_treatmentValues; } set { mcqmc_treatmentValues = value; } }

        //public string statictTF { get { return mcqmc_statictTF; } set { mcqmc_statictTF = value; } }

        //public string staticNTF { get { return mcqmc_staticNTF; } set { mcqmc_staticNTF = value; } }

        //public double tearMDAverage { get { return mcqmc_tearMDAverage; } set { mcqmc_tearMDAverage = value; } }

        //public string tearMDValues { get { return mcqmc_tearMDValues; } set { mcqmc_tearMDValues = value; } }

        //public double tearTDAverage { get { return mcqmc_tearTDAverage; } set { mcqmc_tearTDAverage = value; } }

        //public string tearTDValues { get { return mcqmc_tearTDValues; } set { mcqmc_tearTDValues = value; } }

        //public List<double> tearMDAList { get { return mcqmc_tearMDAList; } set { mcqmc_tearMDAList = value; } }

        //public List<double> tearTDAList { get { return mcqmc_tearTDAList; } set { mcqmc_tearTDAList = value; } }

        //public List<double> dartImpactTFList { get { return mcqmc_dartImpactTFList; } set { mcqmc_dartImpactTFList = value; } }

        //public List<double> dartImpactNTFList { get { return mcqmc_dartImpactNTFList; } set { mcqmc_dartImpactNTFList = value; } }

        //public double dartImpactTFAverage { get { return mcqmc_dartImpactTFAverage; } set { mcqmc_dartImpactTFAverage = value; } }

        //public string dartImpactTFValues { get { return mcqmc_dartImpactTFValues; } set { mcqmc_dartImpactTFValues = value; } }

        //public double dartImpactNTFAverage { get { return mcqmc_dartImpactNTFAverage; } set { mcqmc_dartImpactNTFAverage = value; } }

        //public string dartImpactNTFValues { get { return mcqmc_dartImpactNTFValues; } set { mcqmc_dartImpactNTFValues = value; } }

        //public string metalFilmValues { get { return mcqmc_metalFilmValues; } set { mcqmc_metalFilmValues = value; } }

        //public List<double> metalfilmValuesList { get { return mcqmc_metalFilmValuesList; } set { mcqmc_metalFilmValuesList = value; } }

        //public double metalfilmAverage { get { return mcqmc_metalFilmAverage; } set { mcqmc_metalFilmAverage = value; } }

        //public double metalfilmAverageII { get { return mcqmc_metalFilmAverageII; } set { mcqmc_metalFilmAverageII = value; } }

        //public string GlossIIValues { get { return mcqmc_GlossIIValues; } set { mcqmc_GlossIIValues = value; } }

        //public List<double> GlossIIList { get { return mcqmc_GlossIIList; } set { mcqmc_GlossIIList = value; } }

        //public double GlossIIAverage { get { return mcqmc_GlossIIAverage; } set { mcqmc_GlossIIAverage = value; } }

        //public double GlossIIDesviation { get { return mcqmc_GlossIIDesviation; } set { mcqmc_GlossIIDesviation = value; } }

        //public double sealStrengthValuesDMTFNewton { get { return mcqmc_sealStrengthValuesDMTFNewton; } set { mcqmc_sealStrengthValuesDMTFNewton = value; } }

        //public double sealStrengthValuesDTNTFNewton { get { return mcqmc_sealStrengthValuesDTNTFNewton; } set { mcqmc_sealStrengthValuesDTNTFNewton = value; } }

        //public double sealStrengthValuesDMTFNewtonII { get { return mcqmc_sealStrengthValuesDMTFNewton2; } set { mcqmc_sealStrengthValuesDMTFNewton2 = value; } }

        //public double sealStrengthValuesDTNTFNewtonII { get { return mcqmc_sealStrengthValuesDTNTFNewton2; } set { mcqmc_sealStrengthValuesDTNTFNewton2 = value; } }


        //Constructor

        public clsMainCoilQualityMetalCut()
        {
            mcqmc_codsec = 0;
            mcqmc_fkCoil = 0;
            mcqmc_fkMainCoil = 0;
            mcqmc_densityOpticValues = "0;0;0;0;0;0;0;0;0;0;0;0;0;0";
            mcqmc_densityOpticList = new List<double>();
            mcqmc_densityOpticAverage = 0;
            mcqmc_densityOpticDesviation = 0;
            mcqmc_tape = "";
            mcqmc_surfaceTensionValues = "0;0;0;0;0;0";
            mcqmc_createdDate = DateTime.Now;
            mcqmc_createdBy = 88;
            mcqmc_ModifiedDate = DateTime.Now;
            mcqmc_modifiedBy = 88;
            mcqmc_creatorUser = "";
            mcqmc_modificatorUser = "";
            mcqmc_notes = "";
            mcqmc_lstMainCoilQualityMetal = new List<clsMainCoilQualityMetal>();
            mcqmc_labRating = "";
            mcqmc_analistRating = "";
            
            //mcqmc_opacityEvaluated = false;
            //mcqmc_transmittanceEvaluated = false;
            //mcqmc_opacityTransmittanceValues = "";
            //mcqmc_opacityTransmittanceList = new List<double>();
            //mcqmc_surfaceTensionList = new List<double>();
            //mcqmc_backSideValues = "";
            //mcqmc_bakSideList = new List<bool>();
            //mcqmc_SealTemperatureTF = 0;
            //mcqmc_sealTemperatureTFValues = "";
            //mcqmc_sealTemperatureTFList = new List<bool>();
            //mcqmc_sealTemperatureNTF = 0;
            //mcqmc_sealTemperatureNTFValues = "";
            //mcqmc_sealTemperatureNTFList = new List<bool>();
            //mcqmc_appearance = "";
            //mcqmc_appearanceValues = "";
            //mcqmc_appearanceList = new List<string>();
            //mcqmc_operatorCriterial = "";
            //mcqmc_fisicStatus = "";
            //mcqmc_frictionCoefficientTFValues = "";
            //mcqmc_frictionCoefficientTFList = new List<double>();
            //mcqmc_frictionCoefficientTFAverage = 0;
            //mcqmc_frictionCoefficientTFDinamicAverage = 0;
            //mcqmc_frictionCoefficientNTFValues = "";
            //mcqmc_frictionCoefficientNTFList = new List<double>();
            //mcqmc_frictionCoefficientNTFAverage = 0;
            //mcqmc_frictionCoefficientNTFDinamicAverage = 0;
            //mcqmc_GlossValues = "";
            //mcqmc_GlossList = new List<double>();
            //mcqmc_GlossAverage = 0;
            //mcqmc_GlossDesviation = 0;
            //mcqmc_sealStrengthValues = "";
            //mcqmc_sealStrengthList = new List<double>();
            //mcqmc_sealStrengthValuesTF = "";
            //mcqmc_sealStrengthListTF = new List<double>();
            //mcqmc_sealStrengthValuesNTF = "";
            //mcqmc_sealStrengthListNTF = new List<double>();
            //mcqmc_AnalistRating = "";
            //mcqmc_labRating = "";
            //mcqmc_receptionDate = DateTime.Now;
            //mcqmc_opacityEvaluatedInt = 0;
            //mcqmc_transmittanceEvaluatedInt = 0;
            //mcqmc_tearMDAList = new List<double>();
            //mcqmc_tearTDAList = new List<double>();
            //mcqmc_dartImpactTFList = new List<double>();
            //mcqmc_dartImpactNTFList = new List<double>();
            //mcqmc_statictTF = "";
            //mcqmc_staticNTF = "";
            //mcqmc_tearMDAverage = 0;
            //mcqmc_tearMDValues = "";
            //mcqmc_tearTDAverage = 0;
            //mcqmc_tearTDValues = "";
            //mcqmc_dartImpactTFAverage = 0;
            //mcqmc_dartImpactTFValues = "";
            //mcqmc_dartImpactNTFAverage = 0;
            //mcqmc_dartImpactNTFValues = "";
            //mcqmc_sealStrengthValuesNTF = "";
            //mcqmc_metalFilmValues = string.Empty;
            //mcqmc_metalFilmValuesList = new List<double>();
            //mcqmc_metalFilmAverage = 0;
            //mcqmc_metalFilmAverageII = 0;
            //mcqmc_GlossIIValues = string.Empty;
            //mcqmc_GlossIIList = new List<double>();
            //mcqmc_GlossIIAverage = 0;
            //mcqmc_GlossIIDesviation = 0;
            //mcqmc_sealStrengthValuesDMTFNewton = 0;
            //mcqmc_sealStrengthValuesDTNTFNewton = 0;
            //mcqmc_sealStrengthValuesDMTFNewton2 = 0;
            //mcqmc_sealStrengthValuesDTNTFNewton2 = 0;
        }
        public clsMainCoilQualityMetalCut(int codsec)
        {
            this.load(codsec);
        }

        //Methods
        public void load(int codsec)
        {
            //DataSet DS = new DataSet();
            //DS = clsConnection.getDataSetResult("SELECT * FROM vwmaincoilquality where mcqmc_codsec =  " + codsec.ToString());

            //if (DS.Tables[0].Rows.Count > 0)
            //{
            //    this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mcqmc_codsec"]);
            //    this.densityOpticValues = DS.Tables[0].Rows[0]["mcqmc_thikness"].ToString();
            //    this.densityOpticList = clsGlobal.getDoubleListFromString(this.densityOpticValues);
            //    this.densityOpticAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqmc_thiknessAverage"]);
            //    this.densityOpticDesviation = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqmc_thiknessDesviation"]);
            //    this.gramaje = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqmc_gramaje"]);
            //    this.opacityEvaluated = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["mcqmc_opacityEvaluated"], DS.Tables[0].Rows[0]["mcqmc_opacityEvaluated"].GetType().FullName);
            //    this.transmittanceEvaluated = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["mcqmc_transmittanceEvaluated"], DS.Tables[0].Rows[0]["mcqmc_transmittanceEvaluated"].GetType().FullName);
            //    this.opacityTransmittanceValues = DS.Tables[0].Rows[0]["mcqmc_opacityTransmittanceValues"].ToString();
            //    this.opacityTransmittanceList = clsGlobal.getDoubleListFromString(this.opacityTransmittanceValues);
            //    this.surfaceTensionValues = DS.Tables[0].Rows[0]["mcqmc_surfaceTensionValues"].ToString();
            //    this.surfaceTensionList = clsGlobal.getDoubleListFromString(this.surfaceTensionValues);
            //    this.backSideValues = DS.Tables[0].Rows[0]["mcqmc_backSideValues"].ToString();
            //    this.bakSideList = clsGlobal.getBooleanListFromString(this.backSideValues);
            //    this.SealTemperatureTF = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqmc_SealTemperatureTF"]);
            //    this.sealTemperatureTFValues = DS.Tables[0].Rows[0]["mcqmc_sealTemperatureTFValues"].ToString();
            //    this.sealTemperatureTFList = clsGlobal.getBooleanListFromString(this.sealTemperatureTFValues);
            //    this.sealTemperatureNTF = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqmc_sealTemperatureNTF"]);
            //    this.sealTemperatureNTFValues = DS.Tables[0].Rows[0]["mcqmc_sealTemperatureNTFValues"].ToString();
            //    this.sealTemperatureNTFList = clsGlobal.getBooleanListFromString(this.sealTemperatureNTFValues);
            //    this.appearance = DS.Tables[0].Rows[0]["mcqmc_appearance"].ToString();
            //    this.appearanceValues = DS.Tables[0].Rows[0]["mcqmc_appearanceValues"].ToString();
            //    this.appearanceList = clsGlobal.getStringListFromString(this.appearanceValues);
            //    this.operatorCriterial = DS.Tables[0].Rows[0]["mcqmc_operatorCriterial"].ToString();
            //    this.fisicStatus = DS.Tables[0].Rows[0]["mcqmc_fisicStatus"].ToString();
            //    this.frictionCoefficientTFValues = DS.Tables[0].Rows[0]["mcqmc_firctionCoefficientTFValues"].ToString();
            //    this.frictionCoefficientTFList = clsGlobal.getDoubleListFromString(this.frictionCoefficientTFValues);
            //    this.frictionCoefficientTFAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqmc_frictionCoefficientTFAverage"]);
            //    this.frictionCoefficientTFDinamicAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqmc_frictionCoefficientTFDinamicAverage"]);
            //    this.frictionCoefficientNTFValues = DS.Tables[0].Rows[0]["mcqmc_frictionCoeficientNTFValues"].ToString();
            //    this.frictionCoefficientNTFList = clsGlobal.getDoubleListFromString(this.frictionCoefficientNTFValues);
            //    this.frictionCoefficientNTFAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqmc_frictionCoefficientNTFAverage"]);
            //    this.frictionCoefficientNTFDinamicAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqmc_frictionCoefficientNTFDinamicAverage"]);
            //    this.GlossValues = DS.Tables[0].Rows[0]["mcqmc_GlossValues"].ToString();
            //    this.GlossList = clsGlobal.getDoubleListFromString(this.GlossValues);
            //    this.GlossAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqmc_GlossAverage"]);
            //    this.GlossDesviation = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqmc_GlossDesviation"]);
            //    this.sealStrengthValues = DS.Tables[0].Rows[0]["mcqmc_sealStrengthValues"].ToString();
            //    this.sealStrengthValuesTF = DS.Tables[0].Rows[0]["mcqmc_sealStrengthValuesTF"].ToString();
            //    this.sealStrengthList = clsGlobal.getDoubleListFromString(this.sealStrengthValues);
            //    this.sealStrengthListTF = clsGlobal.getDoubleListFromString(this.sealStrengthValuesTF);
            //    this.sealStrengthListNTF = clsGlobal.getDoubleListFromString(this.sealStrengthValuesNTF);
            //    this.AnalistRating = DS.Tables[0].Rows[0]["mcqmc_"].ToString();
            //    this.labRating = DS.Tables[0].Rows[0]["mcqmc_"].ToString();
            //    this.receptionDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mcqmc_receptionDate"]);
            //    this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mcqmc_createdDate"]);
            //    this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mcqmc_createdBy"]);
            //    this.ModifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mcqmc_ModifiedDate"]);
            //    this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mcqmc_modifiedBy"]);
            //    this.creatorUser = DS.Tables[0].Rows[0]["mcqmc_creatorUser"].ToString();
            //    this.modificatorUser = DS.Tables[0].Rows[0]["mcqmc_modificatorUser"].ToString();
            //    this.lstMainCoilMetal = clsMainCoil.getBoppMainCoilListByQualityReport(this.codsec);

            //    this.statictTF = DS.Tables[0].Rows[0]["mcqmc_statictTF"].ToString();
            //    this.staticNTF = DS.Tables[0].Rows[0]["mcqmc_statictNTF"].ToString();
            //    this.tearMDAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqmc_tearMDAverage"]);
            //    this.tearMDValues = DS.Tables[0].Rows[0]["mcqmc_tearMDValues"].ToString();
            //    this.tearMDAList = clsGlobal.getDoubleListFromString(this.tearMDValues);
            //    this.tearTDAList = clsGlobal.getDoubleListFromString(this.dartImpactTFValues);
            //    this.dartImpactTFList = clsGlobal.getDoubleListFromString(this.tearTDValues);

            //    this.tearTDAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqmc_tearTDAverage"]);
            //    this.tearTDValues = DS.Tables[0].Rows[0]["mcqmc_tearTDValues"].ToString();
            //    this.dartImpactTFAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqmc_dartImpactTFAverage"]);
            //    this.dartImpactTFValues = DS.Tables[0].Rows[0]["mcqmc_dartImpactTFValues"].ToString();
            //    this.dartImpactNTFAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqmc_dartImpactNTFAverage"]);
            //    this.dartImpactNTFValues = DS.Tables[0].Rows[0]["mcqmc_dartImpactNTFValues"].ToString();
            //    this.sealStrengthValuesNTF = DS.Tables[0].Rows[0]["mcqmc_sealStrengthValuesNTF"].ToString();

            //}
        }

        public bool save()
        {
            string queryString = "";
            try
            {
                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_maincoilqualitymetalcut (mcqmc_fkCoil, mcqmc_fkMainCoil, mcqmc_densityOpticValues, mcqmc_densityOpticAverage, mcqmc_densityOpticDesviation,mcqmc_tape, mcqmc_surfaceTensionValues, mcqmc_createdDate, mcqmc_createdBy, mcqmc_ModifiedDate, mcqmc_modifiedBy, mcqmc_notes, mcqmc_receptionDate, mcqmc_labRating, mcqmc_analistRating)";
                    //"mcqmc_transmittanceEvaluated, mcqmc_opacityTrasmittanceValues, mcqmc_surfaceTensionValues, mcqmc_backSideValues, mcqmc_SealTemperatureTF, mcqmc_sealTemperatureTFValues, " +
                    //"mcqmc_sealTemperatureNTF, mcqmc_sealTemperatureNTFValues, mcqmc_appearance, mcqmc_appearanceValues, mcqmc_operatorCriterial, mcqmc_fisicStatus, mcqmc_firctionCoefficientTFValues, " +
                    //"mcqmc_frictionCoefficientTFAverage, mcqmc_frictionCoeficientNTFValues, mcqmc_frictionCoefficientNTFAverage, mcqmc_GlossValues, mcqmc_GlossAverage, mcqmc_GlossDesviation, " +
                    //"mcqmc_sealStrengthValues,mcqmc_sealStrengthValuesTF,mcqmc_sealStrengthValuesNTF, mcqmc_receptionDate, mcqmc_createdDate, mcqmc_createdBy, mcqmc_ModifiedDate, mcqmc_modifiedBy, " +
                    //"mcqmc_treatmentValues, mcqmc_statictTF, mcqmc_staticNTF, mcqmc_tearMDAverage, mcqmc_tearMDValues, mcqmc_tearTDAverage, mcqmc_tearTDValues, mcqmc_dartImpactTFAverage, " +
                    //"mcqmc_dartImpactTFValues, mcqmc_dartImpactNTFAverage, mcqmc_dartImpactNTFValues, mcqmc_frictionCoefficientTFDinamicAverage, mcqmc_frictionCoefficientNTFDinamicAverage, " +
                    //"mcqmc_metalFilmValues, mcqmc_metalFilmAverage, mcqmc_metalFilmAverage2, mcqmc_GlossIIValues, mcqmc_GlossIIAverage, mcqmc_GlossIIDesviation, mcqmc_sealStrengthValuesDMTFNewton, mcqmc_sealStrengthValuesDTNTFNewton, mcqmc_sealStrengthValuesDMTFNewton2, mcqmc_sealStrengthValuesDTNTFNewton2) ";
                    queryString += " VALUES (";
                    queryString += "" + this.fkcoil.ToString() + ",";
                    queryString += "" + this.fkmaincoil.ToString() + ",";
                    queryString += "'" + this.densityOpticValues.ToString() + "',";
                    queryString += "" + this.densityOpticAverage.ToString() + ",";
                    queryString += "" + this.densityOpticDesviation.ToString() + ",";
                    queryString += "'" + this.tape.ToString() + "',";
                    queryString += "'" + this.surfaceTensionValues.ToString() + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "" + clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "" + clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += "'" + this.notes.ToString() + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + this.labRating.ToString() + "',";
                    queryString += "'" + this.analistRating.ToString() + "')";


                    //queryString += "'" + this.transmittanceEvaluatedInt.ToString() + "',";
                    //queryString += "'" + this.opacityTransmittanceValues.ToString() + "',";
                    //queryString += "'" + this.backSideValues.ToString() + "',";
                    //queryString += "" + this.SealTemperatureTF.ToString() + ",";
                    //queryString += "'" + this.sealTemperatureTFValues.ToString() + "',";
                    //queryString += "" + this.sealTemperatureNTF.ToString() + ",";
                    //queryString += "'" + this.sealTemperatureNTFValues.ToString() + "',";
                    //queryString += "'" + this.appearance.ToString() + "',";
                    //queryString += "'" + this.appearanceValues.ToString() + "',";
                    //queryString += "'" + this.operatorCriterial.ToString() + "',";
                    //queryString += "'" + this.fisicStatus.ToString() + "',";
                    //queryString += "'" + this.frictionCoefficientTFValues.ToString() + "',";
                    //queryString += "" + this.frictionCoefficientTFAverage.ToString() + ",";
                    //queryString += "'" + this.frictionCoefficientNTFValues.ToString() + "',";
                    //queryString += "" + this.frictionCoefficientNTFAverage.ToString() + ",";
                    //queryString += "'" + this.GlossValues.ToString() + "',";
                    //queryString += "" + this.GlossAverage.ToString() + ",";
                    //queryString += "" + this.GlossDesviation.ToString() + ",";
                    //queryString += "'" + this.sealStrengthValues.ToString() + "',";
                    //queryString += "'" + this.sealStrengthValuesTF.ToString() + "',";
                    //queryString += "'" + this.sealStrengthValuesNTF.ToString() + "',";
                    //queryString += "'" + this.receptionDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    //queryString += "'" + this.treatmentValues.ToString() + "',";
                    //queryString += "'" + this.statictTF.ToString() + "',";
                    //queryString += "'" + this.staticNTF.ToString() + "',";
                    //queryString += "" + this.tearMDAverage.ToString() + ",";
                    //queryString += "'" + this.tearMDValues.ToString() + "',";
                    //queryString += "" + this.tearTDAverage.ToString() + ",";
                    //queryString += "'" + this.tearTDValues.ToString() + "',";
                    //queryString += "" + this.dartImpactTFAverage.ToString() + ",";
                    //queryString += "'" + this.dartImpactTFValues.ToString() + "',";
                    //queryString += "" + this.dartImpactNTFAverage.ToString() + ",";
                    //queryString += "'" + this.dartImpactNTFValues.ToString() + "',";
                    //queryString += "" + this.frictionCoefficientTFDinamicAverage.ToString() + ",";
                    //queryString += "" + this.frictionCoefficientNTFDinamicAverage.ToString() + ",";
                    //queryString += "'" + this.metalFilmValues.ToString() + "',";
                    //queryString += "" + this.metalfilmAverage.ToString() + ",";
                    //queryString += "" + this.metalfilmAverageII.ToString() + ",";
                    //queryString += "'" + this.GlossIIValues.ToString() + "',";
                    //queryString += "" + this.GlossIIAverage.ToString() + ",";
                    //queryString += "'" + this.GlossIIDesviation.ToString() + "',";
                    //queryString += "" + this.sealStrengthValuesDMTFNewton.ToString() + ",";
                    //queryString += "" + this.sealStrengthValuesDTNTFNewton.ToString() + ",";
                    //queryString += "" + this.sealStrengthValuesDMTFNewtonII.ToString() + ",";
                    //queryString += "" + this.sealStrengthValuesDTNTFNewtonII.ToString() + ")";

                }
                else
                {
                    queryString += "UPDATE bps_prod_maincoilqualitymetalcut ";
                    queryString += " SET ";
                    queryString += "mcqmc_densityOpticValues ='" + this.densityOpticValues.ToString() + "',";
                    queryString += "mcqmc_densityOpticAverage = " + this.densityOpticAverage.ToString() + ",";
                    queryString += "mcqmc_densityOpticDesviation = " + this.densityOpticDesviation.ToString() + ",";
                    queryString += "mcqmc_tape ='" + this.tape.ToString() + "',";
                    queryString += "mcqmc_surfaceTensionValues = '" + this.surfaceTensionValues.ToString() + "',";
                    queryString += "mcqmc_ModifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "mcqmc_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += "mcqmc_notes ='" + this.notes.ToString() + "', ";
                    queryString += "mcqmc_labRating ='" + this.labRating.ToString() + "', ";
                    queryString += "mcqmc_analistRating ='" + this.analistRating.ToString() + "' ";


                    //queryString += "mcqmc_sealTemperatureNTF = " + this.sealTemperatureNTF.ToString() + ",";
                    //queryString += "mcqmc_sealTemperatureNTFValues ='" + this.sealTemperatureNTFValues.ToString() + "',";
                    //queryString += "mcqmc_appearance ='" + this.appearance.ToString() + "',";
                    //queryString += "mcqmc_appearanceValues ='" + this.appearanceValues.ToString() + "',";
                    //queryString += "mcqmc_operatorCriterial ='" + this.operatorCriterial.ToString() + "',";
                    //queryString += "mcqmc_fisicStatus ='" + this.fisicStatus.ToString() + "',";
                    //queryString += "mcqmc_firctionCoefficientTFValues ='" + this.frictionCoefficientTFValues.ToString() + "',";
                    //queryString += "mcqmc_frictionCoefficientTFAverage = " + this.frictionCoefficientTFAverage.ToString() + ",";
                    //queryString += "mcqmc_frictionCoefficientTFDinamicAverage = " + this.frictionCoefficientTFDinamicAverage.ToString() + ",";
                    //queryString += "mcqmc_frictionCoeficientNTFValues ='" + this.frictionCoefficientNTFValues.ToString() + "',";
                    //queryString += "mcqmc_frictionCoefficientNTFAverage = " + this.frictionCoefficientNTFAverage.ToString() + ",";
                    //queryString += "mcqmc_frictionCoefficientNTFDinamicAverage = " + this.frictionCoefficientNTFDinamicAverage.ToString() + ",";
                    //queryString += "mcqmc_GlossValues ='" + this.GlossValues.ToString() + "',";
                    //queryString += "mcqmc_GlossAverage = " + this.GlossAverage.ToString() + ",";
                    //queryString += "mcqmc_GlossDesviation = " + this.GlossDesviation.ToString() + ",";
                    //queryString += "mcqmc_sealStrengthValues ='" + this.sealStrengthValues.ToString() + "',";
                    //queryString += "mcqmc_sealStrengthValuesTF ='" + this.sealStrengthValuesTF.ToString() + "',";
                    //queryString += "mcqmc_sealStrengthValuesNTF ='" + this.sealStrengthValuesNTF.ToString() + "',";
                    //queryString += "mcqmc_receptionDate ='" + this.receptionDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    //queryString += "mcqmc_createdDate ='" + this.createdDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    //queryString += "mcqmc_createdBy = " + this.createdBy.ToString() + ",";
                    //queryString += "mcqmc_ModifiedDate ='" + this.ModifiedDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    //queryString += "mcqmc_modifiedBy = " + this.modifiedBy.ToString() + ",";
                    //queryString += "mcqmc_statictTF ='" + this.statictTF.ToString() + "',";
                    //queryString += "mcqmc_staticNTF ='" + this.staticNTF.ToString() + "',";
                    //queryString += "mcqmc_tearMDAverage =" + this.tearMDAverage.ToString() + ",";
                    //queryString += "mcqmc_tearMDValues ='" + this.tearMDValues.ToString() + "',";
                    //queryString += "mcqmc_tearTDAverage =" + this.tearTDAverage.ToString() + ",";
                    //queryString += "mcqmc_tearTDValues ='" + this.tearTDValues.ToString() + "',";
                    //queryString += "mcqmc_dartImpactTFAverage =" + this.dartImpactTFAverage.ToString() + ",";
                    //queryString += "mcqmc_dartImpactTFValues ='" + this.dartImpactTFValues.ToString() + "',";
                    //queryString += "mcqmc_dartImpactNTFAverage =" + this.dartImpactNTFAverage.ToString() + ",";
                    //queryString += "mcqmc_dartImpactNTFValues ='" + this.dartImpactNTFValues.ToString() + "',";
                    //queryString += "mcqmc_metalFilmValues ='" + this.metalFilmValues.ToString() + "',";
                    //queryString += "mcqmc_metalFilmAverage =" + this.metalfilmAverage.ToString() + ",";
                    //queryString += "mcqmc_metalFilmAverage2 =" + this.metalfilmAverageII.ToString() + ",";
                    //queryString += "mcqmc_GlossIIValues ='" + this.GlossIIValues.ToString() + "',";
                    //queryString += "mcqmc_GlossIIAverage =" + this.GlossIIAverage.ToString() + ",";
                    //queryString += "mcqmc_GlossIIDesviation ='" + this.GlossIIDesviation.ToString() + "',";
                    //queryString += "mcqmc_sealStrengthValuesDMTFNewton =" + this.sealStrengthValuesDMTFNewton.ToString() + ",";
                    //queryString += "mcqmc_sealStrengthValuesDTNTFNewton =" + this.sealStrengthValuesDTNTFNewton.ToString() + ",";
                    //queryString += "mcqmc_sealStrengthValuesDMTFNewton2 =" + this.sealStrengthValuesDMTFNewtonII.ToString() + ",";
                    //queryString += "mcqmc_sealStrengthValuesDTNTFNewton2 =" + this.sealStrengthValuesDTNTFNewtonII.ToString() + "";
                    queryString += " WHERE mcqmc_codsec = " + this.codsec.ToString() + "";

                }
                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMainCoilQualityMetalCut.save");
                return false;
            }
        }

        public static clsMainCoilQualityMetalCut getQualityByCoil(int CoilCodsec)
        {
            clsMainCoilQualityMetalCut objMainCoilQuality = new clsMainCoilQualityMetalCut();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spMainCoilQualityMetal 'MainCoilQualityByCoil','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'," + CoilCodsec.ToString() + ",''");

            if (DS.Tables[0].Rows.Count > 0)
            {
                objMainCoilQuality.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mcqmc_codsec"]);
                objMainCoilQuality.densityOpticValues = DS.Tables[0].Rows[0]["mcqmc_densityOpticValues"].ToString();
                objMainCoilQuality.densityOpticList = clsGlobal.getDoubleListFromString(objMainCoilQuality.densityOpticValues);
                objMainCoilQuality.densityOpticAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqmc_densityOpticAverage"]);
                objMainCoilQuality.densityOpticDesviation = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqmc_densityOpticDesviation"]);
                objMainCoilQuality.tape = DS.Tables[0].Rows[0]["mcqmc_tape"].ToString();
                objMainCoilQuality.surfaceTensionValues = DS.Tables[0].Rows[0]["mcqmc_surfaceTensionValues"].ToString();
                objMainCoilQuality.surfaceTensionList = clsGlobal.getDoubleListFromString(objMainCoilQuality.surfaceTensionValues);
                objMainCoilQuality.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mcqmc_createdDate"]);
                objMainCoilQuality.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mcqmc_createdBy"]);
                objMainCoilQuality.ModifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mcqmc_ModifiedDate"]);
                objMainCoilQuality.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mcqmc_modifiedBy"]);
                objMainCoilQuality.creatorUser = DS.Tables[0].Rows[0]["mcqmc_creatorUser"].ToString();
                objMainCoilQuality.modificatorUser = DS.Tables[0].Rows[0]["mcqmc_modificatorUser"].ToString();
                objMainCoilQuality.labRating = DS.Tables[0].Rows[0]["mcqmc_labRating"].ToString();
                objMainCoilQuality.analistRating = DS.Tables[0].Rows[0]["mcqmc_analistRating"].ToString();
                objMainCoilQuality.notes = DS.Tables[0].Rows[0]["mcqmc_notes"].ToString();
            }
            return objMainCoilQuality;
        }

        private static int getLastSavedSalesOrderCodsec()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT mcqmc_codsec FROM bps_prod_maincoilqualitymetal ORDER BY mcqmc_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["mcqmc_codsec"]);
        }

        public void loadByQuantity(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spQualityByMainCoil(" + codsec.ToString() + ");");

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mcqmc_codsec"]);
            }
        }
    }
}
