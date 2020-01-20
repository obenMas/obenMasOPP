using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsNewProductionOrderMetal
    {
        // Atributes
        private int npom_codsec;
        private int npom_fkFilmInit;
        private int npom_fkFilmFin;
        private int npom_fkStatus;
        private int npom_width;
        private string npom_lote;
        private double npom_quantity;
        private DateTime npom_CreatedDate;
        private DateTime npom_modifiedDate;
        private DateTime npom_initEstimatedDate;
        private int npom_fkMachine;
        private int npom_createdBy;
        private int npom_modifiedBy;
        private string npom_observation;

        // Properties

        public int codsec{get { return npom_codsec; }set { npom_codsec = value; }}

        public int fkFilmInit { get { return npom_fkFilmInit; } set { npom_fkFilmInit = value; } }

        public int fkFilmFin { get { return npom_fkFilmFin; } set { npom_fkFilmFin = value; } }

        public int fkStatus{get { return npom_fkStatus; }set { npom_fkStatus = value; }}

        public int width { get { return npom_width; } set { npom_width = value; } }

        public double quantity{get { return npom_quantity; }set { npom_quantity = value; }}

        public DateTime CreatedDate{get { return npom_CreatedDate; }set { npom_CreatedDate = value; }}   

        public DateTime modifiedDate{get { return npom_modifiedDate; }set { npom_modifiedDate = value; }}

        public DateTime initEstimatedDate { get { return npom_initEstimatedDate; } set { npom_initEstimatedDate = value; } }

        public int fkMachine { get { return npom_fkMachine; } set { npom_fkMachine = value; } }

        public int createdBy{get { return npom_createdBy; }set { npom_createdBy = value; }}

        public int modifiedBy{get { return npom_modifiedBy; }set { npom_modifiedBy = value; }}

        public string lote{get { return npom_lote; }set { npom_lote = value; }}

        public string observation { get { return npom_observation; } set { npom_observation = value; } }

        // Constructor
        
        public clsNewProductionOrderMetal()
        {
            codsec = 0;
            fkFilmInit = 0;
            fkFilmFin = 0;
            fkStatus = 0;
            width = 0;
            quantity = 0;
            fkMachine = 0;
            CreatedDate = DateTime.Now;
            modifiedDate = DateTime.Now;
            initEstimatedDate = DateTime.Now;
            createdBy = 0;
            modifiedBy = 0;
            observation = "";
        }

        public clsNewProductionOrderMetal(string lote)
        {
            this.load(lote);
        }

        // Metodos
        
        public void load(string lote)
        {
            DataSet DS = new DataSet();

            string query = "";

            query = "SELECT * FROM bps_prod_NewProductionOrderMetal WHERE npom_lote='" + lote + "'";

            DS = clsConnection.getDataSetResult(query);

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {

                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["npom_codsec"]);
                this.fkFilmInit= Convert.ToInt32(DS.Tables[0].Rows[0]["npom_fkFilmInit"]);
                this.fkFilmFin = Convert.ToInt32(DS.Tables[0].Rows[0]["npom_fkFilmFin"]);
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["npom_fkStatus"]);
                this.width = Convert.ToInt32(DS.Tables[0].Rows[0]["npom_width"]);
                this.quantity = Convert.ToDouble(DS.Tables[0].Rows[0]["npom_quantity"]);
                this.lote = DS.Tables[0].Rows[0]["npom_lote"].ToString();
                this.CreatedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["npom_CreatedDate"]);
                this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["npom_modifiedDate"]);
                this.initEstimatedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["npom_initEstimatedDate"]);
                this.fkMachine = Convert.ToInt32(DS.Tables[0].Rows[0]["npom_fkMachine"]);
                this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["npom_createdBy"]);
                this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["npom_modifiedBy"]);
                this.observation = DS.Tables[0].Rows[0]["npom_observation"].ToString();
                
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
                    query = "INSERT INTO bps_prod_NewProductionOrderMetal(npom_fkFilmInit,npom_fkFilmFin,npom_width,npom_fkMachine,npom_fkStatus,npom_quantity,npom_lote,npom_CreatedDate,npom_modifiedDate,npom_initEstimatedDate,npom_createdBy,npom_observation,npom_modifiedBy)";
                    query += "VALUES(";
                    query += this.fkFilmInit.ToString() + ",";
                    query += this.fkFilmFin.ToString() + ",";
                    query += this.width.ToString() + ",";
                    query += this.fkMachine.ToString() + ",";
                    query += this.fkStatus.ToString() + ",";
                    query += this.quantity.ToString() + ",'";
                    query += this.lote.ToString() + "','";
                    query += this.CreatedDate.ToString("dd/MM/yyyy HH:mm") + "','";
                    query += this.modifiedDate.ToString("dd/MM/yyyy HH:mm") + "','";
                    query += this.initEstimatedDate.ToString("dd/MM/yyyy HH:mm") + "',";
                    query += this.createdBy.ToString() + ",'";
                    query += this.observation.ToString() + "',";
                    query += this.modifiedBy.ToString() + ")";
                }
                else
                {
                    query = "UPDATE bps_prod_NewProductionOrderMetal ";
                    query += "SET ";
                    query += "npom_fkFilmInit = " + this.fkFilmInit.ToString() + ",";
                    query += "npom_fkFilmFin = " + this.fkFilmFin.ToString() + ",";
                    query += "npom_width = " + this.width.ToString() + ",";
                    query += "npom_fkMachine = " + this.fkMachine.ToString() + ",";
                    query += "npom_fkStatus = " + this.fkStatus.ToString() + ",";
                    query += "npom_quantity = " + this.quantity.ToString() + ",";
                    query += "npom_lote = '" + this.lote.ToString() + "',";
                    query += "npom_CreatedDate = '" + this.CreatedDate.ToString("dd/MM/yyyy HH:mm") + "',";
                    query += "npom_modifiedDate = '" + this.modifiedDate.ToString("dd/MM/yyyy HH:mm") + "',";
                    query += "npom_initEstimatedDate = '" + this.initEstimatedDate.ToString("dd/MM/yyyy HH:mm") + "',";
                    query += "npom_createdBy = " + this.createdBy.ToString() + ",";
                    query += "npom_observation = '" + this.observation.ToString() + "',";
                    query += "npom_modifiedBy = " + this.modifiedBy.ToString() + " ";
                    query += "WHERE npom_codsec = " + this.codsec.ToString();
                }

                return clsConnection.executeQuery(query);
                
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex,3,"clsNewProductionOrderMetal.save");
                return false;
            }
        }

        public DataSet getListNPOMDetail()
        {
            
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_newProductionOrderMetalDetail WHERE npomd_fkProdMetalOrder = " + this.codsec);

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                return DS;
            }
            else
            {
                return DS;
            }

        }

        public DataSet getListNPOMDetail2()
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_newProductionOrderMetalDetail WHERE npomd_fkProdMetalOrder = " + this.codsec);

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                return DS;
            }
            else
            {
                return DS;
            }

        }

        public bool delete()
        {

            try
            {
                string query = "DELETE * FROM ";
                return true;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex,3,"clsNewProductionOrderMetal.delete");
                return false;
            }
            
        }

        public static DataSet getDetailByOrder(int order)
        {
            DataSet DS = new DataSet();
                        
            try
            {
                DS = clsConnection.getDataSetResult("CALL spNewMetalOrderDetail(" + order + ")");

                return DS;

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex,3,"clsNewProductionOrderMetal.getDetailByLote");
                DS.Tables[0].Rows[0]["npomd_codsec"] = 0;
                return DS;
            }
        }

        public bool cancel()
        {
            string query = "UPDATE bps_prod_NewProductionOrderMetal SET npom_fkStatus = 48 WHERE npom_codsec =" + this.codsec;

            return clsConnection.executeQuery(query);
        }

        public void pause()
        {
            string query = "UPDATE bps_prod_NewProductionOrderMetalDetail SET npom_fkStatus = 1069 WHERE npom_codsec = " + this.codsec;

            clsConnection.executeQuery(query);
        }

        public static int returnCodsecByLote(string lote)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT bps_prod_NewProductionOrderMetal.npom_codsec FROM bps_prod_NewProductionOrderMetal WHERE npom_lote = " + lote);

            return Convert.ToInt32(DS.Tables[0].Rows[0]["npom_codsec"]);
        }

        public bool imTheOnlyOne(int codsecPOM)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_NewProductionOrderMetal WHERE npom_codsec = " + codsecPOM.ToString());

            if (DS.Tables[0].Rows.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
