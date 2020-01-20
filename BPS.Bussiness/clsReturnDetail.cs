using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra los detalles de una devolucion de productos terminados 
    /// </summary>
    public class clsReturnDetail
    {
        //Atributes

        private int rtndt_codsec;
        private int rtndt_fkCoil;
        private string rtndt_CoilCode;
        private int rtndt_fkPallet;
        private string rtndt_PalletCode;
        private int rtndt_fkReturn;
        private float rtndt_netWeight;

        //Properties

        public int codsec { get { return rtndt_codsec; } set { rtndt_codsec = value; } }

        public int fkCoil { get { return rtndt_fkCoil; } set { rtndt_fkCoil = value; } }

        public string CoilCode { get { return rtndt_CoilCode; } set { rtndt_CoilCode = value; } }

        public int fkPallet { get { return rtndt_fkPallet; } set { rtndt_fkPallet = value; } }

        public string PalletCode { get { return rtndt_PalletCode; } set { rtndt_PalletCode = value; } }

        public int fkReturn { get { return rtndt_fkReturn; } set { rtndt_fkReturn = value; } }

        public float netWeight { get { return rtndt_netWeight; } set { rtndt_netWeight = value; } }


        //Constructor

        public clsReturnDetail()
        { 
        rtndt_codsec = 0;
        rtndt_fkCoil = 0;
        rtndt_CoilCode = "";
        rtndt_fkPallet = 0;
        rtndt_PalletCode = "";
        rtndt_fkReturn = 0;
        rtndt_netWeight = 0;
        }
        //Methods
    }
}
