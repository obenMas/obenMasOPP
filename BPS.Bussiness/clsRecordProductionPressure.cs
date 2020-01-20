using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BPS.Bussiness
{
    public class clsRecordProductionPressure
    {
        //Atributes
        private clsRecordProductionPrs RecordProductionPrs;
        private int recpropre_codsec;
        private int recpropre_fkRecordProduction;
        private int recpropre_fkProductionOrder;
        private double recpropre_Coil1;
        private double recpropre_Coil2;
        private double recpropre_Coil3;
        private double recpropre_Coil4;
        private double recpropre_Coil5;
        private double recpropre_Coil6;
        private double recpropre_Coil7;
        private double recpropre_Coil8;
        private double recpropre_Coil9;
        private double recpropre_Pressure1;
        private double recpropre_Pressure2;
        private double recpropre_Pressure3;
        private double recpropre_Pressure4;
        private double recpropre_Pressure5;
        private double recpropre_Pressure6;
        private double recpropre_Pressure7;
        private double recpropre_Pressure8;
        private double recpropre_Pressure9;
        private double recpropre_Tensioncut;
        private double recpropre_Tensionchange;
        private double recpropre_Coilthickness;
        private double recpropre_Coil10;
        private double recpropre_Coil11;
        private double recpropre_Pressure10;
        private double recpropre_Pressure11;
        
        //Properies
        public clsRecordProductionPrs recordproductionprs { get { return RecordProductionPrs; } set { RecordProductionPrs = value; } }

        public int recproprecodsec { get { return recpropre_codsec; } set { recpropre_codsec = value; } }

        public int recproprefkrecordproduction { get { return recpropre_fkRecordProduction; } set { recpropre_fkRecordProduction = value; } }

        public int recproprefkproductionorder { get { return recpropre_fkProductionOrder; } set { recpropre_fkProductionOrder = value; } }

        public double coil1 { get { return recpropre_Coil1; } set { recpropre_Coil1 = value; } }

        public double coil2 { get { return recpropre_Coil2; } set { recpropre_Coil2 = value; } }

        public double coil3 { get { return recpropre_Coil3; } set { recpropre_Coil3 = value; } }

        public double coil4 { get { return recpropre_Coil4; } set { recpropre_Coil4 = value; } }

        public double coil5 { get { return recpropre_Coil5; } set { recpropre_Coil5 = value; } }

        public double coil6 { get { return recpropre_Coil6; } set { recpropre_Coil6 = value; } }

        public double coil7 { get { return recpropre_Coil7; } set { recpropre_Coil7 = value; } }

        public double coil8 { get { return recpropre_Coil8; } set { recpropre_Coil8 = value; } }

        public double coil9 { get { return recpropre_Coil9; } set { recpropre_Coil9 = value; } }

        public double pressure1 { get { return recpropre_Pressure1; } set { recpropre_Pressure1 = value; } }

        public double pressure2 { get { return recpropre_Pressure2; } set { recpropre_Pressure2 = value; } }

        public double pressure3 { get { return recpropre_Pressure3; } set { recpropre_Pressure3 = value; } }

        public double pressure4 { get { return recpropre_Pressure4; } set { recpropre_Pressure4 = value; } }

        public double pressure5 { get { return recpropre_Pressure5; } set { recpropre_Pressure5 = value; } }

        public double pressure6 { get { return recpropre_Pressure6; } set { recpropre_Pressure6 = value; } }

        public double pressure7 { get { return recpropre_Pressure7; } set { recpropre_Pressure7 = value; } }

        public double pressure8 { get { return recpropre_Pressure8; } set { recpropre_Pressure8 = value; } }

        public double pressure9 { get { return recpropre_Pressure9; } set { recpropre_Pressure9 = value; } }

        public double tensioncut { get { return recpropre_Tensioncut; } set { recpropre_Tensioncut = value; } }

        public double tensionchange { get { return recpropre_Tensionchange; } set { recpropre_Tensionchange = value; } }

        public double coilthickness { get { return recpropre_Coilthickness; } set { recpropre_Coilthickness = value; } }

        public double coil10 { get { return recpropre_Coil10; } set { recpropre_Coil10 = value; } }
        
        public double coil11 { get { return recpropre_Coil11; } set { recpropre_Coil11 = value; } }

        public double pressure10 { get { return recpropre_Pressure10; } set { recpropre_Pressure10 = value; } }

        public double pressure11 { get { return recpropre_Pressure11; } set { recpropre_Pressure11 = value; } }

        //Constructor
        public clsRecordProductionPressure()
        {
            recordproductionprs = new clsRecordProductionPrs();
            recpropre_codsec = 0;
            recpropre_fkRecordProduction = 0;
            recpropre_fkProductionOrder = 0;
            recpropre_Coil1 = 0;
            recpropre_Coil2 = 0;
            recpropre_Coil3 = 0;
            recpropre_Coil4 = 0;
            recpropre_Coil5 = 0;
            recpropre_Coil6 = 0;
            recpropre_Coil7 = 0;
            recpropre_Coil8 = 0;
            recpropre_Coil9 = 0;
            recpropre_Pressure1 = 0;
            recpropre_Pressure2 = 0;
            recpropre_Pressure3 = 0;
            recpropre_Pressure4 = 0;
            recpropre_Pressure5 = 0;
            recpropre_Pressure6 = 0;
            recpropre_Pressure7 = 0;
            recpropre_Pressure8 = 0;
            recpropre_Pressure9 = 0;
            recpropre_Tensioncut = 0;
            recpropre_Tensionchange = 0;
            recpropre_Coilthickness = 0;
            recpropre_Coil10 = 0;
            recpropre_Coil11 = 0;
            recpropre_Pressure10 = 0;
            recpropre_Pressure11 = 0;
        }
        //Method
        public bool save(string actions)
        {
            if (actions == "save")
            {
                try
                {
                    string queryString = "";

                    if (this.recproprecodsec == 0)
                    {
                        queryString += "INSERT INTO bps_prod_recordproductionpressure (recpropre_fkRecordProduction, recpropre_fkProductionOrder, recpropre_Coil1, recpropre_Coil2, recpropre_Coil3, recpropre_Coil4, recpropre_Coil5, recpropre_Coil6, recpropre_Coil7, recpropre_Coil8, recpropre_Coil9, recpropre_Pressure1, recpropre_Pressure2, recpropre_Pressure3, recpropre_Pressure4, recpropre_Pressure5, recpropre_Pressure6, recpropre_Pressure7, recpropre_Pressure8, recpropre_Pressure9, recpropre_Tensioncut, recpropre_Tensionchange, recpropre_Coilthickness, recpropre_Coil10, recpropre_Coil11, recpropre_Pressure10, recpropre_Pressure11) VALUES (";
                        queryString += this.recproprefkrecordproduction.ToString() + ",";
                        queryString += this.recproprefkproductionorder.ToString() + ",";
                        queryString += this.coil1.ToString() + ",";
                        queryString += this.coil2.ToString() + ",";
                        queryString += this.coil3.ToString() + ",";
                        queryString += this.coil4.ToString() + ",";
                        queryString += this.coil5.ToString() + ",";
                        queryString += this.coil6.ToString() + ",";
                        queryString += this.coil7.ToString() + ",";
                        queryString += this.coil8.ToString() + ",";
                        queryString += this.coil9.ToString() + ",";
                        queryString += this.pressure1.ToString() + ",";
                        queryString += this.pressure2.ToString() + ",";
                        queryString += this.pressure3.ToString() + ",";
                        queryString += this.pressure4.ToString() + ",";
                        queryString += this.pressure5.ToString() + ",";
                        queryString += this.pressure6.ToString() + ",";
                        queryString += this.pressure7.ToString() + ",";
                        queryString += this.pressure8.ToString() + ",";
                        queryString += this.pressure9.ToString() + ",";
                        queryString += this.tensioncut.ToString() + ",";
                        queryString += this.tensionchange.ToString() + ",";
                        queryString += this.coilthickness.ToString() + ",";
                        queryString += this.coil10.ToString() + ",";
                        queryString += this.coil11.ToString() + ",";
                        queryString += this.pressure10.ToString() + ",";
                        queryString += this.pressure11.ToString() + ");";
                    }
                    else
                    {
                        queryString += "UPDATE bps_prod_recordproductionpressure SET recpropre_fkRecordProduction = " + this.recproprefkrecordproduction.ToString();
                        queryString += ", recpropre_fkProductionOrder =" + this.recproprefkproductionorder.ToString();
                        queryString += ", recpropre_Coil1 = " + this.coil1.ToString();
                        queryString += ", recpropre_Coil2 = " + this.coil2.ToString();
                        queryString += ", recpropre_Coil3 = " + this.coil3.ToString();
                        queryString += ", recpropre_Coil4 = " + this.coil4.ToString();
                        queryString += ", recpropre_Coil5 = " + this.coil5.ToString();
                        queryString += ", recpropre_Coil6 = " + this.coil6.ToString();
                        queryString += ", recpropre_Coil7 = " + this.coil7.ToString();
                        queryString += ", recpropre_Coil8 = " + this.coil8.ToString();
                        queryString += ", recpropre_Coil9 = " + this.coil9.ToString();
                        queryString += ", recpropre_Pressure1 = " + this.pressure1.ToString();
                        queryString += ", recpropre_Pressure2 = " + this.pressure2.ToString();
                        queryString += ", recpropre_Pressure3 = " + this.pressure3.ToString();
                        queryString += ", recpropre_Pressure4 = " + this.pressure4.ToString();
                        queryString += ", recpropre_Pressure5 = " + this.pressure5.ToString();
                        queryString += ", recpropre_Pressure6 = " + this.pressure6.ToString();
                        queryString += ", recpropre_Pressure7 = " + this.pressure7.ToString();
                        queryString += ", recpropre_Pressure8 = " + this.pressure8.ToString();
                        queryString += ", recpropre_Pressure9 = " + this.pressure9.ToString();
                        queryString += ", recpropre_Tensioncut = " + this.tensioncut.ToString();
                        queryString += ", recpropre_Tensionchange = " + this.tensionchange.ToString();
                        queryString += ", recpropre_Coilthickness = " + this.coilthickness.ToString();
                        queryString += " WHERE recpropre_codsec = " + this.recproprecodsec.ToString() + ";";
                    }
                    clsConnection.executeQuery(queryString);
                    recordproductionprs.save("save");
                    return true;
                    //las otras tablas
                }
                catch (Exception ex)
                {
                    clsLog.addLog(ex, 3, "clsRecordProductionPressure.save");
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

                    if (this.recproprecodsec == 0)
                    {
                        queryString += "INSERT INTO bps_prod_recordproductionpressure (recpropre_fkRecordProduction, recpropre_fkProductionOrder, recpropre_Coil1, recpropre_Coil2, recpropre_Coil3, recpropre_Coil4, recpropre_Coil5, recpropre_Coil6, recpropre_Coil7, recpropre_Coil8, recpropre_Coil9, recpropre_Pressure1, recpropre_Pressure2, recpropre_Pressure3, recpropre_Pressure4, recpropre_Pressure5, recpropre_Pressure6, recpropre_Pressure7, recpropre_Pressure8, recpropre_Pressure9, recpropre_Tensioncut, recpropre_Tensionchange, recpropre_Coilthickness, recpropre_Coil10, recpropre_Coil11, recpropre_Pressure10, recpropre_Pressure11) VALUES (";
                        queryString += this.recproprefkrecordproduction.ToString() + ",";
                        queryString += this.recproprefkproductionorder.ToString() + ",";
                        queryString += this.coil1.ToString() + ",";
                        queryString += this.coil2.ToString() + ",";
                        queryString += this.coil3.ToString() + ",";
                        queryString += this.coil4.ToString() + ",";
                        queryString += this.coil5.ToString() + ",";
                        queryString += this.coil6.ToString() + ",";
                        queryString += this.coil7.ToString() + ",";
                        queryString += this.coil8.ToString() + ",";
                        queryString += this.coil9.ToString() + ",";
                        queryString += this.pressure1.ToString() + ",";
                        queryString += this.pressure2.ToString() + ",";
                        queryString += this.pressure3.ToString() + ",";
                        queryString += this.pressure4.ToString() + ",";
                        queryString += this.pressure5.ToString() + ",";
                        queryString += this.pressure6.ToString() + ",";
                        queryString += this.pressure7.ToString() + ",";
                        queryString += this.pressure8.ToString() + ",";
                        queryString += this.pressure9.ToString() + ",";
                        queryString += this.tensioncut.ToString() + ",";
                        queryString += this.tensionchange.ToString() + ",";
                        queryString += this.coilthickness.ToString() + ",";
                        queryString += this.coil10.ToString() + ",";
                        queryString += this.coil11.ToString() + ",";
                        queryString += this.pressure10.ToString() + ",";
                        queryString += this.pressure11.ToString() + ");";
                    }
                    if (clsConnection.executeQuery(queryString))
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    clsLog.addLog(ex, 3, "clsRecordProductionPressure.save");
                    return false;
                }
            }
            else
                return false;
        }
    }
}
