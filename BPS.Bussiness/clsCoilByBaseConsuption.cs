using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace BPS.Bussiness
{
    public class clsCoilByBaseConsuption
    {
        private int cbbc_codsec;
        private int cbbc_fkCoil;
        private int cbbc_fkNewMetalOrder;
        private int cbbc_length;

        public int codsec{get { return cbbc_codsec; }set { cbbc_codsec = value; }}
        public int fkCoil{get { return cbbc_fkCoil; }set { cbbc_fkCoil = value; }}
        public int fkNewMetalOrder{get { return cbbc_fkNewMetalOrder; }set { cbbc_fkNewMetalOrder = value; }}
        public int length{get { return cbbc_length; }set { cbbc_length = value; }}


        public clsCoilByBaseConsuption()
        {
            codsec = 0;
            fkCoil = 0;
            fkNewMetalOrder = 0;
            length = 0;
        }

        public clsCoilByBaseConsuption(int fkCoil)
        {
            this.load(fkCoil);
        }

        private void load(int fkCoil)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilbybaseconsuption WHERE cbbc_fkCoil = " + fkCoil.ToString());

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cbbc_codsec"]);
                this.fkCoil = Convert.ToInt32(DS.Tables[0].Rows[0]["cbbc_fkCoil"]);
                this.fkNewMetalOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["cbbc_fkNewMetalOrder"]);
                this.length = Convert.ToInt32(DS.Tables[0].Rows[0]["cbbc_length"]);
            }

        }

        public bool save()
        {

            string query = "";
 
            try
            {
                if (codsec == 0)
                {
                    query = "INSERT INTO bps_prod_coilbybaseconsuption(cbbc_fkCoil,cbbc_fkNewMetalOrder,cbbc_length)";
                    query += "VALUES( ";
                    query += this.fkCoil.ToString() + ",";
                    query += this.fkNewMetalOrder.ToString() + ",";
                    query += this.length.ToString() + ");";
                }
                else
                {
                    query = "UPDATE bps_prod_coilbybaseconsuption";
                    query += "SET";
                    query += "cbbc_fkCoil = " + this.fkCoil.ToString() + ",";
                    query += "cbbc_fkNewMetalOrder = " + this.fkNewMetalOrder.ToString() + ",";
                    query += "cbbc_length = " + this.length + ", ";
                    query += "WHERE cbbc_codsec = " + this.codsec.ToString();
                }

                return clsConnection.executeQuery(query);
 
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCoilByBaseConsuptio.save");
                return false;
            }   
        }

    }
}
