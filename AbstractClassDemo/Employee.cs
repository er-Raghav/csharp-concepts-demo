using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    public abstract class Employee          //Abstract Keyword
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public Employee(string a, string b) {
            Console.WriteLine("Value from Child class = " + a);
        }

        public void PrintFullName()         //Abstract class can have both Abstract and non abstract methods
        {
            Console.WriteLine("Employee Name is: " + FirstName + ", " + LastName);
        }

        public abstract void printMonthlySalary();      //Abstract Method does not contains body.

        //Abstract Method body must be given in child class.



    }


    
}
