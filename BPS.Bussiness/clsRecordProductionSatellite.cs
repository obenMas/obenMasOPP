using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BPS.Bussiness
{
    public class clsRecordProductionSatellite
    {
        //Atributes
        private clsRecordProductionTdo RecordProductionTdo;
        private int recprosat_codsec;
        private int recprosat_fkRecordProduction;
        private int recprosat_fkProductionOrder;
        private double recprosat_Sat1Z1;
        private double recprosat_Sat1Z2;
        private double recprosat_Sat1Z3;
        private double recprosat_Sat1Z4;
        private double recprosat_Sat1Z5;
        private double recprosat_Sat1filter;
        private double recprosat_Sat1melt;
        private double recprosat_Sat1beforefiter;
        private double recprosat_Sat1afterfilter;
        private double recprosat_Sat1pressure;
        private double recprosat_Sat1rpm;
        private double recprosat_Sat1amperage;
        private double recprosat_Sat1thickness;
        private double recprosat_Sat2Z1;
        private double recprosat_Sat2Z2;
        private double recprosat_Sat2Z3;
        private double recprosat_Sat2Z4;
        private double recprosat_Sat2Z5;
        private double recprosat_Sat2filter;
        private double recprosat_Sat2melt;
        private double recprosat_Sat2beforefilter;
        private double recprosat_Sat2afterfilter;
        private double recprosat_Sat2pressure;
        private double recprosat_Sat2rpm;
        private double recprosat_Sat2amperage;
        private double recprosat_Sat2thickness;

        //Properties
        public clsRecordProductionTdo recordproductiontdo { get { return RecordProductionTdo; } set { RecordProductionTdo = value; } }

        public int recprosatcodsec { get { return recprosat_codsec; } set { recprosat_codsec = value; } }

        public int recprosatfkrecordproduction { get { return recprosat_fkRecordProduction; } set { recprosat_fkRecordProduction = value; } }

        public int recprosatfkproductionorder { get { return recprosat_fkProductionOrder; } set { recprosat_fkProductionOrder = value; } }

        public double sat1z1 { get { return recprosat_Sat1Z1; } set { recprosat_Sat1Z1 = value; } }

        public double sat1z2 { get { return recprosat_Sat1Z2; } set { recprosat_Sat1Z2 = value; } }

        public double sat1z3 { get { return recprosat_Sat1Z3; } set { recprosat_Sat1Z3 = value; } }

        public double sat1z4 { get { return recprosat_Sat1Z4; } set { recprosat_Sat1Z4 = value; } }

        public double sat1z5 { get { return recprosat_Sat1Z5; } set { recprosat_Sat1Z5 = value; } }

        public double sat1filter { get { return recprosat_Sat1filter; } set { recprosat_Sat1filter = value; } }

        public double sat1melt { get { return recprosat_Sat1melt; } set { recprosat_Sat1melt = value; } }

        public double sat1beforefiter { get { return recprosat_Sat1beforefiter; } set { recprosat_Sat1beforefiter = value; } }

        public double sat1afterfilter { get { return recprosat_Sat1afterfilter; } set { recprosat_Sat1afterfilter = value; } }

        public double sat1pressure { get { return recprosat_Sat1pressure; } set { recprosat_Sat1pressure = value; } }

        public double sat1rpm { get { return recprosat_Sat1rpm; } set { recprosat_Sat1rpm = value; } }

        public double sat1amperage { get { return recprosat_Sat1amperage; } set { recprosat_Sat1amperage = value; } }

        public double sat1thickness { get { return recprosat_Sat1thickness; } set { recprosat_Sat1thickness = value; } }

        public double sat2z1 { get { return recprosat_Sat2Z1; } set { recprosat_Sat2Z1 = value; } }

        public double sat2z2 { get { return recprosat_Sat2Z2; } set { recprosat_Sat2Z2 = value; } }

        public double sat2z3 { get { return recprosat_Sat2Z3; } set { recprosat_Sat2Z3 = value; } }

        public double sat2z4 { get { return recprosat_Sat2Z4; } set { recprosat_Sat2Z4 = value; } }

        public double sat2z5 { get { return recprosat_Sat2Z5; } set { recprosat_Sat2Z5 = value; } }

        public double sat2filter { get { return recprosat_Sat2filter; } set { recprosat_Sat2filter = value; } }

        public double sat2melt { get { return recprosat_Sat2melt; } set { recprosat_Sat2melt = value; } }

        public double sat2beforefilter { get { return recprosat_Sat2beforefilter; } set { recprosat_Sat2beforefilter = value; } }

        public double sat2afterfilter { get { return recprosat_Sat2afterfilter; } set { recprosat_Sat2afterfilter = value; } }

        public double sat2pressure { get { return recprosat_Sat2pressure; } set { recprosat_Sat2pressure = value; } }

        public double sat2rpm { get { return recprosat_Sat2rpm; } set { recprosat_Sat2rpm = value; } }

        public double sat2amperage { get { return recprosat_Sat2amperage; } set { recprosat_Sat2amperage = value; } }

        public double sat2thickness { get { return recprosat_Sat2thickness; } set { recprosat_Sat2thickness = value; } }

        //Constructor
        public clsRecordProductionSatellite()
        {
            RecordProductionTdo = new clsRecordProductionTdo();
            recprosat_codsec = 0;
            recprosat_fkRecordProduction = 0;
            recprosat_fkProductionOrder = 0;
            recprosat_Sat1Z1 = 0;
            recprosat_Sat1Z2 = 0;
            recprosat_Sat1Z3 = 0;
            recprosat_Sat1Z4 = 0;
            recprosat_Sat1Z5 = 0;
            recprosat_Sat1filter = 0;
            recprosat_Sat1melt = 0;
            recprosat_Sat1beforefiter = 0;
            recprosat_Sat1afterfilter = 0;
            recprosat_Sat1pressure = 0;
            recprosat_Sat1rpm = 0;
            recprosat_Sat1amperage = 0;
            recprosat_Sat1thickness = 0;
            recprosat_Sat2Z1 = 0;
            recprosat_Sat2Z2 = 0;
            recprosat_Sat2Z3 = 0;
            recprosat_Sat2Z4 = 0;
            recprosat_Sat2Z5 = 0;
            recprosat_Sat2filter = 0;
            recprosat_Sat2melt = 0;
            recprosat_Sat2beforefilter = 0;
            recprosat_Sat2afterfilter = 0;
            recprosat_Sat2pressure = 0;
            recprosat_Sat2rpm = 0;
            recprosat_Sat2amperage = 0;
            recprosat_Sat2thickness = 0;
        }
        //Method
        public bool save(string actions)
        {
            if (actions == "save")
            {
                try
                {
                    string queryString = "";

                    if (this.recprosatcodsec == 0)
                    {
                        queryString += "INSERT INTO bps_prod_recordproductionsatellite (recprosat_fkRecordProduction, recprosat_fkProductionOrder, recprosat_Sat1Z1, recprosat_Sat1Z2, recprosat_Sat1Z3, recprosat_Sat1Z4, recprosat_Sat1Z5, recprosat_Sat1filter, recprosat_Sat1melt, recprosat_Sat1beforefiter, recprosat_Sat1afterfilter, recprosat_Sat1pressure, recprosat_Sat1rpm, recprosat_Sat1amperage, recprosat_Sat1thickness, recprosat_Sat2Z1, recprosat_Sat2Z2, recprosat_Sat2Z3, recprosat_Sat2Z4, recprosat_Sat2Z5, recprosat_Sat2filter, recprosat_Sat2melt, recprosat_Sat2beforefiter, recprosat_Sat2afterfilter, recprosat_Sat2pressure, recprosat_Sat2rpm, recprosat_Sat2amperage, recprosat_Sat2thickness)  VALUES (";
                        queryString += this.recprosatfkrecordproduction.ToString() + ",";
                        queryString += this.recprosatfkproductionorder.ToString() + ",";
                        queryString += this.sat1z1.ToString() + ",";
                        queryString += this.sat1z2.ToString() + ",";
                        queryString += this.sat1z3.ToString() + ",";
                        queryString += this.sat1z4.ToString() + ",";
                        queryString += this.sat1z5.ToString() + ",";
                        queryString += this.sat1filter.ToString() + ",";
                        queryString += this.sat1melt.ToString() + ",";
                        queryString += this.sat1beforefiter.ToString() + ",";
                        queryString += this.sat1afterfilter.ToString() + ",";
                        queryString += this.sat1pressure.ToString() + ",";
                        queryString += this.sat1rpm.ToString() + ",";
                        queryString += this.sat1amperage.ToString() + ",";
                        queryString += this.sat1thickness.ToString() + ",";
                        queryString += this.sat2z1.ToString() + ",";
                        queryString += this.sat2z2.ToString() + ",";
                        queryString += this.sat2z3.ToString() + ",";
                        queryString += this.sat2z4.ToString() + ",";
                        queryString += this.sat2z5.ToString() + ",";
                        queryString += this.sat2filter.ToString() + ",";
                        queryString += this.sat2melt.ToString() + ",";
                        queryString += this.sat2beforefilter.ToString() + ",";
                        queryString += this.sat2afterfilter.ToString() + ",";
                        queryString += this.sat2pressure.ToString() + ",";
                        queryString += this.sat2rpm.ToString() + ",";
                        queryString += this.sat2amperage.ToString() + ",";
                        queryString += this.sat2thickness.ToString() + ");";
                    }
                    else
                    {
                        queryString += "UPDATE bps_prod_recordproductionsatellite SET recprosat_fkRecordProduction = " + this.recprosatfkrecordproduction.ToString();
                        queryString += ", recprosat_fkProductionOrder =" + this.recprosatfkproductionorder.ToString();
                        queryString += ", recprosat_Sat1Z1 = " + this.sat1z1.ToString();
                        queryString += ", recprosat_Sat1Z2 = " + this.sat1z2.ToString();
                        queryString += ", recprosat_Sat1Z3 = " + this.sat1z3.ToString();
                        queryString += ", recprosat_Sat1Z4 = " + this.sat1z4.ToString();
                        queryString += ", recprosat_Sat1Z5 = " + this.sat1z5.ToString();
                        queryString += ", recprosat_Sat1filter = " + this.sat1filter.ToString();
                        queryString += ", recprosat_Sat1melt = " + this.sat1melt.ToString();
                        queryString += ", recprosat_Sat1beforefiter = " + this.sat1beforefiter.ToString();
                        queryString += ", recprosat_Sat1afterfilter = " + this.sat1afterfilter.ToString();
                        queryString += ", recprosat_Sat1pressure = " + this.sat1pressure.ToString();
                        queryString += ", recprosat_Sat1rpm = " + this.sat1rpm.ToString();
                        queryString += ", recprosat_Sat1amperage = " + this.sat1amperage.ToString();
                        queryString += ", recprosat_Sat1thickness = " + this.sat1thickness.ToString();
                        queryString += ", recprosat_Sat2Z1 = " + this.sat2z1.ToString();
                        queryString += ", recprosat_Sat2Z2 = " + this.sat2z2.ToString();
                        queryString += ", recprosat_Sat2Z3 = " + this.sat2z3.ToString();
                        queryString += ", recprosat_Sat2Z4 = " + this.sat2z4.ToString();
                        queryString += ", recprosat_Sat2Z5 = " + this.sat2z5.ToString();
                        queryString += ", recprosat_Sat2filter = " + this.sat2filter.ToString();
                        queryString += ", recprosat_Sat2melt = " + this.sat2melt.ToString();
                        queryString += ", recprosat_Sat2beforefiter = " + this.sat2beforefilter.ToString();
                        queryString += ", recprosat_Sat2afterfilter = " + this.sat2afterfilter.ToString();
                        queryString += ", recprosat_Sat2pressure = " + this.sat2pressure.ToString();
                        queryString += ", recprosat_Sat2rpm = " + this.sat2rpm.ToString();
                        queryString += ", recprosat_Sat2amperage = " + this.sat2amperage.ToString();
                        queryString += ", recprosat_Sat2thickness = " + this.sat2thickness.ToString();
                        queryString += " WHERE recprosat_codsec = " + this.recprosatcodsec.ToString() + ";";
                    }
                    clsConnection.executeQuery(queryString);
                    recordproductiontdo.save("save");
                    return true;
                    //las otras tablas
                }
                catch (Exception ex)
                {
                    clsLog.addLog(ex, 3, "clsRecordProductionSatellite.save");
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

                    if (this.recprosatcodsec == 0)
                    {
                        queryString += "INSERT INTO bps_prod_recordproductionsatellite (recprosat_fkRecordProduction, recprosat_fkProductionOrder, recprosat_Sat1Z1, recprosat_Sat1Z2, recprosat_Sat1Z3, recprosat_Sat1Z4, recprosat_Sat1Z5, recprosat_Sat1filter, recprosat_Sat1melt, recprosat_Sat1beforefiter, recprosat_Sat1afterfilter, recprosat_Sat1pressure, recprosat_Sat1rpm, recprosat_Sat1amperage, recprosat_Sat1thickness, recprosat_Sat2Z1, recprosat_Sat2Z2, recprosat_Sat2Z3, recprosat_Sat2Z4, recprosat_Sat2Z5, recprosat_Sat2filter, recprosat_Sat2melt, recprosat_Sat2beforefilter, recprosat_Sat2afterfilter, recprosat_Sat2pressure, recprosat_Sat2rpm, recprosat_Sat2amperage, recprosat_Sat2thickness)  VALUES (";
                        queryString += this.recprosatfkrecordproduction.ToString() + ",";
                        queryString += this.recprosatfkproductionorder.ToString() + ",";
                        queryString += this.sat1z1.ToString() + ",";
                        queryString += this.sat1z2.ToString() + ",";
                        queryString += this.sat1z3.ToString() + ",";
                        queryString += this.sat1z4.ToString() + ",";
                        queryString += this.sat1z5.ToString() + ",";
                        queryString += this.sat1filter.ToString() + ",";
                        queryString += this.sat1melt.ToString() + ",";
                        queryString += this.sat1beforefiter.ToString() + ",";
                        queryString += this.sat1afterfilter.ToString() + ",";
                        queryString += this.sat1pressure.ToString() + ",";
                        queryString += this.sat1rpm.ToString() + ",";
                        queryString += this.sat1amperage.ToString() + ",";
                        queryString += this.sat1thickness.ToString() + ",";
                        queryString += this.sat2z1.ToString() + ",";
                        queryString += this.sat2z2.ToString() + ",";
                        queryString += this.sat2z3.ToString() + ",";
                        queryString += this.sat2z4.ToString() + ",";
                        queryString += this.sat2z5.ToString() + ",";
                        queryString += this.sat2filter.ToString() + ",";
                        queryString += this.sat2melt.ToString() + ",";
                        queryString += this.sat2beforefilter.ToString() + ",";
                        queryString += this.sat2afterfilter.ToString() + ",";
                        queryString += this.sat2pressure.ToString() + ",";
                        queryString += this.sat2rpm.ToString() + ",";
                        queryString += this.sat2amperage.ToString() + ",";
                        queryString += this.sat2thickness.ToString() + ");";
                    }
                    if (clsConnection.executeQuery(queryString))
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    clsLog.addLog(ex, 3, "clsRecordProductionSatellite.save");
                    return false;
                }
            }
            else
                return false;
        }
    }
}
