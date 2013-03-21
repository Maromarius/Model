using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHM
{
    class Appointment
    {
        #region Fields
        public int UniqueID { get; set; }
        public bool Attended { get; set; }
        #endregion

        #region Constructors
        public Appointment(int id, bool attended)
        {
            UniqueID = id;
            Attended = attended;
        }
        #endregion
    }
}
