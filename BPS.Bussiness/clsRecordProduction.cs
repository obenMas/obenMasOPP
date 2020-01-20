using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{    
    public class clsRecordProduction
    {
        //Atributes
        private clsRecordProductionHead Recordproductionhead;
        private int recpro_codsec;
        private int recpro_fkProductionOrder;
        private string recpro_LotNumber;
        private string recpro_type;
        private double recpro_thickness;
        private double recpro_temperatureMainZ1;
        private double recpro_temperatureMainZ2;
        private double recpro_temperatureMainZ3;
        private double recpro_temperatureMainZ4;
        private double recpro_temperatureMainZ5;
        private double recpro_temperatureMainZ6;
        private double recpro_temperatureMainZ7;
        private double recpro_temperatureMainBrida;
        private double recpro_temperatureMainMelt;
        private double recpro_temperatureMainFilter1;
        private double recpro_temperatureMainFilter2;
        private double recpro_temperatureMainMelt1;
        private double recpro_temperatureMainDiverter;
        private double recpro_temperatureMaiDiverter;
        private double recpro_pressurebeforefiltermain;
        private double recpro_pressureafterfiltermain;
        private double recpro_pressuremain;
        private double recpro_revolutionperminutemain;
        private double recpro_amperagemain;
        
        //Properties

        public clsRecordProductionHead recordproductionhead { get { return Recordproductionhead; } set { Recordproductionhead = value; } }

        public int recprocodsec { get { return recpro_codsec; } set { recpro_codsec = value; } }

        public int fkproductionorder { get { return recpro_fkProductionOrder; } set { recpro_fkProductionOrder = value; } }

        public string lotnumber { get { return recpro_LotNumber; } set { recpro_LotNumber = value; } }

        public string type { get { return recpro_type; } set { recpro_type = value; } }

        public double thickness { get { return recpro_thickness; } set { recpro_thickness = value; } }

        public double temperaturemainz1 { get { return recpro_temperatureMainZ1; } set { recpro_temperatureMainZ1 = value; } }

        public double temperaturemainz2 { get { return recpro_temperatureMainZ2; } set { recpro_temperatureMainZ2 = value; } }

        public double temperaturemainz3 { get { return recpro_temperatureMainZ3; } set { recpro_temperatureMainZ3 = value; } }

        public double temperaturemainz4 { get { return recpro_temperatureMainZ4; } set { recpro_temperatureMainZ4 = value; } }

        public double temperaturemainz5 { get { return recpro_temperatureMainZ5; } set { recpro_temperatureMainZ5 = value; } }

        public double temperaturemainz6 { get { return recpro_temperatureMainZ6; } set { recpro_temperatureMainZ6 = value; } }

        public double temperaturemainz7 { get { return recpro_temperatureMainZ7; } set { recpro_temperatureMainZ7 = value; } }

        public double temperaturemainbrida { get { return recpro_temperatureMainBrida; } set { recpro_temperatureMainBrida = value; } }

        public double temperaturemainmelt { get { return recpro_temperatureMainMelt; } set { recpro_temperatureMainMelt = value; } }

        public double temperaturemainfilter1 { get { return recpro_temperatureMainFilter1; } set { recpro_temperatureMainFilter1 = value; } }

        public double temperaturemainfilter2 { get { return recpro_temperatureMainFilter2; } set { recpro_temperatureMainFilter2 = value; } }

        public double temperaturemainmelt1 { get { return recpro_temperatureMainMelt1; } set { recpro_temperatureMainMelt1 = value; } }

        public double temperaturemaindiverter { get { return recpro_temperatureMainDiverter; } set { recpro_temperatureMainDiverter = value; } }

        public double temperaturemaidiverter { get { return recpro_temperatureMaiDiverter; } set { recpro_temperatureMaiDiverter = value; } }

        public double pressurebeforefiltermain { get { return recpro_pressurebeforefiltermain; } set { recpro_pressurebeforefiltermain = value; } }

        public double pressureafterfiltermain { get { return recpro_pressureafterfiltermain; } set { recpro_pressureafterfiltermain = value; } }

        public double pressuremain { get { return recpro_pressuremain; } set { recpro_pressuremain = value; } }

        public double revolutionperminutemain { get { return recpro_revolutionperminutemain; } set { recpro_revolutionperminutemain = value; } }

        public double amperagemain { get { return recpro_amperagemain; } set { recpro_amperagemain = value; } }

        //Constructor
        public clsRecordProduction()
        {
            Recordproductionhead = new clsRecordProductionHead();
            recpro_codsec = 0;
            recpro_fkProductionOrder = 0;
            recpro_LotNumber = string.Empty;
            recpro_type = "";
            recpro_thickness = 0;
            recpro_temperatureMainZ1 = 0;
            recpro_temperatureMainZ2 = 0;
            recpro_temperatureMainZ3 = 0;
            recpro_temperatureMainZ4 = 0;
            recpro_temperatureMainZ5 = 0;
            recpro_temperatureMainZ6 = 0;
            recpro_temperatureMainZ7 = 0;
            recpro_temperatureMainBrida = 0;
            recpro_temperatureMainMelt = 0;
            recpro_temperatureMainFilter1 = 0;
            recpro_temperatureMainFilter2 = 0;
            recpro_temperatureMainMelt1 = 0;
            recpro_temperatureMainDiverter = 0;
            recpro_temperatureMaiDiverter = 0;
            recpro_pressurebeforefiltermain = 0;
            recpro_pressureafterfiltermain = 0;
            recpro_pressuremain = 0;
            recpro_revolutionperminutemain = 0;
            recpro_amperagemain = 0;
        }
        //Methods

        public clsRecordProduction(int codsec)
        {
            this.load(codsec);
        }

        private void load(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT COALESCE(MAX(recpro_codsec),0) AS recpro_codsec FROM bps_prod_recordproduction WHERE recpro_fkProductionOrder = " + codsec.ToString());
            if (DS.Tables[0].Rows.Count > 0)
                this.recpro_codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["recpro_codsec"]);
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.recprocodsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_recordproduction (recpro_fkProductionOrder, recpro_LotNumber, recpro_type, recpro_thickness, recpro_temperatureMainZ1, recpro_temperatureMainZ2, recpro_temperatureMainZ3, recpro_temperatureMainZ4, recpro_temperatureMainZ5, recpro_temperatureMainZ6, recpro_temperatureMainZ7, recpro_temperatureMainBrida, recpro_temperatureMainMelt, recpro_temperatureMainFilter1, recpro_temperatureMainFilter2, recpro_temperatureMainMelt1, recpro_temperatureMainDiverter, recpro_pressurebeforefiltermain, recpro_pressureafterfiltermain, recpro_pressuremain, recpro_revolutionperminutemain, recpro_amperagemian) VALUES (";
                    queryString += this.fkproductionorder.ToString() + ",";
                    queryString += this.lotnumber.ToString() + ",";
                    queryString += "'" + this.type + "',";
                    queryString += this.thickness.ToString() + ",";
                    queryString += this.temperaturemainz1.ToString() + ",";
                    queryString += this.temperaturemainz2.ToString() + ",";
                    queryString += this.temperaturemainz3.ToString() + ",";
                    queryString += this.temperaturemainz4.ToString() + ",";
                    queryString += this.temperaturemainz5.ToString() + ",";
                    queryString += this.temperaturemainz6.ToString() + ",";
                    queryString += this.temperaturemainz7.ToString() + ",";
                    queryString += this.temperaturemainbrida.ToString() + ",";
                    queryString += this.temperaturemainmelt.ToString() + ",";
                    queryString += this.temperaturemainfilter1.ToString() + ",";
                    queryString += this.temperaturemainfilter2.ToString() + ",";
                    queryString += this.temperaturemainmelt1.ToString() + ",";
                    queryString += this.temperaturemaindiverter.ToString() + ",";
                    queryString += this.pressurebeforefiltermain.ToString() + ",";
                    queryString += this.pressureafterfiltermain.ToString() + ",";
                    queryString += this.pressuremain.ToString() + ",";
                    queryString += this.revolutionperminutemain.ToString() + ",";
                    queryString += this.amperagemain.ToString() + ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_recordproduction SET recpro_fkProductionOrder = " + this.fkproductionorder.ToString();
                    queryString += ", recpro_LotNumber = '" + this.lotnumber.ToString() + "' ";
                    queryString += ", recpro_type = '" + this.type + "' ";
                    queryString += ", recpro_thickness = " + this.thickness.ToString();
                    queryString += ", recpro_temperatureMainZ1 = " + this.temperaturemainz1.ToString();
                    queryString += ", recpro_temperatureMainZ2 = " + this.temperaturemainz2.ToString();
                    queryString += ", recpro_temperatureMainZ3 = " + this.temperaturemainz3.ToString();
                    queryString += ", recpro_temperatureMainZ4 = " + this.temperaturemainz4.ToString();
                    queryString += ", recpro_temperatureMainZ5 = " + this.temperaturemainz5.ToString();
                    queryString += ", recpro_temperatureMainZ6 = " + this.temperaturemainz6.ToString();
                    queryString += ", recpro_temperatureMainZ7 = " + this.temperaturemainz7.ToString();
                    queryString += ", recpro_temperatureMainBrida = " + this.temperaturemainbrida.ToString();
                    queryString += ", recpro_temperatureMainMelt = " + this.temperaturemainmelt.ToString();
                    queryString += ", recpro_temperatureMainFilter1 = " + this.temperaturemainfilter1.ToString();
                    queryString += ", recpro_temperatureMainFilter2 = " + this.temperaturemainfilter2.ToString();
                    queryString += ", recpro_temperatureMainMelt1 = " + this.temperaturemainmelt1.ToString();
                    queryString += ", recpro_temperatureMainDiverter = " + this.temperaturemaindiverter.ToString();
                    queryString += ", recpro_pressurebeforefiltermain = " + this.pressurebeforefiltermain.ToString();
                    queryString += ", recpro_pressureafterfiltermain = " + this.pressureafterfiltermain.ToString();
                    queryString += ", recpro_pressuremain = " + this.pressuremain.ToString();
                    queryString += ", recpro_revolutionperminutemain = " + this.revolutionperminutemain.ToString();
                    queryString += ", recpro_amperagemian = " + this.amperagemain.ToString();
                    queryString += " WHERE recpro_codsec = " + this.recprocodsec.ToString() + ";";
                }

                clsConnection.executeQuery(queryString);
                recordproductionhead.save("save");
                return true;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsRecordProduction.save");
                return false;
            }
        }

        public static int getLastSavedRecordProduction()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT recpro_codsec FROM bps_prod_recordproduction Order By recpro_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["recpro_codsec"]);
        }

        public static int VerifyData(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT recpro_codsec FROM bps_prod_recordproduction WHERE recpro_fkProductionOrder = " + codsec.ToString());
            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(DS.Tables[0].Rows[0]["recpro_codsec"]);
            else
                return 0;
        }

        public bool saves()
        {
            try
            {
                string queryString = "";

                if (this.recprocodsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_recordproduction (recpro_fkProductionOrder, recpro_LotNumber, recpro_type, recpro_thickness, recpro_temperatureMainZ1, recpro_temperatureMainZ2, recpro_temperatureMainZ3, recpro_temperatureMainZ4, recpro_temperatureMainZ5, recpro_temperatureMainZ6, recpro_temperatureMainZ7, recpro_temperatureMainBrida, recpro_temperatureMainMelt, recpro_temperatureMainFilter1, recpro_temperatureMainFilter2, recpro_temperatureMainMelt1, recpro_temperatureMainDiverter, recpro_pressurebeforefiltermain, recpro_pressureafterfiltermain, recpro_pressuremain, recpro_revolutionperminutemain, recpro_amperagemian) VALUES (";
                    queryString += this.fkproductionorder.ToString() + ",";
                    queryString += "'" + this.lotnumber.ToString() + "',";
                    queryString += "'" + this.type + "',";
                    queryString += this.thickness.ToString() + ",";
                    queryString += this.temperaturemainz1.ToString() + ",";
                    queryString += this.temperaturemainz2.ToString() + ",";
                    queryString += this.temperaturemainz3.ToString() + ",";
                    queryString += this.temperaturemainz4.ToString() + ",";
                    queryString += this.temperaturemainz5.ToString() + ",";
                    queryString += this.temperaturemainz6.ToString() + ",";
                    queryString += this.temperaturemainz7.ToString() + ",";
                    queryString += this.temperaturemainbrida.ToString() + ",";
                    queryString += this.temperaturemainmelt.ToString() + ",";
                    queryString += this.temperaturemainfilter1.ToString() + ",";
                    queryString += this.temperaturemainfilter2.ToString() + ",";
                    queryString += this.temperaturemainmelt1.ToString() + ",";
                    queryString += this.temperaturemaindiverter.ToString() + ",";
                    queryString += this.pressurebeforefiltermain.ToString() + ",";
                    queryString += this.pressureafterfiltermain.ToString() + ",";
                    queryString += this.pressuremain.ToString() + ",";
                    queryString += this.revolutionperminutemain.ToString() + ",";
                    queryString += this.amperagemain.ToString() + ");";
                }
                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsRecordProduction.save");
                return false;
            }
        }
    }
}
