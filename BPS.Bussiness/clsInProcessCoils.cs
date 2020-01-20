using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BPS.Bussiness;

namespace BPS.Bussiness
{
    public class clsInProcessCoils
    {
        //Atributes

        private int ipc_codsec;
        private int ipc_fkCoil;
        string ipc_destination;
        string ipc_process;
        string ipc_detail;
        private int ipc_usefulwidth;
        private int ipc_fkuser;
        DateTime ipc_revisiondate;

        //Properties

        public int codsec { get { return ipc_codsec; } set { ipc_codsec = value; } }

        public int coil { get { return ipc_fkCoil; } set { ipc_fkCoil = value; } }

        public string destination { get { return ipc_destination; } set { ipc_destination = value; } }

        public string process { get { return ipc_process; } set { ipc_process = value; } }

        public string detail { get { return ipc_detail; } set { ipc_detail = value; } }

        public int usefulwidth { get { return ipc_usefulwidth; } set { ipc_usefulwidth = value; } }

        public int fkuser { get { return ipc_fkuser; } set { ipc_fkuser = value; } }

        public DateTime revisiondate { get { return ipc_revisiondate; } set { ipc_revisiondate = value; } }



        //Constructor

        public clsInProcessCoils()
        {
            ipc_codsec = 0;
            ipc_fkCoil = 0;
            ipc_destination = string.Empty;
            ipc_process = string.Empty;
            ipc_detail = string.Empty;
            ipc_usefulwidth = 0;
            ipc_fkuser = 0;
            ipc_revisiondate = DateTime.Now; 
        }

        public clsInProcessCoils(int codsec)
        {
            this.load(codsec);
        }

        public void load(int codsec)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_inprocesscoils where ipc_fkCoil = " + codsec.ToString());

            if(DS.Tables.Count>0 && DS.Tables[0].Rows.Count>0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["ipc_codsec"]);
                this.coil = Convert.ToInt32(DS.Tables[0].Rows[0]["ipc_fkCoil"]);
                this.destination = DS.Tables[0].Rows[0]["ipc_destination"].ToString();
                this.process = DS.Tables[0].Rows[0]["ipc_process"].ToString();
                this.detail = DS.Tables[0].Rows[0]["ipc_detail"].ToString();
                this.usefulwidth = Convert.ToInt32(DS.Tables[0].Rows[0]["ipc_usefulwidth"]);
                this.fkuser = Convert.ToInt32(DS.Tables[0].Rows[0]["ipc_fkuser"]);
                this.revisiondate = Convert.ToDateTime(DS.Tables[0].Rows[0]["ipc_revisiondate"]);


            }
            
        }

        public void loadDetailsbyCodsec(int coilCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spInProcessCoilByCodsec(" + coilCodsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["codsec"]);
                this.coil = Convert.ToInt32(DS.Tables[0].Rows[0]["CoilCodsec"]);
                this.destination = DS.Tables[0].Rows[0]["Destino"].ToString();
                this.process = DS.Tables[0].Rows[0]["Reproceso"].ToString();
                this.detail = DS.Tables[0].Rows[0]["Observacion"].ToString();
                this.usefulwidth = Convert.ToInt32(DS.Tables[0].Rows[0]["AnchoUtil"]);
                this.fkuser = Convert.ToInt32(DS.Tables[0].Rows[0]["Usuario"]);
                this.revisiondate = Convert.ToDateTime(DS.Tables[0].Rows[0]["Fecha"]);
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }


        public bool save()
        {
            try
            {

                string queryString = "";
                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_inprocesscoils (ipc_fkCoil, ipc_destination, ipc_process, ipc_detail, ipc_usefulwidth, ipc_fkuser, ipc_revisiondate)";
                    queryString += " VALUES (";
                    queryString += this.coil.ToString() + ", ";
                    queryString += "'"+ this.destination.ToString() + "', ";
                    queryString += "'"+ this.process.ToString() + "', ";
                    queryString += "'"+ this.detail.ToString() + "', ";
                    queryString += this.usefulwidth.ToString() + ", ";
                    queryString += this.fkuser.ToString() + ", ";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "'";
                    queryString += ");";

                }
                else
                {
                    queryString += "UPDATE bps_prod_inprocesscoils ";
                    queryString += "set ";
                    queryString += "ipc_fkCoil = " + this.coil.ToString() + ", ";
                    queryString += "ipc_destination = '" + this.destination.ToString() + "', ";
                    queryString += "ipc_process = '" + this.process.ToString() + "', ";
                    queryString += "ipc_detail = '" + this.detail.ToString() + "', ";
                    queryString += "ipc_usefulwidth = " + this.usefulwidth.ToString() + ", ";
                    queryString += "ipc_fkuser = " + this.fkuser.ToString() + ", ";
                    queryString += "ipc_revisiondate = '"+DateTime.Now.ToString("dd/MM/yyyy HH:mm") +"'";
                    queryString += "WHERE ipc_codsec = " + this.codsec.ToString() + ";";
                }
                if (clsConnection.executeQuery(queryString))
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsInProcessCoils.save");
                return false;
            }
        }

    }

}

