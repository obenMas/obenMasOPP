using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;


namespace BPS.Bussiness
{
    public class clsMillProduction
    {
        //Atributes
        private int mp_codsec;
        private int mp_fkRaw;
        private double mp_netWeigth;
        private double mp_scrapWeigth;
        private int mp_fkUser;
        private int mp_fkMachine;
        private DateTime mp_date;

        //Propiedades
        public int codsec { get { return mp_codsec; } set { mp_codsec = value; } }
        public int fkRaw { get { return mp_fkRaw; } set { mp_fkRaw = value; } }
        public double netWeigth { get { return mp_netWeigth; } set { mp_netWeigth = value; } }
        public double scrapWeigth { get { return mp_scrapWeigth; } set { mp_scrapWeigth = value; } }
        public int fkUser { get { return mp_fkUser; } set { mp_fkUser = value; } }
        public int fkMachine { get { return mp_fkMachine; } set { mp_fkMachine = value; } }
        public DateTime date { get { return mp_date; } set { mp_date = value; } }

        //Constructor
        public clsMillProduction()
        {
            codsec = 0;
            fkRaw = 0;
            netWeigth = 0;
            scrapWeigth = 0;
            fkUser = 0;
            fkMachine = 0;

        }
        public clsMillProduction(int codsec)
        {
            this.load(codsec);
        }
        //Metodos

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_millproduction WHERE mp_codsec = " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.fkRaw = Convert.ToInt32(DS.Tables[0].Rows[0]["mp_fkRaw"]);
                this.netWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mp_netWeigth"]);
                this.scrapWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mp_scrapWeigth"]);
                this.fkUser = Convert.ToInt32(DS.Tables[0].Rows[0]["mp_fkUser"]);
                this.fkMachine = Convert.ToInt32(DS.Tables[0].Rows[0]["mp_fkMachine"]);
                this.date = Convert.ToDateTime(DS.Tables[0].Rows[0]["mp_date"]);
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_millproduction ";
                    queryString += "VALUES ( ";
                    queryString += this.fkRaw.ToString() + ", ";
                    queryString += this.netWeigth.ToString() + ", ";
                    queryString += this.scrapWeigth.ToString() + ", ";
                    queryString += this.fkUser.ToString() + ", ";
                    queryString += this.fkMachine.ToString() + ", ";
                    queryString += "'" + this.date.ToString("dd/MM/yyyy hh:mm:ss") + "'); ";
                }
                else
                {
                    queryString += "UPDATE bps_prod_millproduction(mp_fkRaw,mp_netWeigth,mp_scrapWeigth,mp_fkUser,mp_fkMachine,mp_date)";
                    queryString += " SET ";
                    queryString += " mp_fkRaw = " + this.fkRaw.ToString() + ", ";
                    queryString += " mp_netWeigth = " + this.netWeigth.ToString() + ", ";
                    queryString += " mp_scrapWeigth = " + this.scrapWeigth.ToString() + ", ";
                    queryString += " mp_fkUser = " + this.fkUser.ToString() + ", ";
                    queryString += " mp_fkMachine = " + this.fkMachine.ToString() + ", ";
                    queryString += " mp_date = " + "'" + this.date.ToString("dd/MM/yyyy hh:mm:ss") + "'" + "";
                    queryString += " WHERE mp_codsec = " + this.codsec.ToString() + ";";

                }
                return clsConnection.executeQuery(queryString);
            }
            catch(Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMillProduction.save");
                return false;
            }
        }
    }
}
