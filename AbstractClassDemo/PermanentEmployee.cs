using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    public class PermanentEmployee : Employee 
    {
        public PermanentEmployee() : base("Test","test5")           
        {
            Console.WriteLine("Permanent Class Constructor Called!");
        }
        
        public int AnnualSalary { get; set; }

        
        public override void printMonthlySalary()
        {
            Console.WriteLine("Monthly Salary = " + AnnualSalary / 12);
        }

    }
}
