using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsFormulationReport
    {
        private int for_codsec;
        private int for_fkProductionOrder;
        private string for_Treatment;
        private double for_SpeedMachine;
        private double for_Gramage;
        private double for_KilogramPerHour;
        private string for_LotNumber;
        private string for_Machine;
        private string for_Film;
        private string for_Notes;

        //Properties


        public int codsec { get { return for_codsec; } set { for_codsec = value; } }

        public int fkproductionorder { get { return for_fkProductionOrder; } set { for_fkProductionOrder = value; } }

        public string treatment { get { return for_Treatment; } set { for_Treatment = value; } }

        public double speedmachine { get { return for_SpeedMachine; } set { for_SpeedMachine = value; } }

        public double gramage { get { return for_Gramage; } set { for_Gramage = value; } }

        public double kilogramperhour { get { return for_KilogramPerHour; } set { for_KilogramPerHour = value; } }

        public string lotnumber { get { return for_LotNumber; } set { for_LotNumber = value; } }

        public string machine { get { return for_Machine; } set { for_Machine = value; } }

        public string film { get { return for_Film; } set { for_Film = value; } }

        public string notes { get { return for_Notes; } set { for_Notes = value; } }

        //Constructor

        public clsFormulationReport()
        {
            for_codsec = 0;
            for_fkProductionOrder = 0;
            for_Treatment = "";
            for_SpeedMachine = 0;
            for_Gramage = 0;
            for_KilogramPerHour = 0;
            for_LotNumber = "";
            for_Machine = "";
            for_Film = "";
            for_Notes = "";
        }

        public clsFormulationReport(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        { 

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT for_codsec, for_gramage FROM bps_prod_formulationreport WHERE for_fkproductionorder = " + codsec.ToString());

            //this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["for_codsec"]);
            this.fkproductionorder = Convert.ToInt32(DS.Tables[0].Rows[0]["for_codsec"]);
            //this.treatment = DS.Tables[0].Rows[0]["for_description"].ToString();
            //this.speedmachine = Convert.ToInt32(DS.Tables[0].Rows[0]["for_fkBopp"]);
            this.gramage = Convert.ToDouble(DS.Tables[0].Rows[0]["for_gramage"]);
            //this.kilogramperhour = DS.Tables[0].Rows[0]["for_BoppName"].ToString();
            //this.lotnumber = Convert.ToInt32(DS.Tables[0].Rows[0]["for_fkCast"]);
            //this.machine = DS.Tables[0].Rows[0]["for_CastCode"].ToString();
            //this.film = DS.Tables[0].Rows[0]["for_CastName"].ToString();
            //this.notes = Convert.ToDouble(DS.Tables[0].Rows[0]["for_thick"]);
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                    if (this.codsec == 0)
                    {
                        queryString += "INSERT INTO bps_prod_formulationreport (for_fkproductionorder,for_treatment, for_speedmachine,for_gramage,for_kilogramsperhour,for_lotnumber,for_machine,for_film,for_notes)";
                        queryString += " VALUES (";
                        queryString += this.fkproductionorder.ToString() + ",";
                        queryString += "'" + this.treatment.ToString() + "',";
                        queryString += this.speedmachine.ToString() + ",";
                        queryString += this.gramage.ToString() + ",";
                        queryString += this.kilogramperhour.ToString() + ",";
                        queryString += "'" + this.lotnumber + "',";
                        queryString += "'" + this.machine + "',";
                        queryString += "'" + this.film + "',";
                        queryString += "'" + this.notes + "');";
                    }
                    else
                    {
                        queryString += "UPDATE bps_prod_formulationreport";
                        queryString += " SET ";
                        queryString += "for_fkproductionorder = " + this.fkproductionorder + ",";
                        queryString += "for_treatment = '" + this.treatment.ToString() + "',";
                        queryString += "for_speedmachine = " + this.speedmachine.ToString() + ",";
                        queryString += "for_gramage = " + this.gramage.ToString() + ",";
                        queryString += "for_kilogramsperhour = " + this.kilogramperhour.ToString() + "',";
                        queryString += "for_lotnumber = '" + this.lotnumber + "',";
                        queryString += "for_machine = '" + this.machine + "',";
                        queryString += "for_film = '" + this.film + "',";
                        queryString += "for_notes = '" + this.notes + "'";
                        queryString += " WHERE for_codsec = " + this.codsec.ToString() + ";";
                    }
                    return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsFormulationReport.save");
                return false;
            }
        }

        public static int getLastsaved()
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT for_codsec FROM bps_prod_formulationreport Order By for_codsec DESC LIMIT 1");
            return Convert.ToInt32(DS.Tables[0].Rows[0]["for_codsec"]);
        }

        public static int getFormulationStatus(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT for_codsec FROM bps_prod_formulationreport WHERE for_fkproductionorder = " + codsec.ToString());
            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(DS.Tables[0].Rows[0]["for_codsec"]);
            else
                return 0;
        }
    }
}
