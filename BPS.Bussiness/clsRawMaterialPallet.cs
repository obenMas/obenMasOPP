using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace BPS.Bussiness
{
    public class clsRawMaterialPallet
    {
        //Atributes
        private int mp_codsec;
        private int mp_fkRaw;
        private string mp_code;
        private string mp_lote;
        private double mp_netweigth;
        private int mp_fkStatus;
        private int mp_fkUser;
        private DateTime mp_date;
        private string mp_notes;
        
        //Properties
        public int codsec { get { return mp_codsec; } set { mp_codsec = value; } }
        public int fkRaw { get { return mp_fkRaw; } set { mp_fkRaw=value; } }
        public string code { get { return mp_code; } set { mp_code = value; } }
        public string lote { get { return mp_lote; } set { mp_lote = value; } }
        public double netweigth { get { return mp_netweigth; } set { mp_netweigth = value; } }
        public int fkStatus { get { return mp_fkStatus; } set { mp_fkStatus = value; } }
        public int fkUser { get { return mp_fkUser; } set { mp_fkUser = value; } }
        public DateTime date { get { return mp_date; } set { mp_date = value; } }
        public string notes { get { return mp_notes; } set { mp_notes = value; } }
        public clsRawMaterial rawMaterial = new clsRawMaterial();
        public clsUser Usuario = new clsUser();

        //Constructor

        public clsRawMaterialPallet()
        {
            codsec = 0;
            fkRaw = 0;
            code = "";
            lote = "";
            netweigth = 0;
            fkStatus = 0;
            fkUser = 0;
            notes = "";
            date = DateTime.Now;
        }
        public clsRawMaterialPallet(string codeRawPallet)
        {
            this.load(codeRawPallet);
            rawMaterial = new clsRawMaterial(this.fkRaw);
            if (this.fkUser != 0)
            {
                Usuario = new clsUser(this.fkUser);
            }
        }

        public clsRawMaterialPallet(int codsec)
        {
            this.load(codsec);
            // Controlar que el usuario por que esto tambien se llama en movements.
            rawMaterial = new clsRawMaterial(this.fkRaw);
            if (this.fkUser != 0)
            {
                Usuario = new clsUser(this.fkUser);
            }
            
        }
        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS= clsConnection.getDataSetResult("SELECT * FROM bps_prod_rawmaterialpallet WHERE mp_codsec = " + codsec.ToString());

            if(DS.Tables[0].Rows.Count > 0 )
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mp_codsec"]);
                this.fkRaw = Convert.ToInt32(DS.Tables[0].Rows[0]["mp_fkRaw"]);
                this.code = Convert.ToString(DS.Tables[0].Rows[0]["mp_code"]);
                this.lote = Convert.ToString(DS.Tables[0].Rows[0]["mp_lote"]);
                this.netweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mp_netWeigth"]);
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["mp_fkStatus"]);
                this.fkUser = Convert.ToInt32(DS.Tables[0].Rows[0]["mp_fkUser"]);
                this.date = Convert.ToDateTime(DS.Tables[0].Rows[0]["mp_date"]); 
                this.notes = Convert.ToString(DS.Tables[0].Rows[0]["mp_notes"]); 
            }
        }

        public void load(string codeRawPallet)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_rawmaterialpallet WHERE mp_code = " + "'" + codeRawPallet.ToString() + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mp_codsec"]);
                this.fkRaw = Convert.ToInt32(DS.Tables[0].Rows[0]["mp_fkRaw"]);
                this.code = Convert.ToString(DS.Tables[0].Rows[0]["mp_code"]);
                this.lote = Convert.ToString(DS.Tables[0].Rows[0]["mp_lote"]);
                this.netweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mp_netWeigth"]);
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["mp_fkStatus"]);
                this.fkUser = Convert.ToInt32(DS.Tables[0].Rows[0]["mp_fkUser"]);
                this.date = Convert.ToDateTime(DS.Tables[0].Rows[0]["mp_date"]);
                this.notes = Convert.ToString(DS.Tables[0].Rows[0]["mp_notes"]);
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_rawmaterialpallet ";
                    queryString += "VALUES ( ";
                    queryString += this.fkRaw.ToString() + ", ";
                    queryString += "'" + this.code.ToString() + "'" + ", ";
                    queryString += "'" + this.lote.ToString() + "'" + ", ";
                    queryString += this.netweigth.ToString() + ", ";
                    queryString += this.fkStatus.ToString() + ", ";
                    queryString += this.fkUser.ToString() + ", ";
                    queryString += "'" + this.date.ToString("dd/MM/yyyy hh:mm:ss") + "', ";
                    queryString += "'" + this.notes + "'); ";
                }
                else
                {
                    queryString += "UPDATE bps_prod_rawmaterialpallet ";
                    queryString += " SET ";
                    queryString += " mp_fkRaw = " + this.fkRaw.ToString() + ", ";
                    queryString += " mp_code = " + "'" + this.code.ToString() + "' , ";
                    queryString += " mp_lote = " + "'" + this.lote.ToString() + "' , ";
                    queryString += " mp_netWeigth = " + this.netweigth.ToString() + ", ";
                    queryString += " mp_fkStatus = " + this.fkStatus.ToString() + ", ";
                    queryString += " mp_fkUser = " + this.fkUser.ToString() + ", ";
                    queryString += " mp_date = " + "'" + this.date.ToString("dd/MM/yyyy hh:mm:ss") + "'," + "";
                    queryString += " mp_notes = " + "'" + this.notes.ToString() + "' ";
                    queryString += " WHERE mp_codsec = " + this.codsec.ToString() + ";";

                }
                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsRawMaterialPallet.save");
                return false;
            }
        }

        public static List<clsRawMaterialPallet> getStockInCoilCellarByPlantForRaw()
        {
            //NEgrada extrema por que nose si este formulario se sigue usando. 
            List<clsRawMaterialPallet> List = new List<clsRawMaterialPallet>();

            return List;
        }

        public static int getCodsecByCode(string code)
        {
            try
            {
                DataSet DS = new DataSet();

                DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_rawmaterialpallet WHERE mp_code = '" + code.ToString() + "'");

                if (DS.Tables[0].Rows.Count > 0)
                {
                    return Convert.ToInt32(DS.Tables[0].Rows[0]["mp_codsec"]);
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsRawMaterialPallet.save");
                return 0;
            }
        }
    }
}
