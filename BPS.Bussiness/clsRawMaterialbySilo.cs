using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsRawMaterialbySilo : IComparable<clsRawMaterialbySilo>
    {
        internal struct stcWeigthSilo
        {
            public string silo { get; set; }
            public double weigth { get; set; }
        }

        //Attributes
        private int rwbs_codsec;
        private int rwbs_fksilo;
        private string rwbs_code;
        private int rwbs_fkrawcodsec;
        private string rwbs_rawmaterialname;
        private string rwbs_lotnumber;
        private double rwbs_weigth;

        //Properties
        public int codsec { get { return rwbs_codsec; } set { rwbs_codsec = value; } }

        public int fksilo { get { return rwbs_fksilo; } set { rwbs_fksilo = value; } }

        public string code { get { return rwbs_code; } set { rwbs_code = value; } }

        public int fkrawcodsec { get { return rwbs_fkrawcodsec; } set { rwbs_fkrawcodsec = value; } }

        public string rawmaterialname { get { return rwbs_rawmaterialname; } set { rwbs_rawmaterialname = value; } }

        public string lotnumber { get { return rwbs_lotnumber; } set { rwbs_lotnumber = value; } }

        public double weigth { get { return rwbs_weigth; } set { rwbs_weigth = value; } }

        //Constructor
        public clsRawMaterialbySilo()
        {
            rwbs_codsec = 0;
            rwbs_fksilo = 0;
            rwbs_code = string.Empty;
            rwbs_fkrawcodsec = 0;
            rwbs_rawmaterialname = string.Empty;
            rwbs_lotnumber = string.Empty;
            rwbs_weigth = 0;
        }

        /*public clsRawMaterialbySilo(string code, bool ingress, bool output, bool devolution)
        {
            LoaderIngress(code, ingress, output, devolution);
        }*/

        public clsRawMaterialbySilo(int codsec)
        {
            load(codsec);
        }

        private void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT TOP(1) * FROM bps_prod_rawmaterialbysilo WHERE rwbs_codsec = " + codsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                rwbs_codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["rwbs_codsec"]);
                fksilo = Convert.ToInt32(DS.Tables[0].Rows[0]["rwbs_fksilo"]);
                code = DS.Tables[0].Rows[0]["rwbs_code"].ToString().ToUpper();
                fkrawcodsec = Convert.ToInt32(DS.Tables[0].Rows[0]["rwbs_fkrawcodsec"]);
                rawmaterialname = DS.Tables[0].Rows[0]["rwbs_rawmaterialname"].ToString();
                lotnumber = DS.Tables[0].Rows[0]["rwbs_lotnumber"].ToString();
                weigth = Convert.ToDouble(DS.Tables[0].Rows[0]["rwbs_weigth"]);
            }
        }

        /*private void LoaderIngress(string code, bool ingress, bool output, bool devolution)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT TOP(1) * FROM bps_prod_rawmaterialbycoilcellar WHERE rwmc_code = '" + code.ToUpper() + "' AND rwmc_in =" + ingress.ToString() + " AND rwmc_out = 0 AND rwmc_devolution = 0");

            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmc_codsec"]);
                fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmc_fkStatus"]);
                fkrawmaterial = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmc_fkrawmaterial"]);
                product = DS.Tables[0].Rows[0]["rwmc_rawmaterialproduct"].ToString();
                lotnumber = DS.Tables[0].Rows[0]["rwmc_lotnumber"].ToString();
                siigoCellar = DS.Tables[0].Rows[0]["rwmc_cellarsiigo"].ToString();
                siigoMovement = DS.Tables[0].Rows[0]["rwmc_movementsiigo"].ToString();
                bag = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmc_bag"]);
                ingress = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["rwmc_in"], DS.Tables[0].Rows[0]["rwmc_in"].GetType().FullName);
                output = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["rwmc_out"], DS.Tables[0].Rows[0]["rwmc_out"].GetType().FullName);
                devolution = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["rwmc_devolution"], DS.Tables[0].Rows[0]["rwmc_devolution"].GetType().FullName);
                code = DS.Tables[0].Rows[0]["rwmc_code"].ToString().ToUpper();
                netweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["rwmc_neetweigth"]);
                grossweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["rwmc_grossweigth"]);
                order = Convert.ToInt32(DS.Tables[0].Rows[0]["rwmc_order"]);
                provider = DS.Tables[0].Rows[0]["rwmc_provider"].ToString();
                date = Convert.ToDateTime(DS.Tables[0].Rows[0]["rwmc_date"]);
                movement = DS.Tables[0].Rows[0]["rwmc_movement"].ToString();
                notes = DS.Tables[0].Rows[0]["rwmc_notes"].ToString();
                isImport = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["rwmc_isImport"], DS.Tables[0].Rows[0]["rwmc_isImport"].GetType().FullName);
            }
        }*/

        public int CompareTo(clsRawMaterialbySilo b)
        {
            if (this.weigth > b.weigth)
            {
                return this.weigth.CompareTo(b.weigth);
            }
            return this.rawmaterialname.CompareTo(b.rawmaterialname);
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_rawmaterialbysilo (rwbs_fksilo, rwbs_code, rwbs_fkrawcodsec, rwbs_rawmaterialname, rwbs_lotnumber, rwbs_weigth)";
                    queryString += " VALUES (";
                    queryString += this.fksilo.ToString() + ", ";
                    queryString += "'" + this.code + "', ";
                    queryString += this.fkrawcodsec.ToString() + ", ";
                    queryString += "'" + this.rawmaterialname + "', ";
                    queryString += "'" + this.lotnumber + "', ";
                    queryString += this.weigth.ToString() + " ";
                    queryString += ");";
                }

                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsRawMaterialbySilo.save");
                return false;
            }
        }

        private static int getLastCodsecByCode(string code)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT MAX(rwbs_codsec) as codsec FROM bps_prod_rawmaterialbysilo WHERE rwbs_code = '" + code + "'");
            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(DS.Tables[0].Rows[0]["codsec"].ToString());
            else
                return 0;
        }

        public static int getLastCodsec()
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT MAX(rwbs_codsec) as codsec FROM bps_prod_rawmaterialbysilo");
            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(DS.Tables[0].Rows[0]["codsec"].ToString());
            else
                return 0;
        }

        public bool toUpdateData()
        {
            try
            {
                string queryString = "";
                queryString += "UPDATE bps_prod_rawmaterialbysilo SET rwbs_fkrawcodsec = " + this.fkrawcodsec + ", ";
                queryString += "rwbs_rawmaterialname = ' " + this.rawmaterialname.ToString() + "', ";
                queryString += "rwbs_lotnumber = '" + this.lotnumber.ToString() + "', ";
                queryString += "rwbs_weigth = " + this.weigth.ToString() +" ";
                queryString += "WHERE rwbs_codsec = " + this.codsec.ToString();

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsRawMaterialbySilo.toupdatedata");
                return false;
            }
        }

        public static bool validateMaterial(int rwcod, int silo)
        {
            bool result = false;
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spRawMaterialBySilo("+silo+")");
            if (DS.Tables[0].Rows.Count > 0)
            {
                DataSet DS2 = new DataSet();
                DS2 = clsConnection.getDataSetResult("CALL spRawTypeByCodsec("+rwcod+")");
                if (DS2.Tables[0].Rows.Count > 0)
                {
                    if(DS.Tables[0].Rows[0]["materialname"].ToString()==DS2.Tables[0].Rows[0]["type"].ToString())
                    {
                        result = true;
                    }
                }
            }
                
            return result;
        }

        public static List<clsRawMaterialbySilo> getList()
        {
            List<clsRawMaterialbySilo> Rawlist = new List<clsRawMaterialbySilo>();
            clsRawMaterialbySilo rawobj = new clsRawMaterialbySilo();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT TOP(1) * FROM bps_prod_rawmaterialbysilo");

            if (DS.Tables[0].Rows.Count > 0)
            { 
                for(int i=0; i<DS.Tables[0].Rows.Count;i++)
                {
                    rawobj.codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["rwbs_codsec"]);
                    rawobj.fksilo = Convert.ToInt32(DS.Tables[0].Rows[i]["rwbs_fksilo"]);
                    rawobj.code = DS.Tables[0].Rows[i]["rwbs_code"].ToString().ToUpper();
                    rawobj.fkrawcodsec = Convert.ToInt32(DS.Tables[0].Rows[i]["rwbs_fkrawcodsec"]);
                    rawobj.rawmaterialname = DS.Tables[0].Rows[i]["rwbs_rawmaterialname"].ToString();
                    rawobj.lotnumber = DS.Tables[0].Rows[i]["rwbs_lotnumber"].ToString();
                    rawobj.weigth = Convert.ToDouble(DS.Tables[0].Rows[i]["rwbs_weigth"]);
                    Rawlist.Add(rawobj);
                }
            }

            return Rawlist;
        }

        public static List<clsRawMaterialbySilo> getListTotalized()
        {
            List<clsRawMaterialbySilo> Rawlist = new List<clsRawMaterialbySilo>();
            clsRawMaterialbySilo rawobj;

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spRawMaterialBySiloTotalized");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    rawobj = new clsRawMaterialbySilo();
                    rawobj.codsec = i;
                    rawobj.fksilo = Convert.ToInt32(DS.Tables[0].Rows[i]["Silo"]);
                    rawobj.code = i.ToString();
                    rawobj.fkrawcodsec = i;
                    rawobj.lotnumber = i.ToString();
                    rawobj.rawmaterialname = DS.Tables[0].Rows[i]["Material"].ToString();
                    rawobj.weigth = Convert.ToDouble(DS.Tables[0].Rows[i]["Total"]);
                    Rawlist.Add(rawobj);
                }
            }

            return Rawlist;
        }

        public static clsRawMaterialbySilo getFirstInBySilo(string silo)
        {
            clsRawMaterialbySilo rawobj = new clsRawMaterialbySilo();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_rawmaterialbysilo");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    rawobj.codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["rwbs_codsec"]);
                    rawobj.fksilo = Convert.ToInt32(DS.Tables[0].Rows[i]["rwbs_fksilo"]);
                    rawobj.code = DS.Tables[0].Rows[i]["rwbs_code"].ToString().ToUpper();
                    rawobj.fkrawcodsec = Convert.ToInt32(DS.Tables[0].Rows[i]["rwbs_fkrawcodsec"]);
                    rawobj.rawmaterialname = DS.Tables[0].Rows[i]["rwbs_rawmaterialname"].ToString();
                    rawobj.lotnumber = DS.Tables[0].Rows[i]["rwbs_lotnumber"].ToString();
                    rawobj.weigth = Convert.ToDouble(DS.Tables[0].Rows[i]["rwbs_weigth"]);
                    if(rawobj.fksilo.ToString() == silo && rawobj.weigth > 0)
                    {
                        return rawobj;
                    }
                }
            }

            rawobj = new clsRawMaterialbySilo();
            return rawobj;
        }

    }
}
