using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsNewExtrusionOrder
    {
        //Atributes

        private int neo_codsec;
        private int neo_fkBopp;
        private int neo_fkCast;
        private int neo_fkCoating;
        private int neo_quantity;
        private int neo_fkUser;
        private DateTime neo_date;
        private int neo_fkStatus;
        private string neo_observations;

        //Properties

        public int codsec { get { return neo_codsec; } set { neo_codsec = value; } }

        public int fkBopp { get { return neo_fkBopp; } set { neo_fkBopp = value; } }

        public int fkCast { get { return neo_fkCast; } set { neo_fkCast = value; } }

        public int fkCoating { get { return neo_fkCoating; } set { neo_fkCoating = value; } }

        public int quantity { get { return neo_quantity; } set { neo_quantity = value; } }

        public int fkUser { get { return neo_fkUser; } set { neo_fkUser = value; } }

        public DateTime date { get { return neo_date; } set { neo_date = value; } }

        public int fkStatus { get { return neo_fkStatus; } set { neo_fkStatus = value; } }

        public string observations { get { return neo_observations; } set { neo_observations = value; } }

        //Constructor

        public clsNewExtrusionOrder()
        {
            codsec = 0;
            fkBopp = 0;
            fkCast = 0;
            fkCoating = 0;
            quantity = 0;
            fkUser = 0;
            fkStatus = 0;
            observations = "";
        }

        public clsNewExtrusionOrder(int cod)
        {
            this.load(cod);
        }

        //Methods

        public void load(int cod)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_new_extrusionOrder where neo_codsec = " + cod.ToString());

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["neo_codsec"]);
                this.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["neo_fkBopp"]);
                this.fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["neo_fkCast"]);
                this.fkCoating = Convert.ToInt32(DS.Tables[0].Rows[0]["neo_fkCoating"]);
                this.quantity = Convert.ToInt32(DS.Tables[0].Rows[0]["neo_quantity"]);
                this.fkUser = Convert.ToInt32(DS.Tables[0].Rows[0]["neo_fkUser"]);
                this.date = Convert.ToDateTime(DS.Tables[0].Rows[0]["neo_date"]);
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["neo_fkStatus"]);
                this.observations = DS.Tables[0].Rows[0]["neo_observations"].ToString();
            }
        }

        public bool save()
        {
            try
            {

                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_new_extrusionOrder (neo_fkBopp, neo_fkCast, neo_fkCoating, neo_quantity, neo_fkUser, neo_date, neo_fkStatus, neo_observations)";
                    queryString += " VALUES (";
                    queryString += this.fkBopp + ", ";
                    queryString += this.fkCast + ", ";
                    queryString += this.fkCoating + ", ";
                    queryString += this.quantity + ", ";
                    queryString += this.fkUser + ", ";
                    queryString += "'" + this.date.ToString() + "', ";
                    queryString += this.fkStatus + ", ";
                    queryString += "'" + this.observations + "'";                    
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_new_extrusionOrder";
                    queryString += " SET ";
                    queryString += "neo_fkBopp = " + this.fkBopp + ", ";
                    queryString += "neo_fkCast = " + this.fkCast + ", ";
                    queryString += "neo_fkCoating = " + this.fkCoating + ", ";
                    queryString += "neo_quantity = " + this.quantity.ToString() + ", ";
                    queryString += "neo_fkUser = " + this.fkUser + ", ";
                    queryString += "neo_date = '" + this.date.ToString() + "', ";
                    queryString += "neo_fkStatus = " + this.fkStatus + ", ";
                    queryString += "neo_observations = '" + this.observations + "'";
                    queryString += " WHERE neo_codsec = " + this.codsec.ToString() + ";";
                    clsConnection.executeQuery(queryString);

                }
                return true;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsNewExtrusionOrder.save");
                return false;
            }
        }

        public static List<clsNewExtrusionOrder> getWithoutPlanningList()
        {
            List<clsNewExtrusionOrder> lista = new List<clsNewExtrusionOrder>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_new_extrusionOrder where neo_fkStatus = 3074" );

            if(DS.Tables.Count>0 && DS.Tables[0].Rows.Count>0)
            {
                for(int i=0;i<DS.Tables[0].Rows.Count;i++)
                {
                    lista.Add(new clsNewExtrusionOrder());
                    lista[lista.Count - 1].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["neo_codsec"]);
                    lista[lista.Count - 1].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["neo_fkBopp"]);
                    lista[lista.Count - 1].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["neo_fkCast"]);
                    lista[lista.Count - 1].fkCoating = Convert.ToInt32(DS.Tables[0].Rows[i]["neo_fkCoating"]);
                    lista[lista.Count - 1].quantity = Convert.ToInt32(DS.Tables[0].Rows[i]["neo_quantity"]);
                    lista[lista.Count - 1].fkUser = Convert.ToInt32(DS.Tables[0].Rows[i]["neo_fkUser"]);
                    lista[lista.Count - 1].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["neo_date"]);
                    lista[lista.Count - 1].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["neo_fkStatus"]);
                    lista[lista.Count - 1].observations = DS.Tables[0].Rows[i]["neo_observations"].ToString();
                }
            }

            return lista;
        }
    }
}
