using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra las Rollos Madres de Coating
    /// </summary>
    public class clsCoatingCoil
    {
        //Atributes


        private int coco_codsec;
        private int coco_fkCoil;
        private string coco_code;
        private string coco_batch;


        //Properties

        public int codsec { get { return coco_codsec; } set { coco_codsec = value; } }

        public int fkCoil { get { return coco_fkCoil; } set { coco_fkCoil = value; } }

        public string code { get { return coco_code; } set { coco_code = value; } }

        public string batch { get { return coco_batch; } set { coco_batch = value; } }


        //Constructor

        public clsCoatingCoil()
        { 

        coco_codsec = 0;
        coco_fkCoil = 0;
        coco_code = "";
        coco_batch = "";
        
        }

        //Methods
    }
}
