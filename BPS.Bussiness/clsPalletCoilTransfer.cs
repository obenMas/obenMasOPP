using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BPS.Bussiness
{
    public class clsPalletCoilTransfer
    {
        //attibutes
        private int pct_codsec;
        private int pct_fkStatus;
        private string pct_statusName;
        private int pct_fkOriginCellar;
        private string pct_originCellarName;
        private int pct_fkDestinationCellar;
        private string pct_destinationCellarName;
        private bool pct_isRequest;
        private DateTime pct_transferDate;
        private DateTime pct_receptionDate;
        private int pct_userSender;
        private string pct_sender;
        private int pct_userReceiver;
        private string pct_receiver;
        private List<clsPallet> pct_lstPallets;
        private List<clsCoil> pct_lstCoils;

        //properties
        public int codsec { get { return pct_codsec; } set { pct_codsec = value; } }

        public int fkStatus { get { return pct_fkStatus; } set { pct_fkStatus = value; } }

        public string statusName { get { return pct_statusName; } set { pct_statusName = value; } }

        public int fkOriginCellar { get { return pct_fkOriginCellar; } set { pct_fkOriginCellar = value; } }

        public string originCellarName { get { return pct_originCellarName; } set { pct_originCellarName = value; } }

        public int fkDestinationCellar { get { return pct_fkDestinationCellar; } set { pct_fkDestinationCellar = value; } }

        public string destinationCellarName { get { return pct_destinationCellarName; } set { pct_destinationCellarName = value; } }

        public bool isRequest { get { return pct_isRequest; } set { pct_isRequest = value; } }

        public DateTime transferDate { get { return pct_transferDate; } set { pct_transferDate = value; } }

        public DateTime receptionDate { get { return pct_receptionDate; } set { pct_receptionDate = value; } }

        public int userSender { get { return pct_userSender; } set { pct_userSender = value; } }

        public string sender { get { return pct_sender; } set { pct_sender = value; } }

        public int userReceiver { get { return pct_userReceiver; } set { pct_userReceiver = value; } }

        public string receiver { get { return pct_receiver; } set { pct_receiver = value; } }

        public List<clsPallet> lstPallets { get { return pct_lstPallets; } set { pct_lstPallets = value; } }

        public List<clsCoil> lstCoils { get { return pct_lstCoils; } set { pct_lstCoils = value; } }

        //constructor
        public clsPalletCoilTransfer()
        {
            codsec = 0;
            fkStatus = 0;
            statusName = "";
            fkOriginCellar = 0;
            originCellarName = "";
            fkDestinationCellar = 0;
            destinationCellarName = "";
            transferDate = DateTime.Now;
            receptionDate = DateTime.Now;
            isRequest = false;
            userSender = 0;
            sender = "";
            userReceiver = 0;
            receiver = "";
            lstCoils = new List<clsCoil>();
            lstPallets = new List<clsPallet>();
        }
        public clsPalletCoilTransfer(int palletCoilTransferCodsec)
        {
            this.load(palletCoilTransferCodsec);
        }
        //methods
        public void load(int transferCodsec)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwPalletCoilTransfer WHERE pct_codsec = " + transferCodsec.ToString());

            if (DS.Tables[0].Rows.Count > 0)
            {
                codsec = Convert.ToInt32(DS.Tables[0].Rows[0]["pct_codsec"]);
                fkStatus = Convert.ToInt32(DS.Tables[0].Rows[0]["pct_fkStatus"]);
                statusName = DS.Tables[0].Rows[0]["pct_statusName"].ToString();
                fkOriginCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["pct_fkOriginCellar"]);
                originCellarName = DS.Tables[0].Rows[0]["pct_originCellarName"].ToString();
                fkDestinationCellar = Convert.ToInt32(DS.Tables[0].Rows[0]["pct_fkDestinationCellar"]);
                destinationCellarName = DS.Tables[0].Rows[0]["pct_destinationCellarName"].ToString();
                isRequest = clsGlobal.convertToBoolean(DS.Tables[0].Rows[0]["pct_isRequest"], DS.Tables[0].Rows[0]["pct_isRequest"].GetType().FullName);
                transferDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["pct_transferDate"]);
                receptionDate = Convert.ToDateTime(DS.Tables[0].Rows[0]["pct_receptionDate"]);
                userSender = Convert.ToInt32(DS.Tables[0].Rows[0]["pct_userSender"]);
                sender = DS.Tables[0].Rows[0]["pct_sender"].ToString();
                userReceiver = Convert.ToInt32(DS.Tables[0].Rows[0]["pct_userReceiver"]);
                receiver = DS.Tables[0].Rows[0]["pct_receiver"].ToString();

                lstCoils = clsCoil.getListByTransfer(codsec);
                lstPallets = clsPallet.getListByTransfer(codsec);
            }
        }

        public bool save()
        {
            try
            {
                string queryString = "";

                if (this.codsec == 0)
                {
                    this.fkStatus = (clsStatus.getStatusByStatusGroupNameAndStatusName("Transferencia de pallets y bobinas", "Activa")).codsec;

                    queryString += "INSERT INTO bps_prod_palletcoiltransfer (pct_fkStatus,pct_fkOriginCellar, pct_fkDestinationCellar, pct_isRequest, pct_transferDate, pct_receptionDate, pct_userSender, pct_userReceiver )";
                    queryString += " VALUES (";
                    queryString += " " + this.fkStatus.ToString() + ", ";
                    queryString += " " + this.fkOriginCellar.ToString() + ", ";
                    queryString += " " + this.fkDestinationCellar.ToString() + ", ";
                    queryString += " " + this.isRequest.ToString() + ", ";
                    queryString += " '" + this.transferDate.ToString("dd/MM/yyyy HH:mm") + "', ";
                    queryString += " '" + this.receptionDate.ToString("dd/MM/yyyy HH:mm") + "', ";
                    queryString += " " + this.userSender.ToString() + ", ";
                    queryString += " " + this.userReceiver.ToString() + ")";
                }
                else
                {
                    queryString += "UPDATE bps_prod_palletcoiltransfer";
                    queryString += " SET ";
                    queryString += "pct_fkStatus = " + this.fkStatus.ToString() + ", ";
                    queryString += "pct_receptionDate = '" + this.receptionDate.ToString("dd/MM/yyyy HH:mm") + "', ";
                    queryString += "pct_userReceiver = " + this.userReceiver.ToString() + "";
                    queryString += " WHERE pct_codsec = " + this.codsec;
                }

                clsConnection.executeQuery(queryString);

                if (this.codsec == 0)
                {
                    this.codsec = clsPalletCoilTransfer.getLastSavedCodsec();
                }

                for (int i = 0; i < lstPallets.Count; i++)
                {
                    queryString = "";
                    queryString += "INSERT INTO bps_prod_palletcoiltransferdetail (pctd_fkPalletCoilTransfer, pctd_fkPallet)";
                    queryString += " VALUES (";
                    queryString += " " + this.codsec.ToString() + ", ";
                    queryString += " " + this.lstPallets[i].codsec + ")";

                    clsConnection.executeQuery(queryString);

                    if (this.isRequest == false)
                        clsPallet.waitingTransferTo(this.lstPallets[i].codsec, this.fkOriginCellar);
                }
                for (int i = 0; i < lstCoils.Count; i++)
                {
                    queryString = "";
                    queryString += "INSERT INTO bps_prod_palletcoiltransferdetail (pctd_fkPalletCoilTransfer, pctd_fkCoil)";
                    queryString += " VALUES (";
                    queryString += " " + this.codsec.ToString() + ", ";
                    queryString += " " + this.lstCoils[i].codsec + ")";

                    clsConnection.executeQuery(queryString);

                    clsCoil.waitingTransferCoilTo(this.lstCoils[i].codsec, this.fkOriginCellar);
                }

                return true;

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, "clsPalletCoilTransfer.save");
                return false;
            }
        }
        public static List<clsPalletCoilTransfer> getIncomingTransferList(int coilCellarCodsec, bool showInactive)
        {
            DataSet DS = new DataSet();
            List<clsPalletCoilTransfer> lstPalletCoilTransfer = new List<clsPalletCoilTransfer>();

            if (showInactive == true)
                DS = clsConnection.getDataSetResult("SELECT * FROM vwPalletCoilTransfer WHERE pct_fkDestinationCellar = " + coilCellarCodsec + " AND pct_isRequest = False ORDER BY pct_transferDate");
            else
                DS = clsConnection.getDataSetResult("SELECT * FROM vwPalletCoilTransfer WHERE pct_fkDestinationCellar = " + coilCellarCodsec + " AND pct_isRequest = False AND pct_fkStatus = 43 ORDER BY pct_transferDate");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstPalletCoilTransfer.Add(new clsPalletCoilTransfer());
                    lstPalletCoilTransfer[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pct_codsec"]);
                    lstPalletCoilTransfer[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["pct_fkStatus"]);
                    lstPalletCoilTransfer[i].statusName = DS.Tables[0].Rows[i]["pct_statusName"].ToString();
                    lstPalletCoilTransfer[i].fkOriginCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["pct_fkOriginCellar"]);
                    lstPalletCoilTransfer[i].originCellarName = DS.Tables[0].Rows[i]["pct_originCellarName"].ToString();
                    lstPalletCoilTransfer[i].fkDestinationCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["pct_fkDestinationCellar"]);
                    lstPalletCoilTransfer[i].destinationCellarName = DS.Tables[0].Rows[i]["pct_destinationCellarName"].ToString();
                    lstPalletCoilTransfer[i].isRequest = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pct_isRequest"], DS.Tables[0].Rows[i]["pct_isRequest"].GetType().FullName);
                    lstPalletCoilTransfer[i].transferDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["pct_transferDate"]);
                    lstPalletCoilTransfer[i].receptionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["pct_receptionDate"]);
                    lstPalletCoilTransfer[i].userSender = Convert.ToInt32(DS.Tables[0].Rows[i]["pct_userSender"]);
                    lstPalletCoilTransfer[i].sender = DS.Tables[0].Rows[i]["pct_sender"].ToString();
                    lstPalletCoilTransfer[i].userReceiver = Convert.ToInt32(DS.Tables[0].Rows[i]["pct_userReceiver"]);
                    lstPalletCoilTransfer[i].receiver = DS.Tables[0].Rows[i]["pct_receiver"].ToString();
                }
                
            }

            return lstPalletCoilTransfer;
        }
        public static List<clsPalletCoilTransfer> getOutgoingTransferList(int coilCellarCodsec, bool showInactive)
        {
            DataSet DS = new DataSet();
            List<clsPalletCoilTransfer> lstPalletCoilTransfer = new List<clsPalletCoilTransfer>();

            if (showInactive == true)
                DS = clsConnection.getDataSetResult("SELECT * FROM vwPalletCoilTransfer WHERE pct_fkOriginCellar = " + coilCellarCodsec + " AND pct_isRequest = False ORDER BY pct_transferDate");
            else
                DS = clsConnection.getDataSetResult("SELECT * FROM vwPalletCoilTransfer WHERE pct_fkOriginCellar = " + coilCellarCodsec + " AND pct_isRequest = False AND pct_fkStatus = 43 ORDER BY pct_transferDate");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstPalletCoilTransfer.Add(new clsPalletCoilTransfer());
                    lstPalletCoilTransfer[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pct_codsec"]);
                    lstPalletCoilTransfer[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["pct_fkStatus"]);
                    lstPalletCoilTransfer[i].statusName = DS.Tables[0].Rows[i]["pct_statusName"].ToString();
                    lstPalletCoilTransfer[i].fkOriginCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["pct_fkOriginCellar"]);
                    lstPalletCoilTransfer[i].originCellarName = DS.Tables[0].Rows[i]["pct_originCellarName"].ToString();
                    lstPalletCoilTransfer[i].fkDestinationCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["pct_fkDestinationCellar"]);
                    lstPalletCoilTransfer[i].destinationCellarName = DS.Tables[0].Rows[i]["pct_destinationCellarName"].ToString();
                    lstPalletCoilTransfer[i].isRequest = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pct_isRequest"], DS.Tables[0].Rows[i]["pct_isRequest"].GetType().FullName);
                    lstPalletCoilTransfer[i].transferDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["pct_transferDate"]);
                    lstPalletCoilTransfer[i].receptionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["pct_receptionDate"]);
                    lstPalletCoilTransfer[i].userSender = Convert.ToInt32(DS.Tables[0].Rows[i]["pct_userSender"]);
                    lstPalletCoilTransfer[i].sender = DS.Tables[0].Rows[i]["pct_sender"].ToString();
                    lstPalletCoilTransfer[i].userReceiver = Convert.ToInt32(DS.Tables[0].Rows[i]["pct_userReceiver"]);
                    lstPalletCoilTransfer[i].receiver = DS.Tables[0].Rows[i]["pct_receiver"].ToString();
                }

            }

            return lstPalletCoilTransfer;
        }
        public static List<clsPalletCoilTransfer> getIncomingRequest(int coilCellarCodsec, bool showInactive)
        {
            DataSet DS = new DataSet();
            List<clsPalletCoilTransfer> lstPalletCoilTransfer = new List<clsPalletCoilTransfer>();

            if (showInactive == true)
                DS = clsConnection.getDataSetResult("SELECT * FROM vwPalletCoilTransfer WHERE pct_fkOriginCellar = " + coilCellarCodsec + " AND pct_isRequest = True ORDER BY pct_transferDate");
            else
                DS = clsConnection.getDataSetResult("SELECT * FROM vwPalletCoilTransfer WHERE pct_fkOriginCellar = " + coilCellarCodsec + " AND pct_isRequest = True AND pct_fkStatus = 43 ORDER BY pct_transferDate");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstPalletCoilTransfer.Add(new clsPalletCoilTransfer());
                    lstPalletCoilTransfer[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pct_codsec"]);
                    lstPalletCoilTransfer[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["pct_fkStatus"]);
                    lstPalletCoilTransfer[i].statusName = DS.Tables[0].Rows[i]["pct_statusName"].ToString();
                    lstPalletCoilTransfer[i].fkOriginCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["pct_fkOriginCellar"]);
                    lstPalletCoilTransfer[i].originCellarName = DS.Tables[0].Rows[i]["pct_originCellarName"].ToString();
                    lstPalletCoilTransfer[i].fkDestinationCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["pct_fkDestinationCellar"]);
                    lstPalletCoilTransfer[i].destinationCellarName = DS.Tables[0].Rows[i]["pct_destinationCellarName"].ToString();
                    lstPalletCoilTransfer[i].isRequest = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pct_isRequest"], DS.Tables[0].Rows[i]["pct_isRequest"].GetType().FullName);
                    lstPalletCoilTransfer[i].transferDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["pct_transferDate"]);
                    lstPalletCoilTransfer[i].receptionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["pct_receptionDate"]);
                    lstPalletCoilTransfer[i].userSender = Convert.ToInt32(DS.Tables[0].Rows[i]["pct_userSender"]);
                    lstPalletCoilTransfer[i].sender = DS.Tables[0].Rows[i]["pct_sender"].ToString();
                    lstPalletCoilTransfer[i].userReceiver = Convert.ToInt32(DS.Tables[0].Rows[i]["pct_userReceiver"]);
                    lstPalletCoilTransfer[i].receiver = DS.Tables[0].Rows[i]["pct_receiver"].ToString();
                }

            }

            return lstPalletCoilTransfer;
        }
        public static List<clsPalletCoilTransfer> getOutgoingRequestList(int coilCellarCodsec, bool showInactive)
        {
            DataSet DS = new DataSet();
            List<clsPalletCoilTransfer> lstPalletCoilTransfer = new List<clsPalletCoilTransfer>();

            if (showInactive == true)
                DS = clsConnection.getDataSetResult("SELECT * FROM vwPalletCoilTransfer WHERE pct_fkDestinationCellar = " + coilCellarCodsec + " AND pct_isRequest = True ORDER BY pct_transferDate");
            else
                DS = clsConnection.getDataSetResult("SELECT * FROM vwPalletCoilTransfer WHERE pct_fkDestinationCellar = " + coilCellarCodsec + " AND pct_isRequest = True AND pct_fkStatus = 43 ORDER BY pct_transferDate");

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    lstPalletCoilTransfer.Add(new clsPalletCoilTransfer());
                    lstPalletCoilTransfer[i].codsec = Convert.ToInt32(DS.Tables[0].Rows[i]["pct_codsec"]);
                    lstPalletCoilTransfer[i].fkStatus = Convert.ToInt32(DS.Tables[0].Rows[i]["pct_fkStatus"]);
                    lstPalletCoilTransfer[i].statusName = DS.Tables[0].Rows[i]["pct_statusName"].ToString();
                    lstPalletCoilTransfer[i].fkOriginCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["pct_fkOriginCellar"]);
                    lstPalletCoilTransfer[i].originCellarName = DS.Tables[0].Rows[i]["pct_originCellarName"].ToString();
                    lstPalletCoilTransfer[i].fkDestinationCellar = Convert.ToInt32(DS.Tables[0].Rows[i]["pct_fkDestinationCellar"]);
                    lstPalletCoilTransfer[i].destinationCellarName = DS.Tables[0].Rows[i]["pct_destinationCellarName"].ToString();
                    lstPalletCoilTransfer[i].isRequest = clsGlobal.convertToBoolean(DS.Tables[0].Rows[i]["pct_isRequest"], DS.Tables[0].Rows[i]["pct_isRequest"].GetType().FullName);
                    lstPalletCoilTransfer[i].transferDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["pct_transferDate"]);
                    lstPalletCoilTransfer[i].receptionDate = Convert.ToDateTime(DS.Tables[0].Rows[i]["pct_receptionDate"]);
                    lstPalletCoilTransfer[i].userSender = Convert.ToInt32(DS.Tables[0].Rows[i]["pct_userSender"]);
                    lstPalletCoilTransfer[i].sender = DS.Tables[0].Rows[i]["pct_sender"].ToString();
                    lstPalletCoilTransfer[i].userReceiver = Convert.ToInt32(DS.Tables[0].Rows[i]["pct_userReceiver"]);
                    lstPalletCoilTransfer[i].receiver = DS.Tables[0].Rows[i]["pct_receiver"].ToString();
                }

            }

            return lstPalletCoilTransfer;
        }
        public static int getLastSavedCodsec()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT pct_codsec FROM bps_prod_palletCoilTransfer ORDER BY pct_codsec DESC LIMIT 1");

            return Convert.ToInt32(DS.Tables[0].Rows[0]["pct_codsec"]);
        }
        public void executeTransfer()
        {
            if (this.isRequest)
            {
                for (int i = 0; i < this.lstPallets.Count; i++)
                    clsPallet.executeRequestFrom(this.lstPallets[i].codsec, this.fkDestinationCellar);

                for (int i = 0; i < lstCoils.Count; i++)
                    clsCoil.transferCoilTo(this.lstCoils[i].codsec, this.fkDestinationCellar);

                string queryString = "";

                this.fkStatus = (clsStatus.getStatusByStatusGroupNameAndStatusName("Transferencia de pallets y bobinas", "Cerrada")).codsec;
                this.receptionDate = DateTime.Now;
                this.userReceiver = clsGlobal.LoggedUser.codsec;

                queryString += "UPDATE bps_prod_palletcoiltransfer";
                queryString += " SET ";
                queryString += "pct_fkStatus = " + this.fkStatus.ToString() + ", ";
                queryString += "pct_receptionDate = '" + this.receptionDate.ToString("dd/MM/yyyy HH:mm") + "', ";
                queryString += "pct_userSender = " + this.userSender.ToString() + "";
                queryString += " WHERE pct_codsec = " + this.codsec;

                clsConnection.executeQuery(queryString);
            }
            else
            {
                for (int i = 0; i < this.lstPallets.Count; i++)
                    clsPallet.executeTransferTo(this.lstPallets[i].codsec, this.fkDestinationCellar);

                for (int i = 0; i < lstCoils.Count; i++)
                    clsCoil.executeTransferTo(this.lstCoils[i].codsec, this.fkDestinationCellar);

                string queryString = "";

                this.fkStatus = (clsStatus.getStatusByStatusGroupNameAndStatusName("Transferencia de pallets y bobinas", "Cerrada")).codsec;
                this.receptionDate = DateTime.Now;
                this.userReceiver = clsGlobal.LoggedUser.codsec;

                queryString += "UPDATE bps_prod_palletcoiltransfer";
                queryString += " SET ";
                queryString += "pct_fkStatus = " + this.fkStatus.ToString() + ", ";
                queryString += "pct_receptionDate = '" + this.receptionDate.ToString("dd/MM/yyyy HH:mm") + "', ";
                queryString += "pct_userReceiver = " + this.userReceiver.ToString() + "";
                queryString += " WHERE pct_codsec = " + this.codsec;

                clsConnection.executeQuery(queryString);
            }
        }
        public void cancelTransfer()
        {
            if (this.isRequest)
            {

                string queryString = "";

                this.fkStatus = (clsStatus.getStatusByStatusGroupNameAndStatusName("Transferencia de pallets y bobinas", "Cancelada")).codsec;

                queryString += "UPDATE bps_prod_palletcoiltransfer";
                queryString += " SET ";
                queryString += "pct_fkStatus = " + this.fkStatus.ToString() + " ";
                queryString += " WHERE pct_codsec = " + this.codsec;

                clsConnection.executeQuery(queryString);
            }
            else
            {
                for (int i = 0; i < this.lstPallets.Count; i++)
                    clsPallet.cancelTransferTo(this.lstPallets[i].codsec, this.fkOriginCellar);

                for (int i = 0; i < lstCoils.Count; i++)
                    clsCoil.cancelTransferTo(this.lstCoils[i].codsec, this.fkOriginCellar);

                string queryString = "";

                this.fkStatus = (clsStatus.getStatusByStatusGroupNameAndStatusName("Transferencia de pallets y bobinas", "Cancelada")).codsec;

                queryString += "UPDATE bps_prod_palletcoiltransfer";
                queryString += " SET ";
                queryString += "pct_fkStatus = " + this.fkStatus.ToString() + " ";
                queryString += " WHERE pct_codsec = " + this.codsec;

                clsConnection.executeQuery(queryString);
            }

        }
    }
}