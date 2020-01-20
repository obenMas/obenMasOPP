using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BPS.Bussiness
{
    public class clsImportedRange
    {
        private string acp_filmname;
        private string acp_thiknessdata;
        private string acp_unitweightdata;
        private string acp_opacitydata;
        private string acp_sealctdata;
        private string acp_forcectdata;
        private string acp_sealcntdata;
        private string acp_forcecntdata;
        private string acp_cofdymanicdata;
        private string acp_trateddata;
        private string acp_tensioncidata;
        private string acp_tensioncedata;

        
        //Properties

        public string filmName { get { return acp_filmname; } set { acp_filmname = value; } }

        public string thiknessValues { get { return acp_thiknessdata; } set { acp_thiknessdata = value; } }

        public string unitweightValues { get { return acp_unitweightdata; } set { acp_unitweightdata = value; } }

        public string opacityValues { get { return acp_opacitydata; } set { acp_opacitydata = value; } }

        public string sealctValues { get { return acp_sealctdata; } set { acp_sealctdata = value; } }

        public string forcectValues { get { return acp_forcectdata; } set { acp_forcectdata = value; } }
        
        public string sealcntValues { get { return acp_sealcntdata; } set { acp_sealcntdata = value; } }

        public string forcecntValues { get { return acp_forcecntdata; } set { acp_forcecntdata = value; } }

        public string cofdymanicValues { get { return acp_cofdymanicdata; } set { acp_cofdymanicdata = value; } }

        public string tratedValues { get { return acp_trateddata; } set { acp_trateddata = value; } }

        public string tensionciValues { get { return acp_tensioncidata; } set { acp_tensioncidata = value; } }

        public string tensionceValues { get { return acp_tensioncedata; } set { acp_tensioncedata = value; } }

        //Constructor

        public clsImportedRange()
        {
            acp_filmname = string.Empty;
            acp_thiknessdata = "0;0";
            acp_unitweightdata = "0;0";
            acp_opacitydata = "0;0";
            acp_sealctdata = "0;0";
            acp_forcectdata = "0;0";
            acp_sealcntdata = "0;0";
            acp_forcecntdata = "0;0";
            acp_cofdymanicdata = "0;0";
            acp_trateddata = "0;0";
            acp_tensioncidata = "0;0";
            acp_tensioncedata = "0;0";
        }
    }
}
