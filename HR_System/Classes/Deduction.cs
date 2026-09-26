using System;
using System.Collections.Generic;
using System.Text;

namespace HR_System
{
    public class Deduction
    {

        #region Properties
        public string Name { get; set; }

        public decimal Amount { get; set; }
        #endregion

        #region Constructors

        // Default Constructor
        public Deduction()
        {
            this.Name = string.Empty;
            this.Amount = 0;
        }

        // Parameterized Constructor
        public Deduction(decimal amount)
        {
            this.Amount = amount;
        }

        // Copy Constructor
        public Deduction(Deduction ded)
        {
            this.Name = ded.Name;
            this.Amount = ded.Amount;
        } 

        #endregion


    }
}
