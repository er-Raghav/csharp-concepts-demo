using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
                       //Abstract class can not be instanctiated
            
            
            PermanentEmployee objperemp = new PermanentEmployee();
            objperemp.ID = 1;
            objperemp.FirstName = "Sushant";
            objperemp.LastName = "Singh";
            objperemp.AnnualSalary = 1000000;

            objperemp.PrintFullName();
            objperemp.printMonthlySalary();

            TemporaryEmployee objtemp = new TemporaryEmployee();
            objtemp.ID = 2;
            objtemp.FirstName = "Rahul";
            objtemp.LastName = "Gupta";
            objtemp.HourlyPay = 200;
            objtemp.TotalWorkHour = 300;

            objtemp.PrintFullName();
            objtemp.printMonthlySalary();

            Console.Read();

        }
    }
}
