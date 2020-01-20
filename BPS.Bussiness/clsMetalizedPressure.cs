using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using System.Data;

namespace BPS.Bussiness
{
    public class clsMetalizedPressure
    {
        //Attributes
        private int mtop_codsec;
        private int mtop_fkOrder;
        private clsMetallizedOrder mtop_Order;
        private double mtop_ingress;
        private double mtop_return;
        private double mtop_down;
        private double mtop_oil;
        private double mtop_up;
        private clsMainCoilMetal mtop_MainCoil;

        //Properties
        public int codsec { get { return mtop_codsec; } set { mtop_codsec = value; } }

        public int fkOrder { get { return mtop_fkOrder; } set { mtop_fkOrder = value; } }

        public clsMetallizedOrder Order { get { return mtop_Order; } set { mtop_Order = value; } }

        public double Ingress { get { return mtop_ingress; } set { mtop_ingress = value; } }

        public double Return { get { return mtop_return; } set { mtop_return = value; } }

        public double Down { get { return mtop_down; } set { mtop_down = value; } }

        public double Oil { get { return mtop_oil; } set { mtop_oil = value; } }

        public double Up { get { return mtop_up; } set { mtop_up = value; } }

        public clsMainCoilMetal MainCoilMetal { get { return mtop_MainCoil; } set { mtop_MainCoil = value; } }


        //Constructor
        public clsMetalizedPressure()
        { 
            mtop_codsec = 0;
            mtop_fkOrder = 0;
            mtop_ingress = 0;
            mtop_return = 0;
            mtop_Order = new clsMetallizedOrder();
            mtop_oil = 0;
            mtop_down = 0;
            mtop_up = 0;
            mtop_MainCoil = new clsMainCoilMetal();
        }

        public clsMetalizedPressure(int Codsec)
        {
            this.load(Codsec);
        }

