using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsCube
    {
        private int trns_codsec;
        private int trns_fkTransportCub;
        private int trns_fkTransport;
        private int trns_isVisible;
        private string trns_name;
        private string trns_code;
        private int trns_coil;
        private string trans_name;
        private int trans_width;
        private int trans_high;
        private int trans_long;
        private clsBoxing trns_Boxing;
        private clsPalletType trans_PalletType;
        private int trns_pallettypecodsec;
        private int trns_pallettypecoil;
        private string trns_pallettyorientation;
        private int trns_pallettyfloors;
        private string trns_pallettycode;

        private int trns_createdBy;
        private string trns_creatorUserName;
        private string trns_modificatorUserName;
        private int trns_modifiedBy;
        private DateTime trns_createdDate;
        private DateTime trns_modifiedDate;
       


        //Properties


        public int codsec { get { return trns_codsec; } set { trns_codsec = value; } }

        public int fkTransportCub { get { return trns_fkTransportCub; } set { trns_fkTransportCub = value; } }

        public int fkTransport { get { return trns_fkTransport; } set { trns_fkTransport = value; } }

        public int isVisible { get { return trns_isVisible; } set { trns_isVisible = value; } }

        public string name { get { return trns_name; } set { trns_name = value; } }

        public string code { get { return trns_code; } set { trns_code = value; } }

        public int coil { get { return trns_coil; } set { trns_coil = value; } }

        public string PalletTypeName { get { return trans_name; } set { trans_name = value; } }

        public int PalletTypeCoil { get { return trns_pallettypecoil; } set { trns_pallettypecoil = value; } }

        public int PalletTypeCodsec { get { return trns_pallettypecodsec; } set { trns_pallettypecodsec = value; } }

        public string PalletTypeOrientation { get { return trns_pallettyorientation; } set { trns_pallettyorientation = value; } }

        public int PalletTypeFloors { get { return trns_pallettyfloors; } set { trns_pallettyfloors = value; } }

        public string PalletTypeCode { get { return trns_pallettycode; } set { trns_pallettycode = value; } }

        public int width { get { return trans_width; } set { trans_width = value; } }

        public int high { get { return trans_high; } set { trans_high = value; } }

        public int Long { get { return trans_long; } set { trans_long = value; } }

        public int createdBy { get { return trns_createdBy; } set { trns_createdBy = value; } }

        public int modifiedBy { get { return trns_modifiedBy; } set { trns_modifiedBy = value; } }

        public DateTime createdDate { get { return trns_createdDate; } set { trns_createdDate = value; } }

        public DateTime modifiedDate { get { return trns_modifiedDate; } set { trns_modifiedDate = value; } }

        public string creatorUserName { get { return trns_creatorUserName; } set { trns_creatorUserName = value; } }

        public string modificatorUserName { get { return trns_modificatorUserName; } set { trns_modificatorUserName = value; } }

        public clsBoxing Boxing { get { return trns_Boxing; } set { trns_Boxing = value; } }

        public clsPalletType PalletType { get { return trans_PalletType; } set { trans_PalletType = value; } }
        

         //Constructor

        public clsCube()
        {
            trns_codsec = 0;
            trns_name = "";
            trns_code = "";
            trns_coil = 0;
            trns_createdBy = 0;
            trns_modifiedBy = 0;
            trns_createdDate = DateTime.Now;
            trns_modifiedDate = DateTime.Now;
            trns_isVisible = 1;
            trns_fkTransportCub = 0;
            trns_fkTransport = 0;
            trns_isVisible = 0;
            trans_name = "";
            trans_width = 0;
            trans_high = 0;
            trans_long = 0;
            trns_creatorUserName = "";
            trns_modificatorUserName = "";
            trns_Boxing = new clsBoxing();
            trans_PalletType = new clsPalletType();
            trns_pallettypecoil = 0;
        }

        public clsCube(int codsec)
        {
            this.load(codsec);
        }

        //Methods
        public void load(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("spCube 'TransportCubByCodsec'," + codsec.ToString() + ",'','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["trns_codsec"]);
            this.fkTransport = Convert.ToInt32(DS.Tables[0].Rows[0]["trns_fkTransport"]);
            this.fkTransportCub = Convert.ToInt32(DS.Tables[0].Rows[0]["trns_fkTransportCub"]);
            this.isVisible = Convert.ToInt32(DS.Tables[0].Rows[0]["trns_isVisible"]);
            this.name = DS.Tables[0].Rows[0]["trsc_name"].ToString();
            this.code = DS.Tables[0].Rows[0]["trsc_code"].ToString();
            this.coil = Convert.ToInt32(DS.Tables[0].Rows[0]["trsc_coil"]);
            this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["trsc_createdBy"]);
            this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["trsc_modifiedBy"]);
            this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["trsc_createdDate"]);
            this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["trsc_modifiedDate"]);
            this.PalletTypeCodsec = Convert.ToInt32(DS.Tables[0].Rows[0]["pltt_codsec"]);
            this.PalletTypeName = DS.Tables[0].Rows[0]["pltt_name"].ToString();
            this.PalletTypeCoil = Convert.ToInt32(DS.Tables[0].Rows[0]["pltt_coilNumber"]);
            this.PalletTypeFloors = Convert.ToInt32(DS.Tables[0].Rows[0]["pltt_floors"]);
            this.PalletTypeOrientation = DS.Tables[0].Rows[0]["pltt_coilOrientation"].ToString();
            this.PalletTypeCode = DS.Tables[0].Rows[0]["pltt_code"].ToString();
            this.Boxing = new clsBoxing(this.fkTransportCub);
            this.PalletType = new clsPalletType(this.fkTransport);
        }

        public bool savetransportcubbyTransport()
        {
            try
            {

                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_admin_transportcubbytransport (trns_fkTransportCub, trns_fkTransport, trns_isVisible) ";
                    queryString += "VALUES (";
                    queryString += "" + this.fkTransportCub.ToString() + ",";
                    queryString += "" + this.fkTransport.ToString() + ",";
                    queryString += "" + this.isVisible.ToString() + "";
                    queryString += ");";
                }
                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCube.save");
                return false;
            }
        }

        public bool updatetransportcubbyTransport()
        {
            try
            {

                string queryString = "";

                queryString += "UPDATE bps_admin_transportcubbytransport";
                queryString += " SET ";
                queryString += "trns_fkTransportCub = " + this.fkTransportCub + ",";
                queryString += "trns_fkTransport = " + this.fkTransport + ",";
                queryString += "trns_isVisible = " + this.isVisible.ToString() + "";
                queryString += " WHERE trns_codsec = " + this.codsec.ToString() + ";";

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCube.save");
                return false;
            }
        }

        public static List<clsCube> getListIsVisible()
        {
            List<clsCube> lstCube = new List<clsCube>();

            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("spCube 'ActiveList',0,'','"+DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")+"','"+DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")+"'");

            lstCube.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstCube.Add(new clsCube());
                lstCube[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["trns_codsec"]);
                lstCube[i].fkTransport = Convert.ToInt32(DS.Tables[0].Rows[i]["trns_fkTransport"]);
                lstCube[i].fkTransportCub = Convert.ToInt32(DS.Tables[0].Rows[i]["trns_fkTransportCub"]);
                lstCube[i].isVisible = Convert.ToInt32(DS.Tables[0].Rows[i]["trns_isVisible"]);
                lstCube[i].name = DS.Tables[0].Rows[i]["trsc_name"].ToString();
                lstCube[i].code = DS.Tables[0].Rows[i]["trsc_code"].ToString();
                lstCube[i].coil = Convert.ToInt32(DS.Tables[0].Rows[i]["trsc_coil"]);
                lstCube[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["trsc_createdBy"]);
                lstCube[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["trsc_modifiedBy"]);
                lstCube[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["trsc_createdDate"]);
                lstCube[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["trsc_modifiedDate"]);
                lstCube[i].PalletTypeCodsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pltt_codsec"]);
                lstCube[i].PalletTypeName = DS.Tables[0].Rows[i]["pltt_name"].ToString();
                lstCube[i].PalletTypeCoil = Convert.ToInt32(DS.Tables[0].Rows[i]["pltt_coilNumber"]);
                lstCube[i].PalletTypeFloors = Convert.ToInt32(DS.Tables[0].Rows[i]["pltt_floors"]);
                lstCube[i].PalletTypeOrientation = DS.Tables[0].Rows[i]["pltt_coilOrientation"].ToString();
                lstCube[i].PalletTypeCode = DS.Tables[0].Rows[i]["pltt_code"].ToString();
                lstCube[i].Boxing = new clsBoxing(lstCube[i].fkTransportCub);
                lstCube[i].PalletType = new clsPalletType(lstCube[i].fkTransport);
            }

            return lstCube;
        }

        public static bool toCrossTransportCubByTransport(int codsec)
        {
            try
            {

                string queryString = "";

                queryString += "UPDATE bps_admin_transportcubbytransport";
                queryString += " SET ";
                queryString += "trns_isVisible = 0";
                queryString += " WHERE trns_codsec = " + codsec.ToString() + ";";

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCube.save");
                return false;
            }
        }

        public static int toCalculeDimentionsPallet(clsProduct objProduct)
        {
            double widthcm = objProduct.width / 10;
            int widthaprox = 0, result = 0, depth = 0;
            List<int> lstInt = new List<int>();

            if (objProduct.fkDiameter == 1)
                widthaprox = 116;
            else if (objProduct.fkDiameter == 2)
                widthaprox = 77;
            else
                widthaprox = 0;
            if (objProduct.width < 1400)
            {
                if ((widthcm % 2) == 0)
                    depth = Convert.ToInt32((widthcm + 8));
                else
                    depth = Convert.ToInt32((widthcm + 10));
            }
            else
            {
                if ((widthcm % 2) == 0)
                    depth = Convert.ToInt32((widthcm + 10));
                else
                    depth = Convert.ToInt32((widthcm + 10));
            }

            List<clsPalletDimentions> lstpalletDimention = clsPalletDimentions.getListByWidth(widthaprox);

            for (int i = 0; i < lstpalletDimention.Count; i++)
            {
                if (lstpalletDimention[i].depth == depth)
                {
                    result = lstpalletDimention[i].codsec;
                    break;
                }
            }

            if (result == 0)
            {
                for (int i = 0; i < lstpalletDimention.Count; i++)
                {
                    if (lstpalletDimention[i].depth > depth)
                        lstInt.Add(lstpalletDimention[i].depth);
                }

                result = clsPalletDimentions.getCodsecByWidthAndDepth(widthaprox, lstInt[0]);
            }

            return result;
        }

        public static int getProportinalWidth(int maxWidth, int width, int formWidth, int pos)
        {
            if (pos == 116)
                return Convert.ToInt32((width * formWidth) / maxWidth);
            else
                return Convert.ToInt32((width * formWidth) / maxWidth);
        }
    }
}
