using System;
using System.Collections.Generic;
using System.Text;

namespace HR_System
{
    public class Vacation
    {

        #region Properties
        public DateTime startDate { get; set; }

        public DateTime endDate { get; set; }

        public string Type { get; set; }

        public int DaysCount { get; set; }

        #endregion

        #region Constructors

        // Default Constructor
        public Vacation()
        {

        }

        // Copy Constructor
        public Vacation(Vacation vac)
        {
            this.startDate = vac.startDate;
            this.endDate = vac.endDate;
            this.Type = vac.Type;
            this.DaysCount = vac.DaysCount;
        } 

        #endregion


    }
}
