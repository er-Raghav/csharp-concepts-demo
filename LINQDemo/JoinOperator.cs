using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LINQDemo
{
    static class JoinOperator
    {
        //Join operator Joins two sequences based on a key

        public static void getemployeewithdept()
        {
            //[Outer Sequence].Join([Inner Sequence], [Outer Sequence Key], [Inner Sequence Key]
            var records = employeerecord.GetEmployeerecords().Join(dept.GetDepts(), e => e.deptID, d => d.ID, (emp, department) => new
            {
                emp.empNum,
                emp.Name,

                department.DeptName
            });

            Console.WriteLine("----Get Employee with Department Name --- JOIN Operator----");
            foreach (var item in records)
            {
                Console.WriteLine($"Employee Name: {item.Name}  Department:{item.DeptName}");
            }


        }
    }


    public class employeerecord
    {

        public int empNum { get; set; }
        public string Name { get; set; }

        public int deptID { get; set; }


        public static List<employeerecord> GetEmployeerecords()
        {

            return new List<employeerecord>() {
                new employeerecord() {empNum=1,Name="Amit",deptID =1 },
                new employeerecord() {empNum=2,Name="Mohan",deptID =2 },
                new employeerecord() {empNum=3,Name="Kapil",deptID =3 },
                new employeerecord() {empNum=4,Name="Tina",deptID =1 },
                new employeerecord() {empNum=5,Name="Meena",deptID =1 },
                new employeerecord() {empNum=6,Name="Naveen",deptID =2 },
                new employeerecord() {empNum=7,Name="Gautam",deptID =3 },
                new employeerecord() {empNum=8,Name="Rohit",deptID =2 }
            };


        }
    }

    public class dept
    {
        public int ID { get; set; }
        public string DeptName { get; set; }


        public static List<dept> GetDepts()
        {
            return new List<dept>()
            {
                new dept(){ ID=1,DeptName="IT"},
                new dept(){ ID=2,DeptName="Admin"},
                new dept(){ ID=3,DeptName="HR"}
            };

        }
    }

}
