using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra la Calidad de las Rollos Madres
    /// </summary>
    public class clsMainCoilQuality       
    {
        //Atributes
        private int mcq_codsec;
        private string mcq_thikness;
        private List<double> mcq_thiknessList;
        private double mcq_thiknessAverage;
        private double mcq_thiknessDesviation;
        private double mcq_gramaje;
        private bool mcq_opacityEvaluated;
        private bool mcq_transmittanceEvaluated;
        private string mcq_opacityTransmittanceValues;
        private List<double> mcq_opacityTransmittanceList;
        private string mcq_surfaceTensionValues;
        private List<double> mcq_surfaceTensionList;
        private string mcq_backSideValues;
        private List<bool> mcq_bakSideList;
        private double mcq_SealTemperatureTF;
        private string mcq_sealTemperatureTFValues;
        private List<bool> mcq_sealTemperatureTFList;
        private double mcq_sealTemperatureNTF;
        private string mcq_sealTemperatureNTFValues;
        private List<bool> mcq_sealTemperatureNTFList;
        private string mcq_appearance;
        private string mcq_appearanceValues;
        private List<string> mcq_appearanceList;
        private string mcq_operatorCriterial;
        private string mcq_fisicStatus;
        private string mcq_frictionCoefficientTFValues;
        private List<double> mcq_frictionCoefficientTFList;
        private double mcq_frictionCoefficientTFAverage;
        private double mcq_frictionCoefficientTFDinamicAverage;
        private string mcq_frictionCoefficientNTFValues;
        private List<double> mcq_frictionCoefficientNTFList;
        private double mcq_frictionCoefficientNTFAverage;
        private double mcq_frictionCoefficientNTFDinamicAverage;
        private string mcq_GlossValues;
        private List<double> mcq_GlossList;
        private double mcq_GlossAverage;
        private double mcq_GlossDesviation;

        private string mcq_sealStrengthValues;
        private List<double> mcq_sealStrengthList;


        private string mcq_sealStrengthValuesTF;
        private List<double> mcq_sealStrengthListTF;
        private List<double> mcq_sealStrengthListNTF;

        private string mcq_AnalistRating;
        private string mcq_labRating;
        private DateTime mcq_receptionDate;
        private DateTime mcq_createdDate;
        private int mcq_createdBy;
        private DateTime mcq_ModifiedDate;
        private int mcq_modifiedBy;
        private string mcq_creatorUser;
        private string mcq_modificatorUser;
        private List<clsMainCoil> mcq_lstMainCoil;
        private int mcq_opacityEvaluatedInt;
        private int mcq_transmittanceEvaluatedInt;
        private string mcq_treatmentValues;
        private string mcq_sealStrengthValuesNTF;

        private string mcq_statictTF;
        private string mcq_staticNTF;
        private double mcq_tearMDAverage;
        private List<double> mcq_tearMDAList;
        private List<double> mcq_tearTDAList;
        private List<double> mcq_dartImpactTFList;
        private List<double> mcq_dartImpactNTFList;

        private string mcq_tearMDValues;
        private double mcq_tearTDAverage;
        private string mcq_tearTDValues;
        private double mcq_dartImpactTFAverage;
        private string mcq_dartImpactTFValues;
        private double mcq_dartImpactNTFAverage;
        private string mcq_dartImpactNTFValues;



        private string mcq_metalFilmValues;
        private List<double> mcq_metalFilmValuesList;
        private double mcq_metalFilmAverage;
        private double mcq_metalFilmAverageII;
        private string mcq_GlossIIValues;
        private List<double> mcq_GlossIIList;
        private double mcq_GlossIIAverage;
        private double mcq_GlossIIDesviation;

        private double mcq_sealStrengthValuesDMTFNewton;
        private double mcq_sealStrengthValuesDTNTFNewton;
        private double mcq_sealStrengthValuesDMTFNewton2;
        private double mcq_sealStrengthValuesDTNTFNewton2;

        private string mcq_addValues;
        private List<double> mcq_addList;

        //Properties
        public string treatmentValues { get { return mcq_treatmentValues; } set { mcq_treatmentValues = value; } }

        public string statictTF { get { return mcq_statictTF; } set { mcq_statictTF = value; } }

        public string staticNTF { get { return mcq_staticNTF; } set { mcq_staticNTF = value; } }

        public double tearMDAverage { get { return mcq_tearMDAverage; } set { mcq_tearMDAverage = value; } }

        public string tearMDValues { get { return mcq_tearMDValues; } set { mcq_tearMDValues = value; } }

        public double tearTDAverage { get { return mcq_tearTDAverage; } set { mcq_tearTDAverage = value; } }

        public string tearTDValues { get { return mcq_tearTDValues; } set { mcq_tearTDValues = value; } }

        public List<double> tearMDAList { get { return mcq_tearMDAList; } set { mcq_tearMDAList = value; } }

        public List<double> tearTDAList { get { return mcq_tearTDAList; } set { mcq_tearTDAList = value; } }

        public List<double> dartImpactTFList { get { return mcq_dartImpactTFList; } set { mcq_dartImpactTFList = value; } }

        public List<double> dartImpactNTFList { get { return mcq_dartImpactNTFList; } set { mcq_dartImpactNTFList = value; } }



        public double dartImpactTFAverage { get { return mcq_dartImpactTFAverage; } set { mcq_dartImpactTFAverage = value; } }

        public string dartImpactTFValues { get { return mcq_dartImpactTFValues; } set { mcq_dartImpactTFValues = value; } }

        public double dartImpactNTFAverage { get { return mcq_dartImpactNTFAverage; } set { mcq_dartImpactNTFAverage = value; } }

        public string dartImpactNTFValues { get { return mcq_dartImpactNTFValues; } set { mcq_dartImpactNTFValues = value; } }


        public int codsec { get { return mcq_codsec; } set { mcq_codsec = value; } }

        public string thikness { get { return mcq_thikness; } set { mcq_thikness = value; } }

        public List<double> thiknessList { get { return mcq_thiknessList; } set { mcq_thiknessList = value; } }

        public double thiknessAverage { get { return mcq_thiknessAverage; } set { mcq_thiknessAverage = value; } }

        public double thiknessDesviation { get { return mcq_thiknessDesviation; } set { mcq_thiknessDesviation = value; } }

        public double gramaje { get { return mcq_gramaje; } set { mcq_gramaje = value; } }

        public bool opacityEvaluated { get { return mcq_opacityEvaluated; } set { mcq_opacityEvaluated = value; } }

        public bool transmittanceEvaluated { get { return mcq_transmittanceEvaluated; } set { mcq_transmittanceEvaluated = value; } }

        public string opacityTransmittanceValues { get { return mcq_opacityTransmittanceValues; } set { mcq_opacityTransmittanceValues = value; } }

        public List<double> opacityTransmittanceList { get { return mcq_opacityTransmittanceList; } set { mcq_opacityTransmittanceList = value; } }

        public string surfaceTensionValues { get { return mcq_surfaceTensionValues; } set { mcq_surfaceTensionValues = value; } }

        public List<double> surfaceTensionList { get { return mcq_surfaceTensionList; } set { mcq_surfaceTensionList = value; } }

        public string backSideValues { get { return mcq_backSideValues; } set { mcq_backSideValues = value; } }

        public List<bool> bakSideList { get { return mcq_bakSideList; } set { mcq_bakSideList = value; } }

        public double SealTemperatureTF { get { return mcq_SealTemperatureTF; } set { mcq_SealTemperatureTF = value; } }

        public string sealTemperatureTFValues { get { return mcq_sealTemperatureTFValues; } set { mcq_sealTemperatureTFValues = value; } }

        public List<bool> sealTemperatureTFList { get { return mcq_sealTemperatureTFList; } set { mcq_sealTemperatureTFList = value; } }
        //public List<double> sealTemperatureTFList { get { return mcq_sealTemperatureTFList; } set { mcq_sealTemperatureTFList = value; } }

        public double sealTemperatureNTF { get { return mcq_sealTemperatureNTF; } set { mcq_sealTemperatureNTF = value; } }

        public string sealTemperatureNTFValues { get { return mcq_sealTemperatureNTFValues; } set { mcq_sealTemperatureNTFValues = value; } }

        public List<bool> sealTemperatureNTFList { get { return mcq_sealTemperatureNTFList; } set { mcq_sealTemperatureNTFList = value; } }
        //public List<double> sealTemperatureNTFList { get { return mcq_sealTemperatureNTFList; } set { mcq_sealTemperatureNTFList = value; } }

        public string appearance { get { return mcq_appearance; } set { mcq_appearance = value; } }

        public string appearanceValues { get { return mcq_appearanceValues; } set { mcq_appearanceValues = value; } }

        public List<string> appearanceList { get { return mcq_appearanceList; } set { mcq_appearanceList = value; } }

        public string operatorCriterial { get { return mcq_operatorCriterial; } set { mcq_operatorCriterial = value; } }

        public string fisicStatus { get { return mcq_fisicStatus; } set { mcq_fisicStatus = value; } }

        public string frictionCoefficientTFValues { get { return mcq_frictionCoefficientTFValues; } set { mcq_frictionCoefficientTFValues = value; } }

        public List<double> frictionCoefficientTFList { get { return mcq_frictionCoefficientTFList; } set { mcq_frictionCoefficientTFList = value; } }

        public double frictionCoefficientTFAverage { get { return mcq_frictionCoefficientTFAverage; } set { mcq_frictionCoefficientTFAverage = value; } }

        public double frictionCoefficientTFDinamicAverage { get { return mcq_frictionCoefficientTFDinamicAverage; } set { mcq_frictionCoefficientTFDinamicAverage = value; } }

        public string frictionCoefficientNTFValues { get { return mcq_frictionCoefficientNTFValues; } set { mcq_frictionCoefficientNTFValues = value; } }

        public List<double> frictionCoefficientNTFList { get { return mcq_frictionCoefficientNTFList; } set { mcq_frictionCoefficientNTFList = value; } }

        public double frictionCoefficientNTFAverage { get { return mcq_frictionCoefficientNTFAverage; } set { mcq_frictionCoefficientNTFAverage = value; } }

        public double frictionCoefficientNTFDinamicAverage { get { return mcq_frictionCoefficientNTFDinamicAverage; } set { mcq_frictionCoefficientNTFDinamicAverage = value; } }

        public string GlossValues { get { return mcq_GlossValues; } set { mcq_GlossValues = value; } }

        public List<double> GlossList { get { return mcq_GlossList; } set { mcq_GlossList = value; } }

        public double GlossAverage { get { return mcq_GlossAverage; } set { mcq_GlossAverage = value; } }

        public double GlossDesviation { get { return mcq_GlossDesviation; } set { mcq_GlossDesviation = value; } }

        public string sealStrengthValuesTF { get { return mcq_sealStrengthValuesTF; } set { mcq_sealStrengthValuesTF = value; } }

        public string sealStrengthValues { get { return mcq_sealStrengthValues; } set { mcq_sealStrengthValues = value; } }
        public List<double> sealStrengthList { get { return mcq_sealStrengthList; } set { mcq_sealStrengthList = value; } }

        public List<double> sealStrengthListTF { get { return mcq_sealStrengthListTF; } set { mcq_sealStrengthListTF = value; } }
        public List<double> sealStrengthListNTF { get { return mcq_sealStrengthListNTF; } set { mcq_sealStrengthListNTF = value; } }

        public string AnalistRating { get { return mcq_AnalistRating; } set { mcq_AnalistRating = value; } }

        public string labRating { get { return mcq_labRating; } set { mcq_labRating = value; } }

        public DateTime receptionDate { get { return mcq_receptionDate; } set { mcq_receptionDate = value; } }

        public DateTime createdDate { get { return mcq_createdDate; } set { mcq_createdDate = value; } }

        public int createdBy { get { return mcq_createdBy; } set { mcq_createdBy = value; } }

        public DateTime ModifiedDate { get { return mcq_ModifiedDate; } set { mcq_ModifiedDate = value; } }

        public int modifiedBy { get { return mcq_modifiedBy; } set { mcq_modifiedBy = value; } }

        public string creatorUser { get { return mcq_creatorUser; } set { mcq_creatorUser = value; } }

        public string modificatorUser { get { return mcq_modificatorUser; } set { mcq_modificatorUser = value; } }

        public List<clsMainCoil> lstMainCoil { get { return mcq_lstMainCoil; } set { mcq_lstMainCoil = value; } }

        public int opacityEvaluatedInt { get { return mcq_opacityEvaluatedInt; } set { mcq_opacityEvaluatedInt = value; } }

        public int transmittanceEvaluatedInt { get { return mcq_transmittanceEvaluatedInt; } set { mcq_transmittanceEvaluatedInt = value; } }

        public string sealStrengthValuesNTF { get { return mcq_sealStrengthValuesNTF; } set { mcq_sealStrengthValuesNTF = value; } }



        public string metalFilmValues { get { return mcq_metalFilmValues; } set { mcq_metalFilmValues = value; } }

        public List<double> metalfilmValuesList { get { return mcq_metalFilmValuesList; } set { mcq_metalFilmValuesList = value; } }

        public double metalfilmAverage { get { return mcq_metalFilmAverage; } set { mcq_metalFilmAverage = value; } }

        public double metalfilmAverageII { get { return mcq_metalFilmAverageII; } set { mcq_metalFilmAverageII = value; } }

        public string GlossIIValues { get { return mcq_GlossIIValues; } set { mcq_GlossIIValues = value; } }

        public List<double> GlossIIList { get { return mcq_GlossIIList; } set { mcq_GlossIIList = value; } }

        public double GlossIIAverage { get { return mcq_GlossIIAverage; } set { mcq_GlossIIAverage = value; } }

        public double GlossIIDesviation { get { return mcq_GlossIIDesviation; } set { mcq_GlossIIDesviation = value; } }

        public double sealStrengthValuesDMTFNewton { get { return mcq_sealStrengthValuesDMTFNewton; } set { mcq_sealStrengthValuesDMTFNewton = value; } }

        public double sealStrengthValuesDTNTFNewton { get { return mcq_sealStrengthValuesDTNTFNewton; } set { mcq_sealStrengthValuesDTNTFNewton = value; } }

        public double sealStrengthValuesDMTFNewtonII { get { return mcq_sealStrengthValuesDMTFNewton2; } set { mcq_sealStrengthValuesDMTFNewton2 = value; } }

        public double sealStrengthValuesDTNTFNewtonII { get { return mcq_sealStrengthValuesDTNTFNewton2; } set { mcq_sealStrengthValuesDTNTFNewton2 = value; } }

        public string addValues { get { return mcq_addValues; } set { mcq_addValues = value; } }

        public List<double> addList { get { return mcq_addList; } set { mcq_addList = value; } }


        //Constructor

        public clsMainCoilQuality()
        {
            mcq_codsec = 0;
            mcq_thikness = "";
            mcq_thiknessList = new List<double>();
            mcq_thiknessAverage = 0;
            mcq_thiknessDesviation = 0;
            mcq_gramaje = 0;
            mcq_opacityEvaluated = false;
            mcq_transmittanceEvaluated = false;
            mcq_opacityTransmittanceValues = "";
            mcq_opacityTransmittanceList = new List<double>();
            mcq_surfaceTensionValues = "";
            mcq_surfaceTensionList = new List<double>();
            mcq_backSideValues = "";
            mcq_bakSideList = new List<bool>();
            mcq_SealTemperatureTF = 0;
            mcq_sealTemperatureTFValues = "";
            mcq_sealTemperatureTFList = new List<bool>();
            mcq_sealTemperatureNTF = 0;
            mcq_sealTemperatureNTFValues = "";
            mcq_sealTemperatureNTFList = new List<bool>();
            mcq_appearance = "";
            mcq_appearanceValues = "";
            mcq_appearanceList = new List<string>();
            mcq_operatorCriterial = "";
            mcq_fisicStatus = "";
            mcq_frictionCoefficientTFValues = "";
            mcq_frictionCoefficientTFList = new List<double>();
            mcq_frictionCoefficientTFAverage = 0;
            mcq_frictionCoefficientTFDinamicAverage = 0;
            mcq_frictionCoefficientNTFValues = "";
            mcq_frictionCoefficientNTFList = new List<double>();
            mcq_frictionCoefficientNTFAverage = 0;
            mcq_frictionCoefficientNTFDinamicAverage = 0;
            mcq_GlossValues = "";
            mcq_GlossList = new List<double>();
            mcq_GlossAverage = 0;
            mcq_GlossDesviation = 0;
            mcq_sealStrengthValues = "";
            mcq_sealStrengthList = new List<double>();
            mcq_sealStrengthValuesTF = "";
            mcq_sealStrengthListTF = new List<double>();
            mcq_sealStrengthValuesNTF = "";
            mcq_sealStrengthListNTF = new List<double>();

            mcq_AnalistRating = "";
            mcq_labRating = "";
            mcq_receptionDate = DateTime.Now;
            mcq_createdDate = DateTime.Now;
            mcq_createdBy = 1;
            mcq_ModifiedDate = DateTime.Now;
            mcq_modifiedBy = 1;
            mcq_creatorUser = "";
            mcq_modificatorUser = "";
            mcq_lstMainCoil = new List<clsMainCoil>();
            mcq_opacityEvaluatedInt = 0;
            mcq_transmittanceEvaluatedInt = 0;
            mcq_tearMDAList = new List<double>();
            mcq_tearTDAList = new List<double>();
            mcq_dartImpactTFList = new List<double>();
            mcq_dartImpactNTFList = new List<double>();

            mcq_statictTF = "";
            mcq_staticNTF = "";
            mcq_tearMDAverage = 0;
            mcq_tearMDValues = "";
            mcq_tearTDAverage = 0;
            mcq_tearTDValues = "";

            mcq_dartImpactTFAverage = 0;
            mcq_dartImpactTFValues = "";
            mcq_dartImpactNTFAverage = 0;
            mcq_dartImpactNTFValues = "";
            mcq_sealStrengthValuesNTF = "";


            mcq_metalFilmValues = string.Empty;
            mcq_metalFilmValuesList = new List<double>();
            mcq_metalFilmAverage = 0;
            mcq_metalFilmAverageII = 0;
            mcq_GlossIIValues = string.Empty;
            mcq_GlossIIList = new List<double>();
            mcq_GlossIIAverage = 0;
            mcq_GlossIIDesviation = 0;

            mcq_sealStrengthValuesDMTFNewton = 0;
            mcq_sealStrengthValuesDTNTFNewton = 0;
            mcq_sealStrengthValuesDMTFNewton2 = 0;
            mcq_sealStrengthValuesDTNTFNewton2 = 0;

            mcq_addList = new List<double>();
            mcq_addValues = "";
        }
        public clsMainCoilQuality(int codsec)
        {
            this.load(codsec);
        }

        //Methods
        public void load(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwmaincoilquality where mcq_codsec =  " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mcq_codsec"]);
                this.thikness = DS.Tables[0].Rows[0]["mcq_thikness"].ToString();
                this.thiknessList = clsGlobal.getDoubleListFromString(this.thikness);
                this.thiknessAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcq_thiknessAverage"]);
                this.thiknessDesviation = Convert.ToDouble(DS.Tables[0].Rows[0]["mcq_thiknessDesviation"]);
                this.gramaje = Convert.ToDouble(DS.Tables[0].Rows[0]["mcq_gramaje"]);
                this.opacityEvaluated = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["mcq_opacityEvaluated"], DS.Tables[0].Rows[0]["mcq_opacityEvaluated"].GetType().FullName);
                this.transmittanceEvaluated = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["mcq_transmittanceEvaluated"], DS.Tables[0].Rows[0]["mcq_transmittanceEvaluated"].GetType().FullName);
                this.opacityTransmittanceValues = DS.Tables[0].Rows[0]["mcq_opacityTransmittanceValues"].ToString();
                this.opacityTransmittanceList = clsGlobal.getDoubleListFromString(this.opacityTransmittanceValues);
                this.surfaceTensionValues = DS.Tables[0].Rows[0]["mcq_surfaceTensionValues"].ToString();
                this.surfaceTensionList = clsGlobal.getDoubleListFromString(this.surfaceTensionValues);
                this.backSideValues = DS.Tables[0].Rows[0]["mcq_backSideValues"].ToString();
                this.bakSideList = clsGlobal.getBooleanListFromString(this.backSideValues);
                this.SealTemperatureTF = Convert.ToDouble(DS.Tables[0].Rows[0]["mcq_SealTemperatureTF"]);
                this.sealTemperatureTFValues = DS.Tables[0].Rows[0]["mcq_sealTemperatureTFValues"].ToString();
                this.sealTemperatureTFList = clsGlobal.getBooleanListFromString(this.sealTemperatureTFValues);
                this.sealTemperatureNTF = Convert.ToDouble(DS.Tables[0].Rows[0]["mcq_sealTemperatureNTF"]);
                this.sealTemperatureNTFValues = DS.Tables[0].Rows[0]["mcq_sealTemperatureNTFValues"].ToString();
                this.sealTemperatureNTFList = clsGlobal.getBooleanListFromString(this.sealTemperatureNTFValues);
                this.appearance = DS.Tables[0].Rows[0]["mcq_appearance"].ToString();
                this.appearanceValues = DS.Tables[0].Rows[0]["mcq_appearanceValues"].ToString();
                this.appearanceList = clsGlobal.getStringListFromString(this.appearanceValues);
                this.operatorCriterial = DS.Tables[0].Rows[0]["mcq_operatorCriterial"].ToString();
                this.fisicStatus = DS.Tables[0].Rows[0]["mcq_fisicStatus"].ToString();
                this.frictionCoefficientTFValues = DS.Tables[0].Rows[0]["mcq_firctionCoefficientTFValues"].ToString();
                this.frictionCoefficientTFList = clsGlobal.getDoubleListFromString(this.frictionCoefficientTFValues);
                this.frictionCoefficientTFAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcq_frictionCoefficientTFAverage"]);
                this.frictionCoefficientTFDinamicAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcq_frictionCoefficientTFDinamicAverage"]);
                this.frictionCoefficientNTFValues = DS.Tables[0].Rows[0]["mcq_frictionCoeficientNTFValues"].ToString();
                this.frictionCoefficientNTFList = clsGlobal.getDoubleListFromString(this.frictionCoefficientNTFValues);
                this.frictionCoefficientNTFAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcq_frictionCoefficientNTFAverage"]);
                this.frictionCoefficientNTFDinamicAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcq_frictionCoefficientNTFDinamicAverage"]);
                this.GlossValues = DS.Tables[0].Rows[0]["mcq_GlossValues"].ToString();
                this.GlossList = clsGlobal.getDoubleListFromString(this.GlossValues);
                this.GlossAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcq_GlossAverage"]);
                this.GlossDesviation = Convert.ToDouble(DS.Tables[0].Rows[0]["mcq_GlossDesviation"]);
                this.sealStrengthValues = DS.Tables[0].Rows[0]["mcq_sealStrengthValues"].ToString();
                this.sealStrengthValuesTF = DS.Tables[0].Rows[0]["mcq_sealStrengthValuesTF"].ToString();
                this.sealStrengthList = clsGlobal.getDoubleListFromString(this.sealStrengthValues);
                this.sealStrengthListTF = clsGlobal.getDoubleListFromString(this.sealStrengthValuesTF);
                this.sealStrengthListNTF = clsGlobal.getDoubleListFromString(this.sealStrengthValuesNTF);
                this.AnalistRating = DS.Tables[0].Rows[0]["mcq_"].ToString();
                this.labRating = DS.Tables[0].Rows[0]["mcq_"].ToString();
                this.receptionDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mcq_receptionDate"]);
                this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mcq_createdDate"]);
                this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mcq_createdBy"]);
                this.ModifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mcq_ModifiedDate"]);
                this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mcq_modifiedBy"]);
                this.creatorUser = DS.Tables[0].Rows[0]["mcq_creatorUser"].ToString();
                this.modificatorUser = DS.Tables[0].Rows[0]["mcq_modificatorUser"].ToString();
                this.lstMainCoil = clsMainCoil.getBoppMainCoilListByQualityReport(this.codsec);

                this.statictTF = DS.Tables[0].Rows[0]["mcq_statictTF"].ToString();
                this.staticNTF = DS.Tables[0].Rows[0]["mcq_statictNTF"].ToString();
                this.tearMDAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcq_tearMDAverage"]);
                this.tearMDValues = DS.Tables[0].Rows[0]["mcq_tearMDValues"].ToString();
                this.tearMDAList = clsGlobal.getDoubleListFromString(this.tearMDValues);
                this.tearTDAList = clsGlobal.getDoubleListFromString(this.dartImpactTFValues);
                this.dartImpactTFList = clsGlobal.getDoubleListFromString(this.tearTDValues);

                this.tearTDAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcq_tearTDAverage"]);
                this.tearTDValues = DS.Tables[0].Rows[0]["mcq_tearTDValues"].ToString();
                this.dartImpactTFAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcq_dartImpactTFAverage"]);
                this.dartImpactTFValues = DS.Tables[0].Rows[0]["mcq_dartImpactTFValues"].ToString();
                this.dartImpactNTFAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcq_dartImpactNTFAverage"]);
                this.dartImpactNTFValues = DS.Tables[0].Rows[0]["mcq_dartImpactNTFValues"].ToString();
                this.sealStrengthValuesNTF = DS.Tables[0].Rows[0]["mcq_sealStrengthValuesNTF"].ToString();

            }
        }

        public bool save()
        {
            string queryString = "";    
            try
            {
                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_maincoilquality(mcq_thikness, mcq_thiknessAverage, mcq_thiknessDesviation, mcq_opacityEvaluated, " +
                    "mcq_transmittanceEvaluated, mcq_opacityTrasmittanceValues, mcq_surfaceTensionValues, mcq_backSideValues, mcq_SealTemperatureTF, mcq_sealTemperatureTFValues, " +
                    "mcq_sealTemperatureNTF, mcq_sealTemperatureNTFValues, mcq_appearance, mcq_appearanceValues, mcq_operatorCriterial, mcq_fisicStatus, mcq_firctionCoefficientTFValues, " +
                    "mcq_frictionCoefficientTFAverage, mcq_frictionCoeficientNTFValues, mcq_frictionCoefficientNTFAverage, mcq_GlossValues, mcq_GlossAverage, mcq_GlossDesviation, " +
                    "mcq_sealStrengthValues,mcq_sealStrengthValuesTF,mcq_sealStrengthValuesNTF, mcq_receptionDate, mcq_createdDate, mcq_createdBy, mcq_ModifiedDate, mcq_modifiedBy, " +
                    "mcq_treatmentValues, mcq_statictTF, mcq_staticNTF, mcq_tearMDAverage, mcq_tearMDValues, mcq_tearTDAverage, mcq_tearTDValues, mcq_dartImpactTFAverage, " +
                    "mcq_dartImpactTFValues, mcq_dartImpactNTFAverage, mcq_dartImpactNTFValues, mcq_frictionCoefficientTFDinamicAverage, mcq_frictionCoefficientNTFDinamicAverage, " +
                    "mcq_metalFilmValues, mcq_metalFilmAverage, mcq_metalFilmAverage2, mcq_GlossIIValues, mcq_GlossIIAverage, mcq_GlossIIDesviation, mcq_sealStrengthValuesDMTFNewton, mcq_sealStrengthValuesDTNTFNewton, mcq_sealStrengthValuesDMTFNewton2, mcq_sealStrengthValuesDTNTFNewton2, mcq_addValues) ";
                    queryString += " VALUES (";
                    queryString += "'" + this.thikness.ToString() + "',";
                    queryString += "" + this.thiknessAverage.ToString() + ",";
                    queryString += "" + this.thiknessDesviation.ToString() + ",";
                    queryString += "'" + this.opacityEvaluatedInt.ToString() + "',";
                    queryString += "'" + this.transmittanceEvaluatedInt.ToString() + "',";
                    queryString += "'" + this.opacityTransmittanceValues.ToString() + "',";
                    queryString += "'" + this.surfaceTensionValues.ToString() + "',";
                    queryString += "'" + this.backSideValues.ToString() + "',";
                    queryString += "" + this.SealTemperatureTF.ToString() + ",";
                    queryString += "'" + this.sealTemperatureTFValues.ToString() + "',";
                    queryString += "" + this.sealTemperatureNTF.ToString() + ",";
                    queryString += "'" + this.sealTemperatureNTFValues.ToString() + "',";
                    queryString += "'" + this.appearance.ToString() + "',";
                    queryString += "'" + this.appearanceValues.ToString() + "',";
                    queryString += "'" + this.operatorCriterial.ToString() + "',";
                    queryString += "'" + this.fisicStatus.ToString() + "',";
                    queryString += "'" + this.frictionCoefficientTFValues.ToString() + "',";
                    queryString += "" + this.frictionCoefficientTFAverage.ToString() + ",";
                    queryString += "'" + this.frictionCoefficientNTFValues.ToString() + "',";
                    queryString += "" + this.frictionCoefficientNTFAverage.ToString() + ",";
                    queryString += "'" + this.GlossValues.ToString() + "',";
                    queryString += "" + this.GlossAverage.ToString() + ",";
                    queryString += "" + this.GlossDesviation.ToString() + ",";
                    queryString += "'" + this.sealStrengthValues.ToString() + "',";
                    queryString += "'" + this.sealStrengthValuesTF.ToString() + "',";
                    queryString += "'" + this.sealStrengthValuesNTF.ToString() + "',";
                    queryString += "'" + this.receptionDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += "'" + this.createdDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += "" + this.createdBy.ToString() + ",";
                    queryString += "'" + this.ModifiedDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += "" + this.modifiedBy.ToString() + ",";
                    queryString += "'" + this.treatmentValues.ToString() + "',";
                    queryString += "'" + this.statictTF.ToString() + "',";
                    queryString += "'" + this.staticNTF.ToString() + "',";
                    queryString += "" + this.tearMDAverage.ToString() + ",";
                    queryString += "'" + this.tearMDValues.ToString() + "',";
                    queryString += "" + this.tearTDAverage.ToString() + ",";

                    queryString += "'" + this.tearTDValues.ToString() + "',";
                    queryString += "" + this.dartImpactTFAverage.ToString() + ",";
                    queryString += "'" + this.dartImpactTFValues.ToString() + "',";
                    queryString += "" + this.dartImpactNTFAverage.ToString() + ",";
                    queryString += "'" + this.dartImpactNTFValues.ToString() + "',";
                    queryString += "" + this.frictionCoefficientTFDinamicAverage.ToString() + ",";
                    queryString += "" + this.frictionCoefficientNTFDinamicAverage.ToString() + ",";

                    queryString += "'" + this.metalFilmValues.ToString() + "',";
                    queryString += "" + this.metalfilmAverage.ToString() + ",";
                    queryString += "" + this.metalfilmAverageII.ToString() + ",";
                    queryString += "'" + this.GlossIIValues.ToString() + "',";
                    queryString += "" + this.GlossIIAverage.ToString() + ",";
                    queryString += "'" + this.GlossIIDesviation.ToString() + "',";
                    queryString += "" + this.sealStrengthValuesDMTFNewton.ToString() + ",";
                    queryString += "" + this.sealStrengthValuesDTNTFNewton.ToString() + ",";
                    queryString += "" + this.sealStrengthValuesDMTFNewtonII.ToString() + ",";
                    queryString += "" + this.sealStrengthValuesDTNTFNewtonII.ToString() + ",";
                    queryString += "'" + this.addValues.ToString() + "')";

                }
                else
                {
                    queryString += "UPDATE bps_prod_maincoilquality ";
                    queryString += " SET ";
                    queryString += "mcq_thikness ='" + this.thikness.ToString() + "',";
                    queryString += "mcq_thiknessAverage = " + this.thiknessAverage.ToString() + ",";
                    queryString += "mcq_thiknessDesviation = " + this.thiknessDesviation.ToString() + ",";
                    queryString += "mcq_opacityEvaluated ='" + this.opacityEvaluatedInt.ToString() + "',";
                    queryString += "mcq_transmittanceEvaluated ='" + this.transmittanceEvaluatedInt.ToString() + "',";
                    queryString += "mcq_opacityTrasmittanceValues ='" + this.opacityTransmittanceValues.ToString() + "',";
                    queryString += "mcq_surfaceTensionValues ='" + this.surfaceTensionValues.ToString() + "',";
                    queryString += "mcq_backSideValues ='" + this.backSideValues.ToString() + "',";
                    queryString += "mcq_SealTemperatureTF = " + this.SealTemperatureTF.ToString() + ",";
                    queryString += "mcq_sealTemperatureTFValues ='" + this.sealTemperatureTFValues.ToString() + "',";
                    queryString += "mcq_sealTemperatureNTF = " + this.sealTemperatureNTF.ToString() + ",";
                    queryString += "mcq_sealTemperatureNTFValues ='" + this.sealTemperatureNTFValues.ToString() + "',";
                    queryString += "mcq_appearance ='" + this.appearance.ToString() + "',";
                    queryString += "mcq_appearanceValues ='" + this.appearanceValues.ToString() + "',";
                    queryString += "mcq_operatorCriterial ='" + this.operatorCriterial.ToString() + "',";
                    queryString += "mcq_fisicStatus ='" + this.fisicStatus.ToString() + "',";
                    queryString += "mcq_firctionCoefficientTFValues ='" + this.frictionCoefficientTFValues.ToString() + "',";
                    queryString += "mcq_frictionCoefficientTFAverage = " + this.frictionCoefficientTFAverage.ToString() + ",";
                    queryString += "mcq_frictionCoefficientTFDinamicAverage = " + this.frictionCoefficientTFDinamicAverage.ToString() + ",";
                    queryString += "mcq_frictionCoeficientNTFValues ='" + this.frictionCoefficientNTFValues.ToString() + "',";
                    queryString += "mcq_frictionCoefficientNTFAverage = " + this.frictionCoefficientNTFAverage.ToString() + ",";
                    queryString += "mcq_frictionCoefficientNTFDinamicAverage = " + this.frictionCoefficientNTFDinamicAverage.ToString() + ",";
                    queryString += "mcq_GlossValues ='" + this.GlossValues.ToString() + "',";
                    queryString += "mcq_GlossAverage = " + this.GlossAverage.ToString() + ",";
                    queryString += "mcq_GlossDesviation = " + this.GlossDesviation.ToString() + ",";
                    queryString += "mcq_sealStrengthValues ='" + this.sealStrengthValues.ToString() + "',";
                    queryString += "mcq_sealStrengthValuesTF ='" + this.sealStrengthValuesTF.ToString() + "',";
                    queryString += "mcq_sealStrengthValuesNTF ='" + this.sealStrengthValuesNTF.ToString() + "',";
                    queryString += "mcq_receptionDate ='" + this.receptionDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += "mcq_createdDate ='" + this.createdDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += "mcq_createdBy = " + this.createdBy.ToString() + ",";
                    queryString += "mcq_ModifiedDate ='" + this.ModifiedDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += "mcq_modifiedBy = " + this.modifiedBy.ToString() + ",";

                    queryString += "mcq_statictTF ='" + this.statictTF.ToString() + "',";
                    queryString += "mcq_staticNTF ='" + this.staticNTF.ToString() + "',";
                    queryString += "mcq_tearMDAverage =" + this.tearMDAverage.ToString() + ",";
                    queryString += "mcq_tearMDValues ='" + this.tearMDValues.ToString() + "',";
                    queryString += "mcq_tearTDAverage =" + this.tearTDAverage.ToString() + ",";
                    queryString += "mcq_tearTDValues ='" + this.tearTDValues.ToString() + "',";
                    queryString += "mcq_dartImpactTFAverage =" + this.dartImpactTFAverage.ToString() + ",";
                    queryString += "mcq_dartImpactTFValues ='" + this.dartImpactTFValues.ToString() + "',";
                    queryString += "mcq_dartImpactNTFAverage =" + this.dartImpactNTFAverage.ToString() + ",";
                    queryString += "mcq_dartImpactNTFValues ='" + this.dartImpactNTFValues.ToString() + "',";

                    queryString += "mcq_metalFilmValues ='" + this.metalFilmValues.ToString() + "',";
                    queryString += "mcq_metalFilmAverage =" + this.metalfilmAverage.ToString() + ",";
                    queryString += "mcq_metalFilmAverage2 =" + this.metalfilmAverageII.ToString() + ",";
                    queryString += "mcq_GlossIIValues ='" + this.GlossIIValues.ToString() + "',";
                    queryString += "mcq_GlossIIAverage =" + this.GlossIIAverage.ToString() + ",";
                    queryString += "mcq_GlossIIDesviation ='" + this.GlossIIDesviation.ToString() + "',";
                    queryString += "mcq_sealStrengthValuesDMTFNewton =" + this.sealStrengthValuesDMTFNewton.ToString() + ",";
                    queryString += "mcq_sealStrengthValuesDTNTFNewton =" + this.sealStrengthValuesDTNTFNewton.ToString() + ",";
                    queryString += "mcq_sealStrengthValuesDMTFNewton2 =" + this.sealStrengthValuesDMTFNewtonII.ToString() + ",";
                    queryString += "mcq_sealStrengthValuesDTNTFNewton2 =" + this.sealStrengthValuesDTNTFNewtonII.ToString() + ",";
                    queryString += "mcq_addValues ='" + this.addValues.ToString() + "'";
                    queryString += " WHERE mcq_codsec = " + this.codsec.ToString() + "";

                }
                if (clsConnection.executeQuery(queryString))
                {
                    if (this.codsec == 0)
                    {
                        this.codsec = clsMainCoilQuality.getLastSavedSalesOrderCodsec();

                        for (int i = 0; i < lstMainCoil.Count; i++)
                        {
                            queryString = "INSERT INTO bps_prod_maincoilsByQuality (mcbq_fkMainCoil, mcbq_fkMainCoilQuality)";
                            queryString += " VALUES (";
                            queryString += "" + lstMainCoil[i].codsec.ToString() + ",";
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

        public static clsMainCoilQuality getQualityByMainCoil(int mainCoilCodsec)
        {
            clsMainCoilQuality objMainCoilQuality = new clsMainCoilQuality();

            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spQualityByMainCoil(" + mainCoilCodsec.ToString() + ");");

            if (DS.Tables[0].Rows.Count > 0)
            {
                objMainCoilQuality.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mcq_codsec"]);
                objMainCoilQuality.thikness = DS.Tables[0].Rows[0]["mcq_thikness"].ToString();
                objMainCoilQuality.thiknessList = clsGlobal.getDoubleListFromString(objMainCoilQuality.thikness);
                objMainCoilQuality.thiknessAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcq_thiknessAverage"]);
                objMainCoilQuality.thiknessDesviation = Convert.ToDouble(DS.Tables[0].Rows[0]["mcq_thiknessDesviation"]);
                objMainCoilQuality.gramaje = Convert.ToDouble(DS.Tables[0].Rows[0]["mcq_gramaje"]);
                objMainCoilQuality.opacityEvaluated = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["mcq_opacityEvaluated"], DS.Tables[0].Rows[0]["mcq_opacityEvaluated"].GetType().FullName);
                objMainCoilQuality.transmittanceEvaluated = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["mcq_transmittanceEvaluated"], DS.Tables[0].Rows[0]["mcq_transmittanceEvaluated"].GetType().FullName);
                objMainCoilQuality.opacityTransmittanceValues = DS.Tables[0].Rows[0]["mcq_opacityTrasmittanceValues"].ToString();
                objMainCoilQuality.opacityTransmittanceList = clsGlobal.getDoubleListFromString(objMainCoilQuality.opacityTransmittanceValues);
                objMainCoilQuality.surfaceTensionValues = DS.Tables[0].Rows[0]["mcq_surfaceTensionValues"].ToString();
                objMainCoilQuality.surfaceTensionList = clsGlobal.getDoubleListFromString(objMainCoilQuality.surfaceTensionValues);
                objMainCoilQuality.backSideValues = DS.Tables[0].Rows[0]["mcq_backSideValues"].ToString();
                objMainCoilQuality.bakSideList = clsGlobal.getBooleanListFromString(objMainCoilQuality.backSideValues);
                objMainCoilQuality.SealTemperatureTF = Convert.ToDouble(DS.Tables[0].Rows[0]["mcq_SealTemperatureTF"]);
                objMainCoilQuality.sealTemperatureTFValues = DS.Tables[0].Rows[0]["mcq_sealTemperatureTFValues"].ToString();
                objMainCoilQuality.sealTemperatureTFList = clsGlobal.getBooleanListFromString(objMainCoilQuality.sealTemperatureTFValues);
                objMainCoilQuality.sealTemperatureNTF = Convert.ToDouble(DS.Tables[0].Rows[0]["mcq_sealTemperatureNTF"]);
                objMainCoilQuality.sealTemperatureNTFValues = DS.Tables[0].Rows[0]["mcq_sealTemperatureNTFValues"].ToString();
                objMainCoilQuality.sealTemperatureNTFList = clsGlobal.getBooleanListFromString(objMainCoilQuality.sealTemperatureNTFValues);
                objMainCoilQuality.appearance = DS.Tables[0].Rows[0]["mcq_appearance"].ToString();
                objMainCoilQuality.appearanceValues = DS.Tables[0].Rows[0]["mcq_appearanceValues"].ToString();
                objMainCoilQuality.appearanceList = clsGlobal.getStringListFromString(objMainCoilQuality.appearanceValues);
                objMainCoilQuality.operatorCriterial = DS.Tables[0].Rows[0]["mcq_operatorCriterial"].ToString();
                objMainCoilQuality.fisicStatus = DS.Tables[0].Rows[0]["mcq_fisicStatus"].ToString();
                objMainCoilQuality.frictionCoefficientTFValues = DS.Tables[0].Rows[0]["mcq_firctionCoefficientTFValues"].ToString();
                objMainCoilQuality.frictionCoefficientTFList = clsGlobal.getDoubleListFromString(objMainCoilQuality.frictionCoefficientTFValues);
                objMainCoilQuality.frictionCoefficientTFAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcq_frictionCoefficientTFAverage"]);
                objMainCoilQuality.frictionCoefficientTFDinamicAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcq_frictionCoefficientTFDinamicAverage"]);
                objMainCoilQuality.frictionCoefficientNTFValues = DS.Tables[0].Rows[0]["mcq_frictionCoeficientNTFValues"].ToString();
                objMainCoilQuality.frictionCoefficientNTFList = clsGlobal.getDoubleListFromString(objMainCoilQuality.frictionCoefficientNTFValues);
                objMainCoilQuality.frictionCoefficientNTFAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcq_frictionCoefficientNTFAverage"]);
                objMainCoilQuality.frictionCoefficientNTFDinamicAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcq_frictionCoefficientNTFDinamicAverage"]);
                objMainCoilQuality.GlossValues = DS.Tables[0].Rows[0]["mcq_GlossValues"].ToString();
                objMainCoilQuality.GlossList = clsGlobal.getDoubleListFromString(objMainCoilQuality.GlossValues);
                objMainCoilQuality.GlossAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcq_GlossAverage"]);
                objMainCoilQuality.GlossDesviation = Convert.ToDouble(DS.Tables[0].Rows[0]["mcq_GlossDesviation"]);
                objMainCoilQuality.sealStrengthValues = DS.Tables[0].Rows[0]["mcq_sealStrengthValues"].ToString();
                objMainCoilQuality.sealStrengthValuesTF = DS.Tables[0].Rows[0]["mcq_sealStrengthValuesTF"].ToString();
                objMainCoilQuality.sealStrengthList = clsGlobal.getDoubleListFromString(objMainCoilQuality.sealStrengthValues);
                objMainCoilQuality.sealStrengthValuesTF = DS.Tables[0].Rows[0]["mcq_sealStrengthValuesTF"].ToString();
                objMainCoilQuality.sealStrengthValuesNTF = DS.Tables[0].Rows[0]["mcq_sealStrengthValuesNTF"].ToString();
                objMainCoilQuality.sealStrengthListTF = clsGlobal.getDoubleListFromString(objMainCoilQuality.sealStrengthValuesTF);
                objMainCoilQuality.sealStrengthListNTF = clsGlobal.getDoubleListFromString(objMainCoilQuality.sealStrengthValuesNTF);
                objMainCoilQuality.AnalistRating = DS.Tables[0].Rows[0]["mcq_AnalistRating"].ToString();
                objMainCoilQuality.labRating = DS.Tables[0].Rows[0]["mcq_labRating"].ToString();
                objMainCoilQuality.receptionDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mcq_receptionDate"]);
                objMainCoilQuality.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mcq_createdDate"]);
                objMainCoilQuality.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mcq_createdBy"]);
                objMainCoilQuality.ModifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mcq_ModifiedDate"]);
                objMainCoilQuality.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mcq_modifiedBy"]);
                objMainCoilQuality.creatorUser = DS.Tables[0].Rows[0]["mcq_creatorUser"].ToString();
                objMainCoilQuality.modificatorUser = DS.Tables[0].Rows[0]["mcq_modificatorUser"].ToString();
                objMainCoilQuality.lstMainCoil = clsMainCoil.getBoppMainCoilListByQualityReport(objMainCoilQuality.codsec);
                objMainCoilQuality.tearMDAList = clsGlobal.getDoubleListFromString(objMainCoilQuality.tearMDValues);
                objMainCoilQuality.tearTDAList = clsGlobal.getDoubleListFromString(objMainCoilQuality.tearTDValues);
                objMainCoilQuality.dartImpactTFList = clsGlobal.getDoubleListFromString(objMainCoilQuality.dartImpactTFValues);
                objMainCoilQuality.dartImpactNTFList = clsGlobal.getDoubleListFromString(objMainCoilQuality.dartImpactNTFValues);

                //MetalFilm
                objMainCoilQuality.metalFilmValues = DS.Tables[0].Rows[0]["mcq_metalFilmValues"].ToString();
                objMainCoilQuality.metalfilmValuesList = clsGlobal.getDoubleListFromString(objMainCoilQuality.metalFilmValues);
                objMainCoilQuality.metalfilmAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcq_metalFilmAverage"]);
                objMainCoilQuality.metalfilmAverageII = Convert.ToDouble(DS.Tables[0].Rows[0]["mcq_metalFilmAverage2"]);
                //GlossII
                objMainCoilQuality.GlossIIValues = DS.Tables[0].Rows[0]["mcq_GlossIIValues"].ToString();
                objMainCoilQuality.GlossIIList = clsGlobal.getDoubleListFromString(objMainCoilQuality.GlossIIValues);
                objMainCoilQuality.GlossIIAverage = Convert.ToDouble(DS.Tables[0].Rows[0]["mcq_GlossIIAverage"]);
                objMainCoilQuality.GlossIIDesviation = Convert.ToDouble(DS.Tables[0].Rows[0]["mcq_GlossIIDesviation"]);

                objMainCoilQuality.addValues = DS.Tables[0].Rows[0]["mcq_addValues"].ToString();
                objMainCoilQuality.addList = clsGlobal.getDoubleListFromString(objMainCoilQuality.addValues);

                //Streng
                //objMainCoilQuality.sealStrengthValuesDMTFNewton = Convert.ToDouble(DS.Tables[0].Rows[0]["mcq_sealStrengthValuesDMTFNewton"]);
                //objMainCoilQuality.sealStrengthValuesDTNTFNewton = Convert.ToDouble(DS.Tables[0].Rows[0]["mcq_sealStrengthValuesDTNTFNewton"]);
                //objMainCoilQuality.sealStrengthValuesDMTFNewtonII = Convert.ToDouble(DS.Tables[0].Rows[0]["mcq_sealStrengthValuesDMTFNewton2"]);
                //objMainCoilQuality.sealStrengthValuesDTNTFNewtonII = Convert.ToDouble(DS.Tables[0].Rows[0]["mcq_sealStrengthValuesDTNTFNewton2"]);
            }
            return objMainCoilQuality;
        }
        private static int getLastSavedSalesOrderCodsec()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT mcq_codsec FROM bps_prod_maincoilquality Order By mcq_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["mcq_codsec"]);
        }

        public void loadByQuantity(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spQualityByMainCoil(" + codsec.ToString() + ");");

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mcq_codsec"]);
            }
        }
    }
}
