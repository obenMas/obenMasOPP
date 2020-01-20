using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BPS.Bussiness
{
    public class clsRecordProductionCoil
    {
        //Atributes
        private int recprocoimw_codsec;
        private int recprocoimw_fkRecordProduction;
        private int recprocoimw_fkProductionOrder;
        private double recprocoimw_Tension1;
        private double recprocoimw_Taper1;
        private double recprocoimw_Tension2;
        private double recprocoimw_Taper2;
        private double recprocoimw_Coil;
        
        //Properies

        public int recprocoicodsec { get { return recprocoimw_codsec; } set { recprocoimw_codsec = value; } }

        public int recprocoifkrecordproduction { get { return recprocoimw_fkRecordProduction; } set { recprocoimw_fkRecordProduction = value; } }

        public int recprocoifkproductionorder { get { return recprocoimw_fkProductionOrder; } set { recprocoimw_fkProductionOrder = value; } }

        public double Tension1 { get { return recprocoimw_Tension1; } set { recprocoimw_Tension1 = value; } }

        public double Taper1 { get { return recprocoimw_Taper1; } set { recprocoimw_Taper1 = value; } }

        public double Tension2 { get { return recprocoimw_Tension2; } set { recprocoimw_Tension2 = value; } }

        public double Taper2 { get { return recprocoimw_Taper2; } set { recprocoimw_Taper2 = value; } }

        public double coil { get { return recprocoimw_Coil; } set { recprocoimw_Coil = value; } }

        //Constructor
        public clsRecordProductionCoil()
        {
            recprocoimw_codsec = 0;
            recprocoimw_fkRecordProduction = 0;
            recprocoimw_fkProductionOrder = 0;
            recprocoimw_Tension1 = 0;
            recprocoimw_Taper1 = 0;
            recprocoimw_Tension2 = 0;
            recprocoimw_Taper2 = 0;
            recprocoimw_Coil = 0;
        }

        //Method
        public bool save(string actions)
        {
            if (actions == "save")
            {
                try
                {
                    string queryString = "";

                    if (this.recprocoicodsec == 0)
                    {
                        queryString += "INSERT INTO bps_prod_recordproductionmwcoil (recprocoimw_fkRecordProduction, recprocoimw_fkProductionOrder, recprocoimw_Tension1, recprocoimw_Taper1, recprocoimw_Tension2, recprocoimw_Taper2) VALUES (";
                        queryString += this.recprocoifkrecordproduction.ToString() + ",";
                        queryString += this.recprocoifkproductionorder.ToString() + ",";
                        queryString += this.Tension1.ToString() + ",";
                        queryString += this.Taper1.ToString() + ",";
                        queryString += this.Tension2.ToString() + ",";
                        queryString += this.Taper2.ToString() + ");";
                    }
                    else
                    {
                        queryString += "UPDATE bps_prod_recordproductionmwcoil SET recprocoimw_fkRecordProduction = " + this.recprocoifkrecordproduction.ToString();
                        queryString += ", recprocoimw_fkProductionOrder =" + this.recprocoifkproductionorder.ToString();
                        queryString += ", recprocoimw_Tension1 = " + this.Tension1.ToString();
                        queryString += ", recpropcoimw_Taper1 = " + this.Taper1.ToString();
                        queryString += ", recprocoimw_Tension2 = " + this.Tension2.ToString();
                        queryString += ", recpropcoimw_Taper2 = " + this.Taper2.ToString() + ";";
                    }
                    clsConnection.executeQuery(queryString);
                    return true;
                }
                catch (Exception ex)
                {
                    clsLog.addLog(ex, 3, "clsRecordProductionCoil.save");
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

                    if (this.recprocoicodsec == 0)
                    {
                        queryString += "INSERT INTO bps_prod_recordproductionmwcoil (recprocoimw_fkRecordProduction, recprocoimw_fkProductionOrder, recprocoimw_Tension1, recprocoimw_Taper1, recprocoimw_Tension2, recprocoimw_Taper2, recprocoimw_Coil) VALUES (";
                        queryString += this.recprocoifkrecordproduction.ToString() + ",";
                        queryString += this.recprocoifkproductionorder.ToString() + ",";
                        queryString += this.Tension1.ToString() + ",";
                        queryString += this.Taper1.ToString() + ",";
                        queryString += this.Tension2.ToString() + ",";
                        queryString += this.Taper2.ToString() + ",";
                        queryString += this.coil.ToString() + ");";
                    }
                    if (clsConnection.executeQuery(queryString))
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    clsLog.addLog(ex, 3, "clsRecordProductionCoil.save");
                    return false;
                }
            }
            else
                return false;
        }
    }
}
