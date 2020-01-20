using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsBonus
    {
        private int bns_codsec;
        private double bns_reward;

        public int codsec { get { return bns_codsec; } set { bns_codsec = value; } }

        public double reward { get { return bns_reward; } set { bns_reward = value; } }

        public clsBonus()
        { 
            bns_codsec = 0;
            bns_reward = 0;     
        }

        public clsBonus(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("select * from bps_admin_bonus where bns_codsec = " + codsec.ToString());

            if(DS.Tables.Count>0 && DS.Tables[0].Rows.Count>0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["bns_codsec"]);
                this.reward = Convert.ToDouble(DS.Tables[0].Rows[0]["bns_reward"]);
            }
            
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_admin_bonus (bns_reward)";
                    queryString += " VALUES (";
                    queryString += this.reward.ToString() + "";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_admin_bonus";
                    queryString += " SET ";
                    queryString += "bns_reward = " + this.reward.ToString() + "";
                    queryString += " WHERE bns_codsec = " + this.codsec.ToString() + ";";
                }

                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsBonus.save");
                return false;
            }

            
        }

        public List<clsBonusDetail> getDetail()
        {
            List<clsBonusDetail> detail = new List<clsBonusDetail>();

            detail = clsBonusDetail.getListByBonus(this.codsec);

            return detail;
        }
    }
}
