using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LINQDemo
{
    static class SortOperators
    {
        public static void sortArray()
        {
            int[] nums = { 1, 4, 5, 6, 7, 8, 60, 10 };

            //OrderByDescending
            var _sortednums = nums.OrderByDescending(a => a);
            foreach (var item in _sortednums)
            {
                Console.WriteLine(item);
            }

            //Order By with employee collection
            List<employee> employees = new List<employee>() {
            new employee(){ ID = 101, Name= "Raghav"},
            new employee(){ ID = 101, Name= "Amit"},
            new employee(){ ID = 202, Name= "Mohan"},
            new employee(){ ID = 103, Name= "Adarsh"},
            new employee(){ ID = 505, Name= "Sushant"}
            };

            var sortedemp = employees.OrderBy(e => e.ID).ToArray();

            foreach (var item in sortedemp)
            {
                Console.WriteLine(item.Name);
            }

            //Then By : Second Level of Sorting
            var sortedemp1 = employees.OrderBy(e => e.ID).ThenBy(r => r.Name).ToArray();

            foreach (var item in sortedemp1)
            {
                Console.WriteLine(item.Name);
            }

            //Reverse
            var revnums = nums.Reverse().ToArray();

        }


    }

    public class employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string dept { get; set; }
    }

    
}
