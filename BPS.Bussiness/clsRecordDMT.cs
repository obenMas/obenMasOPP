using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsRecordDMT
    {
        private int rdmt_codsec;

        public int codsec
        {
            get { return rdmt_codsec; }
            set { rdmt_codsec = value; }
        }

        private int rdmt_fkProductionOrder;

        public int fkProductionOrder
        {
            get { return rdmt_fkProductionOrder; }
            set { rdmt_fkProductionOrder = value; }
        }

        private string rdmt_head;

        public string head
        {
            get { return rdmt_head; }
            set { rdmt_head = value; }
        }

        private string rdmt_footer;

        public string footer
        {
            get { return rdmt_footer; }
            set { rdmt_footer = value; }
        }

        private string rdmt_body;

        public string body
        {
            get { return rdmt_body; }
            set { rdmt_body = value; }
        }


        public bool save()
        {
            string queryString = "";
            try
            {
                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_recordDMT(rdmt_fkProductionOrder, rdmt_head, rdmt_body, rdmt_footer, rdmt_createDate, rdmt_modifiedDate, rdmt_createdBy, rdmt_modifiedBy, rdmt_deletedDate, rdmt_deletedBy, rdmt_isVisible)";
                    queryString += " VALUES (";
                    queryString += "" + this.fkProductionOrder.ToString() + ",";
                    queryString += "'" + this.head.ToString() + "',";
                    queryString += "'" + this.body.ToString() + "',";
                    queryString += "'" + this.footer.ToString() + "',";
                    queryString += "GETDATE(),";
                    queryString += "GETDATE(),";
                    queryString += "" + clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += "" + clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += "GETDATE(),1,1)";
                }
                else
                {
                    queryString += "UPDATE bps_prod_recordDMT ";
                    queryString += " SET ";
                    queryString += "rdmt_fkProductionOrder = " + this.fkProductionOrder.ToString() + ",";
                    queryString += "rdmt_head ='" + this.head.ToString() + "',";
                    queryString += "rdmt_body ='" + this.body.ToString() + "',";
                    queryString += "rdmt_modifiedDate = GETDATE(),";
                    queryString += "rdmt_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += "rdmt_isVisible = 1,";
                    queryString += "rdmt_footer ='" + this.footer.ToString() + "'";
                    queryString += " WHERE rdmt_codsec = " + this.codsec.ToString() + "";

                }
                return (clsConnection.executeQuery(queryString));

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMainCoilQuality.save");
                return false;
            }
        }

        public static int getSituactionCodsec(int fkproductionOrder)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT rdmt_codsec FROM bps_prod_recordDMT WHERE rdmt_fkProductionOrder = " + fkproductionOrder.ToString());
            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(DS.Tables[0].Rows[0]["rdmt_codsec"].ToString());
            else
                return 0;
        }

        public static bool getSituation(int fkproductionOrder)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT rdmt_codsec FROM bps_prod_recordDMT WHERE rdmt_fkProductionOrder = " + fkproductionOrder.ToString() + " AND rdmt_isVisible = 1");
            if (DS.Tables[0].Rows.Count > 0)
                return true;
            else
                return false;
        }

        public static bool delete(int codsec)
        {
            string queryString = "";
            try
            {
                queryString += "UPDATE bps_prod_recordDMT ";
                queryString += " SET ";
                queryString += "rdmt_deletedDate = GETDATE(),";
                queryString += "rdmt_deletedBy = " + clsGlobal.LoggedUser.codsec.ToString() + ",";
                queryString += "rdmt_isVisible = 0";
                queryString += " WHERE rdmt_fkProductionOrder = " + codsec.ToString() + "";

                return (clsConnection.executeQuery(queryString));

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMainCoilQuality.save");
                return false;
            }
        }

        public static bool setNoteLab(int codsec, string note)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT rdmt_footer FROM bps_prod_recordDMT WHERE rdmt_fkProductionOrder = " + codsec.ToString() + " AND rdmt_isVisible = 1");

            if (DS.Tables[0].Rows.Count > 0)
            {
                string f = DS.Tables[0].Rows[0]["rdmt_footer"].ToString();

                string queryString = "";
                queryString += "UPDATE bps_prod_recordDMT ";
                queryString += " SET ";
                queryString += "rdmt_footer = '" + f + " C.C : " + note + "'";
                queryString += " WHERE rdmt_fkProductionOrder = " + codsec.ToString() + "";
                return (clsConnection.executeQuery(queryString));
            }
            else
                return false;
        }
    }
}
