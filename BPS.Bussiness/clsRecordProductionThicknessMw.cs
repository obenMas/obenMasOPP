using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BPS.Bussiness
{
    public class clsRecordProductionThicknessMw
    {
        //Atributes
        private int recprothimw_codsec;
        private int recprothimw_fkRecordProduction;
        private int recprothimw_fkProductionOrder;
        private double recprothimw_PreHeatCasting;
        private double recprothimw_Fd1fd2;
        private double recprothimw_Fd2tdo;
        private double recprothimw_Stretch;
        private double recprothimw_Coefficient;
        private double recprothimw_TolerancyPositive;
        private double recprothimw_TolerancyNegative;

        //Properties
        public int recprothimwcodsec { get { return recprothimw_codsec; } set { recprothimw_codsec = value; } }

        public int recprothimwfkrecordproduction { get { return recprothimw_fkRecordProduction; } set { recprothimw_fkRecordProduction = value; } }

        public int recprothimwfkproductionorder { get { return recprothimw_fkProductionOrder; } set { recprothimw_fkProductionOrder = value; } }

        public double preheatcasting { get { return recprothimw_PreHeatCasting; } set { recprothimw_PreHeatCasting = value; } }

        public double fd1fd2 { get { return recprothimw_Fd1fd2; } set { recprothimw_Fd1fd2 = value; } }

        public double fd2tdo { get { return recprothimw_Fd2tdo; } set { recprothimw_Fd2tdo = value; } }

        public double stretchmw { get { return recprothimw_Stretch; } set { recprothimw_Stretch = value; } }

        public double coefficientthicknessmw { get { return recprothimw_Coefficient; } set { recprothimw_Coefficient = value; } }

        public double tolerancypositivemw { get { return recprothimw_TolerancyPositive; } set { recprothimw_TolerancyPositive = value; } }

        public double tolerancynegativemw { get { return recprothimw_TolerancyNegative; } set { recprothimw_TolerancyNegative = value; } }

        //Constructor
        public clsRecordProductionThicknessMw()
        {
            recprothimw_codsec = 0;
            recprothimw_fkRecordProduction = 0;
            recprothimw_fkProductionOrder = 0;
            recprothimw_PreHeatCasting = 0;
            recprothimw_Fd1fd2 = 0;
            recprothimw_Fd2tdo = 0;
            recprothimw_Stretch = 0;
            recprothimw_Coefficient = 0;
            recprothimw_TolerancyPositive = 0;
            recprothimw_TolerancyNegative = 0;
        }
        //Method
        public bool save(string actions)
        {
            if (actions == "save")
            {
                try
                {
                    string queryString = "";

                    if (this.recprothimwcodsec == 0)
                    {
                        queryString += "INSERT INTO bps_prod_recordproductionmwthickness (recprothimw_fkRecordProduction, recprothimw_fkProductionOrder, recprothimw_PreHeatCasting, recprothimw_Fd1fd2, recprothimw_Fd2tdo, recprothimw_Strecth, recprothimw_Coeffiecient, recprothimw_TolerancyPositive, recprothimw_TolerancyNegative)  VALUES (";
                        queryString += this.recprothimwfkrecordproduction.ToString() + ",";
                        queryString += this.recprothimwfkproductionorder.ToString() + ",";
                        queryString += this.preheatcasting.ToString() + ",";
                        queryString += this.fd1fd2.ToString() + ",";
                        queryString += this.fd2tdo.ToString() + ",";
                        queryString += this.stretchmw.ToString() + ",";
                        queryString += this.coefficientthicknessmw.ToString() + ",";
                        queryString += this.tolerancypositivemw.ToString() + ",";
                        queryString += this.tolerancynegativemw.ToString() + ");";
                    }
                    else
                    {
                        queryString += "UPDATE bps_prod_recordproductionmwthickness SET recprothimw_fkRecordProduction = " + this.recprothimwfkrecordproduction.ToString();
                        queryString += ", recprothimw_fkProductionOrder =" + this.recprothimwfkproductionorder.ToString();
                        queryString += ", recprothimw_PreHeatCasting = " + this.preheatcasting.ToString();
                        queryString += ", recprothimw_Fd1fd2 = " + this.fd1fd2.ToString();
                        queryString += ", recprothimw_Fd2tdo = " + this.fd2tdo.ToString();
                        queryString += ", recprothimw_Strecth = " + this.stretchmw.ToString();
                        queryString += ", recprothimw_Coeffiecient = " + this.coefficientthicknessmw.ToString();
                        queryString += ", recprothimw_TolerancyPositive = " + this.tolerancypositivemw.ToString();
                        queryString += ", recprothimw_TolerancyNegative = " + this.tolerancynegativemw.ToString();
                        queryString += " WHERE recprothi_codsec = " + this.recprothimwcodsec.ToString() + ";";
                    }
                    if (clsConnection.executeQuery(queryString))
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    clsLog.addLog(ex, 3, "clsRecordProductionThicknessMw.save");
                    return false;
                }
            }
            else
                return false;
        }
    }
}
