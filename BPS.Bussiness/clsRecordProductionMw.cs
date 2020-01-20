using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{    
    public class clsRecordProductionMw
    {
        //Atributes
        //private clsRecordProductionHead Recordproductionhead;
        private int recpromw_codsec;
        private string recpromw_type;
        private string recpromw_thickness;
        private double recpromw_fkProductionOrder;
        private double recpromw_temperatureMainZ1;
        private double recpromw_temperatureMainZ2;
        private double recpromw_temperatureMainZ3;
        private double recpromw_temperatureMainZ4;
        private double recpromw_temperatureMainZ5;
        private double recpromw_temperatureMainZ6;
        private double recpromw_temperatureMainFilter;
        private double recpromw_pressurefilter;
        private double recpromw_capacity;
        private double recpromw_amperagemain;
        private double recpromw_diverte;
        private DateTime recpromw_date;
        private string recpromw_note;
        private string recpromw_lotnumber;
        
        //Properties

        //public clsRecordProductionHead recordproductionhead { get { return Recordproductionhead; } set { Recordproductionhead = value; } }

        public int recpromwcodsec { get { return recpromw_codsec; } set { recpromw_codsec = value; } }

        public string type { get { return recpromw_type; } set { recpromw_type = value; } }

        public string thickness { get { return recpromw_thickness; } set { recpromw_thickness = value; } }

        public double fkproductionorder { get { return recpromw_fkProductionOrder; } set { recpromw_fkProductionOrder = value; } }

        public double temperaturemainz1mw { get { return recpromw_temperatureMainZ1; } set { recpromw_temperatureMainZ1 = value; } }

        public double temperaturemainz2mw { get { return recpromw_temperatureMainZ2; } set { recpromw_temperatureMainZ2 = value; } }

        public double temperaturemainz3mw { get { return recpromw_temperatureMainZ3; } set { recpromw_temperatureMainZ3 = value; } }

        public double temperaturemainz4mw { get { return recpromw_temperatureMainZ4; } set { recpromw_temperatureMainZ4 = value; } }

        public double temperaturemainz5mw { get { return recpromw_temperatureMainZ5; } set { recpromw_temperatureMainZ5 = value; } }

        public double temperaturemainz6mw { get { return recpromw_temperatureMainZ6; } set { recpromw_temperatureMainZ6 = value; } }

        public double temperaturemainfiltermw { get { return recpromw_temperatureMainFilter; } set { recpromw_temperatureMainFilter = value; } }

        public double pressurefiltermw { get { return recpromw_pressurefilter; } set { recpromw_pressurefilter = value; } }

        public double pressurecapacity { get { return recpromw_capacity; } set { recpromw_capacity = value; } }

        public double amperagemainmw { get { return recpromw_amperagemain; } set { recpromw_amperagemain = value; } }

        public double diverte { get { return recpromw_diverte; } set { recpromw_diverte = value; } }

        public DateTime date { get { return recpromw_date; } set { recpromw_date = value; } }

        public string note { get { return recpromw_note; } set { recpromw_note = value; } }

        public string lotnumber { get { return recpromw_lotnumber; } set { recpromw_lotnumber = value; } }

        //Constructor
        public clsRecordProductionMw()
        {
            recpromw_codsec = 0;
            recpromw_thickness = "";
            recpromw_type = "";
            recpromw_fkProductionOrder = 0;
            recpromw_temperatureMainZ1 = 0;
            recpromw_temperatureMainZ2 = 0;
            recpromw_temperatureMainZ3 = 0;
            recpromw_temperatureMainZ4 = 0;
            recpromw_temperatureMainZ5 = 0;
            recpromw_temperatureMainZ6 = 0;
            recpromw_temperatureMainFilter = 0;
            recpromw_pressurefilter = 0;
            recpromw_capacity = 0;
            recpromw_amperagemain = 0;
            recpromw_diverte = 0;
            recpromw_date = DateTime.Now;
            recpromw_note = string.Empty;
            recpromw_lotnumber = string.Empty;
        }
        
        //Methods
        public clsRecordProductionMw(int codsec)
        {
            this.load(codsec);
        }

        private void load(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT COALESCE(MAX(recpromw_codsec),0) AS recpromw_codsec FROM bps_prod_recordproductionmw WHERE recpromw_fkProductionOrder = " + codsec.ToString());
            if (DS.Tables[0].Rows.Count > 0)
                this.recpromw_codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["recpromw_codsec"]);
        }

        public static int getLastSavedRecordProduction()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT recpromw_codsec FROM bps_prod_recordproductionmw Order By recpromw_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["recpromw_codsec"]);
        }

        public static int VerifyData(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT recpromw_codsec FROM bps_prod_recordproductionmw WHERE recpromw_fkProductionOrder = " + codsec.ToString());
            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(DS.Tables[0].Rows[0]["recpromw_codsec"]);
            else
                return 0;
        }

        public bool saves()
        {
            try
            {
                string queryString = "";

                if (this.recpromwcodsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_recordproductionmw (recpromw_fkProductionOrder, recpromw_type, recpromw_thickness, recpromw_temperatureMainZ1, recpromw_temperatureMainZ2, recpromw_temperatureMainZ3, recpromw_temperatureMainZ4, recpromw_temperatureMainZ5, recpromw_temperatureMainZ6, recpromw_temperatureMainFilter, recpromw_pressurefilter, recpromw_capacity, recpromw_amperagemain, recpromw_diverte, recpromw_date, recpromw_note, recpromw_lotnumber) VALUES (";
                    queryString += this.fkproductionorder.ToString() + ",";
                    queryString += "'" + this.type.ToString() + "',";
                    queryString += "'" + this.thickness.ToString() + "',";
                    queryString += this.temperaturemainz1mw.ToString() + ",";
                    queryString += this.temperaturemainz2mw.ToString() + ",";
                    queryString += this.temperaturemainz3mw.ToString() + ",";
                    queryString += this.temperaturemainz4mw.ToString() + ",";
                    queryString += this.temperaturemainz5mw.ToString() + ",";
                    queryString += this.temperaturemainz6mw.ToString() + ",";
                    queryString += this.temperaturemainfiltermw.ToString() + ",";
                    queryString += this.pressurefiltermw.ToString() + ",";
                    queryString += this.pressurecapacity.ToString() + ",";
                    queryString += this.amperagemainmw.ToString() + ",";
                    queryString += this.diverte.ToString() + ",";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + this.note.ToString() + "',";
                    queryString += "'" + this.lotnumber.ToString() + "');";
                }
                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsRecordProductionMw.save");
                return false;
            }
        }
    }
}
