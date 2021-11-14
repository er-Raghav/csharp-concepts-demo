using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LINQDemo
{
    static class GroupOperator
    {
        private static List<employee> emp;

        static GroupOperator() {
            emp = new List<employee>() {
            new employee(){ ID = 101, Name= "Raghav",dept= "IT"},
            new employee(){ ID = 101, Name= "Amit",dept= "HR"},
            new employee(){ ID = 202, Name= "Mohan",dept= "Admin"},
            new employee(){ ID = 103, Name= "Adarsh", dept = "IT"},
            new employee(){ ID = 505, Name= "Sushant", dept = "IT"}
            };

        }

        public static void getemployeesbydepartment() {
            var empsbydept = emp.GroupBy(a => a.dept).ToArray();

            foreach (var item in empsbydept)
            {
                Console.WriteLine(item.Key + " "+ item.Count());
            }
        
        }
    }
}
