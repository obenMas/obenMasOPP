using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;

namespace BPS.Bussiness
{
    public class siigoMovements : IComparable<siigoMovements>
    {
        public string receiptType { get; set; }            //01   001  001	TIPO DE COMPROBANTE:  1 posicin alfanum
        public string completeReceiptType { get; set; }    //04   ---  ---  PARA ORDENADO
        public string receiptCode { get; set; }            //03   002  004	CDIGO COMPROBANTE:  3 posiciones numricas
        public string receiptNumber { get; set; }          //11   005  015	NMERO DE DOCUMENTO:  11 posiciones numricas
        public string receiptSequence { get; set; }        //05   016  020	SECUENCIA:  5 posiciones numricas.  Mximo hasta 250
        public string receiptNIT { get; set; }             //13   021  033	NIT:  13 posiciones numricas
        public string subsidiary { get; set; }             //03   034  036	SUCURSAL:  3 posiciones numricas
        public string account { get; set; }                //10   037  046	CUENTA CONTABLE:  10 posiciones numricas
        public string productCode { get; set; }            //13   047  059	CDIGO DE PRODUCTO:  13 posiciones numricas
        public string documentDate { get; set; }           //08   060  067	FECHA DEL DOCUMENTO:  8 posiciones numricas (AAAAMMDD)
        public string costCenter { get; set; }             //04   068  071	CENTRO DE COSTO:  4 posiciones numricas
        public string costSubCenter { get; set; }          //03   072  074	SUBCENTRO DE COSTO:  3 posiciones numricas
        public string description { get; set; }            //50   075  124	DESCRIPCIN DEL MOVIMIENTO:  50 posiciones alfanumricas, para comentario o detalle del movimiento
        public string creditDebit { get; set; }            //01   125  125	DBITO O CRDITO:  1 posicin alfanumrica.  Valor D  C
        public string value { get; set; }                  //15   126  140	VALOR DEL MOVIMIENTO:  15 posiciones numricas, 13 enteros, 2 decimales
        public string retentionBase { get; set; }          //15   141  155	BASE DE RETENCIN:  15 posiciones numricas, 13 enteros, 2 decimales
        public string sellerCode { get; set; }             //04   156  159	CDIGO DEL VENDEDOR:  4 posiciones numricas
        public string cityCode { get; set; }               //04   160  163	CDIGO DE LA CIUDAD:  4 posiciones numricas
        public string zoneCode { get; set; }               //03   164  166	CDIGO DE LA ZONA:  3 posiciones numricas
        public string cellarCode { get; set; }             //04   167  170	CDIGO DE LA BODEGA:  4 posiciones numricas
        public string locationCode { get; set; }           //03   171  173	CDIGO DE LA UBICACIN:  3 posiciones numricas
        public string quantity { get; set; }               //15   174  188	CANTIDAD:  15 posiciones numricas, 10 enteros, 5 decimales
        public string crossDocumentType { get; set; }      //01   189  189	TIPO DE DOCUMENTO CRUCE:  1 posicin alfanumrica 
        public string crossDocumentCode { get; set; }      //03   190  192	CDIGO COMPROBANTE CRUCE:  3 posiciones alfanumricas, diferentes a espacios
        public string crossDocumentNumber { get; set; }    //11   193  203   NMERO DE DOCUMENTO CRUCE:  11 posiciones numricas
        public string crossDocumentSequence { get; set; }  //03   204  206	SECUENCIA DEL DOCUMENTO CRUCE:  3 posiciones numricas.  Secuencia del documento cruce, mximo hasta 250
        public string crossDocumentDate { get; set; }      //08   207  214	FECHA VENCIMIENTO DE DOCUMENTO CRUCE:  8 posiciones numricas (AAAAMMDD)
        public string paymentTypeCode { get; set; }        //04   215  218	CDIGO FORMA DE PAGO:  4 posiciones numricas, solo se utilizan tres el primer digito debe ser cero.
        public string bankCode { get; set; }               //02   219  220	CDIGO DEL BANCO:  2 posiciones numricas
        public string orderNumber { get; set; }
        public bool calendar { get; set; }
        public DateTime endMonth { get; set; }

        public double widthOrder { get; set; }
        public string filmOrder { get; set; }


        public siigoMovements()
        {
            receiptType = "";
            completeReceiptType = "";
            receiptCode = "";
            receiptNumber = "";
            receiptSequence = "";
            receiptNIT = "1790663671001";
            subsidiary = "000";
            account = "1005050100";
            productCode = "";
            documentDate = "";
            costCenter = "";
            costSubCenter = "";
            description = "";
            creditDebit = "";
            value = "000000000000000";
            retentionBase = "000000000000000";
            sellerCode = "0000";
            cityCode = "0000";
            zoneCode = "000";
            cellarCode = "";
            locationCode = "000";
            quantity = "";
            crossDocumentType = " ";
            crossDocumentCode = "---";
            crossDocumentNumber = "---";
            crossDocumentSequence = "000";
            crossDocumentDate = "00000000";
            paymentTypeCode = "0000";
            bankCode = "00";
            orderNumber = "";
            widthOrder = 0;
            filmOrder = "";
        }

        public int CompareTo(siigoMovements b)
        {
            // Alphabetic sort name[A to Z]
            return this.completeReceiptType.CompareTo(b.completeReceiptType);
        }

    }

