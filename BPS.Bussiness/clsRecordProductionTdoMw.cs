using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BPS.Bussiness
{
    public class clsRecordProductionTdoMw
    {
        //Atributes
        //private clsRecordProductionThickness RecordProductionThickness;
        private int recprotdomw_codsec;
        private int recprotdomw_fkRecordProduction;
        private int recprotdomw_fkProductionOrder;
        private double recprotdomw_TdoZ1;
        private double recprotdomw_TdoZ2;
        private double recprotdomw_TdoZ3;
        private double recprotdomw_TdoZ4;
        private double recprotdomw_TdoZ5;
        private double recprotdomw_TdoZ6;
        private double recprotdomw_TdoVelocityString;
        private double recprotdomw_TdoAmperageString;
        private double recprotdomw_TdoTimeLubrication;
        private double recprotdomw_TdoUnTimeLubrication;
        private double recprotdomw_var1;
        private double recprotdomw_var2;
        private double recprotdomw_var3;
        private double recprotdomw_var4;

        //Properties
        //public clsRecordProductionThickness recordproductionthickness { get { return RecordProductionThickness; } set { RecordProductionThickness = value; } }

        public int recprotdomwcodsec { get { return recprotdomw_codsec; } set { recprotdomw_codsec = value; } }

        public int recprotdomwfkrecordproduction { get { return recprotdomw_fkRecordProduction; } set { recprotdomw_fkRecordProduction = value; } }

        public int recprotdomwfkproductionorder { get { return recprotdomw_fkProductionOrder; } set { recprotdomw_fkProductionOrder = value; } }

        public double tdomwz1 { get { return recprotdomw_TdoZ1; } set { recprotdomw_TdoZ1 = value; } }

        public double tdomwz2 { get { return recprotdomw_TdoZ2; } set { recprotdomw_TdoZ2 = value; } }

        public double tdomwz3 { get { return recprotdomw_TdoZ3; } set { recprotdomw_TdoZ3 = value; } }

        public double tdomwz4 { get { return recprotdomw_TdoZ4; } set { recprotdomw_TdoZ4 = value; } }

        public double tdomwz5 { get { return recprotdomw_TdoZ5; } set { recprotdomw_TdoZ5 = value; } }

        public double tdomwz6 { get { return recprotdomw_TdoZ6; } set { recprotdomw_TdoZ6 = value; } }

        public double tdomwvelocitystring { get { return recprotdomw_TdoVelocityString; } set { recprotdomw_TdoVelocityString = value; } }

        public double tdomwamperagestring { get { return recprotdomw_TdoAmperageString; } set { recprotdomw_TdoAmperageString = value; } }

        public double tdotimwlubrication { get { return recprotdomw_TdoTimeLubrication; } set { recprotdomw_TdoTimeLubrication = value; } }

        public double tdountimelubrication { get { return recprotdomw_TdoUnTimeLubrication; } set { recprotdomw_TdoUnTimeLubrication = value; } }

        public double var1 { get { return recprotdomw_var1; } set { recprotdomw_var1 = value; } }

        public double var2 { get { return recprotdomw_var2; } set { recprotdomw_var2 = value; } }

        public double var3 { get { return recprotdomw_var3; } set { recprotdomw_var3 = value; } }

        public double var4 { get { return recprotdomw_var4; } set { recprotdomw_var4 = value; } }

        //Constructor
        public clsRecordProductionTdoMw()
        {
            //RecordProductionThickness = new clsRecordProductionThickness();
            recprotdomw_codsec = 0;
            recprotdomw_fkRecordProduction = 0;
            recprotdomw_fkProductionOrder = 0;
            recprotdomw_TdoZ1 = 0;
            recprotdomw_TdoZ2 = 0;
            recprotdomw_TdoZ3 = 0;
            recprotdomw_TdoZ4 = 0;
            recprotdomw_TdoZ5 = 0;
            recprotdomw_TdoZ6 = 0;
            recprotdomw_TdoVelocityString = 0;
            recprotdomw_TdoAmperageString = 0;
            recprotdomw_TdoTimeLubrication = 0;
            recprotdomw_TdoUnTimeLubrication = 0;
            recprotdomw_var1 = 0;
            recprotdomw_var2 = 0;
            recprotdomw_var3 = 0;
            recprotdomw_var4 = 0;
        }
        //Method
        public bool save(string actions)
        {
            if (actions == "save")
            {
                try
                {
                    string queryString = "";

                    if (this.recprotdomwcodsec == 0)
                    {
                        queryString += "INSERT INTO bps_prod_recordproductionmwtdo (recprotdomw_fkRecordProduction, recprotdomw_fkProductionOrder, recprotdomw_TdoZ1, recprotdomw_TdoZ2, recprotdomw_TdoZ3, recprotdomw_TdoZ4, recprotdomw_TdoZ5, recprotdomw_TdoZ6, recprotdomw_TdoVelocityString, recprotdomw_TdoAmperageString, recprotdomw_TdoTimeLubircation, recprotdomw_TdoUnTimeLubircation)  VALUES (";
                        queryString += this.recprotdomwfkrecordproduction.ToString() + ",";
                        queryString += this.recprotdomwfkproductionorder.ToString() + ",";
                        queryString += this.tdomwz1.ToString() + ",";
                        queryString += this.tdomwz2.ToString() + ",";
                        queryString += this.tdomwz3.ToString() + ",";
                        queryString += this.tdomwz4.ToString() + ",";
                        queryString += this.tdomwz5.ToString() + ",";
                        queryString += this.tdomwz6.ToString() + ",";
                        queryString += this.tdomwvelocitystring.ToString() + ",";
                        queryString += this.tdomwamperagestring.ToString() + ",";
                        queryString += this.tdotimwlubrication.ToString() + ",";
                        queryString += this.tdountimelubrication.ToString() + ");";
                    }
                    else
                    {
                        queryString += "UPDATE bps_prod_recordproductionmwtdo SET recprotdomw_fkRecordProduction = " + this.recprotdomwfkrecordproduction.ToString();
                        queryString += ", recprotdomw_fkProductionOrder =" + this.recprotdomwfkproductionorder.ToString();
                        queryString += ", recprotdomw_TdoZ1 = " + this.tdomwz1.ToString();
                        queryString += ", recprotdomw_TdoZ2 = " + this.tdomwz2.ToString();
                        queryString += ", recprotdomw_TdoZ3 = " + this.tdomwz3.ToString();
                        queryString += ", recprotdomw_TdoZ4 = " + this.tdomwz4.ToString();
                        queryString += ", recprotdomw_TdoZ5 = " + this.tdomwz5.ToString();
                        queryString += ", recprotdomw_TdoZ6 = " + this.tdomwz6.ToString();
                        queryString += ", recprotdomw_TdoVelocityString = " + this.tdomwvelocitystring.ToString();
                        queryString += ", recprotdomw_TdoAmperageString = " + this.tdomwamperagestring.ToString();
                        queryString += ", recprotdomw_TdoTimeLubrication = " + this.tdotimwlubrication.ToString();
                        queryString += ", recprotdomw_TdoUnTimeLubrication = " + this.tdountimelubrication.ToString();
                        queryString += " WHERE recprotdomw_codsec = " + this.recprotdomwcodsec.ToString() + ";";
                    }
                    clsConnection.executeQuery(queryString);
                    return true;
                    //las otras tablas
                }
                catch (Exception ex)
                {
                    clsLog.addLog(ex, 3, "clsRecordProductionTdoMw.save");
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

                    if (this.recprotdomwcodsec == 0)
                    {
                        queryString += "INSERT INTO bps_prod_recordproductionmwtdo (recprotdomw_fkRecordProduction, recprotdomw_fkProductionOrder, recprotdomw_TdoZ1, recprotdomw_TdoZ2, recprotdomw_TdoZ3, recprotdomw_TdoZ4, recprotdomw_TdoZ5, recprotdomw_TdoZ6, recprotdomw_TdoVelocityString, recprotdomw_TdoAmperageString, recprotdomw_TdoTimeLubircation, recprotdomw_TdoUnTimeLubircation, recprotdomw_var1, recprotdomw_var2, recprotdomw_var3, recprotdomw_var4)  VALUES (";
                        queryString += this.recprotdomwfkrecordproduction.ToString() + ",";
                        queryString += this.recprotdomwfkproductionorder.ToString() + ",";
                        queryString += this.tdomwz1.ToString() + ",";
                        queryString += this.tdomwz2.ToString() + ",";
                        queryString += this.tdomwz3.ToString() + ",";
                        queryString += this.tdomwz4.ToString() + ",";
                        queryString += this.tdomwz5.ToString() + ",";
                        queryString += this.tdomwz6.ToString() + ",";
                        queryString += this.tdomwvelocitystring.ToString() + ",";
                        queryString += this.tdomwamperagestring.ToString() + ",";
                        queryString += this.tdotimwlubrication.ToString() + ",";
                        queryString += this.tdountimelubrication.ToString() + ",";
                        queryString += this.var1.ToString() + ",";
                        queryString += this.var2.ToString() + ",";
                        queryString += this.var3.ToString() + ",";
                        queryString += this.var4.ToString() + ");";
                    }
                    if (clsConnection.executeQuery(queryString))
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    clsLog.addLog(ex, 3, "clsRecordProductionTdoMw.save");
                    return false;
                }
            }
            else
                return false;
        }
    }
}
