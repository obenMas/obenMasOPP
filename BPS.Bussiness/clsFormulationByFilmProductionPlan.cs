using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra las formulaciones por planes de producción.
    /// </summary>
    public class clsFormulationByFilmProductionPlan
    {
        //Atrubutes
        private int fpfpp_codsec;
        private int fpfpp_fkFilmProductionPlan;
        private int fpfpp_fkProductionOrder;
        private string fpfpp_lotNumber;
        private int fpfpp_fkFormulation;
        private string fpfpp_formulationName;
        private DateTime fpfpp_createdDate;
        private int fpfpp_createdBy;
        private string fpfpp_userCreator;
        private bool fpfpp_isActive;


        //Properties
        public int codsec { get { return fpfpp_codsec; } set { fpfpp_codsec = value; } }

        public int fkFilmProductionPlan { get { return fpfpp_fkFilmProductionPlan; } set { fpfpp_fkFilmProductionPlan = value; } }

        public int fkProductionOrder { get { return fpfpp_fkProductionOrder; } set { fpfpp_fkProductionOrder = value; } }

        public string lotNumber { get { return fpfpp_lotNumber; } set { fpfpp_lotNumber = value; } }

        public int fkFormulation { get { return fpfpp_fkFormulation; } set { fpfpp_fkFormulation = value; } }

        public string formulationName { get { return fpfpp_formulationName; } set { fpfpp_formulationName = value; } }

        public DateTime createdDate { get { return fpfpp_createdDate; } set { fpfpp_createdDate = value; } }

        public int createdBy { get { return fpfpp_createdBy; } set { fpfpp_createdBy = value; } }

        public string userCreator { get { return fpfpp_userCreator; } set { fpfpp_userCreator = value; } }

        public bool isActive { get { return fpfpp_isActive; } set { fpfpp_isActive = value; } }

        //Constructor
        public clsFormulationByFilmProductionPlan()
        {
            this.fpfpp_codsec = 0;
            this.fpfpp_fkFilmProductionPlan = 0;
            this.fpfpp_fkProductionOrder = 0;
            this.fpfpp_lotNumber = "";
            this.fpfpp_fkFormulation = 0;
            this.fpfpp_formulationName = "";
            this.fpfpp_createdDate = DateTime.Now;
            this.fpfpp_createdBy = 1;
            this.userCreator = "";
            this.isActive = false;
        }

        //Methods
        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwFormulationByFilmProductionPlan where fpfpp_codsec = " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["fpfpp_codsec"]);
                this.fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[0]["fpfpp_fkFilmProductionPlan"]);
                this.fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["fpfpp_fkProductionOrder"]);
                this.lotNumber = DS.Tables[0].Rows[0]["fpfpp_lotNumber"].ToString();
                this.fkFormulation = Convert.ToInt32(DS.Tables[0].Rows[0]["fpfpp_fkFormulation"]);
                this.formulationName = DS.Tables[0].Rows[0]["fpfpp_formulationName"].ToString();
                this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["fpfpp_createdDate"]);
                this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["fpfpp_createdBy"]);
                this.userCreator = DS.Tables[0].Rows[0]["fpfpp_userCreator"].ToString();
                this.isActive = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["fpfpp_isActive"], DS.Tables[0].Rows[0]["fpfpp_isActive"].GetType().FullName);
            }

        }
        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO `bps_prod_formulationperfilmproductionplan` ( `fpfpp_fkFilmProductionPlan`, `fpfpp_fkFormulation`, `fpfpp_createdDate`, `fpfpp_createdBy`, `fpfpp_isActive`) ";
                    queryString += " VALUES (";
                    queryString += "" + this.fkFilmProductionPlan.ToString() + ",";
                    queryString += "" + this.fkFormulation.ToString() + ",";
                    queryString += "'" + this.createdDate.ToString("dd/MM/yyyy HH:mm:ss") + "',";
                    queryString += "" + this.createdBy.ToString() + ",";
                    queryString += "" + this.isActive.ToString() + "";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE `bps_prod_formulationperfilmproductionplan`";
                    queryString += " SET ";
                    queryString += " fpfpp_fkFilmProductionPlan = " + this.fkFilmProductionPlan.ToString() + ",";
                    queryString += " fpfpp_fkFormulation = " + this.fkFormulation.ToString() + ",";
                    queryString += " fpfpp_createdDate = '" + this.createdDate.ToString() + "',";
                    queryString += " fpfpp_createdBy = " + this.createdBy.ToString() + ",";
                    queryString += " fpfpp_isActive = '" + this.isActive.ToString() + "'";
                    queryString += " WHERE fpfpp_codsec = " + this.codsec.ToString() + ";";
                }
                clsConnection.executeQuery(queryString);
                return true;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsProduct.save");
                return false;
            }
        }

        public static List<clsFormulationByFilmProductionPlan> getListByFilmProductionPlan(int filmProductionPlanCodsec)
        {
            List<clsFormulationByFilmProductionPlan> lstFormulationByFilmProductionPlan = new List<clsFormulationByFilmProductionPlan>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwFormulationByFilmProductionPlan WHERE fpfpp_fkFilmProductionPlan = " + filmProductionPlanCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstFormulationByFilmProductionPlan.Add(new clsFormulationByFilmProductionPlan());
                    lstFormulationByFilmProductionPlan[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["fpfpp_codsec"]);
                    lstFormulationByFilmProductionPlan[i].fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[i]["fpfpp_fkFilmProductionPlan"]);
                    lstFormulationByFilmProductionPlan[i].fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["fpfpp_fkProductionOrder"]);
                    lstFormulationByFilmProductionPlan[i].lotNumber = DS.Tables[0].Rows[i]["fpfpp_lotNumber"].ToString();
                    lstFormulationByFilmProductionPlan[i].fkFormulation = Convert.ToInt32(DS.Tables[0].Rows[i]["fpfpp_fkFormulation"]);
                    lstFormulationByFilmProductionPlan[i].formulationName = DS.Tables[0].Rows[i]["fpfpp_formulationName"].ToString();
                    lstFormulationByFilmProductionPlan[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpfpp_createdDate"]);
                    lstFormulationByFilmProductionPlan[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["fpfpp_createdBy"]);
                    lstFormulationByFilmProductionPlan[i].userCreator = DS.Tables[0].Rows[i]["fpfpp_userCreator"].ToString();
                    lstFormulationByFilmProductionPlan[i].isActive = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["fpfpp_isActive"], DS.Tables[0].Rows[i]["fpfpp_isActive"].GetType().FullName);
                }
            }
            return lstFormulationByFilmProductionPlan;
        }

        public static clsFormulationByFilmProductionPlan getActiveFormulationByFilmProductionPlan(int filmProductionPlanCodsec)
        {
            clsFormulationByFilmProductionPlan objFormulationByFilmProductionPlan = new clsFormulationByFilmProductionPlan();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwFormulationByFilmProductionPlan where fpfpp_fkFilmProductionPlan = " + filmProductionPlanCodsec.ToString() + " and fpfpp_isActive = 1");

            if (DS.Tables[0].Rows.Count > 0)
            {
                objFormulationByFilmProductionPlan.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["fpfpp_codsec"]);
                objFormulationByFilmProductionPlan.fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[0]["fpfpp_fkFilmProductionPlan"]);
                objFormulationByFilmProductionPlan.fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["fpfpp_fkProductionOrder"]);
                objFormulationByFilmProductionPlan.lotNumber = DS.Tables[0].Rows[0]["fpfpp_lotNumber"].ToString();
                objFormulationByFilmProductionPlan.fkFormulation = Convert.ToInt32(DS.Tables[0].Rows[0]["fpfpp_fkFormulation"]);
                objFormulationByFilmProductionPlan.formulationName = DS.Tables[0].Rows[0]["fpfpp_formulationName"].ToString();
                objFormulationByFilmProductionPlan.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["fpfpp_createdDate"]);
                objFormulationByFilmProductionPlan.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["fpfpp_createdBy"]);
                objFormulationByFilmProductionPlan.userCreator = DS.Tables[0].Rows[0]["fpfpp_userCreator"].ToString();
                objFormulationByFilmProductionPlan.isActive = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["fpfpp_isActive"], DS.Tables[0].Rows[0]["fpfpp_isActive"].GetType().FullName);
            }
            return objFormulationByFilmProductionPlan;
        }

        public static List<clsFormulationByFilmProductionPlan> getActiveFormulationByFilmProductionPlanList(int filmProductionPlanCodsec)
        {
            List<clsFormulationByFilmProductionPlan> lstFormulationByFilmProductionPlan = new List<clsFormulationByFilmProductionPlan>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwFormulationByFilmProductionPlan where fpfpp_fkFilmProductionPlan = " + filmProductionPlanCodsec.ToString() + " and fpfpp_isActive = 1");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstFormulationByFilmProductionPlan.Add(new clsFormulationByFilmProductionPlan());
                    lstFormulationByFilmProductionPlan[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["fpfpp_codsec"]);
                    lstFormulationByFilmProductionPlan[i].fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[0]["fpfpp_fkFilmProductionPlan"]);
                    lstFormulationByFilmProductionPlan[i].fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["fpfpp_fkProductionOrder"]);
                    lstFormulationByFilmProductionPlan[i].lotNumber = DS.Tables[0].Rows[0]["fpfpp_lotNumber"].ToString();
                    lstFormulationByFilmProductionPlan[i].fkFormulation = Convert.ToInt32(DS.Tables[0].Rows[0]["fpfpp_fkFormulation"]);
                    lstFormulationByFilmProductionPlan[i].formulationName = DS.Tables[0].Rows[0]["fpfpp_formulationName"].ToString();
                    lstFormulationByFilmProductionPlan[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["fpfpp_createdDate"]);
                    lstFormulationByFilmProductionPlan[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["fpfpp_createdBy"]);
                    lstFormulationByFilmProductionPlan[i].userCreator = DS.Tables[0].Rows[0]["fpfpp_userCreator"].ToString();
                    lstFormulationByFilmProductionPlan[i].isActive = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["fpfpp_isActive"], DS.Tables[0].Rows[0]["fpfpp_isActive"].GetType().FullName);
                }
            }
            return lstFormulationByFilmProductionPlan;
        }

        public static List<clsFormulationByFilmProductionPlan> getListByProductionOrder(int ProductionOrderCodsec)
        {
            List<clsFormulationByFilmProductionPlan> lstProductionOrder = new List<clsFormulationByFilmProductionPlan>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwFormulationByFilmProductionPlan where fpfpp_fkProductionOrder = " + ProductionOrderCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstProductionOrder.Add(new clsFormulationByFilmProductionPlan());
                    lstProductionOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["fpfpp_codsec"]);
                    lstProductionOrder[i].fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[i]["fpfpp_fkFilmProductionPlan"]);
                    lstProductionOrder[i].fkProductionOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["fpfpp_fkProductionOrder"]);
                    lstProductionOrder[i].lotNumber = DS.Tables[0].Rows[i]["fpfpp_lotNumber"].ToString();
                    lstProductionOrder[i].fkFormulation = Convert.ToInt32(DS.Tables[0].Rows[i]["fpfpp_fkFormulation"]);
                    lstProductionOrder[i].formulationName = DS.Tables[0].Rows[i]["fpfpp_formulationName"].ToString();
                    lstProductionOrder[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["fpfpp_createdDate"]);
                    lstProductionOrder[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["fpfpp_createdBy"]);
                    lstProductionOrder[i].userCreator = DS.Tables[0].Rows[i]["fpfpp_userCreator"].ToString();
                    lstProductionOrder[i].isActive = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["fpfpp_isActive"], DS.Tables[0].Rows[i]["fpfpp_isActive"].GetType().FullName);
                }
            }
            return lstProductionOrder;
        }

        public static bool insert(int fkfilmproductionplan, int fkformulation)
        {
            string queryString = "";
            queryString += "INSERT INTO `bps_prod_formulationperfilmproductionplan` ( `fpfpp_fkFilmProductionPlan`, `fpfpp_fkFormulation`, `fpfpp_createdDate`, `fpfpp_createdBy`, `fpfpp_isActive`) ";
            queryString += " VALUES (";
            queryString += "" + fkfilmproductionplan.ToString() + ",";
            queryString += "" + fkformulation.ToString() + ",";
            queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
            queryString += "" + clsGlobal.LoggedUser.codsec.ToString() + ",";
            queryString += "1";
            queryString += ");";

            return clsConnection.executeQuery(queryString);
        }


        #region Film Production Plan Reaload

        public static List<clsFormulationByFilmProductionPlan> getListFilmProductionPlanReload(int filmProductionPlanCodsec)
        {
            List<clsFormulationByFilmProductionPlan> filmList = new List<clsFormulationByFilmProductionPlan>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spFormulationMultiple 'formulation',''," + filmProductionPlanCodsec + ",'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    filmList.Add(new clsFormulationByFilmProductionPlan());
                    filmList[i].fkFormulation = Convert.ToInt32(DS.Tables[0].Rows[i]["frml_codsec"]);
                    filmList[i].formulationName = DS.Tables[0].Rows[i]["frml_name"].ToString();
                }
            }
            return filmList;
        }

        #endregion
    }
}
