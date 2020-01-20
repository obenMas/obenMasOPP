using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    public class clsRecordProductionHeadMw
    {
        //private clsRecordProductionLaboratory RecordProductionLaboratory;

        //Atributes
        private int recproheamw_codsec;
        private int recproheamw_fkRecordProduction;
        private int recproheamw_fkProductionOrder;
        private double recproheamw_headZ1;
        private double recproheamw_headZ2;
        private double recproheamw_headZ3;
        private double recproheamw_headZ4;
        private double recproheamw_headZ5;
        private double recproheamw_headtemperaturecylinder;
        private double recproheamw_headtemperaturetub;
        private double recproheamw_headtemperaturemp;
        private double recproheamw_headtemperatureamperage;
        private double recproheamw_headangle;
        private double recproheamw_headheight;
        private double recproheamw_headcr;
        private double recproheamw_headmdo;
        private string recprohea_headtemp;
        private double recproheamw_tractor;
        private double recproheamw_pression;
        
        //Properties
        //public clsRecordProductionLaboratory recordproductionlaboratory { get { return RecordProductionLaboratory; } set { RecordProductionLaboratory = value; } }

        public int recproheamwcodsec { get { return recproheamw_codsec; } set { recproheamw_codsec = value; } }

        public int recproheamwfkrecordproduction { get { return recproheamw_fkRecordProduction; } set { recproheamw_fkRecordProduction = value; } }

        public int recproheamwfkproductionorder { get { return recproheamw_fkProductionOrder; } set { recproheamw_fkProductionOrder = value; } }

        public double headmwz1 { get { return recproheamw_headZ1; } set { recproheamw_headZ1 = value; } }

        public double headmwz2 { get { return recproheamw_headZ2; } set { recproheamw_headZ2 = value; } }

        public double headmwz3 { get { return recproheamw_headZ3; } set { recproheamw_headZ3 = value; } }

        public double headmwz4 { get { return recproheamw_headZ4; } set { recproheamw_headZ4 = value; } }

        public double headmwz5 { get { return recproheamw_headZ5; } set { recproheamw_headZ5 = value; } }

        public double headmwtemperaturecylinder { get { return recproheamw_headtemperaturecylinder; } set { recproheamw_headtemperaturecylinder = value; } }

        public double headmwtemperaturetub { get { return recproheamw_headtemperaturetub; } set { recproheamw_headtemperaturetub = value; } }

        public double headmwtemperaturemp { get { return recproheamw_headtemperaturemp; } set { recproheamw_headtemperaturemp = value; } }

        public double headmwtemperatureamperage { get { return recproheamw_headtemperatureamperage; } set { recproheamw_headtemperatureamperage = value; } }

        public double headmwangle { get { return recproheamw_headangle; } set { recproheamw_headangle = value; } }

        public double headmwheight { get { return recproheamw_headheight; } set { recproheamw_headheight = value; } }

        public double headmwcr { get { return recproheamw_headcr; } set { recproheamw_headcr = value; } }

        public double headmwmdo { get { return recproheamw_headmdo; } set { recproheamw_headmdo = value; } }

        public string headmwtemp { get { return recprohea_headtemp; } set { recprohea_headtemp = value; } }

        public double tractor { get { return recproheamw_tractor; } set { recproheamw_tractor = value; } }

        public double pression { get { return recproheamw_pression; } set { recproheamw_pression = value; } }
        
        //Constructor
        public clsRecordProductionHeadMw()
        {
            recproheamw_codsec = 0;
            recproheamw_fkRecordProduction = 0;
            recproheamw_fkProductionOrder = 0;
            recproheamw_headZ1 = 0;
            recproheamw_headZ2 = 0;
            recproheamw_headZ3 = 0;
            recproheamw_headZ4 = 0;
            recproheamw_headZ5 = 0;
            recproheamw_headtemperaturecylinder = 0;
            recproheamw_headtemperaturetub = 0;
            recproheamw_headtemperaturemp = 0;
            recproheamw_headtemperatureamperage = 0;
            recproheamw_headangle = 0;
            recproheamw_headheight = 0;
            recproheamw_headcr = 0;
            recproheamw_headmdo = 0;
            recprohea_headtemp = "";
            recproheamw_pression = 0;
            recproheamw_tractor = 0;
        }
        //Methods
        public bool save(string action)
        {
            if (action == "save")
            {
                try
                {
                    string queryString = "";

                    if (this.recproheamwcodsec == 0)
                    {
                        queryString += "INSERT INTO bps_prod_recordproductionmwhead (recproheamw_fkRecordProduction, recproheamw_fkProductionOrder, recproheamw_headZ1, recproheamw_headZ2, recproheamw_headZ3, recproheamw_headZ4, recproheamw_headZ5, recproheamw_headangle, recproheamw_headcr, recproheamw_headheight, recproheamw_headmdo, recproheamw_headtemp, recproheamw_headtemperatureamperage, recproheamw_headtemperaturecylinder, recproheamw_headtemperaturermp, recproheamw_headtemperaturetub) VALUES (";
                        queryString += this.recproheamwfkrecordproduction.ToString() + ",";
                        queryString += this.recproheamwfkproductionorder.ToString() + ",";
                        queryString += this.headmwz1.ToString() + ",";
                        queryString += this.headmwz2.ToString() + ",";
                        queryString += this.headmwz3.ToString() + ",";
                        queryString += this.headmwz4.ToString() + ",";
                        queryString += this.headmwz5.ToString() + ",";
                        queryString += this.headmwangle.ToString() + ",";
                        queryString += this.headmwcr.ToString() + ",";
                        queryString += this.headmwheight.ToString() + ",";
                        queryString += this.headmwmdo.ToString() + ",";
                        queryString += "'" + this.headmwtemp + "',";
                        queryString += this.headmwtemperatureamperage.ToString() + ",";
                        queryString += this.headmwtemperaturecylinder.ToString() + ",";
                        queryString += this.headmwtemperaturemp.ToString() + ",";
                        queryString += this.headmwtemperaturetub.ToString() + ");";
                    }
                    else
                    {
                        queryString += "UPDATE bps_prod_recordproductionmwhead SET recproheamw_fkRecordProduction = " + this.recproheamwfkrecordproduction.ToString();
                        queryString += ", recproheamw_fkProductionOrder =" + this.recproheamwfkproductionorder.ToString();
                        queryString += ", recproheamw_headZ1 = " + this.headmwz1.ToString();
                        queryString += ", recproheamw_headZ2 = " + this.headmwz2.ToString();
                        queryString += ", recproheamw_headZ3 = " + this.headmwz3.ToString();
                        queryString += ", recproheamw_headZ4 = " + this.headmwz4.ToString();
                        queryString += ", recproheamw_headZ5 = " + this.headmwz5.ToString();
                        queryString += ", recproheamw_headangle = " + this.headmwangle.ToString();
                        queryString += ", recproheamw_headcr = " + this.headmwcr.ToString();
                        queryString += ", recproheamw_headheight = " + this.headmwheight.ToString();
                        queryString += ", recproheamw_headmdo = " + this.headmwmdo.ToString();
                        queryString += ", recproheamw_headtemp = '" + this.headmwtemp + "' ";
                        queryString += ", recproheamw_headtemperatureamperage = " + this.headmwtemperatureamperage.ToString();
                        queryString += ", recproheamw_headtemperaturecylinder = " + this.headmwtemperaturecylinder.ToString();
                        queryString += ", recproheamw_headtemperaturermp = " + this.headmwtemperaturemp.ToString();
                        queryString += ", recproheamw_headtemperaturetub = " + this.headmwtemperaturetub.ToString();
                        queryString += " WHERE recproheamw_codsec = " + this.recproheamwcodsec.ToString() + ";";
                    }
                    clsConnection.executeQuery(queryString);
                    return true;
                }
                catch (Exception ex)
                {
                    clsLog.addLog(ex, 3, "clsRecordProductionHeadMw.save");
                    return false;
                }
            }
            else
                return false;
        }

        public bool saves(string action)
        {
            if (action == "save")
            {
                try
                {
                    string queryString = "";

                    if (this.recproheamwcodsec == 0)
                    {
                        queryString += "INSERT INTO bps_prod_recordproductionmwhead (recproheamw_fkRecordProduction, recproheamw_fkProductionOrder, recproheamw_headZ1, recproheamw_headZ2, recproheamw_headZ3, recproheamw_headZ4, recproheamw_headZ5, recproheamw_headangle, recproheamw_headcr, recproheamw_headheight, recproheamw_headmdo, recproheamw_headtemp, recproheamw_headtemperatureamperage, recproheamw_headtemperaturecylinder, recproheamw_headtemperaturermp, recproheamw_headtemperaturetub, recproheamw_tractor, recproheamw_pression) VALUES (";
                        queryString += this.recproheamwfkrecordproduction.ToString() + ",";
                        queryString += this.recproheamwfkproductionorder.ToString() + ",";
                        queryString += this.headmwz1.ToString() + ",";
                        queryString += this.headmwz2.ToString() + ",";
                        queryString += this.headmwz3.ToString() + ",";
                        queryString += this.headmwz4.ToString() + ",";
                        queryString += this.headmwz5.ToString() + ",";
                        queryString += this.headmwangle.ToString() + ",";
                        queryString += this.headmwcr.ToString() + ",";
                        queryString += this.headmwheight.ToString() + ",";
                        queryString += this.headmwmdo.ToString() + ",";
                        queryString += "'" + this.headmwtemp + "',";
                        queryString += this.headmwtemperatureamperage.ToString() + ",";
                        queryString += this.headmwtemperaturecylinder.ToString() + ",";
                        queryString += this.headmwtemperaturemp.ToString() + ",";
                        queryString += this.headmwtemperaturetub.ToString() + ",";
                        queryString += this.tractor.ToString() + ",";
                        queryString += this.pression.ToString() + ");";
                    }
                    if (clsConnection.executeQuery(queryString))
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    clsLog.addLog(ex, 3, "clsRecordProductionHeadMw.save");
                    return false;
                }
            }
            else
                return false;
        }
    }
}