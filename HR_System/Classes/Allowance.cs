using System;
using System.Collections.Generic;
using System.Text;

namespace HR_System
{
    public class Allowance
    {

        #region Properties

        // Read-Write Property for the Allowance Name
        public string Name { get; set; }

        // Read-Write Property for the amount of Allowance
        public decimal Amount { get; set; }
        #endregion

        #region Constructors

        // Default Constructor
        public Allowance()
        {
            this.Name = "";
            this.Amount = 0;
        }

        // Parameterized Constructor
        public Allowance(string name)
        {
            this.Name = name;
        }

        // Copy Constructor
        public Allowance(Allowance allow)
        {
            this.Name = allow.Name;
            // for changing
            Amount = allow.Amount;
        } 
        #endregion


    }
}
