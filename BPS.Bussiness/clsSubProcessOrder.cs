using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra las ordenes de proceso secundario para pelicula BOPP/Cast/Coating
    /// </summary>
    public class clsSubProcessOrder
    {
        //Atributes

        private int spo_codsec;
        private int spo_fkSubProcessType;
        private string spo_SubProcessTypeName;
        private int spo_fkStatus;
        private string spo_StatusName;
        private int spo_fkMachine;
        private string spo_MachineName;
        private string spo_code;
        private string spo_notes;
        private DateTime spo_createdDate;
        private DateTime spo_modifiedDate;
        private DateTime spo_initDate;
        private DateTime spo_endDate;
        private int spo_createdBy;
        private string spo_creatorUser;
        private int spo_modifiedBy;
        private string spo_modificatorUser;


        //Properties

        public int codsec { get { return spo_codsec; } set { spo_codsec = value; } }

        public int fkSubProcessType { get { return spo_fkSubProcessType; } set { spo_fkSubProcessType = value; } }

        public string SubProcessTypeName { get { return spo_SubProcessTypeName; } set { spo_SubProcessTypeName = value; } }

        public int fkStatus { get { return spo_fkStatus; } set { spo_fkStatus = value; } }

        public string StatusName { get { return spo_StatusName; } set { spo_StatusName = value; } }

        public int fkMachine { get { return spo_fkMachine; } set { spo_fkMachine = value; } }

        public string MachineName { get { return spo_MachineName; } set { spo_MachineName = value; } }

        public string code { get { return spo_code; } set { spo_code = value; } }

        public string notes { get { return spo_notes; } set { spo_notes = value; } }

        public DateTime createdDate { get { return spo_createdDate; } set { spo_createdDate = value; } }

        public DateTime modifiedDate { get { return spo_modifiedDate; } set { spo_modifiedDate = value; } }

        public DateTime initDate { get { return spo_initDate; } set { spo_initDate = value; } }

        public DateTime endDate { get { return spo_endDate; } set { spo_endDate = value; } }

        public int createdBy { get { return spo_createdBy; } set { spo_createdBy = value; } }

        public string creatorUser { get { return spo_creatorUser; } set { spo_creatorUser = value; } }

        public int modifiedBy { get { return spo_modifiedBy; } set { spo_modifiedBy = value; } }

        public string modificatorUser { get { return spo_modificatorUser; } set { spo_modificatorUser = value; } }



        //Constructor
        public clsSubProcessOrder()
        {
            spo_codsec = 0;
            spo_fkSubProcessType = 0;
            spo_SubProcessTypeName = "";
            spo_fkStatus = 0;
            spo_StatusName = "";
            spo_fkMachine = 0;
            spo_MachineName = "";
            spo_code = "";
            spo_notes = "";
            spo_createdDate = DateTime.Now;
            spo_modifiedDate = DateTime.Now;
            spo_initDate = DateTime.Now;
            spo_endDate = DateTime.Now;
            spo_createdBy = 0;
            spo_creatorUser = "";
            spo_modifiedBy = 0;
            spo_modificatorUser = "";
        }
        public clsSubProcessOrder(int codsec)
        {
            this.load(codsec);
        }
        //Methods
        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT");

        }

        public void save()
        {

        }

        public static List<clsSubProcessOrder> getList()
        {
            return new List<clsSubProcessOrder>();
        }
    }
}
