using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra las bobinas que pasan a corte secundario
    /// </summary>
    public class clsSecundaryJoint
    {
        //Atributes

        private int sjnt_codsec;
        private int sjnt_fkInitCoil;
        private int sjnt_fkFinalCoil;
        private int sjnt_fkSubProcess;
        private string sjnt_SubProcessName;
        private int sjnt_length;
        private int sjnt_jointPosition;


        //Properties

        public int codsec { get { return sjnt_codsec; } set { sjnt_codsec = value; } }

        public int fkInitCoil { get { return sjnt_fkInitCoil; } set { sjnt_fkInitCoil = value; } }

        public int fkFinalCoil { get { return sjnt_fkFinalCoil; } set { sjnt_fkFinalCoil = value; } }

        public int fkSubProcess { get { return sjnt_fkSubProcess; } set { sjnt_fkSubProcess = value; } }

        public string SubProcessName { get { return sjnt_SubProcessName; } set { sjnt_SubProcessName = value; } }

        public int length { get { return sjnt_length; } set { sjnt_length = value; } }

        public int jointPosition { get { return sjnt_jointPosition; } set { sjnt_jointPosition = value; } }

       
        //Constructor

        public clsSecundaryJoint()
        { 
        sjnt_codsec = 0;
        sjnt_fkInitCoil = 0;
        sjnt_fkFinalCoil = 0;
        sjnt_fkSubProcess = 0;
        sjnt_SubProcessName = "";
        sjnt_length = 0;
        sjnt_jointPosition = 0;
        }
        //Methods
    }
}
