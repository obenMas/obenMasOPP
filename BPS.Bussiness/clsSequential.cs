using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    public class clsSequential
    {
        //Attributes
        private int seq_year;
        private int seq_extrusionLot;
        private int seq_mainCoil;
        private int seq_mainCoilMetal;
        private int seq_coil;
        private int seq_pallet;
        private int seq_metallizedOrder;
        private int seq_maquile;
        private int seq_millpallet;
        private int seq_preshipping;
        private int seq_preshippingpl;
        private int seq_salesOrder;
        private int seq_month;
        private int seq_rawPallet;
        private int seq_newPreShipping;

        public int Seq_metallizedOrder
        {
            get { return seq_metallizedOrder; }
            set { seq_metallizedOrder = value; }
        }

        private int seq_rawMaterial;

        public int rawMaterial
        {
            get { return seq_rawMaterial; }
            set { seq_rawMaterial = value; }
        }



        //Properties
        public int year { get { return seq_year; } set { seq_year = value; } }

        public int extrusionLot { get { return seq_extrusionLot; } set { seq_extrusionLot = value; } }

        public int mainCoil { get { return seq_mainCoil; } set { seq_mainCoil = value; } }

        public int mainCoilMetal { get { return seq_mainCoilMetal; } set { seq_mainCoilMetal = value; } }

        public int coil { get { return seq_coil; } set { seq_coil = value; } }

        public int pallet { get { return seq_pallet; } set { seq_pallet = value; } }

        public int metallizedOrder { get { return seq_metallizedOrder; } set { seq_metallizedOrder = value; } }

        public int maquile { get { return seq_maquile; } set { seq_maquile = value; } }

        public int millPallet { get { return seq_millpallet; } set { seq_millpallet = value; } }

        public int preshipping { get { return seq_preshipping; } set { seq_preshipping = value; } }

        public int preshippingpl { get { return seq_preshippingpl; } set { seq_preshippingpl = value; } }

        public int salesOrder { get { return seq_salesOrder; } set { seq_salesOrder = value; } }

        public int month { get { return seq_month; } set { seq_month = value; } }

        public int rawPallet { get { return seq_rawPallet; } set { seq_rawPallet = value; } }

        public int newpreshipping { get { return seq_newPreShipping; } set { seq_newPreShipping = value; } }

        //Constructors
        public clsSequential()
        {
            DataSet DS = new DataSet();

            year = 0;
            extrusionLot = 0;
            mainCoil = 0;
            coil = 0;
            pallet = 0;
            metallizedOrder = 0;
            maquile = 0;
            seq_millpallet = 0;
            rawMaterial = 0;
            preshipping = 0;
            preshippingpl = 0;
            salesOrder = 0;
            month = 0;
            rawPallet = 0;
            newpreshipping = 0;

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_sequential");

            if (DS.Tables[0].Rows.Count > 0)
            {
                year = Convert.ToInt32(DS.Tables[0].Rows[0]["seq_year"]);
                extrusionLot = Convert.ToInt32(DS.Tables[0].Rows[0]["seq_extrusionLot"]);
                mainCoil = Convert.ToInt32(DS.Tables[0].Rows[0]["seq_mainCoil"]);
                coil = Convert.ToInt32(DS.Tables[0].Rows[0]["seq_coil"]);
                pallet = Convert.ToInt32(DS.Tables[0].Rows[0]["seq_pallet"]);
                metallizedOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["seq_metallizedOrder"]);
                maquile = Convert.ToInt32(DS.Tables[0].Rows[0]["seq_maquile"]);
                mainCoilMetal = Convert.ToInt32(DS.Tables[0].Rows[0]["seq_mainCoilMetal"]);
                millPallet = Convert.ToInt32(DS.Tables[0].Rows[0]["seq_millPallet"]);
                rawMaterial = Convert.ToInt32(DS.Tables[0].Rows[0]["seq_rawMaterial"]);
                preshipping = Convert.ToInt32(DS.Tables[0].Rows[0]["seq_preshipping"]);
                preshippingpl = Convert.ToInt32(DS.Tables[0].Rows[0]["seq_preshippingpl"]);
                salesOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["seq_salesOrder"]);
                month = Convert.ToInt32(DS.Tables[0].Rows[0]["seq_month"]);
                rawPallet = Convert.ToInt32(DS.Tables[0].Rows[0]["seq_rawPallet"]);
                newpreshipping = Convert.ToInt32(DS.Tables[0].Rows[0]["seq_newPreShipping"]);
            }

            if (DateTime.Now.Year > year)
            {
                clsConnection.executeQuery("UPDATE bps_admin_sequential SET seq_year = " + DateTime.Now.Year.ToString() + ", seq_extrusionLot = 1, seq_mainCoil = 1, seq_coil = 1, seq_pallet = 1, seq_metallizedOrder = 1, seq_maquile = 1, seq_millPallet = 1, seq_rawMaterial = 1, seq_newPreShipping = 1");
                year = DateTime.Now.Year;
                extrusionLot = 1;
                mainCoil = 1;
                coil = 1;
                pallet = 1;
                metallizedOrder = 1;
                maquile = 1;
                millPallet = 1;
                rawMaterial = 1;
                rawPallet = 1;
                newpreshipping = 1;
            }

            if(DateTime.Now.Month > month)
            {
                clsConnection.executeQuery("UPDATE bps_admin_sequential SET seq_month = " + DateTime.Now.Month.ToString() + ",  seq_salesOrder = 1");
                salesOrder = 1;
                //newpreshipping = 1;
            }
        }

        //Methods
        public static void addSequential(string sequentialName)
        {
            switch (sequentialName)
            {
                case "extrusionLot":
                    clsConnection.executeQuery("UPDATE bps_admin_sequential SET seq_extrusionLot = seq_extrusionLot + 1");
                    break;
                case "mainCoil":
                    clsConnection.executeQuery("UPDATE bps_admin_sequential SET seq_mainCoil = seq_mainCoil + 1");
                    break;
                case "mainCoilMetal":
                    clsConnection.executeQuery("UPDATE bps_admin_sequential SET seq_mainCoilMetal = seq_mainCoilMetal + 1");
                    break;
                case "coil":
                    clsConnection.executeQuery("UPDATE bps_admin_sequential SET seq_coil = seq_coil + 1");
                    break;
                case "pallet":
                    clsConnection.executeQuery("UPDATE bps_admin_sequential SET seq_pallet = seq_pallet + 1");
                    break;
                case "metallizedOrder":
                    clsConnection.executeQuery("UPDATE bps_admin_sequential SET seq_metallizedOrder = seq_metallizedOrder + 1");
                    break;
                case "maquile":
                    clsConnection.executeQuery("UPDATE bps_admin_sequential SET seq_maquile = seq_maquile + 1");
                    break;
                case "millPallet":
                    clsConnection.executeQuery("UPDATE bps_admin_sequential SET seq_millPallet = seq_millPallet + 1");
                    break;
                case "rawMaterial":
                    clsConnection.executeQuery("UPDATE bps_admin_sequential SET seq_rawMaterial = seq_rawMaterial + 1");
                    break;
                case "extRM":
                    clsConnection.executeQuery("UPDATE bps_admin_sequential SET seq_extRM = seq_extRM + 1");
                    break;

                case "rawMaterialD":
                    clsConnection.executeQuery("UPDATE bps_admin_sequential SET seq_rawD = seq_rawD + 1");
                    break;

                case "preshipping":
                    clsConnection.executeQuery("UPDATE bps_admin_sequential SET seq_preshipping = seq_preshipping + 1");
                    break;

                case "preshippingpl":
                    clsConnection.executeQuery("UPDATE bps_admin_sequential SET seq_preshippingpl = seq_preshippingpl + 1");
                    break;

                case "salesOrder":
                    clsConnection.executeQuery("UPDATE bps_admin_sequential SET seq_salesOrder = seq_salesOrder + 1");
                    break;

                case "rawPallet":
                    clsConnection.executeQuery("UPDATE bps_admin_sequential SET seq_rawPallet = seq_rawPallet + 1");
                    break;

                case "newpreshipping":
                    clsConnection.executeQuery("UPDATE bps_admin_sequential SET seq_newPreShipping = seq_newPreShipping + 1");
                    break;
            }
        }

        public static int toSequentialMainCoil()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_sequential");

            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(DS.Tables[0].Rows[0]["seq_mainCoilMetal"]);
            else
                return 0;
        }

        public static int toSequentialMillPallet()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_sequential");

            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(DS.Tables[0].Rows[0]["seq_millPallet"]);
            else
                return 0;
        }

        public static int SequentialList(string sequentialName)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_sequential");
            if (sequentialName == "metallizedOrder")
            {
                if (DS.Tables[0].Rows.Count > 0)
                    return Convert.ToInt32(DS.Tables[0].Rows[0]["seq_metallizedOrder"]);
                else
                    return 0;
            }
            else if (sequentialName == "rawMaterial")
            {
                if (DS.Tables[0].Rows.Count > 0)
                    return Convert.ToInt32(DS.Tables[0].Rows[0]["seq_rawMaterial"]);
                else
                    return 0;
            }
            else if (sequentialName == "rawMaterialD")
            {
                if (DS.Tables[0].Rows.Count > 0)
                    return Convert.ToInt32(DS.Tables[0].Rows[0]["seq_rawD"]);
                else
                    return 0;
            }
            else if (sequentialName == "extRM")
            {
                if (DS.Tables[0].Rows.Count > 0)
                    return Convert.ToInt32(DS.Tables[0].Rows[0]["seq_extRM"]);
                else
                    return 0;
            }
            else if (sequentialName == "preshipping")
            {
                if(DS.Tables[0].Rows.Count > 0)
                {
                    return Convert.ToInt32(DS.Tables[0].Rows[0]["seq_preshipping"]);
                }
                else
                {
                    return 0;
                }
            }
            else if(sequentialName == "preshippingpl")
            {
                if (DS.Tables[0].Rows.Count > 0)
                {
                    return Convert.ToInt32(DS.Tables[0].Rows[0]["seq_preshippingpl"]);
                }
                else
                {
                    return 0;
                }
            }
            else if (sequentialName == "salesOrder")
            {
                if (DS.Tables[0].Rows.Count > 0)
                {
                    return Convert.ToInt32(DS.Tables[0].Rows[0]["seq_salesOrder"]);
                }
                else
                {
                    return 0;
                }
            }
            else if (sequentialName == "rawPallet")
            {
                if (DS.Tables[0].Rows.Count > 0)
                {
                    return Convert.ToInt32(DS.Tables[0].Rows[0]["seq_rawPallet"]);
                }
                else
                {
                    return 0;
                }
            }
            else if (sequentialName == "newpreshipping")
            {
                if (DS.Tables[0].Rows.Count > 0)
                {
                    return Convert.ToInt32(DS.Tables[0].Rows[0]["seq_newPreShipping"]);
                }
                else
                {
                    return 0;
                }
            }
            else
                return 0;
        }

        public static bool updateSequential(int number)
        {
            return clsConnection.executeQuery("UPDATE bps_admin_sequential SET seq_mainCoilMetal = " + number.ToString());
        }

        public static bool updateSequentialMillPallet(int number)
        {
            return clsConnection.executeQuery("UPDATE bps_admin_sequential SET seq_millPallet = " + number.ToString());
        }

        public static bool updateSequentialRawMaterialPallet(int number)
        {
            return clsConnection.executeQuery("UPDATE bps_admin_sequential SET seq_rawMaterial = " + number.ToString());
        }

        public static bool updRawR(int number)
        {
            return clsConnection.executeQuery("UPDATE bps_admin_sequential SET seq_rawD = " + number.ToString());
        }

        public static bool updPreshipping (int number)
        {
            return clsConnection.executeQuery("UPDATE bps_admin_sequential SET seq_preshipping = " + number.ToString());
        }

        public static bool updsalesOrder(int number)
        {
            return clsConnection.executeQuery("UPDATE bps_admin_sequential SET seq_salesOrder = " + number.ToString());
        }

        public static bool updPreshippingpl(int number)
        {
            return clsConnection.executeQuery("UPDATE bps_admin_sequential SET seq_preshippingpl = " + number.ToString());
        }

        public static bool updRawPallet(int number)
        {
            return clsConnection.executeQuery("UPDATE bps_admin_sequential SET seq_rawPallet = " + number.ToString());
        }

        public static bool updnewPreShipping(int number)
        {
            return clsConnection.executeQuery("UPDATE bps_admin_sequential SET seq_newPreShipping = " + number.ToString());
        }

        public static void addSequential()
        {
            clsConnection.executeQuery("UPDATE bps_admin_sequential SET seq_metallizedOrder = 0");
            clsConnection.executeQuery("UPDATE bps_admin_sequential SET seq_year = " + DateTime.Now.Year.ToString());
        }
    }
}
