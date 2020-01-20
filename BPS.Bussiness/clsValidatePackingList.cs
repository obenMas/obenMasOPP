using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsValidatePackingList
    {
        //Atributes
        private string code;
        private double palletnet;
        private double coilnet;
        private string info;
        private double totalcoilnet;
        
        //Properties
        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        public double PalletNetWeigth
        {
            get { return palletnet; }
            set { palletnet = value; }
        }
        public double CoilNetWeigth
        {
            get { return coilnet; }
            set { coilnet = value; }
        }
        public string Info
        {
            get { return info; }
            set { info = value; }
        }
        public double TotalCoilNetWeigth
        {
            get { return totalcoilnet; }
            set { totalcoilnet = value; }
        }
        //Constructor
        public clsValidatePackingList()
        {
            code = string.Empty;
            palletnet = 0;
            coilnet = 0;
            totalcoilnet = 0;
            info = string.Empty;
        }
        //Mehotus
        public static List<clsValidatePackingList> getList(int packinglist, int operation)
        {
            List<clsValidatePackingList> lstPackingList = new List<clsValidatePackingList>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("spValidatePackingList " + packinglist.ToString() + "," + operation.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstPackingList.Add(new clsValidatePackingList());
                    lstPackingList[i].Code = DS.Tables[0].Rows[i]["palletcode"].ToString();
                    lstPackingList[i].PalletNetWeigth = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["palletnet"]), 1);
                    lstPackingList[i].CoilNetWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["coilnet"]);
                    lstPackingList[i].Info = DS.Tables[0].Rows[i]["info"].ToString();
                } 
            }

            return lstPackingList;
        }

        public static double getTotalCoilNetWeigth(int packinglist, int operation)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("spValidatePackingList " + packinglist.ToString() + "," + operation.ToString());

            if (DS.Tables[0].Rows.Count > 0)
                return Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["coil_netWeight"].ToString()), 1);
            else
                return 0;
        }

        public static double getTotalPalletNetWeigth(int packinglist, int operation)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("spValidatePackingList " + packinglist.ToString() + "," + operation.ToString());

            if (DS.Tables[0].Rows.Count > 0)
                return Math.Round(Convert.ToDouble(DS.Tables[0].Rows[0]["plt_netweigth"].ToString()), 1);
            else
                return 0;
        }
    }
}
