using BPS.Bussiness;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BPS.Extruder
{
    public class clsReProcessMP
    {

        //internal static string toSveReProcessMP(clsRawMaterial rawOBJ, double nWeight, string nGrossWeight, string Layer, int fkFormulation)
        //{
        //    var codsecRawtoList = toCreateRM(rawOBJ, nWeight, nGrossWeight);
        //    toChangeOriginal(rawOBJ);
        //    var nRP = toCreateRMP(rawOBJ, nWeight, nGrossWeight);
        //    return toSaveRM(codsecRawtoList, nWeight, nGrossWeight, Layer, fkFormulation, nRP);
        //}

        //private static int toCreateRM(clsRawMaterial rawOBJ, double nWeight, string nGrossWeight)
        //{
        //    clsRawMaterialbyCoilCellar rmOBJORIGINAL = new clsRawMaterialbyCoilCellar(rawOBJ.codsec);

        //    clsRawMaterialbyCoilCellar rwmOBJ = new clsRawMaterialbyCoilCellar();
        //    rwmOBJ.fkStatus = rmOBJORIGINAL.fkStatus;
        //    rwmOBJ.fkrawmaterial = rmOBJORIGINAL.fkrawmaterial;
        //    rwmOBJ.lotnumber = rmOBJORIGINAL.lotnumber;
        //    rwmOBJ.siigoCellar = "111";
        //    rwmOBJ.siigoMovement = "B-EXT";
        //    rwmOBJ.bag = rmOBJORIGINAL.bag;
        //    rwmOBJ.ingress = false;
        //    rwmOBJ.output = true;
        //    rwmOBJ.devolution = false;
        //    rwmOBJ.code = rmOBJORIGINAL.code;
        //    rwmOBJ.netweigth = nWeight;
        //    rwmOBJ.grossweigth = Math.Round(Convert.ToDouble(nGrossWeight), 2, MidpointRounding.AwayFromZero);
        //    rwmOBJ.order = rmOBJORIGINAL.order;
        //    rwmOBJ.provider = rmOBJORIGINAL.provider;
        //    rwmOBJ.date = DateTime.Now;
        //    rwmOBJ.movement = "Movimiento Interno Extrusión";
        //    rwmOBJ.notes = rmOBJORIGINAL.notes;
        //    rwmOBJ.isImport = rmOBJORIGINAL.isImport;
        //    rwmOBJ.isLastM = false;
        //    rwmOBJ.isPending = false;
        //    rwmOBJ.isReProcess = true;
        //    rwmOBJ.fkOrigin = rawOBJ.codsec;

        //return rwmOBJ.saveRePro(rwmOBJ.code, rmOBJORIGINAL.product);
        //}

        //private static void toChangeOriginal(clsRawMaterial rawOBJ)
        //{
        //    clsRawMaterialbyCoilCellar.setTransferMRP(rawOBJ.codsec.ToString());
        //}

        //private static int toCreateRMP(clsRawMaterial rawOBJ, double nWeight, string nGrossWeight)
        //{
        //    clsRawMaterialbyCoilCellar rmOBJORIGINAL = new clsRawMaterialbyCoilCellar(rawOBJ.codsec);

        //    clsRawMaterialbyCoilCellar rwmOBJ = new clsRawMaterialbyCoilCellar();
        //    rwmOBJ.fkStatus = rmOBJORIGINAL.fkStatus;
        //    rwmOBJ.fkrawmaterial = rmOBJORIGINAL.fkrawmaterial;
        //    rwmOBJ.lotnumber = rmOBJORIGINAL.lotnumber;
        //    rwmOBJ.siigoCellar = "111";
        //    rwmOBJ.siigoMovement = "HIJO-EXT";
        //    rwmOBJ.bag = rmOBJORIGINAL.bag;
        //    rwmOBJ.ingress = rmOBJORIGINAL.ingress;
        //    rwmOBJ.output = true;
        //    rwmOBJ.devolution = false;
        //    rwmOBJ.code = rmOBJORIGINAL.code.Replace("MP", "EXT").Replace("DMP", "EXT");
        //    rwmOBJ.netweigth = Math.Round((rmOBJORIGINAL.netweigth - nWeight), 2, MidpointRounding.AwayFromZero);
        //    rwmOBJ.grossweigth = Math.Round((rwmOBJ.netweigth + (Convert.ToDouble(nGrossWeight) - nWeight)), 2, MidpointRounding.AwayFromZero);
        //    rwmOBJ.order = rmOBJORIGINAL.order;
        //    rwmOBJ.provider = rmOBJORIGINAL.provider;
        //    rwmOBJ.date = DateTime.Now;
        //    rwmOBJ.movement = "Movimiento Interno Extrusión ReProceso Listado Backload";
        //    rwmOBJ.notes = rmOBJORIGINAL.notes;
        //    rwmOBJ.isImport = rmOBJORIGINAL.isImport;
        //    rwmOBJ.isLastM = true;
        //    rwmOBJ.isPending = true;
        //    rwmOBJ.isReProcess = true;
        //    rwmOBJ.fkOrigin = rawOBJ.codsec;

        //    return rwmOBJ.saveRePro(rwmOBJ.code, rmOBJORIGINAL.product);
        //}

        //private static string toSaveRM(int codsecRM, double nWeight, string nGrossWeight, string Layer, int fkFormulation, int nRP)
        //{
        //    string isValidProcess = "";

        //    clsRawMaterialbyCoilCellar rawOBJ = new clsRawMaterialbyCoilCellar(codsecRM);

        //    clsRawMaterialByFormulation objRW = new clsRawMaterialByFormulation();
        //    objRW.fkRawMaterial = rawOBJ.fkrawmaterial;
        //    objRW.fkFormulation = fkFormulation;
        //    objRW.percentage = 0;

        //    if (Layer == "CL-DMT")
        //    {
        //        objRW.CentralLayer = true;
        //        objRW.layerC1 = false;
        //        objRW.layerC2 = false;
        //    }

        //    if (Layer == "L1-DMT")
        //    {
        //        objRW.CentralLayer = false;
        //        objRW.layerC1 = true;
        //        objRW.layerC2 = false;
        //    }

        //    if (Layer == "L2-DMT")
        //    {
        //        objRW.CentralLayer = false;
        //        objRW.layerC1 = false;
        //        objRW.layerC2 = true;
        //    }

        //    objRW.weigth = rawOBJ.netweigth;
        //    objRW.lotnumber = rawOBJ.lotnumber;
        //    objRW.isSummary = false;
        //    objRW.fkRaw = codsecRM;

        //    if (objRW.saveReaload())
        //    {
        //        clsSummaryRM.getSummary(objRW);
        //        isValidProcess = rawOBJ.code.Replace("MP", "EXT").Replace("DMP", "EXT") + ";" + nRP.ToString();
        //    }
        //    else
        //        isValidProcess = "";

        //    return isValidProcess;
        //}

        //private static string checkVersion(string code)
        //{
        //    int value = 1;
        //    DataSet DS = new DataSet();
        //    //SERVER
        //    DS = clsConnection.getDataSetResult("SELECT COALESCE(COUNT(rwmc_codsec),0) AS codes FROM bps_prod_rawmaterialbycoilcellar " +
        //        "WHERE rwmc_movement = 'Movimiento Interno Extrusión ReProceso Listado Backload' AND rwmc_code='" + code + "'");

        //    if (DS.Tables[0].Rows.Count > 0)
        //        value = Convert.ToInt32(DS.Tables[0].Rows[0][0].ToString()) + 1;

        //    return value.ToString();
        //}

        internal static string toSaveReProcessMP(clsRawMaterialExtruder rawOBJ, double nWeight, string Layer, int fkFormulation)
        {
            string result = "";
            double resultW = Math.Round((rawOBJ.netWeigth - nWeight), 2, MidpointRounding.AwayFromZero);
            string nCode = rawOBJ.code;

            if (clsRawMaterialExtruder.setReProcess(nWeight, rawOBJ.codsec.ToString(), rawOBJ.isParent))
            {
                result = toCreateRM(rawOBJ, resultW, nCode).ToString();

                if (!string.IsNullOrEmpty(result))
                    toSaveRM(rawOBJ, Layer, fkFormulation, result, nWeight);
                else
                    result = "";
            }
            else
                result = "";

            return result;
        }

        private static string GenerateCode()
        {
            var number = clsSequential.SequentialList("extRM");
            string code = "EXT" + DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + clsGlobal.FillWithZeros(((number).ToString()), 5);
            clsSequential.addSequential("extRM");
            return code;
        }

        private static int toCreateRM(clsRawMaterialExtruder rawOBJ, double nWeight, string code)
        {
            clsRawMaterialExtruder rwmOBJ = new clsRawMaterialExtruder();
            rwmOBJ.fkRaw = rawOBJ.fkRaw;
            rwmOBJ.fkMaterial = rawOBJ.fkMaterial;
            rwmOBJ.lotNumber = rawOBJ.lotNumber;
            rwmOBJ.bag = rawOBJ.bag;
            rwmOBJ.code = code;
            rwmOBJ.netWeigth = nWeight;
            rwmOBJ.isParent = false;
            rwmOBJ.isSon = true;
            rwmOBJ.isProcess = false;

            return rwmOBJ.toSave();
        }

        private static string toSaveRM(clsRawMaterialExtruder rawOBJ, string Layer, int fkFormulation, string nRP, double nWeigth)
        {
            string isValidProcess = "";

            clsRawMaterialByFormulation objRW = new clsRawMaterialByFormulation();
            objRW.fkRawMaterial = rawOBJ.fkMaterial;
            objRW.fkFormulation = fkFormulation;
            objRW.percentage = 0;

            if (Layer == "CL-DMT" || Layer == "CL-MW")
            {
                objRW.CentralLayer = true;
                objRW.layerC1 = false;
                objRW.layerC2 = false;
                objRW.layerC3 = false;
                objRW.layerC4 = false;
            }

            if (Layer == "L1-DMT" || Layer == "S1-MW")
            {
                objRW.CentralLayer = false;
                objRW.layerC1 = true;
                objRW.layerC2 = false;
                objRW.layerC3 = false;
                objRW.layerC4 = false;
            }

            if (Layer == "L2-DMT" || Layer == "S2-MW")
            {
                objRW.CentralLayer = false;
                objRW.layerC1 = false;
                objRW.layerC2 = true;
                objRW.layerC3 = false;
                objRW.layerC4 = false;
            }

            if (Layer == "L3-DMT")
            {
                objRW.CentralLayer = false;
                objRW.layerC1 = false;
                objRW.layerC2 = false;
                objRW.layerC3 = true;
                objRW.layerC4 = false;
            }

            if (Layer == "L4-DMT")
            {
                objRW.CentralLayer = false;
                objRW.layerC1 = false;
                objRW.layerC2 = false;
                objRW.layerC3 = false;
                objRW.layerC4 = true;
            }

            objRW.weigth = nWeigth;
            objRW.lotnumber = rawOBJ.lotNumber;
            objRW.isSummary = false;
            objRW.fkRaw = rawOBJ.codsec;

            if (objRW.saveReaload())
            {
                clsSummaryRM.getSummary(objRW);
                isValidProcess = nRP;
            }
            else
                isValidProcess = "";

            return isValidProcess;
        }
    }
}



