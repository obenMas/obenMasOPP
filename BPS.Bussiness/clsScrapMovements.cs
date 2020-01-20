using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace BPS.Bussiness
{
    public class clsScrapMovements
    {
        //Attributes

        private int sm_codsec;
        private int sm_fkScrap;
        private string sm_type;
        private int sm_fkOriginalCellar;
        private int sm_fkDestinationCellar;
        private int sm_fkScrapPallet;
        private int sm_fkCoil;
        private int sm_fkMainCoil;
        private int sm_fkUser;
        private double sm_netWeigth;
        private DateTime sm_date;

        //Properties

        public int codsec { get { return sm_codsec; } set { sm_codsec = value; } }
        public int fkScrap { get { return sm_fkScrap; } set { sm_fkScrap = value; } } //lo tiene el pallet
        public string type { get { return sm_type; } set { sm_type = value; } } //Movimiento de pale. una constante.
        public int fkOriginalCellar { get { return sm_fkOriginalCellar; } set { sm_fkOriginalCellar = value; } } //
        public int fkDestinationCellar { get { return sm_fkDestinationCellar; } set { sm_fkDestinationCellar = value; } } // esto lo tiene el clsBycoilCellar
        public int fkScrapPallet { get { return sm_fkScrapPallet; } set { sm_fkScrapPallet = value; } } //codsecScrappallet
        public int fkCoil { get { return sm_fkCoil; } set { sm_fkCoil = value; } } //lo debe tener la clase coil.
        public int fkMainCoil { get { return sm_fkMainCoil; } set { sm_fkMainCoil = value; } } //lo debe tener la clase MainCoil
        public int fkUser { get { return sm_fkUser; } set { sm_fkUser = value; } } //se saca del global.codsec
        public double netWeigth { get { return sm_netWeigth; } set { sm_netWeigth = value; } }
        public DateTime date { get { return sm_date; } set { sm_date = value; } } // yaa se instancia solo.
        public clsScrapPallet scrapPallet = new clsScrapPallet();
        public clsCoil Coil = new clsCoil();
        public clsCoilCellar coilOriginCellar = new clsCoilCellar();
        public clsCoilCellar coilDestinationCellar = new clsCoilCellar();
        public clsUser Usuario = new clsUser();
        public clsMainCoil mainCoil = new clsMainCoil();
        public clsScrap tScrap = new clsScrap();
        public clsRawMaterialPallet palletRawMaterial = new clsRawMaterialPallet();
        
        //Se puede usar metodo getlist y que traiga toda la tabla, pero de cada fk que necesito. 
        //Por ejemplo Toda la tabla de scrap segun una fkScrapPallet && fkCoil && fkUser

        //Constructor

        public clsScrapMovements()
        {
            codsec = 0;
            fkScrap = 0;
            type = "";
            fkOriginalCellar = 0;
            fkDestinationCellar = 0;
            fkScrapPallet = 0;
            fkCoil = 0;
            fkMainCoil = 0;
            fkUser = 0;
            netWeigth = 0;
            date = DateTime.Now;
        }
 
        public clsScrapMovements(int codsec)
        {
            this.load(codsec);
            scrapPallet = new clsScrapPallet(this.fkScrapPallet);
            coilOriginCellar= new clsCoilCellar(this.fkOriginalCellar);
            coilDestinationCellar = new clsCoilCellar(this.fkDestinationCellar);
            Usuario = new clsUser(this.fkUser);
            tScrap = new clsScrap(this.fkScrap);
            mainCoil = new clsMainCoil(this.fkMainCoil);
            Coil = new clsCoil(this.fkCoil);

        }

        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_scrapmovements WHERE sm_codsec = " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["sm_codsec"]);
                this.fkScrap = Convert.ToInt32(DS.Tables[0].Rows[0]["sm_fkScrap"]);
                this.type = Convert.ToString(DS.Tables[0].Rows[0]["sm_type"]);
                this.fkOriginalCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["sm_fkOriginalCellar"]);
                this.fkDestinationCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["sm_fkDestinationCellar"]);
                this.fkScrapPallet = Convert.ToInt32(DS.Tables[0].Rows[0]["sm_fkScrapPallet"]);
                this.fkCoil = Convert.ToInt32(DS.Tables[0].Rows[0]["sm_fkCoil"]);
                this.fkMainCoil = Convert.ToInt32(DS.Tables[0].Rows[0]["sm_fkMainCoil"]);
                this.fkUser = Convert.ToInt32(DS.Tables[0].Rows[0]["sm_fkUser"]);
                this.netWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["sm_netWeigth"]);
                this.date = Convert.ToDateTime(DS.Tables[0].Rows[0]["sm_date"]);

            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                //(sm_fkScrap,sm_type,sm_fkOriginalCellar,sm_fkDestinationCellar,sm_fkScrapPallet,sm_fkCoil,sm_fkMainCoil,sm_fkUser,sm_date)"
                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_scrapmovements ";
                    queryString += "VALUES ( ";
                    queryString += this.fkScrap.ToString() + ", ";
                    queryString += "'" + this.type.ToString() + "'" + ", ";
                    queryString += this.fkOriginalCellar.ToString() + ", ";
                    queryString += this.fkDestinationCellar.ToString() + ", ";
                    queryString += this.fkScrapPallet.ToString() + ", ";
                    queryString += this.fkCoil.ToString() + ", ";
                    queryString += this.fkMainCoil.ToString() + ", ";
                    queryString += this.fkUser.ToString() + ", ";
                    queryString += "'" + this.date.ToString("dd/MM/yyyy hh:mm:ss") + "' ,";
                    queryString += this.netWeigth.ToString() + "); ";
                }
                else
                {
                    queryString += "UPDATE bps_prod_scrapmovements (sm_fkScrap,sm_type,sm_fkOriginalCellar,sm_fkDestinationCellar,sm_fkScrapPallet,sm_fkCoil,sm_fkMainCoil,sm_fkUser,sm_date,sm_netWeigth)";
                    queryString += " SET ";
                    queryString += this.fkScrap.ToString() + ", ";
                    queryString += "'" + this.type.ToString() + "'" + ", ";
                    queryString += this.fkOriginalCellar.ToString() + ", ";
                    queryString += "'" + this.fkDestinationCellar.ToString() + "', ";
                    queryString += this.fkScrapPallet.ToString() + ", ";
                    queryString += this.fkCoil.ToString() + ", ";
                    queryString += this.fkMainCoil.ToString() + ", ";
                    queryString += this.fkUser.ToString() + ", ";
                    queryString += "'" + this.date.ToString("dd/MM/yyyy hh:mm:ss") + "', ";
                    queryString += this.netWeigth.ToString() + "";
                    queryString += " WHERE sm_codsec = " + this.codsec.ToString() + ";";

                }
                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsScrapMovements.save");
                return false;
            }
        }

        public static List<clsScrapMovements> getList()
        {
            List<clsScrapMovements> lstMovements = new List<clsScrapMovements>();
            clsScrapMovements movimientos = new clsScrapMovements();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_scrapmovements");


            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    // Instancio una lista de objetos de scrapmovements. Y por cada codsec se genera un 
                    // objeto con todos sus datos segun el codsec.

                    movimientos = new clsScrapMovements(Convert.ToInt32(DS.Tables[0].Rows[i]["sm_codsec"]));
                    lstMovements.Add(movimientos);

                }
               
            }
            return lstMovements;
        }
    }
}
