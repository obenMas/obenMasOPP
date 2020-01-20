using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    public class clsCoilCellarMovement
    {
        //Attributes

        private int ccm_codsec;
        private int ccm_fkCoilCellar;
        private string ccm_code;
        private bool ccm_inputToCellar;
        private string ccm_name;    

        //Properties

        public int codsec { get { return ccm_codsec; } set { ccm_codsec = value; } }

        public int fkCoilCellar { get { return ccm_fkCoilCellar; } set { ccm_fkCoilCellar = value; } }

        public string code { get { return ccm_code; } set { ccm_code = value; } }

        public bool inputToCellar { get { return ccm_inputToCellar; } set { ccm_inputToCellar = value; } }

        public string name { get { return ccm_name; } set { ccm_name = value; } }


        //Constructor

        public clsCoilCellarMovement()
        {
            ccm_codsec = 0;
            ccm_fkCoilCellar = 0;
            ccm_code = "";
            ccm_inputToCellar = false;
        }

        //Methods

        public static clsCoilCellarMovement getCoilCellarDetailByCode(String movementCode)
        {
            clsCoilCellarMovement objCoilCellarMovement = new clsCoilCellarMovement();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilcellarmovement WHERE ccm_code = '" + movementCode + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                objCoilCellarMovement.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["ccm_codsec"]);
                objCoilCellarMovement.fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["ccm_fkCoilCellar"]);
                objCoilCellarMovement.code = DS.Tables[0].Rows[0]["ccm_code"].ToString();
                objCoilCellarMovement.inputToCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["ccm_inputToCellar"], DS.Tables[0].Rows[0]["ccm_inputToCellar"].GetType().FullName);
            }

            return objCoilCellarMovement;
        }

        public static List<clsCoilCellarMovement> getList()
        {
            List<clsCoilCellarMovement> lstCoilCellarMovement = new List<clsCoilCellarMovement>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilcellarmovement ORDER BY ccm_codsec");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCoilCellarMovement.Add(new clsCoilCellarMovement());
                    lstCoilCellarMovement[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["ccm_codsec"]);
                    lstCoilCellarMovement[i].fkCoilCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["ccm_fkCoilCellar"]);
                    lstCoilCellarMovement[i].code = DS.Tables[0].Rows[i]["ccm_code"].ToString();
                    lstCoilCellarMovement[i].inputToCellar = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["ccm_inputToCellar"], DS.Tables[0].Rows[i]["ccm_inputToCellar"].GetType().FullName);
                    lstCoilCellarMovement[i].name = (Convert.ToInt32(DS.Tables[0].Rows[i]["ccm_codsec"]) == 1) ? "Ingreso a Bodega" : (Convert.ToInt32(DS.Tables[0].Rows[i]["ccm_codsec"]) == 2) ? "Ingreso a Bodega 2" : (Convert.ToInt32(DS.Tables[0].Rows[i]["ccm_codsec"]) == 3) ? "Salida a proceso" : (Convert.ToInt32(DS.Tables[0].Rows[i]["ccm_codsec"]) == 4) ? "Salida a metalizado" : (Convert.ToInt32(DS.Tables[0].Rows[i]["ccm_codsec"]) == 5) ? "Salida a bajas" : "";
                }
            }
            return lstCoilCellarMovement;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
