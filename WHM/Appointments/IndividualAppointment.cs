using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHM
{
    class IndividualAppointment : Appointment
    {
        public Dependant Dependant { get; set; }

        public IndividualAppointment(Dependant dep, int id, bool attended)
            : base(id, attended)
        {
            Dependant = dep;
        }
    }
}
