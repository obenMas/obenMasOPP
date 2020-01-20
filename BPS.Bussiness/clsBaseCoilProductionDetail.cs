using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace BPS.Bussiness
{
    public class clsBaseCoilProductionDetail
    {
        //Atributes
        private int bcpd_codsec;
        private int bcpd_fkBaseCoil;
        private int bcpd_unwindTension010;
        private int bcpd_unwindTension1020;
        private int bcpd_unwindTension2030;
        private int bcpd_unwindTension3040;
        private int bcpd_unwindTension4050;
        private int bcpd_unwindTension5060;
        private int bcpd_rewindTension010;
        private int bcpd_rewindTension1020;
        private int bcpd_rewindTension2030;
        private int bcpd_rewindTension3040;
        private int bcpd_rewindTension4050;
        private int bcpd_rewindTension5060;
        private int bcpd_gapUnwind;
        private int bcpd_gapRewind;
        private float bcpd_taperPercentage;
        private float bcpd_drumTemperature;
        private int bcpd_dtr1Torque;
        private int bcpd_rollerPosition;
        private string bcpd_opticDensityMode;
        private int bcpd_aluminumSpeed;
        private bool bcpd_ceramic1;
        private bool bcpd_ceramic2;
        private bool bcpd_ceramic3;
        private bool bcpd_ceramic4;
        private bool bcpd_ceramic5;
        private bool bcpd_ceramic6;
        private bool bcpd_ceramic7;
        private bool bcpd_ceramic8;
        private bool bcpd_ceramic9;
        private bool bcpd_ceramic10;
        private bool bcpd_ceramic11;
        private bool bcpd_ceramic12;
        private bool bcpd_ceramic13;
        private bool bcpd_ceramic14;
        private bool bcpd_ceramic15;
        private bool bcpd_ceramic16;
        private bool bcpd_ceramic17;
        private bool bcpd_ceramic18;
        private bool bcpd_ceramic19;
        private bool bcpd_ceramic20;
        private bool bcpd_ceramic21;
        private bool bcpd_ceramic22;
        private bool bcpd_ceramic23;
        private bool bcpd_ceramic24;
        private bool bcpd_ceramic25;
        private bool bcpd_ceramic26;
        private bool bcpd_ceramic27;
        private bool bcpd_ceramic28;
        private bool bcpd_ceramic29;
        private bool bcpd_ceramic30;
        private bool bcpd_aluminum1;
        private bool bcpd_aluminum2;
        private bool bcpd_aluminum3;
        private bool bcpd_aluminum4;
        private bool bcpd_aluminum5;
        private bool bcpd_aluminum6;
        private bool bcpd_aluminum7;
        private bool bcpd_aluminum8;
        private bool bcpd_aluminum9;
        private bool bcpd_aluminum10;
        private bool bcpd_aluminum11;
        private bool bcpd_aluminum12;
        private bool bcpd_aluminum13;
        private bool bcpd_aluminum14;
        private bool bcpd_aluminum15;
        private bool bcpd_aluminum16;
        private bool bcpd_aluminum17;
        private bool bcpd_aluminum18;
        private bool bcpd_aluminum19;
        private bool bcpd_aluminum20;
        private bool bcpd_aluminum21;
        private bool bcpd_aluminum22;
        private bool bcpd_aluminum23;
        private bool bcpd_aluminum24;
        private bool bcpd_aluminum25;
        private bool bcpd_aluminum26;
        private bool bcpd_aluminum27;
        private bool bcpd_aluminum28;
        private bool bcpd_aluminum29;
        private bool bcpd_aluminum30;
        private int bcpd_initSpeed;
        private int bcpd_processSpeed;
        private int bcpd_endSpeed;
        private int bcpd_linearLength;
        private float bcpd_metalWeigth;
        private string bcpd_MainCoilMetal;
        private string bcpd_notes;

        //Properties
        public int codsec { get { return bcpd_codsec; } set { bcpd_codsec = value; } }
        public int fkBaseCoil { get { return bcpd_fkBaseCoil; } set { bcpd_fkBaseCoil = value; } }
        public int unwindTension010 { get { return bcpd_unwindTension010; } set { bcpd_unwindTension010 = value; } }
        public int unwindTension1020 { get { return bcpd_unwindTension1020; } set { bcpd_unwindTension1020 = value; } }
        public int unwindTension2030 { get { return bcpd_unwindTension2030; } set { bcpd_unwindTension2030 = value; } }
        public int unwindTension3040 { get { return bcpd_unwindTension3040; } set { bcpd_unwindTension3040 = value; } }
        public int unwindTension4050 { get { return bcpd_unwindTension4050; } set { bcpd_unwindTension4050 = value; } }
        public int unwindTension5060 { get { return bcpd_unwindTension5060; } set { bcpd_unwindTension5060 = value; } }
        public int rewindTension010 { get { return bcpd_rewindTension010; } set { bcpd_rewindTension010 = value; } }
        public int rewindTension1020 { get { return bcpd_rewindTension1020; } set { bcpd_rewindTension1020 = value; } }
        public int rewindTension2030 { get { return bcpd_rewindTension2030; } set { bcpd_rewindTension2030 = value; } }
        public int rewindTension3040 { get { return bcpd_rewindTension3040; } set { bcpd_rewindTension3040 = value; } }
        public int rewindTension4050 { get { return bcpd_rewindTension4050; } set { bcpd_rewindTension4050 = value; } }
        public int rewindTension5060 { get { return bcpd_rewindTension5060; } set { bcpd_rewindTension5060 = value; } }
        public int gapUnwind { get { return bcpd_gapUnwind; } set { bcpd_gapUnwind = value; } }
        public int gapRewind { get { return bcpd_gapRewind; } set { bcpd_gapRewind = value; } }
        public float taperPercentage { get { return bcpd_taperPercentage; } set { bcpd_taperPercentage = value; } }
        public float drumTemperature { get { return bcpd_drumTemperature; } set { bcpd_drumTemperature = value; } }
        public int dtr1Torque { get { return bcpd_dtr1Torque; } set { bcpd_dtr1Torque = value; } }
        public int rollerPosition { get { return bcpd_rollerPosition; } set { bcpd_rollerPosition = value; } }
        public string opticDensityMode { get { return bcpd_opticDensityMode; } set { bcpd_opticDensityMode = value; } }
        public int aluminumSpeed { get { return bcpd_aluminumSpeed; } set { bcpd_aluminumSpeed = value; } }
        public bool ceramic1 { get { return bcpd_ceramic1; } set { bcpd_ceramic1 = value; } }
        public bool ceramic2 { get { return bcpd_ceramic2; } set { bcpd_ceramic2 = value; } }
        public bool ceramic3 { get { return bcpd_ceramic3; } set { bcpd_ceramic3 = value; } }
        public bool ceramic4 { get { return bcpd_ceramic4; } set { bcpd_ceramic4 = value; } }
        public bool ceramic5 { get { return bcpd_ceramic5; } set { bcpd_ceramic5 = value; } }
        public bool ceramic6 { get { return bcpd_ceramic6; } set { bcpd_ceramic6 = value; } }
        public bool ceramic7 { get { return bcpd_ceramic7; } set { bcpd_ceramic7 = value; } }
        public bool ceramic8 { get { return bcpd_ceramic8; } set { bcpd_ceramic8 = value; } }
        public bool ceramic9 { get { return bcpd_ceramic9; } set { bcpd_ceramic9 = value; } }
        public bool ceramic10 { get { return bcpd_ceramic10; } set { bcpd_ceramic10 = value; } }
        public bool ceramic11 { get { return bcpd_ceramic11; } set { bcpd_ceramic11 = value; } }
        public bool ceramic12 { get { return bcpd_ceramic12; } set { bcpd_ceramic12 = value; } }
        public bool ceramic13 { get { return bcpd_ceramic13; } set { bcpd_ceramic13 = value; } }
        public bool ceramic14 { get { return bcpd_ceramic14; } set { bcpd_ceramic14 = value; } }
        public bool ceramic15 { get { return bcpd_ceramic15; } set { bcpd_ceramic15 = value; } }
        public bool ceramic16 { get { return bcpd_ceramic16; } set { bcpd_ceramic16 = value; } }
        public bool ceramic17 { get { return bcpd_ceramic17; } set { bcpd_ceramic17 = value; } }
        public bool ceramic18 { get { return bcpd_ceramic18; } set { bcpd_ceramic18 = value; } }
        public bool ceramic19 { get { return bcpd_ceramic19; } set { bcpd_ceramic19 = value; } }
        public bool ceramic20 { get { return bcpd_ceramic20; } set { bcpd_ceramic20 = value; } }
        public bool ceramic21 { get { return bcpd_ceramic21; } set { bcpd_ceramic21 = value; } }
        public bool ceramic22 { get { return bcpd_ceramic22; } set { bcpd_ceramic22 = value; } }
        public bool ceramic23 { get { return bcpd_ceramic23; } set { bcpd_ceramic23 = value; } }
        public bool ceramic24 { get { return bcpd_ceramic24; } set { bcpd_ceramic24 = value; } }
        public bool ceramic25 { get { return bcpd_ceramic25; } set { bcpd_ceramic25 = value; } }
        public bool ceramic26 { get { return bcpd_ceramic26; } set { bcpd_ceramic26 = value; } }
        public bool ceramic27 { get { return bcpd_ceramic27; } set { bcpd_ceramic27 = value; } }
        public bool ceramic28 { get { return bcpd_ceramic28; } set { bcpd_ceramic28 = value; } }
        public bool ceramic29 { get { return bcpd_ceramic29; } set { bcpd_ceramic29 = value; } }
        public bool ceramic30 { get { return bcpd_ceramic30; } set { bcpd_ceramic30 = value; } }
        public bool aluminum1 { get { return bcpd_aluminum1; } set { bcpd_aluminum1 = value; } }
        public bool aluminum2 { get { return bcpd_aluminum2; } set { bcpd_aluminum2 = value; } }
        public bool aluminum3 { get { return bcpd_aluminum3; } set { bcpd_aluminum3 = value; } }
        public bool aluminum4 { get { return bcpd_aluminum4; } set { bcpd_aluminum4 = value; } }
        public bool aluminum5 { get { return bcpd_aluminum5; } set { bcpd_aluminum5 = value; } }
        public bool aluminum6 { get { return bcpd_aluminum6; } set { bcpd_aluminum6 = value; } }
        public bool aluminum7 { get { return bcpd_aluminum7; } set { bcpd_aluminum7 = value; } }
        public bool aluminum8 { get { return bcpd_aluminum8; } set { bcpd_aluminum8 = value; } }
        public bool aluminum9 { get { return bcpd_aluminum9; } set { bcpd_aluminum9 = value; } }
        public bool aluminum10 { get { return bcpd_aluminum10; } set { bcpd_aluminum10 = value; } }
        public bool aluminum11 { get { return bcpd_aluminum11; } set { bcpd_aluminum11 = value; } }
        public bool aluminum12 { get { return bcpd_aluminum12; } set { bcpd_aluminum12 = value; } }
        public bool aluminum13 { get { return bcpd_aluminum13; } set { bcpd_aluminum13 = value; } }
        public bool aluminum14 { get { return bcpd_aluminum14; } set { bcpd_aluminum14 = value; } }
        public bool aluminum15 { get { return bcpd_aluminum15; } set { bcpd_aluminum15 = value; } }
        public bool aluminum16 { get { return bcpd_aluminum16; } set { bcpd_aluminum16 = value; } }
        public bool aluminum17 { get { return bcpd_aluminum17; } set { bcpd_aluminum17 = value; } }
        public bool aluminum18 { get { return bcpd_aluminum18; } set { bcpd_aluminum18 = value; } }
        public bool aluminum19 { get { return bcpd_aluminum19; } set { bcpd_aluminum19 = value; } }
        public bool aluminum20 { get { return bcpd_aluminum20; } set { bcpd_aluminum20 = value; } }
        public bool aluminum21 { get { return bcpd_aluminum21; } set { bcpd_aluminum21 = value; } }
        public bool aluminum22 { get { return bcpd_aluminum22; } set { bcpd_aluminum22 = value; } }
        public bool aluminum23 { get { return bcpd_aluminum23; } set { bcpd_aluminum23 = value; } }
        public bool aluminum24 { get { return bcpd_aluminum24; } set { bcpd_aluminum24 = value; } }
        public bool aluminum25 { get { return bcpd_aluminum25; } set { bcpd_aluminum25 = value; } }
        public bool aluminum26 { get { return bcpd_aluminum26; } set { bcpd_aluminum26 = value; } }
        public bool aluminum27 { get { return bcpd_aluminum27; } set { bcpd_aluminum27 = value; } }
        public bool aluminum28 { get { return bcpd_aluminum28; } set { bcpd_aluminum28 = value; } }
        public bool aluminum29 { get { return bcpd_aluminum29; } set { bcpd_aluminum29 = value; } }
        public bool aluminum30 { get { return bcpd_aluminum30; } set { bcpd_aluminum30 = value; } }
        public int initSpeed { get { return bcpd_initSpeed; } set { bcpd_initSpeed = value; } }
        public int processSpeed { get { return bcpd_processSpeed; } set { bcpd_processSpeed = value; } }
        public int endSpeed { get { return bcpd_endSpeed; } set { bcpd_endSpeed = value; } }
        public int linearLength { get { return bcpd_linearLength; } set { bcpd_linearLength = value; } }
        public float metalWeigth { get { return bcpd_metalWeigth; } set { bcpd_metalWeigth = value; } }
        public string MainCoilMetal { get { return bcpd_MainCoilMetal; } set { bcpd_MainCoilMetal = value; } }
        public string notes { get { return bcpd_notes; } set { bcpd_notes = value; } }

        //Constructor

        public clsBaseCoilProductionDetail()
        {
             codsec = 0;
             fkBaseCoil = 0;
             unwindTension010 = 0;
             unwindTension1020 = 0;
             unwindTension2030 = 0;
             unwindTension3040 = 0;
             unwindTension4050 = 0;
             unwindTension5060 = 0;
             rewindTension010 = 0;
             rewindTension1020 = 0;
             rewindTension2030 = 0;
             rewindTension3040 = 0;
             rewindTension4050 = 0;
             rewindTension5060 = 0;
             gapUnwind = 0;
             gapRewind = 0;
             taperPercentage = 0;
             drumTemperature=0;
             dtr1Torque=0;
             rollerPosition=0;
             opticDensityMode="";
             aluminumSpeed=0;
             ceramic1 = false;
             ceramic2 = false;
             ceramic3 = false;
             ceramic4 = false;
             ceramic5 = false;
             ceramic6 = false;
             ceramic7 = false;
             ceramic8 = false;
             ceramic9 = false;
             ceramic10 = false;
             ceramic11 = false;
             ceramic12 = false;
             ceramic13 = false;
             ceramic14 = false;
             ceramic15 = false;
             ceramic16 = false;
             ceramic17 = false;
             ceramic18 = false;
             ceramic19 = false;
             ceramic20 = false;
             ceramic21 = false;
             ceramic22 = false;
             ceramic23 = false;
             ceramic24 = false;
             ceramic25 = false;
             ceramic26 = false;
             ceramic27 = false;
             ceramic28 = false;
             ceramic29 = false;
             ceramic30 = false;
             aluminum1 = false;
             aluminum2 = false;
             aluminum3 = false;
             aluminum4 = false;
             aluminum5 = false;
             aluminum6 = false;
             aluminum7 = false;
             aluminum8 = false;
             aluminum9 = false;
             aluminum10 = false;
             aluminum11 = false;
             aluminum12 = false;
             aluminum13 = false;
             aluminum14 = false;
             aluminum15 = false;
             aluminum16 = false;
             aluminum17 = false;
             aluminum18 = false;
             aluminum19 = false;
             aluminum20 = false;
             aluminum21 = false;
             aluminum22 = false;
             aluminum23 = false;
             aluminum24 = false;
             aluminum25 = false;
             aluminum26 = false;
             aluminum27 = false;
             aluminum28 = false;
             aluminum29 = false;
             aluminum30 = false;
             initSpeed=0;
             processSpeed=0;
             endSpeed=0;
             linearLength=0;
             metalWeigth=0;
             MainCoilMetal="";
             notes="";
        }
        public clsBaseCoilProductionDetail(int bcpdCodsec)
        {
            this.load(bcpdCodsec);
        }

        //Methods

        public void load(int bcpdCodsec)
        {
            DataSet DS = new DataSet();
            //Crear el store procedure "spBaseCoilProductionDetailByCodsec"
            DS = clsConnection.getDataSetResult("select * from bps_prod_baseCoilProductionDetail where bcpd_fkBaseCoil = " + bcpdCodsec);
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_codsec"]);
                fkBaseCoil = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_fkBaseCoil"]);
                unwindTension010 = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_unwindTension010"]);
                unwindTension1020 = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_unwindTension1020"]);
                unwindTension2030 = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_unwindTension2030"]);
                unwindTension3040 = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_unwindTension3040"]);
                unwindTension4050 = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_unwindTension4050"]);
                rewindTension5060 = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_unwindTension5060"]);
                rewindTension010 = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_rewindTension010"]);
                rewindTension1020 = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_rewindTension1020"]);
                rewindTension2030 = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_rewindTension2030"]);
                rewindTension3040 = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_rewindTension3040"]);
                rewindTension4050 = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_rewindTension4050"]);
                rewindTension5060 = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_rewindTension5060"]);
                gapUnwind = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_gapUnwind"]);
                gapRewind = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_gapRewind"]);
                taperPercentage = float.Parse(DS.Tables[0].Rows[0]["bcpd_taperPercentage"].ToString());
                drumTemperature = float.Parse(DS.Tables[0].Rows[0]["bcpd_drumTemperature"].ToString());
                dtr1Torque = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_dtr1Torque"]);
                rollerPosition = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_rollerPosition"]);
                opticDensityMode = DS.Tables[0].Rows[0]["bcpd_opticDensityMode"].ToString();
                aluminumSpeed = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_aluminumSpeed"]);
                ceramic1 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic1"]);
                ceramic2 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic2"]);
                ceramic3 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic3"]);
                ceramic4 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic4"]);
                ceramic5 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic5"]);
                ceramic6 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic6"]);
                ceramic7 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic7"]);
                ceramic8 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic8"]);
                ceramic9 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic9"]);
                ceramic10 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic10"]);
                ceramic11 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic11"]);
                ceramic12 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic12"]);
                ceramic13 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic13"]);
                ceramic14 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic14"]);
                ceramic15 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic15"]);
                ceramic16 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic16"]);
                ceramic17 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic17"]);
                ceramic18 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic18"]);
                ceramic19 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic19"]);
                ceramic20 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic20"]);
                ceramic21 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic21"]);
                ceramic22 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic22"]);
                ceramic23 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic23"]);
                ceramic24 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic24"]);
                ceramic25 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic25"]);
                ceramic26 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic26"]);
                ceramic27 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic27"]);
                ceramic28 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic28"]);
                ceramic29 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic29"]);
                ceramic30 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic30"]);
                aluminum1 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum1"]);
                aluminum2 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum2"]);
                aluminum3 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum3"]);
                aluminum4 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum4"]);
                aluminum5 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum5"]);
                aluminum6 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum6"]);
                aluminum7 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum7"]);
                aluminum8 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum8"]);
                aluminum9 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum9"]);
                aluminum10 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum10"]);
                aluminum11 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum11"]);
                aluminum12 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum12"]);
                aluminum13 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum13"]);
                aluminum14 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum14"]);
                aluminum15 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum15"]);
                aluminum16 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum16"]);
                aluminum17 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum17"]);
                aluminum18 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum18"]);
                aluminum19 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum19"]);
                aluminum20 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum20"]);
                aluminum21 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum21"]);
                aluminum22 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum22"]);
                aluminum23 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum23"]);
                aluminum24 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum24"]);
                aluminum25 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum25"]);
                aluminum26 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum26"]);
                aluminum27 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum27"]);
                aluminum28 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum28"]);
                aluminum29 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum29"]);
                aluminum30 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum30"]);
                initSpeed = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_initSpeed"]);
                processSpeed = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_processSpeed"]);
                endSpeed = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_endSpeed"]);
                linearLength = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_linearLength"]);
                metalWeigth = float.Parse(DS.Tables[0].Rows[0]["bcpd_metalWeigth"].ToString());
                MainCoilMetal = DS.Tables[0].Rows[0]["bcpd_MainCoilMetal"].ToString();
                notes = DS.Tables[0].Rows[0]["bcpd_notes"].ToString();
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        public void load(string bcpdCodsec, string bcpdMetalCodsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("select * from bps_prod_baseCoilProductionDetail where bcpd_fkBaseCoil = '" + bcpdCodsec + "' AND bcpd_MainCoilMetal='"+bcpdMetalCodsec+"'");
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_codsec"]);
                fkBaseCoil = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_fkBaseCoil"]);
                unwindTension010 = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_unwindTension010"]);
                unwindTension1020 = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_unwindTension1020"]);
                unwindTension2030 = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_unwindTension2030"]);
                unwindTension3040 = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_unwindTension3040"]);
                unwindTension4050 = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_unwindTension4050"]);
                rewindTension5060 = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_unwindTension5060"]);
                rewindTension010 = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_rewindTension010"]);
                rewindTension1020 = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_rewindTension1020"]);
                rewindTension2030 = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_rewindTension2030"]);
                rewindTension3040 = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_rewindTension3040"]);
                rewindTension4050 = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_rewindTension4050"]);
                rewindTension5060 = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_rewindTension5060"]);
                gapUnwind = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_gapUnwind"]);
                gapRewind = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_gapRewind"]);
                taperPercentage = float.Parse(DS.Tables[0].Rows[0]["bcpd_taperPercentage"].ToString());
                drumTemperature = float.Parse(DS.Tables[0].Rows[0]["bcpd_drumTemperature"].ToString());
                dtr1Torque = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_dtr1Torque"]);
                rollerPosition = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_rollerPosition"]);
                opticDensityMode = DS.Tables[0].Rows[0]["bcpd_opticDensityMode"].ToString();
                aluminumSpeed = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_aluminumSpeed"]);
                ceramic1 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic1"]);
                ceramic2 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic2"]);
                ceramic3 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic3"]);
                ceramic4 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic4"]);
                ceramic5 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic5"]);
                ceramic6 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic6"]);
                ceramic7 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic7"]);
                ceramic8 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic8"]);
                ceramic9 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic9"]);
                ceramic10 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic10"]);
                ceramic11 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic11"]);
                ceramic12 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic12"]);
                ceramic13 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic13"]);
                ceramic14 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic14"]);
                ceramic15 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic15"]);
                ceramic16 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic16"]);
                ceramic17 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic17"]);
                ceramic18 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic18"]);
                ceramic19 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic19"]);
                ceramic20 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic20"]);
                ceramic21 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic21"]);
                ceramic22 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic22"]);
                ceramic23 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic23"]);
                ceramic24 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic24"]);
                ceramic25 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic25"]);
                ceramic26 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic26"]);
                ceramic27 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic27"]);
                ceramic28 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic28"]);
                ceramic29 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic29"]);
                ceramic30 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_ceramic30"]);
                aluminum1 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum1"]);
                aluminum2 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum2"]);
                aluminum3 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum3"]);
                aluminum4 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum4"]);
                aluminum5 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum5"]);
                aluminum6 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum6"]);
                aluminum7 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum7"]);
                aluminum8 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum8"]);
                aluminum9 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum9"]);
                aluminum10 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum10"]);
                aluminum11 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum11"]);
                aluminum12 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum12"]);
                aluminum13 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum13"]);
                aluminum14 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum14"]);
                aluminum15 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum15"]);
                aluminum16 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum16"]);
                aluminum17 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum17"]);
                aluminum18 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum18"]);
                aluminum19 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum19"]);
                aluminum20 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum20"]);
                aluminum21 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum21"]);
                aluminum22 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum22"]);
                aluminum23 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum23"]);
                aluminum24 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum24"]);
                aluminum25 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum25"]);
                aluminum26 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum26"]);
                aluminum27 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum27"]);
                aluminum28 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum28"]);
                aluminum29 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum29"]);
                aluminum30 = Convert.ToBoolean(DS.Tables[0].Rows[0]["bcpd_aluminum30"]);
                initSpeed = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_initSpeed"]);
                processSpeed = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_processSpeed"]);
                endSpeed = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_endSpeed"]);
                linearLength = Convert.ToInt32(DS.Tables[0].Rows[0]["bcpd_linearLength"]);
                metalWeigth = float.Parse(DS.Tables[0].Rows[0]["bcpd_metalWeigth"].ToString());
                MainCoilMetal = DS.Tables[0].Rows[0]["bcpd_MainCoilMetal"].ToString();
                notes = DS.Tables[0].Rows[0]["bcpd_notes"].ToString();
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        public bool save()
        {
            try
            {
                string queryString = "";
                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_baseCoilProductionDetail(bcpd_fkBaseCoil, bcpd_unwindTension010, bcpd_unwindTension1020, bcpd_unwindTension2030, bcpd_unwindTension3040, bcpd_unwindTension4050, bcpd_unwindTension5060, bcpd_rewindTension010, bcpd_rewindTension1020";
                    queryString += ", bcpd_rewindTension2030, bcpd_rewindTension3040, bcpd_rewindTension4050, bcpd_rewindTension5060, bcpd_gapUnwind, bcpd_gapRewind, bcpd_taperPercentage, bcpd_drumTemperature, bcpd_dtr1Torque, bcpd_rollerPosition, bcpd_opticDensityMode";
                    queryString += ", bcpd_aluminumSpeed, bcpd_ceramic1, bcpd_ceramic2, bcpd_ceramic3, bcpd_ceramic4, bcpd_ceramic5, bcpd_ceramic6, bcpd_ceramic7, bcpd_ceramic8, bcpd_ceramic9, bcpd_ceramic10, bcpd_ceramic11, bcpd_ceramic12, bcpd_ceramic13, bcpd_ceramic14, bcpd_ceramic15, bcpd_ceramic16, bcpd_ceramic17, bcpd_ceramic18, bcpd_ceramic19, bcpd_ceramic20, bcpd_ceramic21, bcpd_ceramic22, bcpd_ceramic23, bcpd_ceramic24, bcpd_ceramic25, bcpd_ceramic26, bcpd_ceramic27, bcpd_ceramic28, bcpd_ceramic29, bcpd_ceramic30";
                    queryString += ", bcpd_aluminum1, bcpd_aluminum2, bcpd_aluminum3, bcpd_aluminum4, bcpd_aluminum5, bcpd_aluminum6, bcpd_aluminum7, bcpd_aluminum8, bcpd_aluminum9, bcpd_aluminum10, bcpd_aluminum11, bcpd_aluminum12, bcpd_aluminum13, bcpd_aluminum14, bcpd_aluminum15, bcpd_aluminum16, bcpd_aluminum17, bcpd_aluminum18, bcpd_aluminum19, bcpd_aluminum20, bcpd_aluminum21, bcpd_aluminum22, bcpd_aluminum23, bcpd_aluminum24, bcpd_aluminum25, bcpd_aluminum26, bcpd_aluminum27, bcpd_aluminum28, bcpd_aluminum29, bcpd_aluminum30";
                    queryString += ", bcpd_initSpeed, bcpd_processSpeed, bcpd_endSpeed, bcpd_linearLength, bcpd_metalWeigth, bcpd_MainCoilMetal, bcpd_notes)";
                    queryString += " VALUES(";
                    queryString += "" + this.fkBaseCoil.ToString() + ", ";
                    queryString += "" + this.unwindTension010.ToString() + ", ";
                    queryString += "" + this.unwindTension1020.ToString() + ", ";
                    queryString += "" + this.unwindTension2030.ToString() + ", ";
                    queryString += "" + this.unwindTension3040.ToString() + ", ";
                    queryString += "" + this.unwindTension4050.ToString() + ", ";
                    queryString += "" + this.unwindTension5060.ToString() + ", ";
                    queryString += "" + this.rewindTension010.ToString() + ", ";
                    queryString += "" + this.rewindTension1020.ToString() + ", ";
                    queryString += "" + this.rewindTension2030.ToString() + ", ";
                    queryString += "" + this.rewindTension3040.ToString() + ", ";
                    queryString += "" + this.rewindTension4050.ToString() + ", ";
                    queryString += "" + this.rewindTension5060.ToString() + ", ";
                    queryString += "" + this.gapUnwind.ToString() + ", ";
                    queryString += "" + this.gapRewind.ToString() + ", ";
                    queryString += "" + this.taperPercentage.ToString() + ", ";
                    queryString += "" + this.drumTemperature.ToString() + ", ";
                    queryString += "" + this.dtr1Torque.ToString() + ", ";
                    queryString += "" + this.rollerPosition.ToString() + ", ";
                    queryString += "'" + this.opticDensityMode + "', ";
                    queryString += "" + this.aluminumSpeed.ToString() + ", ";
                    queryString += "" + this.ceramic1.ToString() + ", ";
                    queryString += "" + this.ceramic2.ToString() + ", ";
                    queryString += "" + this.ceramic3.ToString() + ", ";
                    queryString += "" + this.ceramic4.ToString() + ", ";
                    queryString += "" + this.ceramic5.ToString() + ", ";
                    queryString += "" + this.ceramic6.ToString() + ", ";
                    queryString += "" + this.ceramic7.ToString() + ", ";
                    queryString += "" + this.ceramic8.ToString() + ", ";
                    queryString += "" + this.ceramic9.ToString() + ", ";
                    queryString += "" + this.ceramic10.ToString() + ", ";
                    queryString += "" + this.ceramic11.ToString() + ", ";
                    queryString += "" + this.ceramic12.ToString() + ", ";
                    queryString += "" + this.ceramic13.ToString() + ", ";
                    queryString += "" + this.ceramic14.ToString() + ", ";
                    queryString += "" + this.ceramic15.ToString() + ", ";
                    queryString += "" + this.ceramic16.ToString() + ", ";
                    queryString += "" + this.ceramic17.ToString() + ", ";
                    queryString += "" + this.ceramic18.ToString() + ", ";
                    queryString += "" + this.ceramic19.ToString() + ", ";
                    queryString += "" + this.ceramic20.ToString() + ", ";
                    queryString += "" + this.ceramic21.ToString() + ", ";
                    queryString += "" + this.ceramic22.ToString() + ", ";
                    queryString += "" + this.ceramic23.ToString() + ", ";
                    queryString += "" + this.ceramic24.ToString() + ", ";
                    queryString += "" + this.ceramic25.ToString() + ", ";
                    queryString += "" + this.ceramic26.ToString() + ", ";
                    queryString += "" + this.ceramic27.ToString() + ", ";
                    queryString += "" + this.ceramic28.ToString() + ", ";
                    queryString += "" + this.ceramic29.ToString() + ", ";
                    queryString += "" + this.ceramic30.ToString() + ", ";
                    queryString += "" + this.aluminum1.ToString() + ", ";
                    queryString += "" + this.aluminum2.ToString() + ", ";
                    queryString += "" + this.aluminum3.ToString() + ", ";
                    queryString += "" + this.aluminum4.ToString() + ", ";
                    queryString += "" + this.aluminum5.ToString() + ", ";
                    queryString += "" + this.aluminum6.ToString() + ", ";
                    queryString += "" + this.aluminum7.ToString() + ", ";
                    queryString += "" + this.aluminum8.ToString() + ", ";
                    queryString += "" + this.aluminum9.ToString() + ", ";
                    queryString += "" + this.aluminum10.ToString() + ", ";
                    queryString += "" + this.aluminum11.ToString() + ", ";
                    queryString += "" + this.aluminum12.ToString() + ", ";
                    queryString += "" + this.aluminum13.ToString() + ", ";
                    queryString += "" + this.aluminum14.ToString() + ", ";
                    queryString += "" + this.aluminum15.ToString() + ", ";
                    queryString += "" + this.aluminum16.ToString() + ", ";
                    queryString += "" + this.aluminum17.ToString() + ", ";
                    queryString += "" + this.aluminum18.ToString() + ", ";
                    queryString += "" + this.aluminum19.ToString() + ", ";
                    queryString += "" + this.aluminum20.ToString() + ", ";
                    queryString += "" + this.aluminum21.ToString() + ", ";
                    queryString += "" + this.aluminum22.ToString() + ", ";
                    queryString += "" + this.aluminum23.ToString() + ", ";
                    queryString += "" + this.aluminum24.ToString() + ", ";
                    queryString += "" + this.aluminum25.ToString() + ", ";
                    queryString += "" + this.aluminum26.ToString() + ", ";
                    queryString += "" + this.aluminum27.ToString() + ", ";
                    queryString += "" + this.aluminum28.ToString() + ", ";
                    queryString += "" + this.aluminum29.ToString() + ", ";
                    queryString += "" + this.aluminum30.ToString() + ", ";
                    queryString += "" + this.initSpeed.ToString() + ", ";
                    queryString += "" + this.processSpeed.ToString() + ", ";
                    queryString += "" + this.endSpeed.ToString() + ", ";
                    queryString += "" + this.linearLength.ToString() + ", ";
                    queryString += "" + this.metalWeigth.ToString() + ", ";
                    queryString += "'" + this.MainCoilMetal + "', ";
                    queryString += "'" + this.notes.ToString() + "'); ";
                }
                else
                {
                    queryString += "UPDATE bps_prod_baseCoilProductionDetail ";
                    queryString += " SET ";
                    queryString += "bcpd_fkBaseCoil = " + this.fkBaseCoil.ToString() + ", ";
                    queryString += "bcpd_unwindTension010 = " + this.unwindTension010.ToString() + ", ";
                    queryString += "bcpd_unwindTension1020 = " + this.unwindTension1020.ToString() + ", ";
                    queryString += "bcpd_unwindTension2030 = " + this.unwindTension2030.ToString() + ", ";
                    queryString += "bcpd_unwindTension3040 = " + this.unwindTension3040.ToString() + ", ";
                    queryString += "bcpd_unwindTension4050 = " + this.unwindTension4050.ToString() + ", ";
                    queryString += "bcpd_unwindTension5060 = " + this.unwindTension5060.ToString() + ", ";
                    queryString += "bcpd_rewindTension010 = " + this.rewindTension010.ToString() + ", ";
                    queryString += "bcpd_rewindTension1020 = " + this.rewindTension1020.ToString() + ", ";
                    queryString += "bcpd_rewindTension2030 = " + this.rewindTension2030.ToString() + ", ";
                    queryString += "bcpd_rewindTension3040 = " + this.rewindTension3040.ToString() + ", ";
                    queryString += "bcpd_rewindTension4050 = " + this.rewindTension4050.ToString() + ", ";
                    queryString += "bcpd_rewindTension5060 = " + this.rewindTension5060.ToString() + ", ";
                    queryString += "bcpd_gapUnwind = " + this.gapUnwind.ToString() + ", ";
                    queryString += "bcpd_gapRewind = " + this.gapRewind.ToString() + ", ";
                    queryString += "bcpd_taperPercentage = " + this.taperPercentage.ToString() + ", ";
                    queryString += "bcpd_drumTemperature = " + this.drumTemperature.ToString() + ", ";
                    queryString += "bcpd_dtr1Torque = " + this.dtr1Torque.ToString() + ", ";
                    queryString += "bcpd_opticDensityMode = '" + this.opticDensityMode.ToString() + "', ";
                    queryString += "bcpd_aluminumSpeed = " + this.aluminumSpeed.ToString() + ", ";
                    queryString += "bcpd_ceramic1 = " + this.ceramic1.ToString() + ", ";
                    queryString += "bcpd_ceramic2 = " + this.ceramic2.ToString() + ", ";
                    queryString += "bcpd_ceramic3 = " + this.ceramic3.ToString() + ", ";
                    queryString += "bcpd_ceramic4 = " + this.ceramic4.ToString() + ", ";
                    queryString += "bcpd_ceramic5 = " + this.ceramic5.ToString() + ", ";
                    queryString += "bcpd_ceramic6 = " + this.ceramic6.ToString() + ", ";
                    queryString += "bcpd_ceramic7 = " + this.ceramic7.ToString() + ", ";
                    queryString += "bcpd_ceramic8 = " + this.ceramic8.ToString() + ", ";
                    queryString += "bcpd_ceramic9 = " + this.ceramic9.ToString() + ", ";
                    queryString += "bcpd_ceramic10 = " + this.ceramic10.ToString() + ", ";
                    queryString += "bcpd_ceramic11 = " + this.ceramic11.ToString() + ", ";
                    queryString += "bcpd_ceramic12 = " + this.ceramic12.ToString() + ", ";
                    queryString += "bcpd_ceramic13 = " + this.ceramic13.ToString() + ", ";
                    queryString += "bcpd_ceramic14 = " + this.ceramic14.ToString() + ", ";
                    queryString += "bcpd_ceramic15 = " + this.ceramic15.ToString() + ", ";
                    queryString += "bcpd_ceramic16 = " + this.ceramic16.ToString() + ", ";
                    queryString += "bcpd_ceramic17 = " + this.ceramic17.ToString() + ", ";
                    queryString += "bcpd_ceramic18 = " + this.ceramic18.ToString() + ", ";
                    queryString += "bcpd_ceramic19 = " + this.ceramic19.ToString() + ", ";
                    queryString += "bcpd_ceramic20 = " + this.ceramic20.ToString() + ", ";
                    queryString += "bcpd_ceramic21 = " + this.ceramic21.ToString() + ", ";
                    queryString += "bcpd_ceramic22 = " + this.ceramic22.ToString() + ", ";
                    queryString += "bcpd_ceramic23 = " + this.ceramic23.ToString() + ", ";
                    queryString += "bcpd_ceramic24 = " + this.ceramic24.ToString() + ", ";
                    queryString += "bcpd_ceramic25 = " + this.ceramic25.ToString() + ", ";
                    queryString += "bcpd_ceramic26 = " + this.ceramic26.ToString() + ", ";
                    queryString += "bcpd_ceramic27 = " + this.ceramic27.ToString() + ", ";
                    queryString += "bcpd_ceramic28 = " + this.ceramic28.ToString() + ", ";
                    queryString += "bcpd_ceramic29 = " + this.ceramic29.ToString() + ", ";
                    queryString += "bcpd_ceramic30 = " + this.ceramic30.ToString() + ", ";
                    queryString += "bcpd_aluminum1 = " + this.aluminum1.ToString() + ", ";
                    queryString += "bcpd_aluminum2 = " + this.aluminum2.ToString() + ", ";
                    queryString += "bcpd_aluminum3 = " + this.aluminum3.ToString() + ", ";
                    queryString += "bcpd_aluminum4 = " + this.aluminum4.ToString() + ", ";
                    queryString += "bcpd_aluminum5 = " + this.aluminum5.ToString() + ", ";
                    queryString += "bcpd_aluminum6 = " + this.aluminum6.ToString() + ", ";
                    queryString += "bcpd_aluminum7 = " + this.aluminum7.ToString() + ", ";
                    queryString += "bcpd_aluminum8 = " + this.aluminum8.ToString() + ", ";
                    queryString += "bcpd_aluminum9 = " + this.aluminum9.ToString() + ", ";
                    queryString += "bcpd_aluminum10 = " + this.aluminum10.ToString() + ", ";
                    queryString += "bcpd_aluminum11 = " + this.aluminum11.ToString() + ", ";
                    queryString += "bcpd_aluminum12 = " + this.aluminum12.ToString() + ", ";
                    queryString += "bcpd_aluminum13 = " + this.aluminum13.ToString() + ", ";
                    queryString += "bcpd_aluminum14 = " + this.aluminum14.ToString() + ", ";
                    queryString += "bcpd_aluminum15 = " + this.aluminum15.ToString() + ", ";
                    queryString += "bcpd_aluminum16 = " + this.aluminum16.ToString() + ", ";
                    queryString += "bcpd_aluminum17 = " + this.aluminum17.ToString() + ", ";
                    queryString += "bcpd_aluminum18 = " + this.aluminum18.ToString() + ", ";
                    queryString += "bcpd_aluminum19 = " + this.aluminum19.ToString() + ", ";
                    queryString += "bcpd_aluminum20 = " + this.aluminum20.ToString() + ", ";
                    queryString += "bcpd_aluminum21 = " + this.aluminum21.ToString() + ", ";
                    queryString += "bcpd_aluminum22 = " + this.aluminum22.ToString() + ", ";
                    queryString += "bcpd_aluminum23 = " + this.aluminum23.ToString() + ", ";
                    queryString += "bcpd_aluminum24 = " + this.aluminum24.ToString() + ", ";
                    queryString += "bcpd_aluminum25 = " + this.aluminum25.ToString() + ", ";
                    queryString += "bcpd_aluminum26 = " + this.aluminum26.ToString() + ", ";
                    queryString += "bcpd_aluminum27 = " + this.aluminum27.ToString() + ", ";
                    queryString += "bcpd_aluminum28 = " + this.aluminum28.ToString() + ", ";
                    queryString += "bcpd_aluminum29 = " + this.aluminum29.ToString() + ", ";
                    queryString += "bcpd_aluminum30 = " + this.aluminum30.ToString() + ", ";
                    queryString += "bcpd_initSpeed = " + this.initSpeed.ToString() + ", ";
                    queryString += "bcpd_processSpeed = " + this.processSpeed.ToString() + ", ";
                    queryString += "bcpd_endSpeed = " + this.endSpeed.ToString() + ", ";
                    queryString += "bcpd_linearLength = " + this.linearLength.ToString() + ", ";
                    queryString += "bcpd_metalWeigth = " + this.metalWeigth.ToString() + ", ";
                    queryString += "bcpd_MainCoilMetal = '" + this.MainCoilMetal.ToString() + "', ";
                    queryString += "bcpd_notes = '" + this.notes.ToString() + "' ";
                    queryString += "WHERE bcpd_codsec=" + this.codsec.ToString()+";";
                }
                bool guardado=clsConnection.executeQuery(queryString);
                GC.Collect();
                GC.WaitForPendingFinalizers();
                return guardado;
            }
            catch (Exception ex)
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();

                clsLog.addLog(ex, 3, "clsMachineActivities.save");
                return false;
            }
        }
    }

}
