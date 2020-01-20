using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsMainCoilLabel
    {
        //Atributtes
        private int mainCoilQuality;
        private double mainCoilGramaje;
        private int mainCoilQualityVw;
        private double thiknessAverage;

        //Properties
        public int maincoilquality { get { return mainCoilQuality; } set { mainCoilQuality = value; } }
        public double maincoilgramaje { get { return mainCoilGramaje; } set { mainCoilGramaje = value; } }
        public double thiknessaverage { get { return thiknessAverage; } set { thiknessAverage = value; } }
        public int maincoilqualityvw { get { return mainCoilQualityVw; } set { mainCoilQualityVw = value; } }

        //Constructor
        public clsMainCoilLabel()
        {
            mainCoilGramaje = 0;
            thiknessAverage = 0;
            mainCoilQuality = 0;
            mainCoilQualityVw = 0;
        }

        //Methods
        public static List<clsMainCoilLabel> getListByQuality(int Codsec)
        {
            List<clsMainCoilLabel> lstMainCoilLabel = new List<clsMainCoilLabel>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spGramajeByQuality(" + Codsec.ToString() + ")");

            lstMainCoilLabel.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstMainCoilLabel.Add(new clsMainCoilLabel());
                lstMainCoilLabel[i].maincoilquality = Convert.ToInt32(DS.Tables[0].Rows[i]["mcbq_fkMainCoilQuality"]);
                lstMainCoilLabel[i].maincoilgramaje = Convert.ToDouble(DS.Tables[0].Rows[i]["mainCoilGramaje"]);
            }
            return lstMainCoilLabel;
        }

        public static List<clsMainCoilLabel> getListByQualityVw(int Codsec)
        {
            List<clsMainCoilLabel> lstMainCoilLabel = new List<clsMainCoilLabel>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM vwmaincoilquality WHERE mcq_codsec = " + Codsec.ToString());

            lstMainCoilLabel.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstMainCoilLabel.Add(new clsMainCoilLabel());
                lstMainCoilLabel[i].maincoilqualityvw = Convert.ToInt32(DS.Tables[0].Rows[i]["mcq_codsec"]);
                lstMainCoilLabel[i].thiknessaverage = Convert.ToDouble(DS.Tables[0].Rows[i]["mcq_thiknessAverage"]);
            }
            return lstMainCoilLabel;
        }
        public static List<clsMainCoilLabel> getListByQualitySp(int Codsec)
        {
            List<clsMainCoilLabel> lstMainCoilLabel = new List<clsMainCoilLabel>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spMainCoilQuality(" + Codsec.ToString() + ")");

            lstMainCoilLabel.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstMainCoilLabel.Add(new clsMainCoilLabel());
                lstMainCoilLabel[i].maincoilqualityvw = Convert.ToInt32(DS.Tables[0].Rows[i]["mcq_codsec"]);
                lstMainCoilLabel[i].thiknessaverage = Convert.ToDouble(DS.Tables[0].Rows[i]["mcq_thiknessAverage"]);
            }
            return lstMainCoilLabel;
        }
    }
}
