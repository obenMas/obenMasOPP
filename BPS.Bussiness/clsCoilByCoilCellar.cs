using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    public class clsCoilByCoilCellar
    {
        //Attributes

        private int cbcc_codsec;
        private int cbcc_fkCoilCellar;
        private int cbcc_fkCoil;
        private clsCoil cbcc_coil;
        private bool cbcc_In;
        private bool cbcc_Out;
        private DateTime cbcc_date;

        //Properties
        public int codsec { get { return cbcc_codsec; } set { cbcc_codsec = value; } }

        public int fkCoilCellar { get { return cbcc_fkCoilCellar; } set { cbcc_fkCoilCellar = value; } }

        public int fkCoil { get { return cbcc_fkCoil; } set { cbcc_fkCoil = value; } }

        public clsCoil coil { get { return cbcc_coil; } set { cbcc_coil = value; } }

        public bool In { get { return cbcc_In; } set { cbcc_In = value; } }

        public bool Out { get { return cbcc_Out; } set { cbcc_Out = value; } }

        public DateTime date { get { return cbcc_date; } set { cbcc_date = value; } }

        //Constructor
        public clsCoilByCoilCellar()
        {
            codsec = 0;
            fkCoilCellar = 0;
            fkCoil = 0;
            coil = new clsCoil();
            In = false;
            Out = false;
            date = DateTime.Now;
        }

        //Methods
        public void load()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilByCoilCellar");

            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cbcc_codsec"]);
                fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["cbcc_fkCoilCellar"]);
                fkCoil = Convert.ToInt32(DS.Tables[0].Rows[0]["cbcc_fkCoil"]);
                coil = new clsCoil(fkCoil);
                In = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cbcc_in"], DS.Tables[0].Rows[0]["cbcc_in"].GetType().FullName);
                Out = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cbcc_out"], DS.Tables[0].Rows[0]["cbcc_out"].GetType().FullName);
                date = Convert.ToDateTime(DS.Tables[0].Rows[0]["cbcc_date"]);
            }
        }

        public void load(int coil)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilByCoilCellar WHERE cbcc_fkCoil = " + coil.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cbcc_codsec"]);
                fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["cbcc_fkCoilCellar"]);
                fkCoil = Convert.ToInt32(DS.Tables[0].Rows[0]["cbcc_fkCoil"]);
                In = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cbcc_in"], DS.Tables[0].Rows[0]["cbcc_in"].GetType().FullName);
                Out = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cbcc_out"], DS.Tables[0].Rows[0]["cbcc_out"].GetType().FullName);
                date = Convert.ToDateTime(DS.Tables[0].Rows[0]["cbcc_date"]);
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    if (this.fkCoilCellar > 0)
                    {
                        queryString += "INSERT INTO bps_prod_coilbycoilcellar (cbcc_fkCoilCellar, cbcc_fkCoil, cbcc_in, cbcc_out, cbcc_date)";
                        queryString += " VALUES (";
                        queryString += "" + this.fkCoilCellar.ToString() + ", ";
                        queryString += "" + this.fkCoil.ToString() + ", ";
                        queryString += "" + this.In.ToString() + ", ";
                        queryString += "" + this.Out.ToString() + ", ";
                        queryString += "'" + this.date.ToString("dd/MM/yyyy HH:mm") + "' ";
                        queryString += ");";
                    }
                }
                else
                {
                    queryString += "UPDATE bps_prod_coilbycoilcellar";
                    queryString += " SET ";
                    queryString += "cbcc_fkCoilCellar = " + this.fkCoilCellar.ToString() + " ";
                    queryString += "WHERE cbcc_fkCoil = " + this.fkCoil.ToString() + " ";
                }
                if (fkCoilCellar == 0)
                    return true;
                else
                {
                    if (clsConnection.executeQuery(queryString))
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCoilByCoilCellar.save");
                return false;
            }
        }

        public static List<clsCoilByCoilCellar> getCoilListByCoilCellar(int coilCellarCodsec)
        {
            List<clsCoilByCoilCellar> lstCoilByCoilCellar = new List<clsCoilByCoilCellar>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilByCoilCellar");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoilByCoilCellar.Add(new clsCoilByCoilCellar());
                    lstCoilByCoilCellar[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cbcc_codsec"]);
                    lstCoilByCoilCellar[i].fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["cbcc_fkCoilCellar"]);
                    lstCoilByCoilCellar[i].fkCoil = Convert.ToInt32(DS.Tables[0].Rows[i]["cbcc_fkCoil"]);
                    lstCoilByCoilCellar[i].coil = new clsCoil(lstCoilByCoilCellar[i].fkCoil);
                    lstCoilByCoilCellar[i].In = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cbcc_in"], DS.Tables[0].Rows[i]["cbcc_in"].GetType().FullName);
                    lstCoilByCoilCellar[i].Out = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cbcc_out"], DS.Tables[0].Rows[i]["cbcc_out"].GetType().FullName);
                    lstCoilByCoilCellar[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["cbcc_date"]);
                }
            }

            return lstCoilByCoilCellar;
        }
    }
}
