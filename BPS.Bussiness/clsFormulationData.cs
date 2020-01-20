using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsFormulationData : clsMyHerency
    {
        public clsFormulationData()
        {
            codsec = 0;
            fkFormulation = 0;
            fkProductionOrder = 0;
            liable = string.Empty;
            tratiment = string.Empty;
            transform = string.Empty;
            power = string.Empty;
            notes = string.Empty;
            createdDate = DateTime.Now;
            modifiedDate = DateTime.Now;
            createdBy = 0;
            modifiedBy = 0;
        }

        public clsFormulationData(int codsec)
        {
            this.load(codsec);
        }

        public clsFormulationData(int codsec, string source)
        {
            if (source == "Check")
                this.loader(codsec);
        }

        private void loader(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_formulationdata WHERE for_fkProductionOrder = " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["for_codsec"]);
                this.fkFormulation = Convert.ToInt32(DS.Tables[0].Rows[0]["for_fkFormulation"]);
                this.objFormulation = new clsFormulation(fkFormulation, "erwin");
                this.fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["for_fkProductionOrder"]);
                this.objFilmProductionPlan = new clsFilmProductionPlan();
                objFilmProductionPlan = clsFilmProductionPlan.getFilmProductionPlanByProductionOrder(fkProductionOrder);
                this.liable = DS.Tables[0].Rows[0]["for_liable"].ToString();
                this.tratiment = DS.Tables[0].Rows[0]["for_trataiment"].ToString();
                this.transform = DS.Tables[0].Rows[0]["for_transform"].ToString();
                this.power = DS.Tables[0].Rows[0]["for_power"].ToString();
                this.notes = DS.Tables[0].Rows[0]["for_notes"].ToString();
                this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["for_createdDate"]);
                this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["for_modifiedDate"]);
            }
        }

        public void load(int codsec)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT for_codsec, for_gramage FROM bps_prod_formulationreport WHERE for_fkproductionorder = " + codsec.ToString());

            //this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["for_codsec"]);
            //this.fkproductionorder = Convert.ToInt32(DS.Tables[0].Rows[0]["for_codsec"]);
            //this.treatment = DS.Tables[0].Rows[0]["for_description"].ToString();
            //this.speedmachine = Convert.ToInt32(DS.Tables[0].Rows[0]["for_fkBopp"]);
            //this.gramage = Convert.ToDouble(DS.Tables[0].Rows[0]["for_gramage"]);
            //this.kilogramperhour = DS.Tables[0].Rows[0]["for_BoppName"].ToString();
            //this.lotnumber = Convert.ToInt32(DS.Tables[0].Rows[0]["for_fkCast"]);
            //this.machine = DS.Tables[0].Rows[0]["for_CastCode"].ToString();
            //this.film = DS.Tables[0].Rows[0]["for_CastName"].ToString();
            //this.notes = Convert.ToDouble(DS.Tables[0].Rows[0]["for_thick"]);
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_formulationdata (for_fkFormulation, for_fkProductionOrder, for_liable, for_trataiment, for_transform, for_power, for_notes, for_createdDate, for_modifiedDate, for_createdBy, for_modifiedBy)";
                    queryString += " VALUES (";
                    queryString += this.fkFormulation.ToString() + ",";
                    queryString += this.fkProductionOrder.ToString() + ",";
                    queryString += "'" + this.liable.ToString() + "',";
                    queryString += "'" + this.tratiment.ToString() + "',";
                    queryString += "'" + this.transform.ToString() + "',";
                    queryString += "'" + this.power.ToString() + "',";
                    queryString += "'" + this.notes.ToString() + "',";
                    queryString += "'" + this.createdDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += clsGlobal.LoggedUser.codsec.ToString() + ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_formulationdata";
                    queryString += " SET ";
                    queryString += "for_fkFormulation = " + this.fkFormulation + ",";
                    queryString += "for_fkProductionOrder = " + this.fkProductionOrder + ",";
                    queryString += "for_liable = '" + this.liable.ToString() + "',";
                    queryString += "for_trataiment = '" + this.tratiment.ToString() + "',";
                    queryString += "for_transform = '" + this.transform.ToString() + "',";
                    queryString += "for_power = '" + this.power.ToString() + "',";
                    queryString += "for_notes = '" + this.notes + "',";
                    queryString += "for_createdDate = '" + this.createdDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += "for_modifiedDate = '"+DateTime.Now.ToString("dd/MM/yyyy HH:mm") +"',";
                    queryString += "for_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + "";
                    queryString += " WHERE for_codsec = " + this.codsec.ToString() + ";";
                }
                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsFormulationReport.save");
                return false;
            }
        }
    }
}
