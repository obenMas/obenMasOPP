using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsEfficiencyCutExtruder
    {
        private int eff_codsec;
        private int eff_fkStatus;
        private int eff_fkCuttingOrder;
        private clsCuttingOrder eff_objfkCuttingOrder;
        private string eff_CuttingStopValues;
        private List<double> eff_CuttingStopList;
        private int eff_CuttingPosition;
        private string eff_CoilsValues;
        private List<int> eff_CoilsList;
        private double eff_Refile;
        private double eff_Decrease;
        private double eff_EndRoller;
        private double eff_Consuption;
        private int eff_CuttingNumber;
        private bool eff_isReprocess;
        private int eff_createdBy;
        private string eff_userCreator;
        private int eff_modificatedBy;
        private string eff_userModificator;
        private DateTime eff_createdDate;
        private DateTime eff_modifiedDate;
        private string eff_statusName;
        private int eff_CuttingStopCodsec;
        private string eff_MainCoilValues;
        private List<int> eff_MainCoilList;
        private string eff_SeqCoilValues;
        private List<int> eff_SeqCoilList;
        private string eff_Notes;
        private double eff_Waste;
        private string eff_WasteCoil;
        private bool eff_Splice;
        private double eff_SpliceInit;
        private string eff_SpliceInitCoil;
        private double eff_SpliceEnd;
        private string eff_SpliceEndCoil;
        private double eff_ConsuptionObs;
        private string eff_ReprocessCoil;
        private bool eff_isLegth;
        private string eff_LegthValues;
        private bool eff_isWeigth;
        private string eff_WeigthValues;
        private double eff_SpliceThree;
        private string eff_SpliceCoilThree;
        private string eff_lotNumber;
        private double eff_totalDecrease;
        private double eff_totalComsuptionDecrease;
        private double eff_efficiency;
        private double eff_mainCoilWeigth;
        private int eff_maincoilCount;
        private int eff_coilCount;
        private string eff_bopp;
        private double eff_coilNetweigth;

        
        
        public double coilNetweigth
        {
            get { return eff_coilNetweigth; }
            set { eff_coilNetweigth = value; }
        }


        public string Bopp
        {
            get { return eff_bopp; }
            set { eff_bopp = value; }
        }


        public int coilCount
        {
            get { return eff_coilCount; }
            set { eff_coilCount = value; }
        }


        public int maincoilCount
        {
            get { return eff_maincoilCount; }
            set { eff_maincoilCount = value; }
        }

        
        public double mainCoilWeigth
        {
            get { return eff_mainCoilWeigth; }
            set { eff_mainCoilWeigth = value; }
        }


        public double efficiency
        {
            get { return eff_efficiency; }
            set { eff_efficiency = value; }
        }


        public double totalComsuptionDecrease
        {
            get { return eff_totalComsuptionDecrease; }
            set { eff_totalComsuptionDecrease = value; }
        }


        public double totalDecrease
        {
            get { return eff_totalDecrease; }
            set { eff_totalDecrease = value; }
        }

        public string lotnumber
        {
            get { return eff_lotNumber; }
            set { eff_lotNumber = value; }
        }



        
        public int codsec { get { return eff_codsec; } set { eff_codsec = value; } }

        public int fkStatus { get { return eff_fkStatus; } set { eff_fkStatus = value; } }

        public int fkCuttingOrder { get { return eff_fkCuttingOrder; } set { eff_fkCuttingOrder = value; } }

        public clsCuttingOrder objCuttingOrder { get { return eff_objfkCuttingOrder; } set { eff_objfkCuttingOrder = value; } }

        public string cuttingstop { get { return eff_CuttingStopValues; } set { eff_CuttingStopValues = value; } }

        public List<double> cuttingstopList { get { return eff_CuttingStopList; } set { eff_CuttingStopList = value; } }

        public int cuttingposition { get { return eff_CuttingPosition; } set { eff_CuttingPosition = value; } }

        public string coilsValues { get { return eff_CoilsValues; } set { eff_CoilsValues = value; } }

        public List<int> coilList { get { return eff_CoilsList; } set { eff_CoilsList = value; } }

        public double refile { get { return eff_Refile; } set { eff_Refile = value; } }

        public double decrease { get { return eff_Decrease; } set { eff_Decrease = value; } }

        public double endroller { get { return eff_EndRoller; } set { eff_EndRoller = value; } }

        public double consuption { get { return eff_Consuption; } set { eff_Consuption = value; } }

        public int cuttingNumber { get { return eff_CuttingNumber; } set { eff_CuttingNumber = value; } }

        public bool isReprocess { get { return eff_isReprocess; } set { eff_isReprocess = value; } }

        public int createdBy { get { return eff_createdBy; } set { eff_createdBy = value; } }

        public string userCreatorName { get { return eff_userCreator; } set { eff_userCreator = value; } }

        public int modifiedBy { get { return eff_modificatedBy; } set { eff_modificatedBy = value; } }

        public string userModificatorName { get { return eff_userModificator; } set { eff_userModificator = value; } }

        public DateTime createdDate { get { return eff_createdDate; } set { eff_createdDate = value; } }

        public DateTime modifiedDate { get { return eff_modifiedDate; } set { eff_modifiedDate = value; } }

        public string statusName { get { return eff_statusName; } set { eff_statusName = value; } }

        public int cuttingstopcodsec { get { return eff_CuttingStopCodsec; } set { eff_CuttingStopCodsec = value; } }

        public string MainCoilValues { get { return eff_MainCoilValues; } set { eff_MainCoilValues = value; } }

        public List<int> MainCoilList { get { return eff_MainCoilList; } set { eff_MainCoilList = value; } }

        public string SeqCoilValues { get { return eff_SeqCoilValues; } set { eff_SeqCoilValues = value; } }

        public List<int> SeqCoilList { get { return eff_SeqCoilList; } set { eff_SeqCoilList = value; } }

        public string notes { get { return eff_Notes; } set { eff_Notes = value; } }

        public double waste
        {
            get { return eff_Waste; }
            set { eff_Waste = value; }
        }

        public string wasteCoil
        {
            get { return eff_WasteCoil; }
            set { eff_WasteCoil = value; }
        }

        public bool splice
        {
            get { return eff_Splice; }
            set { eff_Splice = value; }
        }

        public double spliceInit
        {
            get { return eff_SpliceInit; }
            set { eff_SpliceInit = value; }
        }

        public string spliceInitiCoil
        {
            get { return eff_SpliceInitCoil; }
            set { eff_SpliceInitCoil = value; }
        }

        public double spliceEnd
        {
            get { return eff_SpliceEnd; }
            set { eff_SpliceEnd = value; }
        }

        public string spliceEndCoil
        {
            get { return eff_SpliceEndCoil; }
            set { eff_SpliceEndCoil = value; }
        }

        public double spliceThree
        {
            get { return eff_SpliceThree; }
            set { eff_SpliceThree = value; }
        }

        public string spliceCoilThree
        {
            get { return eff_SpliceCoilThree; }
            set { eff_SpliceCoilThree = value; }
        }

        public string reprocessCoil
        {
            get { return eff_ReprocessCoil; }
            set { eff_ReprocessCoil = value; }
        }

        public bool isLegth
        {
            get { return eff_isLegth; }
            set { eff_isLegth = value; }
        }

        public string legthValues
        {
            get { return eff_LegthValues; }
            set { eff_LegthValues = value; }
        }

        public double ConsuptionObs
        {
            get { return eff_ConsuptionObs; }
            set { eff_ConsuptionObs = value; }
        }

        public bool isWeigth
        {
            get { return eff_isWeigth; }
            set { eff_isWeigth = value; }
        }

        public string weigthValues
        {
            get { return eff_WeigthValues; }
            set { eff_WeigthValues = value; }
        }

        public clsEfficiencyCutExtruder()
        {
            eff_codsec = 0;
            eff_fkStatus = 0;
            eff_fkCuttingOrder = 0;
            eff_CuttingStopCodsec = 0;
            eff_objfkCuttingOrder = new clsCuttingOrder();
            eff_CuttingStopValues = "";
            eff_CuttingStopList = new List<double>();
            eff_CuttingPosition = 0;
            eff_CoilsValues = "";
            eff_CoilsList = new List<int>();
            eff_Refile = 0;
            eff_Decrease = 0;
            eff_EndRoller = 0;
            eff_Consuption = 0;
            eff_CuttingNumber = 0;
            eff_isReprocess = false;
            eff_createdBy = 0;
            eff_userCreator = "";
            eff_modificatedBy = 0;
            eff_userModificator = "";
            eff_createdDate = DateTime.Now;
            eff_modifiedDate = DateTime.Now;
            eff_statusName = "";
            eff_Notes = "";
            eff_Waste = 0;
            eff_WasteCoil = "";
            eff_Splice = false;
            eff_SpliceInit = 0;
            eff_SpliceInitCoil = "";
            eff_SpliceEnd = 0;
            eff_SpliceEndCoil = "";
            eff_ConsuptionObs = 0;
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_efficiencycutextrduer (eff_fkStatus, eff_fkCuttingOrder, eff_CuttingStopCodsec, eff_CuttingPosition, eff_Refile, eff_Decrease, eff_EndRoller, eff_Consuption, eff_ConsuptionObs, eff_CuttingNumber, eff_isSecundaryCut, eff_Notes, eff_Waste, eff_WasteCoil, eff_Splice, eff_SpliceInit, eff_SpliceInitCoil, eff_SpliceEnd, eff_SpliceEndCoil, eff_ReprocessCoil, eff_isLegth, eff_LegthValues, eff_isWeigth, eff_WeigthValues, eff_SpliceThree, eff_SpliceCoilThree, eff_createdBy, eff_modificateBy, eff_createdDate, eff_modifiedDate)  VALUES (";
                    queryString += this.fkStatus.ToString() + ",";
                    queryString += this.fkCuttingOrder.ToString() + ",";
                    queryString += this.cuttingstopcodsec.ToString() + ",";
                    queryString += this.cuttingposition.ToString() + ",";
                    queryString += this.refile.ToString() + ",";
                    queryString += this.decrease.ToString() + ",";
                    queryString += this.endroller.ToString() + ",";
                    queryString += this.consuption.ToString() + ",";
                    queryString += this.ConsuptionObs.ToString() + ",";
                    queryString += this.cuttingNumber.ToString() + ",";
                    queryString += this.isReprocess.ToString() + ",";
                    queryString += "'" + this.notes.ToString() + "',";
                    queryString += this.waste.ToString() + ",";
                    queryString += "'"+this.wasteCoil.ToString() + "',";
                    queryString += this.splice.ToString() + ",";
                    queryString += this.spliceInit.ToString() + ",";
                    queryString += "'"+this.spliceInitiCoil.ToString() + "',";
                    queryString += this.spliceEnd.ToString() + ",";
                    queryString += "'" + this.spliceEndCoil.ToString() + "',";
                    queryString += "'" + this.reprocessCoil.ToString() + "',";
                    queryString += this.isLegth.ToString() + ",";
                    queryString += "'" + this.legthValues.ToString() + "',";
                    queryString += this.isWeigth.ToString() + ",";
                    queryString += "'" + this.weigthValues.ToString() + "',";
                    queryString += "" + this.spliceThree.ToString() + ",";
                    queryString += "'" + this.spliceCoilThree.ToString() + "',";
                    queryString += clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "',";
                    queryString += "'" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "');";
                }
                else
                {
                    queryString += "UPDATE bps_prod_efficiencycutextrduer SET eff_fkCuttingOrder = " + this.fkCuttingOrder.ToString();
                    queryString += ", eff_CuttingPosition =" + this.cuttingposition.ToString();
                    queryString += ", eff_CuttingStopCodsec =" + this.cuttingstopcodsec.ToString();
                    queryString += ", eff_Refile = " + this.refile.ToString();
                    queryString += ", eff_Decrease = " + this.decrease.ToString();
                    queryString += ", eff_EndRoller = " + this.endroller.ToString();
                    queryString += ", eff_Consuption = " + this.consuption.ToString();
                    queryString += ", eff_ConsuptionObs = " + this.ConsuptionObs.ToString();
                    queryString += ", eff_CuttingNumber = " + this.cuttingNumber.ToString();
                    queryString += ", eff_isSecundaryCut = " + this.isReprocess.ToString();
                    queryString += ", eff_Notes = '" + this.notes.ToString() + "'";
                    queryString += ", eff_Waste = " + this.waste.ToString();
                    queryString += ", eff_WasteCoil = '" + this.wasteCoil.ToString() +"'";
                    queryString += ", eff_Splice = " + this.splice.ToString();
                    queryString += ", eff_SpliceInit = " + this.spliceInit.ToString();
                    queryString += ", eff_SpliceInitCoil = '" + this.spliceInitiCoil.ToString() + "'";
                    queryString += ", eff_SpliceEnd = " + this.spliceEnd.ToString();
                    queryString += ", eff_SpliceEndCoil = '" + this.spliceEndCoil.ToString() + "'";
                    queryString += ", eff_ReprocessCoil = '" + this.reprocessCoil.ToString() + "'";
                    queryString += ", eff_isLegth = " + this.isLegth.ToString() + "";
                    queryString += ", eff_LegthValues = '" + this.legthValues.ToString() + "'";
                    queryString += ", eff_isWeigth = " + this.isWeigth.ToString() + "";
                    queryString += ", eff_SpliceThree = " + this.spliceThree.ToString();
                    queryString += ", eff_SpliceCoilThree = '" + this.spliceCoilThree.ToString() + "'";
                    queryString += ", eff_WeigthValues = '" + this.weigthValues.ToString() + "'";
                    queryString += ", eff_modificateBy = " + clsGlobal.LoggedUser.codsec.ToString();
                    queryString += ", eff_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "'";
                    queryString += " WHERE eff_codsec = " + this.codsec.ToString() + ";";
                }
                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsRecordProductionThickness.save");
                return false;
            }
        }

        public bool saveMainCoil()
        {
            try
            {
                string queryString = "";

                queryString += "UPDATE bps_prod_efficiencycutextrduer SET eff_MainCoil = '" + this.MainCoilValues.ToString() + "'";
                queryString += ", eff_modificateBy = " + clsGlobal.LoggedUser.codsec.ToString();
                queryString += ", eff_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "'";
                queryString += " WHERE eff_codsec = " + this.codsec.ToString() + ";";

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsRecordProductionThickness.save");
                return false;
            }
        }

        public bool saveSeqCoil()
        {
            try
            {
                string queryString = "";

                queryString += "UPDATE bps_prod_efficiencycutextrduer SET eff_SeqCoil = '" + this.SeqCoilValues.ToString() + "'";
                queryString += ", eff_modificateBy = " + clsGlobal.LoggedUser.codsec.ToString();
                queryString += ", eff_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "'";
                queryString += " WHERE eff_codsec = " + this.codsec.ToString() + ";";

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsRecordProductionThickness.save");
                return false;
            }
        }

        public bool saveCoil()
        {
            try
            {
                string queryString = "";

                queryString += "UPDATE bps_prod_efficiencycutextrduer SET eff_Coils = '" + this.coilsValues.ToString() + "'";
                queryString += ", eff_modificateBy = " + clsGlobal.LoggedUser.codsec.ToString();
                queryString += ", eff_modifiedDate = '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "'";
                queryString += " WHERE eff_codsec = " + this.codsec.ToString() + ";";

                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsRecordProductionThickness.save");
                return false;
            }
        }

        public static clsEfficiencyCutExtruder getEfficiencyCutExtruderByCuttingOrder(int cuttingNumber, int position)
        {
            clsEfficiencyCutExtruder objEfficiencyCutExtruder = new clsEfficiencyCutExtruder();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spEfficiencyCutByExtruder 'ListPerCuttingNumberAndPosition'," + position.ToString() + "," + cuttingNumber.ToString() + ",'','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                objEfficiencyCutExtruder.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["eff_codsec"]);
                objEfficiencyCutExtruder.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["eff_fkStatus"]);
                objEfficiencyCutExtruder.fkCuttingOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["eff_fkCuttingOrder"]);
                objEfficiencyCutExtruder.cuttingstopcodsec = Convert.ToInt32(DS.Tables[0].Rows[0]["eff_CuttingStopCodsec"]);
                objEfficiencyCutExtruder.objCuttingOrder = new clsCuttingOrder(objEfficiencyCutExtruder.fkCuttingOrder);
                objEfficiencyCutExtruder.cuttingstop = DS.Tables[0].Rows[0]["eff_CuttingStop"].ToString();
                objEfficiencyCutExtruder.cuttingstopList = clsGlobal.getDoubleListFromString(objEfficiencyCutExtruder.cuttingstop);
                objEfficiencyCutExtruder.cuttingposition = Convert.ToInt32(DS.Tables[0].Rows[0]["eff_CuttingPosition"]);
                objEfficiencyCutExtruder.coilsValues = DS.Tables[0].Rows[0]["eff_Coils"].ToString();
                objEfficiencyCutExtruder.coilList = clsGlobal.getIntListFromString(objEfficiencyCutExtruder.coilsValues);
                objEfficiencyCutExtruder.refile = Convert.ToDouble(DS.Tables[0].Rows[0]["eff_Refile"]);
                objEfficiencyCutExtruder.decrease = Convert.ToDouble(DS.Tables[0].Rows[0]["eff_Decrease"]);
                objEfficiencyCutExtruder.endroller = Convert.ToDouble(DS.Tables[0].Rows[0]["eff_EndRoller"]);
                objEfficiencyCutExtruder.consuption = Convert.ToDouble(DS.Tables[0].Rows[0]["eff_Consuption"]);
                objEfficiencyCutExtruder.cuttingNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["eff_CuttingNumber"]);
                objEfficiencyCutExtruder.isReprocess = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["eff_isSecundaryCut"], DS.Tables[0].Rows[0]["eff_isSecundaryCut"].GetType().FullName);
                objEfficiencyCutExtruder.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["eff_createdBy"]);
                objEfficiencyCutExtruder.userCreatorName = DS.Tables[0].Rows[0]["eff_userCreator"].ToString();
                objEfficiencyCutExtruder.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["eff_modificateBy"]);
                objEfficiencyCutExtruder.userModificatorName = DS.Tables[0].Rows[0]["eff_userModificator"].ToString(); 
                objEfficiencyCutExtruder.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["eff_createdDate"]);
                objEfficiencyCutExtruder.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["eff_modifiedDate"]);
                objEfficiencyCutExtruder.statusName = DS.Tables[0].Rows[0]["eff_statusName"].ToString();
                objEfficiencyCutExtruder.notes = DS.Tables[0].Rows[0]["eff_Notes"].ToString();
                objEfficiencyCutExtruder.waste = Convert.ToDouble(DS.Tables[0].Rows[0]["eff_Waste"]);
                objEfficiencyCutExtruder.wasteCoil = DS.Tables[0].Rows[0]["eff_WasteCoil"].ToString();
                objEfficiencyCutExtruder.splice = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["eff_Splice"], DS.Tables[0].Rows[0]["eff_Splice"].GetType().FullName);
                objEfficiencyCutExtruder.spliceInit = Convert.ToDouble(DS.Tables[0].Rows[0]["eff_SpliceInit"]);
                objEfficiencyCutExtruder.spliceInitiCoil = DS.Tables[0].Rows[0]["eff_SpliceInitCoil"].ToString();
                objEfficiencyCutExtruder.spliceEnd = Convert.ToDouble(DS.Tables[0].Rows[0]["eff_SpliceEnd"]);
                objEfficiencyCutExtruder.spliceEndCoil = DS.Tables[0].Rows[0]["eff_SpliceEndCoil"].ToString();
                objEfficiencyCutExtruder.reprocessCoil = DS.Tables[0].Rows[0]["eff_ReprocessCoil"].ToString();
                objEfficiencyCutExtruder.isLegth = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["eff_isLegth"], DS.Tables[0].Rows[0]["eff_isLegth"].GetType().FullName);
                objEfficiencyCutExtruder.legthValues = DS.Tables[0].Rows[0]["eff_LegthValues"].ToString();
                objEfficiencyCutExtruder.eff_isWeigth = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["eff_isWeigth"], DS.Tables[0].Rows[0]["eff_isWeigth"].GetType().FullName);
                objEfficiencyCutExtruder.weigthValues = DS.Tables[0].Rows[0]["eff_WeigthValues"].ToString();
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return objEfficiencyCutExtruder;
        }

        public static clsEfficiencyCutExtruder getEfficiencyCutExtruderByCuttingOrder(int cuttingStopCodsec)
        {
            clsEfficiencyCutExtruder objEfficiencyCutExtruder = new clsEfficiencyCutExtruder();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spEfficiencyCutByExtruder 'ListPerCuttingStopCodsec',0," + cuttingStopCodsec.ToString() + ",'','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                objEfficiencyCutExtruder.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["eff_codsec"]);
                objEfficiencyCutExtruder.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["eff_fkStatus"]);
                objEfficiencyCutExtruder.fkCuttingOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["eff_fkCuttingOrder"]);
                objEfficiencyCutExtruder.cuttingstopcodsec = Convert.ToInt32(DS.Tables[0].Rows[0]["eff_CuttingStopCodsec"]);
                objEfficiencyCutExtruder.objCuttingOrder = new clsCuttingOrder(objEfficiencyCutExtruder.fkCuttingOrder);
                objEfficiencyCutExtruder.cuttingstop = DS.Tables[0].Rows[0]["eff_CuttingStop"].ToString();
                objEfficiencyCutExtruder.cuttingstopList = clsGlobal.getDoubleListFromString(objEfficiencyCutExtruder.cuttingstop);
                objEfficiencyCutExtruder.cuttingposition = Convert.ToInt32(DS.Tables[0].Rows[0]["eff_CuttingPosition"]);
                objEfficiencyCutExtruder.coilsValues = DS.Tables[0].Rows[0]["eff_Coils"].ToString();
                objEfficiencyCutExtruder.coilList = clsGlobal.getIntListFromString(objEfficiencyCutExtruder.coilsValues);
                objEfficiencyCutExtruder.refile = Convert.ToDouble(DS.Tables[0].Rows[0]["eff_Refile"]);
                objEfficiencyCutExtruder.decrease = Convert.ToDouble(DS.Tables[0].Rows[0]["eff_Decrease"]);
                objEfficiencyCutExtruder.endroller = Convert.ToDouble(DS.Tables[0].Rows[0]["eff_EndRoller"]);
                objEfficiencyCutExtruder.consuption = Convert.ToDouble(DS.Tables[0].Rows[0]["eff_Consuption"]);
                objEfficiencyCutExtruder.cuttingNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["eff_CuttingNumber"]);
                objEfficiencyCutExtruder.isReprocess = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["eff_isSecundaryCut"], DS.Tables[0].Rows[0]["eff_isSecundaryCut"].GetType().FullName);
                objEfficiencyCutExtruder.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["eff_createdBy"]);
                objEfficiencyCutExtruder.userCreatorName = DS.Tables[0].Rows[0]["eff_userCreator"].ToString();
                objEfficiencyCutExtruder.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["eff_modificateBy"]);
                objEfficiencyCutExtruder.userModificatorName = DS.Tables[0].Rows[0]["eff_userModificator"].ToString();
                objEfficiencyCutExtruder.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["eff_createdDate"]);
                objEfficiencyCutExtruder.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["eff_modifiedDate"]);
                objEfficiencyCutExtruder.statusName = DS.Tables[0].Rows[0]["eff_statusName"].ToString();
                objEfficiencyCutExtruder.notes = DS.Tables[0].Rows[0]["eff_Notes"].ToString();
                objEfficiencyCutExtruder.waste = Convert.ToDouble(DS.Tables[0].Rows[0]["eff_Waste"]);
                objEfficiencyCutExtruder.wasteCoil = DS.Tables[0].Rows[0]["eff_WasteCoil"].ToString();
                objEfficiencyCutExtruder.splice = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["eff_Splice"], DS.Tables[0].Rows[0]["eff_Splice"].GetType().FullName);
                objEfficiencyCutExtruder.spliceInit = Convert.ToDouble(DS.Tables[0].Rows[0]["eff_SpliceInit"]);
                objEfficiencyCutExtruder.spliceInitiCoil = DS.Tables[0].Rows[0]["eff_SpliceInitCoil"].ToString();
                objEfficiencyCutExtruder.spliceEnd = Convert.ToDouble(DS.Tables[0].Rows[0]["eff_SpliceEnd"]);
                objEfficiencyCutExtruder.spliceEndCoil = DS.Tables[0].Rows[0]["eff_SpliceEndCoil"].ToString();
                objEfficiencyCutExtruder.reprocessCoil = DS.Tables[0].Rows[0]["eff_ReprocessCoil"].ToString();
                objEfficiencyCutExtruder.isLegth = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["eff_isLegth"], DS.Tables[0].Rows[0]["eff_isLegth"].GetType().FullName);
                objEfficiencyCutExtruder.legthValues = DS.Tables[0].Rows[0]["eff_LegthValues"].ToString();
                objEfficiencyCutExtruder.eff_isWeigth = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["eff_isWeigth"], DS.Tables[0].Rows[0]["eff_isWeigth"].GetType().FullName);
                objEfficiencyCutExtruder.weigthValues = DS.Tables[0].Rows[0]["eff_WeigthValues"].ToString();
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return objEfficiencyCutExtruder;
        }

        public static bool getEfficiencyCutExtruderByCuttingStopCodsec(int cuttingStopCodsec)
        {
            bool isExist = false;
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_efficiencycutextrduer WHERE eff_CuttingStopCodsec = " + cuttingStopCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
                isExist = true;
            else
                isExist = false;

            GC.Collect();
            GC.WaitForPendingFinalizers();

            return isExist;
        }

        public static List<clsEfficiencyCutExtruder> getEfficiencySummary(string lotNumber)
        {
            List<clsEfficiencyCutExtruder> lstEfficiencyCutExtruder = new List<clsEfficiencyCutExtruder>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("spEfficiencyCutByExtruder 'Summary',0,0,'" + lotNumber + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");
            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstEfficiencyCutExtruder.Add(new clsEfficiencyCutExtruder());
                    lstEfficiencyCutExtruder[i].MainCoilValues = DS.Tables[0].Rows[i]["coilmainCoilCode"].ToString();
                    lstEfficiencyCutExtruder[i].consuption = Convert.ToDouble(DS.Tables[0].Rows[i]["consuption"]);
                    lstEfficiencyCutExtruder[i].ConsuptionObs = Convert.ToDouble(DS.Tables[0].Rows[i]["consuptionObs"]);
                    lstEfficiencyCutExtruder[i].lotnumber = DS.Tables[0].Rows[i]["lotnumber"].ToString();
                    lstEfficiencyCutExtruder[i].refile = Convert.ToDouble(DS.Tables[0].Rows[i]["refile"]);
                    lstEfficiencyCutExtruder[i].decrease = Convert.ToDouble(DS.Tables[0].Rows[i]["decrease"]);
                    lstEfficiencyCutExtruder[i].endroller = Convert.ToDouble(DS.Tables[0].Rows[i]["endroller"]);
                    lstEfficiencyCutExtruder[i].waste = Convert.ToDouble(DS.Tables[0].Rows[i]["isWaste"]);
                    lstEfficiencyCutExtruder[i].splice = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["isSplice"], DS.Tables[0].Rows[i]["isSplice"].GetType().FullName);
                    lstEfficiencyCutExtruder[i].totalDecrease = Convert.ToDouble(DS.Tables[0].Rows[i]["tDecrease"]);
                    lstEfficiencyCutExtruder[i].totalComsuptionDecrease = Convert.ToDouble(DS.Tables[0].Rows[i]["tConsuptionDecrease"]);
                    lstEfficiencyCutExtruder[i].mainCoilWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["MainCoilWeigth"]);
                    lstEfficiencyCutExtruder[i].efficiency = Convert.ToDouble(DS.Tables[0].Rows[i]["EfficiencyPercentaje"]);
                    lstEfficiencyCutExtruder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["EfficiencyCodsec"]);
                }
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
            return lstEfficiencyCutExtruder;
        }

        public static List<clsEfficiencyCutExtruder> getEfficiencySummaryPlus(string lotNumber)
        {
            List<clsEfficiencyCutExtruder> lstEfficiencyCutExtruder = new List<clsEfficiencyCutExtruder>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("spEfficiencyCutByExtruder 'SummaryPlus',0,0,'" + lotNumber + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");
            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstEfficiencyCutExtruder.Add(new clsEfficiencyCutExtruder());
                    lstEfficiencyCutExtruder[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["efficiencycodsec"]);
                    lstEfficiencyCutExtruder[i].MainCoilValues = DS.Tables[0].Rows[i]["mainCoilCode"].ToString();
                    lstEfficiencyCutExtruder[i].mainCoilWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mainCoilNetWeigth"]);
                    lstEfficiencyCutExtruder[i].consuption = Convert.ToDouble(DS.Tables[0].Rows[i]["consuptionPrmary"]);
                    lstEfficiencyCutExtruder[i].ConsuptionObs = Convert.ToDouble(DS.Tables[0].Rows[i]["consuptionObs"]);
                    lstEfficiencyCutExtruder[i].decrease = Convert.ToDouble(DS.Tables[0].Rows[i]["decrease"]);
                    lstEfficiencyCutExtruder[i].endroller = Convert.ToDouble(DS.Tables[0].Rows[i]["endroller"]);
                    lstEfficiencyCutExtruder[i].waste = Convert.ToDouble(DS.Tables[0].Rows[i]["waste"]);
                    lstEfficiencyCutExtruder[i].splice = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["issplice"], DS.Tables[0].Rows[i]["issplice"].GetType().FullName);
                    lstEfficiencyCutExtruder[i].refile = Convert.ToDouble(DS.Tables[0].Rows[i]["refile"]);
                    if (lstEfficiencyCutExtruder[i].splice)
                        lstEfficiencyCutExtruder[i].MainCoilList = clsGlobal.getIntListFromString(lstEfficiencyCutExtruder[i].MainCoilValues);
                    else
                        lstEfficiencyCutExtruder[i].MainCoilList = new List<int>();
                    lstEfficiencyCutExtruder[i].coilsValues = DS.Tables[0].Rows[i]["coilCode"].ToString();
                    lstEfficiencyCutExtruder[i].coilList = clsGlobal.getIntListFromString(lstEfficiencyCutExtruder[i].coilsValues);
                }
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
            return lstEfficiencyCutExtruder;
        }

        public static List<clsEfficiencyCutExtruder> getEfficiencySummaryShort(string lotNumber)
        {
            List<clsEfficiencyCutExtruder> lstEfficiencyCutExtruder = new List<clsEfficiencyCutExtruder>();
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("spEfficiencyCutByExtruder 'EfficiencyExtruder',0,0,'" + lotNumber + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");
            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstEfficiencyCutExtruder.Add(new clsEfficiencyCutExtruder());
                    lstEfficiencyCutExtruder[i].Bopp = DS.Tables[0].Rows[i]["bopp"].ToString();
                    lstEfficiencyCutExtruder[i].maincoilCount = Convert.ToInt32(DS.Tables[0].Rows[i]["countMainCoil"]);
                    lstEfficiencyCutExtruder[i].mainCoilWeigth = Convert.ToDouble(DS.Tables[0].Rows[i]["mainCoilNetwigth"]);
                    lstEfficiencyCutExtruder[i].coilCount = Convert.ToInt32(DS.Tables[0].Rows[i]["countCoil"]);
                    lstEfficiencyCutExtruder[i].coilNetweigth = Convert.ToDouble(DS.Tables[0].Rows[i]["coilNetWeigth"]);
                    lstEfficiencyCutExtruder[i].efficiency = Convert.ToDouble(DS.Tables[0].Rows[i]["efficiency"]);
                }
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
            return lstEfficiencyCutExtruder;
        }

        public void load(int codsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("spEfficiencyCutByExtruder 'GetEfficiencyByCodsec',0," + codsec.ToString() + ",'','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "'");

            if (DS.Tables[0].Rows.Count > 0)
            {
                this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["eff_codsec"]);
                this.fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["eff_fkStatus"]);
                this.fkCuttingOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["eff_fkCuttingOrder"]);
                this.cuttingstopcodsec = Convert.ToInt32(DS.Tables[0].Rows[0]["eff_CuttingStopCodsec"]);
                this.objCuttingOrder = new clsCuttingOrder(this.fkCuttingOrder);
                this.cuttingstop = DS.Tables[0].Rows[0]["eff_CuttingStop"].ToString();
                this.cuttingstopList = clsGlobal.getDoubleListFromString(this.cuttingstop);
                this.cuttingposition = Convert.ToInt32(DS.Tables[0].Rows[0]["eff_CuttingPosition"]);
                this.coilsValues = DS.Tables[0].Rows[0]["eff_Coils"].ToString();
                this.coilList = clsGlobal.getIntListFromString(this.coilsValues);
                this.refile = Convert.ToDouble(DS.Tables[0].Rows[0]["eff_Refile"]);
                this.decrease = Convert.ToDouble(DS.Tables[0].Rows[0]["eff_Decrease"]);
                this.endroller = Convert.ToDouble(DS.Tables[0].Rows[0]["eff_EndRoller"]);
                this.consuption = Convert.ToDouble(DS.Tables[0].Rows[0]["eff_Consuption"]);
                this.cuttingNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["eff_CuttingNumber"]);
                this.isReprocess = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["eff_isSecundaryCut"], DS.Tables[0].Rows[0]["eff_isSecundaryCut"].GetType().FullName);
                this.createdBy = Convert.ToInt32(DS.Tables[0].Rows[0]["eff_createdBy"]);
                this.userCreatorName = DS.Tables[0].Rows[0]["eff_userCreator"].ToString();
                this.modifiedBy = Convert.ToInt32(DS.Tables[0].Rows[0]["eff_modificateBy"]);
                this.userModificatorName = DS.Tables[0].Rows[0]["eff_userModificator"].ToString();
                this.createdDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["eff_createdDate"]);
                this.modifiedDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["eff_modifiedDate"]);
                this.statusName = DS.Tables[0].Rows[0]["eff_statusName"].ToString();
                this.notes = DS.Tables[0].Rows[0]["eff_Notes"].ToString();
                this.waste = Convert.ToDouble(DS.Tables[0].Rows[0]["eff_Waste"]);
                this.wasteCoil = DS.Tables[0].Rows[0]["eff_WasteCoil"].ToString();
                this.splice = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["eff_Splice"], DS.Tables[0].Rows[0]["eff_Splice"].GetType().FullName);
                this.spliceInit = Convert.ToDouble(DS.Tables[0].Rows[0]["eff_SpliceInit"]);
                this.spliceInitiCoil = DS.Tables[0].Rows[0]["eff_SpliceInitCoil"].ToString();
                this.spliceEnd = Convert.ToDouble(DS.Tables[0].Rows[0]["eff_SpliceEnd"]);
                this.spliceEndCoil = DS.Tables[0].Rows[0]["eff_SpliceEndCoil"].ToString();
                this.spliceThree = Convert.ToDouble(DS.Tables[0].Rows[0]["eff_SpliceThree"]);
                this.spliceCoilThree = DS.Tables[0].Rows[0]["eff_SpliceCoilThree"].ToString();
                this.reprocessCoil = DS.Tables[0].Rows[0]["eff_ReprocessCoil"].ToString();
                this.isLegth = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["eff_isLegth"], DS.Tables[0].Rows[0]["eff_isLegth"].GetType().FullName);
                this.legthValues = DS.Tables[0].Rows[0]["eff_LegthValues"].ToString();
                this.eff_isWeigth = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["eff_isWeigth"], DS.Tables[0].Rows[0]["eff_isWeigth"].GetType().FullName);
                this.weigthValues = DS.Tables[0].Rows[0]["eff_WeigthValues"].ToString();
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
