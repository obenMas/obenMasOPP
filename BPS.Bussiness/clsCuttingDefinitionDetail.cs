using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BPS.Bussiness;

namespace BPS.Bussiness
{
   public class clsCuttingDefinitionDetail
    {
        //Atributes

        private int cuttdefd_codsec;
        private int cuttdefd_fkCuttingDefinition;
        private int cuttdefd_fkSaleOrderDetail;
        private double cuttdefd_quantity;
        private int cuttdefd_priority;

        //Properties

        public int codsec { get { return cuttdefd_codsec; } set { cuttdefd_codsec = value; } }

        public int fkCuttingDefinition { get { return cuttdefd_fkCuttingDefinition; } set { cuttdefd_fkCuttingDefinition = value; } }

        public int fkSaleOrderDetail { get { return cuttdefd_fkSaleOrderDetail; } set { cuttdefd_fkSaleOrderDetail = value; } }

        public double quantity { get { return cuttdefd_quantity; } set { cuttdefd_quantity = value; } }

        public int priority { get { return cuttdefd_priority; } set { cuttdefd_priority = value; } }

        //Constructor

        public clsCuttingDefinitionDetail()
        {
            cuttdefd_codsec = 0;
            cuttdefd_fkCuttingDefinition = 0;
            cuttdefd_fkSaleOrderDetail = 0;
            cuttdefd_quantity = 0;
            cuttdefd_priority = 0;
        }

        public clsCuttingDefinitionDetail(int codsec)
        {
            this.load(codsec);
        }

        public void load(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_cuttingdefinitiondetail WHERE cuttdefd_codsec = " + codsec.ToString());
            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cuttdefd_codsec"]);
                this.fkCuttingDefinition = Convert.ToInt32(DS.Tables[0].Rows[0]["cuttdefd_fkCuttingDefinition"]);
                this.fkSaleOrderDetail = Convert.ToInt32(DS.Tables[0].Rows[0]["cuttdefd_fkSaleOrderDetail"]);
                this.cuttdefd_quantity = Convert.ToDouble(DS.Tables[0].Rows[0]["cuttdefd_quantity"]);
                this.priority = Convert.ToInt32(DS.Tables[0].Rows[0]["cuttdefd_priority"]);
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_cuttingdefinitiondetail (cuttdefd_fkCuttingDefinition, cuttdefd_fkSaleOrderDetail, cuttdefd_quantity, cuttdefd_priority)";
                    queryString += " VALUES ( ";
                    queryString += this.fkCuttingDefinition + ", ";
                    queryString += this.fkSaleOrderDetail + ", ";
                    queryString += this.quantity + ", ";
                    queryString += this.priority;
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_cuttingdefinitiondetail";
                    queryString += " SET ";
                    queryString += "cuttdefd_fkCuttingDefinition = " + this.fkCuttingDefinition + ", ";
                    queryString += "cuttdefd_fkSaleOrderDetail = " + this.fkSaleOrderDetail + ", ";
                    queryString += "cuttdefd_quantity = " + this.cuttdefd_quantity + ", ";
                    queryString += "cuttdefd_priority = " + this.priority;
                    queryString += " WHERE cuttdefd_codsec = " + this.codsec.ToString();
                }
                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCuttingDefinitionDetail.save");
                return false;
            }
        }

       public static void delete(int codsec)
       {
           try
           {
               string queryString = " ";

               queryString += "DELETE FROM bps_prod_cuttingdefinitiondetail";
               queryString += " WHERE cuttdefd_codsec = " + codsec.ToString();
               clsConnection.executeQuery(queryString);
           }
           catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCuttingDefinitionDetail.save");
            }
 
       }

        public static List<clsCuttingDefinitionDetail> getList()
        {
            List<clsCuttingDefinitionDetail> lstCuttingDefinitionDetail = new List<clsCuttingDefinitionDetail>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_cuttingdefinitiondetail order by cuttdefd_codsec asc");

            lstCuttingDefinitionDetail.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstCuttingDefinitionDetail.Add(new clsCuttingDefinitionDetail());
                lstCuttingDefinitionDetail[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cuttdefd_codsec"]);
                lstCuttingDefinitionDetail[i].fkCuttingDefinition = Convert.ToInt32(DS.Tables[0].Rows[0]["cuttdefd_fkCuttingDefinition"]);
                lstCuttingDefinitionDetail[i].fkSaleOrderDetail = Convert.ToInt32(DS.Tables[0].Rows[0]["cuttdefd_fkSaleOrderDetail"]);
                lstCuttingDefinitionDetail[i].cuttdefd_quantity = Convert.ToDouble(DS.Tables[0].Rows[0]["cuttdefd_quantity"]);
                lstCuttingDefinitionDetail[i].priority = Convert.ToInt32(DS.Tables[0].Rows[0]["cuttdefd_priority"]); 
            }

            return lstCuttingDefinitionDetail;
        }

    }
    }
