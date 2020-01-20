using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsBonusParameters
    {
        private int bnp_codsec;
        private int bnp_fkBonusDetail;
        private int bnp_inferiorLimit;
        private int bnp_superiorLimit;
        private double bnd_percentage;

        public int codsec { get { return bnp_codsec; } set { bnp_codsec = value; } }

        public int fkBonusDetail { get { return bnp_fkBonusDetail; } set { bnp_fkBonusDetail = value; } }

        public int inferiorLimit { get { return bnp_inferiorLimit; } set { bnp_inferiorLimit = value; } }

        public int superiorLimit { get { return bnp_superiorLimit; } set { bnp_superiorLimit = value; } }

        public double percentage { get { return bnd_percentage; } set { bnd_percentage = value; } }

        public clsBonusParameters()
        { 
            bnp_codsec = 0;
            bnp_fkBonusDetail = 0;
            bnp_inferiorLimit = 0;
            bnp_superiorLimit = 0;
            bnd_percentage = 0;
        }

        public clsBonusParameters(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("select * from bps_admin_bonusParameters where bnp_codsec = " + codsec.ToString());

            if(DS.Tables.Count>0 && DS.Tables[0].Rows.Count>0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["bnp_codsec"]);
                this.fkBonusDetail = Convert.ToInt32(DS.Tables[0].Rows[0]["bnp_fkBonusDetail"]);
                this.inferiorLimit = Convert.ToInt32(DS.Tables[0].Rows[0]["bnp_inferiorLimit"]);
                this.superiorLimit = Convert.ToInt32(DS.Tables[0].Rows[0]["bnp_superiorLimit"]);
                this.percentage = Convert.ToDouble(DS.Tables[0].Rows[0]["bnp_percentage"]);
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_admin_bonusParameters (bnp_fkBonusDetail, bnp_inferiorLimit, bnp_superiorLimit, bnp_percentage)";
                    queryString += " VALUES (";
                    queryString += this.fkBonusDetail.ToString() + ", ";
                    queryString += this.inferiorLimit.ToString() + ", ";
                    queryString += this.superiorLimit.ToString() + ", ";
                    queryString += this.percentage.ToString() + " ";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_admin_bonusParameters";
                    queryString += " SET ";
                    queryString += "bnp_fkBonusDetail = " + this.fkBonusDetail.ToString() + ", ";
                    queryString += "bnp_inferiorLimit = " + this.inferiorLimit.ToString() + ", ";
                    queryString += "bnp_superiorLimit = " + this.superiorLimit.ToString() + ", ";
                    queryString += "bnp_percentage = " + this.percentage.ToString() + " ";
                    queryString += " WHERE bnp_codsec = " + this.codsec.ToString() + ";";
                }

                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsBonusParameters.save");
                return false;
            }

            
        }

        public static List<clsBonusParameters> getListByBonusDetail(int bon)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("select * from bps_admin_bonusParameters where bnp_fkBonusdetail = " + bon.ToString());

            List<clsBonusParameters> det = new List<clsBonusParameters>();

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    det.Add(new clsBonusParameters(Convert.ToInt32(DS.Tables[0].Rows[i]["bnp_codsec"])));
                }
            }

            return det;
        }
    }
}
