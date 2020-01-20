using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BPS.Bussiness
{
    public class clsRecordProductionPrsMw
    {
        //Atributes
        //private clsRecordProductionSatellite RecordProductionSatellite;
        private int recproprsmw_codsec;
        private int recproprsmw_fkRecordProduction;
        private int recproprsmw_fkProductionOrder;
        private double recproprsmw_RollerGuide;
        private double recproprsmw_RollerBlade;
        private double recproprsmw_RollerTreater1;
        private double recproprsmw_RollerTreater2;
        private double recproprsmw_RollerBridge;
        private double recproprsmw_Speed;
        private double recproprsmw_Amperage;
        private double recproprsmw_PowerTreater;
        private double recproprsmw_amp1;
        private double recproprsmw_amp2;
        private double recproprsmw_amp3;
        private double recproprsmw_amp4;
        private double recproprsmw_amp5;
        private double recproprsmw_amp6;

        
        //Properties
        //public clsRecordProductionSatellite recordproductionsatellite { get { return RecordProductionSatellite; } set { RecordProductionSatellite = value; } }

        public int recproprsmwcodsec { get { return recproprsmw_codsec; } set { recproprsmw_codsec = value; } }

        public int recproprsmwfkrecordproduction { get { return recproprsmw_fkRecordProduction; } set { recproprsmw_fkRecordProduction = value; } }

        public int recproprsmwfkproductionorder { get { return recproprsmw_fkProductionOrder; } set { recproprsmw_fkProductionOrder = value; } }

        public double prsrmwollerguide { get { return recproprsmw_RollerGuide; } set { recproprsmw_RollerGuide = value; } }

        public double prsmwrollerblade { get { return recproprsmw_RollerBlade; } set { recproprsmw_RollerBlade = value; } }

        public double prsmwrollertreater { get { return recproprsmw_RollerTreater1; } set { recproprsmw_RollerTreater1 = value; } }

        public double prsmwrollertreater2 { get { return recproprsmw_RollerTreater2; } set { recproprsmw_RollerTreater2 = value; } }

        public double prsmwbridge { get { return recproprsmw_RollerBridge; } set { recproprsmw_RollerBridge = value; } }

        public double prsmwspeed { get { return recproprsmw_Speed; } set { recproprsmw_Speed = value; } }

        public double prsmwamperage { get { return recproprsmw_Amperage; } set { recproprsmw_Amperage = value; } }

        public double prsmwpowertreater { get { return recproprsmw_PowerTreater; } set { recproprsmw_PowerTreater = value; } }

        public double amp1 { get { return recproprsmw_amp1; } set { recproprsmw_amp1 = value; } }
        
        public double amp2 { get { return recproprsmw_amp2; } set { recproprsmw_amp2 = value; } }
        
        public double amp3 { get { return recproprsmw_amp3; } set { recproprsmw_amp3 = value; } }

        public double amp4 { get { return recproprsmw_amp4; } set { recproprsmw_amp4 = value; } }

        public double amp5 { get { return recproprsmw_amp5; } set { recproprsmw_amp5 = value; } }

        public double amp6 { get { return recproprsmw_amp6; } set { recproprsmw_amp6 = value; } }
        
        //Constructor
        public clsRecordProductionPrsMw()
        {
            recproprsmw_codsec = 0;
            recproprsmw_fkRecordProduction = 0;
            recproprsmw_fkProductionOrder = 0;
            recproprsmw_RollerGuide = 0;
            recproprsmw_RollerBlade = 0;
            recproprsmw_RollerTreater1 = 0;
            recproprsmw_RollerTreater2 = 0;
            recproprsmw_RollerBridge = 0;
            recproprsmw_Speed = 0;
            recproprsmw_Amperage = 0;
            recproprsmw_PowerTreater = 0;
            recproprsmw_amp1 = 0;
            recproprsmw_amp2 = 0;
            recproprsmw_amp3 = 0;
            recproprsmw_amp4 = 0;
            recproprsmw_amp5 = 0;
            recproprsmw_amp6 = 0;
            //recordproductionsatellite = new clsRecordProductionSatellite();
        }
        
        //Method
        public bool save(string actions)
        {
            if (actions == "save")
            {
                try
                {
                    string queryString = "";

                    if (this.recproprsmwcodsec == 0)
                    {
                        queryString += "INSERT INTO bps_prod_recordproductionmwprs (recproprsmw_fkRecordProduction, recproprsmw_fkProductionOrder, recproprsmw_RollerGuide, recproprsmw_RollerBlade, recproprsmw_RollerTreater1, recproprsmw_RollerTreater2, recproprsmw_RollerBridge, recproprsmw_Speed, recproprsmw_Amperage, recproprsmw_PowerTreater) VALUES (";
                        queryString += this.recproprsmwfkrecordproduction.ToString() + ",";
                        queryString += this.recproprsmwfkproductionorder.ToString() + ",";
                        queryString += this.prsrmwollerguide.ToString() + ",";
                        queryString += this.prsmwrollerblade.ToString() + ",";
                        queryString += this.prsmwrollertreater.ToString() + ",";
                        queryString += this.prsmwrollertreater2.ToString() + ",";
                        queryString += this.prsmwbridge.ToString() + ",";
                        queryString += this.prsmwspeed.ToString() + ",";
                        queryString += this.prsmwamperage.ToString() + ",";
                        queryString += this.prsmwpowertreater.ToString() + ");";
                    }
                    else
                    {
                        queryString += "UPDATE bps_prod_recordproductionmwprs SET recproprsmw_fkRecordProduction = " + this.recproprsmwfkrecordproduction.ToString();
                        queryString += ", recproprsmw_fkProductionOrder =" + this.recproprsmwfkproductionorder.ToString();
                        queryString += ", recproprsmw_RollerGuide = " + this.prsrmwollerguide.ToString();
                        queryString += ", recproprsmw_RollerBlade = " + this.prsmwrollerblade.ToString();
                        queryString += ", recproprsmw_RollerTreater1 = " + this.prsmwrollertreater.ToString();
                        queryString += ", recproprsmw_RollerTreater2 = " + this.prsmwrollertreater2.ToString();
                        queryString += ", recproprsmw_RollerBridge = " + this.prsmwbridge.ToString();
                        queryString += ", recproprsmw_Speed = " + this.prsmwspeed.ToString();
                        queryString += ", recproprsmw_Amperage = " + this.prsmwamperage.ToString();
                        queryString += ", recproprsmw_PowerTreater = " + this.prsmwpowertreater.ToString();
                        queryString += " WHERE recproprsmw_codsec = " + this.recproprsmwcodsec.ToString() + ";";
                    }
                    clsConnection.executeQuery(queryString);
                    return true;
                }
                catch (Exception ex)
                {
                    clsLog.addLog(ex, 3, "clsRecordProductionPrsMw.save");
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

                    if (this.recproprsmwcodsec == 0)
                    {
                        queryString += "INSERT INTO bps_prod_recordproductionmwprs (recproprsmw_fkRecordProduction, recproprsmw_fkProductionOrder, recproprsmw_RollerGuide, recproprsmw_RollerBlade, recproprsmw_RollerTreater1, recproprsmw_RollerTreater2, recproprsmw_RollerBridge, recproprsmw_Speed, recproprsmw_Amperage, recproprsmw_PowerTreater, recproprsmw_amp1, recproprsmw_amp2, recproprsmw_amp3, recproprsmw_amp4, recproprsmw_amp5, recproprsmw_amp6) VALUES (";
                        queryString += this.recproprsmwfkrecordproduction.ToString() + ",";
                        queryString += this.recproprsmwfkproductionorder.ToString() + ",";
                        queryString += this.prsrmwollerguide.ToString() + ",";
                        queryString += this.prsmwrollerblade.ToString() + ",";
                        queryString += this.prsmwrollertreater.ToString() + ",";
                        queryString += this.prsmwrollertreater2.ToString() + ",";
                        queryString += this.prsmwbridge.ToString() + ",";
                        queryString += this.prsmwspeed.ToString() + ",";
                        queryString += this.prsmwamperage.ToString() + ",";
                        queryString += this.prsmwpowertreater.ToString() + ",";
                        queryString += this.amp1.ToString() + ",";
                        queryString += this.amp2.ToString() + ",";
                        queryString += this.amp3.ToString() + ",";
                        queryString += this.amp4.ToString() + ",";
                        queryString += this.amp5.ToString() + ",";
                        queryString += this.amp6.ToString() + ");";
                    }
                    if (clsConnection.executeQuery(queryString))
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    clsLog.addLog(ex, 3, "clsRecordProductionPrsMw.save");
                    return false;
                }
            }
            else
                return false;
        }
    }
}
