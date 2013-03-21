using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHM
{
    class HouseholdAppointment : Appointment
    {
        public Household Household { get; set; }

        public HouseholdAppointment(Household house, int id, bool attended)
            : base(id, attended)
        {
            Household = house;
        }
    }
}
