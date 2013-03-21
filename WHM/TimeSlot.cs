using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHM
{
    class TimeSlot
    {
        #region Fields
        
        public DateTime StartTime { get; set; }
        public int UniqueID { get; set; }
        public DateTime EndTime { get; set; }
        public int MaximumAppointments { get; set; }

        #endregion


        #region Constructors
        
        public TimeSlot(DateTime start, DateTime end, int id, int maxappt)
        {
            StartTime = start;
            EndTime = end;
            id = UniqueID;
            MaximumAppointments = maxappt;
        }

        #endregion
    }
}
