using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra las Rollos Madres de Bopp
    /// </summary>
    public class clsBoppCoil
    {
        //Atributes

        private int boco_codsec;
        private int boco_fkCoil;
        private string boco_code;
        private int boco_density;
        private int boco_grammage;
        private int boco_variation;
        private string boco_batch;


        //Properties

        public int codsec { get { return boco_codsec; } set { boco_codsec = value; } }

        public int fkCoil { get { return boco_fkCoil; } set { boco_fkCoil = value; } }

        public string code { get { return boco_code; } set { boco_code = value; } }

        public int density { get { return boco_density; } set { boco_density = value; } }

        public int grammage { get { return boco_grammage; } set { boco_grammage = value; } }

        public int variation { get { return boco_variation; } set { boco_variation = value; } }

        public string batch { get { return boco_batch; } set { boco_batch = value; } }


        //Constructor

        public clsBoppCoil()
        { 
        boco_codsec = 0;
        boco_fkCoil = 0;
        boco_code = "";
        boco_density = 0;
        boco_grammage = 0;
        boco_variation = 0;
        boco_batch = "";       
        
        }

      
        //Methods

       
    }
}
