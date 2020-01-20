using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BPS.Bussiness
{
    public class clsRecordProductionLaboratoryMw
    {
        //Atributes
        private int recprolabmw_codsec;
        private int recprolabmw_fkRecordProduction;
        private int recprolabmw_fkProductionOrder;
        private string recporlabmw_Seal;
        private string recprolabmw_SealCNT;
        private string recprolabmw_Glow;
        private string recprolabmw_GlowCNT;
        private string recprolabmw_Coefficient;
        private string recprolabmw_CoefficientCNT;
        private string recprolabmw_Superficial;
        
        //Properties
        
        public int recprolabmwcodsec { get { return recprolabmw_codsec; } set { recprolabmw_codsec = value; } }

        public int recprolabmwfkrecordproduction { get { return recprolabmw_fkRecordProduction; } set { recprolabmw_fkRecordProduction = value; } }

        public int recprolabmwfkproductionorder { get { return recprolabmw_fkProductionOrder; } set { recprolabmw_fkProductionOrder = value; } }

        public string sealmw { get { return recporlabmw_Seal; } set { recporlabmw_Seal = value; } }

        public string glowmw { get { return recprolabmw_Glow; } set { recprolabmw_Glow = value; } }

        public string coefficientmw { get { return recprolabmw_Coefficient; } set { recprolabmw_Coefficient = value; } }

        public string sealcntmw { get { return recprolabmw_SealCNT; } set { recprolabmw_SealCNT = value; } }

        public string glowcntmw { get { return recprolabmw_GlowCNT; } set { recprolabmw_GlowCNT = value; } }

        public string coefficientcntmw { get { return recprolabmw_CoefficientCNT; } set { recprolabmw_CoefficientCNT = value; } }

        public string superficialmw { get { return recprolabmw_Superficial; } set { recprolabmw_Superficial = value; } }
        
        //Constructor
        public clsRecordProductionLaboratoryMw()
        {
            recprolabmw_codsec = 0;
            recprolabmw_fkRecordProduction = 0;
            recprolabmw_fkProductionOrder = 0;
            recporlabmw_Seal = "";
            recprolabmw_Glow = "";
            recprolabmw_Coefficient = "";
            recprolabmw_SealCNT = "";
            recprolabmw_GlowCNT = "";
            recprolabmw_CoefficientCNT = "";
            recprolabmw_Superficial = "";
        }
        
        //Methods
        public bool save(string actions)
        {
            if (actions == "save")
            {
                try
                {
                    string queryString = "";

                    if (this.recprolabmwcodsec == 0)
                    {
                        queryString += "INSERT INTO bps_prod_recordproductionmwlaboratory (recprolabmw_fkRecordProduction, recprolabmw_fkProductionOrder, recprolabmw_Seal, recprolabmw_Glow, recprolabmw_Coefficient, recprolabmw_SealCNT, recprolabmw_GlowCNT, recprolabmw_CoefficientCNT, recprolabmw_Superficial) VALUES (";
                        queryString += this.recprolabmwfkrecordproduction.ToString() + ",";
                        queryString += this.recprolabmwfkproductionorder.ToString() + ",";
                        queryString += "'" + this.sealmw.ToString() + "',";
                        queryString += "'" + this.glowmw.ToString() + "',";
                        queryString += "'" + this.coefficientmw.ToString() + "',";
                        queryString += "'" + this.sealcntmw.ToString() + "',";
                        queryString += "'" + this.glowcntmw.ToString() + "',";
                        queryString += "'" + this.coefficientcntmw.ToString() + "',";
                        queryString += "'" + this.superficialmw.ToString() + "');";
                    }
                    else
                    {
                        queryString += "UPDATE bps_prod_recordproductionmwlaboratory SET recprolab_fkRecordProduction = " + this.recprolabmwfkrecordproduction.ToString();
                        queryString += ", recprolabmw_fkProductionOrder =" + this.recprolabmwfkproductionorder.ToString();
                        queryString += ", recporlabmw_Seal = '" + this.sealmw.ToString() + "'";
                        queryString += ", recprolabmw_Glow = '" + this.glowmw.ToString() + "'";
                        queryString += ", recprolabmw_Coefficient = '" + this.coefficientmw.ToString() + "'";
                        queryString += ", recporlabmw_SealCNT = '" + this.sealcntmw.ToString() + "'";
                        queryString += ", recprolabmw_GlowCNT = '" + this.glowcntmw.ToString() + "'";
                        queryString += ", recprolabmw_CoefficientCNT = '" + this.coefficientcntmw.ToString() + "'";
                        queryString += ", recprolabmw_Superficial = '" + this.superficialmw.ToString() + "'";
                        queryString += " WHERE recprolabmw_codsec = " + this.recprolabmwcodsec.ToString() + ";";
                    }
                    clsConnection.executeQuery(queryString);
                    return true;
                }
                catch (Exception ex)
                {
                    clsLog.addLog(ex, 3, "clsRecordProductionLaboratorymw.save");
                    return false;
                }
            }
            else
                return false;
        }

        public bool saves(string actions)
        {
            if (actions == "save")
            {
                try
                {
                    string queryString = "";

                    if (this.recprolabmwcodsec == 0)
                    {
                        queryString += "INSERT INTO bps_prod_recordproductionmwlaboratory (recprolabmw_fkRecordProduction, recprolabmw_fkProductionOrder, recprolabmw_Seal, recprolabmw_Glow, recprolabmw_Coefficient, recprolabmw_SealCNT, recprolabmw_GlowCNT, recprolabmw_CoefficientCNT, recprolabmw_Superficial) VALUES (";
                        queryString += this.recprolabmwfkrecordproduction.ToString() + ",";
                        queryString += this.recprolabmwfkproductionorder.ToString() + ",";
                        queryString += "'" + this.sealmw.ToString() + "',";
                        queryString += "'" + this.glowmw.ToString() + "',";
                        queryString += "'" + this.coefficientmw.ToString() + "',";
                        queryString += "'" + this.sealcntmw.ToString() + "',";
                        queryString += "'" + this.glowcntmw.ToString() + "',";
                        queryString += "'" + this.coefficientcntmw.ToString() + "',";
                        queryString += "'" + this.superficialmw.ToString() + "');";
                    }
                    if (clsConnection.executeQuery(queryString))
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    clsLog.addLog(ex, 3, "clsRecordProductionLaboratoryMw.save");
                    return false;
                }
            }
            else
                return false;
        }
    }
}
