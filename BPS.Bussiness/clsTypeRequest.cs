using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsTypeRequest : clsMyHerency
    {
        public clsTypeRequest()
        {
            codsec = 0;
            source = string.Empty;
            name = string.Empty;
            id = string.Empty;
            description = string.Empty;
        }

        public static List<clsTypeRequest> getListPriority()
        {
            try
            {
                List<clsTypeRequest> lstTypeRequets = new List<clsTypeRequest>();
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_typerequest WHERE treq_source = 'Prioridad'");
                if (DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        lstTypeRequets.Add(new clsTypeRequest());
                        lstTypeRequets[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["treq_codsec"].ToString());
                        lstTypeRequets[i].source = DS.Tables[0].Rows[i]["treq_source"].ToString();
                        lstTypeRequets[i].name = DS.Tables[0].Rows[i]["treq_name"].ToString();
                        lstTypeRequets[i].id = DS.Tables[0].Rows[i]["treq_id"].ToString();
                        lstTypeRequets[i].description = DS.Tables[0].Rows[i]["treq_description"].ToString();
                    }
                    return lstTypeRequets;
                }
                else
                    return lstTypeRequets;
            }
            catch (Exception)
            {
                List<clsTypeRequest> lstTypeRequets = new List<clsTypeRequest>();
                return lstTypeRequets;
            }
        }

        public static List<clsTypeRequest> getListUserRequest()
        {
            try
            {
                List<clsTypeRequest> lstTypeRequets = new List<clsTypeRequest>();
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_typerequest WHERE treq_source = 'Usuarios'");
                if (DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        lstTypeRequets.Add(new clsTypeRequest());
                        lstTypeRequets[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["treq_codsec"].ToString());
                        lstTypeRequets[i].source = DS.Tables[0].Rows[i]["treq_source"].ToString();
                        lstTypeRequets[i].name = DS.Tables[0].Rows[i]["treq_name"].ToString();
                        lstTypeRequets[i].id = DS.Tables[0].Rows[i]["treq_id"].ToString();
                        lstTypeRequets[i].description = DS.Tables[0].Rows[i]["treq_description"].ToString();
                    }
                    return lstTypeRequets;
                }
                else
                    return lstTypeRequets;
            }
            catch (Exception)
            {
                List<clsTypeRequest> lstTypeRequets = new List<clsTypeRequest>();
                return lstTypeRequets;
            }
        }

        public override string ToString()
        {
            return this.name + "[ " + this.id + " ]";
        }
    }
}
