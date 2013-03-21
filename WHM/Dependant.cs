using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WHM
{
    class Dependant
    {
        #region Fields

        public int UniqueID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Medicare { get; set; }
        public char Sexe { get; set; }
        public List<int> Appointments { get; set; }

        #endregion

        #region Constructor

        public Dependant(int id, string lastname, string firstname, int medicare, char sexe)
        {
            UniqueID = id;
            LastName = lastname;
            FirstName = firstname;
            Medicare = medicare;
            Sexe = sexe;
        }


        #endregion
    }
}
