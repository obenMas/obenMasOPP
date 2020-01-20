using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BPS.Bussiness
{
    public class clsImportedCoil
    {
        //Attributes

        string icoil_importedProductCode;
        int icoil_importedWidth;
        string icoil_diameterCore;
        string icoil_code;
        double icoil_netWeight;
        double icoil_length;
        double icoil_diameter;
        string icoil_mainCoilCode;
        string icoil_lotNumber;
        string icoil_extrusionDate;
        string icoil_destinationOrder;

        //Properties

        public string importedProductCode { get { return icoil_importedProductCode; } set { icoil_importedProductCode = value; } }

        public int importedWidth { get { return icoil_importedWidth; } set { icoil_importedWidth = value; } }

        public string diameterCore { get { return icoil_diameterCore; } set { icoil_diameterCore = value; } }

        public string code { get { return icoil_code; } set { icoil_code = value; } }

        public double netWeight { get { return icoil_netWeight; } set { icoil_netWeight = value; } }

        public double length { get { return icoil_length; } set { icoil_length = value; } }

        public double diameter { get { return icoil_diameter; } set { icoil_diameter = value; } }

        public string mainCoilCode { get { return icoil_mainCoilCode; } set { icoil_mainCoilCode = value; } }

        public string lotNumber { get { return icoil_lotNumber; } set { icoil_lotNumber = value; } }

        public string extrusionDate { get { return icoil_extrusionDate; } set { icoil_extrusionDate = value; } }

        public string destinationOrder { get { return icoil_destinationOrder; } set { icoil_destinationOrder = value; } }


        //Constructor
        public clsImportedCoil()
        {
            importedProductCode = "";
            importedWidth = 0;
            diameterCore = "";
            code = "";
            netWeight = 0;
            length = 0;
            diameter = 0;
            mainCoilCode = "";
            lotNumber = "";
            extrusionDate = "";
        }


        //Methods



    }
}
