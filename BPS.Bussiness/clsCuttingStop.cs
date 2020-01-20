using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    public class clsCuttingStop
    {
        // Attibutes
        private int cstp_codsec;
        private int cstp_fkCuttingOrder;
        private int cstp_position;
        private int cstp_supervisedBy;
        private string cstp_supervisor;
        private int cstp_digitizedBy;
        private string cstp_digitizer;
        private int cstp_operatedBy;
        private string cstp_operator;
        private bool cstp_closed;
        private List<clsMainCoilByCuttingStop> cstp_lstMainCoilByCuttingStop;
        private List<clsCoilBySecundaryCuttingStop> cstp_lstSecundaryCutCoil;
        private List<clsCoil> cstp_lstCoil;

        //Properties
        public int codsec { get { return cstp_codsec; } set { cstp_codsec = value; } }

        public int fkCuttingOrder { get { return cstp_fkCuttingOrder; } set { cstp_fkCuttingOrder = value; } }

        public int position { get { return cstp_position; } set { cstp_position = value; } }

        public int supervisedBy { get { return cstp_supervisedBy; } set { cstp_supervisedBy = value; } }

        public string supervisor { get { return cstp_supervisor; } set { cstp_supervisor = value; } }

        public int digitizedBy { get { return cstp_digitizedBy; } set { cstp_digitizedBy = value; } }

        public string digitizer { get { return cstp_digitizer; } set { cstp_digitizer = value; } }

        public int operatedBy { get { return cstp_operatedBy; } set { cstp_operatedBy = value; } }

        public string Operator { get { return cstp_operator; } set { cstp_operator = value; } }

        public bool closed { get { return cstp_closed; } set { cstp_closed = value; } }

        public List<clsMainCoilByCuttingStop> lstMainCoilByCuttingStop { get { return cstp_lstMainCoilByCuttingStop; } set { cstp_lstMainCoilByCuttingStop = value; } }

        public List<clsCoilBySecundaryCuttingStop> lstSecundaryCutCoil { get { return cstp_lstSecundaryCutCoil; } set { cstp_lstSecundaryCutCoil = value; } }

        public List<clsCoil> lstCoil { get { return cstp_lstCoil; } set { cstp_lstCoil = value; } }

        //Constructor
        public clsCuttingStop()
        {
            this.codsec = 0;
            this.fkCuttingOrder = 0;
            this.position = 0;
            this.supervisedBy = 0;
            this.supervisor = "";
            this.digitizedBy = 0;
            this.digitizer = "";
            this.operatedBy = 0;
            this.Operator = "";
            this.closed = false;
            this.lstMainCoilByCuttingStop = new List<clsMainCoilByCuttingStop>();
            this.lstSecundaryCutCoil = new List<clsCoilBySecundaryCuttingStop>();
            this.lstCoil = new List<clsCoil>();
        }
        public clsCuttingStop(int cuttingStopCodsec)
        {
            this.load(cuttingStopCodsec);
        }
        //Methods
        public void load(int cuttingStopCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spCuttingStopByCodsec " + cuttingStopCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cstp_codsec"]);
                this.fkCuttingOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["cstp_fkCuttingOrder"]);
                this.position = Convert.ToInt32(DS.Tables[0].Rows[0]["cstp_position"]);
                this.supervisedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["cstp_supervisedBy"]);
                this.supervisor = DS.Tables[0].Rows[0]["cstp_supervisor"].ToString();
                this.digitizedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["cstp_digitizedBy"]);
                this.digitizer = DS.Tables[0].Rows[0]["cstp_digitizer"].ToString();
                this.operatedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["cstp_operatedBy"]);
                this.Operator = DS.Tables[0].Rows[0]["cstp_operator"].ToString();
                this.closed = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cstp_closed"], DS.Tables[0].Rows[0]["cstp_closed"].GetType().FullName);
                this.lstMainCoilByCuttingStop = clsMainCoilByCuttingStop.getListByCuttingStop(this.codsec);
                this.lstSecundaryCutCoil = clsCoilBySecundaryCuttingStop.getListByCuttingStop(this.codsec);
                this.lstCoil = clsCoil.getCoilListByCuttingStop(this.codsec);
            }
        }
        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_cuttingstops (cstp_fkCuttingOrder, cstp_position, cstp_supervisedBy, cstp_digitizedBy, cstp_operatedBy, cstp_closed)";
                    queryString += " VALUES (";
                    queryString += "" + this.fkCuttingOrder.ToString() + ", ";
                    queryString += "" + this.position.ToString() + ", ";
                    queryString += "" + this.supervisedBy.ToString() + ", ";
                    queryString += "" + this.digitizedBy + ", ";
                    queryString += "" + this.operatedBy.ToString() + ", ";
                    queryString += "'" + this.closed.ToString() + "' ";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_cuttingstops";
                    queryString += " SET ";
                    queryString += "cstp_fkCuttingOrder = " + this.fkCuttingOrder.ToString() + ", ";
                    queryString += "cstp_position = " + this.position.ToString() + ", ";
                    queryString += "cstp_supervisedBy = " + this.supervisedBy.ToString() + ", ";
                    queryString += "cstp_digitizedBy = " + this.digitizedBy + ", ";
                    queryString += "cstp_operatedBy = " + this.operatedBy.ToString() + ", ";
                    queryString += "cstp_closed = " + this.closed.ToString() + " ";
                    queryString += " WHERE cstp_codsec = " + this.codsec.ToString() + ";";
                }
                clsConnection.executeQuery(queryString);

                if (this.codsec == 0)
                    this.codsec = clsCuttingStop.getLastSavedCodsec();
                return true;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCuttingStop.save");
                return false;
            }
        }

        public static List<clsCuttingStop> getListByCuttingOrder(int cuttingOrderCodsec)
        {
            List<clsCuttingStop> lstCuttingStop = new List<clsCuttingStop>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spCuttingMultiple " + cuttingOrderCodsec.ToString() + ",0,'','','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','CuttingStopByfkCuttingOrder'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCuttingStop.Add(new clsCuttingStop());
                    lstCuttingStop[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cstp_codsec"]);
                    lstCuttingStop[i].fkCuttingOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["cstp_fkCuttingOrder"]);
                    lstCuttingStop[i].position = Convert.ToInt32(DS.Tables[0].Rows[i]["cstp_position"]);
                    lstCuttingStop[i].supervisedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cstp_supervisedBy"]);
                    lstCuttingStop[i].supervisor = DS.Tables[0].Rows[i]["cstp_supervisor"].ToString();
                    lstCuttingStop[i].digitizedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cstp_digitizedBy"]);
                    lstCuttingStop[i].digitizer = DS.Tables[0].Rows[i]["cstp_digitizer"].ToString();
                    lstCuttingStop[i].operatedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cstp_operatedBy"]);
                    lstCuttingStop[i].Operator = DS.Tables[0].Rows[i]["cstp_operator"].ToString();
                    lstCuttingStop[i].closed = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cstp_closed"], DS.Tables[0].Rows[i]["cstp_closed"].GetType().FullName);
                    lstCuttingStop[i].lstMainCoilByCuttingStop = clsMainCoilByCuttingStop.getListByCuttingStop(lstCuttingStop[i].codsec);
                    lstCuttingStop[i].lstSecundaryCutCoil = clsCoilBySecundaryCuttingStop.getListByCuttingStop(lstCuttingStop[i].codsec);
                    lstCuttingStop[i].lstCoil = clsCoil.getCoilListByCuttingStop(lstCuttingStop[i].codsec);
                }
            }
            return lstCuttingStop;
        }
        public static List<clsCuttingStop> getListByCuttingOrderSimplified(int cuttingOrderCodsec)
        {
            List<clsCuttingStop> lstCuttingStop = new List<clsCuttingStop>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spCuttingMultiple " + cuttingOrderCodsec.ToString() + ",0,'','','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','CuttingStopByfkCuttingOrder'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCuttingStop.Add(new clsCuttingStop());
                    lstCuttingStop[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cstp_codsec"]);
                    lstCuttingStop[i].fkCuttingOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["cstp_fkCuttingOrder"]);
                    lstCuttingStop[i].position = Convert.ToInt32(DS.Tables[0].Rows[i]["cstp_position"]);
                    lstCuttingStop[i].supervisedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cstp_supervisedBy"]);
                    lstCuttingStop[i].supervisor = DS.Tables[0].Rows[i]["cstp_supervisor"].ToString();
                    lstCuttingStop[i].digitizedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cstp_digitizedBy"]);
                    lstCuttingStop[i].digitizer = DS.Tables[0].Rows[i]["cstp_digitizer"].ToString();
                    lstCuttingStop[i].operatedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cstp_operatedBy"]);
                    lstCuttingStop[i].Operator = DS.Tables[0].Rows[i]["cstp_operator"].ToString();
                    lstCuttingStop[i].closed = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cstp_closed"], DS.Tables[0].Rows[i]["cstp_closed"].GetType().FullName);
                    lstCuttingStop[i].lstCoil = clsCoil.getCoilListByCuttingStop(lstCuttingStop[i].codsec);
                }
            }
            return lstCuttingStop;
        }
        public static List<clsCuttingStop> getSimplidiedListByCuttingOrder(int cuttingOrderCodsec)
        {
            List<clsCuttingStop> lstCuttingStop = new List<clsCuttingStop>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spCuttingMultiple " + cuttingOrderCodsec.ToString() + ",0,'','','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','CuttingStopByfkCuttingOrder'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCuttingStop.Add(new clsCuttingStop());
                    lstCuttingStop[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cstp_codsec"]);
                    lstCuttingStop[i].fkCuttingOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["cstp_fkCuttingOrder"]);
                    lstCuttingStop[i].position = Convert.ToInt32(DS.Tables[0].Rows[i]["cstp_position"]);
                    lstCuttingStop[i].supervisedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cstp_supervisedBy"]);
                    lstCuttingStop[i].supervisor = DS.Tables[0].Rows[i]["cstp_supervisor"].ToString();
                    lstCuttingStop[i].digitizedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cstp_digitizedBy"]);
                    lstCuttingStop[i].digitizer = DS.Tables[0].Rows[i]["cstp_digitizer"].ToString();
                    lstCuttingStop[i].operatedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cstp_operatedBy"]);
                    lstCuttingStop[i].Operator = DS.Tables[0].Rows[i]["cstp_operator"].ToString();
                    lstCuttingStop[i].closed = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cstp_closed"], DS.Tables[0].Rows[i]["cstp_closed"].GetType().FullName);
                }
            }
            return lstCuttingStop;
        }
        public static List<clsCuttingStop> getSimplifiedListByCuttingOrder(int cuttingOrderCodsec)
        {
            List<clsCuttingStop> lstCuttingStop = new List<clsCuttingStop>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spCuttingMultiple " + cuttingOrderCodsec.ToString() + ",0,'','','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','CuttingStopByfkCuttingOrder'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCuttingStop.Add(new clsCuttingStop());
                    lstCuttingStop[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cstp_codsec"]);
                    lstCuttingStop[i].fkCuttingOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["cstp_fkCuttingOrder"]);
                    lstCuttingStop[i].position = Convert.ToInt32(DS.Tables[0].Rows[i]["cstp_position"]);
                    lstCuttingStop[i].supervisedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cstp_supervisedBy"]);
                    lstCuttingStop[i].supervisor = DS.Tables[0].Rows[i]["cstp_supervisor"].ToString();
                    lstCuttingStop[i].digitizedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cstp_digitizedBy"]);
                    lstCuttingStop[i].digitizer = DS.Tables[0].Rows[i]["cstp_digitizer"].ToString();
                    lstCuttingStop[i].operatedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cstp_operatedBy"]);
                    lstCuttingStop[i].Operator = DS.Tables[0].Rows[i]["cstp_operator"].ToString();
                    lstCuttingStop[i].closed = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cstp_closed"], DS.Tables[0].Rows[i]["cstp_closed"].GetType().FullName);
                }
            }
            return lstCuttingStop;

        }
        private static int getLastSavedCodsec()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT cstp_codsec FROM vwcuttingstop Order By cstp_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["cstp_codsec"]);
        }
        public static clsCuttingStop getCuttingStopByCoil(int coilCodsec)
        {
            clsCuttingStop objCuttingStop = new clsCuttingStop();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spCuttingStopByCoil " + coilCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                objCuttingStop.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cstp_codsec"]);
                objCuttingStop.fkCuttingOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["cstp_fkCuttingOrder"]);
                objCuttingStop.position = Convert.ToInt32(DS.Tables[0].Rows[0]["cstp_position"]);
                objCuttingStop.supervisedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["cstp_supervisedBy"]);
                objCuttingStop.supervisor = DS.Tables[0].Rows[0]["cstp_supervisor"].ToString();
                objCuttingStop.digitizedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["cstp_digitizedBy"]);
                objCuttingStop.digitizer = DS.Tables[0].Rows[0]["cstp_digitizer"].ToString();
                objCuttingStop.operatedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["cstp_operatedBy"]);
                objCuttingStop.Operator = DS.Tables[0].Rows[0]["cstp_operator"].ToString();
                objCuttingStop.closed = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cstp_closed"], DS.Tables[0].Rows[0]["cstp_closed"].GetType().FullName);
                objCuttingStop.lstMainCoilByCuttingStop = clsMainCoilByCuttingStop.getListByCuttingStop(objCuttingStop.codsec);
                objCuttingStop.lstSecundaryCutCoil = clsCoilBySecundaryCuttingStop.getListByCuttingStop(objCuttingStop.codsec);
                objCuttingStop.lstCoil = clsCoil.getCoilListByCuttingStop(objCuttingStop.codsec);
            }

            return objCuttingStop;
        }
    }
}
