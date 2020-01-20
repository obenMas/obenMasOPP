using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BPS.Bussiness
{
    public class clsMyHerency
    {
        private int prmm_codsec;

        public int codsec
        {
            get { return prmm_codsec; }
            set { prmm_codsec = value; }
        }

        private int prmm_fkBopp;

        public int fkBopp
        {
            get { return prmm_fkBopp; }
            set { prmm_fkBopp = value; }
        }

        private int prmm_fkCast;

        public int fkCast
        {
            get { return prmm_fkCast; }
            set { prmm_fkCast = value; }
        }

        private string prmm_notes;

        public string notes
        {
            get { return prmm_notes; }
            set { prmm_notes = value; }
        }

        private string treq_source;

        public string source
        {
            get { return treq_source; }
            set { treq_source = value; }
        }

        private string treq_name;

        public string name
        {
            get { return treq_name; }
            set { treq_name = value; }
        }

        private string treq_id;

        public string id
        {
            get { return treq_id; }
            set { treq_id = value; }
        }

        private string treq_description;

        public string description
        {
            get { return treq_description; }
            set { treq_description = value; }
        }

        private int req_fkType;

        public int fkType
        {
            get { return req_fkType; }
            set { req_fkType = value; }
        }

        private int req_fkRol;

        public int fkRol
        {
            get { return req_fkRol; }
            set { req_fkRol = value; }
        }

        private int req_fkStatus;

        public int fkStatus
        {
            get { return req_fkStatus; }
            set { req_fkStatus = value; }
        }

        private int req_fkUser;

        public int fkUser
        {
            get { return req_fkUser; }
            set { req_fkUser = value; }
        }

        private int req_number;

        public int number
        {
            get { return req_number; }
            set { req_number = value; }
        }

        private string req_priority;

        public string priority
        {
            get { return req_priority; }
            set { req_priority = value; }
        }

        private string req_manager;

        public string manager
        {
            get { return req_manager; }
            set { req_manager = value; }
        }

        private string req_firtsName;

        public string firstName
        {
            get { return req_firtsName; }
            set { req_firtsName = value; }
        }

        private string req_lastName;

        public string lastName
        {
            get { return req_lastName; }
            set { req_lastName = value; }
        }

        private bool req_isVisible;

        public bool isVisible
        {
            get { return req_isVisible; }
            set { req_isVisible = value; }
        }

        private DateTime req_creadtedDate;

        public DateTime createdDate
        {
            get { return req_creadtedDate; }
            set { req_creadtedDate = value; }
        }

        private DateTime req_modifiedDate;

        public DateTime modifiedDate
        {
            get { return req_modifiedDate; }
            set { req_modifiedDate = value; }
        }

        private int req_createdBy;

        public int createdBy
        {
            get { return req_createdBy; }
            set { req_createdBy = value; }
        }

        private int req_modifiedBy;

        public int modifiedBy
        {
            get { return req_modifiedBy; }
            set { req_modifiedBy = value; }
        }

        private string req_rolName;

        public string rolName
        {
            get { return req_rolName; }
            set { req_rolName = value; }
        }

        private int req_statusCodsec;

        public int statusCodsec
        {
            get { return req_statusCodsec; }
            set { req_statusCodsec = value; }
        }


        private string req_statusName;

        public string statusName
        {
            get { return req_statusName; }
            set { req_statusName = value; }
        }

        private int req_userCodsecForRequest;

        public int userCodsecForRequest
        {
            get { return req_userCodsecForRequest; }
            set { req_userCodsecForRequest = value; }
        }

        private string req_userForRequestUserName;

        public string userForRequestUserName
        {
            get { return req_userForRequestUserName; }
            set { req_userForRequestUserName = value; }
        }

        private string req_userForRequestFirstName;

        public string userForRequestFirtsName
        {
            get { return req_userForRequestFirstName; }
            set { req_userForRequestFirstName = value; }
        }

        private string req_userForRequestLastName;

        public string userForRequestLastName
        {
            get { return req_userForRequestLastName; }
            set { req_userForRequestLastName = value; }
        }


        private string req_departament;

        public string departament
        {
            get { return req_departament; }
            set { req_departament = value; }
        }

        private List<clsUser> req_lstUserCreator;

        public List<clsUser> lstUserCreator
        {
            get { return req_lstUserCreator; }
            set { req_lstUserCreator = value; }
        }

        private List<clsUser> req_lstUserModificator;

        public List<clsUser> lstUserModificator
        {
            get { return req_lstUserModificator; }
            set { req_lstUserModificator = value; }
        }

        private List<clsUser> req_lstUserMain;

        public List<clsUser> lstUserMain
        {
            get { return req_lstUserMain; }
            set { req_lstUserMain = value; }
        }

        private DateTime req_isApprovedDate;

        public DateTime isApprovedDate
        {
            get { return req_isApprovedDate; }
            set { req_isApprovedDate = value; }
        }

        private string req_isApprovedNotes;

        public string isApprovedNotes
        {
            get { return req_isApprovedNotes; }
            set { req_isApprovedNotes = value; }
        }

        private int dtt_fkDeadTime;

        public int fkDeadTime
        {
            get { return dtt_fkDeadTime; }
            set { dtt_fkDeadTime = value; }
        }

        private int dtt_source;

        public int sourceDeadTime
        {
            get { return dtt_source; }
            set { dtt_source = value; }
        }

        private TimeSpan dtt_time;

        public TimeSpan timeDeadTime
        {
            get { return dtt_time; }
            set { dtt_time = value; }
        }

        private int for_fkFormulation;

        public int fkFormulation
        {
            get { return for_fkFormulation; }
            set { for_fkFormulation = value; }
        }

        private clsFormulation obj_Formulation;

        public clsFormulation objFormulation
        {
            get { return obj_Formulation; }
            set { obj_Formulation = value; }
        }

        private List<clsFormulation> lst_Formulation;

        public List<clsFormulation> lstFormulation
        {
            get { return lst_Formulation; }
            set { lst_Formulation = value; }
        }

        private clsProductionOrder obj_productionOrder;

        public clsProductionOrder objProductionorder
        {
            get { return obj_productionOrder; }
            set { obj_productionOrder = value; }
        }

        private List<clsProductionOrder> lst_productionOrder;

        public List<clsProductionOrder> lstProductionOrder
        {
            get { return lst_productionOrder; }
            set { lst_productionOrder = value; }
        }

        private string for_liable;

        public string liable
        {
            get { return for_liable; }
            set { for_liable = value; }
        }

        private string for_trataiment;

        public string tratiment
        {
            get { return for_trataiment; }
            set { for_trataiment = value; }
        }

        private string for_transform;

        public string transform
        {
            get { return for_transform; }
            set { for_transform = value; }
        }

        private string for_power;

        public string power
        {
            get { return for_power; }
            set { for_power = value; }
        }

        private int for_fkProductionOrder;

        public int fkProductionOrder
        {
            get { return for_fkProductionOrder; }
            set { for_fkProductionOrder = value; }
        }

        private clsProductionOrderDetail obj_productionorderdetail;

        public clsProductionOrderDetail objProductionOrderDetail
        {
            get { return obj_productionorderdetail; }
            set { obj_productionorderdetail = value; }
        }


        private List<clsProductionOrderDetail> lst_productionorderdetail;

        public List<clsProductionOrderDetail> lstProductionOrderDetail
        {
            get { return lst_productionorderdetail; }
            set { lst_productionorderdetail = value; }
        }

        private clsFilmProductionPlan obj_filmproductionplan;

        public clsFilmProductionPlan objFilmProductionPlan
        {
            get { return obj_filmproductionplan; }
            set { obj_filmproductionplan = value; }
        }


    }
}
