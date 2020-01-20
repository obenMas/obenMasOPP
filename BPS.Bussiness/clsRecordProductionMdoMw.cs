using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BPS.Bussiness
{
    public class clsRecordProductionMdoMw
    {
        //Atributes
        //private clsRecordProductionPressure RecordProductionPressure;
        private int recpromdomw_codsec;
        private int recpromdomw_fkRecordProduction;
        private int recpromdomw_fkProductionOrder;
        private double recpromdomw_MdoZ1;
        private double recpromdomw_MdoZ2;
        private double recpromdomw_MdoZ3;
        private double recpromdomw_MdoZ4;
        private double recpromdomw_MdoZ5;
        private double recpromdomw_MdoZ6;
        private double recpromdomw_MdoZ7;
        private double recpromdomw_MdoSpeedphsl;
        private double recpromdomw_MdoAmperagephsl;
        private double recpromdomw_MdoSpeedfd1;
        private double recpromdomw_MdoAmperagefd1;
        private double recpromdomw_MdoSpeedfd2;
        private double recpromdomw_MdoAmperagefd2;

        
        //Properties
        //public clsRecordProductionPressure recordproductionpressure { get { return RecordProductionPressure; } set { RecordProductionPressure = value; } }

        public int recpromdomwcodsec { get { return recpromdomw_codsec; } set { recpromdomw_codsec = value; } }

        public int recpromdomwfkrecordproduction { get { return recpromdomw_fkRecordProduction; } set { recpromdomw_fkRecordProduction = value; } }

        public int recpromdomwfkproductionorder { get { return recpromdomw_fkProductionOrder; } set { recpromdomw_fkProductionOrder = value; } }

        public double mdoz1 { get { return recpromdomw_MdoZ1; } set { recpromdomw_MdoZ1 = value; } }

        public double mdoz2 { get { return recpromdomw_MdoZ2; } set { recpromdomw_MdoZ2 = value; } }

        public double mdoz3 { get { return recpromdomw_MdoZ3; } set { recpromdomw_MdoZ3 = value; } }

        public double mdoz4 { get { return recpromdomw_MdoZ4; } set { recpromdomw_MdoZ4 = value; } }

        public double mdoz5 { get { return recpromdomw_MdoZ5; } set { recpromdomw_MdoZ5 = value; } }

        public double mdoz6 { get { return recpromdomw_MdoZ6; } set { recpromdomw_MdoZ6 = value; } }

        public double mdoz7 { get { return recpromdomw_MdoZ7; } set { recpromdomw_MdoZ7 = value; } }

        public double mdoSpeedphsl { get { return recpromdomw_MdoSpeedphsl; } set { recpromdomw_MdoSpeedphsl = value; } }

        public double mdoamperagephsl { get { return recpromdomw_MdoAmperagephsl; } set { recpromdomw_MdoAmperagephsl = value; } }

        public double mdospeedfd1 { get { return recpromdomw_MdoSpeedfd1; } set { recpromdomw_MdoSpeedfd1 = value; } }

        public double mdoamperagefd1 { get { return recpromdomw_MdoAmperagefd1; } set { recpromdomw_MdoAmperagefd1 = value; } }

        public double mdospeedfd2 { get { return recpromdomw_MdoSpeedfd2; } set { recpromdomw_MdoSpeedfd2 = value; } }

        public double mdoamperagefd2 { get { return recpromdomw_MdoAmperagefd2; } set { recpromdomw_MdoAmperagefd2 = value; } }
        
        
        //Constructor
        public clsRecordProductionMdoMw()
        {
            //recordproductionpressure = new clsRecordProductionPressure();
            recpromdomw_codsec = 0;
            recpromdomw_fkRecordProduction = 0;
            recpromdomw_fkProductionOrder = 0;
            recpromdomw_MdoZ1 = 0;
            recpromdomw_MdoZ2 = 0;
            recpromdomw_MdoZ3 = 0;
            recpromdomw_MdoZ4 = 0;
            recpromdomw_MdoZ5 = 0;
            recpromdomw_MdoZ6 = 0;
            recpromdomw_MdoZ7 = 0;
            recpromdomw_MdoAmperagephsl = 0;
            recpromdomw_MdoAmperagefd1 = 0;
            recpromdomw_MdoAmperagefd2 = 0;
            recpromdomw_MdoSpeedphsl = 0;
            recpromdomw_MdoSpeedfd1 = 0;
            recpromdomw_MdoSpeedfd2 = 0;
        }
        //Methods
        public bool save(string actions)
        {
            if (actions == "save")
            {
                try
                {
                    string queryString = "";

                    if (this.recpromdomwcodsec == 0)
                    {
                        queryString += "INSERT INTO bps_prod_recordproductionmwmdo (recpromdomw_fkRecordProduction, recpromdomw_fkProductionOrder, recpromdomw_MdoZ1, recpromdomw_MdoZ2, recpromdomw_MdoZ3, recpromdomw_MdoZ4, recpromdomw_MdoZ5, recpromdomw_MdoZ6, recpromdomw_MdoZ7, recpromdomw_MdoAmperagephsl, recpromdomw_MdoAmperagefd1, recpromdomw_MdoAmperagefd2, recpromdomw_MdoSpeedphsl, recpromdomw_MdoSpeedfd1, recpromdomw_MdoSpeedfd2) VALUES (";
                        queryString += this.recpromdomwfkrecordproduction.ToString() + ",";
                        queryString += this.recpromdomwfkproductionorder.ToString() + ",";
                        queryString += this.mdoz1.ToString() + ",";
                        queryString += this.mdoz2.ToString() + ",";
                        queryString += this.mdoz3.ToString() + ",";
                        queryString += this.mdoz4.ToString() + ",";
                        queryString += this.mdoz5.ToString() + ",";
                        queryString += this.mdoz6.ToString() + ",";
                        queryString += this.mdoz7.ToString() + ",";
                        queryString += this.mdoamperagephsl.ToString() + ",";
                        queryString += this.mdoamperagefd1.ToString() + ",";
                        queryString += this.mdoamperagefd2.ToString() + ",";
                        queryString += this.mdoSpeedphsl.ToString() + ",";
                        queryString += this.mdospeedfd1.ToString() + ",";
                        queryString += this.mdospeedfd2.ToString() + ");";
                    }
                    else
                    {
                        queryString += "UPDATE bps_prod_recordproductionmwmdo SET recpromdomw_fkRecordProduction = " + this.recpromdomwfkrecordproduction.ToString();
                        queryString += ", recpromdomw_fkProductionOrder =" + this.recpromdomwfkproductionorder.ToString();
                        queryString += ", recpromdomw_MdoZ1 = " + this.mdoz1.ToString();
                        queryString += ", recpromdomw_MdoZ2 = " + this.mdoz2.ToString();
                        queryString += ", recpromdomw_MdoZ3 = " + this.mdoz3.ToString();
                        queryString += ", recpromdomw_MdoZ4 = " + this.mdoz4.ToString();
                        queryString += ", recpromdomw_MdoZ5 = " + this.mdoz5.ToString();
                        queryString += ", recpromdomw_MdoZ6 = " + this.mdoz6.ToString();
                        queryString += ", recpromdomw_MdoZ7 = " + this.mdoz7.ToString();
                        queryString += ", recpromdomw_MdoAmperagephsl = " + this.mdoamperagephsl.ToString();
                        queryString += ", recpromdomw_MdoAmperagefd1 = " + this.mdoamperagefd1.ToString();
                        queryString += ", recpromdomw_MdoAmperagefd2 = " + this.mdoamperagefd2.ToString();
                        queryString += ", recpromdomw_MdoSpeedphsl = " + this.mdoSpeedphsl.ToString();
                        queryString += ", recpromdomw_MdoSpeedfd1 = " + this.mdospeedfd1.ToString();
                        queryString += ", recpromdomw_MdoSpeedfd2 = " + this.mdospeedfd2.ToString();
                        queryString += " WHERE recpromdomw_codsec = " + this.recpromdomwcodsec.ToString() + ";";
                    }
                    clsConnection.executeQuery(queryString);
                    return true;
                }
                catch (Exception ex)
                {
                    clsLog.addLog(ex, 3, "clsRecordProductionMdoMw.save");
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

                    if (this.recpromdomwcodsec == 0)
                    {
                        queryString += "INSERT INTO bps_prod_recordproductionmwmdo (recpromdomw_fkRecordProduction, recpromdomw_fkProductionOrder, recpromdomw_MdoZ1, recpromdomw_MdoZ2, recpromdomw_MdoZ3, recpromdomw_MdoZ4, recpromdomw_MdoZ5, recpromdomw_MdoZ6, recpromdomw_MdoZ7, recpromdomw_MdoAmperagephsl, recpromdomw_MdoAmperagefd1, recpromdomw_MdoAmperagefd2, recpromdomw_MdoSpeedphsl, recpromdomw_MdoSpeedfd1, recpromdomw_MdoSpeedfd2) VALUES (";
                        queryString += this.recpromdomwfkrecordproduction.ToString() + ",";
                        queryString += this.recpromdomwfkproductionorder.ToString() + ",";
                        queryString += this.mdoz1.ToString() + ",";
                        queryString += this.mdoz2.ToString() + ",";
                        queryString += this.mdoz3.ToString() + ",";
                        queryString += this.mdoz4.ToString() + ",";
                        queryString += this.mdoz5.ToString() + ",";
                        queryString += this.mdoz6.ToString() + ",";
                        queryString += this.mdoz7.ToString() + ",";
                        queryString += this.mdoamperagephsl.ToString() + ",";
                        queryString += this.mdoamperagefd1.ToString() + ",";
                        queryString += this.mdoamperagefd2.ToString() + ",";
                        queryString += this.mdoSpeedphsl.ToString() + ",";
                        queryString += this.mdospeedfd1.ToString() + ",";
                        queryString += this.mdospeedfd2.ToString() + ");";
                    }
                    if (clsConnection.executeQuery(queryString))
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    clsLog.addLog(ex, 3, "clsRecordProductionMdoMw.save");
                    return false;
                }
            }
            else
                return false;
        }
    }
}
