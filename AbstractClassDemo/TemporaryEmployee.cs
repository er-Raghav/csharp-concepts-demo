using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    public class TemporaryEmployee : Employee
    {
        public TemporaryEmployee() : base("test2","test5") {
            Console.WriteLine("Temp employee constructor called");
        }
        public int HourlyPay { get; set; }
        public int TotalWorkHour { get; set; }
        public override void printMonthlySalary()
        {
            Console.WriteLine("Monthly Salary = " + HourlyPay * TotalWorkHour);
        }
    }
}
