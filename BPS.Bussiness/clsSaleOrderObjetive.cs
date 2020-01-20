using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsSaleOrderObjetive
    {
        //Atributes

        private int soo_codsec;
        private int soo_fkEntity;
        private int soo_objetiveNumber;
        private DateTime soo_Date;

        //Properties

        public int codsec { get { return soo_codsec; } set { soo_codsec = value; } }
        public int fkEntity { get { return soo_fkEntity; } set { soo_fkEntity = value; } }
        public int objetiveNumber { get { return soo_objetiveNumber; } set { soo_objetiveNumber = value; } }
        public DateTime Date { get { return soo_Date; } set { soo_Date = value; } }

        //Constructor
        public clsSaleOrderObjetive()
        {
            codsec = 0;
            fkEntity = 0;
            objetiveNumber = 0;

        }

        public clsSaleOrderObjetive(int codsec)
        {
            this.load(codsec);
        }
        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_com_salesorderobjetive WHERE soo_codsec = " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["soo_codsec"]);
                this.fkEntity = Convert.ToInt32(DS.Tables[0].Rows[0]["soo_fkEntity"]);
                this.objetiveNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["soo_objetiveNumer"]);
                this.Date = Convert.ToDateTime(DS.Tables[0].Rows[0]["soo_Date"]);
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_com_salesorderobjetive";
                    queryString += "VALUES( ";
                    queryString += this.fkEntity.ToString() + ", ";
                    queryString += this.objetiveNumber.ToString() + ", ";
                    queryString += "'" + this.Date.ToString() + "');";
                }
                else
                {
                    queryString += "UPDATE bps_com_salesorderobjetive";
                    queryString += " SET ";
                    queryString += " soo_fkEntity = " + this.fkEntity.ToString() + ", ";
                    queryString += " soo_objetiveNumer = " + this.objetiveNumber.ToString() + "";
                    queryString += " WHERE soo_codsec = " + this.codsec.ToString() + ";";

                }

                return clsConnection.executeQuery(queryString);
            }
            catch(Exception ex)
            {
                clsLog.addLog(ex, 3, "clsSaleOrderObjetive.save");
                return false;
            }
        }
    }
}
