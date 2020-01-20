using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsFilmEquivalence
    {
        //Atributes

        private int feq_codsec;
        private int feq_fkBopp;
        private int feq_fkCast;
        private string feq_externalId;
        private string feq_externalDescription;
        private string feq_externalCode;

       //Properties

        public int codsec { get { return feq_codsec; } set { feq_codsec = value; } }

        public int fkBopp { get { return feq_fkBopp; } set { feq_fkBopp = value; } }

        public string Id { get { return feq_externalId; } set { feq_externalId = value; } }

        public string description { get { return feq_externalDescription; } set { feq_externalDescription = value; } }

        public int fkCast { get { return feq_fkCast; } set { feq_fkCast = value; } }

        public string code { get { return feq_externalCode; } set { feq_externalCode = value; } }


        //Constructor

        public clsFilmEquivalence()
        {  
            feq_codsec = 0;
            feq_fkBopp = 0;
            feq_externalId = "";
            feq_externalDescription = "";
            feq_fkCast = 0;
            feq_externalCode = "";
        }
        
        //Methods

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_xtr_filmequivalence2 (feq_fkBopp, feq_fkCast, feq_externalId, feq_externalDescription, feq_externalCode) ";
                    queryString += " VALUES (";
                    queryString += "" + this.fkBopp.ToString() + ", ";
                    queryString += "" + this.fkCast.ToString() + ", ";
                    queryString += "'" + this.Id.ToString() + "', ";
                    queryString += "'" + this.description.ToString() + "', ";
                    queryString += "'" + this.code.ToString() + "' ";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_xtr_filmequivalence2 ";
                    queryString += " SET ";
                    queryString += "feq_fkBopp = " + this.fkBopp.ToString() + ", ";
                    queryString += "feq_fkCast = " + this.fkCast.ToString() + ", ";
                    queryString += "feq_externalId = '" + this.Id.ToString() + "', ";
                    queryString += "feq_externalDescription = '" + this.description.ToString() + "', ";
                    queryString += "feq_externalCode = '" + this.code.ToString() + "', ";
                    queryString += " WHERE feq_codsec = " + this.codsec.ToString() + ";";

                }

                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();

                clsLog.addLog(ex, 3, "clsCoil.save");
                return false;
            }
        }
    }
}
