using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra las ordenes de metalizado
    /// </summary>
    public class clsMetallizedOrder
    {
        //Atributes

        private int mto_codsec;
        private int mto_fkMachine;
        private string mto_MachineName;
        private string mto_MachineNumber;
        private int mto_fkStatus;
        private string mto_StatusName;
        private string mto_number;
        private int mto_fkproductFrom;
        private string mto_productFromCode;
        private string mto_productFromName;
        private int mto_prodfkBoppFrom;
        private int mto_prodfkBoppTo;
        private int mto_prodfkCastFrom;
        private int mto_prodfkCastTo;
        private int mto_fkproductTo;
        private int mto_fkproductToo;
        private string mto_productToCode;
        private string mto_productToName;
        private double mto_opticDensity;
        private double mto_quantityCoils;
        private string mto_notes;
        private DateTime mto_createdDate;
        private DateTime mto_modifiedDate;
        private int mto_createdBy;
        private string mto_creatorUser;
        private int mto_modifiedBy;
        private string mto_modificatorUser;
        private List<clsPallet> mto_lstPallets;
        private clsPallet mto_pallet;
        private clsCoil mto_coil;

        private double mto_kg;
        private double mto_totalweigth;
        private int mto_fkoriginbase;
        private int mto_fkcodsecdetail;
        private string mto_type;
        private string mto_customerfrom;
        private string mto_customerto;
        private string mto_lotnumber;
        private DateTime mto_estimateInitDate;
        private DateTime mto_estimateEndDate;
        private string mto_ordenation;
        private int mto_widthFrom;
        private int mto_widthTo;
        private string mto_productTooName;
        private int mto_widthToo;

        private int mto_fkFilmProduction;

        public int fkFilmProduction
        {
            get { return mto_fkFilmProduction; }
            set { mto_fkFilmProduction = value; }
        }



        //Properties

        public int codsec { get { return mto_codsec; } set { mto_codsec = value; } }

        public int fkMachine { get { return mto_fkMachine; } set { mto_fkMachine = value; } }

        public string MachineName { get { return mto_MachineName; } set { mto_MachineName = value; } }

        public string MachineNumber { get { return mto_MachineNumber; } set { mto_MachineNumber = value; } }

        public int fkStatus { get { return mto_fkStatus; } set { mto_fkStatus = value; } }

        public string StatusName { get { return mto_StatusName; } set { mto_StatusName = value; } }

        public int prodfkBoppFrom { get { return mto_prodfkBoppFrom; } set { mto_prodfkBoppFrom = value; } }

        public int prodfkBoppTo { get { return mto_prodfkBoppTo; } set { mto_prodfkBoppTo = value; } }

        public int prodfkCastFrom { get { return mto_prodfkCastFrom; } set { mto_prodfkCastFrom = value; } }

        public int prodfkCastTo { get { return mto_prodfkCastTo; } set { mto_prodfkCastTo = value; } }

        public int fkproductFrom { get { return mto_fkproductFrom; } set { mto_fkproductFrom = value; } }

        public string productFromCode { get { return mto_productFromCode; } set { mto_productFromCode = value; } }

        public string productFromName { get { return mto_productFromName; } set { mto_productFromName = value; } }

        public int fkproductTo { get { return mto_fkproductTo; } set { mto_fkproductTo = value; } }

        public int fkproductToo { get { return mto_fkproductToo; } set { mto_fkproductToo = value; } }

        public string productToCode { get { return mto_productToCode; } set { mto_productToCode = value; } }

        public string productToName { get { return mto_productToName; } set { mto_productToName = value; } }

        public string productTooName { get { return mto_productTooName; } set { mto_productTooName = value; } }

        public string number { get { return mto_number; } set { mto_number = value; } }

        public double opticDensity { get { return mto_opticDensity; } set { mto_opticDensity = value; } }

        public double quantityCoils { get { return mto_quantityCoils; } set { mto_quantityCoils = value; } }

        public string notes { get { return mto_notes; } set { mto_notes = value; } }

        public DateTime createdDate { get { return mto_createdDate; } set { mto_createdDate = value; } }

        public DateTime modifiedDate { get { return mto_modifiedDate; } set { mto_modifiedDate = value; } }

        public int createdBy { get { return mto_createdBy; } set { mto_createdBy = value; } }

        public string creatorUser { get { return mto_creatorUser; } set { mto_creatorUser = value; } }

        public int modifiedBy { get { return mto_modifiedBy; } set { mto_modifiedBy = value; } }

        public string modificatorUser { get { return mto_modificatorUser; } set { mto_modificatorUser = value; } }

        public List<clsPallet> lstPallets { get { return mto_lstPallets; } set { mto_lstPallets = value; } }

        public clsPallet Pallet { get { return mto_pallet; } set { mto_pallet = value; } }

        public clsCoil Coil { get { return mto_coil; } set { mto_coil = value; } }

        public double kg { get { return mto_kg; } set { mto_kg = value; } }

        public double totalweigth { get { return mto_totalweigth; } set { mto_totalweigth = value; } }

        public int fkoriginbase { get { return mto_fkoriginbase; } set { mto_fkoriginbase = value; } }

        public int codsecdetail { get { return mto_fkcodsecdetail; } set { mto_fkcodsecdetail = value; } }

        public string type { get { return mto_type; } set { mto_type = value; } }

        public string customerfrom { get { return mto_customerfrom; } set { mto_customerfrom = value; } }

        public string customerto { get { return mto_customerto; } set { mto_customerto = value; } }

        public string lotnumber { get { return mto_lotnumber; } set { mto_lotnumber = value; } }

        public DateTime initDate { get { return mto_estimateInitDate; } set { mto_estimateInitDate = value; } }

        public DateTime endDate { get { return mto_estimateEndDate; } set { mto_estimateEndDate = value; } }

        public string ordenation { get { return mto_ordenation; } set { mto_ordenation = value; } }

        public int widthFrom { get { return mto_widthFrom; } set { mto_widthFrom = value; } }

        public int widthTo { get { return mto_widthTo; } set { mto_widthTo = value; } }

        public int widthToo { get { return mto_widthToo; } set { mto_widthToo = value; } }

        //Constructor

        public clsMetallizedOrder()
        {
            mto_codsec = 0;
            mto_fkMachine = 0;
            mto_MachineName = "";
            mto_MachineNumber = "";
            mto_fkStatus = 0;
            mto_StatusName = "";
            mto_prodfkBoppFrom = 0;
            mto_prodfkBoppTo = 0;
            mto_prodfkCastFrom = 0;
            mto_prodfkCastTo = 0;
            mto_fkproductFrom = 0;
            mto_productFromCode = "";
            mto_productFromName = "";
            mto_fkproductTo = 0;
            mto_productToCode = "";
            mto_productToName = "";
            mto_number = "";
            mto_opticDensity = 0;
            mto_quantityCoils = 0;
            mto_notes = "";
            mto_createdDate = DateTime.Now;
            mto_modifiedDate = DateTime.Now;
            mto_createdBy = 0;
            mto_creatorUser = "";
            mto_modifiedBy = 0;
            mto_modificatorUser = "";
            mto_lstPallets = new List<clsPallet>();
        }

        public clsMetallizedOrder(int codsec)
        {
            Loader(codsec);
        }

        public clsMetallizedOrder(int codsec, bool data)
        {
            Loader(codsec, data);
        }

        //Methods


        public void Loader(int metallizedOrderCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_metalizedorder WHERE mto_codsec = " + metallizedOrderCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_codsec"]);
                fkMachine = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_fkMachine"]);
                //MachineName = DS.Tables[0].Rows[0]["mto_MachineName"].ToString();
                //MachineNumber = DS.Tables[0].Rows[0]["mto_MachineNumber"].ToString();
                fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_fkStatus"]);
                //StatusName = DS.Tables[0].Rows[0]["mto_StatusName"].ToString();
                prodfkBoppFrom = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_fkProductFrom"]);
                prodfkBoppTo = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_fkProductFrom"]);
                //prodfkCastFrom = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_prodfkCastFrom"]);
                //prodfkCastTo = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_prodfkCastTo"]);
                fkproductFrom = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_fkproductFrom"]);
                ordenation = DS.Tables[0].Rows[0]["mto_ordenation"].ToString();
                //productFromCode = DS.Tables[0].Rows[0]["mto_productFromCode"].ToString();
                //productFromName = DS.Tables[0].Rows[0]["mto_productFromName"].ToString();
                //fkproductTo = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_fkproductTo"]);
                lotnumber = DS.Tables[0].Rows[0]["mto_lotnumber"].ToString();
                //productToName = DS.Tables[0].Rows[0]["mto_productToName"].ToString();
                number = DS.Tables[0].Rows[0]["mto_number"].ToString();
                //opticDensity = Convert.ToDouble(DS.Tables[0].Rows[0]["mto_opticDensity"]);
                //quantityCoils = Convert.ToDouble(DS.Tables[0].Rows[0]["mto_quantityCoils"]);
                //notes = DS.Tables[0].Rows[0]["mto_notes"].ToString();
                //createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mto_createdDate"]);
                //modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mto_modifiedDate"]);
                //createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_createdBy"]);
                //creatorUser = DS.Tables[0].Rows[0]["mto_creatorUser"].ToString();
                //modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_modifiedBy"]);
                //modificatorUser = DS.Tables[0].Rows[0]["mto_modificatorUser"].ToString();
                //lstPallets = clsPallet.getListByMetallizedOrder(codsec);
            }
        }

        public void Loader(int metallizedOrderCodsec, bool data)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spMetalizeOrderByCodsec " + metallizedOrderCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                customerfrom = DS.Tables[0].Rows[0]["customerFrom"].ToString();
                customerto = DS.Tables[0].Rows[0]["countryTo"].ToString();
                number = DS.Tables[0].Rows[0]["sord_number"].ToString();
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_codsec"]);
                fkMachine = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_fkMachine"]);
                MachineName = DS.Tables[0].Rows[0]["met_name"].ToString();
                fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_fkStatus"]);
                StatusName = DS.Tables[0].Rows[0]["stt_name"].ToString();
                fkproductFrom = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_fkProductFrom"]);
                productFromName = DS.Tables[0].Rows[0]["mto_productFromName"].ToString();
                productFromCode = DS.Tables[0].Rows[0]["mto_BoppFrom"].ToString();
                widthFrom = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_ProductFromWidth"]);
                fkproductTo = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_fkProductTo"]);
                productToName = DS.Tables[0].Rows[0]["mto_productToName"].ToString();
                productTooName = DS.Tables[0].Rows[0]["mto_productTooName"].ToString();
                productToCode = DS.Tables[0].Rows[0]["mto_productToMaterial"].ToString();
                widthTo = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_productToWidth"]);
                number = DS.Tables[0].Rows[0]["mto_number"].ToString();
                opticDensity = Convert.ToDouble(DS.Tables[0].Rows[0]["mto_opticDensity"]);
                notes = DS.Tables[0].Rows[0]["mto_notes"].ToString();
                createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mto_createdDate"]);
                kg = Convert.ToDouble(DS.Tables[0].Rows[0]["mto_kg"]);
                totalweigth = Convert.ToDouble(DS.Tables[0].Rows[0]["mto_totalweigth"]);
                fkoriginbase = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_fkoriginbase"]);
                ordenation = DS.Tables[0].Rows[0]["mto_ordenation"].ToString();
                type = DS.Tables[0].Rows[0]["mto_type"].ToString();
                quantityCoils = Convert.ToDouble(DS.Tables[0].Rows[0]["mto_quantityCoils"]);
                lotnumber = DS.Tables[0].Rows[0]["mto_lotnumber"].ToString();
                initDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mto_estimateinitdate"]);
                endDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mto_estimateenddate"]);
            }
        }

        public void load(int metallizedOrderCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwmetallizedorder where mto_codsec = " + metallizedOrderCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_codsec"]);
                fkMachine = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_fkMachine"]);
                MachineName = DS.Tables[0].Rows[0]["mto_MachineName"].ToString();
                //MachineNumber = DS.Tables[0].Rows[0]["mto_MachineNumber"].ToString();
                fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_fkStatus"]);
                StatusName = DS.Tables[0].Rows[0]["mto_StatusName"].ToString();
                prodfkBoppFrom = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_prodfkBoppFrom"]);
                prodfkBoppTo = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_prodfkBoppTo"]);
                prodfkCastFrom = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_prodfkCastFrom"]);
                prodfkCastTo = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_prodfkCastTo"]);
                fkproductFrom = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_fkproductFrom"]);
                productFromCode = DS.Tables[0].Rows[0]["mto_productFromCode"].ToString();
                productFromName = DS.Tables[0].Rows[0]["mto_productFromName"].ToString();
                fkproductTo = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_fkproductTo"]);
                productToCode = DS.Tables[0].Rows[0]["mto_productToCode"].ToString();
                productToName = DS.Tables[0].Rows[0]["mto_productToName"].ToString();
                number = DS.Tables[0].Rows[0]["mto_number"].ToString();
                opticDensity = Convert.ToDouble(DS.Tables[0].Rows[0]["mto_opticDensity"]);
                quantityCoils = Convert.ToDouble(DS.Tables[0].Rows[0]["mto_quantityCoils"]);
                notes = DS.Tables[0].Rows[0]["mto_notes"].ToString();
                createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mto_createdDate"]);
                modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["mto_modifiedDate"]);
                createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_createdBy"]);
                creatorUser = DS.Tables[0].Rows[0]["mto_creatorUser"].ToString();
                modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_modifiedBy"]);
                modificatorUser = DS.Tables[0].Rows[0]["mto_modificatorUser"].ToString();
                lstPallets = clsPallet.getListByMetallizedOrder(codsec);
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    clsStatus objStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Orden de metalizado", "Activa");

                    queryString += "INSERT INTO bps_prod_metalizedorder (mto_fkMachine, mto_fkStatus,mto_fkproductFrom,mto_fkproductTo, mto_number,mto_opticDensity, mto_quantityCoils, mto_notes,mto_createdDate, mto_modifiedDate, mto_createdBy, mto_modifiedBy, mtp_fkproductToo) ";
                    queryString += " VALUES (";
                    queryString += "" + this.fkMachine.ToString() + ", ";
                    queryString += "" + objStatus.codsec.ToString() + ", ";
                    queryString += "" + this.fkproductFrom.ToString() + ", ";
                    queryString += "" + this.fkproductTo.ToString() + ", ";
                    queryString += "'" + this.number.ToString() + "', ";
                    queryString += "" + this.opticDensity.ToString() + ", ";
                    queryString += "" + this.quantityCoils.ToString() + ", ";
                    queryString += "'" + this.notes.ToString() + "', ";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "" + clsGlobal.LoggedUser.codsec.ToString() + ", ";
                    queryString += "" + clsGlobal.LoggedUser.codsec.ToString() + ", ";
                    queryString += "" + this.fkproductToo.ToString() + " ";
                    queryString += ");";
                    clsConnection.executeQuery(queryString);
                }
                else
                {
                    queryString += "UPDATE bps_prod_metalizedorder";
                    queryString += " SET ";
                    queryString += "mto_fkMachine = " + this.fkMachine.ToString() + ", ";
                    queryString += "mto_fkStatus = " + this.fkStatus.ToString() + ", ";
                    queryString += "mto_fkproductFrom = " + this.fkproductFrom.ToString() + ", ";
                    queryString += "mto_fkproductTo = " + this.fkproductTo.ToString() + ", ";
                    queryString += "mto_fkproductToo = " + this.fkproductToo.ToString() + ", ";
                    queryString += "mto_number = '" + this.number.ToString() + "', ";
                    queryString += "mto_opticDensity = " + this.opticDensity.ToString() + ", ";
                    queryString += "mto_quantityCoils = " + this.quantityCoils.ToString() + ", ";
                    queryString += "mto_notes = '" + this.notes.ToString() + "', ";
                    queryString += "mto_modifiedDate = " + "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "mto_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + " ";
                    queryString += " WHERE mto_codsec = " + this.codsec.ToString() + ";";

                    clsConnection.executeQuery(queryString);
                }

                if (this.codsec == 0)
                {
                    clsSequential.addSequential("metallizedOrder");
                    this.codsec = clsMetallizedOrder.getLastSavedCodsec();
                }

                clsConnection.executeQuery("DELETE FROM bps_prod_palletbymetallizedorder WHERE pbmo_fkMetallizedOrder = " + this.codsec.ToString());

                for (int i = 0; i < this.lstPallets.Count; i++)
                {
                    clsConnection.executeQuery("INSERT INTO bps_prod_palletbymetallizedorder (pbmo_fkMetallizedOrder, pbmo_fkPallet) VALUES (" + this.codsec.ToString() + ", " + this.lstPallets[i].codsec.ToString() + ")");
                }

                return true;
            }

            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMetallizedOrder.save");
                return false;
            }
        }

        public bool savewithdetail()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    clsStatus objStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Orden de metalizado", "Activa");

                    queryString += "INSERT INTO bps_prod_metalizedorder (mto_fkMachine, mto_fkStatus,mto_fkproductFrom,mto_fkproductTo, mto_number,mto_opticDensity, mto_quantityCoils, mto_notes,mto_createdDate, mto_modifiedDate, mto_createdBy, mto_modifiedBy, mto_kg, mto_totalweigth, mto_fkoriginbase, mto_ordenation, mto_type, mto_lotnumber, mto_estimateinitdate) ";
                    queryString += " VALUES (";
                    queryString += "" + this.fkMachine.ToString() + ", ";
                    queryString += "" + objStatus.codsec.ToString() + ", ";
                    queryString += "" + this.fkproductFrom.ToString() + ", ";
                    queryString += "" + this.fkproductTo.ToString() + ", ";
                    queryString += "'" + this.number.ToString() + "', ";
                    queryString += "" + this.opticDensity.ToString() + ", ";
                    queryString += "" + this.quantityCoils.ToString() + ", ";
                    queryString += "'" + this.notes.ToString() + "', ";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "" + clsGlobal.LoggedUser.codsec.ToString() + ", ";
                    queryString += "" + clsGlobal.LoggedUser.codsec.ToString() + ", ";
                    queryString += "" + kg + ", ";
                    queryString += "" + totalweigth + ", ";
                    queryString += "" + fkoriginbase + ", ";
                    queryString += "0, ";
                    queryString += "'" + type + "', ";
                    queryString += "'" + lotnumber + "', ";
                    queryString += "'" + initDate.ToString("dd/MM/yyyy hh:mm:ss") + "' ";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_metalizedorder";
                    queryString += " SET ";
                    queryString += "mto_ordenation = " + this.ordenation.ToString() + ", ";
                    queryString += "mto_modifiedDate = " + "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "mto_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + " ";
                    queryString += " WHERE mto_codsec = " + this.codsec.ToString() + ";";
                }

                if (clsConnection.executeQuery(queryString))
                {
                    if (this.codsec == 0 && this.codsecdetail != 0)
                    {
                        clsSequential.addSequential("metallizedOrder");
                        this.codsec = clsMetallizedOrder.getLastSavedCodsec();
                        clsConnection.executeQuery("INSERT INTO bps_prod_metalizepersalesorderdetail (mtosod_fkMetailizeOrder, mtosod_fkSalesOrderDetail) VALUES (" + this.codsec.ToString() + ", " + this.codsecdetail.ToString() + ")");
                    }
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMetallizedOrder.save");
                return false;
            }
        }

        public bool savewithdetail(List<int> lstDetails)
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    clsStatus objStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Orden de metalizado", "Activa");

                    queryString += "INSERT INTO bps_prod_metalizedorder (mto_fkMachine, mto_fkStatus,mto_fkproductFrom,mto_fkproductTo, mto_number,mto_opticDensity, mto_quantityCoils, mto_notes,mto_createdDate, mto_modifiedDate, mto_createdBy, mto_modifiedBy, mto_kg, mto_totalweigth, mto_fkoriginbase, mto_ordenation, mto_type, mto_lotnumber, mto_estimateinitdate, mtp_fkproductToo) ";
                    queryString += " VALUES (";
                    queryString += "" + this.fkMachine.ToString() + ", ";
                    queryString += "" + objStatus.codsec.ToString() + ", ";
                    queryString += "" + this.fkproductFrom.ToString() + ", ";
                    queryString += "" + this.fkproductTo.ToString() + ", ";
                    queryString += "'" + this.number.ToString() + "', ";
                    queryString += "" + this.opticDensity.ToString() + ", ";
                    queryString += "" + this.quantityCoils.ToString() + ", ";
                    queryString += "'" + this.notes.ToString() + "', ";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "" + clsGlobal.LoggedUser.codsec.ToString() + ", ";
                    queryString += "" + clsGlobal.LoggedUser.codsec.ToString() + ", ";
                    queryString += "" + kg + ", ";
                    queryString += "" + totalweigth + ", ";
                    queryString += "" + fkoriginbase + ", ";
                    queryString += "0, ";
                    queryString += "'" + type + "', ";
                    queryString += "'" + lotnumber + "', ";
                    queryString += "'" + initDate.ToString("dd/MM/yyyy hh:mm:ss") + "', ";
                    queryString += "" + fkproductToo.ToString() + " ";
                    queryString += ");";
                }
                else
                {
                    queryString += "UPDATE bps_prod_metalizedorder";
                    queryString += " SET ";
                    queryString += "mto_ordenation = " + this.ordenation.ToString() + ", ";
                    queryString += "mto_modifiedDate = " + "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "mto_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + " ";
                    queryString += " WHERE mto_codsec = " + this.codsec.ToString() + ";";
                }

                if (clsConnection.executeQuery(queryString))
                {
                    clsSequential.addSequential("metallizedOrder");

                    if (this.codsec == 0 && lstDetails.Count > 0)
                    {
                        for (int i = 0; i < lstDetails.Count; i++)
                        {
                            this.codsec = clsMetallizedOrder.getLastSavedCodsec();
                            clsConnection.executeQuery("INSERT INTO bps_prod_metalizepersalesorderdetail (mtosod_fkMetailizeOrder, mtosod_fkSalesOrderDetail) VALUES (" + this.codsec.ToString() + ", " + lstDetails[i].ToString() + ")");
                        }
                    }
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMetallizedOrder.save");
                return false;
            }
        }

        public bool updatePos()
        {
            try
            {
                string queryString = "";

                queryString += "UPDATE bps_prod_metalizedorder";
                queryString += " SET ";
                queryString += "mto_ordenation = " + this.ordenation.ToString() + ", ";
                queryString += "mto_modifiedDate = " + "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                queryString += "mto_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + " ";
                queryString += " WHERE mto_codsec = " + this.codsec.ToString() + ";";

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMetallizedOrder.save");
                return false;
            }
        }

        public static bool toCrossOrder(int codsec)
        {
            try
            {
                string queryString = "";

                queryString += "UPDATE bps_prod_metalizedorder";
                queryString += " SET ";
                queryString += "mto_fkStatus = " + clsStatus.getStatusByStatusGroupNameAndStatusName("Orden de metalizado", "Anulada").codsec.ToString() + ", ";
                queryString += "mto_modifiedDate = " + "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                queryString += "mto_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + " ";
                queryString += " WHERE mto_codsec = " + codsec.ToString() + ";";

                clsConnection.executeQuery("DELETE bps_prod_metalizepersalesorderdetail WHERE mtosod_fkMetailizeOrder = " + codsec.ToString());

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMetallizedOrder.save");
                return false;
            }
        }

        public static bool toProcessOrder(int codsec)
        {
            try
            {
                string queryString = "";

                queryString += "UPDATE bps_prod_metalizedorder";
                queryString += " SET ";
                queryString += "mto_fkStatus = " + clsStatus.getStatusByStatusGroupNameAndStatusName("Orden de metalizado", "Proceso").codsec.ToString() + ", ";
                queryString += "mto_modifiedDate = " + "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                queryString += "mto_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + " ";
                queryString += " WHERE mto_codsec = " + codsec.ToString() + ";";

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMetallizedOrder.save");
                return false;
            }
        }

        public static bool toPauseOrder(int codsec)
        {
            try
            {
                string queryString = "";

                queryString += "UPDATE bps_prod_metalizedorder";
                queryString += " SET ";
                queryString += "mto_fkStatus = " + clsStatus.getStatusByStatusGroupNameAndStatusName("Orden de metalizado", "Pause").codsec.ToString() + ", ";
                queryString += "mto_modifiedDate = " + "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                queryString += "mto_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + " ";
                queryString += " WHERE mto_codsec = " + codsec.ToString() + ";";

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMetallizedOrder.save");
                return false;
            }
        }

        public static bool toCloseOrder(int codsec)
        {
            try
            {
                string queryString = "";

                queryString += "UPDATE bps_prod_metalizedorder";
                queryString += " SET ";
                queryString += "mto_fkStatus = " + clsStatus.getStatusByStatusGroupNameAndStatusName("Orden de metalizado", "Cerrada").codsec.ToString() + ", ";
                queryString += "mto_modifiedDate = " + "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                queryString += "mto_modifiedBy = " + clsGlobal.LoggedUser.codsec.ToString() + " ";
                queryString += " WHERE mto_codsec = " + codsec.ToString() + ";";

                if (clsConnection.executeQuery(queryString))
                {
                    queryString = "";

                    queryString += "UPDATE bps_prod_metalizeddetail";
                    queryString += " SET ";
                    queryString += "mtod_endhour = " + "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "mtod_ejecuteby = " + clsGlobal.LoggedUser.codsec.ToString() + " ";
                    queryString += " WHERE mtod_fkOrder = " + codsec.ToString() + ";";
                    if (clsConnection.executeQuery(queryString))
                        return true;
                    else
                        return false;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsMetallizedOrder.save");
                return false;
            }
        }

        public static List<clsMetallizedOrder> getList()
        {
            DataSet DS = new DataSet();

            List<clsMetallizedOrder> lstMetallizedOrder = new List<clsMetallizedOrder>();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwmetallizedorder");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstMetallizedOrder.Add(new clsMetallizedOrder());

                lstMetallizedOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_codsec"]);
                lstMetallizedOrder[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_fkMachine"]);
                lstMetallizedOrder[i].MachineName = DS.Tables[0].Rows[i]["mto_MachineName"].ToString();
                lstMetallizedOrder[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_fkStatus"]);
                lstMetallizedOrder[i].StatusName = DS.Tables[0].Rows[i]["mto_StatusName"].ToString();
                lstMetallizedOrder[i].prodfkBoppFrom = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_prodfkBoppFrom"]);
                lstMetallizedOrder[i].prodfkBoppTo = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_prodfkBoppTo"]);
                lstMetallizedOrder[i].prodfkCastFrom = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_prodfkCastFrom"]);
                lstMetallizedOrder[i].prodfkCastTo = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_prodfkCastTo"]);
                lstMetallizedOrder[i].fkproductFrom = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_fkproductFrom"]);
                lstMetallizedOrder[i].productFromCode = DS.Tables[0].Rows[i]["mto_productFromCode"].ToString();
                lstMetallizedOrder[i].productFromName = DS.Tables[0].Rows[i]["mto_productFromName"].ToString();
                lstMetallizedOrder[i].fkproductTo = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_fkproductTo"]);
                lstMetallizedOrder[i].productToCode = DS.Tables[0].Rows[i]["mto_productToCode"].ToString();
                lstMetallizedOrder[i].productToName = DS.Tables[0].Rows[i]["mto_productToName"].ToString();
                lstMetallizedOrder[i].number = DS.Tables[0].Rows[i]["mto_number"].ToString();
                lstMetallizedOrder[i].opticDensity = Convert.ToDouble(DS.Tables[0].Rows[i]["mto_opticDensity"]);
                lstMetallizedOrder[i].quantityCoils = Convert.ToDouble(DS.Tables[0].Rows[i]["mto_quantityCoils"]);
                lstMetallizedOrder[i].notes = DS.Tables[0].Rows[i]["mto_notes"].ToString();
                lstMetallizedOrder[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mto_createdDate"]);
                lstMetallizedOrder[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mto_modifiedDate"]);
                lstMetallizedOrder[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_createdBy"]);
                lstMetallizedOrder[i].creatorUser = DS.Tables[0].Rows[i]["mto_creatorUser"].ToString();
                lstMetallizedOrder[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_modifiedBy"]);
                lstMetallizedOrder[i].modificatorUser = DS.Tables[0].Rows[i]["mto_modificatorUser"].ToString();
            }

            return lstMetallizedOrder;
        }

        public static List<clsMetallizedOrder> getActiveOrderList()
        {
            DataSet DS = new DataSet();

            List<clsMetallizedOrder> lstMetallizedOrder = new List<clsMetallizedOrder>();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwmetallizedorder WHERE mto_fkStatus = 46");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstMetallizedOrder.Add(new clsMetallizedOrder());

                lstMetallizedOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_codsec"]);
                lstMetallizedOrder[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_fkMachine"]);
                lstMetallizedOrder[i].MachineName = DS.Tables[0].Rows[i]["mto_MachineName"].ToString();
                lstMetallizedOrder[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_fkStatus"]);
                lstMetallizedOrder[i].StatusName = DS.Tables[0].Rows[i]["mto_StatusName"].ToString();
                lstMetallizedOrder[i].prodfkBoppFrom = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_prodfkBoppFrom"]);
                lstMetallizedOrder[i].prodfkBoppTo = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_prodfkBoppTo"]);
                lstMetallizedOrder[i].fkproductFrom = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_fkproductFrom"]);
                lstMetallizedOrder[i].productFromCode = DS.Tables[0].Rows[i]["mto_productFromCode"].ToString();
                lstMetallizedOrder[i].productFromName = DS.Tables[0].Rows[i]["mto_productFromName"].ToString();
                lstMetallizedOrder[i].fkproductTo = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_fkproductTo"]);
                lstMetallizedOrder[i].productToCode = DS.Tables[0].Rows[i]["mto_productToCode"].ToString();
                lstMetallizedOrder[i].productToName = DS.Tables[0].Rows[i]["mto_productToName"].ToString();
                lstMetallizedOrder[i].number = DS.Tables[0].Rows[i]["mto_number"].ToString();
                lstMetallizedOrder[i].opticDensity = Convert.ToDouble(DS.Tables[0].Rows[i]["mto_opticDensity"]);
                lstMetallizedOrder[i].quantityCoils = Convert.ToDouble(DS.Tables[0].Rows[i]["mto_quantityCoils"]);
                lstMetallizedOrder[i].notes = DS.Tables[0].Rows[i]["mto_notes"].ToString();
                lstMetallizedOrder[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mto_createdDate"]);
                lstMetallizedOrder[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mto_modifiedDate"]);
                lstMetallizedOrder[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_createdBy"]);
                lstMetallizedOrder[i].creatorUser = DS.Tables[0].Rows[i]["mto_creatorUser"].ToString();
                lstMetallizedOrder[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_modifiedBy"]);
                lstMetallizedOrder[i].modificatorUser = DS.Tables[0].Rows[i]["mto_modificatorUser"].ToString();
            }

            return lstMetallizedOrder;
        }

        public static int getLastSavedCodsec()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT mto_codsec FROM bps_prod_metalizedorder ORDER BY mto_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["mto_codsec"]);
        }

        public string getLastNumber()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT mto_number FROM bps_prod_metalizedOrder order by mto_number desc Limit 1");

            if (DS.Tables[0].Rows.Count == 0)
                return "";
            else
                return DS.Tables[0].Rows[0]["mto_number"].ToString();
        }

        public static List<clsMetallizedOrder> getActiveOrderListSummary()
        {
            DataSet DS = new DataSet();

            List<clsMetallizedOrder> lstMetallizedOrder = new List<clsMetallizedOrder>();

            DS = clsConnection.getDataSetResult("spMetalizeOrderList");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstMetallizedOrder.Add(new clsMetallizedOrder());
                lstMetallizedOrder[i].customerfrom = DS.Tables[0].Rows[i]["customerFrom"].ToString();
                lstMetallizedOrder[i].customerto = DS.Tables[0].Rows[i]["customerTo"].ToString();
                lstMetallizedOrder[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_fkStatus"]);
                lstMetallizedOrder[i].productFromName = DS.Tables[0].Rows[i]["mto_productFromName"].ToString();
                lstMetallizedOrder[i].productToName = DS.Tables[0].Rows[i]["mto_productToName"].ToString();
                lstMetallizedOrder[i].productTooName = DS.Tables[0].Rows[i]["mto_productTooName"].ToString();
                lstMetallizedOrder[i].quantityCoils = Convert.ToDouble(DS.Tables[0].Rows[i]["mto_quantityCoils"]);
                lstMetallizedOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_codsec"]);
                lstMetallizedOrder[i].lotnumber = DS.Tables[0].Rows[i]["mto_lotnumber"].ToString();
                lstMetallizedOrder[i].initDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mto_estimateinitdate"]);
                lstMetallizedOrder[i].widthFrom = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_ProductFromWidth"]);
                lstMetallizedOrder[i].widthTo = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_ProductToWidth"]);
                lstMetallizedOrder[i].widthToo = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_productTooWidth"]);
                lstMetallizedOrder[i].number = DS.Tables[0].Rows[i]["mto_number"].ToString();
                lstMetallizedOrder[i].notes = DS.Tables[0].Rows[i]["mto_notes"].ToString();
                lstMetallizedOrder[i].type = DS.Tables[0].Rows[i]["mto_type"].ToString();

                //lstMetallizedOrder[i].StatusName = DS.Tables[0].Rows[i]["mto_StatusName"].ToString();
                //lstMetallizedOrder[i].prodfkBoppFrom = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_prodfkBoppFrom"]);
                //lstMetallizedOrder[i].prodfkBoppTo = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_prodfkBoppTo"]);
                //lstMetallizedOrder[i].fkproductFrom = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_fkproductFrom"]);
                //lstMetallizedOrder[i].productFromCode = DS.Tables[0].Rows[i]["mto_productFromCode"].ToString();

                //lstMetallizedOrder[i].fkproductTo = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_fkproductTo"]);
                //lstMetallizedOrder[i].productToCode = DS.Tables[0].Rows[i]["mto_productToCode"].ToString();


                //lstMetallizedOrder[i].opticDensity = Convert.ToDouble(DS.Tables[0].Rows[i]["mto_opticDensity"]);

                //lstMetallizedOrder[i].notes = DS.Tables[0].Rows[i]["mto_notes"].ToString();

                //lstMetallizedOrder[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mto_modifiedDate"]);
                //lstMetallizedOrder[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_createdBy"]);
                //lstMetallizedOrder[i].creatorUser = DS.Tables[0].Rows[i]["mto_creatorUser"].ToString();
                //lstMetallizedOrder[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_modifiedBy"]);
                //lstMetallizedOrder[i].modificatorUser = DS.Tables[0].Rows[i]["mto_modificatorUser"].ToString();
            }

            return lstMetallizedOrder;
        }

        public static List<clsMetallizedOrder> getActiveOrderListByOrderDate(DateTime date)
        {
            DataSet DS = new DataSet();

            List<clsMetallizedOrder> lstMetallizedOrder = new List<clsMetallizedOrder>();

            DS = clsConnection.getDataSetResult("spMetalizeOrderByDate'" + date.ToString("dd/MM/yyyy HH:mm:ss") + "'");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstMetallizedOrder.Add(new clsMetallizedOrder());

                lstMetallizedOrder[i].ordenation = DS.Tables[0].Rows[i]["mto_ordenation"].ToString();
                lstMetallizedOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_codsec"]);
                lstMetallizedOrder[i].lotnumber = DS.Tables[0].Rows[i]["mto_lotnumber"].ToString();
                lstMetallizedOrder[i].productFromName = DS.Tables[0].Rows[i]["mto_productFromName"].ToString();
                lstMetallizedOrder[i].productToName = DS.Tables[0].Rows[i]["mto_productToName"].ToString();
                lstMetallizedOrder[i].widthFrom = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_ProductFromWidth"]);
                lstMetallizedOrder[i].widthTo = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_ProductToWidth"]);
                lstMetallizedOrder[i].totalweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mto_totalweigth"]);
                lstMetallizedOrder[i].kg = Convert.ToDouble(DS.Tables[0].Rows[i]["mto_kg"]);
                lstMetallizedOrder[i].initDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mto_estimateinitdate"]);
                lstMetallizedOrder[i].endDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mto_estimateenddate"]);
                lstMetallizedOrder[i].customerto = DS.Tables[0].Rows[i]["customerlistTo"].ToString();


                //lstMetallizedOrder[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_fkStatus"]);
                //lstMetallizedOrder[i].quantityCoils = Convert.ToDouble(DS.Tables[0].Rows[i]["mto_quantityCoils"]);




                //lstMetallizedOrder[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_fkMachine"]);
                //lstMetallizedOrder[i].MachineName = DS.Tables[0].Rows[i]["mto_MachineName"].ToString();

                //lstMetallizedOrder[i].productFromName = DS.Tables[0].Rows[i]["mto_BoppFrom"].ToString();
                //lstMetallizedOrder[i].productToName = DS.Tables[0].Rows[i]["mto_BoppTo"].ToString();
                //lstMetallizedOrder[i].prodfkBoppFrom = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_prodfkBoppFrom"]);
                //lstMetallizedOrder[i].prodfkBoppTo = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_prodfkBoppTo"]);
                //lstMetallizedOrder[i].fkproductFrom = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_fkproductFrom"]);
                //lstMetallizedOrder[i].productFromCode = DS.Tables[0].Rows[i]["mto_productFromCode"].ToString();

                //lstMetallizedOrder[i].fkproductTo = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_fkproductTo"]);
                //lstMetallizedOrder[i].productToCode = DS.Tables[0].Rows[i]["mto_productToCode"].ToString();


                //lstMetallizedOrder[i].opticDensity = Convert.ToDouble(DS.Tables[0].Rows[i]["mto_opticDensity"]);

                //lstMetallizedOrder[i].notes = DS.Tables[0].Rows[i]["mto_notes"].ToString();

                //lstMetallizedOrder[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mto_modifiedDate"]);
                //lstMetallizedOrder[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_createdBy"]);
                //lstMetallizedOrder[i].creatorUser = DS.Tables[0].Rows[i]["mto_creatorUser"].ToString();
                //lstMetallizedOrder[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_modifiedBy"]);
                //lstMetallizedOrder[i].modificatorUser = DS.Tables[0].Rows[i]["mto_modificatorUser"].ToString();
            }

            return lstMetallizedOrder;
        }

        public static List<clsMetallizedOrder> getOrderListByCodsec(int codsec)
        {
            DataSet DS = new DataSet();

            List<clsMetallizedOrder> lstMetallizedOrder = new List<clsMetallizedOrder>();

            DS = clsConnection.getDataSetResult("spMetalizeOrderListCodsec " + codsec.ToString());

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                lstMetallizedOrder.Add(new clsMetallizedOrder());
                lstMetallizedOrder[i].customerfrom = DS.Tables[0].Rows[i]["customerFrom"].ToString();
                lstMetallizedOrder[i].customerto = DS.Tables[0].Rows[i]["customerTo"].ToString();
                lstMetallizedOrder[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_fkStatus"]);
                lstMetallizedOrder[i].productFromName = DS.Tables[0].Rows[i]["mto_productFromName"].ToString();
                lstMetallizedOrder[i].productToName = DS.Tables[0].Rows[i]["mto_productToName"].ToString();
                lstMetallizedOrder[i].quantityCoils = Convert.ToDouble(DS.Tables[0].Rows[i]["mto_quantityCoils"]);
                lstMetallizedOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_codsec"]);
                lstMetallizedOrder[i].lotnumber = DS.Tables[0].Rows[i]["mto_lotnumber"].ToString();
                lstMetallizedOrder[i].initDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mto_estimateinitdate"]);
                lstMetallizedOrder[i].widthFrom = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_ProductFromWidth"]);
                lstMetallizedOrder[i].widthTo = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_ProductToWidth"]);
                lstMetallizedOrder[i].number = DS.Tables[0].Rows[i]["mto_number"].ToString();
                lstMetallizedOrder[i].notes = DS.Tables[0].Rows[i]["mto_notes"].ToString();

                //lstMetallizedOrder[i].StatusName = DS.Tables[0].Rows[i]["mto_StatusName"].ToString();
                //lstMetallizedOrder[i].prodfkBoppFrom = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_prodfkBoppFrom"]);
                //lstMetallizedOrder[i].prodfkBoppTo = Convert.ToInt32(DS.Tables[0].Rows[0]["mto_prodfkBoppTo"]);
                //lstMetallizedOrder[i].fkproductFrom = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_fkproductFrom"]);
                //lstMetallizedOrder[i].productFromCode = DS.Tables[0].Rows[i]["mto_productFromCode"].ToString();

                //lstMetallizedOrder[i].fkproductTo = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_fkproductTo"]);
                //lstMetallizedOrder[i].productToCode = DS.Tables[0].Rows[i]["mto_productToCode"].ToString();


                //lstMetallizedOrder[i].opticDensity = Convert.ToDouble(DS.Tables[0].Rows[i]["mto_opticDensity"]);

                //lstMetallizedOrder[i].notes = DS.Tables[0].Rows[i]["mto_notes"].ToString();

                //lstMetallizedOrder[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["mto_modifiedDate"]);
                //lstMetallizedOrder[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_createdBy"]);
                //lstMetallizedOrder[i].creatorUser = DS.Tables[0].Rows[i]["mto_creatorUser"].ToString();
                //lstMetallizedOrder[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["mto_modifiedBy"]);
                //lstMetallizedOrder[i].modificatorUser = DS.Tables[0].Rows[i]["mto_modificatorUser"].ToString();
            }

            return lstMetallizedOrder;
        }

        public static List<clsMetallizedOrder> getListSummary()
        {
            DataSet DS = new DataSet();
            List<clsMetallizedOrder> lstMetallizedOrder = new List<clsMetallizedOrder>();
            DS = clsConnection.getDataSetResult("spMetalizedPresionDeadTime 0,'SummaryMetalList'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    string prueba = DS.Tables[0].Rows[i]["met_filmproductionCodsec"].ToString();
                    lstMetallizedOrder.Add(new clsMetallizedOrder());
                    lstMetallizedOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["met_productionCodsec"]);
                    lstMetallizedOrder[i].fkFilmProduction = Convert.ToInt32(DS.Tables[0].Rows[i]["met_filmproductionCodsec"]);
                    lstMetallizedOrder[i].lotnumber = DS.Tables[0].Rows[i]["met_lotNumber"].ToString();
                    lstMetallizedOrder[i].productFromName = DS.Tables[0].Rows[i]["met_boppFrom"].ToString();
                    lstMetallizedOrder[i].productToName = DS.Tables[0].Rows[i]["met_boppTo"].ToString();
                    lstMetallizedOrder[i].ordenation = DS.Tables[0].Rows[i]["met_widthTo"].ToString();
                    lstMetallizedOrder[i].quantityCoils = Convert.ToDouble(DS.Tables[0].Rows[i]["met_coilNumber"]);
                    lstMetallizedOrder[i].totalweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pordm_quantity"]);
                    lstMetallizedOrder[i].StatusName = DS.Tables[0].Rows[i]["popp_StatusName"].ToString();
                }
            }

            return lstMetallizedOrder;
        }

        public static List<clsMetallizedOrder> getListSummaryByLote(string lotNumber)
        {
            DataSet DS = new DataSet();
            List<clsMetallizedOrder> lstMetallizedOrder = new List<clsMetallizedOrder>();
            DS = clsConnection.getDataSetResult("spMetalizeDetailMultiple '" + lotNumber + "','MetalizedLotSearch'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstMetallizedOrder.Add(new clsMetallizedOrder());
                    lstMetallizedOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["met_productionCodsec"]);
                    lstMetallizedOrder[i].fkFilmProduction = Convert.ToInt32(DS.Tables[0].Rows[i]["met_filmproductionCodsec"]);
                    lstMetallizedOrder[i].lotnumber = DS.Tables[0].Rows[i]["met_lotNumber"].ToString();
                    lstMetallizedOrder[i].productFromName = DS.Tables[0].Rows[i]["met_boppFrom"].ToString();
                    lstMetallizedOrder[i].productToName = DS.Tables[0].Rows[i]["met_boppTo"].ToString();
                    lstMetallizedOrder[i].ordenation = DS.Tables[0].Rows[i]["met_widthTo"].ToString();
                    lstMetallizedOrder[i].quantityCoils = Convert.ToDouble(DS.Tables[0].Rows[i]["met_coilNumber"]);
                    lstMetallizedOrder[i].totalweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["pordm_quantity"]);
                    lstMetallizedOrder[i].StatusName = DS.Tables[0].Rows[i]["popp_StatusName"].ToString();
                }
            }

            return lstMetallizedOrder;
        }

        //public static clsMetallizedOrder toLoad(int productionOrderCodsec)
        //{
        //    DataSet DS = new DataSet();
        //    DS = clsConnection.getDataSetResult("spMetalizeDetailMultiple '" + productionOrderCodsec.ToString() + "','MetalizedLotSearch'");
        //    clsProductionOrderMetal ob = new clsProductionOrderMetal(productionOrderCodsec);
        //}
    }
}
