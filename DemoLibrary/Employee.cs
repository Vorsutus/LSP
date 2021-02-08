using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    //control+. to extract Interface and form IEmployee Interface from all the things that are the same in all Inheriting classes
    //Inheriting from BaseEmplyee which brings in everything that is common to all of us (first name, last name, etc.)
    //This also inherits from IEmployee (because BaseEmplyee inherits from IEmployee)
    //Also inherits from IManged
    public class Employee : BaseEmployee, IManaged
    {
        /// <summary>
        /// It is easy to get tripped up with Inheritance (is/a relationship)
        /// so it is easier to gravitate toward Interfaces. A manager is an employee, but a CEO isn't technically.
        /// An employee is assigned a manager and a CEO isn't assigned a manager (fails is/a relationship).
        /// Coming back and making new methods virtual so that you can create new inheritance VIOLATES the Open/Closed Principle too.
        /// </summary>

        //public string FirstName { get; set; } //won't need while inheriting from BaseEmplyee
        //public string LastName { get; set; } //won't need while inheriting from BaseEmplyee
        //public decimal Salary { get; set; }
        public IEmployee Manager { get; set; } = null;

        public void AssignManager(IEmployee manager)
        {
            // Simulate doing other tasks here - otherwise, this should be
            // a property set statement, not a method.
            Manager = manager;
        }

        //public virtual void CalculatePerHourRate(int rank) //won't need while inheriting from BaseEmplyee
        //{
        //    decimal baseAmount = 12.50M;

        //    Salary = baseAmount + (rank * 2);
        //}
    }
}
