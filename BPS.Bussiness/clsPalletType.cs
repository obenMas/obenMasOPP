using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    public class clsPalletType
    {
        //Attributes
        private int pltt_codsec;
        private string pltt_name;
        private int pltt_coilNumber;
        private string pltt_coilOrientation;
        private int pltt_floors;
        private string pltt_code;


        //Properties
        public int codsec { get { return pltt_codsec; } set { pltt_codsec = value; } }

        public string name { get { return pltt_name; } set { pltt_name = value; } }

        public int coilNumber { get { return pltt_coilNumber; } set { pltt_coilNumber = value; } }

        public string coilOrientation { get { return pltt_coilOrientation; } set { pltt_coilOrientation = value; } }

        public int floors { get { return pltt_floors; } set { pltt_floors = value; } }

        public string code { get { return pltt_code; } set { pltt_code = value; } }

        //Constructor

        public clsPalletType()
        {
            codsec = 0;
            name = "";
            coilNumber = 0;
            coilOrientation = "";
            floors = 0;
            code = "";
        }
        public clsPalletType(int palletTypeCodsec)
        {
            this.load(palletTypeCodsec);
        }

        //Methods

        public void load(int palletTypeCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_palletType WHERE pltt_codsec = " + palletTypeCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["pltt_codsec"]);
                name = DS.Tables[0].Rows[0]["pltt_name"].ToString();
                coilNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["pltt_coilNumber"]);
                coilOrientation = DS.Tables[0].Rows[0]["pltt_coilOrientation"].ToString();
                floors = Convert.ToInt32(DS.Tables[0].Rows[0]["pltt_floors"]);
                code = DS.Tables[0].Rows[0]["pltt_code"].ToString();
            }
        }
        public static clsPalletType getPalletTypeByCode(string palletTypeCode)
        {

            DataSet DS = new DataSet();
            clsPalletType objPalletType = new clsPalletType();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_palletType where pltt_code = '" + palletTypeCode.ToString() + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                objPalletType.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["pltt_codsec"]);
                objPalletType.name = DS.Tables[0].Rows[0]["pltt_name"].ToString();
                objPalletType.coilNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["pltt_coilNumber"]);
                objPalletType.coilOrientation = DS.Tables[0].Rows[0]["pltt_coilOrientation"].ToString();
                objPalletType.floors = Convert.ToInt32(DS.Tables[0].Rows[0]["pltt_floors"]);
                objPalletType.code = DS.Tables[0].Rows[0]["pltt_code"].ToString();
            }

            return objPalletType;
        }
        public static List<clsPalletType> getList()
        {
            List<clsPalletType> lstPalletType = new List<clsPalletType>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_palletType  WHERE pltt_isVisible = 1 ORDER BY pltt_coilOrientation, pltt_coilNumber");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstPalletType.Add(new clsPalletType());
                    lstPalletType[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pltt_codsec"]);
                    lstPalletType[i].name = DS.Tables[0].Rows[i]["pltt_name"].ToString();
                    lstPalletType[i].coilNumber = Convert.ToInt32(DS.Tables[0].Rows[i]["pltt_coilNumber"]);
                    lstPalletType[i].coilOrientation = DS.Tables[0].Rows[i]["pltt_coilOrientation"].ToString();
                    lstPalletType[i].floors = Convert.ToInt32(DS.Tables[0].Rows[i]["pltt_floors"]);
                    lstPalletType[i].code = DS.Tables[0].Rows[i]["pltt_code"].ToString();
                }
            }
            return lstPalletType;
        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_pallettype (pltt_name, pltt_coilNumber, pltt_coilOrientation, pltt_floors, pltt_code)";
                    queryString += " VALUES (";
                    queryString += "'" + this.name + "', ";
                    queryString += this.coilNumber.ToString() + ", ";
                    queryString += "'" + this.coilOrientation + "', ";
                    queryString += "" + this.floors.ToString() + ", ";
                    queryString += "'" + this.code.ToString() + "');";
                }
                else
                {
                    queryString += "UPDATE bps_prod_pallettype ";
                    queryString += " SET ";
                    queryString += " pltt_name = '" + this.name + "'";
                    queryString += " pltt_coilNumber = " + this.coilNumber.ToString() + ",";
                    queryString += " pltt_coilOrientation = '" + this.coilOrientation + "',";
                    queryString += " pltt_floors = " + this.floors.ToString() + " ";
                    queryString += " WHERE pltt_codsec =  " + this.codsec.ToString() + ";";
                }
                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsPalletType.save");
                return false;
            }
        }
        public static clsPalletType getPalletTypeByCoilNumberFloorsOrientation(int coilNumber, int floors, string orientation)
        {
            clsPalletType objPalletType = new clsPalletType();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_palletType where pltt_coilNumber = " + coilNumber.ToString() + " AND pltt_floors = " + floors.ToString() + " AND pltt_coilOrientation = '" + orientation + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                objPalletType.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["pltt_codsec"]);
                objPalletType.name = DS.Tables[0].Rows[0]["pltt_name"].ToString();
                objPalletType.coilNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["pltt_coilNumber"]);
                objPalletType.coilOrientation = DS.Tables[0].Rows[0]["pltt_coilOrientation"].ToString();
                objPalletType.floors = Convert.ToInt32(DS.Tables[0].Rows[0]["pltt_floors"]);
            }

            return objPalletType;
        }
        public override string ToString()
        {
            return this.name + "   [" + code + "]";
        }
    }
}
