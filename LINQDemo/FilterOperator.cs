using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace LINQDemo
{
    static class FilterOperator
    {
        public static void GetNames() {

            //Data Source
            string[] names = { "Raghav", "Sushant", "Shrikant", "Mohan","lion" };

            //Without LINQ
            foreach (var item in names)
            {
                if (item.Contains('a')) {
                    Console.WriteLine(item);
                }
            }

            //With LINQ Filter Operator  : Through Lamda Expressions  - Most Popular
            var namewithA = names.Where(n => n.Contains('a')).ToList();

            //With LINQ Filter Operator  : Query Expressions
            var LinqwithA = from name in names          
                            where name.Contains('a')
                            select name;
        }
    }
}
