using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BPS.Bussiness
{
    public class clsRecordProductionThickness
    {
        //Atributes
        private int recprothi_codsec;
        private int recprothi_fkRecordProduction;
        private int recprothi_fkProductionOrder;
        private double recprothi_CRMDO;
        private double recprothi_MDO2TDO;
        private double recprothi_TDOPRS;
        private double recprothi_Stretch;
        private double recprothi_Coefficient;
        private double recprothi_TolerancyPositive;
        private double recprothi_TolerancyNegative;

        private DateTime recprothi_date;
        private string recprothi_notes;

        //Properties
        public int recprothicodsec { get { return recprothi_codsec; } set { recprothi_codsec = value; } }

        public int recprothifkrecordproduction { get { return recprothi_fkRecordProduction; } set { recprothi_fkRecordProduction = value; } }

        public int recprothifkproductionorder { get { return recprothi_fkProductionOrder; } set { recprothi_fkProductionOrder = value; } }

        public double crmdo { get { return recprothi_CRMDO; } set { recprothi_CRMDO = value; } }

        public double mdo2tdo { get { return recprothi_MDO2TDO; } set { recprothi_MDO2TDO = value; } }

        public double tdoprs { get { return recprothi_TDOPRS; } set { recprothi_TDOPRS = value; } }

        public double stretch { get { return recprothi_Stretch; } set { recprothi_Stretch = value; } }

        public double coefficientthickness { get { return recprothi_Coefficient; } set { recprothi_Coefficient = value; } }

        public double tolerancypositive { get { return recprothi_TolerancyPositive; } set { recprothi_TolerancyPositive = value; } }

        public double tolerancynegative { get { return recprothi_TolerancyNegative; } set { recprothi_TolerancyNegative = value; } }

        public DateTime date { get { return recprothi_date; } set { recprothi_date = value; } }

        public string notes { get { return recprothi_notes; } set { recprothi_notes = value; } }

        //Constructor
        public clsRecordProductionThickness()
        {
            recprothi_codsec = 0;
            recprothi_fkRecordProduction = 0;
            recprothi_fkProductionOrder = 0;
            recprothi_CRMDO = 0;
            recprothi_MDO2TDO = 0;
            recprothi_TDOPRS = 0;
            recprothi_Stretch = 0;
            recprothi_Coefficient = 0;
            recprothi_TolerancyPositive = 0;
            recprothi_TolerancyNegative = 0;
            recprothi_date = DateTime.Now;
            recprothi_notes = string.Empty;
        }
        //Method
        public bool save(string actions)
        {
            if (actions == "save")
            {
                try
                {
                    string queryString = "";

                    if (this.recprothicodsec == 0)
                    {
                        queryString += "INSERT INTO bps_prod_recordproductionthickness (recprothi_fkRecordProduction, recprothi_fkProductionOrder, recprothi_CRMDO, recprothi_MDO2TDO, recprothi_TDOPRS, recprothi_Stretch, recprothi_Coefficient, recprothi_TolerancyPositive, recprothi_TolerancyNegative, recprothi_notes, recprothi_date)  VALUES (";
                        queryString += this.recprothifkrecordproduction.ToString() + ",";
                        queryString += this.recprothifkproductionorder.ToString() + ",";
                        queryString += this.crmdo.ToString() + ",";
                        queryString += this.mdo2tdo.ToString() + ",";
                        queryString += this.tdoprs.ToString() + ",";
                        queryString += this.stretch.ToString() + ",";
                        queryString += this.coefficientthickness.ToString() + ",";
                        queryString += this.tolerancypositive.ToString() + ",";
                        queryString += this.tolerancynegative.ToString() + ",";
                        queryString += "'" + this.notes.ToString() + "',";
                        queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "');";
                    }
                    else
                    {
                        queryString += "UPDATE bps_prod_recordproductionthickness SET recprothi_fkRecordProduction = " + this.recprothifkrecordproduction.ToString();
                        queryString += ", recprothi_fkProductionOrder =" + this.recprothifkproductionorder.ToString();
                        queryString += ", recprothi_CRMDO = " + this.crmdo.ToString();
                        queryString += ", recprothi_MDO2TDO = " + this.mdo2tdo.ToString();
                        queryString += ", recprothi_TDOPRS = " + this.tdoprs.ToString();
                        queryString += ", recprothi_Stretch = " + this.stretch.ToString();
                        queryString += ", recprothi_Coefficient = " + this.coefficientthickness.ToString();
                        queryString += ", recprothi_TolerancyPositive = " + this.tolerancypositive.ToString();
                        queryString += ", recprothi_TolerancyNegative = " + this.tolerancynegative.ToString();
                        queryString += " WHERE recprothi_codsec = " + this.recprothicodsec.ToString() + ";";
                    }
                    if (clsConnection.executeQuery(queryString))
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    clsLog.addLog(ex, 3, "clsRecordProductionThickness.save");
                    return false;
                }
            }
            else
                return false;
        }
    }
}
