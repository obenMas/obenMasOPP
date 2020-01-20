using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que adminisrta las transfspyerencias de Suministros al area de produccion
    /// </summary>
    public class clsSupplytransfer
    {

        //Atributes

        private int transfspy_codsec;
        private int transfspy_fkSupplyByReception;
        private double transfspy_amountTransferred;
        private string transfspy_number;
        private DateTime transfspy_createdDate;
        private DateTime transfspy_modifiedDate;
        private int transfspy_createdBy;
        private string transfspy_creatorUser;
        private int transfspy_modifiedBy;
        private string transfspy_modificatorUser;
        private int transfspy_fkSupply;
        private string transfspy_supplyName;
        private int transfspy_fkEntity;
        private string transfspy_EntityName;
        private int transfspy_availableUnits;
        private double transfspy_availableWeigth;
        private int transfspy_fkCellar;
        private string transfspy_cellarName;
        private double transfspy_cost;
        private int transfspy_fkUnit;
        private string transfspy_unitName;
        private double transfspy_Quote;
        private int transfspy_unitsTransferred;
        private string transfspy_code;
        private double transfspy_unitWeigth;

        //Properties

        public int codsec { get { return transfspy_codsec; } set { transfspy_codsec = value; } }

        public int fkSupplyByReception { get { return transfspy_fkSupplyByReception; } set { transfspy_fkSupplyByReception = value; } }

        public double amountTransferred { get { return transfspy_amountTransferred; } set { transfspy_amountTransferred = value; } }

        public string number { get { return transfspy_number; } set { transfspy_number = value; } }

        public DateTime createdDate { get { return transfspy_createdDate; } set { transfspy_createdDate = value; } }

        public DateTime modifiedDate { get { return transfspy_modifiedDate; } set { transfspy_modifiedDate = value; } }

        public int createdBy { get { return transfspy_createdBy; } set { transfspy_createdBy = value; } }

        public string creatorUser { get { return transfspy_creatorUser; } set { transfspy_creatorUser = value; } }

        public int modifiedBy { get { return transfspy_modifiedBy; } set { transfspy_modifiedBy = value; } }

        public string modificatorUser { get { return transfspy_modificatorUser; } set { transfspy_modificatorUser = value; } }

        public int fkSupply { get { return transfspy_fkSupply; } set { transfspy_fkSupply = value; } }

        public string supplyName { get { return transfspy_supplyName; } set { transfspy_supplyName = value; } }

        public int fkEntity { get { return transfspy_fkEntity; } set { transfspy_fkEntity = value; } }

        public string entityName { get { return transfspy_EntityName; } set { transfspy_EntityName = value; } }

        public int availableUnits { get { return transfspy_availableUnits; } set { transfspy_availableUnits = value; } }

        public double availableWeigth { get { return transfspy_availableWeigth; } set { transfspy_availableWeigth = value; } }

        public int fkCellar { get { return transfspy_fkCellar; } set { transfspy_fkCellar = value; } }

        public string cellarName { get { return transfspy_cellarName; } set { transfspy_cellarName = value; } }

        public double cost { get { return transfspy_cost; } set { transfspy_cost = value; } }

        public int fkUnit { get { return transfspy_fkUnit; } set { transfspy_fkUnit = value; } }

        public string unitName { get { return transfspy_unitName; } set { transfspy_unitName = value; } }

        public double Quote { get { return transfspy_Quote; } set { transfspy_Quote = value; } }

        public int unitsTransferred { get { return transfspy_unitsTransferred; } set { transfspy_unitsTransferred = value; } }

        public string code { get { return transfspy_code; } set { transfspy_code = value; } }

        public double unitWeigth { get { return transfspy_unitWeigth; } set { transfspy_unitWeigth = value; } }

        public string EntityName { get { return transfspy_EntityName; } set { transfspy_EntityName = value; } }

        //Constructor

        public clsSupplytransfer()
        {
            transfspy_codsec = 0;
            transfspy_fkSupplyByReception = 0;
            transfspy_amountTransferred = 0;
            transfspy_number = "";
            transfspy_createdDate = DateTime.Now;
            transfspy_modifiedDate = DateTime.Now;
            transfspy_createdBy = 0;
            transfspy_creatorUser = "";
            transfspy_modifiedBy = 0;
            transfspy_modificatorUser = "";
            transfspy_fkSupply = 0;
            transfspy_supplyName = "";
            transfspy_fkEntity = 0;
            transfspy_EntityName = "";
            transfspy_availableUnits = 0;
            transfspy_availableWeigth = 0;
            transfspy_fkCellar = 0;
            transfspy_cellarName = "";
            transfspy_cost = 0;
            transfspy_fkUnit = 0;
            transfspy_unitName = "";
            transfspy_Quote = 0;
            transfspy_unitsTransferred = 0;
            transfspy_code = "";
            transfspy_unitWeigth = 0;
        }

        public clsSupplytransfer(int codsec)
        {

            this.load(codsec);
        }

        //Methods

        public void load(int codsec)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwsupplytransfer where transfspy_codsec = " + codsec.ToString() + " group by transfspy_codsec");


            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["transfspy_codsec"]);
            this.fkSupplyByReception = Convert.ToInt32(DS.Tables[0].Rows[0]["transfspy_fkSupplyByReception"]);
            this.amountTransferred = Convert.ToDouble(DS.Tables[0].Rows[0]["transfspy_amountTransferred"]);
            this.number = DS.Tables[0].Rows[0]["transfspy_number"].ToString();
            this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["transfspy_createdDate"]);
            this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["transfspy_modifiedDate"]);
            this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["transfspy_createdBy"]);
            this.creatorUser = DS.Tables[0].Rows[0]["transfspy_creatorUser"].ToString();
            this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["transfspy_modifiedBy"]);
            this.modificatorUser = DS.Tables[0].Rows[0]["transfspy_modificatorUser"].ToString();
            this.fkSupply = Convert.ToInt32(DS.Tables[0].Rows[0]["transfspy_fkSupply"]);
            this.supplyName = DS.Tables[0].Rows[0]["transfspy_supplyName"].ToString();
            this.fkEntity = Convert.ToInt32(DS.Tables[0].Rows[0]["transfspy_fkEntity"]);
            this.entityName = DS.Tables[0].Rows[0]["transfspy_EntityName"].ToString();
            this.fkCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["transfspy_fkCellar"]);
            this.cellarName = DS.Tables[0].Rows[0]["transfspy_cellarName"].ToString();
            this.fkUnit = Convert.ToInt32(DS.Tables[0].Rows[0]["transfspy_fkUnit"]);
            this.unitName = DS.Tables[0].Rows[0]["transfspy_unitName"].ToString();
            this.unitsTransferred = Convert.ToInt32(DS.Tables[0].Rows[0]["transfspy_unitsTransferred"]);
            this.unitWeigth = Convert.ToDouble(DS.Tables[0].Rows[0]["transfspy_unitWeigth"]);
            this.code = DS.Tables[0].Rows[0]["transfspy_code"].ToString();
            
        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_supplytransfer (transfspy_fkSupplyByReception,transfspy_fkCellar,transfspy_number,transfspy_amountTransferred,transfspy_unitsTransferred,transfspy_createdBy,transfspy_createdDate,transfspy_modifiedBy,transfspy_modifiedDate)";
                    queryString += " VALUES (";
                    queryString += "" + this.fkSupplyByReception + ",";
                    queryString += "" + this.fkCellar + ",";
                    queryString += "'" + this.number + "',";
                    queryString += "" + this.amountTransferred + ",";                    
                    queryString += "" + this.unitsTransferred + ",";
                    queryString += clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += "'" + this.createdDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += "'" + this.modifiedDate.ToString("dd/MM/yyyy HH:mm:ss");
                    queryString += ");";

                }
                else
                {
                    queryString += "UPDATE bps_prod_supplytransfer";
                    queryString += " SET ";
                    queryString += "transfspy_fkSupplyByReception = " + this.fkSupplyByReception + ",";
                    queryString += "transfspy_fkCellar = " + this.fkCellar + ",";
                    queryString += "transfspy_amountTransferred = " + this.amountTransferred + ",";
                    queryString += "transfspy_unitsTransferred = " + this.unitsTransferred + ",";
                    queryString += "transfspy_number = '" + this.number + "',";
                    queryString += "transfspy_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString();
                    queryString += "transfspy_modifiedDate" + this.modifiedDate.ToString("dd/MM/yyyy HH:mm:ss") + "'";
                    queryString += " WHERE transfspy_codsec = " + this.codsec.ToString() + ";";


                }
                clsConnection.executeQuery(queryString);
                return true;
            }

            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsSupplytransfer.save");
                return false;
            }
        }


        public static List<clsSupplytransfer> getList()
        {
            List<clsSupplytransfer> lstSupplyTransfer = new List<clsSupplytransfer>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwSupplyTransfer group by transfspy_codsec");

            lstSupplyTransfer.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {

                lstSupplyTransfer.Add(new clsSupplytransfer());
                lstSupplyTransfer[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["transfspy_codsec"]);
                lstSupplyTransfer[i].fkSupplyByReception = Convert.ToInt32(DS.Tables[0].Rows[i]["transfspy_fkSupplyByReception"]);
                lstSupplyTransfer[i].amountTransferred = Convert.ToDouble(DS.Tables[0].Rows[i]["transfspy_amountTransferred"]);
                lstSupplyTransfer[i].number = DS.Tables[0].Rows[i]["transfspy_number"].ToString();
                lstSupplyTransfer[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["transfspy_createdDate"]);
                lstSupplyTransfer[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["transfspy_modifiedDate"]);
                lstSupplyTransfer[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["transfspy_createdBy"]);
                lstSupplyTransfer[i].creatorUser = DS.Tables[0].Rows[i]["transfspy_creatorUser"].ToString();
                lstSupplyTransfer[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["transfspy_modifiedBy"]);
                lstSupplyTransfer[i].modificatorUser = DS.Tables[0].Rows[i]["transfspy_modificatorUser"].ToString();
                lstSupplyTransfer[i].fkSupply = Convert.ToInt32(DS.Tables[0].Rows[i]["transfspy_fkSupply"]);
                lstSupplyTransfer[i].supplyName = DS.Tables[0].Rows[i]["transfspy_supplyName"].ToString();
                lstSupplyTransfer[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["transfspy_fkEntity"]);
                lstSupplyTransfer[i].entityName = DS.Tables[0].Rows[i]["transfspy_EntityName"].ToString();
                lstSupplyTransfer[i].fkCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["transfspy_fkCellar"]);
                lstSupplyTransfer[i].cellarName = DS.Tables[0].Rows[i]["transfspy_cellarName"].ToString();
                lstSupplyTransfer[i].fkUnit = Convert.ToInt32(DS.Tables[0].Rows[i]["transfspy_fkUnit"]);
                lstSupplyTransfer[i].unitName = DS.Tables[0].Rows[i]["transfspy_unitName"].ToString();
                lstSupplyTransfer[i].unitsTransferred = Convert.ToInt32(DS.Tables[0].Rows[i]["transfspy_unitsTransferred"]);
                lstSupplyTransfer[i].code = DS.Tables[0].Rows[i]["transfspy_code"].ToString();
                lstSupplyTransfer[i].unitWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["transfspy_unitWeigth"]);


            }

            return lstSupplyTransfer;
        }


        public static List<clsSupplytransfer> getListByFilter(List<clsFilter> lstFilter)
        {
            List<clsSupplytransfer> lstSupplyTransfer = new List<clsSupplytransfer>();
            DataSet DS = new DataSet();

            string where = "";

            if (clsFilter.getSql(lstFilter) != "")
                where = " WHERE " + clsFilter.getSql(lstFilter);

            DS = clsConnection.getDataSetResult("SELECT * FROM vwSupplyTransfer " + where + " group by transfspy_codsec order by transfspy_createdDate DESC");

            lstSupplyTransfer.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstSupplyTransfer.Add(new clsSupplytransfer());
                lstSupplyTransfer[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["transfspy_codsec"]);
                lstSupplyTransfer[i].fkSupplyByReception = Convert.ToInt32(DS.Tables[0].Rows[i]["transfspy_fkSupplyByReception"]);
                lstSupplyTransfer[i].amountTransferred = Convert.ToDouble(DS.Tables[0].Rows[i]["transfspy_amountTransferred"]);
                lstSupplyTransfer[i].number = DS.Tables[0].Rows[i]["transfspy_number"].ToString();
                lstSupplyTransfer[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["transfspy_createdDate"]);
                lstSupplyTransfer[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["transfspy_modifiedDate"]);
                lstSupplyTransfer[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["transfspy_createdBy"]);
                lstSupplyTransfer[i].creatorUser = DS.Tables[0].Rows[i]["transfspy_creatorUser"].ToString();
                lstSupplyTransfer[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["transfspy_modifiedBy"]);
                lstSupplyTransfer[i].modificatorUser = DS.Tables[0].Rows[i]["transfspy_modificatorUser"].ToString();
                lstSupplyTransfer[i].fkSupply = Convert.ToInt32(DS.Tables[0].Rows[i]["transfspy_fkSupply"]);
                lstSupplyTransfer[i].supplyName = DS.Tables[0].Rows[i]["transfspy_supplyName"].ToString();
                lstSupplyTransfer[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["transfspy_fkEntity"]);
                lstSupplyTransfer[i].entityName = DS.Tables[0].Rows[i]["transfspy_EntityName"].ToString();
                lstSupplyTransfer[i].fkCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["transfspy_fkCellar"]);
                lstSupplyTransfer[i].cellarName = DS.Tables[0].Rows[i]["transfspy_cellarName"].ToString();
                lstSupplyTransfer[i].fkUnit = Convert.ToInt32(DS.Tables[0].Rows[i]["transfspy_fkUnit"]);
                lstSupplyTransfer[i].unitName = DS.Tables[0].Rows[i]["transfspy_unitName"].ToString();
                lstSupplyTransfer[i].unitsTransferred = Convert.ToInt32(DS.Tables[0].Rows[i]["transfspy_unitsTransferred"]);
                lstSupplyTransfer[i].code = DS.Tables[0].Rows[i]["transfspy_code"].ToString();
                lstSupplyTransfer[i].unitWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["transfspy_unitWeigth"]);


            }

            return lstSupplyTransfer;
        }


        public string getLastBatch()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT transfspy_number FROM bps_prod_supplytransfer order by transfspy_codsec desc Limit 1");


            if (DS.Tables[0].Rows.Count == 0)
                return "";
            else
                return DS.Tables[0].Rows[0]["transfspy_number"].ToString();
        }










    }
}
