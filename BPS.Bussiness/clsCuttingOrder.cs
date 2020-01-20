using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    /// <summary>
    /// Clase que administra las ordenes de corte (combinaciones)
    /// </summary>
    public class clsCuttingOrder
    {
        //Atributes

        private int cord_codsec;
        private int cord_fkMachine;
        private string cord_MachineName;
        private int cord_fkStatus;
        private string cord_StatusName;
        private int cord_fkBopp;
        private string cord_BoppName;
        private string cord_boppCode;
        private int cord_fkCast;
        private string cord_castName;
        private string cord_castCode;
        private int cord_fkCoating;
        private string cord_coatingName;
        private string cord_coatingCode;
        private int cord_fkProduct;
        private string cord_productName;
        private string cord_productCode;
        private string cord_number;
        private int cord_positions;
        private int cord_repetitions;
        private double cord_programmedWeight;
        private double cord_programmedLength;
        private int cord_position;
        private string cord_notes;
        private DateTime cord_createdDate;
        private DateTime cord_modifiedDate;
        private int cord_createdBy;
        private string cord_creatorUser;
        private int cord_modifiedBy;
        private string cord_modificatorUser;
        private List<clsCuttingOrderDetail> cord_lstCuttingOrderDetail;
        private List<clsCuttingStop> cord_lstCuttingStop;
        private bool cord_isSecundaryCut;
        private bool cord_allowEquivalentFilm;
        private int cord_priority;

        //Properties

        public int codsec { get { return cord_codsec; } set { cord_codsec = value; } }

        public int fkMachine { get { return cord_fkMachine; } set { cord_fkMachine = value; } }

        public string machineName { get { return cord_MachineName; } set { cord_MachineName = value; } }

        public int fkStatus { get { return cord_fkStatus; } set { cord_fkStatus = value; } }

        public int fkBopp { get { return cord_fkBopp; } set { cord_fkBopp = value; } }

        public string boppName { get { return cord_BoppName; } set { cord_BoppName = value; } }

        public string boppCode { get { return cord_boppCode; } set { cord_boppCode = value; } }

        public int fkCast { get { return cord_fkCast; } set { cord_fkCast = value; } }

        public string castName { get { return cord_castName; } set { cord_castName = value; } }

        public string castCode { get { return cord_castCode; } set { cord_castCode = value; } }

        public int fkCoating { get { return cord_fkCoating; } set { cord_fkCoating = value; } }

        public string coatingName { get { return cord_coatingName; } set { cord_coatingName = value; } }

        public string coatingCode { get { return cord_coatingCode; } set { cord_coatingCode = value; } }

        public int fkProduct { get { return cord_fkProduct; } set { cord_fkProduct = value; } }

        public string productName { get { return cord_productName; } set { cord_productName = value; } }

        public string productCode { get { return cord_productCode; } set { cord_productCode = value; } }

        public string statusName { get { return cord_StatusName; } set { cord_StatusName = value; } }

        public string number { get { return cord_number; } set { cord_number = value; } }

        public int positions { get { return cord_positions; } set { cord_positions = value; } }

        public int repetitions { get { return cord_repetitions; } set { cord_repetitions = value; } }

        public double programmedWeight { get { return cord_programmedWeight; } set { cord_programmedWeight = value; } }

        public double programmedLength { get { return cord_programmedLength; } set { cord_programmedLength = value; } }

        public int position { get { return cord_position; } set { cord_position = value; } }

        public string notes { get { return cord_notes; } set { cord_notes = value; } }

        public DateTime createdDate { get { return cord_createdDate; } set { cord_createdDate = value; } }

        public DateTime modifiedDate { get { return cord_modifiedDate; } set { cord_modifiedDate = value; } }

        public int createdBy { get { return cord_createdBy; } set { cord_createdBy = value; } }

        public string creatorUser { get { return cord_creatorUser; } set { cord_creatorUser = value; } }

        public int modifiedBy { get { return cord_modifiedBy; } set { cord_modifiedBy = value; } }

        public string modificatorUser { get { return cord_modificatorUser; } set { cord_modificatorUser = value; } }

        public List<clsCuttingOrderDetail> lstCuttingOrderDetail { get { return cord_lstCuttingOrderDetail; } set { cord_lstCuttingOrderDetail = value; } }

        public List<clsCuttingStop> lstCuttingStop { get { return cord_lstCuttingStop; } set { cord_lstCuttingStop = value; } }

        public bool isSecundaryCut { get { return cord_isSecundaryCut; } set { cord_isSecundaryCut = value; } }

        public bool allowEquivalentFilm { get { return cord_allowEquivalentFilm; } set { cord_allowEquivalentFilm = value; } }

        public int priority { get { return cord_priority; } set { cord_priority = value; } }

        //Constructor

        public clsCuttingOrder()
        {
            cord_codsec = 0;
            cord_fkMachine = 0;
            cord_MachineName = "";
            cord_fkStatus = 0;
            cord_fkBopp = 0;
            cord_BoppName = "";
            cord_boppCode = "";
            cord_fkCast = 0;
            cord_castName = "";
            cord_castCode = "";
            cord_fkCoating = 0;
            cord_coatingName = "";
            cord_coatingCode = "";
            cord_fkProduct = 0;
            cord_productName = "";
            cord_productCode = "";
            cord_StatusName = "";
            cord_number = "";
            cord_positions = 0;
            cord_repetitions = 0;
            cord_programmedWeight = 0;
            cord_programmedLength = 0;
            cord_position = 0;
            cord_notes = "";
            cord_createdDate = DateTime.Now;
            cord_modifiedDate = DateTime.Now;
            cord_createdBy = 0;
            cord_creatorUser = "";
            cord_modifiedBy = 0;
            cord_modificatorUser = "";
            cord_lstCuttingOrderDetail = new List<clsCuttingOrderDetail>();
            cord_lstCuttingStop = new List<clsCuttingStop>();
            cord_isSecundaryCut = false;
            cord_allowEquivalentFilm = false;
            cord_priority = 0;
        }
        //Methods
        public clsCuttingOrder(int codsec)
        {
            this.load(codsec);
        }
        public clsCuttingOrder(int codsec, bool isSimplified)
        {
            this.loadSimplified(codsec);
        }
        public void load(int cuttingOrderCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spCuttingOrderDetail(" + cuttingOrderCodsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_codsec"]);
                fkMachine = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_fkMachine"]);
                machineName = DS.Tables[0].Rows[0]["cord_machineName"].ToString();
                fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_fkStatus"]);
                statusName = DS.Tables[0].Rows[0]["cord_statusName"].ToString();
                fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_fkBopp"]);
                boppName = DS.Tables[0].Rows[0]["cord_boppName"].ToString();
                boppCode = DS.Tables[0].Rows[0]["cord_boppCode"].ToString();
                fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_fkCast"]);
                castName = DS.Tables[0].Rows[0]["cord_castName"].ToString();
                castCode = DS.Tables[0].Rows[0]["cord_castCode"].ToString();
                fkCoating = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_fkCoating"]);
                coatingName = DS.Tables[0].Rows[0]["cord_coatingName"].ToString();
                coatingCode = DS.Tables[0].Rows[0]["cord_coatingCode"].ToString();
                fkProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_fkProduct"]);
                productName = DS.Tables[0].Rows[0]["cord_productName"].ToString();
                productCode = DS.Tables[0].Rows[0]["cord_productCode"].ToString();
                isSecundaryCut = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cord_isSecundaryCut"], DS.Tables[0].Rows[0]["cord_isSecundaryCut"].GetType().FullName);
                number = DS.Tables[0].Rows[0]["cord_number"].ToString();
                positions = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_positions"]);
                repetitions = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_repetitions"]);
                programmedWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["cord_programmedWeight"]);
                programmedLength = Convert.ToDouble(DS.Tables[0].Rows[0]["cord_programmedLength"]);
                position = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_position"]);
                notes = DS.Tables[0].Rows[0]["cord_notes"].ToString();
                createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["cord_createdDate"]);
                modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["cord_modifiedDate"]);
                createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_createdBy"]);
                creatorUser = DS.Tables[0].Rows[0]["cord_creatorUser"].ToString();
                modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_modifiedBy"]);
                modificatorUser = DS.Tables[0].Rows[0]["cord_modificatorUser"].ToString();
                lstCuttingOrderDetail = clsCuttingOrderDetail.getListByCuttingOrder(codsec);
                lstCuttingStop = clsCuttingStop.getListByCuttingOrder(codsec);
                allowEquivalentFilm = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cord_allowEquivalentFilm"], DS.Tables[0].Rows[0]["cord_allowEquivalentFilm"].GetType().FullName);
                priority = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_Priority"]);

                if (lstCuttingStop.Count == 0)
                {
                    for (int i = 0; i < repetitions; i++)
                    {
                        clsCuttingStop objCuttingStop = new clsCuttingStop();

                        objCuttingStop.fkCuttingOrder = codsec;
                        objCuttingStop.position = i + 1;

                        objCuttingStop.save();
                        objCuttingStop.load(objCuttingStop.codsec);
                        lstCuttingStop.Add(objCuttingStop);
                    }
                }
            }
        }
        public void loadSimplified(int cuttingOrderCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spCuttingOrderDetail(" + cuttingOrderCodsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_codsec"]);
                fkMachine = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_fkMachine"]);
                machineName = DS.Tables[0].Rows[0]["cord_machineName"].ToString();
                fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_fkStatus"]);
                statusName = DS.Tables[0].Rows[0]["cord_statusName"].ToString();
                fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_fkBopp"]);
                boppName = DS.Tables[0].Rows[0]["cord_boppName"].ToString();
                boppCode = DS.Tables[0].Rows[0]["cord_boppCode"].ToString();
                fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_fkCast"]);
                castName = DS.Tables[0].Rows[0]["cord_castName"].ToString();
                castCode = DS.Tables[0].Rows[0]["cord_castCode"].ToString();
                fkCoating = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_fkCoating"]);
                coatingName = DS.Tables[0].Rows[0]["cord_coatingName"].ToString();
                coatingCode = DS.Tables[0].Rows[0]["cord_coatingCode"].ToString();
                fkProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_fkProduct"]);
                productName = DS.Tables[0].Rows[0]["cord_productName"].ToString();
                productCode = DS.Tables[0].Rows[0]["cord_productCode"].ToString();
                isSecundaryCut = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cord_isSecundaryCut"], DS.Tables[0].Rows[0]["cord_isSecundaryCut"].GetType().FullName);
                number = DS.Tables[0].Rows[0]["cord_number"].ToString();
                positions = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_positions"]);
                repetitions = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_repetitions"]);
                programmedWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["cord_programmedWeight"]);
                programmedLength = Convert.ToDouble(DS.Tables[0].Rows[0]["cord_programmedLength"]);
                position = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_position"]);
                notes = DS.Tables[0].Rows[0]["cord_notes"].ToString();
                createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["cord_createdDate"]);
                modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["cord_modifiedDate"]);
                createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_createdBy"]);
                creatorUser = DS.Tables[0].Rows[0]["cord_creatorUser"].ToString();
                modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_modifiedBy"]);
                modificatorUser = DS.Tables[0].Rows[0]["cord_modificatorUser"].ToString();
                lstCuttingOrderDetail = clsCuttingOrderDetail.getListByCuttingOrder(codsec);
                lstCuttingStop = clsCuttingStop.getSimplidiedListByCuttingOrder(codsec);
                allowEquivalentFilm = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cord_allowEquivalentFilm"], DS.Tables[0].Rows[0]["cord_allowEquivalentFilm"].GetType().FullName);
                priority = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_Priority"]);

                if (lstCuttingStop.Count == 0)
                {
                    for (int i = 0; i < repetitions; i++)
                    {
                        clsCuttingStop objCuttingStop = new clsCuttingStop();

                        objCuttingStop.fkCuttingOrder = codsec;
                        objCuttingStop.position = i + 1;

                        objCuttingStop.save();
                        objCuttingStop.load(objCuttingStop.codsec);
                        lstCuttingStop.Add(objCuttingStop);
                    }
                }
            }
        }
        public bool save()
        {
            bool isNewCuttingOreder = true;
            //try
            //{
                string queryString = "";
                int originalRepetitions = 0;

                if (this.codsec == 0)
                {
                    if (this.fkBopp > 0)
                    {
                        this.position = clsCuttingOrder.getNextPosition();

                        queryString += "INSERT INTO bps_prod_cuttingorder (cord_fkMachine, cord_fkStatus, cord_fkBopp, cord_number, cord_positions, cord_repetitions, cord_programmedWeight, cord_programmedLength, cord_position, cord_notes, cord_createdDate, cord_modifiedDate, cord_createdBy, cord_modifiedBy, cord_allowEquivalentFilm, cord_isSecundaryCut, cord_Priority)";
                        queryString += " VALUES (";
                        queryString += "" + this.fkMachine.ToString() + ", ";
                        queryString += "" + this.fkStatus.ToString() + ", ";
                        queryString += "" + this.fkBopp.ToString() + ", ";
                        queryString += "'--', ";
                        queryString += "" + this.positions.ToString() + ", ";
                        queryString += "" + this.repetitions.ToString() + ", ";
                        queryString += "" + this.programmedWeight.ToString() + ", ";
                        queryString += "" + this.programmedLength.ToString() + ", ";
                        queryString += "" + this.position.ToString() + ", ";
                        queryString += "'" + this.notes.ToString() + "', ";
                        queryString += "'" + this.createdDate.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                        queryString += "'" + this.modifiedDate.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                        queryString += "" + this.createdBy.ToString() + ", ";
                        queryString += "" + this.modifiedBy.ToString() + ", ";
                        queryString += "" + this.allowEquivalentFilm.ToString() + ",";
                        queryString += "" + this.isSecundaryCut.ToString() + ",";
                        queryString += "" + this.priority.ToString() + "";
                        queryString += ");";
                    }
                    if (this.fkCast > 0)
                    {
                        this.position = clsCuttingOrder.getNextPosition();

                        queryString += "INSERT INTO bps_prod_cuttingorder (cord_fkMachine, cord_fkStatus, cord_fkCast, cord_number, cord_positions, cord_repetitions, cord_programmedWeight, cord_programmedLength, cord_position, cord_notes, cord_createdDate, cord_modifiedDate, cord_createdBy, cord_modifiedBy, cord_allowEquivalentFilm, cord_isSecundaryCut, cord_Priority)";
                        queryString += " VALUES (";
                        queryString += "" + this.fkMachine.ToString() + ", ";
                        queryString += "" + this.fkStatus.ToString() + ", ";
                        queryString += "" + this.fkCast.ToString() + ", ";
                        queryString += "'--', ";
                        queryString += "" + this.positions.ToString() + ", ";
                        queryString += "" + this.repetitions.ToString() + ", ";
                        queryString += "" + this.programmedWeight.ToString() + ", ";
                        queryString += "" + this.programmedLength.ToString() + ", ";
                        queryString += "" + this.position.ToString() + ", ";
                        queryString += "'" + this.notes.ToString() + "', ";
                        queryString += "'" + this.createdDate.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                        queryString += "'" + this.modifiedDate.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                        queryString += "" + this.createdBy.ToString() + ", ";
                        queryString += "" + this.modifiedBy.ToString() + ", ";
                        queryString += "" + this.allowEquivalentFilm.ToString() + ",";
                        queryString += "" + this.isSecundaryCut.ToString() + ",";
                        queryString += "" + this.priority.ToString() + "";
                        queryString += ");";
                    }
                    else if (this.fkProduct > 0)
                    {
                        this.position = clsCuttingOrder.getNextPosition();

                        queryString += "INSERT INTO bps_prod_cuttingorder (cord_fkMachine, cord_fkStatus, cord_fkProduct, cord_number, cord_positions, cord_repetitions, cord_programmedWeight, cord_programmedLength, cord_position, cord_notes, cord_createdDate, cord_modifiedDate, cord_createdBy, cord_modifiedBy, cord_allowEquivalentFilm, cord_isSecundaryCut, cord_Priority)";
                        queryString += " VALUES (";
                        queryString += "" + this.fkMachine.ToString() + ", ";
                        queryString += "" + this.fkStatus.ToString() + ", ";
                        queryString += "" + this.fkProduct.ToString() + ", ";
                        queryString += "'--', ";
                        queryString += "" + this.positions.ToString() + ", ";
                        queryString += "" + this.repetitions.ToString() + ", ";
                        queryString += "" + this.programmedWeight.ToString() + ", ";
                        queryString += "" + this.programmedLength.ToString() + ", ";
                        queryString += "" + this.position.ToString() + ", ";
                        queryString += "'" + this.notes.ToString() + "', ";
                        queryString += "'" + this.createdDate.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                        queryString += "'" + this.modifiedDate.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                        queryString += "" + this.createdBy.ToString() + ", ";
                        queryString += "" + this.modifiedBy.ToString() + ", ";
                        queryString += "" + this.allowEquivalentFilm.ToString() + ",";
                        queryString += "" + this.isSecundaryCut.ToString() + ",";
                        queryString += "" + this.priority.ToString() + "";
                        queryString += ");";
                    }
                }
                else
                {                    
                    originalRepetitions = (new clsCuttingOrder(this.codsec)).repetitions;
                    isNewCuttingOreder = false;
                    queryString += "UPDATE bps_prod_cuttingorder";
                    queryString += " SET ";
                    queryString += "cord_fkMachine = " + this.fkMachine.ToString() + ", ";
                    queryString += "cord_fkStatus = " + this.fkStatus.ToString() + ", ";
                    queryString += "cord_number = '" + this.number + "', ";
                    queryString += "cord_positions = " + this.positions.ToString() + ", ";
                    queryString += "cord_repetitions = " + this.repetitions.ToString() + ", ";
                    queryString += "cord_programmedWeight = " + this.programmedWeight.ToString() + ", ";
                    queryString += "cord_programmedLength = " + this.programmedLength.ToString() + ", ";
                    queryString += "cord_notes = '" + this.notes.ToString() + "', ";
                    queryString += "cord_modifiedDate = '" + this.modifiedDate.ToString("dd/MM/yyyy HH:mm:ss") + "', ";
                    queryString += "cord_modifiedBy = " + this.modifiedBy.ToString() + ",";
                    queryString += "cord_Priority = " + this.priority.ToString() + "";
                    queryString += " WHERE cord_codsec = " + this.codsec.ToString() + ";";
                }

                clsConnection.executeQuery(queryString);

                if (this.codsec == 0)
                    this.codsec = clsCuttingOrder.getLastSavedSalesOrderCodsec();

                if (isNewCuttingOreder == false)
                {
                    clsCuttingOrderDetail.checkDeletedCuttingOrderDetails(lstCuttingOrderDetail, codsec);

                    if (this.statusName == "Programada")
                    {
                        clsConnection.executeQuery("DELETE FROM bps_prod_cuttingstops WHERE cstp_fkCuttingOrder = " + this.codsec.ToString());

                        for (int i = 0; i < this.repetitions; i++)
                        {
                            clsCuttingStop objCuttingStop = new clsCuttingStop();

                            objCuttingStop.fkCuttingOrder = this.codsec;
                            objCuttingStop.position = i + 1;

                            objCuttingStop.save();
                        }
                    }
                    else
                    {
                        if (originalRepetitions < this.repetitions)
                        {
                            int nextPosition = originalRepetitions + 1;

                            for (int i = 0; i < this.repetitions - originalRepetitions; i++)
                            {
                                clsCuttingStop objCuttingStop = new clsCuttingStop();

                                objCuttingStop.fkCuttingOrder = this.codsec;
                                objCuttingStop.position = nextPosition;

                                nextPosition++;

                                objCuttingStop.save();
                            }
                        }
                    }
                    
                }
                else
                {

                    for (int i = 0; i < this.repetitions; i++)
                    {
                        clsCuttingStop objCuttingStop = new clsCuttingStop();

                        objCuttingStop.fkCuttingOrder = this.codsec;
                        objCuttingStop.position = i + 1;

                        objCuttingStop.save();
                    }
                }
                for (int i = 0; i < lstCuttingOrderDetail.Count; i++)
                {
                    lstCuttingOrderDetail[i].fkCuttingOrder = this.codsec;
                    lstCuttingOrderDetail[i].save();
                }

                return true;
            //}


            //catch (Exception ex)
            //{
               // clsLog.addLog(ex, 3, "clsCuttingOrder.save");
              //  return false;
            //}
        }
        private static int getLastSavedSalesOrderCodsec()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT cord_codsec FROM vwcuttingorder Order By cord_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["cord_codsec"]);
        }
        private static int getNextPosition()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT (cord_position + 1) as nextPosition FROM vwcuttingorder Order By cord_codsec DESC LIMIT 1");
            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(DS.Tables[0].Rows[0]["nextPosition"]);
            else
                return 1;
        }
        public static List<clsCuttingOrder> getListByBoppCodsec(int boppCodsec)
        {
            List<clsCuttingOrder> lstCuttingOrder = new List<clsCuttingOrder>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spCuttingOrderByBopp(" + boppCodsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCuttingOrder.Add(new clsCuttingOrder());

                    lstCuttingOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_codsec"]);
                    lstCuttingOrder[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkMachine"]);
                    lstCuttingOrder[i].machineName = DS.Tables[0].Rows[i]["cord_machineName"].ToString();
                    lstCuttingOrder[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkStatus"]);
                    lstCuttingOrder[i].statusName = DS.Tables[0].Rows[i]["cord_statusName"].ToString();
                    lstCuttingOrder[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkBopp"]);
                    lstCuttingOrder[i].boppName = DS.Tables[0].Rows[i]["cord_boppName"].ToString();
                    lstCuttingOrder[i].boppCode = DS.Tables[0].Rows[i]["cord_boppCode"].ToString();
                    lstCuttingOrder[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkCast"]);
                    lstCuttingOrder[i].castName = DS.Tables[0].Rows[i]["cord_castName"].ToString();
                    lstCuttingOrder[i].castCode = DS.Tables[0].Rows[i]["cord_castCode"].ToString();
                    lstCuttingOrder[i].fkCoating = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkCoating"]);
                    lstCuttingOrder[i].coatingName = DS.Tables[0].Rows[i]["cord_coatingName"].ToString();
                    lstCuttingOrder[i].coatingCode = DS.Tables[0].Rows[i]["cord_coatingCode"].ToString();
                    lstCuttingOrder[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkProduct"]);
                    lstCuttingOrder[i].productName = DS.Tables[0].Rows[i]["cord_productName"].ToString();
                    lstCuttingOrder[i].productCode = DS.Tables[0].Rows[i]["cord_productCode"].ToString();
                    lstCuttingOrder[i].isSecundaryCut = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cord_isSecundaryCut"], DS.Tables[0].Rows[i]["cord_isSecundaryCut"].GetType().FullName);
                    lstCuttingOrder[i].number = DS.Tables[0].Rows[i]["cord_number"].ToString();
                    lstCuttingOrder[i].positions = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_positions"]);
                    lstCuttingOrder[i].repetitions = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_repetitions"]);
                    lstCuttingOrder[i].programmedWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["cord_programmedWeight"]);
                    lstCuttingOrder[i].programmedLength = Convert.ToDouble(DS.Tables[0].Rows[i]["cord_programmedLength"]);
                    lstCuttingOrder[i].position = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_position"]);
                    lstCuttingOrder[i].notes = DS.Tables[0].Rows[i]["cord_notes"].ToString();
                    lstCuttingOrder[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["cord_createdDate"]);
                    lstCuttingOrder[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["cord_modifiedDate"]);
                    lstCuttingOrder[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_createdBy"]);
                    lstCuttingOrder[i].creatorUser = DS.Tables[0].Rows[i]["cord_creatorUser"].ToString();
                    lstCuttingOrder[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_modifiedBy"]);
                    lstCuttingOrder[i].modificatorUser = DS.Tables[0].Rows[i]["cord_modificatorUser"].ToString();
                    lstCuttingOrder[i].lstCuttingOrderDetail = clsCuttingOrderDetail.getListByCuttingOrder(lstCuttingOrder[i].codsec);
                    //lstCuttingOrder[i].lstCuttingStop = clsCuttingStop.getListByCuttingOrder(lstCuttingOrder[i].codsec);
                    lstCuttingOrder[i].allowEquivalentFilm = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cord_allowEquivalentFilm"], DS.Tables[0].Rows[i]["cord_allowEquivalentFilm"].GetType().FullName);
                    lstCuttingOrder[i].priority = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_Priority"]);
                }
            }
            return lstCuttingOrder;
        }
        public static List<clsCuttingOrder> getActiveListByBoppCodsec(int boppCodsec)
        {
            List<clsCuttingOrder> lstCuttingOrder = new List<clsCuttingOrder>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spActiveCuttingOrderByBopp(" + boppCodsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCuttingOrder.Add(new clsCuttingOrder());

                    lstCuttingOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_codsec"]);
                    lstCuttingOrder[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkMachine"]);
                    lstCuttingOrder[i].machineName = DS.Tables[0].Rows[i]["cord_machineName"].ToString();
                    lstCuttingOrder[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkStatus"]);
                    lstCuttingOrder[i].statusName = DS.Tables[0].Rows[i]["cord_statusName"].ToString();
                    lstCuttingOrder[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkBopp"]);
                    lstCuttingOrder[i].boppName = DS.Tables[0].Rows[i]["cord_boppName"].ToString();
                    lstCuttingOrder[i].boppCode = DS.Tables[0].Rows[i]["cord_boppCode"].ToString();
                    lstCuttingOrder[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkCast"]);
                    lstCuttingOrder[i].castName = DS.Tables[0].Rows[i]["cord_castName"].ToString();
                    lstCuttingOrder[i].castCode = DS.Tables[0].Rows[i]["cord_castCode"].ToString();
                    lstCuttingOrder[i].fkCoating = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkCoating"]);
                    lstCuttingOrder[i].coatingName = DS.Tables[0].Rows[i]["cord_coatingName"].ToString();
                    lstCuttingOrder[i].coatingCode = DS.Tables[0].Rows[i]["cord_coatingCode"].ToString();
                    lstCuttingOrder[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkProduct"]);
                    lstCuttingOrder[i].productName = DS.Tables[0].Rows[i]["cord_productName"].ToString();
                    lstCuttingOrder[i].productCode = DS.Tables[0].Rows[i]["cord_productCode"].ToString();
                    lstCuttingOrder[i].isSecundaryCut = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cord_isSecundaryCut"], DS.Tables[0].Rows[i]["cord_isSecundaryCut"].GetType().FullName);
                    lstCuttingOrder[i].number = DS.Tables[0].Rows[i]["cord_number"].ToString();
                    lstCuttingOrder[i].positions = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_positions"]);
                    lstCuttingOrder[i].repetitions = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_repetitions"]);
                    lstCuttingOrder[i].programmedWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["cord_programmedWeight"]);
                    lstCuttingOrder[i].programmedLength = Convert.ToDouble(DS.Tables[0].Rows[i]["cord_programmedLength"]);
                    lstCuttingOrder[i].position = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_position"]);
                    lstCuttingOrder[i].notes = DS.Tables[0].Rows[i]["cord_notes"].ToString();
                    lstCuttingOrder[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["cord_createdDate"]);
                    lstCuttingOrder[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["cord_modifiedDate"]);
                    lstCuttingOrder[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_createdBy"]);
                    lstCuttingOrder[i].creatorUser = DS.Tables[0].Rows[i]["cord_creatorUser"].ToString();
                    lstCuttingOrder[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_modifiedBy"]);
                    lstCuttingOrder[i].modificatorUser = DS.Tables[0].Rows[i]["cord_modificatorUser"].ToString();
                    lstCuttingOrder[i].lstCuttingOrderDetail = clsCuttingOrderDetail.getListByCuttingOrder(lstCuttingOrder[i].codsec);
                    //lstCuttingOrder[i].lstCuttingStop = clsCuttingStop.getListByCuttingOrder(lstCuttingOrder[i].codsec);
                    lstCuttingOrder[i].allowEquivalentFilm = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cord_allowEquivalentFilm"], DS.Tables[0].Rows[i]["cord_allowEquivalentFilm"].GetType().FullName);
                    lstCuttingOrder[i].priority = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_Priority"]);
                }
            }
            return lstCuttingOrder;
        }
        public static List<clsCuttingOrder> getActiveListByCastCodsec(int castCodsec)
        {
            List<clsCuttingOrder> lstCuttingOrder = new List<clsCuttingOrder>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spActiveCuttingOrderByCast(" + castCodsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCuttingOrder.Add(new clsCuttingOrder());

                    lstCuttingOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_codsec"]);
                    lstCuttingOrder[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkMachine"]);
                    lstCuttingOrder[i].machineName = DS.Tables[0].Rows[i]["cord_machineName"].ToString();
                    lstCuttingOrder[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkStatus"]);
                    lstCuttingOrder[i].statusName = DS.Tables[0].Rows[i]["cord_statusName"].ToString();
                    lstCuttingOrder[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkBopp"]);
                    lstCuttingOrder[i].boppName = DS.Tables[0].Rows[i]["cord_boppName"].ToString();
                    lstCuttingOrder[i].boppCode = DS.Tables[0].Rows[i]["cord_boppCode"].ToString();
                    lstCuttingOrder[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkCast"]);
                    lstCuttingOrder[i].castName = DS.Tables[0].Rows[i]["cord_castName"].ToString();
                    lstCuttingOrder[i].castCode = DS.Tables[0].Rows[i]["cord_castCode"].ToString();
                    lstCuttingOrder[i].fkCoating = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkCoating"]);
                    lstCuttingOrder[i].coatingName = DS.Tables[0].Rows[i]["cord_coatingName"].ToString();
                    lstCuttingOrder[i].coatingCode = DS.Tables[0].Rows[i]["cord_coatingCode"].ToString();
                    lstCuttingOrder[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkProduct"]);
                    lstCuttingOrder[i].productName = DS.Tables[0].Rows[i]["cord_productName"].ToString();
                    lstCuttingOrder[i].productCode = DS.Tables[0].Rows[i]["cord_productCode"].ToString();
                    lstCuttingOrder[i].isSecundaryCut = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cord_isSecundaryCut"], DS.Tables[0].Rows[i]["cord_isSecundaryCut"].GetType().FullName);
                    lstCuttingOrder[i].number = DS.Tables[0].Rows[i]["cord_number"].ToString();
                    lstCuttingOrder[i].positions = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_positions"]);
                    lstCuttingOrder[i].repetitions = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_repetitions"]);
                    lstCuttingOrder[i].programmedWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["cord_programmedWeight"]);
                    lstCuttingOrder[i].programmedLength = Convert.ToDouble(DS.Tables[0].Rows[i]["cord_programmedLength"]);
                    lstCuttingOrder[i].position = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_position"]);
                    lstCuttingOrder[i].notes = DS.Tables[0].Rows[i]["cord_notes"].ToString();
                    lstCuttingOrder[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["cord_createdDate"]);
                    lstCuttingOrder[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["cord_modifiedDate"]);
                    lstCuttingOrder[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_createdBy"]);
                    lstCuttingOrder[i].creatorUser = DS.Tables[0].Rows[i]["cord_creatorUser"].ToString();
                    lstCuttingOrder[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_modifiedBy"]);
                    lstCuttingOrder[i].modificatorUser = DS.Tables[0].Rows[i]["cord_modificatorUser"].ToString();
                    lstCuttingOrder[i].lstCuttingOrderDetail = clsCuttingOrderDetail.getListByCuttingOrder(lstCuttingOrder[i].codsec);
                    //lstCuttingOrder[i].lstCuttingStop = clsCuttingStop.getListByCuttingOrder(lstCuttingOrder[i].codsec);
                    lstCuttingOrder[i].allowEquivalentFilm = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cord_allowEquivalentFilm"], DS.Tables[0].Rows[i]["cord_allowEquivalentFilm"].GetType().FullName);
                    lstCuttingOrder[i].priority = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_Priority"]);
                }
            }
            return lstCuttingOrder;
        }
        public static List<clsCuttingOrder> getActiveSecundaryCuttingList()
        {
            List<clsCuttingOrder> lstCuttingOrder = new List<clsCuttingOrder>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spActiveSecundaryCuttingOrderList()");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCuttingOrder.Add(new clsCuttingOrder());

                    lstCuttingOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_codsec"]);
                    lstCuttingOrder[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkMachine"]);
                    lstCuttingOrder[i].machineName = DS.Tables[0].Rows[i]["cord_machineName"].ToString();
                    lstCuttingOrder[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkStatus"]);
                    lstCuttingOrder[i].statusName = DS.Tables[0].Rows[i]["cord_statusName"].ToString();
                    lstCuttingOrder[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkBopp"]);
                    lstCuttingOrder[i].boppName = DS.Tables[0].Rows[i]["cord_boppName"].ToString();
                    lstCuttingOrder[i].boppCode = DS.Tables[0].Rows[i]["cord_boppCode"].ToString();
                    lstCuttingOrder[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkCast"]);
                    lstCuttingOrder[i].castName = DS.Tables[0].Rows[i]["cord_castName"].ToString();
                    lstCuttingOrder[i].castCode = DS.Tables[0].Rows[i]["cord_castCode"].ToString();
                    lstCuttingOrder[i].fkCoating = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkCoating"]);
                    lstCuttingOrder[i].coatingName = DS.Tables[0].Rows[i]["cord_coatingName"].ToString();
                    lstCuttingOrder[i].coatingCode = DS.Tables[0].Rows[i]["cord_coatingCode"].ToString();
                    lstCuttingOrder[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkProduct"]);
                    lstCuttingOrder[i].productName = DS.Tables[0].Rows[i]["cord_productName"].ToString();
                    lstCuttingOrder[i].productCode = DS.Tables[0].Rows[i]["cord_productCode"].ToString();
                    lstCuttingOrder[i].isSecundaryCut = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cord_isSecundaryCut"], DS.Tables[0].Rows[i]["cord_isSecundaryCut"].GetType().FullName);
                    lstCuttingOrder[i].number = DS.Tables[0].Rows[i]["cord_number"].ToString();
                    lstCuttingOrder[i].positions = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_positions"]);
                    lstCuttingOrder[i].repetitions = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_repetitions"]);
                    lstCuttingOrder[i].programmedWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["cord_programmedWeight"]);
                    lstCuttingOrder[i].programmedLength = Convert.ToDouble(DS.Tables[0].Rows[i]["cord_programmedLength"]);
                    lstCuttingOrder[i].position = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_position"]);
                    lstCuttingOrder[i].notes = DS.Tables[0].Rows[i]["cord_notes"].ToString();
                    lstCuttingOrder[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["cord_createdDate"]);
                    lstCuttingOrder[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["cord_modifiedDate"]);
                    lstCuttingOrder[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_createdBy"]);
                    lstCuttingOrder[i].creatorUser = DS.Tables[0].Rows[i]["cord_creatorUser"].ToString();
                    lstCuttingOrder[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_modifiedBy"]);
                    lstCuttingOrder[i].modificatorUser = DS.Tables[0].Rows[i]["cord_modificatorUser"].ToString();
                    lstCuttingOrder[i].lstCuttingOrderDetail = clsCuttingOrderDetail.getListByCuttingOrder(lstCuttingOrder[i].codsec);
                    //lstCuttingOrder[i].lstCuttingStop = clsCuttingStop.getListByCuttingOrder(lstCuttingOrder[i].codsec);
                    lstCuttingOrder[i].allowEquivalentFilm = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cord_allowEquivalentFilm"], DS.Tables[0].Rows[i]["cord_allowEquivalentFilm"].GetType().FullName);
                    lstCuttingOrder[i].priority = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_Priority"]);
                }
            }
            return lstCuttingOrder;
        }
        public static List<clsCuttingOrder> getProgramedList()
        {
            List<clsCuttingOrder> lstCuttingOrder = new List<clsCuttingOrder>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spProgrammedCuttingOrder()");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCuttingOrder.Add(new clsCuttingOrder());

                    lstCuttingOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_codsec"]);
                    lstCuttingOrder[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkMachine"]);
                    lstCuttingOrder[i].machineName = DS.Tables[0].Rows[i]["cord_machineName"].ToString();
                    lstCuttingOrder[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkStatus"]);
                    lstCuttingOrder[i].statusName = DS.Tables[0].Rows[i]["cord_statusName"].ToString();
                    lstCuttingOrder[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkBopp"]);
                    lstCuttingOrder[i].boppName = DS.Tables[0].Rows[i]["cord_boppName"].ToString();
                    lstCuttingOrder[i].boppCode = DS.Tables[0].Rows[i]["cord_boppCode"].ToString();
                    lstCuttingOrder[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkCast"]);
                    lstCuttingOrder[i].castName = DS.Tables[0].Rows[i]["cord_castName"].ToString();
                    lstCuttingOrder[i].castCode = DS.Tables[0].Rows[i]["cord_castCode"].ToString();
                    lstCuttingOrder[i].fkCoating = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkCoating"]);
                    lstCuttingOrder[i].coatingName = DS.Tables[0].Rows[i]["cord_coatingName"].ToString();
                    lstCuttingOrder[i].coatingCode = DS.Tables[0].Rows[i]["cord_coatingCode"].ToString();
                    lstCuttingOrder[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkProduct"]);
                    lstCuttingOrder[i].productName = DS.Tables[0].Rows[i]["cord_productName"].ToString();
                    lstCuttingOrder[i].productCode = DS.Tables[0].Rows[i]["cord_productCode"].ToString();
                    lstCuttingOrder[i].isSecundaryCut = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cord_isSecundaryCut"], DS.Tables[0].Rows[i]["cord_isSecundaryCut"].GetType().FullName);
                    lstCuttingOrder[i].number = DS.Tables[0].Rows[i]["cord_number"].ToString();
                    lstCuttingOrder[i].positions = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_positions"]);
                    lstCuttingOrder[i].repetitions = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_repetitions"]);
                    lstCuttingOrder[i].programmedWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["cord_programmedWeight"]);
                    lstCuttingOrder[i].programmedLength = Convert.ToDouble(DS.Tables[0].Rows[i]["cord_programmedLength"]);
                    lstCuttingOrder[i].position = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_position"]);
                    lstCuttingOrder[i].notes = DS.Tables[0].Rows[i]["cord_notes"].ToString();
                    lstCuttingOrder[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["cord_createdDate"]);
                    lstCuttingOrder[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["cord_modifiedDate"]);
                    lstCuttingOrder[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_createdBy"]);
                    lstCuttingOrder[i].creatorUser = DS.Tables[0].Rows[i]["cord_creatorUser"].ToString();
                    lstCuttingOrder[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_modifiedBy"]);
                    lstCuttingOrder[i].modificatorUser = DS.Tables[0].Rows[i]["cord_modificatorUser"].ToString();
                    lstCuttingOrder[i].lstCuttingOrderDetail = clsCuttingOrderDetail.getListByCuttingOrder(lstCuttingOrder[i].codsec);
                    //lstCuttingOrder[i].lstCuttingStop = clsCuttingStop.getListByCuttingOrder(lstCuttingOrder[i].codsec);
                    lstCuttingOrder[i].allowEquivalentFilm = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cord_allowEquivalentFilm"], DS.Tables[0].Rows[i]["cord_allowEquivalentFilm"].GetType().FullName);
                    lstCuttingOrder[i].priority = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_Priority"]);
                }
            }
            return lstCuttingOrder;
        }
        public static List<clsCuttingOrder> getProgramedListByMachine(int machineCodsec)
        {
            List<clsCuttingOrder> lstCuttingOrder = new List<clsCuttingOrder>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spProgrammedCuttingOrderByMachine(" + machineCodsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCuttingOrder.Add(new clsCuttingOrder());

                    lstCuttingOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_codsec"]);
                    lstCuttingOrder[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkMachine"]);
                    lstCuttingOrder[i].machineName = DS.Tables[0].Rows[i]["cord_machineName"].ToString();
                    lstCuttingOrder[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkStatus"]);
                    lstCuttingOrder[i].statusName = DS.Tables[0].Rows[i]["cord_statusName"].ToString();
                    lstCuttingOrder[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkBopp"]);
                    lstCuttingOrder[i].boppName = DS.Tables[0].Rows[i]["cord_boppName"].ToString();
                    lstCuttingOrder[i].boppCode = DS.Tables[0].Rows[i]["cord_boppCode"].ToString();
                    lstCuttingOrder[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkCast"]);
                    lstCuttingOrder[i].castName = DS.Tables[0].Rows[i]["cord_castName"].ToString();
                    lstCuttingOrder[i].castCode = DS.Tables[0].Rows[i]["cord_castCode"].ToString();
                    lstCuttingOrder[i].fkCoating = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkCoating"]);
                    lstCuttingOrder[i].coatingName = DS.Tables[0].Rows[i]["cord_coatingName"].ToString();
                    lstCuttingOrder[i].coatingCode = DS.Tables[0].Rows[i]["cord_coatingCode"].ToString();
                    lstCuttingOrder[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkProduct"]);
                    lstCuttingOrder[i].productName = DS.Tables[0].Rows[i]["cord_productName"].ToString();
                    lstCuttingOrder[i].productCode = DS.Tables[0].Rows[i]["cord_productCode"].ToString();
                    lstCuttingOrder[i].isSecundaryCut = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cord_isSecundaryCut"], DS.Tables[0].Rows[i]["cord_isSecundaryCut"].GetType().FullName);
                    lstCuttingOrder[i].number = DS.Tables[0].Rows[i]["cord_number"].ToString();
                    lstCuttingOrder[i].positions = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_positions"]);
                    lstCuttingOrder[i].repetitions = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_repetitions"]);
                    lstCuttingOrder[i].programmedWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["cord_programmedWeight"]);
                    lstCuttingOrder[i].programmedLength = Convert.ToDouble(DS.Tables[0].Rows[i]["cord_programmedLength"]);
                    lstCuttingOrder[i].position = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_position"]);
                    lstCuttingOrder[i].notes = DS.Tables[0].Rows[i]["cord_notes"].ToString();
                    lstCuttingOrder[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["cord_createdDate"]);
                    lstCuttingOrder[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["cord_modifiedDate"]);
                    lstCuttingOrder[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_createdBy"]);
                    lstCuttingOrder[i].creatorUser = DS.Tables[0].Rows[i]["cord_creatorUser"].ToString();
                    lstCuttingOrder[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_modifiedBy"]);
                    lstCuttingOrder[i].modificatorUser = DS.Tables[0].Rows[i]["cord_modificatorUser"].ToString();
                    lstCuttingOrder[i].lstCuttingOrderDetail = clsCuttingOrderDetail.getListByCuttingOrder(lstCuttingOrder[i].codsec);
                    //lstCuttingOrder[i].lstCuttingStop = clsCuttingStop.getSimplifiedListByCuttingOrder(lstCuttingOrder[i].codsec);
                    lstCuttingOrder[i].allowEquivalentFilm = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cord_allowEquivalentFilm"], DS.Tables[0].Rows[i]["cord_allowEquivalentFilm"].GetType().FullName);
                    lstCuttingOrder[i].priority = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_Priority"]);
                }
            }
            return lstCuttingOrder;
        }

        public static List<clsCuttingOrder> getCuttingOrderListByMachine(int machineCodsec)
        {
            List<clsCuttingOrder> lstCuttingOrder = new List<clsCuttingOrder>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spCuttingOrderByMachine(" + machineCodsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCuttingOrder.Add(new clsCuttingOrder());

                    lstCuttingOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_codsec"]);
                    lstCuttingOrder[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkMachine"]);
                    lstCuttingOrder[i].machineName = DS.Tables[0].Rows[i]["cord_machineName"].ToString();
                    lstCuttingOrder[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkStatus"]);
                    lstCuttingOrder[i].statusName = DS.Tables[0].Rows[i]["cord_statusName"].ToString();
                    lstCuttingOrder[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkBopp"]);
                    lstCuttingOrder[i].boppName = DS.Tables[0].Rows[i]["cord_boppName"].ToString();
                    lstCuttingOrder[i].boppCode = DS.Tables[0].Rows[i]["cord_boppCode"].ToString();
                    lstCuttingOrder[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkCast"]);
                    lstCuttingOrder[i].castName = DS.Tables[0].Rows[i]["cord_castName"].ToString();
                    lstCuttingOrder[i].castCode = DS.Tables[0].Rows[i]["cord_castCode"].ToString();
                    lstCuttingOrder[i].fkCoating = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkCoating"]);
                    lstCuttingOrder[i].coatingName = DS.Tables[0].Rows[i]["cord_coatingName"].ToString();
                    lstCuttingOrder[i].coatingCode = DS.Tables[0].Rows[i]["cord_coatingCode"].ToString();
                    lstCuttingOrder[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkProduct"]);
                    lstCuttingOrder[i].productName = DS.Tables[0].Rows[i]["cord_productName"].ToString();
                    lstCuttingOrder[i].productCode = DS.Tables[0].Rows[i]["cord_productCode"].ToString();
                    lstCuttingOrder[i].isSecundaryCut = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cord_isSecundaryCut"], DS.Tables[0].Rows[i]["cord_isSecundaryCut"].GetType().FullName);
                    lstCuttingOrder[i].number = DS.Tables[0].Rows[i]["cord_number"].ToString();
                    lstCuttingOrder[i].positions = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_positions"]);
                    lstCuttingOrder[i].repetitions = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_repetitions"]);
                    lstCuttingOrder[i].programmedWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["cord_programmedWeight"]);
                    lstCuttingOrder[i].programmedLength = Convert.ToDouble(DS.Tables[0].Rows[i]["cord_programmedLength"]);
                    lstCuttingOrder[i].position = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_position"]);
                    lstCuttingOrder[i].notes = DS.Tables[0].Rows[i]["cord_notes"].ToString();
                    lstCuttingOrder[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["cord_createdDate"]);
                    lstCuttingOrder[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["cord_modifiedDate"]);
                    lstCuttingOrder[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_createdBy"]);
                    lstCuttingOrder[i].creatorUser = DS.Tables[0].Rows[i]["cord_creatorUser"].ToString();
                    lstCuttingOrder[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_modifiedBy"]);
                    lstCuttingOrder[i].modificatorUser = DS.Tables[0].Rows[i]["cord_modificatorUser"].ToString();
                    lstCuttingOrder[i].lstCuttingOrderDetail = clsCuttingOrderDetail.getListByCuttingOrder(lstCuttingOrder[i].codsec);
                    lstCuttingOrder[i].lstCuttingStop = clsCuttingStop.getSimplifiedListByCuttingOrder(lstCuttingOrder[i].codsec);
                    lstCuttingOrder[i].allowEquivalentFilm = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cord_allowEquivalentFilm"], DS.Tables[0].Rows[i]["cord_allowEquivalentFilm"].GetType().FullName);
                    lstCuttingOrder[i].priority = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_Priority"]);
                }
            }
            return lstCuttingOrder;
        }

        public static List<clsCuttingOrder> getCuttingOrderListByMachienAndDate(int machineCodsec, DateTime initdate, DateTime enddate)
        {
            List<clsCuttingOrder> lstCuttingOrder = new List<clsCuttingOrder>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spCuttingOrderByMachineAndDate(" + machineCodsec.ToString() + ",'" + initdate.Date.ToString("dd/MM/yyyy") + "','" + enddate.Date.ToString("dd/MM/yyyy") + "')");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCuttingOrder.Add(new clsCuttingOrder());

                    lstCuttingOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_codsec"]);
                    lstCuttingOrder[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkMachine"]);
                    lstCuttingOrder[i].machineName = DS.Tables[0].Rows[i]["cord_machineName"].ToString();
                    lstCuttingOrder[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkStatus"]);
                    lstCuttingOrder[i].statusName = DS.Tables[0].Rows[i]["cord_statusName"].ToString();
                    lstCuttingOrder[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkBopp"]);
                    lstCuttingOrder[i].boppName = DS.Tables[0].Rows[i]["cord_boppName"].ToString();
                    lstCuttingOrder[i].boppCode = DS.Tables[0].Rows[i]["cord_boppCode"].ToString();
                    lstCuttingOrder[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkCast"]);
                    lstCuttingOrder[i].castName = DS.Tables[0].Rows[i]["cord_castName"].ToString();
                    lstCuttingOrder[i].castCode = DS.Tables[0].Rows[i]["cord_castCode"].ToString();
                    lstCuttingOrder[i].fkCoating = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkCoating"]);
                    lstCuttingOrder[i].coatingName = DS.Tables[0].Rows[i]["cord_coatingName"].ToString();
                    lstCuttingOrder[i].coatingCode = DS.Tables[0].Rows[i]["cord_coatingCode"].ToString();
                    lstCuttingOrder[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkProduct"]);
                    lstCuttingOrder[i].productName = DS.Tables[0].Rows[i]["cord_productName"].ToString();
                    lstCuttingOrder[i].productCode = DS.Tables[0].Rows[i]["cord_productCode"].ToString();
                    lstCuttingOrder[i].isSecundaryCut = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cord_isSecundaryCut"], DS.Tables[0].Rows[i]["cord_isSecundaryCut"].GetType().FullName);
                    lstCuttingOrder[i].number = DS.Tables[0].Rows[i]["cord_number"].ToString();
                    lstCuttingOrder[i].positions = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_positions"]);
                    lstCuttingOrder[i].repetitions = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_repetitions"]);
                    lstCuttingOrder[i].programmedWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["cord_programmedWeight"]);
                    lstCuttingOrder[i].programmedLength = Convert.ToDouble(DS.Tables[0].Rows[i]["cord_programmedLength"]);
                    lstCuttingOrder[i].position = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_position"]);
                    lstCuttingOrder[i].notes = DS.Tables[0].Rows[i]["cord_notes"].ToString();
                    lstCuttingOrder[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["cord_createdDate"]);
                    lstCuttingOrder[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["cord_modifiedDate"]);
                    lstCuttingOrder[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_createdBy"]);
                    lstCuttingOrder[i].creatorUser = DS.Tables[0].Rows[i]["cord_creatorUser"].ToString();
                    lstCuttingOrder[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_modifiedBy"]);
                    lstCuttingOrder[i].modificatorUser = DS.Tables[0].Rows[i]["cord_modificatorUser"].ToString();
                    lstCuttingOrder[i].lstCuttingOrderDetail = clsCuttingOrderDetail.getListByCuttingOrder(lstCuttingOrder[i].codsec);
                    lstCuttingOrder[i].allowEquivalentFilm = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cord_allowEquivalentFilm"], DS.Tables[0].Rows[i]["cord_allowEquivalentFilm"].GetType().FullName);
                    lstCuttingOrder[i].priority = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_Priority"]);
                }
            }
            return lstCuttingOrder;
        }

        public static List<clsCuttingOrder> getActiveOrderListByMachine(int machineCodsec)
        {
            List<clsCuttingOrder> lstCuttingOrder = new List<clsCuttingOrder>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL sp_activeCuttingOrderByMachine(" + machineCodsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCuttingOrder.Add(new clsCuttingOrder());

                    lstCuttingOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_codsec"]);
                    lstCuttingOrder[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkMachine"]);
                    lstCuttingOrder[i].machineName = DS.Tables[0].Rows[i]["cord_machineName"].ToString();
                    lstCuttingOrder[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkStatus"]);
                    lstCuttingOrder[i].statusName = DS.Tables[0].Rows[i]["cord_statusName"].ToString();
                    lstCuttingOrder[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkBopp"]);
                    lstCuttingOrder[i].boppName = DS.Tables[0].Rows[i]["cord_boppName"].ToString();
                    lstCuttingOrder[i].boppCode = DS.Tables[0].Rows[i]["cord_boppCode"].ToString();
                    lstCuttingOrder[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkCast"]);
                    lstCuttingOrder[i].castName = DS.Tables[0].Rows[i]["cord_castName"].ToString();
                    lstCuttingOrder[i].castCode = DS.Tables[0].Rows[i]["cord_castCode"].ToString();
                    lstCuttingOrder[i].fkCoating = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkCoating"]);
                    lstCuttingOrder[i].coatingName = DS.Tables[0].Rows[i]["cord_coatingName"].ToString();
                    lstCuttingOrder[i].coatingCode = DS.Tables[0].Rows[i]["cord_coatingCode"].ToString();
                    lstCuttingOrder[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkProduct"]);
                    lstCuttingOrder[i].productName = DS.Tables[0].Rows[i]["cord_productName"].ToString();
                    lstCuttingOrder[i].productCode = DS.Tables[0].Rows[i]["cord_productCode"].ToString();
                    lstCuttingOrder[i].isSecundaryCut = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cord_isSecundaryCut"], DS.Tables[0].Rows[i]["cord_isSecundaryCut"].GetType().FullName);
                    lstCuttingOrder[i].number = DS.Tables[0].Rows[i]["cord_number"].ToString();
                    lstCuttingOrder[i].positions = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_positions"]);
                    lstCuttingOrder[i].repetitions = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_repetitions"]);
                    lstCuttingOrder[i].programmedWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["cord_programmedWeight"]);
                    lstCuttingOrder[i].programmedLength = Convert.ToDouble(DS.Tables[0].Rows[i]["cord_programmedLength"]);
                    lstCuttingOrder[i].position = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_position"]);
                    lstCuttingOrder[i].notes = DS.Tables[0].Rows[i]["cord_notes"].ToString();
                    lstCuttingOrder[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["cord_createdDate"]);
                    lstCuttingOrder[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["cord_modifiedDate"]);
                    lstCuttingOrder[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_createdBy"]);
                    lstCuttingOrder[i].creatorUser = DS.Tables[0].Rows[i]["cord_creatorUser"].ToString();
                    lstCuttingOrder[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_modifiedBy"]);
                    lstCuttingOrder[i].modificatorUser = DS.Tables[0].Rows[i]["cord_modificatorUser"].ToString();
                    lstCuttingOrder[i].lstCuttingOrderDetail = clsCuttingOrderDetail.getListByCuttingOrder(lstCuttingOrder[i].codsec);
                    //lstCuttingOrder[i].lstCuttingStop = clsCuttingStop.getSimplifiedListByCuttingOrder(lstCuttingOrder[i].codsec);
                    lstCuttingOrder[i].allowEquivalentFilm = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cord_allowEquivalentFilm"], DS.Tables[0].Rows[i]["cord_allowEquivalentFilm"].GetType().FullName);
                    lstCuttingOrder[i].priority = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_Priority"]);
                }
            }
            return lstCuttingOrder;
        }
        public static clsCuttingOrder getActiveOrderByMachine(int machineCodsec)
        {
            clsCuttingOrder objCuttingOrder = new clsCuttingOrder();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spActiveCuttingOrderByMachine(" + machineCodsec.ToString() + ")");

            if (DS.Tables.Count>0 && DS.Tables[0].Rows.Count > 0)
            {
                objCuttingOrder.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_codsec"]);
                objCuttingOrder.fkMachine = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_fkMachine"]);
                objCuttingOrder.machineName = DS.Tables[0].Rows[0]["cord_machineName"].ToString();
                objCuttingOrder.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_fkStatus"]);
                objCuttingOrder.statusName = DS.Tables[0].Rows[0]["cord_statusName"].ToString();
                objCuttingOrder.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_fkBopp"]);
                objCuttingOrder.boppName = DS.Tables[0].Rows[0]["cord_boppName"].ToString();
                objCuttingOrder.boppCode = DS.Tables[0].Rows[0]["cord_boppCode"].ToString();
                objCuttingOrder.fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_fkCast"]);
                objCuttingOrder.castName = DS.Tables[0].Rows[0]["cord_castName"].ToString();
                objCuttingOrder.castCode = DS.Tables[0].Rows[0]["cord_castCode"].ToString();
                objCuttingOrder.fkCoating = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_fkCoating"]);
                objCuttingOrder.coatingName = DS.Tables[0].Rows[0]["cord_coatingName"].ToString();
                objCuttingOrder.coatingCode = DS.Tables[0].Rows[0]["cord_coatingCode"].ToString();
                objCuttingOrder.fkProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_fkCoating"]);
                objCuttingOrder.productName = DS.Tables[0].Rows[0]["cord_productName"].ToString();
                objCuttingOrder.productCode = DS.Tables[0].Rows[0]["cord_productCode"].ToString();
                objCuttingOrder.isSecundaryCut = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cord_isSecundaryCut"], DS.Tables[0].Rows[0]["cord_isSecundaryCut"].GetType().FullName);
                objCuttingOrder.number = DS.Tables[0].Rows[0]["cord_number"].ToString();
                objCuttingOrder.positions = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_positions"]);
                objCuttingOrder.repetitions = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_repetitions"]);
                objCuttingOrder.programmedWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["cord_programmedWeight"]);
                objCuttingOrder.programmedLength = Convert.ToDouble(DS.Tables[0].Rows[0]["cord_programmedLength"]);
                objCuttingOrder.position = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_position"]);
                objCuttingOrder.notes = DS.Tables[0].Rows[0]["cord_notes"].ToString();
                objCuttingOrder.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["cord_createdDate"]);
                objCuttingOrder.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["cord_modifiedDate"]);
                objCuttingOrder.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_createdBy"]);
                objCuttingOrder.creatorUser = DS.Tables[0].Rows[0]["cord_creatorUser"].ToString();
                objCuttingOrder.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_modifiedBy"]);
                objCuttingOrder.modificatorUser = DS.Tables[0].Rows[0]["cord_modificatorUser"].ToString();
                objCuttingOrder.lstCuttingOrderDetail = clsCuttingOrderDetail.getListByCuttingOrder(objCuttingOrder.codsec);
                //objCuttingOrder.lstCuttingStop = clsCuttingStop.getListByCuttingOrder(objCuttingOrder.codsec);
                objCuttingOrder.allowEquivalentFilm = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cord_allowEquivalentFilm"], DS.Tables[0].Rows[0]["cord_allowEquivalentFilm"].GetType().FullName);
                objCuttingOrder.priority = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_Priority"]);
            }
            return objCuttingOrder;
        }
        public static clsCuttingOrder getSimplifiedActiveOrderByMachine(int machineCodsec)
        {
            clsCuttingOrder objCuttingOrder = new clsCuttingOrder();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spActiveCuttingOrderByMachine(" + machineCodsec.ToString() + ")");

            if (DS.Tables[0].Rows.Count > 0)
            {
                objCuttingOrder.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_codsec"]);
                objCuttingOrder.fkMachine = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_fkMachine"]);
                objCuttingOrder.machineName = DS.Tables[0].Rows[0]["cord_machineName"].ToString();
                objCuttingOrder.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_fkStatus"]);
                objCuttingOrder.statusName = DS.Tables[0].Rows[0]["cord_statusName"].ToString();
                objCuttingOrder.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_fkBopp"]);
                objCuttingOrder.boppName = DS.Tables[0].Rows[0]["cord_boppName"].ToString();
                objCuttingOrder.boppCode = DS.Tables[0].Rows[0]["cord_boppCode"].ToString();
                objCuttingOrder.fkCast = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_fkCast"]);
                objCuttingOrder.castName = DS.Tables[0].Rows[0]["cord_castName"].ToString();
                objCuttingOrder.castCode = DS.Tables[0].Rows[0]["cord_castCode"].ToString();
                objCuttingOrder.fkCoating = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_fkCoating"]);
                objCuttingOrder.coatingName = DS.Tables[0].Rows[0]["cord_coatingName"].ToString();
                objCuttingOrder.coatingCode = DS.Tables[0].Rows[0]["cord_coatingCode"].ToString();
                objCuttingOrder.fkProduct = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_fkCoating"]);
                objCuttingOrder.productName = DS.Tables[0].Rows[0]["cord_productName"].ToString();
                objCuttingOrder.productCode = DS.Tables[0].Rows[0]["cord_productCode"].ToString();
                objCuttingOrder.isSecundaryCut = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cord_isSecundaryCut"], DS.Tables[0].Rows[0]["cord_isSecundaryCut"].GetType().FullName);
                objCuttingOrder.number = DS.Tables[0].Rows[0]["cord_number"].ToString();
                objCuttingOrder.positions = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_positions"]);
                objCuttingOrder.repetitions = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_repetitions"]);
                objCuttingOrder.programmedWeight = Convert.ToDouble(DS.Tables[0].Rows[0]["cord_programmedWeight"]);
                objCuttingOrder.programmedLength = Convert.ToDouble(DS.Tables[0].Rows[0]["cord_programmedLength"]);
                objCuttingOrder.position = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_position"]);
                objCuttingOrder.notes = DS.Tables[0].Rows[0]["cord_notes"].ToString();
                objCuttingOrder.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["cord_createdDate"]);
                objCuttingOrder.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["cord_modifiedDate"]);
                objCuttingOrder.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_createdBy"]);
                objCuttingOrder.creatorUser = DS.Tables[0].Rows[0]["cord_creatorUser"].ToString();
                objCuttingOrder.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_modifiedBy"]);
                objCuttingOrder.modificatorUser = DS.Tables[0].Rows[0]["cord_modificatorUser"].ToString();
                //objCuttingOrder.lstCuttingOrderDetail = clsCuttingOrderDetail.getListByCuttingOrder(objCuttingOrder.codsec);
                //objCuttingOrder.lstCuttingStop = clsCuttingStop.getListByCuttingOrder(objCuttingOrder.codsec);
                objCuttingOrder.allowEquivalentFilm = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["cord_allowEquivalentFilm"], DS.Tables[0].Rows[0]["cord_allowEquivalentFilm"].GetType().FullName);
                objCuttingOrder.priority = Convert.ToInt32(DS.Tables[0].Rows[0]["cord_Priority"]);
            }
            return objCuttingOrder;
        }
        public static List<clsCuttingOrder> getActiveOrderListWithStockProducts()
        {
            List<clsCuttingOrder> lstCuttingOrder = new List<clsCuttingOrder>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spActiveSalesOrderWithStockProducts()");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCuttingOrder.Add(new clsCuttingOrder());

                    lstCuttingOrder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_codsec"]);
                    lstCuttingOrder[i].fkMachine = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkMachine"]);
                    lstCuttingOrder[i].machineName = DS.Tables[0].Rows[i]["cord_machineName"].ToString();
                    lstCuttingOrder[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkStatus"]);
                    lstCuttingOrder[i].statusName = DS.Tables[0].Rows[i]["cord_statusName"].ToString();
                    lstCuttingOrder[i].fkBopp = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkBopp"]);
                    lstCuttingOrder[i].boppName = DS.Tables[0].Rows[i]["cord_boppName"].ToString();
                    lstCuttingOrder[i].boppCode = DS.Tables[0].Rows[i]["cord_boppCode"].ToString();
                    lstCuttingOrder[i].fkCast = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkCast"]);
                    lstCuttingOrder[i].castName = DS.Tables[0].Rows[i]["cord_castName"].ToString();
                    lstCuttingOrder[i].castCode = DS.Tables[0].Rows[i]["cord_castCode"].ToString();
                    lstCuttingOrder[i].fkCoating = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkCoating"]);
                    lstCuttingOrder[i].coatingName = DS.Tables[0].Rows[i]["cord_coatingName"].ToString();
                    lstCuttingOrder[i].coatingCode = DS.Tables[0].Rows[i]["cord_coatingCode"].ToString();
                    lstCuttingOrder[i].fkProduct = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_fkProduct"]);
                    lstCuttingOrder[i].productName = DS.Tables[0].Rows[i]["cord_productName"].ToString();
                    lstCuttingOrder[i].productCode = DS.Tables[0].Rows[i]["cord_productCode"].ToString();
                    lstCuttingOrder[i].isSecundaryCut = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cord_isSecundaryCut"], DS.Tables[0].Rows[i]["cord_isSecundaryCut"].GetType().FullName);
                    lstCuttingOrder[i].number = DS.Tables[0].Rows[i]["cord_number"].ToString();
                    lstCuttingOrder[i].positions = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_positions"]);
                    lstCuttingOrder[i].repetitions = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_repetitions"]);
                    lstCuttingOrder[i].programmedWeight = Convert.ToDouble(DS.Tables[0].Rows[i]["cord_programmedWeight"]);
                    lstCuttingOrder[i].programmedLength = Convert.ToDouble(DS.Tables[0].Rows[i]["cord_programmedLength"]);
                    lstCuttingOrder[i].position = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_position"]);
                    lstCuttingOrder[i].notes = DS.Tables[0].Rows[i]["cord_notes"].ToString();
                    lstCuttingOrder[i].createdDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["cord_createdDate"]);
                    lstCuttingOrder[i].modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["cord_modifiedDate"]);
                    lstCuttingOrder[i].createdBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_createdBy"]);
                    lstCuttingOrder[i].creatorUser = DS.Tables[0].Rows[i]["cord_creatorUser"].ToString();
                    lstCuttingOrder[i].modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_modifiedBy"]);
                    lstCuttingOrder[i].modificatorUser = DS.Tables[0].Rows[i]["cord_modificatorUser"].ToString();
                    lstCuttingOrder[i].lstCuttingOrderDetail = clsCuttingOrderDetail.getListByCuttingOrder(lstCuttingOrder[i].codsec);
                    //lstCuttingOrder[i].lstCuttingStop = clsCuttingStop.getSimplifiedListByCuttingOrder(lstCuttingOrder[i].codsec);
                    lstCuttingOrder[i].allowEquivalentFilm = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["cord_allowEquivalentFilm"], DS.Tables[0].Rows[i]["cord_allowEquivalentFilm"].GetType().FullName);
                    lstCuttingOrder[i].priority = Convert.ToInt32(DS.Tables[0].Rows[i]["cord_Priority"]);
                }
            }
            return lstCuttingOrder;
        }
        public bool canBeProcessed()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT cord_codsec FROM vwcuttingorder WHERE cord_fkMachine = " + this.fkMachine.ToString() + " and cord_fkStatus = 26");
            if (DS.Tables[0].Rows.Count > 0)
                return false;
            else
                return true;
        }
        public bool beingProcessed()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT cord_codsec FROM vwcuttingorder WHERE cord_fkMachine = " + this.fkMachine.ToString() + " and cord_fkStatus = 26");
            if (DS.Tables[0].Rows.Count > 0)
                if (Convert.ToInt32(DS.Tables[0].Rows[0]["cord_codsec"]) == this.codsec)
                    return true;
                else
                    return false;
            else
                return false;
        }
        public static int getNextNumber()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT cord_number FROM vwcuttingorder where cord_number <> '--' Order By cord_codsec DESC LIMIT 1");
            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(DS.Tables[0].Rows[0]["cord_number"]) + 1;
            else
                return 1;
        }
        public void changeStatus(string status)
        {
            switch (status)
            {
                case "En pausa":
                    this.fkStatus = (clsStatus.getStatusByStatusGroupNameAndStatusName("Ordenes de corte", status)).codsec;
                    this.save();
                    break;
                case "Ejecutandose":
                    this.fkStatus = (clsStatus.getStatusByStatusGroupNameAndStatusName("Ordenes de corte", status)).codsec;
                    this.save();
                    break;
                case "Cerrada":
                    this.fkStatus = (clsStatus.getStatusByStatusGroupNameAndStatusName("Ordenes de corte", status)).codsec;
                    this.save();
                    break;
                default:
                    break;
            }
        }
        public static List<clsSalesOrder> getSalesOrderByCuttingOrder(int cuttingOrderCodsec)
        {
            clsCuttingOrder objCuttingOrder = new clsCuttingOrder(cuttingOrderCodsec);
            List<clsSalesOrder> lstSalesOrder = new List<clsSalesOrder>();


            if (objCuttingOrder.codsec > 0)
            {
                for (int i = 0; i < objCuttingOrder.lstCuttingOrderDetail.Count; i++)
                {
                    if (objCuttingOrder.lstCuttingOrderDetail[i].fkSalesOrderDetail > 0)
                    {
                        clsSalesOrderDetail objSalesOrderDetail = new clsSalesOrderDetail(objCuttingOrder.lstCuttingOrderDetail[i].fkSalesOrderDetail);
                        bool inList = false;

                        for (int j = 0; j < lstSalesOrder.Count; j++)
                        {
                            if (lstSalesOrder[j].codsec == objSalesOrderDetail.fkSalesOrder)
                                inList = true;
                        }

                        if (inList == false)
                            lstSalesOrder.Add(new clsSalesOrder(objSalesOrderDetail.fkSalesOrder));
                    }
                }
            }
            return lstSalesOrder;
        }
        public static bool cuttingOrderHasStockEntries(int cuttingOrderCodsec)
        {
            List<clsCuttingOrderDetail> lstCuttingOrderDetail = clsCuttingOrderDetail.getStockEntriesByCuttingOrder(cuttingOrderCodsec);

            if (lstCuttingOrderDetail.Count > 0)
                return true;
            else
                return false;
        }
        public static bool DeleteByCodsec(int cuttingOrderCodsec)
        {
            return clsConnection.executeQuery("DELETE FROM bps_prod_cuttingorder WHERE cord_codsec=" + cuttingOrderCodsec.ToString());
        }
    }

}
