using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra las Rollos Madres de Cast
    /// </summary>
    public class clsCastCoil
    {
        //Atributes
 
        private int ccco_codsec;
        private int ccco_fkCoil;
        private string ccco_code;
        private string ccco_batch;


        //Properties

        public int codsec { get { return ccco_codsec; } set { ccco_codsec = value; } }

        public int fkCoil { get { return ccco_fkCoil; } set { ccco_fkCoil = value; } }

        public string code { get { return ccco_code; } set { ccco_code = value; } }

        public string batch { get { return ccco_batch; } set { ccco_batch = value; } }



        //Constructor

        public clsCastCoil()

        { 
        ccco_codsec = 0;
        ccco_fkCoil = 0;
        ccco_code = "";
        ccco_batch = "";
        
        }
        //Methods
    }
}
