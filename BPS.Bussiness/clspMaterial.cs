using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clspMaterial
    {
        //Attribute

        private int pm_codsec;
        private int pm_fkType;
        private int pm_fkSupplier;
        private string pm_code;
        private int pm_fkUnit;
        private int pm_fkDiameter;
        private int pm_width;
        private int pm_heigth;
        private bool pm_isExternal;

        // Properties

        public int codsec { get { return pm_codsec; } set { pm_codsec = value; } }

        public int fkType{get { return pm_fkType; }set { pm_fkType = value; }}

        public int fkSupplier { get { return pm_fkSupplier; } set { pm_fkSupplier = value; } }

        public string code{get { return pm_code; }set { pm_code = value; }}

        public int fkUnit { get { return pm_fkUnit; } set { pm_fkUnit = value; } }

        public int fkDiameter{get { return pm_fkDiameter; } set { pm_fkDiameter = value; }}

        public int width { get { return pm_width; }set { pm_width = value; }}

        public int heigth{get { return pm_heigth; }set { pm_heigth = value; }}

        public bool isExternal { get { return pm_isExternal; } set { pm_isExternal = value; } }

        //Constructor

        public clspMaterial()
        {
            codsec = 0;
            fkType = 0;
            fkSupplier = 0;
            code = "";
            fkUnit = 0;
            fkDiameter = 0;
            width = 0;
            heigth = 0;
            isExternal = false;
        }

        public clspMaterial(string code)
        {
            this.load(code);
        }

        // Methods

        private void load(string code)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_pmaterial WHERE pm_code =" + code.ToString() );

            if (DS.Tables.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["pm_codsec"]);
                this.fkType = Convert.ToInt32(DS.Tables[0].Rows[0]["pm_fkType"]);
                this.fkSupplier = Convert.ToInt32(DS.Tables[0].Rows[0]["pm_fkSupplier"]);
                this.code = DS.Tables[0].Rows[0]["pm_code"].ToString();
                this.fkUnit = Convert.ToInt32(DS.Tables[0].Rows[0]["pm_fkUnit"]);
                this.fkDiameter = Convert.ToInt32(DS.Tables[0].Rows[0]["pm_fkDiameter"]);
                this.width = Convert.ToInt32(DS.Tables[0].Rows[0]["pm_width"]); // Sujeto a cambios por si no funciona
                this.heigth = Convert.ToInt32(DS.Tables[0].Rows[0]["pm_heigth"]);
                this.isExternal = Convert.ToBoolean(DS.Tables[0].Rows[0]["pm_isExternal"]);
            }
        }

        private bool save()
        {
            string query = "";

            try
            {
                if (this.codsec == 0)
                {
                    query = "INSERT INTO bps_prod_pmaterial(pm_fkType,pm_fkSupplier,pm_code,pm_fkUnit,pm_fkDiameter,pm_witdth,pm_heigth)";
                    query += " VALUES(";
                    query += this.fkType.ToString() + ", ";
                    query += this.fkSupplier.ToString() + ", '";
                    query += this.code.ToString() + "',";
                    query += this.fkUnit.ToString() + ",";
                    query += this.fkDiameter.ToString() + ",";
                    query += this.width.ToString() + ",";
                    query += this.heigth.ToString() + ",";
                    query += this.isExternal.ToString() + ");";
                }
                else
                {
                    query = "UPDATE bps_prod_pmaterial";
                    query += " SET";
                    query += "pm_fkType = " + this.fkType.ToString() + ", ";
                    query += "pm_fkSupplier =" + this.fkSupplier.ToString() + ", '";
                    query += "pm_code =" +this.code.ToString() + "',";
                    query += "pm_fkUnit = " +this.fkUnit.ToString() + ",";
                    query += "pm_fkDiameter=" + this.fkDiameter.ToString() + ",";
                    query += "pm_width =" + this.width.ToString() + ",";
                    query += "pm_heigth=" + this.heigth.ToString() + ", ";
                    query += "pm_isExternal= " + this.isExternal.ToString() + " ";
                    query += "WHERE pm_codsec = " + this.codsec.ToString();
                }

                return clsConnection.executeQuery(query);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clspMaterial.save");
                return false;
            }
        }
    }
}
