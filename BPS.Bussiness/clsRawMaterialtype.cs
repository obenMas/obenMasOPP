using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra los tipos de Materias Primas (Homopolimero,Copolimero,etc)
    /// </summary>
    public class clsRawMaterialtype
    {
        //Atributes

        private int trwm_codsec;
        private string trwm_name;
        private DateTime trwm_createdDate;
        private DateTime trwm_modifiedDate;
        private int trwm_createdBy;
        private string trwm_creatorUser;
        private int trwm_modifiedBy;
        private string trwm_modificatorUser;


        //Properties

        public int codsec { get { return trwm_codsec; } set { trwm_codsec = value; } }

        public string name { get { return trwm_name; } set { trwm_name = value; } }

        public DateTime createdDate { get { return trwm_createdDate; } set { trwm_createdDate = value; } }

        public DateTime modifiedDate { get { return trwm_modifiedDate; } set { trwm_modifiedDate = value; } }

        public int createdBy { get { return trwm_createdBy; } set { trwm_createdBy = value; } }

        public string creatorUser { get { return trwm_creatorUser; } set { trwm_creatorUser = value; } }

        public int modifiedBy { get { return trwm_modifiedBy; } set { trwm_modifiedBy = value; } }

        public string modificatorUser { get { return trwm_modificatorUser; } set { trwm_modificatorUser = value; } }

        
        //Constructor

        public clsRawMaterialtype()
        { 
        trwm_codsec = 0;
        trwm_name = "";
        trwm_createdDate = DateTime.Now;
        trwm_modifiedDate = DateTime.Now;
        trwm_createdBy = 0;
        trwm_creatorUser = "";
        trwm_modifiedBy = 0;
        trwm_modificatorUser = "";


        }
        public clsRawMaterialtype(int codsec)
        {
            this.load(codsec);
        }

        //Methods
        
        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwRawMaterialType where trwm_codsec =  " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["trwm_codsec"]);
            this.name = DS.Tables[0].Rows[0]["trwm_name"].ToString();
            this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["trwm_createdDate"]);
            this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["trwm_modifiedDate"]);
            this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["trwm_createdBy"]);
            this.creatorUser = DS.Tables[0].Rows[0]["trwm_creatorUser"].ToString();
            this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["trwm_modifiedBy"]);
            this.modificatorUser = DS.Tables[0].Rows[0]["trwm_modificatorUser"].ToString();
            
        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_rawmaterialtype (trwm_name,trwm_createdDate,trwm_modifiedDate,trwm_createdBy,trwm_modifiedBy)";
                    queryString += " VALUES (";
                    queryString += "'" + this.name + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += clsGlobal.LoggedUser.codsec.ToString();
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_prod_rawmaterialtype";
                    queryString += " SET ";
                    queryString += "trwm_name = '" + this.name.ToString() + "',";
                    queryString += "trwm_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "trwm_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString();
                    queryString += " WHERE trwm_codsec = " + this.codsec.ToString() + ";";
                    clsConnection.executeQuery(queryString);
                }
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsRawMaterialtype.save");
                return false;
            }
        }
        public static List<clsRawMaterialtype> getList()
        {
            List<clsRawMaterialtype> lstRawMaterialtype = new List<clsRawMaterialtype>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwRawMaterialType order by trwm_codsec asc");

            lstRawMaterialtype.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstRawMaterialtype.Add(new clsRawMaterialtype());
                lstRawMaterialtype[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["trwm_codsec"]);
                lstRawMaterialtype[i].name = DS.Tables[0].Rows[i]["trwm_name"].ToString();
                lstRawMaterialtype[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["trwm_createdDate"]);
                lstRawMaterialtype[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["trwm_modifiedDate"]);
                lstRawMaterialtype[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["trwm_createdBy"]);
                lstRawMaterialtype[i].creatorUser = DS.Tables[0].Rows[i]["trwm_creatorUser"].ToString();
                lstRawMaterialtype[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["trwm_modifiedBy"]);
                lstRawMaterialtype[i].modificatorUser = DS.Tables[0].Rows[i]["trwm_modificatorUser"].ToString();
            
            }

            return lstRawMaterialtype;
        }


       


        public int getLastSavedCodsec()
        {
            DataSet DS = new DataSet();
            DataSet DSUser = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwRawMaterialType ORDER BY trwm_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["trwm_codsec"]);

        }
        public override string ToString()
        {
            return this.name;
        }
       
    }
}