        //Methods
        public void load(int Codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spMetalizedPresionDeadTime " + Codsec.ToString() + ", 'PresionByCodsec'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mtop_codsec"]);
                this.fkOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["mtop_fkOrder"]);
                this.Order = new clsMetallizedOrder(this.fkOrder);
                this.Ingress = Convert.ToDouble(DS.Tables[0].Rows[0]["mtop_ingress"]);
                this.Return = Convert.ToDouble(DS.Tables[0].Rows[0]["mtop_return"]);
                this.Down = Convert.ToDouble(DS.Tables[0].Rows[0]["mtop_down"]);
                this.Oil = Convert.ToDouble(DS.Tables[0].Rows[0]["mtop_oil"]);
                this.Up = Convert.ToDouble(DS.Tables[0].Rows[0]["mtop_up"]);
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_metalizedpression (mtop_fkOrder, mtop_ingress, mtop_return, mtop_down, mtop_oil, mtop_up)";
                    queryString += " VALUES (";
                    queryString += "" + this.fkOrder.ToString() + ",";
                    queryString += "" + this.Ingress.ToString() + ",";
                    queryString += "" + this.Return.ToString() + ",";
                    queryString += "" + this.Down.ToString() + ",";
                    queryString += "" + this.Oil.ToString() + ",";
                    queryString += "" + this.Up.ToString() + " ";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_metalizedpression";
                    queryString += " SET ";
                    queryString += "mtop_fkOrder = " + this.fkOrder.ToString() + ",";
                    queryString += "mtop_ingress = " + this.Ingress.ToString() + ",";
                    queryString += "mtop_return = " + this.Return.ToString() + ",";
                    queryString += "mtop_down = " + this.Down.ToString() + ",";
                    queryString += "mtop_oil = " + this.Oil.ToString() + ",";
                    queryString += "mtop_up = " + this.Up.ToString() + "";
                    queryString += " WHERE mtop_codsec = " + this.codsec.ToString() + ";";
                }

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMetalizedPressure.save");
                return false;
            }
        }

        public static List<clsMetalizedPressure> getListByOrder(int codsec)
        {
            List<clsMetalizedPressure> lstDeadTimeType = new List<clsMetalizedPressure>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spMetalizedPresionDeadTime " + codsec.ToString() + ", 'PressionByOrder'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstDeadTimeType.Add(new clsMetalizedPressure());
                    lstDeadTimeType[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mtop_codsec"]);
                    lstDeadTimeType[i].fkOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["mtop_fkOrder"]);
                    lstDeadTimeType[i].MainCoilMetal = new clsMainCoilMetal(lstDeadTimeType[i].fkOrder);
                    lstDeadTimeType[i].Ingress = Convert.ToDouble(DS.Tables[0].Rows[i]["mtop_ingress"]);
                    lstDeadTimeType[i].Return = Convert.ToDouble(DS.Tables[0].Rows[i]["mtop_return"]);
                    lstDeadTimeType[i].Down = Convert.ToDouble(DS.Tables[0].Rows[i]["mtop_down"]);
                    lstDeadTimeType[i].Oil = Convert.ToDouble(DS.Tables[0].Rows[i]["mtop_oil"]);
                    lstDeadTimeType[i].Up = Convert.ToDouble(DS.Tables[0].Rows[i]["mtop_up"]);
                }
            }

            return lstDeadTimeType;
        }

        public static List<clsMetalizedPressure> getListByMainCoilMetal(int codsec)
        {
            List<clsMetalizedPressure> lstDeadTimeType = new List<clsMetalizedPressure>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spMetalizedPresionDeadTime " + codsec.ToString() + ", 'PressionByMainCoil'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstDeadTimeType.Add(new clsMetalizedPressure());
                    lstDeadTimeType[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mtop_codsec"]);
                    lstDeadTimeType[i].fkOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["mtop_fkOrder"]);
                    lstDeadTimeType[i].MainCoilMetal = new clsMainCoilMetal(lstDeadTimeType[i].fkOrder);
                    lstDeadTimeType[i].Ingress = Convert.ToDouble(DS.Tables[0].Rows[i]["mtop_ingress"]);
                    lstDeadTimeType[i].Return = Convert.ToDouble(DS.Tables[0].Rows[i]["mtop_return"]);
                    lstDeadTimeType[i].Down = Convert.ToDouble(DS.Tables[0].Rows[i]["mtop_down"]);
                    lstDeadTimeType[i].Oil = Convert.ToDouble(DS.Tables[0].Rows[i]["mtop_oil"]);
                    lstDeadTimeType[i].Up = Convert.ToDouble(DS.Tables[0].Rows[i]["mtop_up"]);
                }
            }

            return lstDeadTimeType;
        }

        public static bool toDelete(int codsec)
        {
            try
            {
                string queryString = "";
                queryString += "DELETE bps_prod_metalizedpression WHERE mtop_codsec = " + codsec.ToString() + ";";
                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMetalizedPressure.save");
                return false;
            }
        }

        //public static List<clsMetalizedDeadTime> getListByGroup(int codsec)
        //{
        //    List<clsMetalizedDeadTime> lstDeadTimeType = new List<clsMetalizedDeadTime>();

        //    DataSet DS = new DataSet();

        //    DS = clsConnection.getDataSetResult("spDeadTimeMetalizedByGroup " + codsec.ToString());

        //    if (DS.Tables[0].Rows.Count > 0)
        //    {
        //        for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
        //        {
        //            lstDeadTimeType.Add(new clsMetalizedDeadTime());
        //            lstDeadTimeType[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mtodtg_codsec"]);
        //            lstDeadTimeType[i].fkDeadTimeGroup = Convert.ToInt32(DS.Tables[0].Rows[i]["mtodtg_fkDeadTime"]);
        //            lstDeadTimeType[i].deadTimeGroupName = DS.Tables[0].Rows[i]["mtogr_name"].ToString();
        //            lstDeadTimeType[i].deadTimeName = DS.Tables[0].Rows[i]["mtodtg_name"].ToString();
        //        }
        //    }

        //    return lstDeadTimeType;
        //}
    }
}
