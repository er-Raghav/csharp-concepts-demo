using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LINQDemo
{
    static class AggregateOperators
    {
        static int[] nums = { 3, 4, 5, 3, 21, 23, 7 };

        

        public static void getsum()
        {
            Console.WriteLine(nums.Sum());
        }

        public static void getminimum()
        {
            Console.WriteLine(nums.Min());
        }


        public static void getmaximum()
        {
            Console.WriteLine(nums.Max());
        }

        public static void getaverage()
        {
            Console.WriteLine(nums.Average());
        }
    }
}
