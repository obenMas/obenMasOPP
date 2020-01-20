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
    public class clsMainCoilQualityMetal       
    {
        //Atributes
        private int mcqm_codsec;
        private string mcqm_densityOpticValues;
        private List<double> mcqm_densityOpticList;
        private double mcqm_densityOpticAverage;
        private double mcqm_densityOpticDesviation;
        private double mcqm_cof;
        private double mcqm_gramaje;
        private double mcqm_seal;
        private string mcqm_tape;
        private string mcqm_surfaceTensionValues;
        private List<double> mcqm_surfaceTensionList;
        private DateTime mcqm_createdDate;
        private int mcqm_createdBy;
        private DateTime mcqm_ModifiedDate;
        private int mcqm_modifiedBy;
        private string mcqm_creatorUser;
        private string mcqm_modificatorUser;
        private List<clsMainCoilMetal> mcqm_lstMainCoilMetal;
        private string mcqm_notes;

        
        

        private bool mcqm_opacityEvaluated;
        private bool mcqm_transmittanceEvaluated;
        private string mcqm_opacityTransmittanceValues;
        private List<double> mcqm_opacityTransmittanceList;
        //private List<double> mcqm_surfaceTensionList;
        private string mcqm_backSideValues;
        private List<bool> mcqm_bakSideList;
        private double mcqm_SealTemperatureTF;
        private string mcqm_sealTemperatureTFValues;
        private List<bool> mcqm_sealTemperatureTFList;
        private double mcqm_sealTemperatureNTF;
        private string mcqm_sealTemperatureNTFValues;
        private List<bool> mcqm_sealTemperatureNTFList;
        private string mcqm_appearance;
        private string mcqm_appearanceValues;
        private List<string> mcqm_appearanceList;
        private string mcqm_operatorCriterial;
        private string mcqm_fisicStatus;
        private string mcqm_frictionCoefficientTFValues;
        private List<double> mcqm_frictionCoefficientTFList;
        private double mcqm_frictionCoefficientTFAverage;
        private double mcqm_frictionCoefficientTFDinamicAverage;
        private string mcqm_frictionCoefficientNTFValues;
        private List<double> mcqm_frictionCoefficientNTFList;
        private double mcqm_frictionCoefficientNTFAverage;
        private double mcqm_frictionCoefficientNTFDinamicAverage;
        private string mcqm_GlossValues;
        private List<double> mcqm_GlossList;
        private double mcqm_GlossAverage;
        private double mcqm_GlossDesviation;
        private string mcqm_sealStrengthValues;
        private List<double> mcqm_sealStrengthList;
        private string mcqm_sealStrengthValuesTF;
        private List<double> mcqm_sealStrengthListTF;
        private List<double> mcqm_sealStrengthListNTF;
        private string mcqm_AnalistRating;
        private string mcqm_labRating;
        private DateTime mcqm_receptionDate;
        private int mcqm_opacityEvaluatedInt;
        private int mcqm_transmittanceEvaluatedInt;
        private string mcqm_treatmentValues;
        private string mcqm_sealStrengthValuesNTF;
        private string mcqm_statictTF;
        private string mcqm_staticNTF;
        private double mcqm_tearMDAverage;
        private List<double> mcqm_tearMDAList;
        private List<double> mcqm_tearTDAList;
        private List<double> mcqm_dartImpactTFList;
        private List<double> mcqm_dartImpactNTFList;
        private string mcqm_tearMDValues;
        private double mcqm_tearTDAverage;
        private string mcqm_tearTDValues;
        private double mcqm_dartImpactTFAverage;
        private string mcqm_dartImpactTFValues;
        private double mcqm_dartImpactNTFAverage;
        private string mcqm_dartImpactNTFValues;
        private string mcqm_metalFilmValues;
        private List<double> mcqm_metalFilmValuesList;
        private double mcqm_metalFilmAverage;
        private double mcqm_metalFilmAverageII;
        private string mcqm_GlossIIValues;
        private List<double> mcqm_GlossIIList;
        private double mcqm_GlossIIAverage;
        private double mcqm_GlossIIDesviation;
        private double mcqm_sealStrengthValuesDMTFNewton;
        private double mcqm_sealStrengthValuesDTNTFNewton;
        private double mcqm_sealStrengthValuesDMTFNewton2;
        private double mcqm_sealStrengthValuesDTNTFNewton2;

        //Properties
        public int codsec { get { return mcqm_codsec; } set { mcqm_codsec = value; } }

        public string densityOpticValues { get { return mcqm_densityOpticValues; } set { mcqm_densityOpticValues = value; } }

        public List<double> densityOpticList { get { return mcqm_densityOpticList; } set { mcqm_densityOpticList = value; } }

        public double densityOpticAverage { get { return mcqm_densityOpticAverage; } set { mcqm_densityOpticAverage = value; } }

        public double densityOpticDesviation { get { return mcqm_densityOpticDesviation; } set { mcqm_densityOpticDesviation = value; } }

        public double cof { get { return mcqm_cof; } set { mcqm_cof = value; } }

        public double gramaje { get { return mcqm_gramaje; } set { mcqm_gramaje = value; } }

        public double seal { get { return mcqm_seal; } set { mcqm_seal = value; } }

        public string tape { get { return mcqm_tape; } set { mcqm_tape = value; } }

        public string surfaceTensionValues { get { return mcqm_surfaceTensionValues; } set { mcqm_surfaceTensionValues = value; } }

        public List<double> surfaceTensionList { get { return mcqm_surfaceTensionList; } set { mcqm_surfaceTensionList = value; } }

        public DateTime createdDate { get { return mcqm_createdDate; } set { mcqm_createdDate = value; } }

        public int createdBy { get { return mcqm_createdBy; } set { mcqm_createdBy = value; } }

        public DateTime ModifiedDate { get { return mcqm_ModifiedDate; } set { mcqm_ModifiedDate = value; } }

        public int modifiedBy { get { return mcqm_modifiedBy; } set { mcqm_modifiedBy = value; } }

        public string creatorUser { get { return mcqm_creatorUser; } set { mcqm_creatorUser = value; } }

        public string modificatorUser { get { return mcqm_modificatorUser; } set { mcqm_modificatorUser = value; } }

        public string notes { get { return mcqm_notes; } set { mcqm_notes = value; } }

        public List<clsMainCoilMetal> lstMainCoilMetal { get { return mcqm_lstMainCoilMetal; } set { mcqm_lstMainCoilMetal = value; } }



        public bool opacityEvaluated { get { return mcqm_opacityEvaluated; } set { mcqm_opacityEvaluated = value; } }

        public bool transmittanceEvaluated { get { return mcqm_transmittanceEvaluated; } set { mcqm_transmittanceEvaluated = value; } }

        public string opacityTransmittanceValues { get { return mcqm_opacityTransmittanceValues; } set { mcqm_opacityTransmittanceValues = value; } }

        public List<double> opacityTransmittanceList { get { return mcqm_opacityTransmittanceList; } set { mcqm_opacityTransmittanceList = value; } }

        //public List<double> surfaceTensionList { get { return mcqm_surfaceTensionList; } set { mcqm_surfaceTensionList = value; } }

        public string backSideValues { get { return mcqm_backSideValues; } set { mcqm_backSideValues = value; } }

        public List<bool> bakSideList { get { return mcqm_bakSideList; } set { mcqm_bakSideList = value; } }

        public double SealTemperatureTF { get { return mcqm_SealTemperatureTF; } set { mcqm_SealTemperatureTF = value; } }

        public string sealTemperatureTFValues { get { return mcqm_sealTemperatureTFValues; } set { mcqm_sealTemperatureTFValues = value; } }

        public List<bool> sealTemperatureTFList { get { return mcqm_sealTemperatureTFList; } set { mcqm_sealTemperatureTFList = value; } }

        public double sealTemperatureNTF { get { return mcqm_sealTemperatureNTF; } set { mcqm_sealTemperatureNTF = value; } }

        public string sealTemperatureNTFValues { get { return mcqm_sealTemperatureNTFValues; } set { mcqm_sealTemperatureNTFValues = value; } }

        public List<bool> sealTemperatureNTFList { get { return mcqm_sealTemperatureNTFList; } set { mcqm_sealTemperatureNTFList = value; } }

        public string appearance { get { return mcqm_appearance; } set { mcqm_appearance = value; } }

        public string appearanceValues { get { return mcqm_appearanceValues; } set { mcqm_appearanceValues = value; } }

        public List<string> appearanceList { get { return mcqm_appearanceList; } set { mcqm_appearanceList = value; } }

        public string operatorCriterial { get { return mcqm_operatorCriterial; } set { mcqm_operatorCriterial = value; } }

        public string fisicStatus { get { return mcqm_fisicStatus; } set { mcqm_fisicStatus = value; } }

        public string frictionCoefficientTFValues { get { return mcqm_frictionCoefficientTFValues; } set { mcqm_frictionCoefficientTFValues = value; } }

        public List<double> frictionCoefficientTFList { get { return mcqm_frictionCoefficientTFList; } set { mcqm_frictionCoefficientTFList = value; } }

        public double frictionCoefficientTFAverage { get { return mcqm_frictionCoefficientTFAverage; } set { mcqm_frictionCoefficientTFAverage = value; } }

        public double frictionCoefficientTFDinamicAverage { get { return mcqm_frictionCoefficientTFDinamicAverage; } set { mcqm_frictionCoefficientTFDinamicAverage = value; } }

        public string frictionCoefficientNTFValues { get { return mcqm_frictionCoefficientNTFValues; } set { mcqm_frictionCoefficientNTFValues = value; } }

        public List<double> frictionCoefficientNTFList { get { return mcqm_frictionCoefficientNTFList; } set { mcqm_frictionCoefficientNTFList = value; } }

        public double frictionCoefficientNTFAverage { get { return mcqm_frictionCoefficientNTFAverage; } set { mcqm_frictionCoefficientNTFAverage = value; } }

        public double frictionCoefficientNTFDinamicAverage { get { return mcqm_frictionCoefficientNTFDinamicAverage; } set { mcqm_frictionCoefficientNTFDinamicAverage = value; } }

        public string GlossValues { get { return mcqm_GlossValues; } set { mcqm_GlossValues = value; } }

        public List<double> GlossList { get { return mcqm_GlossList; } set { mcqm_GlossList = value; } }

        public double GlossAverage { get { return mcqm_GlossAverage; } set { mcqm_GlossAverage = value; } }

        public double GlossDesviation { get { return mcqm_GlossDesviation; } set { mcqm_GlossDesviation = value; } }

        public string sealStrengthValuesTF { get { return mcqm_sealStrengthValuesTF; } set { mcqm_sealStrengthValuesTF = value; } }

        public string sealStrengthValues { get { return mcqm_sealStrengthValues; } set { mcqm_sealStrengthValues = value; } }
        public List<double> sealStrengthList { get { return mcqm_sealStrengthList; } set { mcqm_sealStrengthList = value; } }

        public List<double> sealStrengthListTF { get { return mcqm_sealStrengthListTF; } set { mcqm_sealStrengthListTF = value; } }
        public List<double> sealStrengthListNTF { get { return mcqm_sealStrengthListNTF; } set { mcqm_sealStrengthListNTF = value; } }

        public string AnalistRating { get { return mcqm_AnalistRating; } set { mcqm_AnalistRating = value; } }

        public string labRating { get { return mcqm_labRating; } set { mcqm_labRating = value; } }

        public DateTime receptionDate { get { return mcqm_receptionDate; } set { mcqm_receptionDate = value; } }

        public int opacityEvaluatedInt { get { return mcqm_opacityEvaluatedInt; } set { mcqm_opacityEvaluatedInt = value; } }

        public int transmittanceEvaluatedInt { get { return mcqm_transmittanceEvaluatedInt; } set { mcqm_transmittanceEvaluatedInt = value; } }

        public string sealStrengthValuesNTF { get { return mcqm_sealStrengthValuesNTF; } set { mcqm_sealStrengthValuesNTF = value; } }

        public string treatmentValues { get { return mcqm_treatmentValues; } set { mcqm_treatmentValues = value; } }

        public string statictTF { get { return mcqm_statictTF; } set { mcqm_statictTF = value; } }

        public string staticNTF { get { return mcqm_staticNTF; } set { mcqm_staticNTF = value; } }

        public double tearMDAverage { get { return mcqm_tearMDAverage; } set { mcqm_tearMDAverage = value; } }

        public string tearMDValues { get { return mcqm_tearMDValues; } set { mcqm_tearMDValues = value; } }

        public double tearTDAverage { get { return mcqm_tearTDAverage; } set { mcqm_tearTDAverage = value; } }

        public string tearTDValues { get { return mcqm_tearTDValues; } set { mcqm_tearTDValues = value; } }

        public List<double> tearMDAList { get { return mcqm_tearMDAList; } set { mcqm_tearMDAList = value; } }

        public List<double> tearTDAList { get { return mcqm_tearTDAList; } set { mcqm_tearTDAList = value; } }

        public List<double> dartImpactTFList { get { return mcqm_dartImpactTFList; } set { mcqm_dartImpactTFList = value; } }

        public List<double> dartImpactNTFList { get { return mcqm_dartImpactNTFList; } set { mcqm_dartImpactNTFList = value; } }

        public double dartImpactTFAverage { get { return mcqm_dartImpactTFAverage; } set { mcqm_dartImpactTFAverage = value; } }

        public string dartImpactTFValues { get { return mcqm_dartImpactTFValues; } set { mcqm_dartImpactTFValues = value; } }

        public double dartImpactNTFAverage { get { return mcqm_dartImpactNTFAverage; } set { mcqm_dartImpactNTFAverage = value; } }

        public string dartImpactNTFValues { get { return mcqm_dartImpactNTFValues; } set { mcqm_dartImpactNTFValues = value; } }

        public string metalFilmValues { get { return mcqm_metalFilmValues; } set { mcqm_metalFilmValues = value; } }

        public List<double> metalfilmValuesList { get { return mcqm_metalFilmValuesList; } set { mcqm_metalFilmValuesList = value; } }

        public double metalfilmAverage { get { return mcqm_metalFilmAverage; } set { mcqm_metalFilmAverage = value; } }

        public double metalfilmAverageII { get { return mcqm_metalFilmAverageII; } set { mcqm_metalFilmAverageII = value; } }

        public string GlossIIValues { get { return mcqm_GlossIIValues; } set { mcqm_GlossIIValues = value; } }

        public List<double> GlossIIList { get { return mcqm_GlossIIList; } set { mcqm_GlossIIList = value; } }

        public double GlossIIAverage { get { return mcqm_GlossIIAverage; } set { mcqm_GlossIIAverage = value; } }

        public double GlossIIDesviation { get { return mcqm_GlossIIDesviation; } set { mcqm_GlossIIDesviation = value; } }

        public double sealStrengthValuesDMTFNewton { get { return mcqm_sealStrengthValuesDMTFNewton; } set { mcqm_sealStrengthValuesDMTFNewton = value; } }

        public double sealStrengthValuesDTNTFNewton { get { return mcqm_sealStrengthValuesDTNTFNewton; } set { mcqm_sealStrengthValuesDTNTFNewton = value; } }

        public double sealStrengthValuesDMTFNewtonII { get { return mcqm_sealStrengthValuesDMTFNewton2; } set { mcqm_sealStrengthValuesDMTFNewton2 = value; } }

        public double sealStrengthValuesDTNTFNewtonII { get { return mcqm_sealStrengthValuesDTNTFNewton2; } set { mcqm_sealStrengthValuesDTNTFNewton2 = value; } }


        //Constructor

        public clsMainCoilQualityMetal()
        {
            mcqm_codsec = 0;
            mcqm_densityOpticValues = "0;0;0;0;0;0;0;0;0;0;0;0;0;0";
            mcqm_densityOpticList = new List<double>();
            mcqm_densityOpticAverage = 0;
            mcqm_densityOpticDesviation = 0;
            mcqm_cof = 0;
            mcqm_gramaje = 0;
            mcqm_seal = 0;
            mcqm_tape = "";
            mcqm_surfaceTensionValues = "0;0;0;0;0;0";
            mcqm_createdDate = DateTime.Now;
            mcqm_createdBy = 88;
            mcqm_ModifiedDate = DateTime.Now;
            mcqm_modifiedBy = 88;
            mcqm_creatorUser = "";
            mcqm_modificatorUser = "";
            mcqm_notes = "";
            mcqm_lstMainCoilMetal = new List<clsMainCoilMetal>();
            
            mcqm_opacityEvaluated = false;
            mcqm_transmittanceEvaluated = false;
            mcqm_opacityTransmittanceValues = "";
            mcqm_opacityTransmittanceList = new List<double>();
            mcqm_surfaceTensionList = new List<double>();
            mcqm_backSideValues = "";
            mcqm_bakSideList = new List<bool>();
            mcqm_SealTemperatureTF = 0;
            mcqm_sealTemperatureTFValues = "";
            mcqm_sealTemperatureTFList = new List<bool>();
            mcqm_sealTemperatureNTF = 0;
            mcqm_sealTemperatureNTFValues = "";
            mcqm_sealTemperatureNTFList = new List<bool>();
            mcqm_appearance = "";
            mcqm_appearanceValues = "";
            mcqm_appearanceList = new List<string>();
            mcqm_operatorCriterial = "";
            mcqm_fisicStatus = "";
            mcqm_frictionCoefficientTFValues = "";
            mcqm_frictionCoefficientTFList = new List<double>();
            mcqm_frictionCoefficientTFAverage = 0;
            mcqm_frictionCoefficientTFDinamicAverage = 0;
            mcqm_frictionCoefficientNTFValues = "";
            mcqm_frictionCoefficientNTFList = new List<double>();
            mcqm_frictionCoefficientNTFAverage = 0;
            mcqm_frictionCoefficientNTFDinamicAverage = 0;
            mcqm_GlossValues = "";
            mcqm_GlossList = new List<double>();
            mcqm_GlossAverage = 0;
            mcqm_GlossDesviation = 0;
            mcqm_sealStrengthValues = "";
            mcqm_sealStrengthList = new List<double>();
            mcqm_sealStrengthValuesTF = "";
            mcqm_sealStrengthListTF = new List<double>();
            mcqm_sealStrengthValuesNTF = "";
            mcqm_sealStrengthListNTF = new List<double>();
            mcqm_AnalistRating = "";
            mcqm_labRating = "";
            mcqm_receptionDate = DateTime.Now;
            mcqm_opacityEvaluatedInt = 0;
            mcqm_transmittanceEvaluatedInt = 0;
            mcqm_tearMDAList = new List<double>();
            mcqm_tearTDAList = new List<double>();
            mcqm_dartImpactTFList = new List<double>();
            mcqm_dartImpactNTFList = new List<double>();
            mcqm_statictTF = "";
            mcqm_staticNTF = "";
            mcqm_tearMDAverage = 0;
            mcqm_tearMDValues = "";
            mcqm_tearTDAverage = 0;
            mcqm_tearTDValues = "";
            mcqm_dartImpactTFAverage = 0;
            mcqm_dartImpactTFValues = "";
            mcqm_dartImpactNTFAverage = 0;
            mcqm_dartImpactNTFValues = "";
            mcqm_sealStrengthValuesNTF = "";
            mcqm_metalFilmValues = string.Empty;
            mcqm_metalFilmValuesList = new List<double>();
            mcqm_metalFilmAverage = 0;
            mcqm_metalFilmAverageII = 0;
            mcqm_GlossIIValues = string.Empty;
            mcqm_GlossIIList = new List<double>();
            mcqm_GlossIIAverage = 0;
            mcqm_GlossIIDesviation = 0;
            mcqm_sealStrengthValuesDMTFNewton = 0;
            mcqm_sealStrengthValuesDTNTFNewton = 0;
            mcqm_sealStrengthValuesDMTFNewton2 = 0;
            mcqm_sealStrengthValuesDTNTFNewton2 = 0;
        }
        public clsMainCoilQualityMetal(int codsec)
        {
            this.load(codsec);
        }

        //Methods
        public void load(int codsec)
        {
            //DataSet DS = new DataSet();
            //DS = clsConnection.getDataSetResult("SELECT * FROM vwmaincoilquality where mcqm_codsec =  " + codsec.ToString());

            //if (DS.Tables[0].Rows.Count > 0)
            //{
            //    this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mcqm_codsec"]);
            //    this.densityOpticValues = DS.Tables[0].Rows[0]["mcqm_thikness"].ToString();
            //    this.densityOpticList = clsGlobal.getDoubleListFromString(this.densityOpticValues);
            //    this.densityOpticAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqm_thiknessAverage"]);
            //    this.densityOpticDesviation = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqm_thiknessDesviation"]);
            //    this.gramaje = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqm_gramaje"]);
            //    this.opacityEvaluated = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["mcqm_opacityEvaluated"], DS.Tables[0].Rows[0]["mcqm_opacityEvaluated"].GetType().FullName);
            //    this.transmittanceEvaluated = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["mcqm_transmittanceEvaluated"], DS.Tables[0].Rows[0]["mcqm_transmittanceEvaluated"].GetType().FullName);
            //    this.opacityTransmittanceValues = DS.Tables[0].Rows[0]["mcqm_opacityTransmittanceValues"].ToString();
            //    this.opacityTransmittanceList = clsGlobal.getDoubleListFromString(this.opacityTransmittanceValues);
            //    this.surfaceTensionValues = DS.Tables[0].Rows[0]["mcqm_surfaceTensionValues"].ToString();
            //    this.surfaceTensionList = clsGlobal.getDoubleListFromString(this.surfaceTensionValues);
            //    this.backSideValues = DS.Tables[0].Rows[0]["mcqm_backSideValues"].ToString();
            //    this.bakSideList = clsGlobal.getBooleanListFromString(this.backSideValues);
            //    this.SealTemperatureTF = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqm_SealTemperatureTF"]);
            //    this.sealTemperatureTFValues = DS.Tables[0].Rows[0]["mcqm_sealTemperatureTFValues"].ToString();
            //    this.sealTemperatureTFList = clsGlobal.getBooleanListFromString(this.sealTemperatureTFValues);
            //    this.sealTemperatureNTF = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqm_sealTemperatureNTF"]);
            //    this.sealTemperatureNTFValues = DS.Tables[0].Rows[0]["mcqm_sealTemperatureNTFValues"].ToString();
            //    this.sealTemperatureNTFList = clsGlobal.getBooleanListFromString(this.sealTemperatureNTFValues);
            //    this.appearance = DS.Tables[0].Rows[0]["mcqm_appearance"].ToString();
            //    this.appearanceValues = DS.Tables[0].Rows[0]["mcqm_appearanceValues"].ToString();
            //    this.appearanceList = clsGlobal.getStringListFromString(this.appearanceValues);
            //    this.operatorCriterial = DS.Tables[0].Rows[0]["mcqm_operatorCriterial"].ToString();
            //    this.fisicStatus = DS.Tables[0].Rows[0]["mcqm_fisicStatus"].ToString();
            //    this.frictionCoefficientTFValues = DS.Tables[0].Rows[0]["mcqm_firctionCoefficientTFValues"].ToString();
            //    this.frictionCoefficientTFList = clsGlobal.getDoubleListFromString(this.frictionCoefficientTFValues);
            //    this.frictionCoefficientTFAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqm_frictionCoefficientTFAverage"]);
            //    this.frictionCoefficientTFDinamicAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqm_frictionCoefficientTFDinamicAverage"]);
            //    this.frictionCoefficientNTFValues = DS.Tables[0].Rows[0]["mcqm_frictionCoeficientNTFValues"].ToString();
            //    this.frictionCoefficientNTFList = clsGlobal.getDoubleListFromString(this.frictionCoefficientNTFValues);
            //    this.frictionCoefficientNTFAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqm_frictionCoefficientNTFAverage"]);
            //    this.frictionCoefficientNTFDinamicAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqm_frictionCoefficientNTFDinamicAverage"]);
            //    this.GlossValues = DS.Tables[0].Rows[0]["mcqm_GlossValues"].ToString();
            //    this.GlossList = clsGlobal.getDoubleListFromString(this.GlossValues);
            //    this.GlossAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqm_GlossAverage"]);
            //    this.GlossDesviation = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqm_GlossDesviation"]);
            //    this.sealStrengthValues = DS.Tables[0].Rows[0]["mcqm_sealStrengthValues"].ToString();
            //    this.sealStrengthValuesTF = DS.Tables[0].Rows[0]["mcqm_sealStrengthValuesTF"].ToString();
            //    this.sealStrengthList = clsGlobal.getDoubleListFromString(this.sealStrengthValues);
            //    this.sealStrengthListTF = clsGlobal.getDoubleListFromString(this.sealStrengthValuesTF);
            //    this.sealStrengthListNTF = clsGlobal.getDoubleListFromString(this.sealStrengthValuesNTF);
            //    this.AnalistRating = DS.Tables[0].Rows[0]["mcqm_"].ToString();
            //    this.labRating = DS.Tables[0].Rows[0]["mcqm_"].ToString();
            //    this.receptionDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mcqm_receptionDate"]);
            //    this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mcqm_createdDate"]);
            //    this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mcqm_createdBy"]);
            //    this.ModifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mcqm_ModifiedDate"]);
            //    this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mcqm_modifiedBy"]);
            //    this.creatorUser = DS.Tables[0].Rows[0]["mcqm_creatorUser"].ToString();
            //    this.modificatorUser = DS.Tables[0].Rows[0]["mcqm_modificatorUser"].ToString();
            //    this.lstMainCoilMetal = clsMainCoil.getBoppMainCoilListByQualityReport(this.codsec);

            //    this.statictTF = DS.Tables[0].Rows[0]["mcqm_statictTF"].ToString();
            //    this.staticNTF = DS.Tables[0].Rows[0]["mcqm_statictNTF"].ToString();
            //    this.tearMDAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqm_tearMDAverage"]);
            //    this.tearMDValues = DS.Tables[0].Rows[0]["mcqm_tearMDValues"].ToString();
            //    this.tearMDAList = clsGlobal.getDoubleListFromString(this.tearMDValues);
            //    this.tearTDAList = clsGlobal.getDoubleListFromString(this.dartImpactTFValues);
            //    this.dartImpactTFList = clsGlobal.getDoubleListFromString(this.tearTDValues);

            //    this.tearTDAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqm_tearTDAverage"]);
            //    this.tearTDValues = DS.Tables[0].Rows[0]["mcqm_tearTDValues"].ToString();
            //    this.dartImpactTFAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqm_dartImpactTFAverage"]);
            //    this.dartImpactTFValues = DS.Tables[0].Rows[0]["mcqm_dartImpactTFValues"].ToString();
            //    this.dartImpactNTFAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqm_dartImpactNTFAverage"]);
            //    this.dartImpactNTFValues = DS.Tables[0].Rows[0]["mcqm_dartImpactNTFValues"].ToString();
            //    this.sealStrengthValuesNTF = DS.Tables[0].Rows[0]["mcqm_sealStrengthValuesNTF"].ToString();

            //}
        }

        public bool save()
        {
            string queryString = "";    
            try
            {
                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_maincoilqualitymetal (mcqm_densityOpticValues, mcqm_densityOpticAverage, mcqm_densityOpticDesviation, mcqm_cof, mcqm_gramaje, mcqm_seal, mcqm_tape, mcqm_surfaceTensionValues, mcqm_createdDate, mcqm_createdBy, mcqm_ModifiedDate, mcqm_modifiedBy, mcqm_notes)";
                    //"mcqm_transmittanceEvaluated, mcqm_opacityTrasmittanceValues, mcqm_surfaceTensionValues, mcqm_backSideValues, mcqm_SealTemperatureTF, mcqm_sealTemperatureTFValues, " +
                    //"mcqm_sealTemperatureNTF, mcqm_sealTemperatureNTFValues, mcqm_appearance, mcqm_appearanceValues, mcqm_operatorCriterial, mcqm_fisicStatus, mcqm_firctionCoefficientTFValues, " +
                    //"mcqm_frictionCoefficientTFAverage, mcqm_frictionCoeficientNTFValues, mcqm_frictionCoefficientNTFAverage, mcqm_GlossValues, mcqm_GlossAverage, mcqm_GlossDesviation, " +
                    //"mcqm_sealStrengthValues,mcqm_sealStrengthValuesTF,mcqm_sealStrengthValuesNTF, mcqm_receptionDate, mcqm_createdDate, mcqm_createdBy, mcqm_ModifiedDate, mcqm_modifiedBy, " +
                    //"mcqm_treatmentValues, mcqm_statictTF, mcqm_staticNTF, mcqm_tearMDAverage, mcqm_tearMDValues, mcqm_tearTDAverage, mcqm_tearTDValues, mcqm_dartImpactTFAverage, " +
                    //"mcqm_dartImpactTFValues, mcqm_dartImpactNTFAverage, mcqm_dartImpactNTFValues, mcqm_frictionCoefficientTFDinamicAverage, mcqm_frictionCoefficientNTFDinamicAverage, " +
                    //"mcqm_metalFilmValues, mcqm_metalFilmAverage, mcqm_metalFilmAverage2, mcqm_GlossIIValues, mcqm_GlossIIAverage, mcqm_GlossIIDesviation, mcqm_sealStrengthValuesDMTFNewton, mcqm_sealStrengthValuesDTNTFNewton, mcqm_sealStrengthValuesDMTFNewton2, mcqm_sealStrengthValuesDTNTFNewton2) ";
                    queryString += " VALUES (";
                    queryString += "'" + this.densityOpticValues.ToString() + "',";
                    queryString += "" + this.densityOpticAverage.ToString() + ",";
                    queryString += "" + this.densityOpticDesviation.ToString() + ",";
                    queryString += "" + this.cof.ToString() + ",";
                    queryString += "" + this.gramaje.ToString() + ",";
                    queryString += "" + this.seal.ToString() + ",";
                    queryString += "'" + this.tape.ToString() + "',";
                    queryString += "'" + this.surfaceTensionValues.ToString() + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "" + clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "" + clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += "'" + this.notes.ToString() + "')";

                    
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
                    queryString += "UPDATE bps_prod_maincoilqualitymetal ";
                    queryString += " SET ";
                    queryString += "mcqm_densityOpticValues ='" + this.densityOpticValues.ToString() + "',";
                    queryString += "mcqm_densityOpticAverage = " + this.densityOpticAverage.ToString() + ",";
                    queryString += "mcqm_densityOpticDesviation = " + this.densityOpticDesviation.ToString() + ",";
                    queryString += "mcqm_cof = " + this.cof.ToString() + ",";
                    queryString += "mcqm_gramaje = " + this.gramaje.ToString() + ",";
                    queryString += "mcqm_seal = " + this.seal.ToString() + ",";
                    queryString += "mcqm_tape ='" + this.tape.ToString() + "',";
                    queryString += "mcqm_surfaceTensionValues = '" + this.surfaceTensionValues.ToString() + "',";
                    queryString += "mcqm_ModifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "mcqm_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += "mcqm_notes ='" + this.notes.ToString() + "' ";


                    //queryString += "mcqm_sealTemperatureNTF = " + this.sealTemperatureNTF.ToString() + ",";
                    //queryString += "mcqm_sealTemperatureNTFValues ='" + this.sealTemperatureNTFValues.ToString() + "',";
                    //queryString += "mcqm_appearance ='" + this.appearance.ToString() + "',";
                    //queryString += "mcqm_appearanceValues ='" + this.appearanceValues.ToString() + "',";
                    //queryString += "mcqm_operatorCriterial ='" + this.operatorCriterial.ToString() + "',";
                    //queryString += "mcqm_fisicStatus ='" + this.fisicStatus.ToString() + "',";
                    //queryString += "mcqm_firctionCoefficientTFValues ='" + this.frictionCoefficientTFValues.ToString() + "',";
                    //queryString += "mcqm_frictionCoefficientTFAverage = " + this.frictionCoefficientTFAverage.ToString() + ",";
                    //queryString += "mcqm_frictionCoefficientTFDinamicAverage = " + this.frictionCoefficientTFDinamicAverage.ToString() + ",";
                    //queryString += "mcqm_frictionCoeficientNTFValues ='" + this.frictionCoefficientNTFValues.ToString() + "',";
                    //queryString += "mcqm_frictionCoefficientNTFAverage = " + this.frictionCoefficientNTFAverage.ToString() + ",";
                    //queryString += "mcqm_frictionCoefficientNTFDinamicAverage = " + this.frictionCoefficientNTFDinamicAverage.ToString() + ",";
                    //queryString += "mcqm_GlossValues ='" + this.GlossValues.ToString() + "',";
                    //queryString += "mcqm_GlossAverage = " + this.GlossAverage.ToString() + ",";
                    //queryString += "mcqm_GlossDesviation = " + this.GlossDesviation.ToString() + ",";
                    //queryString += "mcqm_sealStrengthValues ='" + this.sealStrengthValues.ToString() + "',";
                    //queryString += "mcqm_sealStrengthValuesTF ='" + this.sealStrengthValuesTF.ToString() + "',";
                    //queryString += "mcqm_sealStrengthValuesNTF ='" + this.sealStrengthValuesNTF.ToString() + "',";
                    //queryString += "mcqm_receptionDate ='" + this.receptionDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    //queryString += "mcqm_createdDate ='" + this.createdDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    //queryString += "mcqm_createdBy = " + this.createdBy.ToString() + ",";
                    //queryString += "mcqm_ModifiedDate ='" + this.ModifiedDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    //queryString += "mcqm_modifiedBy = " + this.modifiedBy.ToString() + ",";
                    //queryString += "mcqm_statictTF ='" + this.statictTF.ToString() + "',";
                    //queryString += "mcqm_staticNTF ='" + this.staticNTF.ToString() + "',";
                    //queryString += "mcqm_tearMDAverage =" + this.tearMDAverage.ToString() + ",";
                    //queryString += "mcqm_tearMDValues ='" + this.tearMDValues.ToString() + "',";
                    //queryString += "mcqm_tearTDAverage =" + this.tearTDAverage.ToString() + ",";
                    //queryString += "mcqm_tearTDValues ='" + this.tearTDValues.ToString() + "',";
                    //queryString += "mcqm_dartImpactTFAverage =" + this.dartImpactTFAverage.ToString() + ",";
                    //queryString += "mcqm_dartImpactTFValues ='" + this.dartImpactTFValues.ToString() + "',";
                    //queryString += "mcqm_dartImpactNTFAverage =" + this.dartImpactNTFAverage.ToString() + ",";
                    //queryString += "mcqm_dartImpactNTFValues ='" + this.dartImpactNTFValues.ToString() + "',";
                    //queryString += "mcqm_metalFilmValues ='" + this.metalFilmValues.ToString() + "',";
                    //queryString += "mcqm_metalFilmAverage =" + this.metalfilmAverage.ToString() + ",";
                    //queryString += "mcqm_metalFilmAverage2 =" + this.metalfilmAverageII.ToString() + ",";
                    //queryString += "mcqm_GlossIIValues ='" + this.GlossIIValues.ToString() + "',";
                    //queryString += "mcqm_GlossIIAverage =" + this.GlossIIAverage.ToString() + ",";
                    //queryString += "mcqm_GlossIIDesviation ='" + this.GlossIIDesviation.ToString() + "',";
                    //queryString += "mcqm_sealStrengthValuesDMTFNewton =" + this.sealStrengthValuesDMTFNewton.ToString() + ",";
                    //queryString += "mcqm_sealStrengthValuesDTNTFNewton =" + this.sealStrengthValuesDTNTFNewton.ToString() + ",";
                    //queryString += "mcqm_sealStrengthValuesDMTFNewton2 =" + this.sealStrengthValuesDMTFNewtonII.ToString() + ",";
                    //queryString += "mcqm_sealStrengthValuesDTNTFNewton2 =" + this.sealStrengthValuesDTNTFNewtonII.ToString() + "";
                    queryString += " WHERE mcqm_codsec = " + this.codsec.ToString() + "";

                }
                if (clsConnection.executeQuery(queryString))
                {
                    if (this.codsec == 0)
                    {
                        this.codsec = clsMainCoilQualityMetal.getLastSavedSalesOrderCodsec();

                        for (int i = 0; i < lstMainCoilMetal.Count; i++)
                        {
                            queryString = "INSERT INTO bps_prod_maincoilsbyqualitymetal (mcbqm_fkMainCoilMetal, mcbqm_fkMainCoilQualityMetal)";
                            queryString += " VALUES (";
                            queryString += "" + lstMainCoilMetal[i].codsec.ToString() + ",";
                            queryString += "" + this.codsec + "";
                            queryString += ")";

                            clsConnection.executeQuery(queryString);
                        }
                    } return true;
                }
                else
                    return false;

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMainCoilQuality.save");
                return false;
            }
        }

        public static clsMainCoilQualityMetal getQualityByMainCoil(int mainCoilCodsec)
        {
            clsMainCoilQualityMetal objMainCoilQuality = new clsMainCoilQualityMetal();

            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("spQualityMainCoilMetal " + mainCoilCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                objMainCoilQuality.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mcqm_codsec"]);
                objMainCoilQuality.densityOpticValues = DS.Tables[0].Rows[0]["mcqm_densityOpticValues"].ToString();
                objMainCoilQuality.densityOpticList = clsGlobal.getDoubleListFromString(objMainCoilQuality.densityOpticValues);
                objMainCoilQuality.densityOpticAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqm_densityOpticAverage"]);
                objMainCoilQuality.densityOpticDesviation = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqm_densityOpticDesviation"]);
                objMainCoilQuality.cof = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqm_cof"]);
                objMainCoilQuality.gramaje = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqm_gramaje"]);
                objMainCoilQuality.seal = Convert.ToInt32(DS.Tables[0].Rows[0]["mcqm_seal"]);
                objMainCoilQuality.tape = DS.Tables[0].Rows[0]["mcqm_tape"].ToString();
                objMainCoilQuality.surfaceTensionValues = DS.Tables[0].Rows[0]["mcqm_surfaceTensionValues"].ToString();
                objMainCoilQuality.surfaceTensionList = clsGlobal.getDoubleListFromString(objMainCoilQuality.surfaceTensionValues);
                objMainCoilQuality.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mcqm_createdDate"]);
                objMainCoilQuality.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mcqm_createdBy"]);
                objMainCoilQuality.ModifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mcqm_ModifiedDate"]);
                objMainCoilQuality.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mcqm_modifiedBy"]);
                objMainCoilQuality.creatorUser = DS.Tables[0].Rows[0]["mcqm_creatorUser"].ToString();
                objMainCoilQuality.modificatorUser = DS.Tables[0].Rows[0]["mcqm_modificatorUser"].ToString();
                objMainCoilQuality.lstMainCoilMetal = clsMainCoilMetal.getListByMainCoilCodsec(Convert.ToInt32(DS.Tables[0].Rows[0]["mcbqm_fkMainCoilMetal"]));
                objMainCoilQuality.notes = DS.Tables[0].Rows[0]["mcqm_notes"].ToString();
                objMainCoilQuality.labRating = DS.Tables[0].Rows[0]["mclm_labRating"].ToString();
                objMainCoilQuality.AnalistRating = DS.Tables[0].Rows[0]["mclm_analistRating"].ToString();

                //objMainCoilQuality.opacityEvaluated = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["mcqm_opacityEvaluated"], DS.Tables[0].Rows[0]["mcqm_opacityEvaluated"].GetType().FullName);
                //objMainCoilQuality.transmittanceEvaluated = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["mcqm_transmittanceEvaluated"], DS.Tables[0].Rows[0]["mcqm_transmittanceEvaluated"].GetType().FullName);
                //objMainCoilQuality.opacityTransmittanceValues = DS.Tables[0].Rows[0]["mcqm_opacityTrasmittanceValues"].ToString();
                //objMainCoilQuality.opacityTransmittanceList = clsGlobal.getDoubleListFromString(objMainCoilQuality.opacityTransmittanceValues);
                //objMainCoilQuality.surfaceTensionValues = DS.Tables[0].Rows[0]["mcqm_surfaceTensionValues"].ToString();
                //objMainCoilQuality.surfaceTensionList = clsGlobal.getDoubleListFromString(objMainCoilQuality.surfaceTensionValues);
                //objMainCoilQuality.backSideValues = DS.Tables[0].Rows[0]["mcqm_backSideValues"].ToString();
                //objMainCoilQuality.bakSideList = clsGlobal.getBooleanListFromString(objMainCoilQuality.backSideValues);
                //objMainCoilQuality.SealTemperatureTF = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqm_SealTemperatureTF"]);
                //objMainCoilQuality.sealTemperatureTFValues = DS.Tables[0].Rows[0]["mcqm_sealTemperatureTFValues"].ToString();
                //objMainCoilQuality.sealTemperatureTFList = clsGlobal.getBooleanListFromString(objMainCoilQuality.sealTemperatureTFValues);
                //objMainCoilQuality.sealTemperatureNTF = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqm_sealTemperatureNTF"]);
                //objMainCoilQuality.sealTemperatureNTFValues = DS.Tables[0].Rows[0]["mcqm_sealTemperatureNTFValues"].ToString();
                //objMainCoilQuality.sealTemperatureNTFList = clsGlobal.getBooleanListFromString(objMainCoilQuality.sealTemperatureNTFValues);
                //objMainCoilQuality.appearance = DS.Tables[0].Rows[0]["mcqm_appearance"].ToString();
                //objMainCoilQuality.appearanceValues = DS.Tables[0].Rows[0]["mcqm_appearanceValues"].ToString();
                //objMainCoilQuality.appearanceList = clsGlobal.getStringListFromString(objMainCoilQuality.appearanceValues);
                //objMainCoilQuality.operatorCriterial = DS.Tables[0].Rows[0]["mcqm_operatorCriterial"].ToString();
                //objMainCoilQuality.fisicStatus = DS.Tables[0].Rows[0]["mcqm_fisicStatus"].ToString();
                //objMainCoilQuality.frictionCoefficientTFValues = DS.Tables[0].Rows[0]["mcqm_firctionCoefficientTFValues"].ToString();
                //objMainCoilQuality.frictionCoefficientTFList = clsGlobal.getDoubleListFromString(objMainCoilQuality.frictionCoefficientTFValues);
                //objMainCoilQuality.frictionCoefficientTFAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqm_frictionCoefficientTFAverage"]);
                //objMainCoilQuality.frictionCoefficientTFDinamicAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqm_frictionCoefficientTFDinamicAverage"]);
                //objMainCoilQuality.frictionCoefficientNTFValues = DS.Tables[0].Rows[0]["mcqm_frictionCoeficientNTFValues"].ToString();
                //objMainCoilQuality.frictionCoefficientNTFList = clsGlobal.getDoubleListFromString(objMainCoilQuality.frictionCoefficientNTFValues);
                //objMainCoilQuality.frictionCoefficientNTFAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqm_frictionCoefficientNTFAverage"]);
                //objMainCoilQuality.frictionCoefficientNTFDinamicAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqm_frictionCoefficientNTFDinamicAverage"]);
                //objMainCoilQuality.GlossValues = DS.Tables[0].Rows[0]["mcqm_GlossValues"].ToString();
                //objMainCoilQuality.GlossList = clsGlobal.getDoubleListFromString(objMainCoilQuality.GlossValues);
                //objMainCoilQuality.GlossAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqm_GlossAverage"]);
                //objMainCoilQuality.GlossDesviation = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqm_GlossDesviation"]);
                //objMainCoilQuality.sealStrengthValues = DS.Tables[0].Rows[0]["mcqm_sealStrengthValues"].ToString();
                //objMainCoilQuality.sealStrengthValuesTF = DS.Tables[0].Rows[0]["mcqm_sealStrengthValuesTF"].ToString();
                //objMainCoilQuality.sealStrengthList = clsGlobal.getDoubleListFromString(objMainCoilQuality.sealStrengthValues);
                //objMainCoilQuality.sealStrengthValuesTF = DS.Tables[0].Rows[0]["mcqm_sealStrengthValuesTF"].ToString();
                //objMainCoilQuality.sealStrengthValuesNTF = DS.Tables[0].Rows[0]["mcqm_sealStrengthValuesNTF"].ToString();
                //objMainCoilQuality.sealStrengthListTF = clsGlobal.getDoubleListFromString(objMainCoilQuality.sealStrengthValuesTF);
                //objMainCoilQuality.sealStrengthListNTF = clsGlobal.getDoubleListFromString(objMainCoilQuality.sealStrengthValuesNTF);
                
                //objMainCoilQuality.receptionDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mcqm_receptionDate"]);
                //objMainCoilQuality.tearMDAList = clsGlobal.getDoubleListFromString(objMainCoilQuality.tearMDValues);
                //objMainCoilQuality.tearTDAList = clsGlobal.getDoubleListFromString(objMainCoilQuality.tearTDValues);
                //objMainCoilQuality.dartImpactTFList = clsGlobal.getDoubleListFromString(objMainCoilQuality.dartImpactTFValues);
                //objMainCoilQuality.dartImpactNTFList = clsGlobal.getDoubleListFromString(objMainCoilQuality.dartImpactNTFValues);

                ////MetalFilm
                //objMainCoilQuality.metalFilmValues = DS.Tables[0].Rows[0]["mcqm_metalFilmValues"].ToString();
                //objMainCoilQuality.metalfilmValuesList = clsGlobal.getDoubleListFromString(objMainCoilQuality.metalFilmValues);
                //objMainCoilQuality.metalfilmAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqm_metalFilmAverage"]);
                //objMainCoilQuality.metalfilmAverageII = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqm_metalFilmAverage2"]);
                ////GlossII
                //objMainCoilQuality.GlossIIValues = DS.Tables[0].Rows[0]["mcqm_GlossIIValues"].ToString();
                //objMainCoilQuality.GlossIIList = clsGlobal.getDoubleListFromString(objMainCoilQuality.GlossIIValues);
                //objMainCoilQuality.GlossIIAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqm_GlossIIAverage"]);
                //objMainCoilQuality.GlossIIDesviation = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqm_GlossIIDesviation"]);
                //Streng
                //objMainCoilQuality.sealStrengthValuesDMTFNewton = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqm_sealStrengthValuesDMTFNewton"]);
                //objMainCoilQuality.sealStrengthValuesDTNTFNewton = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqm_sealStrengthValuesDTNTFNewton"]);
                //objMainCoilQuality.sealStrengthValuesDMTFNewtonII = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqm_sealStrengthValuesDMTFNewton2"]);
                //objMainCoilQuality.sealStrengthValuesDTNTFNewtonII = Convert.ToDouble(DS.Tables[0].Rows[0]["mcqm_sealStrengthValuesDTNTFNewton2"]);
            }
            return objMainCoilQuality;
        }

        private static int getLastSavedSalesOrderCodsec()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT mcqm_codsec FROM bps_prod_maincoilqualitymetal ORDER BY mcqm_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["mcqm_codsec"]);
        }

        public void loadByQuantity(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spQualityByMainCoil(" + codsec.ToString() + ");");

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mcqm_codsec"]);
            }
        }
    }
}
