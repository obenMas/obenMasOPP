using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsSequentialMovementSiigo
    {
        public int E10 { get; set; }
        public int E21 { get; set; }
        public int E22 { get; set; }
        public int E43 { get; set; }
        public int H14 { get; set; }
        public int H22 { get; set; }
        public int H23 { get; set; }
        public int H47 { get; set; }
        public int S6 { get; set; }
        public int S8 { get; set; }
        public int S9 { get; set; }
        public int S10 { get; set; }
        public int S23 { get; set; }
        public int S25 { get; set; }
        public int E01 { get; set; }
        public int E11 { get; set; }
        public int E12 { get; set; }
        public int H13 { get; set; }
        public int S14 { get; set; }
        public int E23 { get; set; }
        public int E7 { get; set; }
        public int E37 { get; set; }
        public int E38 { get; set; }
        public int S1 { get; set; }
        public int S26 { get; set; }
        public int S18 { get; set; }
        public int S20 { get; set; }
        public int H56 { get; set; }

        public int E4 { get; set; }
        public int E5 { get; set; }
        public int E2 { get; set; }
        public int E35 { get; set; }
        public int E30 { get; set; }
        public int E31 { get; set; }
        public int E33 { get; set; }
        public int E36 { get; set; }

        public int H16 { get; set; }
        public int H4 { get; set; }
        public int H18 { get; set; }
        public int H17 { get; set; }
        public int H5 { get; set; }
        public int H1 { get; set; }
        public int H3 { get; set; }
        public int H7 { get; set; }
        public int H6 { get; set; }

        public int S19 { get; set; }
        public int S21 { get; set; }

        public clsSequentialMovementSiigo()
        {
            E10 = 0;
            E21 = 0;
            E22 = 0;
            E43 = 0;
            H14 = 0;
            H22 = 0;
            H23 = 0;
            H47 = 0;
            S6 = 0;
            S8 = 0;
            S9 = 0;
            S10 = 0;
            S23 = 0;
            S25 = 0;
            E01 = 0;
            E11 = 0;
            E12 = 0;
            H13 = 0;
            S14 = 0;
            E23 = 0;
            E7 = 0;
            E37 = 0;
            E38 = 0;
            S1 = 0;
            S26 = 0;
            S18 = 0;
            S20 = 0;
            H56 = 0;

            S19 = 0;
            S21 = 0;

            H6 = 0;
            H7 = 0;
            H3 = 0;
            H1 = 0;
            H16 = 0;
            H4 = 0;
            H18 = 0;
            H17 = 0;
            H5 = 0;

            E4 = 0;
            E5 = 0;
            E2 = 0;
            E35 = 0;
            E30 = 0;
            E31 = 0;
            E33 = 0;
            E36 = 0;
        }

        public void Load()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_xtr_siigoMovementsSequential");

            if (DS.Tables[0].Rows.Count > 0)
            {
                E10 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E010"]);
                E21 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E021"]);
                E22 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E022"]);
                E43 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E043"]);
                H14 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H014"]);
                H22 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H022"]);
                H23 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H023"]);
                H47 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H047"]);
                S6 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S006"]);
                S8 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S008"]);
                S9 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S009"]);
                S10 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S010"]);
                S23 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S023"]);
                S25 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S025"]);
                E01 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E001"]);
                E11 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E011"]);
                E12 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E012"]);
                H13 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H013"]);
                S14 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S014"]);
                E23 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E023"]);
                E7 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E007"]);
                E37 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E037"]);
                E38 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E038"]);
                S1 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S001"]);
                S26 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S026"]);
                S18 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S018"]);
                S20 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S020"]);
                H56 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H056"]);

                E31 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E031"]);
                E33 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E033"]);
                E36 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E036"]);
                E4 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E004"]);
                E5 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E005"]);
                E2 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E002"]);
                E35 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E035"]);
                E30 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E030"]);

                H16 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H016"]);
                H4 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H004"]);
                H18 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H018"]);
                H17 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H017"]);
                H5 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H005"]);
                H1 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H001"]);
                H3 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H003"]);
                H7 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H007"]);
                H6 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H006"]);

                S19 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S019"]);
                S21 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S021"]);
            }
        }

        public bool save()
        {
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E010 = " + E10);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E021 = " + E21);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E022 = " + E22);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E043 = " + E43);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H014 = " + H14);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H022 = " + H22);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H023 = " + H23);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H047 = " + H47);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S006 = " + S6);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S008 = " + S8);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S009 = " + S9);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S010 = " + S10);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S023 = " + S23);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S025 = " + S25);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E001 = " + E01);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E011 = " + E11);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E012 = " + E12);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H013 = " + H13);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S014 = " + S14);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E023 = " + E23);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E007 = " + E7);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E037 = " + E37);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E038 = " + E38);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S001 = " + S1);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S026 = " + S26);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S018 = " + S18);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S020 = " + S20);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H056 = " + H56);

            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E031 = " + E31);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E033 = " + E33);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E036 = " + E36);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E004 = " + E4);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E005 = " + E5);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E002 = " + E2);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E035 = " + E35);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E030 = " + E30);

            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H016 = " + H16);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H004 = " + H4);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H018 = " + H18);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H017 = " + H17);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H005 = " + H5);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H001 = " + H1);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H003 = " + H3);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H007 = " + H7);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H006 = " + H6);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S019 = " + S19);
            clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S021 = " + S21);

            return true;
        }
    }
}
