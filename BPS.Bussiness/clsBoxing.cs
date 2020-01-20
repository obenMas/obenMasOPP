using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra la clase de contenedores
    /// </summary>
    public class clsBoxing
    {
        //Atributes

        private int trans_codsec;
        private string trans_name;
        private string trans_code;
        private int trans_coil;
        private int trans_createdBy;
        private int trans_modifiedBy;
        private DateTime trans_createdDate;
        private DateTime trans_modifiedDate;
        private int trans_isVisible;

        private int trsc_parameter;

        public int parameter
        {
            get { return trsc_parameter; }
            set { trsc_parameter = value; }
        }


        //Properties


        public int codsec { get { return trans_codsec; } set { trans_codsec = value; } }

        public string name { get { return trans_name; } set { trans_name = value; } }

        public string code { get { return trans_code; } set { trans_code = value; } }

        public int coil { get { return trans_coil; } set { trans_coil = value; } }

        public int createdBy { get { return trans_createdBy; } set { trans_createdBy = value; } }

        public int modifiedBy { get { return trans_modifiedBy; } set { trans_modifiedBy = value; } }

        public DateTime createdDate { get { return trans_createdDate; } set { trans_createdDate = value; } }

        public DateTime modifiedDate { get { return trans_modifiedDate; } set { trans_modifiedDate = value; } }

        public int isVisible { get { return trans_isVisible; } set { trans_isVisible = value; } }

         //Constructor

        public clsBoxing()
        {
            trans_codsec = 0;
            trans_name = "";
            trans_code = "";
            trans_coil = 0;
            trans_createdBy = 0;
            trans_modifiedBy = 0;
            trans_createdDate = DateTime.Now;
            trans_modifiedDate = DateTime.Now;
            trans_isVisible = 1;
        }

        public clsBoxing(int codsec)
        {
            this.load(codsec);
        }

        //Methods
        public void load(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_transportcub WHERE trsc_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["trsc_codsec"]);
            this.name = DS.Tables[0].Rows[0]["trsc_name"].ToString();
            this.code = DS.Tables[0].Rows[0]["trsc_code"].ToString();
            this.coil = Convert.ToInt32(DS.Tables[0].Rows[0]["trsc_coil"]);
            this.parameter = Convert.ToInt32(DS.Tables[0].Rows[0]["trsc_parameter"]);
            this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["trsc_createdBy"]);
            this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["trsc_modifiedBy"]);
            this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["trsc_createdDate"]);
            this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["trsc_modifiedDate"]);
            this.isVisible = Convert.ToInt32(DS.Tables[0].Rows[0]["trsc_isVisible"]);
        }

        public bool save()
        {
            try
            {

                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_admin_transportcub (trsc_name, trsc_code, trsc_parameter, trsc_coil, trsc_createdBy, trsc_modifiedBy, trsc_createdDate, trsc_modifiedDate, trsc_isVisible) ";
                    queryString += "VALUES (";
                    queryString += "'" + this.name + "',";
                    queryString += "'" + this.code + "',";
                    queryString += "" + this.parameter.ToString() + ",";
                    queryString += "" + this.coil.ToString()+ ",";
                    queryString += "" + clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += "" + clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += "NOW(),";
                    queryString += "NOW(),";
                    queryString += "" + this.isVisible.ToString() + "";
                    queryString += ");";

                }
                else
                {
                    queryString += "UPDATE bps_admin_transportcub";
                    queryString += " SET ";
                    queryString += "trsc_name = '" + this.name + "',";
                    queryString += "trsc_code = '" + this.code + "',";
                    queryString += "trsc_parameter = " + this.parameter.ToString() + ",";
                    queryString += "trsc_coil = " + this.coil.ToString() + ",";
                    queryString += "trsc_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += "trsc_modifiedDate = NOW()";
                    queryString += " WHERE trsc_codsec = " + this.codsec.ToString() + ";";

                }
                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsBoxing.save");
                return false;
            }
        }
        
        public static List<clsBoxing> getListIsVisible()
        {
            List<clsBoxing> lstTransport = new List<clsBoxing>();

            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_transportcub WHERE trsc_isVisible = 1 ORDER BY trsc_code");

            lstTransport.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstTransport.Add(new clsBoxing());
                lstTransport[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["trsc_codsec"]);
                lstTransport[i].name = DS.Tables[0].Rows[i]["trsc_name"].ToString();
                lstTransport[i].code = DS.Tables[0].Rows[i]["trsc_code"].ToString();
                lstTransport[i].parameter = Convert.ToInt32(DS.Tables[0].Rows[i]["trsc_parameter"]);
                lstTransport[i].coil = Convert.ToInt32(DS.Tables[0].Rows[i]["trsc_coil"]);
                lstTransport[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["trsc_createdBy"]);
                lstTransport[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["trsc_modifiedBy"]);
                lstTransport[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["trsc_createdDate"]);
                lstTransport[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["trsc_modifiedDate"]);
                lstTransport[i].isVisible = Convert.ToInt32(DS.Tables[0].Rows[i]["trsc_isVisible"]);
            }

            return lstTransport;
        }

        public override string ToString()
        {
            return this.code + " [" + this.name + " ]";
        }

        public static bool toCrossTransport(int codsecTransport)
        {
            try
            {

                string queryString = "";

                queryString += "UPDATE bps_admin_transportcub";
                queryString += " SET ";
                queryString += "trsc_isVisible = 0";
                queryString += " WHERE trsc_codsec = " + codsecTransport.ToString() + ";";

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsBoxing.save");
                return false;
            }
        }

        public static bool isUniqueCode(string code)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_transportcub WHERE trsc_code = '" + code + "'");
            if (DS.Tables[0].Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
