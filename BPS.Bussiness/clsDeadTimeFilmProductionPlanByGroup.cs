using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using System.Data;

namespace BPS.Bussiness
{
    public class clsDeadTimeFilmProductionPlanByGroup
    {
        //Atributes
        private string dtg_Name;
        private string dtg_abbreviation;
        private DateTime dtbfpp_initDate;
        private DateTime dtbfpp_endDate;
        private int dtg_codsec;
        private int dtbfpp_fkFilmProductionPlan;

        //Properties
        public string Name { get { return dtg_Name; } set { dtg_Name = value; } }

        public string Abbreviation { get { return dtg_abbreviation; } set { dtg_abbreviation = value; } }

        public DateTime initDate { get { return dtbfpp_initDate; } set { dtbfpp_initDate = value; } }

        public DateTime endDate { get { return dtbfpp_endDate; } set { dtbfpp_endDate = value; } }

        public int Codsec { get { return dtg_codsec; } set { dtg_codsec = value; } }

        public int fkFilmProductionPlan { get { return dtbfpp_fkFilmProductionPlan; } set { dtbfpp_fkFilmProductionPlan = value; } }

        //Constructor

        public clsDeadTimeFilmProductionPlanByGroup()
        {
            dtg_Name = "";
            dtg_abbreviation = "";
            dtbfpp_initDate = DateTime.Now;
            dtbfpp_endDate = DateTime.Now;
            dtg_codsec = 0;
            dtbfpp_fkFilmProductionPlan = 0;
        }

        //Methods

        public static List<clsDeadTimeFilmProductionPlanByGroup> getListByFilmProductionPlan(int FilmProductionPlanCodsec)
        {
            List<clsDeadTimeFilmProductionPlanByGroup> lstDeadTimeByFilmProductionPlanByGroup = new List<clsDeadTimeFilmProductionPlanByGroup>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwdeadtimebyfilmproductionplanbydeadtimegroup where dtbfpp_fkFilmProductionPlan = " + FilmProductionPlanCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstDeadTimeByFilmProductionPlanByGroup.Add(new clsDeadTimeFilmProductionPlanByGroup());
                    lstDeadTimeByFilmProductionPlanByGroup[i].Name = DS.Tables[0].Rows[i]["dtg_Name"].ToString();
                    lstDeadTimeByFilmProductionPlanByGroup[i].Abbreviation = DS.Tables[0].Rows[i]["dtg_abbreviation"].ToString();
                    lstDeadTimeByFilmProductionPlanByGroup[i].dtbfpp_initDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["dtbfpp_initDate"]);
                    lstDeadTimeByFilmProductionPlanByGroup[i].dtbfpp_endDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["dtbfpp_endDate"]);
                    lstDeadTimeByFilmProductionPlanByGroup[i].Codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["dtg_codsec"].ToString());
                    lstDeadTimeByFilmProductionPlanByGroup[i].fkFilmProductionPlan = Convert.ToInt32(DS.Tables[0].Rows[i]["dtbfpp_fkFilmProductionPlan"].ToString());
                }
            }
            return lstDeadTimeByFilmProductionPlanByGroup;
        }
    }
}
