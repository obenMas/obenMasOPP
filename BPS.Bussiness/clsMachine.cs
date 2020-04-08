using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra la informacion general para todas las maquinas
    /// </summary>
    public class clsMachine
    {
        //Atributes

        private int mch_codsec;
        private int mch_fkExtruder;
        private clsExtruder mch_Extruder;
        private int mch_fkCutter;
        private clsCutter mch_Cutter;
        private int mch_fkMetallizer;
        private clsMetallizer mch_Metallizer;
        private int mch_fkMill;
        private clsMill mch_Mill;
        private int mch_fkThermoformer;
        private clsThermoformer mch_Thermoformer;
        private int mch_fkBalance;
        private clsBalance mch_Balance;
        private int mch_fkSector;
        private string mch_SectorName;
        private int mch_fkStatus;
        private string mch_StatusName;
        
        


        //Properties

        public int codsec { get { return mch_codsec; } set { mch_codsec = value; } }

        public int fkExtruder { get { return mch_fkExtruder; } set { mch_fkExtruder = value; } }

        public clsExtruder Extruder { get { return mch_Extruder; } set { mch_Extruder = value; } }

        public int fkCutter { get { return mch_fkCutter; } set { mch_fkCutter = value; } }

        public clsCutter Cutter { get { return mch_Cutter; } set { mch_Cutter = value; } }

        public int fkMetallizer { get { return mch_fkMetallizer; } set { mch_fkMetallizer = value; } }

        public clsMetallizer Metallizer { get { return mch_Metallizer; } set { mch_Metallizer = value; } }

        public int fkMill { get { return mch_fkMill; } set { mch_fkMill = value; } }

        public clsMill Mill { get { return mch_Mill; } set { mch_Mill = value; } }

        public int fkThermoformer { get { return mch_fkThermoformer; } set { mch_fkThermoformer = value; } }

        public clsThermoformer Thermoformer { get { return mch_Thermoformer; } set { mch_Thermoformer = value; } }

        public int fkBalance { get { return mch_fkBalance; } set { mch_fkBalance = value; } }

        public clsBalance Balance { get { return mch_Balance; } set { mch_Balance = value; } }

        public int fkSector { get { return mch_fkSector; } set { mch_fkSector = value; } }

        public string SectorName { get { return mch_SectorName; } set { mch_SectorName = value; } }

        public int fkStatus { get { return mch_fkStatus; } set { mch_fkStatus = value; } }

        public string StatusName { get { return mch_StatusName; } set { mch_StatusName = value; } }


        //Constructor

        public clsMachine()
        {
            mch_codsec = 0;
            mch_fkExtruder = 0;
            mch_Extruder = new clsExtruder();
            mch_fkCutter = 0;
            mch_Cutter = new clsCutter();
            mch_fkMetallizer = 0;
            mch_Metallizer = new clsMetallizer();
            mch_fkMill = 0;
            mch_Mill = new clsMill();
            mch_fkThermoformer = 0;
            mch_Thermoformer = new clsThermoformer();
            mch_fkBalance = 0;
            mch_Balance = new clsBalance();
            mch_fkSector = 0;
            mch_SectorName = "";
            mch_fkStatus = 0;
            mch_StatusName = "";

        }

        public clsMachine(int codsec)
        {
            this.load(codsec, "");
        }

        public clsMachine(int codsec,string type)
        {
            this.load(codsec, type);
        }

        //Methods

        public void load(int codsec, string machineType)
        {
            DataSet DS = new DataSet();

            switch (machineType)
            {
                case "Extruder":

                    DS = clsConnection.getDataSetResult("SELECT * FROM vwmachinesextruder where mch_codsec =  " + codsec.ToString());

                    this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_codsec"]);
                    this.fkExtruder = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkExtruder"]);
                    this.Extruder = new clsExtruder(Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkExtruder"]));
                    this.fkSector = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkSector"]);
                    this.SectorName = DS.Tables[0].Rows[0]["mch_SectorName"].ToString();
                    this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkStatus"]);
                    this.StatusName = DS.Tables[0].Rows[0]["mch_StatusName"].ToString();

                    break;

                case "Cutter":

                    DS = clsConnection.getDataSetResult("SELECT * FROM vwmachinecutter where mch_codsec =  " + codsec.ToString());

                    if(DS.Tables.Count>0 && DS.Tables[0].Rows.Count>0)
                    {
                        this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_codsec"]);
                        this.fkCutter = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkCutter"]);
                        this.Cutter = new clsCutter(Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkCutter"]));
                        this.fkSector = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkSector"]);
                        this.SectorName = DS.Tables[0].Rows[0]["mch_SectorName"].ToString();
                        this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkStatus"]);
                        this.StatusName = DS.Tables[0].Rows[0]["mch_StatusName"].ToString();

                    }

                    break;


                case "Metallizer":

                    DS = clsConnection.getDataSetResult("SELECT * FROM vwmachinemetallizer where mch_codsec =  " + codsec.ToString());

                    this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_codsec"]);
                    this.fkMetallizer = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkMetallizer"]);
                    this.Metallizer = new clsMetallizer(Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkMetallizer"]));
                    this.fkSector = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkSector"]);
                    this.SectorName = DS.Tables[0].Rows[0]["mch_SectorName"].ToString();
                    this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkStatus"]);
                    this.StatusName = DS.Tables[0].Rows[0]["mch_StatusName"].ToString();

                    break;

                case "Mill":

                    DS = clsConnection.getDataSetResult("SELECT * FROM vwmillmachine where mch_codsec =  " + codsec.ToString());

                    this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_codsec"]);
                    this.fkMill = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkMill"]);
                    this.Mill = new clsMill(Convert.ToInt32(DS.Tables[0].Rows[0]["mch_Mill"]));
                    this.fkSector = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkSector"]);
                    this.SectorName = DS.Tables[0].Rows[0]["mch_SectorName"].ToString();
                    this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkStatus"]);
                    this.StatusName = DS.Tables[0].Rows[0]["mch_StatusName"].ToString();

                    break;

                case "Thermoformer":

                    DS = clsConnection.getDataSetResult("SELECT * FROM vwthermoformermachine where mch_codsec =  " + codsec.ToString());

                    this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_codsec"]);
                    this.fkThermoformer = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkThermoformer"]);
                    this.Thermoformer = new clsThermoformer(Convert.ToInt32(DS.Tables[0].Rows[0]["mch_Thermoformer"]));
                    this.fkSector = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkSector"]);
                    this.SectorName = DS.Tables[0].Rows[0]["mch_SectorName"].ToString();
                    this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkStatus"]);
                    this.StatusName = DS.Tables[0].Rows[0]["mch_StatusName"].ToString();

                    break;

                case "Balance":

                    DS = clsConnection.getDataSetResult("SELECT * FROM vwbalancemachine where mch_codsec =  " + codsec.ToString());

                    this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_codsec"]);
                    this.fkBalance = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkBalance"]);
                    this.Balance = new clsBalance(Convert.ToInt32(DS.Tables[0].Rows[0]["mch_Balance"]));
                    this.fkSector = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkSector"]);
                    this.SectorName = DS.Tables[0].Rows[0]["mch_SectorName"].ToString();
                    this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkStatus"]);
                    this.StatusName = DS.Tables[0].Rows[0]["mch_StatusName"].ToString();

                    break;

                default:
                    break;

            }


        }

        public bool save(string machineType,int codsec, int sectorCodsec, int statusCodsec)
        {
           
            clsStatus objStatus = new clsStatus();
            objStatus.load(statusCodsec);
            clsSector objSector = new clsSector();
            objSector.load(sectorCodsec);
          
            try
            {
                string queryString = "";
                
                switch (machineType)
                {
                    case "Extruder":
                        if (this.codsec == 0)
                        {
                            queryString += "INSERT INTO bps_prod_machine (mch_fkExtruder,mch_fkStatus,mch_fkSector)";
                            queryString += " VALUES (";
                            queryString += codsec.ToString() + ",";
                            queryString += objStatus.codsec.ToString() + ",";
                            queryString += objSector.codsec.ToString() + "";
                            queryString += ");";
                            clsConnection.executeQuery(queryString);
                        }
                        else
                        {
                            queryString += "UPDATE bps_prod_machine";
                            queryString += " SET ";
                            queryString += "mch_fkStatus = " + objStatus.codsec.ToString() + ",";
                            queryString += "mch_fkSector = " + objSector.codsec.ToString() + "";
                            queryString += " WHERE mch_fkExtruder = " + this.fkExtruder.ToString() + ";";
                            clsConnection.executeQuery(queryString);

                        }
                        break;
                    
                    case "Cutter":
                   
                      
                        if (this.codsec == 0)
                        {
                            queryString += "INSERT INTO bps_prod_machine (mch_fkCutter,mch_fkStatus,mch_fkSector)";
                            queryString += " VALUES (";
                            queryString += codsec.ToString() + ",";
                            queryString += objStatus.codsec.ToString() + ",";
                            queryString += objSector.codsec.ToString() + "";
                            queryString += ");";
                            clsConnection.executeQuery(queryString);
                        }
                        else
                        {
                            queryString += "UPDATE bps_prod_machine";
                            queryString += " SET ";
                            queryString += "mch_fkStatus = " + objStatus.codsec.ToString() + ",";
                            queryString += "mch_fkSector = " + objSector.codsec.ToString() + "";
                            queryString += " WHERE mch_fkCutter = " + this.fkCutter.ToString() + ";";
                            clsConnection.executeQuery(queryString);

                        }
                        break;

                    case "Metallizer":
                        if (this.codsec == 0)
                        {
                            queryString += "INSERT INTO bps_prod_machine (mch_fkMetallizer,mch_fkStatus,mch_fkSector)";
                            queryString += " VALUES (";
                            queryString += codsec.ToString() + ",";
                            queryString += objStatus.codsec.ToString() + ",";
                            queryString += objSector.codsec.ToString() + "";
                            queryString += ");";
                            clsConnection.executeQuery(queryString);
                        }
                        else
                        {
                            queryString += "UPDATE bps_prod_machine";
                            queryString += " SET ";
                            queryString += "mch_fkStatus = " + objStatus.codsec.ToString() + ",";
                            queryString += "mch_fkSector = " + objSector.codsec.ToString() + "";
                            queryString += " WHERE mch_fkMetallizer = " + this.fkMetallizer.ToString() + ";";
                            clsConnection.executeQuery(queryString);

                        }
                        break;

                    case "Mill":

                        if (this.codsec == 0)
                        {
                            queryString += "INSERT INTO bps_prod_machine (mch_fkMill,mch_fkStatus,mch_fkSector)";
                            queryString += " VALUES (";
                            queryString += codsec.ToString() + ",";
                            queryString += objStatus.codsec.ToString() + ",";
                            queryString += objSector.codsec.ToString() + "";
                            queryString += ");";
                            clsConnection.executeQuery(queryString);
                        }
                        else
                        {
                            queryString += "UPDATE bps_prod_machine";
                            queryString += " SET ";
                            queryString += "mch_fkStatus = " + objStatus.codsec.ToString() + ",";
                            queryString += "mch_fkSector = " + objSector.codsec.ToString() + "";
                            queryString += " WHERE mch_fkMill = " + this.fkMill.ToString() + ";";
                            clsConnection.executeQuery(queryString);

                        }
                        break;

                    case "Thermoformer":
                        if (this.codsec == 0)
                        {
                            queryString += "INSERT INTO bps_prod_machine (mch_fkThermoformer,mch_fkStatus,mch_fkSector)";
                            queryString += " VALUES (";
                            queryString += codsec.ToString() + ",";
                            queryString += objStatus.codsec.ToString() + ",";
                            queryString += objSector.codsec.ToString() + "";
                            queryString += ");";
                            clsConnection.executeQuery(queryString);
                        }
                        else
                        {
                            queryString += "UPDATE bps_prod_machine";
                            queryString += " SET ";
                            queryString += "mch_fkStatus = " + objStatus.codsec.ToString() + ",";
                            queryString += "mch_fkSector = " + objSector.codsec.ToString() + "";
                            queryString += " WHERE mch_fkThermoformer = " + this.fkThermoformer.ToString() + ";";
                            clsConnection.executeQuery(queryString);

                        }
                        break;

                    case "Balance":
                        if (this.codsec == 0)
                        {
                            queryString += "INSERT INTO bps_prod_machine (mch_fkBalance,mch_fkStatus,mch_fkSector)";
                            queryString += " VALUES (";
                            queryString += codsec.ToString() + ",";
                            queryString += objStatus.codsec.ToString() + ",";
                            queryString += objSector.codsec.ToString() + "";
                            queryString += ");";
                            clsConnection.executeQuery(queryString);
                        }
                        else
                        {
                            queryString += "UPDATE bps_prod_machine";
                            queryString += " SET ";
                            queryString += "mch_fkStatus = " + objStatus.codsec.ToString() + ",";
                            queryString += "mch_fkSector = " + objSector.codsec.ToString() + "";
                            queryString += " WHERE mch_fkBalance = " + this.fkBalance.ToString() + ";";
                            clsConnection.executeQuery(queryString);

                        }
                        break;
                    
                    default:
                        break;
                }
                return true;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMachine.save");
                return false;
            }

        }

        
        public static List<clsMachine> getExtruderMachineList()
        {
            List<clsMachine> lstMachine = new List<clsMachine>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwmachinesextruder");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstMachine.Add(new clsMachine());
                lstMachine[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mch_codsec"]);
                lstMachine[i].fkExtruder = Convert.ToInt32(DS.Tables[0].Rows[i]["mch_fkExtruder"]);
                lstMachine[i].Extruder = new clsExtruder(Convert.ToInt32(DS.Tables[0].Rows[i]["mch_fkExtruder"]));
                lstMachine[i].fkSector = Convert.ToInt32(DS.Tables[0].Rows[i]["mch_fkSector"]);
                lstMachine[i].SectorName = DS.Tables[0].Rows[i]["mch_SectorName"].ToString();
                lstMachine[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mch_fkStatus"]);
                lstMachine[i].StatusName = DS.Tables[0].Rows[i]["mch_StatusName"].ToString();
            }

            return lstMachine;
        }

        public static List<clsMachine> getCutterMachineList()
        {
            List<clsMachine> lstMachine = new List<clsMachine>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwmachinecutter");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstMachine.Add(new clsMachine());
                lstMachine[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mch_codsec"]);
                lstMachine[i].fkCutter = Convert.ToInt32(DS.Tables[0].Rows[i]["mch_fkCutter"]);
                lstMachine[i].Cutter = new clsCutter(Convert.ToInt32(DS.Tables[0].Rows[i]["mch_fkCutter"]));
                lstMachine[i].fkSector = Convert.ToInt32(DS.Tables[0].Rows[i]["mch_fkSector"]);
                lstMachine[i].SectorName = DS.Tables[0].Rows[i]["mch_SectorName"].ToString();
                lstMachine[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mch_fkStatus"]);
                lstMachine[i].StatusName = DS.Tables[0].Rows[i]["mch_StatusName"].ToString();

            }

            return lstMachine;
        }


        

        public static List<clsMachine> getMetallizerMachineList()
        {
            List<clsMachine> lstMachine = new List<clsMachine>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwmachinemetallizer");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstMachine.Add(new clsMachine());
                lstMachine[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mch_codsec"]);
                lstMachine[i].fkMetallizer = Convert.ToInt32(DS.Tables[0].Rows[i]["mch_fkMetallizer"]);
                lstMachine[i].Metallizer = new clsMetallizer(Convert.ToInt32(DS.Tables[0].Rows[i]["mch_fkMetallizer"]));
                lstMachine[i].fkSector = Convert.ToInt32(DS.Tables[0].Rows[i]["mch_fkSector"]);
                lstMachine[i].SectorName = DS.Tables[0].Rows[i]["mch_SectorName"].ToString();
                lstMachine[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mch_fkStatus"]);
                lstMachine[i].StatusName = DS.Tables[0].Rows[i]["mch_StatusName"].ToString();

            }

            return lstMachine;
        }

        public static List<clsMachine> getMillMachineList()
        {
            List<clsMachine> lstMachine = new List<clsMachine>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwmillmachine");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstMachine.Add(new clsMachine());
                lstMachine[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mch_codsec"]);
                lstMachine[i].fkMill = Convert.ToInt32(DS.Tables[0].Rows[i]["mch_fkMill"]);
                lstMachine[i].Mill = new clsMill(Convert.ToInt32(DS.Tables[0].Rows[i]["mch_Mill"]));
                lstMachine[i].fkSector = Convert.ToInt32(DS.Tables[0].Rows[i]["mch_fkSector"]);
                lstMachine[i].SectorName = DS.Tables[0].Rows[i]["mch_SectorName"].ToString();
                lstMachine[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mch_fkStatus"]);
                lstMachine[i].StatusName = DS.Tables[0].Rows[i]["mch_StatusName"].ToString();
            }

            return lstMachine;
        }

        public static List<clsMachine> getThermoformerMachineList()
        {
            List<clsMachine> lstMachine = new List<clsMachine>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwthermoformermachine");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstMachine.Add(new clsMachine());
                lstMachine[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mch_codsec"]);
                lstMachine[i].fkThermoformer = Convert.ToInt32(DS.Tables[0].Rows[i]["mch_fkThermoformer"]);
                lstMachine[i].Thermoformer = new clsThermoformer(Convert.ToInt32(DS.Tables[0].Rows[i]["mch_Thermoformer"]));
                lstMachine[i].fkSector = Convert.ToInt32(DS.Tables[0].Rows[i]["mch_fkSector"]);
                lstMachine[i].SectorName = DS.Tables[0].Rows[i]["mch_SectorName"].ToString();
                lstMachine[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mch_fkStatus"]);
                lstMachine[i].StatusName = DS.Tables[0].Rows[i]["mch_StatusName"].ToString();

            }

            return lstMachine;
        }

         public static List<clsMachine> getBalanceMachineList()
        {
            List<clsMachine> lstMachine = new List<clsMachine>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwbalancemachine");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstMachine.Add(new clsMachine());
                lstMachine[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mch_codsec"]);
                lstMachine[i].fkBalance = Convert.ToInt32(DS.Tables[0].Rows[i]["mch_fkBalance"]);
                lstMachine[i].Balance = new clsBalance(Convert.ToInt32(DS.Tables[0].Rows[i]["mch_Balance"]));
                lstMachine[i].fkSector = Convert.ToInt32(DS.Tables[0].Rows[i]["mch_fkSector"]);
                lstMachine[i].SectorName = DS.Tables[0].Rows[i]["mch_SectorName"].ToString();
                lstMachine[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mch_fkStatus"]);
                lstMachine[i].StatusName = DS.Tables[0].Rows[i]["mch_StatusName"].ToString();

            }

            return lstMachine;
        }

         public static int getMachineCodSecByCutterCodSec(int cutterCodsec)
         {
             DataSet DS = new DataSet();

             DS = clsConnection.getDataSetResult("CALL spGetMachineCodsecByCutterCodsec( " + cutterCodsec + ")");

             return Convert.ToInt32(DS.Tables[0].Rows[0]["mch_codsec"]);
            
            
         }

         public static int getMachineCodSecByMetallizerCodSec(int metCodsec)
         {
             DataSet DS = new DataSet();

             DS = clsConnection.getDataSetResult("CALL spGetMachineCodsecByMetallizerCodsec( " + metCodsec + ")");

             return Convert.ToInt32(DS.Tables[0].Rows[0]["mch_codsec"]);


         }

        public void getMillDetail(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_machine where mch_fkMill =" + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_codsec"]);
            this.fkMill = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkMill"]);
            this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkStatus"]);
            this.fkSector = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkSector"]);        
         
        }

        public void getExtruderDetail(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_machine where mch_fkExtruder =" + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_codsec"]);
            this.fkExtruder = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkExtruder"]);
            this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkStatus"]);
            this.fkSector = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkSector"]);

        }

        public void getCutterDetail(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_machine where mch_fkCutter =" + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_codsec"]);
            this.fkCutter = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkCutter"]);
            this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkStatus"]);
            this.fkSector = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkSector"]);

        }

        public static int  getCutterCodsec(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_machine where mch_fkCutter =" + codsec.ToString());
            return Convert.ToInt32(DS.Tables[0].Rows[0]["mch_codsec"]);
        }

        public static int getBalanceCodsec(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_machine where mch_fkBalance =" + codsec.ToString());
            return Convert.ToInt32(DS.Tables[0].Rows[0]["mch_codsec"]);
        }

        public void getMetallizerDetail(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_machine where mch_fkMetallizer =" + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_codsec"]);
            this.fkMetallizer = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkMetallizer"]);
            this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkStatus"]);
            this.fkSector = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkSector"]);

        }

        public void getThermoformerDetail(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_machine where mch_fkThermoformer =" + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_codsec"]);
            this.fkThermoformer = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkThermoformer"]);
            this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkStatus"]);
            this.fkSector = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkSector"]);

        }

        public void getBalanceDetail(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_machine where mch_fkBalance =" + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_codsec"]);
            this.fkBalance = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkBalance"]);
            this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkStatus"]);
            this.fkSector = Convert.ToInt32(DS.Tables[0].Rows[0]["mch_fkSector"]);

        }
        public override string ToString()
        {
            string name = "";
            if (this.fkExtruder > 0)
                name = this.Extruder.name;
            if (this.fkCutter > 0)
                name = this.Cutter.name;
            if (this.fkBalance > 0)
                name = this.Balance.name;
            if (this.fkMetallizer > 0)
                name = this.Metallizer.name;

            return name;
        }
    }
}
