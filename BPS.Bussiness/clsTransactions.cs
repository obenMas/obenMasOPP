using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsTransactions
    {
        //Atributes

        private int tran_codsec;
        private string tran_codAlfa;
        private string tran_code;
        private string tran_lotNumber;
        private int tran_fkCoilCellar;
        private double tran_quantity;
        private string tran_transaction;
        private string tran_reference;
        private int tran_fkUser;
        private DateTime tran_date;

        //Properties

        public int codsec { get { return tran_codsec; } set { tran_codsec = value; } }

        public string codAlfa { get { return tran_codAlfa; } set { tran_codAlfa = value; } }

        public string code { get { return tran_code; } set { tran_code = value; } }

        public string lotNumber { get { return tran_lotNumber; } set { tran_lotNumber = value; } }

        public int fkCoilCellar { get { return tran_fkCoilCellar; } set { tran_fkCoilCellar = value; } }

        public double quantity { get { return tran_quantity; } set { tran_quantity = value; } }

        public string transaction { get { return tran_transaction; } set { tran_transaction = value; } }

        public string reference { get { return tran_reference; } set { tran_reference = value; } }

        public int fkUser { get { return tran_fkUser; } set { tran_fkUser = value; } }

        public DateTime date { get { return tran_date; } set { tran_date = value; } }

        //Constructor

        public clsTransactions()
        {
            codsec = 0;
            codAlfa = "";
            code = "";
            lotNumber = "";
            fkCoilCellar = 0;
            quantity = 0;
            transaction = "";
            reference = "";
            fkUser = 0;
        }

        public clsTransactions(int cod)
        {
            this.load(cod);
        }

        //Methods

        public void load(int cod)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_transactions where tran_codsec = " + cod.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["tran_codsec"]);
                this.codAlfa = DS.Tables[0].Rows[0]["tran_codAlfa"].ToString();
                this.code = DS.Tables[0].Rows[0]["tran_code"].ToString();
                this.lotNumber = DS.Tables[0].Rows[0]["tran_lotNumber"].ToString();
                this.fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["tran_fkCoilCellar"]);
                this.quantity = Convert.ToDouble(DS.Tables[0].Rows[0]["tran_quantity"]);
                this.transaction = DS.Tables[0].Rows[0]["tran_transaction"].ToString();
                this.reference = DS.Tables[0].Rows[0]["tran_reference"].ToString();
                this.fkUser = Convert.ToInt32(DS.Tables[0].Rows[0]["tran_fkUser"]);
                this.date = Convert.ToDateTime(DS.Tables[0].Rows[0]["tran_date"]);
            }
        }

        public bool save()
        {
            try
            {

                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_transactions (tran_codAlfa, tran_code, tran_lotNumber, tran_fkCoilCellar, tran_quantity, tran_transaction, tran_reference, tran_fkUser, tran_date)";
                    queryString += " VALUES (";
                    queryString += "'" + this.codAlfa + "',";
                    queryString += "'" + this.code + "',";
                    queryString += "'" + this.lotNumber + "',";
                    queryString += this.fkCoilCellar.ToString() + ",";
                    queryString += this.quantity.ToString() + ",";
                    queryString += "'" + this.transaction.ToString() + "',";
                    queryString += "'" + this.reference.ToString() + "',";
                    queryString += this.fkUser.ToString() + ",";
                    queryString += "'" + this.date.ToString() + "'";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_prod_transactions";
                    queryString += " SET ";
                    queryString += "tran_codAlfa = '" + this.codAlfa + "',";
                    queryString += "tran_code = '" + this.code + "',";
                    queryString += "tran_lotNumber = '" + this.lotNumber + "',";
                    queryString += "tran_fkCoilCellar = " + this.fkCoilCellar.ToString() + ",";
                    queryString += "tran_quantity = " + this.quantity.ToString() + ",";
                    queryString += "tran_transaction = '" + this.transaction + "',";
                    queryString += "tran_reference = '" + this.reference + "',";
                    queryString += "tran_fkUser = " + this.fkUser.ToString() + ",";
                    queryString += "tran_date = '" + this.date.ToString() + "'";
                    queryString += " WHERE tran_codsec = " + this.codsec.ToString() + ";";
                    clsConnection.executeQuery(queryString);

                }
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsTrasactions.save");
                return false;
            }
        }

        public static bool addPreseaReception(string codA, string cod, string lot, int cel, double q, string refe)
        {
            clsTransactions tran = new clsTransactions();
            tran.codAlfa = codA;
            tran.code = cod;
            tran.lotNumber = lot;
            tran.fkCoilCellar = cel;
            tran.quantity = q;
            tran.transaction = "Recepción de materiales por interfaz Presea";
            tran.fkUser = clsGlobal.LoggedUser.codsec;
            tran.date = DateTime.Now;
            return tran.save();
        }

        public static bool addIntercellarMovement(string codA, string cod, string lot, int celOrig, int celDest, double q)
        {
            bool result = false;

            clsTransactions tran = new clsTransactions();
            tran.codAlfa = codA;
            tran.code = cod;
            tran.lotNumber = lot;
            tran.fkCoilCellar = celOrig;
            tran.quantity = -q;
            tran.transaction = "Movimiento entre bodegas";
            tran.fkUser = clsGlobal.LoggedUser.codsec;
            tran.date = DateTime.Now;
            result=tran.save();

            tran = new clsTransactions();
            tran.codAlfa = codA;
            tran.code = cod;
            tran.lotNumber = lot;
            tran.fkCoilCellar = celDest;
            tran.quantity = q;
            tran.transaction = "Movimiento entre bodegas";
            tran.fkUser = clsGlobal.LoggedUser.codsec;
            tran.date = DateTime.Now;
            return tran.save() && result;
        }

        public static bool addExtrusionNotification(string codA, string cod, string lot, int cel, double q)
        {
            clsTransactions tran = new clsTransactions();
            tran.codAlfa = codA;
            tran.code = cod;
            tran.lotNumber = lot;
            tran.fkCoilCellar = cel;
            tran.quantity = q;
            tran.transaction = "Alta por extrusión";
            tran.fkUser = clsGlobal.LoggedUser.codsec;
            tran.date = DateTime.Now;
            return tran.save();
        }

        public static bool addCuttingNotification(string codA, string cod, string lot, int cel, double q)
        {
            clsTransactions tran = new clsTransactions();
            tran.codAlfa = codA;
            tran.code = cod;
            tran.lotNumber = lot;
            tran.fkCoilCellar = cel;
            tran.quantity = q;
            tran.transaction = "Alta por corte";
            tran.fkUser = clsGlobal.LoggedUser.codsec;
            tran.date = DateTime.Now;
            return tran.save();
        }

        public static bool addCuttingConsumption(string codA, string cod, string lot, int cel, double q)
        {
            clsTransactions tran = new clsTransactions();
            tran.codAlfa = codA;
            tran.code = cod;
            tran.lotNumber = lot;
            tran.fkCoilCellar = cel;
            tran.quantity = q;
            tran.transaction = "baja por corte";
            tran.fkUser = clsGlobal.LoggedUser.codsec;
            tran.date = DateTime.Now;
            return tran.save();
        }

        public static bool addDispatch(string codA, string cod, string lot, int cel, double q)
        {
            clsTransactions tran = new clsTransactions();
            tran.codAlfa = codA;
            tran.code = cod;
            tran.lotNumber = lot;
            tran.fkCoilCellar = cel;
            tran.quantity = q;
            tran.transaction = "baja por despacho";
            tran.fkUser = clsGlobal.LoggedUser.codsec;
            tran.date = DateTime.Now;
            return tran.save();
        }

        public static bool addPackingNotification(string codA, string cod, string lot, int cel, double q)
        {
            clsTransactions tran = new clsTransactions();
            tran.codAlfa = codA;
            tran.code = cod;
            tran.lotNumber = lot;
            tran.fkCoilCellar = cel;
            tran.quantity = q;
            tran.transaction = "alta por empaque";
            tran.fkUser = clsGlobal.LoggedUser.codsec;
            tran.date = DateTime.Now;
            return tran.save();
        }

        public static bool addPackingConsumption(string codA, string cod, string lot, int cel, double q)
        {
            clsTransactions tran = new clsTransactions();
            tran.codAlfa = codA;
            tran.code = cod;
            tran.lotNumber = lot;
            tran.fkCoilCellar = cel;
            tran.quantity = q;
            tran.transaction = "baja por empaque";
            tran.fkUser = clsGlobal.LoggedUser.codsec;
            tran.date = DateTime.Now;
            return tran.save();
        }
    }
}
