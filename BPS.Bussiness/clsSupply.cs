using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;


namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra los suministros
    /// </summary>
    public class clsSupply
    {
        //Atributes


        private int spy_codsec;
        private int spy_fkUnit;
        private string spy_UnitName;
        private int spy_fkEntity;
        private string spy_EntityName;
        private string spy_name;
        private string spy_code;
        private string spy_note;
        private DateTime spy_createdDate;
        private DateTime spy_modifiedDate;
        private int spy_createdBy;
        private string spy_creatorUser;
        private int spy_modifiedBy;
        private string spy_modificatorUser;

        //Properties

        public int codsec { get { return spy_codsec; } set { spy_codsec = value; } }

        public int fkEntity { get { return spy_fkEntity; } set { spy_fkEntity = value; } }

        public string EntityName { get { return spy_EntityName; } set { spy_EntityName = value; } }

        public int fkUnit { get { return spy_fkUnit; } set { spy_fkUnit = value; } }

        public string UnitName { get { return spy_UnitName; } set { spy_UnitName = value; } }

        public string name { get { return spy_name; } set { spy_name = value; } }

        public string code { get { return spy_code; } set { spy_code = value; } }

        public string note { get { return spy_note; } set { spy_note = value; } }

        public DateTime createdDate { get { return spy_createdDate; } set { spy_createdDate = value; } }

        public DateTime modifiedDate { get { return spy_modifiedDate; } set { spy_modifiedDate = value; } }

        public int createdBy { get { return spy_createdBy; } set { spy_createdBy = value; } }

        public string creatorUser { get { return spy_creatorUser; } set { spy_creatorUser = value; } }

        public int modifiedBy { get { return spy_modifiedBy; } set { spy_modifiedBy = value; } }

        public string modificatorUser { get { return spy_modificatorUser; } set { spy_modificatorUser = value; } }

        //Constructor

        public clsSupply()
        {
            spy_codsec = 0;
            spy_fkEntity = 0;
            spy_fkUnit = 0;
            spy_UnitName = "";
            spy_EntityName = "";
            spy_name = "";
            spy_code = "";
            spy_note = "";
            spy_createdDate = DateTime.Now;
            spy_modifiedDate = DateTime.Now;
            spy_createdBy = 0;
            spy_creatorUser = "";
            spy_modifiedBy = 0;
            spy_modificatorUser = "";
        }

             //Methods

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwSupply where spy_codsec =  " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["spy_codsec"]);
            this.fkEntity = Convert.ToInt32(DS.Tables[0].Rows[0]["spy_fkEntity"]);
            this.EntityName = DS.Tables[0].Rows[0]["spy_EntityName"].ToString();
            this.fkUnit = Convert.ToInt32(DS.Tables[0].Rows[0]["spy_fkUnit"]);
            this.UnitName = DS.Tables[0].Rows[0]["spy_UnitName"].ToString();
            this.name = DS.Tables[0].Rows[0]["spy_name"].ToString();
            this.code = DS.Tables[0].Rows[0]["spy_code"].ToString();
            this.note = DS.Tables[0].Rows[0]["spy_note"].ToString();
            this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["spy_createdDate"]);
            this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["spy_modifiedDate"]);
            this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["spy_createdBy"]);
            this.creatorUser = DS.Tables[0].Rows[0]["spy_creatorUser"].ToString();
            this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["spy_modifiedBy"]);
            this.modificatorUser = DS.Tables[0].Rows[0]["spy_modificatorUser"].ToString();

        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_supply(spy_fkEntity,spy_fkUnit,spy_name,spy_code,spy_note,spy_createdDate,spy_modifiedDate,spy_createdBy,spy_modifiedBy)";
                    queryString += " VALUES (";
                    queryString += this.fkEntity.ToString() + ",";
                    queryString += this.fkUnit.ToString() + ",";                    
                    queryString += "'" + this.name + "',";
                    queryString += "'" + this.code + "',";
                    queryString += "'" + this.note + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += clsGlobal.LoggedUser.codsec.ToString();
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_prod_supply";
                    queryString += " SET ";
                    queryString += "spy_fkUnit = " + this.fkUnit + ",";
                    queryString += "spy_fkEntity = " + this.fkEntity + ",";
                    queryString += "spy_name = '" + this.name.ToString() + "',";
                    queryString += "spy_code = '" + this.code.ToString() + "',";
                    queryString += "spy_note = '" + this.note.ToString() + "',";
                    queryString += "spy_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "spy_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString();
                    queryString += " WHERE spy_codsec = " + this.codsec.ToString() + ";";
                    clsConnection.executeQuery(queryString);
                }
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsSupply.save");
                return false;
            }
        }

        public static List<clsSupply> getList()
        {
            List<clsSupply> lstSupply = new List<clsSupply>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwSupply order by spy_name desc");

            lstSupply.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstSupply.Add(new clsSupply());
                lstSupply[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["spy_codsec"]);
                lstSupply[i].fkEntity = Convert.ToInt32(DS.Tables[0].Rows[i]["spy_fkEntity"]);
                lstSupply[i].EntityName = DS.Tables[0].Rows[i]["spy_EntityName"].ToString();
                lstSupply[i].fkUnit = Convert.ToInt32(DS.Tables[0].Rows[i]["spy_fkUnit"]);
                lstSupply[i].UnitName = DS.Tables[0].Rows[i]["spy_UnitName"].ToString();
                lstSupply[i].name = DS.Tables[0].Rows[i]["spy_name"].ToString();
                lstSupply[i].code = DS.Tables[0].Rows[i]["spy_code"].ToString();
                lstSupply[i].note = DS.Tables[0].Rows[i]["spy_note"].ToString();
                lstSupply[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["spy_createdDate"]);
                lstSupply[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["spy_modifiedDate"]);
                lstSupply[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["spy_createdBy"]);
                lstSupply[i].creatorUser = DS.Tables[0].Rows[i]["spy_creatorUser"].ToString();
                lstSupply[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["spy_modifiedBy"]);
                lstSupply[i].modificatorUser = DS.Tables[0].Rows[i]["spy_modificatorUser"].ToString();

            }

            return lstSupply;
        }



        public override string ToString()
        {
            return this.name;
        }
    }
}
