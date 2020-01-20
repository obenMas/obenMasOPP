using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BPS.Bussiness;

namespace BPS.Bussiness
{
    public class clsRawMaterialMovements
    {
        //Atributes
        private int rwmm_codsec;
        private int rwmm_fkRaw;
        private string rwmm_type;
        private int rwmm_fkRawPallet;
        private string rwmm_lote;
        private double rwmm_netWeigth;
        private string rwmm_estrusionLote;
        private int rwmm_fkOrigCellar;
        private int rwmm_fkDestCellar;
        private DateTime rwmm_date;
        private int rwmm_fkUser;
        //Properties

        public int codsec { get { return rwmm_codsec; } set { rwmm_codsec = value; } }
        public int fkRaw { get { return rwmm_fkRaw; } set { rwmm_fkRaw = value; } }
        public string type { get { return rwmm_type; } set { rwmm_type = value; } }
        public int fkRawPallet { get { return rwmm_fkRawPallet; } set { rwmm_fkRawPallet = value; } }
        public string lote { get { return rwmm_lote; } set { rwmm_lote = value; } }
        public double netWeigth { get { return rwmm_netWeigth; } set { rwmm_netWeigth = value; } }
        public string estrusionLote { get { return rwmm_estrusionLote; } set { rwmm_estrusionLote = value; } }
        public int fkOrigCellar { get { return rwmm_fkOrigCellar; } set { rwmm_fkOrigCellar = value; } }
        public int fkDestCellar { get { return rwmm_fkDestCellar; } set { rwmm_fkDestCellar = value; } }
        public DateTime date { get { return rwmm_date; } set { rwmm_date = value; } }
        public int fkUser { get { return rwmm_fkUser; } set { rwmm_fkUser = value; } }

        //Constructor
        public clsRawMaterialMovements()
        {
            codsec = 0;
            fkRaw = 0;
            type = "";
            fkRawPallet = 0;
            lote = "";
            netWeigth = 0;
            fkOrigCellar = 0;
            fkDestCellar = 0;
            fkUser = 0;
            estrusionLote = "";
            date = DateTime.Now;
        }

        public clsRawMaterialMovements(int codsec)
        {
            this.load(codsec);
        }
        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_rawMaterialMovements WHERE rwmm_codsec = " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmm_codsec"]);
                this.fkRaw = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmm_fkRaw"]);
                this.type = Convert.ToString(DS.Tables[0].Rows[0]["rwmm_type"]);
                this.fkRawPallet = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmm_fkRawPallet"]);
                this.lote = Convert.ToString(DS.Tables[0].Rows[0]["rwmm_lote"]);
                this.netWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["rwmm_netWeigth"]);
                this.estrusionLote = Convert.ToString(DS.Tables[0].Rows[0]["rwmm_estrusionLote"]);
                this.fkOrigCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmm_fkOrigCellar"]);
                this.fkDestCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmm_fkDestCellar"]);
                this.date = Convert.ToDateTime(DS.Tables[0].Rows[0]["rwmm_date"]);
                this.fkUser = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmm_fkUser"]);
            }
        }

        public bool save()
        {
            string querystring = "";

            try
            {
                if (this.codsec == 0)
                {
                    querystring += "INSERT INTO bps_prod_rawMaterialMovements";
                    querystring += " VALUES (";
                    querystring += this.fkRaw.ToString() + ", ";
                    querystring += "'" + this.type.ToString() + "'" + ", ";
                    querystring += this.fkRawPallet.ToString() + ", ";
                    querystring += "'" + this.lote.ToString() + "', ";
                    querystring += this.netWeigth.ToString() + ", ";
                    querystring += "'" + this.estrusionLote.ToString() + "', ";
                    querystring += this.fkOrigCellar.ToString() +", ";
                    querystring += this.fkDestCellar.ToString() + ", ";
                    querystring += this.fkUser.ToString() + ", ";
                    querystring += "'" + this.date.ToString("dd/MM/yyyy hh:mm:ss") + "'" + "); ";
                    
                }
                else
                {
                    querystring += "UPDATE bps_prod_rawMaterialMovements(rwmm_fkRaw,rwmm_type,rwmm_fkRawPallet,rwmm_lote,rwmm_netWeigth,rwmm_estrusionLote,rwmm_fkOrigCellar,rwmm_fkDestCellar,rwmm_fkUser,rwmm_date)";
                    querystring += " SET ";
                    querystring += this.fkRaw.ToString() + ", ";
                    querystring += "'" + this.type.ToString() + "', ";
                    querystring += this.fkRawPallet.ToString() + ", ";
                    querystring += "'" + this.lote.ToString() + "', ";
                    querystring += this.netWeigth.ToString() + ", ";
                    querystring += "'" + this.estrusionLote.ToString() + "', ";
                    querystring += this.fkOrigCellar.ToString() + ", ";
                    querystring += this.fkDestCellar.ToString() + ", ";
                    querystring += this.fkUser.ToString() + ",";
                    querystring += "'" + this.date.ToString("dd/MM/yyyy hh:mm:ss") + "'";
                    querystring += " WHERE rwmm_codsec = " + this.codsec.ToString() + ";";

                }
                return clsConnection.executeQuery(querystring);
            }
            catch(Exception ex)
            {
                clsLog.addLog(ex, 3, "clsRawMaterialMovements.save");
                return false; 
            }
        }
    }
}