    public class clsXportCellarMovementsToSIIGO
    {
        public static bool exportCellarMovementsToSiigo(List<clsPalletbyCoilCellar> lstPalletMovement, string folderPath, int a, bool calendar, DateTime endMonthDate)
        {
            string strFileOne = "";
            string fileName = "";
            int actualMovementNumber = 0;


            bool changeE001 = false;
            bool changeE010 = false;
            bool changeE011 = false;
            bool changeE012 = false;
            bool changeE021 = false;
            bool changeE022 = false;
            bool changeE043 = false;
            bool changeH013 = false;
            bool changeH014 = false;
            bool changeH022 = false;
            bool changeH023 = false;
            bool changeH047 = false;
            bool changeS006 = false;
            bool changeS008 = false;
            bool changeS009 = false;
            bool changeS010 = false;
            bool changeS014 = false;
            bool changeS023 = false;
            bool changeS025 = false;
            bool changeE023 = false;

            try
            {
                if (a == 1)
                {
                    DataSet DS = clsConnection.getDataSetResult("SELECT * FROM bps_xtr_siigoMovementsSequential");
                    List<siigoMovements> lstSiigoMovements = new List<siigoMovements>();

                    for (int i = 0; i < lstPalletMovement.Count; i++)
                    {
                        if (lstPalletMovement[i].localweigth > 0)
                        {
                            string documentType = "";
                            string receiptCode = "";
                            string productCode = "";
                            string costCenter = "0500";
                            string costSubCenter = "001";
                            string movementType = "";
                            string cellarCode = "";
                            string quantity = clsGlobal.FillWithZeros((Math.Round(lstPalletMovement[i].localweigth, 1) * 100000).ToString(), 15);

                            productCode = clsGlobal.FillWithZeros(clsProduct.getExternalERPDescriptionNationalCode(new clsProduct(lstPalletMovement[i].producto)), 13);

                            if (lstPalletMovement[i].ingress == true)
                            {
                                documentType = "E";
                                movementType = "D";

                                switch (lstPalletMovement[i].fkcoilcellar)
                                {
                                    case 3:
                                        receiptCode = "010";
                                        cellarCode = "0003";
                                        break;
                                    case 4:
                                        receiptCode = "043";
                                        cellarCode = "0023";
                                        productCode = clsGlobal.FillWithZeros(clsProduct.getExternalERPDescriptionStockCode(new clsProduct(lstPalletMovement[i].producto)), 13);
                                        break;
                                    case 8:
                                        receiptCode = "043";
                                        cellarCode = "0023";
                                        productCode = clsGlobal.FillWithZeros(clsProduct.getExternalERPDescriptionStockCode(new clsProduct(lstPalletMovement[i].producto)), 13);
                                        break;
                                }
                            }
                            else
                            {
                                movementType = "C";

                                switch (lstPalletMovement[i].movement)
                                {
                                    case "Salida a bodega de proceso":
                                        switch (lstPalletMovement[i].fkcoilcellar)
                                        {
                                            case 3:
                                                documentType = "H";
                                                receiptCode = "014";
                                                cellarCode = "0003";
                                                break;
                                            case 4:
                                                documentType = "H";
                                                receiptCode = "023";
                                                cellarCode = "0023";
                                                productCode = clsGlobal.FillWithZeros(clsProduct.getExternalERPDescriptionStockCode(new clsProduct(lstPalletMovement[i].producto)), 13);
                                                break;
                                            case 8:
                                                documentType = "H";
                                                receiptCode = "023";
                                                cellarCode = "0023";
                                                productCode = clsGlobal.FillWithZeros(clsProduct.getExternalERPDescriptionStockCode(new clsProduct(lstPalletMovement[i].producto)), 13);
                                                break;
                                        }
                                        break;

                                    case "Salida a bodega de base para metalizar":
                                        switch (lstPalletMovement[i].fkcoilcellar)
                                        {
                                            case 3:
                                                documentType = "H";
                                                receiptCode = "014";
                                                cellarCode = "0003";
                                                break;
                                            case 4:
                                                documentType = "H";
                                                receiptCode = "023";
                                                cellarCode = "0023";
                                                productCode = clsGlobal.FillWithZeros(clsProduct.getExternalERPDescriptionStockCode(new clsProduct(lstPalletMovement[i].producto)), 13);
                                                break;
                                            case 8:
                                                documentType = "H";
                                                receiptCode = "023";
                                                cellarCode = "0023";
                                                productCode = clsGlobal.FillWithZeros(clsProduct.getExternalERPDescriptionStockCode(new clsProduct(lstPalletMovement[i].producto)), 13);
                                                break;
                                        }
                                        break;

                                    case "Despacho de mercadería":
                                        clsSalesOrder objSalesOrder = clsSalesOrder.getDetailByNumber(lstPalletMovement[i].order);

                                        switch (lstPalletMovement[i].fkcoilcellar)
                                        {
                                            case 1:
                                                if (objSalesOrder.isInternationalSale == false)
                                                {
                                                    if (objSalesOrder.EntityName.ToUpper() == "BOPP DEL ECUADOR S.A." || objSalesOrder.fkEntity == 119 || objSalesOrder.fkEntity == 173)
                                                    {
                                                        documentType = "H";
                                                        receiptCode = "047";
                                                        cellarCode = "0003";
                                                        costCenter = "0610";
                                                    }
                                                    else
                                                    {
                                                        documentType = "S";
                                                        receiptCode = "009";
                                                        cellarCode = "0003";
                                                        costCenter = "0610";
                                                    }
                                                }
                                                else
                                                {
                                                    documentType = "S";
                                                    receiptCode = "010";
                                                    cellarCode = "0003";
                                                    costCenter = "0610";
                                                }
                                                break;

                                            case 3:
                                                if (objSalesOrder.isInternationalSale == false)
                                                {
                                                    if (objSalesOrder.EntityName.ToUpper() == "BOPP DEL ECUADOR S.A." || objSalesOrder.fkEntity == 119 || objSalesOrder.fkEntity == 173)
                                                    {
                                                        documentType = "H";
                                                        receiptCode = "047";
                                                        cellarCode = "0003";
                                                        costCenter = "0610";
                                                    }
                                                    else
                                                    {
                                                        documentType = "S";
                                                        receiptCode = "009";
                                                        cellarCode = "0003";
                                                        costCenter = "0610";
                                                    }
                                                }
                                                else
                                                {
                                                    documentType = "S";
                                                    receiptCode = "010";
                                                    cellarCode = "0003";
                                                    costCenter = "0610";
                                                }
                                                break;
                                        }
                                        break;

                                    case "Salida de bodega de bajas":
                                        switch (lstPalletMovement[i].fkcoilcellar)
                                        {
                                            case 1:
                                                documentType = "H";
                                                receiptCode = "023";
                                                cellarCode = "0023";
                                                break;
                                            case 3:
                                                documentType = "H";
                                                receiptCode = "014";
                                                cellarCode = "0003";
                                                break;
                                            case 4:
                                                documentType = "H";
                                                receiptCode = "023";
                                                cellarCode = "0023";
                                                productCode = clsGlobal.FillWithZeros(clsProduct.getExternalERPDescriptionStockCode(new clsProduct(lstPalletMovement[i].producto)), 13);
                                                break;
                                            case 8:
                                                documentType = "H";
                                                receiptCode = "023";
                                                cellarCode = "0023";
                                                productCode = clsGlobal.FillWithZeros(clsProduct.getExternalERPDescriptionStockCode(new clsProduct(lstPalletMovement[i].producto)), 13);
                                                break;
                                        }
                                        break;
                                }
                            }

                            lstSiigoMovements.Add(new siigoMovements());

                            lstSiigoMovements[lstSiigoMovements.Count - 1].receiptType = documentType;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].receiptCode = receiptCode;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].completeReceiptType = documentType + receiptCode;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].productCode = productCode;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].documentDate = (calendar == true) ? endMonthDate.ToString("yyyyMMdd") : lstPalletMovement[i].date.ToString("yyyyMMdd");
                            lstSiigoMovements[lstSiigoMovements.Count - 1].costCenter = costCenter;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].costSubCenter = costSubCenter;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].description = clsGlobal.FillWithSpaces(lstPalletMovement[i].code + " - " + lstPalletMovement[i].movement.Replace("á", "a").Replace("é", "e").Replace("í", "i").Replace("ó", "o").Replace("ú", "u"), 50).Substring(0, 50);
                            lstSiigoMovements[lstSiigoMovements.Count - 1].creditDebit = movementType;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].cellarCode = cellarCode;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].quantity = quantity;
                        }

                        if (lstPalletMovement[i].oppweigth > 0)
                        {
                            string documentType = "";
                            string receiptCode = "";
                            string productCode = "";
                            string costCenter = "0500";
                            string costSubCenter = "001";
                            string movementType = "";
                            string cellarCode = "";
                            string quantity = clsGlobal.FillWithZeros((Math.Round(lstPalletMovement[i].oppweigth, 1) * 100000).ToString(), 15);

                            productCode = clsGlobal.FillWithZeros(clsProduct.getExternalERPDescriptionExternalCode(new clsProduct(lstPalletMovement[i].producto)), 13);

                            if (lstPalletMovement[i].ingress == true)
                            {
                                documentType = "E";
                                movementType = "D";

                                switch (lstPalletMovement[i].fkcoilcellar)
                                {
                                    case 3:
                                        if (lstPalletMovement[i].isImport == 0)
                                        {
                                            if (lstPalletMovement[i].producto.StartsWith("M"))
                                            {
                                                receiptCode = "023";
                                                cellarCode = "0018";
                                            }
                                            else
                                            {
                                                receiptCode = "022";
                                                cellarCode = "0018";
                                            }
                                        }
                                        else
                                        {
                                            receiptCode = "021";
                                            cellarCode = "0018";
                                        }
                                        break;

                                    case 4:
                                        if (lstPalletMovement[i].producto.StartsWith("M"))
                                        {
                                            receiptCode = "023";
                                            cellarCode = "0018";
                                        }
                                        else
                                        {
                                            receiptCode = "022";
                                            cellarCode = "0018";
                                        }
                                        break;

                                    case 8:

                                        if (lstPalletMovement[i].isImport == 0)
                                        {
                                            if (lstPalletMovement[i].producto.StartsWith("M"))
                                            {
                                                receiptCode = "023";
                                                cellarCode = "0018";
                                            }
                                            else
                                            {
                                                receiptCode = "022";
                                                cellarCode = "0018";
                                            }

                                        }
                                        else
                                        {
                                            receiptCode = "021";
                                            cellarCode = "0018";
                                        }

                                        break;

                                    case 11:
                                        if (lstPalletMovement[i].isImport == 0)
                                        {
                                            if (lstPalletMovement[i].producto.StartsWith("M"))
                                            {
                                                receiptCode = "023";
                                                cellarCode = "0018";
                                            }
                                            else
                                            {
                                                receiptCode = "022";
                                                cellarCode = "0018";
                                            }

                                        }
                                        else
                                        {
                                            receiptCode = "021";
                                            cellarCode = "0018";
                                        }

                                        break;

                                    case 12:
                                        if (lstPalletMovement[i].isImport == 0)
                                        {
                                            if (lstPalletMovement[i].producto.StartsWith("M"))
                                            {
                                                receiptCode = "023";
                                                cellarCode = "0018";
                                            }
                                            else
                                            {
                                                receiptCode = "022";
                                                cellarCode = "0018";
                                            }

                                        }
                                        else
                                        {
                                            receiptCode = "021";
                                            cellarCode = "0018";
                                        }

                                        break;
                                }
                            }
                            else
                            {
                                movementType = "C";

                                switch (lstPalletMovement[i].movement)
                                {
                                    case "Salida a bodega de proceso":
                                        switch (lstPalletMovement[i].fkcoilcellar)
                                        {
                                            case 3:
                                                documentType = "H";
                                                receiptCode = "022";
                                                cellarCode = "0018";
                                                break;

                                            case 4:
                                                documentType = "H";
                                                receiptCode = "022";
                                                cellarCode = "0018";
                                                break;

                                            case 8:
                                                documentType = "H";
                                                receiptCode = "022";
                                                cellarCode = "0018";
                                                break;

                                            case 11:
                                                documentType = "H";
                                                receiptCode = "022";
                                                cellarCode = "0018";
                                                break;

                                            case 12:
                                                documentType = "H";
                                                receiptCode = "022";
                                                cellarCode = "0018";
                                                break;
                                        }
                                        break;

                                    case "Salida a bodega de base para metalizar":
                                        switch (lstPalletMovement[i].fkcoilcellar)
                                        {
                                            case 3:
                                                documentType = "S";
                                                receiptCode = "006";
                                                cellarCode = "0018";
                                                break;

                                            case 4:
                                                documentType = "S";
                                                receiptCode = "006";
                                                cellarCode = "0018";
                                                break;

                                            case 8:
                                                documentType = "S";
                                                receiptCode = "006";
                                                cellarCode = "0018";
                                                break;

                                            case 9:
                                                documentType = "S";
                                                receiptCode = "006";
                                                cellarCode = "0018";
                                                break;
                                        }
                                        break;

                                    case "Despacho de mercadería":
                                        clsSalesOrder objSalesOrder = clsSalesOrder.getDetailByNumber(lstPalletMovement[i].order);

                                        if (objSalesOrder.EntityName.ToUpper() != "BOPP DEL ECUADOR S.A." || objSalesOrder.EntityName.ToUpper() != "BOPPDELECUADOR" || objSalesOrder.EntityName.ToUpper() != "BOPP DEL ECUADOR")
                                        {
                                            if (!objSalesOrder.isInternationalSale)
                                            {
                                                documentType = "S";
                                                receiptCode = "009";
                                                cellarCode = "0018";
                                                costCenter = "0610";
                                            }
                                            else
                                            {
                                                if (lstPalletMovement[i].producto.StartsWith("B"))
                                                {
                                                    documentType = "S";
                                                    receiptCode = "010";
                                                    cellarCode = "0018";
                                                    costCenter = "0610";
                                                }
                                                else if (lstPalletMovement[i].producto.StartsWith("M"))
                                                {
                                                    documentType = "S";
                                                    receiptCode = "008";
                                                    cellarCode = "0018";
                                                    costCenter = "0610";
                                                }
                                                else
                                                {
                                                    documentType = "S";
                                                    receiptCode = "010";
                                                    cellarCode = "0018";
                                                    costCenter = "0610";
                                                }
                                            }

                                        }
                                        else
                                        {

                                            if (!objSalesOrder.isInternationalSale)
                                            {
                                                documentType = "S";
                                                receiptCode = "023";
                                                cellarCode = "0018";
                                                costCenter = "0610";
                                            }
                                            else
                                            {
                                                documentType = "S";
                                                receiptCode = "000";
                                                cellarCode = "0018";
                                                costCenter = "0610";
                                            }
                                        }
                                        break;

                                    case "Salida de bodega de bajas":
                                        switch (lstPalletMovement[i].fkcoilcellar)
                                        {
                                            case 1:
                                                documentType = "H";
                                                receiptCode = "022";
                                                cellarCode = "0018";
                                                break;

                                            case 3:
                                                documentType = "H";
                                                receiptCode = "022";
                                                cellarCode = "0018";
                                                break;

                                            case 4:
                                                documentType = "H";
                                                receiptCode = "022";
                                                cellarCode = "0018";
                                                break;

                                            case 8:
                                                documentType = "H";
                                                receiptCode = "022";
                                                cellarCode = "0018";
                                                break;
                                        }
                                        break;
                                }
                            }
                            lstSiigoMovements.Add(new siigoMovements());

                            lstSiigoMovements[lstSiigoMovements.Count - 1].receiptType = documentType;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].receiptCode = receiptCode;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].completeReceiptType = documentType + receiptCode;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].productCode = productCode;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].documentDate = (calendar == true) ? endMonthDate.ToString("yyyyMMdd") : lstPalletMovement[i].date.ToString("yyyyMMdd");
                            lstSiigoMovements[lstSiigoMovements.Count - 1].costCenter = costCenter;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].costSubCenter = costSubCenter;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].description = clsGlobal.FillWithSpaces(lstPalletMovement[i].code + " - " + lstPalletMovement[i].movement.Replace('ú', 'u'), 50).Substring(0, 50);
                            lstSiigoMovements[lstSiigoMovements.Count - 1].creditDebit = movementType;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].cellarCode = cellarCode;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].quantity = quantity;
                        }
                    }

                    lstSiigoMovements.Sort();

                    string actualMovement = "";
                    int movementSequential = 0;
                    actualMovementNumber = 0;

                    for (int i = 0; i < lstSiigoMovements.Count; i++)
                    {
                        if (lstSiigoMovements[i].completeReceiptType != actualMovement)
                        {
                            actualMovement = lstSiigoMovements[i].completeReceiptType;
                            movementSequential = 1;
                        }
                        else
                        {
                            movementSequential = movementSequential + 1;
                        }

                        lstSiigoMovements[i].receiptSequence = clsGlobal.FillWithZeros(movementSequential.ToString(), 5);

                        switch (actualMovement)
                        {
                            case "E001":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E001"]);
                                changeE001 = true;
                                break;
                            case "E010":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E010"]);
                                changeE010 = true;
                                break;
                            case "E011":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E011"]);
                                changeE011 = true;
                                break;
                            case "E012":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E012"]);
                                changeE012 = true;
                                break;
                            case "E021":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E021"]);
                                changeE021 = true;
                                break;
                            case "E022":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E022"]);
                                changeE022 = true;
                                break;
                            case "E043":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E043"]);
                                changeE043 = true;
                                break;
                            case "H013":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H013"]);
                                changeH013 = true;
                                break;
                            case "H014":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H014"]);
                                changeH014 = true;
                                break;
                            case "H022":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H022"]);
                                changeH022 = true;
                                break;
                            case "H023":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H023"]);
                                changeH023 = true;
                                break;
                            case "H047":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H047"]);
                                changeH047 = true;
                                break;
                            case "S006":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S006"]);
                                changeS006 = true;
                                break;
                            case "S008":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S008"]);
                                changeS008 = true;
                                break;
                            case "S009":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S009"]);
                                changeS009 = true;
                                break;
                            case "S010":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S010"]);
                                changeS010 = true;
                                break;
                            case "S014":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S014"]);
                                changeS014 = true;
                                break;
                            case "S023":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S023"]);
                                changeS023 = true;
                                break;
                            case "S025":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S025"]);
                                changeS025 = true;
                                break;
                            case "E023":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E023"]);
                                changeE023 = true;
                                break;
                        }
                        lstSiigoMovements[i].receiptNumber = clsGlobal.FillWithZeros(actualMovementNumber.ToString(), 11);
                    }

                    for (int i = 0; i < lstSiigoMovements.Count; i++)
                    {
                        //FILE ONE
                        strFileOne += lstSiigoMovements[i].receiptType;  			//01   001  001	TIPO DE COMPROBANTE:  1 posicin alfanum	
                        strFileOne += lstSiigoMovements[i].receiptCode;  			//03   002  004	CDIGO COMPROBANTE:  3 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].receiptNumber;  			//11   005  015	NMERO DE DOCUMENTO:  11 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].receiptSequence;  		//05   016  020	SECUENCIA:  5 posiciones numricas.  Mximo hasta 250	
                        strFileOne += lstSiigoMovements[i].receiptNIT;  			//13   021  033	NIT:  13 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].subsidiary;  			//03   034  036	SUCURSAL:  3 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].account;  			    //10   037  046	CUENTA CONTABLE:  10 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].productCode;  			//13   047  059	CDIGO DE PRODUCTO:  13 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].documentDate;  			//08   060  067	FECHA DEL DOCUMENTO:  8 posiciones numricas (AAAAMMDD)	
                        strFileOne += lstSiigoMovements[i].costCenter;  			//04   068  071	CENTRO DE COSTO:  4 posiciones numricas		
                        strFileOne += lstSiigoMovements[i].costSubCenter;  			//03   072  074	SUBCENTRO DE COSTO:  3 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].description;  			//50   075  124	DESCRIPCIN DEL MOVIMIENTO:  50 posiciones alfanumricas, para comentario o detalle del movimiento	
                        strFileOne += lstSiigoMovements[i].creditDebit;  			//01   125  125	DBITO O CRDITO:  1 posicin alfanumrica.  Valor D  C	
                        strFileOne += lstSiigoMovements[i].value;  			        //15   126  140	VALOR DEL MOVIMIENTO:  15 posiciones numricas, 13 enteros, 2 decimales	
                        strFileOne += lstSiigoMovements[i].retentionBase;  			//15   141  155	BASE DE RETENCIN:  15 posiciones numricas, 13 enteros, 2 decimales	
                        strFileOne += lstSiigoMovements[i].sellerCode;  			//04   156  159	CDIGO DEL VENDEDOR:  4 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].cityCode;  			    //04   160  163	CDIGO DE LA CIUDAD:  4 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].zoneCode;  			    //03   164  166	CDIGO DE LA ZONA:  3 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].cellarCode;  			//04   167  170	CDIGO DE LA BODEGA:  4 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].locationCode;  			//03   171  173	CDIGO DE LA UBICACIN:  3 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].quantity;  			    //15   174  188	CANTIDAD:  15 posiciones numricas, 10 enteros, 5 decimales	
                        strFileOne += lstSiigoMovements[i].crossDocumentType;  		//01   189  189	TIPO DE DOCUMENTO CRUCE:  1 posicin alfanumrica 	
                        strFileOne += lstSiigoMovements[i].crossDocumentCode;  		//03   190  192	CDIGO COMPROBANTE CRUCE:  3 posiciones alfanumricas, diferentes a espacios	
                        strFileOne += lstSiigoMovements[i].crossDocumentNumber;		//11   193  203   NMERO DE DOCUMENTO CRUCE:  11 posiciones numricas		
                        strFileOne += lstSiigoMovements[i].crossDocumentSequence;  	//03   204  206	SECUENCIA DEL DOCUMENTO CRUCE:  3 posiciones numricas.  Secuencia del documento cruce, mximo hasta 250	
                        strFileOne += lstSiigoMovements[i].crossDocumentDate;  		//08   207  214	FECHA VENCIMIENTO DE DOCUMENTO CRUCE:  8 posiciones numricas (AAAAMMDD)	
                        strFileOne += lstSiigoMovements[i].paymentTypeCode;  		//04   215  218	CDIGO FORMA DE PAGO:  4 posiciones numricas, solo se utilizan tres el primer digito debe ser cero.	
                        strFileOne += lstSiigoMovements[i].bankCode;  			    //02   219  220	CDIGO DEL BANCO:  2 posiciones numricas	                    
                        strFileOne += "\r\n";
                    }
                    fileName = folderPath + "\\m" + DateTime.Now.ToString("yyyyMMddHHmm") + ".txt";

                    FileStream fs = File.Open(fileName, FileMode.CreateNew, FileAccess.Write);

                    StreamWriter sw = new StreamWriter(fs);

                    sw.Write(strFileOne);
                    sw.Close();
                    fs.Close();

                    if (changeE001 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E001 = sms_E001 + 1;");
                    if (changeE010 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E010 = sms_E010 + 1;");
                    if (changeE011 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E011 = sms_E011 + 1;");
                    if (changeE012 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E012 = sms_E012 + 1;");
                    if (changeE021 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E021 = sms_E021 + 1;");
                    if (changeE022 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E022 = sms_E022 + 1;");
                    if (changeE043 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E043 = sms_E043 + 1;");
                    if (changeH013 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H013 = sms_H013 + 1;");
                    if (changeH014 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H014 = sms_H014 + 1;");
                    if (changeH022 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H022 = sms_H022 + 1;");
                    if (changeH023 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H023 = sms_H023 + 1;");
                    if (changeH047 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H047 = sms_H047 + 1;");
                    if (changeS006 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S006 = sms_S006 + 1;");
                    if (changeS008 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S008 = sms_S008 + 1;");
                    if (changeS009 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S009 = sms_S009 + 1;");
                    if (changeS010 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S010 = sms_S010 + 1;");
                    if (changeS014 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S014 = sms_S014 + 1;");
                    if (changeS023 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S023 = sms_S023 + 1;");
                    if (changeS025 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S025 = sms_S025 + 1;");
                    if (changeE023 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E023 = sms_E023 + 1;");
                }
                else
                {
                    //para importaciones
                }
            }
            catch (Exception)
            {
                throw;
            }
            return true;
        }

        public static bool exportCellarShippingPalletToSiigo(List<clsPalletbyCoilCellar> lstPalletMovement, string folderPath, int a, bool calendar, DateTime endMonthDate)
        {
            string strFileOne = "";
            string fileName = "";
            int actualMovementNumber = 0;

            bool changeE001 = false;
            bool changeE010 = false;
            bool changeE011 = false;
            bool changeE012 = false;
            bool changeE021 = false;
            bool changeE022 = false;
            bool changeE043 = false;
            bool changeH013 = false;
            bool changeH014 = false;
            bool changeH022 = false;
            bool changeH023 = false;
            bool changeH047 = false;
            bool changeS006 = false;
            bool changeS008 = false;
            bool changeS009 = false;
            bool changeS010 = false;
            bool changeS014 = false;
            bool changeS023 = false;
            bool changeS025 = false;
            bool changeE023 = false;

            try
            {
                if (a == 1)
                {
                    DataSet DS = clsConnection.getDataSetResult("SELECT * FROM bps_xtr_siigoMovementsSequential");
                    List<siigoMovements> lstSiigoMovements = new List<siigoMovements>();

                    List<clsPalletbyCoilCellar> lstList = new List<clsPalletbyCoilCellar>();
                    List<clsPalletbyCoilCellar> lstFinallyList = new List<clsPalletbyCoilCellar>();

                    List<List<clsPalletbyCoilCellar>> lstDiferentSalesMovements = new List<List<clsPalletbyCoilCellar>>();
                    string strActualSalesOrder = "";

                    for (int i = 0; i < lstPalletMovement.Count; i++)
                    {
                        if (strActualSalesOrder == lstPalletMovement[i].order)
                            lstDiferentSalesMovements[lstDiferentSalesMovements.Count - 1].Add(lstPalletMovement[i]);
                        else
                        {
                            lstDiferentSalesMovements.Add(new List<clsPalletbyCoilCellar>());

                            strActualSalesOrder = lstPalletMovement[i].order;
                            lstDiferentSalesMovements[lstDiferentSalesMovements.Count - 1].Add(lstPalletMovement[i]);
                        }
                    }

                    List<clsPalletbyCoilCellar> lstpallet = new List<clsPalletbyCoilCellar>();

                    foreach (List<clsPalletbyCoilCellar> list in lstDiferentSalesMovements)
                    {
                        foreach (clsPalletbyCoilCellar palletbyCoilCellarListOBJ in list)
                        {
                            lstpallet.Add(palletbyCoilCellarListOBJ);
                        }
                        //Add List Group
                        lstList = clsPalletbyCoilCellar.getAccumulatedOrder(lstpallet);

                        for (int i = 0; i < lstList.Count; i++)
                            lstFinallyList.Add(lstList[i]);

                        lstpallet.Clear();
                        lstList.Clear();
                    }

                    for (int i = 0; i < lstFinallyList.Count; i++)
                    {
                        if (lstFinallyList[i].localweigth > 0)
                        {
                            string Nit = "";
                            string documentType = "";
                            string receiptCode = "";
                            string productCode = "";
                            string costCenter = "0610";
                            string costSubCenter = "002";
                            string movementType = "";
                            string cellarCode = "";
                            string quantity = clsGlobal.FillWithZeros((Math.Round(lstFinallyList[i].localweigth, 1) * 100000).ToString(), 15);
                            productCode = clsGlobal.FillWithZeros(clsProduct.getExternalERPDescriptionNationalCode(lstFinallyList[i].filmBopp, lstFinallyList[i].filmOpp), 13);
                            movementType = "C";
                            clsSalesOrder objSalesOrder = clsSalesOrder.getDetailByNumberOnlySalesOrder(lstFinallyList[i].order);
                            //for (int h = 0; h < objSalesOrder.lstSalesOrderDetail.Count; h++)
                            //{
                            //    if (objSalesOrder.lstSalesOrderDetail[h].fkProduct == lstFinallyList[i].fkproductalfa)
                            //    {
                            //        price = clsGlobal.FillWithZeros((Math.Round(objSalesOrder.lstSalesOrderDetail[i].price, 2) * 100).ToString(), 15);
                            //        break;
                            //    }
                            //}
                            if (objSalesOrder.isInternationalSale == false)
                            {
                                if (objSalesOrder.fkEntity == 119 || objSalesOrder.fkEntity == 173)
                                {
                                    documentType = "H";
                                    receiptCode = "047";
                                    cellarCode = "0003";
                                    costCenter = "0610";
                                    Nit = clsGlobal.FillWithZeros(objSalesOrder.EntityID, 13);
                                }
                                else
                                {
                                    documentType = "S";
                                    receiptCode = "009";
                                    cellarCode = "0003";
                                    costCenter = "0610";
                                    Nit = clsGlobal.FillWithZeros(objSalesOrder.EntityID, 13);
                                }
                            }
                            else
                            {
                                documentType = "S";
                                receiptCode = "010";
                                cellarCode = "0003";
                                costCenter = "0610";
                                Nit = clsGlobal.FillWithZeros(objSalesOrder.EntityID, 13);
                            }

                            lstSiigoMovements.Add(new siigoMovements());

                            lstSiigoMovements[lstSiigoMovements.Count - 1].receiptType = documentType;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].receiptCode = receiptCode;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].completeReceiptType = documentType + receiptCode;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].productCode = productCode;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].documentDate = (calendar == true) ? endMonthDate.ToString("yyyyMMdd") : lstFinallyList[i].date.ToString("yyyyMMdd");
                            lstSiigoMovements[lstSiigoMovements.Count - 1].costCenter = costCenter;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].costSubCenter = costSubCenter;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].description = clsGlobal.FillWithSpaces(lstFinallyList[i].movement.Replace("á", "a").Replace("é", "e").Replace("í", "i").Replace("ó", "o").Replace("ú", "u"), 50).Substring(0, 50);
                            lstSiigoMovements[lstSiigoMovements.Count - 1].creditDebit = movementType;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].cellarCode = cellarCode;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].quantity = quantity;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].crossDocumentNumber = lstFinallyList[i].order;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].receiptNIT = Nit;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].sellerCode = clsGlobal.FillWithZeros("13", 4).Substring(0, 4);
                            lstSiigoMovements[lstSiigoMovements.Count - 1].subsidiary = "000";
                            lstSiigoMovements[lstSiigoMovements.Count - 1].widthOrder = lstFinallyList[i].width;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].filmOrder = lstFinallyList[i].code;
                            //lstSiigoMovements[lstSiigoMovements.Count - 1].value = "000000000000000";
                        }
                        if (lstFinallyList[i].oppweigth > 0)
                        {
                            string Nit = "";
                            string documentType = "";
                            string receiptCode = "";
                            string productCode = "";
                            string costCenter = "0610";
                            string costSubCenter = "002";
                            string movementType = "";
                            string cellarCode = "";
                            string quantity = clsGlobal.FillWithZeros((Math.Round(lstFinallyList[i].oppweigth, 1) * 100000).ToString(), 15);
                            productCode = clsGlobal.FillWithZeros(clsProduct.getExternalERPDescriptionExternalCode(lstFinallyList[i].filmBopp, lstFinallyList[i].filmOpp), 13);
                            movementType = "C";
                            clsSalesOrder objSalesOrder = clsSalesOrder.getDetailByNumberOnlySalesOrder(lstFinallyList[i].order);
                            //for (int h = 0; h < objSalesOrder.lstSalesOrderDetail.Count; h++)
                            //{
                            //    if (objSalesOrder.lstSalesOrderDetail[h].fkProduct == lstFinallyList[i].fkproductalfa)
                            //    {
                            //        price = clsGlobal.FillWithZeros((Math.Round(objSalesOrder.lstSalesOrderDetail[i].price, 2) * 100).ToString(), 15);
                            //        break;
                            //    }
                            //}


                            if (objSalesOrder.isInternationalSale == false)
                            {
                                if (objSalesOrder.fkEntity == 119 || objSalesOrder.fkEntity == 173)
                                {
                                    documentType = "S";
                                    receiptCode = "023";
                                    cellarCode = "0018";
                                    costCenter = "0610";
                                    Nit = clsGlobal.FillWithZeros(objSalesOrder.EntityID, 13);
                                }
                                else
                                {
                                    documentType = "S";
                                    receiptCode = "009";
                                    cellarCode = "0018";
                                    costCenter = "0610";
                                    Nit = clsGlobal.FillWithZeros(objSalesOrder.EntityID, 13);
                                }
                            }
                            else
                            {
                                documentType = "S";
                                receiptCode = "010";
                                cellarCode = "0018";
                                costCenter = "0610";
                                Nit = clsGlobal.FillWithZeros(objSalesOrder.EntityID, 13);
                            }
                            lstSiigoMovements.Add(new siigoMovements());

                            lstSiigoMovements[lstSiigoMovements.Count - 1].receiptType = documentType;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].receiptCode = receiptCode;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].completeReceiptType = documentType + receiptCode;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].productCode = productCode;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].documentDate = (calendar == true) ? endMonthDate.ToString("yyyyMMdd") : lstFinallyList[i].date.ToString("yyyyMMdd");
                            lstSiigoMovements[lstSiigoMovements.Count - 1].costCenter = costCenter;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].costSubCenter = costSubCenter;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].description = clsGlobal.FillWithSpaces(lstFinallyList[i].movement.Replace("á", "a").Replace("é", "e").Replace("í", "i").Replace("ó", "o").Replace("ú", "u"), 50).Substring(0, 50);
                            lstSiigoMovements[lstSiigoMovements.Count - 1].creditDebit = movementType;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].cellarCode = cellarCode;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].quantity = quantity;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].crossDocumentNumber = lstFinallyList[i].order;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].receiptNIT = Nit;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].sellerCode = clsGlobal.FillWithZeros("13", 4).Substring(0, 4);
                            lstSiigoMovements[lstSiigoMovements.Count - 1].subsidiary = "000";
                            lstSiigoMovements[lstSiigoMovements.Count - 1].widthOrder = lstFinallyList[i].width;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].filmOrder = lstFinallyList[i].code;
                            //lstSiigoMovements[lstSiigoMovements.Count - 1].value = "000000000000000";
                        }
                    }

                    lstSiigoMovements.Sort();

                    lstSiigoMovements = lstSiigoMovements.OrderBy(order => order.filmOrder).ThenBy(order => order.widthOrder).ToList();

                    string actualMovement = "";
                    int movementSequential = 0;
                    actualMovementNumber = 0;

                    for (int i = 0; i < lstSiigoMovements.Count; i++)
                    {
                        if (lstSiigoMovements[i].completeReceiptType != actualMovement)
                        {
                            actualMovement = lstSiigoMovements[i].completeReceiptType;
                            movementSequential = 1;
                        }
                        else
                            movementSequential = movementSequential + 1;

                        lstSiigoMovements[i].receiptSequence = clsGlobal.FillWithZeros(movementSequential.ToString(), 5);

                        switch (actualMovement)
                        {
                            case "E001":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E001"]);
                                changeE001 = true;
                                break;
                            case "E010":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E010"]);
                                changeE010 = true;
                                break;
                            case "E011":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E011"]);
                                changeE011 = true;
                                break;
                            case "E012":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E012"]);
                                changeE012 = true;
                                break;
                            case "E021":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E021"]);
                                changeE021 = true;
                                break;
                            case "E022":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E022"]);
                                changeE022 = true;
                                break;
                            case "E043":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E043"]);
                                changeE043 = true;
                                break;
                            case "H013":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H013"]);
                                changeH013 = true;
                                break;
                            case "H014":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H014"]);
                                changeH014 = true;
                                break;
                            case "H022":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H022"]);
                                changeH022 = true;
                                break;
                            case "H023":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H023"]);
                                changeH023 = true;
                                break;
                            case "H047":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H047"]);
                                changeH047 = true;
                                break;
                            case "S006":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S006"]);
                                changeS006 = true;
                                break;
                            case "S008":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S008"]);
                                changeS008 = true;
                                break;
                            case "S009":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S009"]);
                                changeS009 = true;
                                break;
                            case "S010":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S010"]);
                                changeS010 = true;
                                break;
                            case "S014":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S014"]);
                                changeS014 = true;
                                break;
                            case "S023":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S023"]);
                                changeS023 = true;
                                break;
                            case "S025":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S025"]);
                                changeS025 = true;
                                break;
                            case "E023":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E023"]);
                                changeE023 = true;
                                break;
                        }
                        lstSiigoMovements[i].receiptNumber = clsGlobal.FillWithZeros(actualMovementNumber.ToString(), 11);
                    }

                    for (int i = 0; i < lstSiigoMovements.Count; i++)
                    {
                        //FILE ONE
                        strFileOne += lstSiigoMovements[i].receiptType;  			//01   001  001	TIPO DE COMPROBANTE:  1 posicin alfanum	
                        strFileOne += lstSiigoMovements[i].receiptCode;  			//03   002  004	CDIGO COMPROBANTE:  3 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].receiptNumber;  			//11   005  015	NMERO DE DOCUMENTO:  11 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].receiptSequence;  		//05   016  020	SECUENCIA:  5 posiciones numricas.  Mximo hasta 250	
                        strFileOne += lstSiigoMovements[i].receiptNIT;  			//13   021  033	NIT:  13 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].subsidiary;  			//03   034  036	SUCURSAL:  3 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].account;  			    //10   037  046	CUENTA CONTABLE:  10 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].productCode;  			//13   047  059	CDIGO DE PRODUCTO:  13 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].documentDate;  			//08   060  067	FECHA DEL DOCUMENTO:  8 posiciones numricas (AAAAMMDD)	
                        strFileOne += lstSiigoMovements[i].costCenter;  			//04   068  071	CENTRO DE COSTO:  4 posiciones numricas		
                        strFileOne += lstSiigoMovements[i].costSubCenter;  			//03   072  074	SUBCENTRO DE COSTO:  3 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].description;  			//50   075  124	DESCRIPCIN DEL MOVIMIENTO:  50 posiciones alfanumricas, para comentario o detalle del movimiento	
                        strFileOne += lstSiigoMovements[i].creditDebit;  			//01   125  125	DBITO O CRDITO:  1 posicin alfanumrica.  Valor D  C	
                        strFileOne += lstSiigoMovements[i].value;  			        //15   126  140	VALOR DEL MOVIMIENTO:  15 posiciones numricas, 13 enteros, 2 decimales	
                        strFileOne += lstSiigoMovements[i].retentionBase;  			//15   141  155	BASE DE RETENCIN:  15 posiciones numricas, 13 enteros, 2 decimales	
                        strFileOne += lstSiigoMovements[i].sellerCode;  			//04   156  159	CDIGO DEL VENDEDOR:  4 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].cityCode;  			    //04   160  163	CDIGO DE LA CIUDAD:  4 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].zoneCode;  			    //03   164  166	CDIGO DE LA ZONA:  3 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].cellarCode;  			//04   167  170	CDIGO DE LA BODEGA:  4 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].locationCode;  			//03   171  173	CDIGO DE LA UBICACIN:  3 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].quantity;  			    //15   174  188	CANTIDAD:  15 posiciones numricas, 10 enteros, 5 decimales	
                        strFileOne += lstSiigoMovements[i].crossDocumentType;  		//01   189  189	TIPO DE DOCUMENTO CRUCE:  1 posicin alfanumrica 	
                        strFileOne += lstSiigoMovements[i].crossDocumentCode;  		//03   190  192	CDIGO COMPROBANTE CRUCE:  3 posiciones alfanumricas, diferentes a espacios	
                        strFileOne += lstSiigoMovements[i].crossDocumentNumber;		//11   193  203   NMERO DE DOCUMENTO CRUCE:  11 posiciones numricas		
                        strFileOne += lstSiigoMovements[i].receiptSequence;  	    //03   204  206	SECUENCIA DEL DOCUMENTO CRUCE:  3 posiciones numricas.  Secuencia del documento cruce, mximo hasta 250	
                        strFileOne += lstSiigoMovements[i].documentDate;  		    //08   207  214	FECHA VENCIMIENTO DE DOCUMENTO CRUCE:  8 posiciones numricas (AAAAMMDD)	
                        strFileOne += lstSiigoMovements[i].paymentTypeCode;  		//04   215  218	CDIGO FORMA DE PAGO:  4 posiciones numricas, solo se utilizan tres el primer digito debe ser cero.	
                        strFileOne += lstSiigoMovements[i].bankCode;  			    //02   219  220	CDIGO DEL BANCO:  2 posiciones numricas	                    
                        strFileOne += "\r\n";
                    }
                    fileName = folderPath + "\\m" + DateTime.Now.ToString("yyyyMMddHHmm") + ".txt";

                    FileStream fs = File.Open(fileName, FileMode.CreateNew, FileAccess.Write);

                    StreamWriter sw = new StreamWriter(fs);

                    sw.Write(strFileOne);
                    sw.Close();
                    fs.Close();

                    if (changeE001 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E001 = sms_E001 + 1;");
                    if (changeE010 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E010 = sms_E010 + 1;");
                    if (changeE011 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E011 = sms_E011 + 1;");
                    if (changeE012 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E012 = sms_E012 + 1;");
                    if (changeE021 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E021 = sms_E021 + 1;");
                    if (changeE022 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E022 = sms_E022 + 1;");
                    if (changeE043 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E043 = sms_E043 + 1;");
                    if (changeH013 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H013 = sms_H013 + 1;");
                    if (changeH014 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H014 = sms_H014 + 1;");
                    if (changeH022 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H022 = sms_H022 + 1;");
                    if (changeH023 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H023 = sms_H023 + 1;");
                    if (changeH047 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H047 = sms_H047 + 1;");
                    if (changeS006 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S006 = sms_S006 + 1;");
                    if (changeS008 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S008 = sms_S008 + 1;");
                    if (changeS009 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S009 = sms_S009 + 1;");
                    if (changeS010 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S010 = sms_S010 + 1;");
                    if (changeS014 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S014 = sms_S014 + 1;");
                    if (changeS023 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S023 = sms_S023 + 1;");
                    if (changeS025 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S025 = sms_S025 + 1;");
                    if (changeE023 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E023 = sms_E023 + 1;");
                }
                else
                {
                    //para importaciones
                }
            }
            catch (Exception)
            {

            }
            return true;
        }

        public static bool exportCellarShippingsToSiigo(List<clsPalletbyCoilCellar> lstPalletMovement, string folderPath, int a)
        {
            string strFileOne = "";
            string fileName = "";
            int actualMovementNumber = 0;

            bool changeS006 = false;
            bool changeS008 = false;
            bool changeS009 = false;
            bool changeS010 = false;
            bool changeS023 = false;
            bool changeS025 = false;

            int S006 = 0;
            int S008 = 0;
            int S009 = 0;
            int S010 = 0;
            int S023 = 0;
            int S025 = 0;

            try
            {
                DataSet DS = clsConnection.getDataSetResult("SELECT * FROM bps_xtr_siigoMovementsSequential");

                S006 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S006"]);
                S008 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S008"]);
                S009 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S009"]);
                S010 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S010"]);
                S023 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S023"]);
                S025 = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S025"]);

                List<siigoMovements> lstSiigoMovements = new List<siigoMovements>();

                List<List<clsPalletbyCoilCellar>> lstDiferentSalesMovements = new List<List<clsPalletbyCoilCellar>>();
                string strActualSalesOrder = "";

                for (int i = 0; i < lstPalletMovement.Count; i++)
                {
                    if (strActualSalesOrder == lstPalletMovement[i].order)
                    {
                        lstDiferentSalesMovements[lstDiferentSalesMovements.Count - 1].Add(lstPalletMovement[i]);
                    }
                    else
                    {
                        lstDiferentSalesMovements.Add(new List<clsPalletbyCoilCellar>());

                        strActualSalesOrder = lstPalletMovement[i].order;
                        lstDiferentSalesMovements[lstDiferentSalesMovements.Count - 1].Add(lstPalletMovement[i]);
                    }
                }

                for (int i = 0; i < lstDiferentSalesMovements.Count; i++)
                {
                    lstDiferentSalesMovements[i].Sort();
                    List<clsPalletbyCoilCellar> lstPalletByCoilCellarUnified = new List<clsPalletbyCoilCellar>();
                    clsPallet objPallet = new clsPallet();

                    for (int j = 0; j < lstDiferentSalesMovements[i].Count; j++)
                    {
                        int positionLocal = -1;
                        int positionExternal = -1;

                        for (int k = 0; k < lstPalletByCoilCellarUnified.Count; k++)
                        {
                            if (lstDiferentSalesMovements[i][j].producto == lstPalletByCoilCellarUnified[k].producto && lstDiferentSalesMovements[i][j].localweigth > 0)
                                positionLocal = k;

                            if (lstDiferentSalesMovements[i][j].producto == lstPalletByCoilCellarUnified[k].producto && lstDiferentSalesMovements[i][j].oppweigth > 0)
                                positionExternal = k;
                        }

                        if (lstDiferentSalesMovements[i][j].localweigth > 0 && positionLocal == -1)
                        {
                            lstPalletByCoilCellarUnified.Add(new clsPalletbyCoilCellar(lstDiferentSalesMovements[i][j].codsec));
                            positionLocal = lstPalletByCoilCellarUnified.Count - 1;
                            lstPalletByCoilCellarUnified[positionLocal].oppweigth = 0;
                            lstPalletByCoilCellarUnified[positionLocal].localweigth = 0;
                            lstPalletByCoilCellarUnified[positionLocal].localCoils = 0;
                            lstPalletByCoilCellarUnified[positionLocal].oppCoils = 0;

                        }
                        if (lstDiferentSalesMovements[i][j].oppweigth > 0 && positionExternal == -1)
                        {
                            lstPalletByCoilCellarUnified.Add(new clsPalletbyCoilCellar(lstDiferentSalesMovements[i][j].codsec));
                            positionExternal = lstPalletByCoilCellarUnified.Count - 1;
                            lstPalletByCoilCellarUnified[positionExternal].localweigth = 0;
                            lstPalletByCoilCellarUnified[positionExternal].oppweigth = 0;
                            lstPalletByCoilCellarUnified[positionExternal].localCoils = 0;
                            lstPalletByCoilCellarUnified[positionExternal].oppCoils = 0;

                        }

                        if (positionLocal > -1)
                        {
                            lstPalletByCoilCellarUnified[positionLocal].localweigth += lstDiferentSalesMovements[i][j].localweigth;
                            lstPalletByCoilCellarUnified[positionLocal].localCoils += lstDiferentSalesMovements[i][j].localCoils;
                            lstPalletByCoilCellarUnified[positionLocal].movement = lstDiferentSalesMovements[i][j].producto + " / " + lstPalletByCoilCellarUnified[positionLocal].localCoils.ToString() + " Bobinas.";
                        }
                        if (positionExternal > -1)
                        {

                            lstPalletByCoilCellarUnified[positionExternal].oppweigth += lstDiferentSalesMovements[i][j].oppweigth;
                            lstPalletByCoilCellarUnified[positionExternal].oppCoils += lstDiferentSalesMovements[i][j].oppCoils;
                            lstPalletByCoilCellarUnified[positionExternal].movement = lstDiferentSalesMovements[i][j].producto + " / " + lstPalletByCoilCellarUnified[positionExternal].oppCoils.ToString() + " Bobinas.";
                        }

                        //if (actualProductCode == lstDiferentSalesMovements[i][j].producto)
                        //{
                        //    objPallet = new clsPallet(lstDiferentSalesMovements[i][j].fkpallet);
                        //    palletCount++;
                        //    palletWeight += Math.Round(objPallet.netWeight, 1);
                        //    coilCount += objPallet.lstCoil.Count;
                        //    lstPalletByCoilCellarUnified[lstPalletByCoilCellarUnified.Count - 1].movement = lstDiferentSalesMovements[i][j].producto + "/" + palletCount.ToString() + "PAL/" + coilCount.ToString() + "B";
                        //    lstPalletByCoilCellarUnified[lstPalletByCoilCellarUnified.Count - 1].netweigth = palletWeight;

                        //}
                        //else
                        //{
                        //    if (lstDiferentSalesMovements[i][j].localweigth > 0)
                        //    {
                        //        actualProductCode = lstDiferentSalesMovements[i][j].producto;
                        //        lstPalletByCoilCellarUnified.Add(lstDiferentSalesMovements[i][j]);
                        //        objPallet = new clsPallet(lstDiferentSalesMovements[i][j].fkpallet);
                        //        palletCount = 1;
                        //        palletWeight = Math.Round(lstDiferentSalesMovements[i][j].netweigth, 1);
                        //        coilCount = objPallet.lstCoil.Count;
                        //        lstPalletByCoilCellarUnified[lstPalletByCoilCellarUnified.Count - 1].movement = lstDiferentSalesMovements[i][j].producto + "/" + palletCount.ToString() + "PAL/" + coilCount.ToString() + "B";
                        //        lstPalletByCoilCellarUnified[lstPalletByCoilCellarUnified.Count - 1].netweigth = palletWeight;
                        //    }
                        //    if (lstDiferentSalesMovements[i][j].oppweigth > 0)
                        //    {
                        //        actualProductCode = lstDiferentSalesMovements[i][j].producto;
                        //        lstPalletByCoilCellarUnified.Add(lstDiferentSalesMovements[i][j]);
                        //        objPallet = new clsPallet(lstDiferentSalesMovements[i][j].fkpallet);
                        //        palletCount = 1;
                        //        palletWeight = Math.Round(lstDiferentSalesMovements[i][j].netweigth, 1);
                        //        coilCount = objPallet.lstCoil.Count;
                        //        lstPalletByCoilCellarUnified[lstPalletByCoilCellarUnified.Count - 1].movement = lstDiferentSalesMovements[i][j].producto + "/" + palletCount.ToString() + "PAL/" + coilCount.ToString() + "B";
                        //        lstPalletByCoilCellarUnified[lstPalletByCoilCellarUnified.Count - 1].netweigth = palletWeight;
                        //    }
                        //}
                    }

                    lstDiferentSalesMovements[i] = lstPalletByCoilCellarUnified;
                }
                for (int i = 0; i < lstDiferentSalesMovements.Count; i++)
                {
                    lstDiferentSalesMovements[i].Sort();
                }
                for (int pos = 0; pos < lstDiferentSalesMovements.Count; pos++)
                {
                    int localSequence = 0;
                    for (int i = 0; i < lstDiferentSalesMovements[pos].Count; i++)
                    {
                        //clsPallet objPallet = new clsPallet(lstDiferentSalesMovements[pos][i].fkpallet);

                        //objPallet.product.Bopp = new clsBopp(objPallet.product.fkBopp);
                        //objPallet.product.Cast = new clsCast(objPallet.product.fkCast);

                        //double externalWeight = 0;
                        //double localWeight = 0;

                        //for (int j = 0; j < objPallet.lstCoil.Count; j++)
                        //{
                        //    if (objPallet.lstCoil[j].isExternalCoil)
                        //        externalWeight += objPallet.lstCoil[j].netWeight;
                        //    else
                        //        localWeight += objPallet.lstCoil[j].netWeight;
                        //}

                        if (lstDiferentSalesMovements[pos][i].localweigth > 0)
                        {
                            string documentType = "";
                            string receiptCode = "";
                            string productCode = "";
                            string costCenter = "0500";
                            string costSubCenter = "001";
                            string movementType = "";
                            string cellarCode = "";
                            string quantity = clsGlobal.FillWithZeros((Math.Round(lstDiferentSalesMovements[pos][i].localweigth, 2) * 100000).ToString(), 15);
                            localSequence++;


                            productCode = clsGlobal.FillWithZeros(clsProduct.getExternalERPDescriptionNationalCode(new clsProduct(lstDiferentSalesMovements[pos][i].producto)), 13);

                            movementType = "C";

                            clsSalesOrder objSalesOrder = clsSalesOrder.getDetailByNumber(lstDiferentSalesMovements[pos][i].order);

                            switch (lstDiferentSalesMovements[pos][i].fkcoilcellar)
                            {
                                case 3:
                                    if (objSalesOrder.isInternationalSale == false)
                                    {
                                        if (objSalesOrder.EntityName.ToUpper() != "BOPP DEL ECUADOR S.A.")
                                        {
                                            documentType = "S";
                                            receiptCode = "009";
                                            cellarCode = "0003";
                                            costCenter = "0610";
                                        }
                                        else
                                        {
                                            documentType = "H";
                                            receiptCode = "047";
                                            cellarCode = "0003";
                                            costCenter = "0610";
                                        }
                                    }
                                    else
                                    {
                                        documentType = "S";
                                        receiptCode = "010";
                                        cellarCode = "0003";
                                        costCenter = "0610";
                                    }
                                    break;
                            }

                            lstSiigoMovements.Add(new siigoMovements());

                            lstSiigoMovements[lstSiigoMovements.Count - 1].receiptType = documentType;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].receiptCode = receiptCode;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].completeReceiptType = documentType + receiptCode;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].productCode = productCode;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].documentDate = lstDiferentSalesMovements[pos][i].date.ToString("yyyyMMdd");
                            lstSiigoMovements[lstSiigoMovements.Count - 1].costCenter = costCenter;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].costSubCenter = costSubCenter;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].description = clsGlobal.FillWithSpaces(lstDiferentSalesMovements[pos][i].movement.Replace("á", "a").Replace("é", "e").Replace("í", "i").Replace("ó", "o").Replace("ú", "u"), 50).Substring(0, 50);
                            lstSiigoMovements[lstSiigoMovements.Count - 1].creditDebit = movementType;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].cellarCode = cellarCode;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].quantity = quantity;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].orderNumber = lstDiferentSalesMovements[pos][i].order;
                        }
                        if (lstDiferentSalesMovements[pos][i].oppweigth > 0)
                        {
                            string documentType = "";
                            string receiptCode = "";
                            string productCode = "";
                            string costCenter = "0500";
                            string costSubCenter = "001";
                            string movementType = "";
                            string cellarCode = "";
                            string quantity = clsGlobal.FillWithZeros((Math.Round(lstDiferentSalesMovements[pos][i].oppweigth, 2) * 100000).ToString(), 15);

                            productCode = clsGlobal.FillWithZeros(clsProduct.getExternalERPDescriptionExternalCode(new clsProduct(lstDiferentSalesMovements[pos][i].producto)), 13);
                            movementType = "C";

                            clsSalesOrder objSalesOrder = clsSalesOrder.getDetailByNumber(lstDiferentSalesMovements[pos][i].order);

                            if (objSalesOrder.EntityName.ToUpper() != "BOPP DEL ECUADOR S.A.")
                            {
                                if (lstDiferentSalesMovements[pos][i].producto.StartsWith("B"))
                                {
                                    documentType = "S";
                                    receiptCode = "025";
                                    cellarCode = "0018";
                                    costCenter = "0610";
                                }
                                else if (lstDiferentSalesMovements[pos][i].producto.StartsWith("M"))
                                {
                                    documentType = "S";
                                    receiptCode = "008";
                                    cellarCode = "0018";
                                    costCenter = "0610";
                                }
                                else
                                {
                                    documentType = "S";
                                    receiptCode = "025";
                                    cellarCode = "0018";
                                    costCenter = "0610";

                                }
                            }
                            else
                            {
                                if (lstDiferentSalesMovements[pos][i].producto.StartsWith("B"))
                                {
                                    documentType = "S";
                                    receiptCode = "023";
                                    cellarCode = "0018";
                                    costCenter = "0610";
                                }
                                else if (lstDiferentSalesMovements[pos][i].producto.StartsWith("M"))
                                {
                                    documentType = "S";
                                    receiptCode = "008";
                                    cellarCode = "0018";
                                    costCenter = "0610";
                                }
                                else
                                {
                                    documentType = "S";
                                    receiptCode = "023";
                                    cellarCode = "0018";
                                    costCenter = "0610";
                                }
                            }

                            lstSiigoMovements.Add(new siigoMovements());

                            lstSiigoMovements[lstSiigoMovements.Count - 1].receiptType = documentType;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].receiptCode = receiptCode;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].completeReceiptType = documentType + receiptCode;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].productCode = productCode;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].documentDate = lstDiferentSalesMovements[pos][i].date.ToString("yyyyMMdd");
                            lstSiigoMovements[lstSiigoMovements.Count - 1].costCenter = costCenter;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].costSubCenter = costSubCenter;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].description = clsGlobal.FillWithSpaces(lstDiferentSalesMovements[pos][i].movement, 50).Substring(0, 50);
                            lstSiigoMovements[lstSiigoMovements.Count - 1].creditDebit = movementType;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].cellarCode = cellarCode;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].quantity = quantity;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].orderNumber = lstDiferentSalesMovements[pos][i].order;
                        }
                    }

                    //lstSiigoMovements.Sort();

                }


                string actualMovement = "";
                string actualNumber = "";
                int movementSequential = 0;
                actualMovementNumber = 0;
                bool useSameNumber = false;

                for (int i = 0; i < lstSiigoMovements.Count; i++)
                {
                    if (lstSiigoMovements[i].orderNumber != actualNumber)
                    {
                        actualMovement = lstSiigoMovements[i].completeReceiptType;
                        actualNumber = lstSiigoMovements[i].orderNumber;
                        movementSequential = 1;
                        useSameNumber = false;
                    }
                    else
                    {
                        if (lstSiigoMovements[i].orderNumber == actualNumber && lstSiigoMovements[i].completeReceiptType != actualMovement)
                        {
                            actualMovement = lstSiigoMovements[i].completeReceiptType;
                            actualNumber = lstSiigoMovements[i].orderNumber;
                            movementSequential = 1;
                            useSameNumber = false;
                        }
                        else
                        {
                            movementSequential = movementSequential + 1;
                            useSameNumber = true;
                        }
                    }

                    lstSiigoMovements[i].receiptSequence = clsGlobal.FillWithZeros(movementSequential.ToString(), 5);

                    if (useSameNumber == false)
                    {
                        switch (actualMovement)
                        {
                            case "S006":
                                actualMovementNumber = S006;
                                S006++;
                                changeS006 = true;
                                break;
                            case "S008":
                                actualMovementNumber = S008;
                                S008++;
                                changeS008 = true;
                                break;
                            case "S009":
                                actualMovementNumber = S009;
                                S009++;
                                changeS009 = true;
                                break;
                            case "S010":
                                actualMovementNumber = S010;
                                S010++;
                                changeS010 = true;
                                break;
                            case "S023":
                                actualMovementNumber = S023;
                                S023++;
                                changeS023 = true;
                                break;
                            case "S025":
                                actualMovementNumber = S025;
                                S025++;
                                changeS025 = true;
                                break;
                        }
                    }
                    lstSiigoMovements[i].receiptNumber = clsGlobal.FillWithZeros(actualMovementNumber.ToString(), 11);
                }

                for (int i = 0; i < lstSiigoMovements.Count; i++)
                {
                    //FILE ONE
                    strFileOne += lstSiigoMovements[i].receiptType;  			//01   001  001	TIPO DE COMPROBANTE:  1 posicin alfanum	
                    strFileOne += lstSiigoMovements[i].receiptCode;  			//03   002  004	CDIGO COMPROBANTE:  3 posiciones numricas	
                    strFileOne += lstSiigoMovements[i].receiptNumber;  			//11   005  015	NMERO DE DOCUMENTO:  11 posiciones numricas	
                    strFileOne += lstSiigoMovements[i].receiptSequence;  		//05   016  020	SECUENCIA:  5 posiciones numricas.  Mximo hasta 250	
                    strFileOne += lstSiigoMovements[i].receiptNIT;  			//13   021  033	NIT:  13 posiciones numricas	
                    strFileOne += lstSiigoMovements[i].subsidiary;  			//03   034  036	SUCURSAL:  3 posiciones numricas	
                    strFileOne += lstSiigoMovements[i].account;  			    //10   037  046	CUENTA CONTABLE:  10 posiciones numricas	
                    strFileOne += lstSiigoMovements[i].productCode;  			//13   047  059	CDIGO DE PRODUCTO:  13 posiciones numricas	
                    strFileOne += lstSiigoMovements[i].documentDate;  			//08   060  067	FECHA DEL DOCUMENTO:  8 posiciones numricas (AAAAMMDD)	
                    strFileOne += lstSiigoMovements[i].costCenter;  			//04   068  071	CENTRO DE COSTO:  4 posiciones numricas		
                    strFileOne += lstSiigoMovements[i].costSubCenter;  			//03   072  074	SUBCENTRO DE COSTO:  3 posiciones numricas	
                    strFileOne += lstSiigoMovements[i].description;  			//50   075  124	DESCRIPCIN DEL MOVIMIENTO:  50 posiciones alfanumricas, para comentario o detalle del movimiento	
                    strFileOne += lstSiigoMovements[i].creditDebit;  			//01   125  125	DBITO O CRDITO:  1 posicin alfanumrica.  Valor D  C	
                    strFileOne += lstSiigoMovements[i].value;  			        //15   126  140	VALOR DEL MOVIMIENTO:  15 posiciones numricas, 13 enteros, 2 decimales	
                    strFileOne += lstSiigoMovements[i].retentionBase;  			//15   141  155	BASE DE RETENCIN:  15 posiciones numricas, 13 enteros, 2 decimales	
                    strFileOne += lstSiigoMovements[i].sellerCode;  			//04   156  159	CDIGO DEL VENDEDOR:  4 posiciones numricas	
                    strFileOne += lstSiigoMovements[i].cityCode;  			    //04   160  163	CDIGO DE LA CIUDAD:  4 posiciones numricas	
                    strFileOne += lstSiigoMovements[i].zoneCode;  			    //03   164  166	CDIGO DE LA ZONA:  3 posiciones numricas	
                    strFileOne += lstSiigoMovements[i].cellarCode;  			//04   167  170	CDIGO DE LA BODEGA:  4 posiciones numricas	
                    strFileOne += lstSiigoMovements[i].locationCode;  			//03   171  173	CDIGO DE LA UBICACIN:  3 posiciones numricas	
                    strFileOne += lstSiigoMovements[i].quantity;  			    //15   174  188	CANTIDAD:  15 posiciones numricas, 10 enteros, 5 decimales	
                    strFileOne += lstSiigoMovements[i].crossDocumentType;  		//01   189  189	TIPO DE DOCUMENTO CRUCE:  1 posicin alfanumrica 	
                    strFileOne += lstSiigoMovements[i].crossDocumentCode;  		//03   190  192	CDIGO COMPROBANTE CRUCE:  3 posiciones alfanumricas, diferentes a espacios	
                    strFileOne += lstSiigoMovements[i].crossDocumentNumber;		//11   193  203   NMERO DE DOCUMENTO CRUCE:  11 posiciones numricas		
                    strFileOne += lstSiigoMovements[i].crossDocumentSequence;  	//03   204  206	SECUENCIA DEL DOCUMENTO CRUCE:  3 posiciones numricas.  Secuencia del documento cruce, mximo hasta 250	
                    strFileOne += lstSiigoMovements[i].crossDocumentDate;  		//08   207  214	FECHA VENCIMIENTO DE DOCUMENTO CRUCE:  8 posiciones numricas (AAAAMMDD)	
                    strFileOne += lstSiigoMovements[i].paymentTypeCode;  		//04   215  218	CDIGO FORMA DE PAGO:  4 posiciones numricas, solo se utilizan tres el primer digito debe ser cero.	
                    strFileOne += lstSiigoMovements[i].bankCode;  			    //02   219  220	CDIGO DEL BANCO:  2 posiciones numricas	                    
                    strFileOne += "\r\n";
                }
                fileName = folderPath + "\\mov" + DateTime.Now.ToString("yyyyMMddHHmm") + ".txt";

                FileStream fs = File.Open(fileName, FileMode.CreateNew, FileAccess.Write);

                StreamWriter sw = new StreamWriter(fs);

                sw.Write(strFileOne);
                sw.Close();
                fs.Close();

                if (changeS006 == true)
                    clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S006 = " + (S006).ToString() + ";");
                if (changeS008 == true)
                    clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S008 = " + (S008).ToString() + ";");
                if (changeS009 == true)
                    clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S009 = " + (S009).ToString() + ";");
                if (changeS010 == true)
                    clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S010 = " + (S010).ToString() + ";");
                if (changeS023 == true)
                    clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S023 = " + (S023).ToString() + ";");
                if (changeS025 == true)
                    clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S025 = " + (S025).ToString() + ";");

            }
            catch (Exception)
            {

                throw;
            }


            return true;
        }

        public static bool exportCellarMovementsToSiigo(List<clsPalletbyCoilCellar> lstPalletMovement, string folderPath)
        {
            string strFileOne = "";
            string fileName = "";
            string strActualMovement = "";
            int actualMovementNumber = 0;
            int actualMovementSeq = 0;

            bool changeE23Seq = false;
            bool changeE10Seq = false;
            bool changeE43Seq = false;
            bool changeE22Seq = false;
            bool changeS06Seq = false;
            bool changeH14Seq = false;
            bool changeH23Seq = false;
            bool changeH22Seq = false;

            try
            {
                DataSet DS = clsConnection.getDataSetResult("SELECT * FROM bps_xtr_siigoMovementsSequential");

                if (lstPalletMovement.Count > 0)
                {
                    strActualMovement = lstPalletMovement[0].movement;
                    actualMovementSeq = 0;

                    for (int i = 0; i < lstPalletMovement.Count; i++)
                    {
                        if (lstPalletMovement[i].movement != strActualMovement)
                        {
                            actualMovementSeq = 1;
                            strActualMovement = lstPalletMovement[i].movement;
                        }
                        else
                        {
                            actualMovementSeq++;
                        }

                        string documentType = "";
                        string receiptCode = "";
                        string productCode = "";
                        string costCenter = "0500";
                        string costSubCenter = "001";
                        string movementType = "";
                        string cellarCode = "";
                        string quantity = clsGlobal.FillWithZeros((Math.Round(lstPalletMovement[i].netweigth, 2) * 10000).ToString(), 15);

                        clsPallet objPallet = new clsPallet(lstPalletMovement[i].fkpallet);

                        objPallet.product.Bopp = new clsBopp(objPallet.product.fkBopp);
                        objPallet.product.Cast = new clsCast(objPallet.product.fkCast);

                        //bool isExternalCoil = false;
                        double externalWeight = 0;
                        double localWeight = 0;

                        int externalCoilCount = 0;
                        for (int j = 0; j < objPallet.lstCoil.Count; j++)
                        {
                            if (objPallet.lstCoil[j].isExternalCoil)
                                externalCoilCount++;
                        }
                        //if (externalCoilCount >= Math.Ceiling(Convert.ToDouble(objPallet.lstCoil.Count) / 2))
                        //    isExternalCoil = true;

                        productCode = clsGlobal.FillWithZeros(clsProduct.getExternalERPCode(objPallet.product), 13);

                        if (lstPalletMovement[i].ingress == true)
                        {
                            documentType = "E";
                            movementType = "D";

                            switch (lstPalletMovement[i].fkcoilcellar)
                            {
                                case 3:
                                    if (objPallet.product.code.StartsWith("M"))
                                    {
                                        receiptCode = "023";
                                        cellarCode = "0018";
                                        actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E23"]);
                                        changeE23Seq = true;
                                    }
                                    else
                                    {
                                        receiptCode = "010";
                                        cellarCode = "0003";
                                        actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E10"]);
                                        changeE10Seq = true;
                                    }
                                    break;
                                case 4:
                                    if (objPallet.product.code.StartsWith("M"))
                                    {
                                        receiptCode = "023";
                                        cellarCode = "0018";
                                        actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E23"]);
                                        changeE23Seq = true;
                                    }
                                    else
                                    {
                                        receiptCode = "043";
                                        cellarCode = "0023";
                                        actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E43"]);
                                        changeE43Seq = true;
                                    }
                                    break;
                                case 8:
                                    if (objPallet.product.code.StartsWith("M"))
                                    {
                                        receiptCode = "023";
                                        cellarCode = "0018";
                                        actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E23"]);
                                        changeE23Seq = true;
                                    }
                                    else
                                    {
                                        receiptCode = "022";
                                        cellarCode = "0018";
                                        actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E22"]);
                                        changeE22Seq = true;
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            movementType = "C";

                            switch (lstPalletMovement[i].movement)
                            {
                                case "Salida a bodega de proceso":
                                    switch (lstPalletMovement[i].fkcoilcellar)
                                    {
                                        case 3:
                                            if (objPallet.product.code.StartsWith("M"))
                                            {
                                                documentType = "S";
                                                receiptCode = "006";
                                                cellarCode = "0018";
                                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S06"]);
                                                changeS06Seq = true;
                                            }
                                            else
                                            {
                                                documentType = "H";
                                                receiptCode = "014";
                                                cellarCode = "0003";
                                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H14"]);
                                                changeH14Seq = true;
                                            }
                                            break;
                                        case 4:
                                            if (objPallet.product.code.StartsWith("M"))
                                            {
                                                documentType = "S";
                                                receiptCode = "006";
                                                cellarCode = "0018";
                                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S06"]);
                                                changeS06Seq = true;
                                            }
                                            else
                                            {
                                                documentType = "H";
                                                receiptCode = "023";
                                                cellarCode = "0023";
                                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H23"]);
                                                changeH23Seq = true;
                                            }
                                            break;
                                        case 8:
                                            if (objPallet.product.code.StartsWith("M"))
                                            {
                                                documentType = "S";
                                                receiptCode = "006";
                                                cellarCode = "0018";
                                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S06"]);
                                                changeS06Seq = true;
                                            }
                                            else
                                            {
                                                documentType = "H";
                                                receiptCode = "022";
                                                cellarCode = "0018";
                                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H22"]);
                                                changeH22Seq = true;
                                            }
                                            break;
                                    }
                                    break;
                                case "Salida a bodega de base para metalizar":
                                    switch (lstPalletMovement[i].fkcoilcellar)
                                    {
                                        case 3:
                                            if (objPallet.product.code.StartsWith("M"))
                                            {
                                                documentType = "S";
                                                receiptCode = "006";
                                                cellarCode = "0018";
                                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S06"]);
                                                changeS06Seq = true;
                                            }
                                            else
                                            {
                                                documentType = "H";
                                                receiptCode = "014";
                                                cellarCode = "0003";
                                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H14"]);
                                                changeH14Seq = true;
                                            }
                                            break;
                                        case 4:
                                            if (objPallet.product.code.StartsWith("M"))
                                            {
                                                documentType = "S";
                                                receiptCode = "006";
                                                cellarCode = "0018";
                                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S06"]);
                                                changeS06Seq = true;
                                            }
                                            else
                                            {
                                                documentType = "H";
                                                receiptCode = "023";
                                                cellarCode = "0023";
                                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H23"]);
                                                changeH23Seq = true;
                                            }
                                            break;
                                        case 8:
                                            if (objPallet.product.code.StartsWith("M"))
                                            {
                                                documentType = "S";
                                                receiptCode = "006";
                                                cellarCode = "0018";
                                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S06"]);
                                                changeS06Seq = true;
                                            }
                                            else
                                            {
                                                documentType = "H";
                                                receiptCode = "022";
                                                cellarCode = "0018";
                                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H22"]);
                                                changeH22Seq = true;
                                            }
                                            break;
                                    }
                                    break;
                                case "Despacho de mercadería":
                                    clsSalesOrder objSalesOrder = new clsSalesOrder(objPallet.fkSalesOrder);

                                    switch (lstPalletMovement[i].fkcoilcellar)
                                    {
                                        case 3:
                                            if (objSalesOrder.isInternationalSale == false)
                                            {
                                                if (localWeight > 0 && externalWeight == 0)
                                                {
                                                    documentType = "S";
                                                    receiptCode = "009";
                                                    cellarCode = "0003";
                                                    costCenter = "0610";
                                                    actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S09"]);
                                                    changeS06Seq = true;
                                                }
                                                else if (localWeight == 0 && externalWeight > 0)
                                                {
                                                    documentType = "S";
                                                    receiptCode = "025";
                                                    cellarCode = "0003";
                                                    costCenter = "0610";
                                                    actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S25"]);
                                                    changeS06Seq = true;
                                                }
                                            }
                                            else
                                            {
                                                documentType = "S";
                                                receiptCode = "010";
                                                cellarCode = "0003";
                                                costCenter = "0610";
                                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S09"]);
                                                changeS06Seq = true;
                                            }
                                            break;
                                    }
                                    break;
                                case "Salida de bodega de bajas":
                                    switch (lstPalletMovement[i].fkcoilcellar)
                                    {
                                        case 3:
                                            if (objPallet.product.code.StartsWith("M"))
                                            {
                                                documentType = "S";
                                                receiptCode = "006";
                                                cellarCode = "0018";
                                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S06"]);
                                                changeS06Seq = true;
                                            }
                                            else
                                            {
                                                documentType = "H";
                                                receiptCode = "014";
                                                cellarCode = "0003";
                                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H14"]);
                                                changeH14Seq = true;
                                            }
                                            break;
                                        case 4:
                                            if (objPallet.product.code.StartsWith("M"))
                                            {
                                                documentType = "S";
                                                receiptCode = "006";
                                                cellarCode = "0018";
                                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S06"]);
                                                changeS06Seq = true;
                                            }
                                            else
                                            {
                                                documentType = "H";
                                                receiptCode = "023";
                                                cellarCode = "0023";
                                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H23"]);
                                                changeH23Seq = true;
                                            }
                                            break;
                                        case 8:
                                            if (objPallet.product.code.StartsWith("M"))
                                            {
                                                documentType = "S";
                                                receiptCode = "006";
                                                cellarCode = "0018";
                                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S06"]);
                                                changeS06Seq = true;
                                            }
                                            else
                                            {
                                                documentType = "H";
                                                receiptCode = "022";
                                                cellarCode = "0018";
                                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H22"]);
                                                changeH22Seq = true;
                                            }
                                            break;
                                    }
                                    break;
                            }
                        }


                        //FILE ONE
                        strFileOne += documentType;                                                                         //* 01   001 – 001	TIPO DE COMPROBANTE:  1 posición alfanumérica
                        strFileOne += receiptCode;                                                                          //* 03   002 – 004	CÓDIGO COMPROBANTE:  3 posiciones numéricas
                        strFileOne += clsGlobal.FillWithZeros(actualMovementNumber.ToString(), 11);                         // 11   005 – 015	NÚMERO DE DOCUMENTO:  11 posiciones numéricas
                        strFileOne += clsGlobal.FillWithZeros(actualMovementSeq.ToString(), 5);                             //* 05   016 – 020	SECUENCIA:  5 posiciones numéricas.  Máximo hasta 250
                        strFileOne += "1790663671001";                                                                      //* 13   021 – 033	NIT:  13 posiciones numéricas
                        strFileOne += "001";                                                                                //* 03   034 – 036	SUCURSAL:  3 posiciones numéricas
                        strFileOne += "1005050100";                                                                         // 10   037 – 046	CUENTA CONTABLE:  10 posiciones numéricas
                        strFileOne += productCode;                                                                          //* 13   047 – 059	CÓDIGO DE PRODUCTO:  13 posiciones numéricas
                        strFileOne += lstPalletMovement[i].date.ToString("yyyyMMdd");                                       //* 08   060 – 067	FECHA DEL DOCUMENTO:  8 posiciones numéricas (AAAAMMDD)
                        strFileOne += costCenter;                                                                           //* 04   068 – 071	CENTRO DE COSTO:  4 posiciones numéricas
                        strFileOne += costSubCenter;                                                                        //* 03   072 – 074	SUBCENTRO DE COSTO:  3 posiciones numéricas
                        strFileOne += clsGlobal.FillWithSpaces(objPallet.code + " - " + lstPalletMovement[i].movement, 50).Substring(0, 50); //* 50   075 – 124	DESCRIPCIÓN DEL MOVIMIENTO:  50 posiciones alfanuméricas, para comentario o detalle del movimiento
                        strFileOne += movementType;                                                                         //* 01   125 – 125	DÉBITO O CRÉDITO:  1 posición alfanumérica.  Valor D ó C
                        strFileOne += "000000000000000";                                                                    //* 15   126 – 140	VALOR DEL MOVIMIENTO:  15 posiciones numéricas, 13 enteros, 2 decimales
                        strFileOne += "000000000000000";                                                                    //* 15   141 – 155	BASE DE RETENCIÓN:  15 posiciones numéricas, 13 enteros, 2 decimales
                        strFileOne += "0000";                                                                               // 04   156 – 159	CÓDIGO DEL VENDEDOR:  4 posiciones numéricas
                        strFileOne += "0000";                                                                               // 04   160 – 163	CÓDIGO DE LA CIUDAD:  4 posiciones numéricas
                        strFileOne += "000";                                                                                // 03   164 – 166	CÓDIGO DE LA ZONA:  3 posiciones numéricas
                        strFileOne += cellarCode;                                                                           //* 04   167 – 170	CÓDIGO DE LA BODEGA:  4 posiciones numéricas
                        strFileOne += "000";                                                                                // 03   171 – 173	CÓDIGO DE LA UBICACIÓN:  3 posiciones numéricas
                        strFileOne += quantity;                                                                             //* 15   174 – 188	CANTIDAD:  15 posiciones numéricas, 10 enteros, 5 decimales
                        strFileOne += " ";                                                                                  // 01   189 – 189	TIPO DE DOCUMENTO CRUCE:  1 posición alfanumérica 
                        strFileOne += "---";                                                                                // 03   190 – 192	CÓDIGO COMPROBANTE CRUCE:  3 posiciones alfanuméricas, diferentes a espacios
                        strFileOne += "---";                                                                         // 11   193 – 203   NÚMERO DE DOCUMENTO CRUCE:  11 posiciones numéricas
                        strFileOne += "000";                                                                                // 03   204 – 206	SECUENCIA DEL DOCUMENTO CRUCE:  3 posiciones numéricas.  Secuencia del documento cruce, máximo hasta 250
                        strFileOne += "00000000";                                                                           // 08   207 – 214	FECHA VENCIMIENTO DE DOCUMENTO CRUCE:  8 posiciones numéricas (AAAAMMDD)
                        strFileOne += "0000";                                                                               // 04   215 – 218	CÓDIGO FORMA DE PAGO:  4 posiciones numéricas, solo se utilizan tres el primer digito debe ser cero.
                        strFileOne += "00";                                                                                 // 02   219 – 220	CÓDIGO DEL BANCO:  2 posiciones numéricas
                        strFileOne += "\r\n";
                    }

                    fileName = folderPath + "\\movimientos" + DateTime.Now.ToString("yyyyMMddHHmm") + ".txt";

                    FileStream fs = File.Open(fileName, FileMode.CreateNew, FileAccess.Write);

                    StreamWriter sw = new StreamWriter(fs);

                    sw.Write(strFileOne);
                    sw.Close();
                    fs.Close();

                    //for (int i = 0; i < lstPalletMovement.Count; i++)
                    //    clsConnection.executeQuery("UPDATE bps_com_salesOrder SET sord_exportedToERP = 1 WHERE sord_codsec = " + lstPalletMovement[i].codsec.ToString());

                    if (changeE23Seq == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E23 = sms_E23 + 1;");

                    if (changeE10Seq == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E10 = sms_E10 + 1;");

                    if (changeE43Seq == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E43 = sms_E43 + 1;");

                    if (changeE22Seq == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E22 = sms_E22 + 1;");

                    if (changeS06Seq == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S06 = sms_S06 + 1;");

                    if (changeH14Seq == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H14 = sms_H14 + 1;");

                    if (changeH23Seq == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H23 = sms_H23 + 1;");

                    if (changeH22Seq == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H22 = sms_H22 + 1;");



                    return true;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string exportCellar(List<clsPalletbyCoilCellar> lstPallet)
        {
            string cellarCode = "";

            try
            {
                for (int i = 0; i < lstPallet.Count; i++)
                {
                    if (lstPallet[i].localweigth > 0)
                    {
                        if (lstPallet[i].ingress == true)
                        {
                            switch (lstPallet[i].fkcoilcellar)
                            {
                                case 3:
                                    cellarCode = "0003";
                                    break;
                                case 4:
                                    cellarCode = "0023";
                                    break;
                                case 8:
                                    cellarCode = "0023";
                                    break;
                            }
                        }
                        else
                        {
                            switch (lstPallet[i].movement)
                            {
                                case "Salida a bodega de proceso":
                                    switch (lstPallet[i].fkcoilcellar)
                                    {
                                        case 3:
                                            cellarCode = "0003";
                                            break;
                                        case 4:
                                            cellarCode = "0023";
                                            break;
                                        case 8:
                                            cellarCode = "0023";
                                            break;
                                    }
                                    break;
                                case "Salida a bodega de base para metalizar":
                                    switch (lstPallet[i].fkcoilcellar)
                                    {
                                        case 3:
                                            cellarCode = "0003";
                                            break;
                                        case 4:
                                            cellarCode = "0023";
                                            break;
                                        case 8:
                                            cellarCode = "0023";
                                            break;
                                    }
                                    break;
                                case "Despacho de mercadería":
                                    clsSalesOrder objSalesOrder = clsSalesOrder.getDetailByNumberOnlySalesOrder(lstPallet[i].order);

                                    switch (lstPallet[i].fkcoilcellar)
                                    {
                                        case 1:
                                            if (objSalesOrder.isInternationalSale == false)
                                            {
                                                if (objSalesOrder.EntityName.ToUpper() != "BOPP DEL ECUADOR S.A.")
                                                {
                                                    cellarCode = "0003";
                                                }
                                                else
                                                {
                                                    cellarCode = "0003";
                                                }
                                            }
                                            else
                                            {
                                                cellarCode = "0003";
                                            }
                                            break;

                                        case 3:
                                            if (objSalesOrder.isInternationalSale == false)
                                            {
                                                if (objSalesOrder.EntityName.ToUpper() != "BOPP DEL ECUADOR S.A.")
                                                {
                                                    cellarCode = "0003";
                                                }
                                                else
                                                {
                                                    cellarCode = "0003";
                                                }
                                            }
                                            else
                                            {
                                                cellarCode = "0003";
                                            }
                                            break;
                                    }
                                    break;
                                case "Salida de bodega de bajas":
                                    switch (lstPallet[i].fkcoilcellar)
                                    {
                                        case 1:
                                            cellarCode = "0023";
                                            break;
                                        case 3:
                                            cellarCode = "0003";
                                            break;
                                        case 4:
                                            cellarCode = "0023";
                                            break;
                                        case 8:
                                            cellarCode = "0023";
                                            break;
                                    }
                                    break;
                            }
                        }
                    }
                    else if (lstPallet[i].oppweigth > 0)
                    {
                        if (lstPallet[i].ingress == true)
                        {
                            switch (lstPallet[i].fkcoilcellar)
                            {
                                case 3:
                                    cellarCode = "0018";
                                    break;
                                case 4:
                                    cellarCode = "0018";
                                    break;
                                case 8:
                                    cellarCode = "0018";
                                    break;
                                case 11:
                                    cellarCode = "0018";
                                    break;
                                case 12:
                                    cellarCode = "0018";
                                    break;
                            }
                        }
                        else
                        {
                            switch (lstPallet[i].movement)
                            {
                                case "Salida a bodega de proceso":
                                    switch (lstPallet[i].fkcoilcellar)
                                    {
                                        case 3:
                                            cellarCode = "0018";
                                            break;
                                        case 4:
                                            cellarCode = "0018";
                                            break;
                                        case 8:
                                            cellarCode = "0018";
                                            break;
                                        case 11:
                                            cellarCode = "0018";
                                            break;
                                        case 12:
                                            cellarCode = "0018";
                                            break;
                                    }
                                    break;
                                case "Salida a bodega de base para metalizar":
                                    switch (lstPallet[i].fkcoilcellar)
                                    {
                                        case 3:
                                            if (lstPallet[i].producto.StartsWith("B"))
                                            {
                                                cellarCode = "0018";
                                            }
                                            else
                                            {
                                                cellarCode = "0018";

                                            }
                                            break;
                                        case 4:
                                            if (lstPallet[i].producto.StartsWith("B"))
                                            {
                                                cellarCode = "0018";
                                            }
                                            else
                                            {
                                                cellarCode = "0018";

                                            }
                                            break;
                                        case 8:
                                            if (lstPallet[i].producto.StartsWith("B"))
                                            {
                                                cellarCode = "0018";
                                            }
                                            else
                                            {
                                                cellarCode = "0018";
                                            }
                                            break;
                                        case 9:
                                            if (lstPallet[i].producto.StartsWith("B"))
                                            {
                                                cellarCode = "0018";
                                            }
                                            else
                                            {
                                                cellarCode = "0018";
                                            }
                                            break;
                                    }
                                    break;
                                case "Despacho de mercadería":
                                    clsSalesOrder objSalesOrder = clsSalesOrder.getDetailByNumber(lstPallet[i].order);

                                    if (objSalesOrder.EntityName.ToUpper() != "BOPP DEL ECUADOR S.A.")
                                    {
                                        if (lstPallet[i].producto.StartsWith("B"))
                                        {
                                            cellarCode = "0018";
                                        }
                                        else if (lstPallet[i].producto.StartsWith("M"))
                                        {
                                            cellarCode = "0018";
                                        }
                                        else
                                        {
                                            cellarCode = "0018";
                                        }
                                    }
                                    else
                                    {
                                        if (lstPallet[i].producto.StartsWith("B"))
                                        {
                                            cellarCode = "0018";
                                        }
                                        else if (lstPallet[i].producto.StartsWith("M"))
                                        {
                                            cellarCode = "0018";
                                        }
                                        else
                                        {
                                            cellarCode = "0018";
                                        }
                                    }
                                    break;
                                case "Salida de bodega de bajas":
                                    switch (lstPallet[i].fkcoilcellar)
                                    {
                                        case 1:
                                            if (lstPallet[i].producto.StartsWith("B"))
                                            {
                                                cellarCode = "0018";
                                            }
                                            else if (lstPallet[i].producto.StartsWith("M"))
                                            {
                                                cellarCode = "0018";
                                            }
                                            else
                                            {
                                                cellarCode = "0018";
                                            }
                                            break;
                                        case 3:
                                            if (lstPallet[i].producto.StartsWith("B"))
                                            {
                                                cellarCode = "0018";
                                            }
                                            else if (lstPallet[i].producto.StartsWith("M"))
                                            {
                                                cellarCode = "0018";
                                            }
                                            else
                                            {
                                                cellarCode = "0018";
                                            }
                                            break;
                                        case 4:
                                            if (lstPallet[i].producto.StartsWith("B"))
                                            {
                                                cellarCode = "0018";
                                            }
                                            else if (lstPallet[i].producto.StartsWith("M"))
                                            {
                                                cellarCode = "0018";
                                            }
                                            else
                                            {
                                                cellarCode = "0018";

                                            }
                                            break;
                                        case 8:
                                            if (lstPallet[i].producto.StartsWith("B"))
                                            {
                                                cellarCode = "0018";
                                            }
                                            else if (lstPallet[i].producto.StartsWith("M"))
                                            {
                                                cellarCode = "0018";
                                            }
                                            else
                                            {
                                                cellarCode = "0018";
                                            }
                                            break;
                                    }
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                cellarCode = "Inconsistencia en Bodega";
                throw;
            }
            return cellarCode;
        }

        public static string movementCellar(List<clsPalletbyCoilCellar> lstPalletMovement)
        {
            string documentType = "";
            string receiptCode = "";

            try
            {
                for (int i = 0; i < lstPalletMovement.Count; i++)
                {
                    if (lstPalletMovement[i].localweigth > 0)
                    {
                        if (lstPalletMovement[i].ingress == true)
                        {
                            documentType = "E";

                            switch (lstPalletMovement[i].fkcoilcellar)
                            {
                                case 3:
                                    receiptCode = "010";
                                    break;
                                case 4:
                                    receiptCode = "043";
                                    break;
                                case 8:
                                    receiptCode = "043";
                                    break;
                            }
                        }
                        else
                        {
                            switch (lstPalletMovement[i].movement)
                            {
                                case "Salida a bodega de proceso":
                                    switch (lstPalletMovement[i].fkcoilcellar)
                                    {
                                        case 3:
                                            documentType = "H";
                                            receiptCode = "014";
                                            break;
                                        case 4:
                                            documentType = "H";
                                            receiptCode = "023";
                                            break;
                                        case 8:
                                            documentType = "H";
                                            receiptCode = "023";
                                            break;
                                    }
                                    break;
                                case "Salida a bodega de base para metalizar":
                                    switch (lstPalletMovement[i].fkcoilcellar)
                                    {
                                        case 3:
                                            documentType = "H";
                                            receiptCode = "014";
                                            break;
                                        case 4:
                                            documentType = "H";
                                            receiptCode = "023";
                                            break;
                                        case 8:
                                            documentType = "H";
                                            receiptCode = "023";
                                            break;
                                    }
                                    break;
                                case "Despacho de mercadería":
                                    clsSalesOrder objSalesOrder = clsSalesOrder.getDetailByNumberOnlySalesOrder(lstPalletMovement[i].order);

                                    switch (lstPalletMovement[i].fkcoilcellar)
                                    {
                                        case 1:
                                            if (objSalesOrder.isInternationalSale == false)
                                            {
                                                if (objSalesOrder.fkEntity == 119 || objSalesOrder.fkEntity == 173)
                                                {
                                                    documentType = "H";
                                                    receiptCode = "047";
                                                }
                                                else
                                                {
                                                    documentType = "S";
                                                    receiptCode = "009";
                                                }
                                            }
                                            else
                                            {
                                                documentType = "S";
                                                receiptCode = "010";
                                            }
                                            break;

                                        case 3:
                                            if (objSalesOrder.isInternationalSale == false)
                                            {
                                                if (objSalesOrder.fkEntity == 119 || objSalesOrder.fkEntity == 173)
                                                {
                                                    documentType = "H";
                                                    receiptCode = "047";
                                                }
                                                else
                                                {
                                                    documentType = "S";
                                                    receiptCode = "009";
                                                }
                                            }
                                            else
                                            {
                                                documentType = "S";
                                                receiptCode = "010";
                                            }
                                            break;
                                    }
                                    break;
                                case "Salida de bodega de bajas":
                                    switch (lstPalletMovement[i].fkcoilcellar)
                                    {
                                        case 1:
                                            documentType = "H";
                                            receiptCode = "023";
                                            break;
                                        case 3:
                                            documentType = "H";
                                            receiptCode = "014";
                                            break;
                                        case 4:
                                            documentType = "H";
                                            receiptCode = "023";
                                            break;
                                        case 8:
                                            documentType = "H";
                                            receiptCode = "023";
                                            break;
                                    }
                                    break;
                            }
                        }
                    }

                    if (lstPalletMovement[i].oppweigth > 0)
                    {
                        if (lstPalletMovement[i].ingress == true)
                        {
                            documentType = "E";

                            switch (lstPalletMovement[i].fkcoilcellar)
                            {
                                case 3:
                                    if (lstPalletMovement[i].isImport == 0)
                                    {
                                        if (lstPalletMovement[i].producto.StartsWith("M"))
                                            receiptCode = "023";
                                        else
                                            receiptCode = "022";
                                    }
                                    else
                                        receiptCode = "021";
                                    break;
                                case 4:
                                    if (lstPalletMovement[i].producto.StartsWith("M"))
                                        receiptCode = "023";
                                    else
                                        receiptCode = "022";
                                    break;

                                case 8:
                                    if (lstPalletMovement[i].isImport == 0)
                                    {
                                        if (lstPalletMovement[i].producto.StartsWith("M"))
                                            receiptCode = "023";
                                        else
                                            receiptCode = "022";
                                    }
                                    else
                                        receiptCode = "021";

                                    break;
                                case 11:
                                    if (lstPalletMovement[i].isImport == 0)
                                    {
                                        if (lstPalletMovement[i].producto.StartsWith("M"))
                                            receiptCode = "023";
                                        else
                                            receiptCode = "022";
                                    }
                                    else
                                        receiptCode = "021";

                                    break;

                                case 12:
                                    if (lstPalletMovement[i].isImport == 0)
                                    {
                                        if (lstPalletMovement[i].producto.StartsWith("M"))
                                            receiptCode = "023";
                                        else
                                            receiptCode = "022";
                                    }
                                    else
                                        receiptCode = "021";

                                    break;
                            }
                        }
                        else
                        {
                            switch (lstPalletMovement[i].movement)
                            {
                                case "Salida a bodega de proceso":
                                    switch (lstPalletMovement[i].fkcoilcellar)
                                    {
                                        case 3:
                                            documentType = "H";
                                            receiptCode = "022";
                                            break;
                                        case 4:
                                            documentType = "H";
                                            receiptCode = "022";
                                            break;
                                        case 8:
                                            documentType = "H";
                                            receiptCode = "022";
                                            break;
                                        case 11:
                                            documentType = "H";
                                            receiptCode = "022";
                                            break;
                                        case 12:
                                            documentType = "H";
                                            receiptCode = "022";
                                            break;
                                    }
                                    break;
                                case "Salida a bodega de base para metalizar":
                                    switch (lstPalletMovement[i].fkcoilcellar)
                                    {
                                        case 3:
                                            if (lstPalletMovement[i].producto.StartsWith("B"))
                                            {
                                                documentType = "S";
                                                receiptCode = "006";
                                            }
                                            else
                                            {
                                                documentType = "S";
                                                receiptCode = "006";
                                            }
                                            break;
                                        case 4:
                                            if (lstPalletMovement[i].producto.StartsWith("B"))
                                            {
                                                documentType = "S";
                                                receiptCode = "006";
                                            }
                                            else
                                            {
                                                documentType = "S";
                                                receiptCode = "006";
                                            }
                                            break;
                                        case 8:
                                            if (lstPalletMovement[i].producto.StartsWith("B"))
                                            {
                                                documentType = "S";
                                                receiptCode = "006";
                                            }
                                            else
                                            {
                                                documentType = "S";
                                                receiptCode = "006";
                                            }
                                            break;
                                        case 9:
                                            if (lstPalletMovement[i].producto.StartsWith("B"))
                                            {
                                                documentType = "S";
                                                receiptCode = "006";
                                            }
                                            else
                                            {
                                                documentType = "S";
                                                receiptCode = "006";
                                            }
                                            break;
                                    }
                                    break;
                                case "Despacho de mercadería":
                                    clsSalesOrder objSalesOrder = clsSalesOrder.getDetailByNumberOnlySalesOrder(lstPalletMovement[i].order);

                                    if (objSalesOrder.EntityName.ToUpper() != "BOPP DEL ECUADOR S.A." || objSalesOrder.EntityName.ToUpper() != "BOPPDELECUADOR" || objSalesOrder.EntityName.ToUpper() != "BOPP DEL ECUADOR")
                                    {
                                        if (!objSalesOrder.isInternationalSale)
                                        {
                                            if (lstPalletMovement[i].producto.StartsWith("B"))
                                            {
                                                documentType = "S";
                                                receiptCode = "009";
                                            }
                                            else if (lstPalletMovement[i].producto.StartsWith("M"))
                                            {
                                                documentType = "S";
                                                receiptCode = "009";
                                            }
                                            else
                                            {
                                                documentType = "S";
                                                receiptCode = "009";
                                            }
                                        }
                                        else
                                        {
                                            if (lstPalletMovement[i].producto.StartsWith("B"))
                                            {
                                                documentType = "S";
                                                receiptCode = "010";
                                            }
                                            else if (lstPalletMovement[i].producto.StartsWith("M"))
                                            {
                                                documentType = "S";
                                                receiptCode = "008";
                                            }
                                            else
                                            {
                                                documentType = "S";
                                                receiptCode = "010";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (!objSalesOrder.isInternationalSale)
                                        {
                                            if (lstPalletMovement[i].producto.StartsWith("B"))
                                            {
                                                documentType = "S";
                                                receiptCode = "023";
                                            }
                                            else if (lstPalletMovement[i].producto.StartsWith("M"))
                                            {
                                                documentType = "S";
                                                receiptCode = "023";
                                            }
                                            else
                                            {
                                                documentType = "S";
                                                receiptCode = "023";
                                            }
                                        }
                                        else
                                        {
                                            if (lstPalletMovement[i].producto.StartsWith("B"))
                                            {
                                                documentType = "S";
                                                receiptCode = "000";
                                            }
                                            else if (lstPalletMovement[i].producto.StartsWith("M"))
                                            {
                                                documentType = "S";
                                                receiptCode = "000";
                                            }
                                            else
                                            {
                                                documentType = "S";
                                                receiptCode = "000";
                                            }
                                        }
                                    }
                                    break;
                                case "Salida de bodega de bajas":
                                    switch (lstPalletMovement[i].fkcoilcellar)
                                    {
                                        case 1:
                                            if (lstPalletMovement[i].producto.StartsWith("B"))
                                            {
                                                documentType = "H";
                                                receiptCode = "022";
                                            }
                                            else if (lstPalletMovement[i].producto.StartsWith("M"))
                                            {
                                                documentType = "H";
                                                receiptCode = "022";
                                            }
                                            else
                                            {
                                                documentType = "H";
                                                receiptCode = "022";
                                            }
                                            break;
                                        case 3:
                                            if (lstPalletMovement[i].producto.StartsWith("B"))
                                            {
                                                documentType = "H";
                                                receiptCode = "022";
                                            }
                                            else if (lstPalletMovement[i].producto.StartsWith("M"))
                                            {
                                                documentType = "H";
                                                receiptCode = "022";
                                            }
                                            else
                                            {
                                                documentType = "H";
                                                receiptCode = "022";
                                            }
                                            break;
                                        case 4:
                                            if (lstPalletMovement[i].producto.StartsWith("B"))
                                            {
                                                documentType = "H";
                                                receiptCode = "022";
                                            }
                                            else if (lstPalletMovement[i].producto.StartsWith("M"))
                                            {
                                                documentType = "H";
                                                receiptCode = "022";
                                            }
                                            else
                                            {
                                                documentType = "H";
                                                receiptCode = "022";
                                            }
                                            break;
                                        case 8:
                                            if (lstPalletMovement[i].producto.StartsWith("B"))
                                            {
                                                documentType = "H";
                                                receiptCode = "022";
                                            }
                                            else if (lstPalletMovement[i].producto.StartsWith("M"))
                                            {
                                                documentType = "H";
                                                receiptCode = "022";
                                            }
                                            else
                                            {
                                                documentType = "H";
                                                receiptCode = "022";
                                            }
                                            break;
                                    }
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                return "Inconsistencia Movimiento";
                throw;
            }
            return documentType + receiptCode;
        }

        public static string codeCellar(List<clsPalletbyCoilCellar> lstPalletMovement)
        {
            string productCode = "";

            try
            {
                for (int i = 0; i < lstPalletMovement.Count; i++)
                {
                    if (lstPalletMovement[i].localweigth > 0)
                    {
                        productCode = clsGlobal.FillWithZeros(clsProduct.getExternalERPDescriptionNationalCode(new clsProduct(lstPalletMovement[i].producto)), 13);

                        if (lstPalletMovement[i].ingress == true)
                        {
                            switch (lstPalletMovement[i].fkcoilcellar)
                            {
                                case 4:
                                    productCode = clsGlobal.FillWithZeros(clsProduct.getExternalERPDescriptionStockCode(new clsProduct(lstPalletMovement[i].producto)), 13);
                                    break;
                                case 8:
                                    productCode = clsGlobal.FillWithZeros(clsProduct.getExternalERPDescriptionStockCode(new clsProduct(lstPalletMovement[i].producto)), 13);
                                    break;
                            }
                        }
                        else
                        {
                            switch (lstPalletMovement[i].movement)
                            {
                                case "Salida a bodega de proceso":
                                    switch (lstPalletMovement[i].fkcoilcellar)
                                    {
                                        case 4:
                                            productCode = clsGlobal.FillWithZeros(clsProduct.getExternalERPDescriptionStockCode(new clsProduct(lstPalletMovement[i].producto)), 13);
                                            break;
                                        case 8:
                                            productCode = clsGlobal.FillWithZeros(clsProduct.getExternalERPDescriptionStockCode(new clsProduct(lstPalletMovement[i].producto)), 13);
                                            break;
                                    }
                                    break;
                                case "Salida a bodega de base para metalizar":
                                    switch (lstPalletMovement[i].fkcoilcellar)
                                    {
                                        case 4:
                                            productCode = clsGlobal.FillWithZeros(clsProduct.getExternalERPDescriptionStockCode(new clsProduct(lstPalletMovement[i].producto)), 13);
                                            break;
                                        case 8:
                                            productCode = clsGlobal.FillWithZeros(clsProduct.getExternalERPDescriptionStockCode(new clsProduct(lstPalletMovement[i].producto)), 13);
                                            break;
                                    }
                                    break;
                                case "Salida de bodega de bajas":
                                    switch (lstPalletMovement[i].fkcoilcellar)
                                    {
                                        case 4:
                                            productCode = clsGlobal.FillWithZeros(clsProduct.getExternalERPDescriptionStockCode(new clsProduct(lstPalletMovement[i].producto)), 13);
                                            break;
                                        case 8:
                                            productCode = clsGlobal.FillWithZeros(clsProduct.getExternalERPDescriptionStockCode(new clsProduct(lstPalletMovement[i].producto)), 13);
                                            break;
                                    }
                                    break;
                                case "Despacho de mercadería":
                                    switch (lstPalletMovement[i].fkcoilcellar)
                                    {
                                        case 1:
                                            productCode = clsGlobal.FillWithZeros(clsProduct.getExternalERPDescriptionStockCode(new clsProduct(lstPalletMovement[i].producto)), 13);
                                            break;
                                        case 4:
                                            productCode = clsGlobal.FillWithZeros(clsProduct.getExternalERPDescriptionStockCode(new clsProduct(lstPalletMovement[i].producto)), 13);
                                            break;
                                        case 8:
                                            productCode = clsGlobal.FillWithZeros(clsProduct.getExternalERPDescriptionStockCode(new clsProduct(lstPalletMovement[i].producto)), 13);
                                            break;
                                    }
                                    break;
                            }
                        }
                    }
                    if (lstPalletMovement[i].oppweigth > 0)
                        productCode = clsGlobal.FillWithZeros(clsProduct.getExternalERPDescriptionExternalCode(new clsProduct(lstPalletMovement[i].producto)), 13);
                }
            }
            catch (Exception)
            {
                productCode = "0000000000000";
            }
            return productCode;
        }

        public static string ReferenceCellar(string code)
        {
            string productRef = "";

            try
            {
                DataSet DS = new DataSet();
                DS = clsConnection.getDataSetResult("SELECT * FROM bps_xtr_filmequivalence WHERE feq_externalId = '" + code + "'");
                if (DS.Tables[0].Rows.Count > 0)
                    productRef = DS.Tables[0].Rows[0]["feq_externalCode"].ToString();
                else
                    productRef = "Code no encontrado";
            }
            catch (Exception)
            {
                productRef = "Error Ref";
            }
            return productRef;
        }

        public static bool exportReturnMovementsToSiigo(List<clsReturn> lstPalletMovement, string folderPath, int a)
        {
            string strFileOne = "";
            string fileName = "";
            int actualMovementNumber = 0;

            bool changeE001 = false;
            bool changeE010 = false;
            bool changeE011 = false;
            bool changeE012 = false;
            bool changeE021 = false;
            bool changeE022 = false;
            bool changeE043 = false;
            bool changeH013 = false;
            bool changeH014 = false;
            bool changeH022 = false;
            bool changeH023 = false;
            bool changeH047 = false;
            bool changeS006 = false;
            bool changeS008 = false;
            bool changeS009 = false;
            bool changeS010 = false;
            bool changeS014 = false;
            bool changeS023 = false;
            bool changeS025 = false;

            try
            {
                if (a == 1)
                {
                    DataSet DS = clsConnection.getDataSetResult("SELECT * FROM bps_xtr_siigoMovementsSequential");
                    List<siigoMovements> lstSiigoMovements = new List<siigoMovements>();

                    for (int i = 0; i < lstPalletMovement.Count; i++)
                    {
                        string documentType = "";
                        string receiptCode = "";
                        string productCode = "";
                        string costCenter = "0500";
                        string costSubCenter = "001";
                        string movementType = "";
                        string cellarCode = "";
                        string quantity = clsGlobal.FillWithZeros((Math.Round(lstPalletMovement[i].weigth, 1) * 100000).ToString(), 15);

                        productCode = "0040001000306";

                        if (lstPalletMovement[i].ingress == true)
                        {
                            documentType = "E";
                            movementType = "D";
                            receiptCode = "001";
                            cellarCode = "0023";
                        }
                        else
                        {
                            movementType = "C";
                            documentType = "H";
                            receiptCode = "023";
                            cellarCode = "0023";
                        }

                        lstSiigoMovements.Add(new siigoMovements());

                        lstSiigoMovements[lstSiigoMovements.Count - 1].receiptType = documentType;
                        lstSiigoMovements[lstSiigoMovements.Count - 1].receiptCode = receiptCode;
                        lstSiigoMovements[lstSiigoMovements.Count - 1].completeReceiptType = documentType + receiptCode;
                        lstSiigoMovements[lstSiigoMovements.Count - 1].productCode = productCode;
                        lstSiigoMovements[lstSiigoMovements.Count - 1].documentDate = lstPalletMovement[i].createdDate.ToString("yyyyMMdd");
                        lstSiigoMovements[lstSiigoMovements.Count - 1].costCenter = costCenter;
                        lstSiigoMovements[lstSiigoMovements.Count - 1].costSubCenter = costSubCenter;
                        lstSiigoMovements[lstSiigoMovements.Count - 1].description = clsGlobal.FillWithSpaces(lstPalletMovement[i].code + " - " + lstPalletMovement[i].movementcellar.Replace("á", "a").Replace("é", "e").Replace("í", "i").Replace("ó", "o").Replace("ú", "u"), 50).Substring(0, 50);
                        lstSiigoMovements[lstSiigoMovements.Count - 1].creditDebit = movementType;
                        lstSiigoMovements[lstSiigoMovements.Count - 1].cellarCode = cellarCode;
                        lstSiigoMovements[lstSiigoMovements.Count - 1].quantity = quantity;
                    }

                    lstSiigoMovements.Sort();

                    string actualMovement = "";
                    int movementSequential = 0;
                    actualMovementNumber = 0;

                    for (int i = 0; i < lstSiigoMovements.Count; i++)
                    {
                        if (lstSiigoMovements[i].completeReceiptType != actualMovement)
                        {
                            actualMovement = lstSiigoMovements[i].completeReceiptType;
                            movementSequential = 1;
                        }
                        else
                            movementSequential = movementSequential + 1;

                        lstSiigoMovements[i].receiptSequence = clsGlobal.FillWithZeros(movementSequential.ToString(), 5);

                        switch (actualMovement)
                        {
                            case "E001":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E001"]);
                                changeE001 = true;
                                break;
                            case "E010":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E010"]);
                                changeE010 = true;
                                break;
                            case "E011":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E011"]);
                                changeE011 = true;
                                break;
                            case "E012":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E012"]);
                                changeE012 = true;
                                break;
                            case "E021":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E021"]);
                                changeE021 = true;
                                break;
                            case "E022":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E022"]);
                                changeE022 = true;
                                break;
                            case "E043":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E043"]);
                                changeE043 = true;
                                break;
                            case "H013":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H013"]);
                                changeH013 = true;
                                break;
                            case "H014":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H014"]);
                                changeH014 = true;
                                break;
                            case "H022":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H022"]);
                                changeH022 = true;
                                break;
                            case "H023":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H023"]);
                                changeH023 = true;
                                break;
                            case "H047":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H047"]);
                                changeH047 = true;
                                break;
                            case "S006":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S006"]);
                                changeS006 = true;
                                break;
                            case "S008":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S008"]);
                                changeS008 = true;
                                break;
                            case "S009":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S009"]);
                                changeS009 = true;
                                break;
                            case "S010":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S010"]);
                                changeS010 = true;
                                break;
                            case "S014":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S014"]);
                                changeS014 = true;
                                break;
                            case "S023":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S023"]);
                                changeS023 = true;
                                break;
                            case "S025":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S025"]);
                                changeS025 = true;
                                break;
                        }
                        lstSiigoMovements[i].receiptNumber = clsGlobal.FillWithZeros(actualMovementNumber.ToString(), 11);
                    }

                    for (int i = 0; i < lstSiigoMovements.Count; i++)
                    {
                        //FILE ONE
                        strFileOne += lstSiigoMovements[i].receiptType;  			//01   001  001	TIPO DE COMPROBANTE:  1 posicin alfanum	
                        strFileOne += lstSiigoMovements[i].receiptCode;  			//03   002  004	CDIGO COMPROBANTE:  3 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].receiptNumber;  			//11   005  015	NMERO DE DOCUMENTO:  11 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].receiptSequence;  		//05   016  020	SECUENCIA:  5 posiciones numricas.  Mximo hasta 250	
                        strFileOne += lstSiigoMovements[i].receiptNIT;  			//13   021  033	NIT:  13 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].subsidiary;  			//03   034  036	SUCURSAL:  3 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].account;  			    //10   037  046	CUENTA CONTABLE:  10 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].productCode;  			//13   047  059	CDIGO DE PRODUCTO:  13 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].documentDate;  			//08   060  067	FECHA DEL DOCUMENTO:  8 posiciones numricas (AAAAMMDD)	
                        strFileOne += lstSiigoMovements[i].costCenter;  			//04   068  071	CENTRO DE COSTO:  4 posiciones numricas		
                        strFileOne += lstSiigoMovements[i].costSubCenter;  			//03   072  074	SUBCENTRO DE COSTO:  3 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].description;  			//50   075  124	DESCRIPCIN DEL MOVIMIENTO:  50 posiciones alfanumricas, para comentario o detalle del movimiento	
                        strFileOne += lstSiigoMovements[i].creditDebit;  			//01   125  125	DBITO O CRDITO:  1 posicin alfanumrica.  Valor D  C	
                        strFileOne += lstSiigoMovements[i].value;  			        //15   126  140	VALOR DEL MOVIMIENTO:  15 posiciones numricas, 13 enteros, 2 decimales	
                        strFileOne += lstSiigoMovements[i].retentionBase;  			//15   141  155	BASE DE RETENCIN:  15 posiciones numricas, 13 enteros, 2 decimales	
                        strFileOne += lstSiigoMovements[i].sellerCode;  			//04   156  159	CDIGO DEL VENDEDOR:  4 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].cityCode;  			    //04   160  163	CDIGO DE LA CIUDAD:  4 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].zoneCode;  			    //03   164  166	CDIGO DE LA ZONA:  3 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].cellarCode;  			//04   167  170	CDIGO DE LA BODEGA:  4 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].locationCode;  			//03   171  173	CDIGO DE LA UBICACIN:  3 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].quantity;  			    //15   174  188	CANTIDAD:  15 posiciones numricas, 10 enteros, 5 decimales	
                        strFileOne += lstSiigoMovements[i].crossDocumentType;  		//01   189  189	TIPO DE DOCUMENTO CRUCE:  1 posicin alfanumrica 	
                        strFileOne += lstSiigoMovements[i].crossDocumentCode;  		//03   190  192	CDIGO COMPROBANTE CRUCE:  3 posiciones alfanumricas, diferentes a espacios	
                        strFileOne += lstSiigoMovements[i].crossDocumentNumber;		//11   193  203   NMERO DE DOCUMENTO CRUCE:  11 posiciones numricas		
                        strFileOne += lstSiigoMovements[i].crossDocumentSequence;  	//03   204  206	SECUENCIA DEL DOCUMENTO CRUCE:  3 posiciones numricas.  Secuencia del documento cruce, mximo hasta 250	
                        strFileOne += lstSiigoMovements[i].crossDocumentDate;  		//08   207  214	FECHA VENCIMIENTO DE DOCUMENTO CRUCE:  8 posiciones numricas (AAAAMMDD)	
                        strFileOne += lstSiigoMovements[i].paymentTypeCode;  		//04   215  218	CDIGO FORMA DE PAGO:  4 posiciones numricas, solo se utilizan tres el primer digito debe ser cero.	
                        strFileOne += lstSiigoMovements[i].bankCode;  			    //02   219  220	CDIGO DEL BANCO:  2 posiciones numricas	                    
                        strFileOne += "\r\n";
                    }
                    fileName = folderPath + "\\m" + DateTime.Now.ToString("yyyyMMddHHmm") + ".txt";

                    FileStream fs = File.Open(fileName, FileMode.CreateNew, FileAccess.Write);

                    StreamWriter sw = new StreamWriter(fs);

                    sw.Write(strFileOne);
                    sw.Close();
                    fs.Close();

                    if (changeE001 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E001 = sms_E001 + 1;");
                    if (changeE010 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E010 = sms_E010 + 1;");
                    if (changeE011 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E011 = sms_E011 + 1;");
                    if (changeE012 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E012 = sms_E012 + 1;");
                    if (changeE021 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E021 = sms_E021 + 1;");
                    if (changeE022 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E022 = sms_E022 + 1;");
                    if (changeE043 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E043 = sms_E043 + 1;");
                    if (changeH013 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H013 = sms_H013 + 1;");
                    if (changeH014 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H014 = sms_H014 + 1;");
                    if (changeH022 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H022 = sms_H022 + 1;");
                    if (changeH023 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H023 = sms_H023 + 1;");
                    if (changeH047 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H047 = sms_H047 + 1;");
                    if (changeS006 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S006 = sms_S006 + 1;");
                    if (changeS008 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S008 = sms_S008 + 1;");
                    if (changeS009 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S009 = sms_S009 + 1;");
                    if (changeS010 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S010 = sms_S010 + 1;");
                    if (changeS014 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S014 = sms_S014 + 1;");
                    if (changeS023 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S023 = sms_S023 + 1;");
                    if (changeS025 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S025 = sms_S025 + 1;");
                }
                else
                {
                    //para importaciones
                }
            }
            catch (Exception)
            {
                throw;
            }
            return true;
        }

        public static bool exportMaquileMovementsToSiigo(List<clsMaquile> lstPalletMovement, string folderPath, int a)
        {
            string strFileOne = "";
            string fileName = "";
            int actualMovementNumber = 0;

            bool changeE001 = false;
            bool changeE010 = false;
            bool changeE011 = false;
            bool changeE012 = false;
            bool changeE021 = false;
            bool changeE022 = false;
            bool changeE043 = false;
            bool changeH013 = false;
            bool changeH014 = false;
            bool changeH022 = false;
            bool changeH023 = false;
            bool changeH047 = false;
            bool changeS006 = false;
            bool changeS008 = false;
            bool changeS009 = false;
            bool changeS010 = false;
            bool changeS014 = false;
            bool changeS023 = false;
            bool changeS025 = false;
            bool changeE023 = false;

            try
            {
                if (a == 1)
                {
                    DataSet DS = clsConnection.getDataSetResult("SELECT * FROM bps_xtr_siigoMovementsSequential");
                    List<siigoMovements> lstSiigoMovements = new List<siigoMovements>();

                    for (int i = 0; i < lstPalletMovement.Count; i++)
                    {
                        string documentType = "";
                        string receiptCode = "";
                        string productCode = "";
                        string costCenter = "0500";
                        string costSubCenter = "001";
                        string movementType = "";
                        string cellarCode = "";
                        string quantity = clsGlobal.FillWithZeros((Math.Round(lstPalletMovement[i].weigth, 1) * 100000).ToString(), 15);

                        productCode = "0040001000342";

                        if (lstPalletMovement[i].movement == "E011")
                        {
                            documentType = "E";
                            movementType = "D";
                            receiptCode = "011";
                            cellarCode = "0019";
                        }
                        else if (lstPalletMovement[i].movement == "E012")
                        {
                            documentType = "E";
                            movementType = "D";
                            receiptCode = "012";
                            cellarCode = "0019";
                        }
                        else if (lstPalletMovement[i].movement == "S014")
                        {
                            documentType = "S";
                            movementType = "C";
                            receiptCode = "014";
                            cellarCode = "0019";
                        }
                        else
                        {
                            movementType = "C";
                            documentType = "H";
                            receiptCode = "013";
                            cellarCode = "0019";
                        }

                        lstSiigoMovements.Add(new siigoMovements());

                        lstSiigoMovements[lstSiigoMovements.Count - 1].receiptType = documentType;
                        lstSiigoMovements[lstSiigoMovements.Count - 1].receiptCode = receiptCode;
                        lstSiigoMovements[lstSiigoMovements.Count - 1].completeReceiptType = documentType + receiptCode;
                        lstSiigoMovements[lstSiigoMovements.Count - 1].productCode = productCode;
                        lstSiigoMovements[lstSiigoMovements.Count - 1].documentDate = lstPalletMovement[i].createdDate.ToString("yyyyMMdd");
                        lstSiigoMovements[lstSiigoMovements.Count - 1].costCenter = costCenter;
                        lstSiigoMovements[lstSiigoMovements.Count - 1].costSubCenter = costSubCenter;
                        lstSiigoMovements[lstSiigoMovements.Count - 1].description = clsGlobal.FillWithSpaces(lstPalletMovement[i].mainCoilMetalCode + " - " + lstPalletMovement[i].cellarName.Replace("á", "a").Replace("é", "e").Replace("í", "i").Replace("ó", "o").Replace("ú", "u"), 50).Substring(0, 50);
                        lstSiigoMovements[lstSiigoMovements.Count - 1].creditDebit = movementType;
                        lstSiigoMovements[lstSiigoMovements.Count - 1].cellarCode = cellarCode;
                        lstSiigoMovements[lstSiigoMovements.Count - 1].quantity = quantity;
                    }

                    lstSiigoMovements.Sort();

                    string actualMovement = "";
                    int movementSequential = 0;
                    actualMovementNumber = 0;

                    for (int i = 0; i < lstSiigoMovements.Count; i++)
                    {
                        if (lstSiigoMovements[i].completeReceiptType != actualMovement)
                        {
                            actualMovement = lstSiigoMovements[i].completeReceiptType;
                            movementSequential = 1;
                        }
                        else
                            movementSequential = movementSequential + 1;

                        lstSiigoMovements[i].receiptSequence = clsGlobal.FillWithZeros(movementSequential.ToString(), 5);

                        switch (actualMovement)
                        {
                            case "E001":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E001"]);
                                changeE001 = true;
                                break;
                            case "E010":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E010"]);
                                changeE010 = true;
                                break;
                            case "E011":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E011"]);
                                changeE011 = true;
                                break;
                            case "E012":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E012"]);
                                changeE012 = true;
                                break;
                            case "E021":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E021"]);
                                changeE021 = true;
                                break;
                            case "E022":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E022"]);
                                changeE022 = true;
                                break;
                            case "E043":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E043"]);
                                changeE043 = true;
                                break;
                            case "H013":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H013"]);
                                changeH013 = true;
                                break;
                            case "H014":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H014"]);
                                changeH014 = true;
                                break;
                            case "H022":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H022"]);
                                changeH022 = true;
                                break;
                            case "H023":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H023"]);
                                changeH023 = true;
                                break;
                            case "H047":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H047"]);
                                changeH047 = true;
                                break;
                            case "S006":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S006"]);
                                changeS006 = true;
                                break;
                            case "S008":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S008"]);
                                changeS008 = true;
                                break;
                            case "S009":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S009"]);
                                changeS009 = true;
                                break;
                            case "S010":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S010"]);
                                changeS010 = true;
                                break;
                            case "S014":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S014"]);
                                changeS014 = true;
                                break;
                            case "S023":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S023"]);
                                changeS023 = true;
                                break;
                            case "S025":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S025"]);
                                changeS025 = true;
                                break;
                            case "E023":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E023"]);
                                changeE023 = true;
                                break;
                        }
                        lstSiigoMovements[i].receiptNumber = clsGlobal.FillWithZeros(actualMovementNumber.ToString(), 11);
                    }

                    for (int i = 0; i < lstSiigoMovements.Count; i++)
                    {
                        //FILE ONE
                        strFileOne += lstSiigoMovements[i].receiptType;  			//01   001  001	TIPO DE COMPROBANTE:  1 posicin alfanum	
                        strFileOne += lstSiigoMovements[i].receiptCode;  			//03   002  004	CDIGO COMPROBANTE:  3 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].receiptNumber;  			//11   005  015	NMERO DE DOCUMENTO:  11 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].receiptSequence;  		//05   016  020	SECUENCIA:  5 posiciones numricas.  Mximo hasta 250	
                        strFileOne += lstSiigoMovements[i].receiptNIT;  			//13   021  033	NIT:  13 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].subsidiary;  			//03   034  036	SUCURSAL:  3 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].account;  			    //10   037  046	CUENTA CONTABLE:  10 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].productCode;  			//13   047  059	CDIGO DE PRODUCTO:  13 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].documentDate;  			//08   060  067	FECHA DEL DOCUMENTO:  8 posiciones numricas (AAAAMMDD)	
                        strFileOne += lstSiigoMovements[i].costCenter;  			//04   068  071	CENTRO DE COSTO:  4 posiciones numricas		
                        strFileOne += lstSiigoMovements[i].costSubCenter;  			//03   072  074	SUBCENTRO DE COSTO:  3 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].description;  			//50   075  124	DESCRIPCIN DEL MOVIMIENTO:  50 posiciones alfanumricas, para comentario o detalle del movimiento	
                        strFileOne += lstSiigoMovements[i].creditDebit;  			//01   125  125	DBITO O CRDITO:  1 posicin alfanumrica.  Valor D  C	
                        strFileOne += lstSiigoMovements[i].value;  			        //15   126  140	VALOR DEL MOVIMIENTO:  15 posiciones numricas, 13 enteros, 2 decimales	
                        strFileOne += lstSiigoMovements[i].retentionBase;  			//15   141  155	BASE DE RETENCIN:  15 posiciones numricas, 13 enteros, 2 decimales	
                        strFileOne += lstSiigoMovements[i].sellerCode;  			//04   156  159	CDIGO DEL VENDEDOR:  4 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].cityCode;  			    //04   160  163	CDIGO DE LA CIUDAD:  4 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].zoneCode;  			    //03   164  166	CDIGO DE LA ZONA:  3 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].cellarCode;  			//04   167  170	CDIGO DE LA BODEGA:  4 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].locationCode;  			//03   171  173	CDIGO DE LA UBICACIN:  3 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].quantity;  			    //15   174  188	CANTIDAD:  15 posiciones numricas, 10 enteros, 5 decimales	
                        strFileOne += lstSiigoMovements[i].crossDocumentType;  		//01   189  189	TIPO DE DOCUMENTO CRUCE:  1 posicin alfanumrica 	
                        strFileOne += lstSiigoMovements[i].crossDocumentCode;  		//03   190  192	CDIGO COMPROBANTE CRUCE:  3 posiciones alfanumricas, diferentes a espacios	
                        strFileOne += lstSiigoMovements[i].crossDocumentNumber;		//11   193  203   NMERO DE DOCUMENTO CRUCE:  11 posiciones numricas		
                        strFileOne += lstSiigoMovements[i].crossDocumentSequence;  	//03   204  206	SECUENCIA DEL DOCUMENTO CRUCE:  3 posiciones numricas.  Secuencia del documento cruce, mximo hasta 250	
                        strFileOne += lstSiigoMovements[i].crossDocumentDate;  		//08   207  214	FECHA VENCIMIENTO DE DOCUMENTO CRUCE:  8 posiciones numricas (AAAAMMDD)	
                        strFileOne += lstSiigoMovements[i].paymentTypeCode;  		//04   215  218	CDIGO FORMA DE PAGO:  4 posiciones numricas, solo se utilizan tres el primer digito debe ser cero.	
                        strFileOne += lstSiigoMovements[i].bankCode;  			    //02   219  220	CDIGO DEL BANCO:  2 posiciones numricas	                    
                        strFileOne += "\r\n";
                    }
                    fileName = folderPath + "\\m" + DateTime.Now.ToString("yyyyMMddHHmm") + ".txt";

                    FileStream fs = File.Open(fileName, FileMode.CreateNew, FileAccess.Write);

                    StreamWriter sw = new StreamWriter(fs);

                    sw.Write(strFileOne);
                    sw.Close();
                    fs.Close();

                    if (changeE001 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E001 = sms_E001 + 1;");
                    if (changeE010 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E010 = sms_E010 + 1;");
                    if (changeE011 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E011 = sms_E011 + 1;");
                    if (changeE012 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E012 = sms_E012 + 1;");
                    if (changeE021 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E021 = sms_E021 + 1;");
                    if (changeE022 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E022 = sms_E022 + 1;");
                    if (changeE043 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E043 = sms_E043 + 1;");
                    if (changeH013 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H013 = sms_H013 + 1;");
                    if (changeH014 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H014 = sms_H014 + 1;");
                    if (changeH022 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H022 = sms_H022 + 1;");
                    if (changeH023 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H023 = sms_H023 + 1;");
                    if (changeH047 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H047 = sms_H047 + 1;");
                    if (changeS006 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S006 = sms_S006 + 1;");
                    if (changeS008 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S008 = sms_S008 + 1;");
                    if (changeS009 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S009 = sms_S009 + 1;");
                    if (changeS010 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S010 = sms_S010 + 1;");
                    if (changeS014 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S014 = sms_S014 + 1;");
                    if (changeS023 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S023 = sms_S023 + 1;");
                    if (changeS025 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S025 = sms_S025 + 1;");
                    if (changeE023 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E023 = sms_E023 + 1;");
                }
                else
                {
                    //para importaciones
                }
            }
            catch (Exception)
            {
                throw;
            }
            return true;
        }

        public static string siigoDataMill(List<clsMillPalletbyCoilCellar> lstMilPalletAux, string find)
        {
            string returnValue = "";

            try
            {
                for (int i = 0; i < lstMilPalletAux.Count; i++)
                {
                    if (find == "siigoCode")
                    {
                        DataSet DS = new DataSet();
                        DS = clsConnection.getDataSetResult("SELECT TOP (1) feq_externalId FROM bps_xtr_filmequivalencemill WHERE feq_fkMillProduct = " + lstMilPalletAux[i].fkProduct + "");
                        if (DS.Tables[0].Rows.Count > 0)
                            returnValue = DS.Tables[0].Rows[0]["feq_externalId"].ToString();
                        else
                            returnValue = "Code no encontrado";
                    }
                    else if (find == "siigoReference")
                    {
                        DataSet DS = new DataSet();
                        DS = clsConnection.getDataSetResult("SELECT TOP (1) feq_externalCode FROM bps_xtr_filmequivalencemill WHERE feq_fkMillProduct = " + lstMilPalletAux[i].fkProduct + "");
                        if (DS.Tables[0].Rows.Count > 0)
                            returnValue = DS.Tables[0].Rows[0]["feq_externalCode"].ToString();
                        else
                            returnValue = "Ref no encontrada";
                    }
                    else
                        returnValue = "no Data";
                }
                return returnValue;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static bool exportCellarMovementsToSiigo(List<clsMillPalletbyCoilCellar> lstMillPalletMovement, string folderPath, int a, bool calendar, DateTime endMonthDate)
        {
            string strFileOne = "";
            string fileName = "";
            int actualMovementNumber = 0;

            bool changeE007 = false;
            bool changeE037 = false;
            bool changeE038 = false;
            bool changeS018 = false;
            bool changeS020 = false;
            bool changeS001 = false;
            bool changeS026 = false;
            bool changeH056 = false;


            try
            {
                if (a == 1)
                {
                    DataSet DS = clsConnection.getDataSetResult("SELECT * FROM bps_xtr_siigoMovementsSequential");
                    List<siigoMovements> lstSiigoMovements = new List<siigoMovements>();

                    for (int i = 0; i < lstMillPalletMovement.Count; i++)
                    {
                        if (lstMillPalletMovement[i].netweigth > 0)
                        {
                            string documentType = "";
                            string receiptCode = "";
                            string productCode = "";
                            string costCenter = "0500";
                            string costSubCenter = "001";
                            string movementType = "";
                            string cellarCode = "";
                            string quantity = clsGlobal.FillWithZeros((Math.Round(lstMillPalletMovement[i].netweigth, 1) * 100000).ToString(), 15);

                            productCode = clsGlobal.FillWithZeros(clsMillProduct.getExternalCode(new clsMillProduct(lstMillPalletMovement[i].product)), 13);

                            if (lstMillPalletMovement[i].ingress == true)
                            {
                                documentType = "E";
                                movementType = "D";
                                receiptCode = "007";
                                cellarCode = "0020";
                            }
                            else if (lstMillPalletMovement[i].output == true)
                            {
                                movementType = "C";
                                switch (lstMillPalletMovement[i].movement)
                                {
                                    case "Salida a Planta DMT":
                                        documentType = "S";
                                        receiptCode = "001";
                                        cellarCode = "0020";
                                        break;

                                    case "Salida a Planta MW":
                                        documentType = "S";
                                        receiptCode = "026";
                                        cellarCode = "0020";
                                        break;

                                    case "Despacho ReProceso Calderón":
                                        documentType = "S";
                                        receiptCode = "018";
                                        cellarCode = "0020";
                                        break;

                                    case "Despacho ReProceso Cliente":
                                        documentType = "S";
                                        receiptCode = "020";
                                        cellarCode = "0020";
                                        break;

                                    case "Despacho ReProceso Guayaquil":
                                        documentType = "H";
                                        receiptCode = "056";
                                        cellarCode = "0020";
                                        break;
                                }
                            }
                            else if (lstMillPalletMovement[i].devolution == true)
                            {
                                movementType = "D";
                                switch (lstMillPalletMovement[i].movement)
                                {
                                    case "Devolución a Bodega DMT":
                                        movementType = "D";
                                        receiptCode = "037";
                                        cellarCode = "0020";
                                        break;

                                    case "Devolución a Bodega MW":
                                        movementType = "D";
                                        receiptCode = "037";
                                        cellarCode = "0020";
                                        break;
                                }
                            }

                            lstSiigoMovements.Add(new siigoMovements());

                            lstSiigoMovements[lstSiigoMovements.Count - 1].receiptType = documentType;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].receiptCode = receiptCode;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].completeReceiptType = documentType + receiptCode;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].productCode = productCode;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].documentDate = (calendar == true) ? endMonthDate.ToString("yyyyMMdd") : lstMillPalletMovement[i].date.ToString("yyyyMMdd");
                            lstSiigoMovements[lstSiigoMovements.Count - 1].costCenter = costCenter;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].costSubCenter = costSubCenter;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].description = clsGlobal.FillWithSpaces(lstMillPalletMovement[i].code + " - " + lstMillPalletMovement[i].movement.Replace("á", "a").Replace("é", "e").Replace("í", "i").Replace("ó", "o").Replace("ú", "u"), 50).Substring(0, 50);
                            lstSiigoMovements[lstSiigoMovements.Count - 1].creditDebit = movementType;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].cellarCode = cellarCode;
                            lstSiigoMovements[lstSiigoMovements.Count - 1].quantity = quantity;
                        }
                    }

                    lstSiigoMovements.Sort();

                    string actualMovement = "";
                    int movementSequential = 0;
                    actualMovementNumber = 0;

                    for (int i = 0; i < lstSiigoMovements.Count; i++)
                    {
                        if (lstSiigoMovements[i].completeReceiptType != actualMovement)
                        {
                            actualMovement = lstSiigoMovements[i].completeReceiptType;
                            movementSequential = 1;
                        }
                        else
                            movementSequential = movementSequential + 1;

                        lstSiigoMovements[i].receiptSequence = clsGlobal.FillWithZeros(movementSequential.ToString(), 5);

                        switch (actualMovement)
                        {
                            case "E007":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E007"]);
                                changeE007 = true;
                                break;
                            case "E037":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E037"]);
                                changeE037 = true;
                                break;
                            case "E038":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E038"]);
                                changeE038 = true;
                                break;
                            case "S018":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S018"]);
                                changeS018 = true;
                                break;
                            case "S020":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S020"]);
                                changeS020 = true;
                                break;
                            case "S001":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S001"]);
                                changeS001 = true;
                                break;
                            case "S026":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S026"]);
                                changeS026 = true;
                                break;
                            case "H056":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H056"]);
                                changeH056 = true;
                                break;
                        }
                        lstSiigoMovements[i].receiptNumber = clsGlobal.FillWithZeros(actualMovementNumber.ToString(), 11);
                    }

                    for (int i = 0; i < lstSiigoMovements.Count; i++)
                    {
                        lstSiigoMovements[i].account = "1005010100";
                        //FILE ONE
                        strFileOne += lstSiigoMovements[i].receiptType;  			//01   001  001	TIPO DE COMPROBANTE:  1 posicin alfanum	
                        strFileOne += lstSiigoMovements[i].receiptCode;  			//03   002  004	CDIGO COMPROBANTE:  3 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].receiptNumber;  			//11   005  015	NMERO DE DOCUMENTO:  11 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].receiptSequence;  		//05   016  020	SECUENCIA:  5 posiciones numricas.  Mximo hasta 250	
                        strFileOne += lstSiigoMovements[i].receiptNIT;  			//13   021  033	NIT:  13 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].subsidiary;  			//03   034  036	SUCURSAL:  3 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].account;  			    //10   037  046	CUENTA CONTABLE:  10 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].productCode;  			//13   047  059	CDIGO DE PRODUCTO:  13 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].documentDate;  			//08   060  067	FECHA DEL DOCUMENTO:  8 posiciones numricas (AAAAMMDD)	
                        strFileOne += lstSiigoMovements[i].costCenter;  			//04   068  071	CENTRO DE COSTO:  4 posiciones numricas		
                        strFileOne += lstSiigoMovements[i].costSubCenter;  			//03   072  074	SUBCENTRO DE COSTO:  3 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].description;  			//50   075  124	DESCRIPCIN DEL MOVIMIENTO:  50 posiciones alfanumricas, para comentario o detalle del movimiento	
                        strFileOne += lstSiigoMovements[i].creditDebit;  			//01   125  125	DBITO O CRDITO:  1 posicin alfanumrica.  Valor D  C	
                        strFileOne += lstSiigoMovements[i].value;  			        //15   126  140	VALOR DEL MOVIMIENTO:  15 posiciones numricas, 13 enteros, 2 decimales	
                        strFileOne += lstSiigoMovements[i].retentionBase;  			//15   141  155	BASE DE RETENCIN:  15 posiciones numricas, 13 enteros, 2 decimales	
                        strFileOne += lstSiigoMovements[i].sellerCode;  			//04   156  159	CDIGO DEL VENDEDOR:  4 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].cityCode;  			    //04   160  163	CDIGO DE LA CIUDAD:  4 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].zoneCode;  			    //03   164  166	CDIGO DE LA ZONA:  3 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].cellarCode;  			//04   167  170	CDIGO DE LA BODEGA:  4 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].locationCode;  			//03   171  173	CDIGO DE LA UBICACIN:  3 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].quantity;  			    //15   174  188	CANTIDAD:  15 posiciones numricas, 10 enteros, 5 decimales	
                        strFileOne += lstSiigoMovements[i].crossDocumentType;  		//01   189  189	TIPO DE DOCUMENTO CRUCE:  1 posicin alfanumrica 	
                        strFileOne += lstSiigoMovements[i].crossDocumentCode;  		//03   190  192	CDIGO COMPROBANTE CRUCE:  3 posiciones alfanumricas, diferentes a espacios	
                        strFileOne += lstSiigoMovements[i].crossDocumentNumber;		//11   193  203   NMERO DE DOCUMENTO CRUCE:  11 posiciones numricas		
                        strFileOne += lstSiigoMovements[i].crossDocumentSequence;  	//03   204  206	SECUENCIA DEL DOCUMENTO CRUCE:  3 posiciones numricas.  Secuencia del documento cruce, mximo hasta 250	
                        strFileOne += lstSiigoMovements[i].crossDocumentDate;  		//08   207  214	FECHA VENCIMIENTO DE DOCUMENTO CRUCE:  8 posiciones numricas (AAAAMMDD)	
                        strFileOne += lstSiigoMovements[i].paymentTypeCode;  		//04   215  218	CDIGO FORMA DE PAGO:  4 posiciones numricas, solo se utilizan tres el primer digito debe ser cero.	
                        strFileOne += lstSiigoMovements[i].bankCode;  			    //02   219  220	CDIGO DEL BANCO:  2 posiciones numricas	                    
                        strFileOne += "\r\n";
                    }
                    fileName = folderPath + "\\m" + DateTime.Now.ToString("yyyyMMddHHmm") + ".txt";

                    FileStream fs = File.Open(fileName, FileMode.CreateNew, FileAccess.Write);

                    StreamWriter sw = new StreamWriter(fs);

                    sw.Write(strFileOne);
                    sw.Close();
                    fs.Close();

                    if (changeE007 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E007 = sms_E007 + 1;");
                    if (changeE037 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E037 = sms_E037 + 1;");
                    if (changeE038 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E038 = sms_E038 + 1;");
                    if (changeS018 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S018 = sms_S018 + 1;");
                    if (changeS020 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S020 = sms_S020 + 1;");
                    if (changeS001 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S001 = sms_S001 + 1;");
                    if (changeS026 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S026 = sms_S026 + 1;");
                    if (changeH056 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H056 = sms_H056 + 1;");
                }
            }
            catch (Exception)
            {
                throw;
            }
            return true;
        }

        public static bool exportRaw(List<string> rawListCodsec, string folderPath, bool isActiveCalendar, DateTime endMonthDate)
        {
            bool result = true;
            string strFileOne = "", fileName = "";
            int actualMovementNumber = 0;

            bool changeE004 = false, changeE005 = false, changeE031 = false, changeE002 = false, changeE035 = false, changeE030 = false, changeE033 = false, changeE036 = false;
            bool changeH016 = false, changeH004 = false, changeH018 = false, changeH017 = false, changeH005 = false, changeS019 = false, changeS021 = false;
            bool changeH001 = false, changeH003 = false, changeH007 = false, changeH006 = false;

            List<clsRawMaterialbyCoilCellar> rawList = new List<clsRawMaterialbyCoilCellar>();
            rawList = clsRawMaterialbyCoilCellar.getListToList(rawListCodsec);
            DataSet DS = clsConnection.getDataSetResult("SELECT * FROM bps_xtr_siigoMovementsSequential");
            List<siigoMovements> siigoMList = new List<siigoMovements>();

            foreach (var item in rawList)
            {
                string costCenter = "0500";
                string costSubCenter = "001";

                siigoMList.Add(new siigoMovements());

                siigoMList[siigoMList.Count - 1].receiptType = item.documentType;
                siigoMList[siigoMList.Count - 1].receiptCode = item.receiptCode;
                siigoMList[siigoMList.Count - 1].completeReceiptType = item.movementCT;
                siigoMList[siigoMList.Count - 1].productCode = item.product;
                siigoMList[siigoMList.Count - 1].documentDate = (isActiveCalendar == true) ? endMonthDate.ToString("yyyyMMdd") : item.date.ToString("yyyyMMdd");
                siigoMList[siigoMList.Count - 1].costCenter = costCenter;
                siigoMList[siigoMList.Count - 1].costSubCenter = costSubCenter;
                siigoMList[siigoMList.Count - 1].description = item.movement;
                siigoMList[siigoMList.Count - 1].creditDebit = item.movementType;
                siigoMList[siigoMList.Count - 1].cellarCode = clsGlobal.FillWithZeros(item.siigoCellar, 4);
                siigoMList[siigoMList.Count - 1].quantity = clsGlobal.FillWithZeros((Math.Round(item.netweigth, 1) * 100000).ToString(), 15);
                siigoMList[siigoMList.Count - 1].account = "1005010100";
            }

            string actualMovement = "";
            int movementSequential = 0;
            actualMovementNumber = 0;

            for (int i = 0; i < siigoMList.Count; i++)
            {
                if (siigoMList[i].completeReceiptType != actualMovement)
                {
                    actualMovement = siigoMList[i].completeReceiptType;
                    movementSequential = 1;
                }
                else
                    movementSequential += 1;

                siigoMList[i].receiptSequence = clsGlobal.FillWithZeros(movementSequential.ToString(), 5);

                switch (actualMovement)
                {
                    case "E004":
                        actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E004"]);
                        changeE004 = true;
                        break;
                    case "E005":
                        actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E005"]);
                        changeE005 = true;
                        break;
                    case "E031":
                        actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E031"]);
                        changeE031 = true;
                        break;
                    case "E002":
                        actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E002"]);
                        changeE002 = true;
                        break;
                    case "E035":
                        actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E035"]);
                        changeE035 = true;
                        break;
                    case "E030":
                        actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E030"]);
                        changeE030 = true;
                        break;
                    case "E033":
                        actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E033"]);
                        changeE033 = true;
                        break;
                    case "E036":
                        actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E036"]);
                        changeE036 = true;
                        break;
                    case "H016":
                        actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H016"]);
                        changeH016 = true;
                        break;
                    case "H004":
                        actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H004"]);
                        changeH004 = true;
                        break;
                    case "H018":
                        actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H018"]);
                        changeH018 = true;
                        break;
                    case "H017":
                        actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H017"]);
                        changeH017 = true;
                        break;
                    case "H005":
                        actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H005"]);
                        changeH005 = true;
                        break;
                    case "S019":
                        actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S019"]);
                        changeS019 = true;
                        break;
                    case "S021":
                        actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S021"]);
                        changeS021 = true;
                        break;
                    case "H001":
                        actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H001"]);
                        changeH001 = true;
                        break;
                    case "H003":
                        actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H003"]);
                        changeH003 = true;
                        break;
                    case "H007":
                        actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H007"]);
                        changeH007 = true;
                        break;
                    case "H006":
                        actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H006"]);
                        changeH006 = true;
                        break;
                }
                siigoMList[i].receiptNumber = clsGlobal.FillWithZeros(actualMovementNumber.ToString(), 11);
            }

            for (int i = 0; i < siigoMList.Count; i++)
            {
                //FILE ONE
                strFileOne += siigoMList[i].receiptType;  			//01   001  001	TIPO DE COMPROBANTE:  1 posicin alfanum	
                strFileOne += siigoMList[i].receiptCode;  			//03   002  004	CDIGO COMPROBANTE:  3 posiciones numricas	
                strFileOne += siigoMList[i].receiptNumber;  			//11   005  015	NMERO DE DOCUMENTO:  11 posiciones numricas	
                strFileOne += siigoMList[i].receiptSequence;  		//05   016  020	SECUENCIA:  5 posiciones numricas.  Mximo hasta 250	
                strFileOne += siigoMList[i].receiptNIT;  			//13   021  033	NIT:  13 posiciones numricas	
                strFileOne += siigoMList[i].subsidiary;  			//03   034  036	SUCURSAL:  3 posiciones numricas	
                strFileOne += siigoMList[i].account;  			    //10   037  046	CUENTA CONTABLE:  10 posiciones numricas	
                strFileOne += siigoMList[i].productCode;  			//13   047  059	CDIGO DE PRODUCTO:  13 posiciones numricas	
                strFileOne += siigoMList[i].documentDate;  			//08   060  067	FECHA DEL DOCUMENTO:  8 posiciones numricas (AAAAMMDD)	
                strFileOne += siigoMList[i].costCenter;  			//04   068  071	CENTRO DE COSTO:  4 posiciones numricas		
                strFileOne += siigoMList[i].costSubCenter;  			//03   072  074	SUBCENTRO DE COSTO:  3 posiciones numricas	
                strFileOne += siigoMList[i].description;  			//50   075  124	DESCRIPCIN DEL MOVIMIENTO:  50 posiciones alfanumricas, para comentario o detalle del movimiento	
                strFileOne += siigoMList[i].creditDebit;  			//01   125  125	DBITO O CRDITO:  1 posicin alfanumrica.  Valor D  C	
                strFileOne += siigoMList[i].value;  			        //15   126  140	VALOR DEL MOVIMIENTO:  15 posiciones numricas, 13 enteros, 2 decimales	
                strFileOne += siigoMList[i].retentionBase;  			//15   141  155	BASE DE RETENCIN:  15 posiciones numricas, 13 enteros, 2 decimales	
                strFileOne += siigoMList[i].sellerCode;  			//04   156  159	CDIGO DEL VENDEDOR:  4 posiciones numricas	
                strFileOne += siigoMList[i].cityCode;  			    //04   160  163	CDIGO DE LA CIUDAD:  4 posiciones numricas	
                strFileOne += siigoMList[i].zoneCode;  			    //03   164  166	CDIGO DE LA ZONA:  3 posiciones numricas	
                strFileOne += siigoMList[i].cellarCode;  			//04   167  170	CDIGO DE LA BODEGA:  4 posiciones numricas	
                strFileOne += siigoMList[i].locationCode;  			//03   171  173	CDIGO DE LA UBICACIN:  3 posiciones numricas	
                strFileOne += siigoMList[i].quantity;  			    //15   174  188	CANTIDAD:  15 posiciones numricas, 10 enteros, 5 decimales	
                strFileOne += siigoMList[i].crossDocumentType;  		//01   189  189	TIPO DE DOCUMENTO CRUCE:  1 posicin alfanumrica 	
                strFileOne += siigoMList[i].crossDocumentCode;  		//03   190  192	CDIGO COMPROBANTE CRUCE:  3 posiciones alfanumricas, diferentes a espacios	
                strFileOne += siigoMList[i].crossDocumentNumber;		//11   193  203   NMERO DE DOCUMENTO CRUCE:  11 posiciones numricas		
                strFileOne += siigoMList[i].crossDocumentSequence;  	//03   204  206	SECUENCIA DEL DOCUMENTO CRUCE:  3 posiciones numricas.  Secuencia del documento cruce, mximo hasta 250	
                strFileOne += siigoMList[i].crossDocumentDate;  		//08   207  214	FECHA VENCIMIENTO DE DOCUMENTO CRUCE:  8 posiciones numricas (AAAAMMDD)	
                strFileOne += siigoMList[i].paymentTypeCode;  		//04   215  218	CDIGO FORMA DE PAGO:  4 posiciones numricas, solo se utilizan tres el primer digito debe ser cero.	
                strFileOne += siigoMList[i].bankCode;  			    //02   219  220	CDIGO DEL BANCO:  2 posiciones numricas	                    
                strFileOne += "\r\n";
            }

            fileName = folderPath + "\\m" + DateTime.Now.ToString("yyyyMMddHHmm") + ".txt";

            FileStream fs = File.Open(fileName, FileMode.CreateNew, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);

            sw.Write(strFileOne);
            sw.Close();
            fs.Close();

            if (changeE004 == true)
                clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E004 = sms_E004 + 1;");
            if (changeE005 == true)
                clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E005 = sms_E005 + 1;");
            if (changeE031 == true)
                clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E031 = sms_E031 + 1;");
            if (changeE002 == true)
                clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E002 = sms_E002 + 1;");
            if (changeE035 == true)
                clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E035 = sms_E035 + 1;");
            if (changeE030 == true)
                clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E030 = sms_E030 + 1;");
            if (changeE033 == true)
                clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E033 = sms_E033 + 1;");
            if (changeE036 == true)
                clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H036 = sms_H036 + 1;");
            if (changeH016 == true)
                clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H016 = sms_H016 + 1;");
            if (changeH004 == true)
                clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H004 = sms_H004 + 1;");
            if (changeH018 == true)
                clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H018 = sms_H018 + 1;");
            if (changeH017 == true)
                clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H017 = sms_H017 + 1;");
            if (changeH005 == true)
                clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H005 = sms_H005 + 1;");
            if (changeS019 == true)
                clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S019 = sms_S019 + 1;");
            if (changeS021 == true)
                clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S021 = sms_S021 + 1;");
            if (changeH001 == true)
                clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H001 = sms_H001 + 1;");
            if (changeH003 == true)
                clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H003 = sms_H003 + 1;");
            if (changeH007 == true)
                clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H007 = sms_H007 + 1;");
            if (changeH006 == true)
                clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H006 = sms_H006 + 1;");

            return result;
        }

        public static bool exportReturnMovementsToSiigo(List<clsReturn> lstPalletMovement, string folderPath, int a, bool isActiveCalendar, DateTime dtpEndMonth)
        {
            string strFileOne = "";
            string fileName = "";
            int actualMovementNumber = 0;

            bool changeE001 = false, changeE010 = false, changeE011 = false, changeE012 = false, changeE021 = false, changeE022 = false;
            bool changeE043 = false, changeH013 = false, changeH014 = false, changeH022 = false, changeH023 = false, changeH047 = false;
            bool changeS006 = false, changeS008 = false, changeS009 = false, changeS010 = false, changeS014 = false, changeS023 = false;
            bool changeS025 = false;

            try
            {
                if (a == 1)
                {
                    DataSet DS = clsConnection.getDataSetResult("SELECT * FROM bps_xtr_siigoMovementsSequential");
                    List<siigoMovements> lstSiigoMovements = new List<siigoMovements>();

                    for (int i = 0; i < lstPalletMovement.Count; i++)
                    {
                        string documentType = "";
                        string receiptCode = "";
                        string productCode = "";
                        string costCenter = "0500";
                        string costSubCenter = "001";
                        string movementType = "";
                        string cellarCode = "";
                        string quantity = clsGlobal.FillWithZeros((Math.Round(lstPalletMovement[i].weigth, 1) * 100000).ToString(), 15);
                        productCode = "0040001000306";
                        if (lstPalletMovement[i].ingress == true)
                        {
                            documentType = "E";
                            movementType = "D";
                            receiptCode = "001";
                            cellarCode = "0023";
                        }
                        else
                        {
                            movementType = "C";
                            documentType = "H";
                            receiptCode = "023";
                            cellarCode = "0023";
                        }

                        lstSiigoMovements.Add(new siigoMovements());

                        lstSiigoMovements[lstSiigoMovements.Count - 1].receiptType = documentType;
                        lstSiigoMovements[lstSiigoMovements.Count - 1].receiptCode = receiptCode;
                        lstSiigoMovements[lstSiigoMovements.Count - 1].completeReceiptType = documentType + receiptCode;
                        lstSiigoMovements[lstSiigoMovements.Count - 1].productCode = productCode;
                        lstSiigoMovements[lstSiigoMovements.Count - 1].documentDate = (isActiveCalendar == true) ? dtpEndMonth.ToString("yyyyMMdd") : lstPalletMovement[i].createdDate.ToString("yyyyMMdd");
                        lstSiigoMovements[lstSiigoMovements.Count - 1].costCenter = costCenter;
                        lstSiigoMovements[lstSiigoMovements.Count - 1].costSubCenter = costSubCenter;
                        lstSiigoMovements[lstSiigoMovements.Count - 1].description = clsGlobal.FillWithSpaces(lstPalletMovement[i].code + " - " + lstPalletMovement[i].movementcellar.Replace("á", "a").Replace("é", "e").Replace("í", "i").Replace("ó", "o").Replace("ú", "u"), 50).Substring(0, 50);
                        lstSiigoMovements[lstSiigoMovements.Count - 1].creditDebit = movementType;
                        lstSiigoMovements[lstSiigoMovements.Count - 1].cellarCode = cellarCode;
                        lstSiigoMovements[lstSiigoMovements.Count - 1].quantity = quantity;
                    }

                    lstSiigoMovements.Sort();

                    string actualMovement = "";
                    int movementSequential = 0;
                    actualMovementNumber = 0;

                    for (int i = 0; i < lstSiigoMovements.Count; i++)
                    {
                        if (lstSiigoMovements[i].completeReceiptType != actualMovement)
                        {
                            actualMovement = lstSiigoMovements[i].completeReceiptType;
                            movementSequential = 1;
                        }
                        else
                            movementSequential = movementSequential + 1;

                        lstSiigoMovements[i].receiptSequence = clsGlobal.FillWithZeros(movementSequential.ToString(), 5);

                        switch (actualMovement)
                        {
                            case "E001":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E001"]);
                                changeE001 = true;
                                break;
                            case "E010":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E010"]);
                                changeE010 = true;
                                break;
                            case "E011":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E011"]);
                                changeE011 = true;
                                break;
                            case "E012":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E012"]);
                                changeE012 = true;
                                break;
                            case "E021":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E021"]);
                                changeE021 = true;
                                break;
                            case "E022":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E022"]);
                                changeE022 = true;
                                break;
                            case "E043":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E043"]);
                                changeE043 = true;
                                break;
                            case "H013":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H013"]);
                                changeH013 = true;
                                break;
                            case "H014":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H014"]);
                                changeH014 = true;
                                break;
                            case "H022":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H022"]);
                                changeH022 = true;
                                break;
                            case "H023":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H023"]);
                                changeH023 = true;
                                break;
                            case "H047":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H047"]);
                                changeH047 = true;
                                break;
                            case "S006":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S006"]);
                                changeS006 = true;
                                break;
                            case "S008":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S008"]);
                                changeS008 = true;
                                break;
                            case "S009":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S009"]);
                                changeS009 = true;
                                break;
                            case "S010":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S010"]);
                                changeS010 = true;
                                break;
                            case "S014":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S014"]);
                                changeS014 = true;
                                break;
                            case "S023":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S023"]);
                                changeS023 = true;
                                break;
                            case "S025":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S025"]);
                                changeS025 = true;
                                break;
                        }
                        lstSiigoMovements[i].receiptNumber = clsGlobal.FillWithZeros(actualMovementNumber.ToString(), 11);
                    }

                    for (int i = 0; i < lstSiigoMovements.Count; i++)
                    {
                        //FILE ONE
                        strFileOne += lstSiigoMovements[i].receiptType;  			//01   001  001	TIPO DE COMPROBANTE:  1 posicin alfanum	
                        strFileOne += lstSiigoMovements[i].receiptCode;  			//03   002  004	CDIGO COMPROBANTE:  3 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].receiptNumber;  			//11   005  015	NMERO DE DOCUMENTO:  11 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].receiptSequence;  		//05   016  020	SECUENCIA:  5 posiciones numricas.  Mximo hasta 250	
                        strFileOne += lstSiigoMovements[i].receiptNIT;  			//13   021  033	NIT:  13 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].subsidiary;  			//03   034  036	SUCURSAL:  3 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].account;  			    //10   037  046	CUENTA CONTABLE:  10 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].productCode;  			//13   047  059	CDIGO DE PRODUCTO:  13 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].documentDate;  			//08   060  067	FECHA DEL DOCUMENTO:  8 posiciones numricas (AAAAMMDD)	
                        strFileOne += lstSiigoMovements[i].costCenter;  			//04   068  071	CENTRO DE COSTO:  4 posiciones numricas		
                        strFileOne += lstSiigoMovements[i].costSubCenter;  			//03   072  074	SUBCENTRO DE COSTO:  3 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].description;  			//50   075  124	DESCRIPCIN DEL MOVIMIENTO:  50 posiciones alfanumricas, para comentario o detalle del movimiento	
                        strFileOne += lstSiigoMovements[i].creditDebit;  			//01   125  125	DBITO O CRDITO:  1 posicin alfanumrica.  Valor D  C	
                        strFileOne += lstSiigoMovements[i].value;  			        //15   126  140	VALOR DEL MOVIMIENTO:  15 posiciones numricas, 13 enteros, 2 decimales	
                        strFileOne += lstSiigoMovements[i].retentionBase;  			//15   141  155	BASE DE RETENCIN:  15 posiciones numricas, 13 enteros, 2 decimales	
                        strFileOne += lstSiigoMovements[i].sellerCode;  			//04   156  159	CDIGO DEL VENDEDOR:  4 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].cityCode;  			    //04   160  163	CDIGO DE LA CIUDAD:  4 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].zoneCode;  			    //03   164  166	CDIGO DE LA ZONA:  3 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].cellarCode;  			//04   167  170	CDIGO DE LA BODEGA:  4 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].locationCode;  			//03   171  173	CDIGO DE LA UBICACIN:  3 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].quantity;  			    //15   174  188	CANTIDAD:  15 posiciones numricas, 10 enteros, 5 decimales	
                        strFileOne += lstSiigoMovements[i].crossDocumentType;  		//01   189  189	TIPO DE DOCUMENTO CRUCE:  1 posicin alfanumrica 	
                        strFileOne += lstSiigoMovements[i].crossDocumentCode;  		//03   190  192	CDIGO COMPROBANTE CRUCE:  3 posiciones alfanumricas, diferentes a espacios	
                        strFileOne += lstSiigoMovements[i].crossDocumentNumber;		//11   193  203   NMERO DE DOCUMENTO CRUCE:  11 posiciones numricas		
                        strFileOne += lstSiigoMovements[i].crossDocumentSequence;  	//03   204  206	SECUENCIA DEL DOCUMENTO CRUCE:  3 posiciones numricas.  Secuencia del documento cruce, mximo hasta 250	
                        strFileOne += lstSiigoMovements[i].crossDocumentDate;  		//08   207  214	FECHA VENCIMIENTO DE DOCUMENTO CRUCE:  8 posiciones numricas (AAAAMMDD)	
                        strFileOne += lstSiigoMovements[i].paymentTypeCode;  		//04   215  218	CDIGO FORMA DE PAGO:  4 posiciones numricas, solo se utilizan tres el primer digito debe ser cero.	
                        strFileOne += lstSiigoMovements[i].bankCode;  			    //02   219  220	CDIGO DEL BANCO:  2 posiciones numricas	                    
                        strFileOne += "\r\n";
                    }

                    fileName = folderPath + "\\m" + DateTime.Now.ToString("yyyyMMddHHmm") + ".txt";

                    FileStream fs = File.Open(fileName, FileMode.CreateNew, FileAccess.Write);

                    StreamWriter sw = new StreamWriter(fs);

                    sw.Write(strFileOne);
                    sw.Close();
                    fs.Close();

                    if (changeE001 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E001 = sms_E001 + 1;");
                    if (changeE010 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E010 = sms_E010 + 1;");
                    if (changeE011 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E011 = sms_E011 + 1;");
                    if (changeE012 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E012 = sms_E012 + 1;");
                    if (changeE021 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E021 = sms_E021 + 1;");
                    if (changeE022 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E022 = sms_E022 + 1;");
                    if (changeE043 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E043 = sms_E043 + 1;");
                    if (changeH013 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H013 = sms_H013 + 1;");
                    if (changeH014 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H014 = sms_H014 + 1;");
                    if (changeH022 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H022 = sms_H022 + 1;");
                    if (changeH023 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H023 = sms_H023 + 1;");
                    if (changeH047 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H047 = sms_H047 + 1;");
                    if (changeS006 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S006 = sms_S006 + 1;");
                    if (changeS008 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S008 = sms_S008 + 1;");
                    if (changeS009 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S009 = sms_S009 + 1;");
                    if (changeS010 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S010 = sms_S010 + 1;");
                    if (changeS014 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S014 = sms_S014 + 1;");
                    if (changeS023 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S023 = sms_S023 + 1;");
                    if (changeS025 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S025 = sms_S025 + 1;");
                }
            }
            catch (Exception)
            {
                throw;
            }
            return true;
        }

        public static bool exportMaquileMovementsToSiigo(List<clsMaquile> lstPalletMovement, string folderPath, int a, bool isActiveCalendar, DateTime dtpEndMonth)
        {
            string strFileOne = "";
            string fileName = "";
            int actualMovementNumber = 0;

            bool changeE001 = false, changeE010 = false, changeE011 = false, changeE012 = false, changeE021 = false, changeE022 = false, changeE043 = false;
            bool changeH013 = false, changeH014 = false, changeH022 = false, changeH023 = false, changeH047 = false, changeS006 = false, changeS008 = false;
            bool changeS009 = false, changeS010 = false, changeS014 = false, changeS023 = false, changeS025 = false, changeE023 = false;

            try
            {
                if (a == 1)
                {
                    DataSet DS = clsConnection.getDataSetResult("SELECT * FROM bps_xtr_siigoMovementsSequential");
                    List<siigoMovements> lstSiigoMovements = new List<siigoMovements>();

                    for (int i = 0; i < lstPalletMovement.Count; i++)
                    {
                        string documentType = "";
                        string receiptCode = "";
                        string productCode = "";
                        string costCenter = "0500";
                        string costSubCenter = "001";
                        string movementType = "";
                        string cellarCode = "";
                        string quantity = clsGlobal.FillWithZeros((Math.Round(lstPalletMovement[i].weigth, 1) * 100000).ToString(), 15);

                        productCode = "0040001000342";

                        if (lstPalletMovement[i].movement == "E011")
                        {
                            documentType = "E";
                            movementType = "D";
                            receiptCode = "011";
                            cellarCode = "0019";
                        }
                        else if (lstPalletMovement[i].movement == "E012")
                        {
                            documentType = "E";
                            movementType = "D";
                            receiptCode = "012";
                            cellarCode = "0019";
                        }
                        else if (lstPalletMovement[i].movement == "S014")
                        {
                            documentType = "S";
                            movementType = "C";
                            receiptCode = "014";
                            cellarCode = "0019";
                        }
                        else
                        {
                            movementType = "C";
                            documentType = "H";
                            receiptCode = "013";
                            cellarCode = "0019";
                        }

                        lstSiigoMovements.Add(new siigoMovements());

                        lstSiigoMovements[lstSiigoMovements.Count - 1].receiptType = documentType;
                        lstSiigoMovements[lstSiigoMovements.Count - 1].receiptCode = receiptCode;
                        lstSiigoMovements[lstSiigoMovements.Count - 1].completeReceiptType = documentType + receiptCode;
                        lstSiigoMovements[lstSiigoMovements.Count - 1].productCode = productCode;
                        lstSiigoMovements[lstSiigoMovements.Count - 1].documentDate = (isActiveCalendar == true) ? dtpEndMonth.ToString("yyyyMMdd") : lstPalletMovement[i].createdDate.ToString("yyyyMMdd");
                        lstSiigoMovements[lstSiigoMovements.Count - 1].costCenter = costCenter;
                        lstSiigoMovements[lstSiigoMovements.Count - 1].costSubCenter = costSubCenter;
                        lstSiigoMovements[lstSiigoMovements.Count - 1].description = clsGlobal.FillWithSpaces(lstPalletMovement[i].mainCoilMetalCode + " - " + lstPalletMovement[i].cellarName.Replace("á", "a").Replace("é", "e").Replace("í", "i").Replace("ó", "o").Replace("ú", "u"), 50).Substring(0, 50);
                        lstSiigoMovements[lstSiigoMovements.Count - 1].creditDebit = movementType;
                        lstSiigoMovements[lstSiigoMovements.Count - 1].cellarCode = cellarCode;
                        lstSiigoMovements[lstSiigoMovements.Count - 1].quantity = quantity;
                    }

                    lstSiigoMovements.Sort();

                    string actualMovement = "";
                    int movementSequential = 0;
                    actualMovementNumber = 0;

                    for (int i = 0; i < lstSiigoMovements.Count; i++)
                    {
                        if (lstSiigoMovements[i].completeReceiptType != actualMovement)
                        {
                            actualMovement = lstSiigoMovements[i].completeReceiptType;
                            movementSequential = 1;
                        }
                        else
                            movementSequential = movementSequential + 1;

                        lstSiigoMovements[i].receiptSequence = clsGlobal.FillWithZeros(movementSequential.ToString(), 5);

                        switch (actualMovement)
                        {
                            case "E001":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E001"]);
                                changeE001 = true;
                                break;
                            case "E010":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E010"]);
                                changeE010 = true;
                                break;
                            case "E011":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E011"]);
                                changeE011 = true;
                                break;
                            case "E012":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E012"]);
                                changeE012 = true;
                                break;
                            case "E021":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E021"]);
                                changeE021 = true;
                                break;
                            case "E022":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E022"]);
                                changeE022 = true;
                                break;
                            case "E043":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E043"]);
                                changeE043 = true;
                                break;
                            case "H013":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H013"]);
                                changeH013 = true;
                                break;
                            case "H014":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H014"]);
                                changeH014 = true;
                                break;
                            case "H022":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H022"]);
                                changeH022 = true;
                                break;
                            case "H023":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H023"]);
                                changeH023 = true;
                                break;
                            case "H047":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_H047"]);
                                changeH047 = true;
                                break;
                            case "S006":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S006"]);
                                changeS006 = true;
                                break;
                            case "S008":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S008"]);
                                changeS008 = true;
                                break;
                            case "S009":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S009"]);
                                changeS009 = true;
                                break;
                            case "S010":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S010"]);
                                changeS010 = true;
                                break;
                            case "S014":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S014"]);
                                changeS014 = true;
                                break;
                            case "S023":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S023"]);
                                changeS023 = true;
                                break;
                            case "S025":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_S025"]);
                                changeS025 = true;
                                break;
                            case "E023":
                                actualMovementNumber = Convert.ToInt32(DS.Tables[0].Rows[0]["sms_E023"]);
                                changeE023 = true;
                                break;
                        }
                        lstSiigoMovements[i].receiptNumber = clsGlobal.FillWithZeros(actualMovementNumber.ToString(), 11);
                    }

                    for (int i = 0; i < lstSiigoMovements.Count; i++)
                    {
                        //FILE ONE
                        strFileOne += lstSiigoMovements[i].receiptType;  			//01   001  001	TIPO DE COMPROBANTE:  1 posicin alfanum	
                        strFileOne += lstSiigoMovements[i].receiptCode;  			//03   002  004	CDIGO COMPROBANTE:  3 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].receiptNumber;  			//11   005  015	NMERO DE DOCUMENTO:  11 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].receiptSequence;  		//05   016  020	SECUENCIA:  5 posiciones numricas.  Mximo hasta 250	
                        strFileOne += lstSiigoMovements[i].receiptNIT;  			//13   021  033	NIT:  13 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].subsidiary;  			//03   034  036	SUCURSAL:  3 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].account;  			    //10   037  046	CUENTA CONTABLE:  10 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].productCode;  			//13   047  059	CDIGO DE PRODUCTO:  13 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].documentDate;  			//08   060  067	FECHA DEL DOCUMENTO:  8 posiciones numricas (AAAAMMDD)	
                        strFileOne += lstSiigoMovements[i].costCenter;  			//04   068  071	CENTRO DE COSTO:  4 posiciones numricas		
                        strFileOne += lstSiigoMovements[i].costSubCenter;  			//03   072  074	SUBCENTRO DE COSTO:  3 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].description;  			//50   075  124	DESCRIPCIN DEL MOVIMIENTO:  50 posiciones alfanumricas, para comentario o detalle del movimiento	
                        strFileOne += lstSiigoMovements[i].creditDebit;  			//01   125  125	DBITO O CRDITO:  1 posicin alfanumrica.  Valor D  C	
                        strFileOne += lstSiigoMovements[i].value;  			        //15   126  140	VALOR DEL MOVIMIENTO:  15 posiciones numricas, 13 enteros, 2 decimales	
                        strFileOne += lstSiigoMovements[i].retentionBase;  			//15   141  155	BASE DE RETENCIN:  15 posiciones numricas, 13 enteros, 2 decimales	
                        strFileOne += lstSiigoMovements[i].sellerCode;  			//04   156  159	CDIGO DEL VENDEDOR:  4 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].cityCode;  			    //04   160  163	CDIGO DE LA CIUDAD:  4 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].zoneCode;  			    //03   164  166	CDIGO DE LA ZONA:  3 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].cellarCode;  			//04   167  170	CDIGO DE LA BODEGA:  4 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].locationCode;  			//03   171  173	CDIGO DE LA UBICACIN:  3 posiciones numricas	
                        strFileOne += lstSiigoMovements[i].quantity;  			    //15   174  188	CANTIDAD:  15 posiciones numricas, 10 enteros, 5 decimales	
                        strFileOne += lstSiigoMovements[i].crossDocumentType;  		//01   189  189	TIPO DE DOCUMENTO CRUCE:  1 posicin alfanumrica 	
                        strFileOne += lstSiigoMovements[i].crossDocumentCode;  		//03   190  192	CDIGO COMPROBANTE CRUCE:  3 posiciones alfanumricas, diferentes a espacios	
                        strFileOne += lstSiigoMovements[i].crossDocumentNumber;		//11   193  203   NMERO DE DOCUMENTO CRUCE:  11 posiciones numricas		
                        strFileOne += lstSiigoMovements[i].crossDocumentSequence;  	//03   204  206	SECUENCIA DEL DOCUMENTO CRUCE:  3 posiciones numricas.  Secuencia del documento cruce, mximo hasta 250	
                        strFileOne += lstSiigoMovements[i].crossDocumentDate;  		//08   207  214	FECHA VENCIMIENTO DE DOCUMENTO CRUCE:  8 posiciones numricas (AAAAMMDD)	
                        strFileOne += lstSiigoMovements[i].paymentTypeCode;  		//04   215  218	CDIGO FORMA DE PAGO:  4 posiciones numricas, solo se utilizan tres el primer digito debe ser cero.	
                        strFileOne += lstSiigoMovements[i].bankCode;  			    //02   219  220	CDIGO DEL BANCO:  2 posiciones numricas	                    
                        strFileOne += "\r\n";
                    }
                    fileName = folderPath + "\\m" + DateTime.Now.ToString("yyyyMMddHHmm") + ".txt";

                    FileStream fs = File.Open(fileName, FileMode.CreateNew, FileAccess.Write);

                    StreamWriter sw = new StreamWriter(fs);

                    sw.Write(strFileOne);
                    sw.Close();
                    fs.Close();

                    if (changeE001 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E001 = sms_E001 + 1;");
                    if (changeE010 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E010 = sms_E010 + 1;");
                    if (changeE011 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E011 = sms_E011 + 1;");
                    if (changeE012 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E012 = sms_E012 + 1;");
                    if (changeE021 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E021 = sms_E021 + 1;");
                    if (changeE022 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E022 = sms_E022 + 1;");
                    if (changeE043 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E043 = sms_E043 + 1;");
                    if (changeH013 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H013 = sms_H013 + 1;");
                    if (changeH014 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H014 = sms_H014 + 1;");
                    if (changeH022 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H022 = sms_H022 + 1;");
                    if (changeH023 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H023 = sms_H023 + 1;");
                    if (changeH047 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_H047 = sms_H047 + 1;");
                    if (changeS006 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S006 = sms_S006 + 1;");
                    if (changeS008 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S008 = sms_S008 + 1;");
                    if (changeS009 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S009 = sms_S009 + 1;");
                    if (changeS010 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S010 = sms_S010 + 1;");
                    if (changeS014 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S014 = sms_S014 + 1;");
                    if (changeS023 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S023 = sms_S023 + 1;");
                    if (changeS025 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_S025 = sms_S025 + 1;");
                    if (changeE023 == true)
                        clsConnection.executeQuery("UPDATE bps_xtr_siigoMovementsSequential SET sms_E023 = sms_E023 + 1;");
                }
                else
                {
                    //para importaciones
                }
            }
            catch (Exception)
            {
                throw;
            }
            return true;
        }
    }
}

