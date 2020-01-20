using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BPS.Bussiness
{
    public class clsRecordProductionPrs
    {
        //Atributes
        private clsRecordProductionSatellite RecordProductionSatellite;
        private int recproprs_codsec;
        private int recproprs_fkRecordProduction;
        private int recproprs_fkProductionOrder;
        private double recproprs_Prsroller1;
        private double recproprs_Prsroller2;
        private double recproprs_Prsroller3;
        private double recproprs_Prsroller4;
        private double recproprs_Prsroller5;
        private double recproprs_PrsAmperage1;
        private double recproprs_PrsAmperage2;
        private double recproprs_PrsAmperage;
        private double recproprs_PrsVelocity;
        private double recproprs_PrsTratador;
        
        //Properties
        public clsRecordProductionSatellite recordproductionsatellite { get { return RecordProductionSatellite; } set { RecordProductionSatellite = value; } }

        public int recproprscodsec { get { return recproprs_codsec; } set { recproprs_codsec = value; } }

        public int recproprsfkrecordproduction { get { return recproprs_fkRecordProduction; } set { recproprs_fkRecordProduction = value; } }

        public int recproprsfkproductionorder { get { return recproprs_fkProductionOrder; } set { recproprs_fkProductionOrder = value; } }

        public double prsroller1 { get { return recproprs_Prsroller1; } set { recproprs_Prsroller1 = value; } }

        public double prsroller2 { get { return recproprs_Prsroller2; } set { recproprs_Prsroller2 = value; } }

        public double prsroller3 { get { return recproprs_Prsroller3; } set { recproprs_Prsroller3 = value; } }

        public double prsroller4 { get { return recproprs_Prsroller4; } set { recproprs_Prsroller4 = value; } }

        public double prsroller5 { get { return recproprs_Prsroller5; } set { recproprs_Prsroller5 = value; } }

        public double prsamperage1 { get { return recproprs_PrsAmperage1; } set { recproprs_PrsAmperage1 = value; } }

        public double prsamperage2 { get { return recproprs_PrsAmperage2; } set { recproprs_PrsAmperage2 = value; } }

        public double prsamperage { get { return recproprs_PrsAmperage; } set { recproprs_PrsAmperage = value; } }

        public double prsvelocity { get { return recproprs_PrsVelocity; } set { recproprs_PrsVelocity = value; } }

        public double prstratador { get { return recproprs_PrsTratador; } set { recproprs_PrsTratador = value; } }
        
        //Constructor
        public clsRecordProductionPrs()
        {
            recproprs_codsec = 0;
            recproprs_fkRecordProduction = 0;
            recproprs_fkProductionOrder = 0;
            recproprs_Prsroller1 = 0;
            recproprs_Prsroller2 = 0;
            recproprs_Prsroller3 = 0;
            recproprs_Prsroller4 = 0;
            recproprs_Prsroller5 = 0;
            recproprs_PrsAmperage1 = 0;
            recproprs_PrsAmperage2 = 0;
            recproprs_PrsAmperage = 0;
            recproprs_PrsVelocity = 0;
            recproprs_PrsTratador = 0;
            recordproductionsatellite = new clsRecordProductionSatellite();
        }
        
        //Method
        public bool save(string actions)
        {
            if (actions == "save")
            {
                try
                {
                    string queryString = "";

                    if (this.recproprscodsec == 0)
                    {
                        queryString += "INSERT INTO bps_prod_recordproductionprs (recproprs_fkRecordProduction, recproprs_fkProductionOrder, recproprs_Prsroller1, recproprs_Prsroller2, recproprs_Prsroller3, recproprs_Prsroller4, recproprs_PrsAmperage1, recproprs_PrsAmperage2, recproprs_PrsAmperage, recproprs_PrsVelocity, recproprs_PrsTratador, recproprs_Prsroller5) VALUES (";
                        queryString += this.recproprsfkrecordproduction.ToString() + ",";
                        queryString += this.recproprsfkproductionorder.ToString() + ",";
                        queryString += this.prsroller1.ToString() + ",";
                        queryString += this.prsroller2.ToString() + ",";
                        queryString += this.prsroller3.ToString() + ",";
                        queryString += this.prsroller4.ToString() + ",";
                        queryString += this.prsamperage1.ToString() + ",";
                        queryString += this.prsamperage2.ToString() + ",";
                        queryString += this.prsamperage.ToString() + ",";
                        queryString += this.prsvelocity.ToString() + ",";
                        queryString += this.prstratador.ToString() + ",";
                        queryString += this.prsroller5.ToString() + ");";
                    }
                    else
                    {
                        queryString += "UPDATE bps_prod_recordproductionprs SET recproprs_fkRecordProduction = " + this.recproprsfkrecordproduction.ToString();
                        queryString += ", recproprs_fkProductionOrder =" + this.recproprsfkproductionorder.ToString();
                        queryString += ", recproprs_Prsroller1 = " + this.prsroller1.ToString();
                        queryString += ", recproprs_Prsroller2 = " + this.prsroller2.ToString();
                        queryString += ", recproprs_Prsroller3 = " + this.prsroller3.ToString();
                        queryString += ", recproprs_Prsroller4 = " + this.prsroller4.ToString();
                        queryString += ", recproprs_PrsAmperage1 = " + this.prsamperage1.ToString();
                        queryString += ", recproprs_PrsAmperage2 = " + this.prsamperage2.ToString();
                        queryString += ", recproprs_PrsAmperage = " + this.prsamperage.ToString();
                        queryString += ", recproprs_PrsVelocity = " + this.prsvelocity.ToString();
                        queryString += ", recproprs_PrsTratador = " + this.prstratador.ToString();
                        queryString += ", recproprs_Prsroller5 = " + this.prsroller5.ToString();
                        queryString += " WHERE recproprs_codsec = " + this.recproprscodsec.ToString() + ";";
                    }
                    clsConnection.executeQuery(queryString);
                    recordproductionsatellite.save("save");
                    return true;
                    //las otras tablas
                }
                catch (Exception ex)
                {
                    clsLog.addLog(ex, 3, "clsRecordProductionPrs.save");
                    return false;
                }
            }
            else
                return false;
        }

        public bool saves(string actions)
        {
            if (actions == "save")
            {
                try
                {
                    string queryString = "";

                    if (this.recproprscodsec == 0)
                    {
                        queryString += "INSERT INTO bps_prod_recordproductionprs (recproprs_fkRecordProduction, recproprs_fkProductionOrder, recproprs_Prsroller1, recproprs_Prsroller2, recproprs_Prsroller3, recproprs_Prsroller4, recproprs_PrsAmperage1, recproprs_PrsAmperage2, recproprs_PrsAmperage, recproprs_PrsVelocity, recproprs_PrsTratador) VALUES (";
                        queryString += this.recproprsfkrecordproduction.ToString() + ",";
                        queryString += this.recproprsfkproductionorder.ToString() + ",";
                        queryString += this.prsroller1.ToString() + ",";
                        queryString += this.prsroller2.ToString() + ",";
                        queryString += this.prsroller3.ToString() + ",";
                        queryString += this.prsroller4.ToString() + ",";
                        queryString += this.prsamperage1.ToString() + ",";
                        queryString += this.prsamperage2.ToString() + ",";
                        queryString += this.prsamperage.ToString() + ",";
                        queryString += this.prsvelocity.ToString() + ",";
                        queryString += this.prstratador.ToString() + ");";
                    }
                    if (clsConnection.executeQuery(queryString))
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    clsLog.addLog(ex, 3, "clsRecordProductionPrs.save");
                    return false;
                }
            }
            else
                return false;
        }
    }
}
