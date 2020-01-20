using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsCubeDetail
    {
        private int cubd_codsec;

        public int codsec
        {
            get { return cubd_codsec; }
            set { cubd_codsec = value; }
        }

        private int cubd_fkCube;

        public int fkCube
        {
            get { return cubd_fkCube; }
            set { cubd_fkCube = value; }
        }

        private List<clsCubeData> lst_fkCube;

        public List<clsCubeData> lstCube
        {
            get { return lst_fkCube; }
            set { lst_fkCube = value; }
        }

        private int cubd_fkProduct;

        public int fkProduct
        {
            get { return cubd_fkProduct; }
            set { cubd_fkProduct = value; }
        }

        private int cubd_fkBoxing;

        public int fkBoxing
        {
            get { return cubd_fkBoxing; }
            set { cubd_fkBoxing = value; }
        }

        private List<clsBoxing> lst_fkBoxing;

        public List<clsBoxing> lstBoxing
        {
            get { return lst_fkBoxing; }
            set { lst_fkBoxing = value; }
        }

        private int cubd_fkPalletDimentions;

        public int fkPalletDimentions
        {
            get { return cubd_fkPalletDimentions; }
            set { cubd_fkPalletDimentions = value; }
        }

        private List<clsPalletDimentions> lst_fkPalletDimentions;

        public List<clsPalletDimentions> lstPalletDimentions
        {
            get { return lst_fkPalletDimentions; }
            set { lst_fkPalletDimentions = value; }
        }

        private string cubd_Trataiment;

        public string Trataiment
        {
            get { return cubd_Trataiment; }
            set { cubd_Trataiment = value; }
        }
        private double cubd_quantity;

        public double quantity
        {
            get { return cubd_quantity; }
            set { cubd_quantity = value; }
        }

        private int cubd_coil;

        public int coil
        {
            get { return cubd_coil; }
            set { cubd_coil = value; }
        }

        private double cubd_coilweigth;

        public double coilweigth
        {
            get { return cubd_coilweigth; }
            set { cubd_coilweigth = value; }
        }

        private int cubd_pallet;

        public int pallet
        {
            get { return cubd_pallet; }
            set { cubd_pallet = value; }
        }

        private double cubd_palletweigth;

        public double palletweigth
        {
            get { return cubd_palletweigth; }
            set { cubd_palletweigth = value; }
        }

        private int cubd_width;

        public int width
        {
            get { return cubd_width; }
            set { cubd_width = value; }
        }

        private int cub_codsec;

        public int codsecCube
        {
            get { return cub_codsec; }
            set { cub_codsec = value; }
        }

        private int cub_fkStatus;

        public int fkStatusCube
        {
            get { return cub_fkStatus; }
            set { cub_fkStatus = value; }
        }

        private string cub_statusName;

        public string statusName
        {
            get { return cub_statusName; }
            set { cub_statusName = value; }
        }

        private int cub_fkTransport;

        public int fkTransportCube
        {
            get { return cub_fkTransport; }
            set { cub_fkTransport = value; }
        }

        private string cub_trasnportName;

        public string trasnportNameCube
        {
            get { return cub_trasnportName; }
            set { cub_trasnportName = value; }
        }

        private int cub_usefulHigh;

        public int usefulHighCube
        {
            get { return cub_usefulHigh; }
            set { cub_usefulHigh = value; }
        }

        private int cub_usefulLong;

        public int usefulLongCube
        {
            get { return cub_usefulLong; }
            set { cub_usefulLong = value; }
        }

        private int cub_usefulWidth;

        public int usefulWidthCube
        {
            get { return cub_usefulWidth; }
            set { cub_usefulWidth = value; }
        }

        private string cub_companyName;

        public string companyNameCube
        {
            get { return cub_companyName; }
            set { cub_companyName = value; }
        }

        private string cub_countryName;

        public string countryNameCube
        {
            get { return cub_countryName; }
            set { cub_countryName = value; }
        }

        private string cub_code;

        public string code
        {
            get { return cub_code; }
            set { cub_code = value; }
        }

        private string cub_shipping;

        public string shippingCube
        {
            get { return cub_shipping; }
            set { cub_shipping = value; }
        }

        private string cub_order;

        public string orderCube
        {
            get { return cub_order; }
            set { cub_order = value; }
        }

        private DateTime cub_createdDate;

        public DateTime createdDateCube
        {
            get { return cub_createdDate; }
            set { cub_createdDate = value; }
        }

        private DateTime cub_modifiedDate;

        public DateTime modifiedDateCube
        {
            get { return cub_modifiedDate; }
            set { cub_modifiedDate = value; }
        }

        private int cub_createdBy;

        public int createdByCube
        {
            get { return cub_createdBy; }
            set { cub_createdBy = value; }
        }

        private string cub_createdUser;

        public string createdUserCube
        {
            get { return cub_createdUser; }
            set { cub_createdUser = value; }
        }

        private int cub_modifiedBy;

        public int modifiedByCube
        {
            get { return cub_modifiedBy; }
            set { cub_modifiedBy = value; }
        }

        private string prod_code;

        public string codeProduct
        {
            get { return prod_code; }
            set { prod_code = value; }
        }

        private int prod_width;

        public int widthProduct
        {
            get { return prod_width; }
            set { prod_width = value; }
        }

        private string cub_transcode;

        public string transcodeBoxing
        {
            get { return cub_transcode; }
            set { cub_transcode = value; }
        }

        private string cub_transname;

        public string transnameBoxing
        {
            get { return cub_transname; }
            set { cub_transname = value; }
        }

        private int cub_transcoil;

        public int transcoilBoxing
        {
            get { return cub_transcoil; }
            set { cub_transcoil = value; }
        }

        private int cub_dimentionwidth;

        public int dimentionwidthDimentions
        {
            get { return cub_dimentionwidth; }
            set { cub_dimentionwidth = value; }
        }

        private int cub_dimentiondepth;

        public int dimentiondepthDimentions
        {
            get { return cub_dimentiondepth; }
            set { cub_dimentiondepth = value; }
        }

        private string cub_dimentionfull;

        public string dimentionfullDimentions
        {
            get { return cub_dimentionfull; }
            set { cub_dimentionfull = value; }
        }

        private int cubd_rowOne;

        public int rowOne
        {
            get { return cubd_rowOne; }
            set { cubd_rowOne = value; }
        }

        private int cubd_rowTwo;

        public int rowTwo
        {
            get { return cubd_rowTwo; }
            set { cubd_rowTwo = value; }
        }

        private int cubd_rowThree;

        public int rowThree
        {
            get { return cubd_rowThree; }
            set { cubd_rowThree = value; }
        }


        public clsCubeDetail()
        {
            cubd_width = 0;
            cubd_palletweigth = 0;
            cubd_pallet = 0;
            cubd_coilweigth = 0;
            cubd_coil = 0;
            cubd_quantity = 0;
            cubd_Trataiment = "";
            cubd_fkPalletDimentions = 0;
            cubd_fkBoxing = 0;
            cubd_fkProduct = 0;
            cubd_fkCube = 0;
            cubd_codsec = 0;
        }

        public clsCubeDetail(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_cubedetail WHERE cubd_codsec = " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cubd_codsec"]);
                this.fkCube = Convert.ToInt32(DS.Tables[0].Rows[0]["cubd_fkCube"]);
                this.fkProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["cubd_fkProduct"]);
                this.fkBoxing = Convert.ToInt32(DS.Tables[0].Rows[0]["cubd_fkBoxing"]);
                this.fkPalletDimentions = Convert.ToInt32(DS.Tables[0].Rows[0]["cubd_fkPalletDimentions"]);
                this.Trataiment = DS.Tables[0].Rows[0]["cubd_Trataiment"].ToString();
                this.quantity = Convert.ToDouble(DS.Tables[0].Rows[0]["cubd_quantity"]);
                this.coil = Convert.ToInt32(DS.Tables[0].Rows[0]["cubd_coil"]);
                this.coilweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["cubd_coilweigth"]);
                this.pallet = Convert.ToInt32(DS.Tables[0].Rows[0]["cubd_pallet"]);
                this.palletweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["cubd_palletweigth"]);
                this.width = Convert.ToInt32(DS.Tables[0].Rows[0]["cubd_width"]);
                this.lstCube = clsCubeData.getListByCodsec(this.fkCube);
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_cubedetail (cubd_fkCube, cubd_fkProduct, cubd_fkBoxing, cubd_fkPalletDimentions, cubd_Trataiment, cubd_quantity, cubd_coil, cubd_coilweigth, cubd_pallet, cubd_palletweigth, cubd_width, cubd_rowOne, cubd_rowTwo, cubd_rowTree)";
                    queryString += " VALUES (";
                    queryString += this.fkCube.ToString() + ",";
                    queryString += this.fkProduct.ToString() + ",";
                    queryString += this.fkBoxing.ToString() + ",";
                    queryString += this.fkPalletDimentions.ToString() + ",";
                    queryString += "'" + this.Trataiment + "',";
                    queryString += this.quantity.ToString() + ",";
                    queryString += this.coil.ToString() + ",";
                    queryString += this.coilweigth.ToString() + ",";
                    queryString += this.pallet.ToString() + ",";
                    queryString += this.palletweigth.ToString() + ",";
                    queryString += this.width.ToString() + ", ";
                    queryString += this.rowOne.ToString() + ", ";
                    queryString += this.rowTwo.ToString() + ", ";
                    queryString += this.rowThree.ToString() + " ";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_cubedetail";
                    queryString += " SET ";
                    queryString += "cubd_fkProduct =  " + this.fkProduct.ToString() + ",";
                    queryString += "cubd_fkBoxing = " + this.fkBoxing.ToString() + ",";
                    queryString += "cubd_fkPalletDimentions = " + this.fkPalletDimentions.ToString() + ",";
                    queryString += "cubd_Trataiment = '" + this.Trataiment.ToString() + "',";
                    queryString += "cubd_quantity = " + this.quantity.ToString() + ",";
                    queryString += "cubd_coil = " + this.coil.ToString() + ",";
                    queryString += "cubd_coilweigth = " + this.coilweigth.ToString() + ",";
                    queryString += "cubd_pallet = " + this.pallet.ToString() + ",";
                    queryString += "cubd_palletweigth = " + this.palletweigth.ToString() + ",";
                    queryString += "cubd_width = " + this.width.ToString() + ",";
                    queryString += "cubd_rowOne = " + this.rowOne.ToString() + ",";
                    queryString += "cubd_rowTwo = " + this.rowTwo.ToString() + ",";
                    queryString += "cubd_rowTree = " + this.rowThree.ToString() + "";
                    queryString += " WHERE cubd_codsec = " + this.codsec.ToString() + ";";
                }

                return clsConnection.executeQuery(queryString);
            }

            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCubeDetail.save");
                return false;
            }
        }


        public static List<clsCubeDetail> getListByCube(int codsecCube)
        {
            List<clsCubeDetail> lstCubeDetail = new List<clsCubeDetail>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("spCube 'ListByCube'," + codsecCube.ToString() + ",'','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");
            
            lstCubeDetail.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstCubeDetail.Add(new clsCubeDetail());
                lstCubeDetail[i].codsecCube = Convert.ToInt32(DS.Tables[0].Rows[i]["cub_codsec"]);
                lstCubeDetail[i].fkStatusCube = Convert.ToInt32(DS.Tables[0].Rows[i]["cub_fkStatus"]);
                lstCubeDetail[i].statusName = DS.Tables[0].Rows[i]["cub_statusName"].ToString();
                lstCubeDetail[i].fkTransportCube = Convert.ToInt32(DS.Tables[0].Rows[i]["cub_fkTransport"]);
                lstCubeDetail[i].trasnportNameCube = DS.Tables[0].Rows[i]["cub_trasnportName"].ToString();
                lstCubeDetail[i].usefulHighCube = Convert.ToInt32(DS.Tables[0].Rows[i]["cub_usefulHigh"]);
                lstCubeDetail[i].usefulLongCube = Convert.ToInt32(DS.Tables[0].Rows[i]["cub_usefulLong"]);
                lstCubeDetail[i].usefulWidthCube = Convert.ToInt32(DS.Tables[0].Rows[i]["cub_usefulWidth"]);
                lstCubeDetail[i].companyNameCube = DS.Tables[0].Rows[i]["cub_companyName"].ToString();
                lstCubeDetail[i].countryNameCube = DS.Tables[0].Rows[i]["cub_countryName"].ToString();
                lstCubeDetail[i].code = DS.Tables[0].Rows[i]["cub_code"].ToString();
                lstCubeDetail[i].shippingCube = DS.Tables[0].Rows[i]["cub_shipping"].ToString();
                lstCubeDetail[i].orderCube = DS.Tables[0].Rows[i]["cub_order"].ToString();
                lstCubeDetail[i].createdDateCube = Convert.ToDateTime(DS.Tables[0].Rows[i]["cub_createdDate"]);
                lstCubeDetail[i].modifiedDateCube = Convert.ToDateTime(DS.Tables[0].Rows[i]["cub_modifiedDate"]);
                lstCubeDetail[i].createdByCube = Convert.ToInt32(DS.Tables[0].Rows[i]["cub_createdBy"]);
                lstCubeDetail[i].modifiedByCube = Convert.ToInt32(DS.Tables[0].Rows[i]["cub_modifiedBy"]);
                lstCubeDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cubd_codsec"]);
                lstCubeDetail[i].fkCube = Convert.ToInt32(DS.Tables[0].Rows[i]["cubd_fkCube"]);
                lstCubeDetail[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["cubd_fkProduct"]);
                lstCubeDetail[i].codeProduct = DS.Tables[0].Rows[i]["prod_code"].ToString();
                lstCubeDetail[i].widthProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_width"]);
                lstCubeDetail[i].fkBoxing = Convert.ToInt32(DS.Tables[0].Rows[i]["cubd_fkBoxing"]);
                lstCubeDetail[i].transcodeBoxing = DS.Tables[0].Rows[i]["cub_transcode"].ToString();
                lstCubeDetail[i].transnameBoxing = DS.Tables[0].Rows[i]["cub_transname"].ToString();
                lstCubeDetail[i].transcoilBoxing = Convert.ToInt32(DS.Tables[0].Rows[i]["cub_transcoil"]);
                lstCubeDetail[i].fkPalletDimentions = Convert.ToInt32(DS.Tables[0].Rows[i]["cubd_fkPalletDimentions"]);
                lstCubeDetail[i].dimentionwidthDimentions = Convert.ToInt32(DS.Tables[0].Rows[i]["cub_dimentionwidth"]);
                lstCubeDetail[i].dimentiondepthDimentions = Convert.ToInt32(DS.Tables[0].Rows[i]["cub_dimentiondepth"]);
                lstCubeDetail[i].dimentionfullDimentions = DS.Tables[0].Rows[i]["cub_dimentionfull"].ToString();
                lstCubeDetail[i].Trataiment = DS.Tables[0].Rows[i]["cubd_Trataiment"].ToString();
                lstCubeDetail[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["cubd_quantity"]);
                lstCubeDetail[i].coil = Convert.ToInt32(DS.Tables[0].Rows[i]["cubd_coil"]);
                lstCubeDetail[i].coilweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["cubd_coilweigth"]);
                lstCubeDetail[i].pallet = Convert.ToInt32(DS.Tables[0].Rows[i]["cubd_pallet"]);
                lstCubeDetail[i].palletweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["cubd_palletweigth"]);
                lstCubeDetail[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["cubd_width"]);
                lstCubeDetail[i].rowOne = Convert.ToInt32(DS.Tables[0].Rows[i]["cubd_rowOne"]);
                lstCubeDetail[i].rowTwo = Convert.ToInt32(DS.Tables[0].Rows[i]["cubd_rowTwo"]);
                lstCubeDetail[i].rowThree = Convert.ToInt32(DS.Tables[0].Rows[i]["cubd_rowTree"]);
            }

            return lstCubeDetail;
        }

        public static bool detele(int codsec)
        {
            try
            {
                string queryString = "";
                queryString += "DELETE FROM bps_prod_cubedetail WHERE cubd_codsec = " + codsec.ToString() + ";";
                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCubeDetail.delete");
                return false;
            }
        }

        public static bool deteleCubeDetail(int codsec)
        {
            try
            {
                string queryString = "";
                queryString += "DELETE FROM bps_prod_cubedetail WHERE cubd_fkCube = " + codsec.ToString() + ";";
                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCubeDetail.delete");
                return false;
            }
        }

        public static List<clsCubeDetail> getListByCubeSortMaterial(int codsec)
        {
            List<clsCubeDetail> lstCubeDetail = new List<clsCubeDetail>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("spCube 'ListByCubeSort'," + codsec.ToString() + ",'','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");

            lstCubeDetail.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstCubeDetail.Add(new clsCubeDetail());
                lstCubeDetail[i].codsecCube = Convert.ToInt32(DS.Tables[0].Rows[i]["cub_codsec"]);
                lstCubeDetail[i].fkStatusCube = Convert.ToInt32(DS.Tables[0].Rows[i]["cub_fkStatus"]);
                lstCubeDetail[i].statusName = DS.Tables[0].Rows[i]["cub_statusName"].ToString();
                lstCubeDetail[i].fkTransportCube = Convert.ToInt32(DS.Tables[0].Rows[i]["cub_fkTransport"]);
                lstCubeDetail[i].trasnportNameCube = DS.Tables[0].Rows[i]["cub_trasnportName"].ToString();
                lstCubeDetail[i].usefulHighCube = Convert.ToInt32(DS.Tables[0].Rows[i]["cub_usefulHigh"]);
                lstCubeDetail[i].usefulLongCube = Convert.ToInt32(DS.Tables[0].Rows[i]["cub_usefulLong"]);
                lstCubeDetail[i].usefulWidthCube = Convert.ToInt32(DS.Tables[0].Rows[i]["cub_usefulWidth"]);
                lstCubeDetail[i].companyNameCube = DS.Tables[0].Rows[i]["cub_companyName"].ToString();
                lstCubeDetail[i].countryNameCube = DS.Tables[0].Rows[i]["cub_countryName"].ToString();
                lstCubeDetail[i].code = DS.Tables[0].Rows[i]["cub_code"].ToString();
                lstCubeDetail[i].shippingCube = DS.Tables[0].Rows[i]["cub_shipping"].ToString();
                lstCubeDetail[i].orderCube = DS.Tables[0].Rows[i]["cub_order"].ToString();
                lstCubeDetail[i].createdDateCube = Convert.ToDateTime(DS.Tables[0].Rows[i]["cub_createdDate"]);
                lstCubeDetail[i].modifiedDateCube = Convert.ToDateTime(DS.Tables[0].Rows[i]["cub_modifiedDate"]);
                lstCubeDetail[i].createdByCube = Convert.ToInt32(DS.Tables[0].Rows[i]["cub_createdBy"]);
                lstCubeDetail[i].modifiedByCube = Convert.ToInt32(DS.Tables[0].Rows[i]["cub_modifiedBy"]);
                lstCubeDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cubd_codsec"]);
                lstCubeDetail[i].fkCube = Convert.ToInt32(DS.Tables[0].Rows[i]["cubd_fkCube"]);
                lstCubeDetail[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["cubd_fkProduct"]);
                lstCubeDetail[i].codeProduct = DS.Tables[0].Rows[i]["prod_code"].ToString();
                lstCubeDetail[i].widthProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["prod_width"]);
                lstCubeDetail[i].fkBoxing = Convert.ToInt32(DS.Tables[0].Rows[i]["cubd_fkBoxing"]);
                lstCubeDetail[i].transcodeBoxing = DS.Tables[0].Rows[i]["cub_transcode"].ToString();
                lstCubeDetail[i].transnameBoxing = DS.Tables[0].Rows[i]["cub_transname"].ToString();
                lstCubeDetail[i].transcoilBoxing = Convert.ToInt32(DS.Tables[0].Rows[i]["cub_transcoil"]);
                lstCubeDetail[i].fkPalletDimentions = Convert.ToInt32(DS.Tables[0].Rows[i]["cubd_fkPalletDimentions"]);
                lstCubeDetail[i].dimentionwidthDimentions = Convert.ToInt32(DS.Tables[0].Rows[i]["cub_dimentionwidth"]);
                lstCubeDetail[i].dimentiondepthDimentions = Convert.ToInt32(DS.Tables[0].Rows[i]["cub_dimentiondepth"]);
                lstCubeDetail[i].dimentionfullDimentions = DS.Tables[0].Rows[i]["cub_dimentionfull"].ToString();
                lstCubeDetail[i].Trataiment = DS.Tables[0].Rows[i]["cubd_Trataiment"].ToString();
                lstCubeDetail[i].quantity = Convert.ToDouble(DS.Tables[0].Rows[i]["cubd_quantity"]);
                lstCubeDetail[i].coil = Convert.ToInt32(DS.Tables[0].Rows[i]["cubd_coil"]);
                lstCubeDetail[i].coilweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["cubd_coilweigth"]);
                lstCubeDetail[i].pallet = Convert.ToInt32(DS.Tables[0].Rows[i]["cubd_pallet"]);
                lstCubeDetail[i].palletweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["cubd_palletweigth"]);
                lstCubeDetail[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["cubd_width"]);
            }

            return lstCubeDetail;
        }
    }
}
