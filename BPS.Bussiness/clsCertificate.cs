using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BPS.Bussiness
{
    public class clsCertificate
    {
        #region Model
        //Atributes
        private int cer_codsec;
        private int cer_fkBopp;
        private string cer_ordernumber;
        private string cer_company;
        private string cer_lotnumber;
        private string cer_ExtruderDate;
        private string cer_rangeofmaincoil;
        private string cer_filmname;
        private string cer_width;
        private string cer_Bopp;
        private string cer_thicknessvalues;
        private string cer_unitvalues;
        private string cer_opacity;
        private string cer_tensioncidata;
        private string cer_sealct;
        private string cer_forcectdata;
        private string cer_sealcnt;
        private string cer_forcecntdata;
        private string cer_cofcntdata;
        private string cer_transmitancedata;
        private string cer_tensioncedata;
        private int cer_createdBy;
        private int cer_modifiedBy;
        private string cer_maincoil;
        private string cer_createdDate;
        private DateTime cer_createdDateDate;
        private string cer_notes;
        private string cer_head;
        private string cer_brightness;
        private string cer_opticdensity;

        //Properties

        public int codsec { get { return cer_codsec; } set { cer_codsec = value; } }

        public int fkBopp { get { return cer_fkBopp; } set { cer_fkBopp = value; } }

        public string Bopp { get { return cer_Bopp; } set { cer_Bopp = value; } }

        public string thicknessValues { get { return cer_thicknessvalues; } set { cer_thicknessvalues = value; } }

        public string unitValues { get { return cer_unitvalues; } set { cer_unitvalues = value; } }

        public string tensionciValues { get { return cer_tensioncidata; } set { cer_tensioncidata = value; } }

        public string sealctValues { get { return cer_sealct; } set { cer_sealct = value; } }

        public string OrderNumber { get { return cer_ordernumber; } set { cer_ordernumber = value; } }

        public string Company { get { return cer_company; } set { cer_company = value; } }

        public string LotNumber { get { return cer_lotnumber; } set { cer_lotnumber = value; } }

        public string ExtruderDate { get { return cer_ExtruderDate; } set { cer_ExtruderDate = value; } }

        public string superficialtensionValues { get { return cer_rangeofmaincoil; } set { cer_rangeofmaincoil = value; } }

        public string FilmName { get { return cer_filmname; } set { cer_filmname = value; } }

        public string Width { get { return cer_width; } set { cer_width = value; } }

        public string forcecntValues { get { return cer_forcecntdata; } set { cer_forcecntdata = value; } }

        public string cofdymanicValues { get { return cer_cofcntdata; } set { cer_cofcntdata = value; } }

        public string transmitanceValues { get { return cer_transmitancedata; } set { cer_transmitancedata = value; } }

        public string tensionceValues { get { return cer_tensioncedata; } set { cer_tensioncedata = value; } }

        public string forcectValues { get { return cer_forcectdata; } set { cer_forcectdata = value; } }

        public string sealcntValues { get { return cer_sealcnt; } set { cer_sealcnt = value; } }

        public string opacityValues { get { return cer_opacity; } set { cer_opacity = value; } }

        public int createdBy { get { return cer_createdBy; } set { cer_createdBy = value; } }

        public int modifiedBy { get { return cer_modifiedBy; } set { cer_modifiedBy = value; } }

        public string Maincoil { get { return cer_maincoil; } set { cer_maincoil = value; } }

        public string createdDate { get { return cer_createdDate; } set { cer_createdDate = value; } }

        public DateTime createdDateDate { get { return cer_createdDateDate; } set { cer_createdDateDate = value; } }

        public string notes { get { return cer_notes; } set { cer_notes = value; } }

        public string head { get { return cer_head; } set { cer_head = value; } }

        public string brightness { get { return cer_brightness; } set { cer_brightness = value; } }

        public string opticdensity { get { return cer_opticdensity; } set { cer_opticdensity = value; } }

        #endregion

        //Constructor

        public clsCertificate()
        {
            cer_codsec = 0;
            cer_fkBopp = 0;
            cer_ordernumber = string.Empty;
            cer_company = "";
            cer_lotnumber = "";
            cer_ExtruderDate = "";
            cer_rangeofmaincoil = "";
            cer_filmname = "";
            cer_width = "";
            cer_maincoil = "";


            cer_thicknessvalues = "Espesor;micras;0;0;0;(0 - 0)";
            cer_unitvalues = "Gramaje;g/m2;0;0;0;(0 - 0)";
            cer_opacity = "Haze;%;0;0;0;Max 0";
            cer_tensioncidata = "Tensión Superficial;dinas/cm;-----;-----;0;Min 0";
            cer_sealct = "Temperatura Inicial Sello (cara tratada);°C;-----;-----;0;Max 0";
            cer_forcectdata = "Fuerza de Sello (40 PSI, 0.5 seg. A 140 °C);N/25mm;-----;-----;0;Min 0";
            cer_sealcnt = "Temperatura Inicial Sello (cara no tratada);°C;-----;-----;0;Max 0";
            cer_forcecntdata = "Fuerza de Sello (40 PSI, 0.5 seg. A 140 °C);N/25mm;-----;-----;0;Min 0";
            cer_cofcntdata = "Cof Dinámico (cara no tratada);adim;-----;-----;0;Max 0";
            cer_transmitancedata = " Transmitancia;%;0;0;0;Max 0";
            cer_tensioncedata = "Tensión Superficial;dinas/cm;-----;-----;0;Min 0";
            cer_createdBy = 0;
            cer_modifiedBy = 0;
            cer_createdDate = "";
            cer_createdDateDate = DateTime.Now;
            cer_notes = "";
            cer_head = "";
            cer_brightness = "Brillo 45°;%;0;Min 0";
            cer_opticdensity = "Densidad Optica,MACBETH,%,0,Min 0";

        }

        public clsCertificate(int codsec)
        {
            Load(codsec);
        }

        public clsCertificate(string data)
        {
            Load(data);
        }

        public void Load(int codsec)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL (" + codsec.ToString() + ");");

            if (DS.Tables[0].Rows.Count > 0)
            {
                //this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["cer_codsec"]);
                //this.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["cer_fkBopp"]);
                //this.Bopp = DS.Tables[0].Rows[0]["cer_Bopp"].ToString();
                ////this.thicknessValues = DS.Tables[0].Rows[0]["cer"].ToString();



                ////this.OrderNumberList = clsGlobal.getDoubleListFromString(this.Company);
                //this.LotNumber = DS.Tables[0].Rows[0]["acp_unitweightdata"].ToString();
                //this.unitweightList = clsGlobal.getDoubleListFromString(this.LotNumber);
                //this.ExtruderDate = DS.Tables[0].Rows[0]["acp_opacitydata"].ToString();
                //this.opacityList = clsGlobal.getDoubleListFromString(this.ExtruderDate);
                //this.superficialtensionValues = DS.Tables[0].Rows[0]["acp_superficialtensiondata"].ToString();
                //this.superficialtensionList = clsGlobal.getIntListFromString(this.superficialtensionValues);
                //this.FilmName = DS.Tables[0].Rows[0]["acp_sealctdata"].ToString();
                //this.sealctList = clsGlobal.getIntListFromString(this.FilmName);
                //this.Width = DS.Tables[0].Rows[0]["acp_forcectdata"].ToString();
                //this.forcectList = clsGlobal.getDoubleListFromString(this.Width);
                //this.thicknessValues = DS.Tables[0].Rows[0]["acp_sealcntdata"].ToString();
                //this.sealcntList = clsGlobal.getIntListFromString(this.thicknessValues);
                //this.forcecntValues = DS.Tables[0].Rows[0]["acp_forcecntdata"].ToString();
                //this.forcecntList = clsGlobal.getDoubleListFromString(this.forcecntValues);
                //this.cofdymanicValues = DS.Tables[0].Rows[0]["acp_cofdymanicdata"].ToString();
                //this.cofdymanicList = clsGlobal.getDoubleListFromString(this.cofdymanicValues);
                //this.tratedValues = DS.Tables[0].Rows[0]["acp_trateddata"].ToString();
                //this.tratedList = clsGlobal.getIntListFromString(this.tratedValues);
                //this.tensionciValues = DS.Tables[0].Rows[0]["acp_tensioncidata"].ToString();
                //this.tensionciList = clsGlobal.getDoubleListFromString(this.tensionciValues);
                //this.tensionceValues = DS.Tables[0].Rows[0]["acp_tensioncedata"].ToString();
                //this.tensionceList = clsGlobal.getDoubleListFromString(this.tensionceValues);
            }
        }

        public void Load(string data)
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spCertificateHead('List','" + data + "','0','0','0');");

            if (DS.Tables[0].Rows.Count > 0)
            {
                ////this.codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["acp_codsec"]);
                ////this.fkBopp = Convert.ToInt32(DS.Tables[0].Rows[0]["acp_fkBopp"]);
                //this.OrderNumber = DS.Tables[0].Rows[0]["cer_ordernumber"].ToString();
                ////this.Company = DS.Tables[0].Rows[0]["acp_thicknessdata"].ToString();
                ////this.OrderNumberList = clsGlobal.getDoubleListFromString(this.Company);
                ////this.LotNumber = DS.Tables[0].Rows[0]["acp_unitweightdata"].ToString();
                ////this.unitweightList = clsGlobal.getDoubleListFromString(this.LotNumber);
                ////this.ExtruderDate = DS.Tables[0].Rows[0]["acp_opacitydata"].ToString();
                ////this.opacityList = clsGlobal.getDoubleListFromString(this.ExtruderDate);
                ////this.superficialtensionValues = DS.Tables[0].Rows[0]["acp_superficialtensiondata"].ToString();
                ////this.superficialtensionList = clsGlobal.getIntListFromString(this.superficialtensionValues);
                ////this.FilmName = DS.Tables[0].Rows[0]["acp_sealctdata"].ToString();
                ////this.sealctList = clsGlobal.getIntListFromString(this.FilmName);
                //this.Width = DS.Tables[0].Rows[0]["acp_forcectdata"].ToString();
                //this.forcectList = clsGlobal.getDoubleListFromString(this.Width);
                //this.thicknessValues = DS.Tables[0].Rows[0]["acp_sealcntdata"].ToString();
                //this.sealcntList = clsGlobal.getIntListFromString(this.thicknessValues);
                //this.forcecntValues = DS.Tables[0].Rows[0]["acp_forcecntdata"].ToString();
                //this.forcecntList = clsGlobal.getDoubleListFromString(this.forcecntValues);
                //this.cofdymanicValues = DS.Tables[0].Rows[0]["acp_cofdymanicdata"].ToString();
                //this.cofdymanicList = clsGlobal.getDoubleListFromString(this.cofdymanicValues);
                //this.tratedValues = DS.Tables[0].Rows[0]["acp_trateddata"].ToString();
                //this.tratedList = clsGlobal.getIntListFromString(this.tratedValues);
                //this.tensionciValues = DS.Tables[0].Rows[0]["acp_tensioncidata"].ToString();
                //this.tensionciList = clsGlobal.getDoubleListFromString(this.tensionciValues);
                //this.tensionceValues = DS.Tables[0].Rows[0]["acp_tensioncedata"].ToString();
                //this.tensionceList = clsGlobal.getDoubleListFromString(this.tensionceValues);
            }
        }

        public bool save()
        {
            string queryString = "";
            try
            {
                if (this.codsec == 0)
                {
                    queryString += "INSERT INTO bps_prod_certificates (cer_fkBopp, cer_Bopp, cer_thicknessvalues, cer_unitvalues, " +
                    "cer_opacity, cer_tensionci, cer_sealct, cer_forcect, cer_sealcnt, cer_forcecnt, cer_cofcnt, cer_transmitance, cer_tensionce, cer_createdby, cer_modifiedby," +
                    "cer_lotnumber,cer_customer,cer_createdDate,cer_order,cer_width,cer_boppname,cer_maincoil,cer_extruder, cer_notes, cer_head, cer_brightness,cer_opticdensity) ";
                    queryString += " VALUES (";
                    queryString += "" + this.fkBopp.ToString() + ",";
                    queryString += "'" + this.Bopp.ToString() + "',";
                    queryString += "'" + this.thicknessValues.ToString() + "',";
                    queryString += "'" + this.unitValues.ToString() + "',";
                    queryString += "'" + this.opacityValues.ToString() + "',";
                    queryString += "'" + this.tensionciValues.ToString() + "',";
                    queryString += "'" + this.sealctValues.ToString() + "',";
                    queryString += "'" + this.forcectValues.ToString() + "',";
                    queryString += "'" + this.sealcntValues.ToString() + "',";
                    queryString += "'" + this.forcecntValues.ToString() + "',";
                    queryString += "'" + this.cofdymanicValues.ToString() + "',";
                    queryString += "'" + this.transmitanceValues.ToString() + "',";
                    queryString += "'" + this.tensionceValues.ToString() + "',";
                    queryString += "" + clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += "" + clsGlobal.LoggedUser.codsec.ToString() + ",";
                    queryString += "'" + this.LotNumber.ToString() + "',";
                    queryString += "'" + this.Company.ToString() + "',";
                    queryString += "'" + this.createdDate.ToString() + "',";
                    queryString += "'" + this.OrderNumber.ToString() + "',";
                    queryString += "'" + this.Width.ToString() + "',";
                    queryString += "'" + this.FilmName.ToString() + "',";
                    queryString += "'" + this.Maincoil.ToString() + "',";
                    queryString += "'" + this.ExtruderDate.ToString() + "',";
                    queryString += "'" + this.notes.ToString() + "',";
                    queryString += "'" + this.head.ToString() + "',";
                    queryString += "'" + this.brightness.ToString() + "',";
                    queryString += "'" + this.opticdensity.ToString() + "')";
                        
                }
                else
                {
                    //queryString += "UPDATE bps_prod_aceptationrange ";
                    //queryString += " SET ";
                    //queryString += "acp_fkBopp =" + this.fkBopp.ToString() + ",";
                    //queryString += "acp_thicknessdata = '" + this.Company.ToString() + "',";
                    //queryString += "acp_unitweightdata = '" + this.LotNumber.ToString() + "',";
                    //queryString += "acp_opacitydata ='" + this.ExtruderDate.ToString() + "',";
                    //queryString += "acp_superficialtensiondata ='" + this.tensionciValues.ToString() + "',";
                    //queryString += "acp_sealctdata ='" + this.FilmName.ToString() + "',";
                    //queryString += "acp_forcectdata ='" + this.Width.ToString() + "',";
                    //queryString += "acp_sealcntdata ='" + this.sealcntValues.ToString() + "',";
                    //queryString += "acp_forcecntdata = '" + this.forcecntValues.ToString() + "',";
                    //queryString += "acp_cofdymanicdata ='" + this.cofdymanicValues.ToString() + "',";
                    //queryString += "acp_trateddata ='" + this.tratedValues.ToString() + "',";
                    //queryString += "acp_tensioncidata = '" + this.tensionciValues.ToString() + "',";
                    //queryString += "acp_tensioncedata ='" + this.tensionceValues.ToString() + "'";
                    //queryString += " WHERE acp_codsec = " + this.codsec.ToString() + "";
                }
                return clsConnection.executeQuery(queryString);
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCertificate.save");
                return false;
            }
        }

        public static bool toDelete(int codsec)
        {
            try
            {
                string queryString = "";
                queryString += "DELETE FROM bps_prod_certificates WHERE cer_codsec = " + codsec.ToString() + ";";
                if (clsConnection.executeQuery(queryString))
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsCertificates.delete");
                return false;
            }
        }

        public static List<clsCertificate> getListByPreShippingNumber(string data)
        {
            List<clsCertificate> lstCertificate = new List<clsCertificate>();

            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("spCertificateHead 'List','" + data + "','0','0','0'");

            if (DS.Tables.Count>0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCertificate.Add(new clsCertificate());
                    lstCertificate[i].OrderNumber = DS.Tables[0].Rows[i]["cer_ordernumber"].ToString();
                    lstCertificate[i].Company = DS.Tables[0].Rows[i]["cer_company"].ToString();
                    lstCertificate[i].LotNumber = DS.Tables[0].Rows[i]["cer_lotnumber"].ToString();
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return lstCertificate;
        }

        public static List<clsCertificate> getListByNewPreShippingNumber(string data)
        {
            List<clsCertificate> lstCertificate = new List<clsCertificate>();

            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("spNewPDCertificateHead '" + data +"'");

            if (DS.Tables.Count>0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCertificate.Add(new clsCertificate());
                    lstCertificate[i].OrderNumber = DS.Tables[0].Rows[i]["cer_ordernumber"].ToString();
                    lstCertificate[i].Company = DS.Tables[0].Rows[i]["cer_company"].ToString();
                    lstCertificate[i].LotNumber = DS.Tables[0].Rows[i]["cer_lotnumber"].ToString();
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return lstCertificate;
        }

        public static List<clsCertificate> getPopulateList()
        {
            List<clsCertificate> lstCertificate = new List<clsCertificate>();

            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spCertificateList()");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstCertificate.Add(new clsCertificate());
                    lstCertificate[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["cer_codsec"]);
                    lstCertificate[i].Bopp = DS.Tables[0].Rows[i]["cer_Bopp"].ToString();
                    lstCertificate[i].LotNumber = DS.Tables[0].Rows[i]["cer_lotnumber"].ToString();
                    lstCertificate[i].Company = DS.Tables[0].Rows[i]["cer_customer"].ToString();
                    lstCertificate[i].createdDateDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["cer_createdDate"]);
                    lstCertificate[i].OrderNumber = DS.Tables[0].Rows[i]["cer_order"].ToString();

                    if (string.IsNullOrEmpty(DS.Tables[0].Rows[i]["cer_fkBoppL"].ToString()))
                        lstCertificate[i].FilmName = "";
                    else
                        lstCertificate[i].FilmName = DS.Tables[0].Rows[i]["cer_fkBoppL"].ToString();
                }
            }

            GC.Collect();
            GC.WaitForPendingFinalizers();
            DS.Dispose();

            return lstCertificate;
        }

        public static string getExtruderDateByLotNumber(string lotnumber)
        {
            DataSet DS = new DataSet();
            DataSet DSM = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spCertificateHead('LotNumber-Date','0','" + (lotnumber + "0") + "','0','0');");
            if (DS.Tables[0].Rows.Count > 0)
                return DS.Tables[0].Rows[0]["cer_ExtruderDate"].ToString();
            else
            {
                DSM = clsConnection.getDataSetResult("CALL spCertificateHead('LotNumber-Date-Metal','0','" + lotnumber + "','0','0');");
                if (DSM.Tables[0].Rows.Count > 0)
                    return DSM.Tables[0].Rows[0]["cer_ExtruderDate"].ToString();
                else
                    return "-----";
            }
        }

        public static List<string> getRangeOfMainCoilByLotNumber(string lotnumber)
        {
            DataSet DS = new DataSet();
            DataSet DSM = new DataSet();
            List<string> lstString = new List<string>();

            DS = clsConnection.getDataSetResult("CALL spCertificateHead('LotNumber','0','0','" + (lotnumber + "0") + "','0');");

            if (DS.Tables[0].Rows.Count > 0)
            {
                lstString.Add(DS.Tables[0].Rows[0]["cer_rangeofmaincoil"].ToString());
                lstString.Add(DS.Tables[0].Rows[0]["cer_filmname"].ToString());
                lstString.Add(DS.Tables[0].Rows[0]["cer_filmdescription"].ToString());
            }
            else
            {
                DSM = clsConnection.getDataSetResult("CALL spCertificateHead('LotNumber-Metal','0','0','" + lotnumber + "','0');");
                if (DSM.Tables[0].Rows.Count > 0)
                {
                    lstString.Add(DSM.Tables[0].Rows[0]["cer_rangeofmaincoil"].ToString());
                    lstString.Add(DSM.Tables[0].Rows[0]["cer_filmname"].ToString());
                    lstString.Add(DSM.Tables[0].Rows[0]["cer_filmdescription"].ToString());
                }
                else
                {
                    lstString.Add("-----");
                    lstString.Add("-----");
                    lstString.Add("-----");
                }
            }

            DS.Dispose();

            return lstString;
        }

        public static string getWidthByOrderNumber(string order, string preshipping)
        {
            string resutl = string.Empty;
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spCertificateHead('Order','" + preshipping + "','0','0','" + order + "');");
            if (DS.Tables.Count>0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (i == (DS.Tables[0].Rows.Count - 1))
                        resutl += DS.Tables[0].Rows[i]["cer_width"].ToString();
                    else
                        resutl += DS.Tables[0].Rows[i]["cer_width"].ToString() + " , ";
                }
                return resutl;
            }
            else
                return "-----";
        }

        public static string getWidthByOrderNumberNewPD(string order, string preshipping)
        {
            string resutl = string.Empty;
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spNewPDCertificateHeadWidth('" + preshipping + "');");
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    if (i == (DS.Tables[0].Rows.Count - 1))
                        resutl += DS.Tables[0].Rows[i]["cer_width"].ToString();
                    else
                        resutl += DS.Tables[0].Rows[i]["cer_width"].ToString() + " , ";
                }
                return resutl;
            }
            else
                return "-----";
        }


        //GRAMAJE
        public static List<double> getUniWeightByLotNumber(string lotnumber)
        {
            string resutl = string.Empty;
            List<double> lstDoubleList = new List<double>();
            DataSet DS = new DataSet();
            DataSet DSM = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spCertificateUnit('" + (lotnumber + "0") + "',0);");
            if (DS.Tables[0].Rows.Count > 0)
                resutl = DS.Tables[0].Rows[0]["unit"].ToString();
            else
                resutl = "0;0;0";

            lstDoubleList = clsGlobal.getDoubleListFromString(resutl);

            return lstDoubleList;
        }

        //BRILLO
        public static List<double> getBrightnessByLotNumber(string lotnumber)
        {
            string result = string.Empty;
            List<double> lstDoubleList = new List<double>();
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spCertificateBrightness('" + lotnumber.ToString() + "0',0);");
            if (DS.Tables[0].Rows.Count > 0)
                result = DS.Tables[0].Rows[0]["brightness"].ToString();
            else
                result = "0;0";

            lstDoubleList = clsGlobal.getDoubleListFromString(result);

            return lstDoubleList;
        }

        //OPACIDAD o BRILLO
        public static double getOpacityOrTransmitanceByLotNumber(string lotnumber, string operatore)
        {
            string resutl = string.Empty;
            double opacity = 0;
            DataSet DSM = new DataSet();


            DSM = clsConnection.getDataSetResult("CALL spOpacityByLotNumber('" + (lotnumber + "0'") + ");");
            if (DSM.Tables[0].Rows.Count > 0)
            {
                List<double> list = new List<double>();
                List<double> finalList = new List<double>();

                for (int i = 0; i < DSM.Tables[0].Rows.Count; i++)
                {
                    list = clsGlobal.getDoubleListFromString(DSM.Tables[0].Rows[i]["mcq_opacityTrasmittanceValues"].ToString());
                    for (int j = 0; j < list.Count; j++)
                    {
                        finalList.Add(list[j]);
                    }
                        
                }
                opacity = finalList.Average();
            }

            return opacity;
       
        }

        //Promedio Espesor
        public static double getThicknessAverageByLotNumber(string lotnumber)
        {
            double result = 0;
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spThicknessAveragebylot('" + lotnumber + "');");
            if (DS.Tables[0].Rows.Count > 0)
                result = Convert.ToDouble(DS.Tables[0].Rows[0]["tav"]);
            return result;
        }

        //Tension sup
        public static List<double> getTensionByLotNumber(string lotnumber, string operatore)
        {
            string resutl = string.Empty;
            List<double> lstDoubleList = new List<double>();
            DataSet DS = new DataSet();
            DataSet DSM = new DataSet();

            if (operatore == "TensionCI")
            {
                DS = clsConnection.getDataSetResult("CALL spCertificateTension('" + (lotnumber + "0") + "','" + operatore + "',0);");
                if (DS.Tables[0].Rows.Count > 0)
                    resutl = DS.Tables[0].Rows[0]["tensionci"].ToString();
                else
                    resutl = "0;0;0";

                lstDoubleList = clsGlobal.getDoubleListFromString(resutl);

                DSM = clsConnection.getDataSetResult("CALL spTensionByLotNumber('" + (lotnumber + "0'") + ");");
                if (DSM.Tables[0].Rows.Count > 0)
                {
                    List<double> list = new List<double>();
                    List<double> finalList = new List<double>();

                    for(int i=0; i<DSM.Tables[0].Rows.Count;i++)
                    {
                        list = clsGlobal.getDoubleListFromString(DSM.Tables[0].Rows[i]["mcq_surfaceTensionValues"].ToString());
                        finalList.Add(list[0]);
                    }
                    lstDoubleList[1]=finalList.Average();
                }

                return lstDoubleList;
            }
            else
            {
                DS = clsConnection.getDataSetResult("CALL spCertificateTension('" + (lotnumber + "0") + "','" + operatore + "',0);");
                if (DS.Tables[0].Rows.Count > 0)
                    resutl = DS.Tables[0].Rows[0]["tensionce"].ToString();
                else
                    resutl = "0;0;0";

                lstDoubleList = clsGlobal.getDoubleListFromString(resutl);

                DSM = clsConnection.getDataSetResult("CALL spTensionByLotNumber('" + (lotnumber + "0'") + ");");
                if (DSM.Tables[0].Rows.Count > 0)
                {
                    List<double> list = new List<double>();
                    List<double> finalList = new List<double>();

                    for (int i = 0; i < DSM.Tables[0].Rows.Count; i++)
                    {
                        list = clsGlobal.getDoubleListFromString(DSM.Tables[0].Rows[i]["mcq_surfaceTensionValues"].ToString());
                        finalList.Add(list[1]);
                    }
                    lstDoubleList[1] = finalList.Average();
                }

                return lstDoubleList;
            }
        }

        //Sello
        public static List<double> getSealByLotNumber(string lotnumber, string operatore)
        {
            string resutl = string.Empty;
            List<double> lstDoubleList = new List<double>();
            DataSet DS = new DataSet();
            DataSet DSM = new DataSet();
            if (operatore == "SealCI")
            {
                DS = clsConnection.getDataSetResult("CALL spCertificateSeal('" + (lotnumber + "0") + "','" + operatore + "',0);");
                if (DS.Tables[0].Rows.Count > 0)
                    resutl = DS.Tables[0].Rows[0]["sealct"].ToString();
                else
                    resutl = "0;0;0";

                lstDoubleList = clsGlobal.getDoubleListFromString(resutl);

                return lstDoubleList;
            }
            else
            {
                DS = clsConnection.getDataSetResult("CALL spCertificateSeal('" + (lotnumber + "0") + "','" + operatore + "',0);");
                if (DS.Tables[0].Rows.Count > 0)
                    resutl = DS.Tables[0].Rows[0]["sealcnt"].ToString();
                else
                    resutl = "0;0;0";

                lstDoubleList = clsGlobal.getDoubleListFromString(resutl);

                return lstDoubleList;
            }
        }

        //Fuerza
        public static List<double> getForceByLotNumber(string lotnumber, string operatore)
        {
            string resutl = string.Empty;
            List<double> lstDoubleList = new List<double>();
            DataSet DS = new DataSet();
            DataSet DSM = new DataSet();
            if (operatore == "ForceCT")
            {
                DS = clsConnection.getDataSetResult("CALL spCertificateForce('" + (lotnumber + "0") + "','" + operatore + "',0);");
                if (DS.Tables[0].Rows.Count > 0)
                    resutl = DS.Tables[0].Rows[0]["forcect"].ToString();
                else
                    resutl = "0;0;0";

                lstDoubleList = clsGlobal.getDoubleListFromString(resutl);

                return lstDoubleList;
            }
            else
            {
                DS = clsConnection.getDataSetResult("CALL spCertificateForce('" + (lotnumber + "0") + "','" + operatore + "',0);");
                if (DS.Tables[0].Rows.Count > 0)
                    resutl = DS.Tables[0].Rows[0]["forcecnt"].ToString();
                else
                    resutl = "0;0;0";

                lstDoubleList = clsGlobal.getDoubleListFromString(resutl);

                return lstDoubleList;
            }
        }

        //COF
        public static List<double> getCofByLotNumber(string lotnumber, string operatore)
        {
            string resutl = string.Empty;
            List<double> lstDoubleList = new List<double>();
            DataSet DS = new DataSet();
            DataSet DSM = new DataSet();
            if (operatore == "CofCNT")
            {
                DS = clsConnection.getDataSetResult("CALL spCertificateCof('" + (lotnumber + "0") + "','" + operatore + "',0);");
                if (DS.Tables[0].Rows.Count > 0)
                    resutl = DS.Tables[0].Rows[0]["cofcnt"].ToString();
                else
                    resutl = "0;0;0";

                lstDoubleList = clsGlobal.getDoubleListFromString(resutl);

                return lstDoubleList;
            }
            else
            {
                DS = clsConnection.getDataSetResult("CALL spCertificateCof('" + (lotnumber + "0") + "','" + operatore + "',0);");
                if (DS.Tables[0].Rows.Count > 0)
                    resutl = DS.Tables[0].Rows[0]["cofct"].ToString();
                else

                    resutl = "0;0;0";

                lstDoubleList = clsGlobal.getDoubleListFromString(resutl);

                return lstDoubleList;
            }
        }

        public static int getLastCodsec()
        {
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("SELECT MAX(cer_codsec) as codsec FROM bps_prod_certificates");
            if (DS.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(DS.Tables[0].Rows[0]["codsec"].ToString());
            else
                return 0;
        }

        //Promedio Espesor Metales
        public static double getThicknessAverageByLotNumberMetal(string lotnumber)
        {
            double result = 0;
            DataSet DS = new DataSet();
            DS = clsConnection.getDataSetResult("CALL spThicknessAveragebylotMetal('" + lotnumber + "');");
            if (DS.Tables[0].Rows.Count > 0)
                result = Convert.ToDouble(DS.Tables[0].Rows[0]["tav"]);
            return result;
        }

        //Valores Metales
        public static List<double> getMetalDataByLotNumber(string lotnumber, string operation)
        {
            string resutl = string.Empty;
            List<double> lstDoubleList = new List<double>();
            DataSet DS = new DataSet();
            DataSet DSM = new DataSet();

            if (operation == "Unit")
            {
                DSM = clsConnection.getDataSetResult("spCertificateMetal 'Unit','" + lotnumber + "',0");
                if (DSM.Tables[0].Rows.Count > 0)
                    resutl = DSM.Tables[0].Rows[0]["unit"].ToString();
                else
                    resutl = "0;0;0";
            }
            else if (operation == "Density")
            {
                DSM = clsConnection.getDataSetResult("spCertificateMetal 'Density','" + lotnumber + "',0");
                if (DSM.Tables[0].Rows.Count > 0)
                    resutl = DSM.Tables[0].Rows[0]["unit"].ToString();
                else
                    resutl = "0;0;0";
            }
            else if (operation == "TrataCI")
            {
                DSM = clsConnection.getDataSetResult("spCertificateMetal 'TrataCI','" + lotnumber + "',0");
                if (DSM.Tables[0].Rows.Count > 0)
                    resutl = DSM.Tables[0].Rows[0]["trataci"].ToString();
                else
                    resutl = "0;0;0";
            }
            else if (operation == "TrataCE")
            {
                DSM = clsConnection.getDataSetResult("spCertificateMetal 'TrataCE','" + lotnumber + "',0");
                if (DSM.Tables[0].Rows.Count > 0)
                    resutl = DSM.Tables[0].Rows[0]["tratace"].ToString();
                else
                    resutl = "0;0;0";
            }
            else if (operation == "Seal")
            {
                DSM = clsConnection.getDataSetResult("spCertificateMetal 'Seal','" + lotnumber + "',0");
                if (DSM.Tables[0].Rows.Count > 0)
                    resutl = DSM.Tables[0].Rows[0]["seal"].ToString();
                else
                    resutl = "0;0;0";
            }
            else if (operation == "Cof")
            {
                DSM = clsConnection.getDataSetResult("spCertificateMetal 'Cof','" + lotnumber + "',0");
                if (DSM.Tables[0].Rows.Count > 0)
                    resutl = DSM.Tables[0].Rows[0]["cof"].ToString();
                else
                    resutl = "0;0;0";
            }

            lstDoubleList = clsGlobal.getDoubleListFromString(resutl);

            return lstDoubleList;
        }
    }
}
