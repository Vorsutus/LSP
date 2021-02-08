using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    //We don't want to use this directly, we only want to inherit from it (so make it abstract)
    //Abstract doesn't allow direct use
    public abstract class BaseEmployee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public Employee Manager { get; set; } = null;
        public decimal Salary { get; set; }

        //public virtual void AssignManager(Employee manager)
        //{
        //    // Simulate doing other tasks here - otherwise, this should be
        //    // a property set statement, not a method.
        //    Manager = manager;
        //}

        //This probably won't change for the base employee so we leave it as virtual
        public virtual void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 12.50M;

            Salary = baseAmount + (rank * 2);
        }
    }
}
