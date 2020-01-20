using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsSilo
    {
        //Atributes

        private int slo_codsec;
        private string slo_name;
        private int slo_fkrawtype;
        private string slo_rawname;


        //Properties

        public int codsec { get { return slo_codsec; } set { slo_codsec = value; } }

        public string name { get { return slo_name; } set { slo_name = value; } }

        public int fkrawtype { get { return slo_fkrawtype; } set { slo_fkrawtype = value; } }

        public string rawname { get { return slo_rawname; } set { slo_rawname = value; } }

        //Constructor

        public clsSilo()
        {
            slo_codsec = 0;
            slo_name = "";
            slo_fkrawtype = 0;
            slo_rawname = "";
        }

        public clsSilo(int codsec)
        {
            this.load(codsec);
        }

        public void load(int codsec)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_silo where slo_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["slo_codsec"]);
            this.name = DS.Tables[0].Rows[0]["slo_name"].ToString();
            this.fkrawtype = Convert.ToInt32(DS.Tables[0].Rows[0]["slo_fkrawtype"]);
            this.rawname = DS.Tables[0].Rows[0]["slo_rawname"].ToString();
        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_silo (slo_fkrawtype, slo_rawname)";
                    queryString += " VALUES (";
                    queryString += this.fkrawtype.ToString() + ", ";
                    queryString += "'"+this.rawname + "' ";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_prod_silo";
                    queryString += " SET ";
                    queryString += "slo_fkrawtype = " + this.fkrawtype.ToString()+", ";
                    queryString += "slo_rawname = '" + this.rawname + "'";
                    queryString += " WHERE slo_codsec = " + this.codsec.ToString();
                    clsConnection.executeQuery(queryString);
                }
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsSilo.save");
                return false;
            }
        }

        public bool changeMaterial(int raw, string rawname)
        {
            List<clsRawMaterialbySilo> list =clsRawMaterialbySilo.getListTotalized();

            for(int i=0;i<list.Count;i++)
            {
                if (this.codsec == list[i].fksilo)
                {
                    if (list[i].weigth == 0)
                    {
                        this.fkrawtype = raw;
                        this.rawname = rawname;
                        this.save();
                        return true;
                    }
                }
            }

            return false;
        }


        public static List<clsSilo> getList()
        {
            List<clsSilo> lstSilo = new List<clsSilo>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_silo order by slo_name asc");

            lstSilo.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstSilo.Add(new clsSilo());
                lstSilo[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["slo_codsec"]);
                lstSilo[i].name = DS.Tables[0].Rows[i]["slo_name"].ToString();
                lstSilo[i].fkrawtype = Convert.ToInt32(DS.Tables[0].Rows[0]["slo_fkrawtype"]);
                lstSilo[i].rawname = DS.Tables[0].Rows[0]["slo_rawname"].ToString();
            }

            return lstSilo;
        }
    }
}
