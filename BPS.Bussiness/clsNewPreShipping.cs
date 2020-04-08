using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsNewPreShipping
    {
        private int npship_codsec;
        private string npship_number;
        private int npship_fkEntity;
        private int npship_fkUser;
        private DateTime npship_shippingDate;
        private int npship_fkStatus;
        private DateTime npship_createdDate;
        private string npship_Rnumber;
        private bool npship_wasAproved;

        public int codsec { get { return npship_codsec; } set { npship_codsec = value; } }

        public string number { get { return npship_number; } set { npship_number = value; } }

        public int fkEntity { get { return npship_fkEntity; } set { npship_fkEntity = value; } }

        public int fkUser { get { return npship_fkUser; } set { npship_fkUser = value; } }

        public DateTime shippingDate { get { return npship_shippingDate; } set { npship_shippingDate = value; } }

        public int fkStatus { get { return npship_fkStatus; } set { npship_fkStatus = value; } }

        public DateTime createdDate { get { return npship_createdDate; } set { npship_createdDate = value; } }
        
        public string Rnumber { get { return npship_Rnumber; } set { npship_Rnumber = value; } }

        public bool wasAproved { get { return npship_wasAproved; } set { npship_wasAproved = value; } }

        //Constructor
        public clsNewPreShipping()
        {
            codsec = 0;
            number = DateTime.Now.ToString("yy") + "-" + clsNewPreShipping.GetOrdinalNumber().ToString("00000");
            fkEntity = 0;
            fkUser = 0;
            shippingDate = DateTime.Now;
            fkStatus = 3067;
            createdDate = DateTime.Now;
            Rnumber = "0";
            wasAproved = false;
        }

        public clsNewPreShipping(string numb)
        {
            this.load(numb);
        }

        public clsNewPreShipping(int codsec)
        {
            this.load(codsec);
        }

        public void load(string numb)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_newPreShipping where npship_number = '" + numb +"'");
            if (DS.Tables.Count>0 && DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["npship_codsec"]);
                this.number = DS.Tables[0].Rows[0]["npship_number"].ToString();
                this.fkEntity = Convert.ToInt32(DS.Tables[0].Rows[0]["npship_fkEntity"]);
                this.fkUser = Convert.ToInt32(DS.Tables[0].Rows[0]["npship_fkUser"]);
                this.shippingDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["npship_shippingDate"]);
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["npship_fkStatus"]);
                this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["npship_createdDate"]);
                this.Rnumber = DS.Tables[0].Rows[0]["npship_Rnumber"].ToString();
                this.wasAproved = Convert.ToBoolean(DS.Tables[0].Rows[0]["npship_wasAproved"]);
            }
        }

        public void load(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_newPreShipping where npship_codsec = " + codsec);
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["npship_codsec"]);
                this.number = DS.Tables[0].Rows[0]["npship_number"].ToString();
                this.fkEntity = Convert.ToInt32(DS.Tables[0].Rows[0]["npship_fkEntity"]);
                this.fkUser = Convert.ToInt32(DS.Tables[0].Rows[0]["npship_fkUser"]);
                this.shippingDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["npship_shippingDate"]);
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["npship_fkStatus"]);
                this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["npship_createdDate"]);
                this.Rnumber = DS.Tables[0].Rows[0]["npship_Rnumber"].ToString();
                this.wasAproved = Convert.ToBoolean(DS.Tables[0].Rows[0]["npship_wasAproved"]);
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_newPreShipping (npship_number, npship_fkEntity, npship_fkUser, npship_shippingDate, npship_fkStatus, npship_createdDate, npship_Rnumber)";
                    queryString += " VALUES ( ";
                    queryString += "'" + this.number + "', ";
                    queryString += "" + this.fkEntity + ", ";
                    queryString += "" + this.fkUser + ", ";
                    queryString += "'" + this.shippingDate.ToString("dd/MM/yyyy") + "', ";
                    queryString += "" + this.fkStatus + ", ";
                    queryString += "'" + this.createdDate.ToString("dd/MM/yyyy") + "', ";
                    queryString += "'" + this.Rnumber + "' ";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_newPreShipping";
                    queryString += " SET ";
                    queryString += "npship_number = '" + this.number + "', ";
                    queryString += "npship_fkEntity = " + this.fkEntity + ", ";
                    queryString += "npship_fkUser = " + this.fkUser + ", ";
                    queryString += "npship_shippingDate ='" + this.shippingDate.ToString("dd/MM/yyyy") + "', ";
                    queryString += "npship_fkStatus = " + this.fkStatus + ", ";
                    queryString += "npship_createdDate ='" + this.createdDate.ToString("dd/MM/yyyy") + "', ";
                    queryString += "npship_Rnumber = '" + this.Rnumber + "' ";
                    queryString += " WHERE npship_codsec = " + this.codsec.ToString();
                }
                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsNewPreShipping.save");
                return false;
            }
        }

        public bool setAsProgrammed(DateTime ship)
        {
            string queryString = "";

            queryString += "UPDATE bps_prod_newPreShipping";
            queryString += " SET ";
            queryString += "npship_fkStatus = 3068, ";
            queryString += "npship_shippingDate = '" + ship.ToString("dd/MM/yyyy") + "'";
            queryString += " WHERE npship_codsec = " + this.codsec.ToString();
            
            if (clsConnection.executeQuery(queryString))
                return true;
            else
                return false;
        }

        public bool setAsNonProgrammed()
        {
            string queryString = "";

            queryString += "UPDATE bps_prod_newPreShipping";
            queryString += " SET ";
            queryString += "npship_fkStatus = 3067, ";
            queryString += "npship_shippingDate = '" + this.createdDate.ToString("dd/MM/yyyy") + "'";
            queryString += " WHERE npship_codsec = " + this.codsec.ToString();

            if (clsConnection.executeQuery(queryString))
                return true;
            else
                return false;
        }

        public bool setAsCanceled()
        {
            string queryString = "";

            queryString += "UPDATE bps_prod_newPreShipping";
            queryString += " SET ";
            queryString += "npship_fkStatus = 3071 ";
            queryString += " WHERE npship_codsec = " + this.codsec.ToString();

            if (clsConnection.executeQuery(queryString))
            {
                List<clsNewPreShippingDetail> list = this.getDetail();
  
                bool acu = true;

                for(int i=0;i<list.Count;i++)
                {
                    clsPallet.cancelPreShipping(list[i].fkPallet);
                    acu = acu && list[i].cancel();
                }

                return acu;
            }
            else
            {
                return false;
            }
        }

        public bool setAsDispatched()
        {
            if(this.fkStatus==3068)
            {
                string queryString = "";

                queryString += "UPDATE bps_prod_newPreShipping";
                queryString += " SET ";
                queryString += "npship_fkStatus = 3069 ";
                queryString += " WHERE npship_codsec = " + this.codsec.ToString();

                return clsConnection.executeQuery(queryString);
            }
            else
            {
                return false;
            }
        }

        public bool setAsAproved()
        {
            string queryString = "";

            queryString += "UPDATE bps_prod_newPreShipping";
            queryString += " SET ";
            queryString += "npship_wasAproved = 1 ";
            queryString += " WHERE npship_codsec = " + this.codsec.ToString();

            if (clsConnection.executeQuery(queryString))
                return true;
            else
                return false;
        }

        public bool setAsNotAproved()
        {
            string queryString = "";

            queryString += "UPDATE bps_prod_newPreShipping";
            queryString += " SET ";
            queryString += "npship_wasAproved = 0 ";
            queryString += " WHERE npship_codsec = " + this.codsec.ToString();

            if (clsConnection.executeQuery(queryString))
                return true;
            else
                return false;
        }

        public bool setRnumber(string rn)
        {
            string queryString = "";

            queryString += "UPDATE bps_prod_newPreShipping";
            queryString += " SET ";
            queryString += "npship_Rnumber = '" + rn + "'";
            queryString += " WHERE npship_codsec = " + this.codsec.ToString();

            if (clsConnection.executeQuery(queryString))
                return true;
            else
                return false;
        }

        public static int GetOrdinalNumber()
        {
            int seq = clsSequential.SequentialList("newpreshipping");
            clsSequential.addSequential("newpreshipping");
            return seq;
        }

        public List<clsNewPreShippingDetail> getDetail()
        {
            List<clsNewPreShippingDetail> list = new List<clsNewPreShippingDetail>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_newPreShippingDetail where npsd_fkNewPreShipping = " + this.codsec);

            if(DS.Tables.Count>0)
            {
                for(int i=0;i<DS.Tables[0].Rows.Count;i++)
                {
                    list.Add(new clsNewPreShippingDetail(Convert.ToInt32(DS.Tables[0].Rows[i]["npsd_fkPallet"])));
                }
            }

            return list;
        }

        public DataSet getDetailDS()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_newPreShippingDetail where npsd_fkNewPreShipping = " + this.codsec);

            if (DS.Tables.Count > 0)
            {
                return DS;
            }
            else
            {
                DS.Tables[0].Rows[0]["npsd_codsec"] = 0;
                return DS;
            }
        }

        public static DataSet getDetailForDispatchWithouClasses(string pdCode)
        {
            DataSet DS = new DataSet();

            //clsNewPreShipping pd = new clsNewPreShipping(pdCode)

            DS = clsConnection.getDataSetResult("CALL spPreshippingDetailDispatch('" + pdCode + "')");

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                return DS;
            }
            else
            {
                return DS;
            }

        }

        public string getStatusName()
        {
            clsStatus est = new clsStatus(this.fkStatus);
            return est.name;
        }

        public static DataSet dispatchPalletInPD(string numPD) // Por ahora, se va a usar para llevar la contabilizacion de los pallets que despachó si vuelve al formulario de Despacho.
        {
            DataSet DS = new DataSet();
            clsNewPreShipping pd = new clsNewPreShipping(numPD);

            try
            {
                DS = clsConnection.getDataSetResult("CALL spPalletInPD(" + pd.codsec + ")");

                if (DS.Tables[0].Rows.Count > 0)
                {
                    return DS;
                }
                else
                {
                    DS.Tables[0].Rows[0]["CodPallet"] = 0;
                    return DS;
                }
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsNewPreShipping.save");
                DS.Tables[0].Rows[0]["CodPallet"] = 0;
                return DS;
            }
        }

        public bool palletInPD(int palcodsec)
        {
            bool resp = false;
            List<clsNewPreShippingDetail> lista = this.getDetail();
            for (int i = 0; i < lista.Count;i++)
            {
                if(lista[i].fkPallet==palcodsec)
                {
                    resp = true;
                }
            }
            return resp;
        }

        public static bool palletInPD(string numPD, string palletCode)
        {
            DataSet DS = new DataSet();
            clsNewPreShipping pd = new clsNewPreShipping(numPD);
            bool siEsta = false;

            DS = clsConnection.getDataSetResult("CALL spPalletInPD(" + pd.codsec + ")");
             
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (DS.Tables[0].Rows[i]["CodPallet"].ToString() == palletCode)
                    {
                        siEsta = true;
                    }
                }
            }

            return siEsta;
        }
/*
        public static int activePalletInPD(string numPD)
        {

        }

        public static bool pltInPD(string PD, int fkPallet)
        {

        }*/

        public static DataSet getControlList(int cant)
        {
            DataSet DS = clsConnection.getDataSetResult("spNewPreShippingControl " + cant);

            return DS;
        }

        public bool cancel()
        {
            if(this.fkStatus==3067)
            {
                this.setAsCanceled();
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
