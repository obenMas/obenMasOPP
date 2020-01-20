using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;

namespace BPS.Bussiness
{
    public class clsXportSalesOrderToSIIGO
    {
        public static bool exportSalesOrderToSiigo(List<clsSalesOrder> lstSalesOrder, string folderPath, bool isInternationalSalesOrder)
        {
            string strFileOne = "";
            string strFileTwo = "";
            string fileName = "";

            try
            {
                for (int i = 0; i < lstSalesOrder.Count; i++)
                {
                    for (int j = 0; j < lstSalesOrder[i].lstSalesOrderDetail.Count; j++)
                    {
                        //FILE ONE
                        strFileOne += "Z";                                                                                                                      // 01   001 – 001	TIPO DE PEDIDO:  1 posición alfanumérica
                        strFileOne += (isInternationalSalesOrder) ? "008" : "009";                                                                              // 03   002 – 004	CÓDIGO COMPROBANTE PEDIDO:  3 posiciones numéricas
                        strFileOne += clsGlobal.FillWithZeros(lstSalesOrder[i].number, 11);                                                                     // 11   005 – 015	NÚMERO DE DOCUMENTO PEDIDO:  11 posiciones numéricas
                        strFileOne += clsGlobal.FillWithZeros((j + 1).ToString(), 3);                                                                           // 03   016 – 018	SECUENCIA:  3 posiciones numéricas.  Máximo hasta 250
                        strFileOne += lstSalesOrder[i].createdDate.ToString("yyyyMMdd");                                                                        // 08   019 – 026	FECHA DEL DOCUMENTO:  8 posiciones numéricas (AAAAMMDD)
                        strFileOne += lstSalesOrder[i].createdDate.ToString("yyyyMMdd");                                                                        // 08   027 – 034	FECHA DE ENTREGA:  8 posiciones numéricas (AAAAMMDD)
                        strFileOne += clsGlobal.FillWithZeros(lstSalesOrder[i].EntityID, 13);                                                                   // 13   035 – 047	NIT:  13 posiciones numéricas
                        strFileOne += "000";                                                                                                                    // 03   048 – 050	SUCURSAL:  3 posiciones numéricas
                        strFileOne += "0610";                                                                                                                   // 04   051 – 054	CENTRO DE COSTO: 4 posiciones numéricas
                        strFileOne += (isInternationalSalesOrder) ? "003" : "002";                                                                              // 03   055 – 057	SUBCENTRO DE COSTO: 3 posiciones numéricas
                        strFileOne += "0003";                                                                                                                   // 04   058 – 061	CODIGO DE LA BODEGA:  4 posiciones numéricas
                        strFileOne += "001";                                                                                                                    // 03   062 – 064	CÓDIGO DE LA UBICACIÓN:  3 posiciones numéricas
                        strFileOne += (isInternationalSalesOrder) ? "0014" : "0013";                                                                            // 04   065 – 068	CODIGO DEL VENDEDOR:  4 posiciones numéricas
                        strFileOne += "01";                                                                                                                     // 02   069 – 070	CODIGO DE LA MONEDA: 2 posiciones numéricas
                        strFileOne += clsGlobal.FillWithZeros(clsProduct.getExternalERPCode(lstSalesOrder[i].lstSalesOrderDetail[j].product), 13);              // 13   071 – 083	CÓDIGO DEL PRODUCTO:  13 posiciones numéricas
                        strFileOne += clsGlobal.FillWithZeros((Math.Round(lstSalesOrder[i].lstSalesOrderDetail[j].quantity, 5) * 100000).ToString(), 14);       // 14   084 – 097	CANTIDAD DEL PRODUCTO: 14 posiciones numéricas, 9 enteros, 5 decimales 
                        strFileOne += clsGlobal.FillWithZeros((Math.Round(lstSalesOrder[i].lstSalesOrderDetail[j].quantity * 
                                                               lstSalesOrder[i].lstSalesOrderDetail[j].price, 2) * 100).ToString(), 15);                        // 15   098 – 112	VALOR DEL PEDIDO:  15 posiciones numéricas; 13 enteros, 2 decimales
                        strFileOne += "00000000000";                                                                                                            // 11   113 – 123	VALOR DEL PEDIDO EN EXTRANJERA:  11 posiciones numéricas; 9 enteros, 2 decimales
                        strFileOne += "000000000000000";                                                                                                        // 15   124 – 138	CANTIDAD FACTOR DE CONVERSIÓN: 15 posiciones numéricas; 10 enteros, 5 decimales  (en este campo va la cantidad convertida después de aplicarle un factor de conversión), si no aplica el campo va en ceros
                        strFileOne += "0";                                                                                                                      // 01   139 - 139	OPERANDO DEL FACTOR DE CONVERSIÓN:  1 posición numérica.  En este campo se debe indicar que factor del 1 al 5 se utiliza para la conversión de lo contrario va en ceros.
                        strFileOne += "0000100000";                                                                                                             // 10   140 – 149	FACTOR DE CONVERSIÓN A APLICAR:  Campo numérico de 10 posiciones; 5 enteros, 5 decimales
                        strFileOne += "0001";                                                                                                                   // 04   150 – 153	CIUDAD:  4 posiciones numéricas
                        strFileOne += "000";                                                                                                                    // 03   154 – 156	ZONA:  3 posiciones numéricas
                        strFileOne += "0000000";                                                                                                                // 07   157 – 163	NUMERO DE LA PLACA:  7 posiciones alfanuméricas 
                        strFileOne += clsGlobal.FillWithZeros((Math.Round(lstSalesOrder[i].lstSalesOrderDetail[j].price, 2) * 100).ToString(), 13);             // 13   164 – 176	VALOR UNITARIO DEL PRODUCTO:  13 posiciones numéricas; 11 enteros, 2 decimales
                        strFileOne += "\r\n";


                        //FILE TWO
                        strFileTwo += "0000000000000";                                                                                                          // 13   001 – 013	VALOR PRIMER CARGO:  13 posiciones numéricas; 11 enteros, 2 decimales
                        strFileTwo += "00000";                                                                                                                  // 05   014 – 018	PORCENTAJE PRIMER CARGO: 5 posiciones numéricas; 3 enteros, 2 decimales
                        strFileTwo += "0000000000000";                                                                                                          // 13   019 – 031	VALOR SEGUNDO CARGO:  13 posiciones numéricas; 11 enteros, 2 decimales
                        strFileTwo += "00000";                                                                                                                  // 05   032 – 036	PORCENTAJE SEGUNDO CARGO: 5 posiciones numéricas; 3 enteros, 2 decimales
                        if (isInternationalSalesOrder)
                        {
                            strFileTwo += "0000000000000";                                                                                                          // 13   037 – 049	VALOR TERCER CARGO:  13 posiciones numéricas; 11 enteros, 2 decimales
                            strFileTwo += "00000";                                                                                                                  // 05   050 – 054	PORCENTAJE TERCER CARGO: 5 posiciones numéricas; 3 enteros, 2 decimales
                        }
                        else
                        { 
                            strFileTwo += clsGlobal.FillWithZeros((Math.Round(lstSalesOrder[i].lstSalesOrderDetail[j].quantity *
                                                                   lstSalesOrder[i].lstSalesOrderDetail[j].price * 0.12, 2) * 100).ToString(), 13);                 // 13   037 – 049	VALOR TERCER CARGO:  13 posiciones numéricas; 11 enteros, 2 decimales
                            strFileTwo += "01200";                                                                                                                  // 05   050 – 054	PORCENTAJE TERCER CARGO: 5 posiciones numéricas; 3 enteros, 2 decimales
                        }
                        strFileTwo += "0000000000000";                                                                                                          // 13   055 – 067	VALOR PRIMER DESCUENTO:  13 posiciones numéricas; 11 enteros, 2 decimales
                        strFileTwo += "00000";                                                                                                                  // 05   068 – 072	PORCENTAJE PRIMER DESCUENTO: 5 posiciones numéricas; 3 enteros, 2 decimales
                        strFileTwo += "0000000000000";                                                                                                          // 13   073 – 085	VALOR SEGUNDO DESCUENTO:  13 posiciones numéricas; 11 enteros, 2 decimales
                        strFileTwo += "00000";                                                                                                                  // 05   086 – 090	PORCENTAJE SEGUNDO DESCUENTO: 5 posiciones numéricas; 3 enteros, 2 decimales
                        strFileTwo += "0000000000000";                                                                                                          // 13   091 – 103	VALOR TERCER DESCUENTO:  13 posiciones numéricas; 11 enteros, 2 decimales
                        strFileTwo += "00000";                                                                                                                  // 05   104 – 108	PORCENTAJE TERCER DESCUENTO: 5 posiciones numéricas; 3 enteros, 2 decimales
                        strFileTwo += "0000000000000";                                                                                                          // 13   109 – 121	VALOR IMPOCONSUMO:  13 posiciones numéricas; 11 enteros, 2 decimales
                        strFileTwo += clsGlobal.FillWithSpaces(clsProduct.getExternalERPDescription(lstSalesOrder[i].lstSalesOrderDetail[j].product), 50);      // 50   122 – 171	DESCRIPCIÓN DEL ITEM:  50 posiciones alfanuméricas
                        strFileTwo += "00000";                                                                                                                  // 05   172 – 176	PORCENTAJE IMPOCONSUMO: 5 posiciones numéricas; 3 enteros, 2 decimales
                        strFileTwo += "00000";                                                                                                                  // 05   177 – 181	PORCENTAJE IMPUESTO AL DEPORTE: 5 posiciones numéricas; 3 enteros, 2 decimales
                        strFileTwo += "0000000000000";                                                                                                          // 13   182 – 194	VALOR IMPUESTO AL DEPORTE:  13 posiciones numéricas; 11 enteros, 2 decimales
                        strFileTwo += "00";                                                                                                                     // 02   195 - 196	COMPROBANTE ORDEN DE COMPRA: 2 posiciones numéricas, 3 enteros (PERU)
                        strFileTwo += "00000000000";                                                                                                            // 11   197 - 207	NUMERO ORDEN DE COMPRA: 11 posiciones numéricas, 11 enteros (PERU)
                        strFileTwo += "\r\n";
                    }
                }

                fileName = folderPath + "\\File1" + DateTime.Now.ToString("yyyyMMddHHmm") + ".txt";

                FileStream fs = File.Open(fileName, FileMode.CreateNew, FileAccess.Write);
                
                StreamWriter sw = new StreamWriter(fs);

                sw.Write(strFileOne);
                sw.Close();
                fs.Close();

                fileName = folderPath + "\\File2" + DateTime.Now.ToString("yyyyMMddHHmm") + ".txt";

                fs = File.Open(fileName, FileMode.CreateNew, FileAccess.Write);

                sw = new StreamWriter(fs);

                sw.Write(strFileTwo);
                sw.Close();

                for (int i = 0; i < lstSalesOrder.Count; i++)
                    clsConnection.executeQuery("UPDATE bps_com_salesOrder SET sord_exportedToERP = 1 WHERE sord_codsec = " + lstSalesOrder[i].codsec.ToString());

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
