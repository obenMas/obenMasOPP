using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace BPS.Bussiness
{
    public class clsNewExtrusionPlan
    {
        private int nep_codsec;
        private int neo_fkMachine;
        private DateTime nep_initDate;
        private string nep_observations;
        private bool nep_active;
        private int nep_velocity;
        private double nep_efficiency;
        private double nep_availability;

        //Properties

        public int codsec { get { return nep_codsec; } set { nep_codsec = value; } }

        public int fkMachine { get { return neo_fkMachine; } set { neo_fkMachine = value; } }

        public DateTime initDate { get { return nep_initDate; } set { nep_initDate = value; } }

        public string observations { get { return nep_observations; } set { nep_observations = value; } }

        public bool active { get { return nep_active; } set { nep_active = value; } }

        public int velocity { get { return nep_velocity; } set { nep_velocity = value; } }

        public double efficiency { get { return nep_efficiency; } set { nep_efficiency = value; } }

        public double availability { get { return nep_availability; } set { nep_availability = value; } }
        //Constructor

        public clsNewExtrusionPlan()
        {
            codsec = 0;
            fkMachine = 0;
            observations = "";
            initDate = DateTime.Parse("01/01/1900");
            active = false;
            velocity = 0;
            efficiency = 0;
            availability = 0;
        }

        public clsNewExtrusionPlan(int cod)
        {
            this.load(cod);
        }

        //Methods

        public void load(int cod)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_new_extrusionPlan where nep_codsec = " + cod.ToString());

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["nep_codsec"]);
                this.fkMachine = Convert.ToInt32(DS.Tables[0].Rows[0]["nep_fkMachine"]);
                this.initDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["nep_initDate"]);
                this.observations = DS.Tables[0].Rows[0]["nep_observations"].ToString();
                this.active = Convert.ToBoolean(DS.Tables[0].Rows[0]["nep_active"]);
                this.velocity = Convert.ToInt32(DS.Tables[0].Rows[0]["nep_velocity"]);
                this.efficiency = Convert.ToDouble(DS.Tables[0].Rows[0]["nep_efficiency"]);
                this.availability = Convert.ToDouble(DS.Tables[0].Rows[0]["nep_availability"]);
            }
        }

        public bool save()
        {
            try
            {

                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_new_extrusionPlan (nep_fkMachine, nep_initDate, nep_observations, nep_active, nep_velocity, nep_efficiency, nep_availability)";
                    queryString += " VALUES (";
                    queryString += this.fkMachine + ", ";
                    queryString += "'" + this.initDate.ToString() + "', ";
                    queryString += "'" + this.observations + "', ";
                    if(this.active)
                    {
                        queryString += "1, ";
                    }
                    else
                    {
                        queryString += "0, ";
                    }
                    queryString += this.velocity + ", ";
                    queryString += this.efficiency + ", ";
                    queryString += this.availability + " ";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                    this.codsec = clsNewExtrusionPlan.getLastSavedCodsec();
                }
                else
                {
                    queryString += "UPDATE bps_new_extrusionPlan";
                    queryString += " SET ";
                    queryString += "nep_fkMachine = " + this.fkMachine + ", ";
                    queryString += "nep_initDate = '" + this.initDate.ToString() + "', ";
                    queryString += "nep_observations = '" + this.observations + "', ";
                    if(this.active)
                    {
                        queryString += "nep_active = 1,";
                    }
                    else
                    {
                        queryString += "nep_active = 0,";
                    }
                    queryString += "nep_velocity = " + this.velocity + ", ";
                    queryString += "nep_efficiency = " + this.efficiency + ", ";
                    queryString += "nep_availability = " + this.availability + " ";
                    queryString += " WHERE nep_codsec = " + this.codsec.ToString() + ";";
                    clsConnection.executeQuery(queryString);

                }
                return true;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsNewExtrusionPlan.save");
                return false;
            }
        }

        public static int getLastSavedCodsec()
        {
            
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT MAX(nep_codsec) FROM bps_new_extrusionPlan");

            int cod = 0;

            if(DS.Tables.Count>0 && DS.Tables[0].Rows.Count>0)
            {
                cod = Convert.ToInt32(DS.Tables[0].Rows[0][0]);
            }

            return cod;
        }

        public static clsNewExtrusionPlan getActivePlan(int machine)
        {
            clsNewExtrusionPlan plan = new clsNewExtrusionPlan();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_new_extrusionPlan where nep_active = 1 AND nep_fkMachine="+machine.ToString());

            if (DS.Tables.Count>0 && DS.Tables[0].Rows.Count > 0)
            {
                plan.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["nep_codsec"]);
                plan.fkMachine = Convert.ToInt32(DS.Tables[0].Rows[0]["nep_fkMachine"]);
                plan.initDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["nep_initDate"]);
                plan.observations = DS.Tables[0].Rows[0]["nep_observations"].ToString();
                plan.active = Convert.ToBoolean(DS.Tables[0].Rows[0]["nep_active"]);
                plan.velocity = Convert.ToInt32(DS.Tables[0].Rows[0]["nep_velocity"]);
                plan.efficiency = Convert.ToDouble(DS.Tables[0].Rows[0]["nep_efficiency"]);
                plan.availability = Convert.ToDouble(DS.Tables[0].Rows[0]["nep_availability"]);
            }

            return plan;
        }

        public bool setAsNonActive()
        {
            this.active = false;
            return this.save();
        }

        public bool setAsActive()
        {
            DataSet DS = new DataSet();
            clsNewExtrusionPlan extplan = new clsNewExtrusionPlan();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_new_extrusionPlan where nep_active = 1 AND nep_fkMachine=" + this.fkMachine.ToString());

            if(DS.Tables.Count>0 && DS.Tables[0].Rows.Count>0)
            {
                extplan = new clsNewExtrusionPlan(Convert.ToInt32(DS.Tables[0].Rows[0][0]));
                if(!extplan.setAsNonActive())
                {
                    MessageBox.Show("Ocurrio un error, no se pudo modificar el plan activo.","Error al activar plan",MessageBoxButtons.OK);
                    return false;
                }
            }

            this.active = true;
            return this.save();
        }
    }
}
