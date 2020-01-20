using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;



namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra los parametros de peso y metraje peliculas BOPP/Cast/Coating 
    /// </summary>
    public class clsParameters
    {
        //Atributes

        private int prm_codsec;
        private int prm_fkBopp;
        private int prm_fkCast;
        private string prm_BoppName;
        private int prm_fkDiameter;
        private double prm_DiameterValue;
        private string prm_DiameterName;
        private int prm_fkCore;
        private int prm_CoreValue;
        private double prm_weightFactor;
        private double prm_aproxLength;

        //Properties

        public int codsec { get { return prm_codsec; } set { prm_codsec = value; } }

        public int fkBopp { get { return prm_fkBopp; } set { prm_fkBopp = value; } }

        public int fkCast { get { return prm_fkCast; } set { prm_fkCast = value; } }

        public string BoppName { get { return prm_BoppName; } set { prm_BoppName = value; } }

        public int fkDiameter { get { return prm_fkDiameter; } set { prm_fkDiameter = value; } }

        public double DiameterValue { get { return prm_DiameterValue; } set { prm_DiameterValue = value; } }

        public int fkCore { get { return prm_fkCore; } set { prm_fkCore = value; } }

        public int CoreValue { get { return prm_CoreValue; } set { prm_CoreValue = value; } }

        public double weightFactor { get { return prm_weightFactor; } set { prm_weightFactor = value; } }

        public double aproxLength { get { return prm_aproxLength; } set { prm_aproxLength = value; } }

        public string DiameterName { get { return prm_DiameterName; } set { prm_DiameterName = value; } }



        //Constructor

        public clsParameters()
        {
            prm_codsec = 0;
            prm_fkBopp = 0;
            prm_fkCast = 0;
            prm_BoppName = "";
            prm_fkDiameter = 0;
            prm_DiameterValue = 0;
            prm_fkCore = 0;
            prm_CoreValue = 0;
            prm_weightFactor = 0;
            prm_aproxLength = 0;
            prm_DiameterName = string.Empty;
        }

        public clsParameters(int codsec)
        {
            this.load(codsec);
        }
        //Methods

        public void load(int codsec)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwParameters where prm_codsec = " + codsec.ToString());

            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_codsec"]);
            this.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkBopp"]);
            this.fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkCast"]);
            this.BoppName = DS.Tables[0].Rows[0]["prm_BoppName"].ToString();
            this.fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkDiameter"]);
            this.DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[0]["prm_DiameterValue"]);
            this.fkCore = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkCore"]);
            this.CoreValue = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_CoreValue"]);
            this.weightFactor = Convert.ToDouble(DS.Tables[0].Rows[0]["prm_weightFactor"]);
            this.aproxLength = Convert.ToDouble(DS.Tables[0].Rows[0]["prm_aproxLength"]);

        }

        public bool save()
        {
            try
            {
                string queryString = "";


                if (this.codsec == 0)
                {
                    if (this.fkBopp > 0)
                    {
                        queryString += "INSERT INTO bps_prod_parameters (prm_fkBopp,prm_fkDiameter,prm_fkCore,prm_weightFactor,prm_aproxLength)";
                        queryString += " VALUES (";
                        queryString += this.fkBopp.ToString() + ",";
                        queryString += this.fkDiameter.ToString() + ",";
                        queryString += this.fkCore.ToString() + ",";
                        queryString += this.weightFactor.ToString() + ",";
                        queryString += this.aproxLength.ToString() + "";
                        queryString += ");";
                    }
                    else
                    {
                        queryString += "INSERT INTO bps_prod_parameters (prm_fkCast,prm_fkDiameter,prm_fkCore,prm_weightFactor,prm_aproxLength)";
                        queryString += " VALUES (";
                        queryString += this.fkCast.ToString() + ",";
                        queryString += this.fkDiameter.ToString() + ",";
                        queryString += this.fkCore.ToString() + ",";
                        queryString += this.weightFactor.ToString() + ",";
                        queryString += this.aproxLength.ToString() + "";
                        queryString += ");";
                    }
                    if (clsConnection.executeQuery(queryString))
                        return true;
                    else
                        return false;
                }
                else
                {
                    if (this.fkBopp > 0)
                    {
                        queryString += "UPDATE bps_prod_parameters";
                        queryString += " SET ";
                        queryString += "prm_fkBopp = " + this.fkBopp.ToString() + ",";
                        queryString += "prm_fkDiameter = " + this.fkDiameter.ToString() + ",";
                        queryString += "prm_fkCore = " + this.fkCore.ToString() + ",";
                        queryString += "prm_weightFactor = " + this.weightFactor.ToString() + ",";
                        queryString += "prm_aproxLength = " + this.aproxLength.ToString() + "";
                        queryString += " WHERE prm_codsec = " + this.codsec.ToString();
                    }
                    else
                    {
                        queryString += "UPDATE bps_prod_parameters";
                        queryString += " SET ";
                        queryString += "prm_fkCast = " + this.fkCast.ToString() + ",";
                        queryString += "prm_fkDiameter = " + this.fkDiameter.ToString() + ",";
                        queryString += "prm_fkCore = " + this.fkCore.ToString() + ",";
                        queryString += "prm_weightFactor = " + this.weightFactor.ToString() + ",";
                        queryString += "prm_aproxLength = " + this.aproxLength.ToString() + "";
                        queryString += " WHERE prm_codsec = " + this.codsec.ToString();
                    }
                    if (clsConnection.executeQuery(queryString))
                        return true;
                    else
                        return false;
                }
            }


            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsParameters.save");
                return false;
            }

        }

        public static List<clsParameters> getList()
        {
            List<clsParameters> lstParameters = new List<clsParameters>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_parameters order by prm_name asc");

            lstParameters.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstParameters.Add(new clsParameters());
                lstParameters[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["prm_codsec"]);
                lstParameters[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["prm_fkBopp"]);
                lstParameters[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["prm_fkCast"]);
                lstParameters[i].fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[i]["prm_fkDiameter"]);
                lstParameters[i].fkCore = Convert.ToInt32(DS.Tables[0].Rows[i]["prm_fkCore"]);
                lstParameters[i].weightFactor = Convert.ToInt32(DS.Tables[0].Rows[i]["prm_weightFactor"]);
                lstParameters[i].aproxLength = Convert.ToInt32(DS.Tables[0].Rows[i]["prm_aproxLength"]);
            }

            return lstParameters;
        }

        public static List<clsParameters> getListByFilm()
        {
            List<clsParameters> lstParameters = new List<clsParameters>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spParametersByFilm");

            lstParameters.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstParameters.Add(new clsParameters());
                lstParameters[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["prm_fkBopp"]);
                lstParameters[i].BoppName = DS.Tables[0].Rows[i]["bopp_code"].ToString();
            }
            return lstParameters;
        }

        public static List<clsParameters> getListByFilmCodsec(int codsec)
        {
            List<clsParameters> lstParameters = new List<clsParameters>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spParametersByFilmCodsec('" + codsec.ToString() + "')");

            lstParameters.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstParameters.Add(new clsParameters());
                lstParameters[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["prm_codsec"]);
                lstParameters[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["prm_fkBopp"]);
                lstParameters[i].BoppName = DS.Tables[0].Rows[i]["prm_BoppName"].ToString();
                lstParameters[i].fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[i]["prm_fkDiameter"]);
                lstParameters[i].DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[i]["prm_DiameterValue"]);
                lstParameters[i].DiameterName = DS.Tables[0].Rows[i]["prm_DiameterName"].ToString();
                lstParameters[i].fkCore = Convert.ToInt32(DS.Tables[0].Rows[i]["prm_fkCore"]);
                lstParameters[i].CoreValue = Convert.ToInt32(DS.Tables[0].Rows[i]["prm_CoreValue"]);
                lstParameters[i].weightFactor = Convert.ToDouble(DS.Tables[0].Rows[i]["prm_weightFactor"]);
                lstParameters[i].aproxLength = Convert.ToInt32(DS.Tables[0].Rows[i]["prm_aproxLength"]);
            }

            return lstParameters;
        }

        public static List<clsParameters> getBoppListWithParameters()
        {
            List<clsParameters> lstParameters = new List<clsParameters>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwboppfilmwithparameters");

            lstParameters.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstParameters.Add(new clsParameters());
                lstParameters[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["prm_codsec"]);
                lstParameters[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["prm_fkBopp"]);
                //lstParameters[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["prm_fkCast"]);
                lstParameters[i].BoppName = DS.Tables[0].Rows[i]["prm_BoppName"].ToString();
                lstParameters[i].fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[i]["prm_fkDiameter"]);
                lstParameters[i].DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[i]["prm_DiameterValue"]);
                lstParameters[i].fkCore = Convert.ToInt32(DS.Tables[0].Rows[i]["prm_fkCore"]);
                lstParameters[i].CoreValue = Convert.ToInt32(DS.Tables[0].Rows[i]["prm_CoreValue"]);
                lstParameters[i].weightFactor = Convert.ToDouble(DS.Tables[0].Rows[i]["prm_weightFactor"]);
                lstParameters[i].aproxLength = Convert.ToDouble(DS.Tables[0].Rows[i]["prm_aproxLength"]);
            }

            return lstParameters;
        }

        public static double getCoilsNumberByWidthAndWeigth(int boppCodsec, int castCodsec, int diameterCodsec, int coreCodsec, double width, double weigth)
        {
            clsParameters objParameters = new clsParameters();
            DataSet DS = new DataSet();

            if (boppCodsec != 0)
            {
                string query = "SELECT * FROM vwparameters where prm_fkBopp = " + boppCodsec.ToString() + " and prm_fkDiameter = " + diameterCodsec.ToString() + " and prm_fkCore = " + coreCodsec.ToString();
                DS = clsConnection.getDataSetResult(query);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    objParameters.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_codsec"]);
                    objParameters.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkBopp"]);
                    objParameters.fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkCast"]);
                    objParameters.BoppName = DS.Tables[0].Rows[0]["prm_BoppName"].ToString();
                    objParameters.fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkDiameter"]);
                    objParameters.DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[0]["prm_DiameterValue"]);
                    objParameters.fkCore = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkCore"]);
                    objParameters.CoreValue = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_CoreValue"]);
                    objParameters.weightFactor = Convert.ToDouble(DS.Tables[0].Rows[0]["prm_weightFactor"]);
                    objParameters.aproxLength = Convert.ToDouble(DS.Tables[0].Rows[0]["prm_aproxLength"]);
                }
                
                return Math.Round((weigth / ((width / 10) * objParameters.weightFactor)), 1);

            }
            else
            {
                DS = clsConnection.getDataSetResult("SELECT * FROM vwparameters where prm_fkCast = " + castCodsec.ToString() + " and prm_fkDiameter = " + diameterCodsec.ToString() + " and prm_fkCore = " + coreCodsec.ToString());
                if (DS.Tables[0].Rows.Count > 0)
                {
                    objParameters.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_codsec"]);
                    objParameters.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkBopp"]);
                    objParameters.fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkCast"]);
                    objParameters.BoppName = DS.Tables[0].Rows[0]["prm_BoppName"].ToString();
                    objParameters.fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkDiameter"]);
                    objParameters.DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[0]["prm_DiameterValue"]);
                    objParameters.fkCore = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkCore"]);
                    objParameters.CoreValue = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_CoreValue"]);
                    objParameters.weightFactor = Convert.ToDouble(DS.Tables[0].Rows[0]["prm_weightFactor"]);
                    objParameters.aproxLength = Convert.ToDouble(DS.Tables[0].Rows[0]["prm_aproxLength"]);
                }
                return Math.Round((weigth / ((width / 10) * objParameters.weightFactor)), 1);
            }
        }
        public static double getAproxLengthByWidthAndWeigth(int boppCodsec, int diameterCodsec, int coreCodsec)
        {
            clsParameters objParameters = new clsParameters();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwParameters where prm_fkBopp = " + boppCodsec.ToString() + " and prm_fkDiameter = " + diameterCodsec.ToString() + " and prm_fkCore = " + coreCodsec.ToString());
            if (DS.Tables[0].Rows.Count > 0)
            {
                objParameters.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_codsec"]);
                objParameters.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkBopp"]);
                objParameters.fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkCast"]);
                objParameters.BoppName = DS.Tables[0].Rows[0]["prm_BoppName"].ToString();
                objParameters.fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkDiameter"]);
                objParameters.DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[0]["prm_DiameterValue"]);
                objParameters.fkCore = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkCore"]);
                objParameters.CoreValue = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_CoreValue"]);
                objParameters.weightFactor = Convert.ToDouble(DS.Tables[0].Rows[0]["prm_weightFactor"]);
                objParameters.aproxLength = Convert.ToDouble(DS.Tables[0].Rows[0]["prm_aproxLength"]);
            }
            return objParameters.aproxLength;
        }
        public static double getCoilsNumberByWidthAndWeigth(int productCodsec, double weigth)
        {
            clsParameters objParameters = new clsParameters();
            DataSet DS = new DataSet();
            clsProduct objProduct = new clsProduct(productCodsec);
                        
            if (objProduct.Bopp.codsec != 0)
            {
                DS = clsConnection.getDataSetResult("SELECT * FROM vwParameters where prm_fkBopp = " + objProduct.Bopp.codsec.ToString() + " and prm_fkDiameter = " + objProduct.fkDiameter.ToString() + " and prm_fkCore = " + objProduct.fkCore.ToString());
                if (DS.Tables[0].Rows.Count > 0)
                {
                    objParameters.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_codsec"]);
                    objParameters.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkBopp"]);
                    objParameters.fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkCast"]);
                    objParameters.BoppName = DS.Tables[0].Rows[0]["prm_BoppName"].ToString();
                    objParameters.fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkDiameter"]);
                    objParameters.DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[0]["prm_DiameterValue"]);
                    objParameters.fkCore = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkCore"]);
                    objParameters.CoreValue = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_CoreValue"]);
                    objParameters.weightFactor = Convert.ToDouble(DS.Tables[0].Rows[0]["prm_weightFactor"]);
                    objParameters.aproxLength = Convert.ToDouble(DS.Tables[0].Rows[0]["prm_aproxLength"]);
                }
                if (objParameters.weightFactor == 0)
                    objParameters.weightFactor = 1;

                if (objParameters.DiameterValue != 30)
                    return Math.Ceiling((weigth / ((objProduct.width / 10) * objParameters.weightFactor)));
                else if (objParameters.DiameterValue != 76.5)
                    return Math.Ceiling((weigth / ((objProduct.width / 10) * objParameters.weightFactor))) + 1;
                else
                    return Math.Ceiling((weigth / ((objProduct.width / 10) * objParameters.weightFactor))) * 3;

            }
            else
            {
                DS = clsConnection.getDataSetResult("SELECT * FROM vwParameters where prm_fkCast = " + objProduct.Cast.codsec.ToString() + " and prm_fkDiameter = " + objProduct.fkDiameter.ToString() + " and prm_fkCore = " + objProduct.fkCore.ToString());
                if (DS.Tables[0].Rows.Count > 0)
                {
                    objParameters.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_codsec"]);
                    objParameters.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkBopp"]);
                    objParameters.fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkCast"]);
                    objParameters.BoppName = DS.Tables[0].Rows[0]["prm_BoppName"].ToString();
                    objParameters.fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkDiameter"]);
                    objParameters.DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[0]["prm_DiameterValue"]);
                    objParameters.fkCore = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkCore"]);
                    objParameters.CoreValue = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_CoreValue"]);
                    objParameters.weightFactor = Convert.ToDouble(DS.Tables[0].Rows[0]["prm_weightFactor"]);
                    objParameters.aproxLength = Convert.ToDouble(DS.Tables[0].Rows[0]["prm_aproxLength"]);
                }
                if (objParameters.weightFactor == 0)
                    objParameters.weightFactor = 1;

                if (objParameters.DiameterValue != 30)
                    return Math.Ceiling((weigth / ((objProduct.width / 10) * 1.92)));
                else if (objParameters.DiameterValue != 76.5)
                    return Math.Ceiling((weigth / ((objProduct.width / 10) * 1.92))) + 1;
                else
                    return Math.Ceiling((weigth / ((objProduct.width / 10) * 1.92))) * 3;
            }
        }
        public static clsParameters getParameterByProduct(int productCodsec)
        {
            clsParameters objParameters = new clsParameters();
            DataSet DS = new DataSet();
            clsProduct objProduct = new clsProduct(productCodsec);

            

            if (objProduct.Bopp.codsec != 0)
            {
                DS = clsConnection.getDataSetResult("SELECT * FROM vwParameters where prm_fkBopp = " + objProduct.Bopp.codsec.ToString() + " and prm_fkDiameter = " + objProduct.fkDiameter.ToString() + " and prm_fkCore = " + objProduct.fkCore.ToString());

                if (DS.Tables[0].Rows.Count > 0)
                {
                    objParameters.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_codsec"]);
                    objParameters.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkBopp"]);
                    objParameters.fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkCast"]);
                    objParameters.BoppName = DS.Tables[0].Rows[0]["prm_BoppName"].ToString();
                    objParameters.fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkDiameter"]);
                    objParameters.DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[0]["prm_DiameterValue"]);
                    objParameters.fkCore = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkCore"]);
                    objParameters.CoreValue = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_CoreValue"]);
                    objParameters.weightFactor = Convert.ToDouble(DS.Tables[0].Rows[0]["prm_weightFactor"]);
                    objParameters.aproxLength = Convert.ToDouble(DS.Tables[0].Rows[0]["prm_aproxLength"]);
                }
            }
            else
            {
                DS = clsConnection.getDataSetResult("SELECT * FROM vwParameters where prm_fkCast = " + objProduct.Cast.codsec.ToString() + " and prm_fkDiameter = " + objProduct.fkDiameter.ToString() + " and prm_fkCore = " + objProduct.fkCore.ToString());

                if (DS.Tables[0].Rows.Count > 0)
                {
                    objParameters.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_codsec"]);
                    objParameters.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkBopp"]);
                    objParameters.fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkCast"]);
                    objParameters.BoppName = DS.Tables[0].Rows[0]["prm_BoppName"].ToString();
                    objParameters.fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkDiameter"]);
                    objParameters.DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[0]["prm_DiameterValue"]);
                    objParameters.fkCore = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkCore"]);
                    objParameters.CoreValue = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_CoreValue"]);
                    objParameters.weightFactor = Convert.ToDouble(DS.Tables[0].Rows[0]["prm_weightFactor"]);
                    objParameters.aproxLength = Convert.ToDouble(DS.Tables[0].Rows[0]["prm_aproxLength"]);
                }
            }
            return objParameters;
        }
        public static double getWeigthByCoilsNumberAndWidth(int boppCodsec, int castCodsec, int diameterCodsec, int coreCodsec, double width, int coilsNumber)
        {
            clsParameters objParameters = new clsParameters();
            DataSet DS = new DataSet();
            if (boppCodsec > 0)
            {
                DS = clsConnection.getDataSetResult("SELECT * FROM vwParameters where prm_fkBopp = " + boppCodsec.ToString() + " and prm_fkDiameter = " + diameterCodsec.ToString() + " and prm_fkCore = " + coreCodsec.ToString());
                if (DS.Tables[0].Rows.Count > 0)
                {
                    objParameters.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_codsec"]);
                    objParameters.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkBopp"]);
                    objParameters.fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkCast"]);
                    objParameters.BoppName = DS.Tables[0].Rows[0]["prm_BoppName"].ToString();
                    objParameters.fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkDiameter"]);
                    objParameters.DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[0]["prm_DiameterValue"]);
                    objParameters.fkCore = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkCore"]);
                    objParameters.CoreValue = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_CoreValue"]);
                    objParameters.weightFactor = Convert.ToDouble(DS.Tables[0].Rows[0]["prm_weightFactor"]);
                    objParameters.aproxLength = Convert.ToDouble(DS.Tables[0].Rows[0]["prm_aproxLength"]);
                }
            }
            else
            {
                DS = clsConnection.getDataSetResult("SELECT * FROM vwParameters where prm_fkCast = " + castCodsec.ToString() + " and prm_fkDiameter = " + diameterCodsec.ToString() + " and prm_fkCore = " + coreCodsec.ToString());
                if (DS.Tables[0].Rows.Count > 0)
                {
                    objParameters.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_codsec"]);
                    objParameters.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkBopp"]);
                    objParameters.fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkCast"]);
                    objParameters.BoppName = DS.Tables[0].Rows[0]["prm_BoppName"].ToString();
                    objParameters.fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkDiameter"]);
                    objParameters.DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[0]["prm_DiameterValue"]);
                    objParameters.fkCore = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkCore"]);
                    objParameters.CoreValue = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_CoreValue"]);
                    objParameters.weightFactor = Convert.ToDouble(DS.Tables[0].Rows[0]["prm_weightFactor"]);
                    objParameters.aproxLength = Convert.ToDouble(DS.Tables[0].Rows[0]["prm_aproxLength"]);
                }
            }
            if (objParameters.DiameterValue != 30)
                return Math.Round((coilsNumber * ((width / 10) * objParameters.weightFactor)), 2);
            else
                return Math.Round((coilsNumber * ((width / 10) * objParameters.weightFactor)), 2) * 3;
        }

        public static int getCoilNumber(int productCodsec, double quantity)
        {
            clsParameters objParameters = new clsParameters();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT COALESCE(dbo.fnGetCoilNumber(" + productCodsec.ToString() + "," + quantity.ToString() + "),0) AS TotalCoil");
            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["TotalCoil"]), 1, MidpointRounding.AwayFromZero));
            else
                return 0;
        }

        public static double getWeigthByProduct(int productCodsec)
        {
            clsParameters objParameters = new clsParameters();
            DataSet DS = new DataSet();
            clsProduct objProduct = new clsProduct(productCodsec);

            if (objProduct.Bopp.codsec != 0)
            {
                DS = clsConnection.getDataSetResult("SELECT * FROM vwParameters where prm_fkBopp = " + objProduct.Bopp.codsec.ToString() + " and prm_fkDiameter = " + objProduct.fkDiameter.ToString() + " and prm_fkCore = " + objProduct.fkCore.ToString());
                if (DS.Tables[0].Rows.Count > 0)
                {
                    objParameters.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_codsec"]);
                    objParameters.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkBopp"]);
                    objParameters.fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkCast"]);
                    objParameters.BoppName = DS.Tables[0].Rows[0]["prm_BoppName"].ToString();
                    objParameters.fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkDiameter"]);
                    objParameters.DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[0]["prm_DiameterValue"]);
                    objParameters.fkCore = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkCore"]);
                    objParameters.CoreValue = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_CoreValue"]);
                    objParameters.weightFactor = Convert.ToDouble(DS.Tables[0].Rows[0]["prm_weightFactor"]);
                    objParameters.aproxLength = Convert.ToDouble(DS.Tables[0].Rows[0]["prm_aproxLength"]);
                }
                if (objParameters.weightFactor == 0)
                    objParameters.weightFactor = 1;

                return Math.Round(((objProduct.width / 10) * objParameters.weightFactor),2,MidpointRounding.AwayFromZero);
            }
            else
            {
                DS = clsConnection.getDataSetResult("SELECT * FROM vwParameters where prm_fkCast = " + objProduct.Cast.codsec.ToString() + " and prm_fkDiameter = " + objProduct.fkDiameter.ToString() + " and prm_fkCore = " + objProduct.fkCore.ToString());
                if (DS.Tables[0].Rows.Count > 0)
                {
                    objParameters.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_codsec"]);
                    objParameters.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkBopp"]);
                    objParameters.fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkCast"]);
                    objParameters.BoppName = DS.Tables[0].Rows[0]["prm_BoppName"].ToString();
                    objParameters.fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkDiameter"]);
                    objParameters.DiameterValue = Convert.ToDouble(DS.Tables[0].Rows[0]["prm_DiameterValue"]);
                    objParameters.fkCore = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_fkCore"]);
                    objParameters.CoreValue = Convert.ToInt32(DS.Tables[0].Rows[0]["prm_CoreValue"]);
                    objParameters.weightFactor = Convert.ToDouble(DS.Tables[0].Rows[0]["prm_weightFactor"]);
                    objParameters.aproxLength = Convert.ToDouble(DS.Tables[0].Rows[0]["prm_aproxLength"]);
                }
                if (objParameters.weightFactor == 0)
                    objParameters.weightFactor = 1;

                return Math.Round(((objProduct.width / 10) * objParameters.weightFactor), 2, MidpointRounding.AwayFromZero);
            }
        }

        public override string ToString()
        {
            return this.BoppName;
        }
    }
}