using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    public class clsRecordProductionHead
    {
        private clsRecordProductionLaboratory RecordProductionLaboratory;

        //Atributes
        private int recprohea_codsec;
        private int recprohea_fkRecordProduction;
        private int recprohea_fkProductionOrder;
        private double recprohea_headZ1;
        private double recprohea_headZ2;
        private double recprohea_headZ3;
        private double recprohea_headZ4;
        private double recprohea_headZ5;
        private double recprohea_headangle;
        private double recprohea_headcr;
        private double recprohea_headheight;
        private double recprohea_headmdo;
        private string recprohea_headtemp;
        private double recprohea_headtemperatureamperage;
        private double recprohea_headtemperaturecylinder;
        private double recprohea_headtemperaturermp;
        private double recprohea_headtemperaturetub;
        private double recprohea_headpression;
        
        
        //Properties
        public clsRecordProductionLaboratory recordproductionlaboratory { get { return RecordProductionLaboratory; } set { RecordProductionLaboratory = value; } }

        public int recproheacodsec { get { return recprohea_codsec; } set { recprohea_codsec = value; } }

        public int recproheafkrecordproduction { get { return recprohea_fkRecordProduction; } set { recprohea_fkRecordProduction = value; } }

        public int recproheafkproductionorder { get { return recprohea_fkProductionOrder; } set { recprohea_fkProductionOrder = value; } }

        public double headz1 { get { return recprohea_headZ1; } set { recprohea_headZ1 = value; } }

        public double headz2 { get { return recprohea_headZ2; } set { recprohea_headZ2 = value; } }

        public double headz3 { get { return recprohea_headZ3; } set { recprohea_headZ3 = value; } }

        public double headz4 { get { return recprohea_headZ4; } set { recprohea_headZ4 = value; } }

        public double headz5 { get { return recprohea_headZ5; } set { recprohea_headZ5 = value; } }

        public double headangle { get { return recprohea_headangle; } set { recprohea_headangle = value; } }

        public double headcr { get { return recprohea_headcr; } set { recprohea_headcr = value; } }

        public double headheight { get { return recprohea_headheight; } set { recprohea_headheight = value; } }

        public double headmdo { get { return recprohea_headmdo; } set { recprohea_headmdo = value; } }

        public string headtemp { get { return recprohea_headtemp; } set { recprohea_headtemp = value; } }

        public double headtemperatureamperage { get { return recprohea_headtemperatureamperage; } set { recprohea_headtemperatureamperage = value; } }

        public double headtemperaturecylinder { get { return recprohea_headtemperaturecylinder; } set { recprohea_headtemperaturecylinder = value; } }

        public double headtemperaturermp { get { return recprohea_headtemperaturermp; } set { recprohea_headtemperaturermp = value; } }

        public double headtemperaturetub { get { return recprohea_headtemperaturetub; } set { recprohea_headtemperaturetub = value; } }

        public double headpression { get { return recprohea_headpression; } set { recprohea_headpression = value; } }
        
        //Constructor
        public clsRecordProductionHead()
        {
            recordproductionlaboratory = new clsRecordProductionLaboratory();
            recprohea_codsec = 0;
            recprohea_fkRecordProduction = 0;
            recprohea_fkProductionOrder = 0;
            recprohea_headZ1 = 0;
            recprohea_headZ2 = 0;
            recprohea_headZ3 = 0;
            recprohea_headZ4 = 0;
            recprohea_headZ5 = 0;
            recprohea_headangle = 0;
            recprohea_headcr = 0;
            recprohea_headheight = 0;
            recprohea_headmdo = 0;
            recprohea_headtemp = "";
            recprohea_headtemperatureamperage = 0;
            recprohea_headtemperaturecylinder = 0;
            recprohea_headtemperaturermp = 0;
            recprohea_headtemperaturetub = 0;
            recprohea_headpression = 0;
        }
        //Methods
        public bool save(string action)
        {
            if (action == "save")
            {
                try
                {
                    string queryString = "";

                    if (this.recproheacodsec == 0)
                    {
                        queryString += "INSERT INTO bps_prod_recordproductionhead (recprohea_fkRecordProduction, recprohea_fkProductionOrder, recprohea_headZ1, recprohea_headZ2, recprohea_headZ3, recprohea_headZ4, recprohea_headZ5, recprohea_headtemperaturecylinder, recprohea_headtemperaturetub, recprohea_headtemperaturermp, recprohea_headtemperatureamperage, recprohea_headangle, recprohea_headheight, recprohea_headcr, recprohea_headmdo, recprohea_headtemp) VALUES (";
                        queryString += this.recproheafkrecordproduction.ToString() + ",";
                        queryString += this.recproheafkproductionorder.ToString() + ",";
                        queryString += this.headz1.ToString() + ",";
                        queryString += this.headz2.ToString() + ",";
                        queryString += this.headz3.ToString() + ",";
                        queryString += this.headz4.ToString() + ",";
                        queryString += this.headz5.ToString() + ",";
                        queryString += this.headtemperaturecylinder.ToString() + ",";
                        queryString += this.headtemperaturetub.ToString() + ",";
                        queryString += this.headtemperaturermp.ToString() + ",";
                        queryString += this.headtemperatureamperage.ToString() + ",";
                        queryString += this.headangle.ToString() + ",";
                        queryString += this.headheight.ToString() + ",";
                        queryString += this.headcr.ToString() + ",";
                        queryString += this.headmdo.ToString() + ",";
                        queryString += "'" + this.headtemp + "');";
                    }
                    else
                    {
                        queryString += "UPDATE bps_prod_recordproductionhead SET recprohea_fkRecordProduction = " + this.recproheafkrecordproduction.ToString();
                        queryString += ", recprohea_fkProductionOrder =" + this.recproheafkproductionorder.ToString();
                        queryString += ", recprohea_headZ1 = " + this.headz1.ToString();
                        queryString += ", recprohea_headZ2 = " + this.headz2.ToString();
                        queryString += ", recprohea_headZ3 = " + this.headz3.ToString();
                        queryString += ", recprohea_headZ4 = " + this.headz4.ToString();
                        queryString += ", recprohea_headZ5 = " + this.headz5.ToString();
                        queryString += ", recprohea_headtemperaturecylinder = " + this.headtemperaturecylinder.ToString();
                        queryString += ", recprohea_headtemperaturetub = " + this.headtemperaturetub.ToString();
                        queryString += ", recprohea_headtemperaturermp = " + this.headtemperaturermp.ToString();
                        queryString += ", recprohea_headtemperatureamperage = " + this.headtemperatureamperage.ToString();
                        queryString += ", recprohea_headangle = " + this.headangle.ToString();
                        queryString += ", recprohea_headheight = " + this.headheight.ToString();
                        queryString += ", recprohea_headcr = " + this.headcr.ToString();
                        queryString += ", recprohea_headmdo = " + this.headmdo.ToString();
                        queryString += ", recprohea_headtemp = '" + this.headtemp + "' ";
                        queryString += " WHERE recprohea_codsec = " + this.recproheacodsec.ToString() + ";";
                    }
                    clsConnection.executeQuery(queryString);
                    recordproductionlaboratory.save("save");
                    return true;
                    //las otras tablas
                }
                catch (Exception ex)
                {
                    clsLog.addLog(ex, 3, "clsRecordProductionHead.save");
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

                    if (this.recproheacodsec == 0)
                    {
                        queryString += "INSERT INTO bps_prod_recordproductionhead (recprohea_fkRecordProduction, recprohea_fkProductionOrder, recprohea_headZ1, recprohea_headZ2, recprohea_headZ3, recprohea_headZ4, recprohea_headZ5, recprohea_headtemperaturecylinder, recprohea_headtemperaturetub, recprohea_headtemperaturermp, recprohea_headtemperatureamperage, recprohea_headangle, recprohea_headheight, recprohea_headcr, recprohea_headmdo, recprohea_headtemp, recprohea_headpression) VALUES (";
                        queryString += this.recproheafkrecordproduction.ToString() + ",";
                        queryString += this.recproheafkproductionorder.ToString() + ",";
                        queryString += this.headz1.ToString() + ",";
                        queryString += this.headz2.ToString() + ",";
                        queryString += this.headz3.ToString() + ",";
                        queryString += this.headz4.ToString() + ",";
                        queryString += this.headz5.ToString() + ",";
                        queryString += this.headtemperaturecylinder.ToString() + ",";
                        queryString += this.headtemperaturetub.ToString() + ",";
                        queryString += this.headtemperaturermp.ToString() + ",";
                        queryString += this.headtemperatureamperage.ToString() + ",";
                        queryString += this.headangle.ToString() + ",";
                        queryString += this.headheight.ToString() + ",";
                        queryString += this.headcr.ToString() + ",";
                        queryString += this.headmdo.ToString() + ",";
                        queryString += "'" + this.headtemp.ToString() + "',";
                        queryString += this.headpression + ");";
                    }
                    if (clsConnection.executeQuery(queryString))
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    clsLog.addLog(ex, 3, "clsRecordProductionHead.save");
                    return false;
                }
            }
            else
                return false;
        }
    }
}