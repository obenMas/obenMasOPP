using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BPS.Bussiness
{
    public class clsRecordProductionLaboratory
    {
        //Atributes
        private clsRecordProductionMdo RecordProductionMdo;
        private int recprolab_codsec;
        private int recprolab_fkRecordProduction;
        private int recprolab_fkProductionOrder;
        private string recporlab_Seal;
        private string recprolab_SealCNT;
        private string recprolab_Glow;
        private string recprolab_GlowCNT;
        private string recprolab_Coefficient;
        private string recprolab_CoefficientCNT;
        private string recprolab_Superficial;

        private string recprolab_Transmitance;
        private string recprolab_Haze;
        
        //Properties
        public clsRecordProductionMdo recordproductionmdo { get { return RecordProductionMdo; } set { RecordProductionMdo = value; } }
        
        public int recprolabcodsec { get { return recprolab_codsec; } set { recprolab_codsec = value; } }

        public int recprolabfkrecordproduction { get { return recprolab_fkRecordProduction; } set { recprolab_fkRecordProduction = value; } }

        public int recprolabfkproductionorder { get { return recprolab_fkProductionOrder; } set { recprolab_fkProductionOrder = value; } }

        public string seal { get { return recporlab_Seal; } set { recporlab_Seal = value; } }

        public string glow { get { return recprolab_Glow; } set { recprolab_Glow = value; } }

        public string coefficient { get { return recprolab_Coefficient; } set { recprolab_Coefficient = value; } }

        public string sealcnt { get { return recprolab_SealCNT; } set { recprolab_SealCNT = value; } }

        public string glowcnt { get { return recprolab_GlowCNT; } set { recprolab_GlowCNT = value; } }

        public string coefficientcnt { get { return recprolab_CoefficientCNT; } set { recprolab_CoefficientCNT = value; } }

        public string superficial { get { return recprolab_Superficial; } set { recprolab_Superficial = value; } }

        public string transmitance { get { return recprolab_Transmitance; } set { recprolab_Transmitance = value; } }

        public string haze { get { return recprolab_Haze; } set { recprolab_Haze = value; } }
        
        //Constructor
        public clsRecordProductionLaboratory()
        {
            recordproductionmdo = new clsRecordProductionMdo();
            recprolab_codsec = 0;
            recprolab_fkRecordProduction = 0;
            recprolab_fkProductionOrder = 0;
            recporlab_Seal = "";
            recprolab_Glow = "";
            recprolab_Coefficient = "";
            recprolab_SealCNT = "";
            recprolab_GlowCNT = "";
            recprolab_CoefficientCNT = "";
            recprolab_Superficial = "";
            recprolab_Haze = "";
            recprolab_Transmitance = "";
        }
        
        //Methods
        public bool save(string actions)
        {
            if (actions == "save")
            {
                try
                {
                    string queryString = "";

                    if (this.recprolabcodsec == 0)
                    {
                        queryString += "INSERT INTO bps_prod_recordproductionlaboratory (recprolab_fkRecordProduction, recprolab_fkProductionOrder, recprolab_Seal, recprolab_Glow, recprolab_Coefficient, recprolab_SealCNT, recprolab_GlowCNT, recprolab_CoefficientCNT, recprolab_Superficial) VALUES (";
                        queryString += this.recprolabfkrecordproduction.ToString() + ",";
                        queryString += this.recprolabfkproductionorder.ToString() + ",";
                        queryString += "'" + this.seal.ToString() + "',";
                        queryString += "'" + this.glow.ToString() + "',";
                        queryString += "'" + this.coefficient.ToString() + "',";
                        queryString += "'" + this.sealcnt.ToString() + "',";
                        queryString += "'" + this.glowcnt.ToString() + "',";
                        queryString += "'" + this.coefficientcnt.ToString() + "',";
                        queryString += "'" + this.superficial.ToString() + "');";
                    }
                    else
                    {
                        queryString += "UPDATE bps_prod_recordproductionlaboratory SET recprolab_fkRecordProduction = " + this.recprolabfkrecordproduction.ToString();
                        queryString += ", recprolab_fkProductionOrder =" + this.recprolabfkproductionorder.ToString();
                        queryString += ", recporlab_Seal = '" + this.seal.ToString() + "'";
                        queryString += ", recprolab_Glow = '" + this.glow.ToString() + "'";
                        queryString += ", recprolab_Coefficient = '" + this.coefficient.ToString() + "'";
                        queryString += ", recporlab_SealCNT = '" + this.sealcnt.ToString() + "'";
                        queryString += ", recprolab_GlowCNT = '" + this.glowcnt.ToString() + "'";
                        queryString += ", recprolab_CoefficientCNT = '" + this.coefficientcnt.ToString() + "'";
                        queryString += ", recprolab_Superficial = '" + this.superficial.ToString() + "'";
                        queryString += " WHERE recprolab_codsec = " + this.recprolabcodsec.ToString() + ";";
                    }
                    clsConnection.executeQuery(queryString);
                    recordproductionmdo.save("save");
                    return true;
                }
                catch (Exception ex)
                {
                    clsLog.addLog(ex, 3, "clsRecordProductionLaboratory.save");
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

                    if (this.recprolabcodsec == 0)
                    {
                        queryString += "INSERT INTO bps_prod_recordproductionlaboratory (recprolab_fkRecordProduction, recprolab_fkProductionOrder, recprolab_Seal, recprolab_Glow, recprolab_Coefficient, recprolab_Superficial, recprolab_SealCNT, recprolab_GlowCNT, recprolab_CoefficientCNT, recprolab_Transmitance, recprolab_Haze) VALUES (";
                        queryString += this.recprolabfkrecordproduction.ToString() + ",";
                        queryString += this.recprolabfkproductionorder.ToString() + ",";
                        queryString += "'" + this.seal.ToString() + "',";
                        queryString += "'" + this.glow.ToString() + "',";
                        queryString += "'" + this.coefficient.ToString() + "',";
                        queryString += "'" + this.superficial.ToString() + "',";
                        queryString += "'" + this.sealcnt.ToString() + "',";
                        queryString += "'" + this.glowcnt.ToString() + "',";
                        queryString += "'" + this.coefficientcnt.ToString() + "',";
                        queryString += "'" + this.transmitance.ToString() + "',";
                        queryString += "'" + this.haze.ToString() + "');";
                    }
                    if (clsConnection.executeQuery(queryString))
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    clsLog.addLog(ex, 3, "clsRecordProductionLaboratory.save");
                    return false;
                }
            }
            else
                return false;
        }
    }
}
