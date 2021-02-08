using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Manager accountingVP = new Manager();
            IManager accountingVP = new Manager(); //this would work with new CEO too because 

            accountingVP.FirstName = "Emma";
            accountingVP.LastName = "Stone";
            accountingVP.CalculatePerHourRate(4);

            Console.WriteLine($"{ accountingVP.FirstName }'s salary is ${ accountingVP.Salary }/hour.");

            //Employee emp = new Employee(); //this works so no VIOLATION of Liskov Sub
            //Employee emp = new Manager(); //This works so no VIOLATION of Liskov Sub
            //Employee emp = new CEO(); //This DOES NOT work so it violates Liskov Sub

            //this works for new Employee, new Manager, and new CEO because they all inherit from BaseEmployee
            BaseEmployee emp = new CEO(); 

            emp.FirstName = "Tim";
            emp.LastName = "Corey";
            //emp.AssignManager(accountingVP);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{ emp.FirstName }'s salary is ${ emp.Salary }/hour.");

            Console.ReadLine();
        }
    }
}
