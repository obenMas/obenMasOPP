using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsRelabelEquivalencesMov
    {
        //Atributes
        private int rleq_codsec;
        private string rleq_type;
        private string rleq_code;
        private int rleq_fkLastProduct;
        private int rleq_fkNewProduct;
        private int rleq_fkPallet;
        private int rleq_fkCoil;
        private DateTime rleq_date;

        //Properties
        public int codsec { get { return rleq_codsec; } set { rleq_codsec = value; } }
        public string type { get { return rleq_type; } set { rleq_type = value; } }
        public string code { get { return rleq_code; } set { rleq_code = value; } }
        public int fkLastProduct { get { return rleq_fkLastProduct; } set { rleq_fkLastProduct = value; } }
        public int fkNewProduct { get { return rleq_fkNewProduct; } set { rleq_fkNewProduct = value; } }
        public int fkPallet { get { return rleq_fkPallet; } set { rleq_fkPallet = value; } }
        public int fkCoil { get { return rleq_fkCoil; } set { rleq_fkCoil = value; } }
        public DateTime date { get { return rleq_date; } set { rleq_date = value; } }

        //Constructor
        public clsRelabelEquivalencesMov()
        {
            codsec = 0;
            type = "";
            code = "";
            fkLastProduct = 0;
            fkNewProduct = 0;
            fkPallet = 0;
            fkCoil = 0;
        }

        public clsRelabelEquivalencesMov(string code)
        {
            this.load(code);
        }

        //Method

        public void load(string code)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELCT * FROM bps_prod_rlbelequivalencesmov WHERE rleq_code = " + code.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["rleq_codsec"]);
                this.type = Convert.ToString(DS.Tables[0].Rows[0]["rleq}_type"]);
                this.code = Convert.ToString(DS.Tables[0].Rows[0]["rleq_code"]);
                this.fkLastProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["rleq_fkLastProduct"]);
                this.fkNewProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["rleq_fkNewProduct"]);
                this.fkPallet = Convert.ToInt32(DS.Tables[0].Rows[0]["rleq_fkCoil"]);
                this.date = Convert.ToDateTime(DS.Tables[0].Rows[0]["rleq_date"]);
            }
        }

        public bool save()
        {
            DataSet DS = new DataSet();

            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_rlbelequivalencesmov(rleq_type,rleq_code,rleq_fkLastProduct,rleq_fkNewProduct,rleq_fkPallet,rleq_fkCoil,rleq_date)";
                    queryString += " VALUES (";
                    queryString += "'" + this.type.ToString() + "', '";
                    queryString += this.code.ToString() + "', ";
                    queryString += this.fkLastProduct.ToString() + ", ";
                    queryString += this.fkNewProduct.ToString() + ", ";
                    queryString += this.fkPallet.ToString() + ", ";
                    queryString += this.fkCoil.ToString() + ", ";
                    queryString += "'" + this.date.ToString("dd/MM/yyyy hh:mm:ss") + "');";
                }
                else
                {
                    queryString += "UPDATE bps_prod_rlbelequivalencesmov";
                    queryString += " SET ";
                    queryString += "'" + this.type.ToString() + ", ";
                    queryString += "'" + this.code.ToString() + ", ";
                    queryString += this.fkLastProduct.ToString() + ", ";
                    queryString += this.fkNewProduct.ToString() + ", ";
                    queryString += this.fkPallet.ToString() + ", ";
                    queryString += this.fkCoil.ToString() + ", ";
                    queryString += "'" + this.date.ToString("dd/MM/yyyy hh:mm:ss") + "');";
                    queryString += "WHERE rleq_code = " + this.code.ToString() + ";";
                }
                return clsConnection.executeQuery(queryString);    
            }
            catch(Exception ex)
            {
                clsLog.addLog(ex, 3, "clsRelabelEquivalencesMov.save");
                return false; 
            }
        }
    }
}
