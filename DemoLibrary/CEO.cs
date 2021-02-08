using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class CEO : BaseEmployee, IManager
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 150M;

            Salary = baseAmount * rank;
        }

        //Don't need this, just need stuff from BaseEmployee and IManager
        //public override void AssignManager(Employee manager)
        //{
        //    //this is a new exception that isn't handled by the Employee Class so it doesn't work
        //    throw new InvalidOperationException("The CEO has no manager.");
        //}

        public void GeneratePerformanceReview()
        {
            // Simulate reviewing a direct report
            Console.WriteLine("I'm reviewing a direct report's performance.");
        }

        public void FireSomeone()
        {
            // Simulate firing someone
            Console.WriteLine("You're Fired!");
        }
    }
}
