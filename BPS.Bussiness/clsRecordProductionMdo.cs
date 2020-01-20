using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BPS.Bussiness
{
    public class clsRecordProductionMdo
    {
        //Atributes
        private clsRecordProductionPressure RecordProductionPressure;
        private int recpromdo_codsec;
        private int recpromdo_fkRecordProduction;
        private int recpromdo_fkProductionOrder;
        private double recpromdo_Mdocirprin;
        private double recpromdo_MdoZ1;
        private double recpromdo_MdoZ2;
        private double recpromdo_MdoZ3;
        private double recpromdo_MdoZ4;
        private double recpromdo_Mdoest1;
        private double recpromdo_Mdoest2;
        private double recpromdo_Mdoestab;
        private double recpromdo_Mdo1velocity;
        private double recpromdo_Mdo1amperage;
        private double recpromdo_Mdo2velocity;
        private double recpromdo_Mdo2amperage;
        private double recpromdo_Mdofixation1;
        private double recpromdo_Mdofixation2;
        
        //Properties
        public clsRecordProductionPressure recordproductionpressure { get { return RecordProductionPressure; } set { RecordProductionPressure = value; } }

        public int recpromdocodsec { get { return recpromdo_codsec; } set { recpromdo_codsec = value; } }

        public int recpromdofkrecordproduction { get { return recpromdo_fkRecordProduction; } set { recpromdo_fkRecordProduction = value; } }

        public int recpromdofkproductionorder { get { return recpromdo_fkProductionOrder; } set { recpromdo_fkProductionOrder = value; } }

        public double mdocirprin { get { return recpromdo_Mdocirprin; } set { recpromdo_Mdocirprin = value; } }

        public double mdoz1 { get { return recpromdo_MdoZ1; } set { recpromdo_MdoZ1 = value; } }

        public double mdoz2 { get { return recpromdo_MdoZ2; } set { recpromdo_MdoZ2 = value; } }

        public double mdoz3 { get { return recpromdo_MdoZ3; } set { recpromdo_MdoZ3 = value; } }

        public double mdoz4 { get { return recpromdo_MdoZ4; } set { recpromdo_MdoZ4 = value; } }

        public double mdoest1 { get { return recpromdo_Mdoest1; } set { recpromdo_Mdoest1 = value; } }

        public double mdoest2 { get { return recpromdo_Mdoest2; } set { recpromdo_Mdoest2 = value; } }

        public double mdoestab { get { return recpromdo_Mdoestab; } set { recpromdo_Mdoestab = value; } }

        public double mdo1velocity { get { return recpromdo_Mdo1velocity; } set { recpromdo_Mdo1velocity = value; } }

        public double mdo1amperage { get { return recpromdo_Mdo1amperage; } set { recpromdo_Mdo1amperage = value; } }

        public double mdo2velocity { get { return recpromdo_Mdo2velocity; } set { recpromdo_Mdo2velocity = value; } }

        public double mdo2amperage { get { return recpromdo_Mdo2amperage; } set { recpromdo_Mdo2amperage = value; } }

        public double mdofixation1 { get { return recpromdo_Mdofixation1; } set { recpromdo_Mdofixation1 = value; } }

        public double mdofixation2 { get { return recpromdo_Mdofixation2; } set { recpromdo_Mdofixation2 = value; } }
        
        //Constructor
        public clsRecordProductionMdo()
        {
            recordproductionpressure = new clsRecordProductionPressure();
            recpromdo_codsec = 0;
            recpromdo_fkRecordProduction = 0;
            recpromdo_fkProductionOrder = 0;
            recpromdo_Mdocirprin = 0;
            recpromdo_MdoZ1 = 0;
            recpromdo_MdoZ2 = 0;
            recpromdo_MdoZ3 = 0;
            recpromdo_MdoZ4 = 0;
            recpromdo_Mdoest1 = 0;
            recpromdo_Mdoest2 = 0;
            recpromdo_Mdoestab = 0;
            recpromdo_Mdo1velocity = 0;
            recpromdo_Mdo1amperage = 0;
            recpromdo_Mdo2velocity = 0;
            recpromdo_Mdo2amperage = 0;
            recpromdo_Mdofixation1 = 0;
            recpromdo_Mdofixation2 = 0;
        }
        //Methods
        public bool save(string actions)
        {
            if (actions == "save")
            {
                try
                {
                    string queryString = "";

                    if (this.recpromdocodsec == 0)
                    {
                        queryString += "INSERT INTO bps_prod_recordproductionmdo (recpromdo_fkRecordProduction, recpromdo_fkProductionOrder, recpromdo_Mdocirprin, recpromdo_MdoZ1, recpromdo_MdoZ2, recpromdo_MdoZ3, recpromdo_MdoZ4, recpromdo_Mdoest1, recpromdo_Mdoest2, recpromdo_Mdoestab, recpromdo_Mdo1velocity, recpromdo_Mdo1amperage, recpromdo_Mdo2velocity, recpromdo_Mdo2amperage, recpromdo_Mdofixation1, recpromdo_Mdofixation2) VALUES (";
                        queryString += this.recpromdofkrecordproduction.ToString() + ",";
                        queryString += this.recpromdofkproductionorder.ToString() + ",";
                        queryString += this.mdocirprin.ToString() + ",";
                        queryString += this.mdoz1.ToString() + ",";
                        queryString += this.mdoz2.ToString() + ",";
                        queryString += this.mdoz3.ToString() + ",";
                        queryString += this.mdoz4.ToString() + ",";
                        queryString += this.mdoest1.ToString() + ",";
                        queryString += this.mdoest2.ToString() + ",";
                        queryString += this.mdoestab.ToString() + ",";
                        queryString += this.mdo1velocity.ToString() + ",";
                        queryString += this.mdo1amperage.ToString() + ",";
                        queryString += this.mdo2velocity.ToString() + ",";
                        queryString += this.mdo2amperage.ToString() + ",";
                        queryString += this.mdofixation1.ToString() + ",";
                        queryString += this.mdofixation2.ToString() + ");";
                    }
                    else
                    {
                        queryString += "UPDATE bps_prod_recordproductionmdo SET recpromdo_fkRecordProduction = " + this.recpromdofkrecordproduction.ToString();
                        queryString += ", recpromdo_fkProductionOrder =" + this.recpromdofkproductionorder.ToString();
                        queryString += ", recpromdo_Mdocirprin = '" + this.mdocirprin.ToString() + "' ";
                        queryString += ", recpromdo_MdoZ1 = " + this.mdoz1.ToString();
                        queryString += ", recpromdo_MdoZ2 = " + this.mdoz2.ToString();
                        queryString += ", recpromdo_MdoZ3 = " + this.mdoz3.ToString();
                        queryString += ", recpromdo_MdoZ4 = " + this.mdoz4.ToString();
                        queryString += ", recpromdo_Mdoest1 = " + this.mdoest1.ToString();
                        queryString += ", recpromdo_Mdoest2 = " + this.mdoest2.ToString();
                        queryString += ", recpromdo_Mdoestab = " + this.mdoestab.ToString();
                        queryString += ", recpromdo_Mdo1velocity = " + this.mdo1velocity.ToString();
                        queryString += ", recpromdo_Mdo1amperage = " + this.mdo1amperage.ToString();
                        queryString += ", recpromdo_Mdo2velocity = " + this.mdo2velocity.ToString();
                        queryString += ", recpromdo_Mdo2amperage = " + this.mdo2amperage.ToString();
                        queryString += ", recpromdo_Mdofixation1 = " + this.mdofixation1.ToString();
                        queryString += ", recpromdo_Mdofixation2 = " + this.mdofixation2.ToString();
                        queryString += " WHERE recpromdo_codsec = " + this.recpromdocodsec.ToString() + ";";
                    }
                   return clsConnection.executeQuery(queryString);
                }
                catch (Exception ex)
                {
                    clsLog.addLog(ex, 3, "clsRecordProductionMdo.save");
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

                    if (this.recpromdocodsec == 0)
                    {
                        queryString += "INSERT INTO bps_prod_recordproductionmdo (recpromdo_fkRecordProduction, recpromdo_fkProductionOrder, recpromdo_Mdocirprin, recpromdo_MdoZ1, recpromdo_MdoZ2, recpromdo_MdoZ3, recpromdo_MdoZ4, recpromdo_Mdoest1, recpromdo_Mdoest2, recpromdo_Mdoestab, recpromdo_Mdo1velocity, recpromdo_Mdo1amperage, recpromdo_Mdo2velocity, recpromdo_Mdo2amperage, recpromdo_Mdofixation1, recpromdo_Mdofixation2) VALUES (";
                        queryString += this.recpromdofkrecordproduction.ToString() + ",";
                        queryString += this.recpromdofkproductionorder.ToString() + ",";
                        queryString += this.mdocirprin.ToString() + ",";
                        queryString += this.mdoz1.ToString() + ",";
                        queryString += this.mdoz2.ToString() + ",";
                        queryString += this.mdoz3.ToString() + ",";
                        queryString += this.mdoz4.ToString() + ",";
                        queryString += this.mdoest1.ToString() + ",";
                        queryString += this.mdoest2.ToString() + ",";
                        queryString += this.mdoestab.ToString() + ",";
                        queryString += this.mdo1velocity.ToString() + ",";
                        queryString += this.mdo1amperage.ToString() + ",";
                        queryString += this.mdo2velocity.ToString() + ",";
                        queryString += this.mdo2amperage.ToString() + ",";
                        queryString += this.mdofixation1.ToString() + ",";
                        queryString += this.mdofixation2.ToString() + ");";
                    }
                    if (clsConnection.executeQuery(queryString))
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    clsLog.addLog(ex, 3, "clsRecordProductionMdo.save");
                    return false;
                }
            }
            else
                return false;
        }
    }
}
