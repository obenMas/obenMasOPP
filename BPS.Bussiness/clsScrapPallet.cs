using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace BPS.Bussiness
{
    public class clsScrapPallet
    {
        //Atributes
        private int sp_codsec;
        private int sp_fkScrap;
        private string sp_code;
        private double sp_netWeigth;
        private string sp_turn;
        private DateTime sp_date;
        private int sp_fkMachine;
        private int sp_fkStatus;

        //Properties 

        public int codsec { get { return sp_codsec; } set { sp_codsec = value; } }
        public int fkScrap { get { return sp_fkScrap; } set { sp_fkScrap = value; } }
        public clsScrap Scrap = new clsScrap();
        public string code { get { return sp_code; } set { sp_code = value; } }
        public double netWeigth { get { return sp_netWeigth; } set { sp_netWeigth = value; } }
        public string turn { get { return sp_turn; } set { sp_turn = value; } }
        public DateTime date { get { return sp_date; } set { sp_date = value; } }
        public int fkMachine { get { return sp_fkMachine; } set { sp_fkMachine = value; } }
        public clsMachine Machine = new clsMachine();
        public int fkStatus { get { return sp_fkStatus; } set { sp_fkStatus = value; } }

        //Constructor
        public clsScrapPallet()
        {
            codsec = 0;
            fkScrap = 0;
            code = "";
            netWeigth = 0;
            turn = "";
            date = DateTime.Now;
            fkMachine = 0;
            fkStatus = 0;

        }

        public clsScrapPallet(int codesec)
        {
            this.load(codesec);
            // Esta verificación se hace por si ingresa un codigo inexistente, o erroneo
            if (this.codsec != 0 )
            {
                Scrap = new clsScrap(this.fkScrap);
                Machine = new clsMachine(this.fkMachine, "Cutter");
                if(Machine.codsec==0)
                {
                    Machine = new clsMachine(this.fkMachine, "Metallizer");
                }
            }
        }

        public clsScrapPallet(string code)
        {
            this.load(code);

            // Esta verificación se hace por si ingresa un codigo inexistente, o erroneo.
            if (this.codsec != 0)
            {
                Scrap = new clsScrap(this.fkScrap);
                Machine = new clsMachine(this.fkMachine, "Cutter");
                if (Machine.codsec == 0)
                {
                    Machine = new clsMachine(this.fkMachine, "Metallizer");
                }
            }
        }

        // Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_scrappallet WHERE sp_codsec = " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["sp_codsec"]);
                this.fkScrap = Convert.ToInt32(DS.Tables[0].Rows[0]["sp_fkScrap"]);
                this.code = Convert.ToString(DS.Tables[0].Rows[0]["sp_code"]);
                this.netWeigth = Convert.ToInt32(DS.Tables[0].Rows[0]["sp_netWeigth"]);
                this.turn = Convert.ToString(DS.Tables[0].Rows[0]["sp_turn"]);
                this.date = Convert.ToDateTime(DS.Tables[0].Rows[0]["sp_date"]);
                this.fkMachine = Convert.ToInt32(DS.Tables[0].Rows[0]["sp_fkMachine"]);
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["sp_fkStatus"]);
            }

        }

        public void load(string code)
        {
            DataSet DS = new DataSet();
            // RECORDAR si le paso texto en el matching del where, ponerle ' TEXTO ' luego del campo con el que quiero matchear.

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_scrappallet WHERE sp_code = '" + code.ToString() + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["sp_codsec"]);
                this.fkScrap = Convert.ToInt32(DS.Tables[0].Rows[0]["sp_fkScrap"]);
                this.code = Convert.ToString(DS.Tables[0].Rows[0]["sp_code"]);
                this.netWeigth = Convert.ToInt32(DS.Tables[0].Rows[0]["sp_netWeigth"]);
                this.turn = Convert.ToString(DS.Tables[0].Rows[0]["sp_turn"]);
                this.date = Convert.ToDateTime(DS.Tables[0].Rows[0]["sp_date"]);
                this.fkMachine = Convert.ToInt32(DS.Tables[0].Rows[0]["sp_fkMachine"]);
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["sp_fkStatus"]);
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_scrappallet (sp_fkScrap,sp_code,sp_netWeigth,sp_turn,sp_date,sp_fkMachine,sp_fkStatus)";
                    queryString += "VALUES ( ";
                    queryString += this.fkScrap.ToString() + ", ";
                    queryString += "'" + this.code.ToString() + "'" + ", ";
                    queryString += this.netWeigth.ToString() + ", ";
                    queryString += "'" + this.turn.ToString() + "', "; 
                    queryString += "'" + this.date.ToString("dd/MM/yyyy hh:mm:ss") + "', ";
                    queryString += this.fkMachine.ToString() + ", ";
                    queryString += this.fkStatus.ToString() + ") ";
                 }
                else
                {
                    queryString += "UPDATE bps_prod_scrappallet";
                    queryString += " SET ";
                    queryString += " sp_fkScrap = " + this.fkScrap.ToString() + ", ";
                    queryString += " sp_code = " + "'" + this.code.ToString() + "' , ";
                    queryString += " sp_netWeigth = " + this.netWeigth.ToString() + ", ";
                    queryString += " sp_turn = " + "'" + this.turn.ToString() + "', ";
                    queryString += " sp_date = " + "'" +this.date.ToString("dd/MM/yyyy hh:mm:ss") + "', ";
                    queryString += " sp_fkMachine = " + this.fkMachine.ToString() + ", ";
                    queryString += " sp_fkStatus = " + this.fkStatus.ToString() + "";
                    queryString += " WHERE sp_codsec = " + this.codsec.ToString() + ";";
 
                }
                return clsConnection.executeQuery(queryString);
            }
            catch(Exception ex)
            {
                clsLog.addLog(ex, 3,"clsScrapPallet.save");
                return false;
            }
        }

        public bool delete()
        {
            try
            {
                string queryString = "";

                    if(this.codsec != 0)
                    {
                        queryString += "UPDATE bps_prod_scrappallet";
                        queryString += " SET ";
                        queryString += " sp_fkStatus = " + Convert.ToInt32(41) +  "";
                        queryString += " WHERE sp_codsec = " + this.codsec.ToString() + ";";
                    }
                    return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsScrapPallet.save");
                return false;
            }
        }

        public static List<clsScrapPallet> getStockInCoilCellarbyPlant(int fkplant)
        {
            List<clsScrapPallet> list = new List<clsScrapPallet>();
            DataSet DS = new DataSet();
            clsScrapPallet pallet;

            DS = clsConnection.getDataSetResult("CALL spScrapPalletInCoilCellarStockByPlant("+fkplant.ToString()+")");

            if(DS.Tables.Count>0)
            {
                for(int i=0;i<DS.Tables[0].Rows.Count;i++)
                {
                    pallet = new clsScrapPallet(Convert.ToInt32(DS.Tables[0].Rows[i]["codsec"]));
                    list.Add(pallet);
                }
            }

            return list;
        }

        public static bool setFkCoilcellarNew(int palletCodsec, int fkCoilcellarNew)
        {
             DataSet DS = new DataSet();
            string queryString = "";

            try
            {
                queryString += "UPDATE bps_prod_scrappalletbycoilcellar";
                queryString += " SET spbcc_fkCoilCellar = " + fkCoilcellarNew.ToString();
                queryString += " WHERE spbcc_fkScrapPallet = " + palletCodsec.ToString();

                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsScrapPallet.save");
                return false;
            }
        }

   }
}
