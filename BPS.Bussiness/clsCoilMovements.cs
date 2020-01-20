using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace BPS.Bussiness
{
    public class clsCoilMovements
    {
        // Atributes
        
        private int cm_codsec;
        private string cm_type;
        private int cm_fkCoil;
        private int cm_length;
        private double cm_netWeigth;
        private int cm_fkOrgCellar;
        private int cm_fkDestCellar;
        private int cm_fkUser;
       // private clsCoil cm_coilClass;
        private DateTime cm_date;
        
        // Properties
        
        public int codsec { get { return cm_codsec; } set { cm_codsec = value; } }
        public string type { get { return cm_type; } set { cm_type = value; } }
        public int fkCoil { get { return cm_fkCoil; } set { cm_fkCoil = value; } }
        public int length { get { return cm_length; } set { cm_length = value; } }
        public double netWeigth { get { return cm_netWeigth; } set { cm_netWeigth = value; } }
        public int fkOrgCellar { get { return cm_fkOrgCellar; } set { cm_fkOrgCellar = value; } }
        public int fkDestCellar { get { return cm_fkDestCellar; } set { cm_fkDestCellar = value; } }
        public int fkUser { get { return cm_fkUser; } set { cm_fkUser = value; } }
        public DateTime date { get { return cm_date; } set { cm_date = value; } }

        // Constructor
        
        public clsCoilMovements()
        {
            codsec = 0;
            type = "";
            fkCoil = 0;
            length = 0;
            netWeigth = 0;
            fkOrgCellar = 0;
            fkDestCellar = 0;
            fkUser = 0;
            date = DateTime.Now;
        }

        public clsCoilMovements(int codsec)
        {
            this.load(codsec);
        }

        // Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilMovements WHERE cm_codsec = " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
	        {
		        codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cm_codsec"]);
                type = DS.Tables[0].Rows[0]["cm_type"].ToString();
                fkCoil = Convert.ToInt32(DS.Tables[0].Rows[0]["cm_fkCoil"]);
                length = Convert.ToInt32(DS.Tables[0].Rows[0]["cm_length"]);
                netWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["cm_netWeigth"]);
                fkOrgCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["cm_fkOrgCellar"]);
                fkDestCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["cm_fkDestCellar"]);
                fkUser = Convert.ToInt32(DS.Tables[0].Rows[0]["cm_fkUser"]);
                date = Convert.ToDateTime(DS.Tables[0].Rows[0]["cm_date"]);

	        }

        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString = "INSERT INTO bps_prod_coilMovements(cm_type,cm_fkCoil,cm_length,cm_netWeigth,cm_fkOrgCellar,cm_fkDestCellar,cm_fkUser,cm_date)";
                    queryString += "VALUES( ";
                    queryString += "'" + this.type + "', ";
                    queryString += this.fkCoil + ", ";
                    queryString += this.length + ", ";
                    queryString += this.netWeigth + ", ";
                    queryString += this.fkOrgCellar + ", ";
                    queryString += this.fkDestCellar + ", ";
                    queryString += this.fkUser + ",";
                    queryString += "'" + this.date.ToString("dd/MM/yyyy HH:mm") + "')";
                }
                else
                {
                    queryString = "UPDATE bps_prod_coilMovements";
                    queryString += "SET";
                    queryString += "cm_type = '" + this.type + "', ";
                    queryString += "cm_fkCoil =" + this.fkCoil.ToString() + ", ";
                    queryString += "cm_length =" + this.length.ToString() + ", ";
                    queryString += "cm_netWeigth = " + this.netWeigth.ToString() + ", ";
                    queryString += "cm_fkOrgCellar = " + this.fkOrgCellar.ToString() +  ", ";
                    queryString += "cm_fkDestCellar = " + this.fkDestCellar.ToString() + ", ";
                    queryString += "cm_fkUser = " + this.fkUser + ", ";
                    queryString += "cm_date ='" + this.date.ToString("dd/MM/yyyy HH:mm") +"' ";
                    queryString += "WHERE cm_codsec = " + this.codsec.ToString();
                }

                bool anduvo = clsConnection.executeQuery(queryString);

                return anduvo;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCoil.save");
                return false;
            }
        }

    }
}