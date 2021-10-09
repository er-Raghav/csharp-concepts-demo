using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            company objcompany = new company();     //Object Intialize

            Console.WriteLine(objcompany["Sonal"]);

            objcompany["Sonal"] = "male";

            Console.WriteLine(objcompany["Sonal"]);
            Console.Read();

        }
    }

    public class Employee
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }

    public class company
    {
        private List<Employee> lstemps;         //Declare List<Employee> variable

        public company()
        {
            lstemps = new List<Employee>();         //Object creation  Employees 

            lstemps.Add(new Employee() { EmpID = 1, Name = "Raghav", Gender = "Male" });
            lstemps.Add(new Employee() { EmpID = 2, Name = "Sushant", Gender = "Male" });
            lstemps.Add(new Employee() { EmpID = 3, Name = "Shrikant", Gender = "Male" });
            lstemps.Add(new Employee() { EmpID = 4, Name = "Sonal", Gender = "Female" });

        }


        public string this[int employeeID]
        {
            get
            {
                return lstemps.SingleOrDefault(emp => emp.EmpID == employeeID).Name;
            }
            set
            {
                lstemps.SingleOrDefault(emp => emp.EmpID == employeeID).Name = value;
            }

        }

        public string this[string empName]
        {
            get
            {
                return lstemps.SingleOrDefault(emp => emp.Name == empName).Gender;
            }
            set
            {
                lstemps.SingleOrDefault(emp => emp.Name == empName).Gender = value;
            }

        }


    }
}
