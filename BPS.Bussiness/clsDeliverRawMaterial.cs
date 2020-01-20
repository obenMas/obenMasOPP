using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;


namespace BPS.Bussiness
{
    public class clsDeliverRawMaterial
    {
               
            //Atributes

            private int drm_cellarCodsec;
            private int drm_machineCodsec;
            private int drm_cellarCodsecP;



            //Properties


            public int cellarCodsec { get { return drm_cellarCodsec; } set { drm_cellarCodsec = value; } }

            public int cellarCodsecP { get { return drm_cellarCodsecP; } set { drm_cellarCodsecP = value; } }

            public int machineCodsec { get { return drm_machineCodsec; } set { drm_machineCodsec = value; } }

  
            //Constructor

             public clsDeliverRawMaterial()
            {
                drm_cellarCodsec = 0;
                drm_machineCodsec = 0;
                drm_cellarCodsecP = 0;
           
            }

        
        public int getOutlerCellar()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT DISTINCT cl.`clr_codsec` as cellarCodsec FROM `bps_admin_cellar` cl WHERE NOT  EXISTS (SELECT * FROM `bps_prod_cellarbymachine` cm WHERE  cm.`cllmch_fkCellar` = cl.`clr_codsec`)");

            this.cellarCodsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cellarCodsec"]);

            return cellarCodsec;
        }

        public int getOutlerToProduction(int machineCodsec, int cellarCodsec)
        {
            

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT cllmch.`cllmch_fkCellar` as cellarCodsec FROM `bps_prod_cellarbymachine` cllmch WHERE cllmch.`cllmch_fkMachine` = " + machineCodsec + " and cllmch.`cllmch_fkCellar` != " + cellarCodsec + "");

            this.cellarCodsecP = Convert.ToInt32(DS.Tables[0].Rows[0]["cellarCodsec"]);

            return cellarCodsecP;
        }



    }
}
