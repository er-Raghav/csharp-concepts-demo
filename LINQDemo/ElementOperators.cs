using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace LINQDemo
{
    static class ElementOperators
    {
        static List<employee> emp;
        static ElementOperators()
        {
            emp = new List<employee>() {
            new employee(){ ID = 101, Name= "Raghav",dept= "IT"},
            new employee(){ ID = 101, Name= "Amit",dept= "HR"},
            new employee(){ ID = 202, Name= "Mohan",dept= "Admin"},
            new employee(){ ID = 103, Name= "Adarsh", dept = "IT"},
            new employee(){ ID = 505, Name= "Sushant", dept = "IT"}
            };
        }
        public static void getemployee()
        {
            //Get First Employee from IT - It will though Exception
            var firstemp = emp.Where(a => a.dept == "HR").First();

            Console.WriteLine(firstemp.Name);

            //FirstOrDefault - It will not through Exception if no data returned from LINQ query
            var firstemp1 = emp.Where(a => a.dept == "Payroll").FirstOrDefault();


            //Single
            var singlename = emp.Where(a => a.dept == "Payroll").Single(b => b.dept =="HR");
        }

    }
}
