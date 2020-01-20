using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsBonusDetail
    {
        private int bnd_codsec;
        private int bnd_fkBonus;
        private string bnd_parameterName;
        private double bnd_percentage;

        public int codsec { get { return bnd_codsec; } set { bnd_codsec = value; } }

        public int fkBonus { get { return bnd_fkBonus; } set { bnd_fkBonus = value; } }

        public string parameterName { get { return bnd_parameterName; } set { bnd_parameterName = value; } }

        public double percentage { get { return bnd_percentage; } set { bnd_percentage = value; } }

        public clsBonusDetail()
        { 
            bnd_codsec = 0;
            bnd_fkBonus = 0;
            bnd_parameterName = "";
            bnd_percentage = 0;
        }

        public clsBonusDetail(int codsec)
        {
            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("select * from bps_admin_bonusDetail where bnd_codsec = " + codsec.ToString());

            if(DS.Tables.Count>0 && DS.Tables[0].Rows.Count>0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["bnd_codsec"]);
                this.fkBonus = Convert.ToInt32(DS.Tables[0].Rows[0]["bnd_fkBonus"]);
                this.parameterName = DS.Tables[0].Rows[0]["bnd_parameterName"].ToString();
                this.percentage = Convert.ToDouble(DS.Tables[0].Rows[0]["bnd_percentage"]);
            }
            
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_admin_bonusDetail (bnd_fkBonus, bnd_parameterName, bnd_percentage)";
                    queryString += " VALUES (";
                    queryString += this.fkBonus.ToString() + ", ";
                    queryString += "'"+this.parameterName + "', ";
                    queryString += this.percentage.ToString() + " ";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_admin_bonusDetail";
                    queryString += " SET ";
                    queryString += "bnd_fkBonus = " + this.fkBonus.ToString() + ", ";
                    queryString += "bnd_parameterName = '" + this.parameterName.ToString() + "', ";
                    queryString += "bnd_percentage = " + this.percentage.ToString() + " ";
                    queryString += " WHERE bnd_codsec = " + this.codsec.ToString() + ";";
                }

                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsBonusDetail.save");
                return false;
            }

            
        }

        public static List<clsBonusDetail> getListByBonus(int bon)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("select * from bps_admin_bonusDetail where bnd_fkBonus = " + bon.ToString());

            List<clsBonusDetail> det = new List<clsBonusDetail>();

            if(DS.Tables.Count>0 && DS.Tables[0].Rows.Count>0)
            {
                
                for(int i=0;i<DS.Tables[0].Rows.Count;i++)
                {
                    det.Add(new clsBonusDetail(Convert.ToInt32(DS.Tables[0].Rows[i]["bnd_codsec"])));
                }
            }

            return det;
        }

        public List<clsBonusParameters> getParameters()
        {
            List<clsBonusParameters> param = new List<clsBonusParameters>();

            param = clsBonusParameters.getListByBonusDetail(this.codsec);

            return param;
        }
    }
}
