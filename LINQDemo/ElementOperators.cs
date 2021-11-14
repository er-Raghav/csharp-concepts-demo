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
            int[] numbers = { 1, 2, 3 };
            //var n = numbers.Single(s => s % 2 == 0);
            var n1 = numbers.SingleOrDefault(s => s % 2 == 0);


            //Skip Operator
            int[] values = { 20, 30, 40, 13, 10, 60, 90, 80, 30 };

            var seq = values.Skip(4);

            foreach (var item in seq)
            {
                Console.WriteLine(item);
            }

            //SkipWhile Operator

            var skipwhileseq = values.SkipWhile(s => s % 2 == 0);       //It will skip all elemements till condition stands true

            //Take

            var takeseq = values.Take(4);


            //TakeWhile
            var takewhileseq = values.TakeWhile(s => s % 2 == 0);        //It will Take all elemements till condition stands true

        }

    }
}
