using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase para administrar las rollos madres de termoformado
    /// </summary>
    public class clsTherMainCoil
    {
        //Atributes

        private int thermmc_codsec;
        private int thermmc_fkThermOrderPlan;

        private int thermmc_lenght;
        private int thermmc_lotNumber;
        private int thermmc_width;
        private string thermmc_code;
        private double thermmc_weigth;
        private double thermmc_tickness;
        private DateTime thermmc_initDate;
        private string thermmc_observation;
        private DateTime thermmc_createdDate;
        private DateTime thermmc_modifiedDate;
        private int thermmc_createdBy;
        private int thermmc_modifiedBy;
        private DateTime thermmc_endDate;

        //Properties

        public int codsec { get { return thermmc_codsec; } set { thermmc_codsec = value; } }

        public int fkThermOrderPlan { get { return thermmc_fkThermOrderPlan; } set { thermmc_fkThermOrderPlan = value; } }

        public int lenght { get { return thermmc_lenght; } set { thermmc_lenght = value; } }

        public int lotNumber { get { return thermmc_lotNumber; } set { thermmc_lotNumber = value; } }

        public int width { get { return thermmc_width; } set { thermmc_width = value; } }

        public string code { get { return thermmc_code; } set { thermmc_code = value; } }

        public double weigth { get { return thermmc_weigth; } set { thermmc_weigth = value; } }

        public double tickness { get { return thermmc_tickness; } set { thermmc_tickness = value; } }

        public DateTime initDate { get { return thermmc_initDate; } set { thermmc_initDate = value; } }

        public string observation { get { return thermmc_observation; } set { thermmc_observation = value; } }

        public DateTime createdDate { get { return thermmc_createdDate; } set { thermmc_createdDate = value; } }

        public DateTime modifiedDate { get { return thermmc_modifiedDate; } set { thermmc_modifiedDate = value; } }

        public int createdBy { get { return thermmc_createdBy; } set { thermmc_createdBy = value; } }

        public int modifiedBy { get { return thermmc_modifiedBy; } set { thermmc_modifiedBy = value; } }

        public DateTime endDate { get { return thermmc_endDate; } set { thermmc_endDate = value; } }

        //Constructor

        public clsTherMainCoil()
        {
            thermmc_codsec = 0;
            thermmc_fkThermOrderPlan = 0;
            thermmc_lenght = 0;
            thermmc_lotNumber = 0;
            thermmc_width = 0;
            thermmc_code = "";
            thermmc_weigth = 0;
            thermmc_tickness = 0;
            thermmc_initDate = DateTime.Now;
            thermmc_observation = "";
            thermmc_createdDate = DateTime.Now;
            thermmc_modifiedDate = DateTime.Now;
            thermmc_createdBy = 0;
            thermmc_modifiedBy = 0;
            thermmc_endDate = DateTime.Now;
        }

        public clsTherMainCoil(int codsec)
        {
            //this.load(codsec);
        }
    }
}
