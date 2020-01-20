using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsSupplier
    {
        //Attribute
        private string sp_trademark;
        private string sp_abreviation;
        private int sp_codsec;


        //Properties

        public int codsec{get { return sp_codsec; }set { sp_codsec = value; }}
        public string trademark{get { return sp_trademark; }set { sp_trademark = value; }}
        public string abreviation{get { return sp_abreviation; }set { sp_abreviation = value; }}
        
        //Constructor
        public clsSupplier()
        {
            codsec = 0;
            trademark = "";
            abreviation = "";
        }

        public clsSupplier(string abr)
        {
            this.load(abr);
        }

        //Methods

        public void load(string abr)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_supplier WHERE sp_abreviation =" + abr.ToString());

            if (DS.Tables.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["sp_codsec"]);
                this.trademark = DS.Tables[0].Rows[0]["sp_trademark"].ToString();
                this.abreviation = DS.Tables[0].Rows[0]["sp_abreviation"].ToString();
            }
        }


        public bool save()
        {
            string query = "";

            try
            {
                if (this.codsec == 0)
                {
                    query = "INSERT INTO bps_prod_supplier(sp_trademark,sp_abreviation)";
                    query += " VALUES( '";
                    query += this.trademark.ToString() + "','";
                    query += this.abreviation.ToString() + "'";
                }
                else
                {
                    query = "UPDATE bps_prod_supplier";
                    query += "SET";
                    query += "sp_trademark = '" + this.trademark.ToString() + "',";
                    query += "sp_abreviation = '" + this.abreviation.ToString() + "' ";
                    query += "WHERE sp_codsec = " + this.codsec.ToString() + ";"; 
                }

                return clsConnection.executeQuery(query);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsSupplier.save");
                return false;
            }
        }
    }
}
