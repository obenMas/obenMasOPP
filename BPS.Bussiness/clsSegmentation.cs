using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;
using BPS.Bussiness;

namespace BPS.Bussiness
{    /// <summary>
    /// Clase para el manejo de la Segmentacion de los Clientes
    /// </summary>
   public class clsSegmentation
    {
        //Atributes

        private int cseg_codsec;
        private string cseg_SegmentationName;


        //Properties

        public int codsec { get { return cseg_codsec; } set { cseg_codsec = value; } }

        public string SegmentationName { get { return cseg_SegmentationName; } set { cseg_SegmentationName = value; } }

        //Constructor

        public clsSegmentation()
        {
            cseg_codsec = 0;
            cseg_SegmentationName = "";
        }

        public clsSegmentation(string name)
        {
            this.load(name);
        }

        public clsSegmentation(int number)
        {
            this.load(number);
        }
        //Methods

        public void load(int number)
        {

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_com_customerSegmentation where cseg_codsec = " + number.ToString());
            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cseg_codsec"]);
            this.SegmentationName = DS.Tables[0].Rows[0]["cseg_SegmentationName"].ToString();
        }

       public void load(string sname)
        {
            DataSet DS = new DataSet();


            DS = clsConnection.getDataSetResult("SELECT * FROM bps_com_customerSegmentation where cseg_SegmentationName = '" + sname + "'");
            this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cseg_codsec"]);
            this.SegmentationName = DS.Tables[0].Rows[0]["cseg_SegmentationName"].ToString();
        }


        public static List<clsSegmentation> getList()
        {
            List<clsSegmentation> lstSegmentation= new List<clsSegmentation>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_com_customerSegmentation");

            lstSegmentation.Clear();

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstSegmentation.Add(new clsSegmentation());
                lstSegmentation[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cseg_codsec"]);
                lstSegmentation[i].SegmentationName = DS.Tables[0].Rows[i]["cseg_SegmentationName"].ToString();
                
            }

            return lstSegmentation;
        }



    }
}
