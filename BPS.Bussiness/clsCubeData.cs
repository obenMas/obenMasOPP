using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsCubeData       
    {
        private int cub_codsec;

        public int codsec
        {
            get { return cub_codsec; }
            set { cub_codsec = value; }
        }

        private int cub_fkTransport;

        public int fkTransport
        {
            get { return cub_fkTransport; }
            set { cub_fkTransport = value; }
        }

        private int cub_fkCustomer;

        public int fkCustomer
        {
            get { return cub_fkCustomer; }
            set { cub_fkCustomer = value; }
        }

        private string cub_code;

        public string code
        {
            get { return cub_code; }
            set { cub_code = value; }
        }

        private string cub_shipping;

        public string shipping
        {
            get { return cub_shipping; }
            set { cub_shipping = value; }
        }

        private string cub_order;

        public string order
        {
            get { return cub_order; }
            set { cub_order = value; }
        }

        private DateTime cub_createdDate;

        public DateTime createdDate
        {
            get { return cub_createdDate; }
            set { cub_createdDate = value; }
        }

        private DateTime cub_modifiedDate;

        public DateTime modifiedDate
        {
            get { return cub_modifiedDate; }
            set { cub_modifiedDate = value; }
        }

        private int cub_createdBy;

        public int createdBy
        {
            get { return cub_createdBy; }
            set { cub_createdBy = value; }
        }

        private int cub_modifiedBy;

        public int modifiedBy
        {
            get { return cub_modifiedBy; }
            set { cub_modifiedBy = value; }
        }

        private int cub_fkStatus;

        public int fkStatus
        {
            get { return cub_fkStatus; }
            set { cub_fkStatus = value; }
        }

        private List<clsTransport> cub_lstTransport;

        public List<clsTransport> lstTransport
        {
            get { return cub_lstTransport; }
            set { cub_lstTransport = value; }
        }

        private string cub_notes;

        public string notes
        {
            get { return cub_notes; }
            set { cub_notes = value; }
        }


        public clsCubeData()
        {
            cub_codsec = 0;
            cub_code = "ER001";
            cub_fkCustomer = 0;
            cub_fkTransport = 0;
            cub_shipping = "";
            cub_order = "----";
            cub_createdDate = DateTime.Now;
            cub_modifiedDate = DateTime.Now;
            cub_createdBy = 88;
            cub_modifiedBy = 88;
            cub_fkStatus = 0;
        }

        public clsCubeData(int codsec)
        {
            this.load(codsec);
        }

        public clsCubeData(string order)
        {
            this.load(order);
        }

        public void load(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_cube WHERE cub_codsec = " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cub_codsec"]);
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["cub_fkStatus"]);
                this.fkTransport = Convert.ToInt32(DS.Tables[0].Rows[0]["cub_fkTransport"]);
                this.fkCustomer = Convert.ToInt32(DS.Tables[0].Rows[0]["cub_fkCustomer"]);
                this.code = DS.Tables[0].Rows[0]["cub_code"].ToString();
                this.shipping = DS.Tables[0].Rows[0]["cub_shipping"].ToString();
                this.order = DS.Tables[0].Rows[0]["cub_order"].ToString();
                this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["cub_createdBy"]);
                this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["cub_modifiedBy"]);
                this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["cub_createdDate"]);
                this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["cub_modifiedDate"]);
            }
        }

        public void load(string order)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_cube WHERE cub_code = 'ER001' AND cub_order = '" + order + "' AND (cub_fkStatus = " + clsStatus.getStatusByStatusGroupNameAndStatusName("Cubicaje", "Activa con Datos").codsec.ToString() + " OR cub_fkStatus = " + clsStatus.getStatusByStatusGroupNameAndStatusName("Cubicaje", "Activa sin Datos").codsec.ToString() + ") ORDER BY cub_codsec DESC");

            if (DS.Tables[0].Rows.Count > 0 && DS.Tables[0].Rows.Count == 1)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cub_codsec"]);
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["cub_fkStatus"]);
                this.fkTransport = Convert.ToInt32(DS.Tables[0].Rows[0]["cub_fkTransport"]);
                this.fkCustomer = Convert.ToInt32(DS.Tables[0].Rows[0]["cub_fkCustomer"]);
                this.code = DS.Tables[0].Rows[0]["cub_code"].ToString();
                this.shipping = DS.Tables[0].Rows[0]["cub_shipping"].ToString();
                this.order = DS.Tables[0].Rows[0]["cub_order"].ToString();
                this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["cub_createdBy"]);
                this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["cub_modifiedBy"]);
                this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["cub_createdDate"]);
                this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["cub_modifiedDate"]);
            }
            else if(DS.Tables[0].Rows.Count > 1)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count - 1; i++)
                    clsConnection.executeQuery("UPDATE bps_prod_cube SET cub_fkStatus = " + clsStatus.getStatusByStatusGroupNameAndStatusName("Cubicaje", "Eliminada sin Datos").codsec.ToString() + " WHERE cub_codsec = " + Convert.ToInt32(DS.Tables[0].Rows[i]["cub_codsec"]).ToString());

                DS = new DataSet();
                DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_cube WHERE cub_code = 'ER001' AND cub_order = '" + order + "' AND cub_fkStatus = " + clsStatus.getStatusByStatusGroupNameAndStatusName("Cubicaje", "Activa sin Datos").codsec.ToString() + " ORDER BY cub_codsec DESC");
                if (DS.Tables[0].Rows.Count > 0 && DS.Tables[0].Rows.Count == 1)
                {
                    this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cub_codsec"]);
                    this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["cub_fkStatus"]);
                    this.fkTransport = Convert.ToInt32(DS.Tables[0].Rows[0]["cub_fkTransport"]);
                    this.fkCustomer = Convert.ToInt32(DS.Tables[0].Rows[0]["cub_fkCustomer"]);
                    this.code = DS.Tables[0].Rows[0]["cub_code"].ToString();
                    this.shipping = DS.Tables[0].Rows[0]["cub_shipping"].ToString();
                    this.order = DS.Tables[0].Rows[0]["cub_order"].ToString();
                    this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["cub_createdBy"]);
                    this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["cub_modifiedBy"]);
                    this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["cub_createdDate"]);
                    this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["cub_modifiedDate"]);
                }
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_cube (cub_fkStatus, cub_fkTransport, cub_fkCustomer, cub_code, cub_shipping, cub_order, cub_createdDate, cub_modifiedDate, cub_createdBy, cub_modifiedBy, cub_notes) ";
                    queryString += "VALUES (";
                    queryString += "" + this.fkStatus.ToString() + ",";
                    queryString += "" + this.fkTransport.ToString() + ",";
                    queryString += "" + this.fkCustomer.ToString() + ",";
                    queryString += "'" + this.code.ToString() + "',";
                    queryString += "'" + this.shipping.ToString() + "',";
                    queryString += "'" + this.order.ToString() + "',";
                    queryString += "'" + this.createdDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += "'" + this.modifiedDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += "" + clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += "" + clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += "'" + this.notes.ToString() + "'";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_cube";
                    queryString += " SET ";
                    queryString += "cub_fkTransport = " + this.fkTransport + ",";
                    queryString += "cub_fkStatus = " + this.fkStatus + ",";
                    queryString += "cub_fkCustomer = " + this.fkCustomer + ",";
                    queryString += "cub_code = '" + this.code + "',";
                    queryString += "cub_notes = '" + this.notes + "',";
                    queryString += "cub_modifiedDate = '" + this.modifiedDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += "cub_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + "";
                    queryString += " WHERE cub_codsec = " + this.codsec.ToString() + ";";
                }

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCubeData.save");
                return false;
            }
        }

        public static int getLastCodsec()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT cub_codsec FROM bps_prod_cube ORDER BY cub_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["cub_codsec"]);
        }

        public static List<clsCubeData> getListByCodsec(int codsec)
        {
            DataSet DS = new DataSet();
            List<clsCubeData> lstCubeDetail = new List<clsCubeData>();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_cube WHERE cub_codsec = " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCubeDetail.Add(new clsCubeData());
                    lstCubeDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cub_codsec"]);
                    lstCubeDetail[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["cub_fkStatus"]);
                    lstCubeDetail[i].fkTransport = Convert.ToInt32(DS.Tables[0].Rows[i]["cub_fkTransport"]);
                    lstCubeDetail[i].fkCustomer = Convert.ToInt32(DS.Tables[0].Rows[i]["cub_fkCustomer"]);
                    lstCubeDetail[i].code = DS.Tables[0].Rows[i]["cub_code"].ToString();
                    lstCubeDetail[i].shipping = DS.Tables[0].Rows[i]["cub_shipping"].ToString();
                    lstCubeDetail[i].order = DS.Tables[0].Rows[i]["cub_order"].ToString();
                    lstCubeDetail[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cub_createdBy"]);
                    lstCubeDetail[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cub_modifiedBy"]);
                    lstCubeDetail[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["cub_createdDate"]);
                    lstCubeDetail[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["cub_modifiedDate"]);
                    lstCubeDetail[i].lstTransport = clsTransport.getListByCodsec(lstCubeDetail[i].fkTransport);
                    lstCubeDetail[i].notes = DS.Tables[0].Rows[i]["cub_notes"].ToString();
                }
            }
            return lstCubeDetail;
        }

        public static List<clsCubeData> getList()
        {
            DataSet DS = new DataSet();
            List<clsCubeData> lstCubeDetail = new List<clsCubeData>();

            DS = clsConnection.getDataSetResult("SELECT TOP(300) * FROM bps_prod_cube");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCubeDetail.Add(new clsCubeData());
                    lstCubeDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cub_codsec"]);
                    lstCubeDetail[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["cub_fkStatus"]);
                    lstCubeDetail[i].fkTransport = Convert.ToInt32(DS.Tables[0].Rows[i]["cub_fkTransport"]);
                    lstCubeDetail[i].fkCustomer = Convert.ToInt32(DS.Tables[0].Rows[i]["cub_fkCustomer"]);
                    lstCubeDetail[i].code = DS.Tables[0].Rows[i]["cub_code"].ToString();
                    lstCubeDetail[i].shipping = DS.Tables[0].Rows[i]["cub_shipping"].ToString();
                    lstCubeDetail[i].order = DS.Tables[0].Rows[i]["cub_order"].ToString();
                    lstCubeDetail[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cub_createdBy"]);
                    lstCubeDetail[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cub_modifiedBy"]);
                    lstCubeDetail[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["cub_createdDate"]);
                    lstCubeDetail[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["cub_modifiedDate"]);
                    lstCubeDetail[i].lstTransport = clsTransport.getListByCodsec(lstCubeDetail[i].fkTransport);
                }
            }
            return lstCubeDetail;
        }

        public static bool delete(int codsec)
        {
            try
            {
                string queryString = "";
                queryString += "DELETE FROM bps_prod_cube WHERE cub_codsec = " + codsec.ToString() + ";";
                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCubeDetail.delete");
                return false;
            }
        }
    }
}
