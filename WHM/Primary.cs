using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WHM
{
    class Primary
    {
        #region Fields

        public Dependant Dependant { get; set; }
        public Address Address { get; set; }
        public string MaritalStatus { get; set; }
        public string WorkStatus { get; set; }
        public int Income { get; set; }
        public string CanadianStatus { get; set; }
        public string Origin { get; set; }
        public string MotherTongue { get; set; }
        public string CommunicationLanguage { get; set; }
        public string Referral { get; set; }
        //UOS = Reasong for use of Service
        public string RUOS { get; set; }
        public DateTime DateRegistered { get; set; }

        #endregion

        #region Constructors
        
        public Primary(Dependant dependant, Address address, string maritalStatus, string workStatus, int income, string canadianStatus, string origin, string motherTongue, string communicationLanguage, string referral, string ruos, DateTime dateRegistered)
        {
           
            Dependant = dependant;
            Address = address;
            MaritalStatus = maritalStatus;
            WorkStatus = workStatus;
            Income = income;
            Origin = origin;
            CanadianStatus = canadianStatus;
            MotherTongue = motherTongue;
            CommunicationLanguage = communicationLanguage;
            Referral = referral ;
            RUOS = ruos;
            DateRegistered = dateRegistered;
        }
        
        #endregion

        
        

    }
}
