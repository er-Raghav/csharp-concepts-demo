using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory obj1 = new Inventory();
            obj1.Name = "Baleno";
            obj1.TotalNumber = 25;
            obj1.comments = "Unit Delivered on 09/01/2021 ";


            Inventory obj2 = new Inventory();
            obj2.Name = "Baleno";
            obj2.TotalNumber = 15;
            obj2.comments = "Units Delivered on 09/05/2021 ";


            Inventory obj3 = new Inventory();
            obj3.Name = "Baleno";
            obj3.TotalNumber = 55;
            obj3.comments = "Units Delivered on 08/05/2021 ";

            Inventory obj4 = (obj1 + obj2) + obj3;

            Console.WriteLine(obj4.TotalNumber);
            Console.WriteLine(obj4.comments);
            Console.Read();

        }
    }


    public class Inventory {
        public int TotalNumber { get; set; }
        public string Name { get; set; }
        public string comments { get; set; }


        // Operator Overloading

        //
        public static Inventory operator +(Inventory obj1, Inventory obj2) {
            Inventory obj3 = new Inventory();
            obj3.Name = obj1.Name;
            obj3.TotalNumber = obj1.TotalNumber + obj2.TotalNumber;
            obj3.comments = obj1.comments + obj2.comments;
            return obj3;
            
        }


    }





}
