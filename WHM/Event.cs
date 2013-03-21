using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHM.Events
{
    class Event
    {
        #region Fields

        public int UniqueID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public bool Opened { get; set; }
        public DateTime Date { get; set; }
        public Event EventTemplate { get; set; }
        public Dictionary<int,TimeSlot> TimeSlots { get; set; }

        #endregion

        #region Constructors

        public Event(int id, string name, string type, string desc, bool opened, DateTime date)
        {
            UniqueID = id;
            Name = name;
            Type = type;
            Description = desc;
            Opened = opened;
            Date = date;
            EventTemplate = this;
            TimeSlots = new Dictionary<int,TimeSlot>();
        }

        #endregion

        public void addTimeSlot(TimeSlot timeslot)
        {
            TimeSlots.Add(timeslot.UniqueID,timeslot);
        }
        public void removeTimeSlot(int id)
        {
            TimeSlots.Remove(id); 
        }
    }
}
