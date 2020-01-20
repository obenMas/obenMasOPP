using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    public class clsPalletDimentions
    {
        // Attributes
        private int pltd_codsec;
        private int pltd_width;
        private int pltd_depth;

        // Properties
        public int codsec { get { return pltd_codsec; } set { pltd_codsec = value; } }

        public int width { get { return pltd_width; } set { pltd_width = value; } }

        public int depth { get { return pltd_depth; } set { pltd_depth = value; } }


        // Constructor
        public clsPalletDimentions()
        {
            codsec = 0;
            width = 0;
            depth = 0;
        }
        public clsPalletDimentions(int palletDimentionCodsec)
        {
            this.load(palletDimentionCodsec);
        }

        // Methods
        public void load(int palletDimentionCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_palletdimention where pltd_codsec = " + palletDimentionCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["pltd_codsec"]);
                width = Convert.ToInt32(DS.Tables[0].Rows[0]["pltd_width"]);
                depth = Convert.ToInt32(DS.Tables[0].Rows[0]["pltd_depth"]);                
            }
        }
        public static List<clsPalletDimentions> getList()
        {
            List<clsPalletDimentions> lstPalletDimentions = new List<clsPalletDimentions>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_palletdimention order by pltd_width, pltd_depth");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstPalletDimentions.Add(new clsPalletDimentions());
                    lstPalletDimentions[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pltd_codsec"]);
                    lstPalletDimentions[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["pltd_width"]);
                    lstPalletDimentions[i].depth = Convert.ToInt32(DS.Tables[0].Rows[i]["pltd_depth"]);
                }
            }
            return lstPalletDimentions;
        }

        public static List<clsPalletDimentions> getListByWidth(int width)
        {
            List<clsPalletDimentions> lstPalletDimentions = new List<clsPalletDimentions>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_palletdimention WHERE pltd_width = " + width.ToString() + " ORDER BY pltd_depth ASC");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstPalletDimentions.Add(new clsPalletDimentions());
                    lstPalletDimentions[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pltd_codsec"]);
                    lstPalletDimentions[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["pltd_width"]);
                    lstPalletDimentions[i].depth = Convert.ToInt32(DS.Tables[0].Rows[i]["pltd_depth"]);
                }
            }
            return lstPalletDimentions;
        }

        public static int getCodsecByWidthAndDepth(int width, int depth)
        {
            List<clsPalletDimentions> lstPalletDimentions = new List<clsPalletDimentions>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_palletdimention WHERE pltd_width = " + width.ToString() + " AND pltd_depth = " + depth.ToString());

            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(DS.Tables[0].Rows[0]["pltd_codsec"]);
            else
                return 0;
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_palletdimention (pltd_width, pltd_depth)";
                    queryString += " VALUES (";
                    queryString += this.width.ToString() + ", ";
                    queryString += this.depth.ToString() + ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_palletdimention ";
                    queryString += " SET ";
                    queryString += " pltd_width = " + this.width.ToString() + ",";
                    queryString += " pltd_depth = " + this.depth.ToString() + " ";
                    queryString += " WHERE pltd_codsec =  " + this.codsec.ToString() + ";";
                }
                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsPalletDimentions.save");
                return false;
            }
        }

        public override string ToString()
        {
            return this.width.ToString() + " x " + this.depth.ToString();
        }
    }
}
