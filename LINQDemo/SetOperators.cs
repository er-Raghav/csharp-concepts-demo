using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LINQDemo
{
    static class SetOperators
    {
        private static string[] _countriesGroupA = { "USA", "India", "UK", "India", "USA" };
        private static string[] _countriesGroupB = {  "UK", "Swizarland", "Germany", "USA" };
        

        public static void getDistinctCountries() {
            Console.WriteLine("----------Distinct Countries in Group A----------");
            var _c = _countriesGroupA.Distinct();
            foreach (var item in _c)
            {
                Console.WriteLine(item);
            }
        }

        public static void getExceptCountries()
        {
            Console.WriteLine("----------All Countries in Group A which are not present in Group B----------");
            var _c = _countriesGroupA.Except(_countriesGroupB);
            foreach (var item in _c)
            {                
                Console.WriteLine(item);
            }
        }
        public static void getInterseptCountries()
        {
            Console.WriteLine("----------All Countries common in Group A and Group B----------");
            var _c = _countriesGroupA.Intersect(_countriesGroupB);
            foreach (var item in _c)
            {
                
                Console.WriteLine(item);
            }
        }
        public static void getUnionCountries()
        {
            Console.WriteLine("----------All Countries in both Group A and Group B----------");
            var _c = _countriesGroupA.Union(_countriesGroupB);
            foreach (var item in _c)
            {                
                Console.WriteLine(item);
            }
        }

    }
}
