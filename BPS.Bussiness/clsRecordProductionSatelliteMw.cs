using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BPS.Bussiness
{
    public class clsRecordProductionSatelliteMw
    {
        //Atributes
        //private clsRecordProductionTdo RecordProductionTdo;
        private int recprosatmw_codsec;
        private int recprosatmw_fkRecordProduction;
        private int recprosatmw_fkProductionOrder;
        private double recprosatmw_satellite25Z1;
        private double recprosatmw_satellite25Z2;
        private double recprosatmw_satellite25Z3;
        private double recprosatmw_satellite25Z4;
        private double recprosatmw_satellite25filter;
        private double recprosatmw_satellite25mp;
        private double recprosatmw_satellite25amperage;
        private double recprosatmw_satellite25pressurefilter;
        private double recprosatmw_satellite25capacity;
        private double recprosatmw_satellite25thickness;
        private double recprosatmw_satellite2Z1;
        private double recprosatmw_satellite2Z2;
        private double recprosatmw_satellite2Z3;
        private double recprosatmw_satellite2Z4;
        private double recprosatmw_satellite2filter;
        private double recprosatmw_satellite2mp;
        private double recprosatmw_satellite2amperage;
        private double recprosatmw_satellite2pressurefilter;
        private double recprosatmw_satellite2capacity;
        private double recprosatmw_satellite2thickness;


        //Properties
        //public clsRecordProductionTdo recordproductiontdo { get { return RecordProductionTdo; } set { RecordProductionTdo = value; } }

        public int recprosatmwcodsec { get { return recprosatmw_codsec; } set { recprosatmw_codsec = value; } }

        public int recprosatmwfkrecordproduction { get { return recprosatmw_fkRecordProduction; } set { recprosatmw_fkRecordProduction = value; } }

        public int recprosatmwfkproductionorder { get { return recprosatmw_fkProductionOrder; } set { recprosatmw_fkProductionOrder = value; } }

        public double sat25z1 { get { return recprosatmw_satellite25Z1; } set { recprosatmw_satellite25Z1 = value; } }

        public double sat25z2 { get { return recprosatmw_satellite25Z2; } set { recprosatmw_satellite25Z2 = value; } }

        public double sat25z3 { get { return recprosatmw_satellite25Z3; } set { recprosatmw_satellite25Z3 = value; } }

        public double sat25z4 { get { return recprosatmw_satellite25Z4; } set { recprosatmw_satellite25Z4 = value; } }

        public double sat25filter { get { return recprosatmw_satellite25filter; } set { recprosatmw_satellite25filter = value; } }

        public double sat25mp { get { return recprosatmw_satellite25mp; } set { recprosatmw_satellite25mp = value; } }

        public double sat25amperage { get { return recprosatmw_satellite25amperage; } set { recprosatmw_satellite25amperage = value; } }

        public double sat25pressurefilter { get { return recprosatmw_satellite25pressurefilter; } set { recprosatmw_satellite25pressurefilter = value; } }

        public double sat25capacity { get { return recprosatmw_satellite25capacity; } set { recprosatmw_satellite25capacity = value; } }

        public double sat25thickness { get { return recprosatmw_satellite25thickness; } set { recprosatmw_satellite25thickness = value; } }

        public double sat2z1 { get { return recprosatmw_satellite2Z1; } set { recprosatmw_satellite2Z1 = value; } }

        public double sat2z2 { get { return recprosatmw_satellite2Z2; } set { recprosatmw_satellite2Z2 = value; } }

        public double sat2z3 { get { return recprosatmw_satellite2Z3; } set { recprosatmw_satellite2Z3 = value; } }

        public double sat2z4 { get { return recprosatmw_satellite2Z4; } set { recprosatmw_satellite2Z4 = value; } }

        public double sat2filter { get { return recprosatmw_satellite2filter; } set { recprosatmw_satellite2filter = value; } }

        public double sat2mp { get { return recprosatmw_satellite2mp; } set { recprosatmw_satellite2mp = value; } }

        public double sat2amperage { get { return recprosatmw_satellite2amperage; } set { recprosatmw_satellite2amperage = value; } }

        public double sat2pressurefilter { get { return recprosatmw_satellite2pressurefilter; } set { recprosatmw_satellite2pressurefilter = value; } }

        public double sat2capacity { get { return recprosatmw_satellite2capacity; } set { recprosatmw_satellite2capacity = value; } }

        public double sat2thickness { get { return recprosatmw_satellite2thickness; } set { recprosatmw_satellite2thickness = value; } }

        //Constructor
        public clsRecordProductionSatelliteMw()
        {
            //RecordProductionTdo = new clsRecordProductionTdo();
            recprosatmw_codsec = 0;
            recprosatmw_fkRecordProduction = 0;
            recprosatmw_fkProductionOrder = 0;
            recprosatmw_satellite25Z1 = 0;
            recprosatmw_satellite25Z2 = 0;
            recprosatmw_satellite25Z3 = 0;
            recprosatmw_satellite25Z4 = 0;
            recprosatmw_satellite25filter = 0;
            recprosatmw_satellite25mp = 0;
            recprosatmw_satellite25amperage = 0;
            recprosatmw_satellite25pressurefilter = 0;
            recprosatmw_satellite25capacity = 0;
            recprosatmw_satellite25thickness = 0;
            recprosatmw_satellite2Z1 = 0;
            recprosatmw_satellite2Z2 = 0;
            recprosatmw_satellite2Z3 = 0;
            recprosatmw_satellite2Z4 = 0;
            recprosatmw_satellite2filter = 0;
            recprosatmw_satellite2mp = 0;
            recprosatmw_satellite2amperage = 0;
            recprosatmw_satellite2pressurefilter = 0;
            recprosatmw_satellite2capacity = 0;
            recprosatmw_satellite2thickness = 0;
            
        }
        //Method
        public bool save(string actions)
        {
            if (actions == "save")
            {
                try
                {
                    string queryString = "";

                    if (this.recprosatmwcodsec == 0)
                    {
                        queryString += "INSERT INTO bps_prod_recorproductionmwsatellite (recprosatmw_fkRecordProduction, recprosatmw_fkProductionOrder, recprosatmw_satellite25Z1, recprosatmw_satellite25Z2, recprosatmw_satellite25Z3, recprosatmw_satellite25Z4, recprosatmw_satellite25filter, recprosatmw_satellite25mp, recprosatmw_satellite25amperage, recprosatmw_satellite25pressurefilter, recprosatmw_satellite25capacity, recprosatmw_satellite25thickness, recprosatmw_satellite2Z1, recprosatmw_satellite2Z2, recprosatmw_satellite2Z3, recprosatmw_satellite2Z4, recprosatmw_satellite2filter, recprosatmw_satellite2mp, recprosatmw_satellite2amperage, recprosatmw_satellite2pressurefilter, recprosatmw_satellite2capacity, recprosatmw_satellite2thickness)  VALUES (";
                        queryString += this.recprosatmwfkrecordproduction.ToString() + ",";
                        queryString += this.recprosatmwfkproductionorder.ToString() + ",";
                        queryString += this.sat25z1.ToString() + ",";
                        queryString += this.sat25z2.ToString() + ",";
                        queryString += this.sat25z3.ToString() + ",";
                        queryString += this.sat25z4.ToString() + ",";
                        queryString += this.sat25filter.ToString() + ",";
                        queryString += this.sat25mp.ToString() + ",";
                        queryString += this.sat25amperage.ToString() + ",";
                        queryString += this.sat25pressurefilter.ToString() + ",";
                        queryString += this.sat25capacity.ToString() + ",";
                        queryString += this.sat25thickness.ToString() + ",";
                        queryString += this.sat2z1.ToString() + ",";
                        queryString += this.sat2z2.ToString() + ",";
                        queryString += this.sat2z3.ToString() + ",";
                        queryString += this.sat2z4.ToString() + ",";
                        queryString += this.sat2filter.ToString() + ",";
                        queryString += this.sat2mp.ToString() + ",";
                        queryString += this.sat2amperage.ToString() + ",";
                        queryString += this.sat2pressurefilter.ToString() + ",";
                        queryString += this.sat2capacity.ToString() + ",";
                        queryString += this.sat2thickness.ToString() + ");";
                    }
                    else
                    {
                        queryString += "UPDATE bps_prod_recorproductionmwsatellite SET recprosatmw_fkRecordProduction = " + this.recprosatmwfkrecordproduction.ToString();
                        queryString += ", recprosatmw_fkProductionOrder =" + this.recprosatmwfkproductionorder.ToString();
                        queryString += ", recprosatmw_satellite25Z1 = " + this.sat25z1.ToString();
                        queryString += ", recprosatmw_satellite25Z2 = " + this.sat25z2.ToString();
                        queryString += ", recprosatmw_satellite25Z3 = " + this.sat25z3.ToString();
                        queryString += ", recprosatmw_satellite25Z4 = " + this.sat25z4.ToString();
                        queryString += ", recprosatmw_satellite25filter = " + this.sat25filter.ToString();
                        queryString += ", recprosatmw_satellite25mp = " + this.sat25mp.ToString();
                        queryString += ", recprosatmw_satellite25amperage = " + this.sat25amperage.ToString();
                        queryString += ", recprosatmw_satellite25pressurefilter = " + this.sat25pressurefilter.ToString();
                        queryString += ", recprosatmw_satellite25capacity = " + this.sat25capacity.ToString();
                        queryString += ", recprosatmw_satellite25thickness = " + this.sat25thickness.ToString();
                        queryString += ", recprosatmw_satellite2Z1 = " + this.sat2z1.ToString();
                        queryString += ", recprosatmw_satellite2Z2 = " + this.sat2z2.ToString();
                        queryString += ", recprosatmw_satellite2Z3 = " + this.sat2z3.ToString();
                        queryString += ", recprosatmw_satellite2Z4 = " + this.sat2z4.ToString();
                        queryString += ", recprosatmw_satellite2filter = " + this.sat2filter.ToString();
                        queryString += ", recprosatmw_satellite2mp = " + this.sat2mp.ToString();
                        queryString += ", recprosatmw_satellite2amperage = " + this.sat2amperage.ToString();
                        queryString += ", recprosatmw_satellite2pressurefilter = " + this.sat2pressurefilter.ToString();
                        queryString += ", recprosatmw_satellite2capacity = " + this.sat2capacity.ToString();
                        queryString += ", recprosatmw_satellite2thickness = " + this.sat2thickness.ToString();
                        queryString += " WHERE recprosatmwcodsec = " + this.recprosatmwcodsec.ToString() + ";";
                    }
                    clsConnection.executeQuery(queryString);
                    return true;
                }
                catch (Exception ex)
                {
                    clsLog.addLog(ex, 3, "clsRecordProductionMwSatellite.save");
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

                    if (this.recprosatmwcodsec == 0)
                    {
                        queryString += "INSERT INTO bps_prod_recorproductionmwsatellite (recprosatmw_fkRecordProduction, recprosatmw_fkProductionOrder, recprosatmw_satellite25Z1, recprosatmw_satellite25Z2, recprosatmw_satellite25Z3, recprosatmw_satellite25Z4, recprosatmw_satellite25filter, recprosatmw_satellite25mp, recprosatmw_satellite25amperage, recprosatmw_satellite25pressurefilter, recprosatmw_satellite25capacity, recprosatmw_satellite25thickness, recprosatmw_satellite2Z1, recprosatmw_satellite2Z2, recprosatmw_satellite2Z3, recprosatmw_satellite2Z4, recprosatmw_satellite2filter, recprosatmw_satellite2mp, recprosatmw_satellite2amperage, recprosatmw_satellite2pressurefilter, recprosatmw_satellite2capacity, recprosatmw_satellite2thickness)  VALUES (";
                        queryString += this.recprosatmwfkrecordproduction.ToString() + ",";
                        queryString += this.recprosatmwfkproductionorder.ToString() + ",";
                        queryString += this.sat25z1.ToString() + ",";
                        queryString += this.sat25z2.ToString() + ",";
                        queryString += this.sat25z3.ToString() + ",";
                        queryString += this.sat25z4.ToString() + ",";
                        queryString += this.sat25filter.ToString() + ",";
                        queryString += this.sat25mp.ToString() + ",";
                        queryString += this.sat25amperage.ToString() + ",";
                        queryString += this.sat25pressurefilter.ToString() + ",";
                        queryString += this.sat25capacity.ToString() + ",";
                        queryString += this.sat25thickness.ToString() + ",";
                        queryString += this.sat2z1.ToString() + ",";
                        queryString += this.sat2z2.ToString() + ",";
                        queryString += this.sat2z3.ToString() + ",";
                        queryString += this.sat2z4.ToString() + ",";
                        queryString += this.sat2filter.ToString() + ",";
                        queryString += this.sat2mp.ToString() + ",";
                        queryString += this.sat2amperage.ToString() + ",";
                        queryString += this.sat2pressurefilter.ToString() + ",";
                        queryString += this.sat2capacity.ToString() + ",";
                        queryString += this.sat2thickness.ToString() + ");";
                    }
                    if (clsConnection.executeQuery(queryString))
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    clsLog.addLog(ex, 3, "clsRecordProductionSatelliteMw.save");
                    return false;
                }
            }
            else
                return false;
        }
    }
}
