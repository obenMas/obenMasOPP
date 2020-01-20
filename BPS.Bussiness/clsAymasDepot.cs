using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsAymasDepot
    {
        //Atributes

        private int ayd_codsec;
        private string ayd_Id;
        private string ayd_palletCode;
        private string ayd_film;
        private int ayd_width;
        private double ayd_weigth;
        private string ayd_quality;
        private string ayd_diameter;
        private int ayd_core;
        private string ayd_procedence;
        private int ayd_fkSaleOrderDetail;
        private string ayd_saleOrder;
        private string ayd_customer;
        private string ayd_state;
        private DateTime ayd_date;

        //Properties

        public int codsec { get { return ayd_codsec; } set { ayd_codsec = value; } }
        public string Id { get { return ayd_Id; } set { ayd_Id = value; } }
        public string palletCode { get { return ayd_palletCode; } set { ayd_palletCode = value; } }
        public string film { get { return ayd_film; } set { ayd_film = value; } }
        public int width { get { return ayd_width; } set { ayd_width = value; } }
        public double weigth { get { return ayd_weigth; } set { ayd_weigth = value; } }
        public string quality { get { return ayd_quality; } set { ayd_quality = value; } }
        public string diameter { get { return ayd_diameter; } set { ayd_diameter = value; } }
        public int core { get { return ayd_core; } set { ayd_core = value; } }
        public string procedence { get { return ayd_procedence; } set { ayd_procedence = value; } }
        public int fkSaleOrderDetail { get { return ayd_fkSaleOrderDetail; } set { ayd_fkSaleOrderDetail = value; } }
        public string saleOrder { get { return ayd_saleOrder; } set { ayd_saleOrder = value; } }
        public string customer { get { return ayd_customer; } set { ayd_customer = value; } }
        public string state { get { return ayd_state; } set { ayd_state = value; } }
        public DateTime date { get { return ayd_date; } set { ayd_date = value; } }

        //Constructor

        public clsAymasDepot()
        {
            ayd_codsec=0;
            ayd_Id = string.Empty;
            ayd_palletCode=string.Empty;
            ayd_film=string.Empty;
            ayd_width=0;
            ayd_weigth=0;
            ayd_quality=string.Empty;
            ayd_diameter=string.Empty;
            ayd_core=0;
            ayd_procedence = string.Empty;
            ayd_fkSaleOrderDetail = 0;
            ayd_saleOrder=string.Empty;
            ayd_customer=string.Empty;
            ayd_state=string.Empty;
            ayd_date=DateTime.Now;
        }

        public clsAymasDepot(string pallcode)
        {   
            this.palletCode = pallcode;
            getDetailByCode(palletCode);
            
        }

        //Methods

        public bool save()
        {
            try
            {
                string queryString = "";
                if(this.codsec==0)
                {
                    queryString += "INSERT INTO bps_prod_aymasDepot (ayd_Id, ayd_palletCode, ayd_film, ayd_width, ayd_weigth, ayd_quality, ayd_diameter, ayd_core, ayd_procedence, ayd_saleOrder, ayd_customer, ayd_state, ayd_date) ";
                    queryString += " VALUES (";
                    queryString += "'" + this.Id.ToString() + "', ";
                    queryString += "'" + this.palletCode.ToString() + "', ";
                    queryString += "'" + this.film.ToString() + "', ";
                    queryString += "" + this.width.ToString() + ", ";
                    queryString += "" + this.weigth.ToString() + ", ";
                    queryString += "'" + this.quality.ToString() + "', ";
                    queryString += "'" + this.diameter.ToString() + "', ";
                    queryString += "" + this.core.ToString() + ", ";
                    queryString += "'" + this.procedence.ToString() + "', ";
                    queryString += "'" + this.saleOrder.ToString() + "', ";
                    queryString += "'" + this.customer.ToString() + "', ";
                    queryString += "'" + this.state.ToString() + "', ";
                    queryString += "'" + this.date.ToString("dd/MM/yyyy hh:mm:ss") + "' ";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_aymasDepot ";
                    queryString += " SET ";
                    queryString += "ayd_Id = '" + this.Id.ToString() + "', ";
                    queryString += "ayd_palletCode = '" + this.palletCode.ToString() + "', ";
                    queryString += "ayd_film = '" + this.film.ToString() + "', ";
                    queryString += "ayd_width = " + this.width.ToString() + ", ";
                    queryString += "ayd_weigth = " + this.weigth.ToString() + ", ";
                    queryString += "ayd_quality = '" + this.quality.ToString() + "', ";
                    queryString += "ayd_diameter = '" + this.diameter.ToString() + "', ";
                    queryString += "ayd_core = " + this.core.ToString() + ", ";
                    queryString += "ayd_procedence = '" + this.procedence.ToString() + "', ";
                    queryString += "ayd_saleOrder = '" + this.saleOrder.ToString() + "', ";
                    queryString += "ayd_customer = '" + this.customer.ToString() + "', ";
                    queryString += "ayd_state = '" + this.state.ToString() + "', ";
                    queryString += "ayd_date = '" + this.date.ToString("dd/MM/yyyy hh:mm:ss") + "' ";
                    queryString += " WHERE ayd_codsec = " + this.codsec.ToString() + ";";
                }
                

                clsConnection.executeQuery(queryString);

                GC.Collect();
                GC.WaitForPendingFinalizers();

                return true;
            }
            catch (Exception ex)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();

                clsLog.addLog(ex, 3, "clsAymasDepot.save");
                return false;
            }
        }

        public static List<clsAymasDepot> getList()
        {
            List<clsAymasDepot> lst = new List<clsAymasDepot>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwAymasDepot");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lst.Add(new clsAymasDepot());
                    lst[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["codsec"]);
                    lst[i].Id = DS.Tables[0].Rows[i]["Id"].ToString();
                    lst[i].palletCode = DS.Tables[0].Rows[i]["palletCode"].ToString();
                    lst[i].film = DS.Tables[0].Rows[i]["film"].ToString();
                    lst[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["width"]);
                    lst[i].weigth = Convert.ToDouble(DS.Tables[0].Rows[i]["weigth"]);
                    lst[i].quality = DS.Tables[0].Rows[i]["quality"].ToString();
                    lst[i].diameter = DS.Tables[0].Rows[i]["diameter"].ToString();
                    lst[i].core = Convert.ToInt32(DS.Tables[0].Rows[i]["core"]);
                    lst[i].procedence = DS.Tables[0].Rows[i]["procedence"].ToString();
                    lst[i].fkSaleOrderDetail = Convert.ToInt32(DS.Tables[0].Rows[i]["fkSalesOrderDetail"]);
                    lst[i].saleOrder = DS.Tables[0].Rows[i]["saleOrder"].ToString();
                    lst[i].customer = DS.Tables[0].Rows[i]["customer"].ToString();
                    lst[i].state = DS.Tables[0].Rows[i]["state"].ToString();
                    lst[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["date"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return lst;
        }

        public static void clear()
        {
            clsConnection.executeQuery("DELETE FROM bps_prod_AymasDepot");
        }

        public static clsAymasDepot getDetailByCode(string palletCode)
        {
            clsAymasDepot objPallet = new clsAymasDepot();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spPalletByCodePl('" + palletCode + "')");

            if (DS.Tables[0].Rows.Count > 0)
            {
                objPallet.ayd_codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["Codsec"]);
                objPallet.ayd_Id = DS.Tables[0].Rows[0]["Id"].ToString();
                objPallet.ayd_palletCode = DS.Tables[0].Rows[0]["Código"].ToString();
                objPallet.ayd_film = DS.Tables[0].Rows[0]["Producto"].ToString();
                objPallet.ayd_width = Convert.ToInt32(DS.Tables[0].Rows[0]["Ancho"]);
                objPallet.ayd_weigth = Convert.ToDouble(DS.Tables[0].Rows[0]["Peso"]);
                objPallet.ayd_quality = DS.Tables[0].Rows[0]["Calificación"].ToString();
                objPallet.ayd_diameter = DS.Tables[0].Rows[0]["Diametro"].ToString();
                objPallet.ayd_core = Convert.ToInt32(DS.Tables[0].Rows[0]["Core"]);
                objPallet.ayd_fkSaleOrderDetail = Convert.ToInt32(DS.Tables[0].Rows[0]["fkSaleOrderDetail"]);
                objPallet.ayd_procedence = DS.Tables[0].Rows[0]["procedence"].ToString();
                objPallet.ayd_saleOrder = DS.Tables[0].Rows[0]["OV"].ToString();
                objPallet.ayd_customer = DS.Tables[0].Rows[0]["Cliente"].ToString();
                objPallet.ayd_state = DS.Tables[0].Rows[0]["Estado"].ToString();
                objPallet.ayd_date = Convert.ToDateTime(DS.Tables[0].Rows[0]["Fecha"]);
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return objPallet;
        }

        public static List<clsAymasDepot> getAvailableListBySalesOrderDetailPL(int SalesOrderDetailCodsec)
        {
            List<clsAymasDepot> lstPallet = new List<clsAymasDepot>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spAvailablePalletListBySalesOrderDetailPL(" + SalesOrderDetailCodsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstPallet.Add(new clsAymasDepot());
                    lstPallet[i].palletCode = DS.Tables[0].Rows[i]["palletcode"].ToString();
                    lstPallet[i].film = DS.Tables[0].Rows[i]["Pelicula"].ToString();
                    lstPallet[i].width = Convert.ToInt32(DS.Tables[0].Rows[i]["Ancho"]);
                    lstPallet[i].diameter = DS.Tables[0].Rows[i]["Diametro"].ToString();
                    lstPallet[i].core = Convert.ToInt32(DS.Tables[0].Rows[i]["Core"]);
                    lstPallet[i].weigth = Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                    lstPallet[i].customer = DS.Tables[0].Rows[i]["Cliente"].ToString();
                    lstPallet[i].saleOrder = DS.Tables[0].Rows[i]["OV"].ToString();
                    lstPallet[i].state = DS.Tables[0].Rows[i]["Posicion"].ToString();
                    lstPallet[i].procedence = DS.Tables[0].Rows[i]["Origen"].ToString();
                    lstPallet[i].quality = DS.Tables[0].Rows[i]["Calificacion"].ToString();
                    lstPallet[i].date = Convert.ToDateTime(DS.Tables[0].Rows[i]["Fecha"]);
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return lstPallet;
        }

        public static List<clsAymasDepot> getPalletListBySalesOrderNumber(string number)
        {
            List<clsAymasDepot> lstPalletPreShippingPL = new List<clsAymasDepot>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spPalletBySalesOrderPL('" + number + "')");
            lstPalletPreShippingPL.Clear();
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {

                lstPalletPreShippingPL.Add(new clsAymasDepot());
                lstPalletPreShippingPL[i].palletCode = DS.Tables[0].Rows[i]["Código"].ToString();
                lstPalletPreShippingPL[i].film = DS.Tables[0].Rows[i]["Producto"].ToString();
                lstPalletPreShippingPL[i].saleOrder = DS.Tables[0].Rows[i]["OV"].ToString();
                lstPalletPreShippingPL[i].weigth = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]), 2);
                lstPalletPreShippingPL[i].state = DS.Tables[0].Rows[i]["Estado"].ToString();
            }
            return lstPalletPreShippingPL;
        }

        public static List<clsAymasDepot> getPalletListByPreShipingNumber(string number)
        {
            List<clsAymasDepot> lstPalletPreShippingPL = new List<clsAymasDepot>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spPalletPreShippingDetailPL('" + number + "')");
            lstPalletPreShippingPL.Clear();
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstPalletPreShippingPL.Add(new clsAymasDepot());
                lstPalletPreShippingPL[i].palletCode = DS.Tables[0].Rows[i]["Código"].ToString();
                lstPalletPreShippingPL[i].customer = DS.Tables[0].Rows[i]["Cliente"].ToString();
                lstPalletPreShippingPL[i].saleOrder = DS.Tables[0].Rows[i]["OV"].ToString();
                lstPalletPreShippingPL[i].film = DS.Tables[0].Rows[i]["Producto"].ToString();
                lstPalletPreShippingPL[i].weigth = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]), 2);
            }
            return lstPalletPreShippingPL;
        }



    }
}
