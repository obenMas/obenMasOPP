using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsAux
    {
        private int aux_codsec;
        private int aux_month;
        private int aux_year;
        private decimal aux_parameter;

        public int codsec { get { return aux_codsec; } set { aux_codsec = value; } }

        public int month { get { return aux_month; } set { aux_month = value; } }

        public int year { get { return aux_year; } set { aux_year = value; } }

        public decimal parameter { get { return aux_parameter; } set { aux_parameter = value; } }

        public clsAux()
        { 
            month = 0;
            year = 0;
            parameter = 0;
        }

        public clsAux(int cod)
        {
            this.load(cod);
        }

        public clsAux(int mon, int yea)
        {
            this.load(mon, yea);
        }

        //Methods

        public void load(int cod)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("select * from bps_admin_aux where aux_codsec = " + cod.ToString());

            if(DS.Tables.Count>0 && DS.Tables[0].Rows.Count>0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["aux_codsec"]);
                this.month = Convert.ToInt32(DS.Tables[0].Rows[0]["aux_month"]);
                this.year = Convert.ToInt32(DS.Tables[0].Rows[0]["aux_year"]);
                this.parameter = Convert.ToDecimal(DS.Tables[0].Rows[0]["aux_parameter"]);
            }
        }

        public void load(int mon, int yea)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("select * from bps_admin_aux where aux_month = '" + mon.ToString()+"' AND aux_year = '"+ yea.ToString()+"'");

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["aux_codsec"]);
                this.month = Convert.ToInt32(DS.Tables[0].Rows[0]["aux_month"]);
                this.year = Convert.ToInt32(DS.Tables[0].Rows[0]["aux_year"]);
                this.parameter = Convert.ToDecimal(DS.Tables[0].Rows[0]["aux_parameter"]);
            }
            else
            {
                this.month = mon;
                this.year = yea;
                this.parameter = 0;
                this.save();
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_admin_aux (aux_month, aux_year, aux_parameter)";
                    queryString += " VALUES (";
                    queryString += this.month.ToString() + ", ";
                    queryString += this.year.ToString() + ", ";
                    queryString += this.parameter.ToString() + " ";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_admin_aux";
                    queryString += " SET ";
                    queryString += "aux_month = " + this.month.ToString() + ", ";
                    queryString += "aux_year = " + this.year.ToString() + ", ";
                    queryString += "aux_parameter = " + this.parameter.ToString() + " ";
                    queryString += " WHERE aux_codsec = " + this.codsec.ToString() + ";";
                }

                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsAux.save");
                return false;
            }

            
        }
    }
}
