using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsNewProductionOrderMetalDetail
    {
        //Attribute

        private int npomd_codsec;
        private int npomd_fkProductMetalOrder;
        private int npomd_fkCoil;
        private double npomd_netWeigth;
        private int npomd_fkProduct;
        
        //Properties

        public int codsec { get { return npomd_codsec; } set { npomd_codsec= value; } }
        public int fkProductMetalOrder { get { return npomd_fkProductMetalOrder; } set { npomd_fkProductMetalOrder = value; } }
        public int fkCoil { get { return npomd_fkCoil; } set { npomd_fkCoil = value; } }
        public double netWeigth { get { return npomd_netWeigth; } set { npomd_netWeigth = value; } }
        public int fkProduct { get { return npomd_fkProduct; } set { npomd_fkProduct = value; } }

        //Constructor

        public clsNewProductionOrderMetalDetail()
        {
            codsec = 0;
            fkProductMetalOrder = 0;
            fkCoil = 0;
            netWeigth = 0;
            fkProduct = 0;
        }

        public clsNewProductionOrderMetalDetail(int fkCoil)
        {
            this.load(fkCoil);
        }

        //Method

        public void load(int fkCoil)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_newProductionOderMetalDetail WHERE npomd_fkCoil = " + fkCoil.ToString());

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["npomd_codsec"]);
                this.fkCoil = Convert.ToInt32(DS.Tables[0].Rows[0]["npomd_fkCoil"]);
                this.fkProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["npomd_fkProduct"]);
                this.fkProductMetalOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["npomd_fkProdMetalOrder"]);
                this.netWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["npomd_netWeigth"]);
            }
        }

        public bool save()
        {
            
            DataSet DS = new DataSet();
            string query = "";

            try
            {
                if (codsec == 0)
                {
                    query = "INSERT INTO bps_prod_NewProductionOrderMetalDetail(npomd_fkProdMetalOrder,npomd_fkCoil,npomd_netWeigth,npomd_fkProduct)";
                    query += "VALUE(";
                    query += this.fkProductMetalOrder.ToString() + ",";
                    query += this.fkCoil.ToString() + ",";
                    query += this.netWeigth.ToString() + ",";
                    query += this.fkProduct.ToString() + ")";
                }
                else
                {
                    query = "UPDATE bps_prod_NewProductionOrderMetalDetail";
                    query += "SET";
                    query += "npomd_fkProdMetalOrder = " + this.fkProductMetalOrder.ToString() + ",";
                    query += "npomd_fkCoil = " + this.fkCoil + ",";
                    query += "npomd_netWeigth = " + this.netWeigth.ToString() + ",";
                    query += "npomd_fkProduct = " + this.fkProduct.ToString() + "";
                    query += "WHERE npomd_codsec = " + this.codsec;
                }

                return clsConnection.executeQuery(query);

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsNewProductionOrderMetalDetail.save");
                return false;
            }
        }

        public static bool CanCancel(string lote)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwNewMetOrdQuantitysByLote WHERE lote = '" + lote + "'");

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                if (Convert.ToDouble(DS.Tables[0].Rows[0]["cantTotal"]) > Convert.ToDouble(DS.Tables[0].Rows[0]["pesoMetalizado"]))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }
    }
}
