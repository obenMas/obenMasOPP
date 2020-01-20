using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Globalization;


namespace BPS.Bussiness
{
   public class clsScrapByExtruderCellar
    {   
        // Attributes

        private int sec_codsec;
        private int sec_fkScrap;
        private double sec_weigth;
        private int sec_fkcoilcellar;

        // Properties
        public int codsec { get { return sec_codsec; } set { sec_codsec = value; } }
        public int fkScrap { get { return sec_fkScrap; } set { sec_fkScrap = value; } }
        public double weigth { get { return sec_weigth; } set { sec_weigth = value; } }
        public int fkCoilCellar { get { return sec_fkcoilcellar; } set { sec_fkcoilcellar = value; } }
        public clsScrap Scrap = new clsScrap();
        public clsScrapPallet ScrapPallet = new clsScrapPallet();
        public clsCoilCellar deposito = new clsCoilCellar();

        // Constructor
       
        public clsScrapByExtruderCellar()
        {
            codsec = 0;
            fkScrap = 0;
            weigth = 0;
            fkCoilCellar = 0;
        }
        public clsScrapByExtruderCellar(int frkScrap, int fkCoilCellar)
        {
            this.load(frkScrap,fkCoilCellar);
        }
        public clsScrapByExtruderCellar(int codsec)
        {
            this.load(codsec);
            deposito = new clsCoilCellar(this.fkCoilCellar);
            Scrap = new clsScrap(this.fkScrap);
        }

        // Metodos
 
        public bool acuWeigth(double weig)
        {
            this.weigth = this.weigth + weig;
            return this.saveWeigth();
        }

        public void load(int frkScrap,int fkCoilCellar)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_scrapbyextrudercellar WHERE (sec_fkScrap = " + frkScrap.ToString() + " AND sec_fkcoilcellar =" + fkCoilCellar.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["sec_codsec"]);
                this.fkScrap = Convert.ToInt32(DS.Tables[0].Rows[0]["sec_fkScrap"]);
                this.weigth = Convert.ToDouble(DS.Tables[0].Rows[0]["sec_weigth"]);
                this.fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["sec_fkcoilcellar"]);
            }
        }

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_scrapbyextruderCellar WHERE sec_codsec = " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["sec_codsec"]);
                this.fkScrap = Convert.ToInt32(DS.Tables[0].Rows[0]["sec_fkScrap"]);
                this.weigth = Convert.ToInt32(DS.Tables[0].Rows[0]["sec_weigth"]);
                this.fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["sec_fkcoilcellar"]);
            }
        }

        public bool saveWeigth()
        {
            try
            {
                string queryString = "";
               // hacer el update aca.

                if ((sec_fkScrap != 0) && (sec_fkcoilcellar != 0))
                {
                    queryString += "UPDATE bps_prod_scrapbyextrudercellar";
                    queryString += " SET ";
                    queryString += " sec_weigth = " + this.weigth.ToString() + "";
                    queryString += " WHERE (sec_fkScrap = " + this.fkScrap.ToString() + "";
                    queryString += " AND ";
                    queryString += " sec_fkcoilcellar= " + this.fkCoilCellar.ToString() + "); ";
                }
                else
	            {
                    MessageBox.Show("Anduvo mal el update", "Desconfirmación", MessageBoxButtons.OK);
                }                
                return clsConnection.executeQuery(queryString);
            }            
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsScrapByExtruderCellar.save");
                return false;
            }

        }
        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_scrapbyextrudercellar(sec_fkScrap,sec_weigth,sec_fkcoilcellar)";
                    queryString += "VALUES (";
                    queryString += this.fkScrap.ToString() + ", ";
                    queryString += this.weigth.ToString() + ", ";
                    queryString += this.fkCoilCellar.ToString() + ") ";

                }
                else
                {
                    queryString += "UPDATE bps_prod_scrapbyextrudercellar(sec_fkScrap,sec_weigth)";
                    queryString += " SET ";
                    queryString += " sec_fkScrap = " + this.fkScrap.ToString() + ", ";
                    queryString += " sec_weigth = " + this.weigth.ToString() + "";
                    queryString += " WHERE sec_codsec = " + this.codsec.ToString() + ";";
                }
                return clsConnection.executeQuery(queryString);
            }
            catch(Exception ex)
            {
                clsLog.addLog(ex, 3, "clsScrapByExtruderCellar.save");
                return false;
            }
        }

        public static List<clsScrapByExtruderCellar> getWeigthInExtruderCellarByPlant(int fkplant)
        {
            List<clsScrapByExtruderCellar> listaSEC = new List<clsScrapByExtruderCellar>();
            DataSet DS = new DataSet();
            clsScrapByExtruderCellar scrapEC;

            DS = clsConnection.getDataSetResult("CALL spScrapWeigthByExtruderCellarByPlant( " + fkplant + ")");

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    scrapEC = new clsScrapByExtruderCellar(Convert.ToInt32(DS.Tables[0].Rows[i]["codsec"]));
                    listaSEC.Add(scrapEC); 
                }
            }
            return listaSEC;
        }
    }
}
