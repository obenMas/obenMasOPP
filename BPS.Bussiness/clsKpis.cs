using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BPS.Business
{
    public class clsKpis
    {
        // Atributes
        private int kpi_codsec;
        private double kpi_prodExt;
        private double kpi_recupCons;
        private int kpi_recovery;
        private double kpi_prodPrimary;
        private double kpi_repProm;
        private double kpi_scrapAtlas;
        private double kpi_prodGnrl;
        private int kpi_coilQuantity;
        private double kpi_coilProm;
        private double kpi_scrapGnrl;
        private double kpi_prodMetal;
        private double kpi_scrapMetal;
        private double kpi_prodSecund;
        private double kpi_scrapSecun;
        private int kpi_invLocal;
        private int kpi_invRev;
        private int kpi_ageProm;
        private int kpi_agePromRev;
        private double kpi_dispatchPTL;
        private double kpi_dispatchPTI;
        private int kpi_rotationPTL;
        private int kpi_rotationPTI;
        private int kpi_complaints;
        private double kpi_kgComplaints;
        private int kpi_apprvedComplaints;
        private double kpi_kgApprvComplaints;


        // Properties
        public int codsec { get { return kpi_codsec; } set { kpi_codsec = value; } }
        public double prodExt { get { return kpi_prodExt; } set { kpi_prodExt = value; } }
        public double recupCons { get { return kpi_recupCons; } set { kpi_recupCons = value; } }
        public int recovery { get { return kpi_recovery; } set { kpi_recovery = value; } }
        public double prodPrimary { get { return kpi_prodPrimary; } set { kpi_prodPrimary = value; } }
        public double repProm { get { return kpi_repProm; } set { kpi_repProm = value; } }
        public double scrapAtlas { get { return kpi_scrapAtlas; } set { kpi_scrapAtlas = value; } }
        public double prodGnrl { get { return kpi_prodGnrl; } set { kpi_prodGnrl = value; } }
        public int coilQuantity { get { return kpi_coilQuantity; } set { kpi_coilQuantity = value; } }
        public double coilProm { get { return kpi_coilProm; } set { kpi_coilProm = value; } }
        private double scrapGnrl { get { return kpi_scrapGnrl; } set { kpi_scrapGnrl = value; } }
        private double prodMetal { get { return kpi_prodMetal; } set { kpi_prodMetal = value; } }
        private double scrapMetal { get { return kpi_scrapMetal; } set { kpi_scrapMetal = value; } }
        private double prodSecund { get { return kpi_prodSecund; } set { kpi_prodSecund = value; } }
        private double scrapSecun { get { return kpi_scrapSecun; } set { kpi_scrapSecun = value; } }
        private int invLocal { get { return kpi_invLocal; } set { kpi_invLocal = value; } }
        private int invRev { get { return kpi_invRev; } set { kpi_invRev = value; } }
        private int ageProm { get { return kpi_ageProm; } set { kpi_ageProm = value; } }
        public int agePromRev { get { return kpi_agePromRev; } set { kpi_agePromRev = value; } }
        public double dispatchPTL { get { return kpi_dispatchPTL; } set { kpi_dispatchPTL = value; } }
        public double dispatchPTI { get { return kpi_dispatchPTI; } set { kpi_dispatchPTI = value; } }
        public int rotationPTL { get { return kpi_rotationPTL; } set { kpi_rotationPTI = value; } }
        public int complaints { get { return kpi_complaints; } set { kpi_complaints = value; } }
        public double kgComplaints { get { return kpi_kgComplaints; } set { kpi_kgComplaints = value; } }
        public int apprvedComplaints { get { return kpi_apprvedComplaints; } set { kpi_apprvedComplaints = value; } }
        private double kgapprvedComplaints { get { return kpi_kgApprvComplaints; } set { kpi_kgApprvComplaints = value; } }

        // Constructor
        public clsKpis()
        {
            codsec = 0;
            prodExt = 0;
            recupCons = 0;
            recovery = 0;
            prodPrimary = 0;
            repProm = 0;
            scrapAtlas = 0;
            prodGnrl = 0;
            coilQuantity = 0;
            coilProm = 0;
            scrapGnrl = 0;
            prodMetal = 0; 
            scrapMetal = 0;
            prodSecund= 0; 
            scrapSecun = 0;
            invLocal = 0;
            invRev = 0;
            ageProm = 0;
            agePromRev = 0;
            dispatchPTL = 0;
            dispatchPTI = 0;
            rotationPTL= 0; 
            complaints = 0;
            kgComplaints = 0;
            apprvedComplaints = 0;
            kgapprvedComplaints = 0;

        }

        // Methods
        public static bool save()
        {
            return true;
        }

        private void load()
        {

        }
    }
}
