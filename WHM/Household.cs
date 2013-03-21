using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WHM
{
    class Household
    {
        #region Fields

        public int UniqueID { get; set; }
        public List<int> Appointments { get; set; }
        public Flag Flag { get; set; }
        public string Notes { get; set; }
        public Primary PrimaryDependant { get; set; }
        public List<Dependant> Dependants { get; set; }
        public bool Exists
        {
            get
            {
                return PrimaryDependant != null;
            }
        }
    
        #endregion

        #region Constructors

        private Household()
        {
        }

        public Household(Primary primaryDependant)
        {
            PrimaryDependant = primaryDependant;
        }

        #endregion


        public void SetPrimaryDependant(Primary primaryDependant)
        {
            PrimaryDependant = primaryDependant;
        }

        public void AddDependant(Dependant dep)
        {
            // A dependant can only be added to the list of dependants iff a primary dependant exists, else it is discarded.
            // A household exists iff a primary dependant exists
            if (Exists)
            {
                Dependants.Add(dep);
            }
        }

        public void AddAppointment(int uniqueid)
        {
            Appointments.Add(uniqueid);
        }
        
    }
}
