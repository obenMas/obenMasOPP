using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO.Ports;
using System.Windows.Forms;


namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra las Balanzas
    /// </summary>
    public class clsBalance
    {
        //Atributes

        private int blc_codsec;
        private int blc_fkStatus;
        private string blc_statusName;
        private int blc_fkUnit;
        private string blc_unitName;
        private string blc_symbol;
        private string blc_name;
        private int blc_capacity;
        private string blc_delimeterOne;
        private string blc_delimeterTwo;
        private int blc_comm;
        private string blc_command;
        private int blc_dataInit;
        private int blc_dataLen;
        private int blc_fkUser;
        private int blc_fkRole;

        private SerialPort sprtBalance;

        //Properties

        public int codsec { get { return blc_codsec; } set { blc_codsec = value; } }

        public int fkStatus { get { return blc_fkStatus; } set { blc_fkStatus = value; } }

        public string statusName { get { return blc_statusName; } set { blc_statusName = value; } }

        public int fkUnit { get { return blc_fkUnit; } set { blc_fkUnit = value; } }

        public string unitName { get { return blc_unitName; } set { blc_unitName = value; } }

        public string symbol { get { return blc_symbol; } set { blc_symbol = value; } }

        public string name { get { return blc_name; } set { blc_name = value; } }

        public int capacity { get { return blc_capacity; } set { blc_capacity = value; } }

        public string delimeterOne { get { return blc_delimeterOne; } set { blc_delimeterOne = value; } }

        public string delimeterTwo { get { return blc_delimeterTwo; } set { blc_delimeterTwo = value; } }

        public int comm { get { return blc_comm; } set { blc_comm = value; } }

        public string command { get { return blc_command; } set { blc_command = value; } }

        public int dataInit { get { return blc_dataInit; } set { blc_dataInit = value; } }

        public int dataLen { get { return blc_dataLen; } set { blc_dataLen = value; } }

        public int fkUser { get { return blc_fkUser; } set { blc_fkUser = value; } }

        public int fkRole { get { return blc_fkRole; } set { blc_fkRole = value; } }

        //Constructor

        public clsBalance()
        {
            blc_codsec = 0;
            blc_fkStatus = 0;
            blc_statusName = "";
            blc_fkUnit = 0;
            blc_unitName = "";
            blc_symbol = "";
            blc_name = "";
            blc_capacity = 0;
            blc_delimeterOne = "";
            blc_delimeterTwo = "";
            blc_comm = 0;
            blc_command = "";
            blc_dataInit = 0;
            blc_dataLen = 0;
            blc_fkUser = 0;
            blc_fkRole = 0;
        }
        public clsBalance(int codsec)
        {
            this.load(codsec);
        }

        public clsBalance(string balname)
        {
            this.load(balname);
        }

        //Methods

        public void load(int codsec)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwBalance where blc_codsec = " + codsec.ToString());
            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_codsec"]);
                    this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_fkStatus"]);
                    this.statusName = DS.Tables[0].Rows[0]["blc_statusName"].ToString();
                    this.fkUnit = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_fkUnit"]);
                    this.unitName = DS.Tables[0].Rows[0]["blc_unitName"].ToString();
                    this.symbol = DS.Tables[0].Rows[0]["blc_symbol"].ToString();
                    this.name = DS.Tables[0].Rows[0]["blc_name"].ToString();
                    this.capacity = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_capacity"]);
                    this.delimeterOne = DS.Tables[0].Rows[0]["blc_delimeterOne"].ToString();
                    this.delimeterTwo = DS.Tables[0].Rows[0]["blc_delimeterTwo"].ToString();
                    this.comm = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_comm"]);
                    this.command = DS.Tables[0].Rows[0]["blc_command"].ToString();
                    this.dataInit = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_dataInit"]);
                    this.dataLen = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_dataLen"]);
                    this.fkUser = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_fkUser"]);
                    this.fkRole = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_fkRole"]);
                }
            }
        }

        public void loadByRole(int codsec)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwBalance where blc_fkRole = " + codsec.ToString());
            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_codsec"]);
                    this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_fkStatus"]);
                    this.statusName = DS.Tables[0].Rows[0]["blc_statusName"].ToString();
                    this.fkUnit = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_fkUnit"]);
                    this.unitName = DS.Tables[0].Rows[0]["blc_unitName"].ToString();
                    this.symbol = DS.Tables[0].Rows[0]["blc_symbol"].ToString();
                    this.name = DS.Tables[0].Rows[0]["blc_name"].ToString();
                    this.capacity = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_capacity"]);
                    this.delimeterOne = DS.Tables[0].Rows[0]["blc_delimeterOne"].ToString();
                    this.delimeterTwo = DS.Tables[0].Rows[0]["blc_delimeterTwo"].ToString();
                    this.comm = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_comm"]);
                    this.command = DS.Tables[0].Rows[0]["blc_command"].ToString();
                    this.dataInit = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_dataInit"]);
                    this.dataLen = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_dataLen"]);
                    this.fkUser = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_fkUser"]);
                    this.fkRole = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_fkRole"]);
                }
            }
        }

        public void loadBalanceNameByUser(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwBalance where blc_fkUser = " + codsec.ToString());
            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_codsec"]);
                    this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_fkStatus"]);
                    this.statusName = DS.Tables[0].Rows[0]["blc_statusName"].ToString();
                    this.fkUnit = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_fkUnit"]);
                    this.unitName = DS.Tables[0].Rows[0]["blc_unitName"].ToString();
                    this.symbol = DS.Tables[0].Rows[0]["blc_symbol"].ToString();
                    this.name = DS.Tables[0].Rows[0]["blc_name"].ToString();
                    this.capacity = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_capacity"]);
                    this.delimeterOne = DS.Tables[0].Rows[0]["blc_delimeterOne"].ToString();
                    this.delimeterTwo = DS.Tables[0].Rows[0]["blc_delimeterTwo"].ToString();
                    this.comm = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_comm"]);
                    this.command = DS.Tables[0].Rows[0]["blc_command"].ToString();
                    this.dataInit = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_dataInit"]);
                    this.dataLen = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_dataLen"]);
                    this.fkUser = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_fkUser"]);
                    this.fkRole = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_fkRole"]);
                }
            }
        }

        public List<clsBalance> getBalanceList()
        {
            List<clsBalance> lstBalance = new List<clsBalance>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwBalance ");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstBalance.Add(new clsBalance());
                    lstBalance[i].blc_codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_codsec"]);
                    lstBalance[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_fkStatus"]);
                    lstBalance[i].statusName = DS.Tables[0].Rows[0]["blc_statusName"].ToString();
                    lstBalance[i].fkUnit = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_fkUnit"]);
                    lstBalance[i].unitName = DS.Tables[0].Rows[0]["blc_unitName"].ToString();
                    lstBalance[i].symbol = DS.Tables[0].Rows[0]["blc_symbol"].ToString();
                    lstBalance[i].name = DS.Tables[0].Rows[0]["blc_name"].ToString();
                    lstBalance[i].capacity = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_capacity"]);
                    lstBalance[i].delimeterOne = DS.Tables[0].Rows[0]["blc_delimeterOne"].ToString();
                    lstBalance[i].delimeterTwo = DS.Tables[0].Rows[0]["blc_delimeterTwo"].ToString();
                    lstBalance[i].comm = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_comm"]);
                    lstBalance[i].command = DS.Tables[0].Rows[0]["blc_command"].ToString();
                    lstBalance[i].dataInit = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_dataInit"]);
                    lstBalance[i].dataLen = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_dataLen"]);
                    lstBalance[i].fkUser = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_fkUser"]);
                    lstBalance[i].fkRole = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_fkRole"]);
                }


            }
            return lstBalance;
        }

        public void load(string bname)
        {
            List<clsCoil> lstCoil = new List<clsCoil>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwBalance where blc_name = '" + bname + "'");
            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_codsec"]);
                    this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_fkStatus"]);
                    this.statusName = DS.Tables[0].Rows[0]["blc_statusName"].ToString();
                    this.fkUnit = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_fkUnit"]);
                    this.unitName = DS.Tables[0].Rows[0]["blc_unitName"].ToString();
                    this.symbol = DS.Tables[0].Rows[0]["blc_symbol"].ToString();
                    this.name = DS.Tables[0].Rows[0]["blc_name"].ToString();
                    this.capacity = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_capacity"]);
                    this.delimeterOne = DS.Tables[0].Rows[0]["blc_delimeterOne"].ToString();
                    this.delimeterTwo = DS.Tables[0].Rows[0]["blc_delimeterTwo"].ToString();
                    this.comm = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_comm"]);
                    this.command = DS.Tables[0].Rows[0]["blc_command"].ToString();
                    this.dataInit = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_dataInit"]);
                    this.dataLen = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_dataLen"]);
                    this.fkUser = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_fkUser"]);
                    this.fkRole = Convert.ToInt32(DS.Tables[0].Rows[0]["blc_fkRole"]);
                }
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_balance (blc_fkStatus, blc_fkUnit, blc_name,blc_capacity,blc_delimeterOne,blc_delimeterTwo,blc_comm,blc_command,blc_dataInit,blc_dataLen)";
                    queryString += " VALUES (";
                    queryString += "" + this.fkStatus + ",";
                    queryString += "" + this.fkUnit + ",";
                    queryString += "'" + this.name + "',";
                    queryString += "" + this.capacity + ",";
                    queryString += "'" + this.delimeterOne + "',";
                    queryString += "'" + this.delimeterTwo + "',";
                    queryString += "" + this.comm + ",";
                    queryString += "'" + this.command + "'";
                    queryString += "" + this.dataInit + ",";
                    queryString += "" + this.dataLen + ",";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_prod_balance";
                    queryString += " SET ";
                    queryString += "blc_fkStatus = '" + this.fkStatus.ToString() + "',";
                    queryString += "blc_fkUnit = '" + this.fkUnit.ToString() + "',";
                    queryString += "blc_name = '" + this.name + "',";
                    queryString += "blc_capacity = " + this.capacity.ToString() + ",";
                    queryString += "blc_delimeterOne = '" + this.delimeterOne + "',";
                    queryString += "blc_delimeterTwo = '" + this.delimeterTwo + "',";
                    queryString += "blc_comm = " + this.comm.ToString() + ",";
                    queryString += "blc_command = '" + this.command.ToString() + "'";
                    queryString += "blc_dataInit = " + this.comm.ToString() + ",";
                    queryString += "blc_dataEnd = " + this.comm.ToString() + ",";
                    queryString += " WHERE blc_codsec = " + this.codsec.ToString() + ";";
                    clsConnection.executeQuery(queryString);

                }
                return true;
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsBalance.save");
                return false;
            }
        }

        public static List<clsBalance> getList()
        {
            List<clsBalance> lstBalance = new List<clsBalance>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_balance order by blc_name asc");

            lstBalance.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstBalance.Add(new clsBalance());
                lstBalance[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["blc_codsec"]);
                lstBalance[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["blc_fkStatus"]);
                lstBalance[i].fkUnit = Convert.ToInt32(DS.Tables[0].Rows[i]["blc_fkUnit"]);
                lstBalance[i].name = DS.Tables[0].Rows[i]["blc_name"].ToString();
                lstBalance[i].capacity = Convert.ToInt32(DS.Tables[0].Rows[i]["blc_capacity"]);
                lstBalance[i].delimeterOne = DS.Tables[0].Rows[i]["blc_delimeterOne"].ToString();
                lstBalance[i].delimeterTwo = DS.Tables[0].Rows[i]["blc_delimeterTwo"].ToString();
                lstBalance[i].comm = Convert.ToInt32(DS.Tables[0].Rows[i]["blc_comm"]);
                lstBalance[i].command = DS.Tables[0].Rows[i]["blc_command"].ToString();
                lstBalance[i].dataInit = Convert.ToInt32(DS.Tables[0].Rows[i]["blc_dataInit"]);
                lstBalance[i].dataLen = Convert.ToInt32(DS.Tables[0].Rows[i]["blc_dataLen"]);
                lstBalance[i].fkUser = Convert.ToInt32(DS.Tables[0].Rows[i]["blc_fkUser"]);
                lstBalance[i].fkRole = Convert.ToInt32(DS.Tables[0].Rows[i]["blc_fkRole"]);
            }

            return lstBalance;
        }

        public string getWeigth(string last)
        {
            string texto = "";
            string texto2 = "";
            string result = "";
            try
            {
                string command = string.Empty;
                sprtBalance = new SerialPort(("COM" + this.comm.ToString()));


                if (!sprtBalance.IsOpen)
                {
                    sprtBalance.Open();
                }
                sprtBalance.ReadTimeout = 5000;

                if (this.blc_command != string.Empty)
                {
                    //sprtBalance.Write(this.blc_command + "\r");
                    sprtBalance.WriteLine(this.blc_command + "\r");
                    
                    texto = sprtBalance.ReadLine();
                    
                    if (sprtBalance.IsOpen)
                    {
                        sprtBalance.Close();
                    }
                    if (texto != string.Empty)
                    {
                        if (texto.Length >= this.dataLen + this.dataInit)
                        {
                            result = texto.Substring(this.dataInit, this.dataLen);
                            return result;
                        }
                        else
                        {
                            result = texto.Substring(this.dataInit, texto.Length - this.dataInit);
                            return result;
                        }
                    }
                    else
                    {
                        return last;
                    }
                }
                else
                {
                    texto2 = sprtBalance.ReadTo("\r");

                    if (sprtBalance.IsOpen)
                    {
                        sprtBalance.Close();
                    }
                    if ((!texto2.StartsWith("D") && !texto2.StartsWith("F") && !texto2.StartsWith("@") && !texto2.StartsWith("L")) || texto2.Length < this.dataLen)
                    {
                        return last;
                    }
                    string ret = "0";

                    for (int i = 1; i < this.dataLen; i++)
                    {
                        if (isnumber(texto2.Substring(i, 1)))
                        {
                            ret += texto2.Substring(i, 1);
                        }
                        if (texto2.Substring(i, 1) == "D")
                        {
                            return last;
                        }
                    }
                    if (Convert.ToDouble(ret) % 1 != 0)
                    {
                        ret = (Convert.ToDouble(ret) / 10).ToString(); 
                    }
                    
                    if (ret == "0")
                    {
                        ret = "0";
                    }
                    return ret;
                }
            }
            catch(Exception ex)
            {
                clsLog.addLog(ex,1,"getweigth");
                return last;
            }
        }


        public bool isnumber(string st)
        {
            switch (st)
            {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    return true;
                default:
                    return false;
            }
        }
    }
}