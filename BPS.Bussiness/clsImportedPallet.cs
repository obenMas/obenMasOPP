using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BPS.Bussiness
{
    public class clsImportedPallet
    {
        //Attibutes

        string iplt_importedProductCode;
        int iplt_importedWidth;
        string iplt_diameterCore;
        string iplt_code;
        double iplt_netWeight;
        double iplt_grossWeight;
        string iplt_date;
        List<clsImportedCoil> iplt_lstImportedCoil = new List<clsImportedCoil>();

        string cus_id;
        string cus_name;
        string cus_contact;
        string cus_adress;
        string cus_country;
        string cus_city;        
        string cus_phone1;
        string cus_phone2;
        string cus_fax;
        string cus_email;
        string cus_destinationOrder;

        private int feq_fkBopp;
        private int feq_fkCast;
        private string feq_externalId;
        private string feq_externalDescription;
        private string feq_externalCode;
        

        //Properties

        public string importedProductCode { get { return iplt_importedProductCode; } set { iplt_importedProductCode = value; } }

        public int importedWidth { get { return iplt_importedWidth; } set { iplt_importedWidth = value; } }

        public string diameterCore { get { return iplt_diameterCore; } set { iplt_diameterCore = value; } }

        public string code { get { return iplt_code; } set { iplt_code = value; } }

        public double netWeight { get { return iplt_netWeight; } set { iplt_netWeight = value; } }

        public double grossWeight { get { return iplt_grossWeight; } set { iplt_grossWeight = value; } }

        public string date { get { return iplt_date; } set { iplt_date = value; } }

        public List<clsImportedCoil> lstImportedCoil { get { return iplt_lstImportedCoil; } set { iplt_lstImportedCoil = value; } }

        public string id { get { return cus_id; } set { cus_id = value; } }

        public string name { get { return cus_name; } set { cus_name = value; } }

        public string contact { get { return cus_contact; } set { cus_contact = value; } }

        public string adress { get { return cus_adress; } set { cus_adress = value; } }

        public string country { get { return cus_country; } set { cus_country = value; } }

        public string city { get { return cus_city; } set { cus_city = value; } }

        public string phone1{get { return cus_phone1; }set { cus_phone1 = value; }}

        public string phone2 { get { return cus_phone2; } set { cus_phone2 = value; } }

        public string fax { get { return cus_fax; } set { cus_fax = value; } }

        public string email { get { return cus_email; } set { cus_email = value; } }

        public string destinationOrder { get { return cus_destinationOrder; } set { cus_destinationOrder = value; } }

        public int fkBopp { get { return feq_fkBopp; } set { feq_fkBopp = value; } }

        public string Id { get { return feq_externalId; } set { feq_externalId = value; } }

        public string description { get { return feq_externalDescription; } set { feq_externalDescription = value; } }

        public int fkCast { get { return feq_fkCast; } set { feq_fkCast = value; } }

        public string codes { get { return feq_externalCode; } set { feq_externalCode = value; } }


        //Constructor

        public clsImportedPallet()
        {
            importedProductCode = "";
            importedWidth = 0;
            diameterCore = "";
            code = "";
            netWeight = 0;
            grossWeight = 0;
            date = "";
            lstImportedCoil = new List<clsImportedCoil>();
            id = "";
            name = "";
            contact = "";
            country = "";
            city = "";
            phone1 = "";
            phone2 = "";
            fax = "";
            email = "";
            destinationOrder = "";
            feq_fkBopp = 0;
            feq_externalId = "";
            feq_externalDescription = "";
            feq_fkCast = 0;
            feq_externalCode = "";
        }

        //Methods



    }
}
