using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BPS.Bussiness
{
    public class clsRecordProductionTdo
    {
        //Atributes
        private clsRecordProductionThickness RecordProductionThickness;
        private int recprotdo_codsec;
        private int recprotdo_fkRecordProduction;
        private int recprotdo_fkProductionOrder;
        private double recprotdo_TdoZ1;
        private double recprotdo_TdoZ2;
        private double recprotdo_TdoZ3;
        private double recprotdo_TdoZ4;
        private double recprotdo_TdoZ5;
        private double recprotdo_TdoZ6;
        private double recprotdo_TdoZ7;
        private double recprotdo_TdoZ8;
        private double recprotdo_TdoZ9;
        private double recprotdo_TdoVelocityString;
        private double recprotdo_TdoAmperageString;
        private string recprotdo_Tdolubrication1;
        private string recprotdo_Tdolubrication2;

        //Properties
        public clsRecordProductionThickness recordproductionthickness { get { return RecordProductionThickness; } set { RecordProductionThickness = value; } }

        public int recprotdocodsec { get { return recprotdo_codsec; } set { recprotdo_codsec = value; } }

        public int recprotdofkrecordproduction { get { return recprotdo_fkRecordProduction; } set { recprotdo_fkRecordProduction = value; } }

        public int recprotdofkproductionorder { get { return recprotdo_fkProductionOrder; } set { recprotdo_fkProductionOrder = value; } }

        public double tdoz1 { get { return recprotdo_TdoZ1; } set { recprotdo_TdoZ1 = value; } }

        public double tdoz2 { get { return recprotdo_TdoZ2; } set { recprotdo_TdoZ2 = value; } }

        public double tdoz3 { get { return recprotdo_TdoZ3; } set { recprotdo_TdoZ3 = value; } }

        public double tdoz4 { get { return recprotdo_TdoZ4; } set { recprotdo_TdoZ4 = value; } }

        public double tdoz5 { get { return recprotdo_TdoZ5; } set { recprotdo_TdoZ5 = value; } }

        public double tdoz6 { get { return recprotdo_TdoZ6; } set { recprotdo_TdoZ6 = value; } }

        public double tdoz7 { get { return recprotdo_TdoZ7; } set { recprotdo_TdoZ7 = value; } }

        public double tdoz8 { get { return recprotdo_TdoZ8; } set { recprotdo_TdoZ8 = value; } }

        public double tdoz9 { get { return recprotdo_TdoZ9; } set { recprotdo_TdoZ9 = value; } }

        public double tdovelocitystring { get { return recprotdo_TdoVelocityString; } set { recprotdo_TdoVelocityString = value; } }

        public double tdoamperagestring { get { return recprotdo_TdoAmperageString; } set { recprotdo_TdoAmperageString = value; } }

        public string tdolubrication1 { get { return recprotdo_Tdolubrication1; } set { recprotdo_Tdolubrication1 = value; } }

        public string tdolubrication2 { get { return recprotdo_Tdolubrication2; } set { recprotdo_Tdolubrication2 = value; } }

        //Constructor
        public clsRecordProductionTdo()
        {
            RecordProductionThickness = new clsRecordProductionThickness();
            recprotdo_codsec = 0;
            recprotdo_fkRecordProduction = 0;
            recprotdo_fkProductionOrder = 0;
            recprotdo_TdoZ1 = 0;
            recprotdo_TdoZ2 = 0;
            recprotdo_TdoZ3 = 0;
            recprotdo_TdoZ4 = 0;
            recprotdo_TdoZ5 = 0;
            recprotdo_TdoZ6 = 0;
            recprotdo_TdoZ7 = 0;
            recprotdo_TdoZ8 = 0;
            recprotdo_TdoZ9 = 0;
            recprotdo_TdoVelocityString = 0;
            recprotdo_TdoAmperageString = 0;
            recprotdo_Tdolubrication1 = "";
            recprotdo_Tdolubrication2 = "";
        }
        //Method
        public bool save(string actions)
        {
            if (actions == "save")
            {
                try
                {
                    string queryString = "";

                    if (this.recprotdocodsec == 0)
                    {
                        queryString += "INSERT INTO bps_prod_recordproductiontdo (recprotdo_fkRecordProduction, recprotdo_fkProductionOrder, recprotdo_TdoZ1, recprotdo_TdoZ2, recprotdo_TdoZ3, recprotdo_TdoZ4, recprotdo_TdoZ5, recprotdo_TdoZ6, recprotdo_TdoZ7, recprotdo_TdoZ8, recprotdo_TdoZ9, recprotdo_TdoVelocityString, recprotdo_TdoAmperageString, recprotdo_Tdolubrication1, recprotdo_Tdolubrication2)  VALUES (";
                        queryString += this.recprotdofkrecordproduction.ToString() + ",";
                        queryString += this.recprotdofkproductionorder.ToString() + ",";
                        queryString += this.tdoz1.ToString() + ",";
                        queryString += this.tdoz2.ToString() + ",";
                        queryString += this.tdoz3.ToString() + ",";
                        queryString += this.tdoz4.ToString() + ",";
                        queryString += this.tdoz5.ToString() + ",";
                        queryString += this.tdoz6.ToString() + ",";
                        queryString += this.tdoz7.ToString() + ",";
                        queryString += this.tdoz8.ToString() + ",";
                        queryString += this.tdoz9.ToString() + ",";
                        queryString += this.tdovelocitystring.ToString() + ",";
                        queryString += this.tdoamperagestring.ToString() + ",";
                        queryString += "'" + this.tdolubrication1.ToString() + "',";
                        queryString += "'" + this.tdolubrication2.ToString() + "');";
                    }
                    else
                    {
                        queryString += "UPDATE bps_prod_recordproductiontdo SET recprotdo_fkRecordProduction = " + this.recprotdofkrecordproduction.ToString();
                        queryString += ", recprotdo_fkProductionOrder =" + this.recprotdofkproductionorder.ToString();
                        queryString += ", recprotdo_TdoZ1 = " + this.tdoz1.ToString();
                        queryString += ", recprotdo_TdoZ2 = " + this.tdoz2.ToString();
                        queryString += ", recprotdo_TdoZ3 = " + this.tdoz3.ToString();
                        queryString += ", recprotdo_TdoZ4 = " + this.tdoz4.ToString();
                        queryString += ", recprotdo_TdoZ5 = " + this.tdoz5.ToString();
                        queryString += ", recprotdo_TdoZ6 = " + this.tdoz6.ToString();
                        queryString += ", recprotdo_TdoZ7 = " + this.tdoz7.ToString();
                        queryString += ", recprotdo_TdoZ8 = " + this.tdoz8.ToString();
                        queryString += ", recprotdo_TdoZ9 = " + this.tdoz9.ToString();
                        queryString += ", recprotdo_TdoVelocityString = " + this.tdovelocitystring.ToString();
                        queryString += ", recprotdo_TdoAmperageString = " + this.tdoamperagestring.ToString();
                        queryString += ", recprotdo_Tdolubrication1 = '" + this.tdolubrication1.ToString() + "'";
                        queryString += ", recprotdo_Tdolubrication2 = '" + this.tdolubrication2.ToString() + "'";
                        queryString += " WHERE recprotdo_codsec = " + this.recprotdocodsec.ToString() + ";";
                    }
                    clsConnection.executeQuery(queryString);
                    recordproductionthickness.save("save");
                    return true;
                    //las otras tablas
                }
                catch (Exception ex)
                {
                    clsLog.addLog(ex, 3, "clsRecordProductionTdo.save");
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

                    if (this.recprotdocodsec == 0)
                    {
                        queryString += "INSERT INTO bps_prod_recordproductiontdo (recprotdo_fkRecordProduction, recprotdo_fkProductionOrder, recprotdo_TdoZ1, recprotdo_TdoZ2, recprotdo_TdoZ3, recprotdo_TdoZ4, recprotdo_TdoZ5, recprotdo_TdoZ6, recprotdo_TdoZ7, recprotdo_TdoZ8, recprotdo_TdoZ9, recprotdo_TdoVelocityString, recprotdo_TdoAmperageString, recprotdo_Tdolubrication1, recprotdo_Tdolubrication2)  VALUES (";
                        queryString += this.recprotdofkrecordproduction.ToString() + ",";
                        queryString += this.recprotdofkproductionorder.ToString() + ",";
                        queryString += this.tdoz1.ToString() + ",";
                        queryString += this.tdoz2.ToString() + ",";
                        queryString += this.tdoz3.ToString() + ",";
                        queryString += this.tdoz4.ToString() + ",";
                        queryString += this.tdoz5.ToString() + ",";
                        queryString += this.tdoz6.ToString() + ",";
                        queryString += this.tdoz7.ToString() + ",";
                        queryString += this.tdoz8.ToString() + ",";
                        queryString += this.tdoz9.ToString() + ",";
                        queryString += this.tdovelocitystring.ToString() + ",";
                        queryString += this.tdoamperagestring.ToString() + ",";
                        queryString += "'" + this.tdolubrication1.ToString() + "',";
                        queryString += "'" + this.tdolubrication2.ToString() + "');";
                    }
                    if (clsConnection.executeQuery(queryString))
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    clsLog.addLog(ex, 3, "clsRecordProductionTdo.save");
                    return false;
                }
            }
            else
                return false;
        }
    }
}
